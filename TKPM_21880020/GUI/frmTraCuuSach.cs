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
    public partial class frmTraCuuSach : Form
    {
        TheLoaiSachBUS tlBus = new TheLoaiSachBUS();
        public frmTraCuuSach()
        {
            InitializeComponent();
        }

        private void frmTraCuuSach_Load(object sender, EventArgs e)
        {
            LayDSTheLoai();
        }
        private void LayDSTheLoai()
        {
            cmbTheLoai.DataSource = tlBus.LayDuLieu();
            cmbTheLoai.DisplayMember = "TenTheLoai";
            cmbTheLoai.ValueMember = "MaTheLoai";
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            SachDTO sach = new SachDTO() {
                TenSach = tbTenSach.Text,
                TheLoai=(int)cmbTheLoai.SelectedValue
            };
            dgvDS.DataSource = SachBUS.TraCuuSach(sach);
            
        }

        private void dgvDS_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvDS.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
