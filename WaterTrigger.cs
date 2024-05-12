using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200012B RID: 299
public class WaterTrigger : MonoBehaviour
{
	// Token: 0x060012E0 RID: 4832 RVA: 0x0004C820 File Offset: 0x0004AA20
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterTrigger.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x0004C864 File Offset: 0x0004AA64
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterTrigger.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x0004C8A8 File Offset: 0x0004AAA8
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterTrigger.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x0004C8EC File Offset: 0x0004AAEC
	[CallerCount(0)]
	public unsafe void OnTriggerEnter(Collider other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterTrigger.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x0004C948 File Offset: 0x0004AB48
	[CallerCount(0)]
	public unsafe void OnTriggerExit(Collider other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterTrigger.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x0004C9A4 File Offset: 0x0004ABA4
	[CallerCount(0)]
	public unsafe void OnGroundDetectorEnter(GroundDetector detector)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(detector);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterTrigger.NativeMethodInfoPtr_OnGroundDetectorEnter_Public_Void_GroundDetector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x0004CA00 File Offset: 0x0004AC00
	[CallerCount(0)]
	public unsafe void OnGroundDetectorExit(GroundDetector detector)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(detector);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterTrigger.NativeMethodInfoPtr_OnGroundDetectorExit_Public_Void_GroundDetector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x0004CA5C File Offset: 0x0004AC5C
	[CallerCount(0)]
	public unsafe WaterTrigger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x0004CAA8 File Offset: 0x0004ACA8
	// Note: this type is marked as 'beforefieldinit'.
	static WaterTrigger()
	{
		Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WaterTrigger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr);
		WaterTrigger.NativeFieldInfoPtr_WaterTriggersByCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr, "WaterTriggersByCollider");
		WaterTrigger.NativeFieldInfoPtr_PickupLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr, "PickupLayer");
		WaterTrigger.NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr, "colliders");
		WaterTrigger.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr, 100664868);
		WaterTrigger.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr, 100664869);
		WaterTrigger.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr, 100664870);
		WaterTrigger.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr, 100664871);
		WaterTrigger.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr, 100664872);
		WaterTrigger.NativeMethodInfoPtr_OnGroundDetectorEnter_Public_Void_GroundDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr, 100664873);
		WaterTrigger.NativeMethodInfoPtr_OnGroundDetectorExit_Public_Void_GroundDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr, 100664874);
		WaterTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr, 100664875);
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x0000210C File Offset: 0x0000030C
	public WaterTrigger(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000666 RID: 1638
	// (get) Token: 0x060012EA RID: 4842 RVA: 0x0004CBB4 File Offset: 0x0004ADB4
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WaterTrigger>.NativeClassPtr));
		}
	}

	// Token: 0x17000667 RID: 1639
	// (get) Token: 0x060012EB RID: 4843 RVA: 0x0004CBC8 File Offset: 0x0004ADC8
	// (set) Token: 0x060012EC RID: 4844 RVA: 0x0004CBF3 File Offset: 0x0004ADF3
	public unsafe static Dictionary<Collider, WaterTrigger> WaterTriggersByCollider
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WaterTrigger.NativeFieldInfoPtr_WaterTriggersByCollider, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Dictionary<Collider, WaterTrigger>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WaterTrigger.NativeFieldInfoPtr_WaterTriggersByCollider, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000668 RID: 1640
	// (get) Token: 0x060012ED RID: 4845 RVA: 0x0004CC08 File Offset: 0x0004AE08
	// (set) Token: 0x060012EE RID: 4846 RVA: 0x0004CC30 File Offset: 0x0004AE30
	public unsafe LayerMask PickupLayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterTrigger.NativeFieldInfoPtr_PickupLayer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterTrigger.NativeFieldInfoPtr_PickupLayer)) = value;
		}
	}

	// Token: 0x17000669 RID: 1641
	// (get) Token: 0x060012EF RID: 4847 RVA: 0x0004CC54 File Offset: 0x0004AE54
	// (set) Token: 0x060012F0 RID: 4848 RVA: 0x0004CC88 File Offset: 0x0004AE88
	public unsafe Il2CppReferenceArray<Collider> colliders
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterTrigger.NativeFieldInfoPtr_colliders);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<Collider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterTrigger.NativeFieldInfoPtr_colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000C13 RID: 3091
	private static readonly IntPtr NativeFieldInfoPtr_WaterTriggersByCollider;

	// Token: 0x04000C14 RID: 3092
	private static readonly IntPtr NativeFieldInfoPtr_PickupLayer;

	// Token: 0x04000C15 RID: 3093
	private static readonly IntPtr NativeFieldInfoPtr_colliders;

	// Token: 0x04000C16 RID: 3094
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000C17 RID: 3095
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04000C18 RID: 3096
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04000C19 RID: 3097
	private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

	// Token: 0x04000C1A RID: 3098
	private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

	// Token: 0x04000C1B RID: 3099
	private static readonly IntPtr NativeMethodInfoPtr_OnGroundDetectorEnter_Public_Void_GroundDetector_0;

	// Token: 0x04000C1C RID: 3100
	private static readonly IntPtr NativeMethodInfoPtr_OnGroundDetectorExit_Public_Void_GroundDetector_0;

	// Token: 0x04000C1D RID: 3101
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
