namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of DeactivateGameObjectPerBuildType allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DeactivateGameObjectPerBuildTypeR:InstanceClassWrapper<DeactivateGameObjectPerBuildType>
{
public DeactivateGameObjectPerBuildTypeR(DeactivateGameObjectPerBuildType _orig) : base(_orig) {}
public GlobalEnums.BuildTypes[] buildTypes
{
get => GetField<GlobalEnums.BuildTypes[]>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

}
}
