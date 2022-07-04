namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dResourceTocEntry allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dResourceTocEntryR : InstanceClassWrapper<tk2dResourceTocEntry>
{
    public tk2dResourceTocEntryR(tk2dResourceTocEntry _orig) : base(_orig)
    {
    }

    public string resourceGUID
    {
        get => orig.resourceGUID;
        set => orig.resourceGUID = value;
    }

    public string assetName
    {
        get => orig.assetName;
        set => orig.assetName = value;
    }

    public string assetGUID
    {
        get => orig.assetGUID;
        set => orig.assetGUID = value;
    }
}