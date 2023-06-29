CREATE DATABASE UngDungQuanLyQuanBida;
GO

USE UngDungQuanLyQuanBida;
GO

-- 01. LoaiNhanVien --------------------------------------------------------------------------------------
CREATE TABLE dbo.LoaiNhanVien
(
    maLoaiNhanVien  VARCHAR(10)   NOT NULL CONSTRAINT pk_LoaiNhanVien PRIMARY KEY,
    tenLoaiNhanVien NVARCHAR(200) NULL
);
GO

-- 02. NhanVien ------------------------------------------------------------------------------------------
CREATE TABLE dbo.NhanVien
(
    tenDangNhap    VARCHAR(20)    NOT NULL CONSTRAINT pk_NhanVien PRIMARY KEY,
    matKhau        VARCHAR(128)   NULL,
    hoVaTen        NVARCHAR(200)  NULL,
    maLoaiNhanVien VARCHAR(10)    NULL CONSTRAINT fk_NhanVien_maLoaiNhanVien FOREIGN KEY REFERENCES dbo.LoaiNhanVien (maLoaiNhanVien),
    hinhAnh        VARBINARY(MAX) NULL,
    thoiGianThem   DATETIME       NULL,
    trangThai      BIT            NULL
);
GO

-- 03. HangKhachHang -------------------------------------------------------------------------------------
CREATE TABLE dbo.HangKhachHang
(
    maHangKhachHang  VARCHAR(10)   NOT NULL CONSTRAINT pk_HangKhachHang PRIMARY KEY,
    tenHangKhachHang NVARCHAR(200) NULL,
    doanhSoDatToi    BIGINT        NULL,
    khuyenMai        TINYINT       NULL
);
GO

-- 04. KhachHang -----------------------------------------------------------------------------------------
CREATE TABLE dbo.KhachHang
(
    soDienThoai     VARCHAR(10)   NOT NULL CONSTRAINT pk_KhachHang PRIMARY KEY,
    hoVaTen         NVARCHAR(200) NULL,
    maHangKhachHang VARCHAR(10)   NULL CONSTRAINT fk_KhachHang_maHangKhachHang FOREIGN KEY REFERENCES dbo.HangKhachHang (maHangKhachHang),
    thoiGianThem    DATETIME      NULL
);
GO

-- 05. LoaiBan -------------------------------------------------------------------------------------------
CREATE TABLE dbo.LoaiBan
(
    maLoaiBan  VARCHAR(10)   NOT NULL CONSTRAINT pk_LoaiBan PRIMARY KEY,
    tenLoaiBan NVARCHAR(200) NULL
);
GO

-- 06. KhuVuc --------------------------------------------------------------------------------------------
CREATE TABLE dbo.KhuVuc
(
    maKhuVuc  VARCHAR(10)   NOT NULL CONSTRAINT pk_KhuVuc PRIMARY KEY,
    tenKhuVuc NVARCHAR(200) NULL
);
GO

-- 07. Ban -----------------------------------------------------------------------------------------------
CREATE TABLE dbo.Ban
(
    maBan     VARCHAR(10)   NOT NULL CONSTRAINT pk_Ban PRIMARY KEY,
    tenBan    NVARCHAR(200) NULL,
    maLoaiBan VARCHAR(10)   NOT NULL CONSTRAINT fk_Ban_maLoaiBan FOREIGN KEY REFERENCES dbo.LoaiBan (maLoaiBan),
    maKhuVuc  VARCHAR(10)   NOT NULL CONSTRAINT fk_Ban_maKhuVuc FOREIGN KEY REFERENCES dbo.KhuVuc (maKhuVuc),
    gia       BIGINT        NULL,
    trangThai BIT           NULL
);
GO

-- 08. LoaiDichVu ----------------------------------------------------------------------------------------
CREATE TABLE dbo.LoaiDichVu
(
    maLoaiDichVu  VARCHAR(10)   NOT NULL CONSTRAINT pk_LoaiDichVu PRIMARY KEY,
    tenLoaiDichVu NVARCHAR(200) NULL
);
GO

-- 09. DichVu --------------------------------------------------------------------------------------------
CREATE TABLE dbo.DichVu
(
    maDichVu     VARCHAR(10)    NOT NULL CONSTRAINT pk_DichVu PRIMARY KEY,
    tenDichVu    NVARCHAR(200)  NULL,
    maLoaiDichVu VARCHAR(10)    NOT NULL CONSTRAINT fk_DichVu_maLoaiDichVu FOREIGN KEY REFERENCES dbo.LoaiDichVu (maLoaiDichVu),
    hinhAnh      VARBINARY(MAX) NULL,
    gia          BIGINT         NULL,
    thoiGianThem DATETIME       NULL,
    trangThai    BIT            NULL
);
GO

-- 10. NgayCoKhuyenMai -----------------------------------------------------------------------------------
CREATE TABLE dbo.NgayCoKhuyenMai
(
    ngay      DATE           NOT NULL CONSTRAINT pk_NgayCoKhuyenMai PRIMARY KEY,
    moTa      NVARCHAR(1000) NULL,
    khuyenMai TINYINT        NULL
);
GO

-- 11. HoaDon --------------------------------------------------------------------------------------------
CREATE TABLE dbo.HoaDon
(
    maHoaDon               VARCHAR(14) NOT NULL CONSTRAINT pk_HoaDon PRIMARY KEY,
    thoiGianThem           DATETIME    NULL,
    tenDangNhapNhanVien    VARCHAR(20) NULL CONSTRAINT fk_HoaDon_tenDangNhapNhanVien FOREIGN KEY REFERENCES dbo.NhanVien (tenDangNhap) ON UPDATE CASCADE,
    soDienThoaiKhachHang   VARCHAR(10) NULL CONSTRAINT fk_HoaDon_soDienThoaiKhachHang FOREIGN KEY REFERENCES dbo.KhachHang (soDienThoai) ON UPDATE CASCADE,
    khuyenMaiHangKhachHang TINYINT     NULL,
    khuyenMaiNgay          TINYINT     NULL,
    trangThai              BIT         NULL
);
GO

-- 12. HoaDonBan ----------------------------------------------------------------------------------------
CREATE TABLE dbo.HoaDonBan
(
    thoiGianThem    DATETIME    NOT NULL CONSTRAINT pk_HoaDonBan PRIMARY KEY,
    maHoaDon        VARCHAR(14) NULL CONSTRAINT fk_HoaDonBan_maHoaDon FOREIGN KEY REFERENCES dbo.HoaDon (maHoaDon),
    maBan           VARCHAR(10) NULL CONSTRAINT fk_HoaDonBan_maBan FOREIGN KEY REFERENCES dbo.Ban (maBan),
    gia             BIGINT      NULL,
    thoiGianBatDau  DATETIME    NULL,
    thoiGianKetThuc DATETIME    NULL
);
GO

-- 13. HoaDonDichVu -------------------------------------------------------------------------------------
CREATE TABLE dbo.HoaDonDichVu
(
    thoiGianThem DATETIME    NOT NULL CONSTRAINT pk_HoaDonDichVu PRIMARY KEY,
    maHoaDon     VARCHAR(14) NULL CONSTRAINT fk_HoaDonDichVu_maHoaDon FOREIGN KEY REFERENCES dbo.HoaDon (maHoaDon),
    maDichVu     VARCHAR(10) NULL CONSTRAINT fk_HoaDonDichVu_maDichVu FOREIGN KEY REFERENCES dbo.DichVu (maDichVu),
    gia          BIGINT      NULL,
    soLuong      INT         NULL
);
GO

-- 14. ThongTinQuan --------------------------------------------------------------------------------------
CREATE TABLE dbo.ThongTinQuan
(
    maQuan      VARCHAR(10)    NOT NULL CONSTRAINT pk_ThongTinQuan PRIMARY KEY,
    tenQuan     NVARCHAR(200)  NULL,
    diaChi      NVARCHAR(MAX)  NULL,
    soDienThoai VARCHAR(10)    NULL,
    hinhAnh     VARBINARY(MAX) NULL
);
GO

-- 01. LoaiNhanVien --------------------------------------------------------------------------------------


-- 02. NhanVien ------------------------------------------------------------------------------------------


-- 03. HangKhachHang -------------------------------------------------------------------------------------


-- 04. KhachHang -----------------------------------------------------------------------------------------


-- 05. LoaiBan -------------------------------------------------------------------------------------------


-- 06. KhuVuc --------------------------------------------------------------------------------------------


-- 07. Ban -----------------------------------------------------------------------------------------------


-- 08. LoaiDichVu ----------------------------------------------------------------------------------------


-- 09. DichVu --------------------------------------------------------------------------------------------


-- 10. NgayCoKhuyenMai; -----------------------------------------------------------------------------------


-- 11. HoaDon --------------------------------------------------------------------------------------------


-- 12. HoaDonBan ----------------------------------------------------------------------------------------


-- 13. HoaDonDichVu -------------------------------------------------------------------------------------


-- 14. ThongTinQuan --------------------------------------------------------------------------------------
GO
