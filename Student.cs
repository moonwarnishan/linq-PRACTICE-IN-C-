using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Student : Mmain
    {
        public Student(int Id,string Name, string Oc):base(Id,Name, Oc)
        {

        }
        public override void Details()
        {
            Console.WriteLine($"Hey My name is {_Name} my occuption is {_Oc}, am from school");
        }
    }
}
