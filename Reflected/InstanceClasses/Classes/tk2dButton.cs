namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dButton allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dButtonR:InstanceClassWrapper<tk2dButton>
{
public tk2dButtonR(tk2dButton _orig) : base(_orig) {}
public UnityEngine.Camera viewCamera
{
get => orig.viewCamera;
set => orig.viewCamera = value;
}

public string buttonDownSprite
{
get => orig.buttonDownSprite;
set => orig.buttonDownSprite = value;
}

public string buttonUpSprite
{
get => orig.buttonUpSprite;
set => orig.buttonUpSprite = value;
}

public string buttonPressedSprite
{
get => orig.buttonPressedSprite;
set => orig.buttonPressedSprite = value;
}

public int buttonDownSpriteId
{
get => GetField<int>();
set => SetField(value);
}

public int buttonUpSpriteId
{
get => GetField<int>();
set => SetField(value);
}

public int buttonPressedSpriteId
{
get => GetField<int>();
set => SetField(value);
}

public UnityEngine.AudioClip buttonDownSound
{
get => orig.buttonDownSound;
set => orig.buttonDownSound = value;
}

public UnityEngine.AudioClip buttonUpSound
{
get => orig.buttonUpSound;
set => orig.buttonUpSound = value;
}

public UnityEngine.AudioClip buttonPressedSound
{
get => orig.buttonPressedSound;
set => orig.buttonPressedSound = value;
}

public UnityEngine.GameObject targetObject
{
get => orig.targetObject;
set => orig.targetObject = value;
}

public string messageName
{
get => orig.messageName;
set => orig.messageName = value;
}

public tk2dBaseSprite sprite
{
get => GetField<tk2dBaseSprite>();
set => SetField(value);
}

public bool buttonDown
{
get => GetField<bool>();
set => SetField(value);
}

public float targetScale
{
get => orig.targetScale;
set => orig.targetScale = value;
}

public float scaleTime
{
get => orig.scaleTime;
set => orig.scaleTime = value;
}

public float pressedWaitTime
{
get => orig.pressedWaitTime;
set => orig.pressedWaitTime = value;
}



public void OnEnable () =>
CallMethod();

public void Start () =>
CallMethod();

public void UpdateSpriteIds () =>
orig.UpdateSpriteIds();

public void PlaySound (UnityEngine.AudioClip source) =>
CallMethod(new object[] {source});

public System.Collections.IEnumerator coScale (UnityEngine.Vector3 defaultScale, float startScale, float endScale) =>
CallMethod<System.Collections.IEnumerator>(new object[] {defaultScale, startScale, endScale});

public System.Collections.IEnumerator LocalWaitForSeconds (float seconds) =>
CallMethod<System.Collections.IEnumerator>(new object[] {seconds});

public System.Collections.IEnumerator coHandleButtonPress (int fingerId) =>
CallMethod<System.Collections.IEnumerator>(new object[] {fingerId});

public void Update () =>
CallMethod();

}
}
