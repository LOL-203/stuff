using System;
using System.Runtime.InteropServices;
using DPI.Networking.IO;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking
{
	// Token: 0x020011DA RID: 4570
	[StructLayout(2)]
	public struct DPIVector3UInt9Bits
	{
		// Token: 0x060150D6 RID: 86230 RVA: 0x0054B2AC File Offset: 0x005494AC
		[CallerCount(0)]
		public unsafe void Write(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPIVector3UInt9Bits.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060150D7 RID: 86231 RVA: 0x0054B2F8 File Offset: 0x005494F8
		[CallerCount(0)]
		public unsafe void Read(DPINetworkStream networkStream)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(networkStream);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DPIVector3UInt9Bits.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060150D8 RID: 86232 RVA: 0x0054B344 File Offset: 0x00549544
		[CallerCount(0)]
		public unsafe string ToString()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DPIVector3UInt9Bits.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060150D9 RID: 86233 RVA: 0x0054B380 File Offset: 0x00549580
		// Note: this type is marked as 'beforefieldinit'.
		static DPIVector3UInt9Bits()
		{
			Il2CppClassPointerStore<DPIVector3UInt9Bits>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking", "DPIVector3UInt9Bits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DPIVector3UInt9Bits>.NativeClassPtr);
			DPIVector3UInt9Bits.NativeFieldInfoPtr_READ_WRITE_BITS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPIVector3UInt9Bits>.NativeClassPtr, "READ_WRITE_BITS");
			DPIVector3UInt9Bits.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPIVector3UInt9Bits>.NativeClassPtr, "x");
			DPIVector3UInt9Bits.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPIVector3UInt9Bits>.NativeClassPtr, "y");
			DPIVector3UInt9Bits.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DPIVector3UInt9Bits>.NativeClassPtr, "z");
			DPIVector3UInt9Bits.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPIVector3UInt9Bits>.NativeClassPtr, 100690156);
			DPIVector3UInt9Bits.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPIVector3UInt9Bits>.NativeClassPtr, 100690157);
			DPIVector3UInt9Bits.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DPIVector3UInt9Bits>.NativeClassPtr, 100690158);
		}

		// Token: 0x060150DA RID: 86234 RVA: 0x0054B43C File Offset: 0x0054963C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DPIVector3UInt9Bits>.NativeClassPtr, ref this));
		}

		// Token: 0x170076EE RID: 30446
		// (get) Token: 0x060150DB RID: 86235 RVA: 0x0054B44E File Offset: 0x0054964E
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DPIVector3UInt9Bits>.NativeClassPtr));
			}
		}

		// Token: 0x170076EF RID: 30447
		// (get) Token: 0x060150DC RID: 86236 RVA: 0x0054B460 File Offset: 0x00549660
		// (set) Token: 0x060150DD RID: 86237 RVA: 0x0054B47E File Offset: 0x0054967E
		public unsafe static int READ_WRITE_BITS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DPIVector3UInt9Bits.NativeFieldInfoPtr_READ_WRITE_BITS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DPIVector3UInt9Bits.NativeFieldInfoPtr_READ_WRITE_BITS, (void*)(&value));
			}
		}

		// Token: 0x0400D717 RID: 55063
		private static readonly IntPtr NativeFieldInfoPtr_READ_WRITE_BITS;

		// Token: 0x0400D718 RID: 55064
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400D719 RID: 55065
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x0400D71A RID: 55066
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x0400D71B RID: 55067
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x0400D71C RID: 55068
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void_DPINetworkStream_0;

		// Token: 0x0400D71D RID: 55069
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400D71E RID: 55070
		[FieldOffset(0)]
		public uint x;

		// Token: 0x0400D71F RID: 55071
		[FieldOffset(4)]
		public uint y;

		// Token: 0x0400D720 RID: 55072
		[FieldOffset(8)]
		public uint z;
	}
}
