namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of AreaTitleController allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class AreaTitleControllerR:InstanceClassWrapper<AreaTitleController>
{
public AreaTitleControllerR(AreaTitleController _orig) : base(_orig) {}
// public System.Collections.Generic.List<AreaTitleController.Area> areaList
// {
// get => GetField<System.Collections.Generic.List<AreaTitleController.Area>>();
// set => SetField(value);
// }

public bool waitForHeroInPosition
{
get => orig.waitForHeroInPosition;
set => orig.waitForHeroInPosition = value;
}

public string areaEvent
{
get => orig.areaEvent;
set => orig.areaEvent = value;
}

public bool displayRight
{
get => orig.displayRight;
set => orig.displayRight = value;
}

public string doorTrigger
{
get => orig.doorTrigger;
set => orig.doorTrigger = value;
}

public bool onlyOnRevisit
{
get => orig.onlyOnRevisit;
set => orig.onlyOnRevisit = value;
}

public float unvisitedPause
{
get => orig.unvisitedPause;
set => orig.unvisitedPause = value;
}

public float visitedPause
{
get => orig.visitedPause;
set => orig.visitedPause = value;
}

public bool waitForTrigger
{
get => orig.waitForTrigger;
set => orig.waitForTrigger = value;
}

public UnityEngine.GameObject areaTitle
{
get => orig.areaTitle;
set => orig.areaTitle = value;
}

public bool played
{
get => GetField<bool>();
set => SetField(value);
}

public bool doFinish
{
get => GetField<bool>();
set => SetField(value);
}

public HeroController hc
{
get => GetField<HeroController>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void FindAreaTitle () =>
CallMethod();

public void DoPlay () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void Play () =>
CallMethod();

public void CheckArea () =>
CallMethod();

public void Finish () =>
CallMethod();

public System.Collections.IEnumerator VisitPause (bool pause = true) =>
CallMethod<System.Collections.IEnumerator>(new object[] {pause});

public System.Collections.IEnumerator UnvisitPause (bool pause = true) =>
CallMethod<System.Collections.IEnumerator>(new object[] {pause});

}
}
