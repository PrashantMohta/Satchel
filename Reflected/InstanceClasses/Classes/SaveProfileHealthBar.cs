namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SaveProfileHealthBar allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SaveProfileHealthBarR:InstanceClassWrapper<SaveProfileHealthBar>
{
public SaveProfileHealthBarR(SaveProfileHealthBar _orig) : base(_orig) {}
public int buttonsToShow
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.UI.Image[] healthUnits
{
get => GetField<UnityEngine.UI.Image[]>();
set => SetField(value);
}

public UnityEngine.Sprite normalHealth
{
get => orig.normalHealth;
set => orig.normalHealth = value;
}

public UnityEngine.Sprite steelHealth
{
get => orig.steelHealth;
set => orig.steelHealth = value;
}



public void Awake () =>
orig.Awake();

public void showHealth (int numberToShow, bool steelsoulMode) =>
orig.showHealth(numberToShow, steelsoulMode);

}
}
