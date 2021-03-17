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
    public partial class frmMain : Form
    {
        public static string quyen;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (quyen == null)
            {
                txttaikhoan.Text = "----------- Bạn chưa đăng nhập tài khoản -----------";
            }
            else
            {
                txttaikhoan.Text = "Bạn đã đăng nhập tài khoản: " + quyen;

            }
        }

        private void btCHUYEN_DE_Click(object sender, EventArgs e)
        {
            if (quyen == null)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmCD chuyenDe = new frmCD();
                chuyenDe.Show();
                this.Close();
            }
        }

        private void btBTL_Click(object sender, EventArgs e)
        {
            if (quyen == null)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmBTL baiTapLon = new frmBTL();
                baiTapLon.Show();
                this.Close();
            }
        }

        private void btLOP_Click(object sender, EventArgs e)
        {
            if (quyen == null)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmLOP lop = new frmLOP();
                lop.Show();
                this.Close();
            }
        }

        private void btHOI_DONG_Click(object sender, EventArgs e)
        {
            if (quyen == null)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmHOIDONG hoiDong = new frmHOIDONG();
                hoiDong.Show();
                this.Close();
            }
        }

        private void btGV_Click(object sender, EventArgs e)
        {
            if (quyen == null)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmGV giaoVien = new frmGV();
                giaoVien.Show();
                this.Close();
            }
        }

        private void btSV_Click(object sender, EventArgs e)
        {
            if (quyen == null)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmSINHVIEN sinhVien = new frmSINHVIEN();
                sinhVien.Show();
                this.Close();
            }
        }

        private void btHOC_PHAN_Click(object sender, EventArgs e)
        {
            if (quyen == null)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmHOCPHAN hocPhan = new frmHOCPHAN();
                hocPhan.Show();
                this.Close();
            }
        }

        private void btHD_BTL_Click(object sender, EventArgs e)
        {
            if (quyen == null)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmBTL_SV BTLSV = new frmBTL_SV();
                BTLSV.Show();
                this.Close();
            }
        }

        private void btHD_CD_Click(object sender, EventArgs e)
        {
            if (quyen == null)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmCD_SV CDSV = new frmCD_SV();
                CDSV.Show();
                this.Close();
            }
        }

        private void btTK_Click(object sender, EventArgs e)
        {
            if (quyen == null)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quyen == "admin")
            {
                frmTK TK = new frmTK();
                TK.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn không phải admin nên không thể sử dụng chức năng này");
            }
        }

        private void btDK_Click(object sender, EventArgs e)
        {
            if (quyen == null)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quyen == "admin")
            {
                frmDK DK = new frmDK();
                DK.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn phải là admin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btTHOAT_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Dispose();
        }

        private void btBAO_CAO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này hiện chưa được thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btHELP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này hiện chưa được thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btTIM_KIEM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này hiện chưa được thêm, chúng tôi sẽ thêm trong bản cập nhật tới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btDANG_NHAP_Click(object sender, EventArgs e)
        {
            frmDN dn = new frmDN();
            this.Hide();
            dn.ShowDialog();
            
        }

        private void btDANG_XUAT_Click(object sender, EventArgs e)
        {
            if (quyen == null)
            {
                MessageBox.Show("Bạn phải đăng nhập trước khi sử dụng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmDN dx = new frmDN();
                dx.Show();
                this.Close();
            }
        }
    }
}
