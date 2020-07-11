using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using xuchengzhineng.configuration;
using xuchengzhineng.Dialog;
using System.Data;
using System.Xml;
namespace xuchengzhineng
{
    public partial class MainForm : Form
    {
        List<string> refreshParmList = new List<string>();
        DataTable table;
        Dictionary<string, DataRow> index;
        DataView view;
        BindingSource bs;
        private void dataGridView_Paraminit()
        {
            this.table = new DataTable();
            dataGridView_Param.AutoGenerateColumns = false;
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("ParamName", typeof(String));
            table.Columns.Add("Units", typeof(String));
            table.Columns.Add("Curr_value", typeof(String));
            table.Columns.Add("Set_value", typeof(String));
            table.Columns.Add("Offset", typeof(String));
            this.index = new Dictionary<string, DataRow>();
             bs = new BindingSource();
            bs.DataSource = table;
            view = table.DefaultView;
            dataGridView_Param.DataSource = bs;
           
        }
        private void dataGridView_Param_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dataGridView_Param.CurrentRow != null && dataGridView_Param.CurrentRow.Index >= 0)
            {
                if (e.ColumnIndex == dataGridView_Param.Columns["Set_value"].Index)
                {
                    string setvalue = "";
                    string setoffset = "";
                    if (dataGridView_Param.CurrentRow.Cells["Set_value"].Value != null)
                    {
                        setvalue = dataGridView_Param.CurrentRow.Cells["Set_value"].Value.ToString();
                    }
                    if (dataGridView_Param.CurrentRow.Cells["Offset"].Value != null)
                    {
                        setoffset = dataGridView_Param.CurrentRow.Cells["Offset"].Value.ToString();
                    }
                    string paramname = dataGridView_Param.CurrentRow.Cells["ParamName"].Value.ToString();
                    string curvalue = null;
                    if (dataGridView_Param.CurrentRow.Cells["Curr_value"].Value != null)
                    {
                        curvalue = dataGridView_Param.CurrentRow.Cells["Curr_value"].Value.ToString();
                    }



                    ParamSetDialog pd = new ParamSetDialog(paramname, curvalue, setvalue, setoffset);
                    DialogResult result = pd.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        bs.EndEdit();
                        dataGridView_Param.EndEdit();
                        this.dataGridView_Param.CurrentRow.Cells["Set_value"].Value = pd.SetValue;
                        this.dataGridView_Param.CurrentRow.Cells["Offset"].Value = pd.SetOffset;
                        //this.dataGridView_Param.CurrentCell = null;
                        pd.Dispose();
                    }

                }
            }
        }
        public void ParamRefresh()
        {
            if (refreshParmList.Count > 0)
            {
                foreach (string ParamName in refreshParmList)
                {
                   
                    string opcname = ParamInfoList.ParamInfo_list[ParamName].OpcName;
                    string result = Connection.connectManager.OpcInstance.Read(opcname);
                    
                    if (index.ContainsKey(ParamName))
                    {
                        this.InvokeIfNeed(() =>
                        {
                            index[ParamName]["Curr_value"] = result;
                            //index[ParamName]["Curr_value"] = this.dataGridView_Param.CurrentRow.Cells["Set_value"].Value;
                           // this.dataGridView_Param.CurrentRow.Cells["Curr_value"].Value= this.dataGridView_Param.CurrentRow.Cells["Set_value"].Value;
                        });
                        
                    }
                    
                    
                }
            }

        }
        private void Add(int ID)
        {
            string name = ParamInfoList.ParamInfo_list[ID].Name;
            if (!index.ContainsKey(name)&& ParamInfoList.ParamInfo_list.ParamNameList.Contains(name))
            {
                string units = ParamInfoList.ParamInfo_list[name].Units;
                int id = ParamInfoList.ParamInfo_list[name].ID;
                string opcName = ParamInfoList.ParamInfo_list[name].OpcName;
                refreshParmList.Add(name);
                DataRow row = table.NewRow();
                row["ID"] = id;
                row["ParamName"] = name;
                row["Units"] = units;
                index.Add(name, row);
                table.Rows.Add(row);

            }

        }
        private void Remove(string name)
        {
            if (refreshParmList.Contains(name))
            {
                refreshParmList.Remove(name);
            }
            if (index.ContainsKey(name))
            {
                table.Rows.Remove(index[name]);
                index.Remove(name);
            }
        }
        private void AddParamBtn_Click(object sender, EventArgs e)
        {
            SelectParamDialog s = new SelectParamDialog();
            int[] idlist;
            DialogResult result = s.ShowWindow(out idlist);
            if (result == DialogResult.OK)
            {
                foreach (int id in idlist)
                {
                    Add(id);
                }
            }
            s.Dispose();
        }
        private void removeParam_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_Param.SelectedRows != null)
            {
                foreach (DataGridViewRow row in dataGridView_Param.SelectedRows)
                {
                    Remove(row.Cells[1].Value.ToString());
                }
            }
        }
        private void saveParamXml_Click(object sender, EventArgs e)
        {
            if(refreshParmList.ToArray().Length == 0)
            {
                MessageBox.Show("至少添加一个参数");
                return;
            }
            XmlDocument xmlDoc = new XmlDocument();
            //XML的声明<?xml version="1.0" encoding="gb2312"?> 
            XmlDeclaration xmlSM = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            //追加xmldecl位置
            xmlDoc.AppendChild(xmlSM);
            //添加一个名为Gen的根节点
            XmlElement xml = xmlDoc.CreateElement("", "ParamTable", "");
            //追加Gen的根节点位置
            xmlDoc.AppendChild(xml);
            //添加另一个节点,与Gen所匹配，查找<Gen>
            XmlNode gen = xmlDoc.SelectSingleNode("ParamTable");
            //添加一个名为<Version>的节点   
            XmlElement ver = xmlDoc.CreateElement("Version");
            //为<Version>节点的属性
            ver.SetAttribute("version", ConfigLoader.GetInstance().FirmwareVersion);
            gen.AppendChild(ver);
            XmlElement p = xmlDoc.CreateElement("ParameterList");

            //循环遍历paramrefreshlist 创建节点  
            foreach(string name in refreshParmList)
            {
                XmlElement xele = xmlDoc.CreateElement("Parameter");
                int id = ParamInfoList.ParamInfo_list[name].ID;
                string opcName = ParamInfoList.ParamInfo_list[name].OpcName;
                xele.InnerText = name;
                xele.SetAttribute("ID", id.ToString());
                xele.SetAttribute("opcName", opcName);
                p.AppendChild(xele);

            }
            gen.AppendChild(p);
            SaveFile_Dialog sf_dialog = new Dialog.SaveFile_Dialog();
            DialogResult result = sf_dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                string filename = sf_dialog.FileName;
                string save_filepath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
               @"Data\ParamFile\");
                xmlDoc.Save(save_filepath + filename+".xml");
            }
            sf_dialog.Dispose();


        }
    }
}
