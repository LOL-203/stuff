using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace VLB
{
	// Token: 0x020005DB RID: 1499
	public class MaterialKeywordSRP : Object
	{
		// Token: 0x060079EA RID: 31210 RVA: 0x001EAB84 File Offset: 0x001E8D84
		[CallerCount(0)]
		public unsafe MaterialKeywordSRP() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialKeywordSRP>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialKeywordSRP.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x001EABD0 File Offset: 0x001E8DD0
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialKeywordSRP()
		{
			Il2CppClassPointerStore<MaterialKeywordSRP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MaterialKeywordSRP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialKeywordSRP>.NativeClassPtr);
			MaterialKeywordSRP.NativeFieldInfoPtr_kKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialKeywordSRP>.NativeClassPtr, "kKeyword");
			MaterialKeywordSRP.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialKeywordSRP>.NativeClassPtr, 100673031);
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x00002988 File Offset: 0x00000B88
		public MaterialKeywordSRP(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x060079ED RID: 31213 RVA: 0x001EAC28 File Offset: 0x001E8E28
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MaterialKeywordSRP>.NativeClassPtr));
			}
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x060079EE RID: 31214 RVA: 0x001EAC3C File Offset: 0x001E8E3C
		// (set) Token: 0x060079EF RID: 31215 RVA: 0x001EAC5C File Offset: 0x001E8E5C
		public unsafe static string kKeyword
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(MaterialKeywordSRP.NativeFieldInfoPtr_kKeyword, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialKeywordSRP.NativeFieldInfoPtr_kKeyword, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004E14 RID: 19988
		private static readonly IntPtr NativeFieldInfoPtr_kKeyword;

		// Token: 0x04004E15 RID: 19989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
