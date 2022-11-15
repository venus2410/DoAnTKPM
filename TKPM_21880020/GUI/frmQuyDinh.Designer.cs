
namespace TKPM_21880020.GUI
{
    partial class frmQuyDinh
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
            this.dgvDS = new System.Windows.Forms.DataGridView();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.nudGiaTri = new System.Windows.Forms.NumericUpDown();
            this.tbKieuGiaTri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDS
            // 
            this.dgvDS.AllowUserToAddRows = false;
            this.dgvDS.AllowUserToDeleteRows = false;
            this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS.Location = new System.Drawing.Point(12, 54);
            this.dgvDS.Name = "dgvDS";
            this.dgvDS.Size = new System.Drawing.Size(381, 231);
            this.dgvDS.TabIndex = 0;
            this.dgvDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDS_CellClick);
            // 
            // tbTen
            // 
            this.tbTen.Enabled = false;
            this.tbTen.Location = new System.Drawing.Point(513, 63);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(120, 20);
            this.tbTen.TabIndex = 1;
            // 
            // nudGiaTri
            // 
            this.nudGiaTri.Location = new System.Drawing.Point(513, 107);
            this.nudGiaTri.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudGiaTri.Name = "nudGiaTri";
            this.nudGiaTri.Size = new System.Drawing.Size(120, 20);
            this.nudGiaTri.TabIndex = 2;
            // 
            // tbKieuGiaTri
            // 
            this.tbKieuGiaTri.Enabled = false;
            this.tbKieuGiaTri.Location = new System.Drawing.Point(513, 153);
            this.tbKieuGiaTri.Name = "tbKieuGiaTri";
            this.tbKieuGiaTri.Size = new System.Drawing.Size(120, 20);
            this.tbKieuGiaTri.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên quy định";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá trị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kiểu giá trị";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(513, 219);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKieuGiaTri);
            this.Controls.Add(this.nudGiaTri);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.dgvDS);
            this.Name = "frmQuyDinh";
            this.Text = "frmQuyDinh";
            this.Load += new System.EventHandler(this.frmQuyDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiaTri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDS;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.NumericUpDown nudGiaTri;
        private System.Windows.Forms.TextBox tbKieuGiaTri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapNhat;
    }
}