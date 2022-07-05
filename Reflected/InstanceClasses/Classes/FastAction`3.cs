using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FastAction`3 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FastActionR<A, B, C> : InstanceClassWrapper<FastAction<A, B, C>>
{
    public FastActionR(FastAction<A, B, C> _orig) : base(_orig)
    {
    }

    public LinkedList<Action<A, B, C>> delegates
    {
        get => GetField<LinkedList<Action<A, B, C>>>();
        set => SetField(value);
    }

    public Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup
    {
        get => GetField<Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>>>();
        set => SetField(value);
    }

    public void Add(Action<A, B, C> rhs)
    {
        orig.Add(rhs);
    }

    public void Remove(Action<A, B, C> rhs)
    {
        orig.Remove(rhs);
    }

    public void Call(A a, B b, C c)
    {
        orig.Call(a, b, c);
    }
}