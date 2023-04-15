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
    public partial class FDoiMK : Form
    {
        public FDoiMK()
        {
            InitializeComponent();
        }
        private static bool isClick = true;
        private void pb_eye_Click(object sender, EventArgs e)
        {
            isClick = !isClick;
            tb_mkcu.UseSystemPasswordChar = isClick;
            tb_mkmoi.UseSystemPasswordChar = isClick;
            tb_mkmoi2.UseSystemPasswordChar = isClick;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string mkcu = tb_mkcu.Text.ToString();
            string mkmoi = tb_mkmoi.Text.ToString();
            string mkmoi2 = tb_mkmoi2.Text.ToString();
            if (mkcu == "" || mkmoi == "" || mkmoi2 == "")
            {
                lb_validate.Text = "Xin nhập đầy đủ mật khẩu!";
            }
            else if (mkmoi != mkmoi2)
            {
                lb_validate.Text = "Mật khẩu mới thứ 2 khác thứ nhất";
            }
            else
            {
                TaiKhoan nv = null;
                nv = TaiKhoanBUS.Instance.checkAccount(mkcu);
                if (nv != null)
                {
                    bool check = TaiKhoanBUS.Instance.doiMatKhau(mkcu, mkmoi);
                    if (check)
                    {
                        this.Close();
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu KHÔNG thành công");
                    }    
                }
                else
                {
                    lb_validate.Text = "Mật khẩu cũ sai!";
                }
            }    
        }

        private void FDoiMK_Load(object sender, EventArgs e)
        {
            lb_validate.Text = "";
            tb_mkcu.UseSystemPasswordChar = isClick;
            tb_mkmoi.UseSystemPasswordChar = isClick;
            tb_mkmoi2.UseSystemPasswordChar = isClick;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tb_mkcu_TextChanged(object sender, EventArgs e)
        {
            lb_validate.Text = "";
        }
    }
}
