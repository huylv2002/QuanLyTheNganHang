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
using BUS.bus_the_khachHang;
using DTO;
using QLTHE;

namespace GiaoDien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            lblUser.Text = "User";
            lblUser.Text = bus_tkNhanVien.Instance.UserLogin()[0].HoTenNhanVien;
            if (bus_tkNhanVien.Instance.UserLogin()[0].MaCV.Equals("TP"))
            {
                if(bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PGD"))
                {
                    ToolStripMenuItem_quanLyThe.Visible = false;
                    ToolStripMenuItem_lapHoSo.Visible = false;
                    ToolStripMenuItem_giaoDich.Visible = true;
                    ToolStripMenuItem_QLTT.Visible = true;
                    ToolStripMenuItem_giaiNgan.Visible = true;
                    ToolStripMenuItem_quanLyHoSo.Visible = false;
                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PKD"))
                {
                    ToolStripMenuItem_quanLyThe.Visible = true;
                    ToolStripMenuItem_lapHoSo.Visible = true;
                    ToolStripMenuItem_giaoDich.Visible = false;
                    ToolStripMenuItem_QLTT.Visible = true;
                    ToolStripMenuItem_giaiNgan.Visible = false;
                    ToolStripMenuItem_quanLyHoSo.Visible = false;
                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PPL"))
                {
                    ToolStripMenuItem_quanLyThe.Visible = false;
                    ToolStripMenuItem_lapHoSo.Visible = false;
                    ToolStripMenuItem_giaoDich.Visible = false;
                    ToolStripMenuItem_QLTT.Visible = true;
                    ToolStripMenuItem_giaiNgan.Visible = false;
                    ToolStripMenuItem_quanLyHoSo.Visible = true;
                }
            }
            else if(bus_tkNhanVien.Instance.UserLogin()[0].MaCV.Equals("NV"))
            {
                if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PGD"))
                {
                    ToolStripMenuItem_quanLyThe.Visible = false;
                    ToolStripMenuItem_lapHoSo.Visible = false;
                    ToolStripMenuItem_giaoDich.Visible = true;
                    ToolStripMenuItem_QLTT.Visible = false;
                    ToolStripMenuItem_giaiNgan.Visible = true;
                    ToolStripMenuItem_quanLyHoSo.Visible = false;
                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PKD"))
                {
                    ToolStripMenuItem_quanLyThe.Visible = true;
                    ToolStripMenuItem_lapHoSo.Visible = true;
                    ToolStripMenuItem_giaoDich.Visible = false;
                    ToolStripMenuItem_QLTT.Visible = false;
                    ToolStripMenuItem_giaiNgan.Visible = false;
                    ToolStripMenuItem_quanLyHoSo.Visible = false;
                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PPL"))
                {
                    ToolStripMenuItem_quanLyThe.Visible = false;
                    ToolStripMenuItem_lapHoSo.Visible = false;
                    ToolStripMenuItem_giaoDich.Visible = false;
                    ToolStripMenuItem_QLTT.Visible = true;
                    ToolStripMenuItem_giaiNgan.Visible = true;
                    ToolStripMenuItem_quanLyHoSo.Visible = true;
                }
            }
            else if(bus_tkNhanVien.Instance.UserLogin()[0].MaCV.Equals("GD"))
            {
                if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PGD"))
                {

                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PKD"))
                {

                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PPL"))
                {

                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTinTK_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan myForm = new frmThongTinTaiKhoan();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panelWC.Controls.Add(myForm);
            myForm.Show();
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            //panelWC.BackgroundImage = Image.FromFile(Application.StartupPath +());
        }

        private void tabMenu_DangXuat_Click(object sender, EventArgs e)
        {
            bus_tkNhanVien.Instance.UserLogin().RemoveAt(0);
            this.Close();
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void tabMenu_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem_quanLyThe_Click(object sender, EventArgs e)
        {
            frmThe the = new frmThe();
            the.TopLevel = false;
            the.AutoScroll = true;
            this.panelWC.Controls.Add(the);
            the.Show();
        }

        private void ToolStripMenuItem_lapHoSo_Click(object sender, EventArgs e)
        {
            frmQuanLyHS myForm = new frmQuanLyHS();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panelWC.Controls.Add(myForm);
            myForm.Show();
        }

        private void ToolStripMenuItem_giaiNgan_Click(object sender, EventArgs e)
        {
            frmGiaiNgan myForm = new frmGiaiNgan();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panelWC.Controls.Add(myForm);
            myForm.Show();
        }

        private void ToolStripMenuItem_giaoDich_Click(object sender, EventArgs e)
        {
            frmGiaoDich myForm = new frmGiaoDich();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panelWC.Controls.Add(myForm);
            myForm.Show();
        }

        private void ToolStripMenuItem_quanLyHoSo_Click(object sender, EventArgs e)
        {
            frmQuanLyHS myForm = new frmQuanLyHS();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panelWC.Controls.Add(myForm);
            myForm.Show();
        }

        private void ToolStripMenuItem_TTKH_Click(object sender, EventArgs e)
        {
            frmPhongQL myForm = new frmPhongQL();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panelWC.Controls.Add(myForm);
            myForm.Show();
        }

        private void ToolStripMenuItem_TTNV_Click(object sender, EventArgs e)
        {
            frmPhongQL myForm = new frmPhongQL();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            this.panelWC.Controls.Add(myForm);
            myForm.Show();
        }
    }
}
