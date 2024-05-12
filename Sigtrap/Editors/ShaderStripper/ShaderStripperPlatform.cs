using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace Sigtrap.Editors.ShaderStripper
{
	// Token: 0x02000605 RID: 1541
	public class ShaderStripperPlatform : ShaderStripperBase
	{
		// Token: 0x06007C5F RID: 31839 RVA: 0x001F3E38 File Offset: 0x001F2038
		[CallerCount(0)]
		public unsafe ShaderStripperPlatform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderStripperPlatform>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderStripperPlatform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C60 RID: 31840 RVA: 0x001F3E84 File Offset: 0x001F2084
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderStripperPlatform()
		{
			Il2CppClassPointerStore<ShaderStripperPlatform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Sigtrap.Editors.ShaderStripper", "ShaderStripperPlatform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderStripperPlatform>.NativeClassPtr);
			ShaderStripperPlatform.NativeFieldInfoPtr__whitelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperPlatform>.NativeClassPtr, "_whitelist");
			ShaderStripperPlatform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderStripperPlatform>.NativeClassPtr, 100673226);
		}

		// Token: 0x06007C61 RID: 31841 RVA: 0x001F2F7C File Offset: 0x001F117C
		public ShaderStripperPlatform(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002C9B RID: 11419
		// (get) Token: 0x06007C62 RID: 31842 RVA: 0x001F3EDC File Offset: 0x001F20DC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderStripperPlatform>.NativeClassPtr));
			}
		}

		// Token: 0x17002C9C RID: 11420
		// (get) Token: 0x06007C63 RID: 31843 RVA: 0x001F3EF0 File Offset: 0x001F20F0
		// (set) Token: 0x06007C64 RID: 31844 RVA: 0x001F3F18 File Offset: 0x001F2118
		public unsafe bool _whitelist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperPlatform.NativeFieldInfoPtr__whitelist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperPlatform.NativeFieldInfoPtr__whitelist)) = value;
			}
		}

		// Token: 0x04004FA3 RID: 20387
		private static readonly IntPtr NativeFieldInfoPtr__whitelist;

		// Token: 0x04004FA4 RID: 20388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
