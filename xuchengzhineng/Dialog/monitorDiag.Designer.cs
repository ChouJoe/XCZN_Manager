namespace xuchengzhineng.Dialog
{
    partial class monitorDiag
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
            this.dataGridView_monitor = new System.Windows.Forms.DataGridView();
            this.variableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_VarRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_monitor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_monitor
            // 
            this.dataGridView_monitor.AllowUserToAddRows = false;
            this.dataGridView_monitor.AllowUserToDeleteRows = false;
            this.dataGridView_monitor.AllowUserToResizeRows = false;
            this.dataGridView_monitor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_monitor.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_monitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_monitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.variableName,
            this.value,
            this.unit});
            this.dataGridView_monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_monitor.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_monitor.Name = "dataGridView_monitor";
            this.dataGridView_monitor.ReadOnly = true;
            this.dataGridView_monitor.RowHeadersVisible = false;
            this.dataGridView_monitor.RowTemplate.Height = 27;
            this.dataGridView_monitor.Size = new System.Drawing.Size(693, 269);
            this.dataGridView_monitor.TabIndex = 0;
            // 
            // variableName
            // 
            this.variableName.DataPropertyName = "Name";
            this.variableName.HeaderText = "名称";
            this.variableName.Name = "variableName";
            this.variableName.ReadOnly = true;
            this.variableName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // value
            // 
            this.value.DataPropertyName = "Value";
            this.value.HeaderText = "值";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "Unit";
            this.unit.HeaderText = "单位";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // timer_VarRefresh
            // 
            this.timer_VarRefresh.Interval = 1000;
            this.timer_VarRefresh.Tick += new System.EventHandler(this.timer_VarRefresh_Tick);
            // 
            // monitorDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 269);
            this.Controls.Add(this.dataGridView_monitor);
            this.Name = "monitorDiag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "变量窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.monitorDiag_FormClosing);
            this.Shown += new System.EventHandler(this.monitorDiag_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_monitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_monitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn variableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.Timer timer_VarRefresh;
    }
}