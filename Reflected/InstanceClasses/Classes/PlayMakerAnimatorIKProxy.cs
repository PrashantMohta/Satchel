namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerAnimatorIKProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerAnimatorIKProxyR : InstanceClassWrapper<PlayMakerAnimatorIKProxy>
{
    public PlayMakerAnimatorIKProxyR(PlayMakerAnimatorIKProxy _orig) : base(_orig)
    {
    }

    public Action<int> OnAnimatorIKEvent
    {
        get => GetField<Action<int>>();
        set => SetField(value);
    }

    public Animator _animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }


    public void OnAnimatorIK(int layerIndex)
    {
        CallMethod(new object[] { layerIndex });
    }
}