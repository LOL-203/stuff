using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200045B RID: 1115
public class bl_MMItemInfo : Il2CppSystem.Object
{
	// Token: 0x060059A5 RID: 22949 RVA: 0x00166A98 File Offset: 0x00164C98
	[CallerCount(0)]
	public unsafe bl_MMItemInfo(Vector3 position) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref position;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MMItemInfo.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060059A6 RID: 22950 RVA: 0x00166AF8 File Offset: 0x00164CF8
	[CallerCount(0)]
	public unsafe bl_MMItemInfo(Transform target) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MMItemInfo.NativeMethodInfoPtr__ctor_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060059A7 RID: 22951 RVA: 0x00166B5C File Offset: 0x00164D5C
	// Note: this type is marked as 'beforefieldinit'.
	static bl_MMItemInfo()
	{
		Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "bl_MMItemInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr);
		bl_MMItemInfo.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr, "Position");
		bl_MMItemInfo.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr, "Target");
		bl_MMItemInfo.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr, "Size");
		bl_MMItemInfo.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr, "Color");
		bl_MMItemInfo.NativeFieldInfoPtr_Interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr, "Interactable");
		bl_MMItemInfo.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr, "Sprite");
		bl_MMItemInfo.NativeFieldInfoPtr_Effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr, "Effect");
		bl_MMItemInfo.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr, 100670340);
		bl_MMItemInfo.NativeMethodInfoPtr__ctor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr, 100670341);
	}

	// Token: 0x060059A8 RID: 22952 RVA: 0x00002988 File Offset: 0x00000B88
	public bl_MMItemInfo(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001FF6 RID: 8182
	// (get) Token: 0x060059A9 RID: 22953 RVA: 0x00166C40 File Offset: 0x00164E40
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<bl_MMItemInfo>.NativeClassPtr));
		}
	}

	// Token: 0x17001FF7 RID: 8183
	// (get) Token: 0x060059AA RID: 22954 RVA: 0x00166C54 File Offset: 0x00164E54
	// (set) Token: 0x060059AB RID: 22955 RVA: 0x00166C7C File Offset: 0x00164E7C
	public unsafe Vector3 Position
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Position);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Position)) = value;
		}
	}

	// Token: 0x17001FF8 RID: 8184
	// (get) Token: 0x060059AC RID: 22956 RVA: 0x00166CA0 File Offset: 0x00164EA0
	// (set) Token: 0x060059AD RID: 22957 RVA: 0x00166CD4 File Offset: 0x00164ED4
	public unsafe Transform Target
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Target);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FF9 RID: 8185
	// (get) Token: 0x060059AE RID: 22958 RVA: 0x00166CFC File Offset: 0x00164EFC
	// (set) Token: 0x060059AF RID: 22959 RVA: 0x00166D24 File Offset: 0x00164F24
	public unsafe float Size
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Size);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Size)) = value;
		}
	}

	// Token: 0x17001FFA RID: 8186
	// (get) Token: 0x060059B0 RID: 22960 RVA: 0x00166D48 File Offset: 0x00164F48
	// (set) Token: 0x060059B1 RID: 22961 RVA: 0x00166D70 File Offset: 0x00164F70
	public unsafe Color Color
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Color);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Color)) = value;
		}
	}

	// Token: 0x17001FFB RID: 8187
	// (get) Token: 0x060059B2 RID: 22962 RVA: 0x00166D94 File Offset: 0x00164F94
	// (set) Token: 0x060059B3 RID: 22963 RVA: 0x00166DBC File Offset: 0x00164FBC
	public unsafe bool Interactable
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Interactable);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Interactable)) = value;
		}
	}

	// Token: 0x17001FFC RID: 8188
	// (get) Token: 0x060059B4 RID: 22964 RVA: 0x00166DE0 File Offset: 0x00164FE0
	// (set) Token: 0x060059B5 RID: 22965 RVA: 0x00166E14 File Offset: 0x00165014
	public unsafe Sprite Sprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Sprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Sprite(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FFD RID: 8189
	// (get) Token: 0x060059B6 RID: 22966 RVA: 0x00166E3C File Offset: 0x0016503C
	// (set) Token: 0x060059B7 RID: 22967 RVA: 0x00166E64 File Offset: 0x00165064
	public unsafe ItemEffect Effect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Effect);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMItemInfo.NativeFieldInfoPtr_Effect)) = value;
		}
	}

	// Token: 0x040038BF RID: 14527
	private static readonly IntPtr NativeFieldInfoPtr_Position;

	// Token: 0x040038C0 RID: 14528
	private static readonly IntPtr NativeFieldInfoPtr_Target;

	// Token: 0x040038C1 RID: 14529
	private static readonly IntPtr NativeFieldInfoPtr_Size;

	// Token: 0x040038C2 RID: 14530
	private static readonly IntPtr NativeFieldInfoPtr_Color;

	// Token: 0x040038C3 RID: 14531
	private static readonly IntPtr NativeFieldInfoPtr_Interactable;

	// Token: 0x040038C4 RID: 14532
	private static readonly IntPtr NativeFieldInfoPtr_Sprite;

	// Token: 0x040038C5 RID: 14533
	private static readonly IntPtr NativeFieldInfoPtr_Effect;

	// Token: 0x040038C6 RID: 14534
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_0;

	// Token: 0x040038C7 RID: 14535
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_0;
}
