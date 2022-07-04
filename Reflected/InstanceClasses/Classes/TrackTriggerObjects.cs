namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of TrackTriggerObjects allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class TrackTriggerObjectsR:InstanceClassWrapper<TrackTriggerObjects>
{
public TrackTriggerObjectsR(TrackTriggerObjects _orig) : base(_orig) {}
public UnityEngine.LayerMask ignoreLayers
{
get => GetField<UnityEngine.LayerMask>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.GameObject> insideGameObjects
{
get => GetField<System.Collections.Generic.List<UnityEngine.GameObject>>();
set => SetField(value);
}

public int layerMask
{
get => GetField<int>();
set => SetField(value);
}

public bool gottenOverlappedColliders
{
get => GetField<bool>();
set => SetField(value);
}

public bool subscribed
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.Collider2D[] _tempResults
{
get => GetFieldStatic<UnityEngine.Collider2D[]>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.GameObject> _refreshTemp
{
get => GetFieldStatic<System.Collections.Generic.List<UnityEngine.GameObject>>();
set => SetField(value);
}

public int InsideCount
{
get => orig.InsideCount;
}



public void OnDisable () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

public void OnHeroInPosition (bool forceDirect) =>
CallMethod(new object[] {forceDirect});

public void GetOverlappedColliders (bool isRefresh = false) =>
CallMethod(new object[] {isRefresh});

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void OnTriggerExit2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void OnExit (UnityEngine.GameObject obj) =>
CallMethod(new object[] {obj});

public bool IsIgnored (UnityEngine.GameObject obj) =>
CallMethod<bool>(new object[] {obj});

}
}
