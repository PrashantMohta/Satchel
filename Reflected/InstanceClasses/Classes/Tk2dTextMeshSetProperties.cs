namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of Tk2dTextMeshSetProperties allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class Tk2dTextMeshSetPropertiesR : InstanceClassWrapper<Tk2dTextMeshSetProperties>
{
    public Tk2dTextMeshSetPropertiesR(Tk2dTextMeshSetProperties _orig) : base(_orig)
    {
    }

    public FsmOwnerDefault gameObject
    {
        get => orig.gameObject;
        set => orig.gameObject = value;
    }

    public FsmString text
    {
        get => orig.text;
        set => orig.text = value;
    }

    public FsmBool inlineStyling
    {
        get => orig.inlineStyling;
        set => orig.inlineStyling = value;
    }

    public TextAnchor anchor
    {
        get => orig.anchor;
        set => orig.anchor = value;
    }

    public FsmString OrTextAnchorString
    {
        get => orig.OrTextAnchorString;
        set => orig.OrTextAnchorString = value;
    }

    public FsmBool kerning
    {
        get => orig.kerning;
        set => orig.kerning = value;
    }

    public FsmInt maxChars
    {
        get => orig.maxChars;
        set => orig.maxChars = value;
    }

    public FsmInt NumDrawnCharacters
    {
        get => orig.NumDrawnCharacters;
        set => orig.NumDrawnCharacters = value;
    }

    public FsmColor mainColor
    {
        get => orig.mainColor;
        set => orig.mainColor = value;
    }

    public FsmColor gradientColor
    {
        get => orig.gradientColor;
        set => orig.gradientColor = value;
    }

    public FsmBool useGradient
    {
        get => orig.useGradient;
        set => orig.useGradient = value;
    }

    public FsmInt textureGradient
    {
        get => orig.textureGradient;
        set => orig.textureGradient = value;
    }

    public FsmVector3 scale
    {
        get => orig.scale;
        set => orig.scale = value;
    }

    public FsmBool commit
    {
        get => orig.commit;
        set => orig.commit = value;
    }

    public tk2dTextMesh _textMesh
    {
        get => GetField<tk2dTextMesh>();
        set => SetField(value);
    }

    public string Name
    {
        get => orig.Name;
        set => orig.Name = value;
    }

    public string DisplayName
    {
        get => orig.DisplayName;
        set => orig.DisplayName = value;
    }

    public Fsm Fsm
    {
        get => orig.Fsm;
        set => orig.Fsm = value;
    }

    public GameObject Owner
    {
        get => orig.Owner;
        set => orig.Owner = value;
    }

    public FsmState State
    {
        get => orig.State;
        set => orig.State = value;
    }

    public bool Enabled
    {
        get => orig.Enabled;
        set => orig.Enabled = value;
    }

    public bool IsOpen
    {
        get => orig.IsOpen;
        set => orig.IsOpen = value;
    }

    public bool IsAutoNamed
    {
        get => orig.IsAutoNamed;
        set => orig.IsAutoNamed = value;
    }

    public bool Entered
    {
        get => orig.Entered;
        set => orig.Entered = value;
    }

    public bool Finished
    {
        get => orig.Finished;
        set => orig.Finished = value;
    }

    public bool Active
    {
        get => orig.Active;
        set => orig.Active = value;
    }

    public void _getTextMesh()
    {
        CallMethod();
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void OnEnter()
    {
        orig.OnEnter();
    }

    public void DoSetProperties()
    {
        CallMethod();
    }
}