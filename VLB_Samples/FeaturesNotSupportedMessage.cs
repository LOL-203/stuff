using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB_Samples
{
	// Token: 0x020005F9 RID: 1529
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		// Token: 0x06007BE1 RID: 31713 RVA: 0x001F2410 File Offset: 0x001F0610
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesNotSupportedMessage.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BE2 RID: 31714 RVA: 0x001F2454 File Offset: 0x001F0654
		[CallerCount(0)]
		public unsafe FeaturesNotSupportedMessage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesNotSupportedMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BE3 RID: 31715 RVA: 0x001F24A0 File Offset: 0x001F06A0
		// Note: this type is marked as 'beforefieldinit'.
		static FeaturesNotSupportedMessage()
		{
			Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "FeaturesNotSupportedMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr);
			FeaturesNotSupportedMessage.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr, 100673200);
			FeaturesNotSupportedMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr, 100673201);
		}

		// Token: 0x06007BE4 RID: 31716 RVA: 0x0000210C File Offset: 0x0000030C
		public FeaturesNotSupportedMessage(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002C6B RID: 11371
		// (get) Token: 0x06007BE5 RID: 31717 RVA: 0x001F24F8 File Offset: 0x001F06F8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr));
			}
		}

		// Token: 0x04004F5C RID: 20316
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004F5D RID: 20317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
