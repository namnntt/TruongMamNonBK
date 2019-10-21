using DataLayer.InterFace;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public bool CheckuserName(string username)
        {
            using (MamNonBK context = new MamNonBK())
            {
                var TaiKhoan = from tk in context.GiaoVus.AsNoTracking()
                                  where tk.TaiKhoan == username
                                  select tk.TaiKhoan;
                if (!TaiKhoan.ToList().Any())
                    return false;
                else return true;

            }
        }

        public GiaoVu LayThongtinGiaoVu(string TaiKhoan)
        {
            
                using (MamNonBK context = new MamNonBK())
                {
                    var TTGiaoVu = from gv in context.GiaoVus.AsNoTracking()
                                   where TaiKhoan == gv.TaiKhoan
                                   select gv;
                    return TTGiaoVu.ToList().FirstOrDefault();
               
                }
        }
    }
}
