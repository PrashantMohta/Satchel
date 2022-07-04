namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ShopItemStats allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ShopItemStatsR:InstanceClassWrapper<ShopItemStats>
{
public ShopItemStatsR(ShopItemStats _orig) : base(_orig) {}
public string playerDataBoolName
{
get => orig.playerDataBoolName;
set => orig.playerDataBoolName = value;
}

public string nameConvo
{
get => orig.nameConvo;
set => orig.nameConvo = value;
}

public string descConvo
{
get => orig.descConvo;
set => orig.descConvo = value;
}

public string priceConvo
{
get => orig.priceConvo;
set => orig.priceConvo = value;
}

public string requiredPlayerDataBool
{
get => orig.requiredPlayerDataBool;
set => orig.requiredPlayerDataBool = value;
}

public string removalPlayerDataBool
{
get => orig.removalPlayerDataBool;
set => orig.removalPlayerDataBool = value;
}

public int specialType
{
get => orig.specialType;
set => orig.specialType = value;
}

public int relicNumber
{
get => orig.relicNumber;
set => orig.relicNumber = value;
}

public int charmsRequired
{
get => orig.charmsRequired;
set => orig.charmsRequired = value;
}

public UnityEngine.Color activeColour
{
get => orig.activeColour;
set => orig.activeColour = value;
}

public UnityEngine.Color inactiveColour
{
get => orig.inactiveColour;
set => orig.inactiveColour = value;
}

public bool dungDiscount
{
get => orig.dungDiscount;
set => orig.dungDiscount = value;
}

public bool relic
{
get => orig.relic;
set => orig.relic = value;
}

public string relicPDInt
{
get => orig.relicPDInt;
set => orig.relicPDInt = value;
}

public string notchCostBool
{
get => orig.notchCostBool;
set => orig.notchCostBool = value;
}

public int cost
{
get => orig.cost;
set => orig.cost = value;
}

public int runningCost
{
get => GetField<int>();
set => SetField(value);
}

public int itemNumber
{
get => orig.itemNumber;
set => orig.itemNumber = value;
}

public bool canBuy
{
get => orig.canBuy;
set => orig.canBuy = value;
}

public PlayerData playerData
{
get => GetField<PlayerData>();
set => SetField(value);
}

public int notchCost
{
get => GetField<int>();
set => SetField(value);
}

public float topY
{
get => GetField<float>();
set => SetField(value);
}

public float botY
{
get => GetField<float>();
set => SetField(value);
}

public bool hidden
{
get => GetField<bool>();
set => SetField(value);
}

public PlayerData pd
{
get => GetField<PlayerData>();
set => SetField(value);
}

public UnityEngine.GameObject geoSprite
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject itemSprite
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject itemCost
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void Update () =>
CallMethod();

public int GetCost () =>
orig.GetCost();

public int GetNotchCost () =>
orig.GetNotchCost();

public int GetCharmsRequired () =>
orig.GetCharmsRequired();

public int GetRelicNumber () =>
orig.GetRelicNumber();

public string GetNameConvo () =>
orig.GetNameConvo();

public string GetDescConvo () =>
orig.GetDescConvo();

public string GetPlayerDataBoolName () =>
orig.GetPlayerDataBoolName();

public string GetRequiredPlayerDataBoolName () =>
orig.GetRequiredPlayerDataBoolName();

public string GetRemovalPlayerDataBoolName () =>
orig.GetRemovalPlayerDataBoolName();

public int GetItemNumber () =>
orig.GetItemNumber();

public int GetSpecialType () =>
orig.GetSpecialType();

public bool CanBuy () =>
orig.CanBuy();

public void SetCanBuy (bool can) =>
orig.SetCanBuy(can);

public void SetDescConvo (string convo) =>
orig.SetDescConvo(convo);

public void SetCost (int newCost) =>
orig.SetCost(newCost);

}
}
