CREATE FUNCTION LamGonChuoi (@s NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
    BEGIN
        SET @s = LOWER(@s);

        SET @s = REPLACE(@s, N'a', N'a');
        SET @s = REPLACE(@s, N'à', N'a');
        SET @s = REPLACE(@s, N'á', N'a');
        SET @s = REPLACE(@s, N'ả', N'a');
        SET @s = REPLACE(@s, N'ã', N'a');
        SET @s = REPLACE(@s, N'ạ', N'a');
        -- ă
        SET @s = REPLACE(@s, N'ă', N'a');
        SET @s = REPLACE(@s, N'ằ', N'a');
        SET @s = REPLACE(@s, N'ắ', N'a');
        SET @s = REPLACE(@s, N'ẳ', N'a');
        SET @s = REPLACE(@s, N'ẵ', N'a');
        SET @s = REPLACE(@s, N'ặ', N'a');
        -- â
        SET @s = REPLACE(@s, N'â', N'a');
        SET @s = REPLACE(@s, N'ầ', N'a');
        SET @s = REPLACE(@s, N'ấ', N'a');
        SET @s = REPLACE(@s, N'ẩ', N'a');
        SET @s = REPLACE(@s, N'ẫ', N'a');
        SET @s = REPLACE(@s, N'ậ', N'a');
        -- đ
        SET @s = REPLACE(@s, N'đ', N'd');
        -- e
        SET @s = REPLACE(@s, N'e', N'e');
        SET @s = REPLACE(@s, N'è', N'e');
        SET @s = REPLACE(@s, N'é', N'e');
        SET @s = REPLACE(@s, N'ẻ', N'e');
        SET @s = REPLACE(@s, N'ẽ', N'e');
        SET @s = REPLACE(@s, N'ẹ', N'e');
        -- ê
        SET @s = REPLACE(@s, N'ê', N'e');
        SET @s = REPLACE(@s, N'ề', N'e');
        SET @s = REPLACE(@s, N'ế', N'e');
        SET @s = REPLACE(@s, N'ể', N'e');
        SET @s = REPLACE(@s, N'ễ', N'e');
        SET @s = REPLACE(@s, N'ệ', N'e');
        -- i
        SET @s = REPLACE(@s, N'i', N'i');
        SET @s = REPLACE(@s, N'ì', N'i');
        SET @s = REPLACE(@s, N'í', N'i');
        SET @s = REPLACE(@s, N'ỉ', N'i');
        SET @s = REPLACE(@s, N'ĩ', N'i');
        SET @s = REPLACE(@s, N'ị', N'i');
        -- o
        SET @s = REPLACE(@s, N'o', N'o');
        SET @s = REPLACE(@s, N'ò', N'o');
        SET @s = REPLACE(@s, N'ó', N'o');
        SET @s = REPLACE(@s, N'ỏ', N'o');
        SET @s = REPLACE(@s, N'õ', N'o');
        SET @s = REPLACE(@s, N'ọ', N'o');
        -- ô
        SET @s = REPLACE(@s, N'ô', N'o');
        SET @s = REPLACE(@s, N'ồ', N'o');
        SET @s = REPLACE(@s, N'ố', N'o');
        SET @s = REPLACE(@s, N'ổ', N'o');
        SET @s = REPLACE(@s, N'ỗ', N'o');
        SET @s = REPLACE(@s, N'ộ', N'o');
        -- ơ
        SET @s = REPLACE(@s, N'ơ', N'o');
        SET @s = REPLACE(@s, N'ờ', N'o');
        SET @s = REPLACE(@s, N'ớ', N'o');
        SET @s = REPLACE(@s, N'ở', N'o');
        SET @s = REPLACE(@s, N'ỡ', N'o');
        SET @s = REPLACE(@s, N'ợ', N'o');
        -- u
        SET @s = REPLACE(@s, N'u', N'u');
        SET @s = REPLACE(@s, N'ù', N'u');
        SET @s = REPLACE(@s, N'ú', N'u');
        SET @s = REPLACE(@s, N'ủ', N'u');
        SET @s = REPLACE(@s, N'ũ', N'u');
        SET @s = REPLACE(@s, N'ụ', N'u');
        -- ư
        SET @s = REPLACE(@s, N'ư', N'u');
        SET @s = REPLACE(@s, N'ừ', N'u');
        SET @s = REPLACE(@s, N'ứ', N'u');
        SET @s = REPLACE(@s, N'ử', N'u');
        SET @s = REPLACE(@s, N'ữ', N'u');
        SET @s = REPLACE(@s, N'ự', N'u');
        -- y
        SET @s = REPLACE(@s, N'y', N'y');
        SET @s = REPLACE(@s, N'ỳ', N'y');
        SET @s = REPLACE(@s, N'ý', N'y');
        SET @s = REPLACE(@s, N'ỷ', N'y');
        SET @s = REPLACE(@s, N'ỹ', N'y');
        SET @s = REPLACE(@s, N'ỵ', N'y');

        SET @s = REPLACE(@s, N' ', N'');

        RETURN @s;
    END;
GO

SELECT dbo.LamGonChuoi(N'Ê, Bánh Mì Kẹp Thịt Đặc Biệt ThƠm ngon');
GO

--DROP FUNCTION dbo.LamGonChuoi;
--GO
