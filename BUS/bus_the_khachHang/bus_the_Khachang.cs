using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using DTO.dto_the_khachhang;

namespace BUS
{
    public static class bus_the_Khachang
    {
        public static List<dto_thongtinthe> danhSachTheMoi = new List<dto_thongtinthe>();
        //private static bus_the_Khachang instance;
        //public static static bus_the_Khachang Instance
        //{
        //    get
        //    {
        //        if (instance == null) instance = new bus_the_Khachang();
        //        return instance;
        //    }
        //    set => instance = value;
        //}

        public static List<dto_the_KhachHang> layDanhSach()
        {
            return dao_the_mothe.Instance.danhSachKHKhachHang();
        }

        public static void ThemKhachHang(TextBox hoTenKhachHang,
            DateTimePicker ngaySinh,
            TextBox diaChiThuongTru,
            TextBox diaChiLienHe,
            TextBox email,
            TextBox SDT,
            TextBox sCCCD,
            bool gioiTinh,
            byte[] hinhCCCDMT,
            byte[] hinhCCCDMS,
            TextBox ngheNghiep,
            TextBox maNhanVien,
            string maLoaiKhachHang)
        {
            DateTime _ngaySinh = DateTime.Parse(ngaySinh.Value.ToString());
            var so = Int64.Parse(sCCCD.Text);
            string maKH = string.Concat("KH", so % 10000);
            dao_the_mothe.Instance.themKhachHang(maKH, hoTenKhachHang.Text, _ngaySinh, diaChiThuongTru.Text, diaChiLienHe.Text, email.Text, SDT.Text, sCCCD.Text, gioiTinh, hinhCCCDMT, hinhCCCDMS, ngheNghiep.Text, maNhanVien.Text, maLoaiKhachHang);
        }

        public static void kiemTraKH(TextBox hoTenKH, TextBox email, TextBox soCMND,
            TextBox diaChiTT, TextBox diaChiTC, RadioButton gtNam, RadioButton gtNu, DateTimePicker ngaySinh,
             ComboBox loaiKH, TextBox nvPT, byte[] picCMNDMT, byte[] picCMNDMS, PictureBox A, PictureBox B, TextBox ngheNghiep, TextBox SDT)
        {
            var ds = dao_the_mothe.Instance.LayDSKH();
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                if (hoTenKH.Text.Equals(ds.Rows[i]["hoTenKhachHang"]) || soCMND.Text.Equals(ds.Rows[i]["sCCCD"]))
                {
                    if (hoTenKH.Text == string.Empty)
                    {
                        hoTenKH.Text = ds.Rows[i]["hoTenKhachHang"].ToString().Trim();
                    }
                    email.Text = ds.Rows[i]["email"].ToString();
                    if (soCMND.Text == string.Empty)
                    {
                        soCMND.Text = ds.Rows[i]["sCCCD"].ToString().Trim();
                    }
                    diaChiTT.Text = ds.Rows[i]["diaChiThuongTru"].ToString().Trim();
                    diaChiTC.Text = ds.Rows[i]["diaChiLienHe"].ToString().Trim();
                    var gioiTinh = (bool)ds.Rows[i]["gioiTinh"];
                    if (gioiTinh == true)
                    {
                        gtNam.Checked = true;
                        gtNu.Checked = false;
                    }
                    else
                    {
                        gtNam.Checked = false;
                        gtNu.Checked = true;
                    }
                    ngaySinh.Value = DateTime.Parse(ds.Rows[i]["ngaySinh"].ToString());
                    nvPT.Text = ds.Rows[i]["maNhanVien"].ToString();
                    picCMNDMT = !Convert.IsDBNull(ds.Rows[i]["hinhCCCDMT"]) ? (byte[])ds.Rows[i]["hinhCCCDMT"] : null;
                    if (picCMNDMT == null)
                        A.Image = null;
                    else
                    {
                        //ImageByteArray = ImageArray;
                        A.Image = Image.FromStream(new MemoryStream(picCMNDMT));
                    }
                    picCMNDMS = !Convert.IsDBNull(ds.Rows[i]["hinhCCCDMS"]) ? (byte[])ds.Rows[i]["hinhCCCDMS"] : null;
                    if (picCMNDMS == null)
                        B.Image = null;
                    else
                    {
                        //ImageByteArray = ImageArray;
                        B.Image = Image.FromStream(new MemoryStream(picCMNDMS));
                    }
                    foreach (object p in loaiKH.Items)
                    {
                        if (ds.Rows[i]["maLoaiKhachHang"].ToString().Equals(p.ToString()))
                        {
                            loaiKH.SelectedItem = p;
                        }
                    }
                    ngheNghiep.Text = ds.Rows[i]["ngheNghiep"].ToString();
                    SDT.Text = ds.Rows[i]["SDT"].ToString();
                }
            }

        }
        public static bool KiemTraKHTonTai(TextBox hoTen)
        {
            var ds = dao_the_mothe.Instance.LayDSKH();
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                if(hoTen.Text.Equals(ds.Rows[i]["hoTenKhachHang"]))
                {
                    return true;
                }
            }
            return false;
        }

        public static void TaoThe(TextBox hoTenKH
            , ComboBox maLoaiThe
            , ComboBox maTaiSan
            , ComboBox maDD)
        {
            Random random = new Random();
            string _maLoaiThe = maLoaiThe.SelectedItem.ToString();
            string _maTaiSan = maTaiSan.SelectedItem.ToString();
            string maPin = NextString(random, 6);
            int soThanhToan = 5000000;
            string maKhachHang = "";
            DateTime ngayMo = DateTime.Today;
            DateTime ngayHetHan = ngayMo.AddYears(4);
            string maTkKH = "";
            
            if (KiemTraTKKHTonTai(hoTenKH))
            {
                var dsKH = dao_the_mothe.Instance.LayDSKH();
                var dsTk = dao_the_mothe.Instance.LayTKHH();
                for (int i = 0; i < dsKH.Rows.Count; i++)
                {
                    if (hoTenKH.Text.Equals(dsKH.Rows[i]["hoTenKhachHang"]))
                    {
                        maKhachHang = dsKH.Rows[i]["maKhachHang"].ToString().Trim();
                        for(int j = 0; j < dsTk.Rows.Count; j++)
                        {
                            if(maKhachHang.Equals(dsTk.Rows[j]["maKhachHang"].ToString().Trim()))
                            {
                                maTkKH = dsTk.Rows[j]["maTkKH"].ToString().Trim();
                            }
                        }    
                            
                    }
                }
            }
            else
            {
                string maDDKD = maDD.SelectedItem.ToString();
                TaoTKKH(hoTenKH.Text, maDDKD);
                var dsKH = dao_the_mothe.Instance.LayDSKH();
                var dsTk = dao_the_mothe.Instance.LayTKHH();
                for (int i = 0; i < dsKH.Rows.Count; i++)
                {
                    if (hoTenKH.Text.Equals(dsKH.Rows[i]["hoTenKhachHang"]))
                    {
                        maKhachHang = dsKH.Rows[i]["maKhachHang"].ToString().TrimEnd();
                        for(int j = 0; j < dsTk.Rows.Count; j++)
                        {
                            if(maKhachHang.Equals(dsTk.Rows[j]["maTkKH"].ToString().Trim()))
                            {
                                maTkKH = dsTk.Rows[j]["maTkKH"].ToString().Trim();
                            }
                        }
                    }
                }
            }
            int soThe = int.Parse(maTkKH) / 10000;
            string maSoThe = soThe.ToString() + RandomNumber(1000,9999).ToString();
            dao_the_mothe.Instance.ThemThe(maKhachHang
           , _maLoaiThe
           , maTkKH
           , ngayMo
           , ngayHetHan
           , _maTaiSan
           , maPin
           , soThanhToan
           ,maSoThe);         
            }
        

        public static string NextString(this Random random, int length)
        {
            const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public static DataTable DanhSachTaiKhoanKH()
        {
            return dao_the_mothe.Instance.LayTKHH();
        }
        public static bool KiemTraTKKHTonTai(TextBox hoTen)
        {
            string maKH;
            var ds = dao_the_mothe.Instance.LayDSKH();
            var dsTk = dao_the_mothe.Instance.LayTKHH();
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                if (hoTen.Text.Equals(ds.Rows[i]["hoTenKhachHang"].ToString().Trim()))
                {
                    maKH = ds.Rows[i]["maKhachHang"].ToString().Trim();
                    for (int item = 0; item < dsTk.Rows.Count; item++)
                    {
                        if (maKH.Equals(dsTk.Rows[item]["maKhachHang"].ToString().Trim()))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public static void TaoTKKH(string hoTen, string maDdKD)
        {
            string maKhachHang = "";
            var dsKH = dao_the_mothe.Instance.LayDSKH();
            var dsTk = dao_the_mothe.Instance.LayTKHH();
            for (int i = 0; i < dsKH.Rows.Count; i++)
            {
                if (hoTen.Equals(dsKH.Rows[i]["hoTenKhachHang"]))
                {
                    maKhachHang = dsKH.Rows[i]["maKhachHang"].ToString().Trim();
                }
            }
            Random random = new Random();
            string maTkKH = RandomNumber(10000, 999999).ToString();
            string soDu = "0";
            DateTime ngayMo = DateTime.Today;
            string matKhau = NextString(random, 6);
            dao_the_mothe.Instance.ThemTaiKhoanKH(maTkKH, maKhachHang, soDu, ngayMo, maDdKD, matKhau);
        }

       



        //EndClass
    }
}

