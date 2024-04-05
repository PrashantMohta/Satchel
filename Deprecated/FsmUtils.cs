using Satchel.Futils.Extractors;

namespace Satchel
{

    [Obsolete("Satchel.MethodAction is deprecated, please use Satchel.Futils.CustomFsmAction instead.")]
    public class MethodAction : CustomFsmAction { }
    public static partial class FsmUtil
    {

        [Obsolete("Satchel.FsmUtil.AddMethod is deprecated, please use Satchel.FsmUtil.AddCustomAction instead.")]
        public static void AddMethod(this PlayMakerFSM self, string state, Action method)
        {
            AddCustomAction(self, state, method);
        }
        [Obsolete("Satchel.FsmUtil.InsertMethod is deprecated, please use Satchel.FsmUtil.InsertCustomAction instead.")]
        public static void InsertMethod(this PlayMakerFSM self, string state, Action method, int index)
        {
            InsertCustomAction(self, state, method, index);
        }
        [Obsolete("Satchel.FsmUtil.getAudioClips is deprecated, please use Satchel.Futils.Extractors.GetAudioClips instead.")]
        public static Dictionary<string, AudioClip> getAudioClips(this PlayMakerFSM self)
        {
            return self.GetAudioClips();
        }

        [Obsolete("Satchel.FsmUtil.AddCustomAction with stateName is deprecated, please use the overload without stateName.")]
        public static void AddCustomAction(this FsmState state, string stateName, Action method)
        {
            state.AddCustomAction(method);
        }

        [Obsolete("Satchel.FsmUtil.AddCustomAction with stateName is deprecated, please use the overload without stateName.")]
        public static void AddCustomAction(this FsmState state, string stateName, Action<FsmState> method)
        {
            state.AddCustomAction(method);
        }

        [Obsolete("Satchel.FsmUtil.InsertCustomAction with stateName is deprecated, please use the overload without stateName.")]
        public static void InsertCustomAction(this FsmState state, string stateName, Action method, int index)
        {
            state.InsertCustomAction(method, index);
        }

        [Obsolete("Satchel.FsmUtil.InsertCustomAction with stateName is deprecated, please use the overload without stateName.")]
        public static void InsertCustomAction(this FsmState state, string stateName, Action<FsmState> method, int index)
        {
            state.InsertCustomAction(method, index);
        }
    }
}