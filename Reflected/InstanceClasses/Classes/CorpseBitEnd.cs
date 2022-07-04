namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CorpseBitEnd allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CorpseBitEndR:InstanceClassWrapper<CorpseBitEnd>
{
public CorpseBitEndR(CorpseBitEnd _orig) : base(_orig) {}
public float timer
{
get => orig.timer;
set => orig.timer = value;
}

public bool stopped
{
get => GetField<bool>();
set => SetField(value);
}



public void Update () =>
CallMethod();

}
}
