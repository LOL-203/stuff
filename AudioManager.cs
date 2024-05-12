using System;
using System.Runtime.InteropServices;
using AK.Wwise;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Onward.Audio;
using Onward.Scenes;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000136 RID: 310
public class AudioManager : MonoBehaviour
{
	// Token: 0x170006D7 RID: 1751
	// (get) Token: 0x06001381 RID: 4993 RVA: 0x0004ECE4 File Offset: 0x0004CEE4
	// (set) Token: 0x06001382 RID: 4994 RVA: 0x0004ED2C File Offset: 0x0004CF2C
	public unsafe static AudioManager Singleton
	{
		[CallerCount(0)]
		get
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_Singleton_Public_Static_get_AudioManager_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new AudioManager(intPtr2) : null;
		}
		[CallerCount(0)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_set_Singleton_Public_Static_set_Void_AudioManager_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x170006D8 RID: 1752
	// (get) Token: 0x06001383 RID: 4995 RVA: 0x0004ED78 File Offset: 0x0004CF78
	// (set) Token: 0x06001384 RID: 4996 RVA: 0x0004EDBC File Offset: 0x0004CFBC
	public unsafe static bool IsInitialized
	{
		[CallerCount(0)]
		get
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_IsInitialized_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_set_IsInitialized_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x0004EE04 File Offset: 0x0004D004
	[CallerCount(0)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x0004EE48 File Offset: 0x0004D048
	[CallerCount(0)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001387 RID: 4999 RVA: 0x0004EE8C File Offset: 0x0004D08C
	[CallerCount(0)]
	public unsafe IEnumerator InitializeAfterStartupBankLoads()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_InitializeAfterStartupBankLoads_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x0004EEE4 File Offset: 0x0004D0E4
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001389 RID: 5001 RVA: 0x0004EF28 File Offset: 0x0004D128
	[CallerCount(0)]
	public unsafe void OnApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600138A RID: 5002 RVA: 0x0004EF6C File Offset: 0x0004D16C
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600138B RID: 5003 RVA: 0x0004EFB0 File Offset: 0x0004D1B0
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x170006D9 RID: 1753
	// (get) Token: 0x0600138C RID: 5004 RVA: 0x0004EFF4 File Offset: 0x0004D1F4
	// (set) Token: 0x0600138D RID: 5005 RVA: 0x0004F044 File Offset: 0x0004D244
	public unsafe bool ManagedLateUpdateRemoval
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_ManagedLateUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_set_ManagedLateUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x0004F098 File Offset: 0x0004D298
	[CallerCount(0)]
	public unsafe void OnManagedLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_OnManagedLateUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600138F RID: 5007 RVA: 0x0004F0DC File Offset: 0x0004D2DC
	[CallerCount(0)]
	public unsafe void OnTentStateChange(bool isInTent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref isInTent;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_OnTentStateChange_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x0004F130 File Offset: 0x0004D330
	[CallerCount(0)]
	public unsafe static float GetCurrentVolumePreferences([In] ref AudioManager.MixBusType type)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = &type;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_GetCurrentVolumePreferences_Public_Static_Single_byref_MixBusType_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x0004F184 File Offset: 0x0004D384
	[CallerCount(0)]
	public unsafe static void SaveVolumePreferences([In] ref AudioManager.MixBusType type, float value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = &type;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SaveVolumePreferences_Public_Static_Void_byref_MixBusType_Single_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x0004F1E0 File Offset: 0x0004D3E0
	[CallerCount(0)]
	public unsafe static void UpdateVolumesAndMix()
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_UpdateVolumesAndMix_Public_Static_Void_0, 0, (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x0004F214 File Offset: 0x0004D414
	[CallerCount(0)]
	public unsafe static void SetMixingPreset(int playerPrefValue)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref playerPrefValue;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetMixingPreset_Public_Static_Void_Int32_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001394 RID: 5012 RVA: 0x0004F25C File Offset: 0x0004D45C
	[CallerCount(0)]
	public unsafe void StartBankLoad(Bank bank)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bank);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_StartBankLoad_Private_Void_Bank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001395 RID: 5013 RVA: 0x0004F2B8 File Offset: 0x0004D4B8
	[CallerCount(0)]
	public unsafe void UnloadBank(Bank bank)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bank);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_UnloadBank_Private_Void_Bank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x0004F314 File Offset: 0x0004D514
	[CallerCount(0)]
	public unsafe bool AreAllBankLoadsFinished()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_AreAllBankLoadsFinished_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x0004F364 File Offset: 0x0004D564
	[CallerCount(0)]
	public unsafe bool IsStartupBankLoading()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_IsStartupBankLoading_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x0004F3B4 File Offset: 0x0004D5B4
	[CallerCount(0)]
	public unsafe IEnumerator StartTransitionToSceneAsync(SceneData nextScene, bool isInLoadScreen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextScene);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInLoadScreen;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_StartTransitionToSceneAsync_Public_IEnumerator_SceneData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x0004F434 File Offset: 0x0004D634
	[CallerCount(0)]
	public unsafe IEnumerator FinishTransitionToSceneAsync(SceneData nextScene)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextScene);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_FinishTransitionToSceneAsync_Public_IEnumerator_SceneData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x0004F4A4 File Offset: 0x0004D6A4
	[CallerCount(0)]
	public unsafe void DisableAllReverbBuses()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_DisableAllReverbBuses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x0004F4E8 File Offset: 0x0004D6E8
	[CallerCount(0)]
	public unsafe void UpdateUsedReverbBuses()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_UpdateUsedReverbBuses_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x0004F52C File Offset: 0x0004D72C
	[CallerCount(0)]
	public unsafe void EnqueueForDeferredAcoustingsUpdate(GameObject gameObject, bool useObstruction = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useObstruction;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_EnqueueForDeferredAcoustingsUpdate_Private_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x0004F598 File Offset: 0x0004D798
	[CallerCount(0)]
	public unsafe void UpdateListenerIfRequired()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_UpdateListenerIfRequired_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x0004F5DC File Offset: 0x0004D7DC
	[CallerCount(0)]
	public unsafe void PerformDeferredAcousticsUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_PerformDeferredAcousticsUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x0004F620 File Offset: 0x0004D820
	[CallerCount(0)]
	public unsafe void PerformAcousticsUpdate(GameObject obj, bool useObstruction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useObstruction;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_PerformAcousticsUpdate_Private_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013A0 RID: 5024 RVA: 0x0004F68C File Offset: 0x0004D88C
	[CallerCount(0)]
	public unsafe void SetReverbSendsAndOutdoorness(GameObject obj, AudioManager.ReverbBusType emitterReverbBus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref emitterReverbBus;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetReverbSendsAndOutdoorness_Public_Void_GameObject_ReverbBusType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013A1 RID: 5025 RVA: 0x0004F6F8 File Offset: 0x0004D8F8
	[CallerCount(0)]
	public unsafe void PlayLoadingMusic(Switch loadingMusicTrackSelectionSwitch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(loadingMusicTrackSelectionSwitch);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_PlayLoadingMusic_Public_Void_Switch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x0004F754 File Offset: 0x0004D954
	[CallerCount(0)]
	public unsafe void PlayTentMusic(Switch tentMusicTrackSelectionSwitch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tentMusicTrackSelectionSwitch);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_PlayTentMusic_Public_Void_Switch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013A3 RID: 5027 RVA: 0x0004F7B0 File Offset: 0x0004D9B0
	[CallerCount(0)]
	public unsafe void PlayMainMenuMusic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_PlayMainMenuMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013A4 RID: 5028 RVA: 0x0004F7F4 File Offset: 0x0004D9F4
	[CallerCount(0)]
	public unsafe void PlayRoundStartMusic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_PlayRoundStartMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x0004F838 File Offset: 0x0004DA38
	[CallerCount(0)]
	public unsafe void PlayRoundVictoryMusic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_PlayRoundVictoryMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x0004F87C File Offset: 0x0004DA7C
	[CallerCount(0)]
	public unsafe void PlayRoundDefeatMusic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_PlayRoundDefeatMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013A7 RID: 5031 RVA: 0x0004F8C0 File Offset: 0x0004DAC0
	[CallerCount(0)]
	public unsafe bool IsRoundEndMusicPlaying()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_IsRoundEndMusicPlaying_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x0004F910 File Offset: 0x0004DB10
	[CallerCount(0)]
	public unsafe bool IsTentMusicPlaying()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_IsTentMusicPlaying_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x0004F960 File Offset: 0x0004DB60
	[CallerCount(0)]
	public unsafe void PlayEvacMusic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_PlayEvacMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x0004F9A4 File Offset: 0x0004DBA4
	[CallerCount(0)]
	public unsafe void StopMusic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_StopMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x0004F9E8 File Offset: 0x0004DBE8
	[CallerCount(0)]
	public unsafe void StartGlobalAmbients()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_StartGlobalAmbients_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x0004FA2C File Offset: 0x0004DC2C
	[CallerCount(0)]
	public unsafe void StopGlobalAmbients()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_StopGlobalAmbients_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x0004FA70 File Offset: 0x0004DC70
	[CallerCount(0)]
	public unsafe void RegisterWeaponBankUser(WeaponName weaponName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref weaponName;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_RegisterWeaponBankUser_Public_Void_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x0004FAC4 File Offset: 0x0004DCC4
	[CallerCount(0)]
	public unsafe void UnregisterWeaponBankUser(WeaponName weaponName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref weaponName;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_UnregisterWeaponBankUser_Public_Void_WeaponName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x0004FB18 File Offset: 0x0004DD18
	[CallerCount(0)]
	public unsafe void SetMaterialSwitch(GameObject gameObject, DamageLibrary.MaterialType materialType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref materialType;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetMaterialSwitch_Public_Void_GameObject_MaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x0004FB84 File Offset: 0x0004DD84
	[CallerCount(0)]
	public unsafe AKRESULT SetObjectPosition(GameObject gameObject, Transform transform, bool useObstruction = true, bool useDeferredUpdate = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useObstruction;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDeferredUpdate;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetObjectPosition_Public_AKRESULT_GameObject_Transform_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060013B1 RID: 5041 RVA: 0x0004FC2C File Offset: 0x0004DE2C
	[CallerCount(0)]
	public unsafe AKRESULT SetObjectPosition(GameObject gameObject, float posX, float posY, float posZ, float frontX, float frontY, float frontZ, float topX, float topY, float topZ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posX;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posY;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posZ;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frontX;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frontY;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frontZ;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topX;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topY;
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topZ;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetObjectPosition_Public_AKRESULT_GameObject_Single_Single_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060013B2 RID: 5042 RVA: 0x0004FD40 File Offset: 0x0004DF40
	[CallerCount(0)]
	public unsafe AKRESULT SetObjectPosition(GameObject gameObject, Vector3 position, Vector3 forward, Vector3 up, bool useObstruction = true, bool useDeferredUpdate = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forward;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref up;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useObstruction;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useDeferredUpdate;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetObjectPosition_Public_AKRESULT_GameObject_Vector3_Vector3_Vector3_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060013B3 RID: 5043 RVA: 0x0004FE08 File Offset: 0x0004E008
	[CallerCount(0)]
	public unsafe void PostDetachedEventAt(AK.Wwise.Event wwisePlayEvent, Vector3 position, Vector3 forward, Vector3 up)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wwisePlayEvent);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forward;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref up;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_PostDetachedEventAt_Public_Void_Event_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x0004FE9C File Offset: 0x0004E09C
	[CallerCount(0)]
	public unsafe void PostDetachedEventAt(AK.Wwise.Event wwisePlayEvent, Vector3 position, Vector3 forward, Vector3 up, DamageLibrary.MaterialType materialType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wwisePlayEvent);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forward;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref up;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref materialType;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_PostDetachedEventAt_Public_Void_Event_Vector3_Vector3_Vector3_MaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013B5 RID: 5045 RVA: 0x0004FF44 File Offset: 0x0004E144
	[CallerCount(0)]
	public unsafe void PostDetachedEventAt(AK.Wwise.Event wwisePlayEvent, Vector3 position, Vector3 forward, Vector3 up, uint rtpc, float rtpcValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(wwisePlayEvent);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forward;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref up;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rtpc;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rtpcValue;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_PostDetachedEventAt_Public_Void_Event_Vector3_Vector3_Vector3_UInt32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x0004FFFC File Offset: 0x0004E1FC
	[CallerCount(0)]
	public unsafe bool IsEventPlayingOnGameObject(AK.Wwise.Event eventToCheck, GameObject go)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventToCheck);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_IsEventPlayingOnGameObject_Public_Boolean_Event_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060013B7 RID: 5047 RVA: 0x0005007C File Offset: 0x0004E27C
	[CallerCount(0)]
	public unsafe bool IsAnyEventPlayingOnGameObject(GameObject go)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_IsAnyEventPlayingOnGameObject_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x000500E4 File Offset: 0x0004E2E4
	[CallerCount(0)]
	public unsafe void ToggleMuteGame(bool isMuting)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref isMuting;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_ToggleMuteGame_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x00050138 File Offset: 0x0004E338
	[CallerCount(0)]
	public unsafe ulong GetUInt64HashCode(string strText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strText);
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_GetUInt64HashCode_Public_UInt64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x000501A0 File Offset: 0x0004E3A0
	[CallerCount(0)]
	public unsafe void Log(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_Log_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x000501FC File Offset: 0x0004E3FC
	[CallerCount(0)]
	public unsafe void LogState(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_LogState_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x00050258 File Offset: 0x0004E458
	[CallerCount(0)]
	public unsafe void LogMusic(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_LogMusic_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013BD RID: 5053 RVA: 0x000502B4 File Offset: 0x0004E4B4
	[CallerCount(0)]
	public unsafe void LogLoading(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_LogLoading_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013BE RID: 5054 RVA: 0x00050310 File Offset: 0x0004E510
	[CallerCount(0)]
	public unsafe void LogReverb(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_LogReverb_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x0005036C File Offset: 0x0004E56C
	[CallerCount(0)]
	public unsafe void LogVoip(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_LogVoip_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x000503C8 File Offset: 0x0004E5C8
	[CallerCount(0)]
	public unsafe void LogMovement(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_LogMovement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x00050424 File Offset: 0x0004E624
	[CallerCount(0)]
	public unsafe void LogError(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_LogError_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x00050480 File Offset: 0x0004E680
	[CallerCount(0)]
	public unsafe void LogWarning(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_LogWarning_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x000504DC File Offset: 0x0004E6DC
	[CallerCount(0)]
	public unsafe void LogErrorNoSpam(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_LogErrorNoSpam_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x00050538 File Offset: 0x0004E738
	[CallerCount(0)]
	public unsafe void LogWarningNoSpam(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_LogWarningNoSpam_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x00050594 File Offset: 0x0004E794
	[CallerCount(0)]
	public unsafe AudioManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioManager>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x000505E0 File Offset: 0x0004E7E0
	// Note: this type is marked as 'beforefieldinit'.
	static AudioManager()
	{
		Il2CppClassPointerStore<AudioManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AudioManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioManager>.NativeClassPtr);
		AudioManager.NativeFieldInfoPtr_DetachedGameObjectPoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "DetachedGameObjectPoolSize");
		AudioManager.NativeFieldInfoPtr_AcousticsUpdateArrayMaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "AcousticsUpdateArrayMaxSize");
		AudioManager.NativeFieldInfoPtr_ReverbBusTypeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "ReverbBusTypeCount");
		AudioManager.NativeFieldInfoPtr_AudioReverbLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "AudioReverbLayerMask");
		AudioManager.NativeFieldInfoPtr_isInitializing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "isInitializing");
		AudioManager.NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "isInitialized");
		AudioManager.NativeFieldInfoPtr_m_Singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "m_Singleton");
		AudioManager.NativeFieldInfoPtr_OnListenerMuffleZoneChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "OnListenerMuffleZoneChanged");
		AudioManager.NativeFieldInfoPtr_OnListenerReverbZoneChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "OnListenerReverbZoneChanged");
		AudioManager.NativeFieldInfoPtr_OculusPCWwiseOutputHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "OculusPCWwiseOutputHandler");
		AudioManager.NativeFieldInfoPtr_StartupBank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "StartupBank");
		AudioManager.NativeFieldInfoPtr_MainBank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MainBank");
		AudioManager.NativeFieldInfoPtr_AmbiencesBank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "AmbiencesBank");
		AudioManager.NativeFieldInfoPtr_MusicBank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MusicBank");
		AudioManager.NativeFieldInfoPtr_WeaponsGenericBank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "WeaponsGenericBank");
		AudioManager.NativeFieldInfoPtr_VOIPBank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "VOIPBank");
		AudioManager.NativeFieldInfoPtr_weaponSoundBankLibrary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "weaponSoundBankLibrary");
		AudioManager.NativeFieldInfoPtr_loadingMusicPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "loadingMusicPlayEvent");
		AudioManager.NativeFieldInfoPtr_menuMusicPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "menuMusicPlayEvent");
		AudioManager.NativeFieldInfoPtr_tentMusicPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "tentMusicPlayEvent");
		AudioManager.NativeFieldInfoPtr_roundStartMusicPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "roundStartMusicPlayEvent");
		AudioManager.NativeFieldInfoPtr_roundVictoryMusicPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "roundVictoryMusicPlayEvent");
		AudioManager.NativeFieldInfoPtr_roundDefeatMusicPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "roundDefeatMusicPlayEvent");
		AudioManager.NativeFieldInfoPtr_evacMusicPlayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "evacMusicPlayEvent");
		AudioManager.NativeFieldInfoPtr_musicStopEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "musicStopEvent");
		AudioManager.NativeFieldInfoPtr_emitterReverbBusMixAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "emitterReverbBusMixAmount");
		AudioManager.NativeFieldInfoPtr_listenerReverbBusMixAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "listenerReverbBusMixAmount");
		AudioManager.NativeFieldInfoPtr_defaultGlobalAmbientState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "defaultGlobalAmbientState");
		AudioManager.NativeFieldInfoPtr_logLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "logLoading");
		AudioManager.NativeFieldInfoPtr_logState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "logState");
		AudioManager.NativeFieldInfoPtr_logMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "logMusic");
		AudioManager.NativeFieldInfoPtr_logReverb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "logReverb");
		AudioManager.NativeFieldInfoPtr_logVoip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "logVoip");
		AudioManager.NativeFieldInfoPtr_logMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "logMovement");
		AudioManager.NativeFieldInfoPtr_VOLUME_MAX_BOOST_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "VOLUME_MAX_BOOST_VALUE");
		AudioManager.NativeFieldInfoPtr_VOLUME_MAX_REDUCTION_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "VOLUME_MAX_REDUCTION_VALUE");
		AudioManager.NativeFieldInfoPtr_playingIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "playingIds");
		AudioManager.NativeFieldInfoPtr_reverbColliderResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "reverbColliderResults");
		AudioManager.NativeFieldInfoPtr_reverbBusTypeToWwiseBusId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "reverbBusTypeToWwiseBusId");
		AudioManager.NativeFieldInfoPtr_reverbAuxSendValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "reverbAuxSendValues");
		AudioManager.NativeFieldInfoPtr_currentListenerMuffleZoneGroupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "currentListenerMuffleZoneGroupId");
		AudioManager.NativeFieldInfoPtr_currentListenerReverbBus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "currentListenerReverbBus");
		AudioManager.NativeFieldInfoPtr_currentGlobalAmbientState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "currentGlobalAmbientState");
		AudioManager.NativeFieldInfoPtr_listenerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "listenerObject");
		AudioManager.NativeFieldInfoPtr_defaultReverbBus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "defaultReverbBus");
		AudioManager.NativeFieldInfoPtr_needListenerZoneUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "needListenerZoneUpdate");
		AudioManager.NativeFieldInfoPtr_acousticsUpdateArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "acousticsUpdateArray");
		AudioManager.NativeFieldInfoPtr_acousticsUpdateArraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "acousticsUpdateArraySize");
		AudioManager.NativeFieldInfoPtr_isMainBankLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "isMainBankLoaded");
		AudioManager.NativeFieldInfoPtr_currentScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "currentScene");
		AudioManager.NativeFieldInfoPtr_weaponBankUsageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "weaponBankUsageCount");
		AudioManager.NativeFieldInfoPtr_loadingBanks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "loadingBanks");
		AudioManager.NativeFieldInfoPtr_detachedGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "detachedGameObjects");
		AudioManager.NativeFieldInfoPtr_nextDetachedGameObjectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "nextDetachedGameObjectIndex");
		AudioManager.NativeFieldInfoPtr_reactToTentEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "reactToTentEvents");
		AudioManager.NativeFieldInfoPtr_lastNoSpamError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "lastNoSpamError");
		AudioManager.NativeFieldInfoPtr_lastNoSpamWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "lastNoSpamWarning");
		AudioManager.NativeFieldInfoPtr_hashedUserIDString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "hashedUserIDString");
		AudioManager.NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "<ManagedLateUpdateRemoval>k__BackingField");
		AudioManager.NativeMethodInfoPtr_get_Singleton_Public_Static_get_AudioManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664916);
		AudioManager.NativeMethodInfoPtr_set_Singleton_Public_Static_set_Void_AudioManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664917);
		AudioManager.NativeMethodInfoPtr_get_IsInitialized_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664918);
		AudioManager.NativeMethodInfoPtr_set_IsInitialized_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664919);
		AudioManager.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664920);
		AudioManager.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664921);
		AudioManager.NativeMethodInfoPtr_InitializeAfterStartupBankLoads_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664922);
		AudioManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664923);
		AudioManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664924);
		AudioManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664925);
		AudioManager.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664926);
		AudioManager.NativeMethodInfoPtr_get_ManagedLateUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664927);
		AudioManager.NativeMethodInfoPtr_set_ManagedLateUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664928);
		AudioManager.NativeMethodInfoPtr_OnManagedLateUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664929);
		AudioManager.NativeMethodInfoPtr_OnTentStateChange_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664930);
		AudioManager.NativeMethodInfoPtr_GetCurrentVolumePreferences_Public_Static_Single_byref_MixBusType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664931);
		AudioManager.NativeMethodInfoPtr_SaveVolumePreferences_Public_Static_Void_byref_MixBusType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664932);
		AudioManager.NativeMethodInfoPtr_UpdateVolumesAndMix_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664933);
		AudioManager.NativeMethodInfoPtr_SetMixingPreset_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664934);
		AudioManager.NativeMethodInfoPtr_StartBankLoad_Private_Void_Bank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664935);
		AudioManager.NativeMethodInfoPtr_UnloadBank_Private_Void_Bank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664936);
		AudioManager.NativeMethodInfoPtr_AreAllBankLoadsFinished_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664937);
		AudioManager.NativeMethodInfoPtr_IsStartupBankLoading_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664938);
		AudioManager.NativeMethodInfoPtr_StartTransitionToSceneAsync_Public_IEnumerator_SceneData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664939);
		AudioManager.NativeMethodInfoPtr_FinishTransitionToSceneAsync_Public_IEnumerator_SceneData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664940);
		AudioManager.NativeMethodInfoPtr_DisableAllReverbBuses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664941);
		AudioManager.NativeMethodInfoPtr_UpdateUsedReverbBuses_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664942);
		AudioManager.NativeMethodInfoPtr_EnqueueForDeferredAcoustingsUpdate_Private_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664943);
		AudioManager.NativeMethodInfoPtr_UpdateListenerIfRequired_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664944);
		AudioManager.NativeMethodInfoPtr_PerformDeferredAcousticsUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664945);
		AudioManager.NativeMethodInfoPtr_PerformAcousticsUpdate_Private_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664946);
		AudioManager.NativeMethodInfoPtr_SetReverbSendsAndOutdoorness_Public_Void_GameObject_ReverbBusType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664947);
		AudioManager.NativeMethodInfoPtr_PlayLoadingMusic_Public_Void_Switch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664948);
		AudioManager.NativeMethodInfoPtr_PlayTentMusic_Public_Void_Switch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664949);
		AudioManager.NativeMethodInfoPtr_PlayMainMenuMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664950);
		AudioManager.NativeMethodInfoPtr_PlayRoundStartMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664951);
		AudioManager.NativeMethodInfoPtr_PlayRoundVictoryMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664952);
		AudioManager.NativeMethodInfoPtr_PlayRoundDefeatMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664953);
		AudioManager.NativeMethodInfoPtr_IsRoundEndMusicPlaying_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664954);
		AudioManager.NativeMethodInfoPtr_IsTentMusicPlaying_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664955);
		AudioManager.NativeMethodInfoPtr_PlayEvacMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664956);
		AudioManager.NativeMethodInfoPtr_StopMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664957);
		AudioManager.NativeMethodInfoPtr_StartGlobalAmbients_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664958);
		AudioManager.NativeMethodInfoPtr_StopGlobalAmbients_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664959);
		AudioManager.NativeMethodInfoPtr_RegisterWeaponBankUser_Public_Void_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664960);
		AudioManager.NativeMethodInfoPtr_UnregisterWeaponBankUser_Public_Void_WeaponName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664961);
		AudioManager.NativeMethodInfoPtr_SetMaterialSwitch_Public_Void_GameObject_MaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664962);
		AudioManager.NativeMethodInfoPtr_SetObjectPosition_Public_AKRESULT_GameObject_Transform_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664963);
		AudioManager.NativeMethodInfoPtr_SetObjectPosition_Public_AKRESULT_GameObject_Single_Single_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664964);
		AudioManager.NativeMethodInfoPtr_SetObjectPosition_Public_AKRESULT_GameObject_Vector3_Vector3_Vector3_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664965);
		AudioManager.NativeMethodInfoPtr_PostDetachedEventAt_Public_Void_Event_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664966);
		AudioManager.NativeMethodInfoPtr_PostDetachedEventAt_Public_Void_Event_Vector3_Vector3_Vector3_MaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664967);
		AudioManager.NativeMethodInfoPtr_PostDetachedEventAt_Public_Void_Event_Vector3_Vector3_Vector3_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664968);
		AudioManager.NativeMethodInfoPtr_IsEventPlayingOnGameObject_Public_Boolean_Event_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664969);
		AudioManager.NativeMethodInfoPtr_IsAnyEventPlayingOnGameObject_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664970);
		AudioManager.NativeMethodInfoPtr_ToggleMuteGame_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664971);
		AudioManager.NativeMethodInfoPtr_GetUInt64HashCode_Public_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664972);
		AudioManager.NativeMethodInfoPtr_Log_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664973);
		AudioManager.NativeMethodInfoPtr_LogState_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664974);
		AudioManager.NativeMethodInfoPtr_LogMusic_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664975);
		AudioManager.NativeMethodInfoPtr_LogLoading_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664976);
		AudioManager.NativeMethodInfoPtr_LogReverb_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664977);
		AudioManager.NativeMethodInfoPtr_LogVoip_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664978);
		AudioManager.NativeMethodInfoPtr_LogMovement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664979);
		AudioManager.NativeMethodInfoPtr_LogError_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664980);
		AudioManager.NativeMethodInfoPtr_LogWarning_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664981);
		AudioManager.NativeMethodInfoPtr_LogErrorNoSpam_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664982);
		AudioManager.NativeMethodInfoPtr_LogWarningNoSpam_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664983);
		AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100664984);
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x0000210C File Offset: 0x0000030C
	public AudioManager(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700069B RID: 1691
	// (get) Token: 0x060013C8 RID: 5064 RVA: 0x00051010 File Offset: 0x0004F210
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AudioManager>.NativeClassPtr));
		}
	}

	// Token: 0x1700069C RID: 1692
	// (get) Token: 0x060013C9 RID: 5065 RVA: 0x00051024 File Offset: 0x0004F224
	// (set) Token: 0x060013CA RID: 5066 RVA: 0x00051042 File Offset: 0x0004F242
	public unsafe static int DetachedGameObjectPoolSize
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_DetachedGameObjectPoolSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_DetachedGameObjectPoolSize, (void*)(&value));
		}
	}

	// Token: 0x1700069D RID: 1693
	// (get) Token: 0x060013CB RID: 5067 RVA: 0x00051054 File Offset: 0x0004F254
	// (set) Token: 0x060013CC RID: 5068 RVA: 0x00051072 File Offset: 0x0004F272
	public unsafe static int AcousticsUpdateArrayMaxSize
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_AcousticsUpdateArrayMaxSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_AcousticsUpdateArrayMaxSize, (void*)(&value));
		}
	}

	// Token: 0x1700069E RID: 1694
	// (get) Token: 0x060013CD RID: 5069 RVA: 0x00051084 File Offset: 0x0004F284
	// (set) Token: 0x060013CE RID: 5070 RVA: 0x000510A2 File Offset: 0x0004F2A2
	public unsafe static int ReverbBusTypeCount
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_ReverbBusTypeCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_ReverbBusTypeCount, (void*)(&value));
		}
	}

	// Token: 0x1700069F RID: 1695
	// (get) Token: 0x060013CF RID: 5071 RVA: 0x000510B4 File Offset: 0x0004F2B4
	// (set) Token: 0x060013D0 RID: 5072 RVA: 0x000510DC File Offset: 0x0004F2DC
	public unsafe int AudioReverbLayerMask
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_AudioReverbLayerMask);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_AudioReverbLayerMask)) = value;
		}
	}

	// Token: 0x170006A0 RID: 1696
	// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00051100 File Offset: 0x0004F300
	// (set) Token: 0x060013D2 RID: 5074 RVA: 0x0005111E File Offset: 0x0004F31E
	public unsafe static bool isInitializing
	{
		get
		{
			bool result;
			IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_isInitializing, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_isInitializing, (void*)(&value));
		}
	}

	// Token: 0x170006A1 RID: 1697
	// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00051130 File Offset: 0x0004F330
	// (set) Token: 0x060013D4 RID: 5076 RVA: 0x0005114E File Offset: 0x0004F34E
	public unsafe static bool isInitialized
	{
		get
		{
			bool result;
			IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_isInitialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_isInitialized, (void*)(&value));
		}
	}

	// Token: 0x170006A2 RID: 1698
	// (get) Token: 0x060013D5 RID: 5077 RVA: 0x00051160 File Offset: 0x0004F360
	// (set) Token: 0x060013D6 RID: 5078 RVA: 0x0005118B File Offset: 0x0004F38B
	public unsafe static AudioManager m_Singleton
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_m_Singleton, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new AudioManager(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_m_Singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A3 RID: 1699
	// (get) Token: 0x060013D7 RID: 5079 RVA: 0x000511A0 File Offset: 0x0004F3A0
	// (set) Token: 0x060013D8 RID: 5080 RVA: 0x000511D4 File Offset: 0x0004F3D4
	public unsafe Action<int> OnListenerMuffleZoneChanged
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_OnListenerMuffleZoneChanged);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Action<int>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_OnListenerMuffleZoneChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A4 RID: 1700
	// (get) Token: 0x060013D9 RID: 5081 RVA: 0x000511FC File Offset: 0x0004F3FC
	// (set) Token: 0x060013DA RID: 5082 RVA: 0x00051230 File Offset: 0x0004F430
	public unsafe Action<AudioManager.ReverbBusType> OnListenerReverbZoneChanged
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_OnListenerReverbZoneChanged);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Action<AudioManager.ReverbBusType>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_OnListenerReverbZoneChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A5 RID: 1701
	// (get) Token: 0x060013DB RID: 5083 RVA: 0x00051258 File Offset: 0x0004F458
	// (set) Token: 0x060013DC RID: 5084 RVA: 0x0005128C File Offset: 0x0004F48C
	public unsafe OculusPCWwiseOutputHandler OculusPCWwiseOutputHandler
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_OculusPCWwiseOutputHandler);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new OculusPCWwiseOutputHandler(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_OculusPCWwiseOutputHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A6 RID: 1702
	// (get) Token: 0x060013DD RID: 5085 RVA: 0x000512B4 File Offset: 0x0004F4B4
	// (set) Token: 0x060013DE RID: 5086 RVA: 0x000512E8 File Offset: 0x0004F4E8
	public unsafe Bank StartupBank
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_StartupBank);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Bank(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_StartupBank), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A7 RID: 1703
	// (get) Token: 0x060013DF RID: 5087 RVA: 0x00051310 File Offset: 0x0004F510
	// (set) Token: 0x060013E0 RID: 5088 RVA: 0x00051344 File Offset: 0x0004F544
	public unsafe Bank MainBank
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MainBank);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Bank(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MainBank), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A8 RID: 1704
	// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0005136C File Offset: 0x0004F56C
	// (set) Token: 0x060013E2 RID: 5090 RVA: 0x000513A0 File Offset: 0x0004F5A0
	public unsafe Bank AmbiencesBank
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_AmbiencesBank);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Bank(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_AmbiencesBank), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A9 RID: 1705
	// (get) Token: 0x060013E3 RID: 5091 RVA: 0x000513C8 File Offset: 0x0004F5C8
	// (set) Token: 0x060013E4 RID: 5092 RVA: 0x000513FC File Offset: 0x0004F5FC
	public unsafe Bank MusicBank
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MusicBank);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Bank(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MusicBank), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006AA RID: 1706
	// (get) Token: 0x060013E5 RID: 5093 RVA: 0x00051424 File Offset: 0x0004F624
	// (set) Token: 0x060013E6 RID: 5094 RVA: 0x00051458 File Offset: 0x0004F658
	public unsafe Bank WeaponsGenericBank
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_WeaponsGenericBank);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Bank(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_WeaponsGenericBank), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006AB RID: 1707
	// (get) Token: 0x060013E7 RID: 5095 RVA: 0x00051480 File Offset: 0x0004F680
	// (set) Token: 0x060013E8 RID: 5096 RVA: 0x000514B4 File Offset: 0x0004F6B4
	public unsafe Bank VOIPBank
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_VOIPBank);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Bank(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_VOIPBank), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006AC RID: 1708
	// (get) Token: 0x060013E9 RID: 5097 RVA: 0x000514DC File Offset: 0x0004F6DC
	// (set) Token: 0x060013EA RID: 5098 RVA: 0x00051510 File Offset: 0x0004F710
	public unsafe WeaponSoundBankLibrary weaponSoundBankLibrary
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_weaponSoundBankLibrary);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new WeaponSoundBankLibrary(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_weaponSoundBankLibrary), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006AD RID: 1709
	// (get) Token: 0x060013EB RID: 5099 RVA: 0x00051538 File Offset: 0x0004F738
	// (set) Token: 0x060013EC RID: 5100 RVA: 0x0005156C File Offset: 0x0004F76C
	public unsafe AK.Wwise.Event loadingMusicPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_loadingMusicPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_loadingMusicPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006AE RID: 1710
	// (get) Token: 0x060013ED RID: 5101 RVA: 0x00051594 File Offset: 0x0004F794
	// (set) Token: 0x060013EE RID: 5102 RVA: 0x000515C8 File Offset: 0x0004F7C8
	public unsafe AK.Wwise.Event menuMusicPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_menuMusicPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_menuMusicPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006AF RID: 1711
	// (get) Token: 0x060013EF RID: 5103 RVA: 0x000515F0 File Offset: 0x0004F7F0
	// (set) Token: 0x060013F0 RID: 5104 RVA: 0x00051624 File Offset: 0x0004F824
	public unsafe AK.Wwise.Event tentMusicPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_tentMusicPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_tentMusicPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B0 RID: 1712
	// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0005164C File Offset: 0x0004F84C
	// (set) Token: 0x060013F2 RID: 5106 RVA: 0x00051680 File Offset: 0x0004F880
	public unsafe AK.Wwise.Event roundStartMusicPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_roundStartMusicPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_roundStartMusicPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B1 RID: 1713
	// (get) Token: 0x060013F3 RID: 5107 RVA: 0x000516A8 File Offset: 0x0004F8A8
	// (set) Token: 0x060013F4 RID: 5108 RVA: 0x000516DC File Offset: 0x0004F8DC
	public unsafe AK.Wwise.Event roundVictoryMusicPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_roundVictoryMusicPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_roundVictoryMusicPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B2 RID: 1714
	// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00051704 File Offset: 0x0004F904
	// (set) Token: 0x060013F6 RID: 5110 RVA: 0x00051738 File Offset: 0x0004F938
	public unsafe AK.Wwise.Event roundDefeatMusicPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_roundDefeatMusicPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_roundDefeatMusicPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B3 RID: 1715
	// (get) Token: 0x060013F7 RID: 5111 RVA: 0x00051760 File Offset: 0x0004F960
	// (set) Token: 0x060013F8 RID: 5112 RVA: 0x00051794 File Offset: 0x0004F994
	public unsafe AK.Wwise.Event evacMusicPlayEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_evacMusicPlayEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_evacMusicPlayEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B4 RID: 1716
	// (get) Token: 0x060013F9 RID: 5113 RVA: 0x000517BC File Offset: 0x0004F9BC
	// (set) Token: 0x060013FA RID: 5114 RVA: 0x000517F0 File Offset: 0x0004F9F0
	public unsafe AK.Wwise.Event musicStopEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicStopEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicStopEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B5 RID: 1717
	// (get) Token: 0x060013FB RID: 5115 RVA: 0x00051818 File Offset: 0x0004FA18
	// (set) Token: 0x060013FC RID: 5116 RVA: 0x00051840 File Offset: 0x0004FA40
	public unsafe float emitterReverbBusMixAmount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_emitterReverbBusMixAmount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_emitterReverbBusMixAmount)) = value;
		}
	}

	// Token: 0x170006B6 RID: 1718
	// (get) Token: 0x060013FD RID: 5117 RVA: 0x00051864 File Offset: 0x0004FA64
	// (set) Token: 0x060013FE RID: 5118 RVA: 0x0005188C File Offset: 0x0004FA8C
	public unsafe float listenerReverbBusMixAmount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_listenerReverbBusMixAmount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_listenerReverbBusMixAmount)) = value;
		}
	}

	// Token: 0x170006B7 RID: 1719
	// (get) Token: 0x060013FF RID: 5119 RVA: 0x000518B0 File Offset: 0x0004FAB0
	// (set) Token: 0x06001400 RID: 5120 RVA: 0x000518E4 File Offset: 0x0004FAE4
	public unsafe State defaultGlobalAmbientState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_defaultGlobalAmbientState);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new State(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_defaultGlobalAmbientState), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006B8 RID: 1720
	// (get) Token: 0x06001401 RID: 5121 RVA: 0x0005190C File Offset: 0x0004FB0C
	// (set) Token: 0x06001402 RID: 5122 RVA: 0x00051934 File Offset: 0x0004FB34
	public unsafe bool logLoading
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_logLoading);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_logLoading)) = value;
		}
	}

	// Token: 0x170006B9 RID: 1721
	// (get) Token: 0x06001403 RID: 5123 RVA: 0x00051958 File Offset: 0x0004FB58
	// (set) Token: 0x06001404 RID: 5124 RVA: 0x00051980 File Offset: 0x0004FB80
	public unsafe bool logState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_logState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_logState)) = value;
		}
	}

	// Token: 0x170006BA RID: 1722
	// (get) Token: 0x06001405 RID: 5125 RVA: 0x000519A4 File Offset: 0x0004FBA4
	// (set) Token: 0x06001406 RID: 5126 RVA: 0x000519CC File Offset: 0x0004FBCC
	public unsafe bool logMusic
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_logMusic);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_logMusic)) = value;
		}
	}

	// Token: 0x170006BB RID: 1723
	// (get) Token: 0x06001407 RID: 5127 RVA: 0x000519F0 File Offset: 0x0004FBF0
	// (set) Token: 0x06001408 RID: 5128 RVA: 0x00051A18 File Offset: 0x0004FC18
	public unsafe bool logReverb
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_logReverb);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_logReverb)) = value;
		}
	}

	// Token: 0x170006BC RID: 1724
	// (get) Token: 0x06001409 RID: 5129 RVA: 0x00051A3C File Offset: 0x0004FC3C
	// (set) Token: 0x0600140A RID: 5130 RVA: 0x00051A64 File Offset: 0x0004FC64
	public unsafe bool logVoip
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_logVoip);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_logVoip)) = value;
		}
	}

	// Token: 0x170006BD RID: 1725
	// (get) Token: 0x0600140B RID: 5131 RVA: 0x00051A88 File Offset: 0x0004FC88
	// (set) Token: 0x0600140C RID: 5132 RVA: 0x00051AB0 File Offset: 0x0004FCB0
	public unsafe bool logMovement
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_logMovement);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_logMovement)) = value;
		}
	}

	// Token: 0x170006BE RID: 1726
	// (get) Token: 0x0600140D RID: 5133 RVA: 0x00051AD4 File Offset: 0x0004FCD4
	// (set) Token: 0x0600140E RID: 5134 RVA: 0x00051AF2 File Offset: 0x0004FCF2
	public unsafe static float VOLUME_MAX_BOOST_VALUE
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_VOLUME_MAX_BOOST_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_VOLUME_MAX_BOOST_VALUE, (void*)(&value));
		}
	}

	// Token: 0x170006BF RID: 1727
	// (get) Token: 0x0600140F RID: 5135 RVA: 0x00051B04 File Offset: 0x0004FD04
	// (set) Token: 0x06001410 RID: 5136 RVA: 0x00051B22 File Offset: 0x0004FD22
	public unsafe static float VOLUME_MAX_REDUCTION_VALUE
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_VOLUME_MAX_REDUCTION_VALUE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_VOLUME_MAX_REDUCTION_VALUE, (void*)(&value));
		}
	}

	// Token: 0x170006C0 RID: 1728
	// (get) Token: 0x06001411 RID: 5137 RVA: 0x00051B34 File Offset: 0x0004FD34
	// (set) Token: 0x06001412 RID: 5138 RVA: 0x00051B68 File Offset: 0x0004FD68
	public unsafe Il2CppStructArray<uint> playingIds
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_playingIds);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppStructArray<uint>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_playingIds), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C1 RID: 1729
	// (get) Token: 0x06001413 RID: 5139 RVA: 0x00051B90 File Offset: 0x0004FD90
	// (set) Token: 0x06001414 RID: 5140 RVA: 0x00051BC4 File Offset: 0x0004FDC4
	public unsafe Il2CppReferenceArray<Collider> reverbColliderResults
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_reverbColliderResults);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<Collider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_reverbColliderResults), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C2 RID: 1730
	// (get) Token: 0x06001415 RID: 5141 RVA: 0x00051BEC File Offset: 0x0004FDEC
	// (set) Token: 0x06001416 RID: 5142 RVA: 0x00051C20 File Offset: 0x0004FE20
	public unsafe Il2CppStructArray<uint> reverbBusTypeToWwiseBusId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_reverbBusTypeToWwiseBusId);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppStructArray<uint>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_reverbBusTypeToWwiseBusId), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C3 RID: 1731
	// (get) Token: 0x06001417 RID: 5143 RVA: 0x00051C48 File Offset: 0x0004FE48
	// (set) Token: 0x06001418 RID: 5144 RVA: 0x00051C7C File Offset: 0x0004FE7C
	public unsafe AkAuxSendArray reverbAuxSendValues
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_reverbAuxSendValues);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AkAuxSendArray(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_reverbAuxSendValues), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C4 RID: 1732
	// (get) Token: 0x06001419 RID: 5145 RVA: 0x00051CA4 File Offset: 0x0004FEA4
	// (set) Token: 0x0600141A RID: 5146 RVA: 0x00051CCC File Offset: 0x0004FECC
	public unsafe int currentListenerMuffleZoneGroupId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentListenerMuffleZoneGroupId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentListenerMuffleZoneGroupId)) = value;
		}
	}

	// Token: 0x170006C5 RID: 1733
	// (get) Token: 0x0600141B RID: 5147 RVA: 0x00051CF0 File Offset: 0x0004FEF0
	// (set) Token: 0x0600141C RID: 5148 RVA: 0x00051D18 File Offset: 0x0004FF18
	public unsafe AudioManager.ReverbBusType currentListenerReverbBus
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentListenerReverbBus);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentListenerReverbBus)) = value;
		}
	}

	// Token: 0x170006C6 RID: 1734
	// (get) Token: 0x0600141D RID: 5149 RVA: 0x00051D3C File Offset: 0x0004FF3C
	// (set) Token: 0x0600141E RID: 5150 RVA: 0x00051D70 File Offset: 0x0004FF70
	public unsafe State currentGlobalAmbientState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentGlobalAmbientState);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new State(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentGlobalAmbientState), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C7 RID: 1735
	// (get) Token: 0x0600141F RID: 5151 RVA: 0x00051D98 File Offset: 0x0004FF98
	// (set) Token: 0x06001420 RID: 5152 RVA: 0x00051DCC File Offset: 0x0004FFCC
	public unsafe GameObject listenerObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_listenerObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_listenerObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C8 RID: 1736
	// (get) Token: 0x06001421 RID: 5153 RVA: 0x00051DF4 File Offset: 0x0004FFF4
	// (set) Token: 0x06001422 RID: 5154 RVA: 0x00051E1C File Offset: 0x0005001C
	public unsafe AudioManager.ReverbBusType defaultReverbBus
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_defaultReverbBus);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_defaultReverbBus)) = value;
		}
	}

	// Token: 0x170006C9 RID: 1737
	// (get) Token: 0x06001423 RID: 5155 RVA: 0x00051E40 File Offset: 0x00050040
	// (set) Token: 0x06001424 RID: 5156 RVA: 0x00051E68 File Offset: 0x00050068
	public unsafe bool needListenerZoneUpdate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_needListenerZoneUpdate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_needListenerZoneUpdate)) = value;
		}
	}

	// Token: 0x170006CA RID: 1738
	// (get) Token: 0x06001425 RID: 5157 RVA: 0x00051E8C File Offset: 0x0005008C
	// (set) Token: 0x06001426 RID: 5158 RVA: 0x00051EC0 File Offset: 0x000500C0
	public unsafe Il2CppReferenceArray<AudioManager.AcousticsUpdateEntry> acousticsUpdateArray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_acousticsUpdateArray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<AudioManager.AcousticsUpdateEntry>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_acousticsUpdateArray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006CB RID: 1739
	// (get) Token: 0x06001427 RID: 5159 RVA: 0x00051EE8 File Offset: 0x000500E8
	// (set) Token: 0x06001428 RID: 5160 RVA: 0x00051F10 File Offset: 0x00050110
	public unsafe int acousticsUpdateArraySize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_acousticsUpdateArraySize);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_acousticsUpdateArraySize)) = value;
		}
	}

	// Token: 0x170006CC RID: 1740
	// (get) Token: 0x06001429 RID: 5161 RVA: 0x00051F34 File Offset: 0x00050134
	// (set) Token: 0x0600142A RID: 5162 RVA: 0x00051F5C File Offset: 0x0005015C
	public unsafe bool isMainBankLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_isMainBankLoaded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_isMainBankLoaded)) = value;
		}
	}

	// Token: 0x170006CD RID: 1741
	// (get) Token: 0x0600142B RID: 5163 RVA: 0x00051F80 File Offset: 0x00050180
	// (set) Token: 0x0600142C RID: 5164 RVA: 0x00051FB4 File Offset: 0x000501B4
	public unsafe SceneData currentScene
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentScene);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new SceneData(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentScene), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006CE RID: 1742
	// (get) Token: 0x0600142D RID: 5165 RVA: 0x00051FDC File Offset: 0x000501DC
	// (set) Token: 0x0600142E RID: 5166 RVA: 0x00052010 File Offset: 0x00050210
	public unsafe Dictionary<uint, int> weaponBankUsageCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_weaponBankUsageCount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Dictionary<uint, int>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_weaponBankUsageCount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006CF RID: 1743
	// (get) Token: 0x0600142F RID: 5167 RVA: 0x00052038 File Offset: 0x00050238
	// (set) Token: 0x06001430 RID: 5168 RVA: 0x0005206C File Offset: 0x0005026C
	public unsafe HashSet<Bank> loadingBanks
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_loadingBanks);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new HashSet<Bank>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_loadingBanks), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006D0 RID: 1744
	// (get) Token: 0x06001431 RID: 5169 RVA: 0x00052094 File Offset: 0x00050294
	// (set) Token: 0x06001432 RID: 5170 RVA: 0x000520C8 File Offset: 0x000502C8
	public unsafe List<GameObject> detachedGameObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_detachedGameObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_detachedGameObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006D1 RID: 1745
	// (get) Token: 0x06001433 RID: 5171 RVA: 0x000520F0 File Offset: 0x000502F0
	// (set) Token: 0x06001434 RID: 5172 RVA: 0x00052118 File Offset: 0x00050318
	public unsafe int nextDetachedGameObjectIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_nextDetachedGameObjectIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_nextDetachedGameObjectIndex)) = value;
		}
	}

	// Token: 0x170006D2 RID: 1746
	// (get) Token: 0x06001435 RID: 5173 RVA: 0x0005213C File Offset: 0x0005033C
	// (set) Token: 0x06001436 RID: 5174 RVA: 0x00052164 File Offset: 0x00050364
	public unsafe bool reactToTentEvents
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_reactToTentEvents);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_reactToTentEvents)) = value;
		}
	}

	// Token: 0x170006D3 RID: 1747
	// (get) Token: 0x06001437 RID: 5175 RVA: 0x00052188 File Offset: 0x00050388
	// (set) Token: 0x06001438 RID: 5176 RVA: 0x000521B0 File Offset: 0x000503B0
	public unsafe float lastNoSpamError
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_lastNoSpamError);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_lastNoSpamError)) = value;
		}
	}

	// Token: 0x170006D4 RID: 1748
	// (get) Token: 0x06001439 RID: 5177 RVA: 0x000521D4 File Offset: 0x000503D4
	// (set) Token: 0x0600143A RID: 5178 RVA: 0x000521FC File Offset: 0x000503FC
	public unsafe float lastNoSpamWarning
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_lastNoSpamWarning);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_lastNoSpamWarning)) = value;
		}
	}

	// Token: 0x170006D5 RID: 1749
	// (get) Token: 0x0600143B RID: 5179 RVA: 0x00052220 File Offset: 0x00050420
	// (set) Token: 0x0600143C RID: 5180 RVA: 0x00052249 File Offset: 0x00050449
	public unsafe string hashedUserIDString
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_hashedUserIDString);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_hashedUserIDString), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170006D6 RID: 1750
	// (get) Token: 0x0600143D RID: 5181 RVA: 0x00052270 File Offset: 0x00050470
	// (set) Token: 0x0600143E RID: 5182 RVA: 0x00052298 File Offset: 0x00050498
	public unsafe bool _ManagedLateUpdateRemoval_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField)) = value;
		}
	}

	// Token: 0x04000C6F RID: 3183
	private static readonly IntPtr NativeFieldInfoPtr_DetachedGameObjectPoolSize;

	// Token: 0x04000C70 RID: 3184
	private static readonly IntPtr NativeFieldInfoPtr_AcousticsUpdateArrayMaxSize;

	// Token: 0x04000C71 RID: 3185
	private static readonly IntPtr NativeFieldInfoPtr_ReverbBusTypeCount;

	// Token: 0x04000C72 RID: 3186
	private static readonly IntPtr NativeFieldInfoPtr_AudioReverbLayerMask;

	// Token: 0x04000C73 RID: 3187
	private static readonly IntPtr NativeFieldInfoPtr_isInitializing;

	// Token: 0x04000C74 RID: 3188
	private static readonly IntPtr NativeFieldInfoPtr_isInitialized;

	// Token: 0x04000C75 RID: 3189
	private static readonly IntPtr NativeFieldInfoPtr_m_Singleton;

	// Token: 0x04000C76 RID: 3190
	private static readonly IntPtr NativeFieldInfoPtr_OnListenerMuffleZoneChanged;

	// Token: 0x04000C77 RID: 3191
	private static readonly IntPtr NativeFieldInfoPtr_OnListenerReverbZoneChanged;

	// Token: 0x04000C78 RID: 3192
	private static readonly IntPtr NativeFieldInfoPtr_OculusPCWwiseOutputHandler;

	// Token: 0x04000C79 RID: 3193
	private static readonly IntPtr NativeFieldInfoPtr_StartupBank;

	// Token: 0x04000C7A RID: 3194
	private static readonly IntPtr NativeFieldInfoPtr_MainBank;

	// Token: 0x04000C7B RID: 3195
	private static readonly IntPtr NativeFieldInfoPtr_AmbiencesBank;

	// Token: 0x04000C7C RID: 3196
	private static readonly IntPtr NativeFieldInfoPtr_MusicBank;

	// Token: 0x04000C7D RID: 3197
	private static readonly IntPtr NativeFieldInfoPtr_WeaponsGenericBank;

	// Token: 0x04000C7E RID: 3198
	private static readonly IntPtr NativeFieldInfoPtr_VOIPBank;

	// Token: 0x04000C7F RID: 3199
	private static readonly IntPtr NativeFieldInfoPtr_weaponSoundBankLibrary;

	// Token: 0x04000C80 RID: 3200
	private static readonly IntPtr NativeFieldInfoPtr_loadingMusicPlayEvent;

	// Token: 0x04000C81 RID: 3201
	private static readonly IntPtr NativeFieldInfoPtr_menuMusicPlayEvent;

	// Token: 0x04000C82 RID: 3202
	private static readonly IntPtr NativeFieldInfoPtr_tentMusicPlayEvent;

	// Token: 0x04000C83 RID: 3203
	private static readonly IntPtr NativeFieldInfoPtr_roundStartMusicPlayEvent;

	// Token: 0x04000C84 RID: 3204
	private static readonly IntPtr NativeFieldInfoPtr_roundVictoryMusicPlayEvent;

	// Token: 0x04000C85 RID: 3205
	private static readonly IntPtr NativeFieldInfoPtr_roundDefeatMusicPlayEvent;

	// Token: 0x04000C86 RID: 3206
	private static readonly IntPtr NativeFieldInfoPtr_evacMusicPlayEvent;

	// Token: 0x04000C87 RID: 3207
	private static readonly IntPtr NativeFieldInfoPtr_musicStopEvent;

	// Token: 0x04000C88 RID: 3208
	private static readonly IntPtr NativeFieldInfoPtr_emitterReverbBusMixAmount;

	// Token: 0x04000C89 RID: 3209
	private static readonly IntPtr NativeFieldInfoPtr_listenerReverbBusMixAmount;

	// Token: 0x04000C8A RID: 3210
	private static readonly IntPtr NativeFieldInfoPtr_defaultGlobalAmbientState;

	// Token: 0x04000C8B RID: 3211
	private static readonly IntPtr NativeFieldInfoPtr_logLoading;

	// Token: 0x04000C8C RID: 3212
	private static readonly IntPtr NativeFieldInfoPtr_logState;

	// Token: 0x04000C8D RID: 3213
	private static readonly IntPtr NativeFieldInfoPtr_logMusic;

	// Token: 0x04000C8E RID: 3214
	private static readonly IntPtr NativeFieldInfoPtr_logReverb;

	// Token: 0x04000C8F RID: 3215
	private static readonly IntPtr NativeFieldInfoPtr_logVoip;

	// Token: 0x04000C90 RID: 3216
	private static readonly IntPtr NativeFieldInfoPtr_logMovement;

	// Token: 0x04000C91 RID: 3217
	private static readonly IntPtr NativeFieldInfoPtr_VOLUME_MAX_BOOST_VALUE;

	// Token: 0x04000C92 RID: 3218
	private static readonly IntPtr NativeFieldInfoPtr_VOLUME_MAX_REDUCTION_VALUE;

	// Token: 0x04000C93 RID: 3219
	private static readonly IntPtr NativeFieldInfoPtr_playingIds;

	// Token: 0x04000C94 RID: 3220
	private static readonly IntPtr NativeFieldInfoPtr_reverbColliderResults;

	// Token: 0x04000C95 RID: 3221
	private static readonly IntPtr NativeFieldInfoPtr_reverbBusTypeToWwiseBusId;

	// Token: 0x04000C96 RID: 3222
	private static readonly IntPtr NativeFieldInfoPtr_reverbAuxSendValues;

	// Token: 0x04000C97 RID: 3223
	private static readonly IntPtr NativeFieldInfoPtr_currentListenerMuffleZoneGroupId;

	// Token: 0x04000C98 RID: 3224
	private static readonly IntPtr NativeFieldInfoPtr_currentListenerReverbBus;

	// Token: 0x04000C99 RID: 3225
	private static readonly IntPtr NativeFieldInfoPtr_currentGlobalAmbientState;

	// Token: 0x04000C9A RID: 3226
	private static readonly IntPtr NativeFieldInfoPtr_listenerObject;

	// Token: 0x04000C9B RID: 3227
	private static readonly IntPtr NativeFieldInfoPtr_defaultReverbBus;

	// Token: 0x04000C9C RID: 3228
	private static readonly IntPtr NativeFieldInfoPtr_needListenerZoneUpdate;

	// Token: 0x04000C9D RID: 3229
	private static readonly IntPtr NativeFieldInfoPtr_acousticsUpdateArray;

	// Token: 0x04000C9E RID: 3230
	private static readonly IntPtr NativeFieldInfoPtr_acousticsUpdateArraySize;

	// Token: 0x04000C9F RID: 3231
	private static readonly IntPtr NativeFieldInfoPtr_isMainBankLoaded;

	// Token: 0x04000CA0 RID: 3232
	private static readonly IntPtr NativeFieldInfoPtr_currentScene;

	// Token: 0x04000CA1 RID: 3233
	private static readonly IntPtr NativeFieldInfoPtr_weaponBankUsageCount;

	// Token: 0x04000CA2 RID: 3234
	private static readonly IntPtr NativeFieldInfoPtr_loadingBanks;

	// Token: 0x04000CA3 RID: 3235
	private static readonly IntPtr NativeFieldInfoPtr_detachedGameObjects;

	// Token: 0x04000CA4 RID: 3236
	private static readonly IntPtr NativeFieldInfoPtr_nextDetachedGameObjectIndex;

	// Token: 0x04000CA5 RID: 3237
	private static readonly IntPtr NativeFieldInfoPtr_reactToTentEvents;

	// Token: 0x04000CA6 RID: 3238
	private static readonly IntPtr NativeFieldInfoPtr_lastNoSpamError;

	// Token: 0x04000CA7 RID: 3239
	private static readonly IntPtr NativeFieldInfoPtr_lastNoSpamWarning;

	// Token: 0x04000CA8 RID: 3240
	private static readonly IntPtr NativeFieldInfoPtr_hashedUserIDString;

	// Token: 0x04000CA9 RID: 3241
	private static readonly IntPtr NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField;

	// Token: 0x04000CAA RID: 3242
	private static readonly IntPtr NativeMethodInfoPtr_get_Singleton_Public_Static_get_AudioManager_0;

	// Token: 0x04000CAB RID: 3243
	private static readonly IntPtr NativeMethodInfoPtr_set_Singleton_Public_Static_set_Void_AudioManager_0;

	// Token: 0x04000CAC RID: 3244
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInitialized_Public_Static_get_Boolean_0;

	// Token: 0x04000CAD RID: 3245
	private static readonly IntPtr NativeMethodInfoPtr_set_IsInitialized_Private_Static_set_Void_Boolean_0;

	// Token: 0x04000CAE RID: 3246
	private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	// Token: 0x04000CAF RID: 3247
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	// Token: 0x04000CB0 RID: 3248
	private static readonly IntPtr NativeMethodInfoPtr_InitializeAfterStartupBankLoads_Private_IEnumerator_0;

	// Token: 0x04000CB1 RID: 3249
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000CB2 RID: 3250
	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

	// Token: 0x04000CB3 RID: 3251
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04000CB4 RID: 3252
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04000CB5 RID: 3253
	private static readonly IntPtr NativeMethodInfoPtr_get_ManagedLateUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04000CB6 RID: 3254
	private static readonly IntPtr NativeMethodInfoPtr_set_ManagedLateUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0;

	// Token: 0x04000CB7 RID: 3255
	private static readonly IntPtr NativeMethodInfoPtr_OnManagedLateUpdate_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000CB8 RID: 3256
	private static readonly IntPtr NativeMethodInfoPtr_OnTentStateChange_Private_Void_Boolean_0;

	// Token: 0x04000CB9 RID: 3257
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentVolumePreferences_Public_Static_Single_byref_MixBusType_0;

	// Token: 0x04000CBA RID: 3258
	private static readonly IntPtr NativeMethodInfoPtr_SaveVolumePreferences_Public_Static_Void_byref_MixBusType_Single_0;

	// Token: 0x04000CBB RID: 3259
	private static readonly IntPtr NativeMethodInfoPtr_UpdateVolumesAndMix_Public_Static_Void_0;

	// Token: 0x04000CBC RID: 3260
	private static readonly IntPtr NativeMethodInfoPtr_SetMixingPreset_Public_Static_Void_Int32_0;

	// Token: 0x04000CBD RID: 3261
	private static readonly IntPtr NativeMethodInfoPtr_StartBankLoad_Private_Void_Bank_0;

	// Token: 0x04000CBE RID: 3262
	private static readonly IntPtr NativeMethodInfoPtr_UnloadBank_Private_Void_Bank_0;

	// Token: 0x04000CBF RID: 3263
	private static readonly IntPtr NativeMethodInfoPtr_AreAllBankLoadsFinished_Private_Boolean_0;

	// Token: 0x04000CC0 RID: 3264
	private static readonly IntPtr NativeMethodInfoPtr_IsStartupBankLoading_Public_Boolean_0;

	// Token: 0x04000CC1 RID: 3265
	private static readonly IntPtr NativeMethodInfoPtr_StartTransitionToSceneAsync_Public_IEnumerator_SceneData_Boolean_0;

	// Token: 0x04000CC2 RID: 3266
	private static readonly IntPtr NativeMethodInfoPtr_FinishTransitionToSceneAsync_Public_IEnumerator_SceneData_0;

	// Token: 0x04000CC3 RID: 3267
	private static readonly IntPtr NativeMethodInfoPtr_DisableAllReverbBuses_Private_Void_0;

	// Token: 0x04000CC4 RID: 3268
	private static readonly IntPtr NativeMethodInfoPtr_UpdateUsedReverbBuses_Private_Void_0;

	// Token: 0x04000CC5 RID: 3269
	private static readonly IntPtr NativeMethodInfoPtr_EnqueueForDeferredAcoustingsUpdate_Private_Void_GameObject_Boolean_0;

	// Token: 0x04000CC6 RID: 3270
	private static readonly IntPtr NativeMethodInfoPtr_UpdateListenerIfRequired_Private_Void_0;

	// Token: 0x04000CC7 RID: 3271
	private static readonly IntPtr NativeMethodInfoPtr_PerformDeferredAcousticsUpdate_Private_Void_0;

	// Token: 0x04000CC8 RID: 3272
	private static readonly IntPtr NativeMethodInfoPtr_PerformAcousticsUpdate_Private_Void_GameObject_Boolean_0;

	// Token: 0x04000CC9 RID: 3273
	private static readonly IntPtr NativeMethodInfoPtr_SetReverbSendsAndOutdoorness_Public_Void_GameObject_ReverbBusType_0;

	// Token: 0x04000CCA RID: 3274
	private static readonly IntPtr NativeMethodInfoPtr_PlayLoadingMusic_Public_Void_Switch_0;

	// Token: 0x04000CCB RID: 3275
	private static readonly IntPtr NativeMethodInfoPtr_PlayTentMusic_Public_Void_Switch_0;

	// Token: 0x04000CCC RID: 3276
	private static readonly IntPtr NativeMethodInfoPtr_PlayMainMenuMusic_Public_Void_0;

	// Token: 0x04000CCD RID: 3277
	private static readonly IntPtr NativeMethodInfoPtr_PlayRoundStartMusic_Public_Void_0;

	// Token: 0x04000CCE RID: 3278
	private static readonly IntPtr NativeMethodInfoPtr_PlayRoundVictoryMusic_Public_Void_0;

	// Token: 0x04000CCF RID: 3279
	private static readonly IntPtr NativeMethodInfoPtr_PlayRoundDefeatMusic_Public_Void_0;

	// Token: 0x04000CD0 RID: 3280
	private static readonly IntPtr NativeMethodInfoPtr_IsRoundEndMusicPlaying_Public_Boolean_0;

	// Token: 0x04000CD1 RID: 3281
	private static readonly IntPtr NativeMethodInfoPtr_IsTentMusicPlaying_Public_Boolean_0;

	// Token: 0x04000CD2 RID: 3282
	private static readonly IntPtr NativeMethodInfoPtr_PlayEvacMusic_Public_Void_0;

	// Token: 0x04000CD3 RID: 3283
	private static readonly IntPtr NativeMethodInfoPtr_StopMusic_Public_Void_0;

	// Token: 0x04000CD4 RID: 3284
	private static readonly IntPtr NativeMethodInfoPtr_StartGlobalAmbients_Public_Void_0;

	// Token: 0x04000CD5 RID: 3285
	private static readonly IntPtr NativeMethodInfoPtr_StopGlobalAmbients_Public_Void_0;

	// Token: 0x04000CD6 RID: 3286
	private static readonly IntPtr NativeMethodInfoPtr_RegisterWeaponBankUser_Public_Void_WeaponName_0;

	// Token: 0x04000CD7 RID: 3287
	private static readonly IntPtr NativeMethodInfoPtr_UnregisterWeaponBankUser_Public_Void_WeaponName_0;

	// Token: 0x04000CD8 RID: 3288
	private static readonly IntPtr NativeMethodInfoPtr_SetMaterialSwitch_Public_Void_GameObject_MaterialType_0;

	// Token: 0x04000CD9 RID: 3289
	private static readonly IntPtr NativeMethodInfoPtr_SetObjectPosition_Public_AKRESULT_GameObject_Transform_Boolean_Boolean_0;

	// Token: 0x04000CDA RID: 3290
	private static readonly IntPtr NativeMethodInfoPtr_SetObjectPosition_Public_AKRESULT_GameObject_Single_Single_Single_Single_Single_Single_Single_Single_Single_0;

	// Token: 0x04000CDB RID: 3291
	private static readonly IntPtr NativeMethodInfoPtr_SetObjectPosition_Public_AKRESULT_GameObject_Vector3_Vector3_Vector3_Boolean_Boolean_0;

	// Token: 0x04000CDC RID: 3292
	private static readonly IntPtr NativeMethodInfoPtr_PostDetachedEventAt_Public_Void_Event_Vector3_Vector3_Vector3_0;

	// Token: 0x04000CDD RID: 3293
	private static readonly IntPtr NativeMethodInfoPtr_PostDetachedEventAt_Public_Void_Event_Vector3_Vector3_Vector3_MaterialType_0;

	// Token: 0x04000CDE RID: 3294
	private static readonly IntPtr NativeMethodInfoPtr_PostDetachedEventAt_Public_Void_Event_Vector3_Vector3_Vector3_UInt32_Single_0;

	// Token: 0x04000CDF RID: 3295
	private static readonly IntPtr NativeMethodInfoPtr_IsEventPlayingOnGameObject_Public_Boolean_Event_GameObject_0;

	// Token: 0x04000CE0 RID: 3296
	private static readonly IntPtr NativeMethodInfoPtr_IsAnyEventPlayingOnGameObject_Public_Boolean_GameObject_0;

	// Token: 0x04000CE1 RID: 3297
	private static readonly IntPtr NativeMethodInfoPtr_ToggleMuteGame_Public_Void_Boolean_0;

	// Token: 0x04000CE2 RID: 3298
	private static readonly IntPtr NativeMethodInfoPtr_GetUInt64HashCode_Public_UInt64_String_0;

	// Token: 0x04000CE3 RID: 3299
	private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Void_String_0;

	// Token: 0x04000CE4 RID: 3300
	private static readonly IntPtr NativeMethodInfoPtr_LogState_Public_Void_String_0;

	// Token: 0x04000CE5 RID: 3301
	private static readonly IntPtr NativeMethodInfoPtr_LogMusic_Public_Void_String_0;

	// Token: 0x04000CE6 RID: 3302
	private static readonly IntPtr NativeMethodInfoPtr_LogLoading_Public_Void_String_0;

	// Token: 0x04000CE7 RID: 3303
	private static readonly IntPtr NativeMethodInfoPtr_LogReverb_Public_Void_String_0;

	// Token: 0x04000CE8 RID: 3304
	private static readonly IntPtr NativeMethodInfoPtr_LogVoip_Public_Void_String_0;

	// Token: 0x04000CE9 RID: 3305
	private static readonly IntPtr NativeMethodInfoPtr_LogMovement_Public_Void_String_0;

	// Token: 0x04000CEA RID: 3306
	private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Void_String_0;

	// Token: 0x04000CEB RID: 3307
	private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Void_String_0;

	// Token: 0x04000CEC RID: 3308
	private static readonly IntPtr NativeMethodInfoPtr_LogErrorNoSpam_Public_Void_String_0;

	// Token: 0x04000CED RID: 3309
	private static readonly IntPtr NativeMethodInfoPtr_LogWarningNoSpam_Public_Void_String_0;

	// Token: 0x04000CEE RID: 3310
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000137 RID: 311
	public enum MixBusType
	{
		// Token: 0x04000CF0 RID: 3312
		Master,
		// Token: 0x04000CF1 RID: 3313
		Music,
		// Token: 0x04000CF2 RID: 3314
		Sfx,
		// Token: 0x04000CF3 RID: 3315
		Weapon,
		// Token: 0x04000CF4 RID: 3316
		Voip
	}

	// Token: 0x02000138 RID: 312
	public enum ReverbBusType
	{
		// Token: 0x04000CF6 RID: 3318
		None,
		// Token: 0x04000CF7 RID: 3319
		ReflectiveIndoorSmall,
		// Token: 0x04000CF8 RID: 3320
		ReflectiveIndoorMedium,
		// Token: 0x04000CF9 RID: 3321
		ReflectiveIndoorLarge,
		// Token: 0x04000CFA RID: 3322
		ReflectiveOutdoor,
		// Token: 0x04000CFB RID: 3323
		SmoothIndoorSmall,
		// Token: 0x04000CFC RID: 3324
		SmoothIndoorMedium,
		// Token: 0x04000CFD RID: 3325
		SmoothIndoorLarge,
		// Token: 0x04000CFE RID: 3326
		SmoothOutdoor
	}

	// Token: 0x02000139 RID: 313
	[StructLayout(0)]
	public sealed class AcousticsUpdateEntry : ValueType
	{
		// Token: 0x06001443 RID: 5187 RVA: 0x00052308 File Offset: 0x00050508
		// Note: this type is marked as 'beforefieldinit'.
		static AcousticsUpdateEntry()
		{
			Il2CppClassPointerStore<AudioManager.AcousticsUpdateEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "AcousticsUpdateEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioManager.AcousticsUpdateEntry>.NativeClassPtr);
			AudioManager.AcousticsUpdateEntry.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager.AcousticsUpdateEntry>.NativeClassPtr, "gameObject");
			AudioManager.AcousticsUpdateEntry.NativeFieldInfoPtr_useObstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager.AcousticsUpdateEntry>.NativeClassPtr, "useObstruction");
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0002717B File Offset: 0x0002537B
		public AcousticsUpdateEntry(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x0005235B File Offset: 0x0005055B
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AudioManager.AcousticsUpdateEntry>.NativeClassPtr));
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0005236C File Offset: 0x0005056C
		public unsafe AcousticsUpdateEntry()
		{
			IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioManager.AcousticsUpdateEntry>.NativeClassPtr, (UIntPtr)0)];
			base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioManager.AcousticsUpdateEntry>.NativeClassPtr, data));
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x0005239C File Offset: 0x0005059C
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x000523D0 File Offset: 0x000505D0
		public unsafe GameObject gameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.AcousticsUpdateEntry.NativeFieldInfoPtr_gameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.AcousticsUpdateEntry.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x000523F8 File Offset: 0x000505F8
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x00052420 File Offset: 0x00050620
		public unsafe bool useObstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.AcousticsUpdateEntry.NativeFieldInfoPtr_useObstruction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.AcousticsUpdateEntry.NativeFieldInfoPtr_useObstruction)) = value;
			}
		}

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeFieldInfoPtr_gameObject;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeFieldInfoPtr_useObstruction;
	}

	// Token: 0x0200013A RID: 314
	[ObfuscatedName("AudioManager/<InitializeAfterStartupBankLoads>d__69")]
	public sealed class _InitializeAfterStartupBankLoads_d__69 : Il2CppSystem.Object
	{
		// Token: 0x0600144B RID: 5195 RVA: 0x00052444 File Offset: 0x00050644
		[CallerCount(0)]
		public unsafe _InitializeAfterStartupBankLoads_d__69(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioManager._InitializeAfterStartupBankLoads_d__69>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._InitializeAfterStartupBankLoads_d__69.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x000524A4 File Offset: 0x000506A4
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._InitializeAfterStartupBankLoads_d__69.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x000524E8 File Offset: 0x000506E8
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager._InitializeAfterStartupBankLoads_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x00052538 File Offset: 0x00050738
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._InitializeAfterStartupBankLoads_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00052590 File Offset: 0x00050790
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._InitializeAfterStartupBankLoads_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x000525D4 File Offset: 0x000507D4
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._InitializeAfterStartupBankLoads_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0005262C File Offset: 0x0005082C
		// Note: this type is marked as 'beforefieldinit'.
		static _InitializeAfterStartupBankLoads_d__69()
		{
			Il2CppClassPointerStore<AudioManager._InitializeAfterStartupBankLoads_d__69>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "<InitializeAfterStartupBankLoads>d__69");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioManager._InitializeAfterStartupBankLoads_d__69>.NativeClassPtr);
			AudioManager._InitializeAfterStartupBankLoads_d__69.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager._InitializeAfterStartupBankLoads_d__69>.NativeClassPtr, "<>1__state");
			AudioManager._InitializeAfterStartupBankLoads_d__69.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager._InitializeAfterStartupBankLoads_d__69>.NativeClassPtr, "<>2__current");
			AudioManager._InitializeAfterStartupBankLoads_d__69.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager._InitializeAfterStartupBankLoads_d__69>.NativeClassPtr, "<>4__this");
			AudioManager._InitializeAfterStartupBankLoads_d__69.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._InitializeAfterStartupBankLoads_d__69>.NativeClassPtr, 100664985);
			AudioManager._InitializeAfterStartupBankLoads_d__69.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._InitializeAfterStartupBankLoads_d__69>.NativeClassPtr, 100664986);
			AudioManager._InitializeAfterStartupBankLoads_d__69.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._InitializeAfterStartupBankLoads_d__69>.NativeClassPtr, 100664987);
			AudioManager._InitializeAfterStartupBankLoads_d__69.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._InitializeAfterStartupBankLoads_d__69>.NativeClassPtr, 100664988);
			AudioManager._InitializeAfterStartupBankLoads_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._InitializeAfterStartupBankLoads_d__69>.NativeClassPtr, 100664989);
			AudioManager._InitializeAfterStartupBankLoads_d__69.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._InitializeAfterStartupBankLoads_d__69>.NativeClassPtr, 100664990);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00002988 File Offset: 0x00000B88
		public _InitializeAfterStartupBankLoads_d__69(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0005270B File Offset: 0x0005090B
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AudioManager._InitializeAfterStartupBankLoads_d__69>.NativeClassPtr));
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x0005271C File Offset: 0x0005091C
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x00052744 File Offset: 0x00050944
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._InitializeAfterStartupBankLoads_d__69.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._InitializeAfterStartupBankLoads_d__69.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x00052768 File Offset: 0x00050968
		// (set) Token: 0x06001457 RID: 5207 RVA: 0x0005279C File Offset: 0x0005099C
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._InitializeAfterStartupBankLoads_d__69.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._InitializeAfterStartupBankLoads_d__69.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x000527C4 File Offset: 0x000509C4
		// (set) Token: 0x06001459 RID: 5209 RVA: 0x000527F8 File Offset: 0x000509F8
		public unsafe AudioManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._InitializeAfterStartupBankLoads_d__69.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AudioManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._InitializeAfterStartupBankLoads_d__69.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200013B RID: 315
	[ObfuscatedName("AudioManager/<>c")]
	[Serializable]
	public sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x0600145A RID: 5210 RVA: 0x00052820 File Offset: 0x00050A20
		[CallerCount(0)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioManager.__c>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0005286C File Offset: 0x00050A6C
		[CallerCount(0)]
		public unsafe bool _AreAllBankLoadsFinished_b__86_0(Bank bank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bank);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.__c.NativeMethodInfoPtr__AreAllBankLoadsFinished_b__86_0_Internal_Boolean_Bank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x000528D4 File Offset: 0x00050AD4
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AudioManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioManager.__c>.NativeClassPtr);
			AudioManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager.__c>.NativeClassPtr, "<>9");
			AudioManager.__c.NativeFieldInfoPtr___9__86_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager.__c>.NativeClassPtr, "<>9__86_0");
			AudioManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager.__c>.NativeClassPtr, 100664992);
			AudioManager.__c.NativeMethodInfoPtr__AreAllBankLoadsFinished_b__86_0_Internal_Boolean_Bank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager.__c>.NativeClassPtr, 100664993);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00002988 File Offset: 0x00000B88
		public __c(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0005294F File Offset: 0x00050B4F
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AudioManager.__c>.NativeClassPtr));
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x00052960 File Offset: 0x00050B60
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x0005298B File Offset: 0x00050B8B
		public unsafe static AudioManager.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new AudioManager.__c(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x000529A0 File Offset: 0x00050BA0
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x000529CB File Offset: 0x00050BCB
		public unsafe static Predicate<Bank> __9__86_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.__c.NativeFieldInfoPtr___9__86_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Predicate<Bank>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.__c.NativeFieldInfoPtr___9__86_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeFieldInfoPtr___9__86_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr__AreAllBankLoadsFinished_b__86_0_Internal_Boolean_Bank_0;
	}

	// Token: 0x0200013C RID: 316
	[ObfuscatedName("AudioManager/<StartTransitionToSceneAsync>d__88")]
	public sealed class _StartTransitionToSceneAsync_d__88 : Il2CppSystem.Object
	{
		// Token: 0x06001463 RID: 5219 RVA: 0x000529E0 File Offset: 0x00050BE0
		[CallerCount(0)]
		public unsafe _StartTransitionToSceneAsync_d__88(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioManager._StartTransitionToSceneAsync_d__88>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._StartTransitionToSceneAsync_d__88.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00052A40 File Offset: 0x00050C40
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._StartTransitionToSceneAsync_d__88.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00052A84 File Offset: 0x00050C84
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager._StartTransitionToSceneAsync_d__88.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x00052AD4 File Offset: 0x00050CD4
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._StartTransitionToSceneAsync_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00052B2C File Offset: 0x00050D2C
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._StartTransitionToSceneAsync_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x00052B70 File Offset: 0x00050D70
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._StartTransitionToSceneAsync_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00052BC8 File Offset: 0x00050DC8
		// Note: this type is marked as 'beforefieldinit'.
		static _StartTransitionToSceneAsync_d__88()
		{
			Il2CppClassPointerStore<AudioManager._StartTransitionToSceneAsync_d__88>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "<StartTransitionToSceneAsync>d__88");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioManager._StartTransitionToSceneAsync_d__88>.NativeClassPtr);
			AudioManager._StartTransitionToSceneAsync_d__88.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager._StartTransitionToSceneAsync_d__88>.NativeClassPtr, "<>1__state");
			AudioManager._StartTransitionToSceneAsync_d__88.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager._StartTransitionToSceneAsync_d__88>.NativeClassPtr, "<>2__current");
			AudioManager._StartTransitionToSceneAsync_d__88.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager._StartTransitionToSceneAsync_d__88>.NativeClassPtr, "<>4__this");
			AudioManager._StartTransitionToSceneAsync_d__88.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._StartTransitionToSceneAsync_d__88>.NativeClassPtr, 100664994);
			AudioManager._StartTransitionToSceneAsync_d__88.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._StartTransitionToSceneAsync_d__88>.NativeClassPtr, 100664995);
			AudioManager._StartTransitionToSceneAsync_d__88.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._StartTransitionToSceneAsync_d__88>.NativeClassPtr, 100664996);
			AudioManager._StartTransitionToSceneAsync_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._StartTransitionToSceneAsync_d__88>.NativeClassPtr, 100664997);
			AudioManager._StartTransitionToSceneAsync_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._StartTransitionToSceneAsync_d__88>.NativeClassPtr, 100664998);
			AudioManager._StartTransitionToSceneAsync_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._StartTransitionToSceneAsync_d__88>.NativeClassPtr, 100664999);
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00002988 File Offset: 0x00000B88
		public _StartTransitionToSceneAsync_d__88(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x00052CA7 File Offset: 0x00050EA7
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AudioManager._StartTransitionToSceneAsync_d__88>.NativeClassPtr));
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x00052CB8 File Offset: 0x00050EB8
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x00052CE0 File Offset: 0x00050EE0
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._StartTransitionToSceneAsync_d__88.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._StartTransitionToSceneAsync_d__88.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x00052D04 File Offset: 0x00050F04
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x00052D38 File Offset: 0x00050F38
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._StartTransitionToSceneAsync_d__88.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._StartTransitionToSceneAsync_d__88.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x00052D60 File Offset: 0x00050F60
		// (set) Token: 0x06001471 RID: 5233 RVA: 0x00052D94 File Offset: 0x00050F94
		public unsafe AudioManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._StartTransitionToSceneAsync_d__88.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AudioManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._StartTransitionToSceneAsync_d__88.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200013D RID: 317
	[ObfuscatedName("AudioManager/<FinishTransitionToSceneAsync>d__89")]
	public sealed class _FinishTransitionToSceneAsync_d__89 : Il2CppSystem.Object
	{
		// Token: 0x06001472 RID: 5234 RVA: 0x00052DBC File Offset: 0x00050FBC
		[CallerCount(0)]
		public unsafe _FinishTransitionToSceneAsync_d__89(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._FinishTransitionToSceneAsync_d__89.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00052E1C File Offset: 0x0005101C
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._FinishTransitionToSceneAsync_d__89.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00052E60 File Offset: 0x00051060
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager._FinishTransitionToSceneAsync_d__89.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x00052EB0 File Offset: 0x000510B0
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._FinishTransitionToSceneAsync_d__89.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x00052F08 File Offset: 0x00051108
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._FinishTransitionToSceneAsync_d__89.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x00052F4C File Offset: 0x0005114C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager._FinishTransitionToSceneAsync_d__89.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00052FA4 File Offset: 0x000511A4
		// Note: this type is marked as 'beforefieldinit'.
		static _FinishTransitionToSceneAsync_d__89()
		{
			Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "<FinishTransitionToSceneAsync>d__89");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr);
			AudioManager._FinishTransitionToSceneAsync_d__89.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr, "<>1__state");
			AudioManager._FinishTransitionToSceneAsync_d__89.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr, "<>2__current");
			AudioManager._FinishTransitionToSceneAsync_d__89.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr, "<>4__this");
			AudioManager._FinishTransitionToSceneAsync_d__89.NativeFieldInfoPtr_nextScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr, "nextScene");
			AudioManager._FinishTransitionToSceneAsync_d__89.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr, 100665000);
			AudioManager._FinishTransitionToSceneAsync_d__89.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr, 100665001);
			AudioManager._FinishTransitionToSceneAsync_d__89.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr, 100665002);
			AudioManager._FinishTransitionToSceneAsync_d__89.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr, 100665003);
			AudioManager._FinishTransitionToSceneAsync_d__89.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr, 100665004);
			AudioManager._FinishTransitionToSceneAsync_d__89.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr, 100665005);
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00002988 File Offset: 0x00000B88
		public _FinishTransitionToSceneAsync_d__89(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x00053097 File Offset: 0x00051297
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AudioManager._FinishTransitionToSceneAsync_d__89>.NativeClassPtr));
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x000530A8 File Offset: 0x000512A8
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x000530D0 File Offset: 0x000512D0
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._FinishTransitionToSceneAsync_d__89.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._FinishTransitionToSceneAsync_d__89.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x000530F4 File Offset: 0x000512F4
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x00053128 File Offset: 0x00051328
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._FinishTransitionToSceneAsync_d__89.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._FinishTransitionToSceneAsync_d__89.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x00053150 File Offset: 0x00051350
		// (set) Token: 0x06001480 RID: 5248 RVA: 0x00053184 File Offset: 0x00051384
		public unsafe AudioManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._FinishTransitionToSceneAsync_d__89.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AudioManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._FinishTransitionToSceneAsync_d__89.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x000531AC File Offset: 0x000513AC
		// (set) Token: 0x06001482 RID: 5250 RVA: 0x000531E0 File Offset: 0x000513E0
		public unsafe SceneData nextScene
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._FinishTransitionToSceneAsync_d__89.NativeFieldInfoPtr_nextScene);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new SceneData(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager._FinishTransitionToSceneAsync_d__89.NativeFieldInfoPtr_nextScene), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeFieldInfoPtr_nextScene;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
