using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace VLB
{
	// Token: 0x020005D8 RID: 1496
	public static class GlobalMesh : Il2CppSystem.Object
	{
		// Token: 0x060079D3 RID: 31187 RVA: 0x001EA638 File Offset: 0x001E8838
		[CallerCount(0)]
		public unsafe static Mesh Get()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMesh.NativeMethodInfoPtr_Get_Public_Static_Mesh_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x001EA680 File Offset: 0x001E8880
		[CallerCount(0)]
		public unsafe static void Destroy()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalMesh.NativeMethodInfoPtr_Destroy_Public_Static_Void_0, 0, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079D5 RID: 31189 RVA: 0x001EA6B4 File Offset: 0x001E88B4
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalMesh()
		{
			Il2CppClassPointerStore<GlobalMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "GlobalMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalMesh>.NativeClassPtr);
			GlobalMesh.NativeFieldInfoPtr_ms_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalMesh>.NativeClassPtr, "ms_Mesh");
			GlobalMesh.NativeFieldInfoPtr_ms_DoubleSided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalMesh>.NativeClassPtr, "ms_DoubleSided");
			GlobalMesh.NativeMethodInfoPtr_Get_Public_Static_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMesh>.NativeClassPtr, 100673023);
			GlobalMesh.NativeMethodInfoPtr_Destroy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalMesh>.NativeClassPtr, 100673024);
		}

		// Token: 0x060079D6 RID: 31190 RVA: 0x00002988 File Offset: 0x00000B88
		public GlobalMesh(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x060079D7 RID: 31191 RVA: 0x001EA734 File Offset: 0x001E8934
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GlobalMesh>.NativeClassPtr));
			}
		}

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x060079D8 RID: 31192 RVA: 0x001EA748 File Offset: 0x001E8948
		// (set) Token: 0x060079D9 RID: 31193 RVA: 0x001EA773 File Offset: 0x001E8973
		public unsafe static Mesh ms_Mesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GlobalMesh.NativeFieldInfoPtr_ms_Mesh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalMesh.NativeFieldInfoPtr_ms_Mesh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x060079DA RID: 31194 RVA: 0x001EA788 File Offset: 0x001E8988
		// (set) Token: 0x060079DB RID: 31195 RVA: 0x001EA7A6 File Offset: 0x001E89A6
		public unsafe static bool ms_DoubleSided
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GlobalMesh.NativeFieldInfoPtr_ms_DoubleSided, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalMesh.NativeFieldInfoPtr_ms_DoubleSided, (void*)(&value));
			}
		}

		// Token: 0x04004E09 RID: 19977
		private static readonly IntPtr NativeFieldInfoPtr_ms_Mesh;

		// Token: 0x04004E0A RID: 19978
		private static readonly IntPtr NativeFieldInfoPtr_ms_DoubleSided;

		// Token: 0x04004E0B RID: 19979
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Mesh_0;

		// Token: 0x04004E0C RID: 19980
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_0;
	}
}
