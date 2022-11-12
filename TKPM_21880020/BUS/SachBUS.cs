using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TKPM_21880020.DAO;
using TKPM_21880020.DTO;

namespace TKPM_21880020.BUS
{
    public class SachBUS
    {
        SachDAO sachDAO = new SachDAO();
        public DataTable LayDuLieu()
        {
            return sachDAO.LayDuLieu();
        }
        public int Them(SachDTO sach)
        {
            if (QuyDinhBUS.isThoiHanSachHopLe(sach.NamXuatBan))
                return sachDAO.Them(sach);
            return -1;
        }
        public int CapNhat(SachDTO sach)
        {
            if (QuyDinhBUS.isThoiHanSachHopLe(sach.NamXuatBan))
                return sachDAO.CapNhat(sach);
            return -1;
        }
        public int Xoa(SachDTO sach)
        {
            return sachDAO.Xoa(sach);
        }
        public DataTable LayMaTiepTheo()
        {
            return sachDAO.LayMaTiepTheo();
        }
    }
}
