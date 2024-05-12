using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace VLB
{
	// Token: 0x020005E6 RID: 1510
	public static class ShaderProperties : Object
	{
		// Token: 0x06007A41 RID: 31297 RVA: 0x001EBDE4 File Offset: 0x001E9FE4
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderProperties()
		{
			Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "ShaderProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr);
			ShaderProperties.NativeFieldInfoPtr_FadeOutFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "FadeOutFactor");
			ShaderProperties.NativeFieldInfoPtr_ClippingPlaneWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ClippingPlaneWS");
			ShaderProperties.NativeFieldInfoPtr_ClippingPlaneProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ClippingPlaneProps");
			ShaderProperties.NativeFieldInfoPtr_ConeSlopeCosSin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ConeSlopeCosSin");
			ShaderProperties.NativeFieldInfoPtr_ConeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ConeRadius");
			ShaderProperties.NativeFieldInfoPtr_ConeApexOffsetZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ConeApexOffsetZ");
			ShaderProperties.NativeFieldInfoPtr_ColorFlat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ColorFlat");
			ShaderProperties.NativeFieldInfoPtr_AlphaInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "AlphaInside");
			ShaderProperties.NativeFieldInfoPtr_AlphaOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "AlphaOutside");
			ShaderProperties.NativeFieldInfoPtr_AttenuationLerpLinearQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "AttenuationLerpLinearQuad");
			ShaderProperties.NativeFieldInfoPtr_DistanceFadeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "DistanceFadeStart");
			ShaderProperties.NativeFieldInfoPtr_DistanceFadeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "DistanceFadeEnd");
			ShaderProperties.NativeFieldInfoPtr_DistanceCamClipping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "DistanceCamClipping");
			ShaderProperties.NativeFieldInfoPtr_FresnelPow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "FresnelPow");
			ShaderProperties.NativeFieldInfoPtr_GlareBehind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlareBehind");
			ShaderProperties.NativeFieldInfoPtr_GlareFrontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlareFrontal");
			ShaderProperties.NativeFieldInfoPtr_DrawCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "DrawCap");
			ShaderProperties.NativeFieldInfoPtr_DepthBlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "DepthBlendDistance");
			ShaderProperties.NativeFieldInfoPtr_NoiseLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "NoiseLocal");
			ShaderProperties.NativeFieldInfoPtr_NoiseParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "NoiseParam");
			ShaderProperties.NativeFieldInfoPtr_CameraParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "CameraParams");
			ShaderProperties.NativeFieldInfoPtr_CameraBufferSizeSRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "CameraBufferSizeSRP");
			ShaderProperties.NativeFieldInfoPtr_ColorGradientMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ColorGradientMatrix");
			ShaderProperties.NativeFieldInfoPtr_LocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "LocalToWorldMatrix");
			ShaderProperties.NativeFieldInfoPtr_WorldToLocalMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "WorldToLocalMatrix");
			ShaderProperties.NativeFieldInfoPtr_BlendSrcFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "BlendSrcFactor");
			ShaderProperties.NativeFieldInfoPtr_BlendDstFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "BlendDstFactor");
			ShaderProperties.NativeFieldInfoPtr_DynamicOcclusionDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "DynamicOcclusionDepthTexture");
			ShaderProperties.NativeFieldInfoPtr_DynamicOcclusionDepthProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "DynamicOcclusionDepthProps");
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x00002988 File Offset: 0x00000B88
		public ShaderProperties(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x06007A43 RID: 31299 RVA: 0x001EC058 File Offset: 0x001EA258
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr));
			}
		}

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x06007A44 RID: 31300 RVA: 0x001EC06C File Offset: 0x001EA26C
		// (set) Token: 0x06007A45 RID: 31301 RVA: 0x001EC08A File Offset: 0x001EA28A
		public unsafe static int FadeOutFactor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_FadeOutFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_FadeOutFactor, (void*)(&value));
			}
		}

		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x06007A46 RID: 31302 RVA: 0x001EC09C File Offset: 0x001EA29C
		// (set) Token: 0x06007A47 RID: 31303 RVA: 0x001EC0BA File Offset: 0x001EA2BA
		public unsafe static int ClippingPlaneWS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ClippingPlaneWS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ClippingPlaneWS, (void*)(&value));
			}
		}

		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x06007A48 RID: 31304 RVA: 0x001EC0CC File Offset: 0x001EA2CC
		// (set) Token: 0x06007A49 RID: 31305 RVA: 0x001EC0EA File Offset: 0x001EA2EA
		public unsafe static int ClippingPlaneProps
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ClippingPlaneProps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ClippingPlaneProps, (void*)(&value));
			}
		}

		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x06007A4A RID: 31306 RVA: 0x001EC0FC File Offset: 0x001EA2FC
		// (set) Token: 0x06007A4B RID: 31307 RVA: 0x001EC11A File Offset: 0x001EA31A
		public unsafe static int ConeSlopeCosSin
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ConeSlopeCosSin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ConeSlopeCosSin, (void*)(&value));
			}
		}

		// Token: 0x17002BCC RID: 11212
		// (get) Token: 0x06007A4C RID: 31308 RVA: 0x001EC12C File Offset: 0x001EA32C
		// (set) Token: 0x06007A4D RID: 31309 RVA: 0x001EC14A File Offset: 0x001EA34A
		public unsafe static int ConeRadius
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ConeRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ConeRadius, (void*)(&value));
			}
		}

		// Token: 0x17002BCD RID: 11213
		// (get) Token: 0x06007A4E RID: 31310 RVA: 0x001EC15C File Offset: 0x001EA35C
		// (set) Token: 0x06007A4F RID: 31311 RVA: 0x001EC17A File Offset: 0x001EA37A
		public unsafe static int ConeApexOffsetZ
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ConeApexOffsetZ, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ConeApexOffsetZ, (void*)(&value));
			}
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x06007A50 RID: 31312 RVA: 0x001EC18C File Offset: 0x001EA38C
		// (set) Token: 0x06007A51 RID: 31313 RVA: 0x001EC1AA File Offset: 0x001EA3AA
		public unsafe static int ColorFlat
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ColorFlat, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ColorFlat, (void*)(&value));
			}
		}

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x06007A52 RID: 31314 RVA: 0x001EC1BC File Offset: 0x001EA3BC
		// (set) Token: 0x06007A53 RID: 31315 RVA: 0x001EC1DA File Offset: 0x001EA3DA
		public unsafe static int AlphaInside
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_AlphaInside, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_AlphaInside, (void*)(&value));
			}
		}

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x06007A54 RID: 31316 RVA: 0x001EC1EC File Offset: 0x001EA3EC
		// (set) Token: 0x06007A55 RID: 31317 RVA: 0x001EC20A File Offset: 0x001EA40A
		public unsafe static int AlphaOutside
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_AlphaOutside, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_AlphaOutside, (void*)(&value));
			}
		}

		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x06007A56 RID: 31318 RVA: 0x001EC21C File Offset: 0x001EA41C
		// (set) Token: 0x06007A57 RID: 31319 RVA: 0x001EC23A File Offset: 0x001EA43A
		public unsafe static int AttenuationLerpLinearQuad
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_AttenuationLerpLinearQuad, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_AttenuationLerpLinearQuad, (void*)(&value));
			}
		}

		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x06007A58 RID: 31320 RVA: 0x001EC24C File Offset: 0x001EA44C
		// (set) Token: 0x06007A59 RID: 31321 RVA: 0x001EC26A File Offset: 0x001EA46A
		public unsafe static int DistanceFadeStart
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_DistanceFadeStart, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_DistanceFadeStart, (void*)(&value));
			}
		}

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x06007A5A RID: 31322 RVA: 0x001EC27C File Offset: 0x001EA47C
		// (set) Token: 0x06007A5B RID: 31323 RVA: 0x001EC29A File Offset: 0x001EA49A
		public unsafe static int DistanceFadeEnd
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_DistanceFadeEnd, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_DistanceFadeEnd, (void*)(&value));
			}
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x06007A5C RID: 31324 RVA: 0x001EC2AC File Offset: 0x001EA4AC
		// (set) Token: 0x06007A5D RID: 31325 RVA: 0x001EC2CA File Offset: 0x001EA4CA
		public unsafe static int DistanceCamClipping
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_DistanceCamClipping, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_DistanceCamClipping, (void*)(&value));
			}
		}

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x06007A5E RID: 31326 RVA: 0x001EC2DC File Offset: 0x001EA4DC
		// (set) Token: 0x06007A5F RID: 31327 RVA: 0x001EC2FA File Offset: 0x001EA4FA
		public unsafe static int FresnelPow
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_FresnelPow, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_FresnelPow, (void*)(&value));
			}
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x06007A60 RID: 31328 RVA: 0x001EC30C File Offset: 0x001EA50C
		// (set) Token: 0x06007A61 RID: 31329 RVA: 0x001EC32A File Offset: 0x001EA52A
		public unsafe static int GlareBehind
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlareBehind, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlareBehind, (void*)(&value));
			}
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x06007A62 RID: 31330 RVA: 0x001EC33C File Offset: 0x001EA53C
		// (set) Token: 0x06007A63 RID: 31331 RVA: 0x001EC35A File Offset: 0x001EA55A
		public unsafe static int GlareFrontal
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlareFrontal, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlareFrontal, (void*)(&value));
			}
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x06007A64 RID: 31332 RVA: 0x001EC36C File Offset: 0x001EA56C
		// (set) Token: 0x06007A65 RID: 31333 RVA: 0x001EC38A File Offset: 0x001EA58A
		public unsafe static int DrawCap
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_DrawCap, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_DrawCap, (void*)(&value));
			}
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x06007A66 RID: 31334 RVA: 0x001EC39C File Offset: 0x001EA59C
		// (set) Token: 0x06007A67 RID: 31335 RVA: 0x001EC3BA File Offset: 0x001EA5BA
		public unsafe static int DepthBlendDistance
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&value));
			}
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x06007A68 RID: 31336 RVA: 0x001EC3CC File Offset: 0x001EA5CC
		// (set) Token: 0x06007A69 RID: 31337 RVA: 0x001EC3EA File Offset: 0x001EA5EA
		public unsafe static int NoiseLocal
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_NoiseLocal, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_NoiseLocal, (void*)(&value));
			}
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x06007A6A RID: 31338 RVA: 0x001EC3FC File Offset: 0x001EA5FC
		// (set) Token: 0x06007A6B RID: 31339 RVA: 0x001EC41A File Offset: 0x001EA61A
		public unsafe static int NoiseParam
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_NoiseParam, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_NoiseParam, (void*)(&value));
			}
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x06007A6C RID: 31340 RVA: 0x001EC42C File Offset: 0x001EA62C
		// (set) Token: 0x06007A6D RID: 31341 RVA: 0x001EC44A File Offset: 0x001EA64A
		public unsafe static int CameraParams
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_CameraParams, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_CameraParams, (void*)(&value));
			}
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x06007A6E RID: 31342 RVA: 0x001EC45C File Offset: 0x001EA65C
		// (set) Token: 0x06007A6F RID: 31343 RVA: 0x001EC47A File Offset: 0x001EA67A
		public unsafe static int CameraBufferSizeSRP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_CameraBufferSizeSRP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_CameraBufferSizeSRP, (void*)(&value));
			}
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x06007A70 RID: 31344 RVA: 0x001EC48C File Offset: 0x001EA68C
		// (set) Token: 0x06007A71 RID: 31345 RVA: 0x001EC4AA File Offset: 0x001EA6AA
		public unsafe static int ColorGradientMatrix
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ColorGradientMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ColorGradientMatrix, (void*)(&value));
			}
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x06007A72 RID: 31346 RVA: 0x001EC4BC File Offset: 0x001EA6BC
		// (set) Token: 0x06007A73 RID: 31347 RVA: 0x001EC4DA File Offset: 0x001EA6DA
		public unsafe static int LocalToWorldMatrix
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_LocalToWorldMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_LocalToWorldMatrix, (void*)(&value));
			}
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x06007A74 RID: 31348 RVA: 0x001EC4EC File Offset: 0x001EA6EC
		// (set) Token: 0x06007A75 RID: 31349 RVA: 0x001EC50A File Offset: 0x001EA70A
		public unsafe static int WorldToLocalMatrix
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_WorldToLocalMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_WorldToLocalMatrix, (void*)(&value));
			}
		}

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x06007A76 RID: 31350 RVA: 0x001EC51C File Offset: 0x001EA71C
		// (set) Token: 0x06007A77 RID: 31351 RVA: 0x001EC53A File Offset: 0x001EA73A
		public unsafe static int BlendSrcFactor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_BlendSrcFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_BlendSrcFactor, (void*)(&value));
			}
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x06007A78 RID: 31352 RVA: 0x001EC54C File Offset: 0x001EA74C
		// (set) Token: 0x06007A79 RID: 31353 RVA: 0x001EC56A File Offset: 0x001EA76A
		public unsafe static int BlendDstFactor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_BlendDstFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_BlendDstFactor, (void*)(&value));
			}
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x06007A7A RID: 31354 RVA: 0x001EC57C File Offset: 0x001EA77C
		// (set) Token: 0x06007A7B RID: 31355 RVA: 0x001EC59A File Offset: 0x001EA79A
		public unsafe static int DynamicOcclusionDepthTexture
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_DynamicOcclusionDepthTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_DynamicOcclusionDepthTexture, (void*)(&value));
			}
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x06007A7C RID: 31356 RVA: 0x001EC5AC File Offset: 0x001EA7AC
		// (set) Token: 0x06007A7D RID: 31357 RVA: 0x001EC5CA File Offset: 0x001EA7CA
		public unsafe static int DynamicOcclusionDepthProps
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_DynamicOcclusionDepthProps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_DynamicOcclusionDepthProps, (void*)(&value));
			}
		}

		// Token: 0x04004E53 RID: 20051
		private static readonly IntPtr NativeFieldInfoPtr_FadeOutFactor;

		// Token: 0x04004E54 RID: 20052
		private static readonly IntPtr NativeFieldInfoPtr_ClippingPlaneWS;

		// Token: 0x04004E55 RID: 20053
		private static readonly IntPtr NativeFieldInfoPtr_ClippingPlaneProps;

		// Token: 0x04004E56 RID: 20054
		private static readonly IntPtr NativeFieldInfoPtr_ConeSlopeCosSin;

		// Token: 0x04004E57 RID: 20055
		private static readonly IntPtr NativeFieldInfoPtr_ConeRadius;

		// Token: 0x04004E58 RID: 20056
		private static readonly IntPtr NativeFieldInfoPtr_ConeApexOffsetZ;

		// Token: 0x04004E59 RID: 20057
		private static readonly IntPtr NativeFieldInfoPtr_ColorFlat;

		// Token: 0x04004E5A RID: 20058
		private static readonly IntPtr NativeFieldInfoPtr_AlphaInside;

		// Token: 0x04004E5B RID: 20059
		private static readonly IntPtr NativeFieldInfoPtr_AlphaOutside;

		// Token: 0x04004E5C RID: 20060
		private static readonly IntPtr NativeFieldInfoPtr_AttenuationLerpLinearQuad;

		// Token: 0x04004E5D RID: 20061
		private static readonly IntPtr NativeFieldInfoPtr_DistanceFadeStart;

		// Token: 0x04004E5E RID: 20062
		private static readonly IntPtr NativeFieldInfoPtr_DistanceFadeEnd;

		// Token: 0x04004E5F RID: 20063
		private static readonly IntPtr NativeFieldInfoPtr_DistanceCamClipping;

		// Token: 0x04004E60 RID: 20064
		private static readonly IntPtr NativeFieldInfoPtr_FresnelPow;

		// Token: 0x04004E61 RID: 20065
		private static readonly IntPtr NativeFieldInfoPtr_GlareBehind;

		// Token: 0x04004E62 RID: 20066
		private static readonly IntPtr NativeFieldInfoPtr_GlareFrontal;

		// Token: 0x04004E63 RID: 20067
		private static readonly IntPtr NativeFieldInfoPtr_DrawCap;

		// Token: 0x04004E64 RID: 20068
		private static readonly IntPtr NativeFieldInfoPtr_DepthBlendDistance;

		// Token: 0x04004E65 RID: 20069
		private static readonly IntPtr NativeFieldInfoPtr_NoiseLocal;

		// Token: 0x04004E66 RID: 20070
		private static readonly IntPtr NativeFieldInfoPtr_NoiseParam;

		// Token: 0x04004E67 RID: 20071
		private static readonly IntPtr NativeFieldInfoPtr_CameraParams;

		// Token: 0x04004E68 RID: 20072
		private static readonly IntPtr NativeFieldInfoPtr_CameraBufferSizeSRP;

		// Token: 0x04004E69 RID: 20073
		private static readonly IntPtr NativeFieldInfoPtr_ColorGradientMatrix;

		// Token: 0x04004E6A RID: 20074
		private static readonly IntPtr NativeFieldInfoPtr_LocalToWorldMatrix;

		// Token: 0x04004E6B RID: 20075
		private static readonly IntPtr NativeFieldInfoPtr_WorldToLocalMatrix;

		// Token: 0x04004E6C RID: 20076
		private static readonly IntPtr NativeFieldInfoPtr_BlendSrcFactor;

		// Token: 0x04004E6D RID: 20077
		private static readonly IntPtr NativeFieldInfoPtr_BlendDstFactor;

		// Token: 0x04004E6E RID: 20078
		private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionDepthTexture;

		// Token: 0x04004E6F RID: 20079
		private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionDepthProps;
	}
}
