using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TKPM_21880020.DTO;

namespace TKPM_21880020.DAO
{
    public class SachDAO
    {
        XuLyDuLieu db = new XuLyDuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "select * from SACH where isDeleted=0";
            return db.DocDuLieu(sql);
        }
        public DataTable LayMaTiepTheo()
        {
            string str = "select MAX(MaSach) as Max from SACH";
            return db.DocDuLieu(str);
        }
        public int Them(SachDTO sach)
        {
            string sql = string.Format("insert into SACH(MaSach,TenSach,MaTheLoai,TacGia,NamXuatBan,NhaXuatBan,NgayNhap,TinhTrang,isDeleted) " +
                                                "values ({0},'{1}',{2},'{3}',{4},'{5}','{6}',0,0)", 
                                                sach.MaSach, sach.TenSach, sach.TheLoai, sach.TacGia, sach.NamXuatBan, sach.NhaXuatBan, sach.NgayNhap.ToString("MM-dd-yyyy"));
            return db.GhiDuLieu(sql);
        }
        public int CapNhat(SachDTO sach)
        {
            string sql = string.Format("update SACH set TenSach='{0}',MaTheLoai={1}, TacGia='{2}',NamXuatBan={3},NhaXuatBan='{4}',NgayNhap='{5}' where MaSach={6}"
                    , sach.TenSach, sach.TheLoai, sach.TacGia, sach.NamXuatBan, sach.NhaXuatBan, sach.NgayNhap.ToString("MM-dd-yyyy"), sach.MaSach);
            return db.GhiDuLieu(sql);
        }
        public int Xoa(SachDTO sach)
        {
            string sql = string.Format("update SACH set isDeleted=1 where MaSach={0}", sach.MaSach);
            return db.GhiDuLieu(sql);
        }
    }
}
