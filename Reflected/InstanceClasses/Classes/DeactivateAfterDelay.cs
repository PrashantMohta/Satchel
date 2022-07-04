namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DeactivateAfterDelay allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DeactivateAfterDelayR:InstanceClassWrapper<DeactivateAfterDelay>
{
public DeactivateAfterDelayR(DeactivateAfterDelay _orig) : base(_orig) {}
public float time
{
get => orig.time;
set => orig.time = value;
}

public bool stayInPlace
{
get => orig.stayInPlace;
set => orig.stayInPlace = value;
}

public float timer
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Vector3 worldPos
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector3 startPos
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
