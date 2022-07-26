using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAO
{
    public class dao_NhanVien
    {

        private static dao_NhanVien instance;


        public static dao_NhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new dao_NhanVien();
                return instance;

            }
        }

        private dao_NhanVien() { }

        public List<dto_NhanVien> Xem()
        {


            List<dto_NhanVien> dtoNhanVien = new List<dto_NhanVien>();


            string query = "SELECT*FROM tb_NhanVien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                 string maNhanVien = item["maNhanVien"].ToString();
                string hoTenNhanVien = item["hoTenNhanVien"].ToString(); 
                 DateTime? ngaySinh = item["ngaySinh"].ToString() == string.Empty? null:(DateTime?)item["ngaySinh"];
                 string diaChi = item["diaChi"].ToString(); 
                 string email = item["email"].ToString(); 
                 string sCCCD = item["sCCCD"].ToString();
                 string maPB = item["maPB"].ToString() ;
                 string maCV = item["maCV"].ToString();
                 string maDdKD = item["maDdKD"].ToString(); 
                 string matkhau = item["matkhau"].ToString() ;
                 bool? gioiTinh = (bool?)item["gioiTinh"];
                 string SDT = item["SDT"].ToString(); 



                dto_NhanVien newNv = new dto_NhanVien(maNhanVien, hoTenNhanVien, ngaySinh, diaChi, email, sCCCD, maPB, maCV, maDdKD, matkhau, gioiTinh, SDT);
                dtoNhanVien.Add(newNv);
            }


            return dtoNhanVien;
        }


        public bool Sua(string maNhanVien, dto_NhanVien NVS)
        {

            string query = "UPDATE dbo.tb_NhanVien SET hoTenNhanVien = @hoTenNhanVien , ngaySinh = @ngaySinh , diaChi = @diaChi , email = @email , sCCCD = @sCCCD , maPB = @maPB , maCV = @maCV , maDdKD = @maDdKD , matkhau = @matkhau , gioiTinh = @gioiTinh , SDT = @SDT Where maNhanVien = @maNhanVien ";

            object[] para = new object[] { NVS.HoTenNhanVien, NVS.NgaySinh, NVS.DiaChi, NVS.Email, NVS.SCCCD, NVS.MaPB, NVS.MaCV, NVS.MaDdKD, NVS.Matkhau, NVS.GioiTinh, NVS.SDT1, NVS.MaNhanVien };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }

            return false;
        }


    }
}
