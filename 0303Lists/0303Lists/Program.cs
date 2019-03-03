using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0303Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mobile> phones = new List<Mobile>()
            {
                new Mobile(2020, "IPhone 10x", 0.9f, 5500),
                new Mobile(2018, "Samsung S10+", 1.5f, 4500),
                new Mobile(2019, "LG v40", 1.2f, 4900),
                new Mobile(2007, "Nokia 900", 4.5f, 10)
            };

            var r = phones[0];

            phones.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("==================== Compare default: by price");
            phones.Sort();
            phones.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("==================== Compare default: by year");
            phones.Sort(new MobileCompareByYear());
            phones.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("=============================");
            MyMobileStack myMobileStack = new MyMobileStack();
            myMobileStack.Init(phones);

            Console.WriteLine(myMobileStack.Pop());
            Console.WriteLine(myMobileStack.Pop());
            Console.WriteLine(myMobileStack.Size);
        }
    }
}
