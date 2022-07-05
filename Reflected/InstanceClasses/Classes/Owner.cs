using HutongGames.PlayMaker.Ecosystem.Utils;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Owner allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class OwnerR : InstanceClassWrapper<Owner>
{
    public OwnerR(Owner _orig) : base(_orig)
    {
    }

    public OwnerSelectionOptions selection
    {
        get => orig.selection;
        set => orig.selection = value;
    }

    public GameObject gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }
}