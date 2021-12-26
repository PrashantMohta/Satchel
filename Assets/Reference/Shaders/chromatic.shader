Shader "Sprites/Chromatic"
{
	Properties
	{
		_MainTex("Base (RGB)", 2D) = "white" {}
        _RScale ("RScale",Range(0.0,1.0)) = 1.0
        _GScale ("GScale",Range(0.0,1.0)) = 1.0
        _BScale ("BScale",Range(0.0,1.0)) = 1.0

        _OffsetX ("OffsetX",Range(-1.0,1.0)) = 0.0
        _OffsetY ("OffsetY",Range(-1.0,1.0)) = 0.0

	}
		SubShader
	{
        Tags
         { 
             "Queue"="Transparent" 
             "IgnoreProjector"="True" 
             "RenderType"="Transparent" 
             "PreviewType"="Plane"
             "CanUseSpriteAtlas"="True"
         }
 
         Cull Off
         Lighting Off
         ZWrite Off
         Fog { Mode Off }
         Blend SrcAlpha OneMinusSrcAlpha
 
		Pass
		{
			CGPROGRAM
			#pragma vertex vert_img
			#pragma fragment frag
			#pragma fragmentoption ARB_precision_hint_fastest
			#include "UnityCG.cginc"

			uniform sampler2D _MainTex;
			float _OffsetX,_OffsetY,_RScale,_GScale,_BScale;

			float4 frag(v2f_img i) : COLOR
			{
				float2 coords = i.uv.xy;

				//Red Channel
				float4 red = tex2D(_MainTex , float2((coords.x - _OffsetX),(coords.y - _OffsetY)));

				//Green Channel
				float4 green = tex2D(_MainTex, float2((coords.x),(coords.y )));

				//Blue Channel
				float4 blue = tex2D(_MainTex, float2((coords.x + _OffsetX),(coords.y + _OffsetY)));


				float4 finalColor = float4(red.r * _RScale, green.g * _GScale, blue.b * _BScale, green.a);
				return finalColor;
			}
		ENDCG
		}
	}
}