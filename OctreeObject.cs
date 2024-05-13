using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Octrees
{
	// Token: 0x020010C9 RID: 4297
	public class OctreeObject<T> : Il2CppSystem.Object
	{
		// Token: 0x0601447C RID: 83068 RVA: 0x0051A6B8 File Offset: 0x005188B8
		[CallerCount(0)]
		public unsafe OctreeObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OctreeObject<T>>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OctreeObject<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601447D RID: 83069 RVA: 0x0051A704 File Offset: 0x00518904
		[CallerCount(0)]
		public unsafe OctreeObject(T target, Vector3 position) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OctreeObject<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = target;
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
				ptr4 = ref target;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OctreeObject<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601447E RID: 83070 RVA: 0x0051A7CC File Offset: 0x005189CC
		// Note: this type is marked as 'beforefieldinit'.
		static OctreeObject()
		{
			Il2CppClassPointerStore<OctreeObject<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Octrees", "OctreeObject`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OctreeObject<T>>.NativeClassPtr);
			OctreeObject<T>.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeObject<T>>.NativeClassPtr, "Target");
			OctreeObject<T>.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeObject<T>>.NativeClassPtr, "Position");
			OctreeObject<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OctreeObject<T>>.NativeClassPtr, 100689244);
			OctreeObject<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OctreeObject<T>>.NativeClassPtr, 100689245);
		}

		// Token: 0x0601447F RID: 83071 RVA: 0x00002988 File Offset: 0x00000B88
		public OctreeObject(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170072E0 RID: 29408
		// (get) Token: 0x06014480 RID: 83072 RVA: 0x0051A887 File Offset: 0x00518A87
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OctreeObject<T>>.NativeClassPtr));
			}
		}

		// Token: 0x170072E1 RID: 29409
		// (get) Token: 0x06014481 RID: 83073 RVA: 0x0051A898 File Offset: 0x00518A98
		// (set) Token: 0x06014482 RID: 83074 RVA: 0x0051A8C4 File Offset: 0x00518AC4
		public unsafe T Target
		{
			get
			{
				IntPtr objectPointer = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeObject<T>.NativeFieldInfoPtr_Target);
				return IL2CPP.PointerToValueGeneric<T>(objectPointer, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeObject<T>.NativeFieldInfoPtr_Target);
				Type typeFromHandle = typeof(T);
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

		// Token: 0x170072E2 RID: 29410
		// (get) Token: 0x06014483 RID: 83075 RVA: 0x0051A980 File Offset: 0x00518B80
		// (set) Token: 0x06014484 RID: 83076 RVA: 0x0051A9A8 File Offset: 0x00518BA8
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeObject<T>.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeObject<T>.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x0400CF4D RID: 53069
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x0400CF4E RID: 53070
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x0400CF4F RID: 53071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400CF50 RID: 53072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_Vector3_0;
	}
}
