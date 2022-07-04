using HutongGames.PlayMaker.Ecosystem.Utils;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ShowOptions allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ShowOptionsR : InstanceClassWrapper<ShowOptions>
{
    public ShowOptionsR(ShowOptions _orig) : base(_orig)
    {
    }

    public object TypeId => orig.TypeId;
}