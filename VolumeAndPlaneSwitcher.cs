using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000096 RID: 150
public class VolumeAndPlaneSwitcher : MonoBehaviour
{
	// Token: 0x06000948 RID: 2376 RVA: 0x00026C84 File Offset: 0x00024E84
	[CallerCount(0)]
	public unsafe void ReplaceAnchor(OVRSceneAnchor prefab, Vector3 position, Quaternion rotation, Vector3 localScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localScale;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeAndPlaneSwitcher.NativeMethodInfoPtr_ReplaceAnchor_Private_Void_OVRSceneAnchor_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x00026D18 File Offset: 0x00024F18
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeAndPlaneSwitcher.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x00026D5C File Offset: 0x00024F5C
	[CallerCount(0)]
	public unsafe void GetVolumeFromTopPlane(Transform plane, Vector2 dimensions, float height, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(plane);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimensions;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &localScale;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeAndPlaneSwitcher.NativeMethodInfoPtr_GetVolumeFromTopPlane_Private_Void_Transform_Vector2_Single_byref_Vector3_byref_Quaternion_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00026E18 File Offset: 0x00025018
	[CallerCount(0)]
	public unsafe void GetTopPlaneFromVolume(Transform volume, Vector3 dimensions, out Vector3 position, out Quaternion rotation, out Vector3 localScale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dimensions;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &localScale;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeAndPlaneSwitcher.NativeMethodInfoPtr_GetTopPlaneFromVolume_Private_Void_Transform_Vector3_byref_Vector3_byref_Quaternion_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00026EC0 File Offset: 0x000250C0
	[CallerCount(0)]
	public unsafe VolumeAndPlaneSwitcher() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeAndPlaneSwitcher>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeAndPlaneSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00026F0C File Offset: 0x0002510C
	// Note: this type is marked as 'beforefieldinit'.
	static VolumeAndPlaneSwitcher()
	{
		Il2CppClassPointerStore<VolumeAndPlaneSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VolumeAndPlaneSwitcher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeAndPlaneSwitcher>.NativeClassPtr);
		VolumeAndPlaneSwitcher.NativeFieldInfoPtr_planePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeAndPlaneSwitcher>.NativeClassPtr, "planePrefab");
		VolumeAndPlaneSwitcher.NativeFieldInfoPtr_volumePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeAndPlaneSwitcher>.NativeClassPtr, "volumePrefab");
		VolumeAndPlaneSwitcher.NativeFieldInfoPtr_desiredSwitches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeAndPlaneSwitcher>.NativeClassPtr, "desiredSwitches");
		VolumeAndPlaneSwitcher.NativeMethodInfoPtr_ReplaceAnchor_Private_Void_OVRSceneAnchor_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeAndPlaneSwitcher>.NativeClassPtr, 100664043);
		VolumeAndPlaneSwitcher.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeAndPlaneSwitcher>.NativeClassPtr, 100664044);
		VolumeAndPlaneSwitcher.NativeMethodInfoPtr_GetVolumeFromTopPlane_Private_Void_Transform_Vector2_Single_byref_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeAndPlaneSwitcher>.NativeClassPtr, 100664045);
		VolumeAndPlaneSwitcher.NativeMethodInfoPtr_GetTopPlaneFromVolume_Private_Void_Transform_Vector3_byref_Vector3_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeAndPlaneSwitcher>.NativeClassPtr, 100664046);
		VolumeAndPlaneSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeAndPlaneSwitcher>.NativeClassPtr, 100664047);
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x0000210C File Offset: 0x0000030C
	public VolumeAndPlaneSwitcher(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000331 RID: 817
	// (get) Token: 0x0600094F RID: 2383 RVA: 0x00026FDC File Offset: 0x000251DC
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VolumeAndPlaneSwitcher>.NativeClassPtr));
		}
	}

	// Token: 0x17000332 RID: 818
	// (get) Token: 0x06000950 RID: 2384 RVA: 0x00026FF0 File Offset: 0x000251F0
	// (set) Token: 0x06000951 RID: 2385 RVA: 0x00027024 File Offset: 0x00025224
	public unsafe OVRSceneAnchor planePrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeAndPlaneSwitcher.NativeFieldInfoPtr_planePrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new OVRSceneAnchor(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeAndPlaneSwitcher.NativeFieldInfoPtr_planePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000333 RID: 819
	// (get) Token: 0x06000952 RID: 2386 RVA: 0x0002704C File Offset: 0x0002524C
	// (set) Token: 0x06000953 RID: 2387 RVA: 0x00027080 File Offset: 0x00025280
	public unsafe OVRSceneAnchor volumePrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeAndPlaneSwitcher.NativeFieldInfoPtr_volumePrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new OVRSceneAnchor(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeAndPlaneSwitcher.NativeFieldInfoPtr_volumePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000334 RID: 820
	// (get) Token: 0x06000954 RID: 2388 RVA: 0x000270A8 File Offset: 0x000252A8
	// (set) Token: 0x06000955 RID: 2389 RVA: 0x000270DC File Offset: 0x000252DC
	public unsafe List<VolumeAndPlaneSwitcher.LabelGeometryPair> desiredSwitches
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeAndPlaneSwitcher.NativeFieldInfoPtr_desiredSwitches);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<VolumeAndPlaneSwitcher.LabelGeometryPair>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeAndPlaneSwitcher.NativeFieldInfoPtr_desiredSwitches), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040005AD RID: 1453
	private static readonly IntPtr NativeFieldInfoPtr_planePrefab;

	// Token: 0x040005AE RID: 1454
	private static readonly IntPtr NativeFieldInfoPtr_volumePrefab;

	// Token: 0x040005AF RID: 1455
	private static readonly IntPtr NativeFieldInfoPtr_desiredSwitches;

	// Token: 0x040005B0 RID: 1456
	private static readonly IntPtr NativeMethodInfoPtr_ReplaceAnchor_Private_Void_OVRSceneAnchor_Vector3_Quaternion_Vector3_0;

	// Token: 0x040005B1 RID: 1457
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040005B2 RID: 1458
	private static readonly IntPtr NativeMethodInfoPtr_GetVolumeFromTopPlane_Private_Void_Transform_Vector2_Single_byref_Vector3_byref_Quaternion_byref_Vector3_0;

	// Token: 0x040005B3 RID: 1459
	private static readonly IntPtr NativeMethodInfoPtr_GetTopPlaneFromVolume_Private_Void_Transform_Vector3_byref_Vector3_byref_Quaternion_byref_Vector3_0;

	// Token: 0x040005B4 RID: 1460
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000097 RID: 151
	public enum GeometryType
	{
		// Token: 0x040005B6 RID: 1462
		Plane,
		// Token: 0x040005B7 RID: 1463
		Volume
	}

	// Token: 0x02000098 RID: 152
	[Serializable]
	[StructLayout(0)]
	public sealed class LabelGeometryPair : ValueType
	{
		// Token: 0x06000958 RID: 2392 RVA: 0x00027128 File Offset: 0x00025328
		// Note: this type is marked as 'beforefieldinit'.
		static LabelGeometryPair()
		{
			Il2CppClassPointerStore<VolumeAndPlaneSwitcher.LabelGeometryPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeAndPlaneSwitcher>.NativeClassPtr, "LabelGeometryPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeAndPlaneSwitcher.LabelGeometryPair>.NativeClassPtr);
			VolumeAndPlaneSwitcher.LabelGeometryPair.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeAndPlaneSwitcher.LabelGeometryPair>.NativeClassPtr, "label");
			VolumeAndPlaneSwitcher.LabelGeometryPair.NativeFieldInfoPtr_desiredGeometryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeAndPlaneSwitcher.LabelGeometryPair>.NativeClassPtr, "desiredGeometryType");
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0002717B File Offset: 0x0002537B
		public LabelGeometryPair(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00027184 File Offset: 0x00025384
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VolumeAndPlaneSwitcher.LabelGeometryPair>.NativeClassPtr));
			}
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00027198 File Offset: 0x00025398
		public unsafe LabelGeometryPair()
		{
			IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VolumeAndPlaneSwitcher.LabelGeometryPair>.NativeClassPtr, (UIntPtr)0)];
			base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumeAndPlaneSwitcher.LabelGeometryPair>.NativeClassPtr, data));
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x000271C8 File Offset: 0x000253C8
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x000271F1 File Offset: 0x000253F1
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeAndPlaneSwitcher.LabelGeometryPair.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeAndPlaneSwitcher.LabelGeometryPair.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00027218 File Offset: 0x00025418
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00027240 File Offset: 0x00025440
		public unsafe VolumeAndPlaneSwitcher.GeometryType desiredGeometryType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeAndPlaneSwitcher.LabelGeometryPair.NativeFieldInfoPtr_desiredGeometryType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeAndPlaneSwitcher.LabelGeometryPair.NativeFieldInfoPtr_desiredGeometryType)) = value;
			}
		}

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeFieldInfoPtr_desiredGeometryType;
	}
}
