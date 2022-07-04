namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteAnimation allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteAnimationR:InstanceClassWrapper<tk2dSpriteAnimation>
{
public tk2dSpriteAnimationR(tk2dSpriteAnimation _orig) : base(_orig) {}
public tk2dSpriteAnimationClip[] clips
{
get => orig.clips;
set => orig.clips = value;
}

public tk2dSpriteAnimationClip FirstValidClip
{
get => orig.FirstValidClip;
}



public tk2dSpriteAnimationClip GetClipByName (string name) =>
orig.GetClipByName(name);

public tk2dSpriteAnimationClip GetClipById (int id) =>
orig.GetClipById(id);

public int GetClipIdByName (string name) =>
orig.GetClipIdByName(name);

public int GetClipIdByName (tk2dSpriteAnimationClip clip) =>
orig.GetClipIdByName(clip);

}
}
