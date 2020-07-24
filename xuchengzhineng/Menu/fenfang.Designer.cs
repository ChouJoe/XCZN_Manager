namespace xuchengzhineng.Menu
{
    partial class fenfang
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
            this.mianfeng_status_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mianfeng_status_pbox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mianfeng_stop_btn = new System.Windows.Forms.Button();
            this.mianfeng_start_btn = new System.Windows.Forms.Button();
            this.difeng_status_label = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.difeng_status_pbox = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.difeng_stop_btn = new System.Windows.Forms.Button();
            this.difeng_start_btn = new System.Windows.Forms.Button();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.ucPanelTitle2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mianfeng_status_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difeng_status_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucPanelTitle2);
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
            this.ucPanelTitle2.Controls.Add(this.mianfeng_status_label);
            this.ucPanelTitle2.Controls.Add(this.label2);
            this.ucPanelTitle2.Controls.Add(this.mianfeng_status_pbox);
            this.ucPanelTitle2.Controls.Add(this.label3);
            this.ucPanelTitle2.Controls.Add(this.mianfeng_stop_btn);
            this.ucPanelTitle2.Controls.Add(this.mianfeng_start_btn);
            this.ucPanelTitle2.Controls.Add(this.difeng_status_label);
            this.ucPanelTitle2.Controls.Add(this.label25);
            this.ucPanelTitle2.Controls.Add(this.difeng_status_pbox);
            this.ucPanelTitle2.Controls.Add(this.label26);
            this.ucPanelTitle2.Controls.Add(this.difeng_stop_btn);
            this.ucPanelTitle2.Controls.Add(this.difeng_start_btn);
            this.ucPanelTitle2.Controls.Add(this.pictureBox12);
            this.ucPanelTitle2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelTitle2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ucPanelTitle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ucPanelTitle2.IsCanExpand = false;
            this.ucPanelTitle2.IsExpand = false;
            this.ucPanelTitle2.IsRadius = true;
            this.ucPanelTitle2.IsShowRect = true;
            this.ucPanelTitle2.Location = new System.Drawing.Point(0, 0);
            this.ucPanelTitle2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPanelTitle2.Name = "ucPanelTitle2";
            this.ucPanelTitle2.Padding = new System.Windows.Forms.Padding(1);
            this.ucPanelTitle2.RectColor = System.Drawing.Color.DarkSlateBlue;
            this.ucPanelTitle2.RectWidth = 1;
            this.ucPanelTitle2.Size = new System.Drawing.Size(982, 553);
            this.ucPanelTitle2.TabIndex = 5;
            this.ucPanelTitle2.Title = "粉房";
            // 
            // mianfeng_status_label
            // 
            this.mianfeng_status_label.AutoSize = true;
            this.mianfeng_status_label.ForeColor = System.Drawing.Color.Gray;
            this.mianfeng_status_label.Location = new System.Drawing.Point(507, 104);
            this.mianfeng_status_label.Name = "mianfeng_status_label";
            this.mianfeng_status_label.Size = new System.Drawing.Size(21, 19);
            this.mianfeng_status_label.TabIndex = 34;
            this.mianfeng_status_label.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "面粉运行反馈";
            // 
            // mianfeng_status_pbox
            // 
            this.mianfeng_status_pbox.BackgroundImage = global::xuchengzhineng.Properties.Resources.gg;
            this.mianfeng_status_pbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mianfeng_status_pbox.Location = new System.Drawing.Point(537, 98);
            this.mianfeng_status_pbox.Name = "mianfeng_status_pbox";
            this.mianfeng_status_pbox.Size = new System.Drawing.Size(30, 30);
            this.mianfeng_status_pbox.TabIndex = 32;
            this.mianfeng_status_pbox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "面粉";
            // 
            // mianfeng_stop_btn
            // 
            this.mianfeng_stop_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.mianfeng_stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mianfeng_stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mianfeng_stop_btn.FlatAppearance.BorderSize = 0;
            this.mianfeng_stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mianfeng_stop_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.mianfeng_stop_btn.Image = global::xuchengzhineng.Properties.Resources.stop;
            this.mianfeng_stop_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mianfeng_stop_btn.Location = new System.Drawing.Point(333, 98);
            this.mianfeng_stop_btn.Name = "mianfeng_stop_btn";
            this.mianfeng_stop_btn.Size = new System.Drawing.Size(75, 29);
            this.mianfeng_stop_btn.TabIndex = 30;
            this.mianfeng_stop_btn.Text = "停止";
            this.mianfeng_stop_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mianfeng_stop_btn.UseVisualStyleBackColor = false;
            this.mianfeng_stop_btn.Click += new System.EventHandler(this.mianfeng_stop_btn_Click);
            // 
            // mianfeng_start_btn
            // 
            this.mianfeng_start_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.mianfeng_start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mianfeng_start_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mianfeng_start_btn.FlatAppearance.BorderSize = 0;
            this.mianfeng_start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mianfeng_start_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.mianfeng_start_btn.Image = global::xuchengzhineng.Properties.Resources.start;
            this.mianfeng_start_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mianfeng_start_btn.Location = new System.Drawing.Point(253, 98);
            this.mianfeng_start_btn.Name = "mianfeng_start_btn";
            this.mianfeng_start_btn.Size = new System.Drawing.Size(74, 29);
            this.mianfeng_start_btn.TabIndex = 29;
            this.mianfeng_start_btn.Text = "启动";
            this.mianfeng_start_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mianfeng_start_btn.UseVisualStyleBackColor = false;
            this.mianfeng_start_btn.Click += new System.EventHandler(this.mianfeng_start_btn_Click);
            // 
            // difeng_status_label
            // 
            this.difeng_status_label.AutoSize = true;
            this.difeng_status_label.ForeColor = System.Drawing.Color.Gray;
            this.difeng_status_label.Location = new System.Drawing.Point(507, 58);
            this.difeng_status_label.Name = "difeng_status_label";
            this.difeng_status_label.Size = new System.Drawing.Size(21, 19);
            this.difeng_status_label.TabIndex = 28;
            this.difeng_status_label.Text = "--";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(417, 57);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 19);
            this.label25.TabIndex = 17;
            this.label25.Text = "底粉运行反馈";
            // 
            // difeng_status_pbox
            // 
            this.difeng_status_pbox.BackgroundImage = global::xuchengzhineng.Properties.Resources.gg;
            this.difeng_status_pbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.difeng_status_pbox.Location = new System.Drawing.Point(537, 52);
            this.difeng_status_pbox.Name = "difeng_status_pbox";
            this.difeng_status_pbox.Size = new System.Drawing.Size(30, 30);
            this.difeng_status_pbox.TabIndex = 14;
            this.difeng_status_pbox.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(182, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 19);
            this.label26.TabIndex = 11;
            this.label26.Text = "底粉";
            // 
            // difeng_stop_btn
            // 
            this.difeng_stop_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.difeng_stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.difeng_stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.difeng_stop_btn.FlatAppearance.BorderSize = 0;
            this.difeng_stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.difeng_stop_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.difeng_stop_btn.Image = global::xuchengzhineng.Properties.Resources.stop;
            this.difeng_stop_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.difeng_stop_btn.Location = new System.Drawing.Point(333, 53);
            this.difeng_stop_btn.Name = "difeng_stop_btn";
            this.difeng_stop_btn.Size = new System.Drawing.Size(75, 29);
            this.difeng_stop_btn.TabIndex = 3;
            this.difeng_stop_btn.Text = "停止";
            this.difeng_stop_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.difeng_stop_btn.UseVisualStyleBackColor = false;
            this.difeng_stop_btn.Click += new System.EventHandler(this.difeng_stop_btn_Click);
            // 
            // difeng_start_btn
            // 
            this.difeng_start_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.difeng_start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.difeng_start_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.difeng_start_btn.FlatAppearance.BorderSize = 0;
            this.difeng_start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.difeng_start_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.difeng_start_btn.Image = global::xuchengzhineng.Properties.Resources.start;
            this.difeng_start_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.difeng_start_btn.Location = new System.Drawing.Point(253, 53);
            this.difeng_start_btn.Name = "difeng_start_btn";
            this.difeng_start_btn.Size = new System.Drawing.Size(74, 29);
            this.difeng_start_btn.TabIndex = 2;
            this.difeng_start_btn.Text = "启动";
            this.difeng_start_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.difeng_start_btn.UseVisualStyleBackColor = false;
            this.difeng_start_btn.Click += new System.EventHandler(this.difeng_start_btn_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(12, 49);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(152, 125);
            this.pictureBox12.TabIndex = 1;
            this.pictureBox12.TabStop = false;
            // 
            // timer_refresh
            // 
            this.timer_refresh.Interval = 1000;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // fenfang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel1);
            this.Name = "fenfang";
            this.Text = "粉房";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fenfang_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ucPanelTitle2.ResumeLayout(false);
            this.ucPanelTitle2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mianfeng_status_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difeng_status_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer_refresh;
        private HZH_Controls.Controls.UCPanelTitle ucPanelTitle2;
        private System.Windows.Forms.Label difeng_status_label;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox difeng_status_pbox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button difeng_stop_btn;
        private System.Windows.Forms.Button difeng_start_btn;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label mianfeng_status_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox mianfeng_status_pbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mianfeng_stop_btn;
        private System.Windows.Forms.Button mianfeng_start_btn;
    }
}