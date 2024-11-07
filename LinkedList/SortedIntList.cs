namespace AniHamelech;
class SortedIntList
{
    Node<int>? head;

    public SortedIntList()
    {
        head = null;
    }
    public void Add(int value)
    {
        if (head == null)
        {
            head = new Node<int>(value);
        }
        Node<int> temp = head;
        while (temp != null)
        {
            if (temp.GetNext() == null)
            {
                temp.SetNext(new Node<int>(value));
                break;
            }
            else if (temp.GetValue() < value && temp.GetNext().GetValue() >= value)
            {
                Node<int> node = temp.GetNext();
                temp.SetNext(new Node<int>(value));
                temp = temp.GetNext();
                temp.SetNext(node);
                break;
            }
        }

    }
    public bool Contains(int value)
    {
        Node<int> temp = head;
        while (temp != null)
        {
            if (temp.GetValue() == value) { return true; }
            temp = temp.GetNext();
        }
        return false;
    }
}