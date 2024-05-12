using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnitySA.Utility;

namespace UnitySA.Characters.FirstPerson
{
	// Token: 0x02000620 RID: 1568
	public class FPCtrl : MonoBehaviour
	{
		// Token: 0x06007F42 RID: 32578 RVA: 0x00202710 File Offset: 0x00200910
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPCtrl.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x00202754 File Offset: 0x00200954
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPCtrl.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x00202798 File Offset: 0x00200998
		[CallerCount(0)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPCtrl.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F45 RID: 32581 RVA: 0x002027DC File Offset: 0x002009DC
		[CallerCount(0)]
		public unsafe void ProgressStepCycle(float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref speed;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPCtrl.NativeMethodInfoPtr_ProgressStepCycle_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F46 RID: 32582 RVA: 0x00202830 File Offset: 0x00200A30
		[CallerCount(0)]
		public unsafe void UpdateCameraPosition(float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref speed;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPCtrl.NativeMethodInfoPtr_UpdateCameraPosition_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F47 RID: 32583 RVA: 0x00202884 File Offset: 0x00200A84
		[CallerCount(0)]
		public unsafe void GetInput(out float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &speed;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPCtrl.NativeMethodInfoPtr_GetInput_Private_Void_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F48 RID: 32584 RVA: 0x002028DC File Offset: 0x00200ADC
		[CallerCount(0)]
		public unsafe void RotateView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPCtrl.NativeMethodInfoPtr_RotateView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F49 RID: 32585 RVA: 0x00202920 File Offset: 0x00200B20
		[CallerCount(0)]
		public unsafe void OnControllerColliderHit(ControllerColliderHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(hit);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPCtrl.NativeMethodInfoPtr_OnControllerColliderHit_Private_Void_ControllerColliderHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F4A RID: 32586 RVA: 0x0020297C File Offset: 0x00200B7C
		[CallerCount(0)]
		public unsafe FPCtrl() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FPCtrl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F4B RID: 32587 RVA: 0x002029C8 File Offset: 0x00200BC8
		// Note: this type is marked as 'beforefieldinit'.
		static FPCtrl()
		{
			Il2CppClassPointerStore<FPCtrl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnitySA.Characters.FirstPerson", "FPCtrl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr);
			FPCtrl.NativeFieldInfoPtr_m_IsWalking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_IsWalking");
			FPCtrl.NativeFieldInfoPtr_m_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_WalkSpeed");
			FPCtrl.NativeFieldInfoPtr_m_RunSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_RunSpeed");
			FPCtrl.NativeFieldInfoPtr_m_RunstepLenghten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_RunstepLenghten");
			FPCtrl.NativeFieldInfoPtr_m_JumpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_JumpSpeed");
			FPCtrl.NativeFieldInfoPtr_m_StickToGroundForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_StickToGroundForce");
			FPCtrl.NativeFieldInfoPtr_m_GravityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_GravityMultiplier");
			FPCtrl.NativeFieldInfoPtr_m_MouseLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_MouseLook");
			FPCtrl.NativeFieldInfoPtr_m_UseFovKick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_UseFovKick");
			FPCtrl.NativeFieldInfoPtr_m_FovKick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_FovKick");
			FPCtrl.NativeFieldInfoPtr_m_UseHeadBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_UseHeadBob");
			FPCtrl.NativeFieldInfoPtr_m_HeadBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_HeadBob");
			FPCtrl.NativeFieldInfoPtr_m_JumpBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_JumpBob");
			FPCtrl.NativeFieldInfoPtr_m_StepInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_StepInterval");
			FPCtrl.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_Camera");
			FPCtrl.NativeFieldInfoPtr_m_Jump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_Jump");
			FPCtrl.NativeFieldInfoPtr_m_YRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_YRotation");
			FPCtrl.NativeFieldInfoPtr_m_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_Input");
			FPCtrl.NativeFieldInfoPtr_m_MoveDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_MoveDir");
			FPCtrl.NativeFieldInfoPtr_m_CharacterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_CharacterController");
			FPCtrl.NativeFieldInfoPtr_m_CollisionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_CollisionFlags");
			FPCtrl.NativeFieldInfoPtr_m_PreviouslyGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_PreviouslyGrounded");
			FPCtrl.NativeFieldInfoPtr_m_OriginalCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_OriginalCameraPosition");
			FPCtrl.NativeFieldInfoPtr_m_StepCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_StepCycle");
			FPCtrl.NativeFieldInfoPtr_m_NextStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_NextStep");
			FPCtrl.NativeFieldInfoPtr_m_Jumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_Jumping");
			FPCtrl.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100673582);
			FPCtrl.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100673583);
			FPCtrl.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100673584);
			FPCtrl.NativeMethodInfoPtr_ProgressStepCycle_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100673585);
			FPCtrl.NativeMethodInfoPtr_UpdateCameraPosition_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100673586);
			FPCtrl.NativeMethodInfoPtr_GetInput_Private_Void_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100673587);
			FPCtrl.NativeMethodInfoPtr_RotateView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100673588);
			FPCtrl.NativeMethodInfoPtr_OnControllerColliderHit_Private_Void_ControllerColliderHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100673589);
			FPCtrl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100673590);
		}

		// Token: 0x06007F4C RID: 32588 RVA: 0x0000210C File Offset: 0x0000030C
		public FPCtrl(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x06007F4D RID: 32589 RVA: 0x00202CB4 File Offset: 0x00200EB4
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr));
			}
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x06007F4E RID: 32590 RVA: 0x00202CC8 File Offset: 0x00200EC8
		// (set) Token: 0x06007F4F RID: 32591 RVA: 0x00202CF0 File Offset: 0x00200EF0
		public unsafe bool m_IsWalking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_IsWalking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_IsWalking)) = value;
			}
		}

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x06007F50 RID: 32592 RVA: 0x00202D14 File Offset: 0x00200F14
		// (set) Token: 0x06007F51 RID: 32593 RVA: 0x00202D3C File Offset: 0x00200F3C
		public unsafe float m_WalkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_WalkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_WalkSpeed)) = value;
			}
		}

		// Token: 0x17002D78 RID: 11640
		// (get) Token: 0x06007F52 RID: 32594 RVA: 0x00202D60 File Offset: 0x00200F60
		// (set) Token: 0x06007F53 RID: 32595 RVA: 0x00202D88 File Offset: 0x00200F88
		public unsafe float m_RunSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_RunSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_RunSpeed)) = value;
			}
		}

		// Token: 0x17002D79 RID: 11641
		// (get) Token: 0x06007F54 RID: 32596 RVA: 0x00202DAC File Offset: 0x00200FAC
		// (set) Token: 0x06007F55 RID: 32597 RVA: 0x00202DD4 File Offset: 0x00200FD4
		public unsafe float m_RunstepLenghten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_RunstepLenghten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_RunstepLenghten)) = value;
			}
		}

		// Token: 0x17002D7A RID: 11642
		// (get) Token: 0x06007F56 RID: 32598 RVA: 0x00202DF8 File Offset: 0x00200FF8
		// (set) Token: 0x06007F57 RID: 32599 RVA: 0x00202E20 File Offset: 0x00201020
		public unsafe float m_JumpSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_JumpSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_JumpSpeed)) = value;
			}
		}

		// Token: 0x17002D7B RID: 11643
		// (get) Token: 0x06007F58 RID: 32600 RVA: 0x00202E44 File Offset: 0x00201044
		// (set) Token: 0x06007F59 RID: 32601 RVA: 0x00202E6C File Offset: 0x0020106C
		public unsafe float m_StickToGroundForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_StickToGroundForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_StickToGroundForce)) = value;
			}
		}

		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x06007F5A RID: 32602 RVA: 0x00202E90 File Offset: 0x00201090
		// (set) Token: 0x06007F5B RID: 32603 RVA: 0x00202EB8 File Offset: 0x002010B8
		public unsafe float m_GravityMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_GravityMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_GravityMultiplier)) = value;
			}
		}

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x06007F5C RID: 32604 RVA: 0x00202EDC File Offset: 0x002010DC
		// (set) Token: 0x06007F5D RID: 32605 RVA: 0x00202F10 File Offset: 0x00201110
		public unsafe MLook m_MouseLook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_MouseLook);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new MLook(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_MouseLook), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x06007F5E RID: 32606 RVA: 0x00202F38 File Offset: 0x00201138
		// (set) Token: 0x06007F5F RID: 32607 RVA: 0x00202F60 File Offset: 0x00201160
		public unsafe bool m_UseFovKick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_UseFovKick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_UseFovKick)) = value;
			}
		}

		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x06007F60 RID: 32608 RVA: 0x00202F84 File Offset: 0x00201184
		// (set) Token: 0x06007F61 RID: 32609 RVA: 0x00202FB8 File Offset: 0x002011B8
		public unsafe FOVZoom m_FovKick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_FovKick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new FOVZoom(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_FovKick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x06007F62 RID: 32610 RVA: 0x00202FE0 File Offset: 0x002011E0
		// (set) Token: 0x06007F63 RID: 32611 RVA: 0x00203008 File Offset: 0x00201208
		public unsafe bool m_UseHeadBob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_UseHeadBob);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_UseHeadBob)) = value;
			}
		}

		// Token: 0x17002D81 RID: 11649
		// (get) Token: 0x06007F64 RID: 32612 RVA: 0x0020302C File Offset: 0x0020122C
		// (set) Token: 0x06007F65 RID: 32613 RVA: 0x00203060 File Offset: 0x00201260
		public unsafe CurveCtrlBob m_HeadBob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_HeadBob);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new CurveCtrlBob(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_HeadBob), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D82 RID: 11650
		// (get) Token: 0x06007F66 RID: 32614 RVA: 0x00203088 File Offset: 0x00201288
		// (set) Token: 0x06007F67 RID: 32615 RVA: 0x002030BC File Offset: 0x002012BC
		public unsafe LerpCtrlBob m_JumpBob
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_JumpBob);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new LerpCtrlBob(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_JumpBob), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D83 RID: 11651
		// (get) Token: 0x06007F68 RID: 32616 RVA: 0x002030E4 File Offset: 0x002012E4
		// (set) Token: 0x06007F69 RID: 32617 RVA: 0x0020310C File Offset: 0x0020130C
		public unsafe float m_StepInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_StepInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_StepInterval)) = value;
			}
		}

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x06007F6A RID: 32618 RVA: 0x00203130 File Offset: 0x00201330
		// (set) Token: 0x06007F6B RID: 32619 RVA: 0x00203164 File Offset: 0x00201364
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Camera(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x06007F6C RID: 32620 RVA: 0x0020318C File Offset: 0x0020138C
		// (set) Token: 0x06007F6D RID: 32621 RVA: 0x002031B4 File Offset: 0x002013B4
		public unsafe bool m_Jump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_Jump);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_Jump)) = value;
			}
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x06007F6E RID: 32622 RVA: 0x002031D8 File Offset: 0x002013D8
		// (set) Token: 0x06007F6F RID: 32623 RVA: 0x00203200 File Offset: 0x00201400
		public unsafe float m_YRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_YRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_YRotation)) = value;
			}
		}

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x06007F70 RID: 32624 RVA: 0x00203224 File Offset: 0x00201424
		// (set) Token: 0x06007F71 RID: 32625 RVA: 0x0020324C File Offset: 0x0020144C
		public unsafe Vector2 m_Input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_Input);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_Input)) = value;
			}
		}

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x06007F72 RID: 32626 RVA: 0x00203270 File Offset: 0x00201470
		// (set) Token: 0x06007F73 RID: 32627 RVA: 0x00203298 File Offset: 0x00201498
		public unsafe Vector3 m_MoveDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_MoveDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_MoveDir)) = value;
			}
		}

		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x06007F74 RID: 32628 RVA: 0x002032BC File Offset: 0x002014BC
		// (set) Token: 0x06007F75 RID: 32629 RVA: 0x002032F0 File Offset: 0x002014F0
		public unsafe CharacterController m_CharacterController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_CharacterController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new CharacterController(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_CharacterController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x06007F76 RID: 32630 RVA: 0x00203318 File Offset: 0x00201518
		// (set) Token: 0x06007F77 RID: 32631 RVA: 0x00203340 File Offset: 0x00201540
		public unsafe CollisionFlags m_CollisionFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_CollisionFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_CollisionFlags)) = value;
			}
		}

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x06007F78 RID: 32632 RVA: 0x00203364 File Offset: 0x00201564
		// (set) Token: 0x06007F79 RID: 32633 RVA: 0x0020338C File Offset: 0x0020158C
		public unsafe bool m_PreviouslyGrounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_PreviouslyGrounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_PreviouslyGrounded)) = value;
			}
		}

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x06007F7A RID: 32634 RVA: 0x002033B0 File Offset: 0x002015B0
		// (set) Token: 0x06007F7B RID: 32635 RVA: 0x002033D8 File Offset: 0x002015D8
		public unsafe Vector3 m_OriginalCameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_OriginalCameraPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_OriginalCameraPosition)) = value;
			}
		}

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x06007F7C RID: 32636 RVA: 0x002033FC File Offset: 0x002015FC
		// (set) Token: 0x06007F7D RID: 32637 RVA: 0x00203424 File Offset: 0x00201624
		public unsafe float m_StepCycle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_StepCycle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_StepCycle)) = value;
			}
		}

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x06007F7E RID: 32638 RVA: 0x00203448 File Offset: 0x00201648
		// (set) Token: 0x06007F7F RID: 32639 RVA: 0x00203470 File Offset: 0x00201670
		public unsafe float m_NextStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_NextStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_NextStep)) = value;
			}
		}

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x06007F80 RID: 32640 RVA: 0x00203494 File Offset: 0x00201694
		// (set) Token: 0x06007F81 RID: 32641 RVA: 0x002034BC File Offset: 0x002016BC
		public unsafe bool m_Jumping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_Jumping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FPCtrl.NativeFieldInfoPtr_m_Jumping)) = value;
			}
		}

		// Token: 0x040051A3 RID: 20899
		private static readonly IntPtr NativeFieldInfoPtr_m_IsWalking;

		// Token: 0x040051A4 RID: 20900
		private static readonly IntPtr NativeFieldInfoPtr_m_WalkSpeed;

		// Token: 0x040051A5 RID: 20901
		private static readonly IntPtr NativeFieldInfoPtr_m_RunSpeed;

		// Token: 0x040051A6 RID: 20902
		private static readonly IntPtr NativeFieldInfoPtr_m_RunstepLenghten;

		// Token: 0x040051A7 RID: 20903
		private static readonly IntPtr NativeFieldInfoPtr_m_JumpSpeed;

		// Token: 0x040051A8 RID: 20904
		private static readonly IntPtr NativeFieldInfoPtr_m_StickToGroundForce;

		// Token: 0x040051A9 RID: 20905
		private static readonly IntPtr NativeFieldInfoPtr_m_GravityMultiplier;

		// Token: 0x040051AA RID: 20906
		private static readonly IntPtr NativeFieldInfoPtr_m_MouseLook;

		// Token: 0x040051AB RID: 20907
		private static readonly IntPtr NativeFieldInfoPtr_m_UseFovKick;

		// Token: 0x040051AC RID: 20908
		private static readonly IntPtr NativeFieldInfoPtr_m_FovKick;

		// Token: 0x040051AD RID: 20909
		private static readonly IntPtr NativeFieldInfoPtr_m_UseHeadBob;

		// Token: 0x040051AE RID: 20910
		private static readonly IntPtr NativeFieldInfoPtr_m_HeadBob;

		// Token: 0x040051AF RID: 20911
		private static readonly IntPtr NativeFieldInfoPtr_m_JumpBob;

		// Token: 0x040051B0 RID: 20912
		private static readonly IntPtr NativeFieldInfoPtr_m_StepInterval;

		// Token: 0x040051B1 RID: 20913
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x040051B2 RID: 20914
		private static readonly IntPtr NativeFieldInfoPtr_m_Jump;

		// Token: 0x040051B3 RID: 20915
		private static readonly IntPtr NativeFieldInfoPtr_m_YRotation;

		// Token: 0x040051B4 RID: 20916
		private static readonly IntPtr NativeFieldInfoPtr_m_Input;

		// Token: 0x040051B5 RID: 20917
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveDir;

		// Token: 0x040051B6 RID: 20918
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterController;

		// Token: 0x040051B7 RID: 20919
		private static readonly IntPtr NativeFieldInfoPtr_m_CollisionFlags;

		// Token: 0x040051B8 RID: 20920
		private static readonly IntPtr NativeFieldInfoPtr_m_PreviouslyGrounded;

		// Token: 0x040051B9 RID: 20921
		private static readonly IntPtr NativeFieldInfoPtr_m_OriginalCameraPosition;

		// Token: 0x040051BA RID: 20922
		private static readonly IntPtr NativeFieldInfoPtr_m_StepCycle;

		// Token: 0x040051BB RID: 20923
		private static readonly IntPtr NativeFieldInfoPtr_m_NextStep;

		// Token: 0x040051BC RID: 20924
		private static readonly IntPtr NativeFieldInfoPtr_m_Jumping;

		// Token: 0x040051BD RID: 20925
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040051BE RID: 20926
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040051BF RID: 20927
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040051C0 RID: 20928
		private static readonly IntPtr NativeMethodInfoPtr_ProgressStepCycle_Private_Void_Single_0;

		// Token: 0x040051C1 RID: 20929
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraPosition_Private_Void_Single_0;

		// Token: 0x040051C2 RID: 20930
		private static readonly IntPtr NativeMethodInfoPtr_GetInput_Private_Void_byref_Single_0;

		// Token: 0x040051C3 RID: 20931
		private static readonly IntPtr NativeMethodInfoPtr_RotateView_Private_Void_0;

		// Token: 0x040051C4 RID: 20932
		private static readonly IntPtr NativeMethodInfoPtr_OnControllerColliderHit_Private_Void_ControllerColliderHit_0;

		// Token: 0x040051C5 RID: 20933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
