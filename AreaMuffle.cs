using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x02000131 RID: 305
public class AreaMuffle : AreaVolume
{
	// Token: 0x06001351 RID: 4945 RVA: 0x0004E320 File Offset: 0x0004C520
	[CallerCount(0)]
	public unsafe AreaMuffle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaMuffle>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AreaMuffle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001352 RID: 4946 RVA: 0x0004E36C File Offset: 0x0004C56C
	// Note: this type is marked as 'beforefieldinit'.
	static AreaMuffle()
	{
		Il2CppClassPointerStore<AreaMuffle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AreaMuffle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaMuffle>.NativeClassPtr);
		AreaMuffle.NativeFieldInfoPtr_GroupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaMuffle>.NativeClassPtr, "GroupId");
		AreaMuffle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaMuffle>.NativeClassPtr, 100664907);
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x0004E2A8 File Offset: 0x0004C4A8
	public AreaMuffle(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700068A RID: 1674
	// (get) Token: 0x06001354 RID: 4948 RVA: 0x0004E3C4 File Offset: 0x0004C5C4
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AreaMuffle>.NativeClassPtr));
		}
	}

	// Token: 0x1700068B RID: 1675
	// (get) Token: 0x06001355 RID: 4949 RVA: 0x0004E3D8 File Offset: 0x0004C5D8
	// (set) Token: 0x06001356 RID: 4950 RVA: 0x0004E400 File Offset: 0x0004C600
	public unsafe int GroupId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaMuffle.NativeFieldInfoPtr_GroupId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaMuffle.NativeFieldInfoPtr_GroupId)) = value;
		}
	}

	// Token: 0x04000C54 RID: 3156
	private static readonly IntPtr NativeFieldInfoPtr_GroupId;

	// Token: 0x04000C55 RID: 3157
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
