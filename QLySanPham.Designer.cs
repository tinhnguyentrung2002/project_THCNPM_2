namespace DoAn
{
    partial class QLySanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLySanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grInfo = new System.Windows.Forms.GroupBox();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.cboDanhmuc = new System.Windows.Forms.ComboBox();
            this.nudSL = new System.Windows.Forms.NumericUpDown();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.txtPrices = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSTT = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbProvider = new System.Windows.Forms.Label();
            this.lbPrices = new System.Windows.Forms.Label();
            this.lbUnit = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbIDProduct = new System.Windows.Forms.Label();
            this.lbSTT = new System.Windows.Forms.Label();
            this.grButton = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDanhmuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbDanhmuc1 = new System.Windows.Forms.Label();
            this.cboCategory1 = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).BeginInit();
            this.grButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // grInfo
            // 
            this.grInfo.Controls.Add(this.cboUnit);
            this.grInfo.Controls.Add(this.cboDanhmuc);
            this.grInfo.Controls.Add(this.nudSL);
            this.grInfo.Controls.Add(this.txtNSX);
            this.grInfo.Controls.Add(this.txtPrices);
            this.grInfo.Controls.Add(this.txtName);
            this.grInfo.Controls.Add(this.txtID);
            this.grInfo.Controls.Add(this.txtSTT);
            this.grInfo.Controls.Add(this.lbCategory);
            this.grInfo.Controls.Add(this.lbAmount);
            this.grInfo.Controls.Add(this.lbProvider);
            this.grInfo.Controls.Add(this.lbPrices);
            this.grInfo.Controls.Add(this.lbUnit);
            this.grInfo.Controls.Add(this.lbName);
            this.grInfo.Controls.Add(this.lbIDProduct);
            this.grInfo.Controls.Add(this.lbSTT);
            this.grInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.grInfo.Location = new System.Drawing.Point(12, 37);
            this.grInfo.Name = "grInfo";
            this.grInfo.Size = new System.Drawing.Size(336, 369);
            this.grInfo.TabIndex = 0;
            this.grInfo.TabStop = false;
            this.grInfo.Text = "Thông tin sản phẩm";
            // 
            // cboUnit
            // 
            this.cboUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Items.AddRange(new object[] {
            "Cái",
            "Bộ",
            "Thùng",
            "Gói",
            "Hộp",
            "Trái",
            "Lon",
            "Lốc"});
            this.cboUnit.Location = new System.Drawing.Point(137, 223);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(125, 28);
            this.cboUnit.TabIndex = 5;
            // 
            // cboDanhmuc
            // 
            this.cboDanhmuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboDanhmuc.FormattingEnabled = true;
            this.cboDanhmuc.Items.AddRange(new object[] {
            "Đồ Gia Dụng",
            "Bộ Quà Tặng",
            "Đồ Uống",
            "Thực phẩm đóng hộp và Khô",
            "Sữa và Các sản phẩm từ sữa",
            "Đồ Ăn Vặt",
            "Gia vị và Chế biến",
            "Thực phẩm chức năng",
            "<Trống>"});
            this.cboDanhmuc.Location = new System.Drawing.Point(137, 32);
            this.cboDanhmuc.Name = "cboDanhmuc";
            this.cboDanhmuc.Size = new System.Drawing.Size(194, 28);
            this.cboDanhmuc.TabIndex = 0;
            // 
            // nudSL
            // 
            this.nudSL.Location = new System.Drawing.Point(137, 304);
            this.nudSL.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSL.Name = "nudSL";
            this.nudSL.Size = new System.Drawing.Size(93, 27);
            this.nudSL.TabIndex = 7;
            // 
            // txtNSX
            // 
            this.txtNSX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNSX.Location = new System.Drawing.Point(137, 265);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(190, 27);
            this.txtNSX.TabIndex = 6;
            // 
            // txtPrices
            // 
            this.txtPrices.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrices.Location = new System.Drawing.Point(137, 184);
            this.txtPrices.Name = "txtPrices";
            this.txtPrices.Size = new System.Drawing.Size(125, 27);
            this.txtPrices.TabIndex = 4;
            this.txtPrices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrices_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Location = new System.Drawing.Point(137, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 27);
            this.txtName.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Location = new System.Drawing.Point(137, 109);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(93, 27);
            this.txtID.TabIndex = 2;
            // 
            // txtSTT
            // 
            this.txtSTT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSTT.Enabled = false;
            this.txtSTT.Location = new System.Drawing.Point(137, 71);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(50, 27);
            this.txtSTT.TabIndex = 1;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCategory.Location = new System.Drawing.Point(25, 35);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(80, 20);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.Text = "Danh mục";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAmount.Location = new System.Drawing.Point(25, 306);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(71, 20);
            this.lbAmount.TabIndex = 0;
            this.lbAmount.Text = "Số lượng";
            // 
            // lbProvider
            // 
            this.lbProvider.AutoSize = true;
            this.lbProvider.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProvider.Location = new System.Drawing.Point(25, 268);
            this.lbProvider.Name = "lbProvider";
            this.lbProvider.Size = new System.Drawing.Size(101, 20);
            this.lbProvider.TabIndex = 0;
            this.lbProvider.Text = "Nhà sản xuất";
            // 
            // lbPrices
            // 
            this.lbPrices.AutoSize = true;
            this.lbPrices.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPrices.Location = new System.Drawing.Point(25, 187);
            this.lbPrices.Name = "lbPrices";
            this.lbPrices.Size = new System.Drawing.Size(32, 20);
            this.lbPrices.TabIndex = 0;
            this.lbPrices.Text = "Giá";
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUnit.Location = new System.Drawing.Point(25, 226);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(86, 20);
            this.lbUnit.TabIndex = 0;
            this.lbUnit.Text = "Đơn vị tính";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(25, 148);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(106, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên sản phẩm";
            // 
            // lbIDProduct
            // 
            this.lbIDProduct.AutoSize = true;
            this.lbIDProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIDProduct.Location = new System.Drawing.Point(25, 112);
            this.lbIDProduct.Name = "lbIDProduct";
            this.lbIDProduct.Size = new System.Drawing.Size(103, 20);
            this.lbIDProduct.TabIndex = 0;
            this.lbIDProduct.Text = "Mã sản phẩm";
            // 
            // lbSTT
            // 
            this.lbSTT.AutoSize = true;
            this.lbSTT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSTT.Location = new System.Drawing.Point(25, 74);
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size(35, 20);
            this.lbSTT.TabIndex = 0;
            this.lbSTT.Text = "STT";
            // 
            // grButton
            // 
            this.grButton.Controls.Add(this.btnReset);
            this.grButton.Controls.Add(this.btnCancel);
            this.grButton.Controls.Add(this.btnXoa);
            this.grButton.Controls.Add(this.btnSave);
            this.grButton.Controls.Add(this.btnSua);
            this.grButton.Controls.Add(this.btnThem);
            this.grButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grButton.ForeColor = System.Drawing.SystemColors.Window;
            this.grButton.Location = new System.Drawing.Point(12, 412);
            this.grButton.Name = "grButton";
            this.grButton.Size = new System.Drawing.Size(336, 143);
            this.grButton.TabIndex = 0;
            this.grButton.TabStop = false;
            this.grButton.Text = "Chức năng";
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(225, 83);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 37);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(25, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 37);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(225, 38);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 39);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(124, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(126, 38);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 39);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(25, 38);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 39);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colIDProduct,
            this.colName,
            this.colGia,
            this.colDVT,
            this.colNSX,
            this.colSL,
            this.colDanhmuc,
            this.colUpdate});
            this.dgvSanPham.Location = new System.Drawing.Point(354, 111);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSanPham.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSanPham.RowTemplate.Height = 25;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(847, 444);
            this.dgvSanPham.TabIndex = 1;
            this.dgvSanPham.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_RowEnter);
            // 
            // colSTT
            // 
            this.colSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.FillWeight = 45.39487F;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            // 
            // colIDProduct
            // 
            this.colIDProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIDProduct.DataPropertyName = "MaSP";
            this.colIDProduct.FillWeight = 121.2692F;
            this.colIDProduct.HeaderText = "Mã sản phẩm";
            this.colIDProduct.MinimumWidth = 6;
            this.colIDProduct.Name = "colIDProduct";
            this.colIDProduct.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "TenSP";
            this.colName.FillWeight = 121.2692F;
            this.colName.HeaderText = "Tên sản phẩm";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colGia
            // 
            this.colGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGia.DataPropertyName = "Gia";
            this.colGia.FillWeight = 121.2692F;
            this.colGia.HeaderText = "Giá (VNĐ)";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            // 
            // colDVT
            // 
            this.colDVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDVT.DataPropertyName = "DVT";
            this.colDVT.FillWeight = 60.91372F;
            this.colDVT.HeaderText = "ĐVT";
            this.colDVT.MinimumWidth = 6;
            this.colDVT.Name = "colDVT";
            this.colDVT.ReadOnly = true;
            // 
            // colNSX
            // 
            this.colNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNSX.DataPropertyName = "NSX";
            this.colNSX.FillWeight = 121.2692F;
            this.colNSX.HeaderText = "NSX";
            this.colNSX.MinimumWidth = 6;
            this.colNSX.Name = "colNSX";
            this.colNSX.ReadOnly = true;
            // 
            // colSL
            // 
            this.colSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSL.DataPropertyName = "SoLuong";
            this.colSL.FillWeight = 87.34574F;
            this.colSL.HeaderText = "Số lượng";
            this.colSL.MinimumWidth = 6;
            this.colSL.Name = "colSL";
            this.colSL.ReadOnly = true;
            // 
            // colDanhmuc
            // 
            this.colDanhmuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDanhmuc.DataPropertyName = "DanhMuc";
            this.colDanhmuc.FillWeight = 121.2692F;
            this.colDanhmuc.HeaderText = "Danh mục";
            this.colDanhmuc.MinimumWidth = 6;
            this.colDanhmuc.Name = "colDanhmuc";
            this.colDanhmuc.ReadOnly = true;
            // 
            // colUpdate
            // 
            this.colUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUpdate.DataPropertyName = "NgayCapNhat";
            this.colUpdate.HeaderText = "Ngày cập nhật";
            this.colUpdate.MinimumWidth = 6;
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.ReadOnly = true;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.lbTitle.Location = new System.Drawing.Point(616, 37);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(292, 32);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1108, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 30);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbDanhmuc1
            // 
            this.lbDanhmuc1.AutoSize = true;
            this.lbDanhmuc1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDanhmuc1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbDanhmuc1.Location = new System.Drawing.Point(354, 80);
            this.lbDanhmuc1.Name = "lbDanhmuc1";
            this.lbDanhmuc1.Size = new System.Drawing.Size(88, 21);
            this.lbDanhmuc1.TabIndex = 2;
            this.lbDanhmuc1.Text = "Danh mục";
            // 
            // cboCategory1
            // 
            this.cboCategory1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCategory1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCategory1.FormattingEnabled = true;
            this.cboCategory1.Items.AddRange(new object[] {
            "Tất cả",
            "Đồ Gia Dụng",
            "Bộ Quà Tặng",
            "Đồ Uống",
            "Thực phẩm đóng hộp và Khô",
            "Sữa và Các sản phẩm từ sữa",
            "Đồ Ăn Vặt",
            "Gia vị và Chế biến",
            "Thực phẩm chức năng"});
            this.cboCategory1.Location = new System.Drawing.Point(457, 76);
            this.cboCategory1.Name = "cboCategory1";
            this.cboCategory1.Size = new System.Drawing.Size(192, 29);
            this.cboCategory1.TabIndex = 14;
            this.cboCategory1.SelectedIndexChanged += new System.EventHandler(this.cboCategory1_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(971, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(131, 29);
            this.txtSearch.TabIndex = 15;
            // 
            // QLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1212, 607);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboCategory1);
            this.Controls.Add(this.lbDanhmuc1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.grButton);
            this.Controls.Add(this.grInfo);
            this.Name = "QLySanPham";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.QLySanPham_Load);
            this.grInfo.ResumeLayout(false);
            this.grInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL)).EndInit();
            this.grButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grInfo;
        private GroupBox grButton;
        private Label lbTitle;
        private TextBox txtNSX;
        private TextBox txtPrices;
        private TextBox txtName;
        private TextBox txtID;
        private TextBox txtSTT;
        private Label lbCategory;
        private Label lbAmount;
        private Label lbProvider;
        private Label lbPrices;
        private Label lbUnit;
        private Label lbName;
        private Label lbIDProduct;
        private Label lbSTT;
        private Button btnCancel;
        private Button btnXoa;
        private Button btnSave;
        private Button btnSua;
        private Button btnThem;
        private Button btnSearch;
        private Label lbDanhmuc1;
        private ComboBox cboCategory1;
        private TextBox txtSearch;
        private ComboBox cboUnit;
        private ComboBox cboDanhmuc;
        private NumericUpDown nudSL;
        private Button btnReset;
        private DataGridViewTextBoxColumn colSTT;
        private DataGridViewTextBoxColumn colIDProduct;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colGia;
        private DataGridViewTextBoxColumn colDVT;
        private DataGridViewTextBoxColumn colNSX;
        private DataGridViewTextBoxColumn colSL;
        private DataGridViewTextBoxColumn colDanhmuc;
        private DataGridViewTextBoxColumn colUpdate;
        public DataGridView dgvSanPham;
    }
}