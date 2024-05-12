using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x02000263 RID: 611
public class WorkshopReviewSubmission : Object
{
	// Token: 0x06002CDC RID: 11484 RVA: 0x000B07F0 File Offset: 0x000AE9F0
	[CallerCount(0)]
	public unsafe WorkshopReviewSubmission() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkshopReviewSubmission>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopReviewSubmission.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002CDD RID: 11485 RVA: 0x000B083C File Offset: 0x000AEA3C
	// Note: this type is marked as 'beforefieldinit'.
	static WorkshopReviewSubmission()
	{
		Il2CppClassPointerStore<WorkshopReviewSubmission>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorkshopReviewSubmission");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopReviewSubmission>.NativeClassPtr);
		WorkshopReviewSubmission.NativeFieldInfoPtr_IsInstalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopReviewSubmission>.NativeClassPtr, "IsInstalled");
		WorkshopReviewSubmission.NativeFieldInfoPtr_ItemVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopReviewSubmission>.NativeClassPtr, "ItemVersion");
		WorkshopReviewSubmission.NativeFieldInfoPtr_Rating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopReviewSubmission>.NativeClassPtr, "Rating");
		WorkshopReviewSubmission.NativeFieldInfoPtr_ReviewText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopReviewSubmission>.NativeClassPtr, "ReviewText");
		WorkshopReviewSubmission.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopReviewSubmission>.NativeClassPtr, "Title");
		WorkshopReviewSubmission.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopReviewSubmission>.NativeClassPtr, 100666674);
	}

	// Token: 0x06002CDE RID: 11486 RVA: 0x00002988 File Offset: 0x00000B88
	public WorkshopReviewSubmission(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700100B RID: 4107
	// (get) Token: 0x06002CDF RID: 11487 RVA: 0x000B08E4 File Offset: 0x000AEAE4
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WorkshopReviewSubmission>.NativeClassPtr));
		}
	}

	// Token: 0x1700100C RID: 4108
	// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x000B08F8 File Offset: 0x000AEAF8
	// (set) Token: 0x06002CE1 RID: 11489 RVA: 0x000B0920 File Offset: 0x000AEB20
	public unsafe bool IsInstalled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopReviewSubmission.NativeFieldInfoPtr_IsInstalled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopReviewSubmission.NativeFieldInfoPtr_IsInstalled)) = value;
		}
	}

	// Token: 0x1700100D RID: 4109
	// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x000B0944 File Offset: 0x000AEB44
	// (set) Token: 0x06002CE3 RID: 11491 RVA: 0x000B096D File Offset: 0x000AEB6D
	public unsafe string ItemVersion
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopReviewSubmission.NativeFieldInfoPtr_ItemVersion);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopReviewSubmission.NativeFieldInfoPtr_ItemVersion), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700100E RID: 4110
	// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x000B0994 File Offset: 0x000AEB94
	// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x000B09BC File Offset: 0x000AEBBC
	public unsafe int Rating
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopReviewSubmission.NativeFieldInfoPtr_Rating);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopReviewSubmission.NativeFieldInfoPtr_Rating)) = value;
		}
	}

	// Token: 0x1700100F RID: 4111
	// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x000B09E0 File Offset: 0x000AEBE0
	// (set) Token: 0x06002CE7 RID: 11495 RVA: 0x000B0A09 File Offset: 0x000AEC09
	public unsafe string ReviewText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopReviewSubmission.NativeFieldInfoPtr_ReviewText);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopReviewSubmission.NativeFieldInfoPtr_ReviewText), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001010 RID: 4112
	// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x000B0A30 File Offset: 0x000AEC30
	// (set) Token: 0x06002CE9 RID: 11497 RVA: 0x000B0A59 File Offset: 0x000AEC59
	public unsafe string Title
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopReviewSubmission.NativeFieldInfoPtr_Title);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopReviewSubmission.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04001C77 RID: 7287
	private static readonly IntPtr NativeFieldInfoPtr_IsInstalled;

	// Token: 0x04001C78 RID: 7288
	private static readonly IntPtr NativeFieldInfoPtr_ItemVersion;

	// Token: 0x04001C79 RID: 7289
	private static readonly IntPtr NativeFieldInfoPtr_Rating;

	// Token: 0x04001C7A RID: 7290
	private static readonly IntPtr NativeFieldInfoPtr_ReviewText;

	// Token: 0x04001C7B RID: 7291
	private static readonly IntPtr NativeFieldInfoPtr_Title;

	// Token: 0x04001C7C RID: 7292
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
