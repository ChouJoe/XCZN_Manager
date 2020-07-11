using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using xuchengzhineng.Connection;
using xuchengzhineng.configuration;
namespace xuchengzhineng.Dialog
{
    public partial class ParamSetDialog : Form
    {
        private string set_value;
        private string set_offset;
        private string paramname;
        public string SetValue
        {
            get
            {
                return set_value;
            }
        }
        public  string SetOffset
        {
            get {
                return set_offset;
            }
        }
        public ParamSetDialog(string ParamName, string Cur_Value, string Set_Value, string Set_Offset)
        {
            this.paramname = ParamName;
            InitializeComponent();
            label_ParamName.Text = ParamName;
            label_CurParamValue.Text = Cur_Value;
            textBox_SetParamValue.Text = Set_Value;
            textBox_SetOffset.Text = Set_Offset;
        }

        private void btn_Setparam_Click(object sender, EventArgs e)
        {
            //需要判断一下输入的数据类型是否正确 
            if(textBox_SetParamValue.Text.Length!=0)
            {
                set_value = textBox_SetParamValue.Text;
                set_offset = textBox_SetOffset.Text;
                string opcname = ParamInfoList.ParamInfo_list[paramname].OpcName;
                connectManager.OpcInstance.Write(opcname, set_value);
            }

            this.Close();

        }

        private void ParamSetDialog_Shown(object sender, EventArgs e)
        {
            this.textBox_SetParamValue.Focus();
        }
    }
}
