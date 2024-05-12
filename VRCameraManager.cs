using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Onward.Cameras;
using Onward.Data;
using Onward.Devices;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.XR;
using Valve.VR;

// Token: 0x0200017B RID: 379
public class VRCameraManager : MonoBehaviour
{
	// Token: 0x170008D2 RID: 2258
	// (get) Token: 0x0600192F RID: 6447 RVA: 0x00064888 File Offset: 0x00062A88
	public unsafe GameObject Rig
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_get_Rig_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
	}

	// Token: 0x170008D3 RID: 2259
	// (get) Token: 0x06001930 RID: 6448 RVA: 0x000648E0 File Offset: 0x00062AE0
	public unsafe GameObject HeadController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_get_HeadController_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
	}

	// Token: 0x170008D4 RID: 2260
	// (get) Token: 0x06001931 RID: 6449 RVA: 0x00064938 File Offset: 0x00062B38
	public unsafe GameObject RightController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_get_RightController_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
	}

	// Token: 0x170008D5 RID: 2261
	// (get) Token: 0x06001932 RID: 6450 RVA: 0x00064990 File Offset: 0x00062B90
	public unsafe GameObject LeftController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_get_LeftController_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
	}

	// Token: 0x170008D6 RID: 2262
	// (get) Token: 0x06001933 RID: 6451 RVA: 0x000649E8 File Offset: 0x00062BE8
	public unsafe Transform FootPosition
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_get_FootPosition_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
	}

	// Token: 0x170008D7 RID: 2263
	// (get) Token: 0x06001934 RID: 6452 RVA: 0x00064A40 File Offset: 0x00062C40
	public unsafe GameObject Ears
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_get_Ears_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x00064A98 File Offset: 0x00062C98
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001936 RID: 6454 RVA: 0x00064ADC File Offset: 0x00062CDC
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001937 RID: 6455 RVA: 0x00064B20 File Offset: 0x00062D20
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001938 RID: 6456 RVA: 0x00064B64 File Offset: 0x00062D64
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001939 RID: 6457 RVA: 0x00064BA8 File Offset: 0x00062DA8
	[CallerCount(0)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600193A RID: 6458 RVA: 0x00064BEC File Offset: 0x00062DEC
	[CallerCount(0)]
	public unsafe void OnAppLostFocus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_OnAppLostFocus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600193B RID: 6459 RVA: 0x00064C30 File Offset: 0x00062E30
	[CallerCount(0)]
	public unsafe void OnAppAcquiredFocus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_OnAppAcquiredFocus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600193C RID: 6460 RVA: 0x00064C74 File Offset: 0x00062E74
	[CallerCount(0)]
	public unsafe IEnumerator DelayEnableControllers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_DelayEnableControllers_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
	}

	// Token: 0x0600193D RID: 6461 RVA: 0x00064CCC File Offset: 0x00062ECC
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600193E RID: 6462 RVA: 0x00064D10 File Offset: 0x00062F10
	[CallerCount(0)]
	public unsafe void SetTestFootTargetPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_SetTestFootTargetPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600193F RID: 6463 RVA: 0x00064D54 File Offset: 0x00062F54
	[CallerCount(0)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001940 RID: 6464 RVA: 0x00064D98 File Offset: 0x00062F98
	[CallerCount(0)]
	public unsafe void GetFloorMarker([Optional] float overrideVal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref overrideVal;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_GetFloorMarker_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001941 RID: 6465 RVA: 0x00064DEC File Offset: 0x00062FEC
	[CallerCount(0)]
	public unsafe static void InitLaser()
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_InitLaser_Public_Static_Void_0, 0, (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001942 RID: 6466 RVA: 0x00064E20 File Offset: 0x00063020
	[CallerCount(0)]
	public unsafe void InitOtherObjects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_InitOtherObjects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001943 RID: 6467 RVA: 0x00064E64 File Offset: 0x00063064
	[CallerCount(0)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x00064EA8 File Offset: 0x000630A8
	[CallerCount(0)]
	public unsafe static GameObject GetDominantPointerOrigin()
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_GetDominantPointerOrigin_Public_Static_GameObject_0, 0, (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
	}

	// Token: 0x06001945 RID: 6469 RVA: 0x00064EF0 File Offset: 0x000630F0
	[CallerCount(0)]
	public unsafe static GameObject GetActiveHandController(InputGlobal.Hand hand)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref hand;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_GetActiveHandController_Public_Static_GameObject_Hand_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x00064F4C File Offset: 0x0006314C
	[CallerCount(0)]
	public unsafe static GameObject GetActiveHeadController()
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_GetActiveHeadController_Public_Static_GameObject_0, 0, (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x00064F94 File Offset: 0x00063194
	[CallerCount(0)]
	public unsafe static void SetHandDominance(InputGlobal.Hand DominantHand)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref DominantHand;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_SetHandDominance_Public_Static_Void_Hand_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001948 RID: 6472 RVA: 0x00064FDC File Offset: 0x000631DC
	[CallerCount(0)]
	public unsafe void SteamVRLaserReposition(InputGlobal.Hand laserHand, Vector3 position, Quaternion rotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref laserHand;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_SteamVRLaserReposition_Public_Void_Hand_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001949 RID: 6473 RVA: 0x00065058 File Offset: 0x00063258
	[CallerCount(0)]
	public unsafe static Vector3 GetEyeWorldPosition([In] ref XRNode eye, Camera camera)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = &eye;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_GetEyeWorldPosition_Public_Static_Vector3_byref_XRNode_Camera_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x0600194A RID: 6474 RVA: 0x000650C4 File Offset: 0x000632C4
	[CallerCount(0)]
	public unsafe void ForceSynchronizePosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_ForceSynchronizePosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600194B RID: 6475 RVA: 0x00065108 File Offset: 0x00063308
	[CallerCount(0)]
	public unsafe void SetPlayerCamera(bool enableCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref enableCamera;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr_SetPlayerCamera_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x0006515C File Offset: 0x0006335C
	[CallerCount(0)]
	public unsafe VRCameraManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600194D RID: 6477 RVA: 0x000651A8 File Offset: 0x000633A8
	// Note: this type is marked as 'beforefieldinit'.
	static VRCameraManager()
	{
		Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VRCameraManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr);
		VRCameraManager.NativeFieldInfoPtr_ActiveCameraManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "ActiveCameraManager");
		VRCameraManager.NativeFieldInfoPtr_CameraRigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "CameraRigs");
		VRCameraManager.NativeFieldInfoPtr_PlatformSpecificOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "PlatformSpecificOffsets");
		VRCameraManager.NativeFieldInfoPtr_FadeBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "FadeBlack");
		VRCameraManager.NativeFieldInfoPtr_HeadObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "HeadObjects");
		VRCameraManager.NativeFieldInfoPtr_HandRightObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "HandRightObjects");
		VRCameraManager.NativeFieldInfoPtr_HandLeftObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "HandLeftObjects");
		VRCameraManager.NativeFieldInfoPtr_CurrentCameraRig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "CurrentCameraRig");
		VRCameraManager.NativeFieldInfoPtr_SynchronizePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "SynchronizePosition");
		VRCameraManager.NativeFieldInfoPtr_SyncronisationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "SyncronisationOffset");
		VRCameraManager.NativeFieldInfoPtr_UpdateFootRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "UpdateFootRotation");
		VRCameraManager.NativeFieldInfoPtr_FootRotationLerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "FootRotationLerpSpeed");
		VRCameraManager.NativeFieldInfoPtr_OverrideFootPositionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "OverrideFootPositionTarget");
		VRCameraManager.NativeFieldInfoPtr_TestOverrideFootPositionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "TestOverrideFootPositionTarget");
		VRCameraManager.NativeFieldInfoPtr_LaserSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "LaserSettings");
		VRCameraManager.NativeFieldInfoPtr_RightHandLaser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "RightHandLaser");
		VRCameraManager.NativeFieldInfoPtr_LeftHandLaser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "LeftHandLaser");
		VRCameraManager.NativeFieldInfoPtr__headControllerForwardY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "_headControllerForwardY");
		VRCameraManager.NativeFieldInfoPtr__footTargetLocalPostion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "_footTargetLocalPostion");
		VRCameraManager.NativeFieldInfoPtr__vrCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "_vrCam");
		VRCameraManager.NativeFieldInfoPtr_LeftPose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "LeftPose");
		VRCameraManager.NativeFieldInfoPtr_RightPose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "RightPose");
		VRCameraManager.NativeFieldInfoPtr_VRAnimControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "VRAnimControl");
		VRCameraManager.NativeFieldInfoPtr_VRCharacterControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "VRCharacterControl");
		VRCameraManager.NativeFieldInfoPtr_FlashVignetteCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "FlashVignetteCamera");
		VRCameraManager.NativeFieldInfoPtr_rigsBySDK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "rigsBySDK");
		VRCameraManager.NativeFieldInfoPtr_m_showAfterInputFocusAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "m_showAfterInputFocusAcquired");
		VRCameraManager.NativeFieldInfoPtr_m_restoreOnInputAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "m_restoreOnInputAcquired");
		VRCameraManager.NativeFieldInfoPtr_hasInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "hasInit");
		VRCameraManager.NativeFieldInfoPtr_hasInitLaser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "hasInitLaser");
		VRCameraManager.NativeMethodInfoPtr_get_Rig_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665308);
		VRCameraManager.NativeMethodInfoPtr_get_HeadController_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665309);
		VRCameraManager.NativeMethodInfoPtr_get_RightController_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665310);
		VRCameraManager.NativeMethodInfoPtr_get_LeftController_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665311);
		VRCameraManager.NativeMethodInfoPtr_get_FootPosition_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665312);
		VRCameraManager.NativeMethodInfoPtr_get_Ears_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665313);
		VRCameraManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665314);
		VRCameraManager.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665315);
		VRCameraManager.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665316);
		VRCameraManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665317);
		VRCameraManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665318);
		VRCameraManager.NativeMethodInfoPtr_OnAppLostFocus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665319);
		VRCameraManager.NativeMethodInfoPtr_OnAppAcquiredFocus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665320);
		VRCameraManager.NativeMethodInfoPtr_DelayEnableControllers_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665321);
		VRCameraManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665322);
		VRCameraManager.NativeMethodInfoPtr_SetTestFootTargetPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665323);
		VRCameraManager.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665324);
		VRCameraManager.NativeMethodInfoPtr_GetFloorMarker_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665325);
		VRCameraManager.NativeMethodInfoPtr_InitLaser_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665326);
		VRCameraManager.NativeMethodInfoPtr_InitOtherObjects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665327);
		VRCameraManager.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665328);
		VRCameraManager.NativeMethodInfoPtr_GetDominantPointerOrigin_Public_Static_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665329);
		VRCameraManager.NativeMethodInfoPtr_GetActiveHandController_Public_Static_GameObject_Hand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665330);
		VRCameraManager.NativeMethodInfoPtr_GetActiveHeadController_Public_Static_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665331);
		VRCameraManager.NativeMethodInfoPtr_SetHandDominance_Public_Static_Void_Hand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665332);
		VRCameraManager.NativeMethodInfoPtr_SteamVRLaserReposition_Public_Void_Hand_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665333);
		VRCameraManager.NativeMethodInfoPtr_GetEyeWorldPosition_Public_Static_Vector3_byref_XRNode_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665334);
		VRCameraManager.NativeMethodInfoPtr_ForceSynchronizePosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665335);
		VRCameraManager.NativeMethodInfoPtr_SetPlayerCamera_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665336);
		VRCameraManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, 100665337);
	}

	// Token: 0x0600194E RID: 6478 RVA: 0x0000210C File Offset: 0x0000030C
	public VRCameraManager(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170008B3 RID: 2227
	// (get) Token: 0x0600194F RID: 6479 RVA: 0x00065688 File Offset: 0x00063888
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr));
		}
	}

	// Token: 0x170008B4 RID: 2228
	// (get) Token: 0x06001950 RID: 6480 RVA: 0x0006569C File Offset: 0x0006389C
	// (set) Token: 0x06001951 RID: 6481 RVA: 0x000656C7 File Offset: 0x000638C7
	public unsafe static VRCameraManager ActiveCameraManager
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(VRCameraManager.NativeFieldInfoPtr_ActiveCameraManager, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new VRCameraManager(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(VRCameraManager.NativeFieldInfoPtr_ActiveCameraManager, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008B5 RID: 2229
	// (get) Token: 0x06001952 RID: 6482 RVA: 0x000656DC File Offset: 0x000638DC
	// (set) Token: 0x06001953 RID: 6483 RVA: 0x00065710 File Offset: 0x00063910
	public unsafe Il2CppReferenceArray<VRCameraManager.CameraRig> CameraRigs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_CameraRigs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<VRCameraManager.CameraRig>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_CameraRigs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008B6 RID: 2230
	// (get) Token: 0x06001954 RID: 6484 RVA: 0x00065738 File Offset: 0x00063938
	// (set) Token: 0x06001955 RID: 6485 RVA: 0x0006576C File Offset: 0x0006396C
	public unsafe Il2CppReferenceArray<VRCameraManager.PlatformSpecificOffset> PlatformSpecificOffsets
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_PlatformSpecificOffsets);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<VRCameraManager.PlatformSpecificOffset>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_PlatformSpecificOffsets), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008B7 RID: 2231
	// (get) Token: 0x06001956 RID: 6486 RVA: 0x00065794 File Offset: 0x00063994
	// (set) Token: 0x06001957 RID: 6487 RVA: 0x000657C8 File Offset: 0x000639C8
	public unsafe SceneFadeInOut FadeBlack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_FadeBlack);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new SceneFadeInOut(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_FadeBlack), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008B8 RID: 2232
	// (get) Token: 0x06001958 RID: 6488 RVA: 0x000657F0 File Offset: 0x000639F0
	// (set) Token: 0x06001959 RID: 6489 RVA: 0x00065824 File Offset: 0x00063A24
	public unsafe Il2CppReferenceArray<Transform> HeadObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_HeadObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_HeadObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008B9 RID: 2233
	// (get) Token: 0x0600195A RID: 6490 RVA: 0x0006584C File Offset: 0x00063A4C
	// (set) Token: 0x0600195B RID: 6491 RVA: 0x00065880 File Offset: 0x00063A80
	public unsafe Il2CppReferenceArray<Transform> HandRightObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_HandRightObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_HandRightObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008BA RID: 2234
	// (get) Token: 0x0600195C RID: 6492 RVA: 0x000658A8 File Offset: 0x00063AA8
	// (set) Token: 0x0600195D RID: 6493 RVA: 0x000658DC File Offset: 0x00063ADC
	public unsafe Il2CppReferenceArray<Transform> HandLeftObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_HandLeftObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_HandLeftObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008BB RID: 2235
	// (get) Token: 0x0600195E RID: 6494 RVA: 0x00065904 File Offset: 0x00063B04
	// (set) Token: 0x0600195F RID: 6495 RVA: 0x00065938 File Offset: 0x00063B38
	public unsafe VRCameraManager.CameraRig CurrentCameraRig
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_CurrentCameraRig);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VRCameraManager.CameraRig(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_CurrentCameraRig), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008BC RID: 2236
	// (get) Token: 0x06001960 RID: 6496 RVA: 0x00065960 File Offset: 0x00063B60
	// (set) Token: 0x06001961 RID: 6497 RVA: 0x00065988 File Offset: 0x00063B88
	public unsafe bool SynchronizePosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_SynchronizePosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_SynchronizePosition)) = value;
		}
	}

	// Token: 0x170008BD RID: 2237
	// (get) Token: 0x06001962 RID: 6498 RVA: 0x000659AC File Offset: 0x00063BAC
	// (set) Token: 0x06001963 RID: 6499 RVA: 0x000659D4 File Offset: 0x00063BD4
	public unsafe Vector3 SyncronisationOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_SyncronisationOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_SyncronisationOffset)) = value;
		}
	}

	// Token: 0x170008BE RID: 2238
	// (get) Token: 0x06001964 RID: 6500 RVA: 0x000659F8 File Offset: 0x00063BF8
	// (set) Token: 0x06001965 RID: 6501 RVA: 0x00065A20 File Offset: 0x00063C20
	public unsafe bool UpdateFootRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_UpdateFootRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_UpdateFootRotation)) = value;
		}
	}

	// Token: 0x170008BF RID: 2239
	// (get) Token: 0x06001966 RID: 6502 RVA: 0x00065A44 File Offset: 0x00063C44
	// (set) Token: 0x06001967 RID: 6503 RVA: 0x00065A6C File Offset: 0x00063C6C
	public unsafe float FootRotationLerpSpeed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_FootRotationLerpSpeed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_FootRotationLerpSpeed)) = value;
		}
	}

	// Token: 0x170008C0 RID: 2240
	// (get) Token: 0x06001968 RID: 6504 RVA: 0x00065A90 File Offset: 0x00063C90
	// (set) Token: 0x06001969 RID: 6505 RVA: 0x00065AC4 File Offset: 0x00063CC4
	public unsafe Transform OverrideFootPositionTarget
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_OverrideFootPositionTarget);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_OverrideFootPositionTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008C1 RID: 2241
	// (get) Token: 0x0600196A RID: 6506 RVA: 0x00065AEC File Offset: 0x00063CEC
	// (set) Token: 0x0600196B RID: 6507 RVA: 0x00065B20 File Offset: 0x00063D20
	public unsafe Transform TestOverrideFootPositionTarget
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_TestOverrideFootPositionTarget);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_TestOverrideFootPositionTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008C2 RID: 2242
	// (get) Token: 0x0600196C RID: 6508 RVA: 0x00065B48 File Offset: 0x00063D48
	// (set) Token: 0x0600196D RID: 6509 RVA: 0x00065B7C File Offset: 0x00063D7C
	public unsafe Il2CppReferenceArray<VRCameraManager.LaserSetting> LaserSettings
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_LaserSettings);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<VRCameraManager.LaserSetting>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_LaserSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008C3 RID: 2243
	// (get) Token: 0x0600196E RID: 6510 RVA: 0x00065BA4 File Offset: 0x00063DA4
	// (set) Token: 0x0600196F RID: 6511 RVA: 0x00065BD8 File Offset: 0x00063DD8
	public unsafe GameObject RightHandLaser
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_RightHandLaser);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_RightHandLaser), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008C4 RID: 2244
	// (get) Token: 0x06001970 RID: 6512 RVA: 0x00065C00 File Offset: 0x00063E00
	// (set) Token: 0x06001971 RID: 6513 RVA: 0x00065C34 File Offset: 0x00063E34
	public unsafe GameObject LeftHandLaser
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_LeftHandLaser);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_LeftHandLaser), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008C5 RID: 2245
	// (get) Token: 0x06001972 RID: 6514 RVA: 0x00065C5C File Offset: 0x00063E5C
	// (set) Token: 0x06001973 RID: 6515 RVA: 0x00065C84 File Offset: 0x00063E84
	public unsafe float _headControllerForwardY
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr__headControllerForwardY);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr__headControllerForwardY)) = value;
		}
	}

	// Token: 0x170008C6 RID: 2246
	// (get) Token: 0x06001974 RID: 6516 RVA: 0x00065CA8 File Offset: 0x00063EA8
	// (set) Token: 0x06001975 RID: 6517 RVA: 0x00065CD0 File Offset: 0x00063ED0
	public unsafe Vector3 _footTargetLocalPostion
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr__footTargetLocalPostion);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr__footTargetLocalPostion)) = value;
		}
	}

	// Token: 0x170008C7 RID: 2247
	// (get) Token: 0x06001976 RID: 6518 RVA: 0x00065CF4 File Offset: 0x00063EF4
	// (set) Token: 0x06001977 RID: 6519 RVA: 0x00065D28 File Offset: 0x00063F28
	public unsafe Camera _vrCam
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr__vrCam);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Camera(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr__vrCam), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008C8 RID: 2248
	// (get) Token: 0x06001978 RID: 6520 RVA: 0x00065D50 File Offset: 0x00063F50
	// (set) Token: 0x06001979 RID: 6521 RVA: 0x00065D84 File Offset: 0x00063F84
	public unsafe SteamVR_Action_Pose_Source LeftPose
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_LeftPose);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new SteamVR_Action_Pose_Source(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_LeftPose), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008C9 RID: 2249
	// (get) Token: 0x0600197A RID: 6522 RVA: 0x00065DAC File Offset: 0x00063FAC
	// (set) Token: 0x0600197B RID: 6523 RVA: 0x00065DE0 File Offset: 0x00063FE0
	public unsafe SteamVR_Action_Pose_Source RightPose
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_RightPose);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new SteamVR_Action_Pose_Source(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_RightPose), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008CA RID: 2250
	// (get) Token: 0x0600197C RID: 6524 RVA: 0x00065E08 File Offset: 0x00064008
	// (set) Token: 0x0600197D RID: 6525 RVA: 0x00065E3C File Offset: 0x0006403C
	public unsafe VRAnimatorController VRAnimControl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_VRAnimControl);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VRAnimatorController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_VRAnimControl), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008CB RID: 2251
	// (get) Token: 0x0600197E RID: 6526 RVA: 0x00065E64 File Offset: 0x00064064
	// (set) Token: 0x0600197F RID: 6527 RVA: 0x00065E98 File Offset: 0x00064098
	public unsafe VRCharacterController VRCharacterControl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_VRCharacterControl);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VRCharacterController(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_VRCharacterControl), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008CC RID: 2252
	// (get) Token: 0x06001980 RID: 6528 RVA: 0x00065EC0 File Offset: 0x000640C0
	// (set) Token: 0x06001981 RID: 6529 RVA: 0x00065EF4 File Offset: 0x000640F4
	public unsafe Camera FlashVignetteCamera
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_FlashVignetteCamera);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Camera(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_FlashVignetteCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008CD RID: 2253
	// (get) Token: 0x06001982 RID: 6530 RVA: 0x00065F1C File Offset: 0x0006411C
	// (set) Token: 0x06001983 RID: 6531 RVA: 0x00065F50 File Offset: 0x00064150
	public unsafe Dictionary<VRSDKType, VRCameraManager.CameraRig> rigsBySDK
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_rigsBySDK);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Dictionary<VRSDKType, VRCameraManager.CameraRig>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_rigsBySDK), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008CE RID: 2254
	// (get) Token: 0x06001984 RID: 6532 RVA: 0x00065F78 File Offset: 0x00064178
	// (set) Token: 0x06001985 RID: 6533 RVA: 0x00065FAC File Offset: 0x000641AC
	public unsafe List<Renderer> m_showAfterInputFocusAcquired
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_m_showAfterInputFocusAcquired);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<Renderer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_m_showAfterInputFocusAcquired), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008CF RID: 2255
	// (get) Token: 0x06001986 RID: 6534 RVA: 0x00065FD4 File Offset: 0x000641D4
	// (set) Token: 0x06001987 RID: 6535 RVA: 0x00065FFC File Offset: 0x000641FC
	public unsafe bool m_restoreOnInputAcquired
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_m_restoreOnInputAcquired);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_m_restoreOnInputAcquired)) = value;
		}
	}

	// Token: 0x170008D0 RID: 2256
	// (get) Token: 0x06001988 RID: 6536 RVA: 0x00066020 File Offset: 0x00064220
	// (set) Token: 0x06001989 RID: 6537 RVA: 0x00066048 File Offset: 0x00064248
	public unsafe bool hasInit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_hasInit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_hasInit)) = value;
		}
	}

	// Token: 0x170008D1 RID: 2257
	// (get) Token: 0x0600198A RID: 6538 RVA: 0x0006606C File Offset: 0x0006426C
	// (set) Token: 0x0600198B RID: 6539 RVA: 0x00066094 File Offset: 0x00064294
	public unsafe bool hasInitLaser
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_hasInitLaser);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.NativeFieldInfoPtr_hasInitLaser)) = value;
		}
	}

	// Token: 0x04001032 RID: 4146
	private static readonly IntPtr NativeFieldInfoPtr_ActiveCameraManager;

	// Token: 0x04001033 RID: 4147
	private static readonly IntPtr NativeFieldInfoPtr_CameraRigs;

	// Token: 0x04001034 RID: 4148
	private static readonly IntPtr NativeFieldInfoPtr_PlatformSpecificOffsets;

	// Token: 0x04001035 RID: 4149
	private static readonly IntPtr NativeFieldInfoPtr_FadeBlack;

	// Token: 0x04001036 RID: 4150
	private static readonly IntPtr NativeFieldInfoPtr_HeadObjects;

	// Token: 0x04001037 RID: 4151
	private static readonly IntPtr NativeFieldInfoPtr_HandRightObjects;

	// Token: 0x04001038 RID: 4152
	private static readonly IntPtr NativeFieldInfoPtr_HandLeftObjects;

	// Token: 0x04001039 RID: 4153
	private static readonly IntPtr NativeFieldInfoPtr_CurrentCameraRig;

	// Token: 0x0400103A RID: 4154
	private static readonly IntPtr NativeFieldInfoPtr_SynchronizePosition;

	// Token: 0x0400103B RID: 4155
	private static readonly IntPtr NativeFieldInfoPtr_SyncronisationOffset;

	// Token: 0x0400103C RID: 4156
	private static readonly IntPtr NativeFieldInfoPtr_UpdateFootRotation;

	// Token: 0x0400103D RID: 4157
	private static readonly IntPtr NativeFieldInfoPtr_FootRotationLerpSpeed;

	// Token: 0x0400103E RID: 4158
	private static readonly IntPtr NativeFieldInfoPtr_OverrideFootPositionTarget;

	// Token: 0x0400103F RID: 4159
	private static readonly IntPtr NativeFieldInfoPtr_TestOverrideFootPositionTarget;

	// Token: 0x04001040 RID: 4160
	private static readonly IntPtr NativeFieldInfoPtr_LaserSettings;

	// Token: 0x04001041 RID: 4161
	private static readonly IntPtr NativeFieldInfoPtr_RightHandLaser;

	// Token: 0x04001042 RID: 4162
	private static readonly IntPtr NativeFieldInfoPtr_LeftHandLaser;

	// Token: 0x04001043 RID: 4163
	private static readonly IntPtr NativeFieldInfoPtr__headControllerForwardY;

	// Token: 0x04001044 RID: 4164
	private static readonly IntPtr NativeFieldInfoPtr__footTargetLocalPostion;

	// Token: 0x04001045 RID: 4165
	private static readonly IntPtr NativeFieldInfoPtr__vrCam;

	// Token: 0x04001046 RID: 4166
	private static readonly IntPtr NativeFieldInfoPtr_LeftPose;

	// Token: 0x04001047 RID: 4167
	private static readonly IntPtr NativeFieldInfoPtr_RightPose;

	// Token: 0x04001048 RID: 4168
	private static readonly IntPtr NativeFieldInfoPtr_VRAnimControl;

	// Token: 0x04001049 RID: 4169
	private static readonly IntPtr NativeFieldInfoPtr_VRCharacterControl;

	// Token: 0x0400104A RID: 4170
	private static readonly IntPtr NativeFieldInfoPtr_FlashVignetteCamera;

	// Token: 0x0400104B RID: 4171
	private static readonly IntPtr NativeFieldInfoPtr_rigsBySDK;

	// Token: 0x0400104C RID: 4172
	private static readonly IntPtr NativeFieldInfoPtr_m_showAfterInputFocusAcquired;

	// Token: 0x0400104D RID: 4173
	private static readonly IntPtr NativeFieldInfoPtr_m_restoreOnInputAcquired;

	// Token: 0x0400104E RID: 4174
	private static readonly IntPtr NativeFieldInfoPtr_hasInit;

	// Token: 0x0400104F RID: 4175
	private static readonly IntPtr NativeFieldInfoPtr_hasInitLaser;

	// Token: 0x04001050 RID: 4176
	private static readonly IntPtr NativeMethodInfoPtr_get_Rig_Public_get_GameObject_0;

	// Token: 0x04001051 RID: 4177
	private static readonly IntPtr NativeMethodInfoPtr_get_HeadController_Public_get_GameObject_0;

	// Token: 0x04001052 RID: 4178
	private static readonly IntPtr NativeMethodInfoPtr_get_RightController_Public_get_GameObject_0;

	// Token: 0x04001053 RID: 4179
	private static readonly IntPtr NativeMethodInfoPtr_get_LeftController_Public_get_GameObject_0;

	// Token: 0x04001054 RID: 4180
	private static readonly IntPtr NativeMethodInfoPtr_get_FootPosition_Public_get_Transform_0;

	// Token: 0x04001055 RID: 4181
	private static readonly IntPtr NativeMethodInfoPtr_get_Ears_Public_get_GameObject_0;

	// Token: 0x04001056 RID: 4182
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04001057 RID: 4183
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

	// Token: 0x04001058 RID: 4184
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04001059 RID: 4185
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400105A RID: 4186
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x0400105B RID: 4187
	private static readonly IntPtr NativeMethodInfoPtr_OnAppLostFocus_Private_Void_0;

	// Token: 0x0400105C RID: 4188
	private static readonly IntPtr NativeMethodInfoPtr_OnAppAcquiredFocus_Private_Void_0;

	// Token: 0x0400105D RID: 4189
	private static readonly IntPtr NativeMethodInfoPtr_DelayEnableControllers_Public_IEnumerator_0;

	// Token: 0x0400105E RID: 4190
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x0400105F RID: 4191
	private static readonly IntPtr NativeMethodInfoPtr_SetTestFootTargetPosition_Private_Void_0;

	// Token: 0x04001060 RID: 4192
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	// Token: 0x04001061 RID: 4193
	private static readonly IntPtr NativeMethodInfoPtr_GetFloorMarker_Public_Void_Single_0;

	// Token: 0x04001062 RID: 4194
	private static readonly IntPtr NativeMethodInfoPtr_InitLaser_Public_Static_Void_0;

	// Token: 0x04001063 RID: 4195
	private static readonly IntPtr NativeMethodInfoPtr_InitOtherObjects_Public_Void_0;

	// Token: 0x04001064 RID: 4196
	private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	// Token: 0x04001065 RID: 4197
	private static readonly IntPtr NativeMethodInfoPtr_GetDominantPointerOrigin_Public_Static_GameObject_0;

	// Token: 0x04001066 RID: 4198
	private static readonly IntPtr NativeMethodInfoPtr_GetActiveHandController_Public_Static_GameObject_Hand_0;

	// Token: 0x04001067 RID: 4199
	private static readonly IntPtr NativeMethodInfoPtr_GetActiveHeadController_Public_Static_GameObject_0;

	// Token: 0x04001068 RID: 4200
	private static readonly IntPtr NativeMethodInfoPtr_SetHandDominance_Public_Static_Void_Hand_0;

	// Token: 0x04001069 RID: 4201
	private static readonly IntPtr NativeMethodInfoPtr_SteamVRLaserReposition_Public_Void_Hand_Vector3_Quaternion_0;

	// Token: 0x0400106A RID: 4202
	private static readonly IntPtr NativeMethodInfoPtr_GetEyeWorldPosition_Public_Static_Vector3_byref_XRNode_Camera_0;

	// Token: 0x0400106B RID: 4203
	private static readonly IntPtr NativeMethodInfoPtr_ForceSynchronizePosition_Public_Void_0;

	// Token: 0x0400106C RID: 4204
	private static readonly IntPtr NativeMethodInfoPtr_SetPlayerCamera_Public_Void_Boolean_0;

	// Token: 0x0400106D RID: 4205
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200017C RID: 380
	[Serializable]
	public class CameraRig : Il2CppSystem.Object
	{
		// Token: 0x0600198C RID: 6540 RVA: 0x000660B8 File Offset: 0x000642B8
		[CallerCount(0)]
		public unsafe CameraRig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRCameraManager.CameraRig>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.CameraRig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00066104 File Offset: 0x00064304
		// Note: this type is marked as 'beforefieldinit'.
		static CameraRig()
		{
			Il2CppClassPointerStore<VRCameraManager.CameraRig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "CameraRig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRCameraManager.CameraRig>.NativeClassPtr);
			VRCameraManager.CameraRig.NativeFieldInfoPtr_RigController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.CameraRig>.NativeClassPtr, "RigController");
			VRCameraManager.CameraRig.NativeFieldInfoPtr_ElementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.CameraRig>.NativeClassPtr, "ElementName");
			VRCameraManager.CameraRig.NativeFieldInfoPtr_SDK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.CameraRig>.NativeClassPtr, "SDK");
			VRCameraManager.CameraRig.NativeFieldInfoPtr_RigData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.CameraRig>.NativeClassPtr, "RigData");
			VRCameraManager.CameraRig.NativeFieldInfoPtr_LoadingSceneObjectsDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.CameraRig>.NativeClassPtr, "LoadingSceneObjectsDisable");
			VRCameraManager.CameraRig.NativeFieldInfoPtr_RightShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.CameraRig>.NativeClassPtr, "RightShoulder");
			VRCameraManager.CameraRig.NativeFieldInfoPtr_LeftShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.CameraRig>.NativeClassPtr, "LeftShoulder");
			VRCameraManager.CameraRig.NativeFieldInfoPtr_SpawnPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.CameraRig>.NativeClassPtr, "SpawnPositionOffset");
			VRCameraManager.CameraRig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager.CameraRig>.NativeClassPtr, 100665338);
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00002988 File Offset: 0x00000B88
		public CameraRig(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x000661E3 File Offset: 0x000643E3
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VRCameraManager.CameraRig>.NativeClassPtr));
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x000661F4 File Offset: 0x000643F4
		// (set) Token: 0x06001991 RID: 6545 RVA: 0x00066228 File Offset: 0x00064428
		public unsafe CameraRigController RigController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_RigController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new CameraRigController(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_RigController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x00066250 File Offset: 0x00064450
		// (set) Token: 0x06001993 RID: 6547 RVA: 0x00066279 File Offset: 0x00064479
		public unsafe string ElementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_ElementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_ElementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x000662A0 File Offset: 0x000644A0
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x000662C8 File Offset: 0x000644C8
		public unsafe VRSDKType SDK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_SDK);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_SDK)) = value;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x000662EC File Offset: 0x000644EC
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x00066320 File Offset: 0x00064520
		public unsafe AssetReferenceData RigData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_RigData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AssetReferenceData(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_RigData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x00066348 File Offset: 0x00064548
		// (set) Token: 0x06001999 RID: 6553 RVA: 0x0006637C File Offset: 0x0006457C
		public unsafe Il2CppReferenceArray<GameObject> LoadingSceneObjectsDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_LoadingSceneObjectsDisable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_LoadingSceneObjectsDisable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x000663A4 File Offset: 0x000645A4
		// (set) Token: 0x0600199B RID: 6555 RVA: 0x000663D8 File Offset: 0x000645D8
		public unsafe Transform RightShoulder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_RightShoulder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_RightShoulder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x00066400 File Offset: 0x00064600
		// (set) Token: 0x0600199D RID: 6557 RVA: 0x00066434 File Offset: 0x00064634
		public unsafe Transform LeftShoulder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_LeftShoulder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_LeftShoulder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x0006645C File Offset: 0x0006465C
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x00066484 File Offset: 0x00064684
		public unsafe Vector3 SpawnPositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_SpawnPositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.CameraRig.NativeFieldInfoPtr_SpawnPositionOffset)) = value;
			}
		}

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeFieldInfoPtr_RigController;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeFieldInfoPtr_ElementName;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeFieldInfoPtr_SDK;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeFieldInfoPtr_RigData;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeFieldInfoPtr_LoadingSceneObjectsDisable;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeFieldInfoPtr_RightShoulder;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeFieldInfoPtr_LeftShoulder;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeFieldInfoPtr_SpawnPositionOffset;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x0200017D RID: 381
	[Serializable]
	public class LaserSetting : Il2CppSystem.Object
	{
		// Token: 0x060019A0 RID: 6560 RVA: 0x000664A8 File Offset: 0x000646A8
		[CallerCount(0)]
		public unsafe LaserSetting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRCameraManager.LaserSetting>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.LaserSetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x000664F4 File Offset: 0x000646F4
		// Note: this type is marked as 'beforefieldinit'.
		static LaserSetting()
		{
			Il2CppClassPointerStore<VRCameraManager.LaserSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "LaserSetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRCameraManager.LaserSetting>.NativeClassPtr);
			VRCameraManager.LaserSetting.NativeFieldInfoPtr_ElementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.LaserSetting>.NativeClassPtr, "ElementName");
			VRCameraManager.LaserSetting.NativeFieldInfoPtr_sdk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.LaserSetting>.NativeClassPtr, "sdk");
			VRCameraManager.LaserSetting.NativeFieldInfoPtr_headset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.LaserSetting>.NativeClassPtr, "headset");
			VRCameraManager.LaserSetting.NativeFieldInfoPtr_RightHandOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.LaserSetting>.NativeClassPtr, "RightHandOffset");
			VRCameraManager.LaserSetting.NativeFieldInfoPtr_RightHandRotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.LaserSetting>.NativeClassPtr, "RightHandRotationOffset");
			VRCameraManager.LaserSetting.NativeFieldInfoPtr_LeftHandOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.LaserSetting>.NativeClassPtr, "LeftHandOffset");
			VRCameraManager.LaserSetting.NativeFieldInfoPtr_LeftHandRotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.LaserSetting>.NativeClassPtr, "LeftHandRotationOffset");
			VRCameraManager.LaserSetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager.LaserSetting>.NativeClassPtr, 100665339);
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00002988 File Offset: 0x00000B88
		public LaserSetting(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x000665BF File Offset: 0x000647BF
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VRCameraManager.LaserSetting>.NativeClassPtr));
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x000665D0 File Offset: 0x000647D0
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x000665F9 File Offset: 0x000647F9
		public unsafe string ElementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_ElementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_ElementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x00066620 File Offset: 0x00064820
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x00066648 File Offset: 0x00064848
		public unsafe VRSDKType sdk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_sdk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_sdk)) = value;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x0006666C File Offset: 0x0006486C
		// (set) Token: 0x060019A9 RID: 6569 RVA: 0x00066694 File Offset: 0x00064894
		public unsafe DeviceTypeFlag headset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_headset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_headset)) = value;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x000666B8 File Offset: 0x000648B8
		// (set) Token: 0x060019AB RID: 6571 RVA: 0x000666E0 File Offset: 0x000648E0
		public unsafe Vector3 RightHandOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_RightHandOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_RightHandOffset)) = value;
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x00066704 File Offset: 0x00064904
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x0006672C File Offset: 0x0006492C
		public unsafe Vector3 RightHandRotationOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_RightHandRotationOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_RightHandRotationOffset)) = value;
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x00066750 File Offset: 0x00064950
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x00066778 File Offset: 0x00064978
		public unsafe Vector3 LeftHandOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_LeftHandOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_LeftHandOffset)) = value;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x0006679C File Offset: 0x0006499C
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x000667C4 File Offset: 0x000649C4
		public unsafe Vector3 LeftHandRotationOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_LeftHandRotationOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.LaserSetting.NativeFieldInfoPtr_LeftHandRotationOffset)) = value;
			}
		}

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeFieldInfoPtr_ElementName;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeFieldInfoPtr_sdk;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeFieldInfoPtr_headset;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeFieldInfoPtr_RightHandOffset;

		// Token: 0x0400107B RID: 4219
		private static readonly IntPtr NativeFieldInfoPtr_RightHandRotationOffset;

		// Token: 0x0400107C RID: 4220
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandOffset;

		// Token: 0x0400107D RID: 4221
		private static readonly IntPtr NativeFieldInfoPtr_LeftHandRotationOffset;

		// Token: 0x0400107E RID: 4222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x0200017E RID: 382
	[Serializable]
	public class PlatformSpecificOffset : Il2CppSystem.Object
	{
		// Token: 0x060019B2 RID: 6578 RVA: 0x000667E8 File Offset: 0x000649E8
		[CallerCount(0)]
		public unsafe PlatformSpecificOffset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRCameraManager.PlatformSpecificOffset>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager.PlatformSpecificOffset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00066834 File Offset: 0x00064A34
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformSpecificOffset()
		{
			Il2CppClassPointerStore<VRCameraManager.PlatformSpecificOffset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "PlatformSpecificOffset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRCameraManager.PlatformSpecificOffset>.NativeClassPtr);
			VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_ElementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.PlatformSpecificOffset>.NativeClassPtr, "ElementName");
			VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_Object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.PlatformSpecificOffset>.NativeClassPtr, "Object");
			VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_sdk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.PlatformSpecificOffset>.NativeClassPtr, "sdk");
			VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_headset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.PlatformSpecificOffset>.NativeClassPtr, "headset");
			VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_SetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.PlatformSpecificOffset>.NativeClassPtr, "SetPosition");
			VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_SetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager.PlatformSpecificOffset>.NativeClassPtr, "SetRotation");
			VRCameraManager.PlatformSpecificOffset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager.PlatformSpecificOffset>.NativeClassPtr, 100665340);
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00002988 File Offset: 0x00000B88
		public PlatformSpecificOffset(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x000668EB File Offset: 0x00064AEB
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VRCameraManager.PlatformSpecificOffset>.NativeClassPtr));
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060019B6 RID: 6582 RVA: 0x000668FC File Offset: 0x00064AFC
		// (set) Token: 0x060019B7 RID: 6583 RVA: 0x00066925 File Offset: 0x00064B25
		public unsafe string ElementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_ElementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_ElementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x0006694C File Offset: 0x00064B4C
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x00066980 File Offset: 0x00064B80
		public unsafe Transform Object
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_Object);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_Object), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x000669A8 File Offset: 0x00064BA8
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x000669D0 File Offset: 0x00064BD0
		public unsafe VRSDKType sdk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_sdk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_sdk)) = value;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x000669F4 File Offset: 0x00064BF4
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x00066A1C File Offset: 0x00064C1C
		public unsafe DeviceTypeFlag headset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_headset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_headset)) = value;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x00066A40 File Offset: 0x00064C40
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x00066A68 File Offset: 0x00064C68
		public unsafe Vector3 SetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_SetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_SetPosition)) = value;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x00066A8C File Offset: 0x00064C8C
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x00066AB4 File Offset: 0x00064CB4
		public unsafe Vector3 SetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_SetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager.PlatformSpecificOffset.NativeFieldInfoPtr_SetRotation)) = value;
			}
		}

		// Token: 0x0400107F RID: 4223
		private static readonly IntPtr NativeFieldInfoPtr_ElementName;

		// Token: 0x04001080 RID: 4224
		private static readonly IntPtr NativeFieldInfoPtr_Object;

		// Token: 0x04001081 RID: 4225
		private static readonly IntPtr NativeFieldInfoPtr_sdk;

		// Token: 0x04001082 RID: 4226
		private static readonly IntPtr NativeFieldInfoPtr_headset;

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeFieldInfoPtr_SetPosition;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeFieldInfoPtr_SetRotation;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x0200017F RID: 383
	[ObfuscatedName("VRCameraManager/<DelayEnableControllers>d__50")]
	public sealed class _DelayEnableControllers_d__50 : Il2CppSystem.Object
	{
		// Token: 0x060019C2 RID: 6594 RVA: 0x00066AD8 File Offset: 0x00064CD8
		[CallerCount(0)]
		public unsafe _DelayEnableControllers_d__50(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VRCameraManager._DelayEnableControllers_d__50>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager._DelayEnableControllers_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00066B38 File Offset: 0x00064D38
		[CallerCount(0)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager._DelayEnableControllers_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00066B7C File Offset: 0x00064D7C
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VRCameraManager._DelayEnableControllers_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x00066BCC File Offset: 0x00064DCC
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager._DelayEnableControllers_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x00066C24 File Offset: 0x00064E24
		[CallerCount(0)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager._DelayEnableControllers_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x00066C68 File Offset: 0x00064E68
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VRCameraManager._DelayEnableControllers_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00066CC0 File Offset: 0x00064EC0
		// Note: this type is marked as 'beforefieldinit'.
		static _DelayEnableControllers_d__50()
		{
			Il2CppClassPointerStore<VRCameraManager._DelayEnableControllers_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VRCameraManager>.NativeClassPtr, "<DelayEnableControllers>d__50");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VRCameraManager._DelayEnableControllers_d__50>.NativeClassPtr);
			VRCameraManager._DelayEnableControllers_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager._DelayEnableControllers_d__50>.NativeClassPtr, "<>1__state");
			VRCameraManager._DelayEnableControllers_d__50.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager._DelayEnableControllers_d__50>.NativeClassPtr, "<>2__current");
			VRCameraManager._DelayEnableControllers_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VRCameraManager._DelayEnableControllers_d__50>.NativeClassPtr, "<>4__this");
			VRCameraManager._DelayEnableControllers_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager._DelayEnableControllers_d__50>.NativeClassPtr, 100665341);
			VRCameraManager._DelayEnableControllers_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager._DelayEnableControllers_d__50>.NativeClassPtr, 100665342);
			VRCameraManager._DelayEnableControllers_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager._DelayEnableControllers_d__50>.NativeClassPtr, 100665343);
			VRCameraManager._DelayEnableControllers_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager._DelayEnableControllers_d__50>.NativeClassPtr, 100665344);
			VRCameraManager._DelayEnableControllers_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager._DelayEnableControllers_d__50>.NativeClassPtr, 100665345);
			VRCameraManager._DelayEnableControllers_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VRCameraManager._DelayEnableControllers_d__50>.NativeClassPtr, 100665346);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00002988 File Offset: 0x00000B88
		public _DelayEnableControllers_d__50(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x00066D9F File Offset: 0x00064F9F
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VRCameraManager._DelayEnableControllers_d__50>.NativeClassPtr));
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x00066DB0 File Offset: 0x00064FB0
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x00066DD8 File Offset: 0x00064FD8
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager._DelayEnableControllers_d__50.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager._DelayEnableControllers_d__50.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x00066DFC File Offset: 0x00064FFC
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x00066E30 File Offset: 0x00065030
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager._DelayEnableControllers_d__50.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager._DelayEnableControllers_d__50.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x00066E58 File Offset: 0x00065058
		// (set) Token: 0x060019D0 RID: 6608 RVA: 0x00066E8C File Offset: 0x0006508C
		public unsafe VRCameraManager __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager._DelayEnableControllers_d__50.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new VRCameraManager(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VRCameraManager._DelayEnableControllers_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
