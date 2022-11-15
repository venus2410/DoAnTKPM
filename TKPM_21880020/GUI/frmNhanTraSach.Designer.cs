
namespace TKPM_21880020.GUI
{
    partial class frmNhanTraSach
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
            this.btnTraSach = new System.Windows.Forms.Button();
            this.cmbSach = new System.Windows.Forms.ComboBox();
            this.tbTenSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(491, 76);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(75, 23);
            this.btnTraSach.TabIndex = 0;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // cmbSach
            // 
            this.cmbSach.FormattingEnabled = true;
            this.cmbSach.Location = new System.Drawing.Point(255, 76);
            this.cmbSach.Name = "cmbSach";
            this.cmbSach.Size = new System.Drawing.Size(154, 21);
            this.cmbSach.TabIndex = 1;
            this.cmbSach.SelectedIndexChanged += new System.EventHandler(this.cmbSach_SelectedIndexChanged);
            // 
            // tbTenSach
            // 
            this.tbTenSach.Enabled = false;
            this.tbTenSach.Location = new System.Drawing.Point(255, 116);
            this.tbTenSach.Name = "tbTenSach";
            this.tbTenSach.Size = new System.Drawing.Size(154, 20);
            this.tbTenSach.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên sách";
            // 
            // frmNhanTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTenSach);
            this.Controls.Add(this.cmbSach);
            this.Controls.Add(this.btnTraSach);
            this.Name = "frmNhanTraSach";
            this.Text = "frmTraSach";
            this.Load += new System.EventHandler(this.frmNhanTraSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.ComboBox cmbSach;
        private System.Windows.Forms.TextBox tbTenSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}