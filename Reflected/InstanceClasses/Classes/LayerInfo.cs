namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LayerInfo allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LayerInfoR:InstanceClassWrapper<tk2dRuntime.TileMap.LayerInfo>
{
public LayerInfoR(tk2dRuntime.TileMap.LayerInfo _orig) : base(_orig) {}
public string name
{
get => orig.name;
set => orig.name = value;
}

public int hash
{
get => orig.hash;
set => orig.hash = value;
}

public bool useColor
{
get => orig.useColor;
set => orig.useColor = value;
}

public bool generateCollider
{
get => orig.generateCollider;
set => orig.generateCollider = value;
}

public float z
{
get => orig.z;
set => orig.z = value;
}

public int unityLayer
{
get => orig.unityLayer;
set => orig.unityLayer = value;
}

public string sortingLayerName
{
get => orig.sortingLayerName;
set => orig.sortingLayerName = value;
}

public int sortingOrder
{
get => orig.sortingOrder;
set => orig.sortingOrder = value;
}

public bool skipMeshGeneration
{
get => orig.skipMeshGeneration;
set => orig.skipMeshGeneration = value;
}

public UnityEngine.PhysicMaterial physicMaterial
{
get => orig.physicMaterial;
set => orig.physicMaterial = value;
}

public UnityEngine.PhysicsMaterial2D physicsMaterial2D
{
get => orig.physicsMaterial2D;
set => orig.physicsMaterial2D = value;
}

}
}
