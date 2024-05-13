using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Networking.Transport
{
	// Token: 0x0200126B RID: 4715
	[StructLayout(0)]
	public sealed class EncryptionTransportConfig : ValueType
	{
		// Token: 0x1700790B RID: 30987
		// (get) Token: 0x06015724 RID: 87844 RVA: 0x005657BC File Offset: 0x005639BC
		// (set) Token: 0x06015725 RID: 87845 RVA: 0x0056580C File Offset: 0x00563A0C
		public unsafe bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EncryptionTransportConfig.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptionTransportConfig.NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700790C RID: 30988
		// (get) Token: 0x06015726 RID: 87846 RVA: 0x00565860 File Offset: 0x00563A60
		// (set) Token: 0x06015727 RID: 87847 RVA: 0x005658AC File Offset: 0x00563AAC
		public unsafe string CertificateData
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(EncryptionTransportConfig.NativeMethodInfoPtr_get_CertificateData_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptionTransportConfig.NativeMethodInfoPtr_set_CertificateData_Private_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700790D RID: 30989
		// (get) Token: 0x06015728 RID: 87848 RVA: 0x00565904 File Offset: 0x00563B04
		// (set) Token: 0x06015729 RID: 87849 RVA: 0x00565950 File Offset: 0x00563B50
		public unsafe string PrivateKeyData
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(EncryptionTransportConfig.NativeMethodInfoPtr_get_PrivateKeyData_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptionTransportConfig.NativeMethodInfoPtr_set_PrivateKeyData_Private_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0601572A RID: 87850 RVA: 0x005659A8 File Offset: 0x00563BA8
		[CallerCount(0)]
		public unsafe static EncryptionTransportConfig MakeForServer(string certData, string privateKeyData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(certData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(privateKeyData);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptionTransportConfig.NativeMethodInfoPtr_MakeForServer_Public_Static_EncryptionTransportConfig_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return new EncryptionTransportConfig(intPtr);
		}

		// Token: 0x0601572B RID: 87851 RVA: 0x00565A14 File Offset: 0x00563C14
		[CallerCount(0)]
		public unsafe static EncryptionTransportConfig MakeForClient(string certData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(certData);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncryptionTransportConfig.NativeMethodInfoPtr_MakeForClient_Public_Static_EncryptionTransportConfig_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return new EncryptionTransportConfig(intPtr);
		}

		// Token: 0x0601572C RID: 87852 RVA: 0x00565A68 File Offset: 0x00563C68
		// Note: this type is marked as 'beforefieldinit'.
		static EncryptionTransportConfig()
		{
			Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Networking.Transport", "EncryptionTransportConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr);
			EncryptionTransportConfig.NativeFieldInfoPtr__IsValid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, "<IsValid>k__BackingField");
			EncryptionTransportConfig.NativeFieldInfoPtr__CertificateData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, "<CertificateData>k__BackingField");
			EncryptionTransportConfig.NativeFieldInfoPtr__PrivateKeyData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, "<PrivateKeyData>k__BackingField");
			EncryptionTransportConfig.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, 100690760);
			EncryptionTransportConfig.NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, 100690761);
			EncryptionTransportConfig.NativeMethodInfoPtr_get_CertificateData_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, 100690762);
			EncryptionTransportConfig.NativeMethodInfoPtr_set_CertificateData_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, 100690763);
			EncryptionTransportConfig.NativeMethodInfoPtr_get_PrivateKeyData_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, 100690764);
			EncryptionTransportConfig.NativeMethodInfoPtr_set_PrivateKeyData_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, 100690765);
			EncryptionTransportConfig.NativeMethodInfoPtr_MakeForServer_Public_Static_EncryptionTransportConfig_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, 100690766);
			EncryptionTransportConfig.NativeMethodInfoPtr_MakeForClient_Public_Static_EncryptionTransportConfig_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, 100690767);
		}

		// Token: 0x0601572D RID: 87853 RVA: 0x0002717B File Offset: 0x0002537B
		public EncryptionTransportConfig(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17007907 RID: 30983
		// (get) Token: 0x0601572E RID: 87854 RVA: 0x00565B74 File Offset: 0x00563D74
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr));
			}
		}

		// Token: 0x0601572F RID: 87855 RVA: 0x00565B88 File Offset: 0x00563D88
		public unsafe EncryptionTransportConfig()
		{
			IntPtr data = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, (UIntPtr)0)];
			base..ctor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EncryptionTransportConfig>.NativeClassPtr, data));
		}

		// Token: 0x17007908 RID: 30984
		// (get) Token: 0x06015730 RID: 87856 RVA: 0x00565BB8 File Offset: 0x00563DB8
		// (set) Token: 0x06015731 RID: 87857 RVA: 0x00565BE0 File Offset: 0x00563DE0
		public unsafe bool _IsValid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncryptionTransportConfig.NativeFieldInfoPtr__IsValid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncryptionTransportConfig.NativeFieldInfoPtr__IsValid_k__BackingField)) = value;
			}
		}

		// Token: 0x17007909 RID: 30985
		// (get) Token: 0x06015732 RID: 87858 RVA: 0x00565C04 File Offset: 0x00563E04
		// (set) Token: 0x06015733 RID: 87859 RVA: 0x00565C2D File Offset: 0x00563E2D
		public unsafe string _CertificateData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncryptionTransportConfig.NativeFieldInfoPtr__CertificateData_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncryptionTransportConfig.NativeFieldInfoPtr__CertificateData_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700790A RID: 30986
		// (get) Token: 0x06015734 RID: 87860 RVA: 0x00565C54 File Offset: 0x00563E54
		// (set) Token: 0x06015735 RID: 87861 RVA: 0x00565C7D File Offset: 0x00563E7D
		public unsafe string _PrivateKeyData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncryptionTransportConfig.NativeFieldInfoPtr__PrivateKeyData_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncryptionTransportConfig.NativeFieldInfoPtr__PrivateKeyData_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400DBD6 RID: 56278
		private static readonly IntPtr NativeFieldInfoPtr__IsValid_k__BackingField;

		// Token: 0x0400DBD7 RID: 56279
		private static readonly IntPtr NativeFieldInfoPtr__CertificateData_k__BackingField;

		// Token: 0x0400DBD8 RID: 56280
		private static readonly IntPtr NativeFieldInfoPtr__PrivateKeyData_k__BackingField;

		// Token: 0x0400DBD9 RID: 56281
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x0400DBDA RID: 56282
		private static readonly IntPtr NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0;

		// Token: 0x0400DBDB RID: 56283
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateData_Public_get_String_0;

		// Token: 0x0400DBDC RID: 56284
		private static readonly IntPtr NativeMethodInfoPtr_set_CertificateData_Private_set_Void_String_0;

		// Token: 0x0400DBDD RID: 56285
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateKeyData_Public_get_String_0;

		// Token: 0x0400DBDE RID: 56286
		private static readonly IntPtr NativeMethodInfoPtr_set_PrivateKeyData_Private_set_Void_String_0;

		// Token: 0x0400DBDF RID: 56287
		private static readonly IntPtr NativeMethodInfoPtr_MakeForServer_Public_Static_EncryptionTransportConfig_String_String_0;

		// Token: 0x0400DBE0 RID: 56288
		private static readonly IntPtr NativeMethodInfoPtr_MakeForClient_Public_Static_EncryptionTransportConfig_String_0;
	}
}
