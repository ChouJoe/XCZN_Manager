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
    public partial class reshuixi : Form
    {
        public reshuixi()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            timer_refresh.Start();
        }
        private System.Text.RegularExpressions.Regex number = new System.Text.RegularExpressions.Regex(@"^\d+(\.\d+)?$");
        private void convert_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_XS3_INV_DO", "1");
        }

        private void converter_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_XS3_INV_DO", "0");
        }

        private void frevalue_set_btn_Click(object sender, EventArgs e)
        {
            string value = frevalue_set_textbox.Text.Trim();
            if (number.IsMatch(value) && Convert.ToDouble(value) >= 0 && Convert.ToDouble(value) <= 50)
            {

                connectManager.OpcInstance.Write("\"ANA_PV\".CSX3_INV_AO_MV", value);
                MessageBox.Show("参数设置成功");
            }
            else
            {
                MessageBox.Show("输入非法数值，请重新输入！");
            }
        }
        private void refresh()
        {
            string frevalue = connectManager.OpcInstance.Read("\"ANA_PV\".CSX3_INV_HZ_PV");
            this.InvokeIfNeed(() =>
            {
                frevalue_label.Text = frevalue;
            });
        }
        private void prewarming_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_RSX_RSP_DO", "1");
        }

        private void prewarming_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_RSX_RSP_DO", "0");
        }

        private void pre_water_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_XS3_P_DO", "1");
        }

        private void pre_water_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_XS3_P_DO", "0");
        }

        private void pre_water1_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_XS3_P2_DO", "1");
        }

        private void pre_water1_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_XS3_P2_DO", "0");
        }

        private void water_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_RSX_P_DO", "1");
        }

        private void water_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_RSX_P_DO", "0");
        }

        private void water1_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_RSX_P2_DO", "1");
        }

        private void water1_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_RSX_P2_DO", "0");
        }

        private void cycletime_set_btn_Click(object sender, EventArgs e)
        {
            string value = cycletime_textbox.Text.Trim();
            if (number.IsMatch(value) && Convert.ToDouble(value) >= 0 && Convert.ToDouble(value) <= 720)
            {

                connectManager.OpcInstance.Write("\"HMI_PLC\".RSXDJ_M / A_SET", value);
                MessageBox.Show("参数设置成功");
            }
            else
            {
                MessageBox.Show("输入非法数值，请重新输入！");
            }
        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
