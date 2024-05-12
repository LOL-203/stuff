using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

namespace Verlet
{
	// Token: 0x020008FA RID: 2298
	public class VerletRope : MonoBehaviour
	{
		// Token: 0x17004335 RID: 17205
		// (get) Token: 0x0600BBF3 RID: 48115 RVA: 0x00301340 File Offset: 0x002FF540
		public unsafe NativeArray<VerletRopeSegment> Segments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_get_Segments_Public_get_NativeArray_1_VerletRopeSegment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return new NativeArray<VerletRopeSegment>(intPtr);
			}
		}

		// Token: 0x17004336 RID: 17206
		// (get) Token: 0x0600BBF4 RID: 48116 RVA: 0x0030138C File Offset: 0x002FF58C
		public unsafe Transform RopeStartTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_get_RopeStartTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
		}

		// Token: 0x17004337 RID: 17207
		// (get) Token: 0x0600BBF5 RID: 48117 RVA: 0x003013E4 File Offset: 0x002FF5E4
		public unsafe Transform RopeEndTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_get_RopeEndTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
		}

		// Token: 0x0600BBF6 RID: 48118 RVA: 0x0030143C File Offset: 0x002FF63C
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBF7 RID: 48119 RVA: 0x00301480 File Offset: 0x002FF680
		[CallerCount(0)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBF8 RID: 48120 RVA: 0x003014C4 File Offset: 0x002FF6C4
		[CallerCount(0)]
		public unsafe void SafeArrayDispose<T>(NativeArray<T> array) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(array));
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.MethodInfoStoreGeneric_SafeArrayDispose_Private_Void_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBF9 RID: 48121 RVA: 0x00301524 File Offset: 0x002FF724
		[CallerCount(0)]
		public unsafe void SafeArrayDispose(TransformAccessArray array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref array;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_SafeArrayDispose_Private_Void_TransformAccessArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBFA RID: 48122 RVA: 0x00301578 File Offset: 0x002FF778
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBFB RID: 48123 RVA: 0x003015BC File Offset: 0x002FF7BC
		[CallerCount(0)]
		public unsafe void OnManagedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17004338 RID: 17208
		// (get) Token: 0x0600BBFC RID: 48124 RVA: 0x00301600 File Offset: 0x002FF800
		// (set) Token: 0x0600BBFD RID: 48125 RVA: 0x00301650 File Offset: 0x002FF850
		public unsafe bool ManagedUpdateRemoval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600BBFE RID: 48126 RVA: 0x003016A4 File Offset: 0x002FF8A4
		[CallerCount(0)]
		public unsafe void BeginSimulation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_BeginSimulation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBFF RID: 48127 RVA: 0x003016E8 File Offset: 0x002FF8E8
		[CallerCount(0)]
		public unsafe void EndSimulation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_EndSimulation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC00 RID: 48128 RVA: 0x0030172C File Offset: 0x002FF92C
		[CallerCount(0)]
		public unsafe void Simulate(float dt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dt;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_Simulate_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC01 RID: 48129 RVA: 0x00301780 File Offset: 0x002FF980
		[CallerCount(0)]
		public unsafe static void SegmentMovement(NativeArray<int> currentSegmentCount, NativeArray<VerletRopeSegment> segments, float dt, Vector3 forceGravity, bool lockX, bool lockY, bool lockZ, Vector3 ropeVelocity)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(currentSegmentCount));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segments));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dt;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceGravity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockX;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockY;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockZ;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ropeVelocity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_SegmentMovement_Private_Static_Void_NativeArray_1_Int32_NativeArray_1_VerletRopeSegment_Single_Vector3_Boolean_Boolean_Boolean_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC02 RID: 48130 RVA: 0x00301860 File Offset: 0x002FFA60
		[CallerCount(0)]
		public unsafe static void LockStartAndEndAxis(Vector3 ropeStartTransformPosition, Vector3 ropeEndTransformPosition, NativeArray<Vector3> lockedAxisStart, NativeArray<Vector3> lockedAxisEnd, bool lockX, bool lockY, bool lockZ)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ropeStartTransformPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ropeEndTransformPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lockedAxisStart));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lockedAxisEnd));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockX;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockY;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockZ;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_LockStartAndEndAxis_Private_Static_Void_Vector3_Vector3_NativeArray_1_Vector3_NativeArray_1_Vector3_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC03 RID: 48131 RVA: 0x0030192C File Offset: 0x002FFB2C
		[CallerCount(0)]
		public unsafe static void ApplyBeltPull(bool pullingBelt, NativeArray<Vector3> lockedAxisStart, NativeArray<Vector3> lockedAxisEnd, float maxBeltPull, float currentBeltLength, NativeArray<int> currentSegmentCount, float segmentLength, NativeArray<VerletRopeSegment> segments, Vector3 ropeStartTransformPosition)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pullingBelt;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lockedAxisStart));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lockedAxisEnd));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxBeltPull;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentBeltLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(currentSegmentCount));
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref segmentLength;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segments));
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ropeStartTransformPosition;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_ApplyBeltPull_Private_Static_Void_Boolean_NativeArray_1_Vector3_NativeArray_1_Vector3_Single_Single_NativeArray_1_Int32_Single_NativeArray_1_VerletRopeSegment_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC04 RID: 48132 RVA: 0x00301A34 File Offset: 0x002FFC34
		[CallerCount(0)]
		public unsafe static void ApplyLockAxisConstraints(int i, bool lockX, bool lockY, bool lockZ, NativeArray<VerletRopeSegment> segments)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref i;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockZ;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segments));
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_ApplyLockAxisConstraints_Private_Static_Void_Int32_Boolean_Boolean_Boolean_NativeArray_1_VerletRopeSegment_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC05 RID: 48133 RVA: 0x00301AD0 File Offset: 0x002FFCD0
		[CallerCount(0)]
		public unsafe static void ApplyStartEndConstraints(NativeArray<int> currentSegmentCount, NativeArray<VerletRopeSegment> segments, bool startIsLocked, bool endIsLocked, NativeArray<Vector3> lockedAxisStart, NativeArray<Vector3> lockedAxisEnd)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(currentSegmentCount));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segments));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIsLocked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIsLocked;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lockedAxisStart));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lockedAxisEnd));
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_ApplyStartEndConstraints_Private_Static_Void_NativeArray_1_Int32_NativeArray_1_VerletRopeSegment_Boolean_Boolean_NativeArray_1_Vector3_NativeArray_1_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC06 RID: 48134 RVA: 0x00301B9C File Offset: 0x002FFD9C
		[CallerCount(0)]
		public unsafe static void ApplyBoxCollision(int segmentIndex, Matrix4x4 ropeLocalToWorld, Matrix4x4 ropeWorldToLocal, NativeArray<Matrix4x4> localToWorldArray, NativeArray<Matrix4x4> worldToLocalArray, NativeArray<VerletRopeSegment> segments)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref segmentIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ropeLocalToWorld;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ropeWorldToLocal;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localToWorldArray));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(worldToLocalArray));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(segments));
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_ApplyBoxCollision_Private_Static_Void_Int32_Matrix4x4_Matrix4x4_NativeArray_1_Matrix4x4_NativeArray_1_Matrix4x4_NativeArray_1_VerletRopeSegment_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC07 RID: 48135 RVA: 0x00301C60 File Offset: 0x002FFE60
		[CallerCount(0)]
		public unsafe void ResetAllSegments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_ResetAllSegments_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC08 RID: 48136 RVA: 0x00301CA4 File Offset: 0x002FFEA4
		[CallerCount(0)]
		public unsafe void DrawRope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_DrawRope_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC09 RID: 48137 RVA: 0x00301CE8 File Offset: 0x002FFEE8
		[CallerCount(0)]
		public unsafe static Vector3 LockVector3(Vector3 vec3, bool lockX, bool lockY, bool lockZ)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vec3;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockY;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockZ;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_LockVector3_Private_Static_Vector3_Vector3_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BC0A RID: 48138 RVA: 0x00301D74 File Offset: 0x002FFF74
		[CallerCount(0)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC0B RID: 48139 RVA: 0x00301DB8 File Offset: 0x002FFFB8
		[CallerCount(0)]
		public unsafe void WaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr_WaitForCompletion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC0C RID: 48140 RVA: 0x00301DFC File Offset: 0x002FFFFC
		[CallerCount(0)]
		public unsafe VerletRope() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerletRope>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BC0D RID: 48141 RVA: 0x00301E48 File Offset: 0x00300048
		// Note: this type is marked as 'beforefieldinit'.
		static VerletRope()
		{
			Il2CppClassPointerStore<VerletRope>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Verlet", "VerletRope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerletRope>.NativeClassPtr);
			VerletRope.NativeFieldInfoPtr__segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_segments");
			VerletRope.NativeFieldInfoPtr_CurrentSegmentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "CurrentSegmentCount");
			VerletRope.NativeFieldInfoPtr_StartIsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "StartIsLocked");
			VerletRope.NativeFieldInfoPtr_EndIsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "EndIsLocked");
			VerletRope.NativeFieldInfoPtr_PullingBelt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "PullingBelt");
			VerletRope.NativeFieldInfoPtr_JobComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "JobComplete");
			VerletRope.NativeFieldInfoPtr__segmentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_segmentLength");
			VerletRope.NativeFieldInfoPtr__boxColliderTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_boxColliderTransforms");
			VerletRope.NativeFieldInfoPtr__maxSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_maxSegments");
			VerletRope.NativeFieldInfoPtr__constraintLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_constraintLoops");
			VerletRope.NativeFieldInfoPtr__gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_gravity");
			VerletRope.NativeFieldInfoPtr__lineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_lineRenderer");
			VerletRope.NativeFieldInfoPtr__lockX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_lockX");
			VerletRope.NativeFieldInfoPtr__lockY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_lockY");
			VerletRope.NativeFieldInfoPtr__lockZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_lockZ");
			VerletRope.NativeFieldInfoPtr__ropeStartTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_ropeStartTransform");
			VerletRope.NativeFieldInfoPtr__ropeEndTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_ropeEndTransform");
			VerletRope.NativeFieldInfoPtr__currentBeltLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_currentBeltLength");
			VerletRope.NativeFieldInfoPtr__hasLineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_hasLineRenderer");
			VerletRope.NativeFieldInfoPtr__maxBeltPull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_maxBeltPull");
			VerletRope.NativeFieldInfoPtr_forceGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "forceGravity");
			VerletRope.NativeFieldInfoPtr__nativeLocalToWorldArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_nativeLocalToWorldArray");
			VerletRope.NativeFieldInfoPtr__nativeWorldToLocalArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_nativeWorldToLocalArray");
			VerletRope.NativeFieldInfoPtr__nativeBoxColliderTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_nativeBoxColliderTransforms");
			VerletRope.NativeFieldInfoPtr__lockedAxisStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_lockedAxisStart");
			VerletRope.NativeFieldInfoPtr__lockedAxisEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_lockedAxisEnd");
			VerletRope.NativeFieldInfoPtr__verletBoxColliderCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_verletBoxColliderCount");
			VerletRope.NativeFieldInfoPtr__jobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_jobHandle");
			VerletRope.NativeFieldInfoPtr_accumulator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "accumulator");
			VerletRope.NativeFieldInfoPtr__worldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_worldSpace");
			VerletRope.NativeFieldInfoPtr__isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_isInitialized");
			VerletRope.NativeFieldInfoPtr__ropePosPrevFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "_ropePosPrevFrame");
			VerletRope.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "<ManagedUpdateRemoval>k__BackingField");
			VerletRope.NativeMethodInfoPtr_get_Segments_Public_get_NativeArray_1_VerletRopeSegment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678590);
			VerletRope.NativeMethodInfoPtr_get_RopeStartTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678591);
			VerletRope.NativeMethodInfoPtr_get_RopeEndTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678592);
			VerletRope.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678593);
			VerletRope.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678594);
			VerletRope.NativeMethodInfoPtr_SafeArrayDispose_Private_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678595);
			VerletRope.NativeMethodInfoPtr_SafeArrayDispose_Private_Void_TransformAccessArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678596);
			VerletRope.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678597);
			VerletRope.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678598);
			VerletRope.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678599);
			VerletRope.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678600);
			VerletRope.NativeMethodInfoPtr_BeginSimulation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678601);
			VerletRope.NativeMethodInfoPtr_EndSimulation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678602);
			VerletRope.NativeMethodInfoPtr_Simulate_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678603);
			VerletRope.NativeMethodInfoPtr_SegmentMovement_Private_Static_Void_NativeArray_1_Int32_NativeArray_1_VerletRopeSegment_Single_Vector3_Boolean_Boolean_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678604);
			VerletRope.NativeMethodInfoPtr_LockStartAndEndAxis_Private_Static_Void_Vector3_Vector3_NativeArray_1_Vector3_NativeArray_1_Vector3_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678605);
			VerletRope.NativeMethodInfoPtr_ApplyBeltPull_Private_Static_Void_Boolean_NativeArray_1_Vector3_NativeArray_1_Vector3_Single_Single_NativeArray_1_Int32_Single_NativeArray_1_VerletRopeSegment_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678606);
			VerletRope.NativeMethodInfoPtr_ApplyLockAxisConstraints_Private_Static_Void_Int32_Boolean_Boolean_Boolean_NativeArray_1_VerletRopeSegment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678607);
			VerletRope.NativeMethodInfoPtr_ApplyStartEndConstraints_Private_Static_Void_NativeArray_1_Int32_NativeArray_1_VerletRopeSegment_Boolean_Boolean_NativeArray_1_Vector3_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678608);
			VerletRope.NativeMethodInfoPtr_ApplyBoxCollision_Private_Static_Void_Int32_Matrix4x4_Matrix4x4_NativeArray_1_Matrix4x4_NativeArray_1_Matrix4x4_NativeArray_1_VerletRopeSegment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678609);
			VerletRope.NativeMethodInfoPtr_ResetAllSegments_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678610);
			VerletRope.NativeMethodInfoPtr_DrawRope_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678611);
			VerletRope.NativeMethodInfoPtr_LockVector3_Private_Static_Vector3_Vector3_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678612);
			VerletRope.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678613);
			VerletRope.NativeMethodInfoPtr_WaitForCompletion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678614);
			VerletRope.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, 100678615);
		}

		// Token: 0x0600BC0E RID: 48142 RVA: 0x0000210C File Offset: 0x0000030C
		public VerletRope(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004313 RID: 17171
		// (get) Token: 0x0600BC0F RID: 48143 RVA: 0x00302314 File Offset: 0x00300514
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VerletRope>.NativeClassPtr));
			}
		}

		// Token: 0x17004314 RID: 17172
		// (get) Token: 0x0600BC10 RID: 48144 RVA: 0x00302328 File Offset: 0x00300528
		// (set) Token: 0x0600BC11 RID: 48145 RVA: 0x0030235A File Offset: 0x0030055A
		public NativeArray<VerletRopeSegment> _segments
		{
			get
			{
				IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__segments);
				return new NativeArray<VerletRopeSegment>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<VerletRopeSegment>>.NativeClassPtr, data));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__segments), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<VerletRopeSegment>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17004315 RID: 17173
		// (get) Token: 0x0600BC12 RID: 48146 RVA: 0x00302390 File Offset: 0x00300590
		// (set) Token: 0x0600BC13 RID: 48147 RVA: 0x003023C2 File Offset: 0x003005C2
		public NativeArray<int> CurrentSegmentCount
		{
			get
			{
				IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_CurrentSegmentCount);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, data));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_CurrentSegmentCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17004316 RID: 17174
		// (get) Token: 0x0600BC14 RID: 48148 RVA: 0x003023F8 File Offset: 0x003005F8
		// (set) Token: 0x0600BC15 RID: 48149 RVA: 0x00302420 File Offset: 0x00300620
		public unsafe bool StartIsLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_StartIsLocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_StartIsLocked)) = value;
			}
		}

		// Token: 0x17004317 RID: 17175
		// (get) Token: 0x0600BC16 RID: 48150 RVA: 0x00302444 File Offset: 0x00300644
		// (set) Token: 0x0600BC17 RID: 48151 RVA: 0x0030246C File Offset: 0x0030066C
		public unsafe bool EndIsLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_EndIsLocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_EndIsLocked)) = value;
			}
		}

		// Token: 0x17004318 RID: 17176
		// (get) Token: 0x0600BC18 RID: 48152 RVA: 0x00302490 File Offset: 0x00300690
		// (set) Token: 0x0600BC19 RID: 48153 RVA: 0x003024B8 File Offset: 0x003006B8
		public unsafe bool PullingBelt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_PullingBelt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_PullingBelt)) = value;
			}
		}

		// Token: 0x17004319 RID: 17177
		// (get) Token: 0x0600BC1A RID: 48154 RVA: 0x003024DC File Offset: 0x003006DC
		// (set) Token: 0x0600BC1B RID: 48155 RVA: 0x00302510 File Offset: 0x00300710
		public unsafe Action JobComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_JobComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Action(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_JobComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700431A RID: 17178
		// (get) Token: 0x0600BC1C RID: 48156 RVA: 0x00302538 File Offset: 0x00300738
		// (set) Token: 0x0600BC1D RID: 48157 RVA: 0x00302560 File Offset: 0x00300760
		public unsafe float _segmentLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__segmentLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__segmentLength)) = value;
			}
		}

		// Token: 0x1700431B RID: 17179
		// (get) Token: 0x0600BC1E RID: 48158 RVA: 0x00302584 File Offset: 0x00300784
		// (set) Token: 0x0600BC1F RID: 48159 RVA: 0x003025B8 File Offset: 0x003007B8
		public unsafe Il2CppReferenceArray<Transform> _boxColliderTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__boxColliderTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__boxColliderTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700431C RID: 17180
		// (get) Token: 0x0600BC20 RID: 48160 RVA: 0x003025E0 File Offset: 0x003007E0
		// (set) Token: 0x0600BC21 RID: 48161 RVA: 0x00302608 File Offset: 0x00300808
		public unsafe int _maxSegments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__maxSegments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__maxSegments)) = value;
			}
		}

		// Token: 0x1700431D RID: 17181
		// (get) Token: 0x0600BC22 RID: 48162 RVA: 0x0030262C File Offset: 0x0030082C
		// (set) Token: 0x0600BC23 RID: 48163 RVA: 0x00302654 File Offset: 0x00300854
		public unsafe int _constraintLoops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__constraintLoops);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__constraintLoops)) = value;
			}
		}

		// Token: 0x1700431E RID: 17182
		// (get) Token: 0x0600BC24 RID: 48164 RVA: 0x00302678 File Offset: 0x00300878
		// (set) Token: 0x0600BC25 RID: 48165 RVA: 0x003026A0 File Offset: 0x003008A0
		public unsafe float _gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__gravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__gravity)) = value;
			}
		}

		// Token: 0x1700431F RID: 17183
		// (get) Token: 0x0600BC26 RID: 48166 RVA: 0x003026C4 File Offset: 0x003008C4
		// (set) Token: 0x0600BC27 RID: 48167 RVA: 0x003026F8 File Offset: 0x003008F8
		public unsafe LineRenderer _lineRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__lineRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new LineRenderer(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__lineRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004320 RID: 17184
		// (get) Token: 0x0600BC28 RID: 48168 RVA: 0x00302720 File Offset: 0x00300920
		// (set) Token: 0x0600BC29 RID: 48169 RVA: 0x00302748 File Offset: 0x00300948
		public unsafe bool _lockX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__lockX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__lockX)) = value;
			}
		}

		// Token: 0x17004321 RID: 17185
		// (get) Token: 0x0600BC2A RID: 48170 RVA: 0x0030276C File Offset: 0x0030096C
		// (set) Token: 0x0600BC2B RID: 48171 RVA: 0x00302794 File Offset: 0x00300994
		public unsafe bool _lockY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__lockY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__lockY)) = value;
			}
		}

		// Token: 0x17004322 RID: 17186
		// (get) Token: 0x0600BC2C RID: 48172 RVA: 0x003027B8 File Offset: 0x003009B8
		// (set) Token: 0x0600BC2D RID: 48173 RVA: 0x003027E0 File Offset: 0x003009E0
		public unsafe bool _lockZ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__lockZ);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__lockZ)) = value;
			}
		}

		// Token: 0x17004323 RID: 17187
		// (get) Token: 0x0600BC2E RID: 48174 RVA: 0x00302804 File Offset: 0x00300A04
		// (set) Token: 0x0600BC2F RID: 48175 RVA: 0x00302838 File Offset: 0x00300A38
		public unsafe Transform _ropeStartTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__ropeStartTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__ropeStartTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004324 RID: 17188
		// (get) Token: 0x0600BC30 RID: 48176 RVA: 0x00302860 File Offset: 0x00300A60
		// (set) Token: 0x0600BC31 RID: 48177 RVA: 0x00302894 File Offset: 0x00300A94
		public unsafe Transform _ropeEndTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__ropeEndTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__ropeEndTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004325 RID: 17189
		// (get) Token: 0x0600BC32 RID: 48178 RVA: 0x003028BC File Offset: 0x00300ABC
		// (set) Token: 0x0600BC33 RID: 48179 RVA: 0x003028E4 File Offset: 0x00300AE4
		public unsafe float _currentBeltLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__currentBeltLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__currentBeltLength)) = value;
			}
		}

		// Token: 0x17004326 RID: 17190
		// (get) Token: 0x0600BC34 RID: 48180 RVA: 0x00302908 File Offset: 0x00300B08
		// (set) Token: 0x0600BC35 RID: 48181 RVA: 0x00302930 File Offset: 0x00300B30
		public unsafe bool _hasLineRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__hasLineRenderer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__hasLineRenderer)) = value;
			}
		}

		// Token: 0x17004327 RID: 17191
		// (get) Token: 0x0600BC36 RID: 48182 RVA: 0x00302954 File Offset: 0x00300B54
		// (set) Token: 0x0600BC37 RID: 48183 RVA: 0x0030297C File Offset: 0x00300B7C
		public unsafe float _maxBeltPull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__maxBeltPull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__maxBeltPull)) = value;
			}
		}

		// Token: 0x17004328 RID: 17192
		// (get) Token: 0x0600BC38 RID: 48184 RVA: 0x003029A0 File Offset: 0x00300BA0
		// (set) Token: 0x0600BC39 RID: 48185 RVA: 0x003029C8 File Offset: 0x00300BC8
		public unsafe Vector3 forceGravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_forceGravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_forceGravity)) = value;
			}
		}

		// Token: 0x17004329 RID: 17193
		// (get) Token: 0x0600BC3A RID: 48186 RVA: 0x003029EC File Offset: 0x00300BEC
		// (set) Token: 0x0600BC3B RID: 48187 RVA: 0x00302A1E File Offset: 0x00300C1E
		public NativeArray<Matrix4x4> _nativeLocalToWorldArray
		{
			get
			{
				IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__nativeLocalToWorldArray);
				return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, data));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__nativeLocalToWorldArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700432A RID: 17194
		// (get) Token: 0x0600BC3C RID: 48188 RVA: 0x00302A54 File Offset: 0x00300C54
		// (set) Token: 0x0600BC3D RID: 48189 RVA: 0x00302A86 File Offset: 0x00300C86
		public NativeArray<Matrix4x4> _nativeWorldToLocalArray
		{
			get
			{
				IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__nativeWorldToLocalArray);
				return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, data));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__nativeWorldToLocalArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700432B RID: 17195
		// (get) Token: 0x0600BC3E RID: 48190 RVA: 0x00302ABC File Offset: 0x00300CBC
		// (set) Token: 0x0600BC3F RID: 48191 RVA: 0x00302AE4 File Offset: 0x00300CE4
		public unsafe TransformAccessArray _nativeBoxColliderTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__nativeBoxColliderTransforms);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__nativeBoxColliderTransforms)) = value;
			}
		}

		// Token: 0x1700432C RID: 17196
		// (get) Token: 0x0600BC40 RID: 48192 RVA: 0x00302B08 File Offset: 0x00300D08
		// (set) Token: 0x0600BC41 RID: 48193 RVA: 0x00302B3A File Offset: 0x00300D3A
		public NativeArray<Vector3> _lockedAxisStart
		{
			get
			{
				IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__lockedAxisStart);
				return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, data));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__lockedAxisStart), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700432D RID: 17197
		// (get) Token: 0x0600BC42 RID: 48194 RVA: 0x00302B70 File Offset: 0x00300D70
		// (set) Token: 0x0600BC43 RID: 48195 RVA: 0x00302BA2 File Offset: 0x00300DA2
		public NativeArray<Vector3> _lockedAxisEnd
		{
			get
			{
				IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__lockedAxisEnd);
				return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, data));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__lockedAxisEnd), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700432E RID: 17198
		// (get) Token: 0x0600BC44 RID: 48196 RVA: 0x00302BD8 File Offset: 0x00300DD8
		// (set) Token: 0x0600BC45 RID: 48197 RVA: 0x00302C00 File Offset: 0x00300E00
		public unsafe int _verletBoxColliderCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__verletBoxColliderCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__verletBoxColliderCount)) = value;
			}
		}

		// Token: 0x1700432F RID: 17199
		// (get) Token: 0x0600BC46 RID: 48198 RVA: 0x00302C24 File Offset: 0x00300E24
		// (set) Token: 0x0600BC47 RID: 48199 RVA: 0x00302C4C File Offset: 0x00300E4C
		public unsafe JobHandle _jobHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__jobHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__jobHandle)) = value;
			}
		}

		// Token: 0x17004330 RID: 17200
		// (get) Token: 0x0600BC48 RID: 48200 RVA: 0x00302C70 File Offset: 0x00300E70
		// (set) Token: 0x0600BC49 RID: 48201 RVA: 0x00302C98 File Offset: 0x00300E98
		public unsafe float accumulator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_accumulator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr_accumulator)) = value;
			}
		}

		// Token: 0x17004331 RID: 17201
		// (get) Token: 0x0600BC4A RID: 48202 RVA: 0x00302CBC File Offset: 0x00300EBC
		// (set) Token: 0x0600BC4B RID: 48203 RVA: 0x00302CF0 File Offset: 0x00300EF0
		public unsafe Transform _worldSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__worldSpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__worldSpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004332 RID: 17202
		// (get) Token: 0x0600BC4C RID: 48204 RVA: 0x00302D18 File Offset: 0x00300F18
		// (set) Token: 0x0600BC4D RID: 48205 RVA: 0x00302D40 File Offset: 0x00300F40
		public unsafe bool _isInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__isInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__isInitialized)) = value;
			}
		}

		// Token: 0x17004333 RID: 17203
		// (get) Token: 0x0600BC4E RID: 48206 RVA: 0x00302D64 File Offset: 0x00300F64
		// (set) Token: 0x0600BC4F RID: 48207 RVA: 0x00302D8C File Offset: 0x00300F8C
		public unsafe Vector3 _ropePosPrevFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__ropePosPrevFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__ropePosPrevFrame)) = value;
			}
		}

		// Token: 0x17004334 RID: 17204
		// (get) Token: 0x0600BC50 RID: 48208 RVA: 0x00302DB0 File Offset: 0x00300FB0
		// (set) Token: 0x0600BC51 RID: 48209 RVA: 0x00302DD8 File Offset: 0x00300FD8
		public unsafe bool _ManagedUpdateRemoval_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField)) = value;
			}
		}

		// Token: 0x0400788D RID: 30861
		private static readonly IntPtr NativeFieldInfoPtr__segments;

		// Token: 0x0400788E RID: 30862
		private static readonly IntPtr NativeFieldInfoPtr_CurrentSegmentCount;

		// Token: 0x0400788F RID: 30863
		private static readonly IntPtr NativeFieldInfoPtr_StartIsLocked;

		// Token: 0x04007890 RID: 30864
		private static readonly IntPtr NativeFieldInfoPtr_EndIsLocked;

		// Token: 0x04007891 RID: 30865
		private static readonly IntPtr NativeFieldInfoPtr_PullingBelt;

		// Token: 0x04007892 RID: 30866
		private static readonly IntPtr NativeFieldInfoPtr_JobComplete;

		// Token: 0x04007893 RID: 30867
		private static readonly IntPtr NativeFieldInfoPtr__segmentLength;

		// Token: 0x04007894 RID: 30868
		private static readonly IntPtr NativeFieldInfoPtr__boxColliderTransforms;

		// Token: 0x04007895 RID: 30869
		private static readonly IntPtr NativeFieldInfoPtr__maxSegments;

		// Token: 0x04007896 RID: 30870
		private static readonly IntPtr NativeFieldInfoPtr__constraintLoops;

		// Token: 0x04007897 RID: 30871
		private static readonly IntPtr NativeFieldInfoPtr__gravity;

		// Token: 0x04007898 RID: 30872
		private static readonly IntPtr NativeFieldInfoPtr__lineRenderer;

		// Token: 0x04007899 RID: 30873
		private static readonly IntPtr NativeFieldInfoPtr__lockX;

		// Token: 0x0400789A RID: 30874
		private static readonly IntPtr NativeFieldInfoPtr__lockY;

		// Token: 0x0400789B RID: 30875
		private static readonly IntPtr NativeFieldInfoPtr__lockZ;

		// Token: 0x0400789C RID: 30876
		private static readonly IntPtr NativeFieldInfoPtr__ropeStartTransform;

		// Token: 0x0400789D RID: 30877
		private static readonly IntPtr NativeFieldInfoPtr__ropeEndTransform;

		// Token: 0x0400789E RID: 30878
		private static readonly IntPtr NativeFieldInfoPtr__currentBeltLength;

		// Token: 0x0400789F RID: 30879
		private static readonly IntPtr NativeFieldInfoPtr__hasLineRenderer;

		// Token: 0x040078A0 RID: 30880
		private static readonly IntPtr NativeFieldInfoPtr__maxBeltPull;

		// Token: 0x040078A1 RID: 30881
		private static readonly IntPtr NativeFieldInfoPtr_forceGravity;

		// Token: 0x040078A2 RID: 30882
		private static readonly IntPtr NativeFieldInfoPtr__nativeLocalToWorldArray;

		// Token: 0x040078A3 RID: 30883
		private static readonly IntPtr NativeFieldInfoPtr__nativeWorldToLocalArray;

		// Token: 0x040078A4 RID: 30884
		private static readonly IntPtr NativeFieldInfoPtr__nativeBoxColliderTransforms;

		// Token: 0x040078A5 RID: 30885
		private static readonly IntPtr NativeFieldInfoPtr__lockedAxisStart;

		// Token: 0x040078A6 RID: 30886
		private static readonly IntPtr NativeFieldInfoPtr__lockedAxisEnd;

		// Token: 0x040078A7 RID: 30887
		private static readonly IntPtr NativeFieldInfoPtr__verletBoxColliderCount;

		// Token: 0x040078A8 RID: 30888
		private static readonly IntPtr NativeFieldInfoPtr__jobHandle;

		// Token: 0x040078A9 RID: 30889
		private static readonly IntPtr NativeFieldInfoPtr_accumulator;

		// Token: 0x040078AA RID: 30890
		private static readonly IntPtr NativeFieldInfoPtr__worldSpace;

		// Token: 0x040078AB RID: 30891
		private static readonly IntPtr NativeFieldInfoPtr__isInitialized;

		// Token: 0x040078AC RID: 30892
		private static readonly IntPtr NativeFieldInfoPtr__ropePosPrevFrame;

		// Token: 0x040078AD RID: 30893
		private static readonly IntPtr NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField;

		// Token: 0x040078AE RID: 30894
		private static readonly IntPtr NativeMethodInfoPtr_get_Segments_Public_get_NativeArray_1_VerletRopeSegment_0;

		// Token: 0x040078AF RID: 30895
		private static readonly IntPtr NativeMethodInfoPtr_get_RopeStartTransform_Public_get_Transform_0;

		// Token: 0x040078B0 RID: 30896
		private static readonly IntPtr NativeMethodInfoPtr_get_RopeEndTransform_Public_get_Transform_0;

		// Token: 0x040078B1 RID: 30897
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040078B2 RID: 30898
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x040078B3 RID: 30899
		private static readonly IntPtr NativeMethodInfoPtr_SafeArrayDispose_Private_Void_NativeArray_1_T_0;

		// Token: 0x040078B4 RID: 30900
		private static readonly IntPtr NativeMethodInfoPtr_SafeArrayDispose_Private_Void_TransformAccessArray_0;

		// Token: 0x040078B5 RID: 30901
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040078B6 RID: 30902
		private static readonly IntPtr NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0;

		// Token: 0x040078B7 RID: 30903
		private static readonly IntPtr NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040078B8 RID: 30904
		private static readonly IntPtr NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040078B9 RID: 30905
		private static readonly IntPtr NativeMethodInfoPtr_BeginSimulation_Public_Void_0;

		// Token: 0x040078BA RID: 30906
		private static readonly IntPtr NativeMethodInfoPtr_EndSimulation_Public_Void_0;

		// Token: 0x040078BB RID: 30907
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Private_Void_Single_0;

		// Token: 0x040078BC RID: 30908
		private static readonly IntPtr NativeMethodInfoPtr_SegmentMovement_Private_Static_Void_NativeArray_1_Int32_NativeArray_1_VerletRopeSegment_Single_Vector3_Boolean_Boolean_Boolean_Vector3_0;

		// Token: 0x040078BD RID: 30909
		private static readonly IntPtr NativeMethodInfoPtr_LockStartAndEndAxis_Private_Static_Void_Vector3_Vector3_NativeArray_1_Vector3_NativeArray_1_Vector3_Boolean_Boolean_Boolean_0;

		// Token: 0x040078BE RID: 30910
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBeltPull_Private_Static_Void_Boolean_NativeArray_1_Vector3_NativeArray_1_Vector3_Single_Single_NativeArray_1_Int32_Single_NativeArray_1_VerletRopeSegment_Vector3_0;

		// Token: 0x040078BF RID: 30911
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLockAxisConstraints_Private_Static_Void_Int32_Boolean_Boolean_Boolean_NativeArray_1_VerletRopeSegment_0;

		// Token: 0x040078C0 RID: 30912
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStartEndConstraints_Private_Static_Void_NativeArray_1_Int32_NativeArray_1_VerletRopeSegment_Boolean_Boolean_NativeArray_1_Vector3_NativeArray_1_Vector3_0;

		// Token: 0x040078C1 RID: 30913
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBoxCollision_Private_Static_Void_Int32_Matrix4x4_Matrix4x4_NativeArray_1_Matrix4x4_NativeArray_1_Matrix4x4_NativeArray_1_VerletRopeSegment_0;

		// Token: 0x040078C2 RID: 30914
		private static readonly IntPtr NativeMethodInfoPtr_ResetAllSegments_Private_Void_0;

		// Token: 0x040078C3 RID: 30915
		private static readonly IntPtr NativeMethodInfoPtr_DrawRope_Private_Void_0;

		// Token: 0x040078C4 RID: 30916
		private static readonly IntPtr NativeMethodInfoPtr_LockVector3_Private_Static_Vector3_Vector3_Boolean_Boolean_Boolean_0;

		// Token: 0x040078C5 RID: 30917
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040078C6 RID: 30918
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Void_0;

		// Token: 0x040078C7 RID: 30919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008FB RID: 2299
		[StructLayout(0)]
		public sealed class RopeSimulationJob : ValueType
		{
			// Token: 0x0600BC52 RID: 48210 RVA: 0x00302DFC File Offset: 0x00300FFC
			[CallerCount(0)]
			public unsafe void Execute()
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.RopeSimulationJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600BC53 RID: 48211 RVA: 0x00302E3C File Offset: 0x0030103C
			// Note: this type is marked as 'beforefieldinit'.
			static RopeSimulationJob()
			{
				Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "RopeSimulationJob");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr);
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_CurrentSegmentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "CurrentSegmentCount");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_Segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "Segments");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_DT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "DT");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_ForceGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "ForceGravity");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "LockX");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "LockY");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "LockZ");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_RopeStartTransformPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "RopeStartTransformPosition");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_RopeEndTransformPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "RopeEndTransformPosition");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockedAxisStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "LockedAxisStart");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockedAxisEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "LockedAxisEnd");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_PullingBelt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "PullingBelt");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_RopeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "RopeVelocity");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_MaxBeltPull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "MaxBeltPull");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_CurrentBeltLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "CurrentBeltLength");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_SegmentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "SegmentLength");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_StartIsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "StartIsLocked");
				VerletRope.RopeSimulationJob.NativeFieldInfoPtr_EndIsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, "EndIsLocked");
				VerletRope.RopeSimulationJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, 100678616);
			}

			// Token: 0x0600BC54 RID: 48212 RVA: 0x0002717B File Offset: 0x0002537B
			public RopeSimulationJob(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17004339 RID: 17209
			// (get) Token: 0x0600BC55 RID: 48213 RVA: 0x00302FE3 File Offset: 0x003011E3
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr));
				}
			}

			// Token: 0x0600BC56 RID: 48214 RVA: 0x00302FF4 File Offset: 0x003011F4
			public unsafe RopeSimulationJob()
			{
				IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, (UIntPtr)0)];
				base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VerletRope.RopeSimulationJob>.NativeClassPtr, data));
			}

			// Token: 0x1700433A RID: 17210
			// (get) Token: 0x0600BC57 RID: 48215 RVA: 0x00303024 File Offset: 0x00301224
			// (set) Token: 0x0600BC58 RID: 48216 RVA: 0x00303056 File Offset: 0x00301256
			public NativeArray<int> CurrentSegmentCount
			{
				get
				{
					IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_CurrentSegmentCount);
					return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, data));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_CurrentSegmentCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700433B RID: 17211
			// (get) Token: 0x0600BC59 RID: 48217 RVA: 0x0030308C File Offset: 0x0030128C
			// (set) Token: 0x0600BC5A RID: 48218 RVA: 0x003030BE File Offset: 0x003012BE
			public NativeArray<VerletRopeSegment> Segments
			{
				get
				{
					IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_Segments);
					return new NativeArray<VerletRopeSegment>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<VerletRopeSegment>>.NativeClassPtr, data));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_Segments), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<VerletRopeSegment>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700433C RID: 17212
			// (get) Token: 0x0600BC5B RID: 48219 RVA: 0x003030F4 File Offset: 0x003012F4
			// (set) Token: 0x0600BC5C RID: 48220 RVA: 0x0030311C File Offset: 0x0030131C
			public unsafe float DT
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_DT);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_DT)) = value;
				}
			}

			// Token: 0x1700433D RID: 17213
			// (get) Token: 0x0600BC5D RID: 48221 RVA: 0x00303140 File Offset: 0x00301340
			// (set) Token: 0x0600BC5E RID: 48222 RVA: 0x00303168 File Offset: 0x00301368
			public unsafe Vector3 ForceGravity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_ForceGravity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_ForceGravity)) = value;
				}
			}

			// Token: 0x1700433E RID: 17214
			// (get) Token: 0x0600BC5F RID: 48223 RVA: 0x0030318C File Offset: 0x0030138C
			// (set) Token: 0x0600BC60 RID: 48224 RVA: 0x003031B4 File Offset: 0x003013B4
			public unsafe bool LockX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockX)) = value;
				}
			}

			// Token: 0x1700433F RID: 17215
			// (get) Token: 0x0600BC61 RID: 48225 RVA: 0x003031D8 File Offset: 0x003013D8
			// (set) Token: 0x0600BC62 RID: 48226 RVA: 0x00303200 File Offset: 0x00301400
			public unsafe bool LockY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockY)) = value;
				}
			}

			// Token: 0x17004340 RID: 17216
			// (get) Token: 0x0600BC63 RID: 48227 RVA: 0x00303224 File Offset: 0x00301424
			// (set) Token: 0x0600BC64 RID: 48228 RVA: 0x0030324C File Offset: 0x0030144C
			public unsafe bool LockZ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockZ);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockZ)) = value;
				}
			}

			// Token: 0x17004341 RID: 17217
			// (get) Token: 0x0600BC65 RID: 48229 RVA: 0x00303270 File Offset: 0x00301470
			// (set) Token: 0x0600BC66 RID: 48230 RVA: 0x00303298 File Offset: 0x00301498
			public unsafe Vector3 RopeStartTransformPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_RopeStartTransformPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_RopeStartTransformPosition)) = value;
				}
			}

			// Token: 0x17004342 RID: 17218
			// (get) Token: 0x0600BC67 RID: 48231 RVA: 0x003032BC File Offset: 0x003014BC
			// (set) Token: 0x0600BC68 RID: 48232 RVA: 0x003032E4 File Offset: 0x003014E4
			public unsafe Vector3 RopeEndTransformPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_RopeEndTransformPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_RopeEndTransformPosition)) = value;
				}
			}

			// Token: 0x17004343 RID: 17219
			// (get) Token: 0x0600BC69 RID: 48233 RVA: 0x00303308 File Offset: 0x00301508
			// (set) Token: 0x0600BC6A RID: 48234 RVA: 0x0030333A File Offset: 0x0030153A
			public NativeArray<Vector3> LockedAxisStart
			{
				get
				{
					IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockedAxisStart);
					return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, data));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockedAxisStart), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004344 RID: 17220
			// (get) Token: 0x0600BC6B RID: 48235 RVA: 0x00303370 File Offset: 0x00301570
			// (set) Token: 0x0600BC6C RID: 48236 RVA: 0x003033A2 File Offset: 0x003015A2
			public NativeArray<Vector3> LockedAxisEnd
			{
				get
				{
					IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockedAxisEnd);
					return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, data));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_LockedAxisEnd), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004345 RID: 17221
			// (get) Token: 0x0600BC6D RID: 48237 RVA: 0x003033D8 File Offset: 0x003015D8
			// (set) Token: 0x0600BC6E RID: 48238 RVA: 0x00303400 File Offset: 0x00301600
			public unsafe bool PullingBelt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_PullingBelt);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_PullingBelt)) = value;
				}
			}

			// Token: 0x17004346 RID: 17222
			// (get) Token: 0x0600BC6F RID: 48239 RVA: 0x00303424 File Offset: 0x00301624
			// (set) Token: 0x0600BC70 RID: 48240 RVA: 0x0030344C File Offset: 0x0030164C
			public unsafe Vector3 RopeVelocity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_RopeVelocity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_RopeVelocity)) = value;
				}
			}

			// Token: 0x17004347 RID: 17223
			// (get) Token: 0x0600BC71 RID: 48241 RVA: 0x00303470 File Offset: 0x00301670
			// (set) Token: 0x0600BC72 RID: 48242 RVA: 0x00303498 File Offset: 0x00301698
			public unsafe float MaxBeltPull
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_MaxBeltPull);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_MaxBeltPull)) = value;
				}
			}

			// Token: 0x17004348 RID: 17224
			// (get) Token: 0x0600BC73 RID: 48243 RVA: 0x003034BC File Offset: 0x003016BC
			// (set) Token: 0x0600BC74 RID: 48244 RVA: 0x003034E4 File Offset: 0x003016E4
			public unsafe float CurrentBeltLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_CurrentBeltLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_CurrentBeltLength)) = value;
				}
			}

			// Token: 0x17004349 RID: 17225
			// (get) Token: 0x0600BC75 RID: 48245 RVA: 0x00303508 File Offset: 0x00301708
			// (set) Token: 0x0600BC76 RID: 48246 RVA: 0x00303530 File Offset: 0x00301730
			public unsafe float SegmentLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_SegmentLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_SegmentLength)) = value;
				}
			}

			// Token: 0x1700434A RID: 17226
			// (get) Token: 0x0600BC77 RID: 48247 RVA: 0x00303554 File Offset: 0x00301754
			// (set) Token: 0x0600BC78 RID: 48248 RVA: 0x0030357C File Offset: 0x0030177C
			public unsafe bool StartIsLocked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_StartIsLocked);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_StartIsLocked)) = value;
				}
			}

			// Token: 0x1700434B RID: 17227
			// (get) Token: 0x0600BC79 RID: 48249 RVA: 0x003035A0 File Offset: 0x003017A0
			// (set) Token: 0x0600BC7A RID: 48250 RVA: 0x003035C8 File Offset: 0x003017C8
			public unsafe bool EndIsLocked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_EndIsLocked);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.RopeSimulationJob.NativeFieldInfoPtr_EndIsLocked)) = value;
				}
			}

			// Token: 0x040078C8 RID: 30920
			private static readonly IntPtr NativeFieldInfoPtr_CurrentSegmentCount;

			// Token: 0x040078C9 RID: 30921
			private static readonly IntPtr NativeFieldInfoPtr_Segments;

			// Token: 0x040078CA RID: 30922
			private static readonly IntPtr NativeFieldInfoPtr_DT;

			// Token: 0x040078CB RID: 30923
			private static readonly IntPtr NativeFieldInfoPtr_ForceGravity;

			// Token: 0x040078CC RID: 30924
			private static readonly IntPtr NativeFieldInfoPtr_LockX;

			// Token: 0x040078CD RID: 30925
			private static readonly IntPtr NativeFieldInfoPtr_LockY;

			// Token: 0x040078CE RID: 30926
			private static readonly IntPtr NativeFieldInfoPtr_LockZ;

			// Token: 0x040078CF RID: 30927
			private static readonly IntPtr NativeFieldInfoPtr_RopeStartTransformPosition;

			// Token: 0x040078D0 RID: 30928
			private static readonly IntPtr NativeFieldInfoPtr_RopeEndTransformPosition;

			// Token: 0x040078D1 RID: 30929
			private static readonly IntPtr NativeFieldInfoPtr_LockedAxisStart;

			// Token: 0x040078D2 RID: 30930
			private static readonly IntPtr NativeFieldInfoPtr_LockedAxisEnd;

			// Token: 0x040078D3 RID: 30931
			private static readonly IntPtr NativeFieldInfoPtr_PullingBelt;

			// Token: 0x040078D4 RID: 30932
			private static readonly IntPtr NativeFieldInfoPtr_RopeVelocity;

			// Token: 0x040078D5 RID: 30933
			private static readonly IntPtr NativeFieldInfoPtr_MaxBeltPull;

			// Token: 0x040078D6 RID: 30934
			private static readonly IntPtr NativeFieldInfoPtr_CurrentBeltLength;

			// Token: 0x040078D7 RID: 30935
			private static readonly IntPtr NativeFieldInfoPtr_SegmentLength;

			// Token: 0x040078D8 RID: 30936
			private static readonly IntPtr NativeFieldInfoPtr_StartIsLocked;

			// Token: 0x040078D9 RID: 30937
			private static readonly IntPtr NativeFieldInfoPtr_EndIsLocked;

			// Token: 0x040078DA RID: 30938
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020008FC RID: 2300
		[StructLayout(0)]
		public sealed class PrepareVerletConstraintsJob : ValueType
		{
			// Token: 0x0600BC7B RID: 48251 RVA: 0x003035EC File Offset: 0x003017EC
			[CallerCount(0)]
			public unsafe void Execute(int index, TransformAccess transform)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transform;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.PrepareVerletConstraintsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600BC7C RID: 48252 RVA: 0x00303654 File Offset: 0x00301854
			// Note: this type is marked as 'beforefieldinit'.
			static PrepareVerletConstraintsJob()
			{
				Il2CppClassPointerStore<VerletRope.PrepareVerletConstraintsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "PrepareVerletConstraintsJob");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerletRope.PrepareVerletConstraintsJob>.NativeClassPtr);
				VerletRope.PrepareVerletConstraintsJob.NativeFieldInfoPtr_localToWorldArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.PrepareVerletConstraintsJob>.NativeClassPtr, "localToWorldArray");
				VerletRope.PrepareVerletConstraintsJob.NativeFieldInfoPtr_worldToLocalArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.PrepareVerletConstraintsJob>.NativeClassPtr, "worldToLocalArray");
				VerletRope.PrepareVerletConstraintsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope.PrepareVerletConstraintsJob>.NativeClassPtr, 100678617);
			}

			// Token: 0x0600BC7D RID: 48253 RVA: 0x0002717B File Offset: 0x0002537B
			public PrepareVerletConstraintsJob(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x1700434C RID: 17228
			// (get) Token: 0x0600BC7E RID: 48254 RVA: 0x003036BB File Offset: 0x003018BB
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VerletRope.PrepareVerletConstraintsJob>.NativeClassPtr));
				}
			}

			// Token: 0x0600BC7F RID: 48255 RVA: 0x003036CC File Offset: 0x003018CC
			public unsafe PrepareVerletConstraintsJob()
			{
				IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VerletRope.PrepareVerletConstraintsJob>.NativeClassPtr, (UIntPtr)0)];
				base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VerletRope.PrepareVerletConstraintsJob>.NativeClassPtr, data));
			}

			// Token: 0x1700434D RID: 17229
			// (get) Token: 0x0600BC80 RID: 48256 RVA: 0x003036FC File Offset: 0x003018FC
			// (set) Token: 0x0600BC81 RID: 48257 RVA: 0x0030372E File Offset: 0x0030192E
			public NativeArray<Matrix4x4> localToWorldArray
			{
				get
				{
					IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.PrepareVerletConstraintsJob.NativeFieldInfoPtr_localToWorldArray);
					return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, data));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.PrepareVerletConstraintsJob.NativeFieldInfoPtr_localToWorldArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700434E RID: 17230
			// (get) Token: 0x0600BC82 RID: 48258 RVA: 0x00303764 File Offset: 0x00301964
			// (set) Token: 0x0600BC83 RID: 48259 RVA: 0x00303796 File Offset: 0x00301996
			public NativeArray<Matrix4x4> worldToLocalArray
			{
				get
				{
					IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.PrepareVerletConstraintsJob.NativeFieldInfoPtr_worldToLocalArray);
					return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, data));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.PrepareVerletConstraintsJob.NativeFieldInfoPtr_worldToLocalArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040078DB RID: 30939
			private static readonly IntPtr NativeFieldInfoPtr_localToWorldArray;

			// Token: 0x040078DC RID: 30940
			private static readonly IntPtr NativeFieldInfoPtr_worldToLocalArray;

			// Token: 0x040078DD RID: 30941
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0;
		}

		// Token: 0x020008FD RID: 2301
		[StructLayout(0)]
		public sealed class VerletConstraintJob : ValueType
		{
			// Token: 0x0600BC84 RID: 48260 RVA: 0x003037CC File Offset: 0x003019CC
			[CallerCount(0)]
			public unsafe void Execute()
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerletRope.VerletConstraintJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600BC85 RID: 48261 RVA: 0x0030380C File Offset: 0x00301A0C
			// Note: this type is marked as 'beforefieldinit'.
			static VerletConstraintJob()
			{
				Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VerletRope>.NativeClassPtr, "VerletConstraintJob");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr);
				VerletRope.VerletConstraintJob.NativeFieldInfoPtr_segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr, "segments");
				VerletRope.VerletConstraintJob.NativeFieldInfoPtr_segmentLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr, "segmentLength");
				VerletRope.VerletConstraintJob.NativeFieldInfoPtr_startIsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr, "startIsLocked");
				VerletRope.VerletConstraintJob.NativeFieldInfoPtr_endIsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr, "endIsLocked");
				VerletRope.VerletConstraintJob.NativeFieldInfoPtr_currentSegmentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr, "currentSegmentCount");
				VerletRope.VerletConstraintJob.NativeFieldInfoPtr_ropeLocalToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr, "ropeLocalToWorld");
				VerletRope.VerletConstraintJob.NativeFieldInfoPtr_ropeWorldToLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr, "ropeWorldToLocal");
				VerletRope.VerletConstraintJob.NativeFieldInfoPtr_localToWorldArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr, "localToWorldArray");
				VerletRope.VerletConstraintJob.NativeFieldInfoPtr_worldToLocalArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr, "worldToLocalArray");
				VerletRope.VerletConstraintJob.NativeFieldInfoPtr_constraintLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr, "constraintLoops");
				VerletRope.VerletConstraintJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr, 100678618);
			}

			// Token: 0x0600BC86 RID: 48262 RVA: 0x0002717B File Offset: 0x0002537B
			public VerletConstraintJob(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x1700434F RID: 17231
			// (get) Token: 0x0600BC87 RID: 48263 RVA: 0x00303913 File Offset: 0x00301B13
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr));
				}
			}

			// Token: 0x0600BC88 RID: 48264 RVA: 0x00303924 File Offset: 0x00301B24
			public unsafe VerletConstraintJob()
			{
				IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr, (UIntPtr)0)];
				base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VerletRope.VerletConstraintJob>.NativeClassPtr, data));
			}

			// Token: 0x17004350 RID: 17232
			// (get) Token: 0x0600BC89 RID: 48265 RVA: 0x00303954 File Offset: 0x00301B54
			// (set) Token: 0x0600BC8A RID: 48266 RVA: 0x00303986 File Offset: 0x00301B86
			public NativeArray<VerletRopeSegment> segments
			{
				get
				{
					IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_segments);
					return new NativeArray<VerletRopeSegment>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<VerletRopeSegment>>.NativeClassPtr, data));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_segments), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<VerletRopeSegment>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004351 RID: 17233
			// (get) Token: 0x0600BC8B RID: 48267 RVA: 0x003039BC File Offset: 0x00301BBC
			// (set) Token: 0x0600BC8C RID: 48268 RVA: 0x003039E4 File Offset: 0x00301BE4
			public unsafe float segmentLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_segmentLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_segmentLength)) = value;
				}
			}

			// Token: 0x17004352 RID: 17234
			// (get) Token: 0x0600BC8D RID: 48269 RVA: 0x00303A08 File Offset: 0x00301C08
			// (set) Token: 0x0600BC8E RID: 48270 RVA: 0x00303A30 File Offset: 0x00301C30
			public unsafe bool startIsLocked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_startIsLocked);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_startIsLocked)) = value;
				}
			}

			// Token: 0x17004353 RID: 17235
			// (get) Token: 0x0600BC8F RID: 48271 RVA: 0x00303A54 File Offset: 0x00301C54
			// (set) Token: 0x0600BC90 RID: 48272 RVA: 0x00303A7C File Offset: 0x00301C7C
			public unsafe bool endIsLocked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_endIsLocked);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_endIsLocked)) = value;
				}
			}

			// Token: 0x17004354 RID: 17236
			// (get) Token: 0x0600BC91 RID: 48273 RVA: 0x00303AA0 File Offset: 0x00301CA0
			// (set) Token: 0x0600BC92 RID: 48274 RVA: 0x00303AD2 File Offset: 0x00301CD2
			public NativeArray<int> currentSegmentCount
			{
				get
				{
					IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_currentSegmentCount);
					return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, data));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_currentSegmentCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004355 RID: 17237
			// (get) Token: 0x0600BC93 RID: 48275 RVA: 0x00303B08 File Offset: 0x00301D08
			// (set) Token: 0x0600BC94 RID: 48276 RVA: 0x00303B30 File Offset: 0x00301D30
			public unsafe Matrix4x4 ropeLocalToWorld
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_ropeLocalToWorld);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_ropeLocalToWorld)) = value;
				}
			}

			// Token: 0x17004356 RID: 17238
			// (get) Token: 0x0600BC95 RID: 48277 RVA: 0x00303B54 File Offset: 0x00301D54
			// (set) Token: 0x0600BC96 RID: 48278 RVA: 0x00303B7C File Offset: 0x00301D7C
			public unsafe Matrix4x4 ropeWorldToLocal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_ropeWorldToLocal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_ropeWorldToLocal)) = value;
				}
			}

			// Token: 0x17004357 RID: 17239
			// (get) Token: 0x0600BC97 RID: 48279 RVA: 0x00303BA0 File Offset: 0x00301DA0
			// (set) Token: 0x0600BC98 RID: 48280 RVA: 0x00303BD2 File Offset: 0x00301DD2
			public NativeArray<Matrix4x4> localToWorldArray
			{
				get
				{
					IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_localToWorldArray);
					return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, data));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_localToWorldArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004358 RID: 17240
			// (get) Token: 0x0600BC99 RID: 48281 RVA: 0x00303C08 File Offset: 0x00301E08
			// (set) Token: 0x0600BC9A RID: 48282 RVA: 0x00303C3A File Offset: 0x00301E3A
			public NativeArray<Matrix4x4> worldToLocalArray
			{
				get
				{
					IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_worldToLocalArray);
					return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, data));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_worldToLocalArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004359 RID: 17241
			// (get) Token: 0x0600BC9B RID: 48283 RVA: 0x00303C70 File Offset: 0x00301E70
			// (set) Token: 0x0600BC9C RID: 48284 RVA: 0x00303C98 File Offset: 0x00301E98
			public unsafe int constraintLoops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_constraintLoops);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerletRope.VerletConstraintJob.NativeFieldInfoPtr_constraintLoops)) = value;
				}
			}

			// Token: 0x040078DE RID: 30942
			private static readonly IntPtr NativeFieldInfoPtr_segments;

			// Token: 0x040078DF RID: 30943
			private static readonly IntPtr NativeFieldInfoPtr_segmentLength;

			// Token: 0x040078E0 RID: 30944
			private static readonly IntPtr NativeFieldInfoPtr_startIsLocked;

			// Token: 0x040078E1 RID: 30945
			private static readonly IntPtr NativeFieldInfoPtr_endIsLocked;

			// Token: 0x040078E2 RID: 30946
			private static readonly IntPtr NativeFieldInfoPtr_currentSegmentCount;

			// Token: 0x040078E3 RID: 30947
			private static readonly IntPtr NativeFieldInfoPtr_ropeLocalToWorld;

			// Token: 0x040078E4 RID: 30948
			private static readonly IntPtr NativeFieldInfoPtr_ropeWorldToLocal;

			// Token: 0x040078E5 RID: 30949
			private static readonly IntPtr NativeFieldInfoPtr_localToWorldArray;

			// Token: 0x040078E6 RID: 30950
			private static readonly IntPtr NativeFieldInfoPtr_worldToLocalArray;

			// Token: 0x040078E7 RID: 30951
			private static readonly IntPtr NativeFieldInfoPtr_constraintLoops;

			// Token: 0x040078E8 RID: 30952
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x020008FE RID: 2302
		private sealed class MethodInfoStoreGeneric_SafeArrayDispose_Private_Void_NativeArray_1_T_0<T>
		{
			// Token: 0x040078E9 RID: 30953
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(VerletRope.NativeMethodInfoPtr_SafeArrayDispose_Private_Void_NativeArray_1_T_0, Il2CppClassPointerStore<VerletRope>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
