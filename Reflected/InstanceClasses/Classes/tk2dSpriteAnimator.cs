namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteAnimator allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteAnimatorR:InstanceClassWrapper<tk2dSpriteAnimator>
{
public tk2dSpriteAnimatorR(tk2dSpriteAnimator _orig) : base(_orig) {}
public tk2dSpriteAnimation library
{
get => GetField<tk2dSpriteAnimation>();
set => SetField(value);
}

public int defaultClipId
{
get => GetField<int>();
set => SetField(value);
}

public bool playAutomatically
{
get => orig.playAutomatically;
set => orig.playAutomatically = value;
}

public tk2dSpriteAnimationClip currentClip
{
get => GetField<tk2dSpriteAnimationClip>();
set => SetField(value);
}

public float clipTime
{
get => GetField<float>();
set => SetField(value);
}

public float clipFps
{
get => GetField<float>();
set => SetField(value);
}

public int previousFrame
{
get => GetField<int>();
set => SetField(value);
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

public bool g_Paused
{
get => tk2dSpriteAnimator.g_Paused;
set => tk2dSpriteAnimator.g_Paused = value;
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

public float DefaultFps
{
get => tk2dSpriteAnimator.DefaultFps;
}

public int CurrentFrame
{
get => orig.CurrentFrame;
}



public void OnEnable () =>
CallMethod();

public void Start () =>
CallMethod();

public tk2dSpriteAnimator AddComponent (UnityEngine.GameObject go, tk2dSpriteAnimation anim, int clipId) =>
tk2dSpriteAnimator.AddComponent(go, anim, clipId);

public tk2dSpriteAnimationClip GetClipByNameVerbose (string name) =>
CallMethod<tk2dSpriteAnimationClip>(new object[] {name});

public void Play () =>
orig.Play();

public void Play (string name) =>
orig.Play(name);

public void Play (tk2dSpriteAnimationClip clip) =>
orig.Play(clip);

public void PlayFromFrame (int frame) =>
orig.PlayFromFrame(frame);

public void PlayFromFrame (string name, int frame) =>
orig.PlayFromFrame(name, frame);

public void PlayFromFrame (tk2dSpriteAnimationClip clip, int frame) =>
orig.PlayFromFrame(clip, frame);

public void PlayFrom (float clipStartTime) =>
orig.PlayFrom(clipStartTime);

public void PlayFrom (string name, float clipStartTime) =>
orig.PlayFrom(name, clipStartTime);

public void PlayFrom (tk2dSpriteAnimationClip clip, float clipStartTime) =>
orig.PlayFrom(clip, clipStartTime);

public void Play (tk2dSpriteAnimationClip clip, float clipStartTime, float overrideFps) =>
orig.Play(clip, clipStartTime, overrideFps);

public void Stop () =>
orig.Stop();

public void StopAndResetFrame () =>
orig.StopAndResetFrame();

public bool IsPlaying (string name) =>
orig.IsPlaying(name);

public bool IsPlaying (tk2dSpriteAnimationClip clip) =>
orig.IsPlaying(clip);

public tk2dSpriteAnimationClip GetClipById (int id) =>
orig.GetClipById(id);

public int GetClipIdByName (string name) =>
orig.GetClipIdByName(name);

public tk2dSpriteAnimationClip GetClipByName (string name) =>
orig.GetClipByName(name);

public void Pause () =>
orig.Pause();

public void Resume () =>
orig.Resume();

public void SetFrame (int currFrame) =>
orig.SetFrame(currFrame);

public void SetFrame (int currFrame, bool triggerEvent) =>
orig.SetFrame(currFrame, triggerEvent);

public void UpdateAnimation (float deltaTime) =>
orig.UpdateAnimation(deltaTime);

public void ClipNameError (string name) =>
CallMethod(new object[] {name});

public void ClipIdError (int id) =>
CallMethod(new object[] {id});

public void WarpClipToLocalTime (tk2dSpriteAnimationClip clip, float time) =>
CallMethod(new object[] {clip, time});

public void SetFrameInternal (int currFrame) =>
CallMethod(new object[] {currFrame});

public void ProcessEvents (int start, int last, int direction) =>
CallMethod(new object[] {start, last, direction});

public void OnAnimationCompleted () =>
CallMethod();

public void LateUpdate () =>
orig.LateUpdate();

public void SetSprite (tk2dSpriteCollectionData spriteCollection, int spriteId) =>
orig.SetSprite(spriteCollection, spriteId);

}
}
