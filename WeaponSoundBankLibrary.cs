using System;
using AK.Wwise;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200015C RID: 348
public class WeaponSoundBankLibrary : ScriptableObject
{
	// Token: 0x06001783 RID: 6019 RVA: 0x0005E79C File Offset: 0x0005C99C
	[CallerCount(0)]
	public unsafe bool TryGetBankForWeapon(WeaponName weaponName, out Bank soundBank)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref weaponName;
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(soundBank);
		ptr2 = &intPtr;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponSoundBankLibrary.NativeMethodInfoPtr_TryGetBankForWeapon_Public_Boolean_WeaponName_byref_Bank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		soundBank = ((intPtr2 == 0) ? null : new Bank(intPtr2));
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x0005E838 File Offset: 0x0005CA38
	[CallerCount(0)]
	public unsafe WeaponSoundBankLibrary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponSoundBankLibrary>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSoundBankLibrary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x0005E884 File Offset: 0x0005CA84
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponSoundBankLibrary()
	{
		Il2CppClassPointerStore<WeaponSoundBankLibrary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponSoundBankLibrary");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponSoundBankLibrary>.NativeClassPtr);
		WeaponSoundBankLibrary.NativeFieldInfoPtr_WeaponSoundBankAssignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSoundBankLibrary>.NativeClassPtr, "WeaponSoundBankAssignments");
		WeaponSoundBankLibrary.NativeMethodInfoPtr_TryGetBankForWeapon_Public_Boolean_WeaponName_byref_Bank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSoundBankLibrary>.NativeClassPtr, 100665184);
		WeaponSoundBankLibrary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSoundBankLibrary>.NativeClassPtr, 100665185);
	}

	// Token: 0x06001786 RID: 6022 RVA: 0x0002DD3C File Offset: 0x0002BF3C
	public WeaponSoundBankLibrary(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700081D RID: 2077
	// (get) Token: 0x06001787 RID: 6023 RVA: 0x0005E8F0 File Offset: 0x0005CAF0
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponSoundBankLibrary>.NativeClassPtr));
		}
	}

	// Token: 0x1700081E RID: 2078
	// (get) Token: 0x06001788 RID: 6024 RVA: 0x0005E904 File Offset: 0x0005CB04
	// (set) Token: 0x06001789 RID: 6025 RVA: 0x0005E938 File Offset: 0x0005CB38
	public unsafe List<WeaponSoundBankLibrary.WeaponSoundBankAssignment> WeaponSoundBankAssignments
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSoundBankLibrary.NativeFieldInfoPtr_WeaponSoundBankAssignments);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<WeaponSoundBankLibrary.WeaponSoundBankAssignment>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSoundBankLibrary.NativeFieldInfoPtr_WeaponSoundBankAssignments), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000F06 RID: 3846
	private static readonly IntPtr NativeFieldInfoPtr_WeaponSoundBankAssignments;

	// Token: 0x04000F07 RID: 3847
	private static readonly IntPtr NativeMethodInfoPtr_TryGetBankForWeapon_Public_Boolean_WeaponName_byref_Bank_0;

	// Token: 0x04000F08 RID: 3848
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200015D RID: 349
	[Serializable]
	public class WeaponSoundBankAssignment : Il2CppSystem.Object
	{
		// Token: 0x0600178A RID: 6026 RVA: 0x0005E960 File Offset: 0x0005CB60
		[CallerCount(0)]
		public unsafe WeaponSoundBankAssignment() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponSoundBankLibrary.WeaponSoundBankAssignment>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSoundBankLibrary.WeaponSoundBankAssignment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0005E9AC File Offset: 0x0005CBAC
		// Note: this type is marked as 'beforefieldinit'.
		static WeaponSoundBankAssignment()
		{
			Il2CppClassPointerStore<WeaponSoundBankLibrary.WeaponSoundBankAssignment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeaponSoundBankLibrary>.NativeClassPtr, "WeaponSoundBankAssignment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponSoundBankLibrary.WeaponSoundBankAssignment>.NativeClassPtr);
			WeaponSoundBankLibrary.WeaponSoundBankAssignment.NativeFieldInfoPtr_weaponName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSoundBankLibrary.WeaponSoundBankAssignment>.NativeClassPtr, "weaponName");
			WeaponSoundBankLibrary.WeaponSoundBankAssignment.NativeFieldInfoPtr_soundBank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSoundBankLibrary.WeaponSoundBankAssignment>.NativeClassPtr, "soundBank");
			WeaponSoundBankLibrary.WeaponSoundBankAssignment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSoundBankLibrary.WeaponSoundBankAssignment>.NativeClassPtr, 100665186);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00002988 File Offset: 0x00000B88
		public WeaponSoundBankAssignment(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x0005EA13 File Offset: 0x0005CC13
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponSoundBankLibrary.WeaponSoundBankAssignment>.NativeClassPtr));
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x0005EA24 File Offset: 0x0005CC24
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x0005EA4C File Offset: 0x0005CC4C
		public unsafe WeaponName weaponName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSoundBankLibrary.WeaponSoundBankAssignment.NativeFieldInfoPtr_weaponName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSoundBankLibrary.WeaponSoundBankAssignment.NativeFieldInfoPtr_weaponName)) = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x0005EA70 File Offset: 0x0005CC70
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x0005EAA4 File Offset: 0x0005CCA4
		public unsafe Bank soundBank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSoundBankLibrary.WeaponSoundBankAssignment.NativeFieldInfoPtr_soundBank);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Bank(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSoundBankLibrary.WeaponSoundBankAssignment.NativeFieldInfoPtr_soundBank), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeFieldInfoPtr_weaponName;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeFieldInfoPtr_soundBank;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
