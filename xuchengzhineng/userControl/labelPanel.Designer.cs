namespace xuchengzhineng.userControl
{
    partial class labelPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Des = new System.Windows.Forms.TextBox();
            this.Val = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Des
            // 
            this.Des.Dock = System.Windows.Forms.DockStyle.Top;
            this.Des.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Des.Location = new System.Drawing.Point(0, 0);
            this.Des.Name = "Des";
            this.Des.ReadOnly = true;
            this.Des.Size = new System.Drawing.Size(146, 27);
            this.Des.TabIndex = 0;
            this.Des.Text = "Des";
            this.Des.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Val
            // 
            this.Val.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Val.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Val.Location = new System.Drawing.Point(0, 27);
            this.Val.Name = "Val";
            this.Val.ReadOnly = true;
            this.Val.Size = new System.Drawing.Size(146, 27);
            this.Val.TabIndex = 1;
            this.Val.Text = "value";
            this.Val.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Val);
            this.Controls.Add(this.Des);
            this.Name = "labelPanel";
            this.Size = new System.Drawing.Size(146, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Des;
        private System.Windows.Forms.TextBox Val;
    }
}
