namespace AniHamelech;
class BinNode<T>
{
    T Value;
    BinNode<T>? Left;

    BinNode<T>? Right;

    public BinNode(T value)
    {
        value = Value;
    }

    public BinNode(T value, BinNode<T> Left, BinNode<T> Right)
    {
        value = Value;
        this.Left = Left;
        this.Right = Right;
    }
    public void SetValue(T info)
    {
        Value = info;
    }

    public T GetValue()
    {
        return Value;
    }
    public void SetRight(T info)
    {
        Right.SetValue(info);
    }
    public void SetLeft(T info)
    {
        Left.SetValue(info);
    }
    public BinNode<T> GetRight()
    {
        return Right;
    }

    public BinNode<T> GetLeft()
    {
        return Left;
    }
    public void SetRight(BinNode<T> info)
    {
        Right = info;
    }
    public void SetLeft(BinNode<T> info)
    {
        Left = info;
    }
}