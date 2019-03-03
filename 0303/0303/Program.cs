using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0303
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5 };

            int x = 1;
            goo(x);
            // based on Array behind the scenese
            ArrayList listOfNumbers = new ArrayList();

            listOfNumbers.Add(1);
            int number = (int)listOfNumbers[0];
            listOfNumbers.Add("Hello");

            List<int> lst = new List<int>();
            // avoid boxing /unboxing
            lst.Add(5);
            // type safety
            // this will not work
            //lst.Add("hello");

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Shape());
            shapes.Add(new Circle());

            List<Circle> circles = new List<Circle>();
            circles.Add(new Circle());
            // failure
            //circles.Add((Circle)new Shape());

            Console.WriteLine("===================================");
            List<int> numbers = new List<int>() { 1, 3, 5, 0, -8 };

            numbers.Sort();

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            numbers.ForEach(n => Console.WriteLine(n));

            // typesafe

            //object o = 1;

            //listOfNumbers.Add("Hello");

            //foreach (Object o in listOfNumbers)
            //{
            //    Console.WriteLine(o);
            //}

            //listOfNumbers.RemoveAt(0);

            //Console.WriteLine("==============================");
            //foreach(Object o in listOfNumbers)
            //{
            //    Console.WriteLine(o);
            //}

        }

        static void goo(int x)
        {
                Console.WriteLine(x);

            //moo(x);
            if (x < 3)
                goo(x+1);
        }

        private static void moo(int x)
        {
            Console.WriteLine(x);
        }
    }
}
