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
    
    public static class LopHCServices
    {
        static ILopHCRepository LopHCRepo;
        static LopHCServices()
        {
            LopHCRepo = new LopHCRepository();
        }
        public static List<LopHanhChinh> LayDanhSachLopHanhChinh()
        {
            return LopHCRepo.GetAlls();
        }
    }
}
