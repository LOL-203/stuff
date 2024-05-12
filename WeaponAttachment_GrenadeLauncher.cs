using System;
using AK.Wwise;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x0200051F RID: 1311
public class WeaponAttachment_GrenadeLauncher : WeaponAttachment
{
	// Token: 0x06006B4B RID: 27467 RVA: 0x001AF2A0 File Offset: 0x001AD4A0
	[CallerCount(0)]
	public new unsafe void Initialize(Pickup_Gun gun)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gun);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponAttachment_GrenadeLauncher.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B4C RID: 27468 RVA: 0x001AF304 File Offset: 0x001AD504
	[CallerCount(0)]
	public unsafe WeaponAttachment_GrenadeLauncher() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponAttachment_GrenadeLauncher>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_GrenadeLauncher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B4D RID: 27469 RVA: 0x001AF350 File Offset: 0x001AD550
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponAttachment_GrenadeLauncher()
	{
		Il2CppClassPointerStore<WeaponAttachment_GrenadeLauncher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponAttachment_GrenadeLauncher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponAttachment_GrenadeLauncher>.NativeClassPtr);
		WeaponAttachment_GrenadeLauncher.NativeFieldInfoPtr_AlternateFireSoundPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_GrenadeLauncher>.NativeClassPtr, "AlternateFireSoundPlayEvent");
		WeaponAttachment_GrenadeLauncher.NativeFieldInfoPtr_GrenadeLauncherInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_GrenadeLauncher>.NativeClassPtr, "GrenadeLauncherInteractable");
		WeaponAttachment_GrenadeLauncher.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_GrenadeLauncher>.NativeClassPtr, 100671823);
		WeaponAttachment_GrenadeLauncher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_GrenadeLauncher>.NativeClassPtr, 100671824);
	}

	// Token: 0x06006B4E RID: 27470 RVA: 0x001AF228 File Offset: 0x001AD428
	public WeaponAttachment_GrenadeLauncher(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17002623 RID: 9763
	// (get) Token: 0x06006B4F RID: 27471 RVA: 0x001AF3D0 File Offset: 0x001AD5D0
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponAttachment_GrenadeLauncher>.NativeClassPtr));
		}
	}

	// Token: 0x17002624 RID: 9764
	// (get) Token: 0x06006B50 RID: 27472 RVA: 0x001AF3E4 File Offset: 0x001AD5E4
	// (set) Token: 0x06006B51 RID: 27473 RVA: 0x001AF418 File Offset: 0x001AD618
	public unsafe Event AlternateFireSoundPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_GrenadeLauncher.NativeFieldInfoPtr_AlternateFireSoundPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_GrenadeLauncher.NativeFieldInfoPtr_AlternateFireSoundPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002625 RID: 9765
	// (get) Token: 0x06006B52 RID: 27474 RVA: 0x001AF440 File Offset: 0x001AD640
	// (set) Token: 0x06006B53 RID: 27475 RVA: 0x001AF474 File Offset: 0x001AD674
	public unsafe Interactable_GrenadeLauncher GrenadeLauncherInteractable
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_GrenadeLauncher.NativeFieldInfoPtr_GrenadeLauncherInteractable);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Interactable_GrenadeLauncher(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_GrenadeLauncher.NativeFieldInfoPtr_GrenadeLauncherInteractable), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04004461 RID: 17505
	private static readonly IntPtr NativeFieldInfoPtr_AlternateFireSoundPlayEvent;

	// Token: 0x04004462 RID: 17506
	private static readonly IntPtr NativeFieldInfoPtr_GrenadeLauncherInteractable;

	// Token: 0x04004463 RID: 17507
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0;

	// Token: 0x04004464 RID: 17508
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
