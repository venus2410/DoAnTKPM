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
    }
}
