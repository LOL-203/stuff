using System;
using DPI.Basketball;
using DPI.Killhouse;
using Il2CppSystem;
using TMPro;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000160 RID: 352
public class BasketballGoalIndicatorLight : KillhouseIndicatorLight
{
	// Token: 0x060017D9 RID: 6105 RVA: 0x0005FD94 File Offset: 0x0005DF94
	[CallerCount(0)]
	public new unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasketballGoalIndicatorLight.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017DA RID: 6106 RVA: 0x0005FDE4 File Offset: 0x0005DFE4
	[CallerCount(0)]
	public new unsafe void Deinitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasketballGoalIndicatorLight.NativeMethodInfoPtr_Deinitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017DB RID: 6107 RVA: 0x0005FE34 File Offset: 0x0005E034
	[CallerCount(0)]
	public new unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasketballGoalIndicatorLight.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017DC RID: 6108 RVA: 0x0005FE84 File Offset: 0x0005E084
	[CallerCount(0)]
	public new unsafe void RefreshColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasketballGoalIndicatorLight.NativeMethodInfoPtr_RefreshColor_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017DD RID: 6109 RVA: 0x0005FED4 File Offset: 0x0005E0D4
	[CallerCount(0)]
	public new unsafe void RefreshCaption()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasketballGoalIndicatorLight.NativeMethodInfoPtr_RefreshCaption_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017DE RID: 6110 RVA: 0x0005FF24 File Offset: 0x0005E124
	[CallerCount(0)]
	public unsafe void OnInterludeChange(bool interlude)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref interlude;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasketballGoalIndicatorLight.NativeMethodInfoPtr_OnInterludeChange_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017DF RID: 6111 RVA: 0x0005FF78 File Offset: 0x0005E178
	[CallerCount(0)]
	public unsafe float AddHue(float add, float hue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref add;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hue;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BasketballGoalIndicatorLight.NativeMethodInfoPtr_AddHue_Private_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060017E0 RID: 6112 RVA: 0x0005FFF0 File Offset: 0x0005E1F0
	[CallerCount(0)]
	public unsafe void UpdateScorePulse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasketballGoalIndicatorLight.NativeMethodInfoPtr_UpdateScorePulse_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017E1 RID: 6113 RVA: 0x00060034 File Offset: 0x0005E234
	[CallerCount(0)]
	public unsafe void UpdateInterludeStrobe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasketballGoalIndicatorLight.NativeMethodInfoPtr_UpdateInterludeStrobe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017E2 RID: 6114 RVA: 0x00060078 File Offset: 0x0005E278
	[CallerCount(0)]
	public unsafe void SetFlashingState(BasketballGoalIndicatorLight.FlashingState newState, bool force = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref newState;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasketballGoalIndicatorLight.NativeMethodInfoPtr_SetFlashingState_Public_Void_FlashingState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017E3 RID: 6115 RVA: 0x000600E0 File Offset: 0x0005E2E0
	[CallerCount(0)]
	public unsafe void RestoreBacklight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasketballGoalIndicatorLight.NativeMethodInfoPtr_RestoreBacklight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017E4 RID: 6116 RVA: 0x00060124 File Offset: 0x0005E324
	[CallerCount(0)]
	public unsafe void ToggleBacklight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasketballGoalIndicatorLight.NativeMethodInfoPtr_ToggleBacklight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017E5 RID: 6117 RVA: 0x00060168 File Offset: 0x0005E368
	[CallerCount(0)]
	public unsafe void SetBacklight(bool selected)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref selected;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasketballGoalIndicatorLight.NativeMethodInfoPtr_SetBacklight_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017E6 RID: 6118 RVA: 0x000601BC File Offset: 0x0005E3BC
	[CallerCount(0)]
	public unsafe void RestoreSafetyDisclaimer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasketballGoalIndicatorLight.NativeMethodInfoPtr_RestoreSafetyDisclaimer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017E7 RID: 6119 RVA: 0x00060200 File Offset: 0x0005E400
	[CallerCount(0)]
	public unsafe void SetDisclaimerToInterludeTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasketballGoalIndicatorLight.NativeMethodInfoPtr_SetDisclaimerToInterludeTime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017E8 RID: 6120 RVA: 0x00060244 File Offset: 0x0005E444
	[CallerCount(0)]
	public unsafe BasketballGoalIndicatorLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasketballGoalIndicatorLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017E9 RID: 6121 RVA: 0x00060290 File Offset: 0x0005E490
	// Note: this type is marked as 'beforefieldinit'.
	static BasketballGoalIndicatorLight()
	{
		Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BasketballGoalIndicatorLight");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr);
		BasketballGoalIndicatorLight.NativeFieldInfoPtr_SAFETY_TEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, "SAFETY_TEXT");
		BasketballGoalIndicatorLight.NativeFieldInfoPtr_Court = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, "Court");
		BasketballGoalIndicatorLight.NativeFieldInfoPtr_Disclaimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, "Disclaimer");
		BasketballGoalIndicatorLight.NativeFieldInfoPtr_ColorOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, "ColorOffset");
		BasketballGoalIndicatorLight.NativeFieldInfoPtr_ScoreFlashAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, "ScoreFlashAmount");
		BasketballGoalIndicatorLight.NativeFieldInfoPtr_ScoreFlashDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, "ScoreFlashDelay");
		BasketballGoalIndicatorLight.NativeFieldInfoPtr_InterludeFlashDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, "InterludeFlashDelay");
		BasketballGoalIndicatorLight.NativeFieldInfoPtr__selectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, "_selectedColor");
		BasketballGoalIndicatorLight.NativeFieldInfoPtr__complimentaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, "_complimentaryColor");
		BasketballGoalIndicatorLight.NativeFieldInfoPtr__usingSelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, "_usingSelectedColor");
		BasketballGoalIndicatorLight.NativeFieldInfoPtr__flashingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, "_flashingState");
		BasketballGoalIndicatorLight.NativeFieldInfoPtr__flashTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, "_flashTimer");
		BasketballGoalIndicatorLight.NativeFieldInfoPtr__flashCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, "_flashCounter");
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665210);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_Deinitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665211);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665212);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_RefreshColor_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665213);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_RefreshCaption_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665214);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_OnInterludeChange_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665215);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_AddHue_Private_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665216);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_UpdateScorePulse_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665217);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_UpdateInterludeStrobe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665218);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_SetFlashingState_Public_Void_FlashingState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665219);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_RestoreBacklight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665220);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_ToggleBacklight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665221);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_SetBacklight_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665222);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_RestoreSafetyDisclaimer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665223);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr_SetDisclaimerToInterludeTime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665224);
		BasketballGoalIndicatorLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr, 100665225);
	}

	// Token: 0x060017EA RID: 6122 RVA: 0x00060504 File Offset: 0x0005E704
	public BasketballGoalIndicatorLight(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000839 RID: 2105
	// (get) Token: 0x060017EB RID: 6123 RVA: 0x0006050D File Offset: 0x0005E70D
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BasketballGoalIndicatorLight>.NativeClassPtr));
		}
	}

	// Token: 0x1700083A RID: 2106
	// (get) Token: 0x060017EC RID: 6124 RVA: 0x00060520 File Offset: 0x0005E720
	// (set) Token: 0x060017ED RID: 6125 RVA: 0x00060549 File Offset: 0x0005E749
	public unsafe string SAFETY_TEXT
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_SAFETY_TEXT);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_SAFETY_TEXT), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700083B RID: 2107
	// (get) Token: 0x060017EE RID: 6126 RVA: 0x00060570 File Offset: 0x0005E770
	// (set) Token: 0x060017EF RID: 6127 RVA: 0x000605A4 File Offset: 0x0005E7A4
	public unsafe BasketballCourt Court
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_Court);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new BasketballCourt(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_Court), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700083C RID: 2108
	// (get) Token: 0x060017F0 RID: 6128 RVA: 0x000605CC File Offset: 0x0005E7CC
	// (set) Token: 0x060017F1 RID: 6129 RVA: 0x00060600 File Offset: 0x0005E800
	public unsafe TextMeshPro Disclaimer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_Disclaimer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new TextMeshPro(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_Disclaimer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700083D RID: 2109
	// (get) Token: 0x060017F2 RID: 6130 RVA: 0x00060628 File Offset: 0x0005E828
	// (set) Token: 0x060017F3 RID: 6131 RVA: 0x00060650 File Offset: 0x0005E850
	public unsafe int ColorOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_ColorOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_ColorOffset)) = value;
		}
	}

	// Token: 0x1700083E RID: 2110
	// (get) Token: 0x060017F4 RID: 6132 RVA: 0x00060674 File Offset: 0x0005E874
	// (set) Token: 0x060017F5 RID: 6133 RVA: 0x0006069C File Offset: 0x0005E89C
	public unsafe int ScoreFlashAmount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_ScoreFlashAmount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_ScoreFlashAmount)) = value;
		}
	}

	// Token: 0x1700083F RID: 2111
	// (get) Token: 0x060017F6 RID: 6134 RVA: 0x000606C0 File Offset: 0x0005E8C0
	// (set) Token: 0x060017F7 RID: 6135 RVA: 0x000606E8 File Offset: 0x0005E8E8
	public unsafe float ScoreFlashDelay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_ScoreFlashDelay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_ScoreFlashDelay)) = value;
		}
	}

	// Token: 0x17000840 RID: 2112
	// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0006070C File Offset: 0x0005E90C
	// (set) Token: 0x060017F9 RID: 6137 RVA: 0x00060734 File Offset: 0x0005E934
	public unsafe float InterludeFlashDelay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_InterludeFlashDelay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr_InterludeFlashDelay)) = value;
		}
	}

	// Token: 0x17000841 RID: 2113
	// (get) Token: 0x060017FA RID: 6138 RVA: 0x00060758 File Offset: 0x0005E958
	// (set) Token: 0x060017FB RID: 6139 RVA: 0x00060780 File Offset: 0x0005E980
	public unsafe Color _selectedColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr__selectedColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr__selectedColor)) = value;
		}
	}

	// Token: 0x17000842 RID: 2114
	// (get) Token: 0x060017FC RID: 6140 RVA: 0x000607A4 File Offset: 0x0005E9A4
	// (set) Token: 0x060017FD RID: 6141 RVA: 0x000607CC File Offset: 0x0005E9CC
	public unsafe Color _complimentaryColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr__complimentaryColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr__complimentaryColor)) = value;
		}
	}

	// Token: 0x17000843 RID: 2115
	// (get) Token: 0x060017FE RID: 6142 RVA: 0x000607F0 File Offset: 0x0005E9F0
	// (set) Token: 0x060017FF RID: 6143 RVA: 0x00060818 File Offset: 0x0005EA18
	public unsafe bool _usingSelectedColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr__usingSelectedColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr__usingSelectedColor)) = value;
		}
	}

	// Token: 0x17000844 RID: 2116
	// (get) Token: 0x06001800 RID: 6144 RVA: 0x0006083C File Offset: 0x0005EA3C
	// (set) Token: 0x06001801 RID: 6145 RVA: 0x00060864 File Offset: 0x0005EA64
	public unsafe BasketballGoalIndicatorLight.FlashingState _flashingState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr__flashingState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr__flashingState)) = value;
		}
	}

	// Token: 0x17000845 RID: 2117
	// (get) Token: 0x06001802 RID: 6146 RVA: 0x00060888 File Offset: 0x0005EA88
	// (set) Token: 0x06001803 RID: 6147 RVA: 0x000608B0 File Offset: 0x0005EAB0
	public unsafe float _flashTimer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr__flashTimer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr__flashTimer)) = value;
		}
	}

	// Token: 0x17000846 RID: 2118
	// (get) Token: 0x06001804 RID: 6148 RVA: 0x000608D4 File Offset: 0x0005EAD4
	// (set) Token: 0x06001805 RID: 6149 RVA: 0x000608FC File Offset: 0x0005EAFC
	public unsafe int _flashCounter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr__flashCounter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasketballGoalIndicatorLight.NativeFieldInfoPtr__flashCounter)) = value;
		}
	}

	// Token: 0x04000F38 RID: 3896
	private static readonly IntPtr NativeFieldInfoPtr_SAFETY_TEXT;

	// Token: 0x04000F39 RID: 3897
	private static readonly IntPtr NativeFieldInfoPtr_Court;

	// Token: 0x04000F3A RID: 3898
	private static readonly IntPtr NativeFieldInfoPtr_Disclaimer;

	// Token: 0x04000F3B RID: 3899
	private static readonly IntPtr NativeFieldInfoPtr_ColorOffset;

	// Token: 0x04000F3C RID: 3900
	private static readonly IntPtr NativeFieldInfoPtr_ScoreFlashAmount;

	// Token: 0x04000F3D RID: 3901
	private static readonly IntPtr NativeFieldInfoPtr_ScoreFlashDelay;

	// Token: 0x04000F3E RID: 3902
	private static readonly IntPtr NativeFieldInfoPtr_InterludeFlashDelay;

	// Token: 0x04000F3F RID: 3903
	private static readonly IntPtr NativeFieldInfoPtr__selectedColor;

	// Token: 0x04000F40 RID: 3904
	private static readonly IntPtr NativeFieldInfoPtr__complimentaryColor;

	// Token: 0x04000F41 RID: 3905
	private static readonly IntPtr NativeFieldInfoPtr__usingSelectedColor;

	// Token: 0x04000F42 RID: 3906
	private static readonly IntPtr NativeFieldInfoPtr__flashingState;

	// Token: 0x04000F43 RID: 3907
	private static readonly IntPtr NativeFieldInfoPtr__flashTimer;

	// Token: 0x04000F44 RID: 3908
	private static readonly IntPtr NativeFieldInfoPtr__flashCounter;

	// Token: 0x04000F45 RID: 3909
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0;

	// Token: 0x04000F46 RID: 3910
	private static readonly IntPtr NativeMethodInfoPtr_Deinitialize_Protected_Virtual_Void_0;

	// Token: 0x04000F47 RID: 3911
	private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

	// Token: 0x04000F48 RID: 3912
	private static readonly IntPtr NativeMethodInfoPtr_RefreshColor_Protected_Virtual_Void_0;

	// Token: 0x04000F49 RID: 3913
	private static readonly IntPtr NativeMethodInfoPtr_RefreshCaption_Protected_Virtual_Void_0;

	// Token: 0x04000F4A RID: 3914
	private static readonly IntPtr NativeMethodInfoPtr_OnInterludeChange_Private_Void_Boolean_0;

	// Token: 0x04000F4B RID: 3915
	private static readonly IntPtr NativeMethodInfoPtr_AddHue_Private_Single_Single_Single_0;

	// Token: 0x04000F4C RID: 3916
	private static readonly IntPtr NativeMethodInfoPtr_UpdateScorePulse_Private_Void_0;

	// Token: 0x04000F4D RID: 3917
	private static readonly IntPtr NativeMethodInfoPtr_UpdateInterludeStrobe_Private_Void_0;

	// Token: 0x04000F4E RID: 3918
	private static readonly IntPtr NativeMethodInfoPtr_SetFlashingState_Public_Void_FlashingState_Boolean_0;

	// Token: 0x04000F4F RID: 3919
	private static readonly IntPtr NativeMethodInfoPtr_RestoreBacklight_Private_Void_0;

	// Token: 0x04000F50 RID: 3920
	private static readonly IntPtr NativeMethodInfoPtr_ToggleBacklight_Private_Void_0;

	// Token: 0x04000F51 RID: 3921
	private static readonly IntPtr NativeMethodInfoPtr_SetBacklight_Private_Void_Boolean_0;

	// Token: 0x04000F52 RID: 3922
	private static readonly IntPtr NativeMethodInfoPtr_RestoreSafetyDisclaimer_Private_Void_0;

	// Token: 0x04000F53 RID: 3923
	private static readonly IntPtr NativeMethodInfoPtr_SetDisclaimerToInterludeTime_Private_Void_0;

	// Token: 0x04000F54 RID: 3924
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000161 RID: 353
	public enum FlashingState
	{
		// Token: 0x04000F56 RID: 3926
		NotFlashing,
		// Token: 0x04000F57 RID: 3927
		ScorePulse,
		// Token: 0x04000F58 RID: 3928
		InterludeStrobe
	}
}
