using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking.Transport.Ignorance
{
	// Token: 0x0200126E RID: 4718
	public class UnityIgnoranceTransport : IgnoranceTransport
	{
		// Token: 0x0601576F RID: 87919 RVA: 0x00566D40 File Offset: 0x00564F40
		[CallerCount(0)]
		public unsafe UnityIgnoranceTransport() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityIgnoranceTransport>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityIgnoranceTransport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015770 RID: 87920 RVA: 0x00566D8B File Offset: 0x00564F8B
		// Note: this type is marked as 'beforefieldinit'.
		static UnityIgnoranceTransport()
		{
			Il2CppClassPointerStore<UnityIgnoranceTransport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.Transport.Ignorance", "UnityIgnoranceTransport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityIgnoranceTransport>.NativeClassPtr);
			UnityIgnoranceTransport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityIgnoranceTransport>.NativeClassPtr, 100690793);
		}

		// Token: 0x06015771 RID: 87921 RVA: 0x00566DC4 File Offset: 0x00564FC4
		public UnityIgnoranceTransport(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17007920 RID: 31008
		// (get) Token: 0x06015772 RID: 87922 RVA: 0x00566DCD File Offset: 0x00564FCD
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UnityIgnoranceTransport>.NativeClassPtr));
			}
		}

		// Token: 0x0400DC07 RID: 56327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
