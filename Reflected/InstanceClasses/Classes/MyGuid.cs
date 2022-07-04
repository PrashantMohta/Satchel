namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MyGuid allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MyGuidR:InstanceClassWrapper<MyGuid>
{
public MyGuidR(MyGuid _orig) : base(_orig) {}
public string guidAsString
{
get => GetField<string>();
set => SetField(value);
}

public System.Guid _guid
{
get => GetField<System.Guid>();
set => SetField(value);
}

public System.Guid guid
{
get => orig.guid;
}



public void Generate () =>
orig.Generate();

public string GetGuid () =>
orig.GetGuid();

}
}
