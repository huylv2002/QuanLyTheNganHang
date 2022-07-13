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

        private string hoNV;
        private string tenNV;
        private string email;
        private string matKhau;
        private string cv;
        private string phongBan;
        public string Email { get => email; set => email = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string HoNV { get => hoNV; set => hoNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string Cv { get => cv; set => cv = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }

        public dto_TkNhanVien() { }
        public dto_TkNhanVien(string email, string matKhau)
        {
            this.Email = email;
            this.MatKhau = matKhau;
        }
        public dto_TkNhanVien(string email, string matKhau, string hoNV, string tenNV, string cv, string phongBan) 
        {
            this.Email = email;
            this.MatKhau = matKhau;
            this.HoNV = hoNV;
            this.TenNV = tenNV;
            this.Cv = cv;
            this.PhongBan = phongBan;
        }

    }
}
