namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of SetRandomSpriteId allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SetRandomSpriteIdR : InstanceClassWrapper<SetRandomSpriteId>
{
    public SetRandomSpriteIdR(SetRandomSpriteId _orig) : base(_orig)
    {
    }

    public tk2dSprite sprite
    {
        get => GetField<tk2dSprite>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Init()
    {
        orig.Init();
    }
}