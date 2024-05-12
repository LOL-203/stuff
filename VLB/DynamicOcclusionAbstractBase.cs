using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005C7 RID: 1479
	public class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		// Token: 0x0600792E RID: 31022 RVA: 0x001E7BB0 File Offset: 0x001E5DB0
		[CallerCount(0)]
		public unsafe void ProcessOcclusionManually()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600792F RID: 31023 RVA: 0x001E7BF4 File Offset: 0x001E5DF4
		[CallerCount(0)]
		public unsafe void ProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusion_Protected_Void_ProcessOcclusionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x06007930 RID: 31024 RVA: 0x001E7C48 File Offset: 0x001E5E48
		public unsafe int _INTERNAL_LastFrameRendered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06007931 RID: 31025 RVA: 0x001E7C98 File Offset: 0x001E5E98
		[CallerCount(0)]
		public unsafe string GetShaderKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetShaderKeyword_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06007932 RID: 31026 RVA: 0x001E7CF0 File Offset: 0x001E5EF0
		[CallerCount(0)]
		public unsafe MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Abstract_Virtual_New_DynamicOcclusion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x001E7D4C File Offset: 0x001E5F4C
		[CallerCount(0)]
		public unsafe bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Abstract_Virtual_New_Boolean_ProcessOcclusionSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x001E7DBC File Offset: 0x001E5FBC
		[CallerCount(0)]
		public unsafe void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Abstract_Virtual_New_Void_Interface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x001E7E20 File Offset: 0x001E6020
		[CallerCount(0)]
		public unsafe void OnEnablePostValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x001E7E70 File Offset: 0x001E6070
		[CallerCount(0)]
		public unsafe void OnValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x001E7EC0 File Offset: 0x001E60C0
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x001E7F10 File Offset: 0x001E6110
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x001E7F60 File Offset: 0x001E6160
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x001E7FB0 File Offset: 0x001E61B0
		[CallerCount(0)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x001E8000 File Offset: 0x001E6200
		[CallerCount(0)]
		public unsafe void OnWillCameraRender(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnWillCameraRender_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x001E805C File Offset: 0x001E625C
		[CallerCount(0)]
		public unsafe void DisableOcclusion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr_DisableOcclusion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x001E80A0 File Offset: 0x001E62A0
		[CallerCount(0)]
		public unsafe DynamicOcclusionAbstractBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x001E80EC File Offset: 0x001E62EC
		[CallerCount(0)]
		public unsafe void _OnEnable_b__19_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionAbstractBase.NativeMethodInfoPtr__OnEnable_b__19_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600793F RID: 31039 RVA: 0x001E8130 File Offset: 0x001E6330
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicOcclusionAbstractBase()
		{
			Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "DynamicOcclusionAbstractBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr);
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_updateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "updateRate");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_waitXFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "waitXFrames");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "_INTERNAL_ApplyRandomFrameOffset");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_TransformPacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_TransformPacked");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_LastFrameRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_LastFrameRendered");
			DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, "m_Master");
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672955);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_ProcessOcclusion_Protected_Void_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672956);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672957);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetShaderKeyword_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672958);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Abstract_Virtual_New_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672959);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Abstract_Virtual_New_Boolean_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672960);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Abstract_Virtual_New_Void_Interface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672961);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672962);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672963);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672964);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672965);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672966);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672967);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_OnWillCameraRender_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672968);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr_DisableOcclusion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672969);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672970);
			DynamicOcclusionAbstractBase.NativeMethodInfoPtr__OnEnable_b__19_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr, 100672972);
		}

		// Token: 0x06007940 RID: 31040 RVA: 0x0000210C File Offset: 0x0000030C
		public DynamicOcclusionAbstractBase(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x06007941 RID: 31041 RVA: 0x001E832C File Offset: 0x001E652C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DynamicOcclusionAbstractBase>.NativeClassPtr));
			}
		}

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x06007942 RID: 31042 RVA: 0x001E8340 File Offset: 0x001E6540
		// (set) Token: 0x06007943 RID: 31043 RVA: 0x001E8368 File Offset: 0x001E6568
		public unsafe DynamicOcclusionUpdateRate updateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_updateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_updateRate)) = value;
			}
		}

		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x06007944 RID: 31044 RVA: 0x001E838C File Offset: 0x001E658C
		// (set) Token: 0x06007945 RID: 31045 RVA: 0x001E83B4 File Offset: 0x001E65B4
		public unsafe int waitXFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_waitXFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_waitXFrames)) = value;
			}
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x06007946 RID: 31046 RVA: 0x001E83D8 File Offset: 0x001E65D8
		// (set) Token: 0x06007947 RID: 31047 RVA: 0x001E83F6 File Offset: 0x001E65F6
		public unsafe static bool _INTERNAL_ApplyRandomFrameOffset
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicOcclusionAbstractBase.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&value));
			}
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x06007948 RID: 31048 RVA: 0x001E8408 File Offset: 0x001E6608
		// (set) Token: 0x06007949 RID: 31049 RVA: 0x001E843C File Offset: 0x001E663C
		public unsafe TransformUtils.Packed m_TransformPacked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_TransformPacked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new TransformUtils.Packed(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_TransformPacked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x0600794A RID: 31050 RVA: 0x001E8464 File Offset: 0x001E6664
		// (set) Token: 0x0600794B RID: 31051 RVA: 0x001E848C File Offset: 0x001E668C
		public unsafe int m_LastFrameRendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_LastFrameRendered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_LastFrameRendered)) = value;
			}
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x0600794C RID: 31052 RVA: 0x001E84B0 File Offset: 0x001E66B0
		// (set) Token: 0x0600794D RID: 31053 RVA: 0x001E84E4 File Offset: 0x001E66E4
		public unsafe VolumetricLightBeam m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new VolumetricLightBeam(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionAbstractBase.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D71 RID: 19825
		private static readonly IntPtr NativeFieldInfoPtr_updateRate;

		// Token: 0x04004D72 RID: 19826
		private static readonly IntPtr NativeFieldInfoPtr_waitXFrames;

		// Token: 0x04004D73 RID: 19827
		private static readonly IntPtr NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset;

		// Token: 0x04004D74 RID: 19828
		private static readonly IntPtr NativeFieldInfoPtr_m_TransformPacked;

		// Token: 0x04004D75 RID: 19829
		private static readonly IntPtr NativeFieldInfoPtr_m_LastFrameRendered;

		// Token: 0x04004D76 RID: 19830
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x04004D77 RID: 19831
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0;

		// Token: 0x04004D78 RID: 19832
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusion_Protected_Void_ProcessOcclusionSource_0;

		// Token: 0x04004D79 RID: 19833
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0;

		// Token: 0x04004D7A RID: 19834
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeyword_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x04004D7B RID: 19835
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Abstract_Virtual_New_DynamicOcclusion_0;

		// Token: 0x04004D7C RID: 19836
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessOcclusion_Protected_Abstract_Virtual_New_Boolean_ProcessOcclusionSource_0;

		// Token: 0x04004D7D RID: 19837
		private static readonly IntPtr NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Abstract_Virtual_New_Void_Interface_0;

		// Token: 0x04004D7E RID: 19838
		private static readonly IntPtr NativeMethodInfoPtr_OnEnablePostValidate_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04004D7F RID: 19839
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_New_Void_0;

		// Token: 0x04004D80 RID: 19840
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004D81 RID: 19841
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04004D82 RID: 19842
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04004D83 RID: 19843
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x04004D84 RID: 19844
		private static readonly IntPtr NativeMethodInfoPtr_OnWillCameraRender_Private_Void_Camera_0;

		// Token: 0x04004D85 RID: 19845
		private static readonly IntPtr NativeMethodInfoPtr_DisableOcclusion_Private_Void_0;

		// Token: 0x04004D86 RID: 19846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04004D87 RID: 19847
		private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__19_0_Private_Void_0;

		// Token: 0x020005C8 RID: 1480
		public enum ProcessOcclusionSource
		{
			// Token: 0x04004D89 RID: 19849
			RenderLoop,
			// Token: 0x04004D8A RID: 19850
			OnEnable,
			// Token: 0x04004D8B RID: 19851
			EditorUpdate,
			// Token: 0x04004D8C RID: 19852
			User
		}
	}
}
