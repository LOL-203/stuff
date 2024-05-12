using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005E9 RID: 1513
	public class TriggerZone : MonoBehaviour
	{
		// Token: 0x06007A8D RID: 31373 RVA: 0x001EC8D4 File Offset: 0x001EAAD4
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A8E RID: 31374 RVA: 0x001EC918 File Offset: 0x001EAB18
		[CallerCount(0)]
		public unsafe TriggerZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A8F RID: 31375 RVA: 0x001EC964 File Offset: 0x001EAB64
		// Note: this type is marked as 'beforefieldinit'.
		static TriggerZone()
		{
			Il2CppClassPointerStore<TriggerZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "TriggerZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr);
			TriggerZone.NativeFieldInfoPtr_setIsTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "setIsTrigger");
			TriggerZone.NativeFieldInfoPtr_rangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "rangeMultiplier");
			TriggerZone.NativeFieldInfoPtr_kMeshColliderNumSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "kMeshColliderNumSides");
			TriggerZone.NativeFieldInfoPtr_m_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, "m_Mesh");
			TriggerZone.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100673057);
			TriggerZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr, 100673058);
		}

		// Token: 0x06007A90 RID: 31376 RVA: 0x0000210C File Offset: 0x0000030C
		public TriggerZone(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x06007A91 RID: 31377 RVA: 0x001ECA0C File Offset: 0x001EAC0C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TriggerZone>.NativeClassPtr));
			}
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x06007A92 RID: 31378 RVA: 0x001ECA20 File Offset: 0x001EAC20
		// (set) Token: 0x06007A93 RID: 31379 RVA: 0x001ECA48 File Offset: 0x001EAC48
		public unsafe bool setIsTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_setIsTrigger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_setIsTrigger)) = value;
			}
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x06007A94 RID: 31380 RVA: 0x001ECA6C File Offset: 0x001EAC6C
		// (set) Token: 0x06007A95 RID: 31381 RVA: 0x001ECA94 File Offset: 0x001EAC94
		public unsafe float rangeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_rangeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_rangeMultiplier)) = value;
			}
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x06007A96 RID: 31382 RVA: 0x001ECAB8 File Offset: 0x001EACB8
		// (set) Token: 0x06007A97 RID: 31383 RVA: 0x001ECAD6 File Offset: 0x001EACD6
		public unsafe static int kMeshColliderNumSides
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TriggerZone.NativeFieldInfoPtr_kMeshColliderNumSides, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TriggerZone.NativeFieldInfoPtr_kMeshColliderNumSides, (void*)(&value));
			}
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x06007A98 RID: 31384 RVA: 0x001ECAE8 File Offset: 0x001EACE8
		// (set) Token: 0x06007A99 RID: 31385 RVA: 0x001ECB1C File Offset: 0x001EAD1C
		public unsafe Mesh m_Mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_Mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerZone.NativeFieldInfoPtr_m_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E76 RID: 20086
		private static readonly IntPtr NativeFieldInfoPtr_setIsTrigger;

		// Token: 0x04004E77 RID: 20087
		private static readonly IntPtr NativeFieldInfoPtr_rangeMultiplier;

		// Token: 0x04004E78 RID: 20088
		private static readonly IntPtr NativeFieldInfoPtr_kMeshColliderNumSides;

		// Token: 0x04004E79 RID: 20089
		private static readonly IntPtr NativeFieldInfoPtr_m_Mesh;

		// Token: 0x04004E7A RID: 20090
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004E7B RID: 20091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
