using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking.Transport
{
	// Token: 0x02001267 RID: 4711
	public class NetworkTransport : Object
	{
		// Token: 0x170078F1 RID: 30961
		// (get) Token: 0x060156DC RID: 87772 RVA: 0x0056444C File Offset: 0x0056264C
		// (set) Token: 0x060156DD RID: 87773 RVA: 0x005644A4 File Offset: 0x005626A4
		public unsafe TransportConfig Config
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkTransport.NativeMethodInfoPtr_get_Config_Public_get_TransportConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new TransportConfig(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkTransport.NativeMethodInfoPtr_set_Config_Private_set_Void_TransportConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170078F2 RID: 30962
		// (get) Token: 0x060156DE RID: 87774 RVA: 0x00564500 File Offset: 0x00562700
		// (set) Token: 0x060156DF RID: 87775 RVA: 0x00564550 File Offset: 0x00562750
		public unsafe bool UsePooledStreams
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NetworkTransport.NativeMethodInfoPtr_get_UsePooledStreams_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkTransport.NativeMethodInfoPtr_set_UsePooledStreams_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060156E0 RID: 87776 RVA: 0x005645A4 File Offset: 0x005627A4
		[CallerCount(0)]
		public unsafe bool DoInitialize(TransportConfig config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkTransport.NativeMethodInfoPtr_DoInitialize_Protected_Abstract_Virtual_New_Boolean_TransportConfig_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060156E1 RID: 87777 RVA: 0x00564618 File Offset: 0x00562818
		[CallerCount(0)]
		public unsafe void DoUninitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkTransport.NativeMethodInfoPtr_DoUninitialize_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060156E2 RID: 87778 RVA: 0x00564668 File Offset: 0x00562868
		[CallerCount(0)]
		public unsafe void Initialize(TransportConfig config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkTransport.NativeMethodInfoPtr_Initialize_Public_Void_TransportConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060156E3 RID: 87779 RVA: 0x005646C4 File Offset: 0x005628C4
		[CallerCount(0)]
		public unsafe void Uninitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkTransport.NativeMethodInfoPtr_Uninitialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060156E4 RID: 87780 RVA: 0x00564708 File Offset: 0x00562908
		[CallerCount(0)]
		public unsafe NetworkTransportEvent Poll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkTransport.NativeMethodInfoPtr_Poll_Protected_Abstract_Virtual_New_NetworkTransportEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return new NetworkTransportEvent(intPtr);
		}

		// Token: 0x060156E5 RID: 87781 RVA: 0x00564760 File Offset: 0x00562960
		[CallerCount(0)]
		public unsafe bool PollTransport()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NetworkTransport.NativeMethodInfoPtr_PollTransport_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060156E6 RID: 87782 RVA: 0x005647B0 File Offset: 0x005629B0
		[CallerCount(0)]
		public unsafe bool WaitForEvents(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref millisecondsTimeout;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkTransport.NativeMethodInfoPtr_WaitForEvents_Public_Abstract_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060156E7 RID: 87783 RVA: 0x00564820 File Offset: 0x00562A20
		[CallerCount(0)]
		public unsafe void SetPaused(bool isPaused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isPaused;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkTransport.NativeMethodInfoPtr_SetPaused_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060156E8 RID: 87784 RVA: 0x00564880 File Offset: 0x00562A80
		[CallerCount(0)]
		public unsafe NetworkTransport() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkTransport.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060156E9 RID: 87785 RVA: 0x005648CC File Offset: 0x00562ACC
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkTransport()
		{
			Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.Transport", "NetworkTransport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr);
			NetworkTransport.NativeFieldInfoPtr__Config_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, "<Config>k__BackingField");
			NetworkTransport.NativeFieldInfoPtr__UsePooledStreams_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, "<UsePooledStreams>k__BackingField");
			NetworkTransport.NativeFieldInfoPtr_OnConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, "OnConnected");
			NetworkTransport.NativeFieldInfoPtr_OnDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, "OnDisconnected");
			NetworkTransport.NativeFieldInfoPtr_LastTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, "LastTimestamp");
			NetworkTransport.NativeFieldInfoPtr_OnReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, "OnReceived");
			NetworkTransport.NativeMethodInfoPtr_get_Config_Public_get_TransportConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, 100690734);
			NetworkTransport.NativeMethodInfoPtr_set_Config_Private_set_Void_TransportConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, 100690735);
			NetworkTransport.NativeMethodInfoPtr_get_UsePooledStreams_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, 100690736);
			NetworkTransport.NativeMethodInfoPtr_set_UsePooledStreams_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, 100690737);
			NetworkTransport.NativeMethodInfoPtr_DoInitialize_Protected_Abstract_Virtual_New_Boolean_TransportConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, 100690738);
			NetworkTransport.NativeMethodInfoPtr_DoUninitialize_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, 100690739);
			NetworkTransport.NativeMethodInfoPtr_Initialize_Public_Void_TransportConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, 100690740);
			NetworkTransport.NativeMethodInfoPtr_Uninitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, 100690741);
			NetworkTransport.NativeMethodInfoPtr_Poll_Protected_Abstract_Virtual_New_NetworkTransportEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, 100690742);
			NetworkTransport.NativeMethodInfoPtr_PollTransport_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, 100690743);
			NetworkTransport.NativeMethodInfoPtr_WaitForEvents_Public_Abstract_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, 100690744);
			NetworkTransport.NativeMethodInfoPtr_SetPaused_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, 100690745);
			NetworkTransport.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr, 100690746);
		}

		// Token: 0x060156EA RID: 87786 RVA: 0x00002988 File Offset: 0x00000B88
		public NetworkTransport(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170078EA RID: 30954
		// (get) Token: 0x060156EB RID: 87787 RVA: 0x00564A78 File Offset: 0x00562C78
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NetworkTransport>.NativeClassPtr));
			}
		}

		// Token: 0x170078EB RID: 30955
		// (get) Token: 0x060156EC RID: 87788 RVA: 0x00564A8C File Offset: 0x00562C8C
		// (set) Token: 0x060156ED RID: 87789 RVA: 0x00564AC0 File Offset: 0x00562CC0
		public unsafe TransportConfig _Config_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransport.NativeFieldInfoPtr__Config_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new TransportConfig(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransport.NativeFieldInfoPtr__Config_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170078EC RID: 30956
		// (get) Token: 0x060156EE RID: 87790 RVA: 0x00564AE8 File Offset: 0x00562CE8
		// (set) Token: 0x060156EF RID: 87791 RVA: 0x00564B10 File Offset: 0x00562D10
		public unsafe bool _UsePooledStreams_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransport.NativeFieldInfoPtr__UsePooledStreams_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransport.NativeFieldInfoPtr__UsePooledStreams_k__BackingField)) = value;
			}
		}

		// Token: 0x170078ED RID: 30957
		// (get) Token: 0x060156F0 RID: 87792 RVA: 0x00564B34 File Offset: 0x00562D34
		// (set) Token: 0x060156F1 RID: 87793 RVA: 0x00564B68 File Offset: 0x00562D68
		public unsafe Action<Connection> OnConnected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransport.NativeFieldInfoPtr_OnConnected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Action<Connection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransport.NativeFieldInfoPtr_OnConnected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170078EE RID: 30958
		// (get) Token: 0x060156F2 RID: 87794 RVA: 0x00564B90 File Offset: 0x00562D90
		// (set) Token: 0x060156F3 RID: 87795 RVA: 0x00564BC4 File Offset: 0x00562DC4
		public unsafe Action<Connection, ConnectionCloseReason> OnDisconnected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransport.NativeFieldInfoPtr_OnDisconnected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Action<Connection, ConnectionCloseReason>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransport.NativeFieldInfoPtr_OnDisconnected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170078EF RID: 30959
		// (get) Token: 0x060156F4 RID: 87796 RVA: 0x00564BEC File Offset: 0x00562DEC
		// (set) Token: 0x060156F5 RID: 87797 RVA: 0x00564C14 File Offset: 0x00562E14
		public unsafe long LastTimestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransport.NativeFieldInfoPtr_LastTimestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransport.NativeFieldInfoPtr_LastTimestamp)) = value;
			}
		}

		// Token: 0x170078F0 RID: 30960
		// (get) Token: 0x060156F6 RID: 87798 RVA: 0x00564C38 File Offset: 0x00562E38
		// (set) Token: 0x060156F7 RID: 87799 RVA: 0x00564C6C File Offset: 0x00562E6C
		public unsafe Action<Connection, ArraySegment<byte>, NetworkChannel, long> OnReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransport.NativeFieldInfoPtr_OnReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Action<Connection, ArraySegment<byte>, NetworkChannel, long>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransport.NativeFieldInfoPtr_OnReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400DBA4 RID: 56228
		private static readonly IntPtr NativeFieldInfoPtr__Config_k__BackingField;

		// Token: 0x0400DBA5 RID: 56229
		private static readonly IntPtr NativeFieldInfoPtr__UsePooledStreams_k__BackingField;

		// Token: 0x0400DBA6 RID: 56230
		private static readonly IntPtr NativeFieldInfoPtr_OnConnected;

		// Token: 0x0400DBA7 RID: 56231
		private static readonly IntPtr NativeFieldInfoPtr_OnDisconnected;

		// Token: 0x0400DBA8 RID: 56232
		private static readonly IntPtr NativeFieldInfoPtr_LastTimestamp;

		// Token: 0x0400DBA9 RID: 56233
		private static readonly IntPtr NativeFieldInfoPtr_OnReceived;

		// Token: 0x0400DBAA RID: 56234
		private static readonly IntPtr NativeMethodInfoPtr_get_Config_Public_get_TransportConfig_0;

		// Token: 0x0400DBAB RID: 56235
		private static readonly IntPtr NativeMethodInfoPtr_set_Config_Private_set_Void_TransportConfig_0;

		// Token: 0x0400DBAC RID: 56236
		private static readonly IntPtr NativeMethodInfoPtr_get_UsePooledStreams_Public_get_Boolean_0;

		// Token: 0x0400DBAD RID: 56237
		private static readonly IntPtr NativeMethodInfoPtr_set_UsePooledStreams_Public_set_Void_Boolean_0;

		// Token: 0x0400DBAE RID: 56238
		private static readonly IntPtr NativeMethodInfoPtr_DoInitialize_Protected_Abstract_Virtual_New_Boolean_TransportConfig_0;

		// Token: 0x0400DBAF RID: 56239
		private static readonly IntPtr NativeMethodInfoPtr_DoUninitialize_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400DBB0 RID: 56240
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_TransportConfig_0;

		// Token: 0x0400DBB1 RID: 56241
		private static readonly IntPtr NativeMethodInfoPtr_Uninitialize_Public_Void_0;

		// Token: 0x0400DBB2 RID: 56242
		private static readonly IntPtr NativeMethodInfoPtr_Poll_Protected_Abstract_Virtual_New_NetworkTransportEvent_0;

		// Token: 0x0400DBB3 RID: 56243
		private static readonly IntPtr NativeMethodInfoPtr_PollTransport_Public_Boolean_0;

		// Token: 0x0400DBB4 RID: 56244
		private static readonly IntPtr NativeMethodInfoPtr_WaitForEvents_Public_Abstract_Virtual_New_Boolean_Int32_0;

		// Token: 0x0400DBB5 RID: 56245
		private static readonly IntPtr NativeMethodInfoPtr_SetPaused_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x0400DBB6 RID: 56246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
