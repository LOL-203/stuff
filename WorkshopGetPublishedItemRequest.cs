using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x02000261 RID: 609
public class WorkshopGetPublishedItemRequest : Object
{
	// Token: 0x06002CC4 RID: 11460 RVA: 0x000B02E0 File Offset: 0x000AE4E0
	[CallerCount(0)]
	public unsafe WorkshopGetPublishedItemRequest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkshopGetPublishedItemRequest>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopGetPublishedItemRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002CC5 RID: 11461 RVA: 0x000B032C File Offset: 0x000AE52C
	// Note: this type is marked as 'beforefieldinit'.
	static WorkshopGetPublishedItemRequest()
	{
		Il2CppClassPointerStore<WorkshopGetPublishedItemRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorkshopGetPublishedItemRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopGetPublishedItemRequest>.NativeClassPtr);
		WorkshopGetPublishedItemRequest.NativeFieldInfoPtr_ItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopGetPublishedItemRequest>.NativeClassPtr, "ItemId");
		WorkshopGetPublishedItemRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopGetPublishedItemRequest>.NativeClassPtr, 100666672);
	}

	// Token: 0x06002CC6 RID: 11462 RVA: 0x00002988 File Offset: 0x00000B88
	public WorkshopGetPublishedItemRequest(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001001 RID: 4097
	// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x000B0384 File Offset: 0x000AE584
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WorkshopGetPublishedItemRequest>.NativeClassPtr));
		}
	}

	// Token: 0x17001002 RID: 4098
	// (get) Token: 0x06002CC8 RID: 11464 RVA: 0x000B0398 File Offset: 0x000AE598
	// (set) Token: 0x06002CC9 RID: 11465 RVA: 0x000B03C1 File Offset: 0x000AE5C1
	public unsafe string ItemId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopGetPublishedItemRequest.NativeFieldInfoPtr_ItemId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopGetPublishedItemRequest.NativeFieldInfoPtr_ItemId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04001C6D RID: 7277
	private static readonly IntPtr NativeFieldInfoPtr_ItemId;

	// Token: 0x04001C6E RID: 7278
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
