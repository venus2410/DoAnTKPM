
namespace TKPM_21880020.GUI
{
    partial class frmPhieuMuon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDSPhieuMuon = new System.Windows.Forms.DataGridView();
            this.cmbTenDocGia = new System.Windows.Forms.ComboBox();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dgvDSSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnThemPhieu = new System.Windows.Forms.Button();
            this.btnCapNhatPhieu = new System.Windows.Forms.Button();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSPhieuMuon
            // 
            this.dgvDSPhieuMuon.AllowUserToAddRows = false;
            this.dgvDSPhieuMuon.AllowUserToDeleteRows = false;
            this.dgvDSPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieuMuon.Location = new System.Drawing.Point(12, 30);
            this.dgvDSPhieuMuon.Name = "dgvDSPhieuMuon";
            this.dgvDSPhieuMuon.Size = new System.Drawing.Size(282, 296);
            this.dgvDSPhieuMuon.TabIndex = 0;
            this.dgvDSPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhieuMuon_CellClick);
            this.dgvDSPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhieuMuon_CellContentClick);
            // 
            // cmbTenDocGia
            // 
            this.cmbTenDocGia.FormattingEnabled = true;
            this.cmbTenDocGia.Location = new System.Drawing.Point(447, 62);
            this.cmbTenDocGia.Name = "cmbTenDocGia";
            this.cmbTenDocGia.Size = new System.Drawing.Size(200, 21);
            this.cmbTenDocGia.TabIndex = 1;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(447, 30);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayMuon.TabIndex = 2;
            // 
            // dgvDSSach
            // 
            this.dgvDSSach.AllowUserToAddRows = false;
            this.dgvDSSach.AllowUserToDeleteRows = false;
            this.dgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSach.Location = new System.Drawing.Point(333, 176);
            this.dgvDSSach.Name = "dgvDSSach";
            this.dgvDSSach.Size = new System.Drawing.Size(439, 150);
            this.dgvDSSach.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Độc giả";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày mượn";
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(333, 147);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(75, 23);
            this.btnThemSach.TabIndex = 6;
            this.btnThemSach.Text = "Thêm sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.Location = new System.Drawing.Point(333, 97);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(75, 23);
            this.btnThemPhieu.TabIndex = 7;
            this.btnThemPhieu.Text = "Thêm phiếu";
            this.btnThemPhieu.UseVisualStyleBackColor = true;
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // btnCapNhatPhieu
            // 
            this.btnCapNhatPhieu.Location = new System.Drawing.Point(447, 96);
            this.btnCapNhatPhieu.Name = "btnCapNhatPhieu";
            this.btnCapNhatPhieu.Size = new System.Drawing.Size(91, 23);
            this.btnCapNhatPhieu.TabIndex = 8;
            this.btnCapNhatPhieu.Text = "Cập nhật phiếu";
            this.btnCapNhatPhieu.UseVisualStyleBackColor = true;
            this.btnCapNhatPhieu.Click += new System.EventHandler(this.btnCapNhatPhieu_Click);
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Location = new System.Drawing.Point(572, 96);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(75, 23);
            this.btnXoaPhieu.TabIndex = 9;
            this.btnXoaPhieu.Text = "Xoá phiếu";
            this.btnXoaPhieu.UseVisualStyleBackColor = true;
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(690, 96);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(75, 23);
            this.btnXemChiTiet.TabIndex = 10;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(690, 147);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnXoaPhieu);
            this.Controls.Add(this.btnCapNhatPhieu);
            this.Controls.Add(this.btnThemPhieu);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSSach);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.cmbTenDocGia);
            this.Controls.Add(this.dgvDSPhieuMuon);
            this.Name = "frmPhieuMuon";
            this.Text = "frmPhieuMuon";
            this.Load += new System.EventHandler(this.frmPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSPhieuMuon;
        private System.Windows.Forms.ComboBox cmbTenDocGia;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.DataGridView dgvDSSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnThemPhieu;
        private System.Windows.Forms.Button btnCapNhatPhieu;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnReset;
    }
}