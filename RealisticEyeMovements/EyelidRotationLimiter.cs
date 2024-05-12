using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000773 RID: 1907
	[Serializable]
	public class EyelidRotationLimiter : Il2CppSystem.Object
	{
		// Token: 0x06009D80 RID: 40320 RVA: 0x0027F37C File Offset: 0x0027D57C
		[CallerCount(0)]
		public unsafe bool CanImport(EyelidRotationLimiter.EyelidRotationLimiterForExport import, Transform startXform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(import);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startXform);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.NativeMethodInfoPtr_CanImport_Public_Boolean_EyelidRotationLimiterForExport_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009D81 RID: 40321 RVA: 0x0027F3FC File Offset: 0x0027D5FC
		[CallerCount(0)]
		public unsafe EyelidRotationLimiter.EyelidRotationLimiterForExport GetExport(Transform startXform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(startXform);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.NativeMethodInfoPtr_GetExport_Public_EyelidRotationLimiterForExport_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new EyelidRotationLimiter.EyelidRotationLimiterForExport(intPtr2) : null;
		}

		// Token: 0x06009D82 RID: 40322 RVA: 0x0027F46C File Offset: 0x0027D66C
		[CallerCount(0)]
		public unsafe void GetRotationAndPosition(float eyeAngle, float blink01, float eyeWidenOrSquint, bool isUpper, out Quaternion rotation, ref Vector3 position, ControlData.EyelidBoneMode eyelidBoneMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eyeAngle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blink01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eyeWidenOrSquint;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUpper;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eyelidBoneMode;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.NativeMethodInfoPtr_GetRotationAndPosition_Public_Void_Single_Single_Single_Boolean_byref_Quaternion_byref_Vector3_EyelidBoneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D83 RID: 40323 RVA: 0x0027F534 File Offset: 0x0027D734
		[CallerCount(0)]
		public unsafe void Import(EyelidRotationLimiter.EyelidRotationLimiterForExport import, Transform startXform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(import);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startXform);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.NativeMethodInfoPtr_Import_Public_Void_EyelidRotationLimiterForExport_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D84 RID: 40324 RVA: 0x0027F5A8 File Offset: 0x0027D7A8
		[CallerCount(0)]
		public unsafe void RestoreClosed(ControlData.EyelidBoneMode eyelidBoneMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eyelidBoneMode;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.NativeMethodInfoPtr_RestoreClosed_Public_Void_EyelidBoneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D85 RID: 40325 RVA: 0x0027F5FC File Offset: 0x0027D7FC
		[CallerCount(0)]
		public unsafe void RestoreDefault(ControlData.EyelidBoneMode eyelidBoneMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eyelidBoneMode;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.NativeMethodInfoPtr_RestoreDefault_Public_Void_EyelidBoneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D86 RID: 40326 RVA: 0x0027F650 File Offset: 0x0027D850
		[CallerCount(0)]
		public unsafe void RestoreLookDown(ControlData.EyelidBoneMode eyelidBoneMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eyelidBoneMode;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.NativeMethodInfoPtr_RestoreLookDown_Public_Void_EyelidBoneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D87 RID: 40327 RVA: 0x0027F6A4 File Offset: 0x0027D8A4
		[CallerCount(0)]
		public unsafe void RestoreLookUp(ControlData.EyelidBoneMode eyelidBoneMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eyelidBoneMode;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.NativeMethodInfoPtr_RestoreLookUp_Public_Void_EyelidBoneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D88 RID: 40328 RVA: 0x0027F6F8 File Offset: 0x0027D8F8
		[CallerCount(0)]
		public unsafe void SaveClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.NativeMethodInfoPtr_SaveClosed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D89 RID: 40329 RVA: 0x0027F73C File Offset: 0x0027D93C
		[CallerCount(0)]
		public unsafe void SaveDefault(Transform t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.NativeMethodInfoPtr_SaveDefault_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D8A RID: 40330 RVA: 0x0027F798 File Offset: 0x0027D998
		[CallerCount(0)]
		public unsafe void SaveLookDown(float eyeMaxDownAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eyeMaxDownAngle;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.NativeMethodInfoPtr_SaveLookDown_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x0027F7EC File Offset: 0x0027D9EC
		[CallerCount(0)]
		public unsafe void SaveLookUp(float eyeMaxUpAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eyeMaxUpAngle;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.NativeMethodInfoPtr_SaveLookUp_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D8C RID: 40332 RVA: 0x0027F840 File Offset: 0x0027DA40
		[CallerCount(0)]
		public unsafe EyelidRotationLimiter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009D8D RID: 40333 RVA: 0x0027F88C File Offset: 0x0027DA8C
		// Note: this type is marked as 'beforefieldinit'.
		static EyelidRotationLimiter()
		{
			Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RealisticEyeMovements", "EyelidRotationLimiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr);
			EyelidRotationLimiter.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "transform");
			EyelidRotationLimiter.NativeFieldInfoPtr_defaultQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "defaultQ");
			EyelidRotationLimiter.NativeFieldInfoPtr_closedQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "closedQ");
			EyelidRotationLimiter.NativeFieldInfoPtr_lookUpQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "lookUpQ");
			EyelidRotationLimiter.NativeFieldInfoPtr_lookDownQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "lookDownQ");
			EyelidRotationLimiter.NativeFieldInfoPtr_eyeMaxDownAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "eyeMaxDownAngle");
			EyelidRotationLimiter.NativeFieldInfoPtr_eyeMaxUpAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "eyeMaxUpAngle");
			EyelidRotationLimiter.NativeFieldInfoPtr_defaultPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "defaultPos");
			EyelidRotationLimiter.NativeFieldInfoPtr_closedPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "closedPos");
			EyelidRotationLimiter.NativeFieldInfoPtr_lookUpPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "lookUpPos");
			EyelidRotationLimiter.NativeFieldInfoPtr_lookDownPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "lookDownPos");
			EyelidRotationLimiter.NativeFieldInfoPtr_isLookUpSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "isLookUpSet");
			EyelidRotationLimiter.NativeFieldInfoPtr_isLookDownSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "isLookDownSet");
			EyelidRotationLimiter.NativeFieldInfoPtr_isDefaultPosSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "isDefaultPosSet");
			EyelidRotationLimiter.NativeFieldInfoPtr_isClosedPosSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "isClosedPosSet");
			EyelidRotationLimiter.NativeFieldInfoPtr_isLookUpPosSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "isLookUpPosSet");
			EyelidRotationLimiter.NativeFieldInfoPtr_isLookDownPosSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "isLookDownPosSet");
			EyelidRotationLimiter.NativeMethodInfoPtr_CanImport_Public_Boolean_EyelidRotationLimiterForExport_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, 100675911);
			EyelidRotationLimiter.NativeMethodInfoPtr_GetExport_Public_EyelidRotationLimiterForExport_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, 100675912);
			EyelidRotationLimiter.NativeMethodInfoPtr_GetRotationAndPosition_Public_Void_Single_Single_Single_Boolean_byref_Quaternion_byref_Vector3_EyelidBoneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, 100675913);
			EyelidRotationLimiter.NativeMethodInfoPtr_Import_Public_Void_EyelidRotationLimiterForExport_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, 100675914);
			EyelidRotationLimiter.NativeMethodInfoPtr_RestoreClosed_Public_Void_EyelidBoneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, 100675915);
			EyelidRotationLimiter.NativeMethodInfoPtr_RestoreDefault_Public_Void_EyelidBoneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, 100675916);
			EyelidRotationLimiter.NativeMethodInfoPtr_RestoreLookDown_Public_Void_EyelidBoneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, 100675917);
			EyelidRotationLimiter.NativeMethodInfoPtr_RestoreLookUp_Public_Void_EyelidBoneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, 100675918);
			EyelidRotationLimiter.NativeMethodInfoPtr_SaveClosed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, 100675919);
			EyelidRotationLimiter.NativeMethodInfoPtr_SaveDefault_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, 100675920);
			EyelidRotationLimiter.NativeMethodInfoPtr_SaveLookDown_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, 100675921);
			EyelidRotationLimiter.NativeMethodInfoPtr_SaveLookUp_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, 100675922);
			EyelidRotationLimiter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, 100675923);
		}

		// Token: 0x06009D8E RID: 40334 RVA: 0x00002988 File Offset: 0x00000B88
		public EyelidRotationLimiter(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x06009D8F RID: 40335 RVA: 0x0027FB14 File Offset: 0x0027DD14
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr));
			}
		}

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x06009D90 RID: 40336 RVA: 0x0027FB28 File Offset: 0x0027DD28
		// (set) Token: 0x06009D91 RID: 40337 RVA: 0x0027FB5C File Offset: 0x0027DD5C
		public unsafe Transform transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x06009D92 RID: 40338 RVA: 0x0027FB84 File Offset: 0x0027DD84
		// (set) Token: 0x06009D93 RID: 40339 RVA: 0x0027FBAC File Offset: 0x0027DDAC
		public unsafe Quaternion defaultQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_defaultQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_defaultQ)) = value;
			}
		}

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x06009D94 RID: 40340 RVA: 0x0027FBD0 File Offset: 0x0027DDD0
		// (set) Token: 0x06009D95 RID: 40341 RVA: 0x0027FBF8 File Offset: 0x0027DDF8
		public unsafe Quaternion closedQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_closedQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_closedQ)) = value;
			}
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x06009D96 RID: 40342 RVA: 0x0027FC1C File Offset: 0x0027DE1C
		// (set) Token: 0x06009D97 RID: 40343 RVA: 0x0027FC44 File Offset: 0x0027DE44
		public unsafe Quaternion lookUpQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_lookUpQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_lookUpQ)) = value;
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x06009D98 RID: 40344 RVA: 0x0027FC68 File Offset: 0x0027DE68
		// (set) Token: 0x06009D99 RID: 40345 RVA: 0x0027FC90 File Offset: 0x0027DE90
		public unsafe Quaternion lookDownQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_lookDownQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_lookDownQ)) = value;
			}
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x06009D9A RID: 40346 RVA: 0x0027FCB4 File Offset: 0x0027DEB4
		// (set) Token: 0x06009D9B RID: 40347 RVA: 0x0027FCDC File Offset: 0x0027DEDC
		public unsafe float eyeMaxDownAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_eyeMaxDownAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_eyeMaxDownAngle)) = value;
			}
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x06009D9C RID: 40348 RVA: 0x0027FD00 File Offset: 0x0027DF00
		// (set) Token: 0x06009D9D RID: 40349 RVA: 0x0027FD28 File Offset: 0x0027DF28
		public unsafe float eyeMaxUpAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_eyeMaxUpAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_eyeMaxUpAngle)) = value;
			}
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x06009D9E RID: 40350 RVA: 0x0027FD4C File Offset: 0x0027DF4C
		// (set) Token: 0x06009D9F RID: 40351 RVA: 0x0027FD74 File Offset: 0x0027DF74
		public unsafe Vector3 defaultPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_defaultPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_defaultPos)) = value;
			}
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x06009DA0 RID: 40352 RVA: 0x0027FD98 File Offset: 0x0027DF98
		// (set) Token: 0x06009DA1 RID: 40353 RVA: 0x0027FDC0 File Offset: 0x0027DFC0
		public unsafe Vector3 closedPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_closedPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_closedPos)) = value;
			}
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x06009DA2 RID: 40354 RVA: 0x0027FDE4 File Offset: 0x0027DFE4
		// (set) Token: 0x06009DA3 RID: 40355 RVA: 0x0027FE0C File Offset: 0x0027E00C
		public unsafe Vector3 lookUpPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_lookUpPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_lookUpPos)) = value;
			}
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x06009DA4 RID: 40356 RVA: 0x0027FE30 File Offset: 0x0027E030
		// (set) Token: 0x06009DA5 RID: 40357 RVA: 0x0027FE58 File Offset: 0x0027E058
		public unsafe Vector3 lookDownPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_lookDownPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_lookDownPos)) = value;
			}
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x06009DA6 RID: 40358 RVA: 0x0027FE7C File Offset: 0x0027E07C
		// (set) Token: 0x06009DA7 RID: 40359 RVA: 0x0027FEA4 File Offset: 0x0027E0A4
		public unsafe bool isLookUpSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_isLookUpSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_isLookUpSet)) = value;
			}
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x06009DA8 RID: 40360 RVA: 0x0027FEC8 File Offset: 0x0027E0C8
		// (set) Token: 0x06009DA9 RID: 40361 RVA: 0x0027FEF0 File Offset: 0x0027E0F0
		public unsafe bool isLookDownSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_isLookDownSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_isLookDownSet)) = value;
			}
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x06009DAA RID: 40362 RVA: 0x0027FF14 File Offset: 0x0027E114
		// (set) Token: 0x06009DAB RID: 40363 RVA: 0x0027FF3C File Offset: 0x0027E13C
		public unsafe bool isDefaultPosSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_isDefaultPosSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_isDefaultPosSet)) = value;
			}
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x06009DAC RID: 40364 RVA: 0x0027FF60 File Offset: 0x0027E160
		// (set) Token: 0x06009DAD RID: 40365 RVA: 0x0027FF88 File Offset: 0x0027E188
		public unsafe bool isClosedPosSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_isClosedPosSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_isClosedPosSet)) = value;
			}
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x06009DAE RID: 40366 RVA: 0x0027FFAC File Offset: 0x0027E1AC
		// (set) Token: 0x06009DAF RID: 40367 RVA: 0x0027FFD4 File Offset: 0x0027E1D4
		public unsafe bool isLookUpPosSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_isLookUpPosSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_isLookUpPosSet)) = value;
			}
		}

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x06009DB0 RID: 40368 RVA: 0x0027FFF8 File Offset: 0x0027E1F8
		// (set) Token: 0x06009DB1 RID: 40369 RVA: 0x00280020 File Offset: 0x0027E220
		public unsafe bool isLookDownPosSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_isLookDownPosSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.NativeFieldInfoPtr_isLookDownPosSet)) = value;
			}
		}

		// Token: 0x0400641A RID: 25626
		private static readonly IntPtr NativeFieldInfoPtr_transform;

		// Token: 0x0400641B RID: 25627
		private static readonly IntPtr NativeFieldInfoPtr_defaultQ;

		// Token: 0x0400641C RID: 25628
		private static readonly IntPtr NativeFieldInfoPtr_closedQ;

		// Token: 0x0400641D RID: 25629
		private static readonly IntPtr NativeFieldInfoPtr_lookUpQ;

		// Token: 0x0400641E RID: 25630
		private static readonly IntPtr NativeFieldInfoPtr_lookDownQ;

		// Token: 0x0400641F RID: 25631
		private static readonly IntPtr NativeFieldInfoPtr_eyeMaxDownAngle;

		// Token: 0x04006420 RID: 25632
		private static readonly IntPtr NativeFieldInfoPtr_eyeMaxUpAngle;

		// Token: 0x04006421 RID: 25633
		private static readonly IntPtr NativeFieldInfoPtr_defaultPos;

		// Token: 0x04006422 RID: 25634
		private static readonly IntPtr NativeFieldInfoPtr_closedPos;

		// Token: 0x04006423 RID: 25635
		private static readonly IntPtr NativeFieldInfoPtr_lookUpPos;

		// Token: 0x04006424 RID: 25636
		private static readonly IntPtr NativeFieldInfoPtr_lookDownPos;

		// Token: 0x04006425 RID: 25637
		private static readonly IntPtr NativeFieldInfoPtr_isLookUpSet;

		// Token: 0x04006426 RID: 25638
		private static readonly IntPtr NativeFieldInfoPtr_isLookDownSet;

		// Token: 0x04006427 RID: 25639
		private static readonly IntPtr NativeFieldInfoPtr_isDefaultPosSet;

		// Token: 0x04006428 RID: 25640
		private static readonly IntPtr NativeFieldInfoPtr_isClosedPosSet;

		// Token: 0x04006429 RID: 25641
		private static readonly IntPtr NativeFieldInfoPtr_isLookUpPosSet;

		// Token: 0x0400642A RID: 25642
		private static readonly IntPtr NativeFieldInfoPtr_isLookDownPosSet;

		// Token: 0x0400642B RID: 25643
		private static readonly IntPtr NativeMethodInfoPtr_CanImport_Public_Boolean_EyelidRotationLimiterForExport_Transform_0;

		// Token: 0x0400642C RID: 25644
		private static readonly IntPtr NativeMethodInfoPtr_GetExport_Public_EyelidRotationLimiterForExport_Transform_0;

		// Token: 0x0400642D RID: 25645
		private static readonly IntPtr NativeMethodInfoPtr_GetRotationAndPosition_Public_Void_Single_Single_Single_Boolean_byref_Quaternion_byref_Vector3_EyelidBoneMode_0;

		// Token: 0x0400642E RID: 25646
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Void_EyelidRotationLimiterForExport_Transform_0;

		// Token: 0x0400642F RID: 25647
		private static readonly IntPtr NativeMethodInfoPtr_RestoreClosed_Public_Void_EyelidBoneMode_0;

		// Token: 0x04006430 RID: 25648
		private static readonly IntPtr NativeMethodInfoPtr_RestoreDefault_Public_Void_EyelidBoneMode_0;

		// Token: 0x04006431 RID: 25649
		private static readonly IntPtr NativeMethodInfoPtr_RestoreLookDown_Public_Void_EyelidBoneMode_0;

		// Token: 0x04006432 RID: 25650
		private static readonly IntPtr NativeMethodInfoPtr_RestoreLookUp_Public_Void_EyelidBoneMode_0;

		// Token: 0x04006433 RID: 25651
		private static readonly IntPtr NativeMethodInfoPtr_SaveClosed_Public_Void_0;

		// Token: 0x04006434 RID: 25652
		private static readonly IntPtr NativeMethodInfoPtr_SaveDefault_Public_Void_Transform_0;

		// Token: 0x04006435 RID: 25653
		private static readonly IntPtr NativeMethodInfoPtr_SaveLookDown_Public_Void_Single_0;

		// Token: 0x04006436 RID: 25654
		private static readonly IntPtr NativeMethodInfoPtr_SaveLookUp_Public_Void_Single_0;

		// Token: 0x04006437 RID: 25655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000774 RID: 1908
		[Serializable]
		public class EyelidRotationLimiterForExport : Il2CppSystem.Object
		{
			// Token: 0x06009DB2 RID: 40370 RVA: 0x00280044 File Offset: 0x0027E244
			[CallerCount(0)]
			public unsafe EyelidRotationLimiterForExport() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06009DB3 RID: 40371 RVA: 0x00280090 File Offset: 0x0027E290
			// Note: this type is marked as 'beforefieldinit'.
			static EyelidRotationLimiterForExport()
			{
				Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EyelidRotationLimiter>.NativeClassPtr, "EyelidRotationLimiterForExport");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr);
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_transformPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "transformPath");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_defaultQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "defaultQ");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_closedQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "closedQ");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_lookUpQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "lookUpQ");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_lookDownQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "lookDownQ");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_eyeMaxDownAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "eyeMaxDownAngle");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_eyeMaxUpAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "eyeMaxUpAngle");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_defaultPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "defaultPos");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_closedPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "closedPos");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_lookUpPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "lookUpPos");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_lookDownPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "lookDownPos");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isLookUpSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "isLookUpSet");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isLookDownSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "isLookDownSet");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isDefaultPosSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "isDefaultPosSet");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isClosedPosSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "isClosedPosSet");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isLookUpPosSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "isLookUpPosSet");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isLookDownPosSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, "isLookDownPosSet");
				EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr, 100675924);
			}

			// Token: 0x06009DB4 RID: 40372 RVA: 0x00002988 File Offset: 0x00000B88
			public EyelidRotationLimiterForExport(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x1700385F RID: 14431
			// (get) Token: 0x06009DB5 RID: 40373 RVA: 0x00280223 File Offset: 0x0027E423
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EyelidRotationLimiter.EyelidRotationLimiterForExport>.NativeClassPtr));
				}
			}

			// Token: 0x17003860 RID: 14432
			// (get) Token: 0x06009DB6 RID: 40374 RVA: 0x00280234 File Offset: 0x0027E434
			// (set) Token: 0x06009DB7 RID: 40375 RVA: 0x0028025D File Offset: 0x0027E45D
			public unsafe string transformPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_transformPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_transformPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003861 RID: 14433
			// (get) Token: 0x06009DB8 RID: 40376 RVA: 0x00280284 File Offset: 0x0027E484
			// (set) Token: 0x06009DB9 RID: 40377 RVA: 0x002802AC File Offset: 0x0027E4AC
			public unsafe SerializableQuaternion defaultQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_defaultQ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_defaultQ)) = value;
				}
			}

			// Token: 0x17003862 RID: 14434
			// (get) Token: 0x06009DBA RID: 40378 RVA: 0x002802D0 File Offset: 0x0027E4D0
			// (set) Token: 0x06009DBB RID: 40379 RVA: 0x002802F8 File Offset: 0x0027E4F8
			public unsafe SerializableQuaternion closedQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_closedQ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_closedQ)) = value;
				}
			}

			// Token: 0x17003863 RID: 14435
			// (get) Token: 0x06009DBC RID: 40380 RVA: 0x0028031C File Offset: 0x0027E51C
			// (set) Token: 0x06009DBD RID: 40381 RVA: 0x00280344 File Offset: 0x0027E544
			public unsafe SerializableQuaternion lookUpQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_lookUpQ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_lookUpQ)) = value;
				}
			}

			// Token: 0x17003864 RID: 14436
			// (get) Token: 0x06009DBE RID: 40382 RVA: 0x00280368 File Offset: 0x0027E568
			// (set) Token: 0x06009DBF RID: 40383 RVA: 0x00280390 File Offset: 0x0027E590
			public unsafe SerializableQuaternion lookDownQ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_lookDownQ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_lookDownQ)) = value;
				}
			}

			// Token: 0x17003865 RID: 14437
			// (get) Token: 0x06009DC0 RID: 40384 RVA: 0x002803B4 File Offset: 0x0027E5B4
			// (set) Token: 0x06009DC1 RID: 40385 RVA: 0x002803DC File Offset: 0x0027E5DC
			public unsafe float eyeMaxDownAngle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_eyeMaxDownAngle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_eyeMaxDownAngle)) = value;
				}
			}

			// Token: 0x17003866 RID: 14438
			// (get) Token: 0x06009DC2 RID: 40386 RVA: 0x00280400 File Offset: 0x0027E600
			// (set) Token: 0x06009DC3 RID: 40387 RVA: 0x00280428 File Offset: 0x0027E628
			public unsafe float eyeMaxUpAngle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_eyeMaxUpAngle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_eyeMaxUpAngle)) = value;
				}
			}

			// Token: 0x17003867 RID: 14439
			// (get) Token: 0x06009DC4 RID: 40388 RVA: 0x0028044C File Offset: 0x0027E64C
			// (set) Token: 0x06009DC5 RID: 40389 RVA: 0x00280474 File Offset: 0x0027E674
			public unsafe SerializableVector3 defaultPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_defaultPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_defaultPos)) = value;
				}
			}

			// Token: 0x17003868 RID: 14440
			// (get) Token: 0x06009DC6 RID: 40390 RVA: 0x00280498 File Offset: 0x0027E698
			// (set) Token: 0x06009DC7 RID: 40391 RVA: 0x002804C0 File Offset: 0x0027E6C0
			public unsafe SerializableVector3 closedPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_closedPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_closedPos)) = value;
				}
			}

			// Token: 0x17003869 RID: 14441
			// (get) Token: 0x06009DC8 RID: 40392 RVA: 0x002804E4 File Offset: 0x0027E6E4
			// (set) Token: 0x06009DC9 RID: 40393 RVA: 0x0028050C File Offset: 0x0027E70C
			public unsafe SerializableVector3 lookUpPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_lookUpPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_lookUpPos)) = value;
				}
			}

			// Token: 0x1700386A RID: 14442
			// (get) Token: 0x06009DCA RID: 40394 RVA: 0x00280530 File Offset: 0x0027E730
			// (set) Token: 0x06009DCB RID: 40395 RVA: 0x00280558 File Offset: 0x0027E758
			public unsafe SerializableVector3 lookDownPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_lookDownPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_lookDownPos)) = value;
				}
			}

			// Token: 0x1700386B RID: 14443
			// (get) Token: 0x06009DCC RID: 40396 RVA: 0x0028057C File Offset: 0x0027E77C
			// (set) Token: 0x06009DCD RID: 40397 RVA: 0x002805A4 File Offset: 0x0027E7A4
			public unsafe bool isLookUpSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isLookUpSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isLookUpSet)) = value;
				}
			}

			// Token: 0x1700386C RID: 14444
			// (get) Token: 0x06009DCE RID: 40398 RVA: 0x002805C8 File Offset: 0x0027E7C8
			// (set) Token: 0x06009DCF RID: 40399 RVA: 0x002805F0 File Offset: 0x0027E7F0
			public unsafe bool isLookDownSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isLookDownSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isLookDownSet)) = value;
				}
			}

			// Token: 0x1700386D RID: 14445
			// (get) Token: 0x06009DD0 RID: 40400 RVA: 0x00280614 File Offset: 0x0027E814
			// (set) Token: 0x06009DD1 RID: 40401 RVA: 0x0028063C File Offset: 0x0027E83C
			public unsafe bool isDefaultPosSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isDefaultPosSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isDefaultPosSet)) = value;
				}
			}

			// Token: 0x1700386E RID: 14446
			// (get) Token: 0x06009DD2 RID: 40402 RVA: 0x00280660 File Offset: 0x0027E860
			// (set) Token: 0x06009DD3 RID: 40403 RVA: 0x00280688 File Offset: 0x0027E888
			public unsafe bool isClosedPosSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isClosedPosSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isClosedPosSet)) = value;
				}
			}

			// Token: 0x1700386F RID: 14447
			// (get) Token: 0x06009DD4 RID: 40404 RVA: 0x002806AC File Offset: 0x0027E8AC
			// (set) Token: 0x06009DD5 RID: 40405 RVA: 0x002806D4 File Offset: 0x0027E8D4
			public unsafe bool isLookUpPosSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isLookUpPosSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isLookUpPosSet)) = value;
				}
			}

			// Token: 0x17003870 RID: 14448
			// (get) Token: 0x06009DD6 RID: 40406 RVA: 0x002806F8 File Offset: 0x0027E8F8
			// (set) Token: 0x06009DD7 RID: 40407 RVA: 0x00280720 File Offset: 0x0027E920
			public unsafe bool isLookDownPosSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isLookDownPosSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyelidRotationLimiter.EyelidRotationLimiterForExport.NativeFieldInfoPtr_isLookDownPosSet)) = value;
				}
			}

			// Token: 0x04006438 RID: 25656
			private static readonly IntPtr NativeFieldInfoPtr_transformPath;

			// Token: 0x04006439 RID: 25657
			private static readonly IntPtr NativeFieldInfoPtr_defaultQ;

			// Token: 0x0400643A RID: 25658
			private static readonly IntPtr NativeFieldInfoPtr_closedQ;

			// Token: 0x0400643B RID: 25659
			private static readonly IntPtr NativeFieldInfoPtr_lookUpQ;

			// Token: 0x0400643C RID: 25660
			private static readonly IntPtr NativeFieldInfoPtr_lookDownQ;

			// Token: 0x0400643D RID: 25661
			private static readonly IntPtr NativeFieldInfoPtr_eyeMaxDownAngle;

			// Token: 0x0400643E RID: 25662
			private static readonly IntPtr NativeFieldInfoPtr_eyeMaxUpAngle;

			// Token: 0x0400643F RID: 25663
			private static readonly IntPtr NativeFieldInfoPtr_defaultPos;

			// Token: 0x04006440 RID: 25664
			private static readonly IntPtr NativeFieldInfoPtr_closedPos;

			// Token: 0x04006441 RID: 25665
			private static readonly IntPtr NativeFieldInfoPtr_lookUpPos;

			// Token: 0x04006442 RID: 25666
			private static readonly IntPtr NativeFieldInfoPtr_lookDownPos;

			// Token: 0x04006443 RID: 25667
			private static readonly IntPtr NativeFieldInfoPtr_isLookUpSet;

			// Token: 0x04006444 RID: 25668
			private static readonly IntPtr NativeFieldInfoPtr_isLookDownSet;

			// Token: 0x04006445 RID: 25669
			private static readonly IntPtr NativeFieldInfoPtr_isDefaultPosSet;

			// Token: 0x04006446 RID: 25670
			private static readonly IntPtr NativeFieldInfoPtr_isClosedPosSet;

			// Token: 0x04006447 RID: 25671
			private static readonly IntPtr NativeFieldInfoPtr_isLookUpPosSet;

			// Token: 0x04006448 RID: 25672
			private static readonly IntPtr NativeFieldInfoPtr_isLookDownPosSet;

			// Token: 0x04006449 RID: 25673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
