namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of ColourPainter allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ColourPainterR : InstanceClassWrapper<ColourPainter>
{
    public ColourPainterR(ColourPainter _orig) : base(_orig)
    {
    }

    public Color colour
    {
        get => orig.colour;
        set => orig.colour = value;
    }

    public int chance
    {
        get => orig.chance;
        set => orig.chance = value;
    }

    public float delay
    {
        get => orig.delay;
        set => orig.delay = value;
    }

    public List<SpriteRenderer> splatList
    {
        get => orig.splatList;
        set => orig.splatList = value;
    }

    public BoxCollider2D boxCollider
    {
        get => GetField<BoxCollider2D>();
        set => SetField(value);
    }

    public float timer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool active
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool painted
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }

    public void DoPaint()
    {
        orig.DoPaint();
    }
}