using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using xuchengzhineng.configuration;
using xuchengzhineng.Connection;
using opcua_s7_1500_client;
namespace xuchengzhineng.Dialog
{
    public partial class monitorDiag : Form
    {
        private string[] _namelist;
        public monitorDiag(string ControlName,string [] namelist)
        {
            InitializeComponent();
            this.Text = ControlName;
            _namelist = namelist;

            if (namelist!=null)
            {   
                foreach(string varname in namelist)
                {
                    int index = this.dataGridView_monitor.Rows.Add();
                    string units = VarInfoList.VarInfo_list[varname].Units;
                    this.dataGridView_monitor.Rows[index].Cells[0].Value = varname;
                    this.dataGridView_monitor.Rows[index].Cells[1].Value = 0;
                    this.dataGridView_monitor.Rows[index].Cells[2].Value = units;
                }
            }
           
        }

        private void monitorDiag_Shown(object sender, EventArgs e)
        {
                  timer_VarRefresh.Start();
        }

        private void monitorDiag_FormClosing(object sender, FormClosingEventArgs e)
        {
               timer_VarRefresh.Stop();
        }

        private void timer_VarRefresh_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _namelist.Length; i++)
            {
                string varname = _namelist[i];
                string opcname = VarInfoList.VarInfo_list[varname].OpcName;
                string result = connectManager.OpcInstance.Read(opcname);
          
                this.InvokeIfNeed(() =>
                {

                    this.dataGridView_monitor.Rows[i].Cells[1].Value = result;
                });
            }
        }
    }
   
}
