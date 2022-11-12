using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TKPM_21880020.BUS;
using TKPM_21880020.DTO;
using TKPM_21880020.GUI;

namespace TKPM_21880020
{
    public partial class Form1 : Form
    {
        QuyDinhBUS qdBUS = new QuyDinhBUS();
        public Form1()
        {
            InitializeComponent();
        }

        private void docGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocGia frm = new frmDocGia();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            qdBUS.DocQuyDinh();
        }

        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach frm = new frmSach();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
