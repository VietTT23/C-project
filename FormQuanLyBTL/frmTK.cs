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
    public partial class frmTK : Form
    {
        Dangnhap dn = new Dangnhap();
        public frmTK()
        {
            InitializeComponent();
        }

        private void frmTK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset1.tblTaiKhoan' table. You can move, or remove it, as needed.
            this.tblTaiKhoanTableAdapter.Fill(this.dataset1.tblTaiKhoan);
            dgvTK.DataSource = dn.ShowDN();
            binding();
        }

        public void binding()
        {
            txtMK.DataBindings.Clear();
            txtMK.DataBindings.Add("Text", dgvTK.DataSource, "Pass");
            txtTK.DataBindings.Clear();
            txtTK.DataBindings.Add("Text", dgvTK.DataSource, "Ten");
            chkT.DataBindings.Clear();
            chkT.DataBindings.Add("Checked", dgvTK.DataSource, "QThem");
            chkS.DataBindings.Clear();
            chkS.DataBindings.Add("Checked", dgvTK.DataSource, "QSua");
            chkX.DataBindings.Clear();
            chkX.DataBindings.Add("Checked", dgvTK.DataSource, "QXoa");
            chkTim.DataBindings.Clear();
            chkTim.DataBindings.Add("Checked", dgvTK.DataSource, "QTim");
            chkIn.DataBindings.Clear();
            chkIn.DataBindings.Add("Checked", dgvTK.DataSource, "QIn");

        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "admin")
            {
                MessageBox.Show("Có lỗi !", "Lối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dn.InsertQuyen(txtTK.Text, chkT.Checked, chkS.Checked, chkX.Checked, chkIn.Checked, chkTim.Checked);
                MessageBox.Show("Bạn đã thêm quyền thành công cho các tài khoản");
                frmTK_Load(sender, e);
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "admin")
            {
                MessageBox.Show("Có lỗi không thể xóa !", "Lối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dn.Xoa(txtTK.Text);
                MessageBox.Show("Bạn đã xóa tài khoản thành công");
                frmTK_Load(sender, e);
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Dispose();
        }

        private void bntHome_Click(object sender, EventArgs e)
        {
            frmMain home = new frmMain();
            home.Show();
            this.Close();
        }
    }
}
