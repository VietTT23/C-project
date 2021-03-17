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
    public partial class frmHOCPHAN : Form
    {
        Hp ctpn = new Hp();
        public static string quyen;
        loginTableAdapters.QueriesTableAdapter dn = new loginTableAdapters.QueriesTableAdapter();

        public frmHOCPHAN()
        {
            InitializeComponent();
        }

        private void frmHOCPHAN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset1.tblHP' table. You can move, or remove it, as needed.
            this.tblHPTableAdapter.Fill(this.dataset1.tblHP);

            binding();

            txtten.ReadOnly = true;
            txtma.ReadOnly = true;
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
                txtten.ReadOnly = false;
                txtma.ReadOnly = false;
            }
            else
            {
                bntThem.Enabled = false;
            }

            //Kiêm tra quyền sửa
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
            txtma.DataBindings.Add("text", dataGridView1.DataSource, "MaHP");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("text", dataGridView1.DataSource, "TenHP");
            txtsl.DataBindings.Clear();
            txtsl.DataBindings.Add("text", dataGridView1.DataSource, "SoT");
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
            else if (this.txtsl.TextLength == 0)
            {
                MessageBox.Show("Số tín chỉ không được để trống");
                this.txtsl.Focus();
            }
            else
            {
                try
                {
                    ctpn.InsertHP(this.txtma.Text, this.txtten.Text, int.Parse(txtsl.Text));
                    MessageBox.Show("Đã thêm dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmHOCPHAN_Load(sender, e);
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
                txtsl.ReadOnly = false;
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            ctpn.XoaHP(txtma.Text);
            frmHOCPHAN_Load(sender, e);
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
                this.txtma.Focus();
            }
            else if (this.txtsl.TextLength == 0)
            {
                MessageBox.Show("Số tín chỉ không được để trống");
                this.txtsl.Focus();
            }
            else
            {
                try
                {
                    ctpn.SuaHP(this.txtma.Text, this.txtten.Text, int.Parse(txtsl.Text));
                    MessageBox.Show("Đã sửa dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmHOCPHAN_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã " + this.txtma.Text + " đã tồn tại");
                }
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            frmHOCPHAN_Load(sender, e);
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
            dt = ctpn.TimHP(txtT.Text);
            dataGridView1.DataSource = dt;
            binding();
        }
    }
}
