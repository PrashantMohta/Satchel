namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteCollectionDefinition allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteCollectionDefinitionR:InstanceClassWrapper<tk2dSpriteCollectionDefinition>
{
public tk2dSpriteCollectionDefinitionR(tk2dSpriteCollectionDefinition _orig) : base(_orig) {}
public string name
{
get => orig.name;
set => orig.name = value;
}

public bool disableTrimming
{
get => orig.disableTrimming;
set => orig.disableTrimming = value;
}

public bool additive
{
get => orig.additive;
set => orig.additive = value;
}

public UnityEngine.Vector3 scale
{
get => orig.scale;
set => orig.scale = value;
}

public UnityEngine.Texture2D texture
{
get => orig.texture;
set => orig.texture = value;
}

public UnityEngine.Texture2D thumbnailTexture
{
get => orig.thumbnailTexture;
set => orig.thumbnailTexture = value;
}

public int materialId
{
get => orig.materialId;
set => orig.materialId = value;
}

public float anchorX
{
get => orig.anchorX;
set => orig.anchorX = value;
}

public float anchorY
{
get => orig.anchorY;
set => orig.anchorY = value;
}

public UnityEngine.Object overrideMesh
{
get => orig.overrideMesh;
set => orig.overrideMesh = value;
}

public bool doubleSidedSprite
{
get => orig.doubleSidedSprite;
set => orig.doubleSidedSprite = value;
}

public bool customSpriteGeometry
{
get => orig.customSpriteGeometry;
set => orig.customSpriteGeometry = value;
}

public tk2dSpriteColliderIsland[] geometryIslands
{
get => orig.geometryIslands;
set => orig.geometryIslands = value;
}

public bool dice
{
get => orig.dice;
set => orig.dice = value;
}

public int diceUnitX
{
get => orig.diceUnitX;
set => orig.diceUnitX = value;
}

public int diceUnitY
{
get => orig.diceUnitY;
set => orig.diceUnitY = value;
}

public int extraPadding
{
get => orig.extraPadding;
set => orig.extraPadding = value;
}

public bool fromSpriteSheet
{
get => orig.fromSpriteSheet;
set => orig.fromSpriteSheet = value;
}

public bool hasSpriteSheetId
{
get => orig.hasSpriteSheetId;
set => orig.hasSpriteSheetId = value;
}

public int spriteSheetId
{
get => orig.spriteSheetId;
set => orig.spriteSheetId = value;
}

public int spriteSheetX
{
get => orig.spriteSheetX;
set => orig.spriteSheetX = value;
}

public int spriteSheetY
{
get => orig.spriteSheetY;
set => orig.spriteSheetY = value;
}

public bool extractRegion
{
get => orig.extractRegion;
set => orig.extractRegion = value;
}

public int regionX
{
get => orig.regionX;
set => orig.regionX = value;
}

public int regionY
{
get => orig.regionY;
set => orig.regionY = value;
}

public int regionW
{
get => orig.regionW;
set => orig.regionW = value;
}

public int regionH
{
get => orig.regionH;
set => orig.regionH = value;
}

public int regionId
{
get => orig.regionId;
set => orig.regionId = value;
}

public System.Collections.Generic.List<tk2dSpriteCollectionDefinition.ColliderData> colliderData
{
get => orig.colliderData;
set => orig.colliderData = value;
}

public UnityEngine.Vector2 boxColliderMin
{
get => orig.boxColliderMin;
set => orig.boxColliderMin = value;
}

public UnityEngine.Vector2 boxColliderMax
{
get => orig.boxColliderMax;
set => orig.boxColliderMax = value;
}

public tk2dSpriteColliderIsland[] polyColliderIslands
{
get => orig.polyColliderIslands;
set => orig.polyColliderIslands = value;
}

public bool colliderConvex
{
get => orig.colliderConvex;
set => orig.colliderConvex = value;
}

public bool colliderSmoothSphereCollisions
{
get => orig.colliderSmoothSphereCollisions;
set => orig.colliderSmoothSphereCollisions = value;
}

public System.Collections.Generic.List<tk2dSpriteDefinition.AttachPoint> attachPoints
{
get => orig.attachPoints;
set => orig.attachPoints = value;
}

public void CopyFrom (tk2dSpriteCollectionDefinition src) =>
orig.CopyFrom(src);

public void Clear () =>
orig.Clear();

public bool CompareTo (tk2dSpriteCollectionDefinition src) =>
orig.CompareTo(src);

}
}
