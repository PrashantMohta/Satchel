namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ActivatePerLanguage allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ActivatePerLanguageR:InstanceClassWrapper<ActivatePerLanguage>
{
public ActivatePerLanguageR(ActivatePerLanguage _orig) : base(_orig) {}
public UnityEngine.GameObject target
{
get => orig.target;
set => orig.target = value;
}

public UnityEngine.GameObject alt
{
get => orig.alt;
set => orig.alt = value;
}

public ActivatePerLanguage.LangBoolPair[] languages
{
get => orig.languages;
set => orig.languages = value;
}

public bool defaultActivation
{
get => orig.defaultActivation;
set => orig.defaultActivation = value;
}



public void Start () =>
CallMethod();

}
}
