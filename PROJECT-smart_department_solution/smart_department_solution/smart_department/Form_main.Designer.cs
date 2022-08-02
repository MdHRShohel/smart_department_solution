
namespace smart_department
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.pictureBox_admin = new System.Windows.Forms.PictureBox();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.btn_admin_go = new System.Windows.Forms.Button();
            this.btn_student_go = new System.Windows.Forms.Button();
            this.pictureBox_topName = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_topName)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_admin
            // 
            this.pictureBox_admin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_admin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_admin.Image")));
            this.pictureBox_admin.Location = new System.Drawing.Point(329, 279);
            this.pictureBox_admin.Name = "pictureBox_admin";
            this.pictureBox_admin.Size = new System.Drawing.Size(142, 153);
            this.pictureBox_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_admin.TabIndex = 0;
            this.pictureBox_admin.TabStop = false;
            // 
            // pictureBox_User
            // 
            this.pictureBox_User.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_User.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_User.Image")));
            this.pictureBox_User.Location = new System.Drawing.Point(532, 279);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(142, 153);
            this.pictureBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_User.TabIndex = 1;
            this.pictureBox_User.TabStop = false;
            // 
            // btn_admin_go
            // 
            this.btn_admin_go.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_admin_go.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_go.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_admin_go.Location = new System.Drawing.Point(336, 436);
            this.btn_admin_go.Name = "btn_admin_go";
            this.btn_admin_go.Size = new System.Drawing.Size(142, 35);
            this.btn_admin_go.TabIndex = 2;
            this.btn_admin_go.Text = "ADMIN";
            this.btn_admin_go.UseVisualStyleBackColor = false;
            // 
            // btn_student_go
            // 
            this.btn_student_go.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_student_go.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student_go.ForeColor = System.Drawing.Color.Green;
            this.btn_student_go.Location = new System.Drawing.Point(532, 436);
            this.btn_student_go.Name = "btn_student_go";
            this.btn_student_go.Size = new System.Drawing.Size(142, 35);
            this.btn_student_go.TabIndex = 3;
            this.btn_student_go.Text = "STUDENT";
            this.btn_student_go.UseVisualStyleBackColor = false;
            // 
            // pictureBox_topName
            // 
            this.pictureBox_topName.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_topName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_topName.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_topName.Image")));
            this.pictureBox_topName.Location = new System.Drawing.Point(301, 79);
            this.pictureBox_topName.Name = "pictureBox_topName";
            this.pictureBox_topName.Size = new System.Drawing.Size(408, 178);
            this.pictureBox_topName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_topName.TabIndex = 4;
            this.pictureBox_topName.TabStop = false;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 540);
            this.Controls.Add(this.pictureBox_topName);
            this.Controls.Add(this.btn_student_go);
            this.Controls.Add(this.btn_admin_go);
            this.Controls.Add(this.pictureBox_User);
            this.Controls.Add(this.pictureBox_admin);
            this.DoubleBuffered = true;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Department";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_topName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_admin;
        private System.Windows.Forms.PictureBox pictureBox_User;
        private System.Windows.Forms.Button btn_admin_go;
        private System.Windows.Forms.Button btn_student_go;
        private System.Windows.Forms.PictureBox pictureBox_topName;
    }
}