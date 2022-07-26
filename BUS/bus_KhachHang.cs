using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class bus_KhachHang
    {

        private static bus_KhachHang instance;


        public static bus_KhachHang Instance
        {
            get
            {
                if (instance == null)
                    instance = new bus_KhachHang();
                return instance;

            }
        }

        private bus_KhachHang() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = dao_KhachHang.Instance.Xem();
        }

        public bool Sua(DataGridView data)
        {
            DataGridViewRow r = data.SelectedCells[0].OwningRow;


            string maKhachHang = r.Cells["maKhachHang"].Value.ToString();
            string hoTenKhachHang = r.Cells["hoTenKhachHang"].Value.ToString();
          DateTime? ngaySinh = (DateTime?)r.Cells["ngaySinh"].Value;
            string diaChiThuongTru=r.Cells["diaChiThuongTru"].Value.ToString();
            string diaChiLienHe = r.Cells["diaChiLienHe"].Value.ToString();
            string email = r.Cells["email"].Value.ToString();
            string SDT = r.Cells["SDT1"].Value.ToString();
            string sCCCD = r.Cells["SCCCD"].Value.ToString();
            bool? gioiTinh = (bool?)r.Cells["gioiTinh"].Value;
            string hinhCCCDMT = r.Cells["hinhCCCDMT"].Value.ToString();
            string hinhCCCDMS = r.Cells["hinhCCCDMS"].Value.ToString();
            string ngheNghiep = r.Cells["ngheNghiep"].Value.ToString();
            string ghiChu = r.Cells["ghiChu"].Value.ToString();
            string maNhanVien = r.Cells["maNhanVien"].Value.ToString();
            string maLoaiKhachHang=r.Cells["maLoaiKhachHang"].Value.ToString();

            dto_KhachHang KHS = new dto_KhachHang(maKhachHang, hoTenKhachHang, ngaySinh, diaChiThuongTru, diaChiLienHe, email, SDT, sCCCD, gioiTinh, hinhCCCDMT, hinhCCCDMS, ngheNghiep, ghiChu, maNhanVien, maLoaiKhachHang);
            return dao_KhachHang.Instance.Sua(maKhachHang, KHS);


        }
    }
}
