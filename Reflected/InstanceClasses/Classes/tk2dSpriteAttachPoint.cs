namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteAttachPoint allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteAttachPointR : InstanceClassWrapper<tk2dSpriteAttachPoint>
{
    public tk2dSpriteAttachPointR(tk2dSpriteAttachPoint _orig) : base(_orig)
    {
    }

    public tk2dBaseSprite sprite
    {
        get => GetField<tk2dBaseSprite>();
        set => SetField(value);
    }

    public List<Transform> attachPoints
    {
        get => orig.attachPoints;
        set => orig.attachPoints = value;
    }

    public bool[] attachPointUpdated
    {
        get => GetFieldStatic<bool[]>();
        set => SetField(value);
    }

    public bool deactivateUnusedAttachPoints
    {
        get => orig.deactivateUnusedAttachPoints;
        set => orig.deactivateUnusedAttachPoints = value;
    }

    public Dictionary<Transform, string> cachedInstanceNames
    {
        get => GetField<Dictionary<Transform, string>>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void UpdateAttachPointTransform(tk2dSpriteDefinition.AttachPoint attachPoint, Transform t)
    {
        CallMethod(new object[] { attachPoint, t });
    }

    public string GetInstanceName(Transform t)
    {
        return CallMethod<string>(new object[] { t });
    }

    public void HandleSpriteChanged(tk2dBaseSprite spr)
    {
        CallMethod(new object[] { spr });
    }
}