using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005C9 RID: 1481
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		// Token: 0x06007950 RID: 31056 RVA: 0x001E8530 File Offset: 0x001E6730
		[CallerCount(0)]
		public new unsafe string GetShaderKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06007951 RID: 31057 RVA: 0x001E8588 File Offset: 0x001E6788
		[CallerCount(0)]
		public new unsafe MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007952 RID: 31058 RVA: 0x001E85E4 File Offset: 0x001E67E4
		[CallerCount(0)]
		public unsafe void ProcessOcclusionInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007953 RID: 31059 RVA: 0x001E8628 File Offset: 0x001E6828
		[CallerCount(0)]
		public new unsafe bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007954 RID: 31060 RVA: 0x001E8698 File Offset: 0x001E6898
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007955 RID: 31061 RVA: 0x001E86DC File Offset: 0x001E68DC
		[CallerCount(0)]
		public unsafe void UpdateDepthCameraPropertiesAccordingToBeam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007956 RID: 31062 RVA: 0x001E8720 File Offset: 0x001E6920
		[CallerCount(0)]
		public unsafe bool HasLayerMaskIssues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_HasLayerMaskIssues_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007957 RID: 31063 RVA: 0x001E8770 File Offset: 0x001E6970
		[CallerCount(0)]
		public new unsafe void OnValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007958 RID: 31064 RVA: 0x001E87C0 File Offset: 0x001E69C0
		[CallerCount(0)]
		public unsafe void InstantiateOrActivateDepthCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007959 RID: 31065 RVA: 0x001E8804 File Offset: 0x001E6A04
		[CallerCount(0)]
		public new unsafe void OnEnablePostValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600795A RID: 31066 RVA: 0x001E8854 File Offset: 0x001E6A54
		[CallerCount(0)]
		public new unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600795B RID: 31067 RVA: 0x001E88A4 File Offset: 0x001E6AA4
		[CallerCount(0)]
		public new unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600795C RID: 31068 RVA: 0x001E88F4 File Offset: 0x001E6AF4
		[CallerCount(0)]
		public new unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600795D RID: 31069 RVA: 0x001E8944 File Offset: 0x001E6B44
		[CallerCount(0)]
		public unsafe void DestroyDepthCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600795E RID: 31070 RVA: 0x001E8988 File Offset: 0x001E6B88
		[CallerCount(0)]
		public new unsafe void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600795F RID: 31071 RVA: 0x001E89EC File Offset: 0x001E6BEC
		[CallerCount(0)]
		public unsafe DynamicOcclusionDepthBuffer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionDepthBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007960 RID: 31072 RVA: 0x001E8A38 File Offset: 0x001E6C38
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicOcclusionDepthBuffer()
		{
			Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "DynamicOcclusionDepthBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr);
			DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "layerMask");
			DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_useOcclusionCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "useOcclusionCulling");
			DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_depthMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "depthMapResolution");
			DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_fadeDistanceToSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "fadeDistanceToSurface");
			DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_m_DepthCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "m_DepthCamera");
			DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, "m_NeedToUpdateOcclusionNextFrame");
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672973);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672974);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672975);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672976);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672977);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672978);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_HasLayerMaskIssues_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672979);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672980);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672981);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672982);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672983);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672984);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672985);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672986);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672987);
			DynamicOcclusionDepthBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr, 100672988);
		}

		// Token: 0x06007961 RID: 31073 RVA: 0x001E8C20 File Offset: 0x001E6E20
		public DynamicOcclusionDepthBuffer(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x06007962 RID: 31074 RVA: 0x001E8C29 File Offset: 0x001E6E29
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DynamicOcclusionDepthBuffer>.NativeClassPtr));
			}
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x06007963 RID: 31075 RVA: 0x001E8C3C File Offset: 0x001E6E3C
		// (set) Token: 0x06007964 RID: 31076 RVA: 0x001E8C64 File Offset: 0x001E6E64
		public unsafe LayerMask layerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_layerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_layerMask)) = value;
			}
		}

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x06007965 RID: 31077 RVA: 0x001E8C88 File Offset: 0x001E6E88
		// (set) Token: 0x06007966 RID: 31078 RVA: 0x001E8CB0 File Offset: 0x001E6EB0
		public unsafe bool useOcclusionCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_useOcclusionCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_useOcclusionCulling)) = value;
			}
		}

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x06007967 RID: 31079 RVA: 0x001E8CD4 File Offset: 0x001E6ED4
		// (set) Token: 0x06007968 RID: 31080 RVA: 0x001E8CFC File Offset: 0x001E6EFC
		public unsafe int depthMapResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_depthMapResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_depthMapResolution)) = value;
			}
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x06007969 RID: 31081 RVA: 0x001E8D20 File Offset: 0x001E6F20
		// (set) Token: 0x0600796A RID: 31082 RVA: 0x001E8D48 File Offset: 0x001E6F48
		public unsafe float fadeDistanceToSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_fadeDistanceToSurface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_fadeDistanceToSurface)) = value;
			}
		}

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x0600796B RID: 31083 RVA: 0x001E8D6C File Offset: 0x001E6F6C
		// (set) Token: 0x0600796C RID: 31084 RVA: 0x001E8DA0 File Offset: 0x001E6FA0
		public unsafe Camera m_DepthCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_m_DepthCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Camera(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_m_DepthCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x0600796D RID: 31085 RVA: 0x001E8DC8 File Offset: 0x001E6FC8
		// (set) Token: 0x0600796E RID: 31086 RVA: 0x001E8DF0 File Offset: 0x001E6FF0
		public unsafe bool m_NeedToUpdateOcclusionNextFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionDepthBuffer.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame)) = value;
			}
		}

		// Token: 0x04004D8D RID: 19853
		private static readonly IntPtr NativeFieldInfoPtr_layerMask;

		// Token: 0x04004D8E RID: 19854
		private static readonly IntPtr NativeFieldInfoPtr_useOcclusionCulling;

		// Token: 0x04004D8F RID: 19855
		private static readonly IntPtr NativeFieldInfoPtr_depthMapResolution;

		// Token: 0x04004D90 RID: 19856
		private static readonly IntPtr NativeFieldInfoPtr_fadeDistanceToSurface;

		// Token: 0x04004D91 RID: 19857
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthCamera;

		// Token: 0x04004D92 RID: 19858
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame;

		// Token: 0x04004D93 RID: 19859
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0;

		// Token: 0x04004D94 RID: 19860
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0;

		// Token: 0x04004D95 RID: 19861
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0;

		// Token: 0x04004D96 RID: 19862
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0;

		// Token: 0x04004D97 RID: 19863
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004D98 RID: 19864
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0;

		// Token: 0x04004D99 RID: 19865
		private static readonly IntPtr NativeMethodInfoPtr_HasLayerMaskIssues_Public_Boolean_0;

		// Token: 0x04004D9A RID: 19866
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0;

		// Token: 0x04004D9B RID: 19867
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0;

		// Token: 0x04004D9C RID: 19868
		private static readonly IntPtr NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0;

		// Token: 0x04004D9D RID: 19869
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04004D9E RID: 19870
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004D9F RID: 19871
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04004DA0 RID: 19872
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0;

		// Token: 0x04004DA1 RID: 19873
		private static readonly IntPtr NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0;

		// Token: 0x04004DA2 RID: 19874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
