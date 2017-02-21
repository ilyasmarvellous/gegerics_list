using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_list
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> s = new List<string>(7);
            s.Add("Ilyas");
            s.Add("Teja");
            s.Add("Umakanth");
            s.Add("Rajeesh");
            s.Add("Rohan");
            s.Add("Bharat");
            s.Add("Venu");
            foreach (var v  in s)
                Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}
