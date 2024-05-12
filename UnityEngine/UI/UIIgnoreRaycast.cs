using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace UnityEngine.UI
{
	// Token: 0x02000988 RID: 2440
	public class UIIgnoreRaycast : MonoBehaviour
	{
		// Token: 0x0600CE40 RID: 52800 RVA: 0x00334850 File Offset: 0x00332A50
		[CallerCount(0)]
		public unsafe bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sp;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(UIIgnoreRaycast.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600CE41 RID: 52801 RVA: 0x003348CC File Offset: 0x00332ACC
		[CallerCount(0)]
		public unsafe UIIgnoreRaycast() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIIgnoreRaycast>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIIgnoreRaycast.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600CE42 RID: 52802 RVA: 0x00334918 File Offset: 0x00332B18
		// Note: this type is marked as 'beforefieldinit'.
		static UIIgnoreRaycast()
		{
			Il2CppClassPointerStore<UIIgnoreRaycast>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI", "UIIgnoreRaycast");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIIgnoreRaycast>.NativeClassPtr);
			UIIgnoreRaycast.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIIgnoreRaycast>.NativeClassPtr, 100679185);
			UIIgnoreRaycast.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIIgnoreRaycast>.NativeClassPtr, 100679186);
		}

		// Token: 0x0600CE43 RID: 52803 RVA: 0x0000210C File Offset: 0x0000030C
		public UIIgnoreRaycast(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004B1C RID: 19228
		// (get) Token: 0x0600CE44 RID: 52804 RVA: 0x00334970 File Offset: 0x00332B70
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<UIIgnoreRaycast>.NativeClassPtr));
			}
		}

		// Token: 0x04008267 RID: 33383
		private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_Final_New_Boolean_Vector2_Camera_0;

		// Token: 0x04008268 RID: 33384
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
