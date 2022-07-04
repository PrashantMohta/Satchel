namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DisplayItemAmount allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DisplayItemAmountR:InstanceClassWrapper<DisplayItemAmount>
{
public DisplayItemAmountR(DisplayItemAmount _orig) : base(_orig) {}
public string playerDataInt
{
get => orig.playerDataInt;
set => orig.playerDataInt = value;
}

public TMPro.TextMeshPro textObject
{
get => orig.textObject;
set => orig.textObject = value;
}

public PlayerData playerData
{
get => GetField<PlayerData>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

}
}
