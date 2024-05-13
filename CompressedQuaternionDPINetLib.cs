using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking.IO
{
	// Token: 0x0200126F RID: 4719
	public static class CompressedQuaternionDPINetLib : Object
	{
		// Token: 0x06015773 RID: 87923 RVA: 0x00566DE0 File Offset: 0x00564FE0
		[CallerCount(0)]
		public unsafe static uint Compress(ref DPIQuaternion q)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &q;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CompressedQuaternionDPINetLib.NativeMethodInfoPtr_Compress_Public_Static_UInt32_byref_DPIQuaternion_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06015774 RID: 87924 RVA: 0x00566E34 File Offset: 0x00565034
		[CallerCount(0)]
		public unsafe static void FindLargestIndex(uint i, ref uint largestIndex, float* components)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref i;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &largestIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompressedQuaternionDPINetLib.NativeMethodInfoPtr_FindLargestIndex_Private_Static_Void_UInt32_byref_UInt32_ptr_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015775 RID: 87925 RVA: 0x00566EA8 File Offset: 0x005650A8
		[CallerCount(0)]
		public unsafe static void CompressComponent(ref uint comp, float value, int i, uint largestIndex, uint negate)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &comp;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref largestIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negate;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompressedQuaternionDPINetLib.NativeMethodInfoPtr_CompressComponent_Private_Static_Void_byref_UInt32_Single_Int32_UInt32_UInt32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015776 RID: 87926 RVA: 0x00566F3C File Offset: 0x0056513C
		[CallerCount(0)]
		public unsafe static void Decompress(uint comp, out DPIQuaternion q)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref comp;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &q;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompressedQuaternionDPINetLib.NativeMethodInfoPtr_Decompress_Public_Static_Void_UInt32_byref_DPIQuaternion_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015777 RID: 87927 RVA: 0x00566F98 File Offset: 0x00565198
		[CallerCount(0)]
		public unsafe static float DecompressComponent(ref uint comp, ref float value, int i, uint largestIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &comp;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref largestIndex;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CompressedQuaternionDPINetLib.NativeMethodInfoPtr_DecompressComponent_Private_Static_Single_byref_UInt32_byref_Single_Int32_UInt32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06015778 RID: 87928 RVA: 0x00567028 File Offset: 0x00565228
		// Note: this type is marked as 'beforefieldinit'.
		static CompressedQuaternionDPINetLib()
		{
			Il2CppClassPointerStore<CompressedQuaternionDPINetLib>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.IO", "CompressedQuaternionDPINetLib");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompressedQuaternionDPINetLib>.NativeClassPtr);
			CompressedQuaternionDPINetLib.NativeFieldInfoPtr_SQRT_1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompressedQuaternionDPINetLib>.NativeClassPtr, "SQRT_1_2");
			CompressedQuaternionDPINetLib.NativeMethodInfoPtr_Compress_Public_Static_UInt32_byref_DPIQuaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompressedQuaternionDPINetLib>.NativeClassPtr, 100690794);
			CompressedQuaternionDPINetLib.NativeMethodInfoPtr_FindLargestIndex_Private_Static_Void_UInt32_byref_UInt32_ptr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompressedQuaternionDPINetLib>.NativeClassPtr, 100690795);
			CompressedQuaternionDPINetLib.NativeMethodInfoPtr_CompressComponent_Private_Static_Void_byref_UInt32_Single_Int32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompressedQuaternionDPINetLib>.NativeClassPtr, 100690796);
			CompressedQuaternionDPINetLib.NativeMethodInfoPtr_Decompress_Public_Static_Void_UInt32_byref_DPIQuaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompressedQuaternionDPINetLib>.NativeClassPtr, 100690797);
			CompressedQuaternionDPINetLib.NativeMethodInfoPtr_DecompressComponent_Private_Static_Single_byref_UInt32_byref_Single_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompressedQuaternionDPINetLib>.NativeClassPtr, 100690798);
		}

		// Token: 0x06015779 RID: 87929 RVA: 0x00002988 File Offset: 0x00000B88
		public CompressedQuaternionDPINetLib(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17007921 RID: 31009
		// (get) Token: 0x0601577A RID: 87930 RVA: 0x005670D0 File Offset: 0x005652D0
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CompressedQuaternionDPINetLib>.NativeClassPtr));
			}
		}

		// Token: 0x17007922 RID: 31010
		// (get) Token: 0x0601577B RID: 87931 RVA: 0x005670E4 File Offset: 0x005652E4
		// (set) Token: 0x0601577C RID: 87932 RVA: 0x00567102 File Offset: 0x00565302
		public unsafe static float SQRT_1_2
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CompressedQuaternionDPINetLib.NativeFieldInfoPtr_SQRT_1_2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompressedQuaternionDPINetLib.NativeFieldInfoPtr_SQRT_1_2, (void*)(&value));
			}
		}

		// Token: 0x0400DC08 RID: 56328
		private static readonly IntPtr NativeFieldInfoPtr_SQRT_1_2;

		// Token: 0x0400DC09 RID: 56329
		private static readonly IntPtr NativeMethodInfoPtr_Compress_Public_Static_UInt32_byref_DPIQuaternion_0;

		// Token: 0x0400DC0A RID: 56330
		private static readonly IntPtr NativeMethodInfoPtr_FindLargestIndex_Private_Static_Void_UInt32_byref_UInt32_ptr_Single_0;

		// Token: 0x0400DC0B RID: 56331
		private static readonly IntPtr NativeMethodInfoPtr_CompressComponent_Private_Static_Void_byref_UInt32_Single_Int32_UInt32_UInt32_0;

		// Token: 0x0400DC0C RID: 56332
		private static readonly IntPtr NativeMethodInfoPtr_Decompress_Public_Static_Void_UInt32_byref_DPIQuaternion_0;

		// Token: 0x0400DC0D RID: 56333
		private static readonly IntPtr NativeMethodInfoPtr_DecompressComponent_Private_Static_Single_byref_UInt32_byref_Single_Int32_UInt32_0;
	}
}
