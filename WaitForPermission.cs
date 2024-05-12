using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020000CB RID: 203
public sealed class WaitForPermission : CustomYieldInstruction
{
	// Token: 0x06000CAF RID: 3247 RVA: 0x00033660 File Offset: 0x00031860
	[CallerCount(0)]
	public unsafe WaitForPermission(string permission) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForPermission>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(permission);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForPermission.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x17000465 RID: 1125
	// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x000336C4 File Offset: 0x000318C4
	public new unsafe bool keepWaiting
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WaitForPermission.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x00033714 File Offset: 0x00031914
	[CallerCount(0)]
	public unsafe void Reset(string permission)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(permission);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForPermission.NativeMethodInfoPtr_Reset_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x17000466 RID: 1126
	// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00033770 File Offset: 0x00031970
	public unsafe bool HasPermission
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WaitForPermission.NativeMethodInfoPtr_get_HasPermission_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x000337C0 File Offset: 0x000319C0
	// Note: this type is marked as 'beforefieldinit'.
	static WaitForPermission()
	{
		Il2CppClassPointerStore<WaitForPermission>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WaitForPermission");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForPermission>.NativeClassPtr);
		WaitForPermission.NativeFieldInfoPtr_permission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForPermission>.NativeClassPtr, "permission");
		WaitForPermission.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForPermission>.NativeClassPtr, "timer");
		WaitForPermission.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForPermission>.NativeClassPtr, 100664281);
		WaitForPermission.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForPermission>.NativeClassPtr, 100664282);
		WaitForPermission.NativeMethodInfoPtr_Reset_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForPermission>.NativeClassPtr, 100664283);
		WaitForPermission.NativeMethodInfoPtr_get_HasPermission_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForPermission>.NativeClassPtr, 100664284);
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x000335AC File Offset: 0x000317AC
	public WaitForPermission(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000462 RID: 1122
	// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00033868 File Offset: 0x00031A68
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WaitForPermission>.NativeClassPtr));
		}
	}

	// Token: 0x17000463 RID: 1123
	// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0003387C File Offset: 0x00031A7C
	// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x000338A5 File Offset: 0x00031AA5
	public unsafe string permission
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForPermission.NativeFieldInfoPtr_permission);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForPermission.NativeFieldInfoPtr_permission), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000464 RID: 1124
	// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x000338CC File Offset: 0x00031ACC
	// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x000338F4 File Offset: 0x00031AF4
	public unsafe float timer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForPermission.NativeFieldInfoPtr_timer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForPermission.NativeFieldInfoPtr_timer)) = value;
		}
	}

	// Token: 0x040007A9 RID: 1961
	private static readonly IntPtr NativeFieldInfoPtr_permission;

	// Token: 0x040007AA RID: 1962
	private static readonly IntPtr NativeFieldInfoPtr_timer;

	// Token: 0x040007AB RID: 1963
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x040007AC RID: 1964
	private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

	// Token: 0x040007AD RID: 1965
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_String_0;

	// Token: 0x040007AE RID: 1966
	private static readonly IntPtr NativeMethodInfoPtr_get_HasPermission_Private_get_Boolean_0;
}
