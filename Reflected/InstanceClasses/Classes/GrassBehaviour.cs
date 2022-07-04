namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GrassBehaviour allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GrassBehaviourR:InstanceClassWrapper<GrassBehaviour>
{
public GrassBehaviourR(GrassBehaviour _orig) : base(_orig) {}
public float walkReactAmount
{
get => orig.walkReactAmount;
set => orig.walkReactAmount = value;
}

public UnityEngine.AnimationCurve walkReactCurve
{
get => orig.walkReactCurve;
set => orig.walkReactCurve = value;
}

public float walkReactLength
{
get => orig.walkReactLength;
set => orig.walkReactLength = value;
}

public float attackReactAmount
{
get => orig.attackReactAmount;
set => orig.attackReactAmount = value;
}

public UnityEngine.AnimationCurve attackReactCurve
{
get => orig.attackReactCurve;
set => orig.attackReactCurve = value;
}

public float attackReactLength
{
get => orig.attackReactLength;
set => orig.attackReactLength = value;
}

public string pushAnim
{
get => orig.pushAnim;
set => orig.pushAnim = value;
}

public UnityEngine.Animator animator
{
get => GetField<UnityEngine.Animator>();
set => SetField(value);
}

public UnityEngine.AudioClip[] pushSounds
{
get => orig.pushSounds;
set => orig.pushSounds = value;
}

public UnityEngine.AudioClip[] cutPushSounds
{
get => orig.cutPushSounds;
set => orig.cutPushSounds = value;
}

public UnityEngine.AudioClip[] cutSounds
{
get => orig.cutSounds;
set => orig.cutSounds = value;
}

public UnityEngine.AudioSource source
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.Color infectedColor
{
get => orig.infectedColor;
set => orig.infectedColor = value;
}

public bool neverInfected
{
get => orig.neverInfected;
set => orig.neverInfected = value;
}

public bool colorSet
{
get => GetFieldStatic<bool>();
set => SetField(value);
}

public UnityEngine.AnimationCurve curve
{
get => GetField<UnityEngine.AnimationCurve>();
set => SetField(value);
}

public float animLength
{
get => GetField<float>();
set => SetField(value);
}

public float animElapsed
{
get => GetField<float>();
set => SetField(value);
}

public float pushAmount
{
get => GetField<float>();
set => SetField(value);
}

public float pushDirection
{
get => GetField<float>();
set => SetField(value);
}

public bool returned
{
get => GetField<bool>();
set => SetField(value);
}

public bool cutFirstFrame
{
get => GetField<bool>();
set => SetField(value);
}

public bool isCut
{
get => GetField<bool>();
set => SetField(value);
}

public float pushAmountError
{
get => GetField<float>();
set => SetField(value);
}

public UnityEngine.Rigidbody2D player
{
get => GetField<UnityEngine.Rigidbody2D>();
set => SetField(value);
}

public UnityEngine.Vector3 oldPlayerPos
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.SpriteRenderer[] renderers
{
get => GetField<UnityEngine.SpriteRenderer[]>();
set => SetField(value);
}

public System.Collections.Generic.Dictionary<System.String,UnityEngine.Material> sharedMaterials
{
get => GetFieldStatic<System.Collections.Generic.Dictionary<System.String,UnityEngine.Material>>();
set => SetField(value);
}

public int grassCount
{
get => GetFieldStatic<int>();
set => SetField(value);
}

public UnityEngine.Material sharedMaterial
{
get => GetField<UnityEngine.Material>();
set => SetField(value);
}

public UnityEngine.MaterialPropertyBlock propertyBlock
{
get => GetField<UnityEngine.MaterialPropertyBlock>();
set => SetField(value);
}

public UnityEngine.Material SharedMaterial
{
get => orig.SharedMaterial;
}



public void Awake () =>
CallMethod();

public void Start () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public System.Collections.IEnumerator DelayedInfectedCheck () =>
CallMethod<System.Collections.IEnumerator>();

public void LateUpdate () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

public void OnTriggerEnter2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void OnTriggerExit2D (UnityEngine.Collider2D collision) =>
CallMethod(new object[] {collision});

public void CutReact (UnityEngine.Collider2D collision) =>
orig.CutReact(collision);

public void WindReact (UnityEngine.Collider2D collision) =>
orig.WindReact(collision);

public void PlayRandomSound (UnityEngine.AudioClip[] clips) =>
CallMethod(new object[] {clips});

public void SetPushAmount (UnityEngine.Renderer rend, float value) =>
CallMethod(new object[] {rend, value});

}
}
