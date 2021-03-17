namespace FormQuanLyBTL
{
    partial class frmTK
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntHome = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkT = new System.Windows.Forms.CheckBox();
            this.chkS = new System.Windows.Forms.CheckBox();
            this.chkIn = new System.Windows.Forms.CheckBox();
            this.chkTim = new System.Windows.Forms.CheckBox();
            this.chkX = new System.Windows.Forms.CheckBox();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.tblTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataset1 = new FormQuanLyBTL.Dataset1();
            this.tblTaiKhoanTableAdapter = new FormQuanLyBTL.Dataset1TableAdapters.tblTaiKhoanTableAdapter();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qThemDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qSuaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qXoaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qInDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qTimDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.bntThoat);
            this.groupBox2.Controls.Add(this.bntXoa);
            this.groupBox2.Controls.Add(this.bntHome);
            this.groupBox2.Controls.Add(this.bntThem);
            this.groupBox2.Controls.Add(this.txtTK);
            this.groupBox2.Controls.Add(this.txtMK);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(489, 107);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // bntThoat
            // 
            this.bntThoat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bntThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntThoat.Image = global::FormQuanLyBTL.Properties.Resources.Exit_2_2;
            this.bntThoat.Location = new System.Drawing.Point(407, 57);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 29);
            this.bntThoat.TabIndex = 7;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntThoat.UseVisualStyleBackColor = false;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bntXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntXoa.Image = global::FormQuanLyBTL.Properties.Resources.cancel_16;
            this.bntXoa.Location = new System.Drawing.Point(407, 22);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 29);
            this.bntXoa.TabIndex = 6;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntXoa.UseVisualStyleBackColor = false;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntHome
            // 
            this.bntHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bntHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntHome.Image = global::FormQuanLyBTL.Properties.Resources.application_home;
            this.bntHome.Location = new System.Drawing.Point(275, 57);
            this.bntHome.Name = "bntHome";
            this.bntHome.Size = new System.Drawing.Size(117, 29);
            this.bntHome.TabIndex = 5;
            this.bntHome.Text = "Home";
            this.bntHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntHome.UseVisualStyleBackColor = false;
            this.bntHome.Click += new System.EventHandler(this.bntHome_Click);
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bntThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntThem.Image = global::FormQuanLyBTL.Properties.Resources.add_16;
            this.bntThem.Location = new System.Drawing.Point(275, 22);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(117, 29);
            this.bntThem.TabIndex = 4;
            this.bntThem.Text = "Thêm quyền";
            this.bntThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntThem.UseVisualStyleBackColor = false;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTK.Location = new System.Drawing.Point(107, 27);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(140, 22);
            this.txtTK.TabIndex = 3;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMK.Location = new System.Drawing.Point(107, 58);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(140, 22);
            this.txtMK.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.chkT);
            this.groupBox1.Controls.Add(this.chkS);
            this.groupBox1.Controls.Add(this.chkIn);
            this.groupBox1.Controls.Add(this.chkTim);
            this.groupBox1.Controls.Add(this.chkX);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(497, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(367, 107);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin quyền";
            // 
            // chkT
            // 
            this.chkT.AutoSize = true;
            this.chkT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkT.Location = new System.Drawing.Point(26, 33);
            this.chkT.Margin = new System.Windows.Forms.Padding(4);
            this.chkT.Name = "chkT";
            this.chkT.Size = new System.Drawing.Size(101, 23);
            this.chkT.TabIndex = 5;
            this.chkT.Text = "Quyền thêm";
            this.chkT.UseVisualStyleBackColor = true;
            // 
            // chkS
            // 
            this.chkS.AutoSize = true;
            this.chkS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkS.ForeColor = System.Drawing.Color.Green;
            this.chkS.Location = new System.Drawing.Point(26, 71);
            this.chkS.Margin = new System.Windows.Forms.Padding(4);
            this.chkS.Name = "chkS";
            this.chkS.Size = new System.Drawing.Size(94, 23);
            this.chkS.TabIndex = 7;
            this.chkS.Text = "Quyền sửa";
            this.chkS.UseVisualStyleBackColor = true;
            // 
            // chkIn
            // 
            this.chkIn.AutoSize = true;
            this.chkIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkIn.Location = new System.Drawing.Point(272, 33);
            this.chkIn.Margin = new System.Windows.Forms.Padding(4);
            this.chkIn.Name = "chkIn";
            this.chkIn.Size = new System.Drawing.Size(84, 23);
            this.chkIn.TabIndex = 6;
            this.chkIn.Text = "Quyền In";
            this.chkIn.UseVisualStyleBackColor = true;
            // 
            // chkTim
            // 
            this.chkTim.AutoSize = true;
            this.chkTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkTim.Location = new System.Drawing.Point(152, 33);
            this.chkTim.Margin = new System.Windows.Forms.Padding(4);
            this.chkTim.Name = "chkTim";
            this.chkTim.Size = new System.Drawing.Size(95, 23);
            this.chkTim.TabIndex = 6;
            this.chkTim.Text = "Quyền Tìm";
            this.chkTim.UseVisualStyleBackColor = true;
            // 
            // chkX
            // 
            this.chkX.AutoSize = true;
            this.chkX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkX.Location = new System.Drawing.Point(152, 71);
            this.chkX.Margin = new System.Windows.Forms.Padding(4);
            this.chkX.Name = "chkX";
            this.chkX.Size = new System.Drawing.Size(94, 23);
            this.chkX.TabIndex = 6;
            this.chkX.Text = "Quyền xóa";
            this.chkX.UseVisualStyleBackColor = true;
            // 
            // dgvTK
            // 
            this.dgvTK.AutoGenerateColumns = false;
            this.dgvTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.qThemDataGridViewCheckBoxColumn,
            this.qSuaDataGridViewCheckBoxColumn,
            this.qXoaDataGridViewCheckBoxColumn,
            this.qInDataGridViewCheckBoxColumn,
            this.qTimDataGridViewCheckBoxColumn});
            this.dgvTK.DataSource = this.tblTaiKhoanBindingSource;
            this.dgvTK.Location = new System.Drawing.Point(0, 114);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.Size = new System.Drawing.Size(864, 146);
            this.dgvTK.TabIndex = 26;
            // 
            // tblTaiKhoanBindingSource
            // 
            this.tblTaiKhoanBindingSource.DataMember = "tblTaiKhoan";
            this.tblTaiKhoanBindingSource.DataSource = this.dataset1;
            // 
            // dataset1
            // 
            this.dataset1.DataSetName = "Dataset1";
            this.dataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTaiKhoanTableAdapter
            // 
            this.tblTaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tài khoản";
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passDataGridViewTextBoxColumn.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "Pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // qThemDataGridViewCheckBoxColumn
            // 
            this.qThemDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qThemDataGridViewCheckBoxColumn.DataPropertyName = "QThem";
            this.qThemDataGridViewCheckBoxColumn.HeaderText = "Quyền Thêm";
            this.qThemDataGridViewCheckBoxColumn.Name = "qThemDataGridViewCheckBoxColumn";
            // 
            // qSuaDataGridViewCheckBoxColumn
            // 
            this.qSuaDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qSuaDataGridViewCheckBoxColumn.DataPropertyName = "QSua";
            this.qSuaDataGridViewCheckBoxColumn.HeaderText = "Quyền Sửa";
            this.qSuaDataGridViewCheckBoxColumn.Name = "qSuaDataGridViewCheckBoxColumn";
            // 
            // qXoaDataGridViewCheckBoxColumn
            // 
            this.qXoaDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qXoaDataGridViewCheckBoxColumn.DataPropertyName = "QXoa";
            this.qXoaDataGridViewCheckBoxColumn.HeaderText = "Quyền Xóa";
            this.qXoaDataGridViewCheckBoxColumn.Name = "qXoaDataGridViewCheckBoxColumn";
            // 
            // qInDataGridViewCheckBoxColumn
            // 
            this.qInDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qInDataGridViewCheckBoxColumn.DataPropertyName = "QIn";
            this.qInDataGridViewCheckBoxColumn.HeaderText = "Quyền In";
            this.qInDataGridViewCheckBoxColumn.Name = "qInDataGridViewCheckBoxColumn";
            // 
            // qTimDataGridViewCheckBoxColumn
            // 
            this.qTimDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qTimDataGridViewCheckBoxColumn.DataPropertyName = "QTim";
            this.qTimDataGridViewCheckBoxColumn.HeaderText = "Quyền Tìm";
            this.qTimDataGridViewCheckBoxColumn.Name = "qTimDataGridViewCheckBoxColumn";
            // 
            // frmTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 264);
            this.Controls.Add(this.dgvTK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frmTK_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataset1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntHome;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkT;
        private System.Windows.Forms.CheckBox chkS;
        private System.Windows.Forms.CheckBox chkIn;
        private System.Windows.Forms.CheckBox chkTim;
        private System.Windows.Forms.CheckBox chkX;
        private System.Windows.Forms.DataGridView dgvTK;
        private Dataset1 dataset1;
        private System.Windows.Forms.BindingSource tblTaiKhoanBindingSource;
        private Dataset1TableAdapters.tblTaiKhoanTableAdapter tblTaiKhoanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn qThemDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn qSuaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn qXoaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn qInDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn qTimDataGridViewCheckBoxColumn;
    }
}