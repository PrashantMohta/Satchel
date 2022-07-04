namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CreditsHelper allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CreditsHelperR:InstanceClassWrapper<CreditsHelper>
{
public CreditsHelperR(CreditsHelper _orig) : base(_orig) {}
public UnityEngine.Animator creditsAnimator
{
get => orig.creditsAnimator;
set => orig.creditsAnimator = value;
}

public CutsceneHelper cutSceneHelper
{
get => orig.cutSceneHelper;
set => orig.cutSceneHelper = value;
}



public void Start () =>
CallMethod();

public void BeginCredits () =>
CallMethod();

public void ShouldStopHere () =>
orig.ShouldStopHere();

}
}
