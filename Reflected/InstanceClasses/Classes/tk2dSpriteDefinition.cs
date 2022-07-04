namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteDefinition allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteDefinitionR:InstanceClassWrapper<tk2dSpriteDefinition>
{
public tk2dSpriteDefinitionR(tk2dSpriteDefinition _orig) : base(_orig) {}
public string name
{
get => orig.name;
set => orig.name = value;
}

public UnityEngine.Vector3[] boundsData
{
get => orig.boundsData;
set => orig.boundsData = value;
}

public UnityEngine.Vector3[] untrimmedBoundsData
{
get => orig.untrimmedBoundsData;
set => orig.untrimmedBoundsData = value;
}

public UnityEngine.Vector2 texelSize
{
get => orig.texelSize;
set => orig.texelSize = value;
}

public UnityEngine.Vector3[] positions
{
get => orig.positions;
set => orig.positions = value;
}

public UnityEngine.Vector3[] normals
{
get => orig.normals;
set => orig.normals = value;
}

public UnityEngine.Vector4[] tangents
{
get => orig.tangents;
set => orig.tangents = value;
}

public UnityEngine.Vector2[] uvs
{
get => orig.uvs;
set => orig.uvs = value;
}

public UnityEngine.Vector2[] normalizedUvs
{
get => orig.normalizedUvs;
set => orig.normalizedUvs = value;
}

public System.Int32[] indices
{
get => orig.indices;
set => orig.indices = value;
}

public UnityEngine.Material material
{
get => orig.material;
set => orig.material = value;
}

public UnityEngine.Material materialInst
{
get => orig.materialInst;
set => orig.materialInst = value;
}

public int materialId
{
get => orig.materialId;
set => orig.materialId = value;
}

public string sourceTextureGUID
{
get => orig.sourceTextureGUID;
set => orig.sourceTextureGUID = value;
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

public bool complexGeometry
{
get => orig.complexGeometry;
set => orig.complexGeometry = value;
}

public tk2dSpriteColliderDefinition[] customColliders
{
get => orig.customColliders;
set => orig.customColliders = value;
}

public UnityEngine.Vector3[] colliderVertices
{
get => orig.colliderVertices;
set => orig.colliderVertices = value;
}

public System.Int32[] colliderIndicesFwd
{
get => orig.colliderIndicesFwd;
set => orig.colliderIndicesFwd = value;
}

public System.Int32[] colliderIndicesBack
{
get => orig.colliderIndicesBack;
set => orig.colliderIndicesBack = value;
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

public tk2dCollider2DData[] polygonCollider2D
{
get => orig.polygonCollider2D;
set => orig.polygonCollider2D = value;
}

public tk2dCollider2DData[] edgeCollider2D
{
get => orig.edgeCollider2D;
set => orig.edgeCollider2D = value;
}

public tk2dSpriteDefinition.AttachPoint[] attachPoints
{
get => orig.attachPoints;
set => orig.attachPoints = value;
}

public bool Valid
{
get => orig.Valid;
}

public UnityEngine.Bounds GetBounds () =>
orig.GetBounds();

public UnityEngine.Bounds GetUntrimmedBounds () =>
orig.GetUntrimmedBounds();

}
}
