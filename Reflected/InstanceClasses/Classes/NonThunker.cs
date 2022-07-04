namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of NonThunker allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class NonThunkerR:InstanceClassWrapper<NonThunker>
{
public NonThunkerR(NonThunker _orig) : base(_orig) {}
public bool active
{
get => orig.active;
set => orig.active = value;
}



public void SetActive (bool active) =>
orig.SetActive(active);

}
}
