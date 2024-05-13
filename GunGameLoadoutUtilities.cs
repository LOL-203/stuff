using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.GameVariants.GunGame
{
	// Token: 0x02000FC8 RID: 4040
	public static class GunGameLoadoutUtilities : Object
	{
		// Token: 0x06013696 RID: 79510 RVA: 0x004E237C File Offset: 0x004E057C
		[CallerCount(0)]
		public unsafe static List<Il2CppArrayBase<T>> GetAllCombinations<T>(List<T> candidates, bool excludeEmpty)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(candidates);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref excludeEmpty;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutUtilities.MethodInfoStoreGeneric_GetAllCombinations_Public_Static_List_1_ArrayOf_T_List_1_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new List<Il2CppArrayBase<T>>(intPtr2) : null;
		}

		// Token: 0x06013697 RID: 79511 RVA: 0x004E23F0 File Offset: 0x004E05F0
		[CallerCount(0)]
		public unsafe static T GetEquallyWeightedElement<T>(List<Il2CppArrayBase<T>> arrays, Random random)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrays);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(random);
			IntPtr returnedException;
			IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutUtilities.MethodInfoStoreGeneric_GetEquallyWeightedElement_Public_Static_T_List_1_ArrayOf_T_Random_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06013698 RID: 79512 RVA: 0x004E2460 File Offset: 0x004E0660
		[CallerCount(0)]
		public unsafe static int WrapArray(int index, int length)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GunGameLoadoutUtilities.NativeMethodInfoPtr_WrapArray_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013699 RID: 79513 RVA: 0x004E24C8 File Offset: 0x004E06C8
		// Note: this type is marked as 'beforefieldinit'.
		static GunGameLoadoutUtilities()
		{
			Il2CppClassPointerStore<GunGameLoadoutUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.GameVariants.GunGame", "GunGameLoadoutUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunGameLoadoutUtilities>.NativeClassPtr);
			GunGameLoadoutUtilities.NativeMethodInfoPtr_GetAllCombinations_Public_Static_List_1_ArrayOf_T_List_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutUtilities>.NativeClassPtr, 100688067);
			GunGameLoadoutUtilities.NativeMethodInfoPtr_GetEquallyWeightedElement_Public_Static_T_List_1_ArrayOf_T_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutUtilities>.NativeClassPtr, 100688068);
			GunGameLoadoutUtilities.NativeMethodInfoPtr_WrapArray_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunGameLoadoutUtilities>.NativeClassPtr, 100688069);
		}

		// Token: 0x0601369A RID: 79514 RVA: 0x00002988 File Offset: 0x00000B88
		public GunGameLoadoutUtilities(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E1E RID: 28190
		// (get) Token: 0x0601369B RID: 79515 RVA: 0x004E2534 File Offset: 0x004E0734
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GunGameLoadoutUtilities>.NativeClassPtr));
			}
		}

		// Token: 0x0400C68E RID: 50830
		private static readonly IntPtr NativeMethodInfoPtr_GetAllCombinations_Public_Static_List_1_ArrayOf_T_List_1_T_Boolean_0;

		// Token: 0x0400C68F RID: 50831
		private static readonly IntPtr NativeMethodInfoPtr_GetEquallyWeightedElement_Public_Static_T_List_1_ArrayOf_T_Random_0;

		// Token: 0x0400C690 RID: 50832
		private static readonly IntPtr NativeMethodInfoPtr_WrapArray_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x02000FC9 RID: 4041
		private sealed class MethodInfoStoreGeneric_GetAllCombinations_Public_Static_List_1_ArrayOf_T_List_1_T_Boolean_0<T>
		{
			// Token: 0x0400C691 RID: 50833
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GunGameLoadoutUtilities.NativeMethodInfoPtr_GetAllCombinations_Public_Static_List_1_ArrayOf_T_List_1_T_Boolean_0, Il2CppClassPointerStore<GunGameLoadoutUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000FCA RID: 4042
		private sealed class MethodInfoStoreGeneric_GetEquallyWeightedElement_Public_Static_T_List_1_ArrayOf_T_Random_0<T>
		{
			// Token: 0x0400C692 RID: 50834
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GunGameLoadoutUtilities.NativeMethodInfoPtr_GetEquallyWeightedElement_Public_Static_T_List_1_ArrayOf_T_Random_0, Il2CppClassPointerStore<GunGameLoadoutUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
