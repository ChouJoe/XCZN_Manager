using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace xuchengzhineng.configuration
{
    public partial class configForm : Form
    {   public static string cur_version = "";
        public configForm()
        {
            InitializeComponent();
            
        }
        private List<String> ProductCfgVerList = new List<string>();
        private void configForm_Load(object sender, EventArgs e)
        {
            this.cur_version_label.Text = cur_version;
            string configpath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
               @"firmwareFiles\");
            string[] fullpath = Directory.GetFiles(configpath, "*.xml");
            foreach(string path in fullpath)
            {
                string filename = Path.GetFileNameWithoutExtension(path);
                ProductCfgVerList.Add(filename);
            }
            foreach(string version in ProductCfgVerList)
            {
                comboBox_version.Items.Add(version);
            }
            comboBox_version.SelectedIndex = 0;
        }

        private void config_btn_Click(object sender, EventArgs e)
        {
            string selectedVersion = comboBox_version.SelectedItem.ToString();
            string connect_ip = connectIP.Text.Trim();
            cur_version = selectedVersion;
            string filename = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
               @"firmwareFiles\"+ selectedVersion + ".xml");
            ConfigLoader.GetInstance().loadXml(filename, connect_ip);
            this.Close();
        }
    }
}
