using System;
using AK.Wwise;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000458 RID: 1112
public class WatchBeepPlayer : Il2CppSystem.Object
{
	// Token: 0x06005964 RID: 22884 RVA: 0x00165B68 File Offset: 0x00163D68
	[CallerCount(0)]
	public unsafe WatchBeepPlayer(GameObject go, Transform t, AK.Wwise.Event beep) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beep);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchBeepPlayer.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Transform_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005965 RID: 22885 RVA: 0x00165BFC File Offset: 0x00163DFC
	[CallerCount(0)]
	public unsafe void Play()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchBeepPlayer.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005966 RID: 22886 RVA: 0x00165C40 File Offset: 0x00163E40
	[CallerCount(0)]
	public unsafe void Tick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchBeepPlayer.NativeMethodInfoPtr_Tick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005967 RID: 22887 RVA: 0x00165C84 File Offset: 0x00163E84
	[CallerCount(0)]
	public unsafe void SyncBeepPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchBeepPlayer.NativeMethodInfoPtr_SyncBeepPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005968 RID: 22888 RVA: 0x00165CC8 File Offset: 0x00163EC8
	[CallerCount(0)]
	public unsafe bool CheckIsPlaying()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WatchBeepPlayer.NativeMethodInfoPtr_CheckIsPlaying_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06005969 RID: 22889 RVA: 0x00165D18 File Offset: 0x00163F18
	// Note: this type is marked as 'beforefieldinit'.
	static WatchBeepPlayer()
	{
		Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WatchBeepPlayer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr);
		WatchBeepPlayer.NativeFieldInfoPtr_playingIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr, "playingIds");
		WatchBeepPlayer.NativeFieldInfoPtr__go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr, "_go");
		WatchBeepPlayer.NativeFieldInfoPtr__t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr, "_t");
		WatchBeepPlayer.NativeFieldInfoPtr__beep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr, "_beep");
		WatchBeepPlayer.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr, "_id");
		WatchBeepPlayer.NativeFieldInfoPtr__playing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr, "_playing");
		WatchBeepPlayer.NativeMethodInfoPtr__ctor_Public_Void_GameObject_Transform_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr, 100670322);
		WatchBeepPlayer.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr, 100670323);
		WatchBeepPlayer.NativeMethodInfoPtr_Tick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr, 100670324);
		WatchBeepPlayer.NativeMethodInfoPtr_SyncBeepPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr, 100670325);
		WatchBeepPlayer.NativeMethodInfoPtr_CheckIsPlaying_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr, 100670326);
	}

	// Token: 0x0600596A RID: 22890 RVA: 0x00002988 File Offset: 0x00000B88
	public WatchBeepPlayer(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001FDF RID: 8159
	// (get) Token: 0x0600596B RID: 22891 RVA: 0x00165E24 File Offset: 0x00164024
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WatchBeepPlayer>.NativeClassPtr));
		}
	}

	// Token: 0x17001FE0 RID: 8160
	// (get) Token: 0x0600596C RID: 22892 RVA: 0x00165E38 File Offset: 0x00164038
	// (set) Token: 0x0600596D RID: 22893 RVA: 0x00165E63 File Offset: 0x00164063
	public unsafe static Il2CppStructArray<uint> playingIds
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WatchBeepPlayer.NativeFieldInfoPtr_playingIds, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Il2CppStructArray<uint>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WatchBeepPlayer.NativeFieldInfoPtr_playingIds, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FE1 RID: 8161
	// (get) Token: 0x0600596E RID: 22894 RVA: 0x00165E78 File Offset: 0x00164078
	// (set) Token: 0x0600596F RID: 22895 RVA: 0x00165EAC File Offset: 0x001640AC
	public unsafe GameObject _go
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchBeepPlayer.NativeFieldInfoPtr__go);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchBeepPlayer.NativeFieldInfoPtr__go), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FE2 RID: 8162
	// (get) Token: 0x06005970 RID: 22896 RVA: 0x00165ED4 File Offset: 0x001640D4
	// (set) Token: 0x06005971 RID: 22897 RVA: 0x00165F08 File Offset: 0x00164108
	public unsafe Transform _t
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchBeepPlayer.NativeFieldInfoPtr__t);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchBeepPlayer.NativeFieldInfoPtr__t), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FE3 RID: 8163
	// (get) Token: 0x06005972 RID: 22898 RVA: 0x00165F30 File Offset: 0x00164130
	// (set) Token: 0x06005973 RID: 22899 RVA: 0x00165F64 File Offset: 0x00164164
	public unsafe AK.Wwise.Event _beep
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchBeepPlayer.NativeFieldInfoPtr__beep);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchBeepPlayer.NativeFieldInfoPtr__beep), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FE4 RID: 8164
	// (get) Token: 0x06005974 RID: 22900 RVA: 0x00165F8C File Offset: 0x0016418C
	// (set) Token: 0x06005975 RID: 22901 RVA: 0x00165FB4 File Offset: 0x001641B4
	public unsafe uint _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchBeepPlayer.NativeFieldInfoPtr__id);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchBeepPlayer.NativeFieldInfoPtr__id)) = value;
		}
	}

	// Token: 0x17001FE5 RID: 8165
	// (get) Token: 0x06005976 RID: 22902 RVA: 0x00165FD8 File Offset: 0x001641D8
	// (set) Token: 0x06005977 RID: 22903 RVA: 0x00166000 File Offset: 0x00164200
	public unsafe bool _playing
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchBeepPlayer.NativeFieldInfoPtr__playing);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchBeepPlayer.NativeFieldInfoPtr__playing)) = value;
		}
	}

	// Token: 0x04003896 RID: 14486
	private static readonly IntPtr NativeFieldInfoPtr_playingIds;

	// Token: 0x04003897 RID: 14487
	private static readonly IntPtr NativeFieldInfoPtr__go;

	// Token: 0x04003898 RID: 14488
	private static readonly IntPtr NativeFieldInfoPtr__t;

	// Token: 0x04003899 RID: 14489
	private static readonly IntPtr NativeFieldInfoPtr__beep;

	// Token: 0x0400389A RID: 14490
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x0400389B RID: 14491
	private static readonly IntPtr NativeFieldInfoPtr__playing;

	// Token: 0x0400389C RID: 14492
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_Transform_Event_0;

	// Token: 0x0400389D RID: 14493
	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

	// Token: 0x0400389E RID: 14494
	private static readonly IntPtr NativeMethodInfoPtr_Tick_Public_Void_0;

	// Token: 0x0400389F RID: 14495
	private static readonly IntPtr NativeMethodInfoPtr_SyncBeepPosition_Private_Void_0;

	// Token: 0x040038A0 RID: 14496
	private static readonly IntPtr NativeMethodInfoPtr_CheckIsPlaying_Private_Boolean_0;
}
