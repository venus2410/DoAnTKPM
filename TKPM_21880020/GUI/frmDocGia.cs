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
    public partial class frmDocGia : Form
    {
        DocGiaBUS dgBUS = new DocGiaBUS();
        LoaiDocGiaBUS ldgBUS = new LoaiDocGiaBUS();
        int maDG;
        
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            LayDSDocGia();
            LayDSLoaiDocGia();
            LayMaTiepTheo();
        }
        private void LayDSDocGia()
        {
            var ds =dgBUS.LayDuLieu();
            dgvDS.DataSource = ds;
        }
        private void LayDSLoaiDocGia()
        {
            var ds = ldgBUS.LayDuLieu();
            cmbLoaiDocGia.DataSource = ds;
            cmbLoaiDocGia.DisplayMember = "TenLoaiDocGia";
            cmbLoaiDocGia.ValueMember = "MaLoaiDocGia";
        }

        private void LayMaTiepTheo()
        {
            var dt = dgBUS.LayMaTiepTheo();
            var row = dt.Rows[0];
            if (string.IsNullOrEmpty(row["Max"].ToString()))
            {
                DocGiaDTO.MaTiepTheo = 0;
            }
            else
            {
                DocGiaDTO.MaTiepTheo = (int)row["Max"] + 1;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DocGiaDTO dg = new DocGiaDTO()
            {
                MaDocGia = DocGiaDTO.MaTiepTheo,
                Ten = tbHoTen.Text,
                MaLoaiDocGia = (int)cmbLoaiDocGia.SelectedValue,
                NgaySinh=dtpNgaySinh.Value.Date,
                DiaChi=tbDiachi.Text,
                Email=tbEmail.Text,
                NgayLapThe=dtpNgayLapThe.Value.Date
            };

            var kq = dgBUS.Them(dg);
            
            if(kq>=0)
            {
                DocGiaDTO.MaTiepTheo++;
                MessageBox.Show("Them thanh cong");
                LayDSDocGia();
            }
            if (kq == -1)
            {
                MessageBox.Show("Tuoi khong hop le");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DocGiaDTO dg = new DocGiaDTO()
            {
                MaDocGia = maDG,
                Ten = tbHoTen.Text,
                MaLoaiDocGia = (int)cmbLoaiDocGia.SelectedValue,
                NgaySinh = dtpNgaySinh.Value.Date,
                DiaChi = tbDiachi.Text,
                Email = tbEmail.Text,
                NgayLapThe = dtpNgayLapThe.Value.Date
            };

            var kq = dgBUS.CapNhat(dg);

            if (kq >= 0)
            {
                MessageBox.Show("Cap nhat thanh cong");
                LayDSDocGia();
            }
            if (kq == -1)
            {
                MessageBox.Show("Tuoi khong hop le");
            }
        }

        private void dgvDS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDS.Rows[e.RowIndex];
            tbHoTen.Text = row.Cells[1].Value.ToString();
            cmbLoaiDocGia.SelectedIndex = (int)row.Cells[2].Value-1;
            dtpNgaySinh.Value = (DateTime)row.Cells[3].Value;
            tbDiachi.Text = row.Cells[4].Value.ToString();
            tbEmail.Text = row.Cells[5].Value.ToString();
            dtpNgayLapThe.Value = (DateTime)row.Cells[6].Value;
            maDG = (int)row.Cells[0].Value;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DocGiaDTO dg = new DocGiaDTO()
            {
                MaDocGia = maDG,
                Ten = tbHoTen.Text,
                MaLoaiDocGia = (int)cmbLoaiDocGia.SelectedValue,
                NgaySinh = dtpNgaySinh.Value.Date,
                DiaChi = tbDiachi.Text,
                Email = tbEmail.Text,
                NgayLapThe = dtpNgayLapThe.Value.Date
            };

            var kq = dgBUS.Xoa(dg);

            if (kq >= 0)
            {
                MessageBox.Show("Xoa thanh cong");
                LayDSDocGia();
            }
            else
            {
                MessageBox.Show("Co loi trong qua trinh xu ly");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbLoaiDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
