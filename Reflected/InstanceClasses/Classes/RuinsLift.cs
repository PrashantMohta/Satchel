namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of RuinsLift allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RuinsLiftR : InstanceClassWrapper<RuinsLift>
{
    public RuinsLiftR(RuinsLift _orig) : base(_orig)
    {
    }

    public float[] stopPositions
    {
        get => orig.stopPositions;
        set => orig.stopPositions = value;
    }

    public Transform chainsParent
    {
        get => orig.chainsParent;
        set => orig.chainsParent = value;
    }

    public List<Transform> chains
    {
        get => GetField<List<Transform>>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public IEnumerator HideChains()
    {
        return CallMethod<IEnumerator>();
    }

    public float GetPositionY(int position)
    {
        return orig.GetPositionY(position);
    }

    public bool IsCurrentPositionTerminus(int position)
    {
        return orig.IsCurrentPositionTerminus(position);
    }

    public int KeepInBounds(int position)
    {
        return orig.KeepInBounds(position);
    }
}