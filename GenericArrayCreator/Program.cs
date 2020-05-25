using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace GenericArrayCreator
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] strings = ArrayCreator.Create(5, "Peter");
            int[] integers = ArrayCreator.Create(10, 33);

            
            Console.WriteLine("\n\nAny Key to Quit!");
            Console.ReadLine();
        }
    }
}
