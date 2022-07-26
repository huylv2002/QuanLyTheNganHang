using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dto_NhanVien
    {
        private string maNhanVien;
        private string hoTenNhanVien;
        private DateTime? ngaySinh;
        private string diaChi;
        private string email;
        private string sCCCD;
        private string maPB;
        private string maCV;
        private string maDdKD;
        private string matkhau;
        private bool? gioiTinh;
        private string SDT;

        public dto_NhanVien(string maNhanVien, string hoTenNhanVien, DateTime? ngaySinh, string diaChi, string email, string sCCCD, string maPB, string maCV, string maDdKD, string matkhau, bool? gioiTinh, string sDT)
        {
            this.MaNhanVien = maNhanVien;
            this.HoTenNhanVien = hoTenNhanVien;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.Email = email;
            this.SCCCD = sCCCD;
            this.MaPB = maPB;
            this.MaCV = maCV;
            this.MaDdKD = maDdKD;
            this.Matkhau = matkhau;
            this.GioiTinh = gioiTinh;
            this.SDT1 = sDT;
        }

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string HoTenNhanVien { get => hoTenNhanVien; set => hoTenNhanVien = value; }
        public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
        public string SCCCD { get => sCCCD; set => sCCCD = value; }
        public string MaPB { get => maPB; set => maPB = value; }
        public string MaCV { get => maCV; set => maCV = value; }
        public string MaDdKD { get => maDdKD; set => maDdKD = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public bool? GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
    }
}
