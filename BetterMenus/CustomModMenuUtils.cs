using System;
using System.Collections.Generic;
using Modding.Menu;
using Modding.Menu.Config;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;
using Modding;

namespace Satchel
{
    public static class CustomModMenuUtils
    {
        static CustomModMenuUtils()
        {
            ModHooks.LanguageGetHook += LanguageGet;
        }

        private static string LanguageGet(string key, string sheetTitle, string orig)
        {
            foreach (var KeyValue in CustomModMenuUtils.LanguageKeys)
            {
                if (key == KeyValue.Item1) return KeyValue.Item2;
            }
            return orig;
        }
        private static List<(string, string)> LanguageKeys = new List<(string, string)>();

        public static MenuBuilder CreateMenuBuilder(string Title)
        {
            return new MenuBuilder(UIManager.instance.UICanvas.gameObject, Title)
                .CreateTitle(Title, MenuTitleStyle.vanillaStyle)
                .CreateContentPane(RectTransformData.FromSizeAndPos(
                    new RelVector2(new Vector2(1920f, 903f)),
                    new AnchoredPosition(
                        new Vector2(0.5f, 0.5f),
                        new Vector2(0.5f, 0.5f),
                        new Vector2(0f, -60f)
                    )
                ))
                .CreateControlPane(RectTransformData.FromSizeAndPos(
                    new RelVector2(new Vector2(1920f, 259f)),
                    new AnchoredPosition(
                        new Vector2(0.5f, 0.5f),
                        new Vector2(0.5f, 0.5f),
                        new Vector2(0f, -502f)
                    )
                ))
                .SetDefaultNavGraph(new GridNavGraph(1));
        }
        public static MenuBuilder AddBackButton(this MenuBuilder builder, MenuScreen returnScreen, out UnityEngine.UI.MenuButton backButton)
        {
            UnityEngine.UI.MenuButton BackButton = null;
            builder.AddControls(
                new SingleContentLayout(new AnchoredPosition(
                    new Vector2(0.5f, 0.5f),
                    new Vector2(0.5f, 0.5f),
                    new Vector2(0f, -64f)
                )), c => c.AddMenuButton(
                    "BackButton",
                    new MenuButtonConfig
                    {
                        Label = "Back",
                        CancelAction = _ => UIManager.instance.UIGoToDynamicMenu(returnScreen),
                        SubmitAction = _ => UIManager.instance.UIGoToDynamicMenu(returnScreen),
                        Style = MenuButtonStyle.VanillaStyle,
                        Proceed = true
                    }, out BackButton));
            backButton = BackButton;
            return builder;
        }

        public static MenuBuilder AddBackButton(this MenuBuilder builder, MenuScreen returnScreen) => AddBackButton(builder, returnScreen, out _);

        //add a button near the back button
        public static MenuBuilder AddControlButton(this MenuBuilder builder, string name, Vector2 offset, Action<MenuSelectable> cancelAction, Action<UnityEngine.UI.MenuButton> submitAction)
        {
            return builder.AddControls(
                new SingleContentLayout(new AnchoredPosition(
                    new Vector2(0.5f, 0.5f),
                    new Vector2(0.5f, 0.5f),
                    offset
                )), c => c.AddMenuButton(
                    name,
                    new MenuButtonConfig
                    {
                        Label = name,
                        CancelAction = cancelAction,
                        SubmitAction = submitAction,
                        Style = MenuButtonStyle.VanillaStyle,
                        Proceed = true
                    }));
        }

        public static ContentArea AddVolumeSlider(this ContentArea content, string TextToShow, float height, Action<float> StoreValue, Func<int> SavedValue, out GameObject obj)
        {
            content.AddStaticPanel(TextToShow, new RelVector2(new Vector2(200f, height)), out GameObject parent);
            obj = GetMusicSlider(TextToShow, parent, StoreValue, SavedValue);
            return content;
        }

        private static GameObject GetMusicSlider(string TextToShow, GameObject Parent, Action<float> StoreValue, Func<int> SavedValue)
        {
            string key = $"Satchel_Music_Slider_Key_For_{TextToShow}_{LanguageKeys.Count}";
            LanguageKeys.Add((key, TextToShow));
            GameObject MusicSlider = UIManager.instance.gameObject.transform.Find("UICanvas/AudioMenuScreen/Content/MusicVolume/MusicSlider").gameObject;
            GameObject VolumeSlider = Object.Instantiate(MusicSlider, Parent.transform);
            MenuAudioSlider VolumeSlider_MenuAudioSlider = VolumeSlider.GetComponent<MenuAudioSlider>();
            Slider VolumeSlider_Slider = VolumeSlider.GetComponent<Slider>();
            VolumeSlider.name = $"{TextToShow}";
            Action<float> StoreValue_ = f =>
            {
                VolumeSlider_MenuAudioSlider.UpdateTextValue(f);
                StoreValue.Invoke(f);
            };
            // stuff to happen whenever slider is moved
            var SliderEvent = new Slider.SliderEvent();
            SliderEvent.AddListener(StoreValue_.Invoke);
            VolumeSlider_Slider.onValueChanged = SliderEvent;
            //change the key of the text so it can be changed
            VolumeSlider.transform.Find("Label").GetComponent<AutoLocalizeTextUI>().textKey = key;
            VolumeSlider.SetActive(true);
            //to make sure when go is cloned, it gets the value of the previous session not the value of the music slider
            int currentValue = SavedValue.Invoke();
            VolumeSlider_MenuAudioSlider.UpdateTextValue(currentValue);
            VolumeSlider_Slider.value = currentValue;

            return VolumeSlider;
        }


    }
}


