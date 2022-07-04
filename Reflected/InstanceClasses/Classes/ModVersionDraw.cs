namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ModVersionDraw allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ModVersionDrawR : InstanceClassWrapper<ModVersionDraw>
{
    public ModVersionDrawR(ModVersionDraw _orig) : base(_orig)
    {
    }

    public GUIStyle style
    {
        get => GetFieldStatic<GUIStyle>();
        set => SetField(value);
    }

    public string drawString
    {
        get => orig.drawString;
        set => orig.drawString = value;
    }


    public void OnGUI()
    {
        orig.OnGUI();
    }
}