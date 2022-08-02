
namespace smart_department
{
    partial class Form_notice_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_notice_admin));
            this.pictureBox_insert_notice = new System.Windows.Forms.PictureBox();
            this.btn_insert_img_choose_Notice = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.txt_insert_notice_date = new System.Windows.Forms.TextBox();
            this.lbl_date_notice = new System.Windows.Forms.Label();
            this.btn_back_fm5 = new System.Windows.Forms.Button();
            this.btn_insert_Notice = new System.Windows.Forms.Button();
            this.lbl_Ntype_notice = new System.Windows.Forms.Label();
            this.dateTimePicker_notice = new System.Windows.Forms.DateTimePicker();
            this.comboBox_insert_notice_Ntype = new System.Windows.Forms.ComboBox();
            this.lbl_top_insert_notice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_insert_notice)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_insert_notice
            // 
            this.pictureBox_insert_notice.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox_insert_notice.Location = new System.Drawing.Point(182, 92);
            this.pictureBox_insert_notice.Name = "pictureBox_insert_notice";
            this.pictureBox_insert_notice.Size = new System.Drawing.Size(327, 348);
            this.pictureBox_insert_notice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_insert_notice.TabIndex = 50;
            this.pictureBox_insert_notice.TabStop = false;
            // 
            // btn_insert_img_choose_Notice
            // 
            this.btn_insert_img_choose_Notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_img_choose_Notice.Location = new System.Drawing.Point(539, 344);
            this.btn_insert_img_choose_Notice.Name = "btn_insert_img_choose_Notice";
            this.btn_insert_img_choose_Notice.Size = new System.Drawing.Size(174, 36);
            this.btn_insert_img_choose_Notice.TabIndex = 49;
            this.btn_insert_img_choose_Notice.Text = "Add File";
            this.btn_insert_img_choose_Notice.UseVisualStyleBackColor = true;
            this.btn_insert_img_choose_Notice.Click += new System.EventHandler(this.btn_insert_img_choose_Notice_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_log_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_log_out.Location = new System.Drawing.Point(36, 443);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(134, 30);
            this.btn_log_out.TabIndex = 48;
            this.btn_log_out.Text = "LOG OUT";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // txt_insert_notice_date
            // 
            this.txt_insert_notice_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_insert_notice_date.Location = new System.Drawing.Point(539, 195);
            this.txt_insert_notice_date.Name = "txt_insert_notice_date";
            this.txt_insert_notice_date.Size = new System.Drawing.Size(174, 30);
            this.txt_insert_notice_date.TabIndex = 45;
            // 
            // lbl_date_notice
            // 
            this.lbl_date_notice.AutoSize = true;
            this.lbl_date_notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_notice.Location = new System.Drawing.Point(536, 167);
            this.lbl_date_notice.Name = "lbl_date_notice";
            this.lbl_date_notice.Size = new System.Drawing.Size(142, 25);
            this.lbl_date_notice.TabIndex = 44;
            this.lbl_date_notice.Text = "Published On";
            // 
            // btn_back_fm5
            // 
            this.btn_back_fm5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_back_fm5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_fm5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back_fm5.Location = new System.Drawing.Point(903, 440);
            this.btn_back_fm5.Name = "btn_back_fm5";
            this.btn_back_fm5.Size = new System.Drawing.Size(76, 33);
            this.btn_back_fm5.TabIndex = 43;
            this.btn_back_fm5.Text = "BACK";
            this.btn_back_fm5.UseVisualStyleBackColor = false;
            this.btn_back_fm5.Click += new System.EventHandler(this.btn_back_fm5_Click);
            // 
            // btn_insert_Notice
            // 
            this.btn_insert_Notice.Location = new System.Drawing.Point(811, 345);
            this.btn_insert_Notice.Name = "btn_insert_Notice";
            this.btn_insert_Notice.Size = new System.Drawing.Size(59, 30);
            this.btn_insert_Notice.TabIndex = 42;
            this.btn_insert_Notice.Text = "GO";
            this.btn_insert_Notice.UseVisualStyleBackColor = true;
            this.btn_insert_Notice.Click += new System.EventHandler(this.btn_insert_Notice_Click);
            // 
            // lbl_Ntype_notice
            // 
            this.lbl_Ntype_notice.AutoSize = true;
            this.lbl_Ntype_notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ntype_notice.Location = new System.Drawing.Point(536, 246);
            this.lbl_Ntype_notice.Name = "lbl_Ntype_notice";
            this.lbl_Ntype_notice.Size = new System.Drawing.Size(61, 25);
            this.lbl_Ntype_notice.TabIndex = 40;
            this.lbl_Ntype_notice.Text = "Type";
            // 
            // dateTimePicker_notice
            // 
            this.dateTimePicker_notice.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_notice.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_notice.Location = new System.Drawing.Point(742, 200);
            this.dateTimePicker_notice.Name = "dateTimePicker_notice";
            this.dateTimePicker_notice.Size = new System.Drawing.Size(126, 22);
            this.dateTimePicker_notice.TabIndex = 75;
            this.dateTimePicker_notice.ValueChanged += new System.EventHandler(this.dateTimePicker_notice_ValueChanged);
            // 
            // comboBox_insert_notice_Ntype
            // 
            this.comboBox_insert_notice_Ntype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_insert_notice_Ntype.FormattingEnabled = true;
            this.comboBox_insert_notice_Ntype.Items.AddRange(new object[] {
            "General",
            "Class Related",
            "Exam Related"});
            this.comboBox_insert_notice_Ntype.Location = new System.Drawing.Point(539, 279);
            this.comboBox_insert_notice_Ntype.Name = "comboBox_insert_notice_Ntype";
            this.comboBox_insert_notice_Ntype.Size = new System.Drawing.Size(174, 28);
            this.comboBox_insert_notice_Ntype.TabIndex = 76;
            // 
            // lbl_top_insert_notice
            // 
            this.lbl_top_insert_notice.AutoSize = true;
            this.lbl_top_insert_notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top_insert_notice.Location = new System.Drawing.Point(425, 9);
            this.lbl_top_insert_notice.Name = "lbl_top_insert_notice";
            this.lbl_top_insert_notice.Size = new System.Drawing.Size(161, 29);
            this.lbl_top_insert_notice.TabIndex = 91;
            this.lbl_top_insert_notice.Text = "Insert Notice";
            // 
            // Form_notice_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 540);
            this.Controls.Add(this.lbl_top_insert_notice);
            this.Controls.Add(this.comboBox_insert_notice_Ntype);
            this.Controls.Add(this.dateTimePicker_notice);
            this.Controls.Add(this.pictureBox_insert_notice);
            this.Controls.Add(this.btn_insert_img_choose_Notice);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.txt_insert_notice_date);
            this.Controls.Add(this.lbl_date_notice);
            this.Controls.Add(this.btn_back_fm5);
            this.Controls.Add(this.btn_insert_Notice);
            this.Controls.Add(this.lbl_Ntype_notice);
            this.DoubleBuffered = true;
            this.Name = "Form_notice_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Department";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_insert_notice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_insert_notice;
        private System.Windows.Forms.Button btn_insert_img_choose_Notice;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.TextBox txt_insert_notice_date;
        private System.Windows.Forms.Label lbl_date_notice;
        private System.Windows.Forms.Button btn_back_fm5;
        private System.Windows.Forms.Button btn_insert_Notice;
        private System.Windows.Forms.Label lbl_Ntype_notice;
        private System.Windows.Forms.DateTimePicker dateTimePicker_notice;
        private System.Windows.Forms.ComboBox comboBox_insert_notice_Ntype;
        private System.Windows.Forms.Label lbl_top_insert_notice;
    }
}