using System;
using System.Collections.Generic;
using System.Text;

namespace QueueList
{
    class Queue
    {
        //fields
        private Node first;
        private Node last;
        private int count;

        //constructors
        public Queue()
        {
            this.count = 0;
        }

        //properties
        public int Count { get => count; }

        //fields
        /// <summary>
        /// Endqueue: insert value in last
        /// </summary>
        /// <param name="value"></param>
        public void Endqueue(int value)
        {
            Node node = new Node(value);
            if (this.count == 0)
            {
                this.first = node;
                this.last = node;
            }
            else
            {
                this.last.next = node;
                this.last = node;
            }
            this.count++;
        }

        /// <summary>
        /// Peek: return first value
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return this.first.Value;
        }

        /// <summary>
        /// Dequeue return and remove first value
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            int value = this.first.Value;
            this.first = this.first.next;
            this.count--;
            return value;
        }

        /// <summary>
        /// clear all data
        /// </summary>
        public void Clear()
        {
            this.first = null;
            this.last = null;
            this.count = 0;
        }
        /// <summary>
        /// find with value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Find(int value)
        {
            Node node = null;

            for (Node i = this.first; i != null; i=i.next)
            {
                if (i.Value == value)
                {
                    node = i;
                    break;
                }
            }

            return node;
        }

        /// <summary>
        /// find last with value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node FindLast(int value)
        {
            Node node = null;

            for (Node i = this.first; i != null; i = i.next)
            {
                if (i.Value == value)
                {
                    node = i;
                }
            }
            return node;
        }

        /// <summary>
        /// Bubble Sort
        /// </summary>
        public void BubbleSort()
        {
            for (Node i = this.first; i != null; i = i.next)
            {
                for (Node j = this.first; j.next != null; j = j.next)
                {
                    if (j.Value < j.next.Value)
                    {
                        Swap(ref j, ref j.next);
                    }
                }
            }
        }

        /// <summary>
        /// Interchange sort
        /// </summary>
        public void InterchangeSort()
        {
            for (Node i = this.first; i.next != null; i = i.next)
            {
                for (Node j = i.next; j != null; j = j.next)
                {
                    if (j.Value < i.Value)
                    {
                        Swap(ref j, ref i);
                    }
                }
            }
        }

        /// <summary>
        /// swap node1 node2
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        private void Swap(ref Node node1, ref Node node2)
        {
            int value = node1.Value;
            node1.Value = node2.Value;
            node2.Value = value;
        }

        public void Show()
        {
            for (Node i = this.first; i != null; i = i.next)
            {
                Console.WriteLine(i.Value);
            }
            Console.WriteLine($"count: {this.count}");
        }
    }
}
