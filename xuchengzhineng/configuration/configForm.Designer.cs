namespace xuchengzhineng.configuration
{
    partial class configForm
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
            this.comboBox_version = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.config_btn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.cur_version_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_version
            // 
            this.comboBox_version.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox_version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_version.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_version.FormattingEnabled = true;
            this.comboBox_version.Location = new System.Drawing.Point(186, 95);
            this.comboBox_version.Name = "comboBox_version";
            this.comboBox_version.Size = new System.Drawing.Size(229, 27);
            this.comboBox_version.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(113, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "固件版本";
            // 
            // config_btn
            // 
            this.config_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.config_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.config_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.config_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.config_btn.ForeColor = System.Drawing.Color.White;
            this.config_btn.Location = new System.Drawing.Point(417, 270);
            this.config_btn.Name = "config_btn";
            this.config_btn.Size = new System.Drawing.Size(75, 33);
            this.config_btn.TabIndex = 2;
            this.config_btn.Text = "ok";
            this.config_btn.UseVisualStyleBackColor = false;
            this.config_btn.Click += new System.EventHandler(this.config_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(113, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "当前版本:";
            // 
            // cur_version_label
            // 
            this.cur_version_label.AutoSize = true;
            this.cur_version_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cur_version_label.ForeColor = System.Drawing.Color.White;
            this.cur_version_label.Location = new System.Drawing.Point(195, 60);
            this.cur_version_label.Name = "cur_version_label";
            this.cur_version_label.Size = new System.Drawing.Size(0, 19);
            this.cur_version_label.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(113, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "连接配置";
            // 
            // connectIP
            // 
            this.connectIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.connectIP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.connectIP.ForeColor = System.Drawing.Color.White;
            this.connectIP.Location = new System.Drawing.Point(186, 136);
            this.connectIP.Name = "connectIP";
            this.connectIP.Size = new System.Drawing.Size(229, 27);
            this.connectIP.TabIndex = 6;
            this.connectIP.Text = "opc.tcp://192.168.0.1:4840";
            // 
            // configForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(516, 315);
            this.Controls.Add(this.connectIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cur_version_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.config_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_version);
            this.Name = "configForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置";
            this.Load += new System.EventHandler(this.configForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_version;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button config_btn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cur_version_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox connectIP;
    }
}