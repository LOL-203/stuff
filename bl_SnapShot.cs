using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200045D RID: 1117
public class bl_SnapShot : MonoBehaviour
{
	// Token: 0x17002005 RID: 8197
	// (get) Token: 0x060059BC RID: 22972 RVA: 0x00166F40 File Offset: 0x00165140
	public unsafe static string FolderPath
	{
		[CallerCount(0)]
		get
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(bl_SnapShot.NativeMethodInfoPtr_get_FolderPath_Public_Static_get_String_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
	}

	// Token: 0x060059BD RID: 22973 RVA: 0x00166F7C File Offset: 0x0016517C
	[CallerCount(0)]
	public unsafe string GetFullFolderPath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(bl_SnapShot.NativeMethodInfoPtr_GetFullFolderPath_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	// Token: 0x060059BE RID: 22974 RVA: 0x00166FC8 File Offset: 0x001651C8
	[CallerCount(0)]
	public unsafe void TakeSnapshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_SnapShot.NativeMethodInfoPtr_TakeSnapshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060059BF RID: 22975 RVA: 0x0016700C File Offset: 0x0016520C
	[CallerCount(0)]
	public unsafe bl_SnapShot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bl_SnapShot>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_SnapShot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060059C0 RID: 22976 RVA: 0x00167058 File Offset: 0x00165258
	// Note: this type is marked as 'beforefieldinit'.
	static bl_SnapShot()
	{
		Il2CppClassPointerStore<bl_SnapShot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "bl_SnapShot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bl_SnapShot>.NativeClassPtr);
		bl_SnapShot.NativeFieldInfoPtr_resWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_SnapShot>.NativeClassPtr, "resWidth");
		bl_SnapShot.NativeFieldInfoPtr_resHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_SnapShot>.NativeClassPtr, "resHeight");
		bl_SnapShot.NativeFieldInfoPtr_msaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_SnapShot>.NativeClassPtr, "msaa");
		bl_SnapShot.NativeFieldInfoPtr_m_TakeSnapShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_SnapShot>.NativeClassPtr, "m_TakeSnapShot");
		bl_SnapShot.NativeFieldInfoPtr__folderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_SnapShot>.NativeClassPtr, "_folderPath");
		bl_SnapShot.NativeMethodInfoPtr_get_FolderPath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_SnapShot>.NativeClassPtr, 100670343);
		bl_SnapShot.NativeMethodInfoPtr_GetFullFolderPath_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_SnapShot>.NativeClassPtr, 100670344);
		bl_SnapShot.NativeMethodInfoPtr_TakeSnapshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_SnapShot>.NativeClassPtr, 100670345);
		bl_SnapShot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_SnapShot>.NativeClassPtr, 100670346);
	}

	// Token: 0x060059C1 RID: 22977 RVA: 0x0000210C File Offset: 0x0000030C
	public bl_SnapShot(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001FFF RID: 8191
	// (get) Token: 0x060059C2 RID: 22978 RVA: 0x0016713C File Offset: 0x0016533C
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<bl_SnapShot>.NativeClassPtr));
		}
	}

	// Token: 0x17002000 RID: 8192
	// (get) Token: 0x060059C3 RID: 22979 RVA: 0x00167150 File Offset: 0x00165350
	// (set) Token: 0x060059C4 RID: 22980 RVA: 0x00167178 File Offset: 0x00165378
	public unsafe int resWidth
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_SnapShot.NativeFieldInfoPtr_resWidth);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_SnapShot.NativeFieldInfoPtr_resWidth)) = value;
		}
	}

	// Token: 0x17002001 RID: 8193
	// (get) Token: 0x060059C5 RID: 22981 RVA: 0x0016719C File Offset: 0x0016539C
	// (set) Token: 0x060059C6 RID: 22982 RVA: 0x001671C4 File Offset: 0x001653C4
	public unsafe int resHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_SnapShot.NativeFieldInfoPtr_resHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_SnapShot.NativeFieldInfoPtr_resHeight)) = value;
		}
	}

	// Token: 0x17002002 RID: 8194
	// (get) Token: 0x060059C7 RID: 22983 RVA: 0x001671E8 File Offset: 0x001653E8
	// (set) Token: 0x060059C8 RID: 22984 RVA: 0x00167210 File Offset: 0x00165410
	public unsafe int msaa
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_SnapShot.NativeFieldInfoPtr_msaa);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_SnapShot.NativeFieldInfoPtr_msaa)) = value;
		}
	}

	// Token: 0x17002003 RID: 8195
	// (get) Token: 0x060059C9 RID: 22985 RVA: 0x00167234 File Offset: 0x00165434
	// (set) Token: 0x060059CA RID: 22986 RVA: 0x0016725D File Offset: 0x0016545D
	public unsafe string m_TakeSnapShot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_SnapShot.NativeFieldInfoPtr_m_TakeSnapShot);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_SnapShot.NativeFieldInfoPtr_m_TakeSnapShot), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17002004 RID: 8196
	// (get) Token: 0x060059CB RID: 22987 RVA: 0x00167284 File Offset: 0x00165484
	// (set) Token: 0x060059CC RID: 22988 RVA: 0x001672A4 File Offset: 0x001654A4
	public unsafe static string _folderPath
	{
		get
		{
			IntPtr il2CppString;
			IL2CPP.il2cpp_field_static_get_value(bl_SnapShot.NativeFieldInfoPtr__folderPath, (void*)(&il2CppString));
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(bl_SnapShot.NativeFieldInfoPtr__folderPath, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040038C9 RID: 14537
	private static readonly IntPtr NativeFieldInfoPtr_resWidth;

	// Token: 0x040038CA RID: 14538
	private static readonly IntPtr NativeFieldInfoPtr_resHeight;

	// Token: 0x040038CB RID: 14539
	private static readonly IntPtr NativeFieldInfoPtr_msaa;

	// Token: 0x040038CC RID: 14540
	private static readonly IntPtr NativeFieldInfoPtr_m_TakeSnapShot;

	// Token: 0x040038CD RID: 14541
	private static readonly IntPtr NativeFieldInfoPtr__folderPath;

	// Token: 0x040038CE RID: 14542
	private static readonly IntPtr NativeMethodInfoPtr_get_FolderPath_Public_Static_get_String_0;

	// Token: 0x040038CF RID: 14543
	private static readonly IntPtr NativeMethodInfoPtr_GetFullFolderPath_Private_String_0;

	// Token: 0x040038D0 RID: 14544
	private static readonly IntPtr NativeMethodInfoPtr_TakeSnapshot_Public_Void_0;

	// Token: 0x040038D1 RID: 14545
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
