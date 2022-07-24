using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_TkNhanVien
    {
        private static dto_TkNhanVien instance;
        public static dto_TkNhanVien Instance
        {
            get
            {
                if (instance == null) instance = new dto_TkNhanVien();
                return instance;
            }
            set => instance = value;
        }

        string maNhanVien;
        string hoTenNhanVien;
        DateTime ngaySinh;
        string diaChi;
        string email;
        string sCCCD;
        string maPB;
        string maCV;
        string maDdKD;
        string matkhau;
        bool gioiTinh;
        string SDT;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTenNhanVien { get => hoTenNhanVien; set => hoTenNhanVien = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string SCCCD { get => sCCCD; set => sCCCD = value; }
        public string MaPB { get => maPB; set => maPB = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public string MaDdKD { get => maDdKD; set => maDdKD = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }

        public dto_TkNhanVien(string maNhanVien, string hoTenNhanVien, DateTime ngaySinh, string diaChi, string email, string sCCCD, string maPB, string maCV, string maDdKD, string matkhau, bool gioiTinh, string sDT1)
        {
            MaNhanVien = maNhanVien;
            HoTenNhanVien = hoTenNhanVien;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            Email = email;
            SCCCD = sCCCD;
            MaPB = maPB;
            MaCV = maCV;
            MaDdKD = maDdKD;
            Matkhau = matkhau;
            GioiTinh = gioiTinh;
            SDT1 = sDT1;
        }

        public dto_TkNhanVien()
        {
        }
    }
}
