using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine.Rendering;

namespace Sigtrap.Editors.ShaderStripper
{
	// Token: 0x02000606 RID: 1542
	public class ShaderStripperSimple : ShaderStripperBase
	{
		// Token: 0x06007C65 RID: 31845 RVA: 0x001F3F3C File Offset: 0x001F213C
		[CallerCount(0)]
		public unsafe ShaderStripperSimple() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderStripperSimple>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderStripperSimple.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C66 RID: 31846 RVA: 0x001F3F88 File Offset: 0x001F2188
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderStripperSimple()
		{
			Il2CppClassPointerStore<ShaderStripperSimple>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Sigtrap.Editors.ShaderStripper", "ShaderStripperSimple");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderStripperSimple>.NativeClassPtr);
			ShaderStripperSimple.NativeFieldInfoPtr__blacklistedShaderNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperSimple>.NativeClassPtr, "_blacklistedShaderNames");
			ShaderStripperSimple.NativeFieldInfoPtr__blacklistedPassTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperSimple>.NativeClassPtr, "_blacklistedPassTypes");
			ShaderStripperSimple.NativeFieldInfoPtr__blacklistedKeywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperSimple>.NativeClassPtr, "_blacklistedKeywords");
			ShaderStripperSimple.NativeFieldInfoPtr__androidOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperSimple>.NativeClassPtr, "_androidOnly");
			ShaderStripperSimple.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderStripperSimple>.NativeClassPtr, 100673227);
		}

		// Token: 0x06007C67 RID: 31847 RVA: 0x001F2F7C File Offset: 0x001F117C
		public ShaderStripperSimple(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002C9D RID: 11421
		// (get) Token: 0x06007C68 RID: 31848 RVA: 0x001F401C File Offset: 0x001F221C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderStripperSimple>.NativeClassPtr));
			}
		}

		// Token: 0x17002C9E RID: 11422
		// (get) Token: 0x06007C69 RID: 31849 RVA: 0x001F4030 File Offset: 0x001F2230
		// (set) Token: 0x06007C6A RID: 31850 RVA: 0x001F4064 File Offset: 0x001F2264
		public unsafe List<ShaderStripperBase.StringMatch> _blacklistedShaderNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperSimple.NativeFieldInfoPtr__blacklistedShaderNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<ShaderStripperBase.StringMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperSimple.NativeFieldInfoPtr__blacklistedShaderNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C9F RID: 11423
		// (get) Token: 0x06007C6B RID: 31851 RVA: 0x001F408C File Offset: 0x001F228C
		// (set) Token: 0x06007C6C RID: 31852 RVA: 0x001F40C0 File Offset: 0x001F22C0
		public unsafe List<PassType> _blacklistedPassTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperSimple.NativeFieldInfoPtr__blacklistedPassTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<PassType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperSimple.NativeFieldInfoPtr__blacklistedPassTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA0 RID: 11424
		// (get) Token: 0x06007C6D RID: 31853 RVA: 0x001F40E8 File Offset: 0x001F22E8
		// (set) Token: 0x06007C6E RID: 31854 RVA: 0x001F411C File Offset: 0x001F231C
		public unsafe List<string> _blacklistedKeywords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperSimple.NativeFieldInfoPtr__blacklistedKeywords);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<string>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperSimple.NativeFieldInfoPtr__blacklistedKeywords), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CA1 RID: 11425
		// (get) Token: 0x06007C6F RID: 31855 RVA: 0x001F4144 File Offset: 0x001F2344
		// (set) Token: 0x06007C70 RID: 31856 RVA: 0x001F416C File Offset: 0x001F236C
		public unsafe bool _androidOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperSimple.NativeFieldInfoPtr__androidOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperSimple.NativeFieldInfoPtr__androidOnly)) = value;
			}
		}

		// Token: 0x04004FA5 RID: 20389
		private static readonly IntPtr NativeFieldInfoPtr__blacklistedShaderNames;

		// Token: 0x04004FA6 RID: 20390
		private static readonly IntPtr NativeFieldInfoPtr__blacklistedPassTypes;

		// Token: 0x04004FA7 RID: 20391
		private static readonly IntPtr NativeFieldInfoPtr__blacklistedKeywords;

		// Token: 0x04004FA8 RID: 20392
		private static readonly IntPtr NativeFieldInfoPtr__androidOnly;

		// Token: 0x04004FA9 RID: 20393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
