namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of RemapTK2DSpriteAnimator allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RemapTK2DSpriteAnimatorR:InstanceClassWrapper<RemapTK2DSpriteAnimator>
{
public RemapTK2DSpriteAnimatorR(RemapTK2DSpriteAnimator _orig) : base(_orig) {}
public tk2dSpriteAnimator sourceAnimator
{
get => orig.sourceAnimator;
set => orig.sourceAnimator = value;
}

public tk2dSpriteAnimator targetAnimator
{
get => orig.targetAnimator;
set => orig.targetAnimator = value;
}

public bool syncFrames
{
get => orig.syncFrames;
set => orig.syncFrames = value;
}

public System.Collections.Generic.List<RemapTK2DSpriteAnimator.AnimationRemap> animationsList
{
get => orig.animationsList;
set => orig.animationsList = value;
}

public System.Collections.Generic.Dictionary<System.String,System.String> animations
{
get => GetField<System.Collections.Generic.Dictionary<System.String,System.String>>();
set => SetField(value);
}

public bool shouldAnimate
{
get => GetField<bool>();
set => SetField(value);
}

public string lastSourceClip
{
get => GetField<string>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
