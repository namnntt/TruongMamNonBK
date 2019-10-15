﻿using DataLayer.InterFace;
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
    public static class HocSinhServices
    {
        static IHocSinhRepository HocSinhRepo;
        static ILopDangKyRepository LopDangKyRepo;
        static IDangKyHocRepository DKHocRepo;
        static ICLBRepository CLBRepo;
        static IHoaDonRepository HDRepo;
        static HocSinhServices()
        {
            HocSinhRepo = new HocSinhRepository();
            LopDangKyRepo = new LopDangKyRepository();
            DKHocRepo = new DangKyHocRepository();
            HDRepo = new HoaDonRepository();
            CLBRepo = new CLBRepository();
        }
        public static DataTable LayDanhSachHocSinh()
        {
            var dsHS = from hs in HocSinhRepo.GetAlls()
                       select new
                       {
                           hs.MaHS,
                           hs.TenHS,
                           hs.NgaySinh,
                           hs.LopHanhChinh.TenLopHC,
                           hs.NgayNhapHoc,
                           hs.DiaChi,
                           hs.TenChaMe,
                           hs.SDTChaMe
                       };

            return GenericServices.ToDataTable(dsHS.ToList());

        }
        public static DataTable LayHocSinhDaDangKyTheoMaLopDangKy(string MaLopDangKy)
        {
            List<HoaDon> dsHD = HDRepo.GetAlls();
            List<HocSinh> dsHS = HocSinhRepo.GetAlls();
            List<DangKyHoc> dsDK = DKHocRepo.GetAlls();
            var dsHSDaDK = (from hs in dsHS
                           join hd in dsHD on hs.MaHS equals hd.HocSinh
                           join dk in dsDK on hd.MaHD equals dk.HoaDon
                           where (hd.NgayTao.Value.Month == DateTime.Now.Month && hd.NgayTao.Value.Year == DateTime.Now.Year && MaLopDangKy == dk.LopDangKy)
                           select new
                           {
                               hs.MaHS,
                               hs.TenHS,
                               hs.NgaySinh,
                               hs.LopHanhChinh.TenLopHC,
                               hs.NgayNhapHoc,
                               hs.DiaChi,
                               hs.TenChaMe,
                               hs.SDTChaMe
                           }).Distinct();
            return GenericServices.ToDataTable(dsHSDaDK.ToList());
        }
        public static DataTable LayDanhSachHocSinhDuDKGiaHanDangKyHoc()
        {
            List<HoaDon> dsHD = HDRepo.GetAlls();
            List<HocSinh> dsHS = HocSinhRepo.GetAlls();
            List<DangKyHoc> dsDK = DKHocRepo.GetAlls();
            var dsHSDKThangTruoc = (from hs in dsHS
                             join hd in dsHD on hs.MaHS equals hd.HocSinh
                             join dk in dsDK on hd.MaHD equals dk.HoaDon
                             where(dk.NgayDangKy.Month == (DateTime.Today.AddMonths(-1).Month) && dk.NgayDangKy.Year == (DateTime.Today.AddMonths(-1).Year))
                             select hs).Distinct();
            var dsHSDKThangNay = from hs in dsHS
                                  join hd in dsHD on hs.MaHS equals hd.HocSinh
                                  join dk in dsDK on hd.MaHD equals dk.HoaDon
                                  where (dk.NgayDangKy.Month == DateTime.Now.Month && dk.NgayDangKy.Year == DateTime.Now.Year)
                                  select hs;
            var dsHSDuDkGiaHan = from hs in dsHSDKThangTruoc.ToList()
                                 where !(from hs1 in dsHSDKThangNay.ToList()
                                         select hs1.MaHS).Contains(hs.MaHS)
                                 select new
                                 {
                                     hs.MaHS,
                                     hs.TenHS,
                                     hs.NgaySinh,
                                     hs.LopHanhChinh.TenLopHC,
                                     hs.NgayNhapHoc,
                                     hs.DiaChi,
                                     hs.TenChaMe,
                                     hs.SDTChaMe
                                 };
            return GenericServices.ToDataTable(dsHSDuDkGiaHan.ToList());

        }
        public static List<DangKyHoc> DsLopDangKyCuaHocSinhGiaHan(string MaHS)
        {
            List<HoaDon> dsHD = HDRepo.GetAlls();
            List<DangKyHoc> dsDK = DKHocRepo.GetAlls();
            List<HocSinh> DsHS = HocSinhRepo.GetAlls();
            var dsLopDangKy = from dk in dsDK
                              join hd in dsHD on dk.HoaDon equals hd.MaHD
                              join hs in DsHS on hd.HocSinh equals hs.MaHS
                              where ((dk.NgayDangKy.Month == (DateTime.Today.AddMonths(-1).Month) && dk.NgayDangKy.Year == (DateTime.Today.AddMonths(-1).Year))
                              && hs.MaHS == MaHS)
                              select dk;
            return dsLopDangKy.ToList();
        }
    }
}
