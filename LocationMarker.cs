using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking.IO
{
	// Token: 0x02001279 RID: 4729
	[StructLayout(2)]
	public struct LocationMarker
	{
		// Token: 0x06015837 RID: 88119 RVA: 0x0056B5C0 File Offset: 0x005697C0
		[CallerCount(0)]
		public unsafe LocationMarker(int writeBitPos, int readBitPos)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref writeBitPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readBitPos;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationMarker.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015838 RID: 88120 RVA: 0x0056B618 File Offset: 0x00569818
		// Note: this type is marked as 'beforefieldinit'.
		static LocationMarker()
		{
			Il2CppClassPointerStore<LocationMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.IO", "LocationMarker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocationMarker>.NativeClassPtr);
			LocationMarker.NativeFieldInfoPtr_WriteBitPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocationMarker>.NativeClassPtr, "WriteBitPos");
			LocationMarker.NativeFieldInfoPtr_ReadBitPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocationMarker>.NativeClassPtr, "ReadBitPos");
			LocationMarker.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationMarker>.NativeClassPtr, 100690938);
		}

		// Token: 0x06015839 RID: 88121 RVA: 0x0056B684 File Offset: 0x00569884
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocationMarker>.NativeClassPtr, ref this));
		}

		// Token: 0x17007940 RID: 31040
		// (get) Token: 0x0601583A RID: 88122 RVA: 0x0056B696 File Offset: 0x00569896
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LocationMarker>.NativeClassPtr));
			}
		}

		// Token: 0x0400DCAE RID: 56494
		private static readonly IntPtr NativeFieldInfoPtr_WriteBitPos;

		// Token: 0x0400DCAF RID: 56495
		private static readonly IntPtr NativeFieldInfoPtr_ReadBitPos;

		// Token: 0x0400DCB0 RID: 56496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x0400DCB1 RID: 56497
		[FieldOffset(0)]
		public readonly int WriteBitPos;

		// Token: 0x0400DCB2 RID: 56498
		[FieldOffset(4)]
		public readonly int ReadBitPos;
	}
}
