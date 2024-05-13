using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Octrees
{
	// Token: 0x020010C4 RID: 4292
	public class BoundsBranch<T> : OctreeBranch<T, BoundsBranch<T>, BoundsOctreeObject<T>>
	{
		// Token: 0x06014430 RID: 82992 RVA: 0x00518C8C File Offset: 0x00516E8C
		[CallerCount(0)]
		public unsafe BoundsBranch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsBranch<T>>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsBranch<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014431 RID: 82993 RVA: 0x00518CD8 File Offset: 0x00516ED8
		[CallerCount(0)]
		public new unsafe void AddItem(BoundsOctreeObject<T> dataObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataObject);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoundsBranch<T>.NativeMethodInfoPtr_AddItem_Public_Virtual_Void_BoundsOctreeObject_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014432 RID: 82994 RVA: 0x00518D3C File Offset: 0x00516F3C
		[CallerCount(0)]
		public unsafe void GetObjects(int searchID, ref List<T> foundData, Bounds searchBounds, float radiusSquared)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref searchID;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(foundData);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchBounds;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusSquared;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BoundsBranch<T>.NativeMethodInfoPtr_GetObjects_Public_Void_Int32_byref_List_1_T_Bounds_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			foundData = ((intPtr3 == 0) ? null : new List(intPtr3));
		}

		// Token: 0x06014433 RID: 82995 RVA: 0x00518DF0 File Offset: 0x00516FF0
		[CallerCount(0)]
		public unsafe bool GetClosestInRadius(int searchID, ref T foundItem, Vector3 searchCenter, ref float lowestDistanceSquared, bool includeEncompassingBounds = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref searchID;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(foundItem);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchCenter;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lowestDistanceSquared;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeEncompassingBounds;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BoundsBranch<T>.NativeMethodInfoPtr_GetClosestInRadius_Public_Boolean_Int32_byref_T_Vector3_byref_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			foundItem = ((intPtr2 == 0) ? null : new T(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06014434 RID: 82996 RVA: 0x00518EC4 File Offset: 0x005170C4
		// Note: this type is marked as 'beforefieldinit'.
		static BoundsBranch()
		{
			Il2CppClassPointerStore<BoundsBranch<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Octrees", "BoundsBranch`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsBranch<T>>.NativeClassPtr);
			BoundsBranch<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsBranch<T>>.NativeClassPtr, 100689221);
			BoundsBranch<T>.NativeMethodInfoPtr_AddItem_Public_Virtual_Void_BoundsOctreeObject_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsBranch<T>>.NativeClassPtr, 100689222);
			BoundsBranch<T>.NativeMethodInfoPtr_GetObjects_Public_Void_Int32_byref_List_1_T_Bounds_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsBranch<T>>.NativeClassPtr, 100689223);
			BoundsBranch<T>.NativeMethodInfoPtr_GetClosestInRadius_Public_Boolean_Int32_byref_T_Vector3_byref_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsBranch<T>>.NativeClassPtr, 100689224);
		}

		// Token: 0x06014435 RID: 82997 RVA: 0x00518F7F File Offset: 0x0051717F
		public BoundsBranch(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170072C8 RID: 29384
		// (get) Token: 0x06014436 RID: 82998 RVA: 0x00518F88 File Offset: 0x00517188
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BoundsBranch<T>>.NativeClassPtr));
			}
		}

		// Token: 0x0400CF23 RID: 53027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400CF24 RID: 53028
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Virtual_Void_BoundsOctreeObject_1_T_0;

		// Token: 0x0400CF25 RID: 53029
		private static readonly IntPtr NativeMethodInfoPtr_GetObjects_Public_Void_Int32_byref_List_1_T_Bounds_Single_0;

		// Token: 0x0400CF26 RID: 53030
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestInRadius_Public_Boolean_Int32_byref_T_Vector3_byref_Single_Boolean_0;
	}
}
