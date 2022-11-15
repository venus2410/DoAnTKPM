using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TKPM_21880020.DTO;

namespace TKPM_21880020.DAO
{
    public class PhieuMuonDAO
    {
        XuLyDuLieu db = new XuLyDuLieu();
        public DataTable LayPhieuMuon()
        {
            string sql = "select * from PHIEUMUON where isDeleted=0";
            return db.DocDuLieu(sql);
        }
        public int ThemPhieuMuon(PhieuMuonDTO pm)
        {
            string sql;
            //ghi phieu muon
            sql = $"declare @id int;" +
                $"insert into PHIEUMUON(NgayMuon,MaDocGia,isDeleted) values ('{pm.NgayMuon.ToString("MM-dd-yyyy")}',{pm.DocGia.MaDocGia},0);" +
                $"set @id=SCOPE_IDENTITY();";
            //ghi chi tiet phieu muon
            sql += "insert into CHITIETPHIEUMUON(MaSach,MaPhieuMuon,isDeleted) values ";
            foreach(SachDTO sach in pm.dsSach)
            {
                sql += $"({sach.MaSach},@id,0),";
            }
            //sql.Remove(sql.Length-1, 1);
            StringBuilder sb = new StringBuilder(sql);
            sb.Remove(sql.Length-1,1); // index starts at 0!
            sql = sb.ToString();
            sql += ";";
            //sua tinh trang sach
            SachDAO sachDao = new SachDAO();
            foreach(SachDTO sach in pm.dsSach)
            {
                sql += $" update SACH set TinhTrang={TinhTrangDTO.TinhTrangDaMuon} where MaSach={sach.MaSach};";
            }
            return db.GhiDuLieu(sql);
        }
        /*public DataTable LayMaTiepTheo()
        {
            string str = "select MAX(MaPhieu) as Max from PHIEUMUON";
            return db.DocDuLieu(str);
        }*/
        public DataTable LayDSSachTuMaPhieu(int maPhieu)
        {
            string sql = $"select s.MaSach,s.TenSach,s.MaTheLoai,tl.TenTheLoai,s.TacGia from (CHITIETPHIEUMUON ctpm left join SACH s on ctpm.MaSach=s.MaSach) left join THELOAI tl on s.MaTheLoai=tl.MaTheLoai where ctpm.MaPhieuMuon={maPhieu}";
            return db.DocDuLieu(sql);
        }
        public int XoaPhieu(PhieuMuonDTO phieuMuon)
        {
            //xoa phieu
            string sql = $"update PHIEUMUON set isDeleted=1 where MaPhieu={phieuMuon.MaPhieu}";
            db.GhiDuLieu(sql);
            //xoa chitietphieu
            sql = $"update CHITIETPHIEUMUON set isDeleted=1 where MaPhieuMuon={phieuMuon.MaPhieu}";
            db.GhiDuLieu(sql);
            //doi trang thai sach
            sql = $"update SACH set TinhTrang={TinhTrangDTO.TinhTrangMacDinh} where MaSach in (select MaSach from CHITIETPHIEUMUON where MaPhieuMuon={phieuMuon.MaPhieu})";
            db.GhiDuLieu(sql);
            return 1;
        }
        public int CapNhatPhieu(PhieuMuonDTO phieuMuon)
        {
            string sql = $"update PHIEUMUON set NgayMuon='{phieuMuon.NgayMuon.ToString("MM-dd-yyyy")}', MaDocGia={phieuMuon.DocGia.MaDocGia} where MaPhieu={phieuMuon.MaPhieu}";
            return db.GhiDuLieu(sql);
        }
        public int CapNhatTraSach(SachDTO sach)
        {
            string sql = $"update CHITIETPHIEUMUON set isDeleted=1 where MaSach={sach.MaSach}";
            return db.GhiDuLieu(sql);
        }
    }
}
