using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking.IO
{
	// Token: 0x02001275 RID: 4725
	public static class DPINetworkStreamManager : Object
	{
		// Token: 0x06015827 RID: 88103 RVA: 0x0056B2E4 File Offset: 0x005694E4
		[CallerCount(0)]
		public unsafe static DPINetworkStream Get(DPINetworkStreamType streamType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref streamType;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamManager.NativeMethodInfoPtr_Get_Public_Static_DPINetworkStream_DPINetworkStreamType_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new DPINetworkStream(intPtr2) : null;
		}

		// Token: 0x06015828 RID: 88104 RVA: 0x0056B340 File Offset: 0x00569540
		[CallerCount(0)]
		public unsafe static void Return(DPINetworkStream stream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamManager.NativeMethodInfoPtr_Return_Public_Static_Void_DPINetworkStream_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015829 RID: 88105 RVA: 0x0056B38C File Offset: 0x0056958C
		[CallerCount(0)]
		public unsafe static void ResetPool()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPINetworkStreamManager.NativeMethodInfoPtr_ResetPool_Public_Static_Void_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601582A RID: 88106 RVA: 0x0056B3C0 File Offset: 0x005695C0
		// Note: this type is marked as 'beforefieldinit'.
		static DPINetworkStreamManager()
		{
			Il2CppClassPointerStore<DPINetworkStreamManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.IO", "DPINetworkStreamManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DPINetworkStreamManager>.NativeClassPtr);
			DPINetworkStreamManager.NativeMethodInfoPtr_Get_Public_Static_DPINetworkStream_DPINetworkStreamType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamManager>.NativeClassPtr, 100690933);
			DPINetworkStreamManager.NativeMethodInfoPtr_Return_Public_Static_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamManager>.NativeClassPtr, 100690934);
			DPINetworkStreamManager.NativeMethodInfoPtr_ResetPool_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPINetworkStreamManager>.NativeClassPtr, 100690935);
		}

		// Token: 0x0601582B RID: 88107 RVA: 0x00002988 File Offset: 0x00000B88
		public DPINetworkStreamManager(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700793C RID: 31036
		// (get) Token: 0x0601582C RID: 88108 RVA: 0x0056B42C File Offset: 0x0056962C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DPINetworkStreamManager>.NativeClassPtr));
			}
		}

		// Token: 0x0400DCA6 RID: 56486
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_DPINetworkStream_DPINetworkStreamType_0;

		// Token: 0x0400DCA7 RID: 56487
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Static_Void_DPINetworkStream_0;

		// Token: 0x0400DCA8 RID: 56488
		private static readonly IntPtr NativeMethodInfoPtr_ResetPool_Public_Static_Void_0;
	}
}
