using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of PreserveAttribute allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class PreserveAttributeR : InstanceClassWrapper<PreserveAttribute>
{
    public PreserveAttributeR(PreserveAttribute _orig) : base(_orig)
    {
    }

    public object TypeId => orig.TypeId;
}