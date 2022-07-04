namespace Satchel.Reflected
{
/// <summary>
///     A class that contains all (public and private) fields and methods of BindingListenOptions allowing you to
///     easily get/set fields and call methods without dealing with reflection.
/// </summary>
public class BindingListenOptionsR:InstanceClassWrapper<InControl.BindingListenOptions>
{
public BindingListenOptionsR(InControl.BindingListenOptions _orig) : base(_orig) {}
public bool IncludeControllers
{
get => orig.IncludeControllers;
set => orig.IncludeControllers = value;
}

public bool IncludeUnknownControllers
{
get => orig.IncludeUnknownControllers;
set => orig.IncludeUnknownControllers = value;
}

public bool IncludeNonStandardControls
{
get => orig.IncludeNonStandardControls;
set => orig.IncludeNonStandardControls = value;
}

public bool IncludeMouseButtons
{
get => orig.IncludeMouseButtons;
set => orig.IncludeMouseButtons = value;
}

public bool IncludeMouseScrollWheel
{
get => orig.IncludeMouseScrollWheel;
set => orig.IncludeMouseScrollWheel = value;
}

public bool IncludeKeys
{
get => orig.IncludeKeys;
set => orig.IncludeKeys = value;
}

public bool IncludeModifiersAsFirstClassKeys
{
get => orig.IncludeModifiersAsFirstClassKeys;
set => orig.IncludeModifiersAsFirstClassKeys = value;
}

public System.UInt32 MaxAllowedBindings
{
get => orig.MaxAllowedBindings;
set => orig.MaxAllowedBindings = value;
}

public System.UInt32 MaxAllowedBindingsPerType
{
get => orig.MaxAllowedBindingsPerType;
set => orig.MaxAllowedBindingsPerType = value;
}

public bool AllowDuplicateBindingsPerSet
{
get => orig.AllowDuplicateBindingsPerSet;
set => orig.AllowDuplicateBindingsPerSet = value;
}

public bool UnsetDuplicateBindingsOnSet
{
get => orig.UnsetDuplicateBindingsOnSet;
set => orig.UnsetDuplicateBindingsOnSet = value;
}

public bool RejectRedundantBindings
{
get => orig.RejectRedundantBindings;
set => orig.RejectRedundantBindings = value;
}

public InControl.BindingSource ReplaceBinding
{
get => orig.ReplaceBinding;
set => orig.ReplaceBinding = value;
}

public System.Func<InControl.PlayerAction,InControl.BindingSource,System.Boolean> OnBindingFound
{
get => orig.OnBindingFound;
set => orig.OnBindingFound = value;
}

public System.Action<InControl.PlayerAction,InControl.BindingSource> OnBindingAdded
{
get => orig.OnBindingAdded;
set => orig.OnBindingAdded = value;
}

public System.Action<InControl.PlayerAction,InControl.BindingSource,InControl.BindingSourceRejectionType> OnBindingRejected
{
get => orig.OnBindingRejected;
set => orig.OnBindingRejected = value;
}

public System.Action<InControl.PlayerAction> OnBindingEnded
{
get => orig.OnBindingEnded;
set => orig.OnBindingEnded = value;
}

public bool CallOnBindingFound (InControl.PlayerAction playerAction, InControl.BindingSource bindingSource) =>
orig.CallOnBindingFound(playerAction, bindingSource);

public void CallOnBindingAdded (InControl.PlayerAction playerAction, InControl.BindingSource bindingSource) =>
orig.CallOnBindingAdded(playerAction, bindingSource);

public void CallOnBindingRejected (InControl.PlayerAction playerAction, InControl.BindingSource bindingSource, InControl.BindingSourceRejectionType bindingSourceRejectionType) =>
orig.CallOnBindingRejected(playerAction, bindingSource, bindingSourceRejectionType);

public void CallOnBindingEnded (InControl.PlayerAction playerAction) =>
orig.CallOnBindingEnded(playerAction);

}
}
