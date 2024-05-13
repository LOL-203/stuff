using System;
using System.Runtime.InteropServices;
using DPI.Networking.IO;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking
{
	// Token: 0x020011DC RID: 4572
	[StructLayout(0)]
	public sealed class AuthRequestMessage : ValueType
	{
		// Token: 0x060150E8 RID: 86248 RVA: 0x0054B5F8 File Offset: 0x005497F8
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthRequestMessage.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060150E9 RID: 86249 RVA: 0x0054B650 File Offset: 0x00549850
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthRequestMessage.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060150EA RID: 86250 RVA: 0x0054B6A8 File Offset: 0x005498A8
		// Note: this type is marked as 'beforefieldinit'.
		static AuthRequestMessage()
		{
			Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking", "AuthRequestMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr);
			AuthRequestMessage.NativeFieldInfoPtr_PlayerProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr, "PlayerProperties");
			AuthRequestMessage.NativeFieldInfoPtr_SessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr, "SessionId");
			AuthRequestMessage.NativeFieldInfoPtr_ClientVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr, "ClientVersion");
			AuthRequestMessage.NativeFieldInfoPtr_CreateRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr, "CreateRoom");
			AuthRequestMessage.NativeFieldInfoPtr_CreateRoomProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr, "CreateRoomProperties");
			AuthRequestMessage.NativeFieldInfoPtr_InternalProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr, "InternalProperties");
			AuthRequestMessage.NativeFieldInfoPtr_ExposedRoomPropertiesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr, "ExposedRoomPropertiesCount");
			AuthRequestMessage.NativeFieldInfoPtr_ExposedRoomProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr, "ExposedRoomProperties");
			AuthRequestMessage.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr, 100690160);
			AuthRequestMessage.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr, 100690161);
		}

		// Token: 0x060150EB RID: 86251 RVA: 0x0002717B File Offset: 0x0002537B
		public AuthRequestMessage(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170076F5 RID: 30453
		// (get) Token: 0x060150EC RID: 86252 RVA: 0x0054B7A0 File Offset: 0x005499A0
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr));
			}
		}

		// Token: 0x060150ED RID: 86253 RVA: 0x0054B7B4 File Offset: 0x005499B4
		public unsafe AuthRequestMessage()
		{
			IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr, (UIntPtr)0)];
			base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr, data));
		}

		// Token: 0x170076F6 RID: 30454
		// (get) Token: 0x060150EE RID: 86254 RVA: 0x0054B7E4 File Offset: 0x005499E4
		// (set) Token: 0x060150EF RID: 86255 RVA: 0x0054B818 File Offset: 0x00549A18
		public unsafe DPIHashtable PlayerProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_PlayerProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new DPIHashtable(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_PlayerProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170076F7 RID: 30455
		// (get) Token: 0x060150F0 RID: 86256 RVA: 0x0054B840 File Offset: 0x00549A40
		// (set) Token: 0x060150F1 RID: 86257 RVA: 0x0054B869 File Offset: 0x00549A69
		public unsafe string SessionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_SessionId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_SessionId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170076F8 RID: 30456
		// (get) Token: 0x060150F2 RID: 86258 RVA: 0x0054B890 File Offset: 0x00549A90
		// (set) Token: 0x060150F3 RID: 86259 RVA: 0x0054B8B8 File Offset: 0x00549AB8
		public unsafe int ClientVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_ClientVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_ClientVersion)) = value;
			}
		}

		// Token: 0x170076F9 RID: 30457
		// (get) Token: 0x060150F4 RID: 86260 RVA: 0x0054B8DC File Offset: 0x00549ADC
		// (set) Token: 0x060150F5 RID: 86261 RVA: 0x0054B904 File Offset: 0x00549B04
		public unsafe bool CreateRoom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_CreateRoom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_CreateRoom)) = value;
			}
		}

		// Token: 0x170076FA RID: 30458
		// (get) Token: 0x060150F6 RID: 86262 RVA: 0x0054B928 File Offset: 0x00549B28
		// (set) Token: 0x060150F7 RID: 86263 RVA: 0x0054B95C File Offset: 0x00549B5C
		public unsafe DPIHashtable CreateRoomProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_CreateRoomProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new DPIHashtable(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_CreateRoomProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170076FB RID: 30459
		// (get) Token: 0x060150F8 RID: 86264 RVA: 0x0054B984 File Offset: 0x00549B84
		// (set) Token: 0x060150F9 RID: 86265 RVA: 0x0054B9B8 File Offset: 0x00549BB8
		public unsafe DPIHashtable InternalProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_InternalProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new DPIHashtable(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_InternalProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170076FC RID: 30460
		// (get) Token: 0x060150FA RID: 86266 RVA: 0x0054B9E0 File Offset: 0x00549BE0
		// (set) Token: 0x060150FB RID: 86267 RVA: 0x0054BA08 File Offset: 0x00549C08
		public unsafe byte ExposedRoomPropertiesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_ExposedRoomPropertiesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_ExposedRoomPropertiesCount)) = value;
			}
		}

		// Token: 0x170076FD RID: 30461
		// (get) Token: 0x060150FC RID: 86268 RVA: 0x0054BA2C File Offset: 0x00549C2C
		// (set) Token: 0x060150FD RID: 86269 RVA: 0x0054BA54 File Offset: 0x00549C54
		public unsafe AuthRequestMessage._ExposedRoomProperties_e__FixedBuffer ExposedRoomProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_ExposedRoomProperties);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthRequestMessage.NativeFieldInfoPtr_ExposedRoomProperties)) = value;
			}
		}

		// Token: 0x0400D725 RID: 55077
		private static readonly IntPtr NativeFieldInfoPtr_PlayerProperties;

		// Token: 0x0400D726 RID: 55078
		private static readonly IntPtr NativeFieldInfoPtr_SessionId;

		// Token: 0x0400D727 RID: 55079
		private static readonly IntPtr NativeFieldInfoPtr_ClientVersion;

		// Token: 0x0400D728 RID: 55080
		private static readonly IntPtr NativeFieldInfoPtr_CreateRoom;

		// Token: 0x0400D729 RID: 55081
		private static readonly IntPtr NativeFieldInfoPtr_CreateRoomProperties;

		// Token: 0x0400D72A RID: 55082
		private static readonly IntPtr NativeFieldInfoPtr_InternalProperties;

		// Token: 0x0400D72B RID: 55083
		private static readonly IntPtr NativeFieldInfoPtr_ExposedRoomPropertiesCount;

		// Token: 0x0400D72C RID: 55084
		private static readonly IntPtr NativeFieldInfoPtr_ExposedRoomProperties;

		// Token: 0x0400D72D RID: 55085
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x0400D72E RID: 55086
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x020011DD RID: 4573
		[ObfuscatedName("DPI.Networking.AuthRequestMessage/<ExposedRoomProperties>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _ExposedRoomProperties_e__FixedBuffer
		{
			// Token: 0x060150FE RID: 86270 RVA: 0x0054BA75 File Offset: 0x00549C75
			// Note: this type is marked as 'beforefieldinit'.
			static _ExposedRoomProperties_e__FixedBuffer()
			{
				Il2CppClassPointerStore<AuthRequestMessage._ExposedRoomProperties_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AuthRequestMessage>.NativeClassPtr, "<ExposedRoomProperties>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthRequestMessage._ExposedRoomProperties_e__FixedBuffer>.NativeClassPtr);
				AuthRequestMessage._ExposedRoomProperties_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthRequestMessage._ExposedRoomProperties_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x060150FF RID: 86271 RVA: 0x0054BAA9 File Offset: 0x00549CA9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AuthRequestMessage._ExposedRoomProperties_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x170076FE RID: 30462
			// (get) Token: 0x06015100 RID: 86272 RVA: 0x0054BABB File Offset: 0x00549CBB
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AuthRequestMessage._ExposedRoomProperties_e__FixedBuffer>.NativeClassPtr));
				}
			}

			// Token: 0x0400D72F RID: 55087
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x0400D730 RID: 55088
			[FieldOffset(0)]
			public byte FixedElementField;
		}
	}
}
