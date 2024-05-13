using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.AISystems
{
	// Token: 0x02001180 RID: 4480
	public class AI_SuppressionAlert : AIState
	{
		// Token: 0x06014D5B RID: 85339 RVA: 0x0053D388 File Offset: 0x0053B588
		[CallerCount(0)]
		public new unsafe void Enter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AI_SuppressionAlert.NativeMethodInfoPtr_Enter_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014D5C RID: 85340 RVA: 0x0053D3D8 File Offset: 0x0053B5D8
		[CallerCount(0)]
		public unsafe AI_SuppressionAlert() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AI_SuppressionAlert>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AI_SuppressionAlert.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06014D5D RID: 85341 RVA: 0x0053D424 File Offset: 0x0053B624
		// Note: this type is marked as 'beforefieldinit'.
		static AI_SuppressionAlert()
		{
			Il2CppClassPointerStore<AI_SuppressionAlert>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.AISystems", "AI_SuppressionAlert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AI_SuppressionAlert>.NativeClassPtr);
			AI_SuppressionAlert.NativeMethodInfoPtr_Enter_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI_SuppressionAlert>.NativeClassPtr, 100689859);
			AI_SuppressionAlert.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI_SuppressionAlert>.NativeClassPtr, 100689860);
		}

		// Token: 0x06014D5E RID: 85342 RVA: 0x00535C60 File Offset: 0x00533E60
		public AI_SuppressionAlert(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170075E1 RID: 30177
		// (get) Token: 0x06014D5F RID: 85343 RVA: 0x0053D47C File Offset: 0x0053B67C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AI_SuppressionAlert>.NativeClassPtr));
			}
		}

		// Token: 0x0400D4D7 RID: 54487
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Virtual_Void_0;

		// Token: 0x0400D4D8 RID: 54488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
