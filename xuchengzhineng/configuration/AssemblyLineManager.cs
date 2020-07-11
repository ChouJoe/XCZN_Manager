using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using xuchengzhineng.Dialog;
using System.Windows.Forms;
namespace xuchengzhineng.configuration
{
    class AssemblyLineManager
    {
        private Image _backgroundImage;
        private string _productionType;
        private SortedDictionary<int, ControlInfo> ControlList = new SortedDictionary<int, ControlInfo>();
        private static AssemblyLineManager _instance = null;
        public static AssemblyLineManager GetInstance()
        {
            if(_instance == null)
            {
                _instance = new AssemblyLineManager();
            }
            return _instance;

        }
        public void getImage(string imagename)
        {
            string imagepath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                     @"firmwareFiles\images\" + imagename);
            try
            {
                FileStream fs = new System.IO.FileStream(imagepath, FileMode.Open, FileAccess.Read);
                int byteLength = (int)fs.Length;
                byte[] fileBytes = new byte[byteLength];
                fs.Read(fileBytes, 0, byteLength);
                //文件流关閉,文件解除锁定
                fs.Close();
                fs.Dispose();
                Image image = Image.FromStream(new MemoryStream(fileBytes));
                fileBytes = null;
                if(_backgroundImage != null)
                {
                    _backgroundImage.Dispose();
                    _backgroundImage = null;
                }
                _backgroundImage = image;
            }
            catch
            {
                   
            }
           
        }
        public Image BackgroundImage
        {
            get
            {
                return _backgroundImage;
            }
        }
        public string ProductionType
        {
            get
            {
                return _productionType;
            }
            set
            {
                _productionType = value;
            }
        }
        public void clearControlList()
        {
            ControlList.Clear();
        }
        public ControlInfo this[int key]
        {
            get
            {
                if (this.ControlList.ContainsKey(key))
                {
                    return ControlList[key];
                }
                else
                {
                    return null;
                }
            }
        }
        public void Add(ControlInfo controlinfo)
        {
            if (controlinfo == null)
                return;
            if (ControlList.ContainsKey(controlinfo.seq))
                return;
            ControlList.Add(controlinfo.seq, controlinfo);
        }
        public int[] GetSeqList()
        {
            List<int> list = new List<int>();
            foreach(int key in ControlList.Keys)
            {
                list.Add(key);
            }
            return list.ToArray();
        }

    }
    class ControlInfo
    {
        public EventHandler click_event;
        public EventHandler mousehover_enter;
        public EventHandler mousehover_leave;
        public string ControlName;
        public int locationX;
        public int locationY;
        public ControlType Contype;
        public int seq;
        public ControlInfo(string name, int x, int y, string type, int seq, string[]namelist)
        {
            this.click_event = new EventHandler((s, e) =>
            {
                monitorDiag diag = new monitorDiag(name,namelist);
                diag.ShowDialog();
                diag.Dispose();
            });
            this.mousehover_enter = new EventHandler((s, e) =>
            {
                PictureBox p = (PictureBox)s;
                p.BackgroundImage = Properties.Resources.lg1;

            });
            this.mousehover_leave = new EventHandler((s, e) =>
            {
                PictureBox p = (PictureBox)s;
                p.BackgroundImage = Properties.Resources.lb1;
            });
            this.ControlName = name;
            this.locationX = x;
            this.locationY = y;
            this.seq = seq;
            switch (type)
            {
                case "button":
                    Contype = ControlType.Btn;
                    break;
                case "Select":
                    Contype = ControlType.Select;
                    break;
                case "Text":
                    Contype = ControlType.Text;
                    break;
                case "CheckBox":
                    Contype = ControlType.CheckBox;
                    break;
                default:
                    Contype = ControlType.Btn;
                    break;
            }
        }


    }
    public enum ControlType
    {
        Btn = 0,
        Select,
        Text,
        CheckBox
    }
}
