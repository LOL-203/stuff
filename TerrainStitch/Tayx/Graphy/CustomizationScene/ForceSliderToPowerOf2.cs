using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.CustomizationScene
{
	// Token: 0x020008F6 RID: 2294
	public class ForceSliderToPowerOf2 : MonoBehaviour
	{
		// Token: 0x0600BBD6 RID: 48086 RVA: 0x00300CE0 File Offset: 0x002FEEE0
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceSliderToPowerOf2.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBD7 RID: 48087 RVA: 0x00300D24 File Offset: 0x002FEF24
		[CallerCount(0)]
		public unsafe void UpdateValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceSliderToPowerOf2.NativeMethodInfoPtr_UpdateValue_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBD8 RID: 48088 RVA: 0x00300D78 File Offset: 0x002FEF78
		[CallerCount(0)]
		public unsafe ForceSliderToPowerOf2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceSliderToPowerOf2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBD9 RID: 48089 RVA: 0x00300DC4 File Offset: 0x002FEFC4
		// Note: this type is marked as 'beforefieldinit'.
		static ForceSliderToPowerOf2()
		{
			Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.CustomizationScene", "ForceSliderToPowerOf2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr);
			ForceSliderToPowerOf2.NativeFieldInfoPtr_m_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr, "m_slider");
			ForceSliderToPowerOf2.NativeFieldInfoPtr_m_powerOf2Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr, "m_powerOf2Values");
			ForceSliderToPowerOf2.NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr, "m_text");
			ForceSliderToPowerOf2.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr, 100678583);
			ForceSliderToPowerOf2.NativeMethodInfoPtr_UpdateValue_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr, 100678584);
			ForceSliderToPowerOf2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr, 100678585);
		}

		// Token: 0x0600BBDA RID: 48090 RVA: 0x0000210C File Offset: 0x0000030C
		public ForceSliderToPowerOf2(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700430A RID: 17162
		// (get) Token: 0x0600BBDB RID: 48091 RVA: 0x00300E6C File Offset: 0x002FF06C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ForceSliderToPowerOf2>.NativeClassPtr));
			}
		}

		// Token: 0x1700430B RID: 17163
		// (get) Token: 0x0600BBDC RID: 48092 RVA: 0x00300E80 File Offset: 0x002FF080
		// (set) Token: 0x0600BBDD RID: 48093 RVA: 0x00300EB4 File Offset: 0x002FF0B4
		public unsafe Slider m_slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceSliderToPowerOf2.NativeFieldInfoPtr_m_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Slider(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceSliderToPowerOf2.NativeFieldInfoPtr_m_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700430C RID: 17164
		// (get) Token: 0x0600BBDE RID: 48094 RVA: 0x00300EDC File Offset: 0x002FF0DC
		// (set) Token: 0x0600BBDF RID: 48095 RVA: 0x00300F10 File Offset: 0x002FF110
		public unsafe Il2CppStructArray<int> m_powerOf2Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceSliderToPowerOf2.NativeFieldInfoPtr_m_powerOf2Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<int>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceSliderToPowerOf2.NativeFieldInfoPtr_m_powerOf2Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700430D RID: 17165
		// (get) Token: 0x0600BBE0 RID: 48096 RVA: 0x00300F38 File Offset: 0x002FF138
		// (set) Token: 0x0600BBE1 RID: 48097 RVA: 0x00300F6C File Offset: 0x002FF16C
		public unsafe Text m_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceSliderToPowerOf2.NativeFieldInfoPtr_m_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceSliderToPowerOf2.NativeFieldInfoPtr_m_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400787B RID: 30843
		private static readonly IntPtr NativeFieldInfoPtr_m_slider;

		// Token: 0x0400787C RID: 30844
		private static readonly IntPtr NativeFieldInfoPtr_m_powerOf2Values;

		// Token: 0x0400787D RID: 30845
		private static readonly IntPtr NativeFieldInfoPtr_m_text;

		// Token: 0x0400787E RID: 30846
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400787F RID: 30847
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Private_Void_Single_0;

		// Token: 0x04007880 RID: 30848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
