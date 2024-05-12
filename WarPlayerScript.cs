using System;
using System.Runtime.InteropServices;
using DPI.AISystems;
using DPI.AISystems.Alerts;
using DPI.Networking;
using DPI.Networking.IO;
using DPI.Radio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Onward;
using Onward.AddressableTools;
using Onward.Characters;
using Onward.Devices;
using Onward.Gear;
using Onward.Networking;
using Onward.Rendering;
using Onward.Spectating.Outline;
using Onward.TeamManagement;
using Onward.Voice;
using RootMotion.FinalIK;
using TMPro;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.AddressableAssets;

// Token: 0x020004CF RID: 1231
public class WarPlayerScript : MonoBehaviourDPINetworking
{
	// Token: 0x060062E4 RID: 25316 RVA: 0x0018C1C0 File Offset: 0x0018A3C0
	[CallerCount(0)]
	public unsafe static void add_AnyPlayerHit(WarPlayerScript.PlayerDamaged value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_add_AnyPlayerHit_Public_Static_add_Void_PlayerDamaged_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062E5 RID: 25317 RVA: 0x0018C20C File Offset: 0x0018A40C
	[CallerCount(0)]
	public unsafe static void remove_AnyPlayerHit(WarPlayerScript.PlayerDamaged value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_remove_AnyPlayerHit_Public_Static_rem_Void_PlayerDamaged_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062E6 RID: 25318 RVA: 0x0018C258 File Offset: 0x0018A458
	[CallerCount(0)]
	public unsafe static void add_AnyPlayerRessed(WarPlayerScript.PlayerHealedEvent value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_add_AnyPlayerRessed_Public_Static_add_Void_PlayerHealedEvent_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062E7 RID: 25319 RVA: 0x0018C2A4 File Offset: 0x0018A4A4
	[CallerCount(0)]
	public unsafe static void remove_AnyPlayerRessed(WarPlayerScript.PlayerHealedEvent value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_remove_AnyPlayerRessed_Public_Static_rem_Void_PlayerHealedEvent_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062E8 RID: 25320 RVA: 0x0018C2F0 File Offset: 0x0018A4F0
	[CallerCount(0)]
	public unsafe static void add_AnyPlayerShooting(WarPlayerScript.OtherPlayerEvent value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_add_AnyPlayerShooting_Public_Static_add_Void_OtherPlayerEvent_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062E9 RID: 25321 RVA: 0x0018C33C File Offset: 0x0018A53C
	[CallerCount(0)]
	public unsafe static void remove_AnyPlayerShooting(WarPlayerScript.OtherPlayerEvent value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_remove_AnyPlayerShooting_Public_Static_rem_Void_OtherPlayerEvent_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062EA RID: 25322 RVA: 0x0018C388 File Offset: 0x0018A588
	[CallerCount(0)]
	public unsafe static void add_AnyPlayerSpawned(WarPlayerScript.AnyPlayerEvent value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_add_AnyPlayerSpawned_Public_Static_add_Void_AnyPlayerEvent_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062EB RID: 25323 RVA: 0x0018C3D4 File Offset: 0x0018A5D4
	[CallerCount(0)]
	public unsafe static void remove_AnyPlayerSpawned(WarPlayerScript.AnyPlayerEvent value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_remove_AnyPlayerSpawned_Public_Static_rem_Void_AnyPlayerEvent_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062EC RID: 25324 RVA: 0x0018C420 File Offset: 0x0018A620
	[CallerCount(0)]
	public unsafe static void add_AnyPlayerUnDowned(WarPlayerScript.SpecificPlayerEvent value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_add_AnyPlayerUnDowned_Public_Static_add_Void_SpecificPlayerEvent_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062ED RID: 25325 RVA: 0x0018C46C File Offset: 0x0018A66C
	[CallerCount(0)]
	public unsafe static void remove_AnyPlayerUnDowned(WarPlayerScript.SpecificPlayerEvent value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_remove_AnyPlayerUnDowned_Public_Static_rem_Void_SpecificPlayerEvent_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062EE RID: 25326 RVA: 0x0018C4B8 File Offset: 0x0018A6B8
	[CallerCount(0)]
	public unsafe void add_PlayerShooting(WarPlayerScript.PlayerEvent value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_add_PlayerShooting_Public_add_Void_PlayerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062EF RID: 25327 RVA: 0x0018C514 File Offset: 0x0018A714
	[CallerCount(0)]
	public unsafe void remove_PlayerShooting(WarPlayerScript.PlayerEvent value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_remove_PlayerShooting_Public_rem_Void_PlayerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062F0 RID: 25328 RVA: 0x0018C570 File Offset: 0x0018A770
	[CallerCount(0)]
	public unsafe void add_PlayerSpawned(WarPlayerScript.PlayerEvent value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_add_PlayerSpawned_Public_add_Void_PlayerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062F1 RID: 25329 RVA: 0x0018C5CC File Offset: 0x0018A7CC
	[CallerCount(0)]
	public unsafe void remove_PlayerSpawned(WarPlayerScript.PlayerEvent value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_remove_PlayerSpawned_Public_rem_Void_PlayerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062F2 RID: 25330 RVA: 0x0018C628 File Offset: 0x0018A828
	[CallerCount(0)]
	public unsafe void add_PlayerDespawned(WarPlayerScript.PlayerEvent value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_add_PlayerDespawned_Public_add_Void_PlayerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060062F3 RID: 25331 RVA: 0x0018C684 File Offset: 0x0018A884
	[CallerCount(0)]
	public unsafe void remove_PlayerDespawned(WarPlayerScript.PlayerEvent value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_remove_PlayerDespawned_Public_rem_Void_PlayerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x170023BA RID: 9146
	// (get) Token: 0x060062F4 RID: 25332 RVA: 0x0018C6E0 File Offset: 0x0018A8E0
	public unsafe float CurrentHealth
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170023BB RID: 9147
	// (get) Token: 0x060062F5 RID: 25333 RVA: 0x0018C730 File Offset: 0x0018A930
	public unsafe Faction PlayerFaction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_get_PlayerFaction_Public_get_Faction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170023BC RID: 9148
	// (get) Token: 0x060062F6 RID: 25334 RVA: 0x0018C780 File Offset: 0x0018A980
	public unsafe bool HasSpawnAudioImmunity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_get_HasSpawnAudioImmunity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170023BD RID: 9149
	// (get) Token: 0x060062F7 RID: 25335 RVA: 0x0018C7D0 File Offset: 0x0018A9D0
	public unsafe bool IsNightVisionOn
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_get_IsNightVisionOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170023BE RID: 9150
	// (get) Token: 0x060062F8 RID: 25336 RVA: 0x0018C820 File Offset: 0x0018AA20
	// (set) Token: 0x060062F9 RID: 25337 RVA: 0x0018C878 File Offset: 0x0018AA78
	public unsafe DPIPlayer TeammateWhoDownedMe
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_get_TeammateWhoDownedMe_Public_get_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new DPIPlayer(intPtr2) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_set_TeammateWhoDownedMe_Protected_set_Void_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170023BF RID: 9151
	// (get) Token: 0x060062FA RID: 25338 RVA: 0x0018C8D4 File Offset: 0x0018AAD4
	// (set) Token: 0x060062FB RID: 25339 RVA: 0x0018C924 File Offset: 0x0018AB24
	public unsafe bool IsInDeathTransition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_get_IsInDeathTransition_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_set_IsInDeathTransition_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170023C0 RID: 9152
	// (get) Token: 0x060062FC RID: 25340 RVA: 0x0018C978 File Offset: 0x0018AB78
	// (set) Token: 0x060062FD RID: 25341 RVA: 0x0018C9C8 File Offset: 0x0018ABC8
	public unsafe Vector3 DeathPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_get_DeathPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_set_DeathPosition_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170023C1 RID: 9153
	// (get) Token: 0x060062FE RID: 25342 RVA: 0x0018CA1C File Offset: 0x0018AC1C
	public unsafe bool IsFriendly
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_get_IsFriendly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x170023C2 RID: 9154
	// (get) Token: 0x060062FF RID: 25343 RVA: 0x0018CA6C File Offset: 0x0018AC6C
	// (set) Token: 0x06006300 RID: 25344 RVA: 0x0018CABC File Offset: 0x0018ACBC
	public unsafe double TimeOfLastStateChange
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_get_TimeOfLastStateChange_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_set_TimeOfLastStateChange_Private_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170023C3 RID: 9155
	// (get) Token: 0x06006301 RID: 25345 RVA: 0x0018CB10 File Offset: 0x0018AD10
	public unsafe bool IsEnemy
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_get_IsEnemy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x06006302 RID: 25346 RVA: 0x0018CB60 File Offset: 0x0018AD60
	[CallerCount(0)]
	public unsafe static WarPlayerScript GetWarPlayer(DPIPlayer player)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_GetWarPlayer_Public_Static_WarPlayerScript_DPIPlayer_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new WarPlayerScript(intPtr2) : null;
	}

	// Token: 0x06006303 RID: 25347 RVA: 0x0018CBC0 File Offset: 0x0018ADC0
	[CallerCount(0)]
	public unsafe void ClearReferencesToPlayer(DPIPlayer referencedPlayer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(referencedPlayer);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ClearReferencesToPlayer_Public_Void_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006304 RID: 25348 RVA: 0x0018CC1C File Offset: 0x0018AE1C
	[CallerCount(0)]
	public unsafe void SetOtherAIInfo(int aiID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref aiID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetOtherAIInfo_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006305 RID: 25349 RVA: 0x0018CC70 File Offset: 0x0018AE70
	[CallerCount(0)]
	public unsafe void ShutOff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WarPlayerScript.NativeMethodInfoPtr_ShutOff_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006306 RID: 25350 RVA: 0x0018CCC0 File Offset: 0x0018AEC0
	[CallerCount(0)]
	public unsafe void ShutOffWithoutDisconnect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WarPlayerScript.NativeMethodInfoPtr_ShutOffWithoutDisconnect_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006307 RID: 25351 RVA: 0x0018CD10 File Offset: 0x0018AF10
	[CallerCount(0)]
	public unsafe void GetWatchSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_GetWatchSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006308 RID: 25352 RVA: 0x0018CD54 File Offset: 0x0018AF54
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006309 RID: 25353 RVA: 0x0018CD98 File Offset: 0x0018AF98
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600630A RID: 25354 RVA: 0x0018CDDC File Offset: 0x0018AFDC
	[CallerCount(0)]
	public unsafe void ResetKillingPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ResetKillingPlayer_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600630B RID: 25355 RVA: 0x0018CE20 File Offset: 0x0018B020
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_OnDestroy_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600630C RID: 25356 RVA: 0x0018CE64 File Offset: 0x0018B064
	[CallerCount(0)]
	public unsafe void OnPlayerLeftTeam(OnwardPhotonPlayer player, Team team)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(team);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_OnPlayerLeftTeam_Protected_Void_OnwardPhotonPlayer_Team_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600630D RID: 25357 RVA: 0x0018CED8 File Offset: 0x0018B0D8
	[CallerCount(0)]
	public unsafe IEnumerator AddCameraIn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_AddCameraIn_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x0600630E RID: 25358 RVA: 0x0018CF30 File Offset: 0x0018B130
	[CallerCount(0)]
	public unsafe void AddCameraNow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_AddCameraNow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600630F RID: 25359 RVA: 0x0018CF74 File Offset: 0x0018B174
	[CallerCount(0)]
	public unsafe void SetFirstPersonEnabled(bool isEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref isEnabled;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetFirstPersonEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006310 RID: 25360 RVA: 0x0018CFC8 File Offset: 0x0018B1C8
	[CallerCount(0)]
	public unsafe void SetThirdPersonEnabled(bool isEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref isEnabled;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetThirdPersonEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006311 RID: 25361 RVA: 0x0018D01C File Offset: 0x0018B21C
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Awake_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006312 RID: 25362 RVA: 0x0018D060 File Offset: 0x0018B260
	[CallerCount(0)]
	public unsafe void ToggleInvisibleShadowCasterLOD(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref enable;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ToggleInvisibleShadowCasterLOD_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006313 RID: 25363 RVA: 0x0018D0B4 File Offset: 0x0018B2B4
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006314 RID: 25364 RVA: 0x0018D0F8 File Offset: 0x0018B2F8
	[CallerCount(0)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Init_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006315 RID: 25365 RVA: 0x0018D13C File Offset: 0x0018B33C
	[CallerCount(0)]
	public unsafe void SetupSpectateCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetupSpectateCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x170023C4 RID: 9156
	// (get) Token: 0x06006316 RID: 25366 RVA: 0x0018D180 File Offset: 0x0018B380
	// (set) Token: 0x06006317 RID: 25367 RVA: 0x0018D1D0 File Offset: 0x0018B3D0
	public unsafe bool ManagedUpdateRemoval
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x06006318 RID: 25368 RVA: 0x0018D224 File Offset: 0x0018B424
	[CallerCount(0)]
	public unsafe void OnManagedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006319 RID: 25369 RVA: 0x0018D268 File Offset: 0x0018B468
	[CallerCount(0)]
	public unsafe void SetLocalIconColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetLocalIconColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600631A RID: 25370 RVA: 0x0018D2AC File Offset: 0x0018B4AC
	[CallerCount(0)]
	public unsafe static void RefreshAllPlayerIcons()
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RefreshAllPlayerIcons_Public_Static_Void_0, 0, (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600631B RID: 25371 RVA: 0x0018D2E0 File Offset: 0x0018B4E0
	[CallerCount(0)]
	public unsafe void RefreshPlayerIcon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RefreshPlayerIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600631C RID: 25372 RVA: 0x0018D324 File Offset: 0x0018B524
	[CallerCount(0)]
	public unsafe void RefreshAllyMapIcon(bool showIcon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref showIcon;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RefreshAllyMapIcon_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600631D RID: 25373 RVA: 0x0018D378 File Offset: 0x0018B578
	[CallerCount(0)]
	public unsafe void RefreshAllyMapColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RefreshAllyMapColor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600631E RID: 25374 RVA: 0x0018D3BC File Offset: 0x0018B5BC
	[CallerCount(0)]
	public unsafe void RefreshEnemyMapIcon(bool showIcon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref showIcon;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RefreshEnemyMapIcon_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600631F RID: 25375 RVA: 0x0018D410 File Offset: 0x0018B610
	[CallerCount(0)]
	public unsafe void RefreshEnemyMapColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RefreshEnemyMapColor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006320 RID: 25376 RVA: 0x0018D454 File Offset: 0x0018B654
	[CallerCount(0)]
	public unsafe void ApplyDamage(float damage, DPIPlayer playerSource, int AISourceID, [Optional] DamageType damageType, [In] [Optional] ref Nullable<WeaponName> weaponName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref damage;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerSource);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageType;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(weaponName);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ApplyDamage_Public_Void_Single_DPIPlayer_Int32_DamageType_byref_Nullable_1_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006321 RID: 25377 RVA: 0x0018D500 File Offset: 0x0018B700
	[CallerCount(0)]
	public unsafe void ApplyDamage(float damage, Vector3 hitPos, BodyParts damagedPart, DPIPlayer playerSource, int aiSourceID, [Optional] DamageType damageType, [In] [Optional] ref Nullable<WeaponName> weaponName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref damage;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPos;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damagedPart;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerSource);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aiSourceID;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageType;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(weaponName);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ApplyDamage_Public_Void_Single_Vector3_BodyParts_DPIPlayer_Int32_DamageType_byref_Nullable_1_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006322 RID: 25378 RVA: 0x0018D5D4 File Offset: 0x0018B7D4
	[CallerCount(0)]
	public unsafe void ApplyTaserDamage(OnwardPhotonPlayer shooter, int AISourceID, Pickup pickup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(shooter);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pickup);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ApplyTaserDamage_Public_Void_OnwardPhotonPlayer_Int32_Pickup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006323 RID: 25379 RVA: 0x0018D658 File Offset: 0x0018B858
	[CallerCount(0)]
	public unsafe void RPC_ApplyTaserDamage(DPIPlayer shooterOther, int AISourceID, int tasingItemID, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(shooterOther);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tasingItemID;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_ApplyTaserDamage_Public_Void_DPIPlayer_Int32_Int32_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006324 RID: 25380 RVA: 0x0018D6F4 File Offset: 0x0018B8F4
	[CallerCount(0)]
	public unsafe bool IsHitInfractable(bool isTeamDamage, bool isKillingHit, bool isDowningHit, DPIPlayer damageSourcePlayer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref isTeamDamage;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKillingHit;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDowningHit;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(damageSourcePlayer);
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_IsHitInfractable_Protected_Boolean_Boolean_Boolean_Boolean_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06006325 RID: 25381 RVA: 0x0018D794 File Offset: 0x0018B994
	[CallerCount(0)]
	public unsafe void SendHeal(bool bypassDeadCheck, int healingItemID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref bypassDeadCheck;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref healingItemID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SendHeal_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006326 RID: 25382 RVA: 0x0018D7FC File Offset: 0x0018B9FC
	[CallerCount(0)]
	public unsafe void RPC_Heal(int healingItemID, DPINetworkMessageInfo msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref healingItemID;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(msg));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_Heal_Public_Void_Int32_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006327 RID: 25383 RVA: 0x0018D870 File Offset: 0x0018BA70
	[CallerCount(0)]
	public unsafe void LocalHeal(int healingItemID, DPIPlayer healingSource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref healingItemID;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(healingSource);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_LocalHeal_Private_Void_Int32_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006328 RID: 25384 RVA: 0x0018D8DC File Offset: 0x0018BADC
	[CallerCount(0)]
	public unsafe void RPC_HealRemote(int healingItemID, int endState, bool endBleedingState, DPIPlayer healingSource, DPINetworkMessageInfo msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref healingItemID;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endState;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endBleedingState;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(healingSource);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(msg));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_HealRemote_Public_Void_Int32_Int32_Boolean_DPIPlayer_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006329 RID: 25385 RVA: 0x0018D98C File Offset: 0x0018BB8C
	[CallerCount(0)]
	public unsafe void FullyStopBleedingAndEffects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_FullyStopBleedingAndEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600632A RID: 25386 RVA: 0x0018D9D0 File Offset: 0x0018BBD0
	[CallerCount(0)]
	public unsafe void HealScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_HealScore_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600632B RID: 25387 RVA: 0x0018DA14 File Offset: 0x0018BC14
	[CallerCount(0)]
	public unsafe void RPC_SetArmorHP(float newHP, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref newHP;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_SetArmorHP_Public_Void_Single_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600632C RID: 25388 RVA: 0x0018DA88 File Offset: 0x0018BC88
	[CallerCount(0)]
	public unsafe void SetHP(float newHp, DPIPlayer damageGiver, int aiSourceID, bool isDead, float damage, int damageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref newHp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(damageGiver);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aiSourceID;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDead;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damage;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageType;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetHP_Public_Void_Single_DPIPlayer_Int32_Boolean_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600632D RID: 25389 RVA: 0x0018DB40 File Offset: 0x0018BD40
	[CallerCount(0)]
	public unsafe void RPC_SetHP(float newHp, DPIPlayer playerSource, int aiSourceID, Vector3 hitPos, Vector3 shootPos, bool isDead, int damagedPart, float damage, int damageType, int weaponName, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref newHp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerSource);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aiSourceID;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPos;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shootPos;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDead;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damagedPart;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damage;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageType;
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponName;
		ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_SetHP_Public_Void_Single_DPIPlayer_Int32_Vector3_Vector3_Boolean_Int32_Single_Int32_Int32_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600632E RID: 25390 RVA: 0x0018DC64 File Offset: 0x0018BE64
	[CallerCount(0)]
	public unsafe void IgnoreBleed(bool didTakeDamage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref didTakeDamage;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_IgnoreBleed_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600632F RID: 25391 RVA: 0x0018DCB8 File Offset: 0x0018BEB8
	[CallerCount(0)]
	public unsafe void StopBleedOnHeal(bool didTakeDamage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref didTakeDamage;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_StopBleedOnHeal_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006330 RID: 25392 RVA: 0x0018DD0C File Offset: 0x0018BF0C
	[CallerCount(0)]
	public unsafe void OnPlayerHit(WarPlayerScript player, WarPlayerScript lastDamageGiver, bool killingHit, bool downingHit, bool infractableHit, BodyParts damagedPart, Vector3 hitPos, Vector3 shootPos, float damage, DamageType damageType, [Optional] WeaponName weaponName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastDamageGiver);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref killingHit;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref downingHit;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref infractableHit;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damagedPart;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPos;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shootPos;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damage;
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageType;
		ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponName;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_OnPlayerHit_Private_Void_WarPlayerScript_WarPlayerScript_Boolean_Boolean_Boolean_BodyParts_Vector3_Vector3_Single_DamageType_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006331 RID: 25393 RVA: 0x0018DE2C File Offset: 0x0018C02C
	[CallerCount(0)]
	public unsafe void OnLocalDowned(WarPlayerScript lastDamageGiver, bool infractableHit, DamageType damageType, WeaponName weaponName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastDamageGiver);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref infractableHit;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageType;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponName;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_OnLocalDowned_Private_Void_WarPlayerScript_Boolean_DamageType_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006332 RID: 25394 RVA: 0x0018DEC0 File Offset: 0x0018C0C0
	[CallerCount(0)]
	public unsafe void OnLocalDeath(bool suicide, bool infractableHit, WarPlayerScript lastDamageGiver, DamageType damageType, WeaponName weaponName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref suicide;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref infractableHit;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastDamageGiver);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageType;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponName;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_OnLocalDeath_Private_Void_Boolean_Boolean_WarPlayerScript_DamageType_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006333 RID: 25395 RVA: 0x0018DF68 File Offset: 0x0018C168
	[CallerCount(0)]
	public unsafe void ShowInfractionUI(WarPlayerScript lastDamageGiver, bool kill, [Optional] DamageType damageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastDamageGiver);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kill;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageType;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ShowInfractionUI_Private_Void_WarPlayerScript_Boolean_DamageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006334 RID: 25396 RVA: 0x0018DFE8 File Offset: 0x0018C1E8
	[CallerCount(0)]
	public unsafe void SetHPMax()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetHPMax_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006335 RID: 25397 RVA: 0x0018E02C File Offset: 0x0018C22C
	[CallerCount(0)]
	public unsafe void SetDead(DamageType damageType, bool didKillSelf, bool wasTeamKilled, DPIPlayer source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref damageType;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref didKillSelf;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wasTeamKilled;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetDead_Private_Void_DamageType_Boolean_Boolean_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006336 RID: 25398 RVA: 0x0018E0C0 File Offset: 0x0018C2C0
	[CallerCount(0)]
	public unsafe void LocalPlayerDied(DamageType damageType, bool didKillSelf, bool wasTeamKilled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref damageType;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref didKillSelf;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wasTeamKilled;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_LocalPlayerDied_Private_Void_DamageType_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006337 RID: 25399 RVA: 0x0018E13C File Offset: 0x0018C33C
	[CallerCount(0)]
	public unsafe void PainStopVoice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_PainStopVoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006338 RID: 25400 RVA: 0x0018E180 File Offset: 0x0018C380
	[CallerCount(0)]
	public unsafe void PainPlayCry()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_PainPlayCry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006339 RID: 25401 RVA: 0x0018E1C4 File Offset: 0x0018C3C4
	[CallerCount(0)]
	public unsafe void PainPlayGrunt()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_PainPlayGrunt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600633A RID: 25402 RVA: 0x0018E208 File Offset: 0x0018C408
	[CallerCount(0)]
	public unsafe void OnCasualtyUIVisible(CasualtyUIState casualtyUI)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref casualtyUI;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_OnCasualtyUIVisible_Public_Void_CasualtyUIState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600633B RID: 25403 RVA: 0x0018E25C File Offset: 0x0018C45C
	[CallerCount(0)]
	public unsafe void SetLastDamage(DamageType newType, [Optional] Nullable<WeaponName> newWeapon)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref newType;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newWeapon));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetLastDamage_Public_Void_DamageType_Nullable_1_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600633C RID: 25404 RVA: 0x0018E2D0 File Offset: 0x0018C4D0
	[CallerCount(0)]
	public unsafe void PainPlayDrown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_PainPlayDrown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600633D RID: 25405 RVA: 0x0018E314 File Offset: 0x0018C514
	[CallerCount(0)]
	public unsafe string GetKilledByText(DamageType damageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref damageType;
		IntPtr returnedException;
		IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_GetKilledByText_Public_String_DamageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	// Token: 0x0600633E RID: 25406 RVA: 0x0018E374 File Offset: 0x0018C574
	[CallerCount(0)]
	public unsafe string GetDownedByText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_GetDownedByText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	// Token: 0x0600633F RID: 25407 RVA: 0x0018E3C0 File Offset: 0x0018C5C0
	[CallerCount(0)]
	public unsafe void ResetBody()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ResetBody_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006340 RID: 25408 RVA: 0x0018E404 File Offset: 0x0018C604
	[CallerCount(0)]
	public unsafe void ResetKarmaDialogTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ResetKarmaDialogTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006341 RID: 25409 RVA: 0x0018E448 File Offset: 0x0018C648
	[CallerCount(0)]
	public unsafe IEnumerator DeathTransition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_DeathTransition_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x06006342 RID: 25410 RVA: 0x0018E4A0 File Offset: 0x0018C6A0
	[CallerCount(0)]
	public unsafe IEnumerator BleedOut(float waitTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref waitTime;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_BleedOut_Public_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x06006343 RID: 25411 RVA: 0x0018E508 File Offset: 0x0018C708
	[CallerCount(0)]
	public unsafe void StopBleedOut()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_StopBleedOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006344 RID: 25412 RVA: 0x0018E54C File Offset: 0x0018C74C
	[CallerCount(0)]
	public unsafe void Respawn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Respawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006345 RID: 25413 RVA: 0x0018E590 File Offset: 0x0018C790
	[CallerCount(0)]
	public unsafe void SetInvincibility()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetInvincibility_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006346 RID: 25414 RVA: 0x0018E5D4 File Offset: 0x0018C7D4
	[CallerCount(0)]
	public unsafe void RPC_UpdateMe(DPIPlayer requestFrom, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestFrom);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_UpdateMe_Public_Void_DPIPlayer_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006347 RID: 25415 RVA: 0x0018E64C File Offset: 0x0018C84C
	[CallerCount(0)]
	public unsafe void RPC_ThisPlayerState(float realHp, float armorHP, bool isDead, bool realspawn, Vector3 pos, bool isragdoll, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref realHp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref armorHP;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDead;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref realspawn;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isragdoll;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_ThisPlayerState_Public_Void_Single_Single_Boolean_Boolean_Vector3_Boolean_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006348 RID: 25416 RVA: 0x0018E71C File Offset: 0x0018C91C
	[CallerCount(0)]
	public unsafe void DownPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_DownPlayer_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006349 RID: 25417 RVA: 0x0018E760 File Offset: 0x0018C960
	[CallerCount(0)]
	public unsafe void UnDownPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_UnDownPlayer_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600634A RID: 25418 RVA: 0x0018E7A4 File Offset: 0x0018C9A4
	[CallerCount(0)]
	public unsafe void SetRagdollActive(bool isRagdoll, DPIPlayer source, bool dropEquipment = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref isRagdoll;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dropEquipment;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetRagdollActive_Private_Void_Boolean_DPIPlayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600634B RID: 25419 RVA: 0x0018E824 File Offset: 0x0018CA24
	[CallerCount(0)]
	public unsafe void UpdateHandModels(bool setActive, bool makeTranslucent = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref setActive;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeTranslucent;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_UpdateHandModels_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600634C RID: 25420 RVA: 0x0018E88C File Offset: 0x0018CA8C
	[CallerCount(0)]
	public unsafe void SetState(PlayerState newState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref newState;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetState_Public_Void_PlayerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600634D RID: 25421 RVA: 0x0018E8E0 File Offset: 0x0018CAE0
	[CallerCount(0)]
	public unsafe bool IsRevivable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_IsRevivable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x0600634E RID: 25422 RVA: 0x0018E930 File Offset: 0x0018CB30
	[CallerCount(0)]
	public unsafe void RefreshShadows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RefreshShadows_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600634F RID: 25423 RVA: 0x0018E974 File Offset: 0x0018CB74
	[CallerCount(0)]
	public unsafe void FlashMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_FlashMe_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006350 RID: 25424 RVA: 0x0018E9B8 File Offset: 0x0018CBB8
	[CallerCount(0)]
	public unsafe void RPC_TinitusMe(DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_TinitusMe_Public_Void_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006351 RID: 25425 RVA: 0x0018EA18 File Offset: 0x0018CC18
	[CallerCount(0)]
	public unsafe IEnumerator FlashStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_FlashStart_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x06006352 RID: 25426 RVA: 0x0018EA70 File Offset: 0x0018CC70
	[CallerCount(0)]
	public unsafe void StartTinitus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_StartTinitus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006353 RID: 25427 RVA: 0x0018EAB4 File Offset: 0x0018CCB4
	[CallerCount(0)]
	public unsafe IEnumerator DelayDisableTinitus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_DelayDisableTinitus_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x06006354 RID: 25428 RVA: 0x0018EB0C File Offset: 0x0018CD0C
	[CallerCount(0)]
	public unsafe void ResetGear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ResetGear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006355 RID: 25429 RVA: 0x0018EB50 File Offset: 0x0018CD50
	[CallerCount(0)]
	public unsafe void DisableObject(GameObject g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_DisableObject_Protected_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006356 RID: 25430 RVA: 0x0018EBAC File Offset: 0x0018CDAC
	[CallerCount(0)]
	public unsafe void LoadVisuals()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_LoadVisuals_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006357 RID: 25431 RVA: 0x0018EBF0 File Offset: 0x0018CDF0
	[CallerCount(0)]
	public unsafe void UpdateFakeLights()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_UpdateFakeLights_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006358 RID: 25432 RVA: 0x0018EC34 File Offset: 0x0018CE34
	[CallerCount(0)]
	public unsafe void RefreshOutfit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RefreshOutfit_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006359 RID: 25433 RVA: 0x0018EC78 File Offset: 0x0018CE78
	[CallerCount(0)]
	public unsafe void SetOutfit([Optional] SoldierClass soldierClass, [Optional] Faction faction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref soldierClass;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faction;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetOutfit_Public_Void_SoldierClass_Faction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600635A RID: 25434 RVA: 0x0018ECE0 File Offset: 0x0018CEE0
	[CallerCount(0)]
	public unsafe void ShowWatchVisuals(bool show)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref show;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ShowWatchVisuals_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600635B RID: 25435 RVA: 0x0018ED34 File Offset: 0x0018CF34
	[CallerCount(0)]
	public unsafe void SynchronizeVIPState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SynchronizeVIPState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600635C RID: 25436 RVA: 0x0018ED78 File Offset: 0x0018CF78
	[CallerCount(0)]
	public unsafe void SpectateMe(bool toSpectate, bool thirdPerson = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref toSpectate;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref thirdPerson;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SpectateMe_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600635D RID: 25437 RVA: 0x0018EDE0 File Offset: 0x0018CFE0
	[CallerCount(0)]
	public unsafe Vector3 GetBarrelPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_GetBarrelPosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x0600635E RID: 25438 RVA: 0x0018EE30 File Offset: 0x0018D030
	[CallerCount(0)]
	public unsafe void PlayerShot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_PlayerShot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600635F RID: 25439 RVA: 0x0018EE74 File Offset: 0x0018D074
	[CallerCount(0)]
	public unsafe static void ForceActivateLocalWarPlayer()
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ForceActivateLocalWarPlayer_Public_Static_Void_0, 0, (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006360 RID: 25440 RVA: 0x0018EEA8 File Offset: 0x0018D0A8
	[CallerCount(0)]
	public unsafe void ResetSpawnAudioImmunity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ResetSpawnAudioImmunity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006361 RID: 25441 RVA: 0x0018EEEC File Offset: 0x0018D0EC
	[CallerCount(0)]
	public unsafe void SetNameColor(Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref color;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetNameColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006362 RID: 25442 RVA: 0x0018EF40 File Offset: 0x0018D140
	[CallerCount(0)]
	public unsafe void RemovePlayerEntry()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RemovePlayerEntry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006363 RID: 25443 RVA: 0x0018EF84 File Offset: 0x0018D184
	[CallerCount(0)]
	public unsafe void SetManualInvincibility(bool invincible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invincible;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetManualInvincibility_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006364 RID: 25444 RVA: 0x0018EFD8 File Offset: 0x0018D1D8
	[CallerCount(0)]
	public unsafe void ToggleManualInvincibility()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ToggleManualInvincibility_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006365 RID: 25445 RVA: 0x0018F01C File Offset: 0x0018D21C
	[CallerCount(0)]
	public unsafe static void SetAllManuallyInvincible(bool invincible)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invincible;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SetAllManuallyInvincible_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006366 RID: 25446 RVA: 0x0018F064 File Offset: 0x0018D264
	[CallerCount(0)]
	public unsafe void RPC_ManualInvincibility(bool invincible, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invincible;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_ManualInvincibility_Protected_Void_Boolean_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006367 RID: 25447 RVA: 0x0018F0D8 File Offset: 0x0018D2D8
	[CallerCount(0)]
	public unsafe void RPC_Targetability(bool targetable, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref targetable;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_Targetability_Protected_Void_Boolean_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006368 RID: 25448 RVA: 0x0018F14C File Offset: 0x0018D34C
	[CallerCount(0)]
	public unsafe void SendWhistle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_SendWhistle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006369 RID: 25449 RVA: 0x0018F190 File Offset: 0x0018D390
	[CallerCount(0)]
	public unsafe void RPC_AIWhistle(DPINetworkMessageInfo msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(msg));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_AIWhistle_Protected_Void_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600636A RID: 25450 RVA: 0x0018F1F0 File Offset: 0x0018D3F0
	[CallerCount(0)]
	public unsafe void EnableDebugInvincibility()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_EnableDebugInvincibility_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600636B RID: 25451 RVA: 0x0018F234 File Offset: 0x0018D434
	[CallerCount(0)]
	public unsafe void ToggleDebugTargetability()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_ToggleDebugTargetability_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600636C RID: 25452 RVA: 0x0018F278 File Offset: 0x0018D478
	[CallerCount(0)]
	public unsafe void InflictDamageToSelf()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_InflictDamageToSelf_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600636D RID: 25453 RVA: 0x0018F2BC File Offset: 0x0018D4BC
	[CallerCount(0)]
	public unsafe void UpdateEditorHotkeys(bool shift)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref shift;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_UpdateEditorHotkeys_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600636E RID: 25454 RVA: 0x0018F310 File Offset: 0x0018D510
	[CallerCount(0)]
	public unsafe void UpdateGeneralHotkeys(bool shift)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref shift;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_UpdateGeneralHotkeys_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600636F RID: 25455 RVA: 0x0018F364 File Offset: 0x0018D564
	[CallerCount(0)]
	public unsafe string GetDebugLookObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_GetDebugLookObject_Protected_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	// Token: 0x06006370 RID: 25456 RVA: 0x0018F3B0 File Offset: 0x0018D5B0
	[CallerCount(0)]
	public unsafe float GetSurvivalScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_GetSurvivalScore_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06006371 RID: 25457 RVA: 0x0018F400 File Offset: 0x0018D600
	[CallerCount(0)]
	public unsafe static float GetSurvivalMultiplier(Faction faction)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref faction;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_GetSurvivalMultiplier_Public_Static_Single_Faction_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06006372 RID: 25458 RVA: 0x0018F454 File Offset: 0x0018D654
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableDPInInUnique_DPINetworkMessageInfo_0(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tmp));
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableDPInInUnique_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006373 RID: 25459 RVA: 0x0018F4D0 File Offset: 0x0018D6D0
	[CallerCount(0)]
	public unsafe void RPC_ApplyTaserDamage(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, DPIPlayer shooterOther, int AISourceID, int tasingItemID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shooterOther);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tasingItemID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_ApplyTaserDamage_Public_Void_ArrayOf_DPIPlayer_DPIPlayer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006374 RID: 25460 RVA: 0x0018F568 File Offset: 0x0018D768
	[CallerCount(0)]
	public unsafe void RPC_ApplyTaserDamage(DPIPlayer invokeRpcPlayerTarget, DPIPlayer shooterOther, int AISourceID, int tasingItemID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shooterOther);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tasingItemID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_ApplyTaserDamage_Public_Void_DPIPlayer_DPIPlayer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006375 RID: 25461 RVA: 0x0018F600 File Offset: 0x0018D800
	[CallerCount(0)]
	public unsafe void RPC_ApplyTaserDamage(RpcTarget invokeRpcTarget, DPIPlayer shooterOther, int AISourceID, int tasingItemID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shooterOther);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref AISourceID;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tasingItemID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_ApplyTaserDamage_Public_Void_RpcTarget_DPIPlayer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006376 RID: 25462 RVA: 0x0018F694 File Offset: 0x0018D894
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInUnique_DPINetworkMessageInfo_0(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInUnique_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006377 RID: 25463 RVA: 0x0018F708 File Offset: 0x0018D908
	[CallerCount(0)]
	public unsafe void RPC_Heal(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, int healingItemID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref healingItemID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_Heal_Public_Void_ArrayOf_DPIPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006378 RID: 25464 RVA: 0x0018F774 File Offset: 0x0018D974
	[CallerCount(0)]
	public unsafe void RPC_Heal(DPIPlayer invokeRpcPlayerTarget, int healingItemID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref healingItemID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_Heal_Public_Void_DPIPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006379 RID: 25465 RVA: 0x0018F7E0 File Offset: 0x0018D9E0
	[CallerCount(0)]
	public unsafe void RPC_Heal(RpcTarget invokeRpcTarget, int healingItemID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref healingItemID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_Heal_Public_Void_RpcTarget_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600637A RID: 25466 RVA: 0x0018F848 File Offset: 0x0018DA48
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique_DPINetworkMessageInfo_0(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tmp));
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600637B RID: 25467 RVA: 0x0018F8C4 File Offset: 0x0018DAC4
	[CallerCount(0)]
	public unsafe void RPC_HealRemote(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, int healingItemID, int endState, bool endBleedingState, DPIPlayer healingSource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref healingItemID;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endState;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endBleedingState;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(healingSource);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_HealRemote_Public_Void_ArrayOf_DPIPlayer_Int32_Int32_Boolean_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600637C RID: 25468 RVA: 0x0018F970 File Offset: 0x0018DB70
	[CallerCount(0)]
	public unsafe void RPC_HealRemote(DPIPlayer invokeRpcPlayerTarget, int healingItemID, int endState, bool endBleedingState, DPIPlayer healingSource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref healingItemID;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endState;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endBleedingState;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(healingSource);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_HealRemote_Public_Void_DPIPlayer_Int32_Int32_Boolean_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600637D RID: 25469 RVA: 0x0018FA1C File Offset: 0x0018DC1C
	[CallerCount(0)]
	public unsafe void RPC_HealRemote(RpcTarget invokeRpcTarget, int healingItemID, int endState, bool endBleedingState, DPIPlayer healingSource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref healingItemID;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endState;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endBleedingState;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(healingSource);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_HealRemote_Public_Void_RpcTarget_Int32_Int32_Boolean_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600637E RID: 25470 RVA: 0x0018FAC4 File Offset: 0x0018DCC4
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableSiUnique_DPINetworkMessageInfo_0(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableSiUnique_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600637F RID: 25471 RVA: 0x0018FB38 File Offset: 0x0018DD38
	[CallerCount(0)]
	public unsafe void RPC_SetArmorHP(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, float newHP)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newHP;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_SetArmorHP_Public_Void_ArrayOf_DPIPlayer_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006380 RID: 25472 RVA: 0x0018FBA4 File Offset: 0x0018DDA4
	[CallerCount(0)]
	public unsafe void RPC_SetArmorHP(DPIPlayer invokeRpcPlayerTarget, float newHP)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newHP;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_SetArmorHP_Public_Void_DPIPlayer_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006381 RID: 25473 RVA: 0x0018FC10 File Offset: 0x0018DE10
	[CallerCount(0)]
	public unsafe void RPC_SetArmorHP(RpcTarget invokeRpcTarget, float newHP)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newHP;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_SetArmorHP_Public_Void_RpcTarget_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006382 RID: 25474 RVA: 0x0018FC78 File Offset: 0x0018DE78
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique_DPINetworkMessageInfo_0(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tmp));
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006383 RID: 25475 RVA: 0x0018FCF4 File Offset: 0x0018DEF4
	[CallerCount(0)]
	public unsafe void RPC_SetHP(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, float newHp, DPIPlayer playerSource, int aiSourceID, Vector3 hitPos, Vector3 shootPos, bool isDead, int damagedPart, float damage, int damageType, int weaponName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newHp;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerSource);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aiSourceID;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPos;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shootPos;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDead;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damagedPart;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damage;
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageType;
		ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponName;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_SetHP_Public_Void_ArrayOf_DPIPlayer_Single_DPIPlayer_Int32_Vector3_Vector3_Boolean_Int32_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006384 RID: 25476 RVA: 0x0018FE14 File Offset: 0x0018E014
	[CallerCount(0)]
	public unsafe void RPC_SetHP(DPIPlayer invokeRpcPlayerTarget, float newHp, DPIPlayer playerSource, int aiSourceID, Vector3 hitPos, Vector3 shootPos, bool isDead, int damagedPart, float damage, int damageType, int weaponName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newHp;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerSource);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aiSourceID;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPos;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shootPos;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDead;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damagedPart;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damage;
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageType;
		ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponName;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_SetHP_Public_Void_DPIPlayer_Single_DPIPlayer_Int32_Vector3_Vector3_Boolean_Int32_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006385 RID: 25477 RVA: 0x0018FF34 File Offset: 0x0018E134
	[CallerCount(0)]
	public unsafe void RPC_SetHP(RpcTarget invokeRpcTarget, float newHp, DPIPlayer playerSource, int aiSourceID, Vector3 hitPos, Vector3 shootPos, bool isDead, int damagedPart, float damage, int damageType, int weaponName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newHp;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerSource);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aiSourceID;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPos;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shootPos;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDead;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damagedPart;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damage;
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageType;
		ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponName;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_SetHP_Public_Void_RpcTarget_Single_DPIPlayer_Int32_Vector3_Vector3_Boolean_Int32_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006386 RID: 25478 RVA: 0x00190050 File Offset: 0x0018E250
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableDPUnique_DPINetworkMessageInfo_0(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tmp));
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableDPUnique_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006387 RID: 25479 RVA: 0x001900CC File Offset: 0x0018E2CC
	[CallerCount(0)]
	public unsafe void RPC_UpdateMe(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, DPIPlayer requestFrom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestFrom);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_UpdateMe_Public_Void_ArrayOf_DPIPlayer_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006388 RID: 25480 RVA: 0x00190140 File Offset: 0x0018E340
	[CallerCount(0)]
	public unsafe void RPC_UpdateMe(DPIPlayer invokeRpcPlayerTarget, DPIPlayer requestFrom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestFrom);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_UpdateMe_Public_Void_DPIPlayer_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006389 RID: 25481 RVA: 0x001901B4 File Offset: 0x0018E3B4
	[CallerCount(0)]
	public unsafe void RPC_UpdateMe(RpcTarget invokeRpcTarget, DPIPlayer requestFrom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestFrom);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_UpdateMe_Public_Void_RpcTarget_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600638A RID: 25482 RVA: 0x00190220 File Offset: 0x0018E420
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique_DPINetworkMessageInfo_0(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600638B RID: 25483 RVA: 0x00190294 File Offset: 0x0018E494
	[CallerCount(0)]
	public unsafe void RPC_ThisPlayerState(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, float realHp, float armorHP, bool isDead, bool realspawn, Vector3 pos, bool isragdoll)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref realHp;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref armorHP;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDead;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref realspawn;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isragdoll;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_ThisPlayerState_Public_Void_ArrayOf_DPIPlayer_Single_Single_Boolean_Boolean_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600638C RID: 25484 RVA: 0x00190360 File Offset: 0x0018E560
	[CallerCount(0)]
	public unsafe void RPC_ThisPlayerState(DPIPlayer invokeRpcPlayerTarget, float realHp, float armorHP, bool isDead, bool realspawn, Vector3 pos, bool isragdoll)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref realHp;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref armorHP;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDead;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref realspawn;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isragdoll;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_ThisPlayerState_Public_Void_DPIPlayer_Single_Single_Boolean_Boolean_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600638D RID: 25485 RVA: 0x0019042C File Offset: 0x0018E62C
	[CallerCount(0)]
	public unsafe void RPC_ThisPlayerState(RpcTarget invokeRpcTarget, float realHp, float armorHP, bool isDead, bool realspawn, Vector3 pos, bool isragdoll)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref realHp;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref armorHP;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDead;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref realspawn;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isragdoll;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_ThisPlayerState_Public_Void_RpcTarget_Single_Single_Boolean_Boolean_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600638E RID: 25486 RVA: 0x001904F4 File Offset: 0x0018E6F4
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0_DPINetworkMessageInfo_0(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0 tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600638F RID: 25487 RVA: 0x00190568 File Offset: 0x0018E768
	[CallerCount(0)]
	public unsafe void RPC_TinitusMe(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_TinitusMe_Public_Void_ArrayOf_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006390 RID: 25488 RVA: 0x001905C4 File Offset: 0x0018E7C4
	[CallerCount(0)]
	public unsafe void RPC_TinitusMe(DPIPlayer invokeRpcPlayerTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_TinitusMe_Public_Void_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006391 RID: 25489 RVA: 0x00190620 File Offset: 0x0018E820
	[CallerCount(0)]
	public unsafe void RPC_TinitusMe(RpcTarget invokeRpcTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_TinitusMe_Public_Void_RpcTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006392 RID: 25490 RVA: 0x00190674 File Offset: 0x0018E874
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0_DPINetworkMessageInfo_0(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0 tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006393 RID: 25491 RVA: 0x001906E8 File Offset: 0x0018E8E8
	[CallerCount(0)]
	public unsafe void RPC_ManualInvincibility(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, bool invincible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invincible;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_ManualInvincibility_Public_Void_ArrayOf_DPIPlayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006394 RID: 25492 RVA: 0x00190754 File Offset: 0x0018E954
	[CallerCount(0)]
	public unsafe void RPC_ManualInvincibility(DPIPlayer invokeRpcPlayerTarget, bool invincible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invincible;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_ManualInvincibility_Public_Void_DPIPlayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006395 RID: 25493 RVA: 0x001907C0 File Offset: 0x0018E9C0
	[CallerCount(0)]
	public unsafe void RPC_ManualInvincibility(RpcTarget invokeRpcTarget, bool invincible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invincible;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_ManualInvincibility_Public_Void_RpcTarget_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006396 RID: 25494 RVA: 0x00190828 File Offset: 0x0018EA28
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1_DPINetworkMessageInfo_0(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1 tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006397 RID: 25495 RVA: 0x0019089C File Offset: 0x0018EA9C
	[CallerCount(0)]
	public unsafe void RPC_Targetability(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets, bool targetable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetable;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_Targetability_Public_Void_ArrayOf_DPIPlayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006398 RID: 25496 RVA: 0x00190908 File Offset: 0x0018EB08
	[CallerCount(0)]
	public unsafe void RPC_Targetability(DPIPlayer invokeRpcPlayerTarget, bool targetable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetable;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_Targetability_Public_Void_DPIPlayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006399 RID: 25497 RVA: 0x00190974 File Offset: 0x0018EB74
	[CallerCount(0)]
	public unsafe void RPC_Targetability(RpcTarget invokeRpcTarget, bool targetable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetable;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_Targetability_Public_Void_RpcTarget_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600639A RID: 25498 RVA: 0x001909DC File Offset: 0x0018EBDC
	[CallerCount(0)]
	public unsafe void Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1_DPINetworkMessageInfo_0(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1 tmp, DPINetworkMessageInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref tmp;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1_DPINetworkMessageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600639B RID: 25499 RVA: 0x00190A50 File Offset: 0x0018EC50
	[CallerCount(0)]
	public unsafe void RPC_AIWhistle(Il2CppReferenceArray<DPIPlayer> invokeRpcPlayerTargets)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTargets);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_AIWhistle_Public_Void_ArrayOf_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600639C RID: 25500 RVA: 0x00190AAC File Offset: 0x0018ECAC
	[CallerCount(0)]
	public unsafe void RPC_AIWhistle(DPIPlayer invokeRpcPlayerTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokeRpcPlayerTarget);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_AIWhistle_Public_Void_DPIPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600639D RID: 25501 RVA: 0x00190B08 File Offset: 0x0018ED08
	[CallerCount(0)]
	public unsafe void RPC_AIWhistle(RpcTarget invokeRpcTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref invokeRpcTarget;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr_RPC_AIWhistle_Public_Void_RpcTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600639E RID: 25502 RVA: 0x00190B5C File Offset: 0x0018ED5C
	[CallerCount(0)]
	public new unsafe void OnCodeGenInitializeHook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WarPlayerScript.NativeMethodInfoPtr_OnCodeGenInitializeHook_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600639F RID: 25503 RVA: 0x00190BAC File Offset: 0x0018EDAC
	[CallerCount(0)]
	public unsafe WarPlayerScript() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060063A0 RID: 25504 RVA: 0x00190BF8 File Offset: 0x0018EDF8
	// Note: this type is marked as 'beforefieldinit'.
	static WarPlayerScript()
	{
		Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WarPlayerScript");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr);
		WarPlayerScript.NativeFieldInfoPtr_HEALTH_ON_DOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "HEALTH_ON_DOWN");
		WarPlayerScript.NativeFieldInfoPtr_MAX_HEALTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "MAX_HEALTH");
		WarPlayerScript.NativeFieldInfoPtr_OutlineAlphaMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "OutlineAlphaMultiplier");
		WarPlayerScript.NativeFieldInfoPtr_DOWN_HEAL_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "DOWN_HEAL_COOLDOWN");
		WarPlayerScript.NativeFieldInfoPtr_DEAD_HEAL_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "DEAD_HEAL_COOLDOWN");
		WarPlayerScript.NativeFieldInfoPtr_AllWarPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "AllWarPlayers");
		WarPlayerScript.NativeFieldInfoPtr_AllActiveWarPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "AllActiveWarPlayers");
		WarPlayerScript.NativeFieldInfoPtr_AllAliveWarPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "AllAliveWarPlayers");
		WarPlayerScript.NativeFieldInfoPtr_LocalWarPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "LocalWarPlayer");
		WarPlayerScript.NativeFieldInfoPtr_MirroredDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "MirroredDamage");
		WarPlayerScript.NativeFieldInfoPtr_AnyPlayerHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "AnyPlayerHit");
		WarPlayerScript.NativeFieldInfoPtr_AnyPlayerRessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "AnyPlayerRessed");
		WarPlayerScript.NativeFieldInfoPtr_AnyPlayerHacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "AnyPlayerHacked");
		WarPlayerScript.NativeFieldInfoPtr_AnyPlayerShooting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "AnyPlayerShooting");
		WarPlayerScript.NativeFieldInfoPtr_OnAnyPlayerHealthEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "OnAnyPlayerHealthEvent");
		WarPlayerScript.NativeFieldInfoPtr_AnyPlayerSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "AnyPlayerSpawned");
		WarPlayerScript.NativeFieldInfoPtr_AnyPlayerUnDowned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "AnyPlayerUnDowned");
		WarPlayerScript.NativeFieldInfoPtr_OnVIPSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "OnVIPSet");
		WarPlayerScript.NativeFieldInfoPtr_OnPlayerStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "OnPlayerStateChanged");
		WarPlayerScript.NativeFieldInfoPtr_PlayerShooting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "PlayerShooting");
		WarPlayerScript.NativeFieldInfoPtr_PlayerSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "PlayerSpawned");
		WarPlayerScript.NativeFieldInfoPtr_PlayerDespawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "PlayerDespawned");
		WarPlayerScript.NativeFieldInfoPtr_MiniMapIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "MiniMapIcon");
		WarPlayerScript.NativeFieldInfoPtr_OwningPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "OwningPlayer");
		WarPlayerScript.NativeFieldInfoPtr_ThisPlayerSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "ThisPlayerSpawned");
		WarPlayerScript.NativeFieldInfoPtr_ThisPlayerRevived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "ThisPlayerRevived");
		WarPlayerScript.NativeFieldInfoPtr_VRCharacterControllerScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "VRCharacterControllerScript");
		WarPlayerScript.NativeFieldInfoPtr_PlayerUIController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "PlayerUIController");
		WarPlayerScript.NativeFieldInfoPtr_IkWeightController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "IkWeightController");
		WarPlayerScript.NativeFieldInfoPtr_CameraManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "CameraManager");
		WarPlayerScript.NativeFieldInfoPtr_VRAnimatorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "VRAnimatorController");
		WarPlayerScript.NativeFieldInfoPtr_m_InventoryManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "m_InventoryManager");
		WarPlayerScript.NativeFieldInfoPtr_WhistleAlertData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "WhistleAlertData");
		WarPlayerScript.NativeFieldInfoPtr_playerNameObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "playerNameObj");
		WarPlayerScript.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "playerName");
		WarPlayerScript.NativeFieldInfoPtr_isBleeding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "isBleeding");
		WarPlayerScript.NativeFieldInfoPtr_IsFirstRoundSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "IsFirstRoundSpawn");
		WarPlayerScript.NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "currentState");
		WarPlayerScript.NativeFieldInfoPtr_SuppresionGamObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "SuppresionGamObject");
		WarPlayerScript.NativeFieldInfoPtr_OnDownedOrDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "OnDownedOrDead");
		WarPlayerScript.NativeFieldInfoPtr_OnIKUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "OnIKUpdated");
		WarPlayerScript.NativeFieldInfoPtr_MySoldierClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "MySoldierClass");
		WarPlayerScript.NativeFieldInfoPtr_playerLoadout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "playerLoadout");
		WarPlayerScript.NativeFieldInfoPtr_isBeingSpectated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "isBeingSpectated");
		WarPlayerScript.NativeFieldInfoPtr_TimeSinceLastSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "TimeSinceLastSpawn");
		WarPlayerScript.NativeFieldInfoPtr_SpawnAudioImmunityTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "SpawnAudioImmunityTime");
		WarPlayerScript.NativeFieldInfoPtr_DamageController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "DamageController");
		WarPlayerScript.NativeFieldInfoPtr_NightVision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "NightVision");
		WarPlayerScript.NativeFieldInfoPtr_CurrentArmorHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "CurrentArmorHealth");
		WarPlayerScript.NativeFieldInfoPtr_Dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Dead");
		WarPlayerScript.NativeFieldInfoPtr_Spawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Spawned");
		WarPlayerScript.NativeFieldInfoPtr_HasQuitToTent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "HasQuitToTent");
		WarPlayerScript.NativeFieldInfoPtr_Flashed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Flashed");
		WarPlayerScript.NativeFieldInfoPtr_NVLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "NVLight");
		WarPlayerScript.NativeFieldInfoPtr_ragdollSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "ragdollSet");
		WarPlayerScript.NativeFieldInfoPtr_TinitusEars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "TinitusEars");
		WarPlayerScript.NativeFieldInfoPtr_Tinitused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Tinitused");
		WarPlayerScript.NativeFieldInfoPtr_Counted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Counted");
		WarPlayerScript.NativeFieldInfoPtr_isEscortVIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "isEscortVIP");
		WarPlayerScript.NativeFieldInfoPtr_VIPthem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "VIPthem");
		WarPlayerScript.NativeFieldInfoPtr_leftWatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "leftWatch");
		WarPlayerScript.NativeFieldInfoPtr_rightWatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "rightWatch");
		WarPlayerScript.NativeFieldInfoPtr_WristWatchScripts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "WristWatchScripts");
		WarPlayerScript.NativeFieldInfoPtr_PainScreams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "PainScreams");
		WarPlayerScript.NativeFieldInfoPtr_VestRadio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "VestRadio");
		WarPlayerScript.NativeFieldInfoPtr_RadioHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "RadioHolder");
		WarPlayerScript.NativeFieldInfoPtr_VoiceView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "VoiceView");
		WarPlayerScript.NativeFieldInfoPtr_FPSpectateCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "FPSpectateCamera");
		WarPlayerScript.NativeFieldInfoPtr_TPSpectateCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "TPSpectateCamera");
		WarPlayerScript.NativeFieldInfoPtr_ActiveSpectateCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "ActiveSpectateCamera");
		WarPlayerScript.NativeFieldInfoPtr_hasInitSpectateCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "hasInitSpectateCamera");
		WarPlayerScript.NativeFieldInfoPtr_spectateAspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "spectateAspectRatio");
		WarPlayerScript.NativeFieldInfoPtr_MasterVisualEffectsOBJ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "MasterVisualEffectsOBJ");
		WarPlayerScript.NativeFieldInfoPtr_networkSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "networkSync");
		WarPlayerScript.NativeFieldInfoPtr_ragdollUtility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "ragdollUtility");
		WarPlayerScript.NativeFieldInfoPtr_HeadEffector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "HeadEffector");
		WarPlayerScript.NativeFieldInfoPtr_NetworkHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "NetworkHat");
		WarPlayerScript.NativeFieldInfoPtr_OtherPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "OtherPlayer");
		WarPlayerScript.NativeFieldInfoPtr_LastDamageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "LastDamageType");
		WarPlayerScript.NativeFieldInfoPtr_LastDamageTypeBeforeSuicide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "LastDamageTypeBeforeSuicide");
		WarPlayerScript.NativeFieldInfoPtr_LastWeaponHitBeforeSuicide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "LastWeaponHitBeforeSuicide");
		WarPlayerScript.NativeFieldInfoPtr_LastWeaponFired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "LastWeaponFired");
		WarPlayerScript.NativeFieldInfoPtr_OtherAIPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "OtherAIPlayer");
		WarPlayerScript.NativeFieldInfoPtr_OtherAIPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "OtherAIPlayerID");
		WarPlayerScript.NativeFieldInfoPtr_ik = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "ik");
		WarPlayerScript.NativeFieldInfoPtr_PlayerRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "PlayerRotation");
		WarPlayerScript.NativeFieldInfoPtr_Outline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Outline");
		WarPlayerScript.NativeFieldInfoPtr_VisualLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "VisualLoader");
		WarPlayerScript.NativeFieldInfoPtr_DisableWhenDowned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "DisableWhenDowned");
		WarPlayerScript.NativeFieldInfoPtr_DamageLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "DamageLine");
		WarPlayerScript.NativeFieldInfoPtr_PouchVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "PouchVisibility");
		WarPlayerScript.NativeFieldInfoPtr_SightOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "SightOrigin");
		WarPlayerScript.NativeFieldInfoPtr_FakeGuyLodMeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "FakeGuyLodMeshRenderer");
		WarPlayerScript.NativeFieldInfoPtr_SkeletonManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "SkeletonManager");
		WarPlayerScript.NativeFieldInfoPtr_UplinkDetectorCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "UplinkDetectorCollider");
		WarPlayerScript.NativeFieldInfoPtr_VisionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "VisionTarget");
		WarPlayerScript.NativeFieldInfoPtr_GearManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "GearManager");
		WarPlayerScript.NativeFieldInfoPtr_SFBigBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "SFBigBag");
		WarPlayerScript.NativeFieldInfoPtr_SFSmallBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "SFSmallBag");
		WarPlayerScript.NativeFieldInfoPtr_MiniBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "MiniBag");
		WarPlayerScript.NativeFieldInfoPtr_MarsocGloves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "MarsocGloves");
		WarPlayerScript.NativeFieldInfoPtr_OSBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "OSBag");
		WarPlayerScript.NativeFieldInfoPtr_VolkGloves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "VolkGloves");
		WarPlayerScript.NativeFieldInfoPtr_FakeLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "FakeLights");
		WarPlayerScript.NativeFieldInfoPtr_LocalHandsMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "LocalHandsMesh");
		WarPlayerScript.NativeFieldInfoPtr_LocalVest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "LocalVest");
		WarPlayerScript.NativeFieldInfoPtr_VestDisabledOnDeadOrDowned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "VestDisabledOnDeadOrDowned");
		WarPlayerScript.NativeFieldInfoPtr_VestDisabledOnDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "VestDisabledOnDead");
		WarPlayerScript.NativeFieldInfoPtr_LocalVestRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "LocalVestRenderer");
		WarPlayerScript.NativeFieldInfoPtr_BodyColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "BodyColliders");
		WarPlayerScript.NativeFieldInfoPtr_LocalBodyColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "LocalBodyColliders");
		WarPlayerScript.NativeFieldInfoPtr_ragdollController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "ragdollController");
		WarPlayerScript.NativeFieldInfoPtr_NetworkBreath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "NetworkBreath");
		WarPlayerScript.NativeFieldInfoPtr_NetworkBreathPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "NetworkBreathPos");
		WarPlayerScript.NativeFieldInfoPtr_LocalBreath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "LocalBreath");
		WarPlayerScript.NativeFieldInfoPtr_VoicePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "VoicePosition");
		WarPlayerScript.NativeFieldInfoPtr_FPPostProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "FPPostProcess");
		WarPlayerScript.NativeFieldInfoPtr_FPLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "FPLight");
		WarPlayerScript.NativeFieldInfoPtr_TPPostProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "TPPostProcess");
		WarPlayerScript.NativeFieldInfoPtr_TPLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "TPLight");
		WarPlayerScript.NativeFieldInfoPtr_ArmorObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "ArmorObjects");
		WarPlayerScript.NativeFieldInfoPtr__TeammateWhoDownedMe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "<TeammateWhoDownedMe>k__BackingField");
		WarPlayerScript.NativeFieldInfoPtr__IsInDeathTransition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "<IsInDeathTransition>k__BackingField");
		WarPlayerScript.NativeFieldInfoPtr_KarmaDialogTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "KarmaDialogTime");
		WarPlayerScript.NativeFieldInfoPtr_hasInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "hasInit");
		WarPlayerScript.NativeFieldInfoPtr_lastPainSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "lastPainSound");
		WarPlayerScript.NativeFieldInfoPtr_timeBetweenPainSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "timeBetweenPainSounds");
		WarPlayerScript.NativeFieldInfoPtr_ShadowToggler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "ShadowToggler");
		WarPlayerScript.NativeFieldInfoPtr__watchSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "_watchSetting");
		WarPlayerScript.NativeFieldInfoPtr_KillingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "KillingPlayer");
		WarPlayerScript.NativeFieldInfoPtr_teamKillingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "teamKillingPlayer");
		WarPlayerScript.NativeFieldInfoPtr__DeathPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "<DeathPosition>k__BackingField");
		WarPlayerScript.NativeFieldInfoPtr__TimeOfLastStateChange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "<TimeOfLastStateChange>k__BackingField");
		WarPlayerScript.NativeFieldInfoPtr_BleedOutRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "BleedOutRoutine");
		WarPlayerScript.NativeFieldInfoPtr__deathTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "_deathTransition");
		WarPlayerScript.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "<ManagedUpdateRemoval>k__BackingField");
		WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableDPInInUnique_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_H_RPC_ApplyTaserDamage");
		WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInUnique_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_H_RPC_Heal");
		WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_H_RPC_HealRemote");
		WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiUnique_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_H_RPC_SetArmorHP");
		WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_H_RPC_SetHP");
		WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableDPUnique_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_H_RPC_UpdateMe");
		WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_H_RPC_ThisPlayerState");
		WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_H_RPC_TinitusMe");
		WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_H_RPC_ManualInvincibility");
		WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_H_RPC_Targetability");
		WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_H_RPC_AIWhistle");
		WarPlayerScript.NativeMethodInfoPtr_add_AnyPlayerHit_Public_Static_add_Void_PlayerDamaged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671141);
		WarPlayerScript.NativeMethodInfoPtr_remove_AnyPlayerHit_Public_Static_rem_Void_PlayerDamaged_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671142);
		WarPlayerScript.NativeMethodInfoPtr_add_AnyPlayerRessed_Public_Static_add_Void_PlayerHealedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671143);
		WarPlayerScript.NativeMethodInfoPtr_remove_AnyPlayerRessed_Public_Static_rem_Void_PlayerHealedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671144);
		WarPlayerScript.NativeMethodInfoPtr_add_AnyPlayerShooting_Public_Static_add_Void_OtherPlayerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671145);
		WarPlayerScript.NativeMethodInfoPtr_remove_AnyPlayerShooting_Public_Static_rem_Void_OtherPlayerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671146);
		WarPlayerScript.NativeMethodInfoPtr_add_AnyPlayerSpawned_Public_Static_add_Void_AnyPlayerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671147);
		WarPlayerScript.NativeMethodInfoPtr_remove_AnyPlayerSpawned_Public_Static_rem_Void_AnyPlayerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671148);
		WarPlayerScript.NativeMethodInfoPtr_add_AnyPlayerUnDowned_Public_Static_add_Void_SpecificPlayerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671149);
		WarPlayerScript.NativeMethodInfoPtr_remove_AnyPlayerUnDowned_Public_Static_rem_Void_SpecificPlayerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671150);
		WarPlayerScript.NativeMethodInfoPtr_add_PlayerShooting_Public_add_Void_PlayerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671151);
		WarPlayerScript.NativeMethodInfoPtr_remove_PlayerShooting_Public_rem_Void_PlayerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671152);
		WarPlayerScript.NativeMethodInfoPtr_add_PlayerSpawned_Public_add_Void_PlayerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671153);
		WarPlayerScript.NativeMethodInfoPtr_remove_PlayerSpawned_Public_rem_Void_PlayerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671154);
		WarPlayerScript.NativeMethodInfoPtr_add_PlayerDespawned_Public_add_Void_PlayerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671155);
		WarPlayerScript.NativeMethodInfoPtr_remove_PlayerDespawned_Public_rem_Void_PlayerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671156);
		WarPlayerScript.NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671157);
		WarPlayerScript.NativeMethodInfoPtr_get_PlayerFaction_Public_get_Faction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671158);
		WarPlayerScript.NativeMethodInfoPtr_get_HasSpawnAudioImmunity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671159);
		WarPlayerScript.NativeMethodInfoPtr_get_IsNightVisionOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671160);
		WarPlayerScript.NativeMethodInfoPtr_get_TeammateWhoDownedMe_Public_get_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671161);
		WarPlayerScript.NativeMethodInfoPtr_set_TeammateWhoDownedMe_Protected_set_Void_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671162);
		WarPlayerScript.NativeMethodInfoPtr_get_IsInDeathTransition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671163);
		WarPlayerScript.NativeMethodInfoPtr_set_IsInDeathTransition_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671164);
		WarPlayerScript.NativeMethodInfoPtr_get_DeathPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671165);
		WarPlayerScript.NativeMethodInfoPtr_set_DeathPosition_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671166);
		WarPlayerScript.NativeMethodInfoPtr_get_IsFriendly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671167);
		WarPlayerScript.NativeMethodInfoPtr_get_TimeOfLastStateChange_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671168);
		WarPlayerScript.NativeMethodInfoPtr_set_TimeOfLastStateChange_Private_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671169);
		WarPlayerScript.NativeMethodInfoPtr_get_IsEnemy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671170);
		WarPlayerScript.NativeMethodInfoPtr_GetWarPlayer_Public_Static_WarPlayerScript_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671171);
		WarPlayerScript.NativeMethodInfoPtr_ClearReferencesToPlayer_Public_Void_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671172);
		WarPlayerScript.NativeMethodInfoPtr_SetOtherAIInfo_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671173);
		WarPlayerScript.NativeMethodInfoPtr_ShutOff_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671174);
		WarPlayerScript.NativeMethodInfoPtr_ShutOffWithoutDisconnect_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671175);
		WarPlayerScript.NativeMethodInfoPtr_GetWatchSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671176);
		WarPlayerScript.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671177);
		WarPlayerScript.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671178);
		WarPlayerScript.NativeMethodInfoPtr_ResetKillingPlayer_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671179);
		WarPlayerScript.NativeMethodInfoPtr_OnDestroy_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671180);
		WarPlayerScript.NativeMethodInfoPtr_OnPlayerLeftTeam_Protected_Void_OnwardPhotonPlayer_Team_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671181);
		WarPlayerScript.NativeMethodInfoPtr_AddCameraIn_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671182);
		WarPlayerScript.NativeMethodInfoPtr_AddCameraNow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671183);
		WarPlayerScript.NativeMethodInfoPtr_SetFirstPersonEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671184);
		WarPlayerScript.NativeMethodInfoPtr_SetThirdPersonEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671185);
		WarPlayerScript.NativeMethodInfoPtr_Awake_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671186);
		WarPlayerScript.NativeMethodInfoPtr_ToggleInvisibleShadowCasterLOD_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671187);
		WarPlayerScript.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671188);
		WarPlayerScript.NativeMethodInfoPtr_Init_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671189);
		WarPlayerScript.NativeMethodInfoPtr_SetupSpectateCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671190);
		WarPlayerScript.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671191);
		WarPlayerScript.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671192);
		WarPlayerScript.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671193);
		WarPlayerScript.NativeMethodInfoPtr_SetLocalIconColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671194);
		WarPlayerScript.NativeMethodInfoPtr_RefreshAllPlayerIcons_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671195);
		WarPlayerScript.NativeMethodInfoPtr_RefreshPlayerIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671196);
		WarPlayerScript.NativeMethodInfoPtr_RefreshAllyMapIcon_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671197);
		WarPlayerScript.NativeMethodInfoPtr_RefreshAllyMapColor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671198);
		WarPlayerScript.NativeMethodInfoPtr_RefreshEnemyMapIcon_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671199);
		WarPlayerScript.NativeMethodInfoPtr_RefreshEnemyMapColor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671200);
		WarPlayerScript.NativeMethodInfoPtr_ApplyDamage_Public_Void_Single_DPIPlayer_Int32_DamageType_byref_Nullable_1_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671201);
		WarPlayerScript.NativeMethodInfoPtr_ApplyDamage_Public_Void_Single_Vector3_BodyParts_DPIPlayer_Int32_DamageType_byref_Nullable_1_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671202);
		WarPlayerScript.NativeMethodInfoPtr_ApplyTaserDamage_Public_Void_OnwardPhotonPlayer_Int32_Pickup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671203);
		WarPlayerScript.NativeMethodInfoPtr_RPC_ApplyTaserDamage_Public_Void_DPIPlayer_Int32_Int32_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671204);
		WarPlayerScript.NativeMethodInfoPtr_IsHitInfractable_Protected_Boolean_Boolean_Boolean_Boolean_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671205);
		WarPlayerScript.NativeMethodInfoPtr_SendHeal_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671206);
		WarPlayerScript.NativeMethodInfoPtr_RPC_Heal_Public_Void_Int32_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671207);
		WarPlayerScript.NativeMethodInfoPtr_LocalHeal_Private_Void_Int32_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671208);
		WarPlayerScript.NativeMethodInfoPtr_RPC_HealRemote_Public_Void_Int32_Int32_Boolean_DPIPlayer_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671209);
		WarPlayerScript.NativeMethodInfoPtr_FullyStopBleedingAndEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671210);
		WarPlayerScript.NativeMethodInfoPtr_HealScore_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671211);
		WarPlayerScript.NativeMethodInfoPtr_RPC_SetArmorHP_Public_Void_Single_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671212);
		WarPlayerScript.NativeMethodInfoPtr_SetHP_Public_Void_Single_DPIPlayer_Int32_Boolean_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671213);
		WarPlayerScript.NativeMethodInfoPtr_RPC_SetHP_Public_Void_Single_DPIPlayer_Int32_Vector3_Vector3_Boolean_Int32_Single_Int32_Int32_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671214);
		WarPlayerScript.NativeMethodInfoPtr_IgnoreBleed_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671215);
		WarPlayerScript.NativeMethodInfoPtr_StopBleedOnHeal_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671216);
		WarPlayerScript.NativeMethodInfoPtr_OnPlayerHit_Private_Void_WarPlayerScript_WarPlayerScript_Boolean_Boolean_Boolean_BodyParts_Vector3_Vector3_Single_DamageType_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671217);
		WarPlayerScript.NativeMethodInfoPtr_OnLocalDowned_Private_Void_WarPlayerScript_Boolean_DamageType_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671218);
		WarPlayerScript.NativeMethodInfoPtr_OnLocalDeath_Private_Void_Boolean_Boolean_WarPlayerScript_DamageType_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671219);
		WarPlayerScript.NativeMethodInfoPtr_ShowInfractionUI_Private_Void_WarPlayerScript_Boolean_DamageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671220);
		WarPlayerScript.NativeMethodInfoPtr_SetHPMax_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671221);
		WarPlayerScript.NativeMethodInfoPtr_SetDead_Private_Void_DamageType_Boolean_Boolean_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671222);
		WarPlayerScript.NativeMethodInfoPtr_LocalPlayerDied_Private_Void_DamageType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671223);
		WarPlayerScript.NativeMethodInfoPtr_PainStopVoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671224);
		WarPlayerScript.NativeMethodInfoPtr_PainPlayCry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671225);
		WarPlayerScript.NativeMethodInfoPtr_PainPlayGrunt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671226);
		WarPlayerScript.NativeMethodInfoPtr_OnCasualtyUIVisible_Public_Void_CasualtyUIState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671227);
		WarPlayerScript.NativeMethodInfoPtr_SetLastDamage_Public_Void_DamageType_Nullable_1_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671228);
		WarPlayerScript.NativeMethodInfoPtr_PainPlayDrown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671229);
		WarPlayerScript.NativeMethodInfoPtr_GetKilledByText_Public_String_DamageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671230);
		WarPlayerScript.NativeMethodInfoPtr_GetDownedByText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671231);
		WarPlayerScript.NativeMethodInfoPtr_ResetBody_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671232);
		WarPlayerScript.NativeMethodInfoPtr_ResetKarmaDialogTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671233);
		WarPlayerScript.NativeMethodInfoPtr_DeathTransition_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671234);
		WarPlayerScript.NativeMethodInfoPtr_BleedOut_Public_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671235);
		WarPlayerScript.NativeMethodInfoPtr_StopBleedOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671236);
		WarPlayerScript.NativeMethodInfoPtr_Respawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671237);
		WarPlayerScript.NativeMethodInfoPtr_SetInvincibility_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671238);
		WarPlayerScript.NativeMethodInfoPtr_RPC_UpdateMe_Public_Void_DPIPlayer_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671239);
		WarPlayerScript.NativeMethodInfoPtr_RPC_ThisPlayerState_Public_Void_Single_Single_Boolean_Boolean_Vector3_Boolean_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671240);
		WarPlayerScript.NativeMethodInfoPtr_DownPlayer_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671241);
		WarPlayerScript.NativeMethodInfoPtr_UnDownPlayer_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671242);
		WarPlayerScript.NativeMethodInfoPtr_SetRagdollActive_Private_Void_Boolean_DPIPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671243);
		WarPlayerScript.NativeMethodInfoPtr_UpdateHandModels_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671244);
		WarPlayerScript.NativeMethodInfoPtr_SetState_Public_Void_PlayerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671245);
		WarPlayerScript.NativeMethodInfoPtr_IsRevivable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671246);
		WarPlayerScript.NativeMethodInfoPtr_RefreshShadows_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671247);
		WarPlayerScript.NativeMethodInfoPtr_FlashMe_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671248);
		WarPlayerScript.NativeMethodInfoPtr_RPC_TinitusMe_Public_Void_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671249);
		WarPlayerScript.NativeMethodInfoPtr_FlashStart_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671250);
		WarPlayerScript.NativeMethodInfoPtr_StartTinitus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671251);
		WarPlayerScript.NativeMethodInfoPtr_DelayDisableTinitus_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671252);
		WarPlayerScript.NativeMethodInfoPtr_ResetGear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671253);
		WarPlayerScript.NativeMethodInfoPtr_DisableObject_Protected_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671254);
		WarPlayerScript.NativeMethodInfoPtr_LoadVisuals_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671255);
		WarPlayerScript.NativeMethodInfoPtr_UpdateFakeLights_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671256);
		WarPlayerScript.NativeMethodInfoPtr_RefreshOutfit_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671257);
		WarPlayerScript.NativeMethodInfoPtr_SetOutfit_Public_Void_SoldierClass_Faction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671258);
		WarPlayerScript.NativeMethodInfoPtr_ShowWatchVisuals_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671259);
		WarPlayerScript.NativeMethodInfoPtr_SynchronizeVIPState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671260);
		WarPlayerScript.NativeMethodInfoPtr_SpectateMe_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671261);
		WarPlayerScript.NativeMethodInfoPtr_GetBarrelPosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671262);
		WarPlayerScript.NativeMethodInfoPtr_PlayerShot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671263);
		WarPlayerScript.NativeMethodInfoPtr_ForceActivateLocalWarPlayer_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671264);
		WarPlayerScript.NativeMethodInfoPtr_ResetSpawnAudioImmunity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671265);
		WarPlayerScript.NativeMethodInfoPtr_SetNameColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671266);
		WarPlayerScript.NativeMethodInfoPtr_RemovePlayerEntry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671267);
		WarPlayerScript.NativeMethodInfoPtr_SetManualInvincibility_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671268);
		WarPlayerScript.NativeMethodInfoPtr_ToggleManualInvincibility_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671269);
		WarPlayerScript.NativeMethodInfoPtr_SetAllManuallyInvincible_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671270);
		WarPlayerScript.NativeMethodInfoPtr_RPC_ManualInvincibility_Protected_Void_Boolean_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671271);
		WarPlayerScript.NativeMethodInfoPtr_RPC_Targetability_Protected_Void_Boolean_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671272);
		WarPlayerScript.NativeMethodInfoPtr_SendWhistle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671273);
		WarPlayerScript.NativeMethodInfoPtr_RPC_AIWhistle_Protected_Void_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671274);
		WarPlayerScript.NativeMethodInfoPtr_EnableDebugInvincibility_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671275);
		WarPlayerScript.NativeMethodInfoPtr_ToggleDebugTargetability_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671276);
		WarPlayerScript.NativeMethodInfoPtr_InflictDamageToSelf_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671277);
		WarPlayerScript.NativeMethodInfoPtr_UpdateEditorHotkeys_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671278);
		WarPlayerScript.NativeMethodInfoPtr_UpdateGeneralHotkeys_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671279);
		WarPlayerScript.NativeMethodInfoPtr_GetDebugLookObject_Protected_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671280);
		WarPlayerScript.NativeMethodInfoPtr_GetSurvivalScore_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671281);
		WarPlayerScript.NativeMethodInfoPtr_GetSurvivalMultiplier_Public_Static_Single_Faction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671282);
		WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableDPInInUnique_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671283);
		WarPlayerScript.NativeMethodInfoPtr_RPC_ApplyTaserDamage_Public_Void_ArrayOf_DPIPlayer_DPIPlayer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671284);
		WarPlayerScript.NativeMethodInfoPtr_RPC_ApplyTaserDamage_Public_Void_DPIPlayer_DPIPlayer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671285);
		WarPlayerScript.NativeMethodInfoPtr_RPC_ApplyTaserDamage_Public_Void_RpcTarget_DPIPlayer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671286);
		WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInUnique_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671287);
		WarPlayerScript.NativeMethodInfoPtr_RPC_Heal_Public_Void_ArrayOf_DPIPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671288);
		WarPlayerScript.NativeMethodInfoPtr_RPC_Heal_Public_Void_DPIPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671289);
		WarPlayerScript.NativeMethodInfoPtr_RPC_Heal_Public_Void_RpcTarget_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671290);
		WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671291);
		WarPlayerScript.NativeMethodInfoPtr_RPC_HealRemote_Public_Void_ArrayOf_DPIPlayer_Int32_Int32_Boolean_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671292);
		WarPlayerScript.NativeMethodInfoPtr_RPC_HealRemote_Public_Void_DPIPlayer_Int32_Int32_Boolean_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671293);
		WarPlayerScript.NativeMethodInfoPtr_RPC_HealRemote_Public_Void_RpcTarget_Int32_Int32_Boolean_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671294);
		WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableSiUnique_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671295);
		WarPlayerScript.NativeMethodInfoPtr_RPC_SetArmorHP_Public_Void_ArrayOf_DPIPlayer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671296);
		WarPlayerScript.NativeMethodInfoPtr_RPC_SetArmorHP_Public_Void_DPIPlayer_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671297);
		WarPlayerScript.NativeMethodInfoPtr_RPC_SetArmorHP_Public_Void_RpcTarget_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671298);
		WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671299);
		WarPlayerScript.NativeMethodInfoPtr_RPC_SetHP_Public_Void_ArrayOf_DPIPlayer_Single_DPIPlayer_Int32_Vector3_Vector3_Boolean_Int32_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671300);
		WarPlayerScript.NativeMethodInfoPtr_RPC_SetHP_Public_Void_DPIPlayer_Single_DPIPlayer_Int32_Vector3_Vector3_Boolean_Int32_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671301);
		WarPlayerScript.NativeMethodInfoPtr_RPC_SetHP_Public_Void_RpcTarget_Single_DPIPlayer_Int32_Vector3_Vector3_Boolean_Int32_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671302);
		WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableDPUnique_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671303);
		WarPlayerScript.NativeMethodInfoPtr_RPC_UpdateMe_Public_Void_ArrayOf_DPIPlayer_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671304);
		WarPlayerScript.NativeMethodInfoPtr_RPC_UpdateMe_Public_Void_DPIPlayer_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671305);
		WarPlayerScript.NativeMethodInfoPtr_RPC_UpdateMe_Public_Void_RpcTarget_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671306);
		WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671307);
		WarPlayerScript.NativeMethodInfoPtr_RPC_ThisPlayerState_Public_Void_ArrayOf_DPIPlayer_Single_Single_Boolean_Boolean_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671308);
		WarPlayerScript.NativeMethodInfoPtr_RPC_ThisPlayerState_Public_Void_DPIPlayer_Single_Single_Boolean_Boolean_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671309);
		WarPlayerScript.NativeMethodInfoPtr_RPC_ThisPlayerState_Public_Void_RpcTarget_Single_Single_Boolean_Boolean_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671310);
		WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671311);
		WarPlayerScript.NativeMethodInfoPtr_RPC_TinitusMe_Public_Void_ArrayOf_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671312);
		WarPlayerScript.NativeMethodInfoPtr_RPC_TinitusMe_Public_Void_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671313);
		WarPlayerScript.NativeMethodInfoPtr_RPC_TinitusMe_Public_Void_RpcTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671314);
		WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671315);
		WarPlayerScript.NativeMethodInfoPtr_RPC_ManualInvincibility_Public_Void_ArrayOf_DPIPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671316);
		WarPlayerScript.NativeMethodInfoPtr_RPC_ManualInvincibility_Public_Void_DPIPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671317);
		WarPlayerScript.NativeMethodInfoPtr_RPC_ManualInvincibility_Public_Void_RpcTarget_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671318);
		WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671319);
		WarPlayerScript.NativeMethodInfoPtr_RPC_Targetability_Public_Void_ArrayOf_DPIPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671320);
		WarPlayerScript.NativeMethodInfoPtr_RPC_Targetability_Public_Void_DPIPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671321);
		WarPlayerScript.NativeMethodInfoPtr_RPC_Targetability_Public_Void_RpcTarget_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671322);
		WarPlayerScript.NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1_DPINetworkMessageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671323);
		WarPlayerScript.NativeMethodInfoPtr_RPC_AIWhistle_Public_Void_ArrayOf_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671324);
		WarPlayerScript.NativeMethodInfoPtr_RPC_AIWhistle_Public_Void_DPIPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671325);
		WarPlayerScript.NativeMethodInfoPtr_RPC_AIWhistle_Public_Void_RpcTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671326);
		WarPlayerScript.NativeMethodInfoPtr_OnCodeGenInitializeHook_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671327);
		WarPlayerScript.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, 100671328);
	}

	// Token: 0x060063A1 RID: 25505 RVA: 0x00047530 File Offset: 0x00045730
	public WarPlayerScript(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17002326 RID: 8998
	// (get) Token: 0x060063A2 RID: 25506 RVA: 0x00192654 File Offset: 0x00190854
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr));
		}
	}

	// Token: 0x17002327 RID: 8999
	// (get) Token: 0x060063A3 RID: 25507 RVA: 0x00192668 File Offset: 0x00190868
	// (set) Token: 0x060063A4 RID: 25508 RVA: 0x00192686 File Offset: 0x00190886
	public unsafe static int HEALTH_ON_DOWN
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_HEALTH_ON_DOWN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_HEALTH_ON_DOWN, (void*)(&value));
		}
	}

	// Token: 0x17002328 RID: 9000
	// (get) Token: 0x060063A5 RID: 25509 RVA: 0x00192698 File Offset: 0x00190898
	// (set) Token: 0x060063A6 RID: 25510 RVA: 0x001926B6 File Offset: 0x001908B6
	public unsafe static int MAX_HEALTH
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_MAX_HEALTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_MAX_HEALTH, (void*)(&value));
		}
	}

	// Token: 0x17002329 RID: 9001
	// (get) Token: 0x060063A7 RID: 25511 RVA: 0x001926C8 File Offset: 0x001908C8
	// (set) Token: 0x060063A8 RID: 25512 RVA: 0x001926E6 File Offset: 0x001908E6
	public unsafe static int OutlineAlphaMultiplier
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_OutlineAlphaMultiplier, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_OutlineAlphaMultiplier, (void*)(&value));
		}
	}

	// Token: 0x1700232A RID: 9002
	// (get) Token: 0x060063A9 RID: 25513 RVA: 0x001926F8 File Offset: 0x001908F8
	// (set) Token: 0x060063AA RID: 25514 RVA: 0x00192716 File Offset: 0x00190916
	public unsafe static double DOWN_HEAL_COOLDOWN
	{
		get
		{
			double result;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_DOWN_HEAL_COOLDOWN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_DOWN_HEAL_COOLDOWN, (void*)(&value));
		}
	}

	// Token: 0x1700232B RID: 9003
	// (get) Token: 0x060063AB RID: 25515 RVA: 0x00192728 File Offset: 0x00190928
	// (set) Token: 0x060063AC RID: 25516 RVA: 0x00192746 File Offset: 0x00190946
	public unsafe static double DEAD_HEAL_COOLDOWN
	{
		get
		{
			double result;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_DEAD_HEAL_COOLDOWN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_DEAD_HEAL_COOLDOWN, (void*)(&value));
		}
	}

	// Token: 0x1700232C RID: 9004
	// (get) Token: 0x060063AD RID: 25517 RVA: 0x00192758 File Offset: 0x00190958
	// (set) Token: 0x060063AE RID: 25518 RVA: 0x00192783 File Offset: 0x00190983
	public unsafe static List<WarPlayerScript> AllWarPlayers
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_AllWarPlayers, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new List<WarPlayerScript>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_AllWarPlayers, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700232D RID: 9005
	// (get) Token: 0x060063AF RID: 25519 RVA: 0x00192798 File Offset: 0x00190998
	// (set) Token: 0x060063B0 RID: 25520 RVA: 0x001927C3 File Offset: 0x001909C3
	public unsafe static List<WarPlayerScript> AllActiveWarPlayers
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_AllActiveWarPlayers, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new List<WarPlayerScript>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_AllActiveWarPlayers, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700232E RID: 9006
	// (get) Token: 0x060063B1 RID: 25521 RVA: 0x001927D8 File Offset: 0x001909D8
	// (set) Token: 0x060063B2 RID: 25522 RVA: 0x00192803 File Offset: 0x00190A03
	public unsafe static HashSet<WarPlayerScript> AllAliveWarPlayers
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_AllAliveWarPlayers, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new HashSet<WarPlayerScript>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_AllAliveWarPlayers, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700232F RID: 9007
	// (get) Token: 0x060063B3 RID: 25523 RVA: 0x00192818 File Offset: 0x00190A18
	// (set) Token: 0x060063B4 RID: 25524 RVA: 0x00192843 File Offset: 0x00190A43
	public unsafe static WarPlayerScript LocalWarPlayer
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_LocalWarPlayer, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new WarPlayerScript(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_LocalWarPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002330 RID: 9008
	// (get) Token: 0x060063B5 RID: 25525 RVA: 0x00192858 File Offset: 0x00190A58
	// (set) Token: 0x060063B6 RID: 25526 RVA: 0x00192876 File Offset: 0x00190A76
	public unsafe static bool MirroredDamage
	{
		get
		{
			bool result;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_MirroredDamage, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_MirroredDamage, (void*)(&value));
		}
	}

	// Token: 0x17002331 RID: 9009
	// (get) Token: 0x060063B7 RID: 25527 RVA: 0x00192888 File Offset: 0x00190A88
	// (set) Token: 0x060063B8 RID: 25528 RVA: 0x001928B3 File Offset: 0x00190AB3
	public unsafe static WarPlayerScript.PlayerDamaged AnyPlayerHit
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_AnyPlayerHit, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new WarPlayerScript.PlayerDamaged(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_AnyPlayerHit, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002332 RID: 9010
	// (get) Token: 0x060063B9 RID: 25529 RVA: 0x001928C8 File Offset: 0x00190AC8
	// (set) Token: 0x060063BA RID: 25530 RVA: 0x001928F3 File Offset: 0x00190AF3
	public unsafe static WarPlayerScript.PlayerHealedEvent AnyPlayerRessed
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_AnyPlayerRessed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new WarPlayerScript.PlayerHealedEvent(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_AnyPlayerRessed, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002333 RID: 9011
	// (get) Token: 0x060063BB RID: 25531 RVA: 0x00192908 File Offset: 0x00190B08
	// (set) Token: 0x060063BC RID: 25532 RVA: 0x00192933 File Offset: 0x00190B33
	public unsafe static WarPlayerScript.OtherPlayerEvent AnyPlayerHacked
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_AnyPlayerHacked, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new WarPlayerScript.OtherPlayerEvent(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_AnyPlayerHacked, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002334 RID: 9012
	// (get) Token: 0x060063BD RID: 25533 RVA: 0x00192948 File Offset: 0x00190B48
	// (set) Token: 0x060063BE RID: 25534 RVA: 0x00192973 File Offset: 0x00190B73
	public unsafe static WarPlayerScript.OtherPlayerEvent AnyPlayerShooting
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_AnyPlayerShooting, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new WarPlayerScript.OtherPlayerEvent(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_AnyPlayerShooting, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002335 RID: 9013
	// (get) Token: 0x060063BF RID: 25535 RVA: 0x00192988 File Offset: 0x00190B88
	// (set) Token: 0x060063C0 RID: 25536 RVA: 0x001929B3 File Offset: 0x00190BB3
	public unsafe static Action<WarPlayerScript> OnAnyPlayerHealthEvent
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_OnAnyPlayerHealthEvent, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Action<WarPlayerScript>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_OnAnyPlayerHealthEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002336 RID: 9014
	// (get) Token: 0x060063C1 RID: 25537 RVA: 0x001929C8 File Offset: 0x00190BC8
	// (set) Token: 0x060063C2 RID: 25538 RVA: 0x001929F3 File Offset: 0x00190BF3
	public unsafe static WarPlayerScript.AnyPlayerEvent AnyPlayerSpawned
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_AnyPlayerSpawned, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new WarPlayerScript.AnyPlayerEvent(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_AnyPlayerSpawned, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002337 RID: 9015
	// (get) Token: 0x060063C3 RID: 25539 RVA: 0x00192A08 File Offset: 0x00190C08
	// (set) Token: 0x060063C4 RID: 25540 RVA: 0x00192A33 File Offset: 0x00190C33
	public unsafe static WarPlayerScript.SpecificPlayerEvent AnyPlayerUnDowned
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_AnyPlayerUnDowned, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new WarPlayerScript.SpecificPlayerEvent(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_AnyPlayerUnDowned, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002338 RID: 9016
	// (get) Token: 0x060063C5 RID: 25541 RVA: 0x00192A48 File Offset: 0x00190C48
	// (set) Token: 0x060063C6 RID: 25542 RVA: 0x00192A73 File Offset: 0x00190C73
	public unsafe static Action<WarPlayerScript> OnVIPSet
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_OnVIPSet, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Action<WarPlayerScript>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_OnVIPSet, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002339 RID: 9017
	// (get) Token: 0x060063C7 RID: 25543 RVA: 0x00192A88 File Offset: 0x00190C88
	// (set) Token: 0x060063C8 RID: 25544 RVA: 0x00192AB3 File Offset: 0x00190CB3
	public unsafe static Action<WarPlayerScript> OnPlayerStateChanged
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WarPlayerScript.NativeFieldInfoPtr_OnPlayerStateChanged, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Action<WarPlayerScript>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WarPlayerScript.NativeFieldInfoPtr_OnPlayerStateChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700233A RID: 9018
	// (get) Token: 0x060063C9 RID: 25545 RVA: 0x00192AC8 File Offset: 0x00190CC8
	// (set) Token: 0x060063CA RID: 25546 RVA: 0x00192AFC File Offset: 0x00190CFC
	public unsafe WarPlayerScript.PlayerEvent PlayerShooting
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PlayerShooting);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WarPlayerScript.PlayerEvent(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PlayerShooting), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700233B RID: 9019
	// (get) Token: 0x060063CB RID: 25547 RVA: 0x00192B24 File Offset: 0x00190D24
	// (set) Token: 0x060063CC RID: 25548 RVA: 0x00192B58 File Offset: 0x00190D58
	public unsafe WarPlayerScript.PlayerEvent PlayerSpawned
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PlayerSpawned);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WarPlayerScript.PlayerEvent(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PlayerSpawned), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700233C RID: 9020
	// (get) Token: 0x060063CD RID: 25549 RVA: 0x00192B80 File Offset: 0x00190D80
	// (set) Token: 0x060063CE RID: 25550 RVA: 0x00192BB4 File Offset: 0x00190DB4
	public unsafe WarPlayerScript.PlayerEvent PlayerDespawned
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PlayerDespawned);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WarPlayerScript.PlayerEvent(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PlayerDespawned), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700233D RID: 9021
	// (get) Token: 0x060063CF RID: 25551 RVA: 0x00192BDC File Offset: 0x00190DDC
	// (set) Token: 0x060063D0 RID: 25552 RVA: 0x00192C10 File Offset: 0x00190E10
	public unsafe bl_MiniMapItem MiniMapIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_MiniMapIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new bl_MiniMapItem(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_MiniMapIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700233E RID: 9022
	// (get) Token: 0x060063D1 RID: 25553 RVA: 0x00192C38 File Offset: 0x00190E38
	// (set) Token: 0x060063D2 RID: 25554 RVA: 0x00192C6C File Offset: 0x00190E6C
	public unsafe OnwardPhotonPlayer OwningPlayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OwningPlayer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new OnwardPhotonPlayer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OwningPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700233F RID: 9023
	// (get) Token: 0x060063D3 RID: 25555 RVA: 0x00192C94 File Offset: 0x00190E94
	// (set) Token: 0x060063D4 RID: 25556 RVA: 0x00192CC8 File Offset: 0x00190EC8
	public unsafe Action ThisPlayerSpawned
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ThisPlayerSpawned);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Action(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ThisPlayerSpawned), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002340 RID: 9024
	// (get) Token: 0x060063D5 RID: 25557 RVA: 0x00192CF0 File Offset: 0x00190EF0
	// (set) Token: 0x060063D6 RID: 25558 RVA: 0x00192D24 File Offset: 0x00190F24
	public unsafe Action ThisPlayerRevived
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ThisPlayerRevived);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Action(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ThisPlayerRevived), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002341 RID: 9025
	// (get) Token: 0x060063D7 RID: 25559 RVA: 0x00192D4C File Offset: 0x00190F4C
	// (set) Token: 0x060063D8 RID: 25560 RVA: 0x00192D80 File Offset: 0x00190F80
	public unsafe VRCharacterController VRCharacterControllerScript
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VRCharacterControllerScript);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VRCharacterController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VRCharacterControllerScript), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002342 RID: 9026
	// (get) Token: 0x060063D9 RID: 25561 RVA: 0x00192DA8 File Offset: 0x00190FA8
	// (set) Token: 0x060063DA RID: 25562 RVA: 0x00192DDC File Offset: 0x00190FDC
	public unsafe PlayerUIController PlayerUIController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PlayerUIController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new PlayerUIController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PlayerUIController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002343 RID: 9027
	// (get) Token: 0x060063DB RID: 25563 RVA: 0x00192E04 File Offset: 0x00191004
	// (set) Token: 0x060063DC RID: 25564 RVA: 0x00192E38 File Offset: 0x00191038
	public unsafe IkWeightController IkWeightController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_IkWeightController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new IkWeightController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_IkWeightController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002344 RID: 9028
	// (get) Token: 0x060063DD RID: 25565 RVA: 0x00192E60 File Offset: 0x00191060
	// (set) Token: 0x060063DE RID: 25566 RVA: 0x00192E94 File Offset: 0x00191094
	public unsafe VRCameraManager CameraManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_CameraManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VRCameraManager(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_CameraManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002345 RID: 9029
	// (get) Token: 0x060063DF RID: 25567 RVA: 0x00192EBC File Offset: 0x001910BC
	// (set) Token: 0x060063E0 RID: 25568 RVA: 0x00192EF0 File Offset: 0x001910F0
	public unsafe VRAnimatorController VRAnimatorController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VRAnimatorController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VRAnimatorController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VRAnimatorController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002346 RID: 9030
	// (get) Token: 0x060063E1 RID: 25569 RVA: 0x00192F18 File Offset: 0x00191118
	// (set) Token: 0x060063E2 RID: 25570 RVA: 0x00192F4C File Offset: 0x0019114C
	public unsafe HumanInventoryManager m_InventoryManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_m_InventoryManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new HumanInventoryManager(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_m_InventoryManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002347 RID: 9031
	// (get) Token: 0x060063E3 RID: 25571 RVA: 0x00192F74 File Offset: 0x00191174
	// (set) Token: 0x060063E4 RID: 25572 RVA: 0x00192FA8 File Offset: 0x001911A8
	public unsafe AlertData WhistleAlertData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_WhistleAlertData);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AlertData(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_WhistleAlertData), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002348 RID: 9032
	// (get) Token: 0x060063E5 RID: 25573 RVA: 0x00192FD0 File Offset: 0x001911D0
	// (set) Token: 0x060063E6 RID: 25574 RVA: 0x00193004 File Offset: 0x00191204
	public unsafe GameObject playerNameObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_playerNameObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_playerNameObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002349 RID: 9033
	// (get) Token: 0x060063E7 RID: 25575 RVA: 0x0019302C File Offset: 0x0019122C
	// (set) Token: 0x060063E8 RID: 25576 RVA: 0x00193060 File Offset: 0x00191260
	public unsafe TextMeshPro playerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_playerName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new TextMeshPro(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_playerName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700234A RID: 9034
	// (get) Token: 0x060063E9 RID: 25577 RVA: 0x00193088 File Offset: 0x00191288
	// (set) Token: 0x060063EA RID: 25578 RVA: 0x001930B0 File Offset: 0x001912B0
	public unsafe bool isBleeding
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_isBleeding);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_isBleeding)) = value;
		}
	}

	// Token: 0x1700234B RID: 9035
	// (get) Token: 0x060063EB RID: 25579 RVA: 0x001930D4 File Offset: 0x001912D4
	// (set) Token: 0x060063EC RID: 25580 RVA: 0x001930FC File Offset: 0x001912FC
	public unsafe bool IsFirstRoundSpawn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_IsFirstRoundSpawn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_IsFirstRoundSpawn)) = value;
		}
	}

	// Token: 0x1700234C RID: 9036
	// (get) Token: 0x060063ED RID: 25581 RVA: 0x00193120 File Offset: 0x00191320
	// (set) Token: 0x060063EE RID: 25582 RVA: 0x00193148 File Offset: 0x00191348
	public unsafe PlayerState currentState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_currentState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_currentState)) = value;
		}
	}

	// Token: 0x1700234D RID: 9037
	// (get) Token: 0x060063EF RID: 25583 RVA: 0x0019316C File Offset: 0x0019136C
	// (set) Token: 0x060063F0 RID: 25584 RVA: 0x001931A0 File Offset: 0x001913A0
	public unsafe GameObject SuppresionGamObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_SuppresionGamObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_SuppresionGamObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700234E RID: 9038
	// (get) Token: 0x060063F1 RID: 25585 RVA: 0x001931C8 File Offset: 0x001913C8
	// (set) Token: 0x060063F2 RID: 25586 RVA: 0x001931FC File Offset: 0x001913FC
	public unsafe Action<DPIPlayer> OnDownedOrDead
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OnDownedOrDead);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Action<DPIPlayer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OnDownedOrDead), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700234F RID: 9039
	// (get) Token: 0x060063F3 RID: 25587 RVA: 0x00193224 File Offset: 0x00191424
	// (set) Token: 0x060063F4 RID: 25588 RVA: 0x00193258 File Offset: 0x00191458
	public unsafe Action OnIKUpdated
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OnIKUpdated);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Action(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OnIKUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002350 RID: 9040
	// (get) Token: 0x060063F5 RID: 25589 RVA: 0x00193280 File Offset: 0x00191480
	// (set) Token: 0x060063F6 RID: 25590 RVA: 0x001932A8 File Offset: 0x001914A8
	public unsafe SoldierClass MySoldierClass
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_MySoldierClass);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_MySoldierClass)) = value;
		}
	}

	// Token: 0x17002351 RID: 9041
	// (get) Token: 0x060063F7 RID: 25591 RVA: 0x001932CC File Offset: 0x001914CC
	// (set) Token: 0x060063F8 RID: 25592 RVA: 0x00193300 File Offset: 0x00191500
	public unsafe PlayerLoadout playerLoadout
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_playerLoadout);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new PlayerLoadout(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_playerLoadout), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002352 RID: 9042
	// (get) Token: 0x060063F9 RID: 25593 RVA: 0x00193328 File Offset: 0x00191528
	// (set) Token: 0x060063FA RID: 25594 RVA: 0x00193350 File Offset: 0x00191550
	public unsafe bool isBeingSpectated
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_isBeingSpectated);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_isBeingSpectated)) = value;
		}
	}

	// Token: 0x17002353 RID: 9043
	// (get) Token: 0x060063FB RID: 25595 RVA: 0x00193374 File Offset: 0x00191574
	// (set) Token: 0x060063FC RID: 25596 RVA: 0x0019339C File Offset: 0x0019159C
	public unsafe float TimeSinceLastSpawn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_TimeSinceLastSpawn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_TimeSinceLastSpawn)) = value;
		}
	}

	// Token: 0x17002354 RID: 9044
	// (get) Token: 0x060063FD RID: 25597 RVA: 0x001933C0 File Offset: 0x001915C0
	// (set) Token: 0x060063FE RID: 25598 RVA: 0x001933E8 File Offset: 0x001915E8
	public unsafe float SpawnAudioImmunityTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_SpawnAudioImmunityTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_SpawnAudioImmunityTime)) = value;
		}
	}

	// Token: 0x17002355 RID: 9045
	// (get) Token: 0x060063FF RID: 25599 RVA: 0x0019340C File Offset: 0x0019160C
	// (set) Token: 0x06006400 RID: 25600 RVA: 0x00193440 File Offset: 0x00191640
	public unsafe DamageController DamageController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_DamageController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new DamageController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_DamageController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002356 RID: 9046
	// (get) Token: 0x06006401 RID: 25601 RVA: 0x00193468 File Offset: 0x00191668
	// (set) Token: 0x06006402 RID: 25602 RVA: 0x0019349C File Offset: 0x0019169C
	public unsafe NightVision NightVision
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_NightVision);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new NightVision(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_NightVision), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002357 RID: 9047
	// (get) Token: 0x06006403 RID: 25603 RVA: 0x001934C4 File Offset: 0x001916C4
	// (set) Token: 0x06006404 RID: 25604 RVA: 0x001934EC File Offset: 0x001916EC
	public unsafe float CurrentArmorHealth
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_CurrentArmorHealth);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_CurrentArmorHealth)) = value;
		}
	}

	// Token: 0x17002358 RID: 9048
	// (get) Token: 0x06006405 RID: 25605 RVA: 0x00193510 File Offset: 0x00191710
	// (set) Token: 0x06006406 RID: 25606 RVA: 0x00193538 File Offset: 0x00191738
	public unsafe bool Dead
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_Dead);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_Dead)) = value;
		}
	}

	// Token: 0x17002359 RID: 9049
	// (get) Token: 0x06006407 RID: 25607 RVA: 0x0019355C File Offset: 0x0019175C
	// (set) Token: 0x06006408 RID: 25608 RVA: 0x00193584 File Offset: 0x00191784
	public unsafe bool Spawned
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_Spawned);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_Spawned)) = value;
		}
	}

	// Token: 0x1700235A RID: 9050
	// (get) Token: 0x06006409 RID: 25609 RVA: 0x001935A8 File Offset: 0x001917A8
	// (set) Token: 0x0600640A RID: 25610 RVA: 0x001935D0 File Offset: 0x001917D0
	public unsafe bool HasQuitToTent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_HasQuitToTent);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_HasQuitToTent)) = value;
		}
	}

	// Token: 0x1700235B RID: 9051
	// (get) Token: 0x0600640B RID: 25611 RVA: 0x001935F4 File Offset: 0x001917F4
	// (set) Token: 0x0600640C RID: 25612 RVA: 0x0019361C File Offset: 0x0019181C
	public unsafe bool Flashed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_Flashed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_Flashed)) = value;
		}
	}

	// Token: 0x1700235C RID: 9052
	// (get) Token: 0x0600640D RID: 25613 RVA: 0x00193640 File Offset: 0x00191840
	// (set) Token: 0x0600640E RID: 25614 RVA: 0x00193674 File Offset: 0x00191874
	public unsafe Light NVLight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_NVLight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Light(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_NVLight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700235D RID: 9053
	// (get) Token: 0x0600640F RID: 25615 RVA: 0x0019369C File Offset: 0x0019189C
	// (set) Token: 0x06006410 RID: 25616 RVA: 0x001936C4 File Offset: 0x001918C4
	public unsafe bool ragdollSet
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ragdollSet);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ragdollSet)) = value;
		}
	}

	// Token: 0x1700235E RID: 9054
	// (get) Token: 0x06006411 RID: 25617 RVA: 0x001936E8 File Offset: 0x001918E8
	// (set) Token: 0x06006412 RID: 25618 RVA: 0x0019371C File Offset: 0x0019191C
	public unsafe TinitusMaster TinitusEars
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_TinitusEars);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new TinitusMaster(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_TinitusEars), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700235F RID: 9055
	// (get) Token: 0x06006413 RID: 25619 RVA: 0x00193744 File Offset: 0x00191944
	// (set) Token: 0x06006414 RID: 25620 RVA: 0x0019376C File Offset: 0x0019196C
	public unsafe bool Tinitused
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_Tinitused);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_Tinitused)) = value;
		}
	}

	// Token: 0x17002360 RID: 9056
	// (get) Token: 0x06006415 RID: 25621 RVA: 0x00193790 File Offset: 0x00191990
	// (set) Token: 0x06006416 RID: 25622 RVA: 0x001937B8 File Offset: 0x001919B8
	public unsafe bool Counted
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_Counted);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_Counted)) = value;
		}
	}

	// Token: 0x17002361 RID: 9057
	// (get) Token: 0x06006417 RID: 25623 RVA: 0x001937DC File Offset: 0x001919DC
	// (set) Token: 0x06006418 RID: 25624 RVA: 0x00193804 File Offset: 0x00191A04
	public unsafe bool isEscortVIP
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_isEscortVIP);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_isEscortVIP)) = value;
		}
	}

	// Token: 0x17002362 RID: 9058
	// (get) Token: 0x06006419 RID: 25625 RVA: 0x00193828 File Offset: 0x00191A28
	// (set) Token: 0x0600641A RID: 25626 RVA: 0x0019385C File Offset: 0x00191A5C
	public unsafe Sprite VIPthem
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VIPthem);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Sprite(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VIPthem), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002363 RID: 9059
	// (get) Token: 0x0600641B RID: 25627 RVA: 0x00193884 File Offset: 0x00191A84
	// (set) Token: 0x0600641C RID: 25628 RVA: 0x001938B8 File Offset: 0x00191AB8
	public unsafe GameObject leftWatch
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_leftWatch);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_leftWatch), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002364 RID: 9060
	// (get) Token: 0x0600641D RID: 25629 RVA: 0x001938E0 File Offset: 0x00191AE0
	// (set) Token: 0x0600641E RID: 25630 RVA: 0x00193914 File Offset: 0x00191B14
	public unsafe GameObject rightWatch
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_rightWatch);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_rightWatch), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002365 RID: 9061
	// (get) Token: 0x0600641F RID: 25631 RVA: 0x0019393C File Offset: 0x00191B3C
	// (set) Token: 0x06006420 RID: 25632 RVA: 0x00193970 File Offset: 0x00191B70
	public unsafe Il2CppReferenceArray<WristWatch> WristWatchScripts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_WristWatchScripts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<WristWatch>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_WristWatchScripts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002366 RID: 9062
	// (get) Token: 0x06006421 RID: 25633 RVA: 0x00193998 File Offset: 0x00191B98
	// (set) Token: 0x06006422 RID: 25634 RVA: 0x001939CC File Offset: 0x00191BCC
	public unsafe PainScream PainScreams
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PainScreams);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new PainScream(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PainScreams), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002367 RID: 9063
	// (get) Token: 0x06006423 RID: 25635 RVA: 0x001939F4 File Offset: 0x00191BF4
	// (set) Token: 0x06006424 RID: 25636 RVA: 0x00193A28 File Offset: 0x00191C28
	public unsafe RadioEffectPlayer VestRadio
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VestRadio);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RadioEffectPlayer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VestRadio), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002368 RID: 9064
	// (get) Token: 0x06006425 RID: 25637 RVA: 0x00193A50 File Offset: 0x00191C50
	// (set) Token: 0x06006426 RID: 25638 RVA: 0x00193A84 File Offset: 0x00191C84
	public unsafe Transform RadioHolder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_RadioHolder);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_RadioHolder), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002369 RID: 9065
	// (get) Token: 0x06006427 RID: 25639 RVA: 0x00193AAC File Offset: 0x00191CAC
	// (set) Token: 0x06006428 RID: 25640 RVA: 0x00193AE0 File Offset: 0x00191CE0
	public unsafe DPIVoiceView VoiceView
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VoiceView);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new DPIVoiceView(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VoiceView), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700236A RID: 9066
	// (get) Token: 0x06006429 RID: 25641 RVA: 0x00193B08 File Offset: 0x00191D08
	// (set) Token: 0x0600642A RID: 25642 RVA: 0x00193B3C File Offset: 0x00191D3C
	public unsafe Camera FPSpectateCamera
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_FPSpectateCamera);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Camera(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_FPSpectateCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700236B RID: 9067
	// (get) Token: 0x0600642B RID: 25643 RVA: 0x00193B64 File Offset: 0x00191D64
	// (set) Token: 0x0600642C RID: 25644 RVA: 0x00193B98 File Offset: 0x00191D98
	public unsafe Camera TPSpectateCamera
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_TPSpectateCamera);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Camera(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_TPSpectateCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700236C RID: 9068
	// (get) Token: 0x0600642D RID: 25645 RVA: 0x00193BC0 File Offset: 0x00191DC0
	// (set) Token: 0x0600642E RID: 25646 RVA: 0x00193BF4 File Offset: 0x00191DF4
	public unsafe Camera ActiveSpectateCamera
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ActiveSpectateCamera);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Camera(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ActiveSpectateCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700236D RID: 9069
	// (get) Token: 0x0600642F RID: 25647 RVA: 0x00193C1C File Offset: 0x00191E1C
	// (set) Token: 0x06006430 RID: 25648 RVA: 0x00193C44 File Offset: 0x00191E44
	public unsafe bool hasInitSpectateCamera
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_hasInitSpectateCamera);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_hasInitSpectateCamera)) = value;
		}
	}

	// Token: 0x1700236E RID: 9070
	// (get) Token: 0x06006431 RID: 25649 RVA: 0x00193C68 File Offset: 0x00191E68
	// (set) Token: 0x06006432 RID: 25650 RVA: 0x00193C90 File Offset: 0x00191E90
	public unsafe float spectateAspectRatio
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_spectateAspectRatio);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_spectateAspectRatio)) = value;
		}
	}

	// Token: 0x1700236F RID: 9071
	// (get) Token: 0x06006433 RID: 25651 RVA: 0x00193CB4 File Offset: 0x00191EB4
	// (set) Token: 0x06006434 RID: 25652 RVA: 0x00193CE8 File Offset: 0x00191EE8
	public unsafe MasterVisualEffects MasterVisualEffectsOBJ
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_MasterVisualEffectsOBJ);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new MasterVisualEffects(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_MasterVisualEffectsOBJ), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002370 RID: 9072
	// (get) Token: 0x06006435 RID: 25653 RVA: 0x00193D10 File Offset: 0x00191F10
	// (set) Token: 0x06006436 RID: 25654 RVA: 0x00193D44 File Offset: 0x00191F44
	public unsafe IKNetworkSync networkSync
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_networkSync);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new IKNetworkSync(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_networkSync), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002371 RID: 9073
	// (get) Token: 0x06006437 RID: 25655 RVA: 0x00193D6C File Offset: 0x00191F6C
	// (set) Token: 0x06006438 RID: 25656 RVA: 0x00193DA0 File Offset: 0x00191FA0
	public unsafe RagdollUtility ragdollUtility
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ragdollUtility);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RagdollUtility(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ragdollUtility), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002372 RID: 9074
	// (get) Token: 0x06006439 RID: 25657 RVA: 0x00193DC8 File Offset: 0x00191FC8
	// (set) Token: 0x0600643A RID: 25658 RVA: 0x00193DFC File Offset: 0x00191FFC
	public unsafe GameObject HeadEffector
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_HeadEffector);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_HeadEffector), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002373 RID: 9075
	// (get) Token: 0x0600643B RID: 25659 RVA: 0x00193E24 File Offset: 0x00192024
	// (set) Token: 0x0600643C RID: 25660 RVA: 0x00193E58 File Offset: 0x00192058
	public unsafe PlayerRendererCache NetworkHat
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_NetworkHat);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new PlayerRendererCache(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_NetworkHat), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002374 RID: 9076
	// (get) Token: 0x0600643D RID: 25661 RVA: 0x00193E80 File Offset: 0x00192080
	// (set) Token: 0x0600643E RID: 25662 RVA: 0x00193EB4 File Offset: 0x001920B4
	public unsafe OnwardPhotonPlayer OtherPlayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OtherPlayer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new OnwardPhotonPlayer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OtherPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002375 RID: 9077
	// (get) Token: 0x0600643F RID: 25663 RVA: 0x00193EDC File Offset: 0x001920DC
	// (set) Token: 0x06006440 RID: 25664 RVA: 0x00193F04 File Offset: 0x00192104
	public unsafe DamageType LastDamageType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LastDamageType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LastDamageType)) = value;
		}
	}

	// Token: 0x17002376 RID: 9078
	// (get) Token: 0x06006441 RID: 25665 RVA: 0x00193F28 File Offset: 0x00192128
	// (set) Token: 0x06006442 RID: 25666 RVA: 0x00193F50 File Offset: 0x00192150
	public unsafe DamageType LastDamageTypeBeforeSuicide
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LastDamageTypeBeforeSuicide);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LastDamageTypeBeforeSuicide)) = value;
		}
	}

	// Token: 0x17002377 RID: 9079
	// (get) Token: 0x06006443 RID: 25667 RVA: 0x00193F74 File Offset: 0x00192174
	// (set) Token: 0x06006444 RID: 25668 RVA: 0x00193F9C File Offset: 0x0019219C
	public unsafe WeaponName LastWeaponHitBeforeSuicide
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LastWeaponHitBeforeSuicide);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LastWeaponHitBeforeSuicide)) = value;
		}
	}

	// Token: 0x17002378 RID: 9080
	// (get) Token: 0x06006445 RID: 25669 RVA: 0x00193FC0 File Offset: 0x001921C0
	// (set) Token: 0x06006446 RID: 25670 RVA: 0x00193FE8 File Offset: 0x001921E8
	public unsafe WeaponName LastWeaponFired
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LastWeaponFired);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LastWeaponFired)) = value;
		}
	}

	// Token: 0x17002379 RID: 9081
	// (get) Token: 0x06006447 RID: 25671 RVA: 0x0019400C File Offset: 0x0019220C
	// (set) Token: 0x06006448 RID: 25672 RVA: 0x00194035 File Offset: 0x00192235
	public unsafe string OtherAIPlayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OtherAIPlayer);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OtherAIPlayer), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700237A RID: 9082
	// (get) Token: 0x06006449 RID: 25673 RVA: 0x0019405C File Offset: 0x0019225C
	// (set) Token: 0x0600644A RID: 25674 RVA: 0x00194084 File Offset: 0x00192284
	public unsafe int OtherAIPlayerID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OtherAIPlayerID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OtherAIPlayerID)) = value;
		}
	}

	// Token: 0x1700237B RID: 9083
	// (get) Token: 0x0600644B RID: 25675 RVA: 0x001940A8 File Offset: 0x001922A8
	// (set) Token: 0x0600644C RID: 25676 RVA: 0x001940DC File Offset: 0x001922DC
	public unsafe VRIK ik
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ik);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VRIK(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ik), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700237C RID: 9084
	// (get) Token: 0x0600644D RID: 25677 RVA: 0x00194104 File Offset: 0x00192304
	// (set) Token: 0x0600644E RID: 25678 RVA: 0x0019412C File Offset: 0x0019232C
	public unsafe Vector3 PlayerRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PlayerRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PlayerRotation)) = value;
		}
	}

	// Token: 0x1700237D RID: 9085
	// (get) Token: 0x0600644F RID: 25679 RVA: 0x00194150 File Offset: 0x00192350
	// (set) Token: 0x06006450 RID: 25680 RVA: 0x00194184 File Offset: 0x00192384
	public unsafe SpectateOutline Outline
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_Outline);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new SpectateOutline(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_Outline), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700237E RID: 9086
	// (get) Token: 0x06006451 RID: 25681 RVA: 0x001941AC File Offset: 0x001923AC
	// (set) Token: 0x06006452 RID: 25682 RVA: 0x001941E0 File Offset: 0x001923E0
	public unsafe VisualLoader VisualLoader
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VisualLoader);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VisualLoader(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VisualLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700237F RID: 9087
	// (get) Token: 0x06006453 RID: 25683 RVA: 0x00194208 File Offset: 0x00192408
	// (set) Token: 0x06006454 RID: 25684 RVA: 0x0019423C File Offset: 0x0019243C
	public unsafe Il2CppReferenceArray<GameObject> DisableWhenDowned
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_DisableWhenDowned);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_DisableWhenDowned), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002380 RID: 9088
	// (get) Token: 0x06006455 RID: 25685 RVA: 0x00194264 File Offset: 0x00192464
	// (set) Token: 0x06006456 RID: 25686 RVA: 0x00194298 File Offset: 0x00192498
	public unsafe LineRenderer DamageLine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_DamageLine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new LineRenderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_DamageLine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002381 RID: 9089
	// (get) Token: 0x06006457 RID: 25687 RVA: 0x001942C0 File Offset: 0x001924C0
	// (set) Token: 0x06006458 RID: 25688 RVA: 0x001942F4 File Offset: 0x001924F4
	public unsafe VestPouchVisibility PouchVisibility
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PouchVisibility);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VestPouchVisibility(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_PouchVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002382 RID: 9090
	// (get) Token: 0x06006459 RID: 25689 RVA: 0x0019431C File Offset: 0x0019251C
	// (set) Token: 0x0600645A RID: 25690 RVA: 0x00194350 File Offset: 0x00192550
	public unsafe GameObject SightOrigin
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_SightOrigin);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_SightOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002383 RID: 9091
	// (get) Token: 0x0600645B RID: 25691 RVA: 0x00194378 File Offset: 0x00192578
	// (set) Token: 0x0600645C RID: 25692 RVA: 0x001943AC File Offset: 0x001925AC
	public unsafe MeshRenderer FakeGuyLodMeshRenderer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_FakeGuyLodMeshRenderer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new MeshRenderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_FakeGuyLodMeshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002384 RID: 9092
	// (get) Token: 0x0600645D RID: 25693 RVA: 0x001943D4 File Offset: 0x001925D4
	// (set) Token: 0x0600645E RID: 25694 RVA: 0x00194408 File Offset: 0x00192608
	public unsafe SkeletonManager SkeletonManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_SkeletonManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new SkeletonManager(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_SkeletonManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002385 RID: 9093
	// (get) Token: 0x0600645F RID: 25695 RVA: 0x00194430 File Offset: 0x00192630
	// (set) Token: 0x06006460 RID: 25696 RVA: 0x00194464 File Offset: 0x00192664
	public unsafe UplinkDetectorCollider UplinkDetectorCollider
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_UplinkDetectorCollider);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new UplinkDetectorCollider(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_UplinkDetectorCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002386 RID: 9094
	// (get) Token: 0x06006461 RID: 25697 RVA: 0x0019448C File Offset: 0x0019268C
	// (set) Token: 0x06006462 RID: 25698 RVA: 0x001944C0 File Offset: 0x001926C0
	public unsafe PlayerVisionTarget VisionTarget
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VisionTarget);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new PlayerVisionTarget(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VisionTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002387 RID: 9095
	// (get) Token: 0x06006463 RID: 25699 RVA: 0x001944E8 File Offset: 0x001926E8
	// (set) Token: 0x06006464 RID: 25700 RVA: 0x0019451C File Offset: 0x0019271C
	public unsafe GearManager GearManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_GearManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GearManager(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_GearManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002388 RID: 9096
	// (get) Token: 0x06006465 RID: 25701 RVA: 0x00194544 File Offset: 0x00192744
	// (set) Token: 0x06006466 RID: 25702 RVA: 0x00194578 File Offset: 0x00192778
	public unsafe PlayerRendererCache SFBigBag
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_SFBigBag);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new PlayerRendererCache(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_SFBigBag), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002389 RID: 9097
	// (get) Token: 0x06006467 RID: 25703 RVA: 0x001945A0 File Offset: 0x001927A0
	// (set) Token: 0x06006468 RID: 25704 RVA: 0x001945D4 File Offset: 0x001927D4
	public unsafe PlayerRendererCache SFSmallBag
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_SFSmallBag);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new PlayerRendererCache(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_SFSmallBag), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700238A RID: 9098
	// (get) Token: 0x06006469 RID: 25705 RVA: 0x001945FC File Offset: 0x001927FC
	// (set) Token: 0x0600646A RID: 25706 RVA: 0x00194630 File Offset: 0x00192830
	public unsafe PlayerRendererCache MiniBag
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_MiniBag);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new PlayerRendererCache(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_MiniBag), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700238B RID: 9099
	// (get) Token: 0x0600646B RID: 25707 RVA: 0x00194658 File Offset: 0x00192858
	// (set) Token: 0x0600646C RID: 25708 RVA: 0x0019468C File Offset: 0x0019288C
	public unsafe List<WarPlayerScript.DeviceGloveSettings> MarsocGloves
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_MarsocGloves);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<WarPlayerScript.DeviceGloveSettings>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_MarsocGloves), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700238C RID: 9100
	// (get) Token: 0x0600646D RID: 25709 RVA: 0x001946B4 File Offset: 0x001928B4
	// (set) Token: 0x0600646E RID: 25710 RVA: 0x001946E8 File Offset: 0x001928E8
	public unsafe PlayerRendererCache OSBag
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OSBag);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new PlayerRendererCache(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_OSBag), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700238D RID: 9101
	// (get) Token: 0x0600646F RID: 25711 RVA: 0x00194710 File Offset: 0x00192910
	// (set) Token: 0x06006470 RID: 25712 RVA: 0x00194744 File Offset: 0x00192944
	public unsafe List<WarPlayerScript.DeviceGloveSettings> VolkGloves
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VolkGloves);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<WarPlayerScript.DeviceGloveSettings>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VolkGloves), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700238E RID: 9102
	// (get) Token: 0x06006471 RID: 25713 RVA: 0x0019476C File Offset: 0x0019296C
	// (set) Token: 0x06006472 RID: 25714 RVA: 0x001947A0 File Offset: 0x001929A0
	public unsafe List<FakePickupLight> FakeLights
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_FakeLights);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<FakePickupLight>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_FakeLights), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700238F RID: 9103
	// (get) Token: 0x06006473 RID: 25715 RVA: 0x001947C8 File Offset: 0x001929C8
	// (set) Token: 0x06006474 RID: 25716 RVA: 0x001947FC File Offset: 0x001929FC
	public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> LocalHandsMesh
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LocalHandsMesh);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<SkinnedMeshRenderer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LocalHandsMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002390 RID: 9104
	// (get) Token: 0x06006475 RID: 25717 RVA: 0x00194824 File Offset: 0x00192A24
	// (set) Token: 0x06006476 RID: 25718 RVA: 0x00194858 File Offset: 0x00192A58
	public unsafe GameObject LocalVest
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LocalVest);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LocalVest), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002391 RID: 9105
	// (get) Token: 0x06006477 RID: 25719 RVA: 0x00194880 File Offset: 0x00192A80
	// (set) Token: 0x06006478 RID: 25720 RVA: 0x001948B4 File Offset: 0x00192AB4
	public unsafe GameObject VestDisabledOnDeadOrDowned
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VestDisabledOnDeadOrDowned);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VestDisabledOnDeadOrDowned), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002392 RID: 9106
	// (get) Token: 0x06006479 RID: 25721 RVA: 0x001948DC File Offset: 0x00192ADC
	// (set) Token: 0x0600647A RID: 25722 RVA: 0x00194910 File Offset: 0x00192B10
	public unsafe GameObject VestDisabledOnDead
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VestDisabledOnDead);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VestDisabledOnDead), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002393 RID: 9107
	// (get) Token: 0x0600647B RID: 25723 RVA: 0x00194938 File Offset: 0x00192B38
	// (set) Token: 0x0600647C RID: 25724 RVA: 0x0019496C File Offset: 0x00192B6C
	public unsafe Renderer LocalVestRenderer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LocalVestRenderer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Renderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LocalVestRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002394 RID: 9108
	// (get) Token: 0x0600647D RID: 25725 RVA: 0x00194994 File Offset: 0x00192B94
	// (set) Token: 0x0600647E RID: 25726 RVA: 0x001949C8 File Offset: 0x00192BC8
	public unsafe Il2CppReferenceArray<Collider> BodyColliders
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_BodyColliders);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<Collider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_BodyColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002395 RID: 9109
	// (get) Token: 0x0600647F RID: 25727 RVA: 0x001949F0 File Offset: 0x00192BF0
	// (set) Token: 0x06006480 RID: 25728 RVA: 0x00194A24 File Offset: 0x00192C24
	public unsafe Il2CppReferenceArray<Collider> LocalBodyColliders
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LocalBodyColliders);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<Collider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LocalBodyColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002396 RID: 9110
	// (get) Token: 0x06006481 RID: 25729 RVA: 0x00194A4C File Offset: 0x00192C4C
	// (set) Token: 0x06006482 RID: 25730 RVA: 0x00194A80 File Offset: 0x00192C80
	public unsafe RagdollController ragdollController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ragdollController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new RagdollController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ragdollController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002397 RID: 9111
	// (get) Token: 0x06006483 RID: 25731 RVA: 0x00194AA8 File Offset: 0x00192CA8
	// (set) Token: 0x06006484 RID: 25732 RVA: 0x00194ADC File Offset: 0x00192CDC
	public unsafe GameObject NetworkBreath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_NetworkBreath);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_NetworkBreath), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002398 RID: 9112
	// (get) Token: 0x06006485 RID: 25733 RVA: 0x00194B04 File Offset: 0x00192D04
	// (set) Token: 0x06006486 RID: 25734 RVA: 0x00194B38 File Offset: 0x00192D38
	public unsafe Transform NetworkBreathPos
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_NetworkBreathPos);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_NetworkBreathPos), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002399 RID: 9113
	// (get) Token: 0x06006487 RID: 25735 RVA: 0x00194B60 File Offset: 0x00192D60
	// (set) Token: 0x06006488 RID: 25736 RVA: 0x00194B94 File Offset: 0x00192D94
	public unsafe GameObject LocalBreath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LocalBreath);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_LocalBreath), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700239A RID: 9114
	// (get) Token: 0x06006489 RID: 25737 RVA: 0x00194BBC File Offset: 0x00192DBC
	// (set) Token: 0x0600648A RID: 25738 RVA: 0x00194BF0 File Offset: 0x00192DF0
	public unsafe Transform VoicePosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VoicePosition);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_VoicePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700239B RID: 9115
	// (get) Token: 0x0600648B RID: 25739 RVA: 0x00194C18 File Offset: 0x00192E18
	// (set) Token: 0x0600648C RID: 25740 RVA: 0x00194C4C File Offset: 0x00192E4C
	public unsafe Nightvision FPPostProcess
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_FPPostProcess);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Nightvision(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_FPPostProcess), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700239C RID: 9116
	// (get) Token: 0x0600648D RID: 25741 RVA: 0x00194C74 File Offset: 0x00192E74
	// (set) Token: 0x0600648E RID: 25742 RVA: 0x00194CA8 File Offset: 0x00192EA8
	public unsafe Light FPLight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_FPLight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Light(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_FPLight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700239D RID: 9117
	// (get) Token: 0x0600648F RID: 25743 RVA: 0x00194CD0 File Offset: 0x00192ED0
	// (set) Token: 0x06006490 RID: 25744 RVA: 0x00194D04 File Offset: 0x00192F04
	public unsafe Nightvision TPPostProcess
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_TPPostProcess);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Nightvision(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_TPPostProcess), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700239E RID: 9118
	// (get) Token: 0x06006491 RID: 25745 RVA: 0x00194D2C File Offset: 0x00192F2C
	// (set) Token: 0x06006492 RID: 25746 RVA: 0x00194D60 File Offset: 0x00192F60
	public unsafe Light TPLight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_TPLight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Light(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_TPLight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700239F RID: 9119
	// (get) Token: 0x06006493 RID: 25747 RVA: 0x00194D88 File Offset: 0x00192F88
	// (set) Token: 0x06006494 RID: 25748 RVA: 0x00194DBC File Offset: 0x00192FBC
	public unsafe Il2CppReferenceArray<DamageBody> ArmorObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ArmorObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<DamageBody>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ArmorObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023A0 RID: 9120
	// (get) Token: 0x06006495 RID: 25749 RVA: 0x00194DE4 File Offset: 0x00192FE4
	// (set) Token: 0x06006496 RID: 25750 RVA: 0x00194E18 File Offset: 0x00193018
	public unsafe DPIPlayer _TeammateWhoDownedMe_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__TeammateWhoDownedMe_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new DPIPlayer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__TeammateWhoDownedMe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023A1 RID: 9121
	// (get) Token: 0x06006497 RID: 25751 RVA: 0x00194E40 File Offset: 0x00193040
	// (set) Token: 0x06006498 RID: 25752 RVA: 0x00194E68 File Offset: 0x00193068
	public unsafe bool _IsInDeathTransition_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__IsInDeathTransition_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__IsInDeathTransition_k__BackingField)) = value;
		}
	}

	// Token: 0x170023A2 RID: 9122
	// (get) Token: 0x06006499 RID: 25753 RVA: 0x00194E8C File Offset: 0x0019308C
	// (set) Token: 0x0600649A RID: 25754 RVA: 0x00194EB4 File Offset: 0x001930B4
	public unsafe float KarmaDialogTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_KarmaDialogTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_KarmaDialogTime)) = value;
		}
	}

	// Token: 0x170023A3 RID: 9123
	// (get) Token: 0x0600649B RID: 25755 RVA: 0x00194ED8 File Offset: 0x001930D8
	// (set) Token: 0x0600649C RID: 25756 RVA: 0x00194F00 File Offset: 0x00193100
	public unsafe bool hasInit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_hasInit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_hasInit)) = value;
		}
	}

	// Token: 0x170023A4 RID: 9124
	// (get) Token: 0x0600649D RID: 25757 RVA: 0x00194F24 File Offset: 0x00193124
	// (set) Token: 0x0600649E RID: 25758 RVA: 0x00194F4C File Offset: 0x0019314C
	public unsafe float lastPainSound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_lastPainSound);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_lastPainSound)) = value;
		}
	}

	// Token: 0x170023A5 RID: 9125
	// (get) Token: 0x0600649F RID: 25759 RVA: 0x00194F70 File Offset: 0x00193170
	// (set) Token: 0x060064A0 RID: 25760 RVA: 0x00194F98 File Offset: 0x00193198
	public unsafe float timeBetweenPainSounds
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_timeBetweenPainSounds);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_timeBetweenPainSounds)) = value;
		}
	}

	// Token: 0x170023A6 RID: 9126
	// (get) Token: 0x060064A1 RID: 25761 RVA: 0x00194FBC File Offset: 0x001931BC
	// (set) Token: 0x060064A2 RID: 25762 RVA: 0x00194FF0 File Offset: 0x001931F0
	public unsafe ShadowToggler ShadowToggler
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ShadowToggler);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new ShadowToggler(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_ShadowToggler), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023A7 RID: 9127
	// (get) Token: 0x060064A3 RID: 25763 RVA: 0x00195018 File Offset: 0x00193218
	// (set) Token: 0x060064A4 RID: 25764 RVA: 0x00195040 File Offset: 0x00193240
	public unsafe int _watchSetting
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__watchSetting);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__watchSetting)) = value;
		}
	}

	// Token: 0x170023A8 RID: 9128
	// (get) Token: 0x060064A5 RID: 25765 RVA: 0x00195064 File Offset: 0x00193264
	// (set) Token: 0x060064A6 RID: 25766 RVA: 0x00195098 File Offset: 0x00193298
	public unsafe DPIPlayer KillingPlayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_KillingPlayer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new DPIPlayer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_KillingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023A9 RID: 9129
	// (get) Token: 0x060064A7 RID: 25767 RVA: 0x001950C0 File Offset: 0x001932C0
	// (set) Token: 0x060064A8 RID: 25768 RVA: 0x001950F4 File Offset: 0x001932F4
	public unsafe OnwardPhotonPlayer teamKillingPlayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_teamKillingPlayer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new OnwardPhotonPlayer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_teamKillingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023AA RID: 9130
	// (get) Token: 0x060064A9 RID: 25769 RVA: 0x0019511C File Offset: 0x0019331C
	// (set) Token: 0x060064AA RID: 25770 RVA: 0x00195144 File Offset: 0x00193344
	public unsafe Vector3 _DeathPosition_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__DeathPosition_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__DeathPosition_k__BackingField)) = value;
		}
	}

	// Token: 0x170023AB RID: 9131
	// (get) Token: 0x060064AB RID: 25771 RVA: 0x00195168 File Offset: 0x00193368
	// (set) Token: 0x060064AC RID: 25772 RVA: 0x00195190 File Offset: 0x00193390
	public unsafe double _TimeOfLastStateChange_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__TimeOfLastStateChange_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__TimeOfLastStateChange_k__BackingField)) = value;
		}
	}

	// Token: 0x170023AC RID: 9132
	// (get) Token: 0x060064AD RID: 25773 RVA: 0x001951B4 File Offset: 0x001933B4
	// (set) Token: 0x060064AE RID: 25774 RVA: 0x001951E8 File Offset: 0x001933E8
	public unsafe Coroutine BleedOutRoutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_BleedOutRoutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Coroutine(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_BleedOutRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023AD RID: 9133
	// (get) Token: 0x060064AF RID: 25775 RVA: 0x00195210 File Offset: 0x00193410
	// (set) Token: 0x060064B0 RID: 25776 RVA: 0x00195244 File Offset: 0x00193444
	public unsafe Coroutine _deathTransition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__deathTransition);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Coroutine(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__deathTransition), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023AE RID: 9134
	// (get) Token: 0x060064B1 RID: 25777 RVA: 0x0019526C File Offset: 0x0019346C
	// (set) Token: 0x060064B2 RID: 25778 RVA: 0x00195294 File Offset: 0x00193494
	public unsafe bool _ManagedUpdateRemoval_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField)) = value;
		}
	}

	// Token: 0x170023AF RID: 9135
	// (get) Token: 0x060064B3 RID: 25779 RVA: 0x001952B8 File Offset: 0x001934B8
	// (set) Token: 0x060064B4 RID: 25780 RVA: 0x001952EC File Offset: 0x001934EC
	public unsafe EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableDPInInUnique_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableDPInInUnique_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableDPInInUnique_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023B0 RID: 9136
	// (get) Token: 0x060064B5 RID: 25781 RVA: 0x00195314 File Offset: 0x00193514
	// (set) Token: 0x060064B6 RID: 25782 RVA: 0x00195348 File Offset: 0x00193548
	public unsafe EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInUnique_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInUnique_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInUnique_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023B1 RID: 9137
	// (get) Token: 0x060064B7 RID: 25783 RVA: 0x00195370 File Offset: 0x00193570
	// (set) Token: 0x060064B8 RID: 25784 RVA: 0x001953A4 File Offset: 0x001935A4
	public unsafe EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023B2 RID: 9138
	// (get) Token: 0x060064B9 RID: 25785 RVA: 0x001953CC File Offset: 0x001935CC
	// (set) Token: 0x060064BA RID: 25786 RVA: 0x00195400 File Offset: 0x00193600
	public unsafe EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiUnique_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiUnique_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiUnique_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023B3 RID: 9139
	// (get) Token: 0x060064BB RID: 25787 RVA: 0x00195428 File Offset: 0x00193628
	// (set) Token: 0x060064BC RID: 25788 RVA: 0x0019545C File Offset: 0x0019365C
	public unsafe EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023B4 RID: 9140
	// (get) Token: 0x060064BD RID: 25789 RVA: 0x00195484 File Offset: 0x00193684
	// (set) Token: 0x060064BE RID: 25790 RVA: 0x001954B8 File Offset: 0x001936B8
	public unsafe EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableDPUnique_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableDPUnique_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableDPUnique_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023B5 RID: 9141
	// (get) Token: 0x060064BF RID: 25791 RVA: 0x001954E0 File Offset: 0x001936E0
	// (set) Token: 0x060064C0 RID: 25792 RVA: 0x00195514 File Offset: 0x00193714
	public unsafe EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023B6 RID: 9142
	// (get) Token: 0x060064C1 RID: 25793 RVA: 0x0019553C File Offset: 0x0019373C
	// (set) Token: 0x060064C2 RID: 25794 RVA: 0x00195570 File Offset: 0x00193770
	public unsafe EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023B7 RID: 9143
	// (get) Token: 0x060064C3 RID: 25795 RVA: 0x00195598 File Offset: 0x00193798
	// (set) Token: 0x060064C4 RID: 25796 RVA: 0x001955CC File Offset: 0x001937CC
	public unsafe EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023B8 RID: 9144
	// (get) Token: 0x060064C5 RID: 25797 RVA: 0x001955F4 File Offset: 0x001937F4
	// (set) Token: 0x060064C6 RID: 25798 RVA: 0x00195628 File Offset: 0x00193828
	public unsafe EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170023B9 RID: 9145
	// (get) Token: 0x060064C7 RID: 25799 RVA: 0x00195650 File Offset: 0x00193850
	// (set) Token: 0x060064C8 RID: 25800 RVA: 0x00195684 File Offset: 0x00193884
	public unsafe EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1> field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1_0
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1_0);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new EntityClientRpcHandle<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04003E6F RID: 15983
	private static readonly IntPtr NativeFieldInfoPtr_HEALTH_ON_DOWN;

	// Token: 0x04003E70 RID: 15984
	private static readonly IntPtr NativeFieldInfoPtr_MAX_HEALTH;

	// Token: 0x04003E71 RID: 15985
	private static readonly IntPtr NativeFieldInfoPtr_OutlineAlphaMultiplier;

	// Token: 0x04003E72 RID: 15986
	private static readonly IntPtr NativeFieldInfoPtr_DOWN_HEAL_COOLDOWN;

	// Token: 0x04003E73 RID: 15987
	private static readonly IntPtr NativeFieldInfoPtr_DEAD_HEAL_COOLDOWN;

	// Token: 0x04003E74 RID: 15988
	private static readonly IntPtr NativeFieldInfoPtr_AllWarPlayers;

	// Token: 0x04003E75 RID: 15989
	private static readonly IntPtr NativeFieldInfoPtr_AllActiveWarPlayers;

	// Token: 0x04003E76 RID: 15990
	private static readonly IntPtr NativeFieldInfoPtr_AllAliveWarPlayers;

	// Token: 0x04003E77 RID: 15991
	private static readonly IntPtr NativeFieldInfoPtr_LocalWarPlayer;

	// Token: 0x04003E78 RID: 15992
	private static readonly IntPtr NativeFieldInfoPtr_MirroredDamage;

	// Token: 0x04003E79 RID: 15993
	private static readonly IntPtr NativeFieldInfoPtr_AnyPlayerHit;

	// Token: 0x04003E7A RID: 15994
	private static readonly IntPtr NativeFieldInfoPtr_AnyPlayerRessed;

	// Token: 0x04003E7B RID: 15995
	private static readonly IntPtr NativeFieldInfoPtr_AnyPlayerHacked;

	// Token: 0x04003E7C RID: 15996
	private static readonly IntPtr NativeFieldInfoPtr_AnyPlayerShooting;

	// Token: 0x04003E7D RID: 15997
	private static readonly IntPtr NativeFieldInfoPtr_OnAnyPlayerHealthEvent;

	// Token: 0x04003E7E RID: 15998
	private static readonly IntPtr NativeFieldInfoPtr_AnyPlayerSpawned;

	// Token: 0x04003E7F RID: 15999
	private static readonly IntPtr NativeFieldInfoPtr_AnyPlayerUnDowned;

	// Token: 0x04003E80 RID: 16000
	private static readonly IntPtr NativeFieldInfoPtr_OnVIPSet;

	// Token: 0x04003E81 RID: 16001
	private static readonly IntPtr NativeFieldInfoPtr_OnPlayerStateChanged;

	// Token: 0x04003E82 RID: 16002
	private static readonly IntPtr NativeFieldInfoPtr_PlayerShooting;

	// Token: 0x04003E83 RID: 16003
	private static readonly IntPtr NativeFieldInfoPtr_PlayerSpawned;

	// Token: 0x04003E84 RID: 16004
	private static readonly IntPtr NativeFieldInfoPtr_PlayerDespawned;

	// Token: 0x04003E85 RID: 16005
	private static readonly IntPtr NativeFieldInfoPtr_MiniMapIcon;

	// Token: 0x04003E86 RID: 16006
	private static readonly IntPtr NativeFieldInfoPtr_OwningPlayer;

	// Token: 0x04003E87 RID: 16007
	private static readonly IntPtr NativeFieldInfoPtr_ThisPlayerSpawned;

	// Token: 0x04003E88 RID: 16008
	private static readonly IntPtr NativeFieldInfoPtr_ThisPlayerRevived;

	// Token: 0x04003E89 RID: 16009
	private static readonly IntPtr NativeFieldInfoPtr_VRCharacterControllerScript;

	// Token: 0x04003E8A RID: 16010
	private static readonly IntPtr NativeFieldInfoPtr_PlayerUIController;

	// Token: 0x04003E8B RID: 16011
	private static readonly IntPtr NativeFieldInfoPtr_IkWeightController;

	// Token: 0x04003E8C RID: 16012
	private static readonly IntPtr NativeFieldInfoPtr_CameraManager;

	// Token: 0x04003E8D RID: 16013
	private static readonly IntPtr NativeFieldInfoPtr_VRAnimatorController;

	// Token: 0x04003E8E RID: 16014
	private static readonly IntPtr NativeFieldInfoPtr_m_InventoryManager;

	// Token: 0x04003E8F RID: 16015
	private static readonly IntPtr NativeFieldInfoPtr_WhistleAlertData;

	// Token: 0x04003E90 RID: 16016
	private static readonly IntPtr NativeFieldInfoPtr_playerNameObj;

	// Token: 0x04003E91 RID: 16017
	private static readonly IntPtr NativeFieldInfoPtr_playerName;

	// Token: 0x04003E92 RID: 16018
	private static readonly IntPtr NativeFieldInfoPtr_isBleeding;

	// Token: 0x04003E93 RID: 16019
	private static readonly IntPtr NativeFieldInfoPtr_IsFirstRoundSpawn;

	// Token: 0x04003E94 RID: 16020
	private static readonly IntPtr NativeFieldInfoPtr_currentState;

	// Token: 0x04003E95 RID: 16021
	private static readonly IntPtr NativeFieldInfoPtr_SuppresionGamObject;

	// Token: 0x04003E96 RID: 16022
	private static readonly IntPtr NativeFieldInfoPtr_OnDownedOrDead;

	// Token: 0x04003E97 RID: 16023
	private static readonly IntPtr NativeFieldInfoPtr_OnIKUpdated;

	// Token: 0x04003E98 RID: 16024
	private static readonly IntPtr NativeFieldInfoPtr_MySoldierClass;

	// Token: 0x04003E99 RID: 16025
	private static readonly IntPtr NativeFieldInfoPtr_playerLoadout;

	// Token: 0x04003E9A RID: 16026
	private static readonly IntPtr NativeFieldInfoPtr_isBeingSpectated;

	// Token: 0x04003E9B RID: 16027
	private static readonly IntPtr NativeFieldInfoPtr_TimeSinceLastSpawn;

	// Token: 0x04003E9C RID: 16028
	private static readonly IntPtr NativeFieldInfoPtr_SpawnAudioImmunityTime;

	// Token: 0x04003E9D RID: 16029
	private static readonly IntPtr NativeFieldInfoPtr_DamageController;

	// Token: 0x04003E9E RID: 16030
	private static readonly IntPtr NativeFieldInfoPtr_NightVision;

	// Token: 0x04003E9F RID: 16031
	private static readonly IntPtr NativeFieldInfoPtr_CurrentArmorHealth;

	// Token: 0x04003EA0 RID: 16032
	private static readonly IntPtr NativeFieldInfoPtr_Dead;

	// Token: 0x04003EA1 RID: 16033
	private static readonly IntPtr NativeFieldInfoPtr_Spawned;

	// Token: 0x04003EA2 RID: 16034
	private static readonly IntPtr NativeFieldInfoPtr_HasQuitToTent;

	// Token: 0x04003EA3 RID: 16035
	private static readonly IntPtr NativeFieldInfoPtr_Flashed;

	// Token: 0x04003EA4 RID: 16036
	private static readonly IntPtr NativeFieldInfoPtr_NVLight;

	// Token: 0x04003EA5 RID: 16037
	private static readonly IntPtr NativeFieldInfoPtr_ragdollSet;

	// Token: 0x04003EA6 RID: 16038
	private static readonly IntPtr NativeFieldInfoPtr_TinitusEars;

	// Token: 0x04003EA7 RID: 16039
	private static readonly IntPtr NativeFieldInfoPtr_Tinitused;

	// Token: 0x04003EA8 RID: 16040
	private static readonly IntPtr NativeFieldInfoPtr_Counted;

	// Token: 0x04003EA9 RID: 16041
	private static readonly IntPtr NativeFieldInfoPtr_isEscortVIP;

	// Token: 0x04003EAA RID: 16042
	private static readonly IntPtr NativeFieldInfoPtr_VIPthem;

	// Token: 0x04003EAB RID: 16043
	private static readonly IntPtr NativeFieldInfoPtr_leftWatch;

	// Token: 0x04003EAC RID: 16044
	private static readonly IntPtr NativeFieldInfoPtr_rightWatch;

	// Token: 0x04003EAD RID: 16045
	private static readonly IntPtr NativeFieldInfoPtr_WristWatchScripts;

	// Token: 0x04003EAE RID: 16046
	private static readonly IntPtr NativeFieldInfoPtr_PainScreams;

	// Token: 0x04003EAF RID: 16047
	private static readonly IntPtr NativeFieldInfoPtr_VestRadio;

	// Token: 0x04003EB0 RID: 16048
	private static readonly IntPtr NativeFieldInfoPtr_RadioHolder;

	// Token: 0x04003EB1 RID: 16049
	private static readonly IntPtr NativeFieldInfoPtr_VoiceView;

	// Token: 0x04003EB2 RID: 16050
	private static readonly IntPtr NativeFieldInfoPtr_FPSpectateCamera;

	// Token: 0x04003EB3 RID: 16051
	private static readonly IntPtr NativeFieldInfoPtr_TPSpectateCamera;

	// Token: 0x04003EB4 RID: 16052
	private static readonly IntPtr NativeFieldInfoPtr_ActiveSpectateCamera;

	// Token: 0x04003EB5 RID: 16053
	private static readonly IntPtr NativeFieldInfoPtr_hasInitSpectateCamera;

	// Token: 0x04003EB6 RID: 16054
	private static readonly IntPtr NativeFieldInfoPtr_spectateAspectRatio;

	// Token: 0x04003EB7 RID: 16055
	private static readonly IntPtr NativeFieldInfoPtr_MasterVisualEffectsOBJ;

	// Token: 0x04003EB8 RID: 16056
	private static readonly IntPtr NativeFieldInfoPtr_networkSync;

	// Token: 0x04003EB9 RID: 16057
	private static readonly IntPtr NativeFieldInfoPtr_ragdollUtility;

	// Token: 0x04003EBA RID: 16058
	private static readonly IntPtr NativeFieldInfoPtr_HeadEffector;

	// Token: 0x04003EBB RID: 16059
	private static readonly IntPtr NativeFieldInfoPtr_NetworkHat;

	// Token: 0x04003EBC RID: 16060
	private static readonly IntPtr NativeFieldInfoPtr_OtherPlayer;

	// Token: 0x04003EBD RID: 16061
	private static readonly IntPtr NativeFieldInfoPtr_LastDamageType;

	// Token: 0x04003EBE RID: 16062
	private static readonly IntPtr NativeFieldInfoPtr_LastDamageTypeBeforeSuicide;

	// Token: 0x04003EBF RID: 16063
	private static readonly IntPtr NativeFieldInfoPtr_LastWeaponHitBeforeSuicide;

	// Token: 0x04003EC0 RID: 16064
	private static readonly IntPtr NativeFieldInfoPtr_LastWeaponFired;

	// Token: 0x04003EC1 RID: 16065
	private static readonly IntPtr NativeFieldInfoPtr_OtherAIPlayer;

	// Token: 0x04003EC2 RID: 16066
	private static readonly IntPtr NativeFieldInfoPtr_OtherAIPlayerID;

	// Token: 0x04003EC3 RID: 16067
	private static readonly IntPtr NativeFieldInfoPtr_ik;

	// Token: 0x04003EC4 RID: 16068
	private static readonly IntPtr NativeFieldInfoPtr_PlayerRotation;

	// Token: 0x04003EC5 RID: 16069
	private static readonly IntPtr NativeFieldInfoPtr_Outline;

	// Token: 0x04003EC6 RID: 16070
	private static readonly IntPtr NativeFieldInfoPtr_VisualLoader;

	// Token: 0x04003EC7 RID: 16071
	private static readonly IntPtr NativeFieldInfoPtr_DisableWhenDowned;

	// Token: 0x04003EC8 RID: 16072
	private static readonly IntPtr NativeFieldInfoPtr_DamageLine;

	// Token: 0x04003EC9 RID: 16073
	private static readonly IntPtr NativeFieldInfoPtr_PouchVisibility;

	// Token: 0x04003ECA RID: 16074
	private static readonly IntPtr NativeFieldInfoPtr_SightOrigin;

	// Token: 0x04003ECB RID: 16075
	private static readonly IntPtr NativeFieldInfoPtr_FakeGuyLodMeshRenderer;

	// Token: 0x04003ECC RID: 16076
	private static readonly IntPtr NativeFieldInfoPtr_SkeletonManager;

	// Token: 0x04003ECD RID: 16077
	private static readonly IntPtr NativeFieldInfoPtr_UplinkDetectorCollider;

	// Token: 0x04003ECE RID: 16078
	private static readonly IntPtr NativeFieldInfoPtr_VisionTarget;

	// Token: 0x04003ECF RID: 16079
	private static readonly IntPtr NativeFieldInfoPtr_GearManager;

	// Token: 0x04003ED0 RID: 16080
	private static readonly IntPtr NativeFieldInfoPtr_SFBigBag;

	// Token: 0x04003ED1 RID: 16081
	private static readonly IntPtr NativeFieldInfoPtr_SFSmallBag;

	// Token: 0x04003ED2 RID: 16082
	private static readonly IntPtr NativeFieldInfoPtr_MiniBag;

	// Token: 0x04003ED3 RID: 16083
	private static readonly IntPtr NativeFieldInfoPtr_MarsocGloves;

	// Token: 0x04003ED4 RID: 16084
	private static readonly IntPtr NativeFieldInfoPtr_OSBag;

	// Token: 0x04003ED5 RID: 16085
	private static readonly IntPtr NativeFieldInfoPtr_VolkGloves;

	// Token: 0x04003ED6 RID: 16086
	private static readonly IntPtr NativeFieldInfoPtr_FakeLights;

	// Token: 0x04003ED7 RID: 16087
	private static readonly IntPtr NativeFieldInfoPtr_LocalHandsMesh;

	// Token: 0x04003ED8 RID: 16088
	private static readonly IntPtr NativeFieldInfoPtr_LocalVest;

	// Token: 0x04003ED9 RID: 16089
	private static readonly IntPtr NativeFieldInfoPtr_VestDisabledOnDeadOrDowned;

	// Token: 0x04003EDA RID: 16090
	private static readonly IntPtr NativeFieldInfoPtr_VestDisabledOnDead;

	// Token: 0x04003EDB RID: 16091
	private static readonly IntPtr NativeFieldInfoPtr_LocalVestRenderer;

	// Token: 0x04003EDC RID: 16092
	private static readonly IntPtr NativeFieldInfoPtr_BodyColliders;

	// Token: 0x04003EDD RID: 16093
	private static readonly IntPtr NativeFieldInfoPtr_LocalBodyColliders;

	// Token: 0x04003EDE RID: 16094
	private static readonly IntPtr NativeFieldInfoPtr_ragdollController;

	// Token: 0x04003EDF RID: 16095
	private static readonly IntPtr NativeFieldInfoPtr_NetworkBreath;

	// Token: 0x04003EE0 RID: 16096
	private static readonly IntPtr NativeFieldInfoPtr_NetworkBreathPos;

	// Token: 0x04003EE1 RID: 16097
	private static readonly IntPtr NativeFieldInfoPtr_LocalBreath;

	// Token: 0x04003EE2 RID: 16098
	private static readonly IntPtr NativeFieldInfoPtr_VoicePosition;

	// Token: 0x04003EE3 RID: 16099
	private static readonly IntPtr NativeFieldInfoPtr_FPPostProcess;

	// Token: 0x04003EE4 RID: 16100
	private static readonly IntPtr NativeFieldInfoPtr_FPLight;

	// Token: 0x04003EE5 RID: 16101
	private static readonly IntPtr NativeFieldInfoPtr_TPPostProcess;

	// Token: 0x04003EE6 RID: 16102
	private static readonly IntPtr NativeFieldInfoPtr_TPLight;

	// Token: 0x04003EE7 RID: 16103
	private static readonly IntPtr NativeFieldInfoPtr_ArmorObjects;

	// Token: 0x04003EE8 RID: 16104
	private static readonly IntPtr NativeFieldInfoPtr__TeammateWhoDownedMe_k__BackingField;

	// Token: 0x04003EE9 RID: 16105
	private static readonly IntPtr NativeFieldInfoPtr__IsInDeathTransition_k__BackingField;

	// Token: 0x04003EEA RID: 16106
	private static readonly IntPtr NativeFieldInfoPtr_KarmaDialogTime;

	// Token: 0x04003EEB RID: 16107
	private static readonly IntPtr NativeFieldInfoPtr_hasInit;

	// Token: 0x04003EEC RID: 16108
	private static readonly IntPtr NativeFieldInfoPtr_lastPainSound;

	// Token: 0x04003EED RID: 16109
	private static readonly IntPtr NativeFieldInfoPtr_timeBetweenPainSounds;

	// Token: 0x04003EEE RID: 16110
	private static readonly IntPtr NativeFieldInfoPtr_ShadowToggler;

	// Token: 0x04003EEF RID: 16111
	private static readonly IntPtr NativeFieldInfoPtr__watchSetting;

	// Token: 0x04003EF0 RID: 16112
	private static readonly IntPtr NativeFieldInfoPtr_KillingPlayer;

	// Token: 0x04003EF1 RID: 16113
	private static readonly IntPtr NativeFieldInfoPtr_teamKillingPlayer;

	// Token: 0x04003EF2 RID: 16114
	private static readonly IntPtr NativeFieldInfoPtr__DeathPosition_k__BackingField;

	// Token: 0x04003EF3 RID: 16115
	private static readonly IntPtr NativeFieldInfoPtr__TimeOfLastStateChange_k__BackingField;

	// Token: 0x04003EF4 RID: 16116
	private static readonly IntPtr NativeFieldInfoPtr_BleedOutRoutine;

	// Token: 0x04003EF5 RID: 16117
	private static readonly IntPtr NativeFieldInfoPtr__deathTransition;

	// Token: 0x04003EF6 RID: 16118
	private static readonly IntPtr NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField;

	// Token: 0x04003EF7 RID: 16119
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableDPInInUnique_0;

	// Token: 0x04003EF8 RID: 16120
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInUnique_0;

	// Token: 0x04003EF9 RID: 16121
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique_0;

	// Token: 0x04003EFA RID: 16122
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiUnique_0;

	// Token: 0x04003EFB RID: 16123
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique_0;

	// Token: 0x04003EFC RID: 16124
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableDPUnique_0;

	// Token: 0x04003EFD RID: 16125
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique_0;

	// Token: 0x04003EFE RID: 16126
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0_0;

	// Token: 0x04003EFF RID: 16127
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0_0;

	// Token: 0x04003F00 RID: 16128
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1_0;

	// Token: 0x04003F01 RID: 16129
	private static readonly IntPtr NativeFieldInfoPtr_field_Private_EntityClientRpcHandle_1_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1_0;

	// Token: 0x04003F02 RID: 16130
	private static readonly IntPtr NativeMethodInfoPtr_add_AnyPlayerHit_Public_Static_add_Void_PlayerDamaged_0;

	// Token: 0x04003F03 RID: 16131
	private static readonly IntPtr NativeMethodInfoPtr_remove_AnyPlayerHit_Public_Static_rem_Void_PlayerDamaged_0;

	// Token: 0x04003F04 RID: 16132
	private static readonly IntPtr NativeMethodInfoPtr_add_AnyPlayerRessed_Public_Static_add_Void_PlayerHealedEvent_0;

	// Token: 0x04003F05 RID: 16133
	private static readonly IntPtr NativeMethodInfoPtr_remove_AnyPlayerRessed_Public_Static_rem_Void_PlayerHealedEvent_0;

	// Token: 0x04003F06 RID: 16134
	private static readonly IntPtr NativeMethodInfoPtr_add_AnyPlayerShooting_Public_Static_add_Void_OtherPlayerEvent_0;

	// Token: 0x04003F07 RID: 16135
	private static readonly IntPtr NativeMethodInfoPtr_remove_AnyPlayerShooting_Public_Static_rem_Void_OtherPlayerEvent_0;

	// Token: 0x04003F08 RID: 16136
	private static readonly IntPtr NativeMethodInfoPtr_add_AnyPlayerSpawned_Public_Static_add_Void_AnyPlayerEvent_0;

	// Token: 0x04003F09 RID: 16137
	private static readonly IntPtr NativeMethodInfoPtr_remove_AnyPlayerSpawned_Public_Static_rem_Void_AnyPlayerEvent_0;

	// Token: 0x04003F0A RID: 16138
	private static readonly IntPtr NativeMethodInfoPtr_add_AnyPlayerUnDowned_Public_Static_add_Void_SpecificPlayerEvent_0;

	// Token: 0x04003F0B RID: 16139
	private static readonly IntPtr NativeMethodInfoPtr_remove_AnyPlayerUnDowned_Public_Static_rem_Void_SpecificPlayerEvent_0;

	// Token: 0x04003F0C RID: 16140
	private static readonly IntPtr NativeMethodInfoPtr_add_PlayerShooting_Public_add_Void_PlayerEvent_0;

	// Token: 0x04003F0D RID: 16141
	private static readonly IntPtr NativeMethodInfoPtr_remove_PlayerShooting_Public_rem_Void_PlayerEvent_0;

	// Token: 0x04003F0E RID: 16142
	private static readonly IntPtr NativeMethodInfoPtr_add_PlayerSpawned_Public_add_Void_PlayerEvent_0;

	// Token: 0x04003F0F RID: 16143
	private static readonly IntPtr NativeMethodInfoPtr_remove_PlayerSpawned_Public_rem_Void_PlayerEvent_0;

	// Token: 0x04003F10 RID: 16144
	private static readonly IntPtr NativeMethodInfoPtr_add_PlayerDespawned_Public_add_Void_PlayerEvent_0;

	// Token: 0x04003F11 RID: 16145
	private static readonly IntPtr NativeMethodInfoPtr_remove_PlayerDespawned_Public_rem_Void_PlayerEvent_0;

	// Token: 0x04003F12 RID: 16146
	private static readonly IntPtr NativeMethodInfoPtr_get_CurrentHealth_Public_get_Single_0;

	// Token: 0x04003F13 RID: 16147
	private static readonly IntPtr NativeMethodInfoPtr_get_PlayerFaction_Public_get_Faction_0;

	// Token: 0x04003F14 RID: 16148
	private static readonly IntPtr NativeMethodInfoPtr_get_HasSpawnAudioImmunity_Public_get_Boolean_0;

	// Token: 0x04003F15 RID: 16149
	private static readonly IntPtr NativeMethodInfoPtr_get_IsNightVisionOn_Public_get_Boolean_0;

	// Token: 0x04003F16 RID: 16150
	private static readonly IntPtr NativeMethodInfoPtr_get_TeammateWhoDownedMe_Public_get_DPIPlayer_0;

	// Token: 0x04003F17 RID: 16151
	private static readonly IntPtr NativeMethodInfoPtr_set_TeammateWhoDownedMe_Protected_set_Void_DPIPlayer_0;

	// Token: 0x04003F18 RID: 16152
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInDeathTransition_Public_get_Boolean_0;

	// Token: 0x04003F19 RID: 16153
	private static readonly IntPtr NativeMethodInfoPtr_set_IsInDeathTransition_Protected_set_Void_Boolean_0;

	// Token: 0x04003F1A RID: 16154
	private static readonly IntPtr NativeMethodInfoPtr_get_DeathPosition_Public_get_Vector3_0;

	// Token: 0x04003F1B RID: 16155
	private static readonly IntPtr NativeMethodInfoPtr_set_DeathPosition_Protected_set_Void_Vector3_0;

	// Token: 0x04003F1C RID: 16156
	private static readonly IntPtr NativeMethodInfoPtr_get_IsFriendly_Public_get_Boolean_0;

	// Token: 0x04003F1D RID: 16157
	private static readonly IntPtr NativeMethodInfoPtr_get_TimeOfLastStateChange_Public_get_Double_0;

	// Token: 0x04003F1E RID: 16158
	private static readonly IntPtr NativeMethodInfoPtr_set_TimeOfLastStateChange_Private_set_Void_Double_0;

	// Token: 0x04003F1F RID: 16159
	private static readonly IntPtr NativeMethodInfoPtr_get_IsEnemy_Public_get_Boolean_0;

	// Token: 0x04003F20 RID: 16160
	private static readonly IntPtr NativeMethodInfoPtr_GetWarPlayer_Public_Static_WarPlayerScript_DPIPlayer_0;

	// Token: 0x04003F21 RID: 16161
	private static readonly IntPtr NativeMethodInfoPtr_ClearReferencesToPlayer_Public_Void_DPIPlayer_0;

	// Token: 0x04003F22 RID: 16162
	private static readonly IntPtr NativeMethodInfoPtr_SetOtherAIInfo_Protected_Void_Int32_0;

	// Token: 0x04003F23 RID: 16163
	private static readonly IntPtr NativeMethodInfoPtr_ShutOff_Public_Virtual_New_Void_0;

	// Token: 0x04003F24 RID: 16164
	private static readonly IntPtr NativeMethodInfoPtr_ShutOffWithoutDisconnect_Public_Virtual_New_Void_0;

	// Token: 0x04003F25 RID: 16165
	private static readonly IntPtr NativeMethodInfoPtr_GetWatchSettings_Private_Void_0;

	// Token: 0x04003F26 RID: 16166
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

	// Token: 0x04003F27 RID: 16167
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;

	// Token: 0x04003F28 RID: 16168
	private static readonly IntPtr NativeMethodInfoPtr_ResetKillingPlayer_Protected_Void_0;

	// Token: 0x04003F29 RID: 16169
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Void_0;

	// Token: 0x04003F2A RID: 16170
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerLeftTeam_Protected_Void_OnwardPhotonPlayer_Team_0;

	// Token: 0x04003F2B RID: 16171
	private static readonly IntPtr NativeMethodInfoPtr_AddCameraIn_Public_IEnumerator_0;

	// Token: 0x04003F2C RID: 16172
	private static readonly IntPtr NativeMethodInfoPtr_AddCameraNow_Public_Void_0;

	// Token: 0x04003F2D RID: 16173
	private static readonly IntPtr NativeMethodInfoPtr_SetFirstPersonEnabled_Public_Void_Boolean_0;

	// Token: 0x04003F2E RID: 16174
	private static readonly IntPtr NativeMethodInfoPtr_SetThirdPersonEnabled_Public_Void_Boolean_0;

	// Token: 0x04003F2F RID: 16175
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Void_0;

	// Token: 0x04003F30 RID: 16176
	private static readonly IntPtr NativeMethodInfoPtr_ToggleInvisibleShadowCasterLOD_Private_Void_Boolean_0;

	// Token: 0x04003F31 RID: 16177
	private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

	// Token: 0x04003F32 RID: 16178
	private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Void_0;

	// Token: 0x04003F33 RID: 16179
	private static readonly IntPtr NativeMethodInfoPtr_SetupSpectateCamera_Public_Void_0;

	// Token: 0x04003F34 RID: 16180
	private static readonly IntPtr NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04003F35 RID: 16181
	private static readonly IntPtr NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0;

	// Token: 0x04003F36 RID: 16182
	private static readonly IntPtr NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0;

	// Token: 0x04003F37 RID: 16183
	private static readonly IntPtr NativeMethodInfoPtr_SetLocalIconColor_Public_Void_0;

	// Token: 0x04003F38 RID: 16184
	private static readonly IntPtr NativeMethodInfoPtr_RefreshAllPlayerIcons_Public_Static_Void_0;

	// Token: 0x04003F39 RID: 16185
	private static readonly IntPtr NativeMethodInfoPtr_RefreshPlayerIcon_Public_Void_0;

	// Token: 0x04003F3A RID: 16186
	private static readonly IntPtr NativeMethodInfoPtr_RefreshAllyMapIcon_Protected_Void_Boolean_0;

	// Token: 0x04003F3B RID: 16187
	private static readonly IntPtr NativeMethodInfoPtr_RefreshAllyMapColor_Protected_Void_0;

	// Token: 0x04003F3C RID: 16188
	private static readonly IntPtr NativeMethodInfoPtr_RefreshEnemyMapIcon_Protected_Void_Boolean_0;

	// Token: 0x04003F3D RID: 16189
	private static readonly IntPtr NativeMethodInfoPtr_RefreshEnemyMapColor_Protected_Void_0;

	// Token: 0x04003F3E RID: 16190
	private static readonly IntPtr NativeMethodInfoPtr_ApplyDamage_Public_Void_Single_DPIPlayer_Int32_DamageType_byref_Nullable_1_WeaponName_0;

	// Token: 0x04003F3F RID: 16191
	private static readonly IntPtr NativeMethodInfoPtr_ApplyDamage_Public_Void_Single_Vector3_BodyParts_DPIPlayer_Int32_DamageType_byref_Nullable_1_WeaponName_0;

	// Token: 0x04003F40 RID: 16192
	private static readonly IntPtr NativeMethodInfoPtr_ApplyTaserDamage_Public_Void_OnwardPhotonPlayer_Int32_Pickup_0;

	// Token: 0x04003F41 RID: 16193
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ApplyTaserDamage_Public_Void_DPIPlayer_Int32_Int32_DPINetworkMessageInfo_0;

	// Token: 0x04003F42 RID: 16194
	private static readonly IntPtr NativeMethodInfoPtr_IsHitInfractable_Protected_Boolean_Boolean_Boolean_Boolean_DPIPlayer_0;

	// Token: 0x04003F43 RID: 16195
	private static readonly IntPtr NativeMethodInfoPtr_SendHeal_Public_Void_Boolean_Int32_0;

	// Token: 0x04003F44 RID: 16196
	private static readonly IntPtr NativeMethodInfoPtr_RPC_Heal_Public_Void_Int32_DPINetworkMessageInfo_0;

	// Token: 0x04003F45 RID: 16197
	private static readonly IntPtr NativeMethodInfoPtr_LocalHeal_Private_Void_Int32_DPIPlayer_0;

	// Token: 0x04003F46 RID: 16198
	private static readonly IntPtr NativeMethodInfoPtr_RPC_HealRemote_Public_Void_Int32_Int32_Boolean_DPIPlayer_DPINetworkMessageInfo_0;

	// Token: 0x04003F47 RID: 16199
	private static readonly IntPtr NativeMethodInfoPtr_FullyStopBleedingAndEffects_Private_Void_0;

	// Token: 0x04003F48 RID: 16200
	private static readonly IntPtr NativeMethodInfoPtr_HealScore_Public_Void_0;

	// Token: 0x04003F49 RID: 16201
	private static readonly IntPtr NativeMethodInfoPtr_RPC_SetArmorHP_Public_Void_Single_DPINetworkMessageInfo_0;

	// Token: 0x04003F4A RID: 16202
	private static readonly IntPtr NativeMethodInfoPtr_SetHP_Public_Void_Single_DPIPlayer_Int32_Boolean_Single_Int32_0;

	// Token: 0x04003F4B RID: 16203
	private static readonly IntPtr NativeMethodInfoPtr_RPC_SetHP_Public_Void_Single_DPIPlayer_Int32_Vector3_Vector3_Boolean_Int32_Single_Int32_Int32_DPINetworkMessageInfo_0;

	// Token: 0x04003F4C RID: 16204
	private static readonly IntPtr NativeMethodInfoPtr_IgnoreBleed_Private_Void_Boolean_0;

	// Token: 0x04003F4D RID: 16205
	private static readonly IntPtr NativeMethodInfoPtr_StopBleedOnHeal_Private_Void_Boolean_0;

	// Token: 0x04003F4E RID: 16206
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerHit_Private_Void_WarPlayerScript_WarPlayerScript_Boolean_Boolean_Boolean_BodyParts_Vector3_Vector3_Single_DamageType_WeaponName_0;

	// Token: 0x04003F4F RID: 16207
	private static readonly IntPtr NativeMethodInfoPtr_OnLocalDowned_Private_Void_WarPlayerScript_Boolean_DamageType_WeaponName_0;

	// Token: 0x04003F50 RID: 16208
	private static readonly IntPtr NativeMethodInfoPtr_OnLocalDeath_Private_Void_Boolean_Boolean_WarPlayerScript_DamageType_WeaponName_0;

	// Token: 0x04003F51 RID: 16209
	private static readonly IntPtr NativeMethodInfoPtr_ShowInfractionUI_Private_Void_WarPlayerScript_Boolean_DamageType_0;

	// Token: 0x04003F52 RID: 16210
	private static readonly IntPtr NativeMethodInfoPtr_SetHPMax_Public_Void_0;

	// Token: 0x04003F53 RID: 16211
	private static readonly IntPtr NativeMethodInfoPtr_SetDead_Private_Void_DamageType_Boolean_Boolean_DPIPlayer_0;

	// Token: 0x04003F54 RID: 16212
	private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerDied_Private_Void_DamageType_Boolean_Boolean_0;

	// Token: 0x04003F55 RID: 16213
	private static readonly IntPtr NativeMethodInfoPtr_PainStopVoice_Public_Void_0;

	// Token: 0x04003F56 RID: 16214
	private static readonly IntPtr NativeMethodInfoPtr_PainPlayCry_Public_Void_0;

	// Token: 0x04003F57 RID: 16215
	private static readonly IntPtr NativeMethodInfoPtr_PainPlayGrunt_Public_Void_0;

	// Token: 0x04003F58 RID: 16216
	private static readonly IntPtr NativeMethodInfoPtr_OnCasualtyUIVisible_Public_Void_CasualtyUIState_0;

	// Token: 0x04003F59 RID: 16217
	private static readonly IntPtr NativeMethodInfoPtr_SetLastDamage_Public_Void_DamageType_Nullable_1_WeaponName_0;

	// Token: 0x04003F5A RID: 16218
	private static readonly IntPtr NativeMethodInfoPtr_PainPlayDrown_Public_Void_0;

	// Token: 0x04003F5B RID: 16219
	private static readonly IntPtr NativeMethodInfoPtr_GetKilledByText_Public_String_DamageType_0;

	// Token: 0x04003F5C RID: 16220
	private static readonly IntPtr NativeMethodInfoPtr_GetDownedByText_Public_String_0;

	// Token: 0x04003F5D RID: 16221
	private static readonly IntPtr NativeMethodInfoPtr_ResetBody_Public_Void_0;

	// Token: 0x04003F5E RID: 16222
	private static readonly IntPtr NativeMethodInfoPtr_ResetKarmaDialogTime_Public_Void_0;

	// Token: 0x04003F5F RID: 16223
	private static readonly IntPtr NativeMethodInfoPtr_DeathTransition_Public_IEnumerator_0;

	// Token: 0x04003F60 RID: 16224
	private static readonly IntPtr NativeMethodInfoPtr_BleedOut_Public_IEnumerator_Single_0;

	// Token: 0x04003F61 RID: 16225
	private static readonly IntPtr NativeMethodInfoPtr_StopBleedOut_Public_Void_0;

	// Token: 0x04003F62 RID: 16226
	private static readonly IntPtr NativeMethodInfoPtr_Respawn_Public_Void_0;

	// Token: 0x04003F63 RID: 16227
	private static readonly IntPtr NativeMethodInfoPtr_SetInvincibility_Private_Void_0;

	// Token: 0x04003F64 RID: 16228
	private static readonly IntPtr NativeMethodInfoPtr_RPC_UpdateMe_Public_Void_DPIPlayer_DPINetworkMessageInfo_0;

	// Token: 0x04003F65 RID: 16229
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ThisPlayerState_Public_Void_Single_Single_Boolean_Boolean_Vector3_Boolean_DPINetworkMessageInfo_0;

	// Token: 0x04003F66 RID: 16230
	private static readonly IntPtr NativeMethodInfoPtr_DownPlayer_Protected_Void_0;

	// Token: 0x04003F67 RID: 16231
	private static readonly IntPtr NativeMethodInfoPtr_UnDownPlayer_Protected_Void_0;

	// Token: 0x04003F68 RID: 16232
	private static readonly IntPtr NativeMethodInfoPtr_SetRagdollActive_Private_Void_Boolean_DPIPlayer_Boolean_0;

	// Token: 0x04003F69 RID: 16233
	private static readonly IntPtr NativeMethodInfoPtr_UpdateHandModels_Public_Void_Boolean_Boolean_0;

	// Token: 0x04003F6A RID: 16234
	private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Void_PlayerState_0;

	// Token: 0x04003F6B RID: 16235
	private static readonly IntPtr NativeMethodInfoPtr_IsRevivable_Public_Boolean_0;

	// Token: 0x04003F6C RID: 16236
	private static readonly IntPtr NativeMethodInfoPtr_RefreshShadows_Public_Void_0;

	// Token: 0x04003F6D RID: 16237
	private static readonly IntPtr NativeMethodInfoPtr_FlashMe_Public_Void_0;

	// Token: 0x04003F6E RID: 16238
	private static readonly IntPtr NativeMethodInfoPtr_RPC_TinitusMe_Public_Void_DPINetworkMessageInfo_0;

	// Token: 0x04003F6F RID: 16239
	private static readonly IntPtr NativeMethodInfoPtr_FlashStart_Public_IEnumerator_0;

	// Token: 0x04003F70 RID: 16240
	private static readonly IntPtr NativeMethodInfoPtr_StartTinitus_Public_Void_0;

	// Token: 0x04003F71 RID: 16241
	private static readonly IntPtr NativeMethodInfoPtr_DelayDisableTinitus_Protected_IEnumerator_0;

	// Token: 0x04003F72 RID: 16242
	private static readonly IntPtr NativeMethodInfoPtr_ResetGear_Public_Void_0;

	// Token: 0x04003F73 RID: 16243
	private static readonly IntPtr NativeMethodInfoPtr_DisableObject_Protected_Void_GameObject_0;

	// Token: 0x04003F74 RID: 16244
	private static readonly IntPtr NativeMethodInfoPtr_LoadVisuals_Protected_Void_0;

	// Token: 0x04003F75 RID: 16245
	private static readonly IntPtr NativeMethodInfoPtr_UpdateFakeLights_Protected_Void_0;

	// Token: 0x04003F76 RID: 16246
	private static readonly IntPtr NativeMethodInfoPtr_RefreshOutfit_Protected_Void_0;

	// Token: 0x04003F77 RID: 16247
	private static readonly IntPtr NativeMethodInfoPtr_SetOutfit_Public_Void_SoldierClass_Faction_0;

	// Token: 0x04003F78 RID: 16248
	private static readonly IntPtr NativeMethodInfoPtr_ShowWatchVisuals_Protected_Void_Boolean_0;

	// Token: 0x04003F79 RID: 16249
	private static readonly IntPtr NativeMethodInfoPtr_SynchronizeVIPState_Public_Void_0;

	// Token: 0x04003F7A RID: 16250
	private static readonly IntPtr NativeMethodInfoPtr_SpectateMe_Public_Void_Boolean_Boolean_0;

	// Token: 0x04003F7B RID: 16251
	private static readonly IntPtr NativeMethodInfoPtr_GetBarrelPosition_Public_Vector3_0;

	// Token: 0x04003F7C RID: 16252
	private static readonly IntPtr NativeMethodInfoPtr_PlayerShot_Public_Void_0;

	// Token: 0x04003F7D RID: 16253
	private static readonly IntPtr NativeMethodInfoPtr_ForceActivateLocalWarPlayer_Public_Static_Void_0;

	// Token: 0x04003F7E RID: 16254
	private static readonly IntPtr NativeMethodInfoPtr_ResetSpawnAudioImmunity_Public_Void_0;

	// Token: 0x04003F7F RID: 16255
	private static readonly IntPtr NativeMethodInfoPtr_SetNameColor_Public_Void_Color_0;

	// Token: 0x04003F80 RID: 16256
	private static readonly IntPtr NativeMethodInfoPtr_RemovePlayerEntry_Public_Void_0;

	// Token: 0x04003F81 RID: 16257
	private static readonly IntPtr NativeMethodInfoPtr_SetManualInvincibility_Public_Void_Boolean_0;

	// Token: 0x04003F82 RID: 16258
	private static readonly IntPtr NativeMethodInfoPtr_ToggleManualInvincibility_Public_Void_0;

	// Token: 0x04003F83 RID: 16259
	private static readonly IntPtr NativeMethodInfoPtr_SetAllManuallyInvincible_Public_Static_Void_Boolean_0;

	// Token: 0x04003F84 RID: 16260
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ManualInvincibility_Protected_Void_Boolean_DPINetworkMessageInfo_0;

	// Token: 0x04003F85 RID: 16261
	private static readonly IntPtr NativeMethodInfoPtr_RPC_Targetability_Protected_Void_Boolean_DPINetworkMessageInfo_0;

	// Token: 0x04003F86 RID: 16262
	private static readonly IntPtr NativeMethodInfoPtr_SendWhistle_Public_Void_0;

	// Token: 0x04003F87 RID: 16263
	private static readonly IntPtr NativeMethodInfoPtr_RPC_AIWhistle_Protected_Void_DPINetworkMessageInfo_0;

	// Token: 0x04003F88 RID: 16264
	private static readonly IntPtr NativeMethodInfoPtr_EnableDebugInvincibility_Public_Void_0;

	// Token: 0x04003F89 RID: 16265
	private static readonly IntPtr NativeMethodInfoPtr_ToggleDebugTargetability_Public_Void_0;

	// Token: 0x04003F8A RID: 16266
	private static readonly IntPtr NativeMethodInfoPtr_InflictDamageToSelf_Public_Void_0;

	// Token: 0x04003F8B RID: 16267
	private static readonly IntPtr NativeMethodInfoPtr_UpdateEditorHotkeys_Protected_Void_Boolean_0;

	// Token: 0x04003F8C RID: 16268
	private static readonly IntPtr NativeMethodInfoPtr_UpdateGeneralHotkeys_Protected_Void_Boolean_0;

	// Token: 0x04003F8D RID: 16269
	private static readonly IntPtr NativeMethodInfoPtr_GetDebugLookObject_Protected_String_0;

	// Token: 0x04003F8E RID: 16270
	private static readonly IntPtr NativeMethodInfoPtr_GetSurvivalScore_Public_Single_0;

	// Token: 0x04003F8F RID: 16271
	private static readonly IntPtr NativeMethodInfoPtr_GetSurvivalMultiplier_Public_Static_Single_Faction_0;

	// Token: 0x04003F90 RID: 16272
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableDPInInUnique_DPINetworkMessageInfo_0;

	// Token: 0x04003F91 RID: 16273
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ApplyTaserDamage_Public_Void_ArrayOf_DPIPlayer_DPIPlayer_Int32_Int32_0;

	// Token: 0x04003F92 RID: 16274
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ApplyTaserDamage_Public_Void_DPIPlayer_DPIPlayer_Int32_Int32_0;

	// Token: 0x04003F93 RID: 16275
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ApplyTaserDamage_Public_Void_RpcTarget_DPIPlayer_Int32_Int32_0;

	// Token: 0x04003F94 RID: 16276
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInUnique_DPINetworkMessageInfo_0;

	// Token: 0x04003F95 RID: 16277
	private static readonly IntPtr NativeMethodInfoPtr_RPC_Heal_Public_Void_ArrayOf_DPIPlayer_Int32_0;

	// Token: 0x04003F96 RID: 16278
	private static readonly IntPtr NativeMethodInfoPtr_RPC_Heal_Public_Void_DPIPlayer_Int32_0;

	// Token: 0x04003F97 RID: 16279
	private static readonly IntPtr NativeMethodInfoPtr_RPC_Heal_Public_Void_RpcTarget_Int32_0;

	// Token: 0x04003F98 RID: 16280
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique_DPINetworkMessageInfo_0;

	// Token: 0x04003F99 RID: 16281
	private static readonly IntPtr NativeMethodInfoPtr_RPC_HealRemote_Public_Void_ArrayOf_DPIPlayer_Int32_Int32_Boolean_DPIPlayer_0;

	// Token: 0x04003F9A RID: 16282
	private static readonly IntPtr NativeMethodInfoPtr_RPC_HealRemote_Public_Void_DPIPlayer_Int32_Int32_Boolean_DPIPlayer_0;

	// Token: 0x04003F9B RID: 16283
	private static readonly IntPtr NativeMethodInfoPtr_RPC_HealRemote_Public_Void_RpcTarget_Int32_Int32_Boolean_DPIPlayer_0;

	// Token: 0x04003F9C RID: 16284
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableSiUnique_DPINetworkMessageInfo_0;

	// Token: 0x04003F9D RID: 16285
	private static readonly IntPtr NativeMethodInfoPtr_RPC_SetArmorHP_Public_Void_ArrayOf_DPIPlayer_Single_0;

	// Token: 0x04003F9E RID: 16286
	private static readonly IntPtr NativeMethodInfoPtr_RPC_SetArmorHP_Public_Void_DPIPlayer_Single_0;

	// Token: 0x04003F9F RID: 16287
	private static readonly IntPtr NativeMethodInfoPtr_RPC_SetArmorHP_Public_Void_RpcTarget_Single_0;

	// Token: 0x04003FA0 RID: 16288
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique_DPINetworkMessageInfo_0;

	// Token: 0x04003FA1 RID: 16289
	private static readonly IntPtr NativeMethodInfoPtr_RPC_SetHP_Public_Void_ArrayOf_DPIPlayer_Single_DPIPlayer_Int32_Vector3_Vector3_Boolean_Int32_Single_Int32_Int32_0;

	// Token: 0x04003FA2 RID: 16290
	private static readonly IntPtr NativeMethodInfoPtr_RPC_SetHP_Public_Void_DPIPlayer_Single_DPIPlayer_Int32_Vector3_Vector3_Boolean_Int32_Single_Int32_Int32_0;

	// Token: 0x04003FA3 RID: 16291
	private static readonly IntPtr NativeMethodInfoPtr_RPC_SetHP_Public_Void_RpcTarget_Single_DPIPlayer_Int32_Vector3_Vector3_Boolean_Int32_Single_Int32_Int32_0;

	// Token: 0x04003FA4 RID: 16292
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableDPUnique_DPINetworkMessageInfo_0;

	// Token: 0x04003FA5 RID: 16293
	private static readonly IntPtr NativeMethodInfoPtr_RPC_UpdateMe_Public_Void_ArrayOf_DPIPlayer_DPIPlayer_0;

	// Token: 0x04003FA6 RID: 16294
	private static readonly IntPtr NativeMethodInfoPtr_RPC_UpdateMe_Public_Void_DPIPlayer_DPIPlayer_0;

	// Token: 0x04003FA7 RID: 16295
	private static readonly IntPtr NativeMethodInfoPtr_RPC_UpdateMe_Public_Void_RpcTarget_DPIPlayer_0;

	// Token: 0x04003FA8 RID: 16296
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique_DPINetworkMessageInfo_0;

	// Token: 0x04003FA9 RID: 16297
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ThisPlayerState_Public_Void_ArrayOf_DPIPlayer_Single_Single_Boolean_Boolean_Vector3_Boolean_0;

	// Token: 0x04003FAA RID: 16298
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ThisPlayerState_Public_Void_DPIPlayer_Single_Single_Boolean_Boolean_Vector3_Boolean_0;

	// Token: 0x04003FAB RID: 16299
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ThisPlayerState_Public_Void_RpcTarget_Single_Single_Boolean_Boolean_Vector3_Boolean_0;

	// Token: 0x04003FAC RID: 16300
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0_DPINetworkMessageInfo_0;

	// Token: 0x04003FAD RID: 16301
	private static readonly IntPtr NativeMethodInfoPtr_RPC_TinitusMe_Public_Void_ArrayOf_DPIPlayer_0;

	// Token: 0x04003FAE RID: 16302
	private static readonly IntPtr NativeMethodInfoPtr_RPC_TinitusMe_Public_Void_DPIPlayer_0;

	// Token: 0x04003FAF RID: 16303
	private static readonly IntPtr NativeMethodInfoPtr_RPC_TinitusMe_Public_Void_RpcTarget_0;

	// Token: 0x04003FB0 RID: 16304
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0_DPINetworkMessageInfo_0;

	// Token: 0x04003FB1 RID: 16305
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ManualInvincibility_Public_Void_ArrayOf_DPIPlayer_Boolean_0;

	// Token: 0x04003FB2 RID: 16306
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ManualInvincibility_Public_Void_DPIPlayer_Boolean_0;

	// Token: 0x04003FB3 RID: 16307
	private static readonly IntPtr NativeMethodInfoPtr_RPC_ManualInvincibility_Public_Void_RpcTarget_Boolean_0;

	// Token: 0x04003FB4 RID: 16308
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1_DPINetworkMessageInfo_0;

	// Token: 0x04003FB5 RID: 16309
	private static readonly IntPtr NativeMethodInfoPtr_RPC_Targetability_Public_Void_ArrayOf_DPIPlayer_Boolean_0;

	// Token: 0x04003FB6 RID: 16310
	private static readonly IntPtr NativeMethodInfoPtr_RPC_Targetability_Public_Void_DPIPlayer_Boolean_0;

	// Token: 0x04003FB7 RID: 16311
	private static readonly IntPtr NativeMethodInfoPtr_RPC_Targetability_Public_Void_RpcTarget_Boolean_0;

	// Token: 0x04003FB8 RID: 16312
	private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1_DPINetworkMessageInfo_0;

	// Token: 0x04003FB9 RID: 16313
	private static readonly IntPtr NativeMethodInfoPtr_RPC_AIWhistle_Public_Void_ArrayOf_DPIPlayer_0;

	// Token: 0x04003FBA RID: 16314
	private static readonly IntPtr NativeMethodInfoPtr_RPC_AIWhistle_Public_Void_DPIPlayer_0;

	// Token: 0x04003FBB RID: 16315
	private static readonly IntPtr NativeMethodInfoPtr_RPC_AIWhistle_Public_Void_RpcTarget_0;

	// Token: 0x04003FBC RID: 16316
	private static readonly IntPtr NativeMethodInfoPtr_OnCodeGenInitializeHook_Public_Virtual_Void_0;

	// Token: 0x04003FBD RID: 16317
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020004D0 RID: 1232
	public sealed class PlayerDamaged : MulticastDelegate
	{
		// Token: 0x060064C9 RID: 25801 RVA: 0x001956AC File Offset: 0x001938AC
		[CallerCount(0)]
		public unsafe PlayerDamaged(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript.PlayerDamaged>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerDamaged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064CA RID: 25802 RVA: 0x00195724 File Offset: 0x00193924
		[CallerCount(0)]
		public unsafe void Invoke(WarPlayerScript player, WarPlayerScript lastDamageGiver, bool killingHit, bool downingHit, bool infractableHit, BodyParts damagedPart, Vector3 hitPos, Vector3 shootPos, float damage, DamageType damageType, [Optional] WeaponName weaponName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastDamageGiver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref killingHit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref downingHit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref infractableHit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damagedPart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPos;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shootPos;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damage;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageType;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponName;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerDamaged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_WarPlayerScript_Boolean_Boolean_Boolean_BodyParts_Vector3_Vector3_Single_DamageType_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x00195844 File Offset: 0x00193A44
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(WarPlayerScript player, WarPlayerScript lastDamageGiver, bool killingHit, bool downingHit, bool infractableHit, BodyParts damagedPart, Vector3 hitPos, Vector3 shootPos, float damage, DamageType damageType, WeaponName weaponName, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastDamageGiver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref killingHit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref downingHit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref infractableHit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damagedPart;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPos;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shootPos;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damage;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageType;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weaponName;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerDamaged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_WarPlayerScript_Boolean_Boolean_Boolean_BodyParts_Vector3_Vector3_Single_DamageType_WeaponName_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x060064CC RID: 25804 RVA: 0x001959AC File Offset: 0x00193BAC
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerDamaged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064CD RID: 25805 RVA: 0x00195A08 File Offset: 0x00193C08
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerDamaged()
		{
			Il2CppClassPointerStore<WarPlayerScript.PlayerDamaged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "PlayerDamaged");
			WarPlayerScript.PlayerDamaged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerDamaged>.NativeClassPtr, 100671330);
			WarPlayerScript.PlayerDamaged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_WarPlayerScript_Boolean_Boolean_Boolean_BodyParts_Vector3_Vector3_Single_DamageType_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerDamaged>.NativeClassPtr, 100671331);
			WarPlayerScript.PlayerDamaged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_WarPlayerScript_Boolean_Boolean_Boolean_BodyParts_Vector3_Vector3_Single_DamageType_WeaponName_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerDamaged>.NativeClassPtr, 100671332);
			WarPlayerScript.PlayerDamaged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerDamaged>.NativeClassPtr, 100671333);
		}

		// Token: 0x060064CE RID: 25806 RVA: 0x00005E35 File Offset: 0x00004035
		public PlayerDamaged(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023C5 RID: 9157
		// (get) Token: 0x060064CF RID: 25807 RVA: 0x00195A79 File Offset: 0x00193C79
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.PlayerDamaged>.NativeClassPtr));
			}
		}

		// Token: 0x04003FBE RID: 16318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003FBF RID: 16319
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_WarPlayerScript_Boolean_Boolean_Boolean_BodyParts_Vector3_Vector3_Single_DamageType_WeaponName_0;

		// Token: 0x04003FC0 RID: 16320
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_WarPlayerScript_Boolean_Boolean_Boolean_BodyParts_Vector3_Vector3_Single_DamageType_WeaponName_AsyncCallback_Object_0;

		// Token: 0x04003FC1 RID: 16321
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020004D1 RID: 1233
	public sealed class PlayerHealedEvent : MulticastDelegate
	{
		// Token: 0x060064D0 RID: 25808 RVA: 0x00195A8C File Offset: 0x00193C8C
		[CallerCount(0)]
		public unsafe PlayerHealedEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript.PlayerHealedEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerHealedEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064D1 RID: 25809 RVA: 0x00195B04 File Offset: 0x00193D04
		[CallerCount(0)]
		public unsafe void Invoke(WarPlayerScript player, WarPlayerScript otherPlayer, bool hasRevived)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(otherPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasRevived;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerHealedEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_WarPlayerScript_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064D2 RID: 25810 RVA: 0x00195B88 File Offset: 0x00193D88
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(WarPlayerScript player, WarPlayerScript otherPlayer, bool hasRevived, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(otherPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasRevived;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerHealedEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_WarPlayerScript_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x060064D3 RID: 25811 RVA: 0x00195C50 File Offset: 0x00193E50
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerHealedEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064D4 RID: 25812 RVA: 0x00195CAC File Offset: 0x00193EAC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerHealedEvent()
		{
			Il2CppClassPointerStore<WarPlayerScript.PlayerHealedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "PlayerHealedEvent");
			WarPlayerScript.PlayerHealedEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerHealedEvent>.NativeClassPtr, 100671334);
			WarPlayerScript.PlayerHealedEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_WarPlayerScript_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerHealedEvent>.NativeClassPtr, 100671335);
			WarPlayerScript.PlayerHealedEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_WarPlayerScript_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerHealedEvent>.NativeClassPtr, 100671336);
			WarPlayerScript.PlayerHealedEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerHealedEvent>.NativeClassPtr, 100671337);
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x00005E35 File Offset: 0x00004035
		public PlayerHealedEvent(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x060064D6 RID: 25814 RVA: 0x00195D1D File Offset: 0x00193F1D
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.PlayerHealedEvent>.NativeClassPtr));
			}
		}

		// Token: 0x060064D7 RID: 25815 RVA: 0x00195D2E File Offset: 0x00193F2E
		public static implicit operator WarPlayerScript.PlayerHealedEvent(Action<WarPlayerScript, WarPlayerScript, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<WarPlayerScript.PlayerHealedEvent>(A_0);
		}

		// Token: 0x060064D8 RID: 25816 RVA: 0x00195D36 File Offset: 0x00193F36
		public static WarPlayerScript.PlayerHealedEvent operator +(WarPlayerScript.PlayerHealedEvent A_0, WarPlayerScript.PlayerHealedEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<WarPlayerScript.PlayerHealedEvent>();
		}

		// Token: 0x060064D9 RID: 25817 RVA: 0x00195D44 File Offset: 0x00193F44
		public static WarPlayerScript.PlayerHealedEvent operator -(WarPlayerScript.PlayerHealedEvent A_0, WarPlayerScript.PlayerHealedEvent A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<WarPlayerScript.PlayerHealedEvent>();
			}
			return result;
		}

		// Token: 0x04003FC2 RID: 16322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003FC3 RID: 16323
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_WarPlayerScript_Boolean_0;

		// Token: 0x04003FC4 RID: 16324
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_WarPlayerScript_Boolean_AsyncCallback_Object_0;

		// Token: 0x04003FC5 RID: 16325
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020004D2 RID: 1234
	public sealed class OtherPlayerEvent : MulticastDelegate
	{
		// Token: 0x060064DA RID: 25818 RVA: 0x00195D58 File Offset: 0x00193F58
		[CallerCount(0)]
		public unsafe OtherPlayerEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript.OtherPlayerEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.OtherPlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x00195DD0 File Offset: 0x00193FD0
		[CallerCount(0)]
		public unsafe void Invoke(WarPlayerScript player, WarPlayerScript otherPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(otherPlayer);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.OtherPlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_WarPlayerScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x00195E44 File Offset: 0x00194044
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(WarPlayerScript player, WarPlayerScript otherPlayer, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(otherPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.OtherPlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_WarPlayerScript_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x060064DD RID: 25821 RVA: 0x00195EFC File Offset: 0x001940FC
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.OtherPlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064DE RID: 25822 RVA: 0x00195F58 File Offset: 0x00194158
		// Note: this type is marked as 'beforefieldinit'.
		static OtherPlayerEvent()
		{
			Il2CppClassPointerStore<WarPlayerScript.OtherPlayerEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "OtherPlayerEvent");
			WarPlayerScript.OtherPlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.OtherPlayerEvent>.NativeClassPtr, 100671338);
			WarPlayerScript.OtherPlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_WarPlayerScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.OtherPlayerEvent>.NativeClassPtr, 100671339);
			WarPlayerScript.OtherPlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_WarPlayerScript_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.OtherPlayerEvent>.NativeClassPtr, 100671340);
			WarPlayerScript.OtherPlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.OtherPlayerEvent>.NativeClassPtr, 100671341);
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x00005E35 File Offset: 0x00004035
		public OtherPlayerEvent(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x060064E0 RID: 25824 RVA: 0x00195FC9 File Offset: 0x001941C9
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.OtherPlayerEvent>.NativeClassPtr));
			}
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x00195FDA File Offset: 0x001941DA
		public static implicit operator WarPlayerScript.OtherPlayerEvent(Action<WarPlayerScript, WarPlayerScript> A_0)
		{
			return DelegateSupport.ConvertDelegate<WarPlayerScript.OtherPlayerEvent>(A_0);
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x00195FE2 File Offset: 0x001941E2
		public static WarPlayerScript.OtherPlayerEvent operator +(WarPlayerScript.OtherPlayerEvent A_0, WarPlayerScript.OtherPlayerEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<WarPlayerScript.OtherPlayerEvent>();
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x00195FF0 File Offset: 0x001941F0
		public static WarPlayerScript.OtherPlayerEvent operator -(WarPlayerScript.OtherPlayerEvent A_0, WarPlayerScript.OtherPlayerEvent A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<WarPlayerScript.OtherPlayerEvent>();
			}
			return result;
		}

		// Token: 0x04003FC6 RID: 16326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003FC7 RID: 16327
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_WarPlayerScript_0;

		// Token: 0x04003FC8 RID: 16328
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_WarPlayerScript_AsyncCallback_Object_0;

		// Token: 0x04003FC9 RID: 16329
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020004D3 RID: 1235
	public sealed class AnyPlayerEvent : MulticastDelegate
	{
		// Token: 0x060064E4 RID: 25828 RVA: 0x00196004 File Offset: 0x00194204
		[CallerCount(0)]
		public unsafe AnyPlayerEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript.AnyPlayerEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.AnyPlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x0019607C File Offset: 0x0019427C
		[CallerCount(0)]
		public unsafe void Invoke(WarPlayerScript player, bool isFirstRoundSpawn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFirstRoundSpawn;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.AnyPlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x001960E8 File Offset: 0x001942E8
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(WarPlayerScript player, bool isFirstRoundSpawn, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFirstRoundSpawn;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.AnyPlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x00196198 File Offset: 0x00194398
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.AnyPlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x001961F4 File Offset: 0x001943F4
		// Note: this type is marked as 'beforefieldinit'.
		static AnyPlayerEvent()
		{
			Il2CppClassPointerStore<WarPlayerScript.AnyPlayerEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "AnyPlayerEvent");
			WarPlayerScript.AnyPlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.AnyPlayerEvent>.NativeClassPtr, 100671342);
			WarPlayerScript.AnyPlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.AnyPlayerEvent>.NativeClassPtr, 100671343);
			WarPlayerScript.AnyPlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.AnyPlayerEvent>.NativeClassPtr, 100671344);
			WarPlayerScript.AnyPlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.AnyPlayerEvent>.NativeClassPtr, 100671345);
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x00005E35 File Offset: 0x00004035
		public AnyPlayerEvent(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x060064EA RID: 25834 RVA: 0x00196265 File Offset: 0x00194465
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.AnyPlayerEvent>.NativeClassPtr));
			}
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x00196276 File Offset: 0x00194476
		public static implicit operator WarPlayerScript.AnyPlayerEvent(Action<WarPlayerScript, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<WarPlayerScript.AnyPlayerEvent>(A_0);
		}

		// Token: 0x060064EC RID: 25836 RVA: 0x0019627E File Offset: 0x0019447E
		public static WarPlayerScript.AnyPlayerEvent operator +(WarPlayerScript.AnyPlayerEvent A_0, WarPlayerScript.AnyPlayerEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<WarPlayerScript.AnyPlayerEvent>();
		}

		// Token: 0x060064ED RID: 25837 RVA: 0x0019628C File Offset: 0x0019448C
		public static WarPlayerScript.AnyPlayerEvent operator -(WarPlayerScript.AnyPlayerEvent A_0, WarPlayerScript.AnyPlayerEvent A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<WarPlayerScript.AnyPlayerEvent>();
			}
			return result;
		}

		// Token: 0x04003FCA RID: 16330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003FCB RID: 16331
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_Boolean_0;

		// Token: 0x04003FCC RID: 16332
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_Boolean_AsyncCallback_Object_0;

		// Token: 0x04003FCD RID: 16333
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020004D4 RID: 1236
	public sealed class SpecificPlayerEvent : MulticastDelegate
	{
		// Token: 0x060064EE RID: 25838 RVA: 0x001962A0 File Offset: 0x001944A0
		[CallerCount(0)]
		public unsafe SpecificPlayerEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript.SpecificPlayerEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.SpecificPlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x00196318 File Offset: 0x00194518
		[CallerCount(0)]
		public unsafe void Invoke(WarPlayerScript player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.SpecificPlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x00196374 File Offset: 0x00194574
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(WarPlayerScript player, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.SpecificPlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x00196414 File Offset: 0x00194614
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.SpecificPlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x00196470 File Offset: 0x00194670
		// Note: this type is marked as 'beforefieldinit'.
		static SpecificPlayerEvent()
		{
			Il2CppClassPointerStore<WarPlayerScript.SpecificPlayerEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "SpecificPlayerEvent");
			WarPlayerScript.SpecificPlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.SpecificPlayerEvent>.NativeClassPtr, 100671346);
			WarPlayerScript.SpecificPlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.SpecificPlayerEvent>.NativeClassPtr, 100671347);
			WarPlayerScript.SpecificPlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.SpecificPlayerEvent>.NativeClassPtr, 100671348);
			WarPlayerScript.SpecificPlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.SpecificPlayerEvent>.NativeClassPtr, 100671349);
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x00005E35 File Offset: 0x00004035
		public SpecificPlayerEvent(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x060064F4 RID: 25844 RVA: 0x001964E1 File Offset: 0x001946E1
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.SpecificPlayerEvent>.NativeClassPtr));
			}
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x001964F2 File Offset: 0x001946F2
		public static implicit operator WarPlayerScript.SpecificPlayerEvent(Action<WarPlayerScript> A_0)
		{
			return DelegateSupport.ConvertDelegate<WarPlayerScript.SpecificPlayerEvent>(A_0);
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x001964FA File Offset: 0x001946FA
		public static WarPlayerScript.SpecificPlayerEvent operator +(WarPlayerScript.SpecificPlayerEvent A_0, WarPlayerScript.SpecificPlayerEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<WarPlayerScript.SpecificPlayerEvent>();
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x00196508 File Offset: 0x00194708
		public static WarPlayerScript.SpecificPlayerEvent operator -(WarPlayerScript.SpecificPlayerEvent A_0, WarPlayerScript.SpecificPlayerEvent A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<WarPlayerScript.SpecificPlayerEvent>();
			}
			return result;
		}

		// Token: 0x04003FCE RID: 16334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003FCF RID: 16335
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_WarPlayerScript_0;

		// Token: 0x04003FD0 RID: 16336
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WarPlayerScript_AsyncCallback_Object_0;

		// Token: 0x04003FD1 RID: 16337
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020004D5 RID: 1237
	public sealed class PlayerEvent : MulticastDelegate
	{
		// Token: 0x060064F8 RID: 25848 RVA: 0x0019651C File Offset: 0x0019471C
		[CallerCount(0)]
		public unsafe PlayerEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript.PlayerEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x00196594 File Offset: 0x00194794
		[CallerCount(0)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x001965D8 File Offset: 0x001947D8
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x00196660 File Offset: 0x00194860
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x001966BC File Offset: 0x001948BC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEvent()
		{
			Il2CppClassPointerStore<WarPlayerScript.PlayerEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "PlayerEvent");
			WarPlayerScript.PlayerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerEvent>.NativeClassPtr, 100671350);
			WarPlayerScript.PlayerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerEvent>.NativeClassPtr, 100671351);
			WarPlayerScript.PlayerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerEvent>.NativeClassPtr, 100671352);
			WarPlayerScript.PlayerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerEvent>.NativeClassPtr, 100671353);
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x00005E35 File Offset: 0x00004035
		public PlayerEvent(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x060064FE RID: 25854 RVA: 0x0019672D File Offset: 0x0019492D
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.PlayerEvent>.NativeClassPtr));
			}
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x0019673E File Offset: 0x0019493E
		public static implicit operator WarPlayerScript.PlayerEvent(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<WarPlayerScript.PlayerEvent>(A_0);
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x00196746 File Offset: 0x00194946
		public static WarPlayerScript.PlayerEvent operator +(WarPlayerScript.PlayerEvent A_0, WarPlayerScript.PlayerEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<WarPlayerScript.PlayerEvent>();
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x00196754 File Offset: 0x00194954
		public static WarPlayerScript.PlayerEvent operator -(WarPlayerScript.PlayerEvent A_0, WarPlayerScript.PlayerEvent A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<WarPlayerScript.PlayerEvent>();
			}
			return result;
		}

		// Token: 0x04003FD2 RID: 16338
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003FD3 RID: 16339
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		// Token: 0x04003FD4 RID: 16340
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04003FD5 RID: 16341
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020004D6 RID: 1238
	public sealed class PlayerCustomPropEvent : MulticastDelegate
	{
		// Token: 0x06006502 RID: 25858 RVA: 0x00196768 File Offset: 0x00194968
		[CallerCount(0)]
		public unsafe PlayerCustomPropEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript.PlayerCustomPropEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerCustomPropEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x001967E0 File Offset: 0x001949E0
		[CallerCount(0)]
		public unsafe void Invoke(DPIPlayer player, DPIHashtable hashTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashTable);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerCustomPropEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DPIPlayer_DPIHashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x00196854 File Offset: 0x00194A54
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(DPIPlayer player, DPIHashtable hashTable, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hashTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerCustomPropEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DPIPlayer_DPIHashtable_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x0019690C File Offset: 0x00194B0C
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.PlayerCustomPropEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006506 RID: 25862 RVA: 0x00196968 File Offset: 0x00194B68
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerCustomPropEvent()
		{
			Il2CppClassPointerStore<WarPlayerScript.PlayerCustomPropEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "PlayerCustomPropEvent");
			WarPlayerScript.PlayerCustomPropEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerCustomPropEvent>.NativeClassPtr, 100671354);
			WarPlayerScript.PlayerCustomPropEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DPIPlayer_DPIHashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerCustomPropEvent>.NativeClassPtr, 100671355);
			WarPlayerScript.PlayerCustomPropEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DPIPlayer_DPIHashtable_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerCustomPropEvent>.NativeClassPtr, 100671356);
			WarPlayerScript.PlayerCustomPropEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.PlayerCustomPropEvent>.NativeClassPtr, 100671357);
		}

		// Token: 0x06006507 RID: 25863 RVA: 0x00005E35 File Offset: 0x00004035
		public PlayerCustomPropEvent(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x06006508 RID: 25864 RVA: 0x001969D9 File Offset: 0x00194BD9
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.PlayerCustomPropEvent>.NativeClassPtr));
			}
		}

		// Token: 0x06006509 RID: 25865 RVA: 0x001969EA File Offset: 0x00194BEA
		public static implicit operator WarPlayerScript.PlayerCustomPropEvent(Action<DPIPlayer, DPIHashtable> A_0)
		{
			return DelegateSupport.ConvertDelegate<WarPlayerScript.PlayerCustomPropEvent>(A_0);
		}

		// Token: 0x0600650A RID: 25866 RVA: 0x001969F2 File Offset: 0x00194BF2
		public static WarPlayerScript.PlayerCustomPropEvent operator +(WarPlayerScript.PlayerCustomPropEvent A_0, WarPlayerScript.PlayerCustomPropEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<WarPlayerScript.PlayerCustomPropEvent>();
		}

		// Token: 0x0600650B RID: 25867 RVA: 0x00196A00 File Offset: 0x00194C00
		public static WarPlayerScript.PlayerCustomPropEvent operator -(WarPlayerScript.PlayerCustomPropEvent A_0, WarPlayerScript.PlayerCustomPropEvent A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<WarPlayerScript.PlayerCustomPropEvent>();
			}
			return result;
		}

		// Token: 0x04003FD6 RID: 16342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003FD7 RID: 16343
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DPIPlayer_DPIHashtable_0;

		// Token: 0x04003FD8 RID: 16344
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DPIPlayer_DPIHashtable_AsyncCallback_Object_0;

		// Token: 0x04003FD9 RID: 16345
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020004D7 RID: 1239
	[Serializable]
	[StructLayout(0)]
	public sealed class DeviceGloveSettings : ValueType
	{
		// Token: 0x0600650C RID: 25868 RVA: 0x00196A14 File Offset: 0x00194C14
		// Note: this type is marked as 'beforefieldinit'.
		static DeviceGloveSettings()
		{
			Il2CppClassPointerStore<WarPlayerScript.DeviceGloveSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "DeviceGloveSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript.DeviceGloveSettings>.NativeClassPtr);
			WarPlayerScript.DeviceGloveSettings.NativeFieldInfoPtr_Devices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.DeviceGloveSettings>.NativeClassPtr, "Devices");
			WarPlayerScript.DeviceGloveSettings.NativeFieldInfoPtr_GlovesMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.DeviceGloveSettings>.NativeClassPtr, "GlovesMaterial");
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x0002717B File Offset: 0x0002537B
		public DeviceGloveSettings(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x0600650E RID: 25870 RVA: 0x00196A67 File Offset: 0x00194C67
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.DeviceGloveSettings>.NativeClassPtr));
			}
		}

		// Token: 0x0600650F RID: 25871 RVA: 0x00196A78 File Offset: 0x00194C78
		public unsafe DeviceGloveSettings()
		{
			IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WarPlayerScript.DeviceGloveSettings>.NativeClassPtr, (UIntPtr)0)];
			base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WarPlayerScript.DeviceGloveSettings>.NativeClassPtr, data));
		}

		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x06006510 RID: 25872 RVA: 0x00196AA8 File Offset: 0x00194CA8
		// (set) Token: 0x06006511 RID: 25873 RVA: 0x00196AD0 File Offset: 0x00194CD0
		public unsafe DeviceTypeFlag Devices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.DeviceGloveSettings.NativeFieldInfoPtr_Devices);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.DeviceGloveSettings.NativeFieldInfoPtr_Devices)) = value;
			}
		}

		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x06006512 RID: 25874 RVA: 0x00196AF4 File Offset: 0x00194CF4
		// (set) Token: 0x06006513 RID: 25875 RVA: 0x00196B28 File Offset: 0x00194D28
		public unsafe AssetReference GlovesMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.DeviceGloveSettings.NativeFieldInfoPtr_GlovesMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AssetReference(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.DeviceGloveSettings.NativeFieldInfoPtr_GlovesMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FDA RID: 16346
		private static readonly IntPtr NativeFieldInfoPtr_Devices;

		// Token: 0x04003FDB RID: 16347
		private static readonly IntPtr NativeFieldInfoPtr_GlovesMaterial;
	}

	// Token: 0x020004D8 RID: 1240
	[ObfuscatedName("WarPlayerScript/Δδδ_S_RPC_ApplyTaserDamage")]
	[StructLayout(0)]
	public sealed class ValueTypeNPrivateSealedINetworkStreamableDPInInUnique : ValueType
	{
		// Token: 0x06006514 RID: 25876 RVA: 0x00196B50 File Offset: 0x00194D50
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x00196BA8 File Offset: 0x00194DA8
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006516 RID: 25878 RVA: 0x00196C00 File Offset: 0x00194E00
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableDPInInUnique()
		{
			Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_S_RPC_ApplyTaserDamage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique>.NativeClassPtr);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique.NativeFieldInfoPtr_field_Public_DPIPlayer_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique>.NativeClassPtr, "Δδδ_I_shooterOther");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique.NativeFieldInfoPtr_field_Public_Int32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique>.NativeClassPtr, "Δδδ_I_AISourceID");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique.NativeFieldInfoPtr_field_Public_Int32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique>.NativeClassPtr, "Δδδ_I_tasingItemID");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique>.NativeClassPtr, 100671358);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique>.NativeClassPtr, 100671359);
		}

		// Token: 0x06006517 RID: 25879 RVA: 0x0002717B File Offset: 0x0002537B
		public ValueTypeNPrivateSealedINetworkStreamableDPInInUnique(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023CF RID: 9167
		// (get) Token: 0x06006518 RID: 25880 RVA: 0x00196C8F File Offset: 0x00194E8F
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique>.NativeClassPtr));
			}
		}

		// Token: 0x06006519 RID: 25881 RVA: 0x00196CA0 File Offset: 0x00194EA0
		public unsafe ValueTypeNPrivateSealedINetworkStreamableDPInInUnique()
		{
			IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique>.NativeClassPtr, (UIntPtr)0)];
			base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique>.NativeClassPtr, data));
		}

		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x0600651A RID: 25882 RVA: 0x00196CD0 File Offset: 0x00194ED0
		// (set) Token: 0x0600651B RID: 25883 RVA: 0x00196D04 File Offset: 0x00194F04
		public unsafe DPIPlayer field_Public_DPIPlayer_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique.NativeFieldInfoPtr_field_Public_DPIPlayer_0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new DPIPlayer(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique.NativeFieldInfoPtr_field_Public_DPIPlayer_0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x0600651C RID: 25884 RVA: 0x00196D2C File Offset: 0x00194F2C
		// (set) Token: 0x0600651D RID: 25885 RVA: 0x00196D54 File Offset: 0x00194F54
		public unsafe int field_Public_Int32_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique.NativeFieldInfoPtr_field_Public_Int32_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique.NativeFieldInfoPtr_field_Public_Int32_0)) = value;
			}
		}

		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x0600651E RID: 25886 RVA: 0x00196D78 File Offset: 0x00194F78
		// (set) Token: 0x0600651F RID: 25887 RVA: 0x00196DA0 File Offset: 0x00194FA0
		public unsafe int field_Public_Int32_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique.NativeFieldInfoPtr_field_Public_Int32_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPInInUnique.NativeFieldInfoPtr_field_Public_Int32_1)) = value;
			}
		}

		// Token: 0x04003FDC RID: 16348
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_DPIPlayer_0;

		// Token: 0x04003FDD RID: 16349
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_0;

		// Token: 0x04003FDE RID: 16350
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_1;

		// Token: 0x04003FDF RID: 16351
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04003FE0 RID: 16352
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;
	}

	// Token: 0x020004D9 RID: 1241
	[ObfuscatedName("WarPlayerScript/Δδδ_S_RPC_Heal")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedINetworkStreamableInUnique
	{
		// Token: 0x06006520 RID: 25888 RVA: 0x00196DC4 File Offset: 0x00194FC4
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006521 RID: 25889 RVA: 0x00196E10 File Offset: 0x00195010
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x00196E5C File Offset: 0x0019505C
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableInUnique()
		{
			Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_S_RPC_Heal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique.NativeFieldInfoPtr_field_Public_Int32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr, "Δδδ_I_healingItemID");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr, 100671360);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr, 100671361);
		}

		// Token: 0x06006523 RID: 25891 RVA: 0x00196EC3 File Offset: 0x001950C3
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr, ref this));
		}

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x06006524 RID: 25892 RVA: 0x00196ED5 File Offset: 0x001950D5
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInUnique>.NativeClassPtr));
			}
		}

		// Token: 0x04003FE1 RID: 16353
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_0;

		// Token: 0x04003FE2 RID: 16354
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04003FE3 RID: 16355
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04003FE4 RID: 16356
		[FieldOffset(0)]
		public int field_Public_Int32_0;
	}

	// Token: 0x020004DA RID: 1242
	[ObfuscatedName("WarPlayerScript/Δδδ_S_RPC_HealRemote")]
	[StructLayout(0)]
	public sealed class ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique : ValueType
	{
		// Token: 0x06006525 RID: 25893 RVA: 0x00196EE8 File Offset: 0x001950E8
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x00196F40 File Offset: 0x00195140
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006527 RID: 25895 RVA: 0x00196F98 File Offset: 0x00195198
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique()
		{
			Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_S_RPC_HealRemote");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique>.NativeClassPtr);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeFieldInfoPtr_field_Public_Int32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique>.NativeClassPtr, "Δδδ_I_healingItemID");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeFieldInfoPtr_field_Public_Int32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique>.NativeClassPtr, "Δδδ_I_endState");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeFieldInfoPtr_field_Public_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique>.NativeClassPtr, "Δδδ_I_endBleedingState");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeFieldInfoPtr_field_Public_DPIPlayer_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique>.NativeClassPtr, "Δδδ_I_healingSource");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique>.NativeClassPtr, 100671362);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique>.NativeClassPtr, 100671363);
		}

		// Token: 0x06006528 RID: 25896 RVA: 0x0002717B File Offset: 0x0002537B
		public ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x06006529 RID: 25897 RVA: 0x0019703B File Offset: 0x0019523B
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique>.NativeClassPtr));
			}
		}

		// Token: 0x0600652A RID: 25898 RVA: 0x0019704C File Offset: 0x0019524C
		public unsafe ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique()
		{
			IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique>.NativeClassPtr, (UIntPtr)0)];
			base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique>.NativeClassPtr, data));
		}

		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x0600652B RID: 25899 RVA: 0x0019707C File Offset: 0x0019527C
		// (set) Token: 0x0600652C RID: 25900 RVA: 0x001970A4 File Offset: 0x001952A4
		public unsafe int field_Public_Int32_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeFieldInfoPtr_field_Public_Int32_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeFieldInfoPtr_field_Public_Int32_0)) = value;
			}
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x0600652D RID: 25901 RVA: 0x001970C8 File Offset: 0x001952C8
		// (set) Token: 0x0600652E RID: 25902 RVA: 0x001970F0 File Offset: 0x001952F0
		public unsafe int field_Public_Int32_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeFieldInfoPtr_field_Public_Int32_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeFieldInfoPtr_field_Public_Int32_1)) = value;
			}
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x0600652F RID: 25903 RVA: 0x00197114 File Offset: 0x00195314
		// (set) Token: 0x06006530 RID: 25904 RVA: 0x0019713C File Offset: 0x0019533C
		public unsafe bool field_Public_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeFieldInfoPtr_field_Public_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeFieldInfoPtr_field_Public_Boolean_0)) = value;
			}
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x06006531 RID: 25905 RVA: 0x00197160 File Offset: 0x00195360
		// (set) Token: 0x06006532 RID: 25906 RVA: 0x00197194 File Offset: 0x00195394
		public unsafe DPIPlayer field_Public_DPIPlayer_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeFieldInfoPtr_field_Public_DPIPlayer_0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new DPIPlayer(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableInBoInDPUnique.NativeFieldInfoPtr_field_Public_DPIPlayer_0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FE5 RID: 16357
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_0;

		// Token: 0x04003FE6 RID: 16358
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_1;

		// Token: 0x04003FE7 RID: 16359
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Boolean_0;

		// Token: 0x04003FE8 RID: 16360
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_DPIPlayer_0;

		// Token: 0x04003FE9 RID: 16361
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04003FEA RID: 16362
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;
	}

	// Token: 0x020004DB RID: 1243
	[ObfuscatedName("WarPlayerScript/Δδδ_S_RPC_SetArmorHP")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedINetworkStreamableSiUnique
	{
		// Token: 0x06006533 RID: 25907 RVA: 0x001971BC File Offset: 0x001953BC
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x00197208 File Offset: 0x00195408
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x00197254 File Offset: 0x00195454
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableSiUnique()
		{
			Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_S_RPC_SetArmorHP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique>.NativeClassPtr);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique.NativeFieldInfoPtr_field_Public_Single_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique>.NativeClassPtr, "Δδδ_I_newHP");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique>.NativeClassPtr, 100671364);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique>.NativeClassPtr, 100671365);
		}

		// Token: 0x06006536 RID: 25910 RVA: 0x001972BB File Offset: 0x001954BB
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique>.NativeClassPtr, ref this));
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x06006537 RID: 25911 RVA: 0x001972CD File Offset: 0x001954CD
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiUnique>.NativeClassPtr));
			}
		}

		// Token: 0x04003FEB RID: 16363
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Single_0;

		// Token: 0x04003FEC RID: 16364
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04003FED RID: 16365
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04003FEE RID: 16366
		[FieldOffset(0)]
		public float field_Public_Single_0;
	}

	// Token: 0x020004DC RID: 1244
	[ObfuscatedName("WarPlayerScript/Δδδ_S_RPC_SetHP")]
	[StructLayout(0)]
	public sealed class ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique : ValueType
	{
		// Token: 0x06006538 RID: 25912 RVA: 0x001972E0 File Offset: 0x001954E0
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x00197338 File Offset: 0x00195538
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x00197390 File Offset: 0x00195590
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique()
		{
			Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_S_RPC_SetHP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Single_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, "Δδδ_I_newHp");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_DPIPlayer_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, "Δδδ_I_playerSource");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Int32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, "Δδδ_I_aiSourceID");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Vector3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, "Δδδ_I_hitPos");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Vector3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, "Δδδ_I_shootPos");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, "Δδδ_I_isDead");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Int32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, "Δδδ_I_damagedPart");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Single_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, "Δδδ_I_damage");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Int32_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, "Δδδ_I_damageType");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Int32_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, "Δδδ_I_weaponName");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, 100671366);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, 100671367);
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x0002717B File Offset: 0x0002537B
		public ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x0600653C RID: 25916 RVA: 0x001974AB File Offset: 0x001956AB
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr));
			}
		}

		// Token: 0x0600653D RID: 25917 RVA: 0x001974BC File Offset: 0x001956BC
		public unsafe ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique()
		{
			IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, (UIntPtr)0)];
			base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique>.NativeClassPtr, data));
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x0600653E RID: 25918 RVA: 0x001974EC File Offset: 0x001956EC
		// (set) Token: 0x0600653F RID: 25919 RVA: 0x00197514 File Offset: 0x00195714
		public unsafe float field_Public_Single_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Single_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Single_0)) = value;
			}
		}

		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x06006540 RID: 25920 RVA: 0x00197538 File Offset: 0x00195738
		// (set) Token: 0x06006541 RID: 25921 RVA: 0x0019756C File Offset: 0x0019576C
		public unsafe DPIPlayer field_Public_DPIPlayer_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_DPIPlayer_0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new DPIPlayer(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_DPIPlayer_0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x06006542 RID: 25922 RVA: 0x00197594 File Offset: 0x00195794
		// (set) Token: 0x06006543 RID: 25923 RVA: 0x001975BC File Offset: 0x001957BC
		public unsafe int field_Public_Int32_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Int32_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Int32_0)) = value;
			}
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x06006544 RID: 25924 RVA: 0x001975E0 File Offset: 0x001957E0
		// (set) Token: 0x06006545 RID: 25925 RVA: 0x00197608 File Offset: 0x00195808
		public unsafe Vector3 field_Public_Vector3_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Vector3_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Vector3_0)) = value;
			}
		}

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x06006546 RID: 25926 RVA: 0x0019762C File Offset: 0x0019582C
		// (set) Token: 0x06006547 RID: 25927 RVA: 0x00197654 File Offset: 0x00195854
		public unsafe Vector3 field_Public_Vector3_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Vector3_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Vector3_1)) = value;
			}
		}

		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x06006548 RID: 25928 RVA: 0x00197678 File Offset: 0x00195878
		// (set) Token: 0x06006549 RID: 25929 RVA: 0x001976A0 File Offset: 0x001958A0
		public unsafe bool field_Public_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Boolean_0)) = value;
			}
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x0600654A RID: 25930 RVA: 0x001976C4 File Offset: 0x001958C4
		// (set) Token: 0x0600654B RID: 25931 RVA: 0x001976EC File Offset: 0x001958EC
		public unsafe int field_Public_Int32_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Int32_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Int32_1)) = value;
			}
		}

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x0600654C RID: 25932 RVA: 0x00197710 File Offset: 0x00195910
		// (set) Token: 0x0600654D RID: 25933 RVA: 0x00197738 File Offset: 0x00195938
		public unsafe float field_Public_Single_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Single_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Single_1)) = value;
			}
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x0600654E RID: 25934 RVA: 0x0019775C File Offset: 0x0019595C
		// (set) Token: 0x0600654F RID: 25935 RVA: 0x00197784 File Offset: 0x00195984
		public unsafe int field_Public_Int32_2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Int32_2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Int32_2)) = value;
			}
		}

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x06006550 RID: 25936 RVA: 0x001977A8 File Offset: 0x001959A8
		// (set) Token: 0x06006551 RID: 25937 RVA: 0x001977D0 File Offset: 0x001959D0
		public unsafe int field_Public_Int32_3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Int32_3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiDPInVeBoVeInSiInInUnique.NativeFieldInfoPtr_field_Public_Int32_3)) = value;
			}
		}

		// Token: 0x04003FEF RID: 16367
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Single_0;

		// Token: 0x04003FF0 RID: 16368
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_DPIPlayer_0;

		// Token: 0x04003FF1 RID: 16369
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_0;

		// Token: 0x04003FF2 RID: 16370
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Vector3_0;

		// Token: 0x04003FF3 RID: 16371
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Vector3_1;

		// Token: 0x04003FF4 RID: 16372
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Boolean_0;

		// Token: 0x04003FF5 RID: 16373
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_1;

		// Token: 0x04003FF6 RID: 16374
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Single_1;

		// Token: 0x04003FF7 RID: 16375
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_2;

		// Token: 0x04003FF8 RID: 16376
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Int32_3;

		// Token: 0x04003FF9 RID: 16377
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04003FFA RID: 16378
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;
	}

	// Token: 0x020004DD RID: 1245
	[ObfuscatedName("WarPlayerScript/Δδδ_S_RPC_UpdateMe")]
	[StructLayout(0)]
	public sealed class ValueTypeNPrivateSealedINetworkStreamableDPUnique : ValueType
	{
		// Token: 0x06006552 RID: 25938 RVA: 0x001977F4 File Offset: 0x001959F4
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x0019784C File Offset: 0x00195A4C
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x001978A4 File Offset: 0x00195AA4
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableDPUnique()
		{
			Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_S_RPC_UpdateMe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique>.NativeClassPtr);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique.NativeFieldInfoPtr_field_Public_DPIPlayer_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique>.NativeClassPtr, "Δδδ_I_requestFrom");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique>.NativeClassPtr, 100671368);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique>.NativeClassPtr, 100671369);
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x0002717B File Offset: 0x0002537B
		public ValueTypeNPrivateSealedINetworkStreamableDPUnique(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x06006556 RID: 25942 RVA: 0x0019790B File Offset: 0x00195B0B
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique>.NativeClassPtr));
			}
		}

		// Token: 0x06006557 RID: 25943 RVA: 0x0019791C File Offset: 0x00195B1C
		public unsafe ValueTypeNPrivateSealedINetworkStreamableDPUnique()
		{
			IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique>.NativeClassPtr, (UIntPtr)0)];
			base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique>.NativeClassPtr, data));
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x06006558 RID: 25944 RVA: 0x0019794C File Offset: 0x00195B4C
		// (set) Token: 0x06006559 RID: 25945 RVA: 0x00197980 File Offset: 0x00195B80
		public unsafe DPIPlayer field_Public_DPIPlayer_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique.NativeFieldInfoPtr_field_Public_DPIPlayer_0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new DPIPlayer(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableDPUnique.NativeFieldInfoPtr_field_Public_DPIPlayer_0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FFB RID: 16379
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_DPIPlayer_0;

		// Token: 0x04003FFC RID: 16380
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04003FFD RID: 16381
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;
	}

	// Token: 0x020004DE RID: 1246
	[ObfuscatedName("WarPlayerScript/Δδδ_S_RPC_ThisPlayerState")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique
	{
		// Token: 0x0600655A RID: 25946 RVA: 0x001979A8 File Offset: 0x00195BA8
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600655B RID: 25947 RVA: 0x001979F4 File Offset: 0x00195BF4
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x00197A40 File Offset: 0x00195C40
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique()
		{
			Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_S_RPC_ThisPlayerState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique>.NativeClassPtr);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique.NativeFieldInfoPtr_field_Public_Single_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique>.NativeClassPtr, "Δδδ_I_realHp");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique.NativeFieldInfoPtr_field_Public_Single_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique>.NativeClassPtr, "Δδδ_I_armorHP");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique.NativeFieldInfoPtr_field_Public_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique>.NativeClassPtr, "Δδδ_I_isDead");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique.NativeFieldInfoPtr_field_Public_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique>.NativeClassPtr, "Δδδ_I_realspawn");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique.NativeFieldInfoPtr_field_Public_Vector3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique>.NativeClassPtr, "Δδδ_I_pos");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique.NativeFieldInfoPtr_field_Public_Boolean_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique>.NativeClassPtr, "Δδδ_I_isragdoll");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique>.NativeClassPtr, 100671370);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique>.NativeClassPtr, 100671371);
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x00197B0B File Offset: 0x00195D0B
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique>.NativeClassPtr, ref this));
		}

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x0600655E RID: 25950 RVA: 0x00197B1D File Offset: 0x00195D1D
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableSiBoSiVeBoBoUnique>.NativeClassPtr));
			}
		}

		// Token: 0x04003FFE RID: 16382
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Single_0;

		// Token: 0x04003FFF RID: 16383
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Single_1;

		// Token: 0x04004000 RID: 16384
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Boolean_0;

		// Token: 0x04004001 RID: 16385
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Boolean_1;

		// Token: 0x04004002 RID: 16386
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Vector3_0;

		// Token: 0x04004003 RID: 16387
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Boolean_2;

		// Token: 0x04004004 RID: 16388
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04004005 RID: 16389
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04004006 RID: 16390
		[FieldOffset(0)]
		public float field_Public_Single_0;

		// Token: 0x04004007 RID: 16391
		[FieldOffset(4)]
		public float field_Public_Single_1;

		// Token: 0x04004008 RID: 16392
		[FieldOffset(8)]
		public bool field_Public_Boolean_0;

		// Token: 0x04004009 RID: 16393
		[FieldOffset(9)]
		public bool field_Public_Boolean_1;

		// Token: 0x0400400A RID: 16394
		[FieldOffset(12)]
		public Vector3 field_Public_Vector3_0;

		// Token: 0x0400400B RID: 16395
		[FieldOffset(24)]
		public bool field_Public_Boolean_2;
	}

	// Token: 0x020004DF RID: 1247
	[ObfuscatedName("WarPlayerScript/Δδδ_S_RPC_TinitusMe")]
	[StructLayout(2, Size = 1)]
	public struct ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0
	{
		// Token: 0x0600655F RID: 25951 RVA: 0x00197B30 File Offset: 0x00195D30
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x00197B7C File Offset: 0x00195D7C
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006561 RID: 25953 RVA: 0x00197BC8 File Offset: 0x00195DC8
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0()
		{
			Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_S_RPC_TinitusMe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0>.NativeClassPtr);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0>.NativeClassPtr, 100671372);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0>.NativeClassPtr, 100671373);
		}

		// Token: 0x06006562 RID: 25954 RVA: 0x00197C1B File Offset: 0x00195E1B
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0>.NativeClassPtr, ref this));
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x06006563 RID: 25955 RVA: 0x00197C2D File Offset: 0x00195E2D
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP0>.NativeClassPtr));
			}
		}

		// Token: 0x0400400C RID: 16396
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x0400400D RID: 16397
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;
	}

	// Token: 0x020004E0 RID: 1248
	[ObfuscatedName("WarPlayerScript/Δδδ_S_RPC_ManualInvincibility")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0
	{
		// Token: 0x06006564 RID: 25956 RVA: 0x00197C40 File Offset: 0x00195E40
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x00197C8C File Offset: 0x00195E8C
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x00197CD8 File Offset: 0x00195ED8
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0()
		{
			Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_S_RPC_ManualInvincibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0>.NativeClassPtr);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0.NativeFieldInfoPtr_field_Public_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0>.NativeClassPtr, "Δδδ_I_invincible");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0>.NativeClassPtr, 100671374);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0>.NativeClassPtr, 100671375);
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x00197D3F File Offset: 0x00195F3F
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0>.NativeClassPtr, ref this));
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x06006568 RID: 25960 RVA: 0x00197D51 File Offset: 0x00195F51
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP0>.NativeClassPtr));
			}
		}

		// Token: 0x0400400E RID: 16398
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Boolean_0;

		// Token: 0x0400400F RID: 16399
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04004010 RID: 16400
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04004011 RID: 16401
		[FieldOffset(0)]
		public bool field_Public_Boolean_0;
	}

	// Token: 0x020004E1 RID: 1249
	[ObfuscatedName("WarPlayerScript/Δδδ_S_RPC_Targetability")]
	[StructLayout(2)]
	public struct ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1
	{
		// Token: 0x06006569 RID: 25961 RVA: 0x00197D64 File Offset: 0x00195F64
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x00197DB0 File Offset: 0x00195FB0
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x00197DFC File Offset: 0x00195FFC
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1()
		{
			Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_S_RPC_Targetability");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1>.NativeClassPtr);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1.NativeFieldInfoPtr_field_Public_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1>.NativeClassPtr, "Δδδ_I_targetable");
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1>.NativeClassPtr, 100671376);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1>.NativeClassPtr, 100671377);
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x00197E63 File Offset: 0x00196063
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1>.NativeClassPtr, ref this));
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x0600656D RID: 25965 RVA: 0x00197E75 File Offset: 0x00196075
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableBoReVoneDPWrVoneDP1>.NativeClassPtr));
			}
		}

		// Token: 0x04004012 RID: 16402
		private static readonly IntPtr NativeFieldInfoPtr_field_Public_Boolean_0;

		// Token: 0x04004013 RID: 16403
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04004014 RID: 16404
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04004015 RID: 16405
		[FieldOffset(0)]
		public bool field_Public_Boolean_0;
	}

	// Token: 0x020004E2 RID: 1250
	[ObfuscatedName("WarPlayerScript/Δδδ_S_RPC_AIWhistle")]
	[StructLayout(2, Size = 1)]
	public struct ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1
	{
		// Token: 0x0600656E RID: 25966 RVA: 0x00197E88 File Offset: 0x00196088
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600656F RID: 25967 RVA: 0x00197ED4 File Offset: 0x001960D4
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006570 RID: 25968 RVA: 0x00197F20 File Offset: 0x00196120
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1()
		{
			Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "Δδδ_S_RPC_AIWhistle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1>.NativeClassPtr);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1>.NativeClassPtr, 100671378);
			WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1>.NativeClassPtr, 100671379);
		}

		// Token: 0x06006571 RID: 25969 RVA: 0x00197F73 File Offset: 0x00196173
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1>.NativeClassPtr, ref this));
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x06006572 RID: 25970 RVA: 0x00197F85 File Offset: 0x00196185
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.ValueTypeNPrivateSealedINetworkStreamableReVoneDPWrVoneDP1>.NativeClassPtr));
			}
		}

		// Token: 0x04004016 RID: 16406
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x04004017 RID: 16407
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;
	}

	// Token: 0x020004E3 RID: 1251
	[ObfuscatedName("WarPlayerScript/<AddCameraIn>d__194")]
	public sealed class _AddCameraIn_d__194 : Il2CppSystem.Object
	{
		// Token: 0x06006573 RID: 25971 RVA: 0x00197F98 File Offset: 0x00196198
		[CallerCount(0)]
		public unsafe _AddCameraIn_d__194(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript._AddCameraIn_d__194>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._AddCameraIn_d__194.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x00197FF8 File Offset: 0x001961F8
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._AddCameraIn_d__194.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006575 RID: 25973 RVA: 0x0019803C File Offset: 0x0019623C
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._AddCameraIn_d__194.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x06006576 RID: 25974 RVA: 0x0019808C File Offset: 0x0019628C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._AddCameraIn_d__194.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06006577 RID: 25975 RVA: 0x001980E4 File Offset: 0x001962E4
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._AddCameraIn_d__194.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x06006578 RID: 25976 RVA: 0x00198128 File Offset: 0x00196328
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._AddCameraIn_d__194.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x00198180 File Offset: 0x00196380
		// Note: this type is marked as 'beforefieldinit'.
		static _AddCameraIn_d__194()
		{
			Il2CppClassPointerStore<WarPlayerScript._AddCameraIn_d__194>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "<AddCameraIn>d__194");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript._AddCameraIn_d__194>.NativeClassPtr);
			WarPlayerScript._AddCameraIn_d__194.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._AddCameraIn_d__194>.NativeClassPtr, "<>1__state");
			WarPlayerScript._AddCameraIn_d__194.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._AddCameraIn_d__194>.NativeClassPtr, "<>2__current");
			WarPlayerScript._AddCameraIn_d__194.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._AddCameraIn_d__194>.NativeClassPtr, "<>4__this");
			WarPlayerScript._AddCameraIn_d__194.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._AddCameraIn_d__194>.NativeClassPtr, 100671380);
			WarPlayerScript._AddCameraIn_d__194.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._AddCameraIn_d__194>.NativeClassPtr, 100671381);
			WarPlayerScript._AddCameraIn_d__194.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._AddCameraIn_d__194>.NativeClassPtr, 100671382);
			WarPlayerScript._AddCameraIn_d__194.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._AddCameraIn_d__194>.NativeClassPtr, 100671383);
			WarPlayerScript._AddCameraIn_d__194.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._AddCameraIn_d__194>.NativeClassPtr, 100671384);
			WarPlayerScript._AddCameraIn_d__194.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._AddCameraIn_d__194>.NativeClassPtr, 100671385);
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x00002988 File Offset: 0x00000B88
		public _AddCameraIn_d__194(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x0600657B RID: 25979 RVA: 0x0019825F File Offset: 0x0019645F
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript._AddCameraIn_d__194>.NativeClassPtr));
			}
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x0600657C RID: 25980 RVA: 0x00198270 File Offset: 0x00196470
		// (set) Token: 0x0600657D RID: 25981 RVA: 0x00198298 File Offset: 0x00196498
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._AddCameraIn_d__194.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._AddCameraIn_d__194.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x0600657E RID: 25982 RVA: 0x001982BC File Offset: 0x001964BC
		// (set) Token: 0x0600657F RID: 25983 RVA: 0x001982F0 File Offset: 0x001964F0
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._AddCameraIn_d__194.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._AddCameraIn_d__194.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x06006580 RID: 25984 RVA: 0x00198318 File Offset: 0x00196518
		// (set) Token: 0x06006581 RID: 25985 RVA: 0x0019834C File Offset: 0x0019654C
		public unsafe WarPlayerScript __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._AddCameraIn_d__194.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new WarPlayerScript(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._AddCameraIn_d__194.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004018 RID: 16408
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004019 RID: 16409
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400401A RID: 16410
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400401B RID: 16411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400401C RID: 16412
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400401D RID: 16413
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400401E RID: 16414
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400401F RID: 16415
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004020 RID: 16416
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020004E4 RID: 1252
	[ObfuscatedName("WarPlayerScript/<DeathTransition>d__248")]
	public sealed class _DeathTransition_d__248 : Il2CppSystem.Object
	{
		// Token: 0x06006582 RID: 25986 RVA: 0x00198374 File Offset: 0x00196574
		[CallerCount(0)]
		public unsafe _DeathTransition_d__248(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._DeathTransition_d__248.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006583 RID: 25987 RVA: 0x001983D4 File Offset: 0x001965D4
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._DeathTransition_d__248.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006584 RID: 25988 RVA: 0x00198418 File Offset: 0x00196618
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._DeathTransition_d__248.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x06006585 RID: 25989 RVA: 0x00198468 File Offset: 0x00196668
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._DeathTransition_d__248.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06006586 RID: 25990 RVA: 0x001984C0 File Offset: 0x001966C0
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._DeathTransition_d__248.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x06006587 RID: 25991 RVA: 0x00198504 File Offset: 0x00196704
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._DeathTransition_d__248.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06006588 RID: 25992 RVA: 0x0019855C File Offset: 0x0019675C
		// Note: this type is marked as 'beforefieldinit'.
		static _DeathTransition_d__248()
		{
			Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "<DeathTransition>d__248");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr);
			WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr, "<>1__state");
			WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr, "<>2__current");
			WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr, "<>4__this");
			WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr__finalNetworkTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr, "<finalNetworkTime>5__2");
			WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr__delay_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr, "<delay>5__3");
			WarPlayerScript._DeathTransition_d__248.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr, 100671386);
			WarPlayerScript._DeathTransition_d__248.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr, 100671387);
			WarPlayerScript._DeathTransition_d__248.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr, 100671388);
			WarPlayerScript._DeathTransition_d__248.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr, 100671389);
			WarPlayerScript._DeathTransition_d__248.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr, 100671390);
			WarPlayerScript._DeathTransition_d__248.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr, 100671391);
		}

		// Token: 0x06006589 RID: 25993 RVA: 0x00002988 File Offset: 0x00000B88
		public _DeathTransition_d__248(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x0600658A RID: 25994 RVA: 0x00198663 File Offset: 0x00196863
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript._DeathTransition_d__248>.NativeClassPtr));
			}
		}

		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x0600658B RID: 25995 RVA: 0x00198674 File Offset: 0x00196874
		// (set) Token: 0x0600658C RID: 25996 RVA: 0x0019869C File Offset: 0x0019689C
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x0600658D RID: 25997 RVA: 0x001986C0 File Offset: 0x001968C0
		// (set) Token: 0x0600658E RID: 25998 RVA: 0x001986F4 File Offset: 0x001968F4
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x0600658F RID: 25999 RVA: 0x0019871C File Offset: 0x0019691C
		// (set) Token: 0x06006590 RID: 26000 RVA: 0x00198750 File Offset: 0x00196950
		public unsafe WarPlayerScript __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new WarPlayerScript(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x06006591 RID: 26001 RVA: 0x00198778 File Offset: 0x00196978
		// (set) Token: 0x06006592 RID: 26002 RVA: 0x001987A0 File Offset: 0x001969A0
		public unsafe double _finalNetworkTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr__finalNetworkTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr__finalNetworkTime_5__2)) = value;
			}
		}

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x06006593 RID: 26003 RVA: 0x001987C4 File Offset: 0x001969C4
		// (set) Token: 0x06006594 RID: 26004 RVA: 0x001987EC File Offset: 0x001969EC
		public unsafe float _delay_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr__delay_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DeathTransition_d__248.NativeFieldInfoPtr__delay_5__3)) = value;
			}
		}

		// Token: 0x04004021 RID: 16417
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004022 RID: 16418
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004023 RID: 16419
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004024 RID: 16420
		private static readonly IntPtr NativeFieldInfoPtr__finalNetworkTime_5__2;

		// Token: 0x04004025 RID: 16421
		private static readonly IntPtr NativeFieldInfoPtr__delay_5__3;

		// Token: 0x04004026 RID: 16422
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004027 RID: 16423
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004028 RID: 16424
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004029 RID: 16425
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400402A RID: 16426
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400402B RID: 16427
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020004E5 RID: 1253
	[ObfuscatedName("WarPlayerScript/<BleedOut>d__249")]
	public sealed class _BleedOut_d__249 : Il2CppSystem.Object
	{
		// Token: 0x06006595 RID: 26005 RVA: 0x00198810 File Offset: 0x00196A10
		[CallerCount(0)]
		public unsafe _BleedOut_d__249(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._BleedOut_d__249.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006596 RID: 26006 RVA: 0x00198870 File Offset: 0x00196A70
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._BleedOut_d__249.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006597 RID: 26007 RVA: 0x001988B4 File Offset: 0x00196AB4
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._BleedOut_d__249.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x06006598 RID: 26008 RVA: 0x00198904 File Offset: 0x00196B04
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._BleedOut_d__249.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06006599 RID: 26009 RVA: 0x0019895C File Offset: 0x00196B5C
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._BleedOut_d__249.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x0600659A RID: 26010 RVA: 0x001989A0 File Offset: 0x00196BA0
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._BleedOut_d__249.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x0600659B RID: 26011 RVA: 0x001989F8 File Offset: 0x00196BF8
		// Note: this type is marked as 'beforefieldinit'.
		static _BleedOut_d__249()
		{
			Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "<BleedOut>d__249");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr);
			WarPlayerScript._BleedOut_d__249.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr, "<>1__state");
			WarPlayerScript._BleedOut_d__249.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr, "<>2__current");
			WarPlayerScript._BleedOut_d__249.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr, "<>4__this");
			WarPlayerScript._BleedOut_d__249.NativeFieldInfoPtr_waitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr, "waitTime");
			WarPlayerScript._BleedOut_d__249.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr, 100671392);
			WarPlayerScript._BleedOut_d__249.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr, 100671393);
			WarPlayerScript._BleedOut_d__249.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr, 100671394);
			WarPlayerScript._BleedOut_d__249.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr, 100671395);
			WarPlayerScript._BleedOut_d__249.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr, 100671396);
			WarPlayerScript._BleedOut_d__249.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr, 100671397);
		}

		// Token: 0x0600659C RID: 26012 RVA: 0x00002988 File Offset: 0x00000B88
		public _BleedOut_d__249(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x0600659D RID: 26013 RVA: 0x00198AEB File Offset: 0x00196CEB
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript._BleedOut_d__249>.NativeClassPtr));
			}
		}

		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x0600659E RID: 26014 RVA: 0x00198AFC File Offset: 0x00196CFC
		// (set) Token: 0x0600659F RID: 26015 RVA: 0x00198B24 File Offset: 0x00196D24
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._BleedOut_d__249.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._BleedOut_d__249.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x060065A0 RID: 26016 RVA: 0x00198B48 File Offset: 0x00196D48
		// (set) Token: 0x060065A1 RID: 26017 RVA: 0x00198B7C File Offset: 0x00196D7C
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._BleedOut_d__249.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._BleedOut_d__249.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x060065A2 RID: 26018 RVA: 0x00198BA4 File Offset: 0x00196DA4
		// (set) Token: 0x060065A3 RID: 26019 RVA: 0x00198BD8 File Offset: 0x00196DD8
		public unsafe WarPlayerScript __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._BleedOut_d__249.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new WarPlayerScript(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._BleedOut_d__249.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x060065A4 RID: 26020 RVA: 0x00198C00 File Offset: 0x00196E00
		// (set) Token: 0x060065A5 RID: 26021 RVA: 0x00198C28 File Offset: 0x00196E28
		public unsafe float waitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._BleedOut_d__249.NativeFieldInfoPtr_waitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._BleedOut_d__249.NativeFieldInfoPtr_waitTime)) = value;
			}
		}

		// Token: 0x0400402C RID: 16428
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400402D RID: 16429
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400402E RID: 16430
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400402F RID: 16431
		private static readonly IntPtr NativeFieldInfoPtr_waitTime;

		// Token: 0x04004030 RID: 16432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004031 RID: 16433
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004032 RID: 16434
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004033 RID: 16435
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004034 RID: 16436
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004035 RID: 16437
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020004E6 RID: 1254
	[ObfuscatedName("WarPlayerScript/<>c__DisplayClass258_0")]
	public sealed class __c__DisplayClass258_0 : Il2CppSystem.Object
	{
		// Token: 0x060065A6 RID: 26022 RVA: 0x00198C4C File Offset: 0x00196E4C
		[CallerCount(0)]
		public unsafe __c__DisplayClass258_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript.__c__DisplayClass258_0>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.__c__DisplayClass258_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065A7 RID: 26023 RVA: 0x00198C98 File Offset: 0x00196E98
		[CallerCount(0)]
		public unsafe void _UpdateHandModels_b__0(Material obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript.__c__DisplayClass258_0.NativeMethodInfoPtr__UpdateHandModels_b__0_Internal_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065A8 RID: 26024 RVA: 0x00198CF4 File Offset: 0x00196EF4
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass258_0()
		{
			Il2CppClassPointerStore<WarPlayerScript.__c__DisplayClass258_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "<>c__DisplayClass258_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript.__c__DisplayClass258_0>.NativeClassPtr);
			WarPlayerScript.__c__DisplayClass258_0.NativeFieldInfoPtr_localHandSMR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.__c__DisplayClass258_0>.NativeClassPtr, "localHandSMR");
			WarPlayerScript.__c__DisplayClass258_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.__c__DisplayClass258_0>.NativeClassPtr, "<>4__this");
			WarPlayerScript.__c__DisplayClass258_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript.__c__DisplayClass258_0>.NativeClassPtr, "<>9__0");
			WarPlayerScript.__c__DisplayClass258_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.__c__DisplayClass258_0>.NativeClassPtr, 100671398);
			WarPlayerScript.__c__DisplayClass258_0.NativeMethodInfoPtr__UpdateHandModels_b__0_Internal_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript.__c__DisplayClass258_0>.NativeClassPtr, 100671399);
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x00002988 File Offset: 0x00000B88
		public __c__DisplayClass258_0(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x060065AA RID: 26026 RVA: 0x00198D83 File Offset: 0x00196F83
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript.__c__DisplayClass258_0>.NativeClassPtr));
			}
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x060065AB RID: 26027 RVA: 0x00198D94 File Offset: 0x00196F94
		// (set) Token: 0x060065AC RID: 26028 RVA: 0x00198DC8 File Offset: 0x00196FC8
		public unsafe SkinnedMeshRenderer localHandSMR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.__c__DisplayClass258_0.NativeFieldInfoPtr_localHandSMR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new SkinnedMeshRenderer(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.__c__DisplayClass258_0.NativeFieldInfoPtr_localHandSMR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x060065AD RID: 26029 RVA: 0x00198DF0 File Offset: 0x00196FF0
		// (set) Token: 0x060065AE RID: 26030 RVA: 0x00198E24 File Offset: 0x00197024
		public unsafe WarPlayerScript __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.__c__DisplayClass258_0.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new WarPlayerScript(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.__c__DisplayClass258_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002404 RID: 9220
		// (get) Token: 0x060065AF RID: 26031 RVA: 0x00198E4C File Offset: 0x0019704C
		// (set) Token: 0x060065B0 RID: 26032 RVA: 0x00198E80 File Offset: 0x00197080
		public unsafe Action<Material> __9__0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.__c__DisplayClass258_0.NativeFieldInfoPtr___9__0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Action<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript.__c__DisplayClass258_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004036 RID: 16438
		private static readonly IntPtr NativeFieldInfoPtr_localHandSMR;

		// Token: 0x04004037 RID: 16439
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004038 RID: 16440
		private static readonly IntPtr NativeFieldInfoPtr___9__0;

		// Token: 0x04004039 RID: 16441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400403A RID: 16442
		private static readonly IntPtr NativeMethodInfoPtr__UpdateHandModels_b__0_Internal_Void_Material_0;
	}

	// Token: 0x020004E7 RID: 1255
	[ObfuscatedName("WarPlayerScript/<FlashStart>d__264")]
	public sealed class _FlashStart_d__264 : Il2CppSystem.Object
	{
		// Token: 0x060065B1 RID: 26033 RVA: 0x00198EA8 File Offset: 0x001970A8
		[CallerCount(0)]
		public unsafe _FlashStart_d__264(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript._FlashStart_d__264>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._FlashStart_d__264.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x00198F08 File Offset: 0x00197108
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._FlashStart_d__264.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x00198F4C File Offset: 0x0019714C
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._FlashStart_d__264.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x060065B4 RID: 26036 RVA: 0x00198F9C File Offset: 0x0019719C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._FlashStart_d__264.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060065B5 RID: 26037 RVA: 0x00198FF4 File Offset: 0x001971F4
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._FlashStart_d__264.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x1700240A RID: 9226
		// (get) Token: 0x060065B6 RID: 26038 RVA: 0x00199038 File Offset: 0x00197238
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._FlashStart_d__264.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x00199090 File Offset: 0x00197290
		// Note: this type is marked as 'beforefieldinit'.
		static _FlashStart_d__264()
		{
			Il2CppClassPointerStore<WarPlayerScript._FlashStart_d__264>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "<FlashStart>d__264");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript._FlashStart_d__264>.NativeClassPtr);
			WarPlayerScript._FlashStart_d__264.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._FlashStart_d__264>.NativeClassPtr, "<>1__state");
			WarPlayerScript._FlashStart_d__264.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._FlashStart_d__264>.NativeClassPtr, "<>2__current");
			WarPlayerScript._FlashStart_d__264.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._FlashStart_d__264>.NativeClassPtr, "<>4__this");
			WarPlayerScript._FlashStart_d__264.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._FlashStart_d__264>.NativeClassPtr, 100671400);
			WarPlayerScript._FlashStart_d__264.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._FlashStart_d__264>.NativeClassPtr, 100671401);
			WarPlayerScript._FlashStart_d__264.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._FlashStart_d__264>.NativeClassPtr, 100671402);
			WarPlayerScript._FlashStart_d__264.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._FlashStart_d__264>.NativeClassPtr, 100671403);
			WarPlayerScript._FlashStart_d__264.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._FlashStart_d__264>.NativeClassPtr, 100671404);
			WarPlayerScript._FlashStart_d__264.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._FlashStart_d__264>.NativeClassPtr, 100671405);
		}

		// Token: 0x060065B8 RID: 26040 RVA: 0x00002988 File Offset: 0x00000B88
		public _FlashStart_d__264(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002405 RID: 9221
		// (get) Token: 0x060065B9 RID: 26041 RVA: 0x0019916F File Offset: 0x0019736F
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript._FlashStart_d__264>.NativeClassPtr));
			}
		}

		// Token: 0x17002406 RID: 9222
		// (get) Token: 0x060065BA RID: 26042 RVA: 0x00199180 File Offset: 0x00197380
		// (set) Token: 0x060065BB RID: 26043 RVA: 0x001991A8 File Offset: 0x001973A8
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._FlashStart_d__264.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._FlashStart_d__264.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002407 RID: 9223
		// (get) Token: 0x060065BC RID: 26044 RVA: 0x001991CC File Offset: 0x001973CC
		// (set) Token: 0x060065BD RID: 26045 RVA: 0x00199200 File Offset: 0x00197400
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._FlashStart_d__264.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._FlashStart_d__264.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x060065BE RID: 26046 RVA: 0x00199228 File Offset: 0x00197428
		// (set) Token: 0x060065BF RID: 26047 RVA: 0x0019925C File Offset: 0x0019745C
		public unsafe WarPlayerScript __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._FlashStart_d__264.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new WarPlayerScript(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._FlashStart_d__264.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400403B RID: 16443
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400403C RID: 16444
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400403D RID: 16445
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400403E RID: 16446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400403F RID: 16447
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004040 RID: 16448
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004041 RID: 16449
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004042 RID: 16450
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004043 RID: 16451
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020004E8 RID: 1256
	[ObfuscatedName("WarPlayerScript/<DelayDisableTinitus>d__266")]
	public sealed class _DelayDisableTinitus_d__266 : Il2CppSystem.Object
	{
		// Token: 0x060065C0 RID: 26048 RVA: 0x00199284 File Offset: 0x00197484
		[CallerCount(0)]
		public unsafe _DelayDisableTinitus_d__266(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarPlayerScript._DelayDisableTinitus_d__266>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._DelayDisableTinitus_d__266.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x001992E4 File Offset: 0x001974E4
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._DelayDisableTinitus_d__266.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x00199328 File Offset: 0x00197528
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._DelayDisableTinitus_d__266.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x060065C3 RID: 26051 RVA: 0x00199378 File Offset: 0x00197578
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._DelayDisableTinitus_d__266.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x001993D0 File Offset: 0x001975D0
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._DelayDisableTinitus_d__266.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x060065C5 RID: 26053 RVA: 0x00199414 File Offset: 0x00197614
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarPlayerScript._DelayDisableTinitus_d__266.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x0019946C File Offset: 0x0019766C
		// Note: this type is marked as 'beforefieldinit'.
		static _DelayDisableTinitus_d__266()
		{
			Il2CppClassPointerStore<WarPlayerScript._DelayDisableTinitus_d__266>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarPlayerScript>.NativeClassPtr, "<DelayDisableTinitus>d__266");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarPlayerScript._DelayDisableTinitus_d__266>.NativeClassPtr);
			WarPlayerScript._DelayDisableTinitus_d__266.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._DelayDisableTinitus_d__266>.NativeClassPtr, "<>1__state");
			WarPlayerScript._DelayDisableTinitus_d__266.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._DelayDisableTinitus_d__266>.NativeClassPtr, "<>2__current");
			WarPlayerScript._DelayDisableTinitus_d__266.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarPlayerScript._DelayDisableTinitus_d__266>.NativeClassPtr, "<>4__this");
			WarPlayerScript._DelayDisableTinitus_d__266.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._DelayDisableTinitus_d__266>.NativeClassPtr, 100671406);
			WarPlayerScript._DelayDisableTinitus_d__266.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._DelayDisableTinitus_d__266>.NativeClassPtr, 100671407);
			WarPlayerScript._DelayDisableTinitus_d__266.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._DelayDisableTinitus_d__266>.NativeClassPtr, 100671408);
			WarPlayerScript._DelayDisableTinitus_d__266.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._DelayDisableTinitus_d__266>.NativeClassPtr, 100671409);
			WarPlayerScript._DelayDisableTinitus_d__266.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._DelayDisableTinitus_d__266>.NativeClassPtr, 100671410);
			WarPlayerScript._DelayDisableTinitus_d__266.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarPlayerScript._DelayDisableTinitus_d__266>.NativeClassPtr, 100671411);
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x00002988 File Offset: 0x00000B88
		public _DelayDisableTinitus_d__266(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x060065C8 RID: 26056 RVA: 0x0019954B File Offset: 0x0019774B
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WarPlayerScript._DelayDisableTinitus_d__266>.NativeClassPtr));
			}
		}

		// Token: 0x1700240C RID: 9228
		// (get) Token: 0x060065C9 RID: 26057 RVA: 0x0019955C File Offset: 0x0019775C
		// (set) Token: 0x060065CA RID: 26058 RVA: 0x00199584 File Offset: 0x00197784
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DelayDisableTinitus_d__266.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DelayDisableTinitus_d__266.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x1700240D RID: 9229
		// (get) Token: 0x060065CB RID: 26059 RVA: 0x001995A8 File Offset: 0x001977A8
		// (set) Token: 0x060065CC RID: 26060 RVA: 0x001995DC File Offset: 0x001977DC
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DelayDisableTinitus_d__266.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DelayDisableTinitus_d__266.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x060065CD RID: 26061 RVA: 0x00199604 File Offset: 0x00197804
		// (set) Token: 0x060065CE RID: 26062 RVA: 0x00199638 File Offset: 0x00197838
		public unsafe WarPlayerScript __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DelayDisableTinitus_d__266.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new WarPlayerScript(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarPlayerScript._DelayDisableTinitus_d__266.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004044 RID: 16452
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004045 RID: 16453
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004046 RID: 16454
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004047 RID: 16455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004048 RID: 16456
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004049 RID: 16457
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400404A RID: 16458
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400404B RID: 16459
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400404C RID: 16460
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
