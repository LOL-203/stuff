using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace DPI.Settings
{
	// Token: 0x02000FDB RID: 4059
	public static class OnwardPrefs : Il2CppSystem.Object
	{
		// Token: 0x06013786 RID: 79750 RVA: 0x004E5FB8 File Offset: 0x004E41B8
		[CallerCount(0)]
		public unsafe static void Save(OnwardPrefsStorage storage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(storage);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_OnwardPrefsStorage_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013787 RID: 79751 RVA: 0x004E6004 File Offset: 0x004E4204
		[CallerCount(0)]
		public unsafe static void DeleteAll(OnwardPrefsStorage storage)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(storage);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_DeleteAll_Public_Static_Void_OnwardPrefsStorage_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013788 RID: 79752 RVA: 0x004E6050 File Offset: 0x004E4250
		[CallerCount(0)]
		public unsafe static void DeleteKey<T>(OnwardPrefsKey<T> keyName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyName));
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.MethodInfoStoreGeneric_DeleteKey_Public_Static_Void_OnwardPrefsKey_1_T_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013789 RID: 79753 RVA: 0x004E60A0 File Offset: 0x004E42A0
		[CallerCount(0)]
		public unsafe static bool HasKey<T>(OnwardPrefsKey<T> keyName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyName));
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.MethodInfoStoreGeneric_HasKey_Public_Static_Boolean_OnwardPrefsKey_1_T_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601378A RID: 79754 RVA: 0x004E6100 File Offset: 0x004E4300
		[CallerCount(0)]
		public unsafe static bool HasKey<T1, T2>(OnwardPrefsKey<T1, T2> keyName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyName));
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.MethodInfoStoreGeneric_HasKey_Public_Static_Boolean_OnwardPrefsKey_2_T1_T2_0<T1, T2>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601378B RID: 79755 RVA: 0x004E6160 File Offset: 0x004E4360
		[CallerCount(0)]
		public unsafe static int GetInt(OnwardPrefsKey<int> intKey, [Optional] int defaultValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(intKey));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_OnwardPrefsKey_1_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601378C RID: 79756 RVA: 0x004E61D0 File Offset: 0x004E43D0
		[CallerCount(0)]
		public unsafe static void SetInt(OnwardPrefsKey<int> intKey, int intValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(intKey));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intValue;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_OnwardPrefsKey_1_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601378D RID: 79757 RVA: 0x004E6234 File Offset: 0x004E4434
		[CallerCount(0)]
		public unsafe static bool GetBool(OnwardPrefsKey<bool> boolKey, bool defaultValue = false)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(boolKey));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_GetBool_Public_Static_Boolean_OnwardPrefsKey_1_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0601378E RID: 79758 RVA: 0x004E62A4 File Offset: 0x004E44A4
		[CallerCount(0)]
		public unsafe static void SetBool(OnwardPrefsKey<bool> boolKey, bool boolValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(boolKey));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boolValue;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_SetBool_Public_Static_Void_OnwardPrefsKey_1_Boolean_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601378F RID: 79759 RVA: 0x004E6308 File Offset: 0x004E4508
		[CallerCount(0)]
		public unsafe static float GetFloat(OnwardPrefsKey<float> floatKey, [Optional] float defaultValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(floatKey));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_OnwardPrefsKey_1_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013790 RID: 79760 RVA: 0x004E6378 File Offset: 0x004E4578
		[CallerCount(0)]
		public unsafe static void SetFloat(OnwardPrefsKey<float> floatKey, float floatValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(floatKey));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatValue;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_OnwardPrefsKey_1_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013791 RID: 79761 RVA: 0x004E63DC File Offset: 0x004E45DC
		[CallerCount(0)]
		public unsafe static Vector2 GetVector2(OnwardPrefsKey<Vector2> vec2Key, [Optional] Vector2 defaultValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vec2Key));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_OnwardPrefsKey_1_Vector2_Vector2_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013792 RID: 79762 RVA: 0x004E644C File Offset: 0x004E464C
		[CallerCount(0)]
		public unsafe static void SetVector2(OnwardPrefsKey<Vector2> vec2Key, Vector2 vec2Value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vec2Key));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vec2Value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_SetVector2_Public_Static_Void_OnwardPrefsKey_1_Vector2_Vector2_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013793 RID: 79763 RVA: 0x004E64B0 File Offset: 0x004E46B0
		[CallerCount(0)]
		public unsafe static Vector3 GetVector3(OnwardPrefsKey<Vector3> vec3Key, [Optional] Vector3 defaultValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vec3Key));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_OnwardPrefsKey_1_Vector3_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013794 RID: 79764 RVA: 0x004E6520 File Offset: 0x004E4720
		[CallerCount(0)]
		public unsafe static void SetVector3(OnwardPrefsKey<Vector3> vec3Key, Vector3 vec3Value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vec3Key));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vec3Value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_SetVector3_Public_Static_Void_OnwardPrefsKey_1_Vector3_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013795 RID: 79765 RVA: 0x004E6584 File Offset: 0x004E4784
		[CallerCount(0)]
		public unsafe static Vector4 GetVector4(OnwardPrefsKey<Vector4> vec4Key, [Optional] Vector4 defaultValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vec4Key));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_GetVector4_Public_Static_Vector4_OnwardPrefsKey_1_Vector4_Vector4_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06013796 RID: 79766 RVA: 0x004E65F4 File Offset: 0x004E47F4
		[CallerCount(0)]
		public unsafe static void SetVector4(OnwardPrefsKey<Vector4> vec4Key, Vector4 vec4Value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(vec4Key));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vec4Value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_SetVector4_Public_Static_Void_OnwardPrefsKey_1_Vector4_Vector4_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013797 RID: 79767 RVA: 0x004E6658 File Offset: 0x004E4858
		[CallerCount(0)]
		public unsafe static string GetString(OnwardPrefsKey<string> strKey, [Optional] string defaultValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(strKey));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_OnwardPrefsKey_1_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06013798 RID: 79768 RVA: 0x004E66C8 File Offset: 0x004E48C8
		[CallerCount(0)]
		public unsafe static void SetString(OnwardPrefsKey<string> strKey, string strValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(strKey));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strValue);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnwardPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_OnwardPrefsKey_1_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06013799 RID: 79769 RVA: 0x004E6730 File Offset: 0x004E4930
		// Note: this type is marked as 'beforefieldinit'.
		static OnwardPrefs()
		{
			Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Settings", "OnwardPrefs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr);
			OnwardPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_OnwardPrefsStorage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688132);
			OnwardPrefs.NativeMethodInfoPtr_DeleteAll_Public_Static_Void_OnwardPrefsStorage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688133);
			OnwardPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_OnwardPrefsKey_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688134);
			OnwardPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_OnwardPrefsKey_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688135);
			OnwardPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_OnwardPrefsKey_2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688136);
			OnwardPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_OnwardPrefsKey_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688137);
			OnwardPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_OnwardPrefsKey_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688138);
			OnwardPrefs.NativeMethodInfoPtr_GetBool_Public_Static_Boolean_OnwardPrefsKey_1_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688139);
			OnwardPrefs.NativeMethodInfoPtr_SetBool_Public_Static_Void_OnwardPrefsKey_1_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688140);
			OnwardPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_OnwardPrefsKey_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688141);
			OnwardPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_OnwardPrefsKey_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688142);
			OnwardPrefs.NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_OnwardPrefsKey_1_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688143);
			OnwardPrefs.NativeMethodInfoPtr_SetVector2_Public_Static_Void_OnwardPrefsKey_1_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688144);
			OnwardPrefs.NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_OnwardPrefsKey_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688145);
			OnwardPrefs.NativeMethodInfoPtr_SetVector3_Public_Static_Void_OnwardPrefsKey_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688146);
			OnwardPrefs.NativeMethodInfoPtr_GetVector4_Public_Static_Vector4_OnwardPrefsKey_1_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688147);
			OnwardPrefs.NativeMethodInfoPtr_SetVector4_Public_Static_Void_OnwardPrefsKey_1_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688148);
			OnwardPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_OnwardPrefsKey_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688149);
			OnwardPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_OnwardPrefsKey_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr, 100688150);
		}

		// Token: 0x0601379A RID: 79770 RVA: 0x00002988 File Offset: 0x00000B88
		public OnwardPrefs(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17006E6E RID: 28270
		// (get) Token: 0x0601379B RID: 79771 RVA: 0x004E68DC File Offset: 0x004E4ADC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr));
			}
		}

		// Token: 0x0400C713 RID: 50963
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_OnwardPrefsStorage_0;

		// Token: 0x0400C714 RID: 50964
		private static readonly IntPtr NativeMethodInfoPtr_DeleteAll_Public_Static_Void_OnwardPrefsStorage_0;

		// Token: 0x0400C715 RID: 50965
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Public_Static_Void_OnwardPrefsKey_1_T_0;

		// Token: 0x0400C716 RID: 50966
		private static readonly IntPtr NativeMethodInfoPtr_HasKey_Public_Static_Boolean_OnwardPrefsKey_1_T_0;

		// Token: 0x0400C717 RID: 50967
		private static readonly IntPtr NativeMethodInfoPtr_HasKey_Public_Static_Boolean_OnwardPrefsKey_2_T1_T2_0;

		// Token: 0x0400C718 RID: 50968
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Static_Int32_OnwardPrefsKey_1_Int32_Int32_0;

		// Token: 0x0400C719 RID: 50969
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Static_Void_OnwardPrefsKey_1_Int32_Int32_0;

		// Token: 0x0400C71A RID: 50970
		private static readonly IntPtr NativeMethodInfoPtr_GetBool_Public_Static_Boolean_OnwardPrefsKey_1_Boolean_Boolean_0;

		// Token: 0x0400C71B RID: 50971
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Public_Static_Void_OnwardPrefsKey_1_Boolean_Boolean_0;

		// Token: 0x0400C71C RID: 50972
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Static_Single_OnwardPrefsKey_1_Single_Single_0;

		// Token: 0x0400C71D RID: 50973
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Static_Void_OnwardPrefsKey_1_Single_Single_0;

		// Token: 0x0400C71E RID: 50974
		private static readonly IntPtr NativeMethodInfoPtr_GetVector2_Public_Static_Vector2_OnwardPrefsKey_1_Vector2_Vector2_0;

		// Token: 0x0400C71F RID: 50975
		private static readonly IntPtr NativeMethodInfoPtr_SetVector2_Public_Static_Void_OnwardPrefsKey_1_Vector2_Vector2_0;

		// Token: 0x0400C720 RID: 50976
		private static readonly IntPtr NativeMethodInfoPtr_GetVector3_Public_Static_Vector3_OnwardPrefsKey_1_Vector3_Vector3_0;

		// Token: 0x0400C721 RID: 50977
		private static readonly IntPtr NativeMethodInfoPtr_SetVector3_Public_Static_Void_OnwardPrefsKey_1_Vector3_Vector3_0;

		// Token: 0x0400C722 RID: 50978
		private static readonly IntPtr NativeMethodInfoPtr_GetVector4_Public_Static_Vector4_OnwardPrefsKey_1_Vector4_Vector4_0;

		// Token: 0x0400C723 RID: 50979
		private static readonly IntPtr NativeMethodInfoPtr_SetVector4_Public_Static_Void_OnwardPrefsKey_1_Vector4_Vector4_0;

		// Token: 0x0400C724 RID: 50980
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_OnwardPrefsKey_1_String_String_0;

		// Token: 0x0400C725 RID: 50981
		private static readonly IntPtr NativeMethodInfoPtr_SetString_Public_Static_Void_OnwardPrefsKey_1_String_String_0;

		// Token: 0x02000FDC RID: 4060
		private sealed class MethodInfoStoreGeneric_DeleteKey_Public_Static_Void_OnwardPrefsKey_1_T_0<T>
		{
			// Token: 0x0400C726 RID: 50982
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OnwardPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_OnwardPrefsKey_1_T_0, Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000FDD RID: 4061
		private sealed class MethodInfoStoreGeneric_HasKey_Public_Static_Boolean_OnwardPrefsKey_1_T_0<T>
		{
			// Token: 0x0400C727 RID: 50983
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OnwardPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_OnwardPrefsKey_1_T_0, Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000FDE RID: 4062
		private sealed class MethodInfoStoreGeneric_HasKey_Public_Static_Boolean_OnwardPrefsKey_2_T1_T2_0<T1, T2>
		{
			// Token: 0x0400C728 RID: 50984
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OnwardPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_OnwardPrefsKey_2_T1_T2_0, Il2CppClassPointerStore<OnwardPrefs>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			}))));
		}
	}
}
