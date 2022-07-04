using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of FastAction allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FastActionR : InstanceClassWrapper<FastAction>
{
    public FastActionR(FastAction _orig) : base(_orig)
    {
    }

    public LinkedList<Action> delegates
    {
        get => GetField<LinkedList<Action>>();
        set => SetField(value);
    }

    public Dictionary<Action, LinkedListNode<Action>> lookup
    {
        get => GetField<Dictionary<Action, LinkedListNode<Action>>>();
        set => SetField(value);
    }

    public void Add(Action rhs)
    {
        orig.Add(rhs);
    }

    public void Remove(Action rhs)
    {
        orig.Remove(rhs);
    }

    public void Call()
    {
        orig.Call();
    }
}