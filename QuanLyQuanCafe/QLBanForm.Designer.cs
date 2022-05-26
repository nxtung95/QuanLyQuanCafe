namespace QuanLyQuanCafe
{
    partial class QLBanForm
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
            this.cbLoaiDoUong = new System.Windows.Forms.ComboBox();
            this.cbDoUong = new System.Windows.Forms.ComboBox();
            this.btnThemDoUong = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.cbBanChuyen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numGiamGia = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.btnXoaBan = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lvMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoaiDoUong
            // 
            this.cbLoaiDoUong.BackColor = System.Drawing.SystemColors.Window;
            this.cbLoaiDoUong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbLoaiDoUong.Location = new System.Drawing.Point(459, 12);
            this.cbLoaiDoUong.MaxDropDownItems = 20;
            this.cbLoaiDoUong.Name = "cbLoaiDoUong";
            this.cbLoaiDoUong.Size = new System.Drawing.Size(292, 21);
            this.cbLoaiDoUong.TabIndex = 1;
            this.cbLoaiDoUong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiDoUong_SelectedIndexChanged);
            // 
            // cbDoUong
            // 
            this.cbDoUong.FormattingEnabled = true;
            this.cbDoUong.Location = new System.Drawing.Point(461, 58);
            this.cbDoUong.Name = "cbDoUong";
            this.cbDoUong.Size = new System.Drawing.Size(290, 21);
            this.cbDoUong.TabIndex = 2;
            // 
            // btnThemDoUong
            // 
            this.btnThemDoUong.Location = new System.Drawing.Point(767, 23);
            this.btnThemDoUong.Name = "btnThemDoUong";
            this.btnThemDoUong.Size = new System.Drawing.Size(72, 47);
            this.btnThemDoUong.TabIndex = 4;
            this.btnThemDoUong.Text = "Thêm đồ uống";
            this.btnThemDoUong.UseVisualStyleBackColor = true;
            this.btnThemDoUong.Click += new System.EventHandler(this.btnThemDoUong_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(865, 38);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(47, 20);
            this.numSoLuong.TabIndex = 5;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Location = new System.Drawing.Point(974, 261);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(102, 51);
            this.btnChuyenBan.TabIndex = 6;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            // 
            // cbBanChuyen
            // 
            this.cbBanChuyen.FormattingEnabled = true;
            this.cbBanChuyen.Location = new System.Drawing.Point(972, 234);
            this.cbBanChuyen.Name = "cbBanChuyen";
            this.cbBanChuyen.Size = new System.Drawing.Size(110, 21);
            this.cbBanChuyen.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(971, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bàn cần chuyển";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(973, 419);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(109, 44);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(981, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Giảm giá";
            // 
            // numGiamGia
            // 
            this.numGiamGia.Location = new System.Drawing.Point(981, 334);
            this.numGiamGia.Name = "numGiamGia";
            this.numGiamGia.Size = new System.Drawing.Size(76, 20);
            this.numGiamGia.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(978, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tổng tiền";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(974, 376);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 13;
            // 
            // btnThemBan
            // 
            this.btnThemBan.Location = new System.Drawing.Point(981, 99);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(95, 45);
            this.btnThemBan.TabIndex = 14;
            this.btnThemBan.Text = "Thêm bàn";
            this.btnThemBan.UseVisualStyleBackColor = true;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.Location = new System.Drawing.Point(981, 150);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(95, 45);
            this.btnXoaBan.TabIndex = 15;
            this.btnXoaBan.Text = "Xóa Bàn";
            this.btnXoaBan.UseVisualStyleBackColor = true;
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(438, 449);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // lvMenu
            // 
            this.lvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMenu.HideSelection = false;
            this.lvMenu.Location = new System.Drawing.Point(466, 95);
            this.lvMenu.Name = "lvMenu";
            this.lvMenu.Size = new System.Drawing.Size(501, 369);
            this.lvMenu.TabIndex = 17;
            this.lvMenu.UseCompatibleStateImageBehavior = false;
            this.lvMenu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Đồ uống";
            this.columnHeader1.Width = 179;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 164;
            // 
            // QLBanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 476);
            this.Controls.Add(this.lvMenu);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnXoaBan);
            this.Controls.Add(this.btnThemBan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numGiamGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBanChuyen);
            this.Controls.Add(this.btnChuyenBan);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.btnThemDoUong);
            this.Controls.Add(this.cbDoUong);
            this.Controls.Add(this.cbLoaiDoUong);
            this.Name = "QLBanForm";
            this.Text = "Quản lý bàn";
            this.Load += new System.EventHandler(this.QLBanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiamGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbLoaiDoUong;
        private System.Windows.Forms.ComboBox cbDoUong;
        private System.Windows.Forms.Button btnThemDoUong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.ComboBox cbBanChuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numGiamGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.Button btnXoaBan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView lvMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}