using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics opgave.

            List<int> listOfNumbers = new List<int> { 5, 4, 3, 2, 1 };
            List<int> listOfnumbersReversed = Generics.reverseList(listOfNumbers);

            foreach (int number in listOfNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            foreach (int number in listOfnumbersReversed)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            List<string> listOfStrings = new List<string> { "Fem", "Fire", "Tre", "To", "En" };
            List<string> listOfReversedStrings = Generics.reverseList(listOfStrings);

            foreach (string word in listOfStrings)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine();

            foreach (string word in listOfReversedStrings)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
