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
        T value = default(T);
        /// Next Node
        public Node next = null;
        /// Constructor
        public Node(T val)
        {
            value = val;
        }
    }

    /// Adding new node to the queue
    public Node Enqueue(T val)
    {
        Node nNode = new Node(val);
        
        if (head == null)
        {
            head = nNode;
        }
        else
        {
            nNode.next = head;
            tail = nNode;
        }
        count++;
        return head;
    }

    /// Returns number of nodes
    public int Count()
    {
        return(count);
    }

}
