using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Onward;
using Onward.AddressableTools;
using Onward.Rendering;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200051A RID: 1306
public class WeaponAttachment : MonoBehaviour
{
	// Token: 0x06006B15 RID: 27413 RVA: 0x001AE55C File Offset: 0x001AC75C
	[CallerCount(0)]
	public unsafe static bool IsASight(WeaponAttachment.AttachmentType type)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref type;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment.NativeMethodInfoPtr_IsASight_Public_Static_Boolean_AttachmentType_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x1700261D RID: 9757
	// (get) Token: 0x06006B16 RID: 27414 RVA: 0x001AE5B0 File Offset: 0x001AC7B0
	public unsafe WeaponAttachment.AttachmentType Type
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment.NativeMethodInfoPtr_get_Type_Public_get_AttachmentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x06006B17 RID: 27415 RVA: 0x001AE600 File Offset: 0x001AC800
	[CallerCount(0)]
	public unsafe void SetState(WeaponAttachmentToggleState toggleState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref toggleState;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment.NativeMethodInfoPtr_SetState_Public_Void_WeaponAttachmentToggleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B18 RID: 27416 RVA: 0x001AE654 File Offset: 0x001AC854
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B19 RID: 27417 RVA: 0x001AE698 File Offset: 0x001AC898
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B1A RID: 27418 RVA: 0x001AE6DC File Offset: 0x001AC8DC
	[CallerCount(0)]
	public unsafe void Initialize(Pickup_Gun gun)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gun);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponAttachment.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Pickup_Gun_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B1B RID: 27419 RVA: 0x001AE740 File Offset: 0x001AC940
	[CallerCount(0)]
	public unsafe void Uninitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponAttachment.NativeMethodInfoPtr_Uninitialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B1C RID: 27420 RVA: 0x001AE790 File Offset: 0x001AC990
	[CallerCount(0)]
	public unsafe void OnEffectsContextChanged(Pickup.EffectsContext effectsContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref effectsContext;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponAttachment.NativeMethodInfoPtr_OnEffectsContextChanged_Protected_Virtual_New_Void_EffectsContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B1D RID: 27421 RVA: 0x001AE7F0 File Offset: 0x001AC9F0
	[CallerCount(0)]
	public unsafe void ToggleInteractions(bool enableInteractions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref enableInteractions;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment.NativeMethodInfoPtr_ToggleInteractions_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B1E RID: 27422 RVA: 0x001AE844 File Offset: 0x001ACA44
	[CallerCount(0)]
	public unsafe void Reinitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment.NativeMethodInfoPtr_Reinitialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B1F RID: 27423 RVA: 0x001AE888 File Offset: 0x001ACA88
	[CallerCount(0)]
	public unsafe void Deinitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment.NativeMethodInfoPtr_Deinitialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B20 RID: 27424 RVA: 0x001AE8CC File Offset: 0x001ACACC
	[CallerCount(0)]
	public unsafe void SightDeinitializeJank()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment.NativeMethodInfoPtr_SightDeinitializeJank_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B21 RID: 27425 RVA: 0x001AE910 File Offset: 0x001ACB10
	[CallerCount(0)]
	public unsafe void UpdateShadows(Pickup.EffectsContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref context;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment.NativeMethodInfoPtr_UpdateShadows_Protected_Void_EffectsContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B22 RID: 27426 RVA: 0x001AE964 File Offset: 0x001ACB64
	[CallerCount(0)]
	public unsafe void UpdateToggleObjects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponAttachment.NativeMethodInfoPtr_UpdateToggleObjects_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B23 RID: 27427 RVA: 0x001AE9B4 File Offset: 0x001ACBB4
	[CallerCount(0)]
	public unsafe void ConfigureToggleObjects(WeaponAttachmentToggleState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref state;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeaponAttachment.NativeMethodInfoPtr_ConfigureToggleObjects_Protected_Virtual_New_Void_WeaponAttachmentToggleState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B24 RID: 27428 RVA: 0x001AEA14 File Offset: 0x001ACC14
	[CallerCount(0)]
	public unsafe WeaponAttachment() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeaponAttachment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006B25 RID: 27429 RVA: 0x001AEA60 File Offset: 0x001ACC60
	// Note: this type is marked as 'beforefieldinit'.
	static WeaponAttachment()
	{
		Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WeaponAttachment");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr);
		WeaponAttachment.NativeFieldInfoPtr_AttachmentSO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, "AttachmentSO");
		WeaponAttachment.NativeFieldInfoPtr_ToggleObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, "ToggleObjects");
		WeaponAttachment.NativeFieldInfoPtr_EnableWhenOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, "EnableWhenOn");
		WeaponAttachment.NativeFieldInfoPtr_DisabledWhenOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, "DisabledWhenOn");
		WeaponAttachment.NativeFieldInfoPtr_Interactables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, "Interactables");
		WeaponAttachment.NativeFieldInfoPtr_m_gun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, "m_gun");
		WeaponAttachment.NativeFieldInfoPtr_Loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, "Loader");
		WeaponAttachment.NativeFieldInfoPtr_OnGunAssigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, "OnGunAssigned");
		WeaponAttachment.NativeFieldInfoPtr_ShadowToggler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, "ShadowToggler");
		WeaponAttachment.NativeFieldInfoPtr_ToggleState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, "ToggleState");
		WeaponAttachment.NativeFieldInfoPtr__onlyActiveWithNightVision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, "_onlyActiveWithNightVision");
		WeaponAttachment.NativeMethodInfoPtr_IsASight_Public_Static_Boolean_AttachmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671805);
		WeaponAttachment.NativeMethodInfoPtr_get_Type_Public_get_AttachmentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671806);
		WeaponAttachment.NativeMethodInfoPtr_SetState_Public_Void_WeaponAttachmentToggleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671807);
		WeaponAttachment.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671808);
		WeaponAttachment.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671809);
		WeaponAttachment.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Pickup_Gun_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671810);
		WeaponAttachment.NativeMethodInfoPtr_Uninitialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671811);
		WeaponAttachment.NativeMethodInfoPtr_OnEffectsContextChanged_Protected_Virtual_New_Void_EffectsContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671812);
		WeaponAttachment.NativeMethodInfoPtr_ToggleInteractions_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671813);
		WeaponAttachment.NativeMethodInfoPtr_Reinitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671814);
		WeaponAttachment.NativeMethodInfoPtr_Deinitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671815);
		WeaponAttachment.NativeMethodInfoPtr_SightDeinitializeJank_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671816);
		WeaponAttachment.NativeMethodInfoPtr_UpdateShadows_Protected_Void_EffectsContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671817);
		WeaponAttachment.NativeMethodInfoPtr_UpdateToggleObjects_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671818);
		WeaponAttachment.NativeMethodInfoPtr_ConfigureToggleObjects_Protected_Virtual_New_Void_WeaponAttachmentToggleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671819);
		WeaponAttachment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr, 100671820);
	}

	// Token: 0x06006B26 RID: 27430 RVA: 0x0000210C File Offset: 0x0000030C
	public WeaponAttachment(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17002611 RID: 9745
	// (get) Token: 0x06006B27 RID: 27431 RVA: 0x001AECAC File Offset: 0x001ACEAC
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WeaponAttachment>.NativeClassPtr));
		}
	}

	// Token: 0x17002612 RID: 9746
	// (get) Token: 0x06006B28 RID: 27432 RVA: 0x001AECC0 File Offset: 0x001ACEC0
	// (set) Token: 0x06006B29 RID: 27433 RVA: 0x001AECF4 File Offset: 0x001ACEF4
	public unsafe AttachmentSO AttachmentSO
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_AttachmentSO);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AttachmentSO(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_AttachmentSO), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002613 RID: 9747
	// (get) Token: 0x06006B2A RID: 27434 RVA: 0x001AED1C File Offset: 0x001ACF1C
	// (set) Token: 0x06006B2B RID: 27435 RVA: 0x001AED50 File Offset: 0x001ACF50
	public unsafe Il2CppReferenceArray<GameObject> ToggleObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_ToggleObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_ToggleObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002614 RID: 9748
	// (get) Token: 0x06006B2C RID: 27436 RVA: 0x001AED78 File Offset: 0x001ACF78
	// (set) Token: 0x06006B2D RID: 27437 RVA: 0x001AEDAC File Offset: 0x001ACFAC
	public unsafe Il2CppReferenceArray<GameObject> EnableWhenOn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_EnableWhenOn);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_EnableWhenOn), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002615 RID: 9749
	// (get) Token: 0x06006B2E RID: 27438 RVA: 0x001AEDD4 File Offset: 0x001ACFD4
	// (set) Token: 0x06006B2F RID: 27439 RVA: 0x001AEE08 File Offset: 0x001AD008
	public unsafe Il2CppReferenceArray<GameObject> DisabledWhenOn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_DisabledWhenOn);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_DisabledWhenOn), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002616 RID: 9750
	// (get) Token: 0x06006B30 RID: 27440 RVA: 0x001AEE30 File Offset: 0x001AD030
	// (set) Token: 0x06006B31 RID: 27441 RVA: 0x001AEE64 File Offset: 0x001AD064
	public unsafe List<Interactable> Interactables
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_Interactables);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new List<Interactable>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_Interactables), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002617 RID: 9751
	// (get) Token: 0x06006B32 RID: 27442 RVA: 0x001AEE8C File Offset: 0x001AD08C
	// (set) Token: 0x06006B33 RID: 27443 RVA: 0x001AEEC0 File Offset: 0x001AD0C0
	public unsafe Pickup_Gun m_gun
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_m_gun);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Pickup_Gun(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_m_gun), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002618 RID: 9752
	// (get) Token: 0x06006B34 RID: 27444 RVA: 0x001AEEE8 File Offset: 0x001AD0E8
	// (set) Token: 0x06006B35 RID: 27445 RVA: 0x001AEF1C File Offset: 0x001AD11C
	public unsafe VisualLoader Loader
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_Loader);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new VisualLoader(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_Loader), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17002619 RID: 9753
	// (get) Token: 0x06006B36 RID: 27446 RVA: 0x001AEF44 File Offset: 0x001AD144
	// (set) Token: 0x06006B37 RID: 27447 RVA: 0x001AEF78 File Offset: 0x001AD178
	public unsafe Action OnGunAssigned
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_OnGunAssigned);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Action(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_OnGunAssigned), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700261A RID: 9754
	// (get) Token: 0x06006B38 RID: 27448 RVA: 0x001AEFA0 File Offset: 0x001AD1A0
	// (set) Token: 0x06006B39 RID: 27449 RVA: 0x001AEFD4 File Offset: 0x001AD1D4
	public unsafe ShadowToggler ShadowToggler
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_ShadowToggler);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new ShadowToggler(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_ShadowToggler), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700261B RID: 9755
	// (get) Token: 0x06006B3A RID: 27450 RVA: 0x001AEFFC File Offset: 0x001AD1FC
	// (set) Token: 0x06006B3B RID: 27451 RVA: 0x001AF024 File Offset: 0x001AD224
	public unsafe WeaponAttachmentToggleState ToggleState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_ToggleState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr_ToggleState)) = value;
		}
	}

	// Token: 0x1700261C RID: 9756
	// (get) Token: 0x06006B3C RID: 27452 RVA: 0x001AF048 File Offset: 0x001AD248
	// (set) Token: 0x06006B3D RID: 27453 RVA: 0x001AF070 File Offset: 0x001AD270
	public unsafe bool _onlyActiveWithNightVision
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr__onlyActiveWithNightVision);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeaponAttachment.NativeFieldInfoPtr__onlyActiveWithNightVision)) = value;
		}
	}

	// Token: 0x040043CC RID: 17356
	private static readonly IntPtr NativeFieldInfoPtr_AttachmentSO;

	// Token: 0x040043CD RID: 17357
	private static readonly IntPtr NativeFieldInfoPtr_ToggleObjects;

	// Token: 0x040043CE RID: 17358
	private static readonly IntPtr NativeFieldInfoPtr_EnableWhenOn;

	// Token: 0x040043CF RID: 17359
	private static readonly IntPtr NativeFieldInfoPtr_DisabledWhenOn;

	// Token: 0x040043D0 RID: 17360
	private static readonly IntPtr NativeFieldInfoPtr_Interactables;

	// Token: 0x040043D1 RID: 17361
	private static readonly IntPtr NativeFieldInfoPtr_m_gun;

	// Token: 0x040043D2 RID: 17362
	private static readonly IntPtr NativeFieldInfoPtr_Loader;

	// Token: 0x040043D3 RID: 17363
	private static readonly IntPtr NativeFieldInfoPtr_OnGunAssigned;

	// Token: 0x040043D4 RID: 17364
	private static readonly IntPtr NativeFieldInfoPtr_ShadowToggler;

	// Token: 0x040043D5 RID: 17365
	private static readonly IntPtr NativeFieldInfoPtr_ToggleState;

	// Token: 0x040043D6 RID: 17366
	private static readonly IntPtr NativeFieldInfoPtr__onlyActiveWithNightVision;

	// Token: 0x040043D7 RID: 17367
	private static readonly IntPtr NativeMethodInfoPtr_IsASight_Public_Static_Boolean_AttachmentType_0;

	// Token: 0x040043D8 RID: 17368
	private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_AttachmentType_0;

	// Token: 0x040043D9 RID: 17369
	private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Void_WeaponAttachmentToggleState_0;

	// Token: 0x040043DA RID: 17370
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x040043DB RID: 17371
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x040043DC RID: 17372
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Pickup_Gun_0;

	// Token: 0x040043DD RID: 17373
	private static readonly IntPtr NativeMethodInfoPtr_Uninitialize_Public_Virtual_New_Void_0;

	// Token: 0x040043DE RID: 17374
	private static readonly IntPtr NativeMethodInfoPtr_OnEffectsContextChanged_Protected_Virtual_New_Void_EffectsContext_0;

	// Token: 0x040043DF RID: 17375
	private static readonly IntPtr NativeMethodInfoPtr_ToggleInteractions_Public_Void_Boolean_0;

	// Token: 0x040043E0 RID: 17376
	private static readonly IntPtr NativeMethodInfoPtr_Reinitialize_Public_Void_0;

	// Token: 0x040043E1 RID: 17377
	private static readonly IntPtr NativeMethodInfoPtr_Deinitialize_Public_Void_0;

	// Token: 0x040043E2 RID: 17378
	private static readonly IntPtr NativeMethodInfoPtr_SightDeinitializeJank_Protected_Void_0;

	// Token: 0x040043E3 RID: 17379
	private static readonly IntPtr NativeMethodInfoPtr_UpdateShadows_Protected_Void_EffectsContext_0;

	// Token: 0x040043E4 RID: 17380
	private static readonly IntPtr NativeMethodInfoPtr_UpdateToggleObjects_Protected_Virtual_New_Void_0;

	// Token: 0x040043E5 RID: 17381
	private static readonly IntPtr NativeMethodInfoPtr_ConfigureToggleObjects_Protected_Virtual_New_Void_WeaponAttachmentToggleState_0;

	// Token: 0x040043E6 RID: 17382
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200051B RID: 1307
	public enum AttachmentType
	{
		// Token: 0x040043E8 RID: 17384
		NULL,
		// Token: 0x040043E9 RID: 17385
		SightIron,
		// Token: 0x040043EA RID: 17386
		SightRedDot,
		// Token: 0x040043EB RID: 17387
		SightHolo,
		// Token: 0x040043EC RID: 17388
		SightScope4x,
		// Token: 0x040043ED RID: 17389
		SightScope12x,
		// Token: 0x040043EE RID: 17390
		SightRedDot_2,
		// Token: 0x040043EF RID: 17391
		AngledSightRight,
		// Token: 0x040043F0 RID: 17392
		AngledSightLeft,
		// Token: 0x040043F1 RID: 17393
		Suppressor = 10,
		// Token: 0x040043F2 RID: 17394
		Flashlight,
		// Token: 0x040043F3 RID: 17395
		Foregrip,
		// Token: 0x040043F4 RID: 17396
		Laser,
		// Token: 0x040043F5 RID: 17397
		Bipod,
		// Token: 0x040043F6 RID: 17398
		GrenadeLauncherFrag,
		// Token: 0x040043F7 RID: 17399
		GrenadeLauncherSmoke,
		// Token: 0x040043F8 RID: 17400
		SightHolo2x,
		// Token: 0x040043F9 RID: 17401
		Rail = 19,
		// Token: 0x040043FA RID: 17402
		RailLarge,
		// Token: 0x040043FB RID: 17403
		RailSmall,
		// Token: 0x040043FC RID: 17404
		RailPicatinnyFlat,
		// Token: 0x040043FD RID: 17405
		RailPicatinnyRaised,
		// Token: 0x040043FE RID: 17406
		RailPKM,
		// Token: 0x040043FF RID: 17407
		RailFAMAS,
		// Token: 0x04004400 RID: 17408
		RailM39,
		// Token: 0x04004401 RID: 17409
		RailSV98,
		// Token: 0x04004402 RID: 17410
		Laser_IR = 30,
		// Token: 0x04004403 RID: 17411
		Flashlight_IR
	}

	// Token: 0x0200051C RID: 1308
	public enum AttachmentVariantType
	{
		// Token: 0x04004405 RID: 17413
		X4_ACOG,
		// Token: 0x04004406 RID: 17414
		X12_akm,
		// Token: 0x04004407 RID: 17415
		Bipod,
		// Token: 0x04004408 RID: 17416
		FamasRails,
		// Token: 0x04004409 RID: 17417
		Flashlight,
		// Token: 0x0400440A RID: 17418
		Flashlight_V1,
		// Token: 0x0400440B RID: 17419
		Flashlight_V2,
		// Token: 0x0400440C RID: 17420
		Iron_AUG_Down,
		// Token: 0x0400440D RID: 17421
		Iron_AUG_Up,
		// Token: 0x0400440E RID: 17422
		Iron_mk16,
		// Token: 0x0400440F RID: 17423
		Iron_mk17,
		// Token: 0x04004410 RID: 17424
		Iron_mk18,
		// Token: 0x04004411 RID: 17425
		Iron_I86,
		// Token: 0x04004412 RID: 17426
		Iron_m40,
		// Token: 0x04004413 RID: 17427
		Rail_Famas,
		// Token: 0x04004414 RID: 17428
		Iron_tar,
		// Token: 0x04004415 RID: 17429
		Foregrip_angled,
		// Token: 0x04004416 RID: 17430
		Foregrip_vertical,
		// Token: 0x04004417 RID: 17431
		Foregrip_volk,
		// Token: 0x04004418 RID: 17432
		GrenadeLauncher,
		// Token: 0x04004419 RID: 17433
		Iron_m16,
		// Token: 0x0400441A RID: 17434
		Iron_p90,
		// Token: 0x0400441B RID: 17435
		Laser_small,
		// Token: 0x0400441C RID: 17436
		Laser_large,
		// Token: 0x0400441D RID: 17437
		Sup_pbs1,
		// Token: 0x0400441E RID: 17438
		Sup_pistol,
		// Token: 0x0400441F RID: 17439
		Sup_m40,
		// Token: 0x04004420 RID: 17440
		Sup_mp5,
		// Token: 0x04004421 RID: 17441
		Sup_sv98,
		// Token: 0x04004422 RID: 17442
		Sup,
		// Token: 0x04004423 RID: 17443
		Sup_volk,
		// Token: 0x04004424 RID: 17444
		Sup_mk18,
		// Token: 0x04004425 RID: 17445
		Angled_left_mrd,
		// Token: 0x04004426 RID: 17446
		Angled_right_mrd,
		// Token: 0x04004427 RID: 17447
		Angled_left_pk,
		// Token: 0x04004428 RID: 17448
		Angled_right_pk,
		// Token: 0x04004429 RID: 17449
		Flashlight_pistol,
		// Token: 0x0400442A RID: 17450
		Laser_pistol,
		// Token: 0x0400442B RID: 17451
		RedDot_pistol,
		// Token: 0x0400442C RID: 17452
		RedDot_pistol_1,
		// Token: 0x0400442D RID: 17453
		Holo_pk_120,
		// Token: 0x0400442E RID: 17454
		X12,
		// Token: 0x0400442F RID: 17455
		X12_m40,
		// Token: 0x04004430 RID: 17456
		X12_svd,
		// Token: 0x04004431 RID: 17457
		RedDot_aimpoint,
		// Token: 0x04004432 RID: 17458
		RedDot_kobra,
		// Token: 0x04004433 RID: 17459
		RedDot_kobra_v1,
		// Token: 0x04004434 RID: 17460
		Holo,
		// Token: 0x04004435 RID: 17461
		Holo_new,
		// Token: 0x04004436 RID: 17462
		Holo_volk,
		// Token: 0x04004437 RID: 17463
		RedDot,
		// Token: 0x04004438 RID: 17464
		X4_Volk,
		// Token: 0x04004439 RID: 17465
		X12_Volk,
		// Token: 0x0400443A RID: 17466
		RedDot_pk,
		// Token: 0x0400443B RID: 17467
		FlipUp_G33,
		// Token: 0x0400443C RID: 17468
		FlipUp_ZT310,
		// Token: 0x0400443D RID: 17469
		None,
		// Token: 0x0400443E RID: 17470
		SmokeGrenadeLauncher,
		// Token: 0x0400443F RID: 17471
		Iron_SV98,
		// Token: 0x04004440 RID: 17472
		Rail,
		// Token: 0x04004441 RID: 17473
		RailLarge,
		// Token: 0x04004442 RID: 17474
		Sup_val,
		// Token: 0x04004443 RID: 17475
		RailSmall,
		// Token: 0x04004444 RID: 17476
		RailPicatinnyFlat,
		// Token: 0x04004445 RID: 17477
		RailPicatinnyRaised,
		// Token: 0x04004446 RID: 17478
		RailPKM,
		// Token: 0x04004447 RID: 17479
		RailFAMAS,
		// Token: 0x04004448 RID: 17480
		RailM39,
		// Token: 0x04004449 RID: 17481
		RailSV98,
		// Token: 0x0400444A RID: 17482
		Iron_AK104,
		// Token: 0x0400444B RID: 17483
		Iron_MCXVirtus,
		// Token: 0x0400444C RID: 17484
		Iron_MP7A2,
		// Token: 0x0400444D RID: 17485
		Sup_MP7A2,
		// Token: 0x0400444E RID: 17486
		Sup_SR2MPVeresk,
		// Token: 0x0400444F RID: 17487
		Bipod_M240,
		// Token: 0x04004450 RID: 17488
		Foregrip_M240,
		// Token: 0x04004451 RID: 17489
		Bipod_Ultimax,
		// Token: 0x04004452 RID: 17490
		Iron_M240,
		// Token: 0x04004453 RID: 17491
		Laser_small_ir,
		// Token: 0x04004454 RID: 17492
		Laser_large_ir,
		// Token: 0x04004455 RID: 17493
		Laser_pistol_ir,
		// Token: 0x04004456 RID: 17494
		Flashlight_ir,
		// Token: 0x04004457 RID: 17495
		Flashlight_V1_ir,
		// Token: 0x04004458 RID: 17496
		Flashlight_V2_ir,
		// Token: 0x04004459 RID: 17497
		Flashlight_pistol_ir
	}
}
