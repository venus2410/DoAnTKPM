using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TKPM_21880020.DAO
{
    public class TheLoaiSachDAO
    {
        XuLyDuLieu db = new XuLyDuLieu();
        public DataTable LayDuLieu()
        {
            string sql = "select * from THELOAI";
            return db.DocDuLieu(sql);
        }
    }
}
