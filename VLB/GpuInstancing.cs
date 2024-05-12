using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005D9 RID: 1497
	public static class GpuInstancing : Il2CppSystem.Object
	{
		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x060079DC RID: 31196 RVA: 0x001EA7B8 File Offset: 0x001E89B8
		public unsafe static bool forceEnableDepthBlend
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GpuInstancing.NativeMethodInfoPtr_get_forceEnableDepthBlend_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x001EA7FC File Offset: 0x001E89FC
		[CallerCount(0)]
		public unsafe static void SetMaterialProperties(Material material, bool enableInstancing)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableInstancing;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GpuInstancing.NativeMethodInfoPtr_SetMaterialProperties_Public_Static_Void_Material_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x001EA85C File Offset: 0x001E8A5C
		[CallerCount(0)]
		public unsafe static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beamA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beamB);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GpuInstancing.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeam_VolumetricLightBeam_byref_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reasons = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x001EA8FC File Offset: 0x001E8AFC
		[CallerCount(0)]
		public unsafe static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GpuInstancing.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeam_byref_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reasons = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060079E0 RID: 31200 RVA: 0x001EA984 File Offset: 0x001E8B84
		[CallerCount(0)]
		public unsafe static void AppendErrorMessage(ref string message, string toAppend)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr il2CppString = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr2 = &il2CppString;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(toAppend);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GpuInstancing.NativeMethodInfoPtr_AppendErrorMessage_Private_Static_Void_byref_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			message = IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x001EAA00 File Offset: 0x001E8C00
		// Note: this type is marked as 'beforefieldinit'.
		static GpuInstancing()
		{
			Il2CppClassPointerStore<GpuInstancing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "GpuInstancing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GpuInstancing>.NativeClassPtr);
			GpuInstancing.NativeFieldInfoPtr_isSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GpuInstancing>.NativeClassPtr, "isSupported");
			GpuInstancing.NativeMethodInfoPtr_get_forceEnableDepthBlend_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuInstancing>.NativeClassPtr, 100673025);
			GpuInstancing.NativeMethodInfoPtr_SetMaterialProperties_Public_Static_Void_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuInstancing>.NativeClassPtr, 100673026);
			GpuInstancing.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeam_VolumetricLightBeam_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuInstancing>.NativeClassPtr, 100673027);
			GpuInstancing.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeam_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuInstancing>.NativeClassPtr, 100673028);
			GpuInstancing.NativeMethodInfoPtr_AppendErrorMessage_Private_Static_Void_byref_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GpuInstancing>.NativeClassPtr, 100673029);
		}

		// Token: 0x060079E2 RID: 31202 RVA: 0x00002988 File Offset: 0x00000B88
		public GpuInstancing(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x060079E3 RID: 31203 RVA: 0x001EAAA8 File Offset: 0x001E8CA8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GpuInstancing>.NativeClassPtr));
			}
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x060079E4 RID: 31204 RVA: 0x001EAABC File Offset: 0x001E8CBC
		// (set) Token: 0x060079E5 RID: 31205 RVA: 0x001EAADA File Offset: 0x001E8CDA
		public unsafe static bool isSupported
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GpuInstancing.NativeFieldInfoPtr_isSupported, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GpuInstancing.NativeFieldInfoPtr_isSupported, (void*)(&value));
			}
		}

		// Token: 0x04004E0D RID: 19981
		private static readonly IntPtr NativeFieldInfoPtr_isSupported;

		// Token: 0x04004E0E RID: 19982
		private static readonly IntPtr NativeMethodInfoPtr_get_forceEnableDepthBlend_Public_Static_get_Boolean_0;

		// Token: 0x04004E0F RID: 19983
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProperties_Public_Static_Void_Material_Boolean_0;

		// Token: 0x04004E10 RID: 19984
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeam_VolumetricLightBeam_byref_String_0;

		// Token: 0x04004E11 RID: 19985
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeam_byref_String_0;

		// Token: 0x04004E12 RID: 19986
		private static readonly IntPtr NativeMethodInfoPtr_AppendErrorMessage_Private_Static_Void_byref_String_String_0;
	}
}
