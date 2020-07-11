using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xuchengzhineng.configuration
{
    class VarInfo
    {  
       private int id;
       private string name;
       private string units;
       private uint address;
       private PLCType type;
       private string opcname;

       public int ID { get { return id; } }
       public string Name { get { return name; } }
       public string Units { get { return units; } }
       public uint Address { get { return address; } }
       public string OpcName { get { return opcname; } }
       public PLCType Type { get { return type; } }
        public VarInfo(int id_, uint address_,string name_,string units_, string opcname_, string type_)
        {
            this.id = id_;
            this.address = address_;
            this.name = name_;
            this.units = units_;
            this.opcname = opcname_;
            switch (type_)
            {
                case "Bool":
                    this.type = PLCType.Bool;
                    break;
                case "Int8":
                    this.type = PLCType.Int8;
                    break;
                case "Int16":
                    this.type = PLCType.Int16;
                    break;
                case "Int32":
                    this.type = PLCType.Int32;
                    break;
                case "Float":
                    this.type = PLCType.Float;
                    break;
                case "Word":
                    this.type = PLCType.World;
                    break;
                default:
                    this.type = PLCType.Int16;
                    break;

            }
        }
    }
    public enum PLCType
    {
        Bool,
        Int8,
        Int16,
        Int32,
        Float,
        World
    }
}
