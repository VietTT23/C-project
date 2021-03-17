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
    public partial class frmHOIDONG : Form
    {
        //tạo biến thuộc lớp hội đồng
        HD1 ctpn = new HD1();
        public static string quyen;
        loginTableAdapters.QueriesTableAdapter dn = new loginTableAdapters.QueriesTableAdapter();

        public frmHOIDONG()
        {
            InitializeComponent();
        }

        private void frmHOIDONG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset1.tblHoiDong' table. You can move, or remove it, as needed.
            this.tblHoiDongTableAdapter.Fill(this.dataset1.tblHoiDong);

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
            txtma.DataBindings.Add("text", dgvHoiDong.DataSource, "MaHoiDong");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("text", dgvHoiDong.DataSource, "ChuTichHD");
            txtsl.DataBindings.Clear();
            txtsl.DataBindings.Add("text", dgvHoiDong.DataSource, "Soluong");

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

            else
            {
                try
                {
                    ctpn.InsertHoiDong(this.txtma.Text, this.txtten.Text, int.Parse(this.txtsl.Text));
                    MessageBox.Show("Đã thêm dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmHOIDONG_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã  " + this.txtma.Text + " đã tồn tại");
                }
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (dn.CheckSua(quyen, true) == 1)
            {
                bntSavesua.Enabled = true;

                txtsl.ReadOnly = false;
                txtten.ReadOnly = false;
                txtma.ReadOnly = false;
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            ctpn.XoaHoiDong(txtma.Text);
            frmHOIDONG_Load(sender, e);
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

            else
            {
                try
                {
                    ctpn.UpdateHoiDong(this.txtma.Text, this.txtten.Text, int.Parse(this.txtsl.Text));
                    MessageBox.Show("Đã sửa dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmHOIDONG_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã  " + this.txtma.Text + " đã tồn tại");
                }
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            frmHOIDONG_Load(sender, e);
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
            dt = ctpn.TimHoiDong(txtT.Text);
            dgvHoiDong.DataSource = dt;
            binding();
        }
    }
}
