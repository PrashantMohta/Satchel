namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dStaticSpriteBatcher allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dStaticSpriteBatcherR:InstanceClassWrapper<tk2dStaticSpriteBatcher>
{
public tk2dStaticSpriteBatcherR(tk2dStaticSpriteBatcher _orig) : base(_orig) {}
public int CURRENT_VERSION
{
get => tk2dStaticSpriteBatcher.CURRENT_VERSION;
set => tk2dStaticSpriteBatcher.CURRENT_VERSION = value;
}

public int version
{
get => orig.version;
set => orig.version = value;
}

public tk2dBatchedSprite[] batchedSprites
{
get => orig.batchedSprites;
set => orig.batchedSprites = value;
}

public tk2dTextMeshData[] allTextMeshData
{
get => orig.allTextMeshData;
set => orig.allTextMeshData = value;
}

public tk2dSpriteCollectionData spriteCollection
{
get => orig.spriteCollection;
set => orig.spriteCollection = value;
}

public UnityEngine.Mesh mesh
{
get => GetField<UnityEngine.Mesh>();
set => SetField(value);
}

public UnityEngine.Mesh colliderMesh
{
get => GetField<UnityEngine.Mesh>();
set => SetField(value);
}

public UnityEngine.Vector3 _scale
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}



public bool CheckFlag (tk2dStaticSpriteBatcher.Flags mask) =>
orig.CheckFlag(mask);

public void SetFlag (tk2dStaticSpriteBatcher.Flags mask, bool value) =>
orig.SetFlag(mask, value);

public void Awake () =>
CallMethod();

public bool UpgradeData () =>
CallMethod<bool>();

public void OnDestroy () =>
CallMethod();

public void UpdateMatrices () =>
orig.UpdateMatrices();

public void Build () =>
orig.Build();

public void SortBatchedSprites () =>
CallMethod();

public UnityEngine.Material GetMaterial (tk2dBatchedSprite bs) =>
CallMethod<UnityEngine.Material>(new object[] {bs});

public void BuildRenderMesh () =>
CallMethod();

public void BuildPhysicsMesh () =>
CallMethod();

public void BuildPhysicsMesh2D (UnityEngine.EdgeCollider2D[] edgeColliders, int numEdgeColliders) =>
CallMethod(new object[] {edgeColliders, numEdgeColliders});

public void BuildPhysicsMesh3D (UnityEngine.MeshCollider meshCollider, bool flattenDepth, int numVertices, int numIndices) =>
CallMethod(new object[] {meshCollider, flattenDepth, numVertices, numIndices});

public bool UsesSpriteCollection (tk2dSpriteCollectionData spriteCollection) =>
orig.UsesSpriteCollection(spriteCollection);

public void ForceBuild () =>
orig.ForceBuild();

}
}
