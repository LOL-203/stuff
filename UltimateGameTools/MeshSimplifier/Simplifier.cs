using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace UltimateGameTools.MeshSimplifier
{
	// Token: 0x0200060F RID: 1551
	public class Simplifier : MonoBehaviour
	{
		// Token: 0x17002CE7 RID: 11495
		// (get) Token: 0x06007CEE RID: 31982 RVA: 0x001F5E2C File Offset: 0x001F402C
		// (set) Token: 0x06007CEF RID: 31983 RVA: 0x001F5E70 File Offset: 0x001F4070
		public unsafe static bool Cancelled
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_get_Cancelled_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_set_Cancelled_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002CE8 RID: 11496
		// (get) Token: 0x06007CF0 RID: 31984 RVA: 0x001F5EB8 File Offset: 0x001F40B8
		// (set) Token: 0x06007CF1 RID: 31985 RVA: 0x001F5EFC File Offset: 0x001F40FC
		public unsafe static int CoroutineFrameMiliseconds
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_get_CoroutineFrameMiliseconds_Public_Static_get_Int32_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_set_CoroutineFrameMiliseconds_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002CE9 RID: 11497
		// (get) Token: 0x06007CF2 RID: 31986 RVA: 0x001F5F44 File Offset: 0x001F4144
		// (set) Token: 0x06007CF3 RID: 31987 RVA: 0x001F5F94 File Offset: 0x001F4194
		public unsafe bool CoroutineEnded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_get_CoroutineEnded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_set_CoroutineEnded_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002CEA RID: 11498
		// (get) Token: 0x06007CF4 RID: 31988 RVA: 0x001F5FE8 File Offset: 0x001F41E8
		// (set) Token: 0x06007CF5 RID: 31989 RVA: 0x001F6038 File Offset: 0x001F4238
		public unsafe bool UseEdgeLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_get_UseEdgeLength_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_set_UseEdgeLength_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002CEB RID: 11499
		// (get) Token: 0x06007CF6 RID: 31990 RVA: 0x001F608C File Offset: 0x001F428C
		// (set) Token: 0x06007CF7 RID: 31991 RVA: 0x001F60DC File Offset: 0x001F42DC
		public unsafe bool UseCurvature
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_get_UseCurvature_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_set_UseCurvature_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002CEC RID: 11500
		// (get) Token: 0x06007CF8 RID: 31992 RVA: 0x001F6130 File Offset: 0x001F4330
		// (set) Token: 0x06007CF9 RID: 31993 RVA: 0x001F6180 File Offset: 0x001F4380
		public unsafe bool ProtectTexture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_get_ProtectTexture_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_set_ProtectTexture_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002CED RID: 11501
		// (get) Token: 0x06007CFA RID: 31994 RVA: 0x001F61D4 File Offset: 0x001F43D4
		// (set) Token: 0x06007CFB RID: 31995 RVA: 0x001F6224 File Offset: 0x001F4424
		public unsafe bool LockBorder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_get_LockBorder_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_set_LockBorder_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007CFC RID: 31996 RVA: 0x001F6278 File Offset: 0x001F4478
		[CallerCount(0)]
		public unsafe IEnumerator ProgressiveMesh(GameObject gameObject, Mesh sourceMesh, Il2CppReferenceArray<RelevanceSphere> aRelevanceSpheres, string strProgressDisplayObjectName = "", [Optional] Simplifier.ProgressDelegate progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceMesh);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aRelevanceSpheres);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strProgressDisplayObjectName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(progress);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_ProgressiveMesh_Public_IEnumerator_GameObject_Mesh_ArrayOf_RelevanceSphere_String_ProgressDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
		}

		// Token: 0x06007CFD RID: 31997 RVA: 0x001F6348 File Offset: 0x001F4548
		[CallerCount(0)]
		public unsafe IEnumerator ComputeMeshWithVertexCount(GameObject gameObject, Mesh meshOut, int nVertices, string strProgressDisplayObjectName = "", [Optional] Simplifier.ProgressDelegate progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshOut);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nVertices;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strProgressDisplayObjectName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(progress);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_ComputeMeshWithVertexCount_Public_IEnumerator_GameObject_Mesh_Int32_String_ProgressDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
		}

		// Token: 0x06007CFE RID: 31998 RVA: 0x001F6410 File Offset: 0x001F4610
		[CallerCount(0)]
		public unsafe int GetOriginalMeshUniqueVertexCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_GetOriginalMeshUniqueVertexCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007CFF RID: 31999 RVA: 0x001F6460 File Offset: 0x001F4660
		[CallerCount(0)]
		public unsafe int GetOriginalMeshTriangleCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_GetOriginalMeshTriangleCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007D00 RID: 32000 RVA: 0x001F64B0 File Offset: 0x001F46B0
		[CallerCount(0)]
		public unsafe static Il2CppStructArray<Vector3> GetWorldVertices(GameObject gameObject)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_GetWorldVertices_Public_Static_ArrayOf_Vector3_GameObject_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Il2CppStructArray<Vector3>(intPtr2) : null;
		}

		// Token: 0x06007D01 RID: 32001 RVA: 0x001F6510 File Offset: 0x001F4710
		[CallerCount(0)]
		public unsafe IEnumerator ConsolidateMesh(GameObject gameObject, Mesh meshIn, Mesh meshOut, Il2CppReferenceArray<Simplifier.TriangleList> aListTriangles, Il2CppStructArray<Vector3> av3Vertices, string strProgressDisplayObjectName = "", [Optional] Simplifier.ProgressDelegate progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshIn);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshOut);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aListTriangles);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(av3Vertices);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strProgressDisplayObjectName);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(progress);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_ConsolidateMesh_Private_IEnumerator_GameObject_Mesh_Mesh_ArrayOf_TriangleList_ArrayOf_Vector3_String_ProgressDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
		}

		// Token: 0x06007D02 RID: 32002 RVA: 0x001F6610 File Offset: 0x001F4810
		[CallerCount(0)]
		public unsafe int MapVertex(int nVertex, int nMax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nVertex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMax;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_MapVertex_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007D03 RID: 32003 RVA: 0x001F6688 File Offset: 0x001F4888
		[CallerCount(0)]
		public unsafe float ComputeEdgeCollapseCost(Simplifier.Vertex u, Simplifier.Vertex v, float fRelevanceBias)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(u);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fRelevanceBias;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_ComputeEdgeCollapseCost_Private_Single_Vertex_Vertex_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007D04 RID: 32004 RVA: 0x001F671C File Offset: 0x001F491C
		[CallerCount(0)]
		public unsafe void ComputeEdgeCostAtVertex(Simplifier.Vertex v, Transform transform, Il2CppReferenceArray<RelevanceSphere> aRelevanceSpheres)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aRelevanceSpheres);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_ComputeEdgeCostAtVertex_Private_Void_Vertex_Transform_ArrayOf_RelevanceSphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D05 RID: 32005 RVA: 0x001F67A8 File Offset: 0x001F49A8
		[CallerCount(0)]
		public unsafe IEnumerator ComputeAllEdgeCollapseCosts(string strProgressDisplayObjectName, Transform transform, Il2CppReferenceArray<RelevanceSphere> aRelevanceSpheres, [Optional] Simplifier.ProgressDelegate progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(strProgressDisplayObjectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aRelevanceSpheres);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(progress);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_ComputeAllEdgeCollapseCosts_Private_IEnumerator_String_Transform_ArrayOf_RelevanceSphere_ProgressDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
		}

		// Token: 0x06007D06 RID: 32006 RVA: 0x001F6860 File Offset: 0x001F4A60
		[CallerCount(0)]
		public unsafe void Collapse(Simplifier.Vertex u, Simplifier.Vertex v, bool bRecompute, Transform transform, Il2CppReferenceArray<RelevanceSphere> aRelevanceSpheres)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(u);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecompute;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(aRelevanceSpheres);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_Collapse_Private_Void_Vertex_Vertex_Boolean_Transform_ArrayOf_RelevanceSphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D07 RID: 32007 RVA: 0x001F6914 File Offset: 0x001F4B14
		[CallerCount(0)]
		public unsafe void AddVertices(List<Vector3> listVertices, List<Vector3> listVerticesWorld, List<MeshUniqueVertices.SerializableBoneWeight> listBoneWeights)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listVertices);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listVerticesWorld);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listBoneWeights);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_AddVertices_Private_Void_List_1_Vector3_List_1_Vector3_List_1_SerializableBoneWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D08 RID: 32008 RVA: 0x001F69A0 File Offset: 0x001F4BA0
		[CallerCount(0)]
		public unsafe void AddFaceListSubMesh(int nSubMesh, List<int> listTriangles, Il2CppStructArray<int> anIndices, Il2CppStructArray<Vector2> v2Mapping)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nSubMesh;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listTriangles);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(anIndices);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2Mapping);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_AddFaceListSubMesh_Private_Void_Int32_List_1_Int32_ArrayOf_Int32_ArrayOf_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D09 RID: 32009 RVA: 0x001F6A3C File Offset: 0x001F4C3C
		[CallerCount(0)]
		public unsafe void ShareUV(Il2CppStructArray<Vector2> aMapping, Simplifier.Triangle t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(aMapping);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_ShareUV_Private_Void_ArrayOf_Vector2_Triangle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D0A RID: 32010 RVA: 0x001F6AB0 File Offset: 0x001F4CB0
		[CallerCount(0)]
		public unsafe Simplifier.Vertex MinimumCostEdge()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_MinimumCostEdge_Private_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Simplifier.Vertex(intPtr2) : null;
		}

		// Token: 0x06007D0B RID: 32011 RVA: 0x001F6B08 File Offset: 0x001F4D08
		[CallerCount(0)]
		public unsafe float HeapValue(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref i;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_HeapValue_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007D0C RID: 32012 RVA: 0x001F6B6C File Offset: 0x001F4D6C
		[CallerCount(0)]
		public unsafe void HeapSortUp(int k)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref k;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_HeapSortUp_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D0D RID: 32013 RVA: 0x001F6BC0 File Offset: 0x001F4DC0
		[CallerCount(0)]
		public unsafe void HeapSortDown(int k)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref k;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_HeapSortDown_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D0E RID: 32014 RVA: 0x001F6C14 File Offset: 0x001F4E14
		[CallerCount(0)]
		public unsafe void HeapAdd(Simplifier.Vertex v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_HeapAdd_Private_Void_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D0F RID: 32015 RVA: 0x001F6C70 File Offset: 0x001F4E70
		[CallerCount(0)]
		public unsafe Simplifier.Vertex HeapPop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr_HeapPop_Private_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Simplifier.Vertex(intPtr2) : null;
		}

		// Token: 0x06007D10 RID: 32016 RVA: 0x001F6CC8 File Offset: 0x001F4EC8
		[CallerCount(0)]
		public unsafe Simplifier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Simplifier>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D11 RID: 32017 RVA: 0x001F6D14 File Offset: 0x001F4F14
		// Note: this type is marked as 'beforefieldinit'.
		static Simplifier()
		{
			Il2CppClassPointerStore<Simplifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UltimateGameTools.MeshSimplifier", "Simplifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Simplifier>.NativeClassPtr);
			Simplifier.NativeFieldInfoPtr__Cancelled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "<Cancelled>k__BackingField");
			Simplifier.NativeFieldInfoPtr__CoroutineEnded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "<CoroutineEnded>k__BackingField");
			Simplifier.NativeFieldInfoPtr_m_nCoroutineFrameMiliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_nCoroutineFrameMiliseconds");
			Simplifier.NativeFieldInfoPtr_MAX_VERTEX_COLLAPSE_COST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "MAX_VERTEX_COLLAPSE_COST");
			Simplifier.NativeFieldInfoPtr_m_listVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_listVertices");
			Simplifier.NativeFieldInfoPtr_m_listHeap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_listHeap");
			Simplifier.NativeFieldInfoPtr_m_aListTriangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_aListTriangles");
			Simplifier.NativeFieldInfoPtr_m_nOriginalMeshVertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_nOriginalMeshVertexCount");
			Simplifier.NativeFieldInfoPtr_m_fOriginalMeshSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_fOriginalMeshSize");
			Simplifier.NativeFieldInfoPtr_m_listVertexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_listVertexMap");
			Simplifier.NativeFieldInfoPtr_m_listVertexPermutationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_listVertexPermutationBack");
			Simplifier.NativeFieldInfoPtr_m_meshUniqueVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_meshUniqueVertices");
			Simplifier.NativeFieldInfoPtr_m_meshOriginal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_meshOriginal");
			Simplifier.NativeFieldInfoPtr_m_bUseEdgeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_bUseEdgeLength");
			Simplifier.NativeFieldInfoPtr_m_bUseCurvature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_bUseCurvature");
			Simplifier.NativeFieldInfoPtr_m_bProtectTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_bProtectTexture");
			Simplifier.NativeFieldInfoPtr_m_bLockBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "m_bLockBorder");
			Simplifier.NativeMethodInfoPtr_get_Cancelled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673257);
			Simplifier.NativeMethodInfoPtr_set_Cancelled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673258);
			Simplifier.NativeMethodInfoPtr_get_CoroutineFrameMiliseconds_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673259);
			Simplifier.NativeMethodInfoPtr_set_CoroutineFrameMiliseconds_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673260);
			Simplifier.NativeMethodInfoPtr_get_CoroutineEnded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673261);
			Simplifier.NativeMethodInfoPtr_set_CoroutineEnded_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673262);
			Simplifier.NativeMethodInfoPtr_get_UseEdgeLength_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673263);
			Simplifier.NativeMethodInfoPtr_set_UseEdgeLength_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673264);
			Simplifier.NativeMethodInfoPtr_get_UseCurvature_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673265);
			Simplifier.NativeMethodInfoPtr_set_UseCurvature_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673266);
			Simplifier.NativeMethodInfoPtr_get_ProtectTexture_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673267);
			Simplifier.NativeMethodInfoPtr_set_ProtectTexture_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673268);
			Simplifier.NativeMethodInfoPtr_get_LockBorder_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673269);
			Simplifier.NativeMethodInfoPtr_set_LockBorder_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673270);
			Simplifier.NativeMethodInfoPtr_ProgressiveMesh_Public_IEnumerator_GameObject_Mesh_ArrayOf_RelevanceSphere_String_ProgressDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673271);
			Simplifier.NativeMethodInfoPtr_ComputeMeshWithVertexCount_Public_IEnumerator_GameObject_Mesh_Int32_String_ProgressDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673272);
			Simplifier.NativeMethodInfoPtr_GetOriginalMeshUniqueVertexCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673273);
			Simplifier.NativeMethodInfoPtr_GetOriginalMeshTriangleCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673274);
			Simplifier.NativeMethodInfoPtr_GetWorldVertices_Public_Static_ArrayOf_Vector3_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673275);
			Simplifier.NativeMethodInfoPtr_ConsolidateMesh_Private_IEnumerator_GameObject_Mesh_Mesh_ArrayOf_TriangleList_ArrayOf_Vector3_String_ProgressDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673276);
			Simplifier.NativeMethodInfoPtr_MapVertex_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673277);
			Simplifier.NativeMethodInfoPtr_ComputeEdgeCollapseCost_Private_Single_Vertex_Vertex_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673278);
			Simplifier.NativeMethodInfoPtr_ComputeEdgeCostAtVertex_Private_Void_Vertex_Transform_ArrayOf_RelevanceSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673279);
			Simplifier.NativeMethodInfoPtr_ComputeAllEdgeCollapseCosts_Private_IEnumerator_String_Transform_ArrayOf_RelevanceSphere_ProgressDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673280);
			Simplifier.NativeMethodInfoPtr_Collapse_Private_Void_Vertex_Vertex_Boolean_Transform_ArrayOf_RelevanceSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673281);
			Simplifier.NativeMethodInfoPtr_AddVertices_Private_Void_List_1_Vector3_List_1_Vector3_List_1_SerializableBoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673282);
			Simplifier.NativeMethodInfoPtr_AddFaceListSubMesh_Private_Void_Int32_List_1_Int32_ArrayOf_Int32_ArrayOf_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673283);
			Simplifier.NativeMethodInfoPtr_ShareUV_Private_Void_ArrayOf_Vector2_Triangle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673284);
			Simplifier.NativeMethodInfoPtr_MinimumCostEdge_Private_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673285);
			Simplifier.NativeMethodInfoPtr_HeapValue_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673286);
			Simplifier.NativeMethodInfoPtr_HeapSortUp_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673287);
			Simplifier.NativeMethodInfoPtr_HeapSortDown_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673288);
			Simplifier.NativeMethodInfoPtr_HeapAdd_Private_Void_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673289);
			Simplifier.NativeMethodInfoPtr_HeapPop_Private_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673290);
			Simplifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, 100673291);
		}

		// Token: 0x06007D12 RID: 32018 RVA: 0x0000210C File Offset: 0x0000030C
		public Simplifier(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002CD5 RID: 11477
		// (get) Token: 0x06007D13 RID: 32019 RVA: 0x001F7154 File Offset: 0x001F5354
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Simplifier>.NativeClassPtr));
			}
		}

		// Token: 0x17002CD6 RID: 11478
		// (get) Token: 0x06007D14 RID: 32020 RVA: 0x001F7168 File Offset: 0x001F5368
		// (set) Token: 0x06007D15 RID: 32021 RVA: 0x001F7186 File Offset: 0x001F5386
		public unsafe static bool _Cancelled_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Simplifier.NativeFieldInfoPtr__Cancelled_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Simplifier.NativeFieldInfoPtr__Cancelled_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17002CD7 RID: 11479
		// (get) Token: 0x06007D16 RID: 32022 RVA: 0x001F7198 File Offset: 0x001F5398
		// (set) Token: 0x06007D17 RID: 32023 RVA: 0x001F71C0 File Offset: 0x001F53C0
		public unsafe bool _CoroutineEnded_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr__CoroutineEnded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr__CoroutineEnded_k__BackingField)) = value;
			}
		}

		// Token: 0x17002CD8 RID: 11480
		// (get) Token: 0x06007D18 RID: 32024 RVA: 0x001F71E4 File Offset: 0x001F53E4
		// (set) Token: 0x06007D19 RID: 32025 RVA: 0x001F7202 File Offset: 0x001F5402
		public unsafe static int m_nCoroutineFrameMiliseconds
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Simplifier.NativeFieldInfoPtr_m_nCoroutineFrameMiliseconds, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Simplifier.NativeFieldInfoPtr_m_nCoroutineFrameMiliseconds, (void*)(&value));
			}
		}

		// Token: 0x17002CD9 RID: 11481
		// (get) Token: 0x06007D1A RID: 32026 RVA: 0x001F7214 File Offset: 0x001F5414
		// (set) Token: 0x06007D1B RID: 32027 RVA: 0x001F7232 File Offset: 0x001F5432
		public unsafe static float MAX_VERTEX_COLLAPSE_COST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Simplifier.NativeFieldInfoPtr_MAX_VERTEX_COLLAPSE_COST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Simplifier.NativeFieldInfoPtr_MAX_VERTEX_COLLAPSE_COST, (void*)(&value));
			}
		}

		// Token: 0x17002CDA RID: 11482
		// (get) Token: 0x06007D1C RID: 32028 RVA: 0x001F7244 File Offset: 0x001F5444
		// (set) Token: 0x06007D1D RID: 32029 RVA: 0x001F7278 File Offset: 0x001F5478
		public unsafe List<Simplifier.Vertex> m_listVertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_listVertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<Simplifier.Vertex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_listVertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CDB RID: 11483
		// (get) Token: 0x06007D1E RID: 32030 RVA: 0x001F72A0 File Offset: 0x001F54A0
		// (set) Token: 0x06007D1F RID: 32031 RVA: 0x001F72D4 File Offset: 0x001F54D4
		public unsafe List<Simplifier.Vertex> m_listHeap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_listHeap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<Simplifier.Vertex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_listHeap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CDC RID: 11484
		// (get) Token: 0x06007D20 RID: 32032 RVA: 0x001F72FC File Offset: 0x001F54FC
		// (set) Token: 0x06007D21 RID: 32033 RVA: 0x001F7330 File Offset: 0x001F5530
		public unsafe Il2CppReferenceArray<Simplifier.TriangleList> m_aListTriangles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_aListTriangles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<Simplifier.TriangleList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_aListTriangles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CDD RID: 11485
		// (get) Token: 0x06007D22 RID: 32034 RVA: 0x001F7358 File Offset: 0x001F5558
		// (set) Token: 0x06007D23 RID: 32035 RVA: 0x001F7380 File Offset: 0x001F5580
		public unsafe int m_nOriginalMeshVertexCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_nOriginalMeshVertexCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_nOriginalMeshVertexCount)) = value;
			}
		}

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x06007D24 RID: 32036 RVA: 0x001F73A4 File Offset: 0x001F55A4
		// (set) Token: 0x06007D25 RID: 32037 RVA: 0x001F73CC File Offset: 0x001F55CC
		public unsafe float m_fOriginalMeshSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_fOriginalMeshSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_fOriginalMeshSize)) = value;
			}
		}

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x06007D26 RID: 32038 RVA: 0x001F73F0 File Offset: 0x001F55F0
		// (set) Token: 0x06007D27 RID: 32039 RVA: 0x001F7424 File Offset: 0x001F5624
		public unsafe List<int> m_listVertexMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_listVertexMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_listVertexMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x06007D28 RID: 32040 RVA: 0x001F744C File Offset: 0x001F564C
		// (set) Token: 0x06007D29 RID: 32041 RVA: 0x001F7480 File Offset: 0x001F5680
		public unsafe List<int> m_listVertexPermutationBack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_listVertexPermutationBack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_listVertexPermutationBack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE1 RID: 11489
		// (get) Token: 0x06007D2A RID: 32042 RVA: 0x001F74A8 File Offset: 0x001F56A8
		// (set) Token: 0x06007D2B RID: 32043 RVA: 0x001F74DC File Offset: 0x001F56DC
		public unsafe MeshUniqueVertices m_meshUniqueVertices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_meshUniqueVertices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new MeshUniqueVertices(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_meshUniqueVertices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE2 RID: 11490
		// (get) Token: 0x06007D2C RID: 32044 RVA: 0x001F7504 File Offset: 0x001F5704
		// (set) Token: 0x06007D2D RID: 32045 RVA: 0x001F7538 File Offset: 0x001F5738
		public unsafe Mesh m_meshOriginal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_meshOriginal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_meshOriginal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE3 RID: 11491
		// (get) Token: 0x06007D2E RID: 32046 RVA: 0x001F7560 File Offset: 0x001F5760
		// (set) Token: 0x06007D2F RID: 32047 RVA: 0x001F7588 File Offset: 0x001F5788
		public unsafe bool m_bUseEdgeLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_bUseEdgeLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_bUseEdgeLength)) = value;
			}
		}

		// Token: 0x17002CE4 RID: 11492
		// (get) Token: 0x06007D30 RID: 32048 RVA: 0x001F75AC File Offset: 0x001F57AC
		// (set) Token: 0x06007D31 RID: 32049 RVA: 0x001F75D4 File Offset: 0x001F57D4
		public unsafe bool m_bUseCurvature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_bUseCurvature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_bUseCurvature)) = value;
			}
		}

		// Token: 0x17002CE5 RID: 11493
		// (get) Token: 0x06007D32 RID: 32050 RVA: 0x001F75F8 File Offset: 0x001F57F8
		// (set) Token: 0x06007D33 RID: 32051 RVA: 0x001F7620 File Offset: 0x001F5820
		public unsafe bool m_bProtectTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_bProtectTexture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_bProtectTexture)) = value;
			}
		}

		// Token: 0x17002CE6 RID: 11494
		// (get) Token: 0x06007D34 RID: 32052 RVA: 0x001F7644 File Offset: 0x001F5844
		// (set) Token: 0x06007D35 RID: 32053 RVA: 0x001F766C File Offset: 0x001F586C
		public unsafe bool m_bLockBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_bLockBorder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.NativeFieldInfoPtr_m_bLockBorder)) = value;
			}
		}

		// Token: 0x04004FEB RID: 20459
		private static readonly IntPtr NativeFieldInfoPtr__Cancelled_k__BackingField;

		// Token: 0x04004FEC RID: 20460
		private static readonly IntPtr NativeFieldInfoPtr__CoroutineEnded_k__BackingField;

		// Token: 0x04004FED RID: 20461
		private static readonly IntPtr NativeFieldInfoPtr_m_nCoroutineFrameMiliseconds;

		// Token: 0x04004FEE RID: 20462
		private static readonly IntPtr NativeFieldInfoPtr_MAX_VERTEX_COLLAPSE_COST;

		// Token: 0x04004FEF RID: 20463
		private static readonly IntPtr NativeFieldInfoPtr_m_listVertices;

		// Token: 0x04004FF0 RID: 20464
		private static readonly IntPtr NativeFieldInfoPtr_m_listHeap;

		// Token: 0x04004FF1 RID: 20465
		private static readonly IntPtr NativeFieldInfoPtr_m_aListTriangles;

		// Token: 0x04004FF2 RID: 20466
		private static readonly IntPtr NativeFieldInfoPtr_m_nOriginalMeshVertexCount;

		// Token: 0x04004FF3 RID: 20467
		private static readonly IntPtr NativeFieldInfoPtr_m_fOriginalMeshSize;

		// Token: 0x04004FF4 RID: 20468
		private static readonly IntPtr NativeFieldInfoPtr_m_listVertexMap;

		// Token: 0x04004FF5 RID: 20469
		private static readonly IntPtr NativeFieldInfoPtr_m_listVertexPermutationBack;

		// Token: 0x04004FF6 RID: 20470
		private static readonly IntPtr NativeFieldInfoPtr_m_meshUniqueVertices;

		// Token: 0x04004FF7 RID: 20471
		private static readonly IntPtr NativeFieldInfoPtr_m_meshOriginal;

		// Token: 0x04004FF8 RID: 20472
		private static readonly IntPtr NativeFieldInfoPtr_m_bUseEdgeLength;

		// Token: 0x04004FF9 RID: 20473
		private static readonly IntPtr NativeFieldInfoPtr_m_bUseCurvature;

		// Token: 0x04004FFA RID: 20474
		private static readonly IntPtr NativeFieldInfoPtr_m_bProtectTexture;

		// Token: 0x04004FFB RID: 20475
		private static readonly IntPtr NativeFieldInfoPtr_m_bLockBorder;

		// Token: 0x04004FFC RID: 20476
		private static readonly IntPtr NativeMethodInfoPtr_get_Cancelled_Public_Static_get_Boolean_0;

		// Token: 0x04004FFD RID: 20477
		private static readonly IntPtr NativeMethodInfoPtr_set_Cancelled_Public_Static_set_Void_Boolean_0;

		// Token: 0x04004FFE RID: 20478
		private static readonly IntPtr NativeMethodInfoPtr_get_CoroutineFrameMiliseconds_Public_Static_get_Int32_0;

		// Token: 0x04004FFF RID: 20479
		private static readonly IntPtr NativeMethodInfoPtr_set_CoroutineFrameMiliseconds_Public_Static_set_Void_Int32_0;

		// Token: 0x04005000 RID: 20480
		private static readonly IntPtr NativeMethodInfoPtr_get_CoroutineEnded_Public_get_Boolean_0;

		// Token: 0x04005001 RID: 20481
		private static readonly IntPtr NativeMethodInfoPtr_set_CoroutineEnded_Public_set_Void_Boolean_0;

		// Token: 0x04005002 RID: 20482
		private static readonly IntPtr NativeMethodInfoPtr_get_UseEdgeLength_Public_get_Boolean_0;

		// Token: 0x04005003 RID: 20483
		private static readonly IntPtr NativeMethodInfoPtr_set_UseEdgeLength_Public_set_Void_Boolean_0;

		// Token: 0x04005004 RID: 20484
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCurvature_Public_get_Boolean_0;

		// Token: 0x04005005 RID: 20485
		private static readonly IntPtr NativeMethodInfoPtr_set_UseCurvature_Public_set_Void_Boolean_0;

		// Token: 0x04005006 RID: 20486
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtectTexture_Public_get_Boolean_0;

		// Token: 0x04005007 RID: 20487
		private static readonly IntPtr NativeMethodInfoPtr_set_ProtectTexture_Public_set_Void_Boolean_0;

		// Token: 0x04005008 RID: 20488
		private static readonly IntPtr NativeMethodInfoPtr_get_LockBorder_Public_get_Boolean_0;

		// Token: 0x04005009 RID: 20489
		private static readonly IntPtr NativeMethodInfoPtr_set_LockBorder_Public_set_Void_Boolean_0;

		// Token: 0x0400500A RID: 20490
		private static readonly IntPtr NativeMethodInfoPtr_ProgressiveMesh_Public_IEnumerator_GameObject_Mesh_ArrayOf_RelevanceSphere_String_ProgressDelegate_0;

		// Token: 0x0400500B RID: 20491
		private static readonly IntPtr NativeMethodInfoPtr_ComputeMeshWithVertexCount_Public_IEnumerator_GameObject_Mesh_Int32_String_ProgressDelegate_0;

		// Token: 0x0400500C RID: 20492
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginalMeshUniqueVertexCount_Public_Int32_0;

		// Token: 0x0400500D RID: 20493
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginalMeshTriangleCount_Public_Int32_0;

		// Token: 0x0400500E RID: 20494
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldVertices_Public_Static_ArrayOf_Vector3_GameObject_0;

		// Token: 0x0400500F RID: 20495
		private static readonly IntPtr NativeMethodInfoPtr_ConsolidateMesh_Private_IEnumerator_GameObject_Mesh_Mesh_ArrayOf_TriangleList_ArrayOf_Vector3_String_ProgressDelegate_0;

		// Token: 0x04005010 RID: 20496
		private static readonly IntPtr NativeMethodInfoPtr_MapVertex_Private_Int32_Int32_Int32_0;

		// Token: 0x04005011 RID: 20497
		private static readonly IntPtr NativeMethodInfoPtr_ComputeEdgeCollapseCost_Private_Single_Vertex_Vertex_Single_0;

		// Token: 0x04005012 RID: 20498
		private static readonly IntPtr NativeMethodInfoPtr_ComputeEdgeCostAtVertex_Private_Void_Vertex_Transform_ArrayOf_RelevanceSphere_0;

		// Token: 0x04005013 RID: 20499
		private static readonly IntPtr NativeMethodInfoPtr_ComputeAllEdgeCollapseCosts_Private_IEnumerator_String_Transform_ArrayOf_RelevanceSphere_ProgressDelegate_0;

		// Token: 0x04005014 RID: 20500
		private static readonly IntPtr NativeMethodInfoPtr_Collapse_Private_Void_Vertex_Vertex_Boolean_Transform_ArrayOf_RelevanceSphere_0;

		// Token: 0x04005015 RID: 20501
		private static readonly IntPtr NativeMethodInfoPtr_AddVertices_Private_Void_List_1_Vector3_List_1_Vector3_List_1_SerializableBoneWeight_0;

		// Token: 0x04005016 RID: 20502
		private static readonly IntPtr NativeMethodInfoPtr_AddFaceListSubMesh_Private_Void_Int32_List_1_Int32_ArrayOf_Int32_ArrayOf_Vector2_0;

		// Token: 0x04005017 RID: 20503
		private static readonly IntPtr NativeMethodInfoPtr_ShareUV_Private_Void_ArrayOf_Vector2_Triangle_0;

		// Token: 0x04005018 RID: 20504
		private static readonly IntPtr NativeMethodInfoPtr_MinimumCostEdge_Private_Vertex_0;

		// Token: 0x04005019 RID: 20505
		private static readonly IntPtr NativeMethodInfoPtr_HeapValue_Private_Single_Int32_0;

		// Token: 0x0400501A RID: 20506
		private static readonly IntPtr NativeMethodInfoPtr_HeapSortUp_Private_Void_Int32_0;

		// Token: 0x0400501B RID: 20507
		private static readonly IntPtr NativeMethodInfoPtr_HeapSortDown_Private_Void_Int32_0;

		// Token: 0x0400501C RID: 20508
		private static readonly IntPtr NativeMethodInfoPtr_HeapAdd_Private_Void_Vertex_0;

		// Token: 0x0400501D RID: 20509
		private static readonly IntPtr NativeMethodInfoPtr_HeapPop_Private_Vertex_0;

		// Token: 0x0400501E RID: 20510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000610 RID: 1552
		public sealed class ProgressDelegate : MulticastDelegate
		{
			// Token: 0x06007D36 RID: 32054 RVA: 0x001F7690 File Offset: 0x001F5890
			[CallerCount(0)]
			public unsafe ProgressDelegate(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Simplifier.ProgressDelegate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.ProgressDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D37 RID: 32055 RVA: 0x001F7708 File Offset: 0x001F5908
			[CallerCount(0)]
			public unsafe void Invoke(string strTitle, string strProgressMessage, float fT)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strTitle);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strProgressMessage);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fT;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.ProgressDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D38 RID: 32056 RVA: 0x001F778C File Offset: 0x001F598C
			[CallerCount(0)]
			public unsafe IAsyncResult BeginInvoke(string strTitle, string strProgressMessage, float fT, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strTitle);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strProgressMessage);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fT;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.ProgressDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
			}

			// Token: 0x06007D39 RID: 32057 RVA: 0x001F7854 File Offset: 0x001F5A54
			[CallerCount(0)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.ProgressDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D3A RID: 32058 RVA: 0x001F78B0 File Offset: 0x001F5AB0
			// Note: this type is marked as 'beforefieldinit'.
			static ProgressDelegate()
			{
				Il2CppClassPointerStore<Simplifier.ProgressDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "ProgressDelegate");
				Simplifier.ProgressDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.ProgressDelegate>.NativeClassPtr, 100673292);
				Simplifier.ProgressDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.ProgressDelegate>.NativeClassPtr, 100673293);
				Simplifier.ProgressDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.ProgressDelegate>.NativeClassPtr, 100673294);
				Simplifier.ProgressDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.ProgressDelegate>.NativeClassPtr, 100673295);
			}

			// Token: 0x06007D3B RID: 32059 RVA: 0x00005E35 File Offset: 0x00004035
			public ProgressDelegate(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002CEE RID: 11502
			// (get) Token: 0x06007D3C RID: 32060 RVA: 0x001F7921 File Offset: 0x001F5B21
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Simplifier.ProgressDelegate>.NativeClassPtr));
				}
			}

			// Token: 0x06007D3D RID: 32061 RVA: 0x001F7932 File Offset: 0x001F5B32
			public static implicit operator Simplifier.ProgressDelegate(Action<string, string, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<Simplifier.ProgressDelegate>(A_0);
			}

			// Token: 0x06007D3E RID: 32062 RVA: 0x001F793A File Offset: 0x001F5B3A
			public static Simplifier.ProgressDelegate operator +(Simplifier.ProgressDelegate A_0, Simplifier.ProgressDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Simplifier.ProgressDelegate>();
			}

			// Token: 0x06007D3F RID: 32063 RVA: 0x001F7948 File Offset: 0x001F5B48
			public static Simplifier.ProgressDelegate operator -(Simplifier.ProgressDelegate A_0, Simplifier.ProgressDelegate A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Simplifier.ProgressDelegate>();
				}
				return result;
			}

			// Token: 0x0400501F RID: 20511
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04005020 RID: 20512
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_Single_0;

			// Token: 0x04005021 RID: 20513
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_Single_AsyncCallback_Object_0;

			// Token: 0x04005022 RID: 20514
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000611 RID: 1553
		public class Triangle : Il2CppSystem.Object
		{
			// Token: 0x17002CF6 RID: 11510
			// (get) Token: 0x06007D40 RID: 32064 RVA: 0x001F795C File Offset: 0x001F5B5C
			public unsafe Il2CppReferenceArray<Simplifier.Vertex> Vertices
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr_get_Vertices_Public_get_ArrayOf_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppReferenceArray<Simplifier.Vertex>(intPtr2) : null;
				}
			}

			// Token: 0x17002CF7 RID: 11511
			// (get) Token: 0x06007D41 RID: 32065 RVA: 0x001F79B4 File Offset: 0x001F5BB4
			public unsafe bool HasUVData
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr_get_HasUVData_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x17002CF8 RID: 11512
			// (get) Token: 0x06007D42 RID: 32066 RVA: 0x001F7A04 File Offset: 0x001F5C04
			public unsafe Il2CppStructArray<int> IndicesUV
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr_get_IndicesUV_Public_get_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<int>(intPtr2) : null;
				}
			}

			// Token: 0x17002CF9 RID: 11513
			// (get) Token: 0x06007D43 RID: 32067 RVA: 0x001F7A5C File Offset: 0x001F5C5C
			public unsafe Vector3 Normal
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x17002CFA RID: 11514
			// (get) Token: 0x06007D44 RID: 32068 RVA: 0x001F7AAC File Offset: 0x001F5CAC
			public unsafe Il2CppStructArray<int> Indices
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr_get_Indices_Public_get_ArrayOf_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<int>(intPtr2) : null;
				}
			}

			// Token: 0x06007D45 RID: 32069 RVA: 0x001F7B04 File Offset: 0x001F5D04
			[CallerCount(0)]
			public unsafe Triangle(Simplifier simplifier, int nSubMesh, Simplifier.Vertex v0, Simplifier.Vertex v1, Simplifier.Vertex v2, bool bUVData, int nIndex1, int nIndex2, int nIndex3) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simplifier);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nSubMesh;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v0);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v1);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(v2);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bUVData;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIndex1;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIndex2;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIndex3;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr__ctor_Public_Void_Simplifier_Int32_Vertex_Vertex_Vertex_Boolean_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D46 RID: 32070 RVA: 0x001F7C10 File Offset: 0x001F5E10
			[CallerCount(0)]
			public unsafe void Destructor(Simplifier simplifier)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simplifier);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr_Destructor_Public_Void_Simplifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D47 RID: 32071 RVA: 0x001F7C6C File Offset: 0x001F5E6C
			[CallerCount(0)]
			public unsafe bool HasVertex(Simplifier.Vertex v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr_HasVertex_Public_Boolean_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007D48 RID: 32072 RVA: 0x001F7CD4 File Offset: 0x001F5ED4
			[CallerCount(0)]
			public unsafe void ComputeNormal()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr_ComputeNormal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D49 RID: 32073 RVA: 0x001F7D18 File Offset: 0x001F5F18
			[CallerCount(0)]
			public unsafe int TexAt(Simplifier.Vertex vertex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertex);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr_TexAt_Public_Int32_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007D4A RID: 32074 RVA: 0x001F7D80 File Offset: 0x001F5F80
			[CallerCount(0)]
			public unsafe int TexAt(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref i;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr_TexAt_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007D4B RID: 32075 RVA: 0x001F7DE4 File Offset: 0x001F5FE4
			[CallerCount(0)]
			public unsafe void SetTexAt(Simplifier.Vertex vertex, int uv)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertex);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr_SetTexAt_Public_Void_Vertex_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D4C RID: 32076 RVA: 0x001F7E50 File Offset: 0x001F6050
			[CallerCount(0)]
			public unsafe void SetTexAt(int i, int uv)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref i;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uv;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr_SetTexAt_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D4D RID: 32077 RVA: 0x001F7EB8 File Offset: 0x001F60B8
			[CallerCount(0)]
			public unsafe void ReplaceVertex(Simplifier.Vertex vold, Simplifier.Vertex vnew)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vold);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vnew);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.Triangle.NativeMethodInfoPtr_ReplaceVertex_Public_Void_Vertex_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D4E RID: 32078 RVA: 0x001F7F2C File Offset: 0x001F612C
			// Note: this type is marked as 'beforefieldinit'.
			static Triangle()
			{
				Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "Triangle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr);
				Simplifier.Triangle.NativeFieldInfoPtr_m_aVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, "m_aVertices");
				Simplifier.Triangle.NativeFieldInfoPtr_m_bUVData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, "m_bUVData");
				Simplifier.Triangle.NativeFieldInfoPtr_m_aUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, "m_aUV");
				Simplifier.Triangle.NativeFieldInfoPtr_m_aIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, "m_aIndices");
				Simplifier.Triangle.NativeFieldInfoPtr_m_v3Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, "m_v3Normal");
				Simplifier.Triangle.NativeFieldInfoPtr_m_nSubMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, "m_nSubMesh");
				Simplifier.Triangle.NativeMethodInfoPtr_get_Vertices_Public_get_ArrayOf_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673296);
				Simplifier.Triangle.NativeMethodInfoPtr_get_HasUVData_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673297);
				Simplifier.Triangle.NativeMethodInfoPtr_get_IndicesUV_Public_get_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673298);
				Simplifier.Triangle.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673299);
				Simplifier.Triangle.NativeMethodInfoPtr_get_Indices_Public_get_ArrayOf_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673300);
				Simplifier.Triangle.NativeMethodInfoPtr__ctor_Public_Void_Simplifier_Int32_Vertex_Vertex_Vertex_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673301);
				Simplifier.Triangle.NativeMethodInfoPtr_Destructor_Public_Void_Simplifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673302);
				Simplifier.Triangle.NativeMethodInfoPtr_HasVertex_Public_Boolean_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673303);
				Simplifier.Triangle.NativeMethodInfoPtr_ComputeNormal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673304);
				Simplifier.Triangle.NativeMethodInfoPtr_TexAt_Public_Int32_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673305);
				Simplifier.Triangle.NativeMethodInfoPtr_TexAt_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673306);
				Simplifier.Triangle.NativeMethodInfoPtr_SetTexAt_Public_Void_Vertex_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673307);
				Simplifier.Triangle.NativeMethodInfoPtr_SetTexAt_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673308);
				Simplifier.Triangle.NativeMethodInfoPtr_ReplaceVertex_Public_Void_Vertex_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr, 100673309);
			}

			// Token: 0x06007D4F RID: 32079 RVA: 0x00002988 File Offset: 0x00000B88
			public Triangle(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002CEF RID: 11503
			// (get) Token: 0x06007D50 RID: 32080 RVA: 0x001F80E7 File Offset: 0x001F62E7
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Simplifier.Triangle>.NativeClassPtr));
				}
			}

			// Token: 0x17002CF0 RID: 11504
			// (get) Token: 0x06007D51 RID: 32081 RVA: 0x001F80F8 File Offset: 0x001F62F8
			// (set) Token: 0x06007D52 RID: 32082 RVA: 0x001F812C File Offset: 0x001F632C
			public unsafe Il2CppReferenceArray<Simplifier.Vertex> m_aVertices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Triangle.NativeFieldInfoPtr_m_aVertices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppReferenceArray<Simplifier.Vertex>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Triangle.NativeFieldInfoPtr_m_aVertices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CF1 RID: 11505
			// (get) Token: 0x06007D53 RID: 32083 RVA: 0x001F8154 File Offset: 0x001F6354
			// (set) Token: 0x06007D54 RID: 32084 RVA: 0x001F817C File Offset: 0x001F637C
			public unsafe bool m_bUVData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Triangle.NativeFieldInfoPtr_m_bUVData);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Triangle.NativeFieldInfoPtr_m_bUVData)) = value;
				}
			}

			// Token: 0x17002CF2 RID: 11506
			// (get) Token: 0x06007D55 RID: 32085 RVA: 0x001F81A0 File Offset: 0x001F63A0
			// (set) Token: 0x06007D56 RID: 32086 RVA: 0x001F81D4 File Offset: 0x001F63D4
			public unsafe Il2CppStructArray<int> m_aUV
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Triangle.NativeFieldInfoPtr_m_aUV);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<int>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Triangle.NativeFieldInfoPtr_m_aUV), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CF3 RID: 11507
			// (get) Token: 0x06007D57 RID: 32087 RVA: 0x001F81FC File Offset: 0x001F63FC
			// (set) Token: 0x06007D58 RID: 32088 RVA: 0x001F8230 File Offset: 0x001F6430
			public unsafe Il2CppStructArray<int> m_aIndices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Triangle.NativeFieldInfoPtr_m_aIndices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<int>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Triangle.NativeFieldInfoPtr_m_aIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002CF4 RID: 11508
			// (get) Token: 0x06007D59 RID: 32089 RVA: 0x001F8258 File Offset: 0x001F6458
			// (set) Token: 0x06007D5A RID: 32090 RVA: 0x001F8280 File Offset: 0x001F6480
			public unsafe Vector3 m_v3Normal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Triangle.NativeFieldInfoPtr_m_v3Normal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Triangle.NativeFieldInfoPtr_m_v3Normal)) = value;
				}
			}

			// Token: 0x17002CF5 RID: 11509
			// (get) Token: 0x06007D5B RID: 32091 RVA: 0x001F82A4 File Offset: 0x001F64A4
			// (set) Token: 0x06007D5C RID: 32092 RVA: 0x001F82CC File Offset: 0x001F64CC
			public unsafe int m_nSubMesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Triangle.NativeFieldInfoPtr_m_nSubMesh);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Triangle.NativeFieldInfoPtr_m_nSubMesh)) = value;
				}
			}

			// Token: 0x04005023 RID: 20515
			private static readonly IntPtr NativeFieldInfoPtr_m_aVertices;

			// Token: 0x04005024 RID: 20516
			private static readonly IntPtr NativeFieldInfoPtr_m_bUVData;

			// Token: 0x04005025 RID: 20517
			private static readonly IntPtr NativeFieldInfoPtr_m_aUV;

			// Token: 0x04005026 RID: 20518
			private static readonly IntPtr NativeFieldInfoPtr_m_aIndices;

			// Token: 0x04005027 RID: 20519
			private static readonly IntPtr NativeFieldInfoPtr_m_v3Normal;

			// Token: 0x04005028 RID: 20520
			private static readonly IntPtr NativeFieldInfoPtr_m_nSubMesh;

			// Token: 0x04005029 RID: 20521
			private static readonly IntPtr NativeMethodInfoPtr_get_Vertices_Public_get_ArrayOf_Vertex_0;

			// Token: 0x0400502A RID: 20522
			private static readonly IntPtr NativeMethodInfoPtr_get_HasUVData_Public_get_Boolean_0;

			// Token: 0x0400502B RID: 20523
			private static readonly IntPtr NativeMethodInfoPtr_get_IndicesUV_Public_get_ArrayOf_Int32_0;

			// Token: 0x0400502C RID: 20524
			private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0;

			// Token: 0x0400502D RID: 20525
			private static readonly IntPtr NativeMethodInfoPtr_get_Indices_Public_get_ArrayOf_Int32_0;

			// Token: 0x0400502E RID: 20526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Simplifier_Int32_Vertex_Vertex_Vertex_Boolean_Int32_Int32_Int32_0;

			// Token: 0x0400502F RID: 20527
			private static readonly IntPtr NativeMethodInfoPtr_Destructor_Public_Void_Simplifier_0;

			// Token: 0x04005030 RID: 20528
			private static readonly IntPtr NativeMethodInfoPtr_HasVertex_Public_Boolean_Vertex_0;

			// Token: 0x04005031 RID: 20529
			private static readonly IntPtr NativeMethodInfoPtr_ComputeNormal_Public_Void_0;

			// Token: 0x04005032 RID: 20530
			private static readonly IntPtr NativeMethodInfoPtr_TexAt_Public_Int32_Vertex_0;

			// Token: 0x04005033 RID: 20531
			private static readonly IntPtr NativeMethodInfoPtr_TexAt_Public_Int32_Int32_0;

			// Token: 0x04005034 RID: 20532
			private static readonly IntPtr NativeMethodInfoPtr_SetTexAt_Public_Void_Vertex_Int32_0;

			// Token: 0x04005035 RID: 20533
			private static readonly IntPtr NativeMethodInfoPtr_SetTexAt_Public_Void_Int32_Int32_0;

			// Token: 0x04005036 RID: 20534
			private static readonly IntPtr NativeMethodInfoPtr_ReplaceVertex_Public_Void_Vertex_Vertex_0;
		}

		// Token: 0x02000612 RID: 1554
		public class TriangleList : Il2CppSystem.Object
		{
			// Token: 0x06007D5D RID: 32093 RVA: 0x001F82F0 File Offset: 0x001F64F0
			[CallerCount(0)]
			public unsafe TriangleList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Simplifier.TriangleList>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.TriangleList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D5E RID: 32094 RVA: 0x001F833C File Offset: 0x001F653C
			// Note: this type is marked as 'beforefieldinit'.
			static TriangleList()
			{
				Il2CppClassPointerStore<Simplifier.TriangleList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "TriangleList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Simplifier.TriangleList>.NativeClassPtr);
				Simplifier.TriangleList.NativeFieldInfoPtr_m_listTriangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.TriangleList>.NativeClassPtr, "m_listTriangles");
				Simplifier.TriangleList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.TriangleList>.NativeClassPtr, 100673310);
			}

			// Token: 0x06007D5F RID: 32095 RVA: 0x00002988 File Offset: 0x00000B88
			public TriangleList(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002CFB RID: 11515
			// (get) Token: 0x06007D60 RID: 32096 RVA: 0x001F838F File Offset: 0x001F658F
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Simplifier.TriangleList>.NativeClassPtr));
				}
			}

			// Token: 0x17002CFC RID: 11516
			// (get) Token: 0x06007D61 RID: 32097 RVA: 0x001F83A0 File Offset: 0x001F65A0
			// (set) Token: 0x06007D62 RID: 32098 RVA: 0x001F83D4 File Offset: 0x001F65D4
			public unsafe List<Simplifier.Triangle> m_listTriangles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.TriangleList.NativeFieldInfoPtr_m_listTriangles);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<Simplifier.Triangle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.TriangleList.NativeFieldInfoPtr_m_listTriangles), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005037 RID: 20535
			private static readonly IntPtr NativeFieldInfoPtr_m_listTriangles;

			// Token: 0x04005038 RID: 20536
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000613 RID: 1555
		public class Vertex : Il2CppSystem.Object
		{
			// Token: 0x06007D63 RID: 32099 RVA: 0x001F83FC File Offset: 0x001F65FC
			[CallerCount(0)]
			public unsafe Vertex(Simplifier simplifier, Vector3 v, Vector3 v3World, bool bHasBoneWeight, BoneWeight boneWeight, int nID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simplifier);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v3World;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bHasBoneWeight;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boneWeight;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nID;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.Vertex.NativeMethodInfoPtr__ctor_Public_Void_Simplifier_Vector3_Vector3_Boolean_BoneWeight_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D64 RID: 32100 RVA: 0x001F84C0 File Offset: 0x001F66C0
			[CallerCount(0)]
			public unsafe void Destructor(Simplifier simplifier)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(simplifier);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.Vertex.NativeMethodInfoPtr_Destructor_Public_Void_Simplifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D65 RID: 32101 RVA: 0x001F851C File Offset: 0x001F671C
			[CallerCount(0)]
			public unsafe void RemoveIfNonNeighbor(Simplifier.Vertex n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.Vertex.NativeMethodInfoPtr_RemoveIfNonNeighbor_Public_Void_Vertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D66 RID: 32102 RVA: 0x001F8578 File Offset: 0x001F6778
			[CallerCount(0)]
			public unsafe bool IsBorder()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.Vertex.NativeMethodInfoPtr_IsBorder_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007D67 RID: 32103 RVA: 0x001F85C8 File Offset: 0x001F67C8
			// Note: this type is marked as 'beforefieldinit'.
			static Vertex()
			{
				Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "Vertex");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr);
				Simplifier.Vertex.NativeFieldInfoPtr_m_v3Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, "m_v3Position");
				Simplifier.Vertex.NativeFieldInfoPtr_m_v3PositionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, "m_v3PositionWorld");
				Simplifier.Vertex.NativeFieldInfoPtr_m_bHasBoneWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, "m_bHasBoneWeight");
				Simplifier.Vertex.NativeFieldInfoPtr_m_boneWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, "m_boneWeight");
				Simplifier.Vertex.NativeFieldInfoPtr_m_nID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, "m_nID");
				Simplifier.Vertex.NativeFieldInfoPtr_m_listNeighbors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, "m_listNeighbors");
				Simplifier.Vertex.NativeFieldInfoPtr_m_listFaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, "m_listFaces");
				Simplifier.Vertex.NativeFieldInfoPtr_m_fObjDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, "m_fObjDist");
				Simplifier.Vertex.NativeFieldInfoPtr_m_collapse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, "m_collapse");
				Simplifier.Vertex.NativeFieldInfoPtr_m_nHeapSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, "m_nHeapSpot");
				Simplifier.Vertex.NativeMethodInfoPtr__ctor_Public_Void_Simplifier_Vector3_Vector3_Boolean_BoneWeight_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, 100673311);
				Simplifier.Vertex.NativeMethodInfoPtr_Destructor_Public_Void_Simplifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, 100673312);
				Simplifier.Vertex.NativeMethodInfoPtr_RemoveIfNonNeighbor_Public_Void_Vertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, 100673313);
				Simplifier.Vertex.NativeMethodInfoPtr_IsBorder_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr, 100673314);
			}

			// Token: 0x06007D68 RID: 32104 RVA: 0x00002988 File Offset: 0x00000B88
			public Vertex(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002CFD RID: 11517
			// (get) Token: 0x06007D69 RID: 32105 RVA: 0x001F870B File Offset: 0x001F690B
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Simplifier.Vertex>.NativeClassPtr));
				}
			}

			// Token: 0x17002CFE RID: 11518
			// (get) Token: 0x06007D6A RID: 32106 RVA: 0x001F871C File Offset: 0x001F691C
			// (set) Token: 0x06007D6B RID: 32107 RVA: 0x001F8744 File Offset: 0x001F6944
			public unsafe Vector3 m_v3Position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_v3Position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_v3Position)) = value;
				}
			}

			// Token: 0x17002CFF RID: 11519
			// (get) Token: 0x06007D6C RID: 32108 RVA: 0x001F8768 File Offset: 0x001F6968
			// (set) Token: 0x06007D6D RID: 32109 RVA: 0x001F8790 File Offset: 0x001F6990
			public unsafe Vector3 m_v3PositionWorld
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_v3PositionWorld);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_v3PositionWorld)) = value;
				}
			}

			// Token: 0x17002D00 RID: 11520
			// (get) Token: 0x06007D6E RID: 32110 RVA: 0x001F87B4 File Offset: 0x001F69B4
			// (set) Token: 0x06007D6F RID: 32111 RVA: 0x001F87DC File Offset: 0x001F69DC
			public unsafe bool m_bHasBoneWeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_bHasBoneWeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_bHasBoneWeight)) = value;
				}
			}

			// Token: 0x17002D01 RID: 11521
			// (get) Token: 0x06007D70 RID: 32112 RVA: 0x001F8800 File Offset: 0x001F6A00
			// (set) Token: 0x06007D71 RID: 32113 RVA: 0x001F8828 File Offset: 0x001F6A28
			public unsafe BoneWeight m_boneWeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_boneWeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_boneWeight)) = value;
				}
			}

			// Token: 0x17002D02 RID: 11522
			// (get) Token: 0x06007D72 RID: 32114 RVA: 0x001F884C File Offset: 0x001F6A4C
			// (set) Token: 0x06007D73 RID: 32115 RVA: 0x001F8874 File Offset: 0x001F6A74
			public unsafe int m_nID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_nID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_nID)) = value;
				}
			}

			// Token: 0x17002D03 RID: 11523
			// (get) Token: 0x06007D74 RID: 32116 RVA: 0x001F8898 File Offset: 0x001F6A98
			// (set) Token: 0x06007D75 RID: 32117 RVA: 0x001F88CC File Offset: 0x001F6ACC
			public unsafe List<Simplifier.Vertex> m_listNeighbors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_listNeighbors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<Simplifier.Vertex>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_listNeighbors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D04 RID: 11524
			// (get) Token: 0x06007D76 RID: 32118 RVA: 0x001F88F4 File Offset: 0x001F6AF4
			// (set) Token: 0x06007D77 RID: 32119 RVA: 0x001F8928 File Offset: 0x001F6B28
			public unsafe List<Simplifier.Triangle> m_listFaces
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_listFaces);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<Simplifier.Triangle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_listFaces), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D05 RID: 11525
			// (get) Token: 0x06007D78 RID: 32120 RVA: 0x001F8950 File Offset: 0x001F6B50
			// (set) Token: 0x06007D79 RID: 32121 RVA: 0x001F8978 File Offset: 0x001F6B78
			public unsafe float m_fObjDist
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_fObjDist);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_fObjDist)) = value;
				}
			}

			// Token: 0x17002D06 RID: 11526
			// (get) Token: 0x06007D7A RID: 32122 RVA: 0x001F899C File Offset: 0x001F6B9C
			// (set) Token: 0x06007D7B RID: 32123 RVA: 0x001F89D0 File Offset: 0x001F6BD0
			public unsafe Simplifier.Vertex m_collapse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_collapse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Simplifier.Vertex(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_collapse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D07 RID: 11527
			// (get) Token: 0x06007D7C RID: 32124 RVA: 0x001F89F8 File Offset: 0x001F6BF8
			// (set) Token: 0x06007D7D RID: 32125 RVA: 0x001F8A20 File Offset: 0x001F6C20
			public unsafe int m_nHeapSpot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_nHeapSpot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.Vertex.NativeFieldInfoPtr_m_nHeapSpot)) = value;
				}
			}

			// Token: 0x04005039 RID: 20537
			private static readonly IntPtr NativeFieldInfoPtr_m_v3Position;

			// Token: 0x0400503A RID: 20538
			private static readonly IntPtr NativeFieldInfoPtr_m_v3PositionWorld;

			// Token: 0x0400503B RID: 20539
			private static readonly IntPtr NativeFieldInfoPtr_m_bHasBoneWeight;

			// Token: 0x0400503C RID: 20540
			private static readonly IntPtr NativeFieldInfoPtr_m_boneWeight;

			// Token: 0x0400503D RID: 20541
			private static readonly IntPtr NativeFieldInfoPtr_m_nID;

			// Token: 0x0400503E RID: 20542
			private static readonly IntPtr NativeFieldInfoPtr_m_listNeighbors;

			// Token: 0x0400503F RID: 20543
			private static readonly IntPtr NativeFieldInfoPtr_m_listFaces;

			// Token: 0x04005040 RID: 20544
			private static readonly IntPtr NativeFieldInfoPtr_m_fObjDist;

			// Token: 0x04005041 RID: 20545
			private static readonly IntPtr NativeFieldInfoPtr_m_collapse;

			// Token: 0x04005042 RID: 20546
			private static readonly IntPtr NativeFieldInfoPtr_m_nHeapSpot;

			// Token: 0x04005043 RID: 20547
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Simplifier_Vector3_Vector3_Boolean_BoneWeight_Int32_0;

			// Token: 0x04005044 RID: 20548
			private static readonly IntPtr NativeMethodInfoPtr_Destructor_Public_Void_Simplifier_0;

			// Token: 0x04005045 RID: 20549
			private static readonly IntPtr NativeMethodInfoPtr_RemoveIfNonNeighbor_Public_Void_Vertex_0;

			// Token: 0x04005046 RID: 20550
			private static readonly IntPtr NativeMethodInfoPtr_IsBorder_Public_Boolean_0;
		}

		// Token: 0x02000614 RID: 1556
		public class VertexDataHashComparer : Il2CppSystem.Object
		{
			// Token: 0x06007D7E RID: 32126 RVA: 0x001F8A44 File Offset: 0x001F6C44
			[CallerCount(0)]
			public unsafe bool Equals(Simplifier.VertexDataHash a, Simplifier.VertexDataHash b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.VertexDataHashComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexDataHash_VertexDataHash_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007D7F RID: 32127 RVA: 0x001F8AC4 File Offset: 0x001F6CC4
			[CallerCount(0)]
			public unsafe int GetHashCode(Simplifier.VertexDataHash vdata)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vdata);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.VertexDataHashComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_VertexDataHash_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007D80 RID: 32128 RVA: 0x001F8B2C File Offset: 0x001F6D2C
			[CallerCount(0)]
			public unsafe VertexDataHashComparer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Simplifier.VertexDataHashComparer>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.VertexDataHashComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D81 RID: 32129 RVA: 0x001F8B78 File Offset: 0x001F6D78
			// Note: this type is marked as 'beforefieldinit'.
			static VertexDataHashComparer()
			{
				Il2CppClassPointerStore<Simplifier.VertexDataHashComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "VertexDataHashComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Simplifier.VertexDataHashComparer>.NativeClassPtr);
				Simplifier.VertexDataHashComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexDataHash_VertexDataHash_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.VertexDataHashComparer>.NativeClassPtr, 100673315);
				Simplifier.VertexDataHashComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_VertexDataHash_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.VertexDataHashComparer>.NativeClassPtr, 100673316);
				Simplifier.VertexDataHashComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.VertexDataHashComparer>.NativeClassPtr, 100673317);
			}

			// Token: 0x06007D82 RID: 32130 RVA: 0x00002988 File Offset: 0x00000B88
			public VertexDataHashComparer(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002D08 RID: 11528
			// (get) Token: 0x06007D83 RID: 32131 RVA: 0x001F8BDF File Offset: 0x001F6DDF
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Simplifier.VertexDataHashComparer>.NativeClassPtr));
				}
			}

			// Token: 0x04005047 RID: 20551
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexDataHash_VertexDataHash_0;

			// Token: 0x04005048 RID: 20552
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_VertexDataHash_0;

			// Token: 0x04005049 RID: 20553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000615 RID: 1557
		public class VertexDataHash : Il2CppSystem.Object
		{
			// Token: 0x17002D10 RID: 11536
			// (get) Token: 0x06007D84 RID: 32132 RVA: 0x001F8BF0 File Offset: 0x001F6DF0
			public unsafe Vector3 Vertex
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.VertexDataHash.NativeMethodInfoPtr_get_Vertex_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x17002D11 RID: 11537
			// (get) Token: 0x06007D85 RID: 32133 RVA: 0x001F8C40 File Offset: 0x001F6E40
			public unsafe Vector3 Normal
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.VertexDataHash.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x17002D12 RID: 11538
			// (get) Token: 0x06007D86 RID: 32134 RVA: 0x001F8C90 File Offset: 0x001F6E90
			public unsafe Vector2 UV1
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.VertexDataHash.NativeMethodInfoPtr_get_UV1_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x17002D13 RID: 11539
			// (get) Token: 0x06007D87 RID: 32135 RVA: 0x001F8CE0 File Offset: 0x001F6EE0
			public unsafe Vector2 UV2
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.VertexDataHash.NativeMethodInfoPtr_get_UV2_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x17002D14 RID: 11540
			// (get) Token: 0x06007D88 RID: 32136 RVA: 0x001F8D30 File Offset: 0x001F6F30
			public unsafe Color32 Color
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.VertexDataHash.NativeMethodInfoPtr_get_Color_Public_get_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x06007D89 RID: 32137 RVA: 0x001F8D80 File Offset: 0x001F6F80
			[CallerCount(0)]
			public unsafe VertexDataHash(Vector3 v3Vertex, Vector3 v3Normal, Vector2 v2Mapping1, Vector2 v2Mapping2, Color32 color) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref v3Vertex;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v3Normal;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2Mapping1;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2Mapping2;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier.VertexDataHash.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector2_Vector2_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D8A RID: 32138 RVA: 0x001F8E2C File Offset: 0x001F702C
			[CallerCount(0)]
			public new unsafe bool Equals(Il2CppSystem.Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr returnedException;
				IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Simplifier.VertexDataHash.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj2);
			}

			// Token: 0x06007D8B RID: 32139 RVA: 0x001F8EA0 File Offset: 0x001F70A0
			[CallerCount(0)]
			public new unsafe int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Simplifier.VertexDataHash.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007D8C RID: 32140 RVA: 0x001F8EFC File Offset: 0x001F70FC
			[CallerCount(0)]
			public unsafe static bool operator ==(Simplifier.VertexDataHash a, Simplifier.VertexDataHash b)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.VertexDataHash.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_VertexDataHash_VertexDataHash_0, 0, (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007D8D RID: 32141 RVA: 0x001F8F6C File Offset: 0x001F716C
			[CallerCount(0)]
			public unsafe static bool operator !=(Simplifier.VertexDataHash a, Simplifier.VertexDataHash b)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier.VertexDataHash.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_VertexDataHash_VertexDataHash_0, 0, (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06007D8E RID: 32142 RVA: 0x001F8FDC File Offset: 0x001F71DC
			// Note: this type is marked as 'beforefieldinit'.
			static VertexDataHash()
			{
				Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "VertexDataHash");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr);
				Simplifier.VertexDataHash.NativeFieldInfoPtr__v3Vertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, "_v3Vertex");
				Simplifier.VertexDataHash.NativeFieldInfoPtr__v3Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, "_v3Normal");
				Simplifier.VertexDataHash.NativeFieldInfoPtr__v2Mapping1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, "_v2Mapping1");
				Simplifier.VertexDataHash.NativeFieldInfoPtr__v2Mapping2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, "_v2Mapping2");
				Simplifier.VertexDataHash.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, "_color");
				Simplifier.VertexDataHash.NativeFieldInfoPtr__uniqueVertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, "_uniqueVertex");
				Simplifier.VertexDataHash.NativeMethodInfoPtr_get_Vertex_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, 100673318);
				Simplifier.VertexDataHash.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, 100673319);
				Simplifier.VertexDataHash.NativeMethodInfoPtr_get_UV1_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, 100673320);
				Simplifier.VertexDataHash.NativeMethodInfoPtr_get_UV2_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, 100673321);
				Simplifier.VertexDataHash.NativeMethodInfoPtr_get_Color_Public_get_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, 100673322);
				Simplifier.VertexDataHash.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector2_Vector2_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, 100673323);
				Simplifier.VertexDataHash.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, 100673324);
				Simplifier.VertexDataHash.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, 100673325);
				Simplifier.VertexDataHash.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_VertexDataHash_VertexDataHash_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, 100673326);
				Simplifier.VertexDataHash.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_VertexDataHash_VertexDataHash_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr, 100673327);
			}

			// Token: 0x06007D8F RID: 32143 RVA: 0x00002988 File Offset: 0x00000B88
			public VertexDataHash(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002D09 RID: 11529
			// (get) Token: 0x06007D90 RID: 32144 RVA: 0x001F9147 File Offset: 0x001F7347
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Simplifier.VertexDataHash>.NativeClassPtr));
				}
			}

			// Token: 0x17002D0A RID: 11530
			// (get) Token: 0x06007D91 RID: 32145 RVA: 0x001F9158 File Offset: 0x001F7358
			// (set) Token: 0x06007D92 RID: 32146 RVA: 0x001F9180 File Offset: 0x001F7380
			public unsafe Vector3 _v3Vertex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.VertexDataHash.NativeFieldInfoPtr__v3Vertex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.VertexDataHash.NativeFieldInfoPtr__v3Vertex)) = value;
				}
			}

			// Token: 0x17002D0B RID: 11531
			// (get) Token: 0x06007D93 RID: 32147 RVA: 0x001F91A4 File Offset: 0x001F73A4
			// (set) Token: 0x06007D94 RID: 32148 RVA: 0x001F91CC File Offset: 0x001F73CC
			public unsafe Vector3 _v3Normal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.VertexDataHash.NativeFieldInfoPtr__v3Normal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.VertexDataHash.NativeFieldInfoPtr__v3Normal)) = value;
				}
			}

			// Token: 0x17002D0C RID: 11532
			// (get) Token: 0x06007D95 RID: 32149 RVA: 0x001F91F0 File Offset: 0x001F73F0
			// (set) Token: 0x06007D96 RID: 32150 RVA: 0x001F9218 File Offset: 0x001F7418
			public unsafe Vector2 _v2Mapping1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.VertexDataHash.NativeFieldInfoPtr__v2Mapping1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.VertexDataHash.NativeFieldInfoPtr__v2Mapping1)) = value;
				}
			}

			// Token: 0x17002D0D RID: 11533
			// (get) Token: 0x06007D97 RID: 32151 RVA: 0x001F923C File Offset: 0x001F743C
			// (set) Token: 0x06007D98 RID: 32152 RVA: 0x001F9264 File Offset: 0x001F7464
			public unsafe Vector2 _v2Mapping2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.VertexDataHash.NativeFieldInfoPtr__v2Mapping2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.VertexDataHash.NativeFieldInfoPtr__v2Mapping2)) = value;
				}
			}

			// Token: 0x17002D0E RID: 11534
			// (get) Token: 0x06007D99 RID: 32153 RVA: 0x001F9288 File Offset: 0x001F7488
			// (set) Token: 0x06007D9A RID: 32154 RVA: 0x001F92B0 File Offset: 0x001F74B0
			public unsafe Color32 _color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.VertexDataHash.NativeFieldInfoPtr__color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.VertexDataHash.NativeFieldInfoPtr__color)) = value;
				}
			}

			// Token: 0x17002D0F RID: 11535
			// (get) Token: 0x06007D9B RID: 32155 RVA: 0x001F92D4 File Offset: 0x001F74D4
			// (set) Token: 0x06007D9C RID: 32156 RVA: 0x001F9308 File Offset: 0x001F7508
			public unsafe MeshUniqueVertices.UniqueVertex _uniqueVertex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.VertexDataHash.NativeFieldInfoPtr__uniqueVertex);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new MeshUniqueVertices.UniqueVertex(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier.VertexDataHash.NativeFieldInfoPtr__uniqueVertex), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400504A RID: 20554
			private static readonly IntPtr NativeFieldInfoPtr__v3Vertex;

			// Token: 0x0400504B RID: 20555
			private static readonly IntPtr NativeFieldInfoPtr__v3Normal;

			// Token: 0x0400504C RID: 20556
			private static readonly IntPtr NativeFieldInfoPtr__v2Mapping1;

			// Token: 0x0400504D RID: 20557
			private static readonly IntPtr NativeFieldInfoPtr__v2Mapping2;

			// Token: 0x0400504E RID: 20558
			private static readonly IntPtr NativeFieldInfoPtr__color;

			// Token: 0x0400504F RID: 20559
			private static readonly IntPtr NativeFieldInfoPtr__uniqueVertex;

			// Token: 0x04005050 RID: 20560
			private static readonly IntPtr NativeMethodInfoPtr_get_Vertex_Public_get_Vector3_0;

			// Token: 0x04005051 RID: 20561
			private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0;

			// Token: 0x04005052 RID: 20562
			private static readonly IntPtr NativeMethodInfoPtr_get_UV1_Public_get_Vector2_0;

			// Token: 0x04005053 RID: 20563
			private static readonly IntPtr NativeMethodInfoPtr_get_UV2_Public_get_Vector2_0;

			// Token: 0x04005054 RID: 20564
			private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color32_0;

			// Token: 0x04005055 RID: 20565
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector2_Vector2_Color32_0;

			// Token: 0x04005056 RID: 20566
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04005057 RID: 20567
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04005058 RID: 20568
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_VertexDataHash_VertexDataHash_0;

			// Token: 0x04005059 RID: 20569
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_VertexDataHash_VertexDataHash_0;
		}

		// Token: 0x02000616 RID: 1558
		[ObfuscatedName("UltimateGameTools.MeshSimplifier.Simplifier/<ProgressiveMesh>d__24")]
		public sealed class _ProgressiveMesh_d__24 : Il2CppSystem.Object
		{
			// Token: 0x06007D9D RID: 32157 RVA: 0x001F9330 File Offset: 0x001F7530
			[CallerCount(0)]
			public unsafe _ProgressiveMesh_d__24(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ProgressiveMesh_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D9E RID: 32158 RVA: 0x001F9390 File Offset: 0x001F7590
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ProgressiveMesh_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007D9F RID: 32159 RVA: 0x001F93D4 File Offset: 0x001F75D4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier._ProgressiveMesh_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17002D1F RID: 11551
			// (get) Token: 0x06007DA0 RID: 32160 RVA: 0x001F9424 File Offset: 0x001F7624
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ProgressiveMesh_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007DA1 RID: 32161 RVA: 0x001F947C File Offset: 0x001F767C
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ProgressiveMesh_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17002D20 RID: 11552
			// (get) Token: 0x06007DA2 RID: 32162 RVA: 0x001F94C0 File Offset: 0x001F76C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ProgressiveMesh_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007DA3 RID: 32163 RVA: 0x001F9518 File Offset: 0x001F7718
			// Note: this type is marked as 'beforefieldinit'.
			static _ProgressiveMesh_d__24()
			{
				Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "<ProgressiveMesh>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr);
				Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, "<>1__state");
				Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, "<>2__current");
				Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, "<>4__this");
				Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_sourceMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, "sourceMesh");
				Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, "gameObject");
				Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, "progress");
				Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_strProgressDisplayObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, "strProgressDisplayObjectName");
				Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_aRelevanceSpheres = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, "aRelevanceSpheres");
				Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr__nVertices_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, "<nVertices>5__2");
				Simplifier._ProgressiveMesh_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, 100673328);
				Simplifier._ProgressiveMesh_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, 100673329);
				Simplifier._ProgressiveMesh_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, 100673330);
				Simplifier._ProgressiveMesh_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, 100673331);
				Simplifier._ProgressiveMesh_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, 100673332);
				Simplifier._ProgressiveMesh_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr, 100673333);
			}

			// Token: 0x06007DA4 RID: 32164 RVA: 0x00002988 File Offset: 0x00000B88
			public _ProgressiveMesh_d__24(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002D15 RID: 11541
			// (get) Token: 0x06007DA5 RID: 32165 RVA: 0x001F966F File Offset: 0x001F786F
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Simplifier._ProgressiveMesh_d__24>.NativeClassPtr));
				}
			}

			// Token: 0x17002D16 RID: 11542
			// (get) Token: 0x06007DA6 RID: 32166 RVA: 0x001F9680 File Offset: 0x001F7880
			// (set) Token: 0x06007DA7 RID: 32167 RVA: 0x001F96A8 File Offset: 0x001F78A8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002D17 RID: 11543
			// (get) Token: 0x06007DA8 RID: 32168 RVA: 0x001F96CC File Offset: 0x001F78CC
			// (set) Token: 0x06007DA9 RID: 32169 RVA: 0x001F9700 File Offset: 0x001F7900
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D18 RID: 11544
			// (get) Token: 0x06007DAA RID: 32170 RVA: 0x001F9728 File Offset: 0x001F7928
			// (set) Token: 0x06007DAB RID: 32171 RVA: 0x001F975C File Offset: 0x001F795C
			public unsafe Simplifier __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Simplifier(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D19 RID: 11545
			// (get) Token: 0x06007DAC RID: 32172 RVA: 0x001F9784 File Offset: 0x001F7984
			// (set) Token: 0x06007DAD RID: 32173 RVA: 0x001F97B8 File Offset: 0x001F79B8
			public unsafe Mesh sourceMesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_sourceMesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_sourceMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D1A RID: 11546
			// (get) Token: 0x06007DAE RID: 32174 RVA: 0x001F97E0 File Offset: 0x001F79E0
			// (set) Token: 0x06007DAF RID: 32175 RVA: 0x001F9814 File Offset: 0x001F7A14
			public unsafe GameObject gameObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_gameObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D1B RID: 11547
			// (get) Token: 0x06007DB0 RID: 32176 RVA: 0x001F983C File Offset: 0x001F7A3C
			// (set) Token: 0x06007DB1 RID: 32177 RVA: 0x001F9870 File Offset: 0x001F7A70
			public unsafe Simplifier.ProgressDelegate progress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_progress);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Simplifier.ProgressDelegate(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_progress), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D1C RID: 11548
			// (get) Token: 0x06007DB2 RID: 32178 RVA: 0x001F9898 File Offset: 0x001F7A98
			// (set) Token: 0x06007DB3 RID: 32179 RVA: 0x001F98C1 File Offset: 0x001F7AC1
			public unsafe string strProgressDisplayObjectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_strProgressDisplayObjectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_strProgressDisplayObjectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002D1D RID: 11549
			// (get) Token: 0x06007DB4 RID: 32180 RVA: 0x001F98E8 File Offset: 0x001F7AE8
			// (set) Token: 0x06007DB5 RID: 32181 RVA: 0x001F991C File Offset: 0x001F7B1C
			public unsafe Il2CppReferenceArray<RelevanceSphere> aRelevanceSpheres
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_aRelevanceSpheres);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppReferenceArray<RelevanceSphere>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr_aRelevanceSpheres), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D1E RID: 11550
			// (get) Token: 0x06007DB6 RID: 32182 RVA: 0x001F9944 File Offset: 0x001F7B44
			// (set) Token: 0x06007DB7 RID: 32183 RVA: 0x001F996C File Offset: 0x001F7B6C
			public unsafe int _nVertices_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr__nVertices_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ProgressiveMesh_d__24.NativeFieldInfoPtr__nVertices_5__2)) = value;
				}
			}

			// Token: 0x0400505A RID: 20570
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400505B RID: 20571
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400505C RID: 20572
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400505D RID: 20573
			private static readonly IntPtr NativeFieldInfoPtr_sourceMesh;

			// Token: 0x0400505E RID: 20574
			private static readonly IntPtr NativeFieldInfoPtr_gameObject;

			// Token: 0x0400505F RID: 20575
			private static readonly IntPtr NativeFieldInfoPtr_progress;

			// Token: 0x04005060 RID: 20576
			private static readonly IntPtr NativeFieldInfoPtr_strProgressDisplayObjectName;

			// Token: 0x04005061 RID: 20577
			private static readonly IntPtr NativeFieldInfoPtr_aRelevanceSpheres;

			// Token: 0x04005062 RID: 20578
			private static readonly IntPtr NativeFieldInfoPtr__nVertices_5__2;

			// Token: 0x04005063 RID: 20579
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005064 RID: 20580
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005065 RID: 20581
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005066 RID: 20582
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005067 RID: 20583
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005068 RID: 20584
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000617 RID: 1559
		[ObfuscatedName("UltimateGameTools.MeshSimplifier.Simplifier/<ComputeMeshWithVertexCount>d__25")]
		public sealed class _ComputeMeshWithVertexCount_d__25 : Il2CppSystem.Object
		{
			// Token: 0x06007DB8 RID: 32184 RVA: 0x001F9990 File Offset: 0x001F7B90
			[CallerCount(0)]
			public unsafe _ComputeMeshWithVertexCount_d__25(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ComputeMeshWithVertexCount_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007DB9 RID: 32185 RVA: 0x001F99F0 File Offset: 0x001F7BF0
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ComputeMeshWithVertexCount_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007DBA RID: 32186 RVA: 0x001F9A34 File Offset: 0x001F7C34
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier._ComputeMeshWithVertexCount_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17002D2C RID: 11564
			// (get) Token: 0x06007DBB RID: 32187 RVA: 0x001F9A84 File Offset: 0x001F7C84
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ComputeMeshWithVertexCount_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007DBC RID: 32188 RVA: 0x001F9ADC File Offset: 0x001F7CDC
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ComputeMeshWithVertexCount_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17002D2D RID: 11565
			// (get) Token: 0x06007DBD RID: 32189 RVA: 0x001F9B20 File Offset: 0x001F7D20
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ComputeMeshWithVertexCount_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007DBE RID: 32190 RVA: 0x001F9B78 File Offset: 0x001F7D78
			// Note: this type is marked as 'beforefieldinit'.
			static _ComputeMeshWithVertexCount_d__25()
			{
				Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "<ComputeMeshWithVertexCount>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr);
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, "<>1__state");
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, "<>2__current");
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, "<>4__this");
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_nVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, "nVertices");
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_meshOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, "meshOut");
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, "gameObject");
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, "progress");
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_strProgressDisplayObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, "strProgressDisplayObjectName");
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr__listVertices_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, "<listVertices>5__2");
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr__nTotalVertices_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, "<nTotalVertices>5__3");
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, 100673334);
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, 100673335);
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, 100673336);
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, 100673337);
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, 100673338);
				Simplifier._ComputeMeshWithVertexCount_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr, 100673339);
			}

			// Token: 0x06007DBF RID: 32191 RVA: 0x00002988 File Offset: 0x00000B88
			public _ComputeMeshWithVertexCount_d__25(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002D21 RID: 11553
			// (get) Token: 0x06007DC0 RID: 32192 RVA: 0x001F9CE3 File Offset: 0x001F7EE3
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Simplifier._ComputeMeshWithVertexCount_d__25>.NativeClassPtr));
				}
			}

			// Token: 0x17002D22 RID: 11554
			// (get) Token: 0x06007DC1 RID: 32193 RVA: 0x001F9CF4 File Offset: 0x001F7EF4
			// (set) Token: 0x06007DC2 RID: 32194 RVA: 0x001F9D1C File Offset: 0x001F7F1C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002D23 RID: 11555
			// (get) Token: 0x06007DC3 RID: 32195 RVA: 0x001F9D40 File Offset: 0x001F7F40
			// (set) Token: 0x06007DC4 RID: 32196 RVA: 0x001F9D74 File Offset: 0x001F7F74
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D24 RID: 11556
			// (get) Token: 0x06007DC5 RID: 32197 RVA: 0x001F9D9C File Offset: 0x001F7F9C
			// (set) Token: 0x06007DC6 RID: 32198 RVA: 0x001F9DD0 File Offset: 0x001F7FD0
			public unsafe Simplifier __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Simplifier(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D25 RID: 11557
			// (get) Token: 0x06007DC7 RID: 32199 RVA: 0x001F9DF8 File Offset: 0x001F7FF8
			// (set) Token: 0x06007DC8 RID: 32200 RVA: 0x001F9E20 File Offset: 0x001F8020
			public unsafe int nVertices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_nVertices);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_nVertices)) = value;
				}
			}

			// Token: 0x17002D26 RID: 11558
			// (get) Token: 0x06007DC9 RID: 32201 RVA: 0x001F9E44 File Offset: 0x001F8044
			// (set) Token: 0x06007DCA RID: 32202 RVA: 0x001F9E78 File Offset: 0x001F8078
			public unsafe Mesh meshOut
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_meshOut);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_meshOut), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D27 RID: 11559
			// (get) Token: 0x06007DCB RID: 32203 RVA: 0x001F9EA0 File Offset: 0x001F80A0
			// (set) Token: 0x06007DCC RID: 32204 RVA: 0x001F9ED4 File Offset: 0x001F80D4
			public unsafe GameObject gameObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_gameObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D28 RID: 11560
			// (get) Token: 0x06007DCD RID: 32205 RVA: 0x001F9EFC File Offset: 0x001F80FC
			// (set) Token: 0x06007DCE RID: 32206 RVA: 0x001F9F30 File Offset: 0x001F8130
			public unsafe Simplifier.ProgressDelegate progress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_progress);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Simplifier.ProgressDelegate(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_progress), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D29 RID: 11561
			// (get) Token: 0x06007DCF RID: 32207 RVA: 0x001F9F58 File Offset: 0x001F8158
			// (set) Token: 0x06007DD0 RID: 32208 RVA: 0x001F9F81 File Offset: 0x001F8181
			public unsafe string strProgressDisplayObjectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_strProgressDisplayObjectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr_strProgressDisplayObjectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002D2A RID: 11562
			// (get) Token: 0x06007DD1 RID: 32209 RVA: 0x001F9FA8 File Offset: 0x001F81A8
			// (set) Token: 0x06007DD2 RID: 32210 RVA: 0x001F9FDC File Offset: 0x001F81DC
			public unsafe List<Simplifier.Vertex> _listVertices_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr__listVertices_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<Simplifier.Vertex>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr__listVertices_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D2B RID: 11563
			// (get) Token: 0x06007DD3 RID: 32211 RVA: 0x001FA004 File Offset: 0x001F8204
			// (set) Token: 0x06007DD4 RID: 32212 RVA: 0x001FA02C File Offset: 0x001F822C
			public unsafe int _nTotalVertices_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr__nTotalVertices_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeMeshWithVertexCount_d__25.NativeFieldInfoPtr__nTotalVertices_5__3)) = value;
				}
			}

			// Token: 0x04005069 RID: 20585
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400506A RID: 20586
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400506B RID: 20587
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400506C RID: 20588
			private static readonly IntPtr NativeFieldInfoPtr_nVertices;

			// Token: 0x0400506D RID: 20589
			private static readonly IntPtr NativeFieldInfoPtr_meshOut;

			// Token: 0x0400506E RID: 20590
			private static readonly IntPtr NativeFieldInfoPtr_gameObject;

			// Token: 0x0400506F RID: 20591
			private static readonly IntPtr NativeFieldInfoPtr_progress;

			// Token: 0x04005070 RID: 20592
			private static readonly IntPtr NativeFieldInfoPtr_strProgressDisplayObjectName;

			// Token: 0x04005071 RID: 20593
			private static readonly IntPtr NativeFieldInfoPtr__listVertices_5__2;

			// Token: 0x04005072 RID: 20594
			private static readonly IntPtr NativeFieldInfoPtr__nTotalVertices_5__3;

			// Token: 0x04005073 RID: 20595
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005074 RID: 20596
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005075 RID: 20597
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005076 RID: 20598
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005077 RID: 20599
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005078 RID: 20600
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000618 RID: 1560
		[ObfuscatedName("UltimateGameTools.MeshSimplifier.Simplifier/<ConsolidateMesh>d__29")]
		public sealed class _ConsolidateMesh_d__29 : Il2CppSystem.Object
		{
			// Token: 0x06007DD5 RID: 32213 RVA: 0x001FA050 File Offset: 0x001F8250
			[CallerCount(0)]
			public unsafe _ConsolidateMesh_d__29(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ConsolidateMesh_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007DD6 RID: 32214 RVA: 0x001FA0B0 File Offset: 0x001F82B0
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ConsolidateMesh_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007DD7 RID: 32215 RVA: 0x001FA0F4 File Offset: 0x001F82F4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier._ConsolidateMesh_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17002D4E RID: 11598
			// (get) Token: 0x06007DD8 RID: 32216 RVA: 0x001FA144 File Offset: 0x001F8344
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ConsolidateMesh_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007DD9 RID: 32217 RVA: 0x001FA19C File Offset: 0x001F839C
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ConsolidateMesh_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17002D4F RID: 11599
			// (get) Token: 0x06007DDA RID: 32218 RVA: 0x001FA1E0 File Offset: 0x001F83E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ConsolidateMesh_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007DDB RID: 32219 RVA: 0x001FA238 File Offset: 0x001F8438
			// Note: this type is marked as 'beforefieldinit'.
			static _ConsolidateMesh_d__29()
			{
				Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "<ConsolidateMesh>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr);
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<>1__state");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<>2__current");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_meshIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "meshIn");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_aListTriangles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "aListTriangles");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "progress");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_strProgressDisplayObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "strProgressDisplayObjectName");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_meshOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "meshOut");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "gameObject");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__av3NormalsIn_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<av3NormalsIn>5__2");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__av4TangentsIn_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<av4TangentsIn>5__3");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__av2Mapping1In_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<av2Mapping1In>5__4");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__av2Mapping2In_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<av2Mapping2In>5__5");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__acolColorsIn_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<acolColorsIn>5__6");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__aColors32In_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<aColors32In>5__7");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listlistIndicesOut_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<listlistIndicesOut>5__8");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listVerticesOut_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<listVerticesOut>5__9");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listNormalsOut_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<listNormalsOut>5__10");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listTangentsOut_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<listTangentsOut>5__11");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listMapping1Out_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<listMapping1Out>5__12");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listMapping2Out_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<listMapping2Out>5__13");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listColors32Out_5__14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<listColors32Out>5__14");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listBoneWeightsOut_5__15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<listBoneWeightsOut>5__15");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__dicVertexDataHash2Index_5__16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<dicVertexDataHash2Index>5__16");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__bUV1_5__17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<bUV1>5__17");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__bUV2_5__18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<bUV2>5__18");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__bNormal_5__19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<bNormal>5__19");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__bTangent_5__20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<bTangent>5__20");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__nSubMesh_5__21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<nSubMesh>5__21");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listIndicesOut_5__22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<listIndicesOut>5__22");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__strMesh_5__23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<strMesh>5__23");
				Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__i_5__24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, "<i>5__24");
				Simplifier._ConsolidateMesh_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, 100673340);
				Simplifier._ConsolidateMesh_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, 100673341);
				Simplifier._ConsolidateMesh_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, 100673342);
				Simplifier._ConsolidateMesh_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, 100673343);
				Simplifier._ConsolidateMesh_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, 100673344);
				Simplifier._ConsolidateMesh_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr, 100673345);
			}

			// Token: 0x06007DDC RID: 32220 RVA: 0x00002988 File Offset: 0x00000B88
			public _ConsolidateMesh_d__29(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002D2E RID: 11566
			// (get) Token: 0x06007DDD RID: 32221 RVA: 0x001FA547 File Offset: 0x001F8747
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Simplifier._ConsolidateMesh_d__29>.NativeClassPtr));
				}
			}

			// Token: 0x17002D2F RID: 11567
			// (get) Token: 0x06007DDE RID: 32222 RVA: 0x001FA558 File Offset: 0x001F8758
			// (set) Token: 0x06007DDF RID: 32223 RVA: 0x001FA580 File Offset: 0x001F8780
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002D30 RID: 11568
			// (get) Token: 0x06007DE0 RID: 32224 RVA: 0x001FA5A4 File Offset: 0x001F87A4
			// (set) Token: 0x06007DE1 RID: 32225 RVA: 0x001FA5D8 File Offset: 0x001F87D8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D31 RID: 11569
			// (get) Token: 0x06007DE2 RID: 32226 RVA: 0x001FA600 File Offset: 0x001F8800
			// (set) Token: 0x06007DE3 RID: 32227 RVA: 0x001FA634 File Offset: 0x001F8834
			public unsafe Mesh meshIn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_meshIn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_meshIn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D32 RID: 11570
			// (get) Token: 0x06007DE4 RID: 32228 RVA: 0x001FA65C File Offset: 0x001F885C
			// (set) Token: 0x06007DE5 RID: 32229 RVA: 0x001FA690 File Offset: 0x001F8890
			public unsafe Il2CppReferenceArray<Simplifier.TriangleList> aListTriangles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_aListTriangles);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppReferenceArray<Simplifier.TriangleList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_aListTriangles), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D33 RID: 11571
			// (get) Token: 0x06007DE6 RID: 32230 RVA: 0x001FA6B8 File Offset: 0x001F88B8
			// (set) Token: 0x06007DE7 RID: 32231 RVA: 0x001FA6EC File Offset: 0x001F88EC
			public unsafe Simplifier.ProgressDelegate progress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_progress);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Simplifier.ProgressDelegate(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_progress), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D34 RID: 11572
			// (get) Token: 0x06007DE8 RID: 32232 RVA: 0x001FA714 File Offset: 0x001F8914
			// (set) Token: 0x06007DE9 RID: 32233 RVA: 0x001FA73D File Offset: 0x001F893D
			public unsafe string strProgressDisplayObjectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_strProgressDisplayObjectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_strProgressDisplayObjectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002D35 RID: 11573
			// (get) Token: 0x06007DEA RID: 32234 RVA: 0x001FA764 File Offset: 0x001F8964
			// (set) Token: 0x06007DEB RID: 32235 RVA: 0x001FA798 File Offset: 0x001F8998
			public unsafe Mesh meshOut
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_meshOut);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_meshOut), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D36 RID: 11574
			// (get) Token: 0x06007DEC RID: 32236 RVA: 0x001FA7C0 File Offset: 0x001F89C0
			// (set) Token: 0x06007DED RID: 32237 RVA: 0x001FA7F4 File Offset: 0x001F89F4
			public unsafe GameObject gameObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_gameObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D37 RID: 11575
			// (get) Token: 0x06007DEE RID: 32238 RVA: 0x001FA81C File Offset: 0x001F8A1C
			// (set) Token: 0x06007DEF RID: 32239 RVA: 0x001FA850 File Offset: 0x001F8A50
			public unsafe Il2CppStructArray<Vector3> _av3NormalsIn_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__av3NormalsIn_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__av3NormalsIn_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D38 RID: 11576
			// (get) Token: 0x06007DF0 RID: 32240 RVA: 0x001FA878 File Offset: 0x001F8A78
			// (set) Token: 0x06007DF1 RID: 32241 RVA: 0x001FA8AC File Offset: 0x001F8AAC
			public unsafe Il2CppStructArray<Vector4> _av4TangentsIn_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__av4TangentsIn_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<Vector4>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__av4TangentsIn_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D39 RID: 11577
			// (get) Token: 0x06007DF2 RID: 32242 RVA: 0x001FA8D4 File Offset: 0x001F8AD4
			// (set) Token: 0x06007DF3 RID: 32243 RVA: 0x001FA908 File Offset: 0x001F8B08
			public unsafe Il2CppStructArray<Vector2> _av2Mapping1In_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__av2Mapping1In_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<Vector2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__av2Mapping1In_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D3A RID: 11578
			// (get) Token: 0x06007DF4 RID: 32244 RVA: 0x001FA930 File Offset: 0x001F8B30
			// (set) Token: 0x06007DF5 RID: 32245 RVA: 0x001FA964 File Offset: 0x001F8B64
			public unsafe Il2CppStructArray<Vector2> _av2Mapping2In_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__av2Mapping2In_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<Vector2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__av2Mapping2In_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D3B RID: 11579
			// (get) Token: 0x06007DF6 RID: 32246 RVA: 0x001FA98C File Offset: 0x001F8B8C
			// (set) Token: 0x06007DF7 RID: 32247 RVA: 0x001FA9C0 File Offset: 0x001F8BC0
			public unsafe Il2CppStructArray<Color> _acolColorsIn_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__acolColorsIn_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<Color>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__acolColorsIn_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D3C RID: 11580
			// (get) Token: 0x06007DF8 RID: 32248 RVA: 0x001FA9E8 File Offset: 0x001F8BE8
			// (set) Token: 0x06007DF9 RID: 32249 RVA: 0x001FAA1C File Offset: 0x001F8C1C
			public unsafe Il2CppStructArray<Color32> _aColors32In_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__aColors32In_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<Color32>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__aColors32In_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D3D RID: 11581
			// (get) Token: 0x06007DFA RID: 32250 RVA: 0x001FAA44 File Offset: 0x001F8C44
			// (set) Token: 0x06007DFB RID: 32251 RVA: 0x001FAA78 File Offset: 0x001F8C78
			public unsafe List<List<int>> _listlistIndicesOut_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listlistIndicesOut_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listlistIndicesOut_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D3E RID: 11582
			// (get) Token: 0x06007DFC RID: 32252 RVA: 0x001FAAA0 File Offset: 0x001F8CA0
			// (set) Token: 0x06007DFD RID: 32253 RVA: 0x001FAAD4 File Offset: 0x001F8CD4
			public unsafe List<Vector3> _listVerticesOut_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listVerticesOut_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listVerticesOut_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D3F RID: 11583
			// (get) Token: 0x06007DFE RID: 32254 RVA: 0x001FAAFC File Offset: 0x001F8CFC
			// (set) Token: 0x06007DFF RID: 32255 RVA: 0x001FAB30 File Offset: 0x001F8D30
			public unsafe List<Vector3> _listNormalsOut_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listNormalsOut_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listNormalsOut_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D40 RID: 11584
			// (get) Token: 0x06007E00 RID: 32256 RVA: 0x001FAB58 File Offset: 0x001F8D58
			// (set) Token: 0x06007E01 RID: 32257 RVA: 0x001FAB8C File Offset: 0x001F8D8C
			public unsafe List<Vector4> _listTangentsOut_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listTangentsOut_5__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<Vector4>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listTangentsOut_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D41 RID: 11585
			// (get) Token: 0x06007E02 RID: 32258 RVA: 0x001FABB4 File Offset: 0x001F8DB4
			// (set) Token: 0x06007E03 RID: 32259 RVA: 0x001FABE8 File Offset: 0x001F8DE8
			public unsafe List<Vector2> _listMapping1Out_5__12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listMapping1Out_5__12);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<Vector2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listMapping1Out_5__12), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D42 RID: 11586
			// (get) Token: 0x06007E04 RID: 32260 RVA: 0x001FAC10 File Offset: 0x001F8E10
			// (set) Token: 0x06007E05 RID: 32261 RVA: 0x001FAC44 File Offset: 0x001F8E44
			public unsafe List<Vector2> _listMapping2Out_5__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listMapping2Out_5__13);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<Vector2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listMapping2Out_5__13), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D43 RID: 11587
			// (get) Token: 0x06007E06 RID: 32262 RVA: 0x001FAC6C File Offset: 0x001F8E6C
			// (set) Token: 0x06007E07 RID: 32263 RVA: 0x001FACA0 File Offset: 0x001F8EA0
			public unsafe List<Color32> _listColors32Out_5__14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listColors32Out_5__14);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<Color32>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listColors32Out_5__14), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D44 RID: 11588
			// (get) Token: 0x06007E08 RID: 32264 RVA: 0x001FACC8 File Offset: 0x001F8EC8
			// (set) Token: 0x06007E09 RID: 32265 RVA: 0x001FACFC File Offset: 0x001F8EFC
			public unsafe List<BoneWeight> _listBoneWeightsOut_5__15
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listBoneWeightsOut_5__15);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<BoneWeight>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listBoneWeightsOut_5__15), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D45 RID: 11589
			// (get) Token: 0x06007E0A RID: 32266 RVA: 0x001FAD24 File Offset: 0x001F8F24
			// (set) Token: 0x06007E0B RID: 32267 RVA: 0x001FAD58 File Offset: 0x001F8F58
			public unsafe Dictionary<Simplifier.VertexDataHash, int> _dicVertexDataHash2Index_5__16
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__dicVertexDataHash2Index_5__16);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Dictionary<Simplifier.VertexDataHash, int>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__dicVertexDataHash2Index_5__16), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D46 RID: 11590
			// (get) Token: 0x06007E0C RID: 32268 RVA: 0x001FAD80 File Offset: 0x001F8F80
			// (set) Token: 0x06007E0D RID: 32269 RVA: 0x001FADA8 File Offset: 0x001F8FA8
			public unsafe bool _bUV1_5__17
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__bUV1_5__17);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__bUV1_5__17)) = value;
				}
			}

			// Token: 0x17002D47 RID: 11591
			// (get) Token: 0x06007E0E RID: 32270 RVA: 0x001FADCC File Offset: 0x001F8FCC
			// (set) Token: 0x06007E0F RID: 32271 RVA: 0x001FADF4 File Offset: 0x001F8FF4
			public unsafe bool _bUV2_5__18
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__bUV2_5__18);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__bUV2_5__18)) = value;
				}
			}

			// Token: 0x17002D48 RID: 11592
			// (get) Token: 0x06007E10 RID: 32272 RVA: 0x001FAE18 File Offset: 0x001F9018
			// (set) Token: 0x06007E11 RID: 32273 RVA: 0x001FAE40 File Offset: 0x001F9040
			public unsafe bool _bNormal_5__19
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__bNormal_5__19);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__bNormal_5__19)) = value;
				}
			}

			// Token: 0x17002D49 RID: 11593
			// (get) Token: 0x06007E12 RID: 32274 RVA: 0x001FAE64 File Offset: 0x001F9064
			// (set) Token: 0x06007E13 RID: 32275 RVA: 0x001FAE8C File Offset: 0x001F908C
			public unsafe bool _bTangent_5__20
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__bTangent_5__20);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__bTangent_5__20)) = value;
				}
			}

			// Token: 0x17002D4A RID: 11594
			// (get) Token: 0x06007E14 RID: 32276 RVA: 0x001FAEB0 File Offset: 0x001F90B0
			// (set) Token: 0x06007E15 RID: 32277 RVA: 0x001FAED8 File Offset: 0x001F90D8
			public unsafe int _nSubMesh_5__21
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__nSubMesh_5__21);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__nSubMesh_5__21)) = value;
				}
			}

			// Token: 0x17002D4B RID: 11595
			// (get) Token: 0x06007E16 RID: 32278 RVA: 0x001FAEFC File Offset: 0x001F90FC
			// (set) Token: 0x06007E17 RID: 32279 RVA: 0x001FAF30 File Offset: 0x001F9130
			public unsafe List<int> _listIndicesOut_5__22
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listIndicesOut_5__22);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new List<int>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__listIndicesOut_5__22), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D4C RID: 11596
			// (get) Token: 0x06007E18 RID: 32280 RVA: 0x001FAF58 File Offset: 0x001F9158
			// (set) Token: 0x06007E19 RID: 32281 RVA: 0x001FAF81 File Offset: 0x001F9181
			public unsafe string _strMesh_5__23
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__strMesh_5__23);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__strMesh_5__23), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002D4D RID: 11597
			// (get) Token: 0x06007E1A RID: 32282 RVA: 0x001FAFA8 File Offset: 0x001F91A8
			// (set) Token: 0x06007E1B RID: 32283 RVA: 0x001FAFD0 File Offset: 0x001F91D0
			public unsafe int _i_5__24
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__i_5__24);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ConsolidateMesh_d__29.NativeFieldInfoPtr__i_5__24)) = value;
				}
			}

			// Token: 0x04005079 RID: 20601
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400507A RID: 20602
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400507B RID: 20603
			private static readonly IntPtr NativeFieldInfoPtr_meshIn;

			// Token: 0x0400507C RID: 20604
			private static readonly IntPtr NativeFieldInfoPtr_aListTriangles;

			// Token: 0x0400507D RID: 20605
			private static readonly IntPtr NativeFieldInfoPtr_progress;

			// Token: 0x0400507E RID: 20606
			private static readonly IntPtr NativeFieldInfoPtr_strProgressDisplayObjectName;

			// Token: 0x0400507F RID: 20607
			private static readonly IntPtr NativeFieldInfoPtr_meshOut;

			// Token: 0x04005080 RID: 20608
			private static readonly IntPtr NativeFieldInfoPtr_gameObject;

			// Token: 0x04005081 RID: 20609
			private static readonly IntPtr NativeFieldInfoPtr__av3NormalsIn_5__2;

			// Token: 0x04005082 RID: 20610
			private static readonly IntPtr NativeFieldInfoPtr__av4TangentsIn_5__3;

			// Token: 0x04005083 RID: 20611
			private static readonly IntPtr NativeFieldInfoPtr__av2Mapping1In_5__4;

			// Token: 0x04005084 RID: 20612
			private static readonly IntPtr NativeFieldInfoPtr__av2Mapping2In_5__5;

			// Token: 0x04005085 RID: 20613
			private static readonly IntPtr NativeFieldInfoPtr__acolColorsIn_5__6;

			// Token: 0x04005086 RID: 20614
			private static readonly IntPtr NativeFieldInfoPtr__aColors32In_5__7;

			// Token: 0x04005087 RID: 20615
			private static readonly IntPtr NativeFieldInfoPtr__listlistIndicesOut_5__8;

			// Token: 0x04005088 RID: 20616
			private static readonly IntPtr NativeFieldInfoPtr__listVerticesOut_5__9;

			// Token: 0x04005089 RID: 20617
			private static readonly IntPtr NativeFieldInfoPtr__listNormalsOut_5__10;

			// Token: 0x0400508A RID: 20618
			private static readonly IntPtr NativeFieldInfoPtr__listTangentsOut_5__11;

			// Token: 0x0400508B RID: 20619
			private static readonly IntPtr NativeFieldInfoPtr__listMapping1Out_5__12;

			// Token: 0x0400508C RID: 20620
			private static readonly IntPtr NativeFieldInfoPtr__listMapping2Out_5__13;

			// Token: 0x0400508D RID: 20621
			private static readonly IntPtr NativeFieldInfoPtr__listColors32Out_5__14;

			// Token: 0x0400508E RID: 20622
			private static readonly IntPtr NativeFieldInfoPtr__listBoneWeightsOut_5__15;

			// Token: 0x0400508F RID: 20623
			private static readonly IntPtr NativeFieldInfoPtr__dicVertexDataHash2Index_5__16;

			// Token: 0x04005090 RID: 20624
			private static readonly IntPtr NativeFieldInfoPtr__bUV1_5__17;

			// Token: 0x04005091 RID: 20625
			private static readonly IntPtr NativeFieldInfoPtr__bUV2_5__18;

			// Token: 0x04005092 RID: 20626
			private static readonly IntPtr NativeFieldInfoPtr__bNormal_5__19;

			// Token: 0x04005093 RID: 20627
			private static readonly IntPtr NativeFieldInfoPtr__bTangent_5__20;

			// Token: 0x04005094 RID: 20628
			private static readonly IntPtr NativeFieldInfoPtr__nSubMesh_5__21;

			// Token: 0x04005095 RID: 20629
			private static readonly IntPtr NativeFieldInfoPtr__listIndicesOut_5__22;

			// Token: 0x04005096 RID: 20630
			private static readonly IntPtr NativeFieldInfoPtr__strMesh_5__23;

			// Token: 0x04005097 RID: 20631
			private static readonly IntPtr NativeFieldInfoPtr__i_5__24;

			// Token: 0x04005098 RID: 20632
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005099 RID: 20633
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400509A RID: 20634
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400509B RID: 20635
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400509C RID: 20636
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400509D RID: 20637
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000619 RID: 1561
		[ObfuscatedName("UltimateGameTools.MeshSimplifier.Simplifier/<ComputeAllEdgeCollapseCosts>d__33")]
		public sealed class _ComputeAllEdgeCollapseCosts_d__33 : Il2CppSystem.Object
		{
			// Token: 0x06007E1C RID: 32284 RVA: 0x001FAFF4 File Offset: 0x001F91F4
			[CallerCount(0)]
			public unsafe _ComputeAllEdgeCollapseCosts_d__33(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007E1D RID: 32285 RVA: 0x001FB054 File Offset: 0x001F9254
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007E1E RID: 32286 RVA: 0x001FB098 File Offset: 0x001F9298
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17002D59 RID: 11609
			// (get) Token: 0x06007E1F RID: 32287 RVA: 0x001FB0E8 File Offset: 0x001F92E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007E20 RID: 32288 RVA: 0x001FB140 File Offset: 0x001F9340
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17002D5A RID: 11610
			// (get) Token: 0x06007E21 RID: 32289 RVA: 0x001FB184 File Offset: 0x001F9384
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007E22 RID: 32290 RVA: 0x001FB1DC File Offset: 0x001F93DC
			// Note: this type is marked as 'beforefieldinit'.
			static _ComputeAllEdgeCollapseCosts_d__33()
			{
				Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Simplifier>.NativeClassPtr, "<ComputeAllEdgeCollapseCosts>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr);
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, "<>1__state");
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, "<>2__current");
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, "progress");
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr_strProgressDisplayObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, "strProgressDisplayObjectName");
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, "<>4__this");
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, "transform");
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr_aRelevanceSpheres = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, "aRelevanceSpheres");
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, "<i>5__2");
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, 100673346);
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, 100673347);
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, 100673348);
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, 100673349);
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, 100673350);
				Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr, 100673351);
			}

			// Token: 0x06007E23 RID: 32291 RVA: 0x00002988 File Offset: 0x00000B88
			public _ComputeAllEdgeCollapseCosts_d__33(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002D50 RID: 11600
			// (get) Token: 0x06007E24 RID: 32292 RVA: 0x001FB31F File Offset: 0x001F951F
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Simplifier._ComputeAllEdgeCollapseCosts_d__33>.NativeClassPtr));
				}
			}

			// Token: 0x17002D51 RID: 11601
			// (get) Token: 0x06007E25 RID: 32293 RVA: 0x001FB330 File Offset: 0x001F9530
			// (set) Token: 0x06007E26 RID: 32294 RVA: 0x001FB358 File Offset: 0x001F9558
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002D52 RID: 11602
			// (get) Token: 0x06007E27 RID: 32295 RVA: 0x001FB37C File Offset: 0x001F957C
			// (set) Token: 0x06007E28 RID: 32296 RVA: 0x001FB3B0 File Offset: 0x001F95B0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D53 RID: 11603
			// (get) Token: 0x06007E29 RID: 32297 RVA: 0x001FB3D8 File Offset: 0x001F95D8
			// (set) Token: 0x06007E2A RID: 32298 RVA: 0x001FB40C File Offset: 0x001F960C
			public unsafe Simplifier.ProgressDelegate progress
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr_progress);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Simplifier.ProgressDelegate(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr_progress), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D54 RID: 11604
			// (get) Token: 0x06007E2B RID: 32299 RVA: 0x001FB434 File Offset: 0x001F9634
			// (set) Token: 0x06007E2C RID: 32300 RVA: 0x001FB45D File Offset: 0x001F965D
			public unsafe string strProgressDisplayObjectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr_strProgressDisplayObjectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr_strProgressDisplayObjectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17002D55 RID: 11605
			// (get) Token: 0x06007E2D RID: 32301 RVA: 0x001FB484 File Offset: 0x001F9684
			// (set) Token: 0x06007E2E RID: 32302 RVA: 0x001FB4B8 File Offset: 0x001F96B8
			public unsafe Simplifier __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Simplifier(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D56 RID: 11606
			// (get) Token: 0x06007E2F RID: 32303 RVA: 0x001FB4E0 File Offset: 0x001F96E0
			// (set) Token: 0x06007E30 RID: 32304 RVA: 0x001FB514 File Offset: 0x001F9714
			public unsafe Transform transform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr_transform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Transform(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D57 RID: 11607
			// (get) Token: 0x06007E31 RID: 32305 RVA: 0x001FB53C File Offset: 0x001F973C
			// (set) Token: 0x06007E32 RID: 32306 RVA: 0x001FB570 File Offset: 0x001F9770
			public unsafe Il2CppReferenceArray<RelevanceSphere> aRelevanceSpheres
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr_aRelevanceSpheres);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppReferenceArray<RelevanceSphere>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr_aRelevanceSpheres), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002D58 RID: 11608
			// (get) Token: 0x06007E33 RID: 32307 RVA: 0x001FB598 File Offset: 0x001F9798
			// (set) Token: 0x06007E34 RID: 32308 RVA: 0x001FB5C0 File Offset: 0x001F97C0
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Simplifier._ComputeAllEdgeCollapseCosts_d__33.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x0400509E RID: 20638
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400509F RID: 20639
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040050A0 RID: 20640
			private static readonly IntPtr NativeFieldInfoPtr_progress;

			// Token: 0x040050A1 RID: 20641
			private static readonly IntPtr NativeFieldInfoPtr_strProgressDisplayObjectName;

			// Token: 0x040050A2 RID: 20642
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040050A3 RID: 20643
			private static readonly IntPtr NativeFieldInfoPtr_transform;

			// Token: 0x040050A4 RID: 20644
			private static readonly IntPtr NativeFieldInfoPtr_aRelevanceSpheres;

			// Token: 0x040050A5 RID: 20645
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040050A6 RID: 20646
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040050A7 RID: 20647
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040050A8 RID: 20648
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040050A9 RID: 20649
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040050AA RID: 20650
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040050AB RID: 20651
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
