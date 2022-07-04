namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CharmIconList allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CharmIconListR:InstanceClassWrapper<CharmIconList>
{
public CharmIconListR(CharmIconList _orig) : base(_orig) {}
public CharmIconList Instance
{
get => CharmIconList.Instance;
set => CharmIconList.Instance = value;
}

public UnityEngine.Sprite[] spriteList
{
get => orig.spriteList;
set => orig.spriteList = value;
}

public UnityEngine.Sprite unbreakableHeart
{
get => orig.unbreakableHeart;
set => orig.unbreakableHeart = value;
}

public UnityEngine.Sprite unbreakableGreed
{
get => orig.unbreakableGreed;
set => orig.unbreakableGreed = value;
}

public UnityEngine.Sprite unbreakableStrength
{
get => orig.unbreakableStrength;
set => orig.unbreakableStrength = value;
}

public UnityEngine.Sprite grimmchildLevel1
{
get => orig.grimmchildLevel1;
set => orig.grimmchildLevel1 = value;
}

public UnityEngine.Sprite grimmchildLevel2
{
get => orig.grimmchildLevel2;
set => orig.grimmchildLevel2 = value;
}

public UnityEngine.Sprite grimmchildLevel3
{
get => orig.grimmchildLevel3;
set => orig.grimmchildLevel3 = value;
}

public UnityEngine.Sprite grimmchildLevel4
{
get => orig.grimmchildLevel4;
set => orig.grimmchildLevel4 = value;
}

public UnityEngine.Sprite nymmCharm
{
get => orig.nymmCharm;
set => orig.nymmCharm = value;
}

public PlayerData playerData
{
get => GetField<PlayerData>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public UnityEngine.Sprite GetSprite (int id) =>
orig.GetSprite(id);

}
}
