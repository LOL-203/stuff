using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200044D RID: 1101
public class bl_IconItem : MonoBehaviour
{
	// Token: 0x060057EA RID: 22506 RVA: 0x001602F4 File Offset: 0x0015E4F4
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_IconItem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060057EB RID: 22507 RVA: 0x00160338 File Offset: 0x0015E538
	[CallerCount(0)]
	public unsafe void DestroyIcon(bool immediate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref immediate;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_IconItem.NativeMethodInfoPtr_DestroyIcon_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060057EC RID: 22508 RVA: 0x0016038C File Offset: 0x0015E58C
	[CallerCount(0)]
	public unsafe void DestroyIcon(bool immediate, Sprite death)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref immediate;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(death);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_IconItem.NativeMethodInfoPtr_DestroyIcon_Public_Void_Boolean_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060057ED RID: 22509 RVA: 0x001603F8 File Offset: 0x0015E5F8
	[CallerCount(0)]
	public unsafe void SetInfoText(string info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_IconItem.NativeMethodInfoPtr_SetInfoText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060057EE RID: 22510 RVA: 0x00160454 File Offset: 0x0015E654
	[CallerCount(0)]
	public unsafe bl_IconItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_IconItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060057EF RID: 22511 RVA: 0x001604A0 File Offset: 0x0015E6A0
	// Note: this type is marked as 'beforefieldinit'.
	static bl_IconItem()
	{
		Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "bl_IconItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr);
		bl_IconItem.NativeFieldInfoPtr_DestroyIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr, "DestroyIn");
		bl_IconItem.NativeFieldInfoPtr_TargetGrapihc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr, "TargetGrapihc");
		bl_IconItem.NativeFieldInfoPtr_DeathIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr, "DeathIcon");
		bl_IconItem.NativeFieldInfoPtr_InfoText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr, "InfoText");
		bl_IconItem.NativeFieldInfoPtr_m_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr, "m_CanvasGroup");
		bl_IconItem.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr, "Anim");
		bl_IconItem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr, 100670237);
		bl_IconItem.NativeMethodInfoPtr_DestroyIcon_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr, 100670238);
		bl_IconItem.NativeMethodInfoPtr_DestroyIcon_Public_Void_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr, 100670239);
		bl_IconItem.NativeMethodInfoPtr_SetInfoText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr, 100670240);
		bl_IconItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr, 100670241);
	}

	// Token: 0x060057F0 RID: 22512 RVA: 0x0000210C File Offset: 0x0000030C
	public bl_IconItem(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001F42 RID: 8002
	// (get) Token: 0x060057F1 RID: 22513 RVA: 0x001605AC File Offset: 0x0015E7AC
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<bl_IconItem>.NativeClassPtr));
		}
	}

	// Token: 0x17001F43 RID: 8003
	// (get) Token: 0x060057F2 RID: 22514 RVA: 0x001605C0 File Offset: 0x0015E7C0
	// (set) Token: 0x060057F3 RID: 22515 RVA: 0x001605E8 File Offset: 0x0015E7E8
	public unsafe float DestroyIn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_IconItem.NativeFieldInfoPtr_DestroyIn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_IconItem.NativeFieldInfoPtr_DestroyIn)) = value;
		}
	}

	// Token: 0x17001F44 RID: 8004
	// (get) Token: 0x060057F4 RID: 22516 RVA: 0x0016060C File Offset: 0x0015E80C
	// (set) Token: 0x060057F5 RID: 22517 RVA: 0x00160640 File Offset: 0x0015E840
	public unsafe SpriteRenderer TargetGrapihc
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_IconItem.NativeFieldInfoPtr_TargetGrapihc);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new SpriteRenderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_IconItem.NativeFieldInfoPtr_TargetGrapihc), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F45 RID: 8005
	// (get) Token: 0x060057F6 RID: 22518 RVA: 0x00160668 File Offset: 0x0015E868
	// (set) Token: 0x060057F7 RID: 22519 RVA: 0x0016069C File Offset: 0x0015E89C
	public unsafe Sprite DeathIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_IconItem.NativeFieldInfoPtr_DeathIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Sprite(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_IconItem.NativeFieldInfoPtr_DeathIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F46 RID: 8006
	// (get) Token: 0x060057F8 RID: 22520 RVA: 0x001606C4 File Offset: 0x0015E8C4
	// (set) Token: 0x060057F9 RID: 22521 RVA: 0x001606F8 File Offset: 0x0015E8F8
	public unsafe Text InfoText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_IconItem.NativeFieldInfoPtr_InfoText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Text(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_IconItem.NativeFieldInfoPtr_InfoText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F47 RID: 8007
	// (get) Token: 0x060057FA RID: 22522 RVA: 0x00160720 File Offset: 0x0015E920
	// (set) Token: 0x060057FB RID: 22523 RVA: 0x00160754 File Offset: 0x0015E954
	public unsafe CanvasGroup m_CanvasGroup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_IconItem.NativeFieldInfoPtr_m_CanvasGroup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new CanvasGroup(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_IconItem.NativeFieldInfoPtr_m_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F48 RID: 8008
	// (get) Token: 0x060057FC RID: 22524 RVA: 0x0016077C File Offset: 0x0015E97C
	// (set) Token: 0x060057FD RID: 22525 RVA: 0x001607B0 File Offset: 0x0015E9B0
	public unsafe Animator Anim
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_IconItem.NativeFieldInfoPtr_Anim);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Animator(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_IconItem.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040037B8 RID: 14264
	private static readonly IntPtr NativeFieldInfoPtr_DestroyIn;

	// Token: 0x040037B9 RID: 14265
	private static readonly IntPtr NativeFieldInfoPtr_TargetGrapihc;

	// Token: 0x040037BA RID: 14266
	private static readonly IntPtr NativeFieldInfoPtr_DeathIcon;

	// Token: 0x040037BB RID: 14267
	private static readonly IntPtr NativeFieldInfoPtr_InfoText;

	// Token: 0x040037BC RID: 14268
	private static readonly IntPtr NativeFieldInfoPtr_m_CanvasGroup;

	// Token: 0x040037BD RID: 14269
	private static readonly IntPtr NativeFieldInfoPtr_Anim;

	// Token: 0x040037BE RID: 14270
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040037BF RID: 14271
	private static readonly IntPtr NativeMethodInfoPtr_DestroyIcon_Public_Void_Boolean_0;

	// Token: 0x040037C0 RID: 14272
	private static readonly IntPtr NativeMethodInfoPtr_DestroyIcon_Public_Void_Boolean_Sprite_0;

	// Token: 0x040037C1 RID: 14273
	private static readonly IntPtr NativeMethodInfoPtr_SetInfoText_Public_Void_String_0;

	// Token: 0x040037C2 RID: 14274
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
