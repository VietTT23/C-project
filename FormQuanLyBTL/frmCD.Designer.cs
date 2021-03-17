namespace FormQuanLyBTL
{
    partial class frmCD
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
            this.cbmahd = new System.Windows.Forms.ComboBox();
            this.tblHoiDongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset1 = new FormQuanLyBTL.Dataset1();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.dgvCD = new System.Windows.Forms.DataGridView();
            this.maCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHoiDongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bntHome = new System.Windows.Forms.Button();
            this.bntReset = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntSavesua = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.tblCDTableAdapter = new FormQuanLyBTL.Dataset1TableAdapters.tblCDTableAdapter();
            this.tblHoiDongTableAdapter = new FormQuanLyBTL.Dataset1TableAdapters.tblHoiDongTableAdapter();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoiDongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCDBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 134);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chuyên đề thực tập";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.cbmahd, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtten, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtnam, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtma, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(660, 109);
            this.tableLayoutPanel2.TabIndex = 94;
            // 
            // cbmahd
            // 
            this.cbmahd.DataSource = this.tblHoiDongBindingSource;
            this.cbmahd.DisplayMember = "MaHoiDong";
            this.cbmahd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmahd.FormattingEnabled = true;
            this.cbmahd.Location = new System.Drawing.Point(498, 57);
            this.cbmahd.Name = "cbmahd";
            this.cbmahd.Size = new System.Drawing.Size(159, 27);
            this.cbmahd.TabIndex = 11;
            this.cbmahd.ValueMember = "MaHoiDong";
            // 
            // tblHoiDongBindingSource
            // 
            this.tblHoiDongBindingSource.DataMember = "tblHoiDong";
            this.tblHoiDongBindingSource.DataSource = this.dataset1;
            // 
            // dataset1
            // 
            this.dataset1.DataSetName = "Dataset1";
            this.dataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(169, 57);
            this.txtten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(157, 26);
            this.txtten.TabIndex = 9;
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(499, 3);
            this.txtnam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(157, 26);
            this.txtnam.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(334, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã hội đồng";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(169, 3);
            this.txtma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(157, 26);
            this.txtma.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã chuyên đề";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(334, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên chuyên đề";
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
            this.groupBox2.Controls.Add(this.txtT);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(672, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 134);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin tìm kiếm";
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(6, 49);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(181, 26);
            this.txtT.TabIndex = 0;
            this.txtT.TextChanged += new System.EventHandler(this.txtT_TextChanged);
            // 
            // dgvCD
            // 
            this.dgvCD.AutoGenerateColumns = false;
            this.dgvCD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCDDataGridViewTextBoxColumn,
            this.tenCDDataGridViewTextBoxColumn,
            this.namDataGridViewTextBoxColumn,
            this.maHoiDongDataGridViewTextBoxColumn});
            this.dgvCD.DataSource = this.tblCDBindingSource;
            this.dgvCD.Location = new System.Drawing.Point(0, 142);
            this.dgvCD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCD.Name = "dgvCD";
            this.dgvCD.Size = new System.Drawing.Size(882, 172);
            this.dgvCD.TabIndex = 69;
            // 
            // maCDDataGridViewTextBoxColumn
            // 
            this.maCDDataGridViewTextBoxColumn.DataPropertyName = "MaCD";
            this.maCDDataGridViewTextBoxColumn.HeaderText = "Mã chuyên đề";
            this.maCDDataGridViewTextBoxColumn.Name = "maCDDataGridViewTextBoxColumn";
            // 
            // tenCDDataGridViewTextBoxColumn
            // 
            this.tenCDDataGridViewTextBoxColumn.DataPropertyName = "TenCD";
            this.tenCDDataGridViewTextBoxColumn.HeaderText = "Tên chuyên đề";
            this.tenCDDataGridViewTextBoxColumn.Name = "tenCDDataGridViewTextBoxColumn";
            // 
            // namDataGridViewTextBoxColumn
            // 
            this.namDataGridViewTextBoxColumn.DataPropertyName = "Nam";
            this.namDataGridViewTextBoxColumn.HeaderText = "Năm";
            this.namDataGridViewTextBoxColumn.Name = "namDataGridViewTextBoxColumn";
            // 
            // maHoiDongDataGridViewTextBoxColumn
            // 
            this.maHoiDongDataGridViewTextBoxColumn.DataPropertyName = "MaHoiDong";
            this.maHoiDongDataGridViewTextBoxColumn.HeaderText = "Mã hội đồng";
            this.maHoiDongDataGridViewTextBoxColumn.Name = "maHoiDongDataGridViewTextBoxColumn";
            // 
            // tblCDBindingSource
            // 
            this.tblCDBindingSource.DataMember = "tblCD";
            this.tblCDBindingSource.DataSource = this.dataset1;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 320);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 32);
            this.tableLayoutPanel1.TabIndex = 93;
            // 
            // bntHome
            // 
            this.bntHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.bntHome.Image = global::FormQuanLyBTL.Properties.Resources.application_home;
            this.bntHome.Location = new System.Drawing.Point(591, 3);
            this.bntHome.Name = "bntHome";
            this.bntHome.Size = new System.Drawing.Size(92, 26);
            this.bntHome.TabIndex = 88;
            this.bntHome.Text = "Home";
            this.bntHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntHome.UseVisualStyleBackColor = true;
            this.bntHome.Click += new System.EventHandler(this.bntHome_Click);
            // 
            // bntReset
            // 
            this.bntReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.bntReset.Image = global::FormQuanLyBTL.Properties.Resources.arrow_refresh_small;
            this.bntReset.Location = new System.Drawing.Point(493, 3);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(92, 26);
            this.bntReset.TabIndex = 87;
            this.bntReset.Text = "Reset";
            this.bntReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntThoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.bntThoat.Image = global::FormQuanLyBTL.Properties.Resources.Exit_2_2;
            this.bntThoat.Location = new System.Drawing.Point(787, 3);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(92, 26);
            this.bntThoat.TabIndex = 89;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntSavesua
            // 
            this.bntSavesua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntSavesua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.bntSavesua.Image = global::FormQuanLyBTL.Properties.Resources.save16;
            this.bntSavesua.Location = new System.Drawing.Point(395, 3);
            this.bntSavesua.Name = "bntSavesua";
            this.bntSavesua.Size = new System.Drawing.Size(92, 26);
            this.bntSavesua.TabIndex = 86;
            this.bntSavesua.Text = "Lưu";
            this.bntSavesua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntSavesua.UseVisualStyleBackColor = true;
            this.bntSavesua.Click += new System.EventHandler(this.bntSavesua_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.bntXoa.Image = global::FormQuanLyBTL.Properties.Resources.cancel_16;
            this.bntXoa.Location = new System.Drawing.Point(199, 3);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(92, 26);
            this.bntXoa.TabIndex = 83;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntThem
            // 
            this.bntThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bntThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntThem.Image = global::FormQuanLyBTL.Properties.Resources.add_161;
            this.bntThem.Location = new System.Drawing.Point(3, 3);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(92, 26);
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
            this.bntSua.Location = new System.Drawing.Point(101, 3);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(92, 26);
            this.bntSua.TabIndex = 82;
            this.bntSua.Text = "Sửa ";
            this.bntSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // tblCDTableAdapter
            // 
            this.tblCDTableAdapter.ClearBeforeFill = true;
            // 
            // tblHoiDongTableAdapter
            // 
            this.tblHoiDongTableAdapter.ClearBeforeFill = true;
            // 
            // frmCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(882, 352);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvCD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCD";
            this.Text = "QUẢN LÝ TT CHUYÊN ĐỀ";
            this.Load += new System.EventHandler(this.frmCD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHoiDongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCDBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbmahd;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.DataGridView dgvCD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bntHome;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntSavesua;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Dataset1 dataset1;
        private System.Windows.Forms.BindingSource tblCDBindingSource;
        private Dataset1TableAdapters.tblCDTableAdapter tblCDTableAdapter;
        private System.Windows.Forms.BindingSource tblHoiDongBindingSource;
        private Dataset1TableAdapters.tblHoiDongTableAdapter tblHoiDongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoiDongDataGridViewTextBoxColumn;
    }
}