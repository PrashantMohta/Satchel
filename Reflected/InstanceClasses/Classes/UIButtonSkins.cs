using InControl;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of UIButtonSkins allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UIButtonSkinsR : InstanceClassWrapper<UIButtonSkins>
{
    public UIButtonSkinsR(UIButtonSkins _orig) : base(_orig)
    {
    }

    public Sprite blankKey
    {
        get => orig.blankKey;
        set => orig.blankKey = value;
    }

    public Sprite squareKey
    {
        get => orig.squareKey;
        set => orig.squareKey = value;
    }

    public Sprite rectangleKey
    {
        get => orig.rectangleKey;
        set => orig.rectangleKey = value;
    }

    public Sprite upArrowKey
    {
        get => orig.upArrowKey;
        set => orig.upArrowKey = value;
    }

    public Sprite downArrowKey
    {
        get => orig.downArrowKey;
        set => orig.downArrowKey = value;
    }

    public Sprite leftArrowKey
    {
        get => orig.leftArrowKey;
        set => orig.leftArrowKey = value;
    }

    public Sprite rightArrowKey
    {
        get => orig.rightArrowKey;
        set => orig.rightArrowKey = value;
    }

    public Sprite leftMouseButton
    {
        get => orig.leftMouseButton;
        set => orig.leftMouseButton = value;
    }

    public Sprite rightMouseButton
    {
        get => orig.rightMouseButton;
        set => orig.rightMouseButton = value;
    }

    public Sprite middleMouseButton
    {
        get => orig.middleMouseButton;
        set => orig.middleMouseButton = value;
    }

    public int labelFontSize
    {
        get => orig.labelFontSize;
        set => orig.labelFontSize = value;
    }

    public TextAnchor labelAlignment
    {
        get => orig.labelAlignment;
        set => orig.labelAlignment = value;
    }

    public int buttonFontSize
    {
        get => orig.buttonFontSize;
        set => orig.buttonFontSize = value;
    }

    public TextAnchor buttonAlignment
    {
        get => orig.buttonAlignment;
        set => orig.buttonAlignment = value;
    }

    public int wideButtonFontSize
    {
        get => orig.wideButtonFontSize;
        set => orig.wideButtonFontSize = value;
    }

    public TextAnchor wideButtonAlignment
    {
        get => orig.wideButtonAlignment;
        set => orig.wideButtonAlignment = value;
    }

    public Sprite a
    {
        get => orig.a;
        set => orig.a = value;
    }

    public Sprite b
    {
        get => orig.b;
        set => orig.b = value;
    }

    public Sprite x
    {
        get => orig.x;
        set => orig.x = value;
    }

    public Sprite y
    {
        get => orig.y;
        set => orig.y = value;
    }

    public Sprite lb
    {
        get => orig.lb;
        set => orig.lb = value;
    }

    public Sprite lt
    {
        get => orig.lt;
        set => orig.lt = value;
    }

    public Sprite rb
    {
        get => orig.rb;
        set => orig.rb = value;
    }

    public Sprite rt
    {
        get => orig.rt;
        set => orig.rt = value;
    }

    public Sprite start
    {
        get => orig.start;
        set => orig.start = value;
    }

    public Sprite select
    {
        get => orig.select;
        set => orig.select = value;
    }

    public Sprite dpadLeft
    {
        get => orig.dpadLeft;
        set => orig.dpadLeft = value;
    }

    public Sprite dpadRight
    {
        get => orig.dpadRight;
        set => orig.dpadRight = value;
    }

    public Sprite dpadUp
    {
        get => orig.dpadUp;
        set => orig.dpadUp = value;
    }

    public Sprite dpadDown
    {
        get => orig.dpadDown;
        set => orig.dpadDown = value;
    }

    public Sprite view
    {
        get => orig.view;
        set => orig.view = value;
    }

    public Sprite menu
    {
        get => orig.menu;
        set => orig.menu = value;
    }

    public Sprite options
    {
        get => orig.options;
        set => orig.options = value;
    }

    public Sprite share
    {
        get => orig.share;
        set => orig.share = value;
    }

    public Sprite touchpadButton
    {
        get => orig.touchpadButton;
        set => orig.touchpadButton = value;
    }

    public Sprite ps4x
    {
        get => orig.ps4x;
        set => orig.ps4x = value;
    }

    public Sprite ps4square
    {
        get => orig.ps4square;
        set => orig.ps4square = value;
    }

    public Sprite ps4triangle
    {
        get => orig.ps4triangle;
        set => orig.ps4triangle = value;
    }

    public Sprite ps4circle
    {
        get => orig.ps4circle;
        set => orig.ps4circle = value;
    }

    public Sprite ps4lb
    {
        get => orig.ps4lb;
        set => orig.ps4lb = value;
    }

    public Sprite ps4lt
    {
        get => orig.ps4lt;
        set => orig.ps4lt = value;
    }

    public Sprite ps4rb
    {
        get => orig.ps4rb;
        set => orig.ps4rb = value;
    }

    public Sprite ps4rt
    {
        get => orig.ps4rt;
        set => orig.ps4rt = value;
    }

    public Sprite switchHidB
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite switchHidA
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite switchHidY
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite switchHidX
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite switchHidLeftBumper
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite switchHidLeftTrigger
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite switchHidRightBumper
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite switchHidRightTrigger
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite switchHidMinus
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite switchHidPlus
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite switchHidDPadUp
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite switchHidDPadDown
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite switchHidDPadLeft
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite switchHidDPadRight
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public bool active
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public GameManager gm
    {
        get => GetField<GameManager>();
        set => SetField(value);
    }

    public InputHandler ih
    {
        get => GetField<InputHandler>();
        set => SetField(value);
    }

    public RectTransform mappableKeyboardButtons
    {
        get => orig.mappableKeyboardButtons;
        set => orig.mappableKeyboardButtons = value;
    }

    public RectTransform mappableControllerButtons
    {
        get => orig.mappableControllerButtons;
        set => orig.mappableControllerButtons = value;
    }

    public List<MappableKey> customKeys
    {
        get => GetField<List<MappableKey>>();
        set => SetField(value);
    }

    public List<MappableControllerButton> customButtons
    {
        get => GetField<List<MappableControllerButton>>();
        set => SetField(value);
    }

    public MappableKey listeningKey
    {
        get => orig.listeningKey;
        set => SetProperty(value);
    }

    public MappableControllerButton listeningButton
    {
        get => orig.listeningButton;
        set => SetProperty(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public ButtonSkin GetButtonSkinFor(PlayerAction action)
    {
        return orig.GetButtonSkinFor(action);
    }

    public ButtonSkin GetKeyboardSkinFor(PlayerAction action)
    {
        return orig.GetKeyboardSkinFor(action);
    }

    public ButtonSkin GetControllerButtonSkinFor(PlayerAction action)
    {
        return orig.GetControllerButtonSkinFor(action);
    }

    public ButtonSkin GetButtonSkinFor(HeroActionButton actionButton)
    {
        return orig.GetButtonSkinFor(actionButton);
    }

    public IEnumerator ShowCurrentKeyboardMappings()
    {
        return orig.ShowCurrentKeyboardMappings();
    }

    public IEnumerator ShowCurrentButtonMappings()
    {
        return orig.ShowCurrentButtonMappings();
    }

    public void RefreshKeyMappings()
    {
        orig.RefreshKeyMappings();
    }

    public void RefreshButtonMappings()
    {
        orig.RefreshButtonMappings();
    }

    public void ListeningForKeyRebind(MappableKey mappableKey)
    {
        orig.ListeningForKeyRebind(mappableKey);
    }

    public void ListeningForButtonRebind(MappableControllerButton mappableButton)
    {
        orig.ListeningForButtonRebind(mappableButton);
    }

    public void FinishedListeningForKey()
    {
        orig.FinishedListeningForKey();
    }

    public void FinishedListeningForButton()
    {
        orig.FinishedListeningForButton();
    }

    public ButtonSkin GetButtonSkinFor(InputControlType inputControlType)
    {
        return CallMethod<ButtonSkin>(new object[] { inputControlType });
    }

    public ButtonSkin GetButtonSkinFor(string buttonName)
    {
        return CallMethod<ButtonSkin>(new object[] { buttonName });
    }

    public void SetupRefs()
    {
        CallMethod();
    }

    public void AddMappableKey(MappableKey b)
    {
        orig.AddMappableKey(b);
    }

    public void RemoveMappableKey(MappableKey b)
    {
        orig.RemoveMappableKey(b);
    }

    public void AddMappableControllerButton(MappableControllerButton b)
    {
        orig.AddMappableControllerButton(b);
    }

    public void RemoveMappableControllerButton(MappableControllerButton b)
    {
        orig.RemoveMappableControllerButton(b);
    }

    public void orig_RefreshKeyMappings()
    {
        orig.orig_RefreshKeyMappings();
    }

    public IEnumerator orig_ShowCurrentKeyboardMappings()
    {
        return orig.orig_ShowCurrentKeyboardMappings();
    }

    public void orig_RefreshButtonMappings()
    {
        orig.orig_RefreshButtonMappings();
    }

    public IEnumerator orig_ShowCurrentButtonMappings()
    {
        return orig.orig_ShowCurrentButtonMappings();
    }

    public ButtonSkin orig_GetButtonSkinFor(InputControlType inputControlType)
    {
        return CallMethod<ButtonSkin>(new object[] { inputControlType });
    }

    public void orig_SetupRefs()
    {
        CallMethod();
    }
}