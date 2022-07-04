namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SetPosIfPlayerdataBool allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetPosIfPlayerdataBoolR:InstanceClassWrapper<SetPosIfPlayerdataBool>
{
public SetPosIfPlayerdataBoolR(SetPosIfPlayerdataBool _orig) : base(_orig) {}
public string playerDataBool
{
get => orig.playerDataBool;
set => orig.playerDataBool = value;
}

public bool setX
{
get => orig.setX;
set => orig.setX = value;
}

public float XPos
{
get => orig.XPos;
set => orig.XPos = value;
}

public bool setY
{
get => orig.setY;
set => orig.setY = value;
}

public float YPos
{
get => orig.YPos;
set => orig.YPos = value;
}

public bool onceOnly
{
get => orig.onceOnly;
set => orig.onceOnly = value;
}

public bool hasSet
{
get => GetField<bool>();
set => SetField(value);
}

public bool hasChecked
{
get => GetField<bool>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void DoCheck () =>
CallMethod();

}
}
