using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace ProCore.Decals
{
	// Token: 0x02000790 RID: 1936
	[Serializable]
	public class Decal : Il2CppSystem.Object
	{
		// Token: 0x0600A10F RID: 41231 RVA: 0x0028C4A8 File Offset: 0x0028A6A8
		[CallerCount(0)]
		public unsafe Decal() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Decal>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A110 RID: 41232 RVA: 0x0028C4F4 File Offset: 0x0028A6F4
		[CallerCount(0)]
		public unsafe Decal(Texture2D img) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Decal>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(img);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr__ctor_Public_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A111 RID: 41233 RVA: 0x0028C558 File Offset: 0x0028A758
		[CallerCount(0)]
		public new unsafe string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A112 RID: 41234 RVA: 0x0028C5B0 File Offset: 0x0028A7B0
		[CallerCount(0)]
		public unsafe static bool Deserialize(string txt, out Decal decal)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(txt);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(decal);
			ptr2 = &intPtr;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_String_byref_Decal_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			decal = ((intPtr2 == 0) ? null : new Decal(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A113 RID: 41235 RVA: 0x0028C640 File Offset: 0x0028A840
		[CallerCount(0)]
		public unsafe string Serialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_Serialize_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600A114 RID: 41236 RVA: 0x0028C68C File Offset: 0x0028A88C
		[CallerCount(0)]
		public unsafe static bool Vec3WithString(string str, ref Vector3 vec3)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vec3;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_Vec3WithString_Private_Static_Boolean_String_byref_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A115 RID: 41237 RVA: 0x0028C6F8 File Offset: 0x0028A8F8
		[CallerCount(0)]
		public unsafe static bool Vec4WithString(string str, ref Vector4 vec4)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &vec4;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_Vec4WithString_Private_Static_Boolean_String_byref_Vector4_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A116 RID: 41238 RVA: 0x0028C764 File Offset: 0x0028A964
		[CallerCount(0)]
		public unsafe static Rect Vec4ToRect(Vector4 v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Decal.NativeMethodInfoPtr_Vec4ToRect_Private_Static_Rect_Vector4_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A117 RID: 41239 RVA: 0x0028C7B8 File Offset: 0x0028A9B8
		// Note: this type is marked as 'beforefieldinit'.
		static Decal()
		{
			Il2CppClassPointerStore<Decal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ProCore.Decals", "Decal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decal>.NativeClassPtr);
			Decal.NativeFieldInfoPtr_DefaultRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "DefaultRotation");
			Decal.NativeFieldInfoPtr_DefaultScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "DefaultScale");
			Decal.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "name");
			Decal.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "id");
			Decal.NativeFieldInfoPtr_isPacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "isPacked");
			Decal.NativeFieldInfoPtr_materialId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "materialId");
			Decal.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "rotation");
			Decal.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "scale");
			Decal.NativeFieldInfoPtr_atlasRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "atlasRect");
			Decal.NativeFieldInfoPtr_orgGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "orgGroup");
			Decal.NativeFieldInfoPtr_orgIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "orgIndex");
			Decal.NativeFieldInfoPtr_atlasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "atlasGroup");
			Decal.NativeFieldInfoPtr_atlasIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "atlasIndex");
			Decal.NativeFieldInfoPtr_rotationPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "rotationPlacement");
			Decal.NativeFieldInfoPtr_scalePlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "scalePlacement");
			Decal.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decal>.NativeClassPtr, "texture");
			Decal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100676087);
			Decal.NativeMethodInfoPtr__ctor_Public_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100676088);
			Decal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100676089);
			Decal.NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_String_byref_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100676090);
			Decal.NativeMethodInfoPtr_Serialize_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100676091);
			Decal.NativeMethodInfoPtr_Vec3WithString_Private_Static_Boolean_String_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100676092);
			Decal.NativeMethodInfoPtr_Vec4WithString_Private_Static_Boolean_String_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100676093);
			Decal.NativeMethodInfoPtr_Vec4ToRect_Private_Static_Rect_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decal>.NativeClassPtr, 100676094);
		}

		// Token: 0x0600A118 RID: 41240 RVA: 0x00002988 File Offset: 0x00000B88
		public Decal(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x0600A119 RID: 41241 RVA: 0x0028C9C8 File Offset: 0x0028ABC8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Decal>.NativeClassPtr));
			}
		}

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x0600A11A RID: 41242 RVA: 0x0028C9DC File Offset: 0x0028ABDC
		// (set) Token: 0x0600A11B RID: 41243 RVA: 0x0028C9FA File Offset: 0x0028ABFA
		public unsafe static Vector3 DefaultRotation
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Decal.NativeFieldInfoPtr_DefaultRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decal.NativeFieldInfoPtr_DefaultRotation, (void*)(&value));
			}
		}

		// Token: 0x170039BC RID: 14780
		// (get) Token: 0x0600A11C RID: 41244 RVA: 0x0028CA0C File Offset: 0x0028AC0C
		// (set) Token: 0x0600A11D RID: 41245 RVA: 0x0028CA2A File Offset: 0x0028AC2A
		public unsafe static Vector3 DefaultScale
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Decal.NativeFieldInfoPtr_DefaultScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decal.NativeFieldInfoPtr_DefaultScale, (void*)(&value));
			}
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x0600A11E RID: 41246 RVA: 0x0028CA3C File Offset: 0x0028AC3C
		// (set) Token: 0x0600A11F RID: 41247 RVA: 0x0028CA65 File Offset: 0x0028AC65
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x0600A120 RID: 41248 RVA: 0x0028CA8C File Offset: 0x0028AC8C
		// (set) Token: 0x0600A121 RID: 41249 RVA: 0x0028CAB5 File Offset: 0x0028ACB5
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x0600A122 RID: 41250 RVA: 0x0028CADC File Offset: 0x0028ACDC
		// (set) Token: 0x0600A123 RID: 41251 RVA: 0x0028CB04 File Offset: 0x0028AD04
		public unsafe bool isPacked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_isPacked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_isPacked)) = value;
			}
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x0600A124 RID: 41252 RVA: 0x0028CB28 File Offset: 0x0028AD28
		// (set) Token: 0x0600A125 RID: 41253 RVA: 0x0028CB51 File Offset: 0x0028AD51
		public unsafe string materialId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_materialId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_materialId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x0600A126 RID: 41254 RVA: 0x0028CB78 File Offset: 0x0028AD78
		// (set) Token: 0x0600A127 RID: 41255 RVA: 0x0028CBA0 File Offset: 0x0028ADA0
		public unsafe Vector3 rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x0600A128 RID: 41256 RVA: 0x0028CBC4 File Offset: 0x0028ADC4
		// (set) Token: 0x0600A129 RID: 41257 RVA: 0x0028CBEC File Offset: 0x0028ADEC
		public unsafe Vector3 scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x0600A12A RID: 41258 RVA: 0x0028CC10 File Offset: 0x0028AE10
		// (set) Token: 0x0600A12B RID: 41259 RVA: 0x0028CC38 File Offset: 0x0028AE38
		public unsafe Rect atlasRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_atlasRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_atlasRect)) = value;
			}
		}

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x0600A12C RID: 41260 RVA: 0x0028CC5C File Offset: 0x0028AE5C
		// (set) Token: 0x0600A12D RID: 41261 RVA: 0x0028CC84 File Offset: 0x0028AE84
		public unsafe int orgGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_orgGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_orgGroup)) = value;
			}
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x0600A12E RID: 41262 RVA: 0x0028CCA8 File Offset: 0x0028AEA8
		// (set) Token: 0x0600A12F RID: 41263 RVA: 0x0028CCD0 File Offset: 0x0028AED0
		public unsafe int orgIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_orgIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_orgIndex)) = value;
			}
		}

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x0600A130 RID: 41264 RVA: 0x0028CCF4 File Offset: 0x0028AEF4
		// (set) Token: 0x0600A131 RID: 41265 RVA: 0x0028CD1C File Offset: 0x0028AF1C
		public unsafe int atlasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_atlasGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_atlasGroup)) = value;
			}
		}

		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x0600A132 RID: 41266 RVA: 0x0028CD40 File Offset: 0x0028AF40
		// (set) Token: 0x0600A133 RID: 41267 RVA: 0x0028CD68 File Offset: 0x0028AF68
		public unsafe int atlasIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_atlasIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_atlasIndex)) = value;
			}
		}

		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x0600A134 RID: 41268 RVA: 0x0028CD8C File Offset: 0x0028AF8C
		// (set) Token: 0x0600A135 RID: 41269 RVA: 0x0028CDB4 File Offset: 0x0028AFB4
		public unsafe Placement rotationPlacement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_rotationPlacement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_rotationPlacement)) = value;
			}
		}

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x0600A136 RID: 41270 RVA: 0x0028CDD8 File Offset: 0x0028AFD8
		// (set) Token: 0x0600A137 RID: 41271 RVA: 0x0028CE00 File Offset: 0x0028B000
		public unsafe Placement scalePlacement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_scalePlacement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_scalePlacement)) = value;
			}
		}

		// Token: 0x170039CA RID: 14794
		// (get) Token: 0x0600A138 RID: 41272 RVA: 0x0028CE24 File Offset: 0x0028B024
		// (set) Token: 0x0600A139 RID: 41273 RVA: 0x0028CE58 File Offset: 0x0028B058
		public unsafe Texture2D texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Texture2D(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decal.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006661 RID: 26209
		private static readonly IntPtr NativeFieldInfoPtr_DefaultRotation;

		// Token: 0x04006662 RID: 26210
		private static readonly IntPtr NativeFieldInfoPtr_DefaultScale;

		// Token: 0x04006663 RID: 26211
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04006664 RID: 26212
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04006665 RID: 26213
		private static readonly IntPtr NativeFieldInfoPtr_isPacked;

		// Token: 0x04006666 RID: 26214
		private static readonly IntPtr NativeFieldInfoPtr_materialId;

		// Token: 0x04006667 RID: 26215
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04006668 RID: 26216
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04006669 RID: 26217
		private static readonly IntPtr NativeFieldInfoPtr_atlasRect;

		// Token: 0x0400666A RID: 26218
		private static readonly IntPtr NativeFieldInfoPtr_orgGroup;

		// Token: 0x0400666B RID: 26219
		private static readonly IntPtr NativeFieldInfoPtr_orgIndex;

		// Token: 0x0400666C RID: 26220
		private static readonly IntPtr NativeFieldInfoPtr_atlasGroup;

		// Token: 0x0400666D RID: 26221
		private static readonly IntPtr NativeFieldInfoPtr_atlasIndex;

		// Token: 0x0400666E RID: 26222
		private static readonly IntPtr NativeFieldInfoPtr_rotationPlacement;

		// Token: 0x0400666F RID: 26223
		private static readonly IntPtr NativeFieldInfoPtr_scalePlacement;

		// Token: 0x04006670 RID: 26224
		private static readonly IntPtr NativeFieldInfoPtr_texture;

		// Token: 0x04006671 RID: 26225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006672 RID: 26226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture2D_0;

		// Token: 0x04006673 RID: 26227
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04006674 RID: 26228
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Boolean_String_byref_Decal_0;

		// Token: 0x04006675 RID: 26229
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_String_0;

		// Token: 0x04006676 RID: 26230
		private static readonly IntPtr NativeMethodInfoPtr_Vec3WithString_Private_Static_Boolean_String_byref_Vector3_0;

		// Token: 0x04006677 RID: 26231
		private static readonly IntPtr NativeMethodInfoPtr_Vec4WithString_Private_Static_Boolean_String_byref_Vector4_0;

		// Token: 0x04006678 RID: 26232
		private static readonly IntPtr NativeMethodInfoPtr_Vec4ToRect_Private_Static_Rect_Vector4_0;
	}
}
