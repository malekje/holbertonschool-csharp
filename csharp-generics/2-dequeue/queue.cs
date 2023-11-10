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

    /// Removes the first node in the queue a returns its value
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

    /// Add a new node to the queue
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
}
