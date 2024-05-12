using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace Tayx.Graphy.Ram
{
	// Token: 0x020008E6 RID: 2278
	public class G_RamMonitor : MonoBehaviour
	{
		// Token: 0x17004242 RID: 16962
		// (get) Token: 0x0600B9A7 RID: 47527 RVA: 0x002F82A0 File Offset: 0x002F64A0
		public unsafe float AllocatedRam
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_RamMonitor.NativeMethodInfoPtr_get_AllocatedRam_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17004243 RID: 16963
		// (get) Token: 0x0600B9A8 RID: 47528 RVA: 0x002F82F0 File Offset: 0x002F64F0
		public unsafe float ReservedRam
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_RamMonitor.NativeMethodInfoPtr_get_ReservedRam_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17004244 RID: 16964
		// (get) Token: 0x0600B9A9 RID: 47529 RVA: 0x002F8340 File Offset: 0x002F6540
		public unsafe float MonoRam
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(G_RamMonitor.NativeMethodInfoPtr_get_MonoRam_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600B9AA RID: 47530 RVA: 0x002F8390 File Offset: 0x002F6590
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamMonitor.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9AB RID: 47531 RVA: 0x002F83D4 File Offset: 0x002F65D4
		[CallerCount(0)]
		public unsafe G_RamMonitor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(G_RamMonitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9AC RID: 47532 RVA: 0x002F8420 File Offset: 0x002F6620
		// Note: this type is marked as 'beforefieldinit'.
		static G_RamMonitor()
		{
			Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.Ram", "G_RamMonitor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr);
			G_RamMonitor.NativeFieldInfoPtr_m_allocatedRam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, "m_allocatedRam");
			G_RamMonitor.NativeFieldInfoPtr_m_reservedRam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, "m_reservedRam");
			G_RamMonitor.NativeFieldInfoPtr_m_monoRam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, "m_monoRam");
			G_RamMonitor.NativeMethodInfoPtr_get_AllocatedRam_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, 100678424);
			G_RamMonitor.NativeMethodInfoPtr_get_ReservedRam_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, 100678425);
			G_RamMonitor.NativeMethodInfoPtr_get_MonoRam_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, 100678426);
			G_RamMonitor.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, 100678427);
			G_RamMonitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, 100678428);
		}

		// Token: 0x0600B9AD RID: 47533 RVA: 0x0000210C File Offset: 0x0000030C
		public G_RamMonitor(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700423E RID: 16958
		// (get) Token: 0x0600B9AE RID: 47534 RVA: 0x002F84F0 File Offset: 0x002F66F0
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr));
			}
		}

		// Token: 0x1700423F RID: 16959
		// (get) Token: 0x0600B9AF RID: 47535 RVA: 0x002F8504 File Offset: 0x002F6704
		// (set) Token: 0x0600B9B0 RID: 47536 RVA: 0x002F852C File Offset: 0x002F672C
		public unsafe float m_allocatedRam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamMonitor.NativeFieldInfoPtr_m_allocatedRam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamMonitor.NativeFieldInfoPtr_m_allocatedRam)) = value;
			}
		}

		// Token: 0x17004240 RID: 16960
		// (get) Token: 0x0600B9B1 RID: 47537 RVA: 0x002F8550 File Offset: 0x002F6750
		// (set) Token: 0x0600B9B2 RID: 47538 RVA: 0x002F8578 File Offset: 0x002F6778
		public unsafe float m_reservedRam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamMonitor.NativeFieldInfoPtr_m_reservedRam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamMonitor.NativeFieldInfoPtr_m_reservedRam)) = value;
			}
		}

		// Token: 0x17004241 RID: 16961
		// (get) Token: 0x0600B9B3 RID: 47539 RVA: 0x002F859C File Offset: 0x002F679C
		// (set) Token: 0x0600B9B4 RID: 47540 RVA: 0x002F85C4 File Offset: 0x002F67C4
		public unsafe float m_monoRam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamMonitor.NativeFieldInfoPtr_m_monoRam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(G_RamMonitor.NativeFieldInfoPtr_m_monoRam)) = value;
			}
		}

		// Token: 0x0400772C RID: 30508
		private static readonly IntPtr NativeFieldInfoPtr_m_allocatedRam;

		// Token: 0x0400772D RID: 30509
		private static readonly IntPtr NativeFieldInfoPtr_m_reservedRam;

		// Token: 0x0400772E RID: 30510
		private static readonly IntPtr NativeFieldInfoPtr_m_monoRam;

		// Token: 0x0400772F RID: 30511
		private static readonly IntPtr NativeMethodInfoPtr_get_AllocatedRam_Public_get_Single_0;

		// Token: 0x04007730 RID: 30512
		private static readonly IntPtr NativeMethodInfoPtr_get_ReservedRam_Public_get_Single_0;

		// Token: 0x04007731 RID: 30513
		private static readonly IntPtr NativeMethodInfoPtr_get_MonoRam_Public_get_Single_0;

		// Token: 0x04007732 RID: 30514
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007733 RID: 30515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
