﻿namespace DoAn
{
    partial class QLyCTHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLyCTHD));
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lbList = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.grbCTHD = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaCTHD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.grbCTHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            this.dgvCTHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvCTHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCTHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTHD.ColumnHeadersHeight = 40;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaCTHD,
            this.colMaHD,
            this.colMaSP,
            this.colTenSP,
            this.colSL,
            this.ColDG,
            this.colThanhTien});
            this.dgvCTHD.Location = new System.Drawing.Point(36, 312);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTHD.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCTHD.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCTHD.RowTemplate.Height = 25;
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.Size = new System.Drawing.Size(856, 325);
            this.dgvCTHD.TabIndex = 4;
            this.dgvCTHD.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_RowEnter);
            // 
            // colSTT
            // 
            this.colSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSTT.DataPropertyName = "ID";
            this.colSTT.FillWeight = 42.90066F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Visible = false;
            // 
            // colMaCTHD
            // 
            this.colMaCTHD.DataPropertyName = "MaCTHD";
            this.colMaCTHD.HeaderText = "Mã chi tiết HD";
            this.colMaCTHD.MinimumWidth = 6;
            this.colMaCTHD.Name = "colMaCTHD";
            this.colMaCTHD.ReadOnly = true;
            this.colMaCTHD.Width = 125;
            // 
            // colMaHD
            // 
            this.colMaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaHD.DataPropertyName = "MaHD";
            this.colMaHD.FillWeight = 114.606F;
            this.colMaHD.HeaderText = "Mã hóa đơn";
            this.colMaHD.MinimumWidth = 6;
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.ReadOnly = true;
            // 
            // colMaSP
            // 
            this.colMaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaSP.DataPropertyName = "MaSP";
            this.colMaSP.FillWeight = 114.606F;
            this.colMaSP.HeaderText = "Mã sản phẩm";
            this.colMaSP.MinimumWidth = 6;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            this.colTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSP.DataPropertyName = "TenSP";
            this.colTenSP.FillWeight = 114.606F;
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            // 
            // colSL
            // 
            this.colSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSL.DataPropertyName = "SoLuong";
            this.colSL.HeaderText = "Số lượng";
            this.colSL.MinimumWidth = 6;
            this.colSL.Name = "colSL";
            this.colSL.ReadOnly = true;
            // 
            // ColDG
            // 
            this.ColDG.DataPropertyName = "DonGia";
            this.ColDG.HeaderText = "Đơn giá";
            this.ColDG.MinimumWidth = 6;
            this.ColDG.Name = "ColDG";
            this.ColDG.ReadOnly = true;
            this.ColDG.Width = 125;
            // 
            // colThanhTien
            // 
            this.colThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.FillWeight = 82.5465F;
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(284, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 33);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(18, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetry.Image = ((System.Drawing.Image)(resources.GetObject("btnRetry.Image")));
            this.btnRetry.Location = new System.Drawing.Point(548, 207);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(89, 33);
            this.btnRetry.TabIndex = 13;
            this.btnRetry.Text = "Khởi tạo";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(151, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 33);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(416, 207);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 33);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaSP.Location = new System.Drawing.Point(142, 71);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.PlaceholderText = "Nhập mã sản phẩm";
            this.txtMaSP.Size = new System.Drawing.Size(243, 27);
            this.txtMaSP.TabIndex = 6;
            this.txtMaSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSP_KeyPress);
            this.txtMaSP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaSP_KeyUp);
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(25, 73);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(56, 20);
            this.lbSDT.TabIndex = 0;
            this.lbSDT.Text = "Mã SP:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.Enabled = false;
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenSP.Location = new System.Drawing.Point(142, 108);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PlaceholderText = "Tên Sản Phẩm";
            this.txtTenSP.Size = new System.Drawing.Size(243, 27);
            this.txtTenSP.TabIndex = 8;
            this.txtTenSP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTenSP_KeyUp);
            // 
            // lbList
            // 
            this.lbList.AutoSize = true;
            this.lbList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbList.ForeColor = System.Drawing.SystemColors.Window;
            this.lbList.Location = new System.Drawing.Point(351, 279);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(276, 30);
            this.lbList.TabIndex = 5;
            this.lbList.Text = "Danh sách chi tiết hóa đơn";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(25, 108);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(59, 20);
            this.lbAddress.TabIndex = 0;
            this.lbAddress.Text = "Tên SP:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(458, 76);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(0, 20);
            this.lbEmail.TabIndex = 0;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtThanhTien.Location = new System.Drawing.Point(142, 146);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.PlaceholderText = "Thành tiền";
            this.txtThanhTien.Size = new System.Drawing.Size(243, 27);
            this.txtThanhTien.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thành tiền:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHD.Location = new System.Drawing.Point(584, 32);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PlaceholderText = "Nhập mã hóa đơn";
            this.txtMaHD.Size = new System.Drawing.Size(243, 27);
            this.txtMaHD.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(25, 37);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(79, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Mã CTHD:";
            // 
            // grbCTHD
            // 
            this.grbCTHD.Controls.Add(this.btnCancel);
            this.grbCTHD.Controls.Add(this.btnAdd);
            this.grbCTHD.Controls.Add(this.btnSave);
            this.grbCTHD.Controls.Add(this.btnRetry);
            this.grbCTHD.Controls.Add(this.btnDelete);
            this.grbCTHD.Controls.Add(this.btnUpdate);
            this.grbCTHD.Controls.Add(this.txtSoLuong);
            this.grbCTHD.Controls.Add(this.lblSoLuong);
            this.grbCTHD.Controls.Add(this.txtMaSP);
            this.grbCTHD.Controls.Add(this.lbSDT);
            this.grbCTHD.Controls.Add(this.txtDonGia);
            this.grbCTHD.Controls.Add(this.txtTenSP);
            this.grbCTHD.Controls.Add(this.lblDonGia);
            this.grbCTHD.Controls.Add(this.lbAddress);
            this.grbCTHD.Controls.Add(this.lbEmail);
            this.grbCTHD.Controls.Add(this.txtThanhTien);
            this.grbCTHD.Controls.Add(this.label1);
            this.grbCTHD.Controls.Add(this.label2);
            this.grbCTHD.Controls.Add(this.txtMaCTHD);
            this.grbCTHD.Controls.Add(this.txtMaHD);
            this.grbCTHD.Controls.Add(this.lbName);
            this.grbCTHD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbCTHD.ForeColor = System.Drawing.Color.White;
            this.grbCTHD.Location = new System.Drawing.Point(36, 9);
            this.grbCTHD.Name = "grbCTHD";
            this.grbCTHD.Size = new System.Drawing.Size(856, 267);
            this.grbCTHD.TabIndex = 3;
            this.grbCTHD.TabStop = false;
            this.grbCTHD.Text = "Thông tin chi tiết hóa đơn";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(680, 207);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 33);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoLuong.Location = new System.Drawing.Point(584, 71);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PlaceholderText = "Nhập số lượng";
            this.txtSoLuong.Size = new System.Drawing.Size(243, 27);
            this.txtSoLuong.TabIndex = 6;
            this.txtSoLuong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSoLuong_KeyUp);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(472, 73);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(75, 20);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDonGia.Location = new System.Drawing.Point(584, 112);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PlaceholderText = "Giá sản phẩm";
            this.txtDonGia.Size = new System.Drawing.Size(243, 27);
            this.txtDonGia.TabIndex = 8;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(472, 113);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(67, 20);
            this.lblDonGia.TabIndex = 0;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã HD:";
            // 
            // txtMaCTHD
            // 
            this.txtMaCTHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaCTHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaCTHD.Enabled = false;
            this.txtMaCTHD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaCTHD.Location = new System.Drawing.Point(142, 32);
            this.txtMaCTHD.Name = "txtMaCTHD";
            this.txtMaCTHD.PlaceholderText = "Mã CTHD";
            this.txtMaCTHD.Size = new System.Drawing.Size(243, 27);
            this.txtMaCTHD.TabIndex = 2;
            // 
            // QLyCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(928, 646);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.grbCTHD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLyCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi tiết hóa đơn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QLyCTHD_FormClosed);
            this.Load += new System.EventHandler(this.QLyCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.grbCTHD.ResumeLayout(false);
            this.grbCTHD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvCTHD;
        private Button btnCancel;
        private Button btnAdd;
        private Button btnRetry;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtMaSP;
        private Label lbSDT;
        private TextBox txtTenSP;
        private Label lbList;
        private Label lbAddress;
        private Label lbEmail;
        private TextBox txtThanhTien;
        private Label label1;
        private TextBox txtMaHD;
        private Label lbName;
        private GroupBox grbCTHD;
        private TextBox txtSoLuong;
        private Label lblSoLuong;
        private Label label2;
        private TextBox txtMaCTHD;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Button btnSave;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colMaCTHD;
        private DataGridViewTextBoxColumn colMaHD;
        private DataGridViewTextBoxColumn colMaSP;
        private DataGridViewTextBoxColumn colTenSP;
        private DataGridViewTextBoxColumn colSL;
        private DataGridViewTextBoxColumn ColDG;
        private DataGridViewTextBoxColumn colThanhTien;
    }
}