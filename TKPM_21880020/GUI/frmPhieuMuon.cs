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
    public partial class frmPhieuMuon : Form
    {
        PhieuMuonBUS pmBus = new PhieuMuonBUS();
        DocGiaBUS dgBus = new DocGiaBUS();
        int maPhieu;
        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            frmThemSach frm = new frmThemSach();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                //tim xem sach them vao da co trong dgvDSSach chua?
                String searchValue = frm.sachDuocChon.Cells[0].Value.ToString();
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvDSSach.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        break;
                    }
                }
                if (rowIndex == -1)
                {
                    /*DataGridViewRow row = (DataGridViewRow)dgvDSSach.Rows[-1].Clone();
                    row.Cells[0].Value = frm.sachDuocChon.Cells[0].Value;
                    row.Cells[1].Value = frm.sachDuocChon.Cells[1].Value;
                    row.Cells[2].Value = frm.sachDuocChon.Cells[2].Value;
                    row.Cells[3].Value = frm.sachDuocChon.Cells[3].Value;*/
                    dgvDSSach.Rows.Add(frm.sachDuocChon.Cells[0].Value, frm.sachDuocChon.Cells[1].Value, frm.sachDuocChon.Cells[2].Value, frm.sachDuocChon.Cells[3].Value, frm.sachDuocChon.Cells[4].Value);
                }
            }
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            cmbTenDocGia.DataSource = dgBus.LayDuLieu();
            cmbTenDocGia.ValueMember = "MaDocGia";
            cmbTenDocGia.DisplayMember = "Ten";
            dgvDSSach.Columns.Add("MaSach", "Mã sách");
            dgvDSSach.Columns.Add("TenSach", "Tên sách");
            dgvDSSach.Columns.Add("MaTheLoai", "Mã thể loại");
            dgvDSSach.Columns.Add("TenTheLoai", "Tên thể loại");
            dgvDSSach.Columns.Add("TacGia", "Tác giả");
            dgvDSSach.Columns[0].Visible = false;
            dgvDSSach.Columns[2].Visible = false;
            LayDSPhieuMuon();
            //LayMaTiepTheo();
        }
        /*private void LayMaTiepTheo()
        {
            var dt = pmBus.LayMaTiepTheo();
            var row = dt.Rows[0];
            if (string.IsNullOrEmpty(row["Max"].ToString()))
            {
                PhieuMuonDTO.MaPhieuTiepTheo = 0;
            }
            else
            {
                PhieuMuonDTO.MaPhieuTiepTheo = (int)row["Max"] + 1;
            }
        }*/
        private void LayDSPhieuMuon()
        {
            dgvDSPhieuMuon.DataSource=pmBus.LayPhieuMuon();
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            List<SachDTO> dsSach = new List<SachDTO>();
            for(int i=0;i<dgvDSSach.Rows.Count;i++)
            {
                DataGridViewRow dgvr = (DataGridViewRow)dgvDSSach.Rows[i].DataBoundItem;
                SachDTO sach = new SachDTO()
                {
                    MaSach=(int)dgvDSSach.Rows[i].Cells[0].Value,
                };
                dsSach.Add(sach);
            }
            DocGiaDTO dg = new DocGiaDTO()
            {
                MaDocGia = (int)cmbTenDocGia.SelectedValue
            };
            PhieuMuonDTO phieuMuon = new PhieuMuonDTO()
            {
                MaPhieu = PhieuMuonDTO.MaPhieuTiepTheo,
                DocGia = dg,
                NgayMuon=dtpNgayMuon.Value,
                dsSach=dsSach
            };
            var kq=pmBus.ThemPhieuMuon(phieuMuon);

            if (kq >= 0)
            {
                PhieuMuonDTO.MaPhieuTiepTheo++;
                MessageBox.Show("Thêm thành công");
                LayDSPhieuMuon();
            }
            if (kq == -1)
            {
                MessageBox.Show("Thẻ hết hạn");
            }
            if (kq == -2)
            {
                MessageBox.Show("Đã vượt quá số lượng sách quy định trong thời gian cho phép");
            }
            if (kq == -3)
            {
                MessageBox.Show("Không có sách trong phiếu");
            }
        }

        private void dgvDSPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDSPhieuMuon.Rows[e.RowIndex];
            maPhieu = (int)row.Cells[0].Value;
            dtpNgayMuon.Value = (DateTime)row.Cells[1].Value;
            cmbTenDocGia.SelectedValue = row.Cells[2].Value;
            /*DataTable dt= pmBus.LayDSSachTuMaPhieu(maPhieu);
            foreach (DataRow dr in dt.Rows) {
                dgvDSSach.Rows.Clear();
                dgvDSSach.Rows.Add(dr["MaSach"], dr["TenSach"], dr["MaTheLoai"], dr["TenTheLoai"], dr["TacGia"]);
            }*/
        }

        private void dgvDSPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnXoaPhieu_Click(object sender, EventArgs e)
        {
            PhieuMuonDTO pm = new PhieuMuonDTO()
            {
                MaPhieu = maPhieu
            };
            var kq= pmBus.XoaPhieu(pm);
            if (kq >= 0)
            {
                MessageBox.Show("Xoá thành công");
                LayDSPhieuMuon();
            }
            if (kq == -1)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý");
            }
        }

        private void btnCapNhatPhieu_Click(object sender, EventArgs e)
        {
            if (dgvDSPhieuMuon.SelectedRows.Count > 0)
            {
                PhieuMuonDTO pm = new PhieuMuonDTO()
                {
                    MaPhieu = maPhieu,
                    DocGia = new DocGiaDTO() { MaDocGia = (int)cmbTenDocGia.SelectedValue },
                    NgayMuon = dtpNgayMuon.Value
                };
                var kq = pmBus.CapNhatPhieu(pm);
                if (kq >= 0)
                {
                    PhieuMuonDTO.MaPhieuTiepTheo++;
                    MessageBox.Show("Thêm thành công");
                    LayDSPhieuMuon();
                }
                if (kq == -1)
                {
                    MessageBox.Show("Thẻ hết hạn");
                }
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDSPhieuMuon.SelectedRows.Count > 0)
            {
                DataTable dt = pmBus.LayDSSachTuMaPhieu(maPhieu);
                foreach (DataRow dr in dt.Rows)
                {
                    dgvDSSach.Rows.Clear();
                    dgvDSSach.Rows.Add(dr["MaSach"], dr["TenSach"], dr["MaTheLoai"], dr["TenTheLoai"], dr["TacGia"]);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvDSSach.Rows.Clear();
            dgvDSPhieuMuon.ClearSelection();
        }
    }
}
