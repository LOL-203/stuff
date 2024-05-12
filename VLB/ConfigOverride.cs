using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VLB
{
	// Token: 0x020005C5 RID: 1477
	public class ConfigOverride : Config
	{
		// Token: 0x06007890 RID: 30864 RVA: 0x001E662C File Offset: 0x001E482C
		[CallerCount(0)]
		public unsafe ConfigOverride() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigOverride>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x001E6678 File Offset: 0x001E4878
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigOverride()
		{
			Il2CppClassPointerStore<ConfigOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "ConfigOverride");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigOverride>.NativeClassPtr);
			ConfigOverride.NativeFieldInfoPtr_kAssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigOverride>.NativeClassPtr, "kAssetName");
			ConfigOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigOverride>.NativeClassPtr, 100672952);
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x001E66D0 File Offset: 0x001E48D0
		public ConfigOverride(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x06007893 RID: 30867 RVA: 0x001E66D9 File Offset: 0x001E48D9
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ConfigOverride>.NativeClassPtr));
			}
		}

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x06007894 RID: 30868 RVA: 0x001E66EC File Offset: 0x001E48EC
		// (set) Token: 0x06007895 RID: 30869 RVA: 0x001E670C File Offset: 0x001E490C
		public new unsafe static string kAssetName
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(ConfigOverride.NativeFieldInfoPtr_kAssetName, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfigOverride.NativeFieldInfoPtr_kAssetName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004D24 RID: 19748
		private static readonly IntPtr NativeFieldInfoPtr_kAssetName;

		// Token: 0x04004D25 RID: 19749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
