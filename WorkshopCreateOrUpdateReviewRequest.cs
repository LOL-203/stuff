using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x0200025F RID: 607
public class WorkshopCreateOrUpdateReviewRequest : Object
{
	// Token: 0x06002CB8 RID: 11448 RVA: 0x000B00D0 File Offset: 0x000AE2D0
	[CallerCount(0)]
	public unsafe WorkshopCreateOrUpdateReviewRequest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkshopCreateOrUpdateReviewRequest>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopCreateOrUpdateReviewRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002CB9 RID: 11449 RVA: 0x000B011C File Offset: 0x000AE31C
	// Note: this type is marked as 'beforefieldinit'.
	static WorkshopCreateOrUpdateReviewRequest()
	{
		Il2CppClassPointerStore<WorkshopCreateOrUpdateReviewRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorkshopCreateOrUpdateReviewRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopCreateOrUpdateReviewRequest>.NativeClassPtr);
		WorkshopCreateOrUpdateReviewRequest.NativeFieldInfoPtr_ItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopCreateOrUpdateReviewRequest>.NativeClassPtr, "ItemId");
		WorkshopCreateOrUpdateReviewRequest.NativeFieldInfoPtr_Review = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopCreateOrUpdateReviewRequest>.NativeClassPtr, "Review");
		WorkshopCreateOrUpdateReviewRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopCreateOrUpdateReviewRequest>.NativeClassPtr, 100666670);
	}

	// Token: 0x06002CBA RID: 11450 RVA: 0x00002988 File Offset: 0x00000B88
	public WorkshopCreateOrUpdateReviewRequest(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000FFD RID: 4093
	// (get) Token: 0x06002CBB RID: 11451 RVA: 0x000B0188 File Offset: 0x000AE388
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WorkshopCreateOrUpdateReviewRequest>.NativeClassPtr));
		}
	}

	// Token: 0x17000FFE RID: 4094
	// (get) Token: 0x06002CBC RID: 11452 RVA: 0x000B019C File Offset: 0x000AE39C
	// (set) Token: 0x06002CBD RID: 11453 RVA: 0x000B01C5 File Offset: 0x000AE3C5
	public unsafe string ItemId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopCreateOrUpdateReviewRequest.NativeFieldInfoPtr_ItemId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopCreateOrUpdateReviewRequest.NativeFieldInfoPtr_ItemId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000FFF RID: 4095
	// (get) Token: 0x06002CBE RID: 11454 RVA: 0x000B01EC File Offset: 0x000AE3EC
	// (set) Token: 0x06002CBF RID: 11455 RVA: 0x000B0220 File Offset: 0x000AE420
	public unsafe WorkshopReviewSubmission Review
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopCreateOrUpdateReviewRequest.NativeFieldInfoPtr_Review);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WorkshopReviewSubmission(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopCreateOrUpdateReviewRequest.NativeFieldInfoPtr_Review), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001C69 RID: 7273
	private static readonly IntPtr NativeFieldInfoPtr_ItemId;

	// Token: 0x04001C6A RID: 7274
	private static readonly IntPtr NativeFieldInfoPtr_Review;

	// Token: 0x04001C6B RID: 7275
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
