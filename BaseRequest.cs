using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x020004A6 RID: 1190
[Serializable]
public class BaseRequest<T> : Object
{
	// Token: 0x06005EBD RID: 24253 RVA: 0x0017AE00 File Offset: 0x00179000
	[CallerCount(0)]
	public unsafe BaseRequest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseRequest<T>>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRequest<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005EBE RID: 24254 RVA: 0x0017AE4C File Offset: 0x0017904C
	// Note: this type is marked as 'beforefieldinit'.
	static BaseRequest()
	{
		Il2CppClassPointerStore<BaseRequest<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BaseRequest`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseRequest<T>>.NativeClassPtr);
		BaseRequest<T>.NativeFieldInfoPtr_game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRequest<T>>.NativeClassPtr, "game");
		BaseRequest<T>.NativeFieldInfoPtr_params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRequest<T>>.NativeClassPtr, "params");
		BaseRequest<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRequest<T>>.NativeClassPtr, 100670786);
	}

	// Token: 0x06005EBF RID: 24255 RVA: 0x00002988 File Offset: 0x00000B88
	public BaseRequest(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170021A9 RID: 8617
	// (get) Token: 0x06005EC0 RID: 24256 RVA: 0x0017AEF3 File Offset: 0x001790F3
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BaseRequest<T>>.NativeClassPtr));
		}
	}

	// Token: 0x170021AA RID: 8618
	// (get) Token: 0x06005EC1 RID: 24257 RVA: 0x0017AF04 File Offset: 0x00179104
	// (set) Token: 0x06005EC2 RID: 24258 RVA: 0x0017AF2D File Offset: 0x0017912D
	public unsafe string game
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRequest<T>.NativeFieldInfoPtr_game);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRequest<T>.NativeFieldInfoPtr_game), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170021AB RID: 8619
	// (get) Token: 0x06005EC3 RID: 24259 RVA: 0x0017AF54 File Offset: 0x00179154
	// (set) Token: 0x06005EC4 RID: 24260 RVA: 0x0017AF80 File Offset: 0x00179180
	public unsafe T @params
	{
		get
		{
			IntPtr objectPointer = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRequest<T>.NativeFieldInfoPtr_params);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRequest<T>.NativeFieldInfoPtr_params);
			Type typeFromHandle = typeof(T);
			if (!typeFromHandle.IsValueType)
			{
				if (!string.Equals(typeFromHandle.FullName, "System.String"))
				{
					IntPtr value2;
					IntPtr intPtr3 = value2 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
					if (intPtr3 != 0)
					{
						value2 = intPtr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
						{
							IntPtr obj = intPtr3;
							cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(obj), (UIntPtr)0));
							return;
						}
					}
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr2, value2);
				}
				else
				{
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
				}
			}
			else
			{
				*intPtr2 = value;
			}
		}
	}

	// Token: 0x04003BD6 RID: 15318
	private static readonly IntPtr NativeFieldInfoPtr_game;

	// Token: 0x04003BD7 RID: 15319
	private static readonly IntPtr NativeFieldInfoPtr_params;

	// Token: 0x04003BD8 RID: 15320
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
