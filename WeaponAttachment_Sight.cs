using System;
using DPI.DynamicMaterialManager;
using DPI.NightVision;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000521 RID: 1313
public class WeaponAttachment_Sight : WeaponAttachment
{
	// Token: 0x17002636 RID: 9782
	// (get) Token: 0x06006B64 RID: 27492 RVA: 0x001AF878 File Offset: 0x001ADA78
	public unsafe float VirtualGunstockDistFromHead
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_get_VirtualGunstockDistFromHead_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x17002637 RID: 9783
	// (get) Token: 0x06006B65 RID: 27493 RVA: 0x001AF8C8 File Offset: 0x001ADAC8
	public unsafe float ZeroDistance
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_get_ZeroDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x17002638 RID: 9784
	// (get) Token: 0x06006B66 RID: 27494 RVA: 0x001AF918 File Offset: 0x001ADB18
	public unsafe bool IsZeroDistanceSame
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_get_IsZeroDistanceSame_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x06006B67 RID: 27495 RVA: 0x001AF968 File Offset: 0x001ADB68
	[CallerCount(0)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_OnValidate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B68 RID: 27496 RVA: 0x001AF9AC File Offset: 0x001ADBAC
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B69 RID: 27497 RVA: 0x001AF9F0 File Offset: 0x001ADBF0
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B6A RID: 27498 RVA: 0x001AFA34 File Offset: 0x001ADC34
	[CallerCount(0)]
	public new unsafe void Initialize(Pickup_Gun gun)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gun);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponAttachment_Sight.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B6B RID: 27499 RVA: 0x001AFA98 File Offset: 0x001ADC98
	[CallerCount(0)]
	public new unsafe void Uninitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponAttachment_Sight.NativeMethodInfoPtr_Uninitialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B6C RID: 27500 RVA: 0x001AFAE8 File Offset: 0x001ADCE8
	[CallerCount(0)]
	public unsafe void OverrideZeroDistance(float distance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref distance;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_OverrideZeroDistance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B6D RID: 27501 RVA: 0x001AFB3C File Offset: 0x001ADD3C
	[CallerCount(0)]
	public unsafe void OverrideVirtualGunstockDistance(float distance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref distance;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_OverrideVirtualGunstockDistance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B6E RID: 27502 RVA: 0x001AFB90 File Offset: 0x001ADD90
	[CallerCount(0)]
	public unsafe void Activate(Pickup_Gun pickupGun)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pickupGun);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_Activate_Public_Void_Pickup_Gun_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B6F RID: 27503 RVA: 0x001AFBEC File Offset: 0x001ADDEC
	[CallerCount(0)]
	public unsafe void SetNightVisionOn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_SetNightVisionOn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B70 RID: 27504 RVA: 0x001AFC30 File Offset: 0x001ADE30
	[CallerCount(0)]
	public unsafe void SetNightVisionOff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_SetNightVisionOff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B71 RID: 27505 RVA: 0x001AFC74 File Offset: 0x001ADE74
	[CallerCount(0)]
	public unsafe void SetNightVision(bool isNightVisionOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref isNightVisionOn;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_SetNightVision_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B72 RID: 27506 RVA: 0x001AFCC8 File Offset: 0x001ADEC8
	[CallerCount(0)]
	public unsafe void SetReticleColor(Color c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref c;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_SetReticleColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B73 RID: 27507 RVA: 0x001AFD1C File Offset: 0x001ADF1C
	[CallerCount(0)]
	public unsafe void OnAnyNightVisionBoostActiveChange(bool active)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref active;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_OnAnyNightVisionBoostActiveChange_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B74 RID: 27508 RVA: 0x001AFD70 File Offset: 0x001ADF70
	[CallerCount(0)]
	public unsafe int GetReticleCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_GetReticleCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06006B75 RID: 27509 RVA: 0x001AFDC0 File Offset: 0x001ADFC0
	[CallerCount(0)]
	public unsafe void OnDynamicMaterialEntryReady(DynamicMaterialEntry entry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_OnDynamicMaterialEntryReady_Private_Void_DynamicMaterialEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B76 RID: 27510 RVA: 0x001AFE1C File Offset: 0x001AE01C
	[CallerCount(0)]
	public unsafe void OnAllReticlesLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr_OnAllReticlesLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B77 RID: 27511 RVA: 0x001AFE60 File Offset: 0x001AE060
	[CallerCount(0)]
	public unsafe WeaponAttachment_Sight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment_Sight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B78 RID: 27512 RVA: 0x001AFEAC File Offset: 0x001AE0AC
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponAttachment_Sight()
	{
		Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponAttachment_Sight");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr);
		WeaponAttachment_Sight.NativeFieldInfoPtr_FrontSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, "FrontSight");
		WeaponAttachment_Sight.NativeFieldInfoPtr_RearSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, "RearSight");
		WeaponAttachment_Sight.NativeFieldInfoPtr_ParallaxCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, "ParallaxCamera");
		WeaponAttachment_Sight.NativeFieldInfoPtr__reticleRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, "_reticleRenderers");
		WeaponAttachment_Sight.NativeFieldInfoPtr__prevZeroDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, "_prevZeroDistance");
		WeaponAttachment_Sight.NativeFieldInfoPtr__zeroDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, "_zeroDistance");
		WeaponAttachment_Sight.NativeFieldInfoPtr__virtualGunstockDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, "_virtualGunstockDistance");
		WeaponAttachment_Sight.NativeFieldInfoPtr_PICKUPS_LAYER_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, "PICKUPS_LAYER_NAME");
		WeaponAttachment_Sight.NativeFieldInfoPtr_RETICLE_COLOR_KEYWORD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, "RETICLE_COLOR_KEYWORD");
		WeaponAttachment_Sight.NativeFieldInfoPtr__nvLensCaches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, "_nvLensCaches");
		WeaponAttachment_Sight.NativeMethodInfoPtr_get_VirtualGunstockDistFromHead_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671830);
		WeaponAttachment_Sight.NativeMethodInfoPtr_get_ZeroDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671831);
		WeaponAttachment_Sight.NativeMethodInfoPtr_get_IsZeroDistanceSame_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671832);
		WeaponAttachment_Sight.NativeMethodInfoPtr_OnValidate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671833);
		WeaponAttachment_Sight.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671834);
		WeaponAttachment_Sight.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671835);
		WeaponAttachment_Sight.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671836);
		WeaponAttachment_Sight.NativeMethodInfoPtr_Uninitialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671837);
		WeaponAttachment_Sight.NativeMethodInfoPtr_OverrideZeroDistance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671838);
		WeaponAttachment_Sight.NativeMethodInfoPtr_OverrideVirtualGunstockDistance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671839);
		WeaponAttachment_Sight.NativeMethodInfoPtr_Activate_Public_Void_Pickup_Gun_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671840);
		WeaponAttachment_Sight.NativeMethodInfoPtr_SetNightVisionOn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671841);
		WeaponAttachment_Sight.NativeMethodInfoPtr_SetNightVisionOff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671842);
		WeaponAttachment_Sight.NativeMethodInfoPtr_SetNightVision_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671843);
		WeaponAttachment_Sight.NativeMethodInfoPtr_SetReticleColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671844);
		WeaponAttachment_Sight.NativeMethodInfoPtr_OnAnyNightVisionBoostActiveChange_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671845);
		WeaponAttachment_Sight.NativeMethodInfoPtr_GetReticleCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671846);
		WeaponAttachment_Sight.NativeMethodInfoPtr_OnDynamicMaterialEntryReady_Private_Void_DynamicMaterialEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671847);
		WeaponAttachment_Sight.NativeMethodInfoPtr_OnAllReticlesLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671848);
		WeaponAttachment_Sight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr, 100671849);
	}

	// Token: 0x06006B79 RID: 27513 RVA: 0x001AF228 File Offset: 0x001AD428
	public WeaponAttachment_Sight(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700262B RID: 9771
	// (get) Token: 0x06006B7A RID: 27514 RVA: 0x001B0134 File Offset: 0x001AE334
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponAttachment_Sight>.NativeClassPtr));
		}
	}

	// Token: 0x1700262C RID: 9772
	// (get) Token: 0x06006B7B RID: 27515 RVA: 0x001B0148 File Offset: 0x001AE348
	// (set) Token: 0x06006B7C RID: 27516 RVA: 0x001B017C File Offset: 0x001AE37C
	public unsafe Transform FrontSight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr_FrontSight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr_FrontSight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700262D RID: 9773
	// (get) Token: 0x06006B7D RID: 27517 RVA: 0x001B01A4 File Offset: 0x001AE3A4
	// (set) Token: 0x06006B7E RID: 27518 RVA: 0x001B01D8 File Offset: 0x001AE3D8
	public unsafe Transform RearSight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr_RearSight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr_RearSight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700262E RID: 9774
	// (get) Token: 0x06006B7F RID: 27519 RVA: 0x001B0200 File Offset: 0x001AE400
	// (set) Token: 0x06006B80 RID: 27520 RVA: 0x001B0234 File Offset: 0x001AE434
	public unsafe ScopeParallaxCamera ParallaxCamera
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr_ParallaxCamera);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new ScopeParallaxCamera(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr_ParallaxCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700262F RID: 9775
	// (get) Token: 0x06006B81 RID: 27521 RVA: 0x001B025C File Offset: 0x001AE45C
	// (set) Token: 0x06006B82 RID: 27522 RVA: 0x001B0290 File Offset: 0x001AE490
	public unsafe Il2CppReferenceArray<Renderer> _reticleRenderers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr__reticleRenderers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<Renderer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr__reticleRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002630 RID: 9776
	// (get) Token: 0x06006B83 RID: 27523 RVA: 0x001B02B8 File Offset: 0x001AE4B8
	// (set) Token: 0x06006B84 RID: 27524 RVA: 0x001B02E0 File Offset: 0x001AE4E0
	public unsafe float _prevZeroDistance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr__prevZeroDistance);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr__prevZeroDistance)) = value;
		}
	}

	// Token: 0x17002631 RID: 9777
	// (get) Token: 0x06006B85 RID: 27525 RVA: 0x001B0304 File Offset: 0x001AE504
	// (set) Token: 0x06006B86 RID: 27526 RVA: 0x001B032C File Offset: 0x001AE52C
	public unsafe float _zeroDistance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr__zeroDistance);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr__zeroDistance)) = value;
		}
	}

	// Token: 0x17002632 RID: 9778
	// (get) Token: 0x06006B87 RID: 27527 RVA: 0x001B0350 File Offset: 0x001AE550
	// (set) Token: 0x06006B88 RID: 27528 RVA: 0x001B0378 File Offset: 0x001AE578
	public unsafe float _virtualGunstockDistance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr__virtualGunstockDistance);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr__virtualGunstockDistance)) = value;
		}
	}

	// Token: 0x17002633 RID: 9779
	// (get) Token: 0x06006B89 RID: 27529 RVA: 0x001B039C File Offset: 0x001AE59C
	// (set) Token: 0x06006B8A RID: 27530 RVA: 0x001B03BC File Offset: 0x001AE5BC
	public unsafe static string PICKUPS_LAYER_NAME
	{
		get
		{
			IntPtr il2CppString;
			IL2CPP.il2cpp_field_static_get_value(WeaponAttachment_Sight.NativeFieldInfoPtr_PICKUPS_LAYER_NAME, (void*)(&il2CppString));
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WeaponAttachment_Sight.NativeFieldInfoPtr_PICKUPS_LAYER_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17002634 RID: 9780
	// (get) Token: 0x06006B8B RID: 27531 RVA: 0x001B03D4 File Offset: 0x001AE5D4
	// (set) Token: 0x06006B8C RID: 27532 RVA: 0x001B03F2 File Offset: 0x001AE5F2
	public unsafe static int RETICLE_COLOR_KEYWORD
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(WeaponAttachment_Sight.NativeFieldInfoPtr_RETICLE_COLOR_KEYWORD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WeaponAttachment_Sight.NativeFieldInfoPtr_RETICLE_COLOR_KEYWORD, (void*)(&value));
		}
	}

	// Token: 0x17002635 RID: 9781
	// (get) Token: 0x06006B8D RID: 27533 RVA: 0x001B0404 File Offset: 0x001AE604
	// (set) Token: 0x06006B8E RID: 27534 RVA: 0x001B0438 File Offset: 0x001AE638
	public unsafe List<NightVisionLensCache> _nvLensCaches
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr__nvLensCaches);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<NightVisionLensCache>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment_Sight.NativeFieldInfoPtr__nvLensCaches), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400446E RID: 17518
	private static readonly IntPtr NativeFieldInfoPtr_FrontSight;

	// Token: 0x0400446F RID: 17519
	private static readonly IntPtr NativeFieldInfoPtr_RearSight;

	// Token: 0x04004470 RID: 17520
	private static readonly IntPtr NativeFieldInfoPtr_ParallaxCamera;

	// Token: 0x04004471 RID: 17521
	private static readonly IntPtr NativeFieldInfoPtr__reticleRenderers;

	// Token: 0x04004472 RID: 17522
	private static readonly IntPtr NativeFieldInfoPtr__prevZeroDistance;

	// Token: 0x04004473 RID: 17523
	private static readonly IntPtr NativeFieldInfoPtr__zeroDistance;

	// Token: 0x04004474 RID: 17524
	private static readonly IntPtr NativeFieldInfoPtr__virtualGunstockDistance;

	// Token: 0x04004475 RID: 17525
	private static readonly IntPtr NativeFieldInfoPtr_PICKUPS_LAYER_NAME;

	// Token: 0x04004476 RID: 17526
	private static readonly IntPtr NativeFieldInfoPtr_RETICLE_COLOR_KEYWORD;

	// Token: 0x04004477 RID: 17527
	private static readonly IntPtr NativeFieldInfoPtr__nvLensCaches;

	// Token: 0x04004478 RID: 17528
	private static readonly IntPtr NativeMethodInfoPtr_get_VirtualGunstockDistFromHead_Public_get_Single_0;

	// Token: 0x04004479 RID: 17529
	private static readonly IntPtr NativeMethodInfoPtr_get_ZeroDistance_Public_get_Single_0;

	// Token: 0x0400447A RID: 17530
	private static readonly IntPtr NativeMethodInfoPtr_get_IsZeroDistanceSame_Private_get_Boolean_0;

	// Token: 0x0400447B RID: 17531
	private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Void_0;

	// Token: 0x0400447C RID: 17532
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400447D RID: 17533
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x0400447E RID: 17534
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Pickup_Gun_0;

	// Token: 0x0400447F RID: 17535
	private static readonly IntPtr NativeMethodInfoPtr_Uninitialize_Public_Virtual_Void_0;

	// Token: 0x04004480 RID: 17536
	private static readonly IntPtr NativeMethodInfoPtr_OverrideZeroDistance_Public_Void_Single_0;

	// Token: 0x04004481 RID: 17537
	private static readonly IntPtr NativeMethodInfoPtr_OverrideVirtualGunstockDistance_Public_Void_Single_0;

	// Token: 0x04004482 RID: 17538
	private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_Pickup_Gun_0;

	// Token: 0x04004483 RID: 17539
	private static readonly IntPtr NativeMethodInfoPtr_SetNightVisionOn_Private_Void_0;

	// Token: 0x04004484 RID: 17540
	private static readonly IntPtr NativeMethodInfoPtr_SetNightVisionOff_Private_Void_0;

	// Token: 0x04004485 RID: 17541
	private static readonly IntPtr NativeMethodInfoPtr_SetNightVision_Private_Void_Boolean_0;

	// Token: 0x04004486 RID: 17542
	private static readonly IntPtr NativeMethodInfoPtr_SetReticleColor_Private_Void_Color_0;

	// Token: 0x04004487 RID: 17543
	private static readonly IntPtr NativeMethodInfoPtr_OnAnyNightVisionBoostActiveChange_Private_Void_Boolean_0;

	// Token: 0x04004488 RID: 17544
	private static readonly IntPtr NativeMethodInfoPtr_GetReticleCount_Private_Int32_0;

	// Token: 0x04004489 RID: 17545
	private static readonly IntPtr NativeMethodInfoPtr_OnDynamicMaterialEntryReady_Private_Void_DynamicMaterialEntry_0;

	// Token: 0x0400448A RID: 17546
	private static readonly IntPtr NativeMethodInfoPtr_OnAllReticlesLoaded_Private_Void_0;

	// Token: 0x0400448B RID: 17547
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
