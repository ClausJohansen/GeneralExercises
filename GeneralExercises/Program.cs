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
            // GenericsExercise();
            LinkedListExercise();
            Console.ReadKey();
        }

        private static void GenericsExercise()
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

             // Lav en generic liste af strings. Udskriv alle elementer.

             List<int> intList = new List<int> { 23, 2, 87, 9000 };

             foreach(int number in intList)
             {
                 Console.Write(number + " ");
             }

             Console.WriteLine();


             // Lav en generic liste af ints. Udskriv alle elementer.

             List<string> stringList = new List<string> { "Ged", "Dobbeltdækker", "Syngende", "Bly" };

             foreach (string word in stringList)
             {
                 Console.Write(word + " ");
             }

             Console.WriteLine();
        }

        private static void LinkedListExercise()
        {
            LinkedList<int> list = new LinkedList<int>();

            // list.FirstElement = new Node(1);



        }
    }
}
