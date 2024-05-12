using System;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x020004BC RID: 1212
public class WAVSaver : Object
{
	// Token: 0x06006070 RID: 24688 RVA: 0x0018294C File Offset: 0x00180B4C
	[CallerCount(0)]
	public unsafe void Save(string filename, Il2CppStructArray<short> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WAVSaver.NativeMethodInfoPtr_Save_Public_Void_String_ArrayOf_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006071 RID: 24689 RVA: 0x001829C0 File Offset: 0x00180BC0
	[CallerCount(0)]
	public unsafe void Save(string filename, Il2CppStructArray<float> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WAVSaver.NativeMethodInfoPtr_Save_Public_Void_String_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006072 RID: 24690 RVA: 0x00182A34 File Offset: 0x00180C34
	[CallerCount(0)]
	public unsafe FileStream CreateEmpty(string filepath)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filepath);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WAVSaver.NativeMethodInfoPtr_CreateEmpty_Private_FileStream_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
		IntPtr intPtr2 = intPtr;
		return (intPtr2 != 0) ? new FileStream(intPtr2) : null;
	}

	// Token: 0x06006073 RID: 24691 RVA: 0x00182AA4 File Offset: 0x00180CA4
	[CallerCount(0)]
	public unsafe void ConvertAndWrite(MemoryStream memoryStream, Il2CppStructArray<short> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(memoryStream);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WAVSaver.NativeMethodInfoPtr_ConvertAndWrite_Private_Void_MemoryStream_ArrayOf_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006074 RID: 24692 RVA: 0x00182B18 File Offset: 0x00180D18
	[CallerCount(0)]
	public unsafe void ConvertAndWrite(BinaryWriter binaryWriter, Il2CppStructArray<float> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(binaryWriter);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WAVSaver.NativeMethodInfoPtr_ConvertAndWrite_Private_Void_BinaryWriter_ArrayOf_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006075 RID: 24693 RVA: 0x00182B8C File Offset: 0x00180D8C
	[CallerCount(0)]
	public unsafe WAVSaver() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WAVSaver>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WAVSaver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006076 RID: 24694 RVA: 0x00182BD8 File Offset: 0x00180DD8
	// Note: this type is marked as 'beforefieldinit'.
	static WAVSaver()
	{
		Il2CppClassPointerStore<WAVSaver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "WAVSaver");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WAVSaver>.NativeClassPtr);
		WAVSaver.NativeMethodInfoPtr_Save_Public_Void_String_ArrayOf_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WAVSaver>.NativeClassPtr, 100670969);
		WAVSaver.NativeMethodInfoPtr_Save_Public_Void_String_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WAVSaver>.NativeClassPtr, 100670970);
		WAVSaver.NativeMethodInfoPtr_CreateEmpty_Private_FileStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WAVSaver>.NativeClassPtr, 100670971);
		WAVSaver.NativeMethodInfoPtr_ConvertAndWrite_Private_Void_MemoryStream_ArrayOf_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WAVSaver>.NativeClassPtr, 100670972);
		WAVSaver.NativeMethodInfoPtr_ConvertAndWrite_Private_Void_BinaryWriter_ArrayOf_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WAVSaver>.NativeClassPtr, 100670973);
		WAVSaver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WAVSaver>.NativeClassPtr, 100670974);
	}

	// Token: 0x06006077 RID: 24695 RVA: 0x00002988 File Offset: 0x00000B88
	public WAVSaver(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700222D RID: 8749
	// (get) Token: 0x06006078 RID: 24696 RVA: 0x00182C80 File Offset: 0x00180E80
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<WAVSaver>.NativeClassPtr));
		}
	}

	// Token: 0x04003CF3 RID: 15603
	private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Void_String_ArrayOf_Int16_0;

	// Token: 0x04003CF4 RID: 15604
	private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Void_String_ArrayOf_Single_0;

	// Token: 0x04003CF5 RID: 15605
	private static readonly IntPtr NativeMethodInfoPtr_CreateEmpty_Private_FileStream_String_0;

	// Token: 0x04003CF6 RID: 15606
	private static readonly IntPtr NativeMethodInfoPtr_ConvertAndWrite_Private_Void_MemoryStream_ArrayOf_Int16_0;

	// Token: 0x04003CF7 RID: 15607
	private static readonly IntPtr NativeMethodInfoPtr_ConvertAndWrite_Private_Void_BinaryWriter_ArrayOf_Single_0;

	// Token: 0x04003CF8 RID: 15608
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
