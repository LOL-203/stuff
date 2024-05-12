using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

// Token: 0x0200052E RID: 1326
public class BhapticsLogger : Object
{
	// Token: 0x06006C78 RID: 27768 RVA: 0x001B379C File Offset: 0x001B199C
	[CallerCount(0)]
	public unsafe static void LogDebug(string format, Il2CppReferenceArray<Object> args)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BhapticsLogger.NativeMethodInfoPtr_LogDebug_Public_Static_Void_String_ArrayOf_Object_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C79 RID: 27769 RVA: 0x001B3800 File Offset: 0x001B1A00
	[CallerCount(0)]
	public unsafe static void LogInfo(string format, Il2CppReferenceArray<Object> args)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BhapticsLogger.NativeMethodInfoPtr_LogInfo_Public_Static_Void_String_ArrayOf_Object_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C7A RID: 27770 RVA: 0x001B3864 File Offset: 0x001B1A64
	[CallerCount(0)]
	public unsafe static void LogError(string format, Il2CppReferenceArray<Object> args)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BhapticsLogger.NativeMethodInfoPtr_LogError_Public_Static_Void_String_ArrayOf_Object_0, 0, (void**)ptr, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C7B RID: 27771 RVA: 0x001B38C8 File Offset: 0x001B1AC8
	[CallerCount(0)]
	public unsafe BhapticsLogger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BhapticsLogger>.NativeClassPtr))
	{
		IntPtr* param = null;
		IntPtr returnedException;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BhapticsLogger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
		Il2CppException.RaiseExceptionIfNecessary(returnedException);
	}

	// Token: 0x06006C7C RID: 27772 RVA: 0x001B3914 File Offset: 0x001B1B14
	// Note: this type is marked as 'beforefieldinit'.
	static BhapticsLogger()
	{
		Il2CppClassPointerStore<BhapticsLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BhapticsLogger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BhapticsLogger>.NativeClassPtr);
		BhapticsLogger.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BhapticsLogger>.NativeClassPtr, "level");
		BhapticsLogger.NativeMethodInfoPtr_LogDebug_Public_Static_Void_String_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BhapticsLogger>.NativeClassPtr, 100671898);
		BhapticsLogger.NativeMethodInfoPtr_LogInfo_Public_Static_Void_String_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BhapticsLogger>.NativeClassPtr, 100671899);
		BhapticsLogger.NativeMethodInfoPtr_LogError_Public_Static_Void_String_ArrayOf_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BhapticsLogger>.NativeClassPtr, 100671900);
		BhapticsLogger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BhapticsLogger>.NativeClassPtr, 100671901);
	}

	// Token: 0x06006C7D RID: 27773 RVA: 0x00002988 File Offset: 0x00000B88
	public BhapticsLogger(IntPtr A_1) : base(A_1)
	{
	}

	// Token: 0x1700269D RID: 9885
	// (get) Token: 0x06006C7E RID: 27774 RVA: 0x001B39A8 File Offset: 0x001B1BA8
	[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
	public new static Type Il2CppType
	{
		get
		{
			return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BhapticsLogger>.NativeClassPtr));
		}
	}

	// Token: 0x1700269E RID: 9886
	// (get) Token: 0x06006C7F RID: 27775 RVA: 0x001B39BC File Offset: 0x001B1BBC
	// (set) Token: 0x06006C80 RID: 27776 RVA: 0x001B39DA File Offset: 0x001B1BDA
	public unsafe static BhapticsLogger.LogLevel level
	{
		get
		{
			BhapticsLogger.LogLevel result;
			IL2CPP.il2cpp_field_static_get_value(BhapticsLogger.NativeFieldInfoPtr_level, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BhapticsLogger.NativeFieldInfoPtr_level, (void*)(&value));
		}
	}

	// Token: 0x0400455E RID: 17758
	private static readonly IntPtr NativeFieldInfoPtr_level;

	// Token: 0x0400455F RID: 17759
	private static readonly IntPtr NativeMethodInfoPtr_LogDebug_Public_Static_Void_String_ArrayOf_Object_0;

	// Token: 0x04004560 RID: 17760
	private static readonly IntPtr NativeMethodInfoPtr_LogInfo_Public_Static_Void_String_ArrayOf_Object_0;

	// Token: 0x04004561 RID: 17761
	private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_String_ArrayOf_Object_0;

	// Token: 0x04004562 RID: 17762
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200052F RID: 1327
	public enum LogLevel
	{
		// Token: 0x04004564 RID: 17764
		Debug,
		// Token: 0x04004565 RID: 17765
		Info,
		// Token: 0x04004566 RID: 17766
		Error
	}
}
