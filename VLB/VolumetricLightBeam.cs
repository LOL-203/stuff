using System;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005F3 RID: 1523
	public class VolumetricLightBeam : MonoBehaviour
	{
		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x06007AFD RID: 31485 RVA: 0x001EE6A0 File Offset: 0x001EC8A0
		// (set) Token: 0x06007AFE RID: 31486 RVA: 0x001EE6F0 File Offset: 0x001EC8F0
		public unsafe float alphaInside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_alphaInside_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_alphaInside_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x06007AFF RID: 31487 RVA: 0x001EE744 File Offset: 0x001EC944
		// (set) Token: 0x06007B00 RID: 31488 RVA: 0x001EE794 File Offset: 0x001EC994
		public unsafe float alphaOutside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_alphaOutside_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_alphaOutside_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C3E RID: 11326
		// (get) Token: 0x06007B01 RID: 31489 RVA: 0x001EE7E8 File Offset: 0x001EC9E8
		// (set) Token: 0x06007B02 RID: 31490 RVA: 0x001EE838 File Offset: 0x001ECA38
		public unsafe float intensityGlobal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_intensityGlobal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_intensityGlobal_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C3F RID: 11327
		// (get) Token: 0x06007B03 RID: 31491 RVA: 0x001EE88C File Offset: 0x001ECA8C
		public unsafe float coneAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_coneAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x06007B04 RID: 31492 RVA: 0x001EE8DC File Offset: 0x001ECADC
		public unsafe float coneRadiusEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_coneRadiusEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x06007B05 RID: 31493 RVA: 0x001EE92C File Offset: 0x001ECB2C
		public unsafe float coneVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_coneVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x06007B06 RID: 31494 RVA: 0x001EE97C File Offset: 0x001ECB7C
		public unsafe float coneApexOffsetZ
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_coneApexOffsetZ_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x06007B07 RID: 31495 RVA: 0x001EE9CC File Offset: 0x001ECBCC
		// (set) Token: 0x06007B08 RID: 31496 RVA: 0x001EEA1C File Offset: 0x001ECC1C
		public unsafe int geomSides
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_geomSides_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_geomSides_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x06007B09 RID: 31497 RVA: 0x001EEA70 File Offset: 0x001ECC70
		// (set) Token: 0x06007B0A RID: 31498 RVA: 0x001EEAC0 File Offset: 0x001ECCC0
		public unsafe int geomSegments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_geomSegments_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_geomSegments_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x06007B0B RID: 31499 RVA: 0x001EEB14 File Offset: 0x001ECD14
		// (set) Token: 0x06007B0C RID: 31500 RVA: 0x001EEB64 File Offset: 0x001ECD64
		public unsafe bool fadeEndFromLight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_fadeEndFromLight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_fadeEndFromLight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C46 RID: 11334
		// (get) Token: 0x06007B0D RID: 31501 RVA: 0x001EEBB8 File Offset: 0x001ECDB8
		public unsafe float attenuationLerpLinearQuad
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_attenuationLerpLinearQuad_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C47 RID: 11335
		// (get) Token: 0x06007B0E RID: 31502 RVA: 0x001EEC08 File Offset: 0x001ECE08
		// (set) Token: 0x06007B0F RID: 31503 RVA: 0x001EEC58 File Offset: 0x001ECE58
		public unsafe float fadeStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_fadeStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_fadeStart_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C48 RID: 11336
		// (get) Token: 0x06007B10 RID: 31504 RVA: 0x001EECAC File Offset: 0x001ECEAC
		// (set) Token: 0x06007B11 RID: 31505 RVA: 0x001EECFC File Offset: 0x001ECEFC
		public unsafe float fadeEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_fadeEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_fadeEnd_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x06007B12 RID: 31506 RVA: 0x001EED50 File Offset: 0x001ECF50
		public unsafe bool isNoiseEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_isNoiseEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x06007B13 RID: 31507 RVA: 0x001EEDA0 File Offset: 0x001ECFA0
		// (set) Token: 0x06007B14 RID: 31508 RVA: 0x001EEDF0 File Offset: 0x001ECFF0
		public unsafe bool noiseEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_noiseEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_noiseEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x06007B15 RID: 31509 RVA: 0x001EEE44 File Offset: 0x001ED044
		// (set) Token: 0x06007B16 RID: 31510 RVA: 0x001EEE94 File Offset: 0x001ED094
		public unsafe float fadeOutBegin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_fadeOutBegin_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_fadeOutBegin_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x06007B17 RID: 31511 RVA: 0x001EEEE8 File Offset: 0x001ED0E8
		// (set) Token: 0x06007B18 RID: 31512 RVA: 0x001EEF38 File Offset: 0x001ED138
		public unsafe float fadeOutEnd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_fadeOutEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_fadeOutEnd_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x06007B19 RID: 31513 RVA: 0x001EEF8C File Offset: 0x001ED18C
		public unsafe bool isFadeOutEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_isFadeOutEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x06007B1A RID: 31514 RVA: 0x001EEFDC File Offset: 0x001ED1DC
		// (set) Token: 0x06007B1B RID: 31515 RVA: 0x001EF02C File Offset: 0x001ED22C
		public unsafe int sortingLayerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x06007B1C RID: 31516 RVA: 0x001EF080 File Offset: 0x001ED280
		// (set) Token: 0x06007B1D RID: 31517 RVA: 0x001EF0CC File Offset: 0x001ED2CC
		public unsafe string sortingLayerName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x06007B1E RID: 31518 RVA: 0x001EF128 File Offset: 0x001ED328
		// (set) Token: 0x06007B1F RID: 31519 RVA: 0x001EF178 File Offset: 0x001ED378
		public unsafe int sortingOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x06007B20 RID: 31520 RVA: 0x001EF1CC File Offset: 0x001ED3CC
		// (set) Token: 0x06007B21 RID: 31521 RVA: 0x001EF21C File Offset: 0x001ED41C
		public unsafe bool trackChangesDuringPlaytime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_trackChangesDuringPlaytime_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set_trackChangesDuringPlaytime_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x06007B22 RID: 31522 RVA: 0x001EF270 File Offset: 0x001ED470
		public unsafe bool isCurrentlyTrackingChanges
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_isCurrentlyTrackingChanges_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x06007B23 RID: 31523 RVA: 0x001EF2C0 File Offset: 0x001ED4C0
		public unsafe bool hasGeometry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_hasGeometry_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x06007B24 RID: 31524 RVA: 0x001EF310 File Offset: 0x001ED510
		public unsafe Bounds bounds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x06007B25 RID: 31525 RVA: 0x001EF360 File Offset: 0x001ED560
		public unsafe int blendingModeAsInt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_blendingModeAsInt_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x06007B26 RID: 31526 RVA: 0x001EF3B0 File Offset: 0x001ED5B0
		// (set) Token: 0x06007B27 RID: 31527 RVA: 0x001EF400 File Offset: 0x001ED600
		public unsafe MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Public_get_DynamicOcclusion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set__INTERNAL_DynamicOcclusionMode_Public_set_Void_DynamicOcclusion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x06007B28 RID: 31528 RVA: 0x001EF454 File Offset: 0x001ED654
		public unsafe MaterialManager.DynamicOcclusion _INTERNAL_EnabledDynamicOcclusionMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get__INTERNAL_EnabledDynamicOcclusionMode_Public_get_DynamicOcclusion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x001EF4A4 File Offset: 0x001ED6A4
		[CallerCount(0)]
		public unsafe void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shaderKeyword);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr__INTERNAL_SetDynamicOcclusionCallback_Public_Void_String_Callback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x001EF518 File Offset: 0x001ED718
		[CallerCount(0)]
		public unsafe void add_onWillCameraRenderThisBeam(VolumetricLightBeam.OnWillCameraRenderCB value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_add_onWillCameraRenderThisBeam_Public_add_Void_OnWillCameraRenderCB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x001EF574 File Offset: 0x001ED774
		[CallerCount(0)]
		public unsafe void remove_onWillCameraRenderThisBeam(VolumetricLightBeam.OnWillCameraRenderCB value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_remove_onWillCameraRenderThisBeam_Public_rem_Void_OnWillCameraRenderCB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x001EF5D0 File Offset: 0x001ED7D0
		[CallerCount(0)]
		public unsafe void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr__INTERNAL_OnWillCameraRenderThisBeam_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B2D RID: 31533 RVA: 0x001EF62C File Offset: 0x001ED82C
		[CallerCount(0)]
		public unsafe void RegisterOnBeamGeometryInitializedCallback(VolumetricLightBeam.OnBeamGeometryInitialized cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_RegisterOnBeamGeometryInitializedCallback_Public_Void_OnBeamGeometryInitialized_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x001EF688 File Offset: 0x001ED888
		[CallerCount(0)]
		public unsafe void CallOnBeamGeometryInitializedCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_CallOnBeamGeometryInitializedCallback_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x001EF6CC File Offset: 0x001ED8CC
		[CallerCount(0)]
		public unsafe void SetFadeOutValue(ref float propToChange, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &propToChange;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_SetFadeOutValue_Private_Void_byref_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B30 RID: 31536 RVA: 0x001EF734 File Offset: 0x001ED934
		[CallerCount(0)]
		public unsafe void OnFadeOutStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_OnFadeOutStateChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x06007B31 RID: 31537 RVA: 0x001EF778 File Offset: 0x001ED978
		// (set) Token: 0x06007B32 RID: 31538 RVA: 0x001EF7C8 File Offset: 0x001ED9C8
		public unsafe uint _INTERNAL_InstancedMaterialGroupID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get__INTERNAL_InstancedMaterialGroupID_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_set__INTERNAL_InstancedMaterialGroupID_Protected_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x06007B33 RID: 31539 RVA: 0x001EF81C File Offset: 0x001EDA1C
		public unsafe string meshStats
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_meshStats_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x06007B34 RID: 31540 RVA: 0x001EF868 File Offset: 0x001EDA68
		public unsafe int meshVerticesCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_meshVerticesCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C5B RID: 11355
		// (get) Token: 0x06007B35 RID: 31541 RVA: 0x001EF8B8 File Offset: 0x001EDAB8
		public unsafe int meshTrianglesCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_meshTrianglesCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C5C RID: 11356
		// (get) Token: 0x06007B36 RID: 31542 RVA: 0x001EF908 File Offset: 0x001EDB08
		public unsafe Light lightSpotAttached
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_get_lightSpotAttached_Private_get_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Light(intPtr2) : null;
			}
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x001EF960 File Offset: 0x001EDB60
		[CallerCount(0)]
		public unsafe float GetInsideBeamFactor(Vector3 posWS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref posWS;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_GetInsideBeamFactor_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x001EF9C4 File Offset: 0x001EDBC4
		[CallerCount(0)]
		public unsafe float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref posOS;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_GetInsideBeamFactorFromObjectSpacePos_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007B39 RID: 31545 RVA: 0x001EFA28 File Offset: 0x001EDC28
		[CallerCount(0)]
		public unsafe void Generate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_Generate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x001EFA6C File Offset: 0x001EDC6C
		[CallerCount(0)]
		public unsafe void GenerateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeam.NativeMethodInfoPtr_GenerateGeometry_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x001EFABC File Offset: 0x001EDCBC
		[CallerCount(0)]
		public unsafe void UpdateAfterManualPropertyChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeam.NativeMethodInfoPtr_UpdateAfterManualPropertyChange_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B3C RID: 31548 RVA: 0x001EFB0C File Offset: 0x001EDD0C
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B3D RID: 31549 RVA: 0x001EFB50 File Offset: 0x001EDD50
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B3E RID: 31550 RVA: 0x001EFB94 File Offset: 0x001EDD94
		[CallerCount(0)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B3F RID: 31551 RVA: 0x001EFBD8 File Offset: 0x001EDDD8
		[CallerCount(0)]
		public unsafe void StartPlaytimeUpdateIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_StartPlaytimeUpdateIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B40 RID: 31552 RVA: 0x001EFC1C File Offset: 0x001EDE1C
		[CallerCount(0)]
		public unsafe IEnumerator CoPlaytimeUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_CoPlaytimeUpdate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new IEnumerator(intPtr2) : null;
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x001EFC74 File Offset: 0x001EDE74
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x001EFCB8 File Offset: 0x001EDEB8
		[CallerCount(0)]
		public unsafe void DestroyBeam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_DestroyBeam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B43 RID: 31555 RVA: 0x001EFCFC File Offset: 0x001EDEFC
		[CallerCount(0)]
		public unsafe void AssignPropertiesFromSpotLight(Light lightSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lightSpot);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_AssignPropertiesFromSpotLight_Private_Void_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B44 RID: 31556 RVA: 0x001EFD58 File Offset: 0x001EDF58
		[CallerCount(0)]
		public unsafe void ClampProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_ClampProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B45 RID: 31557 RVA: 0x001EFD9C File Offset: 0x001EDF9C
		[CallerCount(0)]
		public unsafe void ValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_ValidateProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B46 RID: 31558 RVA: 0x001EFDE0 File Offset: 0x001EDFE0
		[CallerCount(0)]
		public unsafe void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref serializedVersion;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVersion;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B47 RID: 31559 RVA: 0x001EFE48 File Offset: 0x001EE048
		[CallerCount(0)]
		public unsafe VolumetricLightBeam() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B48 RID: 31560 RVA: 0x001EFE94 File Offset: 0x001EE094
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricLightBeam()
		{
			Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricLightBeam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr);
			VolumetricLightBeam.NativeFieldInfoPtr_colorFromLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "colorFromLight");
			VolumetricLightBeam.NativeFieldInfoPtr_colorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "colorMode");
			VolumetricLightBeam.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "color");
			VolumetricLightBeam.NativeFieldInfoPtr_colorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "colorGradient");
			VolumetricLightBeam.NativeFieldInfoPtr_intensityFromLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "intensityFromLight");
			VolumetricLightBeam.NativeFieldInfoPtr_intensityModeAdvanced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "intensityModeAdvanced");
			VolumetricLightBeam.NativeFieldInfoPtr_intensityInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "intensityInside");
			VolumetricLightBeam.NativeFieldInfoPtr_intensityOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "intensityOutside");
			VolumetricLightBeam.NativeFieldInfoPtr_blendingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "blendingMode");
			VolumetricLightBeam.NativeFieldInfoPtr_spotAngleFromLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "spotAngleFromLight");
			VolumetricLightBeam.NativeFieldInfoPtr_spotAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "spotAngle");
			VolumetricLightBeam.NativeFieldInfoPtr_coneRadiusStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "coneRadiusStart");
			VolumetricLightBeam.NativeFieldInfoPtr_geomMeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "geomMeshType");
			VolumetricLightBeam.NativeFieldInfoPtr_geomCustomSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "geomCustomSides");
			VolumetricLightBeam.NativeFieldInfoPtr_geomCustomSegments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "geomCustomSegments");
			VolumetricLightBeam.NativeFieldInfoPtr_geomCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "geomCap");
			VolumetricLightBeam.NativeFieldInfoPtr_fallOffEndFromLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "fallOffEndFromLight");
			VolumetricLightBeam.NativeFieldInfoPtr_attenuationEquation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "attenuationEquation");
			VolumetricLightBeam.NativeFieldInfoPtr_attenuationCustomBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "attenuationCustomBlending");
			VolumetricLightBeam.NativeFieldInfoPtr_fallOffStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "fallOffStart");
			VolumetricLightBeam.NativeFieldInfoPtr_fallOffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "fallOffEnd");
			VolumetricLightBeam.NativeFieldInfoPtr_depthBlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "depthBlendDistance");
			VolumetricLightBeam.NativeFieldInfoPtr_cameraClippingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "cameraClippingDistance");
			VolumetricLightBeam.NativeFieldInfoPtr_glareFrontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "glareFrontal");
			VolumetricLightBeam.NativeFieldInfoPtr_glareBehind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "glareBehind");
			VolumetricLightBeam.NativeFieldInfoPtr_fresnelPow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "fresnelPow");
			VolumetricLightBeam.NativeFieldInfoPtr_noiseMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "noiseMode");
			VolumetricLightBeam.NativeFieldInfoPtr__DEPRECATED_NoiseEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "_DEPRECATED_NoiseEnabled");
			VolumetricLightBeam.NativeFieldInfoPtr_noiseIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "noiseIntensity");
			VolumetricLightBeam.NativeFieldInfoPtr_noiseScaleUseGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "noiseScaleUseGlobal");
			VolumetricLightBeam.NativeFieldInfoPtr_noiseScaleLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "noiseScaleLocal");
			VolumetricLightBeam.NativeFieldInfoPtr_noiseVelocityUseGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "noiseVelocityUseGlobal");
			VolumetricLightBeam.NativeFieldInfoPtr_noiseVelocityLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "noiseVelocityLocal");
			VolumetricLightBeam.NativeFieldInfoPtr___INTERNAL_DynamicOcclusionMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "<_INTERNAL_DynamicOcclusionMode>k__BackingField");
			VolumetricLightBeam.NativeFieldInfoPtr_m_IsDynamicOcclusionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "m_IsDynamicOcclusionEnabled");
			VolumetricLightBeam.NativeFieldInfoPtr_onWillCameraRenderThisBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "onWillCameraRenderThisBeam");
			VolumetricLightBeam.NativeFieldInfoPtr_m_OnBeamGeometryInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "m_OnBeamGeometryInitialized");
			VolumetricLightBeam.NativeFieldInfoPtr_pluginVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "pluginVersion");
			VolumetricLightBeam.NativeFieldInfoPtr__TrackChangesDuringPlaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "_TrackChangesDuringPlaytime");
			VolumetricLightBeam.NativeFieldInfoPtr__SortingLayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "_SortingLayerID");
			VolumetricLightBeam.NativeFieldInfoPtr__SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "_SortingOrder");
			VolumetricLightBeam.NativeFieldInfoPtr__FadeOutBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "_FadeOutBegin");
			VolumetricLightBeam.NativeFieldInfoPtr__FadeOutEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "_FadeOutEnd");
			VolumetricLightBeam.NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "<_INTERNAL_InstancedMaterialGroupID>k__BackingField");
			VolumetricLightBeam.NativeFieldInfoPtr_m_BeamGeom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "m_BeamGeom");
			VolumetricLightBeam.NativeFieldInfoPtr_m_CoPlaytimeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "m_CoPlaytimeUpdate");
			VolumetricLightBeam.NativeFieldInfoPtr__CachedLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "_CachedLight");
			VolumetricLightBeam.NativeMethodInfoPtr_get_alphaInside_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673104);
			VolumetricLightBeam.NativeMethodInfoPtr_set_alphaInside_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673105);
			VolumetricLightBeam.NativeMethodInfoPtr_get_alphaOutside_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673106);
			VolumetricLightBeam.NativeMethodInfoPtr_set_alphaOutside_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673107);
			VolumetricLightBeam.NativeMethodInfoPtr_get_intensityGlobal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673108);
			VolumetricLightBeam.NativeMethodInfoPtr_set_intensityGlobal_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673109);
			VolumetricLightBeam.NativeMethodInfoPtr_get_coneAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673110);
			VolumetricLightBeam.NativeMethodInfoPtr_get_coneRadiusEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673111);
			VolumetricLightBeam.NativeMethodInfoPtr_get_coneVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673112);
			VolumetricLightBeam.NativeMethodInfoPtr_get_coneApexOffsetZ_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673113);
			VolumetricLightBeam.NativeMethodInfoPtr_get_geomSides_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673114);
			VolumetricLightBeam.NativeMethodInfoPtr_set_geomSides_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673115);
			VolumetricLightBeam.NativeMethodInfoPtr_get_geomSegments_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673116);
			VolumetricLightBeam.NativeMethodInfoPtr_set_geomSegments_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673117);
			VolumetricLightBeam.NativeMethodInfoPtr_get_fadeEndFromLight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673118);
			VolumetricLightBeam.NativeMethodInfoPtr_set_fadeEndFromLight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673119);
			VolumetricLightBeam.NativeMethodInfoPtr_get_attenuationLerpLinearQuad_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673120);
			VolumetricLightBeam.NativeMethodInfoPtr_get_fadeStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673121);
			VolumetricLightBeam.NativeMethodInfoPtr_set_fadeStart_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673122);
			VolumetricLightBeam.NativeMethodInfoPtr_get_fadeEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673123);
			VolumetricLightBeam.NativeMethodInfoPtr_set_fadeEnd_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673124);
			VolumetricLightBeam.NativeMethodInfoPtr_get_isNoiseEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673125);
			VolumetricLightBeam.NativeMethodInfoPtr_get_noiseEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673126);
			VolumetricLightBeam.NativeMethodInfoPtr_set_noiseEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673127);
			VolumetricLightBeam.NativeMethodInfoPtr_get_fadeOutBegin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673128);
			VolumetricLightBeam.NativeMethodInfoPtr_set_fadeOutBegin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673129);
			VolumetricLightBeam.NativeMethodInfoPtr_get_fadeOutEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673130);
			VolumetricLightBeam.NativeMethodInfoPtr_set_fadeOutEnd_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673131);
			VolumetricLightBeam.NativeMethodInfoPtr_get_isFadeOutEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673132);
			VolumetricLightBeam.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673133);
			VolumetricLightBeam.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673134);
			VolumetricLightBeam.NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673135);
			VolumetricLightBeam.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673136);
			VolumetricLightBeam.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673137);
			VolumetricLightBeam.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673138);
			VolumetricLightBeam.NativeMethodInfoPtr_get_trackChangesDuringPlaytime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673139);
			VolumetricLightBeam.NativeMethodInfoPtr_set_trackChangesDuringPlaytime_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673140);
			VolumetricLightBeam.NativeMethodInfoPtr_get_isCurrentlyTrackingChanges_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673141);
			VolumetricLightBeam.NativeMethodInfoPtr_get_hasGeometry_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673142);
			VolumetricLightBeam.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673143);
			VolumetricLightBeam.NativeMethodInfoPtr_get_blendingModeAsInt_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673144);
			VolumetricLightBeam.NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Public_get_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673145);
			VolumetricLightBeam.NativeMethodInfoPtr_set__INTERNAL_DynamicOcclusionMode_Public_set_Void_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673146);
			VolumetricLightBeam.NativeMethodInfoPtr_get__INTERNAL_EnabledDynamicOcclusionMode_Public_get_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673147);
			VolumetricLightBeam.NativeMethodInfoPtr__INTERNAL_SetDynamicOcclusionCallback_Public_Void_String_Callback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673148);
			VolumetricLightBeam.NativeMethodInfoPtr_add_onWillCameraRenderThisBeam_Public_add_Void_OnWillCameraRenderCB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673149);
			VolumetricLightBeam.NativeMethodInfoPtr_remove_onWillCameraRenderThisBeam_Public_rem_Void_OnWillCameraRenderCB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673150);
			VolumetricLightBeam.NativeMethodInfoPtr__INTERNAL_OnWillCameraRenderThisBeam_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673151);
			VolumetricLightBeam.NativeMethodInfoPtr_RegisterOnBeamGeometryInitializedCallback_Public_Void_OnBeamGeometryInitialized_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673152);
			VolumetricLightBeam.NativeMethodInfoPtr_CallOnBeamGeometryInitializedCallback_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673153);
			VolumetricLightBeam.NativeMethodInfoPtr_SetFadeOutValue_Private_Void_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673154);
			VolumetricLightBeam.NativeMethodInfoPtr_OnFadeOutStateChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673155);
			VolumetricLightBeam.NativeMethodInfoPtr_get__INTERNAL_InstancedMaterialGroupID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673156);
			VolumetricLightBeam.NativeMethodInfoPtr_set__INTERNAL_InstancedMaterialGroupID_Protected_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673157);
			VolumetricLightBeam.NativeMethodInfoPtr_get_meshStats_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673158);
			VolumetricLightBeam.NativeMethodInfoPtr_get_meshVerticesCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673159);
			VolumetricLightBeam.NativeMethodInfoPtr_get_meshTrianglesCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673160);
			VolumetricLightBeam.NativeMethodInfoPtr_get_lightSpotAttached_Private_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673161);
			VolumetricLightBeam.NativeMethodInfoPtr_GetInsideBeamFactor_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673162);
			VolumetricLightBeam.NativeMethodInfoPtr_GetInsideBeamFactorFromObjectSpacePos_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673163);
			VolumetricLightBeam.NativeMethodInfoPtr_Generate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673164);
			VolumetricLightBeam.NativeMethodInfoPtr_GenerateGeometry_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673165);
			VolumetricLightBeam.NativeMethodInfoPtr_UpdateAfterManualPropertyChange_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673166);
			VolumetricLightBeam.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673167);
			VolumetricLightBeam.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673168);
			VolumetricLightBeam.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673169);
			VolumetricLightBeam.NativeMethodInfoPtr_StartPlaytimeUpdateIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673170);
			VolumetricLightBeam.NativeMethodInfoPtr_CoPlaytimeUpdate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673171);
			VolumetricLightBeam.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673172);
			VolumetricLightBeam.NativeMethodInfoPtr_DestroyBeam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673173);
			VolumetricLightBeam.NativeMethodInfoPtr_AssignPropertiesFromSpotLight_Private_Void_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673174);
			VolumetricLightBeam.NativeMethodInfoPtr_ClampProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673175);
			VolumetricLightBeam.NativeMethodInfoPtr_ValidateProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673176);
			VolumetricLightBeam.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673177);
			VolumetricLightBeam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, 100673178);
		}

		// Token: 0x06007B49 RID: 31561 RVA: 0x0000210C File Offset: 0x0000030C
		public VolumetricLightBeam(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x06007B4A RID: 31562 RVA: 0x001F084C File Offset: 0x001EEA4C
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr));
			}
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x06007B4B RID: 31563 RVA: 0x001F0860 File Offset: 0x001EEA60
		// (set) Token: 0x06007B4C RID: 31564 RVA: 0x001F0888 File Offset: 0x001EEA88
		public unsafe bool colorFromLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_colorFromLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_colorFromLight)) = value;
			}
		}

		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x06007B4D RID: 31565 RVA: 0x001F08AC File Offset: 0x001EEAAC
		// (set) Token: 0x06007B4E RID: 31566 RVA: 0x001F08D4 File Offset: 0x001EEAD4
		public unsafe ColorMode colorMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_colorMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_colorMode)) = value;
			}
		}

		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x06007B4F RID: 31567 RVA: 0x001F08F8 File Offset: 0x001EEAF8
		// (set) Token: 0x06007B50 RID: 31568 RVA: 0x001F0920 File Offset: 0x001EEB20
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x06007B51 RID: 31569 RVA: 0x001F0944 File Offset: 0x001EEB44
		// (set) Token: 0x06007B52 RID: 31570 RVA: 0x001F0978 File Offset: 0x001EEB78
		public unsafe Gradient colorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_colorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Gradient(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_colorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x06007B53 RID: 31571 RVA: 0x001F09A0 File Offset: 0x001EEBA0
		// (set) Token: 0x06007B54 RID: 31572 RVA: 0x001F09C8 File Offset: 0x001EEBC8
		public unsafe bool intensityFromLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_intensityFromLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_intensityFromLight)) = value;
			}
		}

		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x06007B55 RID: 31573 RVA: 0x001F09EC File Offset: 0x001EEBEC
		// (set) Token: 0x06007B56 RID: 31574 RVA: 0x001F0A14 File Offset: 0x001EEC14
		public unsafe bool intensityModeAdvanced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_intensityModeAdvanced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_intensityModeAdvanced)) = value;
			}
		}

		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x06007B57 RID: 31575 RVA: 0x001F0A38 File Offset: 0x001EEC38
		// (set) Token: 0x06007B58 RID: 31576 RVA: 0x001F0A60 File Offset: 0x001EEC60
		public unsafe float intensityInside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_intensityInside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_intensityInside)) = value;
			}
		}

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x06007B59 RID: 31577 RVA: 0x001F0A84 File Offset: 0x001EEC84
		// (set) Token: 0x06007B5A RID: 31578 RVA: 0x001F0AAC File Offset: 0x001EECAC
		public unsafe float intensityOutside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_intensityOutside);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_intensityOutside)) = value;
			}
		}

		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x06007B5B RID: 31579 RVA: 0x001F0AD0 File Offset: 0x001EECD0
		// (set) Token: 0x06007B5C RID: 31580 RVA: 0x001F0AF8 File Offset: 0x001EECF8
		public unsafe BlendingMode blendingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_blendingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_blendingMode)) = value;
			}
		}

		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x06007B5D RID: 31581 RVA: 0x001F0B1C File Offset: 0x001EED1C
		// (set) Token: 0x06007B5E RID: 31582 RVA: 0x001F0B44 File Offset: 0x001EED44
		public unsafe bool spotAngleFromLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_spotAngleFromLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_spotAngleFromLight)) = value;
			}
		}

		// Token: 0x17002C17 RID: 11287
		// (get) Token: 0x06007B5F RID: 31583 RVA: 0x001F0B68 File Offset: 0x001EED68
		// (set) Token: 0x06007B60 RID: 31584 RVA: 0x001F0B90 File Offset: 0x001EED90
		public unsafe float spotAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_spotAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_spotAngle)) = value;
			}
		}

		// Token: 0x17002C18 RID: 11288
		// (get) Token: 0x06007B61 RID: 31585 RVA: 0x001F0BB4 File Offset: 0x001EEDB4
		// (set) Token: 0x06007B62 RID: 31586 RVA: 0x001F0BDC File Offset: 0x001EEDDC
		public unsafe float coneRadiusStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_coneRadiusStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_coneRadiusStart)) = value;
			}
		}

		// Token: 0x17002C19 RID: 11289
		// (get) Token: 0x06007B63 RID: 31587 RVA: 0x001F0C00 File Offset: 0x001EEE00
		// (set) Token: 0x06007B64 RID: 31588 RVA: 0x001F0C28 File Offset: 0x001EEE28
		public unsafe MeshType geomMeshType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_geomMeshType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_geomMeshType)) = value;
			}
		}

		// Token: 0x17002C1A RID: 11290
		// (get) Token: 0x06007B65 RID: 31589 RVA: 0x001F0C4C File Offset: 0x001EEE4C
		// (set) Token: 0x06007B66 RID: 31590 RVA: 0x001F0C74 File Offset: 0x001EEE74
		public unsafe int geomCustomSides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_geomCustomSides);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_geomCustomSides)) = value;
			}
		}

		// Token: 0x17002C1B RID: 11291
		// (get) Token: 0x06007B67 RID: 31591 RVA: 0x001F0C98 File Offset: 0x001EEE98
		// (set) Token: 0x06007B68 RID: 31592 RVA: 0x001F0CC0 File Offset: 0x001EEEC0
		public unsafe int geomCustomSegments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_geomCustomSegments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_geomCustomSegments)) = value;
			}
		}

		// Token: 0x17002C1C RID: 11292
		// (get) Token: 0x06007B69 RID: 31593 RVA: 0x001F0CE4 File Offset: 0x001EEEE4
		// (set) Token: 0x06007B6A RID: 31594 RVA: 0x001F0D0C File Offset: 0x001EEF0C
		public unsafe bool geomCap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_geomCap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_geomCap)) = value;
			}
		}

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x06007B6B RID: 31595 RVA: 0x001F0D30 File Offset: 0x001EEF30
		// (set) Token: 0x06007B6C RID: 31596 RVA: 0x001F0D58 File Offset: 0x001EEF58
		public unsafe bool fallOffEndFromLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_fallOffEndFromLight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_fallOffEndFromLight)) = value;
			}
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x06007B6D RID: 31597 RVA: 0x001F0D7C File Offset: 0x001EEF7C
		// (set) Token: 0x06007B6E RID: 31598 RVA: 0x001F0DA4 File Offset: 0x001EEFA4
		public unsafe AttenuationEquation attenuationEquation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_attenuationEquation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_attenuationEquation)) = value;
			}
		}

		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x06007B6F RID: 31599 RVA: 0x001F0DC8 File Offset: 0x001EEFC8
		// (set) Token: 0x06007B70 RID: 31600 RVA: 0x001F0DF0 File Offset: 0x001EEFF0
		public unsafe float attenuationCustomBlending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_attenuationCustomBlending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_attenuationCustomBlending)) = value;
			}
		}

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x06007B71 RID: 31601 RVA: 0x001F0E14 File Offset: 0x001EF014
		// (set) Token: 0x06007B72 RID: 31602 RVA: 0x001F0E3C File Offset: 0x001EF03C
		public unsafe float fallOffStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_fallOffStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_fallOffStart)) = value;
			}
		}

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x06007B73 RID: 31603 RVA: 0x001F0E60 File Offset: 0x001EF060
		// (set) Token: 0x06007B74 RID: 31604 RVA: 0x001F0E88 File Offset: 0x001EF088
		public unsafe float fallOffEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_fallOffEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_fallOffEnd)) = value;
			}
		}

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x06007B75 RID: 31605 RVA: 0x001F0EAC File Offset: 0x001EF0AC
		// (set) Token: 0x06007B76 RID: 31606 RVA: 0x001F0ED4 File Offset: 0x001EF0D4
		public unsafe float depthBlendDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_depthBlendDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_depthBlendDistance)) = value;
			}
		}

		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x06007B77 RID: 31607 RVA: 0x001F0EF8 File Offset: 0x001EF0F8
		// (set) Token: 0x06007B78 RID: 31608 RVA: 0x001F0F20 File Offset: 0x001EF120
		public unsafe float cameraClippingDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_cameraClippingDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_cameraClippingDistance)) = value;
			}
		}

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x06007B79 RID: 31609 RVA: 0x001F0F44 File Offset: 0x001EF144
		// (set) Token: 0x06007B7A RID: 31610 RVA: 0x001F0F6C File Offset: 0x001EF16C
		public unsafe float glareFrontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_glareFrontal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_glareFrontal)) = value;
			}
		}

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x06007B7B RID: 31611 RVA: 0x001F0F90 File Offset: 0x001EF190
		// (set) Token: 0x06007B7C RID: 31612 RVA: 0x001F0FB8 File Offset: 0x001EF1B8
		public unsafe float glareBehind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_glareBehind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_glareBehind)) = value;
			}
		}

		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x06007B7D RID: 31613 RVA: 0x001F0FDC File Offset: 0x001EF1DC
		// (set) Token: 0x06007B7E RID: 31614 RVA: 0x001F1004 File Offset: 0x001EF204
		public unsafe float fresnelPow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_fresnelPow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_fresnelPow)) = value;
			}
		}

		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x06007B7F RID: 31615 RVA: 0x001F1028 File Offset: 0x001EF228
		// (set) Token: 0x06007B80 RID: 31616 RVA: 0x001F1050 File Offset: 0x001EF250
		public unsafe NoiseMode noiseMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_noiseMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_noiseMode)) = value;
			}
		}

		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x06007B81 RID: 31617 RVA: 0x001F1074 File Offset: 0x001EF274
		// (set) Token: 0x06007B82 RID: 31618 RVA: 0x001F109C File Offset: 0x001EF29C
		public unsafe bool _DEPRECATED_NoiseEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__DEPRECATED_NoiseEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__DEPRECATED_NoiseEnabled)) = value;
			}
		}

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x06007B83 RID: 31619 RVA: 0x001F10C0 File Offset: 0x001EF2C0
		// (set) Token: 0x06007B84 RID: 31620 RVA: 0x001F10E8 File Offset: 0x001EF2E8
		public unsafe float noiseIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_noiseIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_noiseIntensity)) = value;
			}
		}

		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x06007B85 RID: 31621 RVA: 0x001F110C File Offset: 0x001EF30C
		// (set) Token: 0x06007B86 RID: 31622 RVA: 0x001F1134 File Offset: 0x001EF334
		public unsafe bool noiseScaleUseGlobal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_noiseScaleUseGlobal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_noiseScaleUseGlobal)) = value;
			}
		}

		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x06007B87 RID: 31623 RVA: 0x001F1158 File Offset: 0x001EF358
		// (set) Token: 0x06007B88 RID: 31624 RVA: 0x001F1180 File Offset: 0x001EF380
		public unsafe float noiseScaleLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_noiseScaleLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_noiseScaleLocal)) = value;
			}
		}

		// Token: 0x17002C2C RID: 11308
		// (get) Token: 0x06007B89 RID: 31625 RVA: 0x001F11A4 File Offset: 0x001EF3A4
		// (set) Token: 0x06007B8A RID: 31626 RVA: 0x001F11CC File Offset: 0x001EF3CC
		public unsafe bool noiseVelocityUseGlobal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_noiseVelocityUseGlobal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_noiseVelocityUseGlobal)) = value;
			}
		}

		// Token: 0x17002C2D RID: 11309
		// (get) Token: 0x06007B8B RID: 31627 RVA: 0x001F11F0 File Offset: 0x001EF3F0
		// (set) Token: 0x06007B8C RID: 31628 RVA: 0x001F1218 File Offset: 0x001EF418
		public unsafe Vector3 noiseVelocityLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_noiseVelocityLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_noiseVelocityLocal)) = value;
			}
		}

		// Token: 0x17002C2E RID: 11310
		// (get) Token: 0x06007B8D RID: 31629 RVA: 0x001F123C File Offset: 0x001EF43C
		// (set) Token: 0x06007B8E RID: 31630 RVA: 0x001F1264 File Offset: 0x001EF464
		public unsafe MaterialManager.DynamicOcclusion __INTERNAL_DynamicOcclusionMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr___INTERNAL_DynamicOcclusionMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr___INTERNAL_DynamicOcclusionMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C2F RID: 11311
		// (get) Token: 0x06007B8F RID: 31631 RVA: 0x001F1288 File Offset: 0x001EF488
		// (set) Token: 0x06007B90 RID: 31632 RVA: 0x001F12B0 File Offset: 0x001EF4B0
		public unsafe bool m_IsDynamicOcclusionEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_m_IsDynamicOcclusionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_m_IsDynamicOcclusionEnabled)) = value;
			}
		}

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x06007B91 RID: 31633 RVA: 0x001F12D4 File Offset: 0x001EF4D4
		// (set) Token: 0x06007B92 RID: 31634 RVA: 0x001F1308 File Offset: 0x001EF508
		public unsafe VolumetricLightBeam.OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_onWillCameraRenderThisBeam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new VolumetricLightBeam.OnWillCameraRenderCB(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_onWillCameraRenderThisBeam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x06007B93 RID: 31635 RVA: 0x001F1330 File Offset: 0x001EF530
		// (set) Token: 0x06007B94 RID: 31636 RVA: 0x001F1364 File Offset: 0x001EF564
		public unsafe VolumetricLightBeam.OnBeamGeometryInitialized m_OnBeamGeometryInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_m_OnBeamGeometryInitialized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new VolumetricLightBeam.OnBeamGeometryInitialized(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_m_OnBeamGeometryInitialized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x06007B95 RID: 31637 RVA: 0x001F138C File Offset: 0x001EF58C
		// (set) Token: 0x06007B96 RID: 31638 RVA: 0x001F13B4 File Offset: 0x001EF5B4
		public unsafe int pluginVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_pluginVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_pluginVersion)) = value;
			}
		}

		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x06007B97 RID: 31639 RVA: 0x001F13D8 File Offset: 0x001EF5D8
		// (set) Token: 0x06007B98 RID: 31640 RVA: 0x001F1400 File Offset: 0x001EF600
		public unsafe bool _TrackChangesDuringPlaytime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__TrackChangesDuringPlaytime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__TrackChangesDuringPlaytime)) = value;
			}
		}

		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x06007B99 RID: 31641 RVA: 0x001F1424 File Offset: 0x001EF624
		// (set) Token: 0x06007B9A RID: 31642 RVA: 0x001F144C File Offset: 0x001EF64C
		public unsafe int _SortingLayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__SortingLayerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__SortingLayerID)) = value;
			}
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x06007B9B RID: 31643 RVA: 0x001F1470 File Offset: 0x001EF670
		// (set) Token: 0x06007B9C RID: 31644 RVA: 0x001F1498 File Offset: 0x001EF698
		public unsafe int _SortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__SortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__SortingOrder)) = value;
			}
		}

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x06007B9D RID: 31645 RVA: 0x001F14BC File Offset: 0x001EF6BC
		// (set) Token: 0x06007B9E RID: 31646 RVA: 0x001F14E4 File Offset: 0x001EF6E4
		public unsafe float _FadeOutBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__FadeOutBegin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__FadeOutBegin)) = value;
			}
		}

		// Token: 0x17002C37 RID: 11319
		// (get) Token: 0x06007B9F RID: 31647 RVA: 0x001F1508 File Offset: 0x001EF708
		// (set) Token: 0x06007BA0 RID: 31648 RVA: 0x001F1530 File Offset: 0x001EF730
		public unsafe float _FadeOutEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__FadeOutEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__FadeOutEnd)) = value;
			}
		}

		// Token: 0x17002C38 RID: 11320
		// (get) Token: 0x06007BA1 RID: 31649 RVA: 0x001F1554 File Offset: 0x001EF754
		// (set) Token: 0x06007BA2 RID: 31650 RVA: 0x001F157C File Offset: 0x001EF77C
		public unsafe uint __INTERNAL_InstancedMaterialGroupID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C39 RID: 11321
		// (get) Token: 0x06007BA3 RID: 31651 RVA: 0x001F15A0 File Offset: 0x001EF7A0
		// (set) Token: 0x06007BA4 RID: 31652 RVA: 0x001F15D4 File Offset: 0x001EF7D4
		public unsafe BeamGeometry m_BeamGeom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_m_BeamGeom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new BeamGeometry(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_m_BeamGeom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C3A RID: 11322
		// (get) Token: 0x06007BA5 RID: 31653 RVA: 0x001F15FC File Offset: 0x001EF7FC
		// (set) Token: 0x06007BA6 RID: 31654 RVA: 0x001F1630 File Offset: 0x001EF830
		public unsafe Coroutine m_CoPlaytimeUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_m_CoPlaytimeUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Coroutine(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr_m_CoPlaytimeUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C3B RID: 11323
		// (get) Token: 0x06007BA7 RID: 31655 RVA: 0x001F1658 File Offset: 0x001EF858
		// (set) Token: 0x06007BA8 RID: 31656 RVA: 0x001F168C File Offset: 0x001EF88C
		public unsafe Light _CachedLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__CachedLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? new Light(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam.NativeFieldInfoPtr__CachedLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004EC6 RID: 20166
		private static readonly IntPtr NativeFieldInfoPtr_colorFromLight;

		// Token: 0x04004EC7 RID: 20167
		private static readonly IntPtr NativeFieldInfoPtr_colorMode;

		// Token: 0x04004EC8 RID: 20168
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04004EC9 RID: 20169
		private static readonly IntPtr NativeFieldInfoPtr_colorGradient;

		// Token: 0x04004ECA RID: 20170
		private static readonly IntPtr NativeFieldInfoPtr_intensityFromLight;

		// Token: 0x04004ECB RID: 20171
		private static readonly IntPtr NativeFieldInfoPtr_intensityModeAdvanced;

		// Token: 0x04004ECC RID: 20172
		private static readonly IntPtr NativeFieldInfoPtr_intensityInside;

		// Token: 0x04004ECD RID: 20173
		private static readonly IntPtr NativeFieldInfoPtr_intensityOutside;

		// Token: 0x04004ECE RID: 20174
		private static readonly IntPtr NativeFieldInfoPtr_blendingMode;

		// Token: 0x04004ECF RID: 20175
		private static readonly IntPtr NativeFieldInfoPtr_spotAngleFromLight;

		// Token: 0x04004ED0 RID: 20176
		private static readonly IntPtr NativeFieldInfoPtr_spotAngle;

		// Token: 0x04004ED1 RID: 20177
		private static readonly IntPtr NativeFieldInfoPtr_coneRadiusStart;

		// Token: 0x04004ED2 RID: 20178
		private static readonly IntPtr NativeFieldInfoPtr_geomMeshType;

		// Token: 0x04004ED3 RID: 20179
		private static readonly IntPtr NativeFieldInfoPtr_geomCustomSides;

		// Token: 0x04004ED4 RID: 20180
		private static readonly IntPtr NativeFieldInfoPtr_geomCustomSegments;

		// Token: 0x04004ED5 RID: 20181
		private static readonly IntPtr NativeFieldInfoPtr_geomCap;

		// Token: 0x04004ED6 RID: 20182
		private static readonly IntPtr NativeFieldInfoPtr_fallOffEndFromLight;

		// Token: 0x04004ED7 RID: 20183
		private static readonly IntPtr NativeFieldInfoPtr_attenuationEquation;

		// Token: 0x04004ED8 RID: 20184
		private static readonly IntPtr NativeFieldInfoPtr_attenuationCustomBlending;

		// Token: 0x04004ED9 RID: 20185
		private static readonly IntPtr NativeFieldInfoPtr_fallOffStart;

		// Token: 0x04004EDA RID: 20186
		private static readonly IntPtr NativeFieldInfoPtr_fallOffEnd;

		// Token: 0x04004EDB RID: 20187
		private static readonly IntPtr NativeFieldInfoPtr_depthBlendDistance;

		// Token: 0x04004EDC RID: 20188
		private static readonly IntPtr NativeFieldInfoPtr_cameraClippingDistance;

		// Token: 0x04004EDD RID: 20189
		private static readonly IntPtr NativeFieldInfoPtr_glareFrontal;

		// Token: 0x04004EDE RID: 20190
		private static readonly IntPtr NativeFieldInfoPtr_glareBehind;

		// Token: 0x04004EDF RID: 20191
		private static readonly IntPtr NativeFieldInfoPtr_fresnelPow;

		// Token: 0x04004EE0 RID: 20192
		private static readonly IntPtr NativeFieldInfoPtr_noiseMode;

		// Token: 0x04004EE1 RID: 20193
		private static readonly IntPtr NativeFieldInfoPtr__DEPRECATED_NoiseEnabled;

		// Token: 0x04004EE2 RID: 20194
		private static readonly IntPtr NativeFieldInfoPtr_noiseIntensity;

		// Token: 0x04004EE3 RID: 20195
		private static readonly IntPtr NativeFieldInfoPtr_noiseScaleUseGlobal;

		// Token: 0x04004EE4 RID: 20196
		private static readonly IntPtr NativeFieldInfoPtr_noiseScaleLocal;

		// Token: 0x04004EE5 RID: 20197
		private static readonly IntPtr NativeFieldInfoPtr_noiseVelocityUseGlobal;

		// Token: 0x04004EE6 RID: 20198
		private static readonly IntPtr NativeFieldInfoPtr_noiseVelocityLocal;

		// Token: 0x04004EE7 RID: 20199
		private static readonly IntPtr NativeFieldInfoPtr___INTERNAL_DynamicOcclusionMode_k__BackingField;

		// Token: 0x04004EE8 RID: 20200
		private static readonly IntPtr NativeFieldInfoPtr_m_IsDynamicOcclusionEnabled;

		// Token: 0x04004EE9 RID: 20201
		private static readonly IntPtr NativeFieldInfoPtr_onWillCameraRenderThisBeam;

		// Token: 0x04004EEA RID: 20202
		private static readonly IntPtr NativeFieldInfoPtr_m_OnBeamGeometryInitialized;

		// Token: 0x04004EEB RID: 20203
		private static readonly IntPtr NativeFieldInfoPtr_pluginVersion;

		// Token: 0x04004EEC RID: 20204
		private static readonly IntPtr NativeFieldInfoPtr__TrackChangesDuringPlaytime;

		// Token: 0x04004EED RID: 20205
		private static readonly IntPtr NativeFieldInfoPtr__SortingLayerID;

		// Token: 0x04004EEE RID: 20206
		private static readonly IntPtr NativeFieldInfoPtr__SortingOrder;

		// Token: 0x04004EEF RID: 20207
		private static readonly IntPtr NativeFieldInfoPtr__FadeOutBegin;

		// Token: 0x04004EF0 RID: 20208
		private static readonly IntPtr NativeFieldInfoPtr__FadeOutEnd;

		// Token: 0x04004EF1 RID: 20209
		private static readonly IntPtr NativeFieldInfoPtr___INTERNAL_InstancedMaterialGroupID_k__BackingField;

		// Token: 0x04004EF2 RID: 20210
		private static readonly IntPtr NativeFieldInfoPtr_m_BeamGeom;

		// Token: 0x04004EF3 RID: 20211
		private static readonly IntPtr NativeFieldInfoPtr_m_CoPlaytimeUpdate;

		// Token: 0x04004EF4 RID: 20212
		private static readonly IntPtr NativeFieldInfoPtr__CachedLight;

		// Token: 0x04004EF5 RID: 20213
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaInside_Public_get_Single_0;

		// Token: 0x04004EF6 RID: 20214
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaInside_Public_set_Void_Single_0;

		// Token: 0x04004EF7 RID: 20215
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaOutside_Public_get_Single_0;

		// Token: 0x04004EF8 RID: 20216
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaOutside_Public_set_Void_Single_0;

		// Token: 0x04004EF9 RID: 20217
		private static readonly IntPtr NativeMethodInfoPtr_get_intensityGlobal_Public_get_Single_0;

		// Token: 0x04004EFA RID: 20218
		private static readonly IntPtr NativeMethodInfoPtr_set_intensityGlobal_Public_set_Void_Single_0;

		// Token: 0x04004EFB RID: 20219
		private static readonly IntPtr NativeMethodInfoPtr_get_coneAngle_Public_get_Single_0;

		// Token: 0x04004EFC RID: 20220
		private static readonly IntPtr NativeMethodInfoPtr_get_coneRadiusEnd_Public_get_Single_0;

		// Token: 0x04004EFD RID: 20221
		private static readonly IntPtr NativeMethodInfoPtr_get_coneVolume_Public_get_Single_0;

		// Token: 0x04004EFE RID: 20222
		private static readonly IntPtr NativeMethodInfoPtr_get_coneApexOffsetZ_Public_get_Single_0;

		// Token: 0x04004EFF RID: 20223
		private static readonly IntPtr NativeMethodInfoPtr_get_geomSides_Public_get_Int32_0;

		// Token: 0x04004F00 RID: 20224
		private static readonly IntPtr NativeMethodInfoPtr_set_geomSides_Public_set_Void_Int32_0;

		// Token: 0x04004F01 RID: 20225
		private static readonly IntPtr NativeMethodInfoPtr_get_geomSegments_Public_get_Int32_0;

		// Token: 0x04004F02 RID: 20226
		private static readonly IntPtr NativeMethodInfoPtr_set_geomSegments_Public_set_Void_Int32_0;

		// Token: 0x04004F03 RID: 20227
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeEndFromLight_Public_get_Boolean_0;

		// Token: 0x04004F04 RID: 20228
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeEndFromLight_Public_set_Void_Boolean_0;

		// Token: 0x04004F05 RID: 20229
		private static readonly IntPtr NativeMethodInfoPtr_get_attenuationLerpLinearQuad_Public_get_Single_0;

		// Token: 0x04004F06 RID: 20230
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeStart_Public_get_Single_0;

		// Token: 0x04004F07 RID: 20231
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeStart_Public_set_Void_Single_0;

		// Token: 0x04004F08 RID: 20232
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeEnd_Public_get_Single_0;

		// Token: 0x04004F09 RID: 20233
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeEnd_Public_set_Void_Single_0;

		// Token: 0x04004F0A RID: 20234
		private static readonly IntPtr NativeMethodInfoPtr_get_isNoiseEnabled_Public_get_Boolean_0;

		// Token: 0x04004F0B RID: 20235
		private static readonly IntPtr NativeMethodInfoPtr_get_noiseEnabled_Public_get_Boolean_0;

		// Token: 0x04004F0C RID: 20236
		private static readonly IntPtr NativeMethodInfoPtr_set_noiseEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04004F0D RID: 20237
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeOutBegin_Public_get_Single_0;

		// Token: 0x04004F0E RID: 20238
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeOutBegin_Public_set_Void_Single_0;

		// Token: 0x04004F0F RID: 20239
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeOutEnd_Public_get_Single_0;

		// Token: 0x04004F10 RID: 20240
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeOutEnd_Public_set_Void_Single_0;

		// Token: 0x04004F11 RID: 20241
		private static readonly IntPtr NativeMethodInfoPtr_get_isFadeOutEnabled_Public_get_Boolean_0;

		// Token: 0x04004F12 RID: 20242
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x04004F13 RID: 20243
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x04004F14 RID: 20244
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0;

		// Token: 0x04004F15 RID: 20245
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0;

		// Token: 0x04004F16 RID: 20246
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x04004F17 RID: 20247
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x04004F18 RID: 20248
		private static readonly IntPtr NativeMethodInfoPtr_get_trackChangesDuringPlaytime_Public_get_Boolean_0;

		// Token: 0x04004F19 RID: 20249
		private static readonly IntPtr NativeMethodInfoPtr_set_trackChangesDuringPlaytime_Public_set_Void_Boolean_0;

		// Token: 0x04004F1A RID: 20250
		private static readonly IntPtr NativeMethodInfoPtr_get_isCurrentlyTrackingChanges_Public_get_Boolean_0;

		// Token: 0x04004F1B RID: 20251
		private static readonly IntPtr NativeMethodInfoPtr_get_hasGeometry_Public_get_Boolean_0;

		// Token: 0x04004F1C RID: 20252
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04004F1D RID: 20253
		private static readonly IntPtr NativeMethodInfoPtr_get_blendingModeAsInt_Public_get_Int32_0;

		// Token: 0x04004F1E RID: 20254
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_DynamicOcclusionMode_Public_get_DynamicOcclusion_0;

		// Token: 0x04004F1F RID: 20255
		private static readonly IntPtr NativeMethodInfoPtr_set__INTERNAL_DynamicOcclusionMode_Public_set_Void_DynamicOcclusion_0;

		// Token: 0x04004F20 RID: 20256
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_EnabledDynamicOcclusionMode_Public_get_DynamicOcclusion_0;

		// Token: 0x04004F21 RID: 20257
		private static readonly IntPtr NativeMethodInfoPtr__INTERNAL_SetDynamicOcclusionCallback_Public_Void_String_Callback_0;

		// Token: 0x04004F22 RID: 20258
		private static readonly IntPtr NativeMethodInfoPtr_add_onWillCameraRenderThisBeam_Public_add_Void_OnWillCameraRenderCB_0;

		// Token: 0x04004F23 RID: 20259
		private static readonly IntPtr NativeMethodInfoPtr_remove_onWillCameraRenderThisBeam_Public_rem_Void_OnWillCameraRenderCB_0;

		// Token: 0x04004F24 RID: 20260
		private static readonly IntPtr NativeMethodInfoPtr__INTERNAL_OnWillCameraRenderThisBeam_Public_Void_Camera_0;

		// Token: 0x04004F25 RID: 20261
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnBeamGeometryInitializedCallback_Public_Void_OnBeamGeometryInitialized_0;

		// Token: 0x04004F26 RID: 20262
		private static readonly IntPtr NativeMethodInfoPtr_CallOnBeamGeometryInitializedCallback_Private_Void_0;

		// Token: 0x04004F27 RID: 20263
		private static readonly IntPtr NativeMethodInfoPtr_SetFadeOutValue_Private_Void_byref_Single_Single_0;

		// Token: 0x04004F28 RID: 20264
		private static readonly IntPtr NativeMethodInfoPtr_OnFadeOutStateChanged_Private_Void_0;

		// Token: 0x04004F29 RID: 20265
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_InstancedMaterialGroupID_Public_get_UInt32_0;

		// Token: 0x04004F2A RID: 20266
		private static readonly IntPtr NativeMethodInfoPtr_set__INTERNAL_InstancedMaterialGroupID_Protected_set_Void_UInt32_0;

		// Token: 0x04004F2B RID: 20267
		private static readonly IntPtr NativeMethodInfoPtr_get_meshStats_Public_get_String_0;

		// Token: 0x04004F2C RID: 20268
		private static readonly IntPtr NativeMethodInfoPtr_get_meshVerticesCount_Public_get_Int32_0;

		// Token: 0x04004F2D RID: 20269
		private static readonly IntPtr NativeMethodInfoPtr_get_meshTrianglesCount_Public_get_Int32_0;

		// Token: 0x04004F2E RID: 20270
		private static readonly IntPtr NativeMethodInfoPtr_get_lightSpotAttached_Private_get_Light_0;

		// Token: 0x04004F2F RID: 20271
		private static readonly IntPtr NativeMethodInfoPtr_GetInsideBeamFactor_Public_Single_Vector3_0;

		// Token: 0x04004F30 RID: 20272
		private static readonly IntPtr NativeMethodInfoPtr_GetInsideBeamFactorFromObjectSpacePos_Public_Single_Vector3_0;

		// Token: 0x04004F31 RID: 20273
		private static readonly IntPtr NativeMethodInfoPtr_Generate_Public_Void_0;

		// Token: 0x04004F32 RID: 20274
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGeometry_Public_Virtual_New_Void_0;

		// Token: 0x04004F33 RID: 20275
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAfterManualPropertyChange_Public_Virtual_New_Void_0;

		// Token: 0x04004F34 RID: 20276
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004F35 RID: 20277
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04004F36 RID: 20278
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04004F37 RID: 20279
		private static readonly IntPtr NativeMethodInfoPtr_StartPlaytimeUpdateIfNeeded_Private_Void_0;

		// Token: 0x04004F38 RID: 20280
		private static readonly IntPtr NativeMethodInfoPtr_CoPlaytimeUpdate_Private_IEnumerator_0;

		// Token: 0x04004F39 RID: 20281
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004F3A RID: 20282
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBeam_Private_Void_0;

		// Token: 0x04004F3B RID: 20283
		private static readonly IntPtr NativeMethodInfoPtr_AssignPropertiesFromSpotLight_Private_Void_Light_0;

		// Token: 0x04004F3C RID: 20284
		private static readonly IntPtr NativeMethodInfoPtr_ClampProperties_Private_Void_0;

		// Token: 0x04004F3D RID: 20285
		private static readonly IntPtr NativeMethodInfoPtr_ValidateProperties_Private_Void_0;

		// Token: 0x04004F3E RID: 20286
		private static readonly IntPtr NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0;

		// Token: 0x04004F3F RID: 20287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005F4 RID: 1524
		public sealed class OnWillCameraRenderCB : MulticastDelegate
		{
			// Token: 0x06007BA9 RID: 31657 RVA: 0x001F16B4 File Offset: 0x001EF8B4
			[CallerCount(0)]
			public unsafe OnWillCameraRenderCB(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeam.OnWillCameraRenderCB>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.OnWillCameraRenderCB.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007BAA RID: 31658 RVA: 0x001F172C File Offset: 0x001EF92C
			[CallerCount(0)]
			public unsafe void Invoke(Camera cam)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.OnWillCameraRenderCB.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007BAB RID: 31659 RVA: 0x001F1788 File Offset: 0x001EF988
			[CallerCount(0)]
			public unsafe IAsyncResult BeginInvoke(Camera cam, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.OnWillCameraRenderCB.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
			}

			// Token: 0x06007BAC RID: 31660 RVA: 0x001F1828 File Offset: 0x001EFA28
			[CallerCount(0)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.OnWillCameraRenderCB.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007BAD RID: 31661 RVA: 0x001F1884 File Offset: 0x001EFA84
			// Note: this type is marked as 'beforefieldinit'.
			static OnWillCameraRenderCB()
			{
				Il2CppClassPointerStore<VolumetricLightBeam.OnWillCameraRenderCB>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "OnWillCameraRenderCB");
				VolumetricLightBeam.OnWillCameraRenderCB.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam.OnWillCameraRenderCB>.NativeClassPtr, 100673179);
				VolumetricLightBeam.OnWillCameraRenderCB.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam.OnWillCameraRenderCB>.NativeClassPtr, 100673180);
				VolumetricLightBeam.OnWillCameraRenderCB.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam.OnWillCameraRenderCB>.NativeClassPtr, 100673181);
				VolumetricLightBeam.OnWillCameraRenderCB.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam.OnWillCameraRenderCB>.NativeClassPtr, 100673182);
			}

			// Token: 0x06007BAE RID: 31662 RVA: 0x00005E35 File Offset: 0x00004035
			public OnWillCameraRenderCB(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002C5D RID: 11357
			// (get) Token: 0x06007BAF RID: 31663 RVA: 0x001F18F5 File Offset: 0x001EFAF5
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VolumetricLightBeam.OnWillCameraRenderCB>.NativeClassPtr));
				}
			}

			// Token: 0x06007BB0 RID: 31664 RVA: 0x001F1906 File Offset: 0x001EFB06
			public static implicit operator VolumetricLightBeam.OnWillCameraRenderCB(Action<Camera> A_0)
			{
				return DelegateSupport.ConvertDelegate<VolumetricLightBeam.OnWillCameraRenderCB>(A_0);
			}

			// Token: 0x06007BB1 RID: 31665 RVA: 0x001F190E File Offset: 0x001EFB0E
			public static VolumetricLightBeam.OnWillCameraRenderCB operator +(VolumetricLightBeam.OnWillCameraRenderCB A_0, VolumetricLightBeam.OnWillCameraRenderCB A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VolumetricLightBeam.OnWillCameraRenderCB>();
			}

			// Token: 0x06007BB2 RID: 31666 RVA: 0x001F191C File Offset: 0x001EFB1C
			public static VolumetricLightBeam.OnWillCameraRenderCB operator -(VolumetricLightBeam.OnWillCameraRenderCB A_0, VolumetricLightBeam.OnWillCameraRenderCB A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VolumetricLightBeam.OnWillCameraRenderCB>();
				}
				return result;
			}

			// Token: 0x04004F40 RID: 20288
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004F41 RID: 20289
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Camera_0;

			// Token: 0x04004F42 RID: 20290
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Camera_AsyncCallback_Object_0;

			// Token: 0x04004F43 RID: 20291
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020005F5 RID: 1525
		public sealed class OnBeamGeometryInitialized : MulticastDelegate
		{
			// Token: 0x06007BB3 RID: 31667 RVA: 0x001F1930 File Offset: 0x001EFB30
			[CallerCount(0)]
			public unsafe OnBeamGeometryInitialized(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeam.OnBeamGeometryInitialized>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.OnBeamGeometryInitialized.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007BB4 RID: 31668 RVA: 0x001F19A8 File Offset: 0x001EFBA8
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.OnBeamGeometryInitialized.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007BB5 RID: 31669 RVA: 0x001F19EC File Offset: 0x001EFBEC
			[CallerCount(0)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.OnBeamGeometryInitialized.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new IAsyncResult(intPtr2) : null;
			}

			// Token: 0x06007BB6 RID: 31670 RVA: 0x001F1A74 File Offset: 0x001EFC74
			[CallerCount(0)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam.OnBeamGeometryInitialized.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007BB7 RID: 31671 RVA: 0x001F1AD0 File Offset: 0x001EFCD0
			// Note: this type is marked as 'beforefieldinit'.
			static OnBeamGeometryInitialized()
			{
				Il2CppClassPointerStore<VolumetricLightBeam.OnBeamGeometryInitialized>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "OnBeamGeometryInitialized");
				VolumetricLightBeam.OnBeamGeometryInitialized.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam.OnBeamGeometryInitialized>.NativeClassPtr, 100673183);
				VolumetricLightBeam.OnBeamGeometryInitialized.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam.OnBeamGeometryInitialized>.NativeClassPtr, 100673184);
				VolumetricLightBeam.OnBeamGeometryInitialized.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam.OnBeamGeometryInitialized>.NativeClassPtr, 100673185);
				VolumetricLightBeam.OnBeamGeometryInitialized.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam.OnBeamGeometryInitialized>.NativeClassPtr, 100673186);
			}

			// Token: 0x06007BB8 RID: 31672 RVA: 0x00005E35 File Offset: 0x00004035
			public OnBeamGeometryInitialized(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002C5E RID: 11358
			// (get) Token: 0x06007BB9 RID: 31673 RVA: 0x001F1B41 File Offset: 0x001EFD41
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VolumetricLightBeam.OnBeamGeometryInitialized>.NativeClassPtr));
				}
			}

			// Token: 0x06007BBA RID: 31674 RVA: 0x001F1B52 File Offset: 0x001EFD52
			public static implicit operator VolumetricLightBeam.OnBeamGeometryInitialized(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<VolumetricLightBeam.OnBeamGeometryInitialized>(A_0);
			}

			// Token: 0x06007BBB RID: 31675 RVA: 0x001F1B5A File Offset: 0x001EFD5A
			public static VolumetricLightBeam.OnBeamGeometryInitialized operator +(VolumetricLightBeam.OnBeamGeometryInitialized A_0, VolumetricLightBeam.OnBeamGeometryInitialized A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<VolumetricLightBeam.OnBeamGeometryInitialized>();
			}

			// Token: 0x06007BBC RID: 31676 RVA: 0x001F1B68 File Offset: 0x001EFD68
			public static VolumetricLightBeam.OnBeamGeometryInitialized operator -(VolumetricLightBeam.OnBeamGeometryInitialized A_0, VolumetricLightBeam.OnBeamGeometryInitialized A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<VolumetricLightBeam.OnBeamGeometryInitialized>();
				}
				return result;
			}

			// Token: 0x04004F44 RID: 20292
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004F45 RID: 20293
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04004F46 RID: 20294
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04004F47 RID: 20295
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020005F6 RID: 1526
		[ObfuscatedName("VLB.VolumetricLightBeam/<CoPlaytimeUpdate>d__149")]
		public sealed class _CoPlaytimeUpdate_d__149 : Il2CppSystem.Object
		{
			// Token: 0x06007BBD RID: 31677 RVA: 0x001F1B7C File Offset: 0x001EFD7C
			[CallerCount(0)]
			public unsafe _CoPlaytimeUpdate_d__149(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeam._CoPlaytimeUpdate_d__149>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007BBE RID: 31678 RVA: 0x001F1BDC File Offset: 0x001EFDDC
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x06007BBF RID: 31679 RVA: 0x001F1C20 File Offset: 0x001EFE20
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17002C63 RID: 11363
			// (get) Token: 0x06007BC0 RID: 31680 RVA: 0x001F1C70 File Offset: 0x001EFE70
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007BC1 RID: 31681 RVA: 0x001F1CC8 File Offset: 0x001EFEC8
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17002C64 RID: 11364
			// (get) Token: 0x06007BC2 RID: 31682 RVA: 0x001F1D0C File Offset: 0x001EFF0C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* param = null;
					IntPtr returnedException;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppException.RaiseExceptionIfNecessary(returnedException);
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
			}

			// Token: 0x06007BC3 RID: 31683 RVA: 0x001F1D64 File Offset: 0x001EFF64
			// Note: this type is marked as 'beforefieldinit'.
			static _CoPlaytimeUpdate_d__149()
			{
				Il2CppClassPointerStore<VolumetricLightBeam._CoPlaytimeUpdate_d__149>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricLightBeam>.NativeClassPtr, "<CoPlaytimeUpdate>d__149");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightBeam._CoPlaytimeUpdate_d__149>.NativeClassPtr);
				VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam._CoPlaytimeUpdate_d__149>.NativeClassPtr, "<>1__state");
				VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam._CoPlaytimeUpdate_d__149>.NativeClassPtr, "<>2__current");
				VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeam._CoPlaytimeUpdate_d__149>.NativeClassPtr, "<>4__this");
				VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam._CoPlaytimeUpdate_d__149>.NativeClassPtr, 100673187);
				VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam._CoPlaytimeUpdate_d__149>.NativeClassPtr, 100673188);
				VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam._CoPlaytimeUpdate_d__149>.NativeClassPtr, 100673189);
				VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam._CoPlaytimeUpdate_d__149>.NativeClassPtr, 100673190);
				VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam._CoPlaytimeUpdate_d__149>.NativeClassPtr, 100673191);
				VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeam._CoPlaytimeUpdate_d__149>.NativeClassPtr, 100673192);
			}

			// Token: 0x06007BC4 RID: 31684 RVA: 0x00002988 File Offset: 0x00000B88
			public _CoPlaytimeUpdate_d__149(IntPtr A_1) : base(A_1)
			{
			}

			// Token: 0x17002C5F RID: 11359
			// (get) Token: 0x06007BC5 RID: 31685 RVA: 0x001F1E43 File Offset: 0x001F0043
			[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
			public new static Type Il2CppType
			{
				get
				{
					return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VolumetricLightBeam._CoPlaytimeUpdate_d__149>.NativeClassPtr));
				}
			}

			// Token: 0x17002C60 RID: 11360
			// (get) Token: 0x06007BC6 RID: 31686 RVA: 0x001F1E54 File Offset: 0x001F0054
			// (set) Token: 0x06007BC7 RID: 31687 RVA: 0x001F1E7C File Offset: 0x001F007C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002C61 RID: 11361
			// (get) Token: 0x06007BC8 RID: 31688 RVA: 0x001F1EA0 File Offset: 0x001F00A0
			// (set) Token: 0x06007BC9 RID: 31689 RVA: 0x001F1ED4 File Offset: 0x001F00D4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new Il2CppSystem.Object(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002C62 RID: 11362
			// (get) Token: 0x06007BCA RID: 31690 RVA: 0x001F1EFC File Offset: 0x001F00FC
			// (set) Token: 0x06007BCB RID: 31691 RVA: 0x001F1F30 File Offset: 0x001F0130
			public unsafe VolumetricLightBeam __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? new VolumetricLightBeam(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.FieldWriteWbarrierStub(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeam._CoPlaytimeUpdate_d__149.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004F48 RID: 20296
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004F49 RID: 20297
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004F4A RID: 20298
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004F4B RID: 20299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004F4C RID: 20300
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004F4D RID: 20301
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004F4E RID: 20302
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004F4F RID: 20303
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004F50 RID: 20304
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
