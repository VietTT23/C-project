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
    public partial class frmBTL_SV : Form
    {
        BTL_SV1 btlsv = new BTL_SV1();
        public static string quyen;
        loginTableAdapters.QueriesTableAdapter dn = new loginTableAdapters.QueriesTableAdapter();

        public frmBTL_SV()
        {
            InitializeComponent();
        }

        private void frmBTL_SV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset1.tblSV' table. You can move, or remove it, as needed.
            this.tblSVTableAdapter.Fill(this.dataset1.tblSV);
            // TODO: This line of code loads data into the 'dataset1.tblGV' table. You can move, or remove it, as needed.
            this.tblGVTableAdapter.Fill(this.dataset1.tblGV);
            // TODO: This line of code loads data into the 'dataset1.tblBTL' table. You can move, or remove it, as needed.
            this.tblBTLTableAdapter.Fill(this.dataset1.tblBTL);
            // TODO: This line of code loads data into the 'dataset1.tblBTL_SV' table. You can move, or remove it, as needed.
            this.tblBTL_SVTableAdapter.Fill(this.dataset1.tblBTL_SV);

            binding();

            txtd.ReadOnly = true;

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

                txtd.ReadOnly = false;
                
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
            cbmabtl.DataBindings.Clear();
            cbmabtl.DataBindings.Add("text", dgvBTL_SV.DataSource, "MaBTL");
            cbmasv.DataBindings.Clear();
            cbmasv.DataBindings.Add("text", dgvBTL_SV.DataSource, "MaSV");
            cbmagv.DataBindings.Clear();
            cbmagv.DataBindings.Add("text", dgvBTL_SV.DataSource, "MaGV");
            txtd.DataBindings.Clear();
            txtd.DataBindings.Add("text", dgvBTL_SV.DataSource, "Diem");
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (this.txtd.TextLength == 0)
            {
                MessageBox.Show("Điểm không được để trống");
                this.txtd.Focus();
            }
            else
            {
                try
                {
                    btlsv.InsertBTL_SV (cbmasv.SelectedValue.ToString(), cbmabtl.SelectedValue.ToString(), cbmagv.SelectedValue.ToString(), int.Parse(txtd.Text));
                    MessageBox.Show("Đã thêm dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmBTL_SV_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã " + this.cbmasv.Text + " đã tồn tại");
                }
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (dn.CheckSua(quyen, true) == 1)
            {
                bntSavesua.Enabled = true;
                
                txtd.ReadOnly = false;
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            frmBTL_SV_Load(sender, e);
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            btlsv.XoaBTL_SV(cbmasv.SelectedValue.ToString(), cbmabtl.SelectedValue.ToString(), cbmagv.SelectedValue.ToString());
            frmBTL_SV_Load(sender, e);
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

        private void bntSavesua_Click(object sender, EventArgs e)
        {
            if (this.txtd.TextLength == 0)
            {
                MessageBox.Show("Điểm không được để trống");
                this.txtd.Focus();
            }

            else
            {
                try
                {
                    btlsv.SuaBTL_SV(cbmasv.SelectedValue.ToString(), cbmabtl.SelectedValue.ToString(), cbmagv.SelectedValue.ToString(), int.Parse(txtd.Text));
                    MessageBox.Show("Đã sửa dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmBTL_SV_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã " + this.cbmasv.Text + " đã tồn tại");
                }
            }
        }

        private void txtT_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = btlsv.TimBTL_SV(txtT.Text);
            dgvBTL_SV.DataSource = dt;
            binding();
        }
    }
}
