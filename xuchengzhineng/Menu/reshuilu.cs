using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using xuchengzhineng;
using xuchengzhineng.Connection;

namespace xuchengzhineng.Menu
{
    public partial class reshuilu : Form
    {
        public reshuilu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            timer_refresh.Start();
        }
        private System.Text.RegularExpressions.Regex number = new System.Text.RegularExpressions.Regex(@"^\d+(\.\d+)?$");
        private void timer_refresh_Tick(object sender, EventArgs e)
        {

        }

        private void reshuilu_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_refresh.Stop();
        }

        private void burn_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_RSX_RSJ_DO", "1");
        }

        private void burn_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_RSX_RSJ_DO", "0");
        }

        private void maxfire_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_RSX_RSJ_DO", "1");
        }

        private void maxfire_stop_btn_Click(object sender, EventArgs e)
        {

        }

        private void minfire_start_btn_Click(object sender, EventArgs e)
        {

        }

        private void minfire_stop_btn_Click(object sender, EventArgs e)
        {

        }

        private void temp_set_btn_Click(object sender, EventArgs e)
        {
            string value = temp_set_textbox.Text.Trim();
            if (number.IsMatch(value) && Convert.ToDouble(value) >= 0 && Convert.ToDouble(value) <= 90)
            {

                connectManager.OpcInstance.Write("\"ANA_PV\".CSX3_INV_AO_MV", value);
                MessageBox.Show("参数设置成功");
            }
            else
            {
                MessageBox.Show("输入非法数值，请重新输入！");
            }
        }

        private void warming_start_btn_Click(object sender, EventArgs e)
        {

        }

        private void warming_stop_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
