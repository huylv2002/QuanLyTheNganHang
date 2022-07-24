using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO.NhanVien
{
    public class dao_Login
    {
        private static dao_Login instance;
        List<dto_TkNhanVien> userLogin = new List<dto_TkNhanVien>();
        
        SqlConnection ketNoi = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsql"].ToString());

        public static dao_Login Instance {
            get { if (instance == null) instance = new dao_Login(); return instance;}
            set => instance = value; }

        public DataTable DSTKNV()
        {
            if(ketNoi.State == ConnectionState.Closed)
            {
                ketNoi.Open();
            }
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.TableMappings.Add("Table", "DanhSachTKNhanVien");
            adap.SelectCommand = new SqlCommand("select * from tb_NhanVien", ketNoi);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            DataTable dt = ds.Tables["DanhSachTKNhanVien"];
            return dt;
        }

        public bool CheckAccount(string account, string pass)
        {
            var ds = DSTKNV();
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                if(account.ToLower().Equals(ds.Rows[i]["email"].ToString().Trim().ToLower()) && pass.ToLower().Equals(DSTKNV().Rows[i]["matkhau"].ToString().Trim().ToLower()))
                {
                    string maNhanVien = ds.Rows[i]["maNhanVien"].ToString().Trim();
                    string hoTenNhanVien = ds.Rows[i]["hoTenNhanVien"].ToString().Trim(); 
                    DateTime ngaySinh = (DateTime)ds.Rows[i]["ngaySinh"];
                    string diaChi = ds.Rows[i]["diaChi"].ToString().Trim();
                    string email = ds.Rows[i]["email"].ToString().Trim();
                    string sCCCD = ds.Rows[i]["sCCCD"].ToString().Trim();
                    string maPB = ds.Rows[i]["maPB"].ToString().Trim();
                    string maCV = ds.Rows[i]["maCV"].ToString().Trim();
                    string maDdKD = ds.Rows[i]["maDdKD"].ToString().Trim();
                    string matkhau = ds.Rows[i]["matkhau"].ToString().Trim();
                    bool gioiTinh = (bool)ds.Rows[i]["gioiTinh"];
                    string sdt = ds.Rows[i]["SDT"].ToString().Trim();
                    dto_TkNhanVien tk = new dto_TkNhanVien(maNhanVien, hoTenNhanVien, ngaySinh, diaChi, email.ToLower(), sCCCD, maPB,
                        maCV, maDdKD, matkhau.ToLower(), gioiTinh, sdt);
                    userLogin.Add(tk);
                    return true;
                }    
            }
            return false;
        }

        public List<dto_TkNhanVien> DataUserLogin()
        {
            return userLogin;
        }

    }
}
