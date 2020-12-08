create database QuanAoBaoChau

create table TinTuc (
MaTinTuc int not null IDENTITY(1,1) PRIMARY KEY,
TieuDe nvarchar(200) not null,
NoiDung text not null,
LinkAnh nvarchar(200) not null,
)

create table LoaiSanPham (
MaLoai int not null IDENTITY(1,1) PRIMARY KEY,
TenLoai nvarchar(200) not null,
)

create table SanPham(
MaSanPham int not null IDENTITY(1,1) PRIMARY KEY,
TenSanPham nvarchar(100) not null,
MoTa text,
Gia int not null,
SoLuongCon int not null,
XuatXu nvarchar(20),
Hang nvarchar(20),
SoLuotXem int not null,
MaLoaiSanPham int  references LoaiSanPham(MaLoai),
TinhTrang int
)

create table HinhAnh(
  MaHinhAnh int not null IDENTITY(1,1) PRIMARY KEY,
  LinkAnh nvarchar(200) not null,
  MaSanPham int references SanPham(MaSanPham)
)

create table DonHang(
MaDonHang int not null IDENTITY(1,1) PRIMARY KEY,
HoTen nvarchar(100) not null,
DiaChi nvarchar(100) not null,
Email nvarchar(100) not null,
SoDienThoai nvarchar(100) not null,
TongTien int
)

create table ChiTietDonHang(
MaChiTietDonHang int not null IDENTITY(1,1) PRIMARY KEY,
MaSanPham int not null references SanPham(MaSanPham) ,
SoLuongMua nvarchar(100) not null,
MaDonHang int not null references DonHang(MaDonHang)
)