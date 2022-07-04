namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GeneratePortraitFrame allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GeneratePortraitFrameR:InstanceClassWrapper<GeneratePortraitFrame>
{
public GeneratePortraitFrameR(GeneratePortraitFrame _orig) : base(_orig) {}
public UnityEngine.GameObject frameObject
{
get => orig.frameObject;
set => orig.frameObject = value;
}



public void Start () =>
CallMethod();

}
}
