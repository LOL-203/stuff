using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000771 RID: 1905
	[Serializable]
	public class EyeRotationLimiter : Il2CppSystem.Object
	{
		// Token: 0x06009D4F RID: 40271 RVA: 0x0027E760 File Offset: 0x0027C960
		[CallerCount(0)]
		public unsafe bool CanImport(EyeRotationLimiter.EyeRotationLimiterForExport import, Transform startXform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(import);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startXform);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr_CanImport_Public_Boolean_EyeRotationLimiterForExport_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009D50 RID: 40272 RVA: 0x0027E7E0 File Offset: 0x0027C9E0
		[CallerCount(0)]
		public unsafe float ClampAngle(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr_ClampAngle_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009D51 RID: 40273 RVA: 0x0027E844 File Offset: 0x0027CA44
		[CallerCount(0)]
		public unsafe EyeRotationLimiter.EyeRotationLimiterForExport GetExport(Transform startXform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(startXform);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr_GetExport_Public_EyeRotationLimiterForExport_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new EyeRotationLimiter.EyeRotationLimiterForExport(intPtr2) : null;
		}

		// Token: 0x06009D52 RID: 40274 RVA: 0x0027E8B4 File Offset: 0x0027CAB4
		[CallerCount(0)]
		public unsafe float GetEyeUp01(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr_GetEyeUp01_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009D53 RID: 40275 RVA: 0x0027E918 File Offset: 0x0027CB18
		[CallerCount(0)]
		public unsafe float GetEyeDown01(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr_GetEyeDown01_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009D54 RID: 40276 RVA: 0x0027E97C File Offset: 0x0027CB7C
		[CallerCount(0)]
		public unsafe void Import(EyeRotationLimiter.EyeRotationLimiterForExport import, Transform startXform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(import);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startXform);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr_Import_Public_Void_EyeRotationLimiterForExport_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D55 RID: 40277 RVA: 0x0027E9F0 File Offset: 0x0027CBF0
		[CallerCount(0)]
		public unsafe void RestoreDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr_RestoreDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D56 RID: 40278 RVA: 0x0027EA34 File Offset: 0x0027CC34
		[CallerCount(0)]
		public unsafe void RestoreLookDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr_RestoreLookDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D57 RID: 40279 RVA: 0x0027EA78 File Offset: 0x0027CC78
		[CallerCount(0)]
		public unsafe void RestoreLookUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr_RestoreLookUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D58 RID: 40280 RVA: 0x0027EABC File Offset: 0x0027CCBC
		[CallerCount(0)]
		public unsafe void SaveDefault(Transform t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr_SaveDefault_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D59 RID: 40281 RVA: 0x0027EB18 File Offset: 0x0027CD18
		[CallerCount(0)]
		public unsafe void SaveLookDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr_SaveLookDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D5A RID: 40282 RVA: 0x0027EB5C File Offset: 0x0027CD5C
		[CallerCount(0)]
		public unsafe void SaveLookUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr_SaveLookUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D5B RID: 40283 RVA: 0x0027EBA0 File Offset: 0x0027CDA0
		[CallerCount(0)]
		public unsafe void UpdateMaxAngles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr_UpdateMaxAngles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D5C RID: 40284 RVA: 0x0027EBE4 File Offset: 0x0027CDE4
		[CallerCount(0)]
		public unsafe EyeRotationLimiter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D5D RID: 40285 RVA: 0x0027EC30 File Offset: 0x0027CE30
		// Note: this type is marked as 'beforefieldinit'.
		static EyeRotationLimiter()
		{
			Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RealisticEyeMovements", "EyeRotationLimiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr);
			EyeRotationLimiter.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, "transform");
			EyeRotationLimiter.NativeFieldInfoPtr_defaultQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, "defaultQ");
			EyeRotationLimiter.NativeFieldInfoPtr_lookUpQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, "lookUpQ");
			EyeRotationLimiter.NativeFieldInfoPtr_lookDownQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, "lookDownQ");
			EyeRotationLimiter.NativeFieldInfoPtr_maxUpAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, "maxUpAngle");
			EyeRotationLimiter.NativeFieldInfoPtr_maxDownAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, "maxDownAngle");
			EyeRotationLimiter.NativeFieldInfoPtr_isLookUpSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, "isLookUpSet");
			EyeRotationLimiter.NativeFieldInfoPtr_isLookDownSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, "isLookDownSet");
			EyeRotationLimiter.NativeMethodInfoPtr_CanImport_Public_Boolean_EyeRotationLimiterForExport_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675896);
			EyeRotationLimiter.NativeMethodInfoPtr_ClampAngle_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675897);
			EyeRotationLimiter.NativeMethodInfoPtr_GetExport_Public_EyeRotationLimiterForExport_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675898);
			EyeRotationLimiter.NativeMethodInfoPtr_GetEyeUp01_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675899);
			EyeRotationLimiter.NativeMethodInfoPtr_GetEyeDown01_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675900);
			EyeRotationLimiter.NativeMethodInfoPtr_Import_Public_Void_EyeRotationLimiterForExport_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675901);
			EyeRotationLimiter.NativeMethodInfoPtr_RestoreDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675902);
			EyeRotationLimiter.NativeMethodInfoPtr_RestoreLookDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675903);
			EyeRotationLimiter.NativeMethodInfoPtr_RestoreLookUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675904);
			EyeRotationLimiter.NativeMethodInfoPtr_SaveDefault_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675905);
			EyeRotationLimiter.NativeMethodInfoPtr_SaveLookDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675906);
			EyeRotationLimiter.NativeMethodInfoPtr_SaveLookUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675907);
			EyeRotationLimiter.NativeMethodInfoPtr_UpdateMaxAngles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675908);
			EyeRotationLimiter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, 100675909);
		}

		// Token: 0x06009D5E RID: 40286 RVA: 0x00002988 File Offset: 0x00000B88
		public EyeRotationLimiter(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x06009D5F RID: 40287 RVA: 0x0027EE18 File Offset: 0x0027D018
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr));
			}
		}

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x06009D60 RID: 40288 RVA: 0x0027EE2C File Offset: 0x0027D02C
		// (set) Token: 0x06009D61 RID: 40289 RVA: 0x0027EE60 File Offset: 0x0027D060
		public unsafe Transform transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x06009D62 RID: 40290 RVA: 0x0027EE88 File Offset: 0x0027D088
		// (set) Token: 0x06009D63 RID: 40291 RVA: 0x0027EEB0 File Offset: 0x0027D0B0
		public unsafe Quaternion defaultQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_defaultQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_defaultQ)) = value;
			}
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x06009D64 RID: 40292 RVA: 0x0027EED4 File Offset: 0x0027D0D4
		// (set) Token: 0x06009D65 RID: 40293 RVA: 0x0027EEFC File Offset: 0x0027D0FC
		public unsafe Quaternion lookUpQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_lookUpQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_lookUpQ)) = value;
			}
		}

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x06009D66 RID: 40294 RVA: 0x0027EF20 File Offset: 0x0027D120
		// (set) Token: 0x06009D67 RID: 40295 RVA: 0x0027EF48 File Offset: 0x0027D148
		public unsafe Quaternion lookDownQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_lookDownQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_lookDownQ)) = value;
			}
		}

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x06009D68 RID: 40296 RVA: 0x0027EF6C File Offset: 0x0027D16C
		// (set) Token: 0x06009D69 RID: 40297 RVA: 0x0027EF94 File Offset: 0x0027D194
		public unsafe float maxUpAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_maxUpAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_maxUpAngle)) = value;
			}
		}

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x06009D6A RID: 40298 RVA: 0x0027EFB8 File Offset: 0x0027D1B8
		// (set) Token: 0x06009D6B RID: 40299 RVA: 0x0027EFE0 File Offset: 0x0027D1E0
		public unsafe float maxDownAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_maxDownAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_maxDownAngle)) = value;
			}
		}

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x06009D6C RID: 40300 RVA: 0x0027F004 File Offset: 0x0027D204
		// (set) Token: 0x06009D6D RID: 40301 RVA: 0x0027F02C File Offset: 0x0027D22C
		public unsafe bool isLookUpSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_isLookUpSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_isLookUpSet)) = value;
			}
		}

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x06009D6E RID: 40302 RVA: 0x0027F050 File Offset: 0x0027D250
		// (set) Token: 0x06009D6F RID: 40303 RVA: 0x0027F078 File Offset: 0x0027D278
		public unsafe bool isLookDownSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_isLookDownSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.NativeFieldInfoPtr_isLookDownSet)) = value;
			}
		}

		// Token: 0x040063FD RID: 25597
		private static readonly IntPtr NativeFieldInfoPtr_transform;

		// Token: 0x040063FE RID: 25598
		private static readonly IntPtr NativeFieldInfoPtr_defaultQ;

		// Token: 0x040063FF RID: 25599
		private static readonly IntPtr NativeFieldInfoPtr_lookUpQ;

		// Token: 0x04006400 RID: 25600
		private static readonly IntPtr NativeFieldInfoPtr_lookDownQ;

		// Token: 0x04006401 RID: 25601
		private static readonly IntPtr NativeFieldInfoPtr_maxUpAngle;

		// Token: 0x04006402 RID: 25602
		private static readonly IntPtr NativeFieldInfoPtr_maxDownAngle;

		// Token: 0x04006403 RID: 25603
		private static readonly IntPtr NativeFieldInfoPtr_isLookUpSet;

		// Token: 0x04006404 RID: 25604
		private static readonly IntPtr NativeFieldInfoPtr_isLookDownSet;

		// Token: 0x04006405 RID: 25605
		private static readonly IntPtr NativeMethodInfoPtr_CanImport_Public_Boolean_EyeRotationLimiterForExport_Transform_0;

		// Token: 0x04006406 RID: 25606
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Public_Single_Single_0;

		// Token: 0x04006407 RID: 25607
		private static readonly IntPtr NativeMethodInfoPtr_GetExport_Public_EyeRotationLimiterForExport_Transform_0;

		// Token: 0x04006408 RID: 25608
		private static readonly IntPtr NativeMethodInfoPtr_GetEyeUp01_Public_Single_Single_0;

		// Token: 0x04006409 RID: 25609
		private static readonly IntPtr NativeMethodInfoPtr_GetEyeDown01_Public_Single_Single_0;

		// Token: 0x0400640A RID: 25610
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Void_EyeRotationLimiterForExport_Transform_0;

		// Token: 0x0400640B RID: 25611
		private static readonly IntPtr NativeMethodInfoPtr_RestoreDefault_Public_Void_0;

		// Token: 0x0400640C RID: 25612
		private static readonly IntPtr NativeMethodInfoPtr_RestoreLookDown_Public_Void_0;

		// Token: 0x0400640D RID: 25613
		private static readonly IntPtr NativeMethodInfoPtr_RestoreLookUp_Public_Void_0;

		// Token: 0x0400640E RID: 25614
		private static readonly IntPtr NativeMethodInfoPtr_SaveDefault_Public_Void_Transform_0;

		// Token: 0x0400640F RID: 25615
		private static readonly IntPtr NativeMethodInfoPtr_SaveLookDown_Public_Void_0;

		// Token: 0x04006410 RID: 25616
		private static readonly IntPtr NativeMethodInfoPtr_SaveLookUp_Public_Void_0;

		// Token: 0x04006411 RID: 25617
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaxAngles_Private_Void_0;

		// Token: 0x04006412 RID: 25618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000772 RID: 1906
		[Serializable]
		public class EyeRotationLimiterForExport : Il2CppSystem.Object
		{
			// Token: 0x06009D70 RID: 40304 RVA: 0x0027F09C File Offset: 0x0027D29C
			[CallerCount(0)]
			public unsafe EyeRotationLimiterForExport() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeRotationLimiter.EyeRotationLimiterForExport>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeRotationLimiter.EyeRotationLimiterForExport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06009D71 RID: 40305 RVA: 0x0027F0E8 File Offset: 0x0027D2E8
			// Note: this type is marked as 'beforefieldinit'.
			static EyeRotationLimiterForExport()
			{
				Il2CppClassPointerStore<EyeRotationLimiter.EyeRotationLimiterForExport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EyeRotationLimiter>.NativeClassPtr, "EyeRotationLimiterForExport");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeRotationLimiter.EyeRotationLimiterForExport>.NativeClassPtr);
				EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_transformPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter.EyeRotationLimiterForExport>.NativeClassPtr, "transformPath");
				EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_defaultQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter.EyeRotationLimiterForExport>.NativeClassPtr, "defaultQ");
				EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_lookUpQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter.EyeRotationLimiterForExport>.NativeClassPtr, "lookUpQ");
				EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_lookDownQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter.EyeRotationLimiterForExport>.NativeClassPtr, "lookDownQ");
				EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_isLookUpSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter.EyeRotationLimiterForExport>.NativeClassPtr, "isLookUpSet");
				EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_isLookDownSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeRotationLimiter.EyeRotationLimiterForExport>.NativeClassPtr, "isLookDownSet");
				EyeRotationLimiter.EyeRotationLimiterForExport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeRotationLimiter.EyeRotationLimiterForExport>.NativeClassPtr, 100675910);
			}

			// Token: 0x06009D72 RID: 40306 RVA: 0x00002988 File Offset: 0x00000B88
			public EyeRotationLimiterForExport(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17003846 RID: 14406
			// (get) Token: 0x06009D73 RID: 40307 RVA: 0x0027F19F File Offset: 0x0027D39F
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EyeRotationLimiter.EyeRotationLimiterForExport>.NativeClassPtr));
				}
			}

			// Token: 0x17003847 RID: 14407
			// (get) Token: 0x06009D74 RID: 40308 RVA: 0x0027F1B0 File Offset: 0x0027D3B0
			// (set) Token: 0x06009D75 RID: 40309 RVA: 0x0027F1D9 File Offset: 0x0027D3D9
			public unsafe string transformPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_transformPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_transformPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003848 RID: 14408
			// (get) Token: 0x06009D76 RID: 40310 RVA: 0x0027F200 File Offset: 0x0027D400
			// (set) Token: 0x06009D77 RID: 40311 RVA: 0x0027F228 File Offset: 0x0027D428
			public unsafe SerializableQuaternion defaultQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_defaultQ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_defaultQ)) = value;
				}
			}

			// Token: 0x17003849 RID: 14409
			// (get) Token: 0x06009D78 RID: 40312 RVA: 0x0027F24C File Offset: 0x0027D44C
			// (set) Token: 0x06009D79 RID: 40313 RVA: 0x0027F274 File Offset: 0x0027D474
			public unsafe SerializableQuaternion lookUpQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_lookUpQ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_lookUpQ)) = value;
				}
			}

			// Token: 0x1700384A RID: 14410
			// (get) Token: 0x06009D7A RID: 40314 RVA: 0x0027F298 File Offset: 0x0027D498
			// (set) Token: 0x06009D7B RID: 40315 RVA: 0x0027F2C0 File Offset: 0x0027D4C0
			public unsafe SerializableQuaternion lookDownQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_lookDownQ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_lookDownQ)) = value;
				}
			}

			// Token: 0x1700384B RID: 14411
			// (get) Token: 0x06009D7C RID: 40316 RVA: 0x0027F2E4 File Offset: 0x0027D4E4
			// (set) Token: 0x06009D7D RID: 40317 RVA: 0x0027F30C File Offset: 0x0027D50C
			public unsafe bool isLookUpSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_isLookUpSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_isLookUpSet)) = value;
				}
			}

			// Token: 0x1700384C RID: 14412
			// (get) Token: 0x06009D7E RID: 40318 RVA: 0x0027F330 File Offset: 0x0027D530
			// (set) Token: 0x06009D7F RID: 40319 RVA: 0x0027F358 File Offset: 0x0027D558
			public unsafe bool isLookDownSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_isLookDownSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeRotationLimiter.EyeRotationLimiterForExport.NativeFieldInfoPtr_isLookDownSet)) = value;
				}
			}

			// Token: 0x04006413 RID: 25619
			private static readonly IntPtr NativeFieldInfoPtr_transformPath;

			// Token: 0x04006414 RID: 25620
			private static readonly IntPtr NativeFieldInfoPtr_defaultQ;

			// Token: 0x04006415 RID: 25621
			private static readonly IntPtr NativeFieldInfoPtr_lookUpQ;

			// Token: 0x04006416 RID: 25622
			private static readonly IntPtr NativeFieldInfoPtr_lookDownQ;

			// Token: 0x04006417 RID: 25623
			private static readonly IntPtr NativeFieldInfoPtr_isLookUpSet;

			// Token: 0x04006418 RID: 25624
			private static readonly IntPtr NativeFieldInfoPtr_isLookDownSet;

			// Token: 0x04006419 RID: 25625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
