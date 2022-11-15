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
    public partial class frmSach : Form
    {
        SachBUS sachBus = new SachBUS();
        TheLoaiSachBUS theLoaiBus = new TheLoaiSachBUS();
        int maSach;
        public frmSach()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            LayDSSach();
            LayDSTheLoai();
            //LayMaTiepTheo();
        }
        private void LayDSSach()
        {
            var ds = sachBus.LayDuLieu();
            dgvDS.DataSource = ds;
            dgvDS.Columns[0].Visible = false;
            dgvDS.Columns[2].Visible = false;
            dgvDS.Columns[7].Visible = false;
            dgvDS.Columns[8].Visible = false;
        }
        private void LayDSTheLoai()
        {
            var ds = theLoaiBus.LayDuLieu();
            cmbTheLoai.DataSource = ds;
            cmbTheLoai.DisplayMember = "TenTheLoai";
            cmbTheLoai.ValueMember = "MaTheLoai";
        }

        /*private void LayMaTiepTheo()
        {
            var dt = sachBus.LayMaTiepTheo();
            var row = dt.Rows[0];
            if(string.IsNullOrEmpty(row["Max"].ToString()))
            {
                SachDTO.MaTiepTheo = 0;
            }
            else
            {
                SachDTO.MaTiepTheo = (int)row["Max"] + 1;
            }
        }*/

        private void btnThem_Click(object sender, EventArgs e)
        {
            SachDTO sach = new SachDTO()
            {
                MaSach = SachDTO.MaTiepTheo,
                TenSach = tbTenSach.Text,
                TheLoai=(int)cmbTheLoai.SelectedValue,
                TacGia=tbTacGia.Text,
                NamXuatBan=(int)nudNamXuatBan.Value,
                NhaXuatBan=tbNhaXuatBan.Text,
                NgayNhap=dtpNgayNhap.Value
            };
            var kq=sachBus.Them(sach);
            if (kq >= 0)
            {
                SachDTO.MaTiepTheo++;
                MessageBox.Show("Thêm thành công");
                LayDSSach();
            }
            if (kq == -1)
            {
                MessageBox.Show("Sách quá hạn");
            }
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                DataGridViewRow row = dgvDS.Rows[e.RowIndex];
                maSach = (int)row.Cells[0].Value;
                tbTenSach.Text = row.Cells[1].Value.ToString();
                cmbTheLoai.SelectedValue = row.Cells[2].Value;
                tbTacGia.Text = row.Cells[3].Value.ToString();
                nudNamXuatBan.Value = (int)row.Cells[4].Value;
                tbNhaXuatBan.Text = row.Cells[5].Value.ToString();
                dtpNgayNhap.Value = (DateTime)row.Cells[6].Value;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SachDTO sach = new SachDTO()
            {
                MaSach = maSach,
                TenSach = tbTenSach.Text,
                TheLoai = (int)cmbTheLoai.SelectedValue,
                TacGia = tbTacGia.Text,
                NamXuatBan = (int)nudNamXuatBan.Value,
                NhaXuatBan = tbNhaXuatBan.Text,
                NgayNhap = dtpNgayNhap.Value
            };
            var kq = sachBus.CapNhat(sach);
            if (kq >= 0)
            {
                MessageBox.Show("Cập nhật thành công");
                LayDSSach();
            }
            if (kq == -1)
            {
                MessageBox.Show("Sách quá hạn");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SachDTO sach = new SachDTO()
            {
                MaSach = maSach,
                TenSach = tbTenSach.Text,
                TheLoai = (int)cmbTheLoai.SelectedValue,
                TacGia = tbTacGia.Text,
                NamXuatBan = (int)nudNamXuatBan.Value,
                NhaXuatBan = tbNhaXuatBan.Text,
                NgayNhap = dtpNgayNhap.Value
            };
            var kq = sachBus.Xoa(sach);
            if (kq >= 0)
            {
                MessageBox.Show("Xoá thành công");
                LayDSSach();
            }
            if (kq == -1)
            {
                MessageBox.Show("Sách quá hạn");
            }
        }
    }
}
