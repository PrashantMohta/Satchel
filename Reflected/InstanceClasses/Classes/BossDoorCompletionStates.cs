namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of BossDoorCompletionStates allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BossDoorCompletionStatesR : InstanceClassWrapper<BossDoorCompletionStates>
{
    public BossDoorCompletionStatesR(BossDoorCompletionStates _orig) : base(_orig)
    {
    }

    public BossDoorCompletionStates.CompletionState[] completionStates
    {
        get => orig.completionStates;
        set => orig.completionStates = value;
    }

    public string stateSeenPlayerData
    {
        get => orig.stateSeenPlayerData;
        set => orig.stateSeenPlayerData = value;
    }

    public int completedIndex
    {
        get => GetField<int>();
        set => SetField(value);
    }


    public void Start()
    {
        CallMethod();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CallMethod(new object[] { collision });
    }
}