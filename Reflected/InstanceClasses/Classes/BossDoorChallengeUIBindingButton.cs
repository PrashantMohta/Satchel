using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossDoorChallengeUIBindingButton allowing you
///     to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossDoorChallengeUIBindingButtonR : InstanceClassWrapper<BossDoorChallengeUIBindingButton>
{
    public BossDoorChallengeUIBindingButtonR(BossDoorChallengeUIBindingButton _orig) : base(_orig)
    {
    }

    public Image iconImage
    {
        get => orig.iconImage;
        set => orig.iconImage = value;
    }

    public Animator iconAnimator
    {
        get => orig.iconAnimator;
        set => orig.iconAnimator = value;
    }

    public Sprite defaultSprite
    {
        get => GetField<Sprite>();
        set => SetField(value);
    }

    public Sprite selectedSprite
    {
        get => orig.selectedSprite;
        set => orig.selectedSprite = value;
    }

    public Sprite allSelectedSprite
    {
        get => orig.allSelectedSprite;
        set => orig.allSelectedSprite = value;
    }

    public Animator chainAnimator
    {
        get => orig.chainAnimator;
        set => orig.chainAnimator = value;
    }

    public GameObject bindAllEffect
    {
        get => orig.bindAllEffect;
        set => orig.bindAllEffect = value;
    }

    public AudioSource audioSourcePrefab
    {
        get => orig.audioSourcePrefab;
        set => orig.audioSourcePrefab = value;
    }

    public AudioEvent selectedSound
    {
        get => orig.selectedSound;
        set => orig.selectedSound = value;
    }

    public AudioEvent deselectedSound
    {
        get => orig.deselectedSound;
        set => orig.deselectedSound = value;
    }

    public float pitchShiftMin
    {
        get => orig.pitchShiftMin;
        set => orig.pitchShiftMin = value;
    }

    public float pitchShiftMax
    {
        get => orig.pitchShiftMax;
        set => orig.pitchShiftMax = value;
    }

    public int maxAmount
    {
        get => orig.maxAmount;
        set => orig.maxAmount = value;
    }

    public int currentAmount
    {
        get => GetFieldStatic<int>();
        set => SetField(value);
    }

    public bool isCounted
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool selected
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool Selected => orig.Selected;


    public void Awake()
    {
        CallMethod();
    }

    public void Reset()
    {
        orig.Reset();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void OnSubmit(BaseEventData eventData)
    {
        orig.OnSubmit(eventData);
    }

    public void SetAllSelected(bool value)
    {
        orig.SetAllSelected(value);
    }

    public IEnumerator SetAnimSizeDelayed(string anim, float normalizedTime)
    {
        return CallMethod<IEnumerator>(new object[] { anim, normalizedTime });
    }

    public void OnCancel(BaseEventData eventData)
    {
        orig.OnCancel(eventData);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        orig.OnPointerClick(eventData);
    }
}