namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerAnimatorMoveProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerAnimatorMoveProxyR : InstanceClassWrapper<PlayMakerAnimatorMoveProxy>
{
    public PlayMakerAnimatorMoveProxyR(PlayMakerAnimatorMoveProxy _orig) : base(_orig)
    {
    }

    public bool applyRootMotion
    {
        get => orig.applyRootMotion;
        set => orig.applyRootMotion = value;
    }

    public Action OnAnimatorMoveEvent
    {
        get => GetField<Action>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void OnAnimatorMove()
    {
        CallMethod();
    }
}