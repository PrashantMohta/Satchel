namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ProjectLocationToMap allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ProjectLocationToMapR:InstanceClassWrapper<HutongGames.PlayMaker.Actions.ProjectLocationToMap>
{
public ProjectLocationToMapR(HutongGames.PlayMaker.Actions.ProjectLocationToMap _orig) : base(_orig) {}
public HutongGames.PlayMaker.FsmVector3 GPSLocation
{
get => orig.GPSLocation;
set => orig.GPSLocation = value;
}

public HutongGames.PlayMaker.FsmFloat minLongitude
{
get => orig.minLongitude;
set => orig.minLongitude = value;
}

public HutongGames.PlayMaker.FsmFloat maxLongitude
{
get => orig.maxLongitude;
set => orig.maxLongitude = value;
}

public HutongGames.PlayMaker.FsmFloat minLatitude
{
get => orig.minLatitude;
set => orig.minLatitude = value;
}

public HutongGames.PlayMaker.FsmFloat maxLatitude
{
get => orig.maxLatitude;
set => orig.maxLatitude = value;
}

public HutongGames.PlayMaker.FsmFloat minX
{
get => orig.minX;
set => orig.minX = value;
}

public HutongGames.PlayMaker.FsmFloat minY
{
get => orig.minY;
set => orig.minY = value;
}

public HutongGames.PlayMaker.FsmFloat width
{
get => orig.width;
set => orig.width = value;
}

public HutongGames.PlayMaker.FsmFloat height
{
get => orig.height;
set => orig.height = value;
}

public HutongGames.PlayMaker.FsmFloat projectedX
{
get => orig.projectedX;
set => orig.projectedX = value;
}

public HutongGames.PlayMaker.FsmFloat projectedY
{
get => orig.projectedY;
set => orig.projectedY = value;
}

public HutongGames.PlayMaker.FsmBool normalized
{
get => orig.normalized;
set => orig.normalized = value;
}

public bool everyFrame
{
get => orig.everyFrame;
set => orig.everyFrame = value;
}

public float x
{
get => GetField<float>();
set => SetField(value);
}

public float y
{
get => GetField<float>();
set => SetField(value);
}

public string Name
{
get => orig.Name;
set => orig.Name = value;
}

public string DisplayName
{
get => orig.DisplayName;
set => orig.DisplayName = value;
}

public HutongGames.PlayMaker.Fsm Fsm
{
get => orig.Fsm;
set => orig.Fsm = value;
}

public UnityEngine.GameObject Owner
{
get => orig.Owner;
set => orig.Owner = value;
}

public HutongGames.PlayMaker.FsmState State
{
get => orig.State;
set => orig.State = value;
}

public bool Enabled
{
get => orig.Enabled;
set => orig.Enabled = value;
}

public bool IsOpen
{
get => orig.IsOpen;
set => orig.IsOpen = value;
}

public bool IsAutoNamed
{
get => orig.IsAutoNamed;
set => orig.IsAutoNamed = value;
}

public bool Entered
{
get => orig.Entered;
set => orig.Entered = value;
}

public bool Finished
{
get => orig.Finished;
set => orig.Finished = value;
}

public bool Active
{
get => orig.Active;
set => orig.Active = value;
}

public void Reset () =>
orig.Reset();

public void OnEnter () =>
orig.OnEnter();

public void OnUpdate () =>
orig.OnUpdate();

public void DoProjectGPSLocation () =>
CallMethod();

public void DoEquidistantCylindrical () =>
CallMethod();

public void DoMercatorProjection () =>
CallMethod();

public float LatitudeToMercator (float latitudeInDegrees) =>
CallMethodStatic<float>(new object[] {latitudeInDegrees});

}
}
