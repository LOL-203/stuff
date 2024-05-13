using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.AISystems
{
	// Token: 0x0200117F RID: 4479
	public class AI_StrafeAndShoot : AI_Shoot
	{
		// Token: 0x06014D51 RID: 85329 RVA: 0x0053D14C File Offset: 0x0053B34C
		[CallerCount(0)]
		public new unsafe void Enter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AI_StrafeAndShoot.NativeMethodInfoPtr_Enter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014D52 RID: 85330 RVA: 0x0053D19C File Offset: 0x0053B39C
		[CallerCount(0)]
		public new unsafe void Tick(float deltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deltaTime;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AI_StrafeAndShoot.NativeMethodInfoPtr_Tick_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014D53 RID: 85331 RVA: 0x0053D1FC File Offset: 0x0053B3FC
		[CallerCount(0)]
		public unsafe AI_StrafeAndShoot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AI_StrafeAndShoot>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AI_StrafeAndShoot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014D54 RID: 85332 RVA: 0x0053D248 File Offset: 0x0053B448
		// Note: this type is marked as 'beforefieldinit'.
		static AI_StrafeAndShoot()
		{
			Il2CppClassPointerStore<AI_StrafeAndShoot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.AISystems", "AI_StrafeAndShoot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AI_StrafeAndShoot>.NativeClassPtr);
			AI_StrafeAndShoot.NativeFieldInfoPtr_MinMoveDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_StrafeAndShoot>.NativeClassPtr, "MinMoveDistance");
			AI_StrafeAndShoot.NativeFieldInfoPtr_MaxMoveDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI_StrafeAndShoot>.NativeClassPtr, "MaxMoveDistance");
			AI_StrafeAndShoot.NativeMethodInfoPtr_Enter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI_StrafeAndShoot>.NativeClassPtr, 100689856);
			AI_StrafeAndShoot.NativeMethodInfoPtr_Tick_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI_StrafeAndShoot>.NativeClassPtr, 100689857);
			AI_StrafeAndShoot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI_StrafeAndShoot>.NativeClassPtr, 100689858);
		}

		// Token: 0x06014D55 RID: 85333 RVA: 0x0053C880 File Offset: 0x0053AA80
		public AI_StrafeAndShoot(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170075DE RID: 30174
		// (get) Token: 0x06014D56 RID: 85334 RVA: 0x0053D2DC File Offset: 0x0053B4DC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AI_StrafeAndShoot>.NativeClassPtr));
			}
		}

		// Token: 0x170075DF RID: 30175
		// (get) Token: 0x06014D57 RID: 85335 RVA: 0x0053D2F0 File Offset: 0x0053B4F0
		// (set) Token: 0x06014D58 RID: 85336 RVA: 0x0053D318 File Offset: 0x0053B518
		public unsafe float MinMoveDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_StrafeAndShoot.NativeFieldInfoPtr_MinMoveDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_StrafeAndShoot.NativeFieldInfoPtr_MinMoveDistance)) = value;
			}
		}

		// Token: 0x170075E0 RID: 30176
		// (get) Token: 0x06014D59 RID: 85337 RVA: 0x0053D33C File Offset: 0x0053B53C
		// (set) Token: 0x06014D5A RID: 85338 RVA: 0x0053D364 File Offset: 0x0053B564
		public unsafe float MaxMoveDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_StrafeAndShoot.NativeFieldInfoPtr_MaxMoveDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AI_StrafeAndShoot.NativeFieldInfoPtr_MaxMoveDistance)) = value;
			}
		}

		// Token: 0x0400D4D2 RID: 54482
		private static readonly IntPtr NativeFieldInfoPtr_MinMoveDistance;

		// Token: 0x0400D4D3 RID: 54483
		private static readonly IntPtr NativeFieldInfoPtr_MaxMoveDistance;

		// Token: 0x0400D4D4 RID: 54484
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Virtual_Void_0;

		// Token: 0x0400D4D5 RID: 54485
		private static readonly IntPtr NativeMethodInfoPtr_Tick_Protected_Virtual_Void_Single_0;

		// Token: 0x0400D4D6 RID: 54486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
