
Shader "Test/Decal" {
Properties {
	_Color ("Color", Color) = (1,1,1,1)
	_MainTex ("Base (RGB)", 2D) = "white" {} // the primary uv texture
	_DecalTex ("Decal (RGBA)", 2D) = "black" {} // the decal texture
}

SubShader {
	Material {
		Diffuse [_Color]
		Ambient [_Color]
		Specular (1,1,1,1)
	}

	Lighting On

	Pass {
		BindChannels {
			Bind "Vertex", vertex
			Bind "normal", normal
			Bind "Texcoord", Texcoord0 // main uses primary uv
			Bind "Texcoord1", Texcoord1 // logo uses secondary uv
		}

		Blend SrcAlpha OneMinusSrcAlpha

		// main (texcoord0)
		SetTexture [_MainTex] {
			constantColor [_Color]
			Combine texture * Constant
		}

		// decal (texcoord1)
		SetTexture [_DecalTex] {
			Combine texture lerp (texture) previous
		}

		SetTexture[_MainTex] {
			Combine primary * previous
		}
	}
}

}
