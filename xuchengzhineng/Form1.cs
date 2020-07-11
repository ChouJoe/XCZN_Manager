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
            this.InvokeIfNeed(() =>
            {
                bgdImagePanel.Visible = false;
                bgdImagePanel.Controls.Clear();
                bgdImagePanel.BackgroundImage = AssemblyLineManager.GetInstance().BackgroundImage;
            });



            int[] monitor_buttonlist = AssemblyLineManager.GetInstance().GetSeqList();
            foreach(int key in monitor_buttonlist)
            {
                ControlInfo key_control = AssemblyLineManager.GetInstance()[key];
                userControl.mapLocation ml = new userControl.mapLocation();
                this.bgdImagePanel.Controls.Add(ml);
                ml.LabelText = key_control.ControlName;
                ml.Location = new System.Drawing.Point(key_control.locationX, key_control.locationY);
                ml.Size = new System.Drawing.Size(72, 54);
                ml.UserControlBtnClicked+= key_control.click_event;
                //pb.BackColor = System.Drawing.Color.Transparent;
                //pb.BackgroundImage = global::xuchengzhineng.Properties.Resources.lb1;
                //pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                //pb.Cursor = System.Windows.Forms.Cursors.Hand;
                //pb.Location = new System.Drawing.Point(key_control.locationX, key_control.locationY);
                //pb.Name = key_control.ControlName + key_control.seq.ToString();
                //pb.Size = new System.Drawing.Size(25, 38);
                //pb.Click += key_control.click_event;
                //pb.MouseEnter += key_control.mousehover_enter;
                //pb.MouseLeave += key_control.mousehover_leave;
              
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
                string world = connectManager.OpcInstance.Read("\"DI_HMI\".DO_D0");
                UInt16 Status = Convert.ToUInt16(world);
                for (int i = 0; i < 3; i++)
                {
                    bool res = (((Status >> i) & 0x01) == 1);
                    switch (i)
                    {
                        case 0:
                            led_safe.IsWorking = res;
                            break;
                        case 1:
                            led_warning.IsWorking = res;
                            break;
                        case 2:
                            led_error.IsWorking = res;
                            break;
                    }
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
                  
                    Thread.Sleep(1000);
                }
            }));
            threadShowTime.IsBackground = true;
            threadShowTime.Start();
        }

        private void timer_refreshData_Tick(object sender, EventArgs e)
        {
            if(_page == Tabpage.page1)
            {
             
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
                //  connectManager.Connected = false;
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
