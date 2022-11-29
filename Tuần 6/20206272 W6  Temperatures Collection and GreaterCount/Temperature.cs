using System.Collections.Generic;

namespace _20206272_W6_1__Temperatures_Collection
{
    public class Temperature
    {
        public List<double> _Listtemperatures { get; set; }

        public Temperature()
        {
            _Listtemperatures = new List<double>();
        }
        public static int GreaterCount2_1(List<double> _List, double IMin)
        {
            int _count = 0;
            foreach (double _temp in _List)
            {
                if (_temp >= IMin) _count++;
            }
            return _count;
        }
        static public int GreaterCount2_2(System.Collections.IEnumerable IList, double IMin)
        {
            int _Count = 0;
            foreach (var _Temp in IList)
            {
                double _x = double.Parse(_Temp.ToString());
                if (_x >= IMin) _Count++;
            }
            return _Count;
        }
    }
}
