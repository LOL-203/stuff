using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005E4 RID: 1508
	public static class MeshGenerator : Il2CppSystem.Object
	{
		// Token: 0x06007A21 RID: 31265 RVA: 0x001EB4B8 File Offset: 0x001E96B8
		[CallerCount(0)]
		public unsafe static float GetAngleOffset(int numSides)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetAngleOffset_Private_Static_Single_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007A22 RID: 31266 RVA: 0x001EB50C File Offset: 0x001E970C
		[CallerCount(0)]
		public unsafe static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneAngle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cap;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_RadiusAndAngle_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
		}

		// Token: 0x06007A23 RID: 31267 RVA: 0x001EB5D8 File Offset: 0x001E97D8
		[CallerCount(0)]
		public unsafe static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cap;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Angle_Public_Static_Mesh_Single_Single_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
		}

		// Token: 0x06007A24 RID: 31268 RVA: 0x001EB690 File Offset: 0x001E9890
		[CallerCount(0)]
		public unsafe static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cap;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radius_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
		}

		// Token: 0x06007A25 RID: 31269 RVA: 0x001EB75C File Offset: 0x001E995C
		[CallerCount(0)]
		public unsafe static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref geomCap;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007A26 RID: 31270 RVA: 0x001EB7E8 File Offset: 0x001E99E8
		[CallerCount(0)]
		public unsafe static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref geomCap;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetIndicesCount_Public_Static_Int32_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x001EB874 File Offset: 0x001E9A74
		[CallerCount(0)]
		public unsafe static int GetSharedMeshVertexCount()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshVertexCount_Public_Static_Int32_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x001EB8B8 File Offset: 0x001E9AB8
		[CallerCount(0)]
		public unsafe static int GetSharedMeshIndicesCount()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshIndicesCount_Public_Static_Int32_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x001EB8FC File Offset: 0x001E9AFC
		// Note: this type is marked as 'beforefieldinit'.
		static MeshGenerator()
		{
			Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MeshGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr);
			MeshGenerator.NativeFieldInfoPtr_kMinTruncatedRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, "kMinTruncatedRadius");
			MeshGenerator.NativeMethodInfoPtr_GetAngleOffset_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100673039);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_RadiusAndAngle_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100673040);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Angle_Public_Static_Mesh_Single_Single_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100673041);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radius_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100673042);
			MeshGenerator.NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100673043);
			MeshGenerator.NativeMethodInfoPtr_GetIndicesCount_Public_Static_Int32_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100673044);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshVertexCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100673045);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshIndicesCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100673046);
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x00002988 File Offset: 0x00000B88
		public MeshGenerator(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x06007A2B RID: 31275 RVA: 0x001EB9E0 File Offset: 0x001E9BE0
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr));
			}
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x06007A2C RID: 31276 RVA: 0x001EB9F4 File Offset: 0x001E9BF4
		// (set) Token: 0x06007A2D RID: 31277 RVA: 0x001EBA12 File Offset: 0x001E9C12
		public unsafe static float kMinTruncatedRadius
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MeshGenerator.NativeFieldInfoPtr_kMinTruncatedRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshGenerator.NativeFieldInfoPtr_kMinTruncatedRadius, (void*)(&value));
			}
		}

		// Token: 0x04004E3F RID: 20031
		private static readonly IntPtr NativeFieldInfoPtr_kMinTruncatedRadius;

		// Token: 0x04004E40 RID: 20032
		private static readonly IntPtr NativeMethodInfoPtr_GetAngleOffset_Private_Static_Single_Int32_0;

		// Token: 0x04004E41 RID: 20033
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_RadiusAndAngle_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04004E42 RID: 20034
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_Angle_Public_Static_Mesh_Single_Single_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04004E43 RID: 20035
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_Radius_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04004E44 RID: 20036
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04004E45 RID: 20037
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesCount_Public_Static_Int32_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04004E46 RID: 20038
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshVertexCount_Public_Static_Int32_0;

		// Token: 0x04004E47 RID: 20039
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshIndicesCount_Public_Static_Int32_0;
	}
}
