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
    public partial class frmThemSach : Form
    {
        SachBUS sachBus = new SachBUS();
        public DataGridViewRow sachDuocChon;
        public frmThemSach()
        {
            InitializeComponent();
        }

        private void frmThemSach_Load(object sender, EventArgs e)
        {
            dgvDS.DataSource = sachBus.LayDuLieuThemSach();
            dgvDS.Columns[0].Visible = false;
            dgvDS.Columns[2].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvDS.SelectedRows.Count > 0)
            {
                sachDuocChon = dgvDS.SelectedRows[0];
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
