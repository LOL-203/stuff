using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005C6 RID: 1478
	public static class Consts : Il2CppSystem.Object
	{
		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x06007896 RID: 30870 RVA: 0x001E6724 File Offset: 0x001E4924
		public unsafe static HideFlags ProceduralObjectsHideFlags
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Consts.NativeMethodInfoPtr_get_ProceduralObjectsHideFlags_Public_Static_get_HideFlags_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06007897 RID: 30871 RVA: 0x001E6768 File Offset: 0x001E4968
		// Note: this type is marked as 'beforefieldinit'.
		static Consts()
		{
			Il2CppClassPointerStore<Consts>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Consts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts>.NativeClassPtr);
			Consts.NativeFieldInfoPtr_HelpUrlBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "HelpUrlBase");
			Consts.NativeFieldInfoPtr_HelpUrlBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "HelpUrlBeam");
			Consts.NativeFieldInfoPtr_HelpUrlDustParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "HelpUrlDustParticles");
			Consts.NativeFieldInfoPtr_HelpUrlDynamicOcclusionRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "HelpUrlDynamicOcclusionRaycasting");
			Consts.NativeFieldInfoPtr_HelpUrlDynamicOcclusionDepthBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "HelpUrlDynamicOcclusionDepthBuffer");
			Consts.NativeFieldInfoPtr_HelpUrlTriggerZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "HelpUrlTriggerZone");
			Consts.NativeFieldInfoPtr_HelpUrlConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "HelpUrlConfig");
			Consts.NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ProceduralObjectsVisibleInEditor");
			Consts.NativeFieldInfoPtr_FlatColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "FlatColor");
			Consts.NativeFieldInfoPtr_ColorModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ColorModeDefault");
			Consts.NativeFieldInfoPtr_IntensityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "IntensityDefault");
			Consts.NativeFieldInfoPtr_IntensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "IntensityMin");
			Consts.NativeFieldInfoPtr_IntensityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "IntensityMax");
			Consts.NativeFieldInfoPtr_SpotAngleDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "SpotAngleDefault");
			Consts.NativeFieldInfoPtr_SpotAngleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "SpotAngleMin");
			Consts.NativeFieldInfoPtr_SpotAngleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "SpotAngleMax");
			Consts.NativeFieldInfoPtr_ConeRadiusStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ConeRadiusStart");
			Consts.NativeFieldInfoPtr_GeomMeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "GeomMeshType");
			Consts.NativeFieldInfoPtr_GeomSidesDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "GeomSidesDefault");
			Consts.NativeFieldInfoPtr_GeomSidesMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "GeomSidesMin");
			Consts.NativeFieldInfoPtr_GeomSidesMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "GeomSidesMax");
			Consts.NativeFieldInfoPtr_GeomSegmentsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "GeomSegmentsDefault");
			Consts.NativeFieldInfoPtr_GeomSegmentsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "GeomSegmentsMin");
			Consts.NativeFieldInfoPtr_GeomSegmentsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "GeomSegmentsMax");
			Consts.NativeFieldInfoPtr_GeomCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "GeomCap");
			Consts.NativeFieldInfoPtr_AttenuationEquationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "AttenuationEquationDefault");
			Consts.NativeFieldInfoPtr_AttenuationCustomBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "AttenuationCustomBlending");
			Consts.NativeFieldInfoPtr_FallOffStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "FallOffStart");
			Consts.NativeFieldInfoPtr_FallOffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "FallOffEnd");
			Consts.NativeFieldInfoPtr_FallOffDistancesMinThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "FallOffDistancesMinThreshold");
			Consts.NativeFieldInfoPtr_DepthBlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DepthBlendDistance");
			Consts.NativeFieldInfoPtr_CameraClippingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "CameraClippingDistance");
			Consts.NativeFieldInfoPtr_FresnelPowMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "FresnelPowMaxValue");
			Consts.NativeFieldInfoPtr_FresnelPow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "FresnelPow");
			Consts.NativeFieldInfoPtr_GlareFrontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "GlareFrontal");
			Consts.NativeFieldInfoPtr_GlareBehind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "GlareBehind");
			Consts.NativeFieldInfoPtr_NoiseModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "NoiseModeDefault");
			Consts.NativeFieldInfoPtr_NoiseIntensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "NoiseIntensityMin");
			Consts.NativeFieldInfoPtr_NoiseIntensityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "NoiseIntensityMax");
			Consts.NativeFieldInfoPtr_NoiseIntensityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "NoiseIntensityDefault");
			Consts.NativeFieldInfoPtr_NoiseScaleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "NoiseScaleMin");
			Consts.NativeFieldInfoPtr_NoiseScaleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "NoiseScaleMax");
			Consts.NativeFieldInfoPtr_NoiseScaleDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "NoiseScaleDefault");
			Consts.NativeFieldInfoPtr_NoiseVelocityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "NoiseVelocityDefault");
			Consts.NativeFieldInfoPtr_BlendingModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "BlendingModeDefault");
			Consts.NativeFieldInfoPtr_FadeOutBeginDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "FadeOutBeginDefault");
			Consts.NativeFieldInfoPtr_FadeOutEndDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "FadeOutEndDefault");
			Consts.NativeFieldInfoPtr_DynOcclusionLayerMaskDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionLayerMaskDefault");
			Consts.NativeFieldInfoPtr_DynOcclusionFadeDistanceToSurfaceDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionFadeDistanceToSurfaceDefault");
			Consts.NativeFieldInfoPtr_DynamicOcclusionUpdateRateDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynamicOcclusionUpdateRateDefault");
			Consts.NativeFieldInfoPtr_DynOcclusionWaitFramesCountDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionWaitFramesCountDefault");
			Consts.NativeFieldInfoPtr_DynOcclusionRaycastingDimensionsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionRaycastingDimensionsDefault");
			Consts.NativeFieldInfoPtr_DynOcclusionRaycastingConsiderTriggersDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionRaycastingConsiderTriggersDefault");
			Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMinOccluderAreaDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionRaycastingMinOccluderAreaDefault");
			Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMinSurfaceRatioDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionRaycastingMinSurfaceRatioDefault");
			Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMinSurfaceRatioMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionRaycastingMinSurfaceRatioMin");
			Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMinSurfaceRatioMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionRaycastingMinSurfaceRatioMax");
			Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMaxSurfaceDotDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionRaycastingMaxSurfaceDotDefault");
			Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMaxSurfaceAngleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionRaycastingMaxSurfaceAngleMin");
			Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMaxSurfaceAngleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionRaycastingMaxSurfaceAngleMax");
			Consts.NativeFieldInfoPtr_DynOcclusionRaycastingPlaneAlignmentDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionRaycastingPlaneAlignmentDefault");
			Consts.NativeFieldInfoPtr_DynOcclusionRaycastingPlaneOffsetDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionRaycastingPlaneOffsetDefault");
			Consts.NativeFieldInfoPtr_DynOcclusionDepthBufferDepthMapResolutionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionDepthBufferDepthMapResolutionDefault");
			Consts.NativeFieldInfoPtr_DynOcclusionDepthBufferOcclusionCullingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusionDepthBufferOcclusionCullingDefault");
			Consts.NativeFieldInfoPtr_ConfigGeometryOverrideLayerDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ConfigGeometryOverrideLayerDefault");
			Consts.NativeFieldInfoPtr_ConfigGeometryLayerIDDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ConfigGeometryLayerIDDefault");
			Consts.NativeFieldInfoPtr_ConfigGeometryTagDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ConfigGeometryTagDefault");
			Consts.NativeFieldInfoPtr_ConfigFadeOutCameraTagDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ConfigFadeOutCameraTagDefault");
			Consts.NativeFieldInfoPtr_ConfigGeometryRenderQueueDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ConfigGeometryRenderQueueDefault");
			Consts.NativeFieldInfoPtr_ConfigGeometryRenderPipelineDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ConfigGeometryRenderPipelineDefault");
			Consts.NativeFieldInfoPtr_ConfigGeometryRenderingModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ConfigGeometryRenderingModeDefault");
			Consts.NativeFieldInfoPtr_ConfigNoise3DSizeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ConfigNoise3DSizeDefault");
			Consts.NativeFieldInfoPtr_ConfigSharedMeshSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ConfigSharedMeshSides");
			Consts.NativeFieldInfoPtr_ConfigSharedMeshSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "ConfigSharedMeshSegments");
			Consts.NativeMethodInfoPtr_get_ProceduralObjectsHideFlags_Public_Static_get_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts>.NativeClassPtr, 100672953);
		}

		// Token: 0x06007898 RID: 30872 RVA: 0x00002988 File Offset: 0x00000B88
		public Consts(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x06007899 RID: 30873 RVA: 0x001E6D74 File Offset: 0x001E4F74
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Consts>.NativeClassPtr));
			}
		}

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x0600789A RID: 30874 RVA: 0x001E6D88 File Offset: 0x001E4F88
		// (set) Token: 0x0600789B RID: 30875 RVA: 0x001E6DA8 File Offset: 0x001E4FA8
		public unsafe static string HelpUrlBase
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_HelpUrlBase, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_HelpUrlBase, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x0600789C RID: 30876 RVA: 0x001E6DC0 File Offset: 0x001E4FC0
		// (set) Token: 0x0600789D RID: 30877 RVA: 0x001E6DE0 File Offset: 0x001E4FE0
		public unsafe static string HelpUrlBeam
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_HelpUrlBeam, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_HelpUrlBeam, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x0600789E RID: 30878 RVA: 0x001E6DF8 File Offset: 0x001E4FF8
		// (set) Token: 0x0600789F RID: 30879 RVA: 0x001E6E18 File Offset: 0x001E5018
		public unsafe static string HelpUrlDustParticles
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_HelpUrlDustParticles, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_HelpUrlDustParticles, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x060078A0 RID: 30880 RVA: 0x001E6E30 File Offset: 0x001E5030
		// (set) Token: 0x060078A1 RID: 30881 RVA: 0x001E6E50 File Offset: 0x001E5050
		public unsafe static string HelpUrlDynamicOcclusionRaycasting
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_HelpUrlDynamicOcclusionRaycasting, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_HelpUrlDynamicOcclusionRaycasting, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x060078A2 RID: 30882 RVA: 0x001E6E68 File Offset: 0x001E5068
		// (set) Token: 0x060078A3 RID: 30883 RVA: 0x001E6E88 File Offset: 0x001E5088
		public unsafe static string HelpUrlDynamicOcclusionDepthBuffer
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_HelpUrlDynamicOcclusionDepthBuffer, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_HelpUrlDynamicOcclusionDepthBuffer, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x060078A4 RID: 30884 RVA: 0x001E6EA0 File Offset: 0x001E50A0
		// (set) Token: 0x060078A5 RID: 30885 RVA: 0x001E6EC0 File Offset: 0x001E50C0
		public unsafe static string HelpUrlTriggerZone
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_HelpUrlTriggerZone, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_HelpUrlTriggerZone, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B21 RID: 11041
		// (get) Token: 0x060078A6 RID: 30886 RVA: 0x001E6ED8 File Offset: 0x001E50D8
		// (set) Token: 0x060078A7 RID: 30887 RVA: 0x001E6EF8 File Offset: 0x001E50F8
		public unsafe static string HelpUrlConfig
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_HelpUrlConfig, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_HelpUrlConfig, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B22 RID: 11042
		// (get) Token: 0x060078A8 RID: 30888 RVA: 0x001E6F10 File Offset: 0x001E5110
		// (set) Token: 0x060078A9 RID: 30889 RVA: 0x001E6F2E File Offset: 0x001E512E
		public unsafe static bool ProceduralObjectsVisibleInEditor
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor, (void*)(&value));
			}
		}

		// Token: 0x17002B23 RID: 11043
		// (get) Token: 0x060078AA RID: 30890 RVA: 0x001E6F40 File Offset: 0x001E5140
		// (set) Token: 0x060078AB RID: 30891 RVA: 0x001E6F5E File Offset: 0x001E515E
		public unsafe static Color FlatColor
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_FlatColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_FlatColor, (void*)(&value));
			}
		}

		// Token: 0x17002B24 RID: 11044
		// (get) Token: 0x060078AC RID: 30892 RVA: 0x001E6F70 File Offset: 0x001E5170
		// (set) Token: 0x060078AD RID: 30893 RVA: 0x001E6F8E File Offset: 0x001E518E
		public unsafe static ColorMode ColorModeDefault
		{
			get
			{
				ColorMode result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ColorModeDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ColorModeDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B25 RID: 11045
		// (get) Token: 0x060078AE RID: 30894 RVA: 0x001E6FA0 File Offset: 0x001E51A0
		// (set) Token: 0x060078AF RID: 30895 RVA: 0x001E6FBE File Offset: 0x001E51BE
		public unsafe static float IntensityDefault
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_IntensityDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_IntensityDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B26 RID: 11046
		// (get) Token: 0x060078B0 RID: 30896 RVA: 0x001E6FD0 File Offset: 0x001E51D0
		// (set) Token: 0x060078B1 RID: 30897 RVA: 0x001E6FEE File Offset: 0x001E51EE
		public unsafe static float IntensityMin
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_IntensityMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_IntensityMin, (void*)(&value));
			}
		}

		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x060078B2 RID: 30898 RVA: 0x001E7000 File Offset: 0x001E5200
		// (set) Token: 0x060078B3 RID: 30899 RVA: 0x001E701E File Offset: 0x001E521E
		public unsafe static float IntensityMax
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_IntensityMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_IntensityMax, (void*)(&value));
			}
		}

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x060078B4 RID: 30900 RVA: 0x001E7030 File Offset: 0x001E5230
		// (set) Token: 0x060078B5 RID: 30901 RVA: 0x001E704E File Offset: 0x001E524E
		public unsafe static float SpotAngleDefault
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_SpotAngleDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_SpotAngleDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x060078B6 RID: 30902 RVA: 0x001E7060 File Offset: 0x001E5260
		// (set) Token: 0x060078B7 RID: 30903 RVA: 0x001E707E File Offset: 0x001E527E
		public unsafe static float SpotAngleMin
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_SpotAngleMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_SpotAngleMin, (void*)(&value));
			}
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x060078B8 RID: 30904 RVA: 0x001E7090 File Offset: 0x001E5290
		// (set) Token: 0x060078B9 RID: 30905 RVA: 0x001E70AE File Offset: 0x001E52AE
		public unsafe static float SpotAngleMax
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_SpotAngleMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_SpotAngleMax, (void*)(&value));
			}
		}

		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x060078BA RID: 30906 RVA: 0x001E70C0 File Offset: 0x001E52C0
		// (set) Token: 0x060078BB RID: 30907 RVA: 0x001E70DE File Offset: 0x001E52DE
		public unsafe static float ConeRadiusStart
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ConeRadiusStart, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ConeRadiusStart, (void*)(&value));
			}
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x060078BC RID: 30908 RVA: 0x001E70F0 File Offset: 0x001E52F0
		// (set) Token: 0x060078BD RID: 30909 RVA: 0x001E710E File Offset: 0x001E530E
		public unsafe static MeshType GeomMeshType
		{
			get
			{
				MeshType result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_GeomMeshType, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_GeomMeshType, (void*)(&value));
			}
		}

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x060078BE RID: 30910 RVA: 0x001E7120 File Offset: 0x001E5320
		// (set) Token: 0x060078BF RID: 30911 RVA: 0x001E713E File Offset: 0x001E533E
		public unsafe static int GeomSidesDefault
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_GeomSidesDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_GeomSidesDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x060078C0 RID: 30912 RVA: 0x001E7150 File Offset: 0x001E5350
		// (set) Token: 0x060078C1 RID: 30913 RVA: 0x001E716E File Offset: 0x001E536E
		public unsafe static int GeomSidesMin
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_GeomSidesMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_GeomSidesMin, (void*)(&value));
			}
		}

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x060078C2 RID: 30914 RVA: 0x001E7180 File Offset: 0x001E5380
		// (set) Token: 0x060078C3 RID: 30915 RVA: 0x001E719E File Offset: 0x001E539E
		public unsafe static int GeomSidesMax
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_GeomSidesMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_GeomSidesMax, (void*)(&value));
			}
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x060078C4 RID: 30916 RVA: 0x001E71B0 File Offset: 0x001E53B0
		// (set) Token: 0x060078C5 RID: 30917 RVA: 0x001E71CE File Offset: 0x001E53CE
		public unsafe static int GeomSegmentsDefault
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_GeomSegmentsDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_GeomSegmentsDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x060078C6 RID: 30918 RVA: 0x001E71E0 File Offset: 0x001E53E0
		// (set) Token: 0x060078C7 RID: 30919 RVA: 0x001E71FE File Offset: 0x001E53FE
		public unsafe static int GeomSegmentsMin
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_GeomSegmentsMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_GeomSegmentsMin, (void*)(&value));
			}
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x060078C8 RID: 30920 RVA: 0x001E7210 File Offset: 0x001E5410
		// (set) Token: 0x060078C9 RID: 30921 RVA: 0x001E722E File Offset: 0x001E542E
		public unsafe static int GeomSegmentsMax
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_GeomSegmentsMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_GeomSegmentsMax, (void*)(&value));
			}
		}

		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x060078CA RID: 30922 RVA: 0x001E7240 File Offset: 0x001E5440
		// (set) Token: 0x060078CB RID: 30923 RVA: 0x001E725E File Offset: 0x001E545E
		public unsafe static bool GeomCap
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_GeomCap, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_GeomCap, (void*)(&value));
			}
		}

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x060078CC RID: 30924 RVA: 0x001E7270 File Offset: 0x001E5470
		// (set) Token: 0x060078CD RID: 30925 RVA: 0x001E728E File Offset: 0x001E548E
		public unsafe static AttenuationEquation AttenuationEquationDefault
		{
			get
			{
				AttenuationEquation result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x060078CE RID: 30926 RVA: 0x001E72A0 File Offset: 0x001E54A0
		// (set) Token: 0x060078CF RID: 30927 RVA: 0x001E72BE File Offset: 0x001E54BE
		public unsafe static float AttenuationCustomBlending
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_AttenuationCustomBlending, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_AttenuationCustomBlending, (void*)(&value));
			}
		}

		// Token: 0x17002B36 RID: 11062
		// (get) Token: 0x060078D0 RID: 30928 RVA: 0x001E72D0 File Offset: 0x001E54D0
		// (set) Token: 0x060078D1 RID: 30929 RVA: 0x001E72EE File Offset: 0x001E54EE
		public unsafe static float FallOffStart
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_FallOffStart, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_FallOffStart, (void*)(&value));
			}
		}

		// Token: 0x17002B37 RID: 11063
		// (get) Token: 0x060078D2 RID: 30930 RVA: 0x001E7300 File Offset: 0x001E5500
		// (set) Token: 0x060078D3 RID: 30931 RVA: 0x001E731E File Offset: 0x001E551E
		public unsafe static float FallOffEnd
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_FallOffEnd, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_FallOffEnd, (void*)(&value));
			}
		}

		// Token: 0x17002B38 RID: 11064
		// (get) Token: 0x060078D4 RID: 30932 RVA: 0x001E7330 File Offset: 0x001E5530
		// (set) Token: 0x060078D5 RID: 30933 RVA: 0x001E734E File Offset: 0x001E554E
		public unsafe static float FallOffDistancesMinThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_FallOffDistancesMinThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_FallOffDistancesMinThreshold, (void*)(&value));
			}
		}

		// Token: 0x17002B39 RID: 11065
		// (get) Token: 0x060078D6 RID: 30934 RVA: 0x001E7360 File Offset: 0x001E5560
		// (set) Token: 0x060078D7 RID: 30935 RVA: 0x001E737E File Offset: 0x001E557E
		public unsafe static float DepthBlendDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&value));
			}
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x060078D8 RID: 30936 RVA: 0x001E7390 File Offset: 0x001E5590
		// (set) Token: 0x060078D9 RID: 30937 RVA: 0x001E73AE File Offset: 0x001E55AE
		public unsafe static float CameraClippingDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_CameraClippingDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_CameraClippingDistance, (void*)(&value));
			}
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x060078DA RID: 30938 RVA: 0x001E73C0 File Offset: 0x001E55C0
		// (set) Token: 0x060078DB RID: 30939 RVA: 0x001E73DE File Offset: 0x001E55DE
		public unsafe static float FresnelPowMaxValue
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_FresnelPowMaxValue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_FresnelPowMaxValue, (void*)(&value));
			}
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x060078DC RID: 30940 RVA: 0x001E73F0 File Offset: 0x001E55F0
		// (set) Token: 0x060078DD RID: 30941 RVA: 0x001E740E File Offset: 0x001E560E
		public unsafe static float FresnelPow
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_FresnelPow, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_FresnelPow, (void*)(&value));
			}
		}

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x060078DE RID: 30942 RVA: 0x001E7420 File Offset: 0x001E5620
		// (set) Token: 0x060078DF RID: 30943 RVA: 0x001E743E File Offset: 0x001E563E
		public unsafe static float GlareFrontal
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_GlareFrontal, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_GlareFrontal, (void*)(&value));
			}
		}

		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x060078E0 RID: 30944 RVA: 0x001E7450 File Offset: 0x001E5650
		// (set) Token: 0x060078E1 RID: 30945 RVA: 0x001E746E File Offset: 0x001E566E
		public unsafe static float GlareBehind
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_GlareBehind, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_GlareBehind, (void*)(&value));
			}
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x060078E2 RID: 30946 RVA: 0x001E7480 File Offset: 0x001E5680
		// (set) Token: 0x060078E3 RID: 30947 RVA: 0x001E749E File Offset: 0x001E569E
		public unsafe static NoiseMode NoiseModeDefault
		{
			get
			{
				NoiseMode result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_NoiseModeDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_NoiseModeDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x060078E4 RID: 30948 RVA: 0x001E74B0 File Offset: 0x001E56B0
		// (set) Token: 0x060078E5 RID: 30949 RVA: 0x001E74CE File Offset: 0x001E56CE
		public unsafe static float NoiseIntensityMin
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_NoiseIntensityMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_NoiseIntensityMin, (void*)(&value));
			}
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x060078E6 RID: 30950 RVA: 0x001E74E0 File Offset: 0x001E56E0
		// (set) Token: 0x060078E7 RID: 30951 RVA: 0x001E74FE File Offset: 0x001E56FE
		public unsafe static float NoiseIntensityMax
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_NoiseIntensityMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_NoiseIntensityMax, (void*)(&value));
			}
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x060078E8 RID: 30952 RVA: 0x001E7510 File Offset: 0x001E5710
		// (set) Token: 0x060078E9 RID: 30953 RVA: 0x001E752E File Offset: 0x001E572E
		public unsafe static float NoiseIntensityDefault
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_NoiseIntensityDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_NoiseIntensityDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x060078EA RID: 30954 RVA: 0x001E7540 File Offset: 0x001E5740
		// (set) Token: 0x060078EB RID: 30955 RVA: 0x001E755E File Offset: 0x001E575E
		public unsafe static float NoiseScaleMin
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_NoiseScaleMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_NoiseScaleMin, (void*)(&value));
			}
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x060078EC RID: 30956 RVA: 0x001E7570 File Offset: 0x001E5770
		// (set) Token: 0x060078ED RID: 30957 RVA: 0x001E758E File Offset: 0x001E578E
		public unsafe static float NoiseScaleMax
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_NoiseScaleMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_NoiseScaleMax, (void*)(&value));
			}
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x060078EE RID: 30958 RVA: 0x001E75A0 File Offset: 0x001E57A0
		// (set) Token: 0x060078EF RID: 30959 RVA: 0x001E75BE File Offset: 0x001E57BE
		public unsafe static float NoiseScaleDefault
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_NoiseScaleDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_NoiseScaleDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x060078F0 RID: 30960 RVA: 0x001E75D0 File Offset: 0x001E57D0
		// (set) Token: 0x060078F1 RID: 30961 RVA: 0x001E75EE File Offset: 0x001E57EE
		public unsafe static Vector3 NoiseVelocityDefault
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_NoiseVelocityDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_NoiseVelocityDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x060078F2 RID: 30962 RVA: 0x001E7600 File Offset: 0x001E5800
		// (set) Token: 0x060078F3 RID: 30963 RVA: 0x001E761E File Offset: 0x001E581E
		public unsafe static BlendingMode BlendingModeDefault
		{
			get
			{
				BlendingMode result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_BlendingModeDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_BlendingModeDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x060078F4 RID: 30964 RVA: 0x001E7630 File Offset: 0x001E5830
		// (set) Token: 0x060078F5 RID: 30965 RVA: 0x001E764E File Offset: 0x001E584E
		public unsafe static float FadeOutBeginDefault
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_FadeOutBeginDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_FadeOutBeginDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x060078F6 RID: 30966 RVA: 0x001E7660 File Offset: 0x001E5860
		// (set) Token: 0x060078F7 RID: 30967 RVA: 0x001E767E File Offset: 0x001E587E
		public unsafe static float FadeOutEndDefault
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_FadeOutEndDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_FadeOutEndDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x060078F8 RID: 30968 RVA: 0x001E7690 File Offset: 0x001E5890
		// (set) Token: 0x060078F9 RID: 30969 RVA: 0x001E76AE File Offset: 0x001E58AE
		public unsafe static LayerMask DynOcclusionLayerMaskDefault
		{
			get
			{
				LayerMask result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionLayerMaskDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionLayerMaskDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x060078FA RID: 30970 RVA: 0x001E76C0 File Offset: 0x001E58C0
		// (set) Token: 0x060078FB RID: 30971 RVA: 0x001E76DE File Offset: 0x001E58DE
		public unsafe static float DynOcclusionFadeDistanceToSurfaceDefault
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionFadeDistanceToSurfaceDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionFadeDistanceToSurfaceDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x060078FC RID: 30972 RVA: 0x001E76F0 File Offset: 0x001E58F0
		// (set) Token: 0x060078FD RID: 30973 RVA: 0x001E770E File Offset: 0x001E590E
		public unsafe static DynamicOcclusionUpdateRate DynamicOcclusionUpdateRateDefault
		{
			get
			{
				DynamicOcclusionUpdateRate result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynamicOcclusionUpdateRateDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynamicOcclusionUpdateRateDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x060078FE RID: 30974 RVA: 0x001E7720 File Offset: 0x001E5920
		// (set) Token: 0x060078FF RID: 30975 RVA: 0x001E773E File Offset: 0x001E593E
		public unsafe static int DynOcclusionWaitFramesCountDefault
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionWaitFramesCountDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionWaitFramesCountDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x06007900 RID: 30976 RVA: 0x001E7750 File Offset: 0x001E5950
		// (set) Token: 0x06007901 RID: 30977 RVA: 0x001E776E File Offset: 0x001E596E
		public unsafe static OccluderDimensions DynOcclusionRaycastingDimensionsDefault
		{
			get
			{
				OccluderDimensions result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingDimensionsDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingDimensionsDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x06007902 RID: 30978 RVA: 0x001E7780 File Offset: 0x001E5980
		// (set) Token: 0x06007903 RID: 30979 RVA: 0x001E779E File Offset: 0x001E599E
		public unsafe static bool DynOcclusionRaycastingConsiderTriggersDefault
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingConsiderTriggersDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingConsiderTriggersDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x06007904 RID: 30980 RVA: 0x001E77B0 File Offset: 0x001E59B0
		// (set) Token: 0x06007905 RID: 30981 RVA: 0x001E77CE File Offset: 0x001E59CE
		public unsafe static float DynOcclusionRaycastingMinOccluderAreaDefault
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMinOccluderAreaDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMinOccluderAreaDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x06007906 RID: 30982 RVA: 0x001E77E0 File Offset: 0x001E59E0
		// (set) Token: 0x06007907 RID: 30983 RVA: 0x001E77FE File Offset: 0x001E59FE
		public unsafe static float DynOcclusionRaycastingMinSurfaceRatioDefault
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMinSurfaceRatioDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMinSurfaceRatioDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x06007908 RID: 30984 RVA: 0x001E7810 File Offset: 0x001E5A10
		// (set) Token: 0x06007909 RID: 30985 RVA: 0x001E782E File Offset: 0x001E5A2E
		public unsafe static float DynOcclusionRaycastingMinSurfaceRatioMin
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMinSurfaceRatioMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMinSurfaceRatioMin, (void*)(&value));
			}
		}

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x0600790A RID: 30986 RVA: 0x001E7840 File Offset: 0x001E5A40
		// (set) Token: 0x0600790B RID: 30987 RVA: 0x001E785E File Offset: 0x001E5A5E
		public unsafe static float DynOcclusionRaycastingMinSurfaceRatioMax
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMinSurfaceRatioMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMinSurfaceRatioMax, (void*)(&value));
			}
		}

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x0600790C RID: 30988 RVA: 0x001E7870 File Offset: 0x001E5A70
		// (set) Token: 0x0600790D RID: 30989 RVA: 0x001E788E File Offset: 0x001E5A8E
		public unsafe static float DynOcclusionRaycastingMaxSurfaceDotDefault
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMaxSurfaceDotDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMaxSurfaceDotDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x0600790E RID: 30990 RVA: 0x001E78A0 File Offset: 0x001E5AA0
		// (set) Token: 0x0600790F RID: 30991 RVA: 0x001E78BE File Offset: 0x001E5ABE
		public unsafe static float DynOcclusionRaycastingMaxSurfaceAngleMin
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMaxSurfaceAngleMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMaxSurfaceAngleMin, (void*)(&value));
			}
		}

		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x06007910 RID: 30992 RVA: 0x001E78D0 File Offset: 0x001E5AD0
		// (set) Token: 0x06007911 RID: 30993 RVA: 0x001E78EE File Offset: 0x001E5AEE
		public unsafe static float DynOcclusionRaycastingMaxSurfaceAngleMax
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMaxSurfaceAngleMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingMaxSurfaceAngleMax, (void*)(&value));
			}
		}

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x06007912 RID: 30994 RVA: 0x001E7900 File Offset: 0x001E5B00
		// (set) Token: 0x06007913 RID: 30995 RVA: 0x001E791E File Offset: 0x001E5B1E
		public unsafe static PlaneAlignment DynOcclusionRaycastingPlaneAlignmentDefault
		{
			get
			{
				PlaneAlignment result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingPlaneAlignmentDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingPlaneAlignmentDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x06007914 RID: 30996 RVA: 0x001E7930 File Offset: 0x001E5B30
		// (set) Token: 0x06007915 RID: 30997 RVA: 0x001E794E File Offset: 0x001E5B4E
		public unsafe static float DynOcclusionRaycastingPlaneOffsetDefault
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingPlaneOffsetDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionRaycastingPlaneOffsetDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x06007916 RID: 30998 RVA: 0x001E7960 File Offset: 0x001E5B60
		// (set) Token: 0x06007917 RID: 30999 RVA: 0x001E797E File Offset: 0x001E5B7E
		public unsafe static int DynOcclusionDepthBufferDepthMapResolutionDefault
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionDepthBufferDepthMapResolutionDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionDepthBufferDepthMapResolutionDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x06007918 RID: 31000 RVA: 0x001E7990 File Offset: 0x001E5B90
		// (set) Token: 0x06007919 RID: 31001 RVA: 0x001E79AE File Offset: 0x001E5BAE
		public unsafe static bool DynOcclusionDepthBufferOcclusionCullingDefault
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_DynOcclusionDepthBufferOcclusionCullingDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_DynOcclusionDepthBufferOcclusionCullingDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x0600791A RID: 31002 RVA: 0x001E79C0 File Offset: 0x001E5BC0
		// (set) Token: 0x0600791B RID: 31003 RVA: 0x001E79DE File Offset: 0x001E5BDE
		public unsafe static bool ConfigGeometryOverrideLayerDefault
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ConfigGeometryOverrideLayerDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ConfigGeometryOverrideLayerDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x0600791C RID: 31004 RVA: 0x001E79F0 File Offset: 0x001E5BF0
		// (set) Token: 0x0600791D RID: 31005 RVA: 0x001E7A0E File Offset: 0x001E5C0E
		public unsafe static int ConfigGeometryLayerIDDefault
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ConfigGeometryLayerIDDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ConfigGeometryLayerIDDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x0600791E RID: 31006 RVA: 0x001E7A20 File Offset: 0x001E5C20
		// (set) Token: 0x0600791F RID: 31007 RVA: 0x001E7A40 File Offset: 0x001E5C40
		public unsafe static string ConfigGeometryTagDefault
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ConfigGeometryTagDefault, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ConfigGeometryTagDefault, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x06007920 RID: 31008 RVA: 0x001E7A58 File Offset: 0x001E5C58
		// (set) Token: 0x06007921 RID: 31009 RVA: 0x001E7A78 File Offset: 0x001E5C78
		public unsafe static string ConfigFadeOutCameraTagDefault
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ConfigFadeOutCameraTagDefault, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ConfigFadeOutCameraTagDefault, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B5F RID: 11103
		// (get) Token: 0x06007922 RID: 31010 RVA: 0x001E7A90 File Offset: 0x001E5C90
		// (set) Token: 0x06007923 RID: 31011 RVA: 0x001E7AAE File Offset: 0x001E5CAE
		public unsafe static RenderQueue ConfigGeometryRenderQueueDefault
		{
			get
			{
				RenderQueue result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ConfigGeometryRenderQueueDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ConfigGeometryRenderQueueDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x06007924 RID: 31012 RVA: 0x001E7AC0 File Offset: 0x001E5CC0
		// (set) Token: 0x06007925 RID: 31013 RVA: 0x001E7ADE File Offset: 0x001E5CDE
		public unsafe static RenderPipeline ConfigGeometryRenderPipelineDefault
		{
			get
			{
				RenderPipeline result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ConfigGeometryRenderPipelineDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ConfigGeometryRenderPipelineDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x06007926 RID: 31014 RVA: 0x001E7AF0 File Offset: 0x001E5CF0
		// (set) Token: 0x06007927 RID: 31015 RVA: 0x001E7B0E File Offset: 0x001E5D0E
		public unsafe static RenderingMode ConfigGeometryRenderingModeDefault
		{
			get
			{
				RenderingMode result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ConfigGeometryRenderingModeDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ConfigGeometryRenderingModeDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x06007928 RID: 31016 RVA: 0x001E7B20 File Offset: 0x001E5D20
		// (set) Token: 0x06007929 RID: 31017 RVA: 0x001E7B3E File Offset: 0x001E5D3E
		public unsafe static int ConfigNoise3DSizeDefault
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ConfigNoise3DSizeDefault, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ConfigNoise3DSizeDefault, (void*)(&value));
			}
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x0600792A RID: 31018 RVA: 0x001E7B50 File Offset: 0x001E5D50
		// (set) Token: 0x0600792B RID: 31019 RVA: 0x001E7B6E File Offset: 0x001E5D6E
		public unsafe static int ConfigSharedMeshSides
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ConfigSharedMeshSides, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ConfigSharedMeshSides, (void*)(&value));
			}
		}

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x0600792C RID: 31020 RVA: 0x001E7B80 File Offset: 0x001E5D80
		// (set) Token: 0x0600792D RID: 31021 RVA: 0x001E7B9E File Offset: 0x001E5D9E
		public unsafe static int ConfigSharedMeshSegments
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_ConfigSharedMeshSegments, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_ConfigSharedMeshSegments, (void*)(&value));
			}
		}

		// Token: 0x04004D26 RID: 19750
		private static readonly IntPtr NativeFieldInfoPtr_HelpUrlBase;

		// Token: 0x04004D27 RID: 19751
		private static readonly IntPtr NativeFieldInfoPtr_HelpUrlBeam;

		// Token: 0x04004D28 RID: 19752
		private static readonly IntPtr NativeFieldInfoPtr_HelpUrlDustParticles;

		// Token: 0x04004D29 RID: 19753
		private static readonly IntPtr NativeFieldInfoPtr_HelpUrlDynamicOcclusionRaycasting;

		// Token: 0x04004D2A RID: 19754
		private static readonly IntPtr NativeFieldInfoPtr_HelpUrlDynamicOcclusionDepthBuffer;

		// Token: 0x04004D2B RID: 19755
		private static readonly IntPtr NativeFieldInfoPtr_HelpUrlTriggerZone;

		// Token: 0x04004D2C RID: 19756
		private static readonly IntPtr NativeFieldInfoPtr_HelpUrlConfig;

		// Token: 0x04004D2D RID: 19757
		private static readonly IntPtr NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor;

		// Token: 0x04004D2E RID: 19758
		private static readonly IntPtr NativeFieldInfoPtr_FlatColor;

		// Token: 0x04004D2F RID: 19759
		private static readonly IntPtr NativeFieldInfoPtr_ColorModeDefault;

		// Token: 0x04004D30 RID: 19760
		private static readonly IntPtr NativeFieldInfoPtr_IntensityDefault;

		// Token: 0x04004D31 RID: 19761
		private static readonly IntPtr NativeFieldInfoPtr_IntensityMin;

		// Token: 0x04004D32 RID: 19762
		private static readonly IntPtr NativeFieldInfoPtr_IntensityMax;

		// Token: 0x04004D33 RID: 19763
		private static readonly IntPtr NativeFieldInfoPtr_SpotAngleDefault;

		// Token: 0x04004D34 RID: 19764
		private static readonly IntPtr NativeFieldInfoPtr_SpotAngleMin;

		// Token: 0x04004D35 RID: 19765
		private static readonly IntPtr NativeFieldInfoPtr_SpotAngleMax;

		// Token: 0x04004D36 RID: 19766
		private static readonly IntPtr NativeFieldInfoPtr_ConeRadiusStart;

		// Token: 0x04004D37 RID: 19767
		private static readonly IntPtr NativeFieldInfoPtr_GeomMeshType;

		// Token: 0x04004D38 RID: 19768
		private static readonly IntPtr NativeFieldInfoPtr_GeomSidesDefault;

		// Token: 0x04004D39 RID: 19769
		private static readonly IntPtr NativeFieldInfoPtr_GeomSidesMin;

		// Token: 0x04004D3A RID: 19770
		private static readonly IntPtr NativeFieldInfoPtr_GeomSidesMax;

		// Token: 0x04004D3B RID: 19771
		private static readonly IntPtr NativeFieldInfoPtr_GeomSegmentsDefault;

		// Token: 0x04004D3C RID: 19772
		private static readonly IntPtr NativeFieldInfoPtr_GeomSegmentsMin;

		// Token: 0x04004D3D RID: 19773
		private static readonly IntPtr NativeFieldInfoPtr_GeomSegmentsMax;

		// Token: 0x04004D3E RID: 19774
		private static readonly IntPtr NativeFieldInfoPtr_GeomCap;

		// Token: 0x04004D3F RID: 19775
		private static readonly IntPtr NativeFieldInfoPtr_AttenuationEquationDefault;

		// Token: 0x04004D40 RID: 19776
		private static readonly IntPtr NativeFieldInfoPtr_AttenuationCustomBlending;

		// Token: 0x04004D41 RID: 19777
		private static readonly IntPtr NativeFieldInfoPtr_FallOffStart;

		// Token: 0x04004D42 RID: 19778
		private static readonly IntPtr NativeFieldInfoPtr_FallOffEnd;

		// Token: 0x04004D43 RID: 19779
		private static readonly IntPtr NativeFieldInfoPtr_FallOffDistancesMinThreshold;

		// Token: 0x04004D44 RID: 19780
		private static readonly IntPtr NativeFieldInfoPtr_DepthBlendDistance;

		// Token: 0x04004D45 RID: 19781
		private static readonly IntPtr NativeFieldInfoPtr_CameraClippingDistance;

		// Token: 0x04004D46 RID: 19782
		private static readonly IntPtr NativeFieldInfoPtr_FresnelPowMaxValue;

		// Token: 0x04004D47 RID: 19783
		private static readonly IntPtr NativeFieldInfoPtr_FresnelPow;

		// Token: 0x04004D48 RID: 19784
		private static readonly IntPtr NativeFieldInfoPtr_GlareFrontal;

		// Token: 0x04004D49 RID: 19785
		private static readonly IntPtr NativeFieldInfoPtr_GlareBehind;

		// Token: 0x04004D4A RID: 19786
		private static readonly IntPtr NativeFieldInfoPtr_NoiseModeDefault;

		// Token: 0x04004D4B RID: 19787
		private static readonly IntPtr NativeFieldInfoPtr_NoiseIntensityMin;

		// Token: 0x04004D4C RID: 19788
		private static readonly IntPtr NativeFieldInfoPtr_NoiseIntensityMax;

		// Token: 0x04004D4D RID: 19789
		private static readonly IntPtr NativeFieldInfoPtr_NoiseIntensityDefault;

		// Token: 0x04004D4E RID: 19790
		private static readonly IntPtr NativeFieldInfoPtr_NoiseScaleMin;

		// Token: 0x04004D4F RID: 19791
		private static readonly IntPtr NativeFieldInfoPtr_NoiseScaleMax;

		// Token: 0x04004D50 RID: 19792
		private static readonly IntPtr NativeFieldInfoPtr_NoiseScaleDefault;

		// Token: 0x04004D51 RID: 19793
		private static readonly IntPtr NativeFieldInfoPtr_NoiseVelocityDefault;

		// Token: 0x04004D52 RID: 19794
		private static readonly IntPtr NativeFieldInfoPtr_BlendingModeDefault;

		// Token: 0x04004D53 RID: 19795
		private static readonly IntPtr NativeFieldInfoPtr_FadeOutBeginDefault;

		// Token: 0x04004D54 RID: 19796
		private static readonly IntPtr NativeFieldInfoPtr_FadeOutEndDefault;

		// Token: 0x04004D55 RID: 19797
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionLayerMaskDefault;

		// Token: 0x04004D56 RID: 19798
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionFadeDistanceToSurfaceDefault;

		// Token: 0x04004D57 RID: 19799
		private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionUpdateRateDefault;

		// Token: 0x04004D58 RID: 19800
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionWaitFramesCountDefault;

		// Token: 0x04004D59 RID: 19801
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionRaycastingDimensionsDefault;

		// Token: 0x04004D5A RID: 19802
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionRaycastingConsiderTriggersDefault;

		// Token: 0x04004D5B RID: 19803
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionRaycastingMinOccluderAreaDefault;

		// Token: 0x04004D5C RID: 19804
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionRaycastingMinSurfaceRatioDefault;

		// Token: 0x04004D5D RID: 19805
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionRaycastingMinSurfaceRatioMin;

		// Token: 0x04004D5E RID: 19806
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionRaycastingMinSurfaceRatioMax;

		// Token: 0x04004D5F RID: 19807
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionRaycastingMaxSurfaceDotDefault;

		// Token: 0x04004D60 RID: 19808
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionRaycastingMaxSurfaceAngleMin;

		// Token: 0x04004D61 RID: 19809
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionRaycastingMaxSurfaceAngleMax;

		// Token: 0x04004D62 RID: 19810
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionRaycastingPlaneAlignmentDefault;

		// Token: 0x04004D63 RID: 19811
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionRaycastingPlaneOffsetDefault;

		// Token: 0x04004D64 RID: 19812
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionDepthBufferDepthMapResolutionDefault;

		// Token: 0x04004D65 RID: 19813
		private static readonly IntPtr NativeFieldInfoPtr_DynOcclusionDepthBufferOcclusionCullingDefault;

		// Token: 0x04004D66 RID: 19814
		private static readonly IntPtr NativeFieldInfoPtr_ConfigGeometryOverrideLayerDefault;

		// Token: 0x04004D67 RID: 19815
		private static readonly IntPtr NativeFieldInfoPtr_ConfigGeometryLayerIDDefault;

		// Token: 0x04004D68 RID: 19816
		private static readonly IntPtr NativeFieldInfoPtr_ConfigGeometryTagDefault;

		// Token: 0x04004D69 RID: 19817
		private static readonly IntPtr NativeFieldInfoPtr_ConfigFadeOutCameraTagDefault;

		// Token: 0x04004D6A RID: 19818
		private static readonly IntPtr NativeFieldInfoPtr_ConfigGeometryRenderQueueDefault;

		// Token: 0x04004D6B RID: 19819
		private static readonly IntPtr NativeFieldInfoPtr_ConfigGeometryRenderPipelineDefault;

		// Token: 0x04004D6C RID: 19820
		private static readonly IntPtr NativeFieldInfoPtr_ConfigGeometryRenderingModeDefault;

		// Token: 0x04004D6D RID: 19821
		private static readonly IntPtr NativeFieldInfoPtr_ConfigNoise3DSizeDefault;

		// Token: 0x04004D6E RID: 19822
		private static readonly IntPtr NativeFieldInfoPtr_ConfigSharedMeshSides;

		// Token: 0x04004D6F RID: 19823
		private static readonly IntPtr NativeFieldInfoPtr_ConfigSharedMeshSegments;

		// Token: 0x04004D70 RID: 19824
		private static readonly IntPtr NativeMethodInfoPtr_get_ProceduralObjectsHideFlags_Public_Static_get_HideFlags_0;
	}
}
