namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of OpeningGameplayCredits allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OpeningGameplayCreditsR:InstanceClassWrapper<OpeningGameplayCredits>
{
public OpeningGameplayCreditsR(OpeningGameplayCredits _orig) : base(_orig) {}
public UnityEngine.Animator animator
{
get => orig.animator;
set => orig.animator = value;
}

public PlayerData pd
{
get => GetField<PlayerData>();
set => SetField(value);
}



public void Start () =>
CallMethod();

}
}
