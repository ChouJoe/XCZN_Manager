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
    public partial class shuifenghonggan : Form
    {
        public shuifenghonggan()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            timer_refresh.Start();
        }
        private System.Text.RegularExpressions.Regex number = new System.Text.RegularExpressions.Regex(@"^\d+(\.\d+)?$");
        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            // HMI_SFHG_TPI     HMI_SFHG_ERROR   HMI_SFHG_F_MAX   HMI_SFHG_F_MIN  HMI_SFHG_FY HMI_SFHG_WS HMI_SFHG_FJDI 
            string tempvalue = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_SFHG_TPI");
            string fault_status = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_SFHG_ERROR");
            string firemax = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_SFHG_F_MAX");
            string firemin = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_SFHG_F_MIN");
            string windvalue = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_SFHG_FY");
            string wavalue = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_SFHG_WS");
            string winddevice_status = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_SFHG_FJDI");
            this.InvokeIfNeed(() =>
            {
                tempvalue_label.Text = tempvalue;

                fault_status_label.Text = fault_status == "0" ? "正常" : "故障";
                fault_status_label.ForeColor = fault_status == "0" ? System.Drawing.Color.LimeGreen : System.Drawing.Color.Red;
                fault_status_pbox.BackgroundImage = fault_status == "0" ? Properties.Resources.sg : Properties.Resources.rg;

                maxfire_status_label.Text = firemax == "0" ? "off" : "on";
                maxfire_status_label.ForeColor = firemax == "0" ? System.Drawing.Color.Gray : System.Drawing.Color.LimeGreen;
                maxfire_pbox.BackgroundImage = firemax == "0" ? Properties.Resources.gg : Properties.Resources.sg;

                minfire_status_label.Text = firemin == "0" ? "off" : "on";
                minfire_status_label.ForeColor = firemin == "0" ? System.Drawing.Color.Gray : System.Drawing.Color.LimeGreen;
                minfire_pbox.BackgroundImage = firemin == "0" ? Properties.Resources.gg : Properties.Resources.sg;

                windpressure_label.Text = windvalue == "0" ? "正常" : "异常";
                windpressure_label.ForeColor = windvalue == "0" ? System.Drawing.Color.LimeGreen : System.Drawing.Color.Red;
                windpressure_pbox.BackgroundImage = windvalue == "0" ? Properties.Resources.sg : Properties.Resources.rg;

                wapressure_label.Text = wavalue == "0" ? "正常" : "异常";
                wapressure_label.ForeColor = wavalue == "0" ? System.Drawing.Color.LimeGreen : System.Drawing.Color.Red;
                wapressure_pbox.BackgroundImage = wavalue == "0" ? Properties.Resources.sg : Properties.Resources.rg;

                winddevice_status_label.Text = winddevice_status == "0" ? "停止" : "运行";
                winddevice_status_label.ForeColor = winddevice_status == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;
                winddevice_status_pbox.BackgroundImage = winddevice_status == "0" ? Properties.Resources.rg : Properties.Resources.sg;

            });

        }
        private void shuifenghonggan_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_refresh.Stop();
        }

        private void burn_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HG_RSJ_DO", "1");
        }

        private void burn_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HG_RSJ_DO", "0");
        }

        private void fault_reset_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_SFHG_RESET", "1");
        }

        private void temp_set_btn_Click(object sender, EventArgs e)
        {
            
            string value = temp_set_textbox.Text.Trim();
            if (number.IsMatch(value) && Convert.ToDouble(value) >= 0 && Convert.ToDouble(value) <= 400)
            {

                connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_SFHG_TPO", value);
                MessageBox.Show("参数设置成功");
            }
            else
            {
                MessageBox.Show("输入非法数值，请重新输入！");
            }
        }

        private void winddevice_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HG_XHFS_DO", "1");
        }

        private void winddevice_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HG_XHFS_DO", "0");
        }
    }
}
