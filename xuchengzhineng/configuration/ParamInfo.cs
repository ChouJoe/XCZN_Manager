using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace xuchengzhineng.configuration
{
    class ParamInfo
    {
        private int id;
        private string name;
        private string units;
        private uint address;
        private string opcname;
        public int ID { get { return id; } }
        public string Name { get { return name; } }
        public string Units { get { return units; } }
        public uint Address { get { return address; } }
        public string OpcName { get { return opcname; } }
        public ParamInfo(int id_, uint address_, string name_, string units_, string opcname_)
        {
            this.id = id_;
            this.address = address_;
            this.name = name_;
            this.units = units_;
            this.opcname = opcname_;
        }
    }
}
