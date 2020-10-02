using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWork
{
    public class Queue<T>
    {
        private List<T> m_Items;
        public int Count => m_Items.Count;
        public Queue()
        {
            m_Items = new List<T>();            
        }
        public Queue(params T[] values) 
        {
            m_Items = new List<T>(values);            
        }
        public void Enqueue(T item)
        {
            m_Items.PushBack(item);
        }
        public T Dequeue()
        {
            T item = m_Items[0];
            m_Items.RemoveAt(0);
            return item;            
        }
        public T Peek() 
        {
            T item = m_Items[0];
            return item; 
        }        
    }
}
