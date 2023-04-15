namespace DrugStore
{
    partial class FDoiMK
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
            this.tb_mkcu = new System.Windows.Forms.TextBox();
            this.tb_mkmoi = new System.Windows.Forms.TextBox();
            this.tb_mkmoi2 = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.lb_validate = new System.Windows.Forms.Label();
            this.pb_eye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_eye)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_mkcu
            // 
            this.tb_mkcu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mkcu.Location = new System.Drawing.Point(92, 48);
            this.tb_mkcu.Name = "tb_mkcu";
            this.tb_mkcu.PlaceholderText = "Nhập mật khẩu cũ";
            this.tb_mkcu.Size = new System.Drawing.Size(230, 32);
            this.tb_mkcu.TabIndex = 0;
            this.tb_mkcu.TextChanged += new System.EventHandler(this.tb_mkcu_TextChanged);
            // 
            // tb_mkmoi
            // 
            this.tb_mkmoi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mkmoi.Location = new System.Drawing.Point(92, 86);
            this.tb_mkmoi.Name = "tb_mkmoi";
            this.tb_mkmoi.PlaceholderText = "Nhập mật khẩu mới";
            this.tb_mkmoi.Size = new System.Drawing.Size(230, 32);
            this.tb_mkmoi.TabIndex = 1;
            this.tb_mkmoi.TextChanged += new System.EventHandler(this.tb_mkcu_TextChanged);
            // 
            // tb_mkmoi2
            // 
            this.tb_mkmoi2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mkmoi2.Location = new System.Drawing.Point(92, 124);
            this.tb_mkmoi2.Name = "tb_mkmoi2";
            this.tb_mkmoi2.PlaceholderText = "Nhập lại mật khẩu mới";
            this.tb_mkmoi2.Size = new System.Drawing.Size(230, 32);
            this.tb_mkmoi2.TabIndex = 2;
            this.tb_mkmoi2.TextChanged += new System.EventHandler(this.tb_mkcu_TextChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ok.Location = new System.Drawing.Point(92, 183);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(101, 42);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_huy.Location = new System.Drawing.Point(199, 183);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(123, 42);
            this.btn_huy.TabIndex = 4;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // lb_validate
            // 
            this.lb_validate.AutoSize = true;
            this.lb_validate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_validate.ForeColor = System.Drawing.Color.Red;
            this.lb_validate.Location = new System.Drawing.Point(92, 159);
            this.lb_validate.Name = "lb_validate";
            this.lb_validate.Size = new System.Drawing.Size(196, 21);
            this.lb_validate.TabIndex = 5;
            this.lb_validate.Text = "Xin nhập đầy đủ mật khẩu!";
            // 
            // pb_eye
            // 
            this.pb_eye.Image = global::DrugStore.Properties.Resources.eye;
            this.pb_eye.Location = new System.Drawing.Point(39, 48);
            this.pb_eye.Name = "pb_eye";
            this.pb_eye.Size = new System.Drawing.Size(34, 34);
            this.pb_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_eye.TabIndex = 6;
            this.pb_eye.TabStop = false;
            this.pb_eye.Click += new System.EventHandler(this.pb_eye_Click);
            // 
            // FDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 275);
            this.Controls.Add(this.pb_eye);
            this.Controls.Add(this.lb_validate);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_mkmoi2);
            this.Controls.Add(this.tb_mkmoi);
            this.Controls.Add(this.tb_mkcu);
            this.Name = "FDoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.FDoiMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_mkcu;
        private TextBox tb_mkmoi;
        private TextBox tb_mkmoi2;
        private Button btn_ok;
        private Button btn_huy;
        private Label lb_validate;
        private PictureBox pb_eye;
    }
}