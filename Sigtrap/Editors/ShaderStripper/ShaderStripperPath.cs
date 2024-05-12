using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace Sigtrap.Editors.ShaderStripper
{
	// Token: 0x02000604 RID: 1540
	public class ShaderStripperPath : ShaderStripperBase
	{
		// Token: 0x06007C59 RID: 31833 RVA: 0x001F3D24 File Offset: 0x001F1F24
		[CallerCount(0)]
		public unsafe ShaderStripperPath() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderStripperPath>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderStripperPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C5A RID: 31834 RVA: 0x001F3D70 File Offset: 0x001F1F70
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderStripperPath()
		{
			Il2CppClassPointerStore<ShaderStripperPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Sigtrap.Editors.ShaderStripper", "ShaderStripperPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderStripperPath>.NativeClassPtr);
			ShaderStripperPath.NativeFieldInfoPtr__pathBlacklist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderStripperPath>.NativeClassPtr, "_pathBlacklist");
			ShaderStripperPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderStripperPath>.NativeClassPtr, 100673225);
		}

		// Token: 0x06007C5B RID: 31835 RVA: 0x001F2F7C File Offset: 0x001F117C
		public ShaderStripperPath(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002C99 RID: 11417
		// (get) Token: 0x06007C5C RID: 31836 RVA: 0x001F3DC8 File Offset: 0x001F1FC8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ShaderStripperPath>.NativeClassPtr));
			}
		}

		// Token: 0x17002C9A RID: 11418
		// (get) Token: 0x06007C5D RID: 31837 RVA: 0x001F3DDC File Offset: 0x001F1FDC
		// (set) Token: 0x06007C5E RID: 31838 RVA: 0x001F3E10 File Offset: 0x001F2010
		public unsafe Il2CppReferenceArray<ShaderStripperBase.StringMatch> _pathBlacklist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperPath.NativeFieldInfoPtr__pathBlacklist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<ShaderStripperBase.StringMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderStripperPath.NativeFieldInfoPtr__pathBlacklist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FA1 RID: 20385
		private static readonly IntPtr NativeFieldInfoPtr__pathBlacklist;

		// Token: 0x04004FA2 RID: 20386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
