using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Wacki
{
	// Token: 0x02000901 RID: 2305
	public class LaserPointerEventData : PointerEventData
	{
		// Token: 0x0600BCC3 RID: 48323 RVA: 0x00304644 File Offset: 0x00302844
		[CallerCount(0)]
		public unsafe LaserPointerEventData(EventSystem e) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaserPointerEventData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaserPointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCC4 RID: 48324 RVA: 0x003046A8 File Offset: 0x003028A8
		[CallerCount(0)]
		public new unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaserPointerEventData.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCC5 RID: 48325 RVA: 0x003046F8 File Offset: 0x003028F8
		// Note: this type is marked as 'beforefieldinit'.
		static LaserPointerEventData()
		{
			Il2CppClassPointerStore<LaserPointerEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Wacki", "LaserPointerEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaserPointerEventData>.NativeClassPtr);
			LaserPointerEventData.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaserPointerEventData>.NativeClassPtr, "current");
			LaserPointerEventData.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaserPointerEventData>.NativeClassPtr, "controller");
			LaserPointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerEventData>.NativeClassPtr, 100678630);
			LaserPointerEventData.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerEventData>.NativeClassPtr, 100678631);
		}

		// Token: 0x0600BCC6 RID: 48326 RVA: 0x00304778 File Offset: 0x00302978
		public LaserPointerEventData(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004366 RID: 17254
		// (get) Token: 0x0600BCC7 RID: 48327 RVA: 0x00304781 File Offset: 0x00302981
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LaserPointerEventData>.NativeClassPtr));
			}
		}

		// Token: 0x17004367 RID: 17255
		// (get) Token: 0x0600BCC8 RID: 48328 RVA: 0x00304794 File Offset: 0x00302994
		// (set) Token: 0x0600BCC9 RID: 48329 RVA: 0x003047C8 File Offset: 0x003029C8
		public unsafe GameObject current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerEventData.NativeFieldInfoPtr_current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerEventData.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004368 RID: 17256
		// (get) Token: 0x0600BCCA RID: 48330 RVA: 0x003047F0 File Offset: 0x003029F0
		// (set) Token: 0x0600BCCB RID: 48331 RVA: 0x00304824 File Offset: 0x00302A24
		public unsafe IUILaserPointer controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerEventData.NativeFieldInfoPtr_controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new IUILaserPointer(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerEventData.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007903 RID: 30979
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04007904 RID: 30980
		private static readonly IntPtr NativeFieldInfoPtr_controller;

		// Token: 0x04007905 RID: 30981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;

		// Token: 0x04007906 RID: 30982
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
	}
}
