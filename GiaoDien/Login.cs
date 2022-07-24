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
using GiaoDien;
namespace GiaoDien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
                      
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }



        private void login_Click(object sender, EventArgs e)
        {
            //if(txtUser.Text.)
            if (bus_tkNhanVien.Instance.KiemTraTaiKkhoan(txtUser.Text.Trim(), txtPass.Text.Trim()))
            {
                   if(MessageBox.Show("Đăng nhập thành công: " + bus_tkNhanVien.Instance.UserLogin()[0].HoTenNhanVien,"Thông báo",MessageBoxButtons.OK) == DialogResult.OK)
                    {   
                        frmMain mainPro = new frmMain();
                        mainPro.Show();
                        this.Hide();
                    }
               
            }
            else
            {
                if(MessageBox.Show("Đăng nhập thất bại! Vui lòng kiểm tra lại tài khoản!", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    txtUser.Focus();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đang muốn thoát chương trình!", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else return;
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtPass.Text == string.Empty)
                {
                    txtPass.Focus();
                }
                else
                {
                    login_Click(sender, e);
                }
            }         
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUser.Text == string.Empty)
                {
                    txtUser.Focus();
                }
                else
                {
                    login_Click(sender, e);
                }
            }
        }
    }
}
