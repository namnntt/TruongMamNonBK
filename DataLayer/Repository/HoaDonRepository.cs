﻿using Dapper;
using DataLayer.InterFace;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public void XoaDuLieuHoaDon(string MaHD)
        {
            using (MamNonBK context = new MamNonBK())
            {
                using (IDbConnection db = new SqlConnection(context.Database.Connection.ConnectionString))
                {
                    var p = new DynamicParameters();
                    p.Add("@MaHoaDon", MaHD);
                    db.Execute("XoaDuLieuHoaDOn", p, commandType: CommandType.StoredProcedure);
                }
            }
        }
    }
}
