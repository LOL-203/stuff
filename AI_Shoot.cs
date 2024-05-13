using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.AISystems
{
	// Token: 0x0200117C RID: 4476
	public class AI_Shoot : AIState
	{
		// Token: 0x06014D02 RID: 85250 RVA: 0x0053BF78 File Offset: 0x0053A178
		[CallerCount(0)]
		public new unsafe void Enter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AI_Shoot.NativeMethodInfoPtr_Enter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014D03 RID: 85251 RVA: 0x0053BFC8 File Offset: 0x0053A1C8
		[CallerCount(0)]
		public new unsafe void Tick(float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deltaTime;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AI_Shoot.NativeMethodInfoPtr_Tick_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014D04 RID: 85252 RVA: 0x0053C028 File Offset: 0x0053A228
		[CallerCount(0)]
		public unsafe void LostTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AI_Shoot.NativeMethodInfoPtr_LostTarget_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014D05 RID: 85253 RVA: 0x0053C078 File Offset: 0x0053A278
		[CallerCount(0)]
		public unsafe void NeedToReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AI_Shoot.NativeMethodInfoPtr_NeedToReload_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014D06 RID: 85254 RVA: 0x0053C0C8 File Offset: 0x0053A2C8
		[CallerCount(0)]
		public unsafe void DoneShooting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AI_Shoot.NativeMethodInfoPtr_DoneShooting_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014D07 RID: 85255 RVA: 0x0053C118 File Offset: 0x0053A318
		[CallerCount(0)]
		public unsafe AI_Shoot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AI_Shoot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014D08 RID: 85256 RVA: 0x0053C164 File Offset: 0x0053A364
		// Note: this type is marked as 'beforefieldinit'.
		static AI_Shoot()
		{
			Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.AISystems", "AI_Shoot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr);
			AI_Shoot.NativeFieldInfoPtr_MinRotationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, "MinRotationTime");
			AI_Shoot.NativeFieldInfoPtr_MaxRotationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, "MaxRotationTime");
			AI_Shoot.NativeFieldInfoPtr_MinFireDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, "MinFireDelay");
			AI_Shoot.NativeFieldInfoPtr_MaxFireDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, "MaxFireDelay");
			AI_Shoot.NativeFieldInfoPtr_BetweenShotDelayMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, "BetweenShotDelayMin");
			AI_Shoot.NativeFieldInfoPtr_BetweenShotDelayMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, "BetweenShotDelayMax");
			AI_Shoot.NativeFieldInfoPtr_MinShotsToFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, "MinShotsToFire");
			AI_Shoot.NativeFieldInfoPtr_MaxShotsToFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, "MaxShotsToFire");
			AI_Shoot.NativeFieldInfoPtr_ClearFireAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, "ClearFireAngle");
			AI_Shoot.NativeFieldInfoPtr_ClearFrontRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, "ClearFrontRange");
			AI_Shoot.NativeFieldInfoPtr__angleTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, "_angleTimer");
			AI_Shoot.NativeFieldInfoPtr__fireDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, "_fireDelay");
			AI_Shoot.NativeFieldInfoPtr__shotsToFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, "_shotsToFire");
			AI_Shoot.NativeMethodInfoPtr_Enter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, 100689838);
			AI_Shoot.NativeMethodInfoPtr_Tick_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, 100689839);
			AI_Shoot.NativeMethodInfoPtr_LostTarget_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, 100689840);
			AI_Shoot.NativeMethodInfoPtr_NeedToReload_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, 100689841);
			AI_Shoot.NativeMethodInfoPtr_DoneShooting_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, 100689842);
			AI_Shoot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr, 100689843);
		}

		// Token: 0x06014D09 RID: 85257 RVA: 0x00535C60 File Offset: 0x00533E60
		public AI_Shoot(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170075C1 RID: 30145
		// (get) Token: 0x06014D0A RID: 85258 RVA: 0x0053C310 File Offset: 0x0053A510
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AI_Shoot>.NativeClassPtr));
			}
		}

		// Token: 0x170075C2 RID: 30146
		// (get) Token: 0x06014D0B RID: 85259 RVA: 0x0053C324 File Offset: 0x0053A524
		// (set) Token: 0x06014D0C RID: 85260 RVA: 0x0053C34C File Offset: 0x0053A54C
		public unsafe float MinRotationTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_MinRotationTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_MinRotationTime)) = value;
			}
		}

		// Token: 0x170075C3 RID: 30147
		// (get) Token: 0x06014D0D RID: 85261 RVA: 0x0053C370 File Offset: 0x0053A570
		// (set) Token: 0x06014D0E RID: 85262 RVA: 0x0053C398 File Offset: 0x0053A598
		public unsafe float MaxRotationTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_MaxRotationTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_MaxRotationTime)) = value;
			}
		}

		// Token: 0x170075C4 RID: 30148
		// (get) Token: 0x06014D0F RID: 85263 RVA: 0x0053C3BC File Offset: 0x0053A5BC
		// (set) Token: 0x06014D10 RID: 85264 RVA: 0x0053C3E4 File Offset: 0x0053A5E4
		public unsafe float MinFireDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_MinFireDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_MinFireDelay)) = value;
			}
		}

		// Token: 0x170075C5 RID: 30149
		// (get) Token: 0x06014D11 RID: 85265 RVA: 0x0053C408 File Offset: 0x0053A608
		// (set) Token: 0x06014D12 RID: 85266 RVA: 0x0053C430 File Offset: 0x0053A630
		public unsafe float MaxFireDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_MaxFireDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_MaxFireDelay)) = value;
			}
		}

		// Token: 0x170075C6 RID: 30150
		// (get) Token: 0x06014D13 RID: 85267 RVA: 0x0053C454 File Offset: 0x0053A654
		// (set) Token: 0x06014D14 RID: 85268 RVA: 0x0053C47C File Offset: 0x0053A67C
		public unsafe float BetweenShotDelayMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_BetweenShotDelayMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_BetweenShotDelayMin)) = value;
			}
		}

		// Token: 0x170075C7 RID: 30151
		// (get) Token: 0x06014D15 RID: 85269 RVA: 0x0053C4A0 File Offset: 0x0053A6A0
		// (set) Token: 0x06014D16 RID: 85270 RVA: 0x0053C4C8 File Offset: 0x0053A6C8
		public unsafe float BetweenShotDelayMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_BetweenShotDelayMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_BetweenShotDelayMax)) = value;
			}
		}

		// Token: 0x170075C8 RID: 30152
		// (get) Token: 0x06014D17 RID: 85271 RVA: 0x0053C4EC File Offset: 0x0053A6EC
		// (set) Token: 0x06014D18 RID: 85272 RVA: 0x0053C514 File Offset: 0x0053A714
		public unsafe int MinShotsToFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_MinShotsToFire);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_MinShotsToFire)) = value;
			}
		}

		// Token: 0x170075C9 RID: 30153
		// (get) Token: 0x06014D19 RID: 85273 RVA: 0x0053C538 File Offset: 0x0053A738
		// (set) Token: 0x06014D1A RID: 85274 RVA: 0x0053C560 File Offset: 0x0053A760
		public unsafe int MaxShotsToFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_MaxShotsToFire);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_MaxShotsToFire)) = value;
			}
		}

		// Token: 0x170075CA RID: 30154
		// (get) Token: 0x06014D1B RID: 85275 RVA: 0x0053C584 File Offset: 0x0053A784
		// (set) Token: 0x06014D1C RID: 85276 RVA: 0x0053C5AC File Offset: 0x0053A7AC
		public unsafe float ClearFireAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_ClearFireAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_ClearFireAngle)) = value;
			}
		}

		// Token: 0x170075CB RID: 30155
		// (get) Token: 0x06014D1D RID: 85277 RVA: 0x0053C5D0 File Offset: 0x0053A7D0
		// (set) Token: 0x06014D1E RID: 85278 RVA: 0x0053C5F8 File Offset: 0x0053A7F8
		public unsafe float ClearFrontRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_ClearFrontRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr_ClearFrontRange)) = value;
			}
		}

		// Token: 0x170075CC RID: 30156
		// (get) Token: 0x06014D1F RID: 85279 RVA: 0x0053C61C File Offset: 0x0053A81C
		// (set) Token: 0x06014D20 RID: 85280 RVA: 0x0053C644 File Offset: 0x0053A844
		public unsafe float _angleTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr__angleTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr__angleTimer)) = value;
			}
		}

		// Token: 0x170075CD RID: 30157
		// (get) Token: 0x06014D21 RID: 85281 RVA: 0x0053C668 File Offset: 0x0053A868
		// (set) Token: 0x06014D22 RID: 85282 RVA: 0x0053C690 File Offset: 0x0053A890
		public unsafe float _fireDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr__fireDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr__fireDelay)) = value;
			}
		}

		// Token: 0x170075CE RID: 30158
		// (get) Token: 0x06014D23 RID: 85283 RVA: 0x0053C6B4 File Offset: 0x0053A8B4
		// (set) Token: 0x06014D24 RID: 85284 RVA: 0x0053C6DC File Offset: 0x0053A8DC
		public unsafe float _shotsToFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr__shotsToFire);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_Shoot.NativeFieldInfoPtr__shotsToFire)) = value;
			}
		}

		// Token: 0x0400D4A6 RID: 54438
		private static readonly IntPtr NativeFieldInfoPtr_MinRotationTime;

		// Token: 0x0400D4A7 RID: 54439
		private static readonly IntPtr NativeFieldInfoPtr_MaxRotationTime;

		// Token: 0x0400D4A8 RID: 54440
		private static readonly IntPtr NativeFieldInfoPtr_MinFireDelay;

		// Token: 0x0400D4A9 RID: 54441
		private static readonly IntPtr NativeFieldInfoPtr_MaxFireDelay;

		// Token: 0x0400D4AA RID: 54442
		private static readonly IntPtr NativeFieldInfoPtr_BetweenShotDelayMin;

		// Token: 0x0400D4AB RID: 54443
		private static readonly IntPtr NativeFieldInfoPtr_BetweenShotDelayMax;

		// Token: 0x0400D4AC RID: 54444
		private static readonly IntPtr NativeFieldInfoPtr_MinShotsToFire;

		// Token: 0x0400D4AD RID: 54445
		private static readonly IntPtr NativeFieldInfoPtr_MaxShotsToFire;

		// Token: 0x0400D4AE RID: 54446
		private static readonly IntPtr NativeFieldInfoPtr_ClearFireAngle;

		// Token: 0x0400D4AF RID: 54447
		private static readonly IntPtr NativeFieldInfoPtr_ClearFrontRange;

		// Token: 0x0400D4B0 RID: 54448
		private static readonly IntPtr NativeFieldInfoPtr__angleTimer;

		// Token: 0x0400D4B1 RID: 54449
		private static readonly IntPtr NativeFieldInfoPtr__fireDelay;

		// Token: 0x0400D4B2 RID: 54450
		private static readonly IntPtr NativeFieldInfoPtr__shotsToFire;

		// Token: 0x0400D4B3 RID: 54451
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Virtual_Void_0;

		// Token: 0x0400D4B4 RID: 54452
		private static readonly IntPtr NativeMethodInfoPtr_Tick_Protected_Virtual_Void_Single_0;

		// Token: 0x0400D4B5 RID: 54453
		private static readonly IntPtr NativeMethodInfoPtr_LostTarget_Protected_Virtual_New_Void_0;

		// Token: 0x0400D4B6 RID: 54454
		private static readonly IntPtr NativeMethodInfoPtr_NeedToReload_Protected_Virtual_New_Void_0;

		// Token: 0x0400D4B7 RID: 54455
		private static readonly IntPtr NativeMethodInfoPtr_DoneShooting_Protected_Virtual_New_Void_0;

		// Token: 0x0400D4B8 RID: 54456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
