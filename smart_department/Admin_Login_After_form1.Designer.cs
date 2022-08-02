
namespace smart_department
{
    partial class Admin_Login_After_form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login_After_form1));
            this.btn_data_show = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_data_insert = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.lbl_top_main_admin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_data_show
            // 
            this.btn_data_show.BackColor = System.Drawing.Color.Silver;
            this.btn_data_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_data_show.Location = new System.Drawing.Point(289, 127);
            this.btn_data_show.Name = "btn_data_show";
            this.btn_data_show.Size = new System.Drawing.Size(170, 92);
            this.btn_data_show.TabIndex = 0;
            this.btn_data_show.Text = "Show Data";
            this.btn_data_show.UseVisualStyleBackColor = false;
            this.btn_data_show.Click += new System.EventHandler(this.btn_data_show_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(530, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 92);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete Data";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(289, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 92);
            this.button4.TabIndex = 2;
            this.button4.Text = "Update Data";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_data_insert
            // 
            this.btn_data_insert.BackColor = System.Drawing.Color.Orange;
            this.btn_data_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_data_insert.Location = new System.Drawing.Point(530, 127);
            this.btn_data_insert.Name = "btn_data_insert";
            this.btn_data_insert.Size = new System.Drawing.Size(170, 92);
            this.btn_data_insert.TabIndex = 5;
            this.btn_data_insert.Text = "Insert Data";
            this.btn_data_insert.UseVisualStyleBackColor = false;
            this.btn_data_insert.Click += new System.EventHandler(this.btn_data_insert_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_log_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_log_out.Location = new System.Drawing.Point(35, 454);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(134, 30);
            this.btn_log_out.TabIndex = 19;
            this.btn_log_out.Text = "LOG OUT";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // lbl_top_main_admin
            // 
            this.lbl_top_main_admin.AutoSize = true;
            this.lbl_top_main_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top_main_admin.Location = new System.Drawing.Point(420, 9);
            this.lbl_top_main_admin.Name = "lbl_top_main_admin";
            this.lbl_top_main_admin.Size = new System.Drawing.Size(169, 29);
            this.lbl_top_main_admin.TabIndex = 98;
            this.lbl_top_main_admin.Text = "Admin Sector";
            // 
            // Admin_Login_After_form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 540);
            this.Controls.Add(this.lbl_top_main_admin);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_data_insert);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_data_show);
            this.DoubleBuffered = true;
            this.Name = "Admin_Login_After_form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Department";
            this.Load += new System.EventHandler(this.Admin_Login_After_form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_data_show;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_data_insert;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Label lbl_top_main_admin;
    }
}