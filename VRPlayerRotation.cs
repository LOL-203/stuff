using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020004BF RID: 1215
public class VRPlayerRotation : MonoBehaviour
{
	// Token: 0x060061C3 RID: 25027 RVA: 0x00187EBC File Offset: 0x001860BC
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRPlayerRotation.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060061C4 RID: 25028 RVA: 0x00187F00 File Offset: 0x00186100
	[CallerCount(0)]
	public unsafe void RefreshRotationSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRPlayerRotation.NativeMethodInfoPtr_RefreshRotationSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060061C5 RID: 25029 RVA: 0x00187F44 File Offset: 0x00186144
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRPlayerRotation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060061C6 RID: 25030 RVA: 0x00187F88 File Offset: 0x00186188
	[CallerCount(0)]
	public unsafe void UpdateRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRPlayerRotation.NativeMethodInfoPtr_UpdateRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060061C7 RID: 25031 RVA: 0x00187FCC File Offset: 0x001861CC
	[CallerCount(0)]
	public unsafe void RotateMe(float angle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref angle;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRPlayerRotation.NativeMethodInfoPtr_RotateMe_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060061C8 RID: 25032 RVA: 0x00188020 File Offset: 0x00186220
	[CallerCount(0)]
	public unsafe VRPlayerRotation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRPlayerRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060061C9 RID: 25033 RVA: 0x0018806C File Offset: 0x0018626C
	// Note: this type is marked as 'beforefieldinit'.
	static VRPlayerRotation()
	{
		Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VRPlayerRotation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr);
		VRPlayerRotation.NativeFieldInfoPtr_CameraManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "CameraManager");
		VRPlayerRotation.NativeFieldInfoPtr_rotateAroundPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "rotateAroundPlayer");
		VRPlayerRotation.NativeFieldInfoPtr_SnapTurnAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "SnapTurnAmount");
		VRPlayerRotation.NativeFieldInfoPtr_SmoothTurnSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "SmoothTurnSpeed");
		VRPlayerRotation.NativeFieldInfoPtr_storedPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "storedPos");
		VRPlayerRotation.NativeFieldInfoPtr_m_CharacterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "m_CharacterController");
		VRPlayerRotation.NativeFieldInfoPtr_m_VRCharacterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "m_VRCharacterController");
		VRPlayerRotation.NativeFieldInfoPtr_SnapTurnAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "SnapTurnAction");
		VRPlayerRotation.NativeFieldInfoPtr_SmoothTurnSpeedBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "SmoothTurnSpeedBase");
		VRPlayerRotation.NativeFieldInfoPtr_canSnapTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "canSnapTurn");
		VRPlayerRotation.NativeFieldInfoPtr_crouchingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "crouchingHeight");
		VRPlayerRotation.NativeFieldInfoPtr_proneHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "proneHeight");
		VRPlayerRotation.NativeFieldInfoPtr_snapDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "snapDelay");
		VRPlayerRotation.NativeFieldInfoPtr_snapCrouchDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "snapCrouchDelay");
		VRPlayerRotation.NativeFieldInfoPtr_snapProneDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "snapProneDelay");
		VRPlayerRotation.NativeFieldInfoPtr_snapCountDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, "snapCountDown");
		VRPlayerRotation.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, 100671066);
		VRPlayerRotation.NativeMethodInfoPtr_RefreshRotationSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, 100671067);
		VRPlayerRotation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, 100671068);
		VRPlayerRotation.NativeMethodInfoPtr_UpdateRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, 100671069);
		VRPlayerRotation.NativeMethodInfoPtr_RotateMe_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, 100671070);
		VRPlayerRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr, 100671071);
	}

	// Token: 0x060061CA RID: 25034 RVA: 0x0000210C File Offset: 0x0000030C
	public VRPlayerRotation(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170022BC RID: 8892
	// (get) Token: 0x060061CB RID: 25035 RVA: 0x00188254 File Offset: 0x00186454
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VRPlayerRotation>.NativeClassPtr));
		}
	}

	// Token: 0x170022BD RID: 8893
	// (get) Token: 0x060061CC RID: 25036 RVA: 0x00188268 File Offset: 0x00186468
	// (set) Token: 0x060061CD RID: 25037 RVA: 0x0018829C File Offset: 0x0018649C
	public unsafe VRCameraManager CameraManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_CameraManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VRCameraManager(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_CameraManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170022BE RID: 8894
	// (get) Token: 0x060061CE RID: 25038 RVA: 0x001882C4 File Offset: 0x001864C4
	// (set) Token: 0x060061CF RID: 25039 RVA: 0x001882EC File Offset: 0x001864EC
	public unsafe bool rotateAroundPlayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_rotateAroundPlayer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_rotateAroundPlayer)) = value;
		}
	}

	// Token: 0x170022BF RID: 8895
	// (get) Token: 0x060061D0 RID: 25040 RVA: 0x00188310 File Offset: 0x00186510
	// (set) Token: 0x060061D1 RID: 25041 RVA: 0x00188344 File Offset: 0x00186544
	public unsafe FloatVariable SnapTurnAmount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_SnapTurnAmount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new FloatVariable(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_SnapTurnAmount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170022C0 RID: 8896
	// (get) Token: 0x060061D2 RID: 25042 RVA: 0x0018836C File Offset: 0x0018656C
	// (set) Token: 0x060061D3 RID: 25043 RVA: 0x001883A0 File Offset: 0x001865A0
	public unsafe FloatVariable SmoothTurnSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_SmoothTurnSpeed);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new FloatVariable(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_SmoothTurnSpeed), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170022C1 RID: 8897
	// (get) Token: 0x060061D4 RID: 25044 RVA: 0x001883C8 File Offset: 0x001865C8
	// (set) Token: 0x060061D5 RID: 25045 RVA: 0x001883F0 File Offset: 0x001865F0
	public unsafe Vector3 storedPos
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_storedPos);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_storedPos)) = value;
		}
	}

	// Token: 0x170022C2 RID: 8898
	// (get) Token: 0x060061D6 RID: 25046 RVA: 0x00188414 File Offset: 0x00186614
	// (set) Token: 0x060061D7 RID: 25047 RVA: 0x00188448 File Offset: 0x00186648
	public unsafe CharacterController m_CharacterController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_m_CharacterController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new CharacterController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_m_CharacterController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170022C3 RID: 8899
	// (get) Token: 0x060061D8 RID: 25048 RVA: 0x00188470 File Offset: 0x00186670
	// (set) Token: 0x060061D9 RID: 25049 RVA: 0x001884A4 File Offset: 0x001866A4
	public unsafe VRCharacterController m_VRCharacterController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_m_VRCharacterController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VRCharacterController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_m_VRCharacterController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170022C4 RID: 8900
	// (get) Token: 0x060061DA RID: 25050 RVA: 0x001884CC File Offset: 0x001866CC
	// (set) Token: 0x060061DB RID: 25051 RVA: 0x001884F7 File Offset: 0x001866F7
	public unsafe static Action SnapTurnAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(VRPlayerRotation.NativeFieldInfoPtr_SnapTurnAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Action(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VRPlayerRotation.NativeFieldInfoPtr_SnapTurnAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170022C5 RID: 8901
	// (get) Token: 0x060061DC RID: 25052 RVA: 0x0018850C File Offset: 0x0018670C
	// (set) Token: 0x060061DD RID: 25053 RVA: 0x00188534 File Offset: 0x00186734
	public unsafe int SmoothTurnSpeedBase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_SmoothTurnSpeedBase);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_SmoothTurnSpeedBase)) = value;
		}
	}

	// Token: 0x170022C6 RID: 8902
	// (get) Token: 0x060061DE RID: 25054 RVA: 0x00188558 File Offset: 0x00186758
	// (set) Token: 0x060061DF RID: 25055 RVA: 0x00188580 File Offset: 0x00186780
	public unsafe bool canSnapTurn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_canSnapTurn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_canSnapTurn)) = value;
		}
	}

	// Token: 0x170022C7 RID: 8903
	// (get) Token: 0x060061E0 RID: 25056 RVA: 0x001885A4 File Offset: 0x001867A4
	// (set) Token: 0x060061E1 RID: 25057 RVA: 0x001885CC File Offset: 0x001867CC
	public unsafe float crouchingHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_crouchingHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_crouchingHeight)) = value;
		}
	}

	// Token: 0x170022C8 RID: 8904
	// (get) Token: 0x060061E2 RID: 25058 RVA: 0x001885F0 File Offset: 0x001867F0
	// (set) Token: 0x060061E3 RID: 25059 RVA: 0x00188618 File Offset: 0x00186818
	public unsafe float proneHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_proneHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_proneHeight)) = value;
		}
	}

	// Token: 0x170022C9 RID: 8905
	// (get) Token: 0x060061E4 RID: 25060 RVA: 0x0018863C File Offset: 0x0018683C
	// (set) Token: 0x060061E5 RID: 25061 RVA: 0x00188664 File Offset: 0x00186864
	public unsafe float snapDelay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_snapDelay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_snapDelay)) = value;
		}
	}

	// Token: 0x170022CA RID: 8906
	// (get) Token: 0x060061E6 RID: 25062 RVA: 0x00188688 File Offset: 0x00186888
	// (set) Token: 0x060061E7 RID: 25063 RVA: 0x001886B0 File Offset: 0x001868B0
	public unsafe float snapCrouchDelay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_snapCrouchDelay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_snapCrouchDelay)) = value;
		}
	}

	// Token: 0x170022CB RID: 8907
	// (get) Token: 0x060061E8 RID: 25064 RVA: 0x001886D4 File Offset: 0x001868D4
	// (set) Token: 0x060061E9 RID: 25065 RVA: 0x001886FC File Offset: 0x001868FC
	public unsafe float snapProneDelay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_snapProneDelay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_snapProneDelay)) = value;
		}
	}

	// Token: 0x170022CC RID: 8908
	// (get) Token: 0x060061EA RID: 25066 RVA: 0x00188720 File Offset: 0x00186920
	// (set) Token: 0x060061EB RID: 25067 RVA: 0x00188748 File Offset: 0x00186948
	public unsafe float snapCountDown
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_snapCountDown);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRPlayerRotation.NativeFieldInfoPtr_snapCountDown)) = value;
		}
	}

	// Token: 0x04003DC8 RID: 15816
	private static readonly IntPtr NativeFieldInfoPtr_CameraManager;

	// Token: 0x04003DC9 RID: 15817
	private static readonly IntPtr NativeFieldInfoPtr_rotateAroundPlayer;

	// Token: 0x04003DCA RID: 15818
	private static readonly IntPtr NativeFieldInfoPtr_SnapTurnAmount;

	// Token: 0x04003DCB RID: 15819
	private static readonly IntPtr NativeFieldInfoPtr_SmoothTurnSpeed;

	// Token: 0x04003DCC RID: 15820
	private static readonly IntPtr NativeFieldInfoPtr_storedPos;

	// Token: 0x04003DCD RID: 15821
	private static readonly IntPtr NativeFieldInfoPtr_m_CharacterController;

	// Token: 0x04003DCE RID: 15822
	private static readonly IntPtr NativeFieldInfoPtr_m_VRCharacterController;

	// Token: 0x04003DCF RID: 15823
	private static readonly IntPtr NativeFieldInfoPtr_SnapTurnAction;

	// Token: 0x04003DD0 RID: 15824
	private static readonly IntPtr NativeFieldInfoPtr_SmoothTurnSpeedBase;

	// Token: 0x04003DD1 RID: 15825
	private static readonly IntPtr NativeFieldInfoPtr_canSnapTurn;

	// Token: 0x04003DD2 RID: 15826
	private static readonly IntPtr NativeFieldInfoPtr_crouchingHeight;

	// Token: 0x04003DD3 RID: 15827
	private static readonly IntPtr NativeFieldInfoPtr_proneHeight;

	// Token: 0x04003DD4 RID: 15828
	private static readonly IntPtr NativeFieldInfoPtr_snapDelay;

	// Token: 0x04003DD5 RID: 15829
	private static readonly IntPtr NativeFieldInfoPtr_snapCrouchDelay;

	// Token: 0x04003DD6 RID: 15830
	private static readonly IntPtr NativeFieldInfoPtr_snapProneDelay;

	// Token: 0x04003DD7 RID: 15831
	private static readonly IntPtr NativeFieldInfoPtr_snapCountDown;

	// Token: 0x04003DD8 RID: 15832
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04003DD9 RID: 15833
	private static readonly IntPtr NativeMethodInfoPtr_RefreshRotationSettings_Private_Void_0;

	// Token: 0x04003DDA RID: 15834
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04003DDB RID: 15835
	private static readonly IntPtr NativeMethodInfoPtr_UpdateRotation_Public_Void_0;

	// Token: 0x04003DDC RID: 15836
	private static readonly IntPtr NativeMethodInfoPtr_RotateMe_Private_Void_Single_0;

	// Token: 0x04003DDD RID: 15837
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
