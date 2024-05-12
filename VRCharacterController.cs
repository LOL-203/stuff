using System;
using CodeStage.AntiCheat.ObscuredTypes;
using DPI.Networking;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Onward.Networking;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020004BD RID: 1213
public class VRCharacterController : MonoBehaviourDPINetworking
{
	// Token: 0x170022A0 RID: 8864
	// (get) Token: 0x06006079 RID: 24697 RVA: 0x00182C94 File Offset: 0x00180E94
	// (set) Token: 0x0600607A RID: 24698 RVA: 0x00182CE4 File Offset: 0x00180EE4
	public unsafe MovementState CurrentMovement
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_CurrentMovement_Public_get_MovementState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_set_CurrentMovement_Private_set_Void_MovementState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170022A1 RID: 8865
	// (get) Token: 0x0600607B RID: 24699 RVA: 0x00182D38 File Offset: 0x00180F38
	// (set) Token: 0x0600607C RID: 24700 RVA: 0x00182D88 File Offset: 0x00180F88
	public unsafe PostureState PostureState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_PostureState_Public_get_PostureState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_set_PostureState_Private_set_Void_PostureState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170022A2 RID: 8866
	// (get) Token: 0x0600607D RID: 24701 RVA: 0x00182DDC File Offset: 0x00180FDC
	// (set) Token: 0x0600607E RID: 24702 RVA: 0x00182E2C File Offset: 0x0018102C
	public unsafe float CurrentMovementSpeed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_CurrentMovementSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_set_CurrentMovementSpeed_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170022A3 RID: 8867
	// (get) Token: 0x0600607F RID: 24703 RVA: 0x00182E80 File Offset: 0x00181080
	// (set) Token: 0x06006080 RID: 24704 RVA: 0x00182ED0 File Offset: 0x001810D0
	public unsafe float CurrentHeightPercentage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_CurrentHeightPercentage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_set_CurrentHeightPercentage_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170022A4 RID: 8868
	// (get) Token: 0x06006081 RID: 24705 RVA: 0x00182F24 File Offset: 0x00181124
	// (set) Token: 0x06006082 RID: 24706 RVA: 0x00182F74 File Offset: 0x00181174
	public unsafe float SpecOpsSpeedMultiplier
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_SpecOpsSpeedMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_set_SpecOpsSpeedMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170022A5 RID: 8869
	// (get) Token: 0x06006083 RID: 24707 RVA: 0x00182FC8 File Offset: 0x001811C8
	// (set) Token: 0x06006084 RID: 24708 RVA: 0x00183018 File Offset: 0x00181218
	public unsafe CasualtyUIState CurrentCasualtyUIState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_CurrentCasualtyUIState_Public_get_CasualtyUIState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_set_CurrentCasualtyUIState_Public_set_Void_CasualtyUIState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170022A6 RID: 8870
	// (get) Token: 0x06006085 RID: 24709 RVA: 0x0018306C File Offset: 0x0018126C
	// (set) Token: 0x06006086 RID: 24710 RVA: 0x001830BC File Offset: 0x001812BC
	public unsafe bool GunActive
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_GunActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_set_GunActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170022A7 RID: 8871
	// (get) Token: 0x06006087 RID: 24711 RVA: 0x00183110 File Offset: 0x00181310
	// (set) Token: 0x06006088 RID: 24712 RVA: 0x00183160 File Offset: 0x00181360
	public unsafe float WeaponAngle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_WeaponAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_set_WeaponAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170022A8 RID: 8872
	// (get) Token: 0x06006089 RID: 24713 RVA: 0x001831B4 File Offset: 0x001813B4
	// (set) Token: 0x0600608A RID: 24714 RVA: 0x00183204 File Offset: 0x00181404
	public unsafe bool Touching
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_Touching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_set_Touching_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170022A9 RID: 8873
	// (get) Token: 0x0600608B RID: 24715 RVA: 0x00183258 File Offset: 0x00181458
	// (set) Token: 0x0600608C RID: 24716 RVA: 0x001832A8 File Offset: 0x001814A8
	public unsafe bool AllowedExploitCheck
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_AllowedExploitCheck_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_set_AllowedExploitCheck_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170022AA RID: 8874
	// (get) Token: 0x0600608D RID: 24717 RVA: 0x001832FC File Offset: 0x001814FC
	// (set) Token: 0x0600608E RID: 24718 RVA: 0x00183348 File Offset: 0x00181548
	public unsafe Nullable<float> HeightWhenFell
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_HeightWhenFell_Public_get_Nullable_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return new Nullable<float>(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_set_HeightWhenFell_Public_set_Void_Nullable_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170022AB RID: 8875
	// (get) Token: 0x0600608F RID: 24719 RVA: 0x001833A8 File Offset: 0x001815A8
	public unsafe Transform CameraRig
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_CameraRig_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
	}

	// Token: 0x170022AC RID: 8876
	// (get) Token: 0x06006090 RID: 24720 RVA: 0x00183400 File Offset: 0x00181600
	public unsafe Vector3 Velocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170022AD RID: 8877
	// (get) Token: 0x06006091 RID: 24721 RVA: 0x00183450 File Offset: 0x00181650
	public unsafe Camera VrCam
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_VrCam_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Camera(intPtr2) : null;
		}
	}

	// Token: 0x170022AE RID: 8878
	// (get) Token: 0x06006092 RID: 24722 RVA: 0x001834A8 File Offset: 0x001816A8
	public unsafe CharacterController CharacterController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_CharacterController_Public_get_CharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new CharacterController(intPtr2) : null;
		}
	}

	// Token: 0x170022AF RID: 8879
	// (get) Token: 0x06006093 RID: 24723 RVA: 0x00183500 File Offset: 0x00181700
	public unsafe bool IsMoving
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170022B0 RID: 8880
	// (get) Token: 0x06006094 RID: 24724 RVA: 0x00183550 File Offset: 0x00181750
	public unsafe bool IsCrouching
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_IsCrouching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170022B1 RID: 8881
	// (get) Token: 0x06006095 RID: 24725 RVA: 0x001835A0 File Offset: 0x001817A0
	public unsafe bool IsProne
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_IsProne_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170022B2 RID: 8882
	// (get) Token: 0x06006096 RID: 24726 RVA: 0x001835F0 File Offset: 0x001817F0
	public unsafe bool IsInsideSomething
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_IsInsideSomething_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x06006097 RID: 24727 RVA: 0x00183640 File Offset: 0x00181840
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006098 RID: 24728 RVA: 0x00183684 File Offset: 0x00181884
	[CallerCount(0)]
	public unsafe void GetRadioAndKnifePositions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_GetRadioAndKnifePositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006099 RID: 24729 RVA: 0x001836C8 File Offset: 0x001818C8
	[CallerCount(0)]
	public unsafe void SetCrouchAndProneHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_SetCrouchAndProneHeight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600609A RID: 24730 RVA: 0x0018370C File Offset: 0x0018190C
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600609B RID: 24731 RVA: 0x00183750 File Offset: 0x00181950
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600609C RID: 24732 RVA: 0x00183794 File Offset: 0x00181994
	[CallerCount(0)]
	public unsafe void OnWeightClassChanged(WeightClass weightClass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref weightClass;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_OnWeightClassChanged_Private_Void_WeightClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600609D RID: 24733 RVA: 0x001837E8 File Offset: 0x001819E8
	[CallerCount(0)]
	public unsafe void MyWarPlayerOnPlayerSpawned()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_MyWarPlayerOnPlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600609E RID: 24734 RVA: 0x0018382C File Offset: 0x00181A2C
	[CallerCount(0)]
	public unsafe void SetPlayerHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_SetPlayerHeight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600609F RID: 24735 RVA: 0x00183870 File Offset: 0x00181A70
	[CallerCount(0)]
	public unsafe Vector3 GetHeightForIndex(int heightIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref heightIndex;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_GetHeightForIndex_Private_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060060A0 RID: 24736 RVA: 0x001838D4 File Offset: 0x00181AD4
	[CallerCount(0)]
	public unsafe void SetRadioAndKnifePosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_SetRadioAndKnifePosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060A1 RID: 24737 RVA: 0x00183918 File Offset: 0x00181B18
	[CallerCount(0)]
	public unsafe void GetCharacterControllerSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_GetCharacterControllerSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060A2 RID: 24738 RVA: 0x0018395C File Offset: 0x00181B5C
	[CallerCount(0)]
	public unsafe void UpdateMovementProfile(WeightClass weightClass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref weightClass;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_UpdateMovementProfile_Private_Void_WeightClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060A3 RID: 24739 RVA: 0x001839B0 File Offset: 0x00181BB0
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060A4 RID: 24740 RVA: 0x001839F4 File Offset: 0x00181BF4
	[CallerCount(0)]
	public unsafe void MovePlayerToLocation(Vector3 Pos, Quaternion Rot, bool synchronous = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref Pos;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Rot;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synchronous;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_MovePlayerToLocation_Public_Void_Vector3_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060A5 RID: 24741 RVA: 0x00183A70 File Offset: 0x00181C70
	[CallerCount(0)]
	public unsafe IEnumerator DelayedCameraOffset(bool synchronous)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref synchronous;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_DelayedCameraOffset_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x060060A6 RID: 24742 RVA: 0x00183AD8 File Offset: 0x00181CD8
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x170022B3 RID: 8883
	// (get) Token: 0x060060A7 RID: 24743 RVA: 0x00183B1C File Offset: 0x00181D1C
	// (set) Token: 0x060060A8 RID: 24744 RVA: 0x00183B6C File Offset: 0x00181D6C
	public unsafe bool ManagedLateUpdateRemoval
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_ManagedLateUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_set_ManagedLateUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x060060A9 RID: 24745 RVA: 0x00183BC0 File Offset: 0x00181DC0
	[CallerCount(0)]
	public unsafe void OnManagedLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_OnManagedLateUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060AA RID: 24746 RVA: 0x00183C04 File Offset: 0x00181E04
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060AB RID: 24747 RVA: 0x00183C48 File Offset: 0x00181E48
	[CallerCount(0)]
	public unsafe void FrameToFrameOutOfBoundsExploitCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_FrameToFrameOutOfBoundsExploitCheck_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060AC RID: 24748 RVA: 0x00183C8C File Offset: 0x00181E8C
	[CallerCount(0)]
	public unsafe void DistanceOutOfBoundsExploitCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_DistanceOutOfBoundsExploitCheck_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060AD RID: 24749 RVA: 0x00183CD0 File Offset: 0x00181ED0
	[CallerCount(0)]
	public unsafe void ExploitLerp(Vector3 bodyPosition, Vector3 cameraPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref bodyPosition;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cameraPosition;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_ExploitLerp_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x170022B4 RID: 8884
	// (get) Token: 0x060060AE RID: 24750 RVA: 0x00183D38 File Offset: 0x00181F38
	// (set) Token: 0x060060AF RID: 24751 RVA: 0x00183D88 File Offset: 0x00181F88
	public unsafe bool ManagedFixedUpdateRemoval
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_get_ManagedFixedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_set_ManagedFixedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x060060B0 RID: 24752 RVA: 0x00183DDC File Offset: 0x00181FDC
	[CallerCount(0)]
	public unsafe void OnManagedFixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_OnManagedFixedUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060B1 RID: 24753 RVA: 0x00183E20 File Offset: 0x00182020
	[CallerCount(0)]
	public unsafe void CheckHeightStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_CheckHeightStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060B2 RID: 24754 RVA: 0x00183E64 File Offset: 0x00182064
	[CallerCount(0)]
	public unsafe bool SatisfiesExternalSprintingConditions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_SatisfiesExternalSprintingConditions_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060060B3 RID: 24755 RVA: 0x00183EB4 File Offset: 0x001820B4
	[CallerCount(0)]
	public unsafe void UpdateLocomotion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_UpdateLocomotion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060B4 RID: 24756 RVA: 0x00183EF8 File Offset: 0x001820F8
	[CallerCount(0)]
	public unsafe void ModifySpeedForSpecOps()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_ModifySpeedForSpecOps_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060B5 RID: 24757 RVA: 0x00183F3C File Offset: 0x0018213C
	[CallerCount(0)]
	public unsafe void ModifySpeedFromWeaponHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_ModifySpeedFromWeaponHeight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060B6 RID: 24758 RVA: 0x00183F80 File Offset: 0x00182180
	[CallerCount(0)]
	public unsafe void SetWeaponAngle(float angle, WeaponType weaponType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref angle;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponType;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_SetWeaponAngle_Public_Void_Single_WeaponType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060B7 RID: 24759 RVA: 0x00183FE8 File Offset: 0x001821E8
	[CallerCount(0)]
	public unsafe void CalculateSpeedFromMovementAndPosture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_CalculateSpeedFromMovementAndPosture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060B8 RID: 24760 RVA: 0x0018402C File Offset: 0x0018222C
	[CallerCount(0)]
	public unsafe void SprintValidation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_SprintValidation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060B9 RID: 24761 RVA: 0x00184070 File Offset: 0x00182270
	[CallerCount(0)]
	public unsafe float GetPlayersForwardDirection(Vector2 xyInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref xyInput;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_GetPlayersForwardDirection_Private_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060060BA RID: 24762 RVA: 0x001840D4 File Offset: 0x001822D4
	[CallerCount(0)]
	public unsafe float GetStrafeAmount(float playersOrientation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref playersOrientation;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_GetStrafeAmount_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060060BB RID: 24763 RVA: 0x00184138 File Offset: 0x00182338
	[CallerCount(0)]
	public unsafe Transform GetLocomotionSource()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_GetLocomotionSource_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new Transform(intPtr2) : null;
	}

	// Token: 0x060060BC RID: 24764 RVA: 0x00184190 File Offset: 0x00182390
	[CallerCount(0)]
	public unsafe Vector3 GetForwardMoveDirection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_GetForwardMoveDirection_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060060BD RID: 24765 RVA: 0x001841E0 File Offset: 0x001823E0
	[CallerCount(0)]
	public unsafe void SetVestPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_SetVestPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060BE RID: 24766 RVA: 0x00184224 File Offset: 0x00182424
	[CallerCount(0)]
	public unsafe void MovePlayer(float moveSpeed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref moveSpeed;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_MovePlayer_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060BF RID: 24767 RVA: 0x00184278 File Offset: 0x00182478
	[CallerCount(0)]
	public unsafe Vector3 ApplyDeadZone(Vector3 input, float threshold)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref input;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_ApplyDeadZone_Private_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060060C0 RID: 24768 RVA: 0x001842F0 File Offset: 0x001824F0
	[CallerCount(0)]
	public unsafe bool IsUsingDrone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_IsUsingDrone_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060060C1 RID: 24769 RVA: 0x00184340 File Offset: 0x00182540
	[CallerCount(0)]
	public unsafe void RestrictRoomScaleMovement(Vector3 input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref input;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_RestrictRoomScaleMovement_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060C2 RID: 24770 RVA: 0x00184394 File Offset: 0x00182594
	[CallerCount(0)]
	public unsafe void UpdateFallDamage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_UpdateFallDamage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060C3 RID: 24771 RVA: 0x001843D8 File Offset: 0x001825D8
	[CallerCount(0)]
	public unsafe void UpdateExploitCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_UpdateExploitCheck_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060C4 RID: 24772 RVA: 0x0018441C File Offset: 0x0018261C
	[CallerCount(0)]
	public unsafe void OnDownedOrDead(DPIPlayer source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_OnDownedOrDead_Private_Void_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060C5 RID: 24773 RVA: 0x00184478 File Offset: 0x00182678
	[CallerCount(0)]
	public unsafe void UpdateGhostWalkingCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_UpdateGhostWalkingCheck_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060C6 RID: 24774 RVA: 0x001844BC File Offset: 0x001826BC
	[CallerCount(0)]
	public unsafe void Recenter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_Recenter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060C7 RID: 24775 RVA: 0x00184500 File Offset: 0x00182700
	[CallerCount(0)]
	public unsafe void ResetExploitChecks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_ResetExploitChecks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060C8 RID: 24776 RVA: 0x00184544 File Offset: 0x00182744
	[CallerCount(0)]
	public unsafe void RespawnReset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_RespawnReset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060C9 RID: 24777 RVA: 0x00184588 File Offset: 0x00182788
	[CallerCount(0)]
	public unsafe void UserControl(bool control)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref control;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_UserControl_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060CA RID: 24778 RVA: 0x001845DC File Offset: 0x001827DC
	[CallerCount(0)]
	public unsafe float ScaleValue(float OldMin, float OldMax, float NewMin, float NewMax, float OldValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref OldMin;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OldMax;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref NewMin;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref NewMax;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OldValue;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_ScaleValue_Public_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060060CB RID: 24779 RVA: 0x0018468C File Offset: 0x0018288C
	[CallerCount(0)]
	public unsafe void SetCapsuleCollider(bool active)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref active;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr_SetCapsuleCollider_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060CC RID: 24780 RVA: 0x001846E0 File Offset: 0x001828E0
	[CallerCount(0)]
	public unsafe VRCharacterController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060060CD RID: 24781 RVA: 0x0018472C File Offset: 0x0018292C
	// Note: this type is marked as 'beforefieldinit'.
	static VRCharacterController()
	{
		Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VRCharacterController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr);
		VRCharacterController.NativeFieldInfoPtr_CameraManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "CameraManager");
		VRCharacterController.NativeFieldInfoPtr_m_CameraCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "m_CameraCollision");
		VRCharacterController.NativeFieldInfoPtr_HeadCheckCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "HeadCheckCollider");
		VRCharacterController.NativeFieldInfoPtr_HeadCollisionDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "HeadCollisionDetector");
		VRCharacterController.NativeFieldInfoPtr_LeftHandMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "LeftHandMesh");
		VRCharacterController.NativeFieldInfoPtr_RightHandMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "RightHandMesh");
		VRCharacterController.NativeFieldInfoPtr_MyWarplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "MyWarplayer");
		VRCharacterController.NativeFieldInfoPtr_ImageHeightExploit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "ImageHeightExploit");
		VRCharacterController.NativeFieldInfoPtr_LocalVestPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "LocalVestPivot");
		VRCharacterController.NativeFieldInfoPtr_LocalVestBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "LocalVestBody");
		VRCharacterController.NativeFieldInfoPtr_VestHeadSpineTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "VestHeadSpineTarget");
		VRCharacterController.NativeFieldInfoPtr_radioRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "radioRef");
		VRCharacterController.NativeFieldInfoPtr_knifeRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "knifeRef");
		VRCharacterController.NativeFieldInfoPtr_CharacterRigidBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "CharacterRigidBody");
		VRCharacterController.NativeFieldInfoPtr_PlayerCapsule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "PlayerCapsule");
		VRCharacterController.NativeFieldInfoPtr_GunHoldLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "GunHoldLeft");
		VRCharacterController.NativeFieldInfoPtr_GunHoldRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "GunHoldRight");
		VRCharacterController.NativeFieldInfoPtr_IkBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "IkBody");
		VRCharacterController.NativeFieldInfoPtr_AnimatorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "AnimatorTransform");
		VRCharacterController.NativeFieldInfoPtr__CurrentMovement_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<CurrentMovement>k__BackingField");
		VRCharacterController.NativeFieldInfoPtr__PostureState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<PostureState>k__BackingField");
		VRCharacterController.NativeFieldInfoPtr__CurrentMovementSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<CurrentMovementSpeed>k__BackingField");
		VRCharacterController.NativeFieldInfoPtr__CurrentHeightPercentage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<CurrentHeightPercentage>k__BackingField");
		VRCharacterController.NativeFieldInfoPtr__SpecOpsSpeedMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<SpecOpsSpeedMultiplier>k__BackingField");
		VRCharacterController.NativeFieldInfoPtr__CurrentCasualtyUIState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<CurrentCasualtyUIState>k__BackingField");
		VRCharacterController.NativeFieldInfoPtr__GunActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<GunActive>k__BackingField");
		VRCharacterController.NativeFieldInfoPtr__WeaponAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<WeaponAngle>k__BackingField");
		VRCharacterController.NativeFieldInfoPtr__Touching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<Touching>k__BackingField");
		VRCharacterController.NativeFieldInfoPtr__AllowedExploitCheck_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<AllowedExploitCheck>k__BackingField");
		VRCharacterController.NativeFieldInfoPtr__HeightWhenFell_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<HeightWhenFell>k__BackingField");
		VRCharacterController.NativeFieldInfoPtr__cameraRig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_cameraRig");
		VRCharacterController.NativeFieldInfoPtr__vrCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_vrCam");
		VRCharacterController.NativeFieldInfoPtr__characterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_characterController");
		VRCharacterController.NativeFieldInfoPtr_lastClickTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "lastClickTime");
		VRCharacterController.NativeFieldInfoPtr_doubleclicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "doubleclicked");
		VRCharacterController.NativeFieldInfoPtr_isUpdating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "isUpdating");
		VRCharacterController.NativeFieldInfoPtr_OriginalLocalVestHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "OriginalLocalVestHeight");
		VRCharacterController.NativeFieldInfoPtr_isUsingGunStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "isUsingGunStock");
		VRCharacterController.NativeFieldInfoPtr_HeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "HeightOffset");
		VRCharacterController.NativeFieldInfoPtr_heightInMeters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "heightInMeters");
		VRCharacterController.NativeFieldInfoPtr_useSinglePressSprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "useSinglePressSprint");
		VRCharacterController.NativeFieldInfoPtr_potentialHeightExploit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "potentialHeightExploit");
		VRCharacterController.NativeFieldInfoPtr__isInsideSomething = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_isInsideSomething");
		VRCharacterController.NativeFieldInfoPtr_potentialUndergroundExploitCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "potentialUndergroundExploitCheck");
		VRCharacterController.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "moveSpeed");
		VRCharacterController.NativeFieldInfoPtr_isMovementLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "isMovementLocked");
		VRCharacterController.NativeFieldInfoPtr_wasGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "wasGrounded");
		VRCharacterController.NativeFieldInfoPtr_maxRoomSizeForwards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "maxRoomSizeForwards");
		VRCharacterController.NativeFieldInfoPtr_maxRoomSizeBackwards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "maxRoomSizeBackwards");
		VRCharacterController.NativeFieldInfoPtr_exploitCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "exploitCheck");
		VRCharacterController.NativeFieldInfoPtr_previousHeadPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "previousHeadPosition");
		VRCharacterController.NativeFieldInfoPtr_previousLeftHandPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "previousLeftHandPosition");
		VRCharacterController.NativeFieldInfoPtr_previousRightHandPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "previousRightHandPosition");
		VRCharacterController.NativeFieldInfoPtr_teleportAllowance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "teleportAllowance");
		VRCharacterController.NativeFieldInfoPtr__velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_velocity");
		VRCharacterController.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "lastPosition");
		VRCharacterController.NativeFieldInfoPtr_maxVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "maxVelocity");
		VRCharacterController.NativeFieldInfoPtr_CasualtyUIInfractionPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "CasualtyUIInfractionPlayer");
		VRCharacterController.NativeFieldInfoPtr__applyingInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_applyingInput");
		VRCharacterController.NativeFieldInfoPtr_spawnLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "spawnLocation");
		VRCharacterController.NativeFieldInfoPtr_spawnRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "spawnRotation");
		VRCharacterController.NativeFieldInfoPtr_settingSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "settingSpawnPoint");
		VRCharacterController.NativeFieldInfoPtr__thisTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_thisTransform");
		VRCharacterController.NativeFieldInfoPtr__headCollisionDetectorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_headCollisionDetectorTransform");
		VRCharacterController.NativeFieldInfoPtr__headCharacterControllerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_headCharacterControllerTransform");
		VRCharacterController.NativeFieldInfoPtr_deathFeetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "deathFeetPosition");
		VRCharacterController.NativeFieldInfoPtr_deathHeadRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "deathHeadRotation");
		VRCharacterController.NativeFieldInfoPtr_m_prevRoomScalePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "m_prevRoomScalePos");
		VRCharacterController.NativeFieldInfoPtr_m_roomScaleVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "m_roomScaleVelocity");
		VRCharacterController.NativeFieldInfoPtr_m_lastCamPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "m_lastCamPos");
		VRCharacterController.NativeFieldInfoPtr__strafeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_strafeAmount");
		VRCharacterController.NativeFieldInfoPtr__forwardMoveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_forwardMoveDirection");
		VRCharacterController.NativeFieldInfoPtr__playerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_playerSpeed");
		VRCharacterController.NativeFieldInfoPtr__weightMovementData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_weightMovementData");
		VRCharacterController.NativeFieldInfoPtr__speedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_speedModifier");
		VRCharacterController.NativeFieldInfoPtr_VRRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "VRRotation");
		VRCharacterController.NativeFieldInfoPtr_m_locomotionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "m_locomotionMode");
		VRCharacterController.NativeFieldInfoPtr_m_gunStockMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "m_gunStockMode");
		VRCharacterController.NativeFieldInfoPtr_m_useRadioRightShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "m_useRadioRightShoulder");
		VRCharacterController.NativeFieldInfoPtr_ProneHeightFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "ProneHeightFraction");
		VRCharacterController.NativeFieldInfoPtr_CrouchHeightFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "CrouchHeightFraction");
		VRCharacterController.NativeFieldInfoPtr_SprintingMinHeightFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "SprintingMinHeightFraction");
		VRCharacterController.NativeFieldInfoPtr_SprintingMaxHeightFraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "SprintingMaxHeightFraction");
		VRCharacterController.NativeFieldInfoPtr_ProneHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "ProneHeight");
		VRCharacterController.NativeFieldInfoPtr_CrouchingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "CrouchingHeight");
		VRCharacterController.NativeFieldInfoPtr_MinSprintingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "MinSprintingHeight");
		VRCharacterController.NativeFieldInfoPtr_MaxSprintingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "MaxSprintingHeight");
		VRCharacterController.NativeFieldInfoPtr_HeightOffsetCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "HeightOffsetCurve");
		VRCharacterController.NativeFieldInfoPtr_transformCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "transformCache");
		VRCharacterController.NativeFieldInfoPtr_vrCamTransformCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "vrCamTransformCache");
		VRCharacterController.NativeFieldInfoPtr_feetTransformCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "feetTransformCache");
		VRCharacterController.NativeFieldInfoPtr__RadioLeftPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_RadioLeftPosition");
		VRCharacterController.NativeFieldInfoPtr__KnifeLeftPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_KnifeLeftPosition");
		VRCharacterController.NativeFieldInfoPtr__RadioRightPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_RadioRightPosition");
		VRCharacterController.NativeFieldInfoPtr__KnifeRightPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_KnifeRightPosition");
		VRCharacterController.NativeFieldInfoPtr__isUsingControllerTilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_isUsingControllerTilt");
		VRCharacterController.NativeFieldInfoPtr__playerPrefSetHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_playerPrefSetHeight");
		VRCharacterController.NativeFieldInfoPtr__currentWeaponType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "_currentWeaponType");
		VRCharacterController.NativeFieldInfoPtr_PlayerBoundsDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "PlayerBoundsDetector");
		VRCharacterController.NativeFieldInfoPtr_GHOST_WALK_FRAME_SKIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "GHOST_WALK_FRAME_SKIP");
		VRCharacterController.NativeFieldInfoPtr_GHOST_WALK_DISTANCE_SQR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "GHOST_WALK_DISTANCE_SQR");
		VRCharacterController.NativeFieldInfoPtr_DOUBLE_CLICK_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "DOUBLE_CLICK_TIME");
		VRCharacterController.NativeFieldInfoPtr_DAMAGE_PER_METER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "DAMAGE_PER_METER");
		VRCharacterController.NativeFieldInfoPtr_ALWAYS_SAFE_HEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "ALWAYS_SAFE_HEIGHT");
		VRCharacterController.NativeFieldInfoPtr_LastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "LastPos");
		VRCharacterController.NativeFieldInfoPtr_MinPlayerScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "MinPlayerScale");
		VRCharacterController.NativeFieldInfoPtr_MaxPlayerScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "MaxPlayerScale");
		VRCharacterController.NativeFieldInfoPtr_Scales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "Scales");
		VRCharacterController.NativeFieldInfoPtr_LowestScaleVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "LowestScaleVector");
		VRCharacterController.NativeFieldInfoPtr_ScaleIncreasePerInch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "ScaleIncreasePerInch");
		VRCharacterController.NativeFieldInfoPtr_DEBUG_exploitCheckLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "DEBUG_exploitCheckLogs");
		VRCharacterController.NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<ManagedLateUpdateRemoval>k__BackingField");
		VRCharacterController.NativeFieldInfoPtr__ManagedFixedUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<ManagedFixedUpdateRemoval>k__BackingField");
		VRCharacterController.NativeMethodInfoPtr_get_CurrentMovement_Public_get_MovementState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670975);
		VRCharacterController.NativeMethodInfoPtr_set_CurrentMovement_Private_set_Void_MovementState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670976);
		VRCharacterController.NativeMethodInfoPtr_get_PostureState_Public_get_PostureState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670977);
		VRCharacterController.NativeMethodInfoPtr_set_PostureState_Private_set_Void_PostureState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670978);
		VRCharacterController.NativeMethodInfoPtr_get_CurrentMovementSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670979);
		VRCharacterController.NativeMethodInfoPtr_set_CurrentMovementSpeed_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670980);
		VRCharacterController.NativeMethodInfoPtr_get_CurrentHeightPercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670981);
		VRCharacterController.NativeMethodInfoPtr_set_CurrentHeightPercentage_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670982);
		VRCharacterController.NativeMethodInfoPtr_get_SpecOpsSpeedMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670983);
		VRCharacterController.NativeMethodInfoPtr_set_SpecOpsSpeedMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670984);
		VRCharacterController.NativeMethodInfoPtr_get_CurrentCasualtyUIState_Public_get_CasualtyUIState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670985);
		VRCharacterController.NativeMethodInfoPtr_set_CurrentCasualtyUIState_Public_set_Void_CasualtyUIState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670986);
		VRCharacterController.NativeMethodInfoPtr_get_GunActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670987);
		VRCharacterController.NativeMethodInfoPtr_set_GunActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670988);
		VRCharacterController.NativeMethodInfoPtr_get_WeaponAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670989);
		VRCharacterController.NativeMethodInfoPtr_set_WeaponAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670990);
		VRCharacterController.NativeMethodInfoPtr_get_Touching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670991);
		VRCharacterController.NativeMethodInfoPtr_set_Touching_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670992);
		VRCharacterController.NativeMethodInfoPtr_get_AllowedExploitCheck_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670993);
		VRCharacterController.NativeMethodInfoPtr_set_AllowedExploitCheck_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670994);
		VRCharacterController.NativeMethodInfoPtr_get_HeightWhenFell_Public_get_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670995);
		VRCharacterController.NativeMethodInfoPtr_set_HeightWhenFell_Public_set_Void_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670996);
		VRCharacterController.NativeMethodInfoPtr_get_CameraRig_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670997);
		VRCharacterController.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670998);
		VRCharacterController.NativeMethodInfoPtr_get_VrCam_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100670999);
		VRCharacterController.NativeMethodInfoPtr_get_CharacterController_Public_get_CharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671000);
		VRCharacterController.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671001);
		VRCharacterController.NativeMethodInfoPtr_get_IsCrouching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671002);
		VRCharacterController.NativeMethodInfoPtr_get_IsProne_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671003);
		VRCharacterController.NativeMethodInfoPtr_get_IsInsideSomething_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671004);
		VRCharacterController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671005);
		VRCharacterController.NativeMethodInfoPtr_GetRadioAndKnifePositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671006);
		VRCharacterController.NativeMethodInfoPtr_SetCrouchAndProneHeight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671007);
		VRCharacterController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671008);
		VRCharacterController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671009);
		VRCharacterController.NativeMethodInfoPtr_OnWeightClassChanged_Private_Void_WeightClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671010);
		VRCharacterController.NativeMethodInfoPtr_MyWarPlayerOnPlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671011);
		VRCharacterController.NativeMethodInfoPtr_SetPlayerHeight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671012);
		VRCharacterController.NativeMethodInfoPtr_GetHeightForIndex_Private_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671013);
		VRCharacterController.NativeMethodInfoPtr_SetRadioAndKnifePosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671014);
		VRCharacterController.NativeMethodInfoPtr_GetCharacterControllerSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671015);
		VRCharacterController.NativeMethodInfoPtr_UpdateMovementProfile_Private_Void_WeightClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671016);
		VRCharacterController.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671017);
		VRCharacterController.NativeMethodInfoPtr_MovePlayerToLocation_Public_Void_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671018);
		VRCharacterController.NativeMethodInfoPtr_DelayedCameraOffset_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671019);
		VRCharacterController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671020);
		VRCharacterController.NativeMethodInfoPtr_get_ManagedLateUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671021);
		VRCharacterController.NativeMethodInfoPtr_set_ManagedLateUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671022);
		VRCharacterController.NativeMethodInfoPtr_OnManagedLateUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671023);
		VRCharacterController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671024);
		VRCharacterController.NativeMethodInfoPtr_FrameToFrameOutOfBoundsExploitCheck_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671025);
		VRCharacterController.NativeMethodInfoPtr_DistanceOutOfBoundsExploitCheck_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671026);
		VRCharacterController.NativeMethodInfoPtr_ExploitLerp_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671027);
		VRCharacterController.NativeMethodInfoPtr_get_ManagedFixedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671028);
		VRCharacterController.NativeMethodInfoPtr_set_ManagedFixedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671029);
		VRCharacterController.NativeMethodInfoPtr_OnManagedFixedUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671030);
		VRCharacterController.NativeMethodInfoPtr_CheckHeightStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671031);
		VRCharacterController.NativeMethodInfoPtr_SatisfiesExternalSprintingConditions_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671032);
		VRCharacterController.NativeMethodInfoPtr_UpdateLocomotion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671033);
		VRCharacterController.NativeMethodInfoPtr_ModifySpeedForSpecOps_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671034);
		VRCharacterController.NativeMethodInfoPtr_ModifySpeedFromWeaponHeight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671035);
		VRCharacterController.NativeMethodInfoPtr_SetWeaponAngle_Public_Void_Single_WeaponType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671036);
		VRCharacterController.NativeMethodInfoPtr_CalculateSpeedFromMovementAndPosture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671037);
		VRCharacterController.NativeMethodInfoPtr_SprintValidation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671038);
		VRCharacterController.NativeMethodInfoPtr_GetPlayersForwardDirection_Private_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671039);
		VRCharacterController.NativeMethodInfoPtr_GetStrafeAmount_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671040);
		VRCharacterController.NativeMethodInfoPtr_GetLocomotionSource_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671041);
		VRCharacterController.NativeMethodInfoPtr_GetForwardMoveDirection_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671042);
		VRCharacterController.NativeMethodInfoPtr_SetVestPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671043);
		VRCharacterController.NativeMethodInfoPtr_MovePlayer_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671044);
		VRCharacterController.NativeMethodInfoPtr_ApplyDeadZone_Private_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671045);
		VRCharacterController.NativeMethodInfoPtr_IsUsingDrone_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671046);
		VRCharacterController.NativeMethodInfoPtr_RestrictRoomScaleMovement_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671047);
		VRCharacterController.NativeMethodInfoPtr_UpdateFallDamage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671048);
		VRCharacterController.NativeMethodInfoPtr_UpdateExploitCheck_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671049);
		VRCharacterController.NativeMethodInfoPtr_OnDownedOrDead_Private_Void_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671050);
		VRCharacterController.NativeMethodInfoPtr_UpdateGhostWalkingCheck_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671051);
		VRCharacterController.NativeMethodInfoPtr_Recenter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671052);
		VRCharacterController.NativeMethodInfoPtr_ResetExploitChecks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671053);
		VRCharacterController.NativeMethodInfoPtr_RespawnReset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671054);
		VRCharacterController.NativeMethodInfoPtr_UserControl_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671055);
		VRCharacterController.NativeMethodInfoPtr_ScaleValue_Public_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671056);
		VRCharacterController.NativeMethodInfoPtr_SetCapsuleCollider_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671057);
		VRCharacterController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, 100671058);
	}

	// Token: 0x060060CE RID: 24782 RVA: 0x00047530 File Offset: 0x00045730
	public VRCharacterController(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700222E RID: 8750
	// (get) Token: 0x060060CF RID: 24783 RVA: 0x001856C0 File Offset: 0x001838C0
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr));
		}
	}

	// Token: 0x1700222F RID: 8751
	// (get) Token: 0x060060D0 RID: 24784 RVA: 0x001856D4 File Offset: 0x001838D4
	// (set) Token: 0x060060D1 RID: 24785 RVA: 0x00185708 File Offset: 0x00183908
	public unsafe VRCameraManager CameraManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_CameraManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VRCameraManager(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_CameraManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002230 RID: 8752
	// (get) Token: 0x060060D2 RID: 24786 RVA: 0x00185730 File Offset: 0x00183930
	// (set) Token: 0x060060D3 RID: 24787 RVA: 0x00185764 File Offset: 0x00183964
	public unsafe CameraCollision m_CameraCollision
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_CameraCollision);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new CameraCollision(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_CameraCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002231 RID: 8753
	// (get) Token: 0x060060D4 RID: 24788 RVA: 0x0018578C File Offset: 0x0018398C
	// (set) Token: 0x060060D5 RID: 24789 RVA: 0x001857C0 File Offset: 0x001839C0
	public unsafe GameObject HeadCheckCollider
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_HeadCheckCollider);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_HeadCheckCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002232 RID: 8754
	// (get) Token: 0x060060D6 RID: 24790 RVA: 0x001857E8 File Offset: 0x001839E8
	// (set) Token: 0x060060D7 RID: 24791 RVA: 0x0018581C File Offset: 0x00183A1C
	public unsafe GameObject HeadCollisionDetector
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_HeadCollisionDetector);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_HeadCollisionDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002233 RID: 8755
	// (get) Token: 0x060060D8 RID: 24792 RVA: 0x00185844 File Offset: 0x00183A44
	// (set) Token: 0x060060D9 RID: 24793 RVA: 0x00185878 File Offset: 0x00183A78
	public unsafe GameObject LeftHandMesh
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_LeftHandMesh);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_LeftHandMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002234 RID: 8756
	// (get) Token: 0x060060DA RID: 24794 RVA: 0x001858A0 File Offset: 0x00183AA0
	// (set) Token: 0x060060DB RID: 24795 RVA: 0x001858D4 File Offset: 0x00183AD4
	public unsafe GameObject RightHandMesh
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_RightHandMesh);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_RightHandMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002235 RID: 8757
	// (get) Token: 0x060060DC RID: 24796 RVA: 0x001858FC File Offset: 0x00183AFC
	// (set) Token: 0x060060DD RID: 24797 RVA: 0x00185930 File Offset: 0x00183B30
	public unsafe WarPlayerScript MyWarplayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_MyWarplayer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WarPlayerScript(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_MyWarplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002236 RID: 8758
	// (get) Token: 0x060060DE RID: 24798 RVA: 0x00185958 File Offset: 0x00183B58
	// (set) Token: 0x060060DF RID: 24799 RVA: 0x0018598C File Offset: 0x00183B8C
	public unsafe GameObject ImageHeightExploit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_ImageHeightExploit);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_ImageHeightExploit), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002237 RID: 8759
	// (get) Token: 0x060060E0 RID: 24800 RVA: 0x001859B4 File Offset: 0x00183BB4
	// (set) Token: 0x060060E1 RID: 24801 RVA: 0x001859E8 File Offset: 0x00183BE8
	public unsafe Transform LocalVestPivot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_LocalVestPivot);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_LocalVestPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002238 RID: 8760
	// (get) Token: 0x060060E2 RID: 24802 RVA: 0x00185A10 File Offset: 0x00183C10
	// (set) Token: 0x060060E3 RID: 24803 RVA: 0x00185A44 File Offset: 0x00183C44
	public unsafe Transform LocalVestBody
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_LocalVestBody);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_LocalVestBody), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002239 RID: 8761
	// (get) Token: 0x060060E4 RID: 24804 RVA: 0x00185A6C File Offset: 0x00183C6C
	// (set) Token: 0x060060E5 RID: 24805 RVA: 0x00185AA0 File Offset: 0x00183CA0
	public unsafe Transform VestHeadSpineTarget
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_VestHeadSpineTarget);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_VestHeadSpineTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700223A RID: 8762
	// (get) Token: 0x060060E6 RID: 24806 RVA: 0x00185AC8 File Offset: 0x00183CC8
	// (set) Token: 0x060060E7 RID: 24807 RVA: 0x00185AFC File Offset: 0x00183CFC
	public unsafe Transform radioRef
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_radioRef);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_radioRef), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700223B RID: 8763
	// (get) Token: 0x060060E8 RID: 24808 RVA: 0x00185B24 File Offset: 0x00183D24
	// (set) Token: 0x060060E9 RID: 24809 RVA: 0x00185B58 File Offset: 0x00183D58
	public unsafe Transform knifeRef
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_knifeRef);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_knifeRef), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700223C RID: 8764
	// (get) Token: 0x060060EA RID: 24810 RVA: 0x00185B80 File Offset: 0x00183D80
	// (set) Token: 0x060060EB RID: 24811 RVA: 0x00185BB4 File Offset: 0x00183DB4
	public unsafe Rigidbody CharacterRigidBody
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_CharacterRigidBody);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Rigidbody(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_CharacterRigidBody), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700223D RID: 8765
	// (get) Token: 0x060060EC RID: 24812 RVA: 0x00185BDC File Offset: 0x00183DDC
	// (set) Token: 0x060060ED RID: 24813 RVA: 0x00185C10 File Offset: 0x00183E10
	public unsafe CapsuleCollider PlayerCapsule
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_PlayerCapsule);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new CapsuleCollider(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_PlayerCapsule), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700223E RID: 8766
	// (get) Token: 0x060060EE RID: 24814 RVA: 0x00185C38 File Offset: 0x00183E38
	// (set) Token: 0x060060EF RID: 24815 RVA: 0x00185C6C File Offset: 0x00183E6C
	public unsafe Transform GunHoldLeft
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_GunHoldLeft);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_GunHoldLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700223F RID: 8767
	// (get) Token: 0x060060F0 RID: 24816 RVA: 0x00185C94 File Offset: 0x00183E94
	// (set) Token: 0x060060F1 RID: 24817 RVA: 0x00185CC8 File Offset: 0x00183EC8
	public unsafe Transform GunHoldRight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_GunHoldRight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_GunHoldRight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002240 RID: 8768
	// (get) Token: 0x060060F2 RID: 24818 RVA: 0x00185CF0 File Offset: 0x00183EF0
	// (set) Token: 0x060060F3 RID: 24819 RVA: 0x00185D24 File Offset: 0x00183F24
	public unsafe Transform IkBody
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_IkBody);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_IkBody), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002241 RID: 8769
	// (get) Token: 0x060060F4 RID: 24820 RVA: 0x00185D4C File Offset: 0x00183F4C
	// (set) Token: 0x060060F5 RID: 24821 RVA: 0x00185D80 File Offset: 0x00183F80
	public unsafe Transform AnimatorTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_AnimatorTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_AnimatorTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002242 RID: 8770
	// (get) Token: 0x060060F6 RID: 24822 RVA: 0x00185DA8 File Offset: 0x00183FA8
	// (set) Token: 0x060060F7 RID: 24823 RVA: 0x00185DD0 File Offset: 0x00183FD0
	public unsafe MovementState _CurrentMovement_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__CurrentMovement_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__CurrentMovement_k__BackingField)) = value;
		}
	}

	// Token: 0x17002243 RID: 8771
	// (get) Token: 0x060060F8 RID: 24824 RVA: 0x00185DF4 File Offset: 0x00183FF4
	// (set) Token: 0x060060F9 RID: 24825 RVA: 0x00185E1C File Offset: 0x0018401C
	public unsafe PostureState _PostureState_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__PostureState_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__PostureState_k__BackingField)) = value;
		}
	}

	// Token: 0x17002244 RID: 8772
	// (get) Token: 0x060060FA RID: 24826 RVA: 0x00185E40 File Offset: 0x00184040
	// (set) Token: 0x060060FB RID: 24827 RVA: 0x00185E68 File Offset: 0x00184068
	public unsafe float _CurrentMovementSpeed_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__CurrentMovementSpeed_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__CurrentMovementSpeed_k__BackingField)) = value;
		}
	}

	// Token: 0x17002245 RID: 8773
	// (get) Token: 0x060060FC RID: 24828 RVA: 0x00185E8C File Offset: 0x0018408C
	// (set) Token: 0x060060FD RID: 24829 RVA: 0x00185EB4 File Offset: 0x001840B4
	public unsafe float _CurrentHeightPercentage_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__CurrentHeightPercentage_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__CurrentHeightPercentage_k__BackingField)) = value;
		}
	}

	// Token: 0x17002246 RID: 8774
	// (get) Token: 0x060060FE RID: 24830 RVA: 0x00185ED8 File Offset: 0x001840D8
	// (set) Token: 0x060060FF RID: 24831 RVA: 0x00185F00 File Offset: 0x00184100
	public unsafe float _SpecOpsSpeedMultiplier_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__SpecOpsSpeedMultiplier_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__SpecOpsSpeedMultiplier_k__BackingField)) = value;
		}
	}

	// Token: 0x17002247 RID: 8775
	// (get) Token: 0x06006100 RID: 24832 RVA: 0x00185F24 File Offset: 0x00184124
	// (set) Token: 0x06006101 RID: 24833 RVA: 0x00185F4C File Offset: 0x0018414C
	public unsafe CasualtyUIState _CurrentCasualtyUIState_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__CurrentCasualtyUIState_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__CurrentCasualtyUIState_k__BackingField)) = value;
		}
	}

	// Token: 0x17002248 RID: 8776
	// (get) Token: 0x06006102 RID: 24834 RVA: 0x00185F70 File Offset: 0x00184170
	// (set) Token: 0x06006103 RID: 24835 RVA: 0x00185F98 File Offset: 0x00184198
	public unsafe bool _GunActive_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__GunActive_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__GunActive_k__BackingField)) = value;
		}
	}

	// Token: 0x17002249 RID: 8777
	// (get) Token: 0x06006104 RID: 24836 RVA: 0x00185FBC File Offset: 0x001841BC
	// (set) Token: 0x06006105 RID: 24837 RVA: 0x00185FE4 File Offset: 0x001841E4
	public unsafe float _WeaponAngle_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__WeaponAngle_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__WeaponAngle_k__BackingField)) = value;
		}
	}

	// Token: 0x1700224A RID: 8778
	// (get) Token: 0x06006106 RID: 24838 RVA: 0x00186008 File Offset: 0x00184208
	// (set) Token: 0x06006107 RID: 24839 RVA: 0x00186030 File Offset: 0x00184230
	public unsafe bool _Touching_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__Touching_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__Touching_k__BackingField)) = value;
		}
	}

	// Token: 0x1700224B RID: 8779
	// (get) Token: 0x06006108 RID: 24840 RVA: 0x00186054 File Offset: 0x00184254
	// (set) Token: 0x06006109 RID: 24841 RVA: 0x0018607C File Offset: 0x0018427C
	public unsafe bool _AllowedExploitCheck_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__AllowedExploitCheck_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__AllowedExploitCheck_k__BackingField)) = value;
		}
	}

	// Token: 0x1700224C RID: 8780
	// (get) Token: 0x0600610A RID: 24842 RVA: 0x001860A0 File Offset: 0x001842A0
	// (set) Token: 0x0600610B RID: 24843 RVA: 0x001860D2 File Offset: 0x001842D2
	public Nullable<float> _HeightWhenFell_k__BackingField
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__HeightWhenFell_k__BackingField);
			return new Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__HeightWhenFell_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x1700224D RID: 8781
	// (get) Token: 0x0600610C RID: 24844 RVA: 0x00186108 File Offset: 0x00184308
	// (set) Token: 0x0600610D RID: 24845 RVA: 0x0018613C File Offset: 0x0018433C
	public unsafe Transform _cameraRig
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__cameraRig);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__cameraRig), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700224E RID: 8782
	// (get) Token: 0x0600610E RID: 24846 RVA: 0x00186164 File Offset: 0x00184364
	// (set) Token: 0x0600610F RID: 24847 RVA: 0x00186198 File Offset: 0x00184398
	public unsafe Camera _vrCam
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__vrCam);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Camera(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__vrCam), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700224F RID: 8783
	// (get) Token: 0x06006110 RID: 24848 RVA: 0x001861C0 File Offset: 0x001843C0
	// (set) Token: 0x06006111 RID: 24849 RVA: 0x001861F4 File Offset: 0x001843F4
	public unsafe CharacterController _characterController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__characterController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new CharacterController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__characterController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002250 RID: 8784
	// (get) Token: 0x06006112 RID: 24850 RVA: 0x0018621C File Offset: 0x0018441C
	// (set) Token: 0x06006113 RID: 24851 RVA: 0x00186244 File Offset: 0x00184444
	public unsafe float lastClickTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_lastClickTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_lastClickTime)) = value;
		}
	}

	// Token: 0x17002251 RID: 8785
	// (get) Token: 0x06006114 RID: 24852 RVA: 0x00186268 File Offset: 0x00184468
	// (set) Token: 0x06006115 RID: 24853 RVA: 0x00186290 File Offset: 0x00184490
	public unsafe bool doubleclicked
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_doubleclicked);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_doubleclicked)) = value;
		}
	}

	// Token: 0x17002252 RID: 8786
	// (get) Token: 0x06006116 RID: 24854 RVA: 0x001862B4 File Offset: 0x001844B4
	// (set) Token: 0x06006117 RID: 24855 RVA: 0x001862DC File Offset: 0x001844DC
	public unsafe bool isUpdating
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_isUpdating);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_isUpdating)) = value;
		}
	}

	// Token: 0x17002253 RID: 8787
	// (get) Token: 0x06006118 RID: 24856 RVA: 0x00186300 File Offset: 0x00184500
	// (set) Token: 0x06006119 RID: 24857 RVA: 0x00186328 File Offset: 0x00184528
	public unsafe float OriginalLocalVestHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_OriginalLocalVestHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_OriginalLocalVestHeight)) = value;
		}
	}

	// Token: 0x17002254 RID: 8788
	// (get) Token: 0x0600611A RID: 24858 RVA: 0x0018634C File Offset: 0x0018454C
	// (set) Token: 0x0600611B RID: 24859 RVA: 0x00186374 File Offset: 0x00184574
	public unsafe bool isUsingGunStock
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_isUsingGunStock);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_isUsingGunStock)) = value;
		}
	}

	// Token: 0x17002255 RID: 8789
	// (get) Token: 0x0600611C RID: 24860 RVA: 0x00186398 File Offset: 0x00184598
	// (set) Token: 0x0600611D RID: 24861 RVA: 0x001863C0 File Offset: 0x001845C0
	public unsafe float HeightOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_HeightOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_HeightOffset)) = value;
		}
	}

	// Token: 0x17002256 RID: 8790
	// (get) Token: 0x0600611E RID: 24862 RVA: 0x001863E4 File Offset: 0x001845E4
	// (set) Token: 0x0600611F RID: 24863 RVA: 0x0018640C File Offset: 0x0018460C
	public unsafe float heightInMeters
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_heightInMeters);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_heightInMeters)) = value;
		}
	}

	// Token: 0x17002257 RID: 8791
	// (get) Token: 0x06006120 RID: 24864 RVA: 0x00186430 File Offset: 0x00184630
	// (set) Token: 0x06006121 RID: 24865 RVA: 0x00186458 File Offset: 0x00184658
	public unsafe bool useSinglePressSprint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_useSinglePressSprint);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_useSinglePressSprint)) = value;
		}
	}

	// Token: 0x17002258 RID: 8792
	// (get) Token: 0x06006122 RID: 24866 RVA: 0x0018647C File Offset: 0x0018467C
	// (set) Token: 0x06006123 RID: 24867 RVA: 0x001864A4 File Offset: 0x001846A4
	public unsafe bool potentialHeightExploit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_potentialHeightExploit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_potentialHeightExploit)) = value;
		}
	}

	// Token: 0x17002259 RID: 8793
	// (get) Token: 0x06006124 RID: 24868 RVA: 0x001864C8 File Offset: 0x001846C8
	// (set) Token: 0x06006125 RID: 24869 RVA: 0x001864F0 File Offset: 0x001846F0
	public unsafe bool _isInsideSomething
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__isInsideSomething);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__isInsideSomething)) = value;
		}
	}

	// Token: 0x1700225A RID: 8794
	// (get) Token: 0x06006126 RID: 24870 RVA: 0x00186514 File Offset: 0x00184714
	// (set) Token: 0x06006127 RID: 24871 RVA: 0x0018653C File Offset: 0x0018473C
	public unsafe bool potentialUndergroundExploitCheck
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_potentialUndergroundExploitCheck);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_potentialUndergroundExploitCheck)) = value;
		}
	}

	// Token: 0x1700225B RID: 8795
	// (get) Token: 0x06006128 RID: 24872 RVA: 0x00186560 File Offset: 0x00184760
	// (set) Token: 0x06006129 RID: 24873 RVA: 0x00186588 File Offset: 0x00184788
	public unsafe float moveSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_moveSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_moveSpeed)) = value;
		}
	}

	// Token: 0x1700225C RID: 8796
	// (get) Token: 0x0600612A RID: 24874 RVA: 0x001865AC File Offset: 0x001847AC
	// (set) Token: 0x0600612B RID: 24875 RVA: 0x001865D4 File Offset: 0x001847D4
	public unsafe bool isMovementLocked
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_isMovementLocked);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_isMovementLocked)) = value;
		}
	}

	// Token: 0x1700225D RID: 8797
	// (get) Token: 0x0600612C RID: 24876 RVA: 0x001865F8 File Offset: 0x001847F8
	// (set) Token: 0x0600612D RID: 24877 RVA: 0x00186620 File Offset: 0x00184820
	public unsafe bool wasGrounded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_wasGrounded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_wasGrounded)) = value;
		}
	}

	// Token: 0x1700225E RID: 8798
	// (get) Token: 0x0600612E RID: 24878 RVA: 0x00186644 File Offset: 0x00184844
	// (set) Token: 0x0600612F RID: 24879 RVA: 0x0018666C File Offset: 0x0018486C
	public unsafe Vector3 maxRoomSizeForwards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_maxRoomSizeForwards);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_maxRoomSizeForwards)) = value;
		}
	}

	// Token: 0x1700225F RID: 8799
	// (get) Token: 0x06006130 RID: 24880 RVA: 0x00186690 File Offset: 0x00184890
	// (set) Token: 0x06006131 RID: 24881 RVA: 0x001866B8 File Offset: 0x001848B8
	public unsafe Vector3 maxRoomSizeBackwards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_maxRoomSizeBackwards);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_maxRoomSizeBackwards)) = value;
		}
	}

	// Token: 0x17002260 RID: 8800
	// (get) Token: 0x06006132 RID: 24882 RVA: 0x001866DC File Offset: 0x001848DC
	// (set) Token: 0x06006133 RID: 24883 RVA: 0x00186704 File Offset: 0x00184904
	public unsafe float exploitCheck
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_exploitCheck);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_exploitCheck)) = value;
		}
	}

	// Token: 0x17002261 RID: 8801
	// (get) Token: 0x06006134 RID: 24884 RVA: 0x00186728 File Offset: 0x00184928
	// (set) Token: 0x06006135 RID: 24885 RVA: 0x0018675A File Offset: 0x0018495A
	public Nullable<Vector3> previousHeadPosition
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_previousHeadPosition);
			return new Nullable<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_previousHeadPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17002262 RID: 8802
	// (get) Token: 0x06006136 RID: 24886 RVA: 0x00186790 File Offset: 0x00184990
	// (set) Token: 0x06006137 RID: 24887 RVA: 0x001867C2 File Offset: 0x001849C2
	public Nullable<Vector3> previousLeftHandPosition
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_previousLeftHandPosition);
			return new Nullable<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_previousLeftHandPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17002263 RID: 8803
	// (get) Token: 0x06006138 RID: 24888 RVA: 0x001867F8 File Offset: 0x001849F8
	// (set) Token: 0x06006139 RID: 24889 RVA: 0x0018682A File Offset: 0x00184A2A
	public Nullable<Vector3> previousRightHandPosition
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_previousRightHandPosition);
			return new Nullable<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_previousRightHandPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17002264 RID: 8804
	// (get) Token: 0x0600613A RID: 24890 RVA: 0x00186860 File Offset: 0x00184A60
	// (set) Token: 0x0600613B RID: 24891 RVA: 0x00186892 File Offset: 0x00184A92
	public ObscuredFloat teleportAllowance
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_teleportAllowance);
			return new ObscuredFloat(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_teleportAllowance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17002265 RID: 8805
	// (get) Token: 0x0600613C RID: 24892 RVA: 0x001868C8 File Offset: 0x00184AC8
	// (set) Token: 0x0600613D RID: 24893 RVA: 0x001868F0 File Offset: 0x00184AF0
	public unsafe Vector3 _velocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__velocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__velocity)) = value;
		}
	}

	// Token: 0x17002266 RID: 8806
	// (get) Token: 0x0600613E RID: 24894 RVA: 0x00186914 File Offset: 0x00184B14
	// (set) Token: 0x0600613F RID: 24895 RVA: 0x0018693C File Offset: 0x00184B3C
	public unsafe Vector3 lastPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_lastPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_lastPosition)) = value;
		}
	}

	// Token: 0x17002267 RID: 8807
	// (get) Token: 0x06006140 RID: 24896 RVA: 0x00186960 File Offset: 0x00184B60
	// (set) Token: 0x06006141 RID: 24897 RVA: 0x00186992 File Offset: 0x00184B92
	public ObscuredFloat maxVelocity
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_maxVelocity);
			return new ObscuredFloat(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_maxVelocity), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ObscuredFloat>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17002268 RID: 8808
	// (get) Token: 0x06006142 RID: 24898 RVA: 0x001869C8 File Offset: 0x00184BC8
	// (set) Token: 0x06006143 RID: 24899 RVA: 0x001869FC File Offset: 0x00184BFC
	public unsafe OnwardPhotonPlayer CasualtyUIInfractionPlayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_CasualtyUIInfractionPlayer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new OnwardPhotonPlayer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_CasualtyUIInfractionPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002269 RID: 8809
	// (get) Token: 0x06006144 RID: 24900 RVA: 0x00186A24 File Offset: 0x00184C24
	// (set) Token: 0x06006145 RID: 24901 RVA: 0x00186A4C File Offset: 0x00184C4C
	public unsafe bool _applyingInput
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__applyingInput);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__applyingInput)) = value;
		}
	}

	// Token: 0x1700226A RID: 8810
	// (get) Token: 0x06006146 RID: 24902 RVA: 0x00186A70 File Offset: 0x00184C70
	// (set) Token: 0x06006147 RID: 24903 RVA: 0x00186A98 File Offset: 0x00184C98
	public unsafe Vector3 spawnLocation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_spawnLocation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_spawnLocation)) = value;
		}
	}

	// Token: 0x1700226B RID: 8811
	// (get) Token: 0x06006148 RID: 24904 RVA: 0x00186ABC File Offset: 0x00184CBC
	// (set) Token: 0x06006149 RID: 24905 RVA: 0x00186AE4 File Offset: 0x00184CE4
	public unsafe Quaternion spawnRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_spawnRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_spawnRotation)) = value;
		}
	}

	// Token: 0x1700226C RID: 8812
	// (get) Token: 0x0600614A RID: 24906 RVA: 0x00186B08 File Offset: 0x00184D08
	// (set) Token: 0x0600614B RID: 24907 RVA: 0x00186B30 File Offset: 0x00184D30
	public unsafe bool settingSpawnPoint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_settingSpawnPoint);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_settingSpawnPoint)) = value;
		}
	}

	// Token: 0x1700226D RID: 8813
	// (get) Token: 0x0600614C RID: 24908 RVA: 0x00186B54 File Offset: 0x00184D54
	// (set) Token: 0x0600614D RID: 24909 RVA: 0x00186B88 File Offset: 0x00184D88
	public unsafe Transform _thisTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__thisTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__thisTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700226E RID: 8814
	// (get) Token: 0x0600614E RID: 24910 RVA: 0x00186BB0 File Offset: 0x00184DB0
	// (set) Token: 0x0600614F RID: 24911 RVA: 0x00186BE4 File Offset: 0x00184DE4
	public unsafe Transform _headCollisionDetectorTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__headCollisionDetectorTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__headCollisionDetectorTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700226F RID: 8815
	// (get) Token: 0x06006150 RID: 24912 RVA: 0x00186C0C File Offset: 0x00184E0C
	// (set) Token: 0x06006151 RID: 24913 RVA: 0x00186C40 File Offset: 0x00184E40
	public unsafe Transform _headCharacterControllerTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__headCharacterControllerTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__headCharacterControllerTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002270 RID: 8816
	// (get) Token: 0x06006152 RID: 24914 RVA: 0x00186C68 File Offset: 0x00184E68
	// (set) Token: 0x06006153 RID: 24915 RVA: 0x00186C90 File Offset: 0x00184E90
	public unsafe Vector3 deathFeetPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_deathFeetPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_deathFeetPosition)) = value;
		}
	}

	// Token: 0x17002271 RID: 8817
	// (get) Token: 0x06006154 RID: 24916 RVA: 0x00186CB4 File Offset: 0x00184EB4
	// (set) Token: 0x06006155 RID: 24917 RVA: 0x00186CDC File Offset: 0x00184EDC
	public unsafe Quaternion deathHeadRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_deathHeadRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_deathHeadRotation)) = value;
		}
	}

	// Token: 0x17002272 RID: 8818
	// (get) Token: 0x06006156 RID: 24918 RVA: 0x00186D00 File Offset: 0x00184F00
	// (set) Token: 0x06006157 RID: 24919 RVA: 0x00186D28 File Offset: 0x00184F28
	public unsafe Vector3 m_prevRoomScalePos
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_prevRoomScalePos);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_prevRoomScalePos)) = value;
		}
	}

	// Token: 0x17002273 RID: 8819
	// (get) Token: 0x06006158 RID: 24920 RVA: 0x00186D4C File Offset: 0x00184F4C
	// (set) Token: 0x06006159 RID: 24921 RVA: 0x00186D74 File Offset: 0x00184F74
	public unsafe Vector3 m_roomScaleVelocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_roomScaleVelocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_roomScaleVelocity)) = value;
		}
	}

	// Token: 0x17002274 RID: 8820
	// (get) Token: 0x0600615A RID: 24922 RVA: 0x00186D98 File Offset: 0x00184F98
	// (set) Token: 0x0600615B RID: 24923 RVA: 0x00186DC0 File Offset: 0x00184FC0
	public unsafe Vector3 m_lastCamPos
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_lastCamPos);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_lastCamPos)) = value;
		}
	}

	// Token: 0x17002275 RID: 8821
	// (get) Token: 0x0600615C RID: 24924 RVA: 0x00186DE4 File Offset: 0x00184FE4
	// (set) Token: 0x0600615D RID: 24925 RVA: 0x00186E0C File Offset: 0x0018500C
	public unsafe float _strafeAmount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__strafeAmount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__strafeAmount)) = value;
		}
	}

	// Token: 0x17002276 RID: 8822
	// (get) Token: 0x0600615E RID: 24926 RVA: 0x00186E30 File Offset: 0x00185030
	// (set) Token: 0x0600615F RID: 24927 RVA: 0x00186E58 File Offset: 0x00185058
	public unsafe Vector3 _forwardMoveDirection
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__forwardMoveDirection);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__forwardMoveDirection)) = value;
		}
	}

	// Token: 0x17002277 RID: 8823
	// (get) Token: 0x06006160 RID: 24928 RVA: 0x00186E7C File Offset: 0x0018507C
	// (set) Token: 0x06006161 RID: 24929 RVA: 0x00186EA4 File Offset: 0x001850A4
	public unsafe Vector3 _playerSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__playerSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__playerSpeed)) = value;
		}
	}

	// Token: 0x17002278 RID: 8824
	// (get) Token: 0x06006162 RID: 24930 RVA: 0x00186EC8 File Offset: 0x001850C8
	// (set) Token: 0x06006163 RID: 24931 RVA: 0x00186EFC File Offset: 0x001850FC
	public unsafe WeightMovementData _weightMovementData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__weightMovementData);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WeightMovementData(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__weightMovementData), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002279 RID: 8825
	// (get) Token: 0x06006164 RID: 24932 RVA: 0x00186F24 File Offset: 0x00185124
	// (set) Token: 0x06006165 RID: 24933 RVA: 0x00186F4C File Offset: 0x0018514C
	public unsafe float _speedModifier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__speedModifier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__speedModifier)) = value;
		}
	}

	// Token: 0x1700227A RID: 8826
	// (get) Token: 0x06006166 RID: 24934 RVA: 0x00186F70 File Offset: 0x00185170
	// (set) Token: 0x06006167 RID: 24935 RVA: 0x00186FA4 File Offset: 0x001851A4
	public unsafe VRPlayerRotation VRRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_VRRotation);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VRPlayerRotation(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_VRRotation), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700227B RID: 8827
	// (get) Token: 0x06006168 RID: 24936 RVA: 0x00186FCC File Offset: 0x001851CC
	// (set) Token: 0x06006169 RID: 24937 RVA: 0x00186FF4 File Offset: 0x001851F4
	public unsafe LocomotionMode m_locomotionMode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_locomotionMode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_locomotionMode)) = value;
		}
	}

	// Token: 0x1700227C RID: 8828
	// (get) Token: 0x0600616A RID: 24938 RVA: 0x00187018 File Offset: 0x00185218
	// (set) Token: 0x0600616B RID: 24939 RVA: 0x00187040 File Offset: 0x00185240
	public unsafe GunstockMode m_gunStockMode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_gunStockMode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_gunStockMode)) = value;
		}
	}

	// Token: 0x1700227D RID: 8829
	// (get) Token: 0x0600616C RID: 24940 RVA: 0x00187064 File Offset: 0x00185264
	// (set) Token: 0x0600616D RID: 24941 RVA: 0x0018708C File Offset: 0x0018528C
	public unsafe bool m_useRadioRightShoulder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_useRadioRightShoulder);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_m_useRadioRightShoulder)) = value;
		}
	}

	// Token: 0x1700227E RID: 8830
	// (get) Token: 0x0600616E RID: 24942 RVA: 0x001870B0 File Offset: 0x001852B0
	// (set) Token: 0x0600616F RID: 24943 RVA: 0x001870D8 File Offset: 0x001852D8
	public unsafe float ProneHeightFraction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_ProneHeightFraction);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_ProneHeightFraction)) = value;
		}
	}

	// Token: 0x1700227F RID: 8831
	// (get) Token: 0x06006170 RID: 24944 RVA: 0x001870FC File Offset: 0x001852FC
	// (set) Token: 0x06006171 RID: 24945 RVA: 0x00187124 File Offset: 0x00185324
	public unsafe float CrouchHeightFraction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_CrouchHeightFraction);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_CrouchHeightFraction)) = value;
		}
	}

	// Token: 0x17002280 RID: 8832
	// (get) Token: 0x06006172 RID: 24946 RVA: 0x00187148 File Offset: 0x00185348
	// (set) Token: 0x06006173 RID: 24947 RVA: 0x00187170 File Offset: 0x00185370
	public unsafe float SprintingMinHeightFraction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_SprintingMinHeightFraction);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_SprintingMinHeightFraction)) = value;
		}
	}

	// Token: 0x17002281 RID: 8833
	// (get) Token: 0x06006174 RID: 24948 RVA: 0x00187194 File Offset: 0x00185394
	// (set) Token: 0x06006175 RID: 24949 RVA: 0x001871BC File Offset: 0x001853BC
	public unsafe float SprintingMaxHeightFraction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_SprintingMaxHeightFraction);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_SprintingMaxHeightFraction)) = value;
		}
	}

	// Token: 0x17002282 RID: 8834
	// (get) Token: 0x06006176 RID: 24950 RVA: 0x001871E0 File Offset: 0x001853E0
	// (set) Token: 0x06006177 RID: 24951 RVA: 0x00187208 File Offset: 0x00185408
	public unsafe float ProneHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_ProneHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_ProneHeight)) = value;
		}
	}

	// Token: 0x17002283 RID: 8835
	// (get) Token: 0x06006178 RID: 24952 RVA: 0x0018722C File Offset: 0x0018542C
	// (set) Token: 0x06006179 RID: 24953 RVA: 0x00187254 File Offset: 0x00185454
	public unsafe float CrouchingHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_CrouchingHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_CrouchingHeight)) = value;
		}
	}

	// Token: 0x17002284 RID: 8836
	// (get) Token: 0x0600617A RID: 24954 RVA: 0x00187278 File Offset: 0x00185478
	// (set) Token: 0x0600617B RID: 24955 RVA: 0x001872A0 File Offset: 0x001854A0
	public unsafe float MinSprintingHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_MinSprintingHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_MinSprintingHeight)) = value;
		}
	}

	// Token: 0x17002285 RID: 8837
	// (get) Token: 0x0600617C RID: 24956 RVA: 0x001872C4 File Offset: 0x001854C4
	// (set) Token: 0x0600617D RID: 24957 RVA: 0x001872EC File Offset: 0x001854EC
	public unsafe float MaxSprintingHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_MaxSprintingHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_MaxSprintingHeight)) = value;
		}
	}

	// Token: 0x17002286 RID: 8838
	// (get) Token: 0x0600617E RID: 24958 RVA: 0x00187310 File Offset: 0x00185510
	// (set) Token: 0x0600617F RID: 24959 RVA: 0x00187344 File Offset: 0x00185544
	public unsafe AnimationCurve HeightOffsetCurve
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_HeightOffsetCurve);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AnimationCurve(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_HeightOffsetCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002287 RID: 8839
	// (get) Token: 0x06006180 RID: 24960 RVA: 0x0018736C File Offset: 0x0018556C
	// (set) Token: 0x06006181 RID: 24961 RVA: 0x001873A0 File Offset: 0x001855A0
	public unsafe Transform transformCache
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_transformCache);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_transformCache), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002288 RID: 8840
	// (get) Token: 0x06006182 RID: 24962 RVA: 0x001873C8 File Offset: 0x001855C8
	// (set) Token: 0x06006183 RID: 24963 RVA: 0x001873FC File Offset: 0x001855FC
	public unsafe Transform vrCamTransformCache
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_vrCamTransformCache);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_vrCamTransformCache), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002289 RID: 8841
	// (get) Token: 0x06006184 RID: 24964 RVA: 0x00187424 File Offset: 0x00185624
	// (set) Token: 0x06006185 RID: 24965 RVA: 0x00187458 File Offset: 0x00185658
	public unsafe Transform feetTransformCache
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_feetTransformCache);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_feetTransformCache), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700228A RID: 8842
	// (get) Token: 0x06006186 RID: 24966 RVA: 0x00187480 File Offset: 0x00185680
	// (set) Token: 0x06006187 RID: 24967 RVA: 0x001874A8 File Offset: 0x001856A8
	public unsafe Vector3 _RadioLeftPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__RadioLeftPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__RadioLeftPosition)) = value;
		}
	}

	// Token: 0x1700228B RID: 8843
	// (get) Token: 0x06006188 RID: 24968 RVA: 0x001874CC File Offset: 0x001856CC
	// (set) Token: 0x06006189 RID: 24969 RVA: 0x001874F4 File Offset: 0x001856F4
	public unsafe Vector3 _KnifeLeftPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__KnifeLeftPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__KnifeLeftPosition)) = value;
		}
	}

	// Token: 0x1700228C RID: 8844
	// (get) Token: 0x0600618A RID: 24970 RVA: 0x00187518 File Offset: 0x00185718
	// (set) Token: 0x0600618B RID: 24971 RVA: 0x00187540 File Offset: 0x00185740
	public unsafe Vector3 _RadioRightPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__RadioRightPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__RadioRightPosition)) = value;
		}
	}

	// Token: 0x1700228D RID: 8845
	// (get) Token: 0x0600618C RID: 24972 RVA: 0x00187564 File Offset: 0x00185764
	// (set) Token: 0x0600618D RID: 24973 RVA: 0x0018758C File Offset: 0x0018578C
	public unsafe Vector3 _KnifeRightPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__KnifeRightPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__KnifeRightPosition)) = value;
		}
	}

	// Token: 0x1700228E RID: 8846
	// (get) Token: 0x0600618E RID: 24974 RVA: 0x001875B0 File Offset: 0x001857B0
	// (set) Token: 0x0600618F RID: 24975 RVA: 0x001875D8 File Offset: 0x001857D8
	public unsafe bool _isUsingControllerTilt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__isUsingControllerTilt);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__isUsingControllerTilt)) = value;
		}
	}

	// Token: 0x1700228F RID: 8847
	// (get) Token: 0x06006190 RID: 24976 RVA: 0x001875FC File Offset: 0x001857FC
	// (set) Token: 0x06006191 RID: 24977 RVA: 0x00187624 File Offset: 0x00185824
	public unsafe int _playerPrefSetHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__playerPrefSetHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__playerPrefSetHeight)) = value;
		}
	}

	// Token: 0x17002290 RID: 8848
	// (get) Token: 0x06006192 RID: 24978 RVA: 0x00187648 File Offset: 0x00185848
	// (set) Token: 0x06006193 RID: 24979 RVA: 0x00187670 File Offset: 0x00185870
	public unsafe WeaponType _currentWeaponType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__currentWeaponType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__currentWeaponType)) = value;
		}
	}

	// Token: 0x17002291 RID: 8849
	// (get) Token: 0x06006194 RID: 24980 RVA: 0x00187694 File Offset: 0x00185894
	// (set) Token: 0x06006195 RID: 24981 RVA: 0x001876C8 File Offset: 0x001858C8
	public unsafe PlayerBoundsDetector PlayerBoundsDetector
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_PlayerBoundsDetector);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new PlayerBoundsDetector(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_PlayerBoundsDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002292 RID: 8850
	// (get) Token: 0x06006196 RID: 24982 RVA: 0x001876F0 File Offset: 0x001858F0
	// (set) Token: 0x06006197 RID: 24983 RVA: 0x0018770E File Offset: 0x0018590E
	public unsafe static int GHOST_WALK_FRAME_SKIP
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(VRCharacterController.NativeFieldInfoPtr_GHOST_WALK_FRAME_SKIP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VRCharacterController.NativeFieldInfoPtr_GHOST_WALK_FRAME_SKIP, (void*)(&value));
		}
	}

	// Token: 0x17002293 RID: 8851
	// (get) Token: 0x06006198 RID: 24984 RVA: 0x00187720 File Offset: 0x00185920
	// (set) Token: 0x06006199 RID: 24985 RVA: 0x0018773E File Offset: 0x0018593E
	public unsafe static float GHOST_WALK_DISTANCE_SQR
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(VRCharacterController.NativeFieldInfoPtr_GHOST_WALK_DISTANCE_SQR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VRCharacterController.NativeFieldInfoPtr_GHOST_WALK_DISTANCE_SQR, (void*)(&value));
		}
	}

	// Token: 0x17002294 RID: 8852
	// (get) Token: 0x0600619A RID: 24986 RVA: 0x00187750 File Offset: 0x00185950
	// (set) Token: 0x0600619B RID: 24987 RVA: 0x0018776E File Offset: 0x0018596E
	public unsafe static float DOUBLE_CLICK_TIME
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(VRCharacterController.NativeFieldInfoPtr_DOUBLE_CLICK_TIME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VRCharacterController.NativeFieldInfoPtr_DOUBLE_CLICK_TIME, (void*)(&value));
		}
	}

	// Token: 0x17002295 RID: 8853
	// (get) Token: 0x0600619C RID: 24988 RVA: 0x00187780 File Offset: 0x00185980
	// (set) Token: 0x0600619D RID: 24989 RVA: 0x0018779E File Offset: 0x0018599E
	public unsafe static float DAMAGE_PER_METER
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(VRCharacterController.NativeFieldInfoPtr_DAMAGE_PER_METER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VRCharacterController.NativeFieldInfoPtr_DAMAGE_PER_METER, (void*)(&value));
		}
	}

	// Token: 0x17002296 RID: 8854
	// (get) Token: 0x0600619E RID: 24990 RVA: 0x001877B0 File Offset: 0x001859B0
	// (set) Token: 0x0600619F RID: 24991 RVA: 0x001877CE File Offset: 0x001859CE
	public unsafe static float ALWAYS_SAFE_HEIGHT
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(VRCharacterController.NativeFieldInfoPtr_ALWAYS_SAFE_HEIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VRCharacterController.NativeFieldInfoPtr_ALWAYS_SAFE_HEIGHT, (void*)(&value));
		}
	}

	// Token: 0x17002297 RID: 8855
	// (get) Token: 0x060061A0 RID: 24992 RVA: 0x001877E0 File Offset: 0x001859E0
	// (set) Token: 0x060061A1 RID: 24993 RVA: 0x00187812 File Offset: 0x00185A12
	public Nullable<Vector3> LastPos
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_LastPos);
			return new Nullable<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_LastPos), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17002298 RID: 8856
	// (get) Token: 0x060061A2 RID: 24994 RVA: 0x00187848 File Offset: 0x00185A48
	// (set) Token: 0x060061A3 RID: 24995 RVA: 0x00187870 File Offset: 0x00185A70
	public unsafe Vector3 MinPlayerScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_MinPlayerScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_MinPlayerScale)) = value;
		}
	}

	// Token: 0x17002299 RID: 8857
	// (get) Token: 0x060061A4 RID: 24996 RVA: 0x00187894 File Offset: 0x00185A94
	// (set) Token: 0x060061A5 RID: 24997 RVA: 0x001878BC File Offset: 0x00185ABC
	public unsafe Vector3 MaxPlayerScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_MaxPlayerScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_MaxPlayerScale)) = value;
		}
	}

	// Token: 0x1700229A RID: 8858
	// (get) Token: 0x060061A6 RID: 24998 RVA: 0x001878E0 File Offset: 0x00185AE0
	// (set) Token: 0x060061A7 RID: 24999 RVA: 0x00187914 File Offset: 0x00185B14
	public unsafe List<Vector3> Scales
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_Scales);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<Vector3>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_Scales), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700229B RID: 8859
	// (get) Token: 0x060061A8 RID: 25000 RVA: 0x0018793C File Offset: 0x00185B3C
	// (set) Token: 0x060061A9 RID: 25001 RVA: 0x0018795A File Offset: 0x00185B5A
	public unsafe static Vector3 LowestScaleVector
	{
		get
		{
			Vector3 result;
			IL2CPP.il2cpp_field_static_get_value(VRCharacterController.NativeFieldInfoPtr_LowestScaleVector, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VRCharacterController.NativeFieldInfoPtr_LowestScaleVector, (void*)(&value));
		}
	}

	// Token: 0x1700229C RID: 8860
	// (get) Token: 0x060061AA RID: 25002 RVA: 0x0018796C File Offset: 0x00185B6C
	// (set) Token: 0x060061AB RID: 25003 RVA: 0x0018798A File Offset: 0x00185B8A
	public unsafe static Vector3 ScaleIncreasePerInch
	{
		get
		{
			Vector3 result;
			IL2CPP.il2cpp_field_static_get_value(VRCharacterController.NativeFieldInfoPtr_ScaleIncreasePerInch, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VRCharacterController.NativeFieldInfoPtr_ScaleIncreasePerInch, (void*)(&value));
		}
	}

	// Token: 0x1700229D RID: 8861
	// (get) Token: 0x060061AC RID: 25004 RVA: 0x0018799C File Offset: 0x00185B9C
	// (set) Token: 0x060061AD RID: 25005 RVA: 0x001879C4 File Offset: 0x00185BC4
	public unsafe bool DEBUG_exploitCheckLogs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_DEBUG_exploitCheckLogs);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr_DEBUG_exploitCheckLogs)) = value;
		}
	}

	// Token: 0x1700229E RID: 8862
	// (get) Token: 0x060061AE RID: 25006 RVA: 0x001879E8 File Offset: 0x00185BE8
	// (set) Token: 0x060061AF RID: 25007 RVA: 0x00187A10 File Offset: 0x00185C10
	public unsafe bool _ManagedLateUpdateRemoval_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField)) = value;
		}
	}

	// Token: 0x1700229F RID: 8863
	// (get) Token: 0x060061B0 RID: 25008 RVA: 0x00187A34 File Offset: 0x00185C34
	// (set) Token: 0x060061B1 RID: 25009 RVA: 0x00187A5C File Offset: 0x00185C5C
	public unsafe bool _ManagedFixedUpdateRemoval_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__ManagedFixedUpdateRemoval_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController.NativeFieldInfoPtr__ManagedFixedUpdateRemoval_k__BackingField)) = value;
		}
	}

	// Token: 0x04003CF9 RID: 15609
	private static readonly IntPtr NativeFieldInfoPtr_CameraManager;

	// Token: 0x04003CFA RID: 15610
	private static readonly IntPtr NativeFieldInfoPtr_m_CameraCollision;

	// Token: 0x04003CFB RID: 15611
	private static readonly IntPtr NativeFieldInfoPtr_HeadCheckCollider;

	// Token: 0x04003CFC RID: 15612
	private static readonly IntPtr NativeFieldInfoPtr_HeadCollisionDetector;

	// Token: 0x04003CFD RID: 15613
	private static readonly IntPtr NativeFieldInfoPtr_LeftHandMesh;

	// Token: 0x04003CFE RID: 15614
	private static readonly IntPtr NativeFieldInfoPtr_RightHandMesh;

	// Token: 0x04003CFF RID: 15615
	private static readonly IntPtr NativeFieldInfoPtr_MyWarplayer;

	// Token: 0x04003D00 RID: 15616
	private static readonly IntPtr NativeFieldInfoPtr_ImageHeightExploit;

	// Token: 0x04003D01 RID: 15617
	private static readonly IntPtr NativeFieldInfoPtr_LocalVestPivot;

	// Token: 0x04003D02 RID: 15618
	private static readonly IntPtr NativeFieldInfoPtr_LocalVestBody;

	// Token: 0x04003D03 RID: 15619
	private static readonly IntPtr NativeFieldInfoPtr_VestHeadSpineTarget;

	// Token: 0x04003D04 RID: 15620
	private static readonly IntPtr NativeFieldInfoPtr_radioRef;

	// Token: 0x04003D05 RID: 15621
	private static readonly IntPtr NativeFieldInfoPtr_knifeRef;

	// Token: 0x04003D06 RID: 15622
	private static readonly IntPtr NativeFieldInfoPtr_CharacterRigidBody;

	// Token: 0x04003D07 RID: 15623
	private static readonly IntPtr NativeFieldInfoPtr_PlayerCapsule;

	// Token: 0x04003D08 RID: 15624
	private static readonly IntPtr NativeFieldInfoPtr_GunHoldLeft;

	// Token: 0x04003D09 RID: 15625
	private static readonly IntPtr NativeFieldInfoPtr_GunHoldRight;

	// Token: 0x04003D0A RID: 15626
	private static readonly IntPtr NativeFieldInfoPtr_IkBody;

	// Token: 0x04003D0B RID: 15627
	private static readonly IntPtr NativeFieldInfoPtr_AnimatorTransform;

	// Token: 0x04003D0C RID: 15628
	private static readonly IntPtr NativeFieldInfoPtr__CurrentMovement_k__BackingField;

	// Token: 0x04003D0D RID: 15629
	private static readonly IntPtr NativeFieldInfoPtr__PostureState_k__BackingField;

	// Token: 0x04003D0E RID: 15630
	private static readonly IntPtr NativeFieldInfoPtr__CurrentMovementSpeed_k__BackingField;

	// Token: 0x04003D0F RID: 15631
	private static readonly IntPtr NativeFieldInfoPtr__CurrentHeightPercentage_k__BackingField;

	// Token: 0x04003D10 RID: 15632
	private static readonly IntPtr NativeFieldInfoPtr__SpecOpsSpeedMultiplier_k__BackingField;

	// Token: 0x04003D11 RID: 15633
	private static readonly IntPtr NativeFieldInfoPtr__CurrentCasualtyUIState_k__BackingField;

	// Token: 0x04003D12 RID: 15634
	private static readonly IntPtr NativeFieldInfoPtr__GunActive_k__BackingField;

	// Token: 0x04003D13 RID: 15635
	private static readonly IntPtr NativeFieldInfoPtr__WeaponAngle_k__BackingField;

	// Token: 0x04003D14 RID: 15636
	private static readonly IntPtr NativeFieldInfoPtr__Touching_k__BackingField;

	// Token: 0x04003D15 RID: 15637
	private static readonly IntPtr NativeFieldInfoPtr__AllowedExploitCheck_k__BackingField;

	// Token: 0x04003D16 RID: 15638
	private static readonly IntPtr NativeFieldInfoPtr__HeightWhenFell_k__BackingField;

	// Token: 0x04003D17 RID: 15639
	private static readonly IntPtr NativeFieldInfoPtr__cameraRig;

	// Token: 0x04003D18 RID: 15640
	private static readonly IntPtr NativeFieldInfoPtr__vrCam;

	// Token: 0x04003D19 RID: 15641
	private static readonly IntPtr NativeFieldInfoPtr__characterController;

	// Token: 0x04003D1A RID: 15642
	private static readonly IntPtr NativeFieldInfoPtr_lastClickTime;

	// Token: 0x04003D1B RID: 15643
	private static readonly IntPtr NativeFieldInfoPtr_doubleclicked;

	// Token: 0x04003D1C RID: 15644
	private static readonly IntPtr NativeFieldInfoPtr_isUpdating;

	// Token: 0x04003D1D RID: 15645
	private static readonly IntPtr NativeFieldInfoPtr_OriginalLocalVestHeight;

	// Token: 0x04003D1E RID: 15646
	private static readonly IntPtr NativeFieldInfoPtr_isUsingGunStock;

	// Token: 0x04003D1F RID: 15647
	private static readonly IntPtr NativeFieldInfoPtr_HeightOffset;

	// Token: 0x04003D20 RID: 15648
	private static readonly IntPtr NativeFieldInfoPtr_heightInMeters;

	// Token: 0x04003D21 RID: 15649
	private static readonly IntPtr NativeFieldInfoPtr_useSinglePressSprint;

	// Token: 0x04003D22 RID: 15650
	private static readonly IntPtr NativeFieldInfoPtr_potentialHeightExploit;

	// Token: 0x04003D23 RID: 15651
	private static readonly IntPtr NativeFieldInfoPtr__isInsideSomething;

	// Token: 0x04003D24 RID: 15652
	private static readonly IntPtr NativeFieldInfoPtr_potentialUndergroundExploitCheck;

	// Token: 0x04003D25 RID: 15653
	private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;

	// Token: 0x04003D26 RID: 15654
	private static readonly IntPtr NativeFieldInfoPtr_isMovementLocked;

	// Token: 0x04003D27 RID: 15655
	private static readonly IntPtr NativeFieldInfoPtr_wasGrounded;

	// Token: 0x04003D28 RID: 15656
	private static readonly IntPtr NativeFieldInfoPtr_maxRoomSizeForwards;

	// Token: 0x04003D29 RID: 15657
	private static readonly IntPtr NativeFieldInfoPtr_maxRoomSizeBackwards;

	// Token: 0x04003D2A RID: 15658
	private static readonly IntPtr NativeFieldInfoPtr_exploitCheck;

	// Token: 0x04003D2B RID: 15659
	private static readonly IntPtr NativeFieldInfoPtr_previousHeadPosition;

	// Token: 0x04003D2C RID: 15660
	private static readonly IntPtr NativeFieldInfoPtr_previousLeftHandPosition;

	// Token: 0x04003D2D RID: 15661
	private static readonly IntPtr NativeFieldInfoPtr_previousRightHandPosition;

	// Token: 0x04003D2E RID: 15662
	private static readonly IntPtr NativeFieldInfoPtr_teleportAllowance;

	// Token: 0x04003D2F RID: 15663
	private static readonly IntPtr NativeFieldInfoPtr__velocity;

	// Token: 0x04003D30 RID: 15664
	private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

	// Token: 0x04003D31 RID: 15665
	private static readonly IntPtr NativeFieldInfoPtr_maxVelocity;

	// Token: 0x04003D32 RID: 15666
	private static readonly IntPtr NativeFieldInfoPtr_CasualtyUIInfractionPlayer;

	// Token: 0x04003D33 RID: 15667
	private static readonly IntPtr NativeFieldInfoPtr__applyingInput;

	// Token: 0x04003D34 RID: 15668
	private static readonly IntPtr NativeFieldInfoPtr_spawnLocation;

	// Token: 0x04003D35 RID: 15669
	private static readonly IntPtr NativeFieldInfoPtr_spawnRotation;

	// Token: 0x04003D36 RID: 15670
	private static readonly IntPtr NativeFieldInfoPtr_settingSpawnPoint;

	// Token: 0x04003D37 RID: 15671
	private static readonly IntPtr NativeFieldInfoPtr__thisTransform;

	// Token: 0x04003D38 RID: 15672
	private static readonly IntPtr NativeFieldInfoPtr__headCollisionDetectorTransform;

	// Token: 0x04003D39 RID: 15673
	private static readonly IntPtr NativeFieldInfoPtr__headCharacterControllerTransform;

	// Token: 0x04003D3A RID: 15674
	private static readonly IntPtr NativeFieldInfoPtr_deathFeetPosition;

	// Token: 0x04003D3B RID: 15675
	private static readonly IntPtr NativeFieldInfoPtr_deathHeadRotation;

	// Token: 0x04003D3C RID: 15676
	private static readonly IntPtr NativeFieldInfoPtr_m_prevRoomScalePos;

	// Token: 0x04003D3D RID: 15677
	private static readonly IntPtr NativeFieldInfoPtr_m_roomScaleVelocity;

	// Token: 0x04003D3E RID: 15678
	private static readonly IntPtr NativeFieldInfoPtr_m_lastCamPos;

	// Token: 0x04003D3F RID: 15679
	private static readonly IntPtr NativeFieldInfoPtr__strafeAmount;

	// Token: 0x04003D40 RID: 15680
	private static readonly IntPtr NativeFieldInfoPtr__forwardMoveDirection;

	// Token: 0x04003D41 RID: 15681
	private static readonly IntPtr NativeFieldInfoPtr__playerSpeed;

	// Token: 0x04003D42 RID: 15682
	private static readonly IntPtr NativeFieldInfoPtr__weightMovementData;

	// Token: 0x04003D43 RID: 15683
	private static readonly IntPtr NativeFieldInfoPtr__speedModifier;

	// Token: 0x04003D44 RID: 15684
	private static readonly IntPtr NativeFieldInfoPtr_VRRotation;

	// Token: 0x04003D45 RID: 15685
	private static readonly IntPtr NativeFieldInfoPtr_m_locomotionMode;

	// Token: 0x04003D46 RID: 15686
	private static readonly IntPtr NativeFieldInfoPtr_m_gunStockMode;

	// Token: 0x04003D47 RID: 15687
	private static readonly IntPtr NativeFieldInfoPtr_m_useRadioRightShoulder;

	// Token: 0x04003D48 RID: 15688
	private static readonly IntPtr NativeFieldInfoPtr_ProneHeightFraction;

	// Token: 0x04003D49 RID: 15689
	private static readonly IntPtr NativeFieldInfoPtr_CrouchHeightFraction;

	// Token: 0x04003D4A RID: 15690
	private static readonly IntPtr NativeFieldInfoPtr_SprintingMinHeightFraction;

	// Token: 0x04003D4B RID: 15691
	private static readonly IntPtr NativeFieldInfoPtr_SprintingMaxHeightFraction;

	// Token: 0x04003D4C RID: 15692
	private static readonly IntPtr NativeFieldInfoPtr_ProneHeight;

	// Token: 0x04003D4D RID: 15693
	private static readonly IntPtr NativeFieldInfoPtr_CrouchingHeight;

	// Token: 0x04003D4E RID: 15694
	private static readonly IntPtr NativeFieldInfoPtr_MinSprintingHeight;

	// Token: 0x04003D4F RID: 15695
	private static readonly IntPtr NativeFieldInfoPtr_MaxSprintingHeight;

	// Token: 0x04003D50 RID: 15696
	private static readonly IntPtr NativeFieldInfoPtr_HeightOffsetCurve;

	// Token: 0x04003D51 RID: 15697
	private static readonly IntPtr NativeFieldInfoPtr_transformCache;

	// Token: 0x04003D52 RID: 15698
	private static readonly IntPtr NativeFieldInfoPtr_vrCamTransformCache;

	// Token: 0x04003D53 RID: 15699
	private static readonly IntPtr NativeFieldInfoPtr_feetTransformCache;

	// Token: 0x04003D54 RID: 15700
	private static readonly IntPtr NativeFieldInfoPtr__RadioLeftPosition;

	// Token: 0x04003D55 RID: 15701
	private static readonly IntPtr NativeFieldInfoPtr__KnifeLeftPosition;

	// Token: 0x04003D56 RID: 15702
	private static readonly IntPtr NativeFieldInfoPtr__RadioRightPosition;

	// Token: 0x04003D57 RID: 15703
	private static readonly IntPtr NativeFieldInfoPtr__KnifeRightPosition;

	// Token: 0x04003D58 RID: 15704
	private static readonly IntPtr NativeFieldInfoPtr__isUsingControllerTilt;

	// Token: 0x04003D59 RID: 15705
	private static readonly IntPtr NativeFieldInfoPtr__playerPrefSetHeight;

	// Token: 0x04003D5A RID: 15706
	private static readonly IntPtr NativeFieldInfoPtr__currentWeaponType;

	// Token: 0x04003D5B RID: 15707
	private static readonly IntPtr NativeFieldInfoPtr_PlayerBoundsDetector;

	// Token: 0x04003D5C RID: 15708
	private static readonly IntPtr NativeFieldInfoPtr_GHOST_WALK_FRAME_SKIP;

	// Token: 0x04003D5D RID: 15709
	private static readonly IntPtr NativeFieldInfoPtr_GHOST_WALK_DISTANCE_SQR;

	// Token: 0x04003D5E RID: 15710
	private static readonly IntPtr NativeFieldInfoPtr_DOUBLE_CLICK_TIME;

	// Token: 0x04003D5F RID: 15711
	private static readonly IntPtr NativeFieldInfoPtr_DAMAGE_PER_METER;

	// Token: 0x04003D60 RID: 15712
	private static readonly IntPtr NativeFieldInfoPtr_ALWAYS_SAFE_HEIGHT;

	// Token: 0x04003D61 RID: 15713
	private static readonly IntPtr NativeFieldInfoPtr_LastPos;

	// Token: 0x04003D62 RID: 15714
	private static readonly IntPtr NativeFieldInfoPtr_MinPlayerScale;

	// Token: 0x04003D63 RID: 15715
	private static readonly IntPtr NativeFieldInfoPtr_MaxPlayerScale;

	// Token: 0x04003D64 RID: 15716
	private static readonly IntPtr NativeFieldInfoPtr_Scales;

	// Token: 0x04003D65 RID: 15717
	private static readonly IntPtr NativeFieldInfoPtr_LowestScaleVector;

	// Token: 0x04003D66 RID: 15718
	private static readonly IntPtr NativeFieldInfoPtr_ScaleIncreasePerInch;

	// Token: 0x04003D67 RID: 15719
	private static readonly IntPtr NativeFieldInfoPtr_DEBUG_exploitCheckLogs;

	// Token: 0x04003D68 RID: 15720
	private static readonly IntPtr NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField;

	// Token: 0x04003D69 RID: 15721
	private static readonly IntPtr NativeFieldInfoPtr__ManagedFixedUpdateRemoval_k__BackingField;

	// Token: 0x04003D6A RID: 15722
	private static readonly IntPtr NativeMethodInfoPtr_get_CurrentMovement_Public_get_MovementState_0;

	// Token: 0x04003D6B RID: 15723
	private static readonly IntPtr NativeMethodInfoPtr_set_CurrentMovement_Private_set_Void_MovementState_0;

	// Token: 0x04003D6C RID: 15724
	private static readonly IntPtr NativeMethodInfoPtr_get_PostureState_Public_get_PostureState_0;

	// Token: 0x04003D6D RID: 15725
	private static readonly IntPtr NativeMethodInfoPtr_set_PostureState_Private_set_Void_PostureState_0;

	// Token: 0x04003D6E RID: 15726
	private static readonly IntPtr NativeMethodInfoPtr_get_CurrentMovementSpeed_Public_get_Single_0;

	// Token: 0x04003D6F RID: 15727
	private static readonly IntPtr NativeMethodInfoPtr_set_CurrentMovementSpeed_Private_set_Void_Single_0;

	// Token: 0x04003D70 RID: 15728
	private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHeightPercentage_Public_get_Single_0;

	// Token: 0x04003D71 RID: 15729
	private static readonly IntPtr NativeMethodInfoPtr_set_CurrentHeightPercentage_Private_set_Void_Single_0;

	// Token: 0x04003D72 RID: 15730
	private static readonly IntPtr NativeMethodInfoPtr_get_SpecOpsSpeedMultiplier_Public_get_Single_0;

	// Token: 0x04003D73 RID: 15731
	private static readonly IntPtr NativeMethodInfoPtr_set_SpecOpsSpeedMultiplier_Public_set_Void_Single_0;

	// Token: 0x04003D74 RID: 15732
	private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCasualtyUIState_Public_get_CasualtyUIState_0;

	// Token: 0x04003D75 RID: 15733
	private static readonly IntPtr NativeMethodInfoPtr_set_CurrentCasualtyUIState_Public_set_Void_CasualtyUIState_0;

	// Token: 0x04003D76 RID: 15734
	private static readonly IntPtr NativeMethodInfoPtr_get_GunActive_Public_get_Boolean_0;

	// Token: 0x04003D77 RID: 15735
	private static readonly IntPtr NativeMethodInfoPtr_set_GunActive_Public_set_Void_Boolean_0;

	// Token: 0x04003D78 RID: 15736
	private static readonly IntPtr NativeMethodInfoPtr_get_WeaponAngle_Public_get_Single_0;

	// Token: 0x04003D79 RID: 15737
	private static readonly IntPtr NativeMethodInfoPtr_set_WeaponAngle_Public_set_Void_Single_0;

	// Token: 0x04003D7A RID: 15738
	private static readonly IntPtr NativeMethodInfoPtr_get_Touching_Public_get_Boolean_0;

	// Token: 0x04003D7B RID: 15739
	private static readonly IntPtr NativeMethodInfoPtr_set_Touching_Public_set_Void_Boolean_0;

	// Token: 0x04003D7C RID: 15740
	private static readonly IntPtr NativeMethodInfoPtr_get_AllowedExploitCheck_Public_get_Boolean_0;

	// Token: 0x04003D7D RID: 15741
	private static readonly IntPtr NativeMethodInfoPtr_set_AllowedExploitCheck_Public_set_Void_Boolean_0;

	// Token: 0x04003D7E RID: 15742
	private static readonly IntPtr NativeMethodInfoPtr_get_HeightWhenFell_Public_get_Nullable_1_Single_0;

	// Token: 0x04003D7F RID: 15743
	private static readonly IntPtr NativeMethodInfoPtr_set_HeightWhenFell_Public_set_Void_Nullable_1_Single_0;

	// Token: 0x04003D80 RID: 15744
	private static readonly IntPtr NativeMethodInfoPtr_get_CameraRig_Public_get_Transform_0;

	// Token: 0x04003D81 RID: 15745
	private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0;

	// Token: 0x04003D82 RID: 15746
	private static readonly IntPtr NativeMethodInfoPtr_get_VrCam_Public_get_Camera_0;

	// Token: 0x04003D83 RID: 15747
	private static readonly IntPtr NativeMethodInfoPtr_get_CharacterController_Public_get_CharacterController_0;

	// Token: 0x04003D84 RID: 15748
	private static readonly IntPtr NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0;

	// Token: 0x04003D85 RID: 15749
	private static readonly IntPtr NativeMethodInfoPtr_get_IsCrouching_Public_get_Boolean_0;

	// Token: 0x04003D86 RID: 15750
	private static readonly IntPtr NativeMethodInfoPtr_get_IsProne_Public_get_Boolean_0;

	// Token: 0x04003D87 RID: 15751
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInsideSomething_Public_get_Boolean_0;

	// Token: 0x04003D88 RID: 15752
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04003D89 RID: 15753
	private static readonly IntPtr NativeMethodInfoPtr_GetRadioAndKnifePositions_Private_Void_0;

	// Token: 0x04003D8A RID: 15754
	private static readonly IntPtr NativeMethodInfoPtr_SetCrouchAndProneHeight_Private_Void_0;

	// Token: 0x04003D8B RID: 15755
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04003D8C RID: 15756
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04003D8D RID: 15757
	private static readonly IntPtr NativeMethodInfoPtr_OnWeightClassChanged_Private_Void_WeightClass_0;

	// Token: 0x04003D8E RID: 15758
	private static readonly IntPtr NativeMethodInfoPtr_MyWarPlayerOnPlayerSpawned_Private_Void_0;

	// Token: 0x04003D8F RID: 15759
	private static readonly IntPtr NativeMethodInfoPtr_SetPlayerHeight_Public_Void_0;

	// Token: 0x04003D90 RID: 15760
	private static readonly IntPtr NativeMethodInfoPtr_GetHeightForIndex_Private_Vector3_Int32_0;

	// Token: 0x04003D91 RID: 15761
	private static readonly IntPtr NativeMethodInfoPtr_SetRadioAndKnifePosition_Private_Void_0;

	// Token: 0x04003D92 RID: 15762
	private static readonly IntPtr NativeMethodInfoPtr_GetCharacterControllerSettings_Private_Void_0;

	// Token: 0x04003D93 RID: 15763
	private static readonly IntPtr NativeMethodInfoPtr_UpdateMovementProfile_Private_Void_WeightClass_0;

	// Token: 0x04003D94 RID: 15764
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04003D95 RID: 15765
	private static readonly IntPtr NativeMethodInfoPtr_MovePlayerToLocation_Public_Void_Vector3_Quaternion_Boolean_0;

	// Token: 0x04003D96 RID: 15766
	private static readonly IntPtr NativeMethodInfoPtr_DelayedCameraOffset_Private_IEnumerator_Boolean_0;

	// Token: 0x04003D97 RID: 15767
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04003D98 RID: 15768
	private static readonly IntPtr NativeMethodInfoPtr_get_ManagedLateUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04003D99 RID: 15769
	private static readonly IntPtr NativeMethodInfoPtr_set_ManagedLateUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0;

	// Token: 0x04003D9A RID: 15770
	private static readonly IntPtr NativeMethodInfoPtr_OnManagedLateUpdate_Public_Virtual_Final_New_Void_0;

	// Token: 0x04003D9B RID: 15771
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04003D9C RID: 15772
	private static readonly IntPtr NativeMethodInfoPtr_FrameToFrameOutOfBoundsExploitCheck_Private_Void_0;

	// Token: 0x04003D9D RID: 15773
	private static readonly IntPtr NativeMethodInfoPtr_DistanceOutOfBoundsExploitCheck_Private_Void_0;

	// Token: 0x04003D9E RID: 15774
	private static readonly IntPtr NativeMethodInfoPtr_ExploitLerp_Public_Void_Vector3_Vector3_0;

	// Token: 0x04003D9F RID: 15775
	private static readonly IntPtr NativeMethodInfoPtr_get_ManagedFixedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04003DA0 RID: 15776
	private static readonly IntPtr NativeMethodInfoPtr_set_ManagedFixedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0;

	// Token: 0x04003DA1 RID: 15777
	private static readonly IntPtr NativeMethodInfoPtr_OnManagedFixedUpdate_Public_Virtual_Final_New_Void_0;

	// Token: 0x04003DA2 RID: 15778
	private static readonly IntPtr NativeMethodInfoPtr_CheckHeightStatus_Private_Void_0;

	// Token: 0x04003DA3 RID: 15779
	private static readonly IntPtr NativeMethodInfoPtr_SatisfiesExternalSprintingConditions_Private_Boolean_0;

	// Token: 0x04003DA4 RID: 15780
	private static readonly IntPtr NativeMethodInfoPtr_UpdateLocomotion_Private_Void_0;

	// Token: 0x04003DA5 RID: 15781
	private static readonly IntPtr NativeMethodInfoPtr_ModifySpeedForSpecOps_Private_Void_0;

	// Token: 0x04003DA6 RID: 15782
	private static readonly IntPtr NativeMethodInfoPtr_ModifySpeedFromWeaponHeight_Private_Void_0;

	// Token: 0x04003DA7 RID: 15783
	private static readonly IntPtr NativeMethodInfoPtr_SetWeaponAngle_Public_Void_Single_WeaponType_0;

	// Token: 0x04003DA8 RID: 15784
	private static readonly IntPtr NativeMethodInfoPtr_CalculateSpeedFromMovementAndPosture_Private_Void_0;

	// Token: 0x04003DA9 RID: 15785
	private static readonly IntPtr NativeMethodInfoPtr_SprintValidation_Private_Void_0;

	// Token: 0x04003DAA RID: 15786
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayersForwardDirection_Private_Single_Vector2_0;

	// Token: 0x04003DAB RID: 15787
	private static readonly IntPtr NativeMethodInfoPtr_GetStrafeAmount_Private_Single_Single_0;

	// Token: 0x04003DAC RID: 15788
	private static readonly IntPtr NativeMethodInfoPtr_GetLocomotionSource_Public_Transform_0;

	// Token: 0x04003DAD RID: 15789
	private static readonly IntPtr NativeMethodInfoPtr_GetForwardMoveDirection_Private_Vector3_0;

	// Token: 0x04003DAE RID: 15790
	private static readonly IntPtr NativeMethodInfoPtr_SetVestPosition_Private_Void_0;

	// Token: 0x04003DAF RID: 15791
	private static readonly IntPtr NativeMethodInfoPtr_MovePlayer_Private_Void_Single_0;

	// Token: 0x04003DB0 RID: 15792
	private static readonly IntPtr NativeMethodInfoPtr_ApplyDeadZone_Private_Vector3_Vector3_Single_0;

	// Token: 0x04003DB1 RID: 15793
	private static readonly IntPtr NativeMethodInfoPtr_IsUsingDrone_Private_Boolean_0;

	// Token: 0x04003DB2 RID: 15794
	private static readonly IntPtr NativeMethodInfoPtr_RestrictRoomScaleMovement_Private_Void_Vector3_0;

	// Token: 0x04003DB3 RID: 15795
	private static readonly IntPtr NativeMethodInfoPtr_UpdateFallDamage_Private_Void_0;

	// Token: 0x04003DB4 RID: 15796
	private static readonly IntPtr NativeMethodInfoPtr_UpdateExploitCheck_Private_Void_0;

	// Token: 0x04003DB5 RID: 15797
	private static readonly IntPtr NativeMethodInfoPtr_OnDownedOrDead_Private_Void_DPIPlayer_0;

	// Token: 0x04003DB6 RID: 15798
	private static readonly IntPtr NativeMethodInfoPtr_UpdateGhostWalkingCheck_Private_Void_0;

	// Token: 0x04003DB7 RID: 15799
	private static readonly IntPtr NativeMethodInfoPtr_Recenter_Public_Void_0;

	// Token: 0x04003DB8 RID: 15800
	private static readonly IntPtr NativeMethodInfoPtr_ResetExploitChecks_Public_Void_0;

	// Token: 0x04003DB9 RID: 15801
	private static readonly IntPtr NativeMethodInfoPtr_RespawnReset_Public_Void_0;

	// Token: 0x04003DBA RID: 15802
	private static readonly IntPtr NativeMethodInfoPtr_UserControl_Public_Void_Boolean_0;

	// Token: 0x04003DBB RID: 15803
	private static readonly IntPtr NativeMethodInfoPtr_ScaleValue_Public_Single_Single_Single_Single_Single_Single_0;

	// Token: 0x04003DBC RID: 15804
	private static readonly IntPtr NativeMethodInfoPtr_SetCapsuleCollider_Public_Void_Boolean_0;

	// Token: 0x04003DBD RID: 15805
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020004BE RID: 1214
	[ObfuscatedName("VRCharacterController/<DelayedCameraOffset>d__174")]
	public sealed class _DelayedCameraOffset_d__174 : Il2CppSystem.Object
	{
		// Token: 0x060061B2 RID: 25010 RVA: 0x00187A80 File Offset: 0x00185C80
		[CallerCount(0)]
		public unsafe _DelayedCameraOffset_d__174(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController._DelayedCameraOffset_d__174.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x00187AE0 File Offset: 0x00185CE0
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController._DelayedCameraOffset_d__174.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x00187B24 File Offset: 0x00185D24
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCharacterController._DelayedCameraOffset_d__174.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x060061B5 RID: 25013 RVA: 0x00187B74 File Offset: 0x00185D74
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController._DelayedCameraOffset_d__174.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x00187BCC File Offset: 0x00185DCC
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController._DelayedCameraOffset_d__174.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170022BB RID: 8891
		// (get) Token: 0x060061B7 RID: 25015 RVA: 0x00187C10 File Offset: 0x00185E10
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCharacterController._DelayedCameraOffset_d__174.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x00187C68 File Offset: 0x00185E68
		// Note: this type is marked as 'beforefieldinit'.
		static _DelayedCameraOffset_d__174()
		{
			Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VRCharacterController>.NativeClassPtr, "<DelayedCameraOffset>d__174");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr);
			VRCharacterController._DelayedCameraOffset_d__174.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr, "<>1__state");
			VRCharacterController._DelayedCameraOffset_d__174.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr, "<>2__current");
			VRCharacterController._DelayedCameraOffset_d__174.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr, "<>4__this");
			VRCharacterController._DelayedCameraOffset_d__174.NativeFieldInfoPtr_synchronous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr, "synchronous");
			VRCharacterController._DelayedCameraOffset_d__174.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr, 100671060);
			VRCharacterController._DelayedCameraOffset_d__174.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr, 100671061);
			VRCharacterController._DelayedCameraOffset_d__174.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr, 100671062);
			VRCharacterController._DelayedCameraOffset_d__174.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr, 100671063);
			VRCharacterController._DelayedCameraOffset_d__174.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr, 100671064);
			VRCharacterController._DelayedCameraOffset_d__174.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr, 100671065);
		}

		// Token: 0x060061B9 RID: 25017 RVA: 0x00002988 File Offset: 0x00000B88
		public _DelayedCameraOffset_d__174(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x060061BA RID: 25018 RVA: 0x00187D5B File Offset: 0x00185F5B
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VRCharacterController._DelayedCameraOffset_d__174>.NativeClassPtr));
			}
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x060061BB RID: 25019 RVA: 0x00187D6C File Offset: 0x00185F6C
		// (set) Token: 0x060061BC RID: 25020 RVA: 0x00187D94 File Offset: 0x00185F94
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController._DelayedCameraOffset_d__174.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController._DelayedCameraOffset_d__174.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x060061BD RID: 25021 RVA: 0x00187DB8 File Offset: 0x00185FB8
		// (set) Token: 0x060061BE RID: 25022 RVA: 0x00187DEC File Offset: 0x00185FEC
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController._DelayedCameraOffset_d__174.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController._DelayedCameraOffset_d__174.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x060061BF RID: 25023 RVA: 0x00187E14 File Offset: 0x00186014
		// (set) Token: 0x060061C0 RID: 25024 RVA: 0x00187E48 File Offset: 0x00186048
		public unsafe VRCharacterController __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController._DelayedCameraOffset_d__174.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new VRCharacterController(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController._DelayedCameraOffset_d__174.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x060061C1 RID: 25025 RVA: 0x00187E70 File Offset: 0x00186070
		// (set) Token: 0x060061C2 RID: 25026 RVA: 0x00187E98 File Offset: 0x00186098
		public unsafe bool synchronous
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController._DelayedCameraOffset_d__174.NativeFieldInfoPtr_synchronous);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCharacterController._DelayedCameraOffset_d__174.NativeFieldInfoPtr_synchronous)) = value;
			}
		}

		// Token: 0x04003DBE RID: 15806
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04003DBF RID: 15807
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04003DC0 RID: 15808
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04003DC1 RID: 15809
		private static readonly IntPtr NativeFieldInfoPtr_synchronous;

		// Token: 0x04003DC2 RID: 15810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003DC3 RID: 15811
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003DC4 RID: 15812
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04003DC5 RID: 15813
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003DC6 RID: 15814
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003DC7 RID: 15815
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
