Shader "Simple Flat - Player" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] [HDR] _Colour2 ("Colour 2", Vector) = (0,0,0,0)
		_Color0 ("Colour 1", Vector) = (0,0,0,0)
		_Shininess ("Shininess", Range(0, 1)) = 0
		[Toggle(_MULTICOLOUR_ON)] _MultiColour ("MultiColour", Float) = 0
		[ASEEnd] _Flatness ("Flatness", Range(0, 1)) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	Fallback "Hidden/InternalErrorShader"
	//CustomEditor "UnityEditor.ShaderGraph.PBRMasterGUI"
}