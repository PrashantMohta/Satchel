namespace Satchel.Reflected;

/// <summary>
///     A class that contains all (public and private) fields and methods of tk2dUpdateManager allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class tk2dUpdateManagerR : InstanceClassWrapper<tk2dUpdateManager>
{
    public tk2dUpdateManagerR(tk2dUpdateManager _orig) : base(_orig)
    {
    }

    public tk2dUpdateManager inst
    {
        get => GetFieldStatic<tk2dUpdateManager>();
        set => SetField(value);
    }

    public List<tk2dTextMesh> textMeshes
    {
        get => GetField<List<tk2dTextMesh>>();
        set => SetField(value);
    }

    public tk2dUpdateManager Instance => GetPropertyStatic<tk2dUpdateManager>();


    public void QueueCommit(tk2dTextMesh textMesh)
    {
        tk2dUpdateManager.QueueCommit(textMesh);
    }

    public void FlushQueues()
    {
        tk2dUpdateManager.FlushQueues();
    }

    public void OnEnable()
    {
        CallMethod();
    }

    public void LateUpdate()
    {
        CallMethod();
    }

    public IEnumerator coSuperLateUpdate()
    {
        return CallMethod<IEnumerator>();
    }

    public void QueueCommitInternal(tk2dTextMesh textMesh)
    {
        CallMethod(new object[] { textMesh });
    }

    public void FlushQueuesInternal()
    {
        CallMethod();
    }
}