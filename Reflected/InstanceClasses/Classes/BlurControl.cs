namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BlurControl allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BlurControlR:InstanceClassWrapper<BlurControl>
{
public BlurControlR(BlurControl _orig) : base(_orig) {}
public float value
{
get => GetField<float>();
set => SetField(value);
}



}
}
