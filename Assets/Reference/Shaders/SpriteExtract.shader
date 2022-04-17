Shader "SpriteExtract"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _MaskTex ("Mask Texture", 2D) = "white" {}
        _OffsetX ("Offset X", int) = 0
        _OffsetY ("Offset Y", int) = 0
        _SrcWidth ("Src Width", int) = 1
        _SrcHeight ("Src Height", int) = 1
        _Width ("Width", int) = 1
        _Height ("Height", int) = 1
        _DstWidth ("Dst Width", int) = 1
        _DstHeight ("Dst Height", int) = 1
        _FlipH ("Flip Horizontal", float) = 0
        _FlipV ("Flip Vertical", float) = 0
        _BorderLeft ("Border Left", int) = 0
        _BorderBottom ("Border Bottom", int) = 0
        _DrawMask ("Draw Mask", float) = 0
    }
    SubShader
    {
        Tags { "QUEUE"="Transparent" "IGNOREPROJECTOR"="true" "RenderType"="Transparent" "CanUseSpriteAtlas"="true" "PreviewType"="Plane" }
        // No culling or depth
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            sampler2D _MaskTex;
            float _OffsetX;
            float _OffsetY;
            fixed _FlipH;
            fixed _FlipV;
            fixed _DrawMask;
            float _Width;
            float _Height;
            float _SrcWidth;
            float _SrcHeight;
            float _DstWidth;
            float _DstHeight;


            float _BorderBottom;
            float _BorderLeft;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            
            

            fixed4 frag (v2f i) : SV_Target
            {   
                i.uv.x -= _BorderLeft / _DstWidth;
                i.uv.y -= _BorderBottom / _DstHeight;
                clip(i.uv);
                float minX = _OffsetX / _SrcWidth;
                float minY = _OffsetY / _SrcHeight;
                float W = _Width / _SrcWidth;
                float H = _Height / _SrcHeight;
                float maxX = minX + W;
                float maxY = minY + H;

                float scaleX = _DstWidth > _Width ? _DstWidth / _Width : _Width / _DstWidth;
                float scaleY = _DstHeight > _Height ? _DstHeight / _Height : _Height / _DstHeight;


                float2 origUV = float2(i.uv.x * scaleX, i.uv.y * scaleY);

                origUV.x = _FlipH > 0 ? 1 - origUV.x : origUV.x;
                origUV.y = _FlipV > 0 ? 1 - origUV.y : origUV.y;
                
                i.uv.x = _FlipH > 0 ? maxX - (i.uv.x * W * scaleX) : minX + (i.uv.x * W * scaleX);
                
                i.uv.y = _FlipV > 0 ? maxY - (i.uv.y * H * scaleY) : minY + (i.uv.y * H * scaleY);

                

                clip(i.uv.x > 1 ? -1 : 1);
                clip(i.uv.y > 1 ? -1 : 1);
                clip(i.uv.x - maxX > 0 ? -1 : 1);
                clip(i.uv.y - maxY > 0 ? -1 : 1);
                clip(i.uv);

                fixed4 col = tex2D(_MainTex, i.uv);
                fixed4 maskCol = tex2D(_MaskTex, origUV);
                col = _DrawMask < 1 ? col : (col.a <= 0 ? maskCol : col); 
                clip(maskCol.a - 0.01);

                clip(col.a - 0.01);
                return col;
            }
            ENDCG
        }
    }
}
