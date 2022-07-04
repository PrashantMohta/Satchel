namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BridgeSection allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BridgeSectionR:InstanceClassWrapper<BridgeSection>
{
public BridgeSectionR(BridgeSection _orig) : base(_orig) {}
public tk2dSpriteAnimator sectionAnim
{
get => orig.sectionAnim;
set => orig.sectionAnim = value;
}

public tk2dSpriteAnimator fenceAnim
{
get => orig.fenceAnim;
set => orig.fenceAnim = value;
}

public UnityEngine.MeshRenderer fenceRenderer
{
get => orig.fenceRenderer;
set => orig.fenceRenderer = value;
}

public UnityEngine.AudioSource source
{
get => orig.source;
set => orig.source = value;
}

public UnityEngine.AudioSource fenceSource
{
get => orig.fenceSource;
set => orig.fenceSource = value;
}



public void Awake () =>
CallMethod();

public void Open (BridgeLever lever, bool playAnim = true) =>
orig.Open(lever, playAnim);

public System.Collections.IEnumerator Open (float waitTime) =>
CallMethod<System.Collections.IEnumerator>(new object[] {waitTime});

public System.Collections.IEnumerator OpenFence () =>
CallMethod<System.Collections.IEnumerator>();

}
}
