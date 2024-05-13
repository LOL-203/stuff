using System;
using AK.Wwise;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Pickups
{
	// Token: 0x020010BF RID: 4287
	public class HardDriveBeep : MonoBehaviour
	{
		// Token: 0x170072AC RID: 29356
		// (get) Token: 0x060143CB RID: 82891 RVA: 0x00517204 File Offset: 0x00515404
		// (set) Token: 0x060143CC RID: 82892 RVA: 0x00517254 File Offset: 0x00515454
		public unsafe bool ManagedUpdateRemoval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HardDriveBeep.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardDriveBeep.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060143CD RID: 82893 RVA: 0x005172A8 File Offset: 0x005154A8
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardDriveBeep.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060143CE RID: 82894 RVA: 0x005172EC File Offset: 0x005154EC
		[CallerCount(0)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardDriveBeep.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060143CF RID: 82895 RVA: 0x00517330 File Offset: 0x00515530
		[CallerCount(0)]
		public unsafe void OnManagedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardDriveBeep.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060143D0 RID: 82896 RVA: 0x00517374 File Offset: 0x00515574
		[CallerCount(0)]
		public unsafe int GetCurrentCycle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HardDriveBeep.NativeMethodInfoPtr_GetCurrentCycle_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060143D1 RID: 82897 RVA: 0x005173C4 File Offset: 0x005155C4
		[CallerCount(0)]
		public unsafe void PlayBeep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardDriveBeep.NativeMethodInfoPtr_PlayBeep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060143D2 RID: 82898 RVA: 0x00517408 File Offset: 0x00515608
		[CallerCount(0)]
		public unsafe HardDriveBeep() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardDriveBeep.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060143D3 RID: 82899 RVA: 0x00517454 File Offset: 0x00515654
		// Note: this type is marked as 'beforefieldinit'.
		static HardDriveBeep()
		{
			Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Pickups", "HardDriveBeep");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr);
			HardDriveBeep.NativeFieldInfoPtr_Pickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, "Pickup");
			HardDriveBeep.NativeFieldInfoPtr_BeepSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, "BeepSoundEvent");
			HardDriveBeep.NativeFieldInfoPtr_CycleLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, "CycleLength");
			HardDriveBeep.NativeFieldInfoPtr_FrameSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, "FrameSkip");
			HardDriveBeep.NativeFieldInfoPtr__cycleCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, "_cycleCache");
			HardDriveBeep.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, "<ManagedUpdateRemoval>k__BackingField");
			HardDriveBeep.NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, 100689191);
			HardDriveBeep.NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, 100689192);
			HardDriveBeep.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, 100689193);
			HardDriveBeep.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, 100689194);
			HardDriveBeep.NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, 100689195);
			HardDriveBeep.NativeMethodInfoPtr_GetCurrentCycle_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, 100689196);
			HardDriveBeep.NativeMethodInfoPtr_PlayBeep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, 100689197);
			HardDriveBeep.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr, 100689198);
		}

		// Token: 0x060143D4 RID: 82900 RVA: 0x0000210C File Offset: 0x0000030C
		public HardDriveBeep(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170072A5 RID: 29349
		// (get) Token: 0x060143D5 RID: 82901 RVA: 0x0051759C File Offset: 0x0051579C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<HardDriveBeep>.NativeClassPtr));
			}
		}

		// Token: 0x170072A6 RID: 29350
		// (get) Token: 0x060143D6 RID: 82902 RVA: 0x005175B0 File Offset: 0x005157B0
		// (set) Token: 0x060143D7 RID: 82903 RVA: 0x005175E4 File Offset: 0x005157E4
		public unsafe Pickup Pickup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardDriveBeep.NativeFieldInfoPtr_Pickup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Pickup(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardDriveBeep.NativeFieldInfoPtr_Pickup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170072A7 RID: 29351
		// (get) Token: 0x060143D8 RID: 82904 RVA: 0x0051760C File Offset: 0x0051580C
		// (set) Token: 0x060143D9 RID: 82905 RVA: 0x00517640 File Offset: 0x00515840
		public unsafe AK.Wwise.Event BeepSoundEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardDriveBeep.NativeFieldInfoPtr_BeepSoundEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AK.Wwise.Event(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardDriveBeep.NativeFieldInfoPtr_BeepSoundEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170072A8 RID: 29352
		// (get) Token: 0x060143DA RID: 82906 RVA: 0x00517668 File Offset: 0x00515868
		// (set) Token: 0x060143DB RID: 82907 RVA: 0x00517690 File Offset: 0x00515890
		public unsafe float CycleLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardDriveBeep.NativeFieldInfoPtr_CycleLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardDriveBeep.NativeFieldInfoPtr_CycleLength)) = value;
			}
		}

		// Token: 0x170072A9 RID: 29353
		// (get) Token: 0x060143DC RID: 82908 RVA: 0x005176B4 File Offset: 0x005158B4
		// (set) Token: 0x060143DD RID: 82909 RVA: 0x005176DC File Offset: 0x005158DC
		public unsafe int FrameSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardDriveBeep.NativeFieldInfoPtr_FrameSkip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardDriveBeep.NativeFieldInfoPtr_FrameSkip)) = value;
			}
		}

		// Token: 0x170072AA RID: 29354
		// (get) Token: 0x060143DE RID: 82910 RVA: 0x00517700 File Offset: 0x00515900
		// (set) Token: 0x060143DF RID: 82911 RVA: 0x00517728 File Offset: 0x00515928
		public unsafe int _cycleCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardDriveBeep.NativeFieldInfoPtr__cycleCache);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardDriveBeep.NativeFieldInfoPtr__cycleCache)) = value;
			}
		}

		// Token: 0x170072AB RID: 29355
		// (get) Token: 0x060143E0 RID: 82912 RVA: 0x0051774C File Offset: 0x0051594C
		// (set) Token: 0x060143E1 RID: 82913 RVA: 0x00517774 File Offset: 0x00515974
		public unsafe bool _ManagedUpdateRemoval_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardDriveBeep.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HardDriveBeep.NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField)) = value;
			}
		}

		// Token: 0x0400CEE9 RID: 52969
		private static readonly IntPtr NativeFieldInfoPtr_Pickup;

		// Token: 0x0400CEEA RID: 52970
		private static readonly IntPtr NativeFieldInfoPtr_BeepSoundEvent;

		// Token: 0x0400CEEB RID: 52971
		private static readonly IntPtr NativeFieldInfoPtr_CycleLength;

		// Token: 0x0400CEEC RID: 52972
		private static readonly IntPtr NativeFieldInfoPtr_FrameSkip;

		// Token: 0x0400CEED RID: 52973
		private static readonly IntPtr NativeFieldInfoPtr__cycleCache;

		// Token: 0x0400CEEE RID: 52974
		private static readonly IntPtr NativeFieldInfoPtr__ManagedUpdateRemoval_k__BackingField;

		// Token: 0x0400CEEF RID: 52975
		private static readonly IntPtr NativeMethodInfoPtr_get_ManagedUpdateRemoval_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400CEF0 RID: 52976
		private static readonly IntPtr NativeMethodInfoPtr_set_ManagedUpdateRemoval_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400CEF1 RID: 52977
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400CEF2 RID: 52978
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400CEF3 RID: 52979
		private static readonly IntPtr NativeMethodInfoPtr_OnManagedUpdate_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400CEF4 RID: 52980
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentCycle_Private_Int32_0;

		// Token: 0x0400CEF5 RID: 52981
		private static readonly IntPtr NativeMethodInfoPtr_PlayBeep_Private_Void_0;

		// Token: 0x0400CEF6 RID: 52982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
