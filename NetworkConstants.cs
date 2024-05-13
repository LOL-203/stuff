using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking
{
	// Token: 0x020011DB RID: 4571
	public static class NetworkConstants : Object
	{
		// Token: 0x170076F4 RID: 30452
		// (get) Token: 0x060150DE RID: 86238 RVA: 0x0054B490 File Offset: 0x00549690
		public unsafe static int NetworkStreamSize
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NetworkConstants.NativeMethodInfoPtr_get_NetworkStreamSize_Public_Static_get_Int32_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060150DF RID: 86239 RVA: 0x0054B4D4 File Offset: 0x005496D4
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkConstants()
		{
			Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking", "NetworkConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr);
			NetworkConstants.NativeFieldInfoPtr_MTU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, "MTU");
			NetworkConstants.NativeFieldInfoPtr_MAX_CHANNELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, "MAX_CHANNELS");
			NetworkConstants.NativeFieldInfoPtr_MAX_BATCH_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, "MAX_BATCH_SIZE");
			NetworkConstants.NativeMethodInfoPtr_get_NetworkStreamSize_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr, 100690159);
		}

		// Token: 0x060150E0 RID: 86240 RVA: 0x00002988 File Offset: 0x00000B88
		public NetworkConstants(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170076F0 RID: 30448
		// (get) Token: 0x060150E1 RID: 86241 RVA: 0x0054B554 File Offset: 0x00549754
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NetworkConstants>.NativeClassPtr));
			}
		}

		// Token: 0x170076F1 RID: 30449
		// (get) Token: 0x060150E2 RID: 86242 RVA: 0x0054B568 File Offset: 0x00549768
		// (set) Token: 0x060150E3 RID: 86243 RVA: 0x0054B586 File Offset: 0x00549786
		public unsafe static int MTU
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MTU, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MTU, (void*)(&value));
			}
		}

		// Token: 0x170076F2 RID: 30450
		// (get) Token: 0x060150E4 RID: 86244 RVA: 0x0054B598 File Offset: 0x00549798
		// (set) Token: 0x060150E5 RID: 86245 RVA: 0x0054B5B6 File Offset: 0x005497B6
		public unsafe static int MAX_CHANNELS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MAX_CHANNELS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MAX_CHANNELS, (void*)(&value));
			}
		}

		// Token: 0x170076F3 RID: 30451
		// (get) Token: 0x060150E6 RID: 86246 RVA: 0x0054B5C8 File Offset: 0x005497C8
		// (set) Token: 0x060150E7 RID: 86247 RVA: 0x0054B5E6 File Offset: 0x005497E6
		public unsafe static int MAX_BATCH_SIZE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NetworkConstants.NativeFieldInfoPtr_MAX_BATCH_SIZE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NetworkConstants.NativeFieldInfoPtr_MAX_BATCH_SIZE, (void*)(&value));
			}
		}

		// Token: 0x0400D721 RID: 55073
		private static readonly IntPtr NativeFieldInfoPtr_MTU;

		// Token: 0x0400D722 RID: 55074
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CHANNELS;

		// Token: 0x0400D723 RID: 55075
		private static readonly IntPtr NativeFieldInfoPtr_MAX_BATCH_SIZE;

		// Token: 0x0400D724 RID: 55076
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkStreamSize_Public_Static_get_Int32_0;
	}
}
