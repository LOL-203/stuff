using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace UltimateGameTools.MeshSimplifier
{
	// Token: 0x02000608 RID: 1544
	[Serializable]
	public class MeshUniqueVertices : Il2CppSystem.Object
	{
		// Token: 0x17002CB2 RID: 11442
		// (get) Token: 0x06007C8B RID: 31883 RVA: 0x001F46E8 File Offset: 0x001F28E8
		public unsafe Il2CppReferenceArray<MeshUniqueVertices.ListIndices> SubmeshesFaceList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.NativeMethodInfoPtr_get_SubmeshesFaceList_Public_get_ArrayOf_ListIndices_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<MeshUniqueVertices.ListIndices>(intPtr2) : null;
			}
		}

		// Token: 0x17002CB3 RID: 11443
		// (get) Token: 0x06007C8C RID: 31884 RVA: 0x001F4740 File Offset: 0x001F2940
		public unsafe List<Vector3> ListVertices
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.NativeMethodInfoPtr_get_ListVertices_Public_get_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new List<Vector3>(intPtr2) : null;
			}
		}

		// Token: 0x17002CB4 RID: 11444
		// (get) Token: 0x06007C8D RID: 31885 RVA: 0x001F4798 File Offset: 0x001F2998
		public unsafe List<Vector3> ListVerticesWorld
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.NativeMethodInfoPtr_get_ListVerticesWorld_Public_get_List_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new List<Vector3>(intPtr2) : null;
			}
		}

		// Token: 0x17002CB5 RID: 11445
		// (get) Token: 0x06007C8E RID: 31886 RVA: 0x001F47F0 File Offset: 0x001F29F0
		public unsafe List<MeshUniqueVertices.SerializableBoneWeight> ListBoneWeights
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.NativeMethodInfoPtr_get_ListBoneWeights_Public_get_List_1_SerializableBoneWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new List<MeshUniqueVertices.SerializableBoneWeight>(intPtr2) : null;
			}
		}

		// Token: 0x06007C8F RID: 31887 RVA: 0x001F4848 File Offset: 0x001F2A48
		[CallerCount(0)]
		public unsafe void BuildData(Mesh sourceMesh, Il2CppStructArray<Vector3> av3VerticesWorld)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceMesh);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(av3VerticesWorld);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.NativeMethodInfoPtr_BuildData_Public_Void_Mesh_ArrayOf_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C90 RID: 31888 RVA: 0x001F48BC File Offset: 0x001F2ABC
		[CallerCount(0)]
		public unsafe MeshUniqueVertices() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C91 RID: 31889 RVA: 0x001F4908 File Offset: 0x001F2B08
		// Note: this type is marked as 'beforefieldinit'.
		static MeshUniqueVertices()
		{
			Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UltimateGameTools.MeshSimplifier", "MeshUniqueVertices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr);
			MeshUniqueVertices.NativeFieldInfoPtr_m_listVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, "m_listVertices");
			MeshUniqueVertices.NativeFieldInfoPtr_m_listVerticesWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, "m_listVerticesWorld");
			MeshUniqueVertices.NativeFieldInfoPtr_m_listBoneWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, "m_listBoneWeights");
			MeshUniqueVertices.NativeFieldInfoPtr_m_aFaceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, "m_aFaceList");
			MeshUniqueVertices.NativeMethodInfoPtr_get_SubmeshesFaceList_Public_get_ArrayOf_ListIndices_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, 100673231);
			MeshUniqueVertices.NativeMethodInfoPtr_get_ListVertices_Public_get_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, 100673232);
			MeshUniqueVertices.NativeMethodInfoPtr_get_ListVerticesWorld_Public_get_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, 100673233);
			MeshUniqueVertices.NativeMethodInfoPtr_get_ListBoneWeights_Public_get_List_1_SerializableBoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, 100673234);
			MeshUniqueVertices.NativeMethodInfoPtr_BuildData_Public_Void_Mesh_ArrayOf_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, 100673235);
			MeshUniqueVertices.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, 100673236);
		}

		// Token: 0x06007C92 RID: 31890 RVA: 0x00002988 File Offset: 0x00000B88
		public MeshUniqueVertices(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x06007C93 RID: 31891 RVA: 0x001F4A00 File Offset: 0x001F2C00
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr));
			}
		}

		// Token: 0x17002CAE RID: 11438
		// (get) Token: 0x06007C94 RID: 31892 RVA: 0x001F4A14 File Offset: 0x001F2C14
		// (set) Token: 0x06007C95 RID: 31893 RVA: 0x001F4A48 File Offset: 0x001F2C48
		public unsafe List<Vector3> m_listVertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.NativeFieldInfoPtr_m_listVertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.NativeFieldInfoPtr_m_listVertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x06007C96 RID: 31894 RVA: 0x001F4A70 File Offset: 0x001F2C70
		// (set) Token: 0x06007C97 RID: 31895 RVA: 0x001F4AA4 File Offset: 0x001F2CA4
		public unsafe List<Vector3> m_listVerticesWorld
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.NativeFieldInfoPtr_m_listVerticesWorld);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.NativeFieldInfoPtr_m_listVerticesWorld), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB0 RID: 11440
		// (get) Token: 0x06007C98 RID: 31896 RVA: 0x001F4ACC File Offset: 0x001F2CCC
		// (set) Token: 0x06007C99 RID: 31897 RVA: 0x001F4B00 File Offset: 0x001F2D00
		public unsafe List<MeshUniqueVertices.SerializableBoneWeight> m_listBoneWeights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.NativeFieldInfoPtr_m_listBoneWeights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<MeshUniqueVertices.SerializableBoneWeight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.NativeFieldInfoPtr_m_listBoneWeights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB1 RID: 11441
		// (get) Token: 0x06007C9A RID: 31898 RVA: 0x001F4B28 File Offset: 0x001F2D28
		// (set) Token: 0x06007C9B RID: 31899 RVA: 0x001F4B5C File Offset: 0x001F2D5C
		public unsafe Il2CppReferenceArray<MeshUniqueVertices.ListIndices> m_aFaceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.NativeFieldInfoPtr_m_aFaceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<MeshUniqueVertices.ListIndices>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.NativeFieldInfoPtr_m_aFaceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FB7 RID: 20407
		private static readonly IntPtr NativeFieldInfoPtr_m_listVertices;

		// Token: 0x04004FB8 RID: 20408
		private static readonly IntPtr NativeFieldInfoPtr_m_listVerticesWorld;

		// Token: 0x04004FB9 RID: 20409
		private static readonly IntPtr NativeFieldInfoPtr_m_listBoneWeights;

		// Token: 0x04004FBA RID: 20410
		private static readonly IntPtr NativeFieldInfoPtr_m_aFaceList;

		// Token: 0x04004FBB RID: 20411
		private static readonly IntPtr NativeMethodInfoPtr_get_SubmeshesFaceList_Public_get_ArrayOf_ListIndices_0;

		// Token: 0x04004FBC RID: 20412
		private static readonly IntPtr NativeMethodInfoPtr_get_ListVertices_Public_get_List_1_Vector3_0;

		// Token: 0x04004FBD RID: 20413
		private static readonly IntPtr NativeMethodInfoPtr_get_ListVerticesWorld_Public_get_List_1_Vector3_0;

		// Token: 0x04004FBE RID: 20414
		private static readonly IntPtr NativeMethodInfoPtr_get_ListBoneWeights_Public_get_List_1_SerializableBoneWeight_0;

		// Token: 0x04004FBF RID: 20415
		private static readonly IntPtr NativeMethodInfoPtr_BuildData_Public_Void_Mesh_ArrayOf_Vector3_0;

		// Token: 0x04004FC0 RID: 20416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000609 RID: 1545
		[Serializable]
		public class ListIndices : Il2CppSystem.Object
		{
			// Token: 0x06007C9C RID: 31900 RVA: 0x001F4B84 File Offset: 0x001F2D84
			[CallerCount(0)]
			public unsafe ListIndices() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshUniqueVertices.ListIndices>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.ListIndices.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007C9D RID: 31901 RVA: 0x001F4BD0 File Offset: 0x001F2DD0
			// Note: this type is marked as 'beforefieldinit'.
			static ListIndices()
			{
				Il2CppClassPointerStore<MeshUniqueVertices.ListIndices>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, "ListIndices");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUniqueVertices.ListIndices>.NativeClassPtr);
				MeshUniqueVertices.ListIndices.NativeFieldInfoPtr_m_listIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.ListIndices>.NativeClassPtr, "m_listIndices");
				MeshUniqueVertices.ListIndices.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.ListIndices>.NativeClassPtr, 100673237);
			}

			// Token: 0x06007C9E RID: 31902 RVA: 0x00002988 File Offset: 0x00000B88
			public ListIndices(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002CB6 RID: 11446
			// (get) Token: 0x06007C9F RID: 31903 RVA: 0x001F4C23 File Offset: 0x001F2E23
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MeshUniqueVertices.ListIndices>.NativeClassPtr));
				}
			}

			// Token: 0x17002CB7 RID: 11447
			// (get) Token: 0x06007CA0 RID: 31904 RVA: 0x001F4C34 File Offset: 0x001F2E34
			// (set) Token: 0x06007CA1 RID: 31905 RVA: 0x001F4C68 File Offset: 0x001F2E68
			public unsafe List<int> m_listIndices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.ListIndices.NativeFieldInfoPtr_m_listIndices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<int>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.ListIndices.NativeFieldInfoPtr_m_listIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004FC1 RID: 20417
			private static readonly IntPtr NativeFieldInfoPtr_m_listIndices;

			// Token: 0x04004FC2 RID: 20418
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200060A RID: 1546
		[Serializable]
		public class SerializableBoneWeight : Il2CppSystem.Object
		{
			// Token: 0x06007CA2 RID: 31906 RVA: 0x001F4C90 File Offset: 0x001F2E90
			[CallerCount(0)]
			public unsafe SerializableBoneWeight(BoneWeight boneWeight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref boneWeight;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.SerializableBoneWeight.NativeMethodInfoPtr__ctor_Public_Void_BoneWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007CA3 RID: 31907 RVA: 0x001F4CF0 File Offset: 0x001F2EF0
			[CallerCount(0)]
			public unsafe BoneWeight ToBoneWeight()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.SerializableBoneWeight.NativeMethodInfoPtr_ToBoneWeight_Public_BoneWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007CA4 RID: 31908 RVA: 0x001F4D40 File Offset: 0x001F2F40
			// Note: this type is marked as 'beforefieldinit'.
			static SerializableBoneWeight()
			{
				Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, "SerializableBoneWeight");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr);
				MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneIndex0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr, "_boneIndex0");
				MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneIndex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr, "_boneIndex1");
				MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneIndex2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr, "_boneIndex2");
				MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneIndex3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr, "_boneIndex3");
				MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneWeight0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr, "_boneWeight0");
				MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneWeight1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr, "_boneWeight1");
				MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneWeight2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr, "_boneWeight2");
				MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneWeight3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr, "_boneWeight3");
				MeshUniqueVertices.SerializableBoneWeight.NativeMethodInfoPtr__ctor_Public_Void_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr, 100673238);
				MeshUniqueVertices.SerializableBoneWeight.NativeMethodInfoPtr_ToBoneWeight_Public_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr, 100673239);
			}

			// Token: 0x06007CA5 RID: 31909 RVA: 0x00002988 File Offset: 0x00000B88
			public SerializableBoneWeight(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002CB8 RID: 11448
			// (get) Token: 0x06007CA6 RID: 31910 RVA: 0x001F4E33 File Offset: 0x001F3033
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MeshUniqueVertices.SerializableBoneWeight>.NativeClassPtr));
				}
			}

			// Token: 0x17002CB9 RID: 11449
			// (get) Token: 0x06007CA7 RID: 31911 RVA: 0x001F4E44 File Offset: 0x001F3044
			// (set) Token: 0x06007CA8 RID: 31912 RVA: 0x001F4E6C File Offset: 0x001F306C
			public unsafe int _boneIndex0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneIndex0);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneIndex0)) = value;
				}
			}

			// Token: 0x17002CBA RID: 11450
			// (get) Token: 0x06007CA9 RID: 31913 RVA: 0x001F4E90 File Offset: 0x001F3090
			// (set) Token: 0x06007CAA RID: 31914 RVA: 0x001F4EB8 File Offset: 0x001F30B8
			public unsafe int _boneIndex1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneIndex1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneIndex1)) = value;
				}
			}

			// Token: 0x17002CBB RID: 11451
			// (get) Token: 0x06007CAB RID: 31915 RVA: 0x001F4EDC File Offset: 0x001F30DC
			// (set) Token: 0x06007CAC RID: 31916 RVA: 0x001F4F04 File Offset: 0x001F3104
			public unsafe int _boneIndex2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneIndex2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneIndex2)) = value;
				}
			}

			// Token: 0x17002CBC RID: 11452
			// (get) Token: 0x06007CAD RID: 31917 RVA: 0x001F4F28 File Offset: 0x001F3128
			// (set) Token: 0x06007CAE RID: 31918 RVA: 0x001F4F50 File Offset: 0x001F3150
			public unsafe int _boneIndex3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneIndex3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneIndex3)) = value;
				}
			}

			// Token: 0x17002CBD RID: 11453
			// (get) Token: 0x06007CAF RID: 31919 RVA: 0x001F4F74 File Offset: 0x001F3174
			// (set) Token: 0x06007CB0 RID: 31920 RVA: 0x001F4F9C File Offset: 0x001F319C
			public unsafe float _boneWeight0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneWeight0);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneWeight0)) = value;
				}
			}

			// Token: 0x17002CBE RID: 11454
			// (get) Token: 0x06007CB1 RID: 31921 RVA: 0x001F4FC0 File Offset: 0x001F31C0
			// (set) Token: 0x06007CB2 RID: 31922 RVA: 0x001F4FE8 File Offset: 0x001F31E8
			public unsafe float _boneWeight1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneWeight1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneWeight1)) = value;
				}
			}

			// Token: 0x17002CBF RID: 11455
			// (get) Token: 0x06007CB3 RID: 31923 RVA: 0x001F500C File Offset: 0x001F320C
			// (set) Token: 0x06007CB4 RID: 31924 RVA: 0x001F5034 File Offset: 0x001F3234
			public unsafe float _boneWeight2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneWeight2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneWeight2)) = value;
				}
			}

			// Token: 0x17002CC0 RID: 11456
			// (get) Token: 0x06007CB5 RID: 31925 RVA: 0x001F5058 File Offset: 0x001F3258
			// (set) Token: 0x06007CB6 RID: 31926 RVA: 0x001F5080 File Offset: 0x001F3280
			public unsafe float _boneWeight3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneWeight3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.SerializableBoneWeight.NativeFieldInfoPtr__boneWeight3)) = value;
				}
			}

			// Token: 0x04004FC3 RID: 20419
			private static readonly IntPtr NativeFieldInfoPtr__boneIndex0;

			// Token: 0x04004FC4 RID: 20420
			private static readonly IntPtr NativeFieldInfoPtr__boneIndex1;

			// Token: 0x04004FC5 RID: 20421
			private static readonly IntPtr NativeFieldInfoPtr__boneIndex2;

			// Token: 0x04004FC6 RID: 20422
			private static readonly IntPtr NativeFieldInfoPtr__boneIndex3;

			// Token: 0x04004FC7 RID: 20423
			private static readonly IntPtr NativeFieldInfoPtr__boneWeight0;

			// Token: 0x04004FC8 RID: 20424
			private static readonly IntPtr NativeFieldInfoPtr__boneWeight1;

			// Token: 0x04004FC9 RID: 20425
			private static readonly IntPtr NativeFieldInfoPtr__boneWeight2;

			// Token: 0x04004FCA RID: 20426
			private static readonly IntPtr NativeFieldInfoPtr__boneWeight3;

			// Token: 0x04004FCB RID: 20427
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BoneWeight_0;

			// Token: 0x04004FCC RID: 20428
			private static readonly IntPtr NativeMethodInfoPtr_ToBoneWeight_Public_BoneWeight_0;
		}

		// Token: 0x0200060B RID: 1547
		public class UniqueVertex : Il2CppSystem.Object
		{
			// Token: 0x06007CB7 RID: 31927 RVA: 0x001F50A4 File Offset: 0x001F32A4
			[CallerCount(0)]
			public new unsafe bool Equals(Il2CppSystem.Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr returnedException;
				IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj2);
			}

			// Token: 0x06007CB8 RID: 31928 RVA: 0x001F5118 File Offset: 0x001F3318
			[CallerCount(0)]
			public new unsafe int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007CB9 RID: 31929 RVA: 0x001F5174 File Offset: 0x001F3374
			[CallerCount(0)]
			public unsafe UniqueVertex(Vector3 v3Vertex) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref v3Vertex;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007CBA RID: 31930 RVA: 0x001F51D4 File Offset: 0x001F33D4
			[CallerCount(0)]
			public unsafe Vector3 ToVertex()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_ToVertex_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007CBB RID: 31931 RVA: 0x001F5224 File Offset: 0x001F3424
			[CallerCount(0)]
			public unsafe static bool operator ==(MeshUniqueVertices.UniqueVertex a, MeshUniqueVertices.UniqueVertex b)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UniqueVertex_UniqueVertex_0, 0, (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007CBC RID: 31932 RVA: 0x001F5294 File Offset: 0x001F3494
			[CallerCount(0)]
			public unsafe static bool operator !=(MeshUniqueVertices.UniqueVertex a, MeshUniqueVertices.UniqueVertex b)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UniqueVertex_UniqueVertex_0, 0, (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007CBD RID: 31933 RVA: 0x001F5304 File Offset: 0x001F3504
			[CallerCount(0)]
			public unsafe void FromVertex(Vector3 vertex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref vertex;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_FromVertex_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007CBE RID: 31934 RVA: 0x001F5358 File Offset: 0x001F3558
			[CallerCount(0)]
			public unsafe int CoordToFixed(float fCoord)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref fCoord;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_CoordToFixed_Private_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007CBF RID: 31935 RVA: 0x001F53BC File Offset: 0x001F35BC
			[CallerCount(0)]
			public unsafe float FixedToCoord(int nFixed)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nFixed;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_FixedToCoord_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007CC0 RID: 31936 RVA: 0x001F5420 File Offset: 0x001F3620
			// Note: this type is marked as 'beforefieldinit'.
			static UniqueVertex()
			{
				Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, "UniqueVertex");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr);
				MeshUniqueVertices.UniqueVertex.NativeFieldInfoPtr_m_nFixedX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr, "m_nFixedX");
				MeshUniqueVertices.UniqueVertex.NativeFieldInfoPtr_m_nFixedY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr, "m_nFixedY");
				MeshUniqueVertices.UniqueVertex.NativeFieldInfoPtr_m_nFixedZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr, "m_nFixedZ");
				MeshUniqueVertices.UniqueVertex.NativeFieldInfoPtr_fDecimalMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr, "fDecimalMultiplier");
				MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr, 100673240);
				MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr, 100673241);
				MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr__ctor_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr, 100673242);
				MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_ToVertex_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr, 100673243);
				MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UniqueVertex_UniqueVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr, 100673244);
				MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UniqueVertex_UniqueVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr, 100673245);
				MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_FromVertex_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr, 100673246);
				MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_CoordToFixed_Private_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr, 100673247);
				MeshUniqueVertices.UniqueVertex.NativeMethodInfoPtr_FixedToCoord_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr, 100673248);
			}

			// Token: 0x06007CC1 RID: 31937 RVA: 0x00002988 File Offset: 0x00000B88
			public UniqueVertex(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002CC1 RID: 11457
			// (get) Token: 0x06007CC2 RID: 31938 RVA: 0x001F554F File Offset: 0x001F374F
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MeshUniqueVertices.UniqueVertex>.NativeClassPtr));
				}
			}

			// Token: 0x17002CC2 RID: 11458
			// (get) Token: 0x06007CC3 RID: 31939 RVA: 0x001F5560 File Offset: 0x001F3760
			// (set) Token: 0x06007CC4 RID: 31940 RVA: 0x001F5588 File Offset: 0x001F3788
			public unsafe int m_nFixedX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.UniqueVertex.NativeFieldInfoPtr_m_nFixedX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.UniqueVertex.NativeFieldInfoPtr_m_nFixedX)) = value;
				}
			}

			// Token: 0x17002CC3 RID: 11459
			// (get) Token: 0x06007CC5 RID: 31941 RVA: 0x001F55AC File Offset: 0x001F37AC
			// (set) Token: 0x06007CC6 RID: 31942 RVA: 0x001F55D4 File Offset: 0x001F37D4
			public unsafe int m_nFixedY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.UniqueVertex.NativeFieldInfoPtr_m_nFixedY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.UniqueVertex.NativeFieldInfoPtr_m_nFixedY)) = value;
				}
			}

			// Token: 0x17002CC4 RID: 11460
			// (get) Token: 0x06007CC7 RID: 31943 RVA: 0x001F55F8 File Offset: 0x001F37F8
			// (set) Token: 0x06007CC8 RID: 31944 RVA: 0x001F5620 File Offset: 0x001F3820
			public unsafe int m_nFixedZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.UniqueVertex.NativeFieldInfoPtr_m_nFixedZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.UniqueVertex.NativeFieldInfoPtr_m_nFixedZ)) = value;
				}
			}

			// Token: 0x17002CC5 RID: 11461
			// (get) Token: 0x06007CC9 RID: 31945 RVA: 0x001F5644 File Offset: 0x001F3844
			// (set) Token: 0x06007CCA RID: 31946 RVA: 0x001F5662 File Offset: 0x001F3862
			public unsafe static float fDecimalMultiplier
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(MeshUniqueVertices.UniqueVertex.NativeFieldInfoPtr_fDecimalMultiplier, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MeshUniqueVertices.UniqueVertex.NativeFieldInfoPtr_fDecimalMultiplier, (void*)(&value));
				}
			}

			// Token: 0x04004FCD RID: 20429
			private static readonly IntPtr NativeFieldInfoPtr_m_nFixedX;

			// Token: 0x04004FCE RID: 20430
			private static readonly IntPtr NativeFieldInfoPtr_m_nFixedY;

			// Token: 0x04004FCF RID: 20431
			private static readonly IntPtr NativeFieldInfoPtr_m_nFixedZ;

			// Token: 0x04004FD0 RID: 20432
			private static readonly IntPtr NativeFieldInfoPtr_fDecimalMultiplier;

			// Token: 0x04004FD1 RID: 20433
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04004FD2 RID: 20434
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04004FD3 RID: 20435
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_0;

			// Token: 0x04004FD4 RID: 20436
			private static readonly IntPtr NativeMethodInfoPtr_ToVertex_Public_Vector3_0;

			// Token: 0x04004FD5 RID: 20437
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UniqueVertex_UniqueVertex_0;

			// Token: 0x04004FD6 RID: 20438
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UniqueVertex_UniqueVertex_0;

			// Token: 0x04004FD7 RID: 20439
			private static readonly IntPtr NativeMethodInfoPtr_FromVertex_Private_Void_Vector3_0;

			// Token: 0x04004FD8 RID: 20440
			private static readonly IntPtr NativeMethodInfoPtr_CoordToFixed_Private_Int32_Single_0;

			// Token: 0x04004FD9 RID: 20441
			private static readonly IntPtr NativeMethodInfoPtr_FixedToCoord_Private_Single_Int32_0;
		}

		// Token: 0x0200060C RID: 1548
		public class RepeatedVertex : Il2CppSystem.Object
		{
			// Token: 0x17002CC9 RID: 11465
			// (get) Token: 0x06007CCB RID: 31947 RVA: 0x001F5674 File Offset: 0x001F3874
			public unsafe int FaceIndex
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.RepeatedVertex.NativeMethodInfoPtr_get_FaceIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x17002CCA RID: 11466
			// (get) Token: 0x06007CCC RID: 31948 RVA: 0x001F56C4 File Offset: 0x001F38C4
			public unsafe int OriginalVertexIndex
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.RepeatedVertex.NativeMethodInfoPtr_get_OriginalVertexIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x06007CCD RID: 31949 RVA: 0x001F5714 File Offset: 0x001F3914
			[CallerCount(0)]
			public unsafe RepeatedVertex(int nFaceIndex, int nOriginalVertexIndex) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertex>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nFaceIndex;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOriginalVertexIndex;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.RepeatedVertex.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007CCE RID: 31950 RVA: 0x001F5784 File Offset: 0x001F3984
			// Note: this type is marked as 'beforefieldinit'.
			static RepeatedVertex()
			{
				Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, "RepeatedVertex");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertex>.NativeClassPtr);
				MeshUniqueVertices.RepeatedVertex.NativeFieldInfoPtr__nFaceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertex>.NativeClassPtr, "_nFaceIndex");
				MeshUniqueVertices.RepeatedVertex.NativeFieldInfoPtr__nOriginalVertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertex>.NativeClassPtr, "_nOriginalVertexIndex");
				MeshUniqueVertices.RepeatedVertex.NativeMethodInfoPtr_get_FaceIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertex>.NativeClassPtr, 100673249);
				MeshUniqueVertices.RepeatedVertex.NativeMethodInfoPtr_get_OriginalVertexIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertex>.NativeClassPtr, 100673250);
				MeshUniqueVertices.RepeatedVertex.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertex>.NativeClassPtr, 100673251);
			}

			// Token: 0x06007CCF RID: 31951 RVA: 0x00002988 File Offset: 0x00000B88
			public RepeatedVertex(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002CC6 RID: 11462
			// (get) Token: 0x06007CD0 RID: 31952 RVA: 0x001F5813 File Offset: 0x001F3A13
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertex>.NativeClassPtr));
				}
			}

			// Token: 0x17002CC7 RID: 11463
			// (get) Token: 0x06007CD1 RID: 31953 RVA: 0x001F5824 File Offset: 0x001F3A24
			// (set) Token: 0x06007CD2 RID: 31954 RVA: 0x001F584C File Offset: 0x001F3A4C
			public unsafe int _nFaceIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.RepeatedVertex.NativeFieldInfoPtr__nFaceIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.RepeatedVertex.NativeFieldInfoPtr__nFaceIndex)) = value;
				}
			}

			// Token: 0x17002CC8 RID: 11464
			// (get) Token: 0x06007CD3 RID: 31955 RVA: 0x001F5870 File Offset: 0x001F3A70
			// (set) Token: 0x06007CD4 RID: 31956 RVA: 0x001F5898 File Offset: 0x001F3A98
			public unsafe int _nOriginalVertexIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.RepeatedVertex.NativeFieldInfoPtr__nOriginalVertexIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.RepeatedVertex.NativeFieldInfoPtr__nOriginalVertexIndex)) = value;
				}
			}

			// Token: 0x04004FDA RID: 20442
			private static readonly IntPtr NativeFieldInfoPtr__nFaceIndex;

			// Token: 0x04004FDB RID: 20443
			private static readonly IntPtr NativeFieldInfoPtr__nOriginalVertexIndex;

			// Token: 0x04004FDC RID: 20444
			private static readonly IntPtr NativeMethodInfoPtr_get_FaceIndex_Public_get_Int32_0;

			// Token: 0x04004FDD RID: 20445
			private static readonly IntPtr NativeMethodInfoPtr_get_OriginalVertexIndex_Public_get_Int32_0;

			// Token: 0x04004FDE RID: 20446
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
		}

		// Token: 0x0200060D RID: 1549
		public class RepeatedVertexList : Il2CppSystem.Object
		{
			// Token: 0x17002CCE RID: 11470
			// (get) Token: 0x06007CD5 RID: 31957 RVA: 0x001F58BC File Offset: 0x001F3ABC
			public unsafe int UniqueIndex
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.RepeatedVertexList.NativeMethodInfoPtr_get_UniqueIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x06007CD6 RID: 31958 RVA: 0x001F590C File Offset: 0x001F3B0C
			[CallerCount(0)]
			public unsafe RepeatedVertexList(int nUniqueIndex, MeshUniqueVertices.RepeatedVertex repeatedVertex) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertexList>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref nUniqueIndex;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(repeatedVertex);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.RepeatedVertexList.NativeMethodInfoPtr__ctor_Public_Void_Int32_RepeatedVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007CD7 RID: 31959 RVA: 0x001F5984 File Offset: 0x001F3B84
			[CallerCount(0)]
			public unsafe void Add(MeshUniqueVertices.RepeatedVertex repeatedVertex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(repeatedVertex);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshUniqueVertices.RepeatedVertexList.NativeMethodInfoPtr_Add_Public_Void_RepeatedVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007CD8 RID: 31960 RVA: 0x001F59E0 File Offset: 0x001F3BE0
			// Note: this type is marked as 'beforefieldinit'.
			static RepeatedVertexList()
			{
				Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertexList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshUniqueVertices>.NativeClassPtr, "RepeatedVertexList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertexList>.NativeClassPtr);
				MeshUniqueVertices.RepeatedVertexList.NativeFieldInfoPtr_m_nUniqueIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertexList>.NativeClassPtr, "m_nUniqueIndex");
				MeshUniqueVertices.RepeatedVertexList.NativeFieldInfoPtr_m_listRepeatedVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertexList>.NativeClassPtr, "m_listRepeatedVertices");
				MeshUniqueVertices.RepeatedVertexList.NativeMethodInfoPtr_get_UniqueIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertexList>.NativeClassPtr, 100673252);
				MeshUniqueVertices.RepeatedVertexList.NativeMethodInfoPtr__ctor_Public_Void_Int32_RepeatedVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertexList>.NativeClassPtr, 100673253);
				MeshUniqueVertices.RepeatedVertexList.NativeMethodInfoPtr_Add_Public_Void_RepeatedVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertexList>.NativeClassPtr, 100673254);
			}

			// Token: 0x06007CD9 RID: 31961 RVA: 0x00002988 File Offset: 0x00000B88
			public RepeatedVertexList(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002CCB RID: 11467
			// (get) Token: 0x06007CDA RID: 31962 RVA: 0x001F5A6F File Offset: 0x001F3C6F
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MeshUniqueVertices.RepeatedVertexList>.NativeClassPtr));
				}
			}

			// Token: 0x17002CCC RID: 11468
			// (get) Token: 0x06007CDB RID: 31963 RVA: 0x001F5A80 File Offset: 0x001F3C80
			// (set) Token: 0x06007CDC RID: 31964 RVA: 0x001F5AA8 File Offset: 0x001F3CA8
			public unsafe int m_nUniqueIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.RepeatedVertexList.NativeFieldInfoPtr_m_nUniqueIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.RepeatedVertexList.NativeFieldInfoPtr_m_nUniqueIndex)) = value;
				}
			}

			// Token: 0x17002CCD RID: 11469
			// (get) Token: 0x06007CDD RID: 31965 RVA: 0x001F5ACC File Offset: 0x001F3CCC
			// (set) Token: 0x06007CDE RID: 31966 RVA: 0x001F5B00 File Offset: 0x001F3D00
			public unsafe List<MeshUniqueVertices.RepeatedVertex> m_listRepeatedVertices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.RepeatedVertexList.NativeFieldInfoPtr_m_listRepeatedVertices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<MeshUniqueVertices.RepeatedVertex>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshUniqueVertices.RepeatedVertexList.NativeFieldInfoPtr_m_listRepeatedVertices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004FDF RID: 20447
			private static readonly IntPtr NativeFieldInfoPtr_m_nUniqueIndex;

			// Token: 0x04004FE0 RID: 20448
			private static readonly IntPtr NativeFieldInfoPtr_m_listRepeatedVertices;

			// Token: 0x04004FE1 RID: 20449
			private static readonly IntPtr NativeMethodInfoPtr_get_UniqueIndex_Public_get_Int32_0;

			// Token: 0x04004FE2 RID: 20450
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_RepeatedVertex_0;

			// Token: 0x04004FE3 RID: 20451
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_RepeatedVertex_0;
		}
	}
}
