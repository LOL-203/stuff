using System;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	// Token: 0x020005DC RID: 1500
	public static class MaterialManager : Il2CppSystem.Object
	{
		// Token: 0x060079F0 RID: 31216 RVA: 0x001EAC74 File Offset: 0x001E8E74
		[CallerCount(0)]
		public unsafe static Material NewMaterial(bool gpuInstanced)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gpuInstanced;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_NewMaterial_Public_Static_Material_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Material(intPtr2) : null;
		}

		// Token: 0x060079F1 RID: 31217 RVA: 0x001EACD0 File Offset: 0x001E8ED0
		[CallerCount(0)]
		public unsafe static Material GetInstancedMaterial(uint groupID, MaterialManager.StaticProperties staticProps)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref groupID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(staticProps);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_StaticProperties_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Material(intPtr2) : null;
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x001EAD44 File Offset: 0x001E8F44
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialManager()
		{
			Il2CppClassPointerStore<MaterialManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MaterialManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr);
			MaterialManager.NativeFieldInfoPtr_materialPropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "materialPropertyBlock");
			MaterialManager.NativeFieldInfoPtr_BlendingMode_SrcFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "BlendingMode_SrcFactor");
			MaterialManager.NativeFieldInfoPtr_BlendingMode_DstFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "BlendingMode_DstFactor");
			MaterialManager.NativeFieldInfoPtr_BlendingMode_AlphaAsBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "BlendingMode_AlphaAsBlack");
			MaterialManager.NativeFieldInfoPtr_kStaticPropertiesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "kStaticPropertiesCount");
			MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "ms_MaterialsGroup");
			MaterialManager.NativeMethodInfoPtr_NewMaterial_Public_Static_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100673032);
			MaterialManager.NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_StaticProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, 100673033);
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x00002988 File Offset: 0x00000B88
		public MaterialManager(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x060079F4 RID: 31220 RVA: 0x001EAE14 File Offset: 0x001E9014
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr));
			}
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x060079F5 RID: 31221 RVA: 0x001EAE28 File Offset: 0x001E9028
		// (set) Token: 0x060079F6 RID: 31222 RVA: 0x001EAE53 File Offset: 0x001E9053
		public unsafe static MaterialPropertyBlock materialPropertyBlock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_materialPropertyBlock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new MaterialPropertyBlock(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_materialPropertyBlock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x060079F7 RID: 31223 RVA: 0x001EAE68 File Offset: 0x001E9068
		// (set) Token: 0x060079F8 RID: 31224 RVA: 0x001EAE93 File Offset: 0x001E9093
		public unsafe static Il2CppStructArray<BlendMode> BlendingMode_SrcFactor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_SrcFactor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<BlendMode>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_SrcFactor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x060079F9 RID: 31225 RVA: 0x001EAEA8 File Offset: 0x001E90A8
		// (set) Token: 0x060079FA RID: 31226 RVA: 0x001EAED3 File Offset: 0x001E90D3
		public unsafe static Il2CppStructArray<BlendMode> BlendingMode_DstFactor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_DstFactor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<BlendMode>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_DstFactor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x060079FB RID: 31227 RVA: 0x001EAEE8 File Offset: 0x001E90E8
		// (set) Token: 0x060079FC RID: 31228 RVA: 0x001EAF13 File Offset: 0x001E9113
		public unsafe static Il2CppStructArray<bool> BlendingMode_AlphaAsBlack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_AlphaAsBlack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<bool>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_BlendingMode_AlphaAsBlack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x060079FD RID: 31229 RVA: 0x001EAF28 File Offset: 0x001E9128
		// (set) Token: 0x060079FE RID: 31230 RVA: 0x001EAF46 File Offset: 0x001E9146
		public unsafe static int kStaticPropertiesCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_kStaticPropertiesCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_kStaticPropertiesCount, (void*)(&value));
			}
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x060079FF RID: 31231 RVA: 0x001EAF58 File Offset: 0x001E9158
		// (set) Token: 0x06007A00 RID: 31232 RVA: 0x001EAF83 File Offset: 0x001E9183
		public unsafe static Hashtable ms_MaterialsGroup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Hashtable(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialManager.NativeFieldInfoPtr_ms_MaterialsGroup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E16 RID: 19990
		private static readonly IntPtr NativeFieldInfoPtr_materialPropertyBlock;

		// Token: 0x04004E17 RID: 19991
		private static readonly IntPtr NativeFieldInfoPtr_BlendingMode_SrcFactor;

		// Token: 0x04004E18 RID: 19992
		private static readonly IntPtr NativeFieldInfoPtr_BlendingMode_DstFactor;

		// Token: 0x04004E19 RID: 19993
		private static readonly IntPtr NativeFieldInfoPtr_BlendingMode_AlphaAsBlack;

		// Token: 0x04004E1A RID: 19994
		private static readonly IntPtr NativeFieldInfoPtr_kStaticPropertiesCount;

		// Token: 0x04004E1B RID: 19995
		private static readonly IntPtr NativeFieldInfoPtr_ms_MaterialsGroup;

		// Token: 0x04004E1C RID: 19996
		private static readonly IntPtr NativeMethodInfoPtr_NewMaterial_Public_Static_Material_Boolean_0;

		// Token: 0x04004E1D RID: 19997
		private static readonly IntPtr NativeMethodInfoPtr_GetInstancedMaterial_Public_Static_Material_UInt32_StaticProperties_0;

		// Token: 0x020005DD RID: 1501
		public enum BlendingMode
		{
			// Token: 0x04004E1F RID: 19999
			Additive,
			// Token: 0x04004E20 RID: 20000
			SoftAdditive,
			// Token: 0x04004E21 RID: 20001
			TraditionalTransparency,
			// Token: 0x04004E22 RID: 20002
			Count
		}

		// Token: 0x020005DE RID: 1502
		public enum Noise3D
		{
			// Token: 0x04004E24 RID: 20004
			Off,
			// Token: 0x04004E25 RID: 20005
			On,
			// Token: 0x04004E26 RID: 20006
			Count
		}

		// Token: 0x020005DF RID: 1503
		public enum DepthBlend
		{
			// Token: 0x04004E28 RID: 20008
			Off,
			// Token: 0x04004E29 RID: 20009
			On,
			// Token: 0x04004E2A RID: 20010
			Count
		}

		// Token: 0x020005E0 RID: 1504
		public enum ColorGradient
		{
			// Token: 0x04004E2C RID: 20012
			Off,
			// Token: 0x04004E2D RID: 20013
			MatrixLow,
			// Token: 0x04004E2E RID: 20014
			MatrixHigh,
			// Token: 0x04004E2F RID: 20015
			Count
		}

		// Token: 0x020005E1 RID: 1505
		public enum DynamicOcclusion
		{
			// Token: 0x04004E31 RID: 20017
			Off,
			// Token: 0x04004E32 RID: 20018
			ClippingPlane,
			// Token: 0x04004E33 RID: 20019
			DepthTexture,
			// Token: 0x04004E34 RID: 20020
			Count
		}

		// Token: 0x020005E2 RID: 1506
		public class StaticProperties : Il2CppSystem.Object
		{
			// Token: 0x17002BB9 RID: 11193
			// (get) Token: 0x06007A0B RID: 31243 RVA: 0x001EB05C File Offset: 0x001E925C
			public unsafe int materialID
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticProperties.NativeMethodInfoPtr_get_materialID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
			}

			// Token: 0x06007A0C RID: 31244 RVA: 0x001EB0AC File Offset: 0x001E92AC
			[CallerCount(0)]
			public unsafe void ApplyToMaterial(Material mat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticProperties.NativeMethodInfoPtr_ApplyToMaterial_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007A0D RID: 31245 RVA: 0x001EB108 File Offset: 0x001E9308
			[CallerCount(0)]
			public unsafe StaticProperties() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialManager.StaticProperties>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.StaticProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007A0E RID: 31246 RVA: 0x001EB154 File Offset: 0x001E9354
			// Note: this type is marked as 'beforefieldinit'.
			static StaticProperties()
			{
				Il2CppClassPointerStore<MaterialManager.StaticProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "StaticProperties");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.StaticProperties>.NativeClassPtr);
				MaterialManager.StaticProperties.NativeFieldInfoPtr_blendingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticProperties>.NativeClassPtr, "blendingMode");
				MaterialManager.StaticProperties.NativeFieldInfoPtr_noise3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticProperties>.NativeClassPtr, "noise3D");
				MaterialManager.StaticProperties.NativeFieldInfoPtr_depthBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticProperties>.NativeClassPtr, "depthBlend");
				MaterialManager.StaticProperties.NativeFieldInfoPtr_colorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticProperties>.NativeClassPtr, "colorGradient");
				MaterialManager.StaticProperties.NativeFieldInfoPtr_dynamicOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.StaticProperties>.NativeClassPtr, "dynamicOcclusion");
				MaterialManager.StaticProperties.NativeMethodInfoPtr_get_materialID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticProperties>.NativeClassPtr, 100673035);
				MaterialManager.StaticProperties.NativeMethodInfoPtr_ApplyToMaterial_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticProperties>.NativeClassPtr, 100673036);
				MaterialManager.StaticProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.StaticProperties>.NativeClassPtr, 100673037);
			}

			// Token: 0x06007A0F RID: 31247 RVA: 0x00002988 File Offset: 0x00000B88
			public StaticProperties(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002BB3 RID: 11187
			// (get) Token: 0x06007A10 RID: 31248 RVA: 0x001EB21F File Offset: 0x001E941F
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MaterialManager.StaticProperties>.NativeClassPtr));
				}
			}

			// Token: 0x17002BB4 RID: 11188
			// (get) Token: 0x06007A11 RID: 31249 RVA: 0x001EB230 File Offset: 0x001E9430
			// (set) Token: 0x06007A12 RID: 31250 RVA: 0x001EB258 File Offset: 0x001E9458
			public unsafe MaterialManager.BlendingMode blendingMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.StaticProperties.NativeFieldInfoPtr_blendingMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.StaticProperties.NativeFieldInfoPtr_blendingMode)) = value;
				}
			}

			// Token: 0x17002BB5 RID: 11189
			// (get) Token: 0x06007A13 RID: 31251 RVA: 0x001EB27C File Offset: 0x001E947C
			// (set) Token: 0x06007A14 RID: 31252 RVA: 0x001EB2A4 File Offset: 0x001E94A4
			public unsafe MaterialManager.Noise3D noise3D
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.StaticProperties.NativeFieldInfoPtr_noise3D);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.StaticProperties.NativeFieldInfoPtr_noise3D)) = value;
				}
			}

			// Token: 0x17002BB6 RID: 11190
			// (get) Token: 0x06007A15 RID: 31253 RVA: 0x001EB2C8 File Offset: 0x001E94C8
			// (set) Token: 0x06007A16 RID: 31254 RVA: 0x001EB2F0 File Offset: 0x001E94F0
			public unsafe MaterialManager.DepthBlend depthBlend
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.StaticProperties.NativeFieldInfoPtr_depthBlend);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.StaticProperties.NativeFieldInfoPtr_depthBlend)) = value;
				}
			}

			// Token: 0x17002BB7 RID: 11191
			// (get) Token: 0x06007A17 RID: 31255 RVA: 0x001EB314 File Offset: 0x001E9514
			// (set) Token: 0x06007A18 RID: 31256 RVA: 0x001EB33C File Offset: 0x001E953C
			public unsafe MaterialManager.ColorGradient colorGradient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.StaticProperties.NativeFieldInfoPtr_colorGradient);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.StaticProperties.NativeFieldInfoPtr_colorGradient)) = value;
				}
			}

			// Token: 0x17002BB8 RID: 11192
			// (get) Token: 0x06007A19 RID: 31257 RVA: 0x001EB360 File Offset: 0x001E9560
			// (set) Token: 0x06007A1A RID: 31258 RVA: 0x001EB388 File Offset: 0x001E9588
			public unsafe MaterialManager.DynamicOcclusion dynamicOcclusion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.StaticProperties.NativeFieldInfoPtr_dynamicOcclusion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.StaticProperties.NativeFieldInfoPtr_dynamicOcclusion)) = value;
				}
			}

			// Token: 0x04004E35 RID: 20021
			private static readonly IntPtr NativeFieldInfoPtr_blendingMode;

			// Token: 0x04004E36 RID: 20022
			private static readonly IntPtr NativeFieldInfoPtr_noise3D;

			// Token: 0x04004E37 RID: 20023
			private static readonly IntPtr NativeFieldInfoPtr_depthBlend;

			// Token: 0x04004E38 RID: 20024
			private static readonly IntPtr NativeFieldInfoPtr_colorGradient;

			// Token: 0x04004E39 RID: 20025
			private static readonly IntPtr NativeFieldInfoPtr_dynamicOcclusion;

			// Token: 0x04004E3A RID: 20026
			private static readonly IntPtr NativeMethodInfoPtr_get_materialID_Public_get_Int32_0;

			// Token: 0x04004E3B RID: 20027
			private static readonly IntPtr NativeMethodInfoPtr_ApplyToMaterial_Public_Void_Material_0;

			// Token: 0x04004E3C RID: 20028
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020005E3 RID: 1507
		public class MaterialsGroup : Il2CppSystem.Object
		{
			// Token: 0x06007A1B RID: 31259 RVA: 0x001EB3AC File Offset: 0x001E95AC
			[CallerCount(0)]
			public unsafe MaterialsGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr))
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialManager.MaterialsGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007A1C RID: 31260 RVA: 0x001EB3F8 File Offset: 0x001E95F8
			// Note: this type is marked as 'beforefieldinit'.
			static MaterialsGroup()
			{
				Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialManager>.NativeClassPtr, "MaterialsGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr);
				MaterialManager.MaterialsGroup.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr, "materials");
				MaterialManager.MaterialsGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr, 100673038);
			}

			// Token: 0x06007A1D RID: 31261 RVA: 0x00002988 File Offset: 0x00000B88
			public MaterialsGroup(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002BBA RID: 11194
			// (get) Token: 0x06007A1E RID: 31262 RVA: 0x001EB44B File Offset: 0x001E964B
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MaterialManager.MaterialsGroup>.NativeClassPtr));
				}
			}

			// Token: 0x17002BBB RID: 11195
			// (get) Token: 0x06007A1F RID: 31263 RVA: 0x001EB45C File Offset: 0x001E965C
			// (set) Token: 0x06007A20 RID: 31264 RVA: 0x001EB490 File Offset: 0x001E9690
			public unsafe Il2CppReferenceArray<Material> materials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.MaterialsGroup.NativeFieldInfoPtr_materials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppReferenceArray<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialManager.MaterialsGroup.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004E3D RID: 20029
			private static readonly IntPtr NativeFieldInfoPtr_materials;

			// Token: 0x04004E3E RID: 20030
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
