using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Octrees
{
	// Token: 0x020010CA RID: 4298
	public class OctreeUtilities : Il2CppSystem.Object
	{
		// Token: 0x06014485 RID: 83077 RVA: 0x0051A9CC File Offset: 0x00518BCC
		[CallerCount(0)]
		public unsafe static void CreateSubBranches<T, B, O>(Bounds parentBounds, int maxDataCount, int depth, int maxDepth, ref List<B> branches) where B : OctreeBranch<T, B, O>, new() where O : OctreeObject<T>, new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref parentBounds;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(branches);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(OctreeUtilities.MethodInfoStoreGeneric_CreateSubBranches_Public_Static_Void_Bounds_Int32_Int32_Int32_byref_List_1_B_0<T, B, O>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			branches = ((intPtr3 == 0) ? null : new List(intPtr3));
		}

		// Token: 0x06014486 RID: 83078 RVA: 0x0051AA84 File Offset: 0x00518C84
		[CallerCount(0)]
		public unsafe static void CreateSubBranches(Bounds parentBounds, int maxDataCount, int depth, int maxDepth, ref List<NavmapPointBranch> branches)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref parentBounds;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(branches);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(OctreeUtilities.NativeMethodInfoPtr_CreateSubBranches_Public_Static_Void_Bounds_Int32_Int32_Int32_byref_List_1_NavmapPointBranch_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			branches = ((intPtr3 == 0) ? null : new List(intPtr3));
		}

		// Token: 0x06014487 RID: 83079 RVA: 0x0051AB3C File Offset: 0x00518D3C
		[CallerCount(0)]
		public unsafe OctreeUtilities() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OctreeUtilities>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OctreeUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014488 RID: 83080 RVA: 0x0051AB88 File Offset: 0x00518D88
		// Note: this type is marked as 'beforefieldinit'.
		static OctreeUtilities()
		{
			Il2CppClassPointerStore<OctreeUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Octrees", "OctreeUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OctreeUtilities>.NativeClassPtr);
			OctreeUtilities.NativeFieldInfoPtr__Offsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeUtilities>.NativeClassPtr, "_Offsets");
			OctreeUtilities.NativeMethodInfoPtr_CreateSubBranches_Public_Static_Void_Bounds_Int32_Int32_Int32_byref_List_1_B_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OctreeUtilities>.NativeClassPtr, 100689246);
			OctreeUtilities.NativeMethodInfoPtr_CreateSubBranches_Public_Static_Void_Bounds_Int32_Int32_Int32_byref_List_1_NavmapPointBranch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OctreeUtilities>.NativeClassPtr, 100689247);
			OctreeUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OctreeUtilities>.NativeClassPtr, 100689248);
		}

		// Token: 0x06014489 RID: 83081 RVA: 0x00002988 File Offset: 0x00000B88
		public OctreeUtilities(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170072E3 RID: 29411
		// (get) Token: 0x0601448A RID: 83082 RVA: 0x0051AC08 File Offset: 0x00518E08
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OctreeUtilities>.NativeClassPtr));
			}
		}

		// Token: 0x170072E4 RID: 29412
		// (get) Token: 0x0601448B RID: 83083 RVA: 0x0051AC1C File Offset: 0x00518E1C
		// (set) Token: 0x0601448C RID: 83084 RVA: 0x0051AC47 File Offset: 0x00518E47
		public unsafe static List<Vector3> _Offsets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OctreeUtilities.NativeFieldInfoPtr__Offsets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new List<Vector3>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OctreeUtilities.NativeFieldInfoPtr__Offsets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400CF51 RID: 53073
		private static readonly IntPtr NativeFieldInfoPtr__Offsets;

		// Token: 0x0400CF52 RID: 53074
		private static readonly IntPtr NativeMethodInfoPtr_CreateSubBranches_Public_Static_Void_Bounds_Int32_Int32_Int32_byref_List_1_B_0;

		// Token: 0x0400CF53 RID: 53075
		private static readonly IntPtr NativeMethodInfoPtr_CreateSubBranches_Public_Static_Void_Bounds_Int32_Int32_Int32_byref_List_1_NavmapPointBranch_0;

		// Token: 0x0400CF54 RID: 53076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020010CB RID: 4299
		private sealed class MethodInfoStoreGeneric_CreateSubBranches_Public_Static_Void_Bounds_Int32_Int32_Int32_byref_List_1_B_0<T, B, O>
		{
			// Token: 0x0400CF55 RID: 53077
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OctreeUtilities.NativeMethodInfoPtr_CreateSubBranches_Public_Static_Void_Bounds_Int32_Int32_Int32_byref_List_1_B_0, Il2CppClassPointerStore<OctreeUtilities>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<B>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<O>.NativeClassPtr))
			}))));
		}
	}
}
