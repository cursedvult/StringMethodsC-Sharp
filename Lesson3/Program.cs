using System;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string car = "sandero";
            string sentence = "My words are not the bigger, but are the better";
            string nullify = "";
            Console.WriteLine(car.Trim());
            Console.WriteLine(sentence.IndexOf("bigger"));
            bool nult = String.IsNullOrWhiteSpace(nullify);
            Console.WriteLine(nult);
            //Console.WriteLine(car.Substring(5));
        }

    }
}
