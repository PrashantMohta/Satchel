namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of FaceAngleSimple allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class FaceAngleSimpleR:InstanceClassWrapper<FaceAngleSimple>
{
public FaceAngleSimpleR(FaceAngleSimple _orig) : base(_orig) {}
public float angleOffset
{
get => orig.angleOffset;
set => orig.angleOffset = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public UnityEngine.Rigidbody2D rb2d
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public void DoAngle () =>
CallMethod();

}
}
