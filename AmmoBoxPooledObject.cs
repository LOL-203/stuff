using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x0200031A RID: 794
public class AmmoBoxPooledObject : PooledObject
{
	// Token: 0x06003E9E RID: 16030 RVA: 0x000FCAC0 File Offset: 0x000FACC0
	[CallerCount(0)]
	public unsafe AmmoBoxPooledObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmmoBoxPooledObject>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmmoBoxPooledObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06003E9F RID: 16031 RVA: 0x000FCB0C File Offset: 0x000FAD0C
	// Note: this type is marked as 'beforefieldinit'.
	static AmmoBoxPooledObject()
	{
		Il2CppClassPointerStore<AmmoBoxPooledObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AmmoBoxPooledObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmmoBoxPooledObject>.NativeClassPtr);
		AmmoBoxPooledObject.NativeFieldInfoPtr_AmmoRefil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmmoBoxPooledObject>.NativeClassPtr, "AmmoRefil");
		AmmoBoxPooledObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmmoBoxPooledObject>.NativeClassPtr, 100668303);
	}

	// Token: 0x06003EA0 RID: 16032 RVA: 0x000FCB64 File Offset: 0x000FAD64
	public AmmoBoxPooledObject(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700162B RID: 5675
	// (get) Token: 0x06003EA1 RID: 16033 RVA: 0x000FCB6D File Offset: 0x000FAD6D
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AmmoBoxPooledObject>.NativeClassPtr));
		}
	}

	// Token: 0x1700162C RID: 5676
	// (get) Token: 0x06003EA2 RID: 16034 RVA: 0x000FCB80 File Offset: 0x000FAD80
	// (set) Token: 0x06003EA3 RID: 16035 RVA: 0x000FCBB4 File Offset: 0x000FADB4
	public unsafe AmmoRefill AmmoRefil
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoBoxPooledObject.NativeFieldInfoPtr_AmmoRefil);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? new AmmoRefill(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmmoBoxPooledObject.NativeFieldInfoPtr_AmmoRefil), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400282E RID: 10286
	private static readonly IntPtr NativeFieldInfoPtr_AmmoRefil;

	// Token: 0x0400282F RID: 10287
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
