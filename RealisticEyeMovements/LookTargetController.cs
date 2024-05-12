using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.Events;

namespace RealisticEyeMovements
{
	// Token: 0x0200078A RID: 1930
	public class LookTargetController : MonoBehaviour
	{
		// Token: 0x0600A07E RID: 41086 RVA: 0x00289ED4 File Offset: 0x002880D4
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A07F RID: 41087 RVA: 0x00289F18 File Offset: 0x00288118
		[CallerCount(0)]
		public unsafe void Blink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_Blink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A080 RID: 41088 RVA: 0x00289F5C File Offset: 0x0028815C
		[CallerCount(0)]
		public unsafe void ChangeStateTo(LookTargetController.State newState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newState;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_ChangeStateTo_Private_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A081 RID: 41089 RVA: 0x00289FB0 File Offset: 0x002881B0
		[CallerCount(0)]
		public unsafe Vector3 ChooseNextHeadTargetPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_ChooseNextHeadTargetPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A082 RID: 41090 RVA: 0x0028A000 File Offset: 0x00288200
		[CallerCount(0)]
		public unsafe Transform ChooseNextHeadTargetPOI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_ChooseNextHeadTargetPOI_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}

		// Token: 0x0600A083 RID: 41091 RVA: 0x0028A058 File Offset: 0x00288258
		[CallerCount(0)]
		public unsafe void ClearLookTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_ClearLookTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A084 RID: 41092 RVA: 0x0028A09C File Offset: 0x0028829C
		[CallerCount(0)]
		public unsafe Transform FindPlayerCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_FindPlayerCamera_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}

		// Token: 0x0600A085 RID: 41093 RVA: 0x0028A0F4 File Offset: 0x002882F4
		[CallerCount(0)]
		public unsafe void Initialize(bool lookAroundIdly = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lookAroundIdly;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_Initialize_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A086 RID: 41094 RVA: 0x0028A148 File Offset: 0x00288348
		[CallerCount(0)]
		public unsafe bool IsLookingAtPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_IsLookingAtPlayer_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A087 RID: 41095 RVA: 0x0028A198 File Offset: 0x00288398
		[CallerCount(0)]
		public unsafe bool IsPlayerInView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_IsPlayerInView_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A088 RID: 41096 RVA: 0x0028A1E8 File Offset: 0x002883E8
		[CallerCount(0)]
		public unsafe void LookAtPlayer([Optional] float duration, [Optional] float headLatency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headLatency;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_LookAtPlayer_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A089 RID: 41097 RVA: 0x0028A250 File Offset: 0x00288450
		[CallerCount(0)]
		public unsafe void LookAroundIdly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_LookAroundIdly_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A08A RID: 41098 RVA: 0x0028A294 File Offset: 0x00288494
		[CallerCount(0)]
		public unsafe void LookAtPoiDirectly(Transform poiXform, [Optional] float duration, [Optional] float headLatency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(poiXform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headLatency;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_LookAtPoiDirectly_Public_Void_Transform_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A08B RID: 41099 RVA: 0x0028A314 File Offset: 0x00288514
		[CallerCount(0)]
		public unsafe void LookAtPoiDirectly(Vector3 poi, [Optional] float duration, [Optional] float headLatency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref poi;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headLatency;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_LookAtPoiDirectly_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A08C RID: 41100 RVA: 0x0028A390 File Offset: 0x00288590
		[CallerCount(0)]
		public unsafe void LookAwayFromPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_LookAwayFromPlayer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A08D RID: 41101 RVA: 0x0028A3D4 File Offset: 0x002885D4
		[CallerCount(0)]
		public unsafe void OnCannotGetTargetIntoView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_OnCannotGetTargetIntoView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A08E RID: 41102 RVA: 0x0028A418 File Offset: 0x00288618
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A08F RID: 41103 RVA: 0x0028A45C File Offset: 0x0028865C
		[CallerCount(0)]
		public unsafe void OnTargetDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_OnTargetDestroyed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A090 RID: 41104 RVA: 0x0028A4A0 File Offset: 0x002886A0
		[CallerCount(0)]
		public unsafe void OnTargetLost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_OnTargetLost_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A091 RID: 41105 RVA: 0x0028A4E4 File Offset: 0x002886E4
		[CallerCount(0)]
		public unsafe void OnTargetOutOfSight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_OnTargetOutOfSight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A092 RID: 41106 RVA: 0x0028A528 File Offset: 0x00288728
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A093 RID: 41107 RVA: 0x0028A56C File Offset: 0x0028876C
		[CallerCount(0)]
		public unsafe void UpdateNativeVREyePositions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_UpdateNativeVREyePositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A094 RID: 41108 RVA: 0x0028A5B0 File Offset: 0x002887B0
		[CallerCount(0)]
		public unsafe void UpdatePlayerEyeTransformReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_UpdatePlayerEyeTransformReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A095 RID: 41109 RVA: 0x0028A5F4 File Offset: 0x002887F4
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A096 RID: 41110 RVA: 0x0028A638 File Offset: 0x00288838
		[CallerCount(0)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A097 RID: 41111 RVA: 0x0028A67C File Offset: 0x0028887C
		[CallerCount(0)]
		public unsafe LookTargetController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookTargetController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A098 RID: 41112 RVA: 0x0028A6C8 File Offset: 0x002888C8
		// Note: this type is marked as 'beforefieldinit'.
		static LookTargetController()
		{
			Il2CppClassPointerStore<LookTargetController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RealisticEyeMovements", "LookTargetController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr);
			LookTargetController.NativeFieldInfoPtr_pointsOfInterest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "pointsOfInterest");
			LookTargetController.NativeFieldInfoPtr_lookAtPlayerRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "lookAtPlayerRatio");
			LookTargetController.NativeFieldInfoPtr_stareBackFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "stareBackFactor");
			LookTargetController.NativeFieldInfoPtr_noticePlayerDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "noticePlayerDistance");
			LookTargetController.NativeFieldInfoPtr_personalSpaceDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "personalSpaceDistance");
			LookTargetController.NativeFieldInfoPtr_minLookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "minLookTime");
			LookTargetController.NativeFieldInfoPtr_maxLookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "maxLookTime");
			LookTargetController.NativeFieldInfoPtr_thirdPersonPlayerEyeCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "thirdPersonPlayerEyeCenter");
			LookTargetController.NativeFieldInfoPtr_keepTargetEvenWhenLost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "keepTargetEvenWhenLost");
			LookTargetController.NativeFieldInfoPtr_OffsetCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "OffsetCam");
			LookTargetController.NativeFieldInfoPtr_OnStartLookingAtPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "OnStartLookingAtPlayer");
			LookTargetController.NativeFieldInfoPtr_OnStopLookingAtPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "OnStopLookingAtPlayer");
			LookTargetController.NativeFieldInfoPtr_OnPlayerEntersPersonalSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "OnPlayerEntersPersonalSpace");
			LookTargetController.NativeFieldInfoPtr_OnLookAwayFromShyness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "OnLookAwayFromShyness");
			LookTargetController.NativeFieldInfoPtr_eyeAndHeadAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "eyeAndHeadAnimator");
			LookTargetController.NativeFieldInfoPtr_minLookAtMeTimeToReact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "minLookAtMeTimeToReact");
			LookTargetController.NativeFieldInfoPtr_targetPOI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "targetPOI");
			LookTargetController.NativeFieldInfoPtr_mainCameraXform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "mainCameraXform");
			LookTargetController.NativeFieldInfoPtr_mainCameraParentXform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "mainCameraParentXform");
			LookTargetController.NativeFieldInfoPtr_playerEyeCenterXform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "playerEyeCenterXform");
			LookTargetController.NativeFieldInfoPtr_playerLeftEyeXform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "playerLeftEyeXform");
			LookTargetController.NativeFieldInfoPtr_playerRightEyeXform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "playerRightEyeXform");
			LookTargetController.NativeFieldInfoPtr_usedThirdPersonPlayerEyeCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "usedThirdPersonPlayerEyeCenter");
			LookTargetController.NativeFieldInfoPtr_createdVRParentGO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "createdVRParentGO");
			LookTargetController.NativeFieldInfoPtr_createdPlayerEyeCenterGO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "createdPlayerEyeCenterGO");
			LookTargetController.NativeFieldInfoPtr_createdPlayerLeftEyeGO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "createdPlayerLeftEyeGO");
			LookTargetController.NativeFieldInfoPtr_createdPlayerRightEyeGO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "createdPlayerRightEyeGO");
			LookTargetController.NativeFieldInfoPtr_lastDistanceToPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "lastDistanceToPlayer");
			LookTargetController.NativeFieldInfoPtr_playerLookingAtMeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "playerLookingAtMeTime");
			LookTargetController.NativeFieldInfoPtr_nextChangePOITime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "nextChangePOITime");
			LookTargetController.NativeFieldInfoPtr_stareBackDeadtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "stareBackDeadtime");
			LookTargetController.NativeFieldInfoPtr_timeOfLastNoticeCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "timeOfLastNoticeCheck");
			LookTargetController.NativeFieldInfoPtr_timeOfLastLookBackCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "timeOfLastLookBackCheck");
			LookTargetController.NativeFieldInfoPtr_timeOutsideOfAwarenessZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "timeOutsideOfAwarenessZone");
			LookTargetController.NativeFieldInfoPtr_timeInsidePersonalSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "timeInsidePersonalSpace");
			LookTargetController.NativeFieldInfoPtr_useNativeVRSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "useNativeVRSupport");
			LookTargetController.NativeFieldInfoPtr_useVR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "useVR");
			LookTargetController.NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "isInitialized");
			LookTargetController.NativeFieldInfoPtr_wasInPersonalSpaceLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "wasInPersonalSpaceLastFrame");
			LookTargetController.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, "state");
			LookTargetController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676040);
			LookTargetController.NativeMethodInfoPtr_Blink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676041);
			LookTargetController.NativeMethodInfoPtr_ChangeStateTo_Private_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676042);
			LookTargetController.NativeMethodInfoPtr_ChooseNextHeadTargetPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676043);
			LookTargetController.NativeMethodInfoPtr_ChooseNextHeadTargetPOI_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676044);
			LookTargetController.NativeMethodInfoPtr_ClearLookTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676045);
			LookTargetController.NativeMethodInfoPtr_FindPlayerCamera_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676046);
			LookTargetController.NativeMethodInfoPtr_Initialize_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676047);
			LookTargetController.NativeMethodInfoPtr_IsLookingAtPlayer_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676048);
			LookTargetController.NativeMethodInfoPtr_IsPlayerInView_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676049);
			LookTargetController.NativeMethodInfoPtr_LookAtPlayer_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676050);
			LookTargetController.NativeMethodInfoPtr_LookAroundIdly_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676051);
			LookTargetController.NativeMethodInfoPtr_LookAtPoiDirectly_Public_Void_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676052);
			LookTargetController.NativeMethodInfoPtr_LookAtPoiDirectly_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676053);
			LookTargetController.NativeMethodInfoPtr_LookAwayFromPlayer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676054);
			LookTargetController.NativeMethodInfoPtr_OnCannotGetTargetIntoView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676055);
			LookTargetController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676056);
			LookTargetController.NativeMethodInfoPtr_OnTargetDestroyed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676057);
			LookTargetController.NativeMethodInfoPtr_OnTargetLost_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676058);
			LookTargetController.NativeMethodInfoPtr_OnTargetOutOfSight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676059);
			LookTargetController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676060);
			LookTargetController.NativeMethodInfoPtr_UpdateNativeVREyePositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676061);
			LookTargetController.NativeMethodInfoPtr_UpdatePlayerEyeTransformReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676062);
			LookTargetController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676063);
			LookTargetController.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676064);
			LookTargetController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr, 100676065);
		}

		// Token: 0x0600A099 RID: 41113 RVA: 0x0000210C File Offset: 0x0000030C
		public LookTargetController(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x0600A09A RID: 41114 RVA: 0x0028AC20 File Offset: 0x00288E20
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LookTargetController>.NativeClassPtr));
			}
		}

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x0600A09B RID: 41115 RVA: 0x0028AC34 File Offset: 0x00288E34
		// (set) Token: 0x0600A09C RID: 41116 RVA: 0x0028AC68 File Offset: 0x00288E68
		public unsafe Il2CppReferenceArray<Transform> pointsOfInterest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_pointsOfInterest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_pointsOfInterest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x0600A09D RID: 41117 RVA: 0x0028AC90 File Offset: 0x00288E90
		// (set) Token: 0x0600A09E RID: 41118 RVA: 0x0028ACB8 File Offset: 0x00288EB8
		public unsafe float lookAtPlayerRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_lookAtPlayerRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_lookAtPlayerRatio)) = value;
			}
		}

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x0600A09F RID: 41119 RVA: 0x0028ACDC File Offset: 0x00288EDC
		// (set) Token: 0x0600A0A0 RID: 41120 RVA: 0x0028AD04 File Offset: 0x00288F04
		public unsafe float stareBackFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_stareBackFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_stareBackFactor)) = value;
			}
		}

		// Token: 0x1700398F RID: 14735
		// (get) Token: 0x0600A0A1 RID: 41121 RVA: 0x0028AD28 File Offset: 0x00288F28
		// (set) Token: 0x0600A0A2 RID: 41122 RVA: 0x0028AD50 File Offset: 0x00288F50
		public unsafe float noticePlayerDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_noticePlayerDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_noticePlayerDistance)) = value;
			}
		}

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x0600A0A3 RID: 41123 RVA: 0x0028AD74 File Offset: 0x00288F74
		// (set) Token: 0x0600A0A4 RID: 41124 RVA: 0x0028AD9C File Offset: 0x00288F9C
		public unsafe float personalSpaceDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_personalSpaceDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_personalSpaceDistance)) = value;
			}
		}

		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x0600A0A5 RID: 41125 RVA: 0x0028ADC0 File Offset: 0x00288FC0
		// (set) Token: 0x0600A0A6 RID: 41126 RVA: 0x0028ADE8 File Offset: 0x00288FE8
		public unsafe float minLookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_minLookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_minLookTime)) = value;
			}
		}

		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x0600A0A7 RID: 41127 RVA: 0x0028AE0C File Offset: 0x0028900C
		// (set) Token: 0x0600A0A8 RID: 41128 RVA: 0x0028AE34 File Offset: 0x00289034
		public unsafe float maxLookTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_maxLookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_maxLookTime)) = value;
			}
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x0600A0A9 RID: 41129 RVA: 0x0028AE58 File Offset: 0x00289058
		// (set) Token: 0x0600A0AA RID: 41130 RVA: 0x0028AE8C File Offset: 0x0028908C
		public unsafe Transform thirdPersonPlayerEyeCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_thirdPersonPlayerEyeCenter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_thirdPersonPlayerEyeCenter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x0600A0AB RID: 41131 RVA: 0x0028AEB4 File Offset: 0x002890B4
		// (set) Token: 0x0600A0AC RID: 41132 RVA: 0x0028AEDC File Offset: 0x002890DC
		public unsafe bool keepTargetEvenWhenLost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_keepTargetEvenWhenLost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_keepTargetEvenWhenLost)) = value;
			}
		}

		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x0600A0AD RID: 41133 RVA: 0x0028AF00 File Offset: 0x00289100
		// (set) Token: 0x0600A0AE RID: 41134 RVA: 0x0028AF28 File Offset: 0x00289128
		public unsafe Vector3 OffsetCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_OffsetCam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_OffsetCam)) = value;
			}
		}

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x0600A0AF RID: 41135 RVA: 0x0028AF4C File Offset: 0x0028914C
		// (set) Token: 0x0600A0B0 RID: 41136 RVA: 0x0028AF80 File Offset: 0x00289180
		public unsafe UnityEvent OnStartLookingAtPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_OnStartLookingAtPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new UnityEvent(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_OnStartLookingAtPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003997 RID: 14743
		// (get) Token: 0x0600A0B1 RID: 41137 RVA: 0x0028AFA8 File Offset: 0x002891A8
		// (set) Token: 0x0600A0B2 RID: 41138 RVA: 0x0028AFDC File Offset: 0x002891DC
		public unsafe UnityEvent OnStopLookingAtPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_OnStopLookingAtPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new UnityEvent(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_OnStopLookingAtPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x0600A0B3 RID: 41139 RVA: 0x0028B004 File Offset: 0x00289204
		// (set) Token: 0x0600A0B4 RID: 41140 RVA: 0x0028B038 File Offset: 0x00289238
		public unsafe UnityEvent OnPlayerEntersPersonalSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_OnPlayerEntersPersonalSpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new UnityEvent(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_OnPlayerEntersPersonalSpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x0600A0B5 RID: 41141 RVA: 0x0028B060 File Offset: 0x00289260
		// (set) Token: 0x0600A0B6 RID: 41142 RVA: 0x0028B094 File Offset: 0x00289294
		public unsafe UnityEvent OnLookAwayFromShyness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_OnLookAwayFromShyness);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new UnityEvent(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_OnLookAwayFromShyness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x0600A0B7 RID: 41143 RVA: 0x0028B0BC File Offset: 0x002892BC
		// (set) Token: 0x0600A0B8 RID: 41144 RVA: 0x0028B0F0 File Offset: 0x002892F0
		public unsafe EyeAndHeadAnimator eyeAndHeadAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_eyeAndHeadAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new EyeAndHeadAnimator(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_eyeAndHeadAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x0600A0B9 RID: 41145 RVA: 0x0028B118 File Offset: 0x00289318
		// (set) Token: 0x0600A0BA RID: 41146 RVA: 0x0028B136 File Offset: 0x00289336
		public unsafe static float minLookAtMeTimeToReact
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LookTargetController.NativeFieldInfoPtr_minLookAtMeTimeToReact, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LookTargetController.NativeFieldInfoPtr_minLookAtMeTimeToReact, (void*)(&value));
			}
		}

		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x0600A0BB RID: 41147 RVA: 0x0028B148 File Offset: 0x00289348
		// (set) Token: 0x0600A0BC RID: 41148 RVA: 0x0028B17C File Offset: 0x0028937C
		public unsafe Transform targetPOI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_targetPOI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_targetPOI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x0600A0BD RID: 41149 RVA: 0x0028B1A4 File Offset: 0x002893A4
		// (set) Token: 0x0600A0BE RID: 41150 RVA: 0x0028B1D8 File Offset: 0x002893D8
		public unsafe Transform mainCameraXform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_mainCameraXform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_mainCameraXform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700399E RID: 14750
		// (get) Token: 0x0600A0BF RID: 41151 RVA: 0x0028B200 File Offset: 0x00289400
		// (set) Token: 0x0600A0C0 RID: 41152 RVA: 0x0028B234 File Offset: 0x00289434
		public unsafe Transform mainCameraParentXform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_mainCameraParentXform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_mainCameraParentXform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x0600A0C1 RID: 41153 RVA: 0x0028B25C File Offset: 0x0028945C
		// (set) Token: 0x0600A0C2 RID: 41154 RVA: 0x0028B290 File Offset: 0x00289490
		public unsafe Transform playerEyeCenterXform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_playerEyeCenterXform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_playerEyeCenterXform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x0600A0C3 RID: 41155 RVA: 0x0028B2B8 File Offset: 0x002894B8
		// (set) Token: 0x0600A0C4 RID: 41156 RVA: 0x0028B2EC File Offset: 0x002894EC
		public unsafe Transform playerLeftEyeXform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_playerLeftEyeXform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_playerLeftEyeXform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x0600A0C5 RID: 41157 RVA: 0x0028B314 File Offset: 0x00289514
		// (set) Token: 0x0600A0C6 RID: 41158 RVA: 0x0028B348 File Offset: 0x00289548
		public unsafe Transform playerRightEyeXform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_playerRightEyeXform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_playerRightEyeXform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x0600A0C7 RID: 41159 RVA: 0x0028B370 File Offset: 0x00289570
		// (set) Token: 0x0600A0C8 RID: 41160 RVA: 0x0028B3A4 File Offset: 0x002895A4
		public unsafe Transform usedThirdPersonPlayerEyeCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_usedThirdPersonPlayerEyeCenter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_usedThirdPersonPlayerEyeCenter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A3 RID: 14755
		// (get) Token: 0x0600A0C9 RID: 41161 RVA: 0x0028B3CC File Offset: 0x002895CC
		// (set) Token: 0x0600A0CA RID: 41162 RVA: 0x0028B400 File Offset: 0x00289600
		public unsafe GameObject createdVRParentGO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_createdVRParentGO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_createdVRParentGO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A4 RID: 14756
		// (get) Token: 0x0600A0CB RID: 41163 RVA: 0x0028B428 File Offset: 0x00289628
		// (set) Token: 0x0600A0CC RID: 41164 RVA: 0x0028B45C File Offset: 0x0028965C
		public unsafe GameObject createdPlayerEyeCenterGO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_createdPlayerEyeCenterGO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_createdPlayerEyeCenterGO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A5 RID: 14757
		// (get) Token: 0x0600A0CD RID: 41165 RVA: 0x0028B484 File Offset: 0x00289684
		// (set) Token: 0x0600A0CE RID: 41166 RVA: 0x0028B4B8 File Offset: 0x002896B8
		public unsafe GameObject createdPlayerLeftEyeGO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_createdPlayerLeftEyeGO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_createdPlayerLeftEyeGO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A6 RID: 14758
		// (get) Token: 0x0600A0CF RID: 41167 RVA: 0x0028B4E0 File Offset: 0x002896E0
		// (set) Token: 0x0600A0D0 RID: 41168 RVA: 0x0028B514 File Offset: 0x00289714
		public unsafe GameObject createdPlayerRightEyeGO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_createdPlayerRightEyeGO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_createdPlayerRightEyeGO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039A7 RID: 14759
		// (get) Token: 0x0600A0D1 RID: 41169 RVA: 0x0028B53C File Offset: 0x0028973C
		// (set) Token: 0x0600A0D2 RID: 41170 RVA: 0x0028B564 File Offset: 0x00289764
		public unsafe float lastDistanceToPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_lastDistanceToPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_lastDistanceToPlayer)) = value;
			}
		}

		// Token: 0x170039A8 RID: 14760
		// (get) Token: 0x0600A0D3 RID: 41171 RVA: 0x0028B588 File Offset: 0x00289788
		// (set) Token: 0x0600A0D4 RID: 41172 RVA: 0x0028B5B0 File Offset: 0x002897B0
		public unsafe float playerLookingAtMeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_playerLookingAtMeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_playerLookingAtMeTime)) = value;
			}
		}

		// Token: 0x170039A9 RID: 14761
		// (get) Token: 0x0600A0D5 RID: 41173 RVA: 0x0028B5D4 File Offset: 0x002897D4
		// (set) Token: 0x0600A0D6 RID: 41174 RVA: 0x0028B5FC File Offset: 0x002897FC
		public unsafe float nextChangePOITime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_nextChangePOITime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_nextChangePOITime)) = value;
			}
		}

		// Token: 0x170039AA RID: 14762
		// (get) Token: 0x0600A0D7 RID: 41175 RVA: 0x0028B620 File Offset: 0x00289820
		// (set) Token: 0x0600A0D8 RID: 41176 RVA: 0x0028B648 File Offset: 0x00289848
		public unsafe float stareBackDeadtime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_stareBackDeadtime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_stareBackDeadtime)) = value;
			}
		}

		// Token: 0x170039AB RID: 14763
		// (get) Token: 0x0600A0D9 RID: 41177 RVA: 0x0028B66C File Offset: 0x0028986C
		// (set) Token: 0x0600A0DA RID: 41178 RVA: 0x0028B694 File Offset: 0x00289894
		public unsafe float timeOfLastNoticeCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_timeOfLastNoticeCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_timeOfLastNoticeCheck)) = value;
			}
		}

		// Token: 0x170039AC RID: 14764
		// (get) Token: 0x0600A0DB RID: 41179 RVA: 0x0028B6B8 File Offset: 0x002898B8
		// (set) Token: 0x0600A0DC RID: 41180 RVA: 0x0028B6E0 File Offset: 0x002898E0
		public unsafe float timeOfLastLookBackCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_timeOfLastLookBackCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_timeOfLastLookBackCheck)) = value;
			}
		}

		// Token: 0x170039AD RID: 14765
		// (get) Token: 0x0600A0DD RID: 41181 RVA: 0x0028B704 File Offset: 0x00289904
		// (set) Token: 0x0600A0DE RID: 41182 RVA: 0x0028B72C File Offset: 0x0028992C
		public unsafe float timeOutsideOfAwarenessZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_timeOutsideOfAwarenessZone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_timeOutsideOfAwarenessZone)) = value;
			}
		}

		// Token: 0x170039AE RID: 14766
		// (get) Token: 0x0600A0DF RID: 41183 RVA: 0x0028B750 File Offset: 0x00289950
		// (set) Token: 0x0600A0E0 RID: 41184 RVA: 0x0028B778 File Offset: 0x00289978
		public unsafe float timeInsidePersonalSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_timeInsidePersonalSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_timeInsidePersonalSpace)) = value;
			}
		}

		// Token: 0x170039AF RID: 14767
		// (get) Token: 0x0600A0E1 RID: 41185 RVA: 0x0028B79C File Offset: 0x0028999C
		// (set) Token: 0x0600A0E2 RID: 41186 RVA: 0x0028B7C4 File Offset: 0x002899C4
		public unsafe bool useNativeVRSupport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_useNativeVRSupport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_useNativeVRSupport)) = value;
			}
		}

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x0600A0E3 RID: 41187 RVA: 0x0028B7E8 File Offset: 0x002899E8
		// (set) Token: 0x0600A0E4 RID: 41188 RVA: 0x0028B810 File Offset: 0x00289A10
		public unsafe bool useVR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_useVR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_useVR)) = value;
			}
		}

		// Token: 0x170039B1 RID: 14769
		// (get) Token: 0x0600A0E5 RID: 41189 RVA: 0x0028B834 File Offset: 0x00289A34
		// (set) Token: 0x0600A0E6 RID: 41190 RVA: 0x0028B85C File Offset: 0x00289A5C
		public unsafe bool isInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_isInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_isInitialized)) = value;
			}
		}

		// Token: 0x170039B2 RID: 14770
		// (get) Token: 0x0600A0E7 RID: 41191 RVA: 0x0028B880 File Offset: 0x00289A80
		// (set) Token: 0x0600A0E8 RID: 41192 RVA: 0x0028B8A8 File Offset: 0x00289AA8
		public unsafe bool wasInPersonalSpaceLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_wasInPersonalSpaceLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_wasInPersonalSpaceLastFrame)) = value;
			}
		}

		// Token: 0x170039B3 RID: 14771
		// (get) Token: 0x0600A0E9 RID: 41193 RVA: 0x0028B8CC File Offset: 0x00289ACC
		// (set) Token: 0x0600A0EA RID: 41194 RVA: 0x0028B8F4 File Offset: 0x00289AF4
		public unsafe LookTargetController.State state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookTargetController.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x040065F7 RID: 26103
		private static readonly IntPtr NativeFieldInfoPtr_pointsOfInterest;

		// Token: 0x040065F8 RID: 26104
		private static readonly IntPtr NativeFieldInfoPtr_lookAtPlayerRatio;

		// Token: 0x040065F9 RID: 26105
		private static readonly IntPtr NativeFieldInfoPtr_stareBackFactor;

		// Token: 0x040065FA RID: 26106
		private static readonly IntPtr NativeFieldInfoPtr_noticePlayerDistance;

		// Token: 0x040065FB RID: 26107
		private static readonly IntPtr NativeFieldInfoPtr_personalSpaceDistance;

		// Token: 0x040065FC RID: 26108
		private static readonly IntPtr NativeFieldInfoPtr_minLookTime;

		// Token: 0x040065FD RID: 26109
		private static readonly IntPtr NativeFieldInfoPtr_maxLookTime;

		// Token: 0x040065FE RID: 26110
		private static readonly IntPtr NativeFieldInfoPtr_thirdPersonPlayerEyeCenter;

		// Token: 0x040065FF RID: 26111
		private static readonly IntPtr NativeFieldInfoPtr_keepTargetEvenWhenLost;

		// Token: 0x04006600 RID: 26112
		private static readonly IntPtr NativeFieldInfoPtr_OffsetCam;

		// Token: 0x04006601 RID: 26113
		private static readonly IntPtr NativeFieldInfoPtr_OnStartLookingAtPlayer;

		// Token: 0x04006602 RID: 26114
		private static readonly IntPtr NativeFieldInfoPtr_OnStopLookingAtPlayer;

		// Token: 0x04006603 RID: 26115
		private static readonly IntPtr NativeFieldInfoPtr_OnPlayerEntersPersonalSpace;

		// Token: 0x04006604 RID: 26116
		private static readonly IntPtr NativeFieldInfoPtr_OnLookAwayFromShyness;

		// Token: 0x04006605 RID: 26117
		private static readonly IntPtr NativeFieldInfoPtr_eyeAndHeadAnimator;

		// Token: 0x04006606 RID: 26118
		private static readonly IntPtr NativeFieldInfoPtr_minLookAtMeTimeToReact;

		// Token: 0x04006607 RID: 26119
		private static readonly IntPtr NativeFieldInfoPtr_targetPOI;

		// Token: 0x04006608 RID: 26120
		private static readonly IntPtr NativeFieldInfoPtr_mainCameraXform;

		// Token: 0x04006609 RID: 26121
		private static readonly IntPtr NativeFieldInfoPtr_mainCameraParentXform;

		// Token: 0x0400660A RID: 26122
		private static readonly IntPtr NativeFieldInfoPtr_playerEyeCenterXform;

		// Token: 0x0400660B RID: 26123
		private static readonly IntPtr NativeFieldInfoPtr_playerLeftEyeXform;

		// Token: 0x0400660C RID: 26124
		private static readonly IntPtr NativeFieldInfoPtr_playerRightEyeXform;

		// Token: 0x0400660D RID: 26125
		private static readonly IntPtr NativeFieldInfoPtr_usedThirdPersonPlayerEyeCenter;

		// Token: 0x0400660E RID: 26126
		private static readonly IntPtr NativeFieldInfoPtr_createdVRParentGO;

		// Token: 0x0400660F RID: 26127
		private static readonly IntPtr NativeFieldInfoPtr_createdPlayerEyeCenterGO;

		// Token: 0x04006610 RID: 26128
		private static readonly IntPtr NativeFieldInfoPtr_createdPlayerLeftEyeGO;

		// Token: 0x04006611 RID: 26129
		private static readonly IntPtr NativeFieldInfoPtr_createdPlayerRightEyeGO;

		// Token: 0x04006612 RID: 26130
		private static readonly IntPtr NativeFieldInfoPtr_lastDistanceToPlayer;

		// Token: 0x04006613 RID: 26131
		private static readonly IntPtr NativeFieldInfoPtr_playerLookingAtMeTime;

		// Token: 0x04006614 RID: 26132
		private static readonly IntPtr NativeFieldInfoPtr_nextChangePOITime;

		// Token: 0x04006615 RID: 26133
		private static readonly IntPtr NativeFieldInfoPtr_stareBackDeadtime;

		// Token: 0x04006616 RID: 26134
		private static readonly IntPtr NativeFieldInfoPtr_timeOfLastNoticeCheck;

		// Token: 0x04006617 RID: 26135
		private static readonly IntPtr NativeFieldInfoPtr_timeOfLastLookBackCheck;

		// Token: 0x04006618 RID: 26136
		private static readonly IntPtr NativeFieldInfoPtr_timeOutsideOfAwarenessZone;

		// Token: 0x04006619 RID: 26137
		private static readonly IntPtr NativeFieldInfoPtr_timeInsidePersonalSpace;

		// Token: 0x0400661A RID: 26138
		private static readonly IntPtr NativeFieldInfoPtr_useNativeVRSupport;

		// Token: 0x0400661B RID: 26139
		private static readonly IntPtr NativeFieldInfoPtr_useVR;

		// Token: 0x0400661C RID: 26140
		private static readonly IntPtr NativeFieldInfoPtr_isInitialized;

		// Token: 0x0400661D RID: 26141
		private static readonly IntPtr NativeFieldInfoPtr_wasInPersonalSpaceLastFrame;

		// Token: 0x0400661E RID: 26142
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400661F RID: 26143
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006620 RID: 26144
		private static readonly IntPtr NativeMethodInfoPtr_Blink_Public_Void_0;

		// Token: 0x04006621 RID: 26145
		private static readonly IntPtr NativeMethodInfoPtr_ChangeStateTo_Private_Void_State_0;

		// Token: 0x04006622 RID: 26146
		private static readonly IntPtr NativeMethodInfoPtr_ChooseNextHeadTargetPoint_Private_Vector3_0;

		// Token: 0x04006623 RID: 26147
		private static readonly IntPtr NativeMethodInfoPtr_ChooseNextHeadTargetPOI_Private_Transform_0;

		// Token: 0x04006624 RID: 26148
		private static readonly IntPtr NativeMethodInfoPtr_ClearLookTarget_Public_Void_0;

		// Token: 0x04006625 RID: 26149
		private static readonly IntPtr NativeMethodInfoPtr_FindPlayerCamera_Private_Transform_0;

		// Token: 0x04006626 RID: 26150
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Boolean_0;

		// Token: 0x04006627 RID: 26151
		private static readonly IntPtr NativeMethodInfoPtr_IsLookingAtPlayer_Public_Boolean_0;

		// Token: 0x04006628 RID: 26152
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerInView_Public_Boolean_0;

		// Token: 0x04006629 RID: 26153
		private static readonly IntPtr NativeMethodInfoPtr_LookAtPlayer_Public_Void_Single_Single_0;

		// Token: 0x0400662A RID: 26154
		private static readonly IntPtr NativeMethodInfoPtr_LookAroundIdly_Public_Void_0;

		// Token: 0x0400662B RID: 26155
		private static readonly IntPtr NativeMethodInfoPtr_LookAtPoiDirectly_Public_Void_Transform_Single_Single_0;

		// Token: 0x0400662C RID: 26156
		private static readonly IntPtr NativeMethodInfoPtr_LookAtPoiDirectly_Public_Void_Vector3_Single_Single_0;

		// Token: 0x0400662D RID: 26157
		private static readonly IntPtr NativeMethodInfoPtr_LookAwayFromPlayer_Private_Void_0;

		// Token: 0x0400662E RID: 26158
		private static readonly IntPtr NativeMethodInfoPtr_OnCannotGetTargetIntoView_Private_Void_0;

		// Token: 0x0400662F RID: 26159
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006630 RID: 26160
		private static readonly IntPtr NativeMethodInfoPtr_OnTargetDestroyed_Private_Void_0;

		// Token: 0x04006631 RID: 26161
		private static readonly IntPtr NativeMethodInfoPtr_OnTargetLost_Private_Void_0;

		// Token: 0x04006632 RID: 26162
		private static readonly IntPtr NativeMethodInfoPtr_OnTargetOutOfSight_Private_Void_0;

		// Token: 0x04006633 RID: 26163
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006634 RID: 26164
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNativeVREyePositions_Private_Void_0;

		// Token: 0x04006635 RID: 26165
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerEyeTransformReferences_Private_Void_0;

		// Token: 0x04006636 RID: 26166
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006637 RID: 26167
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006638 RID: 26168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200078B RID: 1931
		public enum State
		{
			// Token: 0x0400663A RID: 26170
			LookingAtPlayer,
			// Token: 0x0400663B RID: 26171
			LookingAroundIdly,
			// Token: 0x0400663C RID: 26172
			LookingAtPoiDirectly,
			// Token: 0x0400663D RID: 26173
			LookingAwayFromPlayer
		}
	}
}
