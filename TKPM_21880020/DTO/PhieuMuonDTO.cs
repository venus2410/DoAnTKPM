using System;
using System.Collections.Generic;
using System.Text;

namespace TKPM_21880020.DTO
{
    public class PhieuMuonDTO
    {
        public static int MaPhieuTiepTheo;
        public int MaPhieu { get; set; }
        public DocGiaDTO DocGia { get; set; }
        public DateTime NgayMuon { get; set; }
        public List<SachDTO> dsSach { get; set; }
    }
}
