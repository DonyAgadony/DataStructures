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
class Program
{
    public static void Main()
    {
        Show(Build(5, 20, 5));
    }
    public static Node<int> Build()
    {
        Console.WriteLine("Enter the first element of the list:");
        Node<int> head = new(int.Parse(Console.ReadLine()!));
        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine($"Enter the {i}th element of the list:");
            ListOperations.AddToTail(head, int.Parse(Console.ReadLine()!));
        }
        return head;
    }
    public static Node<int> Build(int from, int to, int len)
    {
        Random rand = new();
        Node<int> head = new(rand.Next(from, to));
        len--;
        do
        {
            ListOperations.AddToTail(head, rand.Next(from, to));
            len--;
        }
        while (len > 0);

        return head;
    }

    public static Node<int> Build(int[] ints)
    {
        Node<int> head = new(ints[0]);
        for (int i = 1; i < ints.Length; i++)
        {
            ListOperations.AddToTail(head, ints[i]);
        }
        return head;
    }

    public static void Show(Node<int> head)
    {
        string result = "[";

        while (head != null)
        {
            result += head.GetValue().ToString() + ", ";
            head = head.GetNext()!;
        }
        result = result.TrimEnd(' ', ',');
        result += "]";
        Console.WriteLine(result);
    }

    public static bool Exist(Node<int> head, int value)
    {
        return ListOperations.Contains(head, value);
    }

    public static int? GetPosition(Node<int> head, int value)
    {
        int index = 0;
        if (ListOperations.Contains(head, value))
        {
            while (head != null)
            {
                if (head.GetValue() == value)
                {
                    return index;
                }
                head = head.GetNext()!;
                index++;
            }
        }
        else { return null; }
        return index;
    }

    public static void Update(Node<int> head, int Value, int SecondValue)
    {
        while (head != null)
        {
            if (head.GetValue() == Value)
            {
                head.SetValue(SecondValue);
                break;
            }
            else
            {
                head = head.GetNext()!;
            }
        }
    }

    public static Node<int> GetMax(Node<int> head)
    {
        Node<int> Max = new(int.MinValue);
        while (head != null)
        {
            if (head.GetValue() > Max.GetValue())
            {
                Max.SetValue(head.GetValue());
            }
            head = head.GetNext()!;
        }
        return Max;
    }
}