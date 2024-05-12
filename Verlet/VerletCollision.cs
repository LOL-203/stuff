using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace Verlet
{
	// Token: 0x020008F8 RID: 2296
	public static class VerletCollision : Il2CppSystem.Object
	{
		// Token: 0x0600BBEC RID: 48108 RVA: 0x003011D8 File Offset: 0x002FF3D8
		[CallerCount(0)]
		public unsafe static bool Collision(Matrix4x4 localToWorld, Matrix4x4 worldToLocal, Vector3 point, ref VerletCollisionHit hit)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref localToWorld;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldToLocal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VerletCollision.NativeMethodInfoPtr_Collision_Public_Static_Boolean_Matrix4x4_Matrix4x4_Vector3_byref_VerletCollisionHit_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BBED RID: 48109 RVA: 0x00301265 File Offset: 0x002FF465
		// Note: this type is marked as 'beforefieldinit'.
		static VerletCollision()
		{
			Il2CppClassPointerStore<VerletCollision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Verlet", "VerletCollision");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerletCollision>.NativeClassPtr);
			VerletCollision.NativeMethodInfoPtr_Collision_Public_Static_Boolean_Matrix4x4_Matrix4x4_Vector3_byref_VerletCollisionHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerletCollision>.NativeClassPtr, 100678589);
		}

		// Token: 0x0600BBEE RID: 48110 RVA: 0x00002988 File Offset: 0x00000B88
		public VerletCollision(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x17004311 RID: 17169
		// (get) Token: 0x0600BBEF RID: 48111 RVA: 0x0030129E File Offset: 0x002FF49E
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<VerletCollision>.NativeClassPtr));
			}
		}

		// Token: 0x04007886 RID: 30854
		private static readonly IntPtr NativeMethodInfoPtr_Collision_Public_Static_Boolean_Matrix4x4_Matrix4x4_Vector3_byref_VerletCollisionHit_0;
	}
}
