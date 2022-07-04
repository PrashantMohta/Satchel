namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of FastAction`1 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FastActionR<A>:InstanceClassWrapper<TMPro.FastAction<A>>
{
public FastActionR(TMPro.FastAction<A> _orig) : base(_orig) {}
public System.Collections.Generic.LinkedList<System.Action<A>> delegates
{
get => GetField<System.Collections.Generic.LinkedList<System.Action<A>>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Action<A>,System.Collections.Generic.LinkedListNode<System.Action<A>>> lookup
{
get => GetField<System.Collections.Generic.Dictionary<System.Action<A>,System.Collections.Generic.LinkedListNode<System.Action<A>>>>();
set => SetField(value);
}

public void Add (System.Action<A> rhs) =>
orig.Add(rhs);

public void Remove (System.Action<A> rhs) =>
orig.Remove(rhs);

public void Call (A a) =>
orig.Call(a);

}
}
