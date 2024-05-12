using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200006D RID: 109
public class AugmentedObject : MonoBehaviour
{
	// Token: 0x0600066A RID: 1642 RVA: 0x0001BEB0 File Offset: 0x0001A0B0
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AugmentedObject.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600066B RID: 1643 RVA: 0x0001BEF4 File Offset: 0x0001A0F4
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AugmentedObject.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600066C RID: 1644 RVA: 0x0001BF38 File Offset: 0x0001A138
	[CallerCount(0)]
	public unsafe void Grab(OVRInput.Controller grabHand)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref grabHand;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AugmentedObject.NativeMethodInfoPtr_Grab_Public_Void_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600066D RID: 1645 RVA: 0x0001BF8C File Offset: 0x0001A18C
	[CallerCount(0)]
	public unsafe void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AugmentedObject.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600066E RID: 1646 RVA: 0x0001BFD0 File Offset: 0x0001A1D0
	[CallerCount(0)]
	public unsafe void ToggleShadowType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AugmentedObject.NativeMethodInfoPtr_ToggleShadowType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x0001C014 File Offset: 0x0001A214
	[CallerCount(0)]
	public unsafe AugmentedObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AugmentedObject>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AugmentedObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06000670 RID: 1648 RVA: 0x0001C060 File Offset: 0x0001A260
	// Note: this type is marked as 'beforefieldinit'.
	static AugmentedObject()
	{
		Il2CppClassPointerStore<AugmentedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AugmentedObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AugmentedObject>.NativeClassPtr);
		AugmentedObject.NativeFieldInfoPtr_controllerHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AugmentedObject>.NativeClassPtr, "controllerHand");
		AugmentedObject.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AugmentedObject>.NativeClassPtr, "shadow");
		AugmentedObject.NativeFieldInfoPtr_groundShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AugmentedObject>.NativeClassPtr, "groundShadow");
		AugmentedObject.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AugmentedObject>.NativeClassPtr, 100663844);
		AugmentedObject.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AugmentedObject>.NativeClassPtr, 100663845);
		AugmentedObject.NativeMethodInfoPtr_Grab_Public_Void_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AugmentedObject>.NativeClassPtr, 100663846);
		AugmentedObject.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AugmentedObject>.NativeClassPtr, 100663847);
		AugmentedObject.NativeMethodInfoPtr_ToggleShadowType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AugmentedObject>.NativeClassPtr, 100663848);
		AugmentedObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AugmentedObject>.NativeClassPtr, 100663849);
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x0000210C File Offset: 0x0000030C
	public AugmentedObject(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x06000672 RID: 1650 RVA: 0x0001C144 File Offset: 0x0001A344
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AugmentedObject>.NativeClassPtr));
		}
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x06000673 RID: 1651 RVA: 0x0001C158 File Offset: 0x0001A358
	// (set) Token: 0x06000674 RID: 1652 RVA: 0x0001C180 File Offset: 0x0001A380
	public unsafe OVRInput.Controller controllerHand
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AugmentedObject.NativeFieldInfoPtr_controllerHand);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AugmentedObject.NativeFieldInfoPtr_controllerHand)) = value;
		}
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x06000675 RID: 1653 RVA: 0x0001C1A4 File Offset: 0x0001A3A4
	// (set) Token: 0x06000676 RID: 1654 RVA: 0x0001C1D8 File Offset: 0x0001A3D8
	public unsafe Transform shadow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AugmentedObject.NativeFieldInfoPtr_shadow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AugmentedObject.NativeFieldInfoPtr_shadow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x06000677 RID: 1655 RVA: 0x0001C200 File Offset: 0x0001A400
	// (set) Token: 0x06000678 RID: 1656 RVA: 0x0001C228 File Offset: 0x0001A428
	public unsafe bool groundShadow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AugmentedObject.NativeFieldInfoPtr_groundShadow);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AugmentedObject.NativeFieldInfoPtr_groundShadow)) = value;
		}
	}

	// Token: 0x0400040B RID: 1035
	private static readonly IntPtr NativeFieldInfoPtr_controllerHand;

	// Token: 0x0400040C RID: 1036
	private static readonly IntPtr NativeFieldInfoPtr_shadow;

	// Token: 0x0400040D RID: 1037
	private static readonly IntPtr NativeFieldInfoPtr_groundShadow;

	// Token: 0x0400040E RID: 1038
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400040F RID: 1039
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000410 RID: 1040
	private static readonly IntPtr NativeMethodInfoPtr_Grab_Public_Void_Controller_0;

	// Token: 0x04000411 RID: 1041
	private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

	// Token: 0x04000412 RID: 1042
	private static readonly IntPtr NativeMethodInfoPtr_ToggleShadowType_Private_Void_0;

	// Token: 0x04000413 RID: 1043
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
