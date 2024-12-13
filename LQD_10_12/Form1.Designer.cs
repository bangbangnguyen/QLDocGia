namespace LQD_10_12
{
    partial class Form1
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
            this.btnQLDocGia = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnQLTaiKhoan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDSDocGia = new System.Windows.Forms.Button();
            this.btnDSLoaiDocGia = new System.Windows.Forms.Button();
            this.btnThemDG = new System.Windows.Forms.Button();
            this.btnSuaDG = new System.Windows.Forms.Button();
            this.btnXoaDG = new System.Windows.Forms.Button();
            this.GridDocGia = new System.Windows.Forms.DataGridView();
            this.panelSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQLDocGia
            // 
            this.btnQLDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDocGia.Location = new System.Drawing.Point(0, 40);
            this.btnQLDocGia.Name = "btnQLDocGia";
            this.btnQLDocGia.Size = new System.Drawing.Size(249, 62);
            this.btnQLDocGia.TabIndex = 0;
            this.btnQLDocGia.Text = "Quản lý độc giả";
            this.btnQLDocGia.UseVisualStyleBackColor = true;
            this.btnQLDocGia.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelSidebar.Controls.Add(this.btnQLTaiKhoan);
            this.panelSidebar.Controls.Add(this.btnQLDocGia);
            this.panelSidebar.Location = new System.Drawing.Point(5, 12);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(249, 861);
            this.panelSidebar.TabIndex = 1;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnQLTaiKhoan
            // 
            this.btnQLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTaiKhoan.Location = new System.Drawing.Point(0, 102);
            this.btnQLTaiKhoan.Name = "btnQLTaiKhoan";
            this.btnQLTaiKhoan.Size = new System.Drawing.Size(249, 64);
            this.btnQLTaiKhoan.TabIndex = 2;
            this.btnQLTaiKhoan.Text = "Quản lý tài khoản";
            this.btnQLTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQLTaiKhoan.Click += new System.EventHandler(this.btnQLTaiKhoan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDSLoaiDocGia);
            this.panel1.Controls.Add(this.btnDSDocGia);
            this.panel1.Location = new System.Drawing.Point(257, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 78);
            this.panel1.TabIndex = 2;
            // 
            // btnDSDocGia
            // 
            this.btnDSDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSDocGia.Location = new System.Drawing.Point(3, 3);
            this.btnDSDocGia.Name = "btnDSDocGia";
            this.btnDSDocGia.Size = new System.Drawing.Size(179, 74);
            this.btnDSDocGia.TabIndex = 3;
            this.btnDSDocGia.Text = "Độc giả";
            this.btnDSDocGia.UseVisualStyleBackColor = true;
            // 
            // btnDSLoaiDocGia
            // 
            this.btnDSLoaiDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSLoaiDocGia.Location = new System.Drawing.Point(188, 3);
            this.btnDSLoaiDocGia.Name = "btnDSLoaiDocGia";
            this.btnDSLoaiDocGia.Size = new System.Drawing.Size(179, 74);
            this.btnDSLoaiDocGia.TabIndex = 4;
            this.btnDSLoaiDocGia.Text = "Loại độc giả";
            this.btnDSLoaiDocGia.UseVisualStyleBackColor = true;
            this.btnDSLoaiDocGia.Click += new System.EventHandler(this.btnDSLoaiDocGia_Click);
            // 
            // btnThemDG
            // 
            this.btnThemDG.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThemDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDG.Location = new System.Drawing.Point(1037, 71);
            this.btnThemDG.Name = "btnThemDG";
            this.btnThemDG.Size = new System.Drawing.Size(191, 78);
            this.btnThemDG.TabIndex = 3;
            this.btnThemDG.Text = "Thêm độc giả";
            this.btnThemDG.UseVisualStyleBackColor = false;
            this.btnThemDG.Click += new System.EventHandler(this.btnThemDG_Click);
            // 
            // btnSuaDG
            // 
            this.btnSuaDG.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSuaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDG.Location = new System.Drawing.Point(1234, 74);
            this.btnSuaDG.Name = "btnSuaDG";
            this.btnSuaDG.Size = new System.Drawing.Size(191, 78);
            this.btnSuaDG.TabIndex = 4;
            this.btnSuaDG.Text = "Sửa độc giả";
            this.btnSuaDG.UseVisualStyleBackColor = false;
            // 
            // btnXoaDG
            // 
            this.btnXoaDG.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDG.Location = new System.Drawing.Point(1431, 74);
            this.btnXoaDG.Name = "btnXoaDG";
            this.btnXoaDG.Size = new System.Drawing.Size(191, 78);
            this.btnXoaDG.TabIndex = 5;
            this.btnXoaDG.Text = "Xóa độc giả";
            this.btnXoaDG.UseVisualStyleBackColor = false;
            // 
            // GridDocGia
            // 
            this.GridDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDocGia.Location = new System.Drawing.Point(257, 175);
            this.GridDocGia.Name = "GridDocGia";
            this.GridDocGia.RowHeadersWidth = 82;
            this.GridDocGia.RowTemplate.Height = 33;
            this.GridDocGia.Size = new System.Drawing.Size(1365, 595);
            this.GridDocGia.TabIndex = 6;
            this.GridDocGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDocGia_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1754, 799);
            this.Controls.Add(this.GridDocGia);
            this.Controls.Add(this.btnXoaDG);
            this.Controls.Add(this.btnSuaDG);
            this.Controls.Add(this.btnThemDG);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSidebar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLDocGia;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnQLTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDSLoaiDocGia;
        private System.Windows.Forms.Button btnDSDocGia;
        private System.Windows.Forms.Button btnThemDG;
        private System.Windows.Forms.Button btnSuaDG;
        private System.Windows.Forms.Button btnXoaDG;
        private System.Windows.Forms.DataGridView GridDocGia;
    }
}

