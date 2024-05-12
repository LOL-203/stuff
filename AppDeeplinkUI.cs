using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000059 RID: 89
public class AppDeeplinkUI : MonoBehaviour
{
	// Token: 0x06000588 RID: 1416 RVA: 0x000186FC File Offset: 0x000168FC
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDeeplinkUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x00018740 File Offset: 0x00016940
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDeeplinkUI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x00018784 File Offset: 0x00016984
	[CallerCount(0)]
	public unsafe void LaunchUnrealDeeplinkSample()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDeeplinkUI.NativeMethodInfoPtr_LaunchUnrealDeeplinkSample_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x000187C8 File Offset: 0x000169C8
	[CallerCount(0)]
	public unsafe void LaunchSelf()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDeeplinkUI.NativeMethodInfoPtr_LaunchSelf_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x0001880C File Offset: 0x00016A0C
	[CallerCount(0)]
	public unsafe void LaunchOtherApp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDeeplinkUI.NativeMethodInfoPtr_LaunchOtherApp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x00018850 File Offset: 0x00016A50
	[CallerCount(0)]
	public unsafe AppDeeplinkUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDeeplinkUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x0001889C File Offset: 0x00016A9C
	// Note: this type is marked as 'beforefieldinit'.
	static AppDeeplinkUI()
	{
		Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AppDeeplinkUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr);
		AppDeeplinkUI.NativeFieldInfoPtr_UNITY_COMPANION_APP_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, "UNITY_COMPANION_APP_ID");
		AppDeeplinkUI.NativeFieldInfoPtr_UNREAL_COMPANION_APP_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, "UNREAL_COMPANION_APP_ID");
		AppDeeplinkUI.NativeFieldInfoPtr_deeplinkAppId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, "deeplinkAppId");
		AppDeeplinkUI.NativeFieldInfoPtr_deeplinkMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, "deeplinkMessage");
		AppDeeplinkUI.NativeFieldInfoPtr_uiLaunchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, "uiLaunchType");
		AppDeeplinkUI.NativeFieldInfoPtr_uiLaunchSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, "uiLaunchSource");
		AppDeeplinkUI.NativeFieldInfoPtr_uiDeepLinkMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, "uiDeepLinkMessage");
		AppDeeplinkUI.NativeFieldInfoPtr_inMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, "inMenu");
		AppDeeplinkUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, 100663772);
		AppDeeplinkUI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, 100663773);
		AppDeeplinkUI.NativeMethodInfoPtr_LaunchUnrealDeeplinkSample_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, 100663774);
		AppDeeplinkUI.NativeMethodInfoPtr_LaunchSelf_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, 100663775);
		AppDeeplinkUI.NativeMethodInfoPtr_LaunchOtherApp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, 100663776);
		AppDeeplinkUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr, 100663777);
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x0000210C File Offset: 0x0000030C
	public AppDeeplinkUI(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x06000590 RID: 1424 RVA: 0x000189E4 File Offset: 0x00016BE4
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AppDeeplinkUI>.NativeClassPtr));
		}
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06000591 RID: 1425 RVA: 0x000189F8 File Offset: 0x00016BF8
	// (set) Token: 0x06000592 RID: 1426 RVA: 0x00018A16 File Offset: 0x00016C16
	public unsafe static ulong UNITY_COMPANION_APP_ID
	{
		get
		{
			ulong result;
			IL2CPP.il2cpp_field_static_get_value(AppDeeplinkUI.NativeFieldInfoPtr_UNITY_COMPANION_APP_ID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AppDeeplinkUI.NativeFieldInfoPtr_UNITY_COMPANION_APP_ID, (void*)(&value));
		}
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x06000593 RID: 1427 RVA: 0x00018A28 File Offset: 0x00016C28
	// (set) Token: 0x06000594 RID: 1428 RVA: 0x00018A46 File Offset: 0x00016C46
	public unsafe static ulong UNREAL_COMPANION_APP_ID
	{
		get
		{
			ulong result;
			IL2CPP.il2cpp_field_static_get_value(AppDeeplinkUI.NativeFieldInfoPtr_UNREAL_COMPANION_APP_ID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AppDeeplinkUI.NativeFieldInfoPtr_UNREAL_COMPANION_APP_ID, (void*)(&value));
		}
	}

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x06000595 RID: 1429 RVA: 0x00018A58 File Offset: 0x00016C58
	// (set) Token: 0x06000596 RID: 1430 RVA: 0x00018A8C File Offset: 0x00016C8C
	public unsafe RectTransform deeplinkAppId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDeeplinkUI.NativeFieldInfoPtr_deeplinkAppId);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDeeplinkUI.NativeFieldInfoPtr_deeplinkAppId), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x06000597 RID: 1431 RVA: 0x00018AB4 File Offset: 0x00016CB4
	// (set) Token: 0x06000598 RID: 1432 RVA: 0x00018AE8 File Offset: 0x00016CE8
	public unsafe RectTransform deeplinkMessage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDeeplinkUI.NativeFieldInfoPtr_deeplinkMessage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDeeplinkUI.NativeFieldInfoPtr_deeplinkMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x06000599 RID: 1433 RVA: 0x00018B10 File Offset: 0x00016D10
	// (set) Token: 0x0600059A RID: 1434 RVA: 0x00018B44 File Offset: 0x00016D44
	public unsafe RectTransform uiLaunchType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDeeplinkUI.NativeFieldInfoPtr_uiLaunchType);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDeeplinkUI.NativeFieldInfoPtr_uiLaunchType), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x0600059B RID: 1435 RVA: 0x00018B6C File Offset: 0x00016D6C
	// (set) Token: 0x0600059C RID: 1436 RVA: 0x00018BA0 File Offset: 0x00016DA0
	public unsafe RectTransform uiLaunchSource
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDeeplinkUI.NativeFieldInfoPtr_uiLaunchSource);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDeeplinkUI.NativeFieldInfoPtr_uiLaunchSource), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x0600059D RID: 1437 RVA: 0x00018BC8 File Offset: 0x00016DC8
	// (set) Token: 0x0600059E RID: 1438 RVA: 0x00018BFC File Offset: 0x00016DFC
	public unsafe RectTransform uiDeepLinkMessage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDeeplinkUI.NativeFieldInfoPtr_uiDeepLinkMessage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDeeplinkUI.NativeFieldInfoPtr_uiDeepLinkMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x0600059F RID: 1439 RVA: 0x00018C24 File Offset: 0x00016E24
	// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00018C4C File Offset: 0x00016E4C
	public unsafe bool inMenu
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDeeplinkUI.NativeFieldInfoPtr_inMenu);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDeeplinkUI.NativeFieldInfoPtr_inMenu)) = value;
		}
	}

	// Token: 0x0400037F RID: 895
	private static readonly IntPtr NativeFieldInfoPtr_UNITY_COMPANION_APP_ID;

	// Token: 0x04000380 RID: 896
	private static readonly IntPtr NativeFieldInfoPtr_UNREAL_COMPANION_APP_ID;

	// Token: 0x04000381 RID: 897
	private static readonly IntPtr NativeFieldInfoPtr_deeplinkAppId;

	// Token: 0x04000382 RID: 898
	private static readonly IntPtr NativeFieldInfoPtr_deeplinkMessage;

	// Token: 0x04000383 RID: 899
	private static readonly IntPtr NativeFieldInfoPtr_uiLaunchType;

	// Token: 0x04000384 RID: 900
	private static readonly IntPtr NativeFieldInfoPtr_uiLaunchSource;

	// Token: 0x04000385 RID: 901
	private static readonly IntPtr NativeFieldInfoPtr_uiDeepLinkMessage;

	// Token: 0x04000386 RID: 902
	private static readonly IntPtr NativeFieldInfoPtr_inMenu;

	// Token: 0x04000387 RID: 903
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000388 RID: 904
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000389 RID: 905
	private static readonly IntPtr NativeMethodInfoPtr_LaunchUnrealDeeplinkSample_Private_Void_0;

	// Token: 0x0400038A RID: 906
	private static readonly IntPtr NativeMethodInfoPtr_LaunchSelf_Private_Void_0;

	// Token: 0x0400038B RID: 907
	private static readonly IntPtr NativeMethodInfoPtr_LaunchOtherApp_Private_Void_0;

	// Token: 0x0400038C RID: 908
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
