using System.Reflection;
using MonoMod.Cil;
using MonoMod.RuntimeDetour.HookGen;
using MonoMod.Utils;

namespace Satchel.Reflected.ILIEnumerators
{
    /// <summary>
    ///     A class that contains events to properly ILHook onto IEnumerators.
    ///     Unlike the MAPI hooks, it uses GetStateMachineTarget which is required for the IL code to run after every "yield
    ///     return"
    /// </summary>
    public class UIManagerILIEnumerators
    {
        public static event ILContext.Manipulator ShowMainMenuHome
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("ShowMainMenuHome", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("ShowMainMenuHome", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator StartMenuAnimationCoroutineWorker
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("StartMenuAnimationCoroutineWorker",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("StartMenuAnimationCoroutineWorker",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }

        public static event ILContext.Manipulator GoToEngageMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToEngageMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToEngageMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToNoSaveMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToNoSaveMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToNoSaveMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToMainMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToMainMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToMainMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToProfileMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToProfileMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToProfileMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator PrepareSaveFilesInOrder
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("PrepareSaveFilesInOrder",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("PrepareSaveFilesInOrder",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }

        public static event ILContext.Manipulator GoToOptionsMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToOptionsMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToOptionsMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToControllerMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToControllerMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToControllerMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToRemapControllerMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToRemapControllerMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToRemapControllerMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }

        public static event ILContext.Manipulator GoToKeyboardMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToKeyboardMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToKeyboardMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToAudioMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToAudioMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToAudioMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToVideoMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToVideoMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToVideoMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToOverscanMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToOverscanMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToOverscanMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToBrightnessMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToBrightnessMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToBrightnessMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToGameOptionsMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToGameOptionsMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToGameOptionsMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToAchievementsMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToAchievementsMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToAchievementsMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToExtrasMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToExtrasMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToExtrasMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToExtrasContentMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToExtrasContentMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToExtrasContentMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }

        public static event ILContext.Manipulator GoToQuitGamePrompt
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToQuitGamePrompt",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToQuitGamePrompt",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToReturnMenuPrompt
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToReturnMenuPrompt",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToReturnMenuPrompt",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToResolutionPrompt
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToResolutionPrompt",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToResolutionPrompt",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator LeaveOptionsMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("LeaveOptionsMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("LeaveOptionsMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator LeaveExitToMenuPrompt
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("LeaveExitToMenuPrompt",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("LeaveExitToMenuPrompt",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }

        public static event ILContext.Manipulator GoToPlayModeMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToPlayModeMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToPlayModeMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator ReturnToMainMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("ReturnToMainMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("ReturnToMainMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToPauseMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToPauseMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToPauseMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToMenuCredits
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToMenuCredits", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToMenuCredits", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator HideCurrentMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("HideCurrentMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("HideCurrentMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator ShowMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("ShowMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("ShowMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator HideMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("HideMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("HideMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator HideSaveProfileMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("HideSaveProfileMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("HideSaveProfileMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator FadeInCanvasGroup
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("FadeInCanvasGroup",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("FadeInCanvasGroup",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator FadeInCanvasGroupAlpha
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("FadeInCanvasGroupAlpha",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("FadeInCanvasGroupAlpha",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetStateMachineTarget(),
                value);
        }

        public static event ILContext.Manipulator FadeOutCanvasGroup
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("FadeOutCanvasGroup",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("FadeOutCanvasGroup",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator FadeInSprite
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("FadeInSprite", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("FadeInSprite", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator FadeOutSprite
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("FadeOutSprite", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("FadeOutSprite", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator orig_HideCurrentMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("orig_HideCurrentMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("orig_HideCurrentMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator GoToDynamicMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("GoToDynamicMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("GoToDynamicMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator LeaveDynamicMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("LeaveDynamicMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("LeaveDynamicMenu", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }

        public static event ILContext.Manipulator PauseToDynamicMenu
        {
            add => HookEndpointManager.Modify(
                typeof(UIManager)
                    .GetMethod("PauseToDynamicMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
            remove => HookEndpointManager.Unmodify(
                typeof(UIManager)
                    .GetMethod("PauseToDynamicMenu",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetStateMachineTarget(), value);
        }
    }
}
