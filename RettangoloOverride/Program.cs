using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RettangoloOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float l1 = float.Parse(Console.ReadLine());
            float l2 = float.Parse(Console.ReadLine());
            Rettangolo r = new Rettangolo (l2,l1);
            Console.WriteLine(r.Area());
            Console.WriteLine(r.Perimetro());
            Console.WriteLine(r.ToString());

            Console.WriteLine();
        }
    }
}
