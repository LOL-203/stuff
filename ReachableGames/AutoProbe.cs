using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace ReachableGames
{
	// Token: 0x0200078F RID: 1935
	public class AutoProbe : MonoBehaviour
	{
		// Token: 0x0600A10B RID: 41227 RVA: 0x0028C410 File Offset: 0x0028A610
		[CallerCount(0)]
		public unsafe AutoProbe() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoProbe>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoProbe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A10C RID: 41228 RVA: 0x0028C45B File Offset: 0x0028A65B
		// Note: this type is marked as 'beforefieldinit'.
		static AutoProbe()
		{
			Il2CppClassPointerStore<AutoProbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ReachableGames", "AutoProbe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoProbe>.NativeClassPtr);
			AutoProbe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoProbe>.NativeClassPtr, 100676086);
		}

		// Token: 0x0600A10D RID: 41229 RVA: 0x0000210C File Offset: 0x0000030C
		public AutoProbe(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170039B9 RID: 14777
		// (get) Token: 0x0600A10E RID: 41230 RVA: 0x0028C494 File Offset: 0x0028A694
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AutoProbe>.NativeClassPtr));
			}
		}

		// Token: 0x04006660 RID: 26208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
