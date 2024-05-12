using System;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace ProCore.Decals
{
	// Token: 0x02000791 RID: 1937
	[Serializable]
	public class DecalGroup : Il2CppSystem.Object
	{
		// Token: 0x0600A13A RID: 41274 RVA: 0x0028CE80 File Offset: 0x0028B080
		[CallerCount(0)]
		public unsafe DecalGroup(string name, List<Decal> decals, bool isPacked, Shader shader, Material material, int maxAtlasSize, int padding) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decals);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPacked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shader);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxAtlasSize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref padding;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalGroup.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_Decal_Boolean_Shader_Material_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A13B RID: 41275 RVA: 0x0028CF64 File Offset: 0x0028B164
		[CallerCount(0)]
		public unsafe bool ContainsTexture(Texture2D tex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DecalGroup.NativeMethodInfoPtr_ContainsTexture_Public_Boolean_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A13C RID: 41276 RVA: 0x0028CFCC File Offset: 0x0028B1CC
		// Note: this type is marked as 'beforefieldinit'.
		static DecalGroup()
		{
			Il2CppClassPointerStore<DecalGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ProCore.Decals", "DecalGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr);
			DecalGroup.NativeFieldInfoPtr_MAX_ATLAS_SIZE_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr, "MAX_ATLAS_SIZE_DEFAULT");
			DecalGroup.NativeFieldInfoPtr_ATLAS_PADDING_DEFAULT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr, "ATLAS_PADDING_DEFAULT");
			DecalGroup.NativeFieldInfoPtr_decals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr, "decals");
			DecalGroup.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr, "name");
			DecalGroup.NativeFieldInfoPtr_shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr, "shader");
			DecalGroup.NativeFieldInfoPtr_isPacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr, "isPacked");
			DecalGroup.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr, "material");
			DecalGroup.NativeFieldInfoPtr_maxAtlasSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr, "maxAtlasSize");
			DecalGroup.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr, "padding");
			DecalGroup.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_Decal_Boolean_Shader_Material_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr, 100676096);
			DecalGroup.NativeMethodInfoPtr_ContainsTexture_Public_Boolean_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr, 100676097);
		}

		// Token: 0x0600A13D RID: 41277 RVA: 0x00002988 File Offset: 0x00000B88
		public DecalGroup(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x0600A13E RID: 41278 RVA: 0x0028D0D8 File Offset: 0x0028B2D8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DecalGroup>.NativeClassPtr));
			}
		}

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x0600A13F RID: 41279 RVA: 0x0028D0EC File Offset: 0x0028B2EC
		// (set) Token: 0x0600A140 RID: 41280 RVA: 0x0028D10A File Offset: 0x0028B30A
		public unsafe static int MAX_ATLAS_SIZE_DEFAULT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DecalGroup.NativeFieldInfoPtr_MAX_ATLAS_SIZE_DEFAULT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalGroup.NativeFieldInfoPtr_MAX_ATLAS_SIZE_DEFAULT, (void*)(&value));
			}
		}

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x0600A141 RID: 41281 RVA: 0x0028D11C File Offset: 0x0028B31C
		// (set) Token: 0x0600A142 RID: 41282 RVA: 0x0028D13A File Offset: 0x0028B33A
		public unsafe static int ATLAS_PADDING_DEFAULT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DecalGroup.NativeFieldInfoPtr_ATLAS_PADDING_DEFAULT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DecalGroup.NativeFieldInfoPtr_ATLAS_PADDING_DEFAULT, (void*)(&value));
			}
		}

		// Token: 0x170039CE RID: 14798
		// (get) Token: 0x0600A143 RID: 41283 RVA: 0x0028D14C File Offset: 0x0028B34C
		// (set) Token: 0x0600A144 RID: 41284 RVA: 0x0028D180 File Offset: 0x0028B380
		public unsafe List<Decal> decals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_decals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new List<Decal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_decals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x0600A145 RID: 41285 RVA: 0x0028D1A8 File Offset: 0x0028B3A8
		// (set) Token: 0x0600A146 RID: 41286 RVA: 0x0028D1D1 File Offset: 0x0028B3D1
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170039D0 RID: 14800
		// (get) Token: 0x0600A147 RID: 41287 RVA: 0x0028D1F8 File Offset: 0x0028B3F8
		// (set) Token: 0x0600A148 RID: 41288 RVA: 0x0028D22C File Offset: 0x0028B42C
		public unsafe Shader shader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_shader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Shader(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_shader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039D1 RID: 14801
		// (get) Token: 0x0600A149 RID: 41289 RVA: 0x0028D254 File Offset: 0x0028B454
		// (set) Token: 0x0600A14A RID: 41290 RVA: 0x0028D27C File Offset: 0x0028B47C
		public unsafe bool isPacked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_isPacked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_isPacked)) = value;
			}
		}

		// Token: 0x170039D2 RID: 14802
		// (get) Token: 0x0600A14B RID: 41291 RVA: 0x0028D2A0 File Offset: 0x0028B4A0
		// (set) Token: 0x0600A14C RID: 41292 RVA: 0x0028D2D4 File Offset: 0x0028B4D4
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Material(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039D3 RID: 14803
		// (get) Token: 0x0600A14D RID: 41293 RVA: 0x0028D2FC File Offset: 0x0028B4FC
		// (set) Token: 0x0600A14E RID: 41294 RVA: 0x0028D324 File Offset: 0x0028B524
		public unsafe int maxAtlasSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_maxAtlasSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_maxAtlasSize)) = value;
			}
		}

		// Token: 0x170039D4 RID: 14804
		// (get) Token: 0x0600A14F RID: 41295 RVA: 0x0028D348 File Offset: 0x0028B548
		// (set) Token: 0x0600A150 RID: 41296 RVA: 0x0028D370 File Offset: 0x0028B570
		public unsafe int padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalGroup.NativeFieldInfoPtr_padding)) = value;
			}
		}

		// Token: 0x04006679 RID: 26233
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ATLAS_SIZE_DEFAULT;

		// Token: 0x0400667A RID: 26234
		private static readonly IntPtr NativeFieldInfoPtr_ATLAS_PADDING_DEFAULT;

		// Token: 0x0400667B RID: 26235
		private static readonly IntPtr NativeFieldInfoPtr_decals;

		// Token: 0x0400667C RID: 26236
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400667D RID: 26237
		private static readonly IntPtr NativeFieldInfoPtr_shader;

		// Token: 0x0400667E RID: 26238
		private static readonly IntPtr NativeFieldInfoPtr_isPacked;

		// Token: 0x0400667F RID: 26239
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x04006680 RID: 26240
		private static readonly IntPtr NativeFieldInfoPtr_maxAtlasSize;

		// Token: 0x04006681 RID: 26241
		private static readonly IntPtr NativeFieldInfoPtr_padding;

		// Token: 0x04006682 RID: 26242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_Decal_Boolean_Shader_Material_Int32_Int32_0;

		// Token: 0x04006683 RID: 26243
		private static readonly IntPtr NativeMethodInfoPtr_ContainsTexture_Public_Boolean_Texture2D_0;
	}
}
