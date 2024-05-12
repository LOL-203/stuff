using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy.CustomizationScene
{
	// Token: 0x020008F5 RID: 2293
	public class ForceSliderToMultipleOf3 : MonoBehaviour
	{
		// Token: 0x0600BBCE RID: 48078 RVA: 0x00300B0C File Offset: 0x002FED0C
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceSliderToMultipleOf3.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBCF RID: 48079 RVA: 0x00300B50 File Offset: 0x002FED50
		[CallerCount(0)]
		public unsafe void UpdateValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceSliderToMultipleOf3.NativeMethodInfoPtr_UpdateValue_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBD0 RID: 48080 RVA: 0x00300BA4 File Offset: 0x002FEDA4
		[CallerCount(0)]
		public unsafe ForceSliderToMultipleOf3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceSliderToMultipleOf3>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceSliderToMultipleOf3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BBD1 RID: 48081 RVA: 0x00300BF0 File Offset: 0x002FEDF0
		// Note: this type is marked as 'beforefieldinit'.
		static ForceSliderToMultipleOf3()
		{
			Il2CppClassPointerStore<ForceSliderToMultipleOf3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.CustomizationScene", "ForceSliderToMultipleOf3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceSliderToMultipleOf3>.NativeClassPtr);
			ForceSliderToMultipleOf3.NativeFieldInfoPtr_m_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceSliderToMultipleOf3>.NativeClassPtr, "m_slider");
			ForceSliderToMultipleOf3.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSliderToMultipleOf3>.NativeClassPtr, 100678580);
			ForceSliderToMultipleOf3.NativeMethodInfoPtr_UpdateValue_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSliderToMultipleOf3>.NativeClassPtr, 100678581);
			ForceSliderToMultipleOf3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceSliderToMultipleOf3>.NativeClassPtr, 100678582);
		}

		// Token: 0x0600BBD2 RID: 48082 RVA: 0x0000210C File Offset: 0x0000030C
		public ForceSliderToMultipleOf3(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004308 RID: 17160
		// (get) Token: 0x0600BBD3 RID: 48083 RVA: 0x00300C70 File Offset: 0x002FEE70
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ForceSliderToMultipleOf3>.NativeClassPtr));
			}
		}

		// Token: 0x17004309 RID: 17161
		// (get) Token: 0x0600BBD4 RID: 48084 RVA: 0x00300C84 File Offset: 0x002FEE84
		// (set) Token: 0x0600BBD5 RID: 48085 RVA: 0x00300CB8 File Offset: 0x002FEEB8
		public unsafe Slider m_slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceSliderToMultipleOf3.NativeFieldInfoPtr_m_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Slider(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceSliderToMultipleOf3.NativeFieldInfoPtr_m_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007877 RID: 30839
		private static readonly IntPtr NativeFieldInfoPtr_m_slider;

		// Token: 0x04007878 RID: 30840
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007879 RID: 30841
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Private_Void_Single_0;

		// Token: 0x0400787A RID: 30842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
