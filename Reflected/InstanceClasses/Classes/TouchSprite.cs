namespace Satchel.Reflected
{
    /// <summary>
    ///     A class that contains all (public and private) fields and methods of TouchSprite allowing you to
    ///     easily get/set fields and call methods without dealing with reflection.
    /// </summary>
    public class TouchSpriteR : InstanceClassWrapper<InControl.TouchSprite>
    {
        public TouchSpriteR(InControl.TouchSprite _orig) : base(_orig)
        {
        }

        public UnityEngine.Sprite idleSprite
        {
            get => GetField<UnityEngine.Sprite>();
            set => SetField(value);
        }

        public UnityEngine.Sprite busySprite
        {
            get => GetField<UnityEngine.Sprite>();
            set => SetField(value);
        }

        public UnityEngine.Color idleColor
        {
            get => GetField<UnityEngine.Color>();
            set => SetField(value);
        }

        public UnityEngine.Color busyColor
        {
            get => GetField<UnityEngine.Color>();
            set => SetField(value);
        }

        public InControl.TouchSpriteShape shape
        {
            get => GetField<InControl.TouchSpriteShape>();
            set => SetField(value);
        }

        public InControl.TouchUnitType sizeUnitType
        {
            get => GetField<InControl.TouchUnitType>();
            set => SetField(value);
        }

        public UnityEngine.Vector2 size
        {
            get => GetField<UnityEngine.Vector2>();
            set => SetField(value);
        }

        public bool lockAspectRatio
        {
            get => GetField<bool>();
            set => SetField(value);
        }

        public UnityEngine.Vector2 worldSize
        {
            get => GetField<UnityEngine.Vector2>();
            set => SetField(value);
        }

        public UnityEngine.GameObject spriteGameObject
        {
            get => GetField<UnityEngine.GameObject>();
            set => SetField(value);
        }

        public UnityEngine.SpriteRenderer spriteRenderer
        {
            get => GetField<UnityEngine.SpriteRenderer>();
            set => SetField(value);
        }

        public bool state
        {
            get => GetField<bool>();
            set => SetField(value);
        }

        public UnityEngine.Shader spriteRendererShader
        {
            get => GetFieldStatic<UnityEngine.Shader>();
            set => SetField(value);
        }

        public UnityEngine.Material spriteRendererMaterial
        {
            get => GetFieldStatic<UnityEngine.Material>();
            set => SetField(value);
        }

        public int spriteRendererPixelSnapId
        {
            get => GetFieldStatic<int>();
        }
    }
}