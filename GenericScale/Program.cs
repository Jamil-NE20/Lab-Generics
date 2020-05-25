using System;

namespace GenericScale
{
   public class Program
    {
        public static void Main(string[] args)
        {

            var Myscale1 = new Scale<int>(10, 20);
            Console.WriteLine(Myscale1.GetHeavier());

            var Myscale2 = new Scale<string>("Love", "Hate");
            Console.WriteLine(Myscale2.GetHeavier());


            Console.WriteLine("Any Key to Quit!");
            Console.ReadLine();
        }
    }
}
