using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace ProCore.Decals
{
	// Token: 0x02000792 RID: 1938
	public static class qdUtil : Il2CppSystem.Object
	{
		// Token: 0x0600A151 RID: 41297 RVA: 0x0028D394 File Offset: 0x0028B594
		[CallerCount(0)]
		public unsafe static Il2CppReferenceArray<GameObject> FindDecalsWithTexture(Texture2D img)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(img);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(qdUtil.NativeMethodInfoPtr_FindDecalsWithTexture_Public_Static_ArrayOf_GameObject_Texture2D_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Il2CppReferenceArray<GameObject>(intPtr2) : null;
		}

		// Token: 0x0600A152 RID: 41298 RVA: 0x0028D3F4 File Offset: 0x0028B5F4
		[CallerCount(0)]
		public unsafe static void RefreshSceneDecals(DecalGroup dg)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dg);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(qdUtil.NativeMethodInfoPtr_RefreshSceneDecals_Public_Static_Void_DecalGroup_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A153 RID: 41299 RVA: 0x0028D440 File Offset: 0x0028B640
		[CallerCount(0)]
		public unsafe static void SortDecalsUsingView(ref List<Decal> decals, DecalView decalView)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(decals);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decalView;
			IntPtr returnedException;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(qdUtil.NativeMethodInfoPtr_SortDecalsUsingView_Public_Static_Void_byref_List_1_Decal_DecalView_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr3 = intPtr;
			decals = ((intPtr3 == 0) ? null : new List(intPtr3));
		}

		// Token: 0x0600A154 RID: 41300 RVA: 0x0028D4C0 File Offset: 0x0028B6C0
		[CallerCount(0)]
		public unsafe static bool Contains(this Dictionary<int, List<int>> dic, int key, int val)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dic);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(qdUtil.NativeMethodInfoPtr_Contains_Public_Static_Boolean_Dictionary_2_Int32_List_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A155 RID: 41301 RVA: 0x0028D540 File Offset: 0x0028B740
		[CallerCount(0)]
		public unsafe static void Add(this Dictionary<int, List<int>> dic, int key, int val)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dic);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(qdUtil.NativeMethodInfoPtr_Add_Public_Static_Void_Dictionary_2_Int32_List_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A156 RID: 41302 RVA: 0x0028D5B0 File Offset: 0x0028B7B0
		[CallerCount(0)]
		public unsafe static string ToFormattedString(this Dictionary<int, List<int>> dic)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dic);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(qdUtil.NativeMethodInfoPtr_ToFormattedString_Public_Static_String_Dictionary_2_Int32_List_1_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A157 RID: 41303 RVA: 0x0028D604 File Offset: 0x0028B804
		[CallerCount(0)]
		public unsafe static string ToFormattedString<T>(this Il2CppArrayBase<T> t, string _delimiter)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_delimiter);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(qdUtil.MethodInfoStoreGeneric_ToFormattedString_Public_Static_String_ArrayOf_T_String_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A158 RID: 41304 RVA: 0x0028D670 File Offset: 0x0028B870
		[CallerCount(0)]
		public unsafe static string ToFormattedString<T>(this List<T> t, string _delimiter)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_delimiter);
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(qdUtil.MethodInfoStoreGeneric_ToFormattedString_Public_Static_String_List_1_T_String_0<T>.Pointer, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A159 RID: 41305 RVA: 0x0028D6DC File Offset: 0x0028B8DC
		// Note: this type is marked as 'beforefieldinit'.
		static qdUtil()
		{
			Il2CppClassPointerStore<qdUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ProCore.Decals", "qdUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<qdUtil>.NativeClassPtr);
			qdUtil.NativeMethodInfoPtr_FindDecalsWithTexture_Public_Static_ArrayOf_GameObject_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<qdUtil>.NativeClassPtr, 100676098);
			qdUtil.NativeMethodInfoPtr_RefreshSceneDecals_Public_Static_Void_DecalGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<qdUtil>.NativeClassPtr, 100676099);
			qdUtil.NativeMethodInfoPtr_SortDecalsUsingView_Public_Static_Void_byref_List_1_Decal_DecalView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<qdUtil>.NativeClassPtr, 100676100);
			qdUtil.NativeMethodInfoPtr_Contains_Public_Static_Boolean_Dictionary_2_Int32_List_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<qdUtil>.NativeClassPtr, 100676101);
			qdUtil.NativeMethodInfoPtr_Add_Public_Static_Void_Dictionary_2_Int32_List_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<qdUtil>.NativeClassPtr, 100676102);
			qdUtil.NativeMethodInfoPtr_ToFormattedString_Public_Static_String_Dictionary_2_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<qdUtil>.NativeClassPtr, 100676103);
			qdUtil.NativeMethodInfoPtr_ToFormattedString_Public_Static_String_ArrayOf_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<qdUtil>.NativeClassPtr, 100676104);
			qdUtil.NativeMethodInfoPtr_ToFormattedString_Public_Static_String_List_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<qdUtil>.NativeClassPtr, 100676105);
		}

		// Token: 0x0600A15A RID: 41306 RVA: 0x00002988 File Offset: 0x00000B88
		public qdUtil(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170039D5 RID: 14805
		// (get) Token: 0x0600A15B RID: 41307 RVA: 0x0028D7AC File Offset: 0x0028B9AC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<qdUtil>.NativeClassPtr));
			}
		}

		// Token: 0x04006684 RID: 26244
		private static readonly IntPtr NativeMethodInfoPtr_FindDecalsWithTexture_Public_Static_ArrayOf_GameObject_Texture2D_0;

		// Token: 0x04006685 RID: 26245
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSceneDecals_Public_Static_Void_DecalGroup_0;

		// Token: 0x04006686 RID: 26246
		private static readonly IntPtr NativeMethodInfoPtr_SortDecalsUsingView_Public_Static_Void_byref_List_1_Decal_DecalView_0;

		// Token: 0x04006687 RID: 26247
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_Dictionary_2_Int32_List_1_Int32_Int32_Int32_0;

		// Token: 0x04006688 RID: 26248
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Void_Dictionary_2_Int32_List_1_Int32_Int32_Int32_0;

		// Token: 0x04006689 RID: 26249
		private static readonly IntPtr NativeMethodInfoPtr_ToFormattedString_Public_Static_String_Dictionary_2_Int32_List_1_Int32_0;

		// Token: 0x0400668A RID: 26250
		private static readonly IntPtr NativeMethodInfoPtr_ToFormattedString_Public_Static_String_ArrayOf_T_String_0;

		// Token: 0x0400668B RID: 26251
		private static readonly IntPtr NativeMethodInfoPtr_ToFormattedString_Public_Static_String_List_1_T_String_0;

		// Token: 0x02000793 RID: 1939
		private sealed class MethodInfoStoreGeneric_ToFormattedString_Public_Static_String_ArrayOf_T_String_0<T>
		{
			// Token: 0x0400668C RID: 26252
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(qdUtil.NativeMethodInfoPtr_ToFormattedString_Public_Static_String_ArrayOf_T_String_0, Il2CppClassPointerStore<qdUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000794 RID: 1940
		private sealed class MethodInfoStoreGeneric_ToFormattedString_Public_Static_String_List_1_T_String_0<T>
		{
			// Token: 0x0400668D RID: 26253
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(qdUtil.NativeMethodInfoPtr_ToFormattedString_Public_Static_String_List_1_T_String_0, Il2CppClassPointerStore<qdUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
