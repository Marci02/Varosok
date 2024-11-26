using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varosok
{
    internal class Nagyvaros
    {
        public string Varos { get; set; }
        public string Orszag { get; set; }
        public decimal Nepesseg { get; set; }


        public override string ToString()
        {
            return $"{Varos} ({Orszag}) -  {Nepesseg:F0} fő";
        }

        public Nagyvaros(string sor)
        {
            var v = sor.Split(';');
            Varos = v[0];
            Orszag = v[1];
            Nepesseg = decimal.Parse(v[2]) * 1000000;
        }
    }
}
