using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TKPM_21880020.DAO;

namespace TKPM_21880020.BUS
{
    public class TheLoaiSachBUS
    {
        TheLoaiSachDAO tlsDao = new TheLoaiSachDAO();
        public DataTable LayDuLieu()
        {
            return tlsDao.LayDuLieu();
        }
    }
}
