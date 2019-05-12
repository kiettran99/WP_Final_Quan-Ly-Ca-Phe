--use master
--drop database if exists QuanLyCaPhe
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
	TenBan nvarchar(100) not null,
	TinhTrang nvarchar(100) not null,	-- Ban dang trong hay dang nguoi
	primary key (IDBanAn)
)

create table LoaiThucAn(
	IDLoaiThucAn int not null,
	TenLoaiThucAn nvarchar(100) not null,
	primary key (IDLoaiThucAn)
)


create table ThucAn(
	IDThucAn int not null,
	TenThucAn nvarchar(100) not null,
	IDLoaiThucAn int not null,
	Gia float,
	primary key (IDThucAn),
	foreign key (IDLoaiThucAn) references LoaiThucAn(IDLoaiThucAn)
)

create table HoaDon(
	IDHoaDon int not null,
	NgayTaoHoaDon datetime not null,
	NgayKetThucHoaDon datetime,
	IDBanAn int not null,
	TinhTrang bit not null, -- Tinh trang thanh toan hoa don
	primary key (IDHoaDon),
	foreign key (IDBanAn) references BanAn(IDBanAn)
)

--Hoa don (n,n) ThucAn
create table ChiTietHoaDon(
	IDHoaDon int not null,
	IDThucAn int not null,
	SoLuong int default 0 not null,
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
