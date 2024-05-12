using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB_Samples
{
	// Token: 0x020005FA RID: 1530
	public class FreeCameraController : MonoBehaviour
	{
		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x06007BE6 RID: 31718 RVA: 0x001F250C File Offset: 0x001F070C
		// (set) Token: 0x06007BE7 RID: 31719 RVA: 0x001F255C File Offset: 0x001F075C
		public unsafe bool useMouseView
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FreeCameraController.NativeMethodInfoPtr_get_useMouseView_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCameraController.NativeMethodInfoPtr_set_useMouseView_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007BE8 RID: 31720 RVA: 0x001F25B0 File Offset: 0x001F07B0
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCameraController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BE9 RID: 31721 RVA: 0x001F25F4 File Offset: 0x001F07F4
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCameraController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BEA RID: 31722 RVA: 0x001F2638 File Offset: 0x001F0838
		[CallerCount(0)]
		public unsafe FreeCameraController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCameraController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BEB RID: 31723 RVA: 0x001F2684 File Offset: 0x001F0884
		// Note: this type is marked as 'beforefieldinit'.
		static FreeCameraController()
		{
			Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "FreeCameraController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr);
			FreeCameraController.NativeFieldInfoPtr_cameraSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "cameraSensitivity");
			FreeCameraController.NativeFieldInfoPtr_speedNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "speedNormal");
			FreeCameraController.NativeFieldInfoPtr_speedFactorSlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "speedFactorSlow");
			FreeCameraController.NativeFieldInfoPtr_speedFactorFast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "speedFactorFast");
			FreeCameraController.NativeFieldInfoPtr_speedClimb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "speedClimb");
			FreeCameraController.NativeFieldInfoPtr_rotationH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "rotationH");
			FreeCameraController.NativeFieldInfoPtr_rotationV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "rotationV");
			FreeCameraController.NativeFieldInfoPtr_m_UseMouseView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, "m_UseMouseView");
			FreeCameraController.NativeMethodInfoPtr_get_useMouseView_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, 100673202);
			FreeCameraController.NativeMethodInfoPtr_set_useMouseView_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, 100673203);
			FreeCameraController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, 100673204);
			FreeCameraController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, 100673205);
			FreeCameraController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr, 100673206);
		}

		// Token: 0x06007BEC RID: 31724 RVA: 0x0000210C File Offset: 0x0000030C
		public FreeCameraController(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002C6C RID: 11372
		// (get) Token: 0x06007BED RID: 31725 RVA: 0x001F27B8 File Offset: 0x001F09B8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FreeCameraController>.NativeClassPtr));
			}
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x06007BEE RID: 31726 RVA: 0x001F27CC File Offset: 0x001F09CC
		// (set) Token: 0x06007BEF RID: 31727 RVA: 0x001F27F4 File Offset: 0x001F09F4
		public unsafe float cameraSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_cameraSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_cameraSensitivity)) = value;
			}
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x06007BF0 RID: 31728 RVA: 0x001F2818 File Offset: 0x001F0A18
		// (set) Token: 0x06007BF1 RID: 31729 RVA: 0x001F2840 File Offset: 0x001F0A40
		public unsafe float speedNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedNormal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedNormal)) = value;
			}
		}

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x06007BF2 RID: 31730 RVA: 0x001F2864 File Offset: 0x001F0A64
		// (set) Token: 0x06007BF3 RID: 31731 RVA: 0x001F288C File Offset: 0x001F0A8C
		public unsafe float speedFactorSlow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedFactorSlow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedFactorSlow)) = value;
			}
		}

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x06007BF4 RID: 31732 RVA: 0x001F28B0 File Offset: 0x001F0AB0
		// (set) Token: 0x06007BF5 RID: 31733 RVA: 0x001F28D8 File Offset: 0x001F0AD8
		public unsafe float speedFactorFast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedFactorFast);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedFactorFast)) = value;
			}
		}

		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x06007BF6 RID: 31734 RVA: 0x001F28FC File Offset: 0x001F0AFC
		// (set) Token: 0x06007BF7 RID: 31735 RVA: 0x001F2924 File Offset: 0x001F0B24
		public unsafe float speedClimb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedClimb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_speedClimb)) = value;
			}
		}

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x06007BF8 RID: 31736 RVA: 0x001F2948 File Offset: 0x001F0B48
		// (set) Token: 0x06007BF9 RID: 31737 RVA: 0x001F2970 File Offset: 0x001F0B70
		public unsafe float rotationH
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_rotationH);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_rotationH)) = value;
			}
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x06007BFA RID: 31738 RVA: 0x001F2994 File Offset: 0x001F0B94
		// (set) Token: 0x06007BFB RID: 31739 RVA: 0x001F29BC File Offset: 0x001F0BBC
		public unsafe float rotationV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_rotationV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_rotationV)) = value;
			}
		}

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x06007BFC RID: 31740 RVA: 0x001F29E0 File Offset: 0x001F0BE0
		// (set) Token: 0x06007BFD RID: 31741 RVA: 0x001F2A08 File Offset: 0x001F0C08
		public unsafe bool m_UseMouseView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_m_UseMouseView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCameraController.NativeFieldInfoPtr_m_UseMouseView)) = value;
			}
		}

		// Token: 0x04004F5E RID: 20318
		private static readonly IntPtr NativeFieldInfoPtr_cameraSensitivity;

		// Token: 0x04004F5F RID: 20319
		private static readonly IntPtr NativeFieldInfoPtr_speedNormal;

		// Token: 0x04004F60 RID: 20320
		private static readonly IntPtr NativeFieldInfoPtr_speedFactorSlow;

		// Token: 0x04004F61 RID: 20321
		private static readonly IntPtr NativeFieldInfoPtr_speedFactorFast;

		// Token: 0x04004F62 RID: 20322
		private static readonly IntPtr NativeFieldInfoPtr_speedClimb;

		// Token: 0x04004F63 RID: 20323
		private static readonly IntPtr NativeFieldInfoPtr_rotationH;

		// Token: 0x04004F64 RID: 20324
		private static readonly IntPtr NativeFieldInfoPtr_rotationV;

		// Token: 0x04004F65 RID: 20325
		private static readonly IntPtr NativeFieldInfoPtr_m_UseMouseView;

		// Token: 0x04004F66 RID: 20326
		private static readonly IntPtr NativeMethodInfoPtr_get_useMouseView_Private_get_Boolean_0;

		// Token: 0x04004F67 RID: 20327
		private static readonly IntPtr NativeMethodInfoPtr_set_useMouseView_Private_set_Void_Boolean_0;

		// Token: 0x04004F68 RID: 20328
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004F69 RID: 20329
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004F6A RID: 20330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
