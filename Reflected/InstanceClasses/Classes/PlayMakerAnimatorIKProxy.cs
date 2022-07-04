namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of PlayMakerAnimatorIKProxy allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PlayMakerAnimatorIKProxyR:InstanceClassWrapper<PlayMakerAnimatorIKProxy>
{
public PlayMakerAnimatorIKProxyR(PlayMakerAnimatorIKProxy _orig) : base(_orig) {}
public System.Action<System.Int32> OnAnimatorIKEvent
{
get => GetField<System.Action<System.Int32>>();
set => SetField(value);
}

public UnityEngine.Animator _animator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}



public void OnAnimatorIK (int layerIndex) =>
CallMethod(new object[] {layerIndex});

}
}
