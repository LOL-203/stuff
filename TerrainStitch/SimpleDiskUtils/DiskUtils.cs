using System;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace SimpleDiskUtils
{
	// Token: 0x0200065A RID: 1626
	public class DiskUtils : Object
	{
		// Token: 0x060083BD RID: 33725 RVA: 0x00216828 File Offset: 0x00214A28
		[CallerCount(0)]
		public unsafe static int getAvailableDiskSpace(StringBuilder drive)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(drive);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr_getAvailableDiskSpace_Private_Static_Int32_StringBuilder_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060083BE RID: 33726 RVA: 0x00216880 File Offset: 0x00214A80
		[CallerCount(0)]
		public unsafe static int getTotalDiskSpace(StringBuilder drive)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(drive);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr_getTotalDiskSpace_Private_Static_Int32_StringBuilder_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060083BF RID: 33727 RVA: 0x002168D8 File Offset: 0x00214AD8
		[CallerCount(0)]
		public unsafe static int getBusyDiskSpace(StringBuilder drive)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(drive);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr_getBusyDiskSpace_Private_Static_Int32_StringBuilder_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060083C0 RID: 33728 RVA: 0x00216930 File Offset: 0x00214B30
		[CallerCount(0)]
		public unsafe static int CheckAvailableSpace(string drive = "C:/")
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(drive);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr_CheckAvailableSpace_Public_Static_Int32_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060083C1 RID: 33729 RVA: 0x00216988 File Offset: 0x00214B88
		[CallerCount(0)]
		public unsafe static int CheckTotalSpace(string drive = "C:/")
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(drive);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr_CheckTotalSpace_Public_Static_Int32_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060083C2 RID: 33730 RVA: 0x002169E0 File Offset: 0x00214BE0
		[CallerCount(0)]
		public unsafe static int CheckBusySpace(string drive = "C:/")
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(drive);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr_CheckBusySpace_Public_Static_Int32_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060083C3 RID: 33731 RVA: 0x00216A38 File Offset: 0x00214C38
		[CallerCount(0)]
		public unsafe static Il2CppStringArray GetDriveNames()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr_GetDriveNames_Public_Static_ArrayOf_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Il2CppStringArray(intPtr2) : null;
		}

		// Token: 0x060083C4 RID: 33732 RVA: 0x00216A80 File Offset: 0x00214C80
		[CallerCount(0)]
		public unsafe static void DeleteFile(string filePath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060083C5 RID: 33733 RVA: 0x00216ACC File Offset: 0x00214CCC
		[CallerCount(0)]
		public unsafe static void SaveFile(Object obj, string filePath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filePath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr_SaveFile_Public_Static_Void_Object_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060083C6 RID: 33734 RVA: 0x00216B30 File Offset: 0x00214D30
		[CallerCount(0)]
		public unsafe static void SaveFile(Object obj, string dirPath, string fileName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dirPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr_SaveFile_Public_Static_Void_Object_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060083C7 RID: 33735 RVA: 0x00216BAC File Offset: 0x00214DAC
		[CallerCount(0)]
		public unsafe static T LoadFile<T>(string filePath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			IntPtr returnedException;
			IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(DiskUtils.MethodInfoStoreGeneric_LoadFile_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x060083C8 RID: 33736 RVA: 0x00216C04 File Offset: 0x00214E04
		[CallerCount(0)]
		public unsafe static void SaveTextFile(string str, string filePath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filePath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr_SaveTextFile_Public_Static_Void_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060083C9 RID: 33737 RVA: 0x00216C68 File Offset: 0x00214E68
		[CallerCount(0)]
		public unsafe static void SaveTextFile(string str, string dirPath, string fileName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dirPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr_SaveTextFile_Public_Static_Void_String_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x00216CE4 File Offset: 0x00214EE4
		[CallerCount(0)]
		public unsafe static string LoadTextFile<T>(string filePath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DiskUtils.MethodInfoStoreGeneric_LoadTextFile_Public_Static_String_String_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x00216D38 File Offset: 0x00214F38
		[CallerCount(0)]
		public unsafe static Il2CppStructArray<byte> ObjectToByteArray(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr_ObjectToByteArray_Public_Static_ArrayOf_Byte_Object_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Il2CppStructArray<byte>(intPtr2) : null;
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x00216D98 File Offset: 0x00214F98
		[CallerCount(0)]
		public unsafe static T ByteArrayToObject<T>(Il2CppStructArray<byte> bytes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			IntPtr returnedException;
			IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(DiskUtils.MethodInfoStoreGeneric_ByteArrayToObject_Public_Static_T_ArrayOf_Byte_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x060083CD RID: 33741 RVA: 0x00216DF0 File Offset: 0x00214FF0
		[CallerCount(0)]
		public unsafe DiskUtils() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiskUtils.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x00216E3C File Offset: 0x0021503C
		// Note: this type is marked as 'beforefieldinit'.
		static DiskUtils()
		{
			Il2CppClassPointerStore<DiskUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SimpleDiskUtils", "DiskUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr);
			DiskUtils.NativeFieldInfoPtr_DEFAULT_DRIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, "DEFAULT_DRIVE");
			DiskUtils.NativeMethodInfoPtr_getAvailableDiskSpace_Private_Static_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673966);
			DiskUtils.NativeMethodInfoPtr_getTotalDiskSpace_Private_Static_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673967);
			DiskUtils.NativeMethodInfoPtr_getBusyDiskSpace_Private_Static_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673968);
			DiskUtils.NativeMethodInfoPtr_CheckAvailableSpace_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673969);
			DiskUtils.NativeMethodInfoPtr_CheckTotalSpace_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673970);
			DiskUtils.NativeMethodInfoPtr_CheckBusySpace_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673971);
			DiskUtils.NativeMethodInfoPtr_GetDriveNames_Public_Static_ArrayOf_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673972);
			DiskUtils.NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673973);
			DiskUtils.NativeMethodInfoPtr_SaveFile_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673974);
			DiskUtils.NativeMethodInfoPtr_SaveFile_Public_Static_Void_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673975);
			DiskUtils.NativeMethodInfoPtr_LoadFile_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673976);
			DiskUtils.NativeMethodInfoPtr_SaveTextFile_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673977);
			DiskUtils.NativeMethodInfoPtr_SaveTextFile_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673978);
			DiskUtils.NativeMethodInfoPtr_LoadTextFile_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673979);
			DiskUtils.NativeMethodInfoPtr_ObjectToByteArray_Public_Static_ArrayOf_Byte_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673980);
			DiskUtils.NativeMethodInfoPtr_ByteArrayToObject_Public_Static_T_ArrayOf_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673981);
			DiskUtils.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr, 100673982);
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x00002988 File Offset: 0x00000B88
		public DiskUtils(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x060083D0 RID: 33744 RVA: 0x00216FD4 File Offset: 0x002151D4
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DiskUtils>.NativeClassPtr));
			}
		}

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x060083D1 RID: 33745 RVA: 0x00216FE8 File Offset: 0x002151E8
		// (set) Token: 0x060083D2 RID: 33746 RVA: 0x00217008 File Offset: 0x00215208
		public unsafe static string DEFAULT_DRIVE
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(DiskUtils.NativeFieldInfoPtr_DEFAULT_DRIVE, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DiskUtils.NativeFieldInfoPtr_DEFAULT_DRIVE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04005464 RID: 21604
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_DRIVE;

		// Token: 0x04005465 RID: 21605
		private static readonly IntPtr NativeMethodInfoPtr_getAvailableDiskSpace_Private_Static_Int32_StringBuilder_0;

		// Token: 0x04005466 RID: 21606
		private static readonly IntPtr NativeMethodInfoPtr_getTotalDiskSpace_Private_Static_Int32_StringBuilder_0;

		// Token: 0x04005467 RID: 21607
		private static readonly IntPtr NativeMethodInfoPtr_getBusyDiskSpace_Private_Static_Int32_StringBuilder_0;

		// Token: 0x04005468 RID: 21608
		private static readonly IntPtr NativeMethodInfoPtr_CheckAvailableSpace_Public_Static_Int32_String_0;

		// Token: 0x04005469 RID: 21609
		private static readonly IntPtr NativeMethodInfoPtr_CheckTotalSpace_Public_Static_Int32_String_0;

		// Token: 0x0400546A RID: 21610
		private static readonly IntPtr NativeMethodInfoPtr_CheckBusySpace_Public_Static_Int32_String_0;

		// Token: 0x0400546B RID: 21611
		private static readonly IntPtr NativeMethodInfoPtr_GetDriveNames_Public_Static_ArrayOf_0;

		// Token: 0x0400546C RID: 21612
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0;

		// Token: 0x0400546D RID: 21613
		private static readonly IntPtr NativeMethodInfoPtr_SaveFile_Public_Static_Void_Object_String_0;

		// Token: 0x0400546E RID: 21614
		private static readonly IntPtr NativeMethodInfoPtr_SaveFile_Public_Static_Void_Object_String_String_0;

		// Token: 0x0400546F RID: 21615
		private static readonly IntPtr NativeMethodInfoPtr_LoadFile_Public_Static_T_String_0;

		// Token: 0x04005470 RID: 21616
		private static readonly IntPtr NativeMethodInfoPtr_SaveTextFile_Public_Static_Void_String_String_0;

		// Token: 0x04005471 RID: 21617
		private static readonly IntPtr NativeMethodInfoPtr_SaveTextFile_Public_Static_Void_String_String_String_0;

		// Token: 0x04005472 RID: 21618
		private static readonly IntPtr NativeMethodInfoPtr_LoadTextFile_Public_Static_String_String_0;

		// Token: 0x04005473 RID: 21619
		private static readonly IntPtr NativeMethodInfoPtr_ObjectToByteArray_Public_Static_ArrayOf_Byte_Object_0;

		// Token: 0x04005474 RID: 21620
		private static readonly IntPtr NativeMethodInfoPtr_ByteArrayToObject_Public_Static_T_ArrayOf_Byte_0;

		// Token: 0x04005475 RID: 21621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200065B RID: 1627
		private sealed class MethodInfoStoreGeneric_LoadFile_Public_Static_T_String_0<T>
		{
			// Token: 0x04005476 RID: 21622
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DiskUtils.NativeMethodInfoPtr_LoadFile_Public_Static_T_String_0, Il2CppClassPointerStore<DiskUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200065C RID: 1628
		private sealed class MethodInfoStoreGeneric_LoadTextFile_Public_Static_String_String_0<T>
		{
			// Token: 0x04005477 RID: 21623
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DiskUtils.NativeMethodInfoPtr_LoadTextFile_Public_Static_String_String_0, Il2CppClassPointerStore<DiskUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200065D RID: 1629
		private sealed class MethodInfoStoreGeneric_ByteArrayToObject_Public_Static_T_ArrayOf_Byte_0<T>
		{
			// Token: 0x04005478 RID: 21624
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DiskUtils.NativeMethodInfoPtr_ByteArrayToObject_Public_Static_T_ArrayOf_Byte_0, Il2CppClassPointerStore<DiskUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
