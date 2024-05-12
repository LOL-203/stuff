using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.CustomizationScene
{
	// Token: 0x020008F2 RID: 2290
	public class G_CUIColorPicker : MonoBehaviour
	{
		// Token: 0x170042CC RID: 17100
		// (get) Token: 0x0600BB09 RID: 47881 RVA: 0x002FD684 File Offset: 0x002FB884
		// (set) Token: 0x0600BB0A RID: 47882 RVA: 0x002FD6D4 File Offset: 0x002FB8D4
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600BB0B RID: 47883 RVA: 0x002FD728 File Offset: 0x002FB928
		[CallerCount(0)]
		public unsafe void SetOnValueChangeCallback(Action<Color> onValueChange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onValueChange);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_SetOnValueChangeCallback_Public_Void_Action_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BB0C RID: 47884 RVA: 0x002FD784 File Offset: 0x002FB984
		[CallerCount(0)]
		public unsafe static void RGBToHSV(Color color, out float h, out float s, out float v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &v;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_RGBToHSV_Private_Static_Void_Color_byref_Single_byref_Single_byref_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BB0D RID: 47885 RVA: 0x002FD808 File Offset: 0x002FBA08
		[CallerCount(0)]
		public unsafe static bool GetLocalMouse(GameObject go, out Vector2 result)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_GetLocalMouse_Private_Static_Boolean_GameObject_byref_Vector2_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BB0E RID: 47886 RVA: 0x002FD874 File Offset: 0x002FBA74
		[CallerCount(0)]
		public unsafe static Vector2 GetWidgetSize(GameObject go)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_GetWidgetSize_Private_Static_Vector2_GameObject_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BB0F RID: 47887 RVA: 0x002FD8CC File Offset: 0x002FBACC
		[CallerCount(0)]
		public unsafe GameObject GO(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_GO_Private_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}

		// Token: 0x0600BB10 RID: 47888 RVA: 0x002FD93C File Offset: 0x002FBB3C
		[CallerCount(0)]
		public unsafe void Setup(Color inputColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputColor;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_Setup_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BB11 RID: 47889 RVA: 0x002FD990 File Offset: 0x002FBB90
		[CallerCount(0)]
		public unsafe void SetRandomColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_SetRandomColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BB12 RID: 47890 RVA: 0x002FD9D4 File Offset: 0x002FBBD4
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BB13 RID: 47891 RVA: 0x002FDA18 File Offset: 0x002FBC18
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BB14 RID: 47892 RVA: 0x002FDA5C File Offset: 0x002FBC5C
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BB15 RID: 47893 RVA: 0x002FDAA0 File Offset: 0x002FBCA0
		[CallerCount(0)]
		public unsafe G_CUIColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BB16 RID: 47894 RVA: 0x002FDAEC File Offset: 0x002FBCEC
		[CallerCount(0)]
		public unsafe void _Start_b__16_0(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.NativeMethodInfoPtr__Start_b__16_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BB17 RID: 47895 RVA: 0x002FDB40 File Offset: 0x002FBD40
		// Note: this type is marked as 'beforefieldinit'.
		static G_CUIColorPicker()
		{
			Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.CustomizationScene", "G_CUIColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr);
			G_CUIColorPicker.NativeFieldInfoPtr_alphaSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, "alphaSlider");
			G_CUIColorPicker.NativeFieldInfoPtr_alphaSliderBGImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, "alphaSliderBGImage");
			G_CUIColorPicker.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, "_color");
			G_CUIColorPicker.NativeFieldInfoPtr__onValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, "_onValueChange");
			G_CUIColorPicker.NativeFieldInfoPtr__update = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, "_update");
			G_CUIColorPicker.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678516);
			G_CUIColorPicker.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678517);
			G_CUIColorPicker.NativeMethodInfoPtr_SetOnValueChangeCallback_Public_Void_Action_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678518);
			G_CUIColorPicker.NativeMethodInfoPtr_RGBToHSV_Private_Static_Void_Color_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678519);
			G_CUIColorPicker.NativeMethodInfoPtr_GetLocalMouse_Private_Static_Boolean_GameObject_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678520);
			G_CUIColorPicker.NativeMethodInfoPtr_GetWidgetSize_Private_Static_Vector2_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678521);
			G_CUIColorPicker.NativeMethodInfoPtr_GO_Private_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678522);
			G_CUIColorPicker.NativeMethodInfoPtr_Setup_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678523);
			G_CUIColorPicker.NativeMethodInfoPtr_SetRandomColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678524);
			G_CUIColorPicker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678525);
			G_CUIColorPicker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678526);
			G_CUIColorPicker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678527);
			G_CUIColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678528);
			G_CUIColorPicker.NativeMethodInfoPtr__Start_b__16_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, 100678529);
		}

		// Token: 0x0600BB18 RID: 47896 RVA: 0x0000210C File Offset: 0x0000030C
		public G_CUIColorPicker(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170042C6 RID: 17094
		// (get) Token: 0x0600BB19 RID: 47897 RVA: 0x002FDCEC File Offset: 0x002FBEEC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr));
			}
		}

		// Token: 0x170042C7 RID: 17095
		// (get) Token: 0x0600BB1A RID: 47898 RVA: 0x002FDD00 File Offset: 0x002FBF00
		// (set) Token: 0x0600BB1B RID: 47899 RVA: 0x002FDD34 File Offset: 0x002FBF34
		public unsafe Slider alphaSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr_alphaSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Slider(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr_alphaSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042C8 RID: 17096
		// (get) Token: 0x0600BB1C RID: 47900 RVA: 0x002FDD5C File Offset: 0x002FBF5C
		// (set) Token: 0x0600BB1D RID: 47901 RVA: 0x002FDD90 File Offset: 0x002FBF90
		public unsafe Image alphaSliderBGImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr_alphaSliderBGImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Image(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr_alphaSliderBGImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042C9 RID: 17097
		// (get) Token: 0x0600BB1E RID: 47902 RVA: 0x002FDDB8 File Offset: 0x002FBFB8
		// (set) Token: 0x0600BB1F RID: 47903 RVA: 0x002FDDE0 File Offset: 0x002FBFE0
		public unsafe Color _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr__color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr__color)) = value;
			}
		}

		// Token: 0x170042CA RID: 17098
		// (get) Token: 0x0600BB20 RID: 47904 RVA: 0x002FDE04 File Offset: 0x002FC004
		// (set) Token: 0x0600BB21 RID: 47905 RVA: 0x002FDE38 File Offset: 0x002FC038
		public unsafe Action<Color> _onValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr__onValueChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Action<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr__onValueChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170042CB RID: 17099
		// (get) Token: 0x0600BB22 RID: 47906 RVA: 0x002FDE60 File Offset: 0x002FC060
		// (set) Token: 0x0600BB23 RID: 47907 RVA: 0x002FDE94 File Offset: 0x002FC094
		public unsafe Action _update
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr__update);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Action(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.NativeFieldInfoPtr__update), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040077F9 RID: 30713
		private static readonly IntPtr NativeFieldInfoPtr_alphaSlider;

		// Token: 0x040077FA RID: 30714
		private static readonly IntPtr NativeFieldInfoPtr_alphaSliderBGImage;

		// Token: 0x040077FB RID: 30715
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x040077FC RID: 30716
		private static readonly IntPtr NativeFieldInfoPtr__onValueChange;

		// Token: 0x040077FD RID: 30717
		private static readonly IntPtr NativeFieldInfoPtr__update;

		// Token: 0x040077FE RID: 30718
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x040077FF RID: 30719
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04007800 RID: 30720
		private static readonly IntPtr NativeMethodInfoPtr_SetOnValueChangeCallback_Public_Void_Action_1_Color_0;

		// Token: 0x04007801 RID: 30721
		private static readonly IntPtr NativeMethodInfoPtr_RGBToHSV_Private_Static_Void_Color_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x04007802 RID: 30722
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalMouse_Private_Static_Boolean_GameObject_byref_Vector2_0;

		// Token: 0x04007803 RID: 30723
		private static readonly IntPtr NativeMethodInfoPtr_GetWidgetSize_Private_Static_Vector2_GameObject_0;

		// Token: 0x04007804 RID: 30724
		private static readonly IntPtr NativeMethodInfoPtr_GO_Private_GameObject_String_0;

		// Token: 0x04007805 RID: 30725
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Private_Void_Color_0;

		// Token: 0x04007806 RID: 30726
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomColor_Public_Void_0;

		// Token: 0x04007807 RID: 30727
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007808 RID: 30728
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007809 RID: 30729
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400780A RID: 30730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400780B RID: 30731
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__16_0_Private_Void_Single_0;

		// Token: 0x020008F3 RID: 2291
		[ObfuscatedName("Tayx.Graphy.CustomizationScene.G_CUIColorPicker/<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BB24 RID: 47908 RVA: 0x002FDEBC File Offset: 0x002FC0BC
			[CallerCount(0)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600BB25 RID: 47909 RVA: 0x002FDF08 File Offset: 0x002FC108
			[CallerCount(0)]
			public unsafe void _Setup_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600BB26 RID: 47910 RVA: 0x002FDF4C File Offset: 0x002FC14C
			[CallerCount(0)]
			public unsafe void _Setup_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600BB27 RID: 47911 RVA: 0x002FDF90 File Offset: 0x002FC190
			[CallerCount(0)]
			public unsafe void _Setup_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600BB28 RID: 47912 RVA: 0x002FDFD4 File Offset: 0x002FC1D4
			[CallerCount(0)]
			public unsafe void _Setup_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600BB29 RID: 47913 RVA: 0x002FE018 File Offset: 0x002FC218
			[CallerCount(0)]
			public unsafe void _Setup_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600BB2A RID: 47914 RVA: 0x002FE05C File Offset: 0x002FC25C
			[CallerCount(0)]
			public unsafe void _Setup_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600BB2B RID: 47915 RVA: 0x002FE0A0 File Offset: 0x002FC2A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<G_CUIColorPicker>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr);
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "satvalTex");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "satvalColors");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Hue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "Hue");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "hueColors");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_resetSatValTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "resetSatValTexture");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Saturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "Saturation");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "Value");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "result");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueGO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "hueGO");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_dragH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "dragH");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalGO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "satvalGO");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_dragSV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "dragSV");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueSz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "hueSz");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_applyHue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "applyHue");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_applySaturationValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "applySaturationValue");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueKnob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "hueKnob");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_idle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "idle");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalSz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "satvalSz");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalKnob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, "satvalKnob");
				G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100678530);
				G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100678531);
				G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100678532);
				G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100678533);
				G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100678534);
				G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100678535);
				G_CUIColorPicker.__c__DisplayClass13_0.NativeMethodInfoPtr__Setup_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr, 100678536);
			}

			// Token: 0x0600BB2C RID: 47916 RVA: 0x00002988 File Offset: 0x00000B88
			public __c__DisplayClass13_0(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x170042CD RID: 17101
			// (get) Token: 0x0600BB2D RID: 47917 RVA: 0x002FE2E7 File Offset: 0x002FC4E7
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_CUIColorPicker.__c__DisplayClass13_0>.NativeClassPtr));
				}
			}

			// Token: 0x170042CE RID: 17102
			// (get) Token: 0x0600BB2E RID: 47918 RVA: 0x002FE2F8 File Offset: 0x002FC4F8
			// (set) Token: 0x0600BB2F RID: 47919 RVA: 0x002FE32C File Offset: 0x002FC52C
			public unsafe Texture2D satvalTex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalTex);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Texture2D(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalTex), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042CF RID: 17103
			// (get) Token: 0x0600BB30 RID: 47920 RVA: 0x002FE354 File Offset: 0x002FC554
			// (set) Token: 0x0600BB31 RID: 47921 RVA: 0x002FE388 File Offset: 0x002FC588
			public unsafe Il2CppStructArray<Color> satvalColors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalColors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<Color>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalColors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D0 RID: 17104
			// (get) Token: 0x0600BB32 RID: 47922 RVA: 0x002FE3B0 File Offset: 0x002FC5B0
			// (set) Token: 0x0600BB33 RID: 47923 RVA: 0x002FE3D8 File Offset: 0x002FC5D8
			public unsafe float Hue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Hue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Hue)) = value;
				}
			}

			// Token: 0x170042D1 RID: 17105
			// (get) Token: 0x0600BB34 RID: 47924 RVA: 0x002FE3FC File Offset: 0x002FC5FC
			// (set) Token: 0x0600BB35 RID: 47925 RVA: 0x002FE430 File Offset: 0x002FC630
			public unsafe Il2CppStructArray<Color> hueColors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueColors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppStructArray<Color>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueColors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D2 RID: 17106
			// (get) Token: 0x0600BB36 RID: 47926 RVA: 0x002FE458 File Offset: 0x002FC658
			// (set) Token: 0x0600BB37 RID: 47927 RVA: 0x002FE48C File Offset: 0x002FC68C
			public unsafe Action resetSatValTexture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_resetSatValTexture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Action(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_resetSatValTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D3 RID: 17107
			// (get) Token: 0x0600BB38 RID: 47928 RVA: 0x002FE4B4 File Offset: 0x002FC6B4
			// (set) Token: 0x0600BB39 RID: 47929 RVA: 0x002FE4DC File Offset: 0x002FC6DC
			public unsafe float Saturation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Saturation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Saturation)) = value;
				}
			}

			// Token: 0x170042D4 RID: 17108
			// (get) Token: 0x0600BB3A RID: 47930 RVA: 0x002FE500 File Offset: 0x002FC700
			// (set) Token: 0x0600BB3B RID: 47931 RVA: 0x002FE528 File Offset: 0x002FC728
			public unsafe float Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x170042D5 RID: 17109
			// (get) Token: 0x0600BB3C RID: 47932 RVA: 0x002FE54C File Offset: 0x002FC74C
			// (set) Token: 0x0600BB3D RID: 47933 RVA: 0x002FE580 File Offset: 0x002FC780
			public unsafe GameObject result
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_result);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D6 RID: 17110
			// (get) Token: 0x0600BB3E RID: 47934 RVA: 0x002FE5A8 File Offset: 0x002FC7A8
			// (set) Token: 0x0600BB3F RID: 47935 RVA: 0x002FE5DC File Offset: 0x002FC7DC
			public unsafe G_CUIColorPicker __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new G_CUIColorPicker(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D7 RID: 17111
			// (get) Token: 0x0600BB40 RID: 47936 RVA: 0x002FE604 File Offset: 0x002FC804
			// (set) Token: 0x0600BB41 RID: 47937 RVA: 0x002FE638 File Offset: 0x002FC838
			public unsafe GameObject hueGO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueGO);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueGO), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D8 RID: 17112
			// (get) Token: 0x0600BB42 RID: 47938 RVA: 0x002FE660 File Offset: 0x002FC860
			// (set) Token: 0x0600BB43 RID: 47939 RVA: 0x002FE694 File Offset: 0x002FC894
			public unsafe Action dragH
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_dragH);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Action(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_dragH), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042D9 RID: 17113
			// (get) Token: 0x0600BB44 RID: 47940 RVA: 0x002FE6BC File Offset: 0x002FC8BC
			// (set) Token: 0x0600BB45 RID: 47941 RVA: 0x002FE6F0 File Offset: 0x002FC8F0
			public unsafe GameObject satvalGO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalGO);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalGO), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DA RID: 17114
			// (get) Token: 0x0600BB46 RID: 47942 RVA: 0x002FE718 File Offset: 0x002FC918
			// (set) Token: 0x0600BB47 RID: 47943 RVA: 0x002FE74C File Offset: 0x002FC94C
			public unsafe Action dragSV
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_dragSV);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Action(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_dragSV), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DB RID: 17115
			// (get) Token: 0x0600BB48 RID: 47944 RVA: 0x002FE774 File Offset: 0x002FC974
			// (set) Token: 0x0600BB49 RID: 47945 RVA: 0x002FE79C File Offset: 0x002FC99C
			public unsafe Vector2 hueSz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueSz);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueSz)) = value;
				}
			}

			// Token: 0x170042DC RID: 17116
			// (get) Token: 0x0600BB4A RID: 47946 RVA: 0x002FE7C0 File Offset: 0x002FC9C0
			// (set) Token: 0x0600BB4B RID: 47947 RVA: 0x002FE7F4 File Offset: 0x002FC9F4
			public unsafe Action applyHue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_applyHue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Action(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_applyHue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DD RID: 17117
			// (get) Token: 0x0600BB4C RID: 47948 RVA: 0x002FE81C File Offset: 0x002FCA1C
			// (set) Token: 0x0600BB4D RID: 47949 RVA: 0x002FE850 File Offset: 0x002FCA50
			public unsafe Action applySaturationValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_applySaturationValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Action(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_applySaturationValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DE RID: 17118
			// (get) Token: 0x0600BB4E RID: 47950 RVA: 0x002FE878 File Offset: 0x002FCA78
			// (set) Token: 0x0600BB4F RID: 47951 RVA: 0x002FE8AC File Offset: 0x002FCAAC
			public unsafe GameObject hueKnob
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueKnob);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_hueKnob), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DF RID: 17119
			// (get) Token: 0x0600BB50 RID: 47952 RVA: 0x002FE8D4 File Offset: 0x002FCAD4
			// (set) Token: 0x0600BB51 RID: 47953 RVA: 0x002FE908 File Offset: 0x002FCB08
			public unsafe Action idle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_idle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Action(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_idle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E0 RID: 17120
			// (get) Token: 0x0600BB52 RID: 47954 RVA: 0x002FE930 File Offset: 0x002FCB30
			// (set) Token: 0x0600BB53 RID: 47955 RVA: 0x002FE958 File Offset: 0x002FCB58
			public unsafe Vector2 satvalSz
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalSz);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalSz)) = value;
				}
			}

			// Token: 0x170042E1 RID: 17121
			// (get) Token: 0x0600BB54 RID: 47956 RVA: 0x002FE97C File Offset: 0x002FCB7C
			// (set) Token: 0x0600BB55 RID: 47957 RVA: 0x002FE9B0 File Offset: 0x002FCBB0
			public unsafe GameObject satvalKnob
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalKnob);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_CUIColorPicker.__c__DisplayClass13_0.NativeFieldInfoPtr_satvalKnob), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400780C RID: 30732
			private static readonly IntPtr NativeFieldInfoPtr_satvalTex;

			// Token: 0x0400780D RID: 30733
			private static readonly IntPtr NativeFieldInfoPtr_satvalColors;

			// Token: 0x0400780E RID: 30734
			private static readonly IntPtr NativeFieldInfoPtr_Hue;

			// Token: 0x0400780F RID: 30735
			private static readonly IntPtr NativeFieldInfoPtr_hueColors;

			// Token: 0x04007810 RID: 30736
			private static readonly IntPtr NativeFieldInfoPtr_resetSatValTexture;

			// Token: 0x04007811 RID: 30737
			private static readonly IntPtr NativeFieldInfoPtr_Saturation;

			// Token: 0x04007812 RID: 30738
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04007813 RID: 30739
			private static readonly IntPtr NativeFieldInfoPtr_result;

			// Token: 0x04007814 RID: 30740
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007815 RID: 30741
			private static readonly IntPtr NativeFieldInfoPtr_hueGO;

			// Token: 0x04007816 RID: 30742
			private static readonly IntPtr NativeFieldInfoPtr_dragH;

			// Token: 0x04007817 RID: 30743
			private static readonly IntPtr NativeFieldInfoPtr_satvalGO;

			// Token: 0x04007818 RID: 30744
			private static readonly IntPtr NativeFieldInfoPtr_dragSV;

			// Token: 0x04007819 RID: 30745
			private static readonly IntPtr NativeFieldInfoPtr_hueSz;

			// Token: 0x0400781A RID: 30746
			private static readonly IntPtr NativeFieldInfoPtr_applyHue;

			// Token: 0x0400781B RID: 30747
			private static readonly IntPtr NativeFieldInfoPtr_applySaturationValue;

			// Token: 0x0400781C RID: 30748
			private static readonly IntPtr NativeFieldInfoPtr_hueKnob;

			// Token: 0x0400781D RID: 30749
			private static readonly IntPtr NativeFieldInfoPtr_idle;

			// Token: 0x0400781E RID: 30750
			private static readonly IntPtr NativeFieldInfoPtr_satvalSz;

			// Token: 0x0400781F RID: 30751
			private static readonly IntPtr NativeFieldInfoPtr_satvalKnob;

			// Token: 0x04007820 RID: 30752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007821 RID: 30753
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__0_Internal_Void_0;

			// Token: 0x04007822 RID: 30754
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__1_Internal_Void_0;

			// Token: 0x04007823 RID: 30755
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__2_Internal_Void_0;

			// Token: 0x04007824 RID: 30756
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__3_Internal_Void_0;

			// Token: 0x04007825 RID: 30757
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__4_Internal_Void_0;

			// Token: 0x04007826 RID: 30758
			private static readonly IntPtr NativeMethodInfoPtr__Setup_b__5_Internal_Void_0;
		}
	}
}
