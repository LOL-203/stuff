using System;
using AK.Wwise;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x02000130 RID: 304
public class AreaGlobalAmbient : AreaVolume
{
	// Token: 0x0600134B RID: 4939 RVA: 0x0004E204 File Offset: 0x0004C404
	[CallerCount(0)]
	public unsafe AreaGlobalAmbient() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaGlobalAmbient>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AreaGlobalAmbient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x0004E250 File Offset: 0x0004C450
	// Note: this type is marked as 'beforefieldinit'.
	static AreaGlobalAmbient()
	{
		Il2CppClassPointerStore<AreaGlobalAmbient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AreaGlobalAmbient");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaGlobalAmbient>.NativeClassPtr);
		AreaGlobalAmbient.NativeFieldInfoPtr_AmbientState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaGlobalAmbient>.NativeClassPtr, "AmbientState");
		AreaGlobalAmbient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaGlobalAmbient>.NativeClassPtr, 100664906);
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x0004E2A8 File Offset: 0x0004C4A8
	public AreaGlobalAmbient(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000688 RID: 1672
	// (get) Token: 0x0600134E RID: 4942 RVA: 0x0004E2B1 File Offset: 0x0004C4B1
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AreaGlobalAmbient>.NativeClassPtr));
		}
	}

	// Token: 0x17000689 RID: 1673
	// (get) Token: 0x0600134F RID: 4943 RVA: 0x0004E2C4 File Offset: 0x0004C4C4
	// (set) Token: 0x06001350 RID: 4944 RVA: 0x0004E2F8 File Offset: 0x0004C4F8
	public unsafe State AmbientState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaGlobalAmbient.NativeFieldInfoPtr_AmbientState);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new State(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaGlobalAmbient.NativeFieldInfoPtr_AmbientState), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000C52 RID: 3154
	private static readonly IntPtr NativeFieldInfoPtr_AmbientState;

	// Token: 0x04000C53 RID: 3155
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
