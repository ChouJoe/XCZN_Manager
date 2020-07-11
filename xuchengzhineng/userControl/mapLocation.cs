using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xuchengzhineng.userControl
{
    public partial class mapLocation : UserControl
    {
        public mapLocation()
        {
            InitializeComponent();
            
        } 
        private Color textcolor = System.Drawing.Color.DeepSkyBlue;
        public Color TextColor
        {
            get { return textcolor; }
            set
            {
                label1.ForeColor = value;
                textcolor = value;            }
        }
        private String labeltext;
        public String LabelText
        {
            get { return labeltext; }
            set
            {
                label1.Text = value;
                labeltext = value;
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.lg1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.lb1;
        }     
        public event EventHandler  UserControlBtnClicked;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (UserControlBtnClicked != null)
                UserControlBtnClicked(sender, new EventArgs());//把按钮自身作为参数传递       
        }
    }
}
