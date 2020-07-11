using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace xuchengzhineng.configuration
{
    class ConfigLoader
    {
        
        private static ConfigLoader _configLoader = null;
        private string _FirmwareVersion = null;
        private static string c_ip = null;
        private AssemblyLineManager assemblyline = AssemblyLineManager.GetInstance();
        public string FirmwareVersion
        {
            get { return _FirmwareVersion; }
        }
        public static string CONNECT_IP
        {
            get
            {
                return c_ip;
            }
        }
        public static ConfigLoader GetInstance()
        {
            if(_configLoader == null)
            {
                _configLoader = new ConfigLoader();
            }
            return _configLoader;
        }
        public void loadXml(string path, string ip)
        {
            c_ip = ip;
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            assemblyline.clearControlList();
            XmlNode root = xml.SelectSingleNode("ProductionConfig");
            assemblyline.ProductionType = root.Attributes["name"].Value;
            _FirmwareVersion= root.Attributes["firmware"].Value;
            XmlNode xnode = root.SelectSingleNode("BackgroundImage");
             assemblyline.getImage(xnode.Attributes["name"].Value);
            xnode = root.SelectSingleNode("AssemblyLine");
            foreach (XmlNode step in xnode.ChildNodes)
            {
                XmlNode monitor = step.SelectSingleNode("monitor");
                XmlNode lxnode = monitor.SelectSingleNode("lx");
                XmlNode lynode = monitor.SelectSingleNode("ly");
                XmlNodeList varnodelist = monitor.SelectNodes("var");
                List<string> varnamelist = new List<string>();
                foreach (XmlNode child in varnodelist)
                {
                    varnamelist.Add(child.Attributes["name"].Value);
                }
                string StepName = step.Attributes["name"].Value;
                int Seq = int.Parse(step.Attributes["seq"].Value);
                string controltype = monitor.Attributes["control"].Value;
                int lx = Convert.ToInt32(lxnode.InnerText.Trim());
                int ly = Convert.ToInt32(lynode.InnerText.Trim());

                assemblyline.Add(new ControlInfo(StepName, lx, ly, controltype, Seq, varnamelist.ToArray()));
            }

            xnode = root.SelectSingleNode("VariableTable");
            VarInfoList.VarInfo_list.Clear();
            foreach (XmlNode varnode in xnode.ChildNodes)
            {
                string name = varnode.Attributes["Name"].Value;
                int id = Convert.ToInt32(varnode.Attributes["ID"].Value);
                uint address = Convert.ToUInt32(varnode.SelectSingleNode("Address").InnerText.Trim());
                string units = varnode.SelectSingleNode("Units").InnerText.Trim();
                string opcname = varnode.SelectSingleNode("opcName").InnerText.Trim();
                string type = varnode.SelectSingleNode("Type").InnerText.Trim();
                VarInfo varinfo = new VarInfo(id, address, name, units, opcname,type);
                if (!VarInfoList.VarInfo_list.Contains(varinfo.Name))
                {
                    VarInfoList.VarInfo_list.Add(varinfo);
                }
            }

            xnode = root.SelectSingleNode("ParameterTable");
            ParamInfoList.ParamInfo_list.Clear();
            foreach(XmlNode parnode in xnode.ChildNodes)
            {
                string name = parnode.Attributes["Name"].Value;
                int id = Convert.ToInt32(parnode.Attributes["ID"].Value);
                uint address = Convert.ToUInt32(parnode.SelectSingleNode("Address").InnerText.Trim());
                string units = parnode.SelectSingleNode("Units").InnerText.Trim();
                string opcname = parnode.SelectSingleNode("opcName").InnerText.Trim();
                ParamInfo paraminfo = new ParamInfo(id, address, name, units, opcname);
                if (!ParamInfoList.ParamInfo_list.Contains(paraminfo.Name))
                {
                    ParamInfoList.ParamInfo_list.Add(paraminfo);
                }
            }


        }
    }
}
