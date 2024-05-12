using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB_Samples
{
	// Token: 0x020005FC RID: 1532
	public class Rotater : MonoBehaviour
	{
		// Token: 0x06007C0F RID: 31759 RVA: 0x001F2D68 File Offset: 0x001F0F68
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotater.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C10 RID: 31760 RVA: 0x001F2DAC File Offset: 0x001F0FAC
		[CallerCount(0)]
		public unsafe Rotater() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rotater>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rotater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C11 RID: 31761 RVA: 0x001F2DF8 File Offset: 0x001F0FF8
		// Note: this type is marked as 'beforefieldinit'.
		static Rotater()
		{
			Il2CppClassPointerStore<Rotater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "Rotater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rotater>.NativeClassPtr);
			Rotater.NativeFieldInfoPtr_EulerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rotater>.NativeClassPtr, "EulerSpeed");
			Rotater.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotater>.NativeClassPtr, 100673209);
			Rotater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rotater>.NativeClassPtr, 100673210);
		}

		// Token: 0x06007C12 RID: 31762 RVA: 0x0000210C File Offset: 0x0000030C
		public Rotater(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x06007C13 RID: 31763 RVA: 0x001F2E64 File Offset: 0x001F1064
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Rotater>.NativeClassPtr));
			}
		}

		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x06007C14 RID: 31764 RVA: 0x001F2E78 File Offset: 0x001F1078
		// (set) Token: 0x06007C15 RID: 31765 RVA: 0x001F2EA0 File Offset: 0x001F10A0
		public unsafe Vector3 EulerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotater.NativeFieldInfoPtr_EulerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Rotater.NativeFieldInfoPtr_EulerSpeed)) = value;
			}
		}

		// Token: 0x04004F73 RID: 20339
		private static readonly IntPtr NativeFieldInfoPtr_EulerSpeed;

		// Token: 0x04004F74 RID: 20340
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004F75 RID: 20341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
