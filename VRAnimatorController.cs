using System;
using DPI.Networking;
using Il2CppSystem;
using Il2CppSystem.Collections;
using RootMotion.FinalIK;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000317 RID: 791
public class VRAnimatorController : MonoBehaviourDPINetworking
{
	// Token: 0x1700161F RID: 5663
	// (get) Token: 0x06003E2D RID: 15917 RVA: 0x000FB120 File Offset: 0x000F9320
	// (set) Token: 0x06003E2E RID: 15918 RVA: 0x000FB170 File Offset: 0x000F9370
	public unsafe Vector3 velocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x06003E2F RID: 15919 RVA: 0x000FB1C4 File Offset: 0x000F93C4
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06003E30 RID: 15920 RVA: 0x000FB208 File Offset: 0x000F9408
	[CallerCount(0)]
	public unsafe IEnumerator WaitLocomotionLerp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr_WaitLocomotionLerp_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x06003E31 RID: 15921 RVA: 0x000FB260 File Offset: 0x000F9460
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06003E32 RID: 15922 RVA: 0x000FB2A4 File Offset: 0x000F94A4
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x17001620 RID: 5664
	// (get) Token: 0x06003E33 RID: 15923 RVA: 0x000FB2E8 File Offset: 0x000F94E8
	// (set) Token: 0x06003E34 RID: 15924 RVA: 0x000FB338 File Offset: 0x000F9538
	public unsafe bool ManagedLateUpdateRemoval
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr_get_ManagedLateUpdateRemoval_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr_set_ManagedLateUpdateRemoval_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x17001621 RID: 5665
	// (get) Token: 0x06003E35 RID: 15925 RVA: 0x000FB38C File Offset: 0x000F958C
	// (set) Token: 0x06003E36 RID: 15926 RVA: 0x000FB3DC File Offset: 0x000F95DC
	public unsafe bool ManagedUpdateRemoval
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x06003E37 RID: 15927 RVA: 0x000FB430 File Offset: 0x000F9630
	[CallerCount(0)]
	public unsafe void OnManagedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06003E38 RID: 15928 RVA: 0x000FB474 File Offset: 0x000F9674
	[CallerCount(0)]
	public unsafe Vector3 GetVelocityTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr_GetVelocityTarget_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06003E39 RID: 15929 RVA: 0x000FB4C4 File Offset: 0x000F96C4
	[CallerCount(0)]
	public unsafe void SetVestAnimation(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref enable;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr_SetVestAnimation_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06003E3A RID: 15930 RVA: 0x000FB518 File Offset: 0x000F9718
	[CallerCount(0)]
	public unsafe VRAnimatorController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06003E3B RID: 15931 RVA: 0x000FB564 File Offset: 0x000F9764
	// Note: this type is marked as 'beforefieldinit'.
	static VRAnimatorController()
	{
		Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VRAnimatorController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr);
		VRAnimatorController.NativeFieldInfoPtr_characterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "characterController");
		VRAnimatorController.NativeFieldInfoPtr_IkWeightController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "IkWeightController");
		VRAnimatorController.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "cam");
		VRAnimatorController.NativeFieldInfoPtr_smoothAccelerationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "smoothAccelerationTime");
		VRAnimatorController.NativeFieldInfoPtr_linearAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "linearAcceleration");
		VRAnimatorController.NativeFieldInfoPtr_maxViewAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "maxViewAngle");
		VRAnimatorController.NativeFieldInfoPtr_locomotionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "locomotionSpeed");
		VRAnimatorController.NativeFieldInfoPtr_proneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "proneOffset");
		VRAnimatorController.NativeFieldInfoPtr__velocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "<velocity>k__BackingField");
		VRAnimatorController.NativeFieldInfoPtr_m_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "m_Animator");
		VRAnimatorController.NativeFieldInfoPtr_VestAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "VestAnimator");
		VRAnimatorController.NativeFieldInfoPtr_velocityC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "velocityC");
		VRAnimatorController.NativeFieldInfoPtr_playerVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "playerVelocity");
		VRAnimatorController.NativeFieldInfoPtr_playerLastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "playerLastPosition");
		VRAnimatorController.NativeFieldInfoPtr_HeadEffector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "HeadEffector");
		VRAnimatorController.NativeFieldInfoPtr_MyWarPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "MyWarPlayer");
		VRAnimatorController.NativeFieldInfoPtr_VRCharController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "VRCharController");
		VRAnimatorController.NativeFieldInfoPtr_sprintoffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "sprintoffset");
		VRAnimatorController.NativeFieldInfoPtr_DebugVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "DebugVelocity");
		VRAnimatorController.NativeFieldInfoPtr_lerpspeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "lerpspeed");
		VRAnimatorController.NativeFieldInfoPtr_CanReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "CanReset");
		VRAnimatorController.NativeFieldInfoPtr_CanLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "CanLerp");
		VRAnimatorController.NativeFieldInfoPtr_LowerSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "LowerSpine");
		VRAnimatorController.NativeFieldInfoPtr_LerpVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "LerpVelocity");
		VRAnimatorController.NativeFieldInfoPtr_RotationParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "RotationParent");
		VRAnimatorController.NativeFieldInfoPtr_LocalVestAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "LocalVestAnimator");
		VRAnimatorController.NativeFieldInfoPtr_IsProneID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "IsProneID");
		VRAnimatorController.NativeFieldInfoPtr_CrouchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "CrouchID");
		VRAnimatorController.NativeFieldInfoPtr_ForwardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "ForwardID");
		VRAnimatorController.NativeFieldInfoPtr_RightID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "RightID");
		VRAnimatorController.NativeFieldInfoPtr_HeightID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "HeightID");
		VRAnimatorController.NativeFieldInfoPtr_MovementSpeedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "MovementSpeedID");
		VRAnimatorController.NativeFieldInfoPtr_LocalAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "LocalAnimator");
		VRAnimatorController.NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "<ManagedLateUpdateRemoval>k__BackingField");
		VRAnimatorController.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "<ManagedUpdateRemoval>k__BackingField");
		VRAnimatorController.NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668279);
		VRAnimatorController.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668280);
		VRAnimatorController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668281);
		VRAnimatorController.NativeMethodInfoPtr_WaitLocomotionLerp_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668282);
		VRAnimatorController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668283);
		VRAnimatorController.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668284);
		VRAnimatorController.NativeMethodInfoPtr_get_ManagedLateUpdateRemoval_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668285);
		VRAnimatorController.NativeMethodInfoPtr_set_ManagedLateUpdateRemoval_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668286);
		VRAnimatorController.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668287);
		VRAnimatorController.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668288);
		VRAnimatorController.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668289);
		VRAnimatorController.NativeMethodInfoPtr_GetVelocityTarget_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668290);
		VRAnimatorController.NativeMethodInfoPtr_SetVestAnimation_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668291);
		VRAnimatorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, 100668292);
	}

	// Token: 0x06003E3C RID: 15932 RVA: 0x00047530 File Offset: 0x00045730
	public VRAnimatorController(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170015FB RID: 5627
	// (get) Token: 0x06003E3D RID: 15933 RVA: 0x000FB968 File Offset: 0x000F9B68
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr));
		}
	}

	// Token: 0x170015FC RID: 5628
	// (get) Token: 0x06003E3E RID: 15934 RVA: 0x000FB97C File Offset: 0x000F9B7C
	// (set) Token: 0x06003E3F RID: 15935 RVA: 0x000FB9B0 File Offset: 0x000F9BB0
	public unsafe Transform characterController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_characterController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_characterController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170015FD RID: 5629
	// (get) Token: 0x06003E40 RID: 15936 RVA: 0x000FB9D8 File Offset: 0x000F9BD8
	// (set) Token: 0x06003E41 RID: 15937 RVA: 0x000FBA0C File Offset: 0x000F9C0C
	public unsafe IkWeightController IkWeightController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_IkWeightController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new IkWeightController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_IkWeightController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170015FE RID: 5630
	// (get) Token: 0x06003E42 RID: 15938 RVA: 0x000FBA34 File Offset: 0x000F9C34
	// (set) Token: 0x06003E43 RID: 15939 RVA: 0x000FBA68 File Offset: 0x000F9C68
	public unsafe Transform cam
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_cam);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170015FF RID: 5631
	// (get) Token: 0x06003E44 RID: 15940 RVA: 0x000FBA90 File Offset: 0x000F9C90
	// (set) Token: 0x06003E45 RID: 15941 RVA: 0x000FBAB8 File Offset: 0x000F9CB8
	public unsafe float smoothAccelerationTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_smoothAccelerationTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_smoothAccelerationTime)) = value;
		}
	}

	// Token: 0x17001600 RID: 5632
	// (get) Token: 0x06003E46 RID: 15942 RVA: 0x000FBADC File Offset: 0x000F9CDC
	// (set) Token: 0x06003E47 RID: 15943 RVA: 0x000FBB04 File Offset: 0x000F9D04
	public unsafe float linearAcceleration
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_linearAcceleration);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_linearAcceleration)) = value;
		}
	}

	// Token: 0x17001601 RID: 5633
	// (get) Token: 0x06003E48 RID: 15944 RVA: 0x000FBB28 File Offset: 0x000F9D28
	// (set) Token: 0x06003E49 RID: 15945 RVA: 0x000FBB50 File Offset: 0x000F9D50
	public unsafe float maxViewAngle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_maxViewAngle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_maxViewAngle)) = value;
		}
	}

	// Token: 0x17001602 RID: 5634
	// (get) Token: 0x06003E4A RID: 15946 RVA: 0x000FBB74 File Offset: 0x000F9D74
	// (set) Token: 0x06003E4B RID: 15947 RVA: 0x000FBB9C File Offset: 0x000F9D9C
	public unsafe float locomotionSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_locomotionSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_locomotionSpeed)) = value;
		}
	}

	// Token: 0x17001603 RID: 5635
	// (get) Token: 0x06003E4C RID: 15948 RVA: 0x000FBBC0 File Offset: 0x000F9DC0
	// (set) Token: 0x06003E4D RID: 15949 RVA: 0x000FBBE8 File Offset: 0x000F9DE8
	public unsafe float proneOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_proneOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_proneOffset)) = value;
		}
	}

	// Token: 0x17001604 RID: 5636
	// (get) Token: 0x06003E4E RID: 15950 RVA: 0x000FBC0C File Offset: 0x000F9E0C
	// (set) Token: 0x06003E4F RID: 15951 RVA: 0x000FBC34 File Offset: 0x000F9E34
	public unsafe Vector3 _velocity_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr__velocity_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr__velocity_k__BackingField)) = value;
		}
	}

	// Token: 0x17001605 RID: 5637
	// (get) Token: 0x06003E50 RID: 15952 RVA: 0x000FBC58 File Offset: 0x000F9E58
	// (set) Token: 0x06003E51 RID: 15953 RVA: 0x000FBC8C File Offset: 0x000F9E8C
	public unsafe Animator m_Animator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_m_Animator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Animator(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_m_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001606 RID: 5638
	// (get) Token: 0x06003E52 RID: 15954 RVA: 0x000FBCB4 File Offset: 0x000F9EB4
	// (set) Token: 0x06003E53 RID: 15955 RVA: 0x000FBCE8 File Offset: 0x000F9EE8
	public unsafe Animator VestAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_VestAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Animator(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_VestAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001607 RID: 5639
	// (get) Token: 0x06003E54 RID: 15956 RVA: 0x000FBD10 File Offset: 0x000F9F10
	// (set) Token: 0x06003E55 RID: 15957 RVA: 0x000FBD38 File Offset: 0x000F9F38
	public unsafe Vector3 velocityC
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_velocityC);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_velocityC)) = value;
		}
	}

	// Token: 0x17001608 RID: 5640
	// (get) Token: 0x06003E56 RID: 15958 RVA: 0x000FBD5C File Offset: 0x000F9F5C
	// (set) Token: 0x06003E57 RID: 15959 RVA: 0x000FBD84 File Offset: 0x000F9F84
	public unsafe Vector3 playerVelocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_playerVelocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_playerVelocity)) = value;
		}
	}

	// Token: 0x17001609 RID: 5641
	// (get) Token: 0x06003E58 RID: 15960 RVA: 0x000FBDA8 File Offset: 0x000F9FA8
	// (set) Token: 0x06003E59 RID: 15961 RVA: 0x000FBDD0 File Offset: 0x000F9FD0
	public unsafe Vector3 playerLastPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_playerLastPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_playerLastPosition)) = value;
		}
	}

	// Token: 0x1700160A RID: 5642
	// (get) Token: 0x06003E5A RID: 15962 RVA: 0x000FBDF4 File Offset: 0x000F9FF4
	// (set) Token: 0x06003E5B RID: 15963 RVA: 0x000FBE28 File Offset: 0x000FA028
	public unsafe FBBIKHeadEffector HeadEffector
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_HeadEffector);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new FBBIKHeadEffector(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_HeadEffector), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700160B RID: 5643
	// (get) Token: 0x06003E5C RID: 15964 RVA: 0x000FBE50 File Offset: 0x000FA050
	// (set) Token: 0x06003E5D RID: 15965 RVA: 0x000FBE84 File Offset: 0x000FA084
	public unsafe WarPlayerScript MyWarPlayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_MyWarPlayer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WarPlayerScript(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_MyWarPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700160C RID: 5644
	// (get) Token: 0x06003E5E RID: 15966 RVA: 0x000FBEAC File Offset: 0x000FA0AC
	// (set) Token: 0x06003E5F RID: 15967 RVA: 0x000FBEE0 File Offset: 0x000FA0E0
	public unsafe VRCharacterController VRCharController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_VRCharController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VRCharacterController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_VRCharController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700160D RID: 5645
	// (get) Token: 0x06003E60 RID: 15968 RVA: 0x000FBF08 File Offset: 0x000FA108
	// (set) Token: 0x06003E61 RID: 15969 RVA: 0x000FBF30 File Offset: 0x000FA130
	public unsafe float sprintoffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_sprintoffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_sprintoffset)) = value;
		}
	}

	// Token: 0x1700160E RID: 5646
	// (get) Token: 0x06003E62 RID: 15970 RVA: 0x000FBF54 File Offset: 0x000FA154
	// (set) Token: 0x06003E63 RID: 15971 RVA: 0x000FBF7C File Offset: 0x000FA17C
	public unsafe bool DebugVelocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_DebugVelocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_DebugVelocity)) = value;
		}
	}

	// Token: 0x1700160F RID: 5647
	// (get) Token: 0x06003E64 RID: 15972 RVA: 0x000FBFA0 File Offset: 0x000FA1A0
	// (set) Token: 0x06003E65 RID: 15973 RVA: 0x000FBFC8 File Offset: 0x000FA1C8
	public unsafe float lerpspeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_lerpspeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_lerpspeed)) = value;
		}
	}

	// Token: 0x17001610 RID: 5648
	// (get) Token: 0x06003E66 RID: 15974 RVA: 0x000FBFEC File Offset: 0x000FA1EC
	// (set) Token: 0x06003E67 RID: 15975 RVA: 0x000FC014 File Offset: 0x000FA214
	public unsafe bool CanReset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_CanReset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_CanReset)) = value;
		}
	}

	// Token: 0x17001611 RID: 5649
	// (get) Token: 0x06003E68 RID: 15976 RVA: 0x000FC038 File Offset: 0x000FA238
	// (set) Token: 0x06003E69 RID: 15977 RVA: 0x000FC060 File Offset: 0x000FA260
	public unsafe bool CanLerp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_CanLerp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_CanLerp)) = value;
		}
	}

	// Token: 0x17001612 RID: 5650
	// (get) Token: 0x06003E6A RID: 15978 RVA: 0x000FC084 File Offset: 0x000FA284
	// (set) Token: 0x06003E6B RID: 15979 RVA: 0x000FC0B8 File Offset: 0x000FA2B8
	public unsafe Transform LowerSpine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_LowerSpine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_LowerSpine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001613 RID: 5651
	// (get) Token: 0x06003E6C RID: 15980 RVA: 0x000FC0E0 File Offset: 0x000FA2E0
	// (set) Token: 0x06003E6D RID: 15981 RVA: 0x000FC108 File Offset: 0x000FA308
	public unsafe Vector3 LerpVelocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_LerpVelocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_LerpVelocity)) = value;
		}
	}

	// Token: 0x17001614 RID: 5652
	// (get) Token: 0x06003E6E RID: 15982 RVA: 0x000FC12C File Offset: 0x000FA32C
	// (set) Token: 0x06003E6F RID: 15983 RVA: 0x000FC160 File Offset: 0x000FA360
	public unsafe Transform RotationParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_RotationParent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_RotationParent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001615 RID: 5653
	// (get) Token: 0x06003E70 RID: 15984 RVA: 0x000FC188 File Offset: 0x000FA388
	// (set) Token: 0x06003E71 RID: 15985 RVA: 0x000FC1BC File Offset: 0x000FA3BC
	public unsafe Animator LocalVestAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_LocalVestAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Animator(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_LocalVestAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001616 RID: 5654
	// (get) Token: 0x06003E72 RID: 15986 RVA: 0x000FC1E4 File Offset: 0x000FA3E4
	// (set) Token: 0x06003E73 RID: 15987 RVA: 0x000FC20C File Offset: 0x000FA40C
	public unsafe int IsProneID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_IsProneID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_IsProneID)) = value;
		}
	}

	// Token: 0x17001617 RID: 5655
	// (get) Token: 0x06003E74 RID: 15988 RVA: 0x000FC230 File Offset: 0x000FA430
	// (set) Token: 0x06003E75 RID: 15989 RVA: 0x000FC258 File Offset: 0x000FA458
	public unsafe int CrouchID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_CrouchID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_CrouchID)) = value;
		}
	}

	// Token: 0x17001618 RID: 5656
	// (get) Token: 0x06003E76 RID: 15990 RVA: 0x000FC27C File Offset: 0x000FA47C
	// (set) Token: 0x06003E77 RID: 15991 RVA: 0x000FC2A4 File Offset: 0x000FA4A4
	public unsafe int ForwardID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_ForwardID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_ForwardID)) = value;
		}
	}

	// Token: 0x17001619 RID: 5657
	// (get) Token: 0x06003E78 RID: 15992 RVA: 0x000FC2C8 File Offset: 0x000FA4C8
	// (set) Token: 0x06003E79 RID: 15993 RVA: 0x000FC2F0 File Offset: 0x000FA4F0
	public unsafe int RightID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_RightID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_RightID)) = value;
		}
	}

	// Token: 0x1700161A RID: 5658
	// (get) Token: 0x06003E7A RID: 15994 RVA: 0x000FC314 File Offset: 0x000FA514
	// (set) Token: 0x06003E7B RID: 15995 RVA: 0x000FC33C File Offset: 0x000FA53C
	public unsafe int HeightID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_HeightID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_HeightID)) = value;
		}
	}

	// Token: 0x1700161B RID: 5659
	// (get) Token: 0x06003E7C RID: 15996 RVA: 0x000FC360 File Offset: 0x000FA560
	// (set) Token: 0x06003E7D RID: 15997 RVA: 0x000FC388 File Offset: 0x000FA588
	public unsafe int MovementSpeedID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_MovementSpeedID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_MovementSpeedID)) = value;
		}
	}

	// Token: 0x1700161C RID: 5660
	// (get) Token: 0x06003E7E RID: 15998 RVA: 0x000FC3AC File Offset: 0x000FA5AC
	// (set) Token: 0x06003E7F RID: 15999 RVA: 0x000FC3D4 File Offset: 0x000FA5D4
	public unsafe bool LocalAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_LocalAnimator);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr_LocalAnimator)) = value;
		}
	}

	// Token: 0x1700161D RID: 5661
	// (get) Token: 0x06003E80 RID: 16000 RVA: 0x000FC3F8 File Offset: 0x000FA5F8
	// (set) Token: 0x06003E81 RID: 16001 RVA: 0x000FC420 File Offset: 0x000FA620
	public unsafe bool _ManagedLateUpdateRemoval_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField)) = value;
		}
	}

	// Token: 0x1700161E RID: 5662
	// (get) Token: 0x06003E82 RID: 16002 RVA: 0x000FC444 File Offset: 0x000FA644
	// (set) Token: 0x06003E83 RID: 16003 RVA: 0x000FC46C File Offset: 0x000FA66C
	public unsafe bool _ManagedUpdateRemoval_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField)) = value;
		}
	}

	// Token: 0x040027EE RID: 10222
	private static readonly IntPtr NativeFieldInfoPtr_characterController;

	// Token: 0x040027EF RID: 10223
	private static readonly IntPtr NativeFieldInfoPtr_IkWeightController;

	// Token: 0x040027F0 RID: 10224
	private static readonly IntPtr NativeFieldInfoPtr_cam;

	// Token: 0x040027F1 RID: 10225
	private static readonly IntPtr NativeFieldInfoPtr_smoothAccelerationTime;

	// Token: 0x040027F2 RID: 10226
	private static readonly IntPtr NativeFieldInfoPtr_linearAcceleration;

	// Token: 0x040027F3 RID: 10227
	private static readonly IntPtr NativeFieldInfoPtr_maxViewAngle;

	// Token: 0x040027F4 RID: 10228
	private static readonly IntPtr NativeFieldInfoPtr_locomotionSpeed;

	// Token: 0x040027F5 RID: 10229
	private static readonly IntPtr NativeFieldInfoPtr_proneOffset;

	// Token: 0x040027F6 RID: 10230
	private static readonly IntPtr NativeFieldInfoPtr__velocity_k__BackingField;

	// Token: 0x040027F7 RID: 10231
	private static readonly IntPtr NativeFieldInfoPtr_m_Animator;

	// Token: 0x040027F8 RID: 10232
	private static readonly IntPtr NativeFieldInfoPtr_VestAnimator;

	// Token: 0x040027F9 RID: 10233
	private static readonly IntPtr NativeFieldInfoPtr_velocityC;

	// Token: 0x040027FA RID: 10234
	private static readonly IntPtr NativeFieldInfoPtr_playerVelocity;

	// Token: 0x040027FB RID: 10235
	private static readonly IntPtr NativeFieldInfoPtr_playerLastPosition;

	// Token: 0x040027FC RID: 10236
	private static readonly IntPtr NativeFieldInfoPtr_HeadEffector;

	// Token: 0x040027FD RID: 10237
	private static readonly IntPtr NativeFieldInfoPtr_MyWarPlayer;

	// Token: 0x040027FE RID: 10238
	private static readonly IntPtr NativeFieldInfoPtr_VRCharController;

	// Token: 0x040027FF RID: 10239
	private static readonly IntPtr NativeFieldInfoPtr_sprintoffset;

	// Token: 0x04002800 RID: 10240
	private static readonly IntPtr NativeFieldInfoPtr_DebugVelocity;

	// Token: 0x04002801 RID: 10241
	private static readonly IntPtr NativeFieldInfoPtr_lerpspeed;

	// Token: 0x04002802 RID: 10242
	private static readonly IntPtr NativeFieldInfoPtr_CanReset;

	// Token: 0x04002803 RID: 10243
	private static readonly IntPtr NativeFieldInfoPtr_CanLerp;

	// Token: 0x04002804 RID: 10244
	private static readonly IntPtr NativeFieldInfoPtr_LowerSpine;

	// Token: 0x04002805 RID: 10245
	private static readonly IntPtr NativeFieldInfoPtr_LerpVelocity;

	// Token: 0x04002806 RID: 10246
	private static readonly IntPtr NativeFieldInfoPtr_RotationParent;

	// Token: 0x04002807 RID: 10247
	private static readonly IntPtr NativeFieldInfoPtr_LocalVestAnimator;

	// Token: 0x04002808 RID: 10248
	private static readonly IntPtr NativeFieldInfoPtr_IsProneID;

	// Token: 0x04002809 RID: 10249
	private static readonly IntPtr NativeFieldInfoPtr_CrouchID;

	// Token: 0x0400280A RID: 10250
	private static readonly IntPtr NativeFieldInfoPtr_ForwardID;

	// Token: 0x0400280B RID: 10251
	private static readonly IntPtr NativeFieldInfoPtr_RightID;

	// Token: 0x0400280C RID: 10252
	private static readonly IntPtr NativeFieldInfoPtr_HeightID;

	// Token: 0x0400280D RID: 10253
	private static readonly IntPtr NativeFieldInfoPtr_MovementSpeedID;

	// Token: 0x0400280E RID: 10254
	private static readonly IntPtr NativeFieldInfoPtr_LocalAnimator;

	// Token: 0x0400280F RID: 10255
	private static readonly IntPtr NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField;

	// Token: 0x04002810 RID: 10256
	private static readonly IntPtr NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField;

	// Token: 0x04002811 RID: 10257
	private static readonly IntPtr NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0;

	// Token: 0x04002812 RID: 10258
	private static readonly IntPtr NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0;

	// Token: 0x04002813 RID: 10259
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04002814 RID: 10260
	private static readonly IntPtr NativeMethodInfoPtr_WaitLocomotionLerp_Private_IEnumerator_0;

	// Token: 0x04002815 RID: 10261
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04002816 RID: 10262
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04002817 RID: 10263
	private static readonly IntPtr NativeMethodInfoPtr_get_ManagedLateUpdateRemoval_Public_get_Boolean_0;

	// Token: 0x04002818 RID: 10264
	private static readonly IntPtr NativeMethodInfoPtr_set_ManagedLateUpdateRemoval_Public_set_Void_Boolean_0;

	// Token: 0x04002819 RID: 10265
	private static readonly IntPtr NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x0400281A RID: 10266
	private static readonly IntPtr NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0;

	// Token: 0x0400281B RID: 10267
	private static readonly IntPtr NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0;

	// Token: 0x0400281C RID: 10268
	private static readonly IntPtr NativeMethodInfoPtr_GetVelocityTarget_Private_Vector3_0;

	// Token: 0x0400281D RID: 10269
	private static readonly IntPtr NativeMethodInfoPtr_SetVestAnimation_Public_Void_Boolean_0;

	// Token: 0x0400281E RID: 10270
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000318 RID: 792
	[ObfuscatedName("VRAnimatorController/<WaitLocomotionLerp>d__37")]
	public sealed class _WaitLocomotionLerp_d__37 : Il2CppSystem.Object
	{
		// Token: 0x06003E84 RID: 16004 RVA: 0x000FC490 File Offset: 0x000FA690
		[CallerCount(0)]
		public unsafe _WaitLocomotionLerp_d__37(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRAnimatorController._WaitLocomotionLerp_d__37>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController._WaitLocomotionLerp_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x000FC4F0 File Offset: 0x000FA6F0
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController._WaitLocomotionLerp_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x000FC534 File Offset: 0x000FA734
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController._WaitLocomotionLerp_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06003E87 RID: 16007 RVA: 0x000FC584 File Offset: 0x000FA784
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController._WaitLocomotionLerp_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06003E88 RID: 16008 RVA: 0x000FC5DC File Offset: 0x000FA7DC
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController._WaitLocomotionLerp_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06003E89 RID: 16009 RVA: 0x000FC620 File Offset: 0x000FA820
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRAnimatorController._WaitLocomotionLerp_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06003E8A RID: 16010 RVA: 0x000FC678 File Offset: 0x000FA878
		// Note: this type is marked as 'beforefieldinit'.
		static _WaitLocomotionLerp_d__37()
		{
			Il2CppClassPointerStore<VRAnimatorController._WaitLocomotionLerp_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VRAnimatorController>.NativeClassPtr, "<WaitLocomotionLerp>d__37");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRAnimatorController._WaitLocomotionLerp_d__37>.NativeClassPtr);
			VRAnimatorController._WaitLocomotionLerp_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController._WaitLocomotionLerp_d__37>.NativeClassPtr, "<>1__state");
			VRAnimatorController._WaitLocomotionLerp_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController._WaitLocomotionLerp_d__37>.NativeClassPtr, "<>2__current");
			VRAnimatorController._WaitLocomotionLerp_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRAnimatorController._WaitLocomotionLerp_d__37>.NativeClassPtr, "<>4__this");
			VRAnimatorController._WaitLocomotionLerp_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController._WaitLocomotionLerp_d__37>.NativeClassPtr, 100668293);
			VRAnimatorController._WaitLocomotionLerp_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController._WaitLocomotionLerp_d__37>.NativeClassPtr, 100668294);
			VRAnimatorController._WaitLocomotionLerp_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController._WaitLocomotionLerp_d__37>.NativeClassPtr, 100668295);
			VRAnimatorController._WaitLocomotionLerp_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController._WaitLocomotionLerp_d__37>.NativeClassPtr, 100668296);
			VRAnimatorController._WaitLocomotionLerp_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController._WaitLocomotionLerp_d__37>.NativeClassPtr, 100668297);
			VRAnimatorController._WaitLocomotionLerp_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRAnimatorController._WaitLocomotionLerp_d__37>.NativeClassPtr, 100668298);
		}

		// Token: 0x06003E8B RID: 16011 RVA: 0x00002988 File Offset: 0x00000B88
		public _WaitLocomotionLerp_d__37(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06003E8C RID: 16012 RVA: 0x000FC757 File Offset: 0x000FA957
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VRAnimatorController._WaitLocomotionLerp_d__37>.NativeClassPtr));
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06003E8D RID: 16013 RVA: 0x000FC768 File Offset: 0x000FA968
		// (set) Token: 0x06003E8E RID: 16014 RVA: 0x000FC790 File Offset: 0x000FA990
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController._WaitLocomotionLerp_d__37.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController._WaitLocomotionLerp_d__37.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06003E8F RID: 16015 RVA: 0x000FC7B4 File Offset: 0x000FA9B4
		// (set) Token: 0x06003E90 RID: 16016 RVA: 0x000FC7E8 File Offset: 0x000FA9E8
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController._WaitLocomotionLerp_d__37.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController._WaitLocomotionLerp_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06003E91 RID: 16017 RVA: 0x000FC810 File Offset: 0x000FAA10
		// (set) Token: 0x06003E92 RID: 16018 RVA: 0x000FC844 File Offset: 0x000FAA44
		public unsafe VRAnimatorController __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController._WaitLocomotionLerp_d__37.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new VRAnimatorController(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRAnimatorController._WaitLocomotionLerp_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400281F RID: 10271
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04002820 RID: 10272
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04002821 RID: 10273
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04002822 RID: 10274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002823 RID: 10275
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04002824 RID: 10276
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04002825 RID: 10277
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04002826 RID: 10278
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04002827 RID: 10279
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
