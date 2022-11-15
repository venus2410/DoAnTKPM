using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TKPM_21880020.DAO;
using TKPM_21880020.DTO;

namespace TKPM_21880020.BUS
{
    public class PhieuMuonBUS
    {
        PhieuMuonDAO pmDAO = new PhieuMuonDAO();
        public int ThemPhieuMuon(PhieuMuonDTO pm)
        {
            if (!QuyDinhBUS.isTheConHan(pm.DocGia))
                return -1;
            if (QuyDinhBUS.isDatSoLuotMuonToiDa(pm.DocGia, pm.dsSach.Count))
                return -2;
            if (pm.dsSach.Count <= 0)
                return -3;
            return pmDAO.ThemPhieuMuon(pm);
        }
        /*public DataTable LayMaTiepTheo()
        {
            return pmDAO.LayMaTiepTheo();
        }*/
        public DataTable LayPhieuMuon()
        {
            return pmDAO.LayPhieuMuon();
        }
        public DataTable LayDSSachTuMaPhieu(int maPhieu)
        {
            return pmDAO.LayDSSachTuMaPhieu(maPhieu);
        }
        public int XoaPhieu(PhieuMuonDTO phieuMuon)
        {
            return pmDAO.XoaPhieu(phieuMuon);
        }
        public int CapNhatPhieu(PhieuMuonDTO phieuMuon)
        {
            if (!QuyDinhBUS.isTheConHan(phieuMuon.DocGia))
                return -1;
            return pmDAO.CapNhatPhieu(phieuMuon);
        }
        public int TraSach(SachDTO sach)
        {
            return pmDAO.CapNhatTraSach(sach);
        }
    }
}
