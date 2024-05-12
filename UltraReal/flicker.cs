using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace UltraReal
{
	// Token: 0x02000907 RID: 2311
	public class flicker : MonoBehaviour
	{
		// Token: 0x0600BD21 RID: 48417 RVA: 0x00305ECC File Offset: 0x003040CC
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(flicker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BD22 RID: 48418 RVA: 0x00305F10 File Offset: 0x00304110
		[CallerCount(0)]
		public unsafe flicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<flicker>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(flicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BD23 RID: 48419 RVA: 0x00305F5C File Offset: 0x0030415C
		// Note: this type is marked as 'beforefieldinit'.
		static flicker()
		{
			Il2CppClassPointerStore<flicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UltraReal", "flicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<flicker>.NativeClassPtr);
			flicker.NativeFieldInfoPtr_lightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<flicker>.NativeClassPtr, "lightIntensity");
			flicker.NativeFieldInfoPtr_flickerCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<flicker>.NativeClassPtr, "flickerCurve");
			flicker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<flicker>.NativeClassPtr, 100678666);
			flicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<flicker>.NativeClassPtr, 100678667);
		}

		// Token: 0x0600BD24 RID: 48420 RVA: 0x0000210C File Offset: 0x0000030C
		public flicker(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004382 RID: 17282
		// (get) Token: 0x0600BD25 RID: 48421 RVA: 0x00305FDC File Offset: 0x003041DC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<flicker>.NativeClassPtr));
			}
		}

		// Token: 0x17004383 RID: 17283
		// (get) Token: 0x0600BD26 RID: 48422 RVA: 0x00305FF0 File Offset: 0x003041F0
		// (set) Token: 0x0600BD27 RID: 48423 RVA: 0x00306018 File Offset: 0x00304218
		public unsafe float lightIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(flicker.NativeFieldInfoPtr_lightIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(flicker.NativeFieldInfoPtr_lightIntensity)) = value;
			}
		}

		// Token: 0x17004384 RID: 17284
		// (get) Token: 0x0600BD28 RID: 48424 RVA: 0x0030603C File Offset: 0x0030423C
		// (set) Token: 0x0600BD29 RID: 48425 RVA: 0x00306070 File Offset: 0x00304270
		public unsafe AnimationCurveProperty flickerCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(flicker.NativeFieldInfoPtr_flickerCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AnimationCurveProperty(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(flicker.NativeFieldInfoPtr_flickerCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400793B RID: 31035
		private static readonly IntPtr NativeFieldInfoPtr_lightIntensity;

		// Token: 0x0400793C RID: 31036
		private static readonly IntPtr NativeFieldInfoPtr_flickerCurve;

		// Token: 0x0400793D RID: 31037
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400793E RID: 31038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
