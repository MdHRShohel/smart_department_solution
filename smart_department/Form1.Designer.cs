
namespace smart_department
{
    partial class form_start
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
            this.components = new System.ComponentModel.Container();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.lbl_credit = new System.Windows.Forms.Label();
            this.pnl_progress2 = new System.Windows.Forms.Panel();
            this.pnl_progress1 = new System.Windows.Forms.Panel();
            this.timer_progress = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(132, 41);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(306, 25);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome to Smart Department";
            // 
            // lbl_loading
            // 
            this.lbl_loading.AutoSize = true;
            this.lbl_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading.ForeColor = System.Drawing.Color.Silver;
            this.lbl_loading.Location = new System.Drawing.Point(201, 75);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(161, 29);
            this.lbl_loading.TabIndex = 1;
            this.lbl_loading.Text = "LOADING.....";
            // 
            // lbl_credit
            // 
            this.lbl_credit.AutoSize = true;
            this.lbl_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_credit.Location = new System.Drawing.Point(290, 157);
            this.lbl_credit.Name = "lbl_credit";
            this.lbl_credit.Size = new System.Drawing.Size(259, 20);
            this.lbl_credit.TabIndex = 2;
            this.lbl_credit.Text = "Created By Firose, Arafat, Shohel";
            // 
            // pnl_progress2
            // 
            this.pnl_progress2.Location = new System.Drawing.Point(0, 198);
            this.pnl_progress2.Name = "pnl_progress2";
            this.pnl_progress2.Size = new System.Drawing.Size(580, 16);
            this.pnl_progress2.TabIndex = 3;
            // 
            // pnl_progress1
            // 
            this.pnl_progress1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_progress1.Location = new System.Drawing.Point(0, 198);
            this.pnl_progress1.Name = "pnl_progress1";
            this.pnl_progress1.Size = new System.Drawing.Size(35, 16);
            this.pnl_progress1.TabIndex = 4;
            // 
            // timer_progress
            // 
            this.timer_progress.Enabled = true;
            this.timer_progress.Interval = 15;
            this.timer_progress.Tick += new System.EventHandler(this.timer_progress_Tick);
            // 
            // form_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(581, 214);
            this.Controls.Add(this.pnl_progress1);
            this.Controls.Add(this.pnl_progress2);
            this.Controls.Add(this.lbl_credit);
            this.Controls.Add(this.lbl_loading);
            this.Controls.Add(this.lbl_welcome);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_loading;
        private System.Windows.Forms.Label lbl_credit;
        private System.Windows.Forms.Panel pnl_progress2;
        private System.Windows.Forms.Panel pnl_progress1;
        private System.Windows.Forms.Timer timer_progress;
    }
}

