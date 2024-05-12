using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000775 RID: 1909
	[Serializable]
	public class ControlData : Il2CppSystem.Object
	{
		// Token: 0x06009DD8 RID: 40408 RVA: 0x00280744 File Offset: 0x0027E944
		[CallerCount(0)]
		public unsafe bool CanImport(ControlData.ControlDataForExport import, Transform startXform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(import);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startXform);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_CanImport_Public_Boolean_ControlDataForExport_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009DD9 RID: 40409 RVA: 0x002807C4 File Offset: 0x0027E9C4
		[CallerCount(0)]
		public unsafe void CheckConsistency(Animator animator, EyeAndHeadAnimator eyeAndHeadAnimator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eyeAndHeadAnimator);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_CheckConsistency_Public_Void_Animator_EyeAndHeadAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DDA RID: 40410 RVA: 0x00280838 File Offset: 0x0027EA38
		[CallerCount(0)]
		public unsafe float ClampLeftVertEyeAngle(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_ClampLeftVertEyeAngle_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009DDB RID: 40411 RVA: 0x0028089C File Offset: 0x0027EA9C
		[CallerCount(0)]
		public unsafe float ClampRightVertEyeAngle(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_ClampRightVertEyeAngle_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009DDC RID: 40412 RVA: 0x00280900 File Offset: 0x0027EB00
		[CallerCount(0)]
		public unsafe ControlData.ControlDataForExport GetExport(Transform startXform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(startXform);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_GetExport_Public_ControlDataForExport_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new ControlData.ControlDataForExport(intPtr2) : null;
		}

		// Token: 0x06009DDD RID: 40413 RVA: 0x00280970 File Offset: 0x0027EB70
		[CallerCount(0)]
		public unsafe void Import(ControlData.ControlDataForExport import, Transform startXform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(import);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startXform);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_Import_Public_Void_ControlDataForExport_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DDE RID: 40414 RVA: 0x002809E4 File Offset: 0x0027EBE4
		[CallerCount(0)]
		public unsafe void Initialize(Transform startXform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(startXform);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_Initialize_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DDF RID: 40415 RVA: 0x00280A40 File Offset: 0x0027EC40
		[CallerCount(0)]
		public unsafe void LerpBlendshapeConfig(Il2CppReferenceArray<ControlData.EyelidPositionBlendshape> blendshapes, float lerpValue, bool relativeToCurrentValueIfUsedInOtherConfig = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(blendshapes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeToCurrentValueIfUsedInOtherConfig;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_LerpBlendshapeConfig_Private_Void_ArrayOf_EyelidPositionBlendshape_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DE0 RID: 40416 RVA: 0x00280AC0 File Offset: 0x0027ECC0
		[CallerCount(0)]
		public unsafe bool NeedsSaveDefaultBlendshapeConfig()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_NeedsSaveDefaultBlendshapeConfig_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009DE1 RID: 40417 RVA: 0x00280B10 File Offset: 0x0027ED10
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DE2 RID: 40418 RVA: 0x00280B54 File Offset: 0x0027ED54
		[CallerCount(0)]
		public unsafe void ResetBlendshapeConfig(Il2CppReferenceArray<ControlData.EyelidPositionBlendshape> blendshapes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(blendshapes);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_ResetBlendshapeConfig_Private_Void_ArrayOf_EyelidPositionBlendshape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DE3 RID: 40419 RVA: 0x00280BB0 File Offset: 0x0027EDB0
		[CallerCount(0)]
		public unsafe void ResetAllBlendshapesToDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_ResetAllBlendshapesToDefault_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DE4 RID: 40420 RVA: 0x00280BF4 File Offset: 0x0027EDF4
		[CallerCount(0)]
		public unsafe void RestoreClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_RestoreClosed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DE5 RID: 40421 RVA: 0x00280C38 File Offset: 0x0027EE38
		[CallerCount(0)]
		public unsafe void RestoreDefault(bool withEyelids = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref withEyelids;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_RestoreDefault_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DE6 RID: 40422 RVA: 0x00280C8C File Offset: 0x0027EE8C
		[CallerCount(0)]
		public unsafe void RestoreLookDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_RestoreLookDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DE7 RID: 40423 RVA: 0x00280CD0 File Offset: 0x0027EED0
		[CallerCount(0)]
		public unsafe void RestoreLookUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_RestoreLookUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DE8 RID: 40424 RVA: 0x00280D14 File Offset: 0x0027EF14
		[CallerCount(0)]
		public unsafe void SaveBlendshapesForEyelidPosition(ref Il2CppReferenceArray<ControlData.EyelidPositionBlendshape> blendshapesForPosition, UnityEngine.Object rootObject, string positionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(blendshapesForPosition);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rootObject);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(positionName);
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_SaveBlendshapesForEyelidPosition_Private_Void_byref_ArrayOf_EyelidPositionBlendshape_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			blendshapesForPosition = ((intPtr3 == 0) ? null : new Il2CppReferenceArray(intPtr3));
		}

		// Token: 0x06009DE9 RID: 40425 RVA: 0x00280DC0 File Offset: 0x0027EFC0
		[CallerCount(0)]
		public unsafe void SaveClosed(UnityEngine.Object rootObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootObject);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_SaveClosed_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DEA RID: 40426 RVA: 0x00280E1C File Offset: 0x0027F01C
		[CallerCount(0)]
		public unsafe void SaveDefault(UnityEngine.Object rootObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootObject);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_SaveDefault_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DEB RID: 40427 RVA: 0x00280E78 File Offset: 0x0027F078
		[CallerCount(0)]
		public unsafe void SaveLookDown(UnityEngine.Object rootObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootObject);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_SaveLookDown_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DEC RID: 40428 RVA: 0x00280ED4 File Offset: 0x0027F0D4
		[CallerCount(0)]
		public unsafe void SaveLookUp(UnityEngine.Object rootObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootObject);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_SaveLookUp_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DED RID: 40429 RVA: 0x00280F30 File Offset: 0x0027F130
		[CallerCount(0)]
		public unsafe void UpdateEyelids(float leftEyeAngle, float rightEyeAngle, float blink01, bool eyelidsFollowEyesVertically)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref leftEyeAngle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightEyeAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blink01;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eyelidsFollowEyesVertically;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr_UpdateEyelids_Public_Void_Single_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DEE RID: 40430 RVA: 0x00280FC0 File Offset: 0x0027F1C0
		[CallerCount(0)]
		public unsafe ControlData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlData>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009DEF RID: 40431 RVA: 0x0028100C File Offset: 0x0027F20C
		// Note: this type is marked as 'beforefieldinit'.
		static ControlData()
		{
			Il2CppClassPointerStore<ControlData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RealisticEyeMovements", "ControlData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlData>.NativeClassPtr);
			ControlData.NativeFieldInfoPtr_eyeControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "eyeControl");
			ControlData.NativeFieldInfoPtr_leftEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "leftEye");
			ControlData.NativeFieldInfoPtr_rightEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "rightEye");
			ControlData.NativeFieldInfoPtr_maxEyeUpBoneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "maxEyeUpBoneAngle");
			ControlData.NativeFieldInfoPtr_maxEyeDownBoneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "maxEyeDownBoneAngle");
			ControlData.NativeFieldInfoPtr_maxEyeUpEyeballAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "maxEyeUpEyeballAngle");
			ControlData.NativeFieldInfoPtr_maxEyeDownEyeballAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "maxEyeDownEyeballAngle");
			ControlData.NativeFieldInfoPtr_isEyeBallDefaultSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyeBallDefaultSet");
			ControlData.NativeFieldInfoPtr_isEyeBoneDefaultSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyeBoneDefaultSet");
			ControlData.NativeFieldInfoPtr_isEyeBallLookUpSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyeBallLookUpSet");
			ControlData.NativeFieldInfoPtr_isEyeBoneLookUpSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyeBoneLookUpSet");
			ControlData.NativeFieldInfoPtr_isEyeBallLookDownSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyeBallLookDownSet");
			ControlData.NativeFieldInfoPtr_isEyeBoneLookDownSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyeBoneLookDownSet");
			ControlData.NativeFieldInfoPtr_leftBoneEyeRotationLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "leftBoneEyeRotationLimiter");
			ControlData.NativeFieldInfoPtr_rightBoneEyeRotationLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "rightBoneEyeRotationLimiter");
			ControlData.NativeFieldInfoPtr_leftEyeballEyeRotationLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "leftEyeballEyeRotationLimiter");
			ControlData.NativeFieldInfoPtr_rightEyeballEyeRotationLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "rightEyeballEyeRotationLimiter");
			ControlData.NativeFieldInfoPtr_eyelidControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "eyelidControl");
			ControlData.NativeFieldInfoPtr_eyelidBoneMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "eyelidBoneMode");
			ControlData.NativeFieldInfoPtr_eyelidsFollowEyesVertically = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "eyelidsFollowEyesVertically");
			ControlData.NativeFieldInfoPtr_upperEyeLidLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "upperEyeLidLeft");
			ControlData.NativeFieldInfoPtr_upperEyeLidRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "upperEyeLidRight");
			ControlData.NativeFieldInfoPtr_lowerEyeLidLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "lowerEyeLidLeft");
			ControlData.NativeFieldInfoPtr_lowerEyeLidRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "lowerEyeLidRight");
			ControlData.NativeFieldInfoPtr_isEyelidBonesDefaultSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyelidBonesDefaultSet");
			ControlData.NativeFieldInfoPtr_isEyelidBonesClosedSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyelidBonesClosedSet");
			ControlData.NativeFieldInfoPtr_isEyelidBonesLookUpSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyelidBonesLookUpSet");
			ControlData.NativeFieldInfoPtr_isEyelidBonesLookDownSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyelidBonesLookDownSet");
			ControlData.NativeFieldInfoPtr_upperLeftLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "upperLeftLimiter");
			ControlData.NativeFieldInfoPtr_upperRightLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "upperRightLimiter");
			ControlData.NativeFieldInfoPtr_lowerLeftLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "lowerLeftLimiter");
			ControlData.NativeFieldInfoPtr_lowerRightLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "lowerRightLimiter");
			ControlData.NativeFieldInfoPtr_eyeWidenOrSquint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "eyeWidenOrSquint");
			ControlData.NativeFieldInfoPtr_blendshapesForBlinking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "blendshapesForBlinking");
			ControlData.NativeFieldInfoPtr_blendshapesForLookingUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "blendshapesForLookingUp");
			ControlData.NativeFieldInfoPtr_blendshapesForLookingDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "blendshapesForLookingDown");
			ControlData.NativeFieldInfoPtr_blendshapesConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "blendshapesConfigs");
			ControlData.NativeFieldInfoPtr_isEyelidBlendshapeDefaultSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyelidBlendshapeDefaultSet");
			ControlData.NativeFieldInfoPtr_isEyelidBlendshapeClosedSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyelidBlendshapeClosedSet");
			ControlData.NativeFieldInfoPtr_isEyelidBlendshapeLookUpSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyelidBlendshapeLookUpSet");
			ControlData.NativeFieldInfoPtr_isEyelidBlendshapeLookDownSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "isEyelidBlendshapeLookDownSet");
			ControlData.NativeMethodInfoPtr_CanImport_Public_Boolean_ControlDataForExport_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675925);
			ControlData.NativeMethodInfoPtr_CheckConsistency_Public_Void_Animator_EyeAndHeadAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675926);
			ControlData.NativeMethodInfoPtr_ClampLeftVertEyeAngle_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675927);
			ControlData.NativeMethodInfoPtr_ClampRightVertEyeAngle_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675928);
			ControlData.NativeMethodInfoPtr_GetExport_Public_ControlDataForExport_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675929);
			ControlData.NativeMethodInfoPtr_Import_Public_Void_ControlDataForExport_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675930);
			ControlData.NativeMethodInfoPtr_Initialize_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675931);
			ControlData.NativeMethodInfoPtr_LerpBlendshapeConfig_Private_Void_ArrayOf_EyelidPositionBlendshape_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675932);
			ControlData.NativeMethodInfoPtr_NeedsSaveDefaultBlendshapeConfig_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675933);
			ControlData.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675934);
			ControlData.NativeMethodInfoPtr_ResetBlendshapeConfig_Private_Void_ArrayOf_EyelidPositionBlendshape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675935);
			ControlData.NativeMethodInfoPtr_ResetAllBlendshapesToDefault_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675936);
			ControlData.NativeMethodInfoPtr_RestoreClosed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675937);
			ControlData.NativeMethodInfoPtr_RestoreDefault_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675938);
			ControlData.NativeMethodInfoPtr_RestoreLookDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675939);
			ControlData.NativeMethodInfoPtr_RestoreLookUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675940);
			ControlData.NativeMethodInfoPtr_SaveBlendshapesForEyelidPosition_Private_Void_byref_ArrayOf_EyelidPositionBlendshape_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675941);
			ControlData.NativeMethodInfoPtr_SaveClosed_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675942);
			ControlData.NativeMethodInfoPtr_SaveDefault_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675943);
			ControlData.NativeMethodInfoPtr_SaveLookDown_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675944);
			ControlData.NativeMethodInfoPtr_SaveLookUp_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675945);
			ControlData.NativeMethodInfoPtr_UpdateEyelids_Public_Void_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675946);
			ControlData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData>.NativeClassPtr, 100675947);
		}

		// Token: 0x06009DF0 RID: 40432 RVA: 0x00002988 File Offset: 0x00000B88
		public ControlData(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x06009DF1 RID: 40433 RVA: 0x0028153C File Offset: 0x0027F73C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ControlData>.NativeClassPtr));
			}
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x06009DF2 RID: 40434 RVA: 0x00281550 File Offset: 0x0027F750
		// (set) Token: 0x06009DF3 RID: 40435 RVA: 0x00281578 File Offset: 0x0027F778
		public unsafe ControlData.EyeControl eyeControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_eyeControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_eyeControl)) = value;
			}
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x06009DF4 RID: 40436 RVA: 0x0028159C File Offset: 0x0027F79C
		// (set) Token: 0x06009DF5 RID: 40437 RVA: 0x002815D0 File Offset: 0x0027F7D0
		public unsafe Transform leftEye
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_leftEye);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_leftEye), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x06009DF6 RID: 40438 RVA: 0x002815F8 File Offset: 0x0027F7F8
		// (set) Token: 0x06009DF7 RID: 40439 RVA: 0x0028162C File Offset: 0x0027F82C
		public unsafe Transform rightEye
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_rightEye);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_rightEye), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x06009DF8 RID: 40440 RVA: 0x00281654 File Offset: 0x0027F854
		// (set) Token: 0x06009DF9 RID: 40441 RVA: 0x0028167C File Offset: 0x0027F87C
		public unsafe float maxEyeUpBoneAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_maxEyeUpBoneAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_maxEyeUpBoneAngle)) = value;
			}
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x06009DFA RID: 40442 RVA: 0x002816A0 File Offset: 0x0027F8A0
		// (set) Token: 0x06009DFB RID: 40443 RVA: 0x002816C8 File Offset: 0x0027F8C8
		public unsafe float maxEyeDownBoneAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_maxEyeDownBoneAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_maxEyeDownBoneAngle)) = value;
			}
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x06009DFC RID: 40444 RVA: 0x002816EC File Offset: 0x0027F8EC
		// (set) Token: 0x06009DFD RID: 40445 RVA: 0x00281714 File Offset: 0x0027F914
		public unsafe float maxEyeUpEyeballAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_maxEyeUpEyeballAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_maxEyeUpEyeballAngle)) = value;
			}
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x06009DFE RID: 40446 RVA: 0x00281738 File Offset: 0x0027F938
		// (set) Token: 0x06009DFF RID: 40447 RVA: 0x00281760 File Offset: 0x0027F960
		public unsafe float maxEyeDownEyeballAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_maxEyeDownEyeballAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_maxEyeDownEyeballAngle)) = value;
			}
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x06009E00 RID: 40448 RVA: 0x00281784 File Offset: 0x0027F984
		// (set) Token: 0x06009E01 RID: 40449 RVA: 0x002817AC File Offset: 0x0027F9AC
		public unsafe bool isEyeBallDefaultSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyeBallDefaultSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyeBallDefaultSet)) = value;
			}
		}

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x06009E02 RID: 40450 RVA: 0x002817D0 File Offset: 0x0027F9D0
		// (set) Token: 0x06009E03 RID: 40451 RVA: 0x002817F8 File Offset: 0x0027F9F8
		public unsafe bool isEyeBoneDefaultSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyeBoneDefaultSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyeBoneDefaultSet)) = value;
			}
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x06009E04 RID: 40452 RVA: 0x0028181C File Offset: 0x0027FA1C
		// (set) Token: 0x06009E05 RID: 40453 RVA: 0x00281844 File Offset: 0x0027FA44
		public unsafe bool isEyeBallLookUpSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyeBallLookUpSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyeBallLookUpSet)) = value;
			}
		}

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x06009E06 RID: 40454 RVA: 0x00281868 File Offset: 0x0027FA68
		// (set) Token: 0x06009E07 RID: 40455 RVA: 0x00281890 File Offset: 0x0027FA90
		public unsafe bool isEyeBoneLookUpSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyeBoneLookUpSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyeBoneLookUpSet)) = value;
			}
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x06009E08 RID: 40456 RVA: 0x002818B4 File Offset: 0x0027FAB4
		// (set) Token: 0x06009E09 RID: 40457 RVA: 0x002818DC File Offset: 0x0027FADC
		public unsafe bool isEyeBallLookDownSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyeBallLookDownSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyeBallLookDownSet)) = value;
			}
		}

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x06009E0A RID: 40458 RVA: 0x00281900 File Offset: 0x0027FB00
		// (set) Token: 0x06009E0B RID: 40459 RVA: 0x00281928 File Offset: 0x0027FB28
		public unsafe bool isEyeBoneLookDownSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyeBoneLookDownSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyeBoneLookDownSet)) = value;
			}
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x06009E0C RID: 40460 RVA: 0x0028194C File Offset: 0x0027FB4C
		// (set) Token: 0x06009E0D RID: 40461 RVA: 0x00281980 File Offset: 0x0027FB80
		public unsafe EyeRotationLimiter leftBoneEyeRotationLimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_leftBoneEyeRotationLimiter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new EyeRotationLimiter(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_leftBoneEyeRotationLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x06009E0E RID: 40462 RVA: 0x002819A8 File Offset: 0x0027FBA8
		// (set) Token: 0x06009E0F RID: 40463 RVA: 0x002819DC File Offset: 0x0027FBDC
		public unsafe EyeRotationLimiter rightBoneEyeRotationLimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_rightBoneEyeRotationLimiter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new EyeRotationLimiter(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_rightBoneEyeRotationLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x06009E10 RID: 40464 RVA: 0x00281A04 File Offset: 0x0027FC04
		// (set) Token: 0x06009E11 RID: 40465 RVA: 0x00281A38 File Offset: 0x0027FC38
		public unsafe EyeRotationLimiter leftEyeballEyeRotationLimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_leftEyeballEyeRotationLimiter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new EyeRotationLimiter(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_leftEyeballEyeRotationLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x06009E12 RID: 40466 RVA: 0x00281A60 File Offset: 0x0027FC60
		// (set) Token: 0x06009E13 RID: 40467 RVA: 0x00281A94 File Offset: 0x0027FC94
		public unsafe EyeRotationLimiter rightEyeballEyeRotationLimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_rightEyeballEyeRotationLimiter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new EyeRotationLimiter(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_rightEyeballEyeRotationLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x06009E14 RID: 40468 RVA: 0x00281ABC File Offset: 0x0027FCBC
		// (set) Token: 0x06009E15 RID: 40469 RVA: 0x00281AE4 File Offset: 0x0027FCE4
		public unsafe ControlData.EyelidControl eyelidControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_eyelidControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_eyelidControl)) = value;
			}
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x06009E16 RID: 40470 RVA: 0x00281B08 File Offset: 0x0027FD08
		// (set) Token: 0x06009E17 RID: 40471 RVA: 0x00281B30 File Offset: 0x0027FD30
		public unsafe ControlData.EyelidBoneMode eyelidBoneMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_eyelidBoneMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_eyelidBoneMode)) = value;
			}
		}

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x06009E18 RID: 40472 RVA: 0x00281B54 File Offset: 0x0027FD54
		// (set) Token: 0x06009E19 RID: 40473 RVA: 0x00281B7C File Offset: 0x0027FD7C
		public unsafe bool eyelidsFollowEyesVertically
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_eyelidsFollowEyesVertically);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_eyelidsFollowEyesVertically)) = value;
			}
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x06009E1A RID: 40474 RVA: 0x00281BA0 File Offset: 0x0027FDA0
		// (set) Token: 0x06009E1B RID: 40475 RVA: 0x00281BD4 File Offset: 0x0027FDD4
		public unsafe Transform upperEyeLidLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_upperEyeLidLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_upperEyeLidLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x06009E1C RID: 40476 RVA: 0x00281BFC File Offset: 0x0027FDFC
		// (set) Token: 0x06009E1D RID: 40477 RVA: 0x00281C30 File Offset: 0x0027FE30
		public unsafe Transform upperEyeLidRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_upperEyeLidRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_upperEyeLidRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x06009E1E RID: 40478 RVA: 0x00281C58 File Offset: 0x0027FE58
		// (set) Token: 0x06009E1F RID: 40479 RVA: 0x00281C8C File Offset: 0x0027FE8C
		public unsafe Transform lowerEyeLidLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_lowerEyeLidLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_lowerEyeLidLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x06009E20 RID: 40480 RVA: 0x00281CB4 File Offset: 0x0027FEB4
		// (set) Token: 0x06009E21 RID: 40481 RVA: 0x00281CE8 File Offset: 0x0027FEE8
		public unsafe Transform lowerEyeLidRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_lowerEyeLidRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_lowerEyeLidRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x06009E22 RID: 40482 RVA: 0x00281D10 File Offset: 0x0027FF10
		// (set) Token: 0x06009E23 RID: 40483 RVA: 0x00281D38 File Offset: 0x0027FF38
		public unsafe bool isEyelidBonesDefaultSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBonesDefaultSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBonesDefaultSet)) = value;
			}
		}

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x06009E24 RID: 40484 RVA: 0x00281D5C File Offset: 0x0027FF5C
		// (set) Token: 0x06009E25 RID: 40485 RVA: 0x00281D84 File Offset: 0x0027FF84
		public unsafe bool isEyelidBonesClosedSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBonesClosedSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBonesClosedSet)) = value;
			}
		}

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x06009E26 RID: 40486 RVA: 0x00281DA8 File Offset: 0x0027FFA8
		// (set) Token: 0x06009E27 RID: 40487 RVA: 0x00281DD0 File Offset: 0x0027FFD0
		public unsafe bool isEyelidBonesLookUpSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBonesLookUpSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBonesLookUpSet)) = value;
			}
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x06009E28 RID: 40488 RVA: 0x00281DF4 File Offset: 0x0027FFF4
		// (set) Token: 0x06009E29 RID: 40489 RVA: 0x00281E1C File Offset: 0x0028001C
		public unsafe bool isEyelidBonesLookDownSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBonesLookDownSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBonesLookDownSet)) = value;
			}
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x06009E2A RID: 40490 RVA: 0x00281E40 File Offset: 0x00280040
		// (set) Token: 0x06009E2B RID: 40491 RVA: 0x00281E74 File Offset: 0x00280074
		public unsafe EyelidRotationLimiter upperLeftLimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_upperLeftLimiter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new EyelidRotationLimiter(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_upperLeftLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x06009E2C RID: 40492 RVA: 0x00281E9C File Offset: 0x0028009C
		// (set) Token: 0x06009E2D RID: 40493 RVA: 0x00281ED0 File Offset: 0x002800D0
		public unsafe EyelidRotationLimiter upperRightLimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_upperRightLimiter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new EyelidRotationLimiter(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_upperRightLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x06009E2E RID: 40494 RVA: 0x00281EF8 File Offset: 0x002800F8
		// (set) Token: 0x06009E2F RID: 40495 RVA: 0x00281F2C File Offset: 0x0028012C
		public unsafe EyelidRotationLimiter lowerLeftLimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_lowerLeftLimiter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new EyelidRotationLimiter(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_lowerLeftLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x06009E30 RID: 40496 RVA: 0x00281F54 File Offset: 0x00280154
		// (set) Token: 0x06009E31 RID: 40497 RVA: 0x00281F88 File Offset: 0x00280188
		public unsafe EyelidRotationLimiter lowerRightLimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_lowerRightLimiter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new EyelidRotationLimiter(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_lowerRightLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x06009E32 RID: 40498 RVA: 0x00281FB0 File Offset: 0x002801B0
		// (set) Token: 0x06009E33 RID: 40499 RVA: 0x00281FD8 File Offset: 0x002801D8
		public unsafe float eyeWidenOrSquint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_eyeWidenOrSquint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_eyeWidenOrSquint)) = value;
			}
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x06009E34 RID: 40500 RVA: 0x00281FFC File Offset: 0x002801FC
		// (set) Token: 0x06009E35 RID: 40501 RVA: 0x00282030 File Offset: 0x00280230
		public unsafe Il2CppReferenceArray<ControlData.EyelidPositionBlendshape> blendshapesForBlinking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_blendshapesForBlinking);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<ControlData.EyelidPositionBlendshape>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_blendshapesForBlinking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x06009E36 RID: 40502 RVA: 0x00282058 File Offset: 0x00280258
		// (set) Token: 0x06009E37 RID: 40503 RVA: 0x0028208C File Offset: 0x0028028C
		public unsafe Il2CppReferenceArray<ControlData.EyelidPositionBlendshape> blendshapesForLookingUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_blendshapesForLookingUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<ControlData.EyelidPositionBlendshape>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_blendshapesForLookingUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x06009E38 RID: 40504 RVA: 0x002820B4 File Offset: 0x002802B4
		// (set) Token: 0x06009E39 RID: 40505 RVA: 0x002820E8 File Offset: 0x002802E8
		public unsafe Il2CppReferenceArray<ControlData.EyelidPositionBlendshape> blendshapesForLookingDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_blendshapesForLookingDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<ControlData.EyelidPositionBlendshape>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_blendshapesForLookingDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x06009E3A RID: 40506 RVA: 0x00282110 File Offset: 0x00280310
		// (set) Token: 0x06009E3B RID: 40507 RVA: 0x00282144 File Offset: 0x00280344
		public unsafe Il2CppReferenceArray<ControlData.BlendshapesConfig> blendshapesConfigs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_blendshapesConfigs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<ControlData.BlendshapesConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_blendshapesConfigs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x06009E3C RID: 40508 RVA: 0x0028216C File Offset: 0x0028036C
		// (set) Token: 0x06009E3D RID: 40509 RVA: 0x00282194 File Offset: 0x00280394
		public unsafe bool isEyelidBlendshapeDefaultSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBlendshapeDefaultSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBlendshapeDefaultSet)) = value;
			}
		}

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x06009E3E RID: 40510 RVA: 0x002821B8 File Offset: 0x002803B8
		// (set) Token: 0x06009E3F RID: 40511 RVA: 0x002821E0 File Offset: 0x002803E0
		public unsafe bool isEyelidBlendshapeClosedSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBlendshapeClosedSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBlendshapeClosedSet)) = value;
			}
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x06009E40 RID: 40512 RVA: 0x00282204 File Offset: 0x00280404
		// (set) Token: 0x06009E41 RID: 40513 RVA: 0x0028222C File Offset: 0x0028042C
		public unsafe bool isEyelidBlendshapeLookUpSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBlendshapeLookUpSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBlendshapeLookUpSet)) = value;
			}
		}

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x06009E42 RID: 40514 RVA: 0x00282250 File Offset: 0x00280450
		// (set) Token: 0x06009E43 RID: 40515 RVA: 0x00282278 File Offset: 0x00280478
		public unsafe bool isEyelidBlendshapeLookDownSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBlendshapeLookDownSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.NativeFieldInfoPtr_isEyelidBlendshapeLookDownSet)) = value;
			}
		}

		// Token: 0x0400644A RID: 25674
		private static readonly IntPtr NativeFieldInfoPtr_eyeControl;

		// Token: 0x0400644B RID: 25675
		private static readonly IntPtr NativeFieldInfoPtr_leftEye;

		// Token: 0x0400644C RID: 25676
		private static readonly IntPtr NativeFieldInfoPtr_rightEye;

		// Token: 0x0400644D RID: 25677
		private static readonly IntPtr NativeFieldInfoPtr_maxEyeUpBoneAngle;

		// Token: 0x0400644E RID: 25678
		private static readonly IntPtr NativeFieldInfoPtr_maxEyeDownBoneAngle;

		// Token: 0x0400644F RID: 25679
		private static readonly IntPtr NativeFieldInfoPtr_maxEyeUpEyeballAngle;

		// Token: 0x04006450 RID: 25680
		private static readonly IntPtr NativeFieldInfoPtr_maxEyeDownEyeballAngle;

		// Token: 0x04006451 RID: 25681
		private static readonly IntPtr NativeFieldInfoPtr_isEyeBallDefaultSet;

		// Token: 0x04006452 RID: 25682
		private static readonly IntPtr NativeFieldInfoPtr_isEyeBoneDefaultSet;

		// Token: 0x04006453 RID: 25683
		private static readonly IntPtr NativeFieldInfoPtr_isEyeBallLookUpSet;

		// Token: 0x04006454 RID: 25684
		private static readonly IntPtr NativeFieldInfoPtr_isEyeBoneLookUpSet;

		// Token: 0x04006455 RID: 25685
		private static readonly IntPtr NativeFieldInfoPtr_isEyeBallLookDownSet;

		// Token: 0x04006456 RID: 25686
		private static readonly IntPtr NativeFieldInfoPtr_isEyeBoneLookDownSet;

		// Token: 0x04006457 RID: 25687
		private static readonly IntPtr NativeFieldInfoPtr_leftBoneEyeRotationLimiter;

		// Token: 0x04006458 RID: 25688
		private static readonly IntPtr NativeFieldInfoPtr_rightBoneEyeRotationLimiter;

		// Token: 0x04006459 RID: 25689
		private static readonly IntPtr NativeFieldInfoPtr_leftEyeballEyeRotationLimiter;

		// Token: 0x0400645A RID: 25690
		private static readonly IntPtr NativeFieldInfoPtr_rightEyeballEyeRotationLimiter;

		// Token: 0x0400645B RID: 25691
		private static readonly IntPtr NativeFieldInfoPtr_eyelidControl;

		// Token: 0x0400645C RID: 25692
		private static readonly IntPtr NativeFieldInfoPtr_eyelidBoneMode;

		// Token: 0x0400645D RID: 25693
		private static readonly IntPtr NativeFieldInfoPtr_eyelidsFollowEyesVertically;

		// Token: 0x0400645E RID: 25694
		private static readonly IntPtr NativeFieldInfoPtr_upperEyeLidLeft;

		// Token: 0x0400645F RID: 25695
		private static readonly IntPtr NativeFieldInfoPtr_upperEyeLidRight;

		// Token: 0x04006460 RID: 25696
		private static readonly IntPtr NativeFieldInfoPtr_lowerEyeLidLeft;

		// Token: 0x04006461 RID: 25697
		private static readonly IntPtr NativeFieldInfoPtr_lowerEyeLidRight;

		// Token: 0x04006462 RID: 25698
		private static readonly IntPtr NativeFieldInfoPtr_isEyelidBonesDefaultSet;

		// Token: 0x04006463 RID: 25699
		private static readonly IntPtr NativeFieldInfoPtr_isEyelidBonesClosedSet;

		// Token: 0x04006464 RID: 25700
		private static readonly IntPtr NativeFieldInfoPtr_isEyelidBonesLookUpSet;

		// Token: 0x04006465 RID: 25701
		private static readonly IntPtr NativeFieldInfoPtr_isEyelidBonesLookDownSet;

		// Token: 0x04006466 RID: 25702
		private static readonly IntPtr NativeFieldInfoPtr_upperLeftLimiter;

		// Token: 0x04006467 RID: 25703
		private static readonly IntPtr NativeFieldInfoPtr_upperRightLimiter;

		// Token: 0x04006468 RID: 25704
		private static readonly IntPtr NativeFieldInfoPtr_lowerLeftLimiter;

		// Token: 0x04006469 RID: 25705
		private static readonly IntPtr NativeFieldInfoPtr_lowerRightLimiter;

		// Token: 0x0400646A RID: 25706
		private static readonly IntPtr NativeFieldInfoPtr_eyeWidenOrSquint;

		// Token: 0x0400646B RID: 25707
		private static readonly IntPtr NativeFieldInfoPtr_blendshapesForBlinking;

		// Token: 0x0400646C RID: 25708
		private static readonly IntPtr NativeFieldInfoPtr_blendshapesForLookingUp;

		// Token: 0x0400646D RID: 25709
		private static readonly IntPtr NativeFieldInfoPtr_blendshapesForLookingDown;

		// Token: 0x0400646E RID: 25710
		private static readonly IntPtr NativeFieldInfoPtr_blendshapesConfigs;

		// Token: 0x0400646F RID: 25711
		private static readonly IntPtr NativeFieldInfoPtr_isEyelidBlendshapeDefaultSet;

		// Token: 0x04006470 RID: 25712
		private static readonly IntPtr NativeFieldInfoPtr_isEyelidBlendshapeClosedSet;

		// Token: 0x04006471 RID: 25713
		private static readonly IntPtr NativeFieldInfoPtr_isEyelidBlendshapeLookUpSet;

		// Token: 0x04006472 RID: 25714
		private static readonly IntPtr NativeFieldInfoPtr_isEyelidBlendshapeLookDownSet;

		// Token: 0x04006473 RID: 25715
		private static readonly IntPtr NativeMethodInfoPtr_CanImport_Public_Boolean_ControlDataForExport_Transform_0;

		// Token: 0x04006474 RID: 25716
		private static readonly IntPtr NativeMethodInfoPtr_CheckConsistency_Public_Void_Animator_EyeAndHeadAnimator_0;

		// Token: 0x04006475 RID: 25717
		private static readonly IntPtr NativeMethodInfoPtr_ClampLeftVertEyeAngle_Public_Single_Single_0;

		// Token: 0x04006476 RID: 25718
		private static readonly IntPtr NativeMethodInfoPtr_ClampRightVertEyeAngle_Public_Single_Single_0;

		// Token: 0x04006477 RID: 25719
		private static readonly IntPtr NativeMethodInfoPtr_GetExport_Public_ControlDataForExport_Transform_0;

		// Token: 0x04006478 RID: 25720
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Void_ControlDataForExport_Transform_0;

		// Token: 0x04006479 RID: 25721
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Transform_0;

		// Token: 0x0400647A RID: 25722
		private static readonly IntPtr NativeMethodInfoPtr_LerpBlendshapeConfig_Private_Void_ArrayOf_EyelidPositionBlendshape_Single_Boolean_0;

		// Token: 0x0400647B RID: 25723
		private static readonly IntPtr NativeMethodInfoPtr_NeedsSaveDefaultBlendshapeConfig_Public_Boolean_0;

		// Token: 0x0400647C RID: 25724
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x0400647D RID: 25725
		private static readonly IntPtr NativeMethodInfoPtr_ResetBlendshapeConfig_Private_Void_ArrayOf_EyelidPositionBlendshape_0;

		// Token: 0x0400647E RID: 25726
		private static readonly IntPtr NativeMethodInfoPtr_ResetAllBlendshapesToDefault_Private_Void_0;

		// Token: 0x0400647F RID: 25727
		private static readonly IntPtr NativeMethodInfoPtr_RestoreClosed_Public_Void_0;

		// Token: 0x04006480 RID: 25728
		private static readonly IntPtr NativeMethodInfoPtr_RestoreDefault_Public_Void_Boolean_0;

		// Token: 0x04006481 RID: 25729
		private static readonly IntPtr NativeMethodInfoPtr_RestoreLookDown_Public_Void_0;

		// Token: 0x04006482 RID: 25730
		private static readonly IntPtr NativeMethodInfoPtr_RestoreLookUp_Public_Void_0;

		// Token: 0x04006483 RID: 25731
		private static readonly IntPtr NativeMethodInfoPtr_SaveBlendshapesForEyelidPosition_Private_Void_byref_ArrayOf_EyelidPositionBlendshape_Object_String_0;

		// Token: 0x04006484 RID: 25732
		private static readonly IntPtr NativeMethodInfoPtr_SaveClosed_Public_Void_Object_0;

		// Token: 0x04006485 RID: 25733
		private static readonly IntPtr NativeMethodInfoPtr_SaveDefault_Public_Void_Object_0;

		// Token: 0x04006486 RID: 25734
		private static readonly IntPtr NativeMethodInfoPtr_SaveLookDown_Public_Void_Object_0;

		// Token: 0x04006487 RID: 25735
		private static readonly IntPtr NativeMethodInfoPtr_SaveLookUp_Public_Void_Object_0;

		// Token: 0x04006488 RID: 25736
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEyelids_Public_Void_Single_Single_Single_Boolean_0;

		// Token: 0x04006489 RID: 25737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000776 RID: 1910
		[Serializable]
		public class ControlDataForExport : Il2CppSystem.Object
		{
			// Token: 0x06009E44 RID: 40516 RVA: 0x0028229C File Offset: 0x0028049C
			[CallerCount(0)]
			public unsafe ControlDataForExport() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.ControlDataForExport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06009E45 RID: 40517 RVA: 0x002822E8 File Offset: 0x002804E8
			// Note: this type is marked as 'beforefieldinit'.
			static ControlDataForExport()
			{
				Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "ControlDataForExport");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr);
				ControlData.ControlDataForExport.NativeFieldInfoPtr_eyeControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "eyeControl");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_eyelidBoneMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "eyelidBoneMode");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_leftEyePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "leftEyePath");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_rightEyePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "rightEyePath");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_maxEyeUpBoneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "maxEyeUpBoneAngle");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_maxEyeDownBoneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "maxEyeDownBoneAngle");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_maxEyeUpEyeballAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "maxEyeUpEyeballAngle");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_maxEyeDownEyeballAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "maxEyeDownEyeballAngle");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBallDefaultSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyeBallDefaultSet");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBoneDefaultSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyeBoneDefaultSet");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBallLookUpSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyeBallLookUpSet");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBoneLookUpSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyeBoneLookUpSet");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBallLookDownSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyeBallLookDownSet");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBoneLookDownSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyeBoneLookDownSet");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_leftBoneEyeRotationLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "leftBoneEyeRotationLimiter");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_rightBoneEyeRotationLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "rightBoneEyeRotationLimiter");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_leftEyeballEyeRotationLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "leftEyeballEyeRotationLimiter");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_rightEyeballEyeRotationLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "rightEyeballEyeRotationLimiter");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_eyelidControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "eyelidControl");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_eyelidsFollowEyesVertically = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "eyelidsFollowEyesVertically");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_upperEyeLidLeftPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "upperEyeLidLeftPath");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_upperEyeLidRightPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "upperEyeLidRightPath");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_lowerEyeLidLeftPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "lowerEyeLidLeftPath");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_lowerEyeLidRightPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "lowerEyeLidRightPath");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBonesDefaultSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyelidBonesDefaultSet");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBonesClosedSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyelidBonesClosedSet");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBonesLookUpSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyelidBonesLookUpSet");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBonesLookDownSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyelidBonesLookDownSet");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_upperLeftLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "upperLeftLimiter");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_upperRightLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "upperRightLimiter");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_lowerLeftLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "lowerLeftLimiter");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_lowerRightLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "lowerRightLimiter");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_eyeWidenOrSquint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "eyeWidenOrSquint");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_blendshapesForBlinking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "blendshapesForBlinking");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_blendshapesForLookingUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "blendshapesForLookingUp");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_blendshapesForLookingDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "blendshapesForLookingDown");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_blendshapesConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "blendshapesConfigs");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBlendshapeDefaultSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyelidBlendshapeDefaultSet");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBlendshapeClosedSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyelidBlendshapeClosedSet");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBlendshapeLookUpSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyelidBlendshapeLookUpSet");
				ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBlendshapeLookDownSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, "isEyelidBlendshapeLookDownSet");
				ControlData.ControlDataForExport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr, 100675948);
			}

			// Token: 0x06009E46 RID: 40518 RVA: 0x00002988 File Offset: 0x00000B88
			public ControlDataForExport(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x1700389B RID: 14491
			// (get) Token: 0x06009E47 RID: 40519 RVA: 0x0028265B File Offset: 0x0028085B
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ControlData.ControlDataForExport>.NativeClassPtr));
				}
			}

			// Token: 0x1700389C RID: 14492
			// (get) Token: 0x06009E48 RID: 40520 RVA: 0x0028266C File Offset: 0x0028086C
			// (set) Token: 0x06009E49 RID: 40521 RVA: 0x00282694 File Offset: 0x00280894
			public unsafe ControlData.EyeControl eyeControl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_eyeControl);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_eyeControl)) = value;
				}
			}

			// Token: 0x1700389D RID: 14493
			// (get) Token: 0x06009E4A RID: 40522 RVA: 0x002826B8 File Offset: 0x002808B8
			// (set) Token: 0x06009E4B RID: 40523 RVA: 0x002826E0 File Offset: 0x002808E0
			public unsafe ControlData.EyelidBoneMode eyelidBoneMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_eyelidBoneMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_eyelidBoneMode)) = value;
				}
			}

			// Token: 0x1700389E RID: 14494
			// (get) Token: 0x06009E4C RID: 40524 RVA: 0x00282704 File Offset: 0x00280904
			// (set) Token: 0x06009E4D RID: 40525 RVA: 0x0028272D File Offset: 0x0028092D
			public unsafe string leftEyePath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_leftEyePath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_leftEyePath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700389F RID: 14495
			// (get) Token: 0x06009E4E RID: 40526 RVA: 0x00282754 File Offset: 0x00280954
			// (set) Token: 0x06009E4F RID: 40527 RVA: 0x0028277D File Offset: 0x0028097D
			public unsafe string rightEyePath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_rightEyePath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_rightEyePath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170038A0 RID: 14496
			// (get) Token: 0x06009E50 RID: 40528 RVA: 0x002827A4 File Offset: 0x002809A4
			// (set) Token: 0x06009E51 RID: 40529 RVA: 0x002827CC File Offset: 0x002809CC
			public unsafe float maxEyeUpBoneAngle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_maxEyeUpBoneAngle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_maxEyeUpBoneAngle)) = value;
				}
			}

			// Token: 0x170038A1 RID: 14497
			// (get) Token: 0x06009E52 RID: 40530 RVA: 0x002827F0 File Offset: 0x002809F0
			// (set) Token: 0x06009E53 RID: 40531 RVA: 0x00282818 File Offset: 0x00280A18
			public unsafe float maxEyeDownBoneAngle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_maxEyeDownBoneAngle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_maxEyeDownBoneAngle)) = value;
				}
			}

			// Token: 0x170038A2 RID: 14498
			// (get) Token: 0x06009E54 RID: 40532 RVA: 0x0028283C File Offset: 0x00280A3C
			// (set) Token: 0x06009E55 RID: 40533 RVA: 0x00282864 File Offset: 0x00280A64
			public unsafe float maxEyeUpEyeballAngle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_maxEyeUpEyeballAngle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_maxEyeUpEyeballAngle)) = value;
				}
			}

			// Token: 0x170038A3 RID: 14499
			// (get) Token: 0x06009E56 RID: 40534 RVA: 0x00282888 File Offset: 0x00280A88
			// (set) Token: 0x06009E57 RID: 40535 RVA: 0x002828B0 File Offset: 0x00280AB0
			public unsafe float maxEyeDownEyeballAngle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_maxEyeDownEyeballAngle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_maxEyeDownEyeballAngle)) = value;
				}
			}

			// Token: 0x170038A4 RID: 14500
			// (get) Token: 0x06009E58 RID: 40536 RVA: 0x002828D4 File Offset: 0x00280AD4
			// (set) Token: 0x06009E59 RID: 40537 RVA: 0x002828FC File Offset: 0x00280AFC
			public unsafe bool isEyeBallDefaultSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBallDefaultSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBallDefaultSet)) = value;
				}
			}

			// Token: 0x170038A5 RID: 14501
			// (get) Token: 0x06009E5A RID: 40538 RVA: 0x00282920 File Offset: 0x00280B20
			// (set) Token: 0x06009E5B RID: 40539 RVA: 0x00282948 File Offset: 0x00280B48
			public unsafe bool isEyeBoneDefaultSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBoneDefaultSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBoneDefaultSet)) = value;
				}
			}

			// Token: 0x170038A6 RID: 14502
			// (get) Token: 0x06009E5C RID: 40540 RVA: 0x0028296C File Offset: 0x00280B6C
			// (set) Token: 0x06009E5D RID: 40541 RVA: 0x00282994 File Offset: 0x00280B94
			public unsafe bool isEyeBallLookUpSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBallLookUpSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBallLookUpSet)) = value;
				}
			}

			// Token: 0x170038A7 RID: 14503
			// (get) Token: 0x06009E5E RID: 40542 RVA: 0x002829B8 File Offset: 0x00280BB8
			// (set) Token: 0x06009E5F RID: 40543 RVA: 0x002829E0 File Offset: 0x00280BE0
			public unsafe bool isEyeBoneLookUpSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBoneLookUpSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBoneLookUpSet)) = value;
				}
			}

			// Token: 0x170038A8 RID: 14504
			// (get) Token: 0x06009E60 RID: 40544 RVA: 0x00282A04 File Offset: 0x00280C04
			// (set) Token: 0x06009E61 RID: 40545 RVA: 0x00282A2C File Offset: 0x00280C2C
			public unsafe bool isEyeBallLookDownSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBallLookDownSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBallLookDownSet)) = value;
				}
			}

			// Token: 0x170038A9 RID: 14505
			// (get) Token: 0x06009E62 RID: 40546 RVA: 0x00282A50 File Offset: 0x00280C50
			// (set) Token: 0x06009E63 RID: 40547 RVA: 0x00282A78 File Offset: 0x00280C78
			public unsafe bool isEyeBoneLookDownSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBoneLookDownSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyeBoneLookDownSet)) = value;
				}
			}

			// Token: 0x170038AA RID: 14506
			// (get) Token: 0x06009E64 RID: 40548 RVA: 0x00282A9C File Offset: 0x00280C9C
			// (set) Token: 0x06009E65 RID: 40549 RVA: 0x00282AD0 File Offset: 0x00280CD0
			public unsafe EyeRotationLimiter.EyeRotationLimiterForExport leftBoneEyeRotationLimiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_leftBoneEyeRotationLimiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new EyeRotationLimiter.EyeRotationLimiterForExport(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_leftBoneEyeRotationLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038AB RID: 14507
			// (get) Token: 0x06009E66 RID: 40550 RVA: 0x00282AF8 File Offset: 0x00280CF8
			// (set) Token: 0x06009E67 RID: 40551 RVA: 0x00282B2C File Offset: 0x00280D2C
			public unsafe EyeRotationLimiter.EyeRotationLimiterForExport rightBoneEyeRotationLimiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_rightBoneEyeRotationLimiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new EyeRotationLimiter.EyeRotationLimiterForExport(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_rightBoneEyeRotationLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038AC RID: 14508
			// (get) Token: 0x06009E68 RID: 40552 RVA: 0x00282B54 File Offset: 0x00280D54
			// (set) Token: 0x06009E69 RID: 40553 RVA: 0x00282B88 File Offset: 0x00280D88
			public unsafe EyeRotationLimiter.EyeRotationLimiterForExport leftEyeballEyeRotationLimiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_leftEyeballEyeRotationLimiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new EyeRotationLimiter.EyeRotationLimiterForExport(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_leftEyeballEyeRotationLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038AD RID: 14509
			// (get) Token: 0x06009E6A RID: 40554 RVA: 0x00282BB0 File Offset: 0x00280DB0
			// (set) Token: 0x06009E6B RID: 40555 RVA: 0x00282BE4 File Offset: 0x00280DE4
			public unsafe EyeRotationLimiter.EyeRotationLimiterForExport rightEyeballEyeRotationLimiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_rightEyeballEyeRotationLimiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new EyeRotationLimiter.EyeRotationLimiterForExport(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_rightEyeballEyeRotationLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038AE RID: 14510
			// (get) Token: 0x06009E6C RID: 40556 RVA: 0x00282C0C File Offset: 0x00280E0C
			// (set) Token: 0x06009E6D RID: 40557 RVA: 0x00282C34 File Offset: 0x00280E34
			public unsafe ControlData.EyelidControl eyelidControl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_eyelidControl);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_eyelidControl)) = value;
				}
			}

			// Token: 0x170038AF RID: 14511
			// (get) Token: 0x06009E6E RID: 40558 RVA: 0x00282C58 File Offset: 0x00280E58
			// (set) Token: 0x06009E6F RID: 40559 RVA: 0x00282C80 File Offset: 0x00280E80
			public unsafe bool eyelidsFollowEyesVertically
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_eyelidsFollowEyesVertically);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_eyelidsFollowEyesVertically)) = value;
				}
			}

			// Token: 0x170038B0 RID: 14512
			// (get) Token: 0x06009E70 RID: 40560 RVA: 0x00282CA4 File Offset: 0x00280EA4
			// (set) Token: 0x06009E71 RID: 40561 RVA: 0x00282CCD File Offset: 0x00280ECD
			public unsafe string upperEyeLidLeftPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_upperEyeLidLeftPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_upperEyeLidLeftPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170038B1 RID: 14513
			// (get) Token: 0x06009E72 RID: 40562 RVA: 0x00282CF4 File Offset: 0x00280EF4
			// (set) Token: 0x06009E73 RID: 40563 RVA: 0x00282D1D File Offset: 0x00280F1D
			public unsafe string upperEyeLidRightPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_upperEyeLidRightPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_upperEyeLidRightPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170038B2 RID: 14514
			// (get) Token: 0x06009E74 RID: 40564 RVA: 0x00282D44 File Offset: 0x00280F44
			// (set) Token: 0x06009E75 RID: 40565 RVA: 0x00282D6D File Offset: 0x00280F6D
			public unsafe string lowerEyeLidLeftPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_lowerEyeLidLeftPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_lowerEyeLidLeftPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170038B3 RID: 14515
			// (get) Token: 0x06009E76 RID: 40566 RVA: 0x00282D94 File Offset: 0x00280F94
			// (set) Token: 0x06009E77 RID: 40567 RVA: 0x00282DBD File Offset: 0x00280FBD
			public unsafe string lowerEyeLidRightPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_lowerEyeLidRightPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_lowerEyeLidRightPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170038B4 RID: 14516
			// (get) Token: 0x06009E78 RID: 40568 RVA: 0x00282DE4 File Offset: 0x00280FE4
			// (set) Token: 0x06009E79 RID: 40569 RVA: 0x00282E0C File Offset: 0x0028100C
			public unsafe bool isEyelidBonesDefaultSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBonesDefaultSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBonesDefaultSet)) = value;
				}
			}

			// Token: 0x170038B5 RID: 14517
			// (get) Token: 0x06009E7A RID: 40570 RVA: 0x00282E30 File Offset: 0x00281030
			// (set) Token: 0x06009E7B RID: 40571 RVA: 0x00282E58 File Offset: 0x00281058
			public unsafe bool isEyelidBonesClosedSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBonesClosedSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBonesClosedSet)) = value;
				}
			}

			// Token: 0x170038B6 RID: 14518
			// (get) Token: 0x06009E7C RID: 40572 RVA: 0x00282E7C File Offset: 0x0028107C
			// (set) Token: 0x06009E7D RID: 40573 RVA: 0x00282EA4 File Offset: 0x002810A4
			public unsafe bool isEyelidBonesLookUpSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBonesLookUpSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBonesLookUpSet)) = value;
				}
			}

			// Token: 0x170038B7 RID: 14519
			// (get) Token: 0x06009E7E RID: 40574 RVA: 0x00282EC8 File Offset: 0x002810C8
			// (set) Token: 0x06009E7F RID: 40575 RVA: 0x00282EF0 File Offset: 0x002810F0
			public unsafe bool isEyelidBonesLookDownSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBonesLookDownSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBonesLookDownSet)) = value;
				}
			}

			// Token: 0x170038B8 RID: 14520
			// (get) Token: 0x06009E80 RID: 40576 RVA: 0x00282F14 File Offset: 0x00281114
			// (set) Token: 0x06009E81 RID: 40577 RVA: 0x00282F48 File Offset: 0x00281148
			public unsafe EyelidRotationLimiter.EyelidRotationLimiterForExport upperLeftLimiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_upperLeftLimiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new EyelidRotationLimiter.EyelidRotationLimiterForExport(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_upperLeftLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038B9 RID: 14521
			// (get) Token: 0x06009E82 RID: 40578 RVA: 0x00282F70 File Offset: 0x00281170
			// (set) Token: 0x06009E83 RID: 40579 RVA: 0x00282FA4 File Offset: 0x002811A4
			public unsafe EyelidRotationLimiter.EyelidRotationLimiterForExport upperRightLimiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_upperRightLimiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new EyelidRotationLimiter.EyelidRotationLimiterForExport(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_upperRightLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038BA RID: 14522
			// (get) Token: 0x06009E84 RID: 40580 RVA: 0x00282FCC File Offset: 0x002811CC
			// (set) Token: 0x06009E85 RID: 40581 RVA: 0x00283000 File Offset: 0x00281200
			public unsafe EyelidRotationLimiter.EyelidRotationLimiterForExport lowerLeftLimiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_lowerLeftLimiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new EyelidRotationLimiter.EyelidRotationLimiterForExport(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_lowerLeftLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038BB RID: 14523
			// (get) Token: 0x06009E86 RID: 40582 RVA: 0x00283028 File Offset: 0x00281228
			// (set) Token: 0x06009E87 RID: 40583 RVA: 0x0028305C File Offset: 0x0028125C
			public unsafe EyelidRotationLimiter.EyelidRotationLimiterForExport lowerRightLimiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_lowerRightLimiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new EyelidRotationLimiter.EyelidRotationLimiterForExport(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_lowerRightLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038BC RID: 14524
			// (get) Token: 0x06009E88 RID: 40584 RVA: 0x00283084 File Offset: 0x00281284
			// (set) Token: 0x06009E89 RID: 40585 RVA: 0x002830AC File Offset: 0x002812AC
			public unsafe float eyeWidenOrSquint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_eyeWidenOrSquint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_eyeWidenOrSquint)) = value;
				}
			}

			// Token: 0x170038BD RID: 14525
			// (get) Token: 0x06009E8A RID: 40586 RVA: 0x002830D0 File Offset: 0x002812D0
			// (set) Token: 0x06009E8B RID: 40587 RVA: 0x00283104 File Offset: 0x00281304
			public unsafe Il2CppReferenceArray<ControlData.EyelidPositionBlendshapeForExport> blendshapesForBlinking
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_blendshapesForBlinking);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppReferenceArray<ControlData.EyelidPositionBlendshapeForExport>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_blendshapesForBlinking), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038BE RID: 14526
			// (get) Token: 0x06009E8C RID: 40588 RVA: 0x0028312C File Offset: 0x0028132C
			// (set) Token: 0x06009E8D RID: 40589 RVA: 0x00283160 File Offset: 0x00281360
			public unsafe Il2CppReferenceArray<ControlData.EyelidPositionBlendshapeForExport> blendshapesForLookingUp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_blendshapesForLookingUp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppReferenceArray<ControlData.EyelidPositionBlendshapeForExport>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_blendshapesForLookingUp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038BF RID: 14527
			// (get) Token: 0x06009E8E RID: 40590 RVA: 0x00283188 File Offset: 0x00281388
			// (set) Token: 0x06009E8F RID: 40591 RVA: 0x002831BC File Offset: 0x002813BC
			public unsafe Il2CppReferenceArray<ControlData.EyelidPositionBlendshapeForExport> blendshapesForLookingDown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_blendshapesForLookingDown);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppReferenceArray<ControlData.EyelidPositionBlendshapeForExport>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_blendshapesForLookingDown), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038C0 RID: 14528
			// (get) Token: 0x06009E90 RID: 40592 RVA: 0x002831E4 File Offset: 0x002813E4
			// (set) Token: 0x06009E91 RID: 40593 RVA: 0x00283218 File Offset: 0x00281418
			public unsafe Il2CppReferenceArray<ControlData.BlendshapesConfigForExport> blendshapesConfigs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_blendshapesConfigs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppReferenceArray<ControlData.BlendshapesConfigForExport>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_blendshapesConfigs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038C1 RID: 14529
			// (get) Token: 0x06009E92 RID: 40594 RVA: 0x00283240 File Offset: 0x00281440
			// (set) Token: 0x06009E93 RID: 40595 RVA: 0x00283268 File Offset: 0x00281468
			public unsafe bool isEyelidBlendshapeDefaultSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBlendshapeDefaultSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBlendshapeDefaultSet)) = value;
				}
			}

			// Token: 0x170038C2 RID: 14530
			// (get) Token: 0x06009E94 RID: 40596 RVA: 0x0028328C File Offset: 0x0028148C
			// (set) Token: 0x06009E95 RID: 40597 RVA: 0x002832B4 File Offset: 0x002814B4
			public unsafe bool isEyelidBlendshapeClosedSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBlendshapeClosedSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBlendshapeClosedSet)) = value;
				}
			}

			// Token: 0x170038C3 RID: 14531
			// (get) Token: 0x06009E96 RID: 40598 RVA: 0x002832D8 File Offset: 0x002814D8
			// (set) Token: 0x06009E97 RID: 40599 RVA: 0x00283300 File Offset: 0x00281500
			public unsafe bool isEyelidBlendshapeLookUpSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBlendshapeLookUpSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBlendshapeLookUpSet)) = value;
				}
			}

			// Token: 0x170038C4 RID: 14532
			// (get) Token: 0x06009E98 RID: 40600 RVA: 0x00283324 File Offset: 0x00281524
			// (set) Token: 0x06009E99 RID: 40601 RVA: 0x0028334C File Offset: 0x0028154C
			public unsafe bool isEyelidBlendshapeLookDownSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBlendshapeLookDownSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.ControlDataForExport.NativeFieldInfoPtr_isEyelidBlendshapeLookDownSet)) = value;
				}
			}

			// Token: 0x0400648A RID: 25738
			private static readonly IntPtr NativeFieldInfoPtr_eyeControl;

			// Token: 0x0400648B RID: 25739
			private static readonly IntPtr NativeFieldInfoPtr_eyelidBoneMode;

			// Token: 0x0400648C RID: 25740
			private static readonly IntPtr NativeFieldInfoPtr_leftEyePath;

			// Token: 0x0400648D RID: 25741
			private static readonly IntPtr NativeFieldInfoPtr_rightEyePath;

			// Token: 0x0400648E RID: 25742
			private static readonly IntPtr NativeFieldInfoPtr_maxEyeUpBoneAngle;

			// Token: 0x0400648F RID: 25743
			private static readonly IntPtr NativeFieldInfoPtr_maxEyeDownBoneAngle;

			// Token: 0x04006490 RID: 25744
			private static readonly IntPtr NativeFieldInfoPtr_maxEyeUpEyeballAngle;

			// Token: 0x04006491 RID: 25745
			private static readonly IntPtr NativeFieldInfoPtr_maxEyeDownEyeballAngle;

			// Token: 0x04006492 RID: 25746
			private static readonly IntPtr NativeFieldInfoPtr_isEyeBallDefaultSet;

			// Token: 0x04006493 RID: 25747
			private static readonly IntPtr NativeFieldInfoPtr_isEyeBoneDefaultSet;

			// Token: 0x04006494 RID: 25748
			private static readonly IntPtr NativeFieldInfoPtr_isEyeBallLookUpSet;

			// Token: 0x04006495 RID: 25749
			private static readonly IntPtr NativeFieldInfoPtr_isEyeBoneLookUpSet;

			// Token: 0x04006496 RID: 25750
			private static readonly IntPtr NativeFieldInfoPtr_isEyeBallLookDownSet;

			// Token: 0x04006497 RID: 25751
			private static readonly IntPtr NativeFieldInfoPtr_isEyeBoneLookDownSet;

			// Token: 0x04006498 RID: 25752
			private static readonly IntPtr NativeFieldInfoPtr_leftBoneEyeRotationLimiter;

			// Token: 0x04006499 RID: 25753
			private static readonly IntPtr NativeFieldInfoPtr_rightBoneEyeRotationLimiter;

			// Token: 0x0400649A RID: 25754
			private static readonly IntPtr NativeFieldInfoPtr_leftEyeballEyeRotationLimiter;

			// Token: 0x0400649B RID: 25755
			private static readonly IntPtr NativeFieldInfoPtr_rightEyeballEyeRotationLimiter;

			// Token: 0x0400649C RID: 25756
			private static readonly IntPtr NativeFieldInfoPtr_eyelidControl;

			// Token: 0x0400649D RID: 25757
			private static readonly IntPtr NativeFieldInfoPtr_eyelidsFollowEyesVertically;

			// Token: 0x0400649E RID: 25758
			private static readonly IntPtr NativeFieldInfoPtr_upperEyeLidLeftPath;

			// Token: 0x0400649F RID: 25759
			private static readonly IntPtr NativeFieldInfoPtr_upperEyeLidRightPath;

			// Token: 0x040064A0 RID: 25760
			private static readonly IntPtr NativeFieldInfoPtr_lowerEyeLidLeftPath;

			// Token: 0x040064A1 RID: 25761
			private static readonly IntPtr NativeFieldInfoPtr_lowerEyeLidRightPath;

			// Token: 0x040064A2 RID: 25762
			private static readonly IntPtr NativeFieldInfoPtr_isEyelidBonesDefaultSet;

			// Token: 0x040064A3 RID: 25763
			private static readonly IntPtr NativeFieldInfoPtr_isEyelidBonesClosedSet;

			// Token: 0x040064A4 RID: 25764
			private static readonly IntPtr NativeFieldInfoPtr_isEyelidBonesLookUpSet;

			// Token: 0x040064A5 RID: 25765
			private static readonly IntPtr NativeFieldInfoPtr_isEyelidBonesLookDownSet;

			// Token: 0x040064A6 RID: 25766
			private static readonly IntPtr NativeFieldInfoPtr_upperLeftLimiter;

			// Token: 0x040064A7 RID: 25767
			private static readonly IntPtr NativeFieldInfoPtr_upperRightLimiter;

			// Token: 0x040064A8 RID: 25768
			private static readonly IntPtr NativeFieldInfoPtr_lowerLeftLimiter;

			// Token: 0x040064A9 RID: 25769
			private static readonly IntPtr NativeFieldInfoPtr_lowerRightLimiter;

			// Token: 0x040064AA RID: 25770
			private static readonly IntPtr NativeFieldInfoPtr_eyeWidenOrSquint;

			// Token: 0x040064AB RID: 25771
			private static readonly IntPtr NativeFieldInfoPtr_blendshapesForBlinking;

			// Token: 0x040064AC RID: 25772
			private static readonly IntPtr NativeFieldInfoPtr_blendshapesForLookingUp;

			// Token: 0x040064AD RID: 25773
			private static readonly IntPtr NativeFieldInfoPtr_blendshapesForLookingDown;

			// Token: 0x040064AE RID: 25774
			private static readonly IntPtr NativeFieldInfoPtr_blendshapesConfigs;

			// Token: 0x040064AF RID: 25775
			private static readonly IntPtr NativeFieldInfoPtr_isEyelidBlendshapeDefaultSet;

			// Token: 0x040064B0 RID: 25776
			private static readonly IntPtr NativeFieldInfoPtr_isEyelidBlendshapeClosedSet;

			// Token: 0x040064B1 RID: 25777
			private static readonly IntPtr NativeFieldInfoPtr_isEyelidBlendshapeLookUpSet;

			// Token: 0x040064B2 RID: 25778
			private static readonly IntPtr NativeFieldInfoPtr_isEyelidBlendshapeLookDownSet;

			// Token: 0x040064B3 RID: 25779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000777 RID: 1911
		public enum EyeControl
		{
			// Token: 0x040064B5 RID: 25781
			None,
			// Token: 0x040064B6 RID: 25782
			MecanimEyeBones,
			// Token: 0x040064B7 RID: 25783
			SelectedObjects
		}

		// Token: 0x02000778 RID: 1912
		public enum EyelidControl
		{
			// Token: 0x040064B9 RID: 25785
			None,
			// Token: 0x040064BA RID: 25786
			Bones,
			// Token: 0x040064BB RID: 25787
			Blendshapes,
			// Token: 0x040064BC RID: 25788
			MCS_Blendshapes
		}

		// Token: 0x02000779 RID: 1913
		public enum EyelidBoneMode
		{
			// Token: 0x040064BE RID: 25790
			RotationAndPosition,
			// Token: 0x040064BF RID: 25791
			Rotation,
			// Token: 0x040064C0 RID: 25792
			Position
		}

		// Token: 0x0200077A RID: 1914
		[Serializable]
		public class EyelidPositionBlendshapeForExport : Il2CppSystem.Object
		{
			// Token: 0x06009EA0 RID: 40608 RVA: 0x002833E4 File Offset: 0x002815E4
			[CallerCount(0)]
			public unsafe EyelidPositionBlendshapeForExport() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshapeForExport>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.EyelidPositionBlendshapeForExport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06009EA1 RID: 40609 RVA: 0x00283430 File Offset: 0x00281630
			// Note: this type is marked as 'beforefieldinit'.
			static EyelidPositionBlendshapeForExport()
			{
				Il2CppClassPointerStore<ControlData.EyelidPositionBlendshapeForExport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "EyelidPositionBlendshapeForExport");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshapeForExport>.NativeClassPtr);
				ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_skinnedMeshRendererPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshapeForExport>.NativeClassPtr, "skinnedMeshRendererPath");
				ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_defaultWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshapeForExport>.NativeClassPtr, "defaultWeight");
				ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_positionWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshapeForExport>.NativeClassPtr, "positionWeight");
				ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshapeForExport>.NativeClassPtr, "index");
				ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshapeForExport>.NativeClassPtr, "name");
				ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_isUsedInEalierConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshapeForExport>.NativeClassPtr, "isUsedInEalierConfig");
				ControlData.EyelidPositionBlendshapeForExport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshapeForExport>.NativeClassPtr, 100675949);
			}

			// Token: 0x06009EA2 RID: 40610 RVA: 0x00002988 File Offset: 0x00000B88
			public EyelidPositionBlendshapeForExport(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x170038C8 RID: 14536
			// (get) Token: 0x06009EA3 RID: 40611 RVA: 0x002834E7 File Offset: 0x002816E7
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshapeForExport>.NativeClassPtr));
				}
			}

			// Token: 0x170038C9 RID: 14537
			// (get) Token: 0x06009EA4 RID: 40612 RVA: 0x002834F8 File Offset: 0x002816F8
			// (set) Token: 0x06009EA5 RID: 40613 RVA: 0x00283521 File Offset: 0x00281721
			public unsafe string skinnedMeshRendererPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_skinnedMeshRendererPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_skinnedMeshRendererPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170038CA RID: 14538
			// (get) Token: 0x06009EA6 RID: 40614 RVA: 0x00283548 File Offset: 0x00281748
			// (set) Token: 0x06009EA7 RID: 40615 RVA: 0x00283570 File Offset: 0x00281770
			public unsafe float defaultWeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_defaultWeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_defaultWeight)) = value;
				}
			}

			// Token: 0x170038CB RID: 14539
			// (get) Token: 0x06009EA8 RID: 40616 RVA: 0x00283594 File Offset: 0x00281794
			// (set) Token: 0x06009EA9 RID: 40617 RVA: 0x002835BC File Offset: 0x002817BC
			public unsafe float positionWeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_positionWeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_positionWeight)) = value;
				}
			}

			// Token: 0x170038CC RID: 14540
			// (get) Token: 0x06009EAA RID: 40618 RVA: 0x002835E0 File Offset: 0x002817E0
			// (set) Token: 0x06009EAB RID: 40619 RVA: 0x00283608 File Offset: 0x00281808
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170038CD RID: 14541
			// (get) Token: 0x06009EAC RID: 40620 RVA: 0x0028362C File Offset: 0x0028182C
			// (set) Token: 0x06009EAD RID: 40621 RVA: 0x00283655 File Offset: 0x00281855
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170038CE RID: 14542
			// (get) Token: 0x06009EAE RID: 40622 RVA: 0x0028367C File Offset: 0x0028187C
			// (set) Token: 0x06009EAF RID: 40623 RVA: 0x002836A4 File Offset: 0x002818A4
			public unsafe bool isUsedInEalierConfig
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_isUsedInEalierConfig);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshapeForExport.NativeFieldInfoPtr_isUsedInEalierConfig)) = value;
				}
			}

			// Token: 0x040064C1 RID: 25793
			private static readonly IntPtr NativeFieldInfoPtr_skinnedMeshRendererPath;

			// Token: 0x040064C2 RID: 25794
			private static readonly IntPtr NativeFieldInfoPtr_defaultWeight;

			// Token: 0x040064C3 RID: 25795
			private static readonly IntPtr NativeFieldInfoPtr_positionWeight;

			// Token: 0x040064C4 RID: 25796
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040064C5 RID: 25797
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040064C6 RID: 25798
			private static readonly IntPtr NativeFieldInfoPtr_isUsedInEalierConfig;

			// Token: 0x040064C7 RID: 25799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200077B RID: 1915
		[Serializable]
		public class EyelidPositionBlendshape : Il2CppSystem.Object
		{
			// Token: 0x06009EB0 RID: 40624 RVA: 0x002836C8 File Offset: 0x002818C8
			[CallerCount(0)]
			public unsafe static bool CanImport(ControlData.EyelidPositionBlendshapeForExport import, Transform startXform, ControlData.EyelidControl eyelidControl)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(import);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startXform);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eyelidControl;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ControlData.EyelidPositionBlendshape.NativeMethodInfoPtr_CanImport_Public_Static_Boolean_EyelidPositionBlendshapeForExport_Transform_EyelidControl_0, 0, (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06009EB1 RID: 40625 RVA: 0x0028374C File Offset: 0x0028194C
			[CallerCount(0)]
			public unsafe ControlData.EyelidPositionBlendshapeForExport GetExport(Transform startXform)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startXform);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.EyelidPositionBlendshape.NativeMethodInfoPtr_GetExport_Public_EyelidPositionBlendshapeForExport_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new ControlData.EyelidPositionBlendshapeForExport(intPtr2) : null;
			}

			// Token: 0x06009EB2 RID: 40626 RVA: 0x002837BC File Offset: 0x002819BC
			[CallerCount(0)]
			public unsafe void Import(ControlData.EyelidPositionBlendshapeForExport export, Transform startXform)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(export);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startXform);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.EyelidPositionBlendshape.NativeMethodInfoPtr_Import_Public_Void_EyelidPositionBlendshapeForExport_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06009EB3 RID: 40627 RVA: 0x00283830 File Offset: 0x00281A30
			[CallerCount(0)]
			public unsafe EyelidPositionBlendshape() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.EyelidPositionBlendshape.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06009EB4 RID: 40628 RVA: 0x0028387C File Offset: 0x00281A7C
			// Note: this type is marked as 'beforefieldinit'.
			static EyelidPositionBlendshape()
			{
				Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "EyelidPositionBlendshape");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr);
				ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_skinnedMeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr, "skinnedMeshRenderer");
				ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_defaultWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr, "defaultWeight");
				ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_positionWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr, "positionWeight");
				ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr, "index");
				ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr, "name");
				ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_isUsedInEalierConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr, "isUsedInEalierConfig");
				ControlData.EyelidPositionBlendshape.NativeMethodInfoPtr_CanImport_Public_Static_Boolean_EyelidPositionBlendshapeForExport_Transform_EyelidControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr, 100675950);
				ControlData.EyelidPositionBlendshape.NativeMethodInfoPtr_GetExport_Public_EyelidPositionBlendshapeForExport_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr, 100675951);
				ControlData.EyelidPositionBlendshape.NativeMethodInfoPtr_Import_Public_Void_EyelidPositionBlendshapeForExport_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr, 100675952);
				ControlData.EyelidPositionBlendshape.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr, 100675953);
			}

			// Token: 0x06009EB5 RID: 40629 RVA: 0x00002988 File Offset: 0x00000B88
			public EyelidPositionBlendshape(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x170038CF RID: 14543
			// (get) Token: 0x06009EB6 RID: 40630 RVA: 0x0028396F File Offset: 0x00281B6F
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ControlData.EyelidPositionBlendshape>.NativeClassPtr));
				}
			}

			// Token: 0x170038D0 RID: 14544
			// (get) Token: 0x06009EB7 RID: 40631 RVA: 0x00283980 File Offset: 0x00281B80
			// (set) Token: 0x06009EB8 RID: 40632 RVA: 0x002839B4 File Offset: 0x00281BB4
			public unsafe SkinnedMeshRenderer skinnedMeshRenderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_skinnedMeshRenderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new SkinnedMeshRenderer(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_skinnedMeshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038D1 RID: 14545
			// (get) Token: 0x06009EB9 RID: 40633 RVA: 0x002839DC File Offset: 0x00281BDC
			// (set) Token: 0x06009EBA RID: 40634 RVA: 0x00283A04 File Offset: 0x00281C04
			public unsafe float defaultWeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_defaultWeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_defaultWeight)) = value;
				}
			}

			// Token: 0x170038D2 RID: 14546
			// (get) Token: 0x06009EBB RID: 40635 RVA: 0x00283A28 File Offset: 0x00281C28
			// (set) Token: 0x06009EBC RID: 40636 RVA: 0x00283A50 File Offset: 0x00281C50
			public unsafe float positionWeight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_positionWeight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_positionWeight)) = value;
				}
			}

			// Token: 0x170038D3 RID: 14547
			// (get) Token: 0x06009EBD RID: 40637 RVA: 0x00283A74 File Offset: 0x00281C74
			// (set) Token: 0x06009EBE RID: 40638 RVA: 0x00283A9C File Offset: 0x00281C9C
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170038D4 RID: 14548
			// (get) Token: 0x06009EBF RID: 40639 RVA: 0x00283AC0 File Offset: 0x00281CC0
			// (set) Token: 0x06009EC0 RID: 40640 RVA: 0x00283AE9 File Offset: 0x00281CE9
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170038D5 RID: 14549
			// (get) Token: 0x06009EC1 RID: 40641 RVA: 0x00283B10 File Offset: 0x00281D10
			// (set) Token: 0x06009EC2 RID: 40642 RVA: 0x00283B38 File Offset: 0x00281D38
			public unsafe bool isUsedInEalierConfig
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_isUsedInEalierConfig);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.EyelidPositionBlendshape.NativeFieldInfoPtr_isUsedInEalierConfig)) = value;
				}
			}

			// Token: 0x040064C8 RID: 25800
			private static readonly IntPtr NativeFieldInfoPtr_skinnedMeshRenderer;

			// Token: 0x040064C9 RID: 25801
			private static readonly IntPtr NativeFieldInfoPtr_defaultWeight;

			// Token: 0x040064CA RID: 25802
			private static readonly IntPtr NativeFieldInfoPtr_positionWeight;

			// Token: 0x040064CB RID: 25803
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040064CC RID: 25804
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040064CD RID: 25805
			private static readonly IntPtr NativeFieldInfoPtr_isUsedInEalierConfig;

			// Token: 0x040064CE RID: 25806
			private static readonly IntPtr NativeMethodInfoPtr_CanImport_Public_Static_Boolean_EyelidPositionBlendshapeForExport_Transform_EyelidControl_0;

			// Token: 0x040064CF RID: 25807
			private static readonly IntPtr NativeMethodInfoPtr_GetExport_Public_EyelidPositionBlendshapeForExport_Transform_0;

			// Token: 0x040064D0 RID: 25808
			private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Void_EyelidPositionBlendshapeForExport_Transform_0;

			// Token: 0x040064D1 RID: 25809
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200077C RID: 1916
		[Serializable]
		public class BlendshapesConfigForExport : Il2CppSystem.Object
		{
			// Token: 0x06009EC3 RID: 40643 RVA: 0x00283B5C File Offset: 0x00281D5C
			[CallerCount(0)]
			public unsafe BlendshapesConfigForExport() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlData.BlendshapesConfigForExport>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.BlendshapesConfigForExport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06009EC4 RID: 40644 RVA: 0x00283BA8 File Offset: 0x00281DA8
			// Note: this type is marked as 'beforefieldinit'.
			static BlendshapesConfigForExport()
			{
				Il2CppClassPointerStore<ControlData.BlendshapesConfigForExport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "BlendshapesConfigForExport");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlData.BlendshapesConfigForExport>.NativeClassPtr);
				ControlData.BlendshapesConfigForExport.NativeFieldInfoPtr_skinnedMeshRendererPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.BlendshapesConfigForExport>.NativeClassPtr, "skinnedMeshRendererPath");
				ControlData.BlendshapesConfigForExport.NativeFieldInfoPtr_blendShapeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.BlendshapesConfigForExport>.NativeClassPtr, "blendShapeCount");
				ControlData.BlendshapesConfigForExport.NativeFieldInfoPtr_blendshapeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.BlendshapesConfigForExport>.NativeClassPtr, "blendshapeNames");
				ControlData.BlendshapesConfigForExport.NativeFieldInfoPtr_blendshapeWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.BlendshapesConfigForExport>.NativeClassPtr, "blendshapeWeights");
				ControlData.BlendshapesConfigForExport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData.BlendshapesConfigForExport>.NativeClassPtr, 100675954);
			}

			// Token: 0x06009EC5 RID: 40645 RVA: 0x00002988 File Offset: 0x00000B88
			public BlendshapesConfigForExport(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x170038D6 RID: 14550
			// (get) Token: 0x06009EC6 RID: 40646 RVA: 0x00283C37 File Offset: 0x00281E37
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ControlData.BlendshapesConfigForExport>.NativeClassPtr));
				}
			}

			// Token: 0x170038D7 RID: 14551
			// (get) Token: 0x06009EC7 RID: 40647 RVA: 0x00283C48 File Offset: 0x00281E48
			// (set) Token: 0x06009EC8 RID: 40648 RVA: 0x00283C71 File Offset: 0x00281E71
			public unsafe string skinnedMeshRendererPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfigForExport.NativeFieldInfoPtr_skinnedMeshRendererPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfigForExport.NativeFieldInfoPtr_skinnedMeshRendererPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170038D8 RID: 14552
			// (get) Token: 0x06009EC9 RID: 40649 RVA: 0x00283C98 File Offset: 0x00281E98
			// (set) Token: 0x06009ECA RID: 40650 RVA: 0x00283CC0 File Offset: 0x00281EC0
			public unsafe int blendShapeCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfigForExport.NativeFieldInfoPtr_blendShapeCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfigForExport.NativeFieldInfoPtr_blendShapeCount)) = value;
				}
			}

			// Token: 0x170038D9 RID: 14553
			// (get) Token: 0x06009ECB RID: 40651 RVA: 0x00283CE4 File Offset: 0x00281EE4
			// (set) Token: 0x06009ECC RID: 40652 RVA: 0x00283D18 File Offset: 0x00281F18
			public unsafe Il2CppStringArray blendshapeNames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfigForExport.NativeFieldInfoPtr_blendshapeNames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStringArray(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfigForExport.NativeFieldInfoPtr_blendshapeNames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038DA RID: 14554
			// (get) Token: 0x06009ECD RID: 40653 RVA: 0x00283D40 File Offset: 0x00281F40
			// (set) Token: 0x06009ECE RID: 40654 RVA: 0x00283D74 File Offset: 0x00281F74
			public unsafe Il2CppStructArray<float> blendshapeWeights
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfigForExport.NativeFieldInfoPtr_blendshapeWeights);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfigForExport.NativeFieldInfoPtr_blendshapeWeights), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040064D2 RID: 25810
			private static readonly IntPtr NativeFieldInfoPtr_skinnedMeshRendererPath;

			// Token: 0x040064D3 RID: 25811
			private static readonly IntPtr NativeFieldInfoPtr_blendShapeCount;

			// Token: 0x040064D4 RID: 25812
			private static readonly IntPtr NativeFieldInfoPtr_blendshapeNames;

			// Token: 0x040064D5 RID: 25813
			private static readonly IntPtr NativeFieldInfoPtr_blendshapeWeights;

			// Token: 0x040064D6 RID: 25814
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200077D RID: 1917
		[Serializable]
		public class BlendshapesConfig : Il2CppSystem.Object
		{
			// Token: 0x06009ECF RID: 40655 RVA: 0x00283D9C File Offset: 0x00281F9C
			[CallerCount(0)]
			public unsafe static bool CanImport(ControlData.BlendshapesConfigForExport import, Transform startXform)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(import);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startXform);
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ControlData.BlendshapesConfig.NativeMethodInfoPtr_CanImport_Public_Static_Boolean_BlendshapesConfigForExport_Transform_0, 0, (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x06009ED0 RID: 40656 RVA: 0x00283E0C File Offset: 0x0028200C
			[CallerCount(0)]
			public unsafe ControlData.BlendshapesConfigForExport GetExport(Transform startXform)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startXform);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.BlendshapesConfig.NativeMethodInfoPtr_GetExport_Public_BlendshapesConfigForExport_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new ControlData.BlendshapesConfigForExport(intPtr2) : null;
			}

			// Token: 0x06009ED1 RID: 40657 RVA: 0x00283E7C File Offset: 0x0028207C
			[CallerCount(0)]
			public unsafe void Import(Transform startXform, ControlData.BlendshapesConfigForExport import)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startXform);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(import);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.BlendshapesConfig.NativeMethodInfoPtr_Import_Public_Void_Transform_BlendshapesConfigForExport_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06009ED2 RID: 40658 RVA: 0x00283EF0 File Offset: 0x002820F0
			[CallerCount(0)]
			public unsafe BlendshapesConfig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlData.BlendshapesConfig>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlData.BlendshapesConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06009ED3 RID: 40659 RVA: 0x00283F3C File Offset: 0x0028213C
			// Note: this type is marked as 'beforefieldinit'.
			static BlendshapesConfig()
			{
				Il2CppClassPointerStore<ControlData.BlendshapesConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControlData>.NativeClassPtr, "BlendshapesConfig");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlData.BlendshapesConfig>.NativeClassPtr);
				ControlData.BlendshapesConfig.NativeFieldInfoPtr_skinnedMeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.BlendshapesConfig>.NativeClassPtr, "skinnedMeshRenderer");
				ControlData.BlendshapesConfig.NativeFieldInfoPtr_blendShapeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.BlendshapesConfig>.NativeClassPtr, "blendShapeCount");
				ControlData.BlendshapesConfig.NativeFieldInfoPtr_blendshapeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.BlendshapesConfig>.NativeClassPtr, "blendshapeNames");
				ControlData.BlendshapesConfig.NativeFieldInfoPtr_blendshapeWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlData.BlendshapesConfig>.NativeClassPtr, "blendshapeWeights");
				ControlData.BlendshapesConfig.NativeMethodInfoPtr_CanImport_Public_Static_Boolean_BlendshapesConfigForExport_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData.BlendshapesConfig>.NativeClassPtr, 100675955);
				ControlData.BlendshapesConfig.NativeMethodInfoPtr_GetExport_Public_BlendshapesConfigForExport_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData.BlendshapesConfig>.NativeClassPtr, 100675956);
				ControlData.BlendshapesConfig.NativeMethodInfoPtr_Import_Public_Void_Transform_BlendshapesConfigForExport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData.BlendshapesConfig>.NativeClassPtr, 100675957);
				ControlData.BlendshapesConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlData.BlendshapesConfig>.NativeClassPtr, 100675958);
			}

			// Token: 0x06009ED4 RID: 40660 RVA: 0x00002988 File Offset: 0x00000B88
			public BlendshapesConfig(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x170038DB RID: 14555
			// (get) Token: 0x06009ED5 RID: 40661 RVA: 0x00284007 File Offset: 0x00282207
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ControlData.BlendshapesConfig>.NativeClassPtr));
				}
			}

			// Token: 0x170038DC RID: 14556
			// (get) Token: 0x06009ED6 RID: 40662 RVA: 0x00284018 File Offset: 0x00282218
			// (set) Token: 0x06009ED7 RID: 40663 RVA: 0x0028404C File Offset: 0x0028224C
			public unsafe SkinnedMeshRenderer skinnedMeshRenderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfig.NativeFieldInfoPtr_skinnedMeshRenderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new SkinnedMeshRenderer(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfig.NativeFieldInfoPtr_skinnedMeshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038DD RID: 14557
			// (get) Token: 0x06009ED8 RID: 40664 RVA: 0x00284074 File Offset: 0x00282274
			// (set) Token: 0x06009ED9 RID: 40665 RVA: 0x0028409C File Offset: 0x0028229C
			public unsafe int blendShapeCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfig.NativeFieldInfoPtr_blendShapeCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfig.NativeFieldInfoPtr_blendShapeCount)) = value;
				}
			}

			// Token: 0x170038DE RID: 14558
			// (get) Token: 0x06009EDA RID: 40666 RVA: 0x002840C0 File Offset: 0x002822C0
			// (set) Token: 0x06009EDB RID: 40667 RVA: 0x002840F4 File Offset: 0x002822F4
			public unsafe Il2CppStringArray blendshapeNames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfig.NativeFieldInfoPtr_blendshapeNames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStringArray(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfig.NativeFieldInfoPtr_blendshapeNames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170038DF RID: 14559
			// (get) Token: 0x06009EDC RID: 40668 RVA: 0x0028411C File Offset: 0x0028231C
			// (set) Token: 0x06009EDD RID: 40669 RVA: 0x00284150 File Offset: 0x00282350
			public unsafe Il2CppStructArray<float> blendshapeWeights
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfig.NativeFieldInfoPtr_blendshapeWeights);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlData.BlendshapesConfig.NativeFieldInfoPtr_blendshapeWeights), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040064D7 RID: 25815
			private static readonly IntPtr NativeFieldInfoPtr_skinnedMeshRenderer;

			// Token: 0x040064D8 RID: 25816
			private static readonly IntPtr NativeFieldInfoPtr_blendShapeCount;

			// Token: 0x040064D9 RID: 25817
			private static readonly IntPtr NativeFieldInfoPtr_blendshapeNames;

			// Token: 0x040064DA RID: 25818
			private static readonly IntPtr NativeFieldInfoPtr_blendshapeWeights;

			// Token: 0x040064DB RID: 25819
			private static readonly IntPtr NativeMethodInfoPtr_CanImport_Public_Static_Boolean_BlendshapesConfigForExport_Transform_0;

			// Token: 0x040064DC RID: 25820
			private static readonly IntPtr NativeMethodInfoPtr_GetExport_Public_BlendshapesConfigForExport_Transform_0;

			// Token: 0x040064DD RID: 25821
			private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Void_Transform_BlendshapesConfigForExport_0;

			// Token: 0x040064DE RID: 25822
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
