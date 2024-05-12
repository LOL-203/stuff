using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000782 RID: 1922
	public class EyeAndHeadAnimator : MonoBehaviour
	{
		// Token: 0x06009F15 RID: 40725 RVA: 0x00284D98 File Offset: 0x00282F98
		[CallerCount(0)]
		public unsafe void add_OnCannotGetTargetIntoView(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_add_OnCannotGetTargetIntoView_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F16 RID: 40726 RVA: 0x00284DF4 File Offset: 0x00282FF4
		[CallerCount(0)]
		public unsafe void remove_OnCannotGetTargetIntoView(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_remove_OnCannotGetTargetIntoView_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F17 RID: 40727 RVA: 0x00284E50 File Offset: 0x00283050
		[CallerCount(0)]
		public unsafe void add_OnTargetDestroyed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_add_OnTargetDestroyed_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F18 RID: 40728 RVA: 0x00284EAC File Offset: 0x002830AC
		[CallerCount(0)]
		public unsafe void remove_OnTargetDestroyed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_remove_OnTargetDestroyed_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x1700397F RID: 14719
		// (get) Token: 0x06009F19 RID: 40729 RVA: 0x00284F08 File Offset: 0x00283108
		// (set) Token: 0x06009F1A RID: 40730 RVA: 0x00284F58 File Offset: 0x00283158
		public unsafe float blink01
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_get_blink01_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_set_blink01_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003980 RID: 14720
		// (get) Token: 0x06009F1B RID: 40731 RVA: 0x00284FAC File Offset: 0x002831AC
		// (set) Token: 0x06009F1C RID: 40732 RVA: 0x00284FFC File Offset: 0x002831FC
		public unsafe float eyeDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_get_eyeDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_set_eyeDistance_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003981 RID: 14721
		// (get) Token: 0x06009F1D RID: 40733 RVA: 0x00285050 File Offset: 0x00283250
		// (set) Token: 0x06009F1E RID: 40734 RVA: 0x002850A0 File Offset: 0x002832A0
		public unsafe float eyeDistanceScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_get_eyeDistanceScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_set_eyeDistanceScale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003982 RID: 14722
		// (get) Token: 0x06009F1F RID: 40735 RVA: 0x002850F4 File Offset: 0x002832F4
		// (set) Token: 0x06009F20 RID: 40736 RVA: 0x0028514C File Offset: 0x0028334C
		public unsafe Transform eyesRootXform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_get_eyesRootXform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_set_eyesRootXform_Private_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003983 RID: 14723
		// (get) Token: 0x06009F21 RID: 40737 RVA: 0x002851A8 File Offset: 0x002833A8
		// (set) Token: 0x06009F22 RID: 40738 RVA: 0x00285200 File Offset: 0x00283400
		public unsafe Transform headParentXform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_get_headParentXform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_set_headParentXform_Private_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009F23 RID: 40739 RVA: 0x0028525C File Offset: 0x0028345C
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F24 RID: 40740 RVA: 0x002852A0 File Offset: 0x002834A0
		[CallerCount(0)]
		public unsafe void Blink(bool isShortBlink = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isShortBlink;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_Blink_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F25 RID: 40741 RVA: 0x002852F4 File Offset: 0x002834F4
		[CallerCount(0)]
		public unsafe bool CanGetIntoView(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_CanGetIntoView_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F26 RID: 40742 RVA: 0x00285358 File Offset: 0x00283558
		[CallerCount(0)]
		public unsafe bool CanChangePointOfAttention()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_CanChangePointOfAttention_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F27 RID: 40743 RVA: 0x002853A8 File Offset: 0x002835A8
		[CallerCount(0)]
		public unsafe bool CanImportFromFile(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_CanImportFromFile_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F28 RID: 40744 RVA: 0x00285410 File Offset: 0x00283610
		[CallerCount(0)]
		public unsafe void CheckIdleLookTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_CheckIdleLookTargets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F29 RID: 40745 RVA: 0x00285454 File Offset: 0x00283654
		[CallerCount(0)]
		public unsafe void CheckLatencies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_CheckLatencies_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F2A RID: 40746 RVA: 0x00285498 File Offset: 0x00283698
		[CallerCount(0)]
		public unsafe void CheckMacroSaccades()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_CheckMacroSaccades_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F2B RID: 40747 RVA: 0x002854DC File Offset: 0x002836DC
		[CallerCount(0)]
		public unsafe void CheckMicroSaccades()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_CheckMicroSaccades_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F2C RID: 40748 RVA: 0x00285520 File Offset: 0x00283720
		[CallerCount(0)]
		public unsafe float ClampLeftHorizEyeAngle(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_ClampLeftHorizEyeAngle_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F2D RID: 40749 RVA: 0x00285584 File Offset: 0x00283784
		[CallerCount(0)]
		public unsafe float ClampRightHorizEyeAngle(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_ClampRightHorizEyeAngle_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F2E RID: 40750 RVA: 0x002855E8 File Offset: 0x002837E8
		[CallerCount(0)]
		public unsafe void ClearLookTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_ClearLookTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F2F RID: 40751 RVA: 0x0028562C File Offset: 0x0028382C
		[CallerCount(0)]
		public unsafe void DrawSightlinesInEditor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_DrawSightlinesInEditor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F30 RID: 40752 RVA: 0x00285670 File Offset: 0x00283870
		[CallerCount(0)]
		public unsafe void ExportToFile(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_ExportToFile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F31 RID: 40753 RVA: 0x002856CC File Offset: 0x002838CC
		[CallerCount(0)]
		public unsafe Vector3 GetCurrentEyeTargetPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_GetCurrentEyeTargetPos_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F32 RID: 40754 RVA: 0x0028571C File Offset: 0x0028391C
		[CallerCount(0)]
		public unsafe Vector3 GetCurrentHeadTargetPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_GetCurrentHeadTargetPos_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F33 RID: 40755 RVA: 0x0028576C File Offset: 0x0028396C
		[CallerCount(0)]
		public unsafe Vector3 GetHeadDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_GetHeadDirection_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F34 RID: 40756 RVA: 0x002857BC File Offset: 0x002839BC
		[CallerCount(0)]
		public unsafe Vector3 GetLeftEyeDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_GetLeftEyeDirection_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F35 RID: 40757 RVA: 0x0028580C File Offset: 0x00283A0C
		[CallerCount(0)]
		public unsafe Vector3 GetLookTargetPosForSocialTriangle(EyeAndHeadAnimator.FaceLookTarget playerFaceLookTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playerFaceLookTarget;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_GetLookTargetPosForSocialTriangle_Private_Vector3_FaceLookTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x00285870 File Offset: 0x00283A70
		[CallerCount(0)]
		public unsafe Vector3 GetOwnEyeCenter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_GetOwnEyeCenter_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F37 RID: 40759 RVA: 0x002858C0 File Offset: 0x00283AC0
		[CallerCount(0)]
		public unsafe Transform GetOwnEyeCenterXform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_GetOwnEyeCenterXform_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}

		// Token: 0x06009F38 RID: 40760 RVA: 0x00285918 File Offset: 0x00283B18
		[CallerCount(0)]
		public unsafe Vector3 GetOwnLookDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_GetOwnLookDirection_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F39 RID: 40761 RVA: 0x00285968 File Offset: 0x00283B68
		[CallerCount(0)]
		public unsafe Vector3 GetRightEyeDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_GetRightEyeDirection_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F3A RID: 40762 RVA: 0x002859B8 File Offset: 0x00283BB8
		[CallerCount(0)]
		public unsafe float GetStareAngleMeAtTarget(Vector3 target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref target;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_GetStareAngleMeAtTarget_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F3B RID: 40763 RVA: 0x00285A1C File Offset: 0x00283C1C
		[CallerCount(0)]
		public unsafe float GetStareAngleTargetAtMe(Transform targetXform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetXform);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_GetStareAngleTargetAtMe_Public_Single_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F3C RID: 40764 RVA: 0x00285A84 File Offset: 0x00283C84
		[CallerCount(0)]
		public unsafe void ImportFromFile(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_ImportFromFile_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F3D RID: 40765 RVA: 0x00285AE0 File Offset: 0x00283CE0
		[CallerCount(0)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F3E RID: 40766 RVA: 0x00285B24 File Offset: 0x00283D24
		[CallerCount(0)]
		public unsafe bool IsInView(Vector3 target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref target;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_IsInView_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F3F RID: 40767 RVA: 0x00285B88 File Offset: 0x00283D88
		[CallerCount(0)]
		public unsafe bool IsLookingAtFace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_IsLookingAtFace_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F40 RID: 40768 RVA: 0x00285BD8 File Offset: 0x00283DD8
		[CallerCount(0)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F41 RID: 40769 RVA: 0x00285C1C File Offset: 0x00283E1C
		[CallerCount(0)]
		public unsafe float LimitHorizontalHeadAngle(float headAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref headAngle;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_LimitHorizontalHeadAngle_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F42 RID: 40770 RVA: 0x00285C80 File Offset: 0x00283E80
		[CallerCount(0)]
		public unsafe float LimitVerticalHeadAngle(float headAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref headAngle;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_LimitVerticalHeadAngle_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009F43 RID: 40771 RVA: 0x00285CE4 File Offset: 0x00283EE4
		[CallerCount(0)]
		public unsafe void LookAtFace(Transform eyeCenterXform, [Optional] float headLatency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eyeCenterXform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headLatency;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_LookAtFace_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F44 RID: 40772 RVA: 0x00285D50 File Offset: 0x00283F50
		[CallerCount(0)]
		public unsafe void LookAtFace(Transform leftEyeXform, Transform rightEyeXform, Transform eyesCenterXform, [Optional] float headLatency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(leftEyeXform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rightEyeXform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eyesCenterXform);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headLatency;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_LookAtFace_Public_Void_Transform_Transform_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F45 RID: 40773 RVA: 0x00285DEC File Offset: 0x00283FEC
		[CallerCount(0)]
		public unsafe void LookAtSpecificThing(Transform poi, [Optional] float headLatency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(poi);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headLatency;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_LookAtSpecificThing_Public_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F46 RID: 40774 RVA: 0x00285E58 File Offset: 0x00284058
		[CallerCount(0)]
		public unsafe void LookAtSpecificThing(Vector3 point, [Optional] float headLatency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headLatency;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_LookAtSpecificThing_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F47 RID: 40775 RVA: 0x00285EC0 File Offset: 0x002840C0
		[CallerCount(0)]
		public unsafe void LookAroundIdly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_LookAroundIdly_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F48 RID: 40776 RVA: 0x00285F04 File Offset: 0x00284104
		[CallerCount(0)]
		public unsafe void LookAtAreaAround(Transform poi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(poi);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_LookAtAreaAround_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F49 RID: 40777 RVA: 0x00285F60 File Offset: 0x00284160
		[CallerCount(0)]
		public unsafe void LookAtAreaAround(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_LookAtAreaAround_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F4A RID: 40778 RVA: 0x00285FB4 File Offset: 0x002841B4
		[CallerCount(0)]
		public unsafe void OnAnimatorIK()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_OnAnimatorIK_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F4B RID: 40779 RVA: 0x00285FF8 File Offset: 0x002841F8
		[CallerCount(0)]
		public unsafe void OnCreatedXformDestroyed(DestroyNotifier destroyNotifer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destroyNotifer);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_OnCreatedXformDestroyed_Private_Void_DestroyNotifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F4C RID: 40780 RVA: 0x00286054 File Offset: 0x00284254
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F4D RID: 40781 RVA: 0x00286098 File Offset: 0x00284298
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F4E RID: 40782 RVA: 0x002860DC File Offset: 0x002842DC
		[CallerCount(0)]
		public unsafe void SetMacroSaccadeTarget(Vector3 targetGlobal, bool blinkIfEyesMoveEnough = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetGlobal;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blinkIfEyesMoveEnough;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_SetMacroSaccadeTarget_Private_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F4F RID: 40783 RVA: 0x00286144 File Offset: 0x00284344
		[CallerCount(0)]
		public unsafe void SetMicroSaccadeTarget(Vector3 targetGlobal, bool blinkIfEyesMoveEnough = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetGlobal;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blinkIfEyesMoveEnough;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_SetMicroSaccadeTarget_Private_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F50 RID: 40784 RVA: 0x002861AC File Offset: 0x002843AC
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F51 RID: 40785 RVA: 0x002861F0 File Offset: 0x002843F0
		[CallerCount(0)]
		public unsafe void StartEyeMovement([Optional] Transform targetXform, bool blinkIfEyesMoveEnough = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetXform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blinkIfEyesMoveEnough;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_StartEyeMovement_Private_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F52 RID: 40786 RVA: 0x0028625C File Offset: 0x0028445C
		[CallerCount(0)]
		public unsafe void StartHeadMovement([Optional] Transform targetXform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetXform);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_StartHeadMovement_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F53 RID: 40787 RVA: 0x002862B8 File Offset: 0x002844B8
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F54 RID: 40788 RVA: 0x002862FC File Offset: 0x002844FC
		[CallerCount(0)]
		public unsafe void Update1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_Update1_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F55 RID: 40789 RVA: 0x00286340 File Offset: 0x00284540
		[CallerCount(0)]
		public unsafe void Update2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_Update2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F56 RID: 40790 RVA: 0x00286384 File Offset: 0x00284584
		[CallerCount(0)]
		public unsafe void UpdateBlinking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_UpdateBlinking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F57 RID: 40791 RVA: 0x002863C8 File Offset: 0x002845C8
		[CallerCount(0)]
		public unsafe void UpdateEyelids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_UpdateEyelids_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F58 RID: 40792 RVA: 0x0028640C File Offset: 0x0028460C
		[CallerCount(0)]
		public unsafe void UpdateEyeMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_UpdateEyeMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F59 RID: 40793 RVA: 0x00286450 File Offset: 0x00284650
		[CallerCount(0)]
		public unsafe void UpdateHeadMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr_UpdateHeadMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F5A RID: 40794 RVA: 0x00286494 File Offset: 0x00284694
		[CallerCount(0)]
		public unsafe EyeAndHeadAnimator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009F5B RID: 40795 RVA: 0x002864E0 File Offset: 0x002846E0
		// Note: this type is marked as 'beforefieldinit'.
		static EyeAndHeadAnimator()
		{
			Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RealisticEyeMovements", "EyeAndHeadAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr);
			EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxLimitedHorizontalHeadAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kMaxLimitedHorizontalHeadAngle");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxLimitedVerticalHeadAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kMaxLimitedVerticalHeadAngle");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxHorizViewAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kMaxHorizViewAngle");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxVertViewAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kMaxVertViewAngle");
			EyeAndHeadAnimator.NativeFieldInfoPtr_OnCannotGetTargetIntoView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "OnCannotGetTargetIntoView");
			EyeAndHeadAnimator.NativeFieldInfoPtr_OnTargetDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "OnTargetDestroyed");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headSpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headSpeedModifier");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headWeight");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headBoneNonMecanimXform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headBoneNonMecanimXform");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headBoneNonMecanimFromRootQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headBoneNonMecanimFromRootQ");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kHeadJitterFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kHeadJitterFrequency");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kHeadJitterAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kHeadJitterAmount");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headJitterRotationComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headJitterRotationComponents");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kHeadJitterOctave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kHeadJitterOctave");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headJitterTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headJitterTime");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headJitterNoiseVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headJitterNoiseVectors");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headControl");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headTweenMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headTweenMethod");
			EyeAndHeadAnimator.NativeFieldInfoPtr_useMicroSaccades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "useMicroSaccades");
			EyeAndHeadAnimator.NativeFieldInfoPtr_useMacroSaccades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "useMacroSaccades");
			EyeAndHeadAnimator.NativeFieldInfoPtr_useHeadJitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "useHeadJitter");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kDrawSightlinesInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kDrawSightlinesInEditor");
			EyeAndHeadAnimator.NativeFieldInfoPtr_areUpdatedControlledExternally = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "areUpdatedControlledExternally");
			EyeAndHeadAnimator.NativeFieldInfoPtr_controlData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "controlData");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kMinNextBlinkTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kMinNextBlinkTime");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxNextBlinkTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kMaxNextBlinkTime");
			EyeAndHeadAnimator.NativeFieldInfoPtr_blinkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "blinkSpeed");
			EyeAndHeadAnimator.NativeFieldInfoPtr_eyelidsFollowEyesVertically = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "eyelidsFollowEyesVertically");
			EyeAndHeadAnimator.NativeFieldInfoPtr__blink01_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "<blink01>k__BackingField");
			EyeAndHeadAnimator.NativeFieldInfoPtr_useUpperEyelids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "useUpperEyelids");
			EyeAndHeadAnimator.NativeFieldInfoPtr_useLowerEyelids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "useLowerEyelids");
			EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfNextBlink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "timeOfNextBlink");
			EyeAndHeadAnimator.NativeFieldInfoPtr_blinkState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "blinkState");
			EyeAndHeadAnimator.NativeFieldInfoPtr_blinkStateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "blinkStateTime");
			EyeAndHeadAnimator.NativeFieldInfoPtr_blinkDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "blinkDuration");
			EyeAndHeadAnimator.NativeFieldInfoPtr_isShortBlink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "isShortBlink");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkCloseTimeShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kBlinkCloseTimeShort");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkOpenTimeShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kBlinkOpenTimeShort");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkCloseTimeLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kBlinkCloseTimeLong");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkOpenTimeLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kBlinkOpenTimeLong");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkKeepingClosedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kBlinkKeepingClosedTime");
			EyeAndHeadAnimator.NativeFieldInfoPtr_maxEyeHorizAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "maxEyeHorizAngle");
			EyeAndHeadAnimator.NativeFieldInfoPtr_maxEyeHorizAngleTowardsNose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "maxEyeHorizAngleTowardsNose");
			EyeAndHeadAnimator.NativeFieldInfoPtr_crossEyeCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "crossEyeCorrection");
			EyeAndHeadAnimator.NativeFieldInfoPtr_nervousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "nervousness");
			EyeAndHeadAnimator.NativeFieldInfoPtr_limitHeadAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "limitHeadAngle");
			EyeAndHeadAnimator.NativeFieldInfoPtr__eyeDistance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "<eyeDistance>k__BackingField");
			EyeAndHeadAnimator.NativeFieldInfoPtr__eyeDistanceScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "<eyeDistanceScale>k__BackingField");
			EyeAndHeadAnimator.NativeFieldInfoPtr_leftEyeAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "leftEyeAnchor");
			EyeAndHeadAnimator.NativeFieldInfoPtr_rightEyeAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "rightEyeAnchor");
			EyeAndHeadAnimator.NativeFieldInfoPtr_leftMaxSpeedHoriz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "leftMaxSpeedHoriz");
			EyeAndHeadAnimator.NativeFieldInfoPtr_leftHorizDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "leftHorizDuration");
			EyeAndHeadAnimator.NativeFieldInfoPtr_leftMaxSpeedVert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "leftMaxSpeedVert");
			EyeAndHeadAnimator.NativeFieldInfoPtr_leftVertDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "leftVertDuration");
			EyeAndHeadAnimator.NativeFieldInfoPtr_leftCurrentSpeedX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "leftCurrentSpeedX");
			EyeAndHeadAnimator.NativeFieldInfoPtr_leftCurrentSpeedY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "leftCurrentSpeedY");
			EyeAndHeadAnimator.NativeFieldInfoPtr_rightMaxSpeedHoriz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "rightMaxSpeedHoriz");
			EyeAndHeadAnimator.NativeFieldInfoPtr_rightHorizDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "rightHorizDuration");
			EyeAndHeadAnimator.NativeFieldInfoPtr_rightMaxSpeedVert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "rightMaxSpeedVert");
			EyeAndHeadAnimator.NativeFieldInfoPtr_rightVertDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "rightVertDuration");
			EyeAndHeadAnimator.NativeFieldInfoPtr_rightCurrentSpeedX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "rightCurrentSpeedX");
			EyeAndHeadAnimator.NativeFieldInfoPtr_rightCurrentSpeedY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "rightCurrentSpeedY");
			EyeAndHeadAnimator.NativeFieldInfoPtr_startLeftEyeHorizDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "startLeftEyeHorizDuration");
			EyeAndHeadAnimator.NativeFieldInfoPtr_startLeftEyeVertDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "startLeftEyeVertDuration");
			EyeAndHeadAnimator.NativeFieldInfoPtr_startLeftEyeMaxSpeedHoriz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "startLeftEyeMaxSpeedHoriz");
			EyeAndHeadAnimator.NativeFieldInfoPtr_startLeftEyeMaxSpeedVert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "startLeftEyeMaxSpeedVert");
			EyeAndHeadAnimator.NativeFieldInfoPtr_startRightEyeHorizDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "startRightEyeHorizDuration");
			EyeAndHeadAnimator.NativeFieldInfoPtr_startRightEyeVertDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "startRightEyeVertDuration");
			EyeAndHeadAnimator.NativeFieldInfoPtr_startRightEyeMaxSpeedHoriz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "startRightEyeMaxSpeedHoriz");
			EyeAndHeadAnimator.NativeFieldInfoPtr_startRightEyeMaxSpeedVert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "startRightEyeMaxSpeedVert");
			EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfEyeMovementStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "timeOfEyeMovementStart");
			EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfHeadMovementStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "timeOfHeadMovementStart");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headMaxSpeedHoriz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headMaxSpeedHoriz");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headMaxSpeedVert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headMaxSpeedVert");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headHorizDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headHorizDuration");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headVertDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headVertDuration");
			EyeAndHeadAnimator.NativeFieldInfoPtr_startHeadHorizDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "startHeadHorizDuration");
			EyeAndHeadAnimator.NativeFieldInfoPtr_startHeadVertDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "startHeadVertDuration");
			EyeAndHeadAnimator.NativeFieldInfoPtr_startHeadMaxSpeedHoriz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "startHeadMaxSpeedHoriz");
			EyeAndHeadAnimator.NativeFieldInfoPtr_startHeadMaxSpeedVert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "startHeadMaxSpeedVert");
			EyeAndHeadAnimator.NativeFieldInfoPtr_currentHeadHorizSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "currentHeadHorizSpeed");
			EyeAndHeadAnimator.NativeFieldInfoPtr_currentHeadVertSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "currentHeadVertSpeed");
			EyeAndHeadAnimator.NativeFieldInfoPtr_currentHeadZSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "currentHeadZSpeed");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxHeadVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kMaxHeadVelocity");
			EyeAndHeadAnimator.NativeFieldInfoPtr_kHeadOmega = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "kHeadOmega");
			EyeAndHeadAnimator.NativeFieldInfoPtr_critDampTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "critDampTween");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headEulerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headEulerSpeed");
			EyeAndHeadAnimator.NativeFieldInfoPtr_lastHeadEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "lastHeadEuler");
			EyeAndHeadAnimator.NativeFieldInfoPtr_maxHeadHorizSpeedSinceSaccadeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "maxHeadHorizSpeedSinceSaccadeStart");
			EyeAndHeadAnimator.NativeFieldInfoPtr_maxHeadVertSpeedSinceSaccadeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "maxHeadVertSpeedSinceSaccadeStart");
			EyeAndHeadAnimator.NativeFieldInfoPtr_isHeadTracking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "isHeadTracking");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headTrackingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headTrackingFactor");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headLatency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headLatency");
			EyeAndHeadAnimator.NativeFieldInfoPtr_eyeLatency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "eyeLatency");
			EyeAndHeadAnimator.NativeFieldInfoPtr_ikWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "ikWeight");
			EyeAndHeadAnimator.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "animator");
			EyeAndHeadAnimator.NativeFieldInfoPtr_hasLateUpdateRunThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "hasLateUpdateRunThisFrame");
			EyeAndHeadAnimator.NativeFieldInfoPtr_hasCheckedIdleLookTargetsThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "hasCheckedIdleLookTargetsThisFrame");
			EyeAndHeadAnimator.NativeFieldInfoPtr_placeNewIdleLookTargetsAtNextOpportunity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "placeNewIdleLookTargetsAtNextOpportunity");
			EyeAndHeadAnimator.NativeFieldInfoPtr_currentHeadTargetPOI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "currentHeadTargetPOI");
			EyeAndHeadAnimator.NativeFieldInfoPtr_currentEyeTargetPOI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "currentEyeTargetPOI");
			EyeAndHeadAnimator.NativeFieldInfoPtr_nextHeadTargetPOI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "nextHeadTargetPOI");
			EyeAndHeadAnimator.NativeFieldInfoPtr_nextEyeTargetPOI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "nextEyeTargetPOI");
			EyeAndHeadAnimator.NativeFieldInfoPtr_currentTargetLeftEyeXform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "currentTargetLeftEyeXform");
			EyeAndHeadAnimator.NativeFieldInfoPtr_currentTargetRightEyeXform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "currentTargetRightEyeXform");
			EyeAndHeadAnimator.NativeFieldInfoPtr_nextTargetLeftEyeXform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "nextTargetLeftEyeXform");
			EyeAndHeadAnimator.NativeFieldInfoPtr_nextTargetRightEyeXform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "nextTargetRightEyeXform");
			EyeAndHeadAnimator.NativeFieldInfoPtr_createdTargetXforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "createdTargetXforms");
			EyeAndHeadAnimator.NativeFieldInfoPtr_createdTargetXformIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "createdTargetXformIndex");
			EyeAndHeadAnimator.NativeFieldInfoPtr__eyesRootXform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "<eyesRootXform>k__BackingField");
			EyeAndHeadAnimator.NativeFieldInfoPtr__headParentXform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "<headParentXform>k__BackingField");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headTargetPivotXform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headTargetPivotXform");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headXform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headXform");
			EyeAndHeadAnimator.NativeFieldInfoPtr_leftEyeRootFromAnchorQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "leftEyeRootFromAnchorQ");
			EyeAndHeadAnimator.NativeFieldInfoPtr_rightEyeRootFromAnchorQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "rightEyeRootFromAnchorQ");
			EyeAndHeadAnimator.NativeFieldInfoPtr_leftAnchorFromEyeRootQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "leftAnchorFromEyeRootQ");
			EyeAndHeadAnimator.NativeFieldInfoPtr_rightAnchorFromEyeRootQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "rightAnchorFromEyeRootQ");
			EyeAndHeadAnimator.NativeFieldInfoPtr_currentLeftEyeLocalEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "currentLeftEyeLocalEuler");
			EyeAndHeadAnimator.NativeFieldInfoPtr_currentRightEyeLocalEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "currentRightEyeLocalEuler");
			EyeAndHeadAnimator.NativeFieldInfoPtr_originalLeftEyeLocalQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "originalLeftEyeLocalQ");
			EyeAndHeadAnimator.NativeFieldInfoPtr_originalRightEyeLocalQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "originalRightEyeLocalQ");
			EyeAndHeadAnimator.NativeFieldInfoPtr_lastLeftEyeLocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "lastLeftEyeLocalRotation");
			EyeAndHeadAnimator.NativeFieldInfoPtr_lastRightEyeLocalQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "lastRightEyeLocalQ");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headBoneInAvatarQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headBoneInAvatarQ");
			EyeAndHeadAnimator.NativeFieldInfoPtr_macroSaccadeTargetLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "macroSaccadeTargetLocal");
			EyeAndHeadAnimator.NativeFieldInfoPtr_microSaccadeTargetLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "microSaccadeTargetLocal");
			EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfEnteringClearingPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "timeOfEnteringClearingPhase");
			EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfLastMacroSaccade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "timeOfLastMacroSaccade");
			EyeAndHeadAnimator.NativeFieldInfoPtr_timeToMicroSaccade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "timeToMicroSaccade");
			EyeAndHeadAnimator.NativeFieldInfoPtr_timeToMacroSaccade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "timeToMacroSaccade");
			EyeAndHeadAnimator.NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "isInitialized");
			EyeAndHeadAnimator.NativeFieldInfoPtr_lastFrameOfUpdate1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "lastFrameOfUpdate1");
			EyeAndHeadAnimator.NativeFieldInfoPtr_lastFrameOfUpdate2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "lastFrameOfUpdate2");
			EyeAndHeadAnimator.NativeFieldInfoPtr_headSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "headSpeed");
			EyeAndHeadAnimator.NativeFieldInfoPtr_lookTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "lookTarget");
			EyeAndHeadAnimator.NativeFieldInfoPtr_faceLookTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "faceLookTarget");
			EyeAndHeadAnimator.NativeFieldInfoPtr_InRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, "InRange");
			EyeAndHeadAnimator.NativeMethodInfoPtr_add_OnCannotGetTargetIntoView_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675970);
			EyeAndHeadAnimator.NativeMethodInfoPtr_remove_OnCannotGetTargetIntoView_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675971);
			EyeAndHeadAnimator.NativeMethodInfoPtr_add_OnTargetDestroyed_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675972);
			EyeAndHeadAnimator.NativeMethodInfoPtr_remove_OnTargetDestroyed_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675973);
			EyeAndHeadAnimator.NativeMethodInfoPtr_get_blink01_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675974);
			EyeAndHeadAnimator.NativeMethodInfoPtr_set_blink01_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675975);
			EyeAndHeadAnimator.NativeMethodInfoPtr_get_eyeDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675976);
			EyeAndHeadAnimator.NativeMethodInfoPtr_set_eyeDistance_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675977);
			EyeAndHeadAnimator.NativeMethodInfoPtr_get_eyeDistanceScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675978);
			EyeAndHeadAnimator.NativeMethodInfoPtr_set_eyeDistanceScale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675979);
			EyeAndHeadAnimator.NativeMethodInfoPtr_get_eyesRootXform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675980);
			EyeAndHeadAnimator.NativeMethodInfoPtr_set_eyesRootXform_Private_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675981);
			EyeAndHeadAnimator.NativeMethodInfoPtr_get_headParentXform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675982);
			EyeAndHeadAnimator.NativeMethodInfoPtr_set_headParentXform_Private_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675983);
			EyeAndHeadAnimator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675984);
			EyeAndHeadAnimator.NativeMethodInfoPtr_Blink_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675985);
			EyeAndHeadAnimator.NativeMethodInfoPtr_CanGetIntoView_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675986);
			EyeAndHeadAnimator.NativeMethodInfoPtr_CanChangePointOfAttention_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675987);
			EyeAndHeadAnimator.NativeMethodInfoPtr_CanImportFromFile_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675988);
			EyeAndHeadAnimator.NativeMethodInfoPtr_CheckIdleLookTargets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675989);
			EyeAndHeadAnimator.NativeMethodInfoPtr_CheckLatencies_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675990);
			EyeAndHeadAnimator.NativeMethodInfoPtr_CheckMacroSaccades_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675991);
			EyeAndHeadAnimator.NativeMethodInfoPtr_CheckMicroSaccades_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675992);
			EyeAndHeadAnimator.NativeMethodInfoPtr_ClampLeftHorizEyeAngle_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675993);
			EyeAndHeadAnimator.NativeMethodInfoPtr_ClampRightHorizEyeAngle_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675994);
			EyeAndHeadAnimator.NativeMethodInfoPtr_ClearLookTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675995);
			EyeAndHeadAnimator.NativeMethodInfoPtr_DrawSightlinesInEditor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675996);
			EyeAndHeadAnimator.NativeMethodInfoPtr_ExportToFile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675997);
			EyeAndHeadAnimator.NativeMethodInfoPtr_GetCurrentEyeTargetPos_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675998);
			EyeAndHeadAnimator.NativeMethodInfoPtr_GetCurrentHeadTargetPos_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100675999);
			EyeAndHeadAnimator.NativeMethodInfoPtr_GetHeadDirection_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676000);
			EyeAndHeadAnimator.NativeMethodInfoPtr_GetLeftEyeDirection_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676001);
			EyeAndHeadAnimator.NativeMethodInfoPtr_GetLookTargetPosForSocialTriangle_Private_Vector3_FaceLookTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676002);
			EyeAndHeadAnimator.NativeMethodInfoPtr_GetOwnEyeCenter_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676003);
			EyeAndHeadAnimator.NativeMethodInfoPtr_GetOwnEyeCenterXform_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676004);
			EyeAndHeadAnimator.NativeMethodInfoPtr_GetOwnLookDirection_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676005);
			EyeAndHeadAnimator.NativeMethodInfoPtr_GetRightEyeDirection_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676006);
			EyeAndHeadAnimator.NativeMethodInfoPtr_GetStareAngleMeAtTarget_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676007);
			EyeAndHeadAnimator.NativeMethodInfoPtr_GetStareAngleTargetAtMe_Public_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676008);
			EyeAndHeadAnimator.NativeMethodInfoPtr_ImportFromFile_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676009);
			EyeAndHeadAnimator.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676010);
			EyeAndHeadAnimator.NativeMethodInfoPtr_IsInView_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676011);
			EyeAndHeadAnimator.NativeMethodInfoPtr_IsLookingAtFace_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676012);
			EyeAndHeadAnimator.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676013);
			EyeAndHeadAnimator.NativeMethodInfoPtr_LimitHorizontalHeadAngle_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676014);
			EyeAndHeadAnimator.NativeMethodInfoPtr_LimitVerticalHeadAngle_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676015);
			EyeAndHeadAnimator.NativeMethodInfoPtr_LookAtFace_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676016);
			EyeAndHeadAnimator.NativeMethodInfoPtr_LookAtFace_Public_Void_Transform_Transform_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676017);
			EyeAndHeadAnimator.NativeMethodInfoPtr_LookAtSpecificThing_Public_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676018);
			EyeAndHeadAnimator.NativeMethodInfoPtr_LookAtSpecificThing_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676019);
			EyeAndHeadAnimator.NativeMethodInfoPtr_LookAroundIdly_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676020);
			EyeAndHeadAnimator.NativeMethodInfoPtr_LookAtAreaAround_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676021);
			EyeAndHeadAnimator.NativeMethodInfoPtr_LookAtAreaAround_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676022);
			EyeAndHeadAnimator.NativeMethodInfoPtr_OnAnimatorIK_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676023);
			EyeAndHeadAnimator.NativeMethodInfoPtr_OnCreatedXformDestroyed_Private_Void_DestroyNotifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676024);
			EyeAndHeadAnimator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676025);
			EyeAndHeadAnimator.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676026);
			EyeAndHeadAnimator.NativeMethodInfoPtr_SetMacroSaccadeTarget_Private_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676027);
			EyeAndHeadAnimator.NativeMethodInfoPtr_SetMicroSaccadeTarget_Private_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676028);
			EyeAndHeadAnimator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676029);
			EyeAndHeadAnimator.NativeMethodInfoPtr_StartEyeMovement_Private_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676030);
			EyeAndHeadAnimator.NativeMethodInfoPtr_StartHeadMovement_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676031);
			EyeAndHeadAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676032);
			EyeAndHeadAnimator.NativeMethodInfoPtr_Update1_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676033);
			EyeAndHeadAnimator.NativeMethodInfoPtr_Update2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676034);
			EyeAndHeadAnimator.NativeMethodInfoPtr_UpdateBlinking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676035);
			EyeAndHeadAnimator.NativeMethodInfoPtr_UpdateEyelids_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676036);
			EyeAndHeadAnimator.NativeMethodInfoPtr_UpdateEyeMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676037);
			EyeAndHeadAnimator.NativeMethodInfoPtr_UpdateHeadMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676038);
			EyeAndHeadAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr, 100676039);
		}

		// Token: 0x06009F5C RID: 40796 RVA: 0x0000210C File Offset: 0x0000030C
		public EyeAndHeadAnimator(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x06009F5D RID: 40797 RVA: 0x0028753C File Offset: 0x0028573C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EyeAndHeadAnimator>.NativeClassPtr));
			}
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x06009F5E RID: 40798 RVA: 0x00287550 File Offset: 0x00285750
		// (set) Token: 0x06009F5F RID: 40799 RVA: 0x0028756E File Offset: 0x0028576E
		public unsafe static float kMaxLimitedHorizontalHeadAngle
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxLimitedHorizontalHeadAngle, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxLimitedHorizontalHeadAngle, (void*)(&value));
			}
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x06009F60 RID: 40800 RVA: 0x00287580 File Offset: 0x00285780
		// (set) Token: 0x06009F61 RID: 40801 RVA: 0x0028759E File Offset: 0x0028579E
		public unsafe static float kMaxLimitedVerticalHeadAngle
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxLimitedVerticalHeadAngle, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxLimitedVerticalHeadAngle, (void*)(&value));
			}
		}

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x06009F62 RID: 40802 RVA: 0x002875B0 File Offset: 0x002857B0
		// (set) Token: 0x06009F63 RID: 40803 RVA: 0x002875CE File Offset: 0x002857CE
		public unsafe static float kMaxHorizViewAngle
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxHorizViewAngle, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxHorizViewAngle, (void*)(&value));
			}
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x06009F64 RID: 40804 RVA: 0x002875E0 File Offset: 0x002857E0
		// (set) Token: 0x06009F65 RID: 40805 RVA: 0x002875FE File Offset: 0x002857FE
		public unsafe static float kMaxVertViewAngle
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxVertViewAngle, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxVertViewAngle, (void*)(&value));
			}
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x06009F66 RID: 40806 RVA: 0x00287610 File Offset: 0x00285810
		// (set) Token: 0x06009F67 RID: 40807 RVA: 0x00287644 File Offset: 0x00285844
		public unsafe Action OnCannotGetTargetIntoView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_OnCannotGetTargetIntoView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Action(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_OnCannotGetTargetIntoView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x06009F68 RID: 40808 RVA: 0x0028766C File Offset: 0x0028586C
		// (set) Token: 0x06009F69 RID: 40809 RVA: 0x002876A0 File Offset: 0x002858A0
		public unsafe Action OnTargetDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_OnTargetDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Action(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_OnTargetDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x06009F6A RID: 40810 RVA: 0x002876C8 File Offset: 0x002858C8
		// (set) Token: 0x06009F6B RID: 40811 RVA: 0x002876F0 File Offset: 0x002858F0
		public unsafe float headSpeedModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headSpeedModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headSpeedModifier)) = value;
			}
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x06009F6C RID: 40812 RVA: 0x00287714 File Offset: 0x00285914
		// (set) Token: 0x06009F6D RID: 40813 RVA: 0x0028773C File Offset: 0x0028593C
		public unsafe float headWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headWeight)) = value;
			}
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x06009F6E RID: 40814 RVA: 0x00287760 File Offset: 0x00285960
		// (set) Token: 0x06009F6F RID: 40815 RVA: 0x00287794 File Offset: 0x00285994
		public unsafe Transform headBoneNonMecanimXform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headBoneNonMecanimXform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headBoneNonMecanimXform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x06009F70 RID: 40816 RVA: 0x002877BC File Offset: 0x002859BC
		// (set) Token: 0x06009F71 RID: 40817 RVA: 0x002877E4 File Offset: 0x002859E4
		public unsafe Quaternion headBoneNonMecanimFromRootQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headBoneNonMecanimFromRootQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headBoneNonMecanimFromRootQ)) = value;
			}
		}

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x06009F72 RID: 40818 RVA: 0x00287808 File Offset: 0x00285A08
		// (set) Token: 0x06009F73 RID: 40819 RVA: 0x00287826 File Offset: 0x00285A26
		public unsafe static float kHeadJitterFrequency
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kHeadJitterFrequency, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kHeadJitterFrequency, (void*)(&value));
			}
		}

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x06009F74 RID: 40820 RVA: 0x00287838 File Offset: 0x00285A38
		// (set) Token: 0x06009F75 RID: 40821 RVA: 0x00287856 File Offset: 0x00285A56
		public unsafe static float kHeadJitterAmount
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kHeadJitterAmount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kHeadJitterAmount, (void*)(&value));
			}
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x06009F76 RID: 40822 RVA: 0x00287868 File Offset: 0x00285A68
		// (set) Token: 0x06009F77 RID: 40823 RVA: 0x00287890 File Offset: 0x00285A90
		public unsafe Vector3 headJitterRotationComponents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headJitterRotationComponents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headJitterRotationComponents)) = value;
			}
		}

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x06009F78 RID: 40824 RVA: 0x002878B4 File Offset: 0x00285AB4
		// (set) Token: 0x06009F79 RID: 40825 RVA: 0x002878D2 File Offset: 0x00285AD2
		public unsafe static int kHeadJitterOctave
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kHeadJitterOctave, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kHeadJitterOctave, (void*)(&value));
			}
		}

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x06009F7A RID: 40826 RVA: 0x002878E4 File Offset: 0x00285AE4
		// (set) Token: 0x06009F7B RID: 40827 RVA: 0x0028790C File Offset: 0x00285B0C
		public unsafe float headJitterTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headJitterTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headJitterTime)) = value;
			}
		}

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x06009F7C RID: 40828 RVA: 0x00287930 File Offset: 0x00285B30
		// (set) Token: 0x06009F7D RID: 40829 RVA: 0x00287964 File Offset: 0x00285B64
		public unsafe Il2CppStructArray<Vector2> headJitterNoiseVectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headJitterNoiseVectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headJitterNoiseVectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x06009F7E RID: 40830 RVA: 0x0028798C File Offset: 0x00285B8C
		// (set) Token: 0x06009F7F RID: 40831 RVA: 0x002879B4 File Offset: 0x00285BB4
		public unsafe EyeAndHeadAnimator.HeadControl headControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headControl)) = value;
			}
		}

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x06009F80 RID: 40832 RVA: 0x002879D8 File Offset: 0x00285BD8
		// (set) Token: 0x06009F81 RID: 40833 RVA: 0x00287A00 File Offset: 0x00285C00
		public unsafe EyeAndHeadAnimator.HeadTweenMethod headTweenMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headTweenMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headTweenMethod)) = value;
			}
		}

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x06009F82 RID: 40834 RVA: 0x00287A24 File Offset: 0x00285C24
		// (set) Token: 0x06009F83 RID: 40835 RVA: 0x00287A4C File Offset: 0x00285C4C
		public unsafe bool useMicroSaccades
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_useMicroSaccades);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_useMicroSaccades)) = value;
			}
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x06009F84 RID: 40836 RVA: 0x00287A70 File Offset: 0x00285C70
		// (set) Token: 0x06009F85 RID: 40837 RVA: 0x00287A98 File Offset: 0x00285C98
		public unsafe bool useMacroSaccades
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_useMacroSaccades);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_useMacroSaccades)) = value;
			}
		}

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x06009F86 RID: 40838 RVA: 0x00287ABC File Offset: 0x00285CBC
		// (set) Token: 0x06009F87 RID: 40839 RVA: 0x00287AE4 File Offset: 0x00285CE4
		public unsafe bool useHeadJitter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_useHeadJitter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_useHeadJitter)) = value;
			}
		}

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x06009F88 RID: 40840 RVA: 0x00287B08 File Offset: 0x00285D08
		// (set) Token: 0x06009F89 RID: 40841 RVA: 0x00287B30 File Offset: 0x00285D30
		public unsafe bool kDrawSightlinesInEditor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_kDrawSightlinesInEditor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_kDrawSightlinesInEditor)) = value;
			}
		}

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x06009F8A RID: 40842 RVA: 0x00287B54 File Offset: 0x00285D54
		// (set) Token: 0x06009F8B RID: 40843 RVA: 0x00287B7C File Offset: 0x00285D7C
		public unsafe bool areUpdatedControlledExternally
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_areUpdatedControlledExternally);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_areUpdatedControlledExternally)) = value;
			}
		}

		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x06009F8C RID: 40844 RVA: 0x00287BA0 File Offset: 0x00285DA0
		// (set) Token: 0x06009F8D RID: 40845 RVA: 0x00287BD4 File Offset: 0x00285DD4
		public unsafe ControlData controlData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_controlData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new ControlData(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_controlData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x06009F8E RID: 40846 RVA: 0x00287BFC File Offset: 0x00285DFC
		// (set) Token: 0x06009F8F RID: 40847 RVA: 0x00287C24 File Offset: 0x00285E24
		public unsafe float kMinNextBlinkTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_kMinNextBlinkTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_kMinNextBlinkTime)) = value;
			}
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x06009F90 RID: 40848 RVA: 0x00287C48 File Offset: 0x00285E48
		// (set) Token: 0x06009F91 RID: 40849 RVA: 0x00287C70 File Offset: 0x00285E70
		public unsafe float kMaxNextBlinkTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxNextBlinkTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxNextBlinkTime)) = value;
			}
		}

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x06009F92 RID: 40850 RVA: 0x00287C94 File Offset: 0x00285E94
		// (set) Token: 0x06009F93 RID: 40851 RVA: 0x00287CBC File Offset: 0x00285EBC
		public unsafe float blinkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_blinkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_blinkSpeed)) = value;
			}
		}

		// Token: 0x17003911 RID: 14609
		// (get) Token: 0x06009F94 RID: 40852 RVA: 0x00287CE0 File Offset: 0x00285EE0
		// (set) Token: 0x06009F95 RID: 40853 RVA: 0x00287D08 File Offset: 0x00285F08
		public unsafe bool eyelidsFollowEyesVertically
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_eyelidsFollowEyesVertically);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_eyelidsFollowEyesVertically)) = value;
			}
		}

		// Token: 0x17003912 RID: 14610
		// (get) Token: 0x06009F96 RID: 40854 RVA: 0x00287D2C File Offset: 0x00285F2C
		// (set) Token: 0x06009F97 RID: 40855 RVA: 0x00287D54 File Offset: 0x00285F54
		public unsafe float _blink01_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr__blink01_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr__blink01_k__BackingField)) = value;
			}
		}

		// Token: 0x17003913 RID: 14611
		// (get) Token: 0x06009F98 RID: 40856 RVA: 0x00287D78 File Offset: 0x00285F78
		// (set) Token: 0x06009F99 RID: 40857 RVA: 0x00287DA0 File Offset: 0x00285FA0
		public unsafe bool useUpperEyelids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_useUpperEyelids);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_useUpperEyelids)) = value;
			}
		}

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x06009F9A RID: 40858 RVA: 0x00287DC4 File Offset: 0x00285FC4
		// (set) Token: 0x06009F9B RID: 40859 RVA: 0x00287DEC File Offset: 0x00285FEC
		public unsafe bool useLowerEyelids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_useLowerEyelids);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_useLowerEyelids)) = value;
			}
		}

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x06009F9C RID: 40860 RVA: 0x00287E10 File Offset: 0x00286010
		// (set) Token: 0x06009F9D RID: 40861 RVA: 0x00287E38 File Offset: 0x00286038
		public unsafe float timeOfNextBlink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfNextBlink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfNextBlink)) = value;
			}
		}

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x06009F9E RID: 40862 RVA: 0x00287E5C File Offset: 0x0028605C
		// (set) Token: 0x06009F9F RID: 40863 RVA: 0x00287E84 File Offset: 0x00286084
		public unsafe EyeAndHeadAnimator.BlinkState blinkState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_blinkState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_blinkState)) = value;
			}
		}

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x06009FA0 RID: 40864 RVA: 0x00287EA8 File Offset: 0x002860A8
		// (set) Token: 0x06009FA1 RID: 40865 RVA: 0x00287ED0 File Offset: 0x002860D0
		public unsafe float blinkStateTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_blinkStateTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_blinkStateTime)) = value;
			}
		}

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x06009FA2 RID: 40866 RVA: 0x00287EF4 File Offset: 0x002860F4
		// (set) Token: 0x06009FA3 RID: 40867 RVA: 0x00287F1C File Offset: 0x0028611C
		public unsafe float blinkDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_blinkDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_blinkDuration)) = value;
			}
		}

		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x06009FA4 RID: 40868 RVA: 0x00287F40 File Offset: 0x00286140
		// (set) Token: 0x06009FA5 RID: 40869 RVA: 0x00287F68 File Offset: 0x00286168
		public unsafe bool isShortBlink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_isShortBlink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_isShortBlink)) = value;
			}
		}

		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x06009FA6 RID: 40870 RVA: 0x00287F8C File Offset: 0x0028618C
		// (set) Token: 0x06009FA7 RID: 40871 RVA: 0x00287FAA File Offset: 0x002861AA
		public unsafe static float kBlinkCloseTimeShort
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkCloseTimeShort, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkCloseTimeShort, (void*)(&value));
			}
		}

		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x06009FA8 RID: 40872 RVA: 0x00287FBC File Offset: 0x002861BC
		// (set) Token: 0x06009FA9 RID: 40873 RVA: 0x00287FDA File Offset: 0x002861DA
		public unsafe static float kBlinkOpenTimeShort
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkOpenTimeShort, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkOpenTimeShort, (void*)(&value));
			}
		}

		// Token: 0x1700391C RID: 14620
		// (get) Token: 0x06009FAA RID: 40874 RVA: 0x00287FEC File Offset: 0x002861EC
		// (set) Token: 0x06009FAB RID: 40875 RVA: 0x0028800A File Offset: 0x0028620A
		public unsafe static float kBlinkCloseTimeLong
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkCloseTimeLong, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkCloseTimeLong, (void*)(&value));
			}
		}

		// Token: 0x1700391D RID: 14621
		// (get) Token: 0x06009FAC RID: 40876 RVA: 0x0028801C File Offset: 0x0028621C
		// (set) Token: 0x06009FAD RID: 40877 RVA: 0x0028803A File Offset: 0x0028623A
		public unsafe static float kBlinkOpenTimeLong
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkOpenTimeLong, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkOpenTimeLong, (void*)(&value));
			}
		}

		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x06009FAE RID: 40878 RVA: 0x0028804C File Offset: 0x0028624C
		// (set) Token: 0x06009FAF RID: 40879 RVA: 0x0028806A File Offset: 0x0028626A
		public unsafe static float kBlinkKeepingClosedTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkKeepingClosedTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kBlinkKeepingClosedTime, (void*)(&value));
			}
		}

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x06009FB0 RID: 40880 RVA: 0x0028807C File Offset: 0x0028627C
		// (set) Token: 0x06009FB1 RID: 40881 RVA: 0x002880A4 File Offset: 0x002862A4
		public unsafe float maxEyeHorizAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_maxEyeHorizAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_maxEyeHorizAngle)) = value;
			}
		}

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x06009FB2 RID: 40882 RVA: 0x002880C8 File Offset: 0x002862C8
		// (set) Token: 0x06009FB3 RID: 40883 RVA: 0x002880F0 File Offset: 0x002862F0
		public unsafe float maxEyeHorizAngleTowardsNose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_maxEyeHorizAngleTowardsNose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_maxEyeHorizAngleTowardsNose)) = value;
			}
		}

		// Token: 0x17003921 RID: 14625
		// (get) Token: 0x06009FB4 RID: 40884 RVA: 0x00288114 File Offset: 0x00286314
		// (set) Token: 0x06009FB5 RID: 40885 RVA: 0x0028813C File Offset: 0x0028633C
		public unsafe float crossEyeCorrection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_crossEyeCorrection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_crossEyeCorrection)) = value;
			}
		}

		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x06009FB6 RID: 40886 RVA: 0x00288160 File Offset: 0x00286360
		// (set) Token: 0x06009FB7 RID: 40887 RVA: 0x00288188 File Offset: 0x00286388
		public unsafe float nervousness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_nervousness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_nervousness)) = value;
			}
		}

		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x06009FB8 RID: 40888 RVA: 0x002881AC File Offset: 0x002863AC
		// (set) Token: 0x06009FB9 RID: 40889 RVA: 0x002881D4 File Offset: 0x002863D4
		public unsafe float limitHeadAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_limitHeadAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_limitHeadAngle)) = value;
			}
		}

		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x06009FBA RID: 40890 RVA: 0x002881F8 File Offset: 0x002863F8
		// (set) Token: 0x06009FBB RID: 40891 RVA: 0x00288220 File Offset: 0x00286420
		public unsafe float _eyeDistance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr__eyeDistance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr__eyeDistance_k__BackingField)) = value;
			}
		}

		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x06009FBC RID: 40892 RVA: 0x00288244 File Offset: 0x00286444
		// (set) Token: 0x06009FBD RID: 40893 RVA: 0x0028826C File Offset: 0x0028646C
		public unsafe float _eyeDistanceScale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr__eyeDistanceScale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr__eyeDistanceScale_k__BackingField)) = value;
			}
		}

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x06009FBE RID: 40894 RVA: 0x00288290 File Offset: 0x00286490
		// (set) Token: 0x06009FBF RID: 40895 RVA: 0x002882C4 File Offset: 0x002864C4
		public unsafe Transform leftEyeAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftEyeAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftEyeAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x06009FC0 RID: 40896 RVA: 0x002882EC File Offset: 0x002864EC
		// (set) Token: 0x06009FC1 RID: 40897 RVA: 0x00288320 File Offset: 0x00286520
		public unsafe Transform rightEyeAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightEyeAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightEyeAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x06009FC2 RID: 40898 RVA: 0x00288348 File Offset: 0x00286548
		// (set) Token: 0x06009FC3 RID: 40899 RVA: 0x00288370 File Offset: 0x00286570
		public unsafe float leftMaxSpeedHoriz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftMaxSpeedHoriz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftMaxSpeedHoriz)) = value;
			}
		}

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x06009FC4 RID: 40900 RVA: 0x00288394 File Offset: 0x00286594
		// (set) Token: 0x06009FC5 RID: 40901 RVA: 0x002883BC File Offset: 0x002865BC
		public unsafe float leftHorizDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftHorizDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftHorizDuration)) = value;
			}
		}

		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x06009FC6 RID: 40902 RVA: 0x002883E0 File Offset: 0x002865E0
		// (set) Token: 0x06009FC7 RID: 40903 RVA: 0x00288408 File Offset: 0x00286608
		public unsafe float leftMaxSpeedVert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftMaxSpeedVert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftMaxSpeedVert)) = value;
			}
		}

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x06009FC8 RID: 40904 RVA: 0x0028842C File Offset: 0x0028662C
		// (set) Token: 0x06009FC9 RID: 40905 RVA: 0x00288454 File Offset: 0x00286654
		public unsafe float leftVertDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftVertDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftVertDuration)) = value;
			}
		}

		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x06009FCA RID: 40906 RVA: 0x00288478 File Offset: 0x00286678
		// (set) Token: 0x06009FCB RID: 40907 RVA: 0x002884A0 File Offset: 0x002866A0
		public unsafe float leftCurrentSpeedX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftCurrentSpeedX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftCurrentSpeedX)) = value;
			}
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x06009FCC RID: 40908 RVA: 0x002884C4 File Offset: 0x002866C4
		// (set) Token: 0x06009FCD RID: 40909 RVA: 0x002884EC File Offset: 0x002866EC
		public unsafe float leftCurrentSpeedY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftCurrentSpeedY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftCurrentSpeedY)) = value;
			}
		}

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x06009FCE RID: 40910 RVA: 0x00288510 File Offset: 0x00286710
		// (set) Token: 0x06009FCF RID: 40911 RVA: 0x00288538 File Offset: 0x00286738
		public unsafe float rightMaxSpeedHoriz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightMaxSpeedHoriz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightMaxSpeedHoriz)) = value;
			}
		}

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x06009FD0 RID: 40912 RVA: 0x0028855C File Offset: 0x0028675C
		// (set) Token: 0x06009FD1 RID: 40913 RVA: 0x00288584 File Offset: 0x00286784
		public unsafe float rightHorizDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightHorizDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightHorizDuration)) = value;
			}
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x06009FD2 RID: 40914 RVA: 0x002885A8 File Offset: 0x002867A8
		// (set) Token: 0x06009FD3 RID: 40915 RVA: 0x002885D0 File Offset: 0x002867D0
		public unsafe float rightMaxSpeedVert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightMaxSpeedVert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightMaxSpeedVert)) = value;
			}
		}

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x06009FD4 RID: 40916 RVA: 0x002885F4 File Offset: 0x002867F4
		// (set) Token: 0x06009FD5 RID: 40917 RVA: 0x0028861C File Offset: 0x0028681C
		public unsafe float rightVertDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightVertDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightVertDuration)) = value;
			}
		}

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x06009FD6 RID: 40918 RVA: 0x00288640 File Offset: 0x00286840
		// (set) Token: 0x06009FD7 RID: 40919 RVA: 0x00288668 File Offset: 0x00286868
		public unsafe float rightCurrentSpeedX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightCurrentSpeedX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightCurrentSpeedX)) = value;
			}
		}

		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x06009FD8 RID: 40920 RVA: 0x0028868C File Offset: 0x0028688C
		// (set) Token: 0x06009FD9 RID: 40921 RVA: 0x002886B4 File Offset: 0x002868B4
		public unsafe float rightCurrentSpeedY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightCurrentSpeedY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightCurrentSpeedY)) = value;
			}
		}

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x06009FDA RID: 40922 RVA: 0x002886D8 File Offset: 0x002868D8
		// (set) Token: 0x06009FDB RID: 40923 RVA: 0x00288700 File Offset: 0x00286900
		public unsafe float startLeftEyeHorizDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startLeftEyeHorizDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startLeftEyeHorizDuration)) = value;
			}
		}

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x06009FDC RID: 40924 RVA: 0x00288724 File Offset: 0x00286924
		// (set) Token: 0x06009FDD RID: 40925 RVA: 0x0028874C File Offset: 0x0028694C
		public unsafe float startLeftEyeVertDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startLeftEyeVertDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startLeftEyeVertDuration)) = value;
			}
		}

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x06009FDE RID: 40926 RVA: 0x00288770 File Offset: 0x00286970
		// (set) Token: 0x06009FDF RID: 40927 RVA: 0x00288798 File Offset: 0x00286998
		public unsafe float startLeftEyeMaxSpeedHoriz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startLeftEyeMaxSpeedHoriz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startLeftEyeMaxSpeedHoriz)) = value;
			}
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x06009FE0 RID: 40928 RVA: 0x002887BC File Offset: 0x002869BC
		// (set) Token: 0x06009FE1 RID: 40929 RVA: 0x002887E4 File Offset: 0x002869E4
		public unsafe float startLeftEyeMaxSpeedVert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startLeftEyeMaxSpeedVert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startLeftEyeMaxSpeedVert)) = value;
			}
		}

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x06009FE2 RID: 40930 RVA: 0x00288808 File Offset: 0x00286A08
		// (set) Token: 0x06009FE3 RID: 40931 RVA: 0x00288830 File Offset: 0x00286A30
		public unsafe float startRightEyeHorizDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startRightEyeHorizDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startRightEyeHorizDuration)) = value;
			}
		}

		// Token: 0x17003939 RID: 14649
		// (get) Token: 0x06009FE4 RID: 40932 RVA: 0x00288854 File Offset: 0x00286A54
		// (set) Token: 0x06009FE5 RID: 40933 RVA: 0x0028887C File Offset: 0x00286A7C
		public unsafe float startRightEyeVertDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startRightEyeVertDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startRightEyeVertDuration)) = value;
			}
		}

		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x06009FE6 RID: 40934 RVA: 0x002888A0 File Offset: 0x00286AA0
		// (set) Token: 0x06009FE7 RID: 40935 RVA: 0x002888C8 File Offset: 0x00286AC8
		public unsafe float startRightEyeMaxSpeedHoriz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startRightEyeMaxSpeedHoriz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startRightEyeMaxSpeedHoriz)) = value;
			}
		}

		// Token: 0x1700393B RID: 14651
		// (get) Token: 0x06009FE8 RID: 40936 RVA: 0x002888EC File Offset: 0x00286AEC
		// (set) Token: 0x06009FE9 RID: 40937 RVA: 0x00288914 File Offset: 0x00286B14
		public unsafe float startRightEyeMaxSpeedVert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startRightEyeMaxSpeedVert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startRightEyeMaxSpeedVert)) = value;
			}
		}

		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x06009FEA RID: 40938 RVA: 0x00288938 File Offset: 0x00286B38
		// (set) Token: 0x06009FEB RID: 40939 RVA: 0x00288960 File Offset: 0x00286B60
		public unsafe float timeOfEyeMovementStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfEyeMovementStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfEyeMovementStart)) = value;
			}
		}

		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x06009FEC RID: 40940 RVA: 0x00288984 File Offset: 0x00286B84
		// (set) Token: 0x06009FED RID: 40941 RVA: 0x002889AC File Offset: 0x00286BAC
		public unsafe float timeOfHeadMovementStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfHeadMovementStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfHeadMovementStart)) = value;
			}
		}

		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x06009FEE RID: 40942 RVA: 0x002889D0 File Offset: 0x00286BD0
		// (set) Token: 0x06009FEF RID: 40943 RVA: 0x002889F8 File Offset: 0x00286BF8
		public unsafe float headMaxSpeedHoriz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headMaxSpeedHoriz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headMaxSpeedHoriz)) = value;
			}
		}

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x06009FF0 RID: 40944 RVA: 0x00288A1C File Offset: 0x00286C1C
		// (set) Token: 0x06009FF1 RID: 40945 RVA: 0x00288A44 File Offset: 0x00286C44
		public unsafe float headMaxSpeedVert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headMaxSpeedVert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headMaxSpeedVert)) = value;
			}
		}

		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x06009FF2 RID: 40946 RVA: 0x00288A68 File Offset: 0x00286C68
		// (set) Token: 0x06009FF3 RID: 40947 RVA: 0x00288A90 File Offset: 0x00286C90
		public unsafe float headHorizDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headHorizDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headHorizDuration)) = value;
			}
		}

		// Token: 0x17003941 RID: 14657
		// (get) Token: 0x06009FF4 RID: 40948 RVA: 0x00288AB4 File Offset: 0x00286CB4
		// (set) Token: 0x06009FF5 RID: 40949 RVA: 0x00288ADC File Offset: 0x00286CDC
		public unsafe float headVertDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headVertDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headVertDuration)) = value;
			}
		}

		// Token: 0x17003942 RID: 14658
		// (get) Token: 0x06009FF6 RID: 40950 RVA: 0x00288B00 File Offset: 0x00286D00
		// (set) Token: 0x06009FF7 RID: 40951 RVA: 0x00288B28 File Offset: 0x00286D28
		public unsafe float startHeadHorizDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startHeadHorizDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startHeadHorizDuration)) = value;
			}
		}

		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x06009FF8 RID: 40952 RVA: 0x00288B4C File Offset: 0x00286D4C
		// (set) Token: 0x06009FF9 RID: 40953 RVA: 0x00288B74 File Offset: 0x00286D74
		public unsafe float startHeadVertDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startHeadVertDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startHeadVertDuration)) = value;
			}
		}

		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x06009FFA RID: 40954 RVA: 0x00288B98 File Offset: 0x00286D98
		// (set) Token: 0x06009FFB RID: 40955 RVA: 0x00288BC0 File Offset: 0x00286DC0
		public unsafe float startHeadMaxSpeedHoriz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startHeadMaxSpeedHoriz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startHeadMaxSpeedHoriz)) = value;
			}
		}

		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x06009FFC RID: 40956 RVA: 0x00288BE4 File Offset: 0x00286DE4
		// (set) Token: 0x06009FFD RID: 40957 RVA: 0x00288C0C File Offset: 0x00286E0C
		public unsafe float startHeadMaxSpeedVert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startHeadMaxSpeedVert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_startHeadMaxSpeedVert)) = value;
			}
		}

		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x06009FFE RID: 40958 RVA: 0x00288C30 File Offset: 0x00286E30
		// (set) Token: 0x06009FFF RID: 40959 RVA: 0x00288C58 File Offset: 0x00286E58
		public unsafe float currentHeadHorizSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentHeadHorizSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentHeadHorizSpeed)) = value;
			}
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x0600A000 RID: 40960 RVA: 0x00288C7C File Offset: 0x00286E7C
		// (set) Token: 0x0600A001 RID: 40961 RVA: 0x00288CA4 File Offset: 0x00286EA4
		public unsafe float currentHeadVertSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentHeadVertSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentHeadVertSpeed)) = value;
			}
		}

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x0600A002 RID: 40962 RVA: 0x00288CC8 File Offset: 0x00286EC8
		// (set) Token: 0x0600A003 RID: 40963 RVA: 0x00288CF0 File Offset: 0x00286EF0
		public unsafe float currentHeadZSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentHeadZSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentHeadZSpeed)) = value;
			}
		}

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x0600A004 RID: 40964 RVA: 0x00288D14 File Offset: 0x00286F14
		// (set) Token: 0x0600A005 RID: 40965 RVA: 0x00288D32 File Offset: 0x00286F32
		public unsafe static float kMaxHeadVelocity
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxHeadVelocity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kMaxHeadVelocity, (void*)(&value));
			}
		}

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x0600A006 RID: 40966 RVA: 0x00288D44 File Offset: 0x00286F44
		// (set) Token: 0x0600A007 RID: 40967 RVA: 0x00288D62 File Offset: 0x00286F62
		public unsafe static float kHeadOmega
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kHeadOmega, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeAndHeadAnimator.NativeFieldInfoPtr_kHeadOmega, (void*)(&value));
			}
		}

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x0600A008 RID: 40968 RVA: 0x00288D74 File Offset: 0x00286F74
		// (set) Token: 0x0600A009 RID: 40969 RVA: 0x00288D9C File Offset: 0x00286F9C
		public unsafe CritDampTweenQuaternion critDampTween
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_critDampTween);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_critDampTween)) = value;
			}
		}

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x0600A00A RID: 40970 RVA: 0x00288DC0 File Offset: 0x00286FC0
		// (set) Token: 0x0600A00B RID: 40971 RVA: 0x00288DE8 File Offset: 0x00286FE8
		public unsafe Vector3 headEulerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headEulerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headEulerSpeed)) = value;
			}
		}

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x0600A00C RID: 40972 RVA: 0x00288E0C File Offset: 0x0028700C
		// (set) Token: 0x0600A00D RID: 40973 RVA: 0x00288E34 File Offset: 0x00287034
		public unsafe Vector3 lastHeadEuler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_lastHeadEuler);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_lastHeadEuler)) = value;
			}
		}

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x0600A00E RID: 40974 RVA: 0x00288E58 File Offset: 0x00287058
		// (set) Token: 0x0600A00F RID: 40975 RVA: 0x00288E80 File Offset: 0x00287080
		public unsafe float maxHeadHorizSpeedSinceSaccadeStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_maxHeadHorizSpeedSinceSaccadeStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_maxHeadHorizSpeedSinceSaccadeStart)) = value;
			}
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x0600A010 RID: 40976 RVA: 0x00288EA4 File Offset: 0x002870A4
		// (set) Token: 0x0600A011 RID: 40977 RVA: 0x00288ECC File Offset: 0x002870CC
		public unsafe float maxHeadVertSpeedSinceSaccadeStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_maxHeadVertSpeedSinceSaccadeStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_maxHeadVertSpeedSinceSaccadeStart)) = value;
			}
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x0600A012 RID: 40978 RVA: 0x00288EF0 File Offset: 0x002870F0
		// (set) Token: 0x0600A013 RID: 40979 RVA: 0x00288F18 File Offset: 0x00287118
		public unsafe bool isHeadTracking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_isHeadTracking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_isHeadTracking)) = value;
			}
		}

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x0600A014 RID: 40980 RVA: 0x00288F3C File Offset: 0x0028713C
		// (set) Token: 0x0600A015 RID: 40981 RVA: 0x00288F64 File Offset: 0x00287164
		public unsafe float headTrackingFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headTrackingFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headTrackingFactor)) = value;
			}
		}

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x0600A016 RID: 40982 RVA: 0x00288F88 File Offset: 0x00287188
		// (set) Token: 0x0600A017 RID: 40983 RVA: 0x00288FB0 File Offset: 0x002871B0
		public unsafe float headLatency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headLatency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headLatency)) = value;
			}
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x0600A018 RID: 40984 RVA: 0x00288FD4 File Offset: 0x002871D4
		// (set) Token: 0x0600A019 RID: 40985 RVA: 0x00288FFC File Offset: 0x002871FC
		public unsafe float eyeLatency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_eyeLatency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_eyeLatency)) = value;
			}
		}

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0600A01A RID: 40986 RVA: 0x00289020 File Offset: 0x00287220
		// (set) Token: 0x0600A01B RID: 40987 RVA: 0x00289048 File Offset: 0x00287248
		public unsafe float ikWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_ikWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_ikWeight)) = value;
			}
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0600A01C RID: 40988 RVA: 0x0028906C File Offset: 0x0028726C
		// (set) Token: 0x0600A01D RID: 40989 RVA: 0x002890A0 File Offset: 0x002872A0
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Animator(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0600A01E RID: 40990 RVA: 0x002890C8 File Offset: 0x002872C8
		// (set) Token: 0x0600A01F RID: 40991 RVA: 0x002890F0 File Offset: 0x002872F0
		public unsafe bool hasLateUpdateRunThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_hasLateUpdateRunThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_hasLateUpdateRunThisFrame)) = value;
			}
		}

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x0600A020 RID: 40992 RVA: 0x00289114 File Offset: 0x00287314
		// (set) Token: 0x0600A021 RID: 40993 RVA: 0x0028913C File Offset: 0x0028733C
		public unsafe bool hasCheckedIdleLookTargetsThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_hasCheckedIdleLookTargetsThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_hasCheckedIdleLookTargetsThisFrame)) = value;
			}
		}

		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x0600A022 RID: 40994 RVA: 0x00289160 File Offset: 0x00287360
		// (set) Token: 0x0600A023 RID: 40995 RVA: 0x00289188 File Offset: 0x00287388
		public unsafe bool placeNewIdleLookTargetsAtNextOpportunity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_placeNewIdleLookTargetsAtNextOpportunity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_placeNewIdleLookTargetsAtNextOpportunity)) = value;
			}
		}

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x0600A024 RID: 40996 RVA: 0x002891AC File Offset: 0x002873AC
		// (set) Token: 0x0600A025 RID: 40997 RVA: 0x002891E0 File Offset: 0x002873E0
		public unsafe Transform currentHeadTargetPOI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentHeadTargetPOI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentHeadTargetPOI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x0600A026 RID: 40998 RVA: 0x00289208 File Offset: 0x00287408
		// (set) Token: 0x0600A027 RID: 40999 RVA: 0x0028923C File Offset: 0x0028743C
		public unsafe Transform currentEyeTargetPOI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentEyeTargetPOI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentEyeTargetPOI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x0600A028 RID: 41000 RVA: 0x00289264 File Offset: 0x00287464
		// (set) Token: 0x0600A029 RID: 41001 RVA: 0x00289298 File Offset: 0x00287498
		public unsafe Transform nextHeadTargetPOI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_nextHeadTargetPOI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_nextHeadTargetPOI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x0600A02A RID: 41002 RVA: 0x002892C0 File Offset: 0x002874C0
		// (set) Token: 0x0600A02B RID: 41003 RVA: 0x002892F4 File Offset: 0x002874F4
		public unsafe Transform nextEyeTargetPOI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_nextEyeTargetPOI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_nextEyeTargetPOI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x0600A02C RID: 41004 RVA: 0x0028931C File Offset: 0x0028751C
		// (set) Token: 0x0600A02D RID: 41005 RVA: 0x00289350 File Offset: 0x00287550
		public unsafe Transform currentTargetLeftEyeXform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentTargetLeftEyeXform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentTargetLeftEyeXform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x0600A02E RID: 41006 RVA: 0x00289378 File Offset: 0x00287578
		// (set) Token: 0x0600A02F RID: 41007 RVA: 0x002893AC File Offset: 0x002875AC
		public unsafe Transform currentTargetRightEyeXform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentTargetRightEyeXform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentTargetRightEyeXform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x0600A030 RID: 41008 RVA: 0x002893D4 File Offset: 0x002875D4
		// (set) Token: 0x0600A031 RID: 41009 RVA: 0x00289408 File Offset: 0x00287608
		public unsafe Transform nextTargetLeftEyeXform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_nextTargetLeftEyeXform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_nextTargetLeftEyeXform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x0600A032 RID: 41010 RVA: 0x00289430 File Offset: 0x00287630
		// (set) Token: 0x0600A033 RID: 41011 RVA: 0x00289464 File Offset: 0x00287664
		public unsafe Transform nextTargetRightEyeXform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_nextTargetRightEyeXform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_nextTargetRightEyeXform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x0600A034 RID: 41012 RVA: 0x0028948C File Offset: 0x0028768C
		// (set) Token: 0x0600A035 RID: 41013 RVA: 0x002894C0 File Offset: 0x002876C0
		public unsafe Il2CppReferenceArray<Transform> createdTargetXforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_createdTargetXforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_createdTargetXforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x0600A036 RID: 41014 RVA: 0x002894E8 File Offset: 0x002876E8
		// (set) Token: 0x0600A037 RID: 41015 RVA: 0x00289510 File Offset: 0x00287710
		public unsafe int createdTargetXformIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_createdTargetXformIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_createdTargetXformIndex)) = value;
			}
		}

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x0600A038 RID: 41016 RVA: 0x00289534 File Offset: 0x00287734
		// (set) Token: 0x0600A039 RID: 41017 RVA: 0x00289568 File Offset: 0x00287768
		public unsafe Transform _eyesRootXform_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr__eyesRootXform_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr__eyesRootXform_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x0600A03A RID: 41018 RVA: 0x00289590 File Offset: 0x00287790
		// (set) Token: 0x0600A03B RID: 41019 RVA: 0x002895C4 File Offset: 0x002877C4
		public unsafe Transform _headParentXform_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr__headParentXform_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr__headParentXform_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x0600A03C RID: 41020 RVA: 0x002895EC File Offset: 0x002877EC
		// (set) Token: 0x0600A03D RID: 41021 RVA: 0x00289620 File Offset: 0x00287820
		public unsafe Transform headTargetPivotXform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headTargetPivotXform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headTargetPivotXform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x0600A03E RID: 41022 RVA: 0x00289648 File Offset: 0x00287848
		// (set) Token: 0x0600A03F RID: 41023 RVA: 0x0028967C File Offset: 0x0028787C
		public unsafe Transform headXform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headXform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headXform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x0600A040 RID: 41024 RVA: 0x002896A4 File Offset: 0x002878A4
		// (set) Token: 0x0600A041 RID: 41025 RVA: 0x002896CC File Offset: 0x002878CC
		public unsafe Quaternion leftEyeRootFromAnchorQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftEyeRootFromAnchorQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftEyeRootFromAnchorQ)) = value;
			}
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x0600A042 RID: 41026 RVA: 0x002896F0 File Offset: 0x002878F0
		// (set) Token: 0x0600A043 RID: 41027 RVA: 0x00289718 File Offset: 0x00287918
		public unsafe Quaternion rightEyeRootFromAnchorQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightEyeRootFromAnchorQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightEyeRootFromAnchorQ)) = value;
			}
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x0600A044 RID: 41028 RVA: 0x0028973C File Offset: 0x0028793C
		// (set) Token: 0x0600A045 RID: 41029 RVA: 0x00289764 File Offset: 0x00287964
		public unsafe Quaternion leftAnchorFromEyeRootQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftAnchorFromEyeRootQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_leftAnchorFromEyeRootQ)) = value;
			}
		}

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x0600A046 RID: 41030 RVA: 0x00289788 File Offset: 0x00287988
		// (set) Token: 0x0600A047 RID: 41031 RVA: 0x002897B0 File Offset: 0x002879B0
		public unsafe Quaternion rightAnchorFromEyeRootQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightAnchorFromEyeRootQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_rightAnchorFromEyeRootQ)) = value;
			}
		}

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x0600A048 RID: 41032 RVA: 0x002897D4 File Offset: 0x002879D4
		// (set) Token: 0x0600A049 RID: 41033 RVA: 0x002897FC File Offset: 0x002879FC
		public unsafe Vector3 currentLeftEyeLocalEuler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentLeftEyeLocalEuler);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentLeftEyeLocalEuler)) = value;
			}
		}

		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x0600A04A RID: 41034 RVA: 0x00289820 File Offset: 0x00287A20
		// (set) Token: 0x0600A04B RID: 41035 RVA: 0x00289848 File Offset: 0x00287A48
		public unsafe Vector3 currentRightEyeLocalEuler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentRightEyeLocalEuler);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_currentRightEyeLocalEuler)) = value;
			}
		}

		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x0600A04C RID: 41036 RVA: 0x0028986C File Offset: 0x00287A6C
		// (set) Token: 0x0600A04D RID: 41037 RVA: 0x00289894 File Offset: 0x00287A94
		public unsafe Quaternion originalLeftEyeLocalQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_originalLeftEyeLocalQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_originalLeftEyeLocalQ)) = value;
			}
		}

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x0600A04E RID: 41038 RVA: 0x002898B8 File Offset: 0x00287AB8
		// (set) Token: 0x0600A04F RID: 41039 RVA: 0x002898E0 File Offset: 0x00287AE0
		public unsafe Quaternion originalRightEyeLocalQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_originalRightEyeLocalQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_originalRightEyeLocalQ)) = value;
			}
		}

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x0600A050 RID: 41040 RVA: 0x00289904 File Offset: 0x00287B04
		// (set) Token: 0x0600A051 RID: 41041 RVA: 0x0028992C File Offset: 0x00287B2C
		public unsafe Quaternion lastLeftEyeLocalRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_lastLeftEyeLocalRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_lastLeftEyeLocalRotation)) = value;
			}
		}

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x0600A052 RID: 41042 RVA: 0x00289950 File Offset: 0x00287B50
		// (set) Token: 0x0600A053 RID: 41043 RVA: 0x00289978 File Offset: 0x00287B78
		public unsafe Quaternion lastRightEyeLocalQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_lastRightEyeLocalQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_lastRightEyeLocalQ)) = value;
			}
		}

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x0600A054 RID: 41044 RVA: 0x0028999C File Offset: 0x00287B9C
		// (set) Token: 0x0600A055 RID: 41045 RVA: 0x002899C4 File Offset: 0x00287BC4
		public unsafe Quaternion headBoneInAvatarQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headBoneInAvatarQ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headBoneInAvatarQ)) = value;
			}
		}

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x0600A056 RID: 41046 RVA: 0x002899E8 File Offset: 0x00287BE8
		// (set) Token: 0x0600A057 RID: 41047 RVA: 0x00289A10 File Offset: 0x00287C10
		public unsafe Vector3 macroSaccadeTargetLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_macroSaccadeTargetLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_macroSaccadeTargetLocal)) = value;
			}
		}

		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x0600A058 RID: 41048 RVA: 0x00289A34 File Offset: 0x00287C34
		// (set) Token: 0x0600A059 RID: 41049 RVA: 0x00289A5C File Offset: 0x00287C5C
		public unsafe Vector3 microSaccadeTargetLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_microSaccadeTargetLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_microSaccadeTargetLocal)) = value;
			}
		}

		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x0600A05A RID: 41050 RVA: 0x00289A80 File Offset: 0x00287C80
		// (set) Token: 0x0600A05B RID: 41051 RVA: 0x00289AA8 File Offset: 0x00287CA8
		public unsafe float timeOfEnteringClearingPhase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfEnteringClearingPhase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfEnteringClearingPhase)) = value;
			}
		}

		// Token: 0x17003975 RID: 14709
		// (get) Token: 0x0600A05C RID: 41052 RVA: 0x00289ACC File Offset: 0x00287CCC
		// (set) Token: 0x0600A05D RID: 41053 RVA: 0x00289AF4 File Offset: 0x00287CF4
		public unsafe float timeOfLastMacroSaccade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfLastMacroSaccade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeOfLastMacroSaccade)) = value;
			}
		}

		// Token: 0x17003976 RID: 14710
		// (get) Token: 0x0600A05E RID: 41054 RVA: 0x00289B18 File Offset: 0x00287D18
		// (set) Token: 0x0600A05F RID: 41055 RVA: 0x00289B40 File Offset: 0x00287D40
		public unsafe float timeToMicroSaccade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeToMicroSaccade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeToMicroSaccade)) = value;
			}
		}

		// Token: 0x17003977 RID: 14711
		// (get) Token: 0x0600A060 RID: 41056 RVA: 0x00289B64 File Offset: 0x00287D64
		// (set) Token: 0x0600A061 RID: 41057 RVA: 0x00289B8C File Offset: 0x00287D8C
		public unsafe float timeToMacroSaccade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeToMacroSaccade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_timeToMacroSaccade)) = value;
			}
		}

		// Token: 0x17003978 RID: 14712
		// (get) Token: 0x0600A062 RID: 41058 RVA: 0x00289BB0 File Offset: 0x00287DB0
		// (set) Token: 0x0600A063 RID: 41059 RVA: 0x00289BD8 File Offset: 0x00287DD8
		public unsafe bool isInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_isInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_isInitialized)) = value;
			}
		}

		// Token: 0x17003979 RID: 14713
		// (get) Token: 0x0600A064 RID: 41060 RVA: 0x00289BFC File Offset: 0x00287DFC
		// (set) Token: 0x0600A065 RID: 41061 RVA: 0x00289C24 File Offset: 0x00287E24
		public unsafe int lastFrameOfUpdate1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_lastFrameOfUpdate1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_lastFrameOfUpdate1)) = value;
			}
		}

		// Token: 0x1700397A RID: 14714
		// (get) Token: 0x0600A066 RID: 41062 RVA: 0x00289C48 File Offset: 0x00287E48
		// (set) Token: 0x0600A067 RID: 41063 RVA: 0x00289C70 File Offset: 0x00287E70
		public unsafe int lastFrameOfUpdate2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_lastFrameOfUpdate2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_lastFrameOfUpdate2)) = value;
			}
		}

		// Token: 0x1700397B RID: 14715
		// (get) Token: 0x0600A068 RID: 41064 RVA: 0x00289C94 File Offset: 0x00287E94
		// (set) Token: 0x0600A069 RID: 41065 RVA: 0x00289CBC File Offset: 0x00287EBC
		public unsafe EyeAndHeadAnimator.HeadSpeed headSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_headSpeed)) = value;
			}
		}

		// Token: 0x1700397C RID: 14716
		// (get) Token: 0x0600A06A RID: 41066 RVA: 0x00289CE0 File Offset: 0x00287EE0
		// (set) Token: 0x0600A06B RID: 41067 RVA: 0x00289D08 File Offset: 0x00287F08
		public unsafe EyeAndHeadAnimator.LookTarget lookTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_lookTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_lookTarget)) = value;
			}
		}

		// Token: 0x1700397D RID: 14717
		// (get) Token: 0x0600A06C RID: 41068 RVA: 0x00289D2C File Offset: 0x00287F2C
		// (set) Token: 0x0600A06D RID: 41069 RVA: 0x00289D54 File Offset: 0x00287F54
		public unsafe EyeAndHeadAnimator.FaceLookTarget faceLookTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_faceLookTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_faceLookTarget)) = value;
			}
		}

		// Token: 0x1700397E RID: 14718
		// (get) Token: 0x0600A06E RID: 41070 RVA: 0x00289D78 File Offset: 0x00287F78
		// (set) Token: 0x0600A06F RID: 41071 RVA: 0x00289DA0 File Offset: 0x00287FA0
		public unsafe bool InRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_InRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimator.NativeFieldInfoPtr_InRange)) = value;
			}
		}

		// Token: 0x04006506 RID: 25862
		private static readonly IntPtr NativeFieldInfoPtr_kMaxLimitedHorizontalHeadAngle;

		// Token: 0x04006507 RID: 25863
		private static readonly IntPtr NativeFieldInfoPtr_kMaxLimitedVerticalHeadAngle;

		// Token: 0x04006508 RID: 25864
		private static readonly IntPtr NativeFieldInfoPtr_kMaxHorizViewAngle;

		// Token: 0x04006509 RID: 25865
		private static readonly IntPtr NativeFieldInfoPtr_kMaxVertViewAngle;

		// Token: 0x0400650A RID: 25866
		private static readonly IntPtr NativeFieldInfoPtr_OnCannotGetTargetIntoView;

		// Token: 0x0400650B RID: 25867
		private static readonly IntPtr NativeFieldInfoPtr_OnTargetDestroyed;

		// Token: 0x0400650C RID: 25868
		private static readonly IntPtr NativeFieldInfoPtr_headSpeedModifier;

		// Token: 0x0400650D RID: 25869
		private static readonly IntPtr NativeFieldInfoPtr_headWeight;

		// Token: 0x0400650E RID: 25870
		private static readonly IntPtr NativeFieldInfoPtr_headBoneNonMecanimXform;

		// Token: 0x0400650F RID: 25871
		private static readonly IntPtr NativeFieldInfoPtr_headBoneNonMecanimFromRootQ;

		// Token: 0x04006510 RID: 25872
		private static readonly IntPtr NativeFieldInfoPtr_kHeadJitterFrequency;

		// Token: 0x04006511 RID: 25873
		private static readonly IntPtr NativeFieldInfoPtr_kHeadJitterAmount;

		// Token: 0x04006512 RID: 25874
		private static readonly IntPtr NativeFieldInfoPtr_headJitterRotationComponents;

		// Token: 0x04006513 RID: 25875
		private static readonly IntPtr NativeFieldInfoPtr_kHeadJitterOctave;

		// Token: 0x04006514 RID: 25876
		private static readonly IntPtr NativeFieldInfoPtr_headJitterTime;

		// Token: 0x04006515 RID: 25877
		private static readonly IntPtr NativeFieldInfoPtr_headJitterNoiseVectors;

		// Token: 0x04006516 RID: 25878
		private static readonly IntPtr NativeFieldInfoPtr_headControl;

		// Token: 0x04006517 RID: 25879
		private static readonly IntPtr NativeFieldInfoPtr_headTweenMethod;

		// Token: 0x04006518 RID: 25880
		private static readonly IntPtr NativeFieldInfoPtr_useMicroSaccades;

		// Token: 0x04006519 RID: 25881
		private static readonly IntPtr NativeFieldInfoPtr_useMacroSaccades;

		// Token: 0x0400651A RID: 25882
		private static readonly IntPtr NativeFieldInfoPtr_useHeadJitter;

		// Token: 0x0400651B RID: 25883
		private static readonly IntPtr NativeFieldInfoPtr_kDrawSightlinesInEditor;

		// Token: 0x0400651C RID: 25884
		private static readonly IntPtr NativeFieldInfoPtr_areUpdatedControlledExternally;

		// Token: 0x0400651D RID: 25885
		private static readonly IntPtr NativeFieldInfoPtr_controlData;

		// Token: 0x0400651E RID: 25886
		private static readonly IntPtr NativeFieldInfoPtr_kMinNextBlinkTime;

		// Token: 0x0400651F RID: 25887
		private static readonly IntPtr NativeFieldInfoPtr_kMaxNextBlinkTime;

		// Token: 0x04006520 RID: 25888
		private static readonly IntPtr NativeFieldInfoPtr_blinkSpeed;

		// Token: 0x04006521 RID: 25889
		private static readonly IntPtr NativeFieldInfoPtr_eyelidsFollowEyesVertically;

		// Token: 0x04006522 RID: 25890
		private static readonly IntPtr NativeFieldInfoPtr__blink01_k__BackingField;

		// Token: 0x04006523 RID: 25891
		private static readonly IntPtr NativeFieldInfoPtr_useUpperEyelids;

		// Token: 0x04006524 RID: 25892
		private static readonly IntPtr NativeFieldInfoPtr_useLowerEyelids;

		// Token: 0x04006525 RID: 25893
		private static readonly IntPtr NativeFieldInfoPtr_timeOfNextBlink;

		// Token: 0x04006526 RID: 25894
		private static readonly IntPtr NativeFieldInfoPtr_blinkState;

		// Token: 0x04006527 RID: 25895
		private static readonly IntPtr NativeFieldInfoPtr_blinkStateTime;

		// Token: 0x04006528 RID: 25896
		private static readonly IntPtr NativeFieldInfoPtr_blinkDuration;

		// Token: 0x04006529 RID: 25897
		private static readonly IntPtr NativeFieldInfoPtr_isShortBlink;

		// Token: 0x0400652A RID: 25898
		private static readonly IntPtr NativeFieldInfoPtr_kBlinkCloseTimeShort;

		// Token: 0x0400652B RID: 25899
		private static readonly IntPtr NativeFieldInfoPtr_kBlinkOpenTimeShort;

		// Token: 0x0400652C RID: 25900
		private static readonly IntPtr NativeFieldInfoPtr_kBlinkCloseTimeLong;

		// Token: 0x0400652D RID: 25901
		private static readonly IntPtr NativeFieldInfoPtr_kBlinkOpenTimeLong;

		// Token: 0x0400652E RID: 25902
		private static readonly IntPtr NativeFieldInfoPtr_kBlinkKeepingClosedTime;

		// Token: 0x0400652F RID: 25903
		private static readonly IntPtr NativeFieldInfoPtr_maxEyeHorizAngle;

		// Token: 0x04006530 RID: 25904
		private static readonly IntPtr NativeFieldInfoPtr_maxEyeHorizAngleTowardsNose;

		// Token: 0x04006531 RID: 25905
		private static readonly IntPtr NativeFieldInfoPtr_crossEyeCorrection;

		// Token: 0x04006532 RID: 25906
		private static readonly IntPtr NativeFieldInfoPtr_nervousness;

		// Token: 0x04006533 RID: 25907
		private static readonly IntPtr NativeFieldInfoPtr_limitHeadAngle;

		// Token: 0x04006534 RID: 25908
		private static readonly IntPtr NativeFieldInfoPtr__eyeDistance_k__BackingField;

		// Token: 0x04006535 RID: 25909
		private static readonly IntPtr NativeFieldInfoPtr__eyeDistanceScale_k__BackingField;

		// Token: 0x04006536 RID: 25910
		private static readonly IntPtr NativeFieldInfoPtr_leftEyeAnchor;

		// Token: 0x04006537 RID: 25911
		private static readonly IntPtr NativeFieldInfoPtr_rightEyeAnchor;

		// Token: 0x04006538 RID: 25912
		private static readonly IntPtr NativeFieldInfoPtr_leftMaxSpeedHoriz;

		// Token: 0x04006539 RID: 25913
		private static readonly IntPtr NativeFieldInfoPtr_leftHorizDuration;

		// Token: 0x0400653A RID: 25914
		private static readonly IntPtr NativeFieldInfoPtr_leftMaxSpeedVert;

		// Token: 0x0400653B RID: 25915
		private static readonly IntPtr NativeFieldInfoPtr_leftVertDuration;

		// Token: 0x0400653C RID: 25916
		private static readonly IntPtr NativeFieldInfoPtr_leftCurrentSpeedX;

		// Token: 0x0400653D RID: 25917
		private static readonly IntPtr NativeFieldInfoPtr_leftCurrentSpeedY;

		// Token: 0x0400653E RID: 25918
		private static readonly IntPtr NativeFieldInfoPtr_rightMaxSpeedHoriz;

		// Token: 0x0400653F RID: 25919
		private static readonly IntPtr NativeFieldInfoPtr_rightHorizDuration;

		// Token: 0x04006540 RID: 25920
		private static readonly IntPtr NativeFieldInfoPtr_rightMaxSpeedVert;

		// Token: 0x04006541 RID: 25921
		private static readonly IntPtr NativeFieldInfoPtr_rightVertDuration;

		// Token: 0x04006542 RID: 25922
		private static readonly IntPtr NativeFieldInfoPtr_rightCurrentSpeedX;

		// Token: 0x04006543 RID: 25923
		private static readonly IntPtr NativeFieldInfoPtr_rightCurrentSpeedY;

		// Token: 0x04006544 RID: 25924
		private static readonly IntPtr NativeFieldInfoPtr_startLeftEyeHorizDuration;

		// Token: 0x04006545 RID: 25925
		private static readonly IntPtr NativeFieldInfoPtr_startLeftEyeVertDuration;

		// Token: 0x04006546 RID: 25926
		private static readonly IntPtr NativeFieldInfoPtr_startLeftEyeMaxSpeedHoriz;

		// Token: 0x04006547 RID: 25927
		private static readonly IntPtr NativeFieldInfoPtr_startLeftEyeMaxSpeedVert;

		// Token: 0x04006548 RID: 25928
		private static readonly IntPtr NativeFieldInfoPtr_startRightEyeHorizDuration;

		// Token: 0x04006549 RID: 25929
		private static readonly IntPtr NativeFieldInfoPtr_startRightEyeVertDuration;

		// Token: 0x0400654A RID: 25930
		private static readonly IntPtr NativeFieldInfoPtr_startRightEyeMaxSpeedHoriz;

		// Token: 0x0400654B RID: 25931
		private static readonly IntPtr NativeFieldInfoPtr_startRightEyeMaxSpeedVert;

		// Token: 0x0400654C RID: 25932
		private static readonly IntPtr NativeFieldInfoPtr_timeOfEyeMovementStart;

		// Token: 0x0400654D RID: 25933
		private static readonly IntPtr NativeFieldInfoPtr_timeOfHeadMovementStart;

		// Token: 0x0400654E RID: 25934
		private static readonly IntPtr NativeFieldInfoPtr_headMaxSpeedHoriz;

		// Token: 0x0400654F RID: 25935
		private static readonly IntPtr NativeFieldInfoPtr_headMaxSpeedVert;

		// Token: 0x04006550 RID: 25936
		private static readonly IntPtr NativeFieldInfoPtr_headHorizDuration;

		// Token: 0x04006551 RID: 25937
		private static readonly IntPtr NativeFieldInfoPtr_headVertDuration;

		// Token: 0x04006552 RID: 25938
		private static readonly IntPtr NativeFieldInfoPtr_startHeadHorizDuration;

		// Token: 0x04006553 RID: 25939
		private static readonly IntPtr NativeFieldInfoPtr_startHeadVertDuration;

		// Token: 0x04006554 RID: 25940
		private static readonly IntPtr NativeFieldInfoPtr_startHeadMaxSpeedHoriz;

		// Token: 0x04006555 RID: 25941
		private static readonly IntPtr NativeFieldInfoPtr_startHeadMaxSpeedVert;

		// Token: 0x04006556 RID: 25942
		private static readonly IntPtr NativeFieldInfoPtr_currentHeadHorizSpeed;

		// Token: 0x04006557 RID: 25943
		private static readonly IntPtr NativeFieldInfoPtr_currentHeadVertSpeed;

		// Token: 0x04006558 RID: 25944
		private static readonly IntPtr NativeFieldInfoPtr_currentHeadZSpeed;

		// Token: 0x04006559 RID: 25945
		private static readonly IntPtr NativeFieldInfoPtr_kMaxHeadVelocity;

		// Token: 0x0400655A RID: 25946
		private static readonly IntPtr NativeFieldInfoPtr_kHeadOmega;

		// Token: 0x0400655B RID: 25947
		private static readonly IntPtr NativeFieldInfoPtr_critDampTween;

		// Token: 0x0400655C RID: 25948
		private static readonly IntPtr NativeFieldInfoPtr_headEulerSpeed;

		// Token: 0x0400655D RID: 25949
		private static readonly IntPtr NativeFieldInfoPtr_lastHeadEuler;

		// Token: 0x0400655E RID: 25950
		private static readonly IntPtr NativeFieldInfoPtr_maxHeadHorizSpeedSinceSaccadeStart;

		// Token: 0x0400655F RID: 25951
		private static readonly IntPtr NativeFieldInfoPtr_maxHeadVertSpeedSinceSaccadeStart;

		// Token: 0x04006560 RID: 25952
		private static readonly IntPtr NativeFieldInfoPtr_isHeadTracking;

		// Token: 0x04006561 RID: 25953
		private static readonly IntPtr NativeFieldInfoPtr_headTrackingFactor;

		// Token: 0x04006562 RID: 25954
		private static readonly IntPtr NativeFieldInfoPtr_headLatency;

		// Token: 0x04006563 RID: 25955
		private static readonly IntPtr NativeFieldInfoPtr_eyeLatency;

		// Token: 0x04006564 RID: 25956
		private static readonly IntPtr NativeFieldInfoPtr_ikWeight;

		// Token: 0x04006565 RID: 25957
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04006566 RID: 25958
		private static readonly IntPtr NativeFieldInfoPtr_hasLateUpdateRunThisFrame;

		// Token: 0x04006567 RID: 25959
		private static readonly IntPtr NativeFieldInfoPtr_hasCheckedIdleLookTargetsThisFrame;

		// Token: 0x04006568 RID: 25960
		private static readonly IntPtr NativeFieldInfoPtr_placeNewIdleLookTargetsAtNextOpportunity;

		// Token: 0x04006569 RID: 25961
		private static readonly IntPtr NativeFieldInfoPtr_currentHeadTargetPOI;

		// Token: 0x0400656A RID: 25962
		private static readonly IntPtr NativeFieldInfoPtr_currentEyeTargetPOI;

		// Token: 0x0400656B RID: 25963
		private static readonly IntPtr NativeFieldInfoPtr_nextHeadTargetPOI;

		// Token: 0x0400656C RID: 25964
		private static readonly IntPtr NativeFieldInfoPtr_nextEyeTargetPOI;

		// Token: 0x0400656D RID: 25965
		private static readonly IntPtr NativeFieldInfoPtr_currentTargetLeftEyeXform;

		// Token: 0x0400656E RID: 25966
		private static readonly IntPtr NativeFieldInfoPtr_currentTargetRightEyeXform;

		// Token: 0x0400656F RID: 25967
		private static readonly IntPtr NativeFieldInfoPtr_nextTargetLeftEyeXform;

		// Token: 0x04006570 RID: 25968
		private static readonly IntPtr NativeFieldInfoPtr_nextTargetRightEyeXform;

		// Token: 0x04006571 RID: 25969
		private static readonly IntPtr NativeFieldInfoPtr_createdTargetXforms;

		// Token: 0x04006572 RID: 25970
		private static readonly IntPtr NativeFieldInfoPtr_createdTargetXformIndex;

		// Token: 0x04006573 RID: 25971
		private static readonly IntPtr NativeFieldInfoPtr__eyesRootXform_k__BackingField;

		// Token: 0x04006574 RID: 25972
		private static readonly IntPtr NativeFieldInfoPtr__headParentXform_k__BackingField;

		// Token: 0x04006575 RID: 25973
		private static readonly IntPtr NativeFieldInfoPtr_headTargetPivotXform;

		// Token: 0x04006576 RID: 25974
		private static readonly IntPtr NativeFieldInfoPtr_headXform;

		// Token: 0x04006577 RID: 25975
		private static readonly IntPtr NativeFieldInfoPtr_leftEyeRootFromAnchorQ;

		// Token: 0x04006578 RID: 25976
		private static readonly IntPtr NativeFieldInfoPtr_rightEyeRootFromAnchorQ;

		// Token: 0x04006579 RID: 25977
		private static readonly IntPtr NativeFieldInfoPtr_leftAnchorFromEyeRootQ;

		// Token: 0x0400657A RID: 25978
		private static readonly IntPtr NativeFieldInfoPtr_rightAnchorFromEyeRootQ;

		// Token: 0x0400657B RID: 25979
		private static readonly IntPtr NativeFieldInfoPtr_currentLeftEyeLocalEuler;

		// Token: 0x0400657C RID: 25980
		private static readonly IntPtr NativeFieldInfoPtr_currentRightEyeLocalEuler;

		// Token: 0x0400657D RID: 25981
		private static readonly IntPtr NativeFieldInfoPtr_originalLeftEyeLocalQ;

		// Token: 0x0400657E RID: 25982
		private static readonly IntPtr NativeFieldInfoPtr_originalRightEyeLocalQ;

		// Token: 0x0400657F RID: 25983
		private static readonly IntPtr NativeFieldInfoPtr_lastLeftEyeLocalRotation;

		// Token: 0x04006580 RID: 25984
		private static readonly IntPtr NativeFieldInfoPtr_lastRightEyeLocalQ;

		// Token: 0x04006581 RID: 25985
		private static readonly IntPtr NativeFieldInfoPtr_headBoneInAvatarQ;

		// Token: 0x04006582 RID: 25986
		private static readonly IntPtr NativeFieldInfoPtr_macroSaccadeTargetLocal;

		// Token: 0x04006583 RID: 25987
		private static readonly IntPtr NativeFieldInfoPtr_microSaccadeTargetLocal;

		// Token: 0x04006584 RID: 25988
		private static readonly IntPtr NativeFieldInfoPtr_timeOfEnteringClearingPhase;

		// Token: 0x04006585 RID: 25989
		private static readonly IntPtr NativeFieldInfoPtr_timeOfLastMacroSaccade;

		// Token: 0x04006586 RID: 25990
		private static readonly IntPtr NativeFieldInfoPtr_timeToMicroSaccade;

		// Token: 0x04006587 RID: 25991
		private static readonly IntPtr NativeFieldInfoPtr_timeToMacroSaccade;

		// Token: 0x04006588 RID: 25992
		private static readonly IntPtr NativeFieldInfoPtr_isInitialized;

		// Token: 0x04006589 RID: 25993
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameOfUpdate1;

		// Token: 0x0400658A RID: 25994
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameOfUpdate2;

		// Token: 0x0400658B RID: 25995
		private static readonly IntPtr NativeFieldInfoPtr_headSpeed;

		// Token: 0x0400658C RID: 25996
		private static readonly IntPtr NativeFieldInfoPtr_lookTarget;

		// Token: 0x0400658D RID: 25997
		private static readonly IntPtr NativeFieldInfoPtr_faceLookTarget;

		// Token: 0x0400658E RID: 25998
		private static readonly IntPtr NativeFieldInfoPtr_InRange;

		// Token: 0x0400658F RID: 25999
		private static readonly IntPtr NativeMethodInfoPtr_add_OnCannotGetTargetIntoView_Public_add_Void_Action_0;

		// Token: 0x04006590 RID: 26000
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnCannotGetTargetIntoView_Public_rem_Void_Action_0;

		// Token: 0x04006591 RID: 26001
		private static readonly IntPtr NativeMethodInfoPtr_add_OnTargetDestroyed_Public_add_Void_Action_0;

		// Token: 0x04006592 RID: 26002
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnTargetDestroyed_Public_rem_Void_Action_0;

		// Token: 0x04006593 RID: 26003
		private static readonly IntPtr NativeMethodInfoPtr_get_blink01_Public_get_Single_0;

		// Token: 0x04006594 RID: 26004
		private static readonly IntPtr NativeMethodInfoPtr_set_blink01_Private_set_Void_Single_0;

		// Token: 0x04006595 RID: 26005
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeDistance_Public_get_Single_0;

		// Token: 0x04006596 RID: 26006
		private static readonly IntPtr NativeMethodInfoPtr_set_eyeDistance_Private_set_Void_Single_0;

		// Token: 0x04006597 RID: 26007
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeDistanceScale_Public_get_Single_0;

		// Token: 0x04006598 RID: 26008
		private static readonly IntPtr NativeMethodInfoPtr_set_eyeDistanceScale_Private_set_Void_Single_0;

		// Token: 0x04006599 RID: 26009
		private static readonly IntPtr NativeMethodInfoPtr_get_eyesRootXform_Public_get_Transform_0;

		// Token: 0x0400659A RID: 26010
		private static readonly IntPtr NativeMethodInfoPtr_set_eyesRootXform_Private_set_Void_Transform_0;

		// Token: 0x0400659B RID: 26011
		private static readonly IntPtr NativeMethodInfoPtr_get_headParentXform_Public_get_Transform_0;

		// Token: 0x0400659C RID: 26012
		private static readonly IntPtr NativeMethodInfoPtr_set_headParentXform_Private_set_Void_Transform_0;

		// Token: 0x0400659D RID: 26013
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400659E RID: 26014
		private static readonly IntPtr NativeMethodInfoPtr_Blink_Public_Void_Boolean_0;

		// Token: 0x0400659F RID: 26015
		private static readonly IntPtr NativeMethodInfoPtr_CanGetIntoView_Public_Boolean_Vector3_0;

		// Token: 0x040065A0 RID: 26016
		private static readonly IntPtr NativeMethodInfoPtr_CanChangePointOfAttention_Public_Boolean_0;

		// Token: 0x040065A1 RID: 26017
		private static readonly IntPtr NativeMethodInfoPtr_CanImportFromFile_Public_Boolean_String_0;

		// Token: 0x040065A2 RID: 26018
		private static readonly IntPtr NativeMethodInfoPtr_CheckIdleLookTargets_Private_Void_0;

		// Token: 0x040065A3 RID: 26019
		private static readonly IntPtr NativeMethodInfoPtr_CheckLatencies_Private_Void_0;

		// Token: 0x040065A4 RID: 26020
		private static readonly IntPtr NativeMethodInfoPtr_CheckMacroSaccades_Private_Void_0;

		// Token: 0x040065A5 RID: 26021
		private static readonly IntPtr NativeMethodInfoPtr_CheckMicroSaccades_Private_Void_0;

		// Token: 0x040065A6 RID: 26022
		private static readonly IntPtr NativeMethodInfoPtr_ClampLeftHorizEyeAngle_Private_Single_Single_0;

		// Token: 0x040065A7 RID: 26023
		private static readonly IntPtr NativeMethodInfoPtr_ClampRightHorizEyeAngle_Private_Single_Single_0;

		// Token: 0x040065A8 RID: 26024
		private static readonly IntPtr NativeMethodInfoPtr_ClearLookTarget_Public_Void_0;

		// Token: 0x040065A9 RID: 26025
		private static readonly IntPtr NativeMethodInfoPtr_DrawSightlinesInEditor_Private_Void_0;

		// Token: 0x040065AA RID: 26026
		private static readonly IntPtr NativeMethodInfoPtr_ExportToFile_Public_Void_String_0;

		// Token: 0x040065AB RID: 26027
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentEyeTargetPos_Private_Vector3_0;

		// Token: 0x040065AC RID: 26028
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentHeadTargetPos_Private_Vector3_0;

		// Token: 0x040065AD RID: 26029
		private static readonly IntPtr NativeMethodInfoPtr_GetHeadDirection_Public_Vector3_0;

		// Token: 0x040065AE RID: 26030
		private static readonly IntPtr NativeMethodInfoPtr_GetLeftEyeDirection_Public_Vector3_0;

		// Token: 0x040065AF RID: 26031
		private static readonly IntPtr NativeMethodInfoPtr_GetLookTargetPosForSocialTriangle_Private_Vector3_FaceLookTarget_0;

		// Token: 0x040065B0 RID: 26032
		private static readonly IntPtr NativeMethodInfoPtr_GetOwnEyeCenter_Public_Vector3_0;

		// Token: 0x040065B1 RID: 26033
		private static readonly IntPtr NativeMethodInfoPtr_GetOwnEyeCenterXform_Public_Transform_0;

		// Token: 0x040065B2 RID: 26034
		private static readonly IntPtr NativeMethodInfoPtr_GetOwnLookDirection_Private_Vector3_0;

		// Token: 0x040065B3 RID: 26035
		private static readonly IntPtr NativeMethodInfoPtr_GetRightEyeDirection_Public_Vector3_0;

		// Token: 0x040065B4 RID: 26036
		private static readonly IntPtr NativeMethodInfoPtr_GetStareAngleMeAtTarget_Public_Single_Vector3_0;

		// Token: 0x040065B5 RID: 26037
		private static readonly IntPtr NativeMethodInfoPtr_GetStareAngleTargetAtMe_Public_Single_Transform_0;

		// Token: 0x040065B6 RID: 26038
		private static readonly IntPtr NativeMethodInfoPtr_ImportFromFile_Public_Void_String_0;

		// Token: 0x040065B7 RID: 26039
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x040065B8 RID: 26040
		private static readonly IntPtr NativeMethodInfoPtr_IsInView_Public_Boolean_Vector3_0;

		// Token: 0x040065B9 RID: 26041
		private static readonly IntPtr NativeMethodInfoPtr_IsLookingAtFace_Public_Boolean_0;

		// Token: 0x040065BA RID: 26042
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040065BB RID: 26043
		private static readonly IntPtr NativeMethodInfoPtr_LimitHorizontalHeadAngle_Private_Single_Single_0;

		// Token: 0x040065BC RID: 26044
		private static readonly IntPtr NativeMethodInfoPtr_LimitVerticalHeadAngle_Private_Single_Single_0;

		// Token: 0x040065BD RID: 26045
		private static readonly IntPtr NativeMethodInfoPtr_LookAtFace_Public_Void_Transform_Single_0;

		// Token: 0x040065BE RID: 26046
		private static readonly IntPtr NativeMethodInfoPtr_LookAtFace_Public_Void_Transform_Transform_Transform_Single_0;

		// Token: 0x040065BF RID: 26047
		private static readonly IntPtr NativeMethodInfoPtr_LookAtSpecificThing_Public_Void_Transform_Single_0;

		// Token: 0x040065C0 RID: 26048
		private static readonly IntPtr NativeMethodInfoPtr_LookAtSpecificThing_Public_Void_Vector3_Single_0;

		// Token: 0x040065C1 RID: 26049
		private static readonly IntPtr NativeMethodInfoPtr_LookAroundIdly_Public_Void_0;

		// Token: 0x040065C2 RID: 26050
		private static readonly IntPtr NativeMethodInfoPtr_LookAtAreaAround_Public_Void_Transform_0;

		// Token: 0x040065C3 RID: 26051
		private static readonly IntPtr NativeMethodInfoPtr_LookAtAreaAround_Public_Void_Vector3_0;

		// Token: 0x040065C4 RID: 26052
		private static readonly IntPtr NativeMethodInfoPtr_OnAnimatorIK_Private_Void_0;

		// Token: 0x040065C5 RID: 26053
		private static readonly IntPtr NativeMethodInfoPtr_OnCreatedXformDestroyed_Private_Void_DestroyNotifier_0;

		// Token: 0x040065C6 RID: 26054
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040065C7 RID: 26055
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040065C8 RID: 26056
		private static readonly IntPtr NativeMethodInfoPtr_SetMacroSaccadeTarget_Private_Void_Vector3_Boolean_0;

		// Token: 0x040065C9 RID: 26057
		private static readonly IntPtr NativeMethodInfoPtr_SetMicroSaccadeTarget_Private_Void_Vector3_Boolean_0;

		// Token: 0x040065CA RID: 26058
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040065CB RID: 26059
		private static readonly IntPtr NativeMethodInfoPtr_StartEyeMovement_Private_Void_Transform_Boolean_0;

		// Token: 0x040065CC RID: 26060
		private static readonly IntPtr NativeMethodInfoPtr_StartHeadMovement_Private_Void_Transform_0;

		// Token: 0x040065CD RID: 26061
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040065CE RID: 26062
		private static readonly IntPtr NativeMethodInfoPtr_Update1_Public_Void_0;

		// Token: 0x040065CF RID: 26063
		private static readonly IntPtr NativeMethodInfoPtr_Update2_Public_Void_0;

		// Token: 0x040065D0 RID: 26064
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBlinking_Private_Void_0;

		// Token: 0x040065D1 RID: 26065
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEyelids_Private_Void_0;

		// Token: 0x040065D2 RID: 26066
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEyeMovement_Private_Void_0;

		// Token: 0x040065D3 RID: 26067
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHeadMovement_Private_Void_0;

		// Token: 0x040065D4 RID: 26068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000783 RID: 1923
		public enum HeadControl
		{
			// Token: 0x040065D6 RID: 26070
			None,
			// Token: 0x040065D7 RID: 26071
			Mecanim,
			// Token: 0x040065D8 RID: 26072
			FinalIK,
			// Token: 0x040065D9 RID: 26073
			Transform
		}

		// Token: 0x02000784 RID: 1924
		public enum HeadTweenMethod
		{
			// Token: 0x040065DB RID: 26075
			SmoothDamping,
			// Token: 0x040065DC RID: 26076
			CriticalDamping
		}

		// Token: 0x02000785 RID: 1925
		public enum BlinkState
		{
			// Token: 0x040065DE RID: 26078
			Idle,
			// Token: 0x040065DF RID: 26079
			Closing,
			// Token: 0x040065E0 RID: 26080
			KeepingClosed,
			// Token: 0x040065E1 RID: 26081
			Opening
		}

		// Token: 0x02000786 RID: 1926
		public enum HeadSpeed
		{
			// Token: 0x040065E3 RID: 26083
			Slow,
			// Token: 0x040065E4 RID: 26084
			Fast
		}

		// Token: 0x02000787 RID: 1927
		public enum EyeDelay
		{
			// Token: 0x040065E6 RID: 26086
			Simultaneous,
			// Token: 0x040065E7 RID: 26087
			EyesFirst,
			// Token: 0x040065E8 RID: 26088
			HeadFirst
		}

		// Token: 0x02000788 RID: 1928
		public enum LookTarget
		{
			// Token: 0x040065EA RID: 26090
			None,
			// Token: 0x040065EB RID: 26091
			StraightAhead,
			// Token: 0x040065EC RID: 26092
			ClearingTargetPhase1,
			// Token: 0x040065ED RID: 26093
			ClearingTargetPhase2,
			// Token: 0x040065EE RID: 26094
			GeneralDirection,
			// Token: 0x040065EF RID: 26095
			LookingAroundIdly,
			// Token: 0x040065F0 RID: 26096
			SpecificThing,
			// Token: 0x040065F1 RID: 26097
			Face
		}

		// Token: 0x02000789 RID: 1929
		public enum FaceLookTarget
		{
			// Token: 0x040065F3 RID: 26099
			EyesCenter,
			// Token: 0x040065F4 RID: 26100
			LeftEye,
			// Token: 0x040065F5 RID: 26101
			RightEye,
			// Token: 0x040065F6 RID: 26102
			Mouth
		}
	}
}
