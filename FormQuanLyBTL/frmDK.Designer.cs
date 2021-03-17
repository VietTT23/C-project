namespace FormQuanLyBTL
{
    partial class frmDK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntRF = new System.Windows.Forms.Button();
            this.bntDN = new System.Windows.Forms.Button();
            this.txtnl = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.bntThoat);
            this.groupBox1.Controls.Add(this.bntRF);
            this.groupBox1.Controls.Add(this.bntDN);
            this.groupBox1.Controls.Add(this.txtnl);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng ký tài khoản";
            // 
            // bntThoat
            // 
            this.bntThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntThoat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThoat.Image = global::FormQuanLyBTL.Properties.Resources._1395337265_exit_2;
            this.bntThoat.Location = new System.Drawing.Point(278, 155);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(98, 36);
            this.bntThoat.TabIndex = 16;
            this.bntThoat.Text = "Exit";
            this.bntThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntRF
            // 
            this.bntRF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRF.Image = global::FormQuanLyBTL.Properties.Resources.thuchien;
            this.bntRF.Location = new System.Drawing.Point(141, 155);
            this.bntRF.Name = "bntRF";
            this.bntRF.Size = new System.Drawing.Size(98, 36);
            this.bntRF.TabIndex = 15;
            this.bntRF.Text = "Reset";
            this.bntRF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntRF.UseVisualStyleBackColor = true;
            this.bntRF.Click += new System.EventHandler(this.bntRF_Click);
            // 
            // bntDN
            // 
            this.bntDN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDN.Image = global::FormQuanLyBTL.Properties.Resources.Profile;
            this.bntDN.Location = new System.Drawing.Point(10, 155);
            this.bntDN.Name = "bntDN";
            this.bntDN.Size = new System.Drawing.Size(98, 36);
            this.bntDN.TabIndex = 14;
            this.bntDN.Text = "Sign up";
            this.bntDN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntDN.UseVisualStyleBackColor = true;
            this.bntDN.Click += new System.EventHandler(this.bntDN_Click);
            // 
            // txtnl
            // 
            this.txtnl.Location = new System.Drawing.Point(200, 104);
            this.txtnl.Name = "txtnl";
            this.txtnl.PasswordChar = 'x';
            this.txtnl.Size = new System.Drawing.Size(153, 26);
            this.txtnl.TabIndex = 13;
            this.txtnl.UseSystemPasswordChar = true;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(200, 66);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = 'x';
            this.txtpass.Size = new System.Drawing.Size(153, 26);
            this.txtpass.TabIndex = 12;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(200, 32);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(153, 26);
            this.txtten.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FormQuanLyBTL.Properties.Resources.images__4_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(413, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 178);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(613, 203);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDK";
            this.Text = "THÔNG TIN ĐĂNG KÝ TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frmDK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnl;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button bntDN;
        private System.Windows.Forms.Button bntRF;
        private System.Windows.Forms.Button bntThoat;
    }
}