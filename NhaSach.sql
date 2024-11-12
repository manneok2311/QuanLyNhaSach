CREATE DATABASE NhaSach;
USE NhaSach;

CREATE TABLE LoaiSach (
    MaLoaiSach INT PRIMARY KEY,
    TenLoaiSach NVARCHAR(100),
    MoTa NVARCHAR(255)
);

CREATE TABLE Sach (
    MaSach INT PRIMARY KEY,
    TenSach NVARCHAR(255),
    TacGia NVARCHAR(100),
    GiaBan DECIMAL(18, 2),
    SoLuong INT,
    MoTa NVARCHAR(255),
    MaLoaiSach INT FOREIGN KEY REFERENCES LoaiSach(MaLoaiSach)
);

CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY,
    TenKhachHang NVARCHAR(100),
    DiaChi NVARCHAR(255),
    SoDienThoai NVARCHAR(20),
    Email NVARCHAR(100)
);

CREATE TABLE HoaDon (
    MaHoaDon INT PRIMARY KEY,
    NgayLap DATETIME,
    MaKhachHang INT FOREIGN KEY REFERENCES KhachHang(MaKhachHang)
);

CREATE TABLE ChiTietHoaDon (
    MaChiTietHoaDon INT PRIMARY KEY,
    MaHoaDon INT FOREIGN KEY REFERENCES HoaDon(MaHoaDon),
    MaSach INT FOREIGN KEY REFERENCES Sach(MaSach),
    SoLuong INT,
    DonGia DECIMAL(18, 2)
);
insert into LoaiSach(MaLoaiSach,TenLoaiSach,MoTa)
values  ('01',N'Loại sách 01',N'Mô tả loại sách 01'),
		('02',N'Loại sách 02',N'Mô tả loại sách 02'),
		('03',N'Loại sách 03',N'Mô tả loại sách 03');
insert into Sach(MaSach,TenSach,TacGia,GiaBan,SoLuong,MoTa,MaLoaiSach)
values  ('01',N'Sách 01',N'Tác giả 01',30.000,20,N'Mô tả sách 01','03'),
		('02',N'Sách 02',N'Tác giả 02',45.000,30,N'Mô tả sách 02','01'),
		('03',N'Sách 03',N'Tác giả 03',10.000,25,N'Mô tả sách 00','02');
insert into KhachHang(MaKhachHang,TenKhachHang,DiaChi,SoDienThoai,Email)
values  ('01',N'Khách hàng 01',N'Tên khách hàng 01',N'Địa chỉ 01',N'Email 01'),
		('02',N'Khách hàng 02',N'Tên khách hàng 02',N'Địa chỉ 02',N'Email 02'),
		('03',N'Khách hàng 03',N'Tên khách hàng 03',N'Địa chỉ 03',N'Email 03');
insert into HoaDon(MaHoaDon,NgayLap,MaKhachHang)
values  ('01','20241111','02'),
		('02','20241112','03'),
		('03','20241024','01');
insert into ChiTietHoaDon(MaChiTietHoaDon,MaHoaDon,MaSach,SoLuong,DonGia)
values  ('01','02','01',10,30.000),
		('02','01','03',12,40.000),
		('03','03','02',09,50.000);