using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormQuanLyBTL
{
    public partial class frmDN : Form
    {
        public frmDN()
        {
            InitializeComponent();
        }

        private void bntDN_Click(object sender, EventArgs e)
        {
            loginTableAdapters.QueriesTableAdapter dn = new loginTableAdapters.QueriesTableAdapter();

            if (dn.CheckLogin(txtTK.Text, txtPASS.Text) == 1)
            {
                frmLOP.quyen = txtTK.Text;
                frmCD.quyen = txtTK.Text;
                frmHOIDONG.quyen = txtTK.Text;
                frmGV.quyen = txtTK.Text;
                frmHOCPHAN.quyen = txtTK.Text;
                frmSINHVIEN.quyen = txtTK.Text;
                frmBTL.quyen = txtTK.Text;
                frmBTL_SV.quyen = txtTK.Text;
                frmCD_SV.quyen = txtTK.Text;
                frmMain.quyen = txtTK.Text;

                if (MessageBox.Show("Bạn có muốn đăng nhập bằng tài khoản và mật khẩu này không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frmMain fMain = new frmMain();
                    fMain.Show();
                    this.Hide();


                }
            }
            else
            {
                if (this.txtTK.TextLength == 0)
                {
                    MessageBox.Show("Tài khoản không được bỏ trống");

                }
                else if (this.txtPASS.TextLength == 0)
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống");

                }

                else MessageBox.Show("Tài khoản mật khâu không đúng", "Cảnh báo", MessageBoxButtons.YesNo);
            }
        }

        private void bntRF_Click(object sender, EventArgs e)
        {
            txtTK.Clear();
            txtPASS.Clear();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Dispose();
        }
    }
}
