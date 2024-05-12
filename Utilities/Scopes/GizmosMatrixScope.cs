using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace Utilities.Scopes
{
	// Token: 0x02000987 RID: 2439
	public class GizmosMatrixScope : Il2CppSystem.Object
	{
		// Token: 0x0600CE37 RID: 52791 RVA: 0x003345D0 File Offset: 0x003327D0
		[CallerCount(0)]
		public unsafe GizmosMatrixScope(Vector3 position, Quaternion rotation, Vector3 scale) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmosMatrixScope>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmosMatrixScope.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600CE38 RID: 52792 RVA: 0x00334654 File Offset: 0x00332854
		[CallerCount(0)]
		public unsafe GizmosMatrixScope(Transform transform) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmosMatrixScope>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmosMatrixScope.NativeMethodInfoPtr__ctor_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600CE39 RID: 52793 RVA: 0x003346B8 File Offset: 0x003328B8
		[CallerCount(0)]
		public unsafe GizmosMatrixScope(Matrix4x4 matrix) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmosMatrixScope>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref matrix;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmosMatrixScope.NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600CE3A RID: 52794 RVA: 0x00334718 File Offset: 0x00332918
		[CallerCount(0)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmosMatrixScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600CE3B RID: 52795 RVA: 0x0033475C File Offset: 0x0033295C
		// Note: this type is marked as 'beforefieldinit'.
		static GizmosMatrixScope()
		{
			Il2CppClassPointerStore<GizmosMatrixScope>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Utilities.Scopes", "GizmosMatrixScope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmosMatrixScope>.NativeClassPtr);
			GizmosMatrixScope.NativeFieldInfoPtr__oldScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmosMatrixScope>.NativeClassPtr, "_oldScope");
			GizmosMatrixScope.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmosMatrixScope>.NativeClassPtr, 100679181);
			GizmosMatrixScope.NativeMethodInfoPtr__ctor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmosMatrixScope>.NativeClassPtr, 100679182);
			GizmosMatrixScope.NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmosMatrixScope>.NativeClassPtr, 100679183);
			GizmosMatrixScope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmosMatrixScope>.NativeClassPtr, 100679184);
		}

		// Token: 0x0600CE3C RID: 52796 RVA: 0x00002988 File Offset: 0x00000B88
		public GizmosMatrixScope(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004B1A RID: 19226
		// (get) Token: 0x0600CE3D RID: 52797 RVA: 0x003347F0 File Offset: 0x003329F0
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<GizmosMatrixScope>.NativeClassPtr));
			}
		}

		// Token: 0x17004B1B RID: 19227
		// (get) Token: 0x0600CE3E RID: 52798 RVA: 0x00334804 File Offset: 0x00332A04
		// (set) Token: 0x0600CE3F RID: 52799 RVA: 0x0033482C File Offset: 0x00332A2C
		public unsafe Matrix4x4 _oldScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmosMatrixScope.NativeFieldInfoPtr__oldScope);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmosMatrixScope.NativeFieldInfoPtr__oldScope)) = value;
			}
		}

		// Token: 0x04008262 RID: 33378
		private static readonly IntPtr NativeFieldInfoPtr__oldScope;

		// Token: 0x04008263 RID: 33379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Quaternion_Vector3_0;

		// Token: 0x04008264 RID: 33380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_0;

		// Token: 0x04008265 RID: 33381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_0;

		// Token: 0x04008266 RID: 33382
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
