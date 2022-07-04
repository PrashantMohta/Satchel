namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of QuitToMenu allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class QuitToMenuR : InstanceClassWrapper<QuitToMenu>
{
    public QuitToMenuR(QuitToMenu _orig) : base(_orig)
    {
    }


    public IEnumerator Start()
    {
        return CallMethod<IEnumerator>();
    }
}