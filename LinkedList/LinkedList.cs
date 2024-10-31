namespace AniHamelech;
public class Node<T>
{
    private T value;
    private Node<T>? next;
    public Node(T value)
    {
        this.value = value;
        this.next = null;
    }

    public Node(T value, Node<T> next)
    {
        this.value = value;
        this.next = next;
    }

    public T GetValue()
    {
        return value;
    }

    public Node<T>? GetNext()
    {
        return next;
    }

    public void SetValue(T value)
    {
        this.value = value;
    }

    public void SetNext(Node<T> next)
    {
        this.next = next;
    }

    public bool HasNext()
    {
        return next != null;
    }

    public override string ToString()
    {
        return value!.ToString()!;
    }
}
public static class ListOperations
{
    public static void AddToTail<T>(Node<T> head, T info)
    {
        while (head.HasNext())
        {
            head = head.GetNext()!;
        }
        head.SetNext(new Node<T>(info));
    }

    public static string ToString<T>(Node<T> head)
    {
        string result = "";
        while (head != null)
        {
            result += head.ToString() + ",";
            head = head.GetNext();
        }
        return result;

    }
    public static int GetLength<T>(Node<T> head)
    {
        int len = 0;

        while (head != null)
        {
            len++;
            head = head.GetNext()!;
        }
        return len;
    }

    public static bool Contains<T>(Node<T> head, T value)
    {
        while (head != null)
        {
            if (head.GetValue().Equals(value))
            {
                return true;
            }
            head = head.GetNext()!;
        }
        return false;
    }

    public static int GetMax<T>(Node<int> head)
    {
        int max = int.MinValue;
        while (head != null)
        {
            if (head.GetValue() > max)
            {
                max = head.GetValue();
            }
            head = head.GetNext()!;
        }
        return max;
    }

    public static void Insert<T>(Node<T> head, T value, int index)
    {
        for (; index > 1; index--)
        {
            head = head.GetNext()!;
        }
        Node<T> temp = new(value);
        temp.SetNext(head.GetNext());
        head.SetNext(temp);
    }
}