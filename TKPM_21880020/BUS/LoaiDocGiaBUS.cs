using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TKPM_21880020.DAO;

namespace TKPM_21880020.BUS
{
    public class LoaiDocGiaBUS
    {
        LoaiDocGiaDAO dgDAO = new LoaiDocGiaDAO();
        public DataTable LayDuLieu()
        {
            return dgDAO.DocDuLieu();
        }
    }
}
