using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace Tayx.Graphy.UI
{
	// Token: 0x020008E3 RID: 2275
	public class IMovable : Il2CppObjectBase
	{
		// Token: 0x0600B95C RID: 47452 RVA: 0x002F70EC File Offset: 0x002F52EC
		[CallerCount(0)]
		public unsafe void SetPosition(GraphyManager.ModulePosition newModulePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newModulePosition;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMovable.NativeMethodInfoPtr_SetPosition_Public_Abstract_Virtual_New_Void_ModulePosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B95D RID: 47453 RVA: 0x002F714B File Offset: 0x002F534B
		// Note: this type is marked as 'beforefieldinit'.
		static IMovable()
		{
			Il2CppClassPointerStore<IMovable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.UI", "IMovable");
			IMovable.NativeMethodInfoPtr_SetPosition_Public_Abstract_Virtual_New_Void_ModulePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMovable>.NativeClassPtr, 100678406);
		}

		// Token: 0x0600B95E RID: 47454 RVA: 0x0000206B File Offset: 0x0000026B
		public IMovable(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004223 RID: 16931
		// (get) Token: 0x0600B95F RID: 47455 RVA: 0x002F717A File Offset: 0x002F537A
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IMovable>.NativeClassPtr));
			}
		}

		// Token: 0x04007702 RID: 30466
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Abstract_Virtual_New_Void_ModulePosition_0;
	}
}
