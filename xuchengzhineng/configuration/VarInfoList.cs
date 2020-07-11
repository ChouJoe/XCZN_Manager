using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xuchengzhineng.configuration
{
    class VarInfoList
    {
        SortedDictionary<string, VarInfo> VarList = new SortedDictionary<string, VarInfo>();

        private static VarInfoList _instance = null;
        public static VarInfoList VarInfo_list
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new VarInfoList();
                }
                return _instance;
            }
        }
        public VarInfo this[string name]
        {
            get
            {
                if (this.VarList.ContainsKey(name))
                {
                    return this.VarList[name];
                }
                else
                {
                    return null;
                }
            }
        }
        public int Length
        {
            get { return this.VarList.Count; }
        }
        public void Add(VarInfo x)
        {
            if (x == null)
                return;
            if (this.VarList.ContainsKey(x.Name))
                return;
            this.VarList.Add(x.Name, x);
        }
        public bool Contains(string key)
        {
            return VarList.ContainsKey(key);
        }
        public void Clear()
        {
            VarList.Clear();
        }
    }
}
