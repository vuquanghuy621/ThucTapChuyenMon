-- 01. LoaiNhanVien --------------------------------------------------------------------------------------
SELECT   LNV.maLoaiNhanVien,
         LNV.tenLoaiNhanVien,
         COUNT(NV.tenDangNhap) AS soLuongNhanVien
FROM     dbo.LoaiNhanVien       AS LNV
         LEFT JOIN dbo.NhanVien AS NV ON NV.maLoaiNhanVien = LNV.maLoaiNhanVien
GROUP BY LNV.maLoaiNhanVien,
         LNV.tenLoaiNhanVien;
GO

-- 02. NhanVien ------------------------------------------------------------------------------------------
SELECT NV.thoiGianThem,
       NV.tenDangNhap,
       NV.hoVaTen,
       LNV.tenLoaiNhanVien,
       NV.hinhAnh,
       CASE
           WHEN NV.trangThai = 1 THEN N'Còn làm việc'
           ELSE N'Không còn làm việc'
       END AS trangThai
FROM   dbo.NhanVien          AS NV
       JOIN dbo.LoaiNhanVien AS LNV ON LNV.maLoaiNhanVien = NV.maLoaiNhanVien;
GO

-- 03. HangKhachHang -------------------------------------------------------------------------------------
SELECT   HKH.maHangKhachHang,
         HKH.tenHangKhachHang,
         HKH.doanhSoDatToi,
         CAST(HKH.khuyenMai AS VARCHAR(3)) + '%' AS khuyenMai,
         COUNT(KH.soDienThoai)                   AS soKhachHang
FROM     dbo.HangKhachHang       AS HKH
         LEFT JOIN dbo.KhachHang AS KH ON KH.maHangKhachHang = HKH.maHangKhachHang
GROUP BY HKH.maHangKhachHang,
         HKH.tenHangKhachHang,
         HKH.doanhSoDatToi,
         CAST(HKH.khuyenMai AS VARCHAR(3)) + '%';
GO

-- 04. KhachHang -----------------------------------------------------------------------------------------
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
GO

-- 05. LoaiBan -------------------------------------------------------------------------------------------
SELECT   LB.maLoaiBan,
         LB.tenLoaiBan,
         COUNT(B.maBan) AS soLuongBan
FROM     dbo.LoaiBan       AS LB
         LEFT JOIN dbo.Ban AS B ON B.maLoaiBan = LB.maLoaiBan
GROUP BY LB.maLoaiBan,
         LB.tenLoaiBan;
GO

-- 06. KhuVuc --------------------------------------------------------------------------------------------
SELECT   KV.maKhuVuc,
         KV.tenKhuVuc,
         COUNT(B.maBan) AS soLuongBan
FROM     dbo.KhuVuc        AS KV
         LEFT JOIN dbo.Ban AS B ON B.maKhuVuc = KV.maKhuVuc
GROUP BY KV.maKhuVuc,
         KV.tenKhuVuc;
GO

-- 07. Ban -----------------------------------------------------------------------------------------------
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
GO

-- 08. LoaiDichVu ----------------------------------------------------------------------------------------
SELECT   LDV.maLoaiDichVu,
         LDV.tenLoaiDichVu,
         COUNT(DV.maDichVu) AS soLuongDichVu
FROM     dbo.LoaiDichVu       AS LDV
         LEFT JOIN dbo.DichVu AS DV ON DV.maLoaiDichVu = LDV.maLoaiDichVu
GROUP BY LDV.maLoaiDichVu,
         LDV.tenLoaiDichVu;
GO

-- 09. DichVu --------------------------------------------------------------------------------------------
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
GO

-- 10. NgayCoKhuyenMai; -----------------------------------------------------------------------------------
SELECT ngay,
       moTa,
       CAST(khuyenMai AS VARCHAR(3)) + '%' AS khuyenMai
FROM   dbo.NgayCoKhuyenMai;
GO

-- 11. HoaDon --------------------------------------------------------------------------------------------
SELECT   HD.maHoaDon,
         HD.thoiGiamThem,
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
         HD.thoiGiamThem,
         NV.hoVaTen,
         NV.tenDangNhap,
         KH.hoVaTen,
         KH.soDienThoai,
         HD.khuyenMaiHangKhachHang,
         HD.khuyenMaiNgay,
         HD.trangThai
ORDER BY HD.thoiGiamThem DESC;
GO

-- 12. HoaDonBan ----------------------------------------------------------------------------------------
SELECT   HDB.maHoaDon,
         B.tenBan + N' | ' + LB.tenLoaiBan + CHAR(13) + CHAR(10) + FORMAT(HDB.thoiGianBatDau, 'HH:mm') + N' - ' + ISNULL(FORMAT(HDB.thoiGianKetThuc, 'HH:mm'), N'Đang chơi') AS tenBan,
         HDB.gia,
         DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc)                                                                                                           AS soPhut,
         ROUND(HDB.gia / 60 * DATEDIFF(MINUTE, HDB.thoiGianBatDau, HDB.thoiGianKetThuc), -3)                                                                                 AS thanhTien
FROM     dbo.HoaDonBan    AS HDB
         JOIN dbo.Ban     AS B ON B.maBan       = HDB.maBan
         JOIN dbo.LoaiBan AS LB ON LB.maLoaiBan = B.maLoaiBan
ORDER BY HDB.thoiGianThem;
GO

-- 13. HoaDonDichVu -------------------------------------------------------------------------------------
SELECT   HDDV.maHoaDon,
         DV.tenDichVu,
         HDDV.gia,
         HDDV.soLuong,
         ROUND(HDDV.gia * HDDV.soLuong, -3) AS thanhTien
FROM     dbo.HoaDonDichVu AS HDDV
         JOIN dbo.DichVu  AS DV ON DV.maDichVu = HDDV.maDichVu
ORDER BY HDDV.thoiGianThem;
GO

-- 14. ThongTinQuan --------------------------------------------------------------------------------------
GO