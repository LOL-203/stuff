using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB_Samples
{
	// Token: 0x020005F7 RID: 1527
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		// Token: 0x06007BCC RID: 31692 RVA: 0x001F1F58 File Offset: 0x001F0158
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraToggleBeamVisibility.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BCD RID: 31693 RVA: 0x001F1F9C File Offset: 0x001F019C
		[CallerCount(0)]
		public unsafe CameraToggleBeamVisibility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraToggleBeamVisibility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BCE RID: 31694 RVA: 0x001F1FE8 File Offset: 0x001F01E8
		// Note: this type is marked as 'beforefieldinit'.
		static CameraToggleBeamVisibility()
		{
			Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "CameraToggleBeamVisibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr);
			CameraToggleBeamVisibility.NativeFieldInfoPtr_m_KeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr, "m_KeyCode");
			CameraToggleBeamVisibility.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr, 100673193);
			CameraToggleBeamVisibility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr, 100673194);
		}

		// Token: 0x06007BCF RID: 31695 RVA: 0x0000210C File Offset: 0x0000030C
		public CameraToggleBeamVisibility(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002C65 RID: 11365
		// (get) Token: 0x06007BD0 RID: 31696 RVA: 0x001F2054 File Offset: 0x001F0254
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CameraToggleBeamVisibility>.NativeClassPtr));
			}
		}

		// Token: 0x17002C66 RID: 11366
		// (get) Token: 0x06007BD1 RID: 31697 RVA: 0x001F2068 File Offset: 0x001F0268
		// (set) Token: 0x06007BD2 RID: 31698 RVA: 0x001F2090 File Offset: 0x001F0290
		public unsafe KeyCode m_KeyCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraToggleBeamVisibility.NativeFieldInfoPtr_m_KeyCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraToggleBeamVisibility.NativeFieldInfoPtr_m_KeyCode)) = value;
			}
		}

		// Token: 0x04004F51 RID: 20305
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyCode;

		// Token: 0x04004F52 RID: 20306
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004F53 RID: 20307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
