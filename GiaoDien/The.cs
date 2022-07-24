using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DTO.dto_the_khachhang;
using BUS;
using BUS.bus_the_khachHang;
using System.IO;

namespace GiaoDien
{
    public partial class frmThe : Form
    {
        #region Avairable
        Byte[] ImageByteArray_Pic1;
        Byte[] ImageByteArray_Pic2;
        string pathPic1 = "";
        string pathPic2 = "";
        int index = 0;
        //adioButton[] gT;

        #endregion
        public frmThe()
        {
            InitializeComponent();
            object[] items_the = { "TTT", "TGN"};
            object[] items_lkh = { "CN", "DN" };
            object[] items_ts = { "TSDD", "TSGTK", "TSN", "TSSD" };
            object[] items_ddkd = { "BC", "DA", "DT", "TA", "TDM", "TU" };
            cbLoaiThe.Items.AddRange(items_the);
            cbTaiSanTC.Items.AddRange(items_ts);
            cbLoaiKhachHang.Items.AddRange(items_lkh);
            cbDiaDiemKinhDoanh.Items.AddRange(items_ddkd);

            picMatTruoc.SizeMode = PictureBoxSizeMode.Zoom;
            picMatSau.SizeMode = PictureBoxSizeMode.Zoom;
            bus_thongtinthe_khachhang.BangDuLieuThe(dgvThongTinThe);
        }
        #region undifinition
        private void frmThe_Load(object sender, EventArgs e)
        {


        }

        private void lblHovaTen_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblGioitinh_Click(object sender, EventArgs e)
        {

        }

        private void lblQuanHuyen_Click(object sender, EventArgs e)
        {

        }

        private void lblDiaChiThuongTru_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapdulieu_Click(object sender, EventArgs e)
        {

        }

        private void lblTinhThanhPho_Click(object sender, EventArgs e)
        {

        }

        private void lblTinhtranghonnhan_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuanHuyen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSonhaDuongpho_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblPhuongXa_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void lblNoicap_Click(object sender, EventArgs e)
        {

        }

        private void v_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSoCMND_Click(object sender, EventArgs e)
        {

        }

        private void txtDCTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhuongXa1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhuongXa1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdoDT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTinhThanhpho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDiaChiThuongTru_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void rdoDKH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoNu_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void lblHovaTen_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNgaycap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTinhThanhPho1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNgaycap_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNoicap_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtQuanHuyen1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHovaten_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuanHuyen_Click_1(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGioitinh_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPhuongXa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTinhThanhPho1_Click(object sender, EventArgs e)
        {

        }

        private void lblQuanHuyen1_Click(object sender, EventArgs e)
        {

        }

        private void txtSonhaDuongpho_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblHovaTen_Click_2(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnThe_Click(object sender, EventArgs e)
        {
            bus_the_Khachang.layDanhSach();
            txtHovaten.Text = bus_the_Khachang.layDanhSach()[0].HoTenKhachHang;
        }

        private void btnAddImageF_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "png",
                Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*", 
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = ofd.FileName;
                picMatTruoc.Image = Image.FromFile(ofd.FileName);
                picMatTruoc.SizeMode = PictureBoxSizeMode.Zoom;
                pathPic1 = ofd.FileName;
            }
            //var path = Path.GetFileName(ofd.FileName);
            
            if (pathPic1.Trim() != "")
            {

                if (pathPic1 == "")
                {
                    if (ImageByteArray_Pic1.Length != 0)
                        ImageByteArray_Pic1 = new byte[] { };
                }
                else
                {
                    Image temp = new Bitmap(pathPic1);
                    MemoryStream strm = new MemoryStream();
                    temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                    ImageByteArray_Pic1 = strm.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Please enter image title");
            }
        }

        private void btnAddImageB_Click(object sender, EventArgs e)
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    InitialDirectory = @"D:\",
                    Title = "Browse Text Files",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "png",
                    Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //textBox1.Text = ofd.FileName;
                    picMatSau.Image = Image.FromFile(ofd.FileName);
                    picMatSau.SizeMode = PictureBoxSizeMode.Zoom;
                    pathPic2 = ofd.FileName; 
                }
                //var path = Path.GetFileName(ofd.FileName);

                if (pathPic2.Trim() != "")
                {

                    if (pathPic2 == "")
                    {
                        if (ImageByteArray_Pic2.Length != 0)
                        ImageByteArray_Pic2 = new byte[] { };
                    }
                    else
                    {
                    Image temp = new Bitmap(pathPic2) ;
                        MemoryStream strm = new MemoryStream();
                        temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                        ImageByteArray_Pic2 = strm.ToArray();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter image title");
                }
            }

        public bool KiemTraGioiTinh(RadioButton nam, RadioButton nu)
        {
            int _gt = 0;
            bool gTThem = false;
            if (nam.Checked == true)
            {
                _gt = 1;
            }
            else if (nu.Checked == true)
            {
                _gt = 0;
            }
            else _gt = 3;

            if (_gt == 1)
            {
                gTThem = true;
            }
            else if (_gt == 0)
            {
                gTThem = false;
            }
            return gTThem;
        }
        private void btnMoThe_Click(object sender, EventArgs e)
        {
            var _gt = KiemTraGioiTinh(rdoNam, rdoNu);
            if(bus_the_Khachang.KiemTraKHTonTai(txtHovaten) == false)
                bus_the_Khachang.ThemKhachHang(txtHovaten, dtNgaySinh, txtDiaChi_thuongTru, txt_DiaChi_LienHe, txtEmail, txtSDT, txtSoCMND, _gt, ImageByteArray_Pic1, ImageByteArray_Pic2, txtNgheNghiep, txtNhanVienPT, cbLoaiKhachHang.SelectedItem.ToString());
            if(bus_the_Khachang.KiemTraTKKHTonTai(txtHovaten) == false)
            {
                bus_the_Khachang.TaoTKKH(txtHovaten.Text, cbDiaDiemKinhDoanh.SelectedItem.ToString());
            }
            bus_the_Khachang.TaoThe(txtHovaten,cbLoaiThe,cbTaiSanTC,cbDiaDiemKinhDoanh);
            btnLamMoi_Click(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHovaten.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtSoCMND.Text = "";
            txtNgaycap.Text = "";
            txtNoicap.Text = "";
            txtNgheNghiep.Text = "";
            txtDiaChi_thuongTru.Text = "";
            txt_DiaChi_LienHe.Text = "";
            txtNhanVienPT.Text = "";
            if (rdoNam.Checked == true)
            {
                rdoNam.Checked = false;
            }
            else if (rdoNu.Checked == true)
            {
                rdoNu.Checked = false;
            }
            dtNgaySinh.Value = DateTime.Today;
            cbLoaiThe.SelectedItem = null;
            cbTaiSanTC.SelectedItem = null;
            cbLoaiKhachHang.SelectedItem = null;
            picMatTruoc.Image = null;
            picMatSau.Image = null;
            cbDiaDiemKinhDoanh.SelectedItem = null;
        }

        private void txtHovaten_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bus_the_Khachang.kiemTraKH(txtHovaten,txtEmail,txtSoCMND, 
                    txtDiaChi_thuongTru,txt_DiaChi_LienHe, rdoNam, rdoNu, dtNgaySinh, cbLoaiKhachHang, 
                    txtNhanVienPT, ImageByteArray_Pic1, ImageByteArray_Pic2, picMatTruoc, picMatSau, txtNgheNghiep, txtSDT);
                //bus_the_Khachang.Instance.TaoThe(txtHovaten.Text, );
            }
        }

        private void txtSoCMND_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bus_the_Khachang.kiemTraKH(txtHovaten, txtEmail, txtSoCMND,
                    txtDiaChi_thuongTru, txt_DiaChi_LienHe, rdoNam, rdoNu, dtNgaySinh, cbLoaiKhachHang,
                    txtNhanVienPT, ImageByteArray_Pic1, ImageByteArray_Pic2, picMatTruoc, picMatSau, txtNgheNghiep, txtSDT);
                //bus_the_Khachang.Instance.TaoThe(txtHovaten.Text, );
            }
        }

        private void dgvThongTinThe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                if (index < 0) return;
                DataGridViewRow row = dgvThongTinThe.Rows[index];
                theTxtMaKH.Text = row.Cells[0].Value.ToString();
                theTxtMaLoaiThe.Text = row.Cells[1].Value.ToString();
                theTxtMaTK.Text = row.Cells[2].Value.ToString();
                pNgayMo.Text = row.Cells[3].Value.ToString();
                pngayHetHan.Text = row.Cells[4].Value.ToString();
                theTxtMTS.Text = row.Cells[5].Value.ToString();
                theTxtMaPin.Text = row.Cells[6].Value.ToString();
                theTxtSoThanhToan.Text = row.Cells[7].Value.ToString();
                theTxtMaSoThe.Text = row.Cells[8].Value.ToString();
                lblHoTenKH.Text = bus_thongtinthe_khachhang.KiemTraThongTinThe(theTxtMaKH.Text.Trim());
                lblNgayHetHang.Text = pngayHetHan.Text;
                lblmaSoThe.Text = theTxtMaSoThe.Text;      
            }
            catch(Exception ex)
            {
                MessageBox.Show("There is an error to occured: " + ex.ToString());
            }
        }

        private void btnLamMoiDS_Click(object sender, EventArgs e)
        {
            bus_thongtinthe_khachhang.BangDuLieuThe(dgvThongTinThe);
            theTxtMaKH.Text = "";
            theTxtMaTK.Text = "";
            pNgayMo.Value = DateTime.Today;
            pngayHetHan.Value = DateTime.Today;
            theTxtMTS.Text = "";
            theTxtMaPin.Text = "";
            theTxtSoThanhToan.Text = "";
            theTxtMaSoThe.Text = "";
            theTxtMaLoaiThe.Text = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            bus_thongtinthe_khachhang.timThongTinThe(theTxtMaKH, theTxtMaSoThe, theTxtMaTK, dgvThongTinThe);
        }

        private void btnEditTT_Click(object sender, EventArgs e)
        {
            int _soTHanhToan = Convert.ToInt32(theTxtSoThanhToan.ToString().Trim());
            bus_thongtinthe_khachhang.SuaDuLieu(theTxtMaKH.Text.Trim(), pngayHetHan, 
                theTxtMTS.Text.Trim(), theTxtMaPin.Text.Trim(), _soTHanhToan, dgvThongTinThe, index);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }
    }
}
