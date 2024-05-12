using System;
using Bhaptics.Tact.Unity;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200052D RID: 1325
public class BhapticsConfig : ScriptableObject
{
	// Token: 0x06006C6E RID: 27758 RVA: 0x001B35C8 File Offset: 0x001B17C8
	[CallerCount(0)]
	public unsafe BhapticsConfig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BhapticsConfig>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BhapticsConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C6F RID: 27759 RVA: 0x001B3614 File Offset: 0x001B1814
	// Note: this type is marked as 'beforefieldinit'.
	static BhapticsConfig()
	{
		Il2CppClassPointerStore<BhapticsConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BhapticsConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BhapticsConfig>.NativeClassPtr);
		BhapticsConfig.NativeFieldInfoPtr_launchPlayerIfNotRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BhapticsConfig>.NativeClassPtr, "launchPlayerIfNotRunning");
		BhapticsConfig.NativeFieldInfoPtr_AndroidManagerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BhapticsConfig>.NativeClassPtr, "AndroidManagerPrefab");
		BhapticsConfig.NativeFieldInfoPtr_UseOnlyBackgroundMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BhapticsConfig>.NativeClassPtr, "UseOnlyBackgroundMode");
		BhapticsConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BhapticsConfig>.NativeClassPtr, 100671897);
	}

	// Token: 0x06006C70 RID: 27760 RVA: 0x0002DD3C File Offset: 0x0002BF3C
	public BhapticsConfig(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17002699 RID: 9881
	// (get) Token: 0x06006C71 RID: 27761 RVA: 0x001B3694 File Offset: 0x001B1894
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BhapticsConfig>.NativeClassPtr));
		}
	}

	// Token: 0x1700269A RID: 9882
	// (get) Token: 0x06006C72 RID: 27762 RVA: 0x001B36A8 File Offset: 0x001B18A8
	// (set) Token: 0x06006C73 RID: 27763 RVA: 0x001B36D0 File Offset: 0x001B18D0
	public unsafe bool launchPlayerIfNotRunning
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BhapticsConfig.NativeFieldInfoPtr_launchPlayerIfNotRunning);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BhapticsConfig.NativeFieldInfoPtr_launchPlayerIfNotRunning)) = value;
		}
	}

	// Token: 0x1700269B RID: 9883
	// (get) Token: 0x06006C74 RID: 27764 RVA: 0x001B36F4 File Offset: 0x001B18F4
	// (set) Token: 0x06006C75 RID: 27765 RVA: 0x001B3728 File Offset: 0x001B1928
	public unsafe BhapticsAndroidManager AndroidManagerPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BhapticsConfig.NativeFieldInfoPtr_AndroidManagerPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new BhapticsAndroidManager(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BhapticsConfig.NativeFieldInfoPtr_AndroidManagerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700269C RID: 9884
	// (get) Token: 0x06006C76 RID: 27766 RVA: 0x001B3750 File Offset: 0x001B1950
	// (set) Token: 0x06006C77 RID: 27767 RVA: 0x001B3778 File Offset: 0x001B1978
	public unsafe bool UseOnlyBackgroundMode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BhapticsConfig.NativeFieldInfoPtr_UseOnlyBackgroundMode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BhapticsConfig.NativeFieldInfoPtr_UseOnlyBackgroundMode)) = value;
		}
	}

	// Token: 0x0400455A RID: 17754
	private static readonly IntPtr NativeFieldInfoPtr_launchPlayerIfNotRunning;

	// Token: 0x0400455B RID: 17755
	private static readonly IntPtr NativeFieldInfoPtr_AndroidManagerPrefab;

	// Token: 0x0400455C RID: 17756
	private static readonly IntPtr NativeFieldInfoPtr_UseOnlyBackgroundMode;

	// Token: 0x0400455D RID: 17757
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
