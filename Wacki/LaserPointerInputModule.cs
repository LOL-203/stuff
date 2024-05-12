using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Wacki
{
	// Token: 0x02000903 RID: 2307
	public class LaserPointerInputModule : BaseInputModule
	{
		// Token: 0x17004373 RID: 17267
		// (get) Token: 0x0600BCD6 RID: 48342 RVA: 0x00304B84 File Offset: 0x00302D84
		public unsafe static LaserPointerInputModule instance
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaserPointerInputModule.NativeMethodInfoPtr_get_instance_Public_Static_get_LaserPointerInputModule_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new LaserPointerInputModule(intPtr2) : null;
			}
		}

		// Token: 0x0600BCD7 RID: 48343 RVA: 0x00304BCC File Offset: 0x00302DCC
		[CallerCount(0)]
		public new unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaserPointerInputModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCD8 RID: 48344 RVA: 0x00304C1C File Offset: 0x00302E1C
		[CallerCount(0)]
		public new unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaserPointerInputModule.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCD9 RID: 48345 RVA: 0x00304C6C File Offset: 0x00302E6C
		[CallerCount(0)]
		public new unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaserPointerInputModule.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCDA RID: 48346 RVA: 0x00304CBC File Offset: 0x00302EBC
		[CallerCount(0)]
		public unsafe void OnInputModuleUsageModified(InputGlobal.InputModuleUsage usage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref usage;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaserPointerInputModule.NativeMethodInfoPtr_OnInputModuleUsageModified_Private_Void_InputModuleUsage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCDB RID: 48347 RVA: 0x00304D10 File Offset: 0x00302F10
		[CallerCount(0)]
		public unsafe void UpdateCanvasesCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaserPointerInputModule.NativeMethodInfoPtr_UpdateCanvasesCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCDC RID: 48348 RVA: 0x00304D54 File Offset: 0x00302F54
		[CallerCount(0)]
		public unsafe void AddController(IUILaserPointer controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaserPointerInputModule.NativeMethodInfoPtr_AddController_Public_Void_IUILaserPointer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCDD RID: 48349 RVA: 0x00304DB0 File Offset: 0x00302FB0
		[CallerCount(0)]
		public unsafe void RemoveController(IUILaserPointer controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaserPointerInputModule.NativeMethodInfoPtr_RemoveController_Public_Void_IUILaserPointer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCDE RID: 48350 RVA: 0x00304E0C File Offset: 0x0030300C
		[CallerCount(0)]
		public unsafe void UpdateCameraPosition(IUILaserPointer controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaserPointerInputModule.NativeMethodInfoPtr_UpdateCameraPosition_Protected_Void_IUILaserPointer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCDF RID: 48351 RVA: 0x00304E68 File Offset: 0x00303068
		[CallerCount(0)]
		public unsafe void ClearSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaserPointerInputModule.NativeMethodInfoPtr_ClearSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCE0 RID: 48352 RVA: 0x00304EAC File Offset: 0x003030AC
		[CallerCount(0)]
		public unsafe void Select(GameObject go)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaserPointerInputModule.NativeMethodInfoPtr_Select_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCE1 RID: 48353 RVA: 0x00304F08 File Offset: 0x00303108
		[CallerCount(0)]
		public unsafe void IgnoreOneFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaserPointerInputModule.NativeMethodInfoPtr_IgnoreOneFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCE2 RID: 48354 RVA: 0x00304F4C File Offset: 0x0030314C
		[CallerCount(0)]
		public new unsafe void Process()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaserPointerInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCE3 RID: 48355 RVA: 0x00304F9C File Offset: 0x0030319C
		[CallerCount(0)]
		public unsafe LaserPointerInputModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaserPointerInputModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BCE4 RID: 48356 RVA: 0x00304FE8 File Offset: 0x003031E8
		// Note: this type is marked as 'beforefieldinit'.
		static LaserPointerInputModule()
		{
			Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Wacki", "LaserPointerInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr);
			LaserPointerInputModule.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, "_instance");
			LaserPointerInputModule.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, "layerMask");
			LaserPointerInputModule.NativeFieldInfoPtr_UICamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, "UICamera");
			LaserPointerInputModule.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, "raycaster");
			LaserPointerInputModule.NativeFieldInfoPtr__controllerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, "_controllerData");
			LaserPointerInputModule.NativeFieldInfoPtr_StandaloneInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, "StandaloneInput");
			LaserPointerInputModule.NativeFieldInfoPtr_m_ignoreOneFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, "m_ignoreOneFrame");
			LaserPointerInputModule.NativeMethodInfoPtr_get_instance_Public_Static_get_LaserPointerInputModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678639);
			LaserPointerInputModule.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678640);
			LaserPointerInputModule.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678641);
			LaserPointerInputModule.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678642);
			LaserPointerInputModule.NativeMethodInfoPtr_OnInputModuleUsageModified_Private_Void_InputModuleUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678643);
			LaserPointerInputModule.NativeMethodInfoPtr_UpdateCanvasesCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678644);
			LaserPointerInputModule.NativeMethodInfoPtr_AddController_Public_Void_IUILaserPointer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678645);
			LaserPointerInputModule.NativeMethodInfoPtr_RemoveController_Public_Void_IUILaserPointer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678646);
			LaserPointerInputModule.NativeMethodInfoPtr_UpdateCameraPosition_Protected_Void_IUILaserPointer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678647);
			LaserPointerInputModule.NativeMethodInfoPtr_ClearSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678648);
			LaserPointerInputModule.NativeMethodInfoPtr_Select_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678649);
			LaserPointerInputModule.NativeMethodInfoPtr_IgnoreOneFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678650);
			LaserPointerInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678651);
			LaserPointerInputModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, 100678652);
		}

		// Token: 0x0600BCE5 RID: 48357 RVA: 0x003051BC File Offset: 0x003033BC
		public LaserPointerInputModule(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700436B RID: 17259
		// (get) Token: 0x0600BCE6 RID: 48358 RVA: 0x003051C5 File Offset: 0x003033C5
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr));
			}
		}

		// Token: 0x1700436C RID: 17260
		// (get) Token: 0x0600BCE7 RID: 48359 RVA: 0x003051D8 File Offset: 0x003033D8
		// (set) Token: 0x0600BCE8 RID: 48360 RVA: 0x00305203 File Offset: 0x00303403
		public unsafe static LaserPointerInputModule _instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LaserPointerInputModule.NativeFieldInfoPtr__instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new LaserPointerInputModule(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaserPointerInputModule.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700436D RID: 17261
		// (get) Token: 0x0600BCE9 RID: 48361 RVA: 0x00305218 File Offset: 0x00303418
		// (set) Token: 0x0600BCEA RID: 48362 RVA: 0x00305240 File Offset: 0x00303440
		public unsafe LayerMask layerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.NativeFieldInfoPtr_layerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.NativeFieldInfoPtr_layerMask)) = value;
			}
		}

		// Token: 0x1700436E RID: 17262
		// (get) Token: 0x0600BCEB RID: 48363 RVA: 0x00305264 File Offset: 0x00303464
		// (set) Token: 0x0600BCEC RID: 48364 RVA: 0x00305298 File Offset: 0x00303498
		public unsafe Camera UICamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.NativeFieldInfoPtr_UICamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Camera(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.NativeFieldInfoPtr_UICamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700436F RID: 17263
		// (get) Token: 0x0600BCED RID: 48365 RVA: 0x003052C0 File Offset: 0x003034C0
		// (set) Token: 0x0600BCEE RID: 48366 RVA: 0x003052F4 File Offset: 0x003034F4
		public unsafe PhysicsRaycaster raycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.NativeFieldInfoPtr_raycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new PhysicsRaycaster(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004370 RID: 17264
		// (get) Token: 0x0600BCEF RID: 48367 RVA: 0x0030531C File Offset: 0x0030351C
		// (set) Token: 0x0600BCF0 RID: 48368 RVA: 0x00305350 File Offset: 0x00303550
		public unsafe Dictionary<IUILaserPointer, LaserPointerInputModule.ControllerData> _controllerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.NativeFieldInfoPtr__controllerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Dictionary<IUILaserPointer, LaserPointerInputModule.ControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.NativeFieldInfoPtr__controllerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004371 RID: 17265
		// (get) Token: 0x0600BCF1 RID: 48369 RVA: 0x00305378 File Offset: 0x00303578
		// (set) Token: 0x0600BCF2 RID: 48370 RVA: 0x003053AC File Offset: 0x003035AC
		public unsafe StandaloneInputModule StandaloneInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.NativeFieldInfoPtr_StandaloneInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new StandaloneInputModule(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.NativeFieldInfoPtr_StandaloneInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17004372 RID: 17266
		// (get) Token: 0x0600BCF3 RID: 48371 RVA: 0x003053D4 File Offset: 0x003035D4
		// (set) Token: 0x0600BCF4 RID: 48372 RVA: 0x003053FC File Offset: 0x003035FC
		public unsafe bool m_ignoreOneFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.NativeFieldInfoPtr_m_ignoreOneFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.NativeFieldInfoPtr_m_ignoreOneFrame)) = value;
			}
		}

		// Token: 0x0400790E RID: 30990
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x0400790F RID: 30991
		private static readonly IntPtr NativeFieldInfoPtr_layerMask;

		// Token: 0x04007910 RID: 30992
		private static readonly IntPtr NativeFieldInfoPtr_UICamera;

		// Token: 0x04007911 RID: 30993
		private static readonly IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04007912 RID: 30994
		private static readonly IntPtr NativeFieldInfoPtr__controllerData;

		// Token: 0x04007913 RID: 30995
		private static readonly IntPtr NativeFieldInfoPtr_StandaloneInput;

		// Token: 0x04007914 RID: 30996
		private static readonly IntPtr NativeFieldInfoPtr_m_ignoreOneFrame;

		// Token: 0x04007915 RID: 30997
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_LaserPointerInputModule_0;

		// Token: 0x04007916 RID: 30998
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007917 RID: 30999
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007918 RID: 31000
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04007919 RID: 31001
		private static readonly IntPtr NativeMethodInfoPtr_OnInputModuleUsageModified_Private_Void_InputModuleUsage_0;

		// Token: 0x0400791A RID: 31002
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanvasesCamera_Private_Void_0;

		// Token: 0x0400791B RID: 31003
		private static readonly IntPtr NativeMethodInfoPtr_AddController_Public_Void_IUILaserPointer_0;

		// Token: 0x0400791C RID: 31004
		private static readonly IntPtr NativeMethodInfoPtr_RemoveController_Public_Void_IUILaserPointer_0;

		// Token: 0x0400791D RID: 31005
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraPosition_Protected_Void_IUILaserPointer_0;

		// Token: 0x0400791E RID: 31006
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Public_Void_0;

		// Token: 0x0400791F RID: 31007
		private static readonly IntPtr NativeMethodInfoPtr_Select_Private_Void_GameObject_0;

		// Token: 0x04007920 RID: 31008
		private static readonly IntPtr NativeMethodInfoPtr_IgnoreOneFrame_Public_Void_0;

		// Token: 0x04007921 RID: 31009
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;

		// Token: 0x04007922 RID: 31010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000904 RID: 2308
		public class ControllerData : Il2CppSystem.Object
		{
			// Token: 0x0600BCF5 RID: 48373 RVA: 0x00305420 File Offset: 0x00303620
			[CallerCount(0)]
			public unsafe ControllerData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaserPointerInputModule.ControllerData>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaserPointerInputModule.ControllerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600BCF6 RID: 48374 RVA: 0x0030546C File Offset: 0x0030366C
			// Note: this type is marked as 'beforefieldinit'.
			static ControllerData()
			{
				Il2CppClassPointerStore<LaserPointerInputModule.ControllerData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LaserPointerInputModule>.NativeClassPtr, "ControllerData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaserPointerInputModule.ControllerData>.NativeClassPtr);
				LaserPointerInputModule.ControllerData.NativeFieldInfoPtr_pointerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaserPointerInputModule.ControllerData>.NativeClassPtr, "pointerEvent");
				LaserPointerInputModule.ControllerData.NativeFieldInfoPtr_currentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaserPointerInputModule.ControllerData>.NativeClassPtr, "currentPoint");
				LaserPointerInputModule.ControllerData.NativeFieldInfoPtr_currentPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaserPointerInputModule.ControllerData>.NativeClassPtr, "currentPressed");
				LaserPointerInputModule.ControllerData.NativeFieldInfoPtr_currentDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaserPointerInputModule.ControllerData>.NativeClassPtr, "currentDragging");
				LaserPointerInputModule.ControllerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaserPointerInputModule.ControllerData>.NativeClassPtr, 100678653);
			}

			// Token: 0x0600BCF7 RID: 48375 RVA: 0x00002988 File Offset: 0x00000B88
			public ControllerData(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17004374 RID: 17268
			// (get) Token: 0x0600BCF8 RID: 48376 RVA: 0x003054FB File Offset: 0x003036FB
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<LaserPointerInputModule.ControllerData>.NativeClassPtr));
				}
			}

			// Token: 0x17004375 RID: 17269
			// (get) Token: 0x0600BCF9 RID: 48377 RVA: 0x0030550C File Offset: 0x0030370C
			// (set) Token: 0x0600BCFA RID: 48378 RVA: 0x00305540 File Offset: 0x00303740
			public unsafe LaserPointerEventData pointerEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.ControllerData.NativeFieldInfoPtr_pointerEvent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new LaserPointerEventData(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.ControllerData.NativeFieldInfoPtr_pointerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004376 RID: 17270
			// (get) Token: 0x0600BCFB RID: 48379 RVA: 0x00305568 File Offset: 0x00303768
			// (set) Token: 0x0600BCFC RID: 48380 RVA: 0x0030559C File Offset: 0x0030379C
			public unsafe GameObject currentPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.ControllerData.NativeFieldInfoPtr_currentPoint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.ControllerData.NativeFieldInfoPtr_currentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004377 RID: 17271
			// (get) Token: 0x0600BCFD RID: 48381 RVA: 0x003055C4 File Offset: 0x003037C4
			// (set) Token: 0x0600BCFE RID: 48382 RVA: 0x003055F8 File Offset: 0x003037F8
			public unsafe GameObject currentPressed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.ControllerData.NativeFieldInfoPtr_currentPressed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.ControllerData.NativeFieldInfoPtr_currentPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004378 RID: 17272
			// (get) Token: 0x0600BCFF RID: 48383 RVA: 0x00305620 File Offset: 0x00303820
			// (set) Token: 0x0600BD00 RID: 48384 RVA: 0x00305654 File Offset: 0x00303854
			public unsafe GameObject currentDragging
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.ControllerData.NativeFieldInfoPtr_currentDragging);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaserPointerInputModule.ControllerData.NativeFieldInfoPtr_currentDragging), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007923 RID: 31011
			private static readonly IntPtr NativeFieldInfoPtr_pointerEvent;

			// Token: 0x04007924 RID: 31012
			private static readonly IntPtr NativeFieldInfoPtr_currentPoint;

			// Token: 0x04007925 RID: 31013
			private static readonly IntPtr NativeFieldInfoPtr_currentPressed;

			// Token: 0x04007926 RID: 31014
			private static readonly IntPtr NativeFieldInfoPtr_currentDragging;

			// Token: 0x04007927 RID: 31015
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
