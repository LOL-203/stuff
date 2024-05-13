using System;
using System.Runtime.InteropServices;
using DPI.Networking.IO;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace DPI.Networking.Transport
{
	// Token: 0x02001268 RID: 4712
	[StructLayout(0)]
	public sealed class NetworkTransportEvent : ValueType
	{
		// Token: 0x060156F8 RID: 87800 RVA: 0x00564C94 File Offset: 0x00562E94
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkTransportEvent()
		{
			Il2CppClassPointerStore<NetworkTransportEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.Transport", "NetworkTransportEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkTransportEvent>.NativeClassPtr);
			NetworkTransportEvent.NativeFieldInfoPtr_Ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransportEvent>.NativeClassPtr, "Ticks");
			NetworkTransportEvent.NativeFieldInfoPtr_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransportEvent>.NativeClassPtr, "EventType");
			NetworkTransportEvent.NativeFieldInfoPtr_DataStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransportEvent>.NativeClassPtr, "DataStream");
			NetworkTransportEvent.NativeFieldInfoPtr_Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransportEvent>.NativeClassPtr, "Connection");
			NetworkTransportEvent.NativeFieldInfoPtr_ChannelId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkTransportEvent>.NativeClassPtr, "ChannelId");
		}

		// Token: 0x060156F9 RID: 87801 RVA: 0x0002717B File Offset: 0x0002537B
		public NetworkTransportEvent(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170078F3 RID: 30963
		// (get) Token: 0x060156FA RID: 87802 RVA: 0x00564D28 File Offset: 0x00562F28
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NetworkTransportEvent>.NativeClassPtr));
			}
		}

		// Token: 0x060156FB RID: 87803 RVA: 0x00564D3C File Offset: 0x00562F3C
		public unsafe NetworkTransportEvent()
		{
			IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NetworkTransportEvent>.NativeClassPtr, (UIntPtr)0)];
			base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkTransportEvent>.NativeClassPtr, data));
		}

		// Token: 0x170078F4 RID: 30964
		// (get) Token: 0x060156FC RID: 87804 RVA: 0x00564D6C File Offset: 0x00562F6C
		// (set) Token: 0x060156FD RID: 87805 RVA: 0x00564D94 File Offset: 0x00562F94
		public unsafe long Ticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransportEvent.NativeFieldInfoPtr_Ticks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransportEvent.NativeFieldInfoPtr_Ticks)) = value;
			}
		}

		// Token: 0x170078F5 RID: 30965
		// (get) Token: 0x060156FE RID: 87806 RVA: 0x00564DB8 File Offset: 0x00562FB8
		// (set) Token: 0x060156FF RID: 87807 RVA: 0x00564DE0 File Offset: 0x00562FE0
		public unsafe NetworkTransportEventType EventType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransportEvent.NativeFieldInfoPtr_EventType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransportEvent.NativeFieldInfoPtr_EventType)) = value;
			}
		}

		// Token: 0x170078F6 RID: 30966
		// (get) Token: 0x06015700 RID: 87808 RVA: 0x00564E04 File Offset: 0x00563004
		// (set) Token: 0x06015701 RID: 87809 RVA: 0x00564E38 File Offset: 0x00563038
		public unsafe DPINetworkStream DataStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransportEvent.NativeFieldInfoPtr_DataStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new DPINetworkStream(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransportEvent.NativeFieldInfoPtr_DataStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170078F7 RID: 30967
		// (get) Token: 0x06015702 RID: 87810 RVA: 0x00564E60 File Offset: 0x00563060
		// (set) Token: 0x06015703 RID: 87811 RVA: 0x00564E94 File Offset: 0x00563094
		public unsafe Connection Connection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransportEvent.NativeFieldInfoPtr_Connection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Connection(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransportEvent.NativeFieldInfoPtr_Connection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170078F8 RID: 30968
		// (get) Token: 0x06015704 RID: 87812 RVA: 0x00564EBC File Offset: 0x005630BC
		// (set) Token: 0x06015705 RID: 87813 RVA: 0x00564EE4 File Offset: 0x005630E4
		public unsafe byte ChannelId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransportEvent.NativeFieldInfoPtr_ChannelId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkTransportEvent.NativeFieldInfoPtr_ChannelId)) = value;
			}
		}

		// Token: 0x0400DBB7 RID: 56247
		private static readonly IntPtr NativeFieldInfoPtr_Ticks;

		// Token: 0x0400DBB8 RID: 56248
		private static readonly IntPtr NativeFieldInfoPtr_EventType;

		// Token: 0x0400DBB9 RID: 56249
		private static readonly IntPtr NativeFieldInfoPtr_DataStream;

		// Token: 0x0400DBBA RID: 56250
		private static readonly IntPtr NativeFieldInfoPtr_Connection;

		// Token: 0x0400DBBB RID: 56251
		private static readonly IntPtr NativeFieldInfoPtr_ChannelId;
	}
}
