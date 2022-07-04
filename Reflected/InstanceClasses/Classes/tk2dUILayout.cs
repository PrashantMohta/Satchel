namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUILayout allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUILayoutR:InstanceClassWrapper<tk2dUILayout>
{
public tk2dUILayoutR(tk2dUILayout _orig) : base(_orig) {}
public UnityEngine.Vector3 bMin
{
get => orig.bMin;
set => orig.bMin = value;
}

public UnityEngine.Vector3 bMax
{
get => orig.bMax;
set => orig.bMax = value;
}

public System.Collections.Generic.List<tk2dUILayoutItem> layoutItems
{
get => orig.layoutItems;
set => orig.layoutItems = value;
}

public bool autoResizeCollider
{
get => orig.autoResizeCollider;
set => orig.autoResizeCollider = value;
}

public System.Action<UnityEngine.Vector3,UnityEngine.Vector3> OnReshape
{
get => GetField<System.Action<UnityEngine.Vector3,UnityEngine.Vector3>>();
set => SetField(value);
}

public int ItemCount
{
get => orig.ItemCount;
}



public void Reset () =>
CallMethod();

public void Reshape (UnityEngine.Vector3 dMin, UnityEngine.Vector3 dMax, bool updateChildren) =>
orig.Reshape(dMin, dMax, updateChildren);

public void SetBounds (UnityEngine.Vector3 pMin, UnityEngine.Vector3 pMax) =>
orig.SetBounds(pMin, pMax);

public UnityEngine.Vector3 GetMinBounds () =>
orig.GetMinBounds();

public UnityEngine.Vector3 GetMaxBounds () =>
orig.GetMaxBounds();

public void Refresh () =>
orig.Refresh();

}
}
