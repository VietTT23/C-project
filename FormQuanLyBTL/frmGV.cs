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
    public partial class frmGV : Form
    {
        //tạo biến thuộc lớp GV
        GV ctpn = new GV();
        public static string quyen;
        loginTableAdapters.QueriesTableAdapter dn = new loginTableAdapters.QueriesTableAdapter();

        public frmGV()
        {
            InitializeComponent();
        }

        private void frmGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset1.tblGV' table. You can move, or remove it, as needed.
            this.tblGVTableAdapter.Fill(this.dataset1.tblGV);

            binding();
            
            txtten.ReadOnly = true;
            txtma.ReadOnly = true;
            txtto.ReadOnly = true;
            txtem.ReadOnly = true;
            txtdt.ReadOnly = true;
            txthv.ReadOnly = true;
            
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

                txtten.ReadOnly = false;
                txtma.ReadOnly = false;
                txtto.ReadOnly = false;
                txtem.ReadOnly = false;
                txtdt.ReadOnly = false;
                txthv.ReadOnly = false;
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
            txtma.DataBindings.Add("text", dataGridView1.DataSource, "MaGV");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("text", dataGridView1.DataSource, "TenGV");
            txtto.DataBindings.Clear();
            txtto.DataBindings.Add("text", dataGridView1.DataSource, "TTo");

            txtem.DataBindings.Clear();
            txtem.DataBindings.Add("text", dataGridView1.DataSource, "Email");
            txtdt.DataBindings.Clear();
            txtdt.DataBindings.Add("text", dataGridView1.DataSource, "SDT");
            txthv.DataBindings.Clear();
            txthv.DataBindings.Add("text", dataGridView1.DataSource, "HocVi");

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
            else if (this.txtto.TextLength == 0)
            {
                MessageBox.Show("Tổ không được để trống");
                this.txtto.Focus();
            }
            else
            {
                try
                {
                    ctpn.InsertGiaoVien(txtma.Text, txtten.Text, txtem.Text, txtdt.Text, txtto.Text, txthv.Text);
                    MessageBox.Show("Đã thêm dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmGV_Load(sender, e);


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

                txtten.ReadOnly = false;
                txtma.ReadOnly = false;
                txtto.ReadOnly = false;
                txtem.ReadOnly = false;
                txtdt.ReadOnly = false;
                txthv.ReadOnly = false;
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            ctpn.XoaGV(txtma.Text);
            frmGV_Load(sender, e);
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
            else if (this.txtto.TextLength == 0)
            {
                MessageBox.Show("Tổ không được để trống");
                this.txtto.Focus();
            }
            else
            {
                try
                {
                    ctpn.SuaGV(txtma.Text, txtten.Text, txtem.Text, txtdt.Text, txtto.Text, txthv.Text);
                    MessageBox.Show("Đã sửa dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmGV_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã " + this.txtma.Text + " đã tồn tại");
                }
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            frmGV_Load(sender, e);
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
            dt = ctpn.TimGV(txtT.Text);
            dataGridView1.DataSource = dt;
            binding();
        }
    }
}
