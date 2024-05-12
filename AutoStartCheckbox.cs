using System;
using Il2CppSystem;
using Onward.UI;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003ED RID: 1005
public class AutoStartCheckbox : MonoBehaviour
{
	// Token: 0x17001C31 RID: 7217
	// (get) Token: 0x06004ED4 RID: 20180 RVA: 0x0013BE34 File Offset: 0x0013A034
	public unsafe bool IsChecked
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AutoStartCheckbox.NativeMethodInfoPtr_get_IsChecked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x06004ED5 RID: 20181 RVA: 0x0013BE84 File Offset: 0x0013A084
	[CallerCount(0)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoStartCheckbox.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004ED6 RID: 20182 RVA: 0x0013BEC8 File Offset: 0x0013A0C8
	[CallerCount(0)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoStartCheckbox.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004ED7 RID: 20183 RVA: 0x0013BF0C File Offset: 0x0013A10C
	[CallerCount(0)]
	public unsafe void ToggleChecked(NavigationSelectable selectable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoStartCheckbox.NativeMethodInfoPtr_ToggleChecked_Private_Void_NavigationSelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004ED8 RID: 20184 RVA: 0x0013BF68 File Offset: 0x0013A168
	[CallerCount(0)]
	public unsafe void SetChecked(bool check)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref check;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoStartCheckbox.NativeMethodInfoPtr_SetChecked_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004ED9 RID: 20185 RVA: 0x0013BFBC File Offset: 0x0013A1BC
	[CallerCount(0)]
	public unsafe AutoStartCheckbox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoStartCheckbox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06004EDA RID: 20186 RVA: 0x0013C008 File Offset: 0x0013A208
	// Note: this type is marked as 'beforefieldinit'.
	static AutoStartCheckbox()
	{
		Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AutoStartCheckbox");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr);
		AutoStartCheckbox.NativeFieldInfoPtr_ToggleButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr, "ToggleButton");
		AutoStartCheckbox.NativeFieldInfoPtr_ToggleImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr, "ToggleImage");
		AutoStartCheckbox.NativeFieldInfoPtr_CheckedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr, "CheckedSprite");
		AutoStartCheckbox.NativeFieldInfoPtr_UncheckedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr, "UncheckedSprite");
		AutoStartCheckbox.NativeFieldInfoPtr__isChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr, "_isChecked");
		AutoStartCheckbox.NativeMethodInfoPtr_get_IsChecked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr, 100669505);
		AutoStartCheckbox.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr, 100669506);
		AutoStartCheckbox.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr, 100669507);
		AutoStartCheckbox.NativeMethodInfoPtr_ToggleChecked_Private_Void_NavigationSelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr, 100669508);
		AutoStartCheckbox.NativeMethodInfoPtr_SetChecked_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr, 100669509);
		AutoStartCheckbox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr, 100669510);
	}

	// Token: 0x06004EDB RID: 20187 RVA: 0x0000210C File Offset: 0x0000030C
	public AutoStartCheckbox(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17001C2B RID: 7211
	// (get) Token: 0x06004EDC RID: 20188 RVA: 0x0013C114 File Offset: 0x0013A314
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AutoStartCheckbox>.NativeClassPtr));
		}
	}

	// Token: 0x17001C2C RID: 7212
	// (get) Token: 0x06004EDD RID: 20189 RVA: 0x0013C128 File Offset: 0x0013A328
	// (set) Token: 0x06004EDE RID: 20190 RVA: 0x0013C15C File Offset: 0x0013A35C
	public unsafe MenuItemPopout ToggleButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoStartCheckbox.NativeFieldInfoPtr_ToggleButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new MenuItemPopout(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoStartCheckbox.NativeFieldInfoPtr_ToggleButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001C2D RID: 7213
	// (get) Token: 0x06004EDF RID: 20191 RVA: 0x0013C184 File Offset: 0x0013A384
	// (set) Token: 0x06004EE0 RID: 20192 RVA: 0x0013C1B8 File Offset: 0x0013A3B8
	public unsafe Image ToggleImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoStartCheckbox.NativeFieldInfoPtr_ToggleImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Image(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoStartCheckbox.NativeFieldInfoPtr_ToggleImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001C2E RID: 7214
	// (get) Token: 0x06004EE1 RID: 20193 RVA: 0x0013C1E0 File Offset: 0x0013A3E0
	// (set) Token: 0x06004EE2 RID: 20194 RVA: 0x0013C214 File Offset: 0x0013A414
	public unsafe Sprite CheckedSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoStartCheckbox.NativeFieldInfoPtr_CheckedSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Sprite(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoStartCheckbox.NativeFieldInfoPtr_CheckedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001C2F RID: 7215
	// (get) Token: 0x06004EE3 RID: 20195 RVA: 0x0013C23C File Offset: 0x0013A43C
	// (set) Token: 0x06004EE4 RID: 20196 RVA: 0x0013C270 File Offset: 0x0013A470
	public unsafe Sprite UncheckedSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoStartCheckbox.NativeFieldInfoPtr_UncheckedSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Sprite(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoStartCheckbox.NativeFieldInfoPtr_UncheckedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001C30 RID: 7216
	// (get) Token: 0x06004EE5 RID: 20197 RVA: 0x0013C298 File Offset: 0x0013A498
	// (set) Token: 0x06004EE6 RID: 20198 RVA: 0x0013C2C0 File Offset: 0x0013A4C0
	public unsafe bool _isChecked
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoStartCheckbox.NativeFieldInfoPtr__isChecked);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoStartCheckbox.NativeFieldInfoPtr__isChecked)) = value;
		}
	}

	// Token: 0x04003208 RID: 12808
	private static readonly IntPtr NativeFieldInfoPtr_ToggleButton;

	// Token: 0x04003209 RID: 12809
	private static readonly IntPtr NativeFieldInfoPtr_ToggleImage;

	// Token: 0x0400320A RID: 12810
	private static readonly IntPtr NativeFieldInfoPtr_CheckedSprite;

	// Token: 0x0400320B RID: 12811
	private static readonly IntPtr NativeFieldInfoPtr_UncheckedSprite;

	// Token: 0x0400320C RID: 12812
	private static readonly IntPtr NativeFieldInfoPtr__isChecked;

	// Token: 0x0400320D RID: 12813
	private static readonly IntPtr NativeMethodInfoPtr_get_IsChecked_Public_get_Boolean_0;

	// Token: 0x0400320E RID: 12814
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x0400320F RID: 12815
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04003210 RID: 12816
	private static readonly IntPtr NativeMethodInfoPtr_ToggleChecked_Private_Void_NavigationSelectable_0;

	// Token: 0x04003211 RID: 12817
	private static readonly IntPtr NativeMethodInfoPtr_SetChecked_Private_Void_Boolean_0;

	// Token: 0x04003212 RID: 12818
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
