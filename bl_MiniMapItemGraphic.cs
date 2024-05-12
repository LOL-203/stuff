using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000455 RID: 1109
public class bl_MiniMapItemGraphic : MonoBehaviour
{
	// Token: 0x06005901 RID: 22785 RVA: 0x001645BC File Offset: 0x001627BC
	[CallerCount(0)]
	public unsafe bl_MiniMapItemGraphic() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bl_MiniMapItemGraphic>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItemGraphic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005902 RID: 22786 RVA: 0x00164608 File Offset: 0x00162808
	// Note: this type is marked as 'beforefieldinit'.
	static bl_MiniMapItemGraphic()
	{
		Il2CppClassPointerStore<bl_MiniMapItemGraphic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "bl_MiniMapItemGraphic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bl_MiniMapItemGraphic>.NativeClassPtr);
		bl_MiniMapItemGraphic.NativeFieldInfoPtr_GraphicImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItemGraphic>.NativeClassPtr, "GraphicImage");
		bl_MiniMapItemGraphic.NativeFieldInfoPtr_GraphicItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItemGraphic>.NativeClassPtr, "GraphicItem");
		bl_MiniMapItemGraphic.NativeFieldInfoPtr_GraphicAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItemGraphic>.NativeClassPtr, "GraphicAnimator");
		bl_MiniMapItemGraphic.NativeFieldInfoPtr_HeightIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItemGraphic>.NativeClassPtr, "HeightIcon");
		bl_MiniMapItemGraphic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItemGraphic>.NativeClassPtr, 100670312);
	}

	// Token: 0x06005903 RID: 22787 RVA: 0x0000210C File Offset: 0x0000030C
	public bl_MiniMapItemGraphic(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001FB4 RID: 8116
	// (get) Token: 0x06005904 RID: 22788 RVA: 0x0016469C File Offset: 0x0016289C
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<bl_MiniMapItemGraphic>.NativeClassPtr));
		}
	}

	// Token: 0x17001FB5 RID: 8117
	// (get) Token: 0x06005905 RID: 22789 RVA: 0x001646B0 File Offset: 0x001628B0
	// (set) Token: 0x06005906 RID: 22790 RVA: 0x001646E4 File Offset: 0x001628E4
	public unsafe SpriteRenderer GraphicImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItemGraphic.NativeFieldInfoPtr_GraphicImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new SpriteRenderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItemGraphic.NativeFieldInfoPtr_GraphicImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FB6 RID: 8118
	// (get) Token: 0x06005907 RID: 22791 RVA: 0x0016470C File Offset: 0x0016290C
	// (set) Token: 0x06005908 RID: 22792 RVA: 0x00164740 File Offset: 0x00162940
	public unsafe bl_IconItem GraphicItem
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItemGraphic.NativeFieldInfoPtr_GraphicItem);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new bl_IconItem(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItemGraphic.NativeFieldInfoPtr_GraphicItem), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FB7 RID: 8119
	// (get) Token: 0x06005909 RID: 22793 RVA: 0x00164768 File Offset: 0x00162968
	// (set) Token: 0x0600590A RID: 22794 RVA: 0x0016479C File Offset: 0x0016299C
	public unsafe Animator GraphicAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItemGraphic.NativeFieldInfoPtr_GraphicAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Animator(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItemGraphic.NativeFieldInfoPtr_GraphicAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FB8 RID: 8120
	// (get) Token: 0x0600590B RID: 22795 RVA: 0x001647C4 File Offset: 0x001629C4
	// (set) Token: 0x0600590C RID: 22796 RVA: 0x001647F8 File Offset: 0x001629F8
	public unsafe ObjectiveHeightIcon HeightIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItemGraphic.NativeFieldInfoPtr_HeightIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new ObjectiveHeightIcon(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItemGraphic.NativeFieldInfoPtr_HeightIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04003864 RID: 14436
	private static readonly IntPtr NativeFieldInfoPtr_GraphicImage;

	// Token: 0x04003865 RID: 14437
	private static readonly IntPtr NativeFieldInfoPtr_GraphicItem;

	// Token: 0x04003866 RID: 14438
	private static readonly IntPtr NativeFieldInfoPtr_GraphicAnimator;

	// Token: 0x04003867 RID: 14439
	private static readonly IntPtr NativeFieldInfoPtr_HeightIcon;

	// Token: 0x04003868 RID: 14440
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
