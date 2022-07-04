namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpriteChunk allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpriteChunkR:InstanceClassWrapper<tk2dRuntime.TileMap.SpriteChunk>
{
public SpriteChunkR(tk2dRuntime.TileMap.SpriteChunk _orig) : base(_orig) {}
public bool dirty
{
get => GetField<bool>();
set => SetField(value);
}

public System.Int32[] spriteIds
{
get => orig.spriteIds;
set => orig.spriteIds = value;
}

public UnityEngine.GameObject gameObject
{
get => orig.gameObject;
set => orig.gameObject = value;
}

public UnityEngine.Mesh mesh
{
get => orig.mesh;
set => orig.mesh = value;
}

public UnityEngine.MeshCollider meshCollider
{
get => orig.meshCollider;
set => orig.meshCollider = value;
}

public UnityEngine.Mesh colliderMesh
{
get => orig.colliderMesh;
set => orig.colliderMesh = value;
}

public System.Collections.Generic.List<UnityEngine.EdgeCollider2D> edgeColliders
{
get => orig.edgeColliders;
set => orig.edgeColliders = value;
}

public bool Dirty
{
get => orig.Dirty;
set => orig.Dirty = value;
}

public bool IsEmpty
{
get => orig.IsEmpty;
}

public bool HasGameData
{
get => orig.HasGameData;
}

public void DestroyGameData (tk2dTileMap tileMap) =>
orig.DestroyGameData(tileMap);

public void DestroyColliderData (tk2dTileMap tileMap) =>
orig.DestroyColliderData(tileMap);

}
}
