using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace TerrainStitch
{
	// Token: 0x0200061E RID: 1566
	public class IntArrayComparer : Object
	{
		// Token: 0x06007F30 RID: 32560 RVA: 0x002022C8 File Offset: 0x002004C8
		[CallerCount(0)]
		public unsafe bool Equals(Il2CppStructArray<int> x, Il2CppStructArray<int> y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IntArrayComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ArrayOf_Int32_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007F31 RID: 32561 RVA: 0x00202348 File Offset: 0x00200548
		[CallerCount(0)]
		public unsafe int GetHashCode(Il2CppStructArray<int> obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr returnedException;
			IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(IntArrayComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj2);
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x002023B0 File Offset: 0x002005B0
		[CallerCount(0)]
		public unsafe IntArrayComparer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntArrayComparer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntArrayComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F33 RID: 32563 RVA: 0x002023FC File Offset: 0x002005FC
		// Note: this type is marked as 'beforefieldinit'.
		static IntArrayComparer()
		{
			Il2CppClassPointerStore<IntArrayComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TerrainStitch", "IntArrayComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntArrayComparer>.NativeClassPtr);
			IntArrayComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ArrayOf_Int32_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntArrayComparer>.NativeClassPtr, 100673576);
			IntArrayComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntArrayComparer>.NativeClassPtr, 100673577);
			IntArrayComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntArrayComparer>.NativeClassPtr, 100673578);
		}

		// Token: 0x06007F34 RID: 32564 RVA: 0x00002988 File Offset: 0x00000B88
		public IntArrayComparer(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x06007F35 RID: 32565 RVA: 0x00202468 File Offset: 0x00200668
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IntArrayComparer>.NativeClassPtr));
			}
		}

		// Token: 0x0400519A RID: 20890
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ArrayOf_Int32_ArrayOf_Int32_0;

		// Token: 0x0400519B RID: 20891
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ArrayOf_Int32_0;

		// Token: 0x0400519C RID: 20892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
