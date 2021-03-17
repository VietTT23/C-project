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
    public partial class frmCD_SV : Form
    {
        CD_SV1 ctpn = new CD_SV1();
        public static string quyen;
        loginTableAdapters.QueriesTableAdapter dn = new loginTableAdapters.QueriesTableAdapter();

        public frmCD_SV()
        {
            InitializeComponent();
        }

        private void frmCD_SV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset1.tblCD' table. You can move, or remove it, as needed.
            this.tblCDTableAdapter.Fill(this.dataset1.tblCD);
            // TODO: This line of code loads data into the 'dataset1.tblSV' table. You can move, or remove it, as needed.
            this.tblSVTableAdapter.Fill(this.dataset1.tblSV);
            // TODO: This line of code loads data into the 'dataset1.tblGV' table. You can move, or remove it, as needed.
            this.tblGVTableAdapter.Fill(this.dataset1.tblGV);
            // TODO: This line of code loads data into the 'dataset1.tblHP' table. You can move, or remove it, as needed.
            this.tblHPTableAdapter.Fill(this.dataset1.tblHP);
            // TODO: This line of code loads data into the 'dataset1.tblCD_SV' table. You can move, or remove it, as needed.
            this.tblCD_SVTableAdapter.Fill(this.dataset1.tblCD_SV);

            binding();

            bntSavesua.Enabled = false;

            txtd.ReadOnly = true;

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
                //this.tblSVTableAdapter.Fill(this.dataset1.tblSV);
                //this.tblGVTableAdapter.Fill(this.dataset1.tblGV);
                //this.tblHPTableAdapter.Fill(this.dataset1.tblHP);
                //this.tblCDTableAdapter.Fill(this.dataset1.tblCD);

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
            cbmahp.DataBindings.Clear();
            cbmahp.DataBindings.Add("text", dataGridView1.DataSource, "MaHP");
            cbmasv.DataBindings.Clear();
            cbmasv.DataBindings.Add("text", dataGridView1.DataSource, "MaSV");
            cbmagv.DataBindings.Clear();
            cbmagv.DataBindings.Add("text", dataGridView1.DataSource, "MaGV");
            cbmacd.DataBindings.Clear();
            cbmacd.DataBindings.Add("text", dataGridView1.DataSource, "MaCD");
            txtd.DataBindings.Clear();
            txtd.DataBindings.Add("text", dataGridView1.DataSource, "Diem");
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
                    ctpn.InsertCD_SV(cbmasv.SelectedValue.ToString(), cbmahp.SelectedValue.ToString(), cbmagv.SelectedValue.ToString(), cbmacd.SelectedValue.ToString(), int.Parse(txtd.Text));
                    MessageBox.Show("Đã thêm dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCD_SV_Load(sender, e);
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

        private void bntXoa_Click(object sender, EventArgs e)
        {
            ctpn.XoaCD_SV(cbmasv.SelectedValue.ToString(), cbmahp.SelectedValue.ToString(), cbmagv.SelectedValue.ToString());
            frmCD_SV_Load(sender, e);
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
                    ctpn.SuaCD_SV(cbmasv.SelectedValue.ToString(), cbmahp.SelectedValue.ToString(), cbmagv.SelectedValue.ToString(), cbmacd.SelectedValue.ToString(), int.Parse(txtd.Text));
                    MessageBox.Show("Đã sửa dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCD_SV_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã " + this.cbmasv.Text + " đã tồn tại");
                }
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            frmCD_SV_Load(sender, e);
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
            dt = ctpn.TimCD_SV(txtT.Text);
            dataGridView1.DataSource = dt;
            binding();
        }

    }
}
