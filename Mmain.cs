using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Mmain
    {
        internal int _Id { get; set; }
        internal string _Name { get; set; }
        internal string _Oc { get; set; }
        public Mmain(int Id,string Name, string Oc)
        {
            this._Id = Id;
            this._Name = Name;  
            this._Oc = Oc;
        }

        public virtual void Details()
        {
            Console.WriteLine($"Hey My name is {_Name} my occuption is {_Oc}");
        }
    }
}
