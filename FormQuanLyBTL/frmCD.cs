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
    public partial class frmCD : Form
    {
        //Tạo biến thuộc lớp đối tượng Chuyên đề
        CD1 cd = new CD1();
        //Biến có tác dụng lưu tên tài khoản đang sử dụng
        public static string quyen;
        //Biến thực hiện kiểm tra quyền dc phân
        loginTableAdapters.QueriesTableAdapter dn = new loginTableAdapters.QueriesTableAdapter();

        public frmCD()
        {
            InitializeComponent();
        }

        private void frmCD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataset1.tblHoiDong' table. You can move, or remove it, as needed.
            this.tblHoiDongTableAdapter.Fill(this.dataset1.tblHoiDong);
            // TODO: This line of code loads data into the 'dataset1.tblCD' table. You can move, or remove it, as needed.
            this.tblCDTableAdapter.Fill(this.dataset1.tblCD);

            binding();

            txtten.ReadOnly = true;
            txtma.ReadOnly = true;
            txtnam.ReadOnly = true;

            bntSavesua.Enabled = false;

            //Kiêm rtra quyền tìm
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
   
                txtnam.ReadOnly = false;
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
            txtma.DataBindings.Add("text", dgvCD.DataSource, "MaCD");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("text", dgvCD.DataSource, "TenCD");
            txtnam.DataBindings.Clear();
            txtnam.DataBindings.Add("text", dgvCD.DataSource, "Nam");
            cbmahd.DataBindings.Clear();
            cbmahd.DataBindings.Add("text", dgvCD.DataSource, "MaHoiDong");
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
            else
            {
                try
                {
                    cd.InsertCD(this.txtma.Text, this.txtten.Text, txtnam.Text, cbmahd.Text);
                    MessageBox.Show("Đã thêm dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCD_Load(sender, e);
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
                txtnam.ReadOnly = false;
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            cd.XoaCD(txtma.Text);
            frmCD_Load(sender, e);
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
            else if (this.txtnam.TextLength == 0)
            {
                MessageBox.Show("Năm không được để trống");
                this.txtnam.Focus();
            }
            else
            {
                try
                {
                    cd.SuaCD(this.txtma.Text, this.txtten.Text, txtnam.Text, cbmahd.Text);
                    MessageBox.Show("Đã sửa dự án thành công",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCD_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Mã " + this.txtma.Text + " đã tồn tại");
                }
            }
        }

        private void bntReset_Click(object sender, EventArgs e)
        {
            frmCD_Load(sender, e);
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
            dt = cd.TimCD(txtT.Text);
            dgvCD.DataSource = dt;
            binding();
        }
    }
}
