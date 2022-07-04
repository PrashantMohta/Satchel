namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of KeepRotation allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class KeepRotationR:InstanceClassWrapper<KeepRotation>
{
public KeepRotationR(KeepRotation _orig) : base(_orig) {}
public float angle
{
get => orig.angle;
set => orig.angle = value;
}

public UnityEngine.Transform tf
{
get => GetField<UnityEngine.Transform>();
set => SetField(value);
}

public UnityEngine.Vector3 rotation
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
