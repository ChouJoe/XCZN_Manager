namespace xuchengzhineng.Menu
{
    partial class reshuilu
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
            this.label26 = new System.Windows.Forms.Label();
            this.warming_stop_btn = new System.Windows.Forms.Button();
            this.warming_start_btn = new System.Windows.Forms.Button();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.ucPanelTitle1 = new HZH_Controls.Controls.UCPanelTitle();
            this.maxfire_stop_btn = new System.Windows.Forms.Button();
            this.maxfire_start_btn = new System.Windows.Forms.Button();
            this.minfire_stop_btn = new System.Windows.Forms.Button();
            this.minfire_start_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maxfire_status_label = new System.Windows.Forms.Label();
            this.minfire_status_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minfire_pbox = new System.Windows.Forms.PictureBox();
            this.maxfire_pbox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.temp_set_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.temp_set_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tempvalue_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.burn_stop_btn = new System.Windows.Forms.Button();
            this.burn_start_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.ucPanelTitle2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.ucPanelTitle1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minfire_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxfire_pbox)).BeginInit();
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
            this.ucPanelTitle2.Controls.Add(this.label26);
            this.ucPanelTitle2.Controls.Add(this.warming_stop_btn);
            this.ucPanelTitle2.Controls.Add(this.warming_start_btn);
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
            this.ucPanelTitle2.TabIndex = 3;
            this.ucPanelTitle2.Title = "循环加热泵";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(182, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(48, 19);
            this.label26.TabIndex = 11;
            this.label26.Text = "加热泵";
            // 
            // warming_stop_btn
            // 
            this.warming_stop_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.warming_stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.warming_stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.warming_stop_btn.FlatAppearance.BorderSize = 0;
            this.warming_stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.warming_stop_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.warming_stop_btn.Image = global::xuchengzhineng.Properties.Resources.stop;
            this.warming_stop_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warming_stop_btn.Location = new System.Drawing.Point(333, 53);
            this.warming_stop_btn.Name = "warming_stop_btn";
            this.warming_stop_btn.Size = new System.Drawing.Size(75, 29);
            this.warming_stop_btn.TabIndex = 3;
            this.warming_stop_btn.Text = "停止";
            this.warming_stop_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.warming_stop_btn.UseVisualStyleBackColor = false;
            this.warming_stop_btn.Click += new System.EventHandler(this.warming_stop_btn_Click);
            // 
            // warming_start_btn
            // 
            this.warming_start_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.warming_start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.warming_start_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.warming_start_btn.FlatAppearance.BorderSize = 0;
            this.warming_start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.warming_start_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.warming_start_btn.Image = global::xuchengzhineng.Properties.Resources.start;
            this.warming_start_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.warming_start_btn.Location = new System.Drawing.Point(253, 53);
            this.warming_start_btn.Name = "warming_start_btn";
            this.warming_start_btn.Size = new System.Drawing.Size(74, 29);
            this.warming_start_btn.TabIndex = 2;
            this.warming_start_btn.Text = "启动";
            this.warming_start_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.warming_start_btn.UseVisualStyleBackColor = false;
            this.warming_start_btn.Click += new System.EventHandler(this.warming_start_btn_Click);
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
            this.ucPanelTitle1.Controls.Add(this.maxfire_stop_btn);
            this.ucPanelTitle1.Controls.Add(this.maxfire_start_btn);
            this.ucPanelTitle1.Controls.Add(this.minfire_stop_btn);
            this.ucPanelTitle1.Controls.Add(this.minfire_start_btn);
            this.ucPanelTitle1.Controls.Add(this.label9);
            this.ucPanelTitle1.Controls.Add(this.label7);
            this.ucPanelTitle1.Controls.Add(this.maxfire_status_label);
            this.ucPanelTitle1.Controls.Add(this.minfire_status_label);
            this.ucPanelTitle1.Controls.Add(this.label6);
            this.ucPanelTitle1.Controls.Add(this.label3);
            this.ucPanelTitle1.Controls.Add(this.minfire_pbox);
            this.ucPanelTitle1.Controls.Add(this.maxfire_pbox);
            this.ucPanelTitle1.Controls.Add(this.label8);
            this.ucPanelTitle1.Controls.Add(this.temp_set_btn);
            this.ucPanelTitle1.Controls.Add(this.label5);
            this.ucPanelTitle1.Controls.Add(this.temp_set_textbox);
            this.ucPanelTitle1.Controls.Add(this.label4);
            this.ucPanelTitle1.Controls.Add(this.tempvalue_label);
            this.ucPanelTitle1.Controls.Add(this.label2);
            this.ucPanelTitle1.Controls.Add(this.label1);
            this.ucPanelTitle1.Controls.Add(this.burn_stop_btn);
            this.ucPanelTitle1.Controls.Add(this.burn_start_btn);
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
            this.ucPanelTitle1.TabIndex = 2;
            this.ucPanelTitle1.Title = "热水炉燃烧机";
            // 
            // maxfire_stop_btn
            // 
            this.maxfire_stop_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.maxfire_stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maxfire_stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.maxfire_stop_btn.FlatAppearance.BorderSize = 0;
            this.maxfire_stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.maxfire_stop_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.maxfire_stop_btn.Image = global::xuchengzhineng.Properties.Resources.stop;
            this.maxfire_stop_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maxfire_stop_btn.Location = new System.Drawing.Point(333, 91);
            this.maxfire_stop_btn.Name = "maxfire_stop_btn";
            this.maxfire_stop_btn.Size = new System.Drawing.Size(75, 29);
            this.maxfire_stop_btn.TabIndex = 33;
            this.maxfire_stop_btn.Text = "停止";
            this.maxfire_stop_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maxfire_stop_btn.UseVisualStyleBackColor = false;
            this.maxfire_stop_btn.Click += new System.EventHandler(this.maxfire_stop_btn_Click);
            // 
            // maxfire_start_btn
            // 
            this.maxfire_start_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.maxfire_start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maxfire_start_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.maxfire_start_btn.FlatAppearance.BorderSize = 0;
            this.maxfire_start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.maxfire_start_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.maxfire_start_btn.Image = global::xuchengzhineng.Properties.Resources.start;
            this.maxfire_start_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maxfire_start_btn.Location = new System.Drawing.Point(253, 91);
            this.maxfire_start_btn.Name = "maxfire_start_btn";
            this.maxfire_start_btn.Size = new System.Drawing.Size(74, 29);
            this.maxfire_start_btn.TabIndex = 32;
            this.maxfire_start_btn.Text = "启动";
            this.maxfire_start_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.maxfire_start_btn.UseVisualStyleBackColor = false;
            this.maxfire_start_btn.Click += new System.EventHandler(this.maxfire_start_btn_Click);
            // 
            // minfire_stop_btn
            // 
            this.minfire_stop_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.minfire_stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minfire_stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minfire_stop_btn.FlatAppearance.BorderSize = 0;
            this.minfire_stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minfire_stop_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.minfire_stop_btn.Image = global::xuchengzhineng.Properties.Resources.stop;
            this.minfire_stop_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minfire_stop_btn.Location = new System.Drawing.Point(332, 132);
            this.minfire_stop_btn.Name = "minfire_stop_btn";
            this.minfire_stop_btn.Size = new System.Drawing.Size(75, 29);
            this.minfire_stop_btn.TabIndex = 31;
            this.minfire_stop_btn.Text = "停止";
            this.minfire_stop_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minfire_stop_btn.UseVisualStyleBackColor = false;
            this.minfire_stop_btn.Click += new System.EventHandler(this.minfire_stop_btn_Click);
            // 
            // minfire_start_btn
            // 
            this.minfire_start_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.minfire_start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minfire_start_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minfire_start_btn.FlatAppearance.BorderSize = 0;
            this.minfire_start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minfire_start_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.minfire_start_btn.Image = global::xuchengzhineng.Properties.Resources.start;
            this.minfire_start_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minfire_start_btn.Location = new System.Drawing.Point(252, 132);
            this.minfire_start_btn.Name = "minfire_start_btn";
            this.minfire_start_btn.Size = new System.Drawing.Size(74, 29);
            this.minfire_start_btn.TabIndex = 30;
            this.minfire_start_btn.Text = "启动";
            this.minfire_start_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minfire_start_btn.UseVisualStyleBackColor = false;
            this.minfire_start_btn.Click += new System.EventHandler(this.minfire_start_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "小火启动:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "大火启动:";
            // 
            // maxfire_status_label
            // 
            this.maxfire_status_label.AutoSize = true;
            this.maxfire_status_label.ForeColor = System.Drawing.Color.Gray;
            this.maxfire_status_label.Location = new System.Drawing.Point(490, 103);
            this.maxfire_status_label.Name = "maxfire_status_label";
            this.maxfire_status_label.Size = new System.Drawing.Size(21, 19);
            this.maxfire_status_label.TabIndex = 27;
            this.maxfire_status_label.Text = "--";
            // 
            // minfire_status_label
            // 
            this.minfire_status_label.AutoSize = true;
            this.minfire_status_label.ForeColor = System.Drawing.Color.Gray;
            this.minfire_status_label.Location = new System.Drawing.Point(490, 139);
            this.minfire_status_label.Name = "minfire_status_label";
            this.minfire_status_label.Size = new System.Drawing.Size(21, 19);
            this.minfire_status_label.TabIndex = 26;
            this.minfire_status_label.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "小火反馈:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "大火反馈:";
            // 
            // minfire_pbox
            // 
            this.minfire_pbox.BackgroundImage = global::xuchengzhineng.Properties.Resources.gg;
            this.minfire_pbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minfire_pbox.Location = new System.Drawing.Point(526, 133);
            this.minfire_pbox.Name = "minfire_pbox";
            this.minfire_pbox.Size = new System.Drawing.Size(30, 30);
            this.minfire_pbox.TabIndex = 15;
            this.minfire_pbox.TabStop = false;
            // 
            // maxfire_pbox
            // 
            this.maxfire_pbox.BackgroundImage = global::xuchengzhineng.Properties.Resources.gg;
            this.maxfire_pbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maxfire_pbox.Location = new System.Drawing.Point(526, 97);
            this.maxfire_pbox.Name = "maxfire_pbox";
            this.maxfire_pbox.Size = new System.Drawing.Size(30, 30);
            this.maxfire_pbox.TabIndex = 14;
            this.maxfire_pbox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "燃烧机";
            // 
            // temp_set_btn
            // 
            this.temp_set_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.temp_set_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.temp_set_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.temp_set_btn.FlatAppearance.BorderSize = 0;
            this.temp_set_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.temp_set_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.temp_set_btn.Image = global::xuchengzhineng.Properties.Resources.write1png;
            this.temp_set_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.temp_set_btn.Location = new System.Drawing.Point(333, 176);
            this.temp_set_btn.Name = "temp_set_btn";
            this.temp_set_btn.Size = new System.Drawing.Size(74, 29);
            this.temp_set_btn.TabIndex = 10;
            this.temp_set_btn.Text = "设置";
            this.temp_set_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.temp_set_btn.UseVisualStyleBackColor = false;
            this.temp_set_btn.Click += new System.EventHandler(this.temp_set_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "(0~90℃)";
            // 
            // temp_set_textbox
            // 
            this.temp_set_textbox.Location = new System.Drawing.Point(252, 176);
            this.temp_set_textbox.Name = "temp_set_textbox";
            this.temp_set_textbox.Size = new System.Drawing.Size(74, 23);
            this.temp_set_textbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "℃";
            // 
            // tempvalue_label
            // 
            this.tempvalue_label.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tempvalue_label.ForeColor = System.Drawing.Color.Cyan;
            this.tempvalue_label.Location = new System.Drawing.Point(489, 172);
            this.tempvalue_label.Name = "tempvalue_label";
            this.tempvalue_label.Size = new System.Drawing.Size(78, 31);
            this.tempvalue_label.TabIndex = 6;
            this.tempvalue_label.Text = "--";
            this.tempvalue_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "反馈温度:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "设定温度:";
            // 
            // burn_stop_btn
            // 
            this.burn_stop_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.burn_stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.burn_stop_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.burn_stop_btn.FlatAppearance.BorderSize = 0;
            this.burn_stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.burn_stop_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.burn_stop_btn.Image = global::xuchengzhineng.Properties.Resources.stop;
            this.burn_stop_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.burn_stop_btn.Location = new System.Drawing.Point(333, 53);
            this.burn_stop_btn.Name = "burn_stop_btn";
            this.burn_stop_btn.Size = new System.Drawing.Size(75, 29);
            this.burn_stop_btn.TabIndex = 3;
            this.burn_stop_btn.Text = "停止";
            this.burn_stop_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.burn_stop_btn.UseVisualStyleBackColor = false;
            this.burn_stop_btn.Click += new System.EventHandler(this.burn_stop_btn_Click);
            // 
            // burn_start_btn
            // 
            this.burn_start_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.burn_start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.burn_start_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.burn_start_btn.FlatAppearance.BorderSize = 0;
            this.burn_start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.burn_start_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.burn_start_btn.Image = global::xuchengzhineng.Properties.Resources.start;
            this.burn_start_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.burn_start_btn.Location = new System.Drawing.Point(253, 53);
            this.burn_start_btn.Name = "burn_start_btn";
            this.burn_start_btn.Size = new System.Drawing.Size(74, 29);
            this.burn_start_btn.TabIndex = 2;
            this.burn_start_btn.Text = "启动";
            this.burn_start_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.burn_start_btn.UseVisualStyleBackColor = false;
            this.burn_start_btn.Click += new System.EventHandler(this.burn_start_btn_Click);
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
            // reshuilu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel1);
            this.Name = "reshuilu";
            this.Text = "热水炉";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.reshuilu_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ucPanelTitle2.ResumeLayout(false);
            this.ucPanelTitle2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ucPanelTitle1.ResumeLayout(false);
            this.ucPanelTitle1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minfire_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxfire_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer_refresh;
        private HZH_Controls.Controls.UCPanelTitle ucPanelTitle1;
        private System.Windows.Forms.Label maxfire_status_label;
        private System.Windows.Forms.Label minfire_status_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox minfire_pbox;
        private System.Windows.Forms.PictureBox maxfire_pbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button temp_set_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox temp_set_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tempvalue_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button burn_stop_btn;
        private System.Windows.Forms.Button burn_start_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private HZH_Controls.Controls.UCPanelTitle ucPanelTitle2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button warming_stop_btn;
        private System.Windows.Forms.Button warming_start_btn;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Button maxfire_stop_btn;
        private System.Windows.Forms.Button maxfire_start_btn;
        private System.Windows.Forms.Button minfire_stop_btn;
        private System.Windows.Forms.Button minfire_start_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}