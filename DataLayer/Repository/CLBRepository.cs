using DataLayer.InterFace;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class CLBRepository : ICLBRepository
    {
        public List<CLB> GetAlls()
        {
            using (MamNonBK db = new MamNonBK())
            {
                var dsCLB = from clb in db.CLBs
                            select clb;
                return dsCLB.ToList();
            }
        }
    }
}
