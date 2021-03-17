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
    public partial class frmDK : Form
    {
        Dangnhap dnhap = new Dangnhap();
        public frmDK()
        {
            InitializeComponent();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            frmMain fMain = new frmMain();
            fMain.Show();
            this.Hide();
        }

        private void bntDN_Click(object sender, EventArgs e)
        {
            if (this.txtten.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập tên sử dụng  ");
            else if (this.txtten.TextLength > 8)
                MessageBox.Show("Tên sử dụng không được quá 8 kí tự  ");
            else if (this.txtpass.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập mật khẩu  ");
            else if (this.txtpass.Text != this.txtnl.Text)
                MessageBox.Show("Nhập lại pass");
            else
                try
                {
                    dnhap.themtaikhoan(this.txtten.Text, this.txtpass.Text);
                    frmDK_Load(sender, e);
                    if (MessageBox.Show("Bạn đã thêm tài khoản thành công !Bạn có muốn đăng nhập ngay bây giờ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmDN dn = new frmDN();
                        dn.Show();
                        Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Tài khoản " + this.txtten.Text + " đã được sử dụng");

                }
        }

        private void frmDK_Load(object sender, EventArgs e)
        {

        }

        private void bntRF_Click(object sender, EventArgs e)
        {
            txtten.Clear();
            txtpass.Clear();
            txtnl.Clear();
        }
    }
}
