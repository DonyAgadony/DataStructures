using System.Runtime.Intrinsics.X86;

namespace AniHamelech;
public class MyStack<T>
{
    public T[] items;
    public MyStack()
    {
        this.items = [];
    }
    public T Pop()
    {
        T temp = items[0];
        items = items.Skip(1).ToArray();
        return temp;
    }
    public void Push(T value)
    {
        items = [value, .. items];
    }
    public T Peek()
    {
        return items[0];
    }
    public bool IsEmpty()
    {
        return items[0] == null;
    }

    public void SwapLast2()
    {
        T v1 = items[0];
        T v2 = items[1];
        items = items.Skip(2).ToArray();
        items = [v2, v1, .. items];
    }

    public bool Contains(T value)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i]!.Equals(value)) { return true; }
        }
        return false;
    }
    public bool IsFull()
    {
        return items.Length == int.MaxValue;
    }


}