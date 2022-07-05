namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dBatchedSprite allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dBatchedSpriteR : InstanceClassWrapper<tk2dBatchedSprite>
{
    public tk2dBatchedSpriteR(tk2dBatchedSprite _orig) : base(_orig)
    {
    }

    public string name
    {
        get => orig.name;
        set => orig.name = value;
    }

    public int parentId
    {
        get => orig.parentId;
        set => orig.parentId = value;
    }

    public int spriteId
    {
        get => orig.spriteId;
        set => orig.spriteId = value;
    }

    public int xRefId
    {
        get => orig.xRefId;
        set => orig.xRefId = value;
    }

    public tk2dSpriteCollectionData spriteCollection
    {
        get => orig.spriteCollection;
        set => orig.spriteCollection = value;
    }

    public Quaternion rotation
    {
        get => orig.rotation;
        set => orig.rotation = value;
    }

    public Vector3 position
    {
        get => orig.position;
        set => orig.position = value;
    }

    public Vector3 localScale
    {
        get => orig.localScale;
        set => orig.localScale = value;
    }

    public Color color
    {
        get => orig.color;
        set => orig.color = value;
    }

    public Vector3 baseScale
    {
        get => orig.baseScale;
        set => orig.baseScale = value;
    }

    public int renderLayer
    {
        get => orig.renderLayer;
        set => orig.renderLayer = value;
    }

    public Vector2 internalData0
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Vector2 internalData1
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Vector2 internalData2
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public Vector2 colliderData
    {
        get => GetField<Vector2>();
        set => SetField(value);
    }

    public string formattedText
    {
        get => GetField<string>();
        set => SetField(value);
    }

    public Matrix4x4 relativeMatrix
    {
        get => orig.relativeMatrix;
        set => orig.relativeMatrix = value;
    }

    public Vector3 cachedBoundsCenter
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 cachedBoundsExtents
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public float BoxColliderOffsetZ
    {
        get => orig.BoxColliderOffsetZ;
        set => orig.BoxColliderOffsetZ = value;
    }

    public float BoxColliderExtentZ
    {
        get => orig.BoxColliderExtentZ;
        set => orig.BoxColliderExtentZ = value;
    }

    public string FormattedText
    {
        get => orig.FormattedText;
        set => orig.FormattedText = value;
    }

    public Vector2 ClippedSpriteRegionBottomLeft
    {
        get => orig.ClippedSpriteRegionBottomLeft;
        set => orig.ClippedSpriteRegionBottomLeft = value;
    }

    public Vector2 ClippedSpriteRegionTopRight
    {
        get => orig.ClippedSpriteRegionTopRight;
        set => orig.ClippedSpriteRegionTopRight = value;
    }

    public Vector2 SlicedSpriteBorderBottomLeft
    {
        get => orig.SlicedSpriteBorderBottomLeft;
        set => orig.SlicedSpriteBorderBottomLeft = value;
    }

    public Vector2 SlicedSpriteBorderTopRight
    {
        get => orig.SlicedSpriteBorderTopRight;
        set => orig.SlicedSpriteBorderTopRight = value;
    }

    public Vector2 Dimensions
    {
        get => orig.Dimensions;
        set => orig.Dimensions = value;
    }

    public bool IsDrawn => orig.IsDrawn;

    public Vector3 CachedBoundsCenter
    {
        get => orig.CachedBoundsCenter;
        set => orig.CachedBoundsCenter = value;
    }

    public Vector3 CachedBoundsExtents
    {
        get => orig.CachedBoundsExtents;
        set => orig.CachedBoundsExtents = value;
    }

    public bool CheckFlag(tk2dBatchedSprite.Flags mask)
    {
        return orig.CheckFlag(mask);
    }

    public void SetFlag(tk2dBatchedSprite.Flags mask, bool value)
    {
        orig.SetFlag(mask, value);
    }

    public tk2dSpriteDefinition GetSpriteDefinition()
    {
        return orig.GetSpriteDefinition();
    }
}