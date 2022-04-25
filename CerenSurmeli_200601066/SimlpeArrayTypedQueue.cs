using System;
using System.Collections.Generic;
using System.Text;

namespace ÖdevBaslangic
{
    public class SimlpeArrayTypedQueue : IQueue
    {
        private object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        public int count = 0;

        public SimlpeArrayTypedQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }

        public void Insert(object o)
        {
            if ((count == size) || (rear == size - 1))
            {
                throw new Exception("Şu an sıra dolu lütfen daha sonra tekrar arayın.");
            }

            if (front == -1)
            {
                front = 0;
            }

            Queue[++rear] = o;
            count++;
        }

        public void Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Sırada müşteri yok");
            }
            object silinen = Queue[front];
            Queue[front] = null;
            front++;
            count--;
        }

        public object Peek()
        {
            if (IsEmpty())
            {
                return "";
            }
            else
            return Queue[front];
        }

        public bool IsEmpty()
        {
            return (count == 0 ? true : false);
        }
        

    }
}
