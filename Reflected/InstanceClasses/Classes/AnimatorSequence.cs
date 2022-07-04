namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AnimatorSequence allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AnimatorSequenceR:InstanceClassWrapper<AnimatorSequence>
{
public AnimatorSequenceR(AnimatorSequence _orig) : base(_orig) {}
public UnityEngine.Animator animator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}

public string animatorStateName
{
get => GetField<string>();
set => SetField(value);
}

public float normalizedFinishTime
{
get => GetField<float>();
set => SetField(value);
}

public float fadeByController
{
get => GetField<float>();
set => SetField(value);
}

public bool isSkipped
{
get => GetField<bool>();
set => SetField(value);
}

public bool IsPlaying
{
get => orig.IsPlaying;
}

public bool IsSkipped
{
get => orig.IsSkipped;
}

public float FadeByController
{
get => orig.FadeByController;
set => orig.FadeByController = value;
}



public void Awake () =>
CallMethod();

public void Update () =>
CallMethod();

public void Begin () =>
orig.Begin();

public void Skip () =>
orig.Skip();

}
}
