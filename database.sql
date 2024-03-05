create database vanthu_database;

use vanthu_database;

create table DonVis
(
	MaDonVi int identity(1,1) primary key,
	TenDonVi nvarchar(255)
);

create table Nams
(
	Nam int primary key
);

create table DonVi_Nam
(
	Id int identity(1,1) primary key,
	MaDonVi int references DonVis(MaDonVi),
	Nam int references Nams(Nam)
);

create table VanBanDens
(
	SoDen varchar(50) primary key,
	SoKyHieu varchar(100),
	TrichYeuNoiDung text,
	LoaiVanBan nvarchar(100),
	CoQuanBanHanh nvarchar(100),
	NgayBanHanh date,
	NgayDen date,
	NgayXuLy date,
	NoiNhan nvarchar(255),
	NguoiNhan nvarchar(255),
	DoMat nvarchar(100),
	DoKhan nvarchar(100),
	TepTuLieu varchar(255),
	MaDonVi int references DonVis(MaDonVi)
);

create table VanBanDis
(
	SoDi varchar(50) primary key,
	SoKyHieu varchar(100),
	TrichYeuNoiDung text,
	LoaiVanBan nvarchar(100),
	DonViBanHanh nvarchar(100),
	NgayBanHanh date,
	NoiNhan nvarchar(255),
	NgayXuLy date,
	TepTuLieu varchar(255),
	MaDonVi int references DonVis(MaDonVi)
);