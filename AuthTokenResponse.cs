using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x020004A3 RID: 1187
[Serializable]
public class AuthTokenResponse : Object
{
	// Token: 0x06005EA1 RID: 24225 RVA: 0x0017A8F4 File Offset: 0x00178AF4
	[CallerCount(0)]
	public unsafe AuthTokenResponse() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthTokenResponse>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthTokenResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06005EA2 RID: 24226 RVA: 0x0017A940 File Offset: 0x00178B40
	// Note: this type is marked as 'beforefieldinit'.
	static AuthTokenResponse()
	{
		Il2CppClassPointerStore<AuthTokenResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AuthTokenResponse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthTokenResponse>.NativeClassPtr);
		AuthTokenResponse.NativeFieldInfoPtr_access_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthTokenResponse>.NativeClassPtr, "access_token");
		AuthTokenResponse.NativeFieldInfoPtr_api = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthTokenResponse>.NativeClassPtr, "api");
		AuthTokenResponse.NativeFieldInfoPtr_domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthTokenResponse>.NativeClassPtr, "domain");
		AuthTokenResponse.NativeFieldInfoPtr_issuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthTokenResponse>.NativeClassPtr, "issuer");
		AuthTokenResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthTokenResponse>.NativeClassPtr, 100670783);
	}

	// Token: 0x06005EA3 RID: 24227 RVA: 0x00002988 File Offset: 0x00000B88
	public AuthTokenResponse(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700219E RID: 8606
	// (get) Token: 0x06005EA4 RID: 24228 RVA: 0x0017A9D4 File Offset: 0x00178BD4
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AuthTokenResponse>.NativeClassPtr));
		}
	}

	// Token: 0x1700219F RID: 8607
	// (get) Token: 0x06005EA5 RID: 24229 RVA: 0x0017A9E8 File Offset: 0x00178BE8
	// (set) Token: 0x06005EA6 RID: 24230 RVA: 0x0017AA11 File Offset: 0x00178C11
	public unsafe string access_token
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthTokenResponse.NativeFieldInfoPtr_access_token);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthTokenResponse.NativeFieldInfoPtr_access_token), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170021A0 RID: 8608
	// (get) Token: 0x06005EA7 RID: 24231 RVA: 0x0017AA38 File Offset: 0x00178C38
	// (set) Token: 0x06005EA8 RID: 24232 RVA: 0x0017AA61 File Offset: 0x00178C61
	public unsafe string api
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthTokenResponse.NativeFieldInfoPtr_api);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthTokenResponse.NativeFieldInfoPtr_api), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170021A1 RID: 8609
	// (get) Token: 0x06005EA9 RID: 24233 RVA: 0x0017AA88 File Offset: 0x00178C88
	// (set) Token: 0x06005EAA RID: 24234 RVA: 0x0017AAB1 File Offset: 0x00178CB1
	public unsafe string domain
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthTokenResponse.NativeFieldInfoPtr_domain);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthTokenResponse.NativeFieldInfoPtr_domain), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170021A2 RID: 8610
	// (get) Token: 0x06005EAB RID: 24235 RVA: 0x0017AAD8 File Offset: 0x00178CD8
	// (set) Token: 0x06005EAC RID: 24236 RVA: 0x0017AB01 File Offset: 0x00178D01
	public unsafe string issuer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthTokenResponse.NativeFieldInfoPtr_issuer);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthTokenResponse.NativeFieldInfoPtr_issuer), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04003BCB RID: 15307
	private static readonly IntPtr NativeFieldInfoPtr_access_token;

	// Token: 0x04003BCC RID: 15308
	private static readonly IntPtr NativeFieldInfoPtr_api;

	// Token: 0x04003BCD RID: 15309
	private static readonly IntPtr NativeFieldInfoPtr_domain;

	// Token: 0x04003BCE RID: 15310
	private static readonly IntPtr NativeFieldInfoPtr_issuer;

	// Token: 0x04003BCF RID: 15311
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
