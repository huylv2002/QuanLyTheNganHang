using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DTO;
namespace DAO
{
    public class dao_tkNhanVien
    {
        private static dao_tkNhanVien instance;
        List<dto_TkNhanVien> listAccout = new List<dto_TkNhanVien>();
        SqlConnection ketNoi = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsql"].ToString()); 
       
        public static dao_tkNhanVien Instance {
            get
            {
                if (instance == null) instance = new dao_tkNhanVien();
                return instance;
            }
            set => instance = value; 
        }

        public List<dto_TkNhanVien>layTaiKhoan(string email, string mk)
        {

            ketNoi.Open();
            // ConnectData.Instance.OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ketNoi;
            cmd.CommandText = "LoginAccount";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            var mail = new SqlParameter("@email", email);
            cmd.Parameters.Add(mail);
            var pass = new SqlParameter("@pass", mk);
            cmd.Parameters.Add(pass);
            //ConnectData.Instance.OpenConnection().Open();
            
            //ketNoi.Open();
            var reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
               while(reader.Read())
                {
                    var hoNV = reader["hoNV"].ToString();
                    var tenNV = reader["tenNV"].ToString();
                    var tenDNhap = reader["email"].ToString().Trim();
                    var mKhau = reader["matKhau"].ToString().Trim();
                    var chucVu = reader["maCV"].ToString();
                    var phongBan = reader["maPB"].ToString();
                    dto_TkNhanVien newBie = new dto_TkNhanVien(tenDNhap.ToLower(), mKhau.ToLower(), hoNV, tenNV, chucVu, phongBan);
                    listAccout.Add(newBie);
                }
            }
            else
            {
                listAccout = null;
            } 
                
            ketNoi.Close();
            return listAccout;
        }
        
        public string checkTaiKhoan(string email, string mk)
        {
            List<dto_TkNhanVien> ds = layTaiKhoan(email, mk);
            if (ds != null)
            {
                if (email.Trim() == ds[0].Email && mk.Trim() == ds[0].MatKhau)
                {
                    return string.Concat(ds[0].HoNV, " ", ds[0].TenNV);
                }
                else return "No";
            }
            else return "NOE";
        }

        public List<dto_TkNhanVien> layUser()
        {
            return listAccout;
        }
    }
}
