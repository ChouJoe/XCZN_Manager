using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xuchengzhineng.Auth
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            AuthControl.GetInstance().loadXml();
            InitUser(AuthControl.GetInstance().UserNameList);
            comboBox_user.SelectedIndex = 0;
        }
        public void InitUser(List<string> list)
        {
            foreach(var item in list)
            {
                comboBox_user.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
