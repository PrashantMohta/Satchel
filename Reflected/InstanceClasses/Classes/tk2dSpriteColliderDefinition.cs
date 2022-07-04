namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteColliderDefinition allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteColliderDefinitionR:InstanceClassWrapper<tk2dSpriteColliderDefinition>
{
public tk2dSpriteColliderDefinitionR(tk2dSpriteColliderDefinition _orig) : base(_orig) {}
public UnityEngine.Vector3 origin
{
get => orig.origin;
set => orig.origin = value;
}

public float angle
{
get => orig.angle;
set => orig.angle = value;
}

public string name
{
get => orig.name;
set => orig.name = value;
}

public UnityEngine.Vector3[] vectors
{
get => orig.vectors;
set => orig.vectors = value;
}

public System.Single[] floats
{
get => orig.floats;
set => orig.floats = value;
}

public float Radius
{
get => orig.Radius;
}

public UnityEngine.Vector3 Size
{
get => orig.Size;
}

}
}
