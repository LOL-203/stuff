using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace RealisticEyeMovements
{
	// Token: 0x0200078E RID: 1934
	public class Utils : Il2CppSystem.Object
	{
		// Token: 0x0600A0FB RID: 41211 RVA: 0x0028BDC4 File Offset: 0x00289FC4
		[CallerCount(0)]
		public unsafe static bool CanGetTransformFromPath(Transform startXform, string path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(startXform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_CanGetTransformFromPath_Public_Static_Boolean_Transform_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A0FC RID: 41212 RVA: 0x0028BE34 File Offset: 0x0028A034
		[CallerCount(0)]
		public unsafe static float EaseSineIn(float t, float b, float c, float d)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref t;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_EaseSineIn_Public_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A0FD RID: 41213 RVA: 0x0028BEC0 File Offset: 0x0028A0C0
		[CallerCount(0)]
		public unsafe static float Fbm(Vector2 coord, int octave)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref coord;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref octave;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Fbm_Public_Static_Single_Vector2_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A0FE RID: 41214 RVA: 0x0028BF28 File Offset: 0x0028A128
		[CallerCount(0)]
		public unsafe static GameObject FindChildInHierarchy(GameObject go, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_FindChildInHierarchy_Public_Static_GameObject_GameObject_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}

		// Token: 0x0600A0FF RID: 41215 RVA: 0x0028BFA0 File Offset: 0x0028A1A0
		[CallerCount(0)]
		public unsafe static Transform GetCommonAncestor(Transform xform1, Transform xform2)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(xform1);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xform2);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetCommonAncestor_Public_Static_Transform_Transform_Transform_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}

		// Token: 0x0600A100 RID: 41216 RVA: 0x0028C018 File Offset: 0x0028A218
		[CallerCount(0)]
		public unsafe static string GetPathForTransform(Transform startXform, Transform targetXform)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(startXform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetXform);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetPathForTransform_Public_Static_String_Transform_Transform_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A101 RID: 41217 RVA: 0x0028C084 File Offset: 0x0028A284
		[CallerCount(0)]
		public unsafe static Transform GetTransformFromPath(Transform startXform, string path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(startXform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetTransformFromPath_Public_Static_Transform_Transform_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Transform(intPtr2) : null;
		}

		// Token: 0x0600A102 RID: 41218 RVA: 0x0028C0FC File Offset: 0x0028A2FC
		[CallerCount(0)]
		public unsafe static bool IsEqualOrDescendant(Transform ancestor, Transform descendant)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ancestor);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descendant);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_IsEqualOrDescendant_Public_Static_Boolean_Transform_Transform_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A103 RID: 41219 RVA: 0x0028C16C File Offset: 0x0028A36C
		[CallerCount(0)]
		public unsafe static float NormalizedDegAngle(float degrees)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref degrees;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_NormalizedDegAngle_Public_Static_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A104 RID: 41220 RVA: 0x0028C1C0 File Offset: 0x0028A3C0
		[CallerCount(0)]
		public unsafe static void PlaceDummyObject(string name, Vector3 pos, [Optional] float scale, [Optional] Nullable<Quaternion> rotation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rotation));
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_PlaceDummyObject_Public_Static_Void_String_Vector3_Single_Nullable_1_Quaternion_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A105 RID: 41221 RVA: 0x0028C250 File Offset: 0x0028A450
		[CallerCount(0)]
		public unsafe Utils() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Utils>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A106 RID: 41222 RVA: 0x0028C29C File Offset: 0x0028A49C
		// Note: this type is marked as 'beforefieldinit'.
		static Utils()
		{
			Il2CppClassPointerStore<Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RealisticEyeMovements", "Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utils>.NativeClassPtr);
			Utils.NativeFieldInfoPtr_dummyObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "dummyObjects");
			Utils.NativeMethodInfoPtr_CanGetTransformFromPath_Public_Static_Boolean_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100676074);
			Utils.NativeMethodInfoPtr_EaseSineIn_Public_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100676075);
			Utils.NativeMethodInfoPtr_Fbm_Public_Static_Single_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100676076);
			Utils.NativeMethodInfoPtr_FindChildInHierarchy_Public_Static_GameObject_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100676077);
			Utils.NativeMethodInfoPtr_GetCommonAncestor_Public_Static_Transform_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100676078);
			Utils.NativeMethodInfoPtr_GetPathForTransform_Public_Static_String_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100676079);
			Utils.NativeMethodInfoPtr_GetTransformFromPath_Public_Static_Transform_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100676080);
			Utils.NativeMethodInfoPtr_IsEqualOrDescendant_Public_Static_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100676081);
			Utils.NativeMethodInfoPtr_NormalizedDegAngle_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100676082);
			Utils.NativeMethodInfoPtr_PlaceDummyObject_Public_Static_Void_String_Vector3_Single_Nullable_1_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100676083);
			Utils.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100676084);
		}

		// Token: 0x0600A107 RID: 41223 RVA: 0x00002988 File Offset: 0x00000B88
		public Utils(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170039B7 RID: 14775
		// (get) Token: 0x0600A108 RID: 41224 RVA: 0x0028C3BC File Offset: 0x0028A5BC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Utils>.NativeClassPtr));
			}
		}

		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x0600A109 RID: 41225 RVA: 0x0028C3D0 File Offset: 0x0028A5D0
		// (set) Token: 0x0600A10A RID: 41226 RVA: 0x0028C3FB File Offset: 0x0028A5FB
		public unsafe static Dictionary<string, GameObject> dummyObjects
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_dummyObjects, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Dictionary<string, GameObject>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_dummyObjects, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006654 RID: 26196
		private static readonly IntPtr NativeFieldInfoPtr_dummyObjects;

		// Token: 0x04006655 RID: 26197
		private static readonly IntPtr NativeMethodInfoPtr_CanGetTransformFromPath_Public_Static_Boolean_Transform_String_0;

		// Token: 0x04006656 RID: 26198
		private static readonly IntPtr NativeMethodInfoPtr_EaseSineIn_Public_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04006657 RID: 26199
		private static readonly IntPtr NativeMethodInfoPtr_Fbm_Public_Static_Single_Vector2_Int32_0;

		// Token: 0x04006658 RID: 26200
		private static readonly IntPtr NativeMethodInfoPtr_FindChildInHierarchy_Public_Static_GameObject_GameObject_String_0;

		// Token: 0x04006659 RID: 26201
		private static readonly IntPtr NativeMethodInfoPtr_GetCommonAncestor_Public_Static_Transform_Transform_Transform_0;

		// Token: 0x0400665A RID: 26202
		private static readonly IntPtr NativeMethodInfoPtr_GetPathForTransform_Public_Static_String_Transform_Transform_0;

		// Token: 0x0400665B RID: 26203
		private static readonly IntPtr NativeMethodInfoPtr_GetTransformFromPath_Public_Static_Transform_Transform_String_0;

		// Token: 0x0400665C RID: 26204
		private static readonly IntPtr NativeMethodInfoPtr_IsEqualOrDescendant_Public_Static_Boolean_Transform_Transform_0;

		// Token: 0x0400665D RID: 26205
		private static readonly IntPtr NativeMethodInfoPtr_NormalizedDegAngle_Public_Static_Single_Single_0;

		// Token: 0x0400665E RID: 26206
		private static readonly IntPtr NativeMethodInfoPtr_PlaceDummyObject_Public_Static_Void_String_Vector3_Single_Nullable_1_Quaternion_0;

		// Token: 0x0400665F RID: 26207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
