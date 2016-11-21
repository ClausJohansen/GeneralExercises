using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralExercises
{
    class Generics
    {
        public static List<T> reverseList<T> (List<T> input)
        {
            List<T> result = new List<T>(input);
            result.Reverse();

            return result;
        }
    }
}
