﻿use master
drop database if exists QuanLyCaPhe
create database QuanLyCaPhe
go
use QuanLyCaPhe

go

create table KhachHang (
	MaKH varchar(20) not null,
	HoKH varchar(20),
	TenKH varChar(20),
	GioiTinh varchar(10),
	NgaySinh date,
	SDT varchar(20),
	DiaChi varchar(30),
	primary key(MaKH)
)

create table NhanVien(
	MaNV varchar(20) not null,
	HoNV varchar(20),
	TenNV varchar(20),
	Nu		bit,
	NgaySinh date,
	SDT varchar(20),
	DiaChi varchar(30),
	NgayBD datetime,

	primary key(MaNV)
)

create table DangNhap(
	TaiKhoan varchar(20),
	MatKhau varchar(20),
	MaNV varchar(20),
	primary key(TaiKhoan)
)

create table ThanhPho (
	MaThanhPho int,
	TenThanhPho varchar(20),
	primary key(TenThanhPho)
)

create table BanAn(
	IDBanAn int not null,					
	TenBan nvarchar(100) not null default N'Không có tên',
	TinhTrang nvarchar(100) not null default N'Trống',	-- Ban dang trong hay dang nguoi
	primary key (IDBanAn)
)

create table LoaiThucAn(
	IDLoaiThucAn int not null,
	TenLoaiThucAn nvarchar(100) not null default N'Không có tên',
	primary key (IDLoaiThucAn)
)


create table ThucAn(
	IDThucAn int not null,
	TenThucAn nvarchar(100) not null default N'Không có tên',
	IDLoaiThucAn int not null,
	Gia float default 0,
	primary key (IDThucAn),
	foreign key (IDLoaiThucAn) references LoaiThucAn(IDLoaiThucAn)
)

create table HoaDon(
	IDHoaDon int not null,
	NgayTaoHoaDon datetime not null,
	NgayKetThucHoaDon datetime,
	IDBanAn int not null,
	TinhTrang bit not null default 0, -- Tinh trang thanh toan hoa don
	primary key (IDHoaDon),
	foreign key (IDBanAn) references BanAn(IDBanAn)
)

--Hoa don (n,n) ThucAn
create table ChiTietHoaDon(
	IDHoaDon int not null,
	IDThucAn int not null,
	SoLuong int not null default 0 ,
	primary key (IDHoaDon, IDThucAn),
	foreign key (IDHoaDon) references HoaDon(IDHoaDon),
	foreign key (IDThucAn) references ThucAn(IDThucAn)
)

delete from KhachHang
delete from  NhanVien
delete from ThanhPho
delete from DangNhap


insert into KhachHang values('KH1', 'Nguyen Xuan', 'Huy', 'Nam', '1997-12-05', '0904567841', '92 Hai Ba Trung Ho Chi Minh')
Select MaNV From DangNhap where TaiKhoan='admin';
Select TaiKhoan From DangNhap where MaNV = '1';

delete from BanAn
delete from LoaiThucAn
delete from ThucAn

/*
--Query Tạo csdl bàn ăn
declare @i int = 0

while @i <= 20
begin
	insert into BanAn(IDBanAn, TenBan) 
	values(cast(@i as nvarchar(100)) , N'Bàn' + cast(@i as nvarchar(100)))
	set @i = @i + 1
end

select * from BanAn

--Tạo CSDL Thức Ăn

declare @iCFood int = 0

while @iCFood <= 20
begin
	insert into LoaiThucAn values(cast(@iCFood as int), N'Loại ' + cast(@iCFood as nvarchar(100)))
	set @iCFood = @iCFood + 1
end

select * from LoaiThucAn

declare @iFood int = 0
while @iFood <= 20
begin
	insert into ThucAn values(cast(@iFood as int), N'Thức ăn  ' + cast(@iFood as nvarchar(100)),cast(@iFood as int) , cast(@iFood * 20000 as nvarchar(100)))
	set @iFood = @iFood + 1
end

select * from ThucAn

insert into BanAn values(21, 'Bàn thứ 21', 'Không trống')
*/

-- thêm category

--Query Tạo csdl bàn ăn
declare @i int = 0

while @i <= 20
begin
	insert into BanAn(IDBanAn, TenBan) 
	values(cast(@i as nvarchar(100)) , N'Bàn' + cast(@i as nvarchar(100)))
	set @i = @i + 1
end

select * from BanAn

INSERT LoaiThucAn     
VALUES  ( 1 , N'Hải sản'
          )
INSERT LoaiThucAn
VALUES  ( 2, N'Nông sản' )

INSERT LoaiThucAn
VALUES  ( 3, N'Lâm sản' )

INSERT LoaiThucAn
VALUES  ( 4, N'Sản sản' )

INSERT LoaiThucAn
VALUES  (5, N'Nước' )

-- thêm món ăn
INSERT ThucAn
VALUES  ( 1, N'Mực một nắng nước sa tế', 
          1, -- idCategory - int
          120000)
INSERT ThucAn
VALUES  ( 2, N'Nghêu hấp xả', 1, 50000)
INSERT ThucAn
VALUES  ( 3, N'Dú dê nướng sữa', 2, 60000)
INSERT ThucAn
VALUES  ( 4, N'Heo rừng nướng muối ớt', 3, 75000)
INSERT ThucAn
VALUES  ( 5, N'Cơm chiên mushi', 4, 999999)
INSERT ThucAn
VALUES  ( 6, N'7Up', 5, 15000)
INSERT ThucAn
VALUES  ( 7, N'Cafe', 5, 12000)

-- thêm bill
INSERT	HoaDon
VALUES  ( 5,
			GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          3 , -- idTable - int
          1  -- status - int
        )
        
INSERT	HoaDon
VALUES  (6, GETDATE() , -- DateCheckIn - date
          NULL , -- DateCheckOut - date
          4, -- idTable - int
          1  -- status - int
        )
INSERT	HoaDon
VALUES  (7, GETDATE() , -- DateCheckIn - date
          GETDATE() , -- DateCheckOut - date
          5 , -- idTable - int
          1  -- status - int
        )

-- thêm bill infoHoaDon
INSERT	ChiTietHoaDon
VALUES  ( 5, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )
INSERT	ChiTietHoaDon
VALUES  ( 5, -- idBill - int
          3, -- idFood - int
          4  -- count - int
          )
INSERT	ChiTietHoaDon
VALUES  ( 5, -- idBill - int
          5, -- idFood - int
          1  -- count - int
          )
INSERT	ChiTietHoaDon
VALUES  ( 6, -- idBill - int
          1, -- idFood - int
          2  -- count - int
          )
INSERT	ChiTietHoaDon
VALUES  ( 6, -- idBill - int
          6, -- idFood - int
          2  -- count - int
          )
INSERT	ChiTietHoaDon
VALUES  ( 7, -- idBill - int
          5, -- idFood - int
          2  -- count - int
          )
Update HoaDon set TinhTrang =1 where IDHoaDon = 11