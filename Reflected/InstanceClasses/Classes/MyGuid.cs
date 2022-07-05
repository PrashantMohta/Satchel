namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of MyGuid allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MyGuidR : InstanceClassWrapper<MyGuid>
{
    public MyGuidR(MyGuid _orig) : base(_orig)
    {
    }

    public string guidAsString
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public Guid _guid
    {
        get => GetField<Guid>();
        set => SetField(value);
    }

    public Guid guid => orig.guid;


    public void Generate()
    {
        orig.Generate();
    }

    public string GetGuid()
    {
        return orig.GetGuid();
    }
}