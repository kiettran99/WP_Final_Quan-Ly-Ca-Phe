	
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
	MatKhau varchar(20)
	primary key(TaiKhoan)
)

create table ThanhPho (
	MaThanhPho int,
	TenThanhPho varchar(20),
	primary key(TenThanhPho)
)

delete from KhachHang
delete from  NhanVien
delete from ThanhPho
delete from DangNhap

insert into KhachHang values('KH1', 'Nguyen Xuan', 'Huy', 'Nam', '1997-12-05', '0904567841', '92 Hai Ba Trung Ho Chi Minh')

