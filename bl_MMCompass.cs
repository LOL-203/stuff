using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Onward.Tablet;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000456 RID: 1110
public class bl_MMCompass : MonoBehaviour
{
	// Token: 0x0600590D RID: 22797 RVA: 0x00164820 File Offset: 0x00162A20
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MMCompass.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600590E RID: 22798 RVA: 0x00164864 File Offset: 0x00162A64
	[CallerCount(0)]
	public unsafe void OnTabletScreenInitialized(Pickup_Tablet tablet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tablet);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MMCompass.NativeMethodInfoPtr_OnTabletScreenInitialized_Public_Void_Pickup_Tablet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600590F RID: 22799 RVA: 0x001648C0 File Offset: 0x00162AC0
	[CallerCount(0)]
	public unsafe void OnTabletScreenDeinitialized(Pickup_Tablet tablet)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tablet);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MMCompass.NativeMethodInfoPtr_OnTabletScreenDeinitialized_Public_Void_Pickup_Tablet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005910 RID: 22800 RVA: 0x0016491C File Offset: 0x00162B1C
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MMCompass.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005911 RID: 22801 RVA: 0x00164960 File Offset: 0x00162B60
	[CallerCount(0)]
	public unsafe Vector2 GetBearingAnchoredPosition(int grade, int bearing, [Optional] float multiplier)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref grade;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bearing;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiplier;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(bl_MMCompass.NativeMethodInfoPtr_GetBearingAnchoredPosition_Private_Vector2_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06005912 RID: 22802 RVA: 0x001649E8 File Offset: 0x00162BE8
	[CallerCount(0)]
	public unsafe int GradeForBearing(int northGrade, int bearingAngle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref northGrade;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bearingAngle;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(bl_MMCompass.NativeMethodInfoPtr_GradeForBearing_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06005913 RID: 22803 RVA: 0x00164A60 File Offset: 0x00162C60
	[CallerCount(0)]
	public unsafe bl_MMCompass() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(bl_MMCompass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005914 RID: 22804 RVA: 0x00164AAC File Offset: 0x00162CAC
	// Note: this type is marked as 'beforefieldinit'.
	static bl_MMCompass()
	{
		Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "bl_MMCompass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr);
		bl_MMCompass.NativeFieldInfoPtr_CurrentDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "CurrentDegrees");
		bl_MMCompass.NativeFieldInfoPtr_UseMaterialOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "UseMaterialOffsets");
		bl_MMCompass.NativeFieldInfoPtr_OffsetMaterialRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "OffsetMaterialRenderer");
		bl_MMCompass.NativeFieldInfoPtr_FlipUVs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "FlipUVs");
		bl_MMCompass.NativeFieldInfoPtr_TabletScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "TabletScreen");
		bl_MMCompass.NativeFieldInfoPtr_ForwardRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "ForwardRef");
		bl_MMCompass.NativeFieldInfoPtr_WatchTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "WatchTarget");
		bl_MMCompass.NativeFieldInfoPtr_DegreeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "DegreeOffset");
		bl_MMCompass.NativeFieldInfoPtr_CompassRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "CompassRoot");
		bl_MMCompass.NativeFieldInfoPtr_WCompassRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "WCompassRoot");
		bl_MMCompass.NativeFieldInfoPtr_North = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "North");
		bl_MMCompass.NativeFieldInfoPtr_Thirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "Thirty");
		bl_MMCompass.NativeFieldInfoPtr_Sixty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "Sixty");
		bl_MMCompass.NativeFieldInfoPtr_Ninety = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "Ninety");
		bl_MMCompass.NativeFieldInfoPtr_OneHundredTwenty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "OneHundredTwenty");
		bl_MMCompass.NativeFieldInfoPtr_OneHundredFifty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "OneHundredFifty");
		bl_MMCompass.NativeFieldInfoPtr_OneHundredEighty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "OneHundredEighty");
		bl_MMCompass.NativeFieldInfoPtr_TwoHundredTen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "TwoHundredTen");
		bl_MMCompass.NativeFieldInfoPtr_TwoHundredFourty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "TwoHundredFourty");
		bl_MMCompass.NativeFieldInfoPtr_TwoHundredSeventy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "TwoHundredSeventy");
		bl_MMCompass.NativeFieldInfoPtr_ThreeHundred = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "ThreeHundred");
		bl_MMCompass.NativeFieldInfoPtr_ThreeHundredThirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "ThreeHundredThirty");
		bl_MMCompass.NativeFieldInfoPtr_WNorth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "WNorth");
		bl_MMCompass.NativeFieldInfoPtr_W45 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "W45");
		bl_MMCompass.NativeFieldInfoPtr_WNinety = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "WNinety");
		bl_MMCompass.NativeFieldInfoPtr_W135 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "W135");
		bl_MMCompass.NativeFieldInfoPtr_WOneHundredEighty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "WOneHundredEighty");
		bl_MMCompass.NativeFieldInfoPtr_W225 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "W225");
		bl_MMCompass.NativeFieldInfoPtr_WTwoHundredSeventy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "WTwoHundredSeventy");
		bl_MMCompass.NativeFieldInfoPtr_W315 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "W315");
		bl_MMCompass.NativeFieldInfoPtr_Grade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "Grade");
		bl_MMCompass.NativeFieldInfoPtr_ScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "ScaleMultiplier");
		bl_MMCompass.NativeFieldInfoPtr_offsetTextureKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "offsetTextureKeyword");
		bl_MMCompass.NativeFieldInfoPtr_numericTextureWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "numericTextureWidth");
		bl_MMCompass.NativeFieldInfoPtr_offsetPerDegree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, "offsetPerDegree");
		bl_MMCompass.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, 100670313);
		bl_MMCompass.NativeMethodInfoPtr_OnTabletScreenInitialized_Public_Void_Pickup_Tablet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, 100670314);
		bl_MMCompass.NativeMethodInfoPtr_OnTabletScreenDeinitialized_Public_Void_Pickup_Tablet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, 100670315);
		bl_MMCompass.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, 100670316);
		bl_MMCompass.NativeMethodInfoPtr_GetBearingAnchoredPosition_Private_Vector2_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, 100670317);
		bl_MMCompass.NativeMethodInfoPtr_GradeForBearing_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, 100670318);
		bl_MMCompass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr, 100670319);
	}

	// Token: 0x06005915 RID: 22805 RVA: 0x0000210C File Offset: 0x0000030C
	public bl_MMCompass(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001FB9 RID: 8121
	// (get) Token: 0x06005916 RID: 22806 RVA: 0x00164E24 File Offset: 0x00163024
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<bl_MMCompass>.NativeClassPtr));
		}
	}

	// Token: 0x17001FBA RID: 8122
	// (get) Token: 0x06005917 RID: 22807 RVA: 0x00164E38 File Offset: 0x00163038
	// (set) Token: 0x06005918 RID: 22808 RVA: 0x00164E60 File Offset: 0x00163060
	public unsafe float CurrentDegrees
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_CurrentDegrees);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_CurrentDegrees)) = value;
		}
	}

	// Token: 0x17001FBB RID: 8123
	// (get) Token: 0x06005919 RID: 22809 RVA: 0x00164E84 File Offset: 0x00163084
	// (set) Token: 0x0600591A RID: 22810 RVA: 0x00164EAC File Offset: 0x001630AC
	public unsafe bool UseMaterialOffsets
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_UseMaterialOffsets);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_UseMaterialOffsets)) = value;
		}
	}

	// Token: 0x17001FBC RID: 8124
	// (get) Token: 0x0600591B RID: 22811 RVA: 0x00164ED0 File Offset: 0x001630D0
	// (set) Token: 0x0600591C RID: 22812 RVA: 0x00164F04 File Offset: 0x00163104
	public unsafe Renderer OffsetMaterialRenderer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_OffsetMaterialRenderer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Renderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_OffsetMaterialRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FBD RID: 8125
	// (get) Token: 0x0600591D RID: 22813 RVA: 0x00164F2C File Offset: 0x0016312C
	// (set) Token: 0x0600591E RID: 22814 RVA: 0x00164F54 File Offset: 0x00163154
	public unsafe bool FlipUVs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_FlipUVs);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_FlipUVs)) = value;
		}
	}

	// Token: 0x17001FBE RID: 8126
	// (get) Token: 0x0600591F RID: 22815 RVA: 0x00164F78 File Offset: 0x00163178
	// (set) Token: 0x06005920 RID: 22816 RVA: 0x00164FAC File Offset: 0x001631AC
	public unsafe Pickup_Tablet_Screen TabletScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_TabletScreen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Pickup_Tablet_Screen(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_TabletScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FBF RID: 8127
	// (get) Token: 0x06005921 RID: 22817 RVA: 0x00164FD4 File Offset: 0x001631D4
	// (set) Token: 0x06005922 RID: 22818 RVA: 0x00165008 File Offset: 0x00163208
	public unsafe Transform ForwardRef
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_ForwardRef);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_ForwardRef), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FC0 RID: 8128
	// (get) Token: 0x06005923 RID: 22819 RVA: 0x00165030 File Offset: 0x00163230
	// (set) Token: 0x06005924 RID: 22820 RVA: 0x00165064 File Offset: 0x00163264
	public unsafe Transform WatchTarget
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_WatchTarget);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_WatchTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FC1 RID: 8129
	// (get) Token: 0x06005925 RID: 22821 RVA: 0x0016508C File Offset: 0x0016328C
	// (set) Token: 0x06005926 RID: 22822 RVA: 0x001650B4 File Offset: 0x001632B4
	public unsafe float DegreeOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_DegreeOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_DegreeOffset)) = value;
		}
	}

	// Token: 0x17001FC2 RID: 8130
	// (get) Token: 0x06005927 RID: 22823 RVA: 0x001650D8 File Offset: 0x001632D8
	// (set) Token: 0x06005928 RID: 22824 RVA: 0x0016510C File Offset: 0x0016330C
	public unsafe RectTransform CompassRoot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_CompassRoot);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_CompassRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FC3 RID: 8131
	// (get) Token: 0x06005929 RID: 22825 RVA: 0x00165134 File Offset: 0x00163334
	// (set) Token: 0x0600592A RID: 22826 RVA: 0x00165168 File Offset: 0x00163368
	public unsafe RectTransform WCompassRoot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_WCompassRoot);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_WCompassRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FC4 RID: 8132
	// (get) Token: 0x0600592B RID: 22827 RVA: 0x00165190 File Offset: 0x00163390
	// (set) Token: 0x0600592C RID: 22828 RVA: 0x001651C4 File Offset: 0x001633C4
	public unsafe RectTransform North
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_North);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_North), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FC5 RID: 8133
	// (get) Token: 0x0600592D RID: 22829 RVA: 0x001651EC File Offset: 0x001633EC
	// (set) Token: 0x0600592E RID: 22830 RVA: 0x00165220 File Offset: 0x00163420
	public unsafe RectTransform Thirty
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_Thirty);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_Thirty), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FC6 RID: 8134
	// (get) Token: 0x0600592F RID: 22831 RVA: 0x00165248 File Offset: 0x00163448
	// (set) Token: 0x06005930 RID: 22832 RVA: 0x0016527C File Offset: 0x0016347C
	public unsafe RectTransform Sixty
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_Sixty);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_Sixty), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FC7 RID: 8135
	// (get) Token: 0x06005931 RID: 22833 RVA: 0x001652A4 File Offset: 0x001634A4
	// (set) Token: 0x06005932 RID: 22834 RVA: 0x001652D8 File Offset: 0x001634D8
	public unsafe RectTransform Ninety
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_Ninety);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_Ninety), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FC8 RID: 8136
	// (get) Token: 0x06005933 RID: 22835 RVA: 0x00165300 File Offset: 0x00163500
	// (set) Token: 0x06005934 RID: 22836 RVA: 0x00165334 File Offset: 0x00163534
	public unsafe RectTransform OneHundredTwenty
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_OneHundredTwenty);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_OneHundredTwenty), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FC9 RID: 8137
	// (get) Token: 0x06005935 RID: 22837 RVA: 0x0016535C File Offset: 0x0016355C
	// (set) Token: 0x06005936 RID: 22838 RVA: 0x00165390 File Offset: 0x00163590
	public unsafe RectTransform OneHundredFifty
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_OneHundredFifty);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_OneHundredFifty), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FCA RID: 8138
	// (get) Token: 0x06005937 RID: 22839 RVA: 0x001653B8 File Offset: 0x001635B8
	// (set) Token: 0x06005938 RID: 22840 RVA: 0x001653EC File Offset: 0x001635EC
	public unsafe RectTransform OneHundredEighty
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_OneHundredEighty);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_OneHundredEighty), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FCB RID: 8139
	// (get) Token: 0x06005939 RID: 22841 RVA: 0x00165414 File Offset: 0x00163614
	// (set) Token: 0x0600593A RID: 22842 RVA: 0x00165448 File Offset: 0x00163648
	public unsafe RectTransform TwoHundredTen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_TwoHundredTen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_TwoHundredTen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FCC RID: 8140
	// (get) Token: 0x0600593B RID: 22843 RVA: 0x00165470 File Offset: 0x00163670
	// (set) Token: 0x0600593C RID: 22844 RVA: 0x001654A4 File Offset: 0x001636A4
	public unsafe RectTransform TwoHundredFourty
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_TwoHundredFourty);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_TwoHundredFourty), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FCD RID: 8141
	// (get) Token: 0x0600593D RID: 22845 RVA: 0x001654CC File Offset: 0x001636CC
	// (set) Token: 0x0600593E RID: 22846 RVA: 0x00165500 File Offset: 0x00163700
	public unsafe RectTransform TwoHundredSeventy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_TwoHundredSeventy);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_TwoHundredSeventy), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FCE RID: 8142
	// (get) Token: 0x0600593F RID: 22847 RVA: 0x00165528 File Offset: 0x00163728
	// (set) Token: 0x06005940 RID: 22848 RVA: 0x0016555C File Offset: 0x0016375C
	public unsafe RectTransform ThreeHundred
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_ThreeHundred);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_ThreeHundred), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FCF RID: 8143
	// (get) Token: 0x06005941 RID: 22849 RVA: 0x00165584 File Offset: 0x00163784
	// (set) Token: 0x06005942 RID: 22850 RVA: 0x001655B8 File Offset: 0x001637B8
	public unsafe RectTransform ThreeHundredThirty
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_ThreeHundredThirty);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_ThreeHundredThirty), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FD0 RID: 8144
	// (get) Token: 0x06005943 RID: 22851 RVA: 0x001655E0 File Offset: 0x001637E0
	// (set) Token: 0x06005944 RID: 22852 RVA: 0x00165614 File Offset: 0x00163814
	public unsafe RectTransform WNorth
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_WNorth);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_WNorth), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FD1 RID: 8145
	// (get) Token: 0x06005945 RID: 22853 RVA: 0x0016563C File Offset: 0x0016383C
	// (set) Token: 0x06005946 RID: 22854 RVA: 0x00165670 File Offset: 0x00163870
	public unsafe RectTransform W45
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_W45);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_W45), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FD2 RID: 8146
	// (get) Token: 0x06005947 RID: 22855 RVA: 0x00165698 File Offset: 0x00163898
	// (set) Token: 0x06005948 RID: 22856 RVA: 0x001656CC File Offset: 0x001638CC
	public unsafe RectTransform WNinety
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_WNinety);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_WNinety), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FD3 RID: 8147
	// (get) Token: 0x06005949 RID: 22857 RVA: 0x001656F4 File Offset: 0x001638F4
	// (set) Token: 0x0600594A RID: 22858 RVA: 0x00165728 File Offset: 0x00163928
	public unsafe RectTransform W135
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_W135);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_W135), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FD4 RID: 8148
	// (get) Token: 0x0600594B RID: 22859 RVA: 0x00165750 File Offset: 0x00163950
	// (set) Token: 0x0600594C RID: 22860 RVA: 0x00165784 File Offset: 0x00163984
	public unsafe RectTransform WOneHundredEighty
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_WOneHundredEighty);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_WOneHundredEighty), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FD5 RID: 8149
	// (get) Token: 0x0600594D RID: 22861 RVA: 0x001657AC File Offset: 0x001639AC
	// (set) Token: 0x0600594E RID: 22862 RVA: 0x001657E0 File Offset: 0x001639E0
	public unsafe RectTransform W225
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_W225);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_W225), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FD6 RID: 8150
	// (get) Token: 0x0600594F RID: 22863 RVA: 0x00165808 File Offset: 0x00163A08
	// (set) Token: 0x06005950 RID: 22864 RVA: 0x0016583C File Offset: 0x00163A3C
	public unsafe RectTransform WTwoHundredSeventy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_WTwoHundredSeventy);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_WTwoHundredSeventy), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FD7 RID: 8151
	// (get) Token: 0x06005951 RID: 22865 RVA: 0x00165864 File Offset: 0x00163A64
	// (set) Token: 0x06005952 RID: 22866 RVA: 0x00165898 File Offset: 0x00163A98
	public unsafe RectTransform W315
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_W315);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RectTransform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_W315), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001FD8 RID: 8152
	// (get) Token: 0x06005953 RID: 22867 RVA: 0x001658C0 File Offset: 0x00163AC0
	// (set) Token: 0x06005954 RID: 22868 RVA: 0x001658E8 File Offset: 0x00163AE8
	public unsafe int Grade
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_Grade);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_Grade)) = value;
		}
	}

	// Token: 0x17001FD9 RID: 8153
	// (get) Token: 0x06005955 RID: 22869 RVA: 0x0016590C File Offset: 0x00163B0C
	// (set) Token: 0x06005956 RID: 22870 RVA: 0x00165934 File Offset: 0x00163B34
	public unsafe float ScaleMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_ScaleMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_ScaleMultiplier)) = value;
		}
	}

	// Token: 0x17001FDA RID: 8154
	// (get) Token: 0x06005957 RID: 22871 RVA: 0x00165958 File Offset: 0x00163B58
	// (set) Token: 0x06005958 RID: 22872 RVA: 0x00165978 File Offset: 0x00163B78
	public unsafe static string offsetTextureKeyword
	{
		get
		{
			IntPtr il2CppString;
			IL2CPP.il2cpp_field_static_get_value(bl_MMCompass.NativeFieldInfoPtr_offsetTextureKeyword, (void*)(&il2CppString));
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(bl_MMCompass.NativeFieldInfoPtr_offsetTextureKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001FDB RID: 8155
	// (get) Token: 0x06005959 RID: 22873 RVA: 0x00165990 File Offset: 0x00163B90
	// (set) Token: 0x0600595A RID: 22874 RVA: 0x001659AE File Offset: 0x00163BAE
	public unsafe static int numericTextureWidth
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(bl_MMCompass.NativeFieldInfoPtr_numericTextureWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(bl_MMCompass.NativeFieldInfoPtr_numericTextureWidth, (void*)(&value));
		}
	}

	// Token: 0x17001FDC RID: 8156
	// (get) Token: 0x0600595B RID: 22875 RVA: 0x001659C0 File Offset: 0x00163BC0
	// (set) Token: 0x0600595C RID: 22876 RVA: 0x001659E8 File Offset: 0x00163BE8
	public unsafe float offsetPerDegree
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_offsetPerDegree);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(bl_MMCompass.NativeFieldInfoPtr_offsetPerDegree)) = value;
		}
	}

	// Token: 0x04003869 RID: 14441
	private static readonly IntPtr NativeFieldInfoPtr_CurrentDegrees;

	// Token: 0x0400386A RID: 14442
	private static readonly IntPtr NativeFieldInfoPtr_UseMaterialOffsets;

	// Token: 0x0400386B RID: 14443
	private static readonly IntPtr NativeFieldInfoPtr_OffsetMaterialRenderer;

	// Token: 0x0400386C RID: 14444
	private static readonly IntPtr NativeFieldInfoPtr_FlipUVs;

	// Token: 0x0400386D RID: 14445
	private static readonly IntPtr NativeFieldInfoPtr_TabletScreen;

	// Token: 0x0400386E RID: 14446
	private static readonly IntPtr NativeFieldInfoPtr_ForwardRef;

	// Token: 0x0400386F RID: 14447
	private static readonly IntPtr NativeFieldInfoPtr_WatchTarget;

	// Token: 0x04003870 RID: 14448
	private static readonly IntPtr NativeFieldInfoPtr_DegreeOffset;

	// Token: 0x04003871 RID: 14449
	private static readonly IntPtr NativeFieldInfoPtr_CompassRoot;

	// Token: 0x04003872 RID: 14450
	private static readonly IntPtr NativeFieldInfoPtr_WCompassRoot;

	// Token: 0x04003873 RID: 14451
	private static readonly IntPtr NativeFieldInfoPtr_North;

	// Token: 0x04003874 RID: 14452
	private static readonly IntPtr NativeFieldInfoPtr_Thirty;

	// Token: 0x04003875 RID: 14453
	private static readonly IntPtr NativeFieldInfoPtr_Sixty;

	// Token: 0x04003876 RID: 14454
	private static readonly IntPtr NativeFieldInfoPtr_Ninety;

	// Token: 0x04003877 RID: 14455
	private static readonly IntPtr NativeFieldInfoPtr_OneHundredTwenty;

	// Token: 0x04003878 RID: 14456
	private static readonly IntPtr NativeFieldInfoPtr_OneHundredFifty;

	// Token: 0x04003879 RID: 14457
	private static readonly IntPtr NativeFieldInfoPtr_OneHundredEighty;

	// Token: 0x0400387A RID: 14458
	private static readonly IntPtr NativeFieldInfoPtr_TwoHundredTen;

	// Token: 0x0400387B RID: 14459
	private static readonly IntPtr NativeFieldInfoPtr_TwoHundredFourty;

	// Token: 0x0400387C RID: 14460
	private static readonly IntPtr NativeFieldInfoPtr_TwoHundredSeventy;

	// Token: 0x0400387D RID: 14461
	private static readonly IntPtr NativeFieldInfoPtr_ThreeHundred;

	// Token: 0x0400387E RID: 14462
	private static readonly IntPtr NativeFieldInfoPtr_ThreeHundredThirty;

	// Token: 0x0400387F RID: 14463
	private static readonly IntPtr NativeFieldInfoPtr_WNorth;

	// Token: 0x04003880 RID: 14464
	private static readonly IntPtr NativeFieldInfoPtr_W45;

	// Token: 0x04003881 RID: 14465
	private static readonly IntPtr NativeFieldInfoPtr_WNinety;

	// Token: 0x04003882 RID: 14466
	private static readonly IntPtr NativeFieldInfoPtr_W135;

	// Token: 0x04003883 RID: 14467
	private static readonly IntPtr NativeFieldInfoPtr_WOneHundredEighty;

	// Token: 0x04003884 RID: 14468
	private static readonly IntPtr NativeFieldInfoPtr_W225;

	// Token: 0x04003885 RID: 14469
	private static readonly IntPtr NativeFieldInfoPtr_WTwoHundredSeventy;

	// Token: 0x04003886 RID: 14470
	private static readonly IntPtr NativeFieldInfoPtr_W315;

	// Token: 0x04003887 RID: 14471
	private static readonly IntPtr NativeFieldInfoPtr_Grade;

	// Token: 0x04003888 RID: 14472
	private static readonly IntPtr NativeFieldInfoPtr_ScaleMultiplier;

	// Token: 0x04003889 RID: 14473
	private static readonly IntPtr NativeFieldInfoPtr_offsetTextureKeyword;

	// Token: 0x0400388A RID: 14474
	private static readonly IntPtr NativeFieldInfoPtr_numericTextureWidth;

	// Token: 0x0400388B RID: 14475
	private static readonly IntPtr NativeFieldInfoPtr_offsetPerDegree;

	// Token: 0x0400388C RID: 14476
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400388D RID: 14477
	private static readonly IntPtr NativeMethodInfoPtr_OnTabletScreenInitialized_Public_Void_Pickup_Tablet_0;

	// Token: 0x0400388E RID: 14478
	private static readonly IntPtr NativeMethodInfoPtr_OnTabletScreenDeinitialized_Public_Void_Pickup_Tablet_0;

	// Token: 0x0400388F RID: 14479
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04003890 RID: 14480
	private static readonly IntPtr NativeMethodInfoPtr_GetBearingAnchoredPosition_Private_Vector2_Int32_Int32_Single_0;

	// Token: 0x04003891 RID: 14481
	private static readonly IntPtr NativeMethodInfoPtr_GradeForBearing_Private_Int32_Int32_Int32_0;

	// Token: 0x04003892 RID: 14482
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
