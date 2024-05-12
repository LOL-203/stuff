using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x02000780 RID: 1920
	public class DestroyNotifier : MonoBehaviour
	{
		// Token: 0x06009EEA RID: 40682 RVA: 0x002844F4 File Offset: 0x002826F4
		[CallerCount(0)]
		public unsafe void add_OnDestroyedEvent(Action<DestroyNotifier> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyNotifier.NativeMethodInfoPtr_add_OnDestroyedEvent_Public_add_Void_Action_1_DestroyNotifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EEB RID: 40683 RVA: 0x00284550 File Offset: 0x00282750
		[CallerCount(0)]
		public unsafe void remove_OnDestroyedEvent(Action<DestroyNotifier> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyNotifier.NativeMethodInfoPtr_remove_OnDestroyedEvent_Public_rem_Void_Action_1_DestroyNotifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EEC RID: 40684 RVA: 0x002845AC File Offset: 0x002827AC
		[CallerCount(0)]
		public unsafe void OnDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyNotifier.NativeMethodInfoPtr_OnDestroyed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EED RID: 40685 RVA: 0x002845F0 File Offset: 0x002827F0
		[CallerCount(0)]
		public unsafe DestroyNotifier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyNotifier>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyNotifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009EEE RID: 40686 RVA: 0x0028463C File Offset: 0x0028283C
		// Note: this type is marked as 'beforefieldinit'.
		static DestroyNotifier()
		{
			Il2CppClassPointerStore<DestroyNotifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RealisticEyeMovements", "DestroyNotifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyNotifier>.NativeClassPtr);
			DestroyNotifier.NativeFieldInfoPtr_OnDestroyedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyNotifier>.NativeClassPtr, "OnDestroyedEvent");
			DestroyNotifier.NativeMethodInfoPtr_add_OnDestroyedEvent_Public_add_Void_Action_1_DestroyNotifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyNotifier>.NativeClassPtr, 100675965);
			DestroyNotifier.NativeMethodInfoPtr_remove_OnDestroyedEvent_Public_rem_Void_Action_1_DestroyNotifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyNotifier>.NativeClassPtr, 100675966);
			DestroyNotifier.NativeMethodInfoPtr_OnDestroyed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyNotifier>.NativeClassPtr, 100675967);
			DestroyNotifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyNotifier>.NativeClassPtr, 100675968);
		}

		// Token: 0x06009EEF RID: 40687 RVA: 0x0000210C File Offset: 0x0000030C
		public DestroyNotifier(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170038E3 RID: 14563
		// (get) Token: 0x06009EF0 RID: 40688 RVA: 0x002846D0 File Offset: 0x002828D0
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DestroyNotifier>.NativeClassPtr));
			}
		}

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x06009EF1 RID: 40689 RVA: 0x002846E4 File Offset: 0x002828E4
		// (set) Token: 0x06009EF2 RID: 40690 RVA: 0x00284718 File Offset: 0x00282918
		public unsafe Action<DestroyNotifier> OnDestroyedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyNotifier.NativeFieldInfoPtr_OnDestroyedEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Action<DestroyNotifier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyNotifier.NativeFieldInfoPtr_OnDestroyedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040064F1 RID: 25841
		private static readonly IntPtr NativeFieldInfoPtr_OnDestroyedEvent;

		// Token: 0x040064F2 RID: 25842
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDestroyedEvent_Public_add_Void_Action_1_DestroyNotifier_0;

		// Token: 0x040064F3 RID: 25843
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDestroyedEvent_Public_rem_Void_Action_1_DestroyNotifier_0;

		// Token: 0x040064F4 RID: 25844
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroyed_Private_Void_0;

		// Token: 0x040064F5 RID: 25845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
