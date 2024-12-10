// למי שבאה לפתוח את המחשב כדי להתחיל לעבוד ורואה את הדבר הזה, הכל בסדר זה מסובך בהצלחה עם זה

//אוהב ומעריך דניאל פרץ

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
        int n = 10;
        int m = 8;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {

            }
        }

        BinNode<int> root = new BinNode<int>(10);
        root.SetLeft(new BinNode<int>(5));
        root.SetRight(new BinNode<int>(15));
        BinNode<int> temp = root.GetLeft();
        temp.SetLeft(new BinNode<int>(3));
        temp.SetRight(new BinNode<int>(7));
        Console.WriteLine(TreeSum(root));
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

    public static void PrintTree(BinNode<int> root)
    {
        if (root.GetLeft() != null)
        {
            PrintTree(root.GetLeft());
        }
        Console.WriteLine(root.GetValue());
        if (root.GetRight() != null)
        {
            PrintTree(root.GetRight());
        }
    }
    public static int GetSize(BinNode<int> root)
    {
        int count = 1;
        if (root.GetLeft() != null)
        {
            count += GetSize(root.GetLeft());
        }
        if (root.GetRight() != null)
        {
            count += GetSize(root.GetRight());
        }
        return count;
    }

    public static int GetMaxValue(BinNode<int> root)
    {
        int max = root.GetValue();
        if (root.GetLeft() != null)
        {
            int temp = GetMaxValue(root.GetLeft());
            if (temp > max)
            {
                max = temp;
            }
        }
        if (root.GetRight() != null)
        {
            int temp = GetMaxValue(root.GetRight());
            if (temp > max)
            {
                max = temp;
            }
        }
        return max;
    }

    public static int TreeSum(BinNode<int> root)
    {
        int sum = 0;
        if (root.GetLeft() != null)
        {
            sum += TreeSum(root.GetLeft());
        }
        if (root.GetRight() != null)
        {
            sum += TreeSum(root.GetRight());
        }
        return sum;
    }
}