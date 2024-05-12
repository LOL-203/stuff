using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Onward.Data;
using Onward.Weapons;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200052B RID: 1323
public class WeaponVisuals : MonoBehaviour
{
	// Token: 0x17002690 RID: 9872
	// (get) Token: 0x06006C3E RID: 27710 RVA: 0x001B2A00 File Offset: 0x001B0C00
	public unsafe WeaponName WeaponName
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_get_WeaponName_Public_get_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x17002691 RID: 9873
	// (get) Token: 0x06006C3F RID: 27711 RVA: 0x001B2A50 File Offset: 0x001B0C50
	public unsafe WeaponType WeaponType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_get_WeaponType_Public_get_WeaponType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x17002692 RID: 9874
	// (get) Token: 0x06006C40 RID: 27712 RVA: 0x001B2AA0 File Offset: 0x001B0CA0
	public unsafe WeaponInformation Information
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_get_Information_Public_get_WeaponInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new WeaponInformation(intPtr2) : null;
		}
	}

	// Token: 0x17002693 RID: 9875
	// (get) Token: 0x06006C41 RID: 27713 RVA: 0x001B2AF8 File Offset: 0x001B0CF8
	public unsafe Vector3 GunSlideSoundPos
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_get_GunSlideSoundPos_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x17002694 RID: 9876
	// (get) Token: 0x06006C42 RID: 27714 RVA: 0x001B2B48 File Offset: 0x001B0D48
	public unsafe Vector3 MagSoundPos
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_get_MagSoundPos_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x17002695 RID: 9877
	// (get) Token: 0x06006C43 RID: 27715 RVA: 0x001B2B98 File Offset: 0x001B0D98
	public unsafe bool DoesMuzzleFlashSprite
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_get_DoesMuzzleFlashSprite_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x17002696 RID: 9878
	// (get) Token: 0x06006C44 RID: 27716 RVA: 0x001B2BE8 File Offset: 0x001B0DE8
	public unsafe AssetReferenceData UnspentBullet
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_get_UnspentBullet_Private_get_AssetReferenceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new AssetReferenceData(intPtr2) : null;
		}
	}

	// Token: 0x17002697 RID: 9879
	// (get) Token: 0x06006C45 RID: 27717 RVA: 0x001B2C40 File Offset: 0x001B0E40
	public unsafe bool UseParticleForCasing
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_get_UseParticleForCasing_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x06006C46 RID: 27718 RVA: 0x001B2C90 File Offset: 0x001B0E90
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C47 RID: 27719 RVA: 0x001B2CD4 File Offset: 0x001B0ED4
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C48 RID: 27720 RVA: 0x001B2D18 File Offset: 0x001B0F18
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C49 RID: 27721 RVA: 0x001B2D5C File Offset: 0x001B0F5C
	[CallerCount(0)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C4A RID: 27722 RVA: 0x001B2DA0 File Offset: 0x001B0FA0
	[CallerCount(0)]
	public unsafe void EjectCasing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_EjectCasing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C4B RID: 27723 RVA: 0x001B2DE4 File Offset: 0x001B0FE4
	[CallerCount(0)]
	public unsafe void EjectUnspentBullet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_EjectUnspentBullet_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C4C RID: 27724 RVA: 0x001B2E28 File Offset: 0x001B1028
	[CallerCount(0)]
	public unsafe void Shoot(bool isLocalPlayer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref isLocalPlayer;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_Shoot_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C4D RID: 27725 RVA: 0x001B2E7C File Offset: 0x001B107C
	[CallerCount(0)]
	public unsafe void SetWeaponCasingVfx(WeaponCasingVFX weaponCasingVFX)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(weaponCasingVFX);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr_SetWeaponCasingVfx_Public_Void_WeaponCasingVFX_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C4E RID: 27726 RVA: 0x001B2ED8 File Offset: 0x001B10D8
	[CallerCount(0)]
	public unsafe WeaponVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C4F RID: 27727 RVA: 0x001B2F24 File Offset: 0x001B1124
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponVisuals()
	{
		Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponVisuals");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr);
		WeaponVisuals.NativeFieldInfoPtr_WeaponSO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, "WeaponSO");
		WeaponVisuals.NativeFieldInfoPtr_Weapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, "Weapon");
		WeaponVisuals.NativeFieldInfoPtr_EjectorFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, "EjectorFX");
		WeaponVisuals.NativeFieldInfoPtr_MuzzleObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, "MuzzleObject");
		WeaponVisuals.NativeFieldInfoPtr_casingSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, "casingSpawnPoint");
		WeaponVisuals.NativeFieldInfoPtr_LMGcasingSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, "LMGcasingSpawnPoint");
		WeaponVisuals.NativeFieldInfoPtr__hasInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, "_hasInit");
		WeaponVisuals.NativeFieldInfoPtr__randomflash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, "_randomflash");
		WeaponVisuals.NativeFieldInfoPtr__casingVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, "_casingVFX");
		WeaponVisuals.NativeFieldInfoPtr_CASING_SPAWN_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, "CASING_SPAWN_DISTANCE");
		WeaponVisuals.NativeFieldInfoPtr_NIGHT_MUZZLE_FLASH_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, "NIGHT_MUZZLE_FLASH_MAX");
		WeaponVisuals.NativeFieldInfoPtr_DAY_MUZZLE_FLASH_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, "DAY_MUZZLE_FLASH_MAX");
		WeaponVisuals.NativeFieldInfoPtr_DEFAULT_MUZZLE_FLASH_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, "DEFAULT_MUZZLE_FLASH_MAX");
		WeaponVisuals.NativeMethodInfoPtr_get_WeaponName_Public_get_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671880);
		WeaponVisuals.NativeMethodInfoPtr_get_WeaponType_Public_get_WeaponType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671881);
		WeaponVisuals.NativeMethodInfoPtr_get_Information_Public_get_WeaponInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671882);
		WeaponVisuals.NativeMethodInfoPtr_get_GunSlideSoundPos_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671883);
		WeaponVisuals.NativeMethodInfoPtr_get_MagSoundPos_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671884);
		WeaponVisuals.NativeMethodInfoPtr_get_DoesMuzzleFlashSprite_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671885);
		WeaponVisuals.NativeMethodInfoPtr_get_UnspentBullet_Private_get_AssetReferenceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671886);
		WeaponVisuals.NativeMethodInfoPtr_get_UseParticleForCasing_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671887);
		WeaponVisuals.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671888);
		WeaponVisuals.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671889);
		WeaponVisuals.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671890);
		WeaponVisuals.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671891);
		WeaponVisuals.NativeMethodInfoPtr_EjectCasing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671892);
		WeaponVisuals.NativeMethodInfoPtr_EjectUnspentBullet_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671893);
		WeaponVisuals.NativeMethodInfoPtr_Shoot_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671894);
		WeaponVisuals.NativeMethodInfoPtr_SetWeaponCasingVfx_Public_Void_WeaponCasingVFX_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671895);
		WeaponVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr, 100671896);
	}

	// Token: 0x06006C50 RID: 27728 RVA: 0x0000210C File Offset: 0x0000030C
	public WeaponVisuals(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17002682 RID: 9858
	// (get) Token: 0x06006C51 RID: 27729 RVA: 0x001B31AC File Offset: 0x001B13AC
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponVisuals>.NativeClassPtr));
		}
	}

	// Token: 0x17002683 RID: 9859
	// (get) Token: 0x06006C52 RID: 27730 RVA: 0x001B31C0 File Offset: 0x001B13C0
	// (set) Token: 0x06006C53 RID: 27731 RVA: 0x001B31F4 File Offset: 0x001B13F4
	public unsafe WeaponSO WeaponSO
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr_WeaponSO);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WeaponSO(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr_WeaponSO), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002684 RID: 9860
	// (get) Token: 0x06006C54 RID: 27732 RVA: 0x001B321C File Offset: 0x001B141C
	// (set) Token: 0x06006C55 RID: 27733 RVA: 0x001B3250 File Offset: 0x001B1450
	public unsafe Weapon Weapon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr_Weapon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Weapon(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr_Weapon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002685 RID: 9861
	// (get) Token: 0x06006C56 RID: 27734 RVA: 0x001B3278 File Offset: 0x001B1478
	// (set) Token: 0x06006C57 RID: 27735 RVA: 0x001B32AC File Offset: 0x001B14AC
	public unsafe ParticleSystem EjectorFX
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr_EjectorFX);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new ParticleSystem(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr_EjectorFX), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002686 RID: 9862
	// (get) Token: 0x06006C58 RID: 27736 RVA: 0x001B32D4 File Offset: 0x001B14D4
	// (set) Token: 0x06006C59 RID: 27737 RVA: 0x001B3308 File Offset: 0x001B1508
	public unsafe MuzzleFlash MuzzleObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr_MuzzleObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new MuzzleFlash(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr_MuzzleObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002687 RID: 9863
	// (get) Token: 0x06006C5A RID: 27738 RVA: 0x001B3330 File Offset: 0x001B1530
	// (set) Token: 0x06006C5B RID: 27739 RVA: 0x001B3364 File Offset: 0x001B1564
	public unsafe Transform casingSpawnPoint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr_casingSpawnPoint);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr_casingSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002688 RID: 9864
	// (get) Token: 0x06006C5C RID: 27740 RVA: 0x001B338C File Offset: 0x001B158C
	// (set) Token: 0x06006C5D RID: 27741 RVA: 0x001B33C0 File Offset: 0x001B15C0
	public unsafe Transform LMGcasingSpawnPoint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr_LMGcasingSpawnPoint);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr_LMGcasingSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002689 RID: 9865
	// (get) Token: 0x06006C5E RID: 27742 RVA: 0x001B33E8 File Offset: 0x001B15E8
	// (set) Token: 0x06006C5F RID: 27743 RVA: 0x001B3410 File Offset: 0x001B1610
	public unsafe bool _hasInit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr__hasInit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr__hasInit)) = value;
		}
	}

	// Token: 0x1700268A RID: 9866
	// (get) Token: 0x06006C60 RID: 27744 RVA: 0x001B3434 File Offset: 0x001B1634
	// (set) Token: 0x06006C61 RID: 27745 RVA: 0x001B345C File Offset: 0x001B165C
	public unsafe int _randomflash
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr__randomflash);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr__randomflash)) = value;
		}
	}

	// Token: 0x1700268B RID: 9867
	// (get) Token: 0x06006C62 RID: 27746 RVA: 0x001B3480 File Offset: 0x001B1680
	// (set) Token: 0x06006C63 RID: 27747 RVA: 0x001B34B4 File Offset: 0x001B16B4
	public unsafe List<WeaponCasingVFX> _casingVFX
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr__casingVFX);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<WeaponCasingVFX>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponVisuals.NativeFieldInfoPtr__casingVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700268C RID: 9868
	// (get) Token: 0x06006C64 RID: 27748 RVA: 0x001B34DC File Offset: 0x001B16DC
	// (set) Token: 0x06006C65 RID: 27749 RVA: 0x001B34FA File Offset: 0x001B16FA
	public unsafe static float CASING_SPAWN_DISTANCE
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(WeaponVisuals.NativeFieldInfoPtr_CASING_SPAWN_DISTANCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WeaponVisuals.NativeFieldInfoPtr_CASING_SPAWN_DISTANCE, (void*)(&value));
		}
	}

	// Token: 0x1700268D RID: 9869
	// (get) Token: 0x06006C66 RID: 27750 RVA: 0x001B350C File Offset: 0x001B170C
	// (set) Token: 0x06006C67 RID: 27751 RVA: 0x001B352A File Offset: 0x001B172A
	public unsafe static int NIGHT_MUZZLE_FLASH_MAX
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(WeaponVisuals.NativeFieldInfoPtr_NIGHT_MUZZLE_FLASH_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WeaponVisuals.NativeFieldInfoPtr_NIGHT_MUZZLE_FLASH_MAX, (void*)(&value));
		}
	}

	// Token: 0x1700268E RID: 9870
	// (get) Token: 0x06006C68 RID: 27752 RVA: 0x001B353C File Offset: 0x001B173C
	// (set) Token: 0x06006C69 RID: 27753 RVA: 0x001B355A File Offset: 0x001B175A
	public unsafe static int DAY_MUZZLE_FLASH_MAX
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(WeaponVisuals.NativeFieldInfoPtr_DAY_MUZZLE_FLASH_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WeaponVisuals.NativeFieldInfoPtr_DAY_MUZZLE_FLASH_MAX, (void*)(&value));
		}
	}

	// Token: 0x1700268F RID: 9871
	// (get) Token: 0x06006C6A RID: 27754 RVA: 0x001B356C File Offset: 0x001B176C
	// (set) Token: 0x06006C6B RID: 27755 RVA: 0x001B358A File Offset: 0x001B178A
	public unsafe static int DEFAULT_MUZZLE_FLASH_MAX
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(WeaponVisuals.NativeFieldInfoPtr_DEFAULT_MUZZLE_FLASH_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WeaponVisuals.NativeFieldInfoPtr_DEFAULT_MUZZLE_FLASH_MAX, (void*)(&value));
		}
	}

	// Token: 0x04004536 RID: 17718
	private static readonly IntPtr NativeFieldInfoPtr_WeaponSO;

	// Token: 0x04004537 RID: 17719
	private static readonly IntPtr NativeFieldInfoPtr_Weapon;

	// Token: 0x04004538 RID: 17720
	private static readonly IntPtr NativeFieldInfoPtr_EjectorFX;

	// Token: 0x04004539 RID: 17721
	private static readonly IntPtr NativeFieldInfoPtr_MuzzleObject;

	// Token: 0x0400453A RID: 17722
	private static readonly IntPtr NativeFieldInfoPtr_casingSpawnPoint;

	// Token: 0x0400453B RID: 17723
	private static readonly IntPtr NativeFieldInfoPtr_LMGcasingSpawnPoint;

	// Token: 0x0400453C RID: 17724
	private static readonly IntPtr NativeFieldInfoPtr__hasInit;

	// Token: 0x0400453D RID: 17725
	private static readonly IntPtr NativeFieldInfoPtr__randomflash;

	// Token: 0x0400453E RID: 17726
	private static readonly IntPtr NativeFieldInfoPtr__casingVFX;

	// Token: 0x0400453F RID: 17727
	private static readonly IntPtr NativeFieldInfoPtr_CASING_SPAWN_DISTANCE;

	// Token: 0x04004540 RID: 17728
	private static readonly IntPtr NativeFieldInfoPtr_NIGHT_MUZZLE_FLASH_MAX;

	// Token: 0x04004541 RID: 17729
	private static readonly IntPtr NativeFieldInfoPtr_DAY_MUZZLE_FLASH_MAX;

	// Token: 0x04004542 RID: 17730
	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_MUZZLE_FLASH_MAX;

	// Token: 0x04004543 RID: 17731
	private static readonly IntPtr NativeMethodInfoPtr_get_WeaponName_Public_get_WeaponName_0;

	// Token: 0x04004544 RID: 17732
	private static readonly IntPtr NativeMethodInfoPtr_get_WeaponType_Public_get_WeaponType_0;

	// Token: 0x04004545 RID: 17733
	private static readonly IntPtr NativeMethodInfoPtr_get_Information_Public_get_WeaponInformation_0;

	// Token: 0x04004546 RID: 17734
	private static readonly IntPtr NativeMethodInfoPtr_get_GunSlideSoundPos_Public_get_Vector3_0;

	// Token: 0x04004547 RID: 17735
	private static readonly IntPtr NativeMethodInfoPtr_get_MagSoundPos_Public_get_Vector3_0;

	// Token: 0x04004548 RID: 17736
	private static readonly IntPtr NativeMethodInfoPtr_get_DoesMuzzleFlashSprite_Private_get_Boolean_0;

	// Token: 0x04004549 RID: 17737
	private static readonly IntPtr NativeMethodInfoPtr_get_UnspentBullet_Private_get_AssetReferenceData_0;

	// Token: 0x0400454A RID: 17738
	private static readonly IntPtr NativeMethodInfoPtr_get_UseParticleForCasing_Private_get_Boolean_0;

	// Token: 0x0400454B RID: 17739
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400454C RID: 17740
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x0400454D RID: 17741
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x0400454E RID: 17742
	private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

	// Token: 0x0400454F RID: 17743
	private static readonly IntPtr NativeMethodInfoPtr_EjectCasing_Public_Void_0;

	// Token: 0x04004550 RID: 17744
	private static readonly IntPtr NativeMethodInfoPtr_EjectUnspentBullet_Public_Void_0;

	// Token: 0x04004551 RID: 17745
	private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Void_Boolean_0;

	// Token: 0x04004552 RID: 17746
	private static readonly IntPtr NativeMethodInfoPtr_SetWeaponCasingVfx_Public_Void_WeaponCasingVFX_0;

	// Token: 0x04004553 RID: 17747
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
