using System;
using System.Runtime.InteropServices;
using DPI.Networking.IO;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking
{
	// Token: 0x020011DE RID: 4574
	[StructLayout(0)]
	public sealed class AuthResponseMessage : ValueType
	{
		// Token: 0x06015101 RID: 86273 RVA: 0x0054BACC File Offset: 0x00549CCC
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthResponseMessage.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015102 RID: 86274 RVA: 0x0054BB24 File Offset: 0x00549D24
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthResponseMessage.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015103 RID: 86275 RVA: 0x0054BB7C File Offset: 0x00549D7C
		// Note: this type is marked as 'beforefieldinit'.
		static AuthResponseMessage()
		{
			Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking", "AuthResponseMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr);
			AuthResponseMessage.NativeFieldInfoPtr_AssignedConnectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr, "AssignedConnectionId");
			AuthResponseMessage.NativeFieldInfoPtr_MasterClientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr, "MasterClientId");
			AuthResponseMessage.NativeFieldInfoPtr_CurrentServerTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr, "CurrentServerTimestamp");
			AuthResponseMessage.NativeFieldInfoPtr_RoomProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr, "RoomProperties");
			AuthResponseMessage.NativeFieldInfoPtr_InternalProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr, "InternalProperties");
			AuthResponseMessage.NativeFieldInfoPtr_AdditionalData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr, "AdditionalData");
			AuthResponseMessage.NativeFieldInfoPtr_ServerVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr, "ServerVersion");
			AuthResponseMessage.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr, 100690162);
			AuthResponseMessage.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr, 100690163);
		}

		// Token: 0x06015104 RID: 86276 RVA: 0x0002717B File Offset: 0x0002537B
		public AuthResponseMessage(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170076FF RID: 30463
		// (get) Token: 0x06015105 RID: 86277 RVA: 0x0054BC60 File Offset: 0x00549E60
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr));
			}
		}

		// Token: 0x06015106 RID: 86278 RVA: 0x0054BC74 File Offset: 0x00549E74
		public unsafe AuthResponseMessage()
		{
			IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr, (UIntPtr)0)];
			base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AuthResponseMessage>.NativeClassPtr, data));
		}

		// Token: 0x17007700 RID: 30464
		// (get) Token: 0x06015107 RID: 86279 RVA: 0x0054BCA4 File Offset: 0x00549EA4
		// (set) Token: 0x06015108 RID: 86280 RVA: 0x0054BCCC File Offset: 0x00549ECC
		public unsafe PlayerId AssignedConnectionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_AssignedConnectionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_AssignedConnectionId)) = value;
			}
		}

		// Token: 0x17007701 RID: 30465
		// (get) Token: 0x06015109 RID: 86281 RVA: 0x0054BCF0 File Offset: 0x00549EF0
		// (set) Token: 0x0601510A RID: 86282 RVA: 0x0054BD18 File Offset: 0x00549F18
		public unsafe PlayerId MasterClientId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_MasterClientId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_MasterClientId)) = value;
			}
		}

		// Token: 0x17007702 RID: 30466
		// (get) Token: 0x0601510B RID: 86283 RVA: 0x0054BD3C File Offset: 0x00549F3C
		// (set) Token: 0x0601510C RID: 86284 RVA: 0x0054BD64 File Offset: 0x00549F64
		public unsafe Timestamp CurrentServerTimestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_CurrentServerTimestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_CurrentServerTimestamp)) = value;
			}
		}

		// Token: 0x17007703 RID: 30467
		// (get) Token: 0x0601510D RID: 86285 RVA: 0x0054BD88 File Offset: 0x00549F88
		// (set) Token: 0x0601510E RID: 86286 RVA: 0x0054BDBC File Offset: 0x00549FBC
		public unsafe DPIHashtable RoomProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_RoomProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new DPIHashtable(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_RoomProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17007704 RID: 30468
		// (get) Token: 0x0601510F RID: 86287 RVA: 0x0054BDE4 File Offset: 0x00549FE4
		// (set) Token: 0x06015110 RID: 86288 RVA: 0x0054BE18 File Offset: 0x0054A018
		public unsafe DPIHashtable InternalProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_InternalProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new DPIHashtable(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_InternalProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17007705 RID: 30469
		// (get) Token: 0x06015111 RID: 86289 RVA: 0x0054BE40 File Offset: 0x0054A040
		// (set) Token: 0x06015112 RID: 86290 RVA: 0x0054BE74 File Offset: 0x0054A074
		public unsafe DPINetworkStream AdditionalData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_AdditionalData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new DPINetworkStream(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_AdditionalData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17007706 RID: 30470
		// (get) Token: 0x06015113 RID: 86291 RVA: 0x0054BE9C File Offset: 0x0054A09C
		// (set) Token: 0x06015114 RID: 86292 RVA: 0x0054BEC4 File Offset: 0x0054A0C4
		public unsafe int ServerVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_ServerVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthResponseMessage.NativeFieldInfoPtr_ServerVersion)) = value;
			}
		}

		// Token: 0x0400D731 RID: 55089
		private static readonly IntPtr NativeFieldInfoPtr_AssignedConnectionId;

		// Token: 0x0400D732 RID: 55090
		private static readonly IntPtr NativeFieldInfoPtr_MasterClientId;

		// Token: 0x0400D733 RID: 55091
		private static readonly IntPtr NativeFieldInfoPtr_CurrentServerTimestamp;

		// Token: 0x0400D734 RID: 55092
		private static readonly IntPtr NativeFieldInfoPtr_RoomProperties;

		// Token: 0x0400D735 RID: 55093
		private static readonly IntPtr NativeFieldInfoPtr_InternalProperties;

		// Token: 0x0400D736 RID: 55094
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalData;

		// Token: 0x0400D737 RID: 55095
		private static readonly IntPtr NativeFieldInfoPtr_ServerVersion;

		// Token: 0x0400D738 RID: 55096
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x0400D739 RID: 55097
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;
	}
}
