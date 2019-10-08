using DataLayer.InterFace;
using DataLayer.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public static class HoaDonServices
    {
        static IHoaDonRepository HDrepo;
        static IDangKyHocRepository DkHocRepo;
        static IHocSinhRepository HsRepo;
        static ILopDangKyRepository LDKRepo;
        static HoaDonServices()
        {
            HDrepo = new HoaDonRepository();
            DkHocRepo = new DangKyHocRepository();
            HsRepo = new HocSinhRepository();
            LDKRepo = new LopDangKyRepository();

        }
        public static DataTable LayDanhSachHoaDonTheoNamvaThang(int Nam, int Thang)
        {
            List<DangKyHoc> DsDkHoc = DkHocRepo.GetAlls();
            List<HoaDon> DsHoaDon = HDrepo.GetAlls();
            List<HocSinh> dsHS = HsRepo.GetAlls();
            List<LopDangKy> dsLDK = LDKRepo.LayDanhSachLopDangKy();
            var IdHoaDonvaCount = from hs in dsHS
                                  join hd in DsHoaDon on hs.MaHS equals hd.HocSinh
                                  join dk in DsDkHoc on hd.MaHD equals dk.HoaDon
                                  join ldk in dsLDK on dk.LopDangKy equals ldk.MaLopDangKy
                                  where (dk.NgayDangKy.Month == Thang && dk.NgayDangKy.Year == Nam)
                                  select new
                                  {
                                      hd.MaHD,
                                      hs.MaHS,
                                      hs.TenHS,
                                      hs.LopHanhChinh.TenLopHC,
                                      ldk.HocPhi
                                      
                                  } into x
                                  group x by new { x.MaHD } into g
                                  select new
                                  {
                                      MaHoaDon = g.Key.MaHD,
                                      MaHocSinh = g.First().MaHS,
                                      TenHocSinh = g.First().TenHS,
                                      TenLopHanhChinh = g.First().TenLopHC,
                                      SoluongLopDangKy = g.Count(),
                                      TongHocPhi = g.Sum(m=>m.HocPhi)
                                      
                                  };
            return GenericServices.ToDataTable(IdHoaDonvaCount.ToList());

        }

    }
}
