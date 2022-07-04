namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of FastAction allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FastActionR:InstanceClassWrapper<TMPro.FastAction>
{
public FastActionR(TMPro.FastAction _orig) : base(_orig) {}
public System.Collections.Generic.LinkedList<System.Action> delegates
{
get => GetField<System.Collections.Generic.LinkedList<System.Action>>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.Action,System.Collections.Generic.LinkedListNode<System.Action>> lookup
{
get => GetField<System.Collections.Generic.Dictionary<System.Action,System.Collections.Generic.LinkedListNode<System.Action>>>();
set => SetField(value);
}

public void Add (System.Action rhs) =>
orig.Add(rhs);

public void Remove (System.Action rhs) =>
orig.Remove(rhs);

public void Call () =>
orig.Call();

}
}
