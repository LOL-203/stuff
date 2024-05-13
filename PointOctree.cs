using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Octrees
{
	// Token: 0x020010CD RID: 4301
	public class PointOctree<T> : Octree<T, PointBranch<T>, OctreeObject<T>>
	{
		// Token: 0x06014492 RID: 83090 RVA: 0x0051ADBC File Offset: 0x00518FBC
		[CallerCount(0)]
		public unsafe PointOctree(Vector3 center, float size, int maxDataCountPerBranch, int maxTreeDepth) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointOctree<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataCountPerBranch;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxTreeDepth;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointOctree<T>.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014493 RID: 83091 RVA: 0x0051AE54 File Offset: 0x00519054
		[CallerCount(0)]
		public unsafe void AddItem(T dataObject, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = dataObject;
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
				ptr4 = ref dataObject;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointOctree<T>.NativeMethodInfoPtr_AddItem_Public_Void_T_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014494 RID: 83092 RVA: 0x0051AF14 File Offset: 0x00519114
		// Note: this type is marked as 'beforefieldinit'.
		static PointOctree()
		{
			Il2CppClassPointerStore<PointOctree<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Octrees", "PointOctree`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointOctree<T>>.NativeClassPtr);
			PointOctree<T>.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointOctree<T>>.NativeClassPtr, 100689251);
			PointOctree<T>.NativeMethodInfoPtr_AddItem_Public_Void_T_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointOctree<T>>.NativeClassPtr, 100689252);
		}

		// Token: 0x06014495 RID: 83093 RVA: 0x0051AFA7 File Offset: 0x005191A7
		public PointOctree(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170072E6 RID: 29414
		// (get) Token: 0x06014496 RID: 83094 RVA: 0x0051AFB0 File Offset: 0x005191B0
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PointOctree<T>>.NativeClassPtr));
			}
		}

		// Token: 0x0400CF57 RID: 53079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_Int32_Int32_0;

		// Token: 0x0400CF58 RID: 53080
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_T_Vector3_0;
	}
}
