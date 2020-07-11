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
    public partial class labelPanel : UserControl
    {
        private String text;
        public String DesText
        {
            get { return text; }
            set { text = value; this.Des.Text = text; }
        }
        private String value;
        public String ValText
        {
            get { return value; }
            set { this.value = value; this.Val.Text = this.value; }
        }
        private Color des_color;
        public Color Des_Color
        {
            get { return des_color; }
            set { des_color = value; this.Des.BackColor = des_color; }
        }
        private Color val_color;
        public Color Val_Color
        {
            get { return val_color; }
            set { val_color = value; this.Val.BackColor = val_color; }
        }
        public labelPanel()
        {
            InitializeComponent();
        }
    }
}
