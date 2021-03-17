namespace FormQuanLyBTL
{
    partial class frmHOCPHAN
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bntHome = new System.Windows.Forms.Button();
            this.bntReset = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntSavesua = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset1 = new FormQuanLyBTL.Dataset1();
            this.tblHPTableAdapter = new FormQuanLyBTL.Dataset1TableAdapters.tblHPTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset1)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 333);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 32);
            this.tableLayoutPanel1.TabIndex = 96;
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
            this.bntThoat.Size = new System.Drawing.Size(96, 26);
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
            this.bntThem.Image = global::FormQuanLyBTL.Properties.Resources.add_16;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 134);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học phần";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.txtsl, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtten, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtma, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(661, 109);
            this.tableLayoutPanel2.TabIndex = 114;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(499, 3);
            this.txtsl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(158, 26);
            this.txtsl.TabIndex = 6;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(136, 57);
            this.txtten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(186, 26);
            this.txtten.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(334, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số tín chỉ";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(136, 3);
            this.txtma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(186, 26);
            this.txtma.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên học phần";
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
            this.groupBox2.Location = new System.Drawing.Point(673, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 134);
            this.groupBox2.TabIndex = 98;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHPDataGridViewTextBoxColumn,
            this.tenHPDataGridViewTextBoxColumn,
            this.soTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblHPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(886, 189);
            this.dataGridView1.TabIndex = 113;
            // 
            // maHPDataGridViewTextBoxColumn
            // 
            this.maHPDataGridViewTextBoxColumn.DataPropertyName = "MaHP";
            this.maHPDataGridViewTextBoxColumn.HeaderText = "Mã học phần";
            this.maHPDataGridViewTextBoxColumn.Name = "maHPDataGridViewTextBoxColumn";
            // 
            // tenHPDataGridViewTextBoxColumn
            // 
            this.tenHPDataGridViewTextBoxColumn.DataPropertyName = "TenHP";
            this.tenHPDataGridViewTextBoxColumn.HeaderText = "Tên học phần";
            this.tenHPDataGridViewTextBoxColumn.Name = "tenHPDataGridViewTextBoxColumn";
            // 
            // soTDataGridViewTextBoxColumn
            // 
            this.soTDataGridViewTextBoxColumn.DataPropertyName = "SoT";
            this.soTDataGridViewTextBoxColumn.HeaderText = "Số tín chỉ";
            this.soTDataGridViewTextBoxColumn.Name = "soTDataGridViewTextBoxColumn";
            // 
            // tblHPBindingSource
            // 
            this.tblHPBindingSource.DataMember = "tblHP";
            this.tblHPBindingSource.DataSource = this.dataset1;
            // 
            // dataset1
            // 
            this.dataset1.DataSetName = "Dataset1";
            this.dataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHPTableAdapter
            // 
            this.tblHPTableAdapter.ClearBeforeFill = true;
            // 
            // frmHOCPHAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 365);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmHOCPHAN";
            this.Text = "Quản lý thông tin học phần";
            this.Load += new System.EventHandler(this.frmHOCPHAN_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bntHome;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntSavesua;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Dataset1 dataset1;
        private System.Windows.Forms.BindingSource tblHPBindingSource;
        private Dataset1TableAdapters.tblHPTableAdapter tblHPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTDataGridViewTextBoxColumn;
    }
}