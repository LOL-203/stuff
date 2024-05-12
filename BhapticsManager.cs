using System;
using Bhaptics.Tact.Unity;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x02000530 RID: 1328
public class BhapticsManager : Object
{
	// Token: 0x06006C83 RID: 27779 RVA: 0x001B3A14 File Offset: 0x001B1C14
	[CallerCount(0)]
	public unsafe static IHaptic GetHaptic()
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BhapticsManager.NativeMethodInfoPtr_GetHaptic_Public_Static_IHaptic_0, 0, (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IHaptic(intPtr2) : null;
	}

	// Token: 0x06006C84 RID: 27780 RVA: 0x001B3A5C File Offset: 0x001B1C5C
	[CallerCount(0)]
	public unsafe static void Initialize()
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BhapticsManager.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, 0, (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C85 RID: 27781 RVA: 0x001B3A90 File Offset: 0x001B1C90
	[CallerCount(0)]
	public unsafe static void Dispose()
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BhapticsManager.NativeMethodInfoPtr_Dispose_Public_Static_Void_0, 0, (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C86 RID: 27782 RVA: 0x001B3AC4 File Offset: 0x001B1CC4
	[CallerCount(0)]
	public unsafe BhapticsManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BhapticsManager>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BhapticsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C87 RID: 27783 RVA: 0x001B3B10 File Offset: 0x001B1D10
	// Note: this type is marked as 'beforefieldinit'.
	static BhapticsManager()
	{
		Il2CppClassPointerStore<BhapticsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BhapticsManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BhapticsManager>.NativeClassPtr);
		BhapticsManager.NativeFieldInfoPtr_Haptic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BhapticsManager>.NativeClassPtr, "Haptic");
		BhapticsManager.NativeFieldInfoPtr_Init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BhapticsManager>.NativeClassPtr, "Init");
		BhapticsManager.NativeMethodInfoPtr_GetHaptic_Public_Static_IHaptic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BhapticsManager>.NativeClassPtr, 100671903);
		BhapticsManager.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BhapticsManager>.NativeClassPtr, 100671904);
		BhapticsManager.NativeMethodInfoPtr_Dispose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BhapticsManager>.NativeClassPtr, 100671905);
		BhapticsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BhapticsManager>.NativeClassPtr, 100671906);
	}

	// Token: 0x06006C88 RID: 27784 RVA: 0x00002988 File Offset: 0x00000B88
	public BhapticsManager(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170026A0 RID: 9888
	// (get) Token: 0x06006C89 RID: 27785 RVA: 0x001B3BB8 File Offset: 0x001B1DB8
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BhapticsManager>.NativeClassPtr));
		}
	}

	// Token: 0x170026A1 RID: 9889
	// (get) Token: 0x06006C8A RID: 27786 RVA: 0x001B3BCC File Offset: 0x001B1DCC
	// (set) Token: 0x06006C8B RID: 27787 RVA: 0x001B3BF7 File Offset: 0x001B1DF7
	public unsafe static IHaptic Haptic
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(BhapticsManager.NativeFieldInfoPtr_Haptic, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IHaptic(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BhapticsManager.NativeFieldInfoPtr_Haptic, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170026A2 RID: 9890
	// (get) Token: 0x06006C8C RID: 27788 RVA: 0x001B3C0C File Offset: 0x001B1E0C
	// (set) Token: 0x06006C8D RID: 27789 RVA: 0x001B3C2A File Offset: 0x001B1E2A
	public unsafe static bool Init
	{
		get
		{
			bool result;
			IL2CPP.il2cpp_field_static_get_value(BhapticsManager.NativeFieldInfoPtr_Init, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BhapticsManager.NativeFieldInfoPtr_Init, (void*)(&value));
		}
	}

	// Token: 0x04004567 RID: 17767
	private static readonly IntPtr NativeFieldInfoPtr_Haptic;

	// Token: 0x04004568 RID: 17768
	private static readonly IntPtr NativeFieldInfoPtr_Init;

	// Token: 0x04004569 RID: 17769
	private static readonly IntPtr NativeMethodInfoPtr_GetHaptic_Public_Static_IHaptic_0;

	// Token: 0x0400456A RID: 17770
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

	// Token: 0x0400456B RID: 17771
	private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Static_Void_0;

	// Token: 0x0400456C RID: 17772
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
