using DataLayer.InterFace;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class LopHCRepository : ILopHCRepository
    {
        public List<LopHanhChinh> GetAlls()
        {
            using (MamNonBK db = new MamNonBK())
            {
                var dsLopHC = from lophc in db.LopHanhChinhs
                              select lophc;
                return dsLopHC.ToList();
            }
        }
    }
}
