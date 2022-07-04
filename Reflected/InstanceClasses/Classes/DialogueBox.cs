using TMPro;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of DialogueBox allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class DialogueBoxR : InstanceClassWrapper<DialogueBox>
{
    public DialogueBoxR(DialogueBox _orig) : base(_orig)
    {
    }

    public string currentConversation
    {
        get => orig.currentConversation;
        set => orig.currentConversation = value;
    }

    public int currentPage
    {
        get => orig.currentPage;
        set => orig.currentPage = value;
    }

    public bool useTypeWriter
    {
        get => orig.useTypeWriter;
        set => orig.useTypeWriter = value;
    }

    public float revealSpeed
    {
        get => orig.revealSpeed;
        set => orig.revealSpeed = value;
    }

    public float normalRevealSpeed
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public TextMeshPro textMesh
    {
        get => GetField<TextMeshPro>();
        set => SetField(value);
    }

    public PlayMakerFSM proxyFSM
    {
        get => GetField<PlayMakerFSM>();
        set => SetField(value);
    }

    public bool typing
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool fastTyping
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool hidden
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public TMP_PageInfo[] pageInfo
    {
        get => GetField<TMP_PageInfo[]>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void SetConversation(string convName, string sheetName)
    {
        orig.SetConversation(convName, sheetName);
    }

    public void ShowPage(int pageNum)
    {
        orig.ShowPage(pageNum);
    }

    public void ShowNextPage()
    {
        orig.ShowNextPage();
    }

    public void ShowPrevPage()
    {
        orig.ShowPrevPage();
    }

    public void HideText()
    {
        orig.HideText();
    }

    public void StartConversation(string convName, string sheetName)
    {
        orig.StartConversation(convName, sheetName);
    }

    public IEnumerator TypewriteCurrentPage()
    {
        return CallMethod<IEnumerator>();
    }

    public void ShowNextChar()
    {
        CallMethod();
    }

    public void StopTypewriter()
    {
        CallMethod();
    }

    public void SpeedupTypewriter()
    {
        orig.SpeedupTypewriter();
    }

    public void RestoreTypewriter()
    {
        CallMethod();
    }

    public void SendEndEvent()
    {
        CallMethod();
    }

    public void SendPageEndEvent()
    {
        CallMethod();
    }

    public void SendConvEndEvent()
    {
        CallMethod();
    }

    public int GetFirstCharIndexOnPage()
    {
        return CallMethod<int>();
    }

    public int GetLastCharIndexOnPage()
    {
        return CallMethod<int>();
    }

    public void PrintPageInfo()
    {
        orig.PrintPageInfo();
    }

    public void PrintPageInfoAll()
    {
        orig.PrintPageInfoAll();
    }

    public void PrintCurrentConversation()
    {
        orig.PrintCurrentConversation();
    }
}