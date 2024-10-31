namespace AniHamelech;
class Program
{
    public static void Main()
    {
        MyStack<int> Stack = new();

        Stack.Push(20);
        Stack.Push(40);
        Stack.Push(60);

        Stack.Pop();
        Stack.Pop();
        Console.WriteLine(Stack.Contains(0));
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