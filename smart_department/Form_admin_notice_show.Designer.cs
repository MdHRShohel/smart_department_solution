
namespace smart_department
{
    partial class Form_admin_notice_show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_admin_notice_show));
            this.pictureBox_show_notice = new System.Windows.Forms.PictureBox();
            this.lbl_top_show_notice = new System.Windows.Forms.Label();
            this.btn_back_fm12_show = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.dataGridView_show_notice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_show_notice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_show_notice)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_show_notice
            // 
            this.pictureBox_show_notice.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox_show_notice.Location = new System.Drawing.Point(787, 68);
            this.pictureBox_show_notice.Name = "pictureBox_show_notice";
            this.pictureBox_show_notice.Size = new System.Drawing.Size(581, 670);
            this.pictureBox_show_notice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_show_notice.TabIndex = 98;
            this.pictureBox_show_notice.TabStop = false;
            // 
            // lbl_top_show_notice
            // 
            this.lbl_top_show_notice.AutoSize = true;
            this.lbl_top_show_notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top_show_notice.Location = new System.Drawing.Point(713, 19);
            this.lbl_top_show_notice.Name = "lbl_top_show_notice";
            this.lbl_top_show_notice.Size = new System.Drawing.Size(89, 29);
            this.lbl_top_show_notice.TabIndex = 97;
            this.lbl_top_show_notice.Text = "Notice";
            // 
            // btn_back_fm12_show
            // 
            this.btn_back_fm12_show.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_back_fm12_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_fm12_show.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back_fm12_show.Location = new System.Drawing.Point(1380, 695);
            this.btn_back_fm12_show.Name = "btn_back_fm12_show";
            this.btn_back_fm12_show.Size = new System.Drawing.Size(76, 33);
            this.btn_back_fm12_show.TabIndex = 89;
            this.btn_back_fm12_show.Text = "BACK";
            this.btn_back_fm12_show.UseVisualStyleBackColor = false;
            this.btn_back_fm12_show.Click += new System.EventHandler(this.btn_back_fm12_show_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_log_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_log_out.Location = new System.Drawing.Point(46, 695);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(134, 30);
            this.btn_log_out.TabIndex = 88;
            this.btn_log_out.Text = "LOG OUT";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // dataGridView_show_notice
            // 
            this.dataGridView_show_notice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_show_notice.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView_show_notice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_show_notice.Location = new System.Drawing.Point(186, 70);
            this.dataGridView_show_notice.Name = "dataGridView_show_notice";
            this.dataGridView_show_notice.RowHeadersVisible = false;
            this.dataGridView_show_notice.RowHeadersWidth = 51;
            this.dataGridView_show_notice.RowTemplate.Height = 24;
            this.dataGridView_show_notice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_show_notice.Size = new System.Drawing.Size(544, 668);
            this.dataGridView_show_notice.TabIndex = 99;
            this.dataGridView_show_notice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_show_notice_CellContentClick);
            // 
            // Form_admin_notice_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1499, 806);
            this.Controls.Add(this.dataGridView_show_notice);
            this.Controls.Add(this.pictureBox_show_notice);
            this.Controls.Add(this.lbl_top_show_notice);
            this.Controls.Add(this.btn_back_fm12_show);
            this.Controls.Add(this.btn_log_out);
            this.DoubleBuffered = true;
            this.Name = "Form_admin_notice_show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Department";
            this.Load += new System.EventHandler(this.Form_admin_notice_show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_show_notice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_show_notice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_show_notice;
        private System.Windows.Forms.Label lbl_top_show_notice;
        private System.Windows.Forms.Button btn_back_fm12_show;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.DataGridView dataGridView_show_notice;
    }
}