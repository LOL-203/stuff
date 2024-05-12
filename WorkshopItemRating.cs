using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x02000262 RID: 610
public class WorkshopItemRating : Object
{
	// Token: 0x06002CCA RID: 11466 RVA: 0x000B03E8 File Offset: 0x000AE5E8
	[CallerCount(0)]
	public unsafe WorkshopItemRating() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkshopItemRating>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopItemRating.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002CCB RID: 11467 RVA: 0x000B0434 File Offset: 0x000AE634
	// Note: this type is marked as 'beforefieldinit'.
	static WorkshopItemRating()
	{
		Il2CppClassPointerStore<WorkshopItemRating>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorkshopItemRating");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopItemRating>.NativeClassPtr);
		WorkshopItemRating.NativeFieldInfoPtr_Average = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItemRating>.NativeClassPtr, "Average");
		WorkshopItemRating.NativeFieldInfoPtr_Count1Star = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItemRating>.NativeClassPtr, "Count1Star");
		WorkshopItemRating.NativeFieldInfoPtr_Count2Star = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItemRating>.NativeClassPtr, "Count2Star");
		WorkshopItemRating.NativeFieldInfoPtr_Count3Star = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItemRating>.NativeClassPtr, "Count3Star");
		WorkshopItemRating.NativeFieldInfoPtr_Count4Star = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItemRating>.NativeClassPtr, "Count4Star");
		WorkshopItemRating.NativeFieldInfoPtr_Count5Star = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItemRating>.NativeClassPtr, "Count5Star");
		WorkshopItemRating.NativeFieldInfoPtr_TotalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopItemRating>.NativeClassPtr, "TotalCount");
		WorkshopItemRating.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopItemRating>.NativeClassPtr, 100666673);
	}

	// Token: 0x06002CCC RID: 11468 RVA: 0x00002988 File Offset: 0x00000B88
	public WorkshopItemRating(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001003 RID: 4099
	// (get) Token: 0x06002CCD RID: 11469 RVA: 0x000B0504 File Offset: 0x000AE704
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WorkshopItemRating>.NativeClassPtr));
		}
	}

	// Token: 0x17001004 RID: 4100
	// (get) Token: 0x06002CCE RID: 11470 RVA: 0x000B0518 File Offset: 0x000AE718
	// (set) Token: 0x06002CCF RID: 11471 RVA: 0x000B054A File Offset: 0x000AE74A
	public Nullable<float> Average
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_Average);
			return new Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_Average), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17001005 RID: 4101
	// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x000B0580 File Offset: 0x000AE780
	// (set) Token: 0x06002CD1 RID: 11473 RVA: 0x000B05B2 File Offset: 0x000AE7B2
	public Nullable<int> Count1Star
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_Count1Star);
			return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_Count1Star), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17001006 RID: 4102
	// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x000B05E8 File Offset: 0x000AE7E8
	// (set) Token: 0x06002CD3 RID: 11475 RVA: 0x000B061A File Offset: 0x000AE81A
	public Nullable<int> Count2Star
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_Count2Star);
			return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_Count2Star), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17001007 RID: 4103
	// (get) Token: 0x06002CD4 RID: 11476 RVA: 0x000B0650 File Offset: 0x000AE850
	// (set) Token: 0x06002CD5 RID: 11477 RVA: 0x000B0682 File Offset: 0x000AE882
	public Nullable<int> Count3Star
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_Count3Star);
			return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_Count3Star), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17001008 RID: 4104
	// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x000B06B8 File Offset: 0x000AE8B8
	// (set) Token: 0x06002CD7 RID: 11479 RVA: 0x000B06EA File Offset: 0x000AE8EA
	public Nullable<int> Count4Star
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_Count4Star);
			return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_Count4Star), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17001009 RID: 4105
	// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x000B0720 File Offset: 0x000AE920
	// (set) Token: 0x06002CD9 RID: 11481 RVA: 0x000B0752 File Offset: 0x000AE952
	public Nullable<int> Count5Star
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_Count5Star);
			return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_Count5Star), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x1700100A RID: 4106
	// (get) Token: 0x06002CDA RID: 11482 RVA: 0x000B0788 File Offset: 0x000AE988
	// (set) Token: 0x06002CDB RID: 11483 RVA: 0x000B07BA File Offset: 0x000AE9BA
	public Nullable<int> TotalCount
	{
		get
		{
			IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_TotalCount);
			return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, data));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopItemRating.NativeFieldInfoPtr_TotalCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x04001C6F RID: 7279
	private static readonly IntPtr NativeFieldInfoPtr_Average;

	// Token: 0x04001C70 RID: 7280
	private static readonly IntPtr NativeFieldInfoPtr_Count1Star;

	// Token: 0x04001C71 RID: 7281
	private static readonly IntPtr NativeFieldInfoPtr_Count2Star;

	// Token: 0x04001C72 RID: 7282
	private static readonly IntPtr NativeFieldInfoPtr_Count3Star;

	// Token: 0x04001C73 RID: 7283
	private static readonly IntPtr NativeFieldInfoPtr_Count4Star;

	// Token: 0x04001C74 RID: 7284
	private static readonly IntPtr NativeFieldInfoPtr_Count5Star;

	// Token: 0x04001C75 RID: 7285
	private static readonly IntPtr NativeFieldInfoPtr_TotalCount;

	// Token: 0x04001C76 RID: 7286
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
