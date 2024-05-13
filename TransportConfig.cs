using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking.Transport
{
	// Token: 0x0200126A RID: 4714
	public class TransportConfig : Object
	{
		// Token: 0x17007901 RID: 30977
		// (get) Token: 0x06015708 RID: 87816 RVA: 0x00564F34 File Offset: 0x00563134
		public unsafe bool IsClientConfig
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TransportConfig.NativeMethodInfoPtr_get_IsClientConfig_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17007902 RID: 30978
		// (get) Token: 0x06015709 RID: 87817 RVA: 0x00564F84 File Offset: 0x00563184
		public unsafe bool IsServerConfig
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TransportConfig.NativeMethodInfoPtr_get_IsServerConfig_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17007903 RID: 30979
		// (get) Token: 0x0601570A RID: 87818 RVA: 0x00564FD4 File Offset: 0x005631D4
		// (set) Token: 0x0601570B RID: 87819 RVA: 0x00565024 File Offset: 0x00563224
		public unsafe ushort ListenPort
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TransportConfig.NativeMethodInfoPtr_get_ListenPort_Public_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportConfig.NativeMethodInfoPtr_set_ListenPort_Private_set_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17007904 RID: 30980
		// (get) Token: 0x0601570C RID: 87820 RVA: 0x00565078 File Offset: 0x00563278
		// (set) Token: 0x0601570D RID: 87821 RVA: 0x005650C4 File Offset: 0x005632C4
		public unsafe string ConnectAddress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TransportConfig.NativeMethodInfoPtr_get_ConnectAddress_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportConfig.NativeMethodInfoPtr_set_ConnectAddress_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17007905 RID: 30981
		// (get) Token: 0x0601570E RID: 87822 RVA: 0x00565120 File Offset: 0x00563320
		// (set) Token: 0x0601570F RID: 87823 RVA: 0x00565170 File Offset: 0x00563370
		public unsafe ushort ConnectPort
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TransportConfig.NativeMethodInfoPtr_get_ConnectPort_Public_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportConfig.NativeMethodInfoPtr_set_ConnectPort_Private_set_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17007906 RID: 30982
		// (get) Token: 0x06015710 RID: 87824 RVA: 0x005651C4 File Offset: 0x005633C4
		// (set) Token: 0x06015711 RID: 87825 RVA: 0x00565210 File Offset: 0x00563410
		public unsafe EncryptionTransportConfig EncryptionConfig
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportConfig.NativeMethodInfoPtr_get_EncryptionConfig_Public_get_EncryptionTransportConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return new EncryptionTransportConfig(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportConfig.NativeMethodInfoPtr_set_EncryptionConfig_Private_set_Void_EncryptionTransportConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06015712 RID: 87826 RVA: 0x00565270 File Offset: 0x00563470
		[CallerCount(0)]
		public unsafe TransportConfig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportConfig.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015713 RID: 87827 RVA: 0x005652BC File Offset: 0x005634BC
		[CallerCount(0)]
		public unsafe static TransportConfig MakeClientConfig(Il2CppStructArray<NetworkChannelType> customChannels, string address, ushort port, [Optional] EncryptionTransportConfig encryptionTransportConfig)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customChannels);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(address);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(encryptionTransportConfig));
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportConfig.NativeMethodInfoPtr_MakeClientConfig_Public_Static_TransportConfig_ArrayOf_NetworkChannelType_String_UInt16_EncryptionTransportConfig_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new TransportConfig(intPtr2) : null;
		}

		// Token: 0x06015714 RID: 87828 RVA: 0x00565364 File Offset: 0x00563564
		[CallerCount(0)]
		public unsafe static TransportConfig MakeDedicatedServerConfig(Il2CppStructArray<NetworkChannelType> customChannels, ushort listenPort, [Optional] EncryptionTransportConfig encryptionTransportConfig)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customChannels);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref listenPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(encryptionTransportConfig));
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportConfig.NativeMethodInfoPtr_MakeDedicatedServerConfig_Public_Static_TransportConfig_ArrayOf_NetworkChannelType_UInt16_EncryptionTransportConfig_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new TransportConfig(intPtr2) : null;
		}

		// Token: 0x06015715 RID: 87829 RVA: 0x005653F4 File Offset: 0x005635F4
		// Note: this type is marked as 'beforefieldinit'.
		static TransportConfig()
		{
			Il2CppClassPointerStore<TransportConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.Transport", "TransportConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr);
			TransportConfig.NativeFieldInfoPtr__ListenPort_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, "<ListenPort>k__BackingField");
			TransportConfig.NativeFieldInfoPtr__ConnectAddress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, "<ConnectAddress>k__BackingField");
			TransportConfig.NativeFieldInfoPtr__ConnectPort_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, "<ConnectPort>k__BackingField");
			TransportConfig.NativeFieldInfoPtr_CustomChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, "CustomChannels");
			TransportConfig.NativeFieldInfoPtr__EncryptionConfig_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, "<EncryptionConfig>k__BackingField");
			TransportConfig.NativeFieldInfoPtr_NetworkSimSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, "NetworkSimSettings");
			TransportConfig.NativeMethodInfoPtr_get_IsClientConfig_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, 100690747);
			TransportConfig.NativeMethodInfoPtr_get_IsServerConfig_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, 100690748);
			TransportConfig.NativeMethodInfoPtr_get_ListenPort_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, 100690749);
			TransportConfig.NativeMethodInfoPtr_set_ListenPort_Private_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, 100690750);
			TransportConfig.NativeMethodInfoPtr_get_ConnectAddress_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, 100690751);
			TransportConfig.NativeMethodInfoPtr_set_ConnectAddress_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, 100690752);
			TransportConfig.NativeMethodInfoPtr_get_ConnectPort_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, 100690753);
			TransportConfig.NativeMethodInfoPtr_set_ConnectPort_Private_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, 100690754);
			TransportConfig.NativeMethodInfoPtr_get_EncryptionConfig_Public_get_EncryptionTransportConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, 100690755);
			TransportConfig.NativeMethodInfoPtr_set_EncryptionConfig_Private_set_Void_EncryptionTransportConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, 100690756);
			TransportConfig.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, 100690757);
			TransportConfig.NativeMethodInfoPtr_MakeClientConfig_Public_Static_TransportConfig_ArrayOf_NetworkChannelType_String_UInt16_EncryptionTransportConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, 100690758);
			TransportConfig.NativeMethodInfoPtr_MakeDedicatedServerConfig_Public_Static_TransportConfig_ArrayOf_NetworkChannelType_UInt16_EncryptionTransportConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr, 100690759);
		}

		// Token: 0x06015716 RID: 87830 RVA: 0x00002988 File Offset: 0x00000B88
		public TransportConfig(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170078FA RID: 30970
		// (get) Token: 0x06015717 RID: 87831 RVA: 0x005655A0 File Offset: 0x005637A0
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TransportConfig>.NativeClassPtr));
			}
		}

		// Token: 0x170078FB RID: 30971
		// (get) Token: 0x06015718 RID: 87832 RVA: 0x005655B4 File Offset: 0x005637B4
		// (set) Token: 0x06015719 RID: 87833 RVA: 0x005655DC File Offset: 0x005637DC
		public unsafe ushort _ListenPort_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportConfig.NativeFieldInfoPtr__ListenPort_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportConfig.NativeFieldInfoPtr__ListenPort_k__BackingField)) = value;
			}
		}

		// Token: 0x170078FC RID: 30972
		// (get) Token: 0x0601571A RID: 87834 RVA: 0x00565600 File Offset: 0x00563800
		// (set) Token: 0x0601571B RID: 87835 RVA: 0x00565629 File Offset: 0x00563829
		public unsafe string _ConnectAddress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportConfig.NativeFieldInfoPtr__ConnectAddress_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportConfig.NativeFieldInfoPtr__ConnectAddress_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170078FD RID: 30973
		// (get) Token: 0x0601571C RID: 87836 RVA: 0x00565650 File Offset: 0x00563850
		// (set) Token: 0x0601571D RID: 87837 RVA: 0x00565678 File Offset: 0x00563878
		public unsafe ushort _ConnectPort_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportConfig.NativeFieldInfoPtr__ConnectPort_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportConfig.NativeFieldInfoPtr__ConnectPort_k__BackingField)) = value;
			}
		}

		// Token: 0x170078FE RID: 30974
		// (get) Token: 0x0601571E RID: 87838 RVA: 0x0056569C File Offset: 0x0056389C
		// (set) Token: 0x0601571F RID: 87839 RVA: 0x005656D0 File Offset: 0x005638D0
		public unsafe Il2CppStructArray<NetworkChannelType> CustomChannels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportConfig.NativeFieldInfoPtr_CustomChannels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<NetworkChannelType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportConfig.NativeFieldInfoPtr_CustomChannels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170078FF RID: 30975
		// (get) Token: 0x06015720 RID: 87840 RVA: 0x005656F8 File Offset: 0x005638F8
		// (set) Token: 0x06015721 RID: 87841 RVA: 0x0056572A File Offset: 0x0056392A
		public EncryptionTransportConfig _EncryptionConfig_k__BackingField
		{
			get
			{
				IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportConfig.NativeFieldInfoPtr__EncryptionConfig_k__BackingField);
				return new EncryptionTransportConfig(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, data));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportConfig.NativeFieldInfoPtr__EncryptionConfig_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17007900 RID: 30976
		// (get) Token: 0x06015722 RID: 87842 RVA: 0x00565760 File Offset: 0x00563960
		// (set) Token: 0x06015723 RID: 87843 RVA: 0x00565794 File Offset: 0x00563994
		public unsafe NetworkSimSettings NetworkSimSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportConfig.NativeFieldInfoPtr_NetworkSimSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new NetworkSimSettings(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportConfig.NativeFieldInfoPtr_NetworkSimSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400DBC3 RID: 56259
		private static readonly IntPtr NativeFieldInfoPtr__ListenPort_k__BackingField;

		// Token: 0x0400DBC4 RID: 56260
		private static readonly IntPtr NativeFieldInfoPtr__ConnectAddress_k__BackingField;

		// Token: 0x0400DBC5 RID: 56261
		private static readonly IntPtr NativeFieldInfoPtr__ConnectPort_k__BackingField;

		// Token: 0x0400DBC6 RID: 56262
		private static readonly IntPtr NativeFieldInfoPtr_CustomChannels;

		// Token: 0x0400DBC7 RID: 56263
		private static readonly IntPtr NativeFieldInfoPtr__EncryptionConfig_k__BackingField;

		// Token: 0x0400DBC8 RID: 56264
		private static readonly IntPtr NativeFieldInfoPtr_NetworkSimSettings;

		// Token: 0x0400DBC9 RID: 56265
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClientConfig_Public_get_Boolean_0;

		// Token: 0x0400DBCA RID: 56266
		private static readonly IntPtr NativeMethodInfoPtr_get_IsServerConfig_Public_get_Boolean_0;

		// Token: 0x0400DBCB RID: 56267
		private static readonly IntPtr NativeMethodInfoPtr_get_ListenPort_Public_get_UInt16_0;

		// Token: 0x0400DBCC RID: 56268
		private static readonly IntPtr NativeMethodInfoPtr_set_ListenPort_Private_set_Void_UInt16_0;

		// Token: 0x0400DBCD RID: 56269
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectAddress_Public_get_String_0;

		// Token: 0x0400DBCE RID: 56270
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectAddress_Private_set_Void_String_0;

		// Token: 0x0400DBCF RID: 56271
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectPort_Public_get_UInt16_0;

		// Token: 0x0400DBD0 RID: 56272
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectPort_Private_set_Void_UInt16_0;

		// Token: 0x0400DBD1 RID: 56273
		private static readonly IntPtr NativeMethodInfoPtr_get_EncryptionConfig_Public_get_EncryptionTransportConfig_0;

		// Token: 0x0400DBD2 RID: 56274
		private static readonly IntPtr NativeMethodInfoPtr_set_EncryptionConfig_Private_set_Void_EncryptionTransportConfig_0;

		// Token: 0x0400DBD3 RID: 56275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400DBD4 RID: 56276
		private static readonly IntPtr NativeMethodInfoPtr_MakeClientConfig_Public_Static_TransportConfig_ArrayOf_NetworkChannelType_String_UInt16_EncryptionTransportConfig_0;

		// Token: 0x0400DBD5 RID: 56277
		private static readonly IntPtr NativeMethodInfoPtr_MakeDedicatedServerConfig_Public_Static_TransportConfig_ArrayOf_NetworkChannelType_UInt16_EncryptionTransportConfig_0;
	}
}
