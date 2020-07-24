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
    public partial class jifanglian : Form
    {
        public jifanglian()
        {
            InitializeComponent();
            timer_refresh.Start();
        }
        private System.Text.RegularExpressions.Regex number = new System.Text.RegularExpressions.Regex(@"^\d+(\.\d+)?$");
        private void refresh()
        {
            string world_DI_MD300 = connectManager.OpcInstance.Read("\"DI_HMI\".DI_MD300");
            string world_DI_MD304 = connectManager.OpcInstance.Read("\"DI_HMI\".DI_MD304");
            string world_DI_MD312 = connectManager.OpcInstance.Read("\"DI_HMI\".DI_MD312");
            string fastfreqvalue = connectManager.OpcInstance.Read("\"ANA_PV\".KL_INV_HZ_PV"); 
            string slowfreqvalue = connectManager.OpcInstance.Read("\"ANA_PV\".ML_INV_HZ_PV");
            //string world_DI_MD300 = "4294967295";
            //string world_DI_MD304 = "4294967295";
            //string world_DI_MD312 = "4294967295";
            UInt32 world_DI_MD300_Status = Convert.ToUInt32(world_DI_MD300);
            UInt32 world_DI_MD304_Status = Convert.ToUInt32(world_DI_MD304);
            UInt32 world_DI_MD312_Status = Convert.ToUInt32(world_DI_MD312);
        
            byte[] res_300 = BitConverter.GetBytes(world_DI_MD300_Status);
            byte[] res_304 = BitConverter.GetBytes(world_DI_MD304_Status);
            byte[] res_312 = BitConverter.GetBytes(world_DI_MD312_Status);
            this.InvokeIfNeed(() =>
            {
                FASTfrevalue_label.Text = fastfreqvalue;
                SLOWfrevalue_label.Text = slowfreqvalue;
                ST01_LED.BackgroundImage = !(((res_300[3] >> 7) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                ST02_LED.BackgroundImage = !(((res_300[3] >> 6) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                ST03_LED.BackgroundImage = !(((res_300[3] >> 5) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;

                ST04_LED.BackgroundImage = !(((res_300[2] >> 0) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                ST05_LED.BackgroundImage = !(((res_300[2] >> 1) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                ST06_LED.BackgroundImage = !(((res_300[2] >> 2) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                ST07_LED.BackgroundImage = !(((res_300[2] >> 3) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                ST08_LED.BackgroundImage = !(((res_300[2] >> 4) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                ST09_LED.BackgroundImage = !(((res_300[2] >> 5) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                ST10_LED.BackgroundImage = !(((res_300[2] >> 6) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                ST11_LED.BackgroundImage = !(((res_300[2] >> 7) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;

                ST12_LED.BackgroundImage = !(((res_300[1] >> 0) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                ST13_LED.BackgroundImage = !(((res_300[1] >> 1) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                TG_LED.BackgroundImage = !(((res_300[1] >> 2) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                HMC_F_LED.BackgroundImage = !(((res_300[1] >> 3) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                DC1_INZ_LED.BackgroundImage = !(((res_300[1] >> 6) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                DC1_INW_LED.BackgroundImage = !(((res_300[1] >> 7) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;

                DC3_INZ_LED.BackgroundImage = !(((res_300[0] >> 2) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                DC3_INW_LED.BackgroundImage = !(((res_300[0] >> 3) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;

                DC5_INZ_LED.BackgroundImage = !(((res_304[3] >> 0) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                DC5_INW_LED.BackgroundImage = !(((res_304[3] >> 1) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                DC7_INZ_LED.BackgroundImage = !(((res_304[3] >> 4) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                DC7_INW_LED.BackgroundImage = !(((res_304[3] >> 5) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                DC1_F_LED.BackgroundImage = !(((res_304[3] >> 6) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                DC3_F_LED.BackgroundImage = !(((res_304[3] >> 7) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;

                DC5_F_LED.BackgroundImage = !(((res_304[2] >> 0) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SM8_LED.BackgroundImage = !(((res_304[2] >> 1) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SM11_LED.BackgroundImage = !(((res_304[2] >> 2) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SM12_LED.BackgroundImage = !(((res_304[2] >> 3) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SX1_LED.BackgroundImage = !(((res_304[2] >> 4) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SX2_LED.BackgroundImage = !(((res_304[2] >> 5) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                MK1_LED.BackgroundImage = !(((res_304[2] >> 6) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                MK2_LED.BackgroundImage = !(((res_304[2] >> 7) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;

                KM1_LED.BackgroundImage = !(((res_304[1] >> 0) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;

                SZ01_LED.BackgroundImage = !(((res_312[3] >> 4) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SZ02_LED.BackgroundImage = !(((res_312[3] >> 5) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;

                SZ03_LED.BackgroundImage = !(((res_312[2] >> 3) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SZ04_LED.BackgroundImage = !(((res_312[2] >> 4) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SZ05_LED.BackgroundImage = !(((res_312[2] >> 5) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SZ06_LED.BackgroundImage = !(((res_312[2] >> 6) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SZ07_LED.BackgroundImage = !(((res_312[2] >> 7) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;


                SZ08_LED.BackgroundImage = !(((res_312[1] >> 0) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SZ09_LED.BackgroundImage = !(((res_312[1] >> 1) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SZ10_LED.BackgroundImage = !(((res_312[1] >> 2) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SZ11_LED.BackgroundImage = !(((res_312[1] >> 3) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SZ12_LED.BackgroundImage = !(((res_312[1] >> 4) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;
                SZ13_LED.BackgroundImage = !(((res_312[1] >> 5) & 0x01) == 1) ? Properties.Resources.rg : Properties.Resources.sg;

            });
           


        }
        private void ST01_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST1_DO", "1");
        }

        private void ST01_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST1_DO", "0");
        }


        private void ST02_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST2_DO", "1");
        }

        private void ST02_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST2_DO", "0");
        }

        private void ST03_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST3_DO", "1");
        }

        private void ST03_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST3_DO", "0");
        }

        private void ST04_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST4_DO", "1");
        }

        private void ST04_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST4_DO", "0");
        }

        private void ST05_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST5_DO", "1");
        }

        private void ST05_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST5_DO", "0");
        }

        private void ST06_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST6_DO", "1");
        }

        private void ST06_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST6_DO", "0");
        }

        private void ST07_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST7_DO", "1");
        }

        private void ST07_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST7_DO", "0");
        }

        private void ST08_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST8_DO", "1");
        }

        private void ST08_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST8_DO", "0");
        }

        private void ST09_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST9_DO", "1");
        }

        private void ST09_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST9_DO", "0");
        }

        private void ST10_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST10_DO", "1");
        }

        private void ST10_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST10_DO", "0");
        }

        private void ST11_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST11_DO", "1");
        }

        private void ST11_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST11_DO", "0");
        }

        private void ST12_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST12_DO", "1");
        }

        private void ST12_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST12_DO", "0");
        }

        private void ST13_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST13_DO", "1");
        }

        private void ST13_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ST13_DO", "0");
        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void TG_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_TG_DO", "1");
        }

        private void TG_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_TG_DO", "0");
        }
        private void DC1_INZ_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC1_INZ_DO", "1");
        }
        private void DC1_INZ_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC1_INZ_DO", "0");
        }

        private void DC1_INW_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC1_INW_DO", "1");
        }

        private void DC1_INW_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC1_INW_DO", "0");
        }

        private void DC3_INZ_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC3_INZ_DO", "1");
        }

        private void DC3_INZ_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC3_INZ_DO", "0");
        }

        private void DC3_INW_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC3_INW_DO", "1");
        }

        private void DC3_INW_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC3_INW_DO", "0");
        }

        private void DC5_INZ_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC5_INZ_DO", "1");
        }

        private void DC5_INZ_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC5_INZ_DO", "0");
        }

        private void DC5_INW_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC5_INW_DO", "1");
        }

        private void DC5_INW_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC5_INW_DO", "0");
        }

        private void DC7_INZ_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC7_Z_DO", "1");
        }

        private void DC7_INZ_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC7_Z_DO", "0");
        }

        private void DC7_INW_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC7_W_DO", "1");
        }

        private void DC7_INW_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_DC7_W_DO", "0");
        }

        private void FASTconvert_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_KL_INV_DO", "1");
        }

        private void FASTconverter_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_KL_INV_DO", "0");
        }

        private void FASTfrevalue_set_btn_Click(object sender, EventArgs e)
        {
            string value = FASTfrevalue_set_textbox.Text.Trim();
            if (number.IsMatch(value) && Convert.ToDouble(value) >= 0 && Convert.ToDouble(value) <= 50)
            {

                connectManager.OpcInstance.Write("\"ANA_PV\".KL_INV_AO_MV", value);
                MessageBox.Show("参数设置成功");
            }
            else
            {
                MessageBox.Show("输入非法数值，请重新输入！");
            }
        }

        private void SLOWconvert_start_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ML_INV_DO", "1");
        }

        private void SLOWconverter_stop_btn_Click(object sender, EventArgs e)
        {
            connectManager.OpcInstance.Write("\"HMI_PLC\".HMI_ML_INV_DO", "0");
        }

        private void SLOWfrevalue_set_btn_Click(object sender, EventArgs e)
        {
            string value = SLOWfrevalue_set_textbox.Text.Trim();
            if (number.IsMatch(value) && Convert.ToDouble(value) >= 0 && Convert.ToDouble(value) <= 50)
            {

                connectManager.OpcInstance.Write("\"ANA_PV\".ML_INV_AO_MV", value);
                MessageBox.Show("参数设置成功");
            }
            else
            {
                MessageBox.Show("输入非法数值，请重新输入！");
            }
        }

        private void jifanglian_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_refresh.Stop();
        }
    }
}
