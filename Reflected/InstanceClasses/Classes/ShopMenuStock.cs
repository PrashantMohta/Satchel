namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ShopMenuStock allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ShopMenuStockR : InstanceClassWrapper<ShopMenuStock>
{
    public ShopMenuStockR(ShopMenuStock _orig) : base(_orig)
    {
    }

    public GameObject masterList
    {
        get => orig.masterList;
        set => orig.masterList = value;
    }

    public GameObject[] stock
    {
        get => orig.stock;
        set => orig.stock = value;
    }

    public GameObject[] stockInv
    {
        get => orig.stockInv;
        set => orig.stockInv = value;
    }

    public GameObject[] stockAlt
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

    public Dictionary<GameObject, GameObject> spawnedStock
    {
        get => GetField<Dictionary<GameObject, GameObject>>();
        set => SetField(value);
    }

    public float yDistance
    {
        get => orig.yDistance;
        set => orig.yDistance = value;
    }

    public Vector3 selfPos
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public int itemCount
    {
        get => orig.itemCount;
        set => orig.itemCount = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void SpawnStock()
    {
        CallMethod();
    }

    public void UpdateStock()
    {
        orig.UpdateStock();
    }

    public void BuildFromMasterList()
    {
        CallMethod();
    }

    public bool StockLeft()
    {
        return orig.StockLeft();
    }

    public void BuildItemList()
    {
        CallMethod();
    }

    public int GetItemCount()
    {
        return orig.GetItemCount();
    }

    public int GetCost(int itemNum)
    {
        return orig.GetCost(itemNum);
    }

    public int GetNotchCost(int itemNum)
    {
        return orig.GetNotchCost(itemNum);
    }

    public string GetNameConvo(int itemNum)
    {
        return orig.GetNameConvo(itemNum);
    }

    public string GetDescConvo(int itemNum)
    {
        return orig.GetDescConvo(itemNum);
    }

    public string GetPlayerDataBoolName(int itemNum)
    {
        return orig.GetPlayerDataBoolName(itemNum);
    }

    public int GetSpecialType(int itemNum)
    {
        return orig.GetSpecialType(itemNum);
    }

    public int GetRelicNumber(int itemNum)
    {
        return orig.GetRelicNumber(itemNum);
    }

    public int GetCharmsRequired(int itemNum)
    {
        return orig.GetCharmsRequired(itemNum);
    }

    public float GetYDistance()
    {
        return orig.GetYDistance();
    }

    public Sprite GetItemSprite(int itemNum)
    {
        return orig.GetItemSprite(itemNum);
    }

    public Vector3 GetItemSpriteScale(int itemNum)
    {
        return orig.GetItemSpriteScale(itemNum);
    }

    public bool CanBuy(int itemNum)
    {
        return orig.CanBuy(itemNum);
    }

    public GameObject GetItemGameObject(int itemNum)
    {
        return orig.GetItemGameObject(itemNum);
    }
}