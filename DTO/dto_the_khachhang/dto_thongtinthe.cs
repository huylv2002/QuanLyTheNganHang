using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.dto_the_khachhang
{
    public class dto_thongtinthe
    {
        string maKhachHang;
        string maLoaiThe;
        string maTkKH;
        DateTime ngayMo;
        DateTime ngayHetHan;
        string maTaiSan;
        string maPin;
        int soThanhToan;

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string MaLoaiThe { get => maLoaiThe; set => maLoaiThe = value; }
        public string MaTkKH { get => maTkKH; set => maTkKH = value; }
        public DateTime NgayMo { get => ngayMo; set => ngayMo = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public string MaTaiSan { get => maTaiSan; set => maTaiSan = value; }
        public string MaPin { get => maPin; set => maPin = value; }
        public int SoThanhToan { get => soThanhToan; set => soThanhToan = value; }

        public dto_thongtinthe(string maKhachHang, string maLoaiThe, string maTkKH, DateTime ngayMo, DateTime ngayHetHan, string maTaiSan, string maPin, int soThanhToan)
        {
            MaKhachHang = maKhachHang;
            MaLoaiThe = maLoaiThe;
            MaTkKH = maTkKH;
            NgayMo = ngayMo;
            NgayHetHan = ngayHetHan;
            MaTaiSan = maTaiSan;
            MaPin = maPin;
            SoThanhToan = soThanhToan;
        }
    }
}
