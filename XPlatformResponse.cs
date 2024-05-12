using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x02000310 RID: 784
[Serializable]
public class XPlatformResponse : Object
{
	// Token: 0x06003DB4 RID: 15796 RVA: 0x000F9158 File Offset: 0x000F7358
	[CallerCount(0)]
	public unsafe static XPlatformResponse CreateFromJSON(string json)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPlatformResponse.NativeMethodInfoPtr_CreateFromJSON_Public_Static_XPlatformResponse_String_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new XPlatformResponse(intPtr2) : null;
	}

	// Token: 0x06003DB5 RID: 15797 RVA: 0x000F91B8 File Offset: 0x000F73B8
	[CallerCount(0)]
	public unsafe XPlatformResponse() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPlatformResponse>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPlatformResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06003DB6 RID: 15798 RVA: 0x000F9204 File Offset: 0x000F7404
	// Note: this type is marked as 'beforefieldinit'.
	static XPlatformResponse()
	{
		Il2CppClassPointerStore<XPlatformResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "XPlatformResponse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPlatformResponse>.NativeClassPtr);
		XPlatformResponse.NativeFieldInfoPtr_xplatform_access_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPlatformResponse>.NativeClassPtr, "xplatform_access_token");
		XPlatformResponse.NativeMethodInfoPtr_CreateFromJSON_Public_Static_XPlatformResponse_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPlatformResponse>.NativeClassPtr, 100668233);
		XPlatformResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPlatformResponse>.NativeClassPtr, 100668234);
	}

	// Token: 0x06003DB7 RID: 15799 RVA: 0x00002988 File Offset: 0x00000B88
	public XPlatformResponse(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x170015D5 RID: 5589
	// (get) Token: 0x06003DB8 RID: 15800 RVA: 0x000F9270 File Offset: 0x000F7470
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<XPlatformResponse>.NativeClassPtr));
		}
	}

	// Token: 0x170015D6 RID: 5590
	// (get) Token: 0x06003DB9 RID: 15801 RVA: 0x000F9284 File Offset: 0x000F7484
	// (set) Token: 0x06003DBA RID: 15802 RVA: 0x000F92AD File Offset: 0x000F74AD
	public unsafe string xplatform_access_token
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPlatformResponse.NativeFieldInfoPtr_xplatform_access_token);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPlatformResponse.NativeFieldInfoPtr_xplatform_access_token), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040027A1 RID: 10145
	private static readonly IntPtr NativeFieldInfoPtr_xplatform_access_token;

	// Token: 0x040027A2 RID: 10146
	private static readonly IntPtr NativeMethodInfoPtr_CreateFromJSON_Public_Static_XPlatformResponse_String_0;

	// Token: 0x040027A3 RID: 10147
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
