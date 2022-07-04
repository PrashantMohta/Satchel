namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SimpleLogger allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SimpleLoggerR : InstanceClassWrapper<SimpleLogger>
{
    public SimpleLoggerR(SimpleLogger _orig) : base(_orig)
    {
    }

    public string ClassName
    {
        get => GetField<string>();
        set => SetField(value);
    }
}