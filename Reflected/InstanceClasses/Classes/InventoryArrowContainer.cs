namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of InventoryArrowContainer allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class InventoryArrowContainerR:InstanceClassWrapper<InventoryArrowContainer>
{
public InventoryArrowContainerR(InventoryArrowContainer _orig) : base(_orig) {}
public UnityEngine.GameObject arrowVariant
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public UnityEngine.GameObject promptVariant
{
get => GetField<UnityEngine.GameObject>();
set => SetField(value);
}

public TMPro.TextMeshPro label
{
get => GetField<TMPro.TextMeshPro>();
set => SetField(value);
}

public float labelLeftInset
{
get => GetField<float>();
set => SetField(value);
}

public float labelRightInset
{
get => GetField<float>();
set => SetField(value);
}



public void Start () =>
CallMethod();

public void OnDestroy () =>
CallMethod();

public void Setup () =>
CallMethod();

}
}
