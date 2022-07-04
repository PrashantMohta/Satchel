namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dEditorSpriteDataUnloader allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dEditorSpriteDataUnloaderR : InstanceClassWrapper<tk2dEditorSpriteDataUnloader>
{
    public tk2dEditorSpriteDataUnloaderR(tk2dEditorSpriteDataUnloader _orig) : base(_orig)
    {
    }


    public void Register(tk2dSpriteCollectionData data)
    {
        tk2dEditorSpriteDataUnloader.Register(data);
    }

    public void Unregister(tk2dSpriteCollectionData data)
    {
        tk2dEditorSpriteDataUnloader.Unregister(data);
    }
}