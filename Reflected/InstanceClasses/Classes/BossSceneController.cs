namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BossSceneController allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossSceneControllerR:InstanceClassWrapper<BossSceneController>
{
public BossSceneControllerR(BossSceneController _orig) : base(_orig) {}
public BossSceneController Instance
{
get => BossSceneController.Instance;
set => BossSceneController.Instance = value;
}

public System.Action OnBossesDead
{
get => GetField<System.Action>();
set => SetField(value);
}

public System.Action OnBossSceneComplete
{
get => GetField<System.Action>();
set => SetField(value);
}

public UnityEngine.Transform heroSpawn
{
get => orig.heroSpawn;
set => orig.heroSpawn = value;
}

public UnityEngine.GameObject transitionPrefab
{
get => orig.transitionPrefab;
set => orig.transitionPrefab = value;
}

public EventRegister endTransitionEvent
{
get => orig.endTransitionEvent;
set => orig.endTransitionEvent = value;
}

public bool doTransitionIn
{
get => orig.doTransitionIn;
set => orig.doTransitionIn = value;
}

public float transitionInHoldTime
{
get => orig.transitionInHoldTime;
set => orig.transitionInHoldTime = value;
}

public bool doTransitionOut
{
get => orig.doTransitionOut;
set => orig.doTransitionOut = value;
}

public float transitionOutHoldTime
{
get => orig.transitionOutHoldTime;
set => orig.transitionOutHoldTime = value;
}

public bool isTransitioningOut
{
get => GetField<bool>();
set => SetField(value);
}

public bool canTransition
{
get => GetField<bool>();
set => SetField(value);
}

public HealthManager[] bosses
{
get => orig.bosses;
set => orig.bosses = value;
}

public int bossesLeft
{
get => GetField<int>();
set => SetField(value);
}

public float bossesDeadWaitTime
{
get => orig.bossesDeadWaitTime;
set => orig.bossesDeadWaitTime = value;
}

public int bossLevel
{
get => GetField<int>();
set => SetField(value);
}

public bool endedScene
{
get => GetField<bool>();
set => SetField(value);
}

public bool knightDamagedSubscribed
{
get => GetField<bool>();
set => SetField(value);
}

public bool restoreBindingsOnDestroy
{
get => GetField<bool>();
set => SetField(value);
}

public TransitionPoint customExitPoint
{
get => orig.customExitPoint;
set => orig.customExitPoint = value;
}

public bool doTransition
{
get => GetField<bool>();
set => SetField(value);
}

public bool IsBossScene
{
get => BossSceneController.IsBossScene;
}

public bool HasTransitionedIn
{
get => orig.HasTransitionedIn;
set => SetProperty(value);
}

public bool IsTransitioning
{
get => BossSceneController.IsTransitioning;
}

public bool CanTransition
{
get => orig.CanTransition;
set => orig.CanTransition = value;
}

public int BossLevel
{
get => orig.BossLevel;
set => orig.BossLevel = value;
}

public string DreamReturnEvent
{
get => orig.DreamReturnEvent;
set => orig.DreamReturnEvent = value;
}

public System.Collections.Generic.Dictionary<HealthManager,BossSceneController.BossHealthDetails> BossHealthLookup
{
get => orig.BossHealthLookup;
set => SetProperty(value);
}



public void Awake () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public System.Collections.IEnumerator Start () =>
CallMethod<System.Collections.IEnumerator>();

public void Update () =>
CallMethod();

public void Setup () =>
CallMethod();

public void SetKnightDamaged () =>
CallMethod();

public void CheckBossesDead () =>
CallMethod();

public void EndBossScene () =>
orig.EndBossScene();

public System.Collections.IEnumerator EndSceneDelayed () =>
CallMethod<System.Collections.IEnumerator>();

public void DoDreamReturn () =>
orig.DoDreamReturn();

public void ApplyBindings () =>
orig.ApplyBindings();

public void RestoreBindings () =>
orig.RestoreBindings();

public void ReportHealth (HealthManager healthManager, int baseHP, int adjustedHP, bool forceAdd = false) =>
BossSceneController.ReportHealth(healthManager, baseHP, adjustedHP, forceAdd);

}
}
