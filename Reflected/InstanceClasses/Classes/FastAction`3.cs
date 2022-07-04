namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of FastAction`3 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FastActionR<A,B,C>:InstanceClassWrapper<TMPro.FastAction<A,B,C>>
{
public FastActionR(TMPro.FastAction<A,B,C> _orig) : base(_orig) {}
public System.Collections.Generic.LinkedList<System.Action<A,B,C>> delegates
{
get => GetField<System.Collections.Generic.LinkedList<System.Action<A,B,C>>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Action<A,B,C>,System.Collections.Generic.LinkedListNode<System.Action<A,B,C>>> lookup
{
get => GetField<System.Collections.Generic.Dictionary<System.Action<A,B,C>,System.Collections.Generic.LinkedListNode<System.Action<A,B,C>>>>();
set => SetField(value);
}

public void Add (System.Action<A,B,C> rhs) =>
orig.Add(rhs);

public void Remove (System.Action<A,B,C> rhs) =>
orig.Remove(rhs);

public void Call (A a, B b, C c) =>
orig.Call(a, b, c);

}
}
