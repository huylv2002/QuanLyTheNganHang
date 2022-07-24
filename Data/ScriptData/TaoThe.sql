create procedure TaoThe(
@maKhachHang nchar(10)
,@maLoaiThe nchar(10)
,@maTkKH nchar(10)
,@ngayMo date
,@ngayHetHan date
,@maTaiSan nchar(10)
,@maPin nchar(6)
,@soThanhToan int
)
as
begin
if exists (select * from tb_TheTinDung where maKhachHang = @maKhachHang)
begin
 print 0
end
else
begin
INSERT INTO [dbo].[tb_TheTinDung]
           ([maKhachHang]
           ,[maLoaiThe]
           ,[maTkKH]
           ,[ngayMo]
           ,[ngayHetHan]
           ,[maTaiSan]
           ,[maPin]
           ,[soThanhToan])
     VALUES
           (
			@maKhachHang 
			,@maLoaiThe
			,@maTkKH 
			,@ngayMo 
			,@ngayHetHan 
			,@maTaiSan 
			,@maPin 
			,@soThanhToan 
		   )
end
end