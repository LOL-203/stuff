using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020000CA RID: 202
public sealed class WaitForSecondsNetwork : CustomYieldInstruction
{
	// Token: 0x17000461 RID: 1121
	// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00033428 File Offset: 0x00031628
	public new unsafe bool keepWaiting
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WaitForSecondsNetwork.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x00033478 File Offset: 0x00031678
	[CallerCount(0)]
	public unsafe void ResetTime(double seconds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref seconds;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSecondsNetwork.NativeMethodInfoPtr_ResetTime_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x000334CC File Offset: 0x000316CC
	[CallerCount(0)]
	public unsafe WaitForSecondsNetwork() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSecondsNetwork>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSecondsNetwork.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x00033518 File Offset: 0x00031718
	// Note: this type is marked as 'beforefieldinit'.
	static WaitForSecondsNetwork()
	{
		Il2CppClassPointerStore<WaitForSecondsNetwork>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WaitForSecondsNetwork");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSecondsNetwork>.NativeClassPtr);
		WaitForSecondsNetwork.NativeFieldInfoPtr_WaitingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSecondsNetwork>.NativeClassPtr, "WaitingTime");
		WaitForSecondsNetwork.NativeFieldInfoPtr_KeepWaitingResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSecondsNetwork>.NativeClassPtr, "KeepWaitingResult");
		WaitForSecondsNetwork.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsNetwork>.NativeClassPtr, 100664278);
		WaitForSecondsNetwork.NativeMethodInfoPtr_ResetTime_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsNetwork>.NativeClassPtr, 100664279);
		WaitForSecondsNetwork.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsNetwork>.NativeClassPtr, 100664280);
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x000335AC File Offset: 0x000317AC
	public WaitForSecondsNetwork(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700045E RID: 1118
	// (get) Token: 0x06000CAA RID: 3242 RVA: 0x000335B5 File Offset: 0x000317B5
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WaitForSecondsNetwork>.NativeClassPtr));
		}
	}

	// Token: 0x1700045F RID: 1119
	// (get) Token: 0x06000CAB RID: 3243 RVA: 0x000335C8 File Offset: 0x000317C8
	// (set) Token: 0x06000CAC RID: 3244 RVA: 0x000335F0 File Offset: 0x000317F0
	public unsafe double WaitingTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsNetwork.NativeFieldInfoPtr_WaitingTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsNetwork.NativeFieldInfoPtr_WaitingTime)) = value;
		}
	}

	// Token: 0x17000460 RID: 1120
	// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00033614 File Offset: 0x00031814
	// (set) Token: 0x06000CAE RID: 3246 RVA: 0x0003363C File Offset: 0x0003183C
	public unsafe bool KeepWaitingResult
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsNetwork.NativeFieldInfoPtr_KeepWaitingResult);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsNetwork.NativeFieldInfoPtr_KeepWaitingResult)) = value;
		}
	}

	// Token: 0x040007A4 RID: 1956
	private static readonly IntPtr NativeFieldInfoPtr_WaitingTime;

	// Token: 0x040007A5 RID: 1957
	private static readonly IntPtr NativeFieldInfoPtr_KeepWaitingResult;

	// Token: 0x040007A6 RID: 1958
	private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

	// Token: 0x040007A7 RID: 1959
	private static readonly IntPtr NativeMethodInfoPtr_ResetTime_Public_Void_Double_0;

	// Token: 0x040007A8 RID: 1960
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
