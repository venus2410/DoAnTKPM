using System;
using System.Collections.Generic;
using System.Text;


namespace TKPM_21880020.DTO
{
    
    public class DocGiaDTO
    {
        public int MaDocGia { get; set; }
        public string Ten { get; set; }
        public int MaLoaiDocGia { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public DateTime NgayLapThe { get; set; }
    }
}
