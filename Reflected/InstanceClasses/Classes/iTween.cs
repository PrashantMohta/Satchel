namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of iTween allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class iTweenR : InstanceClassWrapper<iTween>
{
    public iTweenR(iTween _orig) : base(_orig)
    {
    }

    public ArrayList tweens
    {
        get => iTween.tweens;
        set => iTween.tweens = value;
    }

    public GameObject cameraFade
    {
        get => GetFieldStatic<GameObject>();
        set => SetField(value);
    }

    public string id
    {
        get => orig.id;
        set => orig.id = value;
    }

    public string type
    {
        get => orig.type;
        set => orig.type = value;
    }

    public string method
    {
        get => orig.method;
        set => orig.method = value;
    }

    public float time
    {
        get => orig.time;
        set => orig.time = value;
    }

    public float delay
    {
        get => orig.delay;
        set => orig.delay = value;
    }

    public bool isRunning
    {
        get => orig.isRunning;
        set => orig.isRunning = value;
    }

    public bool isPaused
    {
        get => orig.isPaused;
        set => orig.isPaused = value;
    }

    public string _name
    {
        get => orig._name;
        set => orig._name = value;
    }

    public float runningTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float percentage
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public float delayStarted
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool kinematic
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool isLocal
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool loop
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool reverse
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool wasPaused
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public bool physics
    {
        get => GetField<bool>();
        set => SetField(value);
    }

    public Hashtable tweenArguments
    {
        get => GetField<Hashtable>();
        set => SetField(value);
    }

    public Space space
    {
        get => GetField<Space>();
        set => SetField(value);
    }

    public AudioSource audioSource
    {
        get => GetField<AudioSource>();
        set => SetField(value);
    }

    public Vector3[] vector3s
    {
        get => GetField<Vector3[]>();
        set => SetField(value);
    }

    public Vector2[] vector2s
    {
        get => GetField<Vector2[]>();
        set => SetField(value);
    }

    public Color[,] colors
    {
        get => GetField<Color[,]>();
        set => SetField(value);
    }

    public float[] floats
    {
        get => GetField<float[]>();
        set => SetField(value);
    }

    public Rect[] rects
    {
        get => GetField<Rect[]>();
        set => SetField(value);
    }

    public Vector3 preUpdate
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public Vector3 postUpdate
    {
        get => GetField<Vector3>();
        set => SetField(value);
    }

    public float lastRealTime
    {
        get => GetField<float>();
        set => SetField(value);
    }

    public bool useRealTime
    {
        get => GetField<bool>();
        set => SetField(value);
    }


    public void Init(GameObject target)
    {
        iTween.Init(target);
    }

    public void CameraFadeFrom(float amount, float time)
    {
        iTween.CameraFadeFrom(amount, time);
    }

    public void CameraFadeFrom(Hashtable args)
    {
        iTween.CameraFadeFrom(args);
    }

    public void CameraFadeTo(float amount, float time)
    {
        iTween.CameraFadeTo(amount, time);
    }

    public void CameraFadeTo(Hashtable args)
    {
        iTween.CameraFadeTo(args);
    }

    public void ValueTo(GameObject target, Hashtable args)
    {
        iTween.ValueTo(target, args);
    }

    public void FadeFrom(GameObject target, float alpha, float time)
    {
        iTween.FadeFrom(target, alpha, time);
    }

    public void FadeFrom(GameObject target, Hashtable args)
    {
        iTween.FadeFrom(target, args);
    }

    public void FadeTo(GameObject target, float alpha, float time)
    {
        iTween.FadeTo(target, alpha, time);
    }

    public void FadeTo(GameObject target, Hashtable args)
    {
        iTween.FadeTo(target, args);
    }

    public void ColorFrom(GameObject target, Color color, float time)
    {
        iTween.ColorFrom(target, color, time);
    }

    public void ColorFrom(GameObject target, Hashtable args)
    {
        iTween.ColorFrom(target, args);
    }

    public void ColorTo(GameObject target, Color color, float time)
    {
        iTween.ColorTo(target, color, time);
    }

    public void ColorTo(GameObject target, Hashtable args)
    {
        iTween.ColorTo(target, args);
    }

    public void AudioFrom(GameObject target, float volume, float pitch, float time)
    {
        iTween.AudioFrom(target, volume, pitch, time);
    }

    public void AudioFrom(GameObject target, Hashtable args)
    {
        iTween.AudioFrom(target, args);
    }

    public void AudioTo(GameObject target, float volume, float pitch, float time)
    {
        iTween.AudioTo(target, volume, pitch, time);
    }

    public void AudioTo(GameObject target, Hashtable args)
    {
        iTween.AudioTo(target, args);
    }

    public void Stab(GameObject target, AudioClip audioclip, float delay)
    {
        iTween.Stab(target, audioclip, delay);
    }

    public void Stab(GameObject target, Hashtable args)
    {
        iTween.Stab(target, args);
    }

    public void LookFrom(GameObject target, Vector3 looktarget, float time)
    {
        iTween.LookFrom(target, looktarget, time);
    }

    public void LookFrom(GameObject target, Hashtable args)
    {
        iTween.LookFrom(target, args);
    }

    public void LookTo(GameObject target, Vector3 looktarget, float time)
    {
        iTween.LookTo(target, looktarget, time);
    }

    public void LookTo(GameObject target, Hashtable args)
    {
        iTween.LookTo(target, args);
    }

    public void MoveTo(GameObject target, Vector3 position, float time)
    {
        iTween.MoveTo(target, position, time);
    }

    public void MoveTo(GameObject target, Hashtable args)
    {
        iTween.MoveTo(target, args);
    }

    public void MoveFrom(GameObject target, Vector3 position, float time)
    {
        iTween.MoveFrom(target, position, time);
    }

    public void MoveFrom(GameObject target, Hashtable args)
    {
        iTween.MoveFrom(target, args);
    }

    public void MoveAdd(GameObject target, Vector3 amount, float time)
    {
        iTween.MoveAdd(target, amount, time);
    }

    public void MoveAdd(GameObject target, Hashtable args)
    {
        iTween.MoveAdd(target, args);
    }

    public void MoveBy(GameObject target, Vector3 amount, float time)
    {
        iTween.MoveBy(target, amount, time);
    }

    public void MoveBy(GameObject target, Hashtable args)
    {
        iTween.MoveBy(target, args);
    }

    public void ScaleTo(GameObject target, Vector3 scale, float time)
    {
        iTween.ScaleTo(target, scale, time);
    }

    public void ScaleTo(GameObject target, Hashtable args)
    {
        iTween.ScaleTo(target, args);
    }

    public void ScaleFrom(GameObject target, Vector3 scale, float time)
    {
        iTween.ScaleFrom(target, scale, time);
    }

    public void ScaleFrom(GameObject target, Hashtable args)
    {
        iTween.ScaleFrom(target, args);
    }

    public void ScaleAdd(GameObject target, Vector3 amount, float time)
    {
        iTween.ScaleAdd(target, amount, time);
    }

    public void ScaleAdd(GameObject target, Hashtable args)
    {
        iTween.ScaleAdd(target, args);
    }

    public void ScaleBy(GameObject target, Vector3 amount, float time)
    {
        iTween.ScaleBy(target, amount, time);
    }

    public void ScaleBy(GameObject target, Hashtable args)
    {
        iTween.ScaleBy(target, args);
    }

    public void RotateTo(GameObject target, Vector3 rotation, float time)
    {
        iTween.RotateTo(target, rotation, time);
    }

    public void RotateTo(GameObject target, Hashtable args)
    {
        iTween.RotateTo(target, args);
    }

    public void RotateFrom(GameObject target, Vector3 rotation, float time)
    {
        iTween.RotateFrom(target, rotation, time);
    }

    public void RotateFrom(GameObject target, Hashtable args)
    {
        iTween.RotateFrom(target, args);
    }

    public void RotateAdd(GameObject target, Vector3 amount, float time)
    {
        iTween.RotateAdd(target, amount, time);
    }

    public void RotateAdd(GameObject target, Hashtable args)
    {
        iTween.RotateAdd(target, args);
    }

    public void RotateBy(GameObject target, Vector3 amount, float time)
    {
        iTween.RotateBy(target, amount, time);
    }

    public void RotateBy(GameObject target, Hashtable args)
    {
        iTween.RotateBy(target, args);
    }

    public void ShakePosition(GameObject target, Vector3 amount, float time)
    {
        iTween.ShakePosition(target, amount, time);
    }

    public void ShakePosition(GameObject target, Hashtable args)
    {
        iTween.ShakePosition(target, args);
    }

    public void ShakeScale(GameObject target, Vector3 amount, float time)
    {
        iTween.ShakeScale(target, amount, time);
    }

    public void ShakeScale(GameObject target, Hashtable args)
    {
        iTween.ShakeScale(target, args);
    }

    public void ShakeRotation(GameObject target, Vector3 amount, float time)
    {
        iTween.ShakeRotation(target, amount, time);
    }

    public void ShakeRotation(GameObject target, Hashtable args)
    {
        iTween.ShakeRotation(target, args);
    }

    public void PunchPosition(GameObject target, Vector3 amount, float time)
    {
        iTween.PunchPosition(target, amount, time);
    }

    public void PunchPosition(GameObject target, Hashtable args)
    {
        iTween.PunchPosition(target, args);
    }

    public void PunchRotation(GameObject target, Vector3 amount, float time)
    {
        iTween.PunchRotation(target, amount, time);
    }

    public void PunchRotation(GameObject target, Hashtable args)
    {
        iTween.PunchRotation(target, args);
    }

    public void PunchScale(GameObject target, Vector3 amount, float time)
    {
        iTween.PunchScale(target, amount, time);
    }

    public void PunchScale(GameObject target, Hashtable args)
    {
        iTween.PunchScale(target, args);
    }

    public void GenerateTargets()
    {
        CallMethod();
    }

    public void GenerateRectTargets()
    {
        CallMethod();
    }

    public void GenerateColorTargets()
    {
        CallMethod();
    }

    public void GenerateVector3Targets()
    {
        CallMethod();
    }

    public void GenerateVector2Targets()
    {
        CallMethod();
    }

    public void GenerateFloatTargets()
    {
        CallMethod();
    }

    public void GenerateColorToTargets()
    {
        CallMethod();
    }

    public void GenerateAudioToTargets()
    {
        CallMethod();
    }

    public void GenerateStabTargets()
    {
        CallMethod();
    }

    public void GenerateLookToTargets()
    {
        CallMethod();
    }

    public void GenerateMoveToPathTargets()
    {
        CallMethod();
    }

    public void GenerateMoveToTargets()
    {
        CallMethod();
    }

    public void GenerateMoveByTargets()
    {
        CallMethod();
    }

    public void GenerateScaleToTargets()
    {
        CallMethod();
    }

    public void GenerateScaleByTargets()
    {
        CallMethod();
    }

    public void GenerateScaleAddTargets()
    {
        CallMethod();
    }

    public void GenerateRotateToTargets()
    {
        CallMethod();
    }

    public void GenerateRotateAddTargets()
    {
        CallMethod();
    }

    public void GenerateRotateByTargets()
    {
        CallMethod();
    }

    public void GenerateShakePositionTargets()
    {
        CallMethod();
    }

    public void GenerateShakeScaleTargets()
    {
        CallMethod();
    }

    public void GenerateShakeRotationTargets()
    {
        CallMethod();
    }

    public void GeneratePunchPositionTargets()
    {
        CallMethod();
    }

    public void GeneratePunchRotationTargets()
    {
        CallMethod();
    }

    public void GeneratePunchScaleTargets()
    {
        CallMethod();
    }

    public void ApplyRectTargets()
    {
        CallMethod();
    }

    public void ApplyColorTargets()
    {
        CallMethod();
    }

    public void ApplyVector3Targets()
    {
        CallMethod();
    }

    public void ApplyVector2Targets()
    {
        CallMethod();
    }

    public void ApplyFloatTargets()
    {
        CallMethod();
    }

    public void ApplyColorToTargets()
    {
        CallMethod();
    }

    public void ApplyAudioToTargets()
    {
        CallMethod();
    }

    public void ApplyStabTargets()
    {
        CallMethod();
    }

    public void ApplyMoveToPathTargets()
    {
        CallMethod();
    }

    public void ApplyMoveToTargets()
    {
        CallMethod();
    }

    public void ApplyMoveByTargets()
    {
        CallMethod();
    }

    public void ApplyScaleToTargets()
    {
        CallMethod();
    }

    public void ApplyLookToTargets()
    {
        CallMethod();
    }

    public void ApplyRotateToTargets()
    {
        CallMethod();
    }

    public void ApplyRotateAddTargets()
    {
        CallMethod();
    }

    public void ApplyShakePositionTargets()
    {
        CallMethod();
    }

    public void ApplyShakeScaleTargets()
    {
        CallMethod();
    }

    public void ApplyShakeRotationTargets()
    {
        CallMethod();
    }

    public void ApplyPunchPositionTargets()
    {
        CallMethod();
    }

    public void ApplyPunchRotationTargets()
    {
        CallMethod();
    }

    public void ApplyPunchScaleTargets()
    {
        CallMethod();
    }

    public IEnumerator TweenDelay()
    {
        return CallMethod<IEnumerator>();
    }

    public void TweenStart()
    {
        CallMethod();
    }

    public IEnumerator TweenRestart()
    {
        return CallMethod<IEnumerator>();
    }

    public void TweenUpdate()
    {
        CallMethod();
    }

    public void TweenComplete()
    {
        CallMethod();
    }

    public void TweenLoop()
    {
        CallMethod();
    }

    public Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
    {
        return iTween.RectUpdate(currentValue, targetValue, speed);
    }

    public Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
    {
        return iTween.Vector3Update(currentValue, targetValue, speed);
    }

    public Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
    {
        return iTween.Vector2Update(currentValue, targetValue, speed);
    }

    public float FloatUpdate(float currentValue, float targetValue, float speed)
    {
        return iTween.FloatUpdate(currentValue, targetValue, speed);
    }

    public void FadeUpdate(GameObject target, Hashtable args)
    {
        iTween.FadeUpdate(target, args);
    }

    public void FadeUpdate(GameObject target, float alpha, float time)
    {
        iTween.FadeUpdate(target, alpha, time);
    }

    public void ColorUpdate(GameObject target, Hashtable args)
    {
        iTween.ColorUpdate(target, args);
    }

    public void ColorUpdate(GameObject target, Color color, float time)
    {
        iTween.ColorUpdate(target, color, time);
    }

    public void AudioUpdate(GameObject target, Hashtable args)
    {
        iTween.AudioUpdate(target, args);
    }

    public void AudioUpdate(GameObject target, float volume, float pitch, float time)
    {
        iTween.AudioUpdate(target, volume, pitch, time);
    }

    public void RotateUpdate(GameObject target, Hashtable args)
    {
        iTween.RotateUpdate(target, args);
    }

    public void RotateUpdate(GameObject target, Vector3 rotation, float time)
    {
        iTween.RotateUpdate(target, rotation, time);
    }

    public void ScaleUpdate(GameObject target, Hashtable args)
    {
        iTween.ScaleUpdate(target, args);
    }

    public void ScaleUpdate(GameObject target, Vector3 scale, float time)
    {
        iTween.ScaleUpdate(target, scale, time);
    }

    public void MoveUpdate(GameObject target, Hashtable args)
    {
        iTween.MoveUpdate(target, args);
    }

    public void MoveUpdate(GameObject target, Vector3 position, float time)
    {
        iTween.MoveUpdate(target, position, time);
    }

    public void LookUpdate(GameObject target, Hashtable args)
    {
        iTween.LookUpdate(target, args);
    }

    public void LookUpdate(GameObject target, Vector3 looktarget, float time)
    {
        iTween.LookUpdate(target, looktarget, time);
    }

    public float PathLength(Transform[] path)
    {
        return iTween.PathLength(path);
    }

    public float PathLength(Vector3[] path)
    {
        return iTween.PathLength(path);
    }

    public Texture2D CameraTexture(Color color)
    {
        return iTween.CameraTexture(color);
    }

    public void PutOnPath(GameObject target, Vector3[] path, float percent)
    {
        iTween.PutOnPath(target, path, percent);
    }

    public void PutOnPath(Transform target, Vector3[] path, float percent)
    {
        iTween.PutOnPath(target, path, percent);
    }

    public void PutOnPath(GameObject target, Transform[] path, float percent)
    {
        iTween.PutOnPath(target, path, percent);
    }

    public void PutOnPath(Transform target, Transform[] path, float percent)
    {
        iTween.PutOnPath(target, path, percent);
    }

    public Vector3 PointOnPath(Transform[] path, float percent)
    {
        return iTween.PointOnPath(path, percent);
    }

    public void DrawLine(Vector3[] line)
    {
        iTween.DrawLine(line);
    }

    public void DrawLine(Vector3[] line, Color color)
    {
        iTween.DrawLine(line, color);
    }

    public void DrawLine(Transform[] line)
    {
        iTween.DrawLine(line);
    }

    public void DrawLine(Transform[] line, Color color)
    {
        iTween.DrawLine(line, color);
    }

    public void DrawLineGizmos(Vector3[] line)
    {
        iTween.DrawLineGizmos(line);
    }

    public void DrawLineGizmos(Vector3[] line, Color color)
    {
        iTween.DrawLineGizmos(line, color);
    }

    public void DrawLineGizmos(Transform[] line)
    {
        iTween.DrawLineGizmos(line);
    }

    public void DrawLineGizmos(Transform[] line, Color color)
    {
        iTween.DrawLineGizmos(line, color);
    }

    public void DrawLineHandles(Vector3[] line)
    {
        iTween.DrawLineHandles(line);
    }

    public void DrawLineHandles(Vector3[] line, Color color)
    {
        iTween.DrawLineHandles(line, color);
    }

    public void DrawLineHandles(Transform[] line)
    {
        iTween.DrawLineHandles(line);
    }

    public void DrawLineHandles(Transform[] line, Color color)
    {
        iTween.DrawLineHandles(line, color);
    }

    public Vector3 PointOnPath(Vector3[] path, float percent)
    {
        return iTween.PointOnPath(path, percent);
    }

    public void DrawPath(Vector3[] path)
    {
        iTween.DrawPath(path);
    }

    public void DrawPath(Vector3[] path, Color color)
    {
        iTween.DrawPath(path, color);
    }

    public void DrawPath(Transform[] path)
    {
        iTween.DrawPath(path);
    }

    public void DrawPath(Transform[] path, Color color)
    {
        iTween.DrawPath(path, color);
    }

    public void DrawPathGizmos(Vector3[] path)
    {
        iTween.DrawPathGizmos(path);
    }

    public void DrawPathGizmos(Vector3[] path, Color color)
    {
        iTween.DrawPathGizmos(path, color);
    }

    public void DrawPathGizmos(Transform[] path)
    {
        iTween.DrawPathGizmos(path);
    }

    public void DrawPathGizmos(Transform[] path, Color color)
    {
        iTween.DrawPathGizmos(path, color);
    }

    public void DrawPathHandles(Vector3[] path)
    {
        iTween.DrawPathHandles(path);
    }

    public void DrawPathHandles(Vector3[] path, Color color)
    {
        iTween.DrawPathHandles(path, color);
    }

    public void DrawPathHandles(Transform[] path)
    {
        iTween.DrawPathHandles(path);
    }

    public void DrawPathHandles(Transform[] path, Color color)
    {
        iTween.DrawPathHandles(path, color);
    }

    public void CameraFadeDepth(int depth)
    {
        iTween.CameraFadeDepth(depth);
    }

    public void CameraFadeDestroy()
    {
        iTween.CameraFadeDestroy();
    }

    public void CameraFadeSwap(Texture2D texture)
    {
        iTween.CameraFadeSwap(texture);
    }

    public GameObject CameraFadeAdd(Texture2D texture, int depth)
    {
        return iTween.CameraFadeAdd(texture, depth);
    }

    public GameObject CameraFadeAdd(Texture2D texture)
    {
        return iTween.CameraFadeAdd(texture);
    }

    public GameObject CameraFadeAdd()
    {
        return iTween.CameraFadeAdd();
    }

    public void Resume(GameObject target)
    {
        iTween.Resume(target);
    }

    public void Resume(GameObject target, bool includechildren)
    {
        iTween.Resume(target, includechildren);
    }

    public void Resume(GameObject target, string type)
    {
        iTween.Resume(target, type);
    }

    public void Resume(GameObject target, string type, bool includechildren)
    {
        iTween.Resume(target, type, includechildren);
    }

    public void Resume()
    {
        iTween.Resume();
    }

    public void Resume(string type)
    {
        iTween.Resume(type);
    }

    public void Pause(GameObject target)
    {
        iTween.Pause(target);
    }

    public void Pause(GameObject target, bool includechildren)
    {
        iTween.Pause(target, includechildren);
    }

    public void Pause(GameObject target, string type)
    {
        iTween.Pause(target, type);
    }

    public void Pause(GameObject target, string type, bool includechildren)
    {
        iTween.Pause(target, type, includechildren);
    }

    public void Pause()
    {
        iTween.Pause();
    }

    public void Pause(string type)
    {
        iTween.Pause(type);
    }

    public int Count()
    {
        return iTween.Count();
    }

    public int Count(string type)
    {
        return iTween.Count(type);
    }

    public int Count(GameObject target)
    {
        return iTween.Count(target);
    }

    public int Count(GameObject target, string type)
    {
        return iTween.Count(target, type);
    }

    public void Stop()
    {
        iTween.Stop();
    }

    public void Stop(string type)
    {
        iTween.Stop(type);
    }

    public void StopByName(string name)
    {
        iTween.StopByName(name);
    }

    public void Stop(GameObject target)
    {
        iTween.Stop(target);
    }

    public void Stop(GameObject target, bool includechildren)
    {
        iTween.Stop(target, includechildren);
    }

    public void Stop(GameObject target, string type)
    {
        iTween.Stop(target, type);
    }

    public void StopByName(GameObject target, string name)
    {
        iTween.StopByName(target, name);
    }

    public void Stop(GameObject target, string type, bool includechildren)
    {
        iTween.Stop(target, type, includechildren);
    }

    public void StopByName(GameObject target, string name, bool includechildren)
    {
        iTween.StopByName(target, name, includechildren);
    }

    public Hashtable Hash(object[] args)
    {
        return iTween.Hash(args);
    }

    public void Awake()
    {
        CallMethod();
    }

    public IEnumerator Start()
    {
        return CallMethod<IEnumerator>();
    }

    public void Update()
    {
        CallMethod();
    }

    public void FixedUpdate()
    {
        CallMethod();
    }

    public void LateUpdate()
    {
        CallMethod();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void OnDisable()
    {
        CallMethod();
    }

    public void DrawLineHelper(Vector3[] line, Color color, string method)
    {
        CallMethodStatic(new object[] { line, color, method });
    }

    public void DrawPathHelper(Vector3[] path, Color color, string method)
    {
        CallMethodStatic(new object[] { path, color, method });
    }

    public Vector3[] PathControlPointGenerator(Vector3[] path)
    {
        return CallMethodStatic<Vector3[]>(new object[] { path });
    }

    public Vector3 Interp(Vector3[] pts, float t)
    {
        return CallMethodStatic<Vector3>(new object[] { pts, t });
    }

    public void Launch(GameObject target, Hashtable args)
    {
        CallMethodStatic(new object[] { target, args });
    }

    public Hashtable CleanArgs(Hashtable args)
    {
        return CallMethodStatic<Hashtable>(new object[] { args });
    }

    public string GenerateID()
    {
        return CallMethodStatic<string>();
    }

    public void RetrieveArgs()
    {
        CallMethod();
    }

    public void GetEasingFunction()
    {
        CallMethod();
    }

    public void UpdatePercentage()
    {
        CallMethod();
    }

    public void CallBack(string callbackType)
    {
        CallMethod(new object[] { callbackType });
    }

    public void Dispose()
    {
        CallMethod();
    }

    public void ConflictCheck()
    {
        CallMethod();
    }

    public void EnableKinematic()
    {
        CallMethod();
    }

    public void DisableKinematic()
    {
        CallMethod();
    }

    public void ResumeDelay()
    {
        CallMethod();
    }

    public float linear(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float clerp(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float spring(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInQuad(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeOutQuad(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInOutQuad(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInCubic(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeOutCubic(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInOutCubic(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInQuart(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeOutQuart(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInOutQuart(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInQuint(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeOutQuint(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInOutQuint(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInSine(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeOutSine(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInOutSine(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInExpo(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeOutExpo(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInOutExpo(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInCirc(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeOutCirc(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInOutCirc(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInBounce(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeOutBounce(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInOutBounce(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInBack(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeOutBack(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInOutBack(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float punch(float amplitude, float value)
    {
        return CallMethod<float>(new object[] { amplitude, value });
    }

    public float easeInElastic(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeOutElastic(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }

    public float easeInOutElastic(float start, float end, float value)
    {
        return CallMethod<float>(new object[] { start, end, value });
    }
}