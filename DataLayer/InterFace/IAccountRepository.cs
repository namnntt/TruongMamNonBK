using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.InterFace
{
    public interface IAccountRepository
    {
        bool CheckuserName(string username);
        GiaoVu LayThongtinGiaoVu(string TaiKhoan);
        
    }
}
