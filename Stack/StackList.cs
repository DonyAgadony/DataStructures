namespace AniHamelech;
class StackList<T>
{
    Node<T>? LastNode;
    public StackList()
    {

    }

    public void Push(T value)
    {
        if (LastNode == null)
        {
            LastNode = new Node<T>(value);
        }
        else
        {
            Node<T> node = new(value);
            node.SetNext(LastNode);
            LastNode = node;
        }
    }
    public T Pop()
    {
        T rst = LastNode.GetValue();
        LastNode = LastNode.GetNext();
        return rst;
    }

    public T Peek()
    {
        return LastNode.GetValue();
    }

    public int GetSize()
    {
        int count = 0;
        while (LastNode.HasNext())
        {
            count++;
            LastNode = LastNode.GetNext();
        }
        return count;
    }

    public bool IsEmpty()
    {
        return LastNode == null;
    }

    public bool Contains(T value)
    {
        while (LastNode.HasNext())
        {
            if (LastNode.GetValue().Equals(value))
            {
                return true;
            }
        }
        return false;
    }

    public StackList<T> Reverse()
    {
        StackList<T> stackList = new();
        while (LastNode.HasNext())
        {
            stackList.Push(LastNode.GetValue());
            LastNode = LastNode.GetNext();
        }
        return stackList;
    }

}