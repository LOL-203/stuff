using System;
using System.Runtime.InteropServices;
using AK.Wwise;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.ComponentModel;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;
using VivoxUnity;

// Token: 0x020004AF RID: 1199
public class VivoxVoiceManager : MonoBehaviour
{
	// Token: 0x06005FA7 RID: 24487 RVA: 0x0017EEDC File Offset: 0x0017D0DC
	[CallerCount(0)]
	public unsafe void add_OnSpeechDetectedEvent(VivoxVoiceManager.ParticipantValueChangedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_add_OnSpeechDetectedEvent_Public_add_Void_ParticipantValueChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FA8 RID: 24488 RVA: 0x0017EF38 File Offset: 0x0017D138
	[CallerCount(0)]
	public unsafe void remove_OnSpeechDetectedEvent(VivoxVoiceManager.ParticipantValueChangedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_remove_OnSpeechDetectedEvent_Public_rem_Void_ParticipantValueChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FA9 RID: 24489 RVA: 0x0017EF94 File Offset: 0x0017D194
	[CallerCount(0)]
	public unsafe void add_OnAudioEnergyChangedEvent(VivoxVoiceManager.ParticipantValueUpdatedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_add_OnAudioEnergyChangedEvent_Public_add_Void_ParticipantValueUpdatedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FAA RID: 24490 RVA: 0x0017EFF0 File Offset: 0x0017D1F0
	[CallerCount(0)]
	public unsafe void remove_OnAudioEnergyChangedEvent(VivoxVoiceManager.ParticipantValueUpdatedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_remove_OnAudioEnergyChangedEvent_Public_rem_Void_ParticipantValueUpdatedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FAB RID: 24491 RVA: 0x0017F04C File Offset: 0x0017D24C
	[CallerCount(0)]
	public unsafe void add_OnParticipantAddedEvent(VivoxVoiceManager.ParticipantStatusChangedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_add_OnParticipantAddedEvent_Public_add_Void_ParticipantStatusChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FAC RID: 24492 RVA: 0x0017F0A8 File Offset: 0x0017D2A8
	[CallerCount(0)]
	public unsafe void remove_OnParticipantAddedEvent(VivoxVoiceManager.ParticipantStatusChangedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_remove_OnParticipantAddedEvent_Public_rem_Void_ParticipantStatusChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FAD RID: 24493 RVA: 0x0017F104 File Offset: 0x0017D304
	[CallerCount(0)]
	public unsafe void add_OnParticipantRemovedEvent(VivoxVoiceManager.ParticipantStatusChangedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_add_OnParticipantRemovedEvent_Public_add_Void_ParticipantStatusChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FAE RID: 24494 RVA: 0x0017F160 File Offset: 0x0017D360
	[CallerCount(0)]
	public unsafe void remove_OnParticipantRemovedEvent(VivoxVoiceManager.ParticipantStatusChangedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_remove_OnParticipantRemovedEvent_Public_rem_Void_ParticipantStatusChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FAF RID: 24495 RVA: 0x0017F1BC File Offset: 0x0017D3BC
	[CallerCount(0)]
	public unsafe void add_OnTextMessageLogReceivedEvent(VivoxVoiceManager.ChannelTextMessageChangedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_add_OnTextMessageLogReceivedEvent_Public_add_Void_ChannelTextMessageChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FB0 RID: 24496 RVA: 0x0017F218 File Offset: 0x0017D418
	[CallerCount(0)]
	public unsafe void remove_OnTextMessageLogReceivedEvent(VivoxVoiceManager.ChannelTextMessageChangedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_remove_OnTextMessageLogReceivedEvent_Public_rem_Void_ChannelTextMessageChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FB1 RID: 24497 RVA: 0x0017F274 File Offset: 0x0017D474
	[CallerCount(0)]
	public unsafe void add_OnUserLoggedInEvent(VivoxVoiceManager.LoginStatusChangedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_add_OnUserLoggedInEvent_Public_add_Void_LoginStatusChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FB2 RID: 24498 RVA: 0x0017F2D0 File Offset: 0x0017D4D0
	[CallerCount(0)]
	public unsafe void remove_OnUserLoggedInEvent(VivoxVoiceManager.LoginStatusChangedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_remove_OnUserLoggedInEvent_Public_rem_Void_LoginStatusChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FB3 RID: 24499 RVA: 0x0017F32C File Offset: 0x0017D52C
	[CallerCount(0)]
	public unsafe void add_OnUserLoggedOutEvent(VivoxVoiceManager.LoginStatusChangedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_add_OnUserLoggedOutEvent_Public_add_Void_LoginStatusChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FB4 RID: 24500 RVA: 0x0017F388 File Offset: 0x0017D588
	[CallerCount(0)]
	public unsafe void remove_OnUserLoggedOutEvent(VivoxVoiceManager.LoginStatusChangedHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_remove_OnUserLoggedOutEvent_Public_rem_Void_LoginStatusChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x17002214 RID: 8724
	// (get) Token: 0x06005FB5 RID: 24501 RVA: 0x0017F3E4 File Offset: 0x0017D5E4
	// (set) Token: 0x06005FB6 RID: 24502 RVA: 0x0017F43C File Offset: 0x0017D63C
	public unsafe Uri _serverUri
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_get__serverUri_Private_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Uri(intPtr2) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_set__serverUri_Private_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x17002215 RID: 8725
	// (get) Token: 0x06005FB7 RID: 24503 RVA: 0x0017F498 File Offset: 0x0017D698
	public unsafe static VivoxVoiceManager Instance
	{
		[CallerCount(0)]
		get
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_VivoxVoiceManager_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new VivoxVoiceManager(intPtr2) : null;
		}
	}

	// Token: 0x17002216 RID: 8726
	// (get) Token: 0x06005FB8 RID: 24504 RVA: 0x0017F4E0 File Offset: 0x0017D6E0
	// (set) Token: 0x06005FB9 RID: 24505 RVA: 0x0017F530 File Offset: 0x0017D730
	public unsafe LoginState LoginState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_get_LoginState_Public_get_LoginState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_set_LoginState_Private_set_Void_LoginState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x17002217 RID: 8727
	// (get) Token: 0x06005FBA RID: 24506 RVA: 0x0017F584 File Offset: 0x0017D784
	public unsafe VivoxUnity.IReadOnlyDictionary<ChannelId, IChannelSession> ActiveChannels
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_get_ActiveChannels_Public_get_IReadOnlyDictionary_2_ChannelId_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new VivoxUnity.IReadOnlyDictionary<ChannelId, IChannelSession>(intPtr2) : null;
		}
	}

	// Token: 0x17002218 RID: 8728
	// (get) Token: 0x06005FBB RID: 24507 RVA: 0x0017F5DC File Offset: 0x0017D7DC
	public unsafe IAudioDevices AudioInputDevices
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_get_AudioInputDevices_Public_get_IAudioDevices_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAudioDevices(intPtr2) : null;
		}
	}

	// Token: 0x17002219 RID: 8729
	// (get) Token: 0x06005FBC RID: 24508 RVA: 0x0017F634 File Offset: 0x0017D834
	public unsafe IAudioDevices AudioOutputDevices
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_get_AudioOutputDevices_Public_get_IAudioDevices_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAudioDevices(intPtr2) : null;
		}
	}

	// Token: 0x1700221A RID: 8730
	// (get) Token: 0x06005FBD RID: 24509 RVA: 0x0017F68C File Offset: 0x0017D88C
	// (set) Token: 0x06005FBE RID: 24510 RVA: 0x0017F6E4 File Offset: 0x0017D8E4
	public unsafe IChannelSession TransmittingSession
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_get_TransmittingSession_Public_get_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IChannelSession(intPtr2) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_set_TransmittingSession_Public_set_Void_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x06005FBF RID: 24511 RVA: 0x0017F740 File Offset: 0x0017D940
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FC0 RID: 24512 RVA: 0x0017F784 File Offset: 0x0017D984
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FC1 RID: 24513 RVA: 0x0017F7C8 File Offset: 0x0017D9C8
	[CallerCount(0)]
	public unsafe void RegisterWiseGameobject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_RegisterWiseGameobject_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FC2 RID: 24514 RVA: 0x0017F80C File Offset: 0x0017DA0C
	[CallerCount(0)]
	public unsafe void UnRegisterWiseGameobject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_UnRegisterWiseGameobject_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FC3 RID: 24515 RVA: 0x0017F850 File Offset: 0x0017DA50
	[CallerCount(0)]
	public unsafe void PostAudioInputEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_PostAudioInputEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FC4 RID: 24516 RVA: 0x0017F894 File Offset: 0x0017DA94
	[CallerCount(0)]
	public unsafe void StopAudioInputEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_StopAudioInputEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FC5 RID: 24517 RVA: 0x0017F8D8 File Offset: 0x0017DAD8
	[CallerCount(0)]
	public unsafe void SetOutputToNoDevice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_SetOutputToNoDevice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FC6 RID: 24518 RVA: 0x0017F91C File Offset: 0x0017DB1C
	[CallerCount(0)]
	public unsafe bool AudioSamplesDelegate(uint playingID, uint channelIndex, Il2CppStructArray<float> samples)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref playingID;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelIndex;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(samples);
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_AudioSamplesDelegate_Private_Boolean_UInt32_UInt32_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06005FC7 RID: 24519 RVA: 0x0017F9AC File Offset: 0x0017DBAC
	[CallerCount(0)]
	public unsafe void AudioFormatDelegate(uint playingID, AkAudioFormat audioFormat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref playingID;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(audioFormat);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_AudioFormatDelegate_Private_Void_UInt32_AkAudioFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FC8 RID: 24520 RVA: 0x0017FA18 File Offset: 0x0017DC18
	[CallerCount(0)]
	public unsafe void OnAudioDataCallback(Action cb, string session_group_handle, string initial_target_uri, short* pcm_frames, int pcm_frame_count, int audio_frame_rate, int channels_per_frame, int is_silence)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(session_group_handle);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initial_target_uri);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pcm_frames);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pcm_frame_count;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref audio_frame_rate;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channels_per_frame;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref is_silence;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_OnAudioDataCallback_Private_Void_Action_String_String_ptr_Int16_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FC9 RID: 24521 RVA: 0x0017FB08 File Offset: 0x0017DD08
	[CallerCount(0)]
	public unsafe Il2CppStructArray<float> Convert16BitToFloat(Il2CppStructArray<byte> input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_Convert16BitToFloat_Public_ArrayOf_Single_ArrayOf_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
	}

	// Token: 0x06005FCA RID: 24522 RVA: 0x0017FB78 File Offset: 0x0017DD78
	[CallerCount(0)]
	public unsafe void OnApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FCB RID: 24523 RVA: 0x0017FBBC File Offset: 0x0017DDBC
	[CallerCount(0)]
	public unsafe void Login([Optional] string displayName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_Login_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FCC RID: 24524 RVA: 0x0017FC18 File Offset: 0x0017DE18
	[CallerCount(0)]
	public unsafe void Logout()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_Logout_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FCD RID: 24525 RVA: 0x0017FC5C File Offset: 0x0017DE5C
	[CallerCount(0)]
	public unsafe void JoinChannel(string channelName, ChannelType channelType, VivoxVoiceManager.ChatCapability chatCapability, bool switchTransmission = true, [Optional] Channel3DProperties properties)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(channelName);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelType;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chatCapability;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref switchTransmission;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_JoinChannel_Public_Void_String_ChannelType_ChatCapability_Boolean_Channel3DProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FCE RID: 24526 RVA: 0x0017FD08 File Offset: 0x0017DF08
	[CallerCount(0)]
	public unsafe void SendTextMessage(string messageToSend, ChannelId channel, [Optional] string applicationStanzaNamespace, [Optional] string applicationStanzaBody)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(messageToSend);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channel);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(applicationStanzaNamespace);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(applicationStanzaBody);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_SendTextMessage_Public_Void_String_ChannelId_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FCF RID: 24527 RVA: 0x0017FDAC File Offset: 0x0017DFAC
	[CallerCount(0)]
	public unsafe void DisconnectAllChannels()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_DisconnectAllChannels_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FD0 RID: 24528 RVA: 0x0017FDF0 File Offset: 0x0017DFF0
	[CallerCount(0)]
	public unsafe void OnMessageLogRecieved(Il2CppSystem.Object sender, QueueItemAddedEventArgs<IChannelTextMessage> textMessage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textMessage);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_OnMessageLogRecieved_Private_Void_Object_QueueItemAddedEventArgs_1_IChannelTextMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FD1 RID: 24529 RVA: 0x0017FE64 File Offset: 0x0017E064
	[CallerCount(0)]
	public unsafe void OnLoginSessionPropertyChanged(Il2CppSystem.Object sender, PropertyChangedEventArgs propertyChangedEventArgs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyChangedEventArgs);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_OnLoginSessionPropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FD2 RID: 24530 RVA: 0x0017FED8 File Offset: 0x0017E0D8
	[CallerCount(0)]
	public unsafe void OnParticipantAdded(Il2CppSystem.Object sender, KeyEventArg<string> keyEventArg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyEventArg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_OnParticipantAdded_Private_Void_Object_KeyEventArg_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FD3 RID: 24531 RVA: 0x0017FF4C File Offset: 0x0017E14C
	[CallerCount(0)]
	public unsafe void OnParticipantRemoved(Il2CppSystem.Object sender, KeyEventArg<string> keyEventArg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyEventArg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_OnParticipantRemoved_Private_Void_Object_KeyEventArg_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FD4 RID: 24532 RVA: 0x0017FFC0 File Offset: 0x0017E1C0
	[CallerCount(0)]
	public unsafe static void ValidateArgs(Il2CppReferenceArray<Il2CppSystem.Object> objs)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_ValidateArgs_Private_Static_Void_ArrayOf_Object_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FD5 RID: 24533 RVA: 0x0018000C File Offset: 0x0017E20C
	[CallerCount(0)]
	public unsafe void OnParticipantValueUpdated(Il2CppSystem.Object sender, ValueEventArg<string, IParticipant> valueEventArg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueEventArg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_OnParticipantValueUpdated_Private_Void_Object_ValueEventArg_2_String_IParticipant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FD6 RID: 24534 RVA: 0x00180080 File Offset: 0x0017E280
	[CallerCount(0)]
	public unsafe void OnChannelPropertyChanged(Il2CppSystem.Object sender, PropertyChangedEventArgs propertyChangedEventArgs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyChangedEventArgs);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_OnChannelPropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FD7 RID: 24535 RVA: 0x001800F4 File Offset: 0x0017E2F4
	[CallerCount(0)]
	public unsafe void VivoxLog(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_VivoxLog_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FD8 RID: 24536 RVA: 0x00180150 File Offset: 0x0017E350
	[CallerCount(0)]
	public unsafe void VivoxLogError(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr_VivoxLogError_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FD9 RID: 24537 RVA: 0x001801AC File Offset: 0x0017E3AC
	[CallerCount(0)]
	public unsafe VivoxVoiceManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FDA RID: 24538 RVA: 0x001801F8 File Offset: 0x0017E3F8
	[CallerCount(0)]
	public unsafe void _SetOutputToNoDevice_b__73_0(IAsyncResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr__SetOutputToNoDevice_b__73_0_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FDB RID: 24539 RVA: 0x00180254 File Offset: 0x0017E454
	[CallerCount(0)]
	public unsafe void _SetOutputToNoDevice_b__73_1(IAsyncResult result2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(result2);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr__SetOutputToNoDevice_b__73_1_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FDC RID: 24540 RVA: 0x001802B0 File Offset: 0x0017E4B0
	[CallerCount(0)]
	public unsafe void _Login_b__79_0(IAsyncResult ar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(ar);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.NativeMethodInfoPtr__Login_b__79_0_Private_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005FDD RID: 24541 RVA: 0x0018030C File Offset: 0x0017E50C
	// Note: this type is marked as 'beforefieldinit'.
	static VivoxVoiceManager()
	{
		Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VivoxVoiceManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr);
		VivoxVoiceManager.NativeFieldInfoPtr_OnSpeechDetectedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "OnSpeechDetectedEvent");
		VivoxVoiceManager.NativeFieldInfoPtr_OnAudioEnergyChangedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "OnAudioEnergyChangedEvent");
		VivoxVoiceManager.NativeFieldInfoPtr_OnParticipantAddedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "OnParticipantAddedEvent");
		VivoxVoiceManager.NativeFieldInfoPtr_OnParticipantRemovedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "OnParticipantRemovedEvent");
		VivoxVoiceManager.NativeFieldInfoPtr_OnTextMessageLogReceivedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "OnTextMessageLogReceivedEvent");
		VivoxVoiceManager.NativeFieldInfoPtr_OnUserLoggedInEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "OnUserLoggedInEvent");
		VivoxVoiceManager.NativeFieldInfoPtr_OnUserLoggedOutEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "OnUserLoggedOutEvent");
		VivoxVoiceManager.NativeFieldInfoPtr_audioInputEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "audioInputEvent");
		VivoxVoiceManager.NativeFieldInfoPtr_audioReceivedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "audioReceivedDelegate");
		VivoxVoiceManager.NativeFieldInfoPtr_audioReceivedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "audioReceivedCallback");
		VivoxVoiceManager.NativeFieldInfoPtr_channelMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "channelMask");
		VivoxVoiceManager.NativeFieldInfoPtr_audioChannelConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "audioChannelConfig");
		VivoxVoiceManager.NativeFieldInfoPtr__server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "_server");
		VivoxVoiceManager.NativeFieldInfoPtr__domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "_domain");
		VivoxVoiceManager.NativeFieldInfoPtr__tokenIssuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "_tokenIssuer");
		VivoxVoiceManager.NativeFieldInfoPtr__tokenKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "_tokenKey");
		VivoxVoiceManager.NativeFieldInfoPtr__tokenExpiration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "_tokenExpiration");
		VivoxVoiceManager.NativeFieldInfoPtr__client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "_client");
		VivoxVoiceManager.NativeFieldInfoPtr__accountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "_accountId");
		VivoxVoiceManager.NativeFieldInfoPtr_m_Lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "m_Lock");
		VivoxVoiceManager.NativeFieldInfoPtr_m_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "m_Instance");
		VivoxVoiceManager.NativeFieldInfoPtr__isPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "_isPlaying");
		VivoxVoiceManager.NativeFieldInfoPtr_numberOfChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "numberOfChannels");
		VivoxVoiceManager.NativeFieldInfoPtr_sampleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "sampleRate");
		VivoxVoiceManager.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "buffer");
		VivoxVoiceManager.NativeFieldInfoPtr__LoginState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "<LoginState>k__BackingField");
		VivoxVoiceManager.NativeFieldInfoPtr_LoginSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "LoginSession");
		VivoxVoiceManager.NativeMethodInfoPtr_add_OnSpeechDetectedEvent_Public_add_Void_ParticipantValueChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670883);
		VivoxVoiceManager.NativeMethodInfoPtr_remove_OnSpeechDetectedEvent_Public_rem_Void_ParticipantValueChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670884);
		VivoxVoiceManager.NativeMethodInfoPtr_add_OnAudioEnergyChangedEvent_Public_add_Void_ParticipantValueUpdatedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670885);
		VivoxVoiceManager.NativeMethodInfoPtr_remove_OnAudioEnergyChangedEvent_Public_rem_Void_ParticipantValueUpdatedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670886);
		VivoxVoiceManager.NativeMethodInfoPtr_add_OnParticipantAddedEvent_Public_add_Void_ParticipantStatusChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670887);
		VivoxVoiceManager.NativeMethodInfoPtr_remove_OnParticipantAddedEvent_Public_rem_Void_ParticipantStatusChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670888);
		VivoxVoiceManager.NativeMethodInfoPtr_add_OnParticipantRemovedEvent_Public_add_Void_ParticipantStatusChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670889);
		VivoxVoiceManager.NativeMethodInfoPtr_remove_OnParticipantRemovedEvent_Public_rem_Void_ParticipantStatusChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670890);
		VivoxVoiceManager.NativeMethodInfoPtr_add_OnTextMessageLogReceivedEvent_Public_add_Void_ChannelTextMessageChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670891);
		VivoxVoiceManager.NativeMethodInfoPtr_remove_OnTextMessageLogReceivedEvent_Public_rem_Void_ChannelTextMessageChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670892);
		VivoxVoiceManager.NativeMethodInfoPtr_add_OnUserLoggedInEvent_Public_add_Void_LoginStatusChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670893);
		VivoxVoiceManager.NativeMethodInfoPtr_remove_OnUserLoggedInEvent_Public_rem_Void_LoginStatusChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670894);
		VivoxVoiceManager.NativeMethodInfoPtr_add_OnUserLoggedOutEvent_Public_add_Void_LoginStatusChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670895);
		VivoxVoiceManager.NativeMethodInfoPtr_remove_OnUserLoggedOutEvent_Public_rem_Void_LoginStatusChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670896);
		VivoxVoiceManager.NativeMethodInfoPtr_get__serverUri_Private_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670897);
		VivoxVoiceManager.NativeMethodInfoPtr_set__serverUri_Private_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670898);
		VivoxVoiceManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_VivoxVoiceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670899);
		VivoxVoiceManager.NativeMethodInfoPtr_get_LoginState_Public_get_LoginState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670900);
		VivoxVoiceManager.NativeMethodInfoPtr_set_LoginState_Private_set_Void_LoginState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670901);
		VivoxVoiceManager.NativeMethodInfoPtr_get_ActiveChannels_Public_get_IReadOnlyDictionary_2_ChannelId_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670902);
		VivoxVoiceManager.NativeMethodInfoPtr_get_AudioInputDevices_Public_get_IAudioDevices_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670903);
		VivoxVoiceManager.NativeMethodInfoPtr_get_AudioOutputDevices_Public_get_IAudioDevices_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670904);
		VivoxVoiceManager.NativeMethodInfoPtr_get_TransmittingSession_Public_get_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670905);
		VivoxVoiceManager.NativeMethodInfoPtr_set_TransmittingSession_Public_set_Void_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670906);
		VivoxVoiceManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670907);
		VivoxVoiceManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670908);
		VivoxVoiceManager.NativeMethodInfoPtr_RegisterWiseGameobject_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670909);
		VivoxVoiceManager.NativeMethodInfoPtr_UnRegisterWiseGameobject_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670910);
		VivoxVoiceManager.NativeMethodInfoPtr_PostAudioInputEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670911);
		VivoxVoiceManager.NativeMethodInfoPtr_StopAudioInputEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670912);
		VivoxVoiceManager.NativeMethodInfoPtr_SetOutputToNoDevice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670913);
		VivoxVoiceManager.NativeMethodInfoPtr_AudioSamplesDelegate_Private_Boolean_UInt32_UInt32_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670914);
		VivoxVoiceManager.NativeMethodInfoPtr_AudioFormatDelegate_Private_Void_UInt32_AkAudioFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670915);
		VivoxVoiceManager.NativeMethodInfoPtr_OnAudioDataCallback_Private_Void_Action_String_String_ptr_Int16_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670916);
		VivoxVoiceManager.NativeMethodInfoPtr_Convert16BitToFloat_Public_ArrayOf_Single_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670917);
		VivoxVoiceManager.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670918);
		VivoxVoiceManager.NativeMethodInfoPtr_Login_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670919);
		VivoxVoiceManager.NativeMethodInfoPtr_Logout_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670920);
		VivoxVoiceManager.NativeMethodInfoPtr_JoinChannel_Public_Void_String_ChannelType_ChatCapability_Boolean_Channel3DProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670921);
		VivoxVoiceManager.NativeMethodInfoPtr_SendTextMessage_Public_Void_String_ChannelId_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670922);
		VivoxVoiceManager.NativeMethodInfoPtr_DisconnectAllChannels_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670923);
		VivoxVoiceManager.NativeMethodInfoPtr_OnMessageLogRecieved_Private_Void_Object_QueueItemAddedEventArgs_1_IChannelTextMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670924);
		VivoxVoiceManager.NativeMethodInfoPtr_OnLoginSessionPropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670925);
		VivoxVoiceManager.NativeMethodInfoPtr_OnParticipantAdded_Private_Void_Object_KeyEventArg_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670926);
		VivoxVoiceManager.NativeMethodInfoPtr_OnParticipantRemoved_Private_Void_Object_KeyEventArg_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670927);
		VivoxVoiceManager.NativeMethodInfoPtr_ValidateArgs_Private_Static_Void_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670928);
		VivoxVoiceManager.NativeMethodInfoPtr_OnParticipantValueUpdated_Private_Void_Object_ValueEventArg_2_String_IParticipant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670929);
		VivoxVoiceManager.NativeMethodInfoPtr_OnChannelPropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670930);
		VivoxVoiceManager.NativeMethodInfoPtr_VivoxLog_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670931);
		VivoxVoiceManager.NativeMethodInfoPtr_VivoxLogError_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670932);
		VivoxVoiceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670933);
		VivoxVoiceManager.NativeMethodInfoPtr__SetOutputToNoDevice_b__73_0_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670935);
		VivoxVoiceManager.NativeMethodInfoPtr__SetOutputToNoDevice_b__73_1_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670936);
		VivoxVoiceManager.NativeMethodInfoPtr__Login_b__79_0_Private_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, 100670937);
	}

	// Token: 0x06005FDE RID: 24542 RVA: 0x0000210C File Offset: 0x0000030C
	public VivoxVoiceManager(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170021F8 RID: 8696
	// (get) Token: 0x06005FDF RID: 24543 RVA: 0x00180990 File Offset: 0x0017EB90
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr));
		}
	}

	// Token: 0x170021F9 RID: 8697
	// (get) Token: 0x06005FE0 RID: 24544 RVA: 0x001809A4 File Offset: 0x0017EBA4
	// (set) Token: 0x06005FE1 RID: 24545 RVA: 0x001809D8 File Offset: 0x0017EBD8
	public unsafe VivoxVoiceManager.ParticipantValueChangedHandler OnSpeechDetectedEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnSpeechDetectedEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VivoxVoiceManager.ParticipantValueChangedHandler(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnSpeechDetectedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170021FA RID: 8698
	// (get) Token: 0x06005FE2 RID: 24546 RVA: 0x00180A00 File Offset: 0x0017EC00
	// (set) Token: 0x06005FE3 RID: 24547 RVA: 0x00180A34 File Offset: 0x0017EC34
	public unsafe VivoxVoiceManager.ParticipantValueUpdatedHandler OnAudioEnergyChangedEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnAudioEnergyChangedEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VivoxVoiceManager.ParticipantValueUpdatedHandler(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnAudioEnergyChangedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170021FB RID: 8699
	// (get) Token: 0x06005FE4 RID: 24548 RVA: 0x00180A5C File Offset: 0x0017EC5C
	// (set) Token: 0x06005FE5 RID: 24549 RVA: 0x00180A90 File Offset: 0x0017EC90
	public unsafe VivoxVoiceManager.ParticipantStatusChangedHandler OnParticipantAddedEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnParticipantAddedEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VivoxVoiceManager.ParticipantStatusChangedHandler(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnParticipantAddedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170021FC RID: 8700
	// (get) Token: 0x06005FE6 RID: 24550 RVA: 0x00180AB8 File Offset: 0x0017ECB8
	// (set) Token: 0x06005FE7 RID: 24551 RVA: 0x00180AEC File Offset: 0x0017ECEC
	public unsafe VivoxVoiceManager.ParticipantStatusChangedHandler OnParticipantRemovedEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnParticipantRemovedEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VivoxVoiceManager.ParticipantStatusChangedHandler(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnParticipantRemovedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170021FD RID: 8701
	// (get) Token: 0x06005FE8 RID: 24552 RVA: 0x00180B14 File Offset: 0x0017ED14
	// (set) Token: 0x06005FE9 RID: 24553 RVA: 0x00180B48 File Offset: 0x0017ED48
	public unsafe VivoxVoiceManager.ChannelTextMessageChangedHandler OnTextMessageLogReceivedEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnTextMessageLogReceivedEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VivoxVoiceManager.ChannelTextMessageChangedHandler(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnTextMessageLogReceivedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170021FE RID: 8702
	// (get) Token: 0x06005FEA RID: 24554 RVA: 0x00180B70 File Offset: 0x0017ED70
	// (set) Token: 0x06005FEB RID: 24555 RVA: 0x00180BA4 File Offset: 0x0017EDA4
	public unsafe VivoxVoiceManager.LoginStatusChangedHandler OnUserLoggedInEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnUserLoggedInEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VivoxVoiceManager.LoginStatusChangedHandler(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnUserLoggedInEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170021FF RID: 8703
	// (get) Token: 0x06005FEC RID: 24556 RVA: 0x00180BCC File Offset: 0x0017EDCC
	// (set) Token: 0x06005FED RID: 24557 RVA: 0x00180C00 File Offset: 0x0017EE00
	public unsafe VivoxVoiceManager.LoginStatusChangedHandler OnUserLoggedOutEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnUserLoggedOutEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VivoxVoiceManager.LoginStatusChangedHandler(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_OnUserLoggedOutEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002200 RID: 8704
	// (get) Token: 0x06005FEE RID: 24558 RVA: 0x00180C28 File Offset: 0x0017EE28
	// (set) Token: 0x06005FEF RID: 24559 RVA: 0x00180C5C File Offset: 0x0017EE5C
	public unsafe AK.Wwise.Event audioInputEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_audioInputEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_audioInputEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002201 RID: 8705
	// (get) Token: 0x06005FF0 RID: 24560 RVA: 0x00180C84 File Offset: 0x0017EE84
	// (set) Token: 0x06005FF1 RID: 24561 RVA: 0x00180CAF File Offset: 0x0017EEAF
	public unsafe static VivoxVoiceManager.AudioReceivedDelegate audioReceivedDelegate
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(VivoxVoiceManager.NativeFieldInfoPtr_audioReceivedDelegate, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new VivoxVoiceManager.AudioReceivedDelegate(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VivoxVoiceManager.NativeFieldInfoPtr_audioReceivedDelegate, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002202 RID: 8706
	// (get) Token: 0x06005FF2 RID: 24562 RVA: 0x00180CC4 File Offset: 0x0017EEC4
	// (set) Token: 0x06005FF3 RID: 24563 RVA: 0x00180CEF File Offset: 0x0017EEEF
	public unsafe static SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int_int__void audioReceivedCallback
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(VivoxVoiceManager.NativeFieldInfoPtr_audioReceivedCallback, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_short_int_int_int_int__void(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VivoxVoiceManager.NativeFieldInfoPtr_audioReceivedCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002203 RID: 8707
	// (get) Token: 0x06005FF4 RID: 24564 RVA: 0x00180D04 File Offset: 0x0017EF04
	// (set) Token: 0x06005FF5 RID: 24565 RVA: 0x00180D2C File Offset: 0x0017EF2C
	public unsafe VivoxVoiceManager.ChannelMask channelMask
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_channelMask);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_channelMask)) = value;
		}
	}

	// Token: 0x17002204 RID: 8708
	// (get) Token: 0x06005FF6 RID: 24566 RVA: 0x00180D50 File Offset: 0x0017EF50
	// (set) Token: 0x06005FF7 RID: 24567 RVA: 0x00180D84 File Offset: 0x0017EF84
	public unsafe AkChannelConfig audioChannelConfig
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_audioChannelConfig);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AkChannelConfig(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_audioChannelConfig), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002205 RID: 8709
	// (get) Token: 0x06005FF8 RID: 24568 RVA: 0x00180DAC File Offset: 0x0017EFAC
	// (set) Token: 0x06005FF9 RID: 24569 RVA: 0x00180DD5 File Offset: 0x0017EFD5
	public unsafe string _server
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__server);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__server), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17002206 RID: 8710
	// (get) Token: 0x06005FFA RID: 24570 RVA: 0x00180DFC File Offset: 0x0017EFFC
	// (set) Token: 0x06005FFB RID: 24571 RVA: 0x00180E25 File Offset: 0x0017F025
	public unsafe string _domain
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__domain);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__domain), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17002207 RID: 8711
	// (get) Token: 0x06005FFC RID: 24572 RVA: 0x00180E4C File Offset: 0x0017F04C
	// (set) Token: 0x06005FFD RID: 24573 RVA: 0x00180E75 File Offset: 0x0017F075
	public unsafe string _tokenIssuer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__tokenIssuer);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__tokenIssuer), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17002208 RID: 8712
	// (get) Token: 0x06005FFE RID: 24574 RVA: 0x00180E9C File Offset: 0x0017F09C
	// (set) Token: 0x06005FFF RID: 24575 RVA: 0x00180EC5 File Offset: 0x0017F0C5
	public unsafe string _tokenKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__tokenKey);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__tokenKey), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17002209 RID: 8713
	// (get) Token: 0x06006000 RID: 24576 RVA: 0x00180EEC File Offset: 0x0017F0EC
	// (set) Token: 0x06006001 RID: 24577 RVA: 0x00180F14 File Offset: 0x0017F114
	public unsafe TimeSpan _tokenExpiration
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__tokenExpiration);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__tokenExpiration)) = value;
		}
	}

	// Token: 0x1700220A RID: 8714
	// (get) Token: 0x06006002 RID: 24578 RVA: 0x00180F38 File Offset: 0x0017F138
	// (set) Token: 0x06006003 RID: 24579 RVA: 0x00180F6C File Offset: 0x0017F16C
	public unsafe Client _client
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__client);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Client(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__client), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700220B RID: 8715
	// (get) Token: 0x06006004 RID: 24580 RVA: 0x00180F94 File Offset: 0x0017F194
	// (set) Token: 0x06006005 RID: 24581 RVA: 0x00180FC8 File Offset: 0x0017F1C8
	public unsafe AccountId _accountId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__accountId);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AccountId(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__accountId), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700220C RID: 8716
	// (get) Token: 0x06006006 RID: 24582 RVA: 0x00180FF0 File Offset: 0x0017F1F0
	// (set) Token: 0x06006007 RID: 24583 RVA: 0x0018101B File Offset: 0x0017F21B
	public unsafe static Il2CppSystem.Object m_Lock
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(VivoxVoiceManager.NativeFieldInfoPtr_m_Lock, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VivoxVoiceManager.NativeFieldInfoPtr_m_Lock, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700220D RID: 8717
	// (get) Token: 0x06006008 RID: 24584 RVA: 0x00181030 File Offset: 0x0017F230
	// (set) Token: 0x06006009 RID: 24585 RVA: 0x0018105B File Offset: 0x0017F25B
	public unsafe static VivoxVoiceManager m_Instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(VivoxVoiceManager.NativeFieldInfoPtr_m_Instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new VivoxVoiceManager(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VivoxVoiceManager.NativeFieldInfoPtr_m_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700220E RID: 8718
	// (get) Token: 0x0600600A RID: 24586 RVA: 0x00181070 File Offset: 0x0017F270
	// (set) Token: 0x0600600B RID: 24587 RVA: 0x00181098 File Offset: 0x0017F298
	public unsafe bool _isPlaying
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__isPlaying);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__isPlaying)) = value;
		}
	}

	// Token: 0x1700220F RID: 8719
	// (get) Token: 0x0600600C RID: 24588 RVA: 0x001810BC File Offset: 0x0017F2BC
	// (set) Token: 0x0600600D RID: 24589 RVA: 0x001810E4 File Offset: 0x0017F2E4
	public unsafe uint numberOfChannels
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_numberOfChannels);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_numberOfChannels)) = value;
		}
	}

	// Token: 0x17002210 RID: 8720
	// (get) Token: 0x0600600E RID: 24590 RVA: 0x00181108 File Offset: 0x0017F308
	// (set) Token: 0x0600600F RID: 24591 RVA: 0x00181130 File Offset: 0x0017F330
	public unsafe uint sampleRate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_sampleRate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_sampleRate)) = value;
		}
	}

	// Token: 0x17002211 RID: 8721
	// (get) Token: 0x06006010 RID: 24592 RVA: 0x00181154 File Offset: 0x0017F354
	// (set) Token: 0x06006011 RID: 24593 RVA: 0x00181188 File Offset: 0x0017F388
	public unsafe List<float> buffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_buffer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<float>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002212 RID: 8722
	// (get) Token: 0x06006012 RID: 24594 RVA: 0x001811B0 File Offset: 0x0017F3B0
	// (set) Token: 0x06006013 RID: 24595 RVA: 0x001811D8 File Offset: 0x0017F3D8
	public unsafe LoginState _LoginState_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__LoginState_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr__LoginState_k__BackingField)) = value;
		}
	}

	// Token: 0x17002213 RID: 8723
	// (get) Token: 0x06006014 RID: 24596 RVA: 0x001811FC File Offset: 0x0017F3FC
	// (set) Token: 0x06006015 RID: 24597 RVA: 0x00181230 File Offset: 0x0017F430
	public unsafe ILoginSession LoginSession
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_LoginSession);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new ILoginSession(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.NativeFieldInfoPtr_LoginSession), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04003C6E RID: 15470
	private static readonly IntPtr NativeFieldInfoPtr_OnSpeechDetectedEvent;

	// Token: 0x04003C6F RID: 15471
	private static readonly IntPtr NativeFieldInfoPtr_OnAudioEnergyChangedEvent;

	// Token: 0x04003C70 RID: 15472
	private static readonly IntPtr NativeFieldInfoPtr_OnParticipantAddedEvent;

	// Token: 0x04003C71 RID: 15473
	private static readonly IntPtr NativeFieldInfoPtr_OnParticipantRemovedEvent;

	// Token: 0x04003C72 RID: 15474
	private static readonly IntPtr NativeFieldInfoPtr_OnTextMessageLogReceivedEvent;

	// Token: 0x04003C73 RID: 15475
	private static readonly IntPtr NativeFieldInfoPtr_OnUserLoggedInEvent;

	// Token: 0x04003C74 RID: 15476
	private static readonly IntPtr NativeFieldInfoPtr_OnUserLoggedOutEvent;

	// Token: 0x04003C75 RID: 15477
	private static readonly IntPtr NativeFieldInfoPtr_audioInputEvent;

	// Token: 0x04003C76 RID: 15478
	private static readonly IntPtr NativeFieldInfoPtr_audioReceivedDelegate;

	// Token: 0x04003C77 RID: 15479
	private static readonly IntPtr NativeFieldInfoPtr_audioReceivedCallback;

	// Token: 0x04003C78 RID: 15480
	private static readonly IntPtr NativeFieldInfoPtr_channelMask;

	// Token: 0x04003C79 RID: 15481
	private static readonly IntPtr NativeFieldInfoPtr_audioChannelConfig;

	// Token: 0x04003C7A RID: 15482
	private static readonly IntPtr NativeFieldInfoPtr__server;

	// Token: 0x04003C7B RID: 15483
	private static readonly IntPtr NativeFieldInfoPtr__domain;

	// Token: 0x04003C7C RID: 15484
	private static readonly IntPtr NativeFieldInfoPtr__tokenIssuer;

	// Token: 0x04003C7D RID: 15485
	private static readonly IntPtr NativeFieldInfoPtr__tokenKey;

	// Token: 0x04003C7E RID: 15486
	private static readonly IntPtr NativeFieldInfoPtr__tokenExpiration;

	// Token: 0x04003C7F RID: 15487
	private static readonly IntPtr NativeFieldInfoPtr__client;

	// Token: 0x04003C80 RID: 15488
	private static readonly IntPtr NativeFieldInfoPtr__accountId;

	// Token: 0x04003C81 RID: 15489
	private static readonly IntPtr NativeFieldInfoPtr_m_Lock;

	// Token: 0x04003C82 RID: 15490
	private static readonly IntPtr NativeFieldInfoPtr_m_Instance;

	// Token: 0x04003C83 RID: 15491
	private static readonly IntPtr NativeFieldInfoPtr__isPlaying;

	// Token: 0x04003C84 RID: 15492
	private static readonly IntPtr NativeFieldInfoPtr_numberOfChannels;

	// Token: 0x04003C85 RID: 15493
	private static readonly IntPtr NativeFieldInfoPtr_sampleRate;

	// Token: 0x04003C86 RID: 15494
	private static readonly IntPtr NativeFieldInfoPtr_buffer;

	// Token: 0x04003C87 RID: 15495
	private static readonly IntPtr NativeFieldInfoPtr__LoginState_k__BackingField;

	// Token: 0x04003C88 RID: 15496
	private static readonly IntPtr NativeFieldInfoPtr_LoginSession;

	// Token: 0x04003C89 RID: 15497
	private static readonly IntPtr NativeMethodInfoPtr_add_OnSpeechDetectedEvent_Public_add_Void_ParticipantValueChangedHandler_0;

	// Token: 0x04003C8A RID: 15498
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnSpeechDetectedEvent_Public_rem_Void_ParticipantValueChangedHandler_0;

	// Token: 0x04003C8B RID: 15499
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAudioEnergyChangedEvent_Public_add_Void_ParticipantValueUpdatedHandler_0;

	// Token: 0x04003C8C RID: 15500
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAudioEnergyChangedEvent_Public_rem_Void_ParticipantValueUpdatedHandler_0;

	// Token: 0x04003C8D RID: 15501
	private static readonly IntPtr NativeMethodInfoPtr_add_OnParticipantAddedEvent_Public_add_Void_ParticipantStatusChangedHandler_0;

	// Token: 0x04003C8E RID: 15502
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnParticipantAddedEvent_Public_rem_Void_ParticipantStatusChangedHandler_0;

	// Token: 0x04003C8F RID: 15503
	private static readonly IntPtr NativeMethodInfoPtr_add_OnParticipantRemovedEvent_Public_add_Void_ParticipantStatusChangedHandler_0;

	// Token: 0x04003C90 RID: 15504
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnParticipantRemovedEvent_Public_rem_Void_ParticipantStatusChangedHandler_0;

	// Token: 0x04003C91 RID: 15505
	private static readonly IntPtr NativeMethodInfoPtr_add_OnTextMessageLogReceivedEvent_Public_add_Void_ChannelTextMessageChangedHandler_0;

	// Token: 0x04003C92 RID: 15506
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnTextMessageLogReceivedEvent_Public_rem_Void_ChannelTextMessageChangedHandler_0;

	// Token: 0x04003C93 RID: 15507
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUserLoggedInEvent_Public_add_Void_LoginStatusChangedHandler_0;

	// Token: 0x04003C94 RID: 15508
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUserLoggedInEvent_Public_rem_Void_LoginStatusChangedHandler_0;

	// Token: 0x04003C95 RID: 15509
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUserLoggedOutEvent_Public_add_Void_LoginStatusChangedHandler_0;

	// Token: 0x04003C96 RID: 15510
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUserLoggedOutEvent_Public_rem_Void_LoginStatusChangedHandler_0;

	// Token: 0x04003C97 RID: 15511
	private static readonly IntPtr NativeMethodInfoPtr_get__serverUri_Private_get_Uri_0;

	// Token: 0x04003C98 RID: 15512
	private static readonly IntPtr NativeMethodInfoPtr_set__serverUri_Private_set_Void_Uri_0;

	// Token: 0x04003C99 RID: 15513
	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_VivoxVoiceManager_0;

	// Token: 0x04003C9A RID: 15514
	private static readonly IntPtr NativeMethodInfoPtr_get_LoginState_Public_get_LoginState_0;

	// Token: 0x04003C9B RID: 15515
	private static readonly IntPtr NativeMethodInfoPtr_set_LoginState_Private_set_Void_LoginState_0;

	// Token: 0x04003C9C RID: 15516
	private static readonly IntPtr NativeMethodInfoPtr_get_ActiveChannels_Public_get_IReadOnlyDictionary_2_ChannelId_IChannelSession_0;

	// Token: 0x04003C9D RID: 15517
	private static readonly IntPtr NativeMethodInfoPtr_get_AudioInputDevices_Public_get_IAudioDevices_0;

	// Token: 0x04003C9E RID: 15518
	private static readonly IntPtr NativeMethodInfoPtr_get_AudioOutputDevices_Public_get_IAudioDevices_0;

	// Token: 0x04003C9F RID: 15519
	private static readonly IntPtr NativeMethodInfoPtr_get_TransmittingSession_Public_get_IChannelSession_0;

	// Token: 0x04003CA0 RID: 15520
	private static readonly IntPtr NativeMethodInfoPtr_set_TransmittingSession_Public_set_Void_IChannelSession_0;

	// Token: 0x04003CA1 RID: 15521
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04003CA2 RID: 15522
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04003CA3 RID: 15523
	private static readonly IntPtr NativeMethodInfoPtr_RegisterWiseGameobject_Public_Void_0;

	// Token: 0x04003CA4 RID: 15524
	private static readonly IntPtr NativeMethodInfoPtr_UnRegisterWiseGameobject_Public_Void_0;

	// Token: 0x04003CA5 RID: 15525
	private static readonly IntPtr NativeMethodInfoPtr_PostAudioInputEvent_Public_Void_0;

	// Token: 0x04003CA6 RID: 15526
	private static readonly IntPtr NativeMethodInfoPtr_StopAudioInputEvent_Public_Void_0;

	// Token: 0x04003CA7 RID: 15527
	private static readonly IntPtr NativeMethodInfoPtr_SetOutputToNoDevice_Public_Void_0;

	// Token: 0x04003CA8 RID: 15528
	private static readonly IntPtr NativeMethodInfoPtr_AudioSamplesDelegate_Private_Boolean_UInt32_UInt32_ArrayOf_Single_0;

	// Token: 0x04003CA9 RID: 15529
	private static readonly IntPtr NativeMethodInfoPtr_AudioFormatDelegate_Private_Void_UInt32_AkAudioFormat_0;

	// Token: 0x04003CAA RID: 15530
	private static readonly IntPtr NativeMethodInfoPtr_OnAudioDataCallback_Private_Void_Action_String_String_ptr_Int16_Int32_Int32_Int32_Int32_0;

	// Token: 0x04003CAB RID: 15531
	private static readonly IntPtr NativeMethodInfoPtr_Convert16BitToFloat_Public_ArrayOf_Single_ArrayOf_Byte_0;

	// Token: 0x04003CAC RID: 15532
	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

	// Token: 0x04003CAD RID: 15533
	private static readonly IntPtr NativeMethodInfoPtr_Login_Public_Void_String_0;

	// Token: 0x04003CAE RID: 15534
	private static readonly IntPtr NativeMethodInfoPtr_Logout_Public_Void_0;

	// Token: 0x04003CAF RID: 15535
	private static readonly IntPtr NativeMethodInfoPtr_JoinChannel_Public_Void_String_ChannelType_ChatCapability_Boolean_Channel3DProperties_0;

	// Token: 0x04003CB0 RID: 15536
	private static readonly IntPtr NativeMethodInfoPtr_SendTextMessage_Public_Void_String_ChannelId_String_String_0;

	// Token: 0x04003CB1 RID: 15537
	private static readonly IntPtr NativeMethodInfoPtr_DisconnectAllChannels_Public_Void_0;

	// Token: 0x04003CB2 RID: 15538
	private static readonly IntPtr NativeMethodInfoPtr_OnMessageLogRecieved_Private_Void_Object_QueueItemAddedEventArgs_1_IChannelTextMessage_0;

	// Token: 0x04003CB3 RID: 15539
	private static readonly IntPtr NativeMethodInfoPtr_OnLoginSessionPropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0;

	// Token: 0x04003CB4 RID: 15540
	private static readonly IntPtr NativeMethodInfoPtr_OnParticipantAdded_Private_Void_Object_KeyEventArg_1_String_0;

	// Token: 0x04003CB5 RID: 15541
	private static readonly IntPtr NativeMethodInfoPtr_OnParticipantRemoved_Private_Void_Object_KeyEventArg_1_String_0;

	// Token: 0x04003CB6 RID: 15542
	private static readonly IntPtr NativeMethodInfoPtr_ValidateArgs_Private_Static_Void_ArrayOf_Object_0;

	// Token: 0x04003CB7 RID: 15543
	private static readonly IntPtr NativeMethodInfoPtr_OnParticipantValueUpdated_Private_Void_Object_ValueEventArg_2_String_IParticipant_0;

	// Token: 0x04003CB8 RID: 15544
	private static readonly IntPtr NativeMethodInfoPtr_OnChannelPropertyChanged_Private_Void_Object_PropertyChangedEventArgs_0;

	// Token: 0x04003CB9 RID: 15545
	private static readonly IntPtr NativeMethodInfoPtr_VivoxLog_Private_Void_String_0;

	// Token: 0x04003CBA RID: 15546
	private static readonly IntPtr NativeMethodInfoPtr_VivoxLogError_Private_Void_String_0;

	// Token: 0x04003CBB RID: 15547
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04003CBC RID: 15548
	private static readonly IntPtr NativeMethodInfoPtr__SetOutputToNoDevice_b__73_0_Private_Void_IAsyncResult_0;

	// Token: 0x04003CBD RID: 15549
	private static readonly IntPtr NativeMethodInfoPtr__SetOutputToNoDevice_b__73_1_Private_Void_IAsyncResult_0;

	// Token: 0x04003CBE RID: 15550
	private static readonly IntPtr NativeMethodInfoPtr__Login_b__79_0_Private_Void_IAsyncResult_0;

	// Token: 0x020004B0 RID: 1200
	public enum ChangedProperty
	{
		// Token: 0x04003CC0 RID: 15552
		None,
		// Token: 0x04003CC1 RID: 15553
		Speaking,
		// Token: 0x04003CC2 RID: 15554
		Typing,
		// Token: 0x04003CC3 RID: 15555
		Muted
	}

	// Token: 0x020004B1 RID: 1201
	public enum ChatCapability
	{
		// Token: 0x04003CC5 RID: 15557
		TextOnly,
		// Token: 0x04003CC6 RID: 15558
		AudioOnly,
		// Token: 0x04003CC7 RID: 15559
		TextAndAudio
	}

	// Token: 0x020004B2 RID: 1202
	public enum ChannelMask
	{
		// Token: 0x04003CC9 RID: 15561
		NONE,
		// Token: 0x04003CCA RID: 15562
		FRONT_LEFT,
		// Token: 0x04003CCB RID: 15563
		FRONT_RIGHT,
		// Token: 0x04003CCC RID: 15564
		FRONT_CENTER = 4,
		// Token: 0x04003CCD RID: 15565
		SETUP_MONO = 4,
		// Token: 0x04003CCE RID: 15566
		SETUP_STEREO = 3
	}

	// Token: 0x020004B3 RID: 1203
	public sealed class ParticipantValueChangedHandler : MulticastDelegate
	{
		// Token: 0x0600601C RID: 24604 RVA: 0x001812CC File Offset: 0x0017F4CC
		[CallerCount(0)]
		public unsafe ParticipantValueChangedHandler(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueChangedHandler>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ParticipantValueChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600601D RID: 24605 RVA: 0x00181344 File Offset: 0x0017F544
		[CallerCount(0)]
		public unsafe void Invoke(string username, ChannelId channel, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ParticipantValueChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ChannelId_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600601E RID: 24606 RVA: 0x001813C8 File Offset: 0x0017F5C8
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(string username, ChannelId channel, bool value, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ParticipantValueChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ChannelId_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x00181490 File Offset: 0x0017F690
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ParticipantValueChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x001814EC File Offset: 0x0017F6EC
		// Note: this type is marked as 'beforefieldinit'.
		static ParticipantValueChangedHandler()
		{
			Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "ParticipantValueChangedHandler");
			VivoxVoiceManager.ParticipantValueChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueChangedHandler>.NativeClassPtr, 100670938);
			VivoxVoiceManager.ParticipantValueChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ChannelId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueChangedHandler>.NativeClassPtr, 100670939);
			VivoxVoiceManager.ParticipantValueChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ChannelId_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueChangedHandler>.NativeClassPtr, 100670940);
			VivoxVoiceManager.ParticipantValueChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueChangedHandler>.NativeClassPtr, 100670941);
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x00005E35 File Offset: 0x00004035
		public ParticipantValueChangedHandler(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x06006022 RID: 24610 RVA: 0x0018155D File Offset: 0x0017F75D
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueChangedHandler>.NativeClassPtr));
			}
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x0018156E File Offset: 0x0017F76E
		public static implicit operator VivoxVoiceManager.ParticipantValueChangedHandler(Action<string, ChannelId, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<VivoxVoiceManager.ParticipantValueChangedHandler>(A_0);
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x00181576 File Offset: 0x0017F776
		public static VivoxVoiceManager.ParticipantValueChangedHandler operator +(VivoxVoiceManager.ParticipantValueChangedHandler A_0, VivoxVoiceManager.ParticipantValueChangedHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<VivoxVoiceManager.ParticipantValueChangedHandler>();
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x00181584 File Offset: 0x0017F784
		public static VivoxVoiceManager.ParticipantValueChangedHandler operator -(VivoxVoiceManager.ParticipantValueChangedHandler A_0, VivoxVoiceManager.ParticipantValueChangedHandler A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<VivoxVoiceManager.ParticipantValueChangedHandler>();
			}
			return result;
		}

		// Token: 0x04003CCF RID: 15567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003CD0 RID: 15568
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ChannelId_Boolean_0;

		// Token: 0x04003CD1 RID: 15569
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ChannelId_Boolean_AsyncCallback_Object_0;

		// Token: 0x04003CD2 RID: 15570
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020004B4 RID: 1204
	public sealed class ParticipantValueUpdatedHandler : MulticastDelegate
	{
		// Token: 0x06006026 RID: 24614 RVA: 0x00181598 File Offset: 0x0017F798
		[CallerCount(0)]
		public unsafe ParticipantValueUpdatedHandler(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueUpdatedHandler>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ParticipantValueUpdatedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x00181610 File Offset: 0x0017F810
		[CallerCount(0)]
		public unsafe void Invoke(string username, ChannelId channel, double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ParticipantValueUpdatedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ChannelId_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x00181694 File Offset: 0x0017F894
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(string username, ChannelId channel, double value, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ParticipantValueUpdatedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ChannelId_Double_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x0018175C File Offset: 0x0017F95C
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ParticipantValueUpdatedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x001817B8 File Offset: 0x0017F9B8
		// Note: this type is marked as 'beforefieldinit'.
		static ParticipantValueUpdatedHandler()
		{
			Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueUpdatedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "ParticipantValueUpdatedHandler");
			VivoxVoiceManager.ParticipantValueUpdatedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueUpdatedHandler>.NativeClassPtr, 100670942);
			VivoxVoiceManager.ParticipantValueUpdatedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ChannelId_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueUpdatedHandler>.NativeClassPtr, 100670943);
			VivoxVoiceManager.ParticipantValueUpdatedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ChannelId_Double_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueUpdatedHandler>.NativeClassPtr, 100670944);
			VivoxVoiceManager.ParticipantValueUpdatedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueUpdatedHandler>.NativeClassPtr, 100670945);
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x00005E35 File Offset: 0x00004035
		public ParticipantValueUpdatedHandler(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x0600602C RID: 24620 RVA: 0x00181829 File Offset: 0x0017FA29
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantValueUpdatedHandler>.NativeClassPtr));
			}
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x0018183A File Offset: 0x0017FA3A
		public static implicit operator VivoxVoiceManager.ParticipantValueUpdatedHandler(Action<string, ChannelId, double> A_0)
		{
			return DelegateSupport.ConvertDelegate<VivoxVoiceManager.ParticipantValueUpdatedHandler>(A_0);
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x00181842 File Offset: 0x0017FA42
		public static VivoxVoiceManager.ParticipantValueUpdatedHandler operator +(VivoxVoiceManager.ParticipantValueUpdatedHandler A_0, VivoxVoiceManager.ParticipantValueUpdatedHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<VivoxVoiceManager.ParticipantValueUpdatedHandler>();
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x00181850 File Offset: 0x0017FA50
		public static VivoxVoiceManager.ParticipantValueUpdatedHandler operator -(VivoxVoiceManager.ParticipantValueUpdatedHandler A_0, VivoxVoiceManager.ParticipantValueUpdatedHandler A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<VivoxVoiceManager.ParticipantValueUpdatedHandler>();
			}
			return result;
		}

		// Token: 0x04003CD3 RID: 15571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003CD4 RID: 15572
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ChannelId_Double_0;

		// Token: 0x04003CD5 RID: 15573
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ChannelId_Double_AsyncCallback_Object_0;

		// Token: 0x04003CD6 RID: 15574
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020004B5 RID: 1205
	public sealed class ParticipantStatusChangedHandler : MulticastDelegate
	{
		// Token: 0x06006030 RID: 24624 RVA: 0x00181864 File Offset: 0x0017FA64
		[CallerCount(0)]
		public unsafe ParticipantStatusChangedHandler(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantStatusChangedHandler>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ParticipantStatusChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x001818DC File Offset: 0x0017FADC
		[CallerCount(0)]
		public unsafe void Invoke(string username, ChannelId channel, IParticipant participant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(participant);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ParticipantStatusChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ChannelId_IParticipant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x00181968 File Offset: 0x0017FB68
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(string username, ChannelId channel, IParticipant participant, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(participant);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ParticipantStatusChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ChannelId_IParticipant_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x00181A38 File Offset: 0x0017FC38
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ParticipantStatusChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x00181A94 File Offset: 0x0017FC94
		// Note: this type is marked as 'beforefieldinit'.
		static ParticipantStatusChangedHandler()
		{
			Il2CppClassPointerStore<VivoxVoiceManager.ParticipantStatusChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "ParticipantStatusChangedHandler");
			VivoxVoiceManager.ParticipantStatusChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantStatusChangedHandler>.NativeClassPtr, 100670946);
			VivoxVoiceManager.ParticipantStatusChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ChannelId_IParticipant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantStatusChangedHandler>.NativeClassPtr, 100670947);
			VivoxVoiceManager.ParticipantStatusChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ChannelId_IParticipant_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantStatusChangedHandler>.NativeClassPtr, 100670948);
			VivoxVoiceManager.ParticipantStatusChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantStatusChangedHandler>.NativeClassPtr, 100670949);
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x00005E35 File Offset: 0x00004035
		public ParticipantStatusChangedHandler(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x06006036 RID: 24630 RVA: 0x00181B05 File Offset: 0x0017FD05
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VivoxVoiceManager.ParticipantStatusChangedHandler>.NativeClassPtr));
			}
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x00181B16 File Offset: 0x0017FD16
		public static implicit operator VivoxVoiceManager.ParticipantStatusChangedHandler(Action<string, ChannelId, IParticipant> A_0)
		{
			return DelegateSupport.ConvertDelegate<VivoxVoiceManager.ParticipantStatusChangedHandler>(A_0);
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x00181B1E File Offset: 0x0017FD1E
		public static VivoxVoiceManager.ParticipantStatusChangedHandler operator +(VivoxVoiceManager.ParticipantStatusChangedHandler A_0, VivoxVoiceManager.ParticipantStatusChangedHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<VivoxVoiceManager.ParticipantStatusChangedHandler>();
		}

		// Token: 0x06006039 RID: 24633 RVA: 0x00181B2C File Offset: 0x0017FD2C
		public static VivoxVoiceManager.ParticipantStatusChangedHandler operator -(VivoxVoiceManager.ParticipantStatusChangedHandler A_0, VivoxVoiceManager.ParticipantStatusChangedHandler A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<VivoxVoiceManager.ParticipantStatusChangedHandler>();
			}
			return result;
		}

		// Token: 0x04003CD7 RID: 15575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003CD8 RID: 15576
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ChannelId_IParticipant_0;

		// Token: 0x04003CD9 RID: 15577
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_ChannelId_IParticipant_AsyncCallback_Object_0;

		// Token: 0x04003CDA RID: 15578
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020004B6 RID: 1206
	public sealed class ChannelTextMessageChangedHandler : MulticastDelegate
	{
		// Token: 0x0600603A RID: 24634 RVA: 0x00181B40 File Offset: 0x0017FD40
		[CallerCount(0)]
		public unsafe ChannelTextMessageChangedHandler(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxVoiceManager.ChannelTextMessageChangedHandler>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ChannelTextMessageChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x00181BB8 File Offset: 0x0017FDB8
		[CallerCount(0)]
		public unsafe void Invoke(string sender, IChannelTextMessage channelTextMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sender);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channelTextMessage);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ChannelTextMessageChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_IChannelTextMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600603C RID: 24636 RVA: 0x00181C2C File Offset: 0x0017FE2C
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(string sender, IChannelTextMessage channelTextMessage, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sender);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channelTextMessage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ChannelTextMessageChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_IChannelTextMessage_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x00181CE4 File Offset: 0x0017FEE4
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.ChannelTextMessageChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x00181D40 File Offset: 0x0017FF40
		// Note: this type is marked as 'beforefieldinit'.
		static ChannelTextMessageChangedHandler()
		{
			Il2CppClassPointerStore<VivoxVoiceManager.ChannelTextMessageChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "ChannelTextMessageChangedHandler");
			VivoxVoiceManager.ChannelTextMessageChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ChannelTextMessageChangedHandler>.NativeClassPtr, 100670950);
			VivoxVoiceManager.ChannelTextMessageChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_IChannelTextMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ChannelTextMessageChangedHandler>.NativeClassPtr, 100670951);
			VivoxVoiceManager.ChannelTextMessageChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_IChannelTextMessage_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ChannelTextMessageChangedHandler>.NativeClassPtr, 100670952);
			VivoxVoiceManager.ChannelTextMessageChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.ChannelTextMessageChangedHandler>.NativeClassPtr, 100670953);
		}

		// Token: 0x0600603F RID: 24639 RVA: 0x00005E35 File Offset: 0x00004035
		public ChannelTextMessageChangedHandler(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x06006040 RID: 24640 RVA: 0x00181DB1 File Offset: 0x0017FFB1
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VivoxVoiceManager.ChannelTextMessageChangedHandler>.NativeClassPtr));
			}
		}

		// Token: 0x06006041 RID: 24641 RVA: 0x00181DC2 File Offset: 0x0017FFC2
		public static implicit operator VivoxVoiceManager.ChannelTextMessageChangedHandler(Action<string, IChannelTextMessage> A_0)
		{
			return DelegateSupport.ConvertDelegate<VivoxVoiceManager.ChannelTextMessageChangedHandler>(A_0);
		}

		// Token: 0x06006042 RID: 24642 RVA: 0x00181DCA File Offset: 0x0017FFCA
		public static VivoxVoiceManager.ChannelTextMessageChangedHandler operator +(VivoxVoiceManager.ChannelTextMessageChangedHandler A_0, VivoxVoiceManager.ChannelTextMessageChangedHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<VivoxVoiceManager.ChannelTextMessageChangedHandler>();
		}

		// Token: 0x06006043 RID: 24643 RVA: 0x00181DD8 File Offset: 0x0017FFD8
		public static VivoxVoiceManager.ChannelTextMessageChangedHandler operator -(VivoxVoiceManager.ChannelTextMessageChangedHandler A_0, VivoxVoiceManager.ChannelTextMessageChangedHandler A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<VivoxVoiceManager.ChannelTextMessageChangedHandler>();
			}
			return result;
		}

		// Token: 0x04003CDB RID: 15579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003CDC RID: 15580
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_IChannelTextMessage_0;

		// Token: 0x04003CDD RID: 15581
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_IChannelTextMessage_AsyncCallback_Object_0;

		// Token: 0x04003CDE RID: 15582
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020004B7 RID: 1207
	public sealed class LoginStatusChangedHandler : MulticastDelegate
	{
		// Token: 0x06006044 RID: 24644 RVA: 0x00181DEC File Offset: 0x0017FFEC
		[CallerCount(0)]
		public unsafe LoginStatusChangedHandler(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxVoiceManager.LoginStatusChangedHandler>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.LoginStatusChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x00181E64 File Offset: 0x00180064
		[CallerCount(0)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.LoginStatusChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x00181EA8 File Offset: 0x001800A8
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.LoginStatusChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x00181F30 File Offset: 0x00180130
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.LoginStatusChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x00181F8C File Offset: 0x0018018C
		// Note: this type is marked as 'beforefieldinit'.
		static LoginStatusChangedHandler()
		{
			Il2CppClassPointerStore<VivoxVoiceManager.LoginStatusChangedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "LoginStatusChangedHandler");
			VivoxVoiceManager.LoginStatusChangedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.LoginStatusChangedHandler>.NativeClassPtr, 100670954);
			VivoxVoiceManager.LoginStatusChangedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.LoginStatusChangedHandler>.NativeClassPtr, 100670955);
			VivoxVoiceManager.LoginStatusChangedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.LoginStatusChangedHandler>.NativeClassPtr, 100670956);
			VivoxVoiceManager.LoginStatusChangedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.LoginStatusChangedHandler>.NativeClassPtr, 100670957);
		}

		// Token: 0x06006049 RID: 24649 RVA: 0x00005E35 File Offset: 0x00004035
		public LoginStatusChangedHandler(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x0600604A RID: 24650 RVA: 0x00181FFD File Offset: 0x001801FD
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VivoxVoiceManager.LoginStatusChangedHandler>.NativeClassPtr));
			}
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x0018200E File Offset: 0x0018020E
		public static implicit operator VivoxVoiceManager.LoginStatusChangedHandler(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<VivoxVoiceManager.LoginStatusChangedHandler>(A_0);
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x00182016 File Offset: 0x00180216
		public static VivoxVoiceManager.LoginStatusChangedHandler operator +(VivoxVoiceManager.LoginStatusChangedHandler A_0, VivoxVoiceManager.LoginStatusChangedHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<VivoxVoiceManager.LoginStatusChangedHandler>();
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x00182024 File Offset: 0x00180224
		public static VivoxVoiceManager.LoginStatusChangedHandler operator -(VivoxVoiceManager.LoginStatusChangedHandler A_0, VivoxVoiceManager.LoginStatusChangedHandler A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<VivoxVoiceManager.LoginStatusChangedHandler>();
			}
			return result;
		}

		// Token: 0x04003CDF RID: 15583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003CE0 RID: 15584
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		// Token: 0x04003CE1 RID: 15585
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04003CE2 RID: 15586
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020004B8 RID: 1208
	public sealed class AudioReceivedDelegate : MulticastDelegate
	{
		// Token: 0x0600604E RID: 24654 RVA: 0x00182038 File Offset: 0x00180238
		[CallerCount(0)]
		public unsafe AudioReceivedDelegate(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxVoiceManager.AudioReceivedDelegate>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.AudioReceivedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x001820B0 File Offset: 0x001802B0
		[CallerCount(0)]
		public unsafe void Invoke(Action cb, string session_group_handle, string initial_target_uri, short* pcm_frames, int pcm_frame_count, int audio_frame_rate, int channels_per_frame, int is_silence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(session_group_handle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initial_target_uri);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pcm_frames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pcm_frame_count;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref audio_frame_rate;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channels_per_frame;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref is_silence;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.AudioReceivedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Action_String_String_ptr_Int16_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006050 RID: 24656 RVA: 0x001821A0 File Offset: 0x001803A0
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(Action cb, string session_group_handle, string initial_target_uri, short* pcm_frames, int pcm_frame_count, int audio_frame_rate, int channels_per_frame, int is_silence, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(session_group_handle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initial_target_uri);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pcm_frames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pcm_frame_count;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref audio_frame_rate;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channels_per_frame;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref is_silence;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.AudioReceivedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Action_String_String_ptr_Int16_Int32_Int32_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x001822D4 File Offset: 0x001804D4
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.AudioReceivedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006052 RID: 24658 RVA: 0x00182330 File Offset: 0x00180530
		// Note: this type is marked as 'beforefieldinit'.
		static AudioReceivedDelegate()
		{
			Il2CppClassPointerStore<VivoxVoiceManager.AudioReceivedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "AudioReceivedDelegate");
			VivoxVoiceManager.AudioReceivedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.AudioReceivedDelegate>.NativeClassPtr, 100670958);
			VivoxVoiceManager.AudioReceivedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Action_String_String_ptr_Int16_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.AudioReceivedDelegate>.NativeClassPtr, 100670959);
			VivoxVoiceManager.AudioReceivedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Action_String_String_ptr_Int16_Int32_Int32_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.AudioReceivedDelegate>.NativeClassPtr, 100670960);
			VivoxVoiceManager.AudioReceivedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.AudioReceivedDelegate>.NativeClassPtr, 100670961);
		}

		// Token: 0x06006053 RID: 24659 RVA: 0x00005E35 File Offset: 0x00004035
		public AudioReceivedDelegate(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x06006054 RID: 24660 RVA: 0x001823A1 File Offset: 0x001805A1
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VivoxVoiceManager.AudioReceivedDelegate>.NativeClassPtr));
			}
		}

		// Token: 0x04003CE3 RID: 15587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003CE4 RID: 15588
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Action_String_String_ptr_Int16_Int32_Int32_Int32_Int32_0;

		// Token: 0x04003CE5 RID: 15589
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Action_String_String_ptr_Int16_Int32_Int32_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04003CE6 RID: 15590
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020004B9 RID: 1209
	[ObfuscatedName("VivoxVoiceManager/<>c")]
	[Serializable]
	public sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x06006055 RID: 24661 RVA: 0x001823B4 File Offset: 0x001805B4
		[CallerCount(0)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxVoiceManager.__c>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006056 RID: 24662 RVA: 0x00182400 File Offset: 0x00180600
		[CallerCount(0)]
		public unsafe bool _get_TransmittingSession_b__65_0(IChannelSession x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.__c.NativeMethodInfoPtr__get_TransmittingSession_b__65_0_Internal_Boolean_IChannelSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006057 RID: 24663 RVA: 0x00182468 File Offset: 0x00180668
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<VivoxVoiceManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxVoiceManager.__c>.NativeClassPtr);
			VivoxVoiceManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager.__c>.NativeClassPtr, "<>9");
			VivoxVoiceManager.__c.NativeFieldInfoPtr___9__65_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager.__c>.NativeClassPtr, "<>9__65_0");
			VivoxVoiceManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.__c>.NativeClassPtr, 100670963);
			VivoxVoiceManager.__c.NativeMethodInfoPtr__get_TransmittingSession_b__65_0_Internal_Boolean_IChannelSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.__c>.NativeClassPtr, 100670964);
		}

		// Token: 0x06006058 RID: 24664 RVA: 0x00002988 File Offset: 0x00000B88
		public __c(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x06006059 RID: 24665 RVA: 0x001824E3 File Offset: 0x001806E3
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VivoxVoiceManager.__c>.NativeClassPtr));
			}
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x0600605A RID: 24666 RVA: 0x001824F4 File Offset: 0x001806F4
		// (set) Token: 0x0600605B RID: 24667 RVA: 0x0018251F File Offset: 0x0018071F
		public unsafe static VivoxVoiceManager.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VivoxVoiceManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new VivoxVoiceManager.__c(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VivoxVoiceManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x0600605C RID: 24668 RVA: 0x00182534 File Offset: 0x00180734
		// (set) Token: 0x0600605D RID: 24669 RVA: 0x0018255F File Offset: 0x0018075F
		public unsafe static Func<IChannelSession, bool> __9__65_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VivoxVoiceManager.__c.NativeFieldInfoPtr___9__65_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Func<IChannelSession, bool>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VivoxVoiceManager.__c.NativeFieldInfoPtr___9__65_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CE7 RID: 15591
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003CE8 RID: 15592
		private static readonly IntPtr NativeFieldInfoPtr___9__65_0;

		// Token: 0x04003CE9 RID: 15593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003CEA RID: 15594
		private static readonly IntPtr NativeMethodInfoPtr__get_TransmittingSession_b__65_0_Internal_Boolean_IChannelSession_0;
	}

	// Token: 0x020004BA RID: 1210
	[ObfuscatedName("VivoxVoiceManager/<>c__DisplayClass81_0")]
	public sealed class __c__DisplayClass81_0 : Il2CppSystem.Object
	{
		// Token: 0x0600605E RID: 24670 RVA: 0x00182574 File Offset: 0x00180774
		[CallerCount(0)]
		public unsafe __c__DisplayClass81_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass81_0>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x001825C0 File Offset: 0x001807C0
		[CallerCount(0)]
		public unsafe void _JoinChannel_b__0(IAsyncResult ar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ar);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.__c__DisplayClass81_0.NativeMethodInfoPtr__JoinChannel_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006060 RID: 24672 RVA: 0x0018261C File Offset: 0x0018081C
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass81_0()
		{
			Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass81_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "<>c__DisplayClass81_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass81_0>.NativeClassPtr);
			VivoxVoiceManager.__c__DisplayClass81_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass81_0>.NativeClassPtr, "<>4__this");
			VivoxVoiceManager.__c__DisplayClass81_0.NativeFieldInfoPtr_channelSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass81_0>.NativeClassPtr, "channelSession");
			VivoxVoiceManager.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass81_0>.NativeClassPtr, 100670965);
			VivoxVoiceManager.__c__DisplayClass81_0.NativeMethodInfoPtr__JoinChannel_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass81_0>.NativeClassPtr, 100670966);
		}

		// Token: 0x06006061 RID: 24673 RVA: 0x00002988 File Offset: 0x00000B88
		public __c__DisplayClass81_0(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002227 RID: 8743
		// (get) Token: 0x06006062 RID: 24674 RVA: 0x00182697 File Offset: 0x00180897
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass81_0>.NativeClassPtr));
			}
		}

		// Token: 0x17002228 RID: 8744
		// (get) Token: 0x06006063 RID: 24675 RVA: 0x001826A8 File Offset: 0x001808A8
		// (set) Token: 0x06006064 RID: 24676 RVA: 0x001826DC File Offset: 0x001808DC
		public unsafe VivoxVoiceManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.__c__DisplayClass81_0.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new VivoxVoiceManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.__c__DisplayClass81_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002229 RID: 8745
		// (get) Token: 0x06006065 RID: 24677 RVA: 0x00182704 File Offset: 0x00180904
		// (set) Token: 0x06006066 RID: 24678 RVA: 0x00182738 File Offset: 0x00180938
		public unsafe IChannelSession channelSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.__c__DisplayClass81_0.NativeFieldInfoPtr_channelSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new IChannelSession(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.__c__DisplayClass81_0.NativeFieldInfoPtr_channelSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CEB RID: 15595
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04003CEC RID: 15596
		private static readonly IntPtr NativeFieldInfoPtr_channelSession;

		// Token: 0x04003CED RID: 15597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003CEE RID: 15598
		private static readonly IntPtr NativeMethodInfoPtr__JoinChannel_b__0_Internal_Void_IAsyncResult_0;
	}

	// Token: 0x020004BB RID: 1211
	[ObfuscatedName("VivoxVoiceManager/<>c__DisplayClass82_0")]
	public sealed class __c__DisplayClass82_0 : Il2CppSystem.Object
	{
		// Token: 0x06006067 RID: 24679 RVA: 0x00182760 File Offset: 0x00180960
		[CallerCount(0)]
		public unsafe __c__DisplayClass82_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass82_0>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006068 RID: 24680 RVA: 0x001827AC File Offset: 0x001809AC
		[CallerCount(0)]
		public unsafe void _SendTextMessage_b__0(IAsyncResult ar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ar);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VivoxVoiceManager.__c__DisplayClass82_0.NativeMethodInfoPtr__SendTextMessage_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006069 RID: 24681 RVA: 0x00182808 File Offset: 0x00180A08
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass82_0()
		{
			Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass82_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VivoxVoiceManager>.NativeClassPtr, "<>c__DisplayClass82_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass82_0>.NativeClassPtr);
			VivoxVoiceManager.__c__DisplayClass82_0.NativeFieldInfoPtr_channelSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass82_0>.NativeClassPtr, "channelSession");
			VivoxVoiceManager.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass82_0>.NativeClassPtr, "<>4__this");
			VivoxVoiceManager.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass82_0>.NativeClassPtr, 100670967);
			VivoxVoiceManager.__c__DisplayClass82_0.NativeMethodInfoPtr__SendTextMessage_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass82_0>.NativeClassPtr, 100670968);
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x00002988 File Offset: 0x00000B88
		public __c__DisplayClass82_0(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x0600606B RID: 24683 RVA: 0x00182883 File Offset: 0x00180A83
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VivoxVoiceManager.__c__DisplayClass82_0>.NativeClassPtr));
			}
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x0600606C RID: 24684 RVA: 0x00182894 File Offset: 0x00180A94
		// (set) Token: 0x0600606D RID: 24685 RVA: 0x001828C8 File Offset: 0x00180AC8
		public unsafe IChannelSession channelSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.__c__DisplayClass82_0.NativeFieldInfoPtr_channelSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new IChannelSession(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.__c__DisplayClass82_0.NativeFieldInfoPtr_channelSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x0600606E RID: 24686 RVA: 0x001828F0 File Offset: 0x00180AF0
		// (set) Token: 0x0600606F RID: 24687 RVA: 0x00182924 File Offset: 0x00180B24
		public unsafe VivoxVoiceManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new VivoxVoiceManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VivoxVoiceManager.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CEF RID: 15599
		private static readonly IntPtr NativeFieldInfoPtr_channelSession;

		// Token: 0x04003CF0 RID: 15600
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04003CF1 RID: 15601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003CF2 RID: 15602
		private static readonly IntPtr NativeMethodInfoPtr__SendTextMessage_b__0_Internal_Void_IAsyncResult_0;
	}
}
