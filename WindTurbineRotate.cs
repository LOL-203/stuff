using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

// Token: 0x020001D8 RID: 472
public class WindTurbineRotate : MonoBehaviour
{
	// Token: 0x060021E1 RID: 8673 RVA: 0x0008503C File Offset: 0x0008323C
	[CallerCount(0)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindTurbineRotate.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060021E2 RID: 8674 RVA: 0x00085080 File Offset: 0x00083280
	[CallerCount(0)]
	public unsafe WindTurbineRotate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindTurbineRotate>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindTurbineRotate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x060021E3 RID: 8675 RVA: 0x000850CC File Offset: 0x000832CC
	// Note: this type is marked as 'beforefieldinit'.
	static WindTurbineRotate()
	{
		Il2CppClassPointerStore<WindTurbineRotate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WindTurbineRotate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindTurbineRotate>.NativeClassPtr);
		WindTurbineRotate.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindTurbineRotate>.NativeClassPtr, "speed");
		WindTurbineRotate.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindTurbineRotate>.NativeClassPtr, 100665869);
		WindTurbineRotate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindTurbineRotate>.NativeClassPtr, 100665870);
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x0000210C File Offset: 0x0000030C
	public WindTurbineRotate(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x17000BF5 RID: 3061
	// (get) Token: 0x060021E5 RID: 8677 RVA: 0x00085138 File Offset: 0x00083338
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WindTurbineRotate>.NativeClassPtr));
		}
	}

	// Token: 0x17000BF6 RID: 3062
	// (get) Token: 0x060021E6 RID: 8678 RVA: 0x0008514C File Offset: 0x0008334C
	// (set) Token: 0x060021E7 RID: 8679 RVA: 0x00085174 File Offset: 0x00083374
	public unsafe float speed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindTurbineRotate.NativeFieldInfoPtr_speed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindTurbineRotate.NativeFieldInfoPtr_speed)) = value;
		}
	}

	// Token: 0x0400154D RID: 5453
	private static readonly IntPtr NativeFieldInfoPtr_speed;

	// Token: 0x0400154E RID: 5454
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x0400154F RID: 5455
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
