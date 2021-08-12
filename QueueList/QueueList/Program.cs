using System;
using System.Collections.Generic;

namespace QueueList
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            Console.WriteLine($"Enqueue: 1 2 3 1");
            queue.Endqueue(1);
            queue.Endqueue(2);
            queue.Endqueue(3);
            queue.Endqueue(1);
            queue.Show();

            Console.WriteLine($"Peek: {queue.Peek()}");

            Console.WriteLine($"Dequeue: {queue.Dequeue()}");

            Console.WriteLine($"Find: {queue.Find(1).Value}");

            Console.WriteLine($"FindLast: {queue.FindLast(1).Value}");

            Console.WriteLine("Bubble sort:");
            queue.BubbleSort();
            queue.Show();

            Console.WriteLine("Interchange sort:");
            queue.InterchangeSort();
            queue.Show();

        }
    }
}
