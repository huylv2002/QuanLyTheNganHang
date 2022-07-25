using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.bus_the_khachHang;
using BUS;
namespace GiaoDien
{
    public partial class frmThongTinTaiKhoan : Form
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
            ShowLen();
        }
        public void ShowLen()
        {
            txtHoTen.Text = bus_tkNhanVien.Instance.UserLogin()[0].HoTenNhanVien;
            txtMaTK.Text = bus_tkNhanVien.Instance.UserLogin()[0].Email;
            txtChucVu.Text = bus_tkNhanVien.Instance.UserLogin()[0].MaCV;
            txtPhongBan.Text = bus_tkNhanVien.Instance.UserLogin()[0].MaPB;
            txtDDKD.Text = bus_tkNhanVien.Instance.UserLogin()[0].MaDdKD;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
