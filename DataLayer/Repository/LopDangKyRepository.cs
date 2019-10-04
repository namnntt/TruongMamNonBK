using DataLayer.InterFace;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.Repository
{
    public class LopDangKyRepository : ILopDangKyRepository
    {


        public List<LopDangKy> LayDanhSachLopDangKy()
        {
            List<LopDangKy> DsLopDK = new List<LopDangKy>();
            using (MamNonBK db = new MamNonBK())
            {
                DsLopDK = (from ds in db.LopDangKies.Include("CLB1").AsNoTracking()
                           select ds).ToList();

                return DsLopDK;
            }
        }
    }
}
