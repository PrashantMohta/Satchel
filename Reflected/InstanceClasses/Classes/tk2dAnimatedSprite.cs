namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dAnimatedSprite allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dAnimatedSpriteR : InstanceClassWrapper<tk2dAnimatedSprite>
{
    public tk2dAnimatedSpriteR(tk2dAnimatedSprite _orig) : base(_orig)
    {
    }

    public tk2dSpriteAnimator _animator
    {
        get => GetField<tk2dSpriteAnimator>();
        set => SetField(value);
    }

    public tk2dSpriteAnimation anim
    {
        get => GetField<tk2dSpriteAnimation>();
        set => SetField(value);
    }

    public int clipId
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public bool playAutomatically
    {
        get => orig.playAutomatically;
        set => orig.playAutomatically = value;
    }

    public bool createCollider
    {
        get => orig.createCollider;
        set => orig.createCollider = value;
    }

    public tk2dSpriteCollectionData collectionInst
    {
        get => GetField<tk2dSpriteCollectionData>();
        set => SetField(value);
    }

    public Color _color
    {
        get => GetField<Color>();
        set => SetField(value);
    }

    public Vector3 _scale
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public int _spriteId
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public BoxCollider2D boxCollider2D
    {
        get => orig.boxCollider2D;
        set => orig.boxCollider2D = value;
    }

    public List<PolygonCollider2D> polygonCollider2D
    {
        get => orig.polygonCollider2D;
        set => orig.polygonCollider2D = value;
    }

    public List<EdgeCollider2D> edgeCollider2D
    {
        get => orig.edgeCollider2D;
        set => orig.edgeCollider2D = value;
    }

    public BoxCollider boxCollider
    {
        get => orig.boxCollider;
        set => orig.boxCollider = value;
    }

    public MeshCollider meshCollider
    {
        get => orig.meshCollider;
        set => orig.meshCollider = value;
    }

    public Vector3[] meshColliderPositions
    {
        get => orig.meshColliderPositions;
        set => orig.meshColliderPositions = value;
    }

    public Mesh meshColliderMesh
    {
        get => orig.meshColliderMesh;
        set => orig.meshColliderMesh = value;
    }

    public int renderLayer
    {
        get => GetField<int>();
        set => SetField(value);
    }

    public tk2dSpriteAnimator Animator => orig.Animator;

    public tk2dSpriteAnimation Library
    {
        get => orig.Library;
        set => orig.Library = value;
    }

    public int DefaultClipId
    {
        get => orig.DefaultClipId;
        set => orig.DefaultClipId = value;
    }

    public bool g_paused
    {
        get => tk2dAnimatedSprite.g_paused;
        set => tk2dAnimatedSprite.g_paused = value;
    }

    public bool Paused
    {
        get => orig.Paused;
        set => orig.Paused = value;
    }

    public tk2dSpriteAnimationClip CurrentClip => orig.CurrentClip;

    public float ClipTimeSeconds => orig.ClipTimeSeconds;

    public float ClipFps
    {
        get => orig.ClipFps;
        set => orig.ClipFps = value;
    }

    public bool Playing => orig.Playing;

    public float DefaultFps => tk2dAnimatedSprite.DefaultFps;

    public tk2dSpriteCollectionData Collection
    {
        get => orig.Collection;
        set => orig.Collection = value;
    }

    public Color color
    {
        get => orig.color;
        set => orig.color = value;
    }

    public Vector3 scale
    {
        get => orig.scale;
        set => orig.scale = value;
    }

    public int SortingOrder
    {
        get => orig.SortingOrder;
        set => orig.SortingOrder = value;
    }

    public bool FlipX
    {
        get => orig.FlipX;
        set => orig.FlipX = value;
    }

    public bool FlipY
    {
        get => orig.FlipY;
        set => orig.FlipY = value;
    }

    public int spriteId
    {
        get => orig.spriteId;
        set => orig.spriteId = value;
    }

    public tk2dSpriteDefinition CurrentSprite => orig.CurrentSprite;


    public void CheckAddAnimatorInternal()
    {
        CallMethod();
    }

    public bool NeedBoxCollider()
    {
        return CallMethod<bool>();
    }

    public void ProxyCompletedHandler(tk2dSpriteAnimator anim, tk2dSpriteAnimationClip clip)
    {
        CallMethod(new object[] { anim, clip });
    }

    public void ProxyEventTriggeredHandler(tk2dSpriteAnimator anim, tk2dSpriteAnimationClip clip, int frame)
    {
        CallMethod(new object[] { anim, clip, frame });
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void Start()
    {
        CallMethod();
    }

    public tk2dAnimatedSprite AddComponent(GameObject go, tk2dSpriteAnimation anim, int clipId)
    {
        return tk2dAnimatedSprite.AddComponent(go, anim, clipId);
    }

    public void Play()
    {
        orig.Play();
    }

    public void Play(float clipStartTime)
    {
        orig.Play(clipStartTime);
    }

    public void PlayFromFrame(int frame)
    {
        orig.PlayFromFrame(frame);
    }

    public void Play(string name)
    {
        orig.Play(name);
    }

    public void PlayFromFrame(string name, int frame)
    {
        orig.PlayFromFrame(name, frame);
    }

    public void Play(string name, float clipStartTime)
    {
        orig.Play(name, clipStartTime);
    }

    public void Play(tk2dSpriteAnimationClip clip, float clipStartTime)
    {
        orig.Play(clip, clipStartTime);
    }

    public void Play(tk2dSpriteAnimationClip clip, float clipStartTime, float overrideFps)
    {
        orig.Play(clip, clipStartTime, overrideFps);
    }

    public void Stop()
    {
        orig.Stop();
    }

    public void StopAndResetFrame()
    {
        orig.StopAndResetFrame();
    }

    public bool isPlaying()
    {
        return orig.isPlaying();
    }

    public bool IsPlaying(string name)
    {
        return orig.IsPlaying(name);
    }

    public bool IsPlaying(tk2dSpriteAnimationClip clip)
    {
        return orig.IsPlaying(clip);
    }

    public int GetClipIdByName(string name)
    {
        return orig.GetClipIdByName(name);
    }

    public tk2dSpriteAnimationClip GetClipByName(string name)
    {
        return orig.GetClipByName(name);
    }

    public void Pause()
    {
        orig.Pause();
    }

    public void Resume()
    {
        orig.Resume();
    }

    public void SetFrame(int currFrame)
    {
        orig.SetFrame(currFrame);
    }

    public void SetFrame(int currFrame, bool triggerEvent)
    {
        orig.SetFrame(currFrame, triggerEvent);
    }

    public void UpdateAnimation(float deltaTime)
    {
        orig.UpdateAnimation(deltaTime);
    }
}