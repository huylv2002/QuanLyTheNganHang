using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_the_KhachHang
    {
        private static dto_the_KhachHang instance;
        public static dto_the_KhachHang Instance
        {
            get
            {
                if (instance == null) instance = new dto_the_KhachHang();
                return instance;
            }
            set => instance = value;
        }
        string hoTenKhachHang;
        string ngaySinh;
        string diaChiThuongTru;
        string diaChiLienHe;
        string email;
        string SDT;
        string sCCCD;
        bool gioiTinh;
        string hinhCCCDMT;
        string hinhCCCDMS;
        string ngheNghiep;
        string maNhanVien;
        string maLoaiKhachHang;

        public dto_the_KhachHang()
        {
        }

        public string HoTenKhachHang { get => hoTenKhachHang; set => hoTenKhachHang = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChiThuongTru { get => diaChiThuongTru; set => diaChiThuongTru = value; }
        public string DiaChiLienHe { get => diaChiLienHe; set => diaChiLienHe = value; }
        public string Email { get => email; set => email = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string SCCCD { get => sCCCD; set => sCCCD = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string HinhCCCDMT { get => hinhCCCDMT; set => hinhCCCDMT = value; }
        public string HinhCCCDMS { get => hinhCCCDMS; set => hinhCCCDMS = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaLoaiKhachHang { get => maLoaiKhachHang; set => maLoaiKhachHang = value; }

        public dto_the_KhachHang(string hoTenKhachHang, string ngaySinh, string diaChiThuongTru, string diaChiLienHe, string email, string sDT1, string sCCCD, bool gioiTinh, string ngheNghiep, string maNhanVien, string maLoaiKhachHang)
        {
            HoTenKhachHang = hoTenKhachHang;
            NgaySinh = ngaySinh;
            DiaChiThuongTru = diaChiThuongTru;
            DiaChiLienHe = diaChiLienHe;
            Email = email;
            SDT1 = sDT1;
            SCCCD = sCCCD;
            GioiTinh = gioiTinh;
            NgheNghiep = ngheNghiep;
            MaNhanVien = maNhanVien;
            MaLoaiKhachHang = maLoaiKhachHang;
        }

        public dto_the_KhachHang(string hoTenKhachHang, string ngaySinh, string diaChiThuongTru, string diaChiLienHe, string email, string sDT1, string sCCCD, bool gioiTinh, string hinhCCCDMT, string hinhCCCDMS, string ngheNghiep, string maNhanVien, string maLoaiKhachHang)
        {
            HoTenKhachHang = hoTenKhachHang;
            NgaySinh = ngaySinh;
            DiaChiThuongTru = diaChiThuongTru;
            DiaChiLienHe = diaChiLienHe;
            Email = email;
            SDT1 = sDT1;
            SCCCD = sCCCD;
            GioiTinh = gioiTinh;
            HinhCCCDMT = hinhCCCDMT;
            HinhCCCDMS = hinhCCCDMS;
            NgheNghiep = ngheNghiep;
            MaNhanVien = maNhanVien;
            MaLoaiKhachHang = maLoaiKhachHang;
        }
    }
}
