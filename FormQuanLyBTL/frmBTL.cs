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
    public partial class frmBTL : Form
    {
        //Tạo biến thuộc lớp BTL
        BTL1 btl = new BTL1();
        public static string quyen;
        loginTableAdapters.QueriesTableAdapter dn = new loginTableAdapters.QueriesTableAdapter();

        public frmBTL()
        {
            InitializeComponent();
        }

        private void frmBTL_Load(object sender, EventArgs e)
        {
            this.tblHPTableAdapter1.Fill(this.dataset11.tblHP);
            this.tblBTLTableAdapter1.Fill(this.dataset11.tblBTL);

            binding();

            txtTenBTL.ReadOnly = true;
            txtMaBTL.ReadOnly = true;
            txtNam.ReadOnly = true;

            bntSavesua.Enabled = false;

            //Kiểm tra quyền tìm
            if (dn.CheckTim(quyen, true) == 1)
            {
                txtTimKiem.ReadOnly = false;
            }
            else
            {
                txtTimKiem.ReadOnly = true;
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

                txtNam.ReadOnly = false;
                txtTenBTL.ReadOnly = false;
                txtMaBTL.ReadOnly = false;
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
            txtMaBTL.DataBindings.Clear();
            txtMaBTL.DataBindings.Add("text", dgvBTL.DataSource, "MaBTL");
            txtTenBTL.DataBindings.Clear();
            txtTenBTL.DataBindings.Add("text", dgvBTL.DataSource, "TenBTL");
            txtNam.DataBindings.Clear();
            txtNam.DataBindings.Add("text", dgvBTL.DataSource, "Nam");
            cbxMaHP.DataBindings.Clear();
            cbxMaHP.DataBindings.Add("text", dgvBTL.DataSource, "MaHP");
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (this.txtMaBTL.TextLength == 0)
            {
                MessageBox.Show("Mã không được để trống");
                this.txtMaBTL.Focus();
            }
            else if (this.txtTenBTL.TextLength == 0)
            {
                MessageBox.Show("Tên không được để trống");
                this.txtTenBTL.Focus();
            }
            else if (this.txtNam.TextLength == 0)
            {
                MessageBox.Show("Năm không được để trống");
                this.txtNam.Focus();
            }
            else
            {
                try
                {
                    btl.InsertBTL(txtMaBTL.Text, txtTenBTL.Text, txtNam.Text, cbxMaHP.SelectedValue.ToString());
                    MessageBox.Show("Đã thêm dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmBTL_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã " + this.txtMaBTL.Text + " đã tồn tại");
                }
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = btl.TimBTL(txtTimKiem.Text);
            dgvBTL.DataSource = dt;
            binding();
        }

        private void bntSavesua_Click(object sender, EventArgs e)
        {
            if (this.txtMaBTL.TextLength == 0)
            {
                MessageBox.Show("Mã không được để trống");
                this.txtMaBTL.Focus();
            }
            else if (this.txtTenBTL.TextLength == 0)
            {
                MessageBox.Show("Tên không được để trống");
                this.txtTenBTL.Focus();
            }
            else if (this.txtNam.TextLength == 0)
            {
                MessageBox.Show("Năm không được để trống");
                this.txtNam.Focus();
            }
            else
            {
                try
                {
                    btl.SuaBTL(this.txtMaBTL.Text, this.txtTenBTL.Text, txtNam.Text, cbxMaHP.SelectedValue.ToString());
                    MessageBox.Show("Đã sửa dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmBTL_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã dự án " + this.txtMaBTL.Text + " đã tồn tại");
                }
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (dn.CheckSua(quyen, true) == 1)
            {
                bntSavesua.Enabled = true;

                txtTenBTL.ReadOnly = false;
                txtMaBTL.ReadOnly = false;
                txtNam.ReadOnly = false;
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            frmBTL_Load(sender, e);
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            btl.XoaBTL(txtMaBTL.Text);
            frmBTL_Load(sender, e);
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

    }
}
