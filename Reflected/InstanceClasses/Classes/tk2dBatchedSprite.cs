namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dBatchedSprite allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dBatchedSpriteR:InstanceClassWrapper<tk2dBatchedSprite>
{
public tk2dBatchedSpriteR(tk2dBatchedSprite _orig) : base(_orig) {}
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

public UnityEngine.Quaternion rotation
{
get => orig.rotation;
set => orig.rotation = value;
}

public UnityEngine.Vector3 position
{
get => orig.position;
set => orig.position = value;
}

public UnityEngine.Vector3 localScale
{
get => orig.localScale;
set => orig.localScale = value;
}

public UnityEngine.Color color
{
get => orig.color;
set => orig.color = value;
}

public UnityEngine.Vector3 baseScale
{
get => orig.baseScale;
set => orig.baseScale = value;
}

public int renderLayer
{
get => orig.renderLayer;
set => orig.renderLayer = value;
}

public UnityEngine.Vector2 internalData0
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 internalData1
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 internalData2
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public UnityEngine.Vector2 colliderData
{
get => GetField<UnityEngine.Vector2>();
set => SetField(value);
}

public string formattedText
{
get => GetField<string>();
set => SetField(value);
}

public UnityEngine.Matrix4x4 relativeMatrix
{
get => orig.relativeMatrix;
set => orig.relativeMatrix = value;
}

public UnityEngine.Vector3 cachedBoundsCenter
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector3 cachedBoundsExtents
{
get => GetField<UnityEngine.Vector3>();
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

public UnityEngine.Vector2 ClippedSpriteRegionBottomLeft
{
get => orig.ClippedSpriteRegionBottomLeft;
set => orig.ClippedSpriteRegionBottomLeft = value;
}

public UnityEngine.Vector2 ClippedSpriteRegionTopRight
{
get => orig.ClippedSpriteRegionTopRight;
set => orig.ClippedSpriteRegionTopRight = value;
}

public UnityEngine.Vector2 SlicedSpriteBorderBottomLeft
{
get => orig.SlicedSpriteBorderBottomLeft;
set => orig.SlicedSpriteBorderBottomLeft = value;
}

public UnityEngine.Vector2 SlicedSpriteBorderTopRight
{
get => orig.SlicedSpriteBorderTopRight;
set => orig.SlicedSpriteBorderTopRight = value;
}

public UnityEngine.Vector2 Dimensions
{
get => orig.Dimensions;
set => orig.Dimensions = value;
}

public bool IsDrawn
{
get => orig.IsDrawn;
}

public UnityEngine.Vector3 CachedBoundsCenter
{
get => orig.CachedBoundsCenter;
set => orig.CachedBoundsCenter = value;
}

public UnityEngine.Vector3 CachedBoundsExtents
{
get => orig.CachedBoundsExtents;
set => orig.CachedBoundsExtents = value;
}

public bool CheckFlag (tk2dBatchedSprite.Flags mask) =>
orig.CheckFlag(mask);

public void SetFlag (tk2dBatchedSprite.Flags mask, bool value) =>
orig.SetFlag(mask, value);

public tk2dSpriteDefinition GetSpriteDefinition () =>
orig.GetSpriteDefinition();

}
}
