namespace QLKS_TTN
{
    partial class Thuephong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbThuephong = new System.Windows.Forms.GroupBox();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnThue = new System.Windows.Forms.Button();
            this.ckcChuabiet = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayvao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvthuephong = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThuephong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthuephong)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThuephong
            // 
            this.grbThuephong.Controls.Add(this.txtmaphong);
            this.grbThuephong.Controls.Add(this.txtmakh);
            this.grbThuephong.Controls.Add(this.btnthoat);
            this.grbThuephong.Controls.Add(this.btnhuy);
            this.grbThuephong.Controls.Add(this.btnThue);
            this.grbThuephong.Controls.Add(this.ckcChuabiet);
            this.grbThuephong.Controls.Add(this.label5);
            this.grbThuephong.Controls.Add(this.label4);
            this.grbThuephong.Controls.Add(this.label3);
            this.grbThuephong.Controls.Add(this.dtpNgayra);
            this.grbThuephong.Controls.Add(this.dtpNgayvao);
            this.grbThuephong.Controls.Add(this.label1);
            this.grbThuephong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThuephong.Location = new System.Drawing.Point(91, 11);
            this.grbThuephong.Name = "grbThuephong";
            this.grbThuephong.Size = new System.Drawing.Size(618, 191);
            this.grbThuephong.TabIndex = 3;
            this.grbThuephong.TabStop = false;
            this.grbThuephong.Text = "Thông tin thuê phòng";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(106, 60);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(175, 26);
            this.txtmaphong.TabIndex = 14;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(106, 28);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(175, 26);
            this.txtmakh.TabIndex = 14;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(537, 139);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 46);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(331, 139);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 46);
            this.btnhuy.TabIndex = 5;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThue
            // 
            this.btnThue.Location = new System.Drawing.Point(106, 139);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(75, 46);
            this.btnThue.TabIndex = 4;
            this.btnThue.Text = "Thuê phòng";
            this.btnThue.UseVisualStyleBackColor = true;
            // 
            // ckcChuabiet
            // 
            this.ckcChuabiet.AutoSize = true;
            this.ckcChuabiet.Location = new System.Drawing.Point(398, 94);
            this.ckcChuabiet.Name = "ckcChuabiet";
            this.ckcChuabiet.Size = new System.Drawing.Size(88, 23);
            this.ckcChuabiet.TabIndex = 12;
            this.ckcChuabiet.Text = "Chưa biết";
            this.ckcChuabiet.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã Phòng ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày thuê";
            // 
            // dtpNgayra
            // 
            this.dtpNgayra.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayra.Location = new System.Drawing.Point(398, 63);
            this.dtpNgayra.Name = "dtpNgayra";
            this.dtpNgayra.Size = new System.Drawing.Size(214, 25);
            this.dtpNgayra.TabIndex = 3;
            this.dtpNgayra.Value = new System.DateTime(2019, 5, 27, 0, 0, 0, 0);
            // 
            // dtpNgayvao
            // 
            this.dtpNgayvao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayvao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayvao.Location = new System.Drawing.Point(398, 32);
            this.dtpNgayvao.Name = "dtpNgayvao";
            this.dtpNgayvao.Size = new System.Drawing.Size(214, 25);
            this.dtpNgayvao.TabIndex = 2;
            this.dtpNgayvao.Value = new System.DateTime(2019, 5, 27, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // dgvthuephong
            // 
            this.dgvthuephong.AllowUserToAddRows = false;
            this.dgvthuephong.BackgroundColor = System.Drawing.Color.White;
            this.dgvthuephong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthuephong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPh,
            this.Thue,
            this.SoPhong,
            this.TrangThai});
            this.dgvthuephong.Location = new System.Drawing.Point(91, 208);
            this.dgvthuephong.Name = "dgvthuephong";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvthuephong.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvthuephong.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvthuephong.Size = new System.Drawing.Size(618, 231);
            this.dgvthuephong.TabIndex = 4;
            // 
            // STT
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle1;
            this.STT.Frozen = true;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 70;
            // 
            // MaPh
            // 
            this.MaPh.DataPropertyName = "MaPh";
            this.MaPh.HeaderText = "MaPh";
            this.MaPh.Name = "MaPh";
            this.MaPh.ReadOnly = true;
            this.MaPh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MaPh.Visible = false;
            // 
            // Thue
            // 
            this.Thue.HeaderText = "Thuê";
            this.Thue.Name = "Thue";
            // 
            // SoPhong
            // 
            this.SoPhong.DataPropertyName = "SoPhong";
            this.SoPhong.HeaderText = "Số phòng";
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.ReadOnly = true;
            this.SoPhong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SoPhong.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Thuephong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbThuephong);
            this.Controls.Add(this.dgvthuephong);
            this.Name = "Thuephong";
            this.Text = "Thuê phòng";
            this.grbThuephong.ResumeLayout(false);
            this.grbThuephong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthuephong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThuephong;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnThue;
        private System.Windows.Forms.CheckBox ckcChuabiet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayra;
        private System.Windows.Forms.DateTimePicker dtpNgayvao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvthuephong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Thue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}