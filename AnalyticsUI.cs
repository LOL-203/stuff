using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x0200005C RID: 92
public class AnalyticsUI : MonoBehaviour
{
	// Token: 0x060005C2 RID: 1474 RVA: 0x000195EC File Offset: 0x000177EC
	[CallerCount(0)]
	public unsafe AnalyticsUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsUI>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060005C3 RID: 1475 RVA: 0x00019637 File Offset: 0x00017837
	// Note: this type is marked as 'beforefieldinit'.
	static AnalyticsUI()
	{
		Il2CppClassPointerStore<AnalyticsUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AnalyticsUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsUI>.NativeClassPtr);
		AnalyticsUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsUI>.NativeClassPtr, 100663795);
	}

	// Token: 0x060005C4 RID: 1476 RVA: 0x0000210C File Offset: 0x0000030C
	public AnalyticsUI(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00019670 File Offset: 0x00017870
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AnalyticsUI>.NativeClassPtr));
		}
	}

	// Token: 0x040003A3 RID: 931
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
