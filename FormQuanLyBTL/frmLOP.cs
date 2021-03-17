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
    public partial class frmLOP : Form
    {
        LOP ctpn = new LOP();
        public static string quyen;
        loginTableAdapters.QueriesTableAdapter dn = new loginTableAdapters.QueriesTableAdapter();

        public frmLOP()
        {
            InitializeComponent();
        }

        private void frmLOP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset1.tblLop' table. You can move, or remove it, as needed.
            this.tblLopTableAdapter.Fill(this.dataset1.tblLop);

            binding();

            txtten.ReadOnly = true;
            txtma.ReadOnly = true;
            txtkdt.ReadOnly = true;
            txtbdt.ReadOnly = true;
            txtsl.ReadOnly = true;
            
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
                
                txtsl.ReadOnly = false;
                txtkdt.ReadOnly = false;
                txtten.ReadOnly = false;
                txtma.ReadOnly = false;
                txtbdt.ReadOnly = false;
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
            txtma.DataBindings.Add("text", dataGridView1.DataSource, "MaLop");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("text", dataGridView1.DataSource, "TenLop");
            txtsl.DataBindings.Clear();
            txtsl.DataBindings.Add("text", dataGridView1.DataSource, "SoSV");
            txtkdt.DataBindings.Clear();
            txtkdt.DataBindings.Add("text", dataGridView1.DataSource, "KhoaDaoTao");
            txtbdt.DataBindings.Clear();
            txtbdt.DataBindings.Add("text", dataGridView1.DataSource, "BacDaoTao");

        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (this.txtma.TextLength == 0)
            {
                MessageBox.Show("Mã không được để trống");
                this.txtma.Focus();
            }
            else if (this.txtsl.TextLength == 0)
            {
                MessageBox.Show("Số lượng không được để trống");
                this.txtsl.Focus();
            }
            else if (this.txtten.TextLength == 0)
            {
                MessageBox.Show("Tên không được để trống");
                this.txtten.Focus();
            }
            else if (this.txtbdt.TextLength == 0)
            {
                MessageBox.Show("Bậc đào tạo không được để trống");
                this.txtbdt.Focus();
            }
            else if (this.txtkdt.TextLength == 0)
            {
                MessageBox.Show("Khóa đào tạo không được để trống");
                this.txtkdt.Focus();
            }
            else
            {
                try
                {
                    ctpn.ThemLop(this.txtma.Text, this.txtten.Text, int.Parse(this.txtsl.Text), this.txtkdt.Text, this.txtbdt.Text);
                    MessageBox.Show("Đã thêm dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLOP_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã " + this.txtma.Text + " đã tồn tại");
                }
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (dn.CheckSua(quyen, true) == 1)
            {
                bntSavesua.Enabled = true;

                txtsl.ReadOnly = false;
                txtkdt.ReadOnly = false;
                txtten.ReadOnly = false;
                txtma.ReadOnly = false;
                txtbdt.ReadOnly = false;
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            ctpn.XoaLop(txtma.Text);
            frmLOP_Load(sender, e);
        }

        private void bntSavesua_Click(object sender, EventArgs e)
        {
            if (this.txtma.TextLength == 0)
            {
                MessageBox.Show("Mã không được để trống");
                this.txtma.Focus();
            }
            else if (this.txtsl.TextLength == 0)
            {
                MessageBox.Show("Số lượng không được để trống");
                this.txtsl.Focus();
            }
            else if (this.txtten.TextLength == 0)
            {
                MessageBox.Show("Tên không được để trống");
                this.txtten.Focus();
            }
            else if (this.txtbdt.TextLength == 0)
            {
                MessageBox.Show("Bậc đào tạo không được để trống");
                this.txtbdt.Focus();
            }
            else if (this.txtkdt.TextLength == 0)
            {
                MessageBox.Show("Khóa đào tạo không được để trống");
                this.txtkdt.Focus();
            }
            else
            {
                try
                {
                    ctpn.SuaLop(this.txtma.Text, this.txtten.Text, int.Parse(this.txtsl.Text), this.txtkdt.Text, this.txtbdt.Text);
                    MessageBox.Show("Đã sửa dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLOP_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã " + this.txtma.Text + " đã tồn tại");
                }
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            frmLOP_Load(sender, e);
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
            dt = ctpn.timLop(txtT.Text);
            dataGridView1.DataSource = dt;
            binding();
        }
    }
}
