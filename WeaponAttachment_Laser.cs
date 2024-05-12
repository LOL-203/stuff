using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000520 RID: 1312
public class WeaponAttachment_Laser : WeaponAttachment
{
	// Token: 0x06006B54 RID: 27476 RVA: 0x001AF49C File Offset: 0x001AD69C
	[CallerCount(0)]
	public new unsafe void Initialize(Pickup_Gun gun)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gun);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponAttachment_Laser.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B55 RID: 27477 RVA: 0x001AF500 File Offset: 0x001AD700
	[CallerCount(0)]
	public new unsafe void Uninitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponAttachment_Laser.NativeMethodInfoPtr_Uninitialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B56 RID: 27478 RVA: 0x001AF550 File Offset: 0x001AD750
	[CallerCount(0)]
	public unsafe void RefreshLoad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Laser.NativeMethodInfoPtr_RefreshLoad_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B57 RID: 27479 RVA: 0x001AF594 File Offset: 0x001AD794
	[CallerCount(0)]
	public new unsafe void ConfigureToggleObjects(WeaponAttachmentToggleState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref state;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponAttachment_Laser.NativeMethodInfoPtr_ConfigureToggleObjects_Protected_Virtual_Void_WeaponAttachmentToggleState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B58 RID: 27480 RVA: 0x001AF5F4 File Offset: 0x001AD7F4
	[CallerCount(0)]
	public unsafe WeaponAttachment_Laser() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponAttachment_Laser>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Laser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B59 RID: 27481 RVA: 0x001AF640 File Offset: 0x001AD840
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponAttachment_Laser()
	{
		Il2CppClassPointerStore<WeaponAttachment_Laser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponAttachment_Laser");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponAttachment_Laser>.NativeClassPtr);
		WeaponAttachment_Laser.NativeFieldInfoPtr_Laser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Laser>.NativeClassPtr, "Laser");
		WeaponAttachment_Laser.NativeFieldInfoPtr_MarsocColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Laser>.NativeClassPtr, "MarsocColor");
		WeaponAttachment_Laser.NativeFieldInfoPtr_VolkColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Laser>.NativeClassPtr, "VolkColor");
		WeaponAttachment_Laser.NativeFieldInfoPtr_loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Laser>.NativeClassPtr, "loaded");
		WeaponAttachment_Laser.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Laser>.NativeClassPtr, 100671825);
		WeaponAttachment_Laser.NativeMethodInfoPtr_Uninitialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Laser>.NativeClassPtr, 100671826);
		WeaponAttachment_Laser.NativeMethodInfoPtr_RefreshLoad_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Laser>.NativeClassPtr, 100671827);
		WeaponAttachment_Laser.NativeMethodInfoPtr_ConfigureToggleObjects_Protected_Virtual_Void_WeaponAttachmentToggleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Laser>.NativeClassPtr, 100671828);
		WeaponAttachment_Laser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Laser>.NativeClassPtr, 100671829);
	}

	// Token: 0x06006B5A RID: 27482 RVA: 0x001AF228 File Offset: 0x001AD428
	public WeaponAttachment_Laser(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17002626 RID: 9766
	// (get) Token: 0x06006B5B RID: 27483 RVA: 0x001AF724 File Offset: 0x001AD924
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponAttachment_Laser>.NativeClassPtr));
		}
	}

	// Token: 0x17002627 RID: 9767
	// (get) Token: 0x06006B5C RID: 27484 RVA: 0x001AF738 File Offset: 0x001AD938
	// (set) Token: 0x06006B5D RID: 27485 RVA: 0x001AF76C File Offset: 0x001AD96C
	public unsafe BasicLaser_v2 Laser
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Laser.NativeFieldInfoPtr_Laser);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new BasicLaser_v2(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Laser.NativeFieldInfoPtr_Laser), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002628 RID: 9768
	// (get) Token: 0x06006B5E RID: 27486 RVA: 0x001AF794 File Offset: 0x001AD994
	// (set) Token: 0x06006B5F RID: 27487 RVA: 0x001AF7BC File Offset: 0x001AD9BC
	public unsafe Color MarsocColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Laser.NativeFieldInfoPtr_MarsocColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Laser.NativeFieldInfoPtr_MarsocColor)) = value;
		}
	}

	// Token: 0x17002629 RID: 9769
	// (get) Token: 0x06006B60 RID: 27488 RVA: 0x001AF7E0 File Offset: 0x001AD9E0
	// (set) Token: 0x06006B61 RID: 27489 RVA: 0x001AF808 File Offset: 0x001ADA08
	public unsafe Color VolkColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Laser.NativeFieldInfoPtr_VolkColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Laser.NativeFieldInfoPtr_VolkColor)) = value;
		}
	}

	// Token: 0x1700262A RID: 9770
	// (get) Token: 0x06006B62 RID: 27490 RVA: 0x001AF82C File Offset: 0x001ADA2C
	// (set) Token: 0x06006B63 RID: 27491 RVA: 0x001AF854 File Offset: 0x001ADA54
	public unsafe bool loaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Laser.NativeFieldInfoPtr_loaded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Laser.NativeFieldInfoPtr_loaded)) = value;
		}
	}

	// Token: 0x04004465 RID: 17509
	private static readonly IntPtr NativeFieldInfoPtr_Laser;

	// Token: 0x04004466 RID: 17510
	private static readonly IntPtr NativeFieldInfoPtr_MarsocColor;

	// Token: 0x04004467 RID: 17511
	private static readonly IntPtr NativeFieldInfoPtr_VolkColor;

	// Token: 0x04004468 RID: 17512
	private static readonly IntPtr NativeFieldInfoPtr_loaded;

	// Token: 0x04004469 RID: 17513
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0;

	// Token: 0x0400446A RID: 17514
	private static readonly IntPtr NativeMethodInfoPtr_Uninitialize_Public_Virtual_Void_0;

	// Token: 0x0400446B RID: 17515
	private static readonly IntPtr NativeMethodInfoPtr_RefreshLoad_Protected_Void_0;

	// Token: 0x0400446C RID: 17516
	private static readonly IntPtr NativeMethodInfoPtr_ConfigureToggleObjects_Protected_Virtual_Void_WeaponAttachmentToggleState_0;

	// Token: 0x0400446D RID: 17517
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
