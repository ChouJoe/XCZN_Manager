using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace xuchengzhineng.configuration
{
    class ParamInfoList
    {
        SortedDictionary<string, ParamInfo> ParamList = new SortedDictionary<string, ParamInfo>();
        List<String> paramNameList = new List<string>();
        Dictionary<int, string> ID_NameList = new Dictionary<int, string>();
        private static ParamInfoList _instance = null;
        public static ParamInfoList ParamInfo_list
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ParamInfoList();
                }
                return _instance;
            }
        }
        public List<String> ParamNameList
        {
            get
            {
                return paramNameList;
            }
        }
        public ParamInfo this[int id]
        {
            get
            {
                if (this.ID_NameList.ContainsKey(id))
                {
                    return this.ParamList[ ID_NameList[id] ];
                }
                else
                {
                    return null;
                }
            }
        }
        public ParamInfo this[string name]
        {
            get
            {
                if (this.ParamList.ContainsKey(name))
                {
                    return this.ParamList[name];
                }
                else
                {
                    return null;
                }
            }
        }
        public int Length
        {
            get { return this.ParamList.Count; }
        }
        public void Add(ParamInfo x)
        {
            if (x == null)
                return;
            if (this.ParamList.ContainsKey(x.Name))
                return;
            this.ParamList.Add(x.Name, x);
            this.paramNameList.Add(x.Name);
            this.ID_NameList.Add(x.ID, x.Name);
        }
        public bool Contains(string key)
        {
            return ParamList.ContainsKey(key);
        }
        public void Clear()
        {
            ParamList.Clear();
            paramNameList.Clear();
            ID_NameList.Clear();
        }
    }
}
