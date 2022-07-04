namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetZ allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetZR:InstanceClassWrapper<SetZ>
{
public SetZR(SetZ _orig) : base(_orig) {}
public float z
{
get => orig.z;
set => orig.z = value;
}

public bool dontRandomize
{
get => orig.dontRandomize;
set => orig.dontRandomize = value;
}

public bool randomizeFromStartingValue
{
get => orig.randomizeFromStartingValue;
set => orig.randomizeFromStartingValue = value;
}

public float delayBeforeRandomizing
{
get => orig.delayBeforeRandomizing;
set => orig.delayBeforeRandomizing = value;
}

public float setZ
{
get => GetField<float>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public System.Collections.IEnumerator SetPosition () =>
CallMethod<System.Collections.IEnumerator>();

}
}
