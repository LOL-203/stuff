using System;
using System.Runtime.InteropServices;
using DPI.App;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;
using VivoxUnity;

// Token: 0x02000499 RID: 1177
public class AudioIntegrator : MonoBehaviour
{
	// Token: 0x06005DC9 RID: 24009 RVA: 0x00176E70 File Offset: 0x00175070
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DCA RID: 24010 RVA: 0x00176EB4 File Offset: 0x001750B4
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DCB RID: 24011 RVA: 0x00176EF8 File Offset: 0x001750F8
	[CallerCount(0)]
	public unsafe void OnApplicationStateChange(ApplicationStateType type, bool isPlayerPresent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref type;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPlayerPresent;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_OnApplicationStateChange_Private_Void_ApplicationStateType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DCC RID: 24012 RVA: 0x00176F60 File Offset: 0x00175160
	[CallerCount(0)]
	public unsafe void WriteToBuffer(bool isWriting)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref isWriting;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_WriteToBuffer_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DCD RID: 24013 RVA: 0x00176FB4 File Offset: 0x001751B4
	[CallerCount(0)]
	public unsafe void InitializeClient()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_InitializeClient_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DCE RID: 24014 RVA: 0x00176FF8 File Offset: 0x001751F8
	[CallerCount(0)]
	public unsafe void InitializeClient(Client client)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(client);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_InitializeClient_Public_Void_Client_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DCF RID: 24015 RVA: 0x00177054 File Offset: 0x00175254
	[CallerCount(0)]
	public unsafe void UnInitializeClient()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_UnInitializeClient_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DD0 RID: 24016 RVA: 0x00177098 File Offset: 0x00175298
	[CallerCount(0)]
	public unsafe static void OnAudioDataCallback(IntPtr cb, IntPtr session_group_handle, IntPtr initial_target_uri, IntPtr participantsData, uint numParticipants)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref cb;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref session_group_handle;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial_target_uri;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref participantsData;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numParticipants;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_OnAudioDataCallback_Private_Static_Void_IntPtr_IntPtr_IntPtr_IntPtr_UInt32_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DD1 RID: 24017 RVA: 0x0017712C File Offset: 0x0017532C
	[CallerCount(0)]
	public unsafe void SetBufferSizeFromCodec(MediaCodecType codecType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref codecType;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_SetBufferSizeFromCodec_Private_Void_MediaCodecType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DD2 RID: 24018 RVA: 0x00177180 File Offset: 0x00175380
	[CallerCount(0)]
	public unsafe void PrintBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_PrintBuffers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DD3 RID: 24019 RVA: 0x001771C4 File Offset: 0x001753C4
	[CallerCount(0)]
	public unsafe static BufferedFloats GetPlayersBuffer(string uri)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_GetPlayersBuffer_Public_Static_BufferedFloats_String_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new BufferedFloats(intPtr2) : null;
	}

	// Token: 0x06005DD4 RID: 24020 RVA: 0x00177224 File Offset: 0x00175424
	[CallerCount(0)]
	public unsafe void RemovePlayerFromMap(string uri)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_RemovePlayerFromMap_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DD5 RID: 24021 RVA: 0x00177280 File Offset: 0x00175480
	[CallerCount(0)]
	public unsafe void AddPlayerToMap(string uri)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_AddPlayerToMap_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DD6 RID: 24022 RVA: 0x001772DC File Offset: 0x001754DC
	[CallerCount(0)]
	public unsafe void ClearPlayerMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_ClearPlayerMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DD7 RID: 24023 RVA: 0x00177320 File Offset: 0x00175520
	[CallerCount(0)]
	public unsafe static void ClearAllBuffers()
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr_ClearAllBuffers_Public_Static_Void_0, 0, (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DD8 RID: 24024 RVA: 0x00177354 File Offset: 0x00175554
	[CallerCount(0)]
	public unsafe AudioIntegrator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005DD9 RID: 24025 RVA: 0x001773A0 File Offset: 0x001755A0
	// Note: this type is marked as 'beforefieldinit'.
	static AudioIntegrator()
	{
		Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AudioIntegrator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr);
		AudioIntegrator.NativeFieldInfoPtr_UriPlayerMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "UriPlayerMap");
		AudioIntegrator.NativeFieldInfoPtr_BufferLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "BufferLock");
		AudioIntegrator.NativeFieldInfoPtr_UriPlayerMapLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "UriPlayerMapLock");
		AudioIntegrator.NativeFieldInfoPtr_FloatData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "FloatData");
		AudioIntegrator.NativeFieldInfoPtr__audioReceivedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "_audioReceivedDelegate");
		AudioIntegrator.NativeFieldInfoPtr__client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "_client");
		AudioIntegrator.NativeFieldInfoPtr__audioReceivedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "_audioReceivedCallback");
		AudioIntegrator.NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "isInitialized");
		AudioIntegrator.NativeFieldInfoPtr_Singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "Singleton");
		AudioIntegrator.NativeFieldInfoPtr_playerUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "playerUri");
		AudioIntegrator.NativeFieldInfoPtr_participant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "participant");
		AudioIntegrator.NativeFieldInfoPtr_channelsPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "channelsPerFrame");
		AudioIntegrator.NativeFieldInfoPtr_pcmFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "pcmFrames");
		AudioIntegrator.NativeFieldInfoPtr_pcmFrameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "pcmFrameCount");
		AudioIntegrator.NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "frame");
		AudioIntegrator.NativeFieldInfoPtr_vivoxConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "vivoxConfig");
		AudioIntegrator.NativeFieldInfoPtr_OnVivoxInitialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "OnVivoxInitialization");
		AudioIntegrator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670695);
		AudioIntegrator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670696);
		AudioIntegrator.NativeMethodInfoPtr_OnApplicationStateChange_Private_Void_ApplicationStateType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670697);
		AudioIntegrator.NativeMethodInfoPtr_WriteToBuffer_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670698);
		AudioIntegrator.NativeMethodInfoPtr_InitializeClient_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670699);
		AudioIntegrator.NativeMethodInfoPtr_InitializeClient_Public_Void_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670700);
		AudioIntegrator.NativeMethodInfoPtr_UnInitializeClient_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670701);
		AudioIntegrator.NativeMethodInfoPtr_OnAudioDataCallback_Private_Static_Void_IntPtr_IntPtr_IntPtr_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670702);
		AudioIntegrator.NativeMethodInfoPtr_SetBufferSizeFromCodec_Private_Void_MediaCodecType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670703);
		AudioIntegrator.NativeMethodInfoPtr_PrintBuffers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670704);
		AudioIntegrator.NativeMethodInfoPtr_GetPlayersBuffer_Public_Static_BufferedFloats_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670705);
		AudioIntegrator.NativeMethodInfoPtr_RemovePlayerFromMap_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670706);
		AudioIntegrator.NativeMethodInfoPtr_AddPlayerToMap_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670707);
		AudioIntegrator.NativeMethodInfoPtr_ClearPlayerMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670708);
		AudioIntegrator.NativeMethodInfoPtr_ClearAllBuffers_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670709);
		AudioIntegrator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, 100670710);
	}

	// Token: 0x06005DDA RID: 24026 RVA: 0x0000210C File Offset: 0x0000030C
	public AudioIntegrator(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17002156 RID: 8534
	// (get) Token: 0x06005DDB RID: 24027 RVA: 0x00177664 File Offset: 0x00175864
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr));
		}
	}

	// Token: 0x17002157 RID: 8535
	// (get) Token: 0x06005DDC RID: 24028 RVA: 0x00177678 File Offset: 0x00175878
	// (set) Token: 0x06005DDD RID: 24029 RVA: 0x001776A3 File Offset: 0x001758A3
	public unsafe static Dictionary<string, BufferedFloats> UriPlayerMap
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AudioIntegrator.NativeFieldInfoPtr_UriPlayerMap, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Dictionary<string, BufferedFloats>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioIntegrator.NativeFieldInfoPtr_UriPlayerMap, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002158 RID: 8536
	// (get) Token: 0x06005DDE RID: 24030 RVA: 0x001776B8 File Offset: 0x001758B8
	// (set) Token: 0x06005DDF RID: 24031 RVA: 0x001776E3 File Offset: 0x001758E3
	public unsafe static Il2CppSystem.Object BufferLock
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AudioIntegrator.NativeFieldInfoPtr_BufferLock, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioIntegrator.NativeFieldInfoPtr_BufferLock, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002159 RID: 8537
	// (get) Token: 0x06005DE0 RID: 24032 RVA: 0x001776F8 File Offset: 0x001758F8
	// (set) Token: 0x06005DE1 RID: 24033 RVA: 0x00177723 File Offset: 0x00175923
	public unsafe static Il2CppSystem.Object UriPlayerMapLock
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AudioIntegrator.NativeFieldInfoPtr_UriPlayerMapLock, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioIntegrator.NativeFieldInfoPtr_UriPlayerMapLock, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700215A RID: 8538
	// (get) Token: 0x06005DE2 RID: 24034 RVA: 0x00177738 File Offset: 0x00175938
	// (set) Token: 0x06005DE3 RID: 24035 RVA: 0x00177763 File Offset: 0x00175963
	public unsafe static Il2CppStructArray<float> FloatData
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AudioIntegrator.NativeFieldInfoPtr_FloatData, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioIntegrator.NativeFieldInfoPtr_FloatData, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700215B RID: 8539
	// (get) Token: 0x06005DE4 RID: 24036 RVA: 0x00177778 File Offset: 0x00175978
	// (set) Token: 0x06005DE5 RID: 24037 RVA: 0x001777AC File Offset: 0x001759AC
	public unsafe AudioIntegrator.AudioReceivedDelegate _audioReceivedDelegate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioIntegrator.NativeFieldInfoPtr__audioReceivedDelegate);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AudioIntegrator.AudioReceivedDelegate(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioIntegrator.NativeFieldInfoPtr__audioReceivedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700215C RID: 8540
	// (get) Token: 0x06005DE6 RID: 24038 RVA: 0x001777D4 File Offset: 0x001759D4
	// (set) Token: 0x06005DE7 RID: 24039 RVA: 0x001777FF File Offset: 0x001759FF
	public unsafe static Client _client
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AudioIntegrator.NativeFieldInfoPtr__client, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Client(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioIntegrator.NativeFieldInfoPtr__client, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700215D RID: 8541
	// (get) Token: 0x06005DE8 RID: 24040 RVA: 0x00177814 File Offset: 0x00175A14
	// (set) Token: 0x06005DE9 RID: 24041 RVA: 0x00177848 File Offset: 0x00175A48
	public unsafe SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_vx_before_recv_audio_mixed_participant_data_t_size_t__void _audioReceivedCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioIntegrator.NativeFieldInfoPtr__audioReceivedCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new SWIGTYPE_p_f_p_void_p_q_const__char_p_q_const__char_p_vx_before_recv_audio_mixed_participant_data_t_size_t__void(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioIntegrator.NativeFieldInfoPtr__audioReceivedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700215E RID: 8542
	// (get) Token: 0x06005DEA RID: 24042 RVA: 0x00177870 File Offset: 0x00175A70
	// (set) Token: 0x06005DEB RID: 24043 RVA: 0x0017788E File Offset: 0x00175A8E
	public unsafe static bool isInitialized
	{
		get
		{
			bool result;
			IL2CPP.il2cpp_field_static_get_value(AudioIntegrator.NativeFieldInfoPtr_isInitialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioIntegrator.NativeFieldInfoPtr_isInitialized, (void*)(&value));
		}
	}

	// Token: 0x1700215F RID: 8543
	// (get) Token: 0x06005DEC RID: 24044 RVA: 0x001778A0 File Offset: 0x00175AA0
	// (set) Token: 0x06005DED RID: 24045 RVA: 0x001778CB File Offset: 0x00175ACB
	public unsafe static AudioIntegrator Singleton
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AudioIntegrator.NativeFieldInfoPtr_Singleton, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new AudioIntegrator(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioIntegrator.NativeFieldInfoPtr_Singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002160 RID: 8544
	// (get) Token: 0x06005DEE RID: 24046 RVA: 0x001778E0 File Offset: 0x00175AE0
	// (set) Token: 0x06005DEF RID: 24047 RVA: 0x00177900 File Offset: 0x00175B00
	public unsafe static string playerUri
	{
		get
		{
			IntPtr il2CppString;
			IL2CPP.il2cpp_field_static_get_value(AudioIntegrator.NativeFieldInfoPtr_playerUri, (void*)(&il2CppString));
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioIntegrator.NativeFieldInfoPtr_playerUri, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17002161 RID: 8545
	// (get) Token: 0x06005DF0 RID: 24048 RVA: 0x00177918 File Offset: 0x00175B18
	// (set) Token: 0x06005DF1 RID: 24049 RVA: 0x00177936 File Offset: 0x00175B36
	public unsafe static AudioIntegrator.AudioParticipantData participant
	{
		get
		{
			AudioIntegrator.AudioParticipantData result;
			IL2CPP.il2cpp_field_static_get_value(AudioIntegrator.NativeFieldInfoPtr_participant, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioIntegrator.NativeFieldInfoPtr_participant, (void*)(&value));
		}
	}

	// Token: 0x17002162 RID: 8546
	// (get) Token: 0x06005DF2 RID: 24050 RVA: 0x00177948 File Offset: 0x00175B48
	// (set) Token: 0x06005DF3 RID: 24051 RVA: 0x00177966 File Offset: 0x00175B66
	public unsafe static int channelsPerFrame
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AudioIntegrator.NativeFieldInfoPtr_channelsPerFrame, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioIntegrator.NativeFieldInfoPtr_channelsPerFrame, (void*)(&value));
		}
	}

	// Token: 0x17002163 RID: 8547
	// (get) Token: 0x06005DF4 RID: 24052 RVA: 0x00177978 File Offset: 0x00175B78
	// (set) Token: 0x06005DF5 RID: 24053 RVA: 0x001779A3 File Offset: 0x00175BA3
	public unsafe static short* pcmFrames
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AudioIntegrator.NativeFieldInfoPtr_pcmFrames, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new short*(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioIntegrator.NativeFieldInfoPtr_pcmFrames, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002164 RID: 8548
	// (get) Token: 0x06005DF6 RID: 24054 RVA: 0x001779B8 File Offset: 0x00175BB8
	// (set) Token: 0x06005DF7 RID: 24055 RVA: 0x001779D6 File Offset: 0x00175BD6
	public unsafe static int pcmFrameCount
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AudioIntegrator.NativeFieldInfoPtr_pcmFrameCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioIntegrator.NativeFieldInfoPtr_pcmFrameCount, (void*)(&value));
		}
	}

	// Token: 0x17002165 RID: 8549
	// (get) Token: 0x06005DF8 RID: 24056 RVA: 0x001779E8 File Offset: 0x00175BE8
	// (set) Token: 0x06005DF9 RID: 24057 RVA: 0x00177A06 File Offset: 0x00175C06
	public unsafe static short frame
	{
		get
		{
			short result;
			IL2CPP.il2cpp_field_static_get_value(AudioIntegrator.NativeFieldInfoPtr_frame, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioIntegrator.NativeFieldInfoPtr_frame, (void*)(&value));
		}
	}

	// Token: 0x17002166 RID: 8550
	// (get) Token: 0x06005DFA RID: 24058 RVA: 0x00177A18 File Offset: 0x00175C18
	// (set) Token: 0x06005DFB RID: 24059 RVA: 0x00177A4C File Offset: 0x00175C4C
	public unsafe VivoxConfig vivoxConfig
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioIntegrator.NativeFieldInfoPtr_vivoxConfig);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VivoxConfig(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioIntegrator.NativeFieldInfoPtr_vivoxConfig), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002167 RID: 8551
	// (get) Token: 0x06005DFC RID: 24060 RVA: 0x00177A74 File Offset: 0x00175C74
	// (set) Token: 0x06005DFD RID: 24061 RVA: 0x00177AA8 File Offset: 0x00175CA8
	public unsafe Action OnVivoxInitialization
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioIntegrator.NativeFieldInfoPtr_OnVivoxInitialization);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Action(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioIntegrator.NativeFieldInfoPtr_OnVivoxInitialization), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04003B31 RID: 15153
	private static readonly IntPtr NativeFieldInfoPtr_UriPlayerMap;

	// Token: 0x04003B32 RID: 15154
	private static readonly IntPtr NativeFieldInfoPtr_BufferLock;

	// Token: 0x04003B33 RID: 15155
	private static readonly IntPtr NativeFieldInfoPtr_UriPlayerMapLock;

	// Token: 0x04003B34 RID: 15156
	private static readonly IntPtr NativeFieldInfoPtr_FloatData;

	// Token: 0x04003B35 RID: 15157
	private static readonly IntPtr NativeFieldInfoPtr__audioReceivedDelegate;

	// Token: 0x04003B36 RID: 15158
	private static readonly IntPtr NativeFieldInfoPtr__client;

	// Token: 0x04003B37 RID: 15159
	private static readonly IntPtr NativeFieldInfoPtr__audioReceivedCallback;

	// Token: 0x04003B38 RID: 15160
	private static readonly IntPtr NativeFieldInfoPtr_isInitialized;

	// Token: 0x04003B39 RID: 15161
	private static readonly IntPtr NativeFieldInfoPtr_Singleton;

	// Token: 0x04003B3A RID: 15162
	private static readonly IntPtr NativeFieldInfoPtr_playerUri;

	// Token: 0x04003B3B RID: 15163
	private static readonly IntPtr NativeFieldInfoPtr_participant;

	// Token: 0x04003B3C RID: 15164
	private static readonly IntPtr NativeFieldInfoPtr_channelsPerFrame;

	// Token: 0x04003B3D RID: 15165
	private static readonly IntPtr NativeFieldInfoPtr_pcmFrames;

	// Token: 0x04003B3E RID: 15166
	private static readonly IntPtr NativeFieldInfoPtr_pcmFrameCount;

	// Token: 0x04003B3F RID: 15167
	private static readonly IntPtr NativeFieldInfoPtr_frame;

	// Token: 0x04003B40 RID: 15168
	private static readonly IntPtr NativeFieldInfoPtr_vivoxConfig;

	// Token: 0x04003B41 RID: 15169
	private static readonly IntPtr NativeFieldInfoPtr_OnVivoxInitialization;

	// Token: 0x04003B42 RID: 15170
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04003B43 RID: 15171
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04003B44 RID: 15172
	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationStateChange_Private_Void_ApplicationStateType_Boolean_0;

	// Token: 0x04003B45 RID: 15173
	private static readonly IntPtr NativeMethodInfoPtr_WriteToBuffer_Private_Void_Boolean_0;

	// Token: 0x04003B46 RID: 15174
	private static readonly IntPtr NativeMethodInfoPtr_InitializeClient_Public_Void_0;

	// Token: 0x04003B47 RID: 15175
	private static readonly IntPtr NativeMethodInfoPtr_InitializeClient_Public_Void_Client_0;

	// Token: 0x04003B48 RID: 15176
	private static readonly IntPtr NativeMethodInfoPtr_UnInitializeClient_Public_Void_0;

	// Token: 0x04003B49 RID: 15177
	private static readonly IntPtr NativeMethodInfoPtr_OnAudioDataCallback_Private_Static_Void_IntPtr_IntPtr_IntPtr_IntPtr_UInt32_0;

	// Token: 0x04003B4A RID: 15178
	private static readonly IntPtr NativeMethodInfoPtr_SetBufferSizeFromCodec_Private_Void_MediaCodecType_0;

	// Token: 0x04003B4B RID: 15179
	private static readonly IntPtr NativeMethodInfoPtr_PrintBuffers_Public_Void_0;

	// Token: 0x04003B4C RID: 15180
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayersBuffer_Public_Static_BufferedFloats_String_0;

	// Token: 0x04003B4D RID: 15181
	private static readonly IntPtr NativeMethodInfoPtr_RemovePlayerFromMap_Public_Void_String_0;

	// Token: 0x04003B4E RID: 15182
	private static readonly IntPtr NativeMethodInfoPtr_AddPlayerToMap_Public_Void_String_0;

	// Token: 0x04003B4F RID: 15183
	private static readonly IntPtr NativeMethodInfoPtr_ClearPlayerMap_Public_Void_0;

	// Token: 0x04003B50 RID: 15184
	private static readonly IntPtr NativeMethodInfoPtr_ClearAllBuffers_Public_Static_Void_0;

	// Token: 0x04003B51 RID: 15185
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200049A RID: 1178
	public sealed class AudioReceivedDelegate : MulticastDelegate
	{
		// Token: 0x06005DFE RID: 24062 RVA: 0x00177AD0 File Offset: 0x00175CD0
		[CallerCount(0)]
		public unsafe AudioReceivedDelegate(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioIntegrator.AudioReceivedDelegate>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.AudioReceivedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x00177B48 File Offset: 0x00175D48
		[CallerCount(0)]
		public unsafe void Invoke(IntPtr cb, IntPtr session_group_handle, IntPtr initial_target_uri, IntPtr participantsData, uint numParticipants)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cb;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref session_group_handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial_target_uri;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref participantsData;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numParticipants;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.AudioReceivedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_IntPtr_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x00177BE8 File Offset: 0x00175DE8
		[CallerCount(0)]
		public unsafe IAsyncResult BeginInvoke(IntPtr cb, IntPtr session_group_handle, IntPtr initial_target_uri, IntPtr participantsData, uint numParticipants, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cb;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref session_group_handle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial_target_uri;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref participantsData;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numParticipants;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.AudioReceivedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_IntPtr_UInt32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x00177CCC File Offset: 0x00175ECC
		[CallerCount(0)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioIntegrator.AudioReceivedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E02 RID: 24066 RVA: 0x00177D28 File Offset: 0x00175F28
		// Note: this type is marked as 'beforefieldinit'.
		static AudioReceivedDelegate()
		{
			Il2CppClassPointerStore<AudioIntegrator.AudioReceivedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "AudioReceivedDelegate");
			AudioIntegrator.AudioReceivedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator.AudioReceivedDelegate>.NativeClassPtr, 100670712);
			AudioIntegrator.AudioReceivedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator.AudioReceivedDelegate>.NativeClassPtr, 100670713);
			AudioIntegrator.AudioReceivedDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_IntPtr_UInt32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator.AudioReceivedDelegate>.NativeClassPtr, 100670714);
			AudioIntegrator.AudioReceivedDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioIntegrator.AudioReceivedDelegate>.NativeClassPtr, 100670715);
		}

		// Token: 0x06005E03 RID: 24067 RVA: 0x00005E35 File Offset: 0x00004035
		public AudioReceivedDelegate(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x06005E04 RID: 24068 RVA: 0x00177D99 File Offset: 0x00175F99
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AudioIntegrator.AudioReceivedDelegate>.NativeClassPtr));
			}
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x00177DAA File Offset: 0x00175FAA
		public static implicit operator AudioIntegrator.AudioReceivedDelegate(Action<IntPtr, IntPtr, IntPtr, IntPtr, uint> A_0)
		{
			return DelegateSupport.ConvertDelegate<AudioIntegrator.AudioReceivedDelegate>(A_0);
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x00177DB2 File Offset: 0x00175FB2
		public static AudioIntegrator.AudioReceivedDelegate operator +(AudioIntegrator.AudioReceivedDelegate A_0, AudioIntegrator.AudioReceivedDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AudioIntegrator.AudioReceivedDelegate>();
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x00177DC0 File Offset: 0x00175FC0
		public static AudioIntegrator.AudioReceivedDelegate operator -(AudioIntegrator.AudioReceivedDelegate A_0, AudioIntegrator.AudioReceivedDelegate A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<AudioIntegrator.AudioReceivedDelegate>();
			}
			return result;
		}

		// Token: 0x04003B52 RID: 15186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003B53 RID: 15187
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_IntPtr_UInt32_0;

		// Token: 0x04003B54 RID: 15188
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_IntPtr_UInt32_AsyncCallback_Object_0;

		// Token: 0x04003B55 RID: 15189
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x0200049B RID: 1179
	[StructLayout(2)]
	public struct AudioParticipantData
	{
		// Token: 0x06005E08 RID: 24072 RVA: 0x00177DD4 File Offset: 0x00175FD4
		// Note: this type is marked as 'beforefieldinit'.
		static AudioParticipantData()
		{
			Il2CppClassPointerStore<AudioIntegrator.AudioParticipantData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioIntegrator>.NativeClassPtr, "AudioParticipantData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioIntegrator.AudioParticipantData>.NativeClassPtr);
			AudioIntegrator.AudioParticipantData.NativeFieldInfoPtr_participant_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator.AudioParticipantData>.NativeClassPtr, "participant_uri");
			AudioIntegrator.AudioParticipantData.NativeFieldInfoPtr_pcm_frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator.AudioParticipantData>.NativeClassPtr, "pcm_frames");
			AudioIntegrator.AudioParticipantData.NativeFieldInfoPtr_pcm_frame_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator.AudioParticipantData>.NativeClassPtr, "pcm_frame_count");
			AudioIntegrator.AudioParticipantData.NativeFieldInfoPtr_audio_frame_rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator.AudioParticipantData>.NativeClassPtr, "audio_frame_rate");
			AudioIntegrator.AudioParticipantData.NativeFieldInfoPtr_channels_per_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioIntegrator.AudioParticipantData>.NativeClassPtr, "channels_per_frame");
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x00177E63 File Offset: 0x00176063
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioIntegrator.AudioParticipantData>.NativeClassPtr, ref this));
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x06005E0A RID: 24074 RVA: 0x00177E75 File Offset: 0x00176075
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AudioIntegrator.AudioParticipantData>.NativeClassPtr));
			}
		}

		// Token: 0x04003B56 RID: 15190
		private static readonly IntPtr NativeFieldInfoPtr_participant_uri;

		// Token: 0x04003B57 RID: 15191
		private static readonly IntPtr NativeFieldInfoPtr_pcm_frames;

		// Token: 0x04003B58 RID: 15192
		private static readonly IntPtr NativeFieldInfoPtr_pcm_frame_count;

		// Token: 0x04003B59 RID: 15193
		private static readonly IntPtr NativeFieldInfoPtr_audio_frame_rate;

		// Token: 0x04003B5A RID: 15194
		private static readonly IntPtr NativeFieldInfoPtr_channels_per_frame;

		// Token: 0x04003B5B RID: 15195
		[FieldOffset(0)]
		public IntPtr participant_uri;

		// Token: 0x04003B5C RID: 15196
		[FieldOffset(8)]
		public IntPtr pcm_frames;

		// Token: 0x04003B5D RID: 15197
		[FieldOffset(16)]
		public int pcm_frame_count;

		// Token: 0x04003B5E RID: 15198
		[FieldOffset(20)]
		public int audio_frame_rate;

		// Token: 0x04003B5F RID: 15199
		[FieldOffset(24)]
		public int channels_per_frame;
	}
}
