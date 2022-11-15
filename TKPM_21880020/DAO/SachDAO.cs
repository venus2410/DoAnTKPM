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
            string sql = "select s.*,tl.TenTheLoai from SACH s, THELOAI tl where s.MaTheLoai=tl.MaTheLoai and isDeleted=0";
            return db.DocDuLieu(sql);
        }
        public DataTable LayDuLieuThemSach()
        {
            string sql = $"select s.MaSach,s.TenSach,s.MaTheLoai,tl.TenTheLoai,s.TacGia from SACH s left join THELOAI tl on s.MaTheLoai=tl.MaTheLoai where s.isDeleted=0 and s.TinhTrang={TinhTrangDTO.TinhTrangMacDinh}";
            return db.DocDuLieu(sql);
        }
        public int Them(SachDTO sach)
        {
            string sql = string.Format("insert into SACH(TenSach,MaTheLoai,TacGia,NamXuatBan,NhaXuatBan,NgayNhap,TinhTrang,isDeleted) " +
                                                "values ({0}'{1}',{2},'{3}',{4},'{5}','{6}',{7},0)", 
                                                "",sach.TenSach, sach.TheLoai, sach.TacGia, sach.NamXuatBan, sach.NhaXuatBan, sach.NgayNhap.ToString("MM-dd-yyyy"),TinhTrangDTO.TinhTrangMacDinh);
            return db.GhiDuLieu(sql);
        }
        public int CapNhat(SachDTO sach)
        {
            string sql = string.Format("update SACH set TenSach='{0}',MaTheLoai={1}, TacGia='{2}',NamXuatBan={3},NhaXuatBan='{4}',NgayNhap='{5}' where MaSach={6}"
                    , sach.TenSach, sach.TheLoai, sach.TacGia, sach.NamXuatBan, sach.NhaXuatBan, sach.NgayNhap.ToString("MM-dd-yyyy"), sach.MaSach);
            return db.GhiDuLieu(sql);
        }
        public int ThayDoiTinhTrang(SachDTO sach,int maTinhTrang)
        {
            string sql = $"update SACH set TinhTrang={maTinhTrang} where MaSach={sach.MaSach}";
            return db.GhiDuLieu(sql);
        }
        public int Xoa(SachDTO sach)
        {
            string sql = string.Format("update SACH set isDeleted=1 where MaSach={0}", sach.MaSach);
            return db.GhiDuLieu(sql);
        }
        public static DataTable TraCuuSach(SachDTO sach)
        {
            string sql = string.Format("select s.TenSach,tl.TenTheLoai,s.TacGia,tt.TenTinhTrang " +
                "from (SACH s left join THELOAI tl on s.MaTheLoai=tl.MaTheLoai) left join TINHTRANG tt on s.TinhTrang=tt.MaTinhTrang " +
                "where s.TenSach like '%{0}%' or s.MaTheLoai={1}", sach.TenSach,sach.TheLoai);
            XuLyDuLieu db = new XuLyDuLieu();
            return db.DocDuLieu(sql);
        }
        public int TraSach(SachDTO sach)
        {
            string sql = $"update SACH set TinhTrang={TinhTrangDTO.TinhTrangMacDinh} where MaSach={sach.MaSach}";
            return db.GhiDuLieu(sql);
        }
    }
}
