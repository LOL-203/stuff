using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200009B RID: 155
public class AnchorUIManager : MonoBehaviour
{
	// Token: 0x17000367 RID: 871
	// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00028474 File Offset: 0x00026674
	public unsafe Anchor AnchorPrefab
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_get_AnchorPrefab_Public_get_Anchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Anchor(intPtr2) : null;
		}
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x000284CC File Offset: 0x000266CC
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00028510 File Offset: 0x00026710
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00028554 File Offset: 0x00026754
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00028598 File Offset: 0x00026798
	[CallerCount(0)]
	public unsafe void OnCreateModeButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_OnCreateModeButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x000285DC File Offset: 0x000267DC
	[CallerCount(0)]
	public unsafe void OnLoadAnchorsButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_OnLoadAnchorsButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00028620 File Offset: 0x00026820
	[CallerCount(0)]
	public unsafe void ToggleCreateMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_ToggleCreateMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00028664 File Offset: 0x00026864
	[CallerCount(0)]
	public unsafe void StartPlacementMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_StartPlacementMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x000286A8 File Offset: 0x000268A8
	[CallerCount(0)]
	public unsafe void EndPlacementMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_EndPlacementMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x000286EC File Offset: 0x000268EC
	[CallerCount(0)]
	public unsafe void StartSelectMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_StartSelectMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x00028730 File Offset: 0x00026930
	[CallerCount(0)]
	public unsafe void EndSelectMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_EndSelectMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00028774 File Offset: 0x00026974
	[CallerCount(0)]
	public unsafe void HandleMenuNavigation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_HandleMenuNavigation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x000287B8 File Offset: 0x000269B8
	[CallerCount(0)]
	public unsafe void NavigateToIndexInMenu(bool moveNext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref moveNext;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_NavigateToIndexInMenu_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x0002880C File Offset: 0x00026A0C
	[CallerCount(0)]
	public unsafe void ShowAnchorPreview()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_ShowAnchorPreview_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x00028850 File Offset: 0x00026A50
	[CallerCount(0)]
	public unsafe void HideAnchorPreview()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_HideAnchorPreview_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00028894 File Offset: 0x00026A94
	[CallerCount(0)]
	public unsafe void PlaceAnchor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_PlaceAnchor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x000288D8 File Offset: 0x00026AD8
	[CallerCount(0)]
	public unsafe void ShowRaycastLine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_ShowRaycastLine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x0002891C File Offset: 0x00026B1C
	[CallerCount(0)]
	public unsafe void HideRaycastLine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_HideRaycastLine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x00028960 File Offset: 0x00026B60
	[CallerCount(0)]
	public unsafe void ControllerRaycast()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_ControllerRaycast_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x000289A4 File Offset: 0x00026BA4
	[CallerCount(0)]
	public unsafe void HoverAnchor(Anchor anchor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(anchor);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_HoverAnchor_Private_Void_Anchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00028A00 File Offset: 0x00026C00
	[CallerCount(0)]
	public unsafe void UnhoverAnchor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_UnhoverAnchor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00028A44 File Offset: 0x00026C44
	[CallerCount(0)]
	public unsafe void SelectAnchor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr_SelectAnchor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00028A88 File Offset: 0x00026C88
	[CallerCount(0)]
	public unsafe AnchorUIManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00028AD4 File Offset: 0x00026CD4
	// Note: this type is marked as 'beforefieldinit'.
	static AnchorUIManager()
	{
		Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnchorUIManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr);
		AnchorUIManager.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "Instance");
		AnchorUIManager.NativeFieldInfoPtr__createModeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_createModeButton");
		AnchorUIManager.NativeFieldInfoPtr__selectModeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_selectModeButton");
		AnchorUIManager.NativeFieldInfoPtr__trackedDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_trackedDevice");
		AnchorUIManager.NativeFieldInfoPtr__raycastOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_raycastOrigin");
		AnchorUIManager.NativeFieldInfoPtr__drawRaycast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_drawRaycast");
		AnchorUIManager.NativeFieldInfoPtr__lineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_lineRenderer");
		AnchorUIManager.NativeFieldInfoPtr__hoveredAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_hoveredAnchor");
		AnchorUIManager.NativeFieldInfoPtr__selectedAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_selectedAnchor");
		AnchorUIManager.NativeFieldInfoPtr__mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_mode");
		AnchorUIManager.NativeFieldInfoPtr__buttonList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_buttonList");
		AnchorUIManager.NativeFieldInfoPtr__menuIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_menuIndex");
		AnchorUIManager.NativeFieldInfoPtr__selectedButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_selectedButton");
		AnchorUIManager.NativeFieldInfoPtr__anchorPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_anchorPrefab");
		AnchorUIManager.NativeFieldInfoPtr__placementPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_placementPreview");
		AnchorUIManager.NativeFieldInfoPtr__anchorPlacementTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_anchorPlacementTransform");
		AnchorUIManager.NativeFieldInfoPtr__primaryPressDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_primaryPressDelegate");
		AnchorUIManager.NativeFieldInfoPtr__isFocused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "_isFocused");
		AnchorUIManager.NativeMethodInfoPtr_get_AnchorPrefab_Public_get_Anchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664070);
		AnchorUIManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664071);
		AnchorUIManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664072);
		AnchorUIManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664073);
		AnchorUIManager.NativeMethodInfoPtr_OnCreateModeButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664074);
		AnchorUIManager.NativeMethodInfoPtr_OnLoadAnchorsButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664075);
		AnchorUIManager.NativeMethodInfoPtr_ToggleCreateMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664076);
		AnchorUIManager.NativeMethodInfoPtr_StartPlacementMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664077);
		AnchorUIManager.NativeMethodInfoPtr_EndPlacementMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664078);
		AnchorUIManager.NativeMethodInfoPtr_StartSelectMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664079);
		AnchorUIManager.NativeMethodInfoPtr_EndSelectMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664080);
		AnchorUIManager.NativeMethodInfoPtr_HandleMenuNavigation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664081);
		AnchorUIManager.NativeMethodInfoPtr_NavigateToIndexInMenu_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664082);
		AnchorUIManager.NativeMethodInfoPtr_ShowAnchorPreview_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664083);
		AnchorUIManager.NativeMethodInfoPtr_HideAnchorPreview_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664084);
		AnchorUIManager.NativeMethodInfoPtr_PlaceAnchor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664085);
		AnchorUIManager.NativeMethodInfoPtr_ShowRaycastLine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664086);
		AnchorUIManager.NativeMethodInfoPtr_HideRaycastLine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664087);
		AnchorUIManager.NativeMethodInfoPtr_ControllerRaycast_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664088);
		AnchorUIManager.NativeMethodInfoPtr_HoverAnchor_Private_Void_Anchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664089);
		AnchorUIManager.NativeMethodInfoPtr_UnhoverAnchor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664090);
		AnchorUIManager.NativeMethodInfoPtr_SelectAnchor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664091);
		AnchorUIManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, 100664092);
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x0000210C File Offset: 0x0000030C
	public AnchorUIManager(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000354 RID: 852
	// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00028E38 File Offset: 0x00027038
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr));
		}
	}

	// Token: 0x17000355 RID: 853
	// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00028E4C File Offset: 0x0002704C
	// (set) Token: 0x060009C3 RID: 2499 RVA: 0x00028E77 File Offset: 0x00027077
	public unsafe static AnchorUIManager Instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AnchorUIManager.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new AnchorUIManager(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AnchorUIManager.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000356 RID: 854
	// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00028E8C File Offset: 0x0002708C
	// (set) Token: 0x060009C5 RID: 2501 RVA: 0x00028EC0 File Offset: 0x000270C0
	public unsafe GameObject _createModeButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__createModeButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__createModeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000357 RID: 855
	// (get) Token: 0x060009C6 RID: 2502 RVA: 0x00028EE8 File Offset: 0x000270E8
	// (set) Token: 0x060009C7 RID: 2503 RVA: 0x00028F1C File Offset: 0x0002711C
	public unsafe GameObject _selectModeButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__selectModeButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__selectModeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000358 RID: 856
	// (get) Token: 0x060009C8 RID: 2504 RVA: 0x00028F44 File Offset: 0x00027144
	// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00028F78 File Offset: 0x00027178
	public unsafe Transform _trackedDevice
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__trackedDevice);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__trackedDevice), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000359 RID: 857
	// (get) Token: 0x060009CA RID: 2506 RVA: 0x00028FA0 File Offset: 0x000271A0
	// (set) Token: 0x060009CB RID: 2507 RVA: 0x00028FD4 File Offset: 0x000271D4
	public unsafe Transform _raycastOrigin
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__raycastOrigin);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__raycastOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700035A RID: 858
	// (get) Token: 0x060009CC RID: 2508 RVA: 0x00028FFC File Offset: 0x000271FC
	// (set) Token: 0x060009CD RID: 2509 RVA: 0x00029024 File Offset: 0x00027224
	public unsafe bool _drawRaycast
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__drawRaycast);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__drawRaycast)) = value;
		}
	}

	// Token: 0x1700035B RID: 859
	// (get) Token: 0x060009CE RID: 2510 RVA: 0x00029048 File Offset: 0x00027248
	// (set) Token: 0x060009CF RID: 2511 RVA: 0x0002907C File Offset: 0x0002727C
	public unsafe LineRenderer _lineRenderer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__lineRenderer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new LineRenderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__lineRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700035C RID: 860
	// (get) Token: 0x060009D0 RID: 2512 RVA: 0x000290A4 File Offset: 0x000272A4
	// (set) Token: 0x060009D1 RID: 2513 RVA: 0x000290D8 File Offset: 0x000272D8
	public unsafe Anchor _hoveredAnchor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__hoveredAnchor);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Anchor(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__hoveredAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700035D RID: 861
	// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00029100 File Offset: 0x00027300
	// (set) Token: 0x060009D3 RID: 2515 RVA: 0x00029134 File Offset: 0x00027334
	public unsafe Anchor _selectedAnchor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__selectedAnchor);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Anchor(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__selectedAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700035E RID: 862
	// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0002915C File Offset: 0x0002735C
	// (set) Token: 0x060009D5 RID: 2517 RVA: 0x00029184 File Offset: 0x00027384
	public unsafe AnchorUIManager.AnchorMode _mode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__mode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__mode)) = value;
		}
	}

	// Token: 0x1700035F RID: 863
	// (get) Token: 0x060009D6 RID: 2518 RVA: 0x000291A8 File Offset: 0x000273A8
	// (set) Token: 0x060009D7 RID: 2519 RVA: 0x000291DC File Offset: 0x000273DC
	public unsafe List<Button> _buttonList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__buttonList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__buttonList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000360 RID: 864
	// (get) Token: 0x060009D8 RID: 2520 RVA: 0x00029204 File Offset: 0x00027404
	// (set) Token: 0x060009D9 RID: 2521 RVA: 0x0002922C File Offset: 0x0002742C
	public unsafe int _menuIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__menuIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__menuIndex)) = value;
		}
	}

	// Token: 0x17000361 RID: 865
	// (get) Token: 0x060009DA RID: 2522 RVA: 0x00029250 File Offset: 0x00027450
	// (set) Token: 0x060009DB RID: 2523 RVA: 0x00029284 File Offset: 0x00027484
	public unsafe Button _selectedButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__selectedButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Button(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__selectedButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000362 RID: 866
	// (get) Token: 0x060009DC RID: 2524 RVA: 0x000292AC File Offset: 0x000274AC
	// (set) Token: 0x060009DD RID: 2525 RVA: 0x000292E0 File Offset: 0x000274E0
	public unsafe Anchor _anchorPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__anchorPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Anchor(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__anchorPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000363 RID: 867
	// (get) Token: 0x060009DE RID: 2526 RVA: 0x00029308 File Offset: 0x00027508
	// (set) Token: 0x060009DF RID: 2527 RVA: 0x0002933C File Offset: 0x0002753C
	public unsafe GameObject _placementPreview
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__placementPreview);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__placementPreview), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000364 RID: 868
	// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00029364 File Offset: 0x00027564
	// (set) Token: 0x060009E1 RID: 2529 RVA: 0x00029398 File Offset: 0x00027598
	public unsafe Transform _anchorPlacementTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__anchorPlacementTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__anchorPlacementTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000365 RID: 869
	// (get) Token: 0x060009E2 RID: 2530 RVA: 0x000293C0 File Offset: 0x000275C0
	// (set) Token: 0x060009E3 RID: 2531 RVA: 0x000293F4 File Offset: 0x000275F4
	public unsafe AnchorUIManager.PrimaryPressDelegate _primaryPressDelegate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__primaryPressDelegate);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AnchorUIManager.PrimaryPressDelegate(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__primaryPressDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000366 RID: 870
	// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0002941C File Offset: 0x0002761C
	// (set) Token: 0x060009E5 RID: 2533 RVA: 0x00029444 File Offset: 0x00027644
	public unsafe bool _isFocused
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__isFocused);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnchorUIManager.NativeFieldInfoPtr__isFocused)) = value;
		}
	}

	// Token: 0x040005E6 RID: 1510
	private static readonly IntPtr NativeFieldInfoPtr_Instance;

	// Token: 0x040005E7 RID: 1511
	private static readonly IntPtr NativeFieldInfoPtr__createModeButton;

	// Token: 0x040005E8 RID: 1512
	private static readonly IntPtr NativeFieldInfoPtr__selectModeButton;

	// Token: 0x040005E9 RID: 1513
	private static readonly IntPtr NativeFieldInfoPtr__trackedDevice;

	// Token: 0x040005EA RID: 1514
	private static readonly IntPtr NativeFieldInfoPtr__raycastOrigin;

	// Token: 0x040005EB RID: 1515
	private static readonly IntPtr NativeFieldInfoPtr__drawRaycast;

	// Token: 0x040005EC RID: 1516
	private static readonly IntPtr NativeFieldInfoPtr__lineRenderer;

	// Token: 0x040005ED RID: 1517
	private static readonly IntPtr NativeFieldInfoPtr__hoveredAnchor;

	// Token: 0x040005EE RID: 1518
	private static readonly IntPtr NativeFieldInfoPtr__selectedAnchor;

	// Token: 0x040005EF RID: 1519
	private static readonly IntPtr NativeFieldInfoPtr__mode;

	// Token: 0x040005F0 RID: 1520
	private static readonly IntPtr NativeFieldInfoPtr__buttonList;

	// Token: 0x040005F1 RID: 1521
	private static readonly IntPtr NativeFieldInfoPtr__menuIndex;

	// Token: 0x040005F2 RID: 1522
	private static readonly IntPtr NativeFieldInfoPtr__selectedButton;

	// Token: 0x040005F3 RID: 1523
	private static readonly IntPtr NativeFieldInfoPtr__anchorPrefab;

	// Token: 0x040005F4 RID: 1524
	private static readonly IntPtr NativeFieldInfoPtr__placementPreview;

	// Token: 0x040005F5 RID: 1525
	private static readonly IntPtr NativeFieldInfoPtr__anchorPlacementTransform;

	// Token: 0x040005F6 RID: 1526
	private static readonly IntPtr NativeFieldInfoPtr__primaryPressDelegate;

	// Token: 0x040005F7 RID: 1527
	private static readonly IntPtr NativeFieldInfoPtr__isFocused;

	// Token: 0x040005F8 RID: 1528
	private static readonly IntPtr NativeMethodInfoPtr_get_AnchorPrefab_Public_get_Anchor_0;

	// Token: 0x040005F9 RID: 1529
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040005FA RID: 1530
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040005FB RID: 1531
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040005FC RID: 1532
	private static readonly IntPtr NativeMethodInfoPtr_OnCreateModeButtonPressed_Public_Void_0;

	// Token: 0x040005FD RID: 1533
	private static readonly IntPtr NativeMethodInfoPtr_OnLoadAnchorsButtonPressed_Public_Void_0;

	// Token: 0x040005FE RID: 1534
	private static readonly IntPtr NativeMethodInfoPtr_ToggleCreateMode_Private_Void_0;

	// Token: 0x040005FF RID: 1535
	private static readonly IntPtr NativeMethodInfoPtr_StartPlacementMode_Private_Void_0;

	// Token: 0x04000600 RID: 1536
	private static readonly IntPtr NativeMethodInfoPtr_EndPlacementMode_Private_Void_0;

	// Token: 0x04000601 RID: 1537
	private static readonly IntPtr NativeMethodInfoPtr_StartSelectMode_Private_Void_0;

	// Token: 0x04000602 RID: 1538
	private static readonly IntPtr NativeMethodInfoPtr_EndSelectMode_Private_Void_0;

	// Token: 0x04000603 RID: 1539
	private static readonly IntPtr NativeMethodInfoPtr_HandleMenuNavigation_Private_Void_0;

	// Token: 0x04000604 RID: 1540
	private static readonly IntPtr NativeMethodInfoPtr_NavigateToIndexInMenu_Private_Void_Boolean_0;

	// Token: 0x04000605 RID: 1541
	private static readonly IntPtr NativeMethodInfoPtr_ShowAnchorPreview_Private_Void_0;

	// Token: 0x04000606 RID: 1542
	private static readonly IntPtr NativeMethodInfoPtr_HideAnchorPreview_Private_Void_0;

	// Token: 0x04000607 RID: 1543
	private static readonly IntPtr NativeMethodInfoPtr_PlaceAnchor_Private_Void_0;

	// Token: 0x04000608 RID: 1544
	private static readonly IntPtr NativeMethodInfoPtr_ShowRaycastLine_Private_Void_0;

	// Token: 0x04000609 RID: 1545
	private static readonly IntPtr NativeMethodInfoPtr_HideRaycastLine_Private_Void_0;

	// Token: 0x0400060A RID: 1546
	private static readonly IntPtr NativeMethodInfoPtr_ControllerRaycast_Private_Void_0;

	// Token: 0x0400060B RID: 1547
	private static readonly IntPtr NativeMethodInfoPtr_HoverAnchor_Private_Void_Anchor_0;

	// Token: 0x0400060C RID: 1548
	private static readonly IntPtr NativeMethodInfoPtr_UnhoverAnchor_Private_Void_0;

	// Token: 0x0400060D RID: 1549
	private static readonly IntPtr NativeMethodInfoPtr_SelectAnchor_Private_Void_0;

	// Token: 0x0400060E RID: 1550
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200009C RID: 156
	public enum AnchorMode
	{
		// Token: 0x04000610 RID: 1552
		Create,
		// Token: 0x04000611 RID: 1553
		Select
	}

	// Token: 0x0200009D RID: 157
	public sealed class PrimaryPressDelegate : MulticastDelegate
	{
		// Token: 0x060009E8 RID: 2536 RVA: 0x0002948C File Offset: 0x0002768C
		[CallerCount(0)]
		public unsafe PrimaryPressDelegate(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnchorUIManager.PrimaryPressDelegate>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.PrimaryPressDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00029504 File Offset: 0x00027704
		[CallerCount(0)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.PrimaryPressDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00029548 File Offset: 0x00027748
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.PrimaryPressDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x000295D0 File Offset: 0x000277D0
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnchorUIManager.PrimaryPressDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0002962C File Offset: 0x0002782C
		// Note: this type is marked as 'beforefieldinit'.
		static PrimaryPressDelegate()
		{
			Il2CppClassPointerStore<AnchorUIManager.PrimaryPressDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnchorUIManager>.NativeClassPtr, "PrimaryPressDelegate");
			AnchorUIManager.PrimaryPressDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager.PrimaryPressDelegate>.NativeClassPtr, 100664093);
			AnchorUIManager.PrimaryPressDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager.PrimaryPressDelegate>.NativeClassPtr, 100664094);
			AnchorUIManager.PrimaryPressDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager.PrimaryPressDelegate>.NativeClassPtr, 100664095);
			AnchorUIManager.PrimaryPressDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnchorUIManager.PrimaryPressDelegate>.NativeClassPtr, 100664096);
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00005E35 File Offset: 0x00004035
		public PrimaryPressDelegate(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0002969D File Offset: 0x0002789D
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AnchorUIManager.PrimaryPressDelegate>.NativeClassPtr));
			}
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000296AE File Offset: 0x000278AE
		public static implicit operator AnchorUIManager.PrimaryPressDelegate(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<AnchorUIManager.PrimaryPressDelegate>(A_0);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x000296B6 File Offset: 0x000278B6
		public static AnchorUIManager.PrimaryPressDelegate operator +(AnchorUIManager.PrimaryPressDelegate A_0, AnchorUIManager.PrimaryPressDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AnchorUIManager.PrimaryPressDelegate>();
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000296C4 File Offset: 0x000278C4
		public static AnchorUIManager.PrimaryPressDelegate operator -(AnchorUIManager.PrimaryPressDelegate A_0, AnchorUIManager.PrimaryPressDelegate A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<AnchorUIManager.PrimaryPressDelegate>();
			}
			return result;
		}

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
