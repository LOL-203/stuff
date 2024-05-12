using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020004EC RID: 1260
public class BallisticsFinal : MonoBehaviour
{
	// Token: 0x17002439 RID: 9273
	// (get) Token: 0x06006616 RID: 26134 RVA: 0x0019A624 File Offset: 0x00198824
	public unsafe float InitVelocity
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BallisticsFinal.NativeMethodInfoPtr_get_InitVelocity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x06006617 RID: 26135 RVA: 0x0019A674 File Offset: 0x00198874
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BallisticsFinal.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006618 RID: 26136 RVA: 0x0019A6B8 File Offset: 0x001988B8
	[CallerCount(0)]
	public unsafe void ResetVelocity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BallisticsFinal.NativeMethodInfoPtr_ResetVelocity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006619 RID: 26137 RVA: 0x0019A6FC File Offset: 0x001988FC
	[CallerCount(0)]
	public unsafe void UpdateVelocity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BallisticsFinal.NativeMethodInfoPtr_UpdateVelocity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600661A RID: 26138 RVA: 0x0019A740 File Offset: 0x00198940
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BallisticsFinal.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600661B RID: 26139 RVA: 0x0019A784 File Offset: 0x00198984
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BallisticsFinal.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x1700243A RID: 9274
	// (get) Token: 0x0600661C RID: 26140 RVA: 0x0019A7C8 File Offset: 0x001989C8
	// (set) Token: 0x0600661D RID: 26141 RVA: 0x0019A818 File Offset: 0x00198A18
	public unsafe bool ManagedUpdateRemoval
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BallisticsFinal.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BallisticsFinal.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}
	}

	// Token: 0x0600661E RID: 26142 RVA: 0x0019A86C File Offset: 0x00198A6C
	[CallerCount(0)]
	public unsafe void OnManagedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BallisticsFinal.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600661F RID: 26143 RVA: 0x0019A8B0 File Offset: 0x00198AB0
	[CallerCount(0)]
	public unsafe void OnIntegrateBallistics(float delta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref delta;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BallisticsFinal.NativeMethodInfoPtr_OnIntegrateBallistics_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006620 RID: 26144 RVA: 0x0019A904 File Offset: 0x00198B04
	[CallerCount(0)]
	public unsafe BallisticsFinal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BallisticsFinal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006621 RID: 26145 RVA: 0x0019A950 File Offset: 0x00198B50
	// Note: this type is marked as 'beforefieldinit'.
	static BallisticsFinal()
	{
		Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BallisticsFinal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr);
		BallisticsFinal.NativeFieldInfoPtr_AirResistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, "AirResistance");
		BallisticsFinal.NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, "Gravity");
		BallisticsFinal.NativeFieldInfoPtr_OriginalVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, "OriginalVelocity");
		BallisticsFinal.NativeFieldInfoPtr_currentPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, "currentPos");
		BallisticsFinal.NativeFieldInfoPtr_previousPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, "previousPos");
		BallisticsFinal.NativeFieldInfoPtr_CurrentVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, "CurrentVelocity");
		BallisticsFinal.NativeFieldInfoPtr_accumulator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, "accumulator");
		BallisticsFinal.NativeFieldInfoPtr_t2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, "t2");
		BallisticsFinal.NativeFieldInfoPtr_m_initVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, "m_initVelocity");
		BallisticsFinal.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, "<ManagedUpdateRemoval>k__BackingField");
		BallisticsFinal.NativeMethodInfoPtr_get_InitVelocity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, 100671427);
		BallisticsFinal.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, 100671428);
		BallisticsFinal.NativeMethodInfoPtr_ResetVelocity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, 100671429);
		BallisticsFinal.NativeMethodInfoPtr_UpdateVelocity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, 100671430);
		BallisticsFinal.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, 100671431);
		BallisticsFinal.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, 100671432);
		BallisticsFinal.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, 100671433);
		BallisticsFinal.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, 100671434);
		BallisticsFinal.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, 100671435);
		BallisticsFinal.NativeMethodInfoPtr_OnIntegrateBallistics_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, 100671436);
		BallisticsFinal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr, 100671437);
	}

	// Token: 0x06006622 RID: 26146 RVA: 0x0000210C File Offset: 0x0000030C
	public BallisticsFinal(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700242E RID: 9262
	// (get) Token: 0x06006623 RID: 26147 RVA: 0x0019AB24 File Offset: 0x00198D24
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BallisticsFinal>.NativeClassPtr));
		}
	}

	// Token: 0x1700242F RID: 9263
	// (get) Token: 0x06006624 RID: 26148 RVA: 0x0019AB38 File Offset: 0x00198D38
	// (set) Token: 0x06006625 RID: 26149 RVA: 0x0019AB56 File Offset: 0x00198D56
	public unsafe static float AirResistance
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(BallisticsFinal.NativeFieldInfoPtr_AirResistance, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BallisticsFinal.NativeFieldInfoPtr_AirResistance, (void*)(&value));
		}
	}

	// Token: 0x17002430 RID: 9264
	// (get) Token: 0x06006626 RID: 26150 RVA: 0x0019AB68 File Offset: 0x00198D68
	// (set) Token: 0x06006627 RID: 26151 RVA: 0x0019AB90 File Offset: 0x00198D90
	public unsafe float Gravity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_Gravity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_Gravity)) = value;
		}
	}

	// Token: 0x17002431 RID: 9265
	// (get) Token: 0x06006628 RID: 26152 RVA: 0x0019ABB4 File Offset: 0x00198DB4
	// (set) Token: 0x06006629 RID: 26153 RVA: 0x0019ABDC File Offset: 0x00198DDC
	public unsafe float OriginalVelocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_OriginalVelocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_OriginalVelocity)) = value;
		}
	}

	// Token: 0x17002432 RID: 9266
	// (get) Token: 0x0600662A RID: 26154 RVA: 0x0019AC00 File Offset: 0x00198E00
	// (set) Token: 0x0600662B RID: 26155 RVA: 0x0019AC28 File Offset: 0x00198E28
	public unsafe Vector3 currentPos
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_currentPos);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_currentPos)) = value;
		}
	}

	// Token: 0x17002433 RID: 9267
	// (get) Token: 0x0600662C RID: 26156 RVA: 0x0019AC4C File Offset: 0x00198E4C
	// (set) Token: 0x0600662D RID: 26157 RVA: 0x0019AC74 File Offset: 0x00198E74
	public unsafe Vector3 previousPos
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_previousPos);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_previousPos)) = value;
		}
	}

	// Token: 0x17002434 RID: 9268
	// (get) Token: 0x0600662E RID: 26158 RVA: 0x0019AC98 File Offset: 0x00198E98
	// (set) Token: 0x0600662F RID: 26159 RVA: 0x0019ACC0 File Offset: 0x00198EC0
	public unsafe Vector3 CurrentVelocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_CurrentVelocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_CurrentVelocity)) = value;
		}
	}

	// Token: 0x17002435 RID: 9269
	// (get) Token: 0x06006630 RID: 26160 RVA: 0x0019ACE4 File Offset: 0x00198EE4
	// (set) Token: 0x06006631 RID: 26161 RVA: 0x0019AD0C File Offset: 0x00198F0C
	public unsafe float accumulator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_accumulator);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_accumulator)) = value;
		}
	}

	// Token: 0x17002436 RID: 9270
	// (get) Token: 0x06006632 RID: 26162 RVA: 0x0019AD30 File Offset: 0x00198F30
	// (set) Token: 0x06006633 RID: 26163 RVA: 0x0019AD58 File Offset: 0x00198F58
	public unsafe float t2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_t2);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_t2)) = value;
		}
	}

	// Token: 0x17002437 RID: 9271
	// (get) Token: 0x06006634 RID: 26164 RVA: 0x0019AD7C File Offset: 0x00198F7C
	// (set) Token: 0x06006635 RID: 26165 RVA: 0x0019ADA4 File Offset: 0x00198FA4
	public unsafe float m_initVelocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_m_initVelocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr_m_initVelocity)) = value;
		}
	}

	// Token: 0x17002438 RID: 9272
	// (get) Token: 0x06006636 RID: 26166 RVA: 0x0019ADC8 File Offset: 0x00198FC8
	// (set) Token: 0x06006637 RID: 26167 RVA: 0x0019ADF0 File Offset: 0x00198FF0
	public unsafe bool _ManagedUpdateRemoval_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BallisticsFinal.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField)) = value;
		}
	}

	// Token: 0x0400407D RID: 16509
	private static readonly IntPtr NativeFieldInfoPtr_AirResistance;

	// Token: 0x0400407E RID: 16510
	private static readonly IntPtr NativeFieldInfoPtr_Gravity;

	// Token: 0x0400407F RID: 16511
	private static readonly IntPtr NativeFieldInfoPtr_OriginalVelocity;

	// Token: 0x04004080 RID: 16512
	private static readonly IntPtr NativeFieldInfoPtr_currentPos;

	// Token: 0x04004081 RID: 16513
	private static readonly IntPtr NativeFieldInfoPtr_previousPos;

	// Token: 0x04004082 RID: 16514
	private static readonly IntPtr NativeFieldInfoPtr_CurrentVelocity;

	// Token: 0x04004083 RID: 16515
	private static readonly IntPtr NativeFieldInfoPtr_accumulator;

	// Token: 0x04004084 RID: 16516
	private static readonly IntPtr NativeFieldInfoPtr_t2;

	// Token: 0x04004085 RID: 16517
	private static readonly IntPtr NativeFieldInfoPtr_m_initVelocity;

	// Token: 0x04004086 RID: 16518
	private static readonly IntPtr NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField;

	// Token: 0x04004087 RID: 16519
	private static readonly IntPtr NativeMethodInfoPtr_get_InitVelocity_Public_get_Single_0;

	// Token: 0x04004088 RID: 16520
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04004089 RID: 16521
	private static readonly IntPtr NativeMethodInfoPtr_ResetVelocity_Public_Void_0;

	// Token: 0x0400408A RID: 16522
	private static readonly IntPtr NativeMethodInfoPtr_UpdateVelocity_Public_Void_0;

	// Token: 0x0400408B RID: 16523
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x0400408C RID: 16524
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x0400408D RID: 16525
	private static readonly IntPtr NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x0400408E RID: 16526
	private static readonly IntPtr NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0;

	// Token: 0x0400408F RID: 16527
	private static readonly IntPtr NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0;

	// Token: 0x04004090 RID: 16528
	private static readonly IntPtr NativeMethodInfoPtr_OnIntegrateBallistics_Private_Void_Single_0;

	// Token: 0x04004091 RID: 16529
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
