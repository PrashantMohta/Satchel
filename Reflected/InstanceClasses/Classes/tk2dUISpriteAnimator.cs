namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUISpriteAnimator allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUISpriteAnimatorR:InstanceClassWrapper<tk2dUISpriteAnimator>
{
public tk2dUISpriteAnimatorR(tk2dUISpriteAnimator _orig) : base(_orig) {}
public bool playAutomatically
{
get => orig.playAutomatically;
set => orig.playAutomatically = value;
}

public System.Action<tk2dSpriteAnimator,tk2dSpriteAnimationClip> AnimationCompleted
{
get => orig.AnimationCompleted;
set => orig.AnimationCompleted = value;
}

public System.Action<tk2dSpriteAnimator,tk2dSpriteAnimationClip,System.Int32> AnimationEventTriggered
{
get => orig.AnimationEventTriggered;
set => orig.AnimationEventTriggered = value;
}

public tk2dBaseSprite _sprite
{
get => GetField<tk2dBaseSprite>();
set => SetField(value);
}

public bool Paused
{
get => orig.Paused;
set => orig.Paused = value;
}

public tk2dSpriteAnimation Library
{
get => orig.Library;
set => orig.Library = value;
}

public int DefaultClipId
{
get => orig.DefaultClipId;
set => orig.DefaultClipId = value;
}

public tk2dSpriteAnimationClip DefaultClip
{
get => orig.DefaultClip;
}

public tk2dBaseSprite Sprite
{
get => orig.Sprite;
}

public bool Playing
{
get => orig.Playing;
}

public tk2dSpriteAnimationClip CurrentClip
{
get => orig.CurrentClip;
}

public float ClipTimeSeconds
{
get => orig.ClipTimeSeconds;
}

public float ClipFps
{
get => orig.ClipFps;
set => orig.ClipFps = value;
}

public int CurrentFrame
{
get => orig.CurrentFrame;
}



public void LateUpdate () =>
orig.LateUpdate();

}
}
