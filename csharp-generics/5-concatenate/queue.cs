using System;

///<summary>  Create new class called Queue</summary>
public class Queue<T>
{
    /// First node
    public Node head;
    /// Last node
    public Node tail;
    /// Number of nodes
    public int count;

    /// Returns the Queue's Type
    public Type CheckType()
    {
        return typeof(T);
    }
    ///<summary>  Create new class called Node</summary>
    public class Node
    {
        /// Node class prop
        public T value = default(T);
        /// Next Node 
        public Node next = null;
        /// Constructor
        public Node(T val)
        {
            value = val;
        }
    }

    /// Removes the first node in the queue and returns its value
    public T Dequeue()
    {
        if (head != null)
        {
            T NodeValue = head.value;
            head = head.next;
            count--;
            return NodeValue;
        }
        else
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
    }

    /// Add new node to queue
    public void Enqueue(T val)
    {
        Node nNode = new Node(val);
        
        if (head == null)
        {
            head = nNode;
            tail = nNode;
        }
        else
        {
            tail.next = nNode;
            tail = nNode;
        }
        count++;
    }

    /// Returns the number of Nodes
    public int Count()
    {
        return(count);
    }

    /// Returns the value of the first node od the queue
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return (head.value);
        }
    }

    /// Print queue from the head
    public void Print()
    {
        if (head == null)
            Console.WriteLine("Queue is empty");
        
        Node tmp = head;

        for(int i = 0; i < count; i++)
        {
            Console.WriteLine(tmp.value);
            tmp = tmp.next;
        }
    }

    /// Concatenate all values of type string or char in the queue
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (null);
        }
        Node tmp = head;
        string concat = "";
        if (typeof(T) == typeof(Char) || typeof(T) == typeof(string))
        {
            while (tmp != null)
            {
                concat += tmp.value;
                if (typeof(T) == typeof(string) && tmp.next != null)
                {
                    concat += " ";
                }
                tmp = tmp.next;
            }
            return (concat);
        }
        else
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return (null);
        }
    }
}
