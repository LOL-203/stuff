using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Octrees
{
	// Token: 0x020010C8 RID: 4296
	public class OctreeBranch<T, TBranch, TObject> : Il2CppSystem.Object where TBranch : OctreeBranch<T, TBranch, TObject>, new() where TObject : OctreeObject<T>, new()
	{
		// Token: 0x0601445A RID: 83034 RVA: 0x00519D14 File Offset: 0x00517F14
		[CallerCount(0)]
		public unsafe void Initialize(Bounds bounds, int depth, int maxDepth, int maxDataCountPerBranch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bounds;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataCountPerBranch;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr_Initialize_Public_Void_Bounds_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601445B RID: 83035 RVA: 0x00519DA4 File Offset: 0x00517FA4
		[CallerCount(0)]
		public unsafe void GetData(ref List<T> foundData, Vector3 searchCenter, float radiusSquared)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(foundData);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchCenter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusSquared;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr_GetData_Public_Virtual_New_Void_byref_List_1_T_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			foundData = ((intPtr3 == 0) ? null : new List(intPtr3));
		}

		// Token: 0x0601445C RID: 83036 RVA: 0x00519E50 File Offset: 0x00518050
		[CallerCount(0)]
		public unsafe void GetData(ref List<T> foundData, Bounds searchBounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(foundData);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchBounds;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr_GetData_Public_Virtual_New_Void_byref_List_1_T_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			foundData = ((intPtr3 == 0) ? null : new List(intPtr3));
		}

		// Token: 0x0601445D RID: 83037 RVA: 0x00519EE8 File Offset: 0x005180E8
		[CallerCount(0)]
		public unsafe bool GetClosestInRadius(ref T foundItem, Vector3 searchCenter, ref float lowestDistanceSquared)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(foundItem);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchCenter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lowestDistanceSquared;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr_GetClosestInRadius_Public_Virtual_New_Boolean_byref_T_Vector3_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			foundItem = ((intPtr2 == 0) ? null : new T(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601445E RID: 83038 RVA: 0x00519FA4 File Offset: 0x005181A4
		[CallerCount(0)]
		public unsafe void AddItem(TObject dataObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			TObject ptr4;
			if (!typeof(TObject).IsValueType)
			{
				TObject tobject = dataObject;
				if (!(tobject is string))
				{
					ref TObject ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tobject as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(tobject as string);
				}
			}
			else
			{
				ptr4 = ref dataObject;
			}
			*ptr2 = ref ptr4;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_TObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601445F RID: 83039 RVA: 0x0051A05C File Offset: 0x0051825C
		[CallerCount(0)]
		public unsafe void SubDivide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr_SubDivide_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014460 RID: 83040 RVA: 0x0051A0A0 File Offset: 0x005182A0
		[CallerCount(0)]
		public unsafe OctreeBranch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014461 RID: 83041 RVA: 0x0051A0EC File Offset: 0x005182EC
		// Note: this type is marked as 'beforefieldinit'.
		static OctreeBranch()
		{
			Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Octrees", "OctreeBranch`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TBranch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr);
			OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, "_branchDepth");
			OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__maxObjectCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, "_maxObjectCount");
			OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__maxTreeDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, "_maxTreeDepth");
			OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__octreeObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, "_octreeObjects");
			OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__childBranches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, "_childBranches");
			OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__hasChildBranches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, "_hasChildBranches");
			OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, "_branchBounds");
			OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchBoundsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, "_branchBoundsMin");
			OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchBoundsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, "_branchBoundsMax");
			OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchBoundsCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, "_branchBoundsCenter");
			OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, "_branchRadius");
			OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchRadiusSqrd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, "_branchRadiusSqrd");
			OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr_Initialize_Public_Void_Bounds_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, 100689237);
			OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr_GetData_Public_Virtual_New_Void_byref_List_1_T_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, 100689238);
			OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr_GetData_Public_Virtual_New_Void_byref_List_1_T_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, 100689239);
			OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr_GetClosestInRadius_Public_Virtual_New_Boolean_byref_T_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, 100689240);
			OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, 100689241);
			OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr_SubDivide_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, 100689242);
			OctreeBranch<T, TBranch, TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr, 100689243);
		}

		// Token: 0x06014462 RID: 83042 RVA: 0x00002988 File Offset: 0x00000B88
		public OctreeBranch(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170072D3 RID: 29395
		// (get) Token: 0x06014463 RID: 83043 RVA: 0x0051A2F7 File Offset: 0x005184F7
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OctreeBranch<T, TBranch, TObject>>.NativeClassPtr));
			}
		}

		// Token: 0x170072D4 RID: 29396
		// (get) Token: 0x06014464 RID: 83044 RVA: 0x0051A308 File Offset: 0x00518508
		// (set) Token: 0x06014465 RID: 83045 RVA: 0x0051A330 File Offset: 0x00518530
		public unsafe int _branchDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchDepth)) = value;
			}
		}

		// Token: 0x170072D5 RID: 29397
		// (get) Token: 0x06014466 RID: 83046 RVA: 0x0051A354 File Offset: 0x00518554
		// (set) Token: 0x06014467 RID: 83047 RVA: 0x0051A37C File Offset: 0x0051857C
		public unsafe int _maxObjectCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__maxObjectCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__maxObjectCount)) = value;
			}
		}

		// Token: 0x170072D6 RID: 29398
		// (get) Token: 0x06014468 RID: 83048 RVA: 0x0051A3A0 File Offset: 0x005185A0
		// (set) Token: 0x06014469 RID: 83049 RVA: 0x0051A3C8 File Offset: 0x005185C8
		public unsafe int _maxTreeDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__maxTreeDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__maxTreeDepth)) = value;
			}
		}

		// Token: 0x170072D7 RID: 29399
		// (get) Token: 0x0601446A RID: 83050 RVA: 0x0051A3EC File Offset: 0x005185EC
		// (set) Token: 0x0601446B RID: 83051 RVA: 0x0051A420 File Offset: 0x00518620
		public unsafe List<TObject> _octreeObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__octreeObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<TObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__octreeObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170072D8 RID: 29400
		// (get) Token: 0x0601446C RID: 83052 RVA: 0x0051A448 File Offset: 0x00518648
		// (set) Token: 0x0601446D RID: 83053 RVA: 0x0051A47C File Offset: 0x0051867C
		public unsafe List<TBranch> _childBranches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__childBranches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<TBranch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__childBranches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170072D9 RID: 29401
		// (get) Token: 0x0601446E RID: 83054 RVA: 0x0051A4A4 File Offset: 0x005186A4
		// (set) Token: 0x0601446F RID: 83055 RVA: 0x0051A4CC File Offset: 0x005186CC
		public unsafe bool _hasChildBranches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__hasChildBranches);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__hasChildBranches)) = value;
			}
		}

		// Token: 0x170072DA RID: 29402
		// (get) Token: 0x06014470 RID: 83056 RVA: 0x0051A4F0 File Offset: 0x005186F0
		// (set) Token: 0x06014471 RID: 83057 RVA: 0x0051A518 File Offset: 0x00518718
		public unsafe Bounds _branchBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchBounds)) = value;
			}
		}

		// Token: 0x170072DB RID: 29403
		// (get) Token: 0x06014472 RID: 83058 RVA: 0x0051A53C File Offset: 0x0051873C
		// (set) Token: 0x06014473 RID: 83059 RVA: 0x0051A564 File Offset: 0x00518764
		public unsafe Vector3 _branchBoundsMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchBoundsMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchBoundsMin)) = value;
			}
		}

		// Token: 0x170072DC RID: 29404
		// (get) Token: 0x06014474 RID: 83060 RVA: 0x0051A588 File Offset: 0x00518788
		// (set) Token: 0x06014475 RID: 83061 RVA: 0x0051A5B0 File Offset: 0x005187B0
		public unsafe Vector3 _branchBoundsMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchBoundsMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchBoundsMax)) = value;
			}
		}

		// Token: 0x170072DD RID: 29405
		// (get) Token: 0x06014476 RID: 83062 RVA: 0x0051A5D4 File Offset: 0x005187D4
		// (set) Token: 0x06014477 RID: 83063 RVA: 0x0051A5FC File Offset: 0x005187FC
		public unsafe Vector3 _branchBoundsCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchBoundsCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchBoundsCenter)) = value;
			}
		}

		// Token: 0x170072DE RID: 29406
		// (get) Token: 0x06014478 RID: 83064 RVA: 0x0051A620 File Offset: 0x00518820
		// (set) Token: 0x06014479 RID: 83065 RVA: 0x0051A648 File Offset: 0x00518848
		public unsafe float _branchRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchRadius)) = value;
			}
		}

		// Token: 0x170072DF RID: 29407
		// (get) Token: 0x0601447A RID: 83066 RVA: 0x0051A66C File Offset: 0x0051886C
		// (set) Token: 0x0601447B RID: 83067 RVA: 0x0051A694 File Offset: 0x00518894
		public unsafe float _branchRadiusSqrd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchRadiusSqrd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OctreeBranch<T, TBranch, TObject>.NativeFieldInfoPtr__branchRadiusSqrd)) = value;
			}
		}

		// Token: 0x0400CF3A RID: 53050
		private static readonly IntPtr NativeFieldInfoPtr__branchDepth;

		// Token: 0x0400CF3B RID: 53051
		private static readonly IntPtr NativeFieldInfoPtr__maxObjectCount;

		// Token: 0x0400CF3C RID: 53052
		private static readonly IntPtr NativeFieldInfoPtr__maxTreeDepth;

		// Token: 0x0400CF3D RID: 53053
		private static readonly IntPtr NativeFieldInfoPtr__octreeObjects;

		// Token: 0x0400CF3E RID: 53054
		private static readonly IntPtr NativeFieldInfoPtr__childBranches;

		// Token: 0x0400CF3F RID: 53055
		private static readonly IntPtr NativeFieldInfoPtr__hasChildBranches;

		// Token: 0x0400CF40 RID: 53056
		private static readonly IntPtr NativeFieldInfoPtr__branchBounds;

		// Token: 0x0400CF41 RID: 53057
		private static readonly IntPtr NativeFieldInfoPtr__branchBoundsMin;

		// Token: 0x0400CF42 RID: 53058
		private static readonly IntPtr NativeFieldInfoPtr__branchBoundsMax;

		// Token: 0x0400CF43 RID: 53059
		private static readonly IntPtr NativeFieldInfoPtr__branchBoundsCenter;

		// Token: 0x0400CF44 RID: 53060
		private static readonly IntPtr NativeFieldInfoPtr__branchRadius;

		// Token: 0x0400CF45 RID: 53061
		private static readonly IntPtr NativeFieldInfoPtr__branchRadiusSqrd;

		// Token: 0x0400CF46 RID: 53062
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Bounds_Int32_Int32_Int32_0;

		// Token: 0x0400CF47 RID: 53063
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_New_Void_byref_List_1_T_Vector3_Single_0;

		// Token: 0x0400CF48 RID: 53064
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_New_Void_byref_List_1_T_Bounds_0;

		// Token: 0x0400CF49 RID: 53065
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestInRadius_Public_Virtual_New_Boolean_byref_T_Vector3_byref_Single_0;

		// Token: 0x0400CF4A RID: 53066
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_TObject_0;

		// Token: 0x0400CF4B RID: 53067
		private static readonly IntPtr NativeMethodInfoPtr_SubDivide_Protected_Void_0;

		// Token: 0x0400CF4C RID: 53068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
