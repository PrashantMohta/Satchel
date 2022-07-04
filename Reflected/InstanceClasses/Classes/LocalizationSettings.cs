namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of LocalizationSettings allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LocalizationSettingsR:InstanceClassWrapper<LocalizationSettings>
{
public LocalizationSettingsR(LocalizationSettings _orig) : base(_orig) {}
public System.String[] sheetTitles
{
get => orig.sheetTitles;
set => orig.sheetTitles = value;
}

public bool useSystemLanguagePerDefault
{
get => orig.useSystemLanguagePerDefault;
set => orig.useSystemLanguagePerDefault = value;
}

public string defaultLangCode
{
get => orig.defaultLangCode;
set => orig.defaultLangCode = value;
}

public string gDocsURL
{
get => orig.gDocsURL;
set => orig.gDocsURL = value;
}

public string name
{
get => orig.name;
set => orig.name = value;
}

public UnityEngine.HideFlags hideFlags
{
get => orig.hideFlags;
set => orig.hideFlags = value;
}

public Language.LanguageCode GetLanguageEnum (string langCode) =>
LocalizationSettings.GetLanguageEnum(langCode);

}
}
