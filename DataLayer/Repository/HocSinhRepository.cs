using DataLayer.InterFace;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class HocSinhRepository : IHocSinhRepository
    {
        public List<HocSinh> GetAlls()
        {
            using (MamNonBK db = new MamNonBK())
            {
                var dsHS = from hs in db.HocSinhs.Include("LopHanhChinh").AsNoTracking()
                           select hs;
                return dsHS.ToList();
            }
        }
    }
}
