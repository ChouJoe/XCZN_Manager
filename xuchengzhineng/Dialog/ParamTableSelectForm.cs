using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using xuchengzhineng.configuration;
namespace xuchengzhineng.Dialog
{
    public partial class SelectParamDialog : Form
    {
        List<int> selectedParamName = new List<int>(); 
        public SelectParamDialog()
        {
            InitializeComponent();
            initParamTable();
        }

        public void initParamTable()
        {
            if (ParamInfoList.ParamInfo_list.Length > 0)
            {
                this.dataGridView1_ParamTable.Rows.Clear();
                foreach (string parname in ParamInfoList.ParamInfo_list.ParamNameList)
                {
                    int index = this.dataGridView1_ParamTable.Rows.Add();
                    string units = ParamInfoList.ParamInfo_list[parname].Units;
                    int id = ParamInfoList.ParamInfo_list[parname].ID;
                    string opcName = ParamInfoList.ParamInfo_list[parname].OpcName;
                    this.dataGridView1_ParamTable.Rows[index].Cells[0].Value = id;
                    this.dataGridView1_ParamTable.Rows[index].Cells[1].Value = parname;
                    this.dataGridView1_ParamTable.Rows[index].Cells[2].Value = opcName;
                    this.dataGridView1_ParamTable.Rows[index].Cells[3].Value = units;
                }
            }
        }
        public DialogResult ShowWindow(out int[] selectedNameList)
        {
            DialogResult result = this.ShowDialog();
            if(result == DialogResult.OK)
            {
                selectedNameList = this.selectedParamName.ToArray();
                
            }
            else
            {
                selectedNameList = null;
            }
            return result;


        }
        private void btn_ParamSelect_Click(object sender, EventArgs e)
        {
            if(dataGridView1_ParamTable.SelectedRows != null)
            {
                this.selectedParamName.Clear();
                foreach( DataGridViewRow row in dataGridView1_ParamTable.SelectedRows)
                {
                    this.selectedParamName.Add( int.Parse(row.Cells[0].Value.ToString()));
                }
            }
            selectedParamName.Sort();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
