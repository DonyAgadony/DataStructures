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

    public T GetValue() //O(1)
    {
        return value;
    }

    public Node<T>? GetNext() //O(1)
    {
        return next;
    }

    public void SetValue(T value) //O(1)
    {
        this.value = value;
    }

    public void SetNext(Node<T> next) //O(1)
    {
        this.next = next;
    }

    public bool HasNext() //O(1)
    {
        return next != null;
    }

    public override string ToString() //O(1)
    {
        return value!.ToString()!;
    }
}
public static class ListOperations
{
    public static void AddToTail<T>(Node<T> head, T info) //O(n) (n=size)
    {
        while (head.HasNext())
        {
            head = head.GetNext()!;
        }
        head.SetNext(new Node<T>(info));
    }

    public static string ToString<T>(Node<T> head) //O(n) (n=size)
    {
        string result = "";
        while (head != null)
        {
            result += head.ToString() + ",";
            head = head.GetNext();
        }
        return result;

    }
    public static int GetLength<T>(Node<T> head) //O(n) (n=size)
    {
        int len = 0;

        while (head != null)
        {
            len++;
            head = head.GetNext()!;
        }
        return len;
    }

    public static bool Contains<T>(Node<T> head, T value) //O(n) (n=size)
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

    public static int GetMax<T>(Node<int> head) //O(n) (n=size)
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

    public static void Insert<T>(Node<T> head, T value, int index) //O(n) (n=size)
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