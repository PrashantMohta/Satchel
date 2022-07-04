using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of TouchSprite allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TouchSpriteR : InstanceClassWrapper<TouchSprite>
{
    public TouchSpriteR(TouchSprite _orig) : base(_orig)
    {
    }

    public Sprite idleSprite
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite busySprite
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Color idleColor
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public Color busyColor
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public TouchSpriteShape shape
    {
        get => GetField<TouchSpriteShape>();
        set => SetField(value);
    }

    public TouchUnitType sizeUnitType
    {
        get => GetField<TouchUnitType>();
        set => SetField(value);
    }

    public Vector2 size
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public bool lockAspectRatio
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Vector2 worldSize
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public GameObject spriteGameObject
    {
        get => GetField<GameObject>();
        set => SetField(value);
    }

    public SpriteRenderer spriteRenderer
    {
        get => GetField<SpriteRenderer>();
        set => SetField(value);
    }

    public bool state
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Shader spriteRendererShader
    {
        get => GetFieldStatic<Shader>();
        set => SetField(value);
    }

    public Material spriteRendererMaterial
    {
        get => GetFieldStatic<Material>();
        set => SetField(value);
    }

    public int spriteRendererPixelSnapId => GetFieldStatic<int>();
}