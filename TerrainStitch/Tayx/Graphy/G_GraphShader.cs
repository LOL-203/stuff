using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Tayx.Graphy
{
	// Token: 0x020008DD RID: 2269
	public class G_GraphShader : Il2CppSystem.Object
	{
		// Token: 0x0600B8F3 RID: 47347 RVA: 0x002F58B0 File Offset: 0x002F3AB0
		[CallerCount(0)]
		public unsafe void InitializeShader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr_InitializeShader_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8F4 RID: 47348 RVA: 0x002F58F4 File Offset: 0x002F3AF4
		[CallerCount(0)]
		public unsafe void UpdateArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr_UpdateArray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8F5 RID: 47349 RVA: 0x002F5938 File Offset: 0x002F3B38
		[CallerCount(0)]
		public unsafe void UpdateAverage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr_UpdateAverage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8F6 RID: 47350 RVA: 0x002F597C File Offset: 0x002F3B7C
		[CallerCount(0)]
		public unsafe void UpdateThresholds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr_UpdateThresholds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8F7 RID: 47351 RVA: 0x002F59C0 File Offset: 0x002F3BC0
		[CallerCount(0)]
		public unsafe void UpdateColors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr_UpdateColors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8F8 RID: 47352 RVA: 0x002F5A04 File Offset: 0x002F3C04
		[CallerCount(0)]
		public unsafe void UpdatePoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr_UpdatePoints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8F9 RID: 47353 RVA: 0x002F5A48 File Offset: 0x002F3C48
		[CallerCount(0)]
		public unsafe G_GraphShader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8FA RID: 47354 RVA: 0x002F5A94 File Offset: 0x002F3C94
		// Note: this type is marked as 'beforefieldinit'.
		static G_GraphShader()
		{
			Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy", "G_GraphShader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr);
			G_GraphShader.NativeFieldInfoPtr_ArrayMaxSizeFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "ArrayMaxSizeFull");
			G_GraphShader.NativeFieldInfoPtr_ArrayMaxSizeLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "ArrayMaxSizeLight");
			G_GraphShader.NativeFieldInfoPtr_ArrayMaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "ArrayMaxSize");
			G_GraphShader.NativeFieldInfoPtr_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "Array");
			G_GraphShader.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "Image");
			G_GraphShader.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "Name");
			G_GraphShader.NativeFieldInfoPtr_Name_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "Name_Length");
			G_GraphShader.NativeFieldInfoPtr_Average = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "Average");
			G_GraphShader.NativeFieldInfoPtr_averagePropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "averagePropertyId");
			G_GraphShader.NativeFieldInfoPtr_GoodThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "GoodThreshold");
			G_GraphShader.NativeFieldInfoPtr_CautionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "CautionThreshold");
			G_GraphShader.NativeFieldInfoPtr_goodThresholdPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "goodThresholdPropertyId");
			G_GraphShader.NativeFieldInfoPtr_cautionThresholdPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "cautionThresholdPropertyId");
			G_GraphShader.NativeFieldInfoPtr_GoodColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "GoodColor");
			G_GraphShader.NativeFieldInfoPtr_CautionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "CautionColor");
			G_GraphShader.NativeFieldInfoPtr_CriticalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "CriticalColor");
			G_GraphShader.NativeFieldInfoPtr_goodColorPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "goodColorPropertyId");
			G_GraphShader.NativeFieldInfoPtr_cautionColorPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "cautionColorPropertyId");
			G_GraphShader.NativeFieldInfoPtr_criticalColorPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, "criticalColorPropertyId");
			G_GraphShader.NativeMethodInfoPtr_InitializeShader_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100678372);
			G_GraphShader.NativeMethodInfoPtr_UpdateArray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100678373);
			G_GraphShader.NativeMethodInfoPtr_UpdateAverage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100678374);
			G_GraphShader.NativeMethodInfoPtr_UpdateThresholds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100678375);
			G_GraphShader.NativeMethodInfoPtr_UpdateColors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100678376);
			G_GraphShader.NativeMethodInfoPtr_UpdatePoints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100678377);
			G_GraphShader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100678378);
		}

		// Token: 0x0600B8FB RID: 47355 RVA: 0x00002988 File Offset: 0x00000B88
		public G_GraphShader(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170041FA RID: 16890
		// (get) Token: 0x0600B8FC RID: 47356 RVA: 0x002F5CCC File Offset: 0x002F3ECC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr));
			}
		}

		// Token: 0x170041FB RID: 16891
		// (get) Token: 0x0600B8FD RID: 47357 RVA: 0x002F5CE0 File Offset: 0x002F3EE0
		// (set) Token: 0x0600B8FE RID: 47358 RVA: 0x002F5CFE File Offset: 0x002F3EFE
		public unsafe static int ArrayMaxSizeFull
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(G_GraphShader.NativeFieldInfoPtr_ArrayMaxSizeFull, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_GraphShader.NativeFieldInfoPtr_ArrayMaxSizeFull, (void*)(&value));
			}
		}

		// Token: 0x170041FC RID: 16892
		// (get) Token: 0x0600B8FF RID: 47359 RVA: 0x002F5D10 File Offset: 0x002F3F10
		// (set) Token: 0x0600B900 RID: 47360 RVA: 0x002F5D2E File Offset: 0x002F3F2E
		public unsafe static int ArrayMaxSizeLight
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(G_GraphShader.NativeFieldInfoPtr_ArrayMaxSizeLight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(G_GraphShader.NativeFieldInfoPtr_ArrayMaxSizeLight, (void*)(&value));
			}
		}

		// Token: 0x170041FD RID: 16893
		// (get) Token: 0x0600B901 RID: 47361 RVA: 0x002F5D40 File Offset: 0x002F3F40
		// (set) Token: 0x0600B902 RID: 47362 RVA: 0x002F5D68 File Offset: 0x002F3F68
		public unsafe int ArrayMaxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_ArrayMaxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_ArrayMaxSize)) = value;
			}
		}

		// Token: 0x170041FE RID: 16894
		// (get) Token: 0x0600B903 RID: 47363 RVA: 0x002F5D8C File Offset: 0x002F3F8C
		// (set) Token: 0x0600B904 RID: 47364 RVA: 0x002F5DC0 File Offset: 0x002F3FC0
		public unsafe Il2CppStructArray<float> Array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Array);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<float>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170041FF RID: 16895
		// (get) Token: 0x0600B905 RID: 47365 RVA: 0x002F5DE8 File Offset: 0x002F3FE8
		// (set) Token: 0x0600B906 RID: 47366 RVA: 0x002F5E1C File Offset: 0x002F401C
		public unsafe Image Image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Image(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004200 RID: 16896
		// (get) Token: 0x0600B907 RID: 47367 RVA: 0x002F5E44 File Offset: 0x002F4044
		// (set) Token: 0x0600B908 RID: 47368 RVA: 0x002F5E6D File Offset: 0x002F406D
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17004201 RID: 16897
		// (get) Token: 0x0600B909 RID: 47369 RVA: 0x002F5E94 File Offset: 0x002F4094
		// (set) Token: 0x0600B90A RID: 47370 RVA: 0x002F5EBD File Offset: 0x002F40BD
		public unsafe string Name_Length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Name_Length);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Name_Length), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17004202 RID: 16898
		// (get) Token: 0x0600B90B RID: 47371 RVA: 0x002F5EE4 File Offset: 0x002F40E4
		// (set) Token: 0x0600B90C RID: 47372 RVA: 0x002F5F0C File Offset: 0x002F410C
		public unsafe float Average
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Average);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Average)) = value;
			}
		}

		// Token: 0x17004203 RID: 16899
		// (get) Token: 0x0600B90D RID: 47373 RVA: 0x002F5F30 File Offset: 0x002F4130
		// (set) Token: 0x0600B90E RID: 47374 RVA: 0x002F5F58 File Offset: 0x002F4158
		public unsafe int averagePropertyId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_averagePropertyId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_averagePropertyId)) = value;
			}
		}

		// Token: 0x17004204 RID: 16900
		// (get) Token: 0x0600B90F RID: 47375 RVA: 0x002F5F7C File Offset: 0x002F417C
		// (set) Token: 0x0600B910 RID: 47376 RVA: 0x002F5FA4 File Offset: 0x002F41A4
		public unsafe float GoodThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_GoodThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_GoodThreshold)) = value;
			}
		}

		// Token: 0x17004205 RID: 16901
		// (get) Token: 0x0600B911 RID: 47377 RVA: 0x002F5FC8 File Offset: 0x002F41C8
		// (set) Token: 0x0600B912 RID: 47378 RVA: 0x002F5FF0 File Offset: 0x002F41F0
		public unsafe float CautionThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_CautionThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_CautionThreshold)) = value;
			}
		}

		// Token: 0x17004206 RID: 16902
		// (get) Token: 0x0600B913 RID: 47379 RVA: 0x002F6014 File Offset: 0x002F4214
		// (set) Token: 0x0600B914 RID: 47380 RVA: 0x002F603C File Offset: 0x002F423C
		public unsafe int goodThresholdPropertyId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_goodThresholdPropertyId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_goodThresholdPropertyId)) = value;
			}
		}

		// Token: 0x17004207 RID: 16903
		// (get) Token: 0x0600B915 RID: 47381 RVA: 0x002F6060 File Offset: 0x002F4260
		// (set) Token: 0x0600B916 RID: 47382 RVA: 0x002F6088 File Offset: 0x002F4288
		public unsafe int cautionThresholdPropertyId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_cautionThresholdPropertyId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_cautionThresholdPropertyId)) = value;
			}
		}

		// Token: 0x17004208 RID: 16904
		// (get) Token: 0x0600B917 RID: 47383 RVA: 0x002F60AC File Offset: 0x002F42AC
		// (set) Token: 0x0600B918 RID: 47384 RVA: 0x002F60D4 File Offset: 0x002F42D4
		public unsafe Color GoodColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_GoodColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_GoodColor)) = value;
			}
		}

		// Token: 0x17004209 RID: 16905
		// (get) Token: 0x0600B919 RID: 47385 RVA: 0x002F60F8 File Offset: 0x002F42F8
		// (set) Token: 0x0600B91A RID: 47386 RVA: 0x002F6120 File Offset: 0x002F4320
		public unsafe Color CautionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_CautionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_CautionColor)) = value;
			}
		}

		// Token: 0x1700420A RID: 16906
		// (get) Token: 0x0600B91B RID: 47387 RVA: 0x002F6144 File Offset: 0x002F4344
		// (set) Token: 0x0600B91C RID: 47388 RVA: 0x002F616C File Offset: 0x002F436C
		public unsafe Color CriticalColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_CriticalColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_CriticalColor)) = value;
			}
		}

		// Token: 0x1700420B RID: 16907
		// (get) Token: 0x0600B91D RID: 47389 RVA: 0x002F6190 File Offset: 0x002F4390
		// (set) Token: 0x0600B91E RID: 47390 RVA: 0x002F61B8 File Offset: 0x002F43B8
		public unsafe int goodColorPropertyId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_goodColorPropertyId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_goodColorPropertyId)) = value;
			}
		}

		// Token: 0x1700420C RID: 16908
		// (get) Token: 0x0600B91F RID: 47391 RVA: 0x002F61DC File Offset: 0x002F43DC
		// (set) Token: 0x0600B920 RID: 47392 RVA: 0x002F6204 File Offset: 0x002F4404
		public unsafe int cautionColorPropertyId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_cautionColorPropertyId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_cautionColorPropertyId)) = value;
			}
		}

		// Token: 0x1700420D RID: 16909
		// (get) Token: 0x0600B921 RID: 47393 RVA: 0x002F6228 File Offset: 0x002F4428
		// (set) Token: 0x0600B922 RID: 47394 RVA: 0x002F6250 File Offset: 0x002F4450
		public unsafe int criticalColorPropertyId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_criticalColorPropertyId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_criticalColorPropertyId)) = value;
			}
		}

		// Token: 0x040076C7 RID: 30407
		private static readonly IntPtr NativeFieldInfoPtr_ArrayMaxSizeFull;

		// Token: 0x040076C8 RID: 30408
		private static readonly IntPtr NativeFieldInfoPtr_ArrayMaxSizeLight;

		// Token: 0x040076C9 RID: 30409
		private static readonly IntPtr NativeFieldInfoPtr_ArrayMaxSize;

		// Token: 0x040076CA RID: 30410
		private static readonly IntPtr NativeFieldInfoPtr_Array;

		// Token: 0x040076CB RID: 30411
		private static readonly IntPtr NativeFieldInfoPtr_Image;

		// Token: 0x040076CC RID: 30412
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040076CD RID: 30413
		private static readonly IntPtr NativeFieldInfoPtr_Name_Length;

		// Token: 0x040076CE RID: 30414
		private static readonly IntPtr NativeFieldInfoPtr_Average;

		// Token: 0x040076CF RID: 30415
		private static readonly IntPtr NativeFieldInfoPtr_averagePropertyId;

		// Token: 0x040076D0 RID: 30416
		private static readonly IntPtr NativeFieldInfoPtr_GoodThreshold;

		// Token: 0x040076D1 RID: 30417
		private static readonly IntPtr NativeFieldInfoPtr_CautionThreshold;

		// Token: 0x040076D2 RID: 30418
		private static readonly IntPtr NativeFieldInfoPtr_goodThresholdPropertyId;

		// Token: 0x040076D3 RID: 30419
		private static readonly IntPtr NativeFieldInfoPtr_cautionThresholdPropertyId;

		// Token: 0x040076D4 RID: 30420
		private static readonly IntPtr NativeFieldInfoPtr_GoodColor;

		// Token: 0x040076D5 RID: 30421
		private static readonly IntPtr NativeFieldInfoPtr_CautionColor;

		// Token: 0x040076D6 RID: 30422
		private static readonly IntPtr NativeFieldInfoPtr_CriticalColor;

		// Token: 0x040076D7 RID: 30423
		private static readonly IntPtr NativeFieldInfoPtr_goodColorPropertyId;

		// Token: 0x040076D8 RID: 30424
		private static readonly IntPtr NativeFieldInfoPtr_cautionColorPropertyId;

		// Token: 0x040076D9 RID: 30425
		private static readonly IntPtr NativeFieldInfoPtr_criticalColorPropertyId;

		// Token: 0x040076DA RID: 30426
		private static readonly IntPtr NativeMethodInfoPtr_InitializeShader_Public_Void_0;

		// Token: 0x040076DB RID: 30427
		private static readonly IntPtr NativeMethodInfoPtr_UpdateArray_Public_Void_0;

		// Token: 0x040076DC RID: 30428
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAverage_Public_Void_0;

		// Token: 0x040076DD RID: 30429
		private static readonly IntPtr NativeMethodInfoPtr_UpdateThresholds_Public_Void_0;

		// Token: 0x040076DE RID: 30430
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColors_Public_Void_0;

		// Token: 0x040076DF RID: 30431
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePoints_Public_Void_0;

		// Token: 0x040076E0 RID: 30432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
