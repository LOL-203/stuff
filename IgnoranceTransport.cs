using System;
using ENet;
using IgnoranceCore;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Diagnostics;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking.Transport.Ignorance
{
	// Token: 0x0200126D RID: 4717
	public class IgnoranceTransport : NetworkTransport
	{
		// Token: 0x1700791F RID: 31007
		// (get) Token: 0x0601574D RID: 87885 RVA: 0x00566320 File Offset: 0x00564520
		public unsafe bool IsReady
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IgnoranceTransport.NativeMethodInfoPtr_get_IsReady_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0601574E RID: 87886 RVA: 0x00566370 File Offset: 0x00564570
		[CallerCount(0)]
		public new unsafe bool DoInitialize(TransportConfig config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IgnoranceTransport.NativeMethodInfoPtr_DoInitialize_Protected_Virtual_Boolean_TransportConfig_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601574F RID: 87887 RVA: 0x005663E4 File Offset: 0x005645E4
		[CallerCount(0)]
		public new unsafe void DoUninitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IgnoranceTransport.NativeMethodInfoPtr_DoUninitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015750 RID: 87888 RVA: 0x00566434 File Offset: 0x00564634
		[CallerCount(0)]
		public new unsafe NetworkTransportEvent Poll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IgnoranceTransport.NativeMethodInfoPtr_Poll_Protected_Virtual_NetworkTransportEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return new NetworkTransportEvent(intPtr);
		}

		// Token: 0x06015751 RID: 87889 RVA: 0x0056648C File Offset: 0x0056468C
		[CallerCount(0)]
		public unsafe NetworkTransportEvent InternalPoll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoranceTransport.NativeMethodInfoPtr_InternalPoll_Private_NetworkTransportEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return new NetworkTransportEvent(intPtr);
		}

		// Token: 0x06015752 RID: 87890 RVA: 0x005664D8 File Offset: 0x005646D8
		[CallerCount(0)]
		public new unsafe bool WaitForEvents(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref millisecondsTimeout;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IgnoranceTransport.NativeMethodInfoPtr_WaitForEvents_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06015753 RID: 87891 RVA: 0x00566548 File Offset: 0x00564748
		[CallerCount(0)]
		public unsafe void EditorApplicationUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoranceTransport.NativeMethodInfoPtr_EditorApplicationUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015754 RID: 87892 RVA: 0x0056658C File Offset: 0x0056478C
		[CallerCount(0)]
		public new unsafe void SetPaused(bool isPaused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isPaused;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IgnoranceTransport.NativeMethodInfoPtr_SetPaused_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015755 RID: 87893 RVA: 0x005665EC File Offset: 0x005647EC
		[CallerCount(0)]
		public unsafe IgnoranceConnection GetOrCreateOnwardConnection(uint nativePeerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nativePeerId;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoranceTransport.NativeMethodInfoPtr_GetOrCreateOnwardConnection_Private_IgnoranceConnection_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IgnoranceConnection(intPtr2) : null;
		}

		// Token: 0x06015756 RID: 87894 RVA: 0x00566654 File Offset: 0x00564854
		[CallerCount(0)]
		public unsafe void SendToConnection(IgnoranceConnection connection, ArraySegment<byte> bytes, byte channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bytes));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoranceTransport.NativeMethodInfoPtr_SendToConnection_Internal_Void_IgnoranceConnection_ArraySegment_1_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015757 RID: 87895 RVA: 0x005666E0 File Offset: 0x005648E0
		[CallerCount(0)]
		public unsafe void CloseConnection(IgnoranceConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoranceTransport.NativeMethodInfoPtr_CloseConnection_Internal_Void_IgnoranceConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015758 RID: 87896 RVA: 0x0056673C File Offset: 0x0056493C
		[CallerCount(0)]
		public unsafe bool HasQueuedEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IgnoranceTransport.NativeMethodInfoPtr_HasQueuedEvent_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06015759 RID: 87897 RVA: 0x0056678C File Offset: 0x0056498C
		[CallerCount(0)]
		public unsafe PacketFlags GetChannelFlags(byte channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref channel;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IgnoranceTransport.NativeMethodInfoPtr_GetChannelFlags_Private_PacketFlags_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601575A RID: 87898 RVA: 0x005667F0 File Offset: 0x005649F0
		[CallerCount(0)]
		public unsafe long GetInternalStopwatchNow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IgnoranceTransport.NativeMethodInfoPtr_GetInternalStopwatchNow_Public_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601575B RID: 87899 RVA: 0x00566840 File Offset: 0x00564A40
		[CallerCount(0)]
		public unsafe IgnoranceTransport() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoranceTransport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601575C RID: 87900 RVA: 0x0056688C File Offset: 0x00564A8C
		// Note: this type is marked as 'beforefieldinit'.
		static IgnoranceTransport()
		{
			Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.Transport.Ignorance", "IgnoranceTransport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr);
			IgnoranceTransport.NativeFieldInfoPtr__client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, "_client");
			IgnoranceTransport.NativeFieldInfoPtr__server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, "_server");
			IgnoranceTransport.NativeFieldInfoPtr_STATISTICS_UPDATE_INTERVAL_MS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, "STATISTICS_UPDATE_INTERVAL_MS");
			IgnoranceTransport.NativeFieldInfoPtr__connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, "_connections");
			IgnoranceTransport.NativeFieldInfoPtr__connectionIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, "_connectionIds");
			IgnoranceTransport.NativeFieldInfoPtr__stopwatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, "_stopwatch");
			IgnoranceTransport.NativeFieldInfoPtr__lastStatisticsUpdateTimeMillis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, "_lastStatisticsUpdateTimeMillis");
			IgnoranceTransport.NativeFieldInfoPtr__cachedEventsDuringPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, "_cachedEventsDuringPause");
			IgnoranceTransport.NativeMethodInfoPtr_get_IsReady_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690778);
			IgnoranceTransport.NativeMethodInfoPtr_DoInitialize_Protected_Virtual_Boolean_TransportConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690779);
			IgnoranceTransport.NativeMethodInfoPtr_DoUninitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690780);
			IgnoranceTransport.NativeMethodInfoPtr_Poll_Protected_Virtual_NetworkTransportEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690781);
			IgnoranceTransport.NativeMethodInfoPtr_InternalPoll_Private_NetworkTransportEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690782);
			IgnoranceTransport.NativeMethodInfoPtr_WaitForEvents_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690783);
			IgnoranceTransport.NativeMethodInfoPtr_EditorApplicationUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690784);
			IgnoranceTransport.NativeMethodInfoPtr_SetPaused_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690785);
			IgnoranceTransport.NativeMethodInfoPtr_GetOrCreateOnwardConnection_Private_IgnoranceConnection_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690786);
			IgnoranceTransport.NativeMethodInfoPtr_SendToConnection_Internal_Void_IgnoranceConnection_ArraySegment_1_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690787);
			IgnoranceTransport.NativeMethodInfoPtr_CloseConnection_Internal_Void_IgnoranceConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690788);
			IgnoranceTransport.NativeMethodInfoPtr_HasQueuedEvent_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690789);
			IgnoranceTransport.NativeMethodInfoPtr_GetChannelFlags_Private_PacketFlags_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690790);
			IgnoranceTransport.NativeMethodInfoPtr_GetInternalStopwatchNow_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690791);
			IgnoranceTransport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr, 100690792);
		}

		// Token: 0x0601575D RID: 87901 RVA: 0x0055A38C File Offset: 0x0055858C
		public IgnoranceTransport(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17007916 RID: 30998
		// (get) Token: 0x0601575E RID: 87902 RVA: 0x00566A88 File Offset: 0x00564C88
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IgnoranceTransport>.NativeClassPtr));
			}
		}

		// Token: 0x17007917 RID: 30999
		// (get) Token: 0x0601575F RID: 87903 RVA: 0x00566A9C File Offset: 0x00564C9C
		// (set) Token: 0x06015760 RID: 87904 RVA: 0x00566AD0 File Offset: 0x00564CD0
		public unsafe IgnoranceClient _client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__client);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new IgnoranceClient(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__client), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17007918 RID: 31000
		// (get) Token: 0x06015761 RID: 87905 RVA: 0x00566AF8 File Offset: 0x00564CF8
		// (set) Token: 0x06015762 RID: 87906 RVA: 0x00566B2C File Offset: 0x00564D2C
		public unsafe IgnoranceServer _server
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__server);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new IgnoranceServer(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__server), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17007919 RID: 31001
		// (get) Token: 0x06015763 RID: 87907 RVA: 0x00566B54 File Offset: 0x00564D54
		// (set) Token: 0x06015764 RID: 87908 RVA: 0x00566B72 File Offset: 0x00564D72
		public unsafe static long STATISTICS_UPDATE_INTERVAL_MS
		{
			get
			{
				long result;
				IL2CPP.il2cpp_field_static_get_value(IgnoranceTransport.NativeFieldInfoPtr_STATISTICS_UPDATE_INTERVAL_MS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IgnoranceTransport.NativeFieldInfoPtr_STATISTICS_UPDATE_INTERVAL_MS, (void*)(&value));
			}
		}

		// Token: 0x1700791A RID: 31002
		// (get) Token: 0x06015765 RID: 87909 RVA: 0x00566B84 File Offset: 0x00564D84
		// (set) Token: 0x06015766 RID: 87910 RVA: 0x00566BB8 File Offset: 0x00564DB8
		public unsafe Dictionary<uint, IgnoranceConnection> _connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Dictionary<uint, IgnoranceConnection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700791B RID: 31003
		// (get) Token: 0x06015767 RID: 87911 RVA: 0x00566BE0 File Offset: 0x00564DE0
		// (set) Token: 0x06015768 RID: 87912 RVA: 0x00566C14 File Offset: 0x00564E14
		public unsafe List<uint> _connectionIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__connectionIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<uint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__connectionIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700791C RID: 31004
		// (get) Token: 0x06015769 RID: 87913 RVA: 0x00566C3C File Offset: 0x00564E3C
		// (set) Token: 0x0601576A RID: 87914 RVA: 0x00566C70 File Offset: 0x00564E70
		public unsafe Stopwatch _stopwatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__stopwatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Stopwatch(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__stopwatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700791D RID: 31005
		// (get) Token: 0x0601576B RID: 87915 RVA: 0x00566C98 File Offset: 0x00564E98
		// (set) Token: 0x0601576C RID: 87916 RVA: 0x00566CC0 File Offset: 0x00564EC0
		public unsafe long _lastStatisticsUpdateTimeMillis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__lastStatisticsUpdateTimeMillis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__lastStatisticsUpdateTimeMillis)) = value;
			}
		}

		// Token: 0x1700791E RID: 31006
		// (get) Token: 0x0601576D RID: 87917 RVA: 0x00566CE4 File Offset: 0x00564EE4
		// (set) Token: 0x0601576E RID: 87918 RVA: 0x00566D18 File Offset: 0x00564F18
		public unsafe Queue<NetworkTransportEvent> _cachedEventsDuringPause
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__cachedEventsDuringPause);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Queue<NetworkTransportEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceTransport.NativeFieldInfoPtr__cachedEventsDuringPause), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400DBF0 RID: 56304
		private static readonly IntPtr NativeFieldInfoPtr__client;

		// Token: 0x0400DBF1 RID: 56305
		private static readonly IntPtr NativeFieldInfoPtr__server;

		// Token: 0x0400DBF2 RID: 56306
		private static readonly IntPtr NativeFieldInfoPtr_STATISTICS_UPDATE_INTERVAL_MS;

		// Token: 0x0400DBF3 RID: 56307
		private static readonly IntPtr NativeFieldInfoPtr__connections;

		// Token: 0x0400DBF4 RID: 56308
		private static readonly IntPtr NativeFieldInfoPtr__connectionIds;

		// Token: 0x0400DBF5 RID: 56309
		private static readonly IntPtr NativeFieldInfoPtr__stopwatch;

		// Token: 0x0400DBF6 RID: 56310
		private static readonly IntPtr NativeFieldInfoPtr__lastStatisticsUpdateTimeMillis;

		// Token: 0x0400DBF7 RID: 56311
		private static readonly IntPtr NativeFieldInfoPtr__cachedEventsDuringPause;

		// Token: 0x0400DBF8 RID: 56312
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReady_Public_get_Boolean_0;

		// Token: 0x0400DBF9 RID: 56313
		private static readonly IntPtr NativeMethodInfoPtr_DoInitialize_Protected_Virtual_Boolean_TransportConfig_0;

		// Token: 0x0400DBFA RID: 56314
		private static readonly IntPtr NativeMethodInfoPtr_DoUninitialize_Protected_Virtual_Void_0;

		// Token: 0x0400DBFB RID: 56315
		private static readonly IntPtr NativeMethodInfoPtr_Poll_Protected_Virtual_NetworkTransportEvent_0;

		// Token: 0x0400DBFC RID: 56316
		private static readonly IntPtr NativeMethodInfoPtr_InternalPoll_Private_NetworkTransportEvent_0;

		// Token: 0x0400DBFD RID: 56317
		private static readonly IntPtr NativeMethodInfoPtr_WaitForEvents_Public_Virtual_Boolean_Int32_0;

		// Token: 0x0400DBFE RID: 56318
		private static readonly IntPtr NativeMethodInfoPtr_EditorApplicationUpdate_Protected_Void_0;

		// Token: 0x0400DBFF RID: 56319
		private static readonly IntPtr NativeMethodInfoPtr_SetPaused_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400DC00 RID: 56320
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateOnwardConnection_Private_IgnoranceConnection_UInt32_0;

		// Token: 0x0400DC01 RID: 56321
		private static readonly IntPtr NativeMethodInfoPtr_SendToConnection_Internal_Void_IgnoranceConnection_ArraySegment_1_Byte_Byte_0;

		// Token: 0x0400DC02 RID: 56322
		private static readonly IntPtr NativeMethodInfoPtr_CloseConnection_Internal_Void_IgnoranceConnection_0;

		// Token: 0x0400DC03 RID: 56323
		private static readonly IntPtr NativeMethodInfoPtr_HasQueuedEvent_Private_Boolean_0;

		// Token: 0x0400DC04 RID: 56324
		private static readonly IntPtr NativeMethodInfoPtr_GetChannelFlags_Private_PacketFlags_Byte_0;

		// Token: 0x0400DC05 RID: 56325
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalStopwatchNow_Public_Int64_0;

		// Token: 0x0400DC06 RID: 56326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
