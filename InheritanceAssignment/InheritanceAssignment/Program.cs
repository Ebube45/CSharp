using System;
using InheritanceAssignment;

namespace InheritanceExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myStack = new Stack();

            try
            {
                // Push items onto the stack
                myStack.Push(1);
                myStack.Push(2);
                myStack.Push(3);

                // Pop and print items from the stack (LIFO order)
                Console.WriteLine(myStack.Pop()); // Expected output: 3
                Console.WriteLine(myStack.Pop()); // Expected output: 2
                Console.WriteLine(myStack.Pop()); // Expected output: 1
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
