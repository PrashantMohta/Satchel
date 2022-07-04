namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of RuinsLift allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RuinsLiftR:InstanceClassWrapper<RuinsLift>
{
public RuinsLiftR(RuinsLift _orig) : base(_orig) {}
public System.Single[] stopPositions
{
get => orig.stopPositions;
set => orig.stopPositions = value;
}

public UnityEngine.Transform chainsParent
{
get => orig.chainsParent;
set => orig.chainsParent = value;
}

public System.Collections.Generic.List<UnityEngine.Transform> chains
{
get => GetField<System.Collections.Generic.List<UnityEngine.Transform>>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public System.Collections.IEnumerator HideChains () =>
CallMethod<System.Collections.IEnumerator>();

public float GetPositionY (int position) =>
orig.GetPositionY(position);

public bool IsCurrentPositionTerminus (int position) =>
orig.IsCurrentPositionTerminus(position);

public int KeepInBounds (int position) =>
orig.KeepInBounds(position);

}
}
