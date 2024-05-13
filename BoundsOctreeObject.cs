using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Octrees
{
	// Token: 0x020010C6 RID: 4294
	public class BoundsOctreeObject<T> : OctreeObject<T>
	{
		// Token: 0x06014441 RID: 83009 RVA: 0x0051947C File Offset: 0x0051767C
		[CallerCount(0)]
		public unsafe BoundsOctreeObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsOctreeObject<T>>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsOctreeObject<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014442 RID: 83010 RVA: 0x005194C8 File Offset: 0x005176C8
		[CallerCount(0)]
		public unsafe BoundsOctreeObject(T target, Bounds bounds) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundsOctreeObject<T>>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsOctreeObject<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014443 RID: 83011 RVA: 0x00519590 File Offset: 0x00517790
		// Note: this type is marked as 'beforefieldinit'.
		static BoundsOctreeObject()
		{
			Il2CppClassPointerStore<BoundsOctreeObject<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Octrees", "BoundsOctreeObject`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsOctreeObject<T>>.NativeClassPtr);
			BoundsOctreeObject<T>.NativeFieldInfoPtr_SearchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsOctreeObject<T>>.NativeClassPtr, "SearchID");
			BoundsOctreeObject<T>.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsOctreeObject<T>>.NativeClassPtr, "Bounds");
			BoundsOctreeObject<T>.NativeFieldInfoPtr_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsOctreeObject<T>>.NativeClassPtr, "Center");
			BoundsOctreeObject<T>.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsOctreeObject<T>>.NativeClassPtr, "Min");
			BoundsOctreeObject<T>.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsOctreeObject<T>>.NativeClassPtr, "Max");
			BoundsOctreeObject<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsOctreeObject<T>>.NativeClassPtr, 100689230);
			BoundsOctreeObject<T>.NativeMethodInfoPtr__ctor_Public_Void_T_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsOctreeObject<T>>.NativeClassPtr, 100689231);
		}

		// Token: 0x06014444 RID: 83012 RVA: 0x00519687 File Offset: 0x00517887
		public BoundsOctreeObject(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170072CB RID: 29387
		// (get) Token: 0x06014445 RID: 83013 RVA: 0x00519690 File Offset: 0x00517890
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BoundsOctreeObject<T>>.NativeClassPtr));
			}
		}

		// Token: 0x170072CC RID: 29388
		// (get) Token: 0x06014446 RID: 83014 RVA: 0x005196A4 File Offset: 0x005178A4
		// (set) Token: 0x06014447 RID: 83015 RVA: 0x005196CC File Offset: 0x005178CC
		public unsafe int SearchID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsOctreeObject<T>.NativeFieldInfoPtr_SearchID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsOctreeObject<T>.NativeFieldInfoPtr_SearchID)) = value;
			}
		}

		// Token: 0x170072CD RID: 29389
		// (get) Token: 0x06014448 RID: 83016 RVA: 0x005196F0 File Offset: 0x005178F0
		// (set) Token: 0x06014449 RID: 83017 RVA: 0x00519718 File Offset: 0x00517918
		public unsafe Bounds Bounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsOctreeObject<T>.NativeFieldInfoPtr_Bounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsOctreeObject<T>.NativeFieldInfoPtr_Bounds)) = value;
			}
		}

		// Token: 0x170072CE RID: 29390
		// (get) Token: 0x0601444A RID: 83018 RVA: 0x0051973C File Offset: 0x0051793C
		// (set) Token: 0x0601444B RID: 83019 RVA: 0x00519764 File Offset: 0x00517964
		public unsafe Vector3 Center
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsOctreeObject<T>.NativeFieldInfoPtr_Center);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsOctreeObject<T>.NativeFieldInfoPtr_Center)) = value;
			}
		}

		// Token: 0x170072CF RID: 29391
		// (get) Token: 0x0601444C RID: 83020 RVA: 0x00519788 File Offset: 0x00517988
		// (set) Token: 0x0601444D RID: 83021 RVA: 0x005197B0 File Offset: 0x005179B0
		public unsafe Vector3 Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsOctreeObject<T>.NativeFieldInfoPtr_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsOctreeObject<T>.NativeFieldInfoPtr_Min)) = value;
			}
		}

		// Token: 0x170072D0 RID: 29392
		// (get) Token: 0x0601444E RID: 83022 RVA: 0x005197D4 File Offset: 0x005179D4
		// (set) Token: 0x0601444F RID: 83023 RVA: 0x005197FC File Offset: 0x005179FC
		public unsafe Vector3 Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsOctreeObject<T>.NativeFieldInfoPtr_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoundsOctreeObject<T>.NativeFieldInfoPtr_Max)) = value;
			}
		}

		// Token: 0x0400CF2D RID: 53037
		private static readonly IntPtr NativeFieldInfoPtr_SearchID;

		// Token: 0x0400CF2E RID: 53038
		private static readonly IntPtr NativeFieldInfoPtr_Bounds;

		// Token: 0x0400CF2F RID: 53039
		private static readonly IntPtr NativeFieldInfoPtr_Center;

		// Token: 0x0400CF30 RID: 53040
		private static readonly IntPtr NativeFieldInfoPtr_Min;

		// Token: 0x0400CF31 RID: 53041
		private static readonly IntPtr NativeFieldInfoPtr_Max;

		// Token: 0x0400CF32 RID: 53042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400CF33 RID: 53043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_Bounds_0;
	}
}
