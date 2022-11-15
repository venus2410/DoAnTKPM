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
    public partial class frmNhanTraSach : Form
    {
        SachBUS sachBus = new SachBUS();
        PhieuMuonBUS pmBus = new PhieuMuonBUS();
        public frmNhanTraSach()
        {
            InitializeComponent();
        }

        private void frmNhanTraSach_Load(object sender, EventArgs e)
        {
            cmbSach.DataSource = sachBus.LayDuLieu();
            cmbSach.DisplayMember = "MaSach";
            cmbSach.ValueMember = "TenSach";
            tbTenSach.Text = cmbSach.SelectedValue.ToString();
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            SachDTO sach = new SachDTO() { 
                MaSach=(int)cmbSach.SelectedItem
            };
            sachBus.TraSach(sach);
            pmBus.TraSach(sach);
            MessageBox.Show("Trả sách thành công");
        }

        private void cmbSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTenSach.Text = cmbSach.SelectedValue.ToString();
        }
    }
}
