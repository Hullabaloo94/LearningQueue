using System;
using System.Collections;
using System.Collections.Generic;

namespace LearningQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queues are FIFO, they act just like a queue at a supermarket.
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


            // Show element at front of queue then remove from the queue.
            Console.WriteLine(queue.Dequeue());
            // Show element at front of queue
            Console.WriteLine(queue.Peek());



        }
    }
}
