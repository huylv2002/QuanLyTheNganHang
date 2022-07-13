using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            lblUser.Text = "User";
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
    }
}
