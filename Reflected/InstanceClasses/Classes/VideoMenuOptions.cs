namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of VideoMenuOptions allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class VideoMenuOptionsR:InstanceClassWrapper<VideoMenuOptions>
{
public VideoMenuOptionsR(VideoMenuOptions _orig) : base(_orig) {}
public MenuScreen videoMenuScreen
{
get => orig.videoMenuScreen;
set => orig.videoMenuScreen = value;
}

public UnityEngine.UI.MenuSelectable vsyncOption
{
get => orig.vsyncOption;
set => orig.vsyncOption = value;
}

public UnityEngine.UI.MenuSelectable frameCapOption
{
get => orig.frameCapOption;
set => orig.frameCapOption = value;
}

public UnityEngine.UI.MenuSelectable screenScaleOption
{
get => orig.screenScaleOption;
set => orig.screenScaleOption = value;
}

public UnityEngine.UI.MenuSelectable resetButton
{
get => orig.resetButton;
set => orig.resetButton = value;
}

public UnityEngine.UI.MenuSelectable applyButton
{
get => orig.applyButton;
set => orig.applyButton = value;
}



public void ConfigureNavigation () =>
orig.ConfigureNavigation();

}
}
