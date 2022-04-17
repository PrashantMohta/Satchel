using System.Reflection;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;
using MonoMod.Utils;

namespace Satchel.Reflected
{
    /// <summary>
    /// A class that contains events to properly ILHook onto IEnumerators.
    /// Unlike the MAPI hooks, it uses GetStateMachineTarget which is required for the IL code to run after every "yield return"
    /// </summary>
    public class HeroControllerILIEnumerators
    {
        public static event ILContext.Manipulator EnterScene
        {
            add => HookEndpointManager.Modify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"EnterScene").GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"EnterScene").GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator BetaLeave
        {
            add => HookEndpointManager.Modify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"BetaLeave").GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"BetaLeave").GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator BetaReturn
        {
            add => HookEndpointManager.Modify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"BetaReturn").GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"BetaReturn").GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator Respawn
        {
            add => HookEndpointManager.Modify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"Respawn").GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"Respawn").GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator HazardRespawn
        {
            add => HookEndpointManager.Modify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"HazardRespawn").GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"HazardRespawn").GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator Die
        {
            add => HookEndpointManager.Modify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"Die").GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"Die").GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator DieFromHazard
        {
            add => HookEndpointManager.Modify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"DieFromHazard").GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"DieFromHazard").GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator StartRecoil
        {
            add => HookEndpointManager.Modify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"StartRecoil").GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"StartRecoil").GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator Invulnerable
        {
            add => HookEndpointManager.Modify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"Invulnerable").GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"Invulnerable").GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator FirstFadeIn
        {
            add => HookEndpointManager.Modify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"FirstFadeIn").GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"FirstFadeIn").GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator TilemapTestPause
        {
            add => HookEndpointManager.Modify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"TilemapTestPause").GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"TilemapTestPause").GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator CheckForTerrainThunk
        {
            add => HookEndpointManager.Modify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"CheckForTerrainThunk").GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                Modding.ReflectionHelper.GetMethodInfo(typeof(HeroController),"CheckForTerrainThunk").GetStateMachineTarget(), value);
        }
    }
}