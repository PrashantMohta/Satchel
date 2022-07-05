using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of HexadecimalAttribute allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HexadecimalAttributeR : InstanceClassWrapper<HexadecimalAttribute>
{
    public HexadecimalAttributeR(HexadecimalAttribute _orig) : base(_orig)
    {
    }

    public int order
    {
        get => orig.order;
        set => orig.order = value;
    }

    public object TypeId => orig.TypeId;
}