using System;
using AK.Wwise;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000133 RID: 307
public class AreaVolume : MonoBehaviour
{
	// Token: 0x0600135E RID: 4958 RVA: 0x0004E580 File Offset: 0x0004C780
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AreaVolume.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x0004E5D0 File Offset: 0x0004C7D0
	[CallerCount(0)]
	public unsafe void SetupCollider()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AreaVolume.NativeMethodInfoPtr_SetupCollider_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x0004E614 File Offset: 0x0004C814
	[CallerCount(0)]
	public unsafe bool IsPointInside(Vector3 point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref point;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AreaVolume.NativeMethodInfoPtr_IsPointInside_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x0004E678 File Offset: 0x0004C878
	[CallerCount(0)]
	public unsafe static void PointAudioCheck(Vector3 point, ref AudioManager.ReverbBusType busType, ref int muffleZoneGroupID)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref point;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &busType;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &muffleZoneGroupID;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AreaVolume.NativeMethodInfoPtr_PointAudioCheck_Public_Static_Void_Vector3_byref_ReverbBusType_byref_Int32_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x0004E6E8 File Offset: 0x0004C8E8
	[CallerCount(0)]
	public unsafe static void ListenerPointAudioCheck(Vector3 point, ref State globalAmbientState)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref point;
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(globalAmbientState);
		ptr2 = &intPtr;
		IntPtr returnedException;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AreaVolume.NativeMethodInfoPtr_ListenerPointAudioCheck_Public_Static_Void_Vector3_byref_State_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr3 = intPtr;
		globalAmbientState = ((intPtr3 == 0) ? null : new State(intPtr3));
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x0004E768 File Offset: 0x0004C968
	[CallerCount(0)]
	public unsafe AreaVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AreaVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x0004E7B4 File Offset: 0x0004C9B4
	// Note: this type is marked as 'beforefieldinit'.
	static AreaVolume()
	{
		Il2CppClassPointerStore<AreaVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AreaVolume");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr);
		AreaVolume.NativeFieldInfoPtr_AUDIO_REVERB_LAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, "AUDIO_REVERB_LAYER");
		AreaVolume.NativeFieldInfoPtr_AreaCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, "AreaCollider");
		AreaVolume.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, "_transform");
		AreaVolume.NativeFieldInfoPtr__position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, "_position");
		AreaVolume.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, "_rotation");
		AreaVolume.NativeFieldInfoPtr__bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, "_bounds");
		AreaVolume.NativeFieldInfoPtr__min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, "_min");
		AreaVolume.NativeFieldInfoPtr__max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, "_max");
		AreaVolume.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, 100664910);
		AreaVolume.NativeMethodInfoPtr_SetupCollider_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, 100664911);
		AreaVolume.NativeMethodInfoPtr_IsPointInside_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, 100664912);
		AreaVolume.NativeMethodInfoPtr_PointAudioCheck_Public_Static_Void_Vector3_byref_ReverbBusType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, 100664913);
		AreaVolume.NativeMethodInfoPtr_ListenerPointAudioCheck_Public_Static_Void_Vector3_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, 100664914);
		AreaVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr, 100664915);
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x0000210C File Offset: 0x0000030C
	public AreaVolume(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700068E RID: 1678
	// (get) Token: 0x06001366 RID: 4966 RVA: 0x0004E8FC File Offset: 0x0004CAFC
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AreaVolume>.NativeClassPtr));
		}
	}

	// Token: 0x1700068F RID: 1679
	// (get) Token: 0x06001367 RID: 4967 RVA: 0x0004E910 File Offset: 0x0004CB10
	// (set) Token: 0x06001368 RID: 4968 RVA: 0x0004E92E File Offset: 0x0004CB2E
	public unsafe static int AUDIO_REVERB_LAYER
	{
		get
		{
			int result;
			IL2CPP.il2cpp_field_static_get_value(AreaVolume.NativeFieldInfoPtr_AUDIO_REVERB_LAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AreaVolume.NativeFieldInfoPtr_AUDIO_REVERB_LAYER, (void*)(&value));
		}
	}

	// Token: 0x17000690 RID: 1680
	// (get) Token: 0x06001369 RID: 4969 RVA: 0x0004E940 File Offset: 0x0004CB40
	// (set) Token: 0x0600136A RID: 4970 RVA: 0x0004E974 File Offset: 0x0004CB74
	public unsafe BoxCollider AreaCollider
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr_AreaCollider);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new BoxCollider(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr_AreaCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000691 RID: 1681
	// (get) Token: 0x0600136B RID: 4971 RVA: 0x0004E99C File Offset: 0x0004CB9C
	// (set) Token: 0x0600136C RID: 4972 RVA: 0x0004E9D0 File Offset: 0x0004CBD0
	public unsafe Transform _transform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr__transform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000692 RID: 1682
	// (get) Token: 0x0600136D RID: 4973 RVA: 0x0004E9F8 File Offset: 0x0004CBF8
	// (set) Token: 0x0600136E RID: 4974 RVA: 0x0004EA20 File Offset: 0x0004CC20
	public unsafe Vector3 _position
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr__position);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr__position)) = value;
		}
	}

	// Token: 0x17000693 RID: 1683
	// (get) Token: 0x0600136F RID: 4975 RVA: 0x0004EA44 File Offset: 0x0004CC44
	// (set) Token: 0x06001370 RID: 4976 RVA: 0x0004EA6C File Offset: 0x0004CC6C
	public unsafe Quaternion _rotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr__rotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr__rotation)) = value;
		}
	}

	// Token: 0x17000694 RID: 1684
	// (get) Token: 0x06001371 RID: 4977 RVA: 0x0004EA90 File Offset: 0x0004CC90
	// (set) Token: 0x06001372 RID: 4978 RVA: 0x0004EAB8 File Offset: 0x0004CCB8
	public unsafe Bounds _bounds
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr__bounds);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr__bounds)) = value;
		}
	}

	// Token: 0x17000695 RID: 1685
	// (get) Token: 0x06001373 RID: 4979 RVA: 0x0004EADC File Offset: 0x0004CCDC
	// (set) Token: 0x06001374 RID: 4980 RVA: 0x0004EB04 File Offset: 0x0004CD04
	public unsafe Vector3 _min
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr__min);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr__min)) = value;
		}
	}

	// Token: 0x17000696 RID: 1686
	// (get) Token: 0x06001375 RID: 4981 RVA: 0x0004EB28 File Offset: 0x0004CD28
	// (set) Token: 0x06001376 RID: 4982 RVA: 0x0004EB50 File Offset: 0x0004CD50
	public unsafe Vector3 _max
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr__max);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AreaVolume.NativeFieldInfoPtr__max)) = value;
		}
	}

	// Token: 0x04000C59 RID: 3161
	private static readonly IntPtr NativeFieldInfoPtr_AUDIO_REVERB_LAYER;

	// Token: 0x04000C5A RID: 3162
	private static readonly IntPtr NativeFieldInfoPtr_AreaCollider;

	// Token: 0x04000C5B RID: 3163
	private static readonly IntPtr NativeFieldInfoPtr__transform;

	// Token: 0x04000C5C RID: 3164
	private static readonly IntPtr NativeFieldInfoPtr__position;

	// Token: 0x04000C5D RID: 3165
	private static readonly IntPtr NativeFieldInfoPtr__rotation;

	// Token: 0x04000C5E RID: 3166
	private static readonly IntPtr NativeFieldInfoPtr__bounds;

	// Token: 0x04000C5F RID: 3167
	private static readonly IntPtr NativeFieldInfoPtr__min;

	// Token: 0x04000C60 RID: 3168
	private static readonly IntPtr NativeFieldInfoPtr__max;

	// Token: 0x04000C61 RID: 3169
	private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

	// Token: 0x04000C62 RID: 3170
	private static readonly IntPtr NativeMethodInfoPtr_SetupCollider_Protected_Void_0;

	// Token: 0x04000C63 RID: 3171
	private static readonly IntPtr NativeMethodInfoPtr_IsPointInside_Public_Boolean_Vector3_0;

	// Token: 0x04000C64 RID: 3172
	private static readonly IntPtr NativeMethodInfoPtr_PointAudioCheck_Public_Static_Void_Vector3_byref_ReverbBusType_byref_Int32_0;

	// Token: 0x04000C65 RID: 3173
	private static readonly IntPtr NativeMethodInfoPtr_ListenerPointAudioCheck_Public_Static_Void_Vector3_byref_State_0;

	// Token: 0x04000C66 RID: 3174
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
