namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of FastAction`2 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FastActionR<A,B>:InstanceClassWrapper<TMPro.FastAction<A,B>>
{
public FastActionR(TMPro.FastAction<A,B> _orig) : base(_orig) {}
public System.Collections.Generic.LinkedList<System.Action<A,B>> delegates
{
get => GetField<System.Collections.Generic.LinkedList<System.Action<A,B>>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Action<A,B>,System.Collections.Generic.LinkedListNode<System.Action<A,B>>> lookup
{
get => GetField<System.Collections.Generic.Dictionary<System.Action<A,B>,System.Collections.Generic.LinkedListNode<System.Action<A,B>>>>();
set => SetField(value);
}

public void Add (System.Action<A,B> rhs) =>
orig.Add(rhs);

public void Remove (System.Action<A,B> rhs) =>
orig.Remove(rhs);

public void Call (A a, B b) =>
orig.Call(a, b);

}
}
