using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x02000264 RID: 612
public class WorkshopSearchRequest : Object
{
	// Token: 0x06002CEA RID: 11498 RVA: 0x000B0A80 File Offset: 0x000AEC80
	[CallerCount(0)]
	public unsafe WorkshopSearchRequest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkshopSearchRequest>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopSearchRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002CEB RID: 11499 RVA: 0x000B0ACC File Offset: 0x000AECCC
	// Note: this type is marked as 'beforefieldinit'.
	static WorkshopSearchRequest()
	{
		Il2CppClassPointerStore<WorkshopSearchRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorkshopSearchRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopSearchRequest>.NativeClassPtr);
		WorkshopSearchRequest.NativeFieldInfoPtr_Select = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopSearchRequest>.NativeClassPtr, "Select");
		WorkshopSearchRequest.NativeFieldInfoPtr_Filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopSearchRequest>.NativeClassPtr, "Filter");
		WorkshopSearchRequest.NativeFieldInfoPtr_OrderBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopSearchRequest>.NativeClassPtr, "OrderBy");
		WorkshopSearchRequest.NativeFieldInfoPtr_Skip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopSearchRequest>.NativeClassPtr, "Skip");
		WorkshopSearchRequest.NativeFieldInfoPtr_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopSearchRequest>.NativeClassPtr, "Top");
		WorkshopSearchRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopSearchRequest>.NativeClassPtr, 100666675);
	}

	// Token: 0x06002CEC RID: 11500 RVA: 0x00002988 File Offset: 0x00000B88
	public WorkshopSearchRequest(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001011 RID: 4113
	// (get) Token: 0x06002CED RID: 11501 RVA: 0x000B0B74 File Offset: 0x000AED74
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WorkshopSearchRequest>.NativeClassPtr));
		}
	}

	// Token: 0x17001012 RID: 4114
	// (get) Token: 0x06002CEE RID: 11502 RVA: 0x000B0B88 File Offset: 0x000AED88
	// (set) Token: 0x06002CEF RID: 11503 RVA: 0x000B0BB1 File Offset: 0x000AEDB1
	public unsafe string Select
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopSearchRequest.NativeFieldInfoPtr_Select);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopSearchRequest.NativeFieldInfoPtr_Select), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001013 RID: 4115
	// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x000B0BD8 File Offset: 0x000AEDD8
	// (set) Token: 0x06002CF1 RID: 11505 RVA: 0x000B0C01 File Offset: 0x000AEE01
	public unsafe string Filter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopSearchRequest.NativeFieldInfoPtr_Filter);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopSearchRequest.NativeFieldInfoPtr_Filter), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001014 RID: 4116
	// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x000B0C28 File Offset: 0x000AEE28
	// (set) Token: 0x06002CF3 RID: 11507 RVA: 0x000B0C51 File Offset: 0x000AEE51
	public unsafe string OrderBy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopSearchRequest.NativeFieldInfoPtr_OrderBy);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopSearchRequest.NativeFieldInfoPtr_OrderBy), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001015 RID: 4117
	// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x000B0C78 File Offset: 0x000AEE78
	// (set) Token: 0x06002CF5 RID: 11509 RVA: 0x000B0CA0 File Offset: 0x000AEEA0
	public unsafe int Skip
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopSearchRequest.NativeFieldInfoPtr_Skip);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopSearchRequest.NativeFieldInfoPtr_Skip)) = value;
		}
	}

	// Token: 0x17001016 RID: 4118
	// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x000B0CC4 File Offset: 0x000AEEC4
	// (set) Token: 0x06002CF7 RID: 11511 RVA: 0x000B0CEC File Offset: 0x000AEEEC
	public unsafe int Top
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopSearchRequest.NativeFieldInfoPtr_Top);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopSearchRequest.NativeFieldInfoPtr_Top)) = value;
		}
	}

	// Token: 0x04001C7D RID: 7293
	private static readonly IntPtr NativeFieldInfoPtr_Select;

	// Token: 0x04001C7E RID: 7294
	private static readonly IntPtr NativeFieldInfoPtr_Filter;

	// Token: 0x04001C7F RID: 7295
	private static readonly IntPtr NativeFieldInfoPtr_OrderBy;

	// Token: 0x04001C80 RID: 7296
	private static readonly IntPtr NativeFieldInfoPtr_Skip;

	// Token: 0x04001C81 RID: 7297
	private static readonly IntPtr NativeFieldInfoPtr_Top;

	// Token: 0x04001C82 RID: 7298
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
