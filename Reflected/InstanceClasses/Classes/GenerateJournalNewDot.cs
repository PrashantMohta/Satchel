namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of GenerateJournalNewDot allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GenerateJournalNewDotR:InstanceClassWrapper<GenerateJournalNewDot>
{
public GenerateJournalNewDotR(GenerateJournalNewDot _orig) : base(_orig) {}
public UnityEngine.GameObject newDotObject
{
get => orig.newDotObject;
set => orig.newDotObject = value;
}



public void Start () =>
CallMethod();

}
}
