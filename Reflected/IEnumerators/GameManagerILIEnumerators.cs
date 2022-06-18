using System.Reflection;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;
using MonoMod.Utils;

namespace Satchel.Reflected.IEnumerators
{
    /// <summary>
    /// A class that contains events to properly ILHook onto IEnumerators.
    /// Unlike the MAPI hooks, it uses GetStateMachineTarget which is required for the IL code to run after every "yield return"
    /// </summary>
    public class GameManagerILIEnumerators
    {
        public static event ILContext.Manipulator BeginSceneTransitionRoutine
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("BeginSceneTransitionRoutine",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("BeginSceneTransitionRoutine",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }

        public static event ILContext.Manipulator TransitionScene
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("TransitionScene", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("TransitionScene", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator PlayerDead
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("PlayerDead", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("PlayerDead", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator PlayerDeadFromHazard
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("PlayerDeadFromHazard",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("PlayerDeadFromHazard",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }

        public static event ILContext.Manipulator FadeSceneInWithDelay
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("FadeSceneInWithDelay",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("FadeSceneInWithDelay",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }

        public static event ILContext.Manipulator LoadSceneAdditive
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("LoadSceneAdditive",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("LoadSceneAdditive",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }

        public static event ILContext.Manipulator LoadFirstScene
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("LoadFirstScene", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("LoadFirstScene", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator SkipCutsceneNoMash
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("SkipCutsceneNoMash",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("SkipCutsceneNoMash",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }

        public static event ILContext.Manipulator LoadGameFromUIRoutine
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("LoadGameFromUIRoutine",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("LoadGameFromUIRoutine",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }

        public static event ILContext.Manipulator PauseGameToggleByMenu
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("PauseGameToggleByMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("PauseGameToggleByMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }

        public static event ILContext.Manipulator PauseGameToggle
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("PauseGameToggle", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("PauseGameToggle", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator SetTimeScale
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("SetTimeScale", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("SetTimeScale", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator FreezeMoment
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("FreezeMoment", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("FreezeMoment", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator FreezeMomentGC
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("FreezeMomentGC", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("FreezeMomentGC", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator RunStartNewGame
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("RunStartNewGame", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("RunStartNewGame", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator RunContinueGame
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("RunContinueGame", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("RunContinueGame", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator ReturnToMainMenu
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("ReturnToMainMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("ReturnToMainMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator QuitGame
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("QuitGame", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("QuitGame", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator orig_PlayerDead
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("orig_PlayerDead", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("orig_PlayerDead", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator PauseToggleDynamicMenu
        {
            add => HookEndpointManager.Modify(
                typeof(GameManager)
                    .GetMethod("PauseToggleDynamicMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(GameManager)
                    .GetMethod("PauseToggleDynamicMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }
    }
}