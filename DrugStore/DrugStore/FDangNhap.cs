using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugStore
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }
        private static bool isClick = true;
        private void pb_eye_Click(object sender, EventArgs e)
        {
            isClick = !isClick;
            tb_password.UseSystemPasswordChar = isClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = isClick;
            lb_validate.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_password.Text == "")    // Show message to user
            {
                lb_validate.Text = "Chưa nhập mật khẩu!";
                tb_password.Focus();
                return;
            }
            // validating user account
            this.ActiveControl = null;
            
            String pass = tb_password.Text.ToString();
            TaiKhoan nv = null;
            nv = TaiKhoanBUS.Instance.checkAccount(pass);
            if (nv != null)
            {
                Loading f;
                f = new Loading();
                f.Show();
                this.Hide();
            }
            else
            {
                lb_validate.Text = "Sai mật khẩu!";
            }
        }

        private void btn_login_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            lb_validate.Text = "";
        }

        private void FDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
