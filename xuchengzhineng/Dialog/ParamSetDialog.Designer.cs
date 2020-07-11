namespace xuchengzhineng.Dialog
{
    partial class ParamSetDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Setparam = new System.Windows.Forms.Button();
            this.label_CurParamValue = new System.Windows.Forms.Label();
            this.textBox_SetParamValue = new System.Windows.Forms.TextBox();
            this.textBox_SetOffset = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_ParamName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前值:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "设定值:";
            // 
            // btn_Setparam
            // 
            this.btn_Setparam.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Setparam.Location = new System.Drawing.Point(196, 207);
            this.btn_Setparam.Name = "btn_Setparam";
            this.btn_Setparam.Size = new System.Drawing.Size(75, 23);
            this.btn_Setparam.TabIndex = 2;
            this.btn_Setparam.Text = "写入";
            this.btn_Setparam.UseVisualStyleBackColor = true;
            this.btn_Setparam.Click += new System.EventHandler(this.btn_Setparam_Click);
            // 
            // label_CurParamValue
            // 
            this.label_CurParamValue.AutoSize = true;
            this.label_CurParamValue.Location = new System.Drawing.Point(138, 62);
            this.label_CurParamValue.Name = "label_CurParamValue";
            this.label_CurParamValue.Size = new System.Drawing.Size(0, 15);
            this.label_CurParamValue.TabIndex = 3;
            // 
            // textBox_SetParamValue
            // 
            this.textBox_SetParamValue.Location = new System.Drawing.Point(130, 103);
            this.textBox_SetParamValue.Name = "textBox_SetParamValue";
            this.textBox_SetParamValue.Size = new System.Drawing.Size(100, 25);
            this.textBox_SetParamValue.TabIndex = 4;
            // 
            // textBox_SetOffset
            // 
            this.textBox_SetOffset.Location = new System.Drawing.Point(130, 148);
            this.textBox_SetOffset.Name = "textBox_SetOffset";
            this.textBox_SetOffset.Size = new System.Drawing.Size(100, 25);
            this.textBox_SetOffset.TabIndex = 6;
            this.textBox_SetOffset.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "偏差报警值:";
            this.label3.Visible = false;
            // 
            // label_ParamName
            // 
            this.label_ParamName.AutoSize = true;
            this.label_ParamName.Location = new System.Drawing.Point(138, 22);
            this.label_ParamName.Name = "label_ParamName";
            this.label_ParamName.Size = new System.Drawing.Size(0, 15);
            this.label_ParamName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "参数名:";
            // 
            // ParamSetDialog
            // 
            this.AcceptButton = this.btn_Setparam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 253);
            this.Controls.Add(this.label_ParamName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_SetOffset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_SetParamValue);
            this.Controls.Add(this.label_CurParamValue);
            this.Controls.Add(this.btn_Setparam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ParamSetDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "参数修改";
            this.Shown += new System.EventHandler(this.ParamSetDialog_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Setparam;
        private System.Windows.Forms.Label label_CurParamValue;
        private System.Windows.Forms.TextBox textBox_SetParamValue;
        private System.Windows.Forms.TextBox textBox_SetOffset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ParamName;
        private System.Windows.Forms.Label label5;
    }
}