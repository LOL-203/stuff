using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Octrees
{
	// Token: 0x020010C7 RID: 4295
	public class Octree<T, TBranch, TObject> : Il2CppSystem.Object where TBranch : OctreeBranch<T, TBranch, TObject>, new() where TObject : OctreeObject<T>, new()
	{
		// Token: 0x06014450 RID: 83024 RVA: 0x00519820 File Offset: 0x00517A20
		[CallerCount(0)]
		public unsafe Octree() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Octree<T, TBranch, TObject>>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Octree<T, TBranch, TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014451 RID: 83025 RVA: 0x0051986C File Offset: 0x00517A6C
		[CallerCount(0)]
		public unsafe Octree(Vector3 center, float size, int maxDataCountPerBranch, int maxTreeDepth) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Octree<T, TBranch, TObject>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataCountPerBranch;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxTreeDepth;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Octree<T, TBranch, TObject>.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014452 RID: 83026 RVA: 0x00519904 File Offset: 0x00517B04
		[CallerCount(0)]
		public unsafe void GetAllWithinRadius(Vector3 center, float radius, ref List<T> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Octree<T, TBranch, TObject>.NativeMethodInfoPtr_GetAllWithinRadius_Public_Virtual_New_Void_Vector3_Single_byref_List_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			output = ((intPtr3 == 0) ? null : new List(intPtr3));
		}

		// Token: 0x06014453 RID: 83027 RVA: 0x005199B0 File Offset: 0x00517BB0
		[CallerCount(0)]
		public unsafe void GetAllWithinBounds(Bounds bounds, ref List<T> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bounds;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Octree<T, TBranch, TObject>.NativeMethodInfoPtr_GetAllWithinBounds_Public_Virtual_New_Void_Bounds_byref_List_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			output = ((intPtr3 == 0) ? null : new List(intPtr3));
		}

		// Token: 0x06014454 RID: 83028 RVA: 0x00519A48 File Offset: 0x00517C48
		[CallerCount(0)]
		public unsafe bool GetClosestInRadius(Vector3 center, float radius, out T closestItem, out float distanceToClosestSquared)
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
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Octree<T, TBranch, TObject>.NativeMethodInfoPtr_GetClosestInRadius_Public_Virtual_New_Boolean_Vector3_Single_byref_T_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			closestItem = ((intPtr2 == 0) ? null : new T(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06014455 RID: 83029 RVA: 0x00519B14 File Offset: 0x00517D14
		// Note: this type is marked as 'beforefieldinit'.
		static Octree()
		{
			Il2CppClassPointerStore<Octree<T, TBranch, TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Octrees", "Octree`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBranch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Octree<T, TBranch, TObject>>.NativeClassPtr);
			Octree<T, TBranch, TObject>.NativeFieldInfoPtr__root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Octree<T, TBranch, TObject>>.NativeClassPtr, "_root");
			Octree<T, TBranch, TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Octree<T, TBranch, TObject>>.NativeClassPtr, 100689232);
			Octree<T, TBranch, TObject>.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Octree<T, TBranch, TObject>>.NativeClassPtr, 100689233);
			Octree<T, TBranch, TObject>.NativeMethodInfoPtr_GetAllWithinRadius_Public_Virtual_New_Void_Vector3_Single_byref_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Octree<T, TBranch, TObject>>.NativeClassPtr, 100689234);
			Octree<T, TBranch, TObject>.NativeMethodInfoPtr_GetAllWithinBounds_Public_Virtual_New_Void_Bounds_byref_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Octree<T, TBranch, TObject>>.NativeClassPtr, 100689235);
			Octree<T, TBranch, TObject>.NativeMethodInfoPtr_GetClosestInRadius_Public_Virtual_New_Boolean_Vector3_Single_byref_T_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Octree<T, TBranch, TObject>>.NativeClassPtr, 100689236);
		}

		// Token: 0x06014456 RID: 83030 RVA: 0x00002988 File Offset: 0x00000B88
		public Octree(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170072D1 RID: 29393
		// (get) Token: 0x06014457 RID: 83031 RVA: 0x00519C1B File Offset: 0x00517E1B
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Octree<T, TBranch, TObject>>.NativeClassPtr));
			}
		}

		// Token: 0x170072D2 RID: 29394
		// (get) Token: 0x06014458 RID: 83032 RVA: 0x00519C2C File Offset: 0x00517E2C
		// (set) Token: 0x06014459 RID: 83033 RVA: 0x00519C58 File Offset: 0x00517E58
		public unsafe TBranch _root
		{
			get
			{
				IntPtr objectPointer = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Octree<T, TBranch, TObject>.NativeFieldInfoPtr__root);
				return IL2CPP.PointerToValueGeneric<TBranch>(objectPointer, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Octree<T, TBranch, TObject>.NativeFieldInfoPtr__root);
				Type typeFromHandle = typeof(TBranch);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr value2;
						IntPtr intPtr3 = value2 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
						if (intPtr3 != 0)
						{
							value2 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr obj = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(obj), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr2, value2);
					}
					else
					{
						IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x0400CF34 RID: 53044
		private static readonly IntPtr NativeFieldInfoPtr__root;

		// Token: 0x0400CF35 RID: 53045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400CF36 RID: 53046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Int32_Int32_0;

		// Token: 0x0400CF37 RID: 53047
		private static readonly IntPtr NativeMethodInfoPtr_GetAllWithinRadius_Public_Virtual_New_Void_Vector3_Single_byref_List_1_T_0;

		// Token: 0x0400CF38 RID: 53048
		private static readonly IntPtr NativeMethodInfoPtr_GetAllWithinBounds_Public_Virtual_New_Void_Bounds_byref_List_1_T_0;

		// Token: 0x0400CF39 RID: 53049
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestInRadius_Public_Virtual_New_Boolean_Vector3_Single_byref_T_byref_Single_0;
	}
}
