-- 01. LoaiNhanVien --------------------------------------------------------------------------------------
INSERT INTO dbo.LoaiNhanVien (maLoaiNhanVien, tenLoaiNhanVien)
VALUES
('0000000001', N'Nhân viên quản lý'),
('0000000002', N'Nhân viên thường');

-- 02. NhanVien ------------------------------------------------------------------------------------------
INSERT INTO dbo.NhanVien (tenDangNhap, matKhau, hoVaTen, maLoaiNhanVien, hinhAnh, thoiGianThem, trangThai)
VALUES
('nv0', '4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a', N'Nhân Viên 0', '0000000001', (   SELECT *
                                                                                                                                                                              FROM
                                                                                                                                                                                     OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\Staff8.jpg', SINGLE_BLOB) IMAGE ), '2000-01-01', 1),
('nv1', '4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a', N'Nhân Viên 1', '0000000001', (   SELECT *
                                                                                                                                                                              FROM
                                                                                                                                                                                     OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\Staff9.jpg', SINGLE_BLOB) IMAGE ), DATEADD(SECOND, 20, GETDATE()), 1),
('nv2', '4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a', N'Nhân Viên 2', '0000000002', (   SELECT *
                                                                                                                                                                              FROM
                                                                                                                                                                                     OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\Staff1.jpg', SINGLE_BLOB) IMAGE ), DATEADD(SECOND, 30, GETDATE()), 1),
('nv3', '4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a', N'Nhân Viên 3', '0000000002', (   SELECT *
                                                                                                                                                                              FROM
                                                                                                                                                                                     OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\Staff2.jpg', SINGLE_BLOB) IMAGE ), DATEADD(SECOND, 40, GETDATE()), 1),
('nv4', '4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a', N'Nhân Viên 4', '0000000002', (   SELECT *
                                                                                                                                                                              FROM
                                                                                                                                                                                     OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\Staff3.jpg', SINGLE_BLOB) IMAGE ), DATEADD(SECOND, 50, GETDATE()), 1),
('nv5', '4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a', N'Nhân Viên 5', '0000000002', (   SELECT *
                                                                                                                                                                              FROM
                                                                                                                                                                                     OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\Staff4.jpg', SINGLE_BLOB) IMAGE ), DATEADD(SECOND, 60, GETDATE()), 0);
GO

-- 03. HangKhachHang -------------------------------------------------------------------------------------
INSERT INTO dbo.HangKhachHang (maHangKhachHang, doanhSoDatToi, khuyenMai, tenHangKhachHang)
VALUES
('0000000001', 00000000, 00, N'Thường'),
('0000000002', 00500000, 05, N'Đồng'),
('0000000003', 02000000, 10, N'Bạc'),
('0000000004', 05000000, 15, N'Vàng'),
('0000000005', 10000000, 20, N'Kim cương');
GO

-- 04. KhachHang -----------------------------------------------------------------------------------------
INSERT INTO dbo.KhachHang (soDienThoai, hoVaTen, maHangKhachHang, thoiGianThem)
VALUES
('0900000001', N'Khách Hàng 1', '0000000001', DATEADD(MINUTE, 10, GETDATE())),
('0900000002', N'Khách Hàng 2', '0000000001', DATEADD(MINUTE, 20, GETDATE())),
('0900000003', N'Khách Hàng 3', '0000000001', DATEADD(MINUTE, 30, GETDATE())),
('0900000004', N'Khách Hàng 4', '0000000001', DATEADD(MINUTE, 40, GETDATE())),
('0900000005', N'Khách Hàng 5', '0000000001', DATEADD(MINUTE, 50, GETDATE()));
GO

-- 05. LoaiBan -------------------------------------------------------------------------------------------
INSERT INTO dbo.LoaiBan (maLoaiBan, tenLoaiBan)
VALUES
('0000000001', N'Bida líp'),
('0000000002', N'Bida lỗ'),
('0000000003', N'Bida ba băng');
GO

-- 06. KhuVuc --------------------------------------------------------------------------------------------
INSERT INTO dbo.KhuVuc (maKhuVuc, tenKhuVuc)
VALUES
('0000000001', N'Tầng 1'),
('0000000002', N'Tầng 2'),
('0000000003', N'Tầng 3');
GO

-- 07. Ban -----------------------------------------------------------------------------------------------
INSERT INTO dbo.Ban (maBan, tenBan, maLoaiBan, maKhuVuc, gia, trangThai)
VALUES
('0000000001', N'Bàn 01', '0000000002', '0000000001', '50000', 0),
('0000000002', N'Bàn 02', '0000000002', '0000000001', '50000', 0),
('0000000003', N'Bàn 03', '0000000002', '0000000001', '50000', 0),
('0000000004', N'Bàn 04', '0000000002', '0000000001', '50000', 0),
('0000000005', N'Bàn 05', '0000000002', '0000000001', '50000', 0),
('0000000006', N'Bàn 06', '0000000002', '0000000001', '50000', 0),
('0000000007', N'Bàn 07', '0000000001', '0000000002', '40000', 0),
('0000000008', N'Bàn 08', '0000000001', '0000000002', '40000', 0),
('0000000009', N'Bàn 09', '0000000001', '0000000002', '40000', 0),
('0000000010', N'Bàn 10', '0000000001', '0000000002', '40000', 0),
('0000000011', N'Bàn 11', '0000000001', '0000000002', '40000', 0),
('0000000012', N'Bàn 12', '0000000001', '0000000002', '40000', 0),
('0000000013', N'Bàn 13', '0000000001', '0000000002', '40000', 0),
('0000000014', N'Bàn 14', '0000000001', '0000000003', '40000', 0),
('0000000015', N'Bàn 15', '0000000001', '0000000003', '40000', 0),
('0000000016', N'Bàn 16', '0000000001', '0000000003', '40000', 0),
('0000000017', N'Bàn 17', '0000000001', '0000000003', '40000', 0),
('0000000018', N'Bàn 18', '0000000001', '0000000003', '40000', 0),
('0000000019', N'Bàn 19', '0000000003', '0000000003', '60000', 0),
('0000000020', N'Bàn 20', '0000000003', '0000000003', '60000', 0);
GO

-- 08. LoaiDichVu ----------------------------------------------------------------------------------------
INSERT INTO dbo.LoaiDichVu (maLoaiDichVu, tenLoaiDichVu)
VALUES
('0000000001', N'Nước giải khát'),
('0000000002', N'Bia, rượu'),
('0000000003', N'Đồ ăn khô'),
('0000000004', N'Đồ ăn chế biến');
GO

-- 09. DichVu --------------------------------------------------------------------------------------------
INSERT INTO dbo.DichVu (maDichVu, maLoaiDichVu, hinhAnh, gia, thoiGianThem, trangThai, tenDichVu)
VALUES
('0000000001', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D01.jpg', SINGLE_BLOB) IMAGE ), 20000, DATEADD(SECOND, 01, GETDATE()), 0, N'Pepsi'),
('0000000002', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D02.jpg', SINGLE_BLOB) IMAGE ), 20000, DATEADD(SECOND, 02, GETDATE()), 1, N'Cocacola'),
('0000000003', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D03.jpg', SINGLE_BLOB) IMAGE ), 20000, DATEADD(SECOND, 03, GETDATE()), 1, N'7Up'),
('0000000004', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D04.jpg', SINGLE_BLOB) IMAGE ), 20000, DATEADD(SECOND, 04, GETDATE()), 0, N'Sprite'),
('0000000005', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D05.jpg', SINGLE_BLOB) IMAGE ), 20000, DATEADD(SECOND, 05, GETDATE()), 1, N'Sting Dâu'),
('0000000006', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D06.jpg', SINGLE_BLOB) IMAGE ), 20000, DATEADD(SECOND, 06, GETDATE()), 1, N'Number 1'),
('0000000007', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D07.jpg', SINGLE_BLOB) IMAGE ), 20000, DATEADD(SECOND, 07, GETDATE()), 1, N'Twister'),
('0000000008', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D08.jpg', SINGLE_BLOB) IMAGE ), 20000, DATEADD(SECOND, 08, GETDATE()), 1, N'Revive'),
('0000000009', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D09.jpg', SINGLE_BLOB) IMAGE ), 20000, DATEADD(SECOND, 09, GETDATE()), 1, N'Revive Chanh muối'),
('0000000010', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D10.jpg', SINGLE_BLOB) IMAGE ), 20000, DATEADD(SECOND, 10, GETDATE()), 1, N'Wake Up 247'),
('0000000011', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D11.jpg', SINGLE_BLOB) IMAGE ), 20000, DATEADD(SECOND, 11, GETDATE()), 1, N'Trà xanh không độ'),
('0000000012', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D12.jpg', SINGLE_BLOB) IMAGE ), 10000, DATEADD(SECOND, 12, GETDATE()), 0, N'Nước suối Aquafina'),
('0000000013', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D13.jpg', SINGLE_BLOB) IMAGE ), 10000, DATEADD(SECOND, 13, GETDATE()), 1, N'Nước suối Dasani'),
('0000000014', '0000000001', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D14.jpg', SINGLE_BLOB) IMAGE ), 25000, DATEADD(SECOND, 14, GETDATE()), 1, N'Red Bull'),
('0000000015', '0000000002', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D15.jpg', SINGLE_BLOB) IMAGE ), 25000, DATEADD(SECOND, 15, GETDATE()), 1, N'Bia Heineken'),
('0000000016', '0000000002', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D16.jpg', SINGLE_BLOB) IMAGE ), 25000, DATEADD(SECOND, 16, GETDATE()), 1, N'Bia Tiger'),
('0000000017', '0000000002', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D17.jpg', SINGLE_BLOB) IMAGE ), 20000, DATEADD(SECOND, 17, GETDATE()), 1, N'Bia SaiGon'),
('0000000018', '0000000003', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D18.jpg', SINGLE_BLOB) IMAGE ), 50000, DATEADD(SECOND, 18, GETDATE()), 1, N'Bò khô'),
('0000000019', '0000000003', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D19.jpg', SINGLE_BLOB) IMAGE ), 50000, DATEADD(SECOND, 19, GETDATE()), 1, N'Mực khô'),
('0000000020', '0000000003', (   SELECT *
                                 FROM
                                        OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\D20.jpg', SINGLE_BLOB) IMAGE ), 50000, DATEADD(SECOND, 20, GETDATE()), 1, N'Khô gà lá chanh');
GO

-- 10. NgayCoKhuyenMai; -----------------------------------------------------------------------------------
INSERT INTO dbo.NgayCoKhuyenMai (ngay, moTa, khuyenMai)
VALUES
('2023-06-27', N'Khuyến mãi ngày 27/06/2023', 10),
('2023-06-29', N'Khuyến mãi ngày 29/06/2023', 20),
('2023-07-01', N'Khuyến mãi ngày 01/07/2023', 10),
('2023-07-02', N'Khuyến mãi ngày 02/07/2023', 10);
GO
 
-- 14. ThongTinQuan --------------------------------------------------------------------------------------
INSERT INTO dbo.ThongTinQuan (maQuan, tenQuan, diaChi, soDienThoai, hinhAnh)
VALUES
('9999999999', N'CLB Bida 365', N'Số 448 Lê Văn Việt, Phường Tăng Nhơn Phú A, Tp. Thủ Đức, Tp. Hồ Chí Minh', '0912345678', (   SELECT *
                                                                                                                               FROM
                                                                                                                                      OPENROWSET(BULK N'D:\Projects\AppDestop_UngDungQuanLyQuanBida\UngDungQuanLyQuanBida_HinhAnh\HinhAnhQuan.png', SINGLE_BLOB) IMAGE ));
GO