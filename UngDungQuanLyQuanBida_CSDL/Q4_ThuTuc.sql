-- 01. LoaiNhanVien --------------------------------------------------------------------------------------
CREATE PROCEDURE sp_LayDanhSachLoaiNhanVien
AS
    BEGIN
        SELECT   LNV.maLoaiNhanVien,
                 LNV.tenLoaiNhanVien,
                 COUNT(NV.tenDangNhap) AS soLuongNhanVien
        FROM     dbo.LoaiNhanVien       AS LNV
                 LEFT JOIN dbo.NhanVien AS NV ON NV.maLoaiNhanVien = LNV.maLoaiNhanVien
        GROUP BY LNV.maLoaiNhanVien,
                 LNV.tenLoaiNhanVien;
    END;
GO

-- 02. NhanVien ------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_LayDanhSachNhanVien
AS
    BEGIN
        SELECT   NV.thoiGianThem,
                 NV.tenDangNhap,
                 NV.hoVaTen,
                 LNV.tenLoaiNhanVien,
                 NV.hinhAnh,
                 CASE
                     WHEN NV.trangThai = 1 THEN N'Còn làm việc'
                     ELSE N'Không còn làm việc'
                 END AS trangThai
        FROM     dbo.NhanVien          AS NV
                 JOIN dbo.LoaiNhanVien AS LNV ON LNV.maLoaiNhanVien = NV.maLoaiNhanVien
        WHERE    NV.thoiGianThem <> '2000-01-01'
        ORDER BY NV.thoiGianThem;
    END;
GO

CREATE PROCEDURE sp_LayDanhSachNhanVien_timKiem (@tuKhoa NVARCHAR(100))
AS
    BEGIN
        SELECT   NV.thoiGianThem,
                 NV.tenDangNhap,
                 NV.hoVaTen,
                 LNV.tenLoaiNhanVien,
                 NV.hinhAnh,
                 CASE
                     WHEN NV.trangThai = 1 THEN N'Còn làm việc'
                     ELSE N'Không còn làm việc'
                 END AS trangThai
        FROM     dbo.NhanVien          AS NV
                 JOIN dbo.LoaiNhanVien AS LNV ON LNV.maLoaiNhanVien = NV.maLoaiNhanVien
        WHERE    NV.thoiGianThem <> '2000-01-01'
                 AND dbo.LamGonChuoi(NV.hoVaTen) LIKE N'%' + dbo.LamGonChuoi(@tuKhoa) + N'%'
        ORDER BY NV.thoiGianThem;
    END;
GO

CREATE PROCEDURE sp_LayDanhSachNhanVien_maLoaiNhanVien (@maLoaiNhanVien VARCHAR(10))
AS
    BEGIN
        SELECT   NV.thoiGianThem,
                 NV.tenDangNhap,
                 NV.hoVaTen,
                 LNV.tenLoaiNhanVien,
                 NV.hinhAnh,
                 CASE
                     WHEN NV.trangThai = 1 THEN N'Còn làm việc'
                     ELSE N'Không còn làm việc'
                 END AS trangThai
        FROM     dbo.NhanVien          AS NV
                 JOIN dbo.LoaiNhanVien AS LNV ON LNV.maLoaiNhanVien = NV.maLoaiNhanVien
        WHERE    NV.thoiGianThem       <> '2000-01-01'
                 AND NV.maLoaiNhanVien = @maLoaiNhanVien
        ORDER BY NV.thoiGianThem;
    END;
GO

-- 03. HangKhachHang -------------------------------------------------------------------------------------
CREATE PROCEDURE sp_LayDanhSachHangKhachHang
AS
    BEGIN
        SELECT   HKH.maHangKhachHang,
                 HKH.tenHangKhachHang,
                 HKH.doanhSoDatToi,
                 CAST(HKH.khuyenMai AS VARCHAR(3)) + '%' AS khuyenMai,
                 COUNT(KH.soDienThoai)                   AS soLuongKhachHang
        FROM     dbo.HangKhachHang       AS HKH
                 LEFT JOIN dbo.KhachHang AS KH ON KH.maHangKhachHang = HKH.maHangKhachHang
        GROUP BY HKH.maHangKhachHang,
                 HKH.tenHangKhachHang,
                 HKH.doanhSoDatToi,
                 CAST(HKH.khuyenMai AS VARCHAR(3)) + '%';
    END;
GO

-- 04. KhachHang -----------------------------------------------------------------------------------------
CREATE PROCEDURE sp_XetHangKhachHang (@soDienThoai VARCHAR(10))
AS
    BEGIN
        DECLARE @doanhSoHienTai BIGINT;
        DECLARE @doanhSoDatToiHangKhachHangLonNhatCoTheDatDuoc BIGINT;
        DECLARE @maHangKhachHangMoi VARCHAR(10);

        SET @doanhSoHienTai = (   SELECT ISNULL(SUM(Tam.tienPhaiThanhToan), 0) AS doanhSo
                                  FROM   dbo.KhachHang                            AS KH
                                         JOIN dbo.HangKhachHang                   AS HKH ON HKH.maHangKhachHang = KH.maHangKhachHang
                                         LEFT JOIN (   SELECT   HD.maHoaDon,
                                                                KH.soDienThoai,
                                                                CASE
                                                                    WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                                                                    ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                                                                END AS tienPhaiThanhToan
                                                       FROM     dbo.HoaDon                 AS HD
                                                                LEFT JOIN dbo.KhachHang    KH ON KH.soDienThoai     = HD.soDienThoaiKhachHang
                                                                LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                                                                LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
                                                       GROUP BY HD.maHoaDon,
                                                                KH.soDienThoai,
                                                                HD.khuyenMaiHangKhachHang,
                                                                HD.khuyenMaiNgay) AS Tam ON Tam.soDienThoai     = KH.soDienThoai
                                  WHERE  KH.soDienThoai = @soDienThoai);

        SET @doanhSoDatToiHangKhachHangLonNhatCoTheDatDuoc = (SELECT MAX(doanhSoDatToi)FROM dbo.HangKhachHang WHERE @doanhSoHienTai > doanhSoDatToi);

        SET @maHangKhachHangMoi = (SELECT MIN(maHangKhachHang)FROM dbo.HangKhachHang WHERE doanhSoDatToi = @doanhSoDatToiHangKhachHangLonNhatCoTheDatDuoc);

        UPDATE dbo.KhachHang SET maHangKhachHang = @maHangKhachHangMoi WHERE soDienThoai = @soDienThoai;
    END;
GO

CREATE PROCEDURE sp_LayDanhSachKhachHang
AS
    BEGIN
        SELECT   KH.thoiGianThem,
                 KH.soDienThoai,
                 KH.hoVaTen,
                 HKH.tenHangKhachHang,
                 COUNT(Tam.maHoaDon)                   AS soHoaDon,
                 ISNULL(SUM(Tam.tienPhaiThanhToan), 0) AS doanhSo
        FROM     dbo.KhachHang                            AS KH
                 JOIN dbo.HangKhachHang                   AS HKH ON HKH.maHangKhachHang = KH.maHangKhachHang
                 LEFT JOIN (   SELECT   HD.maHoaDon,
                                        KH.soDienThoai,
                                        CASE
                                            WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                                            ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                                        END AS tienPhaiThanhToan
                               FROM     dbo.HoaDon                 AS HD
                                        LEFT JOIN dbo.KhachHang    KH ON KH.soDienThoai     = HD.soDienThoaiKhachHang
                                        LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                                        LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
                               GROUP BY HD.maHoaDon,
                                        KH.soDienThoai,
                                        HD.khuyenMaiHangKhachHang,
                                        HD.khuyenMaiNgay) AS Tam ON Tam.soDienThoai     = KH.soDienThoai
        GROUP BY KH.thoiGianThem,
                 KH.soDienThoai,
                 KH.hoVaTen,
                 HKH.tenHangKhachHang;
    END;
GO

CREATE PROCEDURE sp_LayDanhSachKhachHang_timKiem (@tuKhoa NVARCHAR(100))
AS
    BEGIN
        SELECT   KH.thoiGianThem,
                 KH.soDienThoai,
                 KH.hoVaTen,
                 HKH.tenHangKhachHang,
                 COUNT(Tam.maHoaDon)                   AS soHoaDon,
                 ISNULL(SUM(Tam.tienPhaiThanhToan), 0) AS doanhSo
        FROM     dbo.KhachHang                            AS KH
                 JOIN dbo.HangKhachHang                   AS HKH ON HKH.maHangKhachHang = KH.maHangKhachHang
                 LEFT JOIN (   SELECT   HD.maHoaDon,
                                        KH.soDienThoai,
                                        CASE
                                            WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                                            ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                                        END AS tienPhaiThanhToan
                               FROM     dbo.HoaDon                 AS HD
                                        LEFT JOIN dbo.KhachHang    KH ON KH.soDienThoai     = HD.soDienThoaiKhachHang
                                        LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                                        LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
                               GROUP BY HD.maHoaDon,
                                        KH.soDienThoai,
                                        HD.khuyenMaiHangKhachHang,
                                        HD.khuyenMaiNgay) AS Tam ON Tam.soDienThoai     = KH.soDienThoai
        WHERE    dbo.LamGonChuoi(KH.hoVaTen) LIKE N'%' + dbo.LamGonChuoi(@tuKhoa) + N'%'
                 OR dbo.LamGonChuoi(KH.soDienThoai) LIKE N'%' + dbo.LamGonChuoi(@tuKhoa) + N'%'
        GROUP BY KH.thoiGianThem,
                 KH.soDienThoai,
                 KH.hoVaTen,
                 HKH.tenHangKhachHang;
    END;
GO

CREATE PROCEDURE sp_LayDanhSachKhachHang_maHangKhachHang (@maHangKhachHang VARCHAR(10))
AS
    BEGIN
        SELECT   KH.thoiGianThem,
                 KH.soDienThoai,
                 KH.hoVaTen,
                 HKH.tenHangKhachHang,
                 COUNT(Tam.maHoaDon)                   AS soHoaDon,
                 ISNULL(SUM(Tam.tienPhaiThanhToan), 0) AS doanhSo
        FROM     dbo.KhachHang                            AS KH
                 JOIN dbo.HangKhachHang                   AS HKH ON HKH.maHangKhachHang = KH.maHangKhachHang
                 LEFT JOIN (   SELECT   HD.maHoaDon,
                                        KH.soDienThoai,
                                        CASE
                                            WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                                            ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                                        END AS tienPhaiThanhToan
                               FROM     dbo.HoaDon                 AS HD
                                        LEFT JOIN dbo.KhachHang    KH ON KH.soDienThoai     = HD.soDienThoaiKhachHang
                                        LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                                        LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
                               GROUP BY HD.maHoaDon,
                                        KH.soDienThoai,
                                        HD.khuyenMaiHangKhachHang,
                                        HD.khuyenMaiNgay) AS Tam ON Tam.soDienThoai     = KH.soDienThoai
        WHERE    KH.maHangKhachHang = @maHangKhachHang
        GROUP BY KH.thoiGianThem,
                 KH.soDienThoai,
                 KH.hoVaTen,
                 HKH.tenHangKhachHang;
    END;
GO

-- 05. LoaiBan -------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_LayDanhSachLoaiBan
AS
    BEGIN
        SELECT LB.maLoaiBan, LB.tenLoaiBan, COUNT(B.maBan) AS soLuongBan FROM dbo.LoaiBan AS LB LEFT JOIN dbo.Ban AS B ON B.maLoaiBan = LB.maLoaiBan GROUP BY LB.maLoaiBan, LB.tenLoaiBan;
    END;
GO

-- 06. KhuVuc --------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_LayDanhSachKhuVuc
AS
    BEGIN
        SELECT KV.maKhuVuc, KV.tenKhuVuc, COUNT(B.maBan) AS soLuongBan FROM dbo.KhuVuc AS KV LEFT JOIN dbo.Ban AS B ON B.maKhuVuc = KV.maKhuVuc GROUP BY KV.maKhuVuc, KV.tenKhuVuc;
    END;
GO

-- 07. Ban -----------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_LayDanhSachBan
AS
    BEGIN
        SELECT B.maBan,
               B.tenBan,
               LB.tenLoaiBan,
               KV.tenKhuVuc,
               B.gia,
               CASE
                   WHEN B.trangThai = 1 THEN N'Có khách'
                   ELSE N'Trống'
               END AS trangThai
        FROM   dbo.Ban          AS B
               JOIN dbo.LoaiBan AS LB ON LB.maLoaiBan = B.maLoaiBan
               JOIN dbo.KhuVuc  AS KV ON KV.maKhuVuc  = B.maKhuVuc;
    END;
GO

CREATE PROCEDURE sp_LayDanhSachBan_maLoaiBan (@maLoaiBan VARCHAR(10))
AS
    BEGIN
        SELECT B.maBan,
               B.tenBan,
               LB.tenLoaiBan,
               KV.tenKhuVuc,
               B.gia,
               CASE
                   WHEN B.trangThai = 1 THEN N'Có khách'
                   ELSE N'Trống'
               END AS trangThai
        FROM   dbo.Ban          AS B
               JOIN dbo.LoaiBan AS LB ON LB.maLoaiBan = B.maLoaiBan
               JOIN dbo.KhuVuc  AS KV ON KV.maKhuVuc  = B.maKhuVuc
        WHERE  B.maLoaiBan = @maLoaiBan;
    END;
GO

CREATE PROCEDURE sp_LayDanhSachBan_maKhuVuc (@maKhuVuc VARCHAR(10))
AS
    BEGIN
        SELECT B.maBan,
               B.tenBan,
               LB.tenLoaiBan,
               KV.tenKhuVuc,
               B.gia,
               CASE
                   WHEN B.trangThai = 1 THEN N'Có khách'
                   ELSE N'Trống'
               END AS trangThai
        FROM   dbo.Ban          AS B
               JOIN dbo.LoaiBan AS LB ON LB.maLoaiBan = B.maLoaiBan
               JOIN dbo.KhuVuc  AS KV ON KV.maKhuVuc  = B.maKhuVuc
        WHERE  B.maKhuVuc = @maKhuVuc;
    END;
GO

-- 08. LoaiDichVu ----------------------------------------------------------------------------------------
CREATE PROCEDURE sp_LayDanhSachLoaiDichVu
AS
    BEGIN
        SELECT   LDV.maLoaiDichVu,
                 LDV.tenLoaiDichVu,
                 COUNT(DV.maDichVu) AS soLuongDichVu
        FROM     dbo.LoaiDichVu       AS LDV
                 LEFT JOIN dbo.DichVu AS DV ON DV.maLoaiDichVu = LDV.maLoaiDichVu
        GROUP BY LDV.maLoaiDichVu,
                 LDV.tenLoaiDichVu;
    END;
GO

-- 09. DichVu --------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_LayDanhSachDichVu
AS
    BEGIN
        SELECT DV.thoiGianThem,
               DV.maDichVu,
               DV.tenDichVu,
               LDV.tenLoaiDichVu,
               DV.hinhAnh,
               DV.gia,
               CASE
                   WHEN DV.trangThai = 1 THEN N'Còn kinh doanh'
                   ELSE N'Không còn kinh doanh'
               END AS trangThai
        FROM   dbo.DichVu          AS DV
               JOIN dbo.LoaiDichVu AS LDV ON LDV.maLoaiDichVu = DV.maLoaiDichVu;
    END;
GO

CREATE PROCEDURE sp_LayDanhSachDichVu_timKiem (@tuKhoa NVARCHAR(100))
AS
    BEGIN
        SELECT DV.thoiGianThem,
               DV.maDichVu,
               DV.tenDichVu,
               LDV.tenLoaiDichVu,
               DV.hinhAnh,
               DV.gia,
               CASE
                   WHEN DV.trangThai = 1 THEN N'Còn kinh doanh'
                   ELSE N'Không còn kinh doanh'
               END AS trangThai
        FROM   dbo.DichVu          AS DV
               JOIN dbo.LoaiDichVu AS LDV ON LDV.maLoaiDichVu = DV.maLoaiDichVu
        WHERE  dbo.LamGonChuoi(DV.tenDichVu) LIKE N'%' + dbo.LamGonChuoi(@tuKhoa) + N'%';
    END;
GO

CREATE PROCEDURE sp_LayDanhSachDichVu_maLoaiDichVu (@maLoaiDichVu VARCHAR(10))
AS
    BEGIN
        SELECT DV.thoiGianThem,
               DV.maDichVu,
               DV.tenDichVu,
               LDV.tenLoaiDichVu,
               DV.hinhAnh,
               DV.gia,
               CASE
                   WHEN DV.trangThai = 1 THEN N'Còn kinh doanh'
                   ELSE N'Không còn kinh doanh'
               END AS trangThai
        FROM   dbo.DichVu          AS DV
               JOIN dbo.LoaiDichVu AS LDV ON LDV.maLoaiDichVu = DV.maLoaiDichVu
        WHERE  DV.maLoaiDichVu = @maLoaiDichVu;
    END;
GO

-- 10. NgayCoKhuyenMai; -----------------------------------------------------------------------------------
CREATE PROCEDURE sp_LayDanhSachNgayCoKhuyenMai
AS
    BEGIN
        SELECT   ngay,
                 moTa,
                 CAST(khuyenMai AS VARCHAR(3)) + '%' AS khuyenMai,
                 CASE
                     WHEN ngay < CAST(GETDATE() AS DATE) THEN N'Hết hiệu lực'
                     WHEN ngay > CAST(GETDATE() AS DATE) THEN N'Chưa có hiệu lực'
                     ELSE N'Đang áp dụng'
                 END                                 AS hieuLuc
        FROM     dbo.NgayCoKhuyenMai
        ORDER BY ngay DESC;
    END;
GO

-- 11. HoaDon --------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_LayTienBan (@maHoaDon VARCHAR(14))
AS
    BEGIN
        SELECT CASE
                   WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                   ELSE SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem)
               END AS tienBan
        FROM   dbo.HoaDon                 AS HD
               LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
               LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
        WHERE  HD.maHoaDon = @maHoaDon;
    END;
GO

CREATE PROCEDURE sp_LayTienDichVu (@maHoaDon VARCHAR(14))
AS
    BEGIN
        SELECT SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem) AS tienDichVu
        FROM   dbo.HoaDon                 AS HD
               LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
               LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
        WHERE  HD.maHoaDon = @maHoaDon;
    END;
GO

CREATE PROCEDURE sp_LayTienHoaDon (@maHoaDon VARCHAR(14))
AS
    BEGIN
        SELECT CASE
                   WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                   ELSE (SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem))
               END AS tienHoaDon
        FROM   dbo.HoaDon                 AS HD
               LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
               LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
        WHERE  HD.maHoaDon = @maHoaDon;
    END;
GO

CREATE PROCEDURE sp_LayTienKhuyenMaiHangKhachHang (@maHoaDon VARCHAR(14))
AS
    BEGIN
        SELECT   CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiHangKhachHang / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiHangKhachHang / 100, -3)
                 END AS tienKhuyenMaiHangKhachHang
        FROM     dbo.HoaDon                 AS HD
                 LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                 LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
        WHERE    HD.maHoaDon = @maHoaDon
        GROUP BY HD.khuyenMaiHangKhachHang,
                 HD.khuyenMaiNgay;
    END;
GO

CREATE PROCEDURE sp_LayTienKhuyenMaiNgay (@maHoaDon VARCHAR(14))
AS
    BEGIN
        SELECT   CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiNgay / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiNgay / 100, -3)
                 END AS tienKhuyenMaiNgay
        FROM     dbo.HoaDon                 AS HD
                 LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                 LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
        WHERE    HD.maHoaDon = @maHoaDon
        GROUP BY HD.khuyenMaiHangKhachHang,
                 HD.khuyenMaiNgay;
    END;
GO

CREATE PROCEDURE sp_LayTienPhaiThanhToan (@maHoaDon VARCHAR(14))
AS
    BEGIN
        SELECT   CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                 END AS tienPhaiThanhToan
        FROM     dbo.HoaDon                 AS HD
                 LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                 LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
        WHERE    HD.maHoaDon = @maHoaDon
        GROUP BY HD.khuyenMaiHangKhachHang,
                 HD.khuyenMaiNgay;
    END;
GO

CREATE PROCEDURE sp_LayDoanhThuHomNay
AS
    BEGIN
        SELECT ISNULL(SUM(HDCT.tienPhaiThanhToan), 0)
        FROM   dbo.HoaDon                      AS HD
               JOIN (   SELECT   HD.maHoaDon,
                                 HD.thoiGianThem,
                                 NV.hoVaTen + CHAR(13) + CHAR(10) + NV.tenDangNhap                                     AS nhanVien,
                                 ISNULL(KH.hoVaTen + CHAR(13) + CHAR(10) + KH.soDienThoai, N'Khách lẻ')                AS khachHang,
                                 CAST(HD.khuyenMaiHangKhachHang AS VARCHAR(3)) + '%'                                   AS khuyenMaiHangKhachHang,
                                 CAST(HD.khuyenMaiNgay AS VARCHAR(3)) + '%'                                            AS khuyenMaiNgay,
                                 CASE
                                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                                     ELSE SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem)
                                 END                                                                                   AS tienBan,
                                 SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem) AS tienDichVu,
                                 CASE
                                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                                     ELSE (SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem))
                                 END                                                                                   AS tienHoaDon,
                                 CASE
                                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiHangKhachHang / 100, -3)
                                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiHangKhachHang / 100, -3)
                                 END                                                                                   AS tienKhuyenMaiHangKhachHang,
                                 CASE
                                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiNgay / 100, -3)
                                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiNgay / 100, -3)
                                 END                                                                                   AS tienKhuyenMaiNgay,
                                 CASE
                                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                                 END                                                                                   AS tienPhaiThanhToan,
                                 CASE
                                     WHEN HD.trangThai = 1 THEN N'Đã thanh toán'
                                     ELSE N'Chưa thanh toán'
                                 END                                                                                   AS trangThai
                        FROM     dbo.HoaDon                 AS HD
                                 JOIN dbo.NhanVien          AS NV ON NV.tenDangNhap  = HD.tenDangNhapNhanVien
                                 LEFT JOIN dbo.KhachHang    KH ON KH.soDienThoai     = HD.soDienThoaiKhachHang
                                 LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                                 LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
                        GROUP BY HD.maHoaDon,
                                 HD.thoiGianThem,
                                 NV.hoVaTen,
                                 NV.tenDangNhap,
                                 KH.hoVaTen,
                                 KH.soDienThoai,
                                 HD.khuyenMaiHangKhachHang,
                                 HD.khuyenMaiNgay,
                                 HD.trangThai) AS HDCT ON HDCT.maHoaDon = HD.maHoaDon
        WHERE  CAST(HD.thoiGianThem AS DATE) = CAST(GETDATE() AS DATE);
    END;
GO

CREATE PROCEDURE sp_LayDanhSachHoaDon
AS
    BEGIN
        SELECT   HD.maHoaDon,
                 HD.thoiGianThem,
                 NV.hoVaTen + CHAR(13) + CHAR(10) + NV.tenDangNhap                                     AS nhanVien,
                 ISNULL(KH.hoVaTen + CHAR(13) + CHAR(10) + KH.soDienThoai, N'Khách lẻ')                AS khachHang,
                 CAST(HD.khuyenMaiHangKhachHang AS VARCHAR(3)) + '%'                                   AS khuyenMaiHangKhachHang,
                 CAST(HD.khuyenMaiNgay AS VARCHAR(3)) + '%'                                            AS khuyenMaiNgay,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                     ELSE SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem)
                 END                                                                                   AS tienBan,
                 SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem) AS tienDichVu,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                     ELSE (SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem))
                 END                                                                                   AS tienHoaDon,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiHangKhachHang / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiHangKhachHang / 100, -3)
                 END                                                                                   AS tienKhuyenMaiHangKhachHang,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiNgay / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiNgay / 100, -3)
                 END                                                                                   AS tienKhuyenMaiNgay,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                 END                                                                                   AS tienPhaiThanhToan,
                 CASE
                     WHEN HD.trangThai = 1 THEN N'Đã thanh toán'
                     ELSE N'Chưa thanh toán'
                 END                                                                                   AS trangThai
        FROM     dbo.HoaDon                 AS HD
                 JOIN dbo.NhanVien          AS NV ON NV.tenDangNhap  = HD.tenDangNhapNhanVien
                 LEFT JOIN dbo.KhachHang    KH ON KH.soDienThoai     = HD.soDienThoaiKhachHang
                 LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                 LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
        GROUP BY HD.maHoaDon,
                 HD.thoiGianThem,
                 NV.hoVaTen,
                 NV.tenDangNhap,
                 KH.hoVaTen,
                 KH.soDienThoai,
                 HD.khuyenMaiHangKhachHang,
                 HD.khuyenMaiNgay,
                 HD.trangThai
        ORDER BY HD.thoiGianThem DESC;
    END;
GO

CREATE PROCEDURE sp_LayDanhSachHoaDon_khachLe
AS
    BEGIN
        SELECT   HD.maHoaDon,
                 HD.thoiGianThem,
                 NV.hoVaTen + CHAR(13) + CHAR(10) + NV.tenDangNhap                                     AS nhanVien,
                 ISNULL(KH.hoVaTen + CHAR(13) + CHAR(10) + KH.soDienThoai, N'Khách lẻ')                AS khachHang,
                 CAST(HD.khuyenMaiHangKhachHang AS VARCHAR(3)) + '%'                                   AS khuyenMaiHangKhachHang,
                 CAST(HD.khuyenMaiNgay AS VARCHAR(3)) + '%'                                            AS khuyenMaiNgay,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                     ELSE SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem)
                 END                                                                                   AS tienBan,
                 SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem) AS tienDichVu,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                     ELSE (SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem))
                 END                                                                                   AS tienHoaDon,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiHangKhachHang / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiHangKhachHang / 100, -3)
                 END                                                                                   AS tienKhuyenMaiHangKhachHang,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiNgay / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiNgay / 100, -3)
                 END                                                                                   AS tienKhuyenMaiNgay,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                 END                                                                                   AS tienPhaiThanhToan,
                 CASE
                     WHEN HD.trangThai = 1 THEN N'Đã thanh toán'
                     ELSE N'Chưa thanh toán'
                 END                                                                                   AS trangThai
        FROM     dbo.HoaDon                 AS HD
                 JOIN dbo.NhanVien          AS NV ON NV.tenDangNhap  = HD.tenDangNhapNhanVien
                 LEFT JOIN dbo.KhachHang    KH ON KH.soDienThoai     = HD.soDienThoaiKhachHang
                 LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                 LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
        WHERE    HD.soDienThoaiKhachHang IS NULL
        GROUP BY HD.maHoaDon,
                 HD.thoiGianThem,
                 NV.hoVaTen,
                 NV.tenDangNhap,
                 KH.hoVaTen,
                 KH.soDienThoai,
                 HD.khuyenMaiHangKhachHang,
                 HD.khuyenMaiNgay,
                 HD.trangThai
        ORDER BY HD.thoiGianThem DESC;
    END;
GO

CREATE PROCEDURE sp_LayDanhSachHoaDon_ngay (@ngay DATETIME)
AS
    BEGIN
        SELECT   HD.maHoaDon,
                 HD.thoiGianThem,
                 NV.hoVaTen + CHAR(13) + CHAR(10) + NV.tenDangNhap                                     AS nhanVien,
                 ISNULL(KH.hoVaTen + CHAR(13) + CHAR(10) + KH.soDienThoai, N'Khách lẻ')                AS khachHang,
                 CAST(HD.khuyenMaiHangKhachHang AS VARCHAR(3)) + '%'                                   AS khuyenMaiHangKhachHang,
                 CAST(HD.khuyenMaiNgay AS VARCHAR(3)) + '%'                                            AS khuyenMaiNgay,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                     ELSE SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem)
                 END                                                                                   AS tienBan,
                 SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem) AS tienDichVu,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                     ELSE (SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem))
                 END                                                                                   AS tienHoaDon,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiHangKhachHang / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiHangKhachHang / 100, -3)
                 END                                                                                   AS tienKhuyenMaiHangKhachHang,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiNgay / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiNgay / 100, -3)
                 END                                                                                   AS tienKhuyenMaiNgay,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                 END                                                                                   AS tienPhaiThanhToan,
                 CASE
                     WHEN HD.trangThai = 1 THEN N'Đã thanh toán'
                     ELSE N'Chưa thanh toán'
                 END                                                                                   AS trangThai
        FROM     dbo.HoaDon                 AS HD
                 JOIN dbo.NhanVien          AS NV ON NV.tenDangNhap  = HD.tenDangNhapNhanVien
                 LEFT JOIN dbo.KhachHang    KH ON KH.soDienThoai     = HD.soDienThoaiKhachHang
                 LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                 LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
        WHERE    CAST(HD.thoiGianThem AS DATE) = CAST(@ngay AS DATE)
        GROUP BY HD.maHoaDon,
                 HD.thoiGianThem,
                 NV.hoVaTen,
                 NV.tenDangNhap,
                 KH.hoVaTen,
                 KH.soDienThoai,
                 HD.khuyenMaiHangKhachHang,
                 HD.khuyenMaiNgay,
                 HD.trangThai
        ORDER BY HD.thoiGianThem DESC;
    END;
GO

CREATE PROCEDURE sp_LayDanhSachHoaDon_tuan (@ngay DATETIME)
AS
    BEGIN
        SELECT   HD.maHoaDon,
                 HD.thoiGianThem,
                 NV.hoVaTen + CHAR(13) + CHAR(10) + NV.tenDangNhap                                     AS nhanVien,
                 ISNULL(KH.hoVaTen + CHAR(13) + CHAR(10) + KH.soDienThoai, N'Khách lẻ')                AS khachHang,
                 CAST(HD.khuyenMaiHangKhachHang AS VARCHAR(3)) + '%'                                   AS khuyenMaiHangKhachHang,
                 CAST(HD.khuyenMaiNgay AS VARCHAR(3)) + '%'                                            AS khuyenMaiNgay,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                     ELSE SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem)
                 END                                                                                   AS tienBan,
                 SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem) AS tienDichVu,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                     ELSE (SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem))
                 END                                                                                   AS tienHoaDon,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiHangKhachHang / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiHangKhachHang / 100, -3)
                 END                                                                                   AS tienKhuyenMaiHangKhachHang,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiNgay / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiNgay / 100, -3)
                 END                                                                                   AS tienKhuyenMaiNgay,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                 END                                                                                   AS tienPhaiThanhToan,
                 CASE
                     WHEN HD.trangThai = 1 THEN N'Đã thanh toán'
                     ELSE N'Chưa thanh toán'
                 END                                                                                   AS trangThai
        FROM     dbo.HoaDon                 AS HD
                 JOIN dbo.NhanVien          AS NV ON NV.tenDangNhap  = HD.tenDangNhapNhanVien
                 LEFT JOIN dbo.KhachHang    KH ON KH.soDienThoai     = HD.soDienThoaiKhachHang
                 LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                 LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
        WHERE    DATEPART(ISO_WEEK, HD.thoiGianThem) = DATEPART(ISO_WEEK, @ngay)
        GROUP BY HD.maHoaDon,
                 HD.thoiGianThem,
                 NV.hoVaTen,
                 NV.tenDangNhap,
                 KH.hoVaTen,
                 KH.soDienThoai,
                 HD.khuyenMaiHangKhachHang,
                 HD.khuyenMaiNgay,
                 HD.trangThai
        ORDER BY HD.thoiGianThem DESC;
    END;
GO

CREATE PROCEDURE sp_LayDanhSachHoaDon_thang (@ngay DATETIME)
AS
    BEGIN
        SELECT   HD.maHoaDon,
                 HD.thoiGianThem,
                 NV.hoVaTen + CHAR(13) + CHAR(10) + NV.tenDangNhap                                     AS nhanVien,
                 ISNULL(KH.hoVaTen + CHAR(13) + CHAR(10) + KH.soDienThoai, N'Khách lẻ')                AS khachHang,
                 CAST(HD.khuyenMaiHangKhachHang AS VARCHAR(3)) + '%'                                   AS khuyenMaiHangKhachHang,
                 CAST(HD.khuyenMaiNgay AS VARCHAR(3)) + '%'                                            AS khuyenMaiNgay,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                     ELSE SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem)
                 END                                                                                   AS tienBan,
                 SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem) AS tienDichVu,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                     ELSE (SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem))
                 END                                                                                   AS tienHoaDon,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiHangKhachHang / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiHangKhachHang / 100, -3)
                 END                                                                                   AS tienKhuyenMaiHangKhachHang,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiNgay / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiNgay / 100, -3)
                 END                                                                                   AS tienKhuyenMaiNgay,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                 END                                                                                   AS tienPhaiThanhToan,
                 CASE
                     WHEN HD.trangThai = 1 THEN N'Đã thanh toán'
                     ELSE N'Chưa thanh toán'
                 END                                                                                   AS trangThai
        FROM     dbo.HoaDon                 AS HD
                 JOIN dbo.NhanVien          AS NV ON NV.tenDangNhap  = HD.tenDangNhapNhanVien
                 LEFT JOIN dbo.KhachHang    KH ON KH.soDienThoai     = HD.soDienThoaiKhachHang
                 LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                 LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
        WHERE    MONTH(HD.thoiGianThem)    = MONTH(@ngay)
                 AND YEAR(HD.thoiGianThem) = YEAR(@ngay)
        GROUP BY HD.maHoaDon,
                 HD.thoiGianThem,
                 NV.hoVaTen,
                 NV.tenDangNhap,
                 KH.hoVaTen,
                 KH.soDienThoai,
                 HD.khuyenMaiHangKhachHang,
                 HD.khuyenMaiNgay,
                 HD.trangThai
        ORDER BY HD.thoiGianThem DESC;
    END;
GO

CREATE PROCEDURE sp_LayDanhSachHoaDon_soDienThoaiKhachHang (@soDienThoaiKhachHang VARCHAR(10))
AS
    BEGIN
        SELECT   HD.maHoaDon,
                 HD.thoiGianThem,
                 NV.hoVaTen + CHAR(13) + CHAR(10) + NV.tenDangNhap                                     AS nhanVien,
                 ISNULL(KH.hoVaTen + CHAR(13) + CHAR(10) + KH.soDienThoai, N'Khách lẻ')                AS khachHang,
                 CAST(HD.khuyenMaiHangKhachHang AS VARCHAR(3)) + '%'                                   AS khuyenMaiHangKhachHang,
                 CAST(HD.khuyenMaiNgay AS VARCHAR(3)) + '%'                                            AS khuyenMaiNgay,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                     ELSE SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem)
                 END                                                                                   AS tienBan,
                 SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem) AS tienDichVu,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0))
                     ELSE (SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem))
                 END                                                                                   AS tienHoaDon,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiHangKhachHang / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiHangKhachHang / 100, -3)
                 END                                                                                   AS tienKhuyenMaiHangKhachHang,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * HD.khuyenMaiNgay / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * HD.khuyenMaiNgay / 100, -3)
                 END                                                                                   AS tienKhuyenMaiNgay,
                 CASE
                     WHEN COUNT(DISTINCT HDDV.thoiGianThem) = 0 THEN ROUND(SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                     ELSE ROUND((SUM(ISNULL(ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3), 0)) / COUNT(DISTINCT HDDV.thoiGianThem) + SUM(ISNULL(ROUND(HDDV.gia * HDDV.soLuong, -3), 0)) / COUNT(DISTINCT HDB.thoiGianThem)) * (100 - HD.khuyenMaiHangKhachHang - HD.khuyenMaiNgay) / 100, -3)
                 END                                                                                   AS tienPhaiThanhToan,
                 CASE
                     WHEN HD.trangThai = 1 THEN N'Đã thanh toán'
                     ELSE N'Chưa thanh toán'
                 END                                                                                   AS trangThai
        FROM     dbo.HoaDon                 AS HD
                 JOIN dbo.NhanVien          AS NV ON NV.tenDangNhap  = HD.tenDangNhapNhanVien
                 LEFT JOIN dbo.KhachHang    KH ON KH.soDienThoai     = HD.soDienThoaiKhachHang
                 LEFT JOIN dbo.HoaDonBan    AS HDB ON HDB.maHoaDon   = HD.maHoaDon
                 LEFT JOIN dbo.HoaDonDichVu AS HDDV ON HDDV.maHoaDon = HD.maHoaDon
        WHERE    HD.soDienThoaiKhachHang = @soDienThoaiKhachHang
        GROUP BY HD.maHoaDon,
                 HD.thoiGianThem,
                 NV.hoVaTen,
                 NV.tenDangNhap,
                 KH.hoVaTen,
                 KH.soDienThoai,
                 HD.khuyenMaiHangKhachHang,
                 HD.khuyenMaiNgay,
                 HD.trangThai
        ORDER BY HD.thoiGianThem DESC;
    END;
GO

-- 12. HoaDonBan ----------------------------------------------------------------------------------------
CREATE PROCEDURE sp_LayDanhSachHoaDonBan (@maHoaDon VARCHAR(14))
AS
    BEGIN
        SELECT   HDB.thoiGianThem,
                 B.tenBan + N' | ' + LB.tenLoaiBan + CHAR(13) + CHAR(10) + FORMAT(HDB.thoiGianBatDau, 'HH:mm') + N' - ' + FORMAT(HDB.thoiGianKetThuc, 'HH:mm') AS tenBan,
                 HDB.gia,
                 DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc)                                                                                     AS soPhut,
                 ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3)                                                           AS thanhTien
        FROM     dbo.HoaDonBan    AS HDB
                 JOIN dbo.Ban     AS B ON B.maBan       = HDB.maBan
                 JOIN dbo.LoaiBan AS LB ON LB.maLoaiBan = B.maLoaiBan
        WHERE    HDB.maHoaDon = @maHoaDon
        ORDER BY HDB.thoiGianThem;
    END;
GO

-- 13. HoaDonDichVu -------------------------------------------------------------------------------------
CREATE PROCEDURE sp_LayDanhSachHoaDonDichVu (@maHoaDon VARCHAR(14))
AS
    BEGIN
        SELECT   DV.thoiGianThem,
                 DV.tenDichVu,
                 HDDV.gia,
                 HDDV.soLuong,
                 ROUND(HDDV.gia * HDDV.soLuong, -3) AS thanhTien
        FROM     dbo.HoaDonDichVu AS HDDV
                 JOIN dbo.DichVu  AS DV ON DV.maDichVu = HDDV.maDichVu
        WHERE    HDDV.maHoaDon = @maHoaDon
        ORDER BY HDDV.thoiGianThem;
    END;
GO

-- 14. ThongTinQuan --------------------------------------------------------------------------------------
GO

--EXECUTE dbo.sp_LayDanhSachLoaiNhanVien;
--EXECUTE dbo.sp_LayDanhSachNhanVien;
--EXECUTE dbo.sp_LayDanhSachNhanVien_timKiem @tuKhoa = N'1'; -- nvarchar(100)
--EXECUTE dbo.sp_LayDanhSachNhanVien_maLoaiNhanVien @maLoaiNhanVien = '0000000001'; -- varchar(10)
--EXECUTE dbo.sp_LayDanhSachHangKhachHang;
--EXECUTE dbo.sp_LayDanhSachKhachHang;
--EXECUTE dbo.sp_LayDanhSachKhachHang_timKiem @tuKhoa = N'1'; -- nvarchar(100)
--EXECUTE dbo.sp_LayDanhSachKhachHang_maHangKhachHang @maHangKhachHang = '0000000001'; -- varchar(10)
--EXECUTE dbo.sp_LayDanhSachLoaiBan;
--EXECUTE dbo.sp_LayDanhSachKhuVuc;
--EXECUTE dbo.sp_LayDanhSachBan;
--EXECUTE dbo.sp_LayDanhSachBan_maLoaiBan @maLoaiBan = '0000000002'; -- varchar(10)
--EXECUTE dbo.sp_LayDanhSachBan_maKhuVuc @maKhuVuc = '0000000002'; -- varchar(10)
--EXECUTE dbo.sp_LayDanhSachLoaiDichVu;
--EXECUTE dbo.sp_LayDanhSachDichVu;
--EXECUTE dbo.sp_LayDanhSachDichVu_timKiem @tuKhoa = N'pe'; -- nvarchar(100)
--EXECUTE dbo.sp_LayDanhSachDichVu_maLoaiDichVu @maLoaiDichVu = '0000000001'; -- varchar(10)
--EXECUTE dbo.sp_LayDanhSachNgayCoKhuyenMai;
--EXECUTE dbo.sp_LayTienBan @maHoaDon = '29062023000004'; -- varchar(14)
--EXECUTE dbo.sp_LayTienDichVu @maHoaDon = '29062023000001'; -- varchar(14)
--EXECUTE dbo.sp_LayTienHoaDon @maHoaDon = '29062023000001'; -- varchar(14)
--EXECUTE dbo.sp_LayTienKhuyenMaiHangKhachHang @maHoaDon = '29062023000001'; -- varchar(14)
--EXECUTE dbo.sp_LayTienKhuyenMaiNgay @maHoaDon = '29062023000001'; -- varchar(14)
--EXECUTE dbo.sp_LayTienPhaiThanhToan @maHoaDon = '29062023000001'; -- varchar(14)
--EXECUTE dbo.sp_LayDoanhThuHomNay;
--EXECUTE dbo.sp_LayDanhSachHoaDon;
--EXECUTE dbo.sp_LayDanhSachHoaDon_khachLe;
--EXECUTE dbo.sp_LayDanhSachHoaDon_ngay @ngay = '2023-06-27 08:06:18'; -- datetime
--EXECUTE dbo.sp_LayDanhSachHoaDon_tuan @ngay = '2023-06-27 08:06:25'; -- datetime
--EXECUTE dbo.sp_LayDanhSachHoaDon_thang @ngay = '2023-06-27 08:06:31'; -- datetime
--EXECUTE dbo.sp_LayDanhSachHoaDon_soDienThoaiKhachHang @soDienThoaiKhachHang = '0900000001'; -- varchar(10)
--EXECUTE dbo.sp_LayDanhSachHoaDonBan @maHoaDon = '29062023000001'; -- varchar(14)
--EXECUTE dbo.sp_LayDanhSachHoaDonDichVu @maHoaDon = '29062023000001'; -- varchar(14)
--GO

--DROP PROCEDURE dbo.sp_LayDanhSachLoaiNhanVien;
--DROP PROCEDURE dbo.sp_LayDanhSachNhanVien;
--DROP PROCEDURE dbo.sp_LayDanhSachNhanVien_timKiem;
--DROP PROCEDURE dbo.sp_LayDanhSachNhanVien_maLoaiNhanVien;
--DROP PROCEDURE dbo.sp_LayDanhSachHangKhachHang;
--DROP PROCEDURE dbo.sp_XetHangKhachHang;
--DROP PROCEDURE dbo.sp_LayDanhSachKhachHang;
--DROP PROCEDURE dbo.sp_LayDanhSachKhachHang_timKiem;
--DROP PROCEDURE dbo.sp_LayDanhSachKhachHang_maHangKhachHang;
--DROP PROCEDURE dbo.sp_LayDanhSachLoaiBan;
--DROP PROCEDURE dbo.sp_LayDanhSachKhuVuc;
--DROP PROCEDURE dbo.sp_LayDanhSachBan;
--DROP PROCEDURE dbo.sp_LayDanhSachBan_maLoaiBan;
--DROP PROCEDURE dbo.sp_LayDanhSachBan_maKhuVuc;
--DROP PROCEDURE dbo.sp_LayDanhSachLoaiDichVu;
--DROP PROCEDURE dbo.sp_LayDanhSachDichVu;
--DROP PROCEDURE dbo.sp_LayDanhSachDichVu_timKiem;
--DROP PROCEDURE dbo.sp_LayDanhSachDichVu_maLoaiDichVu;
--DROP PROCEDURE dbo.sp_LayDanhSachNgayCoKhuyenMai;
--DROP PROCEDURE dbo.sp_LayTienBan;
--DROP PROCEDURE dbo.sp_LayTienDichVu;
--DROP PROCEDURE dbo.sp_LayTienHoaDon;
--DROP PROCEDURE dbo.sp_LayTienKhuyenMaiHangKhachHang;
--DROP PROCEDURE dbo.sp_LayTienKhuyenMaiNgay;
--DROP PROCEDURE dbo.sp_LayTienPhaiThanhToan;
--DROP PROCEDURE dbo.sp_LayDoanhThuHomNay;
--DROP PROCEDURE dbo.sp_LayDanhSachHoaDon;
--DROP PROCEDURE dbo.sp_LayDanhSachHoaDon_khachLe;
--DROP PROCEDURE dbo.sp_LayDanhSachHoaDon_ngay;
--DROP PROCEDURE dbo.sp_LayDanhSachHoaDon_tuan;
--DROP PROCEDURE dbo.sp_LayDanhSachHoaDon_thang;
--DROP PROCEDURE dbo.sp_LayDanhSachHoaDon_soDienThoaiKhachHang;
--DROP PROCEDURE dbo.sp_LayDanhSachHoaDonBan;
--DROP PROCEDURE dbo.sp_LayDanhSachHoaDonDichVu;
--GO
