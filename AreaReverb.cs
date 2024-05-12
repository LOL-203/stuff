using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x02000132 RID: 306
public class AreaReverb : AreaVolume
{
	// Token: 0x06001357 RID: 4951 RVA: 0x0004E424 File Offset: 0x0004C624
	[CallerCount(0)]
	public unsafe void OnDrawGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AreaReverb.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001358 RID: 4952 RVA: 0x0004E468 File Offset: 0x0004C668
	[CallerCount(0)]
	public unsafe AreaReverb() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaReverb>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AreaReverb.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001359 RID: 4953 RVA: 0x0004E4B4 File Offset: 0x0004C6B4
	// Note: this type is marked as 'beforefieldinit'.
	static AreaReverb()
	{
		Il2CppClassPointerStore<AreaReverb>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AreaReverb");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaReverb>.NativeClassPtr);
		AreaReverb.NativeFieldInfoPtr_ReverbBus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaReverb>.NativeClassPtr, "ReverbBus");
		AreaReverb.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaReverb>.NativeClassPtr, 100664908);
		AreaReverb.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaReverb>.NativeClassPtr, 100664909);
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x0004E2A8 File Offset: 0x0004C4A8
	public AreaReverb(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700068C RID: 1676
	// (get) Token: 0x0600135B RID: 4955 RVA: 0x0004E520 File Offset: 0x0004C720
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AreaReverb>.NativeClassPtr));
		}
	}

	// Token: 0x1700068D RID: 1677
	// (get) Token: 0x0600135C RID: 4956 RVA: 0x0004E534 File Offset: 0x0004C734
	// (set) Token: 0x0600135D RID: 4957 RVA: 0x0004E55C File Offset: 0x0004C75C
	public unsafe AudioManager.ReverbBusType ReverbBus
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaReverb.NativeFieldInfoPtr_ReverbBus);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaReverb.NativeFieldInfoPtr_ReverbBus)) = value;
		}
	}

	// Token: 0x04000C56 RID: 3158
	private static readonly IntPtr NativeFieldInfoPtr_ReverbBus;

	// Token: 0x04000C57 RID: 3159
	private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

	// Token: 0x04000C58 RID: 3160
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
