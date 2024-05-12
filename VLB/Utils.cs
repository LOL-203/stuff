using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005EA RID: 1514
	public static class Utils : Il2CppSystem.Object
	{
		// Token: 0x06007A9A RID: 31386 RVA: 0x001ECB44 File Offset: 0x001EAD44
		[CallerCount(0)]
		public unsafe static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fallOffEnd;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spotAngle;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ComputeConeRadiusEnd_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x001ECBAC File Offset: 0x001EADAC
		[CallerCount(0)]
		public unsafe static void Swap<T>(ref T a, ref T b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr3 = &intPtr2;
			IntPtr returnedException;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr4 = intPtr;
			a = ((intPtr4 == 0) ? null : new T(intPtr4));
			IntPtr intPtr5 = intPtr2;
			b = ((intPtr5 == 0) ? null : new T(intPtr5));
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x001ECC50 File Offset: 0x001EAE50
		[CallerCount(0)]
		public unsafe static string GetPath(Transform current)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06007A9D RID: 31389 RVA: 0x001ECCA4 File Offset: 0x001EAEA4
		[CallerCount(0)]
		public unsafe static T NewWithComponent<T>(string name) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr returnedException;
			IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_NewWithComponent_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x001ECCFC File Offset: 0x001EAEFC
		[CallerCount(0)]
		public unsafe static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr returnedException;
			IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x001ECD54 File Offset: 0x001EAF54
		[CallerCount(0)]
		public unsafe static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr returnedException;
			IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_T_MonoBehaviour_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06007AA0 RID: 31392 RVA: 0x001ECDAC File Offset: 0x001EAFAC
		[CallerCount(0)]
		public unsafe static bool HasFlag(this Enum mask, Enum flags)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mask);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flags);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_HasFlag_Public_Static_Boolean_Enum_Enum_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AA1 RID: 31393 RVA: 0x001ECE1C File Offset: 0x001EB01C
		[CallerCount(0)]
		public unsafe static Vector2 xy(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_xy_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AA2 RID: 31394 RVA: 0x001ECE70 File Offset: 0x001EB070
		[CallerCount(0)]
		public unsafe static Vector2 xz(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_xz_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AA3 RID: 31395 RVA: 0x001ECEC4 File Offset: 0x001EB0C4
		[CallerCount(0)]
		public unsafe static Vector2 yz(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_yz_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AA4 RID: 31396 RVA: 0x001ECF18 File Offset: 0x001EB118
		[CallerCount(0)]
		public unsafe static Vector2 yx(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_yx_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x001ECF6C File Offset: 0x001EB16C
		[CallerCount(0)]
		public unsafe static Vector2 zx(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_zx_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x001ECFC0 File Offset: 0x001EB1C0
		[CallerCount(0)]
		public unsafe static Vector2 zy(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_zy_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AA7 RID: 31399 RVA: 0x001ED014 File Offset: 0x001EB214
		[CallerCount(0)]
		public unsafe static float GetVolumeCubic(this Bounds self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetVolumeCubic_Public_Static_Single_Bounds_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AA8 RID: 31400 RVA: 0x001ED068 File Offset: 0x001EB268
		[CallerCount(0)]
		public unsafe static float GetMaxArea2D(this Bounds self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetMaxArea2D_Public_Static_Single_Bounds_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AA9 RID: 31401 RVA: 0x001ED0BC File Offset: 0x001EB2BC
		[CallerCount(0)]
		public unsafe static Color Opaque(this Color self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Opaque_Public_Static_Color_Color_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AAA RID: 31402 RVA: 0x001ED110 File Offset: 0x001EB310
		[CallerCount(0)]
		public unsafe static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, [Optional] float size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normal;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GizmosDrawPlane_Public_Static_Void_Vector3_Vector3_Color_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AAB RID: 31403 RVA: 0x001ED190 File Offset: 0x001EB390
		[CallerCount(0)]
		public unsafe static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref plane;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref translation;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_TranslateCustom_Public_Static_Plane_Plane_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x001ED1F8 File Offset: 0x001EB3F8
		[CallerCount(0)]
		public unsafe static bool IsValid(this Plane plane)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref plane;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_Plane_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AAD RID: 31405 RVA: 0x001ED24C File Offset: 0x001EB44C
		[CallerCount(0)]
		public unsafe static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SetKeywordEnabled_Public_Static_Void_Material_String_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AAE RID: 31406 RVA: 0x001ED2C4 File Offset: 0x001EB4C4
		[CallerCount(0)]
		public unsafe static void SetShaderKeywordEnabled(string name, bool enabled)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SetShaderKeywordEnabled_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x001ED324 File Offset: 0x001EB524
		[CallerCount(0)]
		public unsafe static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatPackingPrecision;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SampleInMatrix_Public_Static_Matrix4x4_Gradient_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x001ED390 File Offset: 0x001EB590
		[CallerCount(0)]
		public unsafe static Il2CppStructArray<Color> SampleInArray(this Gradient self, int samplesCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplesCount;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SampleInArray_Public_Static_ArrayOf_Color_Gradient_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Il2CppStructArray<Color>(intPtr2) : null;
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x001ED404 File Offset: 0x001EB604
		[CallerCount(0)]
		public unsafe static Vector4 Vector4_Floor(Vector4 vec)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vec;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Vector4_Floor_Private_Static_Vector4_Vector4_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AB2 RID: 31410 RVA: 0x001ED458 File Offset: 0x001EB658
		[CallerCount(0)]
		public unsafe static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatPackingPrecision;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_PackToFloat_Public_Static_Single_Color_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AB3 RID: 31411 RVA: 0x001ED4C0 File Offset: 0x001EB6C0
		[CallerCount(0)]
		public unsafe static Utils.FloatPackingPrecision GetFloatPackingPrecision()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetFloatPackingPrecision_Public_Static_FloatPackingPrecision_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x001ED504 File Offset: 0x001EB704
		[CallerCount(0)]
		public unsafe static void MarkCurrentSceneDirty()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_MarkCurrentSceneDirty_Public_Static_Void_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AB5 RID: 31413 RVA: 0x001ED538 File Offset: 0x001EB738
		[CallerCount(0)]
		public unsafe static void MarkObjectDirty(UnityEngine.Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_MarkObjectDirty_Public_Static_Void_Object_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007AB6 RID: 31414 RVA: 0x001ED584 File Offset: 0x001EB784
		// Note: this type is marked as 'beforefieldinit'.
		static Utils()
		{
			Il2CppClassPointerStore<Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utils>.NativeClassPtr);
			Utils.NativeFieldInfoPtr_ms_FloatPackingPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "ms_FloatPackingPrecision");
			Utils.NativeFieldInfoPtr_kFloatPackingHighMinShaderLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "kFloatPackingHighMinShaderLevel");
			Utils.NativeMethodInfoPtr_ComputeConeRadiusEnd_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673059);
			Utils.NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673060);
			Utils.NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673061);
			Utils.NativeMethodInfoPtr_NewWithComponent_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673062);
			Utils.NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673063);
			Utils.NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673064);
			Utils.NativeMethodInfoPtr_HasFlag_Public_Static_Boolean_Enum_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673065);
			Utils.NativeMethodInfoPtr_xy_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673066);
			Utils.NativeMethodInfoPtr_xz_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673067);
			Utils.NativeMethodInfoPtr_yz_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673068);
			Utils.NativeMethodInfoPtr_yx_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673069);
			Utils.NativeMethodInfoPtr_zx_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673070);
			Utils.NativeMethodInfoPtr_zy_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673071);
			Utils.NativeMethodInfoPtr_GetVolumeCubic_Public_Static_Single_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673072);
			Utils.NativeMethodInfoPtr_GetMaxArea2D_Public_Static_Single_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673073);
			Utils.NativeMethodInfoPtr_Opaque_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673074);
			Utils.NativeMethodInfoPtr_GizmosDrawPlane_Public_Static_Void_Vector3_Vector3_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673075);
			Utils.NativeMethodInfoPtr_TranslateCustom_Public_Static_Plane_Plane_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673076);
			Utils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673077);
			Utils.NativeMethodInfoPtr_SetKeywordEnabled_Public_Static_Void_Material_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673078);
			Utils.NativeMethodInfoPtr_SetShaderKeywordEnabled_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673079);
			Utils.NativeMethodInfoPtr_SampleInMatrix_Public_Static_Matrix4x4_Gradient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673080);
			Utils.NativeMethodInfoPtr_SampleInArray_Public_Static_ArrayOf_Color_Gradient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673081);
			Utils.NativeMethodInfoPtr_Vector4_Floor_Private_Static_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673082);
			Utils.NativeMethodInfoPtr_PackToFloat_Public_Static_Single_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673083);
			Utils.NativeMethodInfoPtr_GetFloatPackingPrecision_Public_Static_FloatPackingPrecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673084);
			Utils.NativeMethodInfoPtr_MarkCurrentSceneDirty_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673085);
			Utils.NativeMethodInfoPtr_MarkObjectDirty_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100673086);
		}

		// Token: 0x06007AB7 RID: 31415 RVA: 0x00002988 File Offset: 0x00000B88
		public Utils(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x06007AB8 RID: 31416 RVA: 0x001ED80C File Offset: 0x001EBA0C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Utils>.NativeClassPtr));
			}
		}

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x06007AB9 RID: 31417 RVA: 0x001ED820 File Offset: 0x001EBA20
		// (set) Token: 0x06007ABA RID: 31418 RVA: 0x001ED83E File Offset: 0x001EBA3E
		public unsafe static Utils.FloatPackingPrecision ms_FloatPackingPrecision
		{
			get
			{
				Utils.FloatPackingPrecision result;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_ms_FloatPackingPrecision, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_ms_FloatPackingPrecision, (void*)(&value));
			}
		}

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x06007ABB RID: 31419 RVA: 0x001ED850 File Offset: 0x001EBA50
		// (set) Token: 0x06007ABC RID: 31420 RVA: 0x001ED86E File Offset: 0x001EBA6E
		public unsafe static int kFloatPackingHighMinShaderLevel
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_kFloatPackingHighMinShaderLevel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_kFloatPackingHighMinShaderLevel, (void*)(&value));
			}
		}

		// Token: 0x04004E7C RID: 20092
		private static readonly IntPtr NativeFieldInfoPtr_ms_FloatPackingPrecision;

		// Token: 0x04004E7D RID: 20093
		private static readonly IntPtr NativeFieldInfoPtr_kFloatPackingHighMinShaderLevel;

		// Token: 0x04004E7E RID: 20094
		private static readonly IntPtr NativeMethodInfoPtr_ComputeConeRadiusEnd_Public_Static_Single_Single_Single_0;

		// Token: 0x04004E7F RID: 20095
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0;

		// Token: 0x04004E80 RID: 20096
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0;

		// Token: 0x04004E81 RID: 20097
		private static readonly IntPtr NativeMethodInfoPtr_NewWithComponent_Public_Static_T_String_0;

		// Token: 0x04004E82 RID: 20098
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_GameObject_0;

		// Token: 0x04004E83 RID: 20099
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_MonoBehaviour_0;

		// Token: 0x04004E84 RID: 20100
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Public_Static_Boolean_Enum_Enum_0;

		// Token: 0x04004E85 RID: 20101
		private static readonly IntPtr NativeMethodInfoPtr_xy_Public_Static_Vector2_Vector3_0;

		// Token: 0x04004E86 RID: 20102
		private static readonly IntPtr NativeMethodInfoPtr_xz_Public_Static_Vector2_Vector3_0;

		// Token: 0x04004E87 RID: 20103
		private static readonly IntPtr NativeMethodInfoPtr_yz_Public_Static_Vector2_Vector3_0;

		// Token: 0x04004E88 RID: 20104
		private static readonly IntPtr NativeMethodInfoPtr_yx_Public_Static_Vector2_Vector3_0;

		// Token: 0x04004E89 RID: 20105
		private static readonly IntPtr NativeMethodInfoPtr_zx_Public_Static_Vector2_Vector3_0;

		// Token: 0x04004E8A RID: 20106
		private static readonly IntPtr NativeMethodInfoPtr_zy_Public_Static_Vector2_Vector3_0;

		// Token: 0x04004E8B RID: 20107
		private static readonly IntPtr NativeMethodInfoPtr_GetVolumeCubic_Public_Static_Single_Bounds_0;

		// Token: 0x04004E8C RID: 20108
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxArea2D_Public_Static_Single_Bounds_0;

		// Token: 0x04004E8D RID: 20109
		private static readonly IntPtr NativeMethodInfoPtr_Opaque_Public_Static_Color_Color_0;

		// Token: 0x04004E8E RID: 20110
		private static readonly IntPtr NativeMethodInfoPtr_GizmosDrawPlane_Public_Static_Void_Vector3_Vector3_Color_Single_0;

		// Token: 0x04004E8F RID: 20111
		private static readonly IntPtr NativeMethodInfoPtr_TranslateCustom_Public_Static_Plane_Plane_Vector3_0;

		// Token: 0x04004E90 RID: 20112
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_Plane_0;

		// Token: 0x04004E91 RID: 20113
		private static readonly IntPtr NativeMethodInfoPtr_SetKeywordEnabled_Public_Static_Void_Material_String_Boolean_0;

		// Token: 0x04004E92 RID: 20114
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderKeywordEnabled_Public_Static_Void_String_Boolean_0;

		// Token: 0x04004E93 RID: 20115
		private static readonly IntPtr NativeMethodInfoPtr_SampleInMatrix_Public_Static_Matrix4x4_Gradient_Int32_0;

		// Token: 0x04004E94 RID: 20116
		private static readonly IntPtr NativeMethodInfoPtr_SampleInArray_Public_Static_ArrayOf_Color_Gradient_Int32_0;

		// Token: 0x04004E95 RID: 20117
		private static readonly IntPtr NativeMethodInfoPtr_Vector4_Floor_Private_Static_Vector4_Vector4_0;

		// Token: 0x04004E96 RID: 20118
		private static readonly IntPtr NativeMethodInfoPtr_PackToFloat_Public_Static_Single_Color_Int32_0;

		// Token: 0x04004E97 RID: 20119
		private static readonly IntPtr NativeMethodInfoPtr_GetFloatPackingPrecision_Public_Static_FloatPackingPrecision_0;

		// Token: 0x04004E98 RID: 20120
		private static readonly IntPtr NativeMethodInfoPtr_MarkCurrentSceneDirty_Public_Static_Void_0;

		// Token: 0x04004E99 RID: 20121
		private static readonly IntPtr NativeMethodInfoPtr_MarkObjectDirty_Public_Static_Void_Object_0;

		// Token: 0x020005EB RID: 1515
		public enum FloatPackingPrecision
		{
			// Token: 0x04004E9B RID: 20123
			High = 64,
			// Token: 0x04004E9C RID: 20124
			Low = 8,
			// Token: 0x04004E9D RID: 20125
			Undef = 0
		}

		// Token: 0x020005EC RID: 1516
		private sealed class MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>
		{
			// Token: 0x04004E9E RID: 20126
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020005ED RID: 1517
		private sealed class MethodInfoStoreGeneric_NewWithComponent_Public_Static_T_String_0<T>
		{
			// Token: 0x04004E9F RID: 20127
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_NewWithComponent_Public_Static_T_String_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020005EE RID: 1518
		private sealed class MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_T_GameObject_0<T>
		{
			// Token: 0x04004EA0 RID: 20128
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_GameObject_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020005EF RID: 1519
		private sealed class MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_T_MonoBehaviour_0<T>
		{
			// Token: 0x04004EA1 RID: 20129
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_MonoBehaviour_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
