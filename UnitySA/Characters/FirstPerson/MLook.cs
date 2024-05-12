using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace UnitySA.Characters.FirstPerson
{
	// Token: 0x02000621 RID: 1569
	[Serializable]
	public class MLook : Il2CppSystem.Object
	{
		// Token: 0x06007F82 RID: 32642 RVA: 0x002034E0 File Offset: 0x002016E0
		[CallerCount(0)]
		public unsafe void Init(Transform character, Transform camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MLook.NativeMethodInfoPtr_Init_Public_Void_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F83 RID: 32643 RVA: 0x00203554 File Offset: 0x00201754
		[CallerCount(0)]
		public unsafe void LookRotation(Transform character, Transform camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MLook.NativeMethodInfoPtr_LookRotation_Public_Void_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F84 RID: 32644 RVA: 0x002035C8 File Offset: 0x002017C8
		[CallerCount(0)]
		public unsafe void SetCursorLock(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MLook.NativeMethodInfoPtr_SetCursorLock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F85 RID: 32645 RVA: 0x0020361C File Offset: 0x0020181C
		[CallerCount(0)]
		public unsafe void UpdateCursorLock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MLook.NativeMethodInfoPtr_UpdateCursorLock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F86 RID: 32646 RVA: 0x00203660 File Offset: 0x00201860
		[CallerCount(0)]
		public unsafe void InternalLockUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MLook.NativeMethodInfoPtr_InternalLockUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F87 RID: 32647 RVA: 0x002036A4 File Offset: 0x002018A4
		[CallerCount(0)]
		public unsafe Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref q;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MLook.NativeMethodInfoPtr_ClampRotationAroundXAxis_Private_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007F88 RID: 32648 RVA: 0x00203708 File Offset: 0x00201908
		[CallerCount(0)]
		public unsafe MLook() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MLook>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MLook.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F89 RID: 32649 RVA: 0x00203754 File Offset: 0x00201954
		// Note: this type is marked as 'beforefieldinit'.
		static MLook()
		{
			Il2CppClassPointerStore<MLook>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnitySA.Characters.FirstPerson", "MLook");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MLook>.NativeClassPtr);
			MLook.NativeFieldInfoPtr_XSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "XSensitivity");
			MLook.NativeFieldInfoPtr_YSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "YSensitivity");
			MLook.NativeFieldInfoPtr_clampVerticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "clampVerticalRotation");
			MLook.NativeFieldInfoPtr_MinimumX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "MinimumX");
			MLook.NativeFieldInfoPtr_MaximumX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "MaximumX");
			MLook.NativeFieldInfoPtr_smooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "smooth");
			MLook.NativeFieldInfoPtr_smoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "smoothTime");
			MLook.NativeFieldInfoPtr_lockCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "lockCursor");
			MLook.NativeFieldInfoPtr_m_CharacterTargetRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "m_CharacterTargetRot");
			MLook.NativeFieldInfoPtr_m_CameraTargetRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "m_CameraTargetRot");
			MLook.NativeFieldInfoPtr_m_cursorIsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "m_cursorIsLocked");
			MLook.NativeMethodInfoPtr_Init_Public_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100673591);
			MLook.NativeMethodInfoPtr_LookRotation_Public_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100673592);
			MLook.NativeMethodInfoPtr_SetCursorLock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100673593);
			MLook.NativeMethodInfoPtr_UpdateCursorLock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100673594);
			MLook.NativeMethodInfoPtr_InternalLockUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100673595);
			MLook.NativeMethodInfoPtr_ClampRotationAroundXAxis_Private_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100673596);
			MLook.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100673597);
		}

		// Token: 0x06007F8A RID: 32650 RVA: 0x00002988 File Offset: 0x00000B88
		public MLook(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x06007F8B RID: 32651 RVA: 0x002038EC File Offset: 0x00201AEC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MLook>.NativeClassPtr));
			}
		}

		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x06007F8C RID: 32652 RVA: 0x00203900 File Offset: 0x00201B00
		// (set) Token: 0x06007F8D RID: 32653 RVA: 0x00203928 File Offset: 0x00201B28
		public unsafe float XSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_XSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_XSensitivity)) = value;
			}
		}

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x06007F8E RID: 32654 RVA: 0x0020394C File Offset: 0x00201B4C
		// (set) Token: 0x06007F8F RID: 32655 RVA: 0x00203974 File Offset: 0x00201B74
		public unsafe float YSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_YSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_YSensitivity)) = value;
			}
		}

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x06007F90 RID: 32656 RVA: 0x00203998 File Offset: 0x00201B98
		// (set) Token: 0x06007F91 RID: 32657 RVA: 0x002039C0 File Offset: 0x00201BC0
		public unsafe bool clampVerticalRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_clampVerticalRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_clampVerticalRotation)) = value;
			}
		}

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x06007F92 RID: 32658 RVA: 0x002039E4 File Offset: 0x00201BE4
		// (set) Token: 0x06007F93 RID: 32659 RVA: 0x00203A0C File Offset: 0x00201C0C
		public unsafe float MinimumX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_MinimumX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_MinimumX)) = value;
			}
		}

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x06007F94 RID: 32660 RVA: 0x00203A30 File Offset: 0x00201C30
		// (set) Token: 0x06007F95 RID: 32661 RVA: 0x00203A58 File Offset: 0x00201C58
		public unsafe float MaximumX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_MaximumX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_MaximumX)) = value;
			}
		}

		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x06007F96 RID: 32662 RVA: 0x00203A7C File Offset: 0x00201C7C
		// (set) Token: 0x06007F97 RID: 32663 RVA: 0x00203AA4 File Offset: 0x00201CA4
		public unsafe bool smooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_smooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_smooth)) = value;
			}
		}

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x06007F98 RID: 32664 RVA: 0x00203AC8 File Offset: 0x00201CC8
		// (set) Token: 0x06007F99 RID: 32665 RVA: 0x00203AF0 File Offset: 0x00201CF0
		public unsafe float smoothTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_smoothTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_smoothTime)) = value;
			}
		}

		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x06007F9A RID: 32666 RVA: 0x00203B14 File Offset: 0x00201D14
		// (set) Token: 0x06007F9B RID: 32667 RVA: 0x00203B3C File Offset: 0x00201D3C
		public unsafe bool lockCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_lockCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_lockCursor)) = value;
			}
		}

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x06007F9C RID: 32668 RVA: 0x00203B60 File Offset: 0x00201D60
		// (set) Token: 0x06007F9D RID: 32669 RVA: 0x00203B88 File Offset: 0x00201D88
		public unsafe Quaternion m_CharacterTargetRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_m_CharacterTargetRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_m_CharacterTargetRot)) = value;
			}
		}

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x06007F9E RID: 32670 RVA: 0x00203BAC File Offset: 0x00201DAC
		// (set) Token: 0x06007F9F RID: 32671 RVA: 0x00203BD4 File Offset: 0x00201DD4
		public unsafe Quaternion m_CameraTargetRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_m_CameraTargetRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_m_CameraTargetRot)) = value;
			}
		}

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x06007FA0 RID: 32672 RVA: 0x00203BF8 File Offset: 0x00201DF8
		// (set) Token: 0x06007FA1 RID: 32673 RVA: 0x00203C20 File Offset: 0x00201E20
		public unsafe bool m_cursorIsLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_m_cursorIsLocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MLook.NativeFieldInfoPtr_m_cursorIsLocked)) = value;
			}
		}

		// Token: 0x040051C6 RID: 20934
		private static readonly IntPtr NativeFieldInfoPtr_XSensitivity;

		// Token: 0x040051C7 RID: 20935
		private static readonly IntPtr NativeFieldInfoPtr_YSensitivity;

		// Token: 0x040051C8 RID: 20936
		private static readonly IntPtr NativeFieldInfoPtr_clampVerticalRotation;

		// Token: 0x040051C9 RID: 20937
		private static readonly IntPtr NativeFieldInfoPtr_MinimumX;

		// Token: 0x040051CA RID: 20938
		private static readonly IntPtr NativeFieldInfoPtr_MaximumX;

		// Token: 0x040051CB RID: 20939
		private static readonly IntPtr NativeFieldInfoPtr_smooth;

		// Token: 0x040051CC RID: 20940
		private static readonly IntPtr NativeFieldInfoPtr_smoothTime;

		// Token: 0x040051CD RID: 20941
		private static readonly IntPtr NativeFieldInfoPtr_lockCursor;

		// Token: 0x040051CE RID: 20942
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterTargetRot;

		// Token: 0x040051CF RID: 20943
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraTargetRot;

		// Token: 0x040051D0 RID: 20944
		private static readonly IntPtr NativeFieldInfoPtr_m_cursorIsLocked;

		// Token: 0x040051D1 RID: 20945
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Transform_Transform_0;

		// Token: 0x040051D2 RID: 20946
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Public_Void_Transform_Transform_0;

		// Token: 0x040051D3 RID: 20947
		private static readonly IntPtr NativeMethodInfoPtr_SetCursorLock_Public_Void_Boolean_0;

		// Token: 0x040051D4 RID: 20948
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCursorLock_Public_Void_0;

		// Token: 0x040051D5 RID: 20949
		private static readonly IntPtr NativeMethodInfoPtr_InternalLockUpdate_Private_Void_0;

		// Token: 0x040051D6 RID: 20950
		private static readonly IntPtr NativeMethodInfoPtr_ClampRotationAroundXAxis_Private_Quaternion_Quaternion_0;

		// Token: 0x040051D7 RID: 20951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
