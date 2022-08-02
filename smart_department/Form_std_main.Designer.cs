
namespace smart_department
{
    partial class Form_std_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_std_main));
            this.pictureBox_User_login = new System.Windows.Forms.PictureBox();
            this.btn_user_login = new System.Windows.Forms.Button();
            this.txt_user_reg_username = new System.Windows.Forms.TextBox();
            this.lbl_user_login_username = new System.Windows.Forms.Label();
            this.txt_user_reg_pass = new System.Windows.Forms.TextBox();
            this.lbl_user_login_pass = new System.Windows.Forms.Label();
            this.btn_user_reg = new System.Windows.Forms.Button();
            this.btn_back_fm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User_login)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_User_login
            // 
            this.pictureBox_User_login.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_User_login.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_User_login.Image")));
            this.pictureBox_User_login.Location = new System.Drawing.Point(219, 169);
            this.pictureBox_User_login.Name = "pictureBox_User_login";
            this.pictureBox_User_login.Size = new System.Drawing.Size(142, 153);
            this.pictureBox_User_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_User_login.TabIndex = 2;
            this.pictureBox_User_login.TabStop = false;
            // 
            // btn_user_login
            // 
            this.btn_user_login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_user_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_user_login.Location = new System.Drawing.Point(693, 280);
            this.btn_user_login.Name = "btn_user_login";
            this.btn_user_login.Size = new System.Drawing.Size(95, 34);
            this.btn_user_login.TabIndex = 11;
            this.btn_user_login.Text = "LOG IN";
            this.btn_user_login.UseVisualStyleBackColor = false;
            this.btn_user_login.Click += new System.EventHandler(this.btn_user_login_Click);
            // 
            // txt_user_reg_username
            // 
            this.txt_user_reg_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_reg_username.Location = new System.Drawing.Point(376, 210);
            this.txt_user_reg_username.Name = "txt_user_reg_username";
            this.txt_user_reg_username.Size = new System.Drawing.Size(294, 30);
            this.txt_user_reg_username.TabIndex = 120;
            // 
            // lbl_user_login_username
            // 
            this.lbl_user_login_username.AutoSize = true;
            this.lbl_user_login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_login_username.Location = new System.Drawing.Point(376, 182);
            this.lbl_user_login_username.Name = "lbl_user_login_username";
            this.lbl_user_login_username.Size = new System.Drawing.Size(153, 25);
            this.lbl_user_login_username.TabIndex = 119;
            this.lbl_user_login_username.Text = "Username (ID)";
            // 
            // txt_user_reg_pass
            // 
            this.txt_user_reg_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_reg_pass.Location = new System.Drawing.Point(376, 280);
            this.txt_user_reg_pass.Name = "txt_user_reg_pass";
            this.txt_user_reg_pass.Size = new System.Drawing.Size(294, 30);
            this.txt_user_reg_pass.TabIndex = 124;
            this.txt_user_reg_pass.UseSystemPasswordChar = true;
            // 
            // lbl_user_login_pass
            // 
            this.lbl_user_login_pass.AutoSize = true;
            this.lbl_user_login_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_login_pass.Location = new System.Drawing.Point(376, 252);
            this.lbl_user_login_pass.Name = "lbl_user_login_pass";
            this.lbl_user_login_pass.Size = new System.Drawing.Size(235, 25);
            this.lbl_user_login_pass.TabIndex = 123;
            this.lbl_user_login_pass.Text = "Password (Max 8 char)";
            // 
            // btn_user_reg
            // 
            this.btn_user_reg.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_user_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_reg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_user_reg.Location = new System.Drawing.Point(38, 450);
            this.btn_user_reg.Name = "btn_user_reg";
            this.btn_user_reg.Size = new System.Drawing.Size(135, 34);
            this.btn_user_reg.TabIndex = 125;
            this.btn_user_reg.Text = "REG. HERE";
            this.btn_user_reg.UseVisualStyleBackColor = false;
            this.btn_user_reg.Click += new System.EventHandler(this.btn_user_reg_Click);
            // 
            // btn_back_fm2
            // 
            this.btn_back_fm2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_back_fm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_fm2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back_fm2.Location = new System.Drawing.Point(902, 451);
            this.btn_back_fm2.Name = "btn_back_fm2";
            this.btn_back_fm2.Size = new System.Drawing.Size(76, 33);
            this.btn_back_fm2.TabIndex = 127;
            this.btn_back_fm2.Text = "BACK";
            this.btn_back_fm2.UseVisualStyleBackColor = false;
            this.btn_back_fm2.Click += new System.EventHandler(this.btn_back_fm2_Click);
            // 
            // Form_std_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 540);
            this.Controls.Add(this.btn_back_fm2);
            this.Controls.Add(this.btn_user_reg);
            this.Controls.Add(this.txt_user_reg_pass);
            this.Controls.Add(this.lbl_user_login_pass);
            this.Controls.Add(this.txt_user_reg_username);
            this.Controls.Add(this.lbl_user_login_username);
            this.Controls.Add(this.btn_user_login);
            this.Controls.Add(this.pictureBox_User_login);
            this.DoubleBuffered = true;
            this.Name = "Form_std_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Department";
            this.Load += new System.EventHandler(this.Form_std_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_User_login;
        private System.Windows.Forms.Button btn_user_login;
        private System.Windows.Forms.TextBox txt_user_reg_username;
        private System.Windows.Forms.Label lbl_user_login_username;
        private System.Windows.Forms.TextBox txt_user_reg_pass;
        private System.Windows.Forms.Label lbl_user_login_pass;
        private System.Windows.Forms.Button btn_user_reg;
        private System.Windows.Forms.Button btn_back_fm2;
    }
}