using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DAO.NhanVien;
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
            if(dao_Login.Instance.CheckAccount(email, pass))
            {
                return true;
            }
            return false;
        }

        

        public List<dto_TkNhanVien>UserLogin()
        {
            return dao_Login.Instance.DataUserLogin();
        }

        
    }
}
