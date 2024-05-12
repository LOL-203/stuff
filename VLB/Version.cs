using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace VLB
{
	// Token: 0x020005F0 RID: 1520
	public static class Version : Object
	{
		// Token: 0x06007AC3 RID: 31427 RVA: 0x001ED9F6 File Offset: 0x001EBBF6
		// Note: this type is marked as 'beforefieldinit'.
		static Version()
		{
			Il2CppClassPointerStore<Version>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Version");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Version>.NativeClassPtr);
			Version.NativeFieldInfoPtr_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "Current");
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x00002988 File Offset: 0x00000B88
		public Version(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x06007AC5 RID: 31429 RVA: 0x001EDA2F File Offset: 0x001EBC2F
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Version>.NativeClassPtr));
			}
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x06007AC6 RID: 31430 RVA: 0x001EDA40 File Offset: 0x001EBC40
		// (set) Token: 0x06007AC7 RID: 31431 RVA: 0x001EDA5E File Offset: 0x001EBC5E
		public unsafe static int Current
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_Current, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_Current, (void*)(&value));
			}
		}

		// Token: 0x04004EA2 RID: 20130
		private static readonly IntPtr NativeFieldInfoPtr_Current;
	}
}
