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
    public partial class frmPhongQL : Form
    {
        public frmPhongQL()
        {
            InitializeComponent();
        }

        private void frmPhongQL_Load(object sender, EventArgs e)
        {
            if (bus_tkNhanVien.Instance.UserLogin()[0].MaCV.Equals("TP"))
            {
                if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PGD"))
                {
                    tabControlQL.TabPages[1].Visible = true;
                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PKD"))
                {
                    tabControlQL.TabPages[1].Visible = true;
                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PPL"))
                {
                    tabControlQL.TabPages[1].Visible = true;
                }
            }
            else if (bus_tkNhanVien.Instance.UserLogin()[0].MaCV.Equals("NV"))
            {
                if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PGD"))
                {
                    tabControlQL.Visible = false;
                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PKD"))
                {
                    tabControlQL.Visible = false;
                }
                else if (bus_tkNhanVien.Instance.UserLogin()[0].MaPB.Equals("PPL"))
                {
                    //tabControlQL.TabPages[].Visible = false;
                }
            }
        }
    }
}
