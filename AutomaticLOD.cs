using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UltimateGameTools.MeshSimplifier;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200059B RID: 1435
public class AutomaticLOD : MonoBehaviour
{
	// Token: 0x17002A0C RID: 10764
	// (get) Token: 0x060074ED RID: 29933 RVA: 0x001D6860 File Offset: 0x001D4A60
	// (set) Token: 0x060074EE RID: 29934 RVA: 0x001D68A8 File Offset: 0x001D4AA8
	public unsafe static Camera UserDefinedLODCamera
	{
		[CallerCount(0)]
		get
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_get_UserDefinedLODCamera_Public_Static_get_Camera_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Camera(intPtr2) : null;
		}
		[CallerCount(0)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_set_UserDefinedLODCamera_Public_Static_set_Void_Camera_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x17002A0D RID: 10765
	// (get) Token: 0x060074EF RID: 29935 RVA: 0x001D68F4 File Offset: 0x001D4AF4
	public unsafe AutomaticLOD.SwitchMode LODSwitchMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_get_LODSwitchMode_Public_get_SwitchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x060074F0 RID: 29936 RVA: 0x001D6944 File Offset: 0x001D4B44
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060074F1 RID: 29937 RVA: 0x001D6988 File Offset: 0x001D4B88
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060074F2 RID: 29938 RVA: 0x001D69CC File Offset: 0x001D4BCC
	[CallerCount(0)]
	public unsafe void OnWillRenderObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060074F3 RID: 29939 RVA: 0x001D6A10 File Offset: 0x001D4C10
	[CallerCount(0)]
	public unsafe static bool HasValidMeshData(GameObject go)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_HasValidMeshData_Public_Static_Boolean_GameObject_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060074F4 RID: 29940 RVA: 0x001D6A68 File Offset: 0x001D4C68
	[CallerCount(0)]
	public unsafe static bool IsRootOrBelongsToLODTree(AutomaticLOD automaticLOD, AutomaticLOD root)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(automaticLOD);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_IsRootOrBelongsToLODTree_Public_Static_Boolean_AutomaticLOD_AutomaticLOD_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060074F5 RID: 29941 RVA: 0x001D6AD8 File Offset: 0x001D4CD8
	[CallerCount(0)]
	public unsafe int GetNumberOfLevelsToGenerate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetNumberOfLevelsToGenerate_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060074F6 RID: 29942 RVA: 0x001D6B28 File Offset: 0x001D4D28
	[CallerCount(0)]
	public unsafe bool IsGenerateIncludeChildrenActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_IsGenerateIncludeChildrenActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060074F7 RID: 29943 RVA: 0x001D6B78 File Offset: 0x001D4D78
	[CallerCount(0)]
	public unsafe bool IsRootAutomaticLOD()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_IsRootAutomaticLOD_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060074F8 RID: 29944 RVA: 0x001D6BC8 File Offset: 0x001D4DC8
	[CallerCount(0)]
	public unsafe bool HasDependentChildren()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_HasDependentChildren_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060074F9 RID: 29945 RVA: 0x001D6C18 File Offset: 0x001D4E18
	[CallerCount(0)]
	public unsafe bool HasLODDataDirty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_HasLODDataDirty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060074FA RID: 29946 RVA: 0x001D6C68 File Offset: 0x001D4E68
	[CallerCount(0)]
	public unsafe bool SetLODDataDirty(bool bDirty)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref bDirty;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_SetLODDataDirty_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060074FB RID: 29947 RVA: 0x001D6CCC File Offset: 0x001D4ECC
	[CallerCount(0)]
	public unsafe int GetLODLevelCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetLODLevelCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060074FC RID: 29948 RVA: 0x001D6D1C File Offset: 0x001D4F1C
	[CallerCount(0)]
	public unsafe float ComputeScreenCoverage(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_ComputeScreenCoverage_Public_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060074FD RID: 29949 RVA: 0x001D6D84 File Offset: 0x001D4F84
	[CallerCount(0)]
	public unsafe Vector3 ComputeWorldCenter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_ComputeWorldCenter_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060074FE RID: 29950 RVA: 0x001D6DD4 File Offset: 0x001D4FD4
	[CallerCount(0)]
	public unsafe float ComputeViewSpaceBounds(Vector3 v3CameraPos, Vector3 v3CameraDir, Vector3 v3CameraUp, out Vector3 v3Min, out Vector3 v3Max, out Vector3 v3Center)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref v3CameraPos;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v3CameraDir;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v3CameraUp;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &v3Min;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &v3Max;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &v3Center;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_ComputeViewSpaceBounds_Public_Single_Vector3_Vector3_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x060074FF RID: 29951 RVA: 0x001D6E98 File Offset: 0x001D5098
	[CallerCount(0)]
	public unsafe void SetAutomaticCameraLODSwitch(bool bEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref bEnabled;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_SetAutomaticCameraLODSwitch_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007500 RID: 29952 RVA: 0x001D6EEC File Offset: 0x001D50EC
	[CallerCount(0)]
	public unsafe static void SetAutomaticCameraLODSwitchRecursive(AutomaticLOD root, GameObject gameObject, bool bEnabled)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnabled;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_SetAutomaticCameraLODSwitchRecursive_Private_Static_Void_AutomaticLOD_GameObject_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007501 RID: 29953 RVA: 0x001D6F64 File Offset: 0x001D5164
	[CallerCount(0)]
	public unsafe void SetLODLevels(List<AutomaticLOD.LODLevelData> listLODLevelData, AutomaticLOD.EvalMode evalMode, float fMaxCameraDistance, bool bRecurseIntoChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(listLODLevelData);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evalMode;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fMaxCameraDistance;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_SetLODLevels_Public_Void_List_1_LODLevelData_EvalMode_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007502 RID: 29954 RVA: 0x001D6FF8 File Offset: 0x001D51F8
	[CallerCount(0)]
	public unsafe static void SetLODLevelsRecursive(AutomaticLOD root, GameObject gameObject)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_SetLODLevelsRecursive_Private_Static_Void_AutomaticLOD_GameObject_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007503 RID: 29955 RVA: 0x001D705C File Offset: 0x001D525C
	[CallerCount(0)]
	public unsafe void AddLODLevel(int nLevel, bool bBefore, bool bCreateMesh, bool bRecurseIntoChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref nLevel;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bBefore;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreateMesh;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_AddLODLevel_Public_Void_Int32_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007504 RID: 29956 RVA: 0x001D70EC File Offset: 0x001D52EC
	[CallerCount(0)]
	public unsafe static void AddLODLevelRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bBefore, bool bCreateMesh, bool bRecurseIntoChildren)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLevel;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bBefore;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreateMesh;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_AddLODLevelRecursive_Public_Static_Void_AutomaticLOD_GameObject_Int32_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007505 RID: 29957 RVA: 0x001D719C File Offset: 0x001D539C
	[CallerCount(0)]
	public unsafe void RemoveLODLevel(int nLevel, bool bDeleteMesh, bool bRecurseIntoChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref nLevel;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bDeleteMesh;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_RemoveLODLevel_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007506 RID: 29958 RVA: 0x001D7218 File Offset: 0x001D5418
	[CallerCount(0)]
	public unsafe static void RemoveLODLevelRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bDeleteMesh, bool bRecurseIntoChildren)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLevel;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bDeleteMesh;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_RemoveLODLevelRecursive_Public_Static_Void_AutomaticLOD_GameObject_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007507 RID: 29959 RVA: 0x001D72B4 File Offset: 0x001D54B4
	[CallerCount(0)]
	public unsafe Simplifier GetMeshSimplifier()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetMeshSimplifier_Public_Simplifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new Simplifier(intPtr2) : null;
	}

	// Token: 0x06007508 RID: 29960 RVA: 0x001D730C File Offset: 0x001D550C
	[CallerCount(0)]
	public unsafe void ComputeLODData(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref bRecurseIntoChildren;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(progress);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_ComputeLODData_Public_Void_Boolean_ProgressDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007509 RID: 29961 RVA: 0x001D7378 File Offset: 0x001D5578
	[CallerCount(0)]
	public unsafe void ComputeLODDataRecursive(AutomaticLOD root, GameObject gameObject, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(progress);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_ComputeLODDataRecursive_Private_Void_AutomaticLOD_GameObject_Boolean_ProgressDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600750A RID: 29962 RVA: 0x001D7414 File Offset: 0x001D5614
	[CallerCount(0)]
	public unsafe bool HasLODData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_HasLODData_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x0600750B RID: 29963 RVA: 0x001D7464 File Offset: 0x001D5664
	[CallerCount(0)]
	public unsafe int GetLODLevelUsingCamera(Camera currentCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentCamera);
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetLODLevelUsingCamera_Public_Int32_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x0600750C RID: 29964 RVA: 0x001D74CC File Offset: 0x001D56CC
	[CallerCount(0)]
	public unsafe int GetCurrentLODLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetCurrentLODLevel_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x0600750D RID: 29965 RVA: 0x001D751C File Offset: 0x001D571C
	[CallerCount(0)]
	public unsafe void SwitchToLOD(int nLevel, bool bRecurseIntoChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref nLevel;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_SwitchToLOD_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600750E RID: 29966 RVA: 0x001D7584 File Offset: 0x001D5784
	[CallerCount(0)]
	public unsafe static void SwitchToLODRecursive(AutomaticLOD root, GameObject gameObject, int nLODLevel, bool bRecurseIntoChildren)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLODLevel;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_SwitchToLODRecursive_Private_Static_Void_AutomaticLOD_GameObject_Int32_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600750F RID: 29967 RVA: 0x001D760C File Offset: 0x001D580C
	[CallerCount(0)]
	public unsafe void ComputeAllLODMeshes(bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref bRecurseIntoChildren;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(progress);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_ComputeAllLODMeshes_Public_Void_Boolean_ProgressDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007510 RID: 29968 RVA: 0x001D7678 File Offset: 0x001D5878
	[CallerCount(0)]
	public unsafe void ComputeLODMesh(int nLevel, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref nLevel;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(progress);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_ComputeLODMesh_Public_Void_Int32_Boolean_ProgressDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007511 RID: 29969 RVA: 0x001D76F8 File Offset: 0x001D58F8
	[CallerCount(0)]
	public unsafe static void ComputeLODMeshRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bRecurseIntoChildren, [Optional] Simplifier.ProgressDelegate progress)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLevel;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(progress);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_ComputeLODMeshRecursive_Private_Static_Void_AutomaticLOD_GameObject_Int32_Boolean_ProgressDelegate_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007512 RID: 29970 RVA: 0x001D7798 File Offset: 0x001D5998
	[CallerCount(0)]
	public unsafe void RestoreOriginalMesh(bool bDeleteLODData, bool bRecurseIntoChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref bDeleteLODData;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_RestoreOriginalMesh_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007513 RID: 29971 RVA: 0x001D7800 File Offset: 0x001D5A00
	[CallerCount(0)]
	public unsafe static void RestoreOriginalMeshRecursive(AutomaticLOD root, GameObject gameObject, bool bDeleteLODData, bool bRecurseIntoChildren)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bDeleteLODData;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_RestoreOriginalMeshRecursive_Private_Static_Void_AutomaticLOD_GameObject_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007514 RID: 29972 RVA: 0x001D7888 File Offset: 0x001D5A88
	[CallerCount(0)]
	public unsafe bool HasOriginalMeshActive(bool bRecurseIntoChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_HasOriginalMeshActive_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06007515 RID: 29973 RVA: 0x001D78EC File Offset: 0x001D5AEC
	[CallerCount(0)]
	public unsafe static bool HasOriginalMeshActiveRecursive(AutomaticLOD root, GameObject gameObject, bool bRecurseIntoChildren)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_HasOriginalMeshActiveRecursive_Private_Static_Boolean_AutomaticLOD_GameObject_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06007516 RID: 29974 RVA: 0x001D7970 File Offset: 0x001D5B70
	[CallerCount(0)]
	public unsafe bool HasVertexData(int nLevel, bool bRecurseIntoChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref nLevel;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_HasVertexData_Public_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06007517 RID: 29975 RVA: 0x001D79E8 File Offset: 0x001D5BE8
	[CallerCount(0)]
	public unsafe static bool HasVertexDataRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, bool bRecurseIntoChildren)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLevel;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_HasVertexDataRecursive_Private_Static_Boolean_AutomaticLOD_GameObject_Int32_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06007518 RID: 29976 RVA: 0x001D7A80 File Offset: 0x001D5C80
	[CallerCount(0)]
	public unsafe int GetOriginalVertexCount(bool bRecurseIntoChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetOriginalVertexCount_Public_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06007519 RID: 29977 RVA: 0x001D7AE4 File Offset: 0x001D5CE4
	[CallerCount(0)]
	public unsafe static void GetOriginalVertexCountRecursive(AutomaticLOD root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nVertexCount;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetOriginalVertexCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_byref_Int32_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600751A RID: 29978 RVA: 0x001D7B70 File Offset: 0x001D5D70
	[CallerCount(0)]
	public unsafe int GetOriginalTriangleCount(bool bRecurseIntoChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetOriginalTriangleCount_Public_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x0600751B RID: 29979 RVA: 0x001D7BD4 File Offset: 0x001D5DD4
	[CallerCount(0)]
	public unsafe static void GetOriginalTriangleCountRecursive(AutomaticLOD root, GameObject gameObject, ref int nTriangleCount, bool bRecurseIntoChildren)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nTriangleCount;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetOriginalTriangleCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_byref_Int32_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600751C RID: 29980 RVA: 0x001D7C60 File Offset: 0x001D5E60
	[CallerCount(0)]
	public unsafe int GetCurrentVertexCount(bool bRecurseIntoChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetCurrentVertexCount_Public_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x0600751D RID: 29981 RVA: 0x001D7CC4 File Offset: 0x001D5EC4
	[CallerCount(0)]
	public unsafe static void GetCurrentVertexCountRecursive(AutomaticLOD root, GameObject gameObject, ref int nVertexCount, bool bRecurseIntoChildren)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nVertexCount;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetCurrentVertexCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_byref_Int32_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600751E RID: 29982 RVA: 0x001D7D50 File Offset: 0x001D5F50
	[CallerCount(0)]
	public unsafe int GetLODVertexCount(int nLevel, bool bRecurseIntoChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref nLevel;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetLODVertexCount_Public_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x0600751F RID: 29983 RVA: 0x001D7DC8 File Offset: 0x001D5FC8
	[CallerCount(0)]
	public unsafe static void GetLODVertexCountRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, ref int nVertexCount, bool bRecurseIntoChildren)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLevel;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nVertexCount;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetLODVertexCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_Int32_byref_Int32_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007520 RID: 29984 RVA: 0x001D7E64 File Offset: 0x001D6064
	[CallerCount(0)]
	public unsafe int GetLODTriangleCount(int nLevel, bool bRecurseIntoChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref nLevel;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetLODTriangleCount_Public_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06007521 RID: 29985 RVA: 0x001D7EDC File Offset: 0x001D60DC
	[CallerCount(0)]
	public unsafe static void GetLODTriangleCountRecursive(AutomaticLOD root, GameObject gameObject, int nLevel, ref int nTriangleCount, bool bRecurseIntoChildren)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nLevel;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nTriangleCount;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_GetLODTriangleCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_Int32_byref_Int32_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007522 RID: 29986 RVA: 0x001D7F78 File Offset: 0x001D6178
	[CallerCount(0)]
	public unsafe void RemoveFromLODTree()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_RemoveFromLODTree_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007523 RID: 29987 RVA: 0x001D7FBC File Offset: 0x001D61BC
	[CallerCount(0)]
	public unsafe void FreeLODData(bool bRecurseIntoChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_FreeLODData_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007524 RID: 29988 RVA: 0x001D8010 File Offset: 0x001D6210
	[CallerCount(0)]
	public unsafe static void FreeLODDataRecursive(AutomaticLOD root, GameObject gameObject, bool bRecurseIntoChildren)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRecurseIntoChildren;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_FreeLODDataRecursive_Private_Static_Void_AutomaticLOD_GameObject_Boolean_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007525 RID: 29989 RVA: 0x001D8088 File Offset: 0x001D6288
	[CallerCount(0)]
	public unsafe static Mesh CreateNewEmptyMesh(AutomaticLOD automaticLOD)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(automaticLOD);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_CreateNewEmptyMesh_Private_Static_Mesh_AutomaticLOD_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
	}

	// Token: 0x06007526 RID: 29990 RVA: 0x001D80E8 File Offset: 0x001D62E8
	[CallerCount(0)]
	public unsafe static GameObject CreateBasicObjectCopy(GameObject gameObject, Mesh mesh, Transform parent)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_CreateBasicObjectCopy_Private_Static_GameObject_GameObject_Mesh_Transform_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
	}

	// Token: 0x06007527 RID: 29991 RVA: 0x001D8178 File Offset: 0x001D6378
	[CallerCount(0)]
	public unsafe static void CheckForAdditionalLODSetup(AutomaticLOD root, AutomaticLOD automaticLOD, AutomaticLOD.LODLevelData levelData, int level)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(automaticLOD);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(levelData);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_CheckForAdditionalLODSetup_Private_Static_Void_AutomaticLOD_AutomaticLOD_LODLevelData_Int32_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007528 RID: 29992 RVA: 0x001D8208 File Offset: 0x001D6408
	[CallerCount(0)]
	public unsafe void SetupLODGroup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_SetupLODGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06007529 RID: 29993 RVA: 0x001D824C File Offset: 0x001D644C
	[CallerCount(0)]
	public unsafe static void SetupLODGroupRecursive(AutomaticLOD root, GameObject gameObject, ref List<List<Renderer>> renderers)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(renderers);
		ptr2 = &intPtr;
		IntPtr returnedException;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_SetupLODGroupRecursive_Private_Static_Void_AutomaticLOD_GameObject_byref_List_1_List_1_Renderer_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr3 = intPtr;
		renderers = ((intPtr3 == 0) ? null : new List(intPtr3));
	}

	// Token: 0x0600752A RID: 29994 RVA: 0x001D82E8 File Offset: 0x001D64E8
	[CallerCount(0)]
	public unsafe static Component CopyComponent(Component original, GameObject destination)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_CopyComponent_Private_Static_Component_Component_GameObject_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new Component(intPtr2) : null;
	}

	// Token: 0x0600752B RID: 29995 RVA: 0x001D8360 File Offset: 0x001D6560
	[CallerCount(0)]
	public unsafe void BuildCornerData(ref Il2CppStructArray<Vector3> av3Corners, Bounds bounds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(av3Corners);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_BuildCornerData_Private_Void_byref_ArrayOf_Vector3_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600752C RID: 29996 RVA: 0x001D83D0 File Offset: 0x001D65D0
	[CallerCount(0)]
	public unsafe bool IsDependent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr_IsDependent_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x0600752D RID: 29997 RVA: 0x001D8420 File Offset: 0x001D6620
	[CallerCount(0)]
	public unsafe AutomaticLOD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600752E RID: 29998 RVA: 0x001D846C File Offset: 0x001D666C
	// Note: this type is marked as 'beforefieldinit'.
	static AutomaticLOD()
	{
		Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AutomaticLOD");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr);
		AutomaticLOD.NativeFieldInfoPtr_m_originalMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_originalMesh");
		AutomaticLOD.NativeFieldInfoPtr_m_evalMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_evalMode");
		AutomaticLOD.NativeFieldInfoPtr_m_bEnablePrefabUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_bEnablePrefabUsage");
		AutomaticLOD.NativeFieldInfoPtr_m_strAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_strAssetPath");
		AutomaticLOD.NativeFieldInfoPtr_m_fMaxCameraDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_fMaxCameraDistance");
		AutomaticLOD.NativeFieldInfoPtr_m_nColorEditorBarNewIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_nColorEditorBarNewIndex");
		AutomaticLOD.NativeFieldInfoPtr_m_listLODLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_listLODLevels");
		AutomaticLOD.NativeFieldInfoPtr_m_LODObjectRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_LODObjectRoot");
		AutomaticLOD.NativeFieldInfoPtr_m_listDependentChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_listDependentChildren");
		AutomaticLOD.NativeFieldInfoPtr_m_bExpandRelevanceSpheres = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_bExpandRelevanceSpheres");
		AutomaticLOD.NativeFieldInfoPtr_m_aRelevanceSpheres = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_aRelevanceSpheres");
		AutomaticLOD.NativeFieldInfoPtr_m_meshSimplifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_meshSimplifier");
		AutomaticLOD.NativeFieldInfoPtr_m_bGenerateIncludeChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_bGenerateIncludeChildren");
		AutomaticLOD.NativeFieldInfoPtr_m_levelsToGenerate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_levelsToGenerate");
		AutomaticLOD.NativeFieldInfoPtr_m_switchMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_switchMode");
		AutomaticLOD.NativeFieldInfoPtr_m_bOverrideRootSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_bOverrideRootSettings");
		AutomaticLOD.NativeFieldInfoPtr_m_bLODDataDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_bLODDataDirty");
		AutomaticLOD.NativeFieldInfoPtr_m_LODObjectRootPersist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_LODObjectRootPersist");
		AutomaticLOD.NativeFieldInfoPtr_m_LODGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_LODGroup");
		AutomaticLOD.NativeFieldInfoPtr_m_bUseAutomaticCameraLODSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_bUseAutomaticCameraLODSwitch");
		AutomaticLOD.NativeFieldInfoPtr_k_MaxLODChecksPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "k_MaxLODChecksPerFrame");
		AutomaticLOD.NativeFieldInfoPtr_k_MaxFrameCheckLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "k_MaxFrameCheckLoop");
		AutomaticLOD.NativeFieldInfoPtr_s_currentCheckIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "s_currentCheckIndex");
		AutomaticLOD.NativeFieldInfoPtr_s_currentFrameCheckIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "s_currentFrameCheckIndex");
		AutomaticLOD.NativeFieldInfoPtr_s_checkLoopLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "s_checkLoopLength");
		AutomaticLOD.NativeFieldInfoPtr_s_lastFrameComputedModulus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "s_lastFrameComputedModulus");
		AutomaticLOD.NativeFieldInfoPtr_s_currentFrameInLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "s_currentFrameInLoop");
		AutomaticLOD.NativeFieldInfoPtr_s_userDefinedCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "s_userDefinedCamera");
		AutomaticLOD.NativeFieldInfoPtr_m_renderCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_renderCamera");
		AutomaticLOD.NativeFieldInfoPtr_m_nCurrentLOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_nCurrentLOD");
		AutomaticLOD.NativeFieldInfoPtr_m_cachedFrameLODLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_cachedFrameLODLevel");
		AutomaticLOD.NativeFieldInfoPtr_m_localCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_localCenter");
		AutomaticLOD.NativeFieldInfoPtr__corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "_corners");
		AutomaticLOD.NativeFieldInfoPtr_m_frameToCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "m_frameToCheck");
		AutomaticLOD.NativeFieldInfoPtr_b_performCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "b_performCheck");
		AutomaticLOD.NativeMethodInfoPtr_get_UserDefinedLODCamera_Public_Static_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672595);
		AutomaticLOD.NativeMethodInfoPtr_set_UserDefinedLODCamera_Public_Static_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672596);
		AutomaticLOD.NativeMethodInfoPtr_get_LODSwitchMode_Public_get_SwitchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672597);
		AutomaticLOD.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672598);
		AutomaticLOD.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672599);
		AutomaticLOD.NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672600);
		AutomaticLOD.NativeMethodInfoPtr_HasValidMeshData_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672601);
		AutomaticLOD.NativeMethodInfoPtr_IsRootOrBelongsToLODTree_Public_Static_Boolean_AutomaticLOD_AutomaticLOD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672602);
		AutomaticLOD.NativeMethodInfoPtr_GetNumberOfLevelsToGenerate_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672603);
		AutomaticLOD.NativeMethodInfoPtr_IsGenerateIncludeChildrenActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672604);
		AutomaticLOD.NativeMethodInfoPtr_IsRootAutomaticLOD_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672605);
		AutomaticLOD.NativeMethodInfoPtr_HasDependentChildren_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672606);
		AutomaticLOD.NativeMethodInfoPtr_HasLODDataDirty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672607);
		AutomaticLOD.NativeMethodInfoPtr_SetLODDataDirty_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672608);
		AutomaticLOD.NativeMethodInfoPtr_GetLODLevelCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672609);
		AutomaticLOD.NativeMethodInfoPtr_ComputeScreenCoverage_Public_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672610);
		AutomaticLOD.NativeMethodInfoPtr_ComputeWorldCenter_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672611);
		AutomaticLOD.NativeMethodInfoPtr_ComputeViewSpaceBounds_Public_Single_Vector3_Vector3_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672612);
		AutomaticLOD.NativeMethodInfoPtr_SetAutomaticCameraLODSwitch_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672613);
		AutomaticLOD.NativeMethodInfoPtr_SetAutomaticCameraLODSwitchRecursive_Private_Static_Void_AutomaticLOD_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672614);
		AutomaticLOD.NativeMethodInfoPtr_SetLODLevels_Public_Void_List_1_LODLevelData_EvalMode_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672615);
		AutomaticLOD.NativeMethodInfoPtr_SetLODLevelsRecursive_Private_Static_Void_AutomaticLOD_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672616);
		AutomaticLOD.NativeMethodInfoPtr_AddLODLevel_Public_Void_Int32_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672617);
		AutomaticLOD.NativeMethodInfoPtr_AddLODLevelRecursive_Public_Static_Void_AutomaticLOD_GameObject_Int32_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672618);
		AutomaticLOD.NativeMethodInfoPtr_RemoveLODLevel_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672619);
		AutomaticLOD.NativeMethodInfoPtr_RemoveLODLevelRecursive_Public_Static_Void_AutomaticLOD_GameObject_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672620);
		AutomaticLOD.NativeMethodInfoPtr_GetMeshSimplifier_Public_Simplifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672621);
		AutomaticLOD.NativeMethodInfoPtr_ComputeLODData_Public_Void_Boolean_ProgressDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672622);
		AutomaticLOD.NativeMethodInfoPtr_ComputeLODDataRecursive_Private_Void_AutomaticLOD_GameObject_Boolean_ProgressDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672623);
		AutomaticLOD.NativeMethodInfoPtr_HasLODData_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672624);
		AutomaticLOD.NativeMethodInfoPtr_GetLODLevelUsingCamera_Public_Int32_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672625);
		AutomaticLOD.NativeMethodInfoPtr_GetCurrentLODLevel_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672626);
		AutomaticLOD.NativeMethodInfoPtr_SwitchToLOD_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672627);
		AutomaticLOD.NativeMethodInfoPtr_SwitchToLODRecursive_Private_Static_Void_AutomaticLOD_GameObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672628);
		AutomaticLOD.NativeMethodInfoPtr_ComputeAllLODMeshes_Public_Void_Boolean_ProgressDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672629);
		AutomaticLOD.NativeMethodInfoPtr_ComputeLODMesh_Public_Void_Int32_Boolean_ProgressDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672630);
		AutomaticLOD.NativeMethodInfoPtr_ComputeLODMeshRecursive_Private_Static_Void_AutomaticLOD_GameObject_Int32_Boolean_ProgressDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672631);
		AutomaticLOD.NativeMethodInfoPtr_RestoreOriginalMesh_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672632);
		AutomaticLOD.NativeMethodInfoPtr_RestoreOriginalMeshRecursive_Private_Static_Void_AutomaticLOD_GameObject_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672633);
		AutomaticLOD.NativeMethodInfoPtr_HasOriginalMeshActive_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672634);
		AutomaticLOD.NativeMethodInfoPtr_HasOriginalMeshActiveRecursive_Private_Static_Boolean_AutomaticLOD_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672635);
		AutomaticLOD.NativeMethodInfoPtr_HasVertexData_Public_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672636);
		AutomaticLOD.NativeMethodInfoPtr_HasVertexDataRecursive_Private_Static_Boolean_AutomaticLOD_GameObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672637);
		AutomaticLOD.NativeMethodInfoPtr_GetOriginalVertexCount_Public_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672638);
		AutomaticLOD.NativeMethodInfoPtr_GetOriginalVertexCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672639);
		AutomaticLOD.NativeMethodInfoPtr_GetOriginalTriangleCount_Public_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672640);
		AutomaticLOD.NativeMethodInfoPtr_GetOriginalTriangleCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672641);
		AutomaticLOD.NativeMethodInfoPtr_GetCurrentVertexCount_Public_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672642);
		AutomaticLOD.NativeMethodInfoPtr_GetCurrentVertexCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672643);
		AutomaticLOD.NativeMethodInfoPtr_GetLODVertexCount_Public_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672644);
		AutomaticLOD.NativeMethodInfoPtr_GetLODVertexCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672645);
		AutomaticLOD.NativeMethodInfoPtr_GetLODTriangleCount_Public_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672646);
		AutomaticLOD.NativeMethodInfoPtr_GetLODTriangleCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_Int32_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672647);
		AutomaticLOD.NativeMethodInfoPtr_RemoveFromLODTree_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672648);
		AutomaticLOD.NativeMethodInfoPtr_FreeLODData_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672649);
		AutomaticLOD.NativeMethodInfoPtr_FreeLODDataRecursive_Private_Static_Void_AutomaticLOD_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672650);
		AutomaticLOD.NativeMethodInfoPtr_CreateNewEmptyMesh_Private_Static_Mesh_AutomaticLOD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672651);
		AutomaticLOD.NativeMethodInfoPtr_CreateBasicObjectCopy_Private_Static_GameObject_GameObject_Mesh_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672652);
		AutomaticLOD.NativeMethodInfoPtr_CheckForAdditionalLODSetup_Private_Static_Void_AutomaticLOD_AutomaticLOD_LODLevelData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672653);
		AutomaticLOD.NativeMethodInfoPtr_SetupLODGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672654);
		AutomaticLOD.NativeMethodInfoPtr_SetupLODGroupRecursive_Private_Static_Void_AutomaticLOD_GameObject_byref_List_1_List_1_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672655);
		AutomaticLOD.NativeMethodInfoPtr_CopyComponent_Private_Static_Component_Component_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672656);
		AutomaticLOD.NativeMethodInfoPtr_BuildCornerData_Private_Void_byref_ArrayOf_Vector3_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672657);
		AutomaticLOD.NativeMethodInfoPtr_IsDependent_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672658);
		AutomaticLOD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, 100672659);
	}

	// Token: 0x0600752F RID: 29999 RVA: 0x0000210C File Offset: 0x0000030C
	public AutomaticLOD(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170029E8 RID: 10728
	// (get) Token: 0x06007530 RID: 30000 RVA: 0x001D8C6C File Offset: 0x001D6E6C
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr));
		}
	}

	// Token: 0x170029E9 RID: 10729
	// (get) Token: 0x06007531 RID: 30001 RVA: 0x001D8C80 File Offset: 0x001D6E80
	// (set) Token: 0x06007532 RID: 30002 RVA: 0x001D8CB4 File Offset: 0x001D6EB4
	public unsafe Mesh m_originalMesh
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_originalMesh);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_originalMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170029EA RID: 10730
	// (get) Token: 0x06007533 RID: 30003 RVA: 0x001D8CDC File Offset: 0x001D6EDC
	// (set) Token: 0x06007534 RID: 30004 RVA: 0x001D8D04 File Offset: 0x001D6F04
	public unsafe AutomaticLOD.EvalMode m_evalMode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_evalMode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_evalMode)) = value;
		}
	}

	// Token: 0x170029EB RID: 10731
	// (get) Token: 0x06007535 RID: 30005 RVA: 0x001D8D28 File Offset: 0x001D6F28
	// (set) Token: 0x06007536 RID: 30006 RVA: 0x001D8D50 File Offset: 0x001D6F50
	public unsafe bool m_bEnablePrefabUsage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_bEnablePrefabUsage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_bEnablePrefabUsage)) = value;
		}
	}

	// Token: 0x170029EC RID: 10732
	// (get) Token: 0x06007537 RID: 30007 RVA: 0x001D8D74 File Offset: 0x001D6F74
	// (set) Token: 0x06007538 RID: 30008 RVA: 0x001D8D9D File Offset: 0x001D6F9D
	public unsafe string m_strAssetPath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_strAssetPath);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_strAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170029ED RID: 10733
	// (get) Token: 0x06007539 RID: 30009 RVA: 0x001D8DC4 File Offset: 0x001D6FC4
	// (set) Token: 0x0600753A RID: 30010 RVA: 0x001D8DEC File Offset: 0x001D6FEC
	public unsafe float m_fMaxCameraDistance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_fMaxCameraDistance);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_fMaxCameraDistance)) = value;
		}
	}

	// Token: 0x170029EE RID: 10734
	// (get) Token: 0x0600753B RID: 30011 RVA: 0x001D8E10 File Offset: 0x001D7010
	// (set) Token: 0x0600753C RID: 30012 RVA: 0x001D8E38 File Offset: 0x001D7038
	public unsafe int m_nColorEditorBarNewIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_nColorEditorBarNewIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_nColorEditorBarNewIndex)) = value;
		}
	}

	// Token: 0x170029EF RID: 10735
	// (get) Token: 0x0600753D RID: 30013 RVA: 0x001D8E5C File Offset: 0x001D705C
	// (set) Token: 0x0600753E RID: 30014 RVA: 0x001D8E90 File Offset: 0x001D7090
	public unsafe List<AutomaticLOD.LODLevelData> m_listLODLevels
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_listLODLevels);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<AutomaticLOD.LODLevelData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_listLODLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170029F0 RID: 10736
	// (get) Token: 0x0600753F RID: 30015 RVA: 0x001D8EB8 File Offset: 0x001D70B8
	// (set) Token: 0x06007540 RID: 30016 RVA: 0x001D8EEC File Offset: 0x001D70EC
	public unsafe AutomaticLOD m_LODObjectRoot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_LODObjectRoot);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AutomaticLOD(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_LODObjectRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170029F1 RID: 10737
	// (get) Token: 0x06007541 RID: 30017 RVA: 0x001D8F14 File Offset: 0x001D7114
	// (set) Token: 0x06007542 RID: 30018 RVA: 0x001D8F48 File Offset: 0x001D7148
	public unsafe List<AutomaticLOD> m_listDependentChildren
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_listDependentChildren);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<AutomaticLOD>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_listDependentChildren), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170029F2 RID: 10738
	// (get) Token: 0x06007543 RID: 30019 RVA: 0x001D8F70 File Offset: 0x001D7170
	// (set) Token: 0x06007544 RID: 30020 RVA: 0x001D8F98 File Offset: 0x001D7198
	public unsafe bool m_bExpandRelevanceSpheres
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_bExpandRelevanceSpheres);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_bExpandRelevanceSpheres)) = value;
		}
	}

	// Token: 0x170029F3 RID: 10739
	// (get) Token: 0x06007545 RID: 30021 RVA: 0x001D8FBC File Offset: 0x001D71BC
	// (set) Token: 0x06007546 RID: 30022 RVA: 0x001D8FF0 File Offset: 0x001D71F0
	public unsafe Il2CppReferenceArray<RelevanceSphere> m_aRelevanceSpheres
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_aRelevanceSpheres);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<RelevanceSphere>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_aRelevanceSpheres), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170029F4 RID: 10740
	// (get) Token: 0x06007547 RID: 30023 RVA: 0x001D9018 File Offset: 0x001D7218
	// (set) Token: 0x06007548 RID: 30024 RVA: 0x001D904C File Offset: 0x001D724C
	public unsafe Simplifier m_meshSimplifier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_meshSimplifier);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Simplifier(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_meshSimplifier), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170029F5 RID: 10741
	// (get) Token: 0x06007549 RID: 30025 RVA: 0x001D9074 File Offset: 0x001D7274
	// (set) Token: 0x0600754A RID: 30026 RVA: 0x001D909C File Offset: 0x001D729C
	public unsafe bool m_bGenerateIncludeChildren
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_bGenerateIncludeChildren);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_bGenerateIncludeChildren)) = value;
		}
	}

	// Token: 0x170029F6 RID: 10742
	// (get) Token: 0x0600754B RID: 30027 RVA: 0x001D90C0 File Offset: 0x001D72C0
	// (set) Token: 0x0600754C RID: 30028 RVA: 0x001D90E8 File Offset: 0x001D72E8
	public unsafe AutomaticLOD.LevelsToGenerate m_levelsToGenerate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_levelsToGenerate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_levelsToGenerate)) = value;
		}
	}

	// Token: 0x170029F7 RID: 10743
	// (get) Token: 0x0600754D RID: 30029 RVA: 0x001D910C File Offset: 0x001D730C
	// (set) Token: 0x0600754E RID: 30030 RVA: 0x001D9134 File Offset: 0x001D7334
	public unsafe AutomaticLOD.SwitchMode m_switchMode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_switchMode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_switchMode)) = value;
		}
	}

	// Token: 0x170029F8 RID: 10744
	// (get) Token: 0x0600754F RID: 30031 RVA: 0x001D9158 File Offset: 0x001D7358
	// (set) Token: 0x06007550 RID: 30032 RVA: 0x001D9180 File Offset: 0x001D7380
	public unsafe bool m_bOverrideRootSettings
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_bOverrideRootSettings);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_bOverrideRootSettings)) = value;
		}
	}

	// Token: 0x170029F9 RID: 10745
	// (get) Token: 0x06007551 RID: 30033 RVA: 0x001D91A4 File Offset: 0x001D73A4
	// (set) Token: 0x06007552 RID: 30034 RVA: 0x001D91CC File Offset: 0x001D73CC
	public unsafe bool m_bLODDataDirty
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_bLODDataDirty);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_bLODDataDirty)) = value;
		}
	}

	// Token: 0x170029FA RID: 10746
	// (get) Token: 0x06007553 RID: 30035 RVA: 0x001D91F0 File Offset: 0x001D73F0
	// (set) Token: 0x06007554 RID: 30036 RVA: 0x001D9224 File Offset: 0x001D7424
	public unsafe AutomaticLOD m_LODObjectRootPersist
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_LODObjectRootPersist);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AutomaticLOD(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_LODObjectRootPersist), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170029FB RID: 10747
	// (get) Token: 0x06007555 RID: 30037 RVA: 0x001D924C File Offset: 0x001D744C
	// (set) Token: 0x06007556 RID: 30038 RVA: 0x001D9280 File Offset: 0x001D7480
	public unsafe LODGroup m_LODGroup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_LODGroup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new LODGroup(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_LODGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170029FC RID: 10748
	// (get) Token: 0x06007557 RID: 30039 RVA: 0x001D92A8 File Offset: 0x001D74A8
	// (set) Token: 0x06007558 RID: 30040 RVA: 0x001D92D0 File Offset: 0x001D74D0
	public unsafe bool m_bUseAutomaticCameraLODSwitch
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_bUseAutomaticCameraLODSwitch);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_bUseAutomaticCameraLODSwitch)) = value;
		}
	}

	// Token: 0x170029FD RID: 10749
	// (get) Token: 0x06007559 RID: 30041 RVA: 0x001D92F4 File Offset: 0x001D74F4
	// (set) Token: 0x0600755A RID: 30042 RVA: 0x001D9312 File Offset: 0x001D7512
	public unsafe static int k_MaxLODChecksPerFrame
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AutomaticLOD.NativeFieldInfoPtr_k_MaxLODChecksPerFrame, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AutomaticLOD.NativeFieldInfoPtr_k_MaxLODChecksPerFrame, (void*)(&value));
		}
	}

	// Token: 0x170029FE RID: 10750
	// (get) Token: 0x0600755B RID: 30043 RVA: 0x001D9324 File Offset: 0x001D7524
	// (set) Token: 0x0600755C RID: 30044 RVA: 0x001D9342 File Offset: 0x001D7542
	public unsafe static int k_MaxFrameCheckLoop
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AutomaticLOD.NativeFieldInfoPtr_k_MaxFrameCheckLoop, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AutomaticLOD.NativeFieldInfoPtr_k_MaxFrameCheckLoop, (void*)(&value));
		}
	}

	// Token: 0x170029FF RID: 10751
	// (get) Token: 0x0600755D RID: 30045 RVA: 0x001D9354 File Offset: 0x001D7554
	// (set) Token: 0x0600755E RID: 30046 RVA: 0x001D9372 File Offset: 0x001D7572
	public unsafe static int s_currentCheckIndex
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AutomaticLOD.NativeFieldInfoPtr_s_currentCheckIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AutomaticLOD.NativeFieldInfoPtr_s_currentCheckIndex, (void*)(&value));
		}
	}

	// Token: 0x17002A00 RID: 10752
	// (get) Token: 0x0600755F RID: 30047 RVA: 0x001D9384 File Offset: 0x001D7584
	// (set) Token: 0x06007560 RID: 30048 RVA: 0x001D93A2 File Offset: 0x001D75A2
	public unsafe static int s_currentFrameCheckIndex
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AutomaticLOD.NativeFieldInfoPtr_s_currentFrameCheckIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AutomaticLOD.NativeFieldInfoPtr_s_currentFrameCheckIndex, (void*)(&value));
		}
	}

	// Token: 0x17002A01 RID: 10753
	// (get) Token: 0x06007561 RID: 30049 RVA: 0x001D93B4 File Offset: 0x001D75B4
	// (set) Token: 0x06007562 RID: 30050 RVA: 0x001D93D2 File Offset: 0x001D75D2
	public unsafe static int s_checkLoopLength
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AutomaticLOD.NativeFieldInfoPtr_s_checkLoopLength, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AutomaticLOD.NativeFieldInfoPtr_s_checkLoopLength, (void*)(&value));
		}
	}

	// Token: 0x17002A02 RID: 10754
	// (get) Token: 0x06007563 RID: 30051 RVA: 0x001D93E4 File Offset: 0x001D75E4
	// (set) Token: 0x06007564 RID: 30052 RVA: 0x001D9402 File Offset: 0x001D7602
	public unsafe static int s_lastFrameComputedModulus
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AutomaticLOD.NativeFieldInfoPtr_s_lastFrameComputedModulus, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AutomaticLOD.NativeFieldInfoPtr_s_lastFrameComputedModulus, (void*)(&value));
		}
	}

	// Token: 0x17002A03 RID: 10755
	// (get) Token: 0x06007565 RID: 30053 RVA: 0x001D9414 File Offset: 0x001D7614
	// (set) Token: 0x06007566 RID: 30054 RVA: 0x001D9432 File Offset: 0x001D7632
	public unsafe static int s_currentFrameInLoop
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AutomaticLOD.NativeFieldInfoPtr_s_currentFrameInLoop, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AutomaticLOD.NativeFieldInfoPtr_s_currentFrameInLoop, (void*)(&value));
		}
	}

	// Token: 0x17002A04 RID: 10756
	// (get) Token: 0x06007567 RID: 30055 RVA: 0x001D9444 File Offset: 0x001D7644
	// (set) Token: 0x06007568 RID: 30056 RVA: 0x001D946F File Offset: 0x001D766F
	public unsafe static Camera s_userDefinedCamera
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AutomaticLOD.NativeFieldInfoPtr_s_userDefinedCamera, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Camera(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AutomaticLOD.NativeFieldInfoPtr_s_userDefinedCamera, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002A05 RID: 10757
	// (get) Token: 0x06007569 RID: 30057 RVA: 0x001D9484 File Offset: 0x001D7684
	// (set) Token: 0x0600756A RID: 30058 RVA: 0x001D94B8 File Offset: 0x001D76B8
	public unsafe Camera m_renderCamera
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_renderCamera);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Camera(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_renderCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002A06 RID: 10758
	// (get) Token: 0x0600756B RID: 30059 RVA: 0x001D94E0 File Offset: 0x001D76E0
	// (set) Token: 0x0600756C RID: 30060 RVA: 0x001D9508 File Offset: 0x001D7708
	public unsafe int m_nCurrentLOD
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_nCurrentLOD);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_nCurrentLOD)) = value;
		}
	}

	// Token: 0x17002A07 RID: 10759
	// (get) Token: 0x0600756D RID: 30061 RVA: 0x001D952C File Offset: 0x001D772C
	// (set) Token: 0x0600756E RID: 30062 RVA: 0x001D9560 File Offset: 0x001D7760
	public unsafe Dictionary<Camera, int> m_cachedFrameLODLevel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_cachedFrameLODLevel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Dictionary<Camera, int>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_cachedFrameLODLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002A08 RID: 10760
	// (get) Token: 0x0600756F RID: 30063 RVA: 0x001D9588 File Offset: 0x001D7788
	// (set) Token: 0x06007570 RID: 30064 RVA: 0x001D95B0 File Offset: 0x001D77B0
	public unsafe Vector3 m_localCenter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_localCenter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_localCenter)) = value;
		}
	}

	// Token: 0x17002A09 RID: 10761
	// (get) Token: 0x06007571 RID: 30065 RVA: 0x001D95D4 File Offset: 0x001D77D4
	// (set) Token: 0x06007572 RID: 30066 RVA: 0x001D9608 File Offset: 0x001D7808
	public unsafe Il2CppStructArray<Vector3> _corners
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr__corners);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppStructArray<Vector3>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr__corners), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002A0A RID: 10762
	// (get) Token: 0x06007573 RID: 30067 RVA: 0x001D9630 File Offset: 0x001D7830
	// (set) Token: 0x06007574 RID: 30068 RVA: 0x001D9658 File Offset: 0x001D7858
	public unsafe int m_frameToCheck
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_frameToCheck);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_m_frameToCheck)) = value;
		}
	}

	// Token: 0x17002A0B RID: 10763
	// (get) Token: 0x06007575 RID: 30069 RVA: 0x001D967C File Offset: 0x001D787C
	// (set) Token: 0x06007576 RID: 30070 RVA: 0x001D96A4 File Offset: 0x001D78A4
	public unsafe bool b_performCheck
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_b_performCheck);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.NativeFieldInfoPtr_b_performCheck)) = value;
		}
	}

	// Token: 0x04004ABA RID: 19130
	private static readonly IntPtr NativeFieldInfoPtr_m_originalMesh;

	// Token: 0x04004ABB RID: 19131
	private static readonly IntPtr NativeFieldInfoPtr_m_evalMode;

	// Token: 0x04004ABC RID: 19132
	private static readonly IntPtr NativeFieldInfoPtr_m_bEnablePrefabUsage;

	// Token: 0x04004ABD RID: 19133
	private static readonly IntPtr NativeFieldInfoPtr_m_strAssetPath;

	// Token: 0x04004ABE RID: 19134
	private static readonly IntPtr NativeFieldInfoPtr_m_fMaxCameraDistance;

	// Token: 0x04004ABF RID: 19135
	private static readonly IntPtr NativeFieldInfoPtr_m_nColorEditorBarNewIndex;

	// Token: 0x04004AC0 RID: 19136
	private static readonly IntPtr NativeFieldInfoPtr_m_listLODLevels;

	// Token: 0x04004AC1 RID: 19137
	private static readonly IntPtr NativeFieldInfoPtr_m_LODObjectRoot;

	// Token: 0x04004AC2 RID: 19138
	private static readonly IntPtr NativeFieldInfoPtr_m_listDependentChildren;

	// Token: 0x04004AC3 RID: 19139
	private static readonly IntPtr NativeFieldInfoPtr_m_bExpandRelevanceSpheres;

	// Token: 0x04004AC4 RID: 19140
	private static readonly IntPtr NativeFieldInfoPtr_m_aRelevanceSpheres;

	// Token: 0x04004AC5 RID: 19141
	private static readonly IntPtr NativeFieldInfoPtr_m_meshSimplifier;

	// Token: 0x04004AC6 RID: 19142
	private static readonly IntPtr NativeFieldInfoPtr_m_bGenerateIncludeChildren;

	// Token: 0x04004AC7 RID: 19143
	private static readonly IntPtr NativeFieldInfoPtr_m_levelsToGenerate;

	// Token: 0x04004AC8 RID: 19144
	private static readonly IntPtr NativeFieldInfoPtr_m_switchMode;

	// Token: 0x04004AC9 RID: 19145
	private static readonly IntPtr NativeFieldInfoPtr_m_bOverrideRootSettings;

	// Token: 0x04004ACA RID: 19146
	private static readonly IntPtr NativeFieldInfoPtr_m_bLODDataDirty;

	// Token: 0x04004ACB RID: 19147
	private static readonly IntPtr NativeFieldInfoPtr_m_LODObjectRootPersist;

	// Token: 0x04004ACC RID: 19148
	private static readonly IntPtr NativeFieldInfoPtr_m_LODGroup;

	// Token: 0x04004ACD RID: 19149
	private static readonly IntPtr NativeFieldInfoPtr_m_bUseAutomaticCameraLODSwitch;

	// Token: 0x04004ACE RID: 19150
	private static readonly IntPtr NativeFieldInfoPtr_k_MaxLODChecksPerFrame;

	// Token: 0x04004ACF RID: 19151
	private static readonly IntPtr NativeFieldInfoPtr_k_MaxFrameCheckLoop;

	// Token: 0x04004AD0 RID: 19152
	private static readonly IntPtr NativeFieldInfoPtr_s_currentCheckIndex;

	// Token: 0x04004AD1 RID: 19153
	private static readonly IntPtr NativeFieldInfoPtr_s_currentFrameCheckIndex;

	// Token: 0x04004AD2 RID: 19154
	private static readonly IntPtr NativeFieldInfoPtr_s_checkLoopLength;

	// Token: 0x04004AD3 RID: 19155
	private static readonly IntPtr NativeFieldInfoPtr_s_lastFrameComputedModulus;

	// Token: 0x04004AD4 RID: 19156
	private static readonly IntPtr NativeFieldInfoPtr_s_currentFrameInLoop;

	// Token: 0x04004AD5 RID: 19157
	private static readonly IntPtr NativeFieldInfoPtr_s_userDefinedCamera;

	// Token: 0x04004AD6 RID: 19158
	private static readonly IntPtr NativeFieldInfoPtr_m_renderCamera;

	// Token: 0x04004AD7 RID: 19159
	private static readonly IntPtr NativeFieldInfoPtr_m_nCurrentLOD;

	// Token: 0x04004AD8 RID: 19160
	private static readonly IntPtr NativeFieldInfoPtr_m_cachedFrameLODLevel;

	// Token: 0x04004AD9 RID: 19161
	private static readonly IntPtr NativeFieldInfoPtr_m_localCenter;

	// Token: 0x04004ADA RID: 19162
	private static readonly IntPtr NativeFieldInfoPtr__corners;

	// Token: 0x04004ADB RID: 19163
	private static readonly IntPtr NativeFieldInfoPtr_m_frameToCheck;

	// Token: 0x04004ADC RID: 19164
	private static readonly IntPtr NativeFieldInfoPtr_b_performCheck;

	// Token: 0x04004ADD RID: 19165
	private static readonly IntPtr NativeMethodInfoPtr_get_UserDefinedLODCamera_Public_Static_get_Camera_0;

	// Token: 0x04004ADE RID: 19166
	private static readonly IntPtr NativeMethodInfoPtr_set_UserDefinedLODCamera_Public_Static_set_Void_Camera_0;

	// Token: 0x04004ADF RID: 19167
	private static readonly IntPtr NativeMethodInfoPtr_get_LODSwitchMode_Public_get_SwitchMode_0;

	// Token: 0x04004AE0 RID: 19168
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04004AE1 RID: 19169
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04004AE2 RID: 19170
	private static readonly IntPtr NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0;

	// Token: 0x04004AE3 RID: 19171
	private static readonly IntPtr NativeMethodInfoPtr_HasValidMeshData_Public_Static_Boolean_GameObject_0;

	// Token: 0x04004AE4 RID: 19172
	private static readonly IntPtr NativeMethodInfoPtr_IsRootOrBelongsToLODTree_Public_Static_Boolean_AutomaticLOD_AutomaticLOD_0;

	// Token: 0x04004AE5 RID: 19173
	private static readonly IntPtr NativeMethodInfoPtr_GetNumberOfLevelsToGenerate_Public_Int32_0;

	// Token: 0x04004AE6 RID: 19174
	private static readonly IntPtr NativeMethodInfoPtr_IsGenerateIncludeChildrenActive_Public_Boolean_0;

	// Token: 0x04004AE7 RID: 19175
	private static readonly IntPtr NativeMethodInfoPtr_IsRootAutomaticLOD_Public_Boolean_0;

	// Token: 0x04004AE8 RID: 19176
	private static readonly IntPtr NativeMethodInfoPtr_HasDependentChildren_Public_Boolean_0;

	// Token: 0x04004AE9 RID: 19177
	private static readonly IntPtr NativeMethodInfoPtr_HasLODDataDirty_Public_Boolean_0;

	// Token: 0x04004AEA RID: 19178
	private static readonly IntPtr NativeMethodInfoPtr_SetLODDataDirty_Public_Boolean_Boolean_0;

	// Token: 0x04004AEB RID: 19179
	private static readonly IntPtr NativeMethodInfoPtr_GetLODLevelCount_Public_Int32_0;

	// Token: 0x04004AEC RID: 19180
	private static readonly IntPtr NativeMethodInfoPtr_ComputeScreenCoverage_Public_Single_Camera_0;

	// Token: 0x04004AED RID: 19181
	private static readonly IntPtr NativeMethodInfoPtr_ComputeWorldCenter_Public_Vector3_0;

	// Token: 0x04004AEE RID: 19182
	private static readonly IntPtr NativeMethodInfoPtr_ComputeViewSpaceBounds_Public_Single_Vector3_Vector3_Vector3_byref_Vector3_byref_Vector3_byref_Vector3_0;

	// Token: 0x04004AEF RID: 19183
	private static readonly IntPtr NativeMethodInfoPtr_SetAutomaticCameraLODSwitch_Public_Void_Boolean_0;

	// Token: 0x04004AF0 RID: 19184
	private static readonly IntPtr NativeMethodInfoPtr_SetAutomaticCameraLODSwitchRecursive_Private_Static_Void_AutomaticLOD_GameObject_Boolean_0;

	// Token: 0x04004AF1 RID: 19185
	private static readonly IntPtr NativeMethodInfoPtr_SetLODLevels_Public_Void_List_1_LODLevelData_EvalMode_Single_Boolean_0;

	// Token: 0x04004AF2 RID: 19186
	private static readonly IntPtr NativeMethodInfoPtr_SetLODLevelsRecursive_Private_Static_Void_AutomaticLOD_GameObject_0;

	// Token: 0x04004AF3 RID: 19187
	private static readonly IntPtr NativeMethodInfoPtr_AddLODLevel_Public_Void_Int32_Boolean_Boolean_Boolean_0;

	// Token: 0x04004AF4 RID: 19188
	private static readonly IntPtr NativeMethodInfoPtr_AddLODLevelRecursive_Public_Static_Void_AutomaticLOD_GameObject_Int32_Boolean_Boolean_Boolean_0;

	// Token: 0x04004AF5 RID: 19189
	private static readonly IntPtr NativeMethodInfoPtr_RemoveLODLevel_Public_Void_Int32_Boolean_Boolean_0;

	// Token: 0x04004AF6 RID: 19190
	private static readonly IntPtr NativeMethodInfoPtr_RemoveLODLevelRecursive_Public_Static_Void_AutomaticLOD_GameObject_Int32_Boolean_Boolean_0;

	// Token: 0x04004AF7 RID: 19191
	private static readonly IntPtr NativeMethodInfoPtr_GetMeshSimplifier_Public_Simplifier_0;

	// Token: 0x04004AF8 RID: 19192
	private static readonly IntPtr NativeMethodInfoPtr_ComputeLODData_Public_Void_Boolean_ProgressDelegate_0;

	// Token: 0x04004AF9 RID: 19193
	private static readonly IntPtr NativeMethodInfoPtr_ComputeLODDataRecursive_Private_Void_AutomaticLOD_GameObject_Boolean_ProgressDelegate_0;

	// Token: 0x04004AFA RID: 19194
	private static readonly IntPtr NativeMethodInfoPtr_HasLODData_Public_Boolean_0;

	// Token: 0x04004AFB RID: 19195
	private static readonly IntPtr NativeMethodInfoPtr_GetLODLevelUsingCamera_Public_Int32_Camera_0;

	// Token: 0x04004AFC RID: 19196
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentLODLevel_Public_Int32_0;

	// Token: 0x04004AFD RID: 19197
	private static readonly IntPtr NativeMethodInfoPtr_SwitchToLOD_Public_Void_Int32_Boolean_0;

	// Token: 0x04004AFE RID: 19198
	private static readonly IntPtr NativeMethodInfoPtr_SwitchToLODRecursive_Private_Static_Void_AutomaticLOD_GameObject_Int32_Boolean_0;

	// Token: 0x04004AFF RID: 19199
	private static readonly IntPtr NativeMethodInfoPtr_ComputeAllLODMeshes_Public_Void_Boolean_ProgressDelegate_0;

	// Token: 0x04004B00 RID: 19200
	private static readonly IntPtr NativeMethodInfoPtr_ComputeLODMesh_Public_Void_Int32_Boolean_ProgressDelegate_0;

	// Token: 0x04004B01 RID: 19201
	private static readonly IntPtr NativeMethodInfoPtr_ComputeLODMeshRecursive_Private_Static_Void_AutomaticLOD_GameObject_Int32_Boolean_ProgressDelegate_0;

	// Token: 0x04004B02 RID: 19202
	private static readonly IntPtr NativeMethodInfoPtr_RestoreOriginalMesh_Public_Void_Boolean_Boolean_0;

	// Token: 0x04004B03 RID: 19203
	private static readonly IntPtr NativeMethodInfoPtr_RestoreOriginalMeshRecursive_Private_Static_Void_AutomaticLOD_GameObject_Boolean_Boolean_0;

	// Token: 0x04004B04 RID: 19204
	private static readonly IntPtr NativeMethodInfoPtr_HasOriginalMeshActive_Public_Boolean_Boolean_0;

	// Token: 0x04004B05 RID: 19205
	private static readonly IntPtr NativeMethodInfoPtr_HasOriginalMeshActiveRecursive_Private_Static_Boolean_AutomaticLOD_GameObject_Boolean_0;

	// Token: 0x04004B06 RID: 19206
	private static readonly IntPtr NativeMethodInfoPtr_HasVertexData_Public_Boolean_Int32_Boolean_0;

	// Token: 0x04004B07 RID: 19207
	private static readonly IntPtr NativeMethodInfoPtr_HasVertexDataRecursive_Private_Static_Boolean_AutomaticLOD_GameObject_Int32_Boolean_0;

	// Token: 0x04004B08 RID: 19208
	private static readonly IntPtr NativeMethodInfoPtr_GetOriginalVertexCount_Public_Int32_Boolean_0;

	// Token: 0x04004B09 RID: 19209
	private static readonly IntPtr NativeMethodInfoPtr_GetOriginalVertexCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_byref_Int32_Boolean_0;

	// Token: 0x04004B0A RID: 19210
	private static readonly IntPtr NativeMethodInfoPtr_GetOriginalTriangleCount_Public_Int32_Boolean_0;

	// Token: 0x04004B0B RID: 19211
	private static readonly IntPtr NativeMethodInfoPtr_GetOriginalTriangleCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_byref_Int32_Boolean_0;

	// Token: 0x04004B0C RID: 19212
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentVertexCount_Public_Int32_Boolean_0;

	// Token: 0x04004B0D RID: 19213
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentVertexCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_byref_Int32_Boolean_0;

	// Token: 0x04004B0E RID: 19214
	private static readonly IntPtr NativeMethodInfoPtr_GetLODVertexCount_Public_Int32_Int32_Boolean_0;

	// Token: 0x04004B0F RID: 19215
	private static readonly IntPtr NativeMethodInfoPtr_GetLODVertexCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_Int32_byref_Int32_Boolean_0;

	// Token: 0x04004B10 RID: 19216
	private static readonly IntPtr NativeMethodInfoPtr_GetLODTriangleCount_Public_Int32_Int32_Boolean_0;

	// Token: 0x04004B11 RID: 19217
	private static readonly IntPtr NativeMethodInfoPtr_GetLODTriangleCountRecursive_Private_Static_Void_AutomaticLOD_GameObject_Int32_byref_Int32_Boolean_0;

	// Token: 0x04004B12 RID: 19218
	private static readonly IntPtr NativeMethodInfoPtr_RemoveFromLODTree_Public_Void_0;

	// Token: 0x04004B13 RID: 19219
	private static readonly IntPtr NativeMethodInfoPtr_FreeLODData_Public_Void_Boolean_0;

	// Token: 0x04004B14 RID: 19220
	private static readonly IntPtr NativeMethodInfoPtr_FreeLODDataRecursive_Private_Static_Void_AutomaticLOD_GameObject_Boolean_0;

	// Token: 0x04004B15 RID: 19221
	private static readonly IntPtr NativeMethodInfoPtr_CreateNewEmptyMesh_Private_Static_Mesh_AutomaticLOD_0;

	// Token: 0x04004B16 RID: 19222
	private static readonly IntPtr NativeMethodInfoPtr_CreateBasicObjectCopy_Private_Static_GameObject_GameObject_Mesh_Transform_0;

	// Token: 0x04004B17 RID: 19223
	private static readonly IntPtr NativeMethodInfoPtr_CheckForAdditionalLODSetup_Private_Static_Void_AutomaticLOD_AutomaticLOD_LODLevelData_Int32_0;

	// Token: 0x04004B18 RID: 19224
	private static readonly IntPtr NativeMethodInfoPtr_SetupLODGroup_Public_Void_0;

	// Token: 0x04004B19 RID: 19225
	private static readonly IntPtr NativeMethodInfoPtr_SetupLODGroupRecursive_Private_Static_Void_AutomaticLOD_GameObject_byref_List_1_List_1_Renderer_0;

	// Token: 0x04004B1A RID: 19226
	private static readonly IntPtr NativeMethodInfoPtr_CopyComponent_Private_Static_Component_Component_GameObject_0;

	// Token: 0x04004B1B RID: 19227
	private static readonly IntPtr NativeMethodInfoPtr_BuildCornerData_Private_Void_byref_ArrayOf_Vector3_Bounds_0;

	// Token: 0x04004B1C RID: 19228
	private static readonly IntPtr NativeMethodInfoPtr_IsDependent_Private_Boolean_0;

	// Token: 0x04004B1D RID: 19229
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200059C RID: 1436
	[Serializable]
	public enum EvalMode
	{
		// Token: 0x04004B1F RID: 19231
		CameraDistance,
		// Token: 0x04004B20 RID: 19232
		ScreenCoverage
	}

	// Token: 0x0200059D RID: 1437
	[Serializable]
	public enum LevelsToGenerate
	{
		// Token: 0x04004B22 RID: 19234
		_1 = 1,
		// Token: 0x04004B23 RID: 19235
		_2,
		// Token: 0x04004B24 RID: 19236
		_3,
		// Token: 0x04004B25 RID: 19237
		_4,
		// Token: 0x04004B26 RID: 19238
		_5,
		// Token: 0x04004B27 RID: 19239
		_6
	}

	// Token: 0x0200059E RID: 1438
	[Serializable]
	public enum SwitchMode
	{
		// Token: 0x04004B29 RID: 19241
		SwitchMesh,
		// Token: 0x04004B2A RID: 19242
		SwitchGameObject,
		// Token: 0x04004B2B RID: 19243
		UnityLODGroup
	}

	// Token: 0x0200059F RID: 1439
	[Serializable]
	public class LODLevelData : Il2CppSystem.Object
	{
		// Token: 0x0600757D RID: 30077 RVA: 0x001D973C File Offset: 0x001D793C
		[CallerCount(0)]
		public unsafe AutomaticLOD.LODLevelData GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.LODLevelData.NativeMethodInfoPtr_GetCopy_Public_LODLevelData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new AutomaticLOD.LODLevelData(intPtr2) : null;
		}

		// Token: 0x0600757E RID: 30078 RVA: 0x001D9794 File Offset: 0x001D7994
		[CallerCount(0)]
		public unsafe LODLevelData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutomaticLOD.LODLevelData>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutomaticLOD.LODLevelData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600757F RID: 30079 RVA: 0x001D97E0 File Offset: 0x001D79E0
		// Note: this type is marked as 'beforefieldinit'.
		static LODLevelData()
		{
			Il2CppClassPointerStore<AutomaticLOD.LODLevelData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AutomaticLOD>.NativeClassPtr, "LODLevelData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutomaticLOD.LODLevelData>.NativeClassPtr);
			AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_fScreenCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD.LODLevelData>.NativeClassPtr, "m_fScreenCoverage");
			AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_fMaxCameraDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD.LODLevelData>.NativeClassPtr, "m_fMaxCameraDistance");
			AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_fMeshVerticesAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD.LODLevelData>.NativeClassPtr, "m_fMeshVerticesAmount");
			AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_nColorEditorBarIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD.LODLevelData>.NativeClassPtr, "m_nColorEditorBarIndex");
			AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD.LODLevelData>.NativeClassPtr, "m_mesh");
			AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_bUsesOriginalMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD.LODLevelData>.NativeClassPtr, "m_bUsesOriginalMesh");
			AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutomaticLOD.LODLevelData>.NativeClassPtr, "m_gameObject");
			AutomaticLOD.LODLevelData.NativeMethodInfoPtr_GetCopy_Public_LODLevelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD.LODLevelData>.NativeClassPtr, 100672661);
			AutomaticLOD.LODLevelData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutomaticLOD.LODLevelData>.NativeClassPtr, 100672662);
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x00002988 File Offset: 0x00000B88
		public LODLevelData(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x06007581 RID: 30081 RVA: 0x001D98BF File Offset: 0x001D7ABF
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AutomaticLOD.LODLevelData>.NativeClassPtr));
			}
		}

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x06007582 RID: 30082 RVA: 0x001D98D0 File Offset: 0x001D7AD0
		// (set) Token: 0x06007583 RID: 30083 RVA: 0x001D98F8 File Offset: 0x001D7AF8
		public unsafe float m_fScreenCoverage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_fScreenCoverage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_fScreenCoverage)) = value;
			}
		}

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x06007584 RID: 30084 RVA: 0x001D991C File Offset: 0x001D7B1C
		// (set) Token: 0x06007585 RID: 30085 RVA: 0x001D9944 File Offset: 0x001D7B44
		public unsafe float m_fMaxCameraDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_fMaxCameraDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_fMaxCameraDistance)) = value;
			}
		}

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x06007586 RID: 30086 RVA: 0x001D9968 File Offset: 0x001D7B68
		// (set) Token: 0x06007587 RID: 30087 RVA: 0x001D9990 File Offset: 0x001D7B90
		public unsafe float m_fMeshVerticesAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_fMeshVerticesAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_fMeshVerticesAmount)) = value;
			}
		}

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x06007588 RID: 30088 RVA: 0x001D99B4 File Offset: 0x001D7BB4
		// (set) Token: 0x06007589 RID: 30089 RVA: 0x001D99DC File Offset: 0x001D7BDC
		public unsafe int m_nColorEditorBarIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_nColorEditorBarIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_nColorEditorBarIndex)) = value;
			}
		}

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x0600758A RID: 30090 RVA: 0x001D9A00 File Offset: 0x001D7C00
		// (set) Token: 0x0600758B RID: 30091 RVA: 0x001D9A34 File Offset: 0x001D7C34
		public unsafe Mesh m_mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x0600758C RID: 30092 RVA: 0x001D9A5C File Offset: 0x001D7C5C
		// (set) Token: 0x0600758D RID: 30093 RVA: 0x001D9A84 File Offset: 0x001D7C84
		public unsafe bool m_bUsesOriginalMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_bUsesOriginalMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_bUsesOriginalMesh)) = value;
			}
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x0600758E RID: 30094 RVA: 0x001D9AA8 File Offset: 0x001D7CA8
		// (set) Token: 0x0600758F RID: 30095 RVA: 0x001D9ADC File Offset: 0x001D7CDC
		public unsafe GameObject m_gameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_gameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutomaticLOD.LODLevelData.NativeFieldInfoPtr_m_gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B2C RID: 19244
		private static readonly IntPtr NativeFieldInfoPtr_m_fScreenCoverage;

		// Token: 0x04004B2D RID: 19245
		private static readonly IntPtr NativeFieldInfoPtr_m_fMaxCameraDistance;

		// Token: 0x04004B2E RID: 19246
		private static readonly IntPtr NativeFieldInfoPtr_m_fMeshVerticesAmount;

		// Token: 0x04004B2F RID: 19247
		private static readonly IntPtr NativeFieldInfoPtr_m_nColorEditorBarIndex;

		// Token: 0x04004B30 RID: 19248
		private static readonly IntPtr NativeFieldInfoPtr_m_mesh;

		// Token: 0x04004B31 RID: 19249
		private static readonly IntPtr NativeFieldInfoPtr_m_bUsesOriginalMesh;

		// Token: 0x04004B32 RID: 19250
		private static readonly IntPtr NativeFieldInfoPtr_m_gameObject;

		// Token: 0x04004B33 RID: 19251
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_LODLevelData_0;

		// Token: 0x04004B34 RID: 19252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
