namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BetaEndPrompt allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BetaEndPromptR:InstanceClassWrapper<BetaEndPrompt>
{
public BetaEndPromptR(BetaEndPrompt _orig) : base(_orig) {}
public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public float delayDuration
{
get => GetField<float>();
set => SetField(value);
}

public SimpleSpriteFade blackFade
{
get => GetField<SimpleSpriteFade>();
set => SetField(value);
}

public bool canEnd
{
get => GetField<bool>();
set => SetField(value);
}



public void Awake () =>
CallMethod();

public System.Collections.IEnumerator Start () =>
CallMethod<System.Collections.IEnumerator>();

public void Update () =>
CallMethod();

public System.Collections.IEnumerator BeginEnd () =>
CallMethod<System.Collections.IEnumerator>();

}
}
