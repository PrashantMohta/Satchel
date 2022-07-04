namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ControllerProfileButtons allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ControllerProfileButtonsR:InstanceClassWrapper<UnityEngine.UI.ControllerProfileButtons>
{
public ControllerProfileButtonsR(UnityEngine.UI.ControllerProfileButtons _orig) : base(_orig) {}
public UnityEngine.UI.Image profileHighlight1
{
get => orig.profileHighlight1;
set => orig.profileHighlight1 = value;
}

public UnityEngine.UI.Image profileHighlight2
{
get => orig.profileHighlight2;
set => orig.profileHighlight2 = value;
}

public UnityEngine.UI.Image profileHighlight3
{
get => orig.profileHighlight3;
set => orig.profileHighlight3 = value;
}

public UnityEngine.UI.Image profileHighlight4
{
get => orig.profileHighlight4;
set => orig.profileHighlight4 = value;
}



public void SelectItem (int num) =>
orig.SelectItem(num);

}
}
