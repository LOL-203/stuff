using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005E5 RID: 1509
	public static class Noise3D : Il2CppSystem.Object
	{
		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x06007A2E RID: 31278 RVA: 0x001EBA24 File Offset: 0x001E9C24
		public unsafe static bool isSupported
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x06007A2F RID: 31279 RVA: 0x001EBA68 File Offset: 0x001E9C68
		public unsafe static bool isProperlyLoaded
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_get_isProperlyLoaded_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x06007A30 RID: 31280 RVA: 0x001EBAAC File Offset: 0x001E9CAC
		public unsafe static string isNotSupportedString
		{
			[CallerCount(0)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_get_isNotSupportedString_Public_Static_get_String_0, 0, (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06007A31 RID: 31281 RVA: 0x001EBAE8 File Offset: 0x001E9CE8
		[CallerCount(0)]
		public unsafe static void OnStartUp()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_OnStartUp_Private_Static_Void_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A32 RID: 31282 RVA: 0x001EBB1C File Offset: 0x001E9D1C
		[CallerCount(0)]
		public unsafe static void LoadIfNeeded()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_LoadIfNeeded_Public_Static_Void_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x001EBB50 File Offset: 0x001E9D50
		[CallerCount(0)]
		public unsafe static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(textData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Noise3D.NativeMethodInfoPtr_LoadTexture3D_Private_Static_Texture3D_TextAsset_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Texture3D(intPtr2) : null;
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x001EBBC4 File Offset: 0x001E9DC4
		// Note: this type is marked as 'beforefieldinit'.
		static Noise3D()
		{
			Il2CppClassPointerStore<Noise3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Noise3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Noise3D>.NativeClassPtr);
			Noise3D.NativeFieldInfoPtr_ms_IsSupportedChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "ms_IsSupportedChecked");
			Noise3D.NativeFieldInfoPtr_ms_IsSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "ms_IsSupported");
			Noise3D.NativeFieldInfoPtr_ms_NoiseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "ms_NoiseTexture");
			Noise3D.NativeFieldInfoPtr_kHideFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "kHideFlags");
			Noise3D.NativeFieldInfoPtr_kMinShaderLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, "kMinShaderLevel");
			Noise3D.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100673047);
			Noise3D.NativeMethodInfoPtr_get_isProperlyLoaded_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100673048);
			Noise3D.NativeMethodInfoPtr_get_isNotSupportedString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100673049);
			Noise3D.NativeMethodInfoPtr_OnStartUp_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100673050);
			Noise3D.NativeMethodInfoPtr_LoadIfNeeded_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100673051);
			Noise3D.NativeMethodInfoPtr_LoadTexture3D_Private_Static_Texture3D_TextAsset_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Noise3D>.NativeClassPtr, 100673052);
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x00002988 File Offset: 0x00000B88
		public Noise3D(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x06007A36 RID: 31286 RVA: 0x001EBCD0 File Offset: 0x001E9ED0
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Noise3D>.NativeClassPtr));
			}
		}

		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x06007A37 RID: 31287 RVA: 0x001EBCE4 File Offset: 0x001E9EE4
		// (set) Token: 0x06007A38 RID: 31288 RVA: 0x001EBD02 File Offset: 0x001E9F02
		public unsafe static bool ms_IsSupportedChecked
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_ms_IsSupportedChecked, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_ms_IsSupportedChecked, (void*)(&value));
			}
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x06007A39 RID: 31289 RVA: 0x001EBD14 File Offset: 0x001E9F14
		// (set) Token: 0x06007A3A RID: 31290 RVA: 0x001EBD32 File Offset: 0x001E9F32
		public unsafe static bool ms_IsSupported
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_ms_IsSupported, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_ms_IsSupported, (void*)(&value));
			}
		}

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x06007A3B RID: 31291 RVA: 0x001EBD44 File Offset: 0x001E9F44
		// (set) Token: 0x06007A3C RID: 31292 RVA: 0x001EBD6F File Offset: 0x001E9F6F
		public unsafe static Texture3D ms_NoiseTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_ms_NoiseTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Texture3D(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_ms_NoiseTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x06007A3D RID: 31293 RVA: 0x001EBD84 File Offset: 0x001E9F84
		// (set) Token: 0x06007A3E RID: 31294 RVA: 0x001EBDA2 File Offset: 0x001E9FA2
		public unsafe static HideFlags kHideFlags
		{
			get
			{
				HideFlags result;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_kHideFlags, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_kHideFlags, (void*)(&value));
			}
		}

		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x06007A3F RID: 31295 RVA: 0x001EBDB4 File Offset: 0x001E9FB4
		// (set) Token: 0x06007A40 RID: 31296 RVA: 0x001EBDD2 File Offset: 0x001E9FD2
		public unsafe static int kMinShaderLevel
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Noise3D.NativeFieldInfoPtr_kMinShaderLevel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Noise3D.NativeFieldInfoPtr_kMinShaderLevel, (void*)(&value));
			}
		}

		// Token: 0x04004E48 RID: 20040
		private static readonly IntPtr NativeFieldInfoPtr_ms_IsSupportedChecked;

		// Token: 0x04004E49 RID: 20041
		private static readonly IntPtr NativeFieldInfoPtr_ms_IsSupported;

		// Token: 0x04004E4A RID: 20042
		private static readonly IntPtr NativeFieldInfoPtr_ms_NoiseTexture;

		// Token: 0x04004E4B RID: 20043
		private static readonly IntPtr NativeFieldInfoPtr_kHideFlags;

		// Token: 0x04004E4C RID: 20044
		private static readonly IntPtr NativeFieldInfoPtr_kMinShaderLevel;

		// Token: 0x04004E4D RID: 20045
		private static readonly IntPtr NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0;

		// Token: 0x04004E4E RID: 20046
		private static readonly IntPtr NativeMethodInfoPtr_get_isProperlyLoaded_Public_Static_get_Boolean_0;

		// Token: 0x04004E4F RID: 20047
		private static readonly IntPtr NativeMethodInfoPtr_get_isNotSupportedString_Public_Static_get_String_0;

		// Token: 0x04004E50 RID: 20048
		private static readonly IntPtr NativeMethodInfoPtr_OnStartUp_Private_Static_Void_0;

		// Token: 0x04004E51 RID: 20049
		private static readonly IntPtr NativeMethodInfoPtr_LoadIfNeeded_Public_Static_Void_0;

		// Token: 0x04004E52 RID: 20050
		private static readonly IntPtr NativeMethodInfoPtr_LoadTexture3D_Private_Static_Texture3D_TextAsset_Int32_0;
	}
}
