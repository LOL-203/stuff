using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x02000260 RID: 608
public class WorkshopCreateOrUpdateReviewResult : Object
{
	// Token: 0x06002CC0 RID: 11456 RVA: 0x000B0248 File Offset: 0x000AE448
	[CallerCount(0)]
	public unsafe WorkshopCreateOrUpdateReviewResult() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkshopCreateOrUpdateReviewResult>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopCreateOrUpdateReviewResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002CC1 RID: 11457 RVA: 0x000B0293 File Offset: 0x000AE493
	// Note: this type is marked as 'beforefieldinit'.
	static WorkshopCreateOrUpdateReviewResult()
	{
		Il2CppClassPointerStore<WorkshopCreateOrUpdateReviewResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorkshopCreateOrUpdateReviewResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopCreateOrUpdateReviewResult>.NativeClassPtr);
		WorkshopCreateOrUpdateReviewResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopCreateOrUpdateReviewResult>.NativeClassPtr, 100666671);
	}

	// Token: 0x06002CC2 RID: 11458 RVA: 0x00002988 File Offset: 0x00000B88
	public WorkshopCreateOrUpdateReviewResult(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001000 RID: 4096
	// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x000B02CC File Offset: 0x000AE4CC
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WorkshopCreateOrUpdateReviewResult>.NativeClassPtr));
		}
	}

	// Token: 0x04001C6C RID: 7276
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
