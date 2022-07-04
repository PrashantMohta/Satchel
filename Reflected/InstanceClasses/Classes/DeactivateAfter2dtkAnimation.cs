namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DeactivateAfter2dtkAnimation allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DeactivateAfter2dtkAnimationR:InstanceClassWrapper<DeactivateAfter2dtkAnimation>
{
public DeactivateAfter2dtkAnimationR(DeactivateAfter2dtkAnimation _orig) : base(_orig) {}
public tk2dSpriteAnimator spriteAnimator
{
get => orig.spriteAnimator;
set => orig.spriteAnimator = value;
}

public float timer
{
get => GetField<float>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
