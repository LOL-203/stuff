using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x02000533 RID: 1331
public class Basics : MonoBehaviour
{
	// Token: 0x06006CA4 RID: 27812 RVA: 0x001B4138 File Offset: 0x001B2338
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Basics.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006CA5 RID: 27813 RVA: 0x001B417C File Offset: 0x001B237C
	[CallerCount(0)]
	public unsafe Basics() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Basics>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Basics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006CA6 RID: 27814 RVA: 0x001B41C8 File Offset: 0x001B23C8
	[CallerCount(0)]
	public unsafe Vector3 _Start_b__2_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Basics.NativeMethodInfoPtr__Start_b__2_0_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		return *IL2CPP.il2cpp_object_unbox(obj);
	}

	// Token: 0x06006CA7 RID: 27815 RVA: 0x001B4218 File Offset: 0x001B2418
	[CallerCount(0)]
	public unsafe void _Start_b__2_1(Vector3 x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref x;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Basics.NativeMethodInfoPtr__Start_b__2_1_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006CA8 RID: 27816 RVA: 0x001B426C File Offset: 0x001B246C
	// Note: this type is marked as 'beforefieldinit'.
	static Basics()
	{
		Il2CppClassPointerStore<Basics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Basics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Basics>.NativeClassPtr);
		Basics.NativeFieldInfoPtr_cubeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Basics>.NativeClassPtr, "cubeA");
		Basics.NativeFieldInfoPtr_cubeB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Basics>.NativeClassPtr, "cubeB");
		Basics.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Basics>.NativeClassPtr, 100671915);
		Basics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Basics>.NativeClassPtr, 100671916);
		Basics.NativeMethodInfoPtr__Start_b__2_0_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Basics>.NativeClassPtr, 100671917);
		Basics.NativeMethodInfoPtr__Start_b__2_1_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Basics>.NativeClassPtr, 100671918);
	}

	// Token: 0x06006CA9 RID: 27817 RVA: 0x0000210C File Offset: 0x0000030C
	public Basics(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170026A9 RID: 9897
	// (get) Token: 0x06006CAA RID: 27818 RVA: 0x001B4314 File Offset: 0x001B2514
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Basics>.NativeClassPtr));
		}
	}

	// Token: 0x170026AA RID: 9898
	// (get) Token: 0x06006CAB RID: 27819 RVA: 0x001B4328 File Offset: 0x001B2528
	// (set) Token: 0x06006CAC RID: 27820 RVA: 0x001B435C File Offset: 0x001B255C
	public unsafe Transform cubeA
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Basics.NativeFieldInfoPtr_cubeA);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Basics.NativeFieldInfoPtr_cubeA), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170026AB RID: 9899
	// (get) Token: 0x06006CAD RID: 27821 RVA: 0x001B4384 File Offset: 0x001B2584
	// (set) Token: 0x06006CAE RID: 27822 RVA: 0x001B43B8 File Offset: 0x001B25B8
	public unsafe Transform cubeB
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Basics.NativeFieldInfoPtr_cubeB);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Basics.NativeFieldInfoPtr_cubeB), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04004579 RID: 17785
	private static readonly IntPtr NativeFieldInfoPtr_cubeA;

	// Token: 0x0400457A RID: 17786
	private static readonly IntPtr NativeFieldInfoPtr_cubeB;

	// Token: 0x0400457B RID: 17787
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400457C RID: 17788
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0400457D RID: 17789
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__2_0_Private_Vector3_0;

	// Token: 0x0400457E RID: 17790
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__2_1_Private_Void_Vector3_0;
}
