using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using System.Data;
using DAO;
namespace BUS
{
    public class bus_NhanVien
    {

        private static bus_NhanVien instance;


        public static bus_NhanVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new bus_NhanVien();
                return instance;

            }
        }

        private bus_NhanVien() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = dao_NhanVien.Instance.Xem();
        }

        public bool Sua(DataGridView data)
        {
            DataGridViewRow r = data.SelectedCells[0].OwningRow;


            string maNhanVien = r.Cells["maNhanVien"].Value.ToString();
            string hoTeNhanVien = r.Cells["hoTenNhanVien"].Value.ToString();
            DateTime? ngaySinh = (DateTime?)r.Cells["ngaySinh"].Value; 
            string diaChi = r.Cells["diaChi"].Value.ToString();
            string email = r.Cells["email"].Value.ToString();
            string sCCCD = r.Cells["sCCCD"].Value.ToString();
            string maPB = r.Cells["maPB"].Value.ToString();
            string maCV = r.Cells["maCV"].Value.ToString();
            string maDdKD = r.Cells["maDdKD"].Value.ToString();
            string matkhau = r.Cells["matkhau"].Value.ToString();
            bool? gioiTinh= (bool?)r.Cells["gioiTinh"].Value;
            string SDT1 = r.Cells["SDT1"].Value.ToString();

            dto_NhanVien NVS = new dto_NhanVien(maNhanVien, hoTeNhanVien, ngaySinh, diaChi, email, sCCCD,maPB, maCV,maDdKD,matkhau,gioiTinh,SDT1);
            return dao_NhanVien.Instance.Sua(maNhanVien, NVS);


        }
       
            

    }

}
