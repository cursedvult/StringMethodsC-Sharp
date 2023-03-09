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
            //Trims through all of the string
            Console.WriteLine(car.Trim());
            //Finds the index where certain word or character is placed on the string
            Console.WriteLine(sentence.IndexOf("bigger"));
            //Verifies if the string is null or just has white spaces.
            //If yes, returns true, if not, returns false
            bool nult = String.IsNullOrWhiteSpace(nullify);
            Console.WriteLine(nult);
            //Takes away characters from a string until it reaches a specified index
            Console.WriteLine(car.Substring(5));
            //String format puts an object and puts it in another 
            //already existing string
            Console.WriteLine(String.Format("My words are better. {0}", sentence));
        }

    }
}
