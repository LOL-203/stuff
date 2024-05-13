using System;
using Il2CppSystem;
using UnhollowerBaseLib;
using UnhollowerBaseLib.Attributes;

namespace DPI.Octrees
{
	// Token: 0x020010CC RID: 4300
	public class PointBranch<T> : OctreeBranch<T, PointBranch<T>, OctreeObject<T>>
	{
		// Token: 0x0601448E RID: 83086 RVA: 0x0051ACD4 File Offset: 0x00518ED4
		[CallerCount(0)]
		public unsafe PointBranch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointBranch<T>>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointBranch<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0601448F RID: 83087 RVA: 0x0051AD20 File Offset: 0x00518F20
		// Note: this type is marked as 'beforefieldinit'.
		static PointBranch()
		{
			Il2CppClassPointerStore<PointBranch<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DPI.Octrees", "PointBranch`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointBranch<T>>.NativeClassPtr);
			PointBranch<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointBranch<T>>.NativeClassPtr, 100689250);
		}

		// Token: 0x06014490 RID: 83088 RVA: 0x0051AD9F File Offset: 0x00518F9F
		public PointBranch(IntPtr A_1) : base(A_1)
		{
		}

		// Token: 0x170072E5 RID: 29413
		// (get) Token: 0x06014491 RID: 83089 RVA: 0x0051ADA8 File Offset: 0x00518FA8
		[Obsolete("Use Il2CppType.Of<T>() instead. This will be removed in a future version of unhollower.")]
		public new static Type Il2CppType
		{
			get
			{
				return Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PointBranch<T>>.NativeClassPtr));
			}
		}

		// Token: 0x0400CF56 RID: 53078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
