using Microsoft.Xbox;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of XboxSdk allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class XboxSdkR : InstanceClassWrapper<XboxSdk>
{
    public XboxSdkR(XboxSdk _orig) : base(_orig)
    {
    }

    public string scid
    {
        get => orig.scid;
        set => orig.scid = value;
    }

    public Text gamertagLabel
    {
        get => orig.gamertagLabel;
        set => orig.gamertagLabel = value;
    }

    public bool signInOnStart
    {
        get => orig.signInOnStart;
        set => orig.signInOnStart = value;
    }

    public XboxSdk _xboxHelpers
    {
        get => GetFieldStatic<XboxSdk>();
        set => SetField(value);
    }

    public bool _initialized
    {
        get => GetFieldStatic<bool>();
        set => SetField(value);
    }

    public string _GAME_SAVE_CONTAINER_NAME
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public string _GAME_SAVE_BLOB_NAME
    {
        get => GetFieldStatic<string>();
        set => SetField(value);
    }

    public XboxSdk Helpers => XboxSdk.Helpers;


    public void Start()
    {
        CallMethod();
    }

    public void _Initialize()
    {
        CallMethod();
    }

    public void SignIn()
    {
        orig.SignIn();
    }

    public void Save(byte[] data)
    {
        orig.Save(data);
    }

    public void LoadSaveData()
    {
        orig.LoadSaveData();
    }

    public void UnlockAchievement(string achievementId)
    {
        orig.UnlockAchievement(achievementId);
    }

    public void SignInImpl()
    {
        CallMethod();
    }


    public void CompletePostSignInInitialization()
    {
        CallMethod();
    }

    public void InitializeGameSaves()
    {
        CallMethod();
    }

    public void SaveImpl(byte[] data)
    {
        CallMethod(new object[] { data });
    }

    public void GameSaveSubmitUpdateCompleted(int hresult)
    {
        CallMethod(new object[] { hresult });
    }

    public void LoadSaveDataImpl()
    {
        CallMethod();
    }

    public void UnlockAchievementImpl(string achievementId)
    {
        CallMethod(new object[] { achievementId });
    }

    public void UnlockAchievementComplete(int hresult)
    {
        CallMethod(new object[] { hresult });
    }

    public void Update()
    {
        CallMethod();
    }

    public bool Succeeded(int hresult, string operationFriendlyName)
    {
        return CallMethodStatic<bool>(new object[] { hresult, operationFriendlyName });
    }

    public void _LogError(string message)
    {
        CallMethodStatic(new object[] { message });
    }
}