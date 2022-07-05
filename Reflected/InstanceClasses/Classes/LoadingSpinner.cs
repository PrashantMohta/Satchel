using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of LoadingSpinner allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class LoadingSpinnerR : InstanceClassWrapper<LoadingSpinner>
{
    public LoadingSpinnerR(LoadingSpinner _orig) : base(_orig)
    {
    }

    public Image image
    {
        get => GetField<Image>();
        set => SetField(value);
    }

    public float displayDelay
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float fadeDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float fadeAmount
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float fadeVariance
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float fadePulseDuration
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public Sprite[] sprites
    {
        get => GetField<Sprite[]>();
        set => SetField(value);
    }

    public float frameRate
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float fadeFactor
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float frameTimer
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public int frameIndex
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public float displayDelayAdjustment
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float DisplayDelayAdjustment
    {
        get => orig.DisplayDelayAdjustment;
        set => orig.DisplayDelayAdjustment = value;
    }

    public float DisplayDelay => orig.DisplayDelay;


    public void OnEnable()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public void Update()
    {
        CallMethod();
    }
}