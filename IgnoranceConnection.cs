using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking.Transport.Ignorance
{
	// Token: 0x0200126C RID: 4716
	public class IgnoranceConnection : Connection
	{
		// Token: 0x17007914 RID: 30996
		// (get) Token: 0x06015736 RID: 87862 RVA: 0x00565CA4 File Offset: 0x00563EA4
		public new unsafe bool IsConnected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IgnoranceConnection.NativeMethodInfoPtr_get_IsConnected_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17007915 RID: 30997
		// (get) Token: 0x06015737 RID: 87863 RVA: 0x00565D00 File Offset: 0x00563F00
		public unsafe IgnoranceTransport IgnoranceTransport
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoranceConnection.NativeMethodInfoPtr_get_IgnoranceTransport_Public_get_IgnoranceTransport_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new IgnoranceTransport(intPtr2) : null;
			}
		}

		// Token: 0x06015738 RID: 87864 RVA: 0x00565D58 File Offset: 0x00563F58
		[CallerCount(0)]
		public new unsafe void DoSend(ArraySegment<byte> bytes, NetworkChannel networkChannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bytes));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref networkChannel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IgnoranceConnection.NativeMethodInfoPtr_DoSend_Protected_Virtual_Void_ArraySegment_1_Byte_NetworkChannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015739 RID: 87865 RVA: 0x00565DD4 File Offset: 0x00563FD4
		[CallerCount(0)]
		public new unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IgnoranceConnection.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601573A RID: 87866 RVA: 0x00565E24 File Offset: 0x00564024
		[CallerCount(0)]
		public new unsafe int GetRtt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IgnoranceConnection.NativeMethodInfoPtr_GetRtt_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601573B RID: 87867 RVA: 0x00565E80 File Offset: 0x00564080
		[CallerCount(0)]
		public new unsafe int GetLastMessageOutIn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IgnoranceConnection.NativeMethodInfoPtr_GetLastMessageOutIn_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601573C RID: 87868 RVA: 0x00565EDC File Offset: 0x005640DC
		[CallerCount(0)]
		public new unsafe double GetElapsedMillisecondsSinceLastMessageIn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IgnoranceConnection.NativeMethodInfoPtr_GetElapsedMillisecondsSinceLastMessageIn_Public_Virtual_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601573D RID: 87869 RVA: 0x00565F38 File Offset: 0x00564138
		[CallerCount(0)]
		public new unsafe long GetLastMessageIn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IgnoranceConnection.NativeMethodInfoPtr_GetLastMessageIn_Public_Virtual_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601573E RID: 87870 RVA: 0x00565F94 File Offset: 0x00564194
		[CallerCount(0)]
		public unsafe void SetConnected(bool connected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref connected;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoranceConnection.NativeMethodInfoPtr_SetConnected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601573F RID: 87871 RVA: 0x00565FE8 File Offset: 0x005641E8
		[CallerCount(0)]
		public unsafe IgnoranceConnection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoranceConnection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015740 RID: 87872 RVA: 0x00566034 File Offset: 0x00564234
		// Note: this type is marked as 'beforefieldinit'.
		static IgnoranceConnection()
		{
			Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.Transport.Ignorance", "IgnoranceConnection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr);
			IgnoranceConnection.NativeFieldInfoPtr__isConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, "_isConnected");
			IgnoranceConnection.NativeFieldInfoPtr_LastSendTimeMillis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, "LastSendTimeMillis");
			IgnoranceConnection.NativeFieldInfoPtr_LastReceiveTimeMillis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, "LastReceiveTimeMillis");
			IgnoranceConnection.NativeFieldInfoPtr_Rtt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, "Rtt");
			IgnoranceConnection.NativeFieldInfoPtr_NativePeerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, "NativePeerId");
			IgnoranceConnection.NativeMethodInfoPtr_get_IsConnected_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, 100690768);
			IgnoranceConnection.NativeMethodInfoPtr_get_IgnoranceTransport_Public_get_IgnoranceTransport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, 100690769);
			IgnoranceConnection.NativeMethodInfoPtr_DoSend_Protected_Virtual_Void_ArraySegment_1_Byte_NetworkChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, 100690770);
			IgnoranceConnection.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, 100690771);
			IgnoranceConnection.NativeMethodInfoPtr_GetRtt_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, 100690772);
			IgnoranceConnection.NativeMethodInfoPtr_GetLastMessageOutIn_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, 100690773);
			IgnoranceConnection.NativeMethodInfoPtr_GetElapsedMillisecondsSinceLastMessageIn_Public_Virtual_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, 100690774);
			IgnoranceConnection.NativeMethodInfoPtr_GetLastMessageIn_Public_Virtual_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, 100690775);
			IgnoranceConnection.NativeMethodInfoPtr_SetConnected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, 100690776);
			IgnoranceConnection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr, 100690777);
		}

		// Token: 0x06015741 RID: 87873 RVA: 0x00559F48 File Offset: 0x00558148
		public IgnoranceConnection(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700790E RID: 30990
		// (get) Token: 0x06015742 RID: 87874 RVA: 0x00566190 File Offset: 0x00564390
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IgnoranceConnection>.NativeClassPtr));
			}
		}

		// Token: 0x1700790F RID: 30991
		// (get) Token: 0x06015743 RID: 87875 RVA: 0x005661A4 File Offset: 0x005643A4
		// (set) Token: 0x06015744 RID: 87876 RVA: 0x005661CC File Offset: 0x005643CC
		public unsafe bool _isConnected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceConnection.NativeFieldInfoPtr__isConnected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceConnection.NativeFieldInfoPtr__isConnected)) = value;
			}
		}

		// Token: 0x17007910 RID: 30992
		// (get) Token: 0x06015745 RID: 87877 RVA: 0x005661F0 File Offset: 0x005643F0
		// (set) Token: 0x06015746 RID: 87878 RVA: 0x00566218 File Offset: 0x00564418
		public unsafe long LastSendTimeMillis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceConnection.NativeFieldInfoPtr_LastSendTimeMillis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceConnection.NativeFieldInfoPtr_LastSendTimeMillis)) = value;
			}
		}

		// Token: 0x17007911 RID: 30993
		// (get) Token: 0x06015747 RID: 87879 RVA: 0x0056623C File Offset: 0x0056443C
		// (set) Token: 0x06015748 RID: 87880 RVA: 0x00566264 File Offset: 0x00564464
		public unsafe long LastReceiveTimeMillis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceConnection.NativeFieldInfoPtr_LastReceiveTimeMillis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceConnection.NativeFieldInfoPtr_LastReceiveTimeMillis)) = value;
			}
		}

		// Token: 0x17007912 RID: 30994
		// (get) Token: 0x06015749 RID: 87881 RVA: 0x00566288 File Offset: 0x00564488
		// (set) Token: 0x0601574A RID: 87882 RVA: 0x005662B0 File Offset: 0x005644B0
		public unsafe int Rtt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceConnection.NativeFieldInfoPtr_Rtt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceConnection.NativeFieldInfoPtr_Rtt)) = value;
			}
		}

		// Token: 0x17007913 RID: 30995
		// (get) Token: 0x0601574B RID: 87883 RVA: 0x005662D4 File Offset: 0x005644D4
		// (set) Token: 0x0601574C RID: 87884 RVA: 0x005662FC File Offset: 0x005644FC
		public unsafe uint NativePeerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceConnection.NativeFieldInfoPtr_NativePeerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IgnoranceConnection.NativeFieldInfoPtr_NativePeerId)) = value;
			}
		}

		// Token: 0x0400DBE1 RID: 56289
		private static readonly IntPtr NativeFieldInfoPtr__isConnected;

		// Token: 0x0400DBE2 RID: 56290
		private static readonly IntPtr NativeFieldInfoPtr_LastSendTimeMillis;

		// Token: 0x0400DBE3 RID: 56291
		private static readonly IntPtr NativeFieldInfoPtr_LastReceiveTimeMillis;

		// Token: 0x0400DBE4 RID: 56292
		private static readonly IntPtr NativeFieldInfoPtr_Rtt;

		// Token: 0x0400DBE5 RID: 56293
		private static readonly IntPtr NativeFieldInfoPtr_NativePeerId;

		// Token: 0x0400DBE6 RID: 56294
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConnected_Public_Virtual_get_Boolean_0;

		// Token: 0x0400DBE7 RID: 56295
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoranceTransport_Public_get_IgnoranceTransport_0;

		// Token: 0x0400DBE8 RID: 56296
		private static readonly IntPtr NativeMethodInfoPtr_DoSend_Protected_Virtual_Void_ArraySegment_1_Byte_NetworkChannel_0;

		// Token: 0x0400DBE9 RID: 56297
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x0400DBEA RID: 56298
		private static readonly IntPtr NativeMethodInfoPtr_GetRtt_Public_Virtual_Int32_0;

		// Token: 0x0400DBEB RID: 56299
		private static readonly IntPtr NativeMethodInfoPtr_GetLastMessageOutIn_Public_Virtual_Int32_0;

		// Token: 0x0400DBEC RID: 56300
		private static readonly IntPtr NativeMethodInfoPtr_GetElapsedMillisecondsSinceLastMessageIn_Public_Virtual_Double_0;

		// Token: 0x0400DBED RID: 56301
		private static readonly IntPtr NativeMethodInfoPtr_GetLastMessageIn_Public_Virtual_Int64_0;

		// Token: 0x0400DBEE RID: 56302
		private static readonly IntPtr NativeMethodInfoPtr_SetConnected_Public_Void_Boolean_0;

		// Token: 0x0400DBEF RID: 56303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
