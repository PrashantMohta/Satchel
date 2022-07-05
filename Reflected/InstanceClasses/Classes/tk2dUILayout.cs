namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUILayout allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUILayoutR : InstanceClassWrapper<tk2dUILayout>
{
    public tk2dUILayoutR(tk2dUILayout _orig) : base(_orig)
    {
    }

    public Vector3 bMin
    {
        get => orig.bMin;
        set => orig.bMin = value;
    }

    public Vector3 bMax
    {
        get => orig.bMax;
        set => orig.bMax = value;
    }

    public List<tk2dUILayoutItem> layoutItems
    {
        get => orig.layoutItems;
        set => orig.layoutItems = value;
    }

    public bool autoResizeCollider
    {
        get => orig.autoResizeCollider;
        set => orig.autoResizeCollider = value;
    }

    public Action<Vector3, Vector3> OnReshape
    {
        get => GetField<Action<Vector3, Vector3>>();
        set => SetField(value);
    }

    public int ItemCount => orig.ItemCount;


    public void Reset()
    {
        CallMethod();
    }

    public void Reshape(Vector3 dMin, Vector3 dMax, bool updateChildren)
    {
        orig.Reshape(dMin, dMax, updateChildren);
    }

    public void SetBounds(Vector3 pMin, Vector3 pMax)
    {
        orig.SetBounds(pMin, pMax);
    }

    public Vector3 GetMinBounds()
    {
        return orig.GetMinBounds();
    }

    public Vector3 GetMaxBounds()
    {
        return orig.GetMaxBounds();
    }

    public void Refresh()
    {
        orig.Refresh();
    }
}