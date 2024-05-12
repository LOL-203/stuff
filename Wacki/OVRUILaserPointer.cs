using System;
using DPI.App;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace Wacki
{
	// Token: 0x02000905 RID: 2309
	public class OVRUILaserPointer : IUILaserPointer
	{
		// Token: 0x0600BD01 RID: 48385 RVA: 0x0030567C File Offset: 0x0030387C
		[CallerCount(0)]
		public new unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OVRUILaserPointer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BD02 RID: 48386 RVA: 0x003056CC File Offset: 0x003038CC
		[CallerCount(0)]
		public new unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OVRUILaserPointer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BD03 RID: 48387 RVA: 0x0030571C File Offset: 0x0030391C
		[CallerCount(0)]
		public unsafe void OnApplicationStateChange(ApplicationStateType type, bool hasInputFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasInputFocus;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OVRUILaserPointer.NativeMethodInfoPtr_OnApplicationStateChange_Private_Void_ApplicationStateType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BD04 RID: 48388 RVA: 0x00305784 File Offset: 0x00303984
		[CallerCount(0)]
		public new unsafe bool ButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OVRUILaserPointer.NativeMethodInfoPtr_ButtonDown_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BD05 RID: 48389 RVA: 0x003057E0 File Offset: 0x003039E0
		[CallerCount(0)]
		public new unsafe bool ButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OVRUILaserPointer.NativeMethodInfoPtr_ButtonUp_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BD06 RID: 48390 RVA: 0x0030583C File Offset: 0x00303A3C
		[CallerCount(0)]
		public new unsafe void OnEnterControl(GameObject control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(control);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OVRUILaserPointer.NativeMethodInfoPtr_OnEnterControl_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BD07 RID: 48391 RVA: 0x003058A0 File Offset: 0x00303AA0
		[CallerCount(0)]
		public new unsafe void OnExitControl(GameObject control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(control);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OVRUILaserPointer.NativeMethodInfoPtr_OnExitControl_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BD08 RID: 48392 RVA: 0x00305904 File Offset: 0x00303B04
		[CallerCount(0)]
		public new unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OVRUILaserPointer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BD09 RID: 48393 RVA: 0x00305954 File Offset: 0x00303B54
		[CallerCount(0)]
		public unsafe void SetLaser(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OVRUILaserPointer.NativeMethodInfoPtr_SetLaser_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BD0A RID: 48394 RVA: 0x003059A8 File Offset: 0x00303BA8
		[CallerCount(0)]
		public unsafe OVRUILaserPointer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OVRUILaserPointer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BD0B RID: 48395 RVA: 0x003059F4 File Offset: 0x00303BF4
		// Note: this type is marked as 'beforefieldinit'.
		static OVRUILaserPointer()
		{
			Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Wacki", "OVRUILaserPointer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr);
			OVRUILaserPointer.NativeFieldInfoPtr_m_InputCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr, "m_InputCommand");
			OVRUILaserPointer.NativeFieldInfoPtr_m_Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr, "m_Hand");
			OVRUILaserPointer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr, 100678654);
			OVRUILaserPointer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr, 100678655);
			OVRUILaserPointer.NativeMethodInfoPtr_OnApplicationStateChange_Private_Void_ApplicationStateType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr, 100678656);
			OVRUILaserPointer.NativeMethodInfoPtr_ButtonDown_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr, 100678657);
			OVRUILaserPointer.NativeMethodInfoPtr_ButtonUp_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr, 100678658);
			OVRUILaserPointer.NativeMethodInfoPtr_OnEnterControl_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr, 100678659);
			OVRUILaserPointer.NativeMethodInfoPtr_OnExitControl_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr, 100678660);
			OVRUILaserPointer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr, 100678661);
			OVRUILaserPointer.NativeMethodInfoPtr_SetLaser_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr, 100678662);
			OVRUILaserPointer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr, 100678663);
		}

		// Token: 0x0600BD0C RID: 48396 RVA: 0x00304B68 File Offset: 0x00302D68
		public OVRUILaserPointer(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004379 RID: 17273
		// (get) Token: 0x0600BD0D RID: 48397 RVA: 0x00305B14 File Offset: 0x00303D14
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OVRUILaserPointer>.NativeClassPtr));
			}
		}

		// Token: 0x1700437A RID: 17274
		// (get) Token: 0x0600BD0E RID: 48398 RVA: 0x00305B28 File Offset: 0x00303D28
		// (set) Token: 0x0600BD0F RID: 48399 RVA: 0x00305B50 File Offset: 0x00303D50
		public unsafe InputCommand m_InputCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OVRUILaserPointer.NativeFieldInfoPtr_m_InputCommand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OVRUILaserPointer.NativeFieldInfoPtr_m_InputCommand)) = value;
			}
		}

		// Token: 0x1700437B RID: 17275
		// (get) Token: 0x0600BD10 RID: 48400 RVA: 0x00305B74 File Offset: 0x00303D74
		// (set) Token: 0x0600BD11 RID: 48401 RVA: 0x00305B9C File Offset: 0x00303D9C
		public unsafe InputGlobal.Hand m_Hand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OVRUILaserPointer.NativeFieldInfoPtr_m_Hand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OVRUILaserPointer.NativeFieldInfoPtr_m_Hand)) = value;
			}
		}

		// Token: 0x04007928 RID: 31016
		private static readonly IntPtr NativeFieldInfoPtr_m_InputCommand;

		// Token: 0x04007929 RID: 31017
		private static readonly IntPtr NativeFieldInfoPtr_m_Hand;

		// Token: 0x0400792A RID: 31018
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_0;

		// Token: 0x0400792B RID: 31019
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400792C RID: 31020
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationStateChange_Private_Void_ApplicationStateType_Boolean_0;

		// Token: 0x0400792D RID: 31021
		private static readonly IntPtr NativeMethodInfoPtr_ButtonDown_Public_Virtual_Boolean_0;

		// Token: 0x0400792E RID: 31022
		private static readonly IntPtr NativeMethodInfoPtr_ButtonUp_Public_Virtual_Boolean_0;

		// Token: 0x0400792F RID: 31023
		private static readonly IntPtr NativeMethodInfoPtr_OnEnterControl_Public_Virtual_Void_GameObject_0;

		// Token: 0x04007930 RID: 31024
		private static readonly IntPtr NativeMethodInfoPtr_OnExitControl_Public_Virtual_Void_GameObject_0;

		// Token: 0x04007931 RID: 31025
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04007932 RID: 31026
		private static readonly IntPtr NativeMethodInfoPtr_SetLaser_Protected_Void_Boolean_0;

		// Token: 0x04007933 RID: 31027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
