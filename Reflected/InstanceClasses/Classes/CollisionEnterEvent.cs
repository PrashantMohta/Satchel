namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of CollisionEnterEvent allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class CollisionEnterEventR:InstanceClassWrapper<CollisionEnterEvent>
{
public CollisionEnterEventR(CollisionEnterEvent _orig) : base(_orig) {}
public bool checkDirection
{
get => orig.checkDirection;
set => orig.checkDirection = value;
}

public bool ignoreTriggers
{
get => orig.ignoreTriggers;
set => orig.ignoreTriggers = value;
}

public int otherLayer
{
get => orig.otherLayer;
set => orig.otherLayer = value;
}

public bool doCollisionStay
{
get => orig.doCollisionStay;
set => orig.doCollisionStay = value;
}

public UnityEngine.Collider2D col2d
{
get => GetField<UnityEngine.Collider2D>();
set => SetField(value);
}

public float RAYCAST_LENGTH
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Vector2> topRays
{
get => GetField<System.Collections.Generic.List<UnityEngine.Vector2>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Vector2> rightRays
{
get => GetField<System.Collections.Generic.List<UnityEngine.Vector2>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Vector2> bottomRays
{
get => GetField<System.Collections.Generic.List<UnityEngine.Vector2>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Vector2> leftRays
{
get => GetField<System.Collections.Generic.List<UnityEngine.Vector2>>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnCollisionEnter2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void OnCollisionStay2D (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void HandleCollision (UnityEngine.Collision2D collision) =>
CallMethod(new object[] {collision});

public void CheckTouching (UnityEngine.LayerMask layer, UnityEngine.Collision2D collision) =>
CallMethod(new object[] {layer, collision});

}
}
