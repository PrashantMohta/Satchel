namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuButtonIcon allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuButtonIconR:InstanceClassWrapper<MenuButtonIcon>
{
public MenuButtonIconR(MenuButtonIcon _orig) : base(_orig) {}
public bool liveUpdate
{
get => orig.liveUpdate;
set => orig.liveUpdate = value;
}

public TMPro.TextMeshPro label
{
get => orig.label;
set => orig.label = value;
}

public TMPro.TextContainer textContainer
{
get => orig.textContainer;
set => orig.textContainer = value;
}

public UnityEngine.SpriteRenderer sr
{
get => GetField<UnityEngine.SpriteRenderer>();
set => SetField(value);
}

public GlobalEnums.HeroActionButton Action
{
get => orig.Action;
}



}
}
