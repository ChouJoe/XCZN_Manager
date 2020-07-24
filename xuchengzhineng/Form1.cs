using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using xuchengzhineng.Auth;
using xuchengzhineng.configuration;
using System.Threading;
using xuchengzhineng.Connection;
using System.Runtime.InteropServices;
using LiveCharts.Wpf;
namespace xuchengzhineng
{
    public partial class MainForm : Form
    {
        private Tabpage _page = Tabpage.page1;
        private NativeTabControl NativeTabControl1;
        public enum Tabpage
        {
            page1,
            page2,
            page3,
            page4,
            page5
        }
        private string[] MV = { "\"ANA_PV\".COUNT_A_PV", "\"ANA_PV\".COUNT_W_PV", "\"ANA_PV\".COUNT_Q_PV" };
        private void  MoinitorRefresh()
        {
            string res1,res2,res3;
            if (connectManager.Connected)
            {
                res1 = connectManager.OpcInstance.Read("\"ANA_PV\".COUNT_A_PV");
                res2 = connectManager.OpcInstance.Read("\"ANA_PV\".COUNT_W_PV");
                res3 = connectManager.OpcInstance.Read("\"ANA_PV\".COUNT_Q_PV");
                this.InvokeIfNeed(() =>
                {
                    ucMeter1.Value = Math.Round(Convert.ToDecimal("110.25"),1) ;
                    ucMeter2.Value = Math.Round(Convert.ToDecimal("220.25"), 1);
                    ucMeter3.Value = Math.Round(Convert.ToDecimal("1000"), 1);
                });
            }
         
        }
        public MainForm()
        {
            InitializeComponent();
            this.NativeTabControl1 = new NativeTabControl();
            this.NativeTabControl1.AssignHandle(this.tabControl1.Handle);

            dataGridView_Paraminit();
           
        }
        private class NativeTabControl : NativeWindow
        {

            protected override void WndProc(ref Message m)
            {
                if ((m.Msg == TCM_ADJUSTRECT))
                {
                    RECT rc = (RECT)m.GetLParam(typeof(RECT));
                    //Adjust these values to suit, dependant upon Appearance
                    rc.Left -= 5;
                    rc.Right += 5;
                    rc.Top -= 5;
                    rc.Bottom += 5;
                    Marshal.StructureToPtr(rc, m.LParam, true);
                }
                base.WndProc(ref m);
            }

            private const Int32 TCM_FIRST = 0x1300;
            private const Int32 TCM_ADJUSTRECT = (TCM_FIRST + 40);
            private struct RECT
            {
                public Int32 Left;
                public Int32 Top;
                public Int32 Right;
                public Int32 Bottom;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {   
            treeView1.ExpandAll();
           
            LedInit();
            zedGraphInit();
            
        }
        private void DrawControl()
        {

            bgdImagePanel.Visible = false;
            bgdImagePanel.Controls.Clear();

            bgdImagePanel.BackgroundImage = AssemblyLineManager.GetInstance().BackgroundImage;
            int[] monitor_buttonlist = AssemblyLineManager.GetInstance().GetSeqList();
            foreach(int key in monitor_buttonlist)
            {
                ControlInfo key_control = AssemblyLineManager.GetInstance()[key];
                userControl.mapLocation ml = new userControl.mapLocation();
                this.bgdImagePanel.Controls.Add(ml);
                ml.LabelText = key_control.ControlName;
                ml.Location = new System.Drawing.Point(key_control.locationX, key_control.locationY);
                ml.Size = new System.Drawing.Size(58, 43);
                ml.UserControlBtnClicked+= key_control.click_event;
              
            }
            bgdImagePanel.Visible = true;
        }
        private void LedInit()
        {
            
            led_safe.setImageList(new Image[] { imageList1.Images[1], imageList1.Images[2] });
            led_warning.setImageList(new Image[] { imageList1.Images[5], imageList1.Images[6] });
            led_error.setImageList(new Image[] { imageList1.Images[3], imageList1.Images[4] });
            status_timer.Tick += new EventHandler(refreshAlarmStatus);
            led_safe.RegTimer(status_timer);
            led_warning.RegTimer(status_timer);
            led_error.RegTimer(status_timer);
           
            status_timer.Start();
            led_safe.IsWorking = true;
            led_error.IsWorking = true;
            led_warning.IsWorking = true;
        }
        private void refreshAlarmStatus(object sender, EventArgs e)
        {
            if (connectManager.Connected)
            {
                string world = connectManager.OpcInstance.Read("\"DI_HMI\".DO_MD200");
                UInt32 Status = Convert.ToUInt32(world);
                byte[] res = BitConverter.GetBytes(Status);
                bool  warn= (((res[3] >> 0) & 0x01) == 1);
                bool  safe = (((res[3] >> 1) & 0x01) == 1);
                bool  error = (((res[3] >> 2) & 0x01) == 1);
                if (error==true || warn==true)
                {
                    led_safe.IsWorking = false;
                    led_warning.IsWorking = warn;
                    led_error.IsWorking = error;
                }
                else 
                {
                    led_safe.IsWorking = safe;
                    led_warning.IsWorking = warn;
                    led_error.IsWorking = error;
                }
       
            }
           
        }
        private void zedGraphInit()
        {
            zedGraphControl_Temp.GraphPane.Title.Text = "温度曲线";
            zedGraphControl_Temp.GraphPane.XAxis.Title.Text = "时间";
            zedGraphControl_Temp.GraphPane.YAxis.Title.Text = "℃";
            zedGraphControl_Bar.GraphPane.Title.Text = "能耗图";
            zedGraphControl_Bar.GraphPane.XAxis.Title.Text = "时间";
            zedGraphControl_Bar.GraphPane.YAxis.Title.Text = "kWh";
            zedGraphControl_Bar.GraphPane.Y2Axis.Title.Text = "m³";
            zedGraphControl_Bar.GraphPane.Y2Axis.IsVisible = true;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            StartShowTime();
            configForm configform = new configForm();
            configform.StartPosition = FormStartPosition.CenterParent;
            configform.ShowDialog();
            DrawControl();
           // initParamTable();
            timer_refreshData.Start();

        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tabPage1":
                    _page = Tabpage.page1;
                    break;
                case "tabPage2":
                    _page = Tabpage.page2;
                    break;
                case "tabPage3":
                    _page = Tabpage.page3;
                    break;
                case "tabPage4":
                    _page = Tabpage.page4;
                    break;
                case "tabPage5":
                    _page = Tabpage.page5;
                    break;
               
            }
        }
        public void StartShowTime()
        {
            Thread threadShowTime = new Thread(new ThreadStart(() => {
                while (true)
                {
                    this.InvokeIfNeed(() =>
                    {
                        DateTime_label.Text = DateTime.Now.ToString();
                    });
                    //DateTime_label.Text = DateTime.Now.ToString();
                    Thread.Sleep(1000);
                }
            }));
            threadShowTime.IsBackground = true;
            threadShowTime.Start();
        }
        private void moinitorRefresh()
        {

        }
        private void timer_refreshData_Tick(object sender, EventArgs e)
        {
            if(_page == Tabpage.page1)
            {
                MoinitorRefresh();
            }
            else if(_page == Tabpage.page2)
            {
              
            }
            else if(_page == Tabpage.page3)
            {
                
                    ParamRefresh();
                
                
            }
            else if(_page == Tabpage.page4)
            {

            }
            else if(_page == Tabpage.page5)
            {

            }
        }
        private void ucBtnImg1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
            this.ucBtnImg1.Image = Properties.Resources.icon_security_camera_selected;
            this.ucBtnImg1.BtnForeColor =Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(123)))), ((int)(((byte)(245)))));
            this.ucBtnImg2.Image = Properties.Resources.icon_Maintenance;
            this.ucBtnImg2.BtnForeColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ucBtnImg3.Image = Properties.Resources.icon_searched;
            this.ucBtnImg3.BtnForeColor = this.ucBtnImg2.BtnForeColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ucBtnImg4.Image = Properties.Resources.icon_replay;
            this.ucBtnImg4.BtnForeColor = this.ucBtnImg2.BtnForeColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
        }

        private void ucBtnImg2_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 2;
            this.ucBtnImg1.Image = Properties.Resources.icon_security_camera;
            this.ucBtnImg2.Image = Properties.Resources.icon_Maintenance_selected;
            this.ucBtnImg3.Image = Properties.Resources.icon_searched;
            this.ucBtnImg4.Image = Properties.Resources.icon_replay;
            this.ucBtnImg2.BtnForeColor = Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(123)))), ((int)(((byte)(245))))); ;
            this.ucBtnImg1.BtnForeColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ucBtnImg3.BtnForeColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ucBtnImg4.BtnForeColor =  Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));

        }

        private void ucBtnImg3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
            this.ucBtnImg1.Image = Properties.Resources.icon_security_camera;
            this.ucBtnImg2.Image = Properties.Resources.icon_Maintenance;
            this.ucBtnImg3.Image = Properties.Resources.icon_search_selected;
            this.ucBtnImg4.Image = Properties.Resources.icon_replay;
            this.ucBtnImg3.BtnForeColor  = Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(123)))), ((int)(((byte)(245))))); ;
            this.ucBtnImg2.BtnForeColor  = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ucBtnImg1.BtnForeColor  = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ucBtnImg4.BtnForeColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));

        }

        private void ucBtnImg4_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 3;
            this.ucBtnImg1.Image = Properties.Resources.icon_security_camera;
            this.ucBtnImg2.Image = Properties.Resources.icon_Maintenance;
            this.ucBtnImg3.Image = Properties.Resources.icon_searched;
            this.ucBtnImg4.Image = Properties.Resources.icon_replay_selected;
            this.ucBtnImg4.BtnForeColor = Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(123)))), ((int)(((byte)(245))))); ;
            this.ucBtnImg2.BtnForeColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ucBtnImg3.BtnForeColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ucBtnImg1.BtnForeColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
        }
        private void ConBtn_Click(object sender, EventArgs e)
        {
            string ipaddress = ConfigLoader.CONNECT_IP;
            try
            {
                if (connectManager.OpcInstance.Connect(ipaddress))
                {
                    ConBtn.Enabled = false;
                    DisconBtn.Enabled = true;
                    led_safe.IsWorking = true;
                    // connectManager.Connected = true;
                }
            }
            catch
            {

            }

        }

        private void DisconBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connectManager.OpcInstance.DisConnect();
                led_safe.IsWorking = false;
            }
            catch
            {

            }
            ConBtn.Enabled = true;
            DisconBtn.Enabled = false;
        }

        private void ConfigBtn_Click(object sender, EventArgs e)
        {
            configForm configform = new configForm();
            DialogResult res = configform.ShowDialog();
            configform.Dispose();
            if (res == DialogResult.OK)
            {
                DrawControl();
                // initParamTable();
            }
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            loginForm login = new loginForm();
            login.StartPosition = FormStartPosition.CenterParent;
            login.ShowDialog();
            login.Dispose();
        }

        private void LoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   
    }
}
