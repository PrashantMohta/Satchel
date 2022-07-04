namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUIToggleControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUIToggleControlR:InstanceClassWrapper<tk2dUIToggleControl>
{
public tk2dUIToggleControlR(tk2dUIToggleControl _orig) : base(_orig) {}
public tk2dTextMesh descriptionTextMesh
{
get => orig.descriptionTextMesh;
set => orig.descriptionTextMesh = value;
}

public UnityEngine.GameObject offStateGO
{
get => orig.offStateGO;
set => orig.offStateGO = value;
}

public UnityEngine.GameObject onStateGO
{
get => orig.onStateGO;
set => orig.onStateGO = value;
}

public bool activateOnPress
{
get => orig.activateOnPress;
set => orig.activateOnPress = value;
}

public string SendMessageOnToggleMethodName
{
get => orig.SendMessageOnToggleMethodName;
set => orig.SendMessageOnToggleMethodName = value;
}

public tk2dUIItem uiItem
{
get => orig.uiItem;
set => orig.uiItem = value;
}

public bool IsOn
{
get => orig.IsOn;
set => orig.IsOn = value;
}

public bool IsInToggleGroup
{
get => orig.IsInToggleGroup;
set => orig.IsInToggleGroup = value;
}

public UnityEngine.GameObject SendMessageTarget
{
get => orig.SendMessageTarget;
set => orig.SendMessageTarget = value;
}



}
}
