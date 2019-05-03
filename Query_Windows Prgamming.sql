use master

drop database if exists QuanLyCaPhe
	
create database QuanLyCaPhe

use QuanLyCaPhe

drop table if exists KhachHang
drop table if exists NhanVien
drop table if exists NhanVienPhucVu
drop table if exists NhanvienThuNgan
drop table if exists NhanVienQuanLy
drop table if exists ThanhPho

create table KhachHang (
	MaKH varchar(20) not null,
	HoKH varchar(20),
	TenKH varChar(20),
	NgaySinh datetime,
	SDT varchar(20),
	DiaChi varchar(30),
	primary key(MaKH)
)

create table NhanVien(
	MaNV varchar(20) not null,
	HoNV varchar(20),
	TenNV varchar(20),
	NgaySinh datetime,
	SDT varchar(20),
	DiaChi varchar(30),
	NgayBD datetime,
	primary key(MaNV)
)

create table ThanhPho (
	MaThanhPho varchar(10),
	TenThanhPho varchar(20),
	primary key(MaThanhPho)
)

delete from KhachHang
delete from  NhanVien
--delete from  NhanVienPhucVu
--delete from  NhanvienThuNgan
--delete from  NhanVienQuanLy
delete from ThanhPho