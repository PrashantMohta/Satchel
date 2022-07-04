using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FastAction`1 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FastActionR<A> : InstanceClassWrapper<FastAction<A>>
{
    public FastActionR(FastAction<A> _orig) : base(_orig)
    {
    }

    public LinkedList<Action<A>> delegates
    {
        get => GetField<LinkedList<Action<A>>>();
        set => SetField(value);
    }

    public Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup
    {
        get => GetField<Dictionary<Action<A>, LinkedListNode<Action<A>>>>();
        set => SetField(value);
    }

    public void Add(Action<A> rhs)
    {
        orig.Add(rhs);
    }

    public void Remove(Action<A> rhs)
    {
        orig.Remove(rhs);
    }

    public void Call(A a)
    {
        orig.Call(a);
    }
}