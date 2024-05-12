using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace UnitySA.Utility
{
	// Token: 0x02000622 RID: 1570
	[Serializable]
	public class CurveCtrlBob : Il2CppSystem.Object
	{
		// Token: 0x06007FA2 RID: 32674 RVA: 0x00203C44 File Offset: 0x00201E44
		[CallerCount(0)]
		public unsafe void Setup(Camera camera, float bobBaseInterval)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bobBaseInterval;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurveCtrlBob.NativeMethodInfoPtr_Setup_Public_Void_Camera_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FA3 RID: 32675 RVA: 0x00203CB0 File Offset: 0x00201EB0
		[CallerCount(0)]
		public unsafe Vector3 DoHeadBob(float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref speed;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CurveCtrlBob.NativeMethodInfoPtr_DoHeadBob_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x00203D14 File Offset: 0x00201F14
		[CallerCount(0)]
		public unsafe CurveCtrlBob() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurveCtrlBob.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FA5 RID: 32677 RVA: 0x00203D60 File Offset: 0x00201F60
		// Note: this type is marked as 'beforefieldinit'.
		static CurveCtrlBob()
		{
			Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnitySA.Utility", "CurveCtrlBob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr);
			CurveCtrlBob.NativeFieldInfoPtr_HorizontalBobRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "HorizontalBobRange");
			CurveCtrlBob.NativeFieldInfoPtr_VerticalBobRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "VerticalBobRange");
			CurveCtrlBob.NativeFieldInfoPtr_Bobcurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "Bobcurve");
			CurveCtrlBob.NativeFieldInfoPtr_VerticaltoHorizontalRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "VerticaltoHorizontalRatio");
			CurveCtrlBob.NativeFieldInfoPtr_m_CyclePositionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "m_CyclePositionX");
			CurveCtrlBob.NativeFieldInfoPtr_m_CyclePositionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "m_CyclePositionY");
			CurveCtrlBob.NativeFieldInfoPtr_m_BobBaseInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "m_BobBaseInterval");
			CurveCtrlBob.NativeFieldInfoPtr_m_OriginalCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "m_OriginalCameraPosition");
			CurveCtrlBob.NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "m_Time");
			CurveCtrlBob.NativeMethodInfoPtr_Setup_Public_Void_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, 100673598);
			CurveCtrlBob.NativeMethodInfoPtr_DoHeadBob_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, 100673599);
			CurveCtrlBob.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, 100673600);
		}

		// Token: 0x06007FA6 RID: 32678 RVA: 0x00002988 File Offset: 0x00000B88
		public CurveCtrlBob(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x06007FA7 RID: 32679 RVA: 0x00203E80 File Offset: 0x00202080
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr));
			}
		}

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x06007FA8 RID: 32680 RVA: 0x00203E94 File Offset: 0x00202094
		// (set) Token: 0x06007FA9 RID: 32681 RVA: 0x00203EBC File Offset: 0x002020BC
		public unsafe float HorizontalBobRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_HorizontalBobRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_HorizontalBobRange)) = value;
			}
		}

		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x06007FAA RID: 32682 RVA: 0x00203EE0 File Offset: 0x002020E0
		// (set) Token: 0x06007FAB RID: 32683 RVA: 0x00203F08 File Offset: 0x00202108
		public unsafe float VerticalBobRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_VerticalBobRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_VerticalBobRange)) = value;
			}
		}

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x06007FAC RID: 32684 RVA: 0x00203F2C File Offset: 0x0020212C
		// (set) Token: 0x06007FAD RID: 32685 RVA: 0x00203F60 File Offset: 0x00202160
		public unsafe AnimationCurve Bobcurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_Bobcurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AnimationCurve(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_Bobcurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x06007FAE RID: 32686 RVA: 0x00203F88 File Offset: 0x00202188
		// (set) Token: 0x06007FAF RID: 32687 RVA: 0x00203FB0 File Offset: 0x002021B0
		public unsafe float VerticaltoHorizontalRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_VerticaltoHorizontalRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_VerticaltoHorizontalRatio)) = value;
			}
		}

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x06007FB0 RID: 32688 RVA: 0x00203FD4 File Offset: 0x002021D4
		// (set) Token: 0x06007FB1 RID: 32689 RVA: 0x00203FFC File Offset: 0x002021FC
		public unsafe float m_CyclePositionX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_m_CyclePositionX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_m_CyclePositionX)) = value;
			}
		}

		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x06007FB2 RID: 32690 RVA: 0x00204020 File Offset: 0x00202220
		// (set) Token: 0x06007FB3 RID: 32691 RVA: 0x00204048 File Offset: 0x00202248
		public unsafe float m_CyclePositionY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_m_CyclePositionY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_m_CyclePositionY)) = value;
			}
		}

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x06007FB4 RID: 32692 RVA: 0x0020406C File Offset: 0x0020226C
		// (set) Token: 0x06007FB5 RID: 32693 RVA: 0x00204094 File Offset: 0x00202294
		public unsafe float m_BobBaseInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_m_BobBaseInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_m_BobBaseInterval)) = value;
			}
		}

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x06007FB6 RID: 32694 RVA: 0x002040B8 File Offset: 0x002022B8
		// (set) Token: 0x06007FB7 RID: 32695 RVA: 0x002040E0 File Offset: 0x002022E0
		public unsafe Vector3 m_OriginalCameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_m_OriginalCameraPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_m_OriginalCameraPosition)) = value;
			}
		}

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x06007FB8 RID: 32696 RVA: 0x00204104 File Offset: 0x00202304
		// (set) Token: 0x06007FB9 RID: 32697 RVA: 0x0020412C File Offset: 0x0020232C
		public unsafe float m_Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_m_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurveCtrlBob.NativeFieldInfoPtr_m_Time)) = value;
			}
		}

		// Token: 0x040051D8 RID: 20952
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalBobRange;

		// Token: 0x040051D9 RID: 20953
		private static readonly IntPtr NativeFieldInfoPtr_VerticalBobRange;

		// Token: 0x040051DA RID: 20954
		private static readonly IntPtr NativeFieldInfoPtr_Bobcurve;

		// Token: 0x040051DB RID: 20955
		private static readonly IntPtr NativeFieldInfoPtr_VerticaltoHorizontalRatio;

		// Token: 0x040051DC RID: 20956
		private static readonly IntPtr NativeFieldInfoPtr_m_CyclePositionX;

		// Token: 0x040051DD RID: 20957
		private static readonly IntPtr NativeFieldInfoPtr_m_CyclePositionY;

		// Token: 0x040051DE RID: 20958
		private static readonly IntPtr NativeFieldInfoPtr_m_BobBaseInterval;

		// Token: 0x040051DF RID: 20959
		private static readonly IntPtr NativeFieldInfoPtr_m_OriginalCameraPosition;

		// Token: 0x040051E0 RID: 20960
		private static readonly IntPtr NativeFieldInfoPtr_m_Time;

		// Token: 0x040051E1 RID: 20961
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_Camera_Single_0;

		// Token: 0x040051E2 RID: 20962
		private static readonly IntPtr NativeMethodInfoPtr_DoHeadBob_Public_Vector3_Single_0;

		// Token: 0x040051E3 RID: 20963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
