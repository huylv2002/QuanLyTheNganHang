using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAO
{
    public class dao_KhachHang
    {

        private static dao_KhachHang instance;


        public static dao_KhachHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new dao_KhachHang();
                return instance;

            }
        }

        private dao_KhachHang() { }

        public List<dto_KhachHang> Xem()
        {


            List<dto_KhachHang> dtoKhachHang = new List<dto_KhachHang>();


            string query = "SELECT*FROM tb_KhachHang";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                    string maKhachHang = item["maKhachHang"].ToString();
                     string hoTenKhachHang = item["hoTenKhachHang"].ToString();
                     DateTime? ngaySinh = item["ngaySinh"].ToString() == string.Empty ? null : (DateTime?)item["ngaySinh"];
                string diaChiThuongTru = item["diaChiThuongTru"].ToString(); 
                     string diaChiLienHe = item["diaChiLienHe"].ToString();
                     string email = item["email"].ToString();
                     string SDT = item["SDT"].ToString();
                     string sCCCD = item["sCCCD"].ToString();
                     bool? gioiTinh = (bool?)item["gioiTinh"];
                string hinhCCCDMT = item["hinhCCCDMT"].ToString();
                     string hinhCCCDMS = item["hinhCCCDMS"].ToString();
                     string ngheNghiep = item["ngheNghiep"].ToString();
                     string ghiChu = item["ghiChu"].ToString();
                     string maNhanVien = item["maNhanVien"].ToString();
                     string maLoaiKhachHang = item["maLoaiKhachHang"].ToString();



        dto_KhachHang newKH = new dto_KhachHang(maKhachHang, hoTenKhachHang, ngaySinh, diaChiThuongTru, diaChiLienHe, email, SDT, sCCCD, gioiTinh, hinhCCCDMT, hinhCCCDMS, ngheNghiep, ghiChu, maNhanVien, maLoaiKhachHang);
                dtoKhachHang.Add(newKH);
            }


            return dtoKhachHang;
        }

        public bool Sua(string maKhachHang, dto_KhachHang KHS)
        {

            string query = "UPDATE dbo.tb_KhachHang SET hoTenKhachHang = @hoTenKhachHang , ngaySinh = @ngaySinh , diaChiThuongTru = @diaChiThuongTru , diaChiLienHe = @diaChiLienHe , email = @email , SDT = @SDT , sCCCD = @sCCCD , hinhCCCDMT = @hinhCCCDMT , hinhCCCDMS = @hinhCCCDMS , ngheNghiep = @ngheNghiep , ghiChu = @ghiChu , maNhanVien = @maNhanVien , maLoaiKhachHang = @maLoaiKhachHang Where maKhachHang = @maKhachHang ";

            object[] para = new object[] { KHS.HoTenKhachHang, KHS.NgaySinh, KHS.DiaChiThuongTru, KHS.DiaChiLienHe, KHS.Email, KHS.Email, KHS.SDT1, KHS.SCCCD, KHS.HinhCCCDMT, KHS.HinhCCCDMS, KHS.NgheNghiep, KHS.GhiChu, KHS.MaNhanVien, KHS.MaLoaiKhachHang, KHS.MaKhachHang };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }

            return false;
        }
    }
}
