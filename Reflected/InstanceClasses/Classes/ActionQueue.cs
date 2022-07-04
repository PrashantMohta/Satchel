namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ActionQueue allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ActionQueueR:InstanceClassWrapper<ActionQueue>
{
public ActionQueueR(ActionQueue _orig) : base(_orig) {}
public System.Collections.Generic.List<ActionQueue.ActionQueueCallback> pendingActions
{
get => GetField<System.Collections.Generic.List<ActionQueue.ActionQueueCallback>>();
set => SetField(value);
}

public bool isRunning
{
get => GetField<bool>();
set => SetField(value);
}

public void Next () =>
orig.Next();

public void Enqueue (ActionQueue.ActionQueueCallback action) =>
orig.Enqueue(action);

}
}
