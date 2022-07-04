using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of GameCameraTextureDisplay allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class GameCameraTextureDisplayR : InstanceClassWrapper<GameCameraTextureDisplay>
{
    public GameCameraTextureDisplayR(GameCameraTextureDisplay _orig) : base(_orig)
    {
    }

    public GameCameraTextureDisplay Instance
    {
        get => GameCameraTextureDisplay.Instance;
        set => GameCameraTextureDisplay.Instance = value;
    }

    public RenderTexture texture
    {
        get => GetField<RenderTexture>();
        set => SetField(value);
    }

    public RawImage image
    {
        get => orig.image;
        set => orig.image = value;
    }

    public Image altImage
    {
        get => orig.altImage;
        set => orig.altImage = value;
    }


    public void Awake()
    {
        CallMethod();
    }

    public void LateUpdate()
    {
        CallMethod();
    }

    public void UpdateDisplay(RenderTexture source, Material material)
    {
        orig.UpdateDisplay(source, material);
    }
}