namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LocalizedAsset allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LocalizedAssetR:InstanceClassWrapper<Language.LocalizedAsset>
{
public LocalizedAssetR(Language.LocalizedAsset _orig) : base(_orig) {}
public UnityEngine.Object localizeTarget
{
get => orig.localizeTarget;
set => orig.localizeTarget = value;
}



public void Awake () =>
orig.Awake();

public void LocalizeAsset () =>
orig.LocalizeAsset();

public void LocalizeAsset (UnityEngine.Object target) =>
Language.LocalizedAsset.LocalizeAsset(target);

}
}
