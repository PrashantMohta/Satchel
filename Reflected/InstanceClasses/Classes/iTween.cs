namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of iTween allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class iTweenR:InstanceClassWrapper<iTween>
{
public iTweenR(iTween _orig) : base(_orig) {}
public System.Collections.ArrayList tweens
{
get => iTween.tweens;
set => iTween.tweens = value;
}

public UnityEngine.GameObject cameraFade
{
get => GetFieldStatic<UnityEngine.GameObject>();
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

public System.Collections.Hashtable tweenArguments
{
get => GetField<System.Collections.Hashtable>();
set => SetField(value);
}

public UnityEngine.Space space
{
get => GetField<UnityEngine.Space>();
set => SetField(value);
}

public UnityEngine.AudioSource audioSource
{
get => GetField<UnityEngine.AudioSource>();
set => SetField(value);
}

public UnityEngine.Vector3[] vector3s
{
get => GetField<UnityEngine.Vector3[]>();
set => SetField(value);
}

public UnityEngine.Vector2[] vector2s
{
get => GetField<UnityEngine.Vector2[]>();
set => SetField(value);
}

public UnityEngine.Color[,] colors
{
get => GetField<UnityEngine.Color[,]>();
set => SetField(value);
}

public System.Single[] floats
{
get => GetField<System.Single[]>();
set => SetField(value);
}

public UnityEngine.Rect[] rects
{
get => GetField<UnityEngine.Rect[]>();
set => SetField(value);
}

public UnityEngine.Vector3 preUpdate
{
get => GetField<UnityEngine.Vector3>();
set => SetField(value);
}

public UnityEngine.Vector3 postUpdate
{
get => GetField<UnityEngine.Vector3>();
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



public void Init (UnityEngine.GameObject target) =>
iTween.Init(target);

public void CameraFadeFrom (float amount, float time) =>
iTween.CameraFadeFrom(amount, time);

public void CameraFadeFrom (System.Collections.Hashtable args) =>
iTween.CameraFadeFrom(args);

public void CameraFadeTo (float amount, float time) =>
iTween.CameraFadeTo(amount, time);

public void CameraFadeTo (System.Collections.Hashtable args) =>
iTween.CameraFadeTo(args);

public void ValueTo (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.ValueTo(target, args);

public void FadeFrom (UnityEngine.GameObject target, float alpha, float time) =>
iTween.FadeFrom(target, alpha, time);

public void FadeFrom (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.FadeFrom(target, args);

public void FadeTo (UnityEngine.GameObject target, float alpha, float time) =>
iTween.FadeTo(target, alpha, time);

public void FadeTo (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.FadeTo(target, args);

public void ColorFrom (UnityEngine.GameObject target, UnityEngine.Color color, float time) =>
iTween.ColorFrom(target, color, time);

public void ColorFrom (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.ColorFrom(target, args);

public void ColorTo (UnityEngine.GameObject target, UnityEngine.Color color, float time) =>
iTween.ColorTo(target, color, time);

public void ColorTo (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.ColorTo(target, args);

public void AudioFrom (UnityEngine.GameObject target, float volume, float pitch, float time) =>
iTween.AudioFrom(target, volume, pitch, time);

public void AudioFrom (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.AudioFrom(target, args);

public void AudioTo (UnityEngine.GameObject target, float volume, float pitch, float time) =>
iTween.AudioTo(target, volume, pitch, time);

public void AudioTo (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.AudioTo(target, args);

public void Stab (UnityEngine.GameObject target, UnityEngine.AudioClip audioclip, float delay) =>
iTween.Stab(target, audioclip, delay);

public void Stab (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.Stab(target, args);

public void LookFrom (UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time) =>
iTween.LookFrom(target, looktarget, time);

public void LookFrom (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.LookFrom(target, args);

public void LookTo (UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time) =>
iTween.LookTo(target, looktarget, time);

public void LookTo (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.LookTo(target, args);

public void MoveTo (UnityEngine.GameObject target, UnityEngine.Vector3 position, float time) =>
iTween.MoveTo(target, position, time);

public void MoveTo (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.MoveTo(target, args);

public void MoveFrom (UnityEngine.GameObject target, UnityEngine.Vector3 position, float time) =>
iTween.MoveFrom(target, position, time);

public void MoveFrom (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.MoveFrom(target, args);

public void MoveAdd (UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time) =>
iTween.MoveAdd(target, amount, time);

public void MoveAdd (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.MoveAdd(target, args);

public void MoveBy (UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time) =>
iTween.MoveBy(target, amount, time);

public void MoveBy (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.MoveBy(target, args);

public void ScaleTo (UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time) =>
iTween.ScaleTo(target, scale, time);

public void ScaleTo (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.ScaleTo(target, args);

public void ScaleFrom (UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time) =>
iTween.ScaleFrom(target, scale, time);

public void ScaleFrom (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.ScaleFrom(target, args);

public void ScaleAdd (UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time) =>
iTween.ScaleAdd(target, amount, time);

public void ScaleAdd (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.ScaleAdd(target, args);

public void ScaleBy (UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time) =>
iTween.ScaleBy(target, amount, time);

public void ScaleBy (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.ScaleBy(target, args);

public void RotateTo (UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time) =>
iTween.RotateTo(target, rotation, time);

public void RotateTo (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.RotateTo(target, args);

public void RotateFrom (UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time) =>
iTween.RotateFrom(target, rotation, time);

public void RotateFrom (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.RotateFrom(target, args);

public void RotateAdd (UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time) =>
iTween.RotateAdd(target, amount, time);

public void RotateAdd (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.RotateAdd(target, args);

public void RotateBy (UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time) =>
iTween.RotateBy(target, amount, time);

public void RotateBy (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.RotateBy(target, args);

public void ShakePosition (UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time) =>
iTween.ShakePosition(target, amount, time);

public void ShakePosition (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.ShakePosition(target, args);

public void ShakeScale (UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time) =>
iTween.ShakeScale(target, amount, time);

public void ShakeScale (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.ShakeScale(target, args);

public void ShakeRotation (UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time) =>
iTween.ShakeRotation(target, amount, time);

public void ShakeRotation (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.ShakeRotation(target, args);

public void PunchPosition (UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time) =>
iTween.PunchPosition(target, amount, time);

public void PunchPosition (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.PunchPosition(target, args);

public void PunchRotation (UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time) =>
iTween.PunchRotation(target, amount, time);

public void PunchRotation (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.PunchRotation(target, args);

public void PunchScale (UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time) =>
iTween.PunchScale(target, amount, time);

public void PunchScale (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.PunchScale(target, args);

public void GenerateTargets () =>
CallMethod();

public void GenerateRectTargets () =>
CallMethod();

public void GenerateColorTargets () =>
CallMethod();

public void GenerateVector3Targets () =>
CallMethod();

public void GenerateVector2Targets () =>
CallMethod();

public void GenerateFloatTargets () =>
CallMethod();

public void GenerateColorToTargets () =>
CallMethod();

public void GenerateAudioToTargets () =>
CallMethod();

public void GenerateStabTargets () =>
CallMethod();

public void GenerateLookToTargets () =>
CallMethod();

public void GenerateMoveToPathTargets () =>
CallMethod();

public void GenerateMoveToTargets () =>
CallMethod();

public void GenerateMoveByTargets () =>
CallMethod();

public void GenerateScaleToTargets () =>
CallMethod();

public void GenerateScaleByTargets () =>
CallMethod();

public void GenerateScaleAddTargets () =>
CallMethod();

public void GenerateRotateToTargets () =>
CallMethod();

public void GenerateRotateAddTargets () =>
CallMethod();

public void GenerateRotateByTargets () =>
CallMethod();

public void GenerateShakePositionTargets () =>
CallMethod();

public void GenerateShakeScaleTargets () =>
CallMethod();

public void GenerateShakeRotationTargets () =>
CallMethod();

public void GeneratePunchPositionTargets () =>
CallMethod();

public void GeneratePunchRotationTargets () =>
CallMethod();

public void GeneratePunchScaleTargets () =>
CallMethod();

public void ApplyRectTargets () =>
CallMethod();

public void ApplyColorTargets () =>
CallMethod();

public void ApplyVector3Targets () =>
CallMethod();

public void ApplyVector2Targets () =>
CallMethod();

public void ApplyFloatTargets () =>
CallMethod();

public void ApplyColorToTargets () =>
CallMethod();

public void ApplyAudioToTargets () =>
CallMethod();

public void ApplyStabTargets () =>
CallMethod();

public void ApplyMoveToPathTargets () =>
CallMethod();

public void ApplyMoveToTargets () =>
CallMethod();

public void ApplyMoveByTargets () =>
CallMethod();

public void ApplyScaleToTargets () =>
CallMethod();

public void ApplyLookToTargets () =>
CallMethod();

public void ApplyRotateToTargets () =>
CallMethod();

public void ApplyRotateAddTargets () =>
CallMethod();

public void ApplyShakePositionTargets () =>
CallMethod();

public void ApplyShakeScaleTargets () =>
CallMethod();

public void ApplyShakeRotationTargets () =>
CallMethod();

public void ApplyPunchPositionTargets () =>
CallMethod();

public void ApplyPunchRotationTargets () =>
CallMethod();

public void ApplyPunchScaleTargets () =>
CallMethod();

public System.Collections.IEnumerator TweenDelay () =>
CallMethod<System.Collections.IEnumerator>();

public void TweenStart () =>
CallMethod();

public System.Collections.IEnumerator TweenRestart () =>
CallMethod<System.Collections.IEnumerator>();

public void TweenUpdate () =>
CallMethod();

public void TweenComplete () =>
CallMethod();

public void TweenLoop () =>
CallMethod();

public UnityEngine.Rect RectUpdate (UnityEngine.Rect currentValue, UnityEngine.Rect targetValue, float speed) =>
iTween.RectUpdate(currentValue, targetValue, speed);

public UnityEngine.Vector3 Vector3Update (UnityEngine.Vector3 currentValue, UnityEngine.Vector3 targetValue, float speed) =>
iTween.Vector3Update(currentValue, targetValue, speed);

public UnityEngine.Vector2 Vector2Update (UnityEngine.Vector2 currentValue, UnityEngine.Vector2 targetValue, float speed) =>
iTween.Vector2Update(currentValue, targetValue, speed);

public float FloatUpdate (float currentValue, float targetValue, float speed) =>
iTween.FloatUpdate(currentValue, targetValue, speed);

public void FadeUpdate (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.FadeUpdate(target, args);

public void FadeUpdate (UnityEngine.GameObject target, float alpha, float time) =>
iTween.FadeUpdate(target, alpha, time);

public void ColorUpdate (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.ColorUpdate(target, args);

public void ColorUpdate (UnityEngine.GameObject target, UnityEngine.Color color, float time) =>
iTween.ColorUpdate(target, color, time);

public void AudioUpdate (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.AudioUpdate(target, args);

public void AudioUpdate (UnityEngine.GameObject target, float volume, float pitch, float time) =>
iTween.AudioUpdate(target, volume, pitch, time);

public void RotateUpdate (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.RotateUpdate(target, args);

public void RotateUpdate (UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time) =>
iTween.RotateUpdate(target, rotation, time);

public void ScaleUpdate (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.ScaleUpdate(target, args);

public void ScaleUpdate (UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time) =>
iTween.ScaleUpdate(target, scale, time);

public void MoveUpdate (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.MoveUpdate(target, args);

public void MoveUpdate (UnityEngine.GameObject target, UnityEngine.Vector3 position, float time) =>
iTween.MoveUpdate(target, position, time);

public void LookUpdate (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
iTween.LookUpdate(target, args);

public void LookUpdate (UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time) =>
iTween.LookUpdate(target, looktarget, time);

public float PathLength (UnityEngine.Transform[] path) =>
iTween.PathLength(path);

public float PathLength (UnityEngine.Vector3[] path) =>
iTween.PathLength(path);

public UnityEngine.Texture2D CameraTexture (UnityEngine.Color color) =>
iTween.CameraTexture(color);

public void PutOnPath (UnityEngine.GameObject target, UnityEngine.Vector3[] path, float percent) =>
iTween.PutOnPath(target, path, percent);

public void PutOnPath (UnityEngine.Transform target, UnityEngine.Vector3[] path, float percent) =>
iTween.PutOnPath(target, path, percent);

public void PutOnPath (UnityEngine.GameObject target, UnityEngine.Transform[] path, float percent) =>
iTween.PutOnPath(target, path, percent);

public void PutOnPath (UnityEngine.Transform target, UnityEngine.Transform[] path, float percent) =>
iTween.PutOnPath(target, path, percent);

public UnityEngine.Vector3 PointOnPath (UnityEngine.Transform[] path, float percent) =>
iTween.PointOnPath(path, percent);

public void DrawLine (UnityEngine.Vector3[] line) =>
iTween.DrawLine(line);

public void DrawLine (UnityEngine.Vector3[] line, UnityEngine.Color color) =>
iTween.DrawLine(line, color);

public void DrawLine (UnityEngine.Transform[] line) =>
iTween.DrawLine(line);

public void DrawLine (UnityEngine.Transform[] line, UnityEngine.Color color) =>
iTween.DrawLine(line, color);

public void DrawLineGizmos (UnityEngine.Vector3[] line) =>
iTween.DrawLineGizmos(line);

public void DrawLineGizmos (UnityEngine.Vector3[] line, UnityEngine.Color color) =>
iTween.DrawLineGizmos(line, color);

public void DrawLineGizmos (UnityEngine.Transform[] line) =>
iTween.DrawLineGizmos(line);

public void DrawLineGizmos (UnityEngine.Transform[] line, UnityEngine.Color color) =>
iTween.DrawLineGizmos(line, color);

public void DrawLineHandles (UnityEngine.Vector3[] line) =>
iTween.DrawLineHandles(line);

public void DrawLineHandles (UnityEngine.Vector3[] line, UnityEngine.Color color) =>
iTween.DrawLineHandles(line, color);

public void DrawLineHandles (UnityEngine.Transform[] line) =>
iTween.DrawLineHandles(line);

public void DrawLineHandles (UnityEngine.Transform[] line, UnityEngine.Color color) =>
iTween.DrawLineHandles(line, color);

public UnityEngine.Vector3 PointOnPath (UnityEngine.Vector3[] path, float percent) =>
iTween.PointOnPath(path, percent);

public void DrawPath (UnityEngine.Vector3[] path) =>
iTween.DrawPath(path);

public void DrawPath (UnityEngine.Vector3[] path, UnityEngine.Color color) =>
iTween.DrawPath(path, color);

public void DrawPath (UnityEngine.Transform[] path) =>
iTween.DrawPath(path);

public void DrawPath (UnityEngine.Transform[] path, UnityEngine.Color color) =>
iTween.DrawPath(path, color);

public void DrawPathGizmos (UnityEngine.Vector3[] path) =>
iTween.DrawPathGizmos(path);

public void DrawPathGizmos (UnityEngine.Vector3[] path, UnityEngine.Color color) =>
iTween.DrawPathGizmos(path, color);

public void DrawPathGizmos (UnityEngine.Transform[] path) =>
iTween.DrawPathGizmos(path);

public void DrawPathGizmos (UnityEngine.Transform[] path, UnityEngine.Color color) =>
iTween.DrawPathGizmos(path, color);

public void DrawPathHandles (UnityEngine.Vector3[] path) =>
iTween.DrawPathHandles(path);

public void DrawPathHandles (UnityEngine.Vector3[] path, UnityEngine.Color color) =>
iTween.DrawPathHandles(path, color);

public void DrawPathHandles (UnityEngine.Transform[] path) =>
iTween.DrawPathHandles(path);

public void DrawPathHandles (UnityEngine.Transform[] path, UnityEngine.Color color) =>
iTween.DrawPathHandles(path, color);

public void CameraFadeDepth (int depth) =>
iTween.CameraFadeDepth(depth);

public void CameraFadeDestroy () =>
iTween.CameraFadeDestroy();

public void CameraFadeSwap (UnityEngine.Texture2D texture) =>
iTween.CameraFadeSwap(texture);

public UnityEngine.GameObject CameraFadeAdd (UnityEngine.Texture2D texture, int depth) =>
iTween.CameraFadeAdd(texture, depth);

public UnityEngine.GameObject CameraFadeAdd (UnityEngine.Texture2D texture) =>
iTween.CameraFadeAdd(texture);

public UnityEngine.GameObject CameraFadeAdd () =>
iTween.CameraFadeAdd();

public void Resume (UnityEngine.GameObject target) =>
iTween.Resume(target);

public void Resume (UnityEngine.GameObject target, bool includechildren) =>
iTween.Resume(target, includechildren);

public void Resume (UnityEngine.GameObject target, string type) =>
iTween.Resume(target, type);

public void Resume (UnityEngine.GameObject target, string type, bool includechildren) =>
iTween.Resume(target, type, includechildren);

public void Resume () =>
iTween.Resume();

public void Resume (string type) =>
iTween.Resume(type);

public void Pause (UnityEngine.GameObject target) =>
iTween.Pause(target);

public void Pause (UnityEngine.GameObject target, bool includechildren) =>
iTween.Pause(target, includechildren);

public void Pause (UnityEngine.GameObject target, string type) =>
iTween.Pause(target, type);

public void Pause (UnityEngine.GameObject target, string type, bool includechildren) =>
iTween.Pause(target, type, includechildren);

public void Pause () =>
iTween.Pause();

public void Pause (string type) =>
iTween.Pause(type);

public int Count () =>
iTween.Count();

public int Count (string type) =>
iTween.Count(type);

public int Count (UnityEngine.GameObject target) =>
iTween.Count(target);

public int Count (UnityEngine.GameObject target, string type) =>
iTween.Count(target, type);

public void Stop () =>
iTween.Stop();

public void Stop (string type) =>
iTween.Stop(type);

public void StopByName (string name) =>
iTween.StopByName(name);

public void Stop (UnityEngine.GameObject target) =>
iTween.Stop(target);

public void Stop (UnityEngine.GameObject target, bool includechildren) =>
iTween.Stop(target, includechildren);

public void Stop (UnityEngine.GameObject target, string type) =>
iTween.Stop(target, type);

public void StopByName (UnityEngine.GameObject target, string name) =>
iTween.StopByName(target, name);

public void Stop (UnityEngine.GameObject target, string type, bool includechildren) =>
iTween.Stop(target, type, includechildren);

public void StopByName (UnityEngine.GameObject target, string name, bool includechildren) =>
iTween.StopByName(target, name, includechildren);

public System.Collections.Hashtable Hash (System.Object[] args) =>
iTween.Hash(args);

public void Awake () =>
CallMethod();

public System.Collections.IEnumerator Start () =>
CallMethod<System.Collections.IEnumerator>();

public void Update () =>
CallMethod();

public void FixedUpdate () =>
CallMethod();

public void LateUpdate () =>
CallMethod();

public void OnEnable () =>
CallMethod();

public void OnDisable () =>
CallMethod();

public void DrawLineHelper (UnityEngine.Vector3[] line, UnityEngine.Color color, string method) =>
CallMethodStatic(new object[] {line, color, method});

public void DrawPathHelper (UnityEngine.Vector3[] path, UnityEngine.Color color, string method) =>
CallMethodStatic(new object[] {path, color, method});

public UnityEngine.Vector3[] PathControlPointGenerator (UnityEngine.Vector3[] path) =>
CallMethodStatic<UnityEngine.Vector3[]>(new object[] {path});

public UnityEngine.Vector3 Interp (UnityEngine.Vector3[] pts, float t) =>
CallMethodStatic<UnityEngine.Vector3>(new object[] {pts, t});

public void Launch (UnityEngine.GameObject target, System.Collections.Hashtable args) =>
CallMethodStatic(new object[] {target, args});

public System.Collections.Hashtable CleanArgs (System.Collections.Hashtable args) =>
CallMethodStatic<System.Collections.Hashtable>(new object[] {args});

public string GenerateID () =>
CallMethodStatic<string>();

public void RetrieveArgs () =>
CallMethod();

public void GetEasingFunction () =>
CallMethod();

public void UpdatePercentage () =>
CallMethod();

public void CallBack (string callbackType) =>
CallMethod(new object[] {callbackType});

public void Dispose () =>
CallMethod();

public void ConflictCheck () =>
CallMethod();

public void EnableKinematic () =>
CallMethod();

public void DisableKinematic () =>
CallMethod();

public void ResumeDelay () =>
CallMethod();

public float linear (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float clerp (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float spring (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInQuad (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeOutQuad (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInOutQuad (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInCubic (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeOutCubic (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInOutCubic (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInQuart (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeOutQuart (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInOutQuart (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInQuint (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeOutQuint (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInOutQuint (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInSine (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeOutSine (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInOutSine (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInExpo (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeOutExpo (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInOutExpo (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInCirc (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeOutCirc (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInOutCirc (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInBounce (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeOutBounce (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInOutBounce (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInBack (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeOutBack (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInOutBack (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float punch (float amplitude, float value) =>
CallMethod<float>(new object[] {amplitude, value});

public float easeInElastic (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeOutElastic (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

public float easeInOutElastic (float start, float end, float value) =>
CallMethod<float>(new object[] {start, end, value});

}
}
