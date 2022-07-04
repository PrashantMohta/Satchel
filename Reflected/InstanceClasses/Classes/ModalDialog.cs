namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ModalDialog allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ModalDialogR:InstanceClassWrapper<ModalDialog>
{
public ModalDialogR(ModalDialog _orig) : base(_orig) {}
public UnityEngine.CanvasGroup content
{
get => orig.content;
set => orig.content = value;
}

public UnityEngine.UI.Selectable defaultHighlight
{
get => orig.defaultHighlight;
set => orig.defaultHighlight = value;
}

public UnityEngine.CanvasGroup modalWindow
{
get => orig.modalWindow;
}



public void HighlightDefault () =>
orig.HighlightDefault();

}
}
