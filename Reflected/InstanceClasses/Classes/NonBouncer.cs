namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of NonBouncer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class NonBouncerR:InstanceClassWrapper<NonBouncer>
{
public NonBouncerR(NonBouncer _orig) : base(_orig) {}
public bool active
{
get => orig.active;
set => orig.active = value;
}



public void SetActive (bool set_active) =>
orig.SetActive(set_active);

}
}
