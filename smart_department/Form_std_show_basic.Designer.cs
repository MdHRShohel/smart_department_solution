
namespace smart_department
{
    partial class Form_std_show_basic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_std_show_basic));
            this.lbl_top_std_show_basic = new System.Windows.Forms.Label();
            this.txt_std_show_intake_basic = new System.Windows.Forms.TextBox();
            this.lbl_std_show_intake_basic = new System.Windows.Forms.Label();
            this.dataGridView_std_show_basic = new System.Windows.Forms.DataGridView();
            this.btn_back_fm24 = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.bnt_std_show_basic_go = new System.Windows.Forms.Button();
            this.lbl_std_show_intake_select_basic = new System.Windows.Forms.Label();
            this.comboBox_std_show_intake_select_basic = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_std_show_basic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_top_std_show_basic
            // 
            this.lbl_top_std_show_basic.AutoSize = true;
            this.lbl_top_std_show_basic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_top_std_show_basic.Location = new System.Drawing.Point(391, 9);
            this.lbl_top_std_show_basic.Name = "lbl_top_std_show_basic";
            this.lbl_top_std_show_basic.Size = new System.Drawing.Size(234, 29);
            this.lbl_top_std_show_basic.TabIndex = 106;
            this.lbl_top_std_show_basic.Text = "Course Information";
            // 
            // txt_std_show_intake_basic
            // 
            this.txt_std_show_intake_basic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_std_show_intake_basic.Location = new System.Drawing.Point(40, 278);
            this.txt_std_show_intake_basic.Name = "txt_std_show_intake_basic";
            this.txt_std_show_intake_basic.Size = new System.Drawing.Size(174, 30);
            this.txt_std_show_intake_basic.TabIndex = 102;
            this.txt_std_show_intake_basic.TextChanged += new System.EventHandler(this.txt_std_show_intake_basic_TextChanged);
            // 
            // lbl_std_show_intake_basic
            // 
            this.lbl_std_show_intake_basic.AutoSize = true;
            this.lbl_std_show_intake_basic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_std_show_intake_basic.Location = new System.Drawing.Point(39, 250);
            this.lbl_std_show_intake_basic.Name = "lbl_std_show_intake_basic";
            this.lbl_std_show_intake_basic.Size = new System.Drawing.Size(71, 25);
            this.lbl_std_show_intake_basic.TabIndex = 101;
            this.lbl_std_show_intake_basic.Text = "Intake";
            // 
            // dataGridView_std_show_basic
            // 
            this.dataGridView_std_show_basic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_std_show_basic.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView_std_show_basic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_std_show_basic.Location = new System.Drawing.Point(231, 65);
            this.dataGridView_std_show_basic.Name = "dataGridView_std_show_basic";
            this.dataGridView_std_show_basic.RowHeadersVisible = false;
            this.dataGridView_std_show_basic.RowHeadersWidth = 51;
            this.dataGridView_std_show_basic.RowTemplate.Height = 24;
            this.dataGridView_std_show_basic.Size = new System.Drawing.Size(743, 374);
            this.dataGridView_std_show_basic.TabIndex = 100;
            // 
            // btn_back_fm24
            // 
            this.btn_back_fm24.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_back_fm24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_fm24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back_fm24.Location = new System.Drawing.Point(900, 449);
            this.btn_back_fm24.Name = "btn_back_fm24";
            this.btn_back_fm24.Size = new System.Drawing.Size(76, 33);
            this.btn_back_fm24.TabIndex = 99;
            this.btn_back_fm24.Text = "BACK";
            this.btn_back_fm24.UseVisualStyleBackColor = false;
            this.btn_back_fm24.Click += new System.EventHandler(this.btn_back_fm24_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_log_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_log_out.Location = new System.Drawing.Point(40, 449);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(134, 30);
            this.btn_log_out.TabIndex = 98;
            this.btn_log_out.Text = "LOG OUT";
            this.btn_log_out.UseVisualStyleBackColor = false;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // bnt_std_show_basic_go
            // 
            this.bnt_std_show_basic_go.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_std_show_basic_go.Location = new System.Drawing.Point(158, 333);
            this.bnt_std_show_basic_go.Name = "bnt_std_show_basic_go";
            this.bnt_std_show_basic_go.Size = new System.Drawing.Size(56, 28);
            this.bnt_std_show_basic_go.TabIndex = 105;
            this.bnt_std_show_basic_go.Text = "GO";
            this.bnt_std_show_basic_go.UseVisualStyleBackColor = true;
            this.bnt_std_show_basic_go.Click += new System.EventHandler(this.bnt_std_show_basic_go_Click);
            // 
            // lbl_std_show_intake_select_basic
            // 
            this.lbl_std_show_intake_select_basic.AutoSize = true;
            this.lbl_std_show_intake_select_basic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_std_show_intake_select_basic.Location = new System.Drawing.Point(39, 183);
            this.lbl_std_show_intake_select_basic.Name = "lbl_std_show_intake_select_basic";
            this.lbl_std_show_intake_select_basic.Size = new System.Drawing.Size(138, 25);
            this.lbl_std_show_intake_select_basic.TabIndex = 108;
            this.lbl_std_show_intake_select_basic.Text = "Select Intake";
            // 
            // comboBox_std_show_intake_select_basic
            // 
            this.comboBox_std_show_intake_select_basic.FormattingEnabled = true;
            this.comboBox_std_show_intake_select_basic.Location = new System.Drawing.Point(40, 214);
            this.comboBox_std_show_intake_select_basic.Name = "comboBox_std_show_intake_select_basic";
            this.comboBox_std_show_intake_select_basic.Size = new System.Drawing.Size(174, 24);
            this.comboBox_std_show_intake_select_basic.TabIndex = 107;
            this.comboBox_std_show_intake_select_basic.SelectedIndexChanged += new System.EventHandler(this.comboBox_std_show_intake_select_basic_SelectedIndexChanged);
            // 
            // Form_std_show_basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 540);
            this.Controls.Add(this.lbl_std_show_intake_select_basic);
            this.Controls.Add(this.comboBox_std_show_intake_select_basic);
            this.Controls.Add(this.lbl_top_std_show_basic);
            this.Controls.Add(this.bnt_std_show_basic_go);
            this.Controls.Add(this.txt_std_show_intake_basic);
            this.Controls.Add(this.lbl_std_show_intake_basic);
            this.Controls.Add(this.dataGridView_std_show_basic);
            this.Controls.Add(this.btn_back_fm24);
            this.Controls.Add(this.btn_log_out);
            this.DoubleBuffered = true;
            this.Name = "Form_std_show_basic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Department";
            this.Load += new System.EventHandler(this.Form_std_show_basic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_std_show_basic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_top_std_show_basic;
        private System.Windows.Forms.TextBox txt_std_show_intake_basic;
        private System.Windows.Forms.Label lbl_std_show_intake_basic;
        private System.Windows.Forms.DataGridView dataGridView_std_show_basic;
        private System.Windows.Forms.Button btn_back_fm24;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button bnt_std_show_basic_go;
        private System.Windows.Forms.Label lbl_std_show_intake_select_basic;
        private System.Windows.Forms.ComboBox comboBox_std_show_intake_select_basic;
    }
}