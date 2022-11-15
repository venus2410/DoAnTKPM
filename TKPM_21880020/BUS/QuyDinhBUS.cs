using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TKPM_21880020.DAO;
using TKPM_21880020.DTO;

namespace TKPM_21880020.BUS
{
    class QuyDinhBUS
    {
        QuyDinhDAO qdDAO = new QuyDinhDAO();
        
        public static bool isTuoiHopLe(int namSinh)
        {
            if (DateTime.Now.Year - namSinh < QuyDinhDTO.TuoiNhoNhat || DateTime.Now.Year - namSinh > QuyDinhDTO.TuoiLonNhat)
                return false;
            return true;
        }
        public static bool isThoiHanSachHopLe(int namXuatBan)
        {
            return DateTime.Now.Year - namXuatBan < QuyDinhDTO.ThoiHanSach;
        }
        public static bool isTheConHan(DocGiaDTO dg)
        {
            QuyDinhDAO qdDao = new QuyDinhDAO();
            DataTable dt = qdDao.LayDocGiaTheoMa(dg);
            DataRow row = dt.Rows[0];
            DateTime d = (DateTime)row["NgayLapThe"];
            return DateTime.Now <= d.AddMonths(QuyDinhDTO.ThoiHanThe);
        }
        public static bool isDatSoLuotMuonToiDa(DocGiaDTO dg, int soSachMuonMuonThem)
        {
            QuyDinhDAO qdDao = new QuyDinhDAO();
            DataTable dt = qdDao.SoSachMuonTrongTGQD(dg);
            int soSachDaMuon = dt.Rows.Count;
            if (soSachDaMuon + soSachMuonMuonThem > QuyDinhDTO.SoSachToiDa)
                return true;
            return false;
        }
        public int DocQuyDinh()
        {
            var tb = qdDAO.DocQuyDinh("TuoiNhoNhat");
            var row = tb.Rows[0];
            QuyDinhDTO.TuoiNhoNhat = (int)row["GiaTri"];
            tb = qdDAO.DocQuyDinh("TuoiLonNhat");
            row = tb.Rows[0];
            QuyDinhDTO.TuoiLonNhat = (int)row["GiaTri"];
            tb = qdDAO.DocQuyDinh("ThoiHanThe");
            row = tb.Rows[0];
            QuyDinhDTO.ThoiHanThe = (int)row["GiaTri"];
            tb = qdDAO.DocQuyDinh("ThoiHanSach");
            row = tb.Rows[0];
            QuyDinhDTO.ThoiHanSach = (int)row["GiaTri"];
            tb = qdDAO.DocQuyDinh("SoSachToiDa");
            row = tb.Rows[0];
            QuyDinhDTO.SoSachToiDa = (int)row["GiaTri"];
            tb = qdDAO.DocQuyDinh("ThoiGianMuon");
            row = tb.Rows[0];
            QuyDinhDTO.ThoiGianMuon = (int)row["GiaTri"];
            return 1;
        }
        public DataTable LayDanhSach()
        {
            return qdDAO.LayDanhSach();
        }
        public int ThayDoiQuyDinh(QuyDinhDTO quyDinh)
        {
            if (int.Parse(quyDinh.GiaTri) < 0)
                return -1;
            return qdDAO.ThayDoiQuyDinh(quyDinh);
        }
        /*DataTable LayDocGiaTheoMa(DocGiaDTO dg)
        {
            string sql = $"select * from DOCGIA where MaDocGia={dg.MaDocGia}";
            return db.DocDuLieu(sql);
        }*/
    }
}
