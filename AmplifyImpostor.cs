using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace AmplifyImpostors
{
	// Token: 0x02001281 RID: 4737
	public class AmplifyImpostor : MonoBehaviour
	{
		// Token: 0x17007975 RID: 31093
		// (get) Token: 0x06015862 RID: 88162 RVA: 0x0056C164 File Offset: 0x0056A364
		// (set) Token: 0x06015863 RID: 88163 RVA: 0x0056C1BC File Offset: 0x0056A3BC
		public unsafe AmplifyImpostorAsset Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_get_Data_Public_get_AmplifyImpostorAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new AmplifyImpostorAsset(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_set_Data_Public_set_Void_AmplifyImpostorAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17007976 RID: 31094
		// (get) Token: 0x06015864 RID: 88164 RVA: 0x0056C218 File Offset: 0x0056A418
		// (set) Token: 0x06015865 RID: 88165 RVA: 0x0056C270 File Offset: 0x0056A470
		public unsafe Transform RootTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_get_RootTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_set_RootTransform_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17007977 RID: 31095
		// (get) Token: 0x06015866 RID: 88166 RVA: 0x0056C2CC File Offset: 0x0056A4CC
		// (set) Token: 0x06015867 RID: 88167 RVA: 0x0056C324 File Offset: 0x0056A524
		public unsafe LODGroup LodGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_get_LodGroup_Public_get_LODGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new LODGroup(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_set_LodGroup_Public_set_Void_LODGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17007978 RID: 31096
		// (get) Token: 0x06015868 RID: 88168 RVA: 0x0056C380 File Offset: 0x0056A580
		// (set) Token: 0x06015869 RID: 88169 RVA: 0x0056C3D8 File Offset: 0x0056A5D8
		public unsafe Il2CppReferenceArray<Renderer> Renderers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_get_Renderers_Public_get_ArrayOf_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<Renderer>(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_set_Renderers_Public_set_Void_ArrayOf_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0601586A RID: 88170 RVA: 0x0056C434 File Offset: 0x0056A634
		[CallerCount(0)]
		public unsafe void GenerateTextures(List<TextureOutput> outputList, bool standardRendering)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputList);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref standardRendering;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_GenerateTextures_Private_Void_List_1_TextureOutput_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601586B RID: 88171 RVA: 0x0056C4A0 File Offset: 0x0056A6A0
		[CallerCount(0)]
		public unsafe void GenerateAlphaTextures(List<TextureOutput> outputList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputList);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_GenerateAlphaTextures_Private_Void_List_1_TextureOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601586C RID: 88172 RVA: 0x0056C4FC File Offset: 0x0056A6FC
		[CallerCount(0)]
		public unsafe void ClearBuffers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_ClearBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601586D RID: 88173 RVA: 0x0056C540 File Offset: 0x0056A740
		[CallerCount(0)]
		public unsafe void ClearAlphaBuffers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_ClearAlphaBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601586E RID: 88174 RVA: 0x0056C584 File Offset: 0x0056A784
		[CallerCount(0)]
		public unsafe void RenderImpostor(ImpostorType impostorType, int targetAmount, bool impostorMaps = true, bool combinedAlphas = false, bool useMinResolution = false, [Optional] Shader customShader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref impostorType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetAmount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impostorMaps;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref combinedAlphas;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useMinResolution;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customShader);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_RenderImpostor_Public_Void_ImpostorType_Int32_Boolean_Boolean_Boolean_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601586F RID: 88175 RVA: 0x0056C63C File Offset: 0x0056A83C
		[CallerCount(0)]
		public unsafe Matrix4x4 GetCameraRotationMatrix(ImpostorType impostorType, int hframes, int vframes, int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref impostorType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hframes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vframes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_GetCameraRotationMatrix_Private_Matrix4x4_ImpostorType_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06015870 RID: 88176 RVA: 0x0056C6EC File Offset: 0x0056A8EC
		[CallerCount(0)]
		public unsafe Vector3 OctahedronToVector(Vector2 oct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oct;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_OctahedronToVector_Private_Vector3_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06015871 RID: 88177 RVA: 0x0056C750 File Offset: 0x0056A950
		[CallerCount(0)]
		public unsafe Vector3 OctahedronToVector(float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_OctahedronToVector_Private_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06015872 RID: 88178 RVA: 0x0056C7C8 File Offset: 0x0056A9C8
		[CallerCount(0)]
		public unsafe Vector3 HemiOctahedronToVector(float x, float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_HemiOctahedronToVector_Private_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06015873 RID: 88179 RVA: 0x0056C840 File Offset: 0x0056AA40
		[CallerCount(0)]
		public unsafe void GenerateAutomaticMesh(AmplifyImpostorAsset data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_GenerateAutomaticMesh_Public_Void_AmplifyImpostorAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015874 RID: 88180 RVA: 0x0056C89C File Offset: 0x0056AA9C
		[CallerCount(0)]
		public unsafe Mesh GenerateMesh(Il2CppStructArray<Vector2> points, Vector3 offset, [Optional] float width, [Optional] float height, bool invertY = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invertY;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr_GenerateMesh_Public_Mesh_ArrayOf_Vector2_Vector3_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
		}

		// Token: 0x06015875 RID: 88181 RVA: 0x0056C958 File Offset: 0x0056AB58
		[CallerCount(0)]
		public unsafe AmplifyImpostor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmplifyImpostor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06015876 RID: 88182 RVA: 0x0056C9A4 File Offset: 0x0056ABA4
		// Note: this type is marked as 'beforefieldinit'.
		static AmplifyImpostor()
		{
			Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyImpostors", "AmplifyImpostor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr);
			AmplifyImpostor.NativeFieldInfoPtr_ShaderGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "ShaderGUID");
			AmplifyImpostor.NativeFieldInfoPtr_DilateGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "DilateGUID");
			AmplifyImpostor.NativeFieldInfoPtr_DilateSingleMapGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "DilateSingleMapGUID");
			AmplifyImpostor.NativeFieldInfoPtr_PackerGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "PackerGUID");
			AmplifyImpostor.NativeFieldInfoPtr_ShaderOctaGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "ShaderOctaGUID");
			AmplifyImpostor.NativeFieldInfoPtr_StandardPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "StandardPreset");
			AmplifyImpostor.NativeFieldInfoPtr_SingleMapPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "SingleMapPreset");
			AmplifyImpostor.NativeFieldInfoPtr_LWPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "LWPreset");
			AmplifyImpostor.NativeFieldInfoPtr_LWShaderOctaGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "LWShaderOctaGUID");
			AmplifyImpostor.NativeFieldInfoPtr_LWShaderGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "LWShaderGUID");
			AmplifyImpostor.NativeFieldInfoPtr_HDPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "HDPreset");
			AmplifyImpostor.NativeFieldInfoPtr_HDShaderOctaGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "HDShaderOctaGUID");
			AmplifyImpostor.NativeFieldInfoPtr_HDShaderGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "HDShaderGUID");
			AmplifyImpostor.NativeFieldInfoPtr_UPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "UPreset");
			AmplifyImpostor.NativeFieldInfoPtr_UShaderOctaGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "UShaderOctaGUID");
			AmplifyImpostor.NativeFieldInfoPtr_UShaderGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "UShaderGUID");
			AmplifyImpostor.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_data");
			AmplifyImpostor.NativeFieldInfoPtr_m_rootTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_rootTransform");
			AmplifyImpostor.NativeFieldInfoPtr_m_lodGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_lodGroup");
			AmplifyImpostor.NativeFieldInfoPtr_m_renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_renderers");
			AmplifyImpostor.NativeFieldInfoPtr_m_lodReplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_lodReplacement");
			AmplifyImpostor.NativeFieldInfoPtr_m_renderPipelineInUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_renderPipelineInUse");
			AmplifyImpostor.NativeFieldInfoPtr_m_insertIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_insertIndex");
			AmplifyImpostor.NativeFieldInfoPtr_m_lastImpostor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_lastImpostor");
			AmplifyImpostor.NativeFieldInfoPtr_m_folderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_folderPath");
			AmplifyImpostor.NativeFieldInfoPtr_m_impostorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_impostorName");
			AmplifyImpostor.NativeFieldInfoPtr_m_cutMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_cutMode");
			AmplifyImpostor.NativeFieldInfoPtr_StartXRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "StartXRotation");
			AmplifyImpostor.NativeFieldInfoPtr_StartYRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "StartYRotation");
			AmplifyImpostor.NativeFieldInfoPtr_MinAlphaResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "MinAlphaResolution");
			AmplifyImpostor.NativeFieldInfoPtr_m_rtGBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_rtGBuffers");
			AmplifyImpostor.NativeFieldInfoPtr_m_alphaGBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_alphaGBuffers");
			AmplifyImpostor.NativeFieldInfoPtr_m_trueDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_trueDepth");
			AmplifyImpostor.NativeFieldInfoPtr_m_alphaTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_alphaTex");
			AmplifyImpostor.NativeFieldInfoPtr_m_xyFitSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_xyFitSize");
			AmplifyImpostor.NativeFieldInfoPtr_m_depthFitSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_depthFitSize");
			AmplifyImpostor.NativeFieldInfoPtr_m_pixelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_pixelOffset");
			AmplifyImpostor.NativeFieldInfoPtr_m_originalBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_originalBound");
			AmplifyImpostor.NativeFieldInfoPtr_m_oriPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_oriPos");
			AmplifyImpostor.NativeFieldInfoPtr_m_oriRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_oriRot");
			AmplifyImpostor.NativeFieldInfoPtr_m_oriSca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "m_oriSca");
			AmplifyImpostor.NativeFieldInfoPtr_BlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, "BlockSize");
			AmplifyImpostor.NativeMethodInfoPtr_get_Data_Public_get_AmplifyImpostorAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690957);
			AmplifyImpostor.NativeMethodInfoPtr_set_Data_Public_set_Void_AmplifyImpostorAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690958);
			AmplifyImpostor.NativeMethodInfoPtr_get_RootTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690959);
			AmplifyImpostor.NativeMethodInfoPtr_set_RootTransform_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690960);
			AmplifyImpostor.NativeMethodInfoPtr_get_LodGroup_Public_get_LODGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690961);
			AmplifyImpostor.NativeMethodInfoPtr_set_LodGroup_Public_set_Void_LODGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690962);
			AmplifyImpostor.NativeMethodInfoPtr_get_Renderers_Public_get_ArrayOf_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690963);
			AmplifyImpostor.NativeMethodInfoPtr_set_Renderers_Public_set_Void_ArrayOf_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690964);
			AmplifyImpostor.NativeMethodInfoPtr_GenerateTextures_Private_Void_List_1_TextureOutput_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690965);
			AmplifyImpostor.NativeMethodInfoPtr_GenerateAlphaTextures_Private_Void_List_1_TextureOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690966);
			AmplifyImpostor.NativeMethodInfoPtr_ClearBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690967);
			AmplifyImpostor.NativeMethodInfoPtr_ClearAlphaBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690968);
			AmplifyImpostor.NativeMethodInfoPtr_RenderImpostor_Public_Void_ImpostorType_Int32_Boolean_Boolean_Boolean_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690969);
			AmplifyImpostor.NativeMethodInfoPtr_GetCameraRotationMatrix_Private_Matrix4x4_ImpostorType_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690970);
			AmplifyImpostor.NativeMethodInfoPtr_OctahedronToVector_Private_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690971);
			AmplifyImpostor.NativeMethodInfoPtr_OctahedronToVector_Private_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690972);
			AmplifyImpostor.NativeMethodInfoPtr_HemiOctahedronToVector_Private_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690973);
			AmplifyImpostor.NativeMethodInfoPtr_GenerateAutomaticMesh_Public_Void_AmplifyImpostorAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690974);
			AmplifyImpostor.NativeMethodInfoPtr_GenerateMesh_Public_Mesh_ArrayOf_Vector2_Vector3_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690975);
			AmplifyImpostor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr, 100690976);
		}

		// Token: 0x06015877 RID: 88183 RVA: 0x0000210C File Offset: 0x0000030C
		public AmplifyImpostor(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x1700794A RID: 31050
		// (get) Token: 0x06015878 RID: 88184 RVA: 0x0056CEAC File Offset: 0x0056B0AC
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AmplifyImpostor>.NativeClassPtr));
			}
		}

		// Token: 0x1700794B RID: 31051
		// (get) Token: 0x06015879 RID: 88185 RVA: 0x0056CEC0 File Offset: 0x0056B0C0
		// (set) Token: 0x0601587A RID: 88186 RVA: 0x0056CEE0 File Offset: 0x0056B0E0
		public unsafe static string ShaderGUID
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_ShaderGUID, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_ShaderGUID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700794C RID: 31052
		// (get) Token: 0x0601587B RID: 88187 RVA: 0x0056CEF8 File Offset: 0x0056B0F8
		// (set) Token: 0x0601587C RID: 88188 RVA: 0x0056CF18 File Offset: 0x0056B118
		public unsafe static string DilateGUID
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_DilateGUID, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_DilateGUID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700794D RID: 31053
		// (get) Token: 0x0601587D RID: 88189 RVA: 0x0056CF30 File Offset: 0x0056B130
		// (set) Token: 0x0601587E RID: 88190 RVA: 0x0056CF50 File Offset: 0x0056B150
		public unsafe static string DilateSingleMapGUID
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_DilateSingleMapGUID, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_DilateSingleMapGUID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700794E RID: 31054
		// (get) Token: 0x0601587F RID: 88191 RVA: 0x0056CF68 File Offset: 0x0056B168
		// (set) Token: 0x06015880 RID: 88192 RVA: 0x0056CF88 File Offset: 0x0056B188
		public unsafe static string PackerGUID
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_PackerGUID, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_PackerGUID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700794F RID: 31055
		// (get) Token: 0x06015881 RID: 88193 RVA: 0x0056CFA0 File Offset: 0x0056B1A0
		// (set) Token: 0x06015882 RID: 88194 RVA: 0x0056CFC0 File Offset: 0x0056B1C0
		public unsafe static string ShaderOctaGUID
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_ShaderOctaGUID, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_ShaderOctaGUID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007950 RID: 31056
		// (get) Token: 0x06015883 RID: 88195 RVA: 0x0056CFD8 File Offset: 0x0056B1D8
		// (set) Token: 0x06015884 RID: 88196 RVA: 0x0056CFF8 File Offset: 0x0056B1F8
		public unsafe static string StandardPreset
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_StandardPreset, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_StandardPreset, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007951 RID: 31057
		// (get) Token: 0x06015885 RID: 88197 RVA: 0x0056D010 File Offset: 0x0056B210
		// (set) Token: 0x06015886 RID: 88198 RVA: 0x0056D030 File Offset: 0x0056B230
		public unsafe static string SingleMapPreset
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_SingleMapPreset, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_SingleMapPreset, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007952 RID: 31058
		// (get) Token: 0x06015887 RID: 88199 RVA: 0x0056D048 File Offset: 0x0056B248
		// (set) Token: 0x06015888 RID: 88200 RVA: 0x0056D068 File Offset: 0x0056B268
		public unsafe static string LWPreset
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_LWPreset, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_LWPreset, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007953 RID: 31059
		// (get) Token: 0x06015889 RID: 88201 RVA: 0x0056D080 File Offset: 0x0056B280
		// (set) Token: 0x0601588A RID: 88202 RVA: 0x0056D0A0 File Offset: 0x0056B2A0
		public unsafe static string LWShaderOctaGUID
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_LWShaderOctaGUID, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_LWShaderOctaGUID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007954 RID: 31060
		// (get) Token: 0x0601588B RID: 88203 RVA: 0x0056D0B8 File Offset: 0x0056B2B8
		// (set) Token: 0x0601588C RID: 88204 RVA: 0x0056D0D8 File Offset: 0x0056B2D8
		public unsafe static string LWShaderGUID
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_LWShaderGUID, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_LWShaderGUID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007955 RID: 31061
		// (get) Token: 0x0601588D RID: 88205 RVA: 0x0056D0F0 File Offset: 0x0056B2F0
		// (set) Token: 0x0601588E RID: 88206 RVA: 0x0056D110 File Offset: 0x0056B310
		public unsafe static string HDPreset
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_HDPreset, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_HDPreset, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007956 RID: 31062
		// (get) Token: 0x0601588F RID: 88207 RVA: 0x0056D128 File Offset: 0x0056B328
		// (set) Token: 0x06015890 RID: 88208 RVA: 0x0056D148 File Offset: 0x0056B348
		public unsafe static string HDShaderOctaGUID
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_HDShaderOctaGUID, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_HDShaderOctaGUID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007957 RID: 31063
		// (get) Token: 0x06015891 RID: 88209 RVA: 0x0056D160 File Offset: 0x0056B360
		// (set) Token: 0x06015892 RID: 88210 RVA: 0x0056D180 File Offset: 0x0056B380
		public unsafe static string HDShaderGUID
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_HDShaderGUID, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_HDShaderGUID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007958 RID: 31064
		// (get) Token: 0x06015893 RID: 88211 RVA: 0x0056D198 File Offset: 0x0056B398
		// (set) Token: 0x06015894 RID: 88212 RVA: 0x0056D1B8 File Offset: 0x0056B3B8
		public unsafe static string UPreset
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_UPreset, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_UPreset, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007959 RID: 31065
		// (get) Token: 0x06015895 RID: 88213 RVA: 0x0056D1D0 File Offset: 0x0056B3D0
		// (set) Token: 0x06015896 RID: 88214 RVA: 0x0056D1F0 File Offset: 0x0056B3F0
		public unsafe static string UShaderOctaGUID
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_UShaderOctaGUID, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_UShaderOctaGUID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700795A RID: 31066
		// (get) Token: 0x06015897 RID: 88215 RVA: 0x0056D208 File Offset: 0x0056B408
		// (set) Token: 0x06015898 RID: 88216 RVA: 0x0056D228 File Offset: 0x0056B428
		public unsafe static string UShaderGUID
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_UShaderGUID, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_UShaderGUID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700795B RID: 31067
		// (get) Token: 0x06015899 RID: 88217 RVA: 0x0056D240 File Offset: 0x0056B440
		// (set) Token: 0x0601589A RID: 88218 RVA: 0x0056D274 File Offset: 0x0056B474
		public unsafe AmplifyImpostorAsset m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new AmplifyImpostorAsset(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700795C RID: 31068
		// (get) Token: 0x0601589B RID: 88219 RVA: 0x0056D29C File Offset: 0x0056B49C
		// (set) Token: 0x0601589C RID: 88220 RVA: 0x0056D2D0 File Offset: 0x0056B4D0
		public unsafe Transform m_rootTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_rootTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Transform(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_rootTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700795D RID: 31069
		// (get) Token: 0x0601589D RID: 88221 RVA: 0x0056D2F8 File Offset: 0x0056B4F8
		// (set) Token: 0x0601589E RID: 88222 RVA: 0x0056D32C File Offset: 0x0056B52C
		public unsafe LODGroup m_lodGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_lodGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new LODGroup(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_lodGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700795E RID: 31070
		// (get) Token: 0x0601589F RID: 88223 RVA: 0x0056D354 File Offset: 0x0056B554
		// (set) Token: 0x060158A0 RID: 88224 RVA: 0x0056D388 File Offset: 0x0056B588
		public unsafe Il2CppReferenceArray<Renderer> m_renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700795F RID: 31071
		// (get) Token: 0x060158A1 RID: 88225 RVA: 0x0056D3B0 File Offset: 0x0056B5B0
		// (set) Token: 0x060158A2 RID: 88226 RVA: 0x0056D3D8 File Offset: 0x0056B5D8
		public unsafe LODReplacement m_lodReplacement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_lodReplacement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_lodReplacement)) = value;
			}
		}

		// Token: 0x17007960 RID: 31072
		// (get) Token: 0x060158A3 RID: 88227 RVA: 0x0056D3FC File Offset: 0x0056B5FC
		// (set) Token: 0x060158A4 RID: 88228 RVA: 0x0056D424 File Offset: 0x0056B624
		public unsafe RenderPipelineInUse m_renderPipelineInUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_renderPipelineInUse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_renderPipelineInUse)) = value;
			}
		}

		// Token: 0x17007961 RID: 31073
		// (get) Token: 0x060158A5 RID: 88229 RVA: 0x0056D448 File Offset: 0x0056B648
		// (set) Token: 0x060158A6 RID: 88230 RVA: 0x0056D470 File Offset: 0x0056B670
		public unsafe int m_insertIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_insertIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_insertIndex)) = value;
			}
		}

		// Token: 0x17007962 RID: 31074
		// (get) Token: 0x060158A7 RID: 88231 RVA: 0x0056D494 File Offset: 0x0056B694
		// (set) Token: 0x060158A8 RID: 88232 RVA: 0x0056D4C8 File Offset: 0x0056B6C8
		public unsafe GameObject m_lastImpostor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_lastImpostor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_lastImpostor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17007963 RID: 31075
		// (get) Token: 0x060158A9 RID: 88233 RVA: 0x0056D4F0 File Offset: 0x0056B6F0
		// (set) Token: 0x060158AA RID: 88234 RVA: 0x0056D519 File Offset: 0x0056B719
		public unsafe string m_folderPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_folderPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_folderPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007964 RID: 31076
		// (get) Token: 0x060158AB RID: 88235 RVA: 0x0056D540 File Offset: 0x0056B740
		// (set) Token: 0x060158AC RID: 88236 RVA: 0x0056D569 File Offset: 0x0056B769
		public unsafe string m_impostorName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_impostorName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_impostorName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17007965 RID: 31077
		// (get) Token: 0x060158AD RID: 88237 RVA: 0x0056D590 File Offset: 0x0056B790
		// (set) Token: 0x060158AE RID: 88238 RVA: 0x0056D5B8 File Offset: 0x0056B7B8
		public unsafe CutMode m_cutMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_cutMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_cutMode)) = value;
			}
		}

		// Token: 0x17007966 RID: 31078
		// (get) Token: 0x060158AF RID: 88239 RVA: 0x0056D5DC File Offset: 0x0056B7DC
		// (set) Token: 0x060158B0 RID: 88240 RVA: 0x0056D5FA File Offset: 0x0056B7FA
		public unsafe static float StartXRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_StartXRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_StartXRotation, (void*)(&value));
			}
		}

		// Token: 0x17007967 RID: 31079
		// (get) Token: 0x060158B1 RID: 88241 RVA: 0x0056D60C File Offset: 0x0056B80C
		// (set) Token: 0x060158B2 RID: 88242 RVA: 0x0056D62A File Offset: 0x0056B82A
		public unsafe static float StartYRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_StartYRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_StartYRotation, (void*)(&value));
			}
		}

		// Token: 0x17007968 RID: 31080
		// (get) Token: 0x060158B3 RID: 88243 RVA: 0x0056D63C File Offset: 0x0056B83C
		// (set) Token: 0x060158B4 RID: 88244 RVA: 0x0056D65A File Offset: 0x0056B85A
		public unsafe static int MinAlphaResolution
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_MinAlphaResolution, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_MinAlphaResolution, (void*)(&value));
			}
		}

		// Token: 0x17007969 RID: 31081
		// (get) Token: 0x060158B5 RID: 88245 RVA: 0x0056D66C File Offset: 0x0056B86C
		// (set) Token: 0x060158B6 RID: 88246 RVA: 0x0056D6A0 File Offset: 0x0056B8A0
		public unsafe Il2CppReferenceArray<RenderTexture> m_rtGBuffers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_rtGBuffers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_rtGBuffers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700796A RID: 31082
		// (get) Token: 0x060158B7 RID: 88247 RVA: 0x0056D6C8 File Offset: 0x0056B8C8
		// (set) Token: 0x060158B8 RID: 88248 RVA: 0x0056D6FC File Offset: 0x0056B8FC
		public unsafe Il2CppReferenceArray<RenderTexture> m_alphaGBuffers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_alphaGBuffers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Il2CppReferenceArray<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_alphaGBuffers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700796B RID: 31083
		// (get) Token: 0x060158B9 RID: 88249 RVA: 0x0056D724 File Offset: 0x0056B924
		// (set) Token: 0x060158BA RID: 88250 RVA: 0x0056D758 File Offset: 0x0056B958
		public unsafe RenderTexture m_trueDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_trueDepth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new RenderTexture(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_trueDepth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700796C RID: 31084
		// (get) Token: 0x060158BB RID: 88251 RVA: 0x0056D780 File Offset: 0x0056B980
		// (set) Token: 0x060158BC RID: 88252 RVA: 0x0056D7B4 File Offset: 0x0056B9B4
		public unsafe Texture2D m_alphaTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_alphaTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Texture2D(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_alphaTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700796D RID: 31085
		// (get) Token: 0x060158BD RID: 88253 RVA: 0x0056D7DC File Offset: 0x0056B9DC
		// (set) Token: 0x060158BE RID: 88254 RVA: 0x0056D804 File Offset: 0x0056BA04
		public unsafe float m_xyFitSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_xyFitSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_xyFitSize)) = value;
			}
		}

		// Token: 0x1700796E RID: 31086
		// (get) Token: 0x060158BF RID: 88255 RVA: 0x0056D828 File Offset: 0x0056BA28
		// (set) Token: 0x060158C0 RID: 88256 RVA: 0x0056D850 File Offset: 0x0056BA50
		public unsafe float m_depthFitSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_depthFitSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_depthFitSize)) = value;
			}
		}

		// Token: 0x1700796F RID: 31087
		// (get) Token: 0x060158C1 RID: 88257 RVA: 0x0056D874 File Offset: 0x0056BA74
		// (set) Token: 0x060158C2 RID: 88258 RVA: 0x0056D89C File Offset: 0x0056BA9C
		public unsafe Vector2 m_pixelOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_pixelOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_pixelOffset)) = value;
			}
		}

		// Token: 0x17007970 RID: 31088
		// (get) Token: 0x060158C3 RID: 88259 RVA: 0x0056D8C0 File Offset: 0x0056BAC0
		// (set) Token: 0x060158C4 RID: 88260 RVA: 0x0056D8E8 File Offset: 0x0056BAE8
		public unsafe Bounds m_originalBound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_originalBound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_originalBound)) = value;
			}
		}

		// Token: 0x17007971 RID: 31089
		// (get) Token: 0x060158C5 RID: 88261 RVA: 0x0056D90C File Offset: 0x0056BB0C
		// (set) Token: 0x060158C6 RID: 88262 RVA: 0x0056D934 File Offset: 0x0056BB34
		public unsafe Vector3 m_oriPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_oriPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_oriPos)) = value;
			}
		}

		// Token: 0x17007972 RID: 31090
		// (get) Token: 0x060158C7 RID: 88263 RVA: 0x0056D958 File Offset: 0x0056BB58
		// (set) Token: 0x060158C8 RID: 88264 RVA: 0x0056D980 File Offset: 0x0056BB80
		public unsafe Quaternion m_oriRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_oriRot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_oriRot)) = value;
			}
		}

		// Token: 0x17007973 RID: 31091
		// (get) Token: 0x060158C9 RID: 88265 RVA: 0x0056D9A4 File Offset: 0x0056BBA4
		// (set) Token: 0x060158CA RID: 88266 RVA: 0x0056D9CC File Offset: 0x0056BBCC
		public unsafe Vector3 m_oriSca
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_oriSca);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmplifyImpostor.NativeFieldInfoPtr_m_oriSca)) = value;
			}
		}

		// Token: 0x17007974 RID: 31092
		// (get) Token: 0x060158CB RID: 88267 RVA: 0x0056D9F0 File Offset: 0x0056BBF0
		// (set) Token: 0x060158CC RID: 88268 RVA: 0x0056DA0E File Offset: 0x0056BC0E
		public unsafe static int BlockSize
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(AmplifyImpostor.NativeFieldInfoPtr_BlockSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmplifyImpostor.NativeFieldInfoPtr_BlockSize, (void*)(&value));
			}
		}

		// Token: 0x0400DCDB RID: 56539
		private static readonly IntPtr NativeFieldInfoPtr_ShaderGUID;

		// Token: 0x0400DCDC RID: 56540
		private static readonly IntPtr NativeFieldInfoPtr_DilateGUID;

		// Token: 0x0400DCDD RID: 56541
		private static readonly IntPtr NativeFieldInfoPtr_DilateSingleMapGUID;

		// Token: 0x0400DCDE RID: 56542
		private static readonly IntPtr NativeFieldInfoPtr_PackerGUID;

		// Token: 0x0400DCDF RID: 56543
		private static readonly IntPtr NativeFieldInfoPtr_ShaderOctaGUID;

		// Token: 0x0400DCE0 RID: 56544
		private static readonly IntPtr NativeFieldInfoPtr_StandardPreset;

		// Token: 0x0400DCE1 RID: 56545
		private static readonly IntPtr NativeFieldInfoPtr_SingleMapPreset;

		// Token: 0x0400DCE2 RID: 56546
		private static readonly IntPtr NativeFieldInfoPtr_LWPreset;

		// Token: 0x0400DCE3 RID: 56547
		private static readonly IntPtr NativeFieldInfoPtr_LWShaderOctaGUID;

		// Token: 0x0400DCE4 RID: 56548
		private static readonly IntPtr NativeFieldInfoPtr_LWShaderGUID;

		// Token: 0x0400DCE5 RID: 56549
		private static readonly IntPtr NativeFieldInfoPtr_HDPreset;

		// Token: 0x0400DCE6 RID: 56550
		private static readonly IntPtr NativeFieldInfoPtr_HDShaderOctaGUID;

		// Token: 0x0400DCE7 RID: 56551
		private static readonly IntPtr NativeFieldInfoPtr_HDShaderGUID;

		// Token: 0x0400DCE8 RID: 56552
		private static readonly IntPtr NativeFieldInfoPtr_UPreset;

		// Token: 0x0400DCE9 RID: 56553
		private static readonly IntPtr NativeFieldInfoPtr_UShaderOctaGUID;

		// Token: 0x0400DCEA RID: 56554
		private static readonly IntPtr NativeFieldInfoPtr_UShaderGUID;

		// Token: 0x0400DCEB RID: 56555
		private static readonly IntPtr NativeFieldInfoPtr_m_data;

		// Token: 0x0400DCEC RID: 56556
		private static readonly IntPtr NativeFieldInfoPtr_m_rootTransform;

		// Token: 0x0400DCED RID: 56557
		private static readonly IntPtr NativeFieldInfoPtr_m_lodGroup;

		// Token: 0x0400DCEE RID: 56558
		private static readonly IntPtr NativeFieldInfoPtr_m_renderers;

		// Token: 0x0400DCEF RID: 56559
		private static readonly IntPtr NativeFieldInfoPtr_m_lodReplacement;

		// Token: 0x0400DCF0 RID: 56560
		private static readonly IntPtr NativeFieldInfoPtr_m_renderPipelineInUse;

		// Token: 0x0400DCF1 RID: 56561
		private static readonly IntPtr NativeFieldInfoPtr_m_insertIndex;

		// Token: 0x0400DCF2 RID: 56562
		private static readonly IntPtr NativeFieldInfoPtr_m_lastImpostor;

		// Token: 0x0400DCF3 RID: 56563
		private static readonly IntPtr NativeFieldInfoPtr_m_folderPath;

		// Token: 0x0400DCF4 RID: 56564
		private static readonly IntPtr NativeFieldInfoPtr_m_impostorName;

		// Token: 0x0400DCF5 RID: 56565
		private static readonly IntPtr NativeFieldInfoPtr_m_cutMode;

		// Token: 0x0400DCF6 RID: 56566
		private static readonly IntPtr NativeFieldInfoPtr_StartXRotation;

		// Token: 0x0400DCF7 RID: 56567
		private static readonly IntPtr NativeFieldInfoPtr_StartYRotation;

		// Token: 0x0400DCF8 RID: 56568
		private static readonly IntPtr NativeFieldInfoPtr_MinAlphaResolution;

		// Token: 0x0400DCF9 RID: 56569
		private static readonly IntPtr NativeFieldInfoPtr_m_rtGBuffers;

		// Token: 0x0400DCFA RID: 56570
		private static readonly IntPtr NativeFieldInfoPtr_m_alphaGBuffers;

		// Token: 0x0400DCFB RID: 56571
		private static readonly IntPtr NativeFieldInfoPtr_m_trueDepth;

		// Token: 0x0400DCFC RID: 56572
		private static readonly IntPtr NativeFieldInfoPtr_m_alphaTex;

		// Token: 0x0400DCFD RID: 56573
		private static readonly IntPtr NativeFieldInfoPtr_m_xyFitSize;

		// Token: 0x0400DCFE RID: 56574
		private static readonly IntPtr NativeFieldInfoPtr_m_depthFitSize;

		// Token: 0x0400DCFF RID: 56575
		private static readonly IntPtr NativeFieldInfoPtr_m_pixelOffset;

		// Token: 0x0400DD00 RID: 56576
		private static readonly IntPtr NativeFieldInfoPtr_m_originalBound;

		// Token: 0x0400DD01 RID: 56577
		private static readonly IntPtr NativeFieldInfoPtr_m_oriPos;

		// Token: 0x0400DD02 RID: 56578
		private static readonly IntPtr NativeFieldInfoPtr_m_oriRot;

		// Token: 0x0400DD03 RID: 56579
		private static readonly IntPtr NativeFieldInfoPtr_m_oriSca;

		// Token: 0x0400DD04 RID: 56580
		private static readonly IntPtr NativeFieldInfoPtr_BlockSize;

		// Token: 0x0400DD05 RID: 56581
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_AmplifyImpostorAsset_0;

		// Token: 0x0400DD06 RID: 56582
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_AmplifyImpostorAsset_0;

		// Token: 0x0400DD07 RID: 56583
		private static readonly IntPtr NativeMethodInfoPtr_get_RootTransform_Public_get_Transform_0;

		// Token: 0x0400DD08 RID: 56584
		private static readonly IntPtr NativeMethodInfoPtr_set_RootTransform_Public_set_Void_Transform_0;

		// Token: 0x0400DD09 RID: 56585
		private static readonly IntPtr NativeMethodInfoPtr_get_LodGroup_Public_get_LODGroup_0;

		// Token: 0x0400DD0A RID: 56586
		private static readonly IntPtr NativeMethodInfoPtr_set_LodGroup_Public_set_Void_LODGroup_0;

		// Token: 0x0400DD0B RID: 56587
		private static readonly IntPtr NativeMethodInfoPtr_get_Renderers_Public_get_ArrayOf_Renderer_0;

		// Token: 0x0400DD0C RID: 56588
		private static readonly IntPtr NativeMethodInfoPtr_set_Renderers_Public_set_Void_ArrayOf_Renderer_0;

		// Token: 0x0400DD0D RID: 56589
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTextures_Private_Void_List_1_TextureOutput_Boolean_0;

		// Token: 0x0400DD0E RID: 56590
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAlphaTextures_Private_Void_List_1_TextureOutput_0;

		// Token: 0x0400DD0F RID: 56591
		private static readonly IntPtr NativeMethodInfoPtr_ClearBuffers_Private_Void_0;

		// Token: 0x0400DD10 RID: 56592
		private static readonly IntPtr NativeMethodInfoPtr_ClearAlphaBuffers_Private_Void_0;

		// Token: 0x0400DD11 RID: 56593
		private static readonly IntPtr NativeMethodInfoPtr_RenderImpostor_Public_Void_ImpostorType_Int32_Boolean_Boolean_Boolean_Shader_0;

		// Token: 0x0400DD12 RID: 56594
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraRotationMatrix_Private_Matrix4x4_ImpostorType_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400DD13 RID: 56595
		private static readonly IntPtr NativeMethodInfoPtr_OctahedronToVector_Private_Vector3_Vector2_0;

		// Token: 0x0400DD14 RID: 56596
		private static readonly IntPtr NativeMethodInfoPtr_OctahedronToVector_Private_Vector3_Single_Single_0;

		// Token: 0x0400DD15 RID: 56597
		private static readonly IntPtr NativeMethodInfoPtr_HemiOctahedronToVector_Private_Vector3_Single_Single_0;

		// Token: 0x0400DD16 RID: 56598
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAutomaticMesh_Public_Void_AmplifyImpostorAsset_0;

		// Token: 0x0400DD17 RID: 56599
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMesh_Public_Mesh_ArrayOf_Vector2_Vector3_Single_Single_Boolean_0;

		// Token: 0x0400DD18 RID: 56600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
