Shader "[ >< ]/[Apps]/[XSport]/[Transparent]HaloMask_Noise"
{


    CGINCLUDE
    #include "UnityCG.cginc"

    struct a2v
    {
        half4 vertex : POSITION;
        half2 uv0 : TEXCOORD0;
    };

    struct v2f
    {
        half4 vertex : SV_POSITION;
        half2 uv0 : TEXCOORD0;
        half2 uv1 : TEXCOORD1;
        half2 uv2 : TEXCOORD2;

    };
    fixed4 _MainColor;
    sampler2D _MainTex, _MaskTex, _NoiseTex;
    float4 _MainTex_ST, _MaskTex_ST, _NoiseTex_ST;
    float _ColorIntentsity;
    float _SpeedValueX, _SpeedValueY;
    
    v2f vert(a2v v)
    {
        v2f o;

        o.vertex = UnityObjectToClipPos(v.vertex);
        o.uv0 = TRANSFORM_TEX(v.uv0, _MainTex);
        o.uv0.x += (_Time.x * _SpeedValueX);
        o.uv0.y += (_Time.x * _SpeedValueY);
        o.uv1 = TRANSFORM_TEX(v.uv0, _NoiseTex);
        o.uv2 = TRANSFORM_TEX(v.uv0, _MaskTex);
        
        return o;
    }

    fixed4 frag(v2f i) : SV_Target
    {
       fixed4 finalColor = tex2D(_MainTex, i.uv0).rgba;
       fixed noise = tex2D(_NoiseTex, i.uv1).r;
       finalColor *= _MainColor;
       fixed mask = tex2D(_MaskTex, i.uv2).r;
       finalColor.a *= mask * noise;
       finalColor.rgb *= _ColorIntentsity;
       return finalColor;
    }
        ENDCG

        Properties
    {
        _MainTex("Opacity Texture", 2D) = "white" {}
        [HDR]_MainColor("Main Color", Color) = (1, 1, 1, 1)
        _ColorIntentsity("Color Intensity", Range(0, 20)) = 1
        _NoiseTex("NoiseTex", 2D) = "white"{}
        _MaskTex("MaskTex", 2D) = "white"{}
        _SpeedValueY("SpeedValueY",Range(-500,500))=0
        _SpeedValueX("SpeedValueX", Range(-500, 500)) = 0
    }

    SubShader
    {
        Tags{"Queue" = "Transparent""IgnoreProjector" = "True""RenderType" = "Transparent"}
        Pass
        {
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            Cull Off

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

         ENDCG
     }
    }
}