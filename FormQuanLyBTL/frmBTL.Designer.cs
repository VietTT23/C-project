namespace FormQuanLyBTL
{
    partial class frmBTL
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMaHP = new System.Windows.Forms.ComboBox();
            this.tblHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset11 = new FormQuanLyBTL.Dataset1();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaBTL = new System.Windows.Forms.TextBox();
            this.txtTenBTL = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvBTL = new System.Windows.Forms.DataGridView();
            this.maBTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenBTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBTLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bntThem = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntSavesua = new System.Windows.Forms.Button();
            this.bntReset = new System.Windows.Forms.Button();
            this.bntHome = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblBTLTableAdapter1 = new FormQuanLyBTL.Dataset1TableAdapters.tblBTLTableAdapter();
            this.tblHPTableAdapter1 = new FormQuanLyBTL.Dataset1TableAdapters.tblHPTableAdapter();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBTLBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 134);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bài tập lớn";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbxMaHP, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMaBTL, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTenBTL, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtNam, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(670, 109);
            this.tableLayoutPanel2.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã bài tập lớn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên bài tập lớn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(338, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Học phần";
            // 
            // cbxMaHP
            // 
            this.cbxMaHP.DataSource = this.tblHPBindingSource;
            this.cbxMaHP.DisplayMember = "TenHP";
            this.cbxMaHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaHP.FormattingEnabled = true;
            this.cbxMaHP.Location = new System.Drawing.Point(504, 57);
            this.cbxMaHP.Name = "cbxMaHP";
            this.cbxMaHP.Size = new System.Drawing.Size(163, 27);
            this.cbxMaHP.TabIndex = 11;
            this.cbxMaHP.ValueMember = "MaHP";
            // 
            // tblHPBindingSource
            // 
            this.tblHPBindingSource.DataMember = "tblHP";
            this.tblHPBindingSource.DataSource = this.dataset11;
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "Dataset1";
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(338, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Năm";
            // 
            // txtMaBTL
            // 
            this.txtMaBTL.Location = new System.Drawing.Point(171, 3);
            this.txtMaBTL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaBTL.Name = "txtMaBTL";
            this.txtMaBTL.Size = new System.Drawing.Size(159, 26);
            this.txtMaBTL.TabIndex = 10;
            // 
            // txtTenBTL
            // 
            this.txtTenBTL.Location = new System.Drawing.Point(171, 57);
            this.txtTenBTL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenBTL.Name = "txtTenBTL";
            this.txtTenBTL.Size = new System.Drawing.Size(159, 26);
            this.txtTenBTL.TabIndex = 9;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(505, 3);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(161, 26);
            this.txtNam.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(0, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(682, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 134);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 49);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(181, 26);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // dgvBTL
            // 
            this.dgvBTL.AutoGenerateColumns = false;
            this.dgvBTL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBTL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBTL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBTL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBTL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBTLDataGridViewTextBoxColumn,
            this.tenBTLDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.maHPDataGridViewTextBoxColumn});
            this.dgvBTL.DataSource = this.tblBTLBindingSource;
            this.dgvBTL.Location = new System.Drawing.Point(0, 140);
            this.dgvBTL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvBTL.Name = "dgvBTL";
            this.dgvBTL.Size = new System.Drawing.Size(892, 168);
            this.dgvBTL.TabIndex = 80;
            // 
            // maBTLDataGridViewTextBoxColumn
            // 
            this.maBTLDataGridViewTextBoxColumn.DataPropertyName = "MaBTL";
            this.maBTLDataGridViewTextBoxColumn.HeaderText = "Mã bài tập lớn";
            this.maBTLDataGridViewTextBoxColumn.Name = "maBTLDataGridViewTextBoxColumn";
            // 
            // tenBTLDataGridViewTextBoxColumn
            // 
            this.tenBTLDataGridViewTextBoxColumn.DataPropertyName = "TenBTL";
            this.tenBTLDataGridViewTextBoxColumn.HeaderText = "Tên bài tập lớn";
            this.tenBTLDataGridViewTextBoxColumn.Name = "tenBTLDataGridViewTextBoxColumn";
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.DataPropertyName = "Nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Năm";
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            // 
            // maHPDataGridViewTextBoxColumn
            // 
            this.maHPDataGridViewTextBoxColumn.DataPropertyName = "MaHP";
            this.maHPDataGridViewTextBoxColumn.HeaderText = "Mã học phần";
            this.maHPDataGridViewTextBoxColumn.Name = "maHPDataGridViewTextBoxColumn";
            // 
            // tblBTLBindingSource
            // 
            this.tblBTLBindingSource.DataMember = "tblBTL";
            this.tblBTLBindingSource.DataSource = this.dataset11;
            // 
            // bntThem
            // 
            this.bntThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntThem.Image = global::FormQuanLyBTL.Properties.Resources.add_16;
            this.bntThem.Location = new System.Drawing.Point(3, 3);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(93, 26);
            this.bntThem.TabIndex = 81;
            this.bntThem.Text = "Thêm";
            this.bntThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntSua
            // 
            this.bntSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.bntSua.Image = global::FormQuanLyBTL.Properties.Resources.pencil;
            this.bntSua.Location = new System.Drawing.Point(102, 3);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(93, 26);
            this.bntSua.TabIndex = 82;
            this.bntSua.Text = "Sửa ";
            this.bntSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.bntXoa.Image = global::FormQuanLyBTL.Properties.Resources.cancel_16;
            this.bntXoa.Location = new System.Drawing.Point(201, 3);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(93, 26);
            this.bntXoa.TabIndex = 83;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntSavesua
            // 
            this.bntSavesua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntSavesua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.bntSavesua.Image = global::FormQuanLyBTL.Properties.Resources.save16;
            this.bntSavesua.Location = new System.Drawing.Point(399, 3);
            this.bntSavesua.Name = "bntSavesua";
            this.bntSavesua.Size = new System.Drawing.Size(93, 26);
            this.bntSavesua.TabIndex = 86;
            this.bntSavesua.Text = "Lưu";
            this.bntSavesua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntSavesua.UseVisualStyleBackColor = true;
            this.bntSavesua.Click += new System.EventHandler(this.bntSavesua_Click);
            // 
            // bntReset
            // 
            this.bntReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.bntReset.Image = global::FormQuanLyBTL.Properties.Resources.arrow_refresh_small;
            this.bntReset.Location = new System.Drawing.Point(498, 3);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(93, 26);
            this.bntReset.TabIndex = 87;
            this.bntReset.Text = "Reset";
            this.bntReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // bntHome
            // 
            this.bntHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.bntHome.Image = global::FormQuanLyBTL.Properties.Resources.application_home;
            this.bntHome.Location = new System.Drawing.Point(597, 3);
            this.bntHome.Name = "bntHome";
            this.bntHome.Size = new System.Drawing.Size(93, 26);
            this.bntHome.TabIndex = 88;
            this.bntHome.Text = "Home";
            this.bntHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntHome.UseVisualStyleBackColor = true;
            this.bntHome.Click += new System.EventHandler(this.bntHome_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.bntThoat.Image = global::FormQuanLyBTL.Properties.Resources.Exit_2_2;
            this.bntThoat.Location = new System.Drawing.Point(795, 3);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(94, 26);
            this.bntThoat.TabIndex = 89;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Controls.Add(this.bntHome, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.bntReset, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.bntThoat, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.bntSavesua, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.bntXoa, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bntThem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bntSua, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 314);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(892, 32);
            this.tableLayoutPanel1.TabIndex = 90;
            // 
            // tblBTLTableAdapter1
            // 
            this.tblBTLTableAdapter1.ClearBeforeFill = true;
            // 
            // tblHPTableAdapter1
            // 
            this.tblHPTableAdapter1.ClearBeforeFill = true;
            // 
            // frmBTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(892, 346);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvBTL);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBTL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THÔNG TIN BÀI TẬP LỚN";
            this.Load += new System.EventHandler(this.frmBTL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBTLBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxMaHP;
        private System.Windows.Forms.TextBox txtMaBTL;
        private System.Windows.Forms.TextBox txtTenBTL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvBTL;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntSavesua;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Button bntHome;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Dataset1 dataset11;
        private Dataset1TableAdapters.tblBTLTableAdapter tblBTLTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenBTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblBTLBindingSource;
        private Dataset1TableAdapters.tblHPTableAdapter tblHPTableAdapter1;
        private System.Windows.Forms.BindingSource tblHPBindingSource;
    }
}