using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;
using Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;

namespace QLTHE
{
    public partial class frmLayThongTin : Form
    {
        public frmLayThongTin()
        {
            InitializeComponent();
        }

        private void btnLapHoSo_Click(object sender, EventArgs e)
        {
            txtKHACHHANG.Text = txtKHACHHANG.Text.Trim(); // Xóa đầu cuối
            Regex trimmer = new Regex(@"\s\s+"); // Xóa khoảng trắng thừa trong chuỗi
            
            foreach (var item in cboLayThongTinSPV.Items)
            {
                if (cboLayThongTinSPV.SelectedIndex == 0)
                {
                    CreateWordDocument(@"D:\Working\QuanLyNganHang\Datasave\example.docx", @"D:\Working\QuanLyNganHang\Datasave\Hoso\"+"hosovay"+ trimmer.Replace(txtKHACHHANG.Text, " ") + ".docx");
                    Word.Application ap = new Word.Application();
                    if (System.IO.File.Exists(@"D:\Working\QuanLyNganHang\Datasave\Hoso\" + "hosovay_" + trimmer.Replace(txtKHACHHANG.Text, " ") + ".docx"))
                    {
                        Document document = ap.Documents.Open(@"D:\Working\QuanLyNganHang\Datasave\Hoso\" + "hosovay" + trimmer.Replace(txtKHACHHANG.Text, " ") + ".docx");
                        //openWord.Text = document.Content.F;
                        document.ActiveWindow.Selection.WholeStory();
                        document.ActiveWindow.Selection.Copy();
                        IDataObject dataObject = Clipboard.GetDataObject();
                        openWord.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                    }         
                    break;
                }    
                    // Thực thi phần in hóa đơn của từng khách hàn
            }     
            
        }

        private void FindAndReplace(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        //Creeate the Doc Method
        private void CreateWordDocument(object filename, object SaveAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document myWordDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                myWordDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                myWordDoc.Activate();
                string gt = "";
                if (checkBox_GTNAM.Checked == true && checkBox_GTNU.Checked == false)
                {
                    gt = "Nam";
                }
                else gt = "Nữ";
                //find and replace
                this.FindAndReplace(wordApp, "<hoTen>", txtKHACHHANG.Text);
                this.FindAndReplace(wordApp, "<ngaySinh>", DateTime.Today.ToString());
                this.FindAndReplace(wordApp, "<gioiTinh>", gt);
                this.FindAndReplace(wordApp, "<cmnd>", txtCCCD.Text);
                this.FindAndReplace(wordApp, "<diaChi>", txtDiaChi.Text);
                this.FindAndReplace(wordApp, "<sdt>", txtSODT.Text);
                this.FindAndReplace(wordApp, "<ngheNghiep>", txtNgheNghiep.Text);
                this.FindAndReplace(wordApp, "<luongTB>", txtLayThongTinTNBQ.Text);
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            myWordDoc.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            myWordDoc.Close();
            wordApp.Quit();
            MessageBox.Show("File Created!");
        }

        private void btnOpenHoSo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                ValidateNames = true,
                Multiselect = false,
                Filter = "Word 97-2003|*.doc|Word Document|*.docx"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    object readOnly = false;
                    object visible = true;
                    object save = false;
                    object fileName = ofd.FileName;
                    object newTemplate = false;
                    object docType = 0;
                    object missing = Type.Missing;
                    Document document;
                    Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application()
                    {
                        Visible = false
                    };
                    document = application.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
                    document.ActiveWindow.Selection.WholeStory();
                    document.ActiveWindow.Selection.Copy();
                    IDataObject dataObject = Clipboard.GetDataObject();
                    openWord.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                    application.Quit(ref missing, ref missing, ref missing);
                }

            }
        }
    }
}
