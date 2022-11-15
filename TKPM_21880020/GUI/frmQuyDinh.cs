using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TKPM_21880020.BUS;
using TKPM_21880020.DTO;

namespace TKPM_21880020.GUI
{
    public partial class frmQuyDinh : Form
    {
        QuyDinhBUS qdBus = new QuyDinhBUS();
        int maQD;
        public frmQuyDinh()
        {
            InitializeComponent();
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDS.Rows[e.RowIndex];
            maQD = (int)row.Cells[0].Value;
            tbTen.Text = row.Cells[1].Value.ToString();
            nudGiaTri.Value = (int)row.Cells[2].Value;
            tbKieuGiaTri.Text = row.Cells[3].Value.ToString();
        }
        public void LayDanhSach()
        {
            dgvDS.DataSource= qdBus.LayDanhSach();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            QuyDinhDTO qd = new QuyDinhDTO() {
                MaQuyDinh = maQD,
                TenQuyDinh = tbTen.Text,
                GiaTri=nudGiaTri.Value.ToString(),
                KieuGiaTri=tbKieuGiaTri.Text
            };
            var kq=qdBus.ThayDoiQuyDinh(qd);
            if (kq >= 0)
            {
                MessageBox.Show("Cập nhật thành công");
                LayDanhSach();
                qdBus.DocQuyDinh();
            }
            if (kq == -1)
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
            
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            LayDanhSach();
        }
    }
}
