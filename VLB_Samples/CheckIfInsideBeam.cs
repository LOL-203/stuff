using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB_Samples
{
	// Token: 0x020005F8 RID: 1528
	public class CheckIfInsideBeam : MonoBehaviour
	{
		// Token: 0x06007BD3 RID: 31699 RVA: 0x001F20B4 File Offset: 0x001F02B4
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckIfInsideBeam.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BD4 RID: 31700 RVA: 0x001F20F8 File Offset: 0x001F02F8
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckIfInsideBeam.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BD5 RID: 31701 RVA: 0x001F213C File Offset: 0x001F033C
		[CallerCount(0)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckIfInsideBeam.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BD6 RID: 31702 RVA: 0x001F2180 File Offset: 0x001F0380
		[CallerCount(0)]
		public unsafe void OnTriggerStay(Collider trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckIfInsideBeam.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BD7 RID: 31703 RVA: 0x001F21DC File Offset: 0x001F03DC
		[CallerCount(0)]
		public unsafe CheckIfInsideBeam() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckIfInsideBeam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BD8 RID: 31704 RVA: 0x001F2228 File Offset: 0x001F0428
		// Note: this type is marked as 'beforefieldinit'.
		static CheckIfInsideBeam()
		{
			Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "CheckIfInsideBeam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr);
			CheckIfInsideBeam.NativeFieldInfoPtr_isInsideBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, "isInsideBeam");
			CheckIfInsideBeam.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, "m_Material");
			CheckIfInsideBeam.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, "m_Collider");
			CheckIfInsideBeam.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, 100673195);
			CheckIfInsideBeam.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, 100673196);
			CheckIfInsideBeam.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, 100673197);
			CheckIfInsideBeam.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, 100673198);
			CheckIfInsideBeam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr, 100673199);
		}

		// Token: 0x06007BD9 RID: 31705 RVA: 0x0000210C File Offset: 0x0000030C
		public CheckIfInsideBeam(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002C67 RID: 11367
		// (get) Token: 0x06007BDA RID: 31706 RVA: 0x001F22F8 File Offset: 0x001F04F8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<CheckIfInsideBeam>.NativeClassPtr));
			}
		}

		// Token: 0x17002C68 RID: 11368
		// (get) Token: 0x06007BDB RID: 31707 RVA: 0x001F230C File Offset: 0x001F050C
		// (set) Token: 0x06007BDC RID: 31708 RVA: 0x001F2334 File Offset: 0x001F0534
		public unsafe bool isInsideBeam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckIfInsideBeam.NativeFieldInfoPtr_isInsideBeam);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckIfInsideBeam.NativeFieldInfoPtr_isInsideBeam)) = value;
			}
		}

		// Token: 0x17002C69 RID: 11369
		// (get) Token: 0x06007BDD RID: 31709 RVA: 0x001F2358 File Offset: 0x001F0558
		// (set) Token: 0x06007BDE RID: 31710 RVA: 0x001F238C File Offset: 0x001F058C
		public unsafe Material m_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckIfInsideBeam.NativeFieldInfoPtr_m_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Material(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckIfInsideBeam.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C6A RID: 11370
		// (get) Token: 0x06007BDF RID: 31711 RVA: 0x001F23B4 File Offset: 0x001F05B4
		// (set) Token: 0x06007BE0 RID: 31712 RVA: 0x001F23E8 File Offset: 0x001F05E8
		public unsafe Collider m_Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckIfInsideBeam.NativeFieldInfoPtr_m_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Collider(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckIfInsideBeam.NativeFieldInfoPtr_m_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F54 RID: 20308
		private static readonly IntPtr NativeFieldInfoPtr_isInsideBeam;

		// Token: 0x04004F55 RID: 20309
		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		// Token: 0x04004F56 RID: 20310
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x04004F57 RID: 20311
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004F58 RID: 20312
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004F59 RID: 20313
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004F5A RID: 20314
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04004F5B RID: 20315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
