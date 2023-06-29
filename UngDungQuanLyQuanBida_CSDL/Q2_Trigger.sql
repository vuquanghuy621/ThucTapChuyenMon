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
CREATE TRIGGER trg_HoaDon_Insert_Update
ON dbo.HoaDon
FOR INSERT, UPDATE
AS
    BEGIN
        DECLARE @maHoaDon VARCHAR(14);
        DECLARE @thoiGianThem DATETIME;
        DECLARE @soDienThoaiKhachHang VARCHAR(10);

        SELECT @maHoaDon             = Inserted.maHoaDon,
               @thoiGianThem         = Inserted.thoiGianThem,
               @soDienThoaiKhachHang = Inserted.soDienThoaiKhachHang
        FROM   Inserted;

        IF UPDATE(soDienThoaiKhachHang)
            BEGIN
                IF @soDienThoaiKhachHang IS NULL
                    UPDATE dbo.HoaDon SET khuyenMaiHangKhachHang = 0 WHERE maHoaDon = @maHoaDon;
                ELSE
                    UPDATE dbo.HoaDon
                    SET    khuyenMaiHangKhachHang = (   SELECT HKH.khuyenMai
                                                        FROM   dbo.KhachHang          AS KH
                                                               JOIN dbo.HangKhachHang AS HKH ON HKH.maHangKhachHang = KH.maHangKhachHang
                                                        WHERE  KH.soDienThoai = @soDienThoaiKhachHang)
                    WHERE  maHoaDon = @maHoaDon;
            END;

        IF UPDATE(thoiGianThem)
            BEGIN
                IF EXISTS (SELECT * FROM dbo.NgayCoKhuyenMai WHERE CAST(@thoiGianThem AS DATE) = ngay)
                    UPDATE dbo.HoaDon
                    SET    khuyenMaiNgay = (SELECT khuyenMai FROM dbo.NgayCoKhuyenMai WHERE CAST(@thoiGianThem AS DATE) = ngay)
                    WHERE  maHoaDon = @maHoaDon;
                ELSE
                    UPDATE dbo.HoaDon SET khuyenMaiNgay = 0 WHERE maHoaDon = @maHoaDon;
            END;
    END;
GO

-- 12. HoaDonBan ----------------------------------------------------------------------------------------
CREATE TRIGGER trg_HoaDonBan_Insert
ON dbo.HoaDonBan
FOR INSERT
AS
    BEGIN
        DECLARE @thoiGianThem DATETIME;
        DECLARE @maBan VARCHAR(10);

        SELECT @thoiGianThem = Inserted.thoiGianThem, @maBan = Inserted.maBan FROM Inserted;

        UPDATE dbo.HoaDonBan
        SET    gia = (SELECT MAX(gia)FROM dbo.Ban WHERE maBan = @maBan)
        WHERE  thoiGianThem = @thoiGianThem;
    END;
GO

CREATE TRIGGER trg_HoaDonBan_Update
ON dbo.HoaDonBan
FOR UPDATE
AS
    BEGIN
        DECLARE @thoiGianThem DATETIME;
        DECLARE @mahoaDon VARCHAR(14);
        DECLARE @maBanMoi VARCHAR(10);
        DECLARE @maBanCu VARCHAR(10);
        DECLARE @thoiGianBatDauMoi DATETIME;
        DECLARE @thoiGianBatDauCu DATETIME;
        DECLARE @thoiGianKetThucMoi DATETIME;
        DECLARE @thoiGianKetThucCu DATETIME;

        SELECT @thoiGianThem       = Inserted.thoiGianThem,
               @mahoaDon           = Inserted.maHoaDon,
               @maBanMoi           = Inserted.maBan,
               @maBanCu            = Deleted.maBan,
               @thoiGianBatDauMoi  = Inserted.thoiGianBatDau,
               @thoiGianBatDauCu   = Deleted.thoiGianBatDau,
               @thoiGianKetThucMoi = Inserted.thoiGianKetThuc,
               @thoiGianKetThucCu  = Deleted.thoiGianKetThuc
        FROM   Inserted
               JOIN Deleted ON Deleted.thoiGianThem = Inserted.thoiGianThem;

        IF UPDATE(maBan)
            BEGIN
                UPDATE dbo.HoaDonBan
                SET    gia = (SELECT MAX(gia)FROM dbo.Ban WHERE maBan = @maBanMoi)
                WHERE  thoiGianThem = @thoiGianThem;
            END;

        --IF UPDATE(thoiGianBatDau)
        --    BEGIN
        --        UPDATE dbo.HoaDonBan
        --        SET    thoiGianKetThuc = @thoiGianBatDauMoi
        --        WHERE  maHoaDon            = @mahoaDon
        --               AND thoiGianKetThuc = @thoiGianBatDauCu;
        --    END;

        --IF UPDATE(thoiGianKetThuc)
        --    BEGIN
        --        UPDATE dbo.HoaDonBan
        --        SET    thoiGianBatDau = @thoiGianKetThucMoi
        --        WHERE  maHoaDon           = @mahoaDon
        --               AND thoiGianBatDau = @thoiGianKetThucCu;
        --    END;
    END;
GO

--CREATE TRIGGER trg_HoaDonBan_Delete
--ON dbo.HoaDonBan
--FOR DELETE
--AS
--    BEGIN
--        DECLARE @thoiGianThem DATETIME;
--        DECLARE @mahoaDon VARCHAR(14);
--        DECLARE @maBan VARCHAR(10);
--        DECLARE @thoiGianBatDau DATETIME;
--        DECLARE @thoiGianKetThuc DATETIME;

--        SELECT @thoiGianThem    = Deleted.thoiGianThem,
--               @mahoaDon        = Deleted.maHoaDon,
--               @maBan           = Deleted.maBan,
--               @thoiGianBatDau  = Deleted.thoiGianBatDau,
--               @thoiGianKetThuc = Deleted.thoiGianKetThuc
--        FROM   Deleted;

--        UPDATE dbo.HoaDonBan
--        SET    thoiGianKetThuc = @thoiGianKetThuc
--        WHERE  maHoaDon            = @mahoaDon
--               AND thoiGianKetThuc = @thoiGianBatDau;
--    END;
--GO

-- 13. HoaDonDichVu -------------------------------------------------------------------------------------
CREATE TRIGGER trg_HoaDonDichVu_Insert
ON dbo.HoaDonDichVu
FOR INSERT
AS
    BEGIN
        DECLARE @thoiGianThem DATETIME;
        DECLARE @maHoaDon VARCHAR(14);
        DECLARE @maDichVu VARCHAR(10);

        SELECT @thoiGianThem = Inserted.thoiGianThem,
               @maHoaDon     = Inserted.maHoaDon,
               @maDichVu     = Inserted.maDichVu
        FROM   Inserted;

        UPDATE dbo.HoaDonDichVu
        SET    gia = (SELECT MAX(gia)FROM dbo.DichVu WHERE maDichVu = @maDichVu)
        WHERE  thoiGianThem = @thoiGianThem;
    END;
GO

-- 14. ThongTinQuan --------------------------------------------------------------------------------------
GO

--DROP TRIGGER trg_HoaDon_Insert_Update;
--DROP TRIGGER trg_HoaDonBan_Insert;
--DROP TRIGGER trg_HoaDonBan_Update;
--DROP TRIGGER trg_HoaDonBan_Delete;
--DROP TRIGGER trg_HoaDonDichVu_Insert;
--GO
