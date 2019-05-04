use master

drop database if exists QuanLyCaPhe
	
create database QuanLyCaPhe

use QuanLyCaPhe

drop table if exists KhachHang
drop table if exists NhanVien
drop table if exists ThanhPho
drop table if exists DangNhap

create table KhachHang (
	MaKH varchar(20) not null,
	HoKH varchar(20),
	TenKH varChar(20),
	NgaySinh date,
	SDT varchar(20),
	DiaChi varchar(30),
	primary key(MaKH)
)

create table NhanVien(
	MaNV varchar(20) not null,
	HoNV varchar(20),
	TenNV varchar(20),
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
	MaThanhPho varchar(10),
	TenThanhPho varchar(20),
	primary key(MaThanhPho)
)

delete from KhachHang
delete from  NhanVien
delete from ThanhPho
delete from DangNhap

insert into KhachHang values('KH1', 'Nguyen Xuan', 'Huy', '1997-12-05', '0904567841', '92 Hai Ba Trung Ho Chi Minh')

