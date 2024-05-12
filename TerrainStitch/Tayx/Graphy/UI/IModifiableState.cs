using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace Tayx.Graphy.UI
{
	// Token: 0x020008E2 RID: 2274
	public class IModifiableState : Il2CppObjectBase
	{
		// Token: 0x0600B958 RID: 47448 RVA: 0x002F7038 File Offset: 0x002F5238
		[CallerCount(0)]
		public unsafe void SetState(GraphyManager.ModuleState newState, bool silentUpdate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newState;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref silentUpdate;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IModifiableState.NativeMethodInfoPtr_SetState_Public_Abstract_Virtual_New_Void_ModuleState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B959 RID: 47449 RVA: 0x002F70AA File Offset: 0x002F52AA
		// Note: this type is marked as 'beforefieldinit'.
		static IModifiableState()
		{
			Il2CppClassPointerStore<IModifiableState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Tayx.Graphy.UI", "IModifiableState");
			IModifiableState.NativeMethodInfoPtr_SetState_Public_Abstract_Virtual_New_Void_ModuleState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IModifiableState>.NativeClassPtr, 100678405);
		}

		// Token: 0x0600B95A RID: 47450 RVA: 0x0000206B File Offset: 0x0000026B
		public IModifiableState(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004222 RID: 16930
		// (get) Token: 0x0600B95B RID: 47451 RVA: 0x002F70D9 File Offset: 0x002F52D9
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<IModifiableState>.NativeClassPtr));
			}
		}

		// Token: 0x04007701 RID: 30465
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Abstract_Virtual_New_Void_ModuleState_Boolean_0;
	}
}
