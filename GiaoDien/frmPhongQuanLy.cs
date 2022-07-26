using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using DTO;
namespace GiaoDien
{
    public partial class frmPhongQL1 : Form
    {
        public frmPhongQL1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        { 
            bus_NhanVien.Instance.Xem(dgvQLNV);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            bus_KhachHang.Instance.Xem(dgvKhachHang);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bus_NhanVien.Instance.Sua(dgvQLNV))
            {
                MessageBox.Show("Sửa Thành Công!");
                btnShow_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        

        private void btnFill_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            if (bus_KhachHang.Instance.Sua(dgvKhachHang))
            {
                MessageBox.Show("Sửa Thành Công!");
                btnShow_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }
    }
}
