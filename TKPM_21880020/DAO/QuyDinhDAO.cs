using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TKPM_21880020.DTO;

namespace TKPM_21880020.DAO
{
    public class QuyDinhDAO
    {
        XuLyDuLieu db = new XuLyDuLieu();
        public DataTable DocQuyDinh(string tenQD)
        {
            string sql = string.Format("select * from QUYDINH where TenQuyDinh like '%{0}%'",tenQD);
            return db.DocDuLieu(sql);            
        }
        public DataTable LayDanhSach()
        {
            string sql = "select * from QUYDINH";
            return db.DocDuLieu(sql);
        }
        public int ThayDoiQuyDinh(QuyDinhDTO quyDinh)
        {
            string sql = string.Format("update QUYDINH set GiaTri='{0}' where MaQuyDinh={1}",quyDinh.GiaTri,quyDinh.MaQuyDinh);
            return db.GhiDuLieu(sql);
        }
        public DataTable LayDocGiaTheoMa(DocGiaDTO dg)
        {
            string sql = $"select * from DOCGIA where MaDocGia={dg.MaDocGia}";
            return db.DocDuLieu(sql);
        }
        public DataTable SoSachMuonTrongTGQD(DocGiaDTO dg)
        {
            string sql = $"select * from CHITIETPHIEUMUON ctpm,PHIEUMUON pm where ctpm.MaPhieuMuon=pm.MaPhieu and pm.MaDocGia={dg.MaDocGia} and ctpm.isDeleted=0 and pm.isDeleted=0 and pm.NgayMuon between '{DateTime.Now.Date.ToString("MM-dd-yyyy")}' and '{DateTime.Now.Date.AddDays(QuyDinhDTO.ThoiGianMuon).ToString("MM-dd-yyyy")}'";
            return db.DocDuLieu(sql);
        }
    }
}
