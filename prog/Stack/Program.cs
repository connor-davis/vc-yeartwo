using System.Collections;

namespace Stacks
{
    class Program
    {
        public static void Main(string[] args)
        {
            /**
             * Stack
             * Create an object of a stack
             * Imports from the Collections class
             */
            Stack stack = new Stack();

            /**
             * Push -> Inserts an object into the stack
             * Pop -> Removes & returns an item at the top of the stack
             * Clear -> Removes all items in the stack
             * Clone -> Creates a shallow copy of the stack
             * Contains -> Checks if an item exists in the stack
             *          -> returns a boolean True/False
             * Peek -> Returns the top item in the stack
             * 
             * -> Last In First Out storage
             */

            stack.Push("First Item");
            stack.Push("Second Item");
            stack.Push(1000);
            stack.Push(null);
            stack.Push(3.14159);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
