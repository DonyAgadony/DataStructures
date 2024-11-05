namespace AniHamelech;
class QueueList<T>
{
    Node<T> FirstNode;

    Node<T>? LastNode;
    public QueueList()
    {

    }

    public void Enqueue(T value)
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

    public T Dequeue()
    {
        T rtn = FirstNode.GetValue();
        FirstNode = FirstNode.GetNext();
        return rtn;
    }

    public T Peek()
    {
        return FirstNode.GetValue();
    }

    public int GetSize()
    {
        int count = 0;
        while (FirstNode.HasNext())
        {
            count++;
            FirstNode = FirstNode.GetNext();
        }
        return count;
    }

    public bool IsEmpty()
    {
        return FirstNode == null;
    }

    public bool Contains(T value)
    {
        while (FirstNode.HasNext())
        {
            if (FirstNode.GetValue().Equals(value))
                return true;
        }
        return true;
    }

    public QueueList<T> Reverse()
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