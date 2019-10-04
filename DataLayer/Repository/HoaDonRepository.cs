using DataLayer.InterFace;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class HoaDonRepository : IHoaDonRepository
    {
        public List<HoaDon> GetAlls()
        {
            using (MamNonBK db = new MamNonBK())
            {
                var dsHD = from hd in db.HoaDons.AsNoTracking()
                           select hd;
                return dsHD.ToList();
            }
        }
    }
}
