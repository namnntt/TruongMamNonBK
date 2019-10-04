using DataLayer.InterFace;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class DangKyHocRepository : IDangKyHocRepository
    {
        public List<DangKyHoc> GetAlls()
        {
            using (MamNonBK db = new MamNonBK())
            {
                var dsDK = from dk in db.DangKyHocs.AsNoTracking()
                           select dk;
                return dsDK.ToList();
            }
        }
    }
}
