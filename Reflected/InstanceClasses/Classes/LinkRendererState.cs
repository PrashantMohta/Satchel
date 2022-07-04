namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of LinkRendererState allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LinkRendererStateR : InstanceClassWrapper<LinkRendererState>
{
    public LinkRendererStateR(LinkRendererState _orig) : base(_orig)
    {
    }

    public Renderer parent
    {
        get => orig.parent;
        set => orig.parent = value;
    }

    public Renderer child
    {
        get => orig.child;
        set => orig.child = value;
    }


    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }

    public void UpdateLink()
    {
        CallMethod();
    }
}