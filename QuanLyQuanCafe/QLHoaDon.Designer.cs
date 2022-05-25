namespace QuanLyQuanCafe
{
    partial class QLHoaDon
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
            this.tblDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiGianRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tblChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.colDoUong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tblDanhSachHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDanhSachHoaDon
            // 
            this.tblDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHoaDon,
            this.colThoiGianVao,
            this.colThoiGianRa,
            this.colTongTien});
            this.tblDanhSachHoaDon.Location = new System.Drawing.Point(12, 79);
            this.tblDanhSachHoaDon.Name = "tblDanhSachHoaDon";
            this.tblDanhSachHoaDon.Size = new System.Drawing.Size(593, 328);
            this.tblDanhSachHoaDon.TabIndex = 0;
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.colMaHoaDon.Name = "colMaHoaDon";
            // 
            // colThoiGianVao
            // 
            this.colThoiGianVao.HeaderText = "Thời gian vào";
            this.colThoiGianVao.Name = "colThoiGianVao";
            this.colThoiGianVao.Width = 150;
            // 
            // colThoiGianRa
            // 
            this.colThoiGianRa.HeaderText = "Thời gian ra";
            this.colThoiGianRa.Name = "colThoiGianRa";
            this.colThoiGianRa.Width = 150;
            // 
            // colTongTien
            // 
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Width = 150;
            // 
            // dtFromDate
            // 
            this.dtFromDate.Location = new System.Drawing.Point(12, 24);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtFromDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "đến ngày";
            // 
            // dtToDate
            // 
            this.dtToDate.Location = new System.Drawing.Point(321, 24);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(200, 20);
            this.dtToDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi tiết đồ uống";
            // 
            // tblChiTietHoaDon
            // 
            this.tblChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDoUong,
            this.colSoLuong,
            this.colThanhTien});
            this.tblChiTietHoaDon.Location = new System.Drawing.Point(15, 46);
            this.tblChiTietHoaDon.Name = "tblChiTietHoaDon";
            this.tblChiTietHoaDon.Size = new System.Drawing.Size(370, 333);
            this.tblChiTietHoaDon.TabIndex = 7;
            // 
            // colDoUong
            // 
            this.colDoUong.HeaderText = "Đồ uống";
            this.colDoUong.Name = "colDoUong";
            this.colDoUong.Width = 130;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 70;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Width = 130;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tblChiTietHoaDon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(624, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 396);
            this.panel1.TabIndex = 4;
            // 
            // QLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 419);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.tblDanhSachHoaDon);
            this.Name = "QLHoaDon";
            this.Text = "QLHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.tblDanhSachHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblDanhSachHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGianRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tblChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoUong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Panel panel1;
    }
}