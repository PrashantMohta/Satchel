namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of UnsupportedVibrationEmission allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class UnsupportedVibrationEmissionR:InstanceClassWrapper<UnsupportedVibrationEmission>
{
public UnsupportedVibrationEmissionR(UnsupportedVibrationEmission _orig) : base(_orig) {}
public VibrationTarget target
{
get => GetField<VibrationTarget>();
set => SetField(value);
}

public bool isLooping
{
get => GetField<bool>();
set => SetField(value);
}

public string tag
{
get => GetField<string>();
set => SetField(value);
}

public VibrationTarget Target
{
get => orig.Target;
set => orig.Target = value;
}

public bool IsLooping
{
get => orig.IsLooping;
set => orig.IsLooping = value;
}

public bool IsPlaying
{
get => orig.IsPlaying;
}

public string Tag
{
get => orig.Tag;
set => orig.Tag = value;
}

public void Stop () =>
orig.Stop();

}
}
