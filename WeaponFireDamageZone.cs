using System;
using System.Runtime.InteropServices;
using DPI.Networking;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000525 RID: 1317
public class WeaponFireDamageZone : MonoBehaviour
{
	// Token: 0x06006BC4 RID: 27588 RVA: 0x001B10B4 File Offset: 0x001AF2B4
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponFireDamageZone.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006BC5 RID: 27589 RVA: 0x001B10F8 File Offset: 0x001AF2F8
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponFireDamageZone.NativeMethodInfoPtr_OnDestroy_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006BC6 RID: 27590 RVA: 0x001B113C File Offset: 0x001AF33C
	[CallerCount(0)]
	public unsafe void SetLastDamageSources([Optional] DPIPlayer lastPlayerDamageSource, [Optional] int lastAIDamageSourceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastPlayerDamageSource);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastAIDamageSourceID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponFireDamageZone.NativeMethodInfoPtr_SetLastDamageSources_Protected_Void_DPIPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006BC7 RID: 27591 RVA: 0x001B11A8 File Offset: 0x001AF3A8
	[CallerCount(0)]
	public unsafe void OnFired(DPIPlayer playerSource, int aiSource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerSource);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aiSource;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponFireDamageZone.NativeMethodInfoPtr_OnFired_Protected_Void_DPIPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006BC8 RID: 27592 RVA: 0x001B1214 File Offset: 0x001AF414
	[CallerCount(0)]
	public unsafe bool IsFireDamageOriginInsideSomething()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponFireDamageZone.NativeMethodInfoPtr_IsFireDamageOriginInsideSomething_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06006BC9 RID: 27593 RVA: 0x001B1264 File Offset: 0x001AF464
	[CallerCount(0)]
	public unsafe void CheckForDamage(DamageController damageController)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(damageController);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponFireDamageZone.NativeMethodInfoPtr_CheckForDamage_Protected_Void_DamageController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006BCA RID: 27594 RVA: 0x001B12C0 File Offset: 0x001AF4C0
	[CallerCount(0)]
	public unsafe void TryApplyDamage(float damage, DamageController damageController, [Optional] WarPlayerScript warPlayerScript)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref damage;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(damageController);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(warPlayerScript);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponFireDamageZone.NativeMethodInfoPtr_TryApplyDamage_Protected_Void_Single_DamageController_WarPlayerScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006BCB RID: 27595 RVA: 0x001B1344 File Offset: 0x001AF544
	[CallerCount(0)]
	public unsafe WeaponFireDamageZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponFireDamageZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006BCC RID: 27596 RVA: 0x001B1390 File Offset: 0x001AF590
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponFireDamageZone()
	{
		Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponFireDamageZone");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr);
		WeaponFireDamageZone.NativeFieldInfoPtr_FireWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "FireWeapon");
		WeaponFireDamageZone.NativeFieldInfoPtr_FireDamageOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "FireDamageOrigin");
		WeaponFireDamageZone.NativeFieldInfoPtr_DamageFalloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "DamageFalloff");
		WeaponFireDamageZone.NativeFieldInfoPtr_DamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "DamageType");
		WeaponFireDamageZone.NativeFieldInfoPtr_DamageAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "DamageAmount");
		WeaponFireDamageZone.NativeFieldInfoPtr_DamageForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "DamageForce");
		WeaponFireDamageZone.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "range");
		WeaponFireDamageZone.NativeFieldInfoPtr_spread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "spread");
		WeaponFireDamageZone.NativeFieldInfoPtr_DoLOSRaycast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "DoLOSRaycast");
		WeaponFireDamageZone.NativeFieldInfoPtr_LOSRaycastPenetrates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "LOSRaycastPenetrates");
		WeaponFireDamageZone.NativeFieldInfoPtr_LOSMaskType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "LOSMaskType");
		WeaponFireDamageZone.NativeFieldInfoPtr_DamageSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "DamageSelf");
		WeaponFireDamageZone.NativeFieldInfoPtr_InflictTinitus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "InflictTinitus");
		WeaponFireDamageZone.NativeFieldInfoPtr_ShowDebugLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "ShowDebugLogs");
		WeaponFireDamageZone.NativeFieldInfoPtr_LastPlayerDamageSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "LastPlayerDamageSource");
		WeaponFireDamageZone.NativeFieldInfoPtr_LastAIDamageSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "LastAIDamageSource");
		WeaponFireDamageZone.NativeFieldInfoPtr_losPenetrationFudgeForwardOnHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "losPenetrationFudgeForwardOnHit");
		WeaponFireDamageZone.NativeFieldInfoPtr_losPenetrationMaxObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "losPenetrationMaxObjects");
		WeaponFireDamageZone.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "angle");
		WeaponFireDamageZone.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, 100671865);
		WeaponFireDamageZone.NativeMethodInfoPtr_OnDestroy_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, 100671866);
		WeaponFireDamageZone.NativeMethodInfoPtr_SetLastDamageSources_Protected_Void_DPIPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, 100671867);
		WeaponFireDamageZone.NativeMethodInfoPtr_OnFired_Protected_Void_DPIPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, 100671868);
		WeaponFireDamageZone.NativeMethodInfoPtr_IsFireDamageOriginInsideSomething_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, 100671869);
		WeaponFireDamageZone.NativeMethodInfoPtr_CheckForDamage_Protected_Void_DamageController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, 100671870);
		WeaponFireDamageZone.NativeMethodInfoPtr_TryApplyDamage_Protected_Void_Single_DamageController_WarPlayerScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, 100671871);
		WeaponFireDamageZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, 100671872);
	}

	// Token: 0x06006BCD RID: 27597 RVA: 0x0000210C File Offset: 0x0000030C
	public WeaponFireDamageZone(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700264C RID: 9804
	// (get) Token: 0x06006BCE RID: 27598 RVA: 0x001B15DC File Offset: 0x001AF7DC
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr));
		}
	}

	// Token: 0x1700264D RID: 9805
	// (get) Token: 0x06006BCF RID: 27599 RVA: 0x001B15F0 File Offset: 0x001AF7F0
	// (set) Token: 0x06006BD0 RID: 27600 RVA: 0x001B1624 File Offset: 0x001AF824
	public unsafe Weapon FireWeapon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_FireWeapon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Weapon(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_FireWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700264E RID: 9806
	// (get) Token: 0x06006BD1 RID: 27601 RVA: 0x001B164C File Offset: 0x001AF84C
	// (set) Token: 0x06006BD2 RID: 27602 RVA: 0x001B1680 File Offset: 0x001AF880
	public unsafe Transform FireDamageOrigin
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_FireDamageOrigin);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_FireDamageOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700264F RID: 9807
	// (get) Token: 0x06006BD3 RID: 27603 RVA: 0x001B16A8 File Offset: 0x001AF8A8
	// (set) Token: 0x06006BD4 RID: 27604 RVA: 0x001B16DC File Offset: 0x001AF8DC
	public unsafe AnimationCurve DamageFalloff
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_DamageFalloff);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AnimationCurve(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_DamageFalloff), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002650 RID: 9808
	// (get) Token: 0x06006BD5 RID: 27605 RVA: 0x001B1704 File Offset: 0x001AF904
	// (set) Token: 0x06006BD6 RID: 27606 RVA: 0x001B172C File Offset: 0x001AF92C
	public unsafe DamageType DamageType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_DamageType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_DamageType)) = value;
		}
	}

	// Token: 0x17002651 RID: 9809
	// (get) Token: 0x06006BD7 RID: 27607 RVA: 0x001B1750 File Offset: 0x001AF950
	// (set) Token: 0x06006BD8 RID: 27608 RVA: 0x001B1778 File Offset: 0x001AF978
	public unsafe float DamageAmount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_DamageAmount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_DamageAmount)) = value;
		}
	}

	// Token: 0x17002652 RID: 9810
	// (get) Token: 0x06006BD9 RID: 27609 RVA: 0x001B179C File Offset: 0x001AF99C
	// (set) Token: 0x06006BDA RID: 27610 RVA: 0x001B17C4 File Offset: 0x001AF9C4
	public unsafe float DamageForce
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_DamageForce);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_DamageForce)) = value;
		}
	}

	// Token: 0x17002653 RID: 9811
	// (get) Token: 0x06006BDB RID: 27611 RVA: 0x001B17E8 File Offset: 0x001AF9E8
	// (set) Token: 0x06006BDC RID: 27612 RVA: 0x001B1810 File Offset: 0x001AFA10
	public unsafe float range
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_range);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_range)) = value;
		}
	}

	// Token: 0x17002654 RID: 9812
	// (get) Token: 0x06006BDD RID: 27613 RVA: 0x001B1834 File Offset: 0x001AFA34
	// (set) Token: 0x06006BDE RID: 27614 RVA: 0x001B185C File Offset: 0x001AFA5C
	public unsafe float spread
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_spread);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_spread)) = value;
		}
	}

	// Token: 0x17002655 RID: 9813
	// (get) Token: 0x06006BDF RID: 27615 RVA: 0x001B1880 File Offset: 0x001AFA80
	// (set) Token: 0x06006BE0 RID: 27616 RVA: 0x001B18A8 File Offset: 0x001AFAA8
	public unsafe bool DoLOSRaycast
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_DoLOSRaycast);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_DoLOSRaycast)) = value;
		}
	}

	// Token: 0x17002656 RID: 9814
	// (get) Token: 0x06006BE1 RID: 27617 RVA: 0x001B18CC File Offset: 0x001AFACC
	// (set) Token: 0x06006BE2 RID: 27618 RVA: 0x001B18F4 File Offset: 0x001AFAF4
	public unsafe bool LOSRaycastPenetrates
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_LOSRaycastPenetrates);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_LOSRaycastPenetrates)) = value;
		}
	}

	// Token: 0x17002657 RID: 9815
	// (get) Token: 0x06006BE3 RID: 27619 RVA: 0x001B1918 File Offset: 0x001AFB18
	// (set) Token: 0x06006BE4 RID: 27620 RVA: 0x001B1940 File Offset: 0x001AFB40
	public unsafe DamageMaskType LOSMaskType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_LOSMaskType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_LOSMaskType)) = value;
		}
	}

	// Token: 0x17002658 RID: 9816
	// (get) Token: 0x06006BE5 RID: 27621 RVA: 0x001B1964 File Offset: 0x001AFB64
	// (set) Token: 0x06006BE6 RID: 27622 RVA: 0x001B198C File Offset: 0x001AFB8C
	public unsafe bool DamageSelf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_DamageSelf);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_DamageSelf)) = value;
		}
	}

	// Token: 0x17002659 RID: 9817
	// (get) Token: 0x06006BE7 RID: 27623 RVA: 0x001B19B0 File Offset: 0x001AFBB0
	// (set) Token: 0x06006BE8 RID: 27624 RVA: 0x001B19D8 File Offset: 0x001AFBD8
	public unsafe bool InflictTinitus
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_InflictTinitus);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_InflictTinitus)) = value;
		}
	}

	// Token: 0x1700265A RID: 9818
	// (get) Token: 0x06006BE9 RID: 27625 RVA: 0x001B19FC File Offset: 0x001AFBFC
	// (set) Token: 0x06006BEA RID: 27626 RVA: 0x001B1A24 File Offset: 0x001AFC24
	public unsafe bool ShowDebugLogs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_ShowDebugLogs);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_ShowDebugLogs)) = value;
		}
	}

	// Token: 0x1700265B RID: 9819
	// (get) Token: 0x06006BEB RID: 27627 RVA: 0x001B1A48 File Offset: 0x001AFC48
	// (set) Token: 0x06006BEC RID: 27628 RVA: 0x001B1A7C File Offset: 0x001AFC7C
	public unsafe DPIPlayer LastPlayerDamageSource
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_LastPlayerDamageSource);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new DPIPlayer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_LastPlayerDamageSource), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700265C RID: 9820
	// (get) Token: 0x06006BED RID: 27629 RVA: 0x001B1AA4 File Offset: 0x001AFCA4
	// (set) Token: 0x06006BEE RID: 27630 RVA: 0x001B1ACC File Offset: 0x001AFCCC
	public unsafe int LastAIDamageSource
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_LastAIDamageSource);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_LastAIDamageSource)) = value;
		}
	}

	// Token: 0x1700265D RID: 9821
	// (get) Token: 0x06006BEF RID: 27631 RVA: 0x001B1AF0 File Offset: 0x001AFCF0
	// (set) Token: 0x06006BF0 RID: 27632 RVA: 0x001B1B0E File Offset: 0x001AFD0E
	public unsafe static float losPenetrationFudgeForwardOnHit
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(WeaponFireDamageZone.NativeFieldInfoPtr_losPenetrationFudgeForwardOnHit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WeaponFireDamageZone.NativeFieldInfoPtr_losPenetrationFudgeForwardOnHit, (void*)(&value));
		}
	}

	// Token: 0x1700265E RID: 9822
	// (get) Token: 0x06006BF1 RID: 27633 RVA: 0x001B1B20 File Offset: 0x001AFD20
	// (set) Token: 0x06006BF2 RID: 27634 RVA: 0x001B1B3E File Offset: 0x001AFD3E
	public unsafe static int losPenetrationMaxObjects
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(WeaponFireDamageZone.NativeFieldInfoPtr_losPenetrationMaxObjects, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WeaponFireDamageZone.NativeFieldInfoPtr_losPenetrationMaxObjects, (void*)(&value));
		}
	}

	// Token: 0x1700265F RID: 9823
	// (get) Token: 0x06006BF3 RID: 27635 RVA: 0x001B1B50 File Offset: 0x001AFD50
	// (set) Token: 0x06006BF4 RID: 27636 RVA: 0x001B1B78 File Offset: 0x001AFD78
	public unsafe float angle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_angle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.NativeFieldInfoPtr_angle)) = value;
		}
	}

	// Token: 0x040044AF RID: 17583
	private static readonly IntPtr NativeFieldInfoPtr_FireWeapon;

	// Token: 0x040044B0 RID: 17584
	private static readonly IntPtr NativeFieldInfoPtr_FireDamageOrigin;

	// Token: 0x040044B1 RID: 17585
	private static readonly IntPtr NativeFieldInfoPtr_DamageFalloff;

	// Token: 0x040044B2 RID: 17586
	private static readonly IntPtr NativeFieldInfoPtr_DamageType;

	// Token: 0x040044B3 RID: 17587
	private static readonly IntPtr NativeFieldInfoPtr_DamageAmount;

	// Token: 0x040044B4 RID: 17588
	private static readonly IntPtr NativeFieldInfoPtr_DamageForce;

	// Token: 0x040044B5 RID: 17589
	private static readonly IntPtr NativeFieldInfoPtr_range;

	// Token: 0x040044B6 RID: 17590
	private static readonly IntPtr NativeFieldInfoPtr_spread;

	// Token: 0x040044B7 RID: 17591
	private static readonly IntPtr NativeFieldInfoPtr_DoLOSRaycast;

	// Token: 0x040044B8 RID: 17592
	private static readonly IntPtr NativeFieldInfoPtr_LOSRaycastPenetrates;

	// Token: 0x040044B9 RID: 17593
	private static readonly IntPtr NativeFieldInfoPtr_LOSMaskType;

	// Token: 0x040044BA RID: 17594
	private static readonly IntPtr NativeFieldInfoPtr_DamageSelf;

	// Token: 0x040044BB RID: 17595
	private static readonly IntPtr NativeFieldInfoPtr_InflictTinitus;

	// Token: 0x040044BC RID: 17596
	private static readonly IntPtr NativeFieldInfoPtr_ShowDebugLogs;

	// Token: 0x040044BD RID: 17597
	private static readonly IntPtr NativeFieldInfoPtr_LastPlayerDamageSource;

	// Token: 0x040044BE RID: 17598
	private static readonly IntPtr NativeFieldInfoPtr_LastAIDamageSource;

	// Token: 0x040044BF RID: 17599
	private static readonly IntPtr NativeFieldInfoPtr_losPenetrationFudgeForwardOnHit;

	// Token: 0x040044C0 RID: 17600
	private static readonly IntPtr NativeFieldInfoPtr_losPenetrationMaxObjects;

	// Token: 0x040044C1 RID: 17601
	private static readonly IntPtr NativeFieldInfoPtr_angle;

	// Token: 0x040044C2 RID: 17602
	private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

	// Token: 0x040044C3 RID: 17603
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Void_0;

	// Token: 0x040044C4 RID: 17604
	private static readonly IntPtr NativeMethodInfoPtr_SetLastDamageSources_Protected_Void_DPIPlayer_Int32_0;

	// Token: 0x040044C5 RID: 17605
	private static readonly IntPtr NativeMethodInfoPtr_OnFired_Protected_Void_DPIPlayer_Int32_0;

	// Token: 0x040044C6 RID: 17606
	private static readonly IntPtr NativeMethodInfoPtr_IsFireDamageOriginInsideSomething_Protected_Boolean_0;

	// Token: 0x040044C7 RID: 17607
	private static readonly IntPtr NativeMethodInfoPtr_CheckForDamage_Protected_Void_DamageController_0;

	// Token: 0x040044C8 RID: 17608
	private static readonly IntPtr NativeMethodInfoPtr_TryApplyDamage_Protected_Void_Single_DamageController_WarPlayerScript_0;

	// Token: 0x040044C9 RID: 17609
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000526 RID: 1318
	[ObfuscatedName("WeaponFireDamageZone/<>c__DisplayClass22_0")]
	public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
	{
		// Token: 0x06006BF5 RID: 27637 RVA: 0x001B1B9C File Offset: 0x001AFD9C
		[CallerCount(0)]
		public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponFireDamageZone.__c__DisplayClass22_0>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponFireDamageZone.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BF6 RID: 27638 RVA: 0x001B1BE8 File Offset: 0x001AFDE8
		[CallerCount(0)]
		public unsafe bool _OnFired_b__0(DamageController item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponFireDamageZone.__c__DisplayClass22_0.NativeMethodInfoPtr__OnFired_b__0_Internal_Boolean_DamageController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006BF7 RID: 27639 RVA: 0x001B1C50 File Offset: 0x001AFE50
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass22_0()
		{
			Il2CppClassPointerStore<WeaponFireDamageZone.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeaponFireDamageZone>.NativeClassPtr, "<>c__DisplayClass22_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponFireDamageZone.__c__DisplayClass22_0>.NativeClassPtr);
			WeaponFireDamageZone.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
			WeaponFireDamageZone.__c__DisplayClass22_0.NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone.__c__DisplayClass22_0>.NativeClassPtr, "origin");
			WeaponFireDamageZone.__c__DisplayClass22_0.NativeFieldInfoPtr_damageDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponFireDamageZone.__c__DisplayClass22_0>.NativeClassPtr, "damageDirection");
			WeaponFireDamageZone.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponFireDamageZone.__c__DisplayClass22_0>.NativeClassPtr, 100671873);
			WeaponFireDamageZone.__c__DisplayClass22_0.NativeMethodInfoPtr__OnFired_b__0_Internal_Boolean_DamageController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponFireDamageZone.__c__DisplayClass22_0>.NativeClassPtr, 100671874);
		}

		// Token: 0x06006BF8 RID: 27640 RVA: 0x00002988 File Offset: 0x00000B88
		public __c__DisplayClass22_0(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x06006BF9 RID: 27641 RVA: 0x001B1CDF File Offset: 0x001AFEDF
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponFireDamageZone.__c__DisplayClass22_0>.NativeClassPtr));
			}
		}

		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x06006BFA RID: 27642 RVA: 0x001B1CF0 File Offset: 0x001AFEF0
		// (set) Token: 0x06006BFB RID: 27643 RVA: 0x001B1D24 File Offset: 0x001AFF24
		public unsafe WeaponFireDamageZone __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new WeaponFireDamageZone(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x06006BFC RID: 27644 RVA: 0x001B1D4C File Offset: 0x001AFF4C
		// (set) Token: 0x06006BFD RID: 27645 RVA: 0x001B1D74 File Offset: 0x001AFF74
		public unsafe Vector3 origin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.__c__DisplayClass22_0.NativeFieldInfoPtr_origin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.__c__DisplayClass22_0.NativeFieldInfoPtr_origin)) = value;
			}
		}

		// Token: 0x17002663 RID: 9827
		// (get) Token: 0x06006BFE RID: 27646 RVA: 0x001B1D98 File Offset: 0x001AFF98
		// (set) Token: 0x06006BFF RID: 27647 RVA: 0x001B1DC0 File Offset: 0x001AFFC0
		public unsafe Vector3 damageDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.__c__DisplayClass22_0.NativeFieldInfoPtr_damageDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponFireDamageZone.__c__DisplayClass22_0.NativeFieldInfoPtr_damageDirection)) = value;
			}
		}

		// Token: 0x040044CA RID: 17610
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040044CB RID: 17611
		private static readonly IntPtr NativeFieldInfoPtr_origin;

		// Token: 0x040044CC RID: 17612
		private static readonly IntPtr NativeFieldInfoPtr_damageDirection;

		// Token: 0x040044CD RID: 17613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040044CE RID: 17614
		private static readonly IntPtr NativeMethodInfoPtr__OnFired_b__0_Internal_Boolean_DamageController_0;
	}
}
