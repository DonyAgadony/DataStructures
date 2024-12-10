using System.Runtime.Intrinsics.X86;

namespace AniHamelech;
public class MyStack<T>
{
    public T[] items;
    public MyStack()
    {
        this.items = [];
    }
    public T Pop() //O(1)
    {
        T temp = items[0];
        items = items.Skip(1).ToArray();
        return temp;
    }
    public void Push(T value) //O(1)
    {
        items = [value, .. items];
    }
    public T Peek() //O(1)
    {
        return items[0];
    }
    public bool IsEmpty() // O(1)
    {
        return items[0] == null;
    }

    public void SwapLast2() //O(1)
    {
        T v1 = items[0];
        T v2 = items[1];
        items = items.Skip(2).ToArray();
        items = [v2, v1, .. items];
    }

    public bool Contains(T value) //O(n)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i]!.Equals(value)) { return true; }
        }
        return false;
    }
    public bool IsFull() //O(1)
    {
        return items.Length == int.MaxValue;
    }


}