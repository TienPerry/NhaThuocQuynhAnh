namespace DrugStore
{
    partial class FDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.pb_eye = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_validate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_eye)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÀ THUỐC QUỲNH ANH";
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_password.Location = new System.Drawing.Point(105, 67);
            this.tb_password.Name = "tb_password";
            this.tb_password.PlaceholderText = "Nhập mật khẩu";
            this.tb_password.Size = new System.Drawing.Size(233, 34);
            this.tb_password.TabIndex = 1;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // pb_eye
            // 
            this.pb_eye.Image = global::DrugStore.Properties.Resources.eye;
            this.pb_eye.Location = new System.Drawing.Point(65, 67);
            this.pb_eye.Name = "pb_eye";
            this.pb_eye.Size = new System.Drawing.Size(34, 34);
            this.pb_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_eye.TabIndex = 2;
            this.pb_eye.TabStop = false;
            this.pb_eye.Click += new System.EventHandler(this.pb_eye_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_login.Location = new System.Drawing.Point(144, 143);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(121, 41);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_login_KeyUp);
            // 
            // lb_validate
            // 
            this.lb_validate.AutoSize = true;
            this.lb_validate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate.ForeColor = System.Drawing.Color.Red;
            this.lb_validate.Location = new System.Drawing.Point(105, 104);
            this.lb_validate.Name = "lb_validate";
            this.lb_validate.Size = new System.Drawing.Size(105, 21);
            this.lb_validate.TabIndex = 4;
            this.lb_validate.Text = "Sai mật khẩu!";
            // 
            // FDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 210);
            this.Controls.Add(this.lb_validate);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pb_eye);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_password;
        private PictureBox pb_eye;
        private Button btn_login;
        private Label lb_validate;
    }
}