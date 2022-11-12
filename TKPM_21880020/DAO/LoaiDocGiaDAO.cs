using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TKPM_21880020.DAO
{
    public class LoaiDocGiaDAO
    {
        XuLyDuLieu db = new XuLyDuLieu();
        public DataTable DocDuLieu()
        {
            string sql = "select * from LOAIDOCGIA";
            return db.DocDuLieu(sql);
        }
    }
}
