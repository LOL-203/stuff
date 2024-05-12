using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.CustomizationScene
{
	// Token: 0x020008F7 RID: 2295
	public class UpdateTextWithSliderValue : MonoBehaviour
	{
		// Token: 0x0600BBE2 RID: 48098 RVA: 0x00300F94 File Offset: 0x002FF194
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateTextWithSliderValue.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBE3 RID: 48099 RVA: 0x00300FD8 File Offset: 0x002FF1D8
		[CallerCount(0)]
		public unsafe void UpdateText(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateTextWithSliderValue.NativeMethodInfoPtr_UpdateText_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBE4 RID: 48100 RVA: 0x0030102C File Offset: 0x002FF22C
		[CallerCount(0)]
		public unsafe UpdateTextWithSliderValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateTextWithSliderValue>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateTextWithSliderValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBE5 RID: 48101 RVA: 0x00301078 File Offset: 0x002FF278
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateTextWithSliderValue()
		{
			Il2CppClassPointerStore<UpdateTextWithSliderValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.CustomizationScene", "UpdateTextWithSliderValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTextWithSliderValue>.NativeClassPtr);
			UpdateTextWithSliderValue.NativeFieldInfoPtr_m_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTextWithSliderValue>.NativeClassPtr, "m_slider");
			UpdateTextWithSliderValue.NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTextWithSliderValue>.NativeClassPtr, "m_text");
			UpdateTextWithSliderValue.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTextWithSliderValue>.NativeClassPtr, 100678586);
			UpdateTextWithSliderValue.NativeMethodInfoPtr_UpdateText_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTextWithSliderValue>.NativeClassPtr, 100678587);
			UpdateTextWithSliderValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTextWithSliderValue>.NativeClassPtr, 100678588);
		}

		// Token: 0x0600BBE6 RID: 48102 RVA: 0x0000210C File Offset: 0x0000030C
		public UpdateTextWithSliderValue(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700430E RID: 17166
		// (get) Token: 0x0600BBE7 RID: 48103 RVA: 0x0030110C File Offset: 0x002FF30C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UpdateTextWithSliderValue>.NativeClassPtr));
			}
		}

		// Token: 0x1700430F RID: 17167
		// (get) Token: 0x0600BBE8 RID: 48104 RVA: 0x00301120 File Offset: 0x002FF320
		// (set) Token: 0x0600BBE9 RID: 48105 RVA: 0x00301154 File Offset: 0x002FF354
		public unsafe Slider m_slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateTextWithSliderValue.NativeFieldInfoPtr_m_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Slider(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateTextWithSliderValue.NativeFieldInfoPtr_m_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004310 RID: 17168
		// (get) Token: 0x0600BBEA RID: 48106 RVA: 0x0030117C File Offset: 0x002FF37C
		// (set) Token: 0x0600BBEB RID: 48107 RVA: 0x003011B0 File Offset: 0x002FF3B0
		public unsafe Text m_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateTextWithSliderValue.NativeFieldInfoPtr_m_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Text(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateTextWithSliderValue.NativeFieldInfoPtr_m_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007881 RID: 30849
		private static readonly IntPtr NativeFieldInfoPtr_m_slider;

		// Token: 0x04007882 RID: 30850
		private static readonly IntPtr NativeFieldInfoPtr_m_text;

		// Token: 0x04007883 RID: 30851
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007884 RID: 30852
		private static readonly IntPtr NativeMethodInfoPtr_UpdateText_Private_Void_Single_0;

		// Token: 0x04007885 RID: 30853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
