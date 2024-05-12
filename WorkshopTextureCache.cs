using System;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000265 RID: 613
public class WorkshopTextureCache : Il2CppSystem.Object
{
	// Token: 0x1700101C RID: 4124
	// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x000B0D10 File Offset: 0x000AEF10
	public unsafe MonoBehaviour HostBehavior
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopTextureCache.NativeMethodInfoPtr_get_HostBehavior_Public_get_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new MonoBehaviour(intPtr2) : null;
		}
	}

	// Token: 0x06002CF9 RID: 11513 RVA: 0x000B0D68 File Offset: 0x000AEF68
	[CallerCount(0)]
	public unsafe WorkshopTextureCache(MonoBehaviour hostBehaviour) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(hostBehaviour);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopTextureCache.NativeMethodInfoPtr__ctor_Public_Void_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002CFA RID: 11514 RVA: 0x000B0DCC File Offset: 0x000AEFCC
	[CallerCount(0)]
	public unsafe WorkshopTextureState ResolveTexture(string imageID, string url, bool isMetaDownload, bool allowCache = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(imageID);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMetaDownload;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowCache;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopTextureCache.NativeMethodInfoPtr_ResolveTexture_Public_WorkshopTextureState_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new WorkshopTextureState(intPtr2) : null;
	}

	// Token: 0x06002CFB RID: 11515 RVA: 0x000B0E78 File Offset: 0x000AF078
	[CallerCount(0)]
	public unsafe IEnumerator DownloadTexture(string imageId, string url, WorkshopTextureState state, bool allowCache, bool isMetaDownload)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(imageId);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowCache;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMetaDownload;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopTextureCache.NativeMethodInfoPtr_DownloadTexture_Private_IEnumerator_String_String_WorkshopTextureState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x06002CFC RID: 11516 RVA: 0x000B0F3C File Offset: 0x000AF13C
	[CallerCount(0)]
	public unsafe static void CheckCache()
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopTextureCache.NativeMethodInfoPtr_CheckCache_Private_Static_Void_0, 0, (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002CFD RID: 11517 RVA: 0x000B0F70 File Offset: 0x000AF170
	// Note: this type is marked as 'beforefieldinit'.
	static WorkshopTextureCache()
	{
		Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WorkshopTextureCache");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr);
		WorkshopTextureCache.NativeFieldInfoPtr_MAXIMUM_CACHE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr, "MAXIMUM_CACHE_SIZE");
		WorkshopTextureCache.NativeFieldInfoPtr_m_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr, "m_cache");
		WorkshopTextureCache.NativeFieldInfoPtr_m_hostBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr, "m_hostBehaviour");
		WorkshopTextureCache.NativeFieldInfoPtr_m_cacheCheckDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr, "m_cacheCheckDone");
		WorkshopTextureCache.NativeMethodInfoPtr_get_HostBehavior_Public_get_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr, 100666676);
		WorkshopTextureCache.NativeMethodInfoPtr__ctor_Public_Void_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr, 100666677);
		WorkshopTextureCache.NativeMethodInfoPtr_ResolveTexture_Public_WorkshopTextureState_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr, 100666678);
		WorkshopTextureCache.NativeMethodInfoPtr_DownloadTexture_Private_IEnumerator_String_String_WorkshopTextureState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr, 100666679);
		WorkshopTextureCache.NativeMethodInfoPtr_CheckCache_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr, 100666680);
	}

	// Token: 0x06002CFE RID: 11518 RVA: 0x00002988 File Offset: 0x00000B88
	public WorkshopTextureCache(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001017 RID: 4119
	// (get) Token: 0x06002CFF RID: 11519 RVA: 0x000B1054 File Offset: 0x000AF254
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr));
		}
	}

	// Token: 0x17001018 RID: 4120
	// (get) Token: 0x06002D00 RID: 11520 RVA: 0x000B1068 File Offset: 0x000AF268
	// (set) Token: 0x06002D01 RID: 11521 RVA: 0x000B1086 File Offset: 0x000AF286
	public unsafe static int MAXIMUM_CACHE_SIZE
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(WorkshopTextureCache.NativeFieldInfoPtr_MAXIMUM_CACHE_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WorkshopTextureCache.NativeFieldInfoPtr_MAXIMUM_CACHE_SIZE, (void*)(&value));
		}
	}

	// Token: 0x17001019 RID: 4121
	// (get) Token: 0x06002D02 RID: 11522 RVA: 0x000B1098 File Offset: 0x000AF298
	// (set) Token: 0x06002D03 RID: 11523 RVA: 0x000B10CC File Offset: 0x000AF2CC
	public unsafe Dictionary<string, WorkshopTextureState> m_cache
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache.NativeFieldInfoPtr_m_cache);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Dictionary<string, WorkshopTextureState>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache.NativeFieldInfoPtr_m_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700101A RID: 4122
	// (get) Token: 0x06002D04 RID: 11524 RVA: 0x000B10F4 File Offset: 0x000AF2F4
	// (set) Token: 0x06002D05 RID: 11525 RVA: 0x000B1128 File Offset: 0x000AF328
	public unsafe MonoBehaviour m_hostBehaviour
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache.NativeFieldInfoPtr_m_hostBehaviour);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new MonoBehaviour(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache.NativeFieldInfoPtr_m_hostBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700101B RID: 4123
	// (get) Token: 0x06002D06 RID: 11526 RVA: 0x000B1150 File Offset: 0x000AF350
	// (set) Token: 0x06002D07 RID: 11527 RVA: 0x000B116E File Offset: 0x000AF36E
	public unsafe static bool m_cacheCheckDone
	{
		get
		{
			bool result;
			IL2CPP.il2cpp_field_static_get_value(WorkshopTextureCache.NativeFieldInfoPtr_m_cacheCheckDone, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WorkshopTextureCache.NativeFieldInfoPtr_m_cacheCheckDone, (void*)(&value));
		}
	}

	// Token: 0x04001C83 RID: 7299
	private static readonly IntPtr NativeFieldInfoPtr_MAXIMUM_CACHE_SIZE;

	// Token: 0x04001C84 RID: 7300
	private static readonly IntPtr NativeFieldInfoPtr_m_cache;

	// Token: 0x04001C85 RID: 7301
	private static readonly IntPtr NativeFieldInfoPtr_m_hostBehaviour;

	// Token: 0x04001C86 RID: 7302
	private static readonly IntPtr NativeFieldInfoPtr_m_cacheCheckDone;

	// Token: 0x04001C87 RID: 7303
	private static readonly IntPtr NativeMethodInfoPtr_get_HostBehavior_Public_get_MonoBehaviour_0;

	// Token: 0x04001C88 RID: 7304
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MonoBehaviour_0;

	// Token: 0x04001C89 RID: 7305
	private static readonly IntPtr NativeMethodInfoPtr_ResolveTexture_Public_WorkshopTextureState_String_String_Boolean_Boolean_0;

	// Token: 0x04001C8A RID: 7306
	private static readonly IntPtr NativeMethodInfoPtr_DownloadTexture_Private_IEnumerator_String_String_WorkshopTextureState_Boolean_Boolean_0;

	// Token: 0x04001C8B RID: 7307
	private static readonly IntPtr NativeMethodInfoPtr_CheckCache_Private_Static_Void_0;

	// Token: 0x02000266 RID: 614
	[ObfuscatedName("WorkshopTextureCache/<DownloadTexture>d__7")]
	public sealed class _DownloadTexture_d__7 : Il2CppSystem.Object
	{
		// Token: 0x06002D08 RID: 11528 RVA: 0x000B1180 File Offset: 0x000AF380
		[CallerCount(0)]
		public unsafe _DownloadTexture_d__7(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopTextureCache._DownloadTexture_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x000B11E0 File Offset: 0x000AF3E0
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopTextureCache._DownloadTexture_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x000B1224 File Offset: 0x000AF424
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WorkshopTextureCache._DownloadTexture_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x000B1274 File Offset: 0x000AF474
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopTextureCache._DownloadTexture_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x000B12CC File Offset: 0x000AF4CC
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopTextureCache._DownloadTexture_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x000B1310 File Offset: 0x000AF510
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorkshopTextureCache._DownloadTexture_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x000B1368 File Offset: 0x000AF568
		// Note: this type is marked as 'beforefieldinit'.
		static _DownloadTexture_d__7()
		{
			Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorkshopTextureCache>.NativeClassPtr, "<DownloadTexture>d__7");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr);
			WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, "<>1__state");
			WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, "<>2__current");
			WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, "state");
			WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_allowCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, "allowCache");
			WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_imageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, "imageId");
			WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, "url");
			WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_isMetaDownload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, "isMetaDownload");
			WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr__cachedThumbPath_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, "<cachedThumbPath>5__2");
			WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr__request_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, "<request>5__3");
			WorkshopTextureCache._DownloadTexture_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, 100666681);
			WorkshopTextureCache._DownloadTexture_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, 100666682);
			WorkshopTextureCache._DownloadTexture_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, 100666683);
			WorkshopTextureCache._DownloadTexture_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, 100666684);
			WorkshopTextureCache._DownloadTexture_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, 100666685);
			WorkshopTextureCache._DownloadTexture_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr, 100666686);
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00002988 File Offset: 0x00000B88
		public _DownloadTexture_d__7(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x000B14BF File Offset: 0x000AF6BF
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WorkshopTextureCache._DownloadTexture_d__7>.NativeClassPtr));
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x000B14D0 File Offset: 0x000AF6D0
		// (set) Token: 0x06002D12 RID: 11538 RVA: 0x000B14F8 File Offset: 0x000AF6F8
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06002D13 RID: 11539 RVA: 0x000B151C File Offset: 0x000AF71C
		// (set) Token: 0x06002D14 RID: 11540 RVA: 0x000B1550 File Offset: 0x000AF750
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x000B1578 File Offset: 0x000AF778
		// (set) Token: 0x06002D16 RID: 11542 RVA: 0x000B15AC File Offset: 0x000AF7AC
		public unsafe WorkshopTextureState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new WorkshopTextureState(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x000B15D4 File Offset: 0x000AF7D4
		// (set) Token: 0x06002D18 RID: 11544 RVA: 0x000B15FC File Offset: 0x000AF7FC
		public unsafe bool allowCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_allowCache);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_allowCache)) = value;
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06002D19 RID: 11545 RVA: 0x000B1620 File Offset: 0x000AF820
		// (set) Token: 0x06002D1A RID: 11546 RVA: 0x000B1649 File Offset: 0x000AF849
		public unsafe string imageId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_imageId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_imageId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06002D1B RID: 11547 RVA: 0x000B1670 File Offset: 0x000AF870
		// (set) Token: 0x06002D1C RID: 11548 RVA: 0x000B1699 File Offset: 0x000AF899
		public unsafe string url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x000B16C0 File Offset: 0x000AF8C0
		// (set) Token: 0x06002D1E RID: 11550 RVA: 0x000B16E8 File Offset: 0x000AF8E8
		public unsafe bool isMetaDownload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_isMetaDownload);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr_isMetaDownload)) = value;
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06002D1F RID: 11551 RVA: 0x000B170C File Offset: 0x000AF90C
		// (set) Token: 0x06002D20 RID: 11552 RVA: 0x000B1735 File Offset: 0x000AF935
		public unsafe string _cachedThumbPath_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr__cachedThumbPath_5__2);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr__cachedThumbPath_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06002D21 RID: 11553 RVA: 0x000B175C File Offset: 0x000AF95C
		// (set) Token: 0x06002D22 RID: 11554 RVA: 0x000B1790 File Offset: 0x000AF990
		public unsafe UnityWebRequest _request_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr__request_5__3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new UnityWebRequest(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorkshopTextureCache._DownloadTexture_d__7.NativeFieldInfoPtr__request_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001C8E RID: 7310
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001C8F RID: 7311
		private static readonly IntPtr NativeFieldInfoPtr_allowCache;

		// Token: 0x04001C90 RID: 7312
		private static readonly IntPtr NativeFieldInfoPtr_imageId;

		// Token: 0x04001C91 RID: 7313
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x04001C92 RID: 7314
		private static readonly IntPtr NativeFieldInfoPtr_isMetaDownload;

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeFieldInfoPtr__cachedThumbPath_5__2;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeFieldInfoPtr__request_5__3;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
