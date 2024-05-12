using System;
using Il2CppSystem;
using Onward.Weapons;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x02000527 RID: 1319
[Serializable]
public class WeaponInformation : Object
{
	// Token: 0x1700267D RID: 9853
	// (get) Token: 0x06006C00 RID: 27648 RVA: 0x001B1DE4 File Offset: 0x001AFFE4
	public unsafe float WeightMovement
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponInformation.NativeMethodInfoPtr_get_WeightMovement_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x1700267E RID: 9854
	// (get) Token: 0x06006C01 RID: 27649 RVA: 0x001B1E34 File Offset: 0x001B0034
	public unsafe float NormalizedWeightMovement
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponInformation.NativeMethodInfoPtr_get_NormalizedWeightMovement_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x06006C02 RID: 27650 RVA: 0x001B1E84 File Offset: 0x001B0084
	[CallerCount(0)]
	public unsafe string GetInformation(WeaponInformation.InformationType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref type;
		IntPtr returnedException;
		IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(WeaponInformation.NativeMethodInfoPtr_GetInformation_Public_String_InformationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	// Token: 0x06006C03 RID: 27651 RVA: 0x001B1EE4 File Offset: 0x001B00E4
	[CallerCount(0)]
	public unsafe float GetStatistic(WeaponInformation.InformationType type, bool normalized = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref type;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalized;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponInformation.NativeMethodInfoPtr_GetStatistic_Public_Single_InformationType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06006C04 RID: 27652 RVA: 0x001B1F5C File Offset: 0x001B015C
	[CallerCount(0)]
	public unsafe WeaponInformation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C05 RID: 27653 RVA: 0x001B1FA8 File Offset: 0x001B01A8
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponInformation()
	{
		Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponInformation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr);
		WeaponInformation.NativeFieldInfoPtr_WeaponSO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "WeaponSO");
		WeaponInformation.NativeFieldInfoPtr_WeaponName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "WeaponName");
		WeaponInformation.NativeFieldInfoPtr_ShortDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "ShortDescription");
		WeaponInformation.NativeFieldInfoPtr_LongDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "LongDescription");
		WeaponInformation.NativeFieldInfoPtr_FireModes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "FireModes");
		WeaponInformation.NativeFieldInfoPtr_MagazineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "MagazineType");
		WeaponInformation.NativeFieldInfoPtr_BoltType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "BoltType");
		WeaponInformation.NativeFieldInfoPtr_Caliber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "Caliber");
		WeaponInformation.NativeFieldInfoPtr_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "Faction");
		WeaponInformation.NativeFieldInfoPtr_FactionRaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "FactionRaw");
		WeaponInformation.NativeFieldInfoPtr_WeaponType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "WeaponType");
		WeaponInformation.NativeFieldInfoPtr_Damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "Damage");
		WeaponInformation.NativeFieldInfoPtr_Recoil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "Recoil");
		WeaponInformation.NativeFieldInfoPtr_RecoilForegripRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "RecoilForegripRatio");
		WeaponInformation.NativeFieldInfoPtr_RateOfFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "RateOfFire");
		WeaponInformation.NativeFieldInfoPtr_MagazineSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "MagazineSize");
		WeaponInformation.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "Range");
		WeaponInformation.NativeFieldInfoPtr_Penetration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "Penetration");
		WeaponInformation.NativeFieldInfoPtr_NormalizedDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "NormalizedDamage");
		WeaponInformation.NativeFieldInfoPtr_NormalizedRecoil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "NormalizedRecoil");
		WeaponInformation.NativeFieldInfoPtr_NormalizedRateOfFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "NormalizedRateOfFire");
		WeaponInformation.NativeFieldInfoPtr_NormalizedMagazineSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "NormalizedMagazineSize");
		WeaponInformation.NativeFieldInfoPtr_NormalizedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "NormalizedRange");
		WeaponInformation.NativeFieldInfoPtr_NormalizedPenetration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, "NormalizedPenetration");
		WeaponInformation.NativeMethodInfoPtr_get_WeightMovement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, 100671875);
		WeaponInformation.NativeMethodInfoPtr_get_NormalizedWeightMovement_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, 100671876);
		WeaponInformation.NativeMethodInfoPtr_GetInformation_Public_String_InformationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, 100671877);
		WeaponInformation.NativeMethodInfoPtr_GetStatistic_Public_Single_InformationType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, 100671878);
		WeaponInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr, 100671879);
	}

	// Token: 0x06006C06 RID: 27654 RVA: 0x00002988 File Offset: 0x00000B88
	public WeaponInformation(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17002664 RID: 9828
	// (get) Token: 0x06006C07 RID: 27655 RVA: 0x001B221C File Offset: 0x001B041C
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponInformation>.NativeClassPtr));
		}
	}

	// Token: 0x17002665 RID: 9829
	// (get) Token: 0x06006C08 RID: 27656 RVA: 0x001B2230 File Offset: 0x001B0430
	// (set) Token: 0x06006C09 RID: 27657 RVA: 0x001B2264 File Offset: 0x001B0464
	public unsafe WeaponSO WeaponSO
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_WeaponSO);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WeaponSO(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_WeaponSO), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002666 RID: 9830
	// (get) Token: 0x06006C0A RID: 27658 RVA: 0x001B228C File Offset: 0x001B048C
	// (set) Token: 0x06006C0B RID: 27659 RVA: 0x001B22B5 File Offset: 0x001B04B5
	public unsafe string WeaponName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_WeaponName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_WeaponName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17002667 RID: 9831
	// (get) Token: 0x06006C0C RID: 27660 RVA: 0x001B22DC File Offset: 0x001B04DC
	// (set) Token: 0x06006C0D RID: 27661 RVA: 0x001B2305 File Offset: 0x001B0505
	public unsafe string ShortDescription
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_ShortDescription);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_ShortDescription), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17002668 RID: 9832
	// (get) Token: 0x06006C0E RID: 27662 RVA: 0x001B232C File Offset: 0x001B052C
	// (set) Token: 0x06006C0F RID: 27663 RVA: 0x001B2355 File Offset: 0x001B0555
	public unsafe string LongDescription
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_LongDescription);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_LongDescription), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17002669 RID: 9833
	// (get) Token: 0x06006C10 RID: 27664 RVA: 0x001B237C File Offset: 0x001B057C
	// (set) Token: 0x06006C11 RID: 27665 RVA: 0x001B23A5 File Offset: 0x001B05A5
	public unsafe string FireModes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_FireModes);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_FireModes), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700266A RID: 9834
	// (get) Token: 0x06006C12 RID: 27666 RVA: 0x001B23CC File Offset: 0x001B05CC
	// (set) Token: 0x06006C13 RID: 27667 RVA: 0x001B23F5 File Offset: 0x001B05F5
	public unsafe string MagazineType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_MagazineType);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_MagazineType), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700266B RID: 9835
	// (get) Token: 0x06006C14 RID: 27668 RVA: 0x001B241C File Offset: 0x001B061C
	// (set) Token: 0x06006C15 RID: 27669 RVA: 0x001B2445 File Offset: 0x001B0645
	public unsafe string BoltType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_BoltType);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_BoltType), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700266C RID: 9836
	// (get) Token: 0x06006C16 RID: 27670 RVA: 0x001B246C File Offset: 0x001B066C
	// (set) Token: 0x06006C17 RID: 27671 RVA: 0x001B2495 File Offset: 0x001B0695
	public unsafe string Caliber
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_Caliber);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_Caliber), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700266D RID: 9837
	// (get) Token: 0x06006C18 RID: 27672 RVA: 0x001B24BC File Offset: 0x001B06BC
	// (set) Token: 0x06006C19 RID: 27673 RVA: 0x001B24E5 File Offset: 0x001B06E5
	public unsafe string Faction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_Faction);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_Faction), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700266E RID: 9838
	// (get) Token: 0x06006C1A RID: 27674 RVA: 0x001B250C File Offset: 0x001B070C
	// (set) Token: 0x06006C1B RID: 27675 RVA: 0x001B2534 File Offset: 0x001B0734
	public unsafe Faction FactionRaw
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_FactionRaw);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_FactionRaw)) = value;
		}
	}

	// Token: 0x1700266F RID: 9839
	// (get) Token: 0x06006C1C RID: 27676 RVA: 0x001B2558 File Offset: 0x001B0758
	// (set) Token: 0x06006C1D RID: 27677 RVA: 0x001B2581 File Offset: 0x001B0781
	public unsafe string WeaponType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_WeaponType);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_WeaponType), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17002670 RID: 9840
	// (get) Token: 0x06006C1E RID: 27678 RVA: 0x001B25A8 File Offset: 0x001B07A8
	// (set) Token: 0x06006C1F RID: 27679 RVA: 0x001B25D0 File Offset: 0x001B07D0
	public unsafe float Damage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_Damage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_Damage)) = value;
		}
	}

	// Token: 0x17002671 RID: 9841
	// (get) Token: 0x06006C20 RID: 27680 RVA: 0x001B25F4 File Offset: 0x001B07F4
	// (set) Token: 0x06006C21 RID: 27681 RVA: 0x001B261C File Offset: 0x001B081C
	public unsafe float Recoil
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_Recoil);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_Recoil)) = value;
		}
	}

	// Token: 0x17002672 RID: 9842
	// (get) Token: 0x06006C22 RID: 27682 RVA: 0x001B2640 File Offset: 0x001B0840
	// (set) Token: 0x06006C23 RID: 27683 RVA: 0x001B2668 File Offset: 0x001B0868
	public unsafe float RecoilForegripRatio
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_RecoilForegripRatio);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_RecoilForegripRatio)) = value;
		}
	}

	// Token: 0x17002673 RID: 9843
	// (get) Token: 0x06006C24 RID: 27684 RVA: 0x001B268C File Offset: 0x001B088C
	// (set) Token: 0x06006C25 RID: 27685 RVA: 0x001B26B4 File Offset: 0x001B08B4
	public unsafe float RateOfFire
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_RateOfFire);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_RateOfFire)) = value;
		}
	}

	// Token: 0x17002674 RID: 9844
	// (get) Token: 0x06006C26 RID: 27686 RVA: 0x001B26D8 File Offset: 0x001B08D8
	// (set) Token: 0x06006C27 RID: 27687 RVA: 0x001B2700 File Offset: 0x001B0900
	public unsafe float MagazineSize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_MagazineSize);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_MagazineSize)) = value;
		}
	}

	// Token: 0x17002675 RID: 9845
	// (get) Token: 0x06006C28 RID: 27688 RVA: 0x001B2724 File Offset: 0x001B0924
	// (set) Token: 0x06006C29 RID: 27689 RVA: 0x001B274C File Offset: 0x001B094C
	public unsafe float Range
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_Range);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_Range)) = value;
		}
	}

	// Token: 0x17002676 RID: 9846
	// (get) Token: 0x06006C2A RID: 27690 RVA: 0x001B2770 File Offset: 0x001B0970
	// (set) Token: 0x06006C2B RID: 27691 RVA: 0x001B2798 File Offset: 0x001B0998
	public unsafe float Penetration
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_Penetration);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_Penetration)) = value;
		}
	}

	// Token: 0x17002677 RID: 9847
	// (get) Token: 0x06006C2C RID: 27692 RVA: 0x001B27BC File Offset: 0x001B09BC
	// (set) Token: 0x06006C2D RID: 27693 RVA: 0x001B27E4 File Offset: 0x001B09E4
	public unsafe float NormalizedDamage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_NormalizedDamage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_NormalizedDamage)) = value;
		}
	}

	// Token: 0x17002678 RID: 9848
	// (get) Token: 0x06006C2E RID: 27694 RVA: 0x001B2808 File Offset: 0x001B0A08
	// (set) Token: 0x06006C2F RID: 27695 RVA: 0x001B2830 File Offset: 0x001B0A30
	public unsafe float NormalizedRecoil
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_NormalizedRecoil);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_NormalizedRecoil)) = value;
		}
	}

	// Token: 0x17002679 RID: 9849
	// (get) Token: 0x06006C30 RID: 27696 RVA: 0x001B2854 File Offset: 0x001B0A54
	// (set) Token: 0x06006C31 RID: 27697 RVA: 0x001B287C File Offset: 0x001B0A7C
	public unsafe float NormalizedRateOfFire
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_NormalizedRateOfFire);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_NormalizedRateOfFire)) = value;
		}
	}

	// Token: 0x1700267A RID: 9850
	// (get) Token: 0x06006C32 RID: 27698 RVA: 0x001B28A0 File Offset: 0x001B0AA0
	// (set) Token: 0x06006C33 RID: 27699 RVA: 0x001B28C8 File Offset: 0x001B0AC8
	public unsafe float NormalizedMagazineSize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_NormalizedMagazineSize);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_NormalizedMagazineSize)) = value;
		}
	}

	// Token: 0x1700267B RID: 9851
	// (get) Token: 0x06006C34 RID: 27700 RVA: 0x001B28EC File Offset: 0x001B0AEC
	// (set) Token: 0x06006C35 RID: 27701 RVA: 0x001B2914 File Offset: 0x001B0B14
	public unsafe float NormalizedRange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_NormalizedRange);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_NormalizedRange)) = value;
		}
	}

	// Token: 0x1700267C RID: 9852
	// (get) Token: 0x06006C36 RID: 27702 RVA: 0x001B2938 File Offset: 0x001B0B38
	// (set) Token: 0x06006C37 RID: 27703 RVA: 0x001B2960 File Offset: 0x001B0B60
	public unsafe float NormalizedPenetration
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_NormalizedPenetration);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponInformation.NativeFieldInfoPtr_NormalizedPenetration)) = value;
		}
	}

	// Token: 0x040044CF RID: 17615
	private static readonly IntPtr NativeFieldInfoPtr_WeaponSO;

	// Token: 0x040044D0 RID: 17616
	private static readonly IntPtr NativeFieldInfoPtr_WeaponName;

	// Token: 0x040044D1 RID: 17617
	private static readonly IntPtr NativeFieldInfoPtr_ShortDescription;

	// Token: 0x040044D2 RID: 17618
	private static readonly IntPtr NativeFieldInfoPtr_LongDescription;

	// Token: 0x040044D3 RID: 17619
	private static readonly IntPtr NativeFieldInfoPtr_FireModes;

	// Token: 0x040044D4 RID: 17620
	private static readonly IntPtr NativeFieldInfoPtr_MagazineType;

	// Token: 0x040044D5 RID: 17621
	private static readonly IntPtr NativeFieldInfoPtr_BoltType;

	// Token: 0x040044D6 RID: 17622
	private static readonly IntPtr NativeFieldInfoPtr_Caliber;

	// Token: 0x040044D7 RID: 17623
	private static readonly IntPtr NativeFieldInfoPtr_Faction;

	// Token: 0x040044D8 RID: 17624
	private static readonly IntPtr NativeFieldInfoPtr_FactionRaw;

	// Token: 0x040044D9 RID: 17625
	private static readonly IntPtr NativeFieldInfoPtr_WeaponType;

	// Token: 0x040044DA RID: 17626
	private static readonly IntPtr NativeFieldInfoPtr_Damage;

	// Token: 0x040044DB RID: 17627
	private static readonly IntPtr NativeFieldInfoPtr_Recoil;

	// Token: 0x040044DC RID: 17628
	private static readonly IntPtr NativeFieldInfoPtr_RecoilForegripRatio;

	// Token: 0x040044DD RID: 17629
	private static readonly IntPtr NativeFieldInfoPtr_RateOfFire;

	// Token: 0x040044DE RID: 17630
	private static readonly IntPtr NativeFieldInfoPtr_MagazineSize;

	// Token: 0x040044DF RID: 17631
	private static readonly IntPtr NativeFieldInfoPtr_Range;

	// Token: 0x040044E0 RID: 17632
	private static readonly IntPtr NativeFieldInfoPtr_Penetration;

	// Token: 0x040044E1 RID: 17633
	private static readonly IntPtr NativeFieldInfoPtr_NormalizedDamage;

	// Token: 0x040044E2 RID: 17634
	private static readonly IntPtr NativeFieldInfoPtr_NormalizedRecoil;

	// Token: 0x040044E3 RID: 17635
	private static readonly IntPtr NativeFieldInfoPtr_NormalizedRateOfFire;

	// Token: 0x040044E4 RID: 17636
	private static readonly IntPtr NativeFieldInfoPtr_NormalizedMagazineSize;

	// Token: 0x040044E5 RID: 17637
	private static readonly IntPtr NativeFieldInfoPtr_NormalizedRange;

	// Token: 0x040044E6 RID: 17638
	private static readonly IntPtr NativeFieldInfoPtr_NormalizedPenetration;

	// Token: 0x040044E7 RID: 17639
	private static readonly IntPtr NativeMethodInfoPtr_get_WeightMovement_Public_get_Single_0;

	// Token: 0x040044E8 RID: 17640
	private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedWeightMovement_Public_get_Single_0;

	// Token: 0x040044E9 RID: 17641
	private static readonly IntPtr NativeMethodInfoPtr_GetInformation_Public_String_InformationType_0;

	// Token: 0x040044EA RID: 17642
	private static readonly IntPtr NativeMethodInfoPtr_GetStatistic_Public_Single_InformationType_Boolean_0;

	// Token: 0x040044EB RID: 17643
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000528 RID: 1320
	public enum InformationType
	{
		// Token: 0x040044ED RID: 17645
		WeaponName,
		// Token: 0x040044EE RID: 17646
		ShortDescription,
		// Token: 0x040044EF RID: 17647
		LongDescription,
		// Token: 0x040044F0 RID: 17648
		FireModes,
		// Token: 0x040044F1 RID: 17649
		MagazineType,
		// Token: 0x040044F2 RID: 17650
		BoltType,
		// Token: 0x040044F3 RID: 17651
		Caliber,
		// Token: 0x040044F4 RID: 17652
		Faction,
		// Token: 0x040044F5 RID: 17653
		WeaponType,
		// Token: 0x040044F6 RID: 17654
		Damage,
		// Token: 0x040044F7 RID: 17655
		Recoil,
		// Token: 0x040044F8 RID: 17656
		RateOfFire,
		// Token: 0x040044F9 RID: 17657
		MagazineSize,
		// Token: 0x040044FA RID: 17658
		Range,
		// Token: 0x040044FB RID: 17659
		Penetration,
		// Token: 0x040044FC RID: 17660
		WeightMovement
	}
}
