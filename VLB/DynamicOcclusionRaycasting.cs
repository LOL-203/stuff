using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005CA RID: 1482
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x0600796F RID: 31087 RVA: 0x001E8E14 File Offset: 0x001E7014
		// (set) Token: 0x06007970 RID: 31088 RVA: 0x001E8E64 File Offset: 0x001E7064
		public unsafe float fadeDistanceToPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_fadeDistanceToPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_fadeDistanceToPlane_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007971 RID: 31089 RVA: 0x001E8EB8 File Offset: 0x001E70B8
		[CallerCount(0)]
		public unsafe bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsColliderHiddenByDynamicOccluder_Public_Boolean_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17002B85 RID: 11141
		// (get) Token: 0x06007972 RID: 31090 RVA: 0x001E8F20 File Offset: 0x001E7120
		// (set) Token: 0x06007973 RID: 31091 RVA: 0x001E8F78 File Offset: 0x001E7178
		public unsafe DynamicOcclusionRaycasting.HitResult currentHit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_currentHit_Public_get_HitResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new DynamicOcclusionRaycasting.HitResult(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_currentHit_Private_set_Void_HitResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007974 RID: 31092 RVA: 0x001E8FD4 File Offset: 0x001E71D4
		[CallerCount(0)]
		public new unsafe string GetShaderKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x001E902C File Offset: 0x001E722C
		[CallerCount(0)]
		public new unsafe MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x06007976 RID: 31094 RVA: 0x001E9088 File Offset: 0x001E7288
		// (set) Token: 0x06007977 RID: 31095 RVA: 0x001E90D8 File Offset: 0x001E72D8
		public unsafe Plane planeEquationWS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_planeEquationWS_Private_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_planeEquationWS_Private_set_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007978 RID: 31096 RVA: 0x001E912C File Offset: 0x001E732C
		[CallerCount(0)]
		public new unsafe void OnValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007979 RID: 31097 RVA: 0x001E917C File Offset: 0x001E737C
		[CallerCount(0)]
		public new unsafe void OnEnablePostValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600797A RID: 31098 RVA: 0x001E91CC File Offset: 0x001E73CC
		[CallerCount(0)]
		public new unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600797B RID: 31099 RVA: 0x001E921C File Offset: 0x001E741C
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600797C RID: 31100 RVA: 0x001E9260 File Offset: 0x001E7460
		[CallerCount(0)]
		public unsafe Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angleDiff;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetRandomVectorAround_Private_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x0600797D RID: 31101 RVA: 0x001E92D8 File Offset: 0x001E74D8
		public unsafe QueryTriggerInteraction queryTriggerInteraction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_queryTriggerInteraction_Private_get_QueryTriggerInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x0600797E RID: 31102 RVA: 0x001E9328 File Offset: 0x001E7528
		public unsafe float raycastMaxDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_raycastMaxDistance_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600797F RID: 31103 RVA: 0x001E9378 File Offset: 0x001E7578
		[CallerCount(0)]
		public unsafe DynamicOcclusionRaycasting.HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rayPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayDir;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit_Private_HitResult_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new DynamicOcclusionRaycasting.HitResult(intPtr2) : null;
		}

		// Token: 0x06007980 RID: 31104 RVA: 0x001E93F4 File Offset: 0x001E75F4
		[CallerCount(0)]
		public unsafe DynamicOcclusionRaycasting.HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rayPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayDir;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit3D_Private_HitResult_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new DynamicOcclusionRaycasting.HitResult(intPtr2) : null;
		}

		// Token: 0x06007981 RID: 31105 RVA: 0x001E9470 File Offset: 0x001E7670
		[CallerCount(0)]
		public unsafe DynamicOcclusionRaycasting.HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rayPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayDir;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit2D_Private_HitResult_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new DynamicOcclusionRaycasting.HitResult(intPtr2) : null;
		}

		// Token: 0x06007982 RID: 31106 RVA: 0x001E94EC File Offset: 0x001E76EC
		[CallerCount(0)]
		public unsafe Vector3 GetDirection(uint dirInt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dirInt;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirection_Private_Vector3_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x001E9550 File Offset: 0x001E7750
		[CallerCount(0)]
		public unsafe bool IsHitValid(DynamicOcclusionRaycasting.HitResult hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(hit);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsHitValid_Private_Boolean_HitResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007984 RID: 31108 RVA: 0x001E95B8 File Offset: 0x001E77B8
		[CallerCount(0)]
		public new unsafe bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007985 RID: 31109 RVA: 0x001E9628 File Offset: 0x001E7828
		[CallerCount(0)]
		public unsafe void SetHit(DynamicOcclusionRaycasting.HitResult hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(hit);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHit_Private_Void_HitResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007986 RID: 31110 RVA: 0x001E9684 File Offset: 0x001E7884
		[CallerCount(0)]
		public new unsafe void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007987 RID: 31111 RVA: 0x001E96E8 File Offset: 0x001E78E8
		[CallerCount(0)]
		public unsafe void SetClippingPlane(Plane planeWS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref planeWS;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlane_Private_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007988 RID: 31112 RVA: 0x001E973C File Offset: 0x001E793C
		[CallerCount(0)]
		public unsafe void SetClippingPlaneOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlaneOff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007989 RID: 31113 RVA: 0x001E9780 File Offset: 0x001E7980
		[CallerCount(0)]
		public unsafe void SetPlaneWS(Plane planeWS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref planeWS;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetPlaneWS_Private_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600798A RID: 31114 RVA: 0x001E97D4 File Offset: 0x001E79D4
		[CallerCount(0)]
		public unsafe DynamicOcclusionRaycasting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600798B RID: 31115 RVA: 0x001E9820 File Offset: 0x001E7A20
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicOcclusionRaycasting()
		{
			Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "DynamicOcclusionRaycasting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr);
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "dimensions");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "layerMask");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_considerTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "considerTriggers");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_minOccluderArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "minOccluderArea");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_minSurfaceRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "minSurfaceRatio");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_maxSurfaceDot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "maxSurfaceDot");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "planeAlignment");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "planeOffset");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_fadeDistanceToSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "fadeDistanceToSurface");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr__currentHit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "<currentHit>k__BackingField");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_RangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "m_RangeMultiplier");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr__planeEquationWS_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "<planeEquationWS>k__BackingField");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_PrevNonSubHitDirectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "m_PrevNonSubHitDirectionId");
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_fadeDistanceToPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100672989);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_fadeDistanceToPlane_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100672990);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsColliderHiddenByDynamicOccluder_Public_Boolean_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100672991);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_currentHit_Public_get_HitResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100672992);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_currentHit_Private_set_Void_HitResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100672993);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100672994);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100672995);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_planeEquationWS_Private_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100672996);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_planeEquationWS_Private_set_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100672997);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100672998);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100672999);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673000);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673001);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetRandomVectorAround_Private_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673002);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_queryTriggerInteraction_Private_get_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673003);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_raycastMaxDistance_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673004);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit_Private_HitResult_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673005);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit3D_Private_HitResult_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673006);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit2D_Private_HitResult_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673007);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirection_Private_Vector3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673008);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsHitValid_Private_Boolean_HitResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673009);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673010);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHit_Private_Void_HitResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673011);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673012);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlane_Private_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673013);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlaneOff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673014);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetPlaneWS_Private_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673015);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100673016);
		}

		// Token: 0x0600798C RID: 31116 RVA: 0x001E8C20 File Offset: 0x001E6E20
		public DynamicOcclusionRaycasting(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x0600798D RID: 31117 RVA: 0x001E9B84 File Offset: 0x001E7D84
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr));
			}
		}

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x0600798E RID: 31118 RVA: 0x001E9B98 File Offset: 0x001E7D98
		// (set) Token: 0x0600798F RID: 31119 RVA: 0x001E9BC0 File Offset: 0x001E7DC0
		public unsafe OccluderDimensions dimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_dimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_dimensions)) = value;
			}
		}

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x06007990 RID: 31120 RVA: 0x001E9BE4 File Offset: 0x001E7DE4
		// (set) Token: 0x06007991 RID: 31121 RVA: 0x001E9C0C File Offset: 0x001E7E0C
		public unsafe LayerMask layerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_layerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_layerMask)) = value;
			}
		}

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x06007992 RID: 31122 RVA: 0x001E9C30 File Offset: 0x001E7E30
		// (set) Token: 0x06007993 RID: 31123 RVA: 0x001E9C58 File Offset: 0x001E7E58
		public unsafe bool considerTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_considerTriggers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_considerTriggers)) = value;
			}
		}

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x06007994 RID: 31124 RVA: 0x001E9C7C File Offset: 0x001E7E7C
		// (set) Token: 0x06007995 RID: 31125 RVA: 0x001E9CA4 File Offset: 0x001E7EA4
		public unsafe float minOccluderArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minOccluderArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minOccluderArea)) = value;
			}
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x06007996 RID: 31126 RVA: 0x001E9CC8 File Offset: 0x001E7EC8
		// (set) Token: 0x06007997 RID: 31127 RVA: 0x001E9CF0 File Offset: 0x001E7EF0
		public unsafe float minSurfaceRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minSurfaceRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minSurfaceRatio)) = value;
			}
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x06007998 RID: 31128 RVA: 0x001E9D14 File Offset: 0x001E7F14
		// (set) Token: 0x06007999 RID: 31129 RVA: 0x001E9D3C File Offset: 0x001E7F3C
		public unsafe float maxSurfaceDot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_maxSurfaceDot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_maxSurfaceDot)) = value;
			}
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x0600799A RID: 31130 RVA: 0x001E9D60 File Offset: 0x001E7F60
		// (set) Token: 0x0600799B RID: 31131 RVA: 0x001E9D88 File Offset: 0x001E7F88
		public unsafe PlaneAlignment planeAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeAlignment)) = value;
			}
		}

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x0600799C RID: 31132 RVA: 0x001E9DAC File Offset: 0x001E7FAC
		// (set) Token: 0x0600799D RID: 31133 RVA: 0x001E9DD4 File Offset: 0x001E7FD4
		public unsafe float planeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeOffset)) = value;
			}
		}

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x0600799E RID: 31134 RVA: 0x001E9DF8 File Offset: 0x001E7FF8
		// (set) Token: 0x0600799F RID: 31135 RVA: 0x001E9E20 File Offset: 0x001E8020
		public unsafe float fadeDistanceToSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_fadeDistanceToSurface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_fadeDistanceToSurface)) = value;
			}
		}

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x060079A0 RID: 31136 RVA: 0x001E9E44 File Offset: 0x001E8044
		// (set) Token: 0x060079A1 RID: 31137 RVA: 0x001E9E78 File Offset: 0x001E8078
		public unsafe DynamicOcclusionRaycasting.HitResult _currentHit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr__currentHit_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new DynamicOcclusionRaycasting.HitResult(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr__currentHit_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x060079A2 RID: 31138 RVA: 0x001E9EA0 File Offset: 0x001E80A0
		// (set) Token: 0x060079A3 RID: 31139 RVA: 0x001E9EC8 File Offset: 0x001E80C8
		public unsafe float m_RangeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_RangeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_RangeMultiplier)) = value;
			}
		}

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x060079A4 RID: 31140 RVA: 0x001E9EEC File Offset: 0x001E80EC
		// (set) Token: 0x060079A5 RID: 31141 RVA: 0x001E9F14 File Offset: 0x001E8114
		public unsafe Plane _planeEquationWS_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr__planeEquationWS_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr__planeEquationWS_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x060079A6 RID: 31142 RVA: 0x001E9F38 File Offset: 0x001E8138
		// (set) Token: 0x060079A7 RID: 31143 RVA: 0x001E9F60 File Offset: 0x001E8160
		public unsafe uint m_PrevNonSubHitDirectionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_PrevNonSubHitDirectionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_PrevNonSubHitDirectionId)) = value;
			}
		}

		// Token: 0x04004DA3 RID: 19875
		private static readonly IntPtr NativeFieldInfoPtr_dimensions;

		// Token: 0x04004DA4 RID: 19876
		private static readonly IntPtr NativeFieldInfoPtr_layerMask;

		// Token: 0x04004DA5 RID: 19877
		private static readonly IntPtr NativeFieldInfoPtr_considerTriggers;

		// Token: 0x04004DA6 RID: 19878
		private static readonly IntPtr NativeFieldInfoPtr_minOccluderArea;

		// Token: 0x04004DA7 RID: 19879
		private static readonly IntPtr NativeFieldInfoPtr_minSurfaceRatio;

		// Token: 0x04004DA8 RID: 19880
		private static readonly IntPtr NativeFieldInfoPtr_maxSurfaceDot;

		// Token: 0x04004DA9 RID: 19881
		private static readonly IntPtr NativeFieldInfoPtr_planeAlignment;

		// Token: 0x04004DAA RID: 19882
		private static readonly IntPtr NativeFieldInfoPtr_planeOffset;

		// Token: 0x04004DAB RID: 19883
		private static readonly IntPtr NativeFieldInfoPtr_fadeDistanceToSurface;

		// Token: 0x04004DAC RID: 19884
		private static readonly IntPtr NativeFieldInfoPtr__currentHit_k__BackingField;

		// Token: 0x04004DAD RID: 19885
		private static readonly IntPtr NativeFieldInfoPtr_m_RangeMultiplier;

		// Token: 0x04004DAE RID: 19886
		private static readonly IntPtr NativeFieldInfoPtr__planeEquationWS_k__BackingField;

		// Token: 0x04004DAF RID: 19887
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevNonSubHitDirectionId;

		// Token: 0x04004DB0 RID: 19888
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeDistanceToPlane_Public_get_Single_0;

		// Token: 0x04004DB1 RID: 19889
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeDistanceToPlane_Public_set_Void_Single_0;

		// Token: 0x04004DB2 RID: 19890
		private static readonly IntPtr NativeMethodInfoPtr_IsColliderHiddenByDynamicOccluder_Public_Boolean_Collider_0;

		// Token: 0x04004DB3 RID: 19891
		private static readonly IntPtr NativeMethodInfoPtr_get_currentHit_Public_get_HitResult_0;

		// Token: 0x04004DB4 RID: 19892
		private static readonly IntPtr NativeMethodInfoPtr_set_currentHit_Private_set_Void_HitResult_0;

		// Token: 0x04004DB5 RID: 19893
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0;

		// Token: 0x04004DB6 RID: 19894
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0;

		// Token: 0x04004DB7 RID: 19895
		private static readonly IntPtr NativeMethodInfoPtr_get_planeEquationWS_Private_get_Plane_0;

		// Token: 0x04004DB8 RID: 19896
		private static readonly IntPtr NativeMethodInfoPtr_set_planeEquationWS_Private_set_Void_Plane_0;

		// Token: 0x04004DB9 RID: 19897
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0;

		// Token: 0x04004DBA RID: 19898
		private static readonly IntPtr NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0;

		// Token: 0x04004DBB RID: 19899
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04004DBC RID: 19900
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004DBD RID: 19901
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomVectorAround_Private_Vector3_Vector3_Single_0;

		// Token: 0x04004DBE RID: 19902
		private static readonly IntPtr NativeMethodInfoPtr_get_queryTriggerInteraction_Private_get_QueryTriggerInteraction_0;

		// Token: 0x04004DBF RID: 19903
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastMaxDistance_Private_get_Single_0;

		// Token: 0x04004DC0 RID: 19904
		private static readonly IntPtr NativeMethodInfoPtr_GetBestHit_Private_HitResult_Vector3_Vector3_0;

		// Token: 0x04004DC1 RID: 19905
		private static readonly IntPtr NativeMethodInfoPtr_GetBestHit3D_Private_HitResult_Vector3_Vector3_0;

		// Token: 0x04004DC2 RID: 19906
		private static readonly IntPtr NativeMethodInfoPtr_GetBestHit2D_Private_HitResult_Vector3_Vector3_0;

		// Token: 0x04004DC3 RID: 19907
		private static readonly IntPtr NativeMethodInfoPtr_GetDirection_Private_Vector3_UInt32_0;

		// Token: 0x04004DC4 RID: 19908
		private static readonly IntPtr NativeMethodInfoPtr_IsHitValid_Private_Boolean_HitResult_0;

		// Token: 0x04004DC5 RID: 19909
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0;

		// Token: 0x04004DC6 RID: 19910
		private static readonly IntPtr NativeMethodInfoPtr_SetHit_Private_Void_HitResult_0;

		// Token: 0x04004DC7 RID: 19911
		private static readonly IntPtr NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0;

		// Token: 0x04004DC8 RID: 19912
		private static readonly IntPtr NativeMethodInfoPtr_SetClippingPlane_Private_Void_Plane_0;

		// Token: 0x04004DC9 RID: 19913
		private static readonly IntPtr NativeMethodInfoPtr_SetClippingPlaneOff_Private_Void_0;

		// Token: 0x04004DCA RID: 19914
		private static readonly IntPtr NativeMethodInfoPtr_SetPlaneWS_Private_Void_Plane_0;

		// Token: 0x04004DCB RID: 19915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005CB RID: 1483
		public class HitResult : Il2CppSystem.Object
		{
			// Token: 0x060079A8 RID: 31144 RVA: 0x001E9F84 File Offset: 0x001E8184
			[CallerCount(0)]
			public unsafe HitResult(RaycastHit hit3D) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref hit3D;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x060079A9 RID: 31145 RVA: 0x001E9FE4 File Offset: 0x001E81E4
			[CallerCount(0)]
			public unsafe HitResult(RaycastHit2D hit2D) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref hit2D;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_RaycastHit2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x060079AA RID: 31146 RVA: 0x001EA044 File Offset: 0x001E8244
			[CallerCount(0)]
			public unsafe HitResult() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17002B8F RID: 11151
			// (get) Token: 0x060079AB RID: 31147 RVA: 0x001EA090 File Offset: 0x001E8290
			public unsafe bool hasCollider
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_hasCollider_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x17002B90 RID: 11152
			// (get) Token: 0x060079AC RID: 31148 RVA: 0x001EA0E0 File Offset: 0x001E82E0
			public unsafe string name
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return IL2CPP.Il2CppStringToManaged(il2CppString);
				}
			}

			// Token: 0x17002B91 RID: 11153
			// (get) Token: 0x060079AD RID: 31149 RVA: 0x001EA12C File Offset: 0x001E832C
			public unsafe Bounds bounds
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x060079AE RID: 31150 RVA: 0x001EA17C File Offset: 0x001E837C
			// Note: this type is marked as 'beforefieldinit'.
			static HitResult()
			{
				Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "HitResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr);
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "point");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "normal");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "distance");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "collider2D");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "collider3D");
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100673017);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100673018);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100673019);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_hasCollider_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100673020);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100673021);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100673022);
			}

			// Token: 0x060079AF RID: 31151 RVA: 0x00002988 File Offset: 0x00000B88
			public HitResult(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002B89 RID: 11145
			// (get) Token: 0x060079B0 RID: 31152 RVA: 0x001EA283 File Offset: 0x001E8483
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr));
				}
			}

			// Token: 0x17002B8A RID: 11146
			// (get) Token: 0x060079B1 RID: 31153 RVA: 0x001EA294 File Offset: 0x001E8494
			// (set) Token: 0x060079B2 RID: 31154 RVA: 0x001EA2BC File Offset: 0x001E84BC
			public unsafe Vector3 point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_point);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_point)) = value;
				}
			}

			// Token: 0x17002B8B RID: 11147
			// (get) Token: 0x060079B3 RID: 31155 RVA: 0x001EA2E0 File Offset: 0x001E84E0
			// (set) Token: 0x060079B4 RID: 31156 RVA: 0x001EA308 File Offset: 0x001E8508
			public unsafe Vector3 normal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_normal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_normal)) = value;
				}
			}

			// Token: 0x17002B8C RID: 11148
			// (get) Token: 0x060079B5 RID: 31157 RVA: 0x001EA32C File Offset: 0x001E852C
			// (set) Token: 0x060079B6 RID: 31158 RVA: 0x001EA354 File Offset: 0x001E8554
			public unsafe float distance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_distance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_distance)) = value;
				}
			}

			// Token: 0x17002B8D RID: 11149
			// (get) Token: 0x060079B7 RID: 31159 RVA: 0x001EA378 File Offset: 0x001E8578
			// (set) Token: 0x060079B8 RID: 31160 RVA: 0x001EA3AC File Offset: 0x001E85AC
			public unsafe Collider2D collider2D
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider2D);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Collider2D(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider2D), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B8E RID: 11150
			// (get) Token: 0x060079B9 RID: 31161 RVA: 0x001EA3D4 File Offset: 0x001E85D4
			// (set) Token: 0x060079BA RID: 31162 RVA: 0x001EA408 File Offset: 0x001E8608
			public unsafe Collider collider3D
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider3D);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Collider(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider3D), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004DCC RID: 19916
			private static readonly IntPtr NativeFieldInfoPtr_point;

			// Token: 0x04004DCD RID: 19917
			private static readonly IntPtr NativeFieldInfoPtr_normal;

			// Token: 0x04004DCE RID: 19918
			private static readonly IntPtr NativeFieldInfoPtr_distance;

			// Token: 0x04004DCF RID: 19919
			private static readonly IntPtr NativeFieldInfoPtr_collider2D;

			// Token: 0x04004DD0 RID: 19920
			private static readonly IntPtr NativeFieldInfoPtr_collider3D;

			// Token: 0x04004DD1 RID: 19921
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RaycastHit_0;

			// Token: 0x04004DD2 RID: 19922
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RaycastHit2D_0;

			// Token: 0x04004DD3 RID: 19923
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004DD4 RID: 19924
			private static readonly IntPtr NativeMethodInfoPtr_get_hasCollider_Public_get_Boolean_0;

			// Token: 0x04004DD5 RID: 19925
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

			// Token: 0x04004DD6 RID: 19926
			private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;
		}

		// Token: 0x020005CC RID: 1484
		public enum Direction
		{
			// Token: 0x04004DD8 RID: 19928
			Up,
			// Token: 0x04004DD9 RID: 19929
			Right,
			// Token: 0x04004DDA RID: 19930
			Down,
			// Token: 0x04004DDB RID: 19931
			Left
		}
	}
}
