using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlDataAdapter sql = new SqlDataAdapter();
        public frmMain()
        {
            InitializeComponent();
            lblUser.Text = "User";
            lblUser.Text = bus_tkNhanVien.Instance.UserLogin()[0].HoTenNhanVien + " " + bus_tkNhanVien.Instance.UserLogin()[0].MaPB;
            if (bus_tkNhanVien.Instance.UserLogin()[0].MaCV.Equals("TP"))
            {
                if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PGD"))
                {
                    ToolStripMenuItem_quanLyThe.Visible = false;
                    ToolStripMenuItem_lapHoSo.Visible = false;
                    ToolStripMenuItem_giaoDich.Visible = true;
                    ToolStripMenuItem_QLTT.Visible = true;
                    ToolStripMenuItem_giaiNgan.Visible = true;
                    ToolStripMenuItem_quanLyHoSo.Visible = false;
                    btnBoPhan.Visible = true;
                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PKD"))
                {
                    ToolStripMenuItem_quanLyThe.Visible = true;
                    ToolStripMenuItem_lapHoSo.Visible = true;
                    ToolStripMenuItem_giaoDich.Visible = false;
                    ToolStripMenuItem_QLTT.Visible = true;
                    ToolStripMenuItem_giaiNgan.Visible = false;
                    ToolStripMenuItem_quanLyHoSo.Visible = false;
                    btnBoPhan.Visible = true;
                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PPL"))
                {
                    ToolStripMenuItem_quanLyThe.Visible = false;
                    ToolStripMenuItem_lapHoSo.Visible = false;
                    ToolStripMenuItem_giaoDich.Visible = false;
                    ToolStripMenuItem_QLTT.Visible = true;
                    ToolStripMenuItem_giaiNgan.Visible = false;
                    ToolStripMenuItem_quanLyHoSo.Visible = true;
                    btnBoPhan.Visible = true;
                }
            }
            else if (bus_tkNhanVien.Instance.UserLogin()[0].MaCV.Equals("NV"))
            {
                if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PGD"))
                {
                    ToolStripMenuItem_quanLyThe.Visible = false;
                    ToolStripMenuItem_lapHoSo.Visible = false;
                    ToolStripMenuItem_giaoDich.Visible = true;
                    ToolStripMenuItem_QLTT.Visible = false;
                    ToolStripMenuItem_giaiNgan.Visible = true;
                    ToolStripMenuItem_quanLyHoSo.Visible = false;
                    btnBoPhan.Visible = false;
                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PKD"))
                {
                    ToolStripMenuItem_quanLyThe.Visible = true;
                    ToolStripMenuItem_lapHoSo.Visible = true;
                    ToolStripMenuItem_giaoDich.Visible = false;
                    ToolStripMenuItem_QLTT.Visible = false;
                    ToolStripMenuItem_giaiNgan.Visible = false;
                    ToolStripMenuItem_quanLyHoSo.Visible = false;
                    btnBoPhan.Visible = false;
                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PPL"))
                {
                    ToolStripMenuItem_quanLyThe.Visible = false;
                    ToolStripMenuItem_lapHoSo.Visible = false;
                    ToolStripMenuItem_giaoDich.Visible = false;
                    ToolStripMenuItem_QLTT.Visible = true;
                    ToolStripMenuItem_giaiNgan.Visible = true;
                    ToolStripMenuItem_quanLyHoSo.Visible = true;
                    btnBoPhan.Visible = false;
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
                this.panelWC.Controls.Clear();
            frmThongTinTaiKhoan myForm = new frmThongTinTaiKhoan();
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                panelWC.Controls.Add(myForm);
                myForm.Show();
            }

            private void btnTongQuan_Click(object sender, EventArgs e)
            {
                this.panelWC.Controls.Clear();
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
            this.panelWC.Controls.Clear();
            this.panelWC.Controls.Add(the);
                the.Show();
            }

            private void ToolStripMenuItem_lapHoSo_Click(object sender, EventArgs e)
            {
                frmLayThongTin myForm = new frmLayThongTin();
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
            this.panelWC.Controls.Clear();
            this.panelWC.Controls.Add(myForm);
                myForm.Show();
            }

            private void ToolStripMenuItem_giaiNgan_Click(object sender, EventArgs e)
            {
                frmGiaiNgan myForm = new frmGiaiNgan();
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
                this.panelWC.Controls.Clear();
                this.panelWC.Controls.Add(myForm);
                myForm.Show();
            }

            private void ToolStripMenuItem_giaoDich_Click(object sender, EventArgs e)
            {
                frmGiaoDich myForm = new frmGiaoDich();
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
            this.panelWC.Controls.Clear();  
            this.panelWC.Controls.Add(myForm);
                myForm.Show();
            }

            private void ToolStripMenuItem_quanLyHoSo_Click(object sender, EventArgs e)
            {
                frmQuanLyHS myForm = new frmQuanLyHS();
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
            this.panelWC.Controls.Clear();
            this.panelWC.Controls.Add(myForm);
                myForm.Show();
            }

            private void ToolStripMenuItem_TTKH_Click(object sender, EventArgs e)
            {
                frmPhongQL1 myForm = new frmPhongQL1();
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
            this.panelWC.Controls.Clear();
            this.panelWC.Controls.Add(myForm);
                myForm.Show();
            }
            public void Showcheckbox(Panel pn)
            {
                
            }
            private void ToolStripMenuItem_TTNV_Click(object sender, EventArgs e)
            {
                frmPhongQL1 myForm = new frmPhongQL1();
                myForm.TopLevel = false;
                myForm.AutoScroll = true;
            this.panelWC.Controls.Clear();
            this.panelWC.Controls.Add(myForm);
                myForm.Show();
            }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            this.panelWC.Controls.Clear();
            DataTable newDT = new DataTable();
            DataColumn col = new DataColumn();
            col.ColumnName = "MaNV";
            col.DataType = System.Type.GetType("System.String");
            newDT.Columns.Add(col);
            DataColumn col1 = new DataColumn();
            col1.ColumnName = "hoTenNhanVien";
            col1.DataType = System.Type.GetType("System.String");
            newDT.Columns.Add(col1);
            DataColumn col2 = new DataColumn();
            col2.ColumnName = "ngaySinh";
            col2.DataType = System.Type.GetType("System.DateTime");
            newDT.Columns.Add(col2);
            DataColumn col3 = new DataColumn();
            col3.ColumnName = "diaChi";
            col3.DataType = System.Type.GetType("System.String");
            newDT.Columns.Add(col3);
            DataColumn col4 = new DataColumn();
            col4.ColumnName = "email";
            col4.DataType = System.Type.GetType("System.String");
            newDT.Columns.Add(col4);
            DataColumn col5 = new DataColumn();
            col5.ColumnName = "CMND";
            col5.DataType = System.Type.GetType("System.String");
            newDT.Columns.Add(col5);
            DataColumn col6 = new DataColumn();
            col6.ColumnName = "maPB";
            col6.DataType = System.Type.GetType("System.String");
            newDT.Columns.Add(col6);
            DataColumn col7 = new DataColumn();
            col7.ColumnName = "maCV";
            col7.DataType = System.Type.GetType("System.String");
            newDT.Columns.Add(col7);
            DataColumn col8 = new DataColumn();
            col8.ColumnName = "Chi Nhanh";
            col8.DataType = System.Type.GetType("System.String");
            newDT.Columns.Add(col8);
            DataColumn col9 = new DataColumn();
            col9.ColumnName = "matKhau";
            col9.DataType = System.Type.GetType("System.String");
            newDT.Columns.Add(col9);
            DataColumn col10 = new DataColumn();
            col10.ColumnName = "GioiTinh";
            col10.DataType = System.Type.GetType("System.String");
            newDT.Columns.Add(col10);
            DataColumn col11 = new DataColumn();
            col11.ColumnName = "SDT";
            col11.DataType = System.Type.GetType("System.String");
            newDT.Columns.Add(col11);
            DataRow row;
            newDT.Rows.Clear();
            if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PKD"))
            {
                var ds = bus_tkNhanVien.Instance.dsNV();
                for (int i = 0; i < ds.Rows.Count; i++)
                {
                    
                    if (ds.Rows[i]["maPB"].ToString().Trim().Equals("PKD"))
                    {
                        newDT.Rows.Add(ds.Rows[i]["maNhanVien"].ToString(),
                            ds.Rows[i]["hoTenNhanVien"].ToString(),
                            ds.Rows[i]["ngaySinh"].ToString(),
                            ds.Rows[i]["diaChi"].ToString(),
                            ds.Rows[i]["email"].ToString(),
                            ds.Rows[i]["sCCCD"].ToString(),
                            ds.Rows[i]["maPB"].ToString(),
                            ds.Rows[i]["maCV"].ToString(),
                            ds.Rows[i]["maDdKD"].ToString(),
                            ds.Rows[i]["matkhau"].ToString(),
                            ds.Rows[i]["gioiTinh"].ToString(),
                            ds.Rows[i]["SDT"]
                            );
                        //row = ds.Rows[i];
                        
                    }
                }
            }
            else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PGD"))
            {
                var ds = bus_tkNhanVien.Instance.dsNV();
                for (int i = 0; i < ds.Rows.Count; i++)
                {
                    if (ds.Rows[i]["maPB"].ToString().Trim().Equals("PGD"))
                    {
                        newDT.Rows.Add(ds.Rows[i]["maNhanVien"].ToString(),
                            ds.Rows[i]["hoTenNhanVien"].ToString(),
                            ds.Rows[i]["ngaySinh"].ToString(),
                            ds.Rows[i]["diaChi"].ToString(),
                            ds.Rows[i]["email"].ToString(),
                            ds.Rows[i]["sCCCD"].ToString(),
                            ds.Rows[i]["maPB"].ToString(),
                            ds.Rows[i]["maCV"].ToString(),
                            ds.Rows[i]["maDdKD"].ToString(),
                            ds.Rows[i]["matkhau"].ToString(),
                            ds.Rows[i]["gioiTinh"].ToString(),
                            ds.Rows[i]["SDT"]
                            );
                    }
                }
            }else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PPL"))
            {
                var ds = bus_tkNhanVien.Instance.dsNV();
                for (int i = 0; i < ds.Rows.Count; i++)
                {
                    if (ds.Rows[i]["maPB"].ToString().Trim().Equals("PPL"))
                    {
                        newDT.Rows.Add(ds.Rows[i]["maNhanVien"].ToString(),
                            ds.Rows[i]["hoTenNhanVien"].ToString(),
                            ds.Rows[i]["ngaySinh"].ToString(),
                            ds.Rows[i]["diaChi"].ToString(),
                            ds.Rows[i]["email"].ToString(),
                            ds.Rows[i]["sCCCD"].ToString(),
                            ds.Rows[i]["maPB"].ToString(),
                            ds.Rows[i]["maCV"].ToString(),
                            ds.Rows[i]["maDdKD"].ToString(),
                            ds.Rows[i]["matkhau"].ToString(),
                            ds.Rows[i]["gioiTinh"].ToString(),
                            ds.Rows[i]["SDT"]
                            );
                    }
                }
            }
            DataGridView dgvt = new DataGridView();
            dgvt.DataSource = newDT;
            dgvt.Dock = DockStyle.Fill;
            dgvt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            panelWC.Controls.Add(dgvt);
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            this.panelWC.Controls.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.panelWC.Controls.Clear();
        }
    }
    }


