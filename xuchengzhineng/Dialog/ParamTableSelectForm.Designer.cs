namespace xuchengzhineng.Dialog
{
    partial class SelectParamDialog
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
            this.dataGridView1_ParamTable = new System.Windows.Forms.DataGridView();
            this.btn_ParamSelect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_ParamTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1_ParamTable
            // 
            this.dataGridView1_ParamTable.AllowUserToAddRows = false;
            this.dataGridView1_ParamTable.AllowUserToDeleteRows = false;
            this.dataGridView1_ParamTable.AllowUserToResizeRows = false;
            this.dataGridView1_ParamTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_ParamTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1_ParamTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_ParamTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ParamName,
            this.opcName,
            this.Units});
            this.dataGridView1_ParamTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1_ParamTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1_ParamTable.Name = "dataGridView1_ParamTable";
            this.dataGridView1_ParamTable.RowHeadersVisible = false;
            this.dataGridView1_ParamTable.RowTemplate.Height = 27;
            this.dataGridView1_ParamTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_ParamTable.Size = new System.Drawing.Size(728, 238);
            this.dataGridView1_ParamTable.TabIndex = 0;
            // 
            // btn_ParamSelect
            // 
            this.btn_ParamSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ParamSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ParamSelect.Location = new System.Drawing.Point(583, 9);
            this.btn_ParamSelect.Name = "btn_ParamSelect";
            this.btn_ParamSelect.Size = new System.Drawing.Size(75, 23);
            this.btn_ParamSelect.TabIndex = 1;
            this.btn_ParamSelect.Text = "确认";
            this.btn_ParamSelect.UseVisualStyleBackColor = true;
            this.btn_ParamSelect.Click += new System.EventHandler(this.btn_ParamSelect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ParamSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 44);
            this.panel1.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.FillWeight = 22.13449F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ParamName
            // 
            this.ParamName.FillWeight = 88.79031F;
            this.ParamName.HeaderText = "参数名";
            this.ParamName.Name = "ParamName";
            this.ParamName.ReadOnly = true;
            // 
            // opcName
            // 
            this.opcName.FillWeight = 86.0295F;
            this.opcName.HeaderText = "PLC参数名";
            this.opcName.Name = "opcName";
            this.opcName.ReadOnly = true;
            // 
            // Units
            // 
            this.Units.FillWeight = 203.0457F;
            this.Units.HeaderText = "单位";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            // 
            // SelectParamDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 282);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1_ParamTable);
            this.Name = "SelectParamDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择参数";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_ParamTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_ParamTable;
        private System.Windows.Forms.Button btn_ParamSelect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn opcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
    }
}