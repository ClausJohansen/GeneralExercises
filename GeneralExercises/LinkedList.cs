using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralExercises
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node firstElement;

        public void Add<T>(T element)
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private class Node
        {
            protected T Value { get; set; }
            protected Node Next { get; set; }

            protected Node(T value)
            {
                this.Value = value;
            }
        }
    }
}
