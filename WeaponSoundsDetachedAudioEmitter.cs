using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200015F RID: 351
public class WeaponSoundsDetachedAudioEmitter : MonoBehaviour
{
	// Token: 0x060017CC RID: 6092 RVA: 0x0005FAD4 File Offset: 0x0005DCD4
	[CallerCount(0)]
	public unsafe void Initialize(WeaponName weaponName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref weaponName;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSoundsDetachedAudioEmitter.NativeMethodInfoPtr_Initialize_Public_Void_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x0005FB28 File Offset: 0x0005DD28
	[CallerCount(0)]
	public unsafe void StartDelayedDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSoundsDetachedAudioEmitter.NativeMethodInfoPtr_StartDelayedDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017CE RID: 6094 RVA: 0x0005FB6C File Offset: 0x0005DD6C
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSoundsDetachedAudioEmitter.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x0005FBB0 File Offset: 0x0005DDB0
	[CallerCount(0)]
	public unsafe WeaponSoundsDetachedAudioEmitter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponSoundsDetachedAudioEmitter>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSoundsDetachedAudioEmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x0005FBFC File Offset: 0x0005DDFC
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponSoundsDetachedAudioEmitter()
	{
		Il2CppClassPointerStore<WeaponSoundsDetachedAudioEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponSoundsDetachedAudioEmitter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponSoundsDetachedAudioEmitter>.NativeClassPtr);
		WeaponSoundsDetachedAudioEmitter.NativeFieldInfoPtr_loadedWeaponName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSoundsDetachedAudioEmitter>.NativeClassPtr, "loadedWeaponName");
		WeaponSoundsDetachedAudioEmitter.NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSoundsDetachedAudioEmitter>.NativeClassPtr, "isInitialized");
		WeaponSoundsDetachedAudioEmitter.NativeFieldInfoPtr_DESTROY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSoundsDetachedAudioEmitter>.NativeClassPtr, "DESTROY_TIME");
		WeaponSoundsDetachedAudioEmitter.NativeMethodInfoPtr_Initialize_Public_Void_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSoundsDetachedAudioEmitter>.NativeClassPtr, 100665206);
		WeaponSoundsDetachedAudioEmitter.NativeMethodInfoPtr_StartDelayedDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSoundsDetachedAudioEmitter>.NativeClassPtr, 100665207);
		WeaponSoundsDetachedAudioEmitter.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSoundsDetachedAudioEmitter>.NativeClassPtr, 100665208);
		WeaponSoundsDetachedAudioEmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSoundsDetachedAudioEmitter>.NativeClassPtr, 100665209);
	}

	// Token: 0x060017D1 RID: 6097 RVA: 0x0000210C File Offset: 0x0000030C
	public WeaponSoundsDetachedAudioEmitter(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000835 RID: 2101
	// (get) Token: 0x060017D2 RID: 6098 RVA: 0x0005FCB8 File Offset: 0x0005DEB8
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponSoundsDetachedAudioEmitter>.NativeClassPtr));
		}
	}

	// Token: 0x17000836 RID: 2102
	// (get) Token: 0x060017D3 RID: 6099 RVA: 0x0005FCCC File Offset: 0x0005DECC
	// (set) Token: 0x060017D4 RID: 6100 RVA: 0x0005FCF4 File Offset: 0x0005DEF4
	public unsafe WeaponName loadedWeaponName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSoundsDetachedAudioEmitter.NativeFieldInfoPtr_loadedWeaponName);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSoundsDetachedAudioEmitter.NativeFieldInfoPtr_loadedWeaponName)) = value;
		}
	}

	// Token: 0x17000837 RID: 2103
	// (get) Token: 0x060017D5 RID: 6101 RVA: 0x0005FD18 File Offset: 0x0005DF18
	// (set) Token: 0x060017D6 RID: 6102 RVA: 0x0005FD40 File Offset: 0x0005DF40
	public unsafe bool isInitialized
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSoundsDetachedAudioEmitter.NativeFieldInfoPtr_isInitialized);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSoundsDetachedAudioEmitter.NativeFieldInfoPtr_isInitialized)) = value;
		}
	}

	// Token: 0x17000838 RID: 2104
	// (get) Token: 0x060017D7 RID: 6103 RVA: 0x0005FD64 File Offset: 0x0005DF64
	// (set) Token: 0x060017D8 RID: 6104 RVA: 0x0005FD82 File Offset: 0x0005DF82
	public unsafe static float DESTROY_TIME
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(WeaponSoundsDetachedAudioEmitter.NativeFieldInfoPtr_DESTROY_TIME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WeaponSoundsDetachedAudioEmitter.NativeFieldInfoPtr_DESTROY_TIME, (void*)(&value));
		}
	}

	// Token: 0x04000F31 RID: 3889
	private static readonly IntPtr NativeFieldInfoPtr_loadedWeaponName;

	// Token: 0x04000F32 RID: 3890
	private static readonly IntPtr NativeFieldInfoPtr_isInitialized;

	// Token: 0x04000F33 RID: 3891
	private static readonly IntPtr NativeFieldInfoPtr_DESTROY_TIME;

	// Token: 0x04000F34 RID: 3892
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_WeaponName_0;

	// Token: 0x04000F35 RID: 3893
	private static readonly IntPtr NativeMethodInfoPtr_StartDelayedDestroy_Public_Void_0;

	// Token: 0x04000F36 RID: 3894
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000F37 RID: 3895
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
