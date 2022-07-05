namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CameraShake allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CameraShakeR : InstanceClassWrapper<CameraShake>
{
    public CameraShakeR(CameraShake _orig) : base(_orig)
    {
    }

    public List<CameraShake> cameraShakes
    {
        get => GetFieldStatic<List<CameraShake>>();
        set => SetField(value);
    }

    public PlayMakerFSM cameraShakeFSM
    {
        get => GetField<PlayMakerFSM>();
        set => SetField(value);
    }


    public void Init()
    {
        CallMethod();
    }

    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void ShakeSingle(CameraShakeCues cue)
    {
        orig.ShakeSingle(cue);
    }

    public void Shake(CameraShakeCues cue)
    {
        CameraShake.Shake(cue);
    }
}