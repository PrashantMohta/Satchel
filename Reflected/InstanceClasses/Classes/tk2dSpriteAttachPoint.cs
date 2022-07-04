namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dSpriteAttachPoint allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dSpriteAttachPointR:InstanceClassWrapper<tk2dSpriteAttachPoint>
{
public tk2dSpriteAttachPointR(tk2dSpriteAttachPoint _orig) : base(_orig) {}
public tk2dBaseSprite sprite
{
get => GetField<tk2dBaseSprite>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Transform> attachPoints
{
get => orig.attachPoints;
set => orig.attachPoints = value;
}

public System.Boolean[] attachPointUpdated
{
get => GetFieldStatic<System.Boolean[]>();
set => SetField(value);
}

public bool deactivateUnusedAttachPoints
{
get => orig.deactivateUnusedAttachPoints;
set => orig.deactivateUnusedAttachPoints = value;
}

public System.Collections.Generic.Dictionary<UnityEngine.Transform,System.String> cachedInstanceNames
{
get => GetField<System.Collections.Generic.Dictionary<UnityEngine.Transform,System.String>>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void UpdateAttachPointTransform (tk2dSpriteDefinition.AttachPoint attachPoint, UnityEngine.Transform t) =>
CallMethod(new object[] {attachPoint, t});

public string GetInstanceName (UnityEngine.Transform t) =>
CallMethod<string>(new object[] {t});

public void HandleSpriteChanged (tk2dBaseSprite spr) =>
CallMethod(new object[] {spr});

}
}
