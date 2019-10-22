using DataLayer.InterFace;
using DataLayer.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public static class AccountServices
    {
        static IAccountRepository AccRepo;
        static AccountServices()
        {
            AccRepo = new AccountRepository();
        }
        public static bool CheckAccountexits(string inputAccount)
        {
            return AccRepo.CheckuserName(inputAccount);
        }
        public static GiaoVu LayThongtinGiaoVu(string inputAccount)
        {
            return AccRepo.LayThongtinGiaoVu(inputAccount);
        }
        public static void DoiMatKhau(string MatKhauMoi, string MaGiaoVu)
        {
            AccRepo.DoiMatKhau(MaGiaoVu, MatKhauMoi);
        }
    }
}
