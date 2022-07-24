using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.dto_the_khachhang
{
    public class dto_the_taikhoankh
    {
        #region Variable
        private static dto_the_taikhoankh instance;

        public static dto_the_taikhoankh Instance { get { if(instance == null) instance = new dto_the_taikhoankh(); return instance; } 
            set => instance = value; }

        string maTkKH;
        string maKhachHang;
        string soDu;
        DateTime ngayMo;
        string maDdKD;
        string matKhau;
        public string MaTkKH { get => maTkKH; set => maTkKH = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string SoDu { get => soDu; set => soDu = value; }
        public DateTime NgayMo { get => ngayMo; set => ngayMo = value; }
        public string MaDdKD { get => maDdKD; set => maDdKD = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }

        public dto_the_taikhoankh(string maKhachHang, string soDu, DateTime ngayMo, string maDdKD, string matKhau)
        {
            MaKhachHang = maKhachHang;
            SoDu = soDu;
            NgayMo = ngayMo;
            MaDdKD = maDdKD;
            MatKhau = matKhau;
        }

        public dto_the_taikhoankh()
        {
        }
        #endregion

        #region Method


        #endregion

    }
}
