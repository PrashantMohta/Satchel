namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of SpriteFlash allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class SpriteFlashR:InstanceClassWrapper<SpriteFlash>
{
public SpriteFlashR(SpriteFlash _orig) : base(_orig) {}
public UnityEngine.Renderer rend
{
get => GetField<UnityEngine.Renderer>();
set => SetField(value);
}

public UnityEngine.Color flashColour
{
get => GetField<UnityEngine.Color>();
set => SetField(value);
}

public float amount
{
get => GetField<float>();
set => SetField(value);
}

public float timeUp
{
get => GetField<float>();
set => SetField(value);
}

public float stayTime
{
get => GetField<float>();
set => SetField(value);
}

public float timeDown
{
get => GetField<float>();
set => SetField(value);
}

public int flashingState
{
get => GetField<int>();
set => SetField(value);
}

public float flashTimer
{
get => GetField<float>();
set => SetField(value);
}

public float amountCurrent
{
get => GetField<float>();
set => SetField(value);
}

public float t
{
get => GetField<float>();
set => SetField(value);
}

public bool repeatFlash
{
get => GetField<bool>();
set => SetField(value);
}

public bool cancelFlash
{
get => GetField<bool>();
set => SetField(value);
}

public float geoTimer
{
get => GetField<float>();
set => SetField(value);
}

public bool geoFlash
{
get => GetField<bool>();
set => SetField(value);
}

public UnityEngine.MaterialPropertyBlock block
{
get => GetField<UnityEngine.MaterialPropertyBlock>();
set => SetField(value);
}

public bool sendToChildren
{
get => GetField<bool>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void Update () =>
CallMethod();

public void GeoFlash () =>
orig.GeoFlash();

public void flash (UnityEngine.Color flashColour_var, float amount_var, float timeUp_var, float stayTime_var, float timeDown_var) =>
orig.flash(flashColour_var, amount_var, timeUp_var, stayTime_var, timeDown_var);

public void CancelFlash () =>
orig.CancelFlash();

public void FlashingSuperDash () =>
orig.FlashingSuperDash();

public void FlashingGhostWounded () =>
orig.FlashingGhostWounded();

public void FlashingWhiteStay () =>
orig.FlashingWhiteStay();

public void FlashingWhiteStayMoth () =>
orig.FlashingWhiteStayMoth();

public void FlashingFury () =>
orig.FlashingFury();

public void FlashingOrange () =>
orig.FlashingOrange();

public void flashInfected () =>
orig.flashInfected();

public void flashDung () =>
orig.flashDung();

public void flashDungQuick () =>
orig.flashDungQuick();

public void flashSporeQuick () =>
orig.flashSporeQuick();

public void flashWhiteQuick () =>
orig.flashWhiteQuick();

public void flashInfectedLong () =>
orig.flashInfectedLong();

public void flashArmoured () =>
orig.flashArmoured();

public void flashBenchRest () =>
orig.flashBenchRest();

public void flashDreamImpact () =>
orig.flashDreamImpact();

public void flashMothDepart () =>
orig.flashMothDepart();

public void flashSoulGet () =>
orig.flashSoulGet();

public void flashShadeGet () =>
orig.flashShadeGet();

public void flashWhiteLong () =>
orig.flashWhiteLong();

public void flashOvercharmed () =>
orig.flashOvercharmed();

public void flashFocusHeal () =>
orig.flashFocusHeal();

public void flashFocusGet () =>
orig.flashFocusGet();

public void flashWhitePulse () =>
orig.flashWhitePulse();

public void flashHealBlue () =>
orig.flashHealBlue();

public void FlashShadowRecharge () =>
orig.FlashShadowRecharge();

public void flashInfectedLoop () =>
orig.flashInfectedLoop();

public void FlashGrimmflame () =>
orig.FlashGrimmflame();

public void FlashGrimmHit () =>
orig.FlashGrimmHit();

public void SendToChildren (System.Action function) =>
CallMethod(new object[] {function});

}
}
