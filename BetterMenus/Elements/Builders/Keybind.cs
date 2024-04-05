using InControl;
using Modding.Menu;
using Satchel.BetterMenus.Config;
using UnityEngine.UI;

namespace Satchel.BetterMenus
{
    /// <summary>
    /// A helper class for creating keybind mapping buttons.
    /// </summary>
    public static partial class KeybindContent
    {
        /// <summary>
        /// Creates a keybind menu item.
        /// </summary>
        /// <param name="content">The <c>ContentArea</c> to put the keybind item in.</param>
        /// <param name="name">The name of the keybind game object.</param>
        /// <param name="action">The <c>PlayerAction</c> to associate with this keybind.</param>
        /// <param name="config">The configuration options for the keybind item.</param>
        /// <returns></returns>
        public static ContentArea AddCustomKeybind(
            this ContentArea content,
            string name,
            PlayerAction action,
            KeybindConfig config
        ) => content.AddCustomKeybind(name, action, config, out _);

        /// <summary>
        /// Creates a keybind menu item.
        /// </summary>
        /// <param name="content">The <c>ContentArea</c> to put the keybind item in.</param>
        /// <param name="name">The name of the keybind game object.</param>
        /// <param name="action">The <c>PlayerAction</c> to associate with this keybind.</param>
        /// <param name="config">The configuration options for the keybind item.</param>
        /// <param name="mappableKey">The <c>MappablKey</c> component on the created keybind item.</param>
        /// <returns></returns>
        public static ContentArea AddCustomKeybind(
            this ContentArea content,
            string name,
            PlayerAction action,
            KeybindConfig config,
            out MappableKey mappableKey
        )
        {
            var style = config.Style ?? KeybindStyle.VanillaStyle;
            var selectableArea = config.selectableArea ?? SelectableArea.Full;
            // Keybind object
            var keybind = new GameObject($"{name}");
            GameObject.DontDestroyOnLoad(keybind);
            keybind.transform.SetParent(content.ContentObject.transform, false);
            // CanvasRenderer
            keybind.AddComponent<CanvasRenderer>();
            // RectTransform
            var keybindRt = keybind.AddComponent<RectTransform>();
            new RelVector2(new Vector2(650f, 100f)).GetBaseTransformData().Apply(keybindRt);
            content.Layout.ModifyNext(keybindRt);


            // Text object
            var text = new GameObject("Text");
            GameObject.DontDestroyOnLoad(text);
            text.transform.SetParent(keybind.transform, false);
            // CanvasRenderer
            text.AddComponent<CanvasRenderer>();
            // RectTransform
            var textRt = text.AddComponent<RectTransform>();
            textRt.sizeDelta = new Vector2(0f, 0f);
            textRt.anchorMin = new Vector2(0f, 0f);
            textRt.anchorMax = new Vector2(1f, 1f);
            textRt.anchoredPosition = new Vector2(0f, 0f);
            textRt.pivot = new Vector2(0.5f, 0.5f);
            // Text
            var labelText = text.AddComponent<Text>();
            labelText.font = MenuResources.TrajanBold;
            labelText.fontSize = style.LabelTextSize;
            labelText.resizeTextMaxSize = style.LabelTextSize;
            labelText.alignment = TextAnchor.MiddleLeft;
            labelText.text = config.Label;
            labelText.supportRichText = true;
            labelText.verticalOverflow = VerticalWrapMode.Overflow;
            labelText.horizontalOverflow = HorizontalWrapMode.Overflow;
            // FixVerticalAlign
            text.AddComponent<FixVerticalAlign>();

            // LeftCursor object
            var cursorL = new GameObject("CursorLeft");
            GameObject.DontDestroyOnLoad(cursorL);
            cursorL.transform.SetParent(keybind.transform, false);
            // CanvasRenderer
            cursorL.AddComponent<CanvasRenderer>();
            // RectTransform
            var cursorLRt = cursorL.AddComponent<RectTransform>();
            cursorLRt.sizeDelta = new Vector2(154f, 112f);
            cursorLRt.pivot = new Vector2(0.5f, 0.5f);
            cursorLRt.anchorMin = new Vector2(0f, 0.5f);
            cursorLRt.anchorMax = new Vector2(0f, 0.5f);
            cursorLRt.anchoredPosition = new Vector2(-52f, 0f);
            cursorLRt.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            // Animator
            var cursorLAnimator = cursorL.AddComponent<Animator>();
            cursorLAnimator.runtimeAnimatorController = MenuResources.MenuCursorAnimator;
            cursorLAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;
            cursorLAnimator.applyRootMotion = false;
            // Image
            cursorL.AddComponent<Image>();

            // RightCursor object
            var cursorR = new GameObject("CursorRight");
            GameObject.DontDestroyOnLoad(cursorR);
            cursorR.transform.SetParent(keybind.transform, false);
            // CanvasRenderer
            cursorR.AddComponent<CanvasRenderer>();
            // RectTransform
            var cursorRRt = cursorR.AddComponent<RectTransform>();
            cursorRRt.sizeDelta = new Vector2(154f, 112f);
            cursorRRt.pivot = new Vector2(0.5f, 0.5f);
            cursorRRt.anchorMin = new Vector2(1f, 0.5f);
            cursorRRt.anchorMax = new Vector2(1f, 0.5f);
            cursorRRt.anchoredPosition = new Vector2(52f, 0f);
            cursorRRt.localScale = new Vector3(-0.4f, 0.4f, 0.4f);
            // Animator
            var cursorRAnimator = cursorR.AddComponent<Animator>();
            cursorRAnimator.runtimeAnimatorController = MenuResources.MenuCursorAnimator;
            cursorRAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;
            cursorRAnimator.applyRootMotion = false;
            // Image
            cursorR.AddComponent<Image>();

            // Keymap object
            var keymap = new GameObject("Keymap");
            GameObject.DontDestroyOnLoad(keymap);
            keymap.transform.SetParent(keybind.transform, false);
            // CanvasRenderer
            keymap.AddComponent<CanvasRenderer>();
            // RectTransform
            var keymapRt = keymap.AddComponent<RectTransform>();
            keymapRt.sizeDelta = new Vector2(145.8f, 82.4f);
            keymapRt.anchorMin = new Vector2(1f, 0.5f);
            keymapRt.anchorMax = new Vector2(1f, 0.5f);
            keymapRt.anchoredPosition = new Vector2(0f, 0f);
            keymapRt.pivot = new Vector2(1f, 0.5f);
            // Image
            var keymapImg = keymap.AddComponent<Image>();
            keymapImg.preserveAspect = true;

            // Keymap Text object
            var keymapText = new GameObject("Text");
            GameObject.DontDestroyOnLoad(keymapText);
            keymapText.transform.SetParent(keymap.transform, false);
            // CanvasRenderer
            keymapText.AddComponent<CanvasRenderer>();
            // RectTransform
            var keymapTextRt = keymapText.AddComponent<RectTransform>();
            keymapTextRt.sizeDelta = new Vector2(65f, 60f);
            keymapTextRt.anchorMin = new Vector2(0.5f, 0.5f);
            keymapTextRt.anchorMax = new Vector2(0.5f, 0.5f);
            keymapTextRt.anchoredPosition = new Vector2(32f, 0f);
            keymapTextRt.pivot = new Vector2(0.5f, 0.5f);
            // Text
            var keymapTextText = keymapText.AddComponent<Text>();
            keymapTextText.font = MenuResources.Perpetua;
            // FixVerticalAlign
            keymapText.AddComponent<FixVerticalAlign>().labelFixType = FixVerticalAlign.LabelFixType.KeyMap;

            // MappableKey
            var mapKey = keybind.AddComponent<MappableKey>();
            mapKey.InitCustomActions(action.Owner, action);
            var mkbutton = (MenuSelectable)mapKey;
            mkbutton.cancelAction = (CancelAction)CancelAction.CustomCancelAction;
            mkbutton.customCancelAction = _ =>
            {
                mapKey.AbortRebind();
                config.CancelAction?.Invoke(mapKey);
            };
            content.NavGraph.AddNavigationNode(mapKey);

            mapKey.leftCursor = cursorLAnimator;
            mapKey.rightCursor = cursorRAnimator;

            mapKey.keymapSprite = keymapImg;
            mapKey.keymapText = keymapTextText;

            mapKey.GetBinding();
            mapKey.ShowCurrentBinding();
            mappableKey = mapKey;

            ApplySelectableArea(
             config,
             keybind,
             keymap,
             cursorL,
             cursorR,
             keymapRt,
             keymapTextRt,
             textRt,
             keymapTextText,
             mapKey
            );
            return content;
        }
        public static void ApplySelectableArea(MappableKey mapKey, KeybindConfig config)
        {
            GameObject keybind = mapKey.gameObject;
            GameObject keymap = keybind.Find("Keymap");
            GameObject cursorL = keybind.Find("CursorLeft");
            GameObject cursorR = keybind.Find("CursorRight");
            RectTransform keymapRt = keymap.GetComponent<RectTransform>();
            RectTransform keymapTextRt = keymap.Find("Text").GetComponent<RectTransform>();
            RectTransform textRt = keybind.Find("Text").GetComponent<RectTransform>();
            Text keymapTextText = keymap.Find("Text").GetComponent<Text>();
            ApplySelectableArea(
             config,
             keybind,
             keymap,
             cursorL,
             cursorR,
             keymapRt,
             keymapTextRt,
             textRt,
             keymapTextText,
             mapKey
            );
        }

        public static void ApplySelectableArea(
            KeybindConfig config,
            GameObject keybind,
            GameObject keymap,
            GameObject cursorL,
            GameObject cursorR,
            RectTransform keymapRt,
            RectTransform keymapTextRt,
            RectTransform textRt,
            Text keymapTextText,
            MappableKey mapKey
        )
        {
            var selectableArea = config.selectableArea ?? SelectableArea.Full;
            if (selectableArea == SelectableArea.ButtonOnly)
            {
                cursorL.transform.SetParent(keymap.transform, false);
                cursorR.transform.SetParent(keymap.transform, false);

                keymapRt.pivot = new Vector2(0.5f, 0.5f);
                keymapTextRt.anchoredPosition = new Vector2(0f, 0f);
                keymapTextText.alignment = TextAnchor.MiddleCenter;
                ReflectionHelper.SetField(mapKey, "sqrX", 0f);
                ReflectionHelper.SetField(mapKey, "blankWidth", 70f);

                ReflectionHelper.SetField(mapKey, "blankFontSize", 36);
                ReflectionHelper.SetField(mapKey, "sqrMaxFont", 36);
                ReflectionHelper.SetField(mapKey, "sqrFontSize", 36);

                ReflectionHelper.SetField(mapKey, "blankBestFit", true);
                ReflectionHelper.SetField(mapKey, "blankAlignment", TextAnchor.MiddleCenter);

                if (config.Label.Length == 0)
                {
                    textRt.anchorMin = new Vector2(0f, 0f);
                    textRt.anchorMax = new Vector2(0f, 0f);
                }

            }
            else
            {
                cursorL.transform.SetParent(keybind.transform, false);
                cursorR.transform.SetParent(keybind.transform, false);

                keymapRt.pivot = new Vector2(1f, 0.5f);
                keymapTextRt.anchoredPosition = new Vector2(0f, 0f);
                keymapTextText.alignment = TextAnchor.MiddleCenter;
                ReflectionHelper.SetField(mapKey, "sqrX", 32f);
                ReflectionHelper.SetField(mapKey, "blankWidth", 165f);
                ReflectionHelper.SetField(mapKey, "blankBestFit", false);
                ReflectionHelper.SetField(mapKey, "blankFontSize", 36);
                ReflectionHelper.SetField(mapKey, "sqrMaxFont", 36);
                ReflectionHelper.SetField(mapKey, "sqrFontSize", 36);
                ReflectionHelper.SetField(mapKey, "blankAlignment", TextAnchor.MiddleRight);
                textRt.anchorMin = new Vector2(0f, 0f);
                textRt.anchorMax = new Vector2(1f, 1f);
            }
        }
    }
}