using System;
using DPI.Navigation;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Octrees
{
	// Token: 0x020010C2 RID: 4290
	public class NavmapPointBranch : Il2CppSystem.Object
	{
		// Token: 0x06014405 RID: 82949 RVA: 0x005181A8 File Offset: 0x005163A8
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavmapPointBranch.NativeMethodInfoPtr_Initialize_Public_Void_Bounds_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014406 RID: 82950 RVA: 0x00518238 File Offset: 0x00516438
		[CallerCount(0)]
		public unsafe void GetData(ref List<NavigationNode> foundData, Vector3 searchCenter, float radiusSquared)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(foundData);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchCenter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusSquared;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NavmapPointBranch.NativeMethodInfoPtr_GetData_Public_Virtual_New_Void_byref_List_1_NavigationNode_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			foundData = ((intPtr3 == 0) ? null : new List(intPtr3));
		}

		// Token: 0x06014407 RID: 82951 RVA: 0x005182E4 File Offset: 0x005164E4
		[CallerCount(0)]
		public unsafe void GetData(ref List<NavigationNode> foundData, Bounds searchBounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(foundData);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchBounds;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NavmapPointBranch.NativeMethodInfoPtr_GetData_Public_Virtual_New_Void_byref_List_1_NavigationNode_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			foundData = ((intPtr3 == 0) ? null : new List(intPtr3));
		}

		// Token: 0x06014408 RID: 82952 RVA: 0x0051837C File Offset: 0x0051657C
		[CallerCount(0)]
		public unsafe bool GetClosestInRadius(ref NavigationNode foundItem, Vector3 searchCenter, ref float lowestDistanceSquared)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(foundItem);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchCenter;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lowestDistanceSquared;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NavmapPointBranch.NativeMethodInfoPtr_GetClosestInRadius_Public_Virtual_New_Boolean_byref_NavigationNode_Vector3_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06014409 RID: 82953 RVA: 0x00518418 File Offset: 0x00516618
		[CallerCount(0)]
		public unsafe void AddItem(NavmapPointObject dataObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataObject);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NavmapPointBranch.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_NavmapPointObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601440A RID: 82954 RVA: 0x0051847C File Offset: 0x0051667C
		[CallerCount(0)]
		public unsafe void SubDivide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavmapPointBranch.NativeMethodInfoPtr_SubDivide_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601440B RID: 82955 RVA: 0x005184C0 File Offset: 0x005166C0
		[CallerCount(0)]
		public unsafe NavmapPointBranch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavmapPointBranch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601440C RID: 82956 RVA: 0x0051850C File Offset: 0x0051670C
		// Note: this type is marked as 'beforefieldinit'.
		static NavmapPointBranch()
		{
			Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Octrees", "NavmapPointBranch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr);
			NavmapPointBranch.NativeFieldInfoPtr__branchDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, "_branchDepth");
			NavmapPointBranch.NativeFieldInfoPtr__maxObjectCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, "_maxObjectCount");
			NavmapPointBranch.NativeFieldInfoPtr__maxTreeDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, "_maxTreeDepth");
			NavmapPointBranch.NativeFieldInfoPtr__octreeObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, "_octreeObjects");
			NavmapPointBranch.NativeFieldInfoPtr__childBranches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, "_childBranches");
			NavmapPointBranch.NativeFieldInfoPtr__hasChildBranches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, "_hasChildBranches");
			NavmapPointBranch.NativeFieldInfoPtr__branchBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, "_branchBounds");
			NavmapPointBranch.NativeFieldInfoPtr__branchBoundsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, "_branchBoundsMin");
			NavmapPointBranch.NativeFieldInfoPtr__branchBoundsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, "_branchBoundsMax");
			NavmapPointBranch.NativeFieldInfoPtr__branchBoundsCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, "_branchBoundsCenter");
			NavmapPointBranch.NativeFieldInfoPtr__branchRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, "_branchRadius");
			NavmapPointBranch.NativeFieldInfoPtr__branchRadiusSqrd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, "_branchRadiusSqrd");
			NavmapPointBranch.NativeMethodInfoPtr_Initialize_Public_Void_Bounds_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, 100689212);
			NavmapPointBranch.NativeMethodInfoPtr_GetData_Public_Virtual_New_Void_byref_List_1_NavigationNode_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, 100689213);
			NavmapPointBranch.NativeMethodInfoPtr_GetData_Public_Virtual_New_Void_byref_List_1_NavigationNode_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, 100689214);
			NavmapPointBranch.NativeMethodInfoPtr_GetClosestInRadius_Public_Virtual_New_Boolean_byref_NavigationNode_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, 100689215);
			NavmapPointBranch.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_NavmapPointObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, 100689216);
			NavmapPointBranch.NativeMethodInfoPtr_SubDivide_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, 100689217);
			NavmapPointBranch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr, 100689218);
		}

		// Token: 0x0601440D RID: 82957 RVA: 0x00002988 File Offset: 0x00000B88
		public NavmapPointBranch(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170072B8 RID: 29368
		// (get) Token: 0x0601440E RID: 82958 RVA: 0x005186B8 File Offset: 0x005168B8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<NavmapPointBranch>.NativeClassPtr));
			}
		}

		// Token: 0x170072B9 RID: 29369
		// (get) Token: 0x0601440F RID: 82959 RVA: 0x005186CC File Offset: 0x005168CC
		// (set) Token: 0x06014410 RID: 82960 RVA: 0x005186F4 File Offset: 0x005168F4
		public unsafe int _branchDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchDepth)) = value;
			}
		}

		// Token: 0x170072BA RID: 29370
		// (get) Token: 0x06014411 RID: 82961 RVA: 0x00518718 File Offset: 0x00516918
		// (set) Token: 0x06014412 RID: 82962 RVA: 0x00518740 File Offset: 0x00516940
		public unsafe int _maxObjectCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__maxObjectCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__maxObjectCount)) = value;
			}
		}

		// Token: 0x170072BB RID: 29371
		// (get) Token: 0x06014413 RID: 82963 RVA: 0x00518764 File Offset: 0x00516964
		// (set) Token: 0x06014414 RID: 82964 RVA: 0x0051878C File Offset: 0x0051698C
		public unsafe int _maxTreeDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__maxTreeDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__maxTreeDepth)) = value;
			}
		}

		// Token: 0x170072BC RID: 29372
		// (get) Token: 0x06014415 RID: 82965 RVA: 0x005187B0 File Offset: 0x005169B0
		// (set) Token: 0x06014416 RID: 82966 RVA: 0x005187E4 File Offset: 0x005169E4
		public unsafe List<NavmapPointObject> _octreeObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__octreeObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<NavmapPointObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__octreeObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170072BD RID: 29373
		// (get) Token: 0x06014417 RID: 82967 RVA: 0x0051880C File Offset: 0x00516A0C
		// (set) Token: 0x06014418 RID: 82968 RVA: 0x00518840 File Offset: 0x00516A40
		public unsafe List<NavmapPointBranch> _childBranches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__childBranches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<NavmapPointBranch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__childBranches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170072BE RID: 29374
		// (get) Token: 0x06014419 RID: 82969 RVA: 0x00518868 File Offset: 0x00516A68
		// (set) Token: 0x0601441A RID: 82970 RVA: 0x00518890 File Offset: 0x00516A90
		public unsafe bool _hasChildBranches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__hasChildBranches);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__hasChildBranches)) = value;
			}
		}

		// Token: 0x170072BF RID: 29375
		// (get) Token: 0x0601441B RID: 82971 RVA: 0x005188B4 File Offset: 0x00516AB4
		// (set) Token: 0x0601441C RID: 82972 RVA: 0x005188DC File Offset: 0x00516ADC
		public unsafe Bounds _branchBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchBounds)) = value;
			}
		}

		// Token: 0x170072C0 RID: 29376
		// (get) Token: 0x0601441D RID: 82973 RVA: 0x00518900 File Offset: 0x00516B00
		// (set) Token: 0x0601441E RID: 82974 RVA: 0x00518928 File Offset: 0x00516B28
		public unsafe Vector3 _branchBoundsMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchBoundsMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchBoundsMin)) = value;
			}
		}

		// Token: 0x170072C1 RID: 29377
		// (get) Token: 0x0601441F RID: 82975 RVA: 0x0051894C File Offset: 0x00516B4C
		// (set) Token: 0x06014420 RID: 82976 RVA: 0x00518974 File Offset: 0x00516B74
		public unsafe Vector3 _branchBoundsMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchBoundsMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchBoundsMax)) = value;
			}
		}

		// Token: 0x170072C2 RID: 29378
		// (get) Token: 0x06014421 RID: 82977 RVA: 0x00518998 File Offset: 0x00516B98
		// (set) Token: 0x06014422 RID: 82978 RVA: 0x005189C0 File Offset: 0x00516BC0
		public unsafe Vector3 _branchBoundsCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchBoundsCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchBoundsCenter)) = value;
			}
		}

		// Token: 0x170072C3 RID: 29379
		// (get) Token: 0x06014423 RID: 82979 RVA: 0x005189E4 File Offset: 0x00516BE4
		// (set) Token: 0x06014424 RID: 82980 RVA: 0x00518A0C File Offset: 0x00516C0C
		public unsafe float _branchRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchRadius)) = value;
			}
		}

		// Token: 0x170072C4 RID: 29380
		// (get) Token: 0x06014425 RID: 82981 RVA: 0x00518A30 File Offset: 0x00516C30
		// (set) Token: 0x06014426 RID: 82982 RVA: 0x00518A58 File Offset: 0x00516C58
		public unsafe float _branchRadiusSqrd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchRadiusSqrd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavmapPointBranch.NativeFieldInfoPtr__branchRadiusSqrd)) = value;
			}
		}

		// Token: 0x0400CF0C RID: 53004
		private static readonly IntPtr NativeFieldInfoPtr__branchDepth;

		// Token: 0x0400CF0D RID: 53005
		private static readonly IntPtr NativeFieldInfoPtr__maxObjectCount;

		// Token: 0x0400CF0E RID: 53006
		private static readonly IntPtr NativeFieldInfoPtr__maxTreeDepth;

		// Token: 0x0400CF0F RID: 53007
		private static readonly IntPtr NativeFieldInfoPtr__octreeObjects;

		// Token: 0x0400CF10 RID: 53008
		private static readonly IntPtr NativeFieldInfoPtr__childBranches;

		// Token: 0x0400CF11 RID: 53009
		private static readonly IntPtr NativeFieldInfoPtr__hasChildBranches;

		// Token: 0x0400CF12 RID: 53010
		private static readonly IntPtr NativeFieldInfoPtr__branchBounds;

		// Token: 0x0400CF13 RID: 53011
		private static readonly IntPtr NativeFieldInfoPtr__branchBoundsMin;

		// Token: 0x0400CF14 RID: 53012
		private static readonly IntPtr NativeFieldInfoPtr__branchBoundsMax;

		// Token: 0x0400CF15 RID: 53013
		private static readonly IntPtr NativeFieldInfoPtr__branchBoundsCenter;

		// Token: 0x0400CF16 RID: 53014
		private static readonly IntPtr NativeFieldInfoPtr__branchRadius;

		// Token: 0x0400CF17 RID: 53015
		private static readonly IntPtr NativeFieldInfoPtr__branchRadiusSqrd;

		// Token: 0x0400CF18 RID: 53016
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Bounds_Int32_Int32_Int32_0;

		// Token: 0x0400CF19 RID: 53017
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_New_Void_byref_List_1_NavigationNode_Vector3_Single_0;

		// Token: 0x0400CF1A RID: 53018
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_New_Void_byref_List_1_NavigationNode_Bounds_0;

		// Token: 0x0400CF1B RID: 53019
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestInRadius_Public_Virtual_New_Boolean_byref_NavigationNode_Vector3_byref_Single_0;

		// Token: 0x0400CF1C RID: 53020
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_NavmapPointObject_0;

		// Token: 0x0400CF1D RID: 53021
		private static readonly IntPtr NativeMethodInfoPtr_SubDivide_Protected_Void_0;

		// Token: 0x0400CF1E RID: 53022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
