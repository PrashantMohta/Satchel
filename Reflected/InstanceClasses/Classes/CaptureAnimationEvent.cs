namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of CaptureAnimationEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CaptureAnimationEventR : InstanceClassWrapper<CaptureAnimationEvent>
{
    public CaptureAnimationEventR(CaptureAnimationEvent _orig) : base(_orig)
    {
    }

    public PlayerData playerData
    {
        get => GetField<PlayerData>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void SetPlayerDataBoolTrue(string boolName)
    {
        orig.SetPlayerDataBoolTrue(boolName);
    }

    public void SetPlayerDataBoolFalse(string boolName)
    {
        orig.SetPlayerDataBoolFalse(boolName);
    }

    public void IncrementPlayerDataInt(string intName)
    {
        orig.IncrementPlayerDataInt(intName);
    }

    public void DecrementPlayerDataInt(string intName)
    {
        orig.DecrementPlayerDataInt(intName);
    }

    public bool GetPlayerDataBool(string boolName)
    {
        return orig.GetPlayerDataBool(boolName);
    }

    public int GetPlayerDataInt(string intName)
    {
        return orig.GetPlayerDataInt(intName);
    }

    public float GetPlayerDataFloat(string floatName)
    {
        return orig.GetPlayerDataFloat(floatName);
    }

    public string GetPlayerDataString(string stringName)
    {
        return orig.GetPlayerDataString(stringName);
    }

    public void EquipCharm(int charmNum)
    {
        orig.EquipCharm(charmNum);
    }

    public void UnequipCharm(int charmNum)
    {
        orig.UnequipCharm(charmNum);
    }

    public void UpdateBlueHealth()
    {
        orig.UpdateBlueHealth();
    }
}