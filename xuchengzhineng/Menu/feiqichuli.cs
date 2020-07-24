using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using xuchengzhineng.Connection;
namespace xuchengzhineng.Menu
{
    public partial class feiqichuli : Form
    {
        public feiqichuli()
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
            string pf_status = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_FQCL_DI");
            string penlin_status = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_FQCL_PLSB_DI");
            this.InvokeIfNeed(() =>
            {
                pf_status_label.Text = pf_status == "0" ? "停止" : "运行";
                pf_status_label.ForeColor = pf_status == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;
                pf_pbox.BackgroundImage = pf_status == "0" ? Properties.Resources.rg : Properties.Resources.sg;

                penlin_status_label.Text = penlin_status == "0" ? "停止" : "运行";
                penlin_status_label.ForeColor = penlin_status == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;
                penlin_status_pbox.BackgroundImage = penlin_status == "0" ? Properties.Resources.rg : Properties.Resources.sg;
            });
        }
        private void feiqichuli_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_refresh.Stop();
        }

        private void paifeng_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FQ_PF_DO", "1");
        }

        private void paifeng_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FQ_PF_DO", "0");
        }

        private void penlin_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FQ_PL_DO", "1");
        }

        private void penlin_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FQ_PL_DO", "0");
        }
    }
}
