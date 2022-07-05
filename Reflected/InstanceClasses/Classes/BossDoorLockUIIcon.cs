using UnityEngine.UI;

namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossDoorLockUIIcon allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossDoorLockUIIconR : InstanceClassWrapper<BossDoorLockUIIcon>
{
    public BossDoorLockUIIconR(BossDoorLockUIIcon _orig) : base(_orig)
    {
    }

    public Image bossIcon
    {
        get => orig.bossIcon;
        set => orig.bossIcon = value;
    }

    public float unlockAnimDelay
    {
        get => orig.unlockAnimDelay;
        set => orig.unlockAnimDelay = value;
    }

    public float indexOffsetDelay
    {
        get => orig.indexOffsetDelay;
        set => orig.indexOffsetDelay = value;
    }

    public AudioSource audioSourcePrefab
    {
        get => orig.audioSourcePrefab;
        set => orig.audioSourcePrefab = value;
    }

    public AudioEvent unlockSound
    {
        get => orig.unlockSound;
        set => orig.unlockSound = value;
    }

    public Animator animator
    {
        get => GetField<Animator>();
        set => SetField(value);
    }


    public void Awake()
    {
        CallMethod();
    }

    public void SetUnlocked(bool unlocked, bool doUnlockAnim = false, int indexAnimOffset = 0)
    {
        orig.SetUnlocked(unlocked, doUnlockAnim, indexAnimOffset);
    }

    public IEnumerator PlayAnimWithDelay(string anim, bool doAnim, float delay)
    {
        return CallMethod<IEnumerator>(new object[] { anim, doAnim, delay });
    }
}