using System;
using System.Collections.Generic;
using System.Text;

namespace TKPM_21880020.DTO
{
    public class SachDTO
    {
        public static int MaTiepTheo;
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public int TheLoai { get; set; }
        public string TacGia { get; set; }
        public int NamXuatBan { get; set; }
        public string NhaXuatBan { get; set; }
        public DateTime NgayNhap { get; set; }
        public int TinhTrang { get; set; }
    }
}
