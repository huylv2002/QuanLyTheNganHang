using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_KhachHang
    {
        private string maKhachHang;
        private string hoTenKhachHang;
        private DateTime? ngaySinh;
        private string diaChiThuongTru;
        private string diaChiLienHe;
        private string email;
        private string SDT;
        private string sCCCD;
        private bool? gioiTinh;
        private string hinhCCCDMT;
        private string hinhCCCDMS;
        private string ngheNghiep;
        private string ghiChu;
        private string maNhanVien;
        private string maLoaiKhachHang;

        public dto_KhachHang(string maKhachHang, string hoTenKhachHang, DateTime? ngaySinh, string diaChiThuongTru, string diaChiLienHe, string email, string sDT, string sCCCD, bool? gioiTinh, string hinhCCCDMT, string hinhCCCDMS, string ngheNghiep, string ghiChu, string maNhanVien, string maLoaiKhachHang)
        {
            this.MaKhachHang = maKhachHang;
            this.HoTenKhachHang = hoTenKhachHang;
            this.NgaySinh = ngaySinh;
            this.DiaChiThuongTru = diaChiThuongTru;
            this.DiaChiLienHe = diaChiLienHe;
            this.Email = email;
            this.SDT1 = sDT;
            this.SCCCD = sCCCD;
            this.GioiTinh = gioiTinh;
            this.HinhCCCDMT = hinhCCCDMT;
            this.HinhCCCDMS = hinhCCCDMS;
            this.NgheNghiep = ngheNghiep;
            this.GhiChu = ghiChu;
            this.MaNhanVien = maNhanVien;
            this.MaLoaiKhachHang = maLoaiKhachHang;
        }

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string HoTenKhachHang { get => hoTenKhachHang; set => hoTenKhachHang = value; }
        public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChiThuongTru { get => diaChiThuongTru; set => diaChiThuongTru = value; }
        public string DiaChiLienHe { get => diaChiLienHe; set => diaChiLienHe = value; }
        public string Email { get => email; set => email = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string SCCCD { get => sCCCD; set => sCCCD = value; }
        public bool? GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string HinhCCCDMT { get => hinhCCCDMT; set => hinhCCCDMT = value; }
        public string HinhCCCDMS { get => hinhCCCDMS; set => hinhCCCDMS = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaLoaiKhachHang { get => maLoaiKhachHang; set => maLoaiKhachHang = value; }
    }
}
