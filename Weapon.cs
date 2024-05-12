using System;
using System.Runtime.InteropServices;
using AK.Wwise;
using DPI.Networking;
using DPI.Networking.IO;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Onward.Data;
using Onward.Networking;
using Onward.Pickups;
using Onward.Weapons;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200050F RID: 1295
public class Weapon : MonoBehaviourDPINetworking
{
	// Token: 0x060069CA RID: 27082 RVA: 0x001A7FBC File Offset: 0x001A61BC
	[CallerCount(0)]
	public unsafe void add_Fired(Action<DPIPlayer, int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_add_Fired_Public_add_Void_Action_2_DPIPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069CB RID: 27083 RVA: 0x001A8018 File Offset: 0x001A6218
	[CallerCount(0)]
	public unsafe void remove_Fired(Action<DPIPlayer, int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_remove_Fired_Public_rem_Void_Action_2_DPIPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x170025E4 RID: 9700
	// (get) Token: 0x060069CC RID: 27084 RVA: 0x001A8074 File Offset: 0x001A6274
	// (set) Token: 0x060069CD RID: 27085 RVA: 0x001A80C4 File Offset: 0x001A62C4
	public unsafe bool isTentItem
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_isTentItem_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_set_isTentItem_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170025E5 RID: 9701
	// (get) Token: 0x060069CE RID: 27086 RVA: 0x001A8118 File Offset: 0x001A6318
	public unsafe bool CanDropMagFree
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_CanDropMagFree_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025E6 RID: 9702
	// (get) Token: 0x060069CF RID: 27087 RVA: 0x001A8168 File Offset: 0x001A6368
	public unsafe bool IsShotgunWeaponType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_IsShotgunWeaponType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025E7 RID: 9703
	// (get) Token: 0x060069D0 RID: 27088 RVA: 0x001A81B8 File Offset: 0x001A63B8
	public unsafe bool IsLightMachineGunWeaponType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_IsLightMachineGunWeaponType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025E8 RID: 9704
	// (get) Token: 0x060069D1 RID: 27089 RVA: 0x001A8208 File Offset: 0x001A6408
	public unsafe bool IsLauncherWeaponType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_IsLauncherWeaponType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025E9 RID: 9705
	// (get) Token: 0x060069D2 RID: 27090 RVA: 0x001A8258 File Offset: 0x001A6458
	public unsafe bool IsBoltActionWeaponType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_IsBoltActionWeaponType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025EA RID: 9706
	// (get) Token: 0x060069D3 RID: 27091 RVA: 0x001A82A8 File Offset: 0x001A64A8
	public unsafe bool IsPistolWeaponType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_IsPistolWeaponType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025EB RID: 9707
	// (get) Token: 0x060069D4 RID: 27092 RVA: 0x001A82F8 File Offset: 0x001A64F8
	public unsafe bool IsLightMachineGunTopAtTop
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_IsLightMachineGunTopAtTop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025EC RID: 9708
	// (get) Token: 0x060069D5 RID: 27093 RVA: 0x001A8348 File Offset: 0x001A6548
	public unsafe bool IsLightMachineGunTopClosed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_IsLightMachineGunTopClosed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025ED RID: 9709
	// (get) Token: 0x060069D6 RID: 27094 RVA: 0x001A8398 File Offset: 0x001A6598
	public unsafe int LoadingCapacity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_LoadingCapacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025EE RID: 9710
	// (get) Token: 0x060069D7 RID: 27095 RVA: 0x001A83E8 File Offset: 0x001A65E8
	public unsafe int BurstRate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_BurstRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025EF RID: 9711
	// (get) Token: 0x060069D8 RID: 27096 RVA: 0x001A8438 File Offset: 0x001A6638
	public unsafe float MuzzleVelocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_MuzzleVelocity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025F0 RID: 9712
	// (get) Token: 0x060069D9 RID: 27097 RVA: 0x001A8488 File Offset: 0x001A6688
	public unsafe float ShotSpreadAngle
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_ShotSpreadAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025F1 RID: 9713
	// (get) Token: 0x060069DA RID: 27098 RVA: 0x001A84D8 File Offset: 0x001A66D8
	public unsafe bool cleanupProjectilesWithGun
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_cleanupProjectilesWithGun_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025F2 RID: 9714
	// (get) Token: 0x060069DB RID: 27099 RVA: 0x001A8528 File Offset: 0x001A6728
	public unsafe bool doesEjectShells
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_doesEjectShells_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025F3 RID: 9715
	// (get) Token: 0x060069DC RID: 27100 RVA: 0x001A8578 File Offset: 0x001A6778
	public unsafe float AISemiAutoRoundsPerSecond
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_AISemiAutoRoundsPerSecond_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025F4 RID: 9716
	// (get) Token: 0x060069DD RID: 27101 RVA: 0x001A85C8 File Offset: 0x001A67C8
	public unsafe bool StartWithMag
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_StartWithMag_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025F5 RID: 9717
	// (get) Token: 0x060069DE RID: 27102 RVA: 0x001A8618 File Offset: 0x001A6818
	public unsafe bool usesSubSonicRounds
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_usesSubSonicRounds_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025F6 RID: 9718
	// (get) Token: 0x060069DF RID: 27103 RVA: 0x001A8668 File Offset: 0x001A6868
	public unsafe float rateOfFire
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_rateOfFire_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025F7 RID: 9719
	// (get) Token: 0x060069E0 RID: 27104 RVA: 0x001A86B8 File Offset: 0x001A68B8
	public unsafe ProjectileLibrary.ProjectileID ProjectileType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_ProjectileType_Private_get_ProjectileID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025F8 RID: 9720
	// (get) Token: 0x060069E1 RID: 27105 RVA: 0x001A8708 File Offset: 0x001A6908
	public unsafe int CurrentAmmo
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_CurrentAmmo_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025F9 RID: 9721
	// (get) Token: 0x060069E2 RID: 27106 RVA: 0x001A8758 File Offset: 0x001A6958
	public unsafe float AmmoPercentage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_AmmoPercentage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170025FA RID: 9722
	// (get) Token: 0x060069E3 RID: 27107 RVA: 0x001A87A8 File Offset: 0x001A69A8
	// (set) Token: 0x060069E4 RID: 27108 RVA: 0x001A87F8 File Offset: 0x001A69F8
	public unsafe int RoundsLoaded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_RoundsLoaded_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_set_RoundsLoaded_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170025FB RID: 9723
	// (get) Token: 0x060069E5 RID: 27109 RVA: 0x001A884C File Offset: 0x001A6A4C
	// (set) Token: 0x060069E6 RID: 27110 RVA: 0x001A889C File Offset: 0x001A6A9C
	public unsafe ClassLoadout.AmmoType LoadedAmmoType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_LoadedAmmoType_Public_get_AmmoType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_set_LoadedAmmoType_Public_set_Void_AmmoType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x060069E7 RID: 27111 RVA: 0x001A88F0 File Offset: 0x001A6AF0
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069E8 RID: 27112 RVA: 0x001A8934 File Offset: 0x001A6B34
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069E9 RID: 27113 RVA: 0x001A8978 File Offset: 0x001A6B78
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069EA RID: 27114 RVA: 0x001A89BC File Offset: 0x001A6BBC
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069EB RID: 27115 RVA: 0x001A8A00 File Offset: 0x001A6C00
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069EC RID: 27116 RVA: 0x001A8A44 File Offset: 0x001A6C44
	[CallerCount(0)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069ED RID: 27117 RVA: 0x001A8A88 File Offset: 0x001A6C88
	[CallerCount(0)]
	public unsafe void ToggleChamberedRound(bool state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref state;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_ToggleChamberedRound_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069EE RID: 27118 RVA: 0x001A8ADC File Offset: 0x001A6CDC
	[CallerCount(0)]
	public unsafe void SpawnAndInsertMagazine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_SpawnAndInsertMagazine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069EF RID: 27119 RVA: 0x001A8B20 File Offset: 0x001A6D20
	[CallerCount(0)]
	public unsafe void OverrideAmmoType(ClassLoadout.AmmoType ammoType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref ammoType;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_OverrideAmmoType_Public_Void_AmmoType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069F0 RID: 27120 RVA: 0x001A8B74 File Offset: 0x001A6D74
	[CallerCount(0)]
	public unsafe void FlagAsInTentItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_FlagAsInTentItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069F1 RID: 27121 RVA: 0x001A8BB8 File Offset: 0x001A6DB8
	[CallerCount(0)]
	public unsafe Pickup_Magazine SpawnLoadoutTableMagazine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_SpawnLoadoutTableMagazine_Public_Pickup_Magazine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new Pickup_Magazine(intPtr2) : null;
	}

	// Token: 0x060069F2 RID: 27122 RVA: 0x001A8C10 File Offset: 0x001A6E10
	[CallerCount(0)]
	public unsafe void RPC_SetLoadedAmmoType(byte ammoTypeByte, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref ammoTypeByte;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_SetLoadedAmmoType_Public_Void_Byte_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069F3 RID: 27123 RVA: 0x001A8C84 File Offset: 0x001A6E84
	[CallerCount(0)]
	public unsafe void ToggleCamChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_ToggleCamChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x170025FC RID: 9724
	// (get) Token: 0x060069F4 RID: 27124 RVA: 0x001A8CC8 File Offset: 0x001A6EC8
	// (set) Token: 0x060069F5 RID: 27125 RVA: 0x001A8D18 File Offset: 0x001A6F18
	public unsafe bool ManagedUpdateRemoval
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x060069F6 RID: 27126 RVA: 0x001A8D6C File Offset: 0x001A6F6C
	[CallerCount(0)]
	public unsafe void OnManagedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069F7 RID: 27127 RVA: 0x001A8DB0 File Offset: 0x001A6FB0
	[CallerCount(0)]
	public unsafe void SpectatingAndDebugging(float deltaTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref deltaTime;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_SpectatingAndDebugging_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069F8 RID: 27128 RVA: 0x001A8E04 File Offset: 0x001A7004
	[CallerCount(0)]
	public unsafe void UpdateWeaponTimer(float deltaTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref deltaTime;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_UpdateWeaponTimer_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069F9 RID: 27129 RVA: 0x001A8E58 File Offset: 0x001A7058
	[CallerCount(0)]
	public unsafe void InsertMag(Pickup_Magazine mag, bool immediateInsert)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mag);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref immediateInsert;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_InsertMag_Public_Void_Pickup_Magazine_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069FA RID: 27130 RVA: 0x001A8EC4 File Offset: 0x001A70C4
	[CallerCount(0)]
	public unsafe void PulledMagOut()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_PulledMagOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069FB RID: 27131 RVA: 0x001A8F08 File Offset: 0x001A7108
	[CallerCount(0)]
	public unsafe void EjectMagazine(bool isFastReload = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref isFastReload;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_EjectMagazine_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069FC RID: 27132 RVA: 0x001A8F5C File Offset: 0x001A715C
	[CallerCount(0)]
	public unsafe void RPC_EjectMag(bool doEjectAnimation, int newMagAmmo, bool isFastReload, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref doEjectAnimation;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMagAmmo;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFastReload;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_EjectMag_Public_Void_Boolean_Int32_Boolean_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060069FD RID: 27133 RVA: 0x001A8FF4 File Offset: 0x001A71F4
	[CallerCount(0)]
	public unsafe bool CanFire()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_CanFire_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060069FE RID: 27134 RVA: 0x001A9044 File Offset: 0x001A7244
	[CallerCount(0)]
	public unsafe bool CanFireAI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_CanFireAI_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060069FF RID: 27135 RVA: 0x001A9094 File Offset: 0x001A7294
	[CallerCount(0)]
	public unsafe void AIFireWeapon(Vector3 forward, int AISourceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref forward;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_AIFireWeapon_Public_Void_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A00 RID: 27136 RVA: 0x001A90FC File Offset: 0x001A72FC
	[CallerCount(0)]
	public unsafe void AIReload()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_AIReload_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A01 RID: 27137 RVA: 0x001A9140 File Offset: 0x001A7340
	[CallerCount(0)]
	public unsafe void LaunchAlternateProjectile(Vector3 position, Vector3 forward, int ProjectileType, DPIPlayer PlayerSource, int AISourceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref position;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forward;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ProjectileType;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(PlayerSource);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_LaunchAlternateProjectile_Public_Void_Vector3_Vector3_Int32_DPIPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A02 RID: 27138 RVA: 0x001A91E8 File Offset: 0x001A73E8
	[CallerCount(0)]
	public unsafe void RPC_LaunchAlternateProjectile(Vector3 spawnPosition, Vector3 lookDirection, int projectileTypeId, int playerID, int AISourceID, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref spawnPosition;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookDirection;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectileTypeId;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerID;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_LaunchAlternateProjectile_Public_Void_Vector3_Vector3_Int32_Int32_Int32_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A03 RID: 27139 RVA: 0x001A92A8 File Offset: 0x001A74A8
	[CallerCount(0)]
	public unsafe void FireWeapon([Optional] DPIPlayer PlayerSource, [Optional] Nullable<Vector3> forward, [Optional] int AISourceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(PlayerSource);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(forward));
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_FireWeapon_Public_Void_DPIPlayer_Nullable_1_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A04 RID: 27140 RVA: 0x001A9334 File Offset: 0x001A7534
	[CallerCount(0)]
	public unsafe void DeductAmmo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_DeductAmmo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A05 RID: 27141 RVA: 0x001A9378 File Offset: 0x001A7578
	[CallerCount(0)]
	public unsafe void RPC_LaunchProjectile(Vector3 spawnPosition, Vector3 lookDirection, int ammoID, int playerID, int AISourceID, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref spawnPosition;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookDirection;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ammoID;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerID;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_LaunchProjectile_Public_Void_Vector3_Vector3_Int32_Int32_Int32_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A06 RID: 27142 RVA: 0x001A9438 File Offset: 0x001A7638
	[CallerCount(0)]
	public unsafe void HideMagazine(bool hidden)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref hidden;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_HideMagazine_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A07 RID: 27143 RVA: 0x001A948C File Offset: 0x001A768C
	[CallerCount(0)]
	public unsafe void RPC_HideMagazine(bool hidden, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref hidden;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_HideMagazine_Public_Void_Boolean_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A08 RID: 27144 RVA: 0x001A9500 File Offset: 0x001A7700
	[CallerCount(0)]
	public unsafe void LaunchProjectile(Vector3 spawnPosition, Quaternion lookRotation, ProjectileLibrary.ProjectileID projectileType, ClassLoadout.AmmoType ammo, OnwardPhotonPlayer PlayerSource, int AISourceID, [Optional] float DamageOverride)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref spawnPosition;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookRotation;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectileType;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ammo;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(PlayerSource);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref DamageOverride;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_LaunchProjectile_Private_Void_Vector3_Quaternion_ProjectileID_AmmoType_OnwardPhotonPlayer_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A09 RID: 27145 RVA: 0x001A95CC File Offset: 0x001A77CC
	[CallerCount(0)]
	public unsafe void FireAlert()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_FireAlert_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A0A RID: 27146 RVA: 0x001A9610 File Offset: 0x001A7810
	[CallerCount(0)]
	public unsafe void LoadRound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_LoadRound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A0B RID: 27147 RVA: 0x001A9654 File Offset: 0x001A7854
	[CallerCount(0)]
	public unsafe void EjectUnspentBullet()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_EjectUnspentBullet_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A0C RID: 27148 RVA: 0x001A9698 File Offset: 0x001A7898
	[CallerCount(0)]
	public unsafe void EjectCasing()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_EjectCasing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A0D RID: 27149 RVA: 0x001A96DC File Offset: 0x001A78DC
	[CallerCount(0)]
	public unsafe void RPC_ByteWrapper_Alloc_SetAttachments(Il2CppStructArray<int> attachmentTypes, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(attachmentTypes);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_ByteWrapper_Alloc_SetAttachments_Public_Void_ArrayOf_Int32_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A0E RID: 27150 RVA: 0x001A9754 File Offset: 0x001A7954
	[CallerCount(0)]
	public unsafe void InvokeSetAttachmentsRPC(Il2CppStructArray<WeaponAttachment.AttachmentType> attachmentTypes, RpcTarget targets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(attachmentTypes);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targets;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_InvokeSetAttachmentsRPC_Public_Void_ArrayOf_AttachmentType_RpcTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A0F RID: 27151 RVA: 0x001A97C0 File Offset: 0x001A79C0
	[CallerCount(0)]
	public unsafe void SetAttachmentsRPC(Il2CppStructArray<WeaponAttachment.AttachmentType> attachments)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(attachments);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_SetAttachmentsRPC_Public_Void_ArrayOf_AttachmentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A10 RID: 27152 RVA: 0x001A981C File Offset: 0x001A7A1C
	[CallerCount(0)]
	public unsafe WeaponAttachment_Sight GetSightToZero()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_GetSightToZero_Public_WeaponAttachment_Sight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new WeaponAttachment_Sight(intPtr2) : null;
	}

	// Token: 0x06006A11 RID: 27153 RVA: 0x001A9874 File Offset: 0x001A7A74
	[CallerCount(0)]
	public unsafe void SetLaser(WeaponAttachmentToggleState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref state;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_SetLaser_Public_Void_WeaponAttachmentToggleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A12 RID: 27154 RVA: 0x001A98C8 File Offset: 0x001A7AC8
	[CallerCount(0)]
	public unsafe void SetFlashlight(WeaponAttachmentToggleState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref state;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_SetFlashlight_Public_Void_WeaponAttachmentToggleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A13 RID: 27155 RVA: 0x001A991C File Offset: 0x001A7B1C
	[CallerCount(0)]
	public unsafe void ToggleLaser()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_ToggleLaser_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A14 RID: 27156 RVA: 0x001A9960 File Offset: 0x001A7B60
	[CallerCount(0)]
	public unsafe void ToggleFlashlight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_ToggleFlashlight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A15 RID: 27157 RVA: 0x001A99A4 File Offset: 0x001A7BA4
	[CallerCount(0)]
	public unsafe void RPC_LaserStatus(int newStatus, bool playSound, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref newStatus;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_LaserStatus_Public_Void_Int32_Boolean_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A16 RID: 27158 RVA: 0x001A9A28 File Offset: 0x001A7C28
	[CallerCount(0)]
	public unsafe void RefreshLaserClientSide(bool playSound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref playSound;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RefreshLaserClientSide_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A17 RID: 27159 RVA: 0x001A9A7C File Offset: 0x001A7C7C
	[CallerCount(0)]
	public unsafe void RPC_FlashLightStatus(int newStatus, bool playSound, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref newStatus;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_FlashLightStatus_Public_Void_Int32_Boolean_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A18 RID: 27160 RVA: 0x001A9B00 File Offset: 0x001A7D00
	[CallerCount(0)]
	public unsafe void RefreshFlashlightClientSide(bool playSound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref playSound;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RefreshFlashlightClientSide_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A19 RID: 27161 RVA: 0x001A9B54 File Offset: 0x001A7D54
	[CallerCount(0)]
	public unsafe void RefreshInteractableAttachmentsSilently()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RefreshInteractableAttachmentsSilently_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A1A RID: 27162 RVA: 0x001A9B98 File Offset: 0x001A7D98
	[CallerCount(0)]
	public unsafe void OnDrawGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A1B RID: 27163 RVA: 0x001A9BDC File Offset: 0x001A7DDC
	[CallerCount(0)]
	public unsafe void ZeroWeaponBarrel(WeaponAttachment_Sight sightToZero)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sightToZero);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_ZeroWeaponBarrel_Public_Void_WeaponAttachment_Sight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A1C RID: 27164 RVA: 0x001A9C38 File Offset: 0x001A7E38
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableByUnique_DPINetworkMessageInfo_0(Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableByUnique_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A1D RID: 27165 RVA: 0x001A9CAC File Offset: 0x001A7EAC
	[CallerCount(0)]
	public unsafe void RPC_SetLoadedAmmoType(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, byte ammoTypeByte)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ammoTypeByte;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_SetLoadedAmmoType_Public_Void_ArrayOf_DPIPlayer_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A1E RID: 27166 RVA: 0x001A9D18 File Offset: 0x001A7F18
	[CallerCount(0)]
	public unsafe void RPC_SetLoadedAmmoType(DPIPlayer invokeRpcPlayerTarget, byte ammoTypeByte)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ammoTypeByte;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_SetLoadedAmmoType_Public_Void_DPIPlayer_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A1F RID: 27167 RVA: 0x001A9D84 File Offset: 0x001A7F84
	[CallerCount(0)]
	public unsafe void RPC_SetLoadedAmmoType(RpcTarget invokeRpcTarget, byte ammoTypeByte)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ammoTypeByte;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_SetLoadedAmmoType_Public_Void_RpcTarget_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A20 RID: 27168 RVA: 0x001A9DEC File Offset: 0x001A7FEC
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique_DPINetworkMessageInfo_0(Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A21 RID: 27169 RVA: 0x001A9E60 File Offset: 0x001A8060
	[CallerCount(0)]
	public unsafe void RPC_EjectMag(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, bool doEjectAnimation, int newMagAmmo, bool isFastReload)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doEjectAnimation;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMagAmmo;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFastReload;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_EjectMag_Public_Void_ArrayOf_DPIPlayer_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A22 RID: 27170 RVA: 0x001A9EF4 File Offset: 0x001A80F4
	[CallerCount(0)]
	public unsafe void RPC_EjectMag(DPIPlayer invokeRpcPlayerTarget, bool doEjectAnimation, int newMagAmmo, bool isFastReload)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doEjectAnimation;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMagAmmo;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFastReload;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_EjectMag_Public_Void_DPIPlayer_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A23 RID: 27171 RVA: 0x001A9F88 File Offset: 0x001A8188
	[CallerCount(0)]
	public unsafe void RPC_EjectMag(RpcTarget invokeRpcTarget, bool doEjectAnimation, int newMagAmmo, bool isFastReload)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doEjectAnimation;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMagAmmo;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFastReload;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_EjectMag_Public_Void_RpcTarget_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A24 RID: 27172 RVA: 0x001AA018 File Offset: 0x001A8218
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0_DPINetworkMessageInfo_0(Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0 tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A25 RID: 27173 RVA: 0x001AA08C File Offset: 0x001A828C
	[CallerCount(0)]
	public unsafe void RPC_LaunchAlternateProjectile(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, Vector3 spawnPosition, Vector3 lookDirection, int projectileTypeId, int playerID, int AISourceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spawnPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookDirection;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectileTypeId;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerID;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_LaunchAlternateProjectile_Public_Void_ArrayOf_DPIPlayer_Vector3_Vector3_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A26 RID: 27174 RVA: 0x001AA144 File Offset: 0x001A8344
	[CallerCount(0)]
	public unsafe void RPC_LaunchAlternateProjectile(DPIPlayer invokeRpcPlayerTarget, Vector3 spawnPosition, Vector3 lookDirection, int projectileTypeId, int playerID, int AISourceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spawnPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookDirection;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectileTypeId;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerID;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_LaunchAlternateProjectile_Public_Void_DPIPlayer_Vector3_Vector3_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A27 RID: 27175 RVA: 0x001AA1FC File Offset: 0x001A83FC
	[CallerCount(0)]
	public unsafe void RPC_LaunchAlternateProjectile(RpcTarget invokeRpcTarget, Vector3 spawnPosition, Vector3 lookDirection, int projectileTypeId, int playerID, int AISourceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spawnPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookDirection;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref projectileTypeId;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerID;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_LaunchAlternateProjectile_Public_Void_RpcTarget_Vector3_Vector3_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A28 RID: 27176 RVA: 0x001AA2B0 File Offset: 0x001A84B0
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1_DPINetworkMessageInfo_0(Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1 tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A29 RID: 27177 RVA: 0x001AA324 File Offset: 0x001A8524
	[CallerCount(0)]
	public unsafe void RPC_LaunchProjectile(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, Vector3 spawnPosition, Vector3 lookDirection, int ammoID, int playerID, int AISourceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spawnPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookDirection;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ammoID;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerID;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_LaunchProjectile_Public_Void_ArrayOf_DPIPlayer_Vector3_Vector3_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A2A RID: 27178 RVA: 0x001AA3DC File Offset: 0x001A85DC
	[CallerCount(0)]
	public unsafe void RPC_LaunchProjectile(DPIPlayer invokeRpcPlayerTarget, Vector3 spawnPosition, Vector3 lookDirection, int ammoID, int playerID, int AISourceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spawnPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookDirection;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ammoID;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerID;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_LaunchProjectile_Public_Void_DPIPlayer_Vector3_Vector3_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A2B RID: 27179 RVA: 0x001AA494 File Offset: 0x001A8694
	[CallerCount(0)]
	public unsafe void RPC_LaunchProjectile(RpcTarget invokeRpcTarget, Vector3 spawnPosition, Vector3 lookDirection, int ammoID, int playerID, int AISourceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spawnPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lookDirection;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ammoID;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerID;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_LaunchProjectile_Public_Void_RpcTarget_Vector3_Vector3_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A2C RID: 27180 RVA: 0x001AA548 File Offset: 0x001A8748
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoUnique_DPINetworkMessageInfo_0(Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoUnique_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A2D RID: 27181 RVA: 0x001AA5BC File Offset: 0x001A87BC
	[CallerCount(0)]
	public unsafe void RPC_HideMagazine(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, bool hidden)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hidden;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_HideMagazine_Public_Void_ArrayOf_DPIPlayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A2E RID: 27182 RVA: 0x001AA628 File Offset: 0x001A8828
	[CallerCount(0)]
	public unsafe void RPC_HideMagazine(DPIPlayer invokeRpcPlayerTarget, bool hidden)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hidden;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_HideMagazine_Public_Void_DPIPlayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A2F RID: 27183 RVA: 0x001AA694 File Offset: 0x001A8894
	[CallerCount(0)]
	public unsafe void RPC_HideMagazine(RpcTarget invokeRpcTarget, bool hidden)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hidden;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_HideMagazine_Public_Void_RpcTarget_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A30 RID: 27184 RVA: 0x001AA6FC File Offset: 0x001A88FC
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInUnique_DPINetworkMessageInfo_0(Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tmp));
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInUnique_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A31 RID: 27185 RVA: 0x001AA778 File Offset: 0x001A8978
	[CallerCount(0)]
	public unsafe void RPC_ByteWrapper_Alloc_SetAttachments(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, Il2CppStructArray<int> attachmentTypes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attachmentTypes);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_ByteWrapper_Alloc_SetAttachments_Public_Void_ArrayOf_DPIPlayer_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A32 RID: 27186 RVA: 0x001AA7EC File Offset: 0x001A89EC
	[CallerCount(0)]
	public unsafe void RPC_ByteWrapper_Alloc_SetAttachments(DPIPlayer invokeRpcPlayerTarget, Il2CppStructArray<int> attachmentTypes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attachmentTypes);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_ByteWrapper_Alloc_SetAttachments_Public_Void_DPIPlayer_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A33 RID: 27187 RVA: 0x001AA860 File Offset: 0x001A8A60
	[CallerCount(0)]
	public unsafe void RPC_ByteWrapper_Alloc_SetAttachments(RpcTarget invokeRpcTarget, Il2CppStructArray<int> attachmentTypes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attachmentTypes);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_ByteWrapper_Alloc_SetAttachments_Public_Void_RpcTarget_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A34 RID: 27188 RVA: 0x001AA8CC File Offset: 0x001A8ACC
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0_DPINetworkMessageInfo_0(Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0 tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A35 RID: 27189 RVA: 0x001AA940 File Offset: 0x001A8B40
	[CallerCount(0)]
	public unsafe void RPC_LaserStatus(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, int newStatus, bool playSound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_LaserStatus_Public_Void_ArrayOf_DPIPlayer_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A36 RID: 27190 RVA: 0x001AA9C0 File Offset: 0x001A8BC0
	[CallerCount(0)]
	public unsafe void RPC_LaserStatus(DPIPlayer invokeRpcPlayerTarget, int newStatus, bool playSound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_LaserStatus_Public_Void_DPIPlayer_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A37 RID: 27191 RVA: 0x001AAA40 File Offset: 0x001A8C40
	[CallerCount(0)]
	public unsafe void RPC_LaserStatus(RpcTarget invokeRpcTarget, int newStatus, bool playSound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_LaserStatus_Public_Void_RpcTarget_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A38 RID: 27192 RVA: 0x001AAABC File Offset: 0x001A8CBC
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1_DPINetworkMessageInfo_0(Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1 tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A39 RID: 27193 RVA: 0x001AAB30 File Offset: 0x001A8D30
	[CallerCount(0)]
	public unsafe void RPC_FlashLightStatus(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, int newStatus, bool playSound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_FlashLightStatus_Public_Void_ArrayOf_DPIPlayer_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A3A RID: 27194 RVA: 0x001AABB0 File Offset: 0x001A8DB0
	[CallerCount(0)]
	public unsafe void RPC_FlashLightStatus(DPIPlayer invokeRpcPlayerTarget, int newStatus, bool playSound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_FlashLightStatus_Public_Void_DPIPlayer_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A3B RID: 27195 RVA: 0x001AAC30 File Offset: 0x001A8E30
	[CallerCount(0)]
	public unsafe void RPC_FlashLightStatus(RpcTarget invokeRpcTarget, int newStatus, bool playSound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playSound;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr_RPC_FlashLightStatus_Public_Void_RpcTarget_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A3C RID: 27196 RVA: 0x001AACAC File Offset: 0x001A8EAC
	[CallerCount(0)]
	public new unsafe void OnCodeGenInitializeHook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Weapon.NativeMethodInfoPtr_OnCodeGenInitializeHook_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A3D RID: 27197 RVA: 0x001AACFC File Offset: 0x001A8EFC
	[CallerCount(0)]
	public unsafe Weapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Weapon>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006A3E RID: 27198 RVA: 0x001AAD48 File Offset: 0x001A8F48
	// Note: this type is marked as 'beforefieldinit'.
	static Weapon()
	{
		Il2CppClassPointerStore<Weapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Weapon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Weapon>.NativeClassPtr);
		Weapon.NativeFieldInfoPtr_WeaponSO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "WeaponSO");
		Weapon.NativeFieldInfoPtr_AttachmentManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "AttachmentManager");
		Weapon.NativeFieldInfoPtr_AnimControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "AnimControl");
		Weapon.NativeFieldInfoPtr_MagChildPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "MagChildPosition");
		Weapon.NativeFieldInfoPtr_EjectDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "EjectDown");
		Weapon.NativeFieldInfoPtr_ChamberBullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "ChamberBullet");
		Weapon.NativeFieldInfoPtr_projectileSpawnSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "projectileSpawnSpot");
		Weapon.NativeFieldInfoPtr_StockEndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "StockEndPos");
		Weapon.NativeFieldInfoPtr_CollisionParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "CollisionParent");
		Weapon.NativeFieldInfoPtr_m_GunScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "m_GunScript");
		Weapon.NativeFieldInfoPtr_m_SoundScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "m_SoundScript");
		Weapon.NativeFieldInfoPtr_m_Pickup_Gun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "m_Pickup_Gun");
		Weapon.NativeFieldInfoPtr_m_spectateLineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "m_spectateLineRenderer");
		Weapon.NativeFieldInfoPtr_OwnerDamageController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "OwnerDamageController");
		Weapon.NativeFieldInfoPtr_fireSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "fireSelector");
		Weapon.NativeFieldInfoPtr_lmgFeedTrayCover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "lmgFeedTrayCover");
		Weapon.NativeFieldInfoPtr_LaserState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "LaserState");
		Weapon.NativeFieldInfoPtr_FlashlightState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "FlashlightState");
		Weapon.NativeFieldInfoPtr_LastReloadWasFastReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "LastReloadWasFastReload");
		Weapon.NativeFieldInfoPtr_LoadedAlternateAmmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "LoadedAlternateAmmo");
		Weapon.NativeFieldInfoPtr_LastMagUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "LastMagUnloaded");
		Weapon.NativeFieldInfoPtr_ActualROF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "ActualROF");
		Weapon.NativeFieldInfoPtr_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Velocity");
		Weapon.NativeFieldInfoPtr_RotationalVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "RotationalVelocity");
		Weapon.NativeFieldInfoPtr_PhysicsColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "PhysicsColliders");
		Weapon.NativeFieldInfoPtr_CurrentMagazine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "CurrentMagazine");
		Weapon.NativeFieldInfoPtr_LastMagazine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "LastMagazine");
		Weapon.NativeFieldInfoPtr_WeaponData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "WeaponData");
		Weapon.NativeFieldInfoPtr_AlternateFireSoundPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "AlternateFireSoundPlayEvent");
		Weapon.NativeFieldInfoPtr__firingLineLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_firingLineLayerMask");
		Weapon.NativeFieldInfoPtr__hasInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_hasInit");
		Weapon.NativeFieldInfoPtr__roundsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_roundsLoaded");
		Weapon.NativeFieldInfoPtr__burstCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_burstCounter");
		Weapon.NativeFieldInfoPtr__bulletsUntilTracer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_bulletsUntilTracer");
		Weapon.NativeFieldInfoPtr__aiSemiRof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_aiSemiRof");
		Weapon.NativeFieldInfoPtr__timeSinceLastFired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_timeSinceLastFired");
		Weapon.NativeFieldInfoPtr__shotSpreadAngleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_shotSpreadAngleMin");
		Weapon.NativeFieldInfoPtr__shotSpreadAngleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_shotSpreadAngleMax");
		Weapon.NativeFieldInfoPtr__maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_maxDistance");
		Weapon.NativeFieldInfoPtr__burstTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_burstTimer");
		Weapon.NativeFieldInfoPtr__damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_damage");
		Weapon.NativeFieldInfoPtr__burstPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_burstPause");
		Weapon.NativeFieldInfoPtr__lastRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_lastRotation");
		Weapon.NativeFieldInfoPtr__lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_lastPosition");
		Weapon.NativeFieldInfoPtr__chamberBulletGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_chamberBulletGameObject");
		Weapon.NativeFieldInfoPtr__thisTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_thisTransform");
		Weapon.NativeFieldInfoPtr__pickupShotgun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_pickupShotgun");
		Weapon.NativeFieldInfoPtr__projectileDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_projectileDefinition");
		Weapon.NativeFieldInfoPtr__loadedAmmoType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_loadedAmmoType");
		Weapon.NativeFieldInfoPtr__firedProjectiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "_firedProjectiles");
		Weapon.NativeFieldInfoPtr_SHOT_SPREAD_ANGLE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "SHOT_SPREAD_ANGLE_MULTIPLIER");
		Weapon.NativeFieldInfoPtr_INT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "INT_SIZE");
		Weapon.NativeFieldInfoPtr_MagInserted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "MagInserted");
		Weapon.NativeFieldInfoPtr_Fired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Fired");
		Weapon.NativeFieldInfoPtr__isTentItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "<isTentItem>k__BackingField");
		Weapon.NativeFieldInfoPtr_DBG_ENABLE_CAM_CHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "DBG_ENABLE_CAM_CHANGE");
		Weapon.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "<ManagedUpdateRemoval>k__BackingField");
		Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableByUnique_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_H_RPC_SetLoadedAmmoType");
		Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_H_RPC_EjectMag");
		Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_H_RPC_LaunchAlternateProjectile");
		Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_H_RPC_LaunchProjectile");
		Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoUnique_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_H_RPC_HideMagazine");
		Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInUnique_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_H_RPC_ByteWrapper_Alloc_SetAttachments");
		Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_H_RPC_LaserStatus");
		Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_H_RPC_FlashLightStatus");
		Weapon.NativeMethodInfoPtr_add_Fired_Public_add_Void_Action_2_DPIPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671656);
		Weapon.NativeMethodInfoPtr_remove_Fired_Public_rem_Void_Action_2_DPIPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671657);
		Weapon.NativeMethodInfoPtr_get_isTentItem_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671658);
		Weapon.NativeMethodInfoPtr_set_isTentItem_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671659);
		Weapon.NativeMethodInfoPtr_get_CanDropMagFree_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671660);
		Weapon.NativeMethodInfoPtr_get_IsShotgunWeaponType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671661);
		Weapon.NativeMethodInfoPtr_get_IsLightMachineGunWeaponType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671662);
		Weapon.NativeMethodInfoPtr_get_IsLauncherWeaponType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671663);
		Weapon.NativeMethodInfoPtr_get_IsBoltActionWeaponType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671664);
		Weapon.NativeMethodInfoPtr_get_IsPistolWeaponType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671665);
		Weapon.NativeMethodInfoPtr_get_IsLightMachineGunTopAtTop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671666);
		Weapon.NativeMethodInfoPtr_get_IsLightMachineGunTopClosed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671667);
		Weapon.NativeMethodInfoPtr_get_LoadingCapacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671668);
		Weapon.NativeMethodInfoPtr_get_BurstRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671669);
		Weapon.NativeMethodInfoPtr_get_MuzzleVelocity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671670);
		Weapon.NativeMethodInfoPtr_get_ShotSpreadAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671671);
		Weapon.NativeMethodInfoPtr_get_cleanupProjectilesWithGun_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671672);
		Weapon.NativeMethodInfoPtr_get_doesEjectShells_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671673);
		Weapon.NativeMethodInfoPtr_get_AISemiAutoRoundsPerSecond_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671674);
		Weapon.NativeMethodInfoPtr_get_StartWithMag_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671675);
		Weapon.NativeMethodInfoPtr_get_usesSubSonicRounds_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671676);
		Weapon.NativeMethodInfoPtr_get_rateOfFire_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671677);
		Weapon.NativeMethodInfoPtr_get_ProjectileType_Private_get_ProjectileID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671678);
		Weapon.NativeMethodInfoPtr_get_CurrentAmmo_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671679);
		Weapon.NativeMethodInfoPtr_get_AmmoPercentage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671680);
		Weapon.NativeMethodInfoPtr_get_RoundsLoaded_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671681);
		Weapon.NativeMethodInfoPtr_set_RoundsLoaded_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671682);
		Weapon.NativeMethodInfoPtr_get_LoadedAmmoType_Public_get_AmmoType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671683);
		Weapon.NativeMethodInfoPtr_set_LoadedAmmoType_Public_set_Void_AmmoType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671684);
		Weapon.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671685);
		Weapon.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671686);
		Weapon.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671687);
		Weapon.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671688);
		Weapon.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671689);
		Weapon.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671690);
		Weapon.NativeMethodInfoPtr_ToggleChamberedRound_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671691);
		Weapon.NativeMethodInfoPtr_SpawnAndInsertMagazine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671692);
		Weapon.NativeMethodInfoPtr_OverrideAmmoType_Public_Void_AmmoType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671693);
		Weapon.NativeMethodInfoPtr_FlagAsInTentItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671694);
		Weapon.NativeMethodInfoPtr_SpawnLoadoutTableMagazine_Public_Pickup_Magazine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671695);
		Weapon.NativeMethodInfoPtr_RPC_SetLoadedAmmoType_Public_Void_Byte_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671696);
		Weapon.NativeMethodInfoPtr_ToggleCamChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671697);
		Weapon.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671698);
		Weapon.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671699);
		Weapon.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671700);
		Weapon.NativeMethodInfoPtr_SpectatingAndDebugging_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671701);
		Weapon.NativeMethodInfoPtr_UpdateWeaponTimer_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671702);
		Weapon.NativeMethodInfoPtr_InsertMag_Public_Void_Pickup_Magazine_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671703);
		Weapon.NativeMethodInfoPtr_PulledMagOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671704);
		Weapon.NativeMethodInfoPtr_EjectMagazine_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671705);
		Weapon.NativeMethodInfoPtr_RPC_EjectMag_Public_Void_Boolean_Int32_Boolean_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671706);
		Weapon.NativeMethodInfoPtr_CanFire_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671707);
		Weapon.NativeMethodInfoPtr_CanFireAI_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671708);
		Weapon.NativeMethodInfoPtr_AIFireWeapon_Public_Void_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671709);
		Weapon.NativeMethodInfoPtr_AIReload_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671710);
		Weapon.NativeMethodInfoPtr_LaunchAlternateProjectile_Public_Void_Vector3_Vector3_Int32_DPIPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671711);
		Weapon.NativeMethodInfoPtr_RPC_LaunchAlternateProjectile_Public_Void_Vector3_Vector3_Int32_Int32_Int32_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671712);
		Weapon.NativeMethodInfoPtr_FireWeapon_Public_Void_DPIPlayer_Nullable_1_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671713);
		Weapon.NativeMethodInfoPtr_DeductAmmo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671714);
		Weapon.NativeMethodInfoPtr_RPC_LaunchProjectile_Public_Void_Vector3_Vector3_Int32_Int32_Int32_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671715);
		Weapon.NativeMethodInfoPtr_HideMagazine_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671716);
		Weapon.NativeMethodInfoPtr_RPC_HideMagazine_Public_Void_Boolean_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671717);
		Weapon.NativeMethodInfoPtr_LaunchProjectile_Private_Void_Vector3_Quaternion_ProjectileID_AmmoType_OnwardPhotonPlayer_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671718);
		Weapon.NativeMethodInfoPtr_FireAlert_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671719);
		Weapon.NativeMethodInfoPtr_LoadRound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671720);
		Weapon.NativeMethodInfoPtr_EjectUnspentBullet_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671721);
		Weapon.NativeMethodInfoPtr_EjectCasing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671722);
		Weapon.NativeMethodInfoPtr_RPC_ByteWrapper_Alloc_SetAttachments_Public_Void_ArrayOf_Int32_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671723);
		Weapon.NativeMethodInfoPtr_InvokeSetAttachmentsRPC_Public_Void_ArrayOf_AttachmentType_RpcTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671724);
		Weapon.NativeMethodInfoPtr_SetAttachmentsRPC_Public_Void_ArrayOf_AttachmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671725);
		Weapon.NativeMethodInfoPtr_GetSightToZero_Public_WeaponAttachment_Sight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671726);
		Weapon.NativeMethodInfoPtr_SetLaser_Public_Void_WeaponAttachmentToggleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671727);
		Weapon.NativeMethodInfoPtr_SetFlashlight_Public_Void_WeaponAttachmentToggleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671728);
		Weapon.NativeMethodInfoPtr_ToggleLaser_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671729);
		Weapon.NativeMethodInfoPtr_ToggleFlashlight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671730);
		Weapon.NativeMethodInfoPtr_RPC_LaserStatus_Public_Void_Int32_Boolean_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671731);
		Weapon.NativeMethodInfoPtr_RefreshLaserClientSide_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671732);
		Weapon.NativeMethodInfoPtr_RPC_FlashLightStatus_Public_Void_Int32_Boolean_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671733);
		Weapon.NativeMethodInfoPtr_RefreshFlashlightClientSide_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671734);
		Weapon.NativeMethodInfoPtr_RefreshInteractableAttachmentsSilently_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671735);
		Weapon.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671736);
		Weapon.NativeMethodInfoPtr_ZeroWeaponBarrel_Public_Void_WeaponAttachment_Sight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671737);
		Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableByUnique_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671738);
		Weapon.NativeMethodInfoPtr_RPC_SetLoadedAmmoType_Public_Void_ArrayOf_DPIPlayer_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671739);
		Weapon.NativeMethodInfoPtr_RPC_SetLoadedAmmoType_Public_Void_DPIPlayer_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671740);
		Weapon.NativeMethodInfoPtr_RPC_SetLoadedAmmoType_Public_Void_RpcTarget_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671741);
		Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671742);
		Weapon.NativeMethodInfoPtr_RPC_EjectMag_Public_Void_ArrayOf_DPIPlayer_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671743);
		Weapon.NativeMethodInfoPtr_RPC_EjectMag_Public_Void_DPIPlayer_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671744);
		Weapon.NativeMethodInfoPtr_RPC_EjectMag_Public_Void_RpcTarget_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671745);
		Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671746);
		Weapon.NativeMethodInfoPtr_RPC_LaunchAlternateProjectile_Public_Void_ArrayOf_DPIPlayer_Vector3_Vector3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671747);
		Weapon.NativeMethodInfoPtr_RPC_LaunchAlternateProjectile_Public_Void_DPIPlayer_Vector3_Vector3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671748);
		Weapon.NativeMethodInfoPtr_RPC_LaunchAlternateProjectile_Public_Void_RpcTarget_Vector3_Vector3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671749);
		Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671750);
		Weapon.NativeMethodInfoPtr_RPC_LaunchProjectile_Public_Void_ArrayOf_DPIPlayer_Vector3_Vector3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671751);
		Weapon.NativeMethodInfoPtr_RPC_LaunchProjectile_Public_Void_DPIPlayer_Vector3_Vector3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671752);
		Weapon.NativeMethodInfoPtr_RPC_LaunchProjectile_Public_Void_RpcTarget_Vector3_Vector3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671753);
		Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoUnique_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671754);
		Weapon.NativeMethodInfoPtr_RPC_HideMagazine_Public_Void_ArrayOf_DPIPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671755);
		Weapon.NativeMethodInfoPtr_RPC_HideMagazine_Public_Void_DPIPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671756);
		Weapon.NativeMethodInfoPtr_RPC_HideMagazine_Public_Void_RpcTarget_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671757);
		Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInUnique_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671758);
		Weapon.NativeMethodInfoPtr_RPC_ByteWrapper_Alloc_SetAttachments_Public_Void_ArrayOf_DPIPlayer_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671759);
		Weapon.NativeMethodInfoPtr_RPC_ByteWrapper_Alloc_SetAttachments_Public_Void_DPIPlayer_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671760);
		Weapon.NativeMethodInfoPtr_RPC_ByteWrapper_Alloc_SetAttachments_Public_Void_RpcTarget_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671761);
		Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671762);
		Weapon.NativeMethodInfoPtr_RPC_LaserStatus_Public_Void_ArrayOf_DPIPlayer_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671763);
		Weapon.NativeMethodInfoPtr_RPC_LaserStatus_Public_Void_DPIPlayer_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671764);
		Weapon.NativeMethodInfoPtr_RPC_LaserStatus_Public_Void_RpcTarget_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671765);
		Weapon.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671766);
		Weapon.NativeMethodInfoPtr_RPC_FlashLightStatus_Public_Void_ArrayOf_DPIPlayer_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671767);
		Weapon.NativeMethodInfoPtr_RPC_FlashLightStatus_Public_Void_DPIPlayer_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671768);
		Weapon.NativeMethodInfoPtr_RPC_FlashLightStatus_Public_Void_RpcTarget_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671769);
		Weapon.NativeMethodInfoPtr_OnCodeGenInitializeHook_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671770);
		Weapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon>.NativeClassPtr, 100671771);
	}

	// Token: 0x06006A3F RID: 27199 RVA: 0x00047530 File Offset: 0x00045730
	public Weapon(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170025A2 RID: 9634
	// (get) Token: 0x06006A40 RID: 27200 RVA: 0x001ABB9C File Offset: 0x001A9D9C
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Weapon>.NativeClassPtr));
		}
	}

	// Token: 0x170025A3 RID: 9635
	// (get) Token: 0x06006A41 RID: 27201 RVA: 0x001ABBB0 File Offset: 0x001A9DB0
	// (set) Token: 0x06006A42 RID: 27202 RVA: 0x001ABBE4 File Offset: 0x001A9DE4
	public unsafe WeaponSO WeaponSO
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_WeaponSO);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WeaponSO(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_WeaponSO), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025A4 RID: 9636
	// (get) Token: 0x06006A43 RID: 27203 RVA: 0x001ABC0C File Offset: 0x001A9E0C
	// (set) Token: 0x06006A44 RID: 27204 RVA: 0x001ABC40 File Offset: 0x001A9E40
	public unsafe AttachmentManager AttachmentManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_AttachmentManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AttachmentManager(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_AttachmentManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025A5 RID: 9637
	// (get) Token: 0x06006A45 RID: 27205 RVA: 0x001ABC68 File Offset: 0x001A9E68
	// (set) Token: 0x06006A46 RID: 27206 RVA: 0x001ABC9C File Offset: 0x001A9E9C
	public unsafe WeaponAnimator AnimControl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_AnimControl);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WeaponAnimator(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_AnimControl), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025A6 RID: 9638
	// (get) Token: 0x06006A47 RID: 27207 RVA: 0x001ABCC4 File Offset: 0x001A9EC4
	// (set) Token: 0x06006A48 RID: 27208 RVA: 0x001ABCF8 File Offset: 0x001A9EF8
	public unsafe Transform MagChildPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_MagChildPosition);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_MagChildPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025A7 RID: 9639
	// (get) Token: 0x06006A49 RID: 27209 RVA: 0x001ABD20 File Offset: 0x001A9F20
	// (set) Token: 0x06006A4A RID: 27210 RVA: 0x001ABD54 File Offset: 0x001A9F54
	public unsafe Transform EjectDown
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_EjectDown);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_EjectDown), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025A8 RID: 9640
	// (get) Token: 0x06006A4B RID: 27211 RVA: 0x001ABD7C File Offset: 0x001A9F7C
	// (set) Token: 0x06006A4C RID: 27212 RVA: 0x001ABDB0 File Offset: 0x001A9FB0
	public unsafe ChamberBullet ChamberBullet
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_ChamberBullet);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new ChamberBullet(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_ChamberBullet), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025A9 RID: 9641
	// (get) Token: 0x06006A4D RID: 27213 RVA: 0x001ABDD8 File Offset: 0x001A9FD8
	// (set) Token: 0x06006A4E RID: 27214 RVA: 0x001ABE0C File Offset: 0x001AA00C
	public unsafe Transform projectileSpawnSpot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_projectileSpawnSpot);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_projectileSpawnSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025AA RID: 9642
	// (get) Token: 0x06006A4F RID: 27215 RVA: 0x001ABE34 File Offset: 0x001AA034
	// (set) Token: 0x06006A50 RID: 27216 RVA: 0x001ABE68 File Offset: 0x001AA068
	public unsafe Transform StockEndPos
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_StockEndPos);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_StockEndPos), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025AB RID: 9643
	// (get) Token: 0x06006A51 RID: 27217 RVA: 0x001ABE90 File Offset: 0x001AA090
	// (set) Token: 0x06006A52 RID: 27218 RVA: 0x001ABEC4 File Offset: 0x001AA0C4
	public unsafe Transform CollisionParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_CollisionParent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_CollisionParent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025AC RID: 9644
	// (get) Token: 0x06006A53 RID: 27219 RVA: 0x001ABEEC File Offset: 0x001AA0EC
	// (set) Token: 0x06006A54 RID: 27220 RVA: 0x001ABF20 File Offset: 0x001AA120
	public unsafe WeaponVisuals m_GunScript
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_m_GunScript);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WeaponVisuals(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_m_GunScript), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025AD RID: 9645
	// (get) Token: 0x06006A55 RID: 27221 RVA: 0x001ABF48 File Offset: 0x001AA148
	// (set) Token: 0x06006A56 RID: 27222 RVA: 0x001ABF7C File Offset: 0x001AA17C
	public unsafe WeaponSounds m_SoundScript
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_m_SoundScript);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WeaponSounds(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_m_SoundScript), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025AE RID: 9646
	// (get) Token: 0x06006A57 RID: 27223 RVA: 0x001ABFA4 File Offset: 0x001AA1A4
	// (set) Token: 0x06006A58 RID: 27224 RVA: 0x001ABFD8 File Offset: 0x001AA1D8
	public unsafe Pickup_Gun m_Pickup_Gun
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_m_Pickup_Gun);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Pickup_Gun(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_m_Pickup_Gun), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025AF RID: 9647
	// (get) Token: 0x06006A59 RID: 27225 RVA: 0x001AC000 File Offset: 0x001AA200
	// (set) Token: 0x06006A5A RID: 27226 RVA: 0x001AC034 File Offset: 0x001AA234
	public unsafe LineRenderer m_spectateLineRenderer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_m_spectateLineRenderer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new LineRenderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_m_spectateLineRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025B0 RID: 9648
	// (get) Token: 0x06006A5B RID: 27227 RVA: 0x001AC05C File Offset: 0x001AA25C
	// (set) Token: 0x06006A5C RID: 27228 RVA: 0x001AC090 File Offset: 0x001AA290
	public unsafe DamageController OwnerDamageController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_OwnerDamageController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new DamageController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_OwnerDamageController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025B1 RID: 9649
	// (get) Token: 0x06006A5D RID: 27229 RVA: 0x001AC0B8 File Offset: 0x001AA2B8
	// (set) Token: 0x06006A5E RID: 27230 RVA: 0x001AC0EC File Offset: 0x001AA2EC
	public unsafe FireSelector fireSelector
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_fireSelector);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new FireSelector(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_fireSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025B2 RID: 9650
	// (get) Token: 0x06006A5F RID: 27231 RVA: 0x001AC114 File Offset: 0x001AA314
	// (set) Token: 0x06006A60 RID: 27232 RVA: 0x001AC148 File Offset: 0x001AA348
	public unsafe Interactable_LMGFeedTrayCover lmgFeedTrayCover
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_lmgFeedTrayCover);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Interactable_LMGFeedTrayCover(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_lmgFeedTrayCover), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025B3 RID: 9651
	// (get) Token: 0x06006A61 RID: 27233 RVA: 0x001AC170 File Offset: 0x001AA370
	// (set) Token: 0x06006A62 RID: 27234 RVA: 0x001AC198 File Offset: 0x001AA398
	public unsafe WeaponAttachmentToggleState LaserState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_LaserState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_LaserState)) = value;
		}
	}

	// Token: 0x170025B4 RID: 9652
	// (get) Token: 0x06006A63 RID: 27235 RVA: 0x001AC1BC File Offset: 0x001AA3BC
	// (set) Token: 0x06006A64 RID: 27236 RVA: 0x001AC1E4 File Offset: 0x001AA3E4
	public unsafe WeaponAttachmentToggleState FlashlightState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_FlashlightState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_FlashlightState)) = value;
		}
	}

	// Token: 0x170025B5 RID: 9653
	// (get) Token: 0x06006A65 RID: 27237 RVA: 0x001AC208 File Offset: 0x001AA408
	// (set) Token: 0x06006A66 RID: 27238 RVA: 0x001AC230 File Offset: 0x001AA430
	public unsafe bool LastReloadWasFastReload
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_LastReloadWasFastReload);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_LastReloadWasFastReload)) = value;
		}
	}

	// Token: 0x170025B6 RID: 9654
	// (get) Token: 0x06006A67 RID: 27239 RVA: 0x001AC254 File Offset: 0x001AA454
	// (set) Token: 0x06006A68 RID: 27240 RVA: 0x001AC27C File Offset: 0x001AA47C
	public unsafe int LoadedAlternateAmmo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_LoadedAlternateAmmo);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_LoadedAlternateAmmo)) = value;
		}
	}

	// Token: 0x170025B7 RID: 9655
	// (get) Token: 0x06006A69 RID: 27241 RVA: 0x001AC2A0 File Offset: 0x001AA4A0
	// (set) Token: 0x06006A6A RID: 27242 RVA: 0x001AC2C8 File Offset: 0x001AA4C8
	public unsafe float LastMagUnloaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_LastMagUnloaded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_LastMagUnloaded)) = value;
		}
	}

	// Token: 0x170025B8 RID: 9656
	// (get) Token: 0x06006A6B RID: 27243 RVA: 0x001AC2EC File Offset: 0x001AA4EC
	// (set) Token: 0x06006A6C RID: 27244 RVA: 0x001AC314 File Offset: 0x001AA514
	public unsafe float ActualROF
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_ActualROF);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_ActualROF)) = value;
		}
	}

	// Token: 0x170025B9 RID: 9657
	// (get) Token: 0x06006A6D RID: 27245 RVA: 0x001AC338 File Offset: 0x001AA538
	// (set) Token: 0x06006A6E RID: 27246 RVA: 0x001AC360 File Offset: 0x001AA560
	public unsafe Vector3 Velocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_Velocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_Velocity)) = value;
		}
	}

	// Token: 0x170025BA RID: 9658
	// (get) Token: 0x06006A6F RID: 27247 RVA: 0x001AC384 File Offset: 0x001AA584
	// (set) Token: 0x06006A70 RID: 27248 RVA: 0x001AC3AC File Offset: 0x001AA5AC
	public unsafe Vector3 RotationalVelocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_RotationalVelocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_RotationalVelocity)) = value;
		}
	}

	// Token: 0x170025BB RID: 9659
	// (get) Token: 0x06006A71 RID: 27249 RVA: 0x001AC3D0 File Offset: 0x001AA5D0
	// (set) Token: 0x06006A72 RID: 27250 RVA: 0x001AC404 File Offset: 0x001AA604
	public unsafe Il2CppReferenceArray<Collider> PhysicsColliders
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_PhysicsColliders);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<Collider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_PhysicsColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025BC RID: 9660
	// (get) Token: 0x06006A73 RID: 27251 RVA: 0x001AC42C File Offset: 0x001AA62C
	// (set) Token: 0x06006A74 RID: 27252 RVA: 0x001AC460 File Offset: 0x001AA660
	public unsafe Pickup_Magazine CurrentMagazine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_CurrentMagazine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Pickup_Magazine(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_CurrentMagazine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025BD RID: 9661
	// (get) Token: 0x06006A75 RID: 27253 RVA: 0x001AC488 File Offset: 0x001AA688
	// (set) Token: 0x06006A76 RID: 27254 RVA: 0x001AC4BC File Offset: 0x001AA6BC
	public unsafe Pickup_Magazine LastMagazine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_LastMagazine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Pickup_Magazine(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_LastMagazine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025BE RID: 9662
	// (get) Token: 0x06006A77 RID: 27255 RVA: 0x001AC4E4 File Offset: 0x001AA6E4
	// (set) Token: 0x06006A78 RID: 27256 RVA: 0x001AC518 File Offset: 0x001AA718
	public unsafe WeaponData WeaponData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_WeaponData);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WeaponData(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_WeaponData), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025BF RID: 9663
	// (get) Token: 0x06006A79 RID: 27257 RVA: 0x001AC540 File Offset: 0x001AA740
	// (set) Token: 0x06006A7A RID: 27258 RVA: 0x001AC574 File Offset: 0x001AA774
	public unsafe AK.Wwise.Event AlternateFireSoundPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_AlternateFireSoundPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_AlternateFireSoundPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025C0 RID: 9664
	// (get) Token: 0x06006A7B RID: 27259 RVA: 0x001AC59C File Offset: 0x001AA79C
	// (set) Token: 0x06006A7C RID: 27260 RVA: 0x001AC5BA File Offset: 0x001AA7BA
	public unsafe static int _firingLineLayerMask
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(Weapon.NativeFieldInfoPtr__firingLineLayerMask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Weapon.NativeFieldInfoPtr__firingLineLayerMask, (void*)(&value));
		}
	}

	// Token: 0x170025C1 RID: 9665
	// (get) Token: 0x06006A7D RID: 27261 RVA: 0x001AC5CC File Offset: 0x001AA7CC
	// (set) Token: 0x06006A7E RID: 27262 RVA: 0x001AC5F4 File Offset: 0x001AA7F4
	public unsafe bool _hasInit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__hasInit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__hasInit)) = value;
		}
	}

	// Token: 0x170025C2 RID: 9666
	// (get) Token: 0x06006A7F RID: 27263 RVA: 0x001AC618 File Offset: 0x001AA818
	// (set) Token: 0x06006A80 RID: 27264 RVA: 0x001AC640 File Offset: 0x001AA840
	public unsafe int _roundsLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__roundsLoaded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__roundsLoaded)) = value;
		}
	}

	// Token: 0x170025C3 RID: 9667
	// (get) Token: 0x06006A81 RID: 27265 RVA: 0x001AC664 File Offset: 0x001AA864
	// (set) Token: 0x06006A82 RID: 27266 RVA: 0x001AC68C File Offset: 0x001AA88C
	public unsafe int _burstCounter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__burstCounter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__burstCounter)) = value;
		}
	}

	// Token: 0x170025C4 RID: 9668
	// (get) Token: 0x06006A83 RID: 27267 RVA: 0x001AC6B0 File Offset: 0x001AA8B0
	// (set) Token: 0x06006A84 RID: 27268 RVA: 0x001AC6D8 File Offset: 0x001AA8D8
	public unsafe int _bulletsUntilTracer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__bulletsUntilTracer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__bulletsUntilTracer)) = value;
		}
	}

	// Token: 0x170025C5 RID: 9669
	// (get) Token: 0x06006A85 RID: 27269 RVA: 0x001AC6FC File Offset: 0x001AA8FC
	// (set) Token: 0x06006A86 RID: 27270 RVA: 0x001AC724 File Offset: 0x001AA924
	public unsafe float _aiSemiRof
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__aiSemiRof);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__aiSemiRof)) = value;
		}
	}

	// Token: 0x170025C6 RID: 9670
	// (get) Token: 0x06006A87 RID: 27271 RVA: 0x001AC748 File Offset: 0x001AA948
	// (set) Token: 0x06006A88 RID: 27272 RVA: 0x001AC770 File Offset: 0x001AA970
	public unsafe float _timeSinceLastFired
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__timeSinceLastFired);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__timeSinceLastFired)) = value;
		}
	}

	// Token: 0x170025C7 RID: 9671
	// (get) Token: 0x06006A89 RID: 27273 RVA: 0x001AC794 File Offset: 0x001AA994
	// (set) Token: 0x06006A8A RID: 27274 RVA: 0x001AC7BC File Offset: 0x001AA9BC
	public unsafe float _shotSpreadAngleMin
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__shotSpreadAngleMin);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__shotSpreadAngleMin)) = value;
		}
	}

	// Token: 0x170025C8 RID: 9672
	// (get) Token: 0x06006A8B RID: 27275 RVA: 0x001AC7E0 File Offset: 0x001AA9E0
	// (set) Token: 0x06006A8C RID: 27276 RVA: 0x001AC808 File Offset: 0x001AAA08
	public unsafe float _shotSpreadAngleMax
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__shotSpreadAngleMax);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__shotSpreadAngleMax)) = value;
		}
	}

	// Token: 0x170025C9 RID: 9673
	// (get) Token: 0x06006A8D RID: 27277 RVA: 0x001AC82C File Offset: 0x001AAA2C
	// (set) Token: 0x06006A8E RID: 27278 RVA: 0x001AC854 File Offset: 0x001AAA54
	public unsafe float _maxDistance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__maxDistance);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__maxDistance)) = value;
		}
	}

	// Token: 0x170025CA RID: 9674
	// (get) Token: 0x06006A8F RID: 27279 RVA: 0x001AC878 File Offset: 0x001AAA78
	// (set) Token: 0x06006A90 RID: 27280 RVA: 0x001AC8A0 File Offset: 0x001AAAA0
	public unsafe float _burstTimer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__burstTimer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__burstTimer)) = value;
		}
	}

	// Token: 0x170025CB RID: 9675
	// (get) Token: 0x06006A91 RID: 27281 RVA: 0x001AC8C4 File Offset: 0x001AAAC4
	// (set) Token: 0x06006A92 RID: 27282 RVA: 0x001AC8EC File Offset: 0x001AAAEC
	public unsafe float _damage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__damage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__damage)) = value;
		}
	}

	// Token: 0x170025CC RID: 9676
	// (get) Token: 0x06006A93 RID: 27283 RVA: 0x001AC910 File Offset: 0x001AAB10
	// (set) Token: 0x06006A94 RID: 27284 RVA: 0x001AC938 File Offset: 0x001AAB38
	public unsafe float _burstPause
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__burstPause);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__burstPause)) = value;
		}
	}

	// Token: 0x170025CD RID: 9677
	// (get) Token: 0x06006A95 RID: 27285 RVA: 0x001AC95C File Offset: 0x001AAB5C
	// (set) Token: 0x06006A96 RID: 27286 RVA: 0x001AC984 File Offset: 0x001AAB84
	public unsafe Vector3 _lastRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__lastRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__lastRotation)) = value;
		}
	}

	// Token: 0x170025CE RID: 9678
	// (get) Token: 0x06006A97 RID: 27287 RVA: 0x001AC9A8 File Offset: 0x001AABA8
	// (set) Token: 0x06006A98 RID: 27288 RVA: 0x001AC9D0 File Offset: 0x001AABD0
	public unsafe Vector3 _lastPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__lastPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__lastPosition)) = value;
		}
	}

	// Token: 0x170025CF RID: 9679
	// (get) Token: 0x06006A99 RID: 27289 RVA: 0x001AC9F4 File Offset: 0x001AABF4
	// (set) Token: 0x06006A9A RID: 27290 RVA: 0x001ACA28 File Offset: 0x001AAC28
	public unsafe GameObject _chamberBulletGameObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__chamberBulletGameObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__chamberBulletGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025D0 RID: 9680
	// (get) Token: 0x06006A9B RID: 27291 RVA: 0x001ACA50 File Offset: 0x001AAC50
	// (set) Token: 0x06006A9C RID: 27292 RVA: 0x001ACA84 File Offset: 0x001AAC84
	public unsafe Transform _thisTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__thisTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__thisTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025D1 RID: 9681
	// (get) Token: 0x06006A9D RID: 27293 RVA: 0x001ACAAC File Offset: 0x001AACAC
	// (set) Token: 0x06006A9E RID: 27294 RVA: 0x001ACAE0 File Offset: 0x001AACE0
	public unsafe Pickup_Shotgun _pickupShotgun
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__pickupShotgun);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Pickup_Shotgun(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__pickupShotgun), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025D2 RID: 9682
	// (get) Token: 0x06006A9F RID: 27295 RVA: 0x001ACB08 File Offset: 0x001AAD08
	// (set) Token: 0x06006AA0 RID: 27296 RVA: 0x001ACB3C File Offset: 0x001AAD3C
	public unsafe ProjectileLibrary.ProjectileDefinition _projectileDefinition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__projectileDefinition);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new ProjectileLibrary.ProjectileDefinition(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__projectileDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025D3 RID: 9683
	// (get) Token: 0x06006AA1 RID: 27297 RVA: 0x001ACB64 File Offset: 0x001AAD64
	// (set) Token: 0x06006AA2 RID: 27298 RVA: 0x001ACB8C File Offset: 0x001AAD8C
	public unsafe ClassLoadout.AmmoType _loadedAmmoType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__loadedAmmoType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__loadedAmmoType)) = value;
		}
	}

	// Token: 0x170025D4 RID: 9684
	// (get) Token: 0x06006AA3 RID: 27299 RVA: 0x001ACBB0 File Offset: 0x001AADB0
	// (set) Token: 0x06006AA4 RID: 27300 RVA: 0x001ACBE4 File Offset: 0x001AADE4
	public unsafe List<Projectile_Base> _firedProjectiles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__firedProjectiles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<Projectile_Base>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__firedProjectiles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025D5 RID: 9685
	// (get) Token: 0x06006AA5 RID: 27301 RVA: 0x001ACC0C File Offset: 0x001AAE0C
	// (set) Token: 0x06006AA6 RID: 27302 RVA: 0x001ACC2A File Offset: 0x001AAE2A
	public unsafe static float SHOT_SPREAD_ANGLE_MULTIPLIER
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(Weapon.NativeFieldInfoPtr_SHOT_SPREAD_ANGLE_MULTIPLIER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Weapon.NativeFieldInfoPtr_SHOT_SPREAD_ANGLE_MULTIPLIER, (void*)(&value));
		}
	}

	// Token: 0x170025D6 RID: 9686
	// (get) Token: 0x06006AA7 RID: 27303 RVA: 0x001ACC3C File Offset: 0x001AAE3C
	// (set) Token: 0x06006AA8 RID: 27304 RVA: 0x001ACC5A File Offset: 0x001AAE5A
	public unsafe static int INT_SIZE
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(Weapon.NativeFieldInfoPtr_INT_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Weapon.NativeFieldInfoPtr_INT_SIZE, (void*)(&value));
		}
	}

	// Token: 0x170025D7 RID: 9687
	// (get) Token: 0x06006AA9 RID: 27305 RVA: 0x001ACC6C File Offset: 0x001AAE6C
	// (set) Token: 0x06006AAA RID: 27306 RVA: 0x001ACCA0 File Offset: 0x001AAEA0
	public unsafe Action MagInserted
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_MagInserted);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Action(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_MagInserted), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025D8 RID: 9688
	// (get) Token: 0x06006AAB RID: 27307 RVA: 0x001ACCC8 File Offset: 0x001AAEC8
	// (set) Token: 0x06006AAC RID: 27308 RVA: 0x001ACCFC File Offset: 0x001AAEFC
	public unsafe Action<DPIPlayer, int> Fired
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_Fired);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Action<DPIPlayer, int>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_Fired), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025D9 RID: 9689
	// (get) Token: 0x06006AAD RID: 27309 RVA: 0x001ACD24 File Offset: 0x001AAF24
	// (set) Token: 0x06006AAE RID: 27310 RVA: 0x001ACD4C File Offset: 0x001AAF4C
	public unsafe bool _isTentItem_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__isTentItem_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__isTentItem_k__BackingField)) = value;
		}
	}

	// Token: 0x170025DA RID: 9690
	// (get) Token: 0x06006AAF RID: 27311 RVA: 0x001ACD70 File Offset: 0x001AAF70
	// (set) Token: 0x06006AB0 RID: 27312 RVA: 0x001ACD8E File Offset: 0x001AAF8E
	public unsafe static bool DBG_ENABLE_CAM_CHANGE
	{
		get
		{
			bool result;
			IL2CPP.il2cpp_field_static_get_value(Weapon.NativeFieldInfoPtr_DBG_ENABLE_CAM_CHANGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Weapon.NativeFieldInfoPtr_DBG_ENABLE_CAM_CHANGE, (void*)(&value));
		}
	}

	// Token: 0x170025DB RID: 9691
	// (get) Token: 0x06006AB1 RID: 27313 RVA: 0x001ACDA0 File Offset: 0x001AAFA0
	// (set) Token: 0x06006AB2 RID: 27314 RVA: 0x001ACDC8 File Offset: 0x001AAFC8
	public unsafe bool _ManagedUpdateRemoval_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField)) = value;
		}
	}

	// Token: 0x170025DC RID: 9692
	// (get) Token: 0x06006AB3 RID: 27315 RVA: 0x001ACDEC File Offset: 0x001AAFEC
	// (set) Token: 0x06006AB4 RID: 27316 RVA: 0x001ACE20 File Offset: 0x001AB020
	public unsafe EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableByUnique_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableByUnique_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableByUnique_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025DD RID: 9693
	// (get) Token: 0x06006AB5 RID: 27317 RVA: 0x001ACE48 File Offset: 0x001AB048
	// (set) Token: 0x06006AB6 RID: 27318 RVA: 0x001ACE7C File Offset: 0x001AB07C
	public unsafe EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025DE RID: 9694
	// (get) Token: 0x06006AB7 RID: 27319 RVA: 0x001ACEA4 File Offset: 0x001AB0A4
	// (set) Token: 0x06006AB8 RID: 27320 RVA: 0x001ACED8 File Offset: 0x001AB0D8
	public unsafe EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025DF RID: 9695
	// (get) Token: 0x06006AB9 RID: 27321 RVA: 0x001ACF00 File Offset: 0x001AB100
	// (set) Token: 0x06006ABA RID: 27322 RVA: 0x001ACF34 File Offset: 0x001AB134
	public unsafe EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025E0 RID: 9696
	// (get) Token: 0x06006ABB RID: 27323 RVA: 0x001ACF5C File Offset: 0x001AB15C
	// (set) Token: 0x06006ABC RID: 27324 RVA: 0x001ACF90 File Offset: 0x001AB190
	public unsafe EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoUnique_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoUnique_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoUnique_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025E1 RID: 9697
	// (get) Token: 0x06006ABD RID: 27325 RVA: 0x001ACFB8 File Offset: 0x001AB1B8
	// (set) Token: 0x06006ABE RID: 27326 RVA: 0x001ACFEC File Offset: 0x001AB1EC
	public unsafe EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInUnique_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInUnique_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInUnique_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025E2 RID: 9698
	// (get) Token: 0x06006ABF RID: 27327 RVA: 0x001AD014 File Offset: 0x001AB214
	// (set) Token: 0x06006AC0 RID: 27328 RVA: 0x001AD048 File Offset: 0x001AB248
	public unsafe EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170025E3 RID: 9699
	// (get) Token: 0x06006AC1 RID: 27329 RVA: 0x001AD070 File Offset: 0x001AB270
	// (set) Token: 0x06006AC2 RID: 27330 RVA: 0x001AD0A4 File Offset: 0x001AB2A4
	public unsafe EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040042C8 RID: 17096
	private static readonly IntPtr NativeFieldInfoPtr_WeaponSO;

	// Token: 0x040042C9 RID: 17097
	private static readonly IntPtr NativeFieldInfoPtr_AttachmentManager;

	// Token: 0x040042CA RID: 17098
	private static readonly IntPtr NativeFieldInfoPtr_AnimControl;

	// Token: 0x040042CB RID: 17099
	private static readonly IntPtr NativeFieldInfoPtr_MagChildPosition;

	// Token: 0x040042CC RID: 17100
	private static readonly IntPtr NativeFieldInfoPtr_EjectDown;

	// Token: 0x040042CD RID: 17101
	private static readonly IntPtr NativeFieldInfoPtr_ChamberBullet;

	// Token: 0x040042CE RID: 17102
	private static readonly IntPtr NativeFieldInfoPtr_projectileSpawnSpot;

	// Token: 0x040042CF RID: 17103
	private static readonly IntPtr NativeFieldInfoPtr_StockEndPos;

	// Token: 0x040042D0 RID: 17104
	private static readonly IntPtr NativeFieldInfoPtr_CollisionParent;

	// Token: 0x040042D1 RID: 17105
	private static readonly IntPtr NativeFieldInfoPtr_m_GunScript;

	// Token: 0x040042D2 RID: 17106
	private static readonly IntPtr NativeFieldInfoPtr_m_SoundScript;

	// Token: 0x040042D3 RID: 17107
	private static readonly IntPtr NativeFieldInfoPtr_m_Pickup_Gun;

	// Token: 0x040042D4 RID: 17108
	private static readonly IntPtr NativeFieldInfoPtr_m_spectateLineRenderer;

	// Token: 0x040042D5 RID: 17109
	private static readonly IntPtr NativeFieldInfoPtr_OwnerDamageController;

	// Token: 0x040042D6 RID: 17110
	private static readonly IntPtr NativeFieldInfoPtr_fireSelector;

	// Token: 0x040042D7 RID: 17111
	private static readonly IntPtr NativeFieldInfoPtr_lmgFeedTrayCover;

	// Token: 0x040042D8 RID: 17112
	private static readonly IntPtr NativeFieldInfoPtr_LaserState;

	// Token: 0x040042D9 RID: 17113
	private static readonly IntPtr NativeFieldInfoPtr_FlashlightState;

	// Token: 0x040042DA RID: 17114
	private static readonly IntPtr NativeFieldInfoPtr_LastReloadWasFastReload;

	// Token: 0x040042DB RID: 17115
	private static readonly IntPtr NativeFieldInfoPtr_LoadedAlternateAmmo;

	// Token: 0x040042DC RID: 17116
	private static readonly IntPtr NativeFieldInfoPtr_LastMagUnloaded;

	// Token: 0x040042DD RID: 17117
	private static readonly IntPtr NativeFieldInfoPtr_ActualROF;

	// Token: 0x040042DE RID: 17118
	private static readonly IntPtr NativeFieldInfoPtr_Velocity;

	// Token: 0x040042DF RID: 17119
	private static readonly IntPtr NativeFieldInfoPtr_RotationalVelocity;

	// Token: 0x040042E0 RID: 17120
	private static readonly IntPtr NativeFieldInfoPtr_PhysicsColliders;

	// Token: 0x040042E1 RID: 17121
	private static readonly IntPtr NativeFieldInfoPtr_CurrentMagazine;

	// Token: 0x040042E2 RID: 17122
	private static readonly IntPtr NativeFieldInfoPtr_LastMagazine;

	// Token: 0x040042E3 RID: 17123
	private static readonly IntPtr NativeFieldInfoPtr_WeaponData;

	// Token: 0x040042E4 RID: 17124
	private static readonly IntPtr NativeFieldInfoPtr_AlternateFireSoundPlayEvent;

	// Token: 0x040042E5 RID: 17125
	private static readonly IntPtr NativeFieldInfoPtr__firingLineLayerMask;

	// Token: 0x040042E6 RID: 17126
	private static readonly IntPtr NativeFieldInfoPtr__hasInit;

	// Token: 0x040042E7 RID: 17127
	private static readonly IntPtr NativeFieldInfoPtr__roundsLoaded;

	// Token: 0x040042E8 RID: 17128
	private static readonly IntPtr NativeFieldInfoPtr__burstCounter;

	// Token: 0x040042E9 RID: 17129
	private static readonly IntPtr NativeFieldInfoPtr__bulletsUntilTracer;

	// Token: 0x040042EA RID: 17130
	private static readonly IntPtr NativeFieldInfoPtr__aiSemiRof;

	// Token: 0x040042EB RID: 17131
	private static readonly IntPtr NativeFieldInfoPtr__timeSinceLastFired;

	// Token: 0x040042EC RID: 17132
	private static readonly IntPtr NativeFieldInfoPtr__shotSpreadAngleMin;

	// Token: 0x040042ED RID: 17133
	private static readonly IntPtr NativeFieldInfoPtr__shotSpreadAngleMax;

	// Token: 0x040042EE RID: 17134
	private static readonly IntPtr NativeFieldInfoPtr__maxDistance;

	// Token: 0x040042EF RID: 17135
	private static readonly IntPtr NativeFieldInfoPtr__burstTimer;

	// Token: 0x040042F0 RID: 17136
	private static readonly IntPtr NativeFieldInfoPtr__damage;

	// Token: 0x040042F1 RID: 17137
	private static readonly IntPtr NativeFieldInfoPtr__burstPause;

	// Token: 0x040042F2 RID: 17138
	private static readonly IntPtr NativeFieldInfoPtr__lastRotation;

	// Token: 0x040042F3 RID: 17139
	private static readonly IntPtr NativeFieldInfoPtr__lastPosition;

	// Token: 0x040042F4 RID: 17140
	private static readonly IntPtr NativeFieldInfoPtr__chamberBulletGameObject;

	// Token: 0x040042F5 RID: 17141
	private static readonly IntPtr NativeFieldInfoPtr__thisTransform;

	// Token: 0x040042F6 RID: 17142
	private static readonly IntPtr NativeFieldInfoPtr__pickupShotgun;

	// Token: 0x040042F7 RID: 17143
	private static readonly IntPtr NativeFieldInfoPtr__projectileDefinition;

	// Token: 0x040042F8 RID: 17144
	private static readonly IntPtr NativeFieldInfoPtr__loadedAmmoType;

	// Token: 0x040042F9 RID: 17145
	private static readonly IntPtr NativeFieldInfoPtr__firedProjectiles;

	// Token: 0x040042FA RID: 17146
	private static readonly IntPtr NativeFieldInfoPtr_SHOT_SPREAD_ANGLE_MULTIPLIER;

	// Token: 0x040042FB RID: 17147
	private static readonly IntPtr NativeFieldInfoPtr_INT_SIZE;

	// Token: 0x040042FC RID: 17148
	private static readonly IntPtr NativeFieldInfoPtr_MagInserted;

	// Token: 0x040042FD RID: 17149
	private static readonly IntPtr NativeFieldInfoPtr_Fired;

	// Token: 0x040042FE RID: 17150
	private static readonly IntPtr NativeFieldInfoPtr__isTentItem_k__BackingField;

	// Token: 0x040042FF RID: 17151
	private static readonly IntPtr NativeFieldInfoPtr_DBG_ENABLE_CAM_CHANGE;

	// Token: 0x04004300 RID: 17152
	private static readonly IntPtr NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField;

	// Token: 0x04004301 RID: 17153
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableByUnique_0;

	// Token: 0x04004302 RID: 17154
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique_0;

	// Token: 0x04004303 RID: 17155
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0_0;

	// Token: 0x04004304 RID: 17156
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1_0;

	// Token: 0x04004305 RID: 17157
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoUnique_0;

	// Token: 0x04004306 RID: 17158
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInUnique_0;

	// Token: 0x04004307 RID: 17159
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0_0;

	// Token: 0x04004308 RID: 17160
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1_0;

	// Token: 0x04004309 RID: 17161
	private static readonly IntPtr NativeMethodInfoPtr_add_Fired_Public_add_Void_Action_2_DPIPlayer_Int32_0;

	// Token: 0x0400430A RID: 17162
	private static readonly IntPtr NativeMethodInfoPtr_remove_Fired_Public_rem_Void_Action_2_DPIPlayer_Int32_0;

	// Token: 0x0400430B RID: 17163
	private static readonly IntPtr NativeMethodInfoPtr_get_isTentItem_Public_get_Boolean_0;

	// Token: 0x0400430C RID: 17164
	private static readonly IntPtr NativeMethodInfoPtr_set_isTentItem_Private_set_Void_Boolean_0;

	// Token: 0x0400430D RID: 17165
	private static readonly IntPtr NativeMethodInfoPtr_get_CanDropMagFree_Public_get_Boolean_0;

	// Token: 0x0400430E RID: 17166
	private static readonly IntPtr NativeMethodInfoPtr_get_IsShotgunWeaponType_Public_get_Boolean_0;

	// Token: 0x0400430F RID: 17167
	private static readonly IntPtr NativeMethodInfoPtr_get_IsLightMachineGunWeaponType_Public_get_Boolean_0;

	// Token: 0x04004310 RID: 17168
	private static readonly IntPtr NativeMethodInfoPtr_get_IsLauncherWeaponType_Public_get_Boolean_0;

	// Token: 0x04004311 RID: 17169
	private static readonly IntPtr NativeMethodInfoPtr_get_IsBoltActionWeaponType_Public_get_Boolean_0;

	// Token: 0x04004312 RID: 17170
	private static readonly IntPtr NativeMethodInfoPtr_get_IsPistolWeaponType_Public_get_Boolean_0;

	// Token: 0x04004313 RID: 17171
	private static readonly IntPtr NativeMethodInfoPtr_get_IsLightMachineGunTopAtTop_Public_get_Boolean_0;

	// Token: 0x04004314 RID: 17172
	private static readonly IntPtr NativeMethodInfoPtr_get_IsLightMachineGunTopClosed_Public_get_Boolean_0;

	// Token: 0x04004315 RID: 17173
	private static readonly IntPtr NativeMethodInfoPtr_get_LoadingCapacity_Public_get_Int32_0;

	// Token: 0x04004316 RID: 17174
	private static readonly IntPtr NativeMethodInfoPtr_get_BurstRate_Public_get_Int32_0;

	// Token: 0x04004317 RID: 17175
	private static readonly IntPtr NativeMethodInfoPtr_get_MuzzleVelocity_Public_get_Single_0;

	// Token: 0x04004318 RID: 17176
	private static readonly IntPtr NativeMethodInfoPtr_get_ShotSpreadAngle_Public_get_Single_0;

	// Token: 0x04004319 RID: 17177
	private static readonly IntPtr NativeMethodInfoPtr_get_cleanupProjectilesWithGun_Private_get_Boolean_0;

	// Token: 0x0400431A RID: 17178
	private static readonly IntPtr NativeMethodInfoPtr_get_doesEjectShells_Private_get_Boolean_0;

	// Token: 0x0400431B RID: 17179
	private static readonly IntPtr NativeMethodInfoPtr_get_AISemiAutoRoundsPerSecond_Private_get_Single_0;

	// Token: 0x0400431C RID: 17180
	private static readonly IntPtr NativeMethodInfoPtr_get_StartWithMag_Private_get_Boolean_0;

	// Token: 0x0400431D RID: 17181
	private static readonly IntPtr NativeMethodInfoPtr_get_usesSubSonicRounds_Private_get_Boolean_0;

	// Token: 0x0400431E RID: 17182
	private static readonly IntPtr NativeMethodInfoPtr_get_rateOfFire_Private_get_Single_0;

	// Token: 0x0400431F RID: 17183
	private static readonly IntPtr NativeMethodInfoPtr_get_ProjectileType_Private_get_ProjectileID_0;

	// Token: 0x04004320 RID: 17184
	private static readonly IntPtr NativeMethodInfoPtr_get_CurrentAmmo_Public_get_Int32_0;

	// Token: 0x04004321 RID: 17185
	private static readonly IntPtr NativeMethodInfoPtr_get_AmmoPercentage_Public_get_Single_0;

	// Token: 0x04004322 RID: 17186
	private static readonly IntPtr NativeMethodInfoPtr_get_RoundsLoaded_Public_get_Int32_0;

	// Token: 0x04004323 RID: 17187
	private static readonly IntPtr NativeMethodInfoPtr_set_RoundsLoaded_Public_set_Void_Int32_0;

	// Token: 0x04004324 RID: 17188
	private static readonly IntPtr NativeMethodInfoPtr_get_LoadedAmmoType_Public_get_AmmoType_0;

	// Token: 0x04004325 RID: 17189
	private static readonly IntPtr NativeMethodInfoPtr_set_LoadedAmmoType_Public_set_Void_AmmoType_0;

	// Token: 0x04004326 RID: 17190
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04004327 RID: 17191
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04004328 RID: 17192
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04004329 RID: 17193
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x0400432A RID: 17194
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x0400432B RID: 17195
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	// Token: 0x0400432C RID: 17196
	private static readonly IntPtr NativeMethodInfoPtr_ToggleChamberedRound_Public_Void_Boolean_0;

	// Token: 0x0400432D RID: 17197
	private static readonly IntPtr NativeMethodInfoPtr_SpawnAndInsertMagazine_Private_Void_0;

	// Token: 0x0400432E RID: 17198
	private static readonly IntPtr NativeMethodInfoPtr_OverrideAmmoType_Public_Void_AmmoType_0;

	// Token: 0x0400432F RID: 17199
	private static readonly IntPtr NativeMethodInfoPtr_FlagAsInTentItem_Public_Void_0;

	// Token: 0x04004330 RID: 17200
	private static readonly IntPtr NativeMethodInfoPtr_SpawnLoadoutTableMagazine_Public_Pickup_Magazine_0;

	// Token: 0x04004331 RID: 17201
	private static readonly IntPtr NativeMethodInfoPtr_RPC_SetLoadedAmmoType_Public_Void_Byte_DPINetworkMessageInfo_0;

	// Token: 0x04004332 RID: 17202
	private static readonly IntPtr NativeMethodInfoPtr_ToggleCamChange_Public_Void_0;

	// Token: 0x04004333 RID: 17203
	private static readonly IntPtr NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04004334 RID: 17204
	private static readonly IntPtr NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0;

	// Token: 0x04004335 RID: 17205
	private static readonly IntPtr NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0;

	// Token: 0x04004336 RID: 17206
	private static readonly IntPtr NativeMethodInfoPtr_SpectatingAndDebugging_Private_Void_Single_0;

	// Token: 0x04004337 RID: 17207
	private static readonly IntPtr NativeMethodInfoPtr_UpdateWeaponTimer_Private_Void_Single_0;

	// Token: 0x04004338 RID: 17208
	private static readonly IntPtr NativeMethodInfoPtr_InsertMag_Public_Void_Pickup_Magazine_Boolean_0;

	// Token: 0x04004339 RID: 17209
	private static readonly IntPtr NativeMethodInfoPtr_PulledMagOut_Public_Void_0;

	// Token: 0x0400433A RID: 17210
	private static readonly IntPtr NativeMethodInfoPtr_EjectMagazine_Public_Void_Boolean_0;

	// Token: 0x0400433B RID: 17211
	private static readonly IntPtr NativeMethodInfoPtr_RPC_EjectMag_Public_Void_Boolean_Int32_Boolean_DPINetworkMessageInfo_0;

	// Token: 0x0400433C RID: 17212
	private static readonly IntPtr NativeMethodInfoPtr_CanFire_Public_Boolean_0;

	// Token: 0x0400433D RID: 17213
	private static readonly IntPtr NativeMethodInfoPtr_CanFireAI_Public_Boolean_0;

	// Token: 0x0400433E RID: 17214
	private static readonly IntPtr NativeMethodInfoPtr_AIFireWeapon_Public_Void_Vector3_Int32_0;

	// Token: 0x0400433F RID: 17215
	private static readonly IntPtr NativeMethodInfoPtr_AIReload_Public_Void_0;

	// Token: 0x04004340 RID: 17216
	private static readonly IntPtr NativeMethodInfoPtr_LaunchAlternateProjectile_Public_Void_Vector3_Vector3_Int32_DPIPlayer_Int32_0;

	// Token: 0x04004341 RID: 17217
	private static readonly IntPtr NativeMethodInfoPtr_RPC_LaunchAlternateProjectile_Public_Void_Vector3_Vector3_Int32_Int32_Int32_DPINetworkMessageInfo_0;

	// Token: 0x04004342 RID: 17218
	private static readonly IntPtr NativeMethodInfoPtr_FireWeapon_Public_Void_DPIPlayer_Nullable_1_Vector3_Int32_0;

	// Token: 0x04004343 RID: 17219
	private static readonly IntPtr NativeMethodInfoPtr_DeductAmmo_Private_Void_0;

	// Token: 0x04004344 RID: 17220
	private static readonly IntPtr NativeMethodInfoPtr_RPC_LaunchProjectile_Public_Void_Vector3_Vector3_Int32_Int32_Int32_DPINetworkMessageInfo_0;

	// Token: 0x04004345 RID: 17221
	private static readonly IntPtr NativeMethodInfoPtr_HideMagazine_Public_Void_Boolean_0;

	// Token: 0x04004346 RID: 17222
	private static readonly IntPtr NativeMethodInfoPtr_RPC_HideMagazine_Public_Void_Boolean_DPINetworkMessageInfo_0;

	// Token: 0x04004347 RID: 17223
	private static readonly IntPtr NativeMethodInfoPtr_LaunchProjectile_Private_Void_Vector3_Quaternion_ProjectileID_AmmoType_OnwardPhotonPlayer_Int32_Single_0;

	// Token: 0x04004348 RID: 17224
	private static readonly IntPtr NativeMethodInfoPtr_FireAlert_Private_Void_0;

	// Token: 0x04004349 RID: 17225
	private static readonly IntPtr NativeMethodInfoPtr_LoadRound_Public_Void_0;

	// Token: 0x0400434A RID: 17226
	private static readonly IntPtr NativeMethodInfoPtr_EjectUnspentBullet_Public_Void_0;

	// Token: 0x0400434B RID: 17227
	private static readonly IntPtr NativeMethodInfoPtr_EjectCasing_Public_Void_0;

	// Token: 0x0400434C RID: 17228
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ByteWrapper_Alloc_SetAttachments_Public_Void_ArrayOf_Int32_DPINetworkMessageInfo_0;

	// Token: 0x0400434D RID: 17229
	private static readonly IntPtr NativeMethodInfoPtr_InvokeSetAttachmentsRPC_Public_Void_ArrayOf_AttachmentType_RpcTarget_0;

	// Token: 0x0400434E RID: 17230
	private static readonly IntPtr NativeMethodInfoPtr_SetAttachmentsRPC_Public_Void_ArrayOf_AttachmentType_0;

	// Token: 0x0400434F RID: 17231
	private static readonly IntPtr NativeMethodInfoPtr_GetSightToZero_Public_WeaponAttachment_Sight_0;

	// Token: 0x04004350 RID: 17232
	private static readonly IntPtr NativeMethodInfoPtr_SetLaser_Public_Void_WeaponAttachmentToggleState_0;

	// Token: 0x04004351 RID: 17233
	private static readonly IntPtr NativeMethodInfoPtr_SetFlashlight_Public_Void_WeaponAttachmentToggleState_0;

	// Token: 0x04004352 RID: 17234
	private static readonly IntPtr NativeMethodInfoPtr_ToggleLaser_Public_Void_0;

	// Token: 0x04004353 RID: 17235
	private static readonly IntPtr NativeMethodInfoPtr_ToggleFlashlight_Public_Void_0;

	// Token: 0x04004354 RID: 17236
	private static readonly IntPtr NativeMethodInfoPtr_RPC_LaserStatus_Public_Void_Int32_Boolean_DPINetworkMessageInfo_0;

	// Token: 0x04004355 RID: 17237
	private static readonly IntPtr NativeMethodInfoPtr_RefreshLaserClientSide_Private_Void_Boolean_0;

	// Token: 0x04004356 RID: 17238
	private static readonly IntPtr NativeMethodInfoPtr_RPC_FlashLightStatus_Public_Void_Int32_Boolean_DPINetworkMessageInfo_0;

	// Token: 0x04004357 RID: 17239
	private static readonly IntPtr NativeMethodInfoPtr_RefreshFlashlightClientSide_Private_Void_Boolean_0;

	// Token: 0x04004358 RID: 17240
	private static readonly IntPtr NativeMethodInfoPtr_RefreshInteractableAttachmentsSilently_Public_Void_0;

	// Token: 0x04004359 RID: 17241
	private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

	// Token: 0x0400435A RID: 17242
	private static readonly IntPtr NativeMethodInfoPtr_ZeroWeaponBarrel_Public_Void_WeaponAttachment_Sight_0;

	// Token: 0x0400435B RID: 17243
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableByUnique_DPINetworkMessageInfo_0;

	// Token: 0x0400435C RID: 17244
	private static readonly IntPtr NativeMethodInfoPtr_RPC_SetLoadedAmmoType_Public_Void_ArrayOf_DPIPlayer_Byte_0;

	// Token: 0x0400435D RID: 17245
	private static readonly IntPtr NativeMethodInfoPtr_RPC_SetLoadedAmmoType_Public_Void_DPIPlayer_Byte_0;

	// Token: 0x0400435E RID: 17246
	private static readonly IntPtr NativeMethodInfoPtr_RPC_SetLoadedAmmoType_Public_Void_RpcTarget_Byte_0;

	// Token: 0x0400435F RID: 17247
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique_DPINetworkMessageInfo_0;

	// Token: 0x04004360 RID: 17248
	private static readonly IntPtr NativeMethodInfoPtr_RPC_EjectMag_Public_Void_ArrayOf_DPIPlayer_Boolean_Int32_Boolean_0;

	// Token: 0x04004361 RID: 17249
	private static readonly IntPtr NativeMethodInfoPtr_RPC_EjectMag_Public_Void_DPIPlayer_Boolean_Int32_Boolean_0;

	// Token: 0x04004362 RID: 17250
	private static readonly IntPtr NativeMethodInfoPtr_RPC_EjectMag_Public_Void_RpcTarget_Boolean_Int32_Boolean_0;

	// Token: 0x04004363 RID: 17251
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0_DPINetworkMessageInfo_0;

	// Token: 0x04004364 RID: 17252
	private static readonly IntPtr NativeMethodInfoPtr_RPC_LaunchAlternateProjectile_Public_Void_ArrayOf_DPIPlayer_Vector3_Vector3_Int32_Int32_Int32_0;

	// Token: 0x04004365 RID: 17253
	private static readonly IntPtr NativeMethodInfoPtr_RPC_LaunchAlternateProjectile_Public_Void_DPIPlayer_Vector3_Vector3_Int32_Int32_Int32_0;

	// Token: 0x04004366 RID: 17254
	private static readonly IntPtr NativeMethodInfoPtr_RPC_LaunchAlternateProjectile_Public_Void_RpcTarget_Vector3_Vector3_Int32_Int32_Int32_0;

	// Token: 0x04004367 RID: 17255
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1_DPINetworkMessageInfo_0;

	// Token: 0x04004368 RID: 17256
	private static readonly IntPtr NativeMethodInfoPtr_RPC_LaunchProjectile_Public_Void_ArrayOf_DPIPlayer_Vector3_Vector3_Int32_Int32_Int32_0;

	// Token: 0x04004369 RID: 17257
	private static readonly IntPtr NativeMethodInfoPtr_RPC_LaunchProjectile_Public_Void_DPIPlayer_Vector3_Vector3_Int32_Int32_Int32_0;

	// Token: 0x0400436A RID: 17258
	private static readonly IntPtr NativeMethodInfoPtr_RPC_LaunchProjectile_Public_Void_RpcTarget_Vector3_Vector3_Int32_Int32_Int32_0;

	// Token: 0x0400436B RID: 17259
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoUnique_DPINetworkMessageInfo_0;

	// Token: 0x0400436C RID: 17260
	private static readonly IntPtr NativeMethodInfoPtr_RPC_HideMagazine_Public_Void_ArrayOf_DPIPlayer_Boolean_0;

	// Token: 0x0400436D RID: 17261
	private static readonly IntPtr NativeMethodInfoPtr_RPC_HideMagazine_Public_Void_DPIPlayer_Boolean_0;

	// Token: 0x0400436E RID: 17262
	private static readonly IntPtr NativeMethodInfoPtr_RPC_HideMagazine_Public_Void_RpcTarget_Boolean_0;

	// Token: 0x0400436F RID: 17263
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInUnique_DPINetworkMessageInfo_0;

	// Token: 0x04004370 RID: 17264
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ByteWrapper_Alloc_SetAttachments_Public_Void_ArrayOf_DPIPlayer_ArrayOf_Int32_0;

	// Token: 0x04004371 RID: 17265
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ByteWrapper_Alloc_SetAttachments_Public_Void_DPIPlayer_ArrayOf_Int32_0;

	// Token: 0x04004372 RID: 17266
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ByteWrapper_Alloc_SetAttachments_Public_Void_RpcTarget_ArrayOf_Int32_0;

	// Token: 0x04004373 RID: 17267
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0_DPINetworkMessageInfo_0;

	// Token: 0x04004374 RID: 17268
	private static readonly IntPtr NativeMethodInfoPtr_RPC_LaserStatus_Public_Void_ArrayOf_DPIPlayer_Int32_Boolean_0;

	// Token: 0x04004375 RID: 17269
	private static readonly IntPtr NativeMethodInfoPtr_RPC_LaserStatus_Public_Void_DPIPlayer_Int32_Boolean_0;

	// Token: 0x04004376 RID: 17270
	private static readonly IntPtr NativeMethodInfoPtr_RPC_LaserStatus_Public_Void_RpcTarget_Int32_Boolean_0;

	// Token: 0x04004377 RID: 17271
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1_DPINetworkMessageInfo_0;

	// Token: 0x04004378 RID: 17272
	private static readonly IntPtr NativeMethodInfoPtr_RPC_FlashLightStatus_Public_Void_ArrayOf_DPIPlayer_Int32_Boolean_0;

	// Token: 0x04004379 RID: 17273
	private static readonly IntPtr NativeMethodInfoPtr_RPC_FlashLightStatus_Public_Void_DPIPlayer_Int32_Boolean_0;

	// Token: 0x0400437A RID: 17274
	private static readonly IntPtr NativeMethodInfoPtr_RPC_FlashLightStatus_Public_Void_RpcTarget_Int32_Boolean_0;

	// Token: 0x0400437B RID: 17275
	private static readonly IntPtr NativeMethodInfoPtr_OnCodeGenInitializeHook_Public_Virtual_Void_0;

	// Token: 0x0400437C RID: 17276
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000510 RID: 1296
	[ObfuscatedName("Weapon/Δδδ_S_RPC_SetLoadedAmmoType")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedINetworkStreamableByUnique
	{
		// Token: 0x06006AC3 RID: 27331 RVA: 0x001AD0CC File Offset: 0x001AB2CC
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x001AD118 File Offset: 0x001AB318
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x001AD164 File Offset: 0x001AB364
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableByUnique()
		{
			Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_S_RPC_SetLoadedAmmoType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique>.NativeClassPtr);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique.NativeFieldInfoPtr_field_Public_Byte_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique>.NativeClassPtr, "Δδδ_I_ammoTypeByte");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique>.NativeClassPtr, 100671773);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique>.NativeClassPtr, 100671774);
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x001AD1CB File Offset: 0x001AB3CB
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique>.NativeClassPtr, ref this));
		}

		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x06006AC7 RID: 27335 RVA: 0x001AD1DD File Offset: 0x001AB3DD
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableByUnique>.NativeClassPtr));
			}
		}

		// Token: 0x0400437D RID: 17277
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Byte_0;

		// Token: 0x0400437E RID: 17278
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x0400437F RID: 17279
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04004380 RID: 17280
		[FieldOffset(0)]
		public byte field_Public_Byte_0;
	}

	// Token: 0x02000511 RID: 1297
	[ObfuscatedName("Weapon/Δδδ_S_RPC_EjectMag")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique
	{
		// Token: 0x06006AC8 RID: 27336 RVA: 0x001AD1F0 File Offset: 0x001AB3F0
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x001AD23C File Offset: 0x001AB43C
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ACA RID: 27338 RVA: 0x001AD288 File Offset: 0x001AB488
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique()
		{
			Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_S_RPC_EjectMag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique>.NativeClassPtr);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique.NativeFieldInfoPtr_field_Public_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique>.NativeClassPtr, "Δδδ_I_doEjectAnimation");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique.NativeFieldInfoPtr_field_Public_Int32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique>.NativeClassPtr, "Δδδ_I_newMagAmmo");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique.NativeFieldInfoPtr_field_Public_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique>.NativeClassPtr, "Δδδ_I_isFastReload");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique>.NativeClassPtr, 100671775);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique>.NativeClassPtr, 100671776);
		}

		// Token: 0x06006ACB RID: 27339 RVA: 0x001AD317 File Offset: 0x001AB517
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique>.NativeClassPtr, ref this));
		}

		// Token: 0x170025FE RID: 9726
		// (get) Token: 0x06006ACC RID: 27340 RVA: 0x001AD329 File Offset: 0x001AB529
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoInBoUnique>.NativeClassPtr));
			}
		}

		// Token: 0x04004381 RID: 17281
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Boolean_0;

		// Token: 0x04004382 RID: 17282
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_0;

		// Token: 0x04004383 RID: 17283
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Boolean_1;

		// Token: 0x04004384 RID: 17284
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04004385 RID: 17285
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04004386 RID: 17286
		[FieldOffset(0)]
		public bool field_Public_Boolean_0;

		// Token: 0x04004387 RID: 17287
		[FieldOffset(4)]
		public int field_Public_Int32_0;

		// Token: 0x04004388 RID: 17288
		[FieldOffset(8)]
		public bool field_Public_Boolean_1;
	}

	// Token: 0x02000512 RID: 1298
	[ObfuscatedName("Weapon/Δδδ_S_RPC_LaunchAlternateProjectile")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0
	{
		// Token: 0x06006ACD RID: 27341 RVA: 0x001AD33C File Offset: 0x001AB53C
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ACE RID: 27342 RVA: 0x001AD388 File Offset: 0x001AB588
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ACF RID: 27343 RVA: 0x001AD3D4 File Offset: 0x001AB5D4
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0()
		{
			Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_S_RPC_LaunchAlternateProjectile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0>.NativeClassPtr);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0.NativeFieldInfoPtr_field_Public_Vector3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0>.NativeClassPtr, "Δδδ_I_spawnPosition");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0.NativeFieldInfoPtr_field_Public_Vector3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0>.NativeClassPtr, "Δδδ_I_lookDirection");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0.NativeFieldInfoPtr_field_Public_Int32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0>.NativeClassPtr, "Δδδ_I_projectileTypeId");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0.NativeFieldInfoPtr_field_Public_Int32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0>.NativeClassPtr, "Δδδ_I_playerID");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0.NativeFieldInfoPtr_field_Public_Int32_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0>.NativeClassPtr, "Δδδ_I_AISourceID");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0>.NativeClassPtr, 100671777);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0>.NativeClassPtr, 100671778);
		}

		// Token: 0x06006AD0 RID: 27344 RVA: 0x001AD48B File Offset: 0x001AB68B
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0>.NativeClassPtr, ref this));
		}

		// Token: 0x170025FF RID: 9727
		// (get) Token: 0x06006AD1 RID: 27345 RVA: 0x001AD49D File Offset: 0x001AB69D
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr0>.NativeClassPtr));
			}
		}

		// Token: 0x04004389 RID: 17289
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Vector3_0;

		// Token: 0x0400438A RID: 17290
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Vector3_1;

		// Token: 0x0400438B RID: 17291
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_0;

		// Token: 0x0400438C RID: 17292
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_1;

		// Token: 0x0400438D RID: 17293
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_2;

		// Token: 0x0400438E RID: 17294
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x0400438F RID: 17295
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04004390 RID: 17296
		[FieldOffset(0)]
		public Vector3 field_Public_Vector3_0;

		// Token: 0x04004391 RID: 17297
		[FieldOffset(12)]
		public Vector3 field_Public_Vector3_1;

		// Token: 0x04004392 RID: 17298
		[FieldOffset(24)]
		public int field_Public_Int32_0;

		// Token: 0x04004393 RID: 17299
		[FieldOffset(28)]
		public int field_Public_Int32_1;

		// Token: 0x04004394 RID: 17300
		[FieldOffset(32)]
		public int field_Public_Int32_2;
	}

	// Token: 0x02000513 RID: 1299
	[ObfuscatedName("Weapon/Δδδ_S_RPC_LaunchProjectile")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1
	{
		// Token: 0x06006AD2 RID: 27346 RVA: 0x001AD4B0 File Offset: 0x001AB6B0
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AD3 RID: 27347 RVA: 0x001AD4FC File Offset: 0x001AB6FC
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AD4 RID: 27348 RVA: 0x001AD548 File Offset: 0x001AB748
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1()
		{
			Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_S_RPC_LaunchProjectile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1>.NativeClassPtr);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1.NativeFieldInfoPtr_field_Public_Vector3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1>.NativeClassPtr, "Δδδ_I_spawnPosition");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1.NativeFieldInfoPtr_field_Public_Vector3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1>.NativeClassPtr, "Δδδ_I_lookDirection");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1.NativeFieldInfoPtr_field_Public_Int32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1>.NativeClassPtr, "Δδδ_I_ammoID");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1.NativeFieldInfoPtr_field_Public_Int32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1>.NativeClassPtr, "Δδδ_I_playerID");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1.NativeFieldInfoPtr_field_Public_Int32_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1>.NativeClassPtr, "Δδδ_I_AISourceID");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1>.NativeClassPtr, 100671779);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1>.NativeClassPtr, 100671780);
		}

		// Token: 0x06006AD5 RID: 27349 RVA: 0x001AD5FF File Offset: 0x001AB7FF
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1>.NativeClassPtr, ref this));
		}

		// Token: 0x17002600 RID: 9728
		// (get) Token: 0x06006AD6 RID: 27350 RVA: 0x001AD611 File Offset: 0x001AB811
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableVeInVeReInVoneInDPWr1>.NativeClassPtr));
			}
		}

		// Token: 0x04004395 RID: 17301
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Vector3_0;

		// Token: 0x04004396 RID: 17302
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Vector3_1;

		// Token: 0x04004397 RID: 17303
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_0;

		// Token: 0x04004398 RID: 17304
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_1;

		// Token: 0x04004399 RID: 17305
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_2;

		// Token: 0x0400439A RID: 17306
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x0400439B RID: 17307
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x0400439C RID: 17308
		[FieldOffset(0)]
		public Vector3 field_Public_Vector3_0;

		// Token: 0x0400439D RID: 17309
		[FieldOffset(12)]
		public Vector3 field_Public_Vector3_1;

		// Token: 0x0400439E RID: 17310
		[FieldOffset(24)]
		public int field_Public_Int32_0;

		// Token: 0x0400439F RID: 17311
		[FieldOffset(28)]
		public int field_Public_Int32_1;

		// Token: 0x040043A0 RID: 17312
		[FieldOffset(32)]
		public int field_Public_Int32_2;
	}

	// Token: 0x02000514 RID: 1300
	[ObfuscatedName("Weapon/Δδδ_S_RPC_HideMagazine")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedINetworkStreamableBoUnique
	{
		// Token: 0x06006AD7 RID: 27351 RVA: 0x001AD624 File Offset: 0x001AB824
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AD8 RID: 27352 RVA: 0x001AD670 File Offset: 0x001AB870
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AD9 RID: 27353 RVA: 0x001AD6BC File Offset: 0x001AB8BC
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableBoUnique()
		{
			Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_S_RPC_HideMagazine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique>.NativeClassPtr);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique.NativeFieldInfoPtr_field_Public_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique>.NativeClassPtr, "Δδδ_I_hidden");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique>.NativeClassPtr, 100671781);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique>.NativeClassPtr, 100671782);
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x001AD723 File Offset: 0x001AB923
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique>.NativeClassPtr, ref this));
		}

		// Token: 0x17002601 RID: 9729
		// (get) Token: 0x06006ADB RID: 27355 RVA: 0x001AD735 File Offset: 0x001AB935
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableBoUnique>.NativeClassPtr));
			}
		}

		// Token: 0x040043A1 RID: 17313
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Boolean_0;

		// Token: 0x040043A2 RID: 17314
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x040043A3 RID: 17315
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x040043A4 RID: 17316
		[FieldOffset(0)]
		public bool field_Public_Boolean_0;
	}

	// Token: 0x02000515 RID: 1301
	[ObfuscatedName("Weapon/Δδδ_S_RPC_ByteWrapper_Alloc_SetAttachments")]
	[StructLayout(0)]
	public sealed class ValueTypeNPrivateSealedINetworkStreamableInUnique : ValueType
	{
		// Token: 0x06006ADC RID: 27356 RVA: 0x001AD748 File Offset: 0x001AB948
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x001AD7A0 File Offset: 0x001AB9A0
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ADE RID: 27358 RVA: 0x001AD7F8 File Offset: 0x001AB9F8
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableInUnique()
		{
			Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_S_RPC_ByteWrapper_Alloc_SetAttachments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique.NativeFieldInfoPtr_field_Public_ArrayOf_Int32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr, "Δδδ_I_attachmentTypes");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr, 100671783);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr, 100671784);
		}

		// Token: 0x06006ADF RID: 27359 RVA: 0x0002717B File Offset: 0x0002537B
		public ValueTypeNPrivateSealedINetworkStreamableInUnique(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002602 RID: 9730
		// (get) Token: 0x06006AE0 RID: 27360 RVA: 0x001AD85F File Offset: 0x001ABA5F
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr));
			}
		}

		// Token: 0x06006AE1 RID: 27361 RVA: 0x001AD870 File Offset: 0x001ABA70
		public unsafe ValueTypeNPrivateSealedINetworkStreamableInUnique()
		{
			IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr, (UIntPtr)0)];
			base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr, data));
		}

		// Token: 0x17002603 RID: 9731
		// (get) Token: 0x06006AE2 RID: 27362 RVA: 0x001AD8A0 File Offset: 0x001ABAA0
		// (set) Token: 0x06006AE3 RID: 27363 RVA: 0x001AD8D4 File Offset: 0x001ABAD4
		public unsafe Il2CppStructArray<int> field_Public_ArrayOf_Int32_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique.NativeFieldInfoPtr_field_Public_ArrayOf_Int32_0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Weapon.ValueTypeNPrivateSealedINetworkStreamableInUnique.NativeFieldInfoPtr_field_Public_ArrayOf_Int32_0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043A5 RID: 17317
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_ArrayOf_Int32_0;

		// Token: 0x040043A6 RID: 17318
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x040043A7 RID: 17319
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;
	}

	// Token: 0x02000516 RID: 1302
	[ObfuscatedName("Weapon/Δδδ_S_RPC_LaserStatus")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0
	{
		// Token: 0x06006AE4 RID: 27364 RVA: 0x001AD8FC File Offset: 0x001ABAFC
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AE5 RID: 27365 RVA: 0x001AD948 File Offset: 0x001ABB48
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AE6 RID: 27366 RVA: 0x001AD994 File Offset: 0x001ABB94
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0()
		{
			Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_S_RPC_LaserStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0>.NativeClassPtr);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0.NativeFieldInfoPtr_field_Public_Int32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0>.NativeClassPtr, "Δδδ_I_newStatus");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0.NativeFieldInfoPtr_field_Public_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0>.NativeClassPtr, "Δδδ_I_playSound");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0>.NativeClassPtr, 100671785);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0>.NativeClassPtr, 100671786);
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x001ADA0F File Offset: 0x001ABC0F
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0>.NativeClassPtr, ref this));
		}

		// Token: 0x17002604 RID: 9732
		// (get) Token: 0x06006AE8 RID: 27368 RVA: 0x001ADA21 File Offset: 0x001ABC21
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP0>.NativeClassPtr));
			}
		}

		// Token: 0x040043A8 RID: 17320
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_0;

		// Token: 0x040043A9 RID: 17321
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Boolean_0;

		// Token: 0x040043AA RID: 17322
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x040043AB RID: 17323
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x040043AC RID: 17324
		[FieldOffset(0)]
		public int field_Public_Int32_0;

		// Token: 0x040043AD RID: 17325
		[FieldOffset(4)]
		public bool field_Public_Boolean_0;
	}

	// Token: 0x02000517 RID: 1303
	[ObfuscatedName("Weapon/Δδδ_S_RPC_FlashLightStatus")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1
	{
		// Token: 0x06006AE9 RID: 27369 RVA: 0x001ADA34 File Offset: 0x001ABC34
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x001ADA80 File Offset: 0x001ABC80
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AEB RID: 27371 RVA: 0x001ADACC File Offset: 0x001ABCCC
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1()
		{
			Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "Δδδ_S_RPC_FlashLightStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1>.NativeClassPtr);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1.NativeFieldInfoPtr_field_Public_Int32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1>.NativeClassPtr, "Δδδ_I_newStatus");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1.NativeFieldInfoPtr_field_Public_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1>.NativeClassPtr, "Δδδ_I_playSound");
			Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1>.NativeClassPtr, 100671787);
			Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1>.NativeClassPtr, 100671788);
		}

		// Token: 0x06006AEC RID: 27372 RVA: 0x001ADB47 File Offset: 0x001ABD47
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1>.NativeClassPtr, ref this));
		}

		// Token: 0x17002605 RID: 9733
		// (get) Token: 0x06006AED RID: 27373 RVA: 0x001ADB59 File Offset: 0x001ABD59
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Weapon.ValueTypeNPrivateSealedINetworkStreamableInBoReVoneDPWrVoneDP1>.NativeClassPtr));
			}
		}

		// Token: 0x040043AE RID: 17326
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_0;

		// Token: 0x040043AF RID: 17327
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Boolean_0;

		// Token: 0x040043B0 RID: 17328
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x040043B1 RID: 17329
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x040043B2 RID: 17330
		[FieldOffset(0)]
		public int field_Public_Int32_0;

		// Token: 0x040043B3 RID: 17331
		[FieldOffset(4)]
		public bool field_Public_Boolean_0;
	}

	// Token: 0x02000518 RID: 1304
	[ObfuscatedName("Weapon/<>c")]
	[Serializable]
	public sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x06006AEE RID: 27374 RVA: 0x001ADB6C File Offset: 0x001ABD6C
		[CallerCount(0)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Weapon.__c>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Weapon.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AEF RID: 27375 RVA: 0x001ADBB8 File Offset: 0x001ABDB8
		[CallerCount(0)]
		public unsafe bool _SetAttachmentsRPC_b__151_0(WeaponAttachment_Sight sight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sight);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Weapon.__c.NativeMethodInfoPtr__SetAttachmentsRPC_b__151_0_Internal_Boolean_WeaponAttachment_Sight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006AF0 RID: 27376 RVA: 0x001ADC20 File Offset: 0x001ABE20
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<Weapon.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Weapon>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Weapon.__c>.NativeClassPtr);
			Weapon.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.__c>.NativeClassPtr, "<>9");
			Weapon.__c.NativeFieldInfoPtr___9__151_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Weapon.__c>.NativeClassPtr, "<>9__151_0");
			Weapon.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.__c>.NativeClassPtr, 100671790);
			Weapon.__c.NativeMethodInfoPtr__SetAttachmentsRPC_b__151_0_Internal_Boolean_WeaponAttachment_Sight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Weapon.__c>.NativeClassPtr, 100671791);
		}

		// Token: 0x06006AF1 RID: 27377 RVA: 0x00002988 File Offset: 0x00000B88
		public __c(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002606 RID: 9734
		// (get) Token: 0x06006AF2 RID: 27378 RVA: 0x001ADC9B File Offset: 0x001ABE9B
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Weapon.__c>.NativeClassPtr));
			}
		}

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x06006AF3 RID: 27379 RVA: 0x001ADCAC File Offset: 0x001ABEAC
		// (set) Token: 0x06006AF4 RID: 27380 RVA: 0x001ADCD7 File Offset: 0x001ABED7
		public unsafe static Weapon.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Weapon.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Weapon.__c(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Weapon.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x06006AF5 RID: 27381 RVA: 0x001ADCEC File Offset: 0x001ABEEC
		// (set) Token: 0x06006AF6 RID: 27382 RVA: 0x001ADD17 File Offset: 0x001ABF17
		public unsafe static Predicate<WeaponAttachment_Sight> __9__151_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Weapon.__c.NativeFieldInfoPtr___9__151_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Predicate<WeaponAttachment_Sight>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Weapon.__c.NativeFieldInfoPtr___9__151_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043B4 RID: 17332
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040043B5 RID: 17333
		private static readonly IntPtr NativeFieldInfoPtr___9__151_0;

		// Token: 0x040043B6 RID: 17334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040043B7 RID: 17335
		private static readonly IntPtr NativeMethodInfoPtr__SetAttachmentsRPC_b__151_0_Internal_Boolean_WeaponAttachment_Sight_0;
	}
}
