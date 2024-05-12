using System;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	// Token: 0x020005C2 RID: 1474
	public class BeamGeometry : MonoBehaviour
	{
		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x060077FD RID: 30717 RVA: 0x001E3C48 File Offset: 0x001E1E48
		// (set) Token: 0x060077FE RID: 30718 RVA: 0x001E3CA0 File Offset: 0x001E1EA0
		public unsafe MeshRenderer meshRenderer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_get_meshRenderer_Public_get_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new MeshRenderer(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_set_meshRenderer_Private_set_Void_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x060077FF RID: 30719 RVA: 0x001E3CFC File Offset: 0x001E1EFC
		// (set) Token: 0x06007800 RID: 30720 RVA: 0x001E3D54 File Offset: 0x001E1F54
		public unsafe MeshFilter meshFilter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new MeshFilter(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_set_meshFilter_Private_set_Void_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002AEC RID: 10988
		// (get) Token: 0x06007801 RID: 30721 RVA: 0x001E3DB0 File Offset: 0x001E1FB0
		// (set) Token: 0x06007802 RID: 30722 RVA: 0x001E3E08 File Offset: 0x001E2008
		public unsafe Mesh coneMesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_get_coneMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_set_coneMesh_Private_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x06007803 RID: 30723 RVA: 0x001E3E64 File Offset: 0x001E2064
		// (set) Token: 0x06007804 RID: 30724 RVA: 0x001E3EB4 File Offset: 0x001E20B4
		public unsafe bool visible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_get_visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x06007805 RID: 30725 RVA: 0x001E3F08 File Offset: 0x001E2108
		// (set) Token: 0x06007806 RID: 30726 RVA: 0x001E3F58 File Offset: 0x001E2158
		public unsafe int sortingLayerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x06007807 RID: 30727 RVA: 0x001E3FAC File Offset: 0x001E21AC
		// (set) Token: 0x06007808 RID: 30728 RVA: 0x001E3FFC File Offset: 0x001E21FC
		public unsafe int sortingOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x06007809 RID: 30729 RVA: 0x001E4050 File Offset: 0x001E2250
		public unsafe bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_get__INTERNAL_IsFadeOutCoroutineRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x001E40A0 File Offset: 0x001E22A0
		[CallerCount(0)]
		public unsafe float ComputeFadeOutFactor(Transform camTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camTransform);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Single_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x001E4108 File Offset: 0x001E2308
		[CallerCount(0)]
		public unsafe IEnumerator CoUpdateFadeOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_CoUpdateFadeOut_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x001E4160 File Offset: 0x001E2360
		[CallerCount(0)]
		public unsafe void ComputeFadeOutFactor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x001E41A4 File Offset: 0x001E23A4
		[CallerCount(0)]
		public unsafe void SetFadeOutFactorProp(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_SetFadeOutFactorProp_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600780E RID: 30734 RVA: 0x001E41F8 File Offset: 0x001E23F8
		[CallerCount(0)]
		public unsafe void RestartFadeOutCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_RestartFadeOutCoroutine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600780F RID: 30735 RVA: 0x001E423C File Offset: 0x001E243C
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007810 RID: 30736 RVA: 0x001E4280 File Offset: 0x001E2480
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x001E42C4 File Offset: 0x001E24C4
		[CallerCount(0)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x06007812 RID: 30738 RVA: 0x001E4308 File Offset: 0x001E2508
		public unsafe static bool isCustomRenderPipelineSupported
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x06007813 RID: 30739 RVA: 0x001E434C File Offset: 0x001E254C
		public unsafe bool shouldUseGPUInstancedMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06007814 RID: 30740 RVA: 0x001E439C File Offset: 0x001E259C
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007815 RID: 30741 RVA: 0x001E43E0 File Offset: 0x001E25E0
		[CallerCount(0)]
		public unsafe void Initialize(VolumetricLightBeam master)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(master);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x001E443C File Offset: 0x001E263C
		[CallerCount(0)]
		public unsafe void RegenerateMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_RegenerateMesh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x001E4480 File Offset: 0x001E2680
		[CallerCount(0)]
		public unsafe void ComputeLocalMatrix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_ComputeLocalMatrix_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x06007818 RID: 30744 RVA: 0x001E44C4 File Offset: 0x001E26C4
		public unsafe bool isNoiseEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x06007819 RID: 30745 RVA: 0x001E4514 File Offset: 0x001E2714
		public unsafe bool isDepthBlendEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_get_isDepthBlendEnabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x001E4564 File Offset: 0x001E2764
		[CallerCount(0)]
		public unsafe bool ApplyMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x001E45B4 File Offset: 0x001E27B4
		[CallerCount(0)]
		public unsafe void SetMaterialProp(int nameID, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600781C RID: 30748 RVA: 0x001E461C File Offset: 0x001E281C
		[CallerCount(0)]
		public unsafe void SetMaterialProp(int nameID, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600781D RID: 30749 RVA: 0x001E4684 File Offset: 0x001E2884
		[CallerCount(0)]
		public unsafe void SetMaterialProp(int nameID, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x001E46EC File Offset: 0x001E28EC
		[CallerCount(0)]
		public unsafe void SetMaterialProp(int nameID, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x001E4754 File Offset: 0x001E2954
		[CallerCount(0)]
		public unsafe void SetMaterialProp(int nameID, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007820 RID: 30752 RVA: 0x001E47C0 File Offset: 0x001E29C0
		[CallerCount(0)]
		public unsafe void MaterialChangeStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007821 RID: 30753 RVA: 0x001E4804 File Offset: 0x001E2A04
		[CallerCount(0)]
		public unsafe void MaterialChangeStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007822 RID: 30754 RVA: 0x001E4848 File Offset: 0x001E2A48
		[CallerCount(0)]
		public unsafe void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shaderKeyword);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_SetDynamicOcclusionCallback_Public_Void_String_Callback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x001E48BC File Offset: 0x001E2ABC
		[CallerCount(0)]
		public unsafe void UpdateMaterialAndBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_UpdateMaterialAndBounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x001E4900 File Offset: 0x001E2B00
		[CallerCount(0)]
		public unsafe void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x001E4944 File Offset: 0x001E2B44
		[CallerCount(0)]
		public unsafe void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x001E49B0 File Offset: 0x001E2BB0
		[CallerCount(0)]
		public unsafe void OnWillRenderObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x001E49F4 File Offset: 0x001E2BF4
		[CallerCount(0)]
		public unsafe void OnWillCameraRenderThisBeam(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x001E4A50 File Offset: 0x001E2C50
		[CallerCount(0)]
		public unsafe void UpdateCameraRelatedProperties(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr_UpdateCameraRelatedProperties_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x001E4AAC File Offset: 0x001E2CAC
		[CallerCount(0)]
		public unsafe BeamGeometry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x001E4AF8 File Offset: 0x001E2CF8
		// Note: this type is marked as 'beforefieldinit'.
		static BeamGeometry()
		{
			Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "BeamGeometry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr);
			BeamGeometry.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, "m_Master");
			BeamGeometry.NativeFieldInfoPtr_m_ColorGradientMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, "m_ColorGradientMatrix");
			BeamGeometry.NativeFieldInfoPtr_m_CurrentMeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, "m_CurrentMeshType");
			BeamGeometry.NativeFieldInfoPtr_m_CustomMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, "m_CustomMaterial");
			BeamGeometry.NativeFieldInfoPtr_m_MaterialModifierCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, "m_MaterialModifierCallback");
			BeamGeometry.NativeFieldInfoPtr_m_CoFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, "m_CoFadeOut");
			BeamGeometry.NativeFieldInfoPtr__meshRenderer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, "<meshRenderer>k__BackingField");
			BeamGeometry.NativeFieldInfoPtr__meshFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, "<meshFilter>k__BackingField");
			BeamGeometry.NativeFieldInfoPtr__coneMesh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, "<coneMesh>k__BackingField");
			BeamGeometry.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, "m_CurrentCameraRenderingSRP");
			BeamGeometry.NativeMethodInfoPtr_get_meshRenderer_Public_get_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672884);
			BeamGeometry.NativeMethodInfoPtr_set_meshRenderer_Private_set_Void_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672885);
			BeamGeometry.NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672886);
			BeamGeometry.NativeMethodInfoPtr_set_meshFilter_Private_set_Void_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672887);
			BeamGeometry.NativeMethodInfoPtr_get_coneMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672888);
			BeamGeometry.NativeMethodInfoPtr_set_coneMesh_Private_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672889);
			BeamGeometry.NativeMethodInfoPtr_get_visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672890);
			BeamGeometry.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672891);
			BeamGeometry.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672892);
			BeamGeometry.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672893);
			BeamGeometry.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672894);
			BeamGeometry.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672895);
			BeamGeometry.NativeMethodInfoPtr_get__INTERNAL_IsFadeOutCoroutineRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672896);
			BeamGeometry.NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672897);
			BeamGeometry.NativeMethodInfoPtr_CoUpdateFadeOut_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672898);
			BeamGeometry.NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672899);
			BeamGeometry.NativeMethodInfoPtr_SetFadeOutFactorProp_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672900);
			BeamGeometry.NativeMethodInfoPtr_RestartFadeOutCoroutine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672901);
			BeamGeometry.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672902);
			BeamGeometry.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672903);
			BeamGeometry.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672904);
			BeamGeometry.NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672905);
			BeamGeometry.NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672906);
			BeamGeometry.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672907);
			BeamGeometry.NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672908);
			BeamGeometry.NativeMethodInfoPtr_RegenerateMesh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672909);
			BeamGeometry.NativeMethodInfoPtr_ComputeLocalMatrix_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672910);
			BeamGeometry.NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672911);
			BeamGeometry.NativeMethodInfoPtr_get_isDepthBlendEnabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672912);
			BeamGeometry.NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672913);
			BeamGeometry.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672914);
			BeamGeometry.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672915);
			BeamGeometry.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672916);
			BeamGeometry.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672917);
			BeamGeometry.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672918);
			BeamGeometry.NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672919);
			BeamGeometry.NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672920);
			BeamGeometry.NativeMethodInfoPtr_SetDynamicOcclusionCallback_Public_Void_String_Callback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672921);
			BeamGeometry.NativeMethodInfoPtr_UpdateMaterialAndBounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672922);
			BeamGeometry.NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672923);
			BeamGeometry.NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672924);
			BeamGeometry.NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672925);
			BeamGeometry.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672926);
			BeamGeometry.NativeMethodInfoPtr_UpdateCameraRelatedProperties_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672927);
			BeamGeometry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, 100672928);
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x0000210C File Offset: 0x0000030C
		public BeamGeometry(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x0600782C RID: 30764 RVA: 0x001E4F74 File Offset: 0x001E3174
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr));
			}
		}

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x0600782D RID: 30765 RVA: 0x001E4F88 File Offset: 0x001E3188
		// (set) Token: 0x0600782E RID: 30766 RVA: 0x001E4FBC File Offset: 0x001E31BC
		public unsafe VolumetricLightBeam m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new VolumetricLightBeam(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x0600782F RID: 30767 RVA: 0x001E4FE4 File Offset: 0x001E31E4
		// (set) Token: 0x06007830 RID: 30768 RVA: 0x001E500C File Offset: 0x001E320C
		public unsafe Matrix4x4 m_ColorGradientMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_ColorGradientMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_ColorGradientMatrix)) = value;
			}
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x06007831 RID: 30769 RVA: 0x001E5030 File Offset: 0x001E3230
		// (set) Token: 0x06007832 RID: 30770 RVA: 0x001E5058 File Offset: 0x001E3258
		public unsafe MeshType m_CurrentMeshType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_CurrentMeshType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_CurrentMeshType)) = value;
			}
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x06007833 RID: 30771 RVA: 0x001E507C File Offset: 0x001E327C
		// (set) Token: 0x06007834 RID: 30772 RVA: 0x001E50B0 File Offset: 0x001E32B0
		public unsafe Material m_CustomMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_CustomMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Material(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_CustomMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x06007835 RID: 30773 RVA: 0x001E50D8 File Offset: 0x001E32D8
		// (set) Token: 0x06007836 RID: 30774 RVA: 0x001E510C File Offset: 0x001E330C
		public unsafe MaterialModifier.Callback m_MaterialModifierCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_MaterialModifierCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new MaterialModifier.Callback(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_MaterialModifierCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x06007837 RID: 30775 RVA: 0x001E5134 File Offset: 0x001E3334
		// (set) Token: 0x06007838 RID: 30776 RVA: 0x001E5168 File Offset: 0x001E3368
		public unsafe Coroutine m_CoFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_CoFadeOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Coroutine(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_CoFadeOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x06007839 RID: 30777 RVA: 0x001E5190 File Offset: 0x001E3390
		// (set) Token: 0x0600783A RID: 30778 RVA: 0x001E51C4 File Offset: 0x001E33C4
		public unsafe MeshRenderer _meshRenderer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr__meshRenderer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new MeshRenderer(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr__meshRenderer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x0600783B RID: 30779 RVA: 0x001E51EC File Offset: 0x001E33EC
		// (set) Token: 0x0600783C RID: 30780 RVA: 0x001E5220 File Offset: 0x001E3420
		public unsafe MeshFilter _meshFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr__meshFilter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new MeshFilter(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr__meshFilter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x0600783D RID: 30781 RVA: 0x001E5248 File Offset: 0x001E3448
		// (set) Token: 0x0600783E RID: 30782 RVA: 0x001E527C File Offset: 0x001E347C
		public unsafe Mesh _coneMesh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr__coneMesh_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr__coneMesh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x0600783F RID: 30783 RVA: 0x001E52A4 File Offset: 0x001E34A4
		// (set) Token: 0x06007840 RID: 30784 RVA: 0x001E52D8 File Offset: 0x001E34D8
		public unsafe Camera m_CurrentCameraRenderingSRP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Camera(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CBD RID: 19645
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x04004CBE RID: 19646
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGradientMatrix;

		// Token: 0x04004CBF RID: 19647
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentMeshType;

		// Token: 0x04004CC0 RID: 19648
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomMaterial;

		// Token: 0x04004CC1 RID: 19649
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialModifierCallback;

		// Token: 0x04004CC2 RID: 19650
		private static readonly IntPtr NativeFieldInfoPtr_m_CoFadeOut;

		// Token: 0x04004CC3 RID: 19651
		private static readonly IntPtr NativeFieldInfoPtr__meshRenderer_k__BackingField;

		// Token: 0x04004CC4 RID: 19652
		private static readonly IntPtr NativeFieldInfoPtr__meshFilter_k__BackingField;

		// Token: 0x04004CC5 RID: 19653
		private static readonly IntPtr NativeFieldInfoPtr__coneMesh_k__BackingField;

		// Token: 0x04004CC6 RID: 19654
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCameraRenderingSRP;

		// Token: 0x04004CC7 RID: 19655
		private static readonly IntPtr NativeMethodInfoPtr_get_meshRenderer_Public_get_MeshRenderer_0;

		// Token: 0x04004CC8 RID: 19656
		private static readonly IntPtr NativeMethodInfoPtr_set_meshRenderer_Private_set_Void_MeshRenderer_0;

		// Token: 0x04004CC9 RID: 19657
		private static readonly IntPtr NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0;

		// Token: 0x04004CCA RID: 19658
		private static readonly IntPtr NativeMethodInfoPtr_set_meshFilter_Private_set_Void_MeshFilter_0;

		// Token: 0x04004CCB RID: 19659
		private static readonly IntPtr NativeMethodInfoPtr_get_coneMesh_Public_get_Mesh_0;

		// Token: 0x04004CCC RID: 19660
		private static readonly IntPtr NativeMethodInfoPtr_set_coneMesh_Private_set_Void_Mesh_0;

		// Token: 0x04004CCD RID: 19661
		private static readonly IntPtr NativeMethodInfoPtr_get_visible_Public_get_Boolean_0;

		// Token: 0x04004CCE RID: 19662
		private static readonly IntPtr NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0;

		// Token: 0x04004CCF RID: 19663
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x04004CD0 RID: 19664
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x04004CD1 RID: 19665
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x04004CD2 RID: 19666
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x04004CD3 RID: 19667
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_IsFadeOutCoroutineRunning_Public_get_Boolean_0;

		// Token: 0x04004CD4 RID: 19668
		private static readonly IntPtr NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Single_Transform_0;

		// Token: 0x04004CD5 RID: 19669
		private static readonly IntPtr NativeMethodInfoPtr_CoUpdateFadeOut_Private_IEnumerator_0;

		// Token: 0x04004CD6 RID: 19670
		private static readonly IntPtr NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Void_0;

		// Token: 0x04004CD7 RID: 19671
		private static readonly IntPtr NativeMethodInfoPtr_SetFadeOutFactorProp_Private_Void_Single_0;

		// Token: 0x04004CD8 RID: 19672
		private static readonly IntPtr NativeMethodInfoPtr_RestartFadeOutCoroutine_Public_Void_0;

		// Token: 0x04004CD9 RID: 19673
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004CDA RID: 19674
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004CDB RID: 19675
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04004CDC RID: 19676
		private static readonly IntPtr NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0;

		// Token: 0x04004CDD RID: 19677
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0;

		// Token: 0x04004CDE RID: 19678
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04004CDF RID: 19679
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeam_0;

		// Token: 0x04004CE0 RID: 19680
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateMesh_Public_Void_0;

		// Token: 0x04004CE1 RID: 19681
		private static readonly IntPtr NativeMethodInfoPtr_ComputeLocalMatrix_Private_Void_0;

		// Token: 0x04004CE2 RID: 19682
		private static readonly IntPtr NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0;

		// Token: 0x04004CE3 RID: 19683
		private static readonly IntPtr NativeMethodInfoPtr_get_isDepthBlendEnabled_Private_get_Boolean_0;

		// Token: 0x04004CE4 RID: 19684
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0;

		// Token: 0x04004CE5 RID: 19685
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Single_0;

		// Token: 0x04004CE6 RID: 19686
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Vector4_0;

		// Token: 0x04004CE7 RID: 19687
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Color_0;

		// Token: 0x04004CE8 RID: 19688
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Matrix4x4_0;

		// Token: 0x04004CE9 RID: 19689
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Texture_0;

		// Token: 0x04004CEA RID: 19690
		private static readonly IntPtr NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0;

		// Token: 0x04004CEB RID: 19691
		private static readonly IntPtr NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0;

		// Token: 0x04004CEC RID: 19692
		private static readonly IntPtr NativeMethodInfoPtr_SetDynamicOcclusionCallback_Public_Void_String_Callback_0;

		// Token: 0x04004CED RID: 19693
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterialAndBounds_Public_Void_0;

		// Token: 0x04004CEE RID: 19694
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0;

		// Token: 0x04004CEF RID: 19695
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04004CF0 RID: 19696
		private static readonly IntPtr NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0;

		// Token: 0x04004CF1 RID: 19697
		private static readonly IntPtr NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0;

		// Token: 0x04004CF2 RID: 19698
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraRelatedProperties_Private_Void_Camera_0;

		// Token: 0x04004CF3 RID: 19699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005C3 RID: 1475
		[ObfuscatedName("VLB.BeamGeometry/<CoUpdateFadeOut>d__30")]
		public sealed class _CoUpdateFadeOut_d__30 : Il2CppSystem.Object
		{
			// Token: 0x06007841 RID: 30785 RVA: 0x001E5300 File Offset: 0x001E3500
			[CallerCount(0)]
			public unsafe _CoUpdateFadeOut_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeamGeometry._CoUpdateFadeOut_d__30>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry._CoUpdateFadeOut_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007842 RID: 30786 RVA: 0x001E5360 File Offset: 0x001E3560
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry._CoUpdateFadeOut_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007843 RID: 30787 RVA: 0x001E53A4 File Offset: 0x001E35A4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BeamGeometry._CoUpdateFadeOut_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17002AF9 RID: 11001
			// (get) Token: 0x06007844 RID: 30788 RVA: 0x001E53F4 File Offset: 0x001E35F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry._CoUpdateFadeOut_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007845 RID: 30789 RVA: 0x001E544C File Offset: 0x001E364C
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry._CoUpdateFadeOut_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17002AFA RID: 11002
			// (get) Token: 0x06007846 RID: 30790 RVA: 0x001E5490 File Offset: 0x001E3690
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometry._CoUpdateFadeOut_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007847 RID: 30791 RVA: 0x001E54E8 File Offset: 0x001E36E8
			// Note: this type is marked as 'beforefieldinit'.
			static _CoUpdateFadeOut_d__30()
			{
				Il2CppClassPointerStore<BeamGeometry._CoUpdateFadeOut_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BeamGeometry>.NativeClassPtr, "<CoUpdateFadeOut>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeamGeometry._CoUpdateFadeOut_d__30>.NativeClassPtr);
				BeamGeometry._CoUpdateFadeOut_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometry._CoUpdateFadeOut_d__30>.NativeClassPtr, "<>1__state");
				BeamGeometry._CoUpdateFadeOut_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometry._CoUpdateFadeOut_d__30>.NativeClassPtr, "<>2__current");
				BeamGeometry._CoUpdateFadeOut_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometry._CoUpdateFadeOut_d__30>.NativeClassPtr, "<>4__this");
				BeamGeometry._CoUpdateFadeOut_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry._CoUpdateFadeOut_d__30>.NativeClassPtr, 100672929);
				BeamGeometry._CoUpdateFadeOut_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry._CoUpdateFadeOut_d__30>.NativeClassPtr, 100672930);
				BeamGeometry._CoUpdateFadeOut_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry._CoUpdateFadeOut_d__30>.NativeClassPtr, 100672931);
				BeamGeometry._CoUpdateFadeOut_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry._CoUpdateFadeOut_d__30>.NativeClassPtr, 100672932);
				BeamGeometry._CoUpdateFadeOut_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry._CoUpdateFadeOut_d__30>.NativeClassPtr, 100672933);
				BeamGeometry._CoUpdateFadeOut_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometry._CoUpdateFadeOut_d__30>.NativeClassPtr, 100672934);
			}

			// Token: 0x06007848 RID: 30792 RVA: 0x00002988 File Offset: 0x00000B88
			public _CoUpdateFadeOut_d__30(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002AF5 RID: 10997
			// (get) Token: 0x06007849 RID: 30793 RVA: 0x001E55C7 File Offset: 0x001E37C7
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BeamGeometry._CoUpdateFadeOut_d__30>.NativeClassPtr));
				}
			}

			// Token: 0x17002AF6 RID: 10998
			// (get) Token: 0x0600784A RID: 30794 RVA: 0x001E55D8 File Offset: 0x001E37D8
			// (set) Token: 0x0600784B RID: 30795 RVA: 0x001E5600 File Offset: 0x001E3800
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry._CoUpdateFadeOut_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry._CoUpdateFadeOut_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002AF7 RID: 10999
			// (get) Token: 0x0600784C RID: 30796 RVA: 0x001E5624 File Offset: 0x001E3824
			// (set) Token: 0x0600784D RID: 30797 RVA: 0x001E5658 File Offset: 0x001E3858
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry._CoUpdateFadeOut_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry._CoUpdateFadeOut_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002AF8 RID: 11000
			// (get) Token: 0x0600784E RID: 30798 RVA: 0x001E5680 File Offset: 0x001E3880
			// (set) Token: 0x0600784F RID: 30799 RVA: 0x001E56B4 File Offset: 0x001E38B4
			public unsafe BeamGeometry __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry._CoUpdateFadeOut_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new BeamGeometry(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometry._CoUpdateFadeOut_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004CF4 RID: 19700
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004CF5 RID: 19701
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004CF6 RID: 19702
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004CF7 RID: 19703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004CF8 RID: 19704
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004CF9 RID: 19705
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004CFA RID: 19706
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004CFB RID: 19707
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004CFC RID: 19708
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
