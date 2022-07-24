using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using DTO;
using DTO.dto_the_khachhang;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data;
using System.Drawing;

namespace DAO
{
    public class dao_the_mothe
    {
        #region Variable
        private static dao_the_mothe instance;
        List<dto_the_KhachHang> danhSachKH = new List<dto_the_KhachHang>();
        List<dto_thongtinthe> danhSachThe = new List<dto_thongtinthe>();
        SqlConnection ketNoi = new SqlConnection(ConfigurationManager.ConnectionStrings["cnsql"].ToString());
        SqlCommand cmd;

        public static dao_the_mothe Instance 
        { get
            {
                if (instance == null) instance = new dao_the_mothe();
                return instance;
            } 
         set => instance = value; 
        }
        #endregion


        #region Method
        public byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
        //public Image ConvertBtoI(byte[] data)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        return Image.FromStream(ms);
        //    }
        //}
        public List<dto_the_KhachHang> danhSachKHKhachHang()
        {
            cmd = new SqlCommand();
            cmd.Connection = ketNoi;
            cmd.CommandText = "select * from tb_KhachHang";
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (ketNoi.State == System.Data.ConnectionState.Closed)
            {
                ketNoi.Open();
            }
            //SqlDataReader rd = cmd.ExecuteReader();
            //if(rd.HasRows)
            //{
            //    while(rd.Read())
            //    {
            //        var hoTenKhachHang = rd["hoTenKhachHang"].ToString().Trim();
            //        var ngaySinh = rd["ngaySinh"].ToString().Trim();
            //        var diaChiThuongTru = rd["diaChiThuongTru"].ToString().Trim();
            //        var diaChiLienHe = rd["diaChiLienHe"].ToString().Trim();
            //        var email = rd["email"].ToString().Trim();
            //        var SDT = rd["SDT"].ToString().Trim();
            //        var sCCCD = rd["sCCCD"].ToString().Trim();
            //        var gioiTinh = (bool)rd["gioiTinh"];

            //        var hinhCCCDMT = rd["hinhCCCDMT"].ToString().Trim();
            //        var hinhCCCDMS = rd["hinhCCCDMS"].ToString().Trim();

            //        var ngheNghiep = rd["ngheNghiep"].ToString().Trim();
            //        var maNhanVien = rd["maNhanVien"].ToString().Trim();
            //        var maLoaiKhachHang = rd["maLoaiKhachHang"].ToString().Trim();
            //        dto_the_KhachHang kh = new dto_the_KhachHang(hoTenKhachHang, ngaySinh, diaChiThuongTru, diaChiLienHe, email, SDT, sCCCD, gioiTinh, hinhCCCDMT, hinhCCCDMS, ngheNghiep, maNhanVien, maLoaiKhachHang);
            //        danhSachKH.Add(kh);
            //    }
            //}
            //ketNoi.Close();
            
            return danhSachKH;
        }

        public List<dto_thongtinthe> DanhSachThe()
        {
            string qr = "select * from tb_TheTinDung";
            cmd = new SqlCommand(qr, ketNoi);
            cmd.CommandType = System.Data.CommandType.Text;
            if(ketNoi.State == System.Data.ConnectionState.Closed)
            {
                ketNoi.Open();
            }
            SqlDataReader rd = cmd.ExecuteReader();
            if(rd.HasRows)
            {
                while(rd.Read())
                {
                    var maKhachHang = rd["maKhachHang"].ToString().Trim();
                    var maLoaiThe = rd["maLoaiThe"].ToString().Trim();
                    var maTkKH = rd["maTkKH"].ToString().Trim();
                    var ngayMo = (DateTime)rd["ngayMo"];
                    var ngayHetHan = (DateTime)rd["ngayHetHan"];
                    var maTaiSan = rd["maTaiSan"].ToString().Trim();
                    var maPin = rd["maPin"].ToString().Trim();
                    var soThanhToan = (int)rd["soThanhToan"];
                    dto_thongtinthe the = new dto_thongtinthe(maKhachHang, maLoaiThe, maTkKH, ngayMo, ngayHetHan, maTaiSan, maPin, soThanhToan);
                    danhSachThe.Add(the);
                }
            }
            ketNoi.Close();
            return danhSachThe;   
        }

       public DataTable LayDSKH()
        {
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.TableMappings.Add("Table", "KhachHang");
            adap.SelectCommand = new SqlCommand("select * from tb_KhachHang", ketNoi);

            DataSet dtSet = new DataSet();
            adap.Fill(dtSet);
            DataTable dtable = new DataTable();
            dtable = dtSet.Tables["KhachHang"];
            return dtable;

        }

        public void themKhachHang(string maKhachHang, string hoTenKhachHang, DateTime ngaySinh, string diaChiThuongTru, string diaChiLienHe, string email, string SDT, string sCCCD, bool gioiTinh, byte[] hinhCCCDMT, byte[] hinhCCCDMS, string ngheNghiep, string maNhanVien, string maLoaiKhachHang)
        {
            string qr = "ThemKhachHang";
            cmd = new SqlCommand(qr, ketNoi);
            if(ketNoi.State == System.Data.ConnectionState.Closed)
            {
                ketNoi.Open();
            }
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            var _maKhachHang = new SqlParameter("@maKhachHang", maKhachHang);
            var _hoTenKhachHang = new SqlParameter("@hoTenKhachHang", hoTenKhachHang);
            var _ngaySinh = new SqlParameter("@ngaySinh", ngaySinh);
            var _diaChiThuongTru = new SqlParameter("@diaChiThuongTru", diaChiThuongTru);
            var _diaChiLienHe = new SqlParameter("@diaChiLienHe", diaChiLienHe);
            var _email = new SqlParameter("@email", email);
            var _SDT = new SqlParameter("@SDT", SDT);
            var _sCCCD = new SqlParameter("@sCCCD", sCCCD);
            var _gioiTinh = new SqlParameter("@gioiTinh", gioiTinh);
            var _hinhCCCDMT = new SqlParameter("@hinhCCCDMT", hinhCCCDMT);
            var _hinhCCCDMS = new SqlParameter("@hinhCCCDMS", hinhCCCDMS);
            var _ngheNghiep = new SqlParameter("@ngheNghiep", ngheNghiep);
            var _maNhanVien = new SqlParameter("@maNhanVien", maNhanVien);
            var _maLoaiKhachHang = new SqlParameter("@maLoaiKhachHang", maLoaiKhachHang);
            SqlParameter[] parray = new SqlParameter[14] { _maKhachHang, 
                _hoTenKhachHang,
                _ngaySinh, 
                _diaChiThuongTru, 
                _diaChiLienHe, 
                _email, 
                _SDT, 
                _sCCCD,
                _gioiTinh, 
                _hinhCCCDMT, 
                _hinhCCCDMS, 
                _ngheNghiep, 
                _maNhanVien, 
                _maLoaiKhachHang};
            cmd.Parameters.AddRange(parray);
            if(cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm khách hàng thành công!" + cmd.ExecuteNonQuery().ToString(), "Thông báo");
            }else MessageBox.Show("Thêm khách hàng thành công!" + cmd.ExecuteNonQuery().ToString(), "Thông báo");
            //MessageBox.Show(cmd.ExecuteNonQuery().ToString(),"Thông báo", MessageBoxButtons.OK);   
        }

        public void ThemThe(string maKhachHang
                , string maLoaiThe
                , string maTkKH
                , DateTime ngayMo
                , DateTime ngayHetHan
                , string maTaiSan
                , string maPin
                , int soThanhToan
                ,string maSoThe)
        {
            if (ketNoi.State == ConnectionState.Closed) ketNoi.Open();
            cmd = new SqlCommand("TaoThe", ketNoi);
            cmd.CommandType = CommandType.StoredProcedure;
            var _maKhachHang = new SqlParameter("@maKhachHang", maKhachHang);
            var _maLoaiThe = new SqlParameter("@maLoaiThe", maLoaiThe);
            var _maTkKH = new SqlParameter ("@maTkKH", maTkKH);
            var _ngayMo = new SqlParameter("@ngayMo", ngayMo);
            var _ngayHetHan = new SqlParameter("@ngayHetHan", ngayHetHan);
            var _maTaiSan = new SqlParameter("@maTaiSan", maTaiSan);
            var _maPin = new SqlParameter("@maPin", maPin);
            var _soThanhToan = new SqlParameter("@soThanhToan", soThanhToan);
            var _maSoThe = new SqlParameter("@maSoThe", maSoThe);
            SqlParameter[] vari = { _maKhachHang, _maLoaiThe, _maTkKH, _ngayMo, _ngayHetHan, _maTaiSan, _maPin, _soThanhToan, _maSoThe};
            cmd.Parameters.AddRange(vari);
            cmd.ExecuteNonQuery();
            ketNoi.Close();
        }
        
        public void ThemTaiKhoanKH(string maTk, string maKhachHang, string soDu, DateTime ngayMo, string maDdKD, string matKhau)
        {
            if (ketNoi.State == ConnectionState.Closed) ketNoi.Open();
            cmd = new SqlCommand("TaoTKKH", ketNoi);
            cmd.CommandType = CommandType.StoredProcedure;
            var _maTkKH = new SqlParameter("@maTkKH", maTk);
            var _maKhachHang = new SqlParameter("@maKhachHang", maKhachHang);
            var _soDu = new SqlParameter("@soDu", soDu);
            var _ngayMo = new SqlParameter("@ngayMo", ngayMo);
            var _maDdKD = new SqlParameter("@maDdKD", maDdKD);
            var _matKhau = new SqlParameter("@matKhau", matKhau);
            SqlParameter[] vari = { _maTkKH, _maKhachHang, _soDu, _ngayMo, _maDdKD, _matKhau };
            cmd.Parameters.AddRange(vari);
            cmd.ExecuteNonQuery();
            ketNoi.Close();
        }

        public DataTable LayTKHH()
        {
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.TableMappings.Add("Table", "TaiKhoanKH");
            adap.SelectCommand = new SqlCommand("Select * from tb_TaiKhoanKhachHang", ketNoi);
            DataSet dtSet = new DataSet();
            adap.Fill(dtSet);
            DataTable dt = dtSet.Tables["TaiKhoanKH"];
            return dt;
        }
        #endregion

        

    }
}
