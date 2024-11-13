using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the size of CQueue");
            int len = int.Parse(Console.ReadLine());
            CQueue CQ = new CQueue(len);
            // Add multiple elements to CQueue
            for (int i = 0; i < 10; i++)
            {
                if (CQ.IsFull())
                {
                    Console.WriteLine("CQueue is Full!");
                    break;
                }
                else
                {
                    Console.WriteLine("input your element");
                    int x = int.Parse(Console.ReadLine());
                    CQ.Enqueue(x);
                }
            }
            // Delete two element from CQueue
            for (int i = 0; i < 2; i++)
            {
                if (CQ.IsEmpty())
                {
                    Console.WriteLine("CQueue is Empty!");
                    break;
                }
                else
                {
                    int x = CQ.Dequeue();
                    Console.WriteLine("The Deleted element is " + x);
                }
            }
            // CQueue Size
            if (CQ.IsEmpty())
                Console.WriteLine("CQueue is Empty!");
            else
                Console.WriteLine("The CQueue size is " + CQ.QueueSize());
           
            // get First element
            if (CQ.IsEmpty())
                Console.WriteLine("CQueue is Empty!");
            else
                Console.WriteLine("The First element is " + CQ.First());
            // get Last element
            if (CQ.IsEmpty())
                Console.WriteLine("CQueue is Empty!");
            else
                Console.WriteLine("The Last element is " + CQ.Last());
            //Display CQueue elements
            if (CQ.IsEmpty())
                Console.WriteLine("CQueue is Empty!");
            else
                CQ.Display();
            // Add elements to CQueue
            for (int i = 0; i < 10; i++)
            {
                if (CQ.IsFull())
                {
                    Console.WriteLine("CQueue is Full!");
                    break;
                }
                else
                {
                    Console.WriteLine("input your element");
                    int x = int.Parse(Console.ReadLine());
                    CQ.Enqueue(x);
                }
            }
            // CQueue Size
            if (CQ.IsEmpty())
                Console.WriteLine("CQueue is Empty!");
            else
                Console.WriteLine("The CQueue size is " + CQ.QueueSize());
            //Display CQueue elements
            if (CQ.IsEmpty())
                Console.WriteLine("CQueue is Empty!");
            else
                CQ.Display();

            // Delete multiple element from CQueue
            for (int i = 0; i < 10; i++)
            {
                if (CQ.IsEmpty())
                {
                    Console.WriteLine("CQueue is Empty!");
                    break;
                }
                else
                {
                    int x = CQ.Dequeue();
                    Console.WriteLine("The Deleted element is " + x);
                }
            }
            Console.ReadKey();
        }
    }
}
