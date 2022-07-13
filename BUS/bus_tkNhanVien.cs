using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class bus_tkNhanVien
    {
        private static bus_tkNhanVien instance;

        public static bus_tkNhanVien Instance
        {
            get
            {
                if (instance == null) instance = new bus_tkNhanVien();
                return instance;
            }
            set => instance = value; }

        public bool KiemTraTaiKkhoan(string email, string pass)
        {
            foreach (dto_TkNhanVien item in dao_tkNhanVien.Instance.layTaiKhoan(email, pass))
            {
                if (dao_tkNhanVien.Instance.layTaiKhoan(email, pass) != null)
                {
                    if (email == item.Email && pass == item.MatKhau)
                    {
                        return true; break;
                    }
                }
                else
                {
                    return false;
                    break;
                }
            }
            return false;
        }

        public bool thu(string email, string pass)
        {
            if (dao_tkNhanVien.Instance.checkTaiKhoan(email, pass).Equals("No"))
            {
                return false;
            }
            else if (dao_tkNhanVien.Instance.checkTaiKhoan(email, pass).Equals("NOE"))
            {
                return false;
            }
            else return true;
        }

        public List<dto_TkNhanVien>BUSLayTk()
        {
            return dao_tkNhanVien.Instance.layUser();
        }

        public string KiemTraChucVu()
        {
            return dao_tkNhanVien.Instance.layUser()[0].Cv;
        }
    }
}
