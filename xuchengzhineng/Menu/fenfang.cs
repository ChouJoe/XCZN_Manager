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
    public partial class fenfang : Form
    {
        public fenfang()
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
           // HMI_FW_DF HMI_FW_MF
            string difeng_status = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_FW_DF");
            string mianfeng_status = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_FW_MF");
            this.InvokeIfNeed(() =>
            {
                difeng_status_label.Text = difeng_status == "0" ? "停止" : "运行";
                difeng_status_label.ForeColor = difeng_status == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;
                difeng_status_pbox.BackgroundImage = difeng_status == "0" ? Properties.Resources.rg : Properties.Resources.sg;

                mianfeng_status_label.Text = mianfeng_status == "0" ? "停止" : "运行";
                mianfeng_status_label.ForeColor = mianfeng_status == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;
                mianfeng_status_pbox.BackgroundImage = mianfeng_status == "0" ? Properties.Resources.rg : Properties.Resources.sg;
            });
        }
        private void fenfang_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_refresh.Stop();
        }

        private void difeng_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("", "1");
        }

        private void difeng_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("", "0");
        }

        private void mianfeng_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("", "1");
        }

        private void mianfeng_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("", "0");
        }
    }
}
