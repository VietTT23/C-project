using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lopdata;

namespace FormQuanLyBTL
{
    public partial class frmSINHVIEN : Form
    {
        SV ctpn = new SV();
        public static string quyen;
        loginTableAdapters.QueriesTableAdapter dn = new loginTableAdapters.QueriesTableAdapter();

        public frmSINHVIEN()
        {
            InitializeComponent();
        }

        private void frmSINHVIEN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset1.tblLop' table. You can move, or remove it, as needed.
            this.tblLopTableAdapter.Fill(this.dataset1.tblLop);
            // TODO: This line of code loads data into the 'dataset1.tblSV' table. You can move, or remove it, as needed.
            this.tblSVTableAdapter.Fill(this.dataset1.tblSV);

            binding();

            txtma.ReadOnly = true;
            txtten.ReadOnly = true;
            txtem.ReadOnly = true;
            txtnam.ReadOnly = true;
            txtdt.ReadOnly = true;
            //cbmalop.Enabled = false;

            bntSavesua.Enabled = false;

            //Kiểm tra quyền tìm
            if (dn.CheckTim(quyen, true) == 1)
            {
                txtT.ReadOnly = false;
            }
            else
            {
                txtT.ReadOnly = true;
            }

            //Kiểm tra quyền xóa
            if (dn.CheckXoa(quyen, true) == 1)
            {
                bntXoa.Enabled = true;
            }
            else
            {
                bntXoa.Enabled = false;
            }

            //Kiểm tra quyền thêm
            if (dn.CheckThem(quyen, true) == 1)
            {
                bntThem.Enabled = true;

                txtma.ReadOnly = false;
                txtten.ReadOnly = false;
                txtem.ReadOnly = false;
                txtnam.ReadOnly = false;
                txtdt.ReadOnly = false;
                //cbmalop.Enabled = true;
            }
            else
            {
                bntThem.Enabled = false;
            }

            //Kiểm tra quyền sửa
            if (dn.CheckSua(quyen, true) == 1)
            {
                bntSua.Enabled = true;
            }
            else
            {
                bntSua.Enabled = false;
            }
        }

        public void binding()
        {
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("text", dataGridView1.DataSource, "MaSV");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("text", dataGridView1.DataSource, "TenSV");
            txtnam.DataBindings.Clear();
            txtnam.DataBindings.Add("text", dataGridView1.DataSource, "NamSinh");
            cbmalop.DataBindings.Clear();
            cbmalop.DataBindings.Add("text", dataGridView1.DataSource, "MaLop");
            txtem.DataBindings.Clear();
            txtem.DataBindings.Add("text", dataGridView1.DataSource, "Email");
            txtdt.DataBindings.Clear();
            txtdt.DataBindings.Add("text", dataGridView1.DataSource, "SDT");

        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (this.txtma.TextLength == 0)
            {
                MessageBox.Show("Mã không được để trống");
                this.txtma.Focus();
            }
            else if (this.txtten.TextLength == 0)
            {
                MessageBox.Show("Tên không được để trống");
                this.txtten.Focus();
            }
            else if (this.txtnam.TextLength == 0)
            {
                MessageBox.Show("Năm không được để trống");
                this.txtnam.Focus();
            }
            else if (this.txtem.TextLength == 0)
            {
                MessageBox.Show("Email không được để trống");
                this.txtem.Focus();
            }
            else if (this.txtdt.TextLength == 0)
            {
                MessageBox.Show("Điện thoại không được để trống");
                this.txtdt.Focus();
            }
            else
            {
                try
                {
                    ctpn.Insertsv(txtma.Text, txtten.Text, txtnam.Text, txtem.Text, txtdt.Text, cbmalop.SelectedValue.ToString());
                    MessageBox.Show("Đã thêm dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmSINHVIEN_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã dự án " + this.txtma.Text + " đã tồn tại");
                }
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (dn.CheckSua(quyen, true) == 1)
            {
                bntSavesua.Enabled = true;

                txtma.ReadOnly = false;
                txtten.ReadOnly = false;
                txtem.ReadOnly = false;
                txtnam.ReadOnly = false;
                txtdt.ReadOnly = false;
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            ctpn.Deletesv(txtma.Text);
            frmSINHVIEN_Load(sender, e);
        }

        private void bntSavesua_Click(object sender, EventArgs e)
        {
            if (this.txtma.TextLength == 0)
            {
                MessageBox.Show("Mã không được để trống");
                this.txtma.Focus();
            }
            else if (this.txtten.TextLength == 0)
            {
                MessageBox.Show("Tên không được để trống");
                this.txtten.Focus();
            }
            else if (this.txtnam.TextLength == 0)
            {
                MessageBox.Show("Năm không được để trống");
                this.txtnam.Focus();
            }
            else if (this.txtem.TextLength == 0)
            {
                MessageBox.Show("Email không được để trống");
                this.txtem.Focus();
            }
            else if (this.txtdt.TextLength == 0)
            {
                MessageBox.Show("Điện thoại không được để trống");
                this.txtdt.Focus();
            }
            else
            {
                try
                {
                    ctpn.Updatesv(txtma.Text, txtten.Text, txtnam.Text, txtem.Text, txtdt.Text, cbmalop.SelectedValue.ToString());
                    MessageBox.Show("Đã sửa dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmSINHVIEN_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã dự án " + this.txtma.Text + " đã tồn tại");
                }
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            frmSINHVIEN_Load(sender, e);
        }

        private void bntHome_Click(object sender, EventArgs e)
        {
            frmMain home = new frmMain();
            home.Show();
            this.Close();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Dispose();
        }

        private void txtT_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ctpn.Timsv(txtT.Text);
            dataGridView1.DataSource = dt;
            binding();
        }
    }
}
