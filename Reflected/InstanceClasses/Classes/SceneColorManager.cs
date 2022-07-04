namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SceneColorManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SceneColorManagerR:InstanceClassWrapper<SceneColorManager>
{
public SceneColorManagerR(SceneColorManager _orig) : base(_orig) {}
public float Factor
{
get => orig.Factor;
set => orig.Factor = value;
}

public float SaturationA
{
get => orig.SaturationA;
set => orig.SaturationA = value;
}

public UnityEngine.AnimationCurve RedA
{
get => orig.RedA;
set => orig.RedA = value;
}

public UnityEngine.AnimationCurve GreenA
{
get => orig.GreenA;
set => orig.GreenA = value;
}

public UnityEngine.AnimationCurve BlueA
{
get => orig.BlueA;
set => orig.BlueA = value;
}

public UnityEngine.Color AmbientColorA
{
get => orig.AmbientColorA;
set => orig.AmbientColorA = value;
}

public float AmbientIntensityA
{
get => orig.AmbientIntensityA;
set => orig.AmbientIntensityA = value;
}

public UnityEngine.Color HeroLightColorA
{
get => orig.HeroLightColorA;
set => orig.HeroLightColorA = value;
}

public float SaturationB
{
get => orig.SaturationB;
set => orig.SaturationB = value;
}

public UnityEngine.AnimationCurve RedB
{
get => orig.RedB;
set => orig.RedB = value;
}

public UnityEngine.AnimationCurve GreenB
{
get => orig.GreenB;
set => orig.GreenB = value;
}

public UnityEngine.AnimationCurve BlueB
{
get => orig.BlueB;
set => orig.BlueB = value;
}

public UnityEngine.Color AmbientColorB
{
get => orig.AmbientColorB;
set => orig.AmbientColorB = value;
}

public float AmbientIntensityB
{
get => orig.AmbientIntensityB;
set => orig.AmbientIntensityB = value;
}

public UnityEngine.Color HeroLightColorB
{
get => orig.HeroLightColorB;
set => orig.HeroLightColorB = value;
}

public System.Collections.Generic.List<UnityEngine.Keyframe[]> RedPairedKeyframes
{
get => GetField<System.Collections.Generic.List<UnityEngine.Keyframe[]>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Keyframe[]> GreenPairedKeyframes
{
get => GetField<System.Collections.Generic.List<UnityEngine.Keyframe[]>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Keyframe[]> BluePairedKeyframes
{
get => GetField<System.Collections.Generic.List<UnityEngine.Keyframe[]>>();
set => SetField(value);
}



public float PAIRING_DISTANCE
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float TANGENT_DISTANCE
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public float UPDATE_RATE
{
get => GetFieldStatic<float>();
set => SetField(value);
}

public bool gameplayScene
{
get => GetField<bool>();
set => SetField(value);
}

public HeroController hero
{
get => GetField<HeroController>();
set => SetField(value);
}

public GameManager gm
{
get => GetField<GameManager>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Keyframe> tempA
{
get => GetFieldStatic<System.Collections.Generic.List<UnityEngine.Keyframe>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Keyframe> tempB
{
get => GetFieldStatic<System.Collections.Generic.List<UnityEngine.Keyframe>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Keyframe> finalFramesList
{
get => GetFieldStatic<System.Collections.Generic.List<UnityEngine.Keyframe>>();
set => SetField(value);
}

public System.Collections.Generic.List<UnityEngine.Keyframe[]> simplePairList
{
get => GetFieldStatic<System.Collections.Generic.List<UnityEngine.Keyframe[]>>();
set => SetField(value);
}

public bool ChangesInEditor
{
get => GetField<bool>();
set => SetField(value);
}

public float LastFactor
{
get => GetField<float>();
set => SetField(value);
}

public float LastSaturationA
{
get => GetField<float>();
set => SetField(value);
}

public float LastSaturationB
{
get => GetField<float>();
set => SetField(value);
}

public float LastAmbientIntensityA
{
get => GetField<float>();
set => SetField(value);
}

public float LastAmbientIntensityB
{
get => GetField<float>();
set => SetField(value);
}

public float startBufferDuration
{
get => GetField<float>();
set => SetField(value);
}

public bool markerActive
{
get => orig.markerActive;
set => SetProperty(value);
}

public bool startBufferActive
{
get => orig.startBufferActive;
set => SetProperty(value);
}



public void SetFactor (float factor) =>
orig.SetFactor(factor);

public void SetSaturationA (float saturationA) =>
orig.SetSaturationA(saturationA);

public void SetSaturationB (float saturationB) =>
orig.SetSaturationB(saturationB);

public void GameInit () =>
orig.GameInit();

public void SceneInit () =>
orig.SceneInit();

public void Update () =>
CallMethod();

public void OnLevelUnload () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public System.Collections.IEnumerator ForceRefresh () =>
orig.ForceRefresh();

public void FinishBufferPeriod () =>
CallMethod();

public void MarkerActive (bool active) =>
orig.MarkerActive(active);

public void UpdateScript (bool forceUpdate = false) =>
orig.UpdateScript(forceUpdate);

public void EditorHasChanged () =>
CallMethod();

public System.Collections.Generic.List<UnityEngine.Keyframe[]> PairKeyframes (UnityEngine.AnimationCurve curveA, UnityEngine.AnimationCurve curveB) =>
SceneColorManager.PairKeyframes(curveA, curveB);

public System.Collections.Generic.List<UnityEngine.Keyframe[]> SimplePairKeyframes (UnityEngine.AnimationCurve curveA, UnityEngine.AnimationCurve curveB) =>
CallMethodStatic<System.Collections.Generic.List<UnityEngine.Keyframe[]>>(new object[] {curveA, curveB});

public UnityEngine.Keyframe CreatePair (UnityEngine.Keyframe kf, UnityEngine.AnimationCurve curve) =>
CallMethodStatic<UnityEngine.Keyframe>(new object[] {kf, curve});

public UnityEngine.AnimationCurve CreateCurveFromKeyframes (System.Collections.Generic.IList<UnityEngine.Keyframe[]> keyframePairs, float factor) =>
SceneColorManager.CreateCurveFromKeyframes(keyframePairs, factor);

public UnityEngine.Keyframe AverageKeyframe (UnityEngine.Keyframe a, UnityEngine.Keyframe b, float factor) =>
SceneColorManager.AverageKeyframe(a, b, factor);

public void PairCurvesKeyframes () =>
CallMethod();

public void UpdateScriptParameters () =>
CallMethod();

public bool PairedListsInitiated () =>
CallMethod<bool>();

public void UpdateSceneType () =>
CallMethod();

}
}
