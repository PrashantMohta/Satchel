namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of HardLandEffect allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class HardLandEffectR:InstanceClassWrapper<HardLandEffect>
{
public HardLandEffectR(HardLandEffect _orig) : base(_orig) {}
public UnityEngine.GameObject dustObj
{
get => orig.dustObj;
set => orig.dustObj = value;
}

public UnityEngine.GameObject grassObj
{
get => orig.grassObj;
set => orig.grassObj = value;
}

public UnityEngine.GameObject boneObj
{
get => orig.boneObj;
set => orig.boneObj = value;
}

public UnityEngine.GameObject spaObj
{
get => orig.spaObj;
set => orig.spaObj = value;
}

public UnityEngine.GameObject metalObj
{
get => orig.metalObj;
set => orig.metalObj = value;
}

public UnityEngine.GameObject wetObj
{
get => orig.wetObj;
set => orig.wetObj = value;
}

public UnityEngine.GameObject particleRockPrefab
{
get => orig.particleRockPrefab;
set => orig.particleRockPrefab = value;
}

public UnityEngine.GameObject spatterWhitePrefab
{
get => orig.spatterWhitePrefab;
set => orig.spatterWhitePrefab = value;
}

public float recycleTime
{
get => GetField<float>();
set => SetField(value);
}



public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

}
}
