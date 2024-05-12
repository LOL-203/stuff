using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000522 RID: 1314
public sealed class WeaponAttachment_Sight_Holo : WeaponAttachment_Sight
{
	// Token: 0x06006B8F RID: 27535 RVA: 0x001B0460 File Offset: 0x001AE660
	[CallerCount(0)]
	public new unsafe void Initialize(Pickup_Gun gun)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gun);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight_Holo.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B90 RID: 27536 RVA: 0x001B04BC File Offset: 0x001AE6BC
	[CallerCount(0)]
	public new unsafe void Uninitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight_Holo.NativeMethodInfoPtr_Uninitialize_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B91 RID: 27537 RVA: 0x001B0500 File Offset: 0x001AE700
	[CallerCount(0)]
	public unsafe void M_gunOnEventStopEquip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight_Holo.NativeMethodInfoPtr_M_gunOnEventStopEquip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B92 RID: 27538 RVA: 0x001B0544 File Offset: 0x001AE744
	[CallerCount(0)]
	public unsafe void M_gunOnEventStartEquip(Pickup obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight_Holo.NativeMethodInfoPtr_M_gunOnEventStartEquip_Private_Void_Pickup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B93 RID: 27539 RVA: 0x001B05A0 File Offset: 0x001AE7A0
	[CallerCount(0)]
	public unsafe void SetLenses(bool active)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref active;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight_Holo.NativeMethodInfoPtr_SetLenses_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B94 RID: 27540 RVA: 0x001B05F4 File Offset: 0x001AE7F4
	[CallerCount(0)]
	public unsafe WeaponAttachment_Sight_Holo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponAttachment_Sight_Holo>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight_Holo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B95 RID: 27541 RVA: 0x001B0640 File Offset: 0x001AE840
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponAttachment_Sight_Holo()
	{
		Il2CppClassPointerStore<WeaponAttachment_Sight_Holo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponAttachment_Sight_Holo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponAttachment_Sight_Holo>.NativeClassPtr);
		WeaponAttachment_Sight_Holo.NativeFieldInfoPtr_Lenses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Sight_Holo>.NativeClassPtr, "Lenses");
		WeaponAttachment_Sight_Holo.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight_Holo>.NativeClassPtr, 100671851);
		WeaponAttachment_Sight_Holo.NativeMethodInfoPtr_Uninitialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight_Holo>.NativeClassPtr, 100671852);
		WeaponAttachment_Sight_Holo.NativeMethodInfoPtr_M_gunOnEventStopEquip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight_Holo>.NativeClassPtr, 100671853);
		WeaponAttachment_Sight_Holo.NativeMethodInfoPtr_M_gunOnEventStartEquip_Private_Void_Pickup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight_Holo>.NativeClassPtr, 100671854);
		WeaponAttachment_Sight_Holo.NativeMethodInfoPtr_SetLenses_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight_Holo>.NativeClassPtr, 100671855);
		WeaponAttachment_Sight_Holo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight_Holo>.NativeClassPtr, 100671856);
	}

	// Token: 0x06006B96 RID: 27542 RVA: 0x001B06FC File Offset: 0x001AE8FC
	public WeaponAttachment_Sight_Holo(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17002639 RID: 9785
	// (get) Token: 0x06006B97 RID: 27543 RVA: 0x001B0705 File Offset: 0x001AE905
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponAttachment_Sight_Holo>.NativeClassPtr));
		}
	}

	// Token: 0x1700263A RID: 9786
	// (get) Token: 0x06006B98 RID: 27544 RVA: 0x001B0718 File Offset: 0x001AE918
	// (set) Token: 0x06006B99 RID: 27545 RVA: 0x001B074C File Offset: 0x001AE94C
	public unsafe Il2CppReferenceArray<GameObject> Lenses
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight_Holo.NativeFieldInfoPtr_Lenses);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight_Holo.NativeFieldInfoPtr_Lenses), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400448C RID: 17548
	private static readonly IntPtr NativeFieldInfoPtr_Lenses;

	// Token: 0x0400448D RID: 17549
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0;

	// Token: 0x0400448E RID: 17550
	private static readonly IntPtr NativeMethodInfoPtr_Uninitialize_Public_Virtual_Void_0;

	// Token: 0x0400448F RID: 17551
	private static readonly IntPtr NativeMethodInfoPtr_M_gunOnEventStopEquip_Private_Void_0;

	// Token: 0x04004490 RID: 17552
	private static readonly IntPtr NativeMethodInfoPtr_M_gunOnEventStartEquip_Private_Void_Pickup_0;

	// Token: 0x04004491 RID: 17553
	private static readonly IntPtr NativeMethodInfoPtr_SetLenses_Private_Void_Boolean_0;

	// Token: 0x04004492 RID: 17554
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
