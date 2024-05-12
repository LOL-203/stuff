using System;
using System.Runtime.InteropServices;
using DPI.Data;
using Il2CppSystem;
using Onward.Data;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000331 RID: 817
public class AmmoRefill : MonoBehaviour
{
	// Token: 0x0600403A RID: 16442 RVA: 0x001038B0 File Offset: 0x00101AB0
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmmoRefill.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600403B RID: 16443 RVA: 0x001038F4 File Offset: 0x00101AF4
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmmoRefill.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600403C RID: 16444 RVA: 0x00103938 File Offset: 0x00101B38
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmmoRefill.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600403D RID: 16445 RVA: 0x0010397C File Offset: 0x00101B7C
	[CallerCount(0)]
	public unsafe void ReplenishMags()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmmoRefill.NativeMethodInfoPtr_ReplenishMags_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600403E RID: 16446 RVA: 0x001039C0 File Offset: 0x00101BC0
	[CallerCount(0)]
	public unsafe void SpawnItemsInCrate(bool isPile = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref isPile;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmmoRefill.NativeMethodInfoPtr_SpawnItemsInCrate_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600403F RID: 16447 RVA: 0x00103A14 File Offset: 0x00101C14
	[CallerCount(0)]
	public unsafe void SpawnExtras()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmmoRefill.NativeMethodInfoPtr_SpawnExtras_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004040 RID: 16448 RVA: 0x00103A58 File Offset: 0x00101C58
	[CallerCount(0)]
	public unsafe void SpawnThing(BaseData gameData, [In] ref ClassLoadout.AmmoType ammoType, [Optional] int percentChance, [Optional] int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameData);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ammoType;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percentChance;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmmoRefill.NativeMethodInfoPtr_SpawnThing_Public_Void_BaseData_byref_AmmoType_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004041 RID: 16449 RVA: 0x00103AEC File Offset: 0x00101CEC
	[CallerCount(0)]
	public unsafe void ReallySpawnThing(AssetReferenceData gameData, ClassLoadout.AmmoType ammoType, [Optional] int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameData);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ammoType;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmmoRefill.NativeMethodInfoPtr_ReallySpawnThing_Public_Void_AssetReferenceData_AmmoType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004042 RID: 16450 RVA: 0x00103B6C File Offset: 0x00101D6C
	[CallerCount(0)]
	public unsafe void ClearMagsInCrate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmmoRefill.NativeMethodInfoPtr_ClearMagsInCrate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004043 RID: 16451 RVA: 0x00103BB0 File Offset: 0x00101DB0
	[CallerCount(0)]
	public unsafe void ResetCrate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmmoRefill.NativeMethodInfoPtr_ResetCrate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004044 RID: 16452 RVA: 0x00103BF4 File Offset: 0x00101DF4
	[CallerCount(0)]
	public unsafe void HideObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmmoRefill.NativeMethodInfoPtr_HideObject_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004045 RID: 16453 RVA: 0x00103C38 File Offset: 0x00101E38
	[CallerCount(0)]
	public unsafe AmmoRefill() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmmoRefill.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004046 RID: 16454 RVA: 0x00103C84 File Offset: 0x00101E84
	// Note: this type is marked as 'beforefieldinit'.
	static AmmoRefill()
	{
		Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AmmoRefill");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr);
		AmmoRefill.NativeFieldInfoPtr_pickupLibrary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "pickupLibrary");
		AmmoRefill.NativeFieldInfoPtr_thisHolster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "thisHolster");
		AmmoRefill.NativeFieldInfoPtr_hasSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "hasSpawned");
		AmmoRefill.NativeFieldInfoPtr_ShowTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "ShowTable");
		AmmoRefill.NativeFieldInfoPtr_pouchAmmoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "pouchAmmoCount");
		AmmoRefill.NativeFieldInfoPtr_currentAmmoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "currentAmmoCount");
		AmmoRefill.NativeFieldInfoPtr_refillOnSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "refillOnSpawn");
		AmmoRefill.NativeFieldInfoPtr_waitingToReplenish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "waitingToReplenish");
		AmmoRefill.NativeFieldInfoPtr_refillType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "refillType");
		AmmoRefill.NativeFieldInfoPtr_hasBeenOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "hasBeenOpened");
		AmmoRefill.NativeFieldInfoPtr_closeToRefill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "closeToRefill");
		AmmoRefill.NativeFieldInfoPtr_spawnContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "spawnContainer");
		AmmoRefill.NativeFieldInfoPtr_SpawnPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "SpawnPositions");
		AmmoRefill.NativeFieldInfoPtr_thisBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "thisBox");
		AmmoRefill.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "icon");
		AmmoRefill.NativeFieldInfoPtr_jungleCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "jungleCase");
		AmmoRefill.NativeFieldInfoPtr_desertCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "desertCase");
		AmmoRefill.NativeFieldInfoPtr_greenCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "greenCase");
		AmmoRefill.NativeFieldInfoPtr_snowCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "snowCase");
		AmmoRefill.NativeFieldInfoPtr_woodTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "woodTable");
		AmmoRefill.NativeFieldInfoPtr_metalTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "metalTable");
		AmmoRefill.NativeFieldInfoPtr_spawnCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "spawnCount");
		AmmoRefill.NativeFieldInfoPtr_OnAmmoBoxOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "OnAmmoBoxOpened");
		AmmoRefill.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, "currentIndex");
		AmmoRefill.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, 100668453);
		AmmoRefill.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, 100668454);
		AmmoRefill.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, 100668455);
		AmmoRefill.NativeMethodInfoPtr_ReplenishMags_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, 100668456);
		AmmoRefill.NativeMethodInfoPtr_SpawnItemsInCrate_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, 100668457);
		AmmoRefill.NativeMethodInfoPtr_SpawnExtras_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, 100668458);
		AmmoRefill.NativeMethodInfoPtr_SpawnThing_Public_Void_BaseData_byref_AmmoType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, 100668459);
		AmmoRefill.NativeMethodInfoPtr_ReallySpawnThing_Public_Void_AssetReferenceData_AmmoType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, 100668460);
		AmmoRefill.NativeMethodInfoPtr_ClearMagsInCrate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, 100668461);
		AmmoRefill.NativeMethodInfoPtr_ResetCrate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, 100668462);
		AmmoRefill.NativeMethodInfoPtr_HideObject_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, 100668463);
		AmmoRefill.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr, 100668464);
	}

	// Token: 0x06004047 RID: 16455 RVA: 0x0000210C File Offset: 0x0000030C
	public AmmoRefill(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170016B0 RID: 5808
	// (get) Token: 0x06004048 RID: 16456 RVA: 0x00103F84 File Offset: 0x00102184
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Il2CppSystem.Type Il2CppType
	{
		get
		{
			return Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AmmoRefill>.NativeClassPtr));
		}
	}

	// Token: 0x170016B1 RID: 5809
	// (get) Token: 0x06004049 RID: 16457 RVA: 0x00103F98 File Offset: 0x00102198
	// (set) Token: 0x0600404A RID: 16458 RVA: 0x00103FCC File Offset: 0x001021CC
	public unsafe PickupLibrary pickupLibrary
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_pickupLibrary);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new PickupLibrary(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_pickupLibrary), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170016B2 RID: 5810
	// (get) Token: 0x0600404B RID: 16459 RVA: 0x00103FF4 File Offset: 0x001021F4
	// (set) Token: 0x0600404C RID: 16460 RVA: 0x00104028 File Offset: 0x00102228
	public unsafe PickupHolster thisHolster
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_thisHolster);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new PickupHolster(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_thisHolster), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170016B3 RID: 5811
	// (get) Token: 0x0600404D RID: 16461 RVA: 0x00104050 File Offset: 0x00102250
	// (set) Token: 0x0600404E RID: 16462 RVA: 0x00104078 File Offset: 0x00102278
	public unsafe bool hasSpawned
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_hasSpawned);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_hasSpawned)) = value;
		}
	}

	// Token: 0x170016B4 RID: 5812
	// (get) Token: 0x0600404F RID: 16463 RVA: 0x0010409C File Offset: 0x0010229C
	// (set) Token: 0x06004050 RID: 16464 RVA: 0x001040C4 File Offset: 0x001022C4
	public unsafe bool ShowTable
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_ShowTable);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_ShowTable)) = value;
		}
	}

	// Token: 0x170016B5 RID: 5813
	// (get) Token: 0x06004051 RID: 16465 RVA: 0x001040E8 File Offset: 0x001022E8
	// (set) Token: 0x06004052 RID: 16466 RVA: 0x00104110 File Offset: 0x00102310
	public unsafe int pouchAmmoCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_pouchAmmoCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_pouchAmmoCount)) = value;
		}
	}

	// Token: 0x170016B6 RID: 5814
	// (get) Token: 0x06004053 RID: 16467 RVA: 0x00104134 File Offset: 0x00102334
	// (set) Token: 0x06004054 RID: 16468 RVA: 0x0010415C File Offset: 0x0010235C
	public unsafe int currentAmmoCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_currentAmmoCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_currentAmmoCount)) = value;
		}
	}

	// Token: 0x170016B7 RID: 5815
	// (get) Token: 0x06004055 RID: 16469 RVA: 0x00104180 File Offset: 0x00102380
	// (set) Token: 0x06004056 RID: 16470 RVA: 0x001041A8 File Offset: 0x001023A8
	public unsafe bool refillOnSpawn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_refillOnSpawn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_refillOnSpawn)) = value;
		}
	}

	// Token: 0x170016B8 RID: 5816
	// (get) Token: 0x06004057 RID: 16471 RVA: 0x001041CC File Offset: 0x001023CC
	// (set) Token: 0x06004058 RID: 16472 RVA: 0x001041F4 File Offset: 0x001023F4
	public unsafe bool waitingToReplenish
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_waitingToReplenish);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_waitingToReplenish)) = value;
		}
	}

	// Token: 0x170016B9 RID: 5817
	// (get) Token: 0x06004059 RID: 16473 RVA: 0x00104218 File Offset: 0x00102418
	// (set) Token: 0x0600405A RID: 16474 RVA: 0x00104240 File Offset: 0x00102440
	public unsafe AmmoRefill.Type refillType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_refillType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_refillType)) = value;
		}
	}

	// Token: 0x170016BA RID: 5818
	// (get) Token: 0x0600405B RID: 16475 RVA: 0x00104264 File Offset: 0x00102464
	// (set) Token: 0x0600405C RID: 16476 RVA: 0x0010428C File Offset: 0x0010248C
	public unsafe bool hasBeenOpened
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_hasBeenOpened);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_hasBeenOpened)) = value;
		}
	}

	// Token: 0x170016BB RID: 5819
	// (get) Token: 0x0600405D RID: 16477 RVA: 0x001042B0 File Offset: 0x001024B0
	// (set) Token: 0x0600405E RID: 16478 RVA: 0x001042D8 File Offset: 0x001024D8
	public unsafe bool closeToRefill
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_closeToRefill);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_closeToRefill)) = value;
		}
	}

	// Token: 0x170016BC RID: 5820
	// (get) Token: 0x0600405F RID: 16479 RVA: 0x001042FC File Offset: 0x001024FC
	// (set) Token: 0x06004060 RID: 16480 RVA: 0x00104330 File Offset: 0x00102530
	public unsafe Transform spawnContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_spawnContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_spawnContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170016BD RID: 5821
	// (get) Token: 0x06004061 RID: 16481 RVA: 0x00104358 File Offset: 0x00102558
	// (set) Token: 0x06004062 RID: 16482 RVA: 0x0010438C File Offset: 0x0010258C
	public unsafe Il2CppReferenceArray<Transform> SpawnPositions
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_SpawnPositions);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_SpawnPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170016BE RID: 5822
	// (get) Token: 0x06004063 RID: 16483 RVA: 0x001043B4 File Offset: 0x001025B4
	// (set) Token: 0x06004064 RID: 16484 RVA: 0x001043E8 File Offset: 0x001025E8
	public unsafe Interactable_Openable thisBox
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_thisBox);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Interactable_Openable(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_thisBox), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170016BF RID: 5823
	// (get) Token: 0x06004065 RID: 16485 RVA: 0x00104410 File Offset: 0x00102610
	// (set) Token: 0x06004066 RID: 16486 RVA: 0x00104444 File Offset: 0x00102644
	public unsafe bl_MiniMapItem icon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_icon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new bl_MiniMapItem(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170016C0 RID: 5824
	// (get) Token: 0x06004067 RID: 16487 RVA: 0x0010446C File Offset: 0x0010266C
	// (set) Token: 0x06004068 RID: 16488 RVA: 0x001044A0 File Offset: 0x001026A0
	public unsafe GameObject jungleCase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_jungleCase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_jungleCase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170016C1 RID: 5825
	// (get) Token: 0x06004069 RID: 16489 RVA: 0x001044C8 File Offset: 0x001026C8
	// (set) Token: 0x0600406A RID: 16490 RVA: 0x001044FC File Offset: 0x001026FC
	public unsafe GameObject desertCase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_desertCase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_desertCase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170016C2 RID: 5826
	// (get) Token: 0x0600406B RID: 16491 RVA: 0x00104524 File Offset: 0x00102724
	// (set) Token: 0x0600406C RID: 16492 RVA: 0x00104558 File Offset: 0x00102758
	public unsafe GameObject greenCase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_greenCase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_greenCase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170016C3 RID: 5827
	// (get) Token: 0x0600406D RID: 16493 RVA: 0x00104580 File Offset: 0x00102780
	// (set) Token: 0x0600406E RID: 16494 RVA: 0x001045B4 File Offset: 0x001027B4
	public unsafe GameObject snowCase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_snowCase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_snowCase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170016C4 RID: 5828
	// (get) Token: 0x0600406F RID: 16495 RVA: 0x001045DC File Offset: 0x001027DC
	// (set) Token: 0x06004070 RID: 16496 RVA: 0x00104610 File Offset: 0x00102810
	public unsafe GameObject woodTable
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_woodTable);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_woodTable), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170016C5 RID: 5829
	// (get) Token: 0x06004071 RID: 16497 RVA: 0x00104638 File Offset: 0x00102838
	// (set) Token: 0x06004072 RID: 16498 RVA: 0x0010466C File Offset: 0x0010286C
	public unsafe GameObject metalTable
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_metalTable);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_metalTable), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170016C6 RID: 5830
	// (get) Token: 0x06004073 RID: 16499 RVA: 0x00104694 File Offset: 0x00102894
	// (set) Token: 0x06004074 RID: 16500 RVA: 0x001046BC File Offset: 0x001028BC
	public unsafe int spawnCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_spawnCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_spawnCount)) = value;
		}
	}

	// Token: 0x170016C7 RID: 5831
	// (get) Token: 0x06004075 RID: 16501 RVA: 0x001046E0 File Offset: 0x001028E0
	// (set) Token: 0x06004076 RID: 16502 RVA: 0x00104714 File Offset: 0x00102914
	public unsafe Action OnAmmoBoxOpened
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_OnAmmoBoxOpened);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Action(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_OnAmmoBoxOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170016C8 RID: 5832
	// (get) Token: 0x06004077 RID: 16503 RVA: 0x0010473C File Offset: 0x0010293C
	// (set) Token: 0x06004078 RID: 16504 RVA: 0x00104764 File Offset: 0x00102964
	public unsafe int currentIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_currentIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoRefill.NativeFieldInfoPtr_currentIndex)) = value;
		}
	}

	// Token: 0x0400294F RID: 10575
	private static readonly IntPtr NativeFieldInfoPtr_pickupLibrary;

	// Token: 0x04002950 RID: 10576
	private static readonly IntPtr NativeFieldInfoPtr_thisHolster;

	// Token: 0x04002951 RID: 10577
	private static readonly IntPtr NativeFieldInfoPtr_hasSpawned;

	// Token: 0x04002952 RID: 10578
	private static readonly IntPtr NativeFieldInfoPtr_ShowTable;

	// Token: 0x04002953 RID: 10579
	private static readonly IntPtr NativeFieldInfoPtr_pouchAmmoCount;

	// Token: 0x04002954 RID: 10580
	private static readonly IntPtr NativeFieldInfoPtr_currentAmmoCount;

	// Token: 0x04002955 RID: 10581
	private static readonly IntPtr NativeFieldInfoPtr_refillOnSpawn;

	// Token: 0x04002956 RID: 10582
	private static readonly IntPtr NativeFieldInfoPtr_waitingToReplenish;

	// Token: 0x04002957 RID: 10583
	private static readonly IntPtr NativeFieldInfoPtr_refillType;

	// Token: 0x04002958 RID: 10584
	private static readonly IntPtr NativeFieldInfoPtr_hasBeenOpened;

	// Token: 0x04002959 RID: 10585
	private static readonly IntPtr NativeFieldInfoPtr_closeToRefill;

	// Token: 0x0400295A RID: 10586
	private static readonly IntPtr NativeFieldInfoPtr_spawnContainer;

	// Token: 0x0400295B RID: 10587
	private static readonly IntPtr NativeFieldInfoPtr_SpawnPositions;

	// Token: 0x0400295C RID: 10588
	private static readonly IntPtr NativeFieldInfoPtr_thisBox;

	// Token: 0x0400295D RID: 10589
	private static readonly IntPtr NativeFieldInfoPtr_icon;

	// Token: 0x0400295E RID: 10590
	private static readonly IntPtr NativeFieldInfoPtr_jungleCase;

	// Token: 0x0400295F RID: 10591
	private static readonly IntPtr NativeFieldInfoPtr_desertCase;

	// Token: 0x04002960 RID: 10592
	private static readonly IntPtr NativeFieldInfoPtr_greenCase;

	// Token: 0x04002961 RID: 10593
	private static readonly IntPtr NativeFieldInfoPtr_snowCase;

	// Token: 0x04002962 RID: 10594
	private static readonly IntPtr NativeFieldInfoPtr_woodTable;

	// Token: 0x04002963 RID: 10595
	private static readonly IntPtr NativeFieldInfoPtr_metalTable;

	// Token: 0x04002964 RID: 10596
	private static readonly IntPtr NativeFieldInfoPtr_spawnCount;

	// Token: 0x04002965 RID: 10597
	private static readonly IntPtr NativeFieldInfoPtr_OnAmmoBoxOpened;

	// Token: 0x04002966 RID: 10598
	private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

	// Token: 0x04002967 RID: 10599
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04002968 RID: 10600
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04002969 RID: 10601
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x0400296A RID: 10602
	private static readonly IntPtr NativeMethodInfoPtr_ReplenishMags_Public_Void_0;

	// Token: 0x0400296B RID: 10603
	private static readonly IntPtr NativeMethodInfoPtr_SpawnItemsInCrate_Public_Void_Boolean_0;

	// Token: 0x0400296C RID: 10604
	private static readonly IntPtr NativeMethodInfoPtr_SpawnExtras_Public_Void_0;

	// Token: 0x0400296D RID: 10605
	private static readonly IntPtr NativeMethodInfoPtr_SpawnThing_Public_Void_BaseData_byref_AmmoType_Int32_Int32_0;

	// Token: 0x0400296E RID: 10606
	private static readonly IntPtr NativeMethodInfoPtr_ReallySpawnThing_Public_Void_AssetReferenceData_AmmoType_Int32_0;

	// Token: 0x0400296F RID: 10607
	private static readonly IntPtr NativeMethodInfoPtr_ClearMagsInCrate_Public_Void_0;

	// Token: 0x04002970 RID: 10608
	private static readonly IntPtr NativeMethodInfoPtr_ResetCrate_Public_Void_0;

	// Token: 0x04002971 RID: 10609
	private static readonly IntPtr NativeMethodInfoPtr_HideObject_Public_Void_0;

	// Token: 0x04002972 RID: 10610
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000332 RID: 818
	public enum Type
	{
		// Token: 0x04002974 RID: 10612
		Pouch,
		// Token: 0x04002975 RID: 10613
		Crate,
		// Token: 0x04002976 RID: 10614
		Pile
	}
}
