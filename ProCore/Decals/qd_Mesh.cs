using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace ProCore.Decals
{
	// Token: 0x02000798 RID: 1944
	public class qd_Mesh : Il2CppSystem.Object
	{
		// Token: 0x0600A169 RID: 41321 RVA: 0x0028D9AC File Offset: 0x0028BBAC
		[CallerCount(0)]
		public unsafe static GameObject CreateDecal(Material mat, Rect uvCoords, float scale)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uvCoords;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(qd_Mesh.NativeMethodInfoPtr_CreateDecal_Public_Static_GameObject_Material_Rect_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new GameObject(intPtr2) : null;
		}

		// Token: 0x0600A16A RID: 41322 RVA: 0x0028DA30 File Offset: 0x0028BC30
		[CallerCount(0)]
		public unsafe static Mesh DecalMesh(string name, Material mat, Rect uvCoords, float scale)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uvCoords;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(qd_Mesh.NativeMethodInfoPtr_DecalMesh_Public_Static_Mesh_String_Material_Rect_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? new Mesh(intPtr2) : null;
		}

		// Token: 0x0600A16B RID: 41323 RVA: 0x0028DACC File Offset: 0x0028BCCC
		[CallerCount(0)]
		public unsafe qd_Mesh() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<qd_Mesh>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(qd_Mesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A16C RID: 41324 RVA: 0x0028DB18 File Offset: 0x0028BD18
		// Note: this type is marked as 'beforefieldinit'.
		static qd_Mesh()
		{
			Il2CppClassPointerStore<qd_Mesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ProCore.Decals", "qd_Mesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<qd_Mesh>.NativeClassPtr);
			qd_Mesh.NativeFieldInfoPtr_BILLBOARD_TRIANGLES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<qd_Mesh>.NativeClassPtr, "BILLBOARD_TRIANGLES");
			qd_Mesh.NativeFieldInfoPtr_BILLBOARD_VERTICES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<qd_Mesh>.NativeClassPtr, "BILLBOARD_VERTICES");
			qd_Mesh.NativeFieldInfoPtr_BILLBOARD_NORMALS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<qd_Mesh>.NativeClassPtr, "BILLBOARD_NORMALS");
			qd_Mesh.NativeFieldInfoPtr_BILLBOARD_TANGENTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<qd_Mesh>.NativeClassPtr, "BILLBOARD_TANGENTS");
			qd_Mesh.NativeFieldInfoPtr_BILLBOARD_UV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<qd_Mesh>.NativeClassPtr, "BILLBOARD_UV2");
			qd_Mesh.NativeMethodInfoPtr_CreateDecal_Public_Static_GameObject_Material_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<qd_Mesh>.NativeClassPtr, 100676107);
			qd_Mesh.NativeMethodInfoPtr_DecalMesh_Public_Static_Mesh_String_Material_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<qd_Mesh>.NativeClassPtr, 100676108);
			qd_Mesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<qd_Mesh>.NativeClassPtr, 100676109);
		}

		// Token: 0x0600A16D RID: 41325 RVA: 0x00002988 File Offset: 0x00000B88
		public qd_Mesh(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x0600A16E RID: 41326 RVA: 0x0028DBE8 File Offset: 0x0028BDE8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<qd_Mesh>.NativeClassPtr));
			}
		}

		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x0600A16F RID: 41327 RVA: 0x0028DBFC File Offset: 0x0028BDFC
		// (set) Token: 0x0600A170 RID: 41328 RVA: 0x0028DC27 File Offset: 0x0028BE27
		public unsafe static Il2CppStructArray<int> BILLBOARD_TRIANGLES
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(qd_Mesh.NativeFieldInfoPtr_BILLBOARD_TRIANGLES, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<int>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(qd_Mesh.NativeFieldInfoPtr_BILLBOARD_TRIANGLES, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x0600A171 RID: 41329 RVA: 0x0028DC3C File Offset: 0x0028BE3C
		// (set) Token: 0x0600A172 RID: 41330 RVA: 0x0028DC67 File Offset: 0x0028BE67
		public unsafe static Il2CppStructArray<Vector3> BILLBOARD_VERTICES
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(qd_Mesh.NativeFieldInfoPtr_BILLBOARD_VERTICES, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<Vector3>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(qd_Mesh.NativeFieldInfoPtr_BILLBOARD_VERTICES, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039DE RID: 14814
		// (get) Token: 0x0600A173 RID: 41331 RVA: 0x0028DC7C File Offset: 0x0028BE7C
		// (set) Token: 0x0600A174 RID: 41332 RVA: 0x0028DCA7 File Offset: 0x0028BEA7
		public unsafe static Il2CppStructArray<Vector3> BILLBOARD_NORMALS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(qd_Mesh.NativeFieldInfoPtr_BILLBOARD_NORMALS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<Vector3>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(qd_Mesh.NativeFieldInfoPtr_BILLBOARD_NORMALS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039DF RID: 14815
		// (get) Token: 0x0600A175 RID: 41333 RVA: 0x0028DCBC File Offset: 0x0028BEBC
		// (set) Token: 0x0600A176 RID: 41334 RVA: 0x0028DCE7 File Offset: 0x0028BEE7
		public unsafe static Il2CppStructArray<Vector4> BILLBOARD_TANGENTS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(qd_Mesh.NativeFieldInfoPtr_BILLBOARD_TANGENTS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<Vector4>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(qd_Mesh.NativeFieldInfoPtr_BILLBOARD_TANGENTS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039E0 RID: 14816
		// (get) Token: 0x0600A177 RID: 41335 RVA: 0x0028DCFC File Offset: 0x0028BEFC
		// (set) Token: 0x0600A178 RID: 41336 RVA: 0x0028DD27 File Offset: 0x0028BF27
		public unsafe static Il2CppStructArray<Vector2> BILLBOARD_UV2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(qd_Mesh.NativeFieldInfoPtr_BILLBOARD_UV2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? new Il2CppStructArray<Vector2>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(qd_Mesh.NativeFieldInfoPtr_BILLBOARD_UV2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006696 RID: 26262
		private static readonly IntPtr NativeFieldInfoPtr_BILLBOARD_TRIANGLES;

		// Token: 0x04006697 RID: 26263
		private static readonly IntPtr NativeFieldInfoPtr_BILLBOARD_VERTICES;

		// Token: 0x04006698 RID: 26264
		private static readonly IntPtr NativeFieldInfoPtr_BILLBOARD_NORMALS;

		// Token: 0x04006699 RID: 26265
		private static readonly IntPtr NativeFieldInfoPtr_BILLBOARD_TANGENTS;

		// Token: 0x0400669A RID: 26266
		private static readonly IntPtr NativeFieldInfoPtr_BILLBOARD_UV2;

		// Token: 0x0400669B RID: 26267
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecal_Public_Static_GameObject_Material_Rect_Single_0;

		// Token: 0x0400669C RID: 26268
		private static readonly IntPtr NativeMethodInfoPtr_DecalMesh_Public_Static_Mesh_String_Material_Rect_Single_0;

		// Token: 0x0400669D RID: 26269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
