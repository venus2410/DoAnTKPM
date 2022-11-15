using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TKPM_21880020.DAO;
using TKPM_21880020.DTO;

namespace TKPM_21880020.BUS
{
    class DocGiaBUS
    {
        DocGiaDAO dgDao = new DocGiaDAO();
        
        public DataTable LayDuLieu()
        {
            return dgDao.LayDuLieu();
        }
        public int Them(DocGiaDTO dg)
        {
            if(QuyDinhBUS.isTuoiHopLe(dg.NgaySinh.Year))
            return dgDao.Them(dg);
            return -1;
        }
        public int CapNhat(DocGiaDTO dg)
        {
            if (QuyDinhBUS.isTuoiHopLe(dg.NgaySinh.Year))
            return dgDao.CapNhat(dg);
            return -1;
        }
        public int Xoa(DocGiaDTO dg)
        {
            return dgDao.Xoa(dg);
        }
        /*public DataTable LayMaTiepTheo()
        {
            return dgDao.LayMaTiepTheo();
        }*/
        
    }
}
