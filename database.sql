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


insert into DonVis(TenDonVi)
values
(N'Viện kiểm sát nhân dân tỉnh Phú Yên'),
(N'Viện kiểm sát nhân dân Thị xã Đông Hòa'),
(N'Viện kiểm sát nhân dân huyện Đồng Xuân'),
(N'Viện kiểm sát nhân dân huyện Phú Hòa'),
(N'Viện kiểm sát nhân dân huyện Sơn Hòa'),
(N'Viện kiểm sát nhân dân Thị xã Sông Cầu'),
(N'Viện kiểm sát nhân dân huyện Sông Hinh'),
(N'Viện kiểm sát nhân dân huyện Tây Hòa'),
(N'Viện kiểm sát nhân dân huyện Tuy An'),
(N'Viện kiểm sát nhân dân Thành phố Tuy Hòa');

insert into Nams
values
(2024),
(2025),
(2026),
(2027);

insert into DonVi_Nam(MaDonVi, Nam)
values
(1, 2024),
(1, 2025),
(1, 2026),
(1, 2027),
(2, 2024),
(2, 2025),
(2, 2026),
(2, 2027),
(3, 2024),
(3, 2025),
(3, 2026),
(3, 2027),
(4, 2024),
(4, 2025),
(4, 2026),
(4, 2027),
(5, 2024),
(5, 2025),
(5, 2026),
(5, 2027);