using System;
using Il2CppSystem;
using Onward.Tablet;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200044E RID: 1102
public class bl_MiniMap : MonoBehaviour
{
	// Token: 0x17001F73 RID: 8051
	// (get) Token: 0x060057FE RID: 22526 RVA: 0x001607D8 File Offset: 0x0015E9D8
	// (set) Token: 0x060057FF RID: 22527 RVA: 0x00160820 File Offset: 0x0015EA20
	public unsafe static bl_MiniMap Singleton
	{
		[CallerCount(0)]
		get
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_get_Singleton_Public_Static_get_bl_MiniMap_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new bl_MiniMap(intPtr2) : null;
		}
		[CallerCount(0)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_set_Singleton_Private_Static_set_Void_bl_MiniMap_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x17001F74 RID: 8052
	// (get) Token: 0x06005800 RID: 22528 RVA: 0x0016086C File Offset: 0x0015EA6C
	// (set) Token: 0x06005801 RID: 22529 RVA: 0x001608B4 File Offset: 0x0015EAB4
	public unsafe static RectTransform MapUIRoot
	{
		[CallerCount(0)]
		get
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_get_MapUIRoot_Public_Static_get_RectTransform_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		[CallerCount(0)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_set_MapUIRoot_Private_Static_set_Void_RectTransform_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x17001F75 RID: 8053
	// (get) Token: 0x06005802 RID: 22530 RVA: 0x00160900 File Offset: 0x0015EB00
	// (set) Token: 0x06005803 RID: 22531 RVA: 0x00160948 File Offset: 0x0015EB48
	public unsafe static RectTransform MapUIIconRoot
	{
		[CallerCount(0)]
		get
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_get_MapUIIconRoot_Public_Static_get_RectTransform_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		[CallerCount(0)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_set_MapUIIconRoot_Private_Static_set_Void_RectTransform_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x17001F76 RID: 8054
	// (get) Token: 0x06005804 RID: 22532 RVA: 0x00160994 File Offset: 0x0015EB94
	// (set) Token: 0x06005805 RID: 22533 RVA: 0x001609E4 File Offset: 0x0015EBE4
	public unsafe float CurMinimapZoomFactor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_get_CurMinimapZoomFactor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_set_CurMinimapZoomFactor_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x06005806 RID: 22534 RVA: 0x00160A38 File Offset: 0x0015EC38
	[CallerCount(0)]
	public unsafe static void TryCreateSingleton(bl_MiniMap prefab, Pickup_Tablet tablet, Canvas screen)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tablet);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(screen);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_TryCreateSingleton_Public_Static_Void_bl_MiniMap_Pickup_Tablet_Canvas_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005807 RID: 22535 RVA: 0x00160AB4 File Offset: 0x0015ECB4
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005808 RID: 22536 RVA: 0x00160AF8 File Offset: 0x0015ECF8
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005809 RID: 22537 RVA: 0x00160B3C File Offset: 0x0015ED3C
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600580A RID: 22538 RVA: 0x00160B80 File Offset: 0x0015ED80
	[CallerCount(0)]
	public unsafe void InitializeToTablet(Pickup_Tablet tablet, Canvas screen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tablet);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(screen);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_InitializeToTablet_Public_Void_Pickup_Tablet_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600580B RID: 22539 RVA: 0x00160BF4 File Offset: 0x0015EDF4
	[CallerCount(0)]
	public unsafe void SwapToTablet(Pickup_Tablet tablet, Canvas screen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tablet);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(screen);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_SwapToTablet_Public_Void_Pickup_Tablet_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600580C RID: 22540 RVA: 0x00160C68 File Offset: 0x0015EE68
	[CallerCount(0)]
	public unsafe void CreateMapPlane()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_CreateMapPlane_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600580D RID: 22541 RVA: 0x00160CAC File Offset: 0x0015EEAC
	[CallerCount(0)]
	public unsafe void ConfigureCamera3D()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_ConfigureCamera3D_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600580E RID: 22542 RVA: 0x00160CF0 File Offset: 0x0015EEF0
	[CallerCount(0)]
	public unsafe bool ShouldProjectIcons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_ShouldProjectIcons_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x0600580F RID: 22543 RVA: 0x00160D40 File Offset: 0x0015EF40
	[CallerCount(0)]
	public unsafe void OnPlayerHealthEventOccurred(WarPlayerScript player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_OnPlayerHealthEventOccurred_Private_Void_WarPlayerScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005810 RID: 22544 RVA: 0x00160D9C File Offset: 0x0015EF9C
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005811 RID: 22545 RVA: 0x00160DE0 File Offset: 0x0015EFE0
	[CallerCount(0)]
	public unsafe void PositionControl(bool useLerp = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref useLerp;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_PositionControl_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005812 RID: 22546 RVA: 0x00160E34 File Offset: 0x0015F034
	[CallerCount(0)]
	public unsafe void SnapMinimapToPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_SnapMinimapToPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005813 RID: 22547 RVA: 0x00160E78 File Offset: 0x0015F078
	[CallerCount(0)]
	public unsafe void RotationControl()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_RotationControl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005814 RID: 22548 RVA: 0x00160EBC File Offset: 0x0015F0BC
	[CallerCount(0)]
	public unsafe Material CreateMaterial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_CreateMaterial_Public_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new Material(intPtr2) : null;
	}

	// Token: 0x06005815 RID: 22549 RVA: 0x00160F14 File Offset: 0x0015F114
	[CallerCount(0)]
	public unsafe void ResetMapRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_ResetMapRotation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005816 RID: 22550 RVA: 0x00160F58 File Offset: 0x0015F158
	[CallerCount(0)]
	public unsafe void RotationMap(bool mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref mode;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_RotationMap_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005817 RID: 22551 RVA: 0x00160FAC File Offset: 0x0015F1AC
	[CallerCount(0)]
	public unsafe void GetMiniMapSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_GetMiniMapSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005818 RID: 22552 RVA: 0x00160FF0 File Offset: 0x0015F1F0
	[CallerCount(0)]
	public unsafe void ZoomMinimap(float zoomFactor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref zoomFactor;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_ZoomMinimap_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x17001F77 RID: 8055
	// (get) Token: 0x06005819 RID: 22553 RVA: 0x00161044 File Offset: 0x0015F244
	public unsafe Transform Target
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_get_Target_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
	}

	// Token: 0x17001F78 RID: 8056
	// (get) Token: 0x0600581A RID: 22554 RVA: 0x0016109C File Offset: 0x0015F29C
	public unsafe Vector3 TargetPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x0600581B RID: 22555 RVA: 0x001610EC File Offset: 0x0015F2EC
	[CallerCount(0)]
	public unsafe bl_MiniMap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MiniMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600581C RID: 22556 RVA: 0x00161138 File Offset: 0x0015F338
	// Note: this type is marked as 'beforefieldinit'.
	static bl_MiniMap()
	{
		Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "bl_MiniMap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr);
		bl_MiniMap.NativeFieldInfoPtr__Singleton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "<Singleton>k__BackingField");
		bl_MiniMap.NativeFieldInfoPtr_isFullScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "isFullScreen");
		bl_MiniMap.NativeFieldInfoPtr_GlobalIconProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "GlobalIconProjector");
		bl_MiniMap.NativeFieldInfoPtr__MapUIRoot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "<MapUIRoot>k__BackingField");
		bl_MiniMap.NativeFieldInfoPtr__MapUIIconRoot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "<MapUIIconRoot>k__BackingField");
		bl_MiniMap.NativeFieldInfoPtr_thisTablet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "thisTablet");
		bl_MiniMap.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "m_Target");
		bl_MiniMap.NativeFieldInfoPtr_IconProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "IconProjector");
		bl_MiniMap.NativeFieldInfoPtr_isProjectingIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "isProjectingIcons");
		bl_MiniMap.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "m_Type");
		bl_MiniMap.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "m_Mode");
		bl_MiniMap.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "m_Canvas");
		bl_MiniMap.NativeFieldInfoPtr_maxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "maxHeight");
		bl_MiniMap.NativeFieldInfoPtr_minHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "minHeight");
		bl_MiniMap.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "height");
		bl_MiniMap.NativeFieldInfoPtr_useCompassRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "useCompassRotation");
		bl_MiniMap.NativeFieldInfoPtr_DynamicRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "DynamicRotation");
		bl_MiniMap.NativeFieldInfoPtr_SmoothRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "SmoothRotation");
		bl_MiniMap.NativeFieldInfoPtr_LerpRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "LerpRotation");
		bl_MiniMap.NativeFieldInfoPtr_MapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "MapTexture");
		bl_MiniMap.NativeFieldInfoPtr_SpecularColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "SpecularColor");
		bl_MiniMap.NativeFieldInfoPtr_EmessiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "EmessiveColor");
		bl_MiniMap.NativeFieldInfoPtr_EmissionAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "EmissionAmount");
		bl_MiniMap.NativeFieldInfoPtr_ReferenceMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "ReferenceMat");
		bl_MiniMap.NativeFieldInfoPtr_MapPlanePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "MapPlanePrefab");
		bl_MiniMap.NativeFieldInfoPtr_WorldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "WorldSpace");
		bl_MiniMap.NativeFieldInfoPtr_DefaultRotationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "DefaultRotationMode");
		bl_MiniMap.NativeFieldInfoPtr_DefaultRotationCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "DefaultRotationCircle");
		bl_MiniMap.NativeFieldInfoPtr_DefaultMapRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "DefaultMapRot");
		bl_MiniMap.NativeFieldInfoPtr_MiniMapPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "MiniMapPosition");
		bl_MiniMap.NativeFieldInfoPtr_MiniMapRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "MiniMapRotation");
		bl_MiniMap.NativeFieldInfoPtr_MiniMapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "MiniMapSize");
		bl_MiniMap.NativeFieldInfoPtr__CurMinimapZoomFactor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "<CurMinimapZoomFactor>k__BackingField");
		bl_MiniMap.NativeFieldInfoPtr_BasePlayerIconScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "BasePlayerIconScale");
		bl_MiniMap.NativeFieldInfoPtr_BaseOrthographicSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "BaseOrthographicSize");
		bl_MiniMap.NativeFieldInfoPtr_thisTabletScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "thisTabletScreen");
		bl_MiniMap.NativeFieldInfoPtr_HasInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "HasInit");
		bl_MiniMap.NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "m_Transform");
		bl_MiniMap.NativeFieldInfoPtr__iconsNeedRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "_iconsNeedRefresh");
		bl_MiniMap.NativeFieldInfoPtr_TIME_BETWEEN_UI_REFRESH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "TIME_BETWEEN_UI_REFRESH");
		bl_MiniMap.NativeFieldInfoPtr__lastRefreshTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, "_lastRefreshTime");
		bl_MiniMap.NativeMethodInfoPtr_get_Singleton_Public_Static_get_bl_MiniMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670242);
		bl_MiniMap.NativeMethodInfoPtr_set_Singleton_Private_Static_set_Void_bl_MiniMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670243);
		bl_MiniMap.NativeMethodInfoPtr_get_MapUIRoot_Public_Static_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670244);
		bl_MiniMap.NativeMethodInfoPtr_set_MapUIRoot_Private_Static_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670245);
		bl_MiniMap.NativeMethodInfoPtr_get_MapUIIconRoot_Public_Static_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670246);
		bl_MiniMap.NativeMethodInfoPtr_set_MapUIIconRoot_Private_Static_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670247);
		bl_MiniMap.NativeMethodInfoPtr_get_CurMinimapZoomFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670248);
		bl_MiniMap.NativeMethodInfoPtr_set_CurMinimapZoomFactor_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670249);
		bl_MiniMap.NativeMethodInfoPtr_TryCreateSingleton_Public_Static_Void_bl_MiniMap_Pickup_Tablet_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670250);
		bl_MiniMap.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670251);
		bl_MiniMap.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670252);
		bl_MiniMap.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670253);
		bl_MiniMap.NativeMethodInfoPtr_InitializeToTablet_Public_Void_Pickup_Tablet_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670254);
		bl_MiniMap.NativeMethodInfoPtr_SwapToTablet_Public_Void_Pickup_Tablet_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670255);
		bl_MiniMap.NativeMethodInfoPtr_CreateMapPlane_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670256);
		bl_MiniMap.NativeMethodInfoPtr_ConfigureCamera3D_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670257);
		bl_MiniMap.NativeMethodInfoPtr_ShouldProjectIcons_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670258);
		bl_MiniMap.NativeMethodInfoPtr_OnPlayerHealthEventOccurred_Private_Void_WarPlayerScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670259);
		bl_MiniMap.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670260);
		bl_MiniMap.NativeMethodInfoPtr_PositionControl_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670261);
		bl_MiniMap.NativeMethodInfoPtr_SnapMinimapToPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670262);
		bl_MiniMap.NativeMethodInfoPtr_RotationControl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670263);
		bl_MiniMap.NativeMethodInfoPtr_CreateMaterial_Public_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670264);
		bl_MiniMap.NativeMethodInfoPtr_ResetMapRotation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670265);
		bl_MiniMap.NativeMethodInfoPtr_RotationMap_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670266);
		bl_MiniMap.NativeMethodInfoPtr_GetMiniMapSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670267);
		bl_MiniMap.NativeMethodInfoPtr_ZoomMinimap_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670268);
		bl_MiniMap.NativeMethodInfoPtr_get_Target_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670269);
		bl_MiniMap.NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670270);
		bl_MiniMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr, 100670271);
	}

	// Token: 0x0600581D RID: 22557 RVA: 0x0000210C File Offset: 0x0000030C
	public bl_MiniMap(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001F49 RID: 8009
	// (get) Token: 0x0600581E RID: 22558 RVA: 0x001616F4 File Offset: 0x0015F8F4
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<bl_MiniMap>.NativeClassPtr));
		}
	}

	// Token: 0x17001F4A RID: 8010
	// (get) Token: 0x0600581F RID: 22559 RVA: 0x00161708 File Offset: 0x0015F908
	// (set) Token: 0x06005820 RID: 22560 RVA: 0x00161733 File Offset: 0x0015F933
	public unsafe static bl_MiniMap _Singleton_k__BackingField
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(bl_MiniMap.NativeFieldInfoPtr__Singleton_k__BackingField, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new bl_MiniMap(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(bl_MiniMap.NativeFieldInfoPtr__Singleton_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F4B RID: 8011
	// (get) Token: 0x06005821 RID: 22561 RVA: 0x00161748 File Offset: 0x0015F948
	// (set) Token: 0x06005822 RID: 22562 RVA: 0x00161766 File Offset: 0x0015F966
	public unsafe static bool isFullScreen
	{
		get
		{
			bool result;
			IL2CPP.il2cpp_field_static_get_value(bl_MiniMap.NativeFieldInfoPtr_isFullScreen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(bl_MiniMap.NativeFieldInfoPtr_isFullScreen, (void*)(&value));
		}
	}

	// Token: 0x17001F4C RID: 8012
	// (get) Token: 0x06005823 RID: 22563 RVA: 0x00161778 File Offset: 0x0015F978
	// (set) Token: 0x06005824 RID: 22564 RVA: 0x001617A3 File Offset: 0x0015F9A3
	public unsafe static MapIconProjector GlobalIconProjector
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(bl_MiniMap.NativeFieldInfoPtr_GlobalIconProjector, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new MapIconProjector(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(bl_MiniMap.NativeFieldInfoPtr_GlobalIconProjector, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F4D RID: 8013
	// (get) Token: 0x06005825 RID: 22565 RVA: 0x001617B8 File Offset: 0x0015F9B8
	// (set) Token: 0x06005826 RID: 22566 RVA: 0x001617E3 File Offset: 0x0015F9E3
	public unsafe static RectTransform _MapUIRoot_k__BackingField
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(bl_MiniMap.NativeFieldInfoPtr__MapUIRoot_k__BackingField, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(bl_MiniMap.NativeFieldInfoPtr__MapUIRoot_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F4E RID: 8014
	// (get) Token: 0x06005827 RID: 22567 RVA: 0x001617F8 File Offset: 0x0015F9F8
	// (set) Token: 0x06005828 RID: 22568 RVA: 0x00161823 File Offset: 0x0015FA23
	public unsafe static RectTransform _MapUIIconRoot_k__BackingField
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(bl_MiniMap.NativeFieldInfoPtr__MapUIIconRoot_k__BackingField, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(bl_MiniMap.NativeFieldInfoPtr__MapUIIconRoot_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F4F RID: 8015
	// (get) Token: 0x06005829 RID: 22569 RVA: 0x00161838 File Offset: 0x0015FA38
	// (set) Token: 0x0600582A RID: 22570 RVA: 0x0016186C File Offset: 0x0015FA6C
	public unsafe Pickup_Tablet thisTablet
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_thisTablet);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Pickup_Tablet(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_thisTablet), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F50 RID: 8016
	// (get) Token: 0x0600582B RID: 22571 RVA: 0x00161894 File Offset: 0x0015FA94
	// (set) Token: 0x0600582C RID: 22572 RVA: 0x001618C8 File Offset: 0x0015FAC8
	public unsafe Transform m_Target
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_m_Target);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F51 RID: 8017
	// (get) Token: 0x0600582D RID: 22573 RVA: 0x001618F0 File Offset: 0x0015FAF0
	// (set) Token: 0x0600582E RID: 22574 RVA: 0x00161924 File Offset: 0x0015FB24
	public unsafe MapIconProjector IconProjector
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_IconProjector);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new MapIconProjector(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_IconProjector), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F52 RID: 8018
	// (get) Token: 0x0600582F RID: 22575 RVA: 0x0016194C File Offset: 0x0015FB4C
	// (set) Token: 0x06005830 RID: 22576 RVA: 0x00161974 File Offset: 0x0015FB74
	public unsafe bool isProjectingIcons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_isProjectingIcons);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_isProjectingIcons)) = value;
		}
	}

	// Token: 0x17001F53 RID: 8019
	// (get) Token: 0x06005831 RID: 22577 RVA: 0x00161998 File Offset: 0x0015FB98
	// (set) Token: 0x06005832 RID: 22578 RVA: 0x001619C0 File Offset: 0x0015FBC0
	public unsafe bl_MiniMap.RenderType m_Type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_m_Type);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_m_Type)) = value;
		}
	}

	// Token: 0x17001F54 RID: 8020
	// (get) Token: 0x06005833 RID: 22579 RVA: 0x001619E4 File Offset: 0x0015FBE4
	// (set) Token: 0x06005834 RID: 22580 RVA: 0x00161A0C File Offset: 0x0015FC0C
	public unsafe bl_MiniMap.RenderMode m_Mode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_m_Mode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_m_Mode)) = value;
		}
	}

	// Token: 0x17001F55 RID: 8021
	// (get) Token: 0x06005835 RID: 22581 RVA: 0x00161A30 File Offset: 0x0015FC30
	// (set) Token: 0x06005836 RID: 22582 RVA: 0x00161A64 File Offset: 0x0015FC64
	public unsafe Canvas m_Canvas
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_m_Canvas);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Canvas(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F56 RID: 8022
	// (get) Token: 0x06005837 RID: 22583 RVA: 0x00161A8C File Offset: 0x0015FC8C
	// (set) Token: 0x06005838 RID: 22584 RVA: 0x00161AB4 File Offset: 0x0015FCB4
	public unsafe float maxHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_maxHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_maxHeight)) = value;
		}
	}

	// Token: 0x17001F57 RID: 8023
	// (get) Token: 0x06005839 RID: 22585 RVA: 0x00161AD8 File Offset: 0x0015FCD8
	// (set) Token: 0x0600583A RID: 22586 RVA: 0x00161B00 File Offset: 0x0015FD00
	public unsafe float minHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_minHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_minHeight)) = value;
		}
	}

	// Token: 0x17001F58 RID: 8024
	// (get) Token: 0x0600583B RID: 22587 RVA: 0x00161B24 File Offset: 0x0015FD24
	// (set) Token: 0x0600583C RID: 22588 RVA: 0x00161B4C File Offset: 0x0015FD4C
	public unsafe float height
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_height);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_height)) = value;
		}
	}

	// Token: 0x17001F59 RID: 8025
	// (get) Token: 0x0600583D RID: 22589 RVA: 0x00161B70 File Offset: 0x0015FD70
	// (set) Token: 0x0600583E RID: 22590 RVA: 0x00161B98 File Offset: 0x0015FD98
	public unsafe bool useCompassRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_useCompassRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_useCompassRotation)) = value;
		}
	}

	// Token: 0x17001F5A RID: 8026
	// (get) Token: 0x0600583F RID: 22591 RVA: 0x00161BBC File Offset: 0x0015FDBC
	// (set) Token: 0x06005840 RID: 22592 RVA: 0x00161BE4 File Offset: 0x0015FDE4
	public unsafe bool DynamicRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_DynamicRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_DynamicRotation)) = value;
		}
	}

	// Token: 0x17001F5B RID: 8027
	// (get) Token: 0x06005841 RID: 22593 RVA: 0x00161C08 File Offset: 0x0015FE08
	// (set) Token: 0x06005842 RID: 22594 RVA: 0x00161C30 File Offset: 0x0015FE30
	public unsafe bool SmoothRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_SmoothRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_SmoothRotation)) = value;
		}
	}

	// Token: 0x17001F5C RID: 8028
	// (get) Token: 0x06005843 RID: 22595 RVA: 0x00161C54 File Offset: 0x0015FE54
	// (set) Token: 0x06005844 RID: 22596 RVA: 0x00161C7C File Offset: 0x0015FE7C
	public unsafe float LerpRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_LerpRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_LerpRotation)) = value;
		}
	}

	// Token: 0x17001F5D RID: 8029
	// (get) Token: 0x06005845 RID: 22597 RVA: 0x00161CA0 File Offset: 0x0015FEA0
	// (set) Token: 0x06005846 RID: 22598 RVA: 0x00161CD4 File Offset: 0x0015FED4
	public unsafe Texture MapTexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_MapTexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Texture(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_MapTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F5E RID: 8030
	// (get) Token: 0x06005847 RID: 22599 RVA: 0x00161CFC File Offset: 0x0015FEFC
	// (set) Token: 0x06005848 RID: 22600 RVA: 0x00161D24 File Offset: 0x0015FF24
	public unsafe Color SpecularColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_SpecularColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_SpecularColor)) = value;
		}
	}

	// Token: 0x17001F5F RID: 8031
	// (get) Token: 0x06005849 RID: 22601 RVA: 0x00161D48 File Offset: 0x0015FF48
	// (set) Token: 0x0600584A RID: 22602 RVA: 0x00161D70 File Offset: 0x0015FF70
	public unsafe Color EmessiveColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_EmessiveColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_EmessiveColor)) = value;
		}
	}

	// Token: 0x17001F60 RID: 8032
	// (get) Token: 0x0600584B RID: 22603 RVA: 0x00161D94 File Offset: 0x0015FF94
	// (set) Token: 0x0600584C RID: 22604 RVA: 0x00161DBC File Offset: 0x0015FFBC
	public unsafe float EmissionAmount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_EmissionAmount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_EmissionAmount)) = value;
		}
	}

	// Token: 0x17001F61 RID: 8033
	// (get) Token: 0x0600584D RID: 22605 RVA: 0x00161DE0 File Offset: 0x0015FFE0
	// (set) Token: 0x0600584E RID: 22606 RVA: 0x00161E14 File Offset: 0x00160014
	public unsafe Material ReferenceMat
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_ReferenceMat);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Material(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_ReferenceMat), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F62 RID: 8034
	// (get) Token: 0x0600584F RID: 22607 RVA: 0x00161E3C File Offset: 0x0016003C
	// (set) Token: 0x06005850 RID: 22608 RVA: 0x00161E70 File Offset: 0x00160070
	public unsafe Renderer MapPlanePrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_MapPlanePrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Renderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_MapPlanePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F63 RID: 8035
	// (get) Token: 0x06005851 RID: 22609 RVA: 0x00161E98 File Offset: 0x00160098
	// (set) Token: 0x06005852 RID: 22610 RVA: 0x00161ECC File Offset: 0x001600CC
	public unsafe RectTransform WorldSpace
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_WorldSpace);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_WorldSpace), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F64 RID: 8036
	// (get) Token: 0x06005853 RID: 22611 RVA: 0x00161EF4 File Offset: 0x001600F4
	// (set) Token: 0x06005854 RID: 22612 RVA: 0x00161F1C File Offset: 0x0016011C
	public unsafe bool DefaultRotationMode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_DefaultRotationMode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_DefaultRotationMode)) = value;
		}
	}

	// Token: 0x17001F65 RID: 8037
	// (get) Token: 0x06005855 RID: 22613 RVA: 0x00161F40 File Offset: 0x00160140
	// (set) Token: 0x06005856 RID: 22614 RVA: 0x00161F68 File Offset: 0x00160168
	public unsafe bool DefaultRotationCircle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_DefaultRotationCircle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_DefaultRotationCircle)) = value;
		}
	}

	// Token: 0x17001F66 RID: 8038
	// (get) Token: 0x06005857 RID: 22615 RVA: 0x00161F8C File Offset: 0x0016018C
	// (set) Token: 0x06005858 RID: 22616 RVA: 0x00161FB4 File Offset: 0x001601B4
	public unsafe Vector3 DefaultMapRot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_DefaultMapRot);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_DefaultMapRot)) = value;
		}
	}

	// Token: 0x17001F67 RID: 8039
	// (get) Token: 0x06005859 RID: 22617 RVA: 0x00161FD8 File Offset: 0x001601D8
	// (set) Token: 0x0600585A RID: 22618 RVA: 0x00162000 File Offset: 0x00160200
	public unsafe Vector3 MiniMapPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_MiniMapPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_MiniMapPosition)) = value;
		}
	}

	// Token: 0x17001F68 RID: 8040
	// (get) Token: 0x0600585B RID: 22619 RVA: 0x00162024 File Offset: 0x00160224
	// (set) Token: 0x0600585C RID: 22620 RVA: 0x0016204C File Offset: 0x0016024C
	public unsafe Vector3 MiniMapRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_MiniMapRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_MiniMapRotation)) = value;
		}
	}

	// Token: 0x17001F69 RID: 8041
	// (get) Token: 0x0600585D RID: 22621 RVA: 0x00162070 File Offset: 0x00160270
	// (set) Token: 0x0600585E RID: 22622 RVA: 0x00162098 File Offset: 0x00160298
	public unsafe Vector2 MiniMapSize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_MiniMapSize);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_MiniMapSize)) = value;
		}
	}

	// Token: 0x17001F6A RID: 8042
	// (get) Token: 0x0600585F RID: 22623 RVA: 0x001620BC File Offset: 0x001602BC
	// (set) Token: 0x06005860 RID: 22624 RVA: 0x001620E4 File Offset: 0x001602E4
	public unsafe float _CurMinimapZoomFactor_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr__CurMinimapZoomFactor_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr__CurMinimapZoomFactor_k__BackingField)) = value;
		}
	}

	// Token: 0x17001F6B RID: 8043
	// (get) Token: 0x06005861 RID: 22625 RVA: 0x00162108 File Offset: 0x00160308
	// (set) Token: 0x06005862 RID: 22626 RVA: 0x00162130 File Offset: 0x00160330
	public unsafe Vector3 BasePlayerIconScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_BasePlayerIconScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_BasePlayerIconScale)) = value;
		}
	}

	// Token: 0x17001F6C RID: 8044
	// (get) Token: 0x06005863 RID: 22627 RVA: 0x00162154 File Offset: 0x00160354
	// (set) Token: 0x06005864 RID: 22628 RVA: 0x0016217C File Offset: 0x0016037C
	public unsafe float BaseOrthographicSize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_BaseOrthographicSize);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_BaseOrthographicSize)) = value;
		}
	}

	// Token: 0x17001F6D RID: 8045
	// (get) Token: 0x06005865 RID: 22629 RVA: 0x001621A0 File Offset: 0x001603A0
	// (set) Token: 0x06005866 RID: 22630 RVA: 0x001621D4 File Offset: 0x001603D4
	public unsafe Pickup_Tablet_Screen_Main thisTabletScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_thisTabletScreen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Pickup_Tablet_Screen_Main(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_thisTabletScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F6E RID: 8046
	// (get) Token: 0x06005867 RID: 22631 RVA: 0x001621FC File Offset: 0x001603FC
	// (set) Token: 0x06005868 RID: 22632 RVA: 0x00162224 File Offset: 0x00160424
	public unsafe bool HasInit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_HasInit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_HasInit)) = value;
		}
	}

	// Token: 0x17001F6F RID: 8047
	// (get) Token: 0x06005869 RID: 22633 RVA: 0x00162248 File Offset: 0x00160448
	// (set) Token: 0x0600586A RID: 22634 RVA: 0x0016227C File Offset: 0x0016047C
	public unsafe Transform m_Transform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_m_Transform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr_m_Transform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001F70 RID: 8048
	// (get) Token: 0x0600586B RID: 22635 RVA: 0x001622A4 File Offset: 0x001604A4
	// (set) Token: 0x0600586C RID: 22636 RVA: 0x001622CC File Offset: 0x001604CC
	public unsafe bool _iconsNeedRefresh
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr__iconsNeedRefresh);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr__iconsNeedRefresh)) = value;
		}
	}

	// Token: 0x17001F71 RID: 8049
	// (get) Token: 0x0600586D RID: 22637 RVA: 0x001622F0 File Offset: 0x001604F0
	// (set) Token: 0x0600586E RID: 22638 RVA: 0x0016230E File Offset: 0x0016050E
	public unsafe static int TIME_BETWEEN_UI_REFRESH
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(bl_MiniMap.NativeFieldInfoPtr_TIME_BETWEEN_UI_REFRESH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(bl_MiniMap.NativeFieldInfoPtr_TIME_BETWEEN_UI_REFRESH, (void*)(&value));
		}
	}

	// Token: 0x17001F72 RID: 8050
	// (get) Token: 0x0600586F RID: 22639 RVA: 0x00162320 File Offset: 0x00160520
	// (set) Token: 0x06005870 RID: 22640 RVA: 0x00162348 File Offset: 0x00160548
	public unsafe float _lastRefreshTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr__lastRefreshTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MiniMap.NativeFieldInfoPtr__lastRefreshTime)) = value;
		}
	}

	// Token: 0x040037C3 RID: 14275
	private static readonly IntPtr NativeFieldInfoPtr__Singleton_k__BackingField;

	// Token: 0x040037C4 RID: 14276
	private static readonly IntPtr NativeFieldInfoPtr_isFullScreen;

	// Token: 0x040037C5 RID: 14277
	private static readonly IntPtr NativeFieldInfoPtr_GlobalIconProjector;

	// Token: 0x040037C6 RID: 14278
	private static readonly IntPtr NativeFieldInfoPtr__MapUIRoot_k__BackingField;

	// Token: 0x040037C7 RID: 14279
	private static readonly IntPtr NativeFieldInfoPtr__MapUIIconRoot_k__BackingField;

	// Token: 0x040037C8 RID: 14280
	private static readonly IntPtr NativeFieldInfoPtr_thisTablet;

	// Token: 0x040037C9 RID: 14281
	private static readonly IntPtr NativeFieldInfoPtr_m_Target;

	// Token: 0x040037CA RID: 14282
	private static readonly IntPtr NativeFieldInfoPtr_IconProjector;

	// Token: 0x040037CB RID: 14283
	private static readonly IntPtr NativeFieldInfoPtr_isProjectingIcons;

	// Token: 0x040037CC RID: 14284
	private static readonly IntPtr NativeFieldInfoPtr_m_Type;

	// Token: 0x040037CD RID: 14285
	private static readonly IntPtr NativeFieldInfoPtr_m_Mode;

	// Token: 0x040037CE RID: 14286
	private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

	// Token: 0x040037CF RID: 14287
	private static readonly IntPtr NativeFieldInfoPtr_maxHeight;

	// Token: 0x040037D0 RID: 14288
	private static readonly IntPtr NativeFieldInfoPtr_minHeight;

	// Token: 0x040037D1 RID: 14289
	private static readonly IntPtr NativeFieldInfoPtr_height;

	// Token: 0x040037D2 RID: 14290
	private static readonly IntPtr NativeFieldInfoPtr_useCompassRotation;

	// Token: 0x040037D3 RID: 14291
	private static readonly IntPtr NativeFieldInfoPtr_DynamicRotation;

	// Token: 0x040037D4 RID: 14292
	private static readonly IntPtr NativeFieldInfoPtr_SmoothRotation;

	// Token: 0x040037D5 RID: 14293
	private static readonly IntPtr NativeFieldInfoPtr_LerpRotation;

	// Token: 0x040037D6 RID: 14294
	private static readonly IntPtr NativeFieldInfoPtr_MapTexture;

	// Token: 0x040037D7 RID: 14295
	private static readonly IntPtr NativeFieldInfoPtr_SpecularColor;

	// Token: 0x040037D8 RID: 14296
	private static readonly IntPtr NativeFieldInfoPtr_EmessiveColor;

	// Token: 0x040037D9 RID: 14297
	private static readonly IntPtr NativeFieldInfoPtr_EmissionAmount;

	// Token: 0x040037DA RID: 14298
	private static readonly IntPtr NativeFieldInfoPtr_ReferenceMat;

	// Token: 0x040037DB RID: 14299
	private static readonly IntPtr NativeFieldInfoPtr_MapPlanePrefab;

	// Token: 0x040037DC RID: 14300
	private static readonly IntPtr NativeFieldInfoPtr_WorldSpace;

	// Token: 0x040037DD RID: 14301
	private static readonly IntPtr NativeFieldInfoPtr_DefaultRotationMode;

	// Token: 0x040037DE RID: 14302
	private static readonly IntPtr NativeFieldInfoPtr_DefaultRotationCircle;

	// Token: 0x040037DF RID: 14303
	private static readonly IntPtr NativeFieldInfoPtr_DefaultMapRot;

	// Token: 0x040037E0 RID: 14304
	private static readonly IntPtr NativeFieldInfoPtr_MiniMapPosition;

	// Token: 0x040037E1 RID: 14305
	private static readonly IntPtr NativeFieldInfoPtr_MiniMapRotation;

	// Token: 0x040037E2 RID: 14306
	private static readonly IntPtr NativeFieldInfoPtr_MiniMapSize;

	// Token: 0x040037E3 RID: 14307
	private static readonly IntPtr NativeFieldInfoPtr__CurMinimapZoomFactor_k__BackingField;

	// Token: 0x040037E4 RID: 14308
	private static readonly IntPtr NativeFieldInfoPtr_BasePlayerIconScale;

	// Token: 0x040037E5 RID: 14309
	private static readonly IntPtr NativeFieldInfoPtr_BaseOrthographicSize;

	// Token: 0x040037E6 RID: 14310
	private static readonly IntPtr NativeFieldInfoPtr_thisTabletScreen;

	// Token: 0x040037E7 RID: 14311
	private static readonly IntPtr NativeFieldInfoPtr_HasInit;

	// Token: 0x040037E8 RID: 14312
	private static readonly IntPtr NativeFieldInfoPtr_m_Transform;

	// Token: 0x040037E9 RID: 14313
	private static readonly IntPtr NativeFieldInfoPtr__iconsNeedRefresh;

	// Token: 0x040037EA RID: 14314
	private static readonly IntPtr NativeFieldInfoPtr_TIME_BETWEEN_UI_REFRESH;

	// Token: 0x040037EB RID: 14315
	private static readonly IntPtr NativeFieldInfoPtr__lastRefreshTime;

	// Token: 0x040037EC RID: 14316
	private static readonly IntPtr NativeMethodInfoPtr_get_Singleton_Public_Static_get_bl_MiniMap_0;

	// Token: 0x040037ED RID: 14317
	private static readonly IntPtr NativeMethodInfoPtr_set_Singleton_Private_Static_set_Void_bl_MiniMap_0;

	// Token: 0x040037EE RID: 14318
	private static readonly IntPtr NativeMethodInfoPtr_get_MapUIRoot_Public_Static_get_RectTransform_0;

	// Token: 0x040037EF RID: 14319
	private static readonly IntPtr NativeMethodInfoPtr_set_MapUIRoot_Private_Static_set_Void_RectTransform_0;

	// Token: 0x040037F0 RID: 14320
	private static readonly IntPtr NativeMethodInfoPtr_get_MapUIIconRoot_Public_Static_get_RectTransform_0;

	// Token: 0x040037F1 RID: 14321
	private static readonly IntPtr NativeMethodInfoPtr_set_MapUIIconRoot_Private_Static_set_Void_RectTransform_0;

	// Token: 0x040037F2 RID: 14322
	private static readonly IntPtr NativeMethodInfoPtr_get_CurMinimapZoomFactor_Public_get_Single_0;

	// Token: 0x040037F3 RID: 14323
	private static readonly IntPtr NativeMethodInfoPtr_set_CurMinimapZoomFactor_Private_set_Void_Single_0;

	// Token: 0x040037F4 RID: 14324
	private static readonly IntPtr NativeMethodInfoPtr_TryCreateSingleton_Public_Static_Void_bl_MiniMap_Pickup_Tablet_Canvas_0;

	// Token: 0x040037F5 RID: 14325
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040037F6 RID: 14326
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x040037F7 RID: 14327
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040037F8 RID: 14328
	private static readonly IntPtr NativeMethodInfoPtr_InitializeToTablet_Public_Void_Pickup_Tablet_Canvas_0;

	// Token: 0x040037F9 RID: 14329
	private static readonly IntPtr NativeMethodInfoPtr_SwapToTablet_Public_Void_Pickup_Tablet_Canvas_0;

	// Token: 0x040037FA RID: 14330
	private static readonly IntPtr NativeMethodInfoPtr_CreateMapPlane_Private_Void_0;

	// Token: 0x040037FB RID: 14331
	private static readonly IntPtr NativeMethodInfoPtr_ConfigureCamera3D_Public_Void_0;

	// Token: 0x040037FC RID: 14332
	private static readonly IntPtr NativeMethodInfoPtr_ShouldProjectIcons_Private_Boolean_0;

	// Token: 0x040037FD RID: 14333
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerHealthEventOccurred_Private_Void_WarPlayerScript_0;

	// Token: 0x040037FE RID: 14334
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040037FF RID: 14335
	private static readonly IntPtr NativeMethodInfoPtr_PositionControl_Private_Void_Boolean_0;

	// Token: 0x04003800 RID: 14336
	private static readonly IntPtr NativeMethodInfoPtr_SnapMinimapToPosition_Public_Void_0;

	// Token: 0x04003801 RID: 14337
	private static readonly IntPtr NativeMethodInfoPtr_RotationControl_Private_Void_0;

	// Token: 0x04003802 RID: 14338
	private static readonly IntPtr NativeMethodInfoPtr_CreateMaterial_Public_Material_0;

	// Token: 0x04003803 RID: 14339
	private static readonly IntPtr NativeMethodInfoPtr_ResetMapRotation_Private_Void_0;

	// Token: 0x04003804 RID: 14340
	private static readonly IntPtr NativeMethodInfoPtr_RotationMap_Public_Void_Boolean_0;

	// Token: 0x04003805 RID: 14341
	private static readonly IntPtr NativeMethodInfoPtr_GetMiniMapSize_Private_Void_0;

	// Token: 0x04003806 RID: 14342
	private static readonly IntPtr NativeMethodInfoPtr_ZoomMinimap_Public_Void_Single_0;

	// Token: 0x04003807 RID: 14343
	private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Transform_0;

	// Token: 0x04003808 RID: 14344
	private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0;

	// Token: 0x04003809 RID: 14345
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200044F RID: 1103
	[Serializable]
	public enum RenderType
	{
		// Token: 0x0400380B RID: 14347
		RealTime,
		// Token: 0x0400380C RID: 14348
		Picture
	}

	// Token: 0x02000450 RID: 1104
	[Serializable]
	public enum RenderMode
	{
		// Token: 0x0400380E RID: 14350
		Mode2D,
		// Token: 0x0400380F RID: 14351
		Mode3D
	}
}
