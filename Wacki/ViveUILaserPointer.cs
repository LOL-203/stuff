using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using Valve.VR;

namespace Wacki
{
	// Token: 0x02000902 RID: 2306
	public class ViveUILaserPointer : IUILaserPointer
	{
		// Token: 0x1700436A RID: 17258
		// (get) Token: 0x0600BCCC RID: 48332 RVA: 0x0030484C File Offset: 0x00302A4C
		public unsafe static SteamVR_Input_Sources Source
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ViveUILaserPointer.NativeMethodInfoPtr_get_Source_Private_Static_get_SteamVR_Input_Sources_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600BCCD RID: 48333 RVA: 0x00304890 File Offset: 0x00302A90
		[CallerCount(0)]
		public new unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViveUILaserPointer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCCE RID: 48334 RVA: 0x003048E0 File Offset: 0x00302AE0
		[CallerCount(0)]
		public new unsafe bool ButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViveUILaserPointer.NativeMethodInfoPtr_ButtonDown_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BCCF RID: 48335 RVA: 0x0030493C File Offset: 0x00302B3C
		[CallerCount(0)]
		public new unsafe bool ButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViveUILaserPointer.NativeMethodInfoPtr_ButtonUp_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BCD0 RID: 48336 RVA: 0x00304998 File Offset: 0x00302B98
		[CallerCount(0)]
		public new unsafe void OnEnterControl(GameObject control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(control);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViveUILaserPointer.NativeMethodInfoPtr_OnEnterControl_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCD1 RID: 48337 RVA: 0x003049FC File Offset: 0x00302BFC
		[CallerCount(0)]
		public new unsafe void OnExitControl(GameObject control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(control);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViveUILaserPointer.NativeMethodInfoPtr_OnExitControl_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCD2 RID: 48338 RVA: 0x00304A60 File Offset: 0x00302C60
		[CallerCount(0)]
		public unsafe ViveUILaserPointer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViveUILaserPointer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViveUILaserPointer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCD3 RID: 48339 RVA: 0x00304AAC File Offset: 0x00302CAC
		// Note: this type is marked as 'beforefieldinit'.
		static ViveUILaserPointer()
		{
			Il2CppClassPointerStore<ViveUILaserPointer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Wacki", "ViveUILaserPointer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViveUILaserPointer>.NativeClassPtr);
			ViveUILaserPointer.NativeMethodInfoPtr_get_Source_Private_Static_get_SteamVR_Input_Sources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViveUILaserPointer>.NativeClassPtr, 100678632);
			ViveUILaserPointer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViveUILaserPointer>.NativeClassPtr, 100678633);
			ViveUILaserPointer.NativeMethodInfoPtr_ButtonDown_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViveUILaserPointer>.NativeClassPtr, 100678634);
			ViveUILaserPointer.NativeMethodInfoPtr_ButtonUp_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViveUILaserPointer>.NativeClassPtr, 100678635);
			ViveUILaserPointer.NativeMethodInfoPtr_OnEnterControl_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViveUILaserPointer>.NativeClassPtr, 100678636);
			ViveUILaserPointer.NativeMethodInfoPtr_OnExitControl_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViveUILaserPointer>.NativeClassPtr, 100678637);
			ViveUILaserPointer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViveUILaserPointer>.NativeClassPtr, 100678638);
		}

		// Token: 0x0600BCD4 RID: 48340 RVA: 0x00304B68 File Offset: 0x00302D68
		public ViveUILaserPointer(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004369 RID: 17257
		// (get) Token: 0x0600BCD5 RID: 48341 RVA: 0x00304B71 File Offset: 0x00302D71
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ViveUILaserPointer>.NativeClassPtr));
			}
		}

		// Token: 0x04007907 RID: 30983
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Private_Static_get_SteamVR_Input_Sources_0;

		// Token: 0x04007908 RID: 30984
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0;

		// Token: 0x04007909 RID: 30985
		private static readonly IntPtr NativeMethodInfoPtr_ButtonDown_Public_Virtual_Boolean_0;

		// Token: 0x0400790A RID: 30986
		private static readonly IntPtr NativeMethodInfoPtr_ButtonUp_Public_Virtual_Boolean_0;

		// Token: 0x0400790B RID: 30987
		private static readonly IntPtr NativeMethodInfoPtr_OnEnterControl_Public_Virtual_Void_GameObject_0;

		// Token: 0x0400790C RID: 30988
		private static readonly IntPtr NativeMethodInfoPtr_OnExitControl_Public_Virtual_Void_GameObject_0;

		// Token: 0x0400790D RID: 30989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
