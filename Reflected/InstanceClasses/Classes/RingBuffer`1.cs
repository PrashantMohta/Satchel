namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of RingBuffer`1 allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class RingBufferR<T>:InstanceClassWrapper<InControl.Internal.RingBuffer<T>>
{
public RingBufferR(InControl.Internal.RingBuffer<T> _orig) : base(_orig) {}
public int size
{
get => GetField<int>();
set => SetField(value);
}

public T[] data
{
get => GetField<T[]>();
set => SetField(value);
}

public int head
{
get => GetField<int>();
set => SetField(value);
}

public int tail
{
get => GetField<int>();
set => SetField(value);
}

public System.Object sync
{
get => GetField<System.Object>();
set => SetField(value);
}

public void Enqueue (T value) =>
orig.Enqueue(value);

public T Dequeue () =>
orig.Dequeue();

}
}
