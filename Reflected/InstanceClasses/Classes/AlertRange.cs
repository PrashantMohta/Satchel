namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of AlertRange allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AlertRangeR : InstanceClassWrapper<AlertRange>
{
    public AlertRangeR(AlertRange _orig) : base(_orig)
    {
    }

    public bool isHeroInRange
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Collider2D[] colliders
    {
        get => GetField<Collider2D[]>();
        set => SetField(value);
    }

    public bool IsHeroInRange => orig.IsHeroInRange;


    public void Awake()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        CallMethod(new object[] { other });
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        CallMethod(new object[] { other });
    }

    public bool StillInColliders()
    {
        return CallMethod<bool>();
    }

    public AlertRange Find(GameObject root, string childName)
    {
        return AlertRange.Find(root, childName);
    }
}