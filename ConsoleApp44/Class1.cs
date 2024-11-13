using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class CQueue
    {
        int front;
        int rear;
        int size;
        int[] CQueuearr;
        public CQueue(int len)
        {
            size = len;
            CQueuearr = new int[size];
            front = -1;
            rear = -1;
        }
        public bool IsEmpty()
        {
            return (rear == -1);
        }
        public bool IsFull()
        {
            return ((front == 0 && rear == size - 1) || (front == rear + 1));
        }
        //Add element
        public void Enqueue(int element)
        {
            rear = (rear + 1) % size;
            CQueuearr[rear] = element;
            if (front == -1) // for first item added
                front++;
        }
        //Delete element
        public int Dequeue()
        {
            int x = CQueuearr[front];
            if (front == rear) //for last element removed
            {
                front = -1;
                rear = -1;
            }
            else
                front = (front + 1) % size;
            return x;
        }
        public int QueueSize()
        {
            return ((size - front + rear) % size) + 1;
        }
        //Get First element
        public int First()
        {
            return CQueuearr[front];
        }
        //Get Last element
        public int Last()
        {
            return CQueuearr[rear];
        }
        public void Display()
        {
            Console.WriteLine("The elements of CQueue is ");
            int i;
            // display CQ elements
            for (i = front; i != rear; i = (i + 1) % size)
            {
                Console.WriteLine(CQueuearr[i]);
            }
            // display last element only
            Console.WriteLine(CQueuearr[i]);
        }
    }
}
