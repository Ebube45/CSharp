using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Stack
    {
        // Internal list to store stack elements.
        private readonly List<object> _elements = new List<object>();

        // Pushes an item onto the stack. Throws an exception if null is provided.
        public void Push(object item)
        {
            if (item == null)
                throw new InvalidOperationException("Null value not allowed.");
            _elements.Add(item);
        }

        // Pops the top item from the stack. Throws an exception if the stack is empty.
        public object Pop()
        {
            if (_elements.Count == 0)
                throw new InvalidOperationException("Stack is empty; cannot perform Pop.");

            int lastIndex = _elements.Count - 1;
            object topItem = _elements[lastIndex];
            _elements.RemoveAt(lastIndex);
            return topItem;
        }

        // Clears all items from the stack.
        public void Clear()
        {
            _elements.Clear();
        }
    }
}
