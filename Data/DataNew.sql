USE [master]
GO
/****** Object:  Database [Data_CardOfBank]    Script Date: 7/8/2022 1:55:07 PM ******/
CREATE DATABASE [Data_CardOfBank]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Data_CardOfBank', FILENAME = N'D:\Working\Project\ProjectDoing\ProjectDoing\QuanLyTheNganHang\Data\Data_CardOfBank.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Data_CardOfBank_log', FILENAME = N'D:\Working\Project\ProjectDoing\ProjectDoing\QuanLyTheNganHang\Data\Data_CardOfBank_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Data_CardOfBank] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Data_CardOfBank].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Data_CardOfBank] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET ARITHABORT OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Data_CardOfBank] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Data_CardOfBank] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Data_CardOfBank] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Data_CardOfBank] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Data_CardOfBank] SET  MULTI_USER 
GO
ALTER DATABASE [Data_CardOfBank] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Data_CardOfBank] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Data_CardOfBank] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Data_CardOfBank] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Data_CardOfBank] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Data_CardOfBank] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Data_CardOfBank] SET QUERY_STORE = OFF
GO
USE [Data_CardOfBank]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[maCV] [nchar](10) NOT NULL,
	[tenCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[maCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiaDiemKD]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiaDiemKD](
	[maDdKD] [nchar](20) NOT NULL,
	[tenDiaDiem] [nvarchar](50) NULL,
	[diaChi] [nvarchar](200) NULL,
 CONSTRAINT [PK_DiaDiemDK] PRIMARY KEY CLUSTERED 
(
	[maDdKD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoSoTinDung]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSoTinDung](
	[maHoSo] [nchar](20) NOT NULL,
	[maKH] [nchar](10) NULL,
	[maTkKH] [nchar](10) NULL,
	[maNV] [nchar](10) NULL,
	[maDdKD] [nchar](20) NULL,
	[hinhAnhHS] [xml] NULL,
 CONSTRAINT [PK_HoSoTinDung] PRIMARY KEY CLUSTERED 
(
	[maHoSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[maKH] [nchar](10) NOT NULL,
	[hoKH] [nvarchar](10) NULL,
	[tenKH] [nvarchar](10) NULL,
	[ngaySinh] [date] NULL,
	[diaChi] [nvarchar](200) NULL,
	[email] [nchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[sCCCD] [nchar](13) NULL,
	[ghiChu] [nvarchar](50) NULL,
	[malKH] [nchar](10) NULL,
	[maNV] [nchar](10) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[maKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiKH]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKH](
	[malKH] [nchar](10) NOT NULL,
	[tenLoaiKH] [nvarchar](50) NULL,
	[utl] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiKH] PRIMARY KEY CLUSTERED 
(
	[malKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiThe]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThe](
	[mlThe] [nchar](10) NOT NULL,
	[tenLT] [nvarchar](70) NULL,
	[hanMucThauChi] [money] NULL,
	[thoiGianTra] [date] NULL,
	[laiSuat] [float] NULL,
 CONSTRAINT [PK_LoaiThe] PRIMARY KEY CLUSTERED 
(
	[mlThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTK]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTK](
	[maLoaiTK] [nchar](10) NOT NULL,
	[tenLoaiTk] [nvarchar](70) NULL,
 CONSTRAINT [PK_LoaiTK] PRIMARY KEY CLUSTERED 
(
	[maLoaiTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNV] [nchar](10) NOT NULL,
	[hoNV] [nvarchar](10) NULL,
	[tenNV] [nvarchar](10) NULL,
	[ngaySinh] [date] NULL,
	[diaChi] [nvarchar](100) NULL,
	[email] [nchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[sCCCD] [nchar](13) NULL,
	[maPB] [nchar](10) NULL,
	[maCV] [nchar](10) NULL,
	[maDdKD] [nchar](20) NULL,
	[matKhau] [nchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[maPB] [nchar](10) NOT NULL,
	[tenPB] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[maPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoanKH]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoanKH](
	[maTkKH] [nchar](10) NOT NULL,
	[maKH] [nchar](10) NULL,
	[soDu] [money] NULL,
	[ngayMo] [date] NULL,
	[maLoaiTK] [nchar](10) NULL,
	[maDdKD] [nchar](20) NULL,
 CONSTRAINT [PK_TaiKhoanKH] PRIMARY KEY CLUSTERED 
(
	[maTkKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiSanTC]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiSanTC](
	[maTS] [nchar](20) NOT NULL,
	[tenTaiSanTC] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiSanTC] PRIMARY KEY CLUSTERED 
(
	[maTS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheTinDung]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheTinDung](
	[maTheTD] [nchar](10) NOT NULL,
	[maKH] [nchar](10) NULL,
	[mlThe] [nchar](10) NULL,
	[maTkKH] [nchar](10) NULL,
	[ngayMo] [date] NULL,
	[ngayHetHan] [date] NULL,
	[maTS] [nchar](20) NULL,
	[maPin] [nchar](5) NULL,
	[soThanhToan] [money] NULL,
 CONSTRAINT [PK_TheTinDung] PRIMARY KEY CLUSTERED 
(
	[maTheTD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChucVu] ([maCV], [tenCV]) VALUES (N'NV        ', N'Nhân viên')
INSERT [dbo].[ChucVu] ([maCV], [tenCV]) VALUES (N'TP        ', N'Trưởng phòng')
GO
INSERT [dbo].[DiaDiemKD] ([maDdKD], [tenDiaDiem], [diaChi]) VALUES (N'BD_TA               ', N'Thuận An', N'Bình Dương')
INSERT [dbo].[DiaDiemKD] ([maDdKD], [tenDiaDiem], [diaChi]) VALUES (N'BD_TDM              ', N'TP. Thủ Dầu Một ', N'Bình Dương')
INSERT [dbo].[DiaDiemKD] ([maDdKD], [tenDiaDiem], [diaChi]) VALUES (N'BD_TU               ', N'Tân Uyên', N'Bình Dương')
GO
INSERT [dbo].[NhanVien] ([maNV], [hoNV], [tenNV], [ngaySinh], [diaChi], [email], [SDT], [sCCCD], [maPB], [maCV], [maDdKD], [matKhau]) VALUES (N'ABC217    ', N'Phạm', N'Minh', CAST(N'1991-01-03' AS Date), N'Bến cát', N'ABC217@abank.vn                                   ', N'0966604027', N'932391145499 ', N'PKD       ', N'NV        ', N'BD_TU               ', N'123       ')
INSERT [dbo].[NhanVien] ([maNV], [hoNV], [tenNV], [ngaySinh], [diaChi], [email], [SDT], [sCCCD], [maPB], [maCV], [maDdKD], [matKhau]) VALUES (N'ABC228    ', N'Trần', N'Tuấn', CAST(N'1992-03-09' AS Date), N'TP. Thủ Dầu Một', N'ABC228@abank.vn                                   ', N'0937017035', N'676512707194 ', N'PKD       ', N'NV        ', N'BD_TU               ', N'234       ')
INSERT [dbo].[NhanVien] ([maNV], [hoNV], [tenNV], [ngaySinh], [diaChi], [email], [SDT], [sCCCD], [maPB], [maCV], [maDdKD], [matKhau]) VALUES (N'ABC229    ', N'Lê', N'Long', CAST(N'2000-11-10' AS Date), N'TP. Thủ Dầu Một', N'ABC229@abank.vn                                   ', N'0941237585', N'547575337621 ', N'PDV       ', N'NV        ', N'BD_TU               ', N'345       ')
INSERT [dbo].[NhanVien] ([maNV], [hoNV], [tenNV], [ngaySinh], [diaChi], [email], [SDT], [sCCCD], [maPB], [maCV], [maDdKD], [matKhau]) VALUES (N'ABC487    ', N'Hứa', N'Mai', CAST(N'1989-10-12' AS Date), N'Tân uyên', N'ABC487@abank.vn                                   ', N'0374799681', N'821802090865 ', N'PDV       ', N'TP        ', N'BD_TU               ', N'456       ')
INSERT [dbo].[NhanVien] ([maNV], [hoNV], [tenNV], [ngaySinh], [diaChi], [email], [SDT], [sCCCD], [maPB], [maCV], [maDdKD], [matKhau]) VALUES (N'ABC583    ', N'Phạm', N'Trang', CAST(N'1990-01-19' AS Date), N'Phú giáo', N'ABC583@abank.vn                                   ', N'0945881905', N'478523167989 ', N'PKD       ', N'TP        ', N'BD_TU               ', N'567       ')
INSERT [dbo].[NhanVien] ([maNV], [hoNV], [tenNV], [ngaySinh], [diaChi], [email], [SDT], [sCCCD], [maPB], [maCV], [maDdKD], [matKhau]) VALUES (N'ABC648    ', N'Đặng', N'Hiếu', CAST(N'1999-09-20' AS Date), N'Thuận an', N'ABC648@abank.vn                                   ', N'0966372385', N'646372155369 ', N'PKD       ', N'NV        ', N'BD_TU               ', N'789       ')
INSERT [dbo].[NhanVien] ([maNV], [hoNV], [tenNV], [ngaySinh], [diaChi], [email], [SDT], [sCCCD], [maPB], [maCV], [maDdKD], [matKhau]) VALUES (N'ABC703    ', N'Lý', N'Hòa', CAST(N'1998-02-02' AS Date), N'Tân uyên', N'ABC703@abank.vn                                   ', N'0838428972', N'397284955878 ', N'PKD       ', N'NV        ', N'BD_TU               ', N'678       ')
INSERT [dbo].[NhanVien] ([maNV], [hoNV], [tenNV], [ngaySinh], [diaChi], [email], [SDT], [sCCCD], [maPB], [maCV], [maDdKD], [matKhau]) VALUES (N'ABC855    ', N'Trịnh', N'Sơn', CAST(N'1992-12-25' AS Date), N'Phú giáo', N'ABC855@abank.vn                                   ', N'0919723524', N'314917569993 ', N'PKD       ', N'NV        ', N'BD_TU               ', N'890       ')
INSERT [dbo].[NhanVien] ([maNV], [hoNV], [tenNV], [ngaySinh], [diaChi], [email], [SDT], [sCCCD], [maPB], [maCV], [maDdKD], [matKhau]) VALUES (N'ABC951    ', N'Nguyễn', N'Lan', CAST(N'1990-01-01' AS Date), N'HCM', N'ABC951@abank.vn                                   ', N'0937057757', N'822857044314 ', N'PDV       ', N'NV        ', N'BD_TU               ', N'098       ')
INSERT [dbo].[NhanVien] ([maNV], [hoNV], [tenNV], [ngaySinh], [diaChi], [email], [SDT], [sCCCD], [maPB], [maCV], [maDdKD], [matKhau]) VALUES (N'ABC990    ', N'Hoàng', N'Bình', CAST(N'1995-01-30' AS Date), N'Dĩ an', N'ABC990@abank.vn                                   ', N'0365722364', N'558693119211 ', N'PDV       ', N'NV        ', N'BD_TU               ', N'190       ')
GO
INSERT [dbo].[PhongBan] ([maPB], [tenPB]) VALUES (N'PDV       ', N'Phòng dịch vụ')
INSERT [dbo].[PhongBan] ([maPB], [tenPB]) VALUES (N'PHT       ', N'Phòng hỗ trợ')
INSERT [dbo].[PhongBan] ([maPB], [tenPB]) VALUES (N'PKD       ', N'Phòng kinh doanh')
INSERT [dbo].[PhongBan] ([maPB], [tenPB]) VALUES (N'PQTRR     ', N'Phòng quản trị rủi ro')
GO
ALTER TABLE [dbo].[HoSoTinDung]  WITH CHECK ADD  CONSTRAINT [FK_HoSoTinDung_DiaDiemKD] FOREIGN KEY([maDdKD])
REFERENCES [dbo].[DiaDiemKD] ([maDdKD])
GO
ALTER TABLE [dbo].[HoSoTinDung] CHECK CONSTRAINT [FK_HoSoTinDung_DiaDiemKD]
GO
ALTER TABLE [dbo].[HoSoTinDung]  WITH CHECK ADD  CONSTRAINT [FK_HoSoTinDung_KhachHang] FOREIGN KEY([maKH])
REFERENCES [dbo].[KhachHang] ([maKH])
GO
ALTER TABLE [dbo].[HoSoTinDung] CHECK CONSTRAINT [FK_HoSoTinDung_KhachHang]
GO
ALTER TABLE [dbo].[HoSoTinDung]  WITH CHECK ADD  CONSTRAINT [FK_HoSoTinDung_NhanVien] FOREIGN KEY([maNV])
REFERENCES [dbo].[NhanVien] ([maNV])
GO
ALTER TABLE [dbo].[HoSoTinDung] CHECK CONSTRAINT [FK_HoSoTinDung_NhanVien]
GO
ALTER TABLE [dbo].[HoSoTinDung]  WITH CHECK ADD  CONSTRAINT [FK_HoSoTinDung_TaiKhoanKH] FOREIGN KEY([maTkKH])
REFERENCES [dbo].[TaiKhoanKH] ([maTkKH])
GO
ALTER TABLE [dbo].[HoSoTinDung] CHECK CONSTRAINT [FK_HoSoTinDung_TaiKhoanKH]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiKH] FOREIGN KEY([malKH])
REFERENCES [dbo].[LoaiKH] ([malKH])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiKH]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_NhanVien] FOREIGN KEY([maNV])
REFERENCES [dbo].[NhanVien] ([maNV])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([maCV])
REFERENCES [dbo].[ChucVu] ([maCV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_DiaDiemKD] FOREIGN KEY([maDdKD])
REFERENCES [dbo].[DiaDiemKD] ([maDdKD])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_DiaDiemKD]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([maPB])
REFERENCES [dbo].[PhongBan] ([maPB])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
ALTER TABLE [dbo].[TaiKhoanKH]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanKH_DiaDiemKD] FOREIGN KEY([maDdKD])
REFERENCES [dbo].[DiaDiemKD] ([maDdKD])
GO
ALTER TABLE [dbo].[TaiKhoanKH] CHECK CONSTRAINT [FK_TaiKhoanKH_DiaDiemKD]
GO
ALTER TABLE [dbo].[TaiKhoanKH]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanKH_KhachHang] FOREIGN KEY([maKH])
REFERENCES [dbo].[KhachHang] ([maKH])
GO
ALTER TABLE [dbo].[TaiKhoanKH] CHECK CONSTRAINT [FK_TaiKhoanKH_KhachHang]
GO
ALTER TABLE [dbo].[TaiKhoanKH]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanKH_LoaiTK] FOREIGN KEY([maLoaiTK])
REFERENCES [dbo].[LoaiTK] ([maLoaiTK])
GO
ALTER TABLE [dbo].[TaiKhoanKH] CHECK CONSTRAINT [FK_TaiKhoanKH_LoaiTK]
GO
ALTER TABLE [dbo].[TheTinDung]  WITH CHECK ADD  CONSTRAINT [FK_TheTinDung_KhachHang] FOREIGN KEY([maKH])
REFERENCES [dbo].[KhachHang] ([maKH])
GO
ALTER TABLE [dbo].[TheTinDung] CHECK CONSTRAINT [FK_TheTinDung_KhachHang]
GO
ALTER TABLE [dbo].[TheTinDung]  WITH CHECK ADD  CONSTRAINT [FK_TheTinDung_LoaiThe] FOREIGN KEY([mlThe])
REFERENCES [dbo].[LoaiThe] ([mlThe])
GO
ALTER TABLE [dbo].[TheTinDung] CHECK CONSTRAINT [FK_TheTinDung_LoaiThe]
GO
ALTER TABLE [dbo].[TheTinDung]  WITH CHECK ADD  CONSTRAINT [FK_TheTinDung_TaiKhoanKH] FOREIGN KEY([maTkKH])
REFERENCES [dbo].[TaiKhoanKH] ([maTkKH])
GO
ALTER TABLE [dbo].[TheTinDung] CHECK CONSTRAINT [FK_TheTinDung_TaiKhoanKH]
GO
ALTER TABLE [dbo].[TheTinDung]  WITH CHECK ADD  CONSTRAINT [FK_TheTinDung_TaiSanTC] FOREIGN KEY([maTS])
REFERENCES [dbo].[TaiSanTC] ([maTS])
GO
ALTER TABLE [dbo].[TheTinDung] CHECK CONSTRAINT [FK_TheTinDung_TaiSanTC]
GO
/****** Object:  StoredProcedure [dbo].[checkAccount]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[checkAccount]
@email nchar(50) out, @matkhau nchar(10)
as
begin
	select CONCAT(hoNV,' ', tenNV) as Hoten, email, matKhau from NhanVien where email = @email and @matkhau = matkhau
end
GO
/****** Object:  StoredProcedure [dbo].[ShowNhanVien]    Script Date: 7/8/2022 1:55:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[ShowNhanVien] @email nchar(50), @mk nchar(10)
as
begin
	select * from NhanVien where email = @email and matKhau = @mk
end
GO
USE [master]
GO
ALTER DATABASE [Data_CardOfBank] SET  READ_WRITE 
GO
