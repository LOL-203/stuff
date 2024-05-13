using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking.IO
{
	// Token: 0x02001277 RID: 4727
	public class INetworkStreamable : Il2CppObjectBase
	{
		// Token: 0x0601582F RID: 88111 RVA: 0x0056B46C File Offset: 0x0056966C
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INetworkStreamable.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_DPINetworkStream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015830 RID: 88112 RVA: 0x0056B4D0 File Offset: 0x005696D0
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INetworkStreamable.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Void_DPINetworkStream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015831 RID: 88113 RVA: 0x0056B534 File Offset: 0x00569734
		// Note: this type is marked as 'beforefieldinit'.
		static INetworkStreamable()
		{
			Il2CppClassPointerStore<INetworkStreamable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.IO", "INetworkStreamable");
			INetworkStreamable.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INetworkStreamable>.NativeClassPtr, 100690936);
			INetworkStreamable.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INetworkStreamable>.NativeClassPtr, 100690937);
		}

		// Token: 0x06015832 RID: 88114 RVA: 0x0000206B File Offset: 0x0000026B
		public INetworkStreamable(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700793E RID: 31038
		// (get) Token: 0x06015833 RID: 88115 RVA: 0x0056B582 File Offset: 0x00569782
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<INetworkStreamable>.NativeClassPtr));
			}
		}

		// Token: 0x0400DCAC RID: 56492
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_DPINetworkStream_0;

		// Token: 0x0400DCAD RID: 56493
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Void_DPINetworkStream_0;
	}
}
