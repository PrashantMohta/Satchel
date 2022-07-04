using Language;
using Object = UnityEngine.Object;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of LocalizedAsset allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LocalizedAssetR : InstanceClassWrapper<LocalizedAsset>
{
    public LocalizedAssetR(LocalizedAsset _orig) : base(_orig)
    {
    }

    public Object localizeTarget
    {
        get => orig.localizeTarget;
        set => orig.localizeTarget = value;
    }


    public void Awake()
    {
        orig.Awake();
    }

    public void LocalizeAsset()
    {
        orig.LocalizeAsset();
    }

    public void LocalizeAsset(Object target)
    {
        LocalizedAsset.LocalizeAsset(target);
    }
}