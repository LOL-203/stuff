using System;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace DPI.Networking.IO
{
	// Token: 0x02001278 RID: 4728
	public class INetworkStreamableServer : Il2CppObjectBase
	{
		// Token: 0x06015834 RID: 88116 RVA: 0x0056B593 File Offset: 0x00569793
		// Note: this type is marked as 'beforefieldinit'.
		static INetworkStreamableServer()
		{
			Il2CppClassPointerStore<INetworkStreamableServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.IO", "INetworkStreamableServer");
		}

		// Token: 0x06015835 RID: 88117 RVA: 0x0000206B File Offset: 0x0000026B
		public INetworkStreamableServer(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700793F RID: 31039
		// (get) Token: 0x06015836 RID: 88118 RVA: 0x0056B5AE File Offset: 0x005697AE
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<INetworkStreamableServer>.NativeClassPtr));
			}
		}
	}
}
