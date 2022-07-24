using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.dto_the_khachhang;
using DAO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAO.dao_the_khachang
{
    public static class dao_thongtinthe_khachhang
    {
        public static List<dto_the_KhachHang> danhSachKH = new List<dto_the_KhachHang>();
        public static List<dto_thongtinthe> danhSachThe = new List<dto_thongtinthe>();
        public static SqlConnection ketNoi = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsql"].ToString());
        public static  SqlCommand cmd;


        public static DataTable DuLieuThe()
        {
            if(ketNoi.State == ConnectionState.Closed)
            {
                ketNoi.Open();
            }
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.TableMappings.Add("Table", "ThongTinThe");
            adap.SelectCommand = new SqlCommand("Select * from tb_TheTinDung", ketNoi);
            DataSet dataSet = new DataSet();
            adap.Fill(dataSet);
            DataTable dataTable = dataSet.Tables["ThongTinThe"];
            ketNoi.Close();
            return dataTable;
        }

        public static void SuaDuLieu(string maKhachHang, DateTime ngayHH, string maTaiSan, string maPin, int soThanhToan)
        {
            if(ketNoi.State == ConnectionState.Closed)
            {
                ketNoi.Open();
            }
            cmd = new SqlCommand("updateThongTinThe", ketNoi);
            cmd.CommandType = CommandType.StoredProcedure;
            var _maKH = new SqlParameter("@maKhachHang", maKhachHang); 
            var _ngayHH = new SqlParameter("@ngayHH", ngayHH);
            var _maTaiSan =  new SqlParameter("@maTaiSan", maTaiSan);
            var _maPin = new SqlParameter("@maPin", maPin);
            var _soThanhToan = new SqlParameter("@soThanhToan", soThanhToan);
            SqlParameter[] pm = {_maKH, _ngayHH, _maTaiSan, _maPin, _soThanhToan};
            cmd.Parameters.AddRange(pm);
            cmd.ExecuteNonQuery();
        }
    }
}
