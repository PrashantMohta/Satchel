namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DeprecatedPrefab allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DeprecatedPrefabR:InstanceClassWrapper<DeprecatedPrefab>
{
public DeprecatedPrefabR(DeprecatedPrefab _orig) : base(_orig) {}


public void Start () =>
CallMethod();

}
}
