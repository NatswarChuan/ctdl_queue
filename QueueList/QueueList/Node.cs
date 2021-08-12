using System;
using System.Collections.Generic;
using System.Text;

namespace QueueList
{
    class Node
    {
        private int value;
        public Node next;

        public Node(int value)
        {
            this.value = value;
        }

        public int Value { get => value; set => this.value = value; }
    }
}
