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
    public partial class hongwaijiare : Form
    {
        public hongwaijiare()
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
            string tempvalue = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_HWJR_TPI");
            string L1 = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_L_DI_1");
            string L2 = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_L_DI_2");
            string L3 = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_L_DI_3");
            string L4 = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_L_DI_4");
            string R1 = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_R_DI_1");
            string R2 = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_R_DI_2");
            string R3 = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_R_DI_3");
            string R4 = connectManager.OpcInstance.Read("\"HMI_PLC\".HMI_R_DI_4");
            this.InvokeIfNeed(() =>
            {
                tempvalue_label.Text = tempvalue;
                L1_pbox.BackgroundImage = L1 == "0" ? Properties.Resources.rg : Properties.Resources.sg;
                L1_status_label.Text = L1 == "0" ? "未完成" : "完成";
                L1_status_label.ForeColor = L1 == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;

                L2_pbox.BackgroundImage = L2 == "0" ? Properties.Resources.rg : Properties.Resources.sg;
                L2_status_label.Text = L2 == "0" ? "未完成" : "完成";
                L2_status_label.ForeColor = L2 == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;

                L3_pbox.BackgroundImage = L3 == "0" ? Properties.Resources.rg : Properties.Resources.sg;
                L3_status_label.Text = L3 == "0" ? "未完成" : "完成";
                L3_status_label.ForeColor = L3 == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;

                L4_pbox.BackgroundImage = L4 == "0" ? Properties.Resources.rg : Properties.Resources.sg;
                L4_status_label.Text = L4 == "0" ? "未完成" : "完成";
                L4_status_label.ForeColor = L4 == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;

                R1_pbox.BackgroundImage = R1 == "0" ? Properties.Resources.rg : Properties.Resources.sg;
                R1_status_label.Text = R1 == "0" ? "未完成" : "完成";
                R1_status_label.ForeColor = R1 == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;

                R2_pbox.BackgroundImage = R2 == "0" ? Properties.Resources.rg : Properties.Resources.sg;
                R2_status_label.Text = R2 == "0" ? "未完成" : "完成";
                R2_status_label.ForeColor = R2 == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;

                R3_pbox.BackgroundImage = R3 == "0" ? Properties.Resources.rg : Properties.Resources.sg;
                R3_status_label.Text = R3 == "0" ? "未完成" : "完成";
                R3_status_label.ForeColor = R3 == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;

                R4_pbox.BackgroundImage = R4 == "0" ? Properties.Resources.rg : Properties.Resources.sg;
                R4_status_label.Text = R4 == "0" ? "未完成" : "完成";
                R4_status_label.ForeColor = R4 == "0" ? System.Drawing.Color.Red : System.Drawing.Color.LimeGreen;
            });

        }

        private void hongwaijiare_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_refresh.Stop();
        }

        private void hw_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HWJR_V_DO", "1");
        }

        private void hw_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HWJR_V_DO", "0");
        }

        private void temp_set_btn_Click(object sender, EventArgs e)
        {
            string value = temp_set_textbox.Text.Trim();
            if (number.IsMatch(value) && Convert.ToDouble(value) >= 0 && Convert.ToDouble(value) <= 400)
            {
                try
                {
                    connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HWJR_TPO", value);
                    MessageBox.Show("参数设置成功");
                }
                catch
                {
                    MessageBox.Show("参数设置失败");
                }

            }
            else
            {
                MessageBox.Show("输入非法数值，请重新输入！");
            }
        }

        private void pf_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_PF_DO", "1");
        }

        private void pf_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_PF_DO", "0");
        }

        private void L1_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB1_DO", "1");
        }

        private void L1_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB1_DO", "0");
        }

        private void L2_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB2_DO", "1");
        }

        private void L2_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB2_DO", "0");
        }

        private void L3_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB3_DO", "1");
        }

        private void L3_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB3_DO", "0");
        }

        private void L4_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB4_DO", "1");
        }

        private void L4_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB4_DO", "0");
        }

        private void R1_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB5_DO", "1");
        }

        private void R1_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB5_DO", "0");
        }

        private void R2_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB6_DO", "1");
        }

        private void R2_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB6_DO", "0");
        }

        private void R3_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB7_DO", "1");
        }

        private void R3_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB7_DO", "0");
        }

        private void R4_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB8_DO", "1");
        }

        private void R4_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_FRB8_DO", "0");
        }

        private void GPSL1_start_btn_Click(object sender, EventArgs e)
        {
           connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV1_DO", "1");
        }

        private void GPSL1_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV1_DO", "0");
        }

        private void GPSL2_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV2_DO", "1");
        }

        private void GPSL2_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV2_DO", "0");
        }

        private void GPSL3_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV3_DO", "1");
        }

        private void GPSL3_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV3_DO", "0");
        }

        private void GPSL4_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV4_DO", "1");
        }

        private void GPSL4_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV4_DO", "0");
        }

        private void GPSR1_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV5_DO", "1");
        }

        private void GPSR1_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV5_DO", "0");
        }

        private void GPSR2_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV6_DO", "1");
        }

        private void GPSR2_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV6_DO", "0");
        }

        private void GPSR3_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV7_DO", "1");
        }

        private void GPSR3_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV7_DO", "0");
        }

        private void GPSR4_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV8_DO", "1");
        }

        private void GPSR4_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_HW_FV8_DO", "0");
        }
    }
}
