using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWork
{
    public class List<T> 
    {
        Node<T> head;
        Node<T> tail;
        int count;
        public List()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public List(params T[] values) 
        {
            for (int i = 0; i < values.Length; i++) PushBack(values[i]);           
        }
        public List(List<T> list) 
        {
            for (int i = 0; i < list.count; i++) PushBack(list[i]);
        }
        public int Count { get { return count;  } }
        public T this[int index]
        {
            get
            {
                if (count == 0) throw new NullReferenceException();
                if (index < 0 || index > count - 1) 
                    throw new System.IndexOutOfRangeException("Index out of range");
                else 
                {
                    Node<T> current = head;
                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }
                    return current.Data;
                }
            }

            set
            {
                if (count == 0) throw new NullReferenceException();
                if (index < 0 || index > count - 1)
                    throw new System.IndexOutOfRangeException("Index out of range");
                else 
                {
                    Node<T> current = head;
                    for (int i = 0; i < index; i++)
                    {
                        current = current.Next;
                    }
                    current.Data = value;
                }                    
            }
        }
        public void PushBack(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
                head = node;
            else tail.Next = node;
            tail = node;
            count++;
        }
        public void PushUp(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;            
        }

        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null) 
            {
                if (current.Data.Equals(data)) 
                {
                    if (previous != null) 
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;                
                }
                
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > count - 1)
                throw new System.IndexOutOfRangeException("Index out of range");
            else
            {
                Node<T> current = head;
                Node<T> previous = null;
                for (int i = 0; i < index; i++)
                {
                    previous = current;
                    current = current.Next;                    
                }
                if (previous != null)
                {
                    previous.Next = current.Next;
                    if (current.Next == null)
                        tail = previous;
                }
                else
                {
                    head = head.Next;
                    if (head == null)
                        tail = null;
                }
                count--;                
            }                      
        }
        
        public void Clear() 
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data) 
        {
            Node<T> current = head;
            while(current != null) 
            {
                if (current.Data.Equals(data)) 
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public bool Equals(List<T> other)
        {
            if (this.count != other.count)
                return false;
            else
                for (int i = 0; i < this.count; i++) 
                {
                    if (!(this[i].Equals(other[i]))) 
                        return false;
                }
            return true;
        }
        public void Print() 
        {
            if (count == 0) Console.WriteLine("Empty list");
            else
            {
                for (int i = 0; i < count - 1; i++) Console.Write("{0} ", this[i]);
                Console.Write("{0}\n", this[count - 1]);
            }            
        }

        public void ConsoleInput() 
        {
            if (count == 0)
            {
                Console.Write("This list is empty. Enter the number of elements: ");
                int numOfElems = 0;
                while (true)
                {                        
                    if (Int32.TryParse(Console.ReadLine(), out numOfElems) && numOfElems > 0)
                    {
                        Console.WriteLine("Enter your elements through a space");
                        string[] s_values = Console.ReadLine().Split(" ");
                        try
                        {
                            for (int i = 0; i < numOfElems; i++)
                            PushBack((T)Convert.ChangeType(s_values[i], typeof(T)));
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input or type");
                        }
                            break;
                        }
                    else
                    {
                            Console.WriteLine("Invalid input. Try again.");                            
                    }
                }
            }
            else
            {
                int[] indexes = new int[2] { -1, -1 };
                Console.WriteLine("Write an index range for overwriting elements.");
                while (true)
                {
                    Console.Write("First index: ");
                    if (Int32.TryParse(Console.ReadLine(), out indexes[0]) && indexes[0] >= 0 && indexes[0] <= this.count - 1) 
                        break;
                    else 
                        Console.WriteLine("Invalid input. Try again.");
                }
                while (true) 
                {
                    Console.Write("Second index: ");
                    if (Int32.TryParse(Console.ReadLine(), out indexes[1]) && indexes[1] >= indexes[0] && indexes[1] <= this.count - 1) 
                        break;
                    else 
                        Console.WriteLine("Invalid input. Try again.");
                }
                Console.WriteLine("Enter your elements through a space");
                string[] s_values = Console.ReadLine().Split(" ");
                try
                {
                    for (int i = indexes[0]; i <= indexes[1]; i++)
                    this[i] = (T)Convert.ChangeType(s_values[i - indexes[0]], typeof(T));                            
                }
                    catch (FormatException) 
                {
                    Console.WriteLine("Invalid input or type");
                }
            }                           
        }  
    }
}
