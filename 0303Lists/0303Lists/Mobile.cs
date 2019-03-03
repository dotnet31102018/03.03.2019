using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0303Lists
{
    class Mobile : IComparable<Mobile>
    {
        public int Year { get; set; }
        public string Model{ get; set; }
        public float Weight { get; set; }
        public int Price{ get; set; }
        public Mobile(int year, string model, float weight, int price)
        {
            Year = year;
            Model = model;
            Weight = weight;
            Price = price;
        }
        public override string ToString()
        {
            return $"Mobile Year {Year, 5} Model {Model, 15} Weight {Weight, 7} Price {Price, 5}";
        }
        public int CompareTo(Mobile other)
        {
            return this.Price - other.Price;
        }
    }

    class MobileCompareByYear : IComparer<Mobile>
    {
        public int Compare(Mobile x, Mobile y)
        {
            return x.Year - y.Year;
        }
    }
}
