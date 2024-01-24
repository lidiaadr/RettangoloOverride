using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RettangoloOverride
{
    internal class Rettangolo
    {
        public float Lato1 { get; set; }
        public float Lato2 { get; set; }

        public Rettangolo(float lato1, float lato2)
        {
            Lato1 = lato1;
            Lato2 = lato2;
        }

        public float Area()
        {
            return (Lato1 * Lato2) / 2;
        }
        public float Perimetro()
        {
            return (2 * Lato1) + (2 * Lato2);
        }
        public override string ToString()
        {
            return string.Format("{0}", Lato1, Lato2);
        }
    }
}
