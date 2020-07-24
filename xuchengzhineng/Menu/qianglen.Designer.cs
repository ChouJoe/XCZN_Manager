namespace xuchengzhineng.Menu
{
    partial class qianglen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucPanelTitle2 = new HZH_Controls.Controls.UCPanelTitle();
            this.label4 = new System.Windows.Forms.Label();
            this.tempvalue_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pffengji_status_label = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pffengji_status_pbox = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.paifeng_stop_btn = new System.Windows.Forms.Button();
            this.paifeng_start_btn = new System.Windows.Forms.Button();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.ucPanelTitle1 = new HZH_Controls.Controls.UCPanelTitle();
            this.sffengji_status_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sffengji_pbox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sonfeng_stop_btn = new System.Windows.Forms.Button();
            this.sonfeng_start_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.ucPanelTitle2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pffengji_status_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.ucPanelTitle1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sffengji_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucPanelTitle2);
            this.panel1.Controls.Add(this.ucPanelTitle1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 553);
            this.panel1.TabIndex = 0;
            // 
            // ucPanelTitle2
            // 
            this.ucPanelTitle2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanelTitle2.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.ucPanelTitle2.ConerRadius = 10;
            this.ucPanelTitle2.Controls.Add(this.label4);
            this.ucPanelTitle2.Controls.Add(this.tempvalue_label);
            this.ucPanelTitle2.Controls.Add(this.label1);
            this.ucPanelTitle2.Controls.Add(this.pffengji_status_label);
            this.ucPanelTitle2.Controls.Add(this.label25);
            this.ucPanelTitle2.Controls.Add(this.pffengji_status_pbox);
            this.ucPanelTitle2.Controls.Add(this.label26);
            this.ucPanelTitle2.Controls.Add(this.paifeng_stop_btn);
            this.ucPanelTitle2.Controls.Add(this.paifeng_start_btn);
            this.ucPanelTitle2.Controls.Add(this.pictureBox12);
            this.ucPanelTitle2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelTitle2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ucPanelTitle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ucPanelTitle2.IsCanExpand = false;
            this.ucPanelTitle2.IsExpand = false;
            this.ucPanelTitle2.IsRadius = true;
            this.ucPanelTitle2.IsShowRect = true;
            this.ucPanelTitle2.Location = new System.Drawing.Point(0, 292);
            this.ucPanelTitle2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPanelTitle2.Name = "ucPanelTitle2";
            this.ucPanelTitle2.Padding = new System.Windows.Forms.Padding(1);
            this.ucPanelTitle2.RectColor = System.Drawing.Color.DarkSlateBlue;
            this.ucPanelTitle2.RectWidth = 1;
            this.ucPanelTitle2.Size = new System.Drawing.Size(982, 261);
            this.ucPanelTitle2.TabIndex = 6;
            this.ucPanelTitle2.Title = "强冷排风机";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "℃";
            // 
            // tempvalue_label
            // 
            this.tempvalue_label.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tempvalue_label.ForeColor = System.Drawing.Color.Cyan;
            this.tempvalue_label.Location = new System.Drawing.Point(266, 150);
            this.tempvalue_label.Name = "tempvalue_label";
            this.tempvalue_label.Size = new System.Drawing.Size(78, 31);
            this.tempvalue_label.TabIndex = 30;
            this.tempvalue_label.Text = "--";
            this.tempvalue_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "反馈温度";
            // 
            // pffengji_status_label
            // 
            this.pffengji_status_label.AutoSize = true;
            this.pffengji_status_label.ForeColor = System.Drawing.Color.Gray;
            this.pffengji_status_label.Location = new System.Drawing.Point(270, 112);
            this.pffengji_status_label.Name = "pffengji_status_label";
            this.pffengji_status_label.Size = new System.Drawing.Size(21, 19);
            this.pffengji_status_label.TabIndex = 28;
            this.pffengji_status_label.Text = "--";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(173, 112);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 19);
            this.label25.TabIndex = 17;
            this.label25.Text = "循环风机状态";
            // 
            // pffengji_status_pbox
            // 
            this.pffengji_status_pbox.BackgroundImage = global::xuchengzhineng.Properties.Resources.gg;
            this.pffengji_status_pbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pffengji_status_pbox.Location = new System.Drawing.Point(309, 107);
            this.pffengji_status_pbox.Name = "pffengji_status_pbox";
            this.pffengji_status_pbox.Size = new System.Drawing.Size(30, 30);
            this.pffengji_status_pbox.TabIndex = 14;
            this.pffengji_status_pbox.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(186, 59);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 19);
            this.label26.TabIndex = 11;
            this.label26.Text = "强冷排风机";
            // 
            // paifeng_stop_btn
            // 
            this.paifeng_stop_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.paifeng_stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paifeng_stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.paifeng_stop_btn.FlatAppearance.BorderSize = 0;
            this.paifeng_stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paifeng_stop_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.paifeng_stop_btn.Image = global::xuchengzhineng.Properties.Resources.stop;
            this.paifeng_stop_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paifeng_stop_btn.Location = new System.Drawing.Point(353, 53);
            this.paifeng_stop_btn.Name = "paifeng_stop_btn";
            this.paifeng_stop_btn.Size = new System.Drawing.Size(75, 29);
            this.paifeng_stop_btn.TabIndex = 3;
            this.paifeng_stop_btn.Text = "停止";
            this.paifeng_stop_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.paifeng_stop_btn.UseVisualStyleBackColor = false;
            this.paifeng_stop_btn.Click += new System.EventHandler(this.paifeng_stop_btn_Click);
            // 
            // paifeng_start_btn
            // 
            this.paifeng_start_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.paifeng_start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paifeng_start_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.paifeng_start_btn.FlatAppearance.BorderSize = 0;
            this.paifeng_start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paifeng_start_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.paifeng_start_btn.Image = global::xuchengzhineng.Properties.Resources.start;
            this.paifeng_start_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paifeng_start_btn.Location = new System.Drawing.Point(273, 53);
            this.paifeng_start_btn.Name = "paifeng_start_btn";
            this.paifeng_start_btn.Size = new System.Drawing.Size(74, 29);
            this.paifeng_start_btn.TabIndex = 2;
            this.paifeng_start_btn.Text = "启动";
            this.paifeng_start_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.paifeng_start_btn.UseVisualStyleBackColor = false;
            this.paifeng_start_btn.Click += new System.EventHandler(this.paifeng_start_btn_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(12, 49);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(152, 125);
            this.pictureBox12.TabIndex = 1;
            this.pictureBox12.TabStop = false;
            // 
            // ucPanelTitle1
            // 
            this.ucPanelTitle1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanelTitle1.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.ucPanelTitle1.ConerRadius = 10;
            this.ucPanelTitle1.Controls.Add(this.sffengji_status_label);
            this.ucPanelTitle1.Controls.Add(this.label3);
            this.ucPanelTitle1.Controls.Add(this.sffengji_pbox);
            this.ucPanelTitle1.Controls.Add(this.label8);
            this.ucPanelTitle1.Controls.Add(this.sonfeng_stop_btn);
            this.ucPanelTitle1.Controls.Add(this.sonfeng_start_btn);
            this.ucPanelTitle1.Controls.Add(this.pictureBox1);
            this.ucPanelTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanelTitle1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ucPanelTitle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ucPanelTitle1.IsCanExpand = false;
            this.ucPanelTitle1.IsExpand = false;
            this.ucPanelTitle1.IsRadius = true;
            this.ucPanelTitle1.IsShowRect = true;
            this.ucPanelTitle1.Location = new System.Drawing.Point(0, 0);
            this.ucPanelTitle1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPanelTitle1.Name = "ucPanelTitle1";
            this.ucPanelTitle1.Padding = new System.Windows.Forms.Padding(1);
            this.ucPanelTitle1.RectColor = System.Drawing.Color.DarkSlateBlue;
            this.ucPanelTitle1.RectWidth = 1;
            this.ucPanelTitle1.Size = new System.Drawing.Size(982, 292);
            this.ucPanelTitle1.TabIndex = 5;
            this.ucPanelTitle1.Title = "强冷送风机";
            // 
            // sffengji_status_label
            // 
            this.sffengji_status_label.AutoSize = true;
            this.sffengji_status_label.ForeColor = System.Drawing.Color.Gray;
            this.sffengji_status_label.Location = new System.Drawing.Point(278, 110);
            this.sffengji_status_label.Name = "sffengji_status_label";
            this.sffengji_status_label.Size = new System.Drawing.Size(21, 19);
            this.sffengji_status_label.TabIndex = 27;
            this.sffengji_status_label.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "循环风机状态:";
            // 
            // sffengji_pbox
            // 
            this.sffengji_pbox.BackgroundImage = global::xuchengzhineng.Properties.Resources.gg;
            this.sffengji_pbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sffengji_pbox.Location = new System.Drawing.Point(314, 104);
            this.sffengji_pbox.Name = "sffengji_pbox";
            this.sffengji_pbox.Size = new System.Drawing.Size(30, 30);
            this.sffengji_pbox.TabIndex = 14;
            this.sffengji_pbox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "强冷送风机";
            // 
            // sonfeng_stop_btn
            // 
            this.sonfeng_stop_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.sonfeng_stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sonfeng_stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sonfeng_stop_btn.FlatAppearance.BorderSize = 0;
            this.sonfeng_stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sonfeng_stop_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.sonfeng_stop_btn.Image = global::xuchengzhineng.Properties.Resources.stop;
            this.sonfeng_stop_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sonfeng_stop_btn.Location = new System.Drawing.Point(353, 53);
            this.sonfeng_stop_btn.Name = "sonfeng_stop_btn";
            this.sonfeng_stop_btn.Size = new System.Drawing.Size(75, 29);
            this.sonfeng_stop_btn.TabIndex = 3;
            this.sonfeng_stop_btn.Text = "停止";
            this.sonfeng_stop_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sonfeng_stop_btn.UseVisualStyleBackColor = false;
            this.sonfeng_stop_btn.Click += new System.EventHandler(this.sonfeng_stop_btn_Click);
            // 
            // sonfeng_start_btn
            // 
            this.sonfeng_start_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.sonfeng_start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sonfeng_start_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sonfeng_start_btn.FlatAppearance.BorderSize = 0;
            this.sonfeng_start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sonfeng_start_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.sonfeng_start_btn.Image = global::xuchengzhineng.Properties.Resources.start;
            this.sonfeng_start_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sonfeng_start_btn.Location = new System.Drawing.Point(273, 53);
            this.sonfeng_start_btn.Name = "sonfeng_start_btn";
            this.sonfeng_start_btn.Size = new System.Drawing.Size(74, 29);
            this.sonfeng_start_btn.TabIndex = 2;
            this.sonfeng_start_btn.Text = "启动";
            this.sonfeng_start_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sonfeng_start_btn.UseVisualStyleBackColor = false;
            this.sonfeng_start_btn.Click += new System.EventHandler(this.sonfeng_start_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 125);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer_refresh
            // 
            this.timer_refresh.Interval = 1000;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // qianglen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel1);
            this.Name = "qianglen";
            this.Text = "强冷";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.qianglen_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ucPanelTitle2.ResumeLayout(false);
            this.ucPanelTitle2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pffengji_status_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ucPanelTitle1.ResumeLayout(false);
            this.ucPanelTitle1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sffengji_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private HZH_Controls.Controls.UCPanelTitle ucPanelTitle2;
        private System.Windows.Forms.Label pffengji_status_label;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox pffengji_status_pbox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button paifeng_stop_btn;
        private System.Windows.Forms.Button paifeng_start_btn;
        private System.Windows.Forms.PictureBox pictureBox12;
        private HZH_Controls.Controls.UCPanelTitle ucPanelTitle1;
        private System.Windows.Forms.Label sffengji_status_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox sffengji_pbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sonfeng_stop_btn;
        private System.Windows.Forms.Button sonfeng_start_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tempvalue_label;
    }
}