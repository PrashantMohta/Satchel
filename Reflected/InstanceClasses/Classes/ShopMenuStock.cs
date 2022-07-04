namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ShopMenuStock allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ShopMenuStockR:InstanceClassWrapper<ShopMenuStock>
{
public ShopMenuStockR(ShopMenuStock _orig) : base(_orig) {}
public UnityEngine.GameObject masterList
{
get => orig.masterList;
set => orig.masterList = value;
}

public UnityEngine.GameObject[] stock
{
get => orig.stock;
set => orig.stock = value;
}

public UnityEngine.GameObject[] stockInv
{
get => orig.stockInv;
set => orig.stockInv = value;
}

public UnityEngine.GameObject[] stockAlt
{
get => orig.stockAlt;
set => orig.stockAlt = value;
}

public string altPlayerDataBool
{
get => orig.altPlayerDataBool;
set => orig.altPlayerDataBool = value;
}

public string altPlayerDataBoolAlt
{
get => orig.altPlayerDataBoolAlt;
set => orig.altPlayerDataBoolAlt = value;
}

public System.Collections.Generic.Dictionary<UnityEngine.GameObject,UnityEngine.GameObject> spawnedStock
{
get => GetField<System.Collections.Generic.Dictionary<UnityEngine.GameObject,UnityEngine.GameObject>>();
set => SetField(value);
}

public float yDistance
{
get => orig.yDistance;
set => orig.yDistance = value;
}

public UnityEngine.Vector3 selfPos
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public int itemCount
{
get => orig.itemCount;
set => orig.itemCount = value;
}



public void Start () =>
CallMethod();

public void SpawnStock () =>
CallMethod();

public void UpdateStock () =>
orig.UpdateStock();

public void BuildFromMasterList () =>
CallMethod();

public bool StockLeft () =>
orig.StockLeft();

public void BuildItemList () =>
CallMethod();

public int GetItemCount () =>
orig.GetItemCount();

public int GetCost (int itemNum) =>
orig.GetCost(itemNum);

public int GetNotchCost (int itemNum) =>
orig.GetNotchCost(itemNum);

public string GetNameConvo (int itemNum) =>
orig.GetNameConvo(itemNum);

public string GetDescConvo (int itemNum) =>
orig.GetDescConvo(itemNum);

public string GetPlayerDataBoolName (int itemNum) =>
orig.GetPlayerDataBoolName(itemNum);

public int GetSpecialType (int itemNum) =>
orig.GetSpecialType(itemNum);

public int GetRelicNumber (int itemNum) =>
orig.GetRelicNumber(itemNum);

public int GetCharmsRequired (int itemNum) =>
orig.GetCharmsRequired(itemNum);

public float GetYDistance () =>
orig.GetYDistance();

public UnityEngine.Sprite GetItemSprite (int itemNum) =>
orig.GetItemSprite(itemNum);

public UnityEngine.Vector3 GetItemSpriteScale (int itemNum) =>
orig.GetItemSpriteScale(itemNum);

public bool CanBuy (int itemNum) =>
orig.CanBuy(itemNum);

public UnityEngine.GameObject GetItemGameObject (int itemNum) =>
orig.GetItemGameObject(itemNum);

}
}
