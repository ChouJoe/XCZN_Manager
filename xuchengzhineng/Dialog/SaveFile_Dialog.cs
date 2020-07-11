using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xuchengzhineng.Dialog
{
    public partial class SaveFile_Dialog : Form
    {
        public SaveFile_Dialog()
        {
            InitializeComponent();
        }
        private string filename;
        public string FileName
        {
            get
            {
                return filename;
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if(textBox_filename.Text.Trim() == String.Empty)
            {
                MessageBox.Show("文件名不能为空!");
                return;
            }
            filename = textBox_filename.Text.Trim();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
