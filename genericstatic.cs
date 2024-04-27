using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{
  class genericstatic
  {
        static void Main(string[] args)
        {
           
            
                // Using Stack<T> creating elements in stack by using push method 
                Console.WriteLine("Using Stack<T>:");
                Stack<int> stack = new Stack<int>();
                stack.Push(10);
                stack.Push(20);
                stack.Push(30);
                Console.WriteLine("Stack elements:");
                foreach (int item in stack)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();

            //pop method is used to remove the element from the stack (last in , first out)

            stack.Pop();
            Console.WriteLine("Stack elements:");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();



            // Using Queue<T>creating elements in queue by using Enqueue method 
            Console.WriteLine("Using Queue<T>:");
                Queue<string> queue = new Queue<string>();
                queue.Enqueue("Apple");
                queue.Enqueue("Banana");
                queue.Enqueue("Orange");
                Console.WriteLine("Queue elements:");
                foreach (string item in queue)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();

            queue.Enqueue("Papaya");
            Console.WriteLine("Queue elements:");
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            queue.Dequeue();
            Console.WriteLine("Queue elements:");
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            // Using Dictionary<T1, T2>
            Console.WriteLine("Using Dictionary<T1, T2>:");
                Dictionary<int, string> dictionary = new Dictionary<int, string>();
                dictionary.Add(1, "One");
                dictionary.Add(2, "Two");
                dictionary.Add(3, "Three");
                Console.WriteLine("Dictionary elements:");
                foreach (var item in dictionary)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            



        }
  }
}


