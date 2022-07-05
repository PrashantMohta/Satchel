namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of InGameCutsceneInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InGameCutsceneInfoR : InstanceClassWrapper<InGameCutsceneInfo>
{
    public InGameCutsceneInfoR(InGameCutsceneInfo _orig) : base(_orig)
    {
    }

    public InGameCutsceneInfo instance
    {
        get => GetFieldStatic<InGameCutsceneInfo>();
        set => SetField(value);
    }

    public Vector2 cameraPosition
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public bool IsInCutscene => InGameCutsceneInfo.IsInCutscene;

    public Vector2 CameraPosition => InGameCutsceneInfo.CameraPosition;


    public void Awake()
    {
        CallMethod();
    }

    public void OnDestroy()
    {
        CallMethod();
    }
}