namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SaveProfileMPSlots allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SaveProfileMPSlotsR:InstanceClassWrapper<SaveProfileMPSlots>
{
public SaveProfileMPSlotsR(SaveProfileMPSlots _orig) : base(_orig) {}
public int slotsToShow
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.UI.Image[] mpUnits
{
get => GetField<UnityEngine.UI.Image[]>();
set => SetField(value);
}

public UnityEngine.Sprite normalSoulOrb
{
get => orig.normalSoulOrb;
set => orig.normalSoulOrb = value;
}

public UnityEngine.Sprite steelSoulOrb
{
get => orig.steelSoulOrb;
set => orig.steelSoulOrb = value;
}



public void Awake () =>
CallMethod();

public void showMPSlots (int slotsToShow, bool steelsoulMode) =>
orig.showMPSlots(slotsToShow, steelsoulMode);

}
}
