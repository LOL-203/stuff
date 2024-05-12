using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005DA RID: 1498
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		// Token: 0x060079E6 RID: 31206 RVA: 0x001EAAEC File Offset: 0x001E8CEC
		[CallerCount(0)]
		public unsafe HighlightNullAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079E7 RID: 31207 RVA: 0x001EAB37 File Offset: 0x001E8D37
		// Note: this type is marked as 'beforefieldinit'.
		static HighlightNullAttribute()
		{
			Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "HighlightNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr);
			HighlightNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr, 100673030);
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x0003500C File Offset: 0x0003320C
		public HighlightNullAttribute(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x060079E9 RID: 31209 RVA: 0x001EAB70 File Offset: 0x001E8D70
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr));
			}
		}

		// Token: 0x04004E13 RID: 19987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
