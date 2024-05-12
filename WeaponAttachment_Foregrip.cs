using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x0200051E RID: 1310
public class WeaponAttachment_Foregrip : WeaponAttachment
{
	// Token: 0x06006B44 RID: 27460 RVA: 0x001AF10C File Offset: 0x001AD30C
	[CallerCount(0)]
	public new unsafe void Initialize(Pickup_Gun gun)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gun);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponAttachment_Foregrip.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B45 RID: 27461 RVA: 0x001AF170 File Offset: 0x001AD370
	[CallerCount(0)]
	public unsafe WeaponAttachment_Foregrip() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponAttachment_Foregrip>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Foregrip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B46 RID: 27462 RVA: 0x001AF1BC File Offset: 0x001AD3BC
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponAttachment_Foregrip()
	{
		Il2CppClassPointerStore<WeaponAttachment_Foregrip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponAttachment_Foregrip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponAttachment_Foregrip>.NativeClassPtr);
		WeaponAttachment_Foregrip.NativeFieldInfoPtr_WeaponGrip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Foregrip>.NativeClassPtr, "WeaponGrip");
		WeaponAttachment_Foregrip.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Foregrip>.NativeClassPtr, 100671821);
		WeaponAttachment_Foregrip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Foregrip>.NativeClassPtr, 100671822);
	}

	// Token: 0x06006B47 RID: 27463 RVA: 0x001AF228 File Offset: 0x001AD428
	public WeaponAttachment_Foregrip(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17002621 RID: 9761
	// (get) Token: 0x06006B48 RID: 27464 RVA: 0x001AF231 File Offset: 0x001AD431
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponAttachment_Foregrip>.NativeClassPtr));
		}
	}

	// Token: 0x17002622 RID: 9762
	// (get) Token: 0x06006B49 RID: 27465 RVA: 0x001AF244 File Offset: 0x001AD444
	// (set) Token: 0x06006B4A RID: 27466 RVA: 0x001AF278 File Offset: 0x001AD478
	public unsafe Interactable_WeaponGrip WeaponGrip
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Foregrip.NativeFieldInfoPtr_WeaponGrip);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Interactable_WeaponGrip(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Foregrip.NativeFieldInfoPtr_WeaponGrip), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400445E RID: 17502
	private static readonly IntPtr NativeFieldInfoPtr_WeaponGrip;

	// Token: 0x0400445F RID: 17503
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0;

	// Token: 0x04004460 RID: 17504
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
