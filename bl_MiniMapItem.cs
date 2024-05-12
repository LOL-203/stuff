using System;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000451 RID: 1105
public class bl_MiniMapItem : MonoBehaviour
{
	// Token: 0x17001F9E RID: 8094
	// (get) Token: 0x06005875 RID: 22645 RVA: 0x001623B8 File Offset: 0x001605B8
	public unsafe Vector3 BaseScale
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_get_BaseScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x06005876 RID: 22646 RVA: 0x00162408 File Offset: 0x00160608
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005877 RID: 22647 RVA: 0x0016244C File Offset: 0x0016064C
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005878 RID: 22648 RVA: 0x00162490 File Offset: 0x00160690
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005879 RID: 22649 RVA: 0x001624D4 File Offset: 0x001606D4
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600587A RID: 22650 RVA: 0x00162518 File Offset: 0x00160718
	[CallerCount(0)]
	public unsafe void OnRefresh(MonoBehaviour host)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_OnRefresh_Protected_Void_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600587B RID: 22651 RVA: 0x00162574 File Offset: 0x00160774
	[CallerCount(0)]
	public unsafe IEnumerator WaitToCreateIcon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_WaitToCreateIcon_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x0600587C RID: 22652 RVA: 0x001625CC File Offset: 0x001607CC
	[CallerCount(0)]
	public unsafe IEnumerator ReCreateIcon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_ReCreateIcon_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x0600587D RID: 22653 RVA: 0x00162624 File Offset: 0x00160824
	[CallerCount(0)]
	public unsafe void CreateIcon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_CreateIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600587E RID: 22654 RVA: 0x00162668 File Offset: 0x00160868
	[CallerCount(0)]
	public unsafe void SetScale(float scaleFactor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref scaleFactor;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_SetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600587F RID: 22655 RVA: 0x001626BC File Offset: 0x001608BC
	[CallerCount(0)]
	public unsafe void RefreshFaction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_RefreshFaction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005880 RID: 22656 RVA: 0x00162700 File Offset: 0x00160900
	[CallerCount(0)]
	public unsafe void DestroyIconItem(bool immediate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref immediate;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_DestroyIconItem_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x17001F9F RID: 8095
	// (get) Token: 0x06005881 RID: 22657 RVA: 0x00162754 File Offset: 0x00160954
	// (set) Token: 0x06005882 RID: 22658 RVA: 0x001627A4 File Offset: 0x001609A4
	public unsafe bool ManagedUpdateRemoval
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x06005883 RID: 22659 RVA: 0x001627F8 File Offset: 0x001609F8
	[CallerCount(0)]
	public unsafe void OnManagedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005884 RID: 22660 RVA: 0x0016283C File Offset: 0x00160A3C
	[CallerCount(0)]
	public unsafe void StartEffect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_StartEffect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005885 RID: 22661 RVA: 0x00162880 File Offset: 0x00160A80
	[CallerCount(0)]
	public unsafe void DestroyItem(bool immediate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref immediate;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_DestroyItem_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005886 RID: 22662 RVA: 0x001628D4 File Offset: 0x00160AD4
	[CallerCount(0)]
	public unsafe IEnumerator QueueDestroy(float waitTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref waitTime;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_QueueDestroy_Public_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x06005887 RID: 22663 RVA: 0x0016293C File Offset: 0x00160B3C
	[CallerCount(0)]
	public unsafe void HideItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_HideItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005888 RID: 22664 RVA: 0x00162980 File Offset: 0x00160B80
	[CallerCount(0)]
	public unsafe void ShowItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_ShowItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x17001FA0 RID: 8096
	// (get) Token: 0x06005889 RID: 22665 RVA: 0x001629C4 File Offset: 0x00160BC4
	public unsafe Vector3 TargetPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x0600588A RID: 22666 RVA: 0x00162A14 File Offset: 0x00160C14
	[CallerCount(0)]
	public unsafe bl_MiniMapItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600588B RID: 22667 RVA: 0x00162A60 File Offset: 0x00160C60
	// Note: this type is marked as 'beforefieldinit'.
	static bl_MiniMapItem()
	{
		Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "bl_MiniMapItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr);
		bl_MiniMapItem.NativeFieldInfoPtr_OnRefreshIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "OnRefreshIcons");
		bl_MiniMapItem.NativeFieldInfoPtr_OnScaleIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "OnScaleIcons");
		bl_MiniMapItem.NativeFieldInfoPtr_GraphicPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "GraphicPrefab");
		bl_MiniMapItem.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "Target");
		bl_MiniMapItem.NativeFieldInfoPtr_OffSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "OffSet");
		bl_MiniMapItem.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "Icon");
		bl_MiniMapItem.NativeFieldInfoPtr_DeathIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "DeathIcon");
		bl_MiniMapItem.NativeFieldInfoPtr_IconColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "IconColor");
		bl_MiniMapItem.NativeFieldInfoPtr_isPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "isPlayer");
		bl_MiniMapItem.NativeFieldInfoPtr_PlayerScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "PlayerScript");
		bl_MiniMapItem.NativeFieldInfoPtr_PlayerDamageController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "PlayerDamageController");
		bl_MiniMapItem.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "Size");
		bl_MiniMapItem.NativeFieldInfoPtr_isInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "isInteractable");
		bl_MiniMapItem.NativeFieldInfoPtr_InfoItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "InfoItem");
		bl_MiniMapItem.NativeFieldInfoPtr_DoShowOffScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "DoShowOffScreen");
		bl_MiniMapItem.NativeFieldInfoPtr_DelayCreation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "DelayCreation");
		bl_MiniMapItem.NativeFieldInfoPtr_BorderOffScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "BorderOffScreen");
		bl_MiniMapItem.NativeFieldInfoPtr_MinDistanceScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "MinDistanceScale");
		bl_MiniMapItem.NativeFieldInfoPtr_OffscreenScalingDistanceInScreens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "OffscreenScalingDistanceInScreens");
		bl_MiniMapItem.NativeFieldInfoPtr_OffScreenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "OffScreenSize");
		bl_MiniMapItem.NativeFieldInfoPtr_StopAutoCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "StopAutoCreate");
		bl_MiniMapItem.NativeFieldInfoPtr_m_Effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "m_Effect");
		bl_MiniMapItem.NativeFieldInfoPtr_Graphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "Graphic");
		bl_MiniMapItem.NativeFieldInfoPtr_normalSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "normalSprite");
		bl_MiniMapItem.NativeFieldInfoPtr_aboveSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "aboveSprite");
		bl_MiniMapItem.NativeFieldInfoPtr_belowSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "belowSprite");
		bl_MiniMapItem.NativeFieldInfoPtr_RectRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "RectRoot");
		bl_MiniMapItem.NativeFieldInfoPtr_cacheItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "cacheItem");
		bl_MiniMapItem.NativeFieldInfoPtr_isRefreshing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "isRefreshing");
		bl_MiniMapItem.NativeFieldInfoPtr_m_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "m_Faction");
		bl_MiniMapItem.NativeFieldInfoPtr_overrideFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "overrideFaction");
		bl_MiniMapItem.NativeFieldInfoPtr_hasCreatedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "hasCreatedIcon");
		bl_MiniMapItem.NativeFieldInfoPtr__distanceScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "_distanceScale");
		bl_MiniMapItem.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "<ManagedUpdateRemoval>k__BackingField");
		bl_MiniMapItem.NativeMethodInfoPtr_get_BaseScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670272);
		bl_MiniMapItem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670273);
		bl_MiniMapItem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670274);
		bl_MiniMapItem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670275);
		bl_MiniMapItem.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670276);
		bl_MiniMapItem.NativeMethodInfoPtr_OnRefresh_Protected_Void_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670277);
		bl_MiniMapItem.NativeMethodInfoPtr_WaitToCreateIcon_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670278);
		bl_MiniMapItem.NativeMethodInfoPtr_ReCreateIcon_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670279);
		bl_MiniMapItem.NativeMethodInfoPtr_CreateIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670280);
		bl_MiniMapItem.NativeMethodInfoPtr_SetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670281);
		bl_MiniMapItem.NativeMethodInfoPtr_RefreshFaction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670282);
		bl_MiniMapItem.NativeMethodInfoPtr_DestroyIconItem_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670283);
		bl_MiniMapItem.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670284);
		bl_MiniMapItem.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670285);
		bl_MiniMapItem.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670286);
		bl_MiniMapItem.NativeMethodInfoPtr_StartEffect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670287);
		bl_MiniMapItem.NativeMethodInfoPtr_DestroyItem_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670288);
		bl_MiniMapItem.NativeMethodInfoPtr_QueueDestroy_Public_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670289);
		bl_MiniMapItem.NativeMethodInfoPtr_HideItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670290);
		bl_MiniMapItem.NativeMethodInfoPtr_ShowItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670291);
		bl_MiniMapItem.NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670292);
		bl_MiniMapItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, 100670293);
	}

	// Token: 0x0600588C RID: 22668 RVA: 0x0000210C File Offset: 0x0000030C
	public bl_MiniMapItem(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001F7B RID: 8059
	// (get) Token: 0x0600588D RID: 22669 RVA: 0x00162EF0 File Offset: 0x001610F0
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr));
		}
	}

	// Token: 0x17001F7C RID: 8060
	// (get) Token: 0x0600588E RID: 22670 RVA: 0x00162F04 File Offset: 0x00161104
	// (set) Token: 0x0600588F RID: 22671 RVA: 0x00162F2F File Offset: 0x0016112F
	public unsafe static Action<MonoBehaviour> OnRefreshIcons
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(bl_MiniMapItem.NativeFieldInfoPtr_OnRefreshIcons, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Action<MonoBehaviour>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(bl_MiniMapItem.NativeFieldInfoPtr_OnRefreshIcons, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F7D RID: 8061
	// (get) Token: 0x06005890 RID: 22672 RVA: 0x00162F44 File Offset: 0x00161144
	// (set) Token: 0x06005891 RID: 22673 RVA: 0x00162F6F File Offset: 0x0016116F
	public unsafe static Action<float> OnScaleIcons
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(bl_MiniMapItem.NativeFieldInfoPtr_OnScaleIcons, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Action<float>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(bl_MiniMapItem.NativeFieldInfoPtr_OnScaleIcons, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F7E RID: 8062
	// (get) Token: 0x06005892 RID: 22674 RVA: 0x00162F84 File Offset: 0x00161184
	// (set) Token: 0x06005893 RID: 22675 RVA: 0x00162FB8 File Offset: 0x001611B8
	public unsafe bl_MiniMapItemGraphic GraphicPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_GraphicPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new bl_MiniMapItemGraphic(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_GraphicPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F7F RID: 8063
	// (get) Token: 0x06005894 RID: 22676 RVA: 0x00162FE0 File Offset: 0x001611E0
	// (set) Token: 0x06005895 RID: 22677 RVA: 0x00163014 File Offset: 0x00161214
	public unsafe Transform Target
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_Target);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F80 RID: 8064
	// (get) Token: 0x06005896 RID: 22678 RVA: 0x0016303C File Offset: 0x0016123C
	// (set) Token: 0x06005897 RID: 22679 RVA: 0x00163064 File Offset: 0x00161264
	public unsafe Vector3 OffSet
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_OffSet);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_OffSet)) = value;
		}
	}

	// Token: 0x17001F81 RID: 8065
	// (get) Token: 0x06005898 RID: 22680 RVA: 0x00163088 File Offset: 0x00161288
	// (set) Token: 0x06005899 RID: 22681 RVA: 0x001630BC File Offset: 0x001612BC
	public unsafe Sprite Icon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_Icon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Sprite(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F82 RID: 8066
	// (get) Token: 0x0600589A RID: 22682 RVA: 0x001630E4 File Offset: 0x001612E4
	// (set) Token: 0x0600589B RID: 22683 RVA: 0x00163118 File Offset: 0x00161318
	public unsafe Sprite DeathIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_DeathIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Sprite(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_DeathIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F83 RID: 8067
	// (get) Token: 0x0600589C RID: 22684 RVA: 0x00163140 File Offset: 0x00161340
	// (set) Token: 0x0600589D RID: 22685 RVA: 0x00163168 File Offset: 0x00161368
	public unsafe Color IconColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_IconColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_IconColor)) = value;
		}
	}

	// Token: 0x17001F84 RID: 8068
	// (get) Token: 0x0600589E RID: 22686 RVA: 0x0016318C File Offset: 0x0016138C
	// (set) Token: 0x0600589F RID: 22687 RVA: 0x001631B4 File Offset: 0x001613B4
	public unsafe bool isPlayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_isPlayer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_isPlayer)) = value;
		}
	}

	// Token: 0x17001F85 RID: 8069
	// (get) Token: 0x060058A0 RID: 22688 RVA: 0x001631D8 File Offset: 0x001613D8
	// (set) Token: 0x060058A1 RID: 22689 RVA: 0x0016320C File Offset: 0x0016140C
	public unsafe WarPlayerScript PlayerScript
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_PlayerScript);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WarPlayerScript(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_PlayerScript), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F86 RID: 8070
	// (get) Token: 0x060058A2 RID: 22690 RVA: 0x00163234 File Offset: 0x00161434
	// (set) Token: 0x060058A3 RID: 22691 RVA: 0x00163268 File Offset: 0x00161468
	public unsafe DamageController PlayerDamageController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_PlayerDamageController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new DamageController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_PlayerDamageController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F87 RID: 8071
	// (get) Token: 0x060058A4 RID: 22692 RVA: 0x00163290 File Offset: 0x00161490
	// (set) Token: 0x060058A5 RID: 22693 RVA: 0x001632B8 File Offset: 0x001614B8
	public unsafe float Size
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_Size);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_Size)) = value;
		}
	}

	// Token: 0x17001F88 RID: 8072
	// (get) Token: 0x060058A6 RID: 22694 RVA: 0x001632DC File Offset: 0x001614DC
	// (set) Token: 0x060058A7 RID: 22695 RVA: 0x00163304 File Offset: 0x00161504
	public unsafe bool isInteractable
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_isInteractable);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_isInteractable)) = value;
		}
	}

	// Token: 0x17001F89 RID: 8073
	// (get) Token: 0x060058A8 RID: 22696 RVA: 0x00163328 File Offset: 0x00161528
	// (set) Token: 0x060058A9 RID: 22697 RVA: 0x00163351 File Offset: 0x00161551
	public unsafe string InfoItem
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_InfoItem);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_InfoItem), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001F8A RID: 8074
	// (get) Token: 0x060058AA RID: 22698 RVA: 0x00163378 File Offset: 0x00161578
	// (set) Token: 0x060058AB RID: 22699 RVA: 0x001633A0 File Offset: 0x001615A0
	public unsafe bool DoShowOffScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_DoShowOffScreen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_DoShowOffScreen)) = value;
		}
	}

	// Token: 0x17001F8B RID: 8075
	// (get) Token: 0x060058AC RID: 22700 RVA: 0x001633C4 File Offset: 0x001615C4
	// (set) Token: 0x060058AD RID: 22701 RVA: 0x001633EC File Offset: 0x001615EC
	public unsafe bool DelayCreation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_DelayCreation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_DelayCreation)) = value;
		}
	}

	// Token: 0x17001F8C RID: 8076
	// (get) Token: 0x060058AE RID: 22702 RVA: 0x00163410 File Offset: 0x00161610
	// (set) Token: 0x060058AF RID: 22703 RVA: 0x00163438 File Offset: 0x00161638
	public unsafe float BorderOffScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_BorderOffScreen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_BorderOffScreen)) = value;
		}
	}

	// Token: 0x17001F8D RID: 8077
	// (get) Token: 0x060058B0 RID: 22704 RVA: 0x0016345C File Offset: 0x0016165C
	// (set) Token: 0x060058B1 RID: 22705 RVA: 0x00163484 File Offset: 0x00161684
	public unsafe float MinDistanceScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_MinDistanceScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_MinDistanceScale)) = value;
		}
	}

	// Token: 0x17001F8E RID: 8078
	// (get) Token: 0x060058B2 RID: 22706 RVA: 0x001634A8 File Offset: 0x001616A8
	// (set) Token: 0x060058B3 RID: 22707 RVA: 0x001634D0 File Offset: 0x001616D0
	public unsafe float OffscreenScalingDistanceInScreens
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_OffscreenScalingDistanceInScreens);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_OffscreenScalingDistanceInScreens)) = value;
		}
	}

	// Token: 0x17001F8F RID: 8079
	// (get) Token: 0x060058B4 RID: 22708 RVA: 0x001634F4 File Offset: 0x001616F4
	// (set) Token: 0x060058B5 RID: 22709 RVA: 0x0016351C File Offset: 0x0016171C
	public unsafe float OffScreenSize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_OffScreenSize);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_OffScreenSize)) = value;
		}
	}

	// Token: 0x17001F90 RID: 8080
	// (get) Token: 0x060058B6 RID: 22710 RVA: 0x00163540 File Offset: 0x00161740
	// (set) Token: 0x060058B7 RID: 22711 RVA: 0x00163568 File Offset: 0x00161768
	public unsafe bool StopAutoCreate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_StopAutoCreate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_StopAutoCreate)) = value;
		}
	}

	// Token: 0x17001F91 RID: 8081
	// (get) Token: 0x060058B8 RID: 22712 RVA: 0x0016358C File Offset: 0x0016178C
	// (set) Token: 0x060058B9 RID: 22713 RVA: 0x001635B4 File Offset: 0x001617B4
	public unsafe ItemEffect m_Effect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_m_Effect);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_m_Effect)) = value;
		}
	}

	// Token: 0x17001F92 RID: 8082
	// (get) Token: 0x060058BA RID: 22714 RVA: 0x001635D8 File Offset: 0x001617D8
	// (set) Token: 0x060058BB RID: 22715 RVA: 0x0016360C File Offset: 0x0016180C
	public unsafe SpriteRenderer Graphic
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_Graphic);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new SpriteRenderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_Graphic), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F93 RID: 8083
	// (get) Token: 0x060058BC RID: 22716 RVA: 0x00163634 File Offset: 0x00161834
	// (set) Token: 0x060058BD RID: 22717 RVA: 0x00163668 File Offset: 0x00161868
	public unsafe Sprite normalSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_normalSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Sprite(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_normalSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F94 RID: 8084
	// (get) Token: 0x060058BE RID: 22718 RVA: 0x00163690 File Offset: 0x00161890
	// (set) Token: 0x060058BF RID: 22719 RVA: 0x001636C4 File Offset: 0x001618C4
	public unsafe Sprite aboveSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_aboveSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Sprite(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_aboveSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F95 RID: 8085
	// (get) Token: 0x060058C0 RID: 22720 RVA: 0x001636EC File Offset: 0x001618EC
	// (set) Token: 0x060058C1 RID: 22721 RVA: 0x00163720 File Offset: 0x00161920
	public unsafe Sprite belowSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_belowSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Sprite(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_belowSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F96 RID: 8086
	// (get) Token: 0x060058C2 RID: 22722 RVA: 0x00163748 File Offset: 0x00161948
	// (set) Token: 0x060058C3 RID: 22723 RVA: 0x0016377C File Offset: 0x0016197C
	public unsafe RectTransform RectRoot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_RectRoot);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_RectRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F97 RID: 8087
	// (get) Token: 0x060058C4 RID: 22724 RVA: 0x001637A4 File Offset: 0x001619A4
	// (set) Token: 0x060058C5 RID: 22725 RVA: 0x001637D8 File Offset: 0x001619D8
	public unsafe bl_MiniMapItemGraphic cacheItem
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_cacheItem);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new bl_MiniMapItemGraphic(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_cacheItem), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F98 RID: 8088
	// (get) Token: 0x060058C6 RID: 22726 RVA: 0x00163800 File Offset: 0x00161A00
	// (set) Token: 0x060058C7 RID: 22727 RVA: 0x00163828 File Offset: 0x00161A28
	public unsafe bool isRefreshing
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_isRefreshing);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_isRefreshing)) = value;
		}
	}

	// Token: 0x17001F99 RID: 8089
	// (get) Token: 0x060058C8 RID: 22728 RVA: 0x0016384C File Offset: 0x00161A4C
	// (set) Token: 0x060058C9 RID: 22729 RVA: 0x00163874 File Offset: 0x00161A74
	public unsafe Faction m_Faction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_m_Faction);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_m_Faction)) = value;
		}
	}

	// Token: 0x17001F9A RID: 8090
	// (get) Token: 0x060058CA RID: 22730 RVA: 0x00163898 File Offset: 0x00161A98
	// (set) Token: 0x060058CB RID: 22731 RVA: 0x001638C0 File Offset: 0x00161AC0
	public unsafe bool overrideFaction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_overrideFaction);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_overrideFaction)) = value;
		}
	}

	// Token: 0x17001F9B RID: 8091
	// (get) Token: 0x060058CC RID: 22732 RVA: 0x001638E4 File Offset: 0x00161AE4
	// (set) Token: 0x060058CD RID: 22733 RVA: 0x0016390C File Offset: 0x00161B0C
	public unsafe bool hasCreatedIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_hasCreatedIcon);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr_hasCreatedIcon)) = value;
		}
	}

	// Token: 0x17001F9C RID: 8092
	// (get) Token: 0x060058CE RID: 22734 RVA: 0x00163930 File Offset: 0x00161B30
	// (set) Token: 0x060058CF RID: 22735 RVA: 0x00163958 File Offset: 0x00161B58
	public unsafe float _distanceScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr__distanceScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr__distanceScale)) = value;
		}
	}

	// Token: 0x17001F9D RID: 8093
	// (get) Token: 0x060058D0 RID: 22736 RVA: 0x0016397C File Offset: 0x00161B7C
	// (set) Token: 0x060058D1 RID: 22737 RVA: 0x001639A4 File Offset: 0x00161BA4
	public unsafe bool _ManagedUpdateRemoval_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField)) = value;
		}
	}

	// Token: 0x04003810 RID: 14352
	private static readonly IntPtr NativeFieldInfoPtr_OnRefreshIcons;

	// Token: 0x04003811 RID: 14353
	private static readonly IntPtr NativeFieldInfoPtr_OnScaleIcons;

	// Token: 0x04003812 RID: 14354
	private static readonly IntPtr NativeFieldInfoPtr_GraphicPrefab;

	// Token: 0x04003813 RID: 14355
	private static readonly IntPtr NativeFieldInfoPtr_Target;

	// Token: 0x04003814 RID: 14356
	private static readonly IntPtr NativeFieldInfoPtr_OffSet;

	// Token: 0x04003815 RID: 14357
	private static readonly IntPtr NativeFieldInfoPtr_Icon;

	// Token: 0x04003816 RID: 14358
	private static readonly IntPtr NativeFieldInfoPtr_DeathIcon;

	// Token: 0x04003817 RID: 14359
	private static readonly IntPtr NativeFieldInfoPtr_IconColor;

	// Token: 0x04003818 RID: 14360
	private static readonly IntPtr NativeFieldInfoPtr_isPlayer;

	// Token: 0x04003819 RID: 14361
	private static readonly IntPtr NativeFieldInfoPtr_PlayerScript;

	// Token: 0x0400381A RID: 14362
	private static readonly IntPtr NativeFieldInfoPtr_PlayerDamageController;

	// Token: 0x0400381B RID: 14363
	private static readonly IntPtr NativeFieldInfoPtr_Size;

	// Token: 0x0400381C RID: 14364
	private static readonly IntPtr NativeFieldInfoPtr_isInteractable;

	// Token: 0x0400381D RID: 14365
	private static readonly IntPtr NativeFieldInfoPtr_InfoItem;

	// Token: 0x0400381E RID: 14366
	private static readonly IntPtr NativeFieldInfoPtr_DoShowOffScreen;

	// Token: 0x0400381F RID: 14367
	private static readonly IntPtr NativeFieldInfoPtr_DelayCreation;

	// Token: 0x04003820 RID: 14368
	private static readonly IntPtr NativeFieldInfoPtr_BorderOffScreen;

	// Token: 0x04003821 RID: 14369
	private static readonly IntPtr NativeFieldInfoPtr_MinDistanceScale;

	// Token: 0x04003822 RID: 14370
	private static readonly IntPtr NativeFieldInfoPtr_OffscreenScalingDistanceInScreens;

	// Token: 0x04003823 RID: 14371
	private static readonly IntPtr NativeFieldInfoPtr_OffScreenSize;

	// Token: 0x04003824 RID: 14372
	private static readonly IntPtr NativeFieldInfoPtr_StopAutoCreate;

	// Token: 0x04003825 RID: 14373
	private static readonly IntPtr NativeFieldInfoPtr_m_Effect;

	// Token: 0x04003826 RID: 14374
	private static readonly IntPtr NativeFieldInfoPtr_Graphic;

	// Token: 0x04003827 RID: 14375
	private static readonly IntPtr NativeFieldInfoPtr_normalSprite;

	// Token: 0x04003828 RID: 14376
	private static readonly IntPtr NativeFieldInfoPtr_aboveSprite;

	// Token: 0x04003829 RID: 14377
	private static readonly IntPtr NativeFieldInfoPtr_belowSprite;

	// Token: 0x0400382A RID: 14378
	private static readonly IntPtr NativeFieldInfoPtr_RectRoot;

	// Token: 0x0400382B RID: 14379
	private static readonly IntPtr NativeFieldInfoPtr_cacheItem;

	// Token: 0x0400382C RID: 14380
	private static readonly IntPtr NativeFieldInfoPtr_isRefreshing;

	// Token: 0x0400382D RID: 14381
	private static readonly IntPtr NativeFieldInfoPtr_m_Faction;

	// Token: 0x0400382E RID: 14382
	private static readonly IntPtr NativeFieldInfoPtr_overrideFaction;

	// Token: 0x0400382F RID: 14383
	private static readonly IntPtr NativeFieldInfoPtr_hasCreatedIcon;

	// Token: 0x04003830 RID: 14384
	private static readonly IntPtr NativeFieldInfoPtr__distanceScale;

	// Token: 0x04003831 RID: 14385
	private static readonly IntPtr NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField;

	// Token: 0x04003832 RID: 14386
	private static readonly IntPtr NativeMethodInfoPtr_get_BaseScale_Public_get_Vector3_0;

	// Token: 0x04003833 RID: 14387
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04003834 RID: 14388
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04003835 RID: 14389
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04003836 RID: 14390
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04003837 RID: 14391
	private static readonly IntPtr NativeMethodInfoPtr_OnRefresh_Protected_Void_MonoBehaviour_0;

	// Token: 0x04003838 RID: 14392
	private static readonly IntPtr NativeMethodInfoPtr_WaitToCreateIcon_Public_IEnumerator_0;

	// Token: 0x04003839 RID: 14393
	private static readonly IntPtr NativeMethodInfoPtr_ReCreateIcon_Public_IEnumerator_0;

	// Token: 0x0400383A RID: 14394
	private static readonly IntPtr NativeMethodInfoPtr_CreateIcon_Public_Void_0;

	// Token: 0x0400383B RID: 14395
	private static readonly IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_0;

	// Token: 0x0400383C RID: 14396
	private static readonly IntPtr NativeMethodInfoPtr_RefreshFaction_Public_Void_0;

	// Token: 0x0400383D RID: 14397
	private static readonly IntPtr NativeMethodInfoPtr_DestroyIconItem_Public_Void_Boolean_0;

	// Token: 0x0400383E RID: 14398
	private static readonly IntPtr NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x0400383F RID: 14399
	private static readonly IntPtr NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0;

	// Token: 0x04003840 RID: 14400
	private static readonly IntPtr NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0;

	// Token: 0x04003841 RID: 14401
	private static readonly IntPtr NativeMethodInfoPtr_StartEffect_Private_Void_0;

	// Token: 0x04003842 RID: 14402
	private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Void_Boolean_0;

	// Token: 0x04003843 RID: 14403
	private static readonly IntPtr NativeMethodInfoPtr_QueueDestroy_Public_IEnumerator_Single_0;

	// Token: 0x04003844 RID: 14404
	private static readonly IntPtr NativeMethodInfoPtr_HideItem_Public_Void_0;

	// Token: 0x04003845 RID: 14405
	private static readonly IntPtr NativeMethodInfoPtr_ShowItem_Public_Void_0;

	// Token: 0x04003846 RID: 14406
	private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0;

	// Token: 0x04003847 RID: 14407
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000452 RID: 1106
	[ObfuscatedName("bl_MiniMapItem/<WaitToCreateIcon>d__40")]
	public sealed class _WaitToCreateIcon_d__40 : Il2CppSystem.Object
	{
		// Token: 0x060058D2 RID: 22738 RVA: 0x001639C8 File Offset: 0x00161BC8
		[CallerCount(0)]
		public unsafe _WaitToCreateIcon_d__40(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bl_MiniMapItem._WaitToCreateIcon_d__40>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._WaitToCreateIcon_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x00163A28 File Offset: 0x00161C28
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._WaitToCreateIcon_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x00163A6C File Offset: 0x00161C6C
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._WaitToCreateIcon_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x060058D5 RID: 22741 RVA: 0x00163ABC File Offset: 0x00161CBC
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._WaitToCreateIcon_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x00163B14 File Offset: 0x00161D14
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._WaitToCreateIcon_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x060058D7 RID: 22743 RVA: 0x00163B58 File Offset: 0x00161D58
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._WaitToCreateIcon_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x00163BB0 File Offset: 0x00161DB0
		// Note: this type is marked as 'beforefieldinit'.
		static _WaitToCreateIcon_d__40()
		{
			Il2CppClassPointerStore<bl_MiniMapItem._WaitToCreateIcon_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "<WaitToCreateIcon>d__40");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bl_MiniMapItem._WaitToCreateIcon_d__40>.NativeClassPtr);
			bl_MiniMapItem._WaitToCreateIcon_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem._WaitToCreateIcon_d__40>.NativeClassPtr, "<>1__state");
			bl_MiniMapItem._WaitToCreateIcon_d__40.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem._WaitToCreateIcon_d__40>.NativeClassPtr, "<>2__current");
			bl_MiniMapItem._WaitToCreateIcon_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem._WaitToCreateIcon_d__40>.NativeClassPtr, "<>4__this");
			bl_MiniMapItem._WaitToCreateIcon_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._WaitToCreateIcon_d__40>.NativeClassPtr, 100670294);
			bl_MiniMapItem._WaitToCreateIcon_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._WaitToCreateIcon_d__40>.NativeClassPtr, 100670295);
			bl_MiniMapItem._WaitToCreateIcon_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._WaitToCreateIcon_d__40>.NativeClassPtr, 100670296);
			bl_MiniMapItem._WaitToCreateIcon_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._WaitToCreateIcon_d__40>.NativeClassPtr, 100670297);
			bl_MiniMapItem._WaitToCreateIcon_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._WaitToCreateIcon_d__40>.NativeClassPtr, 100670298);
			bl_MiniMapItem._WaitToCreateIcon_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._WaitToCreateIcon_d__40>.NativeClassPtr, 100670299);
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x00002988 File Offset: 0x00000B88
		public _WaitToCreateIcon_d__40(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x060058DA RID: 22746 RVA: 0x00163C8F File Offset: 0x00161E8F
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<bl_MiniMapItem._WaitToCreateIcon_d__40>.NativeClassPtr));
			}
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x060058DB RID: 22747 RVA: 0x00163CA0 File Offset: 0x00161EA0
		// (set) Token: 0x060058DC RID: 22748 RVA: 0x00163CC8 File Offset: 0x00161EC8
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._WaitToCreateIcon_d__40.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._WaitToCreateIcon_d__40.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x060058DD RID: 22749 RVA: 0x00163CEC File Offset: 0x00161EEC
		// (set) Token: 0x060058DE RID: 22750 RVA: 0x00163D20 File Offset: 0x00161F20
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._WaitToCreateIcon_d__40.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._WaitToCreateIcon_d__40.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x060058DF RID: 22751 RVA: 0x00163D48 File Offset: 0x00161F48
		// (set) Token: 0x060058E0 RID: 22752 RVA: 0x00163D7C File Offset: 0x00161F7C
		public unsafe bl_MiniMapItem __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._WaitToCreateIcon_d__40.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new bl_MiniMapItem(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._WaitToCreateIcon_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003848 RID: 14408
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04003849 RID: 14409
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400384A RID: 14410
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400384B RID: 14411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400384C RID: 14412
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400384D RID: 14413
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400384E RID: 14414
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400384F RID: 14415
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003850 RID: 14416
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000453 RID: 1107
	[ObfuscatedName("bl_MiniMapItem/<ReCreateIcon>d__41")]
	public sealed class _ReCreateIcon_d__41 : Il2CppSystem.Object
	{
		// Token: 0x060058E1 RID: 22753 RVA: 0x00163DA4 File Offset: 0x00161FA4
		[CallerCount(0)]
		public unsafe _ReCreateIcon_d__41(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bl_MiniMapItem._ReCreateIcon_d__41>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._ReCreateIcon_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x00163E04 File Offset: 0x00162004
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._ReCreateIcon_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x00163E48 File Offset: 0x00162048
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._ReCreateIcon_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17001FAB RID: 8107
		// (get) Token: 0x060058E4 RID: 22756 RVA: 0x00163E98 File Offset: 0x00162098
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._ReCreateIcon_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x00163EF0 File Offset: 0x001620F0
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._ReCreateIcon_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001FAC RID: 8108
		// (get) Token: 0x060058E6 RID: 22758 RVA: 0x00163F34 File Offset: 0x00162134
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._ReCreateIcon_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x00163F8C File Offset: 0x0016218C
		// Note: this type is marked as 'beforefieldinit'.
		static _ReCreateIcon_d__41()
		{
			Il2CppClassPointerStore<bl_MiniMapItem._ReCreateIcon_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "<ReCreateIcon>d__41");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bl_MiniMapItem._ReCreateIcon_d__41>.NativeClassPtr);
			bl_MiniMapItem._ReCreateIcon_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem._ReCreateIcon_d__41>.NativeClassPtr, "<>1__state");
			bl_MiniMapItem._ReCreateIcon_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem._ReCreateIcon_d__41>.NativeClassPtr, "<>2__current");
			bl_MiniMapItem._ReCreateIcon_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem._ReCreateIcon_d__41>.NativeClassPtr, "<>4__this");
			bl_MiniMapItem._ReCreateIcon_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._ReCreateIcon_d__41>.NativeClassPtr, 100670300);
			bl_MiniMapItem._ReCreateIcon_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._ReCreateIcon_d__41>.NativeClassPtr, 100670301);
			bl_MiniMapItem._ReCreateIcon_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._ReCreateIcon_d__41>.NativeClassPtr, 100670302);
			bl_MiniMapItem._ReCreateIcon_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._ReCreateIcon_d__41>.NativeClassPtr, 100670303);
			bl_MiniMapItem._ReCreateIcon_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._ReCreateIcon_d__41>.NativeClassPtr, 100670304);
			bl_MiniMapItem._ReCreateIcon_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._ReCreateIcon_d__41>.NativeClassPtr, 100670305);
		}

		// Token: 0x060058E8 RID: 22760 RVA: 0x00002988 File Offset: 0x00000B88
		public _ReCreateIcon_d__41(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x060058E9 RID: 22761 RVA: 0x0016406B File Offset: 0x0016226B
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<bl_MiniMapItem._ReCreateIcon_d__41>.NativeClassPtr));
			}
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x060058EA RID: 22762 RVA: 0x0016407C File Offset: 0x0016227C
		// (set) Token: 0x060058EB RID: 22763 RVA: 0x001640A4 File Offset: 0x001622A4
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._ReCreateIcon_d__41.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._ReCreateIcon_d__41.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001FA9 RID: 8105
		// (get) Token: 0x060058EC RID: 22764 RVA: 0x001640C8 File Offset: 0x001622C8
		// (set) Token: 0x060058ED RID: 22765 RVA: 0x001640FC File Offset: 0x001622FC
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._ReCreateIcon_d__41.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._ReCreateIcon_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FAA RID: 8106
		// (get) Token: 0x060058EE RID: 22766 RVA: 0x00164124 File Offset: 0x00162324
		// (set) Token: 0x060058EF RID: 22767 RVA: 0x00164158 File Offset: 0x00162358
		public unsafe bl_MiniMapItem __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._ReCreateIcon_d__41.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new bl_MiniMapItem(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._ReCreateIcon_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003851 RID: 14417
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04003852 RID: 14418
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04003853 RID: 14419
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04003854 RID: 14420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003855 RID: 14421
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003856 RID: 14422
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04003857 RID: 14423
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003858 RID: 14424
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003859 RID: 14425
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000454 RID: 1108
	[ObfuscatedName("bl_MiniMapItem/<QueueDestroy>d__53")]
	public sealed class _QueueDestroy_d__53 : Il2CppSystem.Object
	{
		// Token: 0x060058F0 RID: 22768 RVA: 0x00164180 File Offset: 0x00162380
		[CallerCount(0)]
		public unsafe _QueueDestroy_d__53(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._QueueDestroy_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x001641E0 File Offset: 0x001623E0
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._QueueDestroy_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x00164224 File Offset: 0x00162424
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._QueueDestroy_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x060058F3 RID: 22771 RVA: 0x00164274 File Offset: 0x00162474
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._QueueDestroy_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060058F4 RID: 22772 RVA: 0x001642CC File Offset: 0x001624CC
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._QueueDestroy_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x060058F5 RID: 22773 RVA: 0x00164310 File Offset: 0x00162510
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMapItem._QueueDestroy_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x00164368 File Offset: 0x00162568
		// Note: this type is marked as 'beforefieldinit'.
		static _QueueDestroy_d__53()
		{
			Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<bl_MiniMapItem>.NativeClassPtr, "<QueueDestroy>d__53");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr);
			bl_MiniMapItem._QueueDestroy_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr, "<>1__state");
			bl_MiniMapItem._QueueDestroy_d__53.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr, "<>2__current");
			bl_MiniMapItem._QueueDestroy_d__53.NativeFieldInfoPtr_waitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr, "waitTime");
			bl_MiniMapItem._QueueDestroy_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr, "<>4__this");
			bl_MiniMapItem._QueueDestroy_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr, 100670306);
			bl_MiniMapItem._QueueDestroy_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr, 100670307);
			bl_MiniMapItem._QueueDestroy_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr, 100670308);
			bl_MiniMapItem._QueueDestroy_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr, 100670309);
			bl_MiniMapItem._QueueDestroy_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr, 100670310);
			bl_MiniMapItem._QueueDestroy_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr, 100670311);
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x00002988 File Offset: 0x00000B88
		public _QueueDestroy_d__53(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x060058F8 RID: 22776 RVA: 0x0016445B File Offset: 0x0016265B
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<bl_MiniMapItem._QueueDestroy_d__53>.NativeClassPtr));
			}
		}

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x060058F9 RID: 22777 RVA: 0x0016446C File Offset: 0x0016266C
		// (set) Token: 0x060058FA RID: 22778 RVA: 0x00164494 File Offset: 0x00162694
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._QueueDestroy_d__53.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._QueueDestroy_d__53.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x060058FB RID: 22779 RVA: 0x001644B8 File Offset: 0x001626B8
		// (set) Token: 0x060058FC RID: 22780 RVA: 0x001644EC File Offset: 0x001626EC
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._QueueDestroy_d__53.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._QueueDestroy_d__53.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FB0 RID: 8112
		// (get) Token: 0x060058FD RID: 22781 RVA: 0x00164514 File Offset: 0x00162714
		// (set) Token: 0x060058FE RID: 22782 RVA: 0x0016453C File Offset: 0x0016273C
		public unsafe float waitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._QueueDestroy_d__53.NativeFieldInfoPtr_waitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._QueueDestroy_d__53.NativeFieldInfoPtr_waitTime)) = value;
			}
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x060058FF RID: 22783 RVA: 0x00164560 File Offset: 0x00162760
		// (set) Token: 0x06005900 RID: 22784 RVA: 0x00164594 File Offset: 0x00162794
		public unsafe bl_MiniMapItem __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._QueueDestroy_d__53.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new bl_MiniMapItem(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMapItem._QueueDestroy_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400385A RID: 14426
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400385B RID: 14427
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400385C RID: 14428
		private static readonly IntPtr NativeFieldInfoPtr_waitTime;

		// Token: 0x0400385D RID: 14429
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400385E RID: 14430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400385F RID: 14431
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003860 RID: 14432
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04003861 RID: 14433
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003862 RID: 14434
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003863 RID: 14435
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
