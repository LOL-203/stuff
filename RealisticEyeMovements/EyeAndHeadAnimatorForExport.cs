using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace RealisticEyeMovements
{
	// Token: 0x02000781 RID: 1921
	[Serializable]
	public class EyeAndHeadAnimatorForExport : Object
	{
		// Token: 0x06009EF3 RID: 40691 RVA: 0x00284740 File Offset: 0x00282940
		[CallerCount(0)]
		public unsafe EyeAndHeadAnimatorForExport() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeAndHeadAnimatorForExport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x0028478C File Offset: 0x0028298C
		// Note: this type is marked as 'beforefieldinit'.
		static EyeAndHeadAnimatorForExport()
		{
			Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RealisticEyeMovements", "EyeAndHeadAnimatorForExport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr);
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_headBonePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "headBonePath");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_headSpeedModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "headSpeedModifier");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_headWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "headWeight");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_useMicroSaccades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "useMicroSaccades");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_useMacroSaccades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "useMacroSaccades");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_kDrawSightlinesInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "kDrawSightlinesInEditor");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_controlData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "controlData");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_kMinNextBlinkTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "kMinNextBlinkTime");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_kMaxNextBlinkTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "kMaxNextBlinkTime");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_eyelidsFollowEyesVertically = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "eyelidsFollowEyesVertically");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_maxEyeHorizAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "maxEyeHorizAngle");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_maxEyeHorizAngleTowardsNose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "maxEyeHorizAngleTowardsNose");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_crossEyeCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "crossEyeCorrection");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_nervousness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "nervousness");
			EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_limitHeadAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, "limitHeadAngle");
			EyeAndHeadAnimatorForExport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr, 100675969);
		}

		// Token: 0x06009EF5 RID: 40693 RVA: 0x00002988 File Offset: 0x00000B88
		public EyeAndHeadAnimatorForExport(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x06009EF6 RID: 40694 RVA: 0x002848FC File Offset: 0x00282AFC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EyeAndHeadAnimatorForExport>.NativeClassPtr));
			}
		}

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x06009EF7 RID: 40695 RVA: 0x00284910 File Offset: 0x00282B10
		// (set) Token: 0x06009EF8 RID: 40696 RVA: 0x00284939 File Offset: 0x00282B39
		public unsafe string headBonePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_headBonePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_headBonePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x06009EF9 RID: 40697 RVA: 0x00284960 File Offset: 0x00282B60
		// (set) Token: 0x06009EFA RID: 40698 RVA: 0x00284988 File Offset: 0x00282B88
		public unsafe float headSpeedModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_headSpeedModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_headSpeedModifier)) = value;
			}
		}

		// Token: 0x170038E8 RID: 14568
		// (get) Token: 0x06009EFB RID: 40699 RVA: 0x002849AC File Offset: 0x00282BAC
		// (set) Token: 0x06009EFC RID: 40700 RVA: 0x002849D4 File Offset: 0x00282BD4
		public unsafe float headWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_headWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_headWeight)) = value;
			}
		}

		// Token: 0x170038E9 RID: 14569
		// (get) Token: 0x06009EFD RID: 40701 RVA: 0x002849F8 File Offset: 0x00282BF8
		// (set) Token: 0x06009EFE RID: 40702 RVA: 0x00284A20 File Offset: 0x00282C20
		public unsafe bool useMicroSaccades
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_useMicroSaccades);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_useMicroSaccades)) = value;
			}
		}

		// Token: 0x170038EA RID: 14570
		// (get) Token: 0x06009EFF RID: 40703 RVA: 0x00284A44 File Offset: 0x00282C44
		// (set) Token: 0x06009F00 RID: 40704 RVA: 0x00284A6C File Offset: 0x00282C6C
		public unsafe bool useMacroSaccades
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_useMacroSaccades);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_useMacroSaccades)) = value;
			}
		}

		// Token: 0x170038EB RID: 14571
		// (get) Token: 0x06009F01 RID: 40705 RVA: 0x00284A90 File Offset: 0x00282C90
		// (set) Token: 0x06009F02 RID: 40706 RVA: 0x00284AB8 File Offset: 0x00282CB8
		public unsafe bool kDrawSightlinesInEditor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_kDrawSightlinesInEditor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_kDrawSightlinesInEditor)) = value;
			}
		}

		// Token: 0x170038EC RID: 14572
		// (get) Token: 0x06009F03 RID: 40707 RVA: 0x00284ADC File Offset: 0x00282CDC
		// (set) Token: 0x06009F04 RID: 40708 RVA: 0x00284B10 File Offset: 0x00282D10
		public unsafe ControlData.ControlDataForExport controlData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_controlData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new ControlData.ControlDataForExport(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_controlData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038ED RID: 14573
		// (get) Token: 0x06009F05 RID: 40709 RVA: 0x00284B38 File Offset: 0x00282D38
		// (set) Token: 0x06009F06 RID: 40710 RVA: 0x00284B60 File Offset: 0x00282D60
		public unsafe float kMinNextBlinkTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_kMinNextBlinkTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_kMinNextBlinkTime)) = value;
			}
		}

		// Token: 0x170038EE RID: 14574
		// (get) Token: 0x06009F07 RID: 40711 RVA: 0x00284B84 File Offset: 0x00282D84
		// (set) Token: 0x06009F08 RID: 40712 RVA: 0x00284BAC File Offset: 0x00282DAC
		public unsafe float kMaxNextBlinkTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_kMaxNextBlinkTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_kMaxNextBlinkTime)) = value;
			}
		}

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x06009F09 RID: 40713 RVA: 0x00284BD0 File Offset: 0x00282DD0
		// (set) Token: 0x06009F0A RID: 40714 RVA: 0x00284BF8 File Offset: 0x00282DF8
		public unsafe bool eyelidsFollowEyesVertically
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_eyelidsFollowEyesVertically);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_eyelidsFollowEyesVertically)) = value;
			}
		}

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x06009F0B RID: 40715 RVA: 0x00284C1C File Offset: 0x00282E1C
		// (set) Token: 0x06009F0C RID: 40716 RVA: 0x00284C44 File Offset: 0x00282E44
		public unsafe float maxEyeHorizAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_maxEyeHorizAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_maxEyeHorizAngle)) = value;
			}
		}

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x06009F0D RID: 40717 RVA: 0x00284C68 File Offset: 0x00282E68
		// (set) Token: 0x06009F0E RID: 40718 RVA: 0x00284C90 File Offset: 0x00282E90
		public unsafe float maxEyeHorizAngleTowardsNose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_maxEyeHorizAngleTowardsNose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_maxEyeHorizAngleTowardsNose)) = value;
			}
		}

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x06009F0F RID: 40719 RVA: 0x00284CB4 File Offset: 0x00282EB4
		// (set) Token: 0x06009F10 RID: 40720 RVA: 0x00284CDC File Offset: 0x00282EDC
		public unsafe float crossEyeCorrection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_crossEyeCorrection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_crossEyeCorrection)) = value;
			}
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x06009F11 RID: 40721 RVA: 0x00284D00 File Offset: 0x00282F00
		// (set) Token: 0x06009F12 RID: 40722 RVA: 0x00284D28 File Offset: 0x00282F28
		public unsafe float nervousness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_nervousness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_nervousness)) = value;
			}
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x06009F13 RID: 40723 RVA: 0x00284D4C File Offset: 0x00282F4C
		// (set) Token: 0x06009F14 RID: 40724 RVA: 0x00284D74 File Offset: 0x00282F74
		public unsafe float limitHeadAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_limitHeadAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EyeAndHeadAnimatorForExport.NativeFieldInfoPtr_limitHeadAngle)) = value;
			}
		}

		// Token: 0x040064F6 RID: 25846
		private static readonly IntPtr NativeFieldInfoPtr_headBonePath;

		// Token: 0x040064F7 RID: 25847
		private static readonly IntPtr NativeFieldInfoPtr_headSpeedModifier;

		// Token: 0x040064F8 RID: 25848
		private static readonly IntPtr NativeFieldInfoPtr_headWeight;

		// Token: 0x040064F9 RID: 25849
		private static readonly IntPtr NativeFieldInfoPtr_useMicroSaccades;

		// Token: 0x040064FA RID: 25850
		private static readonly IntPtr NativeFieldInfoPtr_useMacroSaccades;

		// Token: 0x040064FB RID: 25851
		private static readonly IntPtr NativeFieldInfoPtr_kDrawSightlinesInEditor;

		// Token: 0x040064FC RID: 25852
		private static readonly IntPtr NativeFieldInfoPtr_controlData;

		// Token: 0x040064FD RID: 25853
		private static readonly IntPtr NativeFieldInfoPtr_kMinNextBlinkTime;

		// Token: 0x040064FE RID: 25854
		private static readonly IntPtr NativeFieldInfoPtr_kMaxNextBlinkTime;

		// Token: 0x040064FF RID: 25855
		private static readonly IntPtr NativeFieldInfoPtr_eyelidsFollowEyesVertically;

		// Token: 0x04006500 RID: 25856
		private static readonly IntPtr NativeFieldInfoPtr_maxEyeHorizAngle;

		// Token: 0x04006501 RID: 25857
		private static readonly IntPtr NativeFieldInfoPtr_maxEyeHorizAngleTowardsNose;

		// Token: 0x04006502 RID: 25858
		private static readonly IntPtr NativeFieldInfoPtr_crossEyeCorrection;

		// Token: 0x04006503 RID: 25859
		private static readonly IntPtr NativeFieldInfoPtr_nervousness;

		// Token: 0x04006504 RID: 25860
		private static readonly IntPtr NativeFieldInfoPtr_limitHeadAngle;

		// Token: 0x04006505 RID: 25861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
