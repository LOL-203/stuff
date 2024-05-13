using System;
using System.Runtime.InteropServices;
using DPI.Networking.IO;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking
{
	// Token: 0x020011D9 RID: 4569
	[StructLayout(2)]
	public struct DPIVector3UInt16Bits
	{
		// Token: 0x060150CE RID: 86222 RVA: 0x0054B0C8 File Offset: 0x005492C8
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPIVector3UInt16Bits.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060150CF RID: 86223 RVA: 0x0054B114 File Offset: 0x00549314
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPIVector3UInt16Bits.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060150D0 RID: 86224 RVA: 0x0054B160 File Offset: 0x00549360
		[CallerCount(0)]
		public unsafe string ToString()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DPIVector3UInt16Bits.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060150D1 RID: 86225 RVA: 0x0054B19C File Offset: 0x0054939C
		// Note: this type is marked as 'beforefieldinit'.
		static DPIVector3UInt16Bits()
		{
			Il2CppClassPointerStore<DPIVector3UInt16Bits>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking", "DPIVector3UInt16Bits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DPIVector3UInt16Bits>.NativeClassPtr);
			DPIVector3UInt16Bits.NativeFieldInfoPtr_READ_WRITE_BITS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPIVector3UInt16Bits>.NativeClassPtr, "READ_WRITE_BITS");
			DPIVector3UInt16Bits.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPIVector3UInt16Bits>.NativeClassPtr, "x");
			DPIVector3UInt16Bits.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPIVector3UInt16Bits>.NativeClassPtr, "y");
			DPIVector3UInt16Bits.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPIVector3UInt16Bits>.NativeClassPtr, "z");
			DPIVector3UInt16Bits.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPIVector3UInt16Bits>.NativeClassPtr, 100690153);
			DPIVector3UInt16Bits.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPIVector3UInt16Bits>.NativeClassPtr, 100690154);
			DPIVector3UInt16Bits.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPIVector3UInt16Bits>.NativeClassPtr, 100690155);
		}

		// Token: 0x060150D2 RID: 86226 RVA: 0x0054B258 File Offset: 0x00549458
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DPIVector3UInt16Bits>.NativeClassPtr, ref this));
		}

		// Token: 0x170076EC RID: 30444
		// (get) Token: 0x060150D3 RID: 86227 RVA: 0x0054B26A File Offset: 0x0054946A
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DPIVector3UInt16Bits>.NativeClassPtr));
			}
		}

		// Token: 0x170076ED RID: 30445
		// (get) Token: 0x060150D4 RID: 86228 RVA: 0x0054B27C File Offset: 0x0054947C
		// (set) Token: 0x060150D5 RID: 86229 RVA: 0x0054B29A File Offset: 0x0054949A
		public unsafe static int READ_WRITE_BITS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DPIVector3UInt16Bits.NativeFieldInfoPtr_READ_WRITE_BITS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DPIVector3UInt16Bits.NativeFieldInfoPtr_READ_WRITE_BITS, (void*)(&value));
			}
		}

		// Token: 0x0400D70D RID: 55053
		private static readonly IntPtr NativeFieldInfoPtr_READ_WRITE_BITS;

		// Token: 0x0400D70E RID: 55054
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400D70F RID: 55055
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x0400D710 RID: 55056
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x0400D711 RID: 55057
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x0400D712 RID: 55058
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x0400D713 RID: 55059
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400D714 RID: 55060
		[FieldOffset(0)]
		public uint x;

		// Token: 0x0400D715 RID: 55061
		[FieldOffset(4)]
		public uint y;

		// Token: 0x0400D716 RID: 55062
		[FieldOffset(8)]
		public uint z;
	}
}
