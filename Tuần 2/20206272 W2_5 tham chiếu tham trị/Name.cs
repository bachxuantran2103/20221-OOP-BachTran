using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206272_W2_5_tham_chiếu_tham_trị
{
    class Name
    {
        public string _Name;
        public int _Age;
        public Name() { }
        public Name(string name, int age)
        {
            this._Name = name;
            this._Age = age;
        }

        static public void SwapValue(Name a, Name b)
        {
            Name temp = new Name();
            temp._Name = a._Name; temp._Age = a._Age;
            a._Name = b._Name; a._Age = b._Age;
            b._Name = temp._Name; b._Age = temp._Age;
        }
        static public void SwapReference(ref Name a, ref Name b)
        {
            /*Name tem = new Name();
            tem = a;
            a = b; b = tem;*/
            Name temp = new Name();
            temp._Name = a._Name; temp._Age = a._Age;
            a._Name = b._Name; a._Age = b._Age;
            b._Name = temp._Name; b._Age = temp._Age;
        }
    }
}
