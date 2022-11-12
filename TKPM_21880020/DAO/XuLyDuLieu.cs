using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TKPM_21880020.DAO
{
    
    public class XuLyDuLieu
    {
        public string duong_dan = @"Data Source=AD\SQLEXPRESS;Initial Catalog=TKPM_CSDL_21880020;Integrated Security=True";

        public DataTable DocDuLieu(string sql)
        {
            SqlConnection ket_noi = new SqlConnection(duong_dan);

            SqlDataAdapter bo_du_lieu = new SqlDataAdapter(sql, ket_noi);

            DataTable bang = new DataTable();
            bo_du_lieu.Fill(bang);

            return bang;

        }

        public int GhiDuLieu(string sql)
        {
            SqlConnection ket_noi = new SqlConnection(duong_dan);

            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            ket_noi.Open();

            var kq = lenh.ExecuteNonQuery();

            ket_noi.Close();

            return kq;
        }
    }
}
