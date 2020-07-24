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
    public partial class qianglen : Form
    {
        public qianglen()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            timer_refresh.Start();
        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            // 
            string sffengji_status = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_QL_SF_DI");
            string pffengji_status = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_QL_PF_DI");
            string pftempvalue = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_QL_PF_TPI");
            this.InvokeIfNeed(() =>
            {
                tempvalue_label.Text = pftempvalue;

                sffengji_status_label.Text = sffengji_status == "0" ? "停止" : "运行";
                sffengji_status_label.ForeColor = sffengji_status == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;
                sffengji_pbox.BackgroundImage = sffengji_status == "0" ? Properties.Resources.rg : Properties.Resources.sg;

                pffengji_status_label.Text = pffengji_status == "0" ? "停止" : "运行";
                pffengji_status_label.ForeColor = pffengji_status == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;
                pffengji_status_pbox.BackgroundImage = pffengji_status == "0" ? Properties.Resources.rg : Properties.Resources.sg;
            });
        }
        private void qianglen_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_refresh.Stop();
        }

        private void sonfeng_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_QL_SF_DO", "1");
        }

        private void sonfeng_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_QL_SF_DO", "0");
        }

        private void paifeng_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_QL_PF_DO", "1");
        }

        private void paifeng_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_QL_PF_DO", "0");
        }
    }
}
