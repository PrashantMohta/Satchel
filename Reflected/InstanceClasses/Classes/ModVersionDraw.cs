namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ModVersionDraw allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ModVersionDrawR:InstanceClassWrapper<Modding.ModVersionDraw>
{
public ModVersionDrawR(Modding.ModVersionDraw _orig) : base(_orig) {}
public UnityEngine.GUIStyle style
{
get => GetFieldStatic<UnityEngine.GUIStyle>();
set => SetField(value);
}

public string drawString
{
get => orig.drawString;
set => orig.drawString = value;
}



public void OnGUI () =>
orig.OnGUI();

}
}
