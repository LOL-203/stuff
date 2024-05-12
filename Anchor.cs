using System;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000099 RID: 153
public class Anchor : MonoBehaviour
{
	// Token: 0x06000960 RID: 2400 RVA: 0x00027264 File Offset: 0x00025464
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x000272A8 File Offset: 0x000254A8
	[CallerCount(0)]
	public unsafe IEnumerator Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00027300 File Offset: 0x00025500
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00027344 File Offset: 0x00025544
	[CallerCount(0)]
	public unsafe void OnSaveLocalButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr_OnSaveLocalButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00027388 File Offset: 0x00025588
	[CallerCount(0)]
	public unsafe void OnHideButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr_OnHideButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x000273CC File Offset: 0x000255CC
	[CallerCount(0)]
	public unsafe void OnEraseButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr_OnEraseButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x1700034D RID: 845
	// (set) Token: 0x06000966 RID: 2406 RVA: 0x00027410 File Offset: 0x00025610
	public unsafe bool ShowSaveIcon
	{
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr_set_ShowSaveIcon_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00027464 File Offset: 0x00025664
	[CallerCount(0)]
	public unsafe void OnHoverStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr_OnHoverStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x000274A8 File Offset: 0x000256A8
	[CallerCount(0)]
	public unsafe void OnHoverEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr_OnHoverEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x000274EC File Offset: 0x000256EC
	[CallerCount(0)]
	public unsafe void OnSelect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr_OnSelect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x00027530 File Offset: 0x00025730
	[CallerCount(0)]
	public unsafe void BillboardPanel(Transform panel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr_BillboardPanel_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x0002758C File Offset: 0x0002578C
	[CallerCount(0)]
	public unsafe void HandleMenuNavigation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr_HandleMenuNavigation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x000275D0 File Offset: 0x000257D0
	[CallerCount(0)]
	public unsafe void NavigateToIndexInMenu(bool moveNext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref moveNext;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr_NavigateToIndexInMenu_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x00027624 File Offset: 0x00025824
	[CallerCount(0)]
	public unsafe Anchor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Anchor>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x00027670 File Offset: 0x00025870
	[CallerCount(0)]
	public unsafe void _OnSaveLocalButtonPressed_b__22_0(OVRSpatialAnchor anchor, bool success)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(anchor);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr__OnSaveLocalButtonPressed_b__22_0_Private_Void_OVRSpatialAnchor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600096F RID: 2415 RVA: 0x000276DC File Offset: 0x000258DC
	[CallerCount(0)]
	public unsafe void _OnEraseButtonPressed_b__24_0(OVRSpatialAnchor anchor, bool success)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(anchor);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor.NativeMethodInfoPtr__OnEraseButtonPressed_b__24_0_Private_Void_OVRSpatialAnchor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000970 RID: 2416 RVA: 0x00027748 File Offset: 0x00025948
	// Note: this type is marked as 'beforefieldinit'.
	static Anchor()
	{
		Il2CppClassPointerStore<Anchor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Anchor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Anchor>.NativeClassPtr);
		Anchor.NativeFieldInfoPtr_NumUuidsPlayerPref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "NumUuidsPlayerPref");
		Anchor.NativeFieldInfoPtr__canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_canvas");
		Anchor.NativeFieldInfoPtr__pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_pivot");
		Anchor.NativeFieldInfoPtr__anchorMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_anchorMenu");
		Anchor.NativeFieldInfoPtr__isSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_isSelected");
		Anchor.NativeFieldInfoPtr__isHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_isHovered");
		Anchor.NativeFieldInfoPtr__anchorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_anchorName");
		Anchor.NativeFieldInfoPtr__saveIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_saveIcon");
		Anchor.NativeFieldInfoPtr__labelImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_labelImage");
		Anchor.NativeFieldInfoPtr__labelBaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_labelBaseColor");
		Anchor.NativeFieldInfoPtr__labelHighlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_labelHighlightColor");
		Anchor.NativeFieldInfoPtr__labelSelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_labelSelectedColor");
		Anchor.NativeFieldInfoPtr__uiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_uiManager");
		Anchor.NativeFieldInfoPtr__renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_renderers");
		Anchor.NativeFieldInfoPtr__menuIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_menuIndex");
		Anchor.NativeFieldInfoPtr__buttonList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_buttonList");
		Anchor.NativeFieldInfoPtr__selectedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_selectedButton");
		Anchor.NativeFieldInfoPtr__spatialAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_spatialAnchor");
		Anchor.NativeFieldInfoPtr__icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "_icon");
		Anchor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664048);
		Anchor.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664049);
		Anchor.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664050);
		Anchor.NativeMethodInfoPtr_OnSaveLocalButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664051);
		Anchor.NativeMethodInfoPtr_OnHideButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664052);
		Anchor.NativeMethodInfoPtr_OnEraseButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664053);
		Anchor.NativeMethodInfoPtr_set_ShowSaveIcon_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664054);
		Anchor.NativeMethodInfoPtr_OnHoverStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664055);
		Anchor.NativeMethodInfoPtr_OnHoverEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664056);
		Anchor.NativeMethodInfoPtr_OnSelect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664057);
		Anchor.NativeMethodInfoPtr_BillboardPanel_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664058);
		Anchor.NativeMethodInfoPtr_HandleMenuNavigation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664059);
		Anchor.NativeMethodInfoPtr_NavigateToIndexInMenu_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664060);
		Anchor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664061);
		Anchor.NativeMethodInfoPtr__OnSaveLocalButtonPressed_b__22_0_Private_Void_OVRSpatialAnchor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664062);
		Anchor.NativeMethodInfoPtr__OnEraseButtonPressed_b__24_0_Private_Void_OVRSpatialAnchor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor>.NativeClassPtr, 100664063);
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x0000210C File Offset: 0x0000030C
	public Anchor(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000339 RID: 825
	// (get) Token: 0x06000972 RID: 2418 RVA: 0x00027A34 File Offset: 0x00025C34
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Anchor>.NativeClassPtr));
		}
	}

	// Token: 0x1700033A RID: 826
	// (get) Token: 0x06000973 RID: 2419 RVA: 0x00027A48 File Offset: 0x00025C48
	// (set) Token: 0x06000974 RID: 2420 RVA: 0x00027A68 File Offset: 0x00025C68
	public unsafe static string NumUuidsPlayerPref
	{
		get
		{
			IntPtr il2CppString;
			IL2CPP.il2cpp_field_static_get_value(Anchor.NativeFieldInfoPtr_NumUuidsPlayerPref, (void*)(&il2CppString));
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Anchor.NativeFieldInfoPtr_NumUuidsPlayerPref, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700033B RID: 827
	// (get) Token: 0x06000975 RID: 2421 RVA: 0x00027A80 File Offset: 0x00025C80
	// (set) Token: 0x06000976 RID: 2422 RVA: 0x00027AB4 File Offset: 0x00025CB4
	public unsafe Canvas _canvas
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__canvas);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Canvas(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700033C RID: 828
	// (get) Token: 0x06000977 RID: 2423 RVA: 0x00027ADC File Offset: 0x00025CDC
	// (set) Token: 0x06000978 RID: 2424 RVA: 0x00027B10 File Offset: 0x00025D10
	public unsafe Transform _pivot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__pivot);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__pivot), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700033D RID: 829
	// (get) Token: 0x06000979 RID: 2425 RVA: 0x00027B38 File Offset: 0x00025D38
	// (set) Token: 0x0600097A RID: 2426 RVA: 0x00027B6C File Offset: 0x00025D6C
	public unsafe GameObject _anchorMenu
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__anchorMenu);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__anchorMenu), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700033E RID: 830
	// (get) Token: 0x0600097B RID: 2427 RVA: 0x00027B94 File Offset: 0x00025D94
	// (set) Token: 0x0600097C RID: 2428 RVA: 0x00027BBC File Offset: 0x00025DBC
	public unsafe bool _isSelected
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__isSelected);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__isSelected)) = value;
		}
	}

	// Token: 0x1700033F RID: 831
	// (get) Token: 0x0600097D RID: 2429 RVA: 0x00027BE0 File Offset: 0x00025DE0
	// (set) Token: 0x0600097E RID: 2430 RVA: 0x00027C08 File Offset: 0x00025E08
	public unsafe bool _isHovered
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__isHovered);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__isHovered)) = value;
		}
	}

	// Token: 0x17000340 RID: 832
	// (get) Token: 0x0600097F RID: 2431 RVA: 0x00027C2C File Offset: 0x00025E2C
	// (set) Token: 0x06000980 RID: 2432 RVA: 0x00027C60 File Offset: 0x00025E60
	public unsafe TextMeshProUGUI _anchorName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__anchorName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new TextMeshProUGUI(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__anchorName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000341 RID: 833
	// (get) Token: 0x06000981 RID: 2433 RVA: 0x00027C88 File Offset: 0x00025E88
	// (set) Token: 0x06000982 RID: 2434 RVA: 0x00027CBC File Offset: 0x00025EBC
	public unsafe GameObject _saveIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__saveIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__saveIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000342 RID: 834
	// (get) Token: 0x06000983 RID: 2435 RVA: 0x00027CE4 File Offset: 0x00025EE4
	// (set) Token: 0x06000984 RID: 2436 RVA: 0x00027D18 File Offset: 0x00025F18
	public unsafe Image _labelImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__labelImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Image(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__labelImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000343 RID: 835
	// (get) Token: 0x06000985 RID: 2437 RVA: 0x00027D40 File Offset: 0x00025F40
	// (set) Token: 0x06000986 RID: 2438 RVA: 0x00027D68 File Offset: 0x00025F68
	public unsafe Color _labelBaseColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__labelBaseColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__labelBaseColor)) = value;
		}
	}

	// Token: 0x17000344 RID: 836
	// (get) Token: 0x06000987 RID: 2439 RVA: 0x00027D8C File Offset: 0x00025F8C
	// (set) Token: 0x06000988 RID: 2440 RVA: 0x00027DB4 File Offset: 0x00025FB4
	public unsafe Color _labelHighlightColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__labelHighlightColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__labelHighlightColor)) = value;
		}
	}

	// Token: 0x17000345 RID: 837
	// (get) Token: 0x06000989 RID: 2441 RVA: 0x00027DD8 File Offset: 0x00025FD8
	// (set) Token: 0x0600098A RID: 2442 RVA: 0x00027E00 File Offset: 0x00026000
	public unsafe Color _labelSelectedColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__labelSelectedColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__labelSelectedColor)) = value;
		}
	}

	// Token: 0x17000346 RID: 838
	// (get) Token: 0x0600098B RID: 2443 RVA: 0x00027E24 File Offset: 0x00026024
	// (set) Token: 0x0600098C RID: 2444 RVA: 0x00027E58 File Offset: 0x00026058
	public unsafe AnchorUIManager _uiManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__uiManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AnchorUIManager(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__uiManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000347 RID: 839
	// (get) Token: 0x0600098D RID: 2445 RVA: 0x00027E80 File Offset: 0x00026080
	// (set) Token: 0x0600098E RID: 2446 RVA: 0x00027EB4 File Offset: 0x000260B4
	public unsafe Il2CppReferenceArray<MeshRenderer> _renderers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__renderers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<MeshRenderer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000348 RID: 840
	// (get) Token: 0x0600098F RID: 2447 RVA: 0x00027EDC File Offset: 0x000260DC
	// (set) Token: 0x06000990 RID: 2448 RVA: 0x00027F04 File Offset: 0x00026104
	public unsafe int _menuIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__menuIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__menuIndex)) = value;
		}
	}

	// Token: 0x17000349 RID: 841
	// (get) Token: 0x06000991 RID: 2449 RVA: 0x00027F28 File Offset: 0x00026128
	// (set) Token: 0x06000992 RID: 2450 RVA: 0x00027F5C File Offset: 0x0002615C
	public unsafe List<Button> _buttonList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__buttonList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__buttonList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700034A RID: 842
	// (get) Token: 0x06000993 RID: 2451 RVA: 0x00027F84 File Offset: 0x00026184
	// (set) Token: 0x06000994 RID: 2452 RVA: 0x00027FB8 File Offset: 0x000261B8
	public unsafe Button _selectedButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__selectedButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Button(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__selectedButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700034B RID: 843
	// (get) Token: 0x06000995 RID: 2453 RVA: 0x00027FE0 File Offset: 0x000261E0
	// (set) Token: 0x06000996 RID: 2454 RVA: 0x00028014 File Offset: 0x00026214
	public unsafe OVRSpatialAnchor _spatialAnchor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__spatialAnchor);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new OVRSpatialAnchor(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__spatialAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x06000997 RID: 2455 RVA: 0x0002803C File Offset: 0x0002623C
	// (set) Token: 0x06000998 RID: 2456 RVA: 0x00028070 File Offset: 0x00026270
	public unsafe GameObject _icon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__icon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor.NativeFieldInfoPtr__icon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040005BA RID: 1466
	private static readonly IntPtr NativeFieldInfoPtr_NumUuidsPlayerPref;

	// Token: 0x040005BB RID: 1467
	private static readonly IntPtr NativeFieldInfoPtr__canvas;

	// Token: 0x040005BC RID: 1468
	private static readonly IntPtr NativeFieldInfoPtr__pivot;

	// Token: 0x040005BD RID: 1469
	private static readonly IntPtr NativeFieldInfoPtr__anchorMenu;

	// Token: 0x040005BE RID: 1470
	private static readonly IntPtr NativeFieldInfoPtr__isSelected;

	// Token: 0x040005BF RID: 1471
	private static readonly IntPtr NativeFieldInfoPtr__isHovered;

	// Token: 0x040005C0 RID: 1472
	private static readonly IntPtr NativeFieldInfoPtr__anchorName;

	// Token: 0x040005C1 RID: 1473
	private static readonly IntPtr NativeFieldInfoPtr__saveIcon;

	// Token: 0x040005C2 RID: 1474
	private static readonly IntPtr NativeFieldInfoPtr__labelImage;

	// Token: 0x040005C3 RID: 1475
	private static readonly IntPtr NativeFieldInfoPtr__labelBaseColor;

	// Token: 0x040005C4 RID: 1476
	private static readonly IntPtr NativeFieldInfoPtr__labelHighlightColor;

	// Token: 0x040005C5 RID: 1477
	private static readonly IntPtr NativeFieldInfoPtr__labelSelectedColor;

	// Token: 0x040005C6 RID: 1478
	private static readonly IntPtr NativeFieldInfoPtr__uiManager;

	// Token: 0x040005C7 RID: 1479
	private static readonly IntPtr NativeFieldInfoPtr__renderers;

	// Token: 0x040005C8 RID: 1480
	private static readonly IntPtr NativeFieldInfoPtr__menuIndex;

	// Token: 0x040005C9 RID: 1481
	private static readonly IntPtr NativeFieldInfoPtr__buttonList;

	// Token: 0x040005CA RID: 1482
	private static readonly IntPtr NativeFieldInfoPtr__selectedButton;

	// Token: 0x040005CB RID: 1483
	private static readonly IntPtr NativeFieldInfoPtr__spatialAnchor;

	// Token: 0x040005CC RID: 1484
	private static readonly IntPtr NativeFieldInfoPtr__icon;

	// Token: 0x040005CD RID: 1485
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040005CE RID: 1486
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

	// Token: 0x040005CF RID: 1487
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040005D0 RID: 1488
	private static readonly IntPtr NativeMethodInfoPtr_OnSaveLocalButtonPressed_Public_Void_0;

	// Token: 0x040005D1 RID: 1489
	private static readonly IntPtr NativeMethodInfoPtr_OnHideButtonPressed_Public_Void_0;

	// Token: 0x040005D2 RID: 1490
	private static readonly IntPtr NativeMethodInfoPtr_OnEraseButtonPressed_Public_Void_0;

	// Token: 0x040005D3 RID: 1491
	private static readonly IntPtr NativeMethodInfoPtr_set_ShowSaveIcon_Public_set_Void_Boolean_0;

	// Token: 0x040005D4 RID: 1492
	private static readonly IntPtr NativeMethodInfoPtr_OnHoverStart_Public_Void_0;

	// Token: 0x040005D5 RID: 1493
	private static readonly IntPtr NativeMethodInfoPtr_OnHoverEnd_Public_Void_0;

	// Token: 0x040005D6 RID: 1494
	private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Void_0;

	// Token: 0x040005D7 RID: 1495
	private static readonly IntPtr NativeMethodInfoPtr_BillboardPanel_Private_Void_Transform_0;

	// Token: 0x040005D8 RID: 1496
	private static readonly IntPtr NativeMethodInfoPtr_HandleMenuNavigation_Private_Void_0;

	// Token: 0x040005D9 RID: 1497
	private static readonly IntPtr NativeMethodInfoPtr_NavigateToIndexInMenu_Private_Void_Boolean_0;

	// Token: 0x040005DA RID: 1498
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040005DB RID: 1499
	private static readonly IntPtr NativeMethodInfoPtr__OnSaveLocalButtonPressed_b__22_0_Private_Void_OVRSpatialAnchor_Boolean_0;

	// Token: 0x040005DC RID: 1500
	private static readonly IntPtr NativeMethodInfoPtr__OnEraseButtonPressed_b__24_0_Private_Void_OVRSpatialAnchor_Boolean_0;

	// Token: 0x0200009A RID: 154
	[ObfuscatedName("Anchor/<Start>d__20")]
	public sealed class _Start_d__20 : Il2CppSystem.Object
	{
		// Token: 0x06000999 RID: 2457 RVA: 0x00028098 File Offset: 0x00026298
		[CallerCount(0)]
		public unsafe _Start_d__20(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Anchor._Start_d__20>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor._Start_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x000280F8 File Offset: 0x000262F8
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor._Start_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0002813C File Offset: 0x0002633C
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Anchor._Start_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0002818C File Offset: 0x0002638C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor._Start_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000281E4 File Offset: 0x000263E4
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor._Start_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00028228 File Offset: 0x00026428
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Anchor._Start_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00028280 File Offset: 0x00026480
		// Note: this type is marked as 'beforefieldinit'.
		static _Start_d__20()
		{
			Il2CppClassPointerStore<Anchor._Start_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Anchor>.NativeClassPtr, "<Start>d__20");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Anchor._Start_d__20>.NativeClassPtr);
			Anchor._Start_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor._Start_d__20>.NativeClassPtr, "<>1__state");
			Anchor._Start_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor._Start_d__20>.NativeClassPtr, "<>2__current");
			Anchor._Start_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Anchor._Start_d__20>.NativeClassPtr, "<>4__this");
			Anchor._Start_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor._Start_d__20>.NativeClassPtr, 100664064);
			Anchor._Start_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor._Start_d__20>.NativeClassPtr, 100664065);
			Anchor._Start_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor._Start_d__20>.NativeClassPtr, 100664066);
			Anchor._Start_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor._Start_d__20>.NativeClassPtr, 100664067);
			Anchor._Start_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor._Start_d__20>.NativeClassPtr, 100664068);
			Anchor._Start_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Anchor._Start_d__20>.NativeClassPtr, 100664069);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00002988 File Offset: 0x00000B88
		public _Start_d__20(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x0002835F File Offset: 0x0002655F
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Anchor._Start_d__20>.NativeClassPtr));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00028370 File Offset: 0x00026570
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x00028398 File Offset: 0x00026598
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor._Start_d__20.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor._Start_d__20.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x000283BC File Offset: 0x000265BC
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x000283F0 File Offset: 0x000265F0
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor._Start_d__20.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor._Start_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00028418 File Offset: 0x00026618
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x0002844C File Offset: 0x0002664C
		public unsafe Anchor __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor._Start_d__20.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Anchor(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Anchor._Start_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
