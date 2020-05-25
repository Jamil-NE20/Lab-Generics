using System;
using System.Collections.Generic;

namespace BoxOfT
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove()); // removes element 1 and 2
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove()); //remove element 4


            Console.WriteLine("Any Key to Quit!");
            Console.ReadLine();
        }
    }
}
