using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWork
{
    public class List<T>
    {
        public List()
        {
            throw new Exception();
        }
        Node<T> head;
        Node<T> tail;
        int count;
        public int Count { get { return count;  } }
        public T this[int index]
        {
            get
            {
                throw new Exception();
            }

            set
            {
                throw new Exception();
            }
        }
        public void PushBack(T data)
        {
            throw new Exception();
        }
        public void PushUp(T data)
        {
            throw new Exception();
        }

        public void Remove(T data)
        {
            throw new Exception();
        }

        public void RemoveAt(int index)
        {
            throw new Exception();
        }
            
        

        public void Clear() 
        {
            throw new Exception();
        }

        public bool Contains(T data) 
        {
            throw new Exception();
        }


    }
}
