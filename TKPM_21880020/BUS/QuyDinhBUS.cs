using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TKPM_21880020.DAO;
using TKPM_21880020.DTO;

namespace TKPM_21880020.BUS
{
    class QuyDinhBUS
    {
        QuyDinhDAO qdDAO = new QuyDinhDAO();
        public static bool isTuoiHopLe(int namSinh)
        {
            if (DateTime.Now.Year - namSinh < QuyDinhDTO.TuoiNhoNhat || DateTime.Now.Year - namSinh > QuyDinhDTO.TuoiLonNhat)
                return false;
            return true;
        }
        public static bool isThoiHanSachHopLe(int namXuatBan)
        {
            return DateTime.Now.Year - namXuatBan < QuyDinhDTO.ThoiHanSach;
        }
        public int DocQuyDinh()
        {
            var tb = qdDAO.DocQuyDinh("TuoiNhoNhat");
            var row = tb.Rows[0];
            QuyDinhDTO.TuoiNhoNhat = (int)row["GiaTri"];
            tb = qdDAO.DocQuyDinh("TuoiLonNhat");
            row = tb.Rows[0];
            QuyDinhDTO.TuoiLonNhat = (int)row["GiaTri"];
            tb = qdDAO.DocQuyDinh("ThoiHanThe");
            row = tb.Rows[0];
            QuyDinhDTO.ThoiHanThe = (int)row["GiaTri"];
            tb = qdDAO.DocQuyDinh("ThoiHanSach");
            row = tb.Rows[0];
            QuyDinhDTO.ThoiHanSach = (int)row["GiaTri"];
            return 1;
        }
    }
}
