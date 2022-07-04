namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ShineAnimSequence allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ShineAnimSequenceR:InstanceClassWrapper<ShineAnimSequence>
{
public ShineAnimSequenceR(ShineAnimSequence _orig) : base(_orig) {}
public ShineAnimSequence.ShineObject[] shineObjects
{
get => orig.shineObjects;
set => orig.shineObjects = value;
}

public float shineDelay
{
get => orig.shineDelay;
set => orig.shineDelay = value;
}

public float sequencePauseTime
{
get => orig.sequencePauseTime;
set => orig.sequencePauseTime = value;
}



public void Start () =>
CallMethod();

public System.Collections.IEnumerator ShineSequence () =>
CallMethod<System.Collections.IEnumerator>();

}
}
