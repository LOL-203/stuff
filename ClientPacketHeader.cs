using System;
using System.Runtime.InteropServices;
using DPI.Networking.IO;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking
{
	// Token: 0x020011E0 RID: 4576
	[StructLayout(2)]
	public struct ClientPacketHeader
	{
		// Token: 0x06015117 RID: 86295 RVA: 0x0054BF14 File Offset: 0x0054A114
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientPacketHeader.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015118 RID: 86296 RVA: 0x0054BF60 File Offset: 0x0054A160
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientPacketHeader.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015119 RID: 86297 RVA: 0x0054BFAC File Offset: 0x0054A1AC
		[CallerCount(0)]
		public unsafe string ToString()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ClientPacketHeader.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0601511A RID: 86298 RVA: 0x0054BFE8 File Offset: 0x0054A1E8
		// Note: this type is marked as 'beforefieldinit'.
		static ClientPacketHeader()
		{
			Il2CppClassPointerStore<ClientPacketHeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking", "ClientPacketHeader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientPacketHeader>.NativeClassPtr);
			ClientPacketHeader.NativeFieldInfoPtr_PacketType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientPacketHeader>.NativeClassPtr, "PacketType");
			ClientPacketHeader.NativeFieldInfoPtr_Timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientPacketHeader>.NativeClassPtr, "Timestamp");
			ClientPacketHeader.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientPacketHeader>.NativeClassPtr, 100690164);
			ClientPacketHeader.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientPacketHeader>.NativeClassPtr, 100690165);
			ClientPacketHeader.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientPacketHeader>.NativeClassPtr, 100690166);
		}

		// Token: 0x0601511B RID: 86299 RVA: 0x0054C07C File Offset: 0x0054A27C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientPacketHeader>.NativeClassPtr, ref this));
		}

		// Token: 0x17007708 RID: 30472
		// (get) Token: 0x0601511C RID: 86300 RVA: 0x0054C08E File Offset: 0x0054A28E
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ClientPacketHeader>.NativeClassPtr));
			}
		}

		// Token: 0x0400D73D RID: 55101
		private static readonly IntPtr NativeFieldInfoPtr_PacketType;

		// Token: 0x0400D73E RID: 55102
		private static readonly IntPtr NativeFieldInfoPtr_Timestamp;

		// Token: 0x0400D73F RID: 55103
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x0400D740 RID: 55104
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x0400D741 RID: 55105
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400D742 RID: 55106
		[FieldOffset(0)]
		public StreamablePacketType PacketType;

		// Token: 0x0400D743 RID: 55107
		[FieldOffset(4)]
		public Timestamp Timestamp;
	}
}
