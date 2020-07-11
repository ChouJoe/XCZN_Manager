namespace xuchengzhineng.userControl
{
    partial class led
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
            this.ledbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ledbox)).BeginInit();
            this.SuspendLayout();
            // 
            // ledbox
            // 
            this.ledbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ledbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledbox.Location = new System.Drawing.Point(0, 0);
            this.ledbox.Name = "ledbox";
            this.ledbox.Size = new System.Drawing.Size(39, 39);
            this.ledbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledbox.TabIndex = 0;
            this.ledbox.TabStop = false;
            // 
            // led
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ledbox);
            this.Name = "led";
            this.Size = new System.Drawing.Size(39, 39);
            ((System.ComponentModel.ISupportInitialize)(this.ledbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ledbox;
    }
}
