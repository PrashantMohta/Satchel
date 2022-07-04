namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of FSMActivator allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FSMActivatorR:InstanceClassWrapper<FSMActivator>
{
public FSMActivatorR(FSMActivator _orig) : base(_orig) {}
public bool activateStaggered
{
get => orig.activateStaggered;
set => orig.activateStaggered = value;
}

public PlayMakerFSM[] fsms
{
get => GetField<PlayMakerFSM[]>();
set => SetField(value);
}

public tk2dSpriteAnimator spriteAnim
{
get => GetField<tk2dSpriteAnimator>();
set => SetField(value);
}

public bool activated
{
get => GetField<bool>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Activate () =>
orig.Activate();

public System.Collections.IEnumerator ActivateStaggered () =>
orig.ActivateStaggered();

public void Deactivate () =>
orig.Deactivate();

public System.Collections.IEnumerator DeactivateStaggered () =>
orig.DeactivateStaggered();

}
}
