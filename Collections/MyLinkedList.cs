namespace Collections;

public class MyLinkedList<T>
{
    public Node<T> Head { get; set; }
        
    public Node<T> Tail { get; set; }

    private int count;

    public Node<T> AddFirst(T data)
    {
        var node = new Node<T>(data, Head);
        Head = node;
        if (Tail == null)
        {
            Tail = Head;
        }

        count++;
        return node;
    }
    
    public Node<T> AddLast(T data)
    {
        var node = new Node<T>(data, null);
        count++;
        if (Head == null)
        {
            Head = node;
        }
        if (Tail == null)
        {
            Tail = Head;
            return node;
        }
        Tail.Next = node;
        Tail = node;
        return node;
    }

    public Node<T> AddBefore(T data, Node<T> node)
    {
        var prevNode = FindPrevious(node);
        var currentNode = new Node<T>(data, node);
        prevNode.Next = currentNode;
        count++;
        return currentNode;
    }
    
    public Node<T> AddAfter(T data, Node<T> node)
    {
        var currentNode = new Node<T>(data, node.Next);
        node.Next = currentNode;
        count++;
        return currentNode;
    }
    
    private Node<T> Find(T value)
    {
        var currentNode = Head.Next;
        while (!currentNode.Equals(Tail))
        {
            if (currentNode.Data.Equals(value)) return currentNode;
            currentNode = currentNode.Next;
        }

        return null;
    }
    
    private Node<T> FindPrevious(Node<T> node)
    {
        if (count == 1)
        {
            return node;
        }
        var currentNode = Head;
        while (!currentNode.Equals(Tail))
        {
            if (currentNode.Next == node)
            {
                return currentNode;
            }
            currentNode = currentNode.Next;
        }

        return null;
    }
}

public class Node<T>
{
    public T? Data { get; set; }
    
    public Node<T> Next { get; set; }

    public Node(T? data, Node<T> next)
    {
        Data = data;
        Next = next;
    }
}