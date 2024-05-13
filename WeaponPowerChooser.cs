using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Onward.Weapons;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.GameVariants.GunGame
{
	// Token: 0x02000FD1 RID: 4049
	[Serializable]
	public class WeaponPowerChooser : Il2CppSystem.Object
	{
		// Token: 0x060136F0 RID: 79600 RVA: 0x004E3734 File Offset: 0x004E1934
		[CallerCount(0)]
		public unsafe void StartChoices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponPowerChooser.NativeMethodInfoPtr_StartChoices_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060136F1 RID: 79601 RVA: 0x004E3778 File Offset: 0x004E1978
		[CallerCount(0)]
		public unsafe WeaponSO MakeChoice(float powerTarget, Il2CppSystem.Random random)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref powerTarget;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponPowerChooser.NativeMethodInfoPtr_MakeChoice_Public_WeaponSO_Single_Random_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new WeaponSO(intPtr2) : null;
		}

		// Token: 0x060136F2 RID: 79602 RVA: 0x004E37F8 File Offset: 0x004E19F8
		[CallerCount(0)]
		public unsafe void RemoveChoice(WeaponSO weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponPowerChooser.NativeMethodInfoPtr_RemoveChoice_Public_Void_WeaponSO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060136F3 RID: 79603 RVA: 0x004E3854 File Offset: 0x004E1A54
		[CallerCount(0)]
		public unsafe WeaponPowerChooser() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponPowerChooser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060136F4 RID: 79604 RVA: 0x004E38A0 File Offset: 0x004E1AA0
		// Note: this type is marked as 'beforefieldinit'.
		static WeaponPowerChooser()
		{
			Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.GameVariants.GunGame", "WeaponPowerChooser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr);
			WeaponPowerChooser.NativeFieldInfoPtr_PowerDistribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr, "PowerDistribution");
			WeaponPowerChooser.NativeFieldInfoPtr_MinimumWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr, "MinimumWeight");
			WeaponPowerChooser.NativeFieldInfoPtr_MaximumWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr, "MaximumWeight");
			WeaponPowerChooser.NativeFieldInfoPtr_WeaponPowerLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr, "WeaponPowerLevels");
			WeaponPowerChooser.NativeFieldInfoPtr__remaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr, "_remaining");
			WeaponPowerChooser.NativeFieldInfoPtr__weights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr, "_weights");
			WeaponPowerChooser.NativeMethodInfoPtr_StartChoices_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr, 100688083);
			WeaponPowerChooser.NativeMethodInfoPtr_MakeChoice_Public_WeaponSO_Single_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr, 100688084);
			WeaponPowerChooser.NativeMethodInfoPtr_RemoveChoice_Public_Void_WeaponSO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr, 100688085);
			WeaponPowerChooser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr, 100688086);
		}

		// Token: 0x060136F5 RID: 79605 RVA: 0x00002988 File Offset: 0x00000B88
		public WeaponPowerChooser(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E3F RID: 28223
		// (get) Token: 0x060136F6 RID: 79606 RVA: 0x004E3998 File Offset: 0x004E1B98
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponPowerChooser>.NativeClassPtr));
			}
		}

		// Token: 0x17006E40 RID: 28224
		// (get) Token: 0x060136F7 RID: 79607 RVA: 0x004E39AC File Offset: 0x004E1BAC
		// (set) Token: 0x060136F8 RID: 79608 RVA: 0x004E39E0 File Offset: 0x004E1BE0
		public unsafe AnimationCurve PowerDistribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponPowerChooser.NativeFieldInfoPtr_PowerDistribution);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AnimationCurve(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponPowerChooser.NativeFieldInfoPtr_PowerDistribution), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E41 RID: 28225
		// (get) Token: 0x060136F9 RID: 79609 RVA: 0x004E3A08 File Offset: 0x004E1C08
		// (set) Token: 0x060136FA RID: 79610 RVA: 0x004E3A30 File Offset: 0x004E1C30
		public unsafe float MinimumWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponPowerChooser.NativeFieldInfoPtr_MinimumWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponPowerChooser.NativeFieldInfoPtr_MinimumWeight)) = value;
			}
		}

		// Token: 0x17006E42 RID: 28226
		// (get) Token: 0x060136FB RID: 79611 RVA: 0x004E3A54 File Offset: 0x004E1C54
		// (set) Token: 0x060136FC RID: 79612 RVA: 0x004E3A7C File Offset: 0x004E1C7C
		public unsafe float MaximumWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponPowerChooser.NativeFieldInfoPtr_MaximumWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponPowerChooser.NativeFieldInfoPtr_MaximumWeight)) = value;
			}
		}

		// Token: 0x17006E43 RID: 28227
		// (get) Token: 0x060136FD RID: 79613 RVA: 0x004E3AA0 File Offset: 0x004E1CA0
		// (set) Token: 0x060136FE RID: 79614 RVA: 0x004E3AD4 File Offset: 0x004E1CD4
		public unsafe Il2CppReferenceArray<WeaponSO> WeaponPowerLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponPowerChooser.NativeFieldInfoPtr_WeaponPowerLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<WeaponSO>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponPowerChooser.NativeFieldInfoPtr_WeaponPowerLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E44 RID: 28228
		// (get) Token: 0x060136FF RID: 79615 RVA: 0x004E3AFC File Offset: 0x004E1CFC
		// (set) Token: 0x06013700 RID: 79616 RVA: 0x004E3B30 File Offset: 0x004E1D30
		public unsafe List<WeaponSO> _remaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponPowerChooser.NativeFieldInfoPtr__remaining);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<WeaponSO>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponPowerChooser.NativeFieldInfoPtr__remaining), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17006E45 RID: 28229
		// (get) Token: 0x06013701 RID: 79617 RVA: 0x004E3B58 File Offset: 0x004E1D58
		// (set) Token: 0x06013702 RID: 79618 RVA: 0x004E3B8C File Offset: 0x004E1D8C
		public unsafe Dictionary<WeaponSO, float> _weights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponPowerChooser.NativeFieldInfoPtr__weights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Dictionary<WeaponSO, float>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponPowerChooser.NativeFieldInfoPtr__weights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400C6B9 RID: 50873
		private static readonly IntPtr NativeFieldInfoPtr_PowerDistribution;

		// Token: 0x0400C6BA RID: 50874
		private static readonly IntPtr NativeFieldInfoPtr_MinimumWeight;

		// Token: 0x0400C6BB RID: 50875
		private static readonly IntPtr NativeFieldInfoPtr_MaximumWeight;

		// Token: 0x0400C6BC RID: 50876
		private static readonly IntPtr NativeFieldInfoPtr_WeaponPowerLevels;

		// Token: 0x0400C6BD RID: 50877
		private static readonly IntPtr NativeFieldInfoPtr__remaining;

		// Token: 0x0400C6BE RID: 50878
		private static readonly IntPtr NativeFieldInfoPtr__weights;

		// Token: 0x0400C6BF RID: 50879
		private static readonly IntPtr NativeMethodInfoPtr_StartChoices_Public_Void_0;

		// Token: 0x0400C6C0 RID: 50880
		private static readonly IntPtr NativeMethodInfoPtr_MakeChoice_Public_WeaponSO_Single_Random_0;

		// Token: 0x0400C6C1 RID: 50881
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChoice_Public_Void_WeaponSO_0;

		// Token: 0x0400C6C2 RID: 50882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
