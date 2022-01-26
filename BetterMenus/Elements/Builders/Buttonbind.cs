using GlobalEnums;
using UnityEngine;
using UnityEngine.UI;
using Modding;
using Modding.Menu;
using InControl;
using Satchel.BetterMenus.Config;

namespace Satchel.BetterMenus
{
    /// <summary>
    /// A helper class for creating keybind mapping buttons.
    /// </summary>
    public static partial class KeybindContent
    {
        /// <summary>
        /// Creates a buttonBind menu item.
        /// </summary>
        /// <param name="content">The <c>ContentArea</c> to put the buttonBind item in.</param>
        /// <param name="name">The name of the buttonBind game object.</param>
        /// <param name="action">The <c>PlayerAction</c> to associate with this buttonBind.</param>
        /// <param name="config">The configuration options for the buttonBind item.</param>
        /// <param name="mappableControllerButton">The <c>MappableControllerButton</c> component on the created buttonBind item.</param>
        /// <returns></returns>
        public static ContentArea AddCustomButtonBind(
            this ContentArea content,
            string name,
            PlayerAction action,
            ButtonBindConfig config,
            out MappableControllerButton mappableControllerButton
        )
        {
            var style = config.Style ?? KeybindStyle.VanillaStyle;
            var selectableArea = config.selectableArea ?? SelectableArea.Full;
            // buttonBind object
            var buttonBind = new GameObject($"{name}");
            GameObject.DontDestroyOnLoad(buttonBind);
            buttonBind.transform.SetParent(content.ContentObject.transform, false);
            // CanvasRenderer
            buttonBind.AddComponent<CanvasRenderer>();
            // RectTransform
            var buttonBindRt = buttonBind.AddComponent<RectTransform>();
            new RelVector2(new Vector2(650f, 100f)).GetBaseTransformData().Apply(buttonBindRt);
            content.Layout.ModifyNext(buttonBindRt);
            // MappableControllerButton
            var mapButton = (MappableControllerButton)buttonBind.AddComponent<MappableControllerButton>();
            mapButton.InitCustomActions(action.Owner, action);
            var mkbutton = (MenuSelectable)mapButton;
            mkbutton.cancelAction = (CancelAction)CancelAction.CustomCancelAction;
            mkbutton.customCancelAction = _ =>
            {
                mapButton.AbortRebind();
                config.CancelAction?.Invoke(mapButton);
            };
            content.NavGraph.AddNavigationNode(mapButton);

            // Text object
            var text = new GameObject("Text");
            GameObject.DontDestroyOnLoad(text);
            text.transform.SetParent(buttonBind.transform, false);
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
            cursorL.transform.SetParent(buttonBind.transform, false);
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
            // Post Component Config
            mapButton.leftCursor = cursorLAnimator;

            // RightCursor object
            var cursorR = new GameObject("CursorRight");
            GameObject.DontDestroyOnLoad(cursorR);
            cursorR.transform.SetParent(buttonBind.transform, false);
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
            // Post Component Config
            mapButton.rightCursor = cursorRAnimator;

            // Keymap object
            var keymap = new GameObject("Keymap");
            GameObject.DontDestroyOnLoad(keymap);
            keymap.transform.SetParent(buttonBind.transform, false);
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
            mapButton.buttonmapSprite = keymapImg;

            // Keymap Text object
            var buttonmapText = new GameObject("Text");
            GameObject.DontDestroyOnLoad(buttonmapText);
            buttonmapText.transform.SetParent(keymap.transform, false);
            // CanvasRenderer
            buttonmapText.AddComponent<CanvasRenderer>();
            // RectTransform
            var buttonmapTextRt = buttonmapText.AddComponent<RectTransform>();
            buttonmapTextRt.sizeDelta = new Vector2(85f, 60f);
            buttonmapTextRt.anchorMin = new Vector2(0f, 0.5f);
            buttonmapTextRt.anchorMax = new Vector2(1f, 0.5f);
            buttonmapTextRt.anchoredPosition = new Vector2(32f, 0f);
            buttonmapTextRt.pivot = new Vector2(0.5f, 0.5f);
            // Text
            var buttonmapTextText = buttonmapText.AddComponent<Text>();
            buttonmapTextText.font = MenuResources.Perpetua;
            buttonmapTextText.fontSize = 35;
            mapButton.buttonmapText = buttonmapTextText;
            // FixVerticalAlign
            buttonmapText.AddComponent<FixVerticalAlign>().labelFixType = FixVerticalAlign.LabelFixType.KeyMap;
            // FakeThrobber to calm NREs
            var throbber = new GameObject("throbber");
            GameObject.DontDestroyOnLoad(throbber);
            throbber.transform.SetParent(keymap.transform, false);
            mapButton.listeningThrobber = throbber.AddComponent<Throbber>();
            ReflectionHelper.SetField( mapButton.listeningThrobber,"sprites",new Sprite[0]);
            
            mapButton.GetBindingPublic();
            mapButton.ShowCurrentBinding();
            mappableControllerButton = mapButton;
            ApplySelectableArea(
                config,
                buttonBind,
                keymap,
                cursorL,
                cursorR,
                keymapRt,
                buttonmapTextRt,
                textRt,
                buttonmapTextText
            );
            return content;
        }
    
        public static void ApplySelectableArea(MappableControllerButton mapButton,ButtonBindConfig config){
            GameObject buttonBind = mapButton.gameObject;
            GameObject keymap  = buttonBind.Find("Keymap");
            GameObject cursorL = buttonBind.Find("CursorLeft");
            GameObject cursorR = buttonBind.Find("CursorRight");
            RectTransform keymapRt = keymap.GetComponent<RectTransform>();
            RectTransform buttonmapTextRt = keymap.Find("Text").GetComponent<RectTransform>();
            RectTransform textRt = buttonBind.Find("Text").GetComponent<RectTransform>();
            Text buttonmapTextText = keymap.Find("Text").GetComponent<Text>();
            ApplySelectableArea(
                config,
                buttonBind,
                keymap,
                cursorL,
                cursorR,
                keymapRt,
                buttonmapTextRt,
                textRt,
                buttonmapTextText
            );
        }
        public static void ApplySelectableArea(
            ButtonBindConfig config,
            GameObject buttonBind,
            GameObject keymap,
            GameObject cursorL,
            GameObject cursorR,
            RectTransform keymapRt,
            RectTransform buttonmapTextRt,
            RectTransform textRt,
            Text buttonmapTextText
            ){
                var selectableArea = config.selectableArea ?? SelectableArea.Full;
                if(selectableArea == SelectableArea.ButtonOnly ){
                    cursorL.transform.SetParent(keymap.transform, false);
                    cursorR.transform.SetParent(keymap.transform, false);
                    keymapRt.pivot = new Vector2(0.5f, 0.5f);
                    buttonmapTextRt.anchoredPosition = new Vector2(0f, 0f);
                    buttonmapTextText.alignment = TextAnchor.MiddleCenter;
                    if(config.Label.Length == 0){
                        textRt.anchorMin = new Vector2(0f, 0f);
                        textRt.anchorMax = new Vector2(0f, 0f);
                    }
                } else {
                    cursorL.transform.SetParent(buttonBind.transform, false);
                    cursorR.transform.SetParent(buttonBind.transform, false);
                    keymapRt.pivot = new Vector2(1f, 0.5f);
                    buttonmapTextRt.anchoredPosition = new Vector2(32f, 0f);
                    buttonmapTextText.alignment = TextAnchor.MiddleCenter;
                    textRt.anchorMin = new Vector2(0f, 0f);
                    textRt.anchorMax = new Vector2(1f, 1f);
                }
        }


    }

  
}