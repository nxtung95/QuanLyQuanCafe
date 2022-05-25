namespace QuanLyQuanCafe
{
    partial class QLCafeForm
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
            this.btnQuanLyBan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanLyBan
            // 
            this.btnQuanLyBan.Location = new System.Drawing.Point(183, 162);
            this.btnQuanLyBan.Name = "btnQuanLyBan";
            this.btnQuanLyBan.Size = new System.Drawing.Size(90, 50);
            this.btnQuanLyBan.TabIndex = 0;
            this.btnQuanLyBan.Text = "Quản lý bàn";
            this.btnQuanLyBan.UseVisualStyleBackColor = true;
            this.btnQuanLyBan.Click += new System.EventHandler(this.btnQuanLyBan_Click);
            // 
            // QLCafeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuanLyBan);
            this.Name = "QLCafeForm";
            this.Text = "Quản lý quán cafe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLyBan;
    }
}

