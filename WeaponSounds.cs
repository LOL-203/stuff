using System;
using System.Runtime.InteropServices;
using AK.Wwise;
using Il2CppSystem;
using Onward.Weapons;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200015E RID: 350
public class WeaponSounds : MonoBehaviour
{
	// Token: 0x06001792 RID: 6034 RVA: 0x0005EACC File Offset: 0x0005CCCC
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001793 RID: 6035 RVA: 0x0005EB10 File Offset: 0x0005CD10
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x0005EB54 File Offset: 0x0005CD54
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001795 RID: 6037 RVA: 0x0005EB98 File Offset: 0x0005CD98
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_OnDestroy_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001796 RID: 6038 RVA: 0x0005EBDC File Offset: 0x0005CDDC
	[CallerCount(0)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x0005EC20 File Offset: 0x0005CE20
	[CallerCount(0)]
	public unsafe void PlayShootSound(Transform target, bool isSuppressed, bool isLocal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSuppressed;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLocal;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_PlayShootSound_Public_Void_Transform_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x0005ECA0 File Offset: 0x0005CEA0
	[CallerCount(0)]
	public unsafe void PlayBoltSlapSound(Transform position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_PlayBoltSlapSound_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001799 RID: 6041 RVA: 0x0005ECFC File Offset: 0x0005CEFC
	[CallerCount(0)]
	public unsafe void PlayMagSlapSound(Transform position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_PlayMagSlapSound_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x0005ED58 File Offset: 0x0005CF58
	[CallerCount(0)]
	public unsafe void PlayBoltLockSound(Transform position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_PlayBoltLockSound_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600179B RID: 6043 RVA: 0x0005EDB4 File Offset: 0x0005CFB4
	[CallerCount(0)]
	public unsafe void PlayDryFireSound(Transform target, bool isLocal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLocal;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_PlayDryFireSound_Public_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600179C RID: 6044 RVA: 0x0005EE20 File Offset: 0x0005D020
	[CallerCount(0)]
	public unsafe void PlayClickSound(Transform target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_PlayClickSound_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600179D RID: 6045 RVA: 0x0005EE7C File Offset: 0x0005D07C
	[CallerCount(0)]
	public unsafe void PlayFiremodeSelectionSound(Transform target, bool isAlternateFiremode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAlternateFiremode;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_PlayFiremodeSelectionSound_Public_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600179E RID: 6046 RVA: 0x0005EEE8 File Offset: 0x0005D0E8
	[CallerCount(0)]
	public unsafe void PlaySemiAutoFiremodeSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_PlaySemiAutoFiremodeSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600179F RID: 6047 RVA: 0x0005EF2C File Offset: 0x0005D12C
	[CallerCount(0)]
	public unsafe void PlayFullAutoOrBurstFiremodeSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_PlayFullAutoOrBurstFiremodeSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017A0 RID: 6048 RVA: 0x0005EF70 File Offset: 0x0005D170
	[CallerCount(0)]
	public unsafe void PlayMagSound(Vector3 position, bool isMagGoingIn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref position;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMagGoingIn;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_PlayMagSound_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017A1 RID: 6049 RVA: 0x0005EFD8 File Offset: 0x0005D1D8
	[CallerCount(0)]
	public unsafe void PlayBoltSound(Vector3 position, bool isBoltGoingForward)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref position;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isBoltGoingForward;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_PlayBoltSound_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017A2 RID: 6050 RVA: 0x0005F040 File Offset: 0x0005D240
	[CallerCount(0)]
	public unsafe void PlayAlternateFireSound(AK.Wwise.Event wwiseEvent, [Optional] Transform transformToPlayAt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wwiseEvent);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transformToPlayAt);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_PlayAlternateFireSound_Public_Void_Event_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x0005F0B4 File Offset: 0x0005D2B4
	[CallerCount(0)]
	public unsafe void SetAudioEmitterPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr_SetAudioEmitterPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017A4 RID: 6052 RVA: 0x0005F0F8 File Offset: 0x0005D2F8
	[CallerCount(0)]
	public unsafe WeaponSounds() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponSounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x0005F144 File Offset: 0x0005D344
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponSounds()
	{
		Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponSounds");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr);
		WeaponSounds.NativeFieldInfoPtr_Weapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "Weapon");
		WeaponSounds.NativeFieldInfoPtr_pickupGun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "pickupGun");
		WeaponSounds.NativeFieldInfoPtr_fireSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "fireSelector");
		WeaponSounds.NativeFieldInfoPtr_FirePlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "FirePlayEvent");
		WeaponSounds.NativeFieldInfoPtr_DryFirePlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "DryFirePlayEvent");
		WeaponSounds.NativeFieldInfoPtr_FiremodeClickPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "FiremodeClickPlayEvent");
		WeaponSounds.NativeFieldInfoPtr_FiremodeClickAlternatePlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "FiremodeClickAlternatePlayEvent");
		WeaponSounds.NativeFieldInfoPtr_GenericClickPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "GenericClickPlayEvent");
		WeaponSounds.NativeFieldInfoPtr_MagInPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "MagInPlayEvent");
		WeaponSounds.NativeFieldInfoPtr_MagOutPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "MagOutPlayEvent");
		WeaponSounds.NativeFieldInfoPtr_BoltForwardPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "BoltForwardPlayEvent");
		WeaponSounds.NativeFieldInfoPtr_BoltBackPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "BoltBackPlayEvent");
		WeaponSounds.NativeFieldInfoPtr_BoltSlapPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "BoltSlapPlayEvent");
		WeaponSounds.NativeFieldInfoPtr_BoltLockPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "BoltLockPlayEvent");
		WeaponSounds.NativeFieldInfoPtr_MagSlapPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "MagSlapPlayEvent");
		WeaponSounds.NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "isInitialized");
		WeaponSounds.NativeFieldInfoPtr_audioEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "audioEmitter");
		WeaponSounds.NativeFieldInfoPtr__casingSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, "_casingSpawnPoint");
		WeaponSounds.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665187);
		WeaponSounds.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665188);
		WeaponSounds.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665189);
		WeaponSounds.NativeMethodInfoPtr_OnDestroy_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665190);
		WeaponSounds.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665191);
		WeaponSounds.NativeMethodInfoPtr_PlayShootSound_Public_Void_Transform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665192);
		WeaponSounds.NativeMethodInfoPtr_PlayBoltSlapSound_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665193);
		WeaponSounds.NativeMethodInfoPtr_PlayMagSlapSound_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665194);
		WeaponSounds.NativeMethodInfoPtr_PlayBoltLockSound_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665195);
		WeaponSounds.NativeMethodInfoPtr_PlayDryFireSound_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665196);
		WeaponSounds.NativeMethodInfoPtr_PlayClickSound_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665197);
		WeaponSounds.NativeMethodInfoPtr_PlayFiremodeSelectionSound_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665198);
		WeaponSounds.NativeMethodInfoPtr_PlaySemiAutoFiremodeSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665199);
		WeaponSounds.NativeMethodInfoPtr_PlayFullAutoOrBurstFiremodeSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665200);
		WeaponSounds.NativeMethodInfoPtr_PlayMagSound_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665201);
		WeaponSounds.NativeMethodInfoPtr_PlayBoltSound_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665202);
		WeaponSounds.NativeMethodInfoPtr_PlayAlternateFireSound_Public_Void_Event_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665203);
		WeaponSounds.NativeMethodInfoPtr_SetAudioEmitterPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665204);
		WeaponSounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr, 100665205);
	}

	// Token: 0x060017A6 RID: 6054 RVA: 0x0000210C File Offset: 0x0000030C
	public WeaponSounds(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000822 RID: 2082
	// (get) Token: 0x060017A7 RID: 6055 RVA: 0x0005F458 File Offset: 0x0005D658
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponSounds>.NativeClassPtr));
		}
	}

	// Token: 0x17000823 RID: 2083
	// (get) Token: 0x060017A8 RID: 6056 RVA: 0x0005F46C File Offset: 0x0005D66C
	// (set) Token: 0x060017A9 RID: 6057 RVA: 0x0005F4A0 File Offset: 0x0005D6A0
	public unsafe Weapon Weapon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_Weapon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Weapon(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_Weapon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000824 RID: 2084
	// (get) Token: 0x060017AA RID: 6058 RVA: 0x0005F4C8 File Offset: 0x0005D6C8
	// (set) Token: 0x060017AB RID: 6059 RVA: 0x0005F4FC File Offset: 0x0005D6FC
	public unsafe Pickup_Gun pickupGun
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_pickupGun);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Pickup_Gun(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_pickupGun), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000825 RID: 2085
	// (get) Token: 0x060017AC RID: 6060 RVA: 0x0005F524 File Offset: 0x0005D724
	// (set) Token: 0x060017AD RID: 6061 RVA: 0x0005F558 File Offset: 0x0005D758
	public unsafe FireSelector fireSelector
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_fireSelector);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new FireSelector(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_fireSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000826 RID: 2086
	// (get) Token: 0x060017AE RID: 6062 RVA: 0x0005F580 File Offset: 0x0005D780
	// (set) Token: 0x060017AF RID: 6063 RVA: 0x0005F5B4 File Offset: 0x0005D7B4
	public unsafe AK.Wwise.Event FirePlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_FirePlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_FirePlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000827 RID: 2087
	// (get) Token: 0x060017B0 RID: 6064 RVA: 0x0005F5DC File Offset: 0x0005D7DC
	// (set) Token: 0x060017B1 RID: 6065 RVA: 0x0005F610 File Offset: 0x0005D810
	public unsafe AK.Wwise.Event DryFirePlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_DryFirePlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_DryFirePlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000828 RID: 2088
	// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0005F638 File Offset: 0x0005D838
	// (set) Token: 0x060017B3 RID: 6067 RVA: 0x0005F66C File Offset: 0x0005D86C
	public unsafe AK.Wwise.Event FiremodeClickPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_FiremodeClickPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_FiremodeClickPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000829 RID: 2089
	// (get) Token: 0x060017B4 RID: 6068 RVA: 0x0005F694 File Offset: 0x0005D894
	// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0005F6C8 File Offset: 0x0005D8C8
	public unsafe AK.Wwise.Event FiremodeClickAlternatePlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_FiremodeClickAlternatePlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_FiremodeClickAlternatePlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700082A RID: 2090
	// (get) Token: 0x060017B6 RID: 6070 RVA: 0x0005F6F0 File Offset: 0x0005D8F0
	// (set) Token: 0x060017B7 RID: 6071 RVA: 0x0005F724 File Offset: 0x0005D924
	public unsafe AK.Wwise.Event GenericClickPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_GenericClickPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_GenericClickPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700082B RID: 2091
	// (get) Token: 0x060017B8 RID: 6072 RVA: 0x0005F74C File Offset: 0x0005D94C
	// (set) Token: 0x060017B9 RID: 6073 RVA: 0x0005F780 File Offset: 0x0005D980
	public unsafe AK.Wwise.Event MagInPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_MagInPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_MagInPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700082C RID: 2092
	// (get) Token: 0x060017BA RID: 6074 RVA: 0x0005F7A8 File Offset: 0x0005D9A8
	// (set) Token: 0x060017BB RID: 6075 RVA: 0x0005F7DC File Offset: 0x0005D9DC
	public unsafe AK.Wwise.Event MagOutPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_MagOutPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_MagOutPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700082D RID: 2093
	// (get) Token: 0x060017BC RID: 6076 RVA: 0x0005F804 File Offset: 0x0005DA04
	// (set) Token: 0x060017BD RID: 6077 RVA: 0x0005F838 File Offset: 0x0005DA38
	public unsafe AK.Wwise.Event BoltForwardPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_BoltForwardPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_BoltForwardPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700082E RID: 2094
	// (get) Token: 0x060017BE RID: 6078 RVA: 0x0005F860 File Offset: 0x0005DA60
	// (set) Token: 0x060017BF RID: 6079 RVA: 0x0005F894 File Offset: 0x0005DA94
	public unsafe AK.Wwise.Event BoltBackPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_BoltBackPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_BoltBackPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700082F RID: 2095
	// (get) Token: 0x060017C0 RID: 6080 RVA: 0x0005F8BC File Offset: 0x0005DABC
	// (set) Token: 0x060017C1 RID: 6081 RVA: 0x0005F8F0 File Offset: 0x0005DAF0
	public unsafe AK.Wwise.Event BoltSlapPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_BoltSlapPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_BoltSlapPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000830 RID: 2096
	// (get) Token: 0x060017C2 RID: 6082 RVA: 0x0005F918 File Offset: 0x0005DB18
	// (set) Token: 0x060017C3 RID: 6083 RVA: 0x0005F94C File Offset: 0x0005DB4C
	public unsafe AK.Wwise.Event BoltLockPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_BoltLockPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_BoltLockPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000831 RID: 2097
	// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0005F974 File Offset: 0x0005DB74
	// (set) Token: 0x060017C5 RID: 6085 RVA: 0x0005F9A8 File Offset: 0x0005DBA8
	public unsafe AK.Wwise.Event MagSlapPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_MagSlapPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_MagSlapPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000832 RID: 2098
	// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0005F9D0 File Offset: 0x0005DBD0
	// (set) Token: 0x060017C7 RID: 6087 RVA: 0x0005F9F8 File Offset: 0x0005DBF8
	public unsafe bool isInitialized
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_isInitialized);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_isInitialized)) = value;
		}
	}

	// Token: 0x17000833 RID: 2099
	// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0005FA1C File Offset: 0x0005DC1C
	// (set) Token: 0x060017C9 RID: 6089 RVA: 0x0005FA50 File Offset: 0x0005DC50
	public unsafe WeaponSoundsDetachedAudioEmitter audioEmitter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_audioEmitter);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WeaponSoundsDetachedAudioEmitter(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr_audioEmitter), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000834 RID: 2100
	// (get) Token: 0x060017CA RID: 6090 RVA: 0x0005FA78 File Offset: 0x0005DC78
	// (set) Token: 0x060017CB RID: 6091 RVA: 0x0005FAAC File Offset: 0x0005DCAC
	public unsafe Transform _casingSpawnPoint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr__casingSpawnPoint);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponSounds.NativeFieldInfoPtr__casingSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000F0C RID: 3852
	private static readonly IntPtr NativeFieldInfoPtr_Weapon;

	// Token: 0x04000F0D RID: 3853
	private static readonly IntPtr NativeFieldInfoPtr_pickupGun;

	// Token: 0x04000F0E RID: 3854
	private static readonly IntPtr NativeFieldInfoPtr_fireSelector;

	// Token: 0x04000F0F RID: 3855
	private static readonly IntPtr NativeFieldInfoPtr_FirePlayEvent;

	// Token: 0x04000F10 RID: 3856
	private static readonly IntPtr NativeFieldInfoPtr_DryFirePlayEvent;

	// Token: 0x04000F11 RID: 3857
	private static readonly IntPtr NativeFieldInfoPtr_FiremodeClickPlayEvent;

	// Token: 0x04000F12 RID: 3858
	private static readonly IntPtr NativeFieldInfoPtr_FiremodeClickAlternatePlayEvent;

	// Token: 0x04000F13 RID: 3859
	private static readonly IntPtr NativeFieldInfoPtr_GenericClickPlayEvent;

	// Token: 0x04000F14 RID: 3860
	private static readonly IntPtr NativeFieldInfoPtr_MagInPlayEvent;

	// Token: 0x04000F15 RID: 3861
	private static readonly IntPtr NativeFieldInfoPtr_MagOutPlayEvent;

	// Token: 0x04000F16 RID: 3862
	private static readonly IntPtr NativeFieldInfoPtr_BoltForwardPlayEvent;

	// Token: 0x04000F17 RID: 3863
	private static readonly IntPtr NativeFieldInfoPtr_BoltBackPlayEvent;

	// Token: 0x04000F18 RID: 3864
	private static readonly IntPtr NativeFieldInfoPtr_BoltSlapPlayEvent;

	// Token: 0x04000F19 RID: 3865
	private static readonly IntPtr NativeFieldInfoPtr_BoltLockPlayEvent;

	// Token: 0x04000F1A RID: 3866
	private static readonly IntPtr NativeFieldInfoPtr_MagSlapPlayEvent;

	// Token: 0x04000F1B RID: 3867
	private static readonly IntPtr NativeFieldInfoPtr_isInitialized;

	// Token: 0x04000F1C RID: 3868
	private static readonly IntPtr NativeFieldInfoPtr_audioEmitter;

	// Token: 0x04000F1D RID: 3869
	private static readonly IntPtr NativeFieldInfoPtr__casingSpawnPoint;

	// Token: 0x04000F1E RID: 3870
	private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

	// Token: 0x04000F1F RID: 3871
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04000F20 RID: 3872
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04000F21 RID: 3873
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Void_0;

	// Token: 0x04000F22 RID: 3874
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

	// Token: 0x04000F23 RID: 3875
	private static readonly IntPtr NativeMethodInfoPtr_PlayShootSound_Public_Void_Transform_Boolean_Boolean_0;

	// Token: 0x04000F24 RID: 3876
	private static readonly IntPtr NativeMethodInfoPtr_PlayBoltSlapSound_Public_Void_Transform_0;

	// Token: 0x04000F25 RID: 3877
	private static readonly IntPtr NativeMethodInfoPtr_PlayMagSlapSound_Public_Void_Transform_0;

	// Token: 0x04000F26 RID: 3878
	private static readonly IntPtr NativeMethodInfoPtr_PlayBoltLockSound_Public_Void_Transform_0;

	// Token: 0x04000F27 RID: 3879
	private static readonly IntPtr NativeMethodInfoPtr_PlayDryFireSound_Public_Void_Transform_Boolean_0;

	// Token: 0x04000F28 RID: 3880
	private static readonly IntPtr NativeMethodInfoPtr_PlayClickSound_Public_Void_Transform_0;

	// Token: 0x04000F29 RID: 3881
	private static readonly IntPtr NativeMethodInfoPtr_PlayFiremodeSelectionSound_Public_Void_Transform_Boolean_0;

	// Token: 0x04000F2A RID: 3882
	private static readonly IntPtr NativeMethodInfoPtr_PlaySemiAutoFiremodeSelection_Public_Void_0;

	// Token: 0x04000F2B RID: 3883
	private static readonly IntPtr NativeMethodInfoPtr_PlayFullAutoOrBurstFiremodeSelection_Public_Void_0;

	// Token: 0x04000F2C RID: 3884
	private static readonly IntPtr NativeMethodInfoPtr_PlayMagSound_Public_Void_Vector3_Boolean_0;

	// Token: 0x04000F2D RID: 3885
	private static readonly IntPtr NativeMethodInfoPtr_PlayBoltSound_Public_Void_Vector3_Boolean_0;

	// Token: 0x04000F2E RID: 3886
	private static readonly IntPtr NativeMethodInfoPtr_PlayAlternateFireSound_Public_Void_Event_Transform_0;

	// Token: 0x04000F2F RID: 3887
	private static readonly IntPtr NativeMethodInfoPtr_SetAudioEmitterPosition_Private_Void_0;

	// Token: 0x04000F30 RID: 3888
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
