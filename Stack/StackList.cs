namespace AniHamelech;
class StackList<T>
{
    Node<T>? LastNode;
    public StackList()
    {

    }

    public void Push(T value) //O(1)
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
    public T Pop() //O(1)
    {
        T rst = LastNode.GetValue();
        LastNode = LastNode.GetNext();
        return rst;
    }

    public T Peek() //O(1)
    {
        return LastNode.GetValue();
    }

    public int GetSize() //O(n)
    {
        int count = 0;
        while (LastNode.HasNext())
        {
            count++;
            LastNode = LastNode.GetNext();
        }
        return count;
    }

    public bool IsEmpty() //O(1)
    {
        return LastNode == null;
    }

    public bool Contains(T value) //O(n)
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

    public StackList<T> Reverse() //O(n)
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