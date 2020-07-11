using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using opcua_s7_1500_client;
namespace xuchengzhineng.Connection
{
    class connectManager
    {
        private static connectManager _instance ;
        private OPCClient OPC;
        public static  bool Connected = false;
        public static connectManager OpcInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new connectManager();
                }
                return _instance;
            }
        }
        public connectManager()
        {
              OPC = new OPCClient();
        }
        public bool Connect(string ip)
        {     
            bool res = OPC.Create(ip);
            if (res)
            {
                Connected = true;
            }
            return res;
        }
        public void DisConnect()
        {
               OPC.Close();
               Connected = false;
        }
        public string Read(string name)
        {
            string result = "";
            if (Connected)
            {
                result =  OPC.Read(name);
            }
            return result;
        }
        public void Write(string name, string value)
        {
            if (Connected)
            {
                OPC.Write(name, value);
            }
        }


    }
}
