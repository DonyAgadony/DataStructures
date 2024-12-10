namespace AniHamelech;
class QueueList<T>
{
    Node<T> FirstNode;

    Node<T>? LastNode;
    public QueueList()
    {

    }

    public void Enqueue(T value) //O(1)
    {
        if (FirstNode == null)
        {
            FirstNode = new(value);
            LastNode = FirstNode;
        }
        else
        {
            Node<T> node = new(value);
            LastNode.SetNext(node);
            LastNode = LastNode.GetNext();
        }
    }

    public T Dequeue() //O(1)
    {
        T rtn = FirstNode.GetValue();
        FirstNode = FirstNode.GetNext();
        return rtn;
    }

    public T Peek() //O(1)
    {
        return FirstNode.GetValue();
    }

    public int GetSize() //O(n) (n - size)
    {
        int count = 0;
        while (FirstNode.HasNext())
        {
            count++;
            FirstNode = FirstNode.GetNext();
        }
        return count;
    }

    public bool IsEmpty() //O(1)
    {
        return FirstNode == null;
    }

    public bool Contains(T value) //O(n)
    {
        while (FirstNode.HasNext())
        {
            if (FirstNode.GetValue().Equals(value))
                return true;
        }
        return true;
    }

    public QueueList<T> Reverse() //O(n) (n=size)
    {
        StackList<T> stack = new();
        int size = GetSize();
        while (FirstNode.HasNext())
        {
            stack.Push(FirstNode.GetValue());
            FirstNode = FirstNode.GetNext();
        }
        QueueList<T> NewQueue = new();
        for (int i = 0; i < size; i++)
        {
            NewQueue.Enqueue(stack.Pop());
        }
        return NewQueue;
    }

}