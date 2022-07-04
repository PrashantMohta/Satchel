namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of MenuAchievement allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class MenuAchievementR:InstanceClassWrapper<MenuAchievement>
{
public MenuAchievementR(MenuAchievement _orig) : base(_orig) {}
public UnityEngine.UI.Image icon
{
get => orig.icon;
set => orig.icon = value;
}

public UnityEngine.UI.Text title
{
get => orig.title;
set => orig.title = value;
}

public UnityEngine.UI.Text text
{
get => orig.text;
set => orig.text = value;
}



}
}
