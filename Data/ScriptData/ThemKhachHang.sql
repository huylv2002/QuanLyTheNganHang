create procedure ThemKhachHang(@maKhachHang nchar(10)
           ,@hoTenKhachHang nvarchar(10)
           ,@ngaySinh date
           ,@diaChiThuongTru nvarchar(500)
           ,@diaChiLienHe nvarchar(500)
           ,@email nchar(30)
           ,@SDT nchar(10)
           ,@sCCCD nchar(20)
           ,@gioiTinh bit
           ,@hinhCCCDMT image
           ,@hinhCCCDMS image
           ,@ngheNghiep nvarchar(30)
           ,@maNhanVien nchar(10)
           ,@maLoaiKhachHang nchar(10))
as
begin
if exists(select * from tb_KhachHang where hoTenKhachHang = @hoTenKhachHang or sCCCD = @sCCCD)
begin 
	print 0;
end
else begin
 INSERT INTO dbo.tb_KhachHang
           (maKhachHang
           ,hoTenKhachHang
           ,ngaySinh
           ,diaChiThuongTru
           ,diaChiLienHe
           ,email
           ,SDT
           ,sCCCD
           ,gioiTinh
           ,hinhCCCDMT
           ,hinhCCCDMS
           ,ngheNghiep
           ,maNhanVien
           ,maLoaiKhachHang)
     VALUES
           (
		   @maKhachHang 
           ,@hoTenKhachHang 
           ,@ngaySinh 
           ,@diaChiThuongTru 
           ,@diaChiLienHe 
           ,@email 
           ,@SDT 
           ,@sCCCD 
           ,@gioiTinh 
           ,@hinhCCCDMT 
           ,@hinhCCCDMS 
           ,@ngheNghiep 
           ,@maNhanVien 
           ,@maLoaiKhachHang
		   )
		   end
end

