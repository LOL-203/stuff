using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace ProCore.Decals
{
	// Token: 0x02000797 RID: 1943
	public static class qd_Const : Object
	{
		// Token: 0x0600A162 RID: 41314 RVA: 0x0028D8C0 File Offset: 0x0028BAC0
		// Note: this type is marked as 'beforefieldinit'.
		static qd_Const()
		{
			Il2CppClassPointerStore<qd_Const>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ProCore.Decals", "qd_Const");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<qd_Const>.NativeClassPtr);
			qd_Const.NativeFieldInfoPtr_ATLAS_SIZES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<qd_Const>.NativeClassPtr, "ATLAS_SIZES");
			qd_Const.NativeFieldInfoPtr_ATLAS_SIZES_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<qd_Const>.NativeClassPtr, "ATLAS_SIZES_STRING");
		}

		// Token: 0x0600A163 RID: 41315 RVA: 0x00002988 File Offset: 0x00000B88
		public qd_Const(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170039D8 RID: 14808
		// (get) Token: 0x0600A164 RID: 41316 RVA: 0x0028D918 File Offset: 0x0028BB18
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<qd_Const>.NativeClassPtr));
			}
		}

		// Token: 0x170039D9 RID: 14809
		// (get) Token: 0x0600A165 RID: 41317 RVA: 0x0028D92C File Offset: 0x0028BB2C
		// (set) Token: 0x0600A166 RID: 41318 RVA: 0x0028D957 File Offset: 0x0028BB57
		public unsafe static Il2CppStructArray<int> ATLAS_SIZES
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(qd_Const.NativeFieldInfoPtr_ATLAS_SIZES, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<int>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(qd_Const.NativeFieldInfoPtr_ATLAS_SIZES, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039DA RID: 14810
		// (get) Token: 0x0600A167 RID: 41319 RVA: 0x0028D96C File Offset: 0x0028BB6C
		// (set) Token: 0x0600A168 RID: 41320 RVA: 0x0028D997 File Offset: 0x0028BB97
		public unsafe static Il2CppStringArray ATLAS_SIZES_STRING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(qd_Const.NativeFieldInfoPtr_ATLAS_SIZES_STRING, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStringArray(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(qd_Const.NativeFieldInfoPtr_ATLAS_SIZES_STRING, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006694 RID: 26260
		private static readonly IntPtr NativeFieldInfoPtr_ATLAS_SIZES;

		// Token: 0x04006695 RID: 26261
		private static readonly IntPtr NativeFieldInfoPtr_ATLAS_SIZES_STRING;
	}
}
