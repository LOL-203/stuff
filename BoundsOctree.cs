using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Octrees
{
	// Token: 0x020010C5 RID: 4293
	public class BoundsOctree<T> : Octree<T, BoundsBranch<T>, BoundsOctreeObject<T>>
	{
		// Token: 0x06014437 RID: 82999 RVA: 0x00518F9C File Offset: 0x0051719C
		[CallerCount(0)]
		public unsafe BoundsOctree(Vector3 center, float size, int maxDataCountPerBranch, int maxTreeDepth) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsOctree<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataCountPerBranch;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxTreeDepth;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsOctree<T>.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014438 RID: 83000 RVA: 0x00519034 File Offset: 0x00517234
		[CallerCount(0)]
		public unsafe void AddItem(T item, Bounds itemBounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref item;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemBounds;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsOctree<T>.NativeMethodInfoPtr_AddItem_Public_Void_T_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014439 RID: 83001 RVA: 0x005190F4 File Offset: 0x005172F4
		[CallerCount(0)]
		public new unsafe void GetAllWithinRadius(Vector3 center, float radius, ref List<T> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoundsOctree<T>.NativeMethodInfoPtr_GetAllWithinRadius_Public_Virtual_Void_Vector3_Single_byref_List_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			output = ((intPtr3 == 0) ? null : new List(intPtr3));
		}

		// Token: 0x0601443A RID: 83002 RVA: 0x005191A0 File Offset: 0x005173A0
		[CallerCount(0)]
		public new unsafe bool GetClosestInRadius(Vector3 center, float radius, out T closestItem, out float distanceToClosestSquared)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(closestItem);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &distanceToClosestSquared;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoundsOctree<T>.NativeMethodInfoPtr_GetClosestInRadius_Public_Virtual_Boolean_Vector3_Single_byref_T_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			closestItem = ((intPtr2 == 0) ? null : new T(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601443B RID: 83003 RVA: 0x0051926C File Offset: 0x0051746C
		[CallerCount(0)]
		public unsafe bool GetClosestInRadiusExcludingFullyEncompassingItems(Vector3 center, float radius, out T closestItem, out float distanceToClosestSquared)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(closestItem);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &distanceToClosestSquared;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BoundsOctree<T>.NativeMethodInfoPtr_GetClosestInRadiusExcludingFullyEncompassingItems_Public_Boolean_Vector3_Single_byref_T_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			closestItem = ((intPtr2 == 0) ? null : new T(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601443C RID: 83004 RVA: 0x00519330 File Offset: 0x00517530
		// Note: this type is marked as 'beforefieldinit'.
		static BoundsOctree()
		{
			Il2CppClassPointerStore<BoundsOctree<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Octrees", "BoundsOctree`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsOctree<T>>.NativeClassPtr);
			BoundsOctree<T>.NativeFieldInfoPtr__searchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsOctree<T>>.NativeClassPtr, "_searchID");
			BoundsOctree<T>.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsOctree<T>>.NativeClassPtr, 100689225);
			BoundsOctree<T>.NativeMethodInfoPtr_AddItem_Public_Void_T_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsOctree<T>>.NativeClassPtr, 100689226);
			BoundsOctree<T>.NativeMethodInfoPtr_GetAllWithinRadius_Public_Virtual_Void_Vector3_Single_byref_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsOctree<T>>.NativeClassPtr, 100689227);
			BoundsOctree<T>.NativeMethodInfoPtr_GetClosestInRadius_Public_Virtual_Boolean_Vector3_Single_byref_T_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsOctree<T>>.NativeClassPtr, 100689228);
			BoundsOctree<T>.NativeMethodInfoPtr_GetClosestInRadiusExcludingFullyEncompassingItems_Public_Boolean_Vector3_Single_byref_T_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsOctree<T>>.NativeClassPtr, 100689229);
		}

		// Token: 0x0601443D RID: 83005 RVA: 0x00519413 File Offset: 0x00517613
		public BoundsOctree(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170072C9 RID: 29385
		// (get) Token: 0x0601443E RID: 83006 RVA: 0x0051941C File Offset: 0x0051761C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BoundsOctree<T>>.NativeClassPtr));
			}
		}

		// Token: 0x170072CA RID: 29386
		// (get) Token: 0x0601443F RID: 83007 RVA: 0x00519430 File Offset: 0x00517630
		// (set) Token: 0x06014440 RID: 83008 RVA: 0x00519458 File Offset: 0x00517658
		public unsafe int _searchID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsOctree<T>.NativeFieldInfoPtr__searchID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsOctree<T>.NativeFieldInfoPtr__searchID)) = value;
			}
		}

		// Token: 0x0400CF27 RID: 53031
		private static readonly IntPtr NativeFieldInfoPtr__searchID;

		// Token: 0x0400CF28 RID: 53032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Int32_Int32_0;

		// Token: 0x0400CF29 RID: 53033
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_T_Bounds_0;

		// Token: 0x0400CF2A RID: 53034
		private static readonly IntPtr NativeMethodInfoPtr_GetAllWithinRadius_Public_Virtual_Void_Vector3_Single_byref_List_1_T_0;

		// Token: 0x0400CF2B RID: 53035
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestInRadius_Public_Virtual_Boolean_Vector3_Single_byref_T_byref_Single_0;

		// Token: 0x0400CF2C RID: 53036
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestInRadiusExcludingFullyEncompassingItems_Public_Boolean_Vector3_Single_byref_T_byref_Single_0;
	}
}
