using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turbo.az
{
    internal class Cars
    {
        public string marka;
        public string model;
        public int year;
        public double price;

        public string GetFullName()
        {
            return $"{marka} {model} {year} {price}";
        }

    }
}
