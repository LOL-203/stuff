using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020001D2 RID: 466
public class VolumetricBeamVisibility : MonoBehaviour
{
	// Token: 0x06002179 RID: 8569 RVA: 0x000838E4 File Offset: 0x00081AE4
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricBeamVisibility.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600217A RID: 8570 RVA: 0x00083928 File Offset: 0x00081B28
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricBeamVisibility.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x17000BD7 RID: 3031
	// (get) Token: 0x0600217B RID: 8571 RVA: 0x0008396C File Offset: 0x00081B6C
	// (set) Token: 0x0600217C RID: 8572 RVA: 0x000839BC File Offset: 0x00081BBC
	public unsafe bool ManagedLateUpdateRemoval
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricBeamVisibility.NativeMethodInfoPtr_get_ManagedLateUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricBeamVisibility.NativeMethodInfoPtr_set_ManagedLateUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x0600217D RID: 8573 RVA: 0x00083A10 File Offset: 0x00081C10
	[CallerCount(0)]
	public unsafe void OnManagedLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricBeamVisibility.NativeMethodInfoPtr_OnManagedLateUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600217E RID: 8574 RVA: 0x00083A54 File Offset: 0x00081C54
	[CallerCount(0)]
	public unsafe int GetFrameTimeDelay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricBeamVisibility.NativeMethodInfoPtr_GetFrameTimeDelay_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x0600217F RID: 8575 RVA: 0x00083AA4 File Offset: 0x00081CA4
	[CallerCount(0)]
	public unsafe void UpdateVisibility()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricBeamVisibility.NativeMethodInfoPtr_UpdateVisibility_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002180 RID: 8576 RVA: 0x00083AE8 File Offset: 0x00081CE8
	[CallerCount(0)]
	public unsafe void SetBeamLength(float length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref length;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricBeamVisibility.NativeMethodInfoPtr_SetBeamLength_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002181 RID: 8577 RVA: 0x00083B3C File Offset: 0x00081D3C
	[CallerCount(0)]
	public unsafe VolumetricBeamVisibility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricBeamVisibility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06002182 RID: 8578 RVA: 0x00083B88 File Offset: 0x00081D88
	// Note: this type is marked as 'beforefieldinit'.
	static VolumetricBeamVisibility()
	{
		Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VolumetricBeamVisibility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr);
		VolumetricBeamVisibility.NativeFieldInfoPtr_Base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, "Base");
		VolumetricBeamVisibility.NativeFieldInfoPtr_Tip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, "Tip");
		VolumetricBeamVisibility.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, "Renderer");
		VolumetricBeamVisibility.NativeFieldInfoPtr_ClippingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, "ClippingMask");
		VolumetricBeamVisibility.NativeFieldInfoPtr_FrameCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, "FrameCounter");
		VolumetricBeamVisibility.NativeFieldInfoPtr_IsClipping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, "IsClipping");
		VolumetricBeamVisibility.NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, "<ManagedLateUpdateRemoval>k__BackingField");
		VolumetricBeamVisibility.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, 100665841);
		VolumetricBeamVisibility.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, 100665842);
		VolumetricBeamVisibility.NativeMethodInfoPtr_get_ManagedLateUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, 100665843);
		VolumetricBeamVisibility.NativeMethodInfoPtr_set_ManagedLateUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, 100665844);
		VolumetricBeamVisibility.NativeMethodInfoPtr_OnManagedLateUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, 100665845);
		VolumetricBeamVisibility.NativeMethodInfoPtr_GetFrameTimeDelay_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, 100665846);
		VolumetricBeamVisibility.NativeMethodInfoPtr_UpdateVisibility_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, 100665847);
		VolumetricBeamVisibility.NativeMethodInfoPtr_SetBeamLength_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, 100665848);
		VolumetricBeamVisibility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr, 100665849);
	}

	// Token: 0x06002183 RID: 8579 RVA: 0x0000210C File Offset: 0x0000030C
	public VolumetricBeamVisibility(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000BCF RID: 3023
	// (get) Token: 0x06002184 RID: 8580 RVA: 0x00083CF8 File Offset: 0x00081EF8
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VolumetricBeamVisibility>.NativeClassPtr));
		}
	}

	// Token: 0x17000BD0 RID: 3024
	// (get) Token: 0x06002185 RID: 8581 RVA: 0x00083D0C File Offset: 0x00081F0C
	// (set) Token: 0x06002186 RID: 8582 RVA: 0x00083D40 File Offset: 0x00081F40
	public unsafe Transform Base
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr_Base);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr_Base), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000BD1 RID: 3025
	// (get) Token: 0x06002187 RID: 8583 RVA: 0x00083D68 File Offset: 0x00081F68
	// (set) Token: 0x06002188 RID: 8584 RVA: 0x00083D9C File Offset: 0x00081F9C
	public unsafe Transform Tip
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr_Tip);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr_Tip), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000BD2 RID: 3026
	// (get) Token: 0x06002189 RID: 8585 RVA: 0x00083DC4 File Offset: 0x00081FC4
	// (set) Token: 0x0600218A RID: 8586 RVA: 0x00083DF8 File Offset: 0x00081FF8
	public unsafe Renderer Renderer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr_Renderer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Renderer(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000BD3 RID: 3027
	// (get) Token: 0x0600218B RID: 8587 RVA: 0x00083E20 File Offset: 0x00082020
	// (set) Token: 0x0600218C RID: 8588 RVA: 0x00083E48 File Offset: 0x00082048
	public unsafe LayerMask ClippingMask
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr_ClippingMask);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr_ClippingMask)) = value;
		}
	}

	// Token: 0x17000BD4 RID: 3028
	// (get) Token: 0x0600218D RID: 8589 RVA: 0x00083E6C File Offset: 0x0008206C
	// (set) Token: 0x0600218E RID: 8590 RVA: 0x00083E94 File Offset: 0x00082094
	public unsafe int FrameCounter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr_FrameCounter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr_FrameCounter)) = value;
		}
	}

	// Token: 0x17000BD5 RID: 3029
	// (get) Token: 0x0600218F RID: 8591 RVA: 0x00083EB8 File Offset: 0x000820B8
	// (set) Token: 0x06002190 RID: 8592 RVA: 0x00083EE0 File Offset: 0x000820E0
	public unsafe bool IsClipping
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr_IsClipping);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr_IsClipping)) = value;
		}
	}

	// Token: 0x17000BD6 RID: 3030
	// (get) Token: 0x06002191 RID: 8593 RVA: 0x00083F04 File Offset: 0x00082104
	// (set) Token: 0x06002192 RID: 8594 RVA: 0x00083F2C File Offset: 0x0008212C
	public unsafe bool _ManagedLateUpdateRemoval_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricBeamVisibility.NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField)) = value;
		}
	}

	// Token: 0x04001514 RID: 5396
	private static readonly IntPtr NativeFieldInfoPtr_Base;

	// Token: 0x04001515 RID: 5397
	private static readonly IntPtr NativeFieldInfoPtr_Tip;

	// Token: 0x04001516 RID: 5398
	private static readonly IntPtr NativeFieldInfoPtr_Renderer;

	// Token: 0x04001517 RID: 5399
	private static readonly IntPtr NativeFieldInfoPtr_ClippingMask;

	// Token: 0x04001518 RID: 5400
	private static readonly IntPtr NativeFieldInfoPtr_FrameCounter;

	// Token: 0x04001519 RID: 5401
	private static readonly IntPtr NativeFieldInfoPtr_IsClipping;

	// Token: 0x0400151A RID: 5402
	private static readonly IntPtr NativeFieldInfoPtr__ManagedLateUpdateRemoval_k__BackingField;

	// Token: 0x0400151B RID: 5403
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

	// Token: 0x0400151C RID: 5404
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;

	// Token: 0x0400151D RID: 5405
	private static readonly IntPtr NativeMethodInfoPtr_get_ManagedLateUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x0400151E RID: 5406
	private static readonly IntPtr NativeMethodInfoPtr_set_ManagedLateUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0;

	// Token: 0x0400151F RID: 5407
	private static readonly IntPtr NativeMethodInfoPtr_OnManagedLateUpdate_Public_Virtual_Final_New_Void_0;

	// Token: 0x04001520 RID: 5408
	private static readonly IntPtr NativeMethodInfoPtr_GetFrameTimeDelay_Protected_Int32_0;

	// Token: 0x04001521 RID: 5409
	private static readonly IntPtr NativeMethodInfoPtr_UpdateVisibility_Protected_Void_0;

	// Token: 0x04001522 RID: 5410
	private static readonly IntPtr NativeMethodInfoPtr_SetBeamLength_Protected_Void_Single_0;

	// Token: 0x04001523 RID: 5411
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
