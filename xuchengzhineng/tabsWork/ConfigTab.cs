//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using xuchengzhineng.configuration;
//using xuchengzhineng.Dialog;

//namespace xuchengzhineng
//{
//    public partial class MainForm : Form
//    {
//        List<string> refreshParmList = new List<string>();
//        private void dataGridView_Param_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex < 0)
//            {
//                return;
//            }
//            if (dataGridView_Param.CurrentRow != null && dataGridView_Param.CurrentRow.Index >= 0)
//            {
//                if (e.ColumnIndex == dataGridView_Param.Columns["Set_value"].Index)
//                {
//                    string setvalue  = "";
//                    string setoffset = "";
//                    if (dataGridView_Param.CurrentRow.Cells["Set_value"].Value !=null)
//                    {
//                         setvalue = dataGridView_Param.CurrentRow.Cells["Set_value"].Value.ToString();
//                    }
//                    if(dataGridView_Param.CurrentRow.Cells["Offset"].Value != null)
//                    {
//                        setoffset = dataGridView_Param.CurrentRow.Cells["Offset"].Value.ToString();
//                    }
//                    string paramname = dataGridView_Param.CurrentRow.Cells["ParamName"].Value.ToString();
//                    string curvalue = null;
//                    if (dataGridView_Param.CurrentRow.Cells["Curr_value"].Value !=null)
//                    {
//                         curvalue = dataGridView_Param.CurrentRow.Cells["Curr_value"].Value.ToString();
//                    }
                    


//                    ParamSetDialog pd = new ParamSetDialog(paramname,curvalue,setvalue,setoffset);
//                    DialogResult result = pd.ShowDialog();
//                    if(result == DialogResult.OK)
//                    {
//                        this.dataGridView_Param.CurrentRow.Cells["Set_value"].Value = pd.SetValue;
//                        this.dataGridView_Param.CurrentRow.Cells["Offset"].Value = pd.SetOffset;
//                        pd.Dispose();
//                    }

//                }
//            }
//        }
//        public void ParamRefresh()
//        {
//            if (refreshParmList.Count > 0)
//            {
//                foreach (string ParamName in refreshParmList)
//                {
//                    string opcname = ParamInfoList.ParamInfo_list[ParamName].OpcName;
//                    //string result = Connection.connectManager.OpcInstance.Read(opcname);
//                    for(int i = 0; i<dataGridView_Param.Rows.Count; i++)
//                    {
//                        if(dataGridView_Param.Rows[i].Cells[1].Value.ToString() == ParamName)
//                        {
//                            this.InvokeIfNeed(() =>
//                            {
//                                this.dataGridView_Param.Rows[i].Cells[3].Value = i;
//                            });
//                        }
//                    }
//                    //this.InvokeIfNeed(() =>
//                    //{
//                    //    int index = ParamInfoList.ParamInfo_list.ParamNameList.FindIndex((item) => (item.Equals(ParamName)));
                         
//                    //   // this.dataGridView_Param.Rows[index].Cells[3].Value = result;  
//                    //});
//                }
//            }
            
//        }
//        private void Add(int ID)
//        {
//            string name = ParamInfoList.ParamInfo_list[ID].Name;
//            if (!refreshParmList.Contains(name)){
//                refreshParmList.Add(name);
//                int index = this.dataGridView_Param.Rows.Add();
//                string units = ParamInfoList.ParamInfo_list[name].Units;
//                int id = ParamInfoList.ParamInfo_list[name].ID;
//                string opcName = ParamInfoList.ParamInfo_list[name].OpcName;
//                this.dataGridView_Param.Rows[index].Cells[0].Value = id;
//                this.dataGridView_Param.Rows[index].Cells[1].Value = name;
//                this.dataGridView_Param.Rows[index].Cells[2].Value = units;
//            }
            
//        }
//        private void Remove(string name)
//        {
//            if (refreshParmList.Contains(name))
//            {
//                refreshParmList.Remove(name);
//            }
//        }
//        private void AddParamBtn_Click(object sender, EventArgs e)
//        {
//            SelectParamDialog s = new SelectParamDialog();
//            int[] idlist;
//            DialogResult result = s.ShowWindow(out idlist);
//            if(result == DialogResult.OK)
//            {
//                foreach(int id in idlist)
//                {
//                    Add(id);
//                }
//            }
//            s.Dispose();
//        }
//        private void removeParam_btn_Click(object sender, EventArgs e)
//        {
//            if (dataGridView_Param.SelectedRows != null)
//            {
//                foreach (DataGridViewRow row in dataGridView_Param.SelectedRows)
//                {
//                    Remove(row.Cells[1].Value.ToString());
//                    if (!row.IsNewRow)
//                        dataGridView_Param.Rows.Remove(row);
//                }
//            }
//        }
//    }
//}
