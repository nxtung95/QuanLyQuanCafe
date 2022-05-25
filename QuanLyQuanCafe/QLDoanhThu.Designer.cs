namespace QuanLyQuanCafe
{
    partial class QLDoanhThu
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.colTenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblDanhSachHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(323, 13);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(563, 11);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 40);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "đến ngày";
            // 
            // tblDanhSachHoaDon
            // 
            this.tblDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenBan,
            this.colThoiGianVao,
            this.colThoiGianRa,
            this.colTongTien});
            this.tblDanhSachHoaDon.Location = new System.Drawing.Point(16, 56);
            this.tblDanhSachHoaDon.Name = "tblDanhSachHoaDon";
            this.tblDanhSachHoaDon.Size = new System.Drawing.Size(622, 310);
            this.tblDanhSachHoaDon.TabIndex = 4;
            // 
            // colTenBan
            // 
            this.colTenBan.HeaderText = "Tên Bàn";
            this.colTenBan.Name = "colTenBan";
            // 
            // colThoiGianVao
            // 
            this.colThoiGianVao.HeaderText = "Thời gian vào";
            this.colThoiGianVao.Name = "colThoiGianVao";
            this.colThoiGianVao.Width = 150;
            // 
            // colThoiGianRa
            // 
            this.colThoiGianRa.HeaderText = "Thời Gian Ra";
            this.colThoiGianRa.Name = "colThoiGianRa";
            this.colThoiGianRa.Width = 150;
            // 
            // colTongTien
            // 
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Width = 200;
            // 
            // QLDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 378);
            this.Controls.Add(this.tblDanhSachHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "QLDoanhThu";
            this.Text = "QLDoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.tblDanhSachHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tblDanhSachHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
    }
}