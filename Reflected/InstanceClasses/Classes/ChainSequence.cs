namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of ChainSequence allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class ChainSequenceR:InstanceClassWrapper<ChainSequence>
{
public ChainSequenceR(ChainSequence _orig) : base(_orig) {}
public SkippableSequence[] sequences
{
get => GetField<SkippableSequence[]>();
set => SetField(value);
}

public int currentSequenceIndex
{
get => GetField<int>();
set => SetField(value);
}

public float fadeByController
{
get => GetField<float>();
set => SetField(value);
}

public bool isSkipped
{
get => GetField<bool>();
set => SetField(value);
}

public SkippableSequence CurrentSequence
{
get => GetProperty<SkippableSequence>();
}

public bool IsCurrentSkipped
{
get => orig.IsCurrentSkipped;
}

public bool IsSkipped
{
get => orig.IsSkipped;
}

public bool IsPlaying
{
get => orig.IsPlaying;
}

public float FadeByController
{
get => orig.FadeByController;
set => orig.FadeByController = value;
}



public void Awake () =>
CallMethod();

public void Update () =>
CallMethod();

public void Begin () =>
orig.Begin();

public void Next () =>
CallMethod();

public void Skip () =>
orig.Skip();

public void SkipSingle () =>
orig.SkipSingle();

}
}
