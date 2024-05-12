using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005C4 RID: 1476
	public class Config : ScriptableObject
	{
		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x06007850 RID: 30800 RVA: 0x001E56DC File Offset: 0x001E38DC
		public unsafe RenderingMode actualRenderingMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_actualRenderingMode_Public_get_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x06007851 RID: 30801 RVA: 0x001E572C File Offset: 0x001E392C
		public unsafe bool useSinglePassShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_useSinglePassShader_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x06007852 RID: 30802 RVA: 0x001E577C File Offset: 0x001E397C
		public unsafe Shader beamShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_beamShader_Public_get_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Shader(intPtr2) : null;
			}
		}

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x06007853 RID: 30803 RVA: 0x001E57D4 File Offset: 0x001E39D4
		public unsafe Vector4 globalNoiseParam
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_globalNoiseParam_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x06007854 RID: 30804 RVA: 0x001E5824 File Offset: 0x001E3A24
		public unsafe Transform fadeOutCameraTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_fadeOutCameraTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
		}

		// Token: 0x06007855 RID: 30805 RVA: 0x001E587C File Offset: 0x001E3A7C
		[CallerCount(0)]
		public unsafe void ForceUpdateFadeOutCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_ForceUpdateFadeOutCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007856 RID: 30806 RVA: 0x001E58C0 File Offset: 0x001E3AC0
		[CallerCount(0)]
		public unsafe static void OnStartup()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_OnStartup_Private_Static_Void_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x001E58F4 File Offset: 0x001E3AF4
		[CallerCount(0)]
		public unsafe static bool ShouldEnableSrpApi(RenderPipeline pipeline)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pipeline;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_ShouldEnableSrpApi_Private_Static_Boolean_RenderPipeline_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x001E5948 File Offset: 0x001E3B48
		[CallerCount(0)]
		public unsafe static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pipeline;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_OnRenderPipelineChanged_Public_Static_Void_RenderPipeline_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x001E5990 File Offset: 0x001E3B90
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x001E59D4 File Offset: 0x001E3BD4
		[CallerCount(0)]
		public unsafe void ResetInternalData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_ResetInternalData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600785B RID: 30811 RVA: 0x001E5A18 File Offset: 0x001E3C18
		[CallerCount(0)]
		public unsafe ParticleSystem NewVolumetricDustParticles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_NewVolumetricDustParticles_Public_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new ParticleSystem(intPtr2) : null;
		}

		// Token: 0x0600785C RID: 30812 RVA: 0x001E5A70 File Offset: 0x001E3C70
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x001E5AB4 File Offset: 0x001E3CB4
		[CallerCount(0)]
		public unsafe void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref serializedVersion;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVersion;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x0600785E RID: 30814 RVA: 0x001E5B1C File Offset: 0x001E3D1C
		public unsafe static Config Instance
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_Instance_Public_Static_get_Config_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Config(intPtr2) : null;
			}
		}

		// Token: 0x0600785F RID: 30815 RVA: 0x001E5B64 File Offset: 0x001E3D64
		[CallerCount(0)]
		public unsafe static Config GetInstance(bool assertIfNotFound)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref assertIfNotFound;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_GetInstance_Private_Static_Config_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Config(intPtr2) : null;
		}

		// Token: 0x06007860 RID: 30816 RVA: 0x001E5BC0 File Offset: 0x001E3DC0
		[CallerCount(0)]
		public unsafe Config() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Config>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x001E5C0C File Offset: 0x001E3E0C
		// Note: this type is marked as 'beforefieldinit'.
		static Config()
		{
			Il2CppClassPointerStore<Config>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Config");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Config>.NativeClassPtr);
			Config.NativeFieldInfoPtr_geometryOverrideLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryOverrideLayer");
			Config.NativeFieldInfoPtr_geometryLayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryLayerID");
			Config.NativeFieldInfoPtr_geometryTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryTag");
			Config.NativeFieldInfoPtr_geometryRenderQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "geometryRenderQueue");
			Config.NativeFieldInfoPtr_renderPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "renderPipeline");
			Config.NativeFieldInfoPtr_forceSinglePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "forceSinglePass");
			Config.NativeFieldInfoPtr_renderingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "renderingMode");
			Config.NativeFieldInfoPtr_beamShader1Pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "beamShader1Pass");
			Config.NativeFieldInfoPtr_beamShader2Pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "beamShader2Pass");
			Config.NativeFieldInfoPtr_beamShaderSRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "beamShaderSRP");
			Config.NativeFieldInfoPtr_sharedMeshSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "sharedMeshSides");
			Config.NativeFieldInfoPtr_sharedMeshSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "sharedMeshSegments");
			Config.NativeFieldInfoPtr_globalNoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "globalNoiseScale");
			Config.NativeFieldInfoPtr_globalNoiseVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "globalNoiseVelocity");
			Config.NativeFieldInfoPtr_fadeOutCameraTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "fadeOutCameraTag");
			Config.NativeFieldInfoPtr_noise3DData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "noise3DData");
			Config.NativeFieldInfoPtr_noise3DSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "noise3DSize");
			Config.NativeFieldInfoPtr_dustParticlesPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "dustParticlesPrefab");
			Config.NativeFieldInfoPtr_pluginVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "pluginVersion");
			Config.NativeFieldInfoPtr_m_CachedFadeOutCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "m_CachedFadeOutCamera");
			Config.NativeFieldInfoPtr_kAssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "kAssetName");
			Config.NativeFieldInfoPtr_m_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "m_Instance");
			Config.NativeMethodInfoPtr_get_actualRenderingMode_Public_get_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672935);
			Config.NativeMethodInfoPtr_get_useSinglePassShader_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672936);
			Config.NativeMethodInfoPtr_get_beamShader_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672937);
			Config.NativeMethodInfoPtr_get_globalNoiseParam_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672938);
			Config.NativeMethodInfoPtr_get_fadeOutCameraTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672939);
			Config.NativeMethodInfoPtr_ForceUpdateFadeOutCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672940);
			Config.NativeMethodInfoPtr_OnStartup_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672941);
			Config.NativeMethodInfoPtr_ShouldEnableSrpApi_Private_Static_Boolean_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672942);
			Config.NativeMethodInfoPtr_OnRenderPipelineChanged_Public_Static_Void_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672943);
			Config.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672944);
			Config.NativeMethodInfoPtr_ResetInternalData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672945);
			Config.NativeMethodInfoPtr_NewVolumetricDustParticles_Public_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672946);
			Config.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672947);
			Config.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672948);
			Config.NativeMethodInfoPtr_get_Instance_Public_Static_get_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672949);
			Config.NativeMethodInfoPtr_GetInstance_Private_Static_Config_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672950);
			Config.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100672951);
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x0002DD3C File Offset: 0x0002BF3C
		public Config(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002AFB RID: 11003
		// (get) Token: 0x06007863 RID: 30819 RVA: 0x001E5F48 File Offset: 0x001E4148
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Config>.NativeClassPtr));
			}
		}

		// Token: 0x17002AFC RID: 11004
		// (get) Token: 0x06007864 RID: 30820 RVA: 0x001E5F5C File Offset: 0x001E415C
		// (set) Token: 0x06007865 RID: 30821 RVA: 0x001E5F84 File Offset: 0x001E4184
		public unsafe bool geometryOverrideLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryOverrideLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryOverrideLayer)) = value;
			}
		}

		// Token: 0x17002AFD RID: 11005
		// (get) Token: 0x06007866 RID: 30822 RVA: 0x001E5FA8 File Offset: 0x001E41A8
		// (set) Token: 0x06007867 RID: 30823 RVA: 0x001E5FD0 File Offset: 0x001E41D0
		public unsafe int geometryLayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryLayerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryLayerID)) = value;
			}
		}

		// Token: 0x17002AFE RID: 11006
		// (get) Token: 0x06007868 RID: 30824 RVA: 0x001E5FF4 File Offset: 0x001E41F4
		// (set) Token: 0x06007869 RID: 30825 RVA: 0x001E601D File Offset: 0x001E421D
		public unsafe string geometryTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x0600786A RID: 30826 RVA: 0x001E6044 File Offset: 0x001E4244
		// (set) Token: 0x0600786B RID: 30827 RVA: 0x001E606C File Offset: 0x001E426C
		public unsafe int geometryRenderQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryRenderQueue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_geometryRenderQueue)) = value;
			}
		}

		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x0600786C RID: 30828 RVA: 0x001E6090 File Offset: 0x001E4290
		// (set) Token: 0x0600786D RID: 30829 RVA: 0x001E60B8 File Offset: 0x001E42B8
		public unsafe RenderPipeline renderPipeline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_renderPipeline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_renderPipeline)) = value;
			}
		}

		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x0600786E RID: 30830 RVA: 0x001E60DC File Offset: 0x001E42DC
		// (set) Token: 0x0600786F RID: 30831 RVA: 0x001E6104 File Offset: 0x001E4304
		public unsafe bool forceSinglePass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_forceSinglePass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_forceSinglePass)) = value;
			}
		}

		// Token: 0x17002B02 RID: 11010
		// (get) Token: 0x06007870 RID: 30832 RVA: 0x001E6128 File Offset: 0x001E4328
		// (set) Token: 0x06007871 RID: 30833 RVA: 0x001E6150 File Offset: 0x001E4350
		public unsafe RenderingMode renderingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_renderingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_renderingMode)) = value;
			}
		}

		// Token: 0x17002B03 RID: 11011
		// (get) Token: 0x06007872 RID: 30834 RVA: 0x001E6174 File Offset: 0x001E4374
		// (set) Token: 0x06007873 RID: 30835 RVA: 0x001E61A8 File Offset: 0x001E43A8
		public unsafe Shader beamShader1Pass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_beamShader1Pass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Shader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_beamShader1Pass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B04 RID: 11012
		// (get) Token: 0x06007874 RID: 30836 RVA: 0x001E61D0 File Offset: 0x001E43D0
		// (set) Token: 0x06007875 RID: 30837 RVA: 0x001E6204 File Offset: 0x001E4404
		public unsafe Shader beamShader2Pass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_beamShader2Pass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Shader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_beamShader2Pass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x06007876 RID: 30838 RVA: 0x001E622C File Offset: 0x001E442C
		// (set) Token: 0x06007877 RID: 30839 RVA: 0x001E6260 File Offset: 0x001E4460
		public unsafe Shader beamShaderSRP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_beamShaderSRP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Shader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_beamShaderSRP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x06007878 RID: 30840 RVA: 0x001E6288 File Offset: 0x001E4488
		// (set) Token: 0x06007879 RID: 30841 RVA: 0x001E62B0 File Offset: 0x001E44B0
		public unsafe int sharedMeshSides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_sharedMeshSides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_sharedMeshSides)) = value;
			}
		}

		// Token: 0x17002B07 RID: 11015
		// (get) Token: 0x0600787A RID: 30842 RVA: 0x001E62D4 File Offset: 0x001E44D4
		// (set) Token: 0x0600787B RID: 30843 RVA: 0x001E62FC File Offset: 0x001E44FC
		public unsafe int sharedMeshSegments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_sharedMeshSegments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_sharedMeshSegments)) = value;
			}
		}

		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x0600787C RID: 30844 RVA: 0x001E6320 File Offset: 0x001E4520
		// (set) Token: 0x0600787D RID: 30845 RVA: 0x001E6348 File Offset: 0x001E4548
		public unsafe float globalNoiseScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_globalNoiseScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_globalNoiseScale)) = value;
			}
		}

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x0600787E RID: 30846 RVA: 0x001E636C File Offset: 0x001E456C
		// (set) Token: 0x0600787F RID: 30847 RVA: 0x001E6394 File Offset: 0x001E4594
		public unsafe Vector3 globalNoiseVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_globalNoiseVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_globalNoiseVelocity)) = value;
			}
		}

		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x06007880 RID: 30848 RVA: 0x001E63B8 File Offset: 0x001E45B8
		// (set) Token: 0x06007881 RID: 30849 RVA: 0x001E63E1 File Offset: 0x001E45E1
		public unsafe string fadeOutCameraTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_fadeOutCameraTag);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_fadeOutCameraTag), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x06007882 RID: 30850 RVA: 0x001E6408 File Offset: 0x001E4608
		// (set) Token: 0x06007883 RID: 30851 RVA: 0x001E643C File Offset: 0x001E463C
		public unsafe TextAsset noise3DData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_noise3DData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new TextAsset(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_noise3DData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x06007884 RID: 30852 RVA: 0x001E6464 File Offset: 0x001E4664
		// (set) Token: 0x06007885 RID: 30853 RVA: 0x001E648C File Offset: 0x001E468C
		public unsafe int noise3DSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_noise3DSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_noise3DSize)) = value;
			}
		}

		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x06007886 RID: 30854 RVA: 0x001E64B0 File Offset: 0x001E46B0
		// (set) Token: 0x06007887 RID: 30855 RVA: 0x001E64E4 File Offset: 0x001E46E4
		public unsafe ParticleSystem dustParticlesPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_dustParticlesPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new ParticleSystem(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_dustParticlesPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x06007888 RID: 30856 RVA: 0x001E650C File Offset: 0x001E470C
		// (set) Token: 0x06007889 RID: 30857 RVA: 0x001E6534 File Offset: 0x001E4734
		public unsafe int pluginVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_pluginVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_pluginVersion)) = value;
			}
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x0600788A RID: 30858 RVA: 0x001E6558 File Offset: 0x001E4758
		// (set) Token: 0x0600788B RID: 30859 RVA: 0x001E658C File Offset: 0x001E478C
		public unsafe Transform m_CachedFadeOutCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_CachedFadeOutCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Config.NativeFieldInfoPtr_m_CachedFadeOutCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x0600788C RID: 30860 RVA: 0x001E65B4 File Offset: 0x001E47B4
		// (set) Token: 0x0600788D RID: 30861 RVA: 0x001E65D4 File Offset: 0x001E47D4
		public unsafe static string kAssetName
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_kAssetName, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_kAssetName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x0600788E RID: 30862 RVA: 0x001E65EC File Offset: 0x001E47EC
		// (set) Token: 0x0600788F RID: 30863 RVA: 0x001E6617 File Offset: 0x001E4817
		public unsafe static Config m_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_m_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Config(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_m_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CFD RID: 19709
		private static readonly IntPtr NativeFieldInfoPtr_geometryOverrideLayer;

		// Token: 0x04004CFE RID: 19710
		private static readonly IntPtr NativeFieldInfoPtr_geometryLayerID;

		// Token: 0x04004CFF RID: 19711
		private static readonly IntPtr NativeFieldInfoPtr_geometryTag;

		// Token: 0x04004D00 RID: 19712
		private static readonly IntPtr NativeFieldInfoPtr_geometryRenderQueue;

		// Token: 0x04004D01 RID: 19713
		private static readonly IntPtr NativeFieldInfoPtr_renderPipeline;

		// Token: 0x04004D02 RID: 19714
		private static readonly IntPtr NativeFieldInfoPtr_forceSinglePass;

		// Token: 0x04004D03 RID: 19715
		private static readonly IntPtr NativeFieldInfoPtr_renderingMode;

		// Token: 0x04004D04 RID: 19716
		private static readonly IntPtr NativeFieldInfoPtr_beamShader1Pass;

		// Token: 0x04004D05 RID: 19717
		private static readonly IntPtr NativeFieldInfoPtr_beamShader2Pass;

		// Token: 0x04004D06 RID: 19718
		private static readonly IntPtr NativeFieldInfoPtr_beamShaderSRP;

		// Token: 0x04004D07 RID: 19719
		private static readonly IntPtr NativeFieldInfoPtr_sharedMeshSides;

		// Token: 0x04004D08 RID: 19720
		private static readonly IntPtr NativeFieldInfoPtr_sharedMeshSegments;

		// Token: 0x04004D09 RID: 19721
		private static readonly IntPtr NativeFieldInfoPtr_globalNoiseScale;

		// Token: 0x04004D0A RID: 19722
		private static readonly IntPtr NativeFieldInfoPtr_globalNoiseVelocity;

		// Token: 0x04004D0B RID: 19723
		private static readonly IntPtr NativeFieldInfoPtr_fadeOutCameraTag;

		// Token: 0x04004D0C RID: 19724
		private static readonly IntPtr NativeFieldInfoPtr_noise3DData;

		// Token: 0x04004D0D RID: 19725
		private static readonly IntPtr NativeFieldInfoPtr_noise3DSize;

		// Token: 0x04004D0E RID: 19726
		private static readonly IntPtr NativeFieldInfoPtr_dustParticlesPrefab;

		// Token: 0x04004D0F RID: 19727
		private static readonly IntPtr NativeFieldInfoPtr_pluginVersion;

		// Token: 0x04004D10 RID: 19728
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedFadeOutCamera;

		// Token: 0x04004D11 RID: 19729
		private static readonly IntPtr NativeFieldInfoPtr_kAssetName;

		// Token: 0x04004D12 RID: 19730
		private static readonly IntPtr NativeFieldInfoPtr_m_Instance;

		// Token: 0x04004D13 RID: 19731
		private static readonly IntPtr NativeMethodInfoPtr_get_actualRenderingMode_Public_get_RenderingMode_0;

		// Token: 0x04004D14 RID: 19732
		private static readonly IntPtr NativeMethodInfoPtr_get_useSinglePassShader_Public_get_Boolean_0;

		// Token: 0x04004D15 RID: 19733
		private static readonly IntPtr NativeMethodInfoPtr_get_beamShader_Public_get_Shader_0;

		// Token: 0x04004D16 RID: 19734
		private static readonly IntPtr NativeMethodInfoPtr_get_globalNoiseParam_Public_get_Vector4_0;

		// Token: 0x04004D17 RID: 19735
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeOutCameraTransform_Public_get_Transform_0;

		// Token: 0x04004D18 RID: 19736
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdateFadeOutCamera_Public_Void_0;

		// Token: 0x04004D19 RID: 19737
		private static readonly IntPtr NativeMethodInfoPtr_OnStartup_Private_Static_Void_0;

		// Token: 0x04004D1A RID: 19738
		private static readonly IntPtr NativeMethodInfoPtr_ShouldEnableSrpApi_Private_Static_Boolean_RenderPipeline_0;

		// Token: 0x04004D1B RID: 19739
		private static readonly IntPtr NativeMethodInfoPtr_OnRenderPipelineChanged_Public_Static_Void_RenderPipeline_0;

		// Token: 0x04004D1C RID: 19740
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04004D1D RID: 19741
		private static readonly IntPtr NativeMethodInfoPtr_ResetInternalData_Public_Void_0;

		// Token: 0x04004D1E RID: 19742
		private static readonly IntPtr NativeMethodInfoPtr_NewVolumetricDustParticles_Public_ParticleSystem_0;

		// Token: 0x04004D1F RID: 19743
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04004D20 RID: 19744
		private static readonly IntPtr NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0;

		// Token: 0x04004D21 RID: 19745
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Config_0;

		// Token: 0x04004D22 RID: 19746
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Private_Static_Config_Boolean_0;

		// Token: 0x04004D23 RID: 19747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
