namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GodfinderGateIcon allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GodfinderGateIconR:InstanceClassWrapper<GodfinderGateIcon>
{
public GodfinderGateIconR(GodfinderGateIcon _orig) : base(_orig) {}
public UnityEngine.GameObject[] icons
{
get => orig.icons;
set => orig.icons = value;
}

public string completionPD
{
get => orig.completionPD;
set => orig.completionPD = value;
}

public BossSequence unlockedSequence
{
get => orig.unlockedSequence;
set => orig.unlockedSequence = value;
}

public string requiredPDBool
{
get => orig.requiredPDBool;
set => orig.requiredPDBool = value;
}



public void Reset () =>
CallMethod();

public void OnValidate () =>
CallMethod();

public void SetIcon (GodfinderGateIcon.IconType type) =>
CallMethod(new object[] {type});

public void Evaluate () =>
orig.Evaluate();

}
}
