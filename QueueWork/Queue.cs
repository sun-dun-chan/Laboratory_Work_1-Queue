using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWork
{
    public class Queue<T>
    {
        private List<T> m_Items = new List<T>();
        public int Count => m_Items.Count;
        public Queue()
        {
            throw new Exception();
        }
        public void Enqueue(T item)
        {
            throw new Exception();
        }
        public T Dequeue()
        {
            throw new Exception();
        }
        public T Peek() 
        {
            throw new Exception();
        }
    }
}
