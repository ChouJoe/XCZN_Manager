using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace xuchengzhineng.Auth
{
    class AuthControl
    {
        private Dictionary<string, User> Userlist;
        private User current_user;
        private static AuthControl _instance = null;
        private AuthControl()
        {
            Userlist = new Dictionary<string, User>();
            current_user = null;
        }
        public static  AuthControl GetInstance()
        {
            if (_instance == null)
            {
                _instance =  new AuthControl();
            }
 
                return _instance;
            
        }
        public void loadXml()
        {
            Userlist.Clear();
            string filename = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                Properties.Settings.Default.AuthConfigPath);
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNode root = doc.SelectSingleNode("UserConfig");
            foreach(XmlNode xn in root.ChildNodes)
            {
                XmlElement xe = (XmlElement)xn;
                string type = xe.GetAttribute("type");
                string name = xe.GetAttribute("name");
                int level = int.Parse( xe.GetAttribute("value"));
                string hash = xe.GetAttribute("hash");
                User user_ = new User(type, name, level, hash);
                Userlist.Add(type, user_);

            }

        }
        public List<string> UserNameList
        {
            get
            {
                List<string> namelist = new List<string>();
                foreach (KeyValuePair<string, User> kvp in Userlist)
                {
                    namelist.Add(kvp.Value.Name);
                }
                return namelist;
            }

        }
    }
    class User
    {
        private string _type;
        private string _name;
        private int _level;
        private string _hash;

       public User(string type, string name, int value,string hash)
        {
            _type = type;
            _name = name;
            _level = value;
            _hash = hash;
        }
        public string Type
        {
            get
            {
                return this._type;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public int Level
        {
            get
            {
                return this._level;
            }
        }
        public string Hash
        {
            get
            {
                return this._hash;
            }
        }
    }
}
