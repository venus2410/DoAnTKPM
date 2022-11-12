using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TKPM_21880020.DTO;

namespace TKPM_21880020.DAO
{
    public class DocGiaDAO
    {
        private XuLyDuLieu db = new XuLyDuLieu();
        public DataTable LayDuLieu()
        {
            string str = "select * from DOCGIA where isDeleted=0";
            return db.DocDuLieu(str);
        }
        public DataTable LayMaTiepTheo()
        {
            string str = "select MAX(MaDocGia) as Max from DOCGIA";
            return db.DocDuLieu(str);
        }
        
        public int Them(DocGiaDTO dg)
        {
            string sql = string.Format("insert into DOCGIA(MaDocGia,Ten,MaLoaiDocGia,NgaySinh,DiaChi,Email,NgayLapThe,isDeleted) values ({0},'{1}',{2},'{3}','{4}','{5}','{6}',0)", dg.MaDocGia, dg.Ten, dg.MaLoaiDocGia,dg.NgaySinh,dg.DiaChi,dg.Email,dg.NgayLapThe);
            return db.GhiDuLieu(sql);
        }
        public int CapNhat(DocGiaDTO dg)
        {
            string sql=string.Format("update DOCGIA set Ten='{0}',MaLoaiDocGia={1}, NgaySinh='{2}',DiaChi='{3}',Email='{4}',NgayLapThe='{5}' where MaDocGia={6}",dg.Ten,dg.MaLoaiDocGia,dg.NgaySinh.ToString("MM-dd-yyyy"), dg.DiaChi,dg.Email,dg.NgayLapThe.ToString("MM-dd-yyyy"), dg.MaDocGia);
            return db.GhiDuLieu(sql);
        }
        public int Xoa(DocGiaDTO dg)
        {
            string sql = string.Format("update DOCGIA set isDeleted=1 where MaDocGia={0}", dg.MaDocGia);
            return db.GhiDuLieu(sql);
        }
    }
}
