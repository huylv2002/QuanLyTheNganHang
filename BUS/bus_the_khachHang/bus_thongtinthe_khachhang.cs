using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DAO.dao_the_khachang;
using DTO.dto_the_khachhang;
namespace BUS.bus_the_khachHang
{
    public static class bus_thongtinthe_khachhang
    {
        public static void BangDuLieuThe(DataGridView dt)
        {
            dt.DataSource = dao_thongtinthe_khachhang.DuLieuThe();
        }

        public static List<dto_thongtinthe> ThongTinThe()
        {
            return dao_the_mothe.Instance.DanhSachThe();
        }

        public static string KiemTraThongTinThe(string maKhachHang)
        {
            
            var dsKH = dao_the_mothe.Instance.LayDSKH();
            for(int i = 0; i < dsKH.Rows.Count; i++)
            {
                if (maKhachHang.Equals(dsKH.Rows[i]["maKhachHang"].ToString().Trim()))
                {
                    return dsKH.Rows[i]["hoTenKhachHang"].ToString().Trim();
                }
             }
            return "None";
        }

        public static bool timThongTinThe(TextBox maKH, TextBox maSoThe, TextBox maTk, DataGridView dgv)
        {
            string searchValue = "";
            if (maKH.Text != string.Empty)
            {
                searchValue = maKH.Text;
            }else if(maSoThe.Text != string.Empty)
            {
                searchValue = maSoThe.Text;
            }else if(maTk.Text != string.Empty)
            {
                searchValue = maTk.Text;
            }

            int rowIndex = -1;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Trim().Equals(searchValue)||
                            row.Cells[1].Value.ToString().Trim().Equals(searchValue)||
                            row.Cells[2].Value.ToString().Trim().Equals(searchValue))
                        {
                            
                            row.Selected = true;
                            return true;
                            break;
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return false;
        }

        public static void SuaDuLieu(string maKH, DateTimePicker ngayHethan, string maTaiSan, string maPin, int soThanhToan, DataGridView dgv, int index)
        {
            if(ngayHethan.Value == DateTime.Today)
            {
                ngayHethan.Text = "NULL";
            }
            else if(maTaiSan == string.Empty)
            {
                maTaiSan = "NULL";
            }
            else if(maPin == string.Empty)
            {
                maPin = "NULL";
            }else if(soThanhToan == null)
            {
                soThanhToan = 0;
            }


            DataGridViewRow newRow = dgv.Rows[index];
            newRow.Cells[4].Value = ngayHethan.Value;
            newRow.Cells[5].Value = maTaiSan;
            newRow.Cells[6].Value = maPin;
            newRow.Cells[7].Value = soThanhToan;
            //
            
            //dao_thongtinthe_khachhang.SuaDuLieu(maKH, _ngayHetHan, _maTaiSan, _maPin, _soThanhToan); 
        }


    }
}
