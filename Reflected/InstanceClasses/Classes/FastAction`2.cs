using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FastAction`2 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FastActionR<A, B> : InstanceClassWrapper<FastAction<A, B>>
{
    public FastActionR(FastAction<A, B> _orig) : base(_orig)
    {
    }

    public LinkedList<Action<A, B>> delegates
    {
        get => GetField<LinkedList<Action<A, B>>>();
        set => SetField(value);
    }

    public Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup
    {
        get => GetField<Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>>>();
        set => SetField(value);
    }

    public void Add(Action<A, B> rhs)
    {
        orig.Add(rhs);
    }

    public void Remove(Action<A, B> rhs)
    {
        orig.Remove(rhs);
    }

    public void Call(A a, B b)
    {
        orig.Call(a, b);
    }
}